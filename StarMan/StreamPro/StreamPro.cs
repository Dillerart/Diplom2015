using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StarMan
{
    public partial class StreamPro : Form
    {
        
        public StreamPro()
        {
            InitializeComponent();
            User_acc();
            toolUser.Text = Ustr._user;
            _load();

            
        }
       
        //создание костяка таблицы
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Номер карты";
            DatGridUser.Columns[1].Width = 100;
            DatGridUser.Columns[2].HeaderText = "ФИО";
            DatGridUser.Columns[2].Width = 210;
            DatGridUser.Columns[3].HeaderText = "Бонусы";
            DatGridUser.Columns[3].Width = 80;
            DatGridUser.Columns[4].HeaderText = "Дата регистрации";
            DatGridUser.Columns[4].Width = 120;
            DatGridUser.Columns[5].HeaderText = "Блокировка";
            DatGridUser.Columns[5].Width = 90;
            DatGridUser.Columns[6].HeaderText = "Доступные средства";
            DatGridUser.Columns[6].Width = 110;
            DatGridUser.Columns[6].DefaultCellStyle.Format = "C2";
            DatGridUser.Columns[7].HeaderText = "Создан";
            DatGridUser.Columns[7].Width = 160;
            DatGridUser.Columns[8].HeaderText = "Доп. инфо";
            DatGridUser.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatGridUser.CurrentCell = null;
            
        }
        //Вставка данных в таблицу
        public void User_acc()
        {
            t_filter.SelectedIndex = 0;
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_client, me.Number_card, me.Name, me4.Name, me.Date_reg, me.Block, me.Sum_money, me3.NameInfoUser, me.Inform
                                      From Client me, Access_user me3, Bonus me4
                                      Where me.id_access = me3.id_access and me.id_bonus=me4.id_bonus and me._delete='False'";
            try
            {
                acc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(tab_sql, acc);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                DatGridUser.DataSource = dt;
                _size();
                l_count.Text = Convert.ToString(DatGridUser.RowCount);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }
            
        }
        private void sim(string id)
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_client, me4.bonus
                                      From Client me, Bonus me4
                                      Where me.id_client ='" + id + "' and me.id_bonus=me4.id_bonus and me._delete='False'";
             try
                {
                    acc.Open();
                    SqlCommand cmd2 = new SqlCommand(tab_sql, acc);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                           Ustr._sim = dr2["bonus"].ToString();
                         
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    acc.Close();

                }
            
        }
        
        //открытие формы добавление
        private void add_bt_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.ShowDialog();
            
        }
        //загрузка по параметрам: Кассир или Бухгалтер
        public void _load()
        {
            if (this.Text == "Касса" )
            {
                delete_bt.Visible = false;
                b_remove.Visible = false;
                справочникиToolStripMenuItem.Visible = false;
                отчетыToolStripMenuItem.Visible = false;
                удалитьToolStripMenuItem.Visible = false;
                восстановитьКлиентаToolStripMenuItem.Visible = false;

            }
         
        }
        //кнопка редактирования + передача парраметров через класс(в главной форме -  Programs)
        private void edit_bt_Click(object sender, EventArgs e)
        {
            try
            {
                 string sim ="";

                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                Edit_cl._idser = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_config = new ToConnection();
                SqlConnection acc = new SqlConnection(str_config.read_conf());

                string tab_sql = @"Select me._level
                                      From Client me
                                      Where me.id_client = '" + DatGridUser[0, ind_sql].Value.ToString() +"'";
                try
                {
                    acc.Open();
                    SqlCommand cmd2 = new SqlCommand(tab_sql, acc);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        sim = dr2["_level"].ToString();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    acc.Close();

                }
                Edit_cl._card = DatGridUser[1, ind_sql].Value.ToString();
                Edit_cl._fio = DatGridUser[2, ind_sql].Value.ToString();
                Edit_cl._bonus = DatGridUser[3, ind_sql].Value.ToString();
                Edit_cl._inform2 = DatGridUser[8, ind_sql].Value.ToString();
                Client_edit _edit = new Client_edit();
                _edit.simmm(sim);
                _edit.ShowDialog();
                
            }
            catch
            {
                l_error.Text = "Пользователь не выбран. Выбирете пользователя.";
            }
            
        }
        //кнопка добавление денег
        private void money_bt_Click(object sender, EventArgs e)
        {
            try
            {
                
                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string star_del = DatGridUser[5, ind_sql].Value.ToString();
                string id = DatGridUser[0, ind_sql].Value.ToString();
                sim(id);
                _printer._id = DatGridUser[1, ind_sql].Value.ToString();
                _printer._name = DatGridUser[2, ind_sql].Value.ToString();
                string mi = DatGridUser[1, ind_sql].Value.ToString();
                if (star_del != "True")
                {
                    Ustr._id_clients = DatGridUser[0, ind_sql].Value.ToString(); 
                    Money_add money_add = new Money_add();
                    money_add.mig(mi);
                    money_add.ShowDialog();
                }
                else l_error.Text = "Данный пользователь заблокирован.";

            }
            catch
            {
                l_error.Text = "Пользователь не выбран. Выбирете пользователя.";
            }
       }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_bt_Click(sender, e);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_bt_Click(sender, e);
        }

        private void пополнитьСчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money_bt_Click(sender, e);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service _service = new Service();
            _service.ShowDialog();
        }
        
        private void валютаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сurrency _curr = new Сurrency();
            _curr.ShowDialog();
        }
        //кнопка пометка на удаление по выбранной позиции
        private void delete_bt_Click(object sender, EventArgs e)
        {
            try
            {
                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string star_del = DatGridUser[0, ind_sql].Value.ToString();
                _info st = new _info();
                st.ShowDialog();
                _delete(star_del);
                User_acc();
            }
            catch
            {
                l_error.Text = "Пользователь не выбран. Выбирете пользователя.";
            }
           
        }
        //метод пометки на удаление
        private void _delete(string star_del)
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION; UPDATE Client
                                      SET Client._delete = 'True', Client._inform_delete='" + Delete_cl._inf + "' Where Client.id_client='" + star_del + "' COMMIT TRANSACTION;";
            
            try
            {
                acc.Open();
                SqlCommand s_User = new SqlCommand(tab_sql, acc);
                s_User.ExecuteNonQuery();
                l_count.Text = Convert.ToString(DatGridUser.RowCount);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }
        }
        //при активации  формы вызываеться метод заполнения
        private void StreamPro_Activated(object sender, EventArgs e)
        {
            User_acc();
            t_textfilter.Focus();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_bt_Click(sender, e);
        }
        //кнопка блокировки клиента по выбраному полю
        private void b_block_Click(object sender, EventArgs e)
        {
            try
            {
                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string star_del = DatGridUser[0, ind_sql].Value.ToString();
                _block(star_del);
                User_acc();
            }
            catch
            {
                l_error.Text = "Пользователь не выбран. Выбирете пользователя.";
            }
            
        }
        //метод блокировки клиента
        public void _block(string star_del)
        {
            
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION; UPDATE Client
                                      SET Client.Block = 'True'
                                      Where Client.id_client='" + star_del + "' COMMIT TRANSACTION;";

            try
            {
                acc.Open();
                SqlCommand s_User = new SqlCommand(tab_sql, acc);
                s_User.ExecuteNonQuery();
                l_count.Text = Convert.ToString(DatGridUser.RowCount);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }
 
        }
        //зайти в корзину и вытащить от туда данные
        private void b_remove_Click(object sender, EventArgs e)
        {
            _remove_Clients _remove = new _remove_Clients();
            _remove.ShowDialog();
        }
        //кнопка разблокировки клиента по выбраному полю
        private void b_unblock_Click(object sender, EventArgs e)
        {
            try
            {
                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string star_del = DatGridUser[0, ind_sql].Value.ToString();
                _unblock(star_del);
                User_acc();

            }
            catch
            {
                l_error.Text = "Пользователь не выбран. Выбирете пользователя.";
            }
          
        }
        //метод - разблокировать клиента
        public void _unblock(string star_del)
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION; UPDATE Client
                                      SET Client.Block = 'False'
                                      Where Client.id_client='" + star_del + "' COMMIT TRANSACTION;";

            try
            {
                acc.Open();
                SqlCommand s_User = new SqlCommand(tab_sql, acc);
                s_User.ExecuteNonQuery();
                l_count.Text = Convert.ToString(DatGridUser.RowCount);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }

        }

        private void восстановитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_remove_Click(sender, e);
        }

        private void блокироватьСчетКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_block_Click(sender, e);
        }

        private void разблокироватьСчетКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_unblock_Click(sender, e);
        }
        //очистка фильтра
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            t_filter.SelectedIndex = 0;
            t_textfilter.Text = "";
            User_acc();
        }

        // метод фильтрации
        private void fslter(string _filter)
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());


            try
            {
                acc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(_filter, acc);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                DatGridUser.DataSource = dt;
                _size();
                l_count.Text = Convert.ToString(DatGridUser.RowCount);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }

        }

        private void t_textfilter_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                l_error.Text = "";
                string _filter = "";

                switch (t_filter.SelectedIndex)
                {
                    //  Логин
                    case 0:
                        _filter = @"Select me.id_client, me.Number_card, me.Name, me4.Name, me.Date_reg, me.Block, me.Sum_money, me3.NameInfoUser, me.Inform
                                      From  Client me, Access_user me3, Bonus me4
                                      Where (me.Number_card  LIKE '%" + t_textfilter.Text + "%') and (me.id_access = me3.id_access) and (me.id_bonus=me4.id_bonus) and (me._delete='False')";

                        break;
                    //Права доступа
                    case 1:
                        _filter = @"Select me.id_client, me.Number_card, me.Name, me4.Name, me.Date_reg, me.Block, me.Sum_money, me3.NameInfoUser, me.Inform
                                      From Client me, Access_user me3, Bonus me4
                                      Where (me.Name  LIKE '%" + t_textfilter.Text + "%')  and (me.id_access = me3.id_access) and (me.id_bonus=me4.id_bonus) and (me._delete='False')";


                        break;
                    case 2:
                        _filter = @"Select me.id_client, me.Number_card, me.Name, me4.Name, me.Date_reg, me.Block, me.Sum_money, me3.NameInfoUser, me.Inform
                                      From Client me, Access_user me3, Bonus me4
                                      Where (me4.Name  LIKE '%" + t_textfilter.Text + "%') and (me.id_access = me3.id_access) and (me.id_bonus=me4.id_bonus) and (me._delete='False')";


                        break;
                    case 3:
                        _filter = @"Select me.id_client, me.Number_card, me.Name, me4.Name, me.Date_reg, me.Block, me.Sum_money, me3.NameInfoUser, me.Inform
                                      From Client me, Access_user me3, Bonus me4
                                      Where (me3.NameInfoUser  LIKE '%" + t_textfilter.Text + "%') and (me.id_access = me3.id_access) and (me.id_bonus=me4.id_bonus) and (me._delete='False')";


                        break;

                }

                fslter(_filter);
            }
            catch
            {
                l_error.Text = "Не выбрано поле, выберете поле фильтрации.";
            }
                
           

            
        }

        private void бонусыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bonus stim = new Bonus();
            stim.ShowDialog();
        }

        private void пополненыеСредстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UsersReports st = new _UsersReports();
            st.ShowDialog();
        }

        private void поКассирамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Kacca_Reports st = new _Kacca_Reports();
            st.ShowDialog();
        }

        private void потраченыеСредстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ExpensesReports st = new _ExpensesReports();
            st.ShowDialog();
        }

        private void поБухгалтерамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Buh_Reports st = new _Buh_Reports();
            st.ShowDialog();
        }

        private void поВалютамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyCateg_Reports st = new MoneyCateg_Reports();
            st.ShowDialog();
        }

    

     

        private void выходToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SummToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _All_Reports st = new _All_Reports();
            st.ShowDialog();
        }

        private void уровниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level_bns st = new Level_bns();
            st.ShowDialog();
        }

        private void b_eX_Click(object sender, EventArgs e)
        {
            try
            {

                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string star_del = DatGridUser[5, ind_sql].Value.ToString();
                if (star_del != "True")
                {
                    Ustr._name = DatGridUser[1, ind_sql].Value.ToString();
                    Ustr._num = DatGridUser[2, ind_sql].Value.ToString();
                    Ustr._sum = DatGridUser[6, ind_sql].Value.ToString();
                    Ustr._id_clients = DatGridUser[0, ind_sql].Value.ToString();
                    _Expenses money_add = new _Expenses();
                    money_add.ShowDialog();
                }
                else l_error.Text ="Данный пользователь заблокирован.";

            }
            catch
            {
                l_error.Text = "Пользователь не выбран. Выбирете пользователя.";
            }
        }

        private void услугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Service_Report st = new _Service_Report();
            st.ShowDialog();
        }

    }
}
