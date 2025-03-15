using System;
using Sunny.UI;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Aniflix.Entities;

namespace Aniflix.Views
{
    public partial class SeriesView : UIForm
    {
        public SeriesView()
        {
            InitializeComponent();
        }

        private void SeriesView_Load(object sender, EventArgs e)
        {

        }


        #region "ChangeData"
        private void ChangeData()
        {

            var services = new BaseSeriesEntities(
                titulo: TituloText.Text,
                audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: SinopseText.Text,
                tituloOriginal: TituloOriginalText.Text,
                dataLancamento: DataLancamentoText.Text,
                tituloAlternativo: TituloAlternativoText.Text,
                paisOrigem: PaisOrigemText.Text,
                idiomaOriginal: IdiomaOriginalText.Text,
                serie: SerieText.Text,
                autores: AutoresText.Text,
                criadores: CriadoresText.Text,
                obraOriginal: ObraOriginalText.Text,
                genero: GeneroText.Text,
                tags: TagsText.Text,
                diretor: DiretorText.Text,
                estrelas: EstrelasText.Text,
                estudio: EstudioText.Text,
                mcu: FaseMCUText.Text
            );

            ResumoText.Text = services.GetFormattedText();
        }

        #endregion





    }
}
