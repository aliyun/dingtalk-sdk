// This file is auto-generated, don't edit it. Thanks.
package oauth2_1_0

import (
	openapi "github.com/alibabacloud-go/darabonba-openapi/v2/client"
	gatewayclient "github.com/alibabacloud-go/gateway-dingtalk/client"
	openapiutil "github.com/alibabacloud-go/openapi-util/service"
	util "github.com/alibabacloud-go/tea-utils/v2/service"
	"github.com/alibabacloud-go/tea/tea"
)

type CreateJsapiTicketHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CreateJsapiTicketHeaders) String() string {
	return tea.Prettify(s)
}

func (s CreateJsapiTicketHeaders) GoString() string {
	return s.String()
}

func (s *CreateJsapiTicketHeaders) SetCommonHeaders(v map[string]*string) *CreateJsapiTicketHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CreateJsapiTicketHeaders) SetXAcsDingtalkAccessToken(v string) *CreateJsapiTicketHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CreateJsapiTicketResponseBody struct {
	ExpireIn    *int64  `json:"expireIn,omitempty" xml:"expireIn,omitempty"`
	JsapiTicket *string `json:"jsapiTicket,omitempty" xml:"jsapiTicket,omitempty"`
}

func (s CreateJsapiTicketResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateJsapiTicketResponseBody) GoString() string {
	return s.String()
}

func (s *CreateJsapiTicketResponseBody) SetExpireIn(v int64) *CreateJsapiTicketResponseBody {
	s.ExpireIn = &v
	return s
}

func (s *CreateJsapiTicketResponseBody) SetJsapiTicket(v string) *CreateJsapiTicketResponseBody {
	s.JsapiTicket = &v
	return s
}

type CreateJsapiTicketResponse struct {
	Headers    map[string]*string             `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                         `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CreateJsapiTicketResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CreateJsapiTicketResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateJsapiTicketResponse) GoString() string {
	return s.String()
}

func (s *CreateJsapiTicketResponse) SetHeaders(v map[string]*string) *CreateJsapiTicketResponse {
	s.Headers = v
	return s
}

func (s *CreateJsapiTicketResponse) SetStatusCode(v int32) *CreateJsapiTicketResponse {
	s.StatusCode = &v
	return s
}

func (s *CreateJsapiTicketResponse) SetBody(v *CreateJsapiTicketResponseBody) *CreateJsapiTicketResponse {
	s.Body = v
	return s
}

type GetAccessTokenRequest struct {
	// This parameter is required.
	AppKey    *string `json:"appKey,omitempty" xml:"appKey,omitempty"`
	AppSecret *string `json:"appSecret,omitempty" xml:"appSecret,omitempty"`
}

func (s GetAccessTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAccessTokenRequest) GoString() string {
	return s.String()
}

func (s *GetAccessTokenRequest) SetAppKey(v string) *GetAccessTokenRequest {
	s.AppKey = &v
	return s
}

func (s *GetAccessTokenRequest) SetAppSecret(v string) *GetAccessTokenRequest {
	s.AppSecret = &v
	return s
}

type GetAccessTokenResponseBody struct {
	AccessToken *string `json:"accessToken,omitempty" xml:"accessToken,omitempty"`
	ExpireIn    *int64  `json:"expireIn,omitempty" xml:"expireIn,omitempty"`
}

func (s GetAccessTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetAccessTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetAccessTokenResponseBody) SetAccessToken(v string) *GetAccessTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetAccessTokenResponseBody) SetExpireIn(v int64) *GetAccessTokenResponseBody {
	s.ExpireIn = &v
	return s
}

type GetAccessTokenResponse struct {
	Headers    map[string]*string          `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                      `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetAccessTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetAccessTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetAccessTokenResponse) GoString() string {
	return s.String()
}

func (s *GetAccessTokenResponse) SetHeaders(v map[string]*string) *GetAccessTokenResponse {
	s.Headers = v
	return s
}

func (s *GetAccessTokenResponse) SetStatusCode(v int32) *GetAccessTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetAccessTokenResponse) SetBody(v *GetAccessTokenResponseBody) *GetAccessTokenResponse {
	s.Body = v
	return s
}

type GetAuthInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetAuthInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoHeaders) GoString() string {
	return s.String()
}

func (s *GetAuthInfoHeaders) SetCommonHeaders(v map[string]*string) *GetAuthInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetAuthInfoHeaders) SetXAcsDingtalkAccessToken(v string) *GetAuthInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetAuthInfoRequest struct {
	// This parameter is required.
	AuthCorpId *string `json:"authCorpId,omitempty" xml:"authCorpId,omitempty"`
}

func (s GetAuthInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoRequest) GoString() string {
	return s.String()
}

func (s *GetAuthInfoRequest) SetAuthCorpId(v string) *GetAuthInfoRequest {
	s.AuthCorpId = &v
	return s
}

