using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Приставы.ПриставыDataSetTableAdapters;
using static Приставы.ПриставыDataSet;
using System.Data.OleDb;
using System.Data;

namespace Приставы
{
    public class EntityManager
    {
        static ПриставыDataSet ПриставыDataSet = new ПриставыDataSet();

        private static ПользователиTableAdapter пользователиTableAdapter = new ПользователиTableAdapter();
        private static ДолжникиTableAdapter должникиTableAdapter = new ДолжникиTableAdapter();
        private static Типы_взысканийTableAdapter тип_взысканияTableAdapter = new Типы_взысканийTableAdapter();
        private static ВзыскательTableAdapter взыскательTableAdapter = new ВзыскательTableAdapter();
        private static ИсполнительTableAdapter исполнительTableAdapter = new ИсполнительTableAdapter();
        private static ОтделыTableAdapter ОтделыTableAdapter = new ОтделыTableAdapter();
        public static ДолжностиTableAdapter ДолжностиTableAdapter = new ДолжностиTableAdapter();
        public static ОрганизацияTableAdapter ОрганизацияTableAdapter = new ОрганизацияTableAdapter();
        public static Реквизиты_банкаTableAdapter реквизиты_БанкаTableAdapter = new Реквизиты_банкаTableAdapter();

        public static ПользователиDataTable UserDataTable
        {
            get
            {
                return ПриставыDataSet.Пользователи;
            }
        }

        public static void UpdateUsers()
        {
            пользователиTableAdapter.Adapter.Update(UserDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПользователиDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = пользователиTableAdapter.Connection,
                CommandText = "SELECT Id_user, Фамилия, Имя, Отчество, Должность, Логин, Пароль, " +
                $"[Является администратором] FROM Пользователи {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(пользователиTableAdapter.Adapter, filterUserCommand, UserDataTable);

            return UserDataTable;
        }

        public static ДолжникиDataTable DOLDataTable
        {
            get
            {
                return ПриставыDataSet.Должники;
            }
        }

        public static void UpdateDOL()
        {
            должникиTableAdapter.Adapter.Update(DOLDataTable);
        }

        // <summary>
        /// Возвращает отфильтрованную таблицу должники по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ДолжникиDataTable FilterDOL(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OleDbCommand()
            {
                Connection = должникиTableAdapter.Connection,
                CommandText = "SELECT Id, [Номер дела], [ФИО должника], [ФИО взыскателя], [Пристав-исполнитель], Долг," +
                "[Дата заведения дела], [Тип взыскания], [Размер взыскания], [Дата окончания дела] " +
                 $"FROM Должники {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(должникиTableAdapter.Adapter, filterEmployeesCommand, DOLDataTable);

            return DOLDataTable;
        }

        private static Типы_взысканийDataTable TP_VZDataTable
        {
            get
            {
                return ПриставыDataSet.Типы_взысканий;
            }
        }

        public static void UpdateTP_VZ()
        {
            тип_взысканияTableAdapter.Adapter.Update(TP_VZDataTable);
        }

        // <summary>
        /// Возвращает отфильтрованную таблицу тип взыскания по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Типы_взысканийDataTable FilterTP_VZ(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OleDbCommand()
            {
                Connection = тип_взысканияTableAdapter.Connection,
                CommandText = "SELECT Id_взыскания, Наименование, Срок исполнения " +
                 $"FROM Типы взыскания {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(тип_взысканияTableAdapter.Adapter, filterEmployeesCommand, TP_VZDataTable);

            return TP_VZDataTable;
        }

        private static ВзыскательDataTable VZDataTable
        {
            get
            {
                return ПриставыDataSet.Взыскатель;
            }
        }

        public static void UpdateVZ()
        {
            взыскательTableAdapter.Adapter.Update(VZDataTable);
        }

        // <summary>
        /// Возвращает отфильтрованную таблицу взыскатель по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ВзыскательDataTable FilterVZ(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OleDbCommand()
            {
                Connection = взыскательTableAdapter.Connection,
                CommandText = "SELECT Id_взыскателя, ФИО" +
                 $"FROM Взыскатель {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(взыскательTableAdapter.Adapter, filterEmployeesCommand, VZDataTable);

            return VZDataTable;
        }

        public static ИсполнительDataTable PR_ISPDataTable
        {
            get
            {
                return ПриставыDataSet.Исполнитель;
            }
        }

        public static void UpdatePR_ISP()
        {
            исполнительTableAdapter.Adapter.Update(PR_ISPDataTable);
        }

        // <summary>
        /// Возвращает отфильтрованную таблицу пристав-исполнитель по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ИсполнительDataTable FilterPR_ISP(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OleDbCommand()
            {
                Connection = исполнительTableAdapter.Connection,
                CommandText = "SELECT Id_пристава, ФИО, Должности, Отдел " +
                 $"FROM Приставы-исполнители {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(исполнительTableAdapter.Adapter, filterEmployeesCommand, PR_ISPDataTable);

            return PR_ISPDataTable;
        }

        public static ОтделыDataTable DepDataTable
        {
            get
            {
                return ПриставыDataSet.Отделы;
            }
        }

        public static void UpdateDep()
        {
            ОтделыTableAdapter.Adapter.Update(DepDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу отделы по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ОтделыDataTable FilterDep(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = ОтделыTableAdapter.Connection,
                CommandText = "SELECT Номер отделы, Наименование FROM Отделы {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ОтделыTableAdapter.Adapter, filterUserCommand, DepDataTable);

            return DepDataTable;
        }

        public static ДолжностиDataTable PostsDataTable
        {
            get
            {
                return ПриставыDataSet.Должности;
            }
        }

        public static void UpdatePosts()
        {
            ДолжностиTableAdapter.Adapter.Update(PostsDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу должности по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ДолжностиDataTable FilterPosts(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = ДолжностиTableAdapter.Connection,
                CommandText = "SELECT Id_должности, Название, Отделы FROM Должности {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ДолжностиTableAdapter.Adapter, filterUserCommand, PostsDataTable);

            return PostsDataTable;
        }

        public static ОрганизацияDataTable ОрганизацияDataTable
        {
            get
            {
                return ПриставыDataSet.Организация;
            }
        }

        public static void UpdateОрганизация()
        {
            ОрганизацияTableAdapter.Adapter.Update(ОрганизацияDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу должности по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ОрганизацияDataTable FilterОрганизация(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = ОрганизацияTableAdapter.Connection,
                CommandText = "SELECT Id, Организация FROM Организация {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ОрганизацияTableAdapter.Adapter, filterUserCommand, ОрганизацияDataTable);

            return ОрганизацияDataTable;
        }

        public static Реквизиты_банкаDataTable Реквизиты_банкаDataTable
        {
            get
            {
                return ПриставыDataSet.Реквизиты_банка;
            }
        }

        public static void UpdateРеквизиты_банка()
        {
            реквизиты_БанкаTableAdapter.Adapter.Update(Реквизиты_банкаDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу должности по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Реквизиты_банкаDataTable FilterРеквизиты_банка(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = реквизиты_БанкаTableAdapter.Connection,
                CommandText = "SELECT [Id банка], [Название банка],[БИК банка],[ИНН банка] " +
                "FROM Реквизиты банка {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(реквизиты_БанкаTableAdapter.Adapter, filterUserCommand, Реквизиты_банкаDataTable);

            return Реквизиты_банкаDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}
