using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;

// TODO: siga estas etapas para habilitar o item da Faixa de Opções (XML):

// 1: Copie o bloco de código a seguir para a classe ThisAddin, ThisWorkbook ou ThisDocument.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon2();
//  }

// 2. Crie métodos de retorno de chamadas na região "Retornos de Chamada da Faixa de Opções" desta classe para manipular ações do usuário
//    ações, como clicar em um botão. Observação: se você tiver exportado esta Faixa de Opções do designer da Faixa de Opções,
//    mova seu código dos manipuladores de evento para os métodos de retorno de chamada e modifique o código para trabalhar com
//    o modelo de programação de extensibilidade da Faixa de Opções (RibbonX).

// 3. Atribua atributos às marcas de controle no arquivo XML da Faixa de Opções para identificar os métodos de retorno de chamada apropriados em seu código.  

// Para obter mais informações, consulte a documentação XML da Faixa de Opções na Ajuda do Visual Studio Tools para Office.


namespace OutlookAddIn2
{
    [ComVisible(true)]
    public class Ribbon2 : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon2()
        {
        }

        #region Membros de IRibbonExtensibility

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("OutlookAddIn2.Ribbon2.xml");
        }

        #endregion

        #region Retornos de Chamada da Faixa de Opções
        //Crie métodos de retorno de chamada aqui. Para obter mais informações sobre como adicionar métodos de retorno de chamada, visite https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        #region Auxiliares

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion

        public void showWinForm(Office.IRibbonControl control)
        {
            Form1 form = new Form1();

            form.Show();
        }

        public void showWinForm2(Office.IRibbonControl control)
        {
            Form2 form = new Form2();

            form.Size = new Size(1500, 500);
            form.Show();
        }
    }
}