type GetAuthInfoResponseBody struct {
	// This parameter is required.
	AuthAppInfo *GetAuthInfoResponseBodyAuthAppInfo `json:"authAppInfo,omitempty" xml:"authAppInfo,omitempty" type:"Struct"`
	// This parameter is required.
	AuthCorpInfo *GetAuthInfoResponseBodyAuthCorpInfo `json:"authCorpInfo,omitempty" xml:"authCorpInfo,omitempty" type:"Struct"`
	// This parameter is required.
	AuthUserInfo *GetAuthInfoResponseBodyAuthUserInfo `json:"authUserInfo,omitempty" xml:"authUserInfo,omitempty" type:"Struct"`
}

func (s GetAuthInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoResponseBody) GoString() string {
	return s.String()
}

func (s *GetAuthInfoResponseBody) SetAuthAppInfo(v *GetAuthInfoResponseBodyAuthAppInfo) *GetAuthInfoResponseBody {
	s.AuthAppInfo = v
	return s
}

func (s *GetAuthInfoResponseBody) SetAuthCorpInfo(v *GetAuthInfoResponseBodyAuthCorpInfo) *GetAuthInfoResponseBody {
	s.AuthCorpInfo = v
	return s
}

func (s *GetAuthInfoResponseBody) SetAuthUserInfo(v *GetAuthInfoResponseBodyAuthUserInfo) *GetAuthInfoResponseBody {
	s.AuthUserInfo = v
	return s
}

type GetAuthInfoResponseBodyAuthAppInfo struct {
	// This parameter is required.
	AgentList []*GetAuthInfoResponseBodyAuthAppInfoAgentList `json:"agentList,omitempty" xml:"agentList,omitempty" type:"Repeated"`
}

func (s GetAuthInfoResponseBodyAuthAppInfo) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoResponseBodyAuthAppInfo) GoString() string {
	return s.String()
}

func (s *GetAuthInfoResponseBodyAuthAppInfo) SetAgentList(v []*GetAuthInfoResponseBodyAuthAppInfoAgentList) *GetAuthInfoResponseBodyAuthAppInfo {
	s.AgentList = v
	return s
}

