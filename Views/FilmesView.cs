﻿using Sunny.UI;
using Aniflix.Models;
using Aniflix.Services;
using Aniflix.Functions;
using FontAwesome.Sharp.Material;

namespace Aniflix.Views
{
    public partial class FilmesView : UIForm
    {
        public FilmesView()
        {
            InitializeComponent();
        }

        private void FilmesView_Load(object sender, EventArgs e)
        {
            //GlobalFunctions.ApplyTheme(this);
        }

        private void CodigoText_Leave(object sender, EventArgs e)
        {
            var filmesService = new FilmesServices();
            var filmesModel = new FilmesModel();

            filmesService.GivenData(CodigoText, TituloText, SinopseText, Titulo_OriginalText, Data_LancamentoText, Titulo_AlternativoText, TagsText, GeneroText, DiretorText, EstrelasText, EstudioText);

        }