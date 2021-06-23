using Session_11_Exercises.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11_Exercises.WUI {
    public partial class ViewForm : Form {


        public EntityTypeEnum Type { get; set; }
        public University MasterData { get; set; }
        public List<string> ViewData = new List<string>();

        public ViewForm() {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {
            LoadData();

        }

        private void LoadData() {
            foreach (string item in ViewData) {
                ctrlViewList.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            EditSelectedRecord();
        }

        private void ctrlViewList_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecord();
        }

        private void EditSelectedRecord() {

            Guid id = GetListID();
            Object editObject = null;

            // assign edit properties by type
            switch (Type) {
                case EntityTypeEnum.Course:
                    editObject = MasterData.Courses.Find(x => x.ID == id);
                    //RefreshItems();
                    break;

                case EntityTypeEnum.Student:
                    editObject = MasterData.Students.Find(x => x.ID == id);
                    break;

                case EntityTypeEnum.Professor:
                    editObject = MasterData.Professors.Find(x => x.ID == id);
                    break;

                default:
                    break;
            }

            // open edit form
            EditForm form = new EditForm();
            form.Type = Type;
            form.EditObject = editObject;
            form.ShowDialog();

            RefreshItems();

        }

        private Guid GetListID() {

            object listSelection = ctrlViewList.SelectedItem;
            List<string> listParse = listSelection.ToString().Split(' ').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));
            return id;
        }

        private void btnDelete_Click(object sender, EventArgs e) {

            Guid id = GetListID();
            // assign edit properties by type
            switch (Type) {
                case EntityTypeEnum.Course:

                    MasterData.Courses.RemoveAll(x => x.ID == id);
                    //RefreshItems();
                    break;

                case EntityTypeEnum.Student:

                    MasterData.Students.RemoveAll(x => x.ID == id);
                    break;

                case EntityTypeEnum.Professor:
                    MasterData.Professors.RemoveAll(x => x.ID == id);
                    break;

                default:
                    break;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            RefreshItems();
        }

        private void RefreshItems() {
            switch (Type) {
                case EntityTypeEnum.Course:

                    ctrlViewList.Items.Clear();
                    ViewData.Clear();
                    foreach (Course item in MasterData.Courses) {

                        ViewData.Add(string.Format("ID={2} \t Code={0} \t Subject={1} ", item.Code, item.Subject, item.ID));
                        
                    }

                    LoadData();

                    break;

                case EntityTypeEnum.Student:
                    ctrlViewList.Items.Clear();
                    ViewData.Clear();
                    foreach (Student item in MasterData.Students) {

                        ViewData.Add(string.Format("ID={3} \t Name={0} \t Surname={1} \t RegistrationNumber={2}", item.Name, item.Surname, item.RegistrationNumber, item.ID));
                    }

                    LoadData();
                    break;

                case EntityTypeEnum.Professor:
                    ctrlViewList.Items.Clear();
                    ViewData.Clear();
                    foreach (Professor item in MasterData.Professors) {

                        ViewData.Add(string.Format("ID-{3} \t Name={0} \t Surname={1} \t Rank={2}", item.Name, item.Surname, item.Rank, item.ID));
                    }

                    LoadData();
                    break;

                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddEntity(Type);
            // ???
            //RefreshItems();
        }


        private void AddEntity(EntityTypeEnum entityType) {

            switch (entityType) {
                case EntityTypeEnum.Course:
                    Course courseEntity = new Course();
                    EditForm courseForm = new EditForm();
                    
                    courseForm.Type = entityType;
                    courseForm.EditObject = courseEntity;
                    courseForm.Show();

                    //if (courseForm.ShowDialog() == DialogResult.OK) {
                    MasterData.Courses.Add(courseEntity);
                    RefreshItems();
                   // }
                    break;

                case EntityTypeEnum.Student:
                    Student studentEntity = new Student();
                    EditForm studentForm = new EditForm();

                    studentForm.Type = entityType;
                    studentForm.EditObject = studentEntity;
                    studentForm.Show();
                    //if (studentForm.ShowDialog() == DialogResult.OK) {
                    MasterData.Students.Add(studentEntity);
                    // }
                    break;

                case EntityTypeEnum.Professor:
                    Professor professorEntity = new Professor();
                    EditForm professorForm = new EditForm();


                    professorForm.Type = entityType;
                    professorForm.EditObject = professorEntity;
                    professorForm.Show();

                    //if (professorForm.ShowDialog() == DialogResult.OK) {
                    MasterData.Professors.Add(professorEntity);
                    //}
                    break;
            }


            

        }
    }
}