type GetAuthInfoResponseBodyAuthAppInfoAgentList struct {
	// This parameter is required.
	AdminList []*string `json:"adminList,omitempty" xml:"adminList,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// 835880322
	AgentId *int64 `json:"agentId,omitempty" xml:"agentId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 小程序DEMO
	AgentName *string `json:"agentName,omitempty" xml:"agentName,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 111
	AppId *int64 `json:"appId,omitempty" xml:"appId,omitempty"`
}

func (s GetAuthInfoResponseBodyAuthAppInfoAgentList) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoResponseBodyAuthAppInfoAgentList) GoString() string {
	return s.String()
}

func (s *GetAuthInfoResponseBodyAuthAppInfoAgentList) SetAdminList(v []*string) *GetAuthInfoResponseBodyAuthAppInfoAgentList {
	s.AdminList = v
	return s
}

func (s *GetAuthInfoResponseBodyAuthAppInfoAgentList) SetAgentId(v int64) *GetAuthInfoResponseBodyAuthAppInfoAgentList {
	s.AgentId = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthAppInfoAgentList) SetAgentName(v string) *GetAuthInfoResponseBodyAuthAppInfoAgentList {
	s.AgentName = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthAppInfoAgentList) SetAppId(v int64) *GetAuthInfoResponseBodyAuthAppInfoAgentList {
	s.AppId = &v
	return s
}

type GetAuthInfoResponseBodyAuthCorpInfo struct {
	// This parameter is required.
	//
	// example:
	//
	// 123
	AuthChannel *string `json:"authChannel,omitempty" xml:"authChannel,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1
	AuthChannelType *string `json:"authChannelType,omitempty" xml:"authChannelType,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 1
	AuthLevel *int64 `json:"authLevel,omitempty" xml:"authLevel,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// https://static-legacy.dingtalk.com/xxx
	CorpLogoUrl *string `json:"corpLogoUrl,omitempty" xml:"corpLogoUrl,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 小程序体验HTTP
	CorpName *string `json:"corpName,omitempty" xml:"corpName,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 201
	Industry *string `json:"industry,omitempty" xml:"industry,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 111
	InviteCode *string `json:"inviteCode,omitempty" xml:"inviteCode,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// https://wx.dingtalk.com/invite-page/xxx
	InviteUrl *string `json:"inviteUrl,omitempty" xml:"inviteUrl,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 111
	LicenseCode *string `json:"licenseCode,omitempty" xml:"licenseCode,omitempty"`
}

func (s GetAuthInfoResponseBodyAuthCorpInfo) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoResponseBodyAuthCorpInfo) GoString() string {
	return s.String()
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetAuthChannel(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.AuthChannel = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetAuthChannelType(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.AuthChannelType = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetAuthLevel(v int64) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.AuthLevel = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetCorpLogoUrl(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.CorpLogoUrl = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetCorpName(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.CorpName = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetIndustry(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.Industry = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetInviteCode(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.InviteCode = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetInviteUrl(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.InviteUrl = &v
	return s
}

func (s *GetAuthInfoResponseBodyAuthCorpInfo) SetLicenseCode(v string) *GetAuthInfoResponseBodyAuthCorpInfo {
	s.LicenseCode = &v
	return s
}

type GetAuthInfoResponseBodyAuthUserInfo struct {
	// This parameter is required.
	//
	// example:
	//
	// manager975
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s GetAuthInfoResponseBodyAuthUserInfo) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoResponseBodyAuthUserInfo) GoString() string {
	return s.String()
}

func (s *GetAuthInfoResponseBodyAuthUserInfo) SetUserId(v string) *GetAuthInfoResponseBodyAuthUserInfo {
	s.UserId = &v
	return s
}

type GetAuthInfoResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetAuthInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetAuthInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s GetAuthInfoResponse) GoString() string {
	return s.String()
}

func (s *GetAuthInfoResponse) SetHeaders(v map[string]*string) *GetAuthInfoResponse {
	s.Headers = v
	return s
}

func (s *GetAuthInfoResponse) SetStatusCode(v int32) *GetAuthInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *GetAuthInfoResponse) SetBody(v *GetAuthInfoResponseBody) *GetAuthInfoResponse {
	s.Body = v
	return s
}

type GetCorpAccessTokenRequest struct {
	// This parameter is required.
	AuthCorpId *string `json:"authCorpId,omitempty" xml:"authCorpId,omitempty"`
	// This parameter is required.
	SuiteKey *string `json:"suiteKey,omitempty" xml:"suiteKey,omitempty"`
	// This parameter is required.
	SuiteSecret *string `json:"suiteSecret,omitempty" xml:"suiteSecret,omitempty"`
	// This parameter is required.
	SuiteTicket *string `json:"suiteTicket,omitempty" xml:"suiteTicket,omitempty"`
}

func (s GetCorpAccessTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetCorpAccessTokenRequest) GoString() string {
	return s.String()
}

func (s *GetCorpAccessTokenRequest) SetAuthCorpId(v string) *GetCorpAccessTokenRequest {
	s.AuthCorpId = &v
	return s
}

func (s *GetCorpAccessTokenRequest) SetSuiteKey(v string) *GetCorpAccessTokenRequest {
	s.SuiteKey = &v
	return s
}

func (s *GetCorpAccessTokenRequest) SetSuiteSecret(v string) *GetCorpAccessTokenRequest {
	s.SuiteSecret = &v
	return s
}

func (s *GetCorpAccessTokenRequest) SetSuiteTicket(v string) *GetCorpAccessTokenRequest {
	s.SuiteTicket = &v
	return s
}

type GetCorpAccessTokenResponseBody struct {
	AccessToken *string `json:"accessToken,omitempty" xml:"accessToken,omitempty"`
	ExpireIn    *int64  `json:"expireIn,omitempty" xml:"expireIn,omitempty"`
}

func (s GetCorpAccessTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetCorpAccessTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetCorpAccessTokenResponseBody) SetAccessToken(v string) *GetCorpAccessTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetCorpAccessTokenResponseBody) SetExpireIn(v int64) *GetCorpAccessTokenResponseBody {
	s.ExpireIn = &v
	return s
}

type GetCorpAccessTokenResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetCorpAccessTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetCorpAccessTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetCorpAccessTokenResponse) GoString() string {
	return s.String()
}

func (s *GetCorpAccessTokenResponse) SetHeaders(v map[string]*string) *GetCorpAccessTokenResponse {
	s.Headers = v
	return s
}

func (s *GetCorpAccessTokenResponse) SetStatusCode(v int32) *GetCorpAccessTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetCorpAccessTokenResponse) SetBody(v *GetCorpAccessTokenResponseBody) *GetCorpAccessTokenResponse {
	s.Body = v
	return s
}

type GetPersonalAuthRuleHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetPersonalAuthRuleHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetPersonalAuthRuleHeaders) GoString() string {
	return s.String()
}

func (s *GetPersonalAuthRuleHeaders) SetCommonHeaders(v map[string]*string) *GetPersonalAuthRuleHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetPersonalAuthRuleHeaders) SetXAcsDingtalkAccessToken(v string) *GetPersonalAuthRuleHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetPersonalAuthRuleResponseBody struct {
	Result []*GetPersonalAuthRuleResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Repeated"`
}

func (s GetPersonalAuthRuleResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetPersonalAuthRuleResponseBody) GoString() string {
	return s.String()
}

func (s *GetPersonalAuthRuleResponseBody) SetResult(v []*GetPersonalAuthRuleResponseBodyResult) *GetPersonalAuthRuleResponseBody {
	s.Result = v
	return s
}

