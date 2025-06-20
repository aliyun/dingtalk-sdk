// This file is auto-generated, don't edit it. Thanks.
package bizfinance_1_0

import (
	openapi "github.com/alibabacloud-go/darabonba-openapi/v2/client"
	gatewayclient "github.com/alibabacloud-go/gateway-dingtalk/client"
	openapiutil "github.com/alibabacloud-go/openapi-util/service"
	util "github.com/alibabacloud-go/tea-utils/v2/service"
	"github.com/alibabacloud-go/tea/tea"
)

type RoleMemberMapValue struct {
	RoleCode   *string                         `json:"roleCode,omitempty" xml:"roleCode,omitempty"`
	MemberList []*RoleMemberMapValueMemberList `json:"memberList,omitempty" xml:"memberList,omitempty" type:"Repeated"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
}

func (s RoleMemberMapValue) String() string {
	return tea.Prettify(s)
}

func (s RoleMemberMapValue) GoString() string {
	return s.String()
}

func (s *RoleMemberMapValue) SetRoleCode(v string) *RoleMemberMapValue {
	s.RoleCode = &v
	return s
}

func (s *RoleMemberMapValue) SetMemberList(v []*RoleMemberMapValueMemberList) *RoleMemberMapValue {
	s.MemberList = v
	return s
}

func (s *RoleMemberMapValue) SetCompanyCode(v string) *RoleMemberMapValue {
	s.CompanyCode = &v
	return s
}

type RoleMemberMapValueMemberList struct {
	// example:
	//
	// abc
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
	// example:
	//
	// 小明
	Nick *string `json:"nick,omitempty" xml:"nick,omitempty"`
	// example:
	//
	// https://xxxxxxx
	AvatarUrl *string `json:"avatarUrl,omitempty" xml:"avatarUrl,omitempty"`
}

func (s RoleMemberMapValueMemberList) String() string {
	return tea.Prettify(s)
}

func (s RoleMemberMapValueMemberList) GoString() string {
	return s.String()
}

func (s *RoleMemberMapValueMemberList) SetUserId(v string) *RoleMemberMapValueMemberList {
	s.UserId = &v
	return s
}

func (s *RoleMemberMapValueMemberList) SetNick(v string) *RoleMemberMapValueMemberList {
	s.Nick = &v
	return s
}

func (s *RoleMemberMapValueMemberList) SetAvatarUrl(v string) *RoleMemberMapValueMemberList {
	s.AvatarUrl = &v
	return s
}

type AppendRolePermissionHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s AppendRolePermissionHeaders) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionHeaders) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionHeaders) SetCommonHeaders(v map[string]*string) *AppendRolePermissionHeaders {
	s.CommonHeaders = v
	return s
}

func (s *AppendRolePermissionHeaders) SetXAcsDingtalkAccessToken(v string) *AppendRolePermissionHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type AppendRolePermissionRequest struct {
	RolePermissionItemList []*AppendRolePermissionRequestRolePermissionItemList `json:"rolePermissionItemList,omitempty" xml:"rolePermissionItemList,omitempty" type:"Repeated"`
	// example:
	//
	// 5041234
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s AppendRolePermissionRequest) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionRequest) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionRequest) SetRolePermissionItemList(v []*AppendRolePermissionRequestRolePermissionItemList) *AppendRolePermissionRequest {
	s.RolePermissionItemList = v
	return s
}

func (s *AppendRolePermissionRequest) SetUserId(v string) *AppendRolePermissionRequest {
	s.UserId = &v
	return s
}

type AppendRolePermissionRequestRolePermissionItemList struct {
	PermissionList []*AppendRolePermissionRequestRolePermissionItemListPermissionList `json:"permissionList,omitempty" xml:"permissionList,omitempty" type:"Repeated"`
	// example:
	//
	// financeManager
	RoleCode *string `json:"roleCode,omitempty" xml:"roleCode,omitempty"`
}

func (s AppendRolePermissionRequestRolePermissionItemList) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionRequestRolePermissionItemList) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionRequestRolePermissionItemList) SetPermissionList(v []*AppendRolePermissionRequestRolePermissionItemListPermissionList) *AppendRolePermissionRequestRolePermissionItemList {
	s.PermissionList = v
	return s
}

func (s *AppendRolePermissionRequestRolePermissionItemList) SetRoleCode(v string) *AppendRolePermissionRequestRolePermissionItemList {
	s.RoleCode = &v
	return s
}

type AppendRolePermissionRequestRolePermissionItemListPermissionList struct {
	ActionIdList []*string `json:"actionIdList,omitempty" xml:"actionIdList,omitempty" type:"Repeated"`
	// example:
	//
	// /invoice
	ResourceIdentity *string `json:"resourceIdentity,omitempty" xml:"resourceIdentity,omitempty"`
}

func (s AppendRolePermissionRequestRolePermissionItemListPermissionList) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionRequestRolePermissionItemListPermissionList) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionRequestRolePermissionItemListPermissionList) SetActionIdList(v []*string) *AppendRolePermissionRequestRolePermissionItemListPermissionList {
	s.ActionIdList = v
	return s
}

func (s *AppendRolePermissionRequestRolePermissionItemListPermissionList) SetResourceIdentity(v string) *AppendRolePermissionRequestRolePermissionItemListPermissionList {
	s.ResourceIdentity = &v
	return s
}

type AppendRolePermissionShrinkRequest struct {
	RolePermissionItemListShrink *string `json:"rolePermissionItemList,omitempty" xml:"rolePermissionItemList,omitempty"`
	// example:
	//
	// 5041234
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s AppendRolePermissionShrinkRequest) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionShrinkRequest) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionShrinkRequest) SetRolePermissionItemListShrink(v string) *AppendRolePermissionShrinkRequest {
	s.RolePermissionItemListShrink = &v
	return s
}

func (s *AppendRolePermissionShrinkRequest) SetUserId(v string) *AppendRolePermissionShrinkRequest {
	s.UserId = &v
	return s
}

type AppendRolePermissionResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s AppendRolePermissionResponseBody) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionResponseBody) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionResponseBody) SetResult(v bool) *AppendRolePermissionResponseBody {
	s.Result = &v
	return s
}

type AppendRolePermissionResponse struct {
	Headers    map[string]*string                `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                            `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *AppendRolePermissionResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s AppendRolePermissionResponse) String() string {
	return tea.Prettify(s)
}

func (s AppendRolePermissionResponse) GoString() string {
	return s.String()
}

func (s *AppendRolePermissionResponse) SetHeaders(v map[string]*string) *AppendRolePermissionResponse {
	s.Headers = v
	return s
}

func (s *AppendRolePermissionResponse) SetStatusCode(v int32) *AppendRolePermissionResponse {
	s.StatusCode = &v
	return s
}

func (s *AppendRolePermissionResponse) SetBody(v *AppendRolePermissionResponseBody) *AppendRolePermissionResponse {
	s.Body = v
	return s
}

type BatchAddInvoiceHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s BatchAddInvoiceHeaders) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceHeaders) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceHeaders) SetCommonHeaders(v map[string]*string) *BatchAddInvoiceHeaders {
	s.CommonHeaders = v
	return s
}

func (s *BatchAddInvoiceHeaders) SetXAcsDingtalkAccessToken(v string) *BatchAddInvoiceHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type BatchAddInvoiceRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode          *string                                       `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	GeneralInvoiceVOList []*BatchAddInvoiceRequestGeneralInvoiceVOList `json:"generalInvoiceVOList,omitempty" xml:"generalInvoiceVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
	// example:
	//
	// XXX
	OrderId *string `json:"orderId,omitempty" xml:"orderId,omitempty"`
	// example:
	//
	// APPROVAL
	Source *string `json:"source,omitempty" xml:"source,omitempty"`
}

func (s BatchAddInvoiceRequest) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequest) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequest) SetCompanyCode(v string) *BatchAddInvoiceRequest {
	s.CompanyCode = &v
	return s
}

func (s *BatchAddInvoiceRequest) SetGeneralInvoiceVOList(v []*BatchAddInvoiceRequestGeneralInvoiceVOList) *BatchAddInvoiceRequest {
	s.GeneralInvoiceVOList = v
	return s
}

func (s *BatchAddInvoiceRequest) SetOperator(v string) *BatchAddInvoiceRequest {
	s.Operator = &v
	return s
}

func (s *BatchAddInvoiceRequest) SetOrderId(v string) *BatchAddInvoiceRequest {
	s.OrderId = &v
	return s
}

func (s *BatchAddInvoiceRequest) SetSource(v string) *BatchAddInvoiceRequest {
	s.Source = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOList struct {
	// example:
	//
	// abc
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// 100
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// 120
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 1111
	CheckCode *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	// example:
	//
	// 2010-12-12
	CheckTime      *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	DomesticOrIntl *string `json:"domesticOrIntl,omitempty" xml:"domesticOrIntl,omitempty"`
	// example:
	//
	// 张三
	DrawerName *string `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	// example:
	//
	// 2022-12-10
	DrewDate                     *string                                                                   `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	EFlightItineraryDetailVOList []*BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList `json:"eFlightItineraryDetailVOList,omitempty" xml:"eFlightItineraryDetailVOList,omitempty" type:"Repeated"`
	ETicketNo                    *string                                                                   `json:"eTicketNo,omitempty" xml:"eTicketNo,omitempty"`
	ETrainTicketDetailVOList     []*BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList     `json:"eTrainTicketDetailVOList,omitempty" xml:"eTrainTicketDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	ElectronicUrl *string `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	FileId        *string `json:"fileId,omitempty" xml:"fileId,omitempty"`
	// example:
	//
	// INPUT_VAT
	FinanceType *string `json:"financeType,omitempty" xml:"financeType,omitempty"`
	// example:
	//
	// RED
	FundType                   *string                                                                 `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	GpNo                       *string                                                                 `json:"gpNo,omitempty" xml:"gpNo,omitempty"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// abc
	InvoiceStatus *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	// example:
	//
	// INTPUT_VAT
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// 1111
	MachineCode *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	OfdUrl      *string `json:"ofdUrl,omitempty" xml:"ofdUrl,omitempty"`
	// example:
	//
	// abc
	OilFlag         *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	Passenger       *string `json:"passenger,omitempty" xml:"passenger,omitempty"`
	PassengerUserId *string `json:"passengerUserId,omitempty" xml:"passengerUserId,omitempty"`
	// example:
	//
	// abc
	Payee  *string `json:"payee,omitempty" xml:"payee,omitempty"`
	PdfUrl *string `json:"pdfUrl,omitempty" xml:"pdfUrl,omitempty"`
	// example:
	//
	// abc
	ProcessInstCode *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	// example:
	//
	// abc
	ProcessInstType *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress     *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	PurchaserBankAccount *string `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	// example:
	//
	// 建行
	PurchaserBankNameAccount *string `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	// example:
	//
	// 张三
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 155655
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 1333333333
	PurchaserTel  *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	ReceiverEmail *string `json:"receiverEmail,omitempty" xml:"receiverEmail,omitempty"`
	ReceiverName  *string `json:"receiverName,omitempty" xml:"receiverName,omitempty"`
	ReceiverTel   *string `json:"receiverTel,omitempty" xml:"receiverTel,omitempty"`
	// example:
	//
	// abc
	Remark                         *string                                                                     `json:"remark,omitempty" xml:"remark,omitempty"`
	Reviewer                       *string                                                                     `json:"reviewer,omitempty" xml:"reviewer,omitempty"`
	SecondHandCarInvoiceDetailList []*BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	// example:
	//
	// 8852
	SellerAddress     *string `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	SellerBankAccount *string `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	// example:
	//
	// 招商银行
	SellerBankNameAccount *string `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	// example:
	//
	// 李四
	SellerName *string `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	// example:
	//
	// 2202
	SellerTaxNo *string `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	// example:
	//
	// 13355222222
	SellerTel *string `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	SpaceId   *string `json:"spaceId,omitempty" xml:"spaceId,omitempty"`
	// example:
	//
	// abc
	SupplySign *string `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	// example:
	//
	// 20
	TaxAmount                   *string                                                                  `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	UsedVehicleSaleDetailVOList []*BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	// example:
	//
	// abc
	VoucherCode *string `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	// example:
	//
	// abc
	VoucherStatus *string `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
	XmlUrl        *string `json:"xmlUrl,omitempty" xml:"xmlUrl,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetAccountPeriod(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.AccountPeriod = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetAmount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.Amount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetAmountWithTax(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.AmountWithTax = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetCheckCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.CheckCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetCheckTime(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.CheckTime = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetDomesticOrIntl(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.DomesticOrIntl = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetDrawerName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.DrawerName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetDrewDate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.DrewDate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetEFlightItineraryDetailVOList(v []*BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.EFlightItineraryDetailVOList = v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetETicketNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ETicketNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetETrainTicketDetailVOList(v []*BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ETrainTicketDetailVOList = v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetElectronicUrl(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ElectronicUrl = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetFileId(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.FileId = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetFinanceType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.FinanceType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetFundType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.FundType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetGeneralInvoiceDetailVOList(v []*BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetGpNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.GpNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetImageUrl(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ImageUrl = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetInvoiceCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.InvoiceCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetInvoiceNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.InvoiceNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetInvoiceStatus(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.InvoiceStatus = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetInvoiceType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.InvoiceType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetMachineCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.MachineCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetOfdUrl(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.OfdUrl = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetOilFlag(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.OilFlag = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPassenger(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.Passenger = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPassengerUserId(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PassengerUserId = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPayee(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.Payee = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPdfUrl(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PdfUrl = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetProcessInstCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ProcessInstCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetProcessInstType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ProcessInstType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPurchaserAddress(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PurchaserAddress = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPurchaserBankAccount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PurchaserBankAccount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPurchaserBankNameAccount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPurchaserName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PurchaserName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPurchaserTaxNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetPurchaserTel(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.PurchaserTel = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetReceiverEmail(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ReceiverEmail = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetReceiverName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ReceiverName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetReceiverTel(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.ReceiverTel = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetRemark(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.Remark = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetReviewer(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.Reviewer = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSecondHandCarInvoiceDetailList(v []*BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSellerAddress(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SellerAddress = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSellerBankAccount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SellerBankAccount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSellerBankNameAccount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SellerBankNameAccount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSellerName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SellerName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSellerTaxNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SellerTaxNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSellerTel(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SellerTel = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSpaceId(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SpaceId = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetSupplySign(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.SupplySign = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetTaxAmount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.TaxAmount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetUsedVehicleSaleDetailVOList(v []*BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetVehicleSaleDetailVOList(v []*BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetVerifyStatus(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.VerifyStatus = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetVoucherCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.VoucherCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetVoucherStatus(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.VoucherStatus = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOList) SetXmlUrl(v string) *BatchAddInvoiceRequestGeneralInvoiceVOList {
	s.XmlUrl = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList struct {
	Carrier             *string `json:"carrier,omitempty" xml:"carrier,omitempty"`
	ClassName           *string `json:"className,omitempty" xml:"className,omitempty"`
	FlightNumber        *string `json:"flightNumber,omitempty" xml:"flightNumber,omitempty"`
	FlyDate             *string `json:"flyDate,omitempty" xml:"flyDate,omitempty"`
	FlyFrom             *string `json:"flyFrom,omitempty" xml:"flyFrom,omitempty"`
	FlyTime             *string `json:"flyTime,omitempty" xml:"flyTime,omitempty"`
	FlyTo               *string `json:"flyTo,omitempty" xml:"flyTo,omitempty"`
	InvoiceDetailNumber *string `json:"invoiceDetailNumber,omitempty" xml:"invoiceDetailNumber,omitempty"`
	InvoiceId           *string `json:"invoiceId,omitempty" xml:"invoiceId,omitempty"`
	Seat                *string `json:"seat,omitempty" xml:"seat,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetCarrier(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.Carrier = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetClassName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.ClassName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetFlightNumber(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.FlightNumber = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetFlyDate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.FlyDate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetFlyFrom(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.FlyFrom = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetFlyTime(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.FlyTime = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetFlyTo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.FlyTo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetInvoiceDetailNumber(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.InvoiceDetailNumber = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetInvoiceId(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.InvoiceId = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList) SetSeat(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList {
	s.Seat = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList struct {
	AirConditionType *string `json:"airConditionType,omitempty" xml:"airConditionType,omitempty"`
	CarriageNo       *string `json:"carriageNo,omitempty" xml:"carriageNo,omitempty"`
	Destination      *string `json:"destination,omitempty" xml:"destination,omitempty"`
	EticketNo        *string `json:"eticketNo,omitempty" xml:"eticketNo,omitempty"`
	GetOnTime        *string `json:"getOnTime,omitempty" xml:"getOnTime,omitempty"`
	InvoiceId        *string `json:"invoiceId,omitempty" xml:"invoiceId,omitempty"`
	Origin           *string `json:"origin,omitempty" xml:"origin,omitempty"`
	Passenger        *string `json:"passenger,omitempty" xml:"passenger,omitempty"`
	PassengerUserId  *string `json:"passengerUserId,omitempty" xml:"passengerUserId,omitempty"`
	Remark           *string `json:"remark,omitempty" xml:"remark,omitempty"`
	SeatClass        *string `json:"seatClass,omitempty" xml:"seatClass,omitempty"`
	StartTime        *string `json:"startTime,omitempty" xml:"startTime,omitempty"`
	TaxRate          *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	TicketType       *string `json:"ticketType,omitempty" xml:"ticketType,omitempty"`
	TrainNo          *string `json:"trainNo,omitempty" xml:"trainNo,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetAirConditionType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.AirConditionType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetCarriageNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.CarriageNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetDestination(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.Destination = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetEticketNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.EticketNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetGetOnTime(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.GetOnTime = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetInvoiceId(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.InvoiceId = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetOrigin(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.Origin = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetPassenger(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.Passenger = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetPassengerUserId(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.PassengerUserId = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetRemark(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.Remark = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetSeatClass(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.SeatClass = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetStartTime(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.StartTime = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetTaxRate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetTicketType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.TicketType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList) SetTrainNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList {
	s.TrainNo = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	TaxPreType    *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate       *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit          *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice     *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetAmount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetGoodsName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetQuantity(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRevenueCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRowNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetSpecification(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxAmount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPre(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPreType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxRate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnit(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnitPrice(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetAmount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetCardNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetEndDate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetGoodsName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRowNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetStartDate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxRate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetVehicleType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCarModel(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCardNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetRegistration(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	InspectionListNo    *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers       *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace         *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo    *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName    *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo      *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate             *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage             *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo           *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType         *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetBrand(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetCertificateNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetEngineNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetIdCardNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetImportCertificateNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetInspectionListNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetMaxPassengers(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetOriginPlace(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxRate(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTonnage(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleNo(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleType(v string) *BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type BatchAddInvoiceResponseBody struct {
	ErrorResult   []*BatchAddInvoiceResponseBodyErrorResult   `json:"errorResult,omitempty" xml:"errorResult,omitempty" type:"Repeated"`
	SuccessResult []*BatchAddInvoiceResponseBodySuccessResult `json:"successResult,omitempty" xml:"successResult,omitempty" type:"Repeated"`
}

func (s BatchAddInvoiceResponseBody) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceResponseBody) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceResponseBody) SetErrorResult(v []*BatchAddInvoiceResponseBodyErrorResult) *BatchAddInvoiceResponseBody {
	s.ErrorResult = v
	return s
}

func (s *BatchAddInvoiceResponseBody) SetSuccessResult(v []*BatchAddInvoiceResponseBodySuccessResult) *BatchAddInvoiceResponseBody {
	s.SuccessResult = v
	return s
}

type BatchAddInvoiceResponseBodyErrorResult struct {
	// example:
	//
	// abc
	ErrorKey *string `json:"errorKey,omitempty" xml:"errorKey,omitempty"`
	// example:
	//
	// abc
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
}

func (s BatchAddInvoiceResponseBodyErrorResult) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceResponseBodyErrorResult) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceResponseBodyErrorResult) SetErrorKey(v string) *BatchAddInvoiceResponseBodyErrorResult {
	s.ErrorKey = &v
	return s
}

func (s *BatchAddInvoiceResponseBodyErrorResult) SetErrorMsg(v string) *BatchAddInvoiceResponseBodyErrorResult {
	s.ErrorMsg = &v
	return s
}

type BatchAddInvoiceResponseBodySuccessResult struct {
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo   *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s BatchAddInvoiceResponseBodySuccessResult) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceResponseBodySuccessResult) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceResponseBodySuccessResult) SetInvoiceCode(v string) *BatchAddInvoiceResponseBodySuccessResult {
	s.InvoiceCode = &v
	return s
}

func (s *BatchAddInvoiceResponseBodySuccessResult) SetInvoiceNo(v string) *BatchAddInvoiceResponseBodySuccessResult {
	s.InvoiceNo = &v
	return s
}

type BatchAddInvoiceResponse struct {
	Headers    map[string]*string           `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                       `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *BatchAddInvoiceResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s BatchAddInvoiceResponse) String() string {
	return tea.Prettify(s)
}

func (s BatchAddInvoiceResponse) GoString() string {
	return s.String()
}

func (s *BatchAddInvoiceResponse) SetHeaders(v map[string]*string) *BatchAddInvoiceResponse {
	s.Headers = v
	return s
}

func (s *BatchAddInvoiceResponse) SetStatusCode(v int32) *BatchAddInvoiceResponse {
	s.StatusCode = &v
	return s
}

func (s *BatchAddInvoiceResponse) SetBody(v *BatchAddInvoiceResponseBody) *BatchAddInvoiceResponse {
	s.Body = v
	return s
}

type BatchCreateCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s BatchCreateCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s BatchCreateCustomerHeaders) GoString() string {
	return s.String()
}

func (s *BatchCreateCustomerHeaders) SetCommonHeaders(v map[string]*string) *BatchCreateCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *BatchCreateCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *BatchCreateCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type BatchCreateCustomerRequest struct {
	CreateCustomerRequestList []*BatchCreateCustomerRequestCreateCustomerRequestList `json:"createCustomerRequestList,omitempty" xml:"createCustomerRequestList,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// 55001121
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s BatchCreateCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s BatchCreateCustomerRequest) GoString() string {
	return s.String()
}

func (s *BatchCreateCustomerRequest) SetCreateCustomerRequestList(v []*BatchCreateCustomerRequestCreateCustomerRequestList) *BatchCreateCustomerRequest {
	s.CreateCustomerRequestList = v
	return s
}

func (s *BatchCreateCustomerRequest) SetOperator(v string) *BatchCreateCustomerRequest {
	s.Operator = &v
	return s
}

type BatchCreateCustomerRequestCreateCustomerRequestList struct {
	// example:
	//
	// abc
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// example:
	//
	// www.abc.com
	DrawerEmail *string `json:"drawerEmail,omitempty" xml:"drawerEmail,omitempty"`
	// example:
	//
	// 1234567890
	DrawerTelephone *string `json:"drawerTelephone,omitempty" xml:"drawerTelephone,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 张三
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// abc
	PurchaserAccount *string `json:"purchaserAccount,omitempty" xml:"purchaserAccount,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// 建行
	PurchaserBankName *string `json:"purchaserBankName,omitempty" xml:"purchaserBankName,omitempty"`
	// example:
	//
	// 李四
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 1333
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 13333333333
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
}

func (s BatchCreateCustomerRequestCreateCustomerRequestList) String() string {
	return tea.Prettify(s)
}

func (s BatchCreateCustomerRequestCreateCustomerRequestList) GoString() string {
	return s.String()
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetDescription(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.Description = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetDrawerEmail(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.DrawerEmail = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetDrawerTelephone(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.DrawerTelephone = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetName(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.Name = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetPurchaserAccount(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.PurchaserAccount = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetPurchaserAddress(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.PurchaserAddress = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetPurchaserBankName(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.PurchaserBankName = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetPurchaserName(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.PurchaserName = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetPurchaserTaxNo(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *BatchCreateCustomerRequestCreateCustomerRequestList) SetPurchaserTel(v string) *BatchCreateCustomerRequestCreateCustomerRequestList {
	s.PurchaserTel = &v
	return s
}

type BatchCreateCustomerResponseBody struct {
	ErrorResult []*BatchCreateCustomerResponseBodyErrorResult `json:"errorResult,omitempty" xml:"errorResult,omitempty" type:"Repeated"`
	Success     *bool                                         `json:"success,omitempty" xml:"success,omitempty"`
}

func (s BatchCreateCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s BatchCreateCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *BatchCreateCustomerResponseBody) SetErrorResult(v []*BatchCreateCustomerResponseBodyErrorResult) *BatchCreateCustomerResponseBody {
	s.ErrorResult = v
	return s
}

func (s *BatchCreateCustomerResponseBody) SetSuccess(v bool) *BatchCreateCustomerResponseBody {
	s.Success = &v
	return s
}

type BatchCreateCustomerResponseBodyErrorResult struct {
	ErrorKey *string `json:"errorKey,omitempty" xml:"errorKey,omitempty"`
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
}

func (s BatchCreateCustomerResponseBodyErrorResult) String() string {
	return tea.Prettify(s)
}

func (s BatchCreateCustomerResponseBodyErrorResult) GoString() string {
	return s.String()
}

func (s *BatchCreateCustomerResponseBodyErrorResult) SetErrorKey(v string) *BatchCreateCustomerResponseBodyErrorResult {
	s.ErrorKey = &v
	return s
}

func (s *BatchCreateCustomerResponseBodyErrorResult) SetErrorMsg(v string) *BatchCreateCustomerResponseBodyErrorResult {
	s.ErrorMsg = &v
	return s
}

type BatchCreateCustomerResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *BatchCreateCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s BatchCreateCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s BatchCreateCustomerResponse) GoString() string {
	return s.String()
}

func (s *BatchCreateCustomerResponse) SetHeaders(v map[string]*string) *BatchCreateCustomerResponse {
	s.Headers = v
	return s
}

func (s *BatchCreateCustomerResponse) SetStatusCode(v int32) *BatchCreateCustomerResponse {
	s.StatusCode = &v
	return s
}

func (s *BatchCreateCustomerResponse) SetBody(v *BatchCreateCustomerResponseBody) *BatchCreateCustomerResponse {
	s.Body = v
	return s
}

type BeginConsumeHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s BeginConsumeHeaders) String() string {
	return tea.Prettify(s)
}

func (s BeginConsumeHeaders) GoString() string {
	return s.String()
}

func (s *BeginConsumeHeaders) SetCommonHeaders(v map[string]*string) *BeginConsumeHeaders {
	s.CommonHeaders = v
	return s
}

func (s *BeginConsumeHeaders) SetXAcsDingtalkAccessToken(v string) *BeginConsumeHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type BeginConsumeRequest struct {
	// example:
	//
	// B_SF2_INVOICE_OCR
	BenefitCode *string `json:"benefitCode,omitempty" xml:"benefitCode,omitempty"`
	// example:
	//
	// XXX
	BizRequestId *string `json:"bizRequestId,omitempty" xml:"bizRequestId,omitempty"`
	Quota        *int64  `json:"quota,omitempty" xml:"quota,omitempty"`
	UserId       *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s BeginConsumeRequest) String() string {
	return tea.Prettify(s)
}

func (s BeginConsumeRequest) GoString() string {
	return s.String()
}

func (s *BeginConsumeRequest) SetBenefitCode(v string) *BeginConsumeRequest {
	s.BenefitCode = &v
	return s
}

func (s *BeginConsumeRequest) SetBizRequestId(v string) *BeginConsumeRequest {
	s.BizRequestId = &v
	return s
}

func (s *BeginConsumeRequest) SetQuota(v int64) *BeginConsumeRequest {
	s.Quota = &v
	return s
}

func (s *BeginConsumeRequest) SetUserId(v string) *BeginConsumeRequest {
	s.UserId = &v
	return s
}

type BeginConsumeResponseBody struct {
	Result *BeginConsumeResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s BeginConsumeResponseBody) String() string {
	return tea.Prettify(s)
}

func (s BeginConsumeResponseBody) GoString() string {
	return s.String()
}

func (s *BeginConsumeResponseBody) SetResult(v *BeginConsumeResponseBodyResult) *BeginConsumeResponseBody {
	s.Result = v
	return s
}

type BeginConsumeResponseBodyResult struct {
	IsSuccess *bool `json:"isSuccess,omitempty" xml:"isSuccess,omitempty"`
}

func (s BeginConsumeResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s BeginConsumeResponseBodyResult) GoString() string {
	return s.String()
}

func (s *BeginConsumeResponseBodyResult) SetIsSuccess(v bool) *BeginConsumeResponseBodyResult {
	s.IsSuccess = &v
	return s
}

type BeginConsumeResponse struct {
	Headers    map[string]*string        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *BeginConsumeResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s BeginConsumeResponse) String() string {
	return tea.Prettify(s)
}

func (s BeginConsumeResponse) GoString() string {
	return s.String()
}

func (s *BeginConsumeResponse) SetHeaders(v map[string]*string) *BeginConsumeResponse {
	s.Headers = v
	return s
}

func (s *BeginConsumeResponse) SetStatusCode(v int32) *BeginConsumeResponse {
	s.StatusCode = &v
	return s
}

func (s *BeginConsumeResponse) SetBody(v *BeginConsumeResponseBody) *BeginConsumeResponse {
	s.Body = v
	return s
}

type BindCompanyAccountantBookHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s BindCompanyAccountantBookHeaders) String() string {
	return tea.Prettify(s)
}

func (s BindCompanyAccountantBookHeaders) GoString() string {
	return s.String()
}

func (s *BindCompanyAccountantBookHeaders) SetCommonHeaders(v map[string]*string) *BindCompanyAccountantBookHeaders {
	s.CommonHeaders = v
	return s
}

func (s *BindCompanyAccountantBookHeaders) SetXAcsDingtalkAccessToken(v string) *BindCompanyAccountantBookHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type BindCompanyAccountantBookRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// abc
	AccountantBookId *string `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
}

func (s BindCompanyAccountantBookRequest) String() string {
	return tea.Prettify(s)
}

func (s BindCompanyAccountantBookRequest) GoString() string {
	return s.String()
}

func (s *BindCompanyAccountantBookRequest) SetAccountantBookId(v string) *BindCompanyAccountantBookRequest {
	s.AccountantBookId = &v
	return s
}

func (s *BindCompanyAccountantBookRequest) SetCompanyCode(v string) *BindCompanyAccountantBookRequest {
	s.CompanyCode = &v
	return s
}

type BindCompanyAccountantBookResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s BindCompanyAccountantBookResponseBody) String() string {
	return tea.Prettify(s)
}

func (s BindCompanyAccountantBookResponseBody) GoString() string {
	return s.String()
}

func (s *BindCompanyAccountantBookResponseBody) SetResult(v bool) *BindCompanyAccountantBookResponseBody {
	s.Result = &v
	return s
}

type BindCompanyAccountantBookResponse struct {
	Headers    map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *BindCompanyAccountantBookResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s BindCompanyAccountantBookResponse) String() string {
	return tea.Prettify(s)
}

func (s BindCompanyAccountantBookResponse) GoString() string {
	return s.String()
}

func (s *BindCompanyAccountantBookResponse) SetHeaders(v map[string]*string) *BindCompanyAccountantBookResponse {
	s.Headers = v
	return s
}

func (s *BindCompanyAccountantBookResponse) SetStatusCode(v int32) *BindCompanyAccountantBookResponse {
	s.StatusCode = &v
	return s
}

func (s *BindCompanyAccountantBookResponse) SetBody(v *BindCompanyAccountantBookResponseBody) *BindCompanyAccountantBookResponse {
	s.Body = v
	return s
}

type CancelConsumeHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CancelConsumeHeaders) String() string {
	return tea.Prettify(s)
}

func (s CancelConsumeHeaders) GoString() string {
	return s.String()
}

func (s *CancelConsumeHeaders) SetCommonHeaders(v map[string]*string) *CancelConsumeHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CancelConsumeHeaders) SetXAcsDingtalkAccessToken(v string) *CancelConsumeHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CancelConsumeRequest struct {
	// example:
	//
	// B_SF2_INVOICE_OCR
	BenefitCode *string `json:"benefitCode,omitempty" xml:"benefitCode,omitempty"`
	// example:
	//
	// XXX
	BizRequestId *string `json:"bizRequestId,omitempty" xml:"bizRequestId,omitempty"`
	// example:
	//
	// 1
	Quota  *int64  `json:"quota,omitempty" xml:"quota,omitempty"`
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s CancelConsumeRequest) String() string {
	return tea.Prettify(s)
}

func (s CancelConsumeRequest) GoString() string {
	return s.String()
}

func (s *CancelConsumeRequest) SetBenefitCode(v string) *CancelConsumeRequest {
	s.BenefitCode = &v
	return s
}

func (s *CancelConsumeRequest) SetBizRequestId(v string) *CancelConsumeRequest {
	s.BizRequestId = &v
	return s
}

func (s *CancelConsumeRequest) SetQuota(v int64) *CancelConsumeRequest {
	s.Quota = &v
	return s
}

func (s *CancelConsumeRequest) SetUserId(v string) *CancelConsumeRequest {
	s.UserId = &v
	return s
}

type CancelConsumeResponseBody struct {
	Result *CancelConsumeResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s CancelConsumeResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CancelConsumeResponseBody) GoString() string {
	return s.String()
}

func (s *CancelConsumeResponseBody) SetResult(v *CancelConsumeResponseBodyResult) *CancelConsumeResponseBody {
	s.Result = v
	return s
}

type CancelConsumeResponseBodyResult struct {
	IsSuccess *bool `json:"isSuccess,omitempty" xml:"isSuccess,omitempty"`
}

func (s CancelConsumeResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s CancelConsumeResponseBodyResult) GoString() string {
	return s.String()
}

func (s *CancelConsumeResponseBodyResult) SetIsSuccess(v bool) *CancelConsumeResponseBodyResult {
	s.IsSuccess = &v
	return s
}

type CancelConsumeResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CancelConsumeResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CancelConsumeResponse) String() string {
	return tea.Prettify(s)
}

func (s CancelConsumeResponse) GoString() string {
	return s.String()
}

func (s *CancelConsumeResponse) SetHeaders(v map[string]*string) *CancelConsumeResponse {
	s.Headers = v
	return s
}

func (s *CancelConsumeResponse) SetStatusCode(v int32) *CancelConsumeResponse {
	s.StatusCode = &v
	return s
}

func (s *CancelConsumeResponse) SetBody(v *CancelConsumeResponseBody) *CancelConsumeResponse {
	s.Body = v
	return s
}

type CheckVoucherStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CheckVoucherStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s CheckVoucherStatusHeaders) GoString() string {
	return s.String()
}

func (s *CheckVoucherStatusHeaders) SetCommonHeaders(v map[string]*string) *CheckVoucherStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CheckVoucherStatusHeaders) SetXAcsDingtalkAccessToken(v string) *CheckVoucherStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CheckVoucherStatusRequest struct {
	// example:
	//
	// COM_DEFUALT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 1631526550994
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// example:
	//
	// VAT_IN
	FinanceType *string `json:"financeType,omitempty" xml:"financeType,omitempty"`
	// example:
	//
	// 3121234560
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 1234567890
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// example:
	//
	// 100
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
	// example:
	//
	// 1631526550994
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
	// example:
	//
	// 12345678901
	TaxNo *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
	// example:
	//
	// VERIFIED
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
}

func (s CheckVoucherStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s CheckVoucherStatusRequest) GoString() string {
	return s.String()
}

func (s *CheckVoucherStatusRequest) SetCompanyCode(v string) *CheckVoucherStatusRequest {
	s.CompanyCode = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetEndTime(v int64) *CheckVoucherStatusRequest {
	s.EndTime = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetFinanceType(v string) *CheckVoucherStatusRequest {
	s.FinanceType = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetInvoiceCode(v string) *CheckVoucherStatusRequest {
	s.InvoiceCode = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetInvoiceNo(v string) *CheckVoucherStatusRequest {
	s.InvoiceNo = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetPageNumber(v int64) *CheckVoucherStatusRequest {
	s.PageNumber = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetPageSize(v int64) *CheckVoucherStatusRequest {
	s.PageSize = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetStartTime(v int64) *CheckVoucherStatusRequest {
	s.StartTime = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetTaxNo(v string) *CheckVoucherStatusRequest {
	s.TaxNo = &v
	return s
}

func (s *CheckVoucherStatusRequest) SetVerifyStatus(v string) *CheckVoucherStatusRequest {
	s.VerifyStatus = &v
	return s
}

type CheckVoucherStatusResponseBody struct {
	Result  *bool `json:"result,omitempty" xml:"result,omitempty"`
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s CheckVoucherStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CheckVoucherStatusResponseBody) GoString() string {
	return s.String()
}

func (s *CheckVoucherStatusResponseBody) SetResult(v bool) *CheckVoucherStatusResponseBody {
	s.Result = &v
	return s
}

func (s *CheckVoucherStatusResponseBody) SetSuccess(v bool) *CheckVoucherStatusResponseBody {
	s.Success = &v
	return s
}

type CheckVoucherStatusResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CheckVoucherStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CheckVoucherStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s CheckVoucherStatusResponse) GoString() string {
	return s.String()
}

func (s *CheckVoucherStatusResponse) SetHeaders(v map[string]*string) *CheckVoucherStatusResponse {
	s.Headers = v
	return s
}

func (s *CheckVoucherStatusResponse) SetStatusCode(v int32) *CheckVoucherStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *CheckVoucherStatusResponse) SetBody(v *CheckVoucherStatusResponseBody) *CheckVoucherStatusResponse {
	s.Body = v
	return s
}

type CommitConsumeHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CommitConsumeHeaders) String() string {
	return tea.Prettify(s)
}

func (s CommitConsumeHeaders) GoString() string {
	return s.String()
}

func (s *CommitConsumeHeaders) SetCommonHeaders(v map[string]*string) *CommitConsumeHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CommitConsumeHeaders) SetXAcsDingtalkAccessToken(v string) *CommitConsumeHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CommitConsumeRequest struct {
	// example:
	//
	// B_SF2_INVOICE_OCR
	BenefitCode  *string `json:"benefitCode,omitempty" xml:"benefitCode,omitempty"`
	BizRequestId *string `json:"bizRequestId,omitempty" xml:"bizRequestId,omitempty"`
	// example:
	//
	// 1
	Quota  *int64  `json:"quota,omitempty" xml:"quota,omitempty"`
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s CommitConsumeRequest) String() string {
	return tea.Prettify(s)
}

func (s CommitConsumeRequest) GoString() string {
	return s.String()
}

func (s *CommitConsumeRequest) SetBenefitCode(v string) *CommitConsumeRequest {
	s.BenefitCode = &v
	return s
}

func (s *CommitConsumeRequest) SetBizRequestId(v string) *CommitConsumeRequest {
	s.BizRequestId = &v
	return s
}

func (s *CommitConsumeRequest) SetQuota(v int64) *CommitConsumeRequest {
	s.Quota = &v
	return s
}

func (s *CommitConsumeRequest) SetUserId(v string) *CommitConsumeRequest {
	s.UserId = &v
	return s
}

type CommitConsumeResponseBody struct {
	Result *CommitConsumeResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s CommitConsumeResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CommitConsumeResponseBody) GoString() string {
	return s.String()
}

func (s *CommitConsumeResponseBody) SetResult(v *CommitConsumeResponseBodyResult) *CommitConsumeResponseBody {
	s.Result = v
	return s
}

type CommitConsumeResponseBodyResult struct {
	IsSuccess *bool `json:"isSuccess,omitempty" xml:"isSuccess,omitempty"`
}

func (s CommitConsumeResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s CommitConsumeResponseBodyResult) GoString() string {
	return s.String()
}

func (s *CommitConsumeResponseBodyResult) SetIsSuccess(v bool) *CommitConsumeResponseBodyResult {
	s.IsSuccess = &v
	return s
}

type CommitConsumeResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CommitConsumeResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CommitConsumeResponse) String() string {
	return tea.Prettify(s)
}

func (s CommitConsumeResponse) GoString() string {
	return s.String()
}

func (s *CommitConsumeResponse) SetHeaders(v map[string]*string) *CommitConsumeResponse {
	s.Headers = v
	return s
}

func (s *CommitConsumeResponse) SetStatusCode(v int32) *CommitConsumeResponse {
	s.StatusCode = &v
	return s
}

func (s *CommitConsumeResponse) SetBody(v *CommitConsumeResponseBody) *CommitConsumeResponse {
	s.Body = v
	return s
}

type CreateCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CreateCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerHeaders) GoString() string {
	return s.String()
}

func (s *CreateCustomerHeaders) SetCommonHeaders(v map[string]*string) *CreateCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CreateCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *CreateCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CreateCustomerRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 55001121
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
	// example:
	//
	// abc
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// example:
	//
	// www.abc.com
	DrawerEmail *string `json:"drawerEmail,omitempty" xml:"drawerEmail,omitempty"`
	// example:
	//
	// 12345678901
	DrawerTelephone *string `json:"drawerTelephone,omitempty" xml:"drawerTelephone,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 张三
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// abc
	PurchaserAccount *string `json:"purchaserAccount,omitempty" xml:"purchaserAccount,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// 建行
	PurchaserBankName *string `json:"purchaserBankName,omitempty" xml:"purchaserBankName,omitempty"`
	// example:
	//
	// 李四
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 1333
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 13333333333
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
}

func (s CreateCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerRequest) GoString() string {
	return s.String()
}

func (s *CreateCustomerRequest) SetCreator(v string) *CreateCustomerRequest {
	s.Creator = &v
	return s
}

func (s *CreateCustomerRequest) SetDescription(v string) *CreateCustomerRequest {
	s.Description = &v
	return s
}

func (s *CreateCustomerRequest) SetDrawerEmail(v string) *CreateCustomerRequest {
	s.DrawerEmail = &v
	return s
}

func (s *CreateCustomerRequest) SetDrawerTelephone(v string) *CreateCustomerRequest {
	s.DrawerTelephone = &v
	return s
}

func (s *CreateCustomerRequest) SetName(v string) *CreateCustomerRequest {
	s.Name = &v
	return s
}

func (s *CreateCustomerRequest) SetPurchaserAccount(v string) *CreateCustomerRequest {
	s.PurchaserAccount = &v
	return s
}

func (s *CreateCustomerRequest) SetPurchaserAddress(v string) *CreateCustomerRequest {
	s.PurchaserAddress = &v
	return s
}

func (s *CreateCustomerRequest) SetPurchaserBankName(v string) *CreateCustomerRequest {
	s.PurchaserBankName = &v
	return s
}

func (s *CreateCustomerRequest) SetPurchaserName(v string) *CreateCustomerRequest {
	s.PurchaserName = &v
	return s
}

func (s *CreateCustomerRequest) SetPurchaserTaxNo(v string) *CreateCustomerRequest {
	s.PurchaserTaxNo = &v
	return s
}

func (s *CreateCustomerRequest) SetPurchaserTel(v string) *CreateCustomerRequest {
	s.PurchaserTel = &v
	return s
}

type CreateCustomerResponseBody struct {
	// example:
	//
	// CUS_xxxxxx
	CustomerCode *string `json:"customerCode,omitempty" xml:"customerCode,omitempty"`
}

func (s CreateCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *CreateCustomerResponseBody) SetCustomerCode(v string) *CreateCustomerResponseBody {
	s.CustomerCode = &v
	return s
}

type CreateCustomerResponse struct {
	Headers    map[string]*string          `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                      `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CreateCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CreateCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerResponse) GoString() string {
	return s.String()
}

func (s *CreateCustomerResponse) SetHeaders(v map[string]*string) *CreateCustomerResponse {
	s.Headers = v
	return s
}

func (s *CreateCustomerResponse) SetStatusCode(v int32) *CreateCustomerResponse {
	s.StatusCode = &v
	return s
}

func (s *CreateCustomerResponse) SetBody(v *CreateCustomerResponseBody) *CreateCustomerResponse {
	s.Body = v
	return s
}

type CreateReceiptHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CreateReceiptHeaders) String() string {
	return tea.Prettify(s)
}

func (s CreateReceiptHeaders) GoString() string {
	return s.String()
}

func (s *CreateReceiptHeaders) SetCommonHeaders(v map[string]*string) *CreateReceiptHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CreateReceiptHeaders) SetXAcsDingtalkAccessToken(v string) *CreateReceiptHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CreateReceiptRequest struct {
	// This parameter is required.
	Receipts []*CreateReceiptRequestReceipts `json:"receipts,omitempty" xml:"receipts,omitempty" type:"Repeated"`
}

func (s CreateReceiptRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateReceiptRequest) GoString() string {
	return s.String()
}

func (s *CreateReceiptRequest) SetReceipts(v []*CreateReceiptRequestReceipts) *CreateReceiptRequest {
	s.Receipts = v
	return s
}

type CreateReceiptRequestReceipts struct {
	// This parameter is required.
	//
	// example:
	//
	// 4.44
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// INC_XXX
	CategoryCode *string `json:"categoryCode,omitempty" xml:"categoryCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// abcd_efgh
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// 1636445218000
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// emp_xxx
	CreateUserId *string `json:"createUserId,omitempty" xml:"createUserId,omitempty"`
	// example:
	//
	// CUS_XXX
	CustomerCode *string `json:"customerCode,omitempty" xml:"customerCode,omitempty"`
	// example:
	//
	// ACC_XXX
	EnterpriseAcountCode *string `json:"enterpriseAcountCode,omitempty" xml:"enterpriseAcountCode,omitempty"`
	// example:
	//
	// 1636445218000
	OccurDate *int64 `json:"occurDate,omitempty" xml:"occurDate,omitempty"`
	// example:
	//
	// emp_xxx
	PrincipalId *string `json:"principalId,omitempty" xml:"principalId,omitempty"`
	// example:
	//
	// PROJ_XXX
	ProjectCode *string `json:"projectCode,omitempty" xml:"projectCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1
	ReceiptType *int64 `json:"receiptType,omitempty" xml:"receiptType,omitempty"`
	// example:
	//
	// 测试
	Remark *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// SUP_XXX
	SupplierCode *string `json:"supplierCode,omitempty" xml:"supplierCode,omitempty"`
	// example:
	//
	// 收款单
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
}

func (s CreateReceiptRequestReceipts) String() string {
	return tea.Prettify(s)
}

func (s CreateReceiptRequestReceipts) GoString() string {
	return s.String()
}

func (s *CreateReceiptRequestReceipts) SetAmount(v string) *CreateReceiptRequestReceipts {
	s.Amount = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetCategoryCode(v string) *CreateReceiptRequestReceipts {
	s.CategoryCode = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetCode(v string) *CreateReceiptRequestReceipts {
	s.Code = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetCreateTime(v int64) *CreateReceiptRequestReceipts {
	s.CreateTime = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetCreateUserId(v string) *CreateReceiptRequestReceipts {
	s.CreateUserId = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetCustomerCode(v string) *CreateReceiptRequestReceipts {
	s.CustomerCode = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetEnterpriseAcountCode(v string) *CreateReceiptRequestReceipts {
	s.EnterpriseAcountCode = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetOccurDate(v int64) *CreateReceiptRequestReceipts {
	s.OccurDate = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetPrincipalId(v string) *CreateReceiptRequestReceipts {
	s.PrincipalId = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetProjectCode(v string) *CreateReceiptRequestReceipts {
	s.ProjectCode = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetReceiptType(v int64) *CreateReceiptRequestReceipts {
	s.ReceiptType = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetRemark(v string) *CreateReceiptRequestReceipts {
	s.Remark = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetSupplierCode(v string) *CreateReceiptRequestReceipts {
	s.SupplierCode = &v
	return s
}

func (s *CreateReceiptRequestReceipts) SetTitle(v string) *CreateReceiptRequestReceipts {
	s.Title = &v
	return s
}

type CreateReceiptResponseBody struct {
	// This parameter is required.
	Results []*CreateReceiptResponseBodyResults `json:"results,omitempty" xml:"results,omitempty" type:"Repeated"`
}

func (s CreateReceiptResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateReceiptResponseBody) GoString() string {
	return s.String()
}

func (s *CreateReceiptResponseBody) SetResults(v []*CreateReceiptResponseBodyResults) *CreateReceiptResponseBody {
	s.Results = v
	return s
}

type CreateReceiptResponseBodyResults struct {
	// This parameter is required.
	//
	// example:
	//
	// abcef-efgh-123
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// success
	ErrorCode *string `json:"errorCode,omitempty" xml:"errorCode,omitempty"`
	// example:
	//
	// 成功
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s CreateReceiptResponseBodyResults) String() string {
	return tea.Prettify(s)
}

func (s CreateReceiptResponseBodyResults) GoString() string {
	return s.String()
}

func (s *CreateReceiptResponseBodyResults) SetCode(v string) *CreateReceiptResponseBodyResults {
	s.Code = &v
	return s
}

func (s *CreateReceiptResponseBodyResults) SetErrorCode(v string) *CreateReceiptResponseBodyResults {
	s.ErrorCode = &v
	return s
}

func (s *CreateReceiptResponseBodyResults) SetErrorMsg(v string) *CreateReceiptResponseBodyResults {
	s.ErrorMsg = &v
	return s
}

func (s *CreateReceiptResponseBodyResults) SetSuccess(v bool) *CreateReceiptResponseBodyResults {
	s.Success = &v
	return s
}

type CreateReceiptResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CreateReceiptResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CreateReceiptResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateReceiptResponse) GoString() string {
	return s.String()
}

func (s *CreateReceiptResponse) SetHeaders(v map[string]*string) *CreateReceiptResponse {
	s.Headers = v
	return s
}

func (s *CreateReceiptResponse) SetStatusCode(v int32) *CreateReceiptResponse {
	s.StatusCode = &v
	return s
}

func (s *CreateReceiptResponse) SetBody(v *CreateReceiptResponseBody) *CreateReceiptResponse {
	s.Body = v
	return s
}

type DeleteReceiptHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DeleteReceiptHeaders) String() string {
	return tea.Prettify(s)
}

func (s DeleteReceiptHeaders) GoString() string {
	return s.String()
}

func (s *DeleteReceiptHeaders) SetCommonHeaders(v map[string]*string) *DeleteReceiptHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DeleteReceiptHeaders) SetXAcsDingtalkAccessToken(v string) *DeleteReceiptHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DeleteReceiptRequest struct {
	// This parameter is required.
	Receipts []*DeleteReceiptRequestReceipts `json:"receipts,omitempty" xml:"receipts,omitempty" type:"Repeated"`
}

func (s DeleteReceiptRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteReceiptRequest) GoString() string {
	return s.String()
}

func (s *DeleteReceiptRequest) SetReceipts(v []*DeleteReceiptRequestReceipts) *DeleteReceiptRequest {
	s.Receipts = v
	return s
}

type DeleteReceiptRequestReceipts struct {
	// This parameter is required.
	//
	// example:
	//
	// abcd_efgh
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// emp_xxx
	DeleteUserId *string `json:"deleteUserId,omitempty" xml:"deleteUserId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1
	ReceiptType *int64 `json:"receiptType,omitempty" xml:"receiptType,omitempty"`
}

func (s DeleteReceiptRequestReceipts) String() string {
	return tea.Prettify(s)
}

func (s DeleteReceiptRequestReceipts) GoString() string {
	return s.String()
}

func (s *DeleteReceiptRequestReceipts) SetCode(v string) *DeleteReceiptRequestReceipts {
	s.Code = &v
	return s
}

func (s *DeleteReceiptRequestReceipts) SetDeleteUserId(v string) *DeleteReceiptRequestReceipts {
	s.DeleteUserId = &v
	return s
}

func (s *DeleteReceiptRequestReceipts) SetReceiptType(v int64) *DeleteReceiptRequestReceipts {
	s.ReceiptType = &v
	return s
}

type DeleteReceiptResponseBody struct {
	// This parameter is required.
	Results []*DeleteReceiptResponseBodyResults `json:"results,omitempty" xml:"results,omitempty" type:"Repeated"`
}

func (s DeleteReceiptResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteReceiptResponseBody) GoString() string {
	return s.String()
}

func (s *DeleteReceiptResponseBody) SetResults(v []*DeleteReceiptResponseBodyResults) *DeleteReceiptResponseBody {
	s.Results = v
	return s
}

type DeleteReceiptResponseBodyResults struct {
	// This parameter is required.
	//
	// example:
	//
	// abcd_efgh
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// success
	ErrorCode *string `json:"errorCode,omitempty" xml:"errorCode,omitempty"`
	// example:
	//
	// 成功
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s DeleteReceiptResponseBodyResults) String() string {
	return tea.Prettify(s)
}

func (s DeleteReceiptResponseBodyResults) GoString() string {
	return s.String()
}

func (s *DeleteReceiptResponseBodyResults) SetCode(v string) *DeleteReceiptResponseBodyResults {
	s.Code = &v
	return s
}

func (s *DeleteReceiptResponseBodyResults) SetErrorCode(v string) *DeleteReceiptResponseBodyResults {
	s.ErrorCode = &v
	return s
}

func (s *DeleteReceiptResponseBodyResults) SetErrorMsg(v string) *DeleteReceiptResponseBodyResults {
	s.ErrorMsg = &v
	return s
}

func (s *DeleteReceiptResponseBodyResults) SetSuccess(v bool) *DeleteReceiptResponseBodyResults {
	s.Success = &v
	return s
}

type DeleteReceiptResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *DeleteReceiptResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s DeleteReceiptResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteReceiptResponse) GoString() string {
	return s.String()
}

func (s *DeleteReceiptResponse) SetHeaders(v map[string]*string) *DeleteReceiptResponse {
	s.Headers = v
	return s
}

func (s *DeleteReceiptResponse) SetStatusCode(v int32) *DeleteReceiptResponse {
	s.StatusCode = &v
	return s
}

func (s *DeleteReceiptResponse) SetBody(v *DeleteReceiptResponseBody) *DeleteReceiptResponse {
	s.Body = v
	return s
}

type GetBookkeepingUserListHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetBookkeepingUserListHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetBookkeepingUserListHeaders) GoString() string {
	return s.String()
}

func (s *GetBookkeepingUserListHeaders) SetCommonHeaders(v map[string]*string) *GetBookkeepingUserListHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetBookkeepingUserListHeaders) SetXAcsDingtalkAccessToken(v string) *GetBookkeepingUserListHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetBookkeepingUserListResponseBody struct {
	// This parameter is required.
	Result []*string `json:"result,omitempty" xml:"result,omitempty" type:"Repeated"`
}

func (s GetBookkeepingUserListResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetBookkeepingUserListResponseBody) GoString() string {
	return s.String()
}

func (s *GetBookkeepingUserListResponseBody) SetResult(v []*string) *GetBookkeepingUserListResponseBody {
	s.Result = v
	return s
}

type GetBookkeepingUserListResponse struct {
	Headers    map[string]*string                  `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                              `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetBookkeepingUserListResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetBookkeepingUserListResponse) String() string {
	return tea.Prettify(s)
}

func (s GetBookkeepingUserListResponse) GoString() string {
	return s.String()
}

func (s *GetBookkeepingUserListResponse) SetHeaders(v map[string]*string) *GetBookkeepingUserListResponse {
	s.Headers = v
	return s
}

func (s *GetBookkeepingUserListResponse) SetStatusCode(v int32) *GetBookkeepingUserListResponse {
	s.StatusCode = &v
	return s
}

func (s *GetBookkeepingUserListResponse) SetBody(v *GetBookkeepingUserListResponseBody) *GetBookkeepingUserListResponse {
	s.Body = v
	return s
}

type GetCategoryHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetCategoryHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetCategoryHeaders) GoString() string {
	return s.String()
}

func (s *GetCategoryHeaders) SetCommonHeaders(v map[string]*string) *GetCategoryHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetCategoryHeaders) SetXAcsDingtalkAccessToken(v string) *GetCategoryHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetCategoryRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// INCOME_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s GetCategoryRequest) String() string {
	return tea.Prettify(s)
}

func (s GetCategoryRequest) GoString() string {
	return s.String()
}

func (s *GetCategoryRequest) SetCode(v string) *GetCategoryRequest {
	s.Code = &v
	return s
}

type GetCategoryResponseBody struct {
	AccountantBookIdList []*string `json:"accountantBookIdList,omitempty" xml:"accountantBookIdList,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// INCOME_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// false
	IsDir *bool `json:"isDir,omitempty" xml:"isDir,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 汽车
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// DIR_XXX
	ParentCode *string `json:"parentCode,omitempty" xml:"parentCode,omitempty"`
	Remark     *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// income
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
}

func (s GetCategoryResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetCategoryResponseBody) GoString() string {
	return s.String()
}

func (s *GetCategoryResponseBody) SetAccountantBookIdList(v []*string) *GetCategoryResponseBody {
	s.AccountantBookIdList = v
	return s
}

func (s *GetCategoryResponseBody) SetCode(v string) *GetCategoryResponseBody {
	s.Code = &v
	return s
}

func (s *GetCategoryResponseBody) SetIsDir(v bool) *GetCategoryResponseBody {
	s.IsDir = &v
	return s
}

func (s *GetCategoryResponseBody) SetName(v string) *GetCategoryResponseBody {
	s.Name = &v
	return s
}

func (s *GetCategoryResponseBody) SetParentCode(v string) *GetCategoryResponseBody {
	s.ParentCode = &v
	return s
}

func (s *GetCategoryResponseBody) SetRemark(v string) *GetCategoryResponseBody {
	s.Remark = &v
	return s
}

func (s *GetCategoryResponseBody) SetStatus(v string) *GetCategoryResponseBody {
	s.Status = &v
	return s
}

func (s *GetCategoryResponseBody) SetType(v string) *GetCategoryResponseBody {
	s.Type = &v
	return s
}

type GetCategoryResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetCategoryResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetCategoryResponse) String() string {
	return tea.Prettify(s)
}

func (s GetCategoryResponse) GoString() string {
	return s.String()
}

func (s *GetCategoryResponse) SetHeaders(v map[string]*string) *GetCategoryResponse {
	s.Headers = v
	return s
}

func (s *GetCategoryResponse) SetStatusCode(v int32) *GetCategoryResponse {
	s.StatusCode = &v
	return s
}

func (s *GetCategoryResponse) SetBody(v *GetCategoryResponseBody) *GetCategoryResponse {
	s.Body = v
	return s
}

type GetCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetCustomerHeaders) GoString() string {
	return s.String()
}

func (s *GetCustomerHeaders) SetCommonHeaders(v map[string]*string) *GetCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *GetCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetCustomerRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// CUS_XXXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s GetCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s GetCustomerRequest) GoString() string {
	return s.String()
}

func (s *GetCustomerRequest) SetCode(v string) *GetCustomerRequest {
	s.Code = &v
	return s
}

type GetCustomerResponseBody struct {
	AccountantBookIdList []*string `json:"accountantBookIdList,omitempty" xml:"accountantBookIdList,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// CUS_XXXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1634786828686
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 重要客户
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// XX有限公司
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s GetCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *GetCustomerResponseBody) SetAccountantBookIdList(v []*string) *GetCustomerResponseBody {
	s.AccountantBookIdList = v
	return s
}

func (s *GetCustomerResponseBody) SetCode(v string) *GetCustomerResponseBody {
	s.Code = &v
	return s
}

func (s *GetCustomerResponseBody) SetCreateTime(v int64) *GetCustomerResponseBody {
	s.CreateTime = &v
	return s
}

func (s *GetCustomerResponseBody) SetDescription(v string) *GetCustomerResponseBody {
	s.Description = &v
	return s
}

func (s *GetCustomerResponseBody) SetName(v string) *GetCustomerResponseBody {
	s.Name = &v
	return s
}

func (s *GetCustomerResponseBody) SetStatus(v string) *GetCustomerResponseBody {
	s.Status = &v
	return s
}

func (s *GetCustomerResponseBody) SetUserDefineCode(v string) *GetCustomerResponseBody {
	s.UserDefineCode = &v
	return s
}

type GetCustomerResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s GetCustomerResponse) GoString() string {
	return s.String()
}

func (s *GetCustomerResponse) SetHeaders(v map[string]*string) *GetCustomerResponse {
	s.Headers = v
	return s
}

func (s *GetCustomerResponse) SetStatusCode(v int32) *GetCustomerResponse {
	s.StatusCode = &v
	return s
}

func (s *GetCustomerResponse) SetBody(v *GetCustomerResponseBody) *GetCustomerResponse {
	s.Body = v
	return s
}

type GetFinanceAccountHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetFinanceAccountHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetFinanceAccountHeaders) GoString() string {
	return s.String()
}

func (s *GetFinanceAccountHeaders) SetCommonHeaders(v map[string]*string) *GetFinanceAccountHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetFinanceAccountHeaders) SetXAcsDingtalkAccessToken(v string) *GetFinanceAccountHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetFinanceAccountRequest struct {
	// This parameter is required.
	AccountCode *string `json:"accountCode,omitempty" xml:"accountCode,omitempty"`
}

func (s GetFinanceAccountRequest) String() string {
	return tea.Prettify(s)
}

func (s GetFinanceAccountRequest) GoString() string {
	return s.String()
}

func (s *GetFinanceAccountRequest) SetAccountCode(v string) *GetFinanceAccountRequest {
	s.AccountCode = &v
	return s
}

type GetFinanceAccountResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// 12345
	AccountCode *string `json:"accountCode,omitempty" xml:"accountCode,omitempty"`
	// example:
	//
	// test@alipay.com
	AccountId *string `json:"accountId,omitempty" xml:"accountId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 测试
	AccountName   *string `json:"accountName,omitempty" xml:"accountName,omitempty"`
	AccountRemark *string `json:"accountRemark,omitempty" xml:"accountRemark,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// ALIPAY
	AccountType          *string   `json:"accountType,omitempty" xml:"accountType,omitempty"`
	AccountantBookIdList []*string `json:"accountantBookIdList,omitempty" xml:"accountantBookIdList,omitempty" type:"Repeated"`
	// example:
	//
	// 50000.55
	Amount   *string `json:"amount,omitempty" xml:"amount,omitempty"`
	BankCode *string `json:"bankCode,omitempty" xml:"bankCode,omitempty"`
	BankName *string `json:"bankName,omitempty" xml:"bankName,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1631526550994
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// abcdef
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
}

func (s GetFinanceAccountResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetFinanceAccountResponseBody) GoString() string {
	return s.String()
}

func (s *GetFinanceAccountResponseBody) SetAccountCode(v string) *GetFinanceAccountResponseBody {
	s.AccountCode = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetAccountId(v string) *GetFinanceAccountResponseBody {
	s.AccountId = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetAccountName(v string) *GetFinanceAccountResponseBody {
	s.AccountName = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetAccountRemark(v string) *GetFinanceAccountResponseBody {
	s.AccountRemark = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetAccountType(v string) *GetFinanceAccountResponseBody {
	s.AccountType = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetAccountantBookIdList(v []*string) *GetFinanceAccountResponseBody {
	s.AccountantBookIdList = v
	return s
}

func (s *GetFinanceAccountResponseBody) SetAmount(v string) *GetFinanceAccountResponseBody {
	s.Amount = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetBankCode(v string) *GetFinanceAccountResponseBody {
	s.BankCode = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetBankName(v string) *GetFinanceAccountResponseBody {
	s.BankName = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetCreateTime(v int64) *GetFinanceAccountResponseBody {
	s.CreateTime = &v
	return s
}

func (s *GetFinanceAccountResponseBody) SetCreator(v string) *GetFinanceAccountResponseBody {
	s.Creator = &v
	return s
}

type GetFinanceAccountResponse struct {
	Headers    map[string]*string             `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                         `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetFinanceAccountResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetFinanceAccountResponse) String() string {
	return tea.Prettify(s)
}

func (s GetFinanceAccountResponse) GoString() string {
	return s.String()
}

func (s *GetFinanceAccountResponse) SetHeaders(v map[string]*string) *GetFinanceAccountResponse {
	s.Headers = v
	return s
}

func (s *GetFinanceAccountResponse) SetStatusCode(v int32) *GetFinanceAccountResponse {
	s.StatusCode = &v
	return s
}

func (s *GetFinanceAccountResponse) SetBody(v *GetFinanceAccountResponseBody) *GetFinanceAccountResponse {
	s.Body = v
	return s
}

type GetFormTemplateInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetFormTemplateInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetFormTemplateInfoHeaders) GoString() string {
	return s.String()
}

func (s *GetFormTemplateInfoHeaders) SetCommonHeaders(v map[string]*string) *GetFormTemplateInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetFormTemplateInfoHeaders) SetXAcsDingtalkAccessToken(v string) *GetFormTemplateInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetFormTemplateInfoResponseBody struct {
	// This parameter is required.
	ReceiptFormTemplateInfoList []*GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList `json:"receiptFormTemplateInfoList,omitempty" xml:"receiptFormTemplateInfoList,omitempty" type:"Repeated"`
}

func (s GetFormTemplateInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetFormTemplateInfoResponseBody) GoString() string {
	return s.String()
}

func (s *GetFormTemplateInfoResponseBody) SetReceiptFormTemplateInfoList(v []*GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) *GetFormTemplateInfoResponseBody {
	s.ReceiptFormTemplateInfoList = v
	return s
}

type GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList struct {
	ComponentList []*GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList `json:"componentList,omitempty" xml:"componentList,omitempty" type:"Repeated"`
	// example:
	//
	// "报销套件"
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// "PROC-EB81447A-B0E3-4A2F-A719-0A85EFD09184"
	ProcessCode *string `json:"processCode,omitempty" xml:"processCode,omitempty"`
	// example:
	//
	// "invalid"
	Status  *string `json:"status,omitempty" xml:"status,omitempty"`
	SuiteId *string `json:"suiteId,omitempty" xml:"suiteId,omitempty"`
}

func (s GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) String() string {
	return tea.Prettify(s)
}

func (s GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) GoString() string {
	return s.String()
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) SetComponentList(v []*GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList {
	s.ComponentList = v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) SetName(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList {
	s.Name = &v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) SetProcessCode(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList {
	s.ProcessCode = &v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) SetStatus(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList {
	s.Status = &v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList) SetSuiteId(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList {
	s.SuiteId = &v
	return s
}

type GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList struct {
	// example:
	//
	// \"100\"
	BindingVal *string `json:"bindingVal,omitempty" xml:"bindingVal,omitempty"`
	// example:
	//
	// \"xxx\"
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// "报销金额"
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// \"amount\"
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
}

func (s GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) String() string {
	return tea.Prettify(s)
}

func (s GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) GoString() string {
	return s.String()
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) SetBindingVal(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList {
	s.BindingVal = &v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) SetCode(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList {
	s.Code = &v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) SetName(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList {
	s.Name = &v
	return s
}

func (s *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList) SetType(v string) *GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList {
	s.Type = &v
	return s
}

type GetFormTemplateInfoResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetFormTemplateInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetFormTemplateInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s GetFormTemplateInfoResponse) GoString() string {
	return s.String()
}

func (s *GetFormTemplateInfoResponse) SetHeaders(v map[string]*string) *GetFormTemplateInfoResponse {
	s.Headers = v
	return s
}

func (s *GetFormTemplateInfoResponse) SetStatusCode(v int32) *GetFormTemplateInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *GetFormTemplateInfoResponse) SetBody(v *GetFormTemplateInfoResponseBody) *GetFormTemplateInfoResponse {
	s.Body = v
	return s
}

type GetInvoiceByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetInvoiceByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageHeaders) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageHeaders) SetCommonHeaders(v map[string]*string) *GetInvoiceByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetInvoiceByPageHeaders) SetXAcsDingtalkAccessToken(v string) *GetInvoiceByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetInvoiceByPageRequest struct {
	Request *GetInvoiceByPageRequestRequest `json:"request,omitempty" xml:"request,omitempty" type:"Struct"`
}

func (s GetInvoiceByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageRequest) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageRequest) SetRequest(v *GetInvoiceByPageRequestRequest) *GetInvoiceByPageRequest {
	s.Request = v
	return s
}

type GetInvoiceByPageRequestRequest struct {
	// example:
	//
	// abc
	AccountantBookId *string `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// abc
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// example:
	//
	// abc
	FinanceType *string `json:"financeType,omitempty" xml:"financeType,omitempty"`
	// example:
	//
	// 2
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// example:
	//
	// 1
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
	// example:
	//
	// 2022-07-11
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
	// example:
	//
	// 1111111111
	TaxNo *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
	// example:
	//
	// ABC
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
}

func (s GetInvoiceByPageRequestRequest) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageRequestRequest) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageRequestRequest) SetAccountantBookId(v string) *GetInvoiceByPageRequestRequest {
	s.AccountantBookId = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetCompanyCode(v string) *GetInvoiceByPageRequestRequest {
	s.CompanyCode = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetEndTime(v int64) *GetInvoiceByPageRequestRequest {
	s.EndTime = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetFinanceType(v string) *GetInvoiceByPageRequestRequest {
	s.FinanceType = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetPageNumber(v int64) *GetInvoiceByPageRequestRequest {
	s.PageNumber = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetPageSize(v int64) *GetInvoiceByPageRequestRequest {
	s.PageSize = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetStartTime(v int64) *GetInvoiceByPageRequestRequest {
	s.StartTime = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetTaxNo(v string) *GetInvoiceByPageRequestRequest {
	s.TaxNo = &v
	return s
}

func (s *GetInvoiceByPageRequestRequest) SetVerifyStatus(v string) *GetInvoiceByPageRequestRequest {
	s.VerifyStatus = &v
	return s
}

type GetInvoiceByPageShrinkRequest struct {
	RequestShrink *string `json:"request,omitempty" xml:"request,omitempty"`
}

func (s GetInvoiceByPageShrinkRequest) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageShrinkRequest) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageShrinkRequest) SetRequestShrink(v string) *GetInvoiceByPageShrinkRequest {
	s.RequestShrink = &v
	return s
}

type GetInvoiceByPageResponseBody struct {
	ErrorCode *string                             `json:"errorCode,omitempty" xml:"errorCode,omitempty"`
	ErrorMsg  *string                             `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
	Result    *GetInvoiceByPageResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
	Success   *bool                               `json:"success,omitempty" xml:"success,omitempty"`
}

func (s GetInvoiceByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBody) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBody) SetErrorCode(v string) *GetInvoiceByPageResponseBody {
	s.ErrorCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBody) SetErrorMsg(v string) *GetInvoiceByPageResponseBody {
	s.ErrorMsg = &v
	return s
}

func (s *GetInvoiceByPageResponseBody) SetResult(v *GetInvoiceByPageResponseBodyResult) *GetInvoiceByPageResponseBody {
	s.Result = v
	return s
}

func (s *GetInvoiceByPageResponseBody) SetSuccess(v bool) *GetInvoiceByPageResponseBody {
	s.Success = &v
	return s
}

type GetInvoiceByPageResponseBodyResult struct {
	HasMore    *string                                   `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	List       []*GetInvoiceByPageResponseBodyResultList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
	NextCursor *int64                                    `json:"nextCursor,omitempty" xml:"nextCursor,omitempty"`
	TotalCount *int64                                    `json:"totalCount,omitempty" xml:"totalCount,omitempty"`
}

func (s GetInvoiceByPageResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBodyResult) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBodyResult) SetHasMore(v string) *GetInvoiceByPageResponseBodyResult {
	s.HasMore = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResult) SetList(v []*GetInvoiceByPageResponseBodyResultList) *GetInvoiceByPageResponseBodyResult {
	s.List = v
	return s
}

func (s *GetInvoiceByPageResponseBodyResult) SetNextCursor(v int64) *GetInvoiceByPageResponseBodyResult {
	s.NextCursor = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResult) SetTotalCount(v int64) *GetInvoiceByPageResponseBodyResult {
	s.TotalCount = &v
	return s
}

type GetInvoiceByPageResponseBodyResultList struct {
	AccountPeriod              *string                                                             `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	Amount                     *string                                                             `json:"amount,omitempty" xml:"amount,omitempty"`
	AmountWithTax              *string                                                             `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	CheckCode                  *string                                                             `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	CheckTime                  *string                                                             `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	DrewDate                   *string                                                             `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	ElectronicUrl              *string                                                             `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	FinanceType                *string                                                             `json:"financeType,omitempty" xml:"financeType,omitempty"`
	FundType                   *string                                                             `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	ImageUrl                   *string                                                             `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	InvoiceCode                *string                                                             `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo                  *string                                                             `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// abc
	InvoiceStatus               *string                                                              `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	InvoiceType                 *string                                                              `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	MachineCode                 *string                                                              `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	OilFlag                     *string                                                              `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	Payee                       *string                                                              `json:"payee,omitempty" xml:"payee,omitempty"`
	ProcessInstCode             *string                                                              `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	ProcessInstType             *string                                                              `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	PurchaserAddress            *string                                                              `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	PurchaserBankNameAccount    *string                                                              `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	PurchaserName               *string                                                              `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	PurchaserTaxNo              *string                                                              `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	PurchaserTel                *string                                                              `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	Remark                      *string                                                              `json:"remark,omitempty" xml:"remark,omitempty"`
	SellerAddress               *string                                                              `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	SellerBankNameAccount       *string                                                              `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	SellerName                  *string                                                              `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	SellerTaxNo                 *string                                                              `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	SellerTel                   *string                                                              `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	Status                      *string                                                              `json:"status,omitempty" xml:"status,omitempty"`
	SupplySign                  *string                                                              `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	TaxAmount                   *string                                                              `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TransportFeeDetailVOList    []*GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList    `json:"transportFeeDetailVOList,omitempty" xml:"transportFeeDetailVOList,omitempty" type:"Repeated"`
	UsedVehicleSaleDetailVOList []*GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VerifyStatus                *string                                                              `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	VoucherCode                 *string                                                              `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	VoucherStatus               *string                                                              `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s GetInvoiceByPageResponseBodyResultList) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBodyResultList) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBodyResultList) SetAccountPeriod(v string) *GetInvoiceByPageResponseBodyResultList {
	s.AccountPeriod = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetAmount(v string) *GetInvoiceByPageResponseBodyResultList {
	s.Amount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetAmountWithTax(v string) *GetInvoiceByPageResponseBodyResultList {
	s.AmountWithTax = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetCheckCode(v string) *GetInvoiceByPageResponseBodyResultList {
	s.CheckCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetCheckTime(v string) *GetInvoiceByPageResponseBodyResultList {
	s.CheckTime = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetDrewDate(v string) *GetInvoiceByPageResponseBodyResultList {
	s.DrewDate = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetElectronicUrl(v string) *GetInvoiceByPageResponseBodyResultList {
	s.ElectronicUrl = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetFinanceType(v string) *GetInvoiceByPageResponseBodyResultList {
	s.FinanceType = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetFundType(v string) *GetInvoiceByPageResponseBodyResultList {
	s.FundType = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetGeneralInvoiceDetailVOList(v []*GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) *GetInvoiceByPageResponseBodyResultList {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetImageUrl(v string) *GetInvoiceByPageResponseBodyResultList {
	s.ImageUrl = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetInvoiceCode(v string) *GetInvoiceByPageResponseBodyResultList {
	s.InvoiceCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetInvoiceNo(v string) *GetInvoiceByPageResponseBodyResultList {
	s.InvoiceNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetInvoiceStatus(v string) *GetInvoiceByPageResponseBodyResultList {
	s.InvoiceStatus = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetInvoiceType(v string) *GetInvoiceByPageResponseBodyResultList {
	s.InvoiceType = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetMachineCode(v string) *GetInvoiceByPageResponseBodyResultList {
	s.MachineCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetOilFlag(v string) *GetInvoiceByPageResponseBodyResultList {
	s.OilFlag = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetPayee(v string) *GetInvoiceByPageResponseBodyResultList {
	s.Payee = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetProcessInstCode(v string) *GetInvoiceByPageResponseBodyResultList {
	s.ProcessInstCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetProcessInstType(v string) *GetInvoiceByPageResponseBodyResultList {
	s.ProcessInstType = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetPurchaserAddress(v string) *GetInvoiceByPageResponseBodyResultList {
	s.PurchaserAddress = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetPurchaserBankNameAccount(v string) *GetInvoiceByPageResponseBodyResultList {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetPurchaserName(v string) *GetInvoiceByPageResponseBodyResultList {
	s.PurchaserName = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetPurchaserTaxNo(v string) *GetInvoiceByPageResponseBodyResultList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetPurchaserTel(v string) *GetInvoiceByPageResponseBodyResultList {
	s.PurchaserTel = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetRemark(v string) *GetInvoiceByPageResponseBodyResultList {
	s.Remark = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetSellerAddress(v string) *GetInvoiceByPageResponseBodyResultList {
	s.SellerAddress = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetSellerBankNameAccount(v string) *GetInvoiceByPageResponseBodyResultList {
	s.SellerBankNameAccount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetSellerName(v string) *GetInvoiceByPageResponseBodyResultList {
	s.SellerName = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetSellerTaxNo(v string) *GetInvoiceByPageResponseBodyResultList {
	s.SellerTaxNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetSellerTel(v string) *GetInvoiceByPageResponseBodyResultList {
	s.SellerTel = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetStatus(v string) *GetInvoiceByPageResponseBodyResultList {
	s.Status = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetSupplySign(v string) *GetInvoiceByPageResponseBodyResultList {
	s.SupplySign = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetTaxAmount(v string) *GetInvoiceByPageResponseBodyResultList {
	s.TaxAmount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetTransportFeeDetailVOList(v []*GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) *GetInvoiceByPageResponseBodyResultList {
	s.TransportFeeDetailVOList = v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetUsedVehicleSaleDetailVOList(v []*GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) *GetInvoiceByPageResponseBodyResultList {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetVehicleSaleDetailVOList(v []*GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) *GetInvoiceByPageResponseBodyResultList {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetVerifyStatus(v string) *GetInvoiceByPageResponseBodyResultList {
	s.VerifyStatus = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetVoucherCode(v string) *GetInvoiceByPageResponseBodyResultList {
	s.VoucherCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultList) SetVoucherStatus(v string) *GetInvoiceByPageResponseBodyResultList {
	s.VoucherStatus = &v
	return s
}

type GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	TaxRate       *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit          *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice     *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetAmount(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetGoodsName(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetQuantity(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetRevenueCode(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetRowNo(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetSpecification(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetTaxAmount(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetTaxPre(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetTaxRate(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetUnit(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList) SetUnitPrice(v string) *GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetAmount(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.Amount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetCardNo(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.CardNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetEndDate(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.EndDate = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetGoodsName(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetRevenueCode(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetRowNo(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.RowNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetStartDate(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.StartDate = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetTaxAmount(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetTaxRate(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList) SetVehicleType(v string) *GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList {
	s.VehicleType = &v
	return s
}

type GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetCarModel(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetCardNo(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetRegistration(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList) SetVehicleType(v string) *GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	MaxPassengers       *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace         *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo    *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName    *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo      *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate             *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage             *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo           *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType         *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetBrand(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetCertificateNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetEngineNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetIdCardNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetImportCertificateNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetMaxPassengers(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetOriginPlace(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetTaxRate(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetTonnage(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetVehicleNo(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList) SetVehicleType(v string) *GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type GetInvoiceByPageResponse struct {
	Headers    map[string]*string            `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                        `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetInvoiceByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetInvoiceByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s GetInvoiceByPageResponse) GoString() string {
	return s.String()
}

func (s *GetInvoiceByPageResponse) SetHeaders(v map[string]*string) *GetInvoiceByPageResponse {
	s.Headers = v
	return s
}

func (s *GetInvoiceByPageResponse) SetStatusCode(v int32) *GetInvoiceByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *GetInvoiceByPageResponse) SetBody(v *GetInvoiceByPageResponseBody) *GetInvoiceByPageResponse {
	s.Body = v
	return s
}

type GetIsNewVersionHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetIsNewVersionHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetIsNewVersionHeaders) GoString() string {
	return s.String()
}

func (s *GetIsNewVersionHeaders) SetCommonHeaders(v map[string]*string) *GetIsNewVersionHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetIsNewVersionHeaders) SetXAcsDingtalkAccessToken(v string) *GetIsNewVersionHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetIsNewVersionResponseBody struct {
	Result  *bool `json:"result,omitempty" xml:"result,omitempty"`
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s GetIsNewVersionResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetIsNewVersionResponseBody) GoString() string {
	return s.String()
}

func (s *GetIsNewVersionResponseBody) SetResult(v bool) *GetIsNewVersionResponseBody {
	s.Result = &v
	return s
}

func (s *GetIsNewVersionResponseBody) SetSuccess(v bool) *GetIsNewVersionResponseBody {
	s.Success = &v
	return s
}

type GetIsNewVersionResponse struct {
	Headers    map[string]*string           `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                       `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetIsNewVersionResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetIsNewVersionResponse) String() string {
	return tea.Prettify(s)
}

func (s GetIsNewVersionResponse) GoString() string {
	return s.String()
}

func (s *GetIsNewVersionResponse) SetHeaders(v map[string]*string) *GetIsNewVersionResponse {
	s.Headers = v
	return s
}

func (s *GetIsNewVersionResponse) SetStatusCode(v int32) *GetIsNewVersionResponse {
	s.StatusCode = &v
	return s
}

func (s *GetIsNewVersionResponse) SetBody(v *GetIsNewVersionResponseBody) *GetIsNewVersionResponse {
	s.Body = v
	return s
}

type GetMultiCompanyInfoByCodeHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetMultiCompanyInfoByCodeHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetMultiCompanyInfoByCodeHeaders) GoString() string {
	return s.String()
}

func (s *GetMultiCompanyInfoByCodeHeaders) SetCommonHeaders(v map[string]*string) *GetMultiCompanyInfoByCodeHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetMultiCompanyInfoByCodeHeaders) SetXAcsDingtalkAccessToken(v string) *GetMultiCompanyInfoByCodeHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetMultiCompanyInfoByCodeResponseBody struct {
	AdvancedSettingList []*GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList `json:"advancedSettingList,omitempty" xml:"advancedSettingList,omitempty" type:"Repeated"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 钉钉
	CompanyName *string `json:"companyName,omitempty" xml:"companyName,omitempty"`
	// example:
	//
	// 备注
	Remark *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// valid
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// example:
	//
	// generalTaxpayer
	TaxNature *string `json:"taxNature,omitempty" xml:"taxNature,omitempty"`
	// example:
	//
	// 123456789012345
	TaxNo *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
}

func (s GetMultiCompanyInfoByCodeResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetMultiCompanyInfoByCodeResponseBody) GoString() string {
	return s.String()
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetAdvancedSettingList(v []*GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) *GetMultiCompanyInfoByCodeResponseBody {
	s.AdvancedSettingList = v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetCompanyCode(v string) *GetMultiCompanyInfoByCodeResponseBody {
	s.CompanyCode = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetCompanyName(v string) *GetMultiCompanyInfoByCodeResponseBody {
	s.CompanyName = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetRemark(v string) *GetMultiCompanyInfoByCodeResponseBody {
	s.Remark = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetStatus(v string) *GetMultiCompanyInfoByCodeResponseBody {
	s.Status = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetTaxNature(v string) *GetMultiCompanyInfoByCodeResponseBody {
	s.TaxNature = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBody) SetTaxNo(v string) *GetMultiCompanyInfoByCodeResponseBody {
	s.TaxNo = &v
	return s
}

type GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList struct {
	// example:
	//
	// relateedInvoice
	AdvancedSettingKey *string `json:"advancedSettingKey,omitempty" xml:"advancedSettingKey,omitempty"`
	// example:
	//
	// 关联发票
	AdvancedSettingName *string `json:"advancedSettingName,omitempty" xml:"advancedSettingName,omitempty"`
	// example:
	//
	// 123456789
	EndDate *int64 `json:"endDate,omitempty" xml:"endDate,omitempty"`
	Value   *bool  `json:"value,omitempty" xml:"value,omitempty"`
}

func (s GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) String() string {
	return tea.Prettify(s)
}

func (s GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) GoString() string {
	return s.String()
}

func (s *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) SetAdvancedSettingKey(v string) *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList {
	s.AdvancedSettingKey = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) SetAdvancedSettingName(v string) *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList {
	s.AdvancedSettingName = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) SetEndDate(v int64) *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList {
	s.EndDate = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList) SetValue(v bool) *GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList {
	s.Value = &v
	return s
}

type GetMultiCompanyInfoByCodeResponse struct {
	Headers    map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetMultiCompanyInfoByCodeResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetMultiCompanyInfoByCodeResponse) String() string {
	return tea.Prettify(s)
}

func (s GetMultiCompanyInfoByCodeResponse) GoString() string {
	return s.String()
}

func (s *GetMultiCompanyInfoByCodeResponse) SetHeaders(v map[string]*string) *GetMultiCompanyInfoByCodeResponse {
	s.Headers = v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponse) SetStatusCode(v int32) *GetMultiCompanyInfoByCodeResponse {
	s.StatusCode = &v
	return s
}

func (s *GetMultiCompanyInfoByCodeResponse) SetBody(v *GetMultiCompanyInfoByCodeResponseBody) *GetMultiCompanyInfoByCodeResponse {
	s.Body = v
	return s
}

type GetProductHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetProductHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetProductHeaders) GoString() string {
	return s.String()
}

func (s *GetProductHeaders) SetCommonHeaders(v map[string]*string) *GetProductHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetProductHeaders) SetXAcsDingtalkAccessToken(v string) *GetProductHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetProductRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// PROD-xxx
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s GetProductRequest) String() string {
	return tea.Prettify(s)
}

func (s GetProductRequest) GoString() string {
	return s.String()
}

func (s *GetProductRequest) SetCode(v string) *GetProductRequest {
	s.Code = &v
	return s
}

type GetProductResponseBody struct {
	AccountantBookIdList []*string `json:"accountantBookIdList,omitempty" xml:"accountantBookIdList,omitempty" type:"Repeated"`
	// example:
	//
	// PROD-xxx
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// 1634786828686
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// example:
	//
	// 和外部合作
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	Information *string `json:"information,omitempty" xml:"information,omitempty"`
	// example:
	//
	// 外包商品
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// 规格型号
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	// example:
	//
	// valid
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// example:
	//
	// 个
	Unit           *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s GetProductResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetProductResponseBody) GoString() string {
	return s.String()
}

func (s *GetProductResponseBody) SetAccountantBookIdList(v []*string) *GetProductResponseBody {
	s.AccountantBookIdList = v
	return s
}

func (s *GetProductResponseBody) SetCode(v string) *GetProductResponseBody {
	s.Code = &v
	return s
}

func (s *GetProductResponseBody) SetCreateTime(v int64) *GetProductResponseBody {
	s.CreateTime = &v
	return s
}

func (s *GetProductResponseBody) SetDescription(v string) *GetProductResponseBody {
	s.Description = &v
	return s
}

func (s *GetProductResponseBody) SetInformation(v string) *GetProductResponseBody {
	s.Information = &v
	return s
}

func (s *GetProductResponseBody) SetName(v string) *GetProductResponseBody {
	s.Name = &v
	return s
}

func (s *GetProductResponseBody) SetSpecification(v string) *GetProductResponseBody {
	s.Specification = &v
	return s
}

func (s *GetProductResponseBody) SetStatus(v string) *GetProductResponseBody {
	s.Status = &v
	return s
}

func (s *GetProductResponseBody) SetUnit(v string) *GetProductResponseBody {
	s.Unit = &v
	return s
}

func (s *GetProductResponseBody) SetUserDefineCode(v string) *GetProductResponseBody {
	s.UserDefineCode = &v
	return s
}

type GetProductResponse struct {
	Headers    map[string]*string      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetProductResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetProductResponse) String() string {
	return tea.Prettify(s)
}

func (s GetProductResponse) GoString() string {
	return s.String()
}

func (s *GetProductResponse) SetHeaders(v map[string]*string) *GetProductResponse {
	s.Headers = v
	return s
}

func (s *GetProductResponse) SetStatusCode(v int32) *GetProductResponse {
	s.StatusCode = &v
	return s
}

func (s *GetProductResponse) SetBody(v *GetProductResponseBody) *GetProductResponse {
	s.Body = v
	return s
}

type GetProjectHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetProjectHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetProjectHeaders) GoString() string {
	return s.String()
}

func (s *GetProjectHeaders) SetCommonHeaders(v map[string]*string) *GetProjectHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetProjectHeaders) SetXAcsDingtalkAccessToken(v string) *GetProjectHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetProjectRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// PROJ-xxx
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s GetProjectRequest) String() string {
	return tea.Prettify(s)
}

func (s GetProjectRequest) GoString() string {
	return s.String()
}

func (s *GetProjectRequest) SetCode(v string) *GetProjectRequest {
	s.Code = &v
	return s
}

type GetProjectResponseBody struct {
	AccountantBookIdList []*string `json:"accountantBookIdList,omitempty" xml:"accountantBookIdList,omitempty" type:"Repeated"`
	Code                 *string   `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1631526550994
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// aaa
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 和外部合作
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	Name        *string `json:"name,omitempty" xml:"name,omitempty"`
	ParentCode  *string `json:"parentCode,omitempty" xml:"parentCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// PROJ-XXX
	ProjectCode *string `json:"projectCode,omitempty" xml:"projectCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 外包项目
	ProjectName *string `json:"projectName,omitempty" xml:"projectName,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s GetProjectResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetProjectResponseBody) GoString() string {
	return s.String()
}

func (s *GetProjectResponseBody) SetAccountantBookIdList(v []*string) *GetProjectResponseBody {
	s.AccountantBookIdList = v
	return s
}

func (s *GetProjectResponseBody) SetCode(v string) *GetProjectResponseBody {
	s.Code = &v
	return s
}

func (s *GetProjectResponseBody) SetCreateTime(v int64) *GetProjectResponseBody {
	s.CreateTime = &v
	return s
}

func (s *GetProjectResponseBody) SetCreator(v string) *GetProjectResponseBody {
	s.Creator = &v
	return s
}

func (s *GetProjectResponseBody) SetDescription(v string) *GetProjectResponseBody {
	s.Description = &v
	return s
}

func (s *GetProjectResponseBody) SetName(v string) *GetProjectResponseBody {
	s.Name = &v
	return s
}

func (s *GetProjectResponseBody) SetParentCode(v string) *GetProjectResponseBody {
	s.ParentCode = &v
	return s
}

func (s *GetProjectResponseBody) SetProjectCode(v string) *GetProjectResponseBody {
	s.ProjectCode = &v
	return s
}

func (s *GetProjectResponseBody) SetProjectName(v string) *GetProjectResponseBody {
	s.ProjectName = &v
	return s
}

func (s *GetProjectResponseBody) SetStatus(v string) *GetProjectResponseBody {
	s.Status = &v
	return s
}

func (s *GetProjectResponseBody) SetUserDefineCode(v string) *GetProjectResponseBody {
	s.UserDefineCode = &v
	return s
}

type GetProjectResponse struct {
	Headers    map[string]*string      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetProjectResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetProjectResponse) String() string {
	return tea.Prettify(s)
}

func (s GetProjectResponse) GoString() string {
	return s.String()
}

func (s *GetProjectResponse) SetHeaders(v map[string]*string) *GetProjectResponse {
	s.Headers = v
	return s
}

func (s *GetProjectResponse) SetStatusCode(v int32) *GetProjectResponse {
	s.StatusCode = &v
	return s
}

func (s *GetProjectResponse) SetBody(v *GetProjectResponseBody) *GetProjectResponse {
	s.Body = v
	return s
}

type GetReceiptHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetReceiptHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetReceiptHeaders) GoString() string {
	return s.String()
}

func (s *GetReceiptHeaders) SetCommonHeaders(v map[string]*string) *GetReceiptHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetReceiptHeaders) SetXAcsDingtalkAccessToken(v string) *GetReceiptHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetReceiptRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 19b98a1c-5a31-4d78-9da7-0e347593820a
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// EM-1017F28E03350B1738B3000X
	ModelId *string `json:"modelId,omitempty" xml:"modelId,omitempty"`
}

func (s GetReceiptRequest) String() string {
	return tea.Prettify(s)
}

func (s GetReceiptRequest) GoString() string {
	return s.String()
}

func (s *GetReceiptRequest) SetCode(v string) *GetReceiptRequest {
	s.Code = &v
	return s
}

func (s *GetReceiptRequest) SetModelId(v string) *GetReceiptRequest {
	s.ModelId = &v
	return s
}

type GetReceiptResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// 1234
	AppId *string `json:"appId,omitempty" xml:"appId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// {"operatorUserId":"015865244722391178","data":{"amount":{"amountStr":"566"},"code":"d0d54815-32c5-4b18-8391-e79713bba95e","payeeAt":1637251200000,"departmentCode":"-1","project":{"projectCode":"PROJ_101761F3FF6B21362ECA000N","projectName":"客户合作项目"},"principalId":"015865244722391178","enterpriseAccount":{},"approvedAt":1637305373000,"title":"地狱猫提交的智能财务-收款","createAt":1637305353000,"paymentAt":1637251200000,"supplier":{},"operateUserId":"015865244722391178","applicantEmployeeId":"015865244722391178","comment":"ffff","category":{"categoryCode":"INC_1016D6CB3C181E28F0120009","categoryName":"销售收入"},"customer":{"customerCode":"CUS_10178592ECEC2133C893000F","customerName":"钉钉"},"status":"agree"}}
	Data *string `json:"data,omitempty" xml:"data,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// EM-1017F28E03350B1738B3000X
	ModelId *string `json:"modelId,omitempty" xml:"modelId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// approval
	Source *string `json:"source,omitempty" xml:"source,omitempty"`
}

func (s GetReceiptResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetReceiptResponseBody) GoString() string {
	return s.String()
}

func (s *GetReceiptResponseBody) SetAppId(v string) *GetReceiptResponseBody {
	s.AppId = &v
	return s
}

func (s *GetReceiptResponseBody) SetData(v string) *GetReceiptResponseBody {
	s.Data = &v
	return s
}

func (s *GetReceiptResponseBody) SetModelId(v string) *GetReceiptResponseBody {
	s.ModelId = &v
	return s
}

func (s *GetReceiptResponseBody) SetSource(v string) *GetReceiptResponseBody {
	s.Source = &v
	return s
}

type GetReceiptResponse struct {
	Headers    map[string]*string      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetReceiptResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetReceiptResponse) String() string {
	return tea.Prettify(s)
}

func (s GetReceiptResponse) GoString() string {
	return s.String()
}

func (s *GetReceiptResponse) SetHeaders(v map[string]*string) *GetReceiptResponse {
	s.Headers = v
	return s
}

func (s *GetReceiptResponse) SetStatusCode(v int32) *GetReceiptResponse {
	s.StatusCode = &v
	return s
}

func (s *GetReceiptResponse) SetBody(v *GetReceiptResponseBody) *GetReceiptResponse {
	s.Body = v
	return s
}

type GetSupplierHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetSupplierHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetSupplierHeaders) GoString() string {
	return s.String()
}

func (s *GetSupplierHeaders) SetCommonHeaders(v map[string]*string) *GetSupplierHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetSupplierHeaders) SetXAcsDingtalkAccessToken(v string) *GetSupplierHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetSupplierRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// SUP_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s GetSupplierRequest) String() string {
	return tea.Prettify(s)
}

func (s GetSupplierRequest) GoString() string {
	return s.String()
}

func (s *GetSupplierRequest) SetCode(v string) *GetSupplierRequest {
	s.Code = &v
	return s
}

type GetSupplierResponseBody struct {
	AccountantBookIdList []*string `json:"accountantBookIdList,omitempty" xml:"accountantBookIdList,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// SUP_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1634786828686
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 原材料供应商
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// XX公司
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s GetSupplierResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetSupplierResponseBody) GoString() string {
	return s.String()
}

func (s *GetSupplierResponseBody) SetAccountantBookIdList(v []*string) *GetSupplierResponseBody {
	s.AccountantBookIdList = v
	return s
}

func (s *GetSupplierResponseBody) SetCode(v string) *GetSupplierResponseBody {
	s.Code = &v
	return s
}

func (s *GetSupplierResponseBody) SetCreateTime(v int64) *GetSupplierResponseBody {
	s.CreateTime = &v
	return s
}

func (s *GetSupplierResponseBody) SetDescription(v string) *GetSupplierResponseBody {
	s.Description = &v
	return s
}

func (s *GetSupplierResponseBody) SetName(v string) *GetSupplierResponseBody {
	s.Name = &v
	return s
}

func (s *GetSupplierResponseBody) SetStatus(v string) *GetSupplierResponseBody {
	s.Status = &v
	return s
}

func (s *GetSupplierResponseBody) SetUserDefineCode(v string) *GetSupplierResponseBody {
	s.UserDefineCode = &v
	return s
}

type GetSupplierResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetSupplierResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetSupplierResponse) String() string {
	return tea.Prettify(s)
}

func (s GetSupplierResponse) GoString() string {
	return s.String()
}

func (s *GetSupplierResponse) SetHeaders(v map[string]*string) *GetSupplierResponse {
	s.Headers = v
	return s
}

func (s *GetSupplierResponse) SetStatusCode(v int32) *GetSupplierResponse {
	s.StatusCode = &v
	return s
}

func (s *GetSupplierResponse) SetBody(v *GetSupplierResponseBody) *GetSupplierResponse {
	s.Body = v
	return s
}

type GetYongYouOpenApiTokenHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetYongYouOpenApiTokenHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOpenApiTokenHeaders) GoString() string {
	return s.String()
}

func (s *GetYongYouOpenApiTokenHeaders) SetCommonHeaders(v map[string]*string) *GetYongYouOpenApiTokenHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetYongYouOpenApiTokenHeaders) SetXAcsDingtalkAccessToken(v string) *GetYongYouOpenApiTokenHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetYongYouOpenApiTokenRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 50411123322
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s GetYongYouOpenApiTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOpenApiTokenRequest) GoString() string {
	return s.String()
}

func (s *GetYongYouOpenApiTokenRequest) SetUserId(v string) *GetYongYouOpenApiTokenRequest {
	s.UserId = &v
	return s
}

type GetYongYouOpenApiTokenResponseBody struct {
	// example:
	//
	// abc
	AccessToken *string `json:"accessToken,omitempty" xml:"accessToken,omitempty"`
	// example:
	//
	// accounting
	AppName *string `json:"appName,omitempty" xml:"appName,omitempty"`
	// example:
	//
	// 518400
	ExpiresIn *string `json:"expiresIn,omitempty" xml:"expiresIn,omitempty"`
	// example:
	//
	// 2512799
	RefreshExpiresIn *string `json:"refreshExpiresIn,omitempty" xml:"refreshExpiresIn,omitempty"`
	// example:
	//
	// abc
	RefreshToken *string `json:"refreshToken,omitempty" xml:"refreshToken,omitempty"`
	// example:
	//
	// auth_all
	Scope *string `json:"scope,omitempty" xml:"scope,omitempty"`
	// example:
	//
	// abc
	Sid *string `json:"sid,omitempty" xml:"sid,omitempty"`
	// example:
	//
	// 123615862385832922
	YongyouOrgId *string `json:"yongyouOrgId,omitempty" xml:"yongyouOrgId,omitempty"`
	// example:
	//
	// 391733693750254232
	YongyouUserId *string `json:"yongyouUserId,omitempty" xml:"yongyouUserId,omitempty"`
}

func (s GetYongYouOpenApiTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOpenApiTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetYongYouOpenApiTokenResponseBody) SetAccessToken(v string) *GetYongYouOpenApiTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetAppName(v string) *GetYongYouOpenApiTokenResponseBody {
	s.AppName = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetExpiresIn(v string) *GetYongYouOpenApiTokenResponseBody {
	s.ExpiresIn = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetRefreshExpiresIn(v string) *GetYongYouOpenApiTokenResponseBody {
	s.RefreshExpiresIn = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetRefreshToken(v string) *GetYongYouOpenApiTokenResponseBody {
	s.RefreshToken = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetScope(v string) *GetYongYouOpenApiTokenResponseBody {
	s.Scope = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetSid(v string) *GetYongYouOpenApiTokenResponseBody {
	s.Sid = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetYongyouOrgId(v string) *GetYongYouOpenApiTokenResponseBody {
	s.YongyouOrgId = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponseBody) SetYongyouUserId(v string) *GetYongYouOpenApiTokenResponseBody {
	s.YongyouUserId = &v
	return s
}

type GetYongYouOpenApiTokenResponse struct {
	Headers    map[string]*string                  `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                              `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetYongYouOpenApiTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetYongYouOpenApiTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOpenApiTokenResponse) GoString() string {
	return s.String()
}

func (s *GetYongYouOpenApiTokenResponse) SetHeaders(v map[string]*string) *GetYongYouOpenApiTokenResponse {
	s.Headers = v
	return s
}

func (s *GetYongYouOpenApiTokenResponse) SetStatusCode(v int32) *GetYongYouOpenApiTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetYongYouOpenApiTokenResponse) SetBody(v *GetYongYouOpenApiTokenResponseBody) *GetYongYouOpenApiTokenResponse {
	s.Body = v
	return s
}

type GetYongYouOrgRelationHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetYongYouOrgRelationHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOrgRelationHeaders) GoString() string {
	return s.String()
}

func (s *GetYongYouOrgRelationHeaders) SetCommonHeaders(v map[string]*string) *GetYongYouOrgRelationHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetYongYouOrgRelationHeaders) SetXAcsDingtalkAccessToken(v string) *GetYongYouOrgRelationHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetYongYouOrgRelationResponseBody struct {
	// example:
	//
	// 20230731
	ChanjetCorpId *string `json:"chanjetCorpId,omitempty" xml:"chanjetCorpId,omitempty"`
	// example:
	//
	// 01162352501424064728
	ChanjetUserId *string `json:"chanjetUserId,omitempty" xml:"chanjetUserId,omitempty"`
	// example:
	//
	// ding9f50b15bccd16741
	CorpId *string `json:"corpId,omitempty" xml:"corpId,omitempty"`
	// example:
	//
	// 01162352501424064728
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s GetYongYouOrgRelationResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOrgRelationResponseBody) GoString() string {
	return s.String()
}

func (s *GetYongYouOrgRelationResponseBody) SetChanjetCorpId(v string) *GetYongYouOrgRelationResponseBody {
	s.ChanjetCorpId = &v
	return s
}

func (s *GetYongYouOrgRelationResponseBody) SetChanjetUserId(v string) *GetYongYouOrgRelationResponseBody {
	s.ChanjetUserId = &v
	return s
}

func (s *GetYongYouOrgRelationResponseBody) SetCorpId(v string) *GetYongYouOrgRelationResponseBody {
	s.CorpId = &v
	return s
}

func (s *GetYongYouOrgRelationResponseBody) SetUserId(v string) *GetYongYouOrgRelationResponseBody {
	s.UserId = &v
	return s
}

type GetYongYouOrgRelationResponse struct {
	Headers    map[string]*string                 `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                             `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetYongYouOrgRelationResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetYongYouOrgRelationResponse) String() string {
	return tea.Prettify(s)
}

func (s GetYongYouOrgRelationResponse) GoString() string {
	return s.String()
}

func (s *GetYongYouOrgRelationResponse) SetHeaders(v map[string]*string) *GetYongYouOrgRelationResponse {
	s.Headers = v
	return s
}

func (s *GetYongYouOrgRelationResponse) SetStatusCode(v int32) *GetYongYouOrgRelationResponse {
	s.StatusCode = &v
	return s
}

func (s *GetYongYouOrgRelationResponse) SetBody(v *GetYongYouOrgRelationResponseBody) *GetYongYouOrgRelationResponse {
	s.Body = v
	return s
}

type ProfessionBenefitConsumeHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s ProfessionBenefitConsumeHeaders) String() string {
	return tea.Prettify(s)
}

func (s ProfessionBenefitConsumeHeaders) GoString() string {
	return s.String()
}

func (s *ProfessionBenefitConsumeHeaders) SetCommonHeaders(v map[string]*string) *ProfessionBenefitConsumeHeaders {
	s.CommonHeaders = v
	return s
}

func (s *ProfessionBenefitConsumeHeaders) SetXAcsDingtalkAccessToken(v string) *ProfessionBenefitConsumeHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type ProfessionBenefitConsumeRequest struct {
	// example:
	//
	// SF_INVOICE
	BenefitCode *string `json:"benefitCode,omitempty" xml:"benefitCode,omitempty"`
	// example:
	//
	// 1234567890
	BizRequestId *string `json:"bizRequestId,omitempty" xml:"bizRequestId,omitempty"`
	Quota        *int64  `json:"quota,omitempty" xml:"quota,omitempty"`
}

func (s ProfessionBenefitConsumeRequest) String() string {
	return tea.Prettify(s)
}

func (s ProfessionBenefitConsumeRequest) GoString() string {
	return s.String()
}

func (s *ProfessionBenefitConsumeRequest) SetBenefitCode(v string) *ProfessionBenefitConsumeRequest {
	s.BenefitCode = &v
	return s
}

func (s *ProfessionBenefitConsumeRequest) SetBizRequestId(v string) *ProfessionBenefitConsumeRequest {
	s.BizRequestId = &v
	return s
}

func (s *ProfessionBenefitConsumeRequest) SetQuota(v int64) *ProfessionBenefitConsumeRequest {
	s.Quota = &v
	return s
}

type ProfessionBenefitConsumeResponseBody struct {
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s ProfessionBenefitConsumeResponseBody) String() string {
	return tea.Prettify(s)
}

func (s ProfessionBenefitConsumeResponseBody) GoString() string {
	return s.String()
}

func (s *ProfessionBenefitConsumeResponseBody) SetSuccess(v bool) *ProfessionBenefitConsumeResponseBody {
	s.Success = &v
	return s
}

type ProfessionBenefitConsumeResponse struct {
	Headers    map[string]*string                    `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *ProfessionBenefitConsumeResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s ProfessionBenefitConsumeResponse) String() string {
	return tea.Prettify(s)
}

func (s ProfessionBenefitConsumeResponse) GoString() string {
	return s.String()
}

func (s *ProfessionBenefitConsumeResponse) SetHeaders(v map[string]*string) *ProfessionBenefitConsumeResponse {
	s.Headers = v
	return s
}

func (s *ProfessionBenefitConsumeResponse) SetStatusCode(v int32) *ProfessionBenefitConsumeResponse {
	s.StatusCode = &v
	return s
}

func (s *ProfessionBenefitConsumeResponse) SetBody(v *ProfessionBenefitConsumeResponseBody) *ProfessionBenefitConsumeResponse {
	s.Body = v
	return s
}

type PushHistoricalReceiptsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s PushHistoricalReceiptsHeaders) String() string {
	return tea.Prettify(s)
}

func (s PushHistoricalReceiptsHeaders) GoString() string {
	return s.String()
}

func (s *PushHistoricalReceiptsHeaders) SetCommonHeaders(v map[string]*string) *PushHistoricalReceiptsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *PushHistoricalReceiptsHeaders) SetXAcsDingtalkAccessToken(v string) *PushHistoricalReceiptsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type PushHistoricalReceiptsRequest struct {
	// This parameter is required.
	BizId           *string `json:"bizId,omitempty" xml:"bizId,omitempty"`
	EndTime         *int64  `json:"endTime,omitempty" xml:"endTime,omitempty"`
	ForcedIgnoreDup *bool   `json:"forcedIgnoreDup,omitempty" xml:"forcedIgnoreDup,omitempty"`
	// This parameter is required.
	FormCodeList []*string `json:"formCodeList,omitempty" xml:"formCodeList,omitempty" type:"Repeated"`
	// This parameter is required.
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
}

func (s PushHistoricalReceiptsRequest) String() string {
	return tea.Prettify(s)
}

func (s PushHistoricalReceiptsRequest) GoString() string {
	return s.String()
}

func (s *PushHistoricalReceiptsRequest) SetBizId(v string) *PushHistoricalReceiptsRequest {
	s.BizId = &v
	return s
}

func (s *PushHistoricalReceiptsRequest) SetEndTime(v int64) *PushHistoricalReceiptsRequest {
	s.EndTime = &v
	return s
}

func (s *PushHistoricalReceiptsRequest) SetForcedIgnoreDup(v bool) *PushHistoricalReceiptsRequest {
	s.ForcedIgnoreDup = &v
	return s
}

func (s *PushHistoricalReceiptsRequest) SetFormCodeList(v []*string) *PushHistoricalReceiptsRequest {
	s.FormCodeList = v
	return s
}

func (s *PushHistoricalReceiptsRequest) SetStartTime(v int64) *PushHistoricalReceiptsRequest {
	s.StartTime = &v
	return s
}

type PushHistoricalReceiptsResponseBody struct {
	TaskId *string `json:"taskId,omitempty" xml:"taskId,omitempty"`
}

func (s PushHistoricalReceiptsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s PushHistoricalReceiptsResponseBody) GoString() string {
	return s.String()
}

func (s *PushHistoricalReceiptsResponseBody) SetTaskId(v string) *PushHistoricalReceiptsResponseBody {
	s.TaskId = &v
	return s
}

type PushHistoricalReceiptsResponse struct {
	Headers    map[string]*string                  `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                              `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *PushHistoricalReceiptsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s PushHistoricalReceiptsResponse) String() string {
	return tea.Prettify(s)
}

func (s PushHistoricalReceiptsResponse) GoString() string {
	return s.String()
}

func (s *PushHistoricalReceiptsResponse) SetHeaders(v map[string]*string) *PushHistoricalReceiptsResponse {
	s.Headers = v
	return s
}

func (s *PushHistoricalReceiptsResponse) SetStatusCode(v int32) *PushHistoricalReceiptsResponse {
	s.StatusCode = &v
	return s
}

func (s *PushHistoricalReceiptsResponse) SetBody(v *PushHistoricalReceiptsResponseBody) *PushHistoricalReceiptsResponse {
	s.Body = v
	return s
}

type QueryBenefitHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryBenefitHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryBenefitHeaders) GoString() string {
	return s.String()
}

func (s *QueryBenefitHeaders) SetCommonHeaders(v map[string]*string) *QueryBenefitHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryBenefitHeaders) SetXAcsDingtalkAccessToken(v string) *QueryBenefitHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryBenefitRequest struct {
	// example:
	//
	// B_SF2_INVOICE_CHECK_V2
	BenefitCode *string `json:"benefitCode,omitempty" xml:"benefitCode,omitempty"`
}

func (s QueryBenefitRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryBenefitRequest) GoString() string {
	return s.String()
}

func (s *QueryBenefitRequest) SetBenefitCode(v string) *QueryBenefitRequest {
	s.BenefitCode = &v
	return s
}

type QueryBenefitResponseBody struct {
	Result *QueryBenefitResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s QueryBenefitResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryBenefitResponseBody) GoString() string {
	return s.String()
}

func (s *QueryBenefitResponseBody) SetResult(v *QueryBenefitResponseBodyResult) *QueryBenefitResponseBody {
	s.Result = v
	return s
}

type QueryBenefitResponseBodyResult struct {
	RemainQuota *int64 `json:"remainQuota,omitempty" xml:"remainQuota,omitempty"`
	TotalQuota  *int64 `json:"totalQuota,omitempty" xml:"totalQuota,omitempty"`
}

func (s QueryBenefitResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s QueryBenefitResponseBodyResult) GoString() string {
	return s.String()
}

func (s *QueryBenefitResponseBodyResult) SetRemainQuota(v int64) *QueryBenefitResponseBodyResult {
	s.RemainQuota = &v
	return s
}

func (s *QueryBenefitResponseBodyResult) SetTotalQuota(v int64) *QueryBenefitResponseBodyResult {
	s.TotalQuota = &v
	return s
}

type QueryBenefitResponse struct {
	Headers    map[string]*string        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryBenefitResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryBenefitResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryBenefitResponse) GoString() string {
	return s.String()
}

func (s *QueryBenefitResponse) SetHeaders(v map[string]*string) *QueryBenefitResponse {
	s.Headers = v
	return s
}

func (s *QueryBenefitResponse) SetStatusCode(v int32) *QueryBenefitResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryBenefitResponse) SetBody(v *QueryBenefitResponseBody) *QueryBenefitResponse {
	s.Body = v
	return s
}

type QueryCategoryByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryCategoryByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryCategoryByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryCategoryByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryCategoryByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryCategoryByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryCategoryByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryCategoryByPageRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 0
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
}

func (s QueryCategoryByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryCategoryByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryCategoryByPageRequest) SetPageNumber(v int64) *QueryCategoryByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryCategoryByPageRequest) SetPageSize(v int64) *QueryCategoryByPageRequest {
	s.PageSize = &v
	return s
}

func (s *QueryCategoryByPageRequest) SetType(v string) *QueryCategoryByPageRequest {
	s.Type = &v
	return s
}

type QueryCategoryByPageResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// This parameter is required.
	List []*QueryCategoryByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryCategoryByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryCategoryByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryCategoryByPageResponseBody) SetHasMore(v bool) *QueryCategoryByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryCategoryByPageResponseBody) SetList(v []*QueryCategoryByPageResponseBodyList) *QueryCategoryByPageResponseBody {
	s.List = v
	return s
}

type QueryCategoryByPageResponseBodyList struct {
	// This parameter is required.
	//
	// example:
	//
	// INCOME_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// false
	IsDir *bool `json:"isDir,omitempty" xml:"isDir,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 汽车
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// INCOM_XXX
	ParentCode *string `json:"parentCode,omitempty" xml:"parentCode,omitempty"`
	Remark     *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// income
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
}

func (s QueryCategoryByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryCategoryByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryCategoryByPageResponseBodyList) SetCode(v string) *QueryCategoryByPageResponseBodyList {
	s.Code = &v
	return s
}

func (s *QueryCategoryByPageResponseBodyList) SetIsDir(v bool) *QueryCategoryByPageResponseBodyList {
	s.IsDir = &v
	return s
}

func (s *QueryCategoryByPageResponseBodyList) SetName(v string) *QueryCategoryByPageResponseBodyList {
	s.Name = &v
	return s
}

func (s *QueryCategoryByPageResponseBodyList) SetParentCode(v string) *QueryCategoryByPageResponseBodyList {
	s.ParentCode = &v
	return s
}

func (s *QueryCategoryByPageResponseBodyList) SetRemark(v string) *QueryCategoryByPageResponseBodyList {
	s.Remark = &v
	return s
}

func (s *QueryCategoryByPageResponseBodyList) SetStatus(v string) *QueryCategoryByPageResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryCategoryByPageResponseBodyList) SetType(v string) *QueryCategoryByPageResponseBodyList {
	s.Type = &v
	return s
}

type QueryCategoryByPageResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryCategoryByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryCategoryByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryCategoryByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryCategoryByPageResponse) SetHeaders(v map[string]*string) *QueryCategoryByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryCategoryByPageResponse) SetStatusCode(v int32) *QueryCategoryByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryCategoryByPageResponse) SetBody(v *QueryCategoryByPageResponseBody) *QueryCategoryByPageResponse {
	s.Body = v
	return s
}

type QueryCompanyInvoiceRelationCountHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryCompanyInvoiceRelationCountHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryCompanyInvoiceRelationCountHeaders) GoString() string {
	return s.String()
}

func (s *QueryCompanyInvoiceRelationCountHeaders) SetCommonHeaders(v map[string]*string) *QueryCompanyInvoiceRelationCountHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryCompanyInvoiceRelationCountHeaders) SetXAcsDingtalkAccessToken(v string) *QueryCompanyInvoiceRelationCountHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryCompanyInvoiceRelationCountRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
}

func (s QueryCompanyInvoiceRelationCountRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryCompanyInvoiceRelationCountRequest) GoString() string {
	return s.String()
}

func (s *QueryCompanyInvoiceRelationCountRequest) SetCompanyCode(v string) *QueryCompanyInvoiceRelationCountRequest {
	s.CompanyCode = &v
	return s
}

type QueryCompanyInvoiceRelationCountResponseBody struct {
	RelationCountMap map[string]*int64 `json:"relationCountMap,omitempty" xml:"relationCountMap,omitempty"`
}

func (s QueryCompanyInvoiceRelationCountResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryCompanyInvoiceRelationCountResponseBody) GoString() string {
	return s.String()
}

func (s *QueryCompanyInvoiceRelationCountResponseBody) SetRelationCountMap(v map[string]*int64) *QueryCompanyInvoiceRelationCountResponseBody {
	s.RelationCountMap = v
	return s
}

type QueryCompanyInvoiceRelationCountResponse struct {
	Headers    map[string]*string                            `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                        `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryCompanyInvoiceRelationCountResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryCompanyInvoiceRelationCountResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryCompanyInvoiceRelationCountResponse) GoString() string {
	return s.String()
}

func (s *QueryCompanyInvoiceRelationCountResponse) SetHeaders(v map[string]*string) *QueryCompanyInvoiceRelationCountResponse {
	s.Headers = v
	return s
}

func (s *QueryCompanyInvoiceRelationCountResponse) SetStatusCode(v int32) *QueryCompanyInvoiceRelationCountResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryCompanyInvoiceRelationCountResponse) SetBody(v *QueryCompanyInvoiceRelationCountResponseBody) *QueryCompanyInvoiceRelationCountResponse {
	s.Body = v
	return s
}

type QueryCustomerByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryCustomerByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryCustomerByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryCustomerByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryCustomerByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryCustomerByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryCustomerByPageRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
}

func (s QueryCustomerByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryCustomerByPageRequest) SetPageNumber(v int64) *QueryCustomerByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryCustomerByPageRequest) SetPageSize(v int64) *QueryCustomerByPageRequest {
	s.PageSize = &v
	return s
}

type QueryCustomerByPageResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// This parameter is required.
	List []*QueryCustomerByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryCustomerByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryCustomerByPageResponseBody) SetHasMore(v bool) *QueryCustomerByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryCustomerByPageResponseBody) SetList(v []*QueryCustomerByPageResponseBodyList) *QueryCustomerByPageResponseBody {
	s.List = v
	return s
}

type QueryCustomerByPageResponseBodyList struct {
	// This parameter is required.
	//
	// example:
	//
	// CUS_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1634786828686
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 重要客户
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// XX有限公司
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s QueryCustomerByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryCustomerByPageResponseBodyList) SetCode(v string) *QueryCustomerByPageResponseBodyList {
	s.Code = &v
	return s
}

func (s *QueryCustomerByPageResponseBodyList) SetCreateTime(v int64) *QueryCustomerByPageResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryCustomerByPageResponseBodyList) SetDescription(v string) *QueryCustomerByPageResponseBodyList {
	s.Description = &v
	return s
}

func (s *QueryCustomerByPageResponseBodyList) SetName(v string) *QueryCustomerByPageResponseBodyList {
	s.Name = &v
	return s
}

func (s *QueryCustomerByPageResponseBodyList) SetStatus(v string) *QueryCustomerByPageResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryCustomerByPageResponseBodyList) SetUserDefineCode(v string) *QueryCustomerByPageResponseBodyList {
	s.UserDefineCode = &v
	return s
}

type QueryCustomerByPageResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryCustomerByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryCustomerByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryCustomerByPageResponse) SetHeaders(v map[string]*string) *QueryCustomerByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryCustomerByPageResponse) SetStatusCode(v int32) *QueryCustomerByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryCustomerByPageResponse) SetBody(v *QueryCustomerByPageResponseBody) *QueryCustomerByPageResponse {
	s.Body = v
	return s
}

type QueryCustomerInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryCustomerInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerInfoHeaders) GoString() string {
	return s.String()
}

func (s *QueryCustomerInfoHeaders) SetCommonHeaders(v map[string]*string) *QueryCustomerInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryCustomerInfoHeaders) SetXAcsDingtalkAccessToken(v string) *QueryCustomerInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryCustomerInfoRequest struct {
	Keyword *string `json:"keyword,omitempty" xml:"keyword,omitempty"`
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// example:
	//
	// 20
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
}

func (s QueryCustomerInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerInfoRequest) GoString() string {
	return s.String()
}

func (s *QueryCustomerInfoRequest) SetKeyword(v string) *QueryCustomerInfoRequest {
	s.Keyword = &v
	return s
}

func (s *QueryCustomerInfoRequest) SetPageNumber(v int64) *QueryCustomerInfoRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryCustomerInfoRequest) SetPageSize(v int64) *QueryCustomerInfoRequest {
	s.PageSize = &v
	return s
}

type QueryCustomerInfoResponseBody struct {
	// example:
	//
	// true
	HasMore *bool                                `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	List    []*QueryCustomerInfoResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
	// example:
	//
	// 500
	TotalCount *int64 `json:"totalCount,omitempty" xml:"totalCount,omitempty"`
}

func (s QueryCustomerInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerInfoResponseBody) GoString() string {
	return s.String()
}

func (s *QueryCustomerInfoResponseBody) SetHasMore(v bool) *QueryCustomerInfoResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryCustomerInfoResponseBody) SetList(v []*QueryCustomerInfoResponseBodyList) *QueryCustomerInfoResponseBody {
	s.List = v
	return s
}

func (s *QueryCustomerInfoResponseBody) SetTotalCount(v int64) *QueryCustomerInfoResponseBody {
	s.TotalCount = &v
	return s
}

type QueryCustomerInfoResponseBodyList struct {
	// example:
	//
	// CUS_xxxxxxxx
	Code                    *string `json:"code,omitempty" xml:"code,omitempty"`
	ContactAddress          *string `json:"contactAddress,omitempty" xml:"contactAddress,omitempty"`
	ContactCompanyTelephone *string `json:"contactCompanyTelephone,omitempty" xml:"contactCompanyTelephone,omitempty"`
	ContactEmail            *string `json:"contactEmail,omitempty" xml:"contactEmail,omitempty"`
	ContactName             *string `json:"contactName,omitempty" xml:"contactName,omitempty"`
	ContactTelephone        *string `json:"contactTelephone,omitempty" xml:"contactTelephone,omitempty"`
	// example:
	//
	// abc
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// example:
	//
	// www.abc.com
	DrawerEmail *string `json:"drawerEmail,omitempty" xml:"drawerEmail,omitempty"`
	// example:
	//
	// 12345678901
	DrawerTelephone *string `json:"drawerTelephone,omitempty" xml:"drawerTelephone,omitempty"`
	// example:
	//
	// 张三
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// abc
	PurchaserAccount *string `json:"purchaserAccount,omitempty" xml:"purchaserAccount,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// abc
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 123
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 13333333333
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	// example:
	//
	// 建行
	PurchaserrBankName *string `json:"purchaserrBankName,omitempty" xml:"purchaserrBankName,omitempty"`
	// example:
	//
	// valid
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// example:
	//
	// 199200
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s QueryCustomerInfoResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerInfoResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryCustomerInfoResponseBodyList) SetCode(v string) *QueryCustomerInfoResponseBodyList {
	s.Code = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetContactAddress(v string) *QueryCustomerInfoResponseBodyList {
	s.ContactAddress = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetContactCompanyTelephone(v string) *QueryCustomerInfoResponseBodyList {
	s.ContactCompanyTelephone = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetContactEmail(v string) *QueryCustomerInfoResponseBodyList {
	s.ContactEmail = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetContactName(v string) *QueryCustomerInfoResponseBodyList {
	s.ContactName = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetContactTelephone(v string) *QueryCustomerInfoResponseBodyList {
	s.ContactTelephone = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetDescription(v string) *QueryCustomerInfoResponseBodyList {
	s.Description = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetDrawerEmail(v string) *QueryCustomerInfoResponseBodyList {
	s.DrawerEmail = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetDrawerTelephone(v string) *QueryCustomerInfoResponseBodyList {
	s.DrawerTelephone = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetName(v string) *QueryCustomerInfoResponseBodyList {
	s.Name = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetPurchaserAccount(v string) *QueryCustomerInfoResponseBodyList {
	s.PurchaserAccount = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetPurchaserAddress(v string) *QueryCustomerInfoResponseBodyList {
	s.PurchaserAddress = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetPurchaserName(v string) *QueryCustomerInfoResponseBodyList {
	s.PurchaserName = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetPurchaserTaxNo(v string) *QueryCustomerInfoResponseBodyList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetPurchaserTel(v string) *QueryCustomerInfoResponseBodyList {
	s.PurchaserTel = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetPurchaserrBankName(v string) *QueryCustomerInfoResponseBodyList {
	s.PurchaserrBankName = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetStatus(v string) *QueryCustomerInfoResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryCustomerInfoResponseBodyList) SetUserDefineCode(v string) *QueryCustomerInfoResponseBodyList {
	s.UserDefineCode = &v
	return s
}

type QueryCustomerInfoResponse struct {
	Headers    map[string]*string             `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                         `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryCustomerInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryCustomerInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryCustomerInfoResponse) GoString() string {
	return s.String()
}

func (s *QueryCustomerInfoResponse) SetHeaders(v map[string]*string) *QueryCustomerInfoResponse {
	s.Headers = v
	return s
}

func (s *QueryCustomerInfoResponse) SetStatusCode(v int32) *QueryCustomerInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryCustomerInfoResponse) SetBody(v *QueryCustomerInfoResponseBody) *QueryCustomerInfoResponse {
	s.Body = v
	return s
}

type QueryEnterpriseAccountByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryEnterpriseAccountByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryEnterpriseAccountByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryEnterpriseAccountByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryEnterpriseAccountByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryEnterpriseAccountByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryEnterpriseAccountByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryEnterpriseAccountByPageRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
}

func (s QueryEnterpriseAccountByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryEnterpriseAccountByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryEnterpriseAccountByPageRequest) SetPageNumber(v int64) *QueryEnterpriseAccountByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryEnterpriseAccountByPageRequest) SetPageSize(v int64) *QueryEnterpriseAccountByPageRequest {
	s.PageSize = &v
	return s
}

type QueryEnterpriseAccountByPageResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// This parameter is required.
	List []*QueryEnterpriseAccountByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryEnterpriseAccountByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryEnterpriseAccountByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryEnterpriseAccountByPageResponseBody) SetHasMore(v bool) *QueryEnterpriseAccountByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBody) SetList(v []*QueryEnterpriseAccountByPageResponseBodyList) *QueryEnterpriseAccountByPageResponseBody {
	s.List = v
	return s
}

type QueryEnterpriseAccountByPageResponseBodyList struct {
	// This parameter is required.
	//
	// example:
	//
	// 12345
	AccountCode *string `json:"accountCode,omitempty" xml:"accountCode,omitempty"`
	// example:
	//
	// test@alipay.com
	AccountId *string `json:"accountId,omitempty" xml:"accountId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 网商银行
	AccountName *string `json:"accountName,omitempty" xml:"accountName,omitempty"`
	// example:
	//
	// test
	AccountRemark *string `json:"accountRemark,omitempty" xml:"accountRemark,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// ALIPAY
	AccountType *string `json:"accountType,omitempty" xml:"accountType,omitempty"`
	// example:
	//
	// 10000.33
	Amount   *string `json:"amount,omitempty" xml:"amount,omitempty"`
	BankCode *string `json:"bankCode,omitempty" xml:"bankCode,omitempty"`
	BankName *string `json:"bankName,omitempty" xml:"bankName,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1631526550994
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// aaa
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
}

func (s QueryEnterpriseAccountByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryEnterpriseAccountByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetAccountCode(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.AccountCode = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetAccountId(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.AccountId = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetAccountName(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.AccountName = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetAccountRemark(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.AccountRemark = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetAccountType(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.AccountType = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetAmount(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.Amount = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetBankCode(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.BankCode = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetBankName(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.BankName = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetCreateTime(v int64) *QueryEnterpriseAccountByPageResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponseBodyList) SetCreator(v string) *QueryEnterpriseAccountByPageResponseBodyList {
	s.Creator = &v
	return s
}

type QueryEnterpriseAccountByPageResponse struct {
	Headers    map[string]*string                        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryEnterpriseAccountByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryEnterpriseAccountByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryEnterpriseAccountByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryEnterpriseAccountByPageResponse) SetHeaders(v map[string]*string) *QueryEnterpriseAccountByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryEnterpriseAccountByPageResponse) SetStatusCode(v int32) *QueryEnterpriseAccountByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryEnterpriseAccountByPageResponse) SetBody(v *QueryEnterpriseAccountByPageResponseBody) *QueryEnterpriseAccountByPageResponse {
	s.Body = v
	return s
}

type QueryFinanceCompanyInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryFinanceCompanyInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryFinanceCompanyInfoHeaders) GoString() string {
	return s.String()
}

func (s *QueryFinanceCompanyInfoHeaders) SetCommonHeaders(v map[string]*string) *QueryFinanceCompanyInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryFinanceCompanyInfoHeaders) SetXAcsDingtalkAccessToken(v string) *QueryFinanceCompanyInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryFinanceCompanyInfoResponseBody struct {
	CompanyName *string `json:"companyName,omitempty" xml:"companyName,omitempty"`
	TaxNature   *string `json:"taxNature,omitempty" xml:"taxNature,omitempty"`
	TaxNo       *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
}

func (s QueryFinanceCompanyInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryFinanceCompanyInfoResponseBody) GoString() string {
	return s.String()
}

func (s *QueryFinanceCompanyInfoResponseBody) SetCompanyName(v string) *QueryFinanceCompanyInfoResponseBody {
	s.CompanyName = &v
	return s
}

func (s *QueryFinanceCompanyInfoResponseBody) SetTaxNature(v string) *QueryFinanceCompanyInfoResponseBody {
	s.TaxNature = &v
	return s
}

func (s *QueryFinanceCompanyInfoResponseBody) SetTaxNo(v string) *QueryFinanceCompanyInfoResponseBody {
	s.TaxNo = &v
	return s
}

type QueryFinanceCompanyInfoResponse struct {
	Headers    map[string]*string                   `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                               `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryFinanceCompanyInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryFinanceCompanyInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryFinanceCompanyInfoResponse) GoString() string {
	return s.String()
}

func (s *QueryFinanceCompanyInfoResponse) SetHeaders(v map[string]*string) *QueryFinanceCompanyInfoResponse {
	s.Headers = v
	return s
}

func (s *QueryFinanceCompanyInfoResponse) SetStatusCode(v int32) *QueryFinanceCompanyInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryFinanceCompanyInfoResponse) SetBody(v *QueryFinanceCompanyInfoResponseBody) *QueryFinanceCompanyInfoResponse {
	s.Body = v
	return s
}

type QueryInvoiceRelationCountHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryInvoiceRelationCountHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryInvoiceRelationCountHeaders) GoString() string {
	return s.String()
}

func (s *QueryInvoiceRelationCountHeaders) SetCommonHeaders(v map[string]*string) *QueryInvoiceRelationCountHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryInvoiceRelationCountHeaders) SetXAcsDingtalkAccessToken(v string) *QueryInvoiceRelationCountHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryInvoiceRelationCountResponseBody struct {
	RelationCountMap map[string]*int64 `json:"relationCountMap,omitempty" xml:"relationCountMap,omitempty"`
}

func (s QueryInvoiceRelationCountResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryInvoiceRelationCountResponseBody) GoString() string {
	return s.String()
}

func (s *QueryInvoiceRelationCountResponseBody) SetRelationCountMap(v map[string]*int64) *QueryInvoiceRelationCountResponseBody {
	s.RelationCountMap = v
	return s
}

type QueryInvoiceRelationCountResponse struct {
	Headers    map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryInvoiceRelationCountResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryInvoiceRelationCountResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryInvoiceRelationCountResponse) GoString() string {
	return s.String()
}

func (s *QueryInvoiceRelationCountResponse) SetHeaders(v map[string]*string) *QueryInvoiceRelationCountResponse {
	s.Headers = v
	return s
}

func (s *QueryInvoiceRelationCountResponse) SetStatusCode(v int32) *QueryInvoiceRelationCountResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryInvoiceRelationCountResponse) SetBody(v *QueryInvoiceRelationCountResponseBody) *QueryInvoiceRelationCountResponse {
	s.Body = v
	return s
}

type QueryMultiCompanyInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryMultiCompanyInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryMultiCompanyInfoHeaders) GoString() string {
	return s.String()
}

func (s *QueryMultiCompanyInfoHeaders) SetCommonHeaders(v map[string]*string) *QueryMultiCompanyInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryMultiCompanyInfoHeaders) SetXAcsDingtalkAccessToken(v string) *QueryMultiCompanyInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryMultiCompanyInfoResponseBody struct {
	List []*QueryMultiCompanyInfoResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryMultiCompanyInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryMultiCompanyInfoResponseBody) GoString() string {
	return s.String()
}

func (s *QueryMultiCompanyInfoResponseBody) SetList(v []*QueryMultiCompanyInfoResponseBodyList) *QueryMultiCompanyInfoResponseBody {
	s.List = v
	return s
}

type QueryMultiCompanyInfoResponseBodyList struct {
	AccountantBookId    *string                                                     `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	AdvancedSettingList []*QueryMultiCompanyInfoResponseBodyListAdvancedSettingList `json:"advancedSettingList,omitempty" xml:"advancedSettingList,omitempty" type:"Repeated"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 钉钉
	CompanyName *string `json:"companyName,omitempty" xml:"companyName,omitempty"`
	// example:
	//
	// 123456789
	CreateTime *string `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// example:
	//
	// 备注
	Remark *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// valid
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// example:
	//
	// generalTaxpayer
	TaxNature *string `json:"taxNature,omitempty" xml:"taxNature,omitempty"`
	// example:
	//
	// 123456789012345
	TaxNo *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
}

func (s QueryMultiCompanyInfoResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryMultiCompanyInfoResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetAccountantBookId(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.AccountantBookId = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetAdvancedSettingList(v []*QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) *QueryMultiCompanyInfoResponseBodyList {
	s.AdvancedSettingList = v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetCompanyCode(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.CompanyCode = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetCompanyName(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.CompanyName = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetCreateTime(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetRemark(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.Remark = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetStatus(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetTaxNature(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.TaxNature = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyList) SetTaxNo(v string) *QueryMultiCompanyInfoResponseBodyList {
	s.TaxNo = &v
	return s
}

type QueryMultiCompanyInfoResponseBodyListAdvancedSettingList struct {
	// example:
	//
	// relatedInvoice
	AdvancedSettingKey *string `json:"advancedSettingKey,omitempty" xml:"advancedSettingKey,omitempty"`
	// example:
	//
	// 关联发票
	AdvancedSettingName *string `json:"advancedSettingName,omitempty" xml:"advancedSettingName,omitempty"`
	// example:
	//
	// 123456789
	EndDate *int64 `json:"endDate,omitempty" xml:"endDate,omitempty"`
	Valid   *bool  `json:"valid,omitempty" xml:"valid,omitempty"`
	Value   *bool  `json:"value,omitempty" xml:"value,omitempty"`
}

func (s QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) String() string {
	return tea.Prettify(s)
}

func (s QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) GoString() string {
	return s.String()
}

func (s *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) SetAdvancedSettingKey(v string) *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList {
	s.AdvancedSettingKey = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) SetAdvancedSettingName(v string) *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList {
	s.AdvancedSettingName = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) SetEndDate(v int64) *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList {
	s.EndDate = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) SetValid(v bool) *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList {
	s.Valid = &v
	return s
}

func (s *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList) SetValue(v bool) *QueryMultiCompanyInfoResponseBodyListAdvancedSettingList {
	s.Value = &v
	return s
}

type QueryMultiCompanyInfoResponse struct {
	Headers    map[string]*string                 `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                             `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryMultiCompanyInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryMultiCompanyInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryMultiCompanyInfoResponse) GoString() string {
	return s.String()
}

func (s *QueryMultiCompanyInfoResponse) SetHeaders(v map[string]*string) *QueryMultiCompanyInfoResponse {
	s.Headers = v
	return s
}

func (s *QueryMultiCompanyInfoResponse) SetStatusCode(v int32) *QueryMultiCompanyInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryMultiCompanyInfoResponse) SetBody(v *QueryMultiCompanyInfoResponseBody) *QueryMultiCompanyInfoResponse {
	s.Body = v
	return s
}

type QueryPermissionByUserIdHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryPermissionByUserIdHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionByUserIdHeaders) GoString() string {
	return s.String()
}

func (s *QueryPermissionByUserIdHeaders) SetCommonHeaders(v map[string]*string) *QueryPermissionByUserIdHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryPermissionByUserIdHeaders) SetXAcsDingtalkAccessToken(v string) *QueryPermissionByUserIdHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryPermissionByUserIdRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// This parameter is required.
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryPermissionByUserIdRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionByUserIdRequest) GoString() string {
	return s.String()
}

func (s *QueryPermissionByUserIdRequest) SetCompanyCode(v string) *QueryPermissionByUserIdRequest {
	s.CompanyCode = &v
	return s
}

func (s *QueryPermissionByUserIdRequest) SetUserId(v string) *QueryPermissionByUserIdRequest {
	s.UserId = &v
	return s
}

type QueryPermissionByUserIdResponseBody struct {
	CompanyCode       *string                                                 `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	PermissionDTOList []*QueryPermissionByUserIdResponseBodyPermissionDTOList `json:"permissionDTOList,omitempty" xml:"permissionDTOList,omitempty" type:"Repeated"`
	// example:
	//
	// 123456789
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryPermissionByUserIdResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionByUserIdResponseBody) GoString() string {
	return s.String()
}

func (s *QueryPermissionByUserIdResponseBody) SetCompanyCode(v string) *QueryPermissionByUserIdResponseBody {
	s.CompanyCode = &v
	return s
}

func (s *QueryPermissionByUserIdResponseBody) SetPermissionDTOList(v []*QueryPermissionByUserIdResponseBodyPermissionDTOList) *QueryPermissionByUserIdResponseBody {
	s.PermissionDTOList = v
	return s
}

func (s *QueryPermissionByUserIdResponseBody) SetUserId(v string) *QueryPermissionByUserIdResponseBody {
	s.UserId = &v
	return s
}

type QueryPermissionByUserIdResponseBodyPermissionDTOList struct {
	ActionIdList     []*string `json:"actionIdList,omitempty" xml:"actionIdList,omitempty" type:"Repeated"`
	ResourceIdentity *string   `json:"resourceIdentity,omitempty" xml:"resourceIdentity,omitempty"`
}

func (s QueryPermissionByUserIdResponseBodyPermissionDTOList) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionByUserIdResponseBodyPermissionDTOList) GoString() string {
	return s.String()
}

func (s *QueryPermissionByUserIdResponseBodyPermissionDTOList) SetActionIdList(v []*string) *QueryPermissionByUserIdResponseBodyPermissionDTOList {
	s.ActionIdList = v
	return s
}

func (s *QueryPermissionByUserIdResponseBodyPermissionDTOList) SetResourceIdentity(v string) *QueryPermissionByUserIdResponseBodyPermissionDTOList {
	s.ResourceIdentity = &v
	return s
}

type QueryPermissionByUserIdResponse struct {
	Headers    map[string]*string                   `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                               `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryPermissionByUserIdResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryPermissionByUserIdResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionByUserIdResponse) GoString() string {
	return s.String()
}

func (s *QueryPermissionByUserIdResponse) SetHeaders(v map[string]*string) *QueryPermissionByUserIdResponse {
	s.Headers = v
	return s
}

func (s *QueryPermissionByUserIdResponse) SetStatusCode(v int32) *QueryPermissionByUserIdResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryPermissionByUserIdResponse) SetBody(v *QueryPermissionByUserIdResponseBody) *QueryPermissionByUserIdResponse {
	s.Body = v
	return s
}

type QueryPermissionRoleMemberHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryPermissionRoleMemberHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionRoleMemberHeaders) GoString() string {
	return s.String()
}

func (s *QueryPermissionRoleMemberHeaders) SetCommonHeaders(v map[string]*string) *QueryPermissionRoleMemberHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryPermissionRoleMemberHeaders) SetXAcsDingtalkAccessToken(v string) *QueryPermissionRoleMemberHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryPermissionRoleMemberRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// This parameter is required.
	RoleCodeList []*string `json:"roleCodeList,omitempty" xml:"roleCodeList,omitempty" type:"Repeated"`
}

func (s QueryPermissionRoleMemberRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionRoleMemberRequest) GoString() string {
	return s.String()
}

func (s *QueryPermissionRoleMemberRequest) SetCompanyCode(v string) *QueryPermissionRoleMemberRequest {
	s.CompanyCode = &v
	return s
}

func (s *QueryPermissionRoleMemberRequest) SetRoleCodeList(v []*string) *QueryPermissionRoleMemberRequest {
	s.RoleCodeList = v
	return s
}

type QueryPermissionRoleMemberResponseBody struct {
	RoleMemberMap map[string]*RoleMemberMapValue `json:"roleMemberMap,omitempty" xml:"roleMemberMap,omitempty"`
}

func (s QueryPermissionRoleMemberResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionRoleMemberResponseBody) GoString() string {
	return s.String()
}

func (s *QueryPermissionRoleMemberResponseBody) SetRoleMemberMap(v map[string]*RoleMemberMapValue) *QueryPermissionRoleMemberResponseBody {
	s.RoleMemberMap = v
	return s
}

type QueryPermissionRoleMemberResponse struct {
	Headers    map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryPermissionRoleMemberResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryPermissionRoleMemberResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryPermissionRoleMemberResponse) GoString() string {
	return s.String()
}

func (s *QueryPermissionRoleMemberResponse) SetHeaders(v map[string]*string) *QueryPermissionRoleMemberResponse {
	s.Headers = v
	return s
}

func (s *QueryPermissionRoleMemberResponse) SetStatusCode(v int32) *QueryPermissionRoleMemberResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryPermissionRoleMemberResponse) SetBody(v *QueryPermissionRoleMemberResponseBody) *QueryPermissionRoleMemberResponse {
	s.Body = v
	return s
}

type QueryProductByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryProductByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryProductByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryProductByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryProductByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryProductByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryProductByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryProductByPageRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
}

func (s QueryProductByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryProductByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryProductByPageRequest) SetPageNumber(v int64) *QueryProductByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryProductByPageRequest) SetPageSize(v int64) *QueryProductByPageRequest {
	s.PageSize = &v
	return s
}

type QueryProductByPageResponseBody struct {
	HasMore *bool                                 `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	List    []*QueryProductByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryProductByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryProductByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryProductByPageResponseBody) SetHasMore(v bool) *QueryProductByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryProductByPageResponseBody) SetList(v []*QueryProductByPageResponseBodyList) *QueryProductByPageResponseBody {
	s.List = v
	return s
}

type QueryProductByPageResponseBodyList struct {
	Code           *string `json:"code,omitempty" xml:"code,omitempty"`
	CreateTime     *int64  `json:"createTime,omitempty" xml:"createTime,omitempty"`
	Description    *string `json:"description,omitempty" xml:"description,omitempty"`
	Information    *string `json:"information,omitempty" xml:"information,omitempty"`
	Name           *string `json:"name,omitempty" xml:"name,omitempty"`
	Specification  *string `json:"specification,omitempty" xml:"specification,omitempty"`
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	Unit           *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s QueryProductByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryProductByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryProductByPageResponseBodyList) SetCode(v string) *QueryProductByPageResponseBodyList {
	s.Code = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetCreateTime(v int64) *QueryProductByPageResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetDescription(v string) *QueryProductByPageResponseBodyList {
	s.Description = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetInformation(v string) *QueryProductByPageResponseBodyList {
	s.Information = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetName(v string) *QueryProductByPageResponseBodyList {
	s.Name = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetSpecification(v string) *QueryProductByPageResponseBodyList {
	s.Specification = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetStatus(v string) *QueryProductByPageResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetUnit(v string) *QueryProductByPageResponseBodyList {
	s.Unit = &v
	return s
}

func (s *QueryProductByPageResponseBodyList) SetUserDefineCode(v string) *QueryProductByPageResponseBodyList {
	s.UserDefineCode = &v
	return s
}

type QueryProductByPageResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryProductByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryProductByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryProductByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryProductByPageResponse) SetHeaders(v map[string]*string) *QueryProductByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryProductByPageResponse) SetStatusCode(v int32) *QueryProductByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryProductByPageResponse) SetBody(v *QueryProductByPageResponseBody) *QueryProductByPageResponse {
	s.Body = v
	return s
}

type QueryProjectByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryProjectByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryProjectByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryProjectByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryProjectByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryProjectByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryProjectByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryProjectByPageRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
}

func (s QueryProjectByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryProjectByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryProjectByPageRequest) SetPageNumber(v int64) *QueryProjectByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryProjectByPageRequest) SetPageSize(v int64) *QueryProjectByPageRequest {
	s.PageSize = &v
	return s
}

type QueryProjectByPageResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// This parameter is required.
	List []*QueryProjectByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryProjectByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryProjectByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryProjectByPageResponseBody) SetHasMore(v bool) *QueryProjectByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryProjectByPageResponseBody) SetList(v []*QueryProjectByPageResponseBodyList) *QueryProjectByPageResponseBody {
	s.List = v
	return s
}

type QueryProjectByPageResponseBodyList struct {
	Caode *string `json:"caode,omitempty" xml:"caode,omitempty"`
	Code  *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1631524595555
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// aaaa
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
	// example:
	//
	// 外派项目
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	Name        *string `json:"name,omitempty" xml:"name,omitempty"`
	ParentCode  *string `json:"parentCode,omitempty" xml:"parentCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// PROJ-xxx
	ProjectCode *string `json:"projectCode,omitempty" xml:"projectCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 外派项目
	ProjectName *string `json:"projectName,omitempty" xml:"projectName,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s QueryProjectByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryProjectByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryProjectByPageResponseBodyList) SetCaode(v string) *QueryProjectByPageResponseBodyList {
	s.Caode = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetCode(v string) *QueryProjectByPageResponseBodyList {
	s.Code = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetCreateTime(v int64) *QueryProjectByPageResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetCreator(v string) *QueryProjectByPageResponseBodyList {
	s.Creator = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetDescription(v string) *QueryProjectByPageResponseBodyList {
	s.Description = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetName(v string) *QueryProjectByPageResponseBodyList {
	s.Name = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetParentCode(v string) *QueryProjectByPageResponseBodyList {
	s.ParentCode = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetProjectCode(v string) *QueryProjectByPageResponseBodyList {
	s.ProjectCode = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetProjectName(v string) *QueryProjectByPageResponseBodyList {
	s.ProjectName = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetStatus(v string) *QueryProjectByPageResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryProjectByPageResponseBodyList) SetUserDefineCode(v string) *QueryProjectByPageResponseBodyList {
	s.UserDefineCode = &v
	return s
}

type QueryProjectByPageResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryProjectByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryProjectByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryProjectByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryProjectByPageResponse) SetHeaders(v map[string]*string) *QueryProjectByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryProjectByPageResponse) SetStatusCode(v int32) *QueryProjectByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryProjectByPageResponse) SetBody(v *QueryProjectByPageResponseBody) *QueryProjectByPageResponse {
	s.Body = v
	return s
}

type QueryReceiptDetailForInvoiceHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryReceiptDetailForInvoiceHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceHeaders) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceHeaders) SetCommonHeaders(v map[string]*string) *QueryReceiptDetailForInvoiceHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryReceiptDetailForInvoiceHeaders) SetXAcsDingtalkAccessToken(v string) *QueryReceiptDetailForInvoiceHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryReceiptDetailForInvoiceRequest struct {
	// example:
	//
	// abcdefghijklmnopq
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
}

func (s QueryReceiptDetailForInvoiceRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceRequest) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceRequest) SetInstanceId(v string) *QueryReceiptDetailForInvoiceRequest {
	s.InstanceId = &v
	return s
}

type QueryReceiptDetailForInvoiceResponseBody struct {
	Result *QueryReceiptDetailForInvoiceResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s QueryReceiptDetailForInvoiceResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBody) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBody) SetResult(v *QueryReceiptDetailForInvoiceResponseBodyResult) *QueryReceiptDetailForInvoiceResponseBody {
	s.Result = v
	return s
}

type QueryReceiptDetailForInvoiceResponseBodyResult struct {
	// example:
	//
	// abc
	AccountantBookId *string `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	// example:
	//
	// 4000
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// applied
	ApplyStatus *string `json:"applyStatus,omitempty" xml:"applyStatus,omitempty"`
	// example:
	//
	// invoicing
	BizStatus *string `json:"bizStatus,omitempty" xml:"bizStatus,omitempty"`
	// example:
	//
	// 123
	BusinessId *string `json:"businessId,omitempty" xml:"businessId,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 123000
	CreateTime *string                                                 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	Creator    *QueryReceiptDetailForInvoiceResponseBodyResultCreator  `json:"creator,omitempty" xml:"creator,omitempty" type:"Struct"`
	Customer   *QueryReceiptDetailForInvoiceResponseBodyResultCustomer `json:"customer,omitempty" xml:"customer,omitempty" type:"Struct"`
	// example:
	//
	// www.abc.com
	DrawerEmail *string `json:"drawerEmail,omitempty" xml:"drawerEmail,omitempty"`
	// example:
	//
	// 12345678901
	DrawerTelephone *string `json:"drawerTelephone,omitempty" xml:"drawerTelephone,omitempty"`
	// example:
	//
	// VAT_NORMAL_E
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// EM-xxxxx
	ModelId         *string                                                          `json:"modelId,omitempty" xml:"modelId,omitempty"`
	ProductInfoList []*QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList `json:"productInfoList,omitempty" xml:"productInfoList,omitempty" type:"Repeated"`
	// example:
	//
	// 32131131231
	PurchaserAccount *string `json:"purchaserAccount,omitempty" xml:"purchaserAccount,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// 工商银行XX支行
	PurchaserBankName *string `json:"purchaserBankName,omitempty" xml:"purchaserBankName,omitempty"`
	// example:
	//
	// 钉有限公司
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 123456
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 12345678901
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	// example:
	//
	// abc
	ReceiptId *string `json:"receiptId,omitempty" xml:"receiptId,omitempty"`
	// example:
	//
	// 16000000
	RecordTime *string `json:"recordTime,omitempty" xml:"recordTime,omitempty"`
	// example:
	//
	// 备注信息
	Remark                       *string `json:"remark,omitempty" xml:"remark,omitempty"`
	ShowPurchaserAccountInRemark *bool   `json:"showPurchaserAccountInRemark,omitempty" xml:"showPurchaserAccountInRemark,omitempty"`
	ShowPurchaserContactInRemark *bool   `json:"showPurchaserContactInRemark,omitempty" xml:"showPurchaserContactInRemark,omitempty"`
	ShowSellerAccountInRemark    *bool   `json:"showSellerAccountInRemark,omitempty" xml:"showSellerAccountInRemark,omitempty"`
	ShowSellerContactInRemark    *bool   `json:"showSellerContactInRemark,omitempty" xml:"showSellerContactInRemark,omitempty"`
	// example:
	//
	// approval
	Source               *string                                                             `json:"source,omitempty" xml:"source,omitempty"`
	SpecificBusinessInfo *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo `json:"specificBusinessInfo,omitempty" xml:"specificBusinessInfo,omitempty" type:"Struct"`
	// example:
	//
	// agree
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// example:
	//
	// 张三提交的开票申请单
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
}

func (s QueryReceiptDetailForInvoiceResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBodyResult) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetAccountantBookId(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.AccountantBookId = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetAmount(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Amount = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetApplyStatus(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ApplyStatus = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetBizStatus(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.BizStatus = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetBusinessId(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.BusinessId = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetCompanyCode(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.CompanyCode = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetCreateTime(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.CreateTime = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetCreator(v *QueryReceiptDetailForInvoiceResponseBodyResultCreator) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Creator = v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetCustomer(v *QueryReceiptDetailForInvoiceResponseBodyResultCustomer) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Customer = v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetDrawerEmail(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.DrawerEmail = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetDrawerTelephone(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.DrawerTelephone = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetInvoiceType(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.InvoiceType = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetModelId(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ModelId = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetProductInfoList(v []*QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ProductInfoList = v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetPurchaserAccount(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.PurchaserAccount = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetPurchaserAddress(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.PurchaserAddress = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetPurchaserBankName(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.PurchaserBankName = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetPurchaserName(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.PurchaserName = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetPurchaserTaxNo(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.PurchaserTaxNo = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetPurchaserTel(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.PurchaserTel = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetReceiptId(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ReceiptId = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetRecordTime(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.RecordTime = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetRemark(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Remark = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetShowPurchaserAccountInRemark(v bool) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ShowPurchaserAccountInRemark = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetShowPurchaserContactInRemark(v bool) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ShowPurchaserContactInRemark = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetShowSellerAccountInRemark(v bool) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ShowSellerAccountInRemark = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetShowSellerContactInRemark(v bool) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.ShowSellerContactInRemark = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetSource(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Source = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetSpecificBusinessInfo(v *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.SpecificBusinessInfo = v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetStatus(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Status = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResult) SetTitle(v string) *QueryReceiptDetailForInvoiceResponseBodyResult {
	s.Title = &v
	return s
}

type QueryReceiptDetailForInvoiceResponseBodyResultCreator struct {
	// example:
	//
	// https://xxxx
	AvatarUrl *string `json:"avatarUrl,omitempty" xml:"avatarUrl,omitempty"`
	// example:
	//
	// 测试名字
	Nick *string `json:"nick,omitempty" xml:"nick,omitempty"`
	// example:
	//
	// 1231
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultCreator) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultCreator) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultCreator) SetAvatarUrl(v string) *QueryReceiptDetailForInvoiceResponseBodyResultCreator {
	s.AvatarUrl = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultCreator) SetNick(v string) *QueryReceiptDetailForInvoiceResponseBodyResultCreator {
	s.Nick = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultCreator) SetUserId(v string) *QueryReceiptDetailForInvoiceResponseBodyResultCreator {
	s.UserId = &v
	return s
}

type QueryReceiptDetailForInvoiceResponseBodyResultCustomer struct {
	// example:
	//
	// CUS_xxxxx
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// 李四
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultCustomer) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultCustomer) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultCustomer) SetCode(v string) *QueryReceiptDetailForInvoiceResponseBodyResultCustomer {
	s.Code = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultCustomer) SetName(v string) *QueryReceiptDetailForInvoiceResponseBodyResultCustomer {
	s.Name = &v
	return s
}

type QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList struct {
	// example:
	//
	// 12.3
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 100
	AmountWithoutTax *string `json:"amountWithoutTax,omitempty" xml:"amountWithoutTax,omitempty"`
	// example:
	//
	// 10
	DiscountAmount *string `json:"discountAmount,omitempty" xml:"discountAmount,omitempty"`
	// example:
	//
	// 鱼
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// 2
	Quantity *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	// example:
	//
	// 大型
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	// example:
	//
	// XXX
	TaxClassificationCode *string `json:"taxClassificationCode,omitempty" xml:"taxClassificationCode,omitempty"`
	// example:
	//
	// 0.3
	TaxRate *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	// example:
	//
	// 千克
	Unit *string `json:"unit,omitempty" xml:"unit,omitempty"`
	// example:
	//
	// 12.3
	UnitPriceWithTax *string `json:"unitPriceWithTax,omitempty" xml:"unitPriceWithTax,omitempty"`
	// example:
	//
	// 100
	UnitPriceWithoutTax *string `json:"unitPriceWithoutTax,omitempty" xml:"unitPriceWithoutTax,omitempty"`
	WithTax             *bool   `json:"withTax,omitempty" xml:"withTax,omitempty"`
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetAmountWithTax(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.AmountWithTax = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetAmountWithoutTax(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.AmountWithoutTax = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetDiscountAmount(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.DiscountAmount = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetName(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.Name = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetQuantity(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.Quantity = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetSpecification(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.Specification = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetTaxClassificationCode(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.TaxClassificationCode = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetTaxRate(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.TaxRate = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetUnit(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.Unit = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetUnitPriceWithTax(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.UnitPriceWithTax = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetUnitPriceWithoutTax(v string) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.UnitPriceWithoutTax = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList) SetWithTax(v bool) *QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList {
	s.WithTax = &v
	return s
}

type QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo struct {
	// example:
	//
	// lease
	SpecialBizCode           *string                                                                                       `json:"specialBizCode,omitempty" xml:"specialBizCode,omitempty"`
	SpecificBusinessInfoList []*QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList `json:"specificBusinessInfoList,omitempty" xml:"specificBusinessInfoList,omitempty" type:"Repeated"`
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo) SetSpecialBizCode(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo {
	s.SpecialBizCode = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo) SetSpecificBusinessInfoList(v []*QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfo {
	s.SpecificBusinessInfoList = v
	return s
}

type QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList struct {
	AreaUnit                  *string `json:"areaUnit,omitempty" xml:"areaUnit,omitempty"`
	CarNo                     *string `json:"carNo,omitempty" xml:"carNo,omitempty"`
	City                      *string `json:"city,omitempty" xml:"city,omitempty"`
	CrossCityFlg              *string `json:"crossCityFlg,omitempty" xml:"crossCityFlg,omitempty"`
	District                  *string `json:"district,omitempty" xml:"district,omitempty"`
	LeaseEnd                  *int64  `json:"leaseEnd,omitempty" xml:"leaseEnd,omitempty"`
	LeaseStart                *int64  `json:"leaseStart,omitempty" xml:"leaseStart,omitempty"`
	Project                   *string `json:"project,omitempty" xml:"project,omitempty"`
	ProjectNo                 *string `json:"projectNo,omitempty" xml:"projectNo,omitempty"`
	PropertyCertificateNumber *string `json:"propertyCertificateNumber,omitempty" xml:"propertyCertificateNumber,omitempty"`
	Province                  *string `json:"province,omitempty" xml:"province,omitempty"`
	RealEstateDetailedAddress *string `json:"realEstateDetailedAddress,omitempty" xml:"realEstateDetailedAddress,omitempty"`
	SpanRegionManageNo        *string `json:"spanRegionManageNo,omitempty" xml:"spanRegionManageNo,omitempty"`
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetAreaUnit(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.AreaUnit = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetCarNo(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.CarNo = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetCity(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.City = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetCrossCityFlg(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.CrossCityFlg = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetDistrict(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.District = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetLeaseEnd(v int64) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.LeaseEnd = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetLeaseStart(v int64) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.LeaseStart = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetProject(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.Project = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetProjectNo(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.ProjectNo = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetPropertyCertificateNumber(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.PropertyCertificateNumber = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetProvince(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.Province = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetRealEstateDetailedAddress(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.RealEstateDetailedAddress = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList) SetSpanRegionManageNo(v string) *QueryReceiptDetailForInvoiceResponseBodyResultSpecificBusinessInfoSpecificBusinessInfoList {
	s.SpanRegionManageNo = &v
	return s
}

type QueryReceiptDetailForInvoiceResponse struct {
	Headers    map[string]*string                        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryReceiptDetailForInvoiceResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryReceiptDetailForInvoiceResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptDetailForInvoiceResponse) GoString() string {
	return s.String()
}

func (s *QueryReceiptDetailForInvoiceResponse) SetHeaders(v map[string]*string) *QueryReceiptDetailForInvoiceResponse {
	s.Headers = v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponse) SetStatusCode(v int32) *QueryReceiptDetailForInvoiceResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryReceiptDetailForInvoiceResponse) SetBody(v *QueryReceiptDetailForInvoiceResponseBody) *QueryReceiptDetailForInvoiceResponse {
	s.Body = v
	return s
}

type QueryReceiptForInvoiceHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryReceiptForInvoiceHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceHeaders) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceHeaders) SetCommonHeaders(v map[string]*string) *QueryReceiptForInvoiceHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryReceiptForInvoiceHeaders) SetXAcsDingtalkAccessToken(v string) *QueryReceiptForInvoiceHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryReceiptForInvoiceRequest struct {
	// example:
	//
	// abc
	AccountantBookId *string   `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	ApplyStatusList  []*string `json:"applyStatusList,omitempty" xml:"applyStatusList,omitempty" type:"Repeated"`
	BizStatusList    []*string `json:"bizStatusList,omitempty" xml:"bizStatusList,omitempty" type:"Repeated"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode       *string            `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	EndTime           *int64             `json:"endTime,omitempty" xml:"endTime,omitempty"`
	PageNumber        *int64             `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	PageSize          *int64             `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
	ReceiptStatusList []*string          `json:"receiptStatusList,omitempty" xml:"receiptStatusList,omitempty" type:"Repeated"`
	SearchParams      map[string]*string `json:"searchParams,omitempty" xml:"searchParams,omitempty"`
	StartTime         *int64             `json:"startTime,omitempty" xml:"startTime,omitempty"`
	Title             *string            `json:"title,omitempty" xml:"title,omitempty"`
}

func (s QueryReceiptForInvoiceRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceRequest) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceRequest) SetAccountantBookId(v string) *QueryReceiptForInvoiceRequest {
	s.AccountantBookId = &v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetApplyStatusList(v []*string) *QueryReceiptForInvoiceRequest {
	s.ApplyStatusList = v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetBizStatusList(v []*string) *QueryReceiptForInvoiceRequest {
	s.BizStatusList = v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetCompanyCode(v string) *QueryReceiptForInvoiceRequest {
	s.CompanyCode = &v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetEndTime(v int64) *QueryReceiptForInvoiceRequest {
	s.EndTime = &v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetPageNumber(v int64) *QueryReceiptForInvoiceRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetPageSize(v int64) *QueryReceiptForInvoiceRequest {
	s.PageSize = &v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetReceiptStatusList(v []*string) *QueryReceiptForInvoiceRequest {
	s.ReceiptStatusList = v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetSearchParams(v map[string]*string) *QueryReceiptForInvoiceRequest {
	s.SearchParams = v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetStartTime(v int64) *QueryReceiptForInvoiceRequest {
	s.StartTime = &v
	return s
}

func (s *QueryReceiptForInvoiceRequest) SetTitle(v string) *QueryReceiptForInvoiceRequest {
	s.Title = &v
	return s
}

type QueryReceiptForInvoiceResponseBody struct {
	// example:
	//
	// true
	HasMore *string                                   `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	List    []*QueryReceiptForInvoiceResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
	// example:
	//
	// 500
	TotalCount *int64 `json:"totalCount,omitempty" xml:"totalCount,omitempty"`
}

func (s QueryReceiptForInvoiceResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceResponseBody) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceResponseBody) SetHasMore(v string) *QueryReceiptForInvoiceResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBody) SetList(v []*QueryReceiptForInvoiceResponseBodyList) *QueryReceiptForInvoiceResponseBody {
	s.List = v
	return s
}

func (s *QueryReceiptForInvoiceResponseBody) SetTotalCount(v int64) *QueryReceiptForInvoiceResponseBody {
	s.TotalCount = &v
	return s
}

type QueryReceiptForInvoiceResponseBodyList struct {
	// example:
	//
	// abc
	AccountantBookId *string `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	// example:
	//
	// 5000
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// applied
	ApplyStatus *string `json:"applyStatus,omitempty" xml:"applyStatus,omitempty"`
	// example:
	//
	// invoicing
	BizStatus *string `json:"bizStatus,omitempty" xml:"bizStatus,omitempty"`
	// example:
	//
	// 123
	BusinessId *string `json:"businessId,omitempty" xml:"businessId,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string                                         `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	CreateTime  *string                                         `json:"createTime,omitempty" xml:"createTime,omitempty"`
	Creator     *QueryReceiptForInvoiceResponseBodyListCreator  `json:"creator,omitempty" xml:"creator,omitempty" type:"Struct"`
	Customer    *QueryReceiptForInvoiceResponseBodyListCustomer `json:"customer,omitempty" xml:"customer,omitempty" type:"Struct"`
	// example:
	//
	// www.abc.com
	DrawerEmail *string `json:"drawerEmail,omitempty" xml:"drawerEmail,omitempty"`
	// example:
	//
	// 12345678901
	DrawerTelephone *string `json:"drawerTelephone,omitempty" xml:"drawerTelephone,omitempty"`
	// example:
	//
	// 增值税发票
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// EM-xxxxx
	ModelId         *string                                                  `json:"modelId,omitempty" xml:"modelId,omitempty"`
	ProductInfoList []*QueryReceiptForInvoiceResponseBodyListProductInfoList `json:"productInfoList,omitempty" xml:"productInfoList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	PurchaserAccount *string `json:"purchaserAccount,omitempty" xml:"purchaserAccount,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// 建设银行
	PurchaserBankName *string `json:"purchaserBankName,omitempty" xml:"purchaserBankName,omitempty"`
	// example:
	//
	// 钉有限公司
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 123456
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 13333333333
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	// example:
	//
	// abc
	ReceiptId *string `json:"receiptId,omitempty" xml:"receiptId,omitempty"`
	// example:
	//
	// 16000000
	RecordTime *string `json:"recordTime,omitempty" xml:"recordTime,omitempty"`
	// example:
	//
	// 备注信息
	Remark *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// approval
	Source *string `json:"source,omitempty" xml:"source,omitempty"`
	// example:
	//
	// agree
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// example:
	//
	// 张三提交的开票申请单
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
}

func (s QueryReceiptForInvoiceResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetAccountantBookId(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.AccountantBookId = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetAmount(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.Amount = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetApplyStatus(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.ApplyStatus = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetBizStatus(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.BizStatus = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetBusinessId(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.BusinessId = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetCompanyCode(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.CompanyCode = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetCreateTime(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetCreator(v *QueryReceiptForInvoiceResponseBodyListCreator) *QueryReceiptForInvoiceResponseBodyList {
	s.Creator = v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetCustomer(v *QueryReceiptForInvoiceResponseBodyListCustomer) *QueryReceiptForInvoiceResponseBodyList {
	s.Customer = v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetDrawerEmail(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.DrawerEmail = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetDrawerTelephone(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.DrawerTelephone = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetInvoiceType(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.InvoiceType = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetModelId(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.ModelId = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetProductInfoList(v []*QueryReceiptForInvoiceResponseBodyListProductInfoList) *QueryReceiptForInvoiceResponseBodyList {
	s.ProductInfoList = v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetPurchaserAccount(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.PurchaserAccount = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetPurchaserAddress(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.PurchaserAddress = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetPurchaserBankName(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.PurchaserBankName = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetPurchaserName(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.PurchaserName = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetPurchaserTaxNo(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetPurchaserTel(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.PurchaserTel = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetReceiptId(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.ReceiptId = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetRecordTime(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.RecordTime = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetRemark(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.Remark = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetSource(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.Source = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetStatus(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyList) SetTitle(v string) *QueryReceiptForInvoiceResponseBodyList {
	s.Title = &v
	return s
}

type QueryReceiptForInvoiceResponseBodyListCreator struct {
	// example:
	//
	// https://xxxx
	AvatarUrl *string `json:"avatarUrl,omitempty" xml:"avatarUrl,omitempty"`
	// example:
	//
	// 测试名字
	Nick *string `json:"nick,omitempty" xml:"nick,omitempty"`
	// example:
	//
	// 1231
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryReceiptForInvoiceResponseBodyListCreator) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceResponseBodyListCreator) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceResponseBodyListCreator) SetAvatarUrl(v string) *QueryReceiptForInvoiceResponseBodyListCreator {
	s.AvatarUrl = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListCreator) SetNick(v string) *QueryReceiptForInvoiceResponseBodyListCreator {
	s.Nick = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListCreator) SetUserId(v string) *QueryReceiptForInvoiceResponseBodyListCreator {
	s.UserId = &v
	return s
}

type QueryReceiptForInvoiceResponseBodyListCustomer struct {
	// example:
	//
	// CUS_xxxxx
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// 李四
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s QueryReceiptForInvoiceResponseBodyListCustomer) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceResponseBodyListCustomer) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceResponseBodyListCustomer) SetCode(v string) *QueryReceiptForInvoiceResponseBodyListCustomer {
	s.Code = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListCustomer) SetName(v string) *QueryReceiptForInvoiceResponseBodyListCustomer {
	s.Name = &v
	return s
}

type QueryReceiptForInvoiceResponseBodyListProductInfoList struct {
	// example:
	//
	// 12.3
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 100
	AmountWithoutTax *string `json:"amountWithoutTax,omitempty" xml:"amountWithoutTax,omitempty"`
	// example:
	//
	// 10
	DiscountAmount *string `json:"discountAmount,omitempty" xml:"discountAmount,omitempty"`
	// example:
	//
	// 鱼
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// 2
	Quantity *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	// example:
	//
	// 大型
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	// example:
	//
	// XXX
	TaxClassificationCode *string `json:"taxClassificationCode,omitempty" xml:"taxClassificationCode,omitempty"`
	// example:
	//
	// 0.3
	TaxRate *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	// example:
	//
	// 千克
	Unit *string `json:"unit,omitempty" xml:"unit,omitempty"`
	// example:
	//
	// 12.3
	UnitPriceWithTax *string `json:"unitPriceWithTax,omitempty" xml:"unitPriceWithTax,omitempty"`
	// example:
	//
	// 100
	UnitPriceWithoutTax *string `json:"unitPriceWithoutTax,omitempty" xml:"unitPriceWithoutTax,omitempty"`
	WithTax             *bool   `json:"withTax,omitempty" xml:"withTax,omitempty"`
}

func (s QueryReceiptForInvoiceResponseBodyListProductInfoList) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceResponseBodyListProductInfoList) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetAmountWithTax(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.AmountWithTax = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetAmountWithoutTax(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.AmountWithoutTax = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetDiscountAmount(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.DiscountAmount = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetName(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.Name = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetQuantity(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.Quantity = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetSpecification(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.Specification = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetTaxClassificationCode(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.TaxClassificationCode = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetTaxRate(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.TaxRate = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetUnit(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.Unit = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetUnitPriceWithTax(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.UnitPriceWithTax = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetUnitPriceWithoutTax(v string) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.UnitPriceWithoutTax = &v
	return s
}

func (s *QueryReceiptForInvoiceResponseBodyListProductInfoList) SetWithTax(v bool) *QueryReceiptForInvoiceResponseBodyListProductInfoList {
	s.WithTax = &v
	return s
}

type QueryReceiptForInvoiceResponse struct {
	Headers    map[string]*string                  `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                              `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryReceiptForInvoiceResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryReceiptForInvoiceResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptForInvoiceResponse) GoString() string {
	return s.String()
}

func (s *QueryReceiptForInvoiceResponse) SetHeaders(v map[string]*string) *QueryReceiptForInvoiceResponse {
	s.Headers = v
	return s
}

func (s *QueryReceiptForInvoiceResponse) SetStatusCode(v int32) *QueryReceiptForInvoiceResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryReceiptForInvoiceResponse) SetBody(v *QueryReceiptForInvoiceResponseBody) *QueryReceiptForInvoiceResponse {
	s.Body = v
	return s
}

type QueryReceiptsBaseInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryReceiptsBaseInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoHeaders) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoHeaders) SetCommonHeaders(v map[string]*string) *QueryReceiptsBaseInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryReceiptsBaseInfoHeaders) SetXAcsDingtalkAccessToken(v string) *QueryReceiptsBaseInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryReceiptsBaseInfoRequest struct {
	// example:
	//
	// abc
	AccountantBookId *string  `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	AmountEnd        *float64 `json:"amountEnd,omitempty" xml:"amountEnd,omitempty"`
	AmountStart      *float64 `json:"amountStart,omitempty" xml:"amountStart,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 16000000
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// example:
	//
	// 20
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
	// example:
	//
	// 16000000
	StartTime       *int64  `json:"startTime,omitempty" xml:"startTime,omitempty"`
	TimeFilterField *string `json:"timeFilterField,omitempty" xml:"timeFilterField,omitempty"`
	// example:
	//
	// 收款单
	Title         *string `json:"title,omitempty" xml:"title,omitempty"`
	VoucherStatus *string `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s QueryReceiptsBaseInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoRequest) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoRequest) SetAccountantBookId(v string) *QueryReceiptsBaseInfoRequest {
	s.AccountantBookId = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetAmountEnd(v float64) *QueryReceiptsBaseInfoRequest {
	s.AmountEnd = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetAmountStart(v float64) *QueryReceiptsBaseInfoRequest {
	s.AmountStart = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetCompanyCode(v string) *QueryReceiptsBaseInfoRequest {
	s.CompanyCode = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetEndTime(v int64) *QueryReceiptsBaseInfoRequest {
	s.EndTime = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetPageNumber(v int64) *QueryReceiptsBaseInfoRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetPageSize(v int64) *QueryReceiptsBaseInfoRequest {
	s.PageSize = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetStartTime(v int64) *QueryReceiptsBaseInfoRequest {
	s.StartTime = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetTimeFilterField(v string) *QueryReceiptsBaseInfoRequest {
	s.TimeFilterField = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetTitle(v string) *QueryReceiptsBaseInfoRequest {
	s.Title = &v
	return s
}

func (s *QueryReceiptsBaseInfoRequest) SetVoucherStatus(v string) *QueryReceiptsBaseInfoRequest {
	s.VoucherStatus = &v
	return s
}

type QueryReceiptsBaseInfoResponseBody struct {
	// example:
	//
	// true
	HasMore *string                                  `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	List    []*QueryReceiptsBaseInfoResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
	// example:
	//
	// 500
	TotalCount *int64 `json:"totalCount,omitempty" xml:"totalCount,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBody) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBody) SetHasMore(v string) *QueryReceiptsBaseInfoResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBody) SetList(v []*QueryReceiptsBaseInfoResponseBodyList) *QueryReceiptsBaseInfoResponseBody {
	s.List = v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBody) SetTotalCount(v int64) *QueryReceiptsBaseInfoResponseBody {
	s.TotalCount = &v
	return s
}

type QueryReceiptsBaseInfoResponseBodyList struct {
	// example:
	//
	// abc
	AccountantBookId *string `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	// example:
	//
	// 5000
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// 1714973165000
	ApprovedAt *string `json:"approvedAt,omitempty" xml:"approvedAt,omitempty"`
	// example:
	//
	// 123
	BusinessId *string `json:"businessId,omitempty" xml:"businessId,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 1714973165000
	CreateTime *string                                        `json:"createTime,omitempty" xml:"createTime,omitempty"`
	Creator    *QueryReceiptsBaseInfoResponseBodyListCreator  `json:"creator,omitempty" xml:"creator,omitempty" type:"Struct"`
	Customer   *QueryReceiptsBaseInfoResponseBodyListCustomer `json:"customer,omitempty" xml:"customer,omitempty" type:"Struct"`
	// example:
	//
	// https://abc.com
	InstanceJumpUrl *string `json:"instanceJumpUrl,omitempty" xml:"instanceJumpUrl,omitempty"`
	// example:
	//
	// EM-xxxxx
	ModelId   *string                                         `json:"modelId,omitempty" xml:"modelId,omitempty"`
	Principal *QueryReceiptsBaseInfoResponseBodyListPrincipal `json:"principal,omitempty" xml:"principal,omitempty" type:"Struct"`
	Project   *QueryReceiptsBaseInfoResponseBodyListProject   `json:"project,omitempty" xml:"project,omitempty" type:"Struct"`
	// example:
	//
	// abc
	ReceiptId *string `json:"receiptId,omitempty" xml:"receiptId,omitempty"`
	// example:
	//
	// 16000000
	RecordTime *string `json:"recordTime,omitempty" xml:"recordTime,omitempty"`
	// example:
	//
	// 备注信息
	Remark *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// approval
	Source *string `json:"source,omitempty" xml:"source,omitempty"`
	// example:
	//
	// agree
	Status   *string                                        `json:"status,omitempty" xml:"status,omitempty"`
	Supplier *QueryReceiptsBaseInfoResponseBodyListSupplier `json:"supplier,omitempty" xml:"supplier,omitempty" type:"Struct"`
	// example:
	//
	// 张三提交的开票申请单
	Title         *string `json:"title,omitempty" xml:"title,omitempty"`
	VoucherStatus *string `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetAccountantBookId(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.AccountantBookId = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetAmount(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.Amount = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetApprovedAt(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.ApprovedAt = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetBusinessId(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.BusinessId = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetCompanyCode(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.CompanyCode = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetCreateTime(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetCreator(v *QueryReceiptsBaseInfoResponseBodyListCreator) *QueryReceiptsBaseInfoResponseBodyList {
	s.Creator = v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetCustomer(v *QueryReceiptsBaseInfoResponseBodyListCustomer) *QueryReceiptsBaseInfoResponseBodyList {
	s.Customer = v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetInstanceJumpUrl(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.InstanceJumpUrl = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetModelId(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.ModelId = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetPrincipal(v *QueryReceiptsBaseInfoResponseBodyListPrincipal) *QueryReceiptsBaseInfoResponseBodyList {
	s.Principal = v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetProject(v *QueryReceiptsBaseInfoResponseBodyListProject) *QueryReceiptsBaseInfoResponseBodyList {
	s.Project = v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetReceiptId(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.ReceiptId = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetRecordTime(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.RecordTime = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetRemark(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.Remark = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetSource(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.Source = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetStatus(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.Status = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetSupplier(v *QueryReceiptsBaseInfoResponseBodyListSupplier) *QueryReceiptsBaseInfoResponseBodyList {
	s.Supplier = v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetTitle(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.Title = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyList) SetVoucherStatus(v string) *QueryReceiptsBaseInfoResponseBodyList {
	s.VoucherStatus = &v
	return s
}

type QueryReceiptsBaseInfoResponseBodyListCreator struct {
	// example:
	//
	// https://xxxx
	AvatarUrl *string `json:"avatarUrl,omitempty" xml:"avatarUrl,omitempty"`
	// example:
	//
	// 测试名字
	Nick *string `json:"nick,omitempty" xml:"nick,omitempty"`
	// example:
	//
	// 1231
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBodyListCreator) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBodyListCreator) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBodyListCreator) SetAvatarUrl(v string) *QueryReceiptsBaseInfoResponseBodyListCreator {
	s.AvatarUrl = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListCreator) SetNick(v string) *QueryReceiptsBaseInfoResponseBodyListCreator {
	s.Nick = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListCreator) SetUserId(v string) *QueryReceiptsBaseInfoResponseBodyListCreator {
	s.UserId = &v
	return s
}

type QueryReceiptsBaseInfoResponseBodyListCustomer struct {
	// example:
	//
	// CUS_xxxxx
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// 李四
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBodyListCustomer) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBodyListCustomer) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBodyListCustomer) SetCode(v string) *QueryReceiptsBaseInfoResponseBodyListCustomer {
	s.Code = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListCustomer) SetName(v string) *QueryReceiptsBaseInfoResponseBodyListCustomer {
	s.Name = &v
	return s
}

type QueryReceiptsBaseInfoResponseBodyListPrincipal struct {
	AvatarUrl *string `json:"avatarUrl,omitempty" xml:"avatarUrl,omitempty"`
	Nick      *string `json:"nick,omitempty" xml:"nick,omitempty"`
	UserId    *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBodyListPrincipal) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBodyListPrincipal) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBodyListPrincipal) SetAvatarUrl(v string) *QueryReceiptsBaseInfoResponseBodyListPrincipal {
	s.AvatarUrl = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListPrincipal) SetNick(v string) *QueryReceiptsBaseInfoResponseBodyListPrincipal {
	s.Nick = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListPrincipal) SetUserId(v string) *QueryReceiptsBaseInfoResponseBodyListPrincipal {
	s.UserId = &v
	return s
}

type QueryReceiptsBaseInfoResponseBodyListProject struct {
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBodyListProject) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBodyListProject) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBodyListProject) SetCode(v string) *QueryReceiptsBaseInfoResponseBodyListProject {
	s.Code = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListProject) SetName(v string) *QueryReceiptsBaseInfoResponseBodyListProject {
	s.Name = &v
	return s
}

type QueryReceiptsBaseInfoResponseBodyListSupplier struct {
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s QueryReceiptsBaseInfoResponseBodyListSupplier) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponseBodyListSupplier) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponseBodyListSupplier) SetCode(v string) *QueryReceiptsBaseInfoResponseBodyListSupplier {
	s.Code = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponseBodyListSupplier) SetName(v string) *QueryReceiptsBaseInfoResponseBodyListSupplier {
	s.Name = &v
	return s
}

type QueryReceiptsBaseInfoResponse struct {
	Headers    map[string]*string                 `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                             `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryReceiptsBaseInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryReceiptsBaseInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsBaseInfoResponse) GoString() string {
	return s.String()
}

func (s *QueryReceiptsBaseInfoResponse) SetHeaders(v map[string]*string) *QueryReceiptsBaseInfoResponse {
	s.Headers = v
	return s
}

func (s *QueryReceiptsBaseInfoResponse) SetStatusCode(v int32) *QueryReceiptsBaseInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryReceiptsBaseInfoResponse) SetBody(v *QueryReceiptsBaseInfoResponseBody) *QueryReceiptsBaseInfoResponse {
	s.Body = v
	return s
}

type QueryReceiptsByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryReceiptsByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryReceiptsByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryReceiptsByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryReceiptsByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryReceiptsByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryReceiptsByPageRequest struct {
	// example:
	//
	// 1637658261363
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// EM-1017F28E03350B1738B3000X
	ModelId *string `json:"modelId,omitempty" xml:"modelId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1637658261363
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// gmt_create
	TimeFilterField *string `json:"timeFilterField,omitempty" xml:"timeFilterField,omitempty"`
}

func (s QueryReceiptsByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryReceiptsByPageRequest) SetEndTime(v int64) *QueryReceiptsByPageRequest {
	s.EndTime = &v
	return s
}

func (s *QueryReceiptsByPageRequest) SetModelId(v string) *QueryReceiptsByPageRequest {
	s.ModelId = &v
	return s
}

func (s *QueryReceiptsByPageRequest) SetPageNumber(v int64) *QueryReceiptsByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QueryReceiptsByPageRequest) SetPageSize(v int64) *QueryReceiptsByPageRequest {
	s.PageSize = &v
	return s
}

func (s *QueryReceiptsByPageRequest) SetStartTime(v int64) *QueryReceiptsByPageRequest {
	s.StartTime = &v
	return s
}

func (s *QueryReceiptsByPageRequest) SetTimeFilterField(v string) *QueryReceiptsByPageRequest {
	s.TimeFilterField = &v
	return s
}

type QueryReceiptsByPageResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// false
	HasMore *string `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// This parameter is required.
	List []*QueryReceiptsByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QueryReceiptsByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryReceiptsByPageResponseBody) SetHasMore(v string) *QueryReceiptsByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryReceiptsByPageResponseBody) SetList(v []*QueryReceiptsByPageResponseBodyList) *QueryReceiptsByPageResponseBody {
	s.List = v
	return s
}

type QueryReceiptsByPageResponseBodyList struct {
	// This parameter is required.
	//
	// example:
	//
	// 1234
	AppId *string `json:"appId,omitempty" xml:"appId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// {"operatorUserId":"015865244722391178","data":{"amount":{"amountStr":"566"},"code":"d0d54815-32c5-4b18-8391-e79713bba95e","payeeAt":1637251200000,"departmentCode":"-1","project":{"projectCode":"PROJ_101761F3FF6B21362ECA000N","projectName":"客户合作项目"},"principalId":"015865244722391178","enterpriseAccount":{},"approvedAt":1637305373000,"title":"地狱猫提交的智能财务-收款","createAt":1637305353000,"paymentAt":1637251200000,"supplier":{},"operateUserId":"015865244722391178","applicantEmployeeId":"015865244722391178","comment":"ffff","category":{"categoryCode":"INC_1016D6CB3C181E28F0120009","categoryName":"销售收入"},"customer":{"customerCode":"CUS_10178592ECEC2133C893000F","customerName":"钉钉"},"status":"agree"}}
	Data *string `json:"data,omitempty" xml:"data,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// EM-1017F28E03350B1738B3000X
	ModelId *string `json:"modelId,omitempty" xml:"modelId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// approval
	Source *string `json:"source,omitempty" xml:"source,omitempty"`
}

func (s QueryReceiptsByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryReceiptsByPageResponseBodyList) SetAppId(v string) *QueryReceiptsByPageResponseBodyList {
	s.AppId = &v
	return s
}

func (s *QueryReceiptsByPageResponseBodyList) SetData(v string) *QueryReceiptsByPageResponseBodyList {
	s.Data = &v
	return s
}

func (s *QueryReceiptsByPageResponseBodyList) SetModelId(v string) *QueryReceiptsByPageResponseBodyList {
	s.ModelId = &v
	return s
}

func (s *QueryReceiptsByPageResponseBodyList) SetSource(v string) *QueryReceiptsByPageResponseBodyList {
	s.Source = &v
	return s
}

type QueryReceiptsByPageResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryReceiptsByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryReceiptsByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryReceiptsByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryReceiptsByPageResponse) SetHeaders(v map[string]*string) *QueryReceiptsByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryReceiptsByPageResponse) SetStatusCode(v int32) *QueryReceiptsByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryReceiptsByPageResponse) SetBody(v *QueryReceiptsByPageResponseBody) *QueryReceiptsByPageResponse {
	s.Body = v
	return s
}

type QueryRoleMemberByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryRoleMemberByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryRoleMemberByPageHeaders) GoString() string {
	return s.String()
}

func (s *QueryRoleMemberByPageHeaders) SetCommonHeaders(v map[string]*string) *QueryRoleMemberByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryRoleMemberByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QueryRoleMemberByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryRoleMemberByPageRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// 20
	MaxResults *string `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	// example:
	//
	// 0
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// example:
	//
	// financeManager
	RoleCode *string `json:"roleCode,omitempty" xml:"roleCode,omitempty"`
}

func (s QueryRoleMemberByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryRoleMemberByPageRequest) GoString() string {
	return s.String()
}

func (s *QueryRoleMemberByPageRequest) SetCompanyCode(v string) *QueryRoleMemberByPageRequest {
	s.CompanyCode = &v
	return s
}

func (s *QueryRoleMemberByPageRequest) SetMaxResults(v string) *QueryRoleMemberByPageRequest {
	s.MaxResults = &v
	return s
}

func (s *QueryRoleMemberByPageRequest) SetNextToken(v string) *QueryRoleMemberByPageRequest {
	s.NextToken = &v
	return s
}

func (s *QueryRoleMemberByPageRequest) SetRoleCode(v string) *QueryRoleMemberByPageRequest {
	s.RoleCode = &v
	return s
}

type QueryRoleMemberByPageResponseBody struct {
	HasMore    *bool                                    `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	List       []*QueryRoleMemberByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
	NextToken  *int64                                   `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	TotalCount *int64                                   `json:"totalCount,omitempty" xml:"totalCount,omitempty"`
}

func (s QueryRoleMemberByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryRoleMemberByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QueryRoleMemberByPageResponseBody) SetHasMore(v bool) *QueryRoleMemberByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryRoleMemberByPageResponseBody) SetList(v []*QueryRoleMemberByPageResponseBodyList) *QueryRoleMemberByPageResponseBody {
	s.List = v
	return s
}

func (s *QueryRoleMemberByPageResponseBody) SetNextToken(v int64) *QueryRoleMemberByPageResponseBody {
	s.NextToken = &v
	return s
}

func (s *QueryRoleMemberByPageResponseBody) SetTotalCount(v int64) *QueryRoleMemberByPageResponseBody {
	s.TotalCount = &v
	return s
}

type QueryRoleMemberByPageResponseBodyList struct {
	AvatarUrl *string `json:"avatarUrl,omitempty" xml:"avatarUrl,omitempty"`
	Nick      *string `json:"nick,omitempty" xml:"nick,omitempty"`
	UserId    *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryRoleMemberByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QueryRoleMemberByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QueryRoleMemberByPageResponseBodyList) SetAvatarUrl(v string) *QueryRoleMemberByPageResponseBodyList {
	s.AvatarUrl = &v
	return s
}

func (s *QueryRoleMemberByPageResponseBodyList) SetNick(v string) *QueryRoleMemberByPageResponseBodyList {
	s.Nick = &v
	return s
}

func (s *QueryRoleMemberByPageResponseBodyList) SetUserId(v string) *QueryRoleMemberByPageResponseBodyList {
	s.UserId = &v
	return s
}

type QueryRoleMemberByPageResponse struct {
	Headers    map[string]*string                 `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                             `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryRoleMemberByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryRoleMemberByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryRoleMemberByPageResponse) GoString() string {
	return s.String()
}

func (s *QueryRoleMemberByPageResponse) SetHeaders(v map[string]*string) *QueryRoleMemberByPageResponse {
	s.Headers = v
	return s
}

func (s *QueryRoleMemberByPageResponse) SetStatusCode(v int32) *QueryRoleMemberByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryRoleMemberByPageResponse) SetBody(v *QueryRoleMemberByPageResponseBody) *QueryRoleMemberByPageResponse {
	s.Body = v
	return s
}

type QuerySupplierByPageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QuerySupplierByPageHeaders) String() string {
	return tea.Prettify(s)
}

func (s QuerySupplierByPageHeaders) GoString() string {
	return s.String()
}

func (s *QuerySupplierByPageHeaders) SetCommonHeaders(v map[string]*string) *QuerySupplierByPageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QuerySupplierByPageHeaders) SetXAcsDingtalkAccessToken(v string) *QuerySupplierByPageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QuerySupplierByPageRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// 1
	PageNumber *int64 `json:"pageNumber,omitempty" xml:"pageNumber,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 10
	PageSize *int64 `json:"pageSize,omitempty" xml:"pageSize,omitempty"`
}

func (s QuerySupplierByPageRequest) String() string {
	return tea.Prettify(s)
}

func (s QuerySupplierByPageRequest) GoString() string {
	return s.String()
}

func (s *QuerySupplierByPageRequest) SetPageNumber(v int64) *QuerySupplierByPageRequest {
	s.PageNumber = &v
	return s
}

func (s *QuerySupplierByPageRequest) SetPageSize(v int64) *QuerySupplierByPageRequest {
	s.PageSize = &v
	return s
}

type QuerySupplierByPageResponseBody struct {
	// This parameter is required.
	//
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// This parameter is required.
	List []*QuerySupplierByPageResponseBodyList `json:"list,omitempty" xml:"list,omitempty" type:"Repeated"`
}

func (s QuerySupplierByPageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QuerySupplierByPageResponseBody) GoString() string {
	return s.String()
}

func (s *QuerySupplierByPageResponseBody) SetHasMore(v bool) *QuerySupplierByPageResponseBody {
	s.HasMore = &v
	return s
}

func (s *QuerySupplierByPageResponseBody) SetList(v []*QuerySupplierByPageResponseBodyList) *QuerySupplierByPageResponseBody {
	s.List = v
	return s
}

type QuerySupplierByPageResponseBodyList struct {
	// This parameter is required.
	//
	// example:
	//
	// SUP_XXX
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1634786828686
	CreateTime *int64 `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 原材料供应商
	Description *string `json:"description,omitempty" xml:"description,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// XX供应商
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// valid
	Status         *string `json:"status,omitempty" xml:"status,omitempty"`
	UserDefineCode *string `json:"userDefineCode,omitempty" xml:"userDefineCode,omitempty"`
}

func (s QuerySupplierByPageResponseBodyList) String() string {
	return tea.Prettify(s)
}

func (s QuerySupplierByPageResponseBodyList) GoString() string {
	return s.String()
}

func (s *QuerySupplierByPageResponseBodyList) SetCode(v string) *QuerySupplierByPageResponseBodyList {
	s.Code = &v
	return s
}

func (s *QuerySupplierByPageResponseBodyList) SetCreateTime(v int64) *QuerySupplierByPageResponseBodyList {
	s.CreateTime = &v
	return s
}

func (s *QuerySupplierByPageResponseBodyList) SetDescription(v string) *QuerySupplierByPageResponseBodyList {
	s.Description = &v
	return s
}

func (s *QuerySupplierByPageResponseBodyList) SetName(v string) *QuerySupplierByPageResponseBodyList {
	s.Name = &v
	return s
}

func (s *QuerySupplierByPageResponseBodyList) SetStatus(v string) *QuerySupplierByPageResponseBodyList {
	s.Status = &v
	return s
}

func (s *QuerySupplierByPageResponseBodyList) SetUserDefineCode(v string) *QuerySupplierByPageResponseBodyList {
	s.UserDefineCode = &v
	return s
}

type QuerySupplierByPageResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QuerySupplierByPageResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QuerySupplierByPageResponse) String() string {
	return tea.Prettify(s)
}

func (s QuerySupplierByPageResponse) GoString() string {
	return s.String()
}

func (s *QuerySupplierByPageResponse) SetHeaders(v map[string]*string) *QuerySupplierByPageResponse {
	s.Headers = v
	return s
}

func (s *QuerySupplierByPageResponse) SetStatusCode(v int32) *QuerySupplierByPageResponse {
	s.StatusCode = &v
	return s
}

func (s *QuerySupplierByPageResponse) SetBody(v *QuerySupplierByPageResponseBody) *QuerySupplierByPageResponse {
	s.Body = v
	return s
}

type QueryUserRoleListHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryUserRoleListHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryUserRoleListHeaders) GoString() string {
	return s.String()
}

func (s *QueryUserRoleListHeaders) SetCommonHeaders(v map[string]*string) *QueryUserRoleListHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryUserRoleListHeaders) SetXAcsDingtalkAccessToken(v string) *QueryUserRoleListHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryUserRoleListRequest struct {
	// example:
	//
	// 12312231231
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s QueryUserRoleListRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryUserRoleListRequest) GoString() string {
	return s.String()
}

func (s *QueryUserRoleListRequest) SetUserId(v string) *QueryUserRoleListRequest {
	s.UserId = &v
	return s
}

type QueryUserRoleListResponseBody struct {
	FinanceEmpDeptOpenList []*QueryUserRoleListResponseBodyFinanceEmpDeptOpenList `json:"financeEmpDeptOpenList,omitempty" xml:"financeEmpDeptOpenList,omitempty" type:"Repeated"`
	RoleVOList             []*QueryUserRoleListResponseBodyRoleVOList             `json:"roleVOList,omitempty" xml:"roleVOList,omitempty" type:"Repeated"`
}

func (s QueryUserRoleListResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryUserRoleListResponseBody) GoString() string {
	return s.String()
}

func (s *QueryUserRoleListResponseBody) SetFinanceEmpDeptOpenList(v []*QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) *QueryUserRoleListResponseBody {
	s.FinanceEmpDeptOpenList = v
	return s
}

func (s *QueryUserRoleListResponseBody) SetRoleVOList(v []*QueryUserRoleListResponseBodyRoleVOList) *QueryUserRoleListResponseBody {
	s.RoleVOList = v
	return s
}

type QueryUserRoleListResponseBodyFinanceEmpDeptOpenList struct {
	CascadeDeptId *string `json:"cascadeDeptId,omitempty" xml:"cascadeDeptId,omitempty"`
	DeptId        *int64  `json:"deptId,omitempty" xml:"deptId,omitempty"`
	Name          *string `json:"name,omitempty" xml:"name,omitempty"`
	SuperDeptId   *int64  `json:"superDeptId,omitempty" xml:"superDeptId,omitempty"`
}

func (s QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) String() string {
	return tea.Prettify(s)
}

func (s QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) GoString() string {
	return s.String()
}

func (s *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) SetCascadeDeptId(v string) *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList {
	s.CascadeDeptId = &v
	return s
}

func (s *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) SetDeptId(v int64) *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList {
	s.DeptId = &v
	return s
}

func (s *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) SetName(v string) *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList {
	s.Name = &v
	return s
}

func (s *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList) SetSuperDeptId(v int64) *QueryUserRoleListResponseBodyFinanceEmpDeptOpenList {
	s.SuperDeptId = &v
	return s
}

type QueryUserRoleListResponseBodyRoleVOList struct {
	// example:
	//
	// applicationManager
	RoleCode *string `json:"roleCode,omitempty" xml:"roleCode,omitempty"`
	// example:
	//
	// 应用管理员
	RoleName *string `json:"roleName,omitempty" xml:"roleName,omitempty"`
}

func (s QueryUserRoleListResponseBodyRoleVOList) String() string {
	return tea.Prettify(s)
}

func (s QueryUserRoleListResponseBodyRoleVOList) GoString() string {
	return s.String()
}

func (s *QueryUserRoleListResponseBodyRoleVOList) SetRoleCode(v string) *QueryUserRoleListResponseBodyRoleVOList {
	s.RoleCode = &v
	return s
}

func (s *QueryUserRoleListResponseBodyRoleVOList) SetRoleName(v string) *QueryUserRoleListResponseBodyRoleVOList {
	s.RoleName = &v
	return s
}

type QueryUserRoleListResponse struct {
	Headers    map[string]*string             `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                         `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *QueryUserRoleListResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s QueryUserRoleListResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryUserRoleListResponse) GoString() string {
	return s.String()
}

func (s *QueryUserRoleListResponse) SetHeaders(v map[string]*string) *QueryUserRoleListResponse {
	s.Headers = v
	return s
}

func (s *QueryUserRoleListResponse) SetStatusCode(v int32) *QueryUserRoleListResponse {
	s.StatusCode = &v
	return s
}

func (s *QueryUserRoleListResponse) SetBody(v *QueryUserRoleListResponseBody) *QueryUserRoleListResponse {
	s.Body = v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedHeaders) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedHeaders) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedHeaders) SetCommonHeaders(v map[string]*string) *UnbindApplyReceiptAndInvoiceRelatedHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedHeaders) SetXAcsDingtalkAccessToken(v string) *UnbindApplyReceiptAndInvoiceRelatedHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedRequest struct {
	// example:
	//
	// abc
	InstanceId       *string                                                       `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	InvoiceKeyVOList []*UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList `json:"invoiceKeyVOList,omitempty" xml:"invoiceKeyVOList,omitempty" type:"Repeated"`
	Operator         *string                                                       `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedRequest) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedRequest) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedRequest) SetInstanceId(v string) *UnbindApplyReceiptAndInvoiceRelatedRequest {
	s.InstanceId = &v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedRequest) SetInvoiceKeyVOList(v []*UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList) *UnbindApplyReceiptAndInvoiceRelatedRequest {
	s.InvoiceKeyVOList = v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedRequest) SetOperator(v string) *UnbindApplyReceiptAndInvoiceRelatedRequest {
	s.Operator = &v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList struct {
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList) SetInvoiceCode(v string) *UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList) SetInvoiceNo(v string) *UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedResponseBody struct {
	BatchUpdateInvoiceResponse *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse `json:"batchUpdateInvoiceResponse,omitempty" xml:"batchUpdateInvoiceResponse,omitempty" type:"Struct"`
	ErrorInvoiceKeyVOList      []*UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList    `json:"errorInvoiceKeyVOList,omitempty" xml:"errorInvoiceKeyVOList,omitempty" type:"Repeated"`
	Success                    *bool                                                                      `json:"success,omitempty" xml:"success,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBody) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBody) SetBatchUpdateInvoiceResponse(v *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) *UnbindApplyReceiptAndInvoiceRelatedResponseBody {
	s.BatchUpdateInvoiceResponse = v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBody) SetErrorInvoiceKeyVOList(v []*UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) *UnbindApplyReceiptAndInvoiceRelatedResponseBody {
	s.ErrorInvoiceKeyVOList = v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBody) SetSuccess(v bool) *UnbindApplyReceiptAndInvoiceRelatedResponseBody {
	s.Success = &v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse struct {
	InvoiceKeyVOList []*UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList `json:"invoiceKeyVOList,omitempty" xml:"invoiceKeyVOList,omitempty" type:"Repeated"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) SetInvoiceKeyVOList(v []*UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse {
	s.InvoiceKeyVOList = v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList struct {
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) SetInvoiceCode(v string) *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) SetInvoiceNo(v string) *UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList struct {
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo   *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) SetInvoiceCode(v string) *UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) SetInvoiceNo(v string) *UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UnbindApplyReceiptAndInvoiceRelatedResponse struct {
	Headers    map[string]*string                               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UnbindApplyReceiptAndInvoiceRelatedResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponse) String() string {
	return tea.Prettify(s)
}

func (s UnbindApplyReceiptAndInvoiceRelatedResponse) GoString() string {
	return s.String()
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponse) SetHeaders(v map[string]*string) *UnbindApplyReceiptAndInvoiceRelatedResponse {
	s.Headers = v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponse) SetStatusCode(v int32) *UnbindApplyReceiptAndInvoiceRelatedResponse {
	s.StatusCode = &v
	return s
}

func (s *UnbindApplyReceiptAndInvoiceRelatedResponse) SetBody(v *UnbindApplyReceiptAndInvoiceRelatedResponseBody) *UnbindApplyReceiptAndInvoiceRelatedResponse {
	s.Body = v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedHeaders) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedHeaders) SetCommonHeaders(v map[string]*string) *UpdateApplyReceiptAndInvoiceRelatedHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateApplyReceiptAndInvoiceRelatedHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedRequest struct {
	GeneralInvoiceVOList []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList `json:"generalInvoiceVOList,omitempty" xml:"generalInvoiceVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	Operator   *string `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequest) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequest) SetGeneralInvoiceVOList(v []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) *UpdateApplyReceiptAndInvoiceRelatedRequest {
	s.GeneralInvoiceVOList = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequest) SetInstanceId(v string) *UpdateApplyReceiptAndInvoiceRelatedRequest {
	s.InstanceId = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequest) SetOperator(v string) *UpdateApplyReceiptAndInvoiceRelatedRequest {
	s.Operator = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList struct {
	// example:
	//
	// abc
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// 100
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// 120
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 1111
	CheckCode *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	// example:
	//
	// 2010-12-12
	CheckTime *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	// example:
	//
	// 张三
	DrawerName *string `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	// example:
	//
	// 2022-12-10
	DrewDate *string `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	// example:
	//
	// abc
	ElectronicUrl *string `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	// example:
	//
	// INPUT_VAT
	FinanceType *string `json:"financeType,omitempty" xml:"financeType,omitempty"`
	// example:
	//
	// RED
	FundType                   *string                                                                                     `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// abc
	InvoiceStatus *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	// example:
	//
	// INTPUT_VAT
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// 1111
	MachineCode *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	// example:
	//
	// abc
	OilFlag *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	// example:
	//
	// abc
	Payee *string `json:"payee,omitempty" xml:"payee,omitempty"`
	// example:
	//
	// abc
	ProcessInstCode *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	// example:
	//
	// abc
	ProcessInstType *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress     *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	PurchaserBankAccount *string `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	// example:
	//
	// 建行
	PurchaserBankNameAccount *string `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	// example:
	//
	// 张三
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 155655
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 1333333333
	PurchaserTel  *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	ReceiverEmail *string `json:"receiverEmail,omitempty" xml:"receiverEmail,omitempty"`
	ReceiverName  *string `json:"receiverName,omitempty" xml:"receiverName,omitempty"`
	ReceiverTel   *string `json:"receiverTel,omitempty" xml:"receiverTel,omitempty"`
	// example:
	//
	// abc
	Remark                         *string                                                                                         `json:"remark,omitempty" xml:"remark,omitempty"`
	SecondHandCarInvoiceDetailList []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	// example:
	//
	// 8852
	SellerAddress     *string `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	SellerBankAccount *string `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	// example:
	//
	// 招商银行
	SellerBankNameAccount *string `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	// example:
	//
	// 李四
	SellerName *string `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	// example:
	//
	// 2202
	SellerTaxNo *string `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	// example:
	//
	// 13355222222
	SellerTel *string `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	// example:
	//
	// abc
	SupplySign *string `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	// example:
	//
	// 20
	TaxAmount                   *string                                                                                      `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	UsedVehicleSaleDetailVOList []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	// example:
	//
	// abc
	VoucherCode *string `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	// example:
	//
	// abc
	VoucherStatus *string `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetAccountPeriod(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetAmount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.Amount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetAmountWithTax(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.AmountWithTax = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetCheckCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.CheckCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetCheckTime(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.CheckTime = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetDrawerName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.DrawerName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetDrewDate(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.DrewDate = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetElectronicUrl(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ElectronicUrl = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetFinanceType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.FinanceType = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetFundType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.FundType = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetGeneralInvoiceDetailVOList(v []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetImageUrl(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ImageUrl = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetInvoiceCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetInvoiceNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetInvoiceStatus(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.InvoiceStatus = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetInvoiceType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.InvoiceType = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetMachineCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.MachineCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetOilFlag(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.OilFlag = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPayee(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.Payee = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetProcessInstCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ProcessInstCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetProcessInstType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ProcessInstType = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPurchaserAddress(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.PurchaserAddress = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPurchaserBankAccount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.PurchaserBankAccount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPurchaserBankNameAccount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPurchaserName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.PurchaserName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPurchaserTaxNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetPurchaserTel(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.PurchaserTel = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetReceiverEmail(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ReceiverEmail = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetReceiverName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ReceiverName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetReceiverTel(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.ReceiverTel = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetRemark(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.Remark = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSecondHandCarInvoiceDetailList(v []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSellerAddress(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SellerAddress = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSellerBankAccount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SellerBankAccount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSellerBankNameAccount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SellerBankNameAccount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSellerName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SellerName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSellerTaxNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SellerTaxNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSellerTel(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SellerTel = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetSupplySign(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.SupplySign = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetTaxAmount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetUsedVehicleSaleDetailVOList(v []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetVehicleSaleDetailVOList(v []*UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetVerifyStatus(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.VerifyStatus = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetVoucherCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.VoucherCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList) SetVoucherStatus(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList {
	s.VoucherStatus = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	TaxPreType    *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate       *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit          *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice     *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetAmount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetGoodsName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetQuantity(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRevenueCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRowNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetSpecification(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxAmount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPre(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPreType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxRate(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnit(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnitPrice(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetAmount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetCardNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetEndDate(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetGoodsName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRowNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetStartDate(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxRate(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetVehicleType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCarModel(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCardNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetRegistration(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	InspectionListNo    *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers       *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace         *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo    *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName    *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo      *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate             *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage             *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo           *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType         *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetBrand(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetCertificateNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetEngineNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetIdCardNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetImportCertificateNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetInspectionListNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetMaxPassengers(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetOriginPlace(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxRate(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTonnage(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedResponseBody struct {
	BatchUpdateInvoiceResponse *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse `json:"batchUpdateInvoiceResponse,omitempty" xml:"batchUpdateInvoiceResponse,omitempty" type:"Struct"`
	ErrorInvoiceKeyVOList      []*UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList    `json:"errorInvoiceKeyVOList,omitempty" xml:"errorInvoiceKeyVOList,omitempty" type:"Repeated"`
	Success                    *bool                                                                      `json:"success,omitempty" xml:"success,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBody) SetBatchUpdateInvoiceResponse(v *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) *UpdateApplyReceiptAndInvoiceRelatedResponseBody {
	s.BatchUpdateInvoiceResponse = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBody) SetErrorInvoiceKeyVOList(v []*UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) *UpdateApplyReceiptAndInvoiceRelatedResponseBody {
	s.ErrorInvoiceKeyVOList = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBody) SetSuccess(v bool) *UpdateApplyReceiptAndInvoiceRelatedResponseBody {
	s.Success = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse struct {
	InvoiceKeyVOList []*UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList `json:"invoiceKeyVOList,omitempty" xml:"invoiceKeyVOList,omitempty" type:"Repeated"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse) SetInvoiceKeyVOList(v []*UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse {
	s.InvoiceKeyVOList = v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList struct {
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) SetInvoiceCode(v string) *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList) SetInvoiceNo(v string) *UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList struct {
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo   *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) SetInvoiceCode(v string) *UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList) SetInvoiceNo(v string) *UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UpdateApplyReceiptAndInvoiceRelatedResponse struct {
	Headers    map[string]*string                               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateApplyReceiptAndInvoiceRelatedResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateApplyReceiptAndInvoiceRelatedResponse) GoString() string {
	return s.String()
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponse) SetHeaders(v map[string]*string) *UpdateApplyReceiptAndInvoiceRelatedResponse {
	s.Headers = v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponse) SetStatusCode(v int32) *UpdateApplyReceiptAndInvoiceRelatedResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateApplyReceiptAndInvoiceRelatedResponse) SetBody(v *UpdateApplyReceiptAndInvoiceRelatedResponseBody) *UpdateApplyReceiptAndInvoiceRelatedResponse {
	s.Body = v
	return s
}

type UpdateDigitalInvoiceOrgInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateDigitalInvoiceOrgInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateDigitalInvoiceOrgInfoHeaders) GoString() string {
	return s.String()
}

func (s *UpdateDigitalInvoiceOrgInfoHeaders) SetCommonHeaders(v map[string]*string) *UpdateDigitalInvoiceOrgInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateDigitalInvoiceOrgInfoHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateDigitalInvoiceOrgInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateDigitalInvoiceOrgInfoRequest struct {
	DigitalInvoiceType []*string `json:"digitalInvoiceType,omitempty" xml:"digitalInvoiceType,omitempty" type:"Repeated"`
	IsDigitalOrg       *bool     `json:"isDigitalOrg,omitempty" xml:"isDigitalOrg,omitempty"`
	// example:
	//
	// zhejiang
	Location *string `json:"location,omitempty" xml:"location,omitempty"`
	// example:
	//
	// 1234567
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s UpdateDigitalInvoiceOrgInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateDigitalInvoiceOrgInfoRequest) GoString() string {
	return s.String()
}

func (s *UpdateDigitalInvoiceOrgInfoRequest) SetDigitalInvoiceType(v []*string) *UpdateDigitalInvoiceOrgInfoRequest {
	s.DigitalInvoiceType = v
	return s
}

func (s *UpdateDigitalInvoiceOrgInfoRequest) SetIsDigitalOrg(v bool) *UpdateDigitalInvoiceOrgInfoRequest {
	s.IsDigitalOrg = &v
	return s
}

func (s *UpdateDigitalInvoiceOrgInfoRequest) SetLocation(v string) *UpdateDigitalInvoiceOrgInfoRequest {
	s.Location = &v
	return s
}

func (s *UpdateDigitalInvoiceOrgInfoRequest) SetOperator(v string) *UpdateDigitalInvoiceOrgInfoRequest {
	s.Operator = &v
	return s
}

type UpdateDigitalInvoiceOrgInfoResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateDigitalInvoiceOrgInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateDigitalInvoiceOrgInfoResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateDigitalInvoiceOrgInfoResponseBody) SetResult(v bool) *UpdateDigitalInvoiceOrgInfoResponseBody {
	s.Result = &v
	return s
}

type UpdateDigitalInvoiceOrgInfoResponse struct {
	Headers    map[string]*string                       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateDigitalInvoiceOrgInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateDigitalInvoiceOrgInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateDigitalInvoiceOrgInfoResponse) GoString() string {
	return s.String()
}

func (s *UpdateDigitalInvoiceOrgInfoResponse) SetHeaders(v map[string]*string) *UpdateDigitalInvoiceOrgInfoResponse {
	s.Headers = v
	return s
}

func (s *UpdateDigitalInvoiceOrgInfoResponse) SetStatusCode(v int32) *UpdateDigitalInvoiceOrgInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateDigitalInvoiceOrgInfoResponse) SetBody(v *UpdateDigitalInvoiceOrgInfoResponseBody) *UpdateDigitalInvoiceOrgInfoResponse {
	s.Body = v
	return s
}

type UpdateFinanceCompanyInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateFinanceCompanyInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceCompanyInfoHeaders) GoString() string {
	return s.String()
}

func (s *UpdateFinanceCompanyInfoHeaders) SetCommonHeaders(v map[string]*string) *UpdateFinanceCompanyInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateFinanceCompanyInfoHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateFinanceCompanyInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateFinanceCompanyInfoRequest struct {
	CompanyName         *string `json:"companyName,omitempty" xml:"companyName,omitempty"`
	TaxNature           *string `json:"taxNature,omitempty" xml:"taxNature,omitempty"`
	TaxNo               *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
	TaxOrInvoiceHasInit *bool   `json:"taxOrInvoiceHasInit,omitempty" xml:"taxOrInvoiceHasInit,omitempty"`
	UserId              *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s UpdateFinanceCompanyInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceCompanyInfoRequest) GoString() string {
	return s.String()
}

func (s *UpdateFinanceCompanyInfoRequest) SetCompanyName(v string) *UpdateFinanceCompanyInfoRequest {
	s.CompanyName = &v
	return s
}

func (s *UpdateFinanceCompanyInfoRequest) SetTaxNature(v string) *UpdateFinanceCompanyInfoRequest {
	s.TaxNature = &v
	return s
}

func (s *UpdateFinanceCompanyInfoRequest) SetTaxNo(v string) *UpdateFinanceCompanyInfoRequest {
	s.TaxNo = &v
	return s
}

func (s *UpdateFinanceCompanyInfoRequest) SetTaxOrInvoiceHasInit(v bool) *UpdateFinanceCompanyInfoRequest {
	s.TaxOrInvoiceHasInit = &v
	return s
}

func (s *UpdateFinanceCompanyInfoRequest) SetUserId(v string) *UpdateFinanceCompanyInfoRequest {
	s.UserId = &v
	return s
}

type UpdateFinanceCompanyInfoResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateFinanceCompanyInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceCompanyInfoResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateFinanceCompanyInfoResponseBody) SetResult(v bool) *UpdateFinanceCompanyInfoResponseBody {
	s.Result = &v
	return s
}

type UpdateFinanceCompanyInfoResponse struct {
	Headers    map[string]*string                    `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateFinanceCompanyInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateFinanceCompanyInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceCompanyInfoResponse) GoString() string {
	return s.String()
}

func (s *UpdateFinanceCompanyInfoResponse) SetHeaders(v map[string]*string) *UpdateFinanceCompanyInfoResponse {
	s.Headers = v
	return s
}

func (s *UpdateFinanceCompanyInfoResponse) SetStatusCode(v int32) *UpdateFinanceCompanyInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateFinanceCompanyInfoResponse) SetBody(v *UpdateFinanceCompanyInfoResponseBody) *UpdateFinanceCompanyInfoResponse {
	s.Body = v
	return s
}

type UpdateFinanceMultiCompanyInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateFinanceMultiCompanyInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceMultiCompanyInfoHeaders) GoString() string {
	return s.String()
}

func (s *UpdateFinanceMultiCompanyInfoHeaders) SetCommonHeaders(v map[string]*string) *UpdateFinanceMultiCompanyInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateFinanceMultiCompanyInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateFinanceMultiCompanyInfoRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 钉钉
	CompanyName *string `json:"companyName,omitempty" xml:"companyName,omitempty"`
	// example:
	//
	// generalTaxpayer
	TaxNature *string `json:"taxNature,omitempty" xml:"taxNature,omitempty"`
	// example:
	//
	// 123456789012345
	TaxNo               *string `json:"taxNo,omitempty" xml:"taxNo,omitempty"`
	TaxOrInvoiceHasInit *bool   `json:"taxOrInvoiceHasInit,omitempty" xml:"taxOrInvoiceHasInit,omitempty"`
	// example:
	//
	// 123
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s UpdateFinanceMultiCompanyInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceMultiCompanyInfoRequest) GoString() string {
	return s.String()
}

func (s *UpdateFinanceMultiCompanyInfoRequest) SetCompanyCode(v string) *UpdateFinanceMultiCompanyInfoRequest {
	s.CompanyCode = &v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoRequest) SetCompanyName(v string) *UpdateFinanceMultiCompanyInfoRequest {
	s.CompanyName = &v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoRequest) SetTaxNature(v string) *UpdateFinanceMultiCompanyInfoRequest {
	s.TaxNature = &v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoRequest) SetTaxNo(v string) *UpdateFinanceMultiCompanyInfoRequest {
	s.TaxNo = &v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoRequest) SetTaxOrInvoiceHasInit(v bool) *UpdateFinanceMultiCompanyInfoRequest {
	s.TaxOrInvoiceHasInit = &v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoRequest) SetUserId(v string) *UpdateFinanceMultiCompanyInfoRequest {
	s.UserId = &v
	return s
}

type UpdateFinanceMultiCompanyInfoResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateFinanceMultiCompanyInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceMultiCompanyInfoResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateFinanceMultiCompanyInfoResponseBody) SetResult(v bool) *UpdateFinanceMultiCompanyInfoResponseBody {
	s.Result = &v
	return s
}

type UpdateFinanceMultiCompanyInfoResponse struct {
	Headers    map[string]*string                         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateFinanceMultiCompanyInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateFinanceMultiCompanyInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateFinanceMultiCompanyInfoResponse) GoString() string {
	return s.String()
}

func (s *UpdateFinanceMultiCompanyInfoResponse) SetHeaders(v map[string]*string) *UpdateFinanceMultiCompanyInfoResponse {
	s.Headers = v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoResponse) SetStatusCode(v int32) *UpdateFinanceMultiCompanyInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateFinanceMultiCompanyInfoResponse) SetBody(v *UpdateFinanceMultiCompanyInfoResponseBody) *UpdateFinanceMultiCompanyInfoResponse {
	s.Body = v
	return s
}

type UpdateInvoiceAbandonStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceAbandonStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceAbandonStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceAbandonStatusHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceAbandonStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceAbandonStatusRequest struct {
	BlueGeneralInvoiceVO *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO `json:"blueGeneralInvoiceVO,omitempty" xml:"blueGeneralInvoiceVO,omitempty" type:"Struct"`
	BlueInvoiceCode      *string                                                `json:"blueInvoiceCode,omitempty" xml:"blueInvoiceCode,omitempty"`
	BlueInvoiceNo        *string                                                `json:"blueInvoiceNo,omitempty" xml:"blueInvoiceNo,omitempty"`
	BlueInvoiceStatus    *string                                                `json:"blueInvoiceStatus,omitempty" xml:"blueInvoiceStatus,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// abc
	Operator            *string                                               `json:"operator,omitempty" xml:"operator,omitempty"`
	RedGeneralInvoiceVO *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO `json:"redGeneralInvoiceVO,omitempty" xml:"redGeneralInvoiceVO,omitempty" type:"Struct"`
	RedInvoiceCode      *string                                               `json:"redInvoiceCode,omitempty" xml:"redInvoiceCode,omitempty"`
	// example:
	//
	// abc
	RedInvoiceNo *string `json:"redInvoiceNo,omitempty" xml:"redInvoiceNo,omitempty"`
	// example:
	//
	// abc
	RedInvoiceStatus *string `json:"redInvoiceStatus,omitempty" xml:"redInvoiceStatus,omitempty"`
	// example:
	//
	// abc
	TargetInvoice *string `json:"targetInvoice,omitempty" xml:"targetInvoice,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequest) SetBlueGeneralInvoiceVO(v *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) *UpdateInvoiceAbandonStatusRequest {
	s.BlueGeneralInvoiceVO = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetBlueInvoiceCode(v string) *UpdateInvoiceAbandonStatusRequest {
	s.BlueInvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetBlueInvoiceNo(v string) *UpdateInvoiceAbandonStatusRequest {
	s.BlueInvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetBlueInvoiceStatus(v string) *UpdateInvoiceAbandonStatusRequest {
	s.BlueInvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetCompanyCode(v string) *UpdateInvoiceAbandonStatusRequest {
	s.CompanyCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetOperator(v string) *UpdateInvoiceAbandonStatusRequest {
	s.Operator = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetRedGeneralInvoiceVO(v *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) *UpdateInvoiceAbandonStatusRequest {
	s.RedGeneralInvoiceVO = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetRedInvoiceCode(v string) *UpdateInvoiceAbandonStatusRequest {
	s.RedInvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetRedInvoiceNo(v string) *UpdateInvoiceAbandonStatusRequest {
	s.RedInvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetRedInvoiceStatus(v string) *UpdateInvoiceAbandonStatusRequest {
	s.RedInvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequest) SetTargetInvoice(v string) *UpdateInvoiceAbandonStatusRequest {
	s.TargetInvoice = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO struct {
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	CheckCode     *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	CheckTime     *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	// example:
	//
	// 张三
	DrawerName                 *string                                                                            `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	DrewDate                   *string                                                                            `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	ElectronicUrl              *string                                                                            `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	FinanceType                *string                                                                            `json:"financeType,omitempty" xml:"financeType,omitempty"`
	FundType                   *string                                                                            `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl         *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	InvoiceCode      *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo        *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	InvoiceStatus    *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	InvoiceType      *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	MachineCode      *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	OilFlag          *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	Payee            *string `json:"payee,omitempty" xml:"payee,omitempty"`
	ProcessInstCode  *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	ProcessInstType  *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// 111
	PurchaserBankAccount *string `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	// example:
	//
	// 111
	PurchaserBankNameAccount       *string                                                                                `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	PurchaserName                  *string                                                                                `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	PurchaserTaxNo                 *string                                                                                `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	PurchaserTel                   *string                                                                                `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	Remark                         *string                                                                                `json:"remark,omitempty" xml:"remark,omitempty"`
	SecondHandCarInvoiceDetailList []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	SellerAddress                  *string                                                                                `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	// example:
	//
	// 111
	SellerBankAccount           *string                                                                             `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	SellerBankNameAccount       *string                                                                             `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	SellerName                  *string                                                                             `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	SellerTaxNo                 *string                                                                             `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	SellerTel                   *string                                                                             `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	SupplySign                  *string                                                                             `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	TaxAmount                   *string                                                                             `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	UsedVehicleSaleDetailVOList []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VerifyStatus                *string                                                                             `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	VoucherCode                 *string                                                                             `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	VoucherStatus               *string                                                                             `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetAccountPeriod(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetAmount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetAmountWithTax(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.AmountWithTax = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetCheckCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.CheckCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetCheckTime(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.CheckTime = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetDrawerName(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.DrawerName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetDrewDate(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.DrewDate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetElectronicUrl(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.ElectronicUrl = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetFinanceType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.FinanceType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetFundType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.FundType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetGeneralInvoiceDetailVOList(v []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetImageUrl(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.ImageUrl = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetInvoiceCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetInvoiceNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetInvoiceStatus(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.InvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetInvoiceType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.InvoiceType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetMachineCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.MachineCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetOilFlag(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.OilFlag = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPayee(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.Payee = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetProcessInstCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.ProcessInstCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetProcessInstType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.ProcessInstType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPurchaserAddress(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.PurchaserAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPurchaserBankAccount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.PurchaserBankAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPurchaserBankNameAccount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPurchaserName(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.PurchaserName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPurchaserTaxNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.PurchaserTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetPurchaserTel(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.PurchaserTel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetRemark(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.Remark = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSecondHandCarInvoiceDetailList(v []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSellerAddress(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SellerAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSellerBankAccount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SellerBankAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSellerBankNameAccount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SellerBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSellerName(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SellerName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSellerTaxNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SellerTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSellerTel(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SellerTel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetSupplySign(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.SupplySign = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetTaxAmount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetUsedVehicleSaleDetailVOList(v []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetVehicleSaleDetailVOList(v []*UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetVerifyStatus(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.VerifyStatus = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetVoucherCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.VoucherCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO) SetVoucherStatus(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO {
	s.VoucherStatus = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	// example:
	//
	// 1
	TaxPreType *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate    *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit       *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice  *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetAmount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetGoodsName(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetQuantity(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetRevenueCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetRowNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetSpecification(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxAmount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxPre(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxPreType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxRate(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetUnit(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList) SetUnitPrice(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetAmount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetCardNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetEndDate(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetGoodsName(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetRowNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetStartDate(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetTaxRate(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetVehicleType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetCarModel(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetCardNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetRegistration(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	// example:
	//
	// 111
	InspectionListNo *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers    *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace      *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo   *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate          *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage          *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo        *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType      *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetBrand(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetCertificateNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetEngineNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetIdCardNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetImportCertificateNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetInspectionListNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetMaxPassengers(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetOriginPlace(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxRate(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetTonnage(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO struct {
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	CheckCode     *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	CheckTime     *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	// example:
	//
	// 张三
	DrawerName                 *string                                                                           `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	DrewDate                   *string                                                                           `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	ElectronicUrl              *string                                                                           `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	FinanceType                *string                                                                           `json:"financeType,omitempty" xml:"financeType,omitempty"`
	FundType                   *string                                                                           `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl         *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	InvoiceCode      *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo        *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	InvoiceStatus    *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	InvoiceType      *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	MachineCode      *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	OilFlag          *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	Payee            *string `json:"payee,omitempty" xml:"payee,omitempty"`
	ProcessInstCode  *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	ProcessInstType  *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	PurchaserAddress *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// aaa
	PurchaserBankAccount           *string                                                                               `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	PurchaserBankNameAccount       *string                                                                               `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	PurchaserName                  *string                                                                               `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	PurchaserTaxNo                 *string                                                                               `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	PurchaserTel                   *string                                                                               `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	Remark                         *string                                                                               `json:"remark,omitempty" xml:"remark,omitempty"`
	SecondHandCarInvoiceDetailList []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	SellerAddress                  *string                                                                               `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	// example:
	//
	// 111
	SellerBankAccount           *string                                                                            `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	SellerBankNameAccount       *string                                                                            `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	SellerName                  *string                                                                            `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	SellerTaxNo                 *string                                                                            `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	SellerTel                   *string                                                                            `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	SupplySign                  *string                                                                            `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	TaxAmount                   *string                                                                            `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	UsedVehicleSaleDetailVOList []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VerifyStatus                *string                                                                            `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	VoucherCode                 *string                                                                            `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	VoucherStatus               *string                                                                            `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetAccountPeriod(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetAmount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetAmountWithTax(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.AmountWithTax = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetCheckCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.CheckCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetCheckTime(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.CheckTime = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetDrawerName(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.DrawerName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetDrewDate(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.DrewDate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetElectronicUrl(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.ElectronicUrl = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetFinanceType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.FinanceType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetFundType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.FundType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetGeneralInvoiceDetailVOList(v []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetImageUrl(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.ImageUrl = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetInvoiceCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetInvoiceNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetInvoiceStatus(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.InvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetInvoiceType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.InvoiceType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetMachineCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.MachineCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetOilFlag(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.OilFlag = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPayee(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.Payee = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetProcessInstCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.ProcessInstCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetProcessInstType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.ProcessInstType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPurchaserAddress(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.PurchaserAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPurchaserBankAccount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.PurchaserBankAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPurchaserBankNameAccount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPurchaserName(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.PurchaserName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPurchaserTaxNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.PurchaserTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetPurchaserTel(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.PurchaserTel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetRemark(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.Remark = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSecondHandCarInvoiceDetailList(v []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSellerAddress(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SellerAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSellerBankAccount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SellerBankAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSellerBankNameAccount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SellerBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSellerName(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SellerName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSellerTaxNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SellerTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSellerTel(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SellerTel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetSupplySign(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.SupplySign = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetTaxAmount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetUsedVehicleSaleDetailVOList(v []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetVehicleSaleDetailVOList(v []*UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetVerifyStatus(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.VerifyStatus = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetVoucherCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.VoucherCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO) SetVoucherStatus(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO {
	s.VoucherStatus = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	// example:
	//
	// 111
	TaxPreType *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate    *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit       *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice  *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetAmount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetGoodsName(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetQuantity(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetRevenueCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetRowNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetSpecification(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxAmount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxPre(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxPreType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxRate(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetUnit(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList) SetUnitPrice(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetAmount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetCardNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetEndDate(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetGoodsName(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetRowNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetStartDate(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetTaxRate(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetVehicleType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetCarModel(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetCardNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetRegistration(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	// example:
	//
	// 111
	InspectionListNo *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers    *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace      *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo   *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate          *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage          *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo        *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType      *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetBrand(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetCertificateNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetEngineNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetIdCardNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetImportCertificateNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetInspectionListNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetMaxPassengers(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetOriginPlace(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxRate(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetTonnage(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAbandonStatusResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateInvoiceAbandonStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusResponseBody) SetResult(v bool) *UpdateInvoiceAbandonStatusResponseBody {
	s.Result = &v
	return s
}

type UpdateInvoiceAbandonStatusResponse struct {
	Headers    map[string]*string                      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceAbandonStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceAbandonStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAbandonStatusResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAbandonStatusResponse) SetHeaders(v map[string]*string) *UpdateInvoiceAbandonStatusResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceAbandonStatusResponse) SetStatusCode(v int32) *UpdateInvoiceAbandonStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceAbandonStatusResponse) SetBody(v *UpdateInvoiceAbandonStatusResponseBody) *UpdateInvoiceAbandonStatusResponse {
	s.Body = v
	return s
}

type UpdateInvoiceAccountPeriodHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceAccountPeriodHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceAccountPeriodHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceAccountPeriodHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceAccountPeriodHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceAccountPeriodRequest struct {
	// example:
	//
	// abc
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// COM_DEFAULT
	CompanyCode          *string                                                  `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	GeneralInvoiceVOList []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList `json:"generalInvoiceVOList,omitempty" xml:"generalInvoiceVOList,omitempty" type:"Repeated"`
	InvoiceKeyVOList     []*UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList     `json:"invoiceKeyVOList,omitempty" xml:"invoiceKeyVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequest) SetAccountPeriod(v string) *UpdateInvoiceAccountPeriodRequest {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequest) SetCompanyCode(v string) *UpdateInvoiceAccountPeriodRequest {
	s.CompanyCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequest) SetGeneralInvoiceVOList(v []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) *UpdateInvoiceAccountPeriodRequest {
	s.GeneralInvoiceVOList = v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequest) SetInvoiceKeyVOList(v []*UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList) *UpdateInvoiceAccountPeriodRequest {
	s.InvoiceKeyVOList = v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequest) SetOperator(v string) *UpdateInvoiceAccountPeriodRequest {
	s.Operator = &v
	return s
}

type UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList struct {
	// example:
	//
	// abc
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// 100
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// 120
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 1111
	CheckCode *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	// example:
	//
	// 2010-12-12
	CheckTime *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	// example:
	//
	// 张三
	DrawerName *string `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	// example:
	//
	// 2022-12-10
	DrewDate *string `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	// example:
	//
	// abc
	ElectronicUrl *string `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	// example:
	//
	// INPUT_VAT
	FinanceType *string `json:"financeType,omitempty" xml:"financeType,omitempty"`
	// example:
	//
	// RED
	FundType                   *string                                                                            `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// abc
	InvoiceStatus *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	// example:
	//
	// INTPUT_VAT
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// 1111
	MachineCode *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	// example:
	//
	// abc
	OilFlag *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	// example:
	//
	// abc
	Payee *string `json:"payee,omitempty" xml:"payee,omitempty"`
	// example:
	//
	// abc
	ProcessInstCode *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	// example:
	//
	// abc
	ProcessInstType *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress     *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	PurchaserBankAccount *string `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	// example:
	//
	// 建行
	PurchaserBankNameAccount *string `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	// example:
	//
	// 张三
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 155655
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 1333333333
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	// example:
	//
	// abc
	Remark                         *string                                                                                `json:"remark,omitempty" xml:"remark,omitempty"`
	SecondHandCarInvoiceDetailList []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	// example:
	//
	// 8852
	SellerAddress     *string `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	SellerBankAccount *string `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	// example:
	//
	// 招商银行
	SellerBankNameAccount *string `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	// example:
	//
	// 李四
	SellerName *string `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	// example:
	//
	// 2202
	SellerTaxNo *string `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	// example:
	//
	// 13355222222
	SellerTel *string `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	// example:
	//
	// abc
	SupplySign *string `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	// example:
	//
	// 20
	TaxAmount                   *string                                                                             `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	UsedVehicleSaleDetailVOList []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	// example:
	//
	// abc
	VoucherCode *string `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	// example:
	//
	// abc
	VoucherStatus *string `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetAccountPeriod(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetAmount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetAmountWithTax(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.AmountWithTax = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetCheckCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.CheckCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetCheckTime(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.CheckTime = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetDrawerName(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.DrawerName = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetDrewDate(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.DrewDate = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetElectronicUrl(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.ElectronicUrl = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetFinanceType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.FinanceType = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetFundType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.FundType = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetGeneralInvoiceDetailVOList(v []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetImageUrl(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.ImageUrl = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetInvoiceCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetInvoiceNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetInvoiceStatus(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.InvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetInvoiceType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.InvoiceType = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetMachineCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.MachineCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetOilFlag(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.OilFlag = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPayee(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.Payee = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetProcessInstCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.ProcessInstCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetProcessInstType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.ProcessInstType = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPurchaserAddress(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.PurchaserAddress = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPurchaserBankAccount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.PurchaserBankAccount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPurchaserBankNameAccount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPurchaserName(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.PurchaserName = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPurchaserTaxNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetPurchaserTel(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.PurchaserTel = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetRemark(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.Remark = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSecondHandCarInvoiceDetailList(v []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSellerAddress(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SellerAddress = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSellerBankAccount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SellerBankAccount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSellerBankNameAccount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SellerBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSellerName(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SellerName = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSellerTaxNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SellerTaxNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSellerTel(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SellerTel = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetSupplySign(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.SupplySign = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetTaxAmount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetUsedVehicleSaleDetailVOList(v []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetVehicleSaleDetailVOList(v []*UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetVerifyStatus(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.VerifyStatus = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetVoucherCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.VoucherCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList) SetVoucherStatus(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList {
	s.VoucherStatus = &v
	return s
}

type UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	TaxPreType    *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate       *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit          *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice     *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetAmount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetGoodsName(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetQuantity(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRevenueCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRowNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetSpecification(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxAmount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPre(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPreType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxRate(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnit(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnitPrice(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetAmount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetCardNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetEndDate(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetGoodsName(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRowNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetStartDate(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxRate(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetVehicleType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCarModel(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCardNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetRegistration(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	InspectionListNo    *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers       *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace         *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo    *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName    *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo      *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate             *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage             *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo           *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType         *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetBrand(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetCertificateNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetEngineNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetIdCardNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetImportCertificateNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetInspectionListNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetMaxPassengers(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetOriginPlace(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxRate(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTonnage(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList struct {
	// example:
	//
	// 1001
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 2202
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList) SetInvoiceCode(v string) *UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList) SetInvoiceNo(v string) *UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UpdateInvoiceAccountPeriodResponseBody struct {
	ErrorResult   []*UpdateInvoiceAccountPeriodResponseBodyErrorResult   `json:"errorResult,omitempty" xml:"errorResult,omitempty" type:"Repeated"`
	SuccessResult []*UpdateInvoiceAccountPeriodResponseBodySuccessResult `json:"successResult,omitempty" xml:"successResult,omitempty" type:"Repeated"`
}

func (s UpdateInvoiceAccountPeriodResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodResponseBody) SetErrorResult(v []*UpdateInvoiceAccountPeriodResponseBodyErrorResult) *UpdateInvoiceAccountPeriodResponseBody {
	s.ErrorResult = v
	return s
}

func (s *UpdateInvoiceAccountPeriodResponseBody) SetSuccessResult(v []*UpdateInvoiceAccountPeriodResponseBodySuccessResult) *UpdateInvoiceAccountPeriodResponseBody {
	s.SuccessResult = v
	return s
}

type UpdateInvoiceAccountPeriodResponseBodyErrorResult struct {
	// example:
	//
	// abc
	ErrorKey *string `json:"errorKey,omitempty" xml:"errorKey,omitempty"`
	// example:
	//
	// abc
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
}

func (s UpdateInvoiceAccountPeriodResponseBodyErrorResult) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodResponseBodyErrorResult) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodResponseBodyErrorResult) SetErrorKey(v string) *UpdateInvoiceAccountPeriodResponseBodyErrorResult {
	s.ErrorKey = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodResponseBodyErrorResult) SetErrorMsg(v string) *UpdateInvoiceAccountPeriodResponseBodyErrorResult {
	s.ErrorMsg = &v
	return s
}

type UpdateInvoiceAccountPeriodResponseBodySuccessResult struct {
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo   *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateInvoiceAccountPeriodResponseBodySuccessResult) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodResponseBodySuccessResult) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodResponseBodySuccessResult) SetInvoiceCode(v string) *UpdateInvoiceAccountPeriodResponseBodySuccessResult {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodResponseBodySuccessResult) SetInvoiceNo(v string) *UpdateInvoiceAccountPeriodResponseBodySuccessResult {
	s.InvoiceNo = &v
	return s
}

type UpdateInvoiceAccountPeriodResponse struct {
	Headers    map[string]*string                      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceAccountPeriodResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceAccountPeriodResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountPeriodResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountPeriodResponse) SetHeaders(v map[string]*string) *UpdateInvoiceAccountPeriodResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceAccountPeriodResponse) SetStatusCode(v int32) *UpdateInvoiceAccountPeriodResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceAccountPeriodResponse) SetBody(v *UpdateInvoiceAccountPeriodResponseBody) *UpdateInvoiceAccountPeriodResponse {
	s.Body = v
	return s
}

type UpdateInvoiceAccountingPeriodDateHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceAccountingPeriodDateHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceAccountingPeriodDateHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceAccountingPeriodDateHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceAccountingPeriodDateRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode              *string                                                             `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	InvoiceFinanceInfoVOList []*UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList `json:"invoiceFinanceInfoVOList,omitempty" xml:"invoiceFinanceInfoVOList,omitempty" type:"Repeated"`
	// example:
	//
	// 1234567
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s UpdateInvoiceAccountingPeriodDateRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateRequest) SetCompanyCode(v string) *UpdateInvoiceAccountingPeriodDateRequest {
	s.CompanyCode = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateRequest) SetInvoiceFinanceInfoVOList(v []*UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) *UpdateInvoiceAccountingPeriodDateRequest {
	s.InvoiceFinanceInfoVOList = v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateRequest) SetOperator(v string) *UpdateInvoiceAccountingPeriodDateRequest {
	s.Operator = &v
	return s
}

type UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList struct {
	// example:
	//
	// 2022-02-03
	AccountingPeriodData *string `json:"accountingPeriodData,omitempty" xml:"accountingPeriodData,omitempty"`
	// example:
	//
	// 2202020
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 220200200
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// VAT_DIGITAL_NORMAL
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
}

func (s UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) SetAccountingPeriodData(v string) *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList {
	s.AccountingPeriodData = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) SetInvoiceCode(v string) *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) SetInvoiceNo(v string) *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList) SetInvoiceType(v string) *UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList {
	s.InvoiceType = &v
	return s
}

type UpdateInvoiceAccountingPeriodDateResponseBody struct {
	Result *UpdateInvoiceAccountingPeriodDateResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s UpdateInvoiceAccountingPeriodDateResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBody) SetResult(v *UpdateInvoiceAccountingPeriodDateResponseBodyResult) *UpdateInvoiceAccountingPeriodDateResponseBody {
	s.Result = v
	return s
}

type UpdateInvoiceAccountingPeriodDateResponseBodyResult struct {
	// example:
	//
	// 100
	FailCount    *int64                                                             `json:"failCount,omitempty" xml:"failCount,omitempty"`
	FailInvoices []*UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices `json:"failInvoices,omitempty" xml:"failInvoices,omitempty" type:"Repeated"`
	Success      *bool                                                              `json:"success,omitempty" xml:"success,omitempty"`
}

func (s UpdateInvoiceAccountingPeriodDateResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateResponseBodyResult) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResult) SetFailCount(v int64) *UpdateInvoiceAccountingPeriodDateResponseBodyResult {
	s.FailCount = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResult) SetFailInvoices(v []*UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) *UpdateInvoiceAccountingPeriodDateResponseBodyResult {
	s.FailInvoices = v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResult) SetSuccess(v bool) *UpdateInvoiceAccountingPeriodDateResponseBodyResult {
	s.Success = &v
	return s
}

type UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices struct {
	// example:
	//
	// 50001
	ErrorCode *string `json:"errorCode,omitempty" xml:"errorCode,omitempty"`
	// example:
	//
	// invoice not exist
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
	// example:
	//
	// 1231231231
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 1231231231
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) SetErrorCode(v string) *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices {
	s.ErrorCode = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) SetErrorMsg(v string) *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices {
	s.ErrorMsg = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) SetInvoiceCode(v string) *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices) SetInvoiceNo(v string) *UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices {
	s.InvoiceNo = &v
	return s
}

type UpdateInvoiceAccountingPeriodDateResponse struct {
	Headers    map[string]*string                             `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                         `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceAccountingPeriodDateResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceAccountingPeriodDateResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingPeriodDateResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingPeriodDateResponse) SetHeaders(v map[string]*string) *UpdateInvoiceAccountingPeriodDateResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponse) SetStatusCode(v int32) *UpdateInvoiceAccountingPeriodDateResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceAccountingPeriodDateResponse) SetBody(v *UpdateInvoiceAccountingPeriodDateResponseBody) *UpdateInvoiceAccountingPeriodDateResponse {
	s.Body = v
	return s
}

type UpdateInvoiceAccountingStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceAccountingStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceAccountingStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceAccountingStatusHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceAccountingStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceAccountingStatusRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode              *string                                                         `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	InvoiceFinanceInfoVOList []*UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList `json:"invoiceFinanceInfoVOList,omitempty" xml:"invoiceFinanceInfoVOList,omitempty" type:"Repeated"`
	// example:
	//
	// 1234567
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
}

func (s UpdateInvoiceAccountingStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusRequest) SetCompanyCode(v string) *UpdateInvoiceAccountingStatusRequest {
	s.CompanyCode = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusRequest) SetInvoiceFinanceInfoVOList(v []*UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) *UpdateInvoiceAccountingStatusRequest {
	s.InvoiceFinanceInfoVOList = v
	return s
}

func (s *UpdateInvoiceAccountingStatusRequest) SetOperator(v string) *UpdateInvoiceAccountingStatusRequest {
	s.Operator = &v
	return s
}

type UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList struct {
	// example:
	//
	// in_account
	AccountingStatus *string `json:"accountingStatus,omitempty" xml:"accountingStatus,omitempty"`
	// example:
	//
	// 2022002022
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 20022
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// VAT_DIGITAL_NORMAL
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
}

func (s UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) SetAccountingStatus(v string) *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList {
	s.AccountingStatus = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) SetInvoiceCode(v string) *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) SetInvoiceNo(v string) *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList) SetInvoiceType(v string) *UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList {
	s.InvoiceType = &v
	return s
}

type UpdateInvoiceAccountingStatusResponseBody struct {
	Result *UpdateInvoiceAccountingStatusResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s UpdateInvoiceAccountingStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusResponseBody) SetResult(v *UpdateInvoiceAccountingStatusResponseBodyResult) *UpdateInvoiceAccountingStatusResponseBody {
	s.Result = v
	return s
}

type UpdateInvoiceAccountingStatusResponseBodyResult struct {
	// example:
	//
	// 100
	FailCount    *int64                                                         `json:"failCount,omitempty" xml:"failCount,omitempty"`
	FailInvoices []*UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices `json:"failInvoices,omitempty" xml:"failInvoices,omitempty" type:"Repeated"`
	Success      *bool                                                          `json:"success,omitempty" xml:"success,omitempty"`
}

func (s UpdateInvoiceAccountingStatusResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusResponseBodyResult) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResult) SetFailCount(v int64) *UpdateInvoiceAccountingStatusResponseBodyResult {
	s.FailCount = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResult) SetFailInvoices(v []*UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) *UpdateInvoiceAccountingStatusResponseBodyResult {
	s.FailInvoices = v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResult) SetSuccess(v bool) *UpdateInvoiceAccountingStatusResponseBodyResult {
	s.Success = &v
	return s
}

type UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices struct {
	// example:
	//
	// 50001
	ErrorCode *string `json:"errorCode,omitempty" xml:"errorCode,omitempty"`
	// example:
	//
	// invoice not exist
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
	// example:
	//
	// 123123123
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 123123123123
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) SetErrorCode(v string) *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices {
	s.ErrorCode = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) SetErrorMsg(v string) *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices {
	s.ErrorMsg = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) SetInvoiceCode(v string) *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices) SetInvoiceNo(v string) *UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices {
	s.InvoiceNo = &v
	return s
}

type UpdateInvoiceAccountingStatusResponse struct {
	Headers    map[string]*string                         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceAccountingStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceAccountingStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAccountingStatusResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAccountingStatusResponse) SetHeaders(v map[string]*string) *UpdateInvoiceAccountingStatusResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponse) SetStatusCode(v int32) *UpdateInvoiceAccountingStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceAccountingStatusResponse) SetBody(v *UpdateInvoiceAccountingStatusResponseBody) *UpdateInvoiceAccountingStatusResponse {
	s.Body = v
	return s
}

type UpdateInvoiceAndReceiptRelatedHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceAndReceiptRelatedHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceAndReceiptRelatedHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequest struct {
	GeneralInvoiceVO *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO `json:"generalInvoiceVO,omitempty" xml:"generalInvoiceVO,omitempty" type:"Struct"`
	// example:
	//
	// code
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 155
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// abc
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
	// example:
	//
	// abc
	ReceiptCode *string `json:"receiptCode,omitempty" xml:"receiptCode,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequest) SetGeneralInvoiceVO(v *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) *UpdateInvoiceAndReceiptRelatedRequest {
	s.GeneralInvoiceVO = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequest) SetInvoiceCode(v string) *UpdateInvoiceAndReceiptRelatedRequest {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequest) SetInvoiceNo(v string) *UpdateInvoiceAndReceiptRelatedRequest {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequest) SetOperator(v string) *UpdateInvoiceAndReceiptRelatedRequest {
	s.Operator = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequest) SetReceiptCode(v string) *UpdateInvoiceAndReceiptRelatedRequest {
	s.ReceiptCode = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO struct {
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// ABC
	AgentCode     *string `json:"agentCode,omitempty" xml:"agentCode,omitempty"`
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 123
	CaacDevelopmentFund *string `json:"caacDevelopmentFund,omitempty" xml:"caacDevelopmentFund,omitempty"`
	CheckCode           *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	CheckTime           *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	// example:
	//
	// 杭州
	City *string `json:"city,omitempty" xml:"city,omitempty"`
	// example:
	//
	// 北京
	Destination *string `json:"destination,omitempty" xml:"destination,omitempty"`
	// example:
	//
	// 123KM
	Distance *string `json:"distance,omitempty" xml:"distance,omitempty"`
	// example:
	//
	// 张三
	DrawerName    *string `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	DrewDate      *string `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	ElectronicUrl *string `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	// example:
	//
	// 杭州北
	Entrance *string `json:"entrance,omitempty" xml:"entrance,omitempty"`
	// example:
	//
	// 杭州北
	Exit                   *string                                                                        `json:"exit,omitempty" xml:"exit,omitempty"`
	FinanceType            *string                                                                        `json:"financeType,omitempty" xml:"financeType,omitempty"`
	FlightItineraryDetails []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails `json:"flightItineraryDetails,omitempty" xml:"flightItineraryDetails,omitempty" type:"Repeated"`
	// example:
	//
	// 123
	FuelSurcharge              *string                                                                            `json:"fuelSurcharge,omitempty" xml:"fuelSurcharge,omitempty"`
	FundType                   *string                                                                            `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// 18:00
	GetOffTime *string `json:"getOffTime,omitempty" xml:"getOffTime,omitempty"`
	// example:
	//
	// 17:00
	GetOnTime *string `json:"getOnTime,omitempty" xml:"getOnTime,omitempty"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl      *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	InvoiceCode   *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	InvoiceNo     *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	InvoiceStatus *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	InvoiceType   *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// ABCD
	IssueBy     *string `json:"issueBy,omitempty" xml:"issueBy,omitempty"`
	MachineCode *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	OilFlag     *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	// example:
	//
	// 杭州
	Origin *string `json:"origin,omitempty" xml:"origin,omitempty"`
	// example:
	//
	// 张三
	Passenger *string `json:"passenger,omitempty" xml:"passenger,omitempty"`
	// example:
	//
	// 330781****1234
	PassengerUserId *string `json:"passengerUserId,omitempty" xml:"passengerUserId,omitempty"`
	Payee           *string `json:"payee,omitempty" xml:"payee,omitempty"`
	// example:
	//
	// 123
	PrintSerialNumber *string `json:"printSerialNumber,omitempty" xml:"printSerialNumber,omitempty"`
	ProcessInstCode   *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	ProcessInstType   *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	PurchaserAddress  *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	// example:
	//
	// abc
	PurchaserBankAccount *string `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	// example:
	//
	// abc
	PurchaserBankNameAccount *string `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	PurchaserName            *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	PurchaserTaxNo           *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	PurchaserTel             *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	// example:
	//
	// abc@test.com
	ReceiverEmail *string `json:"receiverEmail,omitempty" xml:"receiverEmail,omitempty"`
	// example:
	//
	// 张三
	ReceiverName *string `json:"receiverName,omitempty" xml:"receiverName,omitempty"`
	// example:
	//
	// 1234567809
	ReceiverTel *string `json:"receiverTel,omitempty" xml:"receiverTel,omitempty"`
	Remark      *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// 2023-09-01
	SeatClass                      *string                                                                                `json:"seatClass,omitempty" xml:"seatClass,omitempty"`
	SecondHandCarInvoiceDetailList []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	SellerAddress                  *string                                                                                `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	// example:
	//
	// abc
	SellerBankAccount *string `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	// example:
	//
	// abc
	SellerBankNameAccount *string `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	SellerName            *string `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	SellerTaxNo           *string `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	SellerTel             *string `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	// example:
	//
	// 杭州
	SerialNo *string `json:"serialNo,omitempty" xml:"serialNo,omitempty"`
	// example:
	//
	// 杭州
	StartTime  *string `json:"startTime,omitempty" xml:"startTime,omitempty"`
	SupplySign *string `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	// example:
	//
	// 123
	Surcharge *string `json:"surcharge,omitempty" xml:"surcharge,omitempty"`
	TaxAmount *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	// example:
	//
	// G1234
	TrainNo *string `json:"trainNo,omitempty" xml:"trainNo,omitempty"`
	// example:
	//
	// 2023-09-01
	TravelDate                  *string                                                                             `json:"travelDate,omitempty" xml:"travelDate,omitempty"`
	UsedVehicleSaleDetailVOList []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VerifyStatus                *string                                                                             `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	VoucherCode                 *string                                                                             `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	VoucherStatus               *string                                                                             `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetAccountPeriod(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetAgentCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.AgentCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetAmount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetAmountWithTax(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.AmountWithTax = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetCaacDevelopmentFund(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.CaacDevelopmentFund = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetCheckCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.CheckCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetCheckTime(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.CheckTime = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetCity(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.City = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetDestination(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Destination = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetDistance(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Distance = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetDrawerName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.DrawerName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetDrewDate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.DrewDate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetElectronicUrl(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ElectronicUrl = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetEntrance(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Entrance = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetExit(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Exit = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetFinanceType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.FinanceType = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetFlightItineraryDetails(v []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.FlightItineraryDetails = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetFuelSurcharge(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.FuelSurcharge = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetFundType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.FundType = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetGeneralInvoiceDetailVOList(v []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetGetOffTime(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.GetOffTime = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetGetOnTime(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.GetOnTime = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetImageUrl(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ImageUrl = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetInvoiceCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetInvoiceNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetInvoiceStatus(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.InvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetInvoiceType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.InvoiceType = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetIssueBy(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.IssueBy = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetMachineCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.MachineCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetOilFlag(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.OilFlag = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetOrigin(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Origin = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPassenger(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Passenger = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPassengerUserId(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PassengerUserId = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPayee(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Payee = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPrintSerialNumber(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PrintSerialNumber = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetProcessInstCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ProcessInstCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetProcessInstType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ProcessInstType = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPurchaserAddress(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PurchaserAddress = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPurchaserBankAccount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PurchaserBankAccount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPurchaserBankNameAccount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPurchaserName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PurchaserName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPurchaserTaxNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PurchaserTaxNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetPurchaserTel(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.PurchaserTel = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetReceiverEmail(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ReceiverEmail = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetReceiverName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ReceiverName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetReceiverTel(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.ReceiverTel = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetRemark(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Remark = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSeatClass(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SeatClass = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSecondHandCarInvoiceDetailList(v []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSellerAddress(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SellerAddress = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSellerBankAccount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SellerBankAccount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSellerBankNameAccount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SellerBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSellerName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SellerName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSellerTaxNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SellerTaxNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSellerTel(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SellerTel = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSerialNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SerialNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetStartTime(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.StartTime = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSupplySign(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.SupplySign = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetSurcharge(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.Surcharge = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetTaxAmount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetTrainNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.TrainNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetTravelDate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.TravelDate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetUsedVehicleSaleDetailVOList(v []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetVehicleSaleDetailVOList(v []*UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetVerifyStatus(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.VerifyStatus = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetVoucherCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.VoucherCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO) SetVoucherStatus(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO {
	s.VoucherStatus = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails struct {
	// example:
	//
	// 北京国际机场
	Carrier *string `json:"carrier,omitempty" xml:"carrier,omitempty"`
	// example:
	//
	// AA1234
	FlightNumber *string `json:"flightNumber,omitempty" xml:"flightNumber,omitempty"`
	// example:
	//
	// 2023-05-11
	FlyDate *string `json:"flyDate,omitempty" xml:"flyDate,omitempty"`
	// example:
	//
	// 杭州
	FlyFrom *string `json:"flyFrom,omitempty" xml:"flyFrom,omitempty"`
	// example:
	//
	// 16:00
	FlyTime *string `json:"flyTime,omitempty" xml:"flyTime,omitempty"`
	// example:
	//
	// 北京
	FlyTo *string `json:"flyTo,omitempty" xml:"flyTo,omitempty"`
	// example:
	//
	// 头等舱
	Seat *string `json:"seat,omitempty" xml:"seat,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetCarrier(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.Carrier = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetFlightNumber(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.FlightNumber = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetFlyDate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.FlyDate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetFlyFrom(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.FlyFrom = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetFlyTime(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.FlyTime = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetFlyTo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.FlyTo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails) SetSeat(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails {
	s.Seat = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	// example:
	//
	// 1
	TaxPreType *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate    *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit       *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice  *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetAmount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetGoodsName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetQuantity(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetRevenueCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetRowNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetSpecification(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxAmount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxPre(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxPreType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetTaxRate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetUnit(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList) SetUnitPrice(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetAmount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetCardNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetEndDate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetGoodsName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetRowNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetStartDate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetTaxRate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList) SetVehicleType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetCarModel(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetCardNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetRegistration(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	// example:
	//
	// 123
	InspectionListNo *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers    *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace      *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo   *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate          *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage          *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo        *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType      *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetBrand(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetCertificateNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetEngineNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetIdCardNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetImportCertificateNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetInspectionListNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetMaxPassengers(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetOriginPlace(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetTaxRate(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetTonnage(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedResponseBody) SetResult(v bool) *UpdateInvoiceAndReceiptRelatedResponseBody {
	s.Result = &v
	return s
}

type UpdateInvoiceAndReceiptRelatedResponse struct {
	Headers    map[string]*string                          `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                      `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceAndReceiptRelatedResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceAndReceiptRelatedResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceAndReceiptRelatedResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceAndReceiptRelatedResponse) SetHeaders(v map[string]*string) *UpdateInvoiceAndReceiptRelatedResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedResponse) SetStatusCode(v int32) *UpdateInvoiceAndReceiptRelatedResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceAndReceiptRelatedResponse) SetBody(v *UpdateInvoiceAndReceiptRelatedResponseBody) *UpdateInvoiceAndReceiptRelatedResponse {
	s.Body = v
	return s
}

type UpdateInvoiceIgnoreStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceIgnoreStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceIgnoreStatusHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceIgnoreStatusHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceIgnoreStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceIgnoreStatusHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceIgnoreStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceIgnoreStatusRequest struct {
	// example:
	//
	// abc
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	// example:
	//
	// abc
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
	// example:
	//
	// IGNORE
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
}

func (s UpdateInvoiceIgnoreStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceIgnoreStatusRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceIgnoreStatusRequest) SetInstanceId(v string) *UpdateInvoiceIgnoreStatusRequest {
	s.InstanceId = &v
	return s
}

func (s *UpdateInvoiceIgnoreStatusRequest) SetOperator(v string) *UpdateInvoiceIgnoreStatusRequest {
	s.Operator = &v
	return s
}

func (s *UpdateInvoiceIgnoreStatusRequest) SetStatus(v string) *UpdateInvoiceIgnoreStatusRequest {
	s.Status = &v
	return s
}

type UpdateInvoiceIgnoreStatusResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateInvoiceIgnoreStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceIgnoreStatusResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceIgnoreStatusResponseBody) SetResult(v bool) *UpdateInvoiceIgnoreStatusResponseBody {
	s.Result = &v
	return s
}

type UpdateInvoiceIgnoreStatusResponse struct {
	Headers    map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceIgnoreStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceIgnoreStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceIgnoreStatusResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceIgnoreStatusResponse) SetHeaders(v map[string]*string) *UpdateInvoiceIgnoreStatusResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceIgnoreStatusResponse) SetStatusCode(v int32) *UpdateInvoiceIgnoreStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceIgnoreStatusResponse) SetBody(v *UpdateInvoiceIgnoreStatusResponseBody) *UpdateInvoiceIgnoreStatusResponse {
	s.Body = v
	return s
}

type UpdateInvoiceVerifyStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceVerifyStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceVerifyStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceVerifyStatusHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceVerifyStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceVerifyStatusRequest struct {
	// example:
	//
	// COM_DEFAULT
	CompanyCode *string `json:"companyCode,omitempty" xml:"companyCode,omitempty"`
	// example:
	//
	// DEDUCTED
	DeductStatus         *string                                                 `json:"deductStatus,omitempty" xml:"deductStatus,omitempty"`
	GeneralInvoiceVOList []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList `json:"generalInvoiceVOList,omitempty" xml:"generalInvoiceVOList,omitempty" type:"Repeated"`
	InvoiceKeyVOList     []*UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList     `json:"invoiceKeyVOList,omitempty" xml:"invoiceKeyVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
	// example:
	//
	// abc
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequest) SetCompanyCode(v string) *UpdateInvoiceVerifyStatusRequest {
	s.CompanyCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequest) SetDeductStatus(v string) *UpdateInvoiceVerifyStatusRequest {
	s.DeductStatus = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequest) SetGeneralInvoiceVOList(v []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) *UpdateInvoiceVerifyStatusRequest {
	s.GeneralInvoiceVOList = v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequest) SetInvoiceKeyVOList(v []*UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList) *UpdateInvoiceVerifyStatusRequest {
	s.InvoiceKeyVOList = v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequest) SetOperator(v string) *UpdateInvoiceVerifyStatusRequest {
	s.Operator = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequest) SetVerifyStatus(v string) *UpdateInvoiceVerifyStatusRequest {
	s.VerifyStatus = &v
	return s
}

type UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList struct {
	// example:
	//
	// abc
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// 100
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// 120
	AmountWithTax *string `json:"amountWithTax,omitempty" xml:"amountWithTax,omitempty"`
	// example:
	//
	// 1111
	CheckCode *string `json:"checkCode,omitempty" xml:"checkCode,omitempty"`
	// example:
	//
	// 2010-12-12
	CheckTime *string `json:"checkTime,omitempty" xml:"checkTime,omitempty"`
	// example:
	//
	// 张三
	DrawerName *string `json:"drawerName,omitempty" xml:"drawerName,omitempty"`
	// example:
	//
	// 2022-12-10
	DrewDate *string `json:"drewDate,omitempty" xml:"drewDate,omitempty"`
	// example:
	//
	// abc
	ElectronicUrl *string `json:"electronicUrl,omitempty" xml:"electronicUrl,omitempty"`
	// example:
	//
	// INPUT_VAT
	FinanceType *string `json:"financeType,omitempty" xml:"financeType,omitempty"`
	// example:
	//
	// RED
	FundType                   *string                                                                           `json:"fundType,omitempty" xml:"fundType,omitempty"`
	GeneralInvoiceDetailVOList []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList `json:"generalInvoiceDetailVOList,omitempty" xml:"generalInvoiceDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// http://XXX.jpg
	ImageUrl *string `json:"imageUrl,omitempty" xml:"imageUrl,omitempty"`
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// abc
	InvoiceStatus *string `json:"invoiceStatus,omitempty" xml:"invoiceStatus,omitempty"`
	// example:
	//
	// INTPUT_VAT
	InvoiceType *string `json:"invoiceType,omitempty" xml:"invoiceType,omitempty"`
	// example:
	//
	// 1111
	MachineCode *string `json:"machineCode,omitempty" xml:"machineCode,omitempty"`
	// example:
	//
	// abc
	OilFlag *string `json:"oilFlag,omitempty" xml:"oilFlag,omitempty"`
	// example:
	//
	// abc
	Payee *string `json:"payee,omitempty" xml:"payee,omitempty"`
	// example:
	//
	// abc
	ProcessInstCode *string `json:"processInstCode,omitempty" xml:"processInstCode,omitempty"`
	// example:
	//
	// abc
	ProcessInstType *string `json:"processInstType,omitempty" xml:"processInstType,omitempty"`
	// example:
	//
	// 杭州市
	PurchaserAddress     *string `json:"purchaserAddress,omitempty" xml:"purchaserAddress,omitempty"`
	PurchaserBankAccount *string `json:"purchaserBankAccount,omitempty" xml:"purchaserBankAccount,omitempty"`
	// example:
	//
	// 建行
	PurchaserBankNameAccount *string `json:"purchaserBankNameAccount,omitempty" xml:"purchaserBankNameAccount,omitempty"`
	// example:
	//
	// 张三
	PurchaserName *string `json:"purchaserName,omitempty" xml:"purchaserName,omitempty"`
	// example:
	//
	// 155655
	PurchaserTaxNo *string `json:"purchaserTaxNo,omitempty" xml:"purchaserTaxNo,omitempty"`
	// example:
	//
	// 1333333333
	PurchaserTel *string `json:"purchaserTel,omitempty" xml:"purchaserTel,omitempty"`
	// example:
	//
	// abc
	Remark                         *string                                                                               `json:"remark,omitempty" xml:"remark,omitempty"`
	SecondHandCarInvoiceDetailList []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList `json:"secondHandCarInvoiceDetailList,omitempty" xml:"secondHandCarInvoiceDetailList,omitempty" type:"Repeated"`
	// example:
	//
	// 8852
	SellerAddress     *string `json:"sellerAddress,omitempty" xml:"sellerAddress,omitempty"`
	SellerBankAccount *string `json:"sellerBankAccount,omitempty" xml:"sellerBankAccount,omitempty"`
	// example:
	//
	// 招商银行
	SellerBankNameAccount *string `json:"sellerBankNameAccount,omitempty" xml:"sellerBankNameAccount,omitempty"`
	// example:
	//
	// 李四
	SellerName *string `json:"sellerName,omitempty" xml:"sellerName,omitempty"`
	// example:
	//
	// 2202
	SellerTaxNo *string `json:"sellerTaxNo,omitempty" xml:"sellerTaxNo,omitempty"`
	// example:
	//
	// 13355222222
	SellerTel *string `json:"sellerTel,omitempty" xml:"sellerTel,omitempty"`
	// example:
	//
	// abc
	SupplySign *string `json:"supplySign,omitempty" xml:"supplySign,omitempty"`
	// example:
	//
	// 20
	TaxAmount                   *string                                                                            `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	UsedVehicleSaleDetailVOList []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList `json:"usedVehicleSaleDetailVOList,omitempty" xml:"usedVehicleSaleDetailVOList,omitempty" type:"Repeated"`
	VehicleSaleDetailVOList     []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList     `json:"vehicleSaleDetailVOList,omitempty" xml:"vehicleSaleDetailVOList,omitempty" type:"Repeated"`
	// example:
	//
	// abc
	VerifyStatus *string `json:"verifyStatus,omitempty" xml:"verifyStatus,omitempty"`
	// example:
	//
	// abc
	VoucherCode *string `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	// example:
	//
	// abc
	VoucherStatus *string `json:"voucherStatus,omitempty" xml:"voucherStatus,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetAccountPeriod(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetAmount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetAmountWithTax(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.AmountWithTax = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetCheckCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.CheckCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetCheckTime(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.CheckTime = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetDrawerName(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.DrawerName = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetDrewDate(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.DrewDate = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetElectronicUrl(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.ElectronicUrl = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetFinanceType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.FinanceType = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetFundType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.FundType = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetGeneralInvoiceDetailVOList(v []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.GeneralInvoiceDetailVOList = v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetImageUrl(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.ImageUrl = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetInvoiceCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetInvoiceNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetInvoiceStatus(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.InvoiceStatus = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetInvoiceType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.InvoiceType = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetMachineCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.MachineCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetOilFlag(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.OilFlag = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPayee(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.Payee = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetProcessInstCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.ProcessInstCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetProcessInstType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.ProcessInstType = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPurchaserAddress(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.PurchaserAddress = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPurchaserBankAccount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.PurchaserBankAccount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPurchaserBankNameAccount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.PurchaserBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPurchaserName(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.PurchaserName = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPurchaserTaxNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.PurchaserTaxNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetPurchaserTel(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.PurchaserTel = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetRemark(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.Remark = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSecondHandCarInvoiceDetailList(v []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SecondHandCarInvoiceDetailList = v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSellerAddress(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SellerAddress = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSellerBankAccount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SellerBankAccount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSellerBankNameAccount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SellerBankNameAccount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSellerName(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SellerName = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSellerTaxNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SellerTaxNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSellerTel(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SellerTel = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetSupplySign(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.SupplySign = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetTaxAmount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetUsedVehicleSaleDetailVOList(v []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.UsedVehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetVehicleSaleDetailVOList(v []*UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.VehicleSaleDetailVOList = v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetVerifyStatus(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.VerifyStatus = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetVoucherCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.VoucherCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList) SetVoucherStatus(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList {
	s.VoucherStatus = &v
	return s
}

type UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList struct {
	Amount        *string `json:"amount,omitempty" xml:"amount,omitempty"`
	GoodsName     *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	Quantity      *string `json:"quantity,omitempty" xml:"quantity,omitempty"`
	RevenueCode   *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo         *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	Specification *string `json:"specification,omitempty" xml:"specification,omitempty"`
	TaxAmount     *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxPre        *string `json:"taxPre,omitempty" xml:"taxPre,omitempty"`
	TaxPreType    *string `json:"taxPreType,omitempty" xml:"taxPreType,omitempty"`
	TaxRate       *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Unit          *string `json:"unit,omitempty" xml:"unit,omitempty"`
	UnitPrice     *string `json:"unitPrice,omitempty" xml:"unitPrice,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetAmount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetGoodsName(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetQuantity(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Quantity = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRevenueCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetRowNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetSpecification(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Specification = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxAmount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPre(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPre = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxPreType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxPreType = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetTaxRate(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnit(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.Unit = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList) SetUnitPrice(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList {
	s.UnitPrice = &v
	return s
}

type UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList struct {
	Amount      *string `json:"amount,omitempty" xml:"amount,omitempty"`
	CardNo      *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	EndDate     *string `json:"endDate,omitempty" xml:"endDate,omitempty"`
	GoodsName   *string `json:"goodsName,omitempty" xml:"goodsName,omitempty"`
	RevenueCode *string `json:"revenueCode,omitempty" xml:"revenueCode,omitempty"`
	RowNo       *string `json:"rowNo,omitempty" xml:"rowNo,omitempty"`
	StartDate   *string `json:"startDate,omitempty" xml:"startDate,omitempty"`
	TaxAmount   *string `json:"taxAmount,omitempty" xml:"taxAmount,omitempty"`
	TaxRate     *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	VehicleType *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetAmount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.Amount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetCardNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetEndDate(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.EndDate = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetGoodsName(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.GoodsName = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRevenueCode(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RevenueCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetRowNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.RowNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetStartDate(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.StartDate = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxAmount(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxAmount = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetTaxRate(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList) SetVehicleType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList struct {
	AuctionUnit        *string `json:"auctionUnit,omitempty" xml:"auctionUnit,omitempty"`
	AuctionUnitAddress *string `json:"auctionUnitAddress,omitempty" xml:"auctionUnitAddress,omitempty"`
	AuctionUnitBank    *string `json:"auctionUnitBank,omitempty" xml:"auctionUnitBank,omitempty"`
	AuctionUnitTaxNo   *string `json:"auctionUnitTaxNo,omitempty" xml:"auctionUnitTaxNo,omitempty"`
	AuctionUtilTel     *string `json:"auctionUtilTel,omitempty" xml:"auctionUtilTel,omitempty"`
	CarModel           *string `json:"carModel,omitempty" xml:"carModel,omitempty"`
	CardNo             *string `json:"cardNo,omitempty" xml:"cardNo,omitempty"`
	Registration       *string `json:"registration,omitempty" xml:"registration,omitempty"`
	TransferVehicle    *string `json:"transferVehicle,omitempty" xml:"transferVehicle,omitempty"`
	UsedCarAddress     *string `json:"usedCarAddress,omitempty" xml:"usedCarAddress,omitempty"`
	UsedCarMarket      *string `json:"usedCarMarket,omitempty" xml:"usedCarMarket,omitempty"`
	UsedCarMarketBank  *string `json:"usedCarMarketBank,omitempty" xml:"usedCarMarketBank,omitempty"`
	UsedCarMarketPhone *string `json:"usedCarMarketPhone,omitempty" xml:"usedCarMarketPhone,omitempty"`
	UsedCarMarketTaxNo *string `json:"usedCarMarketTaxNo,omitempty" xml:"usedCarMarketTaxNo,omitempty"`
	VehicleNo          *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType        *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnit(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnit = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitAddress(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitAddress = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitBank(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitBank = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUnitTaxNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUnitTaxNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetAuctionUtilTel(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.AuctionUtilTel = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCarModel(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CarModel = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetCardNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.CardNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetRegistration(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.Registration = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetTransferVehicle(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.TransferVehicle = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarAddress(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarAddress = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarket(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarket = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketBank(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketBank = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketPhone(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketPhone = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetUsedCarMarketTaxNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.UsedCarMarketTaxNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList struct {
	Brand               *string `json:"brand,omitempty" xml:"brand,omitempty"`
	CertificateNo       *string `json:"certificateNo,omitempty" xml:"certificateNo,omitempty"`
	EngineNo            *string `json:"engineNo,omitempty" xml:"engineNo,omitempty"`
	IdCardNo            *string `json:"idCardNo,omitempty" xml:"idCardNo,omitempty"`
	ImportCertificateNo *string `json:"importCertificateNo,omitempty" xml:"importCertificateNo,omitempty"`
	InspectionListNo    *string `json:"inspectionListNo,omitempty" xml:"inspectionListNo,omitempty"`
	MaxPassengers       *string `json:"maxPassengers,omitempty" xml:"maxPassengers,omitempty"`
	OriginPlace         *string `json:"originPlace,omitempty" xml:"originPlace,omitempty"`
	PaymentVoucherNo    *string `json:"paymentVoucherNo,omitempty" xml:"paymentVoucherNo,omitempty"`
	TaxAuthorityName    *string `json:"taxAuthorityName,omitempty" xml:"taxAuthorityName,omitempty"`
	TaxAuthorityNo      *string `json:"taxAuthorityNo,omitempty" xml:"taxAuthorityNo,omitempty"`
	TaxRate             *string `json:"taxRate,omitempty" xml:"taxRate,omitempty"`
	Tonnage             *string `json:"tonnage,omitempty" xml:"tonnage,omitempty"`
	VehicleNo           *string `json:"vehicleNo,omitempty" xml:"vehicleNo,omitempty"`
	VehicleType         *string `json:"vehicleType,omitempty" xml:"vehicleType,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetBrand(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Brand = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetCertificateNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.CertificateNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetEngineNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.EngineNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetIdCardNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.IdCardNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetImportCertificateNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.ImportCertificateNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetInspectionListNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.InspectionListNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetMaxPassengers(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.MaxPassengers = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetOriginPlace(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.OriginPlace = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetPaymentVoucherNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.PaymentVoucherNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityName(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityName = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxAuthorityNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxAuthorityNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTaxRate(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.TaxRate = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetTonnage(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.Tonnage = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleNo(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleNo = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList) SetVehicleType(v string) *UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList {
	s.VehicleType = &v
	return s
}

type UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList struct {
	// example:
	//
	// 1001
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// 2202
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
}

func (s UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList) SetInvoiceCode(v string) *UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList) SetInvoiceNo(v string) *UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList {
	s.InvoiceNo = &v
	return s
}

type UpdateInvoiceVerifyStatusResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateInvoiceVerifyStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusResponseBody) SetResult(v bool) *UpdateInvoiceVerifyStatusResponseBody {
	s.Result = &v
	return s
}

type UpdateInvoiceVerifyStatusResponse struct {
	Headers    map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceVerifyStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceVerifyStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVerifyStatusResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVerifyStatusResponse) SetHeaders(v map[string]*string) *UpdateInvoiceVerifyStatusResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceVerifyStatusResponse) SetStatusCode(v int32) *UpdateInvoiceVerifyStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceVerifyStatusResponse) SetBody(v *UpdateInvoiceVerifyStatusResponseBody) *UpdateInvoiceVerifyStatusResponse {
	s.Body = v
	return s
}

type UpdateInvoiceVoucherStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateInvoiceVoucherStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVoucherStatusHeaders) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVoucherStatusHeaders) SetCommonHeaders(v map[string]*string) *UpdateInvoiceVoucherStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateInvoiceVoucherStatusHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateInvoiceVoucherStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateInvoiceVoucherStatusRequest struct {
	// example:
	//
	// 123
	AccountantBookId *string `json:"accountantBookId,omitempty" xml:"accountantBookId,omitempty"`
	// example:
	//
	// ADD/DELETE
	ActionType *string `json:"actionType,omitempty" xml:"actionType,omitempty"`
	// example:
	//
	// abc
	InvoiceCode *string `json:"invoiceCode,omitempty" xml:"invoiceCode,omitempty"`
	// example:
	//
	// abc
	InvoiceNo *string `json:"invoiceNo,omitempty" xml:"invoiceNo,omitempty"`
	// example:
	//
	// 11011023488
	Operator *string `json:"operator,omitempty" xml:"operator,omitempty"`
	// example:
	//
	// abc
	VoucherId *string `json:"voucherId,omitempty" xml:"voucherId,omitempty"`
}

func (s UpdateInvoiceVoucherStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVoucherStatusRequest) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVoucherStatusRequest) SetAccountantBookId(v string) *UpdateInvoiceVoucherStatusRequest {
	s.AccountantBookId = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusRequest) SetActionType(v string) *UpdateInvoiceVoucherStatusRequest {
	s.ActionType = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusRequest) SetInvoiceCode(v string) *UpdateInvoiceVoucherStatusRequest {
	s.InvoiceCode = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusRequest) SetInvoiceNo(v string) *UpdateInvoiceVoucherStatusRequest {
	s.InvoiceNo = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusRequest) SetOperator(v string) *UpdateInvoiceVoucherStatusRequest {
	s.Operator = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusRequest) SetVoucherId(v string) *UpdateInvoiceVoucherStatusRequest {
	s.VoucherId = &v
	return s
}

type UpdateInvoiceVoucherStatusResponseBody struct {
	Result  *bool `json:"result,omitempty" xml:"result,omitempty"`
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s UpdateInvoiceVoucherStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVoucherStatusResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVoucherStatusResponseBody) SetResult(v bool) *UpdateInvoiceVoucherStatusResponseBody {
	s.Result = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusResponseBody) SetSuccess(v bool) *UpdateInvoiceVoucherStatusResponseBody {
	s.Success = &v
	return s
}

type UpdateInvoiceVoucherStatusResponse struct {
	Headers    map[string]*string                      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateInvoiceVoucherStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateInvoiceVoucherStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateInvoiceVoucherStatusResponse) GoString() string {
	return s.String()
}

func (s *UpdateInvoiceVoucherStatusResponse) SetHeaders(v map[string]*string) *UpdateInvoiceVoucherStatusResponse {
	s.Headers = v
	return s
}

func (s *UpdateInvoiceVoucherStatusResponse) SetStatusCode(v int32) *UpdateInvoiceVoucherStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateInvoiceVoucherStatusResponse) SetBody(v *UpdateInvoiceVoucherStatusResponseBody) *UpdateInvoiceVoucherStatusResponse {
	s.Body = v
	return s
}

type UpdateReceiptHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateReceiptHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptHeaders) GoString() string {
	return s.String()
}

func (s *UpdateReceiptHeaders) SetCommonHeaders(v map[string]*string) *UpdateReceiptHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateReceiptHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateReceiptHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateReceiptRequest struct {
	// This parameter is required.
	Receipts []*UpdateReceiptRequestReceipts `json:"receipts,omitempty" xml:"receipts,omitempty" type:"Repeated"`
}

func (s UpdateReceiptRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptRequest) GoString() string {
	return s.String()
}

func (s *UpdateReceiptRequest) SetReceipts(v []*UpdateReceiptRequestReceipts) *UpdateReceiptRequest {
	s.Receipts = v
	return s
}

type UpdateReceiptRequestReceipts struct {
	// example:
	//
	// 2.44
	Amount *string `json:"amount,omitempty" xml:"amount,omitempty"`
	// example:
	//
	// INC_XXX
	CategoryCode *string `json:"categoryCode,omitempty" xml:"categoryCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// abcd_efgh
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// CUS_XXX
	CustomerCode *string `json:"customerCode,omitempty" xml:"customerCode,omitempty"`
	// example:
	//
	// ACC_XXX
	EnterpriseAcountCode *string `json:"enterpriseAcountCode,omitempty" xml:"enterpriseAcountCode,omitempty"`
	// example:
	//
	// 1636445218000
	OccurDate *int64 `json:"occurDate,omitempty" xml:"occurDate,omitempty"`
	// example:
	//
	// emp_xxx
	PrincipalId *string `json:"principalId,omitempty" xml:"principalId,omitempty"`
	// example:
	//
	// PROJ_XXX
	ProjectCode *string `json:"projectCode,omitempty" xml:"projectCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1
	ReceiptType *int64 `json:"receiptType,omitempty" xml:"receiptType,omitempty"`
	// example:
	//
	// 测试单据
	Remark *string `json:"remark,omitempty" xml:"remark,omitempty"`
	// example:
	//
	// SUP_XXX
	SupplierCode *string `json:"supplierCode,omitempty" xml:"supplierCode,omitempty"`
	// example:
	//
	// 付款单
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1636445218000
	UpdateTime *int64 `json:"updateTime,omitempty" xml:"updateTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// emp_xxx
	UpdateUserId *string `json:"updateUserId,omitempty" xml:"updateUserId,omitempty"`
}

func (s UpdateReceiptRequestReceipts) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptRequestReceipts) GoString() string {
	return s.String()
}

func (s *UpdateReceiptRequestReceipts) SetAmount(v string) *UpdateReceiptRequestReceipts {
	s.Amount = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetCategoryCode(v string) *UpdateReceiptRequestReceipts {
	s.CategoryCode = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetCode(v string) *UpdateReceiptRequestReceipts {
	s.Code = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetCustomerCode(v string) *UpdateReceiptRequestReceipts {
	s.CustomerCode = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetEnterpriseAcountCode(v string) *UpdateReceiptRequestReceipts {
	s.EnterpriseAcountCode = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetOccurDate(v int64) *UpdateReceiptRequestReceipts {
	s.OccurDate = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetPrincipalId(v string) *UpdateReceiptRequestReceipts {
	s.PrincipalId = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetProjectCode(v string) *UpdateReceiptRequestReceipts {
	s.ProjectCode = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetReceiptType(v int64) *UpdateReceiptRequestReceipts {
	s.ReceiptType = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetRemark(v string) *UpdateReceiptRequestReceipts {
	s.Remark = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetSupplierCode(v string) *UpdateReceiptRequestReceipts {
	s.SupplierCode = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetTitle(v string) *UpdateReceiptRequestReceipts {
	s.Title = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetUpdateTime(v int64) *UpdateReceiptRequestReceipts {
	s.UpdateTime = &v
	return s
}

func (s *UpdateReceiptRequestReceipts) SetUpdateUserId(v string) *UpdateReceiptRequestReceipts {
	s.UpdateUserId = &v
	return s
}

type UpdateReceiptResponseBody struct {
	Results []*UpdateReceiptResponseBodyResults `json:"results,omitempty" xml:"results,omitempty" type:"Repeated"`
}

func (s UpdateReceiptResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateReceiptResponseBody) SetResults(v []*UpdateReceiptResponseBodyResults) *UpdateReceiptResponseBody {
	s.Results = v
	return s
}

type UpdateReceiptResponseBodyResults struct {
	// This parameter is required.
	//
	// example:
	//
	// abcd_efgh_1234
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
	// example:
	//
	// success
	ErrorCode *string `json:"errorCode,omitempty" xml:"errorCode,omitempty"`
	// example:
	//
	// 成功
	ErrorMsg *string `json:"errorMsg,omitempty" xml:"errorMsg,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s UpdateReceiptResponseBodyResults) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptResponseBodyResults) GoString() string {
	return s.String()
}

func (s *UpdateReceiptResponseBodyResults) SetCode(v string) *UpdateReceiptResponseBodyResults {
	s.Code = &v
	return s
}

func (s *UpdateReceiptResponseBodyResults) SetErrorCode(v string) *UpdateReceiptResponseBodyResults {
	s.ErrorCode = &v
	return s
}

func (s *UpdateReceiptResponseBodyResults) SetErrorMsg(v string) *UpdateReceiptResponseBodyResults {
	s.ErrorMsg = &v
	return s
}

func (s *UpdateReceiptResponseBodyResults) SetSuccess(v bool) *UpdateReceiptResponseBodyResults {
	s.Success = &v
	return s
}

type UpdateReceiptResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateReceiptResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateReceiptResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptResponse) GoString() string {
	return s.String()
}

func (s *UpdateReceiptResponse) SetHeaders(v map[string]*string) *UpdateReceiptResponse {
	s.Headers = v
	return s
}

func (s *UpdateReceiptResponse) SetStatusCode(v int32) *UpdateReceiptResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateReceiptResponse) SetBody(v *UpdateReceiptResponseBody) *UpdateReceiptResponse {
	s.Body = v
	return s
}

type UpdateReceiptVoucherStatusHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateReceiptVoucherStatusHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptVoucherStatusHeaders) GoString() string {
	return s.String()
}

func (s *UpdateReceiptVoucherStatusHeaders) SetCommonHeaders(v map[string]*string) *UpdateReceiptVoucherStatusHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateReceiptVoucherStatusHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateReceiptVoucherStatusHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateReceiptVoucherStatusRequest struct {
	// example:
	//
	// abc
	AccountPeriod *string `json:"accountPeriod,omitempty" xml:"accountPeriod,omitempty"`
	// example:
	//
	// add
	ActionType *string `json:"actionType,omitempty" xml:"actionType,omitempty"`
	// example:
	//
	// 0021241
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
	// example:
	//
	// abc
	ReceiptId *string `json:"receiptId,omitempty" xml:"receiptId,omitempty"`
	// example:
	//
	// abc
	VoucherCode *string `json:"voucherCode,omitempty" xml:"voucherCode,omitempty"`
	// example:
	//
	// abc
	VoucherId *string `json:"voucherId,omitempty" xml:"voucherId,omitempty"`
	// example:
	//
	// 记-001
	VoucherNo *string `json:"voucherNo,omitempty" xml:"voucherNo,omitempty"`
}

func (s UpdateReceiptVoucherStatusRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptVoucherStatusRequest) GoString() string {
	return s.String()
}

func (s *UpdateReceiptVoucherStatusRequest) SetAccountPeriod(v string) *UpdateReceiptVoucherStatusRequest {
	s.AccountPeriod = &v
	return s
}

func (s *UpdateReceiptVoucherStatusRequest) SetActionType(v string) *UpdateReceiptVoucherStatusRequest {
	s.ActionType = &v
	return s
}

func (s *UpdateReceiptVoucherStatusRequest) SetOperatorId(v string) *UpdateReceiptVoucherStatusRequest {
	s.OperatorId = &v
	return s
}

func (s *UpdateReceiptVoucherStatusRequest) SetReceiptId(v string) *UpdateReceiptVoucherStatusRequest {
	s.ReceiptId = &v
	return s
}

func (s *UpdateReceiptVoucherStatusRequest) SetVoucherCode(v string) *UpdateReceiptVoucherStatusRequest {
	s.VoucherCode = &v
	return s
}

func (s *UpdateReceiptVoucherStatusRequest) SetVoucherId(v string) *UpdateReceiptVoucherStatusRequest {
	s.VoucherId = &v
	return s
}

func (s *UpdateReceiptVoucherStatusRequest) SetVoucherNo(v string) *UpdateReceiptVoucherStatusRequest {
	s.VoucherNo = &v
	return s
}

type UpdateReceiptVoucherStatusResponseBody struct {
	Result *bool `json:"result,omitempty" xml:"result,omitempty"`
}

func (s UpdateReceiptVoucherStatusResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptVoucherStatusResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateReceiptVoucherStatusResponseBody) SetResult(v bool) *UpdateReceiptVoucherStatusResponseBody {
	s.Result = &v
	return s
}

type UpdateReceiptVoucherStatusResponse struct {
	Headers    map[string]*string                      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateReceiptVoucherStatusResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateReceiptVoucherStatusResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateReceiptVoucherStatusResponse) GoString() string {
	return s.String()
}

func (s *UpdateReceiptVoucherStatusResponse) SetHeaders(v map[string]*string) *UpdateReceiptVoucherStatusResponse {
	s.Headers = v
	return s
}

func (s *UpdateReceiptVoucherStatusResponse) SetStatusCode(v int32) *UpdateReceiptVoucherStatusResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateReceiptVoucherStatusResponse) SetBody(v *UpdateReceiptVoucherStatusResponseBody) *UpdateReceiptVoucherStatusResponse {
	s.Body = v
	return s
}

type Client struct {
	openapi.Client
}

func NewClient(config *openapi.Config) (*Client, error) {
	client := new(Client)
	err := client.Init(config)
	return client, err
}

func (client *Client) Init(config *openapi.Config) (_err error) {
	_err = client.Client.Init(config)
	if _err != nil {
		return _err
	}
	gatewayClient, _err := gatewayclient.NewClient()
	if _err != nil {
		return _err
	}

	client.Spi = gatewayClient
	client.EndpointRule = tea.String("")
	if tea.BoolValue(util.Empty(client.Endpoint)) {
		client.Endpoint = tea.String("api.dingtalk.com")
	}

	return nil
}

// Summary:
//
// 追加角色权限点
//
// @param tmpReq - AppendRolePermissionRequest
//
// @param headers - AppendRolePermissionHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return AppendRolePermissionResponse
func (client *Client) AppendRolePermissionWithOptions(tmpReq *AppendRolePermissionRequest, headers *AppendRolePermissionHeaders, runtime *util.RuntimeOptions) (_result *AppendRolePermissionResponse, _err error) {
	_err = util.ValidateModel(tmpReq)
	if _err != nil {
		return _result, _err
	}
	request := &AppendRolePermissionShrinkRequest{}
	openapiutil.Convert(tmpReq, request)
	if !tea.BoolValue(util.IsUnset(tmpReq.RolePermissionItemList)) {
		request.RolePermissionItemListShrink = openapiutil.ArrayToStringWithSpecifiedStyle(tmpReq.RolePermissionItemList, tea.String("rolePermissionItemList"), tea.String("json"))
	}

	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.RolePermissionItemListShrink)) {
		query["rolePermissionItemList"] = request.RolePermissionItemListShrink
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("AppendRolePermission"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/roles/permissions"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &AppendRolePermissionResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 追加角色权限点
//
// @param request - AppendRolePermissionRequest
//
// @return AppendRolePermissionResponse
func (client *Client) AppendRolePermission(request *AppendRolePermissionRequest) (_result *AppendRolePermissionResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &AppendRolePermissionHeaders{}
	_result = &AppendRolePermissionResponse{}
	_body, _err := client.AppendRolePermissionWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 发票数据批量写入
//
// @param request - BatchAddInvoiceRequest
//
// @param headers - BatchAddInvoiceHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return BatchAddInvoiceResponse
func (client *Client) BatchAddInvoiceWithOptions(request *BatchAddInvoiceRequest, headers *BatchAddInvoiceHeaders, runtime *util.RuntimeOptions) (_result *BatchAddInvoiceResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.GeneralInvoiceVOList)) {
		body["generalInvoiceVOList"] = request.GeneralInvoiceVOList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	if !tea.BoolValue(util.IsUnset(request.OrderId)) {
		body["orderId"] = request.OrderId
	}

	if !tea.BoolValue(util.IsUnset(request.Source)) {
		body["source"] = request.Source
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("BatchAddInvoice"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/batch"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &BatchAddInvoiceResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 发票数据批量写入
//
// @param request - BatchAddInvoiceRequest
//
// @return BatchAddInvoiceResponse
func (client *Client) BatchAddInvoice(request *BatchAddInvoiceRequest) (_result *BatchAddInvoiceResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &BatchAddInvoiceHeaders{}
	_result = &BatchAddInvoiceResponse{}
	_body, _err := client.BatchAddInvoiceWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量增加用户信息
//
// @param request - BatchCreateCustomerRequest
//
// @param headers - BatchCreateCustomerHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return BatchCreateCustomerResponse
func (client *Client) BatchCreateCustomerWithOptions(request *BatchCreateCustomerRequest, headers *BatchCreateCustomerHeaders, runtime *util.RuntimeOptions) (_result *BatchCreateCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CreateCustomerRequestList)) {
		body["createCustomerRequestList"] = request.CreateCustomerRequestList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("BatchCreateCustomer"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/auxiliaries/batch"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &BatchCreateCustomerResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量增加用户信息
//
// @param request - BatchCreateCustomerRequest
//
// @return BatchCreateCustomerResponse
func (client *Client) BatchCreateCustomer(request *BatchCreateCustomerRequest) (_result *BatchCreateCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &BatchCreateCustomerHeaders{}
	_result = &BatchCreateCustomerResponse{}
	_body, _err := client.BatchCreateCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 预核销智能财务的权益
//
// @param request - BeginConsumeRequest
//
// @param headers - BeginConsumeHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return BeginConsumeResponse
func (client *Client) BeginConsumeWithOptions(request *BeginConsumeRequest, headers *BeginConsumeHeaders, runtime *util.RuntimeOptions) (_result *BeginConsumeResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BenefitCode)) {
		query["benefitCode"] = request.BenefitCode
	}

	if !tea.BoolValue(util.IsUnset(request.BizRequestId)) {
		query["bizRequestId"] = request.BizRequestId
	}

	if !tea.BoolValue(util.IsUnset(request.Quota)) {
		query["quota"] = request.Quota
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("BeginConsume"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/consumedBenefits/prepare"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &BeginConsumeResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 预核销智能财务的权益
//
// @param request - BeginConsumeRequest
//
// @return BeginConsumeResponse
func (client *Client) BeginConsume(request *BeginConsumeRequest) (_result *BeginConsumeResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &BeginConsumeHeaders{}
	_result = &BeginConsumeResponse{}
	_body, _err := client.BeginConsumeWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 绑定钉钉智能财务企业主体的账套信息
//
// @param request - BindCompanyAccountantBookRequest
//
// @param headers - BindCompanyAccountantBookHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return BindCompanyAccountantBookResponse
func (client *Client) BindCompanyAccountantBookWithOptions(request *BindCompanyAccountantBookRequest, headers *BindCompanyAccountantBookHeaders, runtime *util.RuntimeOptions) (_result *BindCompanyAccountantBookResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountantBookId)) {
		query["accountantBookId"] = request.AccountantBookId
	}

	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		query["companyCode"] = request.CompanyCode
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("BindCompanyAccountantBook"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/companies/accountantBooks/bind"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &BindCompanyAccountantBookResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 绑定钉钉智能财务企业主体的账套信息
//
// @param request - BindCompanyAccountantBookRequest
//
// @return BindCompanyAccountantBookResponse
func (client *Client) BindCompanyAccountantBook(request *BindCompanyAccountantBookRequest) (_result *BindCompanyAccountantBookResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &BindCompanyAccountantBookHeaders{}
	_result = &BindCompanyAccountantBookResponse{}
	_body, _err := client.BindCompanyAccountantBookWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 取消核销智能财务的权益
//
// @param request - CancelConsumeRequest
//
// @param headers - CancelConsumeHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CancelConsumeResponse
func (client *Client) CancelConsumeWithOptions(request *CancelConsumeRequest, headers *CancelConsumeHeaders, runtime *util.RuntimeOptions) (_result *CancelConsumeResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BenefitCode)) {
		query["benefitCode"] = request.BenefitCode
	}

	if !tea.BoolValue(util.IsUnset(request.BizRequestId)) {
		query["bizRequestId"] = request.BizRequestId
	}

	if !tea.BoolValue(util.IsUnset(request.Quota)) {
		query["quota"] = request.Quota
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("CancelConsume"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/consumedBenefits/cancel"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CancelConsumeResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 取消核销智能财务的权益
//
// @param request - CancelConsumeRequest
//
// @return CancelConsumeResponse
func (client *Client) CancelConsume(request *CancelConsumeRequest) (_result *CancelConsumeResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CancelConsumeHeaders{}
	_result = &CancelConsumeResponse{}
	_body, _err := client.CancelConsumeWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查验发票是否生成凭证
//
// @param request - CheckVoucherStatusRequest
//
// @param headers - CheckVoucherStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CheckVoucherStatusResponse
func (client *Client) CheckVoucherStatusWithOptions(request *CheckVoucherStatusRequest, headers *CheckVoucherStatusHeaders, runtime *util.RuntimeOptions) (_result *CheckVoucherStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.EndTime)) {
		body["endTime"] = request.EndTime
	}

	if !tea.BoolValue(util.IsUnset(request.FinanceType)) {
		body["financeType"] = request.FinanceType
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceCode)) {
		body["invoiceCode"] = request.InvoiceCode
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceNo)) {
		body["invoiceNo"] = request.InvoiceNo
	}

	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		body["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		body["pageSize"] = request.PageSize
	}

	if !tea.BoolValue(util.IsUnset(request.StartTime)) {
		body["startTime"] = request.StartTime
	}

	if !tea.BoolValue(util.IsUnset(request.TaxNo)) {
		body["taxNo"] = request.TaxNo
	}

	if !tea.BoolValue(util.IsUnset(request.VerifyStatus)) {
		body["verifyStatus"] = request.VerifyStatus
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("CheckVoucherStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/checkVoucherStatus/query"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CheckVoucherStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查验发票是否生成凭证
//
// @param request - CheckVoucherStatusRequest
//
// @return CheckVoucherStatusResponse
func (client *Client) CheckVoucherStatus(request *CheckVoucherStatusRequest) (_result *CheckVoucherStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CheckVoucherStatusHeaders{}
	_result = &CheckVoucherStatusResponse{}
	_body, _err := client.CheckVoucherStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 确认核销智能财务的权益
//
// @param request - CommitConsumeRequest
//
// @param headers - CommitConsumeHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CommitConsumeResponse
func (client *Client) CommitConsumeWithOptions(request *CommitConsumeRequest, headers *CommitConsumeHeaders, runtime *util.RuntimeOptions) (_result *CommitConsumeResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BenefitCode)) {
		query["benefitCode"] = request.BenefitCode
	}

	if !tea.BoolValue(util.IsUnset(request.BizRequestId)) {
		query["bizRequestId"] = request.BizRequestId
	}

	if !tea.BoolValue(util.IsUnset(request.Quota)) {
		query["quota"] = request.Quota
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("CommitConsume"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/consumedBenefits/commit"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CommitConsumeResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 确认核销智能财务的权益
//
// @param request - CommitConsumeRequest
//
// @return CommitConsumeResponse
func (client *Client) CommitConsume(request *CommitConsumeRequest) (_result *CommitConsumeResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CommitConsumeHeaders{}
	_result = &CommitConsumeResponse{}
	_body, _err := client.CommitConsumeWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 创建智能财务的客户信息
//
// @param request - CreateCustomerRequest
//
// @param headers - CreateCustomerHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CreateCustomerResponse
func (client *Client) CreateCustomerWithOptions(request *CreateCustomerRequest, headers *CreateCustomerHeaders, runtime *util.RuntimeOptions) (_result *CreateCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Creator)) {
		body["creator"] = request.Creator
	}

	if !tea.BoolValue(util.IsUnset(request.Description)) {
		body["description"] = request.Description
	}

	if !tea.BoolValue(util.IsUnset(request.DrawerEmail)) {
		body["drawerEmail"] = request.DrawerEmail
	}

	if !tea.BoolValue(util.IsUnset(request.DrawerTelephone)) {
		body["drawerTelephone"] = request.DrawerTelephone
	}

	if !tea.BoolValue(util.IsUnset(request.Name)) {
		body["name"] = request.Name
	}

	if !tea.BoolValue(util.IsUnset(request.PurchaserAccount)) {
		body["purchaserAccount"] = request.PurchaserAccount
	}

	if !tea.BoolValue(util.IsUnset(request.PurchaserAddress)) {
		body["purchaserAddress"] = request.PurchaserAddress
	}

	if !tea.BoolValue(util.IsUnset(request.PurchaserBankName)) {
		body["purchaserBankName"] = request.PurchaserBankName
	}

	if !tea.BoolValue(util.IsUnset(request.PurchaserName)) {
		body["purchaserName"] = request.PurchaserName
	}

	if !tea.BoolValue(util.IsUnset(request.PurchaserTaxNo)) {
		body["purchaserTaxNo"] = request.PurchaserTaxNo
	}

	if !tea.BoolValue(util.IsUnset(request.PurchaserTel)) {
		body["purchaserTel"] = request.PurchaserTel
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("CreateCustomer"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/auxiliaries/customers"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CreateCustomerResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 创建智能财务的客户信息
//
// @param request - CreateCustomerRequest
//
// @return CreateCustomerResponse
func (client *Client) CreateCustomer(request *CreateCustomerRequest) (_result *CreateCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CreateCustomerHeaders{}
	_result = &CreateCustomerResponse{}
	_body, _err := client.CreateCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 创建智能财务单据
//
// @param request - CreateReceiptRequest
//
// @param headers - CreateReceiptHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CreateReceiptResponse
func (client *Client) CreateReceiptWithOptions(request *CreateReceiptRequest, headers *CreateReceiptHeaders, runtime *util.RuntimeOptions) (_result *CreateReceiptResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Receipts)) {
		body["receipts"] = request.Receipts
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("CreateReceipt"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/receipts"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CreateReceiptResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 创建智能财务单据
//
// @param request - CreateReceiptRequest
//
// @return CreateReceiptResponse
func (client *Client) CreateReceipt(request *CreateReceiptRequest) (_result *CreateReceiptResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CreateReceiptHeaders{}
	_result = &CreateReceiptResponse{}
	_body, _err := client.CreateReceiptWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 删除智能财务单据
//
// @param request - DeleteReceiptRequest
//
// @param headers - DeleteReceiptHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return DeleteReceiptResponse
func (client *Client) DeleteReceiptWithOptions(request *DeleteReceiptRequest, headers *DeleteReceiptHeaders, runtime *util.RuntimeOptions) (_result *DeleteReceiptResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Receipts)) {
		body["receipts"] = request.Receipts
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("DeleteReceipt"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/receipts/remove"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &DeleteReceiptResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 删除智能财务单据
//
// @param request - DeleteReceiptRequest
//
// @return DeleteReceiptResponse
func (client *Client) DeleteReceipt(request *DeleteReceiptRequest) (_result *DeleteReceiptResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DeleteReceiptHeaders{}
	_result = &DeleteReceiptResponse{}
	_body, _err := client.DeleteReceiptWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取可以查看账本的用户列表
//
// @param headers - GetBookkeepingUserListHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetBookkeepingUserListResponse
func (client *Client) GetBookkeepingUserListWithOptions(headers *GetBookkeepingUserListHeaders, runtime *util.RuntimeOptions) (_result *GetBookkeepingUserListResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("GetBookkeepingUserList"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/bookkeeping/users"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetBookkeepingUserListResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取可以查看账本的用户列表
//
// @return GetBookkeepingUserListResponse
func (client *Client) GetBookkeepingUserList() (_result *GetBookkeepingUserListResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetBookkeepingUserListHeaders{}
	_result = &GetBookkeepingUserListResponse{}
	_body, _err := client.GetBookkeepingUserListWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取费用类别
//
// @param request - GetCategoryRequest
//
// @param headers - GetCategoryHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetCategoryResponse
func (client *Client) GetCategoryWithOptions(request *GetCategoryRequest, headers *GetCategoryHeaders, runtime *util.RuntimeOptions) (_result *GetCategoryResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Code)) {
		query["code"] = request.Code
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetCategory"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/categories/get"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetCategoryResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取费用类别
//
// @param request - GetCategoryRequest
//
// @return GetCategoryResponse
func (client *Client) GetCategory(request *GetCategoryRequest) (_result *GetCategoryResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetCategoryHeaders{}
	_result = &GetCategoryResponse{}
	_body, _err := client.GetCategoryWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取智能财务应用内维护的客户信息
//
// @param request - GetCustomerRequest
//
// @param headers - GetCustomerHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetCustomerResponse
func (client *Client) GetCustomerWithOptions(request *GetCustomerRequest, headers *GetCustomerHeaders, runtime *util.RuntimeOptions) (_result *GetCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Code)) {
		query["code"] = request.Code
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetCustomer"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/customers/details"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetCustomerResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取智能财务应用内维护的客户信息
//
// @param request - GetCustomerRequest
//
// @return GetCustomerResponse
func (client *Client) GetCustomer(request *GetCustomerRequest) (_result *GetCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetCustomerHeaders{}
	_result = &GetCustomerResponse{}
	_body, _err := client.GetCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取企业账户
//
// @param request - GetFinanceAccountRequest
//
// @param headers - GetFinanceAccountHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetFinanceAccountResponse
func (client *Client) GetFinanceAccountWithOptions(request *GetFinanceAccountRequest, headers *GetFinanceAccountHeaders, runtime *util.RuntimeOptions) (_result *GetFinanceAccountResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountCode)) {
		query["accountCode"] = request.AccountCode
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetFinanceAccount"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/financeAccounts/get"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetFinanceAccountResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取企业账户
//
// @param request - GetFinanceAccountRequest
//
// @return GetFinanceAccountResponse
func (client *Client) GetFinanceAccount(request *GetFinanceAccountRequest) (_result *GetFinanceAccountResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetFinanceAccountHeaders{}
	_result = &GetFinanceAccountResponse{}
	_body, _err := client.GetFinanceAccountWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取智能财务套件模版信息
//
// @param headers - GetFormTemplateInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetFormTemplateInfoResponse
func (client *Client) GetFormTemplateInfoWithOptions(headers *GetFormTemplateInfoHeaders, runtime *util.RuntimeOptions) (_result *GetFormTemplateInfoResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("GetFormTemplateInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/formTemplates/infos"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetFormTemplateInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取智能财务套件模版信息
//
// @return GetFormTemplateInfoResponse
func (client *Client) GetFormTemplateInfo() (_result *GetFormTemplateInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetFormTemplateInfoHeaders{}
	_result = &GetFormTemplateInfoResponse{}
	_body, _err := client.GetFormTemplateInfoWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 发票分页查询接口
//
// @param tmpReq - GetInvoiceByPageRequest
//
// @param headers - GetInvoiceByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetInvoiceByPageResponse
func (client *Client) GetInvoiceByPageWithOptions(tmpReq *GetInvoiceByPageRequest, headers *GetInvoiceByPageHeaders, runtime *util.RuntimeOptions) (_result *GetInvoiceByPageResponse, _err error) {
	_err = util.ValidateModel(tmpReq)
	if _err != nil {
		return _result, _err
	}
	request := &GetInvoiceByPageShrinkRequest{}
	openapiutil.Convert(tmpReq, request)
	if !tea.BoolValue(util.IsUnset(tmpReq.Request)) {
		request.RequestShrink = openapiutil.ArrayToStringWithSpecifiedStyle(tmpReq.Request, tea.String("request"), tea.String("json"))
	}

	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.RequestShrink)) {
		query["request"] = request.RequestShrink
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetInvoiceByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetInvoiceByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 发票分页查询接口
//
// @param request - GetInvoiceByPageRequest
//
// @return GetInvoiceByPageResponse
func (client *Client) GetInvoiceByPage(request *GetInvoiceByPageRequest) (_result *GetInvoiceByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetInvoiceByPageHeaders{}
	_result = &GetInvoiceByPageResponse{}
	_body, _err := client.GetInvoiceByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 用来给isv提供是否使用智能账本的判断接口
//
// @param headers - GetIsNewVersionHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetIsNewVersionResponse
func (client *Client) GetIsNewVersionWithOptions(headers *GetIsNewVersionHeaders, runtime *util.RuntimeOptions) (_result *GetIsNewVersionResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("GetIsNewVersion"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/accounts/uses"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetIsNewVersionResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 用来给isv提供是否使用智能账本的判断接口
//
// @return GetIsNewVersionResponse
func (client *Client) GetIsNewVersion() (_result *GetIsNewVersionResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetIsNewVersionHeaders{}
	_result = &GetIsNewVersionResponse{}
	_body, _err := client.GetIsNewVersionWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 根据comanyCode查询钉钉智能财务多主体信息
//
// @param headers - GetMultiCompanyInfoByCodeHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetMultiCompanyInfoByCodeResponse
func (client *Client) GetMultiCompanyInfoByCodeWithOptions(companyCode *string, headers *GetMultiCompanyInfoByCodeHeaders, runtime *util.RuntimeOptions) (_result *GetMultiCompanyInfoByCodeResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("GetMultiCompanyInfoByCode"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/multiCompanies/" + tea.StringValue(companyCode)),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetMultiCompanyInfoByCodeResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 根据comanyCode查询钉钉智能财务多主体信息
//
// @return GetMultiCompanyInfoByCodeResponse
func (client *Client) GetMultiCompanyInfoByCode(companyCode *string) (_result *GetMultiCompanyInfoByCodeResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetMultiCompanyInfoByCodeHeaders{}
	_result = &GetMultiCompanyInfoByCodeResponse{}
	_body, _err := client.GetMultiCompanyInfoByCodeWithOptions(companyCode, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取商品信息
//
// @param request - GetProductRequest
//
// @param headers - GetProductHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetProductResponse
func (client *Client) GetProductWithOptions(request *GetProductRequest, headers *GetProductHeaders, runtime *util.RuntimeOptions) (_result *GetProductResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Code)) {
		query["code"] = request.Code
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetProduct"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/products"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetProductResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取商品信息
//
// @param request - GetProductRequest
//
// @return GetProductResponse
func (client *Client) GetProduct(request *GetProductRequest) (_result *GetProductResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetProductHeaders{}
	_result = &GetProductResponse{}
	_body, _err := client.GetProductWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取单条项目
//
// @param request - GetProjectRequest
//
// @param headers - GetProjectHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetProjectResponse
func (client *Client) GetProjectWithOptions(request *GetProjectRequest, headers *GetProjectHeaders, runtime *util.RuntimeOptions) (_result *GetProjectResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Code)) {
		query["code"] = request.Code
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetProject"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/projects/get"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetProjectResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取单条项目
//
// @param request - GetProjectRequest
//
// @return GetProjectResponse
func (client *Client) GetProject(request *GetProjectRequest) (_result *GetProjectResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetProjectHeaders{}
	_result = &GetProjectResponse{}
	_body, _err := client.GetProjectWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取智能财务单据详情
//
// @param request - GetReceiptRequest
//
// @param headers - GetReceiptHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetReceiptResponse
func (client *Client) GetReceiptWithOptions(request *GetReceiptRequest, headers *GetReceiptHeaders, runtime *util.RuntimeOptions) (_result *GetReceiptResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Code)) {
		query["code"] = request.Code
	}

	if !tea.BoolValue(util.IsUnset(request.ModelId)) {
		query["modelId"] = request.ModelId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetReceipt"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/receipts/details"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &GetReceiptResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取智能财务单据详情
//
// @param request - GetReceiptRequest
//
// @return GetReceiptResponse
func (client *Client) GetReceipt(request *GetReceiptRequest) (_result *GetReceiptResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetReceiptHeaders{}
	_result = &GetReceiptResponse{}
	_body, _err := client.GetReceiptWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取智能财务应用内维护的供应商信息
//
// @param request - GetSupplierRequest
//
// @param headers - GetSupplierHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetSupplierResponse
func (client *Client) GetSupplierWithOptions(request *GetSupplierRequest, headers *GetSupplierHeaders, runtime *util.RuntimeOptions) (_result *GetSupplierResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Code)) {
		query["code"] = request.Code
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetSupplier"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/suppliers/details"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetSupplierResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取智能财务应用内维护的供应商信息
//
// @param request - GetSupplierRequest
//
// @return GetSupplierResponse
func (client *Client) GetSupplier(request *GetSupplierRequest) (_result *GetSupplierResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetSupplierHeaders{}
	_result = &GetSupplierResponse{}
	_body, _err := client.GetSupplierWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取用友开放平台接口鉴权信息
//
// @param request - GetYongYouOpenApiTokenRequest
//
// @param headers - GetYongYouOpenApiTokenHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetYongYouOpenApiTokenResponse
func (client *Client) GetYongYouOpenApiTokenWithOptions(request *GetYongYouOpenApiTokenRequest, headers *GetYongYouOpenApiTokenHeaders, runtime *util.RuntimeOptions) (_result *GetYongYouOpenApiTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("GetYongYouOpenApiToken"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/yongyou/token"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetYongYouOpenApiTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取用友开放平台接口鉴权信息
//
// @param request - GetYongYouOpenApiTokenRequest
//
// @return GetYongYouOpenApiTokenResponse
func (client *Client) GetYongYouOpenApiToken(request *GetYongYouOpenApiTokenRequest) (_result *GetYongYouOpenApiTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetYongYouOpenApiTokenHeaders{}
	_result = &GetYongYouOpenApiTokenResponse{}
	_body, _err := client.GetYongYouOpenApiTokenWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询钉钉组织绑定的畅捷通组织
//
// @param headers - GetYongYouOrgRelationHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetYongYouOrgRelationResponse
func (client *Client) GetYongYouOrgRelationWithOptions(headers *GetYongYouOrgRelationHeaders, runtime *util.RuntimeOptions) (_result *GetYongYouOrgRelationResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("GetYongYouOrgRelation"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/yongyou/relations"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetYongYouOrgRelationResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询钉钉组织绑定的畅捷通组织
//
// @return GetYongYouOrgRelationResponse
func (client *Client) GetYongYouOrgRelation() (_result *GetYongYouOrgRelationResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetYongYouOrgRelationHeaders{}
	_result = &GetYongYouOrgRelationResponse{}
	_body, _err := client.GetYongYouOrgRelationWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 权益核销
//
// @param request - ProfessionBenefitConsumeRequest
//
// @param headers - ProfessionBenefitConsumeHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return ProfessionBenefitConsumeResponse
func (client *Client) ProfessionBenefitConsumeWithOptions(request *ProfessionBenefitConsumeRequest, headers *ProfessionBenefitConsumeHeaders, runtime *util.RuntimeOptions) (_result *ProfessionBenefitConsumeResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BenefitCode)) {
		body["benefitCode"] = request.BenefitCode
	}

	if !tea.BoolValue(util.IsUnset(request.BizRequestId)) {
		body["bizRequestId"] = request.BizRequestId
	}

	if !tea.BoolValue(util.IsUnset(request.Quota)) {
		body["quota"] = request.Quota
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("ProfessionBenefitConsume"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/professions/benefits/consume"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &ProfessionBenefitConsumeResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 权益核销
//
// @param request - ProfessionBenefitConsumeRequest
//
// @return ProfessionBenefitConsumeResponse
func (client *Client) ProfessionBenefitConsume(request *ProfessionBenefitConsumeRequest) (_result *ProfessionBenefitConsumeResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &ProfessionBenefitConsumeHeaders{}
	_result = &ProfessionBenefitConsumeResponse{}
	_body, _err := client.ProfessionBenefitConsumeWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 触发单据同步给有成
//
// @param request - PushHistoricalReceiptsRequest
//
// @param headers - PushHistoricalReceiptsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return PushHistoricalReceiptsResponse
func (client *Client) PushHistoricalReceiptsWithOptions(request *PushHistoricalReceiptsRequest, headers *PushHistoricalReceiptsHeaders, runtime *util.RuntimeOptions) (_result *PushHistoricalReceiptsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BizId)) {
		body["bizId"] = request.BizId
	}

	if !tea.BoolValue(util.IsUnset(request.EndTime)) {
		body["endTime"] = request.EndTime
	}

	if !tea.BoolValue(util.IsUnset(request.ForcedIgnoreDup)) {
		body["forcedIgnoreDup"] = request.ForcedIgnoreDup
	}

	if !tea.BoolValue(util.IsUnset(request.FormCodeList)) {
		body["formCodeList"] = request.FormCodeList
	}

	if !tea.BoolValue(util.IsUnset(request.StartTime)) {
		body["startTime"] = request.StartTime
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("PushHistoricalReceipts"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/budgets/historicalReceipts/push"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &PushHistoricalReceiptsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 触发单据同步给有成
//
// @param request - PushHistoricalReceiptsRequest
//
// @return PushHistoricalReceiptsResponse
func (client *Client) PushHistoricalReceipts(request *PushHistoricalReceiptsRequest) (_result *PushHistoricalReceiptsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &PushHistoricalReceiptsHeaders{}
	_result = &PushHistoricalReceiptsResponse{}
	_body, _err := client.PushHistoricalReceiptsWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询智能财务计量型权益
//
// @param request - QueryBenefitRequest
//
// @param headers - QueryBenefitHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryBenefitResponse
func (client *Client) QueryBenefitWithOptions(request *QueryBenefitRequest, headers *QueryBenefitHeaders, runtime *util.RuntimeOptions) (_result *QueryBenefitResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BenefitCode)) {
		query["benefitCode"] = request.BenefitCode
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryBenefit"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/benefits"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryBenefitResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询智能财务计量型权益
//
// @param request - QueryBenefitRequest
//
// @return QueryBenefitResponse
func (client *Client) QueryBenefit(request *QueryBenefitRequest) (_result *QueryBenefitResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryBenefitHeaders{}
	_result = &QueryBenefitResponse{}
	_body, _err := client.QueryBenefitWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量获取费用类别
//
// @param request - QueryCategoryByPageRequest
//
// @param headers - QueryCategoryByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryCategoryByPageResponse
func (client *Client) QueryCategoryByPageWithOptions(request *QueryCategoryByPageRequest, headers *QueryCategoryByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryCategoryByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	if !tea.BoolValue(util.IsUnset(request.Type)) {
		query["type"] = request.Type
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryCategoryByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/categories/list"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryCategoryByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量获取费用类别
//
// @param request - QueryCategoryByPageRequest
//
// @return QueryCategoryByPageResponse
func (client *Client) QueryCategoryByPage(request *QueryCategoryByPageRequest) (_result *QueryCategoryByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryCategoryByPageHeaders{}
	_result = &QueryCategoryByPageResponse{}
	_body, _err := client.QueryCategoryByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询某个主体的开票申请单的提单数量
//
// @param request - QueryCompanyInvoiceRelationCountRequest
//
// @param headers - QueryCompanyInvoiceRelationCountHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryCompanyInvoiceRelationCountResponse
func (client *Client) QueryCompanyInvoiceRelationCountWithOptions(request *QueryCompanyInvoiceRelationCountRequest, headers *QueryCompanyInvoiceRelationCountHeaders, runtime *util.RuntimeOptions) (_result *QueryCompanyInvoiceRelationCountResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		query["companyCode"] = request.CompanyCode
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryCompanyInvoiceRelationCount"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/companyRelationReceipts/counts"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryCompanyInvoiceRelationCountResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询某个主体的开票申请单的提单数量
//
// @param request - QueryCompanyInvoiceRelationCountRequest
//
// @return QueryCompanyInvoiceRelationCountResponse
func (client *Client) QueryCompanyInvoiceRelationCount(request *QueryCompanyInvoiceRelationCountRequest) (_result *QueryCompanyInvoiceRelationCountResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryCompanyInvoiceRelationCountHeaders{}
	_result = &QueryCompanyInvoiceRelationCountResponse{}
	_body, _err := client.QueryCompanyInvoiceRelationCountWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 分页批量获取智能财务应用内维护的客户信息
//
// @param request - QueryCustomerByPageRequest
//
// @param headers - QueryCustomerByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryCustomerByPageResponse
func (client *Client) QueryCustomerByPageWithOptions(request *QueryCustomerByPageRequest, headers *QueryCustomerByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryCustomerByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryCustomerByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/customers"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryCustomerByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 分页批量获取智能财务应用内维护的客户信息
//
// @param request - QueryCustomerByPageRequest
//
// @return QueryCustomerByPageResponse
func (client *Client) QueryCustomerByPage(request *QueryCustomerByPageRequest) (_result *QueryCustomerByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryCustomerByPageHeaders{}
	_result = &QueryCustomerByPageResponse{}
	_body, _err := client.QueryCustomerByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 提供给合作伙伴，查询智能财务的客户配置信息
//
// @param request - QueryCustomerInfoRequest
//
// @param headers - QueryCustomerInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryCustomerInfoResponse
func (client *Client) QueryCustomerInfoWithOptions(request *QueryCustomerInfoRequest, headers *QueryCustomerInfoHeaders, runtime *util.RuntimeOptions) (_result *QueryCustomerInfoResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Keyword)) {
		query["keyword"] = request.Keyword
	}

	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryCustomerInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/auxiliaries/customers"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryCustomerInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 提供给合作伙伴，查询智能财务的客户配置信息
//
// @param request - QueryCustomerInfoRequest
//
// @return QueryCustomerInfoResponse
func (client *Client) QueryCustomerInfo(request *QueryCustomerInfoRequest) (_result *QueryCustomerInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryCustomerInfoHeaders{}
	_result = &QueryCustomerInfoResponse{}
	_body, _err := client.QueryCustomerInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量获取企业账户
//
// @param request - QueryEnterpriseAccountByPageRequest
//
// @param headers - QueryEnterpriseAccountByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryEnterpriseAccountByPageResponse
func (client *Client) QueryEnterpriseAccountByPageWithOptions(request *QueryEnterpriseAccountByPageRequest, headers *QueryEnterpriseAccountByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryEnterpriseAccountByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryEnterpriseAccountByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/financeAccounts/list"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryEnterpriseAccountByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量获取企业账户
//
// @param request - QueryEnterpriseAccountByPageRequest
//
// @return QueryEnterpriseAccountByPageResponse
func (client *Client) QueryEnterpriseAccountByPage(request *QueryEnterpriseAccountByPageRequest) (_result *QueryEnterpriseAccountByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryEnterpriseAccountByPageHeaders{}
	_result = &QueryEnterpriseAccountByPageResponse{}
	_body, _err := client.QueryEnterpriseAccountByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询智能财务配置的企业信息
//
// @param headers - QueryFinanceCompanyInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryFinanceCompanyInfoResponse
func (client *Client) QueryFinanceCompanyInfoWithOptions(headers *QueryFinanceCompanyInfoHeaders, runtime *util.RuntimeOptions) (_result *QueryFinanceCompanyInfoResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("QueryFinanceCompanyInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/companies"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryFinanceCompanyInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询智能财务配置的企业信息
//
// @return QueryFinanceCompanyInfoResponse
func (client *Client) QueryFinanceCompanyInfo() (_result *QueryFinanceCompanyInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryFinanceCompanyInfoHeaders{}
	_result = &QueryFinanceCompanyInfoResponse{}
	_body, _err := client.QueryFinanceCompanyInfoWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询开票申请单的提单数量
//
// @param headers - QueryInvoiceRelationCountHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryInvoiceRelationCountResponse
func (client *Client) QueryInvoiceRelationCountWithOptions(headers *QueryInvoiceRelationCountHeaders, runtime *util.RuntimeOptions) (_result *QueryInvoiceRelationCountResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("QueryInvoiceRelationCount"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/relationReceipts/counts"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryInvoiceRelationCountResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询开票申请单的提单数量
//
// @return QueryInvoiceRelationCountResponse
func (client *Client) QueryInvoiceRelationCount() (_result *QueryInvoiceRelationCountResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryInvoiceRelationCountHeaders{}
	_result = &QueryInvoiceRelationCountResponse{}
	_body, _err := client.QueryInvoiceRelationCountWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询钉钉智能财务多主体信息
//
// @param headers - QueryMultiCompanyInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryMultiCompanyInfoResponse
func (client *Client) QueryMultiCompanyInfoWithOptions(headers *QueryMultiCompanyInfoHeaders, runtime *util.RuntimeOptions) (_result *QueryMultiCompanyInfoResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	params := &openapi.Params{
		Action:      tea.String("QueryMultiCompanyInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/multiCompanies"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryMultiCompanyInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询钉钉智能财务多主体信息
//
// @return QueryMultiCompanyInfoResponse
func (client *Client) QueryMultiCompanyInfo() (_result *QueryMultiCompanyInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryMultiCompanyInfoHeaders{}
	_result = &QueryMultiCompanyInfoResponse{}
	_body, _err := client.QueryMultiCompanyInfoWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 提供给小望，查询当前用户所具有的的小望权限点信息
//
// @param request - QueryPermissionByUserIdRequest
//
// @param headers - QueryPermissionByUserIdHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryPermissionByUserIdResponse
func (client *Client) QueryPermissionByUserIdWithOptions(request *QueryPermissionByUserIdRequest, headers *QueryPermissionByUserIdHeaders, runtime *util.RuntimeOptions) (_result *QueryPermissionByUserIdResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		query["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryPermissionByUserId"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/permissions"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryPermissionByUserIdResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 提供给小望，查询当前用户所具有的的小望权限点信息
//
// @param request - QueryPermissionByUserIdRequest
//
// @return QueryPermissionByUserIdResponse
func (client *Client) QueryPermissionByUserId(request *QueryPermissionByUserIdRequest) (_result *QueryPermissionByUserIdResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryPermissionByUserIdHeaders{}
	_result = &QueryPermissionByUserIdResponse{}
	_body, _err := client.QueryPermissionByUserIdWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询智能财务角色下的成员信息
//
// @param request - QueryPermissionRoleMemberRequest
//
// @param headers - QueryPermissionRoleMemberHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryPermissionRoleMemberResponse
func (client *Client) QueryPermissionRoleMemberWithOptions(request *QueryPermissionRoleMemberRequest, headers *QueryPermissionRoleMemberHeaders, runtime *util.RuntimeOptions) (_result *QueryPermissionRoleMemberResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.RoleCodeList)) {
		body["roleCodeList"] = request.RoleCodeList
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryPermissionRoleMember"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/roles/members/query"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryPermissionRoleMemberResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询智能财务角色下的成员信息
//
// @param request - QueryPermissionRoleMemberRequest
//
// @return QueryPermissionRoleMemberResponse
func (client *Client) QueryPermissionRoleMember(request *QueryPermissionRoleMemberRequest) (_result *QueryPermissionRoleMemberResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryPermissionRoleMemberHeaders{}
	_result = &QueryPermissionRoleMemberResponse{}
	_body, _err := client.QueryPermissionRoleMemberWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量获取商品信息
//
// @param request - QueryProductByPageRequest
//
// @param headers - QueryProductByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryProductByPageResponse
func (client *Client) QueryProductByPageWithOptions(request *QueryProductByPageRequest, headers *QueryProductByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryProductByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryProductByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/products/query"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryProductByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量获取商品信息
//
// @param request - QueryProductByPageRequest
//
// @return QueryProductByPageResponse
func (client *Client) QueryProductByPage(request *QueryProductByPageRequest) (_result *QueryProductByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryProductByPageHeaders{}
	_result = &QueryProductByPageResponse{}
	_body, _err := client.QueryProductByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量获取项目信息
//
// @param request - QueryProjectByPageRequest
//
// @param headers - QueryProjectByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryProjectByPageResponse
func (client *Client) QueryProjectByPageWithOptions(request *QueryProjectByPageRequest, headers *QueryProjectByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryProjectByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryProjectByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/projects/list"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryProjectByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量获取项目信息
//
// @param request - QueryProjectByPageRequest
//
// @return QueryProjectByPageResponse
func (client *Client) QueryProjectByPage(request *QueryProjectByPageRequest) (_result *QueryProjectByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryProjectByPageHeaders{}
	_result = &QueryProjectByPageResponse{}
	_body, _err := client.QueryProjectByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询开票申请单详情
//
// @param request - QueryReceiptDetailForInvoiceRequest
//
// @param headers - QueryReceiptDetailForInvoiceHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryReceiptDetailForInvoiceResponse
func (client *Client) QueryReceiptDetailForInvoiceWithOptions(request *QueryReceiptDetailForInvoiceRequest, headers *QueryReceiptDetailForInvoiceHeaders, runtime *util.RuntimeOptions) (_result *QueryReceiptDetailForInvoiceResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.InstanceId)) {
		query["instanceId"] = request.InstanceId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryReceiptDetailForInvoice"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/receipts/details"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryReceiptDetailForInvoiceResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询开票申请单详情
//
// @param request - QueryReceiptDetailForInvoiceRequest
//
// @return QueryReceiptDetailForInvoiceResponse
func (client *Client) QueryReceiptDetailForInvoice(request *QueryReceiptDetailForInvoiceRequest) (_result *QueryReceiptDetailForInvoiceResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryReceiptDetailForInvoiceHeaders{}
	_result = &QueryReceiptDetailForInvoiceResponse{}
	_body, _err := client.QueryReceiptDetailForInvoiceWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量查询智能财务单据主数据信息
//
// @param request - QueryReceiptForInvoiceRequest
//
// @param headers - QueryReceiptForInvoiceHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryReceiptForInvoiceResponse
func (client *Client) QueryReceiptForInvoiceWithOptions(request *QueryReceiptForInvoiceRequest, headers *QueryReceiptForInvoiceHeaders, runtime *util.RuntimeOptions) (_result *QueryReceiptForInvoiceResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountantBookId)) {
		body["accountantBookId"] = request.AccountantBookId
	}

	if !tea.BoolValue(util.IsUnset(request.ApplyStatusList)) {
		body["applyStatusList"] = request.ApplyStatusList
	}

	if !tea.BoolValue(util.IsUnset(request.BizStatusList)) {
		body["bizStatusList"] = request.BizStatusList
	}

	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.EndTime)) {
		body["endTime"] = request.EndTime
	}

	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		body["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		body["pageSize"] = request.PageSize
	}

	if !tea.BoolValue(util.IsUnset(request.ReceiptStatusList)) {
		body["receiptStatusList"] = request.ReceiptStatusList
	}

	if !tea.BoolValue(util.IsUnset(request.SearchParams)) {
		body["searchParams"] = request.SearchParams
	}

	if !tea.BoolValue(util.IsUnset(request.StartTime)) {
		body["startTime"] = request.StartTime
	}

	if !tea.BoolValue(util.IsUnset(request.Title)) {
		body["title"] = request.Title
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryReceiptForInvoice"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/receipts/query"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryReceiptForInvoiceResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量查询智能财务单据主数据信息
//
// @param request - QueryReceiptForInvoiceRequest
//
// @return QueryReceiptForInvoiceResponse
func (client *Client) QueryReceiptForInvoice(request *QueryReceiptForInvoiceRequest) (_result *QueryReceiptForInvoiceResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryReceiptForInvoiceHeaders{}
	_result = &QueryReceiptForInvoiceResponse{}
	_body, _err := client.QueryReceiptForInvoiceWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 批量查询智能财务的单据主数据基本信息
//
// @param request - QueryReceiptsBaseInfoRequest
//
// @param headers - QueryReceiptsBaseInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryReceiptsBaseInfoResponse
func (client *Client) QueryReceiptsBaseInfoWithOptions(request *QueryReceiptsBaseInfoRequest, headers *QueryReceiptsBaseInfoHeaders, runtime *util.RuntimeOptions) (_result *QueryReceiptsBaseInfoResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountantBookId)) {
		query["accountantBookId"] = request.AccountantBookId
	}

	if !tea.BoolValue(util.IsUnset(request.AmountEnd)) {
		query["amountEnd"] = request.AmountEnd
	}

	if !tea.BoolValue(util.IsUnset(request.AmountStart)) {
		query["amountStart"] = request.AmountStart
	}

	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		query["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.EndTime)) {
		query["endTime"] = request.EndTime
	}

	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	if !tea.BoolValue(util.IsUnset(request.StartTime)) {
		query["startTime"] = request.StartTime
	}

	if !tea.BoolValue(util.IsUnset(request.TimeFilterField)) {
		query["timeFilterField"] = request.TimeFilterField
	}

	if !tea.BoolValue(util.IsUnset(request.Title)) {
		query["title"] = request.Title
	}

	if !tea.BoolValue(util.IsUnset(request.VoucherStatus)) {
		query["voucherStatus"] = request.VoucherStatus
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryReceiptsBaseInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/receipts/dataInfos"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryReceiptsBaseInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 批量查询智能财务的单据主数据基本信息
//
// @param request - QueryReceiptsBaseInfoRequest
//
// @return QueryReceiptsBaseInfoResponse
func (client *Client) QueryReceiptsBaseInfo(request *QueryReceiptsBaseInfoRequest) (_result *QueryReceiptsBaseInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryReceiptsBaseInfoHeaders{}
	_result = &QueryReceiptsBaseInfoResponse{}
	_body, _err := client.QueryReceiptsBaseInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 分页获取智能财务单据详情列表
//
// @param request - QueryReceiptsByPageRequest
//
// @param headers - QueryReceiptsByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryReceiptsByPageResponse
func (client *Client) QueryReceiptsByPageWithOptions(request *QueryReceiptsByPageRequest, headers *QueryReceiptsByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryReceiptsByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.EndTime)) {
		query["endTime"] = request.EndTime
	}

	if !tea.BoolValue(util.IsUnset(request.ModelId)) {
		query["modelId"] = request.ModelId
	}

	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	if !tea.BoolValue(util.IsUnset(request.StartTime)) {
		query["startTime"] = request.StartTime
	}

	if !tea.BoolValue(util.IsUnset(request.TimeFilterField)) {
		query["timeFilterField"] = request.TimeFilterField
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryReceiptsByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/receipts"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryReceiptsByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 分页获取智能财务单据详情列表
//
// @param request - QueryReceiptsByPageRequest
//
// @return QueryReceiptsByPageResponse
func (client *Client) QueryReceiptsByPage(request *QueryReceiptsByPageRequest) (_result *QueryReceiptsByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryReceiptsByPageHeaders{}
	_result = &QueryReceiptsByPageResponse{}
	_body, _err := client.QueryReceiptsByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 分页查询智能财务角色下的成员信息
//
// @param request - QueryRoleMemberByPageRequest
//
// @param headers - QueryRoleMemberByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryRoleMemberByPageResponse
func (client *Client) QueryRoleMemberByPageWithOptions(request *QueryRoleMemberByPageRequest, headers *QueryRoleMemberByPageHeaders, runtime *util.RuntimeOptions) (_result *QueryRoleMemberByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		query["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		query["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		query["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.RoleCode)) {
		query["roleCode"] = request.RoleCode
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryRoleMemberByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/roles/members"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryRoleMemberByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 分页查询智能财务角色下的成员信息
//
// @param request - QueryRoleMemberByPageRequest
//
// @return QueryRoleMemberByPageResponse
func (client *Client) QueryRoleMemberByPage(request *QueryRoleMemberByPageRequest) (_result *QueryRoleMemberByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryRoleMemberByPageHeaders{}
	_result = &QueryRoleMemberByPageResponse{}
	_body, _err := client.QueryRoleMemberByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 分页批量获取智能财务应用内维护的供应商信息
//
// @param request - QuerySupplierByPageRequest
//
// @param headers - QuerySupplierByPageHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QuerySupplierByPageResponse
func (client *Client) QuerySupplierByPageWithOptions(request *QuerySupplierByPageRequest, headers *QuerySupplierByPageHeaders, runtime *util.RuntimeOptions) (_result *QuerySupplierByPageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.PageNumber)) {
		query["pageNumber"] = request.PageNumber
	}

	if !tea.BoolValue(util.IsUnset(request.PageSize)) {
		query["pageSize"] = request.PageSize
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QuerySupplierByPage"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/suppliers"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QuerySupplierByPageResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 分页批量获取智能财务应用内维护的供应商信息
//
// @param request - QuerySupplierByPageRequest
//
// @return QuerySupplierByPageResponse
func (client *Client) QuerySupplierByPage(request *QuerySupplierByPageRequest) (_result *QuerySupplierByPageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QuerySupplierByPageHeaders{}
	_result = &QuerySupplierByPageResponse{}
	_body, _err := client.QuerySupplierByPageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询用户角色
//
// @param request - QueryUserRoleListRequest
//
// @param headers - QueryUserRoleListHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return QueryUserRoleListResponse
func (client *Client) QueryUserRoleListWithOptions(request *QueryUserRoleListRequest, headers *QueryUserRoleListHeaders, runtime *util.RuntimeOptions) (_result *QueryUserRoleListResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("QueryUserRoleList"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/users/roles"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &QueryUserRoleListResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询用户角色
//
// @param request - QueryUserRoleListRequest
//
// @return QueryUserRoleListResponse
func (client *Client) QueryUserRoleList(request *QueryUserRoleListRequest) (_result *QueryUserRoleListResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryUserRoleListHeaders{}
	_result = &QueryUserRoleListResponse{}
	_body, _err := client.QueryUserRoleListWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 解绑开票申请单关联的发票
//
// @param request - UnbindApplyReceiptAndInvoiceRelatedRequest
//
// @param headers - UnbindApplyReceiptAndInvoiceRelatedHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UnbindApplyReceiptAndInvoiceRelatedResponse
func (client *Client) UnbindApplyReceiptAndInvoiceRelatedWithOptions(request *UnbindApplyReceiptAndInvoiceRelatedRequest, headers *UnbindApplyReceiptAndInvoiceRelatedHeaders, runtime *util.RuntimeOptions) (_result *UnbindApplyReceiptAndInvoiceRelatedResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.InstanceId)) {
		body["instanceId"] = request.InstanceId
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceKeyVOList)) {
		body["invoiceKeyVOList"] = request.InvoiceKeyVOList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UnbindApplyReceiptAndInvoiceRelated"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/unbind"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UnbindApplyReceiptAndInvoiceRelatedResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 解绑开票申请单关联的发票
//
// @param request - UnbindApplyReceiptAndInvoiceRelatedRequest
//
// @return UnbindApplyReceiptAndInvoiceRelatedResponse
func (client *Client) UnbindApplyReceiptAndInvoiceRelated(request *UnbindApplyReceiptAndInvoiceRelatedRequest) (_result *UnbindApplyReceiptAndInvoiceRelatedResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UnbindApplyReceiptAndInvoiceRelatedHeaders{}
	_result = &UnbindApplyReceiptAndInvoiceRelatedResponse{}
	_body, _err := client.UnbindApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 开票申请单关联发票
//
// @param request - UpdateApplyReceiptAndInvoiceRelatedRequest
//
// @param headers - UpdateApplyReceiptAndInvoiceRelatedHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateApplyReceiptAndInvoiceRelatedResponse
func (client *Client) UpdateApplyReceiptAndInvoiceRelatedWithOptions(request *UpdateApplyReceiptAndInvoiceRelatedRequest, headers *UpdateApplyReceiptAndInvoiceRelatedHeaders, runtime *util.RuntimeOptions) (_result *UpdateApplyReceiptAndInvoiceRelatedResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.GeneralInvoiceVOList)) {
		body["generalInvoiceVOList"] = request.GeneralInvoiceVOList
	}

	if !tea.BoolValue(util.IsUnset(request.InstanceId)) {
		body["instanceId"] = request.InstanceId
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateApplyReceiptAndInvoiceRelated"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/applyReceipts/relate"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateApplyReceiptAndInvoiceRelatedResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 开票申请单关联发票
//
// @param request - UpdateApplyReceiptAndInvoiceRelatedRequest
//
// @return UpdateApplyReceiptAndInvoiceRelatedResponse
func (client *Client) UpdateApplyReceiptAndInvoiceRelated(request *UpdateApplyReceiptAndInvoiceRelatedRequest) (_result *UpdateApplyReceiptAndInvoiceRelatedResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateApplyReceiptAndInvoiceRelatedHeaders{}
	_result = &UpdateApplyReceiptAndInvoiceRelatedResponse{}
	_body, _err := client.UpdateApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新全电发票企业信息
//
// @param request - UpdateDigitalInvoiceOrgInfoRequest
//
// @param headers - UpdateDigitalInvoiceOrgInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateDigitalInvoiceOrgInfoResponse
func (client *Client) UpdateDigitalInvoiceOrgInfoWithOptions(request *UpdateDigitalInvoiceOrgInfoRequest, headers *UpdateDigitalInvoiceOrgInfoHeaders, runtime *util.RuntimeOptions) (_result *UpdateDigitalInvoiceOrgInfoResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.DigitalInvoiceType)) {
		body["digitalInvoiceType"] = request.DigitalInvoiceType
	}

	if !tea.BoolValue(util.IsUnset(request.IsDigitalOrg)) {
		body["isDigitalOrg"] = request.IsDigitalOrg
	}

	if !tea.BoolValue(util.IsUnset(request.Location)) {
		body["location"] = request.Location
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateDigitalInvoiceOrgInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/organizationInfos"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateDigitalInvoiceOrgInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新全电发票企业信息
//
// @param request - UpdateDigitalInvoiceOrgInfoRequest
//
// @return UpdateDigitalInvoiceOrgInfoResponse
func (client *Client) UpdateDigitalInvoiceOrgInfo(request *UpdateDigitalInvoiceOrgInfoRequest) (_result *UpdateDigitalInvoiceOrgInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateDigitalInvoiceOrgInfoHeaders{}
	_result = &UpdateDigitalInvoiceOrgInfoResponse{}
	_body, _err := client.UpdateDigitalInvoiceOrgInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新智能财务配置的企业信息
//
// @param request - UpdateFinanceCompanyInfoRequest
//
// @param headers - UpdateFinanceCompanyInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateFinanceCompanyInfoResponse
func (client *Client) UpdateFinanceCompanyInfoWithOptions(request *UpdateFinanceCompanyInfoRequest, headers *UpdateFinanceCompanyInfoHeaders, runtime *util.RuntimeOptions) (_result *UpdateFinanceCompanyInfoResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyName)) {
		query["companyName"] = request.CompanyName
	}

	if !tea.BoolValue(util.IsUnset(request.TaxNature)) {
		query["taxNature"] = request.TaxNature
	}

	if !tea.BoolValue(util.IsUnset(request.TaxNo)) {
		query["taxNo"] = request.TaxNo
	}

	if !tea.BoolValue(util.IsUnset(request.TaxOrInvoiceHasInit)) {
		query["taxOrInvoiceHasInit"] = request.TaxOrInvoiceHasInit
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateFinanceCompanyInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/companies"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateFinanceCompanyInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新智能财务配置的企业信息
//
// @param request - UpdateFinanceCompanyInfoRequest
//
// @return UpdateFinanceCompanyInfoResponse
func (client *Client) UpdateFinanceCompanyInfo(request *UpdateFinanceCompanyInfoRequest) (_result *UpdateFinanceCompanyInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateFinanceCompanyInfoHeaders{}
	_result = &UpdateFinanceCompanyInfoResponse{}
	_body, _err := client.UpdateFinanceCompanyInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新钉钉智能财务多主体信息
//
// @param request - UpdateFinanceMultiCompanyInfoRequest
//
// @param headers - UpdateFinanceMultiCompanyInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateFinanceMultiCompanyInfoResponse
func (client *Client) UpdateFinanceMultiCompanyInfoWithOptions(request *UpdateFinanceMultiCompanyInfoRequest, headers *UpdateFinanceMultiCompanyInfoHeaders, runtime *util.RuntimeOptions) (_result *UpdateFinanceMultiCompanyInfoResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		query["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.CompanyName)) {
		query["companyName"] = request.CompanyName
	}

	if !tea.BoolValue(util.IsUnset(request.TaxNature)) {
		query["taxNature"] = request.TaxNature
	}

	if !tea.BoolValue(util.IsUnset(request.TaxNo)) {
		query["taxNo"] = request.TaxNo
	}

	if !tea.BoolValue(util.IsUnset(request.TaxOrInvoiceHasInit)) {
		query["taxOrInvoiceHasInit"] = request.TaxOrInvoiceHasInit
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		query["userId"] = request.UserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateFinanceMultiCompanyInfo"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/multiCompanies"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateFinanceMultiCompanyInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新钉钉智能财务多主体信息
//
// @param request - UpdateFinanceMultiCompanyInfoRequest
//
// @return UpdateFinanceMultiCompanyInfoResponse
func (client *Client) UpdateFinanceMultiCompanyInfo(request *UpdateFinanceMultiCompanyInfoRequest) (_result *UpdateFinanceMultiCompanyInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateFinanceMultiCompanyInfoHeaders{}
	_result = &UpdateFinanceMultiCompanyInfoResponse{}
	_body, _err := client.UpdateFinanceMultiCompanyInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 发票红冲/废弃状态变更接口
//
// @param request - UpdateInvoiceAbandonStatusRequest
//
// @param headers - UpdateInvoiceAbandonStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceAbandonStatusResponse
func (client *Client) UpdateInvoiceAbandonStatusWithOptions(request *UpdateInvoiceAbandonStatusRequest, headers *UpdateInvoiceAbandonStatusHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceAbandonStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.BlueGeneralInvoiceVO)) {
		body["blueGeneralInvoiceVO"] = request.BlueGeneralInvoiceVO
	}

	if !tea.BoolValue(util.IsUnset(request.BlueInvoiceCode)) {
		body["blueInvoiceCode"] = request.BlueInvoiceCode
	}

	if !tea.BoolValue(util.IsUnset(request.BlueInvoiceNo)) {
		body["blueInvoiceNo"] = request.BlueInvoiceNo
	}

	if !tea.BoolValue(util.IsUnset(request.BlueInvoiceStatus)) {
		body["blueInvoiceStatus"] = request.BlueInvoiceStatus
	}

	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	if !tea.BoolValue(util.IsUnset(request.RedGeneralInvoiceVO)) {
		body["redGeneralInvoiceVO"] = request.RedGeneralInvoiceVO
	}

	if !tea.BoolValue(util.IsUnset(request.RedInvoiceCode)) {
		body["redInvoiceCode"] = request.RedInvoiceCode
	}

	if !tea.BoolValue(util.IsUnset(request.RedInvoiceNo)) {
		body["redInvoiceNo"] = request.RedInvoiceNo
	}

	if !tea.BoolValue(util.IsUnset(request.RedInvoiceStatus)) {
		body["redInvoiceStatus"] = request.RedInvoiceStatus
	}

	if !tea.BoolValue(util.IsUnset(request.TargetInvoice)) {
		body["targetInvoice"] = request.TargetInvoice
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceAbandonStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/abandonStatus"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceAbandonStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 发票红冲/废弃状态变更接口
//
// @param request - UpdateInvoiceAbandonStatusRequest
//
// @return UpdateInvoiceAbandonStatusResponse
func (client *Client) UpdateInvoiceAbandonStatus(request *UpdateInvoiceAbandonStatusRequest) (_result *UpdateInvoiceAbandonStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceAbandonStatusHeaders{}
	_result = &UpdateInvoiceAbandonStatusResponse{}
	_body, _err := client.UpdateInvoiceAbandonStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新发票账期状态
//
// @param request - UpdateInvoiceAccountPeriodRequest
//
// @param headers - UpdateInvoiceAccountPeriodHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceAccountPeriodResponse
func (client *Client) UpdateInvoiceAccountPeriodWithOptions(request *UpdateInvoiceAccountPeriodRequest, headers *UpdateInvoiceAccountPeriodHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceAccountPeriodResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountPeriod)) {
		body["accountPeriod"] = request.AccountPeriod
	}

	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.GeneralInvoiceVOList)) {
		body["generalInvoiceVOList"] = request.GeneralInvoiceVOList
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceKeyVOList)) {
		body["invoiceKeyVOList"] = request.InvoiceKeyVOList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceAccountPeriod"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/accountPeriods"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceAccountPeriodResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新发票账期状态
//
// @param request - UpdateInvoiceAccountPeriodRequest
//
// @return UpdateInvoiceAccountPeriodResponse
func (client *Client) UpdateInvoiceAccountPeriod(request *UpdateInvoiceAccountPeriodRequest) (_result *UpdateInvoiceAccountPeriodResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceAccountPeriodHeaders{}
	_result = &UpdateInvoiceAccountPeriodResponse{}
	_body, _err := client.UpdateInvoiceAccountPeriodWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新全电企业入账时间
//
// @param request - UpdateInvoiceAccountingPeriodDateRequest
//
// @param headers - UpdateInvoiceAccountingPeriodDateHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceAccountingPeriodDateResponse
func (client *Client) UpdateInvoiceAccountingPeriodDateWithOptions(request *UpdateInvoiceAccountingPeriodDateRequest, headers *UpdateInvoiceAccountingPeriodDateHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceAccountingPeriodDateResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceFinanceInfoVOList)) {
		body["invoiceFinanceInfoVOList"] = request.InvoiceFinanceInfoVOList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceAccountingPeriodDate"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/accounts/periodDates"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceAccountingPeriodDateResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新全电企业入账时间
//
// @param request - UpdateInvoiceAccountingPeriodDateRequest
//
// @return UpdateInvoiceAccountingPeriodDateResponse
func (client *Client) UpdateInvoiceAccountingPeriodDate(request *UpdateInvoiceAccountingPeriodDateRequest) (_result *UpdateInvoiceAccountingPeriodDateResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceAccountingPeriodDateHeaders{}
	_result = &UpdateInvoiceAccountingPeriodDateResponse{}
	_body, _err := client.UpdateInvoiceAccountingPeriodDateWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新全电企业入账状态
//
// @param request - UpdateInvoiceAccountingStatusRequest
//
// @param headers - UpdateInvoiceAccountingStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceAccountingStatusResponse
func (client *Client) UpdateInvoiceAccountingStatusWithOptions(request *UpdateInvoiceAccountingStatusRequest, headers *UpdateInvoiceAccountingStatusHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceAccountingStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceFinanceInfoVOList)) {
		body["invoiceFinanceInfoVOList"] = request.InvoiceFinanceInfoVOList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceAccountingStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/accounts/statuses"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceAccountingStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新全电企业入账状态
//
// @param request - UpdateInvoiceAccountingStatusRequest
//
// @return UpdateInvoiceAccountingStatusResponse
func (client *Client) UpdateInvoiceAccountingStatus(request *UpdateInvoiceAccountingStatusRequest) (_result *UpdateInvoiceAccountingStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceAccountingStatusHeaders{}
	_result = &UpdateInvoiceAccountingStatusResponse{}
	_body, _err := client.UpdateInvoiceAccountingStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新发票关联审批单
//
// @param request - UpdateInvoiceAndReceiptRelatedRequest
//
// @param headers - UpdateInvoiceAndReceiptRelatedHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceAndReceiptRelatedResponse
func (client *Client) UpdateInvoiceAndReceiptRelatedWithOptions(request *UpdateInvoiceAndReceiptRelatedRequest, headers *UpdateInvoiceAndReceiptRelatedHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceAndReceiptRelatedResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.GeneralInvoiceVO)) {
		body["generalInvoiceVO"] = request.GeneralInvoiceVO
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceCode)) {
		body["invoiceCode"] = request.InvoiceCode
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceNo)) {
		body["invoiceNo"] = request.InvoiceNo
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	if !tea.BoolValue(util.IsUnset(request.ReceiptCode)) {
		body["receiptCode"] = request.ReceiptCode
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceAndReceiptRelated"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/approvalReceipts"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceAndReceiptRelatedResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新发票关联审批单
//
// @param request - UpdateInvoiceAndReceiptRelatedRequest
//
// @return UpdateInvoiceAndReceiptRelatedResponse
func (client *Client) UpdateInvoiceAndReceiptRelated(request *UpdateInvoiceAndReceiptRelatedRequest) (_result *UpdateInvoiceAndReceiptRelatedResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceAndReceiptRelatedHeaders{}
	_result = &UpdateInvoiceAndReceiptRelatedResponse{}
	_body, _err := client.UpdateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新发票忽略状态
//
// @param request - UpdateInvoiceIgnoreStatusRequest
//
// @param headers - UpdateInvoiceIgnoreStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceIgnoreStatusResponse
func (client *Client) UpdateInvoiceIgnoreStatusWithOptions(request *UpdateInvoiceIgnoreStatusRequest, headers *UpdateInvoiceIgnoreStatusHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceIgnoreStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.InstanceId)) {
		query["instanceId"] = request.InstanceId
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		query["operator"] = request.Operator
	}

	if !tea.BoolValue(util.IsUnset(request.Status)) {
		query["status"] = request.Status
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceIgnoreStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/ignoreStatus"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceIgnoreStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新发票忽略状态
//
// @param request - UpdateInvoiceIgnoreStatusRequest
//
// @return UpdateInvoiceIgnoreStatusResponse
func (client *Client) UpdateInvoiceIgnoreStatus(request *UpdateInvoiceIgnoreStatusRequest) (_result *UpdateInvoiceIgnoreStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceIgnoreStatusHeaders{}
	_result = &UpdateInvoiceIgnoreStatusResponse{}
	_body, _err := client.UpdateInvoiceIgnoreStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 发票认证状态变更接口
//
// @param request - UpdateInvoiceVerifyStatusRequest
//
// @param headers - UpdateInvoiceVerifyStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceVerifyStatusResponse
func (client *Client) UpdateInvoiceVerifyStatusWithOptions(request *UpdateInvoiceVerifyStatusRequest, headers *UpdateInvoiceVerifyStatusHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceVerifyStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CompanyCode)) {
		body["companyCode"] = request.CompanyCode
	}

	if !tea.BoolValue(util.IsUnset(request.DeductStatus)) {
		body["deductStatus"] = request.DeductStatus
	}

	if !tea.BoolValue(util.IsUnset(request.GeneralInvoiceVOList)) {
		body["generalInvoiceVOList"] = request.GeneralInvoiceVOList
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceKeyVOList)) {
		body["invoiceKeyVOList"] = request.InvoiceKeyVOList
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	if !tea.BoolValue(util.IsUnset(request.VerifyStatus)) {
		body["verifyStatus"] = request.VerifyStatus
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceVerifyStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/verifyStatus"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceVerifyStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 发票认证状态变更接口
//
// @param request - UpdateInvoiceVerifyStatusRequest
//
// @return UpdateInvoiceVerifyStatusResponse
func (client *Client) UpdateInvoiceVerifyStatus(request *UpdateInvoiceVerifyStatusRequest) (_result *UpdateInvoiceVerifyStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceVerifyStatusHeaders{}
	_result = &UpdateInvoiceVerifyStatusResponse{}
	_body, _err := client.UpdateInvoiceVerifyStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新发票生成凭证状态
//
// @param request - UpdateInvoiceVoucherStatusRequest
//
// @param headers - UpdateInvoiceVoucherStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateInvoiceVoucherStatusResponse
func (client *Client) UpdateInvoiceVoucherStatusWithOptions(request *UpdateInvoiceVoucherStatusRequest, headers *UpdateInvoiceVoucherStatusHeaders, runtime *util.RuntimeOptions) (_result *UpdateInvoiceVoucherStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountantBookId)) {
		body["accountantBookId"] = request.AccountantBookId
	}

	if !tea.BoolValue(util.IsUnset(request.ActionType)) {
		body["actionType"] = request.ActionType
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceCode)) {
		body["invoiceCode"] = request.InvoiceCode
	}

	if !tea.BoolValue(util.IsUnset(request.InvoiceNo)) {
		body["invoiceNo"] = request.InvoiceNo
	}

	if !tea.BoolValue(util.IsUnset(request.Operator)) {
		body["operator"] = request.Operator
	}

	if !tea.BoolValue(util.IsUnset(request.VoucherId)) {
		body["voucherId"] = request.VoucherId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateInvoiceVoucherStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/invoices/vouchers/states"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateInvoiceVoucherStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新发票生成凭证状态
//
// @param request - UpdateInvoiceVoucherStatusRequest
//
// @return UpdateInvoiceVoucherStatusResponse
func (client *Client) UpdateInvoiceVoucherStatus(request *UpdateInvoiceVoucherStatusRequest) (_result *UpdateInvoiceVoucherStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateInvoiceVoucherStatusHeaders{}
	_result = &UpdateInvoiceVoucherStatusResponse{}
	_body, _err := client.UpdateInvoiceVoucherStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新智能财务单据
//
// @param request - UpdateReceiptRequest
//
// @param headers - UpdateReceiptHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateReceiptResponse
func (client *Client) UpdateReceiptWithOptions(request *UpdateReceiptRequest, headers *UpdateReceiptHeaders, runtime *util.RuntimeOptions) (_result *UpdateReceiptResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Receipts)) {
		body["receipts"] = request.Receipts
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateReceipt"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/receipts"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateReceiptResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新智能财务单据
//
// @param request - UpdateReceiptRequest
//
// @return UpdateReceiptResponse
func (client *Client) UpdateReceipt(request *UpdateReceiptRequest) (_result *UpdateReceiptResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateReceiptHeaders{}
	_result = &UpdateReceiptResponse{}
	_body, _err := client.UpdateReceiptWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新智能财务审批单的凭证状态
//
// @param request - UpdateReceiptVoucherStatusRequest
//
// @param headers - UpdateReceiptVoucherStatusHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateReceiptVoucherStatusResponse
func (client *Client) UpdateReceiptVoucherStatusWithOptions(request *UpdateReceiptVoucherStatusRequest, headers *UpdateReceiptVoucherStatusHeaders, runtime *util.RuntimeOptions) (_result *UpdateReceiptVoucherStatusResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AccountPeriod)) {
		body["accountPeriod"] = request.AccountPeriod
	}

	if !tea.BoolValue(util.IsUnset(request.ActionType)) {
		body["actionType"] = request.ActionType
	}

	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		body["operatorId"] = request.OperatorId
	}

	if !tea.BoolValue(util.IsUnset(request.ReceiptId)) {
		body["receiptId"] = request.ReceiptId
	}

	if !tea.BoolValue(util.IsUnset(request.VoucherCode)) {
		body["voucherCode"] = request.VoucherCode
	}

	if !tea.BoolValue(util.IsUnset(request.VoucherId)) {
		body["voucherId"] = request.VoucherId
	}

	if !tea.BoolValue(util.IsUnset(request.VoucherNo)) {
		body["voucherNo"] = request.VoucherNo
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = util.ToJSONString(headers.XAcsDingtalkAccessToken)
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateReceiptVoucherStatus"),
		Version:     tea.String("bizfinance_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/bizfinance/vouchers/recepits"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateReceiptVoucherStatusResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新智能财务审批单的凭证状态
//
// @param request - UpdateReceiptVoucherStatusRequest
//
// @return UpdateReceiptVoucherStatusResponse
func (client *Client) UpdateReceiptVoucherStatus(request *UpdateReceiptVoucherStatusRequest) (_result *UpdateReceiptVoucherStatusResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateReceiptVoucherStatusHeaders{}
	_result = &UpdateReceiptVoucherStatusResponse{}
	_body, _err := client.UpdateReceiptVoucherStatusWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}
