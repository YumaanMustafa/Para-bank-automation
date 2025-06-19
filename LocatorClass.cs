using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Testing_Project
{
    public static class LocatorClass
    {
        //RegisterPage

        public const string RegisterPage = "//a[normalize-space()='Register']";
        public const string FirstName = "input[id='customer.firstName']";
        public const string LastName = "input[id='customer.lastName']";
        public const string Address = "input[id='customer.address.street']";
        public const string City = "input[id='customer.address.city']";
        public const string State = "input[id='customer.address.state']";
        public const string ZipCode = "input[id='customer.address.zipCode']";
        public const string Phone = "input[id='customer.phoneNumber']";
        public const string SSN = "input[id='customer.ssn']";
        public const string UserName = "input[id='customer.username']";
        public const string Password = "input[id='customer.password']";
        public const string confirm = "#repeatedPassword";
        public const string RegisterButton = "input[value='Register']";
        public const string expectedRegisterResult = "//p[contains(text(),'Your account was created successfully. You are now')]";
        public const string expectedDuplicatedError = "//span[@id='customer.username.errors']";
        public const string logout = "a[href='logout.htm']";
        public const string errorFirstname = "//span[@id='customer.firstName.errors']";
        public const string errorLastname = "//span[@id='customer.lastName.errors']";
        public const string errorAddress = "//span[@id='customer.address.street.errors']";
        public const string errorCity = "span[id='customer.address.city.errors']";
        public const string errorState = "//span[@id='customer.address.state.errors']";
        public const string errorZipcode = "//span[@id='customer.address.zipCode.errors']";
        public const string errorSSN = "//span[@id='customer.ssn.errors']";
        public const string errorUsername = "//span[@id='customer.username.errors']";
        public const string errorPassword = "//span[@id='customer.password.errors']";
        public const string errorconfirm = "//span[@id='repeatedPassword.errors']";
        public const string errornotputCorrectConfirm = "//span[@id='repeatedPassword.errors']";


        //LoginPage
        public const string LoginUsername = "input[name='username']";
        public const string LoginPassword = "input[name='password']";
        public const string LoginButton = "input[value='Log In']";
        public const string ExpectedLoginText = "//p[@class='smallText']";
        public const string ErrorEmptyLogin = "//p[@class='error']";
        public const string ErrorInvalid = "//p[@class='error']";


        //OpenNewAccount
        public const string checkingtype = "#type"; 
        public const string OpenNewAccountButton = "input[value='Open New Account']";
        public const string expectedtextcong = "//p[normalize-space()='Congratulations, your account is now open.']";
        public const string navtonewAccount = "//a[@id='newAccountId']"; 
        public const string PageofOpenNewAccount = "a[href='openaccount.htm']";
        public const string Accountno = "#fromAccountId";
        public const string ActivityPriod = "#month";
        public const string Type = "#transactionType";
        public const string GoButton = "input[value='Go']";
        public const string navTransactionDetails = "//a[normalize-space()='Funds Transfer Received']";
        public const string credittype = "//td[normalize-space()='Credit']";
        public const string debittype = "//b[normalize-space()='No transactions found.']";


        //Update Profile Page
        public const string NavigationToUpdateContactInfo = "a[href='updateprofile.htm']";
        public const string ExpectedUpdateInfoText = "//p[contains(text(),'Your updated address and phone number have been ad')]";
        public const string UpdateFirstName = "input[id='customer.firstName']";
        public const string UpdateLastName = "input[id='customer.lastName']";
        public const string  UpdateAddress = "input[id='customer.address.street']";
        public const string UpdateCity = "input[id='customer.address.city']";
        public const string UpdateState = "input[id='customer.address.state']";
        public const string UpdateZipcode = "input[id='customer.address.zipCode']";
        public const string UpdatePhone = "input[id='customer.phoneNumber']";
        public const string UpdateProfileButton = "input[value='Update Profile']";


        //Forget Login Passwpord
        public const string NavigationForgetlogininfo = "//a[normalize-space()='Forgot login info?']";
        public const string Forgetfirstname = "//input[@id='firstName']";
        public const string Forgetlastname = "//input[@id='lastName']";
        public const string ForgetAddress = "//input[@id='address.street']";
        public const string Forgetcity = "//input[@id='address.city']";
        public const string Forgetstate = "//input[@id='address.state']";
        public const string Forgetzipcode = "//input[@id='address.zipCode']";
        public const string Forgetssn = "//input[@id='ssn']";
        public const string ExpectedForgetPassword = "//p[contains(text(),'Your login information was located successfully. Y')]";
        public const string errorForgetFirstname = "//span[@id='firstName.errors']";
        public const string errorForgetLastname = "//span[@id='lastName.errors']";
        public const string errorForgetAddress = "//span[@id='address.street.errors']";
        public const string errorForgetCity = "//span[@id='address.city.errors']";
        public const string errorForgetState = "//span[@id='address.state.errors']";
        public const string errorForgetZipcode = "//span[@id='address.zipCode.errors']";
        public const string errorForgetSSN = "//span[@id='ssn.errors']";
        public const string ForgetPasswordfind = "input[value='Find My Login Info']";


        //Apply for Loan
        public const string NavigationtoApplyforLoan = "a[href='requestloan.htm']";
        public const string LoanAmount = "#amount";
        public const string DownPayment = "#downPayment";
        public const string FromAccount = "#fromAccountId";
        public const string ApplyForLoanButton = "input[value='Apply Now']";
        public const string ExpectedSuccessLoanText = "//p[normalize-space()='Congratulations, your loan has been approved.']";
        public const string navtoNewLoanAccount = "#newAccountId";
        public const string ExpectedTextLoan = "//h1[normalize-space()='Account Details']";
        public const string ErrorApplyLoan = "//p[contains(text(),'You do not have sufficient funds for the given dow')]";
        public const string FieldErrorApplyLoan = "//p[contains(text(),'An internal error has occurred and has been logged')]";


        //  Bill Payment Service
        public const string NavigationtoBillPay = "a[href='billpay.htm']";
        public const string PayeeName = "input[name='payee.name']";
        public const string BillAdress = "input[name='payee.address.street']";
        public const string BillCity = "input[name='payee.address.city']";
        public const string BillState = "input[name='payee.address.state']";
        public const string BillZipcode = "input[name='payee.address.zipCode']";
        public const string BillPhone = "input[name='payee.phoneNumber']";
        public const string BillAccount = "input[name='payee.accountNumber']";
        public const string BillVerifyAccount = "input[name='verifyAccount']";
        public const string BillAmount = "input[name='amount']";
        public const string BillFromAccount = "select[name='fromAccountId']";
        public const string BillPayButton = "input[value='Send Payment']";
        public const string BillPaySuccess = "//p[normalize-space()='See Account Activity for more details.']";
        public const string ErrorPayeename = "//span[@id='validationModel-name']";
        public const string ErrorAddress = "//span[@id='validationModel-address']";
        public const string ErrorCity = "//span[@id='validationModel-city']";
        public const string ErrorState = "//span[@id='validationModel-state']";
        public const string ErrorZipcode = "//span[@id='validationModel-zipCode']";
        public const string ErrorPhone = "//span[@id='validationModel-phoneNumber']";
        public const string ErrorAccount = "//span[@id='validationModel-account-empty']";
        public const string ErrorVerifyAccount = "//span[@id='validationModel-account-empty']";
        public const string ErrorAmount = "//span[@id='validationModel-amount-empty']";
        public const string SpecCharALetAmountError = "//span[@id='validationModel-amount-invalid']";
        public const string NonMatchBillAccountVerify = "//span[@id='validationModel-verifyAccount-mismatch']";


        // Tranfer Fund Page
        public const string NavigationTransferFund = "a[href='transfer.htm']";
        public const string TransferFundAmount = "#amount";
        public const string TransferFundFromAmount = "#fromAccountId";
        public const string TransferFundToAmount = "#toAccountId";
        public const string TransferFundButton = "//input[@value='Transfer']";
        public const string TransferFundSuccess = "//h1[normalize-space()='Transfer Complete!']";
        public const string TransferFundError = "//p[contains(text(),'An internal error has occurred and has been logged')]";

        // Find Transactions

        public const string NavigationToFindTransactions = "a[href='findtrans.htm']";
        public const string FindSelectAmount = "#accountId";
        public const string FindByDate = "#transactionDate";
        public const string FindByDateButton = "//button[@id='findByDate']";
        public const string FindByDateRangeBetween = "//input[@id='fromDate']";
        public const string FindByDateRangeAnd = "//input[@id='toDate']";
        public const string FindByDateRangeButton = "//button[@id='findByDateRange']";
        public const string FindByAmount = "//input[@id='amount']";
        public const string FindByAmountButton = "//button[@id='findByAmount']";
        public const string InvalidFindByDate  = "//span[@id='transactionDateError']";
        public const string InvalidFindByDateRange = "//span[@id='dateRangeError']";
        public const string InvalidFindByAmount = "//span[@id='amountError']";
        public const string ConfirmFindByDate = "//tbody/tr[1]/td[1]";
        public const string ConfirmFindByAmountDebit = "//td[normalize-space()='$515.15']";
        public const string ConfirmFindByAmountCredit = "//td[normalize-space()='$100.00']";
        public const string confirmFindByTransferRecieved = "//td[normalize-space()='$570.00']";
        public const string FindByEXBAD = "//h1[normalize-space()='Transaction Results']";   


    }
}