type GetPersonalAuthRuleResponseBodyResult struct {
	// This parameter is required.
	AuthItems []*string `json:"authItems,omitempty" xml:"authItems,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// Contact.User
	Resource *string `json:"resource,omitempty" xml:"resource,omitempty"`
}

func (s GetPersonalAuthRuleResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s GetPersonalAuthRuleResponseBodyResult) GoString() string {
	return s.String()
}

func (s *GetPersonalAuthRuleResponseBodyResult) SetAuthItems(v []*string) *GetPersonalAuthRuleResponseBodyResult {
	s.AuthItems = v
	return s
}

func (s *GetPersonalAuthRuleResponseBodyResult) SetResource(v string) *GetPersonalAuthRuleResponseBodyResult {
	s.Resource = &v
	return s
}

type GetPersonalAuthRuleResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetPersonalAuthRuleResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetPersonalAuthRuleResponse) String() string {
	return tea.Prettify(s)
}

func (s GetPersonalAuthRuleResponse) GoString() string {
	return s.String()
}

func (s *GetPersonalAuthRuleResponse) SetHeaders(v map[string]*string) *GetPersonalAuthRuleResponse {
	s.Headers = v
	return s
}

func (s *GetPersonalAuthRuleResponse) SetStatusCode(v int32) *GetPersonalAuthRuleResponse {
	s.StatusCode = &v
	return s
}

func (s *GetPersonalAuthRuleResponse) SetBody(v *GetPersonalAuthRuleResponseBody) *GetPersonalAuthRuleResponse {
	s.Body = v
	return s
}

type GetSsoAccessTokenRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// corpxxxx
	Corpid *string `json:"corpid,omitempty" xml:"corpid,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// xxxx
	SsoSecret *string `json:"ssoSecret,omitempty" xml:"ssoSecret,omitempty"`
}

func (s GetSsoAccessTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetSsoAccessTokenRequest) GoString() string {
	return s.String()
}

func (s *GetSsoAccessTokenRequest) SetCorpid(v string) *GetSsoAccessTokenRequest {
	s.Corpid = &v
	return s
}

func (s *GetSsoAccessTokenRequest) SetSsoSecret(v string) *GetSsoAccessTokenRequest {
	s.SsoSecret = &v
	return s
}

type GetSsoAccessTokenResponseBody struct {
	// example:
	//
	// 1234
	AccessToken *string `json:"accessToken,omitempty" xml:"accessToken,omitempty"`
	// example:
	//
	// 3600
	ExpireIn *int64 `json:"expireIn,omitempty" xml:"expireIn,omitempty"`
}

func (s GetSsoAccessTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetSsoAccessTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetSsoAccessTokenResponseBody) SetAccessToken(v string) *GetSsoAccessTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetSsoAccessTokenResponseBody) SetExpireIn(v int64) *GetSsoAccessTokenResponseBody {
	s.ExpireIn = &v
	return s
}

type GetSsoAccessTokenResponse struct {
	Headers    map[string]*string             `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                         `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetSsoAccessTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetSsoAccessTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetSsoAccessTokenResponse) GoString() string {
	return s.String()
}

func (s *GetSsoAccessTokenResponse) SetHeaders(v map[string]*string) *GetSsoAccessTokenResponse {
	s.Headers = v
	return s
}

func (s *GetSsoAccessTokenResponse) SetStatusCode(v int32) *GetSsoAccessTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetSsoAccessTokenResponse) SetBody(v *GetSsoAccessTokenResponseBody) *GetSsoAccessTokenResponse {
	s.Body = v
	return s
}

type GetSsoUserInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetSsoUserInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetSsoUserInfoHeaders) GoString() string {
	return s.String()
}

func (s *GetSsoUserInfoHeaders) SetCommonHeaders(v map[string]*string) *GetSsoUserInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetSsoUserInfoHeaders) SetXAcsDingtalkAccessToken(v string) *GetSsoUserInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetSsoUserInfoRequest struct {
	// This parameter is required.
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s GetSsoUserInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s GetSsoUserInfoRequest) GoString() string {
	return s.String()
}

func (s *GetSsoUserInfoRequest) SetCode(v string) *GetSsoUserInfoRequest {
	s.Code = &v
	return s
}

type GetSsoUserInfoResponseBody struct {
	// This parameter is required.
	Avatar *string `json:"avatar,omitempty" xml:"avatar,omitempty"`
	// This parameter is required.
	CorpId *string `json:"corpId,omitempty" xml:"corpId,omitempty"`
	// This parameter is required.
	CorpName *string `json:"corpName,omitempty" xml:"corpName,omitempty"`
	// This parameter is required.
	Email *string `json:"email,omitempty" xml:"email,omitempty"`
	// This parameter is required.
	IsAdmin *bool `json:"isAdmin,omitempty" xml:"isAdmin,omitempty"`
	// This parameter is required.
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
	// This parameter is required.
	UserName *string `json:"userName,omitempty" xml:"userName,omitempty"`
}

func (s GetSsoUserInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetSsoUserInfoResponseBody) GoString() string {
	return s.String()
}

func (s *GetSsoUserInfoResponseBody) SetAvatar(v string) *GetSsoUserInfoResponseBody {
	s.Avatar = &v
	return s
}

