using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Gerador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class Global
        {
            // esta é uma classe public e todas as variáveis aqui passa a ser publica tam´bem
            public static string vLinha;
            public static int vTotCampo;
        }// public

        private void btCriar_Click(object sender, EventArgs e)
        {
            txAviso.Text = "";
            Global.vTotCampo = 777;
            if (txClasse.Text == "")
            {
                txAviso.Text = "Escreva o nome da classe";
                return;
            }
            if (txNamespace.Text == "")
            {
                txAviso.Text = "Digite o Diretório do Namesapce";
                return;
            }
            if (txTabela.Text == "")
            {
                txAviso.Text = "Informe o nome da tabela relacionada a Classe";
                return;
            }

            // txFields  - - - - - - - - - - - - - - - - - - 
            txFields.Text = "";
            foreach (string linha in txCampos.Lines)
            {
                txFields.Text = txFields.Text + "   private $" + linha + ";";
                txFields.AppendText(Environment.NewLine);
            }
            txFields.Text = txFields.Text + "   public $response; // linhas da tabela";
            txFields.AppendText(Environment.NewLine);

            // classe geral
            txGeral.Text = "<?php";
            txGeral.AppendText(Environment.NewLine);
            txGeral.Text = txGeral.Text + "# Classe";
            txGeral.AppendText(Environment.NewLine);

            txGeral.Text = txGeral.Text + "namespace " + txNamespace.Text + ';';
            txGeral.AppendText(Environment.NewLine);

            // controller - - - - - - - - - - - - - - - - - -
            txController.Text = "<?php";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "# Referente a tabela: ";
            txController.AppendText(Environment.NewLine);

            txController.AppendText(Environment.NewLine);// pula linha

            txController.Text = txController.Text + "namespace " + txNamespace.Text + "Controller;";
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "use " + txNamespace.Text + "\\" + "Model" + txClasse.Text + ";"; 
            txController.AppendText(Environment.NewLine);

            txController.Text = txController.Text + "class " + txClasse.Text + "Controller extends Controller";
            txController.AppendText(Environment.NewLine);
            txController.Text = txController.Text + "{";
            txController.AppendText(Environment.NewLine);
            txController.AppendText(Environment.NewLine);// pula linha

            txController.Text = txController.Text + " public static function index()";
            txController.Text = txController.Text + " {";
            txController.Text = txController.Text + "   parent::has_user();";
            txController.Text = txController.Text + "   parent::load_page('" + txClasse.Text + "//" + "index');";
            txController.Text = txController.Text + " }";
            txController.AppendText(Environment.NewLine);// pula linha
            // campos
            foreach (string linha in txCampos.Lines)
            {
                txController.Text = txController.Text + linha + "\n";
                txController.AppendText(Environment.NewLine);
            }
            txController.Text = txController.Text + "Variavel: " + Global.vTotCampo.ToString();

            txController.Text = txController.Text + "} // class";
            txController.AppendText(Environment.NewLine);

            // Model  - - - - - - - - - - - - - - - - - -
            txModel.Text = "<?php";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "# Referente a tabela" + txTabela.Text;
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);// pula linha

            txModel.Text = txModel.Text + "namespace src" + "\\" + "Model;";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);// pula linha

            txModel.Text = txModel.Text + "use src" + "\\" + "DAO" + "\\" + txClasse.Text + "DAO;";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);// pula linha

            txModel.Text = txModel.Text + "class " + txClasse.Text;
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "{";
            txModel.AppendText(Environment.NewLine);

            // campos
            txModel.Text = txModel.Text + txFields.Text; // conteúdo
            txModel.AppendText(Environment.NewLine);// pula linha

            // getts e setts ---------------------------------------------
            txModel.Text = txModel.Text + "// - -  gets and sets  - - - - - - ";
            txModel.AppendText(Environment.NewLine);

            foreach (string linha in txCampos.Lines)
            {
                // txModel.Text = txModel.Text + linha + "\n";
                txModel.Text = txModel.Text + " public function get_" + linha + "(){";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + "   return $this->" + linha + ";";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + " }";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + " public function set_" + linha + "($x){";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + "   $this->" + linha + " = $x;";
                txModel.AppendText(Environment.NewLine);
                txModel.Text = txModel.Text + " }";
                txModel.AppendText(Environment.NewLine);
            }
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "// functions - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + " public function getAll()";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + " {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $this->response = json_encode($dao->selectAll(), JSON_UNESCAPED_UNICODE);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + " }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + " public function getById($id)";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  $this->response = $dao->selectById($id);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + " public function update()";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + " {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "   $this->response = $dao->update($this);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + " }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "  public function delete($id)";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  {";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "     $dao = new " + txClasse.Text + "DAO();";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "     $this->response = $dao->selectById($id);";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "  }";
            txModel.AppendText(Environment.NewLine);
            txModel.AppendText(Environment.NewLine);

            txModel.Text = txModel.Text + "} // class";
            txModel.AppendText(Environment.NewLine);
            txModel.Text = txModel.Text + "?> \n";

            // DAO - - - - - - - - - - - - - - - - - -
            txDao.Text = "<?php";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "# Referente a tabela " + txTabela.Text;
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);// pula linha

            txDao.Text = txDao.Text + "namespace " + txNamespace.Text + "\\" + "DAO;";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);// pula linha

            txDao.Text = txDao.Text + "use " + txNamespace.Text + "\\" + "Model" + "\\" + txClasse.Text + "Model;";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "use " + "\\" + "PDO;";
            txDao.AppendText(Environment.NewLine);
            txDao.AppendText(Environment.NewLine);// pula linha

            txDao.Text = txDao.Text + "class " + txClasse.Text + "DAO extends DAO";
            txDao.AppendText(Environment.NewLine);
            txDao.Text = txDao.Text + "{";
            txDao.AppendText(Environment.NewLine);

            txDao.Text = txDao.Text + " public function __construct() \n";
            txDao.Text = txDao.Text + " { \n";
            parent::__construct();
            txDao.Text = txDao.Text + " } \n";
            txDao.AppendText(Environment.NewLine);

            public function selectAll()
            {
               $sql = "SELECT * from " + txTabela.Text + ;  
                $st = $this->conexao_XXX->prepare($sql);
                $st->execute();
                return $st->fetchAll(PDO::FETCH_ASSOC);
            }

            public function selectById(int $id)
            {
    $sql = "select * from relator where idrelator = ?";
    $st = $this->conexao_cred->prepare($sql);
    $st->bindValue(1,$id);
    $st->execute();
                return $st->fetch(PDO::FETCH_ASSOC);
            }


            public function insert( + txClasse.Text +  Model $model)
            {
                $sql = "INSERT INTO " + txTabela.Text + (x)VALUES(?)";
                    $st = $this->conexao_XXX->prepare($sql);
                $st->bindValue(1,$model->get_XXX());
                      $st->execute();
            }


            public function update(RelatoresModel $model)
            {
                    $sql = "UPDATE XXX=? FROM + txTabela.Text +  WHERE id = ?";
            $st = $this->conexao_xxx->prepare($sql);
               $st->bindValue(1,$model->get_relatornome());
                return $st->execute();
            }


            public function delete($id)
            {
                    $sql = "DELETE FROM + txTabela WHERE id = ?";
                    $st = $this->conexao_XXX->prepare($sql);
                    $st->bindValue(1, $id);
                        return $st->execute();
            }





            txDao.Text = txDao.Text + "} // class";
            txDao.AppendText(Environment.NewLine);


        }// click


        private void button2_Click(object sender, EventArgs e)
        {
        }
    } // class
} // name
