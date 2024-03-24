using System;
using System.Windows.Forms;

namespace OutlookAddIn2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar avisos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(50, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(768, 73);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(180, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(260, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(50, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(768, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "alex.satorres@drapnorte.gov.pt",
            "alzira.silva@drapnorte.gov.pt",
            "ana.justo@drapnorte.gov.pt",
            "analencastre@drapnorte.gov.pt",
            "anabela@drapnorte.gov.pt",
            "angelo.carneiro@drapnorte.gov.pt",
            "antonio.meireles@drapnorte.gov.pt",
            "avisos.edm@drapnorte.gov.pt",
            "carmindatavares@drapnorte.gov.pt",
            "luis.gaspar@drapnorte.gov.pt",
            "lserapicos@drapnorte.gov.pt",
            "daniela.monteiro@drapnorte.gov.pt",
            "emilia.figueiredo@drapnorte.gov.pt",
            "fatima.sousa@drapnorte.gov.pt",
            "felisbina.ferreira@drapnorte.gov.pt",
            "fernanda.reis@drapnorte.gov.pt",
            "gisela.chicau@drapnorte.gov.pt",
            "graziela.pimenta@drapnorte.gov.pt",
            "henrique.palma@drapnorte.gov.pt",
            "ilda.curtinhas@drapnorte.gov.pt",
            "j.candoso@drapnorte.gov.pt",
            "josematias@drapnorte.gov.pt",
            "jose.reis@drapnorte.gov.pt",
            "manuel.matos@drapnorte.gov.pt",
            "helena.fonseca@drapnorte.gov.pt",
            "fatima.goncalves@drapnorte.gov.pt",
            "mjose.bento@drapnorte.gov.pt",
            "mlmarques@drapnorte.gov.pt",
            "eugenia.mimoso@drapnorte.gov.pt",
            "lourdestavares@drapnorte.gov.pt",
            "fatima.venade@drapnorte.gov.pt",
            "m.rebelo@drapnorte.gov.pt",
            "natalia.melo@drapnorte.gov.pt",
            "ana.costa@drapnorte.gov.pt",
            "maria.castro@drapnorte.gov.pt",
            "paula.cunha@drapnorte.gov.pt",
            "paulo.maia@drapnorte.gov.pt",
            "manuela.pinto@drapnorte.gov.pt",
            "rosa.silvafereira@drapnorte.gov.pt",
            "rosamaria@drapnorte.gov.pt",
            "sandra.martins@drapnorte.gov.pt",
            "vferreira@drapnorte.gov.pt",
            "adelaide.inacio@drapnorte.gov.pt",
            "adelino.bernardo@drapnorte.gov.pt",
            "adilia.domingues@drapnorte.gov.pt",
            "adolfo.rodrigues@drapnorte.gov.pt",
            "acamarinha@drapnorte.gov.pt",
            "anacarreiro@drapnorte.gov.pt",
            "ana.moldao@drapnorte.gov.pt",
            "anabela.pereira@drapnorte.gov.pt",
            "antonio.lopes@drapnorte.gov.pt",
            "armindo.gomes@drapnorte.gov.pt",
            "b.mota@drapnorte.gov.pt",
            "mariafernandes@drapnorte.gov.pt",
            "paula.duarte@drapnorte.gov.pt",
            "carla.alves@drapnorte.gov.pt",
            "carlos.carvalho@drapnorte.gov.pt",
            "gama@drapnorte.gov.pt",
            "toze@drapnorte.gov.pt",
            "celina.reis@drapnorte.gov.pt",
            "dolores.costa@drapnorte.gov.pt",
            "elsa.conde@drapnorte.gov.pt",
            "fernanda.pereira@drapnorte.gov.pt",
            "ana.ribeiro@drapnorte.gov.pt",
            "filomena.machado@drapnorte.gov.pt",
            "h.santos@drapnorte.gov.pt",
            "i.ramadas@drapnorte.gov.pt",
            "isabel.escudeiro@drapnorte.gov.pt",
            "isabel.sousa@drapnorte.gov.pt",
            "joaquimalves@drapnorte.gov.pt",
            "jose.alves@drapnorte.gov.pt",
            "jbotelho@drapnorte.gov.pt",
            "j.rocha.f@drapnorte.gov.pt",
            "josepereira@drapnorte.gov.pt",
            "jose.roque@drapnorte.gov.pt",
            "josevieira@drapnorte.gov.pt",
            "aurelia.nunes@drapnorte.gov.pt",
            "leonor.cordeiro@drapnorte.gov.pt",
            "lucia.ferreira@drapnorte.gov.pt",
            "Luis.brandao@drapnorte.gov.pt",
            "albano.pereira@drapnorte.gov.pt",
            "manuel.santos@drapnorte.gov.pt",
            "manuelacondado@drapnorte.gov.pt",
            "margarida.teixeira@drapnorte.gov.pt",
            "carmo.araujo@drapnorte.gov.pt",
            "m.melo@drapnorte.gov.pt",
            "mariadrummond@drapnorte.gov.pt",
            "conceicao.ferreira@drapnorte.gov.pt",
            "mariajoao@drapnorte.gov.pt",
            "mariamanuel@drapnorte.gov.pt",
            "graca.oliveira@drapnorte.gov.pt",
            "mj.quintao@drapnorte.gov.pt",
            "fatima.silva@drapnorte.gov.pt",
            "lurdessilva@drapnorte.gov.pt",
            "mariosousa@drapnorte.gov.pt",
            "martamoura@drapnorte.gov.pt",
            "manuel.moreira@drapnorte.gov.pt",
            "carlos.sousa@drapnorte.gov.pt",
            "orlando.meireles@drapnorte.gov.pt",
            "oscar.esteves@drapnorte.gov.pt",
            "paulassis@drapnorte.gov.pt",
            "ana.borges@drapnorte.gov.pt",
            "paulo.fernandes@drapnorte.gov.pt",
            "paulopinto@drapnorte.gov.pt",
            "cconstantinescu@drapnorte.gov.pt",
            "pfpereira@drapnorte.gov.pt",
            "rosa.andrade@drapnorte.gov.pt",
            "maria.gomes@drapnorte.gov.pt",
            "rosalia.oliveira@drapnorte.gov.pt",
            "rui.borges@drapnorte.gov.pt",
            "silvina.graca@drapnorte.gov.pt",
            "lsobraldias@drapnorte.gov.pt",
            "teresa.morais@drapnorte.gov.pt",
            "esterpinheiro@drapnorte.gov.pt",
            "adelaide.fernandes@drapnorte.gov.pt",
            "antoniobarros@drapnorte.gov.pt",
            "cristiana.costa@drapnorte.gov.pt",
            "eduardo.tavares@drapnorte.gov.pt",
            "francisco.gilberto@drapnorte.gov.pt",
            "francisco.ribeiro@drapnorte.gov.pt",
            "isabelpires@drapnorte.gov.pt",
            "fmachado@drapnorte.gov.pt",
            "liliana.monteiro@drapnorte.gov.pt",
            "manuela.costa@drapnorte.gov.pt",
            "olga.borges@drapnorte.gov.pt",
            "r.martins@drapnorte.gov.pt",
            "jose.m.pinto@drapnorte.gov.pt",
            "isabelcorreia@drapnorte.gov.pt",
            "helder.sanfins@drapnorte.gov.pt",
            "antonio.graca@drapnorte.gov.pt",
            "aanjos.meireles@drapnorte.gov.pt",
            "carlos.agrelos@drapnorte.gov.pt",
            "jsribeiro@drapnorte.gov.pt",
            "celeste.morais@drapnorte.gov.pt",
            "jose.goncalves@drapnorte.gov.pt",
            "jose.marcal@drapnorte.gov.pt",
            "silva.barroso@drapnorte.gov.pt",
            "joaquim.ferreira@drapnorte.gov.pt",
            "Joaquina.costa@drapnorte.gov.pt ",
            "mgraca.agrasilva@drapnorte.gov.pt",
            "carlos.torres@drapnorte.gov.pt",
            "madias@drapnorte.gov.pt",
            "sergio.fonseca@drapnorte.gov.pt",
            "abilio.geraldes@drapnorte.gov.pt",
            "antonio.guimaraes@drapnorte.gov.pt",
            "jose.madureira@drapnorte.gov.pt",
            "jmendes.ferreira@drapnorte.gov.pt",
            "antonio.pires@drapnorte.gov.pt",
            "antonio.sousa@drapnorte.gov.pt ",
            "raul.salgado@drapnorte.gov.pt",
            "ana.guedes@drapnorte.gov.pt",
            "deolinda.duarte@drapnorte.gov.pt",
            "elisabete.azevedo@drapnorte.gov.pt",
            "ema.vale@drapnorte.gov.pt",
            "isabel.reis@drapnorte.gov.pt",
            "licinio.monteiro@drapnorte.gov.pt",
            "margaridanovo@drapnorte.gov.pt",
            "maria.santos@drapnorte.gov.pt",
            "maria.soares@drapnorte.gov.pt",
            "miguel.peixoto@drapnorte.gov.pt",
            "orlando.figueiredo@drapnorte.gov.pt",
            "oscar.pereira@drapnorte.gov.pt",
            "agostinho.amorim@drapnorte.gov.pt",
            "guiomar.alemao@drapnorte.gov.pt",
            "martamartins@drapnorte.gov.pt",
            "analameiras@drapnorte.gov.pt",
            "gracajesus@drapnorte.gov.pt",
            "abreu.lima@drapnorte.gov.pt",
            "afonsomanuel@drapnorte.gov.pt",
            "estela.almeida@drapnorte.gov.pt",
            "regina.rocha@drapnorte.gov.pt",
            "manuela.pequeno@drapnorte.gov.pt",
            "ana.guerra@drapnorte.gov.pt",
            "antonio.pocas@drapnorte.gov.pt",
            "moraissoares@drapnorte.gov.pt",
            "carlos.castro@drapnorte.gov.pt",
            "Aurora.jacob@drapnorte.gov.pt",
            "isabel.barrote@drapnorte.gov.pt",
            "clara.goncalves@drapnorte.gov.pt",
            "graca.martins@drapnorte.gov.pt",
            "amaliaxavier@drapnorte.gov.pt",
            "sofia.santos@drapnorte.gov.pt",
            "eduarda@drapnorte.gov.pt",
            "paula.pequito@drapnorte.gov.pt",
            "ruicoimbra@drapnorte.gov.pt",
            "americo.vieira@drapnorte.gov.pt",
            "joao.fernandes@drapnorte.gov.pt",
            "carloscosta@drapnorte.gov.pt",
            "cosmeneves@drapnorte.gov.pt",
            "ruivasconcelos@drapnorte.gov.pt",
            "luisacasas@drapnorte.gov.pt",
            "jorgepncosta@drapnorte.gov.pt",
            "teresa.serrano@drapnorte.gov.pt",
            "adelinosoares@drapnorte.gov.pt",
            "jmafonso@drapnorte.gov.pt",
            "j.henrique@drapnorte.gov.pt",
            "manuel.soares@drapnorte.gov.pt",
            "auroraalves@drapnorte.gov.pt",
            "celeste.freire@drapnorte.gov.pt",
            "anabela.freitas@drapnorte.gov.pt",
            "cacilda.coelho@drapnorte.gov.pt",
            "daniel.teixeira@drapnorte.gov.pt",
            "mariaaraujo@drapnorte.gov.pt",
            "paulo.sousa@drapnorte.gov.pt",
            "fernando.miranda@drapnorte.gov.pt",
            "ana.amorim@drapnorte.gov.pt",
            "susana.saraiva@drapnorte.gov.pt",
            "l.hipolito@drapnorte.gov.pt",
            "ema.goncalves@drapnorte.gov.pt",
            "rui.tecedeiro@drapnorte.gov.pt",
            "dulce.fernandes@drapnorte.gov.pt",
            "jvilela@drapnorte.gov.pt",
            "henriqueta.silva@drapnorte.gov.pt",
            "amelia.magalhaes@drapnorte.gov.pt",
            "salome.mourao@drapnorte.gov.pt",
            "jcsilva@drapnorte.gov.pt",
            "j.oliveira@drapnorte.gov.pt",
            "jose.macaira@drapnorte.gov.pt",
            "pessegueiro@drapnorte.gov.pt",
            "souto@drapnorte.gov.pt",
            "abel.nogueira@drapnorte.gov.pt",
            "maria.ceu@drapnorte.gov.pt",
            "celeste.marques@drapnorte.gov.pt",
            "durval.moreira@drapnorte.gov.pt",
            "oscar.c@drapnorte.gov.pt",
            "cribeiro@drapnorte.gov.pt",
            "fcalheiros@drapnorte.gov.pt",
            "carlos.silva@drapnorte.gov.pt",
            "sergio.a.e.araujo@drapnorte.gov.pt",
            "antonio.ferreira@drapnorte.gov.pt",
            "adelino.ribeiro@drapnorte.gov.pt",
            "augusto.assuncao@drapnorte.gov.pt",
            "antonio.fernandes@drapnorte.gov.pt",
            "mdias@drapnorte.gov.pt",
            "bgoncalves@drapnorte.gov.pt",
            "rosa.carvalho@drapnorte.gov.pt",
            "joaoferreira@drapnorte.gov.pt",
            "amadeu.fernandes@drapnorte.gov.pt",
            "jeronimo-cortereal@drapnorte.gov.pt",
            "antonioalvespinto@drapnorte.gov.pt",
            "agostinho.leite@drapnorte.gov.pt",
            "sara.sobral@drapnorte.gov.pt",
            "andreafonso@drapnorte.gov.pt",
            "alopes.fernandes@drapnorte.gov.pt",
            "artur.santos@drapnorte.gov.pt",
            "eduardo.abade@drapnorte.gov.pt",
            "ana.fonseca@drapnorte.gov.pt",
            "fernando.fernandes@drapnorte.gov.pt",
            "f.guia@drapnorte.gov.pt",
            "higino.vieira@drapnorte.gov.pt",
            "teresa.monte@drapnorte.gov.pt",
            "manuel.oliveira@drapnorte.gov.pt",
            "joaquim.moreira@drapnorte.gov.pt",
            "augustolisboa@drapnorte.gov.pt",
            "mariadeus@drapnorte.gov.pt",
            "rosaferreira@drapnorte.gov.pt",
            "orlando.silva@drapnorte.gov.pt",
            "ercilia.moura@drapnorte.gov.pt",
            "alda.viana@drapnorte.gov.pt",
            "jose.parente@drapnorte.gov.pt",
            "paulo.sampaio@drapnorte.gov.pt",
            "hilario.martins@drapnorte.gov.pt",
            "emilia.silva@drapnorte.gov.pt",
            "fernando.cerqueira@drapnorte.gov.pt",
            "teresa.pereira@drapnorte.gov.pt",
            "armindo.rocha@drapnorte.gov.pt",
            "fernando.gomes@drapnorte.gov.pt",
            "adelia.pereira@drapnorte.gov.pt",
            "goretti.cerqueira@drapnorte.gov.pt",
            "rosa.portela@drapnorte.gov.pt",
            "tome.pona@drapnorte.gov.pt",
            "t.ribeiro@drapnorte.gov.pt",
            "ana.macedo@drapnorte.gov.pt",
            "alcina.oliveira@drapnorte.gov.pt",
            "antonio.cabeleira@drapnorte.gov.pt",
            "amaldonado@drapnorte.gov.pt",
            "antonio.guerra@drapnorte.gov.pt",
            "rui.guerra@drapnorte.gov.pt",
            "casimiro.monteiro@drapnorte.gov.pt",
            "jose.lavrador@drapnorte.gov.pt",
            "carlos.martins@drapnorte.gov.pt",
            "norberto.santos@drapnorte.gov.pt",
            "ana.pires@drapnorte.gov.pt",
            "mlurdes.pires@drapnorte.gov.pt",
            "curopos@drapnorte.gov.pt",
            "luis.sa@drapnorte.gov.pt",
            "manuela.mesquita@drapnorte.gov.pt",
            "jose.domingos@drapnorte.gov.pt",
            "manuel.parada@drapnorte.gov.pt",
            "joao.lopes@drapnorte.gov.pt",
            "sergioborges@drapnorte.gov.pt",
            "ana.sa@drapnorte.gov.pt",
            "isabel.campos@drapnorte.gov.pt",
            "luisa.santos@drapnorte.gov.pt",
            "josealves@drapnorte.gov.pt",
            "paulo.guedes@drapnorte.gov.pt",
            "Isabel.ferreira@drapnorte.gov.pt",
            "aurora@drapnorte.gov.pt",
            "ammonteiro@drapnorte.gov.pt",
            "apinto@drapnorte.gov.pt",
            "antonio.reais@drapnorte.gov.pt",
            "arminda.fonseca@drapnorte.gov.pt",
            "jmglima@drapnorte.gov.pt",
            "isabel.neto@drapnorte.gov.pt",
            "celeste.sa@drapnorte.gov.pt",
            "vitoria.sofia@drapnorte.gov.pt",
            "ema.veiga@drapnorte.gov.pt",
            "teresalapa@drapnorte.gov.pt",
            "EmiliaVaz@drapnorte.gov.pt",
            "fernando.silva@drapnorte.gov.pt",
            "fernando.vaz@drapnorte.gov.pt",
            "helena.carvalho@drapnorte.gov.pt",
            "gilbertoaa@drapnorte.gov.pt",
            "graca.marques@drapnorte.gov.pt",
            "leonel@drapnorte.gov.pt",
            "julia.pires@drapnorte.gov.pt",
            "jorge.costa@drapnorte.gov.pt",
            "julio@drapnorte.gov.pt",
            "laurapinto@drapnorte.gov.pt",
            "luis.almendra@drapnorte.gov.pt",
            "luisa.caldeira@drapnorte.gov.pt",
            "saovaz@drapnorte.gov.pt",
            "mariaalmendra@drapnorte.gov.pt",
            "sao.alves@drapnorte.p",
            "laura.caseiro@drapnorte.gov.pt",
            "helenabento@drapnorte.gov.pt",
            "manuel.lemos@drapnorte.gov.pt",
            "frebelo@drapnorte.gov.pt",
            "eduardo.beca@drapnorte.gov.pt",
            "susana.romao@drapnorte.gov.pt",
            "mfatima.nascimento@drapnorte.gov.pt",
            "silvia.almeida@drapnorte.gov.pt",
            "fatima.pires@drapnorte.gov.pt",
            "fatima.pinto@drapnorte.gov.pt",
            "irene.fernandes@drapnorte.gov.pt",
            "fernando@drapnorte.gov.pt",
            "nazaresa@drapnorte.gov.pt",
            "conceicao.silva@drapnorte.gov.pt",
            "helena.vasques@drapnorte.gov.pt",
            "mario.almendra@drapnorte.gov.pt",
            "nelsonmorais@drapnorte.gov.pt",
            "oscar.goncalo@drapnorte.gov.pt",
            "patrociniaCorreia@drapnorte.gov.pt",
            "marisa.ribeirinho@drapnorte.gov.pt ",
            "preciosa@drapnorte.gov.pt",
            "rosa.sousa@drapnorte.gov.pt",
            "rui.ribeiro@drapnorte.gov.pt",
            "ruisa@drapnorte.gov.pt",
            "rutecravo@drapnorte.gov.pt",
            "teresa.marcos@drapnorte.gov.pt",
            "americo.silva@drapnorte.gov.pt",
            "antonio.torres@drapnorte.gov.pt",
            "antonio.vas@drapnorte.gov.pt",
            "antonio.hermeiro@drapnorte.gov.pt",
            "joao.grilo@drapnorte.gov.pt",
            "jorge.pinto@drapnorte.gov.pt",
            "lurdes.mesquita@drapnorte.gov.pt",
            "nuno.chalaca@drapnorte.gov.pt",
            "tania.castro@drapnorte.gov.pt",
            "anabela.martins@drapnorte.gov.pt",
            "natercia.leonardo@drapnorte.gov.pt",
            "carlos.areosa@drapnorte.gov.pt",
            "celia.gradissimo@drapnorte.gov.pt",
            "antonio.aguiar@drapnorte.gov.pt",
            "rui.eugenio@drapnorte.gov.pt",
            "judite.fernandes@drapnorte.gov.pt",
            "jose.moura@drapnorte.gov.pt",
            "alfredo.preto@drapnorte.gov.pt",
            "teresa.vilarica@drapnorte.gov.pt",
            "anaoliveira@drapnorte.gov.pt",
            "andrepeixoto@drapnorte.gov.pt",
            "david.santos@drapnorte.gov.pt",
            "filipe.batista@drapnorte.gov.pt",
            "j.maia@drapnorte.gov.pt",
            "luis.ferreira@drapnorte.gov.pt",
            "mivone.maia@drapnorte.gov.pt",
            "maria.abreu@drapnorte.gov.pt",
            "cristina.assis@drapnorte.gov.pt",
            "adelaidesousa@drapnorte.gov.pt",
            "alda.bras@drapnorte.gov.pt",
            "ana.martins@drapnorte.gov.pt",
            "ana.vicente@drapnorte.gov.pt",
            "dores.pereira@drapnorte.gov.pt",
            "ana.cabeceiro@drapnorte.gov.pt",
            "anabela.esteves@drapnorte.gov.pt",
            "a.ventura@drapnorte.gov.pt",
            "fatima.vivas@drapnorte.gov.pt",
            "bernardino.alegre@drapnorte.gov.pt",
            "bruno.leitao@drapnorte.gov.pt",
            "celiamiranda@drapnorte.gov.pt",
            "daniela.coelho@drapnorte.gov.pt",
            "eulaliacosta@drapnorte.gov.pt",
            "teresajanuario@drapnorte.gov.pt",
            "fernanda.domingues@drapnorte.gov.pt",
            "fernanda.cruz@drapnorte.gov.pt",
            "fernando.msilva@drapnorte.gov.pt",
            "ferraz.machado@drapnorte.gov.pt",
            "francisco.lopes@drapnorte.gov.pt",
            "guilherme.afonso@drapnorte.gov.pt",
            "isaura.ferreira@drapnorte.gov.pt",
            "jasmim.goncalves@drapnorte.gov.pt",
            "joao.ramos@drapnorte.gov.pt",
            "pedro.macedo@drapnorte.gov.pt",
            "ptaveira@drapnorte.gov.pt",
            "j.rodriguesalves@drapnorte.gov.pt",
            "jmotamiranda@drapnorte.gov.pt",
            "pedro.costa@drapnorte.gov.pt",
            "sergio.veloso@drapnorte.gov.pt",
            "laurinda.lopes@drapnorte.gov.pt",
            "luis.pacheco@drapnorte.gov.pt",
            "lmsilva@drapnorte.gov.pt",
            "mafonso@drapnorte.gov.pt",
            "manuel.rodrigues@drapnorte.gov.pt",
            "augusta.monteiro@drapnorte.gov.pt",
            "conceicao.costa@drapnorte.gov.pt",
            "c.almeida@drapnorte.gov.pt",
            "cristina.fernandes@drapnorte.gov.pt",
            "gloria.coelho@drapnorte.gov.pt",
            "isabel.oliveira@drapnorte.gov.pt",
            "maria.vilhena@drapnorte.gov.pt",
            "mjulia.vilasboas@drapnorte.gov.pt",
            "manuela.magalhaes@drapnorte.gov.pt",
            "prazeres.ferreira@drapnorte.gov.pt",
            "marta.teixeira@drapnorte.gov.pt",
            "paulo.mota@drapnorte.gov.pt",
            "preciosa.pires@drapnorte.gov.pt",
            "r.bernardino@drapnorte.gov.pt",
            "rui.xavier@drapnorte.gov.pt",
            "silvia.oliveira@drapnorte.gov.pt",
            "v.velez@drapnorte.gov.pt",
            "vera.colaco@drapnorte.gov.pt",
            "vitor.rodrigues@drapnorte.gov.pt",
            "francisco.oliveira@drapnorte.gov.pt",
            "lauracruz@drapnorte.gov.pt",
            "rui.guedes@drapnorte.gov.pt",
            "acurciopereira@drapnorte.gov.pt",
            "lemos.barroso@drapnorte.gov.pt",
            "isabel.martins@drapnorte.gov.pt",
            "joao.silva@drapnorte.gov.pt",
            "mj.freitas@drapnorte.gov.pt",
            "deolinda.xavier@drapnorte.gov.pt",
            "joseigreja@drapnorte.gov.pt",
            "isabel.trigueiros@drapnorte.gov.pt",
            "Alberto.martins@drapnorte.gov.pt",
            "antonino.guedes@drapnorte.gov.pt",
            "antonio.sobrinho@drapnorte.gov.pt",
            "augusta.taveira@drapnorte.gov.pt",
            "carlos.pereira@drapnorte.gov.pt",
            "filomena.rodrigues@drapnorte.gov.pt",
            "afonso.azevedo@drapnorte.gov.pt",
            "jose.fonseca@drapnorte.gov.pt",
            "joaquim.guerra@drapnorte.gov.pt",
            "jose.pereira@drapnorte.gov.pt",
            "liliana.sequeira@drapnorte.gov.pt",
            "maria.ferreira@drapnorte.gov.pt",
            "eugenia.teixeira@drapnorte.gov.pt",
            "filomena.vicente@drapnorte.gov.pt",
            "mlurdes.heleno@drapnorte.gov.pt",
            "odete.lisboa@drapnorte.gov.pt",
            "zita.santos@drapnorte.gov.pt",
            "rui.alves@drapnorte.gov.pt",
            "apedrodias@drapnorte.gov.pt",
            "maria.rodrigues@drapnorte.gov.pt",
            "artur.pina@drapnorte.gov.pt",
            "eduardo.fernandes@drapnorte.gov.pt",
            "edgarrafael@drapnorte.gov.pt",
            "abrunhosa@drapnorte.gov.pt",
            "graciela.goncalves@drapnorte.gov.pt",
            "jose.soeiro@drapnorte.gov.pt",
            "albano.goncalves@drapnorte.gov.pt",
            "vianaoliveira@drapnorte.gov.pt",
            "lisetaduarte@drapnorte.gov.pt",
            "helena.teixeira@drapnorte.gov.pt",
            "basilio.silva@drapnorte.gov.pt",
            "jcampelo@drapnorte.gov.pt",
            "antonio.brandao@drapnorte.gov.pt",
            "fernanda.lacerda@drapnorte.gov.pt",
            "ivone.cardoso@drapnorte.gov.pt",
            "alzirabernardo@drapnorte.gov.pt",
            "ana.mendes@drapnorte.gov.pt",
            "antonio.barroso@drapnorte.gov.pt",
            "fernandoviana@drapnorte.gov.pt",
            "sandra.oliveira@drapnorte.gov.pt",
            "maria.fraga@drapnorte.gov.pt",
            "albertocarvalho@drapnorte.gov.pt",
            "alvaro.carvalho@drapnorte.gov.pt",
            "ana.gomes@drapnorte.gov.pt",
            "antonio.gaspar@drapnorte.gov.pt",
            "antonioaraujo@drapnorte.gov.pt",
            "antonio.moreira@drapnorte.gov.pt",
            "bruno.queiros@drapnorte.gov.pt",
            "celina.bouca@drapnorte.gov.pt",
            "ema.bouca@drapnorte.gov.pt",
            "fernanda.pinto@drapnorte.gov.pt",
            "fernando.mota@drapnorte.gov.pt",
            "francisco.moreira@drapnorte.gov.pt",
            "francisco.goncalves@drapnorte.gov.pt",
            "helder.fernandes@drapnorte.gov.pt",
            "isabel.ribeiro@drapnorte.gov.pt",
            "jorge.coutinho@drapnorte.gov.pt",
            "jorge.soares@drapnorte.gov.pt",
            "jose.adao@drapnorte.gov.pt",
            "jmanuel.cardoso@drapnorte.gov.pt",
            "lina.vitorino@drapnorte.gov.pt",
            "luis.arnaldo@drapnorte.gov.pt",
            "luis.arrobas@drapnorte.gov.pt",
            "moura@drapnorte.gov.pt",
            "manuela.carvalho@drapnorte.gov.pt",
            "alexandrina@drapnorte.gov.pt",
            "lurdes.goncalves@drapnorte.gov.pt",
            "mpereira@drapnorte.gov.pt",
            "filomena.ramos@drapnorte.gov.pt",
            "HelenaCosta@drapnorte.gov.pt",
            "maria.mesquita@drapnorte.gov.pt",
            "maria.sequeira@drapnorte.gov.pt",
            "mavilda.sousa@drapnorte.gov.pt",
            "nair.teixeira@drapnorte.gov.pt",
            "miguel.andrade@drapnorte.gov.pt",
            "miguel.esteves@drapnorte.gov.pt",
            "rui.lagoa@drapnorte.gov.pt",
            "ruiferrao@drapnorte.gov.pt",
            "rui.pires@drapnorte.gov.pt",
            "sandra.morais@drapnorte.gov.pt",
            "teotoniocastro@drapnorte.gov.pt",
            "amarcelo.fernandes@drapnorte.gov.pt",
            "donzilia.marques@drapnorte.gov.pt",
            "jjoaquim.teixeira@drapnorte.gov.pt",
            "conceicao.andrade@drapnorte.gov.pt",
            "sabrina.lagoa@drapnorte.gov.pt",
            "dionisio.fraga@drapnorte.gov.pt",
            "jose.pires@drapnorte.gov.pt",
            "ana.barros@drapnorte.gov.pt",
            "sonia.goncalves@drapnorte.gov.pt",
            "amelia.moura@drapnorte.gov.pt",
            "aurora.pereira@drapnorte.gov.pt",
            "carlos.ponteira@drapnorte.gov.pt",
            "carma.alves@drapn.mamaot.pt",
            "dinis.ponteira@drapnorte.gov.pt",
            "fernando.mesquita@drapnorte.gov.pt",
            "joao.dias@drapnorte.gov.pt",
            "jose.junqueira@drapnorte.gov.pt",
            "jose.patalao@drapnorte.gov.pt",
            "alexandra.pardelinha@drapnorte.gov.pt",
            "piresalves@drapnorte.gov.pt",
            "monia.ferreira@drapnorte.gov.pt",
            "nazare.dias@drapnorte.gov.pt",
            "joao.cancelinha@drapnorte.gov.pt",
            "sandra.lopes@drapnorte.gov.pt",
            "sebastiao.chaves@drapnorte.gov.pt",
            "jduarte@drapnorte.gov.pt",
            "anabela.santos@drapnorte.gov.pt",
            "marcio.teixeira@drapnorte.gov.pt",
            "joao.pires@drapnorte.gov.pt",
            "maria.lino@drapnorte.gov.pt",
            "maria.tome@drapnorte.gov.pt",
            "mariana.fernandes@drapnorte.gov.pt",
            "ana.mila@drapnorte.gov.pt",
            "mluis.medeiros@drapnorte.gov.pt",
            "anabela.carvalho@drapnorte.gov.pt",
            "fernando.fachada@drapnorte.gov.pt",
            "rui.mourao@drapnorte.gov.pt",
            "aseabra@drapnorte.gov.pt",
            "antonio.batista@drapnorte.gov.pt",
            "antonio.debarros@drapnorte.gov.pt",
            "antonio.vilarica@drapnorte.gov.pt",
            "carlos.azeredo@drapnorte.gov.pt",
            "carlos.bastos@drapnorte.gov.pt",
            "carlos.barroso@drapnorte.gov.pt",
            "carloslira@drapnorte.gov.pt",
            "elsa.mateus@drapnorte.gov.pt",
            "faustino.fernandes@drapnorte.gov.pt",
            "sofiarocha@drapnorte.gov.pt",
            "jeronimo.ferreira@drapnorte.gov.pt",
            "castro.lemos@drapnorte.gov.pt",
            "jmoreira@drapnorte.gov.pt",
            "jose.sales@drapnorte.gov.pt",
            "jose.matos@drapnorte.gov.pt",
            "jose.nobre@drapnorte.gov.pt",
            "cecilia.campilho@drapnorte.gov.pt",
            "clarisse.jacob@drapnorte.gov.pt",
            "goretti.freitas@drapnorte.gov.pt",
            "mluisa.dias@drapnorte.gov.pt",
            "maria.fernandes@drapnorte.gov.pt",
            "mmanuelapereira@drapnorte.gov.pt",
            "carla.morais@drapnorte.gov.pt",
            "maximina.lopes@drapnorte.gov.pt",
            "mjoao.gomes@drapnorte.gov.pt",
            "palmira.costa@drapnorte.gov.pt",
            "noemia.vaz@drapnorte.gov.pt",
            "rui.tamagnini@drapnorte.gov.pt",
            "rute.mota@drapnorte.gov.pt",
            "sandra.coelho@drapnorte.gov.pt",
            "tiago.ala@drapnorte.gov.pt",
            "vanessa.dobroes@drapnorte.gov.pt",
            "joao.almendra@drapnorte.gov.pt"});
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.Location = new System.Drawing.Point(50, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(768, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker2.CustomFormat = "dddd dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(446, 233);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Value = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data de início";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker1.CustomFormat = "dddd dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(413, 272);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 2, 22, 16, 25, 23, 999);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 22, 16, 25, 23, 999);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox5.Location = new System.Drawing.Point(180, 274);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(213, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data de fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Assunto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Para: (separar por ;)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(693, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 65);
            this.button2.TabIndex = 20;
            this.button2.Text = "Adicionar datas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox6.Location = new System.Drawing.Point(180, 317);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(213, 22);
            this.textBox6.TabIndex = 21;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker3.CustomFormat = "dddd dd-MM-yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(413, 316);
            this.dateTimePicker3.MinDate = new System.DateTime(2022, 2, 22, 16, 25, 23, 999);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker3.TabIndex = 22;
            this.dateTimePicker3.Value = new System.DateTime(2022, 2, 22, 16, 25, 23, 999);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(50, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 26);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Lembrar";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 506);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nova tarefa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker3;
        private CheckBox checkBox1;
    }
}