func (s *GetSsoUserInfoResponseBody) SetCorpId(v string) *GetSsoUserInfoResponseBody {
	s.CorpId = &v
	return s
}

func (s *GetSsoUserInfoResponseBody) SetCorpName(v string) *GetSsoUserInfoResponseBody {
	s.CorpName = &v
	return s
}

func (s *GetSsoUserInfoResponseBody) SetEmail(v string) *GetSsoUserInfoResponseBody {
	s.Email = &v
	return s
}

func (s *GetSsoUserInfoResponseBody) SetIsAdmin(v bool) *GetSsoUserInfoResponseBody {
	s.IsAdmin = &v
	return s
}

func (s *GetSsoUserInfoResponseBody) SetUserId(v string) *GetSsoUserInfoResponseBody {
	s.UserId = &v
	return s
}

func (s *GetSsoUserInfoResponseBody) SetUserName(v string) *GetSsoUserInfoResponseBody {
	s.UserName = &v
	return s
}

type GetSsoUserInfoResponse struct {
	Headers    map[string]*string          `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                      `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetSsoUserInfoResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetSsoUserInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s GetSsoUserInfoResponse) GoString() string {
	return s.String()
}

func (s *GetSsoUserInfoResponse) SetHeaders(v map[string]*string) *GetSsoUserInfoResponse {
	s.Headers = v
	return s
}

func (s *GetSsoUserInfoResponse) SetStatusCode(v int32) *GetSsoUserInfoResponse {
	s.StatusCode = &v
	return s
}

func (s *GetSsoUserInfoResponse) SetBody(v *GetSsoUserInfoResponseBody) *GetSsoUserInfoResponse {
	s.Body = v
	return s
}

type GetSuiteAccessTokenRequest struct {
	// This parameter is required.
	SuiteKey *string `json:"suiteKey,omitempty" xml:"suiteKey,omitempty"`
	// This parameter is required.
	SuiteSecret *string `json:"suiteSecret,omitempty" xml:"suiteSecret,omitempty"`
	// This parameter is required.
	SuiteTicket *string `json:"suiteTicket,omitempty" xml:"suiteTicket,omitempty"`
}

func (s GetSuiteAccessTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetSuiteAccessTokenRequest) GoString() string {
	return s.String()
}

func (s *GetSuiteAccessTokenRequest) SetSuiteKey(v string) *GetSuiteAccessTokenRequest {
	s.SuiteKey = &v
	return s
}

func (s *GetSuiteAccessTokenRequest) SetSuiteSecret(v string) *GetSuiteAccessTokenRequest {
	s.SuiteSecret = &v
	return s
}

func (s *GetSuiteAccessTokenRequest) SetSuiteTicket(v string) *GetSuiteAccessTokenRequest {
	s.SuiteTicket = &v
	return s
}

type GetSuiteAccessTokenResponseBody struct {
	AccessToken *string `json:"accessToken,omitempty" xml:"accessToken,omitempty"`
	ExpireIn    *int64  `json:"expireIn,omitempty" xml:"expireIn,omitempty"`
}

func (s GetSuiteAccessTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetSuiteAccessTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetSuiteAccessTokenResponseBody) SetAccessToken(v string) *GetSuiteAccessTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetSuiteAccessTokenResponseBody) SetExpireIn(v int64) *GetSuiteAccessTokenResponseBody {
	s.ExpireIn = &v
	return s
}

type GetSuiteAccessTokenResponse struct {
	Headers    map[string]*string               `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                           `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetSuiteAccessTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetSuiteAccessTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetSuiteAccessTokenResponse) GoString() string {
	return s.String()
}

func (s *GetSuiteAccessTokenResponse) SetHeaders(v map[string]*string) *GetSuiteAccessTokenResponse {
	s.Headers = v
	return s
}

func (s *GetSuiteAccessTokenResponse) SetStatusCode(v int32) *GetSuiteAccessTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetSuiteAccessTokenResponse) SetBody(v *GetSuiteAccessTokenResponseBody) *GetSuiteAccessTokenResponse {
	s.Body = v
	return s
}

type GetTokenRequest struct {
	// This parameter is required.
	ClientId *string `json:"client_id,omitempty" xml:"client_id,omitempty"`
	// This parameter is required.
	ClientSecret *string `json:"client_secret,omitempty" xml:"client_secret,omitempty"`
	// This parameter is required.
	GrantType *string `json:"grant_type,omitempty" xml:"grant_type,omitempty"`
}

func (s GetTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetTokenRequest) GoString() string {
	return s.String()
}

func (s *GetTokenRequest) SetClientId(v string) *GetTokenRequest {
	s.ClientId = &v
	return s
}

func (s *GetTokenRequest) SetClientSecret(v string) *GetTokenRequest {
	s.ClientSecret = &v
	return s
}

func (s *GetTokenRequest) SetGrantType(v string) *GetTokenRequest {
	s.GrantType = &v
	return s
}

type GetTokenResponseBody struct {
	AccessToken *string `json:"access_token,omitempty" xml:"access_token,omitempty"`
	ExpiresIn   *int32  `json:"expires_in,omitempty" xml:"expires_in,omitempty"`
}

