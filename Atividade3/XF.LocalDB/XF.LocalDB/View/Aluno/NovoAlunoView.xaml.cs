﻿using System;

using Xamarin.Forms;
using XF.LocalDB.ViewModel;

namespace XF.LocalDB.View.Aluno
{
    public partial class NovoAlunoView : ContentPage
    {
        public static AlunoViewModel AlunoVM { get; set; }

        public NovoAlunoView()
        {
            InitializeComponent();
        } 
        //private int alunoId = 0;
        //public NovoAlunoView()
        //{
        //    InitializeComponent();
        //}
        //public NovoAlunoView(int Id)
        //{
        //    InitializeComponent();
        //    var aluno = App.AlunoModel.GetAluno(Id);
        //    txtNome.Text = aluno.Nome;
        //    txtRM.Text = aluno.RM;
        //    txtEmail.Text = aluno.Email;
        //    IsAprovado.IsToggled = aluno.Aprovado;
        //    alunoId = aluno.Id;
        //}
        //public void OnSalvar(object sender, EventArgs args)
        //{
        //    XF.LocalDB.Model.Aluno aluno = new XF.LocalDB.Model.Aluno(){
        //        Nome = txtNome.Text,
        //        RM = txtRM.Text,
        //        Email = txtEmail.Text,
        //        Aprovado = IsAprovado.IsToggled, Id = alunoId
        //    };
        //    Limpar();
        //    App.AlunoModel.SalvarAluno(aluno);
        //    Navigation.PopAsync();
        //}
        //public void OnCancelar(object sender, EventArgs args)
        //{
        //    Limpar();
        //    Navigation.PopAsync();
        //}
        //private void Limpar()
        //{
        //    txtNome.Text = txtRM.Text = txtEmail.Text = string.Empty;
        //    IsAprovado.IsToggled = false;
        //}
    }
}
