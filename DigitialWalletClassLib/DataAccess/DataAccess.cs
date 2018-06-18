using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows;
using Newtonsoft.Json;
using DigitalWalletApp.Models;
using System.Net;
namespace DigitialWalletClassLib
{
    public partial class DataAccess
    {
        public HttpClient client = new HttpClient();
        public HttpResponseMessage ResponseMessage;

        

        public DataAccess()
        {
            client.BaseAddress = new Uri("http://digitalwalletapp20180615015607.azurewebsites.net/api/"); // Change when post API
        }
        //-------------------------------------------------------------------------------------------------------------------------------------
        //                                                           Users
        //-------------------------------------------------------------------------------------------------------------------------------------
        public async Task<List<User>> AllUsers()
        {
            ResponseMessage = await client.GetAsync("Users/AllUsers");
            return JsonConvert.DeserializeObject<List<User>>(await ResponseMessage.Content.ReadAsStringAsync());
            
        }

        public async Task<User> GetUser(int UserId)
        {
            string val = UserId.ToString();
            ResponseMessage = await client.GetAsync($"Users/GetUser?userId={val}");
            return JsonConvert.DeserializeObject<User>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<List<User>> GetStudents()
        {
            
            ResponseMessage = await client.GetAsync("Users/AllStudents");
            return JsonConvert.DeserializeObject<List<User>>(await ResponseMessage.Content.ReadAsStringAsync());
        }



       

        public async Task<bool> AddUser(User _user)
        {
            var response = await client.PostAsJsonAsync("Users/AddUser", _user);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            } 
                      
        }