func (s GetTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetTokenResponseBody) SetAccessToken(v string) *GetTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetTokenResponseBody) SetExpiresIn(v int32) *GetTokenResponseBody {
	s.ExpiresIn = &v
	return s
}

type GetTokenResponse struct {
	Headers    map[string]*string    `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetTokenResponse) GoString() string {
	return s.String()
}

func (s *GetTokenResponse) SetHeaders(v map[string]*string) *GetTokenResponse {
	s.Headers = v
	return s
}

func (s *GetTokenResponse) SetStatusCode(v int32) *GetTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetTokenResponse) SetBody(v *GetTokenResponseBody) *GetTokenResponse {
	s.Body = v
	return s
}

type GetUserTokenRequest struct {
	// This parameter is required.
	ClientId     *string `json:"clientId,omitempty" xml:"clientId,omitempty"`
	ClientSecret *string `json:"clientSecret,omitempty" xml:"clientSecret,omitempty"`
	Code         *string `json:"code,omitempty" xml:"code,omitempty"`
	GrantType    *string `json:"grantType,omitempty" xml:"grantType,omitempty"`
	RefreshToken *string `json:"refreshToken,omitempty" xml:"refreshToken,omitempty"`
}

func (s GetUserTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetUserTokenRequest) GoString() string {
	return s.String()
}

func (s *GetUserTokenRequest) SetClientId(v string) *GetUserTokenRequest {
	s.ClientId = &v
	return s
}

func (s *GetUserTokenRequest) SetClientSecret(v string) *GetUserTokenRequest {
	s.ClientSecret = &v
	return s
}

func (s *GetUserTokenRequest) SetCode(v string) *GetUserTokenRequest {
	s.Code = &v
	return s
}

func (s *GetUserTokenRequest) SetGrantType(v string) *GetUserTokenRequest {
	s.GrantType = &v
	return s
}

func (s *GetUserTokenRequest) SetRefreshToken(v string) *GetUserTokenRequest {
	s.RefreshToken = &v
	return s
}

type GetUserTokenResponseBody struct {
	AccessToken  *string `json:"accessToken,omitempty" xml:"accessToken,omitempty"`
	CorpId       *string `json:"corpId,omitempty" xml:"corpId,omitempty"`
	ExpireIn     *int64  `json:"expireIn,omitempty" xml:"expireIn,omitempty"`
	RefreshToken *string `json:"refreshToken,omitempty" xml:"refreshToken,omitempty"`
}

func (s GetUserTokenResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetUserTokenResponseBody) GoString() string {
	return s.String()
}

func (s *GetUserTokenResponseBody) SetAccessToken(v string) *GetUserTokenResponseBody {
	s.AccessToken = &v
	return s
}

func (s *GetUserTokenResponseBody) SetCorpId(v string) *GetUserTokenResponseBody {
	s.CorpId = &v
	return s
}

func (s *GetUserTokenResponseBody) SetExpireIn(v int64) *GetUserTokenResponseBody {
	s.ExpireIn = &v
	return s
}

func (s *GetUserTokenResponseBody) SetRefreshToken(v string) *GetUserTokenResponseBody {
	s.RefreshToken = &v
	return s
}

type GetUserTokenResponse struct {
	Headers    map[string]*string        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetUserTokenResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetUserTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s GetUserTokenResponse) GoString() string {
	return s.String()
}

func (s *GetUserTokenResponse) SetHeaders(v map[string]*string) *GetUserTokenResponse {
	s.Headers = v
	return s
}

func (s *GetUserTokenResponse) SetStatusCode(v int32) *GetUserTokenResponse {
	s.StatusCode = &v
	return s
}

func (s *GetUserTokenResponse) SetBody(v *GetUserTokenResponseBody) *GetUserTokenResponse {
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
	client.SignatureAlgorithm = tea.String("v2")
	client.EndpointRule = tea.String("")
	if tea.BoolValue(util.Empty(client.Endpoint)) {
		client.Endpoint = tea.String("api.dingtalk.com")
	}

	return nil
}

// Summary:
//
// 生成jsapi ticket
//
// @param headers - CreateJsapiTicketHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CreateJsapiTicketResponse
func (client *Client) CreateJsapiTicketWithOptions(headers *CreateJsapiTicketHeaders, runtime *util.RuntimeOptions) (_result *CreateJsapiTicketResponse, _err error) {
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
		Action:      tea.String("CreateJsapiTicket"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/jsapiTickets"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CreateJsapiTicketResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 生成jsapi ticket
//
// @return CreateJsapiTicketResponse
func (client *Client) CreateJsapiTicket() (_result *CreateJsapiTicketResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CreateJsapiTicketHeaders{}
	_result = &CreateJsapiTicketResponse{}
	_body, _err := client.CreateJsapiTicketWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取企业accessToken(企业内部应用)
//
// @param request - GetAccessTokenRequest
//
// @param headers - map
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetAccessTokenResponse
func (client *Client) GetAccessTokenWithOptions(request *GetAccessTokenRequest, headers map[string]*string, runtime *util.RuntimeOptions) (_result *GetAccessTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AppKey)) {
		body["appKey"] = request.AppKey
	}

	if !tea.BoolValue(util.IsUnset(request.AppSecret)) {
		body["appSecret"] = request.AppSecret
	}

	req := &openapi.OpenApiRequest{
		Headers: headers,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("GetAccessToken"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/accessToken"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("Anonymous"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetAccessTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取企业accessToken(企业内部应用)
//
// @param request - GetAccessTokenRequest
//
// @return GetAccessTokenResponse
func (client *Client) GetAccessToken(request *GetAccessTokenRequest) (_result *GetAccessTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := make(map[string]*string)
	_result = &GetAccessTokenResponse{}
	_body, _err := client.GetAccessTokenWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取企业开通应用后的授权信息
//
// @param request - GetAuthInfoRequest
//
// @param headers - GetAuthInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetAuthInfoResponse
func (client *Client) GetAuthInfoWithOptions(request *GetAuthInfoRequest, headers *GetAuthInfoHeaders, runtime *util.RuntimeOptions) (_result *GetAuthInfoResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AuthCorpId)) {
		query["authCorpId"] = request.AuthCorpId
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
		Action:      tea.String("GetAuthInfo"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/apps/authInfo"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &GetAuthInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取企业开通应用后的授权信息
//
// @param request - GetAuthInfoRequest
//
// @return GetAuthInfoResponse
func (client *Client) GetAuthInfo(request *GetAuthInfoRequest) (_result *GetAuthInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetAuthInfoHeaders{}
	_result = &GetAuthInfoResponse{}
	_body, _err := client.GetAuthInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取企业accessToken(应用商店应用)
//
// @param request - GetCorpAccessTokenRequest
//
// @param headers - map
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetCorpAccessTokenResponse
func (client *Client) GetCorpAccessTokenWithOptions(request *GetCorpAccessTokenRequest, headers map[string]*string, runtime *util.RuntimeOptions) (_result *GetCorpAccessTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.AuthCorpId)) {
		body["authCorpId"] = request.AuthCorpId
	}

	if !tea.BoolValue(util.IsUnset(request.SuiteKey)) {
		body["suiteKey"] = request.SuiteKey
	}

	if !tea.BoolValue(util.IsUnset(request.SuiteSecret)) {
		body["suiteSecret"] = request.SuiteSecret
	}

	if !tea.BoolValue(util.IsUnset(request.SuiteTicket)) {
		body["suiteTicket"] = request.SuiteTicket
	}

	req := &openapi.OpenApiRequest{
		Headers: headers,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("GetCorpAccessToken"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/corpAccessToken"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("Anonymous"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetCorpAccessTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取企业accessToken(应用商店应用)
//
// @param request - GetCorpAccessTokenRequest
//
// @return GetCorpAccessTokenResponse
func (client *Client) GetCorpAccessToken(request *GetCorpAccessTokenRequest) (_result *GetCorpAccessTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := make(map[string]*string)
	_result = &GetCorpAccessTokenResponse{}
	_body, _err := client.GetCorpAccessTokenWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询个人授权记录
//
// @param headers - GetPersonalAuthRuleHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetPersonalAuthRuleResponse
func (client *Client) GetPersonalAuthRuleWithOptions(headers *GetPersonalAuthRuleHeaders, runtime *util.RuntimeOptions) (_result *GetPersonalAuthRuleResponse, _err error) {
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
		Action:      tea.String("GetPersonalAuthRule"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/authRules/user"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &GetPersonalAuthRuleResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询个人授权记录
//
// @return GetPersonalAuthRuleResponse
func (client *Client) GetPersonalAuthRule() (_result *GetPersonalAuthRuleResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetPersonalAuthRuleHeaders{}
	_result = &GetPersonalAuthRuleResponse{}
	_body, _err := client.GetPersonalAuthRuleWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 生成微应用管理后台accessToken
//
// @param request - GetSsoAccessTokenRequest
//
// @param headers - map
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetSsoAccessTokenResponse
func (client *Client) GetSsoAccessTokenWithOptions(request *GetSsoAccessTokenRequest, headers map[string]*string, runtime *util.RuntimeOptions) (_result *GetSsoAccessTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Corpid)) {
		body["corpid"] = request.Corpid
	}

	if !tea.BoolValue(util.IsUnset(request.SsoSecret)) {
		body["ssoSecret"] = request.SsoSecret
	}

	req := &openapi.OpenApiRequest{
		Headers: headers,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("GetSsoAccessToken"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/ssoAccessToken"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("Anonymous"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &GetSsoAccessTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 生成微应用管理后台accessToken
//
// @param request - GetSsoAccessTokenRequest
//
// @return GetSsoAccessTokenResponse
func (client *Client) GetSsoAccessToken(request *GetSsoAccessTokenRequest) (_result *GetSsoAccessTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := make(map[string]*string)
	_result = &GetSsoAccessTokenResponse{}
	_body, _err := client.GetSsoAccessTokenWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 查询微应用后台免登的用户信息
//
// @param request - GetSsoUserInfoRequest
//
// @param headers - GetSsoUserInfoHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetSsoUserInfoResponse
func (client *Client) GetSsoUserInfoWithOptions(request *GetSsoUserInfoRequest, headers *GetSsoUserInfoHeaders, runtime *util.RuntimeOptions) (_result *GetSsoUserInfoResponse, _err error) {
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
		Action:      tea.String("GetSsoUserInfo"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/ssoUserInfo"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetSsoUserInfoResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 查询微应用后台免登的用户信息
//
// @param request - GetSsoUserInfoRequest
//
// @return GetSsoUserInfoResponse
func (client *Client) GetSsoUserInfo(request *GetSsoUserInfoRequest) (_result *GetSsoUserInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetSsoUserInfoHeaders{}
	_result = &GetSsoUserInfoResponse{}
	_body, _err := client.GetSsoUserInfoWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取isvAccessToken（三方企业应用）
//
// @param request - GetSuiteAccessTokenRequest
//
// @param headers - map
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetSuiteAccessTokenResponse
func (client *Client) GetSuiteAccessTokenWithOptions(request *GetSuiteAccessTokenRequest, headers map[string]*string, runtime *util.RuntimeOptions) (_result *GetSuiteAccessTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.SuiteKey)) {
		body["suiteKey"] = request.SuiteKey
	}

	if !tea.BoolValue(util.IsUnset(request.SuiteSecret)) {
		body["suiteSecret"] = request.SuiteSecret
	}

	if !tea.BoolValue(util.IsUnset(request.SuiteTicket)) {
		body["suiteTicket"] = request.SuiteTicket
	}

	req := &openapi.OpenApiRequest{
		Headers: headers,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("GetSuiteAccessToken"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/suiteAccessToken"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("Anonymous"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &GetSuiteAccessTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取isvAccessToken（三方企业应用）
//
// @param request - GetSuiteAccessTokenRequest
//
// @return GetSuiteAccessTokenResponse
func (client *Client) GetSuiteAccessToken(request *GetSuiteAccessTokenRequest) (_result *GetSuiteAccessTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := make(map[string]*string)
	_result = &GetSuiteAccessTokenResponse{}
	_body, _err := client.GetSuiteAccessTokenWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取Access Token
//
// @param request - GetTokenRequest
//
// @param headers - map
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetTokenResponse
func (client *Client) GetTokenWithOptions(corpId *string, request *GetTokenRequest, headers map[string]*string, runtime *util.RuntimeOptions) (_result *GetTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.ClientId)) {
		body["client_id"] = request.ClientId
	}

	if !tea.BoolValue(util.IsUnset(request.ClientSecret)) {
		body["client_secret"] = request.ClientSecret
	}

	if !tea.BoolValue(util.IsUnset(request.GrantType)) {
		body["grant_type"] = request.GrantType
	}

	req := &openapi.OpenApiRequest{
		Headers: headers,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("GetToken"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/" + tea.StringValue(corpId) + "/token"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("Anonymous"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取Access Token
//
// @param request - GetTokenRequest
//
// @return GetTokenResponse
func (client *Client) GetToken(corpId *string, request *GetTokenRequest) (_result *GetTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := make(map[string]*string)
	_result = &GetTokenResponse{}
	_body, _err := client.GetTokenWithOptions(corpId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取用户token
//
// @param request - GetUserTokenRequest
//
// @param headers - map
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetUserTokenResponse
func (client *Client) GetUserTokenWithOptions(request *GetUserTokenRequest, headers map[string]*string, runtime *util.RuntimeOptions) (_result *GetUserTokenResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.ClientId)) {
		body["clientId"] = request.ClientId
	}

	if !tea.BoolValue(util.IsUnset(request.ClientSecret)) {
		body["clientSecret"] = request.ClientSecret
	}

	if !tea.BoolValue(util.IsUnset(request.Code)) {
		body["code"] = request.Code
	}

	if !tea.BoolValue(util.IsUnset(request.GrantType)) {
		body["grantType"] = request.GrantType
	}

	if !tea.BoolValue(util.IsUnset(request.RefreshToken)) {
		body["refreshToken"] = request.RefreshToken
	}

	req := &openapi.OpenApiRequest{
		Headers: headers,
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("GetUserToken"),
		Version:     tea.String("oauth2_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/oauth2/userAccessToken"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("Anonymous"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("json"),
		BodyType:    tea.String("json"),
	}
	_result = &GetUserTokenResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取用户token
//
// @param request - GetUserTokenRequest
//
// @return GetUserTokenResponse
func (client *Client) GetUserToken(request *GetUserTokenRequest) (_result *GetUserTokenResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := make(map[string]*string)
	_result = &GetUserTokenResponse{}
	_body, _err := client.GetUserTokenWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}
