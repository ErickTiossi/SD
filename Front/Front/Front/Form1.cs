using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Front.Moldels;
using Newtonsoft.Json;

namespace Front
{
    public partial class Conexão : Form
    {
        public Conexão()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CB_filial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Conexão_Load(object sender, EventArgs e)
        {
            var dados = new List<UsuarioModel>();

            using (var client = new HttpClient()) {

                client.BaseAddress = new Uri("http://localhost:56426/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/usuario/ConsultarFuncionarios").Result;
                if (response.IsSuccessStatusCode) {
                    var product = response.Content.ReadAsStringAsync();
                    dados = JsonConvert.DeserializeObject<List<UsuarioModel>>(product.Result);
                } else {

                }

                var list = new BindingList<UsuarioModel>(dados);
                dgvDados.DataSource = list;
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            try {
                UsuarioModel funcionario = new UsuarioModel(
                    txtName.Text,
                    mskCpf.Text
                );

                using (var client = new HttpClient()) {

                    Task<HttpResponseMessage> response = client.PostAsJsonAsync("http://localhost:56426/api/usuario/CadastrarFuncionario", funcionario);

                    MessageBox.Show("Novo funcionário incluído com sucesso.");
                    txtName.Clear();
                    mskCpf.Clear();
                    txtName.Focus();
                    exibirDados();
                }

            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            try {
                DialogResult dr = MessageBox.Show("Deseja excluir este funcionário ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes) {

                    foreach (DataGridViewRow item in this.dgvDados.SelectedRows) {

                        var Id = item.Cells[0].Value;

                        using (var client = new HttpClient()) {

                            Task<HttpResponseMessage> response = client.DeleteAsync("http://localhost:56426/api/usuario/ExcluirFuncionario/" + Id);
                            MessageBox.Show("Funcionário excluído com sucesso.");
                            txtName.Clear();
                            mskCpf.Clear();
                            txtName.Focus();
                            exibirDados();
                        }
                    }
                }
            } catch {
                throw;
            }
        }

        private void exibirDados() {
            var dados = new List<UsuarioModel>();

            using (var client = new HttpClient()) {

                client.BaseAddress = new Uri("http://localhost:56426/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/usuario/ConsultarFuncionarios").Result;
                if (response.IsSuccessStatusCode) {
                    var product = response.Content.ReadAsStringAsync();
                    dados = JsonConvert.DeserializeObject<List<UsuarioModel>>(product.Result);
                } else {

                }

                var list = new BindingList<UsuarioModel>(dados);
                dgvDados.DataSource = list;
            }
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            int Id = 0;

            if (dgvDados.SelectedRows.Count > 0) {
                Id = Convert.ToInt32(dgvDados.SelectedRows[0].Cells["Id"].Value.ToString());
            }

            try {
                UsuarioModel funcionario = new UsuarioModel(
                    Id,
                    txtName.Text,
                    mskCpf.Text
                );

                using (var client = new HttpClient()) {

                    Task<HttpResponseMessage> response = client.PutAsJsonAsync("http://localhost:56426/api/usuario/AlterarFuncionario", funcionario);

                    MessageBox.Show("Novo funcionário atualizado com sucesso.");
                    txtName.Clear();
                    mskCpf.Clear();
                    txtName.Focus();
                    exibirDados();
                }

            } catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message, "Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                mskCpf.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                mskCpf.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