        public async Task<bool> DeleteUser(int _userID)
        {
            ResponseMessage = await client.GetAsync($"Users/deleteuser?userId={_userID}");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //                                                          Accounts
        //-------------------------------------------------------------------------------------------------------------------------------------

        public async Task<List<Account>> AllAccounts()
        {
            ResponseMessage =await client.GetAsync("Accounts/AllAccounts");
            return JsonConvert.DeserializeObject<List<Account>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<Account> GetAccount(int accountNo)
        {
            ResponseMessage = await client.GetAsync($"Accounts/GetAccount?id={accountNo.ToString()}");
            return JsonConvert.DeserializeObject<Account>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<bool> AddAccount(Account _account)
        {
            var response = await client.PostAsJsonAsync("Accounts/AddAccount", _account);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteAccount(int AccountID)
        {
            ResponseMessage = await client.GetAsync($"Accounts/DeleteAccount?id={AccountID.ToString()}");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //                                                          Invoices
        //-------------------------------------------------------------------------------------------------------------------------------------

        public async Task<List<Invoice>> GetInvoices()
        {
            ResponseMessage = await client.GetAsync("Invoices/GetInvoices");
            return JsonConvert.DeserializeObject<List<Invoice>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            ResponseMessage = await client.GetAsync($"Invoice/GetInvoice?id={id.ToString()}");
            return JsonConvert.DeserializeObject<Invoice>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<List<Invoice>> InvoiceAllTo(int accountTo)
        {
            ResponseMessage = await client.GetAsync($"Invoice/AllAccountTo?accountTo={accountTo.ToString()}");
            return JsonConvert.DeserializeObject<List<Invoice>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<List<Invoice>> InvoiceAllFrom(int accountFrom)
        {
            ResponseMessage = await client.GetAsync($"Invoice/AllAccountFrom?accountFrom={accountFrom.ToString()}");
            return JsonConvert.DeserializeObject<List<Invoice>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<bool> AddInvoice(Invoice _invoice)
        {
            var result = await client.PostAsJsonAsync("Invoice/AddInvoice", _invoice);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteInvoice(int id)
        {
            ResponseMessage = await client.GetAsync($"Invoice/DeleteInvoice?id={id.ToString()}");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //                                                            Teams
        //-------------------------------------------------------------------------------------------------------------------------------------

        public async Task<List<Team>> AllTeams()
        {
            ResponseMessage = await client.GetAsync("Teams/AllTeams");
            return JsonConvert.DeserializeObject<List<Team>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<Team> GetTeam(int id)
        {
            ResponseMessage = await client.GetAsync($"Teams/GetTeam?id={id.ToString()}");
            return JsonConvert.DeserializeObject<Team>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<bool> AddTeam(Team _team)
        {
            var response = await client.PostAsJsonAsync("Teams/AddTeam", _team);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteTeam(int id)
        {
            ResponseMessage = await client.GetAsync($"Teams/DeleteTeam?id={id.ToString()}");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //                                                        Transactions
        //-------------------------------------------------------------------------------------------------------------------------------------

        public async Task<List<Transaction>> AllTransactions()
        {
            ResponseMessage = await client.GetAsync("Transactions/AllTransactions");
            return JsonConvert.DeserializeObject<List<Transaction>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<Transaction> GetTransaction(int accountTo, DateTime datepaid)
        {
            ResponseMessage = await client.GetAsync($"Tranasactions/GetTransaction?AccountTo={accountTo.ToString()}&datepaid={datepaid.ToString()}");
            return JsonConvert.DeserializeObject<Transaction>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<List<Transaction>> AccountTo(int accountTo)
        {
            ResponseMessage = await client.GetAsync($"Transactions/AccountTo?accountto={accountTo.ToString()}");
            return JsonConvert.DeserializeObject<List<Transaction>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<List<Transaction>> AccountFrom(int accountFrom)
        {
            ResponseMessage = await client.GetAsync($"Transactions/AccountFrom?accountFrom={accountFrom.ToString()}");
            return JsonConvert.DeserializeObject<List<Transaction>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<bool> AddTransaction(Transaction _transaction)
        {
            ResponseMessage = await client.PostAsJsonAsync("Transaction/AddTransaction", _transaction);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteTransaction(int id, DateTime date)
        {
            ResponseMessage = await client.GetAsync($"Transaction/DeleteTransaction?id={id.ToString()}&date={date.ToString()}");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //                                                            Work
        //-------------------------------------------------------------------------------------------------------------------------------------

        public async Task<List<WorkAllocation>> AllWork()
        {
            ResponseMessage = await client.GetAsync("Work/AllWork");
            return JsonConvert.DeserializeObject<List<WorkAllocation>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<WorkAllocation> GetWork(int UserId, int TeamId)
        {
            ResponseMessage = await client.GetAsync($"Work/GetWork?workId={TeamId.ToString()}&userId={UserId.ToString()}");
            return JsonConvert.DeserializeObject<WorkAllocation>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<List<WorkAllocation>>TeamByStudent(int userId)
        {
            ResponseMessage = await client.GetAsync($"Work/TeamByStudent?userID={userId.ToString()}");
            return JsonConvert.DeserializeObject<List<WorkAllocation>>(await ResponseMessage.Content.ReadAsStringAsync());
        }

        public async Task<bool> AddWork(WorkAllocation _work)
        {
            ResponseMessage =await client.PostAsJsonAsync("Work/AddWork", _work);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteWork(int id, int work)
        {
            ResponseMessage = await client.GetAsync($"Work/DeleteWork?id={id.ToString()}&work={work.ToString()}");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Account>>LoadAccountData()
        {
            ResponseMessage = await client.GetAsync("Accounts");
            var Content = JsonConvert.DeserializeObject<List<Account>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Invoice>>LoadInvoiceData()
        {
            ResponseMessage = await client.GetAsync("Invoices");
            var Content = JsonConvert.DeserializeObject<List<Invoice>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Team>> LoadTeamData()
        {
            ResponseMessage = await client.GetAsync("Teams");
            var Content = JsonConvert.DeserializeObject<List<Team>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Transaction>>LoadTransactionData()
        {
            ResponseMessage = await client.GetAsync("Transactions");
            var Content = JsonConvert.DeserializeObject<List<Transaction>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<WorkAllocation>>LoadWorkAllocationData()
        {
            ResponseMessage = await client.GetAsync("WorkAllocations");
            var Content = JsonConvert.DeserializeObject<List<WorkAllocation>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;

            
        }

        public async Task<List<User>> LoadUserData()
        {
            ResponseMessage = await client.GetAsync("Users");
            var Content = JsonConvert.DeserializeObject<List<User>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }
    }
}
