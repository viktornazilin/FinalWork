﻿using AnimalNurserynamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalNurseryDesktop
{
    public partial class FormUpdateAnimal : Form
    {
        HomeFriend _homeFriend = new HomeFriend();
        public FormUpdateAnimal(HomeFriend item)
        {
            InitializeComponent();
            _homeFriend = item;
            fillForm();
        }
        public FormUpdateAnimal(ListViewItem item)
        {
            InitializeComponent();
            _homeFriend.Id = int.Parse(item.SubItems[0].Text);
            _homeFriend.Name = item.SubItems[1].Text;
            switch (item.SubItems[2].Text)
            {
                case "Кошка":
                    _homeFriend.Type = "Cat";
                    break;
                case "Собака":
                    _homeFriend.Type = "Dog";
                    break;
                case "Хомяк":
                    _homeFriend.Type = "Hamster";
                    break;
                case "Осёл":
                    _homeFriend.Type = "Donkey";
                    break;
                case "Лошадь":
                    _homeFriend.Type = "Horse";
                    break;
                case "Верблюд":
                    _homeFriend.Type = "Camel";
                    break;
            }
            _homeFriend.Commands = item.SubItems[3].Text.Trim(' ')
                                                    .Split(',')
                                                    .ToList();
            _homeFriend.Birthday = DateTime.Parse(item.SubItems[4].Text);
            fillForm();
        }

        private void fillForm()
        {
            textBoxName.Text = _homeFriend.Name;
            //textBoxName.ReadOnly = true;

            //comboBoxType.Text = _homeFriend.Type;

            switch (_homeFriend.Type)
            {
                case "Cat":
                    comboBoxType.SelectedIndex = 0;
                    break;
                case "Dog":
                    comboBoxType.SelectedIndex = 1;
                    break;
                case "Hamster":
                    comboBoxType.SelectedIndex = 2;
                    break;
                case "Donkey":
                    comboBoxType.SelectedIndex = 3;
                    break;
                case "Horse":
                    comboBoxType.SelectedIndex = 4;
                    break;
                case "Camel":
                    comboBoxType.SelectedIndex = 5;
                    break;
            }

            dateTimePickerBirthday.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthday.Value = _homeFriend.Birthday.Date;
            // dateTimePickerBirthday.Enabled = false;

            textBoxCommands.Text = string.Join(", ", _homeFriend.Commands);

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateHomeFriendsRequest animal = new UpdateHomeFriendsRequest();
            animal.Id = _homeFriend.Id;
            animal.Name = textBoxName.Text;
            animal.Commands = textBoxCommands.Text;
            switch (comboBoxType.Text)
            {
                case "Кошка":
                    animal.Type = "Cat";
                    break;
                case "Собака":
                    animal.Type = "Dog";
                    break;
                case "Хомяк":
                    animal.Type = "Hamster";
                    break;
                case "Осёл":
                    animal.Type = "Donkey";
                    break;
                case "Лошадь":
                    animal.Type = "Horse";
                    break;
                case "Верблюд":
                    animal.Type = "Camel";
                    break;
            }
            animal.Birthday = dateTimePickerBirthday.Value;
           
            AnimalNurseryClient animalNurseryClient = new AnimalNurseryClient("http://localhost:5244/",
            new System.Net.Http.HttpClient());

            animalNurseryClient.UpdateAsync(animal);

            Close();
        }
    }
}
