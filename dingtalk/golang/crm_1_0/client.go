// This file is auto-generated, don't edit it. Thanks.
/**
 *
 */
package crm_1_0

import (
	openapi "github.com/alibabacloud-go/darabonba-openapi/client"
	openapiutil "github.com/alibabacloud-go/openapi-util/service"
	util "github.com/alibabacloud-go/tea-utils/service"
	"github.com/alibabacloud-go/tea/tea"
)

type GetOfficialAccountContactsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetOfficialAccountContactsHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsHeaders) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsHeaders) SetCommonHeaders(v map[string]*string) *GetOfficialAccountContactsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetOfficialAccountContactsHeaders) SetXAcsDingtalkAccessToken(v string) *GetOfficialAccountContactsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetOfficialAccountContactsRequest struct {
	// 取数游标，第一次传0
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 分页大小，最大不超过10
	MaxResults *int64 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
}

func (s GetOfficialAccountContactsRequest) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsRequest) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsRequest) SetNextToken(v string) *GetOfficialAccountContactsRequest {
	s.NextToken = &v
	return s
}

func (s *GetOfficialAccountContactsRequest) SetMaxResults(v int64) *GetOfficialAccountContactsRequest {
	s.MaxResults = &v
	return s
}

type GetOfficialAccountContactsResponseBody struct {
	// 下一页的游标，为null则表示无数据
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 分页大小
	MaxResults *int64 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	// 客户数据节点
	Values []*GetOfficialAccountContactsResponseBodyValues `json:"values,omitempty" xml:"values,omitempty" type:"Repeated"`
}

func (s GetOfficialAccountContactsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsResponseBody) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsResponseBody) SetNextToken(v string) *GetOfficialAccountContactsResponseBody {
	s.NextToken = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBody) SetMaxResults(v int64) *GetOfficialAccountContactsResponseBody {
	s.MaxResults = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBody) SetValues(v []*GetOfficialAccountContactsResponseBodyValues) *GetOfficialAccountContactsResponseBody {
	s.Values = v
	return s
}

type GetOfficialAccountContactsResponseBodyValues struct {
	// 用户userId
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
	// 用户的联系人数据
	Contacts []*GetOfficialAccountContactsResponseBodyValuesContacts `json:"contacts,omitempty" xml:"contacts,omitempty" type:"Repeated"`
}

func (s GetOfficialAccountContactsResponseBodyValues) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsResponseBodyValues) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsResponseBodyValues) SetUserId(v string) *GetOfficialAccountContactsResponseBodyValues {
	s.UserId = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValues) SetContacts(v []*GetOfficialAccountContactsResponseBodyValuesContacts) *GetOfficialAccountContactsResponseBodyValues {
	s.Contacts = v
	return s
}

type GetOfficialAccountContactsResponseBodyValuesContacts struct {
	// 创建记录的用户昵称
	CreatorNick *string `json:"creatorNick,omitempty" xml:"creatorNick,omitempty"`
	// 记录修改时间
	ModifyTime *string `json:"modifyTime,omitempty" xml:"modifyTime,omitempty"`
	// 记录创建时间
	CreateTime *string `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// 创建记录的用户ID
	CreatorUserId *string `json:"creatorUserId,omitempty" xml:"creatorUserId,omitempty"`
	// 数据ID
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	// 数据内容
	Data map[string]interface{} `json:"data,omitempty" xml:"data,omitempty"`
	// 扩展数据内容
	ExtendData map[string]interface{} `json:"extendData,omitempty" xml:"extendData,omitempty"`
	// 数据权限信息
	Permission *GetOfficialAccountContactsResponseBodyValuesContactsPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
}

func (s GetOfficialAccountContactsResponseBodyValuesContacts) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsResponseBodyValuesContacts) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetCreatorNick(v string) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.CreatorNick = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetModifyTime(v string) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.ModifyTime = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetCreateTime(v string) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.CreateTime = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetCreatorUserId(v string) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.CreatorUserId = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetInstanceId(v string) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.InstanceId = &v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetData(v map[string]interface{}) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.Data = v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetExtendData(v map[string]interface{}) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.ExtendData = v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContacts) SetPermission(v *GetOfficialAccountContactsResponseBodyValuesContactsPermission) *GetOfficialAccountContactsResponseBodyValuesContacts {
	s.Permission = v
	return s
}

type GetOfficialAccountContactsResponseBodyValuesContactsPermission struct {
	// 协同人用户ID列表
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
	// 负责人用户ID列表
	OwnerStaffIds []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
}

func (s GetOfficialAccountContactsResponseBodyValuesContactsPermission) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsResponseBodyValuesContactsPermission) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsResponseBodyValuesContactsPermission) SetParticipantStaffIds(v []*string) *GetOfficialAccountContactsResponseBodyValuesContactsPermission {
	s.ParticipantStaffIds = v
	return s
}

func (s *GetOfficialAccountContactsResponseBodyValuesContactsPermission) SetOwnerStaffIds(v []*string) *GetOfficialAccountContactsResponseBodyValuesContactsPermission {
	s.OwnerStaffIds = v
	return s
}

type GetOfficialAccountContactsResponse struct {
	Headers map[string]*string                      `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *GetOfficialAccountContactsResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s GetOfficialAccountContactsResponse) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactsResponse) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactsResponse) SetHeaders(v map[string]*string) *GetOfficialAccountContactsResponse {
	s.Headers = v
	return s
}

func (s *GetOfficialAccountContactsResponse) SetBody(v *GetOfficialAccountContactsResponseBody) *GetOfficialAccountContactsResponse {
	s.Body = v
	return s
}

type ServiceWindowMessageBatchPushHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s ServiceWindowMessageBatchPushHeaders) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushHeaders) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushHeaders) SetCommonHeaders(v map[string]*string) *ServiceWindowMessageBatchPushHeaders {
	s.CommonHeaders = v
	return s
}

func (s *ServiceWindowMessageBatchPushHeaders) SetXAcsDingtalkAccessToken(v string) *ServiceWindowMessageBatchPushHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type ServiceWindowMessageBatchPushRequest struct {
	Detail             *ServiceWindowMessageBatchPushRequestDetail `json:"detail,omitempty" xml:"detail,omitempty" type:"Struct"`
	BizId              *string                                     `json:"bizId,omitempty" xml:"bizId,omitempty"`
	DingIsvOrgId       *int64                                      `json:"dingIsvOrgId,omitempty" xml:"dingIsvOrgId,omitempty"`
	DingOrgId          *int64                                      `json:"dingOrgId,omitempty" xml:"dingOrgId,omitempty"`
	DingTokenGrantType *int64                                      `json:"dingTokenGrantType,omitempty" xml:"dingTokenGrantType,omitempty"`
	DingSuiteKey       *string                                     `json:"dingSuiteKey,omitempty" xml:"dingSuiteKey,omitempty"`
}

func (s ServiceWindowMessageBatchPushRequest) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequest) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequest) SetDetail(v *ServiceWindowMessageBatchPushRequestDetail) *ServiceWindowMessageBatchPushRequest {
	s.Detail = v
	return s
}

func (s *ServiceWindowMessageBatchPushRequest) SetBizId(v string) *ServiceWindowMessageBatchPushRequest {
	s.BizId = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequest) SetDingIsvOrgId(v int64) *ServiceWindowMessageBatchPushRequest {
	s.DingIsvOrgId = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequest) SetDingOrgId(v int64) *ServiceWindowMessageBatchPushRequest {
	s.DingOrgId = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequest) SetDingTokenGrantType(v int64) *ServiceWindowMessageBatchPushRequest {
	s.DingTokenGrantType = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequest) SetDingSuiteKey(v string) *ServiceWindowMessageBatchPushRequest {
	s.DingSuiteKey = &v
	return s
}

type ServiceWindowMessageBatchPushRequestDetail struct {
	MsgType      *string                                                `json:"msgType,omitempty" xml:"msgType,omitempty"`
	Uuid         *string                                                `json:"uuid,omitempty" xml:"uuid,omitempty"`
	BizRequestId *string                                                `json:"bizRequestId,omitempty" xml:"bizRequestId,omitempty"`
	UserIdList   []*string                                              `json:"userIdList,omitempty" xml:"userIdList,omitempty" type:"Repeated"`
	MessageBody  *ServiceWindowMessageBatchPushRequestDetailMessageBody `json:"messageBody,omitempty" xml:"messageBody,omitempty" type:"Struct"`
	SendToAll    *bool                                                  `json:"sendToAll,omitempty" xml:"sendToAll,omitempty"`
}

func (s ServiceWindowMessageBatchPushRequestDetail) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetail) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetail) SetMsgType(v string) *ServiceWindowMessageBatchPushRequestDetail {
	s.MsgType = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetail) SetUuid(v string) *ServiceWindowMessageBatchPushRequestDetail {
	s.Uuid = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetail) SetBizRequestId(v string) *ServiceWindowMessageBatchPushRequestDetail {
	s.BizRequestId = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetail) SetUserIdList(v []*string) *ServiceWindowMessageBatchPushRequestDetail {
	s.UserIdList = v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetail) SetMessageBody(v *ServiceWindowMessageBatchPushRequestDetailMessageBody) *ServiceWindowMessageBatchPushRequestDetail {
	s.MessageBody = v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetail) SetSendToAll(v bool) *ServiceWindowMessageBatchPushRequestDetail {
	s.SendToAll = &v
	return s
}

type ServiceWindowMessageBatchPushRequestDetailMessageBody struct {
	Text       *ServiceWindowMessageBatchPushRequestDetailMessageBodyText       `json:"text,omitempty" xml:"text,omitempty" type:"Struct"`
	Markdown   *ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown   `json:"markdown,omitempty" xml:"markdown,omitempty" type:"Struct"`
	Link       *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink       `json:"link,omitempty" xml:"link,omitempty" type:"Struct"`
	ActionCard *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard `json:"actionCard,omitempty" xml:"actionCard,omitempty" type:"Struct"`
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBody) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBody) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBody) SetText(v *ServiceWindowMessageBatchPushRequestDetailMessageBodyText) *ServiceWindowMessageBatchPushRequestDetailMessageBody {
	s.Text = v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBody) SetMarkdown(v *ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown) *ServiceWindowMessageBatchPushRequestDetailMessageBody {
	s.Markdown = v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBody) SetLink(v *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) *ServiceWindowMessageBatchPushRequestDetailMessageBody {
	s.Link = v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBody) SetActionCard(v *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) *ServiceWindowMessageBatchPushRequestDetailMessageBody {
	s.ActionCard = v
	return s
}

type ServiceWindowMessageBatchPushRequestDetailMessageBodyText struct {
	Content *string `json:"content,omitempty" xml:"content,omitempty"`
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyText) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyText) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyText) SetContent(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyText {
	s.Content = &v
	return s
}

type ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown struct {
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	Text  *string `json:"text,omitempty" xml:"text,omitempty"`
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown) SetTitle(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown {
	s.Title = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown) SetText(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown {
	s.Text = &v
	return s
}

type ServiceWindowMessageBatchPushRequestDetailMessageBodyLink struct {
	PicUrl     *string `json:"picUrl,omitempty" xml:"picUrl,omitempty"`
	MessageUrl *string `json:"messageUrl,omitempty" xml:"messageUrl,omitempty"`
	Title      *string `json:"title,omitempty" xml:"title,omitempty"`
	Text       *string `json:"text,omitempty" xml:"text,omitempty"`
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) SetPicUrl(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink {
	s.PicUrl = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) SetMessageUrl(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink {
	s.MessageUrl = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) SetTitle(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink {
	s.Title = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink) SetText(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyLink {
	s.Text = &v
	return s
}

type ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard struct {
	ButtonOrientation *string                                                                      `json:"buttonOrientation,omitempty" xml:"buttonOrientation,omitempty"`
	SingleUrl         *string                                                                      `json:"singleUrl,omitempty" xml:"singleUrl,omitempty"`
	SingleTitle       *string                                                                      `json:"singleTitle,omitempty" xml:"singleTitle,omitempty"`
	Markdown          *string                                                                      `json:"markdown,omitempty" xml:"markdown,omitempty"`
	Title             *string                                                                      `json:"title,omitempty" xml:"title,omitempty"`
	ButtonList        []*ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList `json:"buttonList,omitempty" xml:"buttonList,omitempty" type:"Repeated"`
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) SetButtonOrientation(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard {
	s.ButtonOrientation = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) SetSingleUrl(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard {
	s.SingleUrl = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) SetSingleTitle(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard {
	s.SingleTitle = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) SetMarkdown(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard {
	s.Markdown = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) SetTitle(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard {
	s.Title = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard) SetButtonList(v []*ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard {
	s.ButtonList = v
	return s
}

type ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList struct {
	Title     *string `json:"title,omitempty" xml:"title,omitempty"`
	ActionUrl *string `json:"actionUrl,omitempty" xml:"actionUrl,omitempty"`
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList) SetTitle(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList {
	s.Title = &v
	return s
}

func (s *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList) SetActionUrl(v string) *ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList {
	s.ActionUrl = &v
	return s
}

type ServiceWindowMessageBatchPushResponseBody struct {
	// result
	Result    *ServiceWindowMessageBatchPushResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
	RequestId *string                                          `json:"requestId,omitempty" xml:"requestId,omitempty"`
}

func (s ServiceWindowMessageBatchPushResponseBody) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushResponseBody) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushResponseBody) SetResult(v *ServiceWindowMessageBatchPushResponseBodyResult) *ServiceWindowMessageBatchPushResponseBody {
	s.Result = v
	return s
}

func (s *ServiceWindowMessageBatchPushResponseBody) SetRequestId(v string) *ServiceWindowMessageBatchPushResponseBody {
	s.RequestId = &v
	return s
}

type ServiceWindowMessageBatchPushResponseBodyResult struct {
	OpenPushId *string `json:"openPushId,omitempty" xml:"openPushId,omitempty"`
}

func (s ServiceWindowMessageBatchPushResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushResponseBodyResult) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushResponseBodyResult) SetOpenPushId(v string) *ServiceWindowMessageBatchPushResponseBodyResult {
	s.OpenPushId = &v
	return s
}

type ServiceWindowMessageBatchPushResponse struct {
	Headers map[string]*string                         `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *ServiceWindowMessageBatchPushResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s ServiceWindowMessageBatchPushResponse) String() string {
	return tea.Prettify(s)
}

func (s ServiceWindowMessageBatchPushResponse) GoString() string {
	return s.String()
}

func (s *ServiceWindowMessageBatchPushResponse) SetHeaders(v map[string]*string) *ServiceWindowMessageBatchPushResponse {
	s.Headers = v
	return s
}

func (s *ServiceWindowMessageBatchPushResponse) SetBody(v *ServiceWindowMessageBatchPushResponseBody) *ServiceWindowMessageBatchPushResponse {
	s.Body = v
	return s
}

type DeleteCrmFormInstanceHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DeleteCrmFormInstanceHeaders) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmFormInstanceHeaders) GoString() string {
	return s.String()
}

func (s *DeleteCrmFormInstanceHeaders) SetCommonHeaders(v map[string]*string) *DeleteCrmFormInstanceHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DeleteCrmFormInstanceHeaders) SetXAcsDingtalkAccessToken(v string) *DeleteCrmFormInstanceHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DeleteCrmFormInstanceRequest struct {
	// 当前操作人id
	CurrentOperatorUserId *string `json:"currentOperatorUserId,omitempty" xml:"currentOperatorUserId,omitempty"`
	// 模版名称
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s DeleteCrmFormInstanceRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmFormInstanceRequest) GoString() string {
	return s.String()
}

func (s *DeleteCrmFormInstanceRequest) SetCurrentOperatorUserId(v string) *DeleteCrmFormInstanceRequest {
	s.CurrentOperatorUserId = &v
	return s
}

func (s *DeleteCrmFormInstanceRequest) SetName(v string) *DeleteCrmFormInstanceRequest {
	s.Name = &v
	return s
}

type DeleteCrmFormInstanceResponseBody struct {
	// 被删除的实例id
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
}

func (s DeleteCrmFormInstanceResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmFormInstanceResponseBody) GoString() string {
	return s.String()
}

func (s *DeleteCrmFormInstanceResponseBody) SetInstanceId(v string) *DeleteCrmFormInstanceResponseBody {
	s.InstanceId = &v
	return s
}

type DeleteCrmFormInstanceResponse struct {
	Headers map[string]*string                 `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *DeleteCrmFormInstanceResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s DeleteCrmFormInstanceResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmFormInstanceResponse) GoString() string {
	return s.String()
}

func (s *DeleteCrmFormInstanceResponse) SetHeaders(v map[string]*string) *DeleteCrmFormInstanceResponse {
	s.Headers = v
	return s
}

func (s *DeleteCrmFormInstanceResponse) SetBody(v *DeleteCrmFormInstanceResponseBody) *DeleteCrmFormInstanceResponse {
	s.Body = v
	return s
}

type GetCrmRolePermissionHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetCrmRolePermissionHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionHeaders) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionHeaders) SetCommonHeaders(v map[string]*string) *GetCrmRolePermissionHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetCrmRolePermissionHeaders) SetXAcsDingtalkAccessToken(v string) *GetCrmRolePermissionHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetCrmRolePermissionRequest struct {
	// 表单标识（formCode & bizType二选一）
	FormCode *string `json:"formCode,omitempty" xml:"formCode,omitempty"`
	// 表单业务标识（formCode & bizType二选一）
	BizType *string `json:"bizType,omitempty" xml:"bizType,omitempty"`
}

func (s GetCrmRolePermissionRequest) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionRequest) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionRequest) SetFormCode(v string) *GetCrmRolePermissionRequest {
	s.FormCode = &v
	return s
}

func (s *GetCrmRolePermissionRequest) SetBizType(v string) *GetCrmRolePermissionRequest {
	s.BizType = &v
	return s
}

type GetCrmRolePermissionResponseBody struct {
	// CRM表单权限配置
	Permissions []*GetCrmRolePermissionResponseBodyPermissions `json:"permissions,omitempty" xml:"permissions,omitempty" type:"Repeated"`
}

func (s GetCrmRolePermissionResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBody) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBody) SetPermissions(v []*GetCrmRolePermissionResponseBodyPermissions) *GetCrmRolePermissionResponseBody {
	s.Permissions = v
	return s
}

type GetCrmRolePermissionResponseBodyPermissions struct {
	// 权限组配置
	RoleMemberList []*GetCrmRolePermissionResponseBodyPermissionsRoleMemberList `json:"roleMemberList,omitempty" xml:"roleMemberList,omitempty" type:"Repeated"`
	// 权限组适用范围配置
	ManagingScopeList []*GetCrmRolePermissionResponseBodyPermissionsManagingScopeList `json:"managingScopeList,omitempty" xml:"managingScopeList,omitempty" type:"Repeated"`
	// 是否是默认权限
	DefaultRole *bool `json:"defaultRole,omitempty" xml:"defaultRole,omitempty"`
	// 资源id
	ResourceId *string `json:"resourceId,omitempty" xml:"resourceId,omitempty"`
	// 权限组名称
	RoleName *string `json:"roleName,omitempty" xml:"roleName,omitempty"`
	// 权限组id
	RoleId *float64 `json:"roleId,omitempty" xml:"roleId,omitempty"`
	// 操作范围
	OperateScopes []*GetCrmRolePermissionResponseBodyPermissionsOperateScopes `json:"operateScopes,omitempty" xml:"operateScopes,omitempty" type:"Repeated"`
	// 字段权限
	FieldScopes []*GetCrmRolePermissionResponseBodyPermissionsFieldScopes `json:"fieldScopes,omitempty" xml:"fieldScopes,omitempty" type:"Repeated"`
}

func (s GetCrmRolePermissionResponseBodyPermissions) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBodyPermissions) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetRoleMemberList(v []*GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) *GetCrmRolePermissionResponseBodyPermissions {
	s.RoleMemberList = v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetManagingScopeList(v []*GetCrmRolePermissionResponseBodyPermissionsManagingScopeList) *GetCrmRolePermissionResponseBodyPermissions {
	s.ManagingScopeList = v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetDefaultRole(v bool) *GetCrmRolePermissionResponseBodyPermissions {
	s.DefaultRole = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetResourceId(v string) *GetCrmRolePermissionResponseBodyPermissions {
	s.ResourceId = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetRoleName(v string) *GetCrmRolePermissionResponseBodyPermissions {
	s.RoleName = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetRoleId(v float64) *GetCrmRolePermissionResponseBodyPermissions {
	s.RoleId = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetOperateScopes(v []*GetCrmRolePermissionResponseBodyPermissionsOperateScopes) *GetCrmRolePermissionResponseBodyPermissions {
	s.OperateScopes = v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissions) SetFieldScopes(v []*GetCrmRolePermissionResponseBodyPermissionsFieldScopes) *GetCrmRolePermissionResponseBodyPermissions {
	s.FieldScopes = v
	return s
}

type GetCrmRolePermissionResponseBodyPermissionsRoleMemberList struct {
	// 角色名
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// 角色的userId
	StaffId *string `json:"staffId,omitempty" xml:"staffId,omitempty"`
	// 角色类型
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
	// 角色值
	MemberId *string `json:"memberId,omitempty" xml:"memberId,omitempty"`
}

func (s GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) SetName(v string) *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList {
	s.Name = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) SetStaffId(v string) *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList {
	s.StaffId = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) SetType(v string) *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList {
	s.Type = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList) SetMemberId(v string) *GetCrmRolePermissionResponseBodyPermissionsRoleMemberList {
	s.MemberId = &v
	return s
}

type GetCrmRolePermissionResponseBodyPermissionsManagingScopeList struct {
	// 管理范围类型
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
	// 是否是主管
	Manager *bool `json:"manager,omitempty" xml:"manager,omitempty"`
	// 扩展信息
	Ext *GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt `json:"ext,omitempty" xml:"ext,omitempty" type:"Struct"`
}

func (s GetCrmRolePermissionResponseBodyPermissionsManagingScopeList) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBodyPermissionsManagingScopeList) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBodyPermissionsManagingScopeList) SetType(v string) *GetCrmRolePermissionResponseBodyPermissionsManagingScopeList {
	s.Type = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsManagingScopeList) SetManager(v bool) *GetCrmRolePermissionResponseBodyPermissionsManagingScopeList {
	s.Manager = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsManagingScopeList) SetExt(v *GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt) *GetCrmRolePermissionResponseBodyPermissionsManagingScopeList {
	s.Ext = v
	return s
}

type GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt struct {
	// 管理员工列表
	StaffIdList []*string `json:"staffIdList,omitempty" xml:"staffIdList,omitempty" type:"Repeated"`
	// 管理部门列表
	DeptIdList []*float64 `json:"deptIdList,omitempty" xml:"deptIdList,omitempty" type:"Repeated"`
}

func (s GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt) SetStaffIdList(v []*string) *GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt {
	s.StaffIdList = v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt) SetDeptIdList(v []*float64) *GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt {
	s.DeptIdList = v
	return s
}

type GetCrmRolePermissionResponseBodyPermissionsOperateScopes struct {
	// 操作范围类型
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
	// 是否有权限
	HasAuth *bool `json:"hasAuth,omitempty" xml:"hasAuth,omitempty"`
}

func (s GetCrmRolePermissionResponseBodyPermissionsOperateScopes) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBodyPermissionsOperateScopes) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBodyPermissionsOperateScopes) SetType(v string) *GetCrmRolePermissionResponseBodyPermissionsOperateScopes {
	s.Type = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsOperateScopes) SetHasAuth(v bool) *GetCrmRolePermissionResponseBodyPermissionsOperateScopes {
	s.HasAuth = &v
	return s
}

type GetCrmRolePermissionResponseBodyPermissionsFieldScopes struct {
	// 字段id
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	// 字段权限点
	FieldActions []*string `json:"fieldActions,omitempty" xml:"fieldActions,omitempty" type:"Repeated"`
}

func (s GetCrmRolePermissionResponseBodyPermissionsFieldScopes) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponseBodyPermissionsFieldScopes) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponseBodyPermissionsFieldScopes) SetFieldId(v string) *GetCrmRolePermissionResponseBodyPermissionsFieldScopes {
	s.FieldId = &v
	return s
}

func (s *GetCrmRolePermissionResponseBodyPermissionsFieldScopes) SetFieldActions(v []*string) *GetCrmRolePermissionResponseBodyPermissionsFieldScopes {
	s.FieldActions = v
	return s
}

type GetCrmRolePermissionResponse struct {
	Headers map[string]*string                `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *GetCrmRolePermissionResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s GetCrmRolePermissionResponse) String() string {
	return tea.Prettify(s)
}

func (s GetCrmRolePermissionResponse) GoString() string {
	return s.String()
}

func (s *GetCrmRolePermissionResponse) SetHeaders(v map[string]*string) *GetCrmRolePermissionResponse {
	s.Headers = v
	return s
}

func (s *GetCrmRolePermissionResponse) SetBody(v *GetCrmRolePermissionResponseBody) *GetCrmRolePermissionResponse {
	s.Body = v
	return s
}

type BatchSendOfficialAccountOTOMessageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageHeaders) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageHeaders) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageHeaders) SetCommonHeaders(v map[string]*string) *BatchSendOfficialAccountOTOMessageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageHeaders) SetXAcsDingtalkAccessToken(v string) *BatchSendOfficialAccountOTOMessageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type BatchSendOfficialAccountOTOMessageRequest struct {
	// 消息详情
	Detail *BatchSendOfficialAccountOTOMessageRequestDetail `json:"detail,omitempty" xml:"detail,omitempty" type:"Struct"`
	// 服务窗授权的调用方标识，可空
	BizId *string `json:"bizId,omitempty" xml:"bizId,omitempty"`
	// 服务窗帐号ID
	AccountId          *string `json:"accountId,omitempty" xml:"accountId,omitempty"`
	DingIsvOrgId       *int64  `json:"dingIsvOrgId,omitempty" xml:"dingIsvOrgId,omitempty"`
	DingOrgId          *int64  `json:"dingOrgId,omitempty" xml:"dingOrgId,omitempty"`
	DingTokenGrantType *int64  `json:"dingTokenGrantType,omitempty" xml:"dingTokenGrantType,omitempty"`
	DingSuiteKey       *string `json:"dingSuiteKey,omitempty" xml:"dingSuiteKey,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageRequest) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequest) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetDetail(v *BatchSendOfficialAccountOTOMessageRequestDetail) *BatchSendOfficialAccountOTOMessageRequest {
	s.Detail = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetBizId(v string) *BatchSendOfficialAccountOTOMessageRequest {
	s.BizId = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetAccountId(v string) *BatchSendOfficialAccountOTOMessageRequest {
	s.AccountId = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetDingIsvOrgId(v int64) *BatchSendOfficialAccountOTOMessageRequest {
	s.DingIsvOrgId = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetDingOrgId(v int64) *BatchSendOfficialAccountOTOMessageRequest {
	s.DingOrgId = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetDingTokenGrantType(v int64) *BatchSendOfficialAccountOTOMessageRequest {
	s.DingTokenGrantType = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequest) SetDingSuiteKey(v string) *BatchSendOfficialAccountOTOMessageRequest {
	s.DingSuiteKey = &v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetail struct {
	// 消息类型
	MsgType *string `json:"msgType,omitempty" xml:"msgType,omitempty"`
	// 消息请求唯一ID
	Uuid *string `json:"uuid,omitempty" xml:"uuid,omitempty"`
	// 业务请求标识，当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
	BizRequestId *string `json:"bizRequestId,omitempty" xml:"bizRequestId,omitempty"`
	// 消息接收人列表，最多支持1000人
	UserIdList []*string `json:"userIdList,omitempty" xml:"userIdList,omitempty" type:"Repeated"`
	// 消息体
	MessageBody *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody `json:"messageBody,omitempty" xml:"messageBody,omitempty" type:"Struct"`
	// 全员群发
	SendToAll *bool `json:"sendToAll,omitempty" xml:"sendToAll,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetail) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetail) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetail) SetMsgType(v string) *BatchSendOfficialAccountOTOMessageRequestDetail {
	s.MsgType = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetail) SetUuid(v string) *BatchSendOfficialAccountOTOMessageRequestDetail {
	s.Uuid = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetail) SetBizRequestId(v string) *BatchSendOfficialAccountOTOMessageRequestDetail {
	s.BizRequestId = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetail) SetUserIdList(v []*string) *BatchSendOfficialAccountOTOMessageRequestDetail {
	s.UserIdList = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetail) SetMessageBody(v *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) *BatchSendOfficialAccountOTOMessageRequestDetail {
	s.MessageBody = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetail) SetSendToAll(v bool) *BatchSendOfficialAccountOTOMessageRequestDetail {
	s.SendToAll = &v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetailMessageBody struct {
	// 文本消息体  对于文本类型消息时必填
	Text *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText `json:"text,omitempty" xml:"text,omitempty" type:"Struct"`
	// markdown消息，仅对消息类型为markdown时有效
	Markdown *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown `json:"markdown,omitempty" xml:"markdown,omitempty" type:"Struct"`
	// 链接消息类型
	Link *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink `json:"link,omitempty" xml:"link,omitempty" type:"Struct"`
	// 卡片消息
	ActionCard *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard `json:"actionCard,omitempty" xml:"actionCard,omitempty" type:"Struct"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) SetText(v *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.Text = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) SetMarkdown(v *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.Markdown = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) SetLink(v *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.Link = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody) SetActionCard(v *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.ActionCard = v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText struct {
	// 消息内容，建议500字符以内。
	Content *string `json:"content,omitempty" xml:"content,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText) SetContent(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText {
	s.Content = &v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown struct {
	// 首屏会话透出的展示内容。
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// markdown格式的消息，建议500字符以内。
	Text *string `json:"text,omitempty" xml:"text,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) SetTitle(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown {
	s.Title = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) SetText(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown {
	s.Text = &v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink struct {
	// 图片地址
	PicUrl *string `json:"picUrl,omitempty" xml:"picUrl,omitempty"`
	// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
	MessageUrl *string `json:"messageUrl,omitempty" xml:"messageUrl,omitempty"`
	// 消息标题，建议100字符以内。
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// 消息描述，建议500字符以内。
	Text *string `json:"text,omitempty" xml:"text,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetPicUrl(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.PicUrl = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetMessageUrl(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.MessageUrl = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetTitle(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.Title = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetText(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.Text = &v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard struct {
	// 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
	ButtonOrientation *string `json:"buttonOrientation,omitempty" xml:"buttonOrientation,omitempty"`
	// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
	SingleUrl *string `json:"singleUrl,omitempty" xml:"singleUrl,omitempty"`
	// 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
	SingleTitle *string `json:"singleTitle,omitempty" xml:"singleTitle,omitempty"`
	// 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
	Markdown *string `json:"markdown,omitempty" xml:"markdown,omitempty"`
	// 透出到会话列表和通知的文案
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
	ButtonList []*BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList `json:"buttonList,omitempty" xml:"buttonList,omitempty" type:"Repeated"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetButtonOrientation(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.ButtonOrientation = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetSingleUrl(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.SingleUrl = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetSingleTitle(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.SingleTitle = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetMarkdown(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.Markdown = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetTitle(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.Title = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetButtonList(v []*BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.ButtonList = v
	return s
}

type BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList struct {
	// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// 使用独立跳转ActionCard样式时的跳转链接。
	ActionUrl *string `json:"actionUrl,omitempty" xml:"actionUrl,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) SetTitle(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList {
	s.Title = &v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) SetActionUrl(v string) *BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList {
	s.ActionUrl = &v
	return s
}

type BatchSendOfficialAccountOTOMessageResponseBody struct {
	// result
	Result *BatchSendOfficialAccountOTOMessageResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
	// 开放API
	RequestId *string `json:"requestId,omitempty" xml:"requestId,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageResponseBody) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageResponseBody) SetResult(v *BatchSendOfficialAccountOTOMessageResponseBodyResult) *BatchSendOfficialAccountOTOMessageResponseBody {
	s.Result = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageResponseBody) SetRequestId(v string) *BatchSendOfficialAccountOTOMessageResponseBody {
	s.RequestId = &v
	return s
}

type BatchSendOfficialAccountOTOMessageResponseBodyResult struct {
	OpenPushId *string `json:"openPushId,omitempty" xml:"openPushId,omitempty"`
}

func (s BatchSendOfficialAccountOTOMessageResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageResponseBodyResult) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageResponseBodyResult) SetOpenPushId(v string) *BatchSendOfficialAccountOTOMessageResponseBodyResult {
	s.OpenPushId = &v
	return s
}

type BatchSendOfficialAccountOTOMessageResponse struct {
	Headers map[string]*string                              `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *BatchSendOfficialAccountOTOMessageResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s BatchSendOfficialAccountOTOMessageResponse) String() string {
	return tea.Prettify(s)
}

func (s BatchSendOfficialAccountOTOMessageResponse) GoString() string {
	return s.String()
}

func (s *BatchSendOfficialAccountOTOMessageResponse) SetHeaders(v map[string]*string) *BatchSendOfficialAccountOTOMessageResponse {
	s.Headers = v
	return s
}

func (s *BatchSendOfficialAccountOTOMessageResponse) SetBody(v *BatchSendOfficialAccountOTOMessageResponseBody) *BatchSendOfficialAccountOTOMessageResponse {
	s.Body = v
	return s
}

type GetOfficialAccountContactInfoHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetOfficialAccountContactInfoHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactInfoHeaders) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactInfoHeaders) SetCommonHeaders(v map[string]*string) *GetOfficialAccountContactInfoHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetOfficialAccountContactInfoHeaders) SetXAcsDingtalkAccessToken(v string) *GetOfficialAccountContactInfoHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetOfficialAccountContactInfoResponseBody struct {
	// 联系人主企业名称
	CorpName *string `json:"corpName,omitempty" xml:"corpName,omitempty"`
	// 手机号
	Mobile *string `json:"mobile,omitempty" xml:"mobile,omitempty"`
	// 手机号国家码
	StateCode *string `json:"stateCode,omitempty" xml:"stateCode,omitempty"`
	// 联系人的unionId
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
	// 已授权的字段
	AuthItems []*string `json:"authItems,omitempty" xml:"authItems,omitempty" type:"Repeated"`
	// 已授权的字段
	UserInfos []*string `json:"userInfos,omitempty" xml:"userInfos,omitempty" type:"Repeated"`
}

func (s GetOfficialAccountContactInfoResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactInfoResponseBody) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactInfoResponseBody) SetCorpName(v string) *GetOfficialAccountContactInfoResponseBody {
	s.CorpName = &v
	return s
}

func (s *GetOfficialAccountContactInfoResponseBody) SetMobile(v string) *GetOfficialAccountContactInfoResponseBody {
	s.Mobile = &v
	return s
}

func (s *GetOfficialAccountContactInfoResponseBody) SetStateCode(v string) *GetOfficialAccountContactInfoResponseBody {
	s.StateCode = &v
	return s
}

func (s *GetOfficialAccountContactInfoResponseBody) SetUnionId(v string) *GetOfficialAccountContactInfoResponseBody {
	s.UnionId = &v
	return s
}

func (s *GetOfficialAccountContactInfoResponseBody) SetAuthItems(v []*string) *GetOfficialAccountContactInfoResponseBody {
	s.AuthItems = v
	return s
}

func (s *GetOfficialAccountContactInfoResponseBody) SetUserInfos(v []*string) *GetOfficialAccountContactInfoResponseBody {
	s.UserInfos = v
	return s
}

type GetOfficialAccountContactInfoResponse struct {
	Headers map[string]*string                         `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *GetOfficialAccountContactInfoResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s GetOfficialAccountContactInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountContactInfoResponse) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountContactInfoResponse) SetHeaders(v map[string]*string) *GetOfficialAccountContactInfoResponse {
	s.Headers = v
	return s
}

func (s *GetOfficialAccountContactInfoResponse) SetBody(v *GetOfficialAccountContactInfoResponseBody) *GetOfficialAccountContactInfoResponse {
	s.Body = v
	return s
}

type QueryAllCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryAllCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerHeaders) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerHeaders) SetCommonHeaders(v map[string]*string) *QueryAllCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryAllCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *QueryAllCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryAllCustomerRequest struct {
	DingIsvOrgId       *int64  `json:"dingIsvOrgId,omitempty" xml:"dingIsvOrgId,omitempty"`
	DingOrgId          *int64  `json:"dingOrgId,omitempty" xml:"dingOrgId,omitempty"`
	DingTokenGrantType *int64  `json:"dingTokenGrantType,omitempty" xml:"dingTokenGrantType,omitempty"`
	DingCorpId         *string `json:"dingCorpId,omitempty" xml:"dingCorpId,omitempty"`
	DingSuiteKey       *string `json:"dingSuiteKey,omitempty" xml:"dingSuiteKey,omitempty"`
	// 用户ID
	OperatorUserId *string `json:"operatorUserId,omitempty" xml:"operatorUserId,omitempty"`
	// 翻页size
	MaxResults *int64 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	// 分页游标，第一次调用传空或者null
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 数据类型（私海个人客户：crm_customer_personal，私海企业客户：crm_customer，公海个人客户：open_customer_personal，公海企业客户：open_customer_org）
	ObjectType *string `json:"objectType,omitempty" xml:"objectType,omitempty"`
}

func (s QueryAllCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerRequest) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerRequest) SetDingIsvOrgId(v int64) *QueryAllCustomerRequest {
	s.DingIsvOrgId = &v
	return s
}

func (s *QueryAllCustomerRequest) SetDingOrgId(v int64) *QueryAllCustomerRequest {
	s.DingOrgId = &v
	return s
}

func (s *QueryAllCustomerRequest) SetDingTokenGrantType(v int64) *QueryAllCustomerRequest {
	s.DingTokenGrantType = &v
	return s
}

func (s *QueryAllCustomerRequest) SetDingCorpId(v string) *QueryAllCustomerRequest {
	s.DingCorpId = &v
	return s
}

func (s *QueryAllCustomerRequest) SetDingSuiteKey(v string) *QueryAllCustomerRequest {
	s.DingSuiteKey = &v
	return s
}

func (s *QueryAllCustomerRequest) SetOperatorUserId(v string) *QueryAllCustomerRequest {
	s.OperatorUserId = &v
	return s
}

func (s *QueryAllCustomerRequest) SetMaxResults(v int64) *QueryAllCustomerRequest {
	s.MaxResults = &v
	return s
}

func (s *QueryAllCustomerRequest) SetNextToken(v string) *QueryAllCustomerRequest {
	s.NextToken = &v
	return s
}

func (s *QueryAllCustomerRequest) SetObjectType(v string) *QueryAllCustomerRequest {
	s.ObjectType = &v
	return s
}

type QueryAllCustomerResponseBody struct {
	// 分页结果
	Result *QueryAllCustomerResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s QueryAllCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerResponseBody) SetResult(v *QueryAllCustomerResponseBodyResult) *QueryAllCustomerResponseBody {
	s.Result = v
	return s
}

type QueryAllCustomerResponseBodyResult struct {
	// 下一页的游标，为null则表示无数据
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 客户数据节点
	Values []*QueryAllCustomerResponseBodyResultValues `json:"values,omitempty" xml:"values,omitempty" type:"Repeated"`
	// 分页大小
	MaxResults *int64 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
}

func (s QueryAllCustomerResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerResponseBodyResult) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerResponseBodyResult) SetNextToken(v string) *QueryAllCustomerResponseBodyResult {
	s.NextToken = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResult) SetValues(v []*QueryAllCustomerResponseBodyResultValues) *QueryAllCustomerResponseBodyResult {
	s.Values = v
	return s
}

func (s *QueryAllCustomerResponseBodyResult) SetMaxResults(v int64) *QueryAllCustomerResponseBodyResult {
	s.MaxResults = &v
	return s
}

type QueryAllCustomerResponseBodyResultValues struct {
	// 创建记录的用户昵称
	CreatorNick *string `json:"creatorNick,omitempty" xml:"creatorNick,omitempty"`
	// 记录修改时间
	ModifyTime *string `json:"modifyTime,omitempty" xml:"modifyTime,omitempty"`
	// 创建记录的用户ID
	CreatorUserId *string `json:"creatorUserId,omitempty" xml:"creatorUserId,omitempty"`
	// 数据ID
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	// 数据内容
	Data map[string]interface{} `json:"data,omitempty" xml:"data,omitempty"`
	// 扩展数据内容
	ExtendData map[string]interface{} `json:"extendData,omitempty" xml:"extendData,omitempty"`
	// 记录创建时间
	CreateTime *string `json:"createTime,omitempty" xml:"createTime,omitempty"`
	// 系统自动生成
	OrgId *int64 `json:"orgId,omitempty" xml:"orgId,omitempty"`
	// 数据类型
	ObjectType *string `json:"objectType,omitempty" xml:"objectType,omitempty"`
	// 数据权限信息
	Permission *QueryAllCustomerResponseBodyResultValuesPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
	// 审批结果
	ProcessOutResult *string `json:"processOutResult,omitempty" xml:"processOutResult,omitempty"`
	// 审批状态
	ProcessInstanceStatus *string `json:"processInstanceStatus,omitempty" xml:"processInstanceStatus,omitempty"`
}

func (s QueryAllCustomerResponseBodyResultValues) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerResponseBodyResultValues) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerResponseBodyResultValues) SetCreatorNick(v string) *QueryAllCustomerResponseBodyResultValues {
	s.CreatorNick = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetModifyTime(v string) *QueryAllCustomerResponseBodyResultValues {
	s.ModifyTime = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetCreatorUserId(v string) *QueryAllCustomerResponseBodyResultValues {
	s.CreatorUserId = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetInstanceId(v string) *QueryAllCustomerResponseBodyResultValues {
	s.InstanceId = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetData(v map[string]interface{}) *QueryAllCustomerResponseBodyResultValues {
	s.Data = v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetExtendData(v map[string]interface{}) *QueryAllCustomerResponseBodyResultValues {
	s.ExtendData = v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetCreateTime(v string) *QueryAllCustomerResponseBodyResultValues {
	s.CreateTime = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetOrgId(v int64) *QueryAllCustomerResponseBodyResultValues {
	s.OrgId = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetObjectType(v string) *QueryAllCustomerResponseBodyResultValues {
	s.ObjectType = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetPermission(v *QueryAllCustomerResponseBodyResultValuesPermission) *QueryAllCustomerResponseBodyResultValues {
	s.Permission = v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetProcessOutResult(v string) *QueryAllCustomerResponseBodyResultValues {
	s.ProcessOutResult = &v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValues) SetProcessInstanceStatus(v string) *QueryAllCustomerResponseBodyResultValues {
	s.ProcessInstanceStatus = &v
	return s
}

type QueryAllCustomerResponseBodyResultValuesPermission struct {
	// 协同人用户ID列表
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
	// 负责人用户ID列表
	OwnerStaffIds []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
}

func (s QueryAllCustomerResponseBodyResultValuesPermission) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerResponseBodyResultValuesPermission) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerResponseBodyResultValuesPermission) SetParticipantStaffIds(v []*string) *QueryAllCustomerResponseBodyResultValuesPermission {
	s.ParticipantStaffIds = v
	return s
}

func (s *QueryAllCustomerResponseBodyResultValuesPermission) SetOwnerStaffIds(v []*string) *QueryAllCustomerResponseBodyResultValuesPermission {
	s.OwnerStaffIds = v
	return s
}

type QueryAllCustomerResponse struct {
	Headers map[string]*string            `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *QueryAllCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s QueryAllCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryAllCustomerResponse) GoString() string {
	return s.String()
}

func (s *QueryAllCustomerResponse) SetHeaders(v map[string]*string) *QueryAllCustomerResponse {
	s.Headers = v
	return s
}

func (s *QueryAllCustomerResponse) SetBody(v *QueryAllCustomerResponseBody) *QueryAllCustomerResponse {
	s.Body = v
	return s
}

type UpdateRelationMetaFieldHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateRelationMetaFieldHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldHeaders) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldHeaders) SetCommonHeaders(v map[string]*string) *UpdateRelationMetaFieldHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateRelationMetaFieldHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateRelationMetaFieldHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateRelationMetaFieldRequest struct {
	Tenant         *string                                       `json:"tenant,omitempty" xml:"tenant,omitempty"`
	OperatorUserId *string                                       `json:"operatorUserId,omitempty" xml:"operatorUserId,omitempty"`
	RelationType   *string                                       `json:"relationType,omitempty" xml:"relationType,omitempty"`
	FieldDTOList   []*UpdateRelationMetaFieldRequestFieldDTOList `json:"fieldDTOList,omitempty" xml:"fieldDTOList,omitempty" type:"Repeated"`
}

func (s UpdateRelationMetaFieldRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldRequest) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldRequest) SetTenant(v string) *UpdateRelationMetaFieldRequest {
	s.Tenant = &v
	return s
}

func (s *UpdateRelationMetaFieldRequest) SetOperatorUserId(v string) *UpdateRelationMetaFieldRequest {
	s.OperatorUserId = &v
	return s
}

func (s *UpdateRelationMetaFieldRequest) SetRelationType(v string) *UpdateRelationMetaFieldRequest {
	s.RelationType = &v
	return s
}

func (s *UpdateRelationMetaFieldRequest) SetFieldDTOList(v []*UpdateRelationMetaFieldRequestFieldDTOList) *UpdateRelationMetaFieldRequest {
	s.FieldDTOList = v
	return s
}

type UpdateRelationMetaFieldRequestFieldDTOList struct {
	ComponentName *string                                          `json:"componentName,omitempty" xml:"componentName,omitempty"`
	Props         *UpdateRelationMetaFieldRequestFieldDTOListProps `json:"props,omitempty" xml:"props,omitempty" type:"Struct"`
}

func (s UpdateRelationMetaFieldRequestFieldDTOList) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldRequestFieldDTOList) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldRequestFieldDTOList) SetComponentName(v string) *UpdateRelationMetaFieldRequestFieldDTOList {
	s.ComponentName = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOList) SetProps(v *UpdateRelationMetaFieldRequestFieldDTOListProps) *UpdateRelationMetaFieldRequestFieldDTOList {
	s.Props = v
	return s
}

type UpdateRelationMetaFieldRequestFieldDTOListProps struct {
	FieldId                *string                                                   `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label                  *string                                                   `json:"label,omitempty" xml:"label,omitempty"`
	LabelEditableFreeze    *bool                                                     `json:"labelEditableFreeze,omitempty" xml:"labelEditableFreeze,omitempty"`
	Required               *bool                                                     `json:"required,omitempty" xml:"required,omitempty"`
	RequiredEditableFreeze *bool                                                     `json:"requiredEditableFreeze,omitempty" xml:"requiredEditableFreeze,omitempty"`
	NotPrint               *string                                                   `json:"notPrint,omitempty" xml:"notPrint,omitempty"`
	Content                *string                                                   `json:"content,omitempty" xml:"content,omitempty"`
	Format                 *string                                                   `json:"format,omitempty" xml:"format,omitempty"`
	Options                []*UpdateRelationMetaFieldRequestFieldDTOListPropsOptions `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	NotUpper               *string                                                   `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Unit                   *string                                                   `json:"unit,omitempty" xml:"unit,omitempty"`
	Placeholder            *string                                                   `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	BizAlias               *string                                                   `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Duration               *bool                                                     `json:"duration,omitempty" xml:"duration,omitempty"`
	Choice                 *int64                                                    `json:"choice,omitempty" xml:"choice,omitempty"`
	Disabled               *bool                                                     `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Align                  *string                                                   `json:"align,omitempty" xml:"align,omitempty"`
	Invisible              *bool                                                     `json:"invisible,omitempty" xml:"invisible,omitempty"`
	PayEnable              *bool                                                     `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	Link                   *string                                                   `json:"link,omitempty" xml:"link,omitempty"`
}

func (s UpdateRelationMetaFieldRequestFieldDTOListProps) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldRequestFieldDTOListProps) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetFieldId(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetLabel(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetLabelEditableFreeze(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.LabelEditableFreeze = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetRequired(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Required = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetRequiredEditableFreeze(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.RequiredEditableFreeze = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetNotPrint(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.NotPrint = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetContent(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Content = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetFormat(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Format = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetOptions(v []*UpdateRelationMetaFieldRequestFieldDTOListPropsOptions) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Options = v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetNotUpper(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.NotUpper = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetUnit(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetPlaceholder(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Placeholder = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetBizAlias(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.BizAlias = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetDuration(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Duration = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetChoice(v int64) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Choice = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetDisabled(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Disabled = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetAlign(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Align = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetInvisible(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Invisible = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetPayEnable(v bool) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.PayEnable = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListProps) SetLink(v string) *UpdateRelationMetaFieldRequestFieldDTOListProps {
	s.Link = &v
	return s
}

type UpdateRelationMetaFieldRequestFieldDTOListPropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s UpdateRelationMetaFieldRequestFieldDTOListPropsOptions) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldRequestFieldDTOListPropsOptions) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListPropsOptions) SetKey(v string) *UpdateRelationMetaFieldRequestFieldDTOListPropsOptions {
	s.Key = &v
	return s
}

func (s *UpdateRelationMetaFieldRequestFieldDTOListPropsOptions) SetValue(v string) *UpdateRelationMetaFieldRequestFieldDTOListPropsOptions {
	s.Value = &v
	return s
}

type UpdateRelationMetaFieldResponseBody struct {
	RelationMetaDTO *UpdateRelationMetaFieldResponseBodyRelationMetaDTO `json:"relationMetaDTO,omitempty" xml:"relationMetaDTO,omitempty" type:"Struct"`
}

func (s UpdateRelationMetaFieldResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBody) SetRelationMetaDTO(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTO) *UpdateRelationMetaFieldResponseBody {
	s.RelationMetaDTO = v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTO struct {
	Desc         *string                                                    `json:"desc,omitempty" xml:"desc,omitempty"`
	Items        []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems `json:"items,omitempty" xml:"items,omitempty" type:"Repeated"`
	Name         *string                                                    `json:"name,omitempty" xml:"name,omitempty"`
	RelationType *string                                                    `json:"relationType,omitempty" xml:"relationType,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTO) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTO) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTO) SetDesc(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTO {
	s.Desc = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTO) SetItems(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems) *UpdateRelationMetaFieldResponseBodyRelationMetaDTO {
	s.Items = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTO) SetName(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTO {
	s.Name = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTO) SetRelationType(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTO {
	s.RelationType = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems struct {
	Children      []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren `json:"children,omitempty" xml:"children,omitempty" type:"Repeated"`
	ComponentName *string                                                            `json:"componentName,omitempty" xml:"componentName,omitempty"`
	Props         []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps    `json:"props,omitempty" xml:"props,omitempty" type:"Repeated"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems) SetChildren(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems {
	s.Children = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems) SetComponentName(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems {
	s.ComponentName = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems) SetProps(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems {
	s.Props = v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren struct {
	ComponentName *string                                                               `json:"componentName,omitempty" xml:"componentName,omitempty"`
	Props         *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps `json:"props,omitempty" xml:"props,omitempty" type:"Struct"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren) SetComponentName(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren {
	s.ComponentName = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren) SetProps(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren {
	s.Props = v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps struct {
	Align                  *string                                                                          `json:"align,omitempty" xml:"align,omitempty"`
	BizAlias               *string                                                                          `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Choice                 *int64                                                                           `json:"choice,omitempty" xml:"choice,omitempty"`
	Content                *string                                                                          `json:"content,omitempty" xml:"content,omitempty"`
	DataSource             *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource  `json:"dataSource,omitempty" xml:"dataSource,omitempty" type:"Struct"`
	Disabled               *bool                                                                            `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Duration               *bool                                                                            `json:"duration,omitempty" xml:"duration,omitempty"`
	Fields                 []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields    `json:"fields,omitempty" xml:"fields,omitempty" type:"Repeated"`
	Format                 *string                                                                          `json:"format,omitempty" xml:"format,omitempty"`
	Formula                *string                                                                          `json:"formula,omitempty" xml:"formula,omitempty"`
	FieldId                *string                                                                          `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Invisible              *bool                                                                            `json:"invisible,omitempty" xml:"invisible,omitempty"`
	Label                  *string                                                                          `json:"label,omitempty" xml:"label,omitempty"`
	LabelEditableFreeze    *bool                                                                            `json:"labelEditableFreeze,omitempty" xml:"labelEditableFreeze,omitempty"`
	Link                   *string                                                                          `json:"link,omitempty" xml:"link,omitempty"`
	NotPrint               *string                                                                          `json:"notPrint,omitempty" xml:"notPrint,omitempty"`
	NotUpper               *string                                                                          `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Options                []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions   `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	PayEnable              *bool                                                                            `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	Placeholder            *string                                                                          `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	Required               *bool                                                                            `json:"required,omitempty" xml:"required,omitempty"`
	RequiredEditableFreeze *bool                                                                            `json:"requiredEditableFreeze,omitempty" xml:"requiredEditableFreeze,omitempty"`
	StatField              []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	Unit                   *string                                                                          `json:"unit,omitempty" xml:"unit,omitempty"`
	VerticalPrint          *bool                                                                            `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetAlign(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Align = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetBizAlias(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.BizAlias = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetChoice(v int64) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Choice = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetContent(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Content = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetDataSource(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.DataSource = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetDisabled(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Disabled = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetDuration(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Duration = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetFields(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Fields = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetFormat(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Format = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetFormula(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Formula = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetInvisible(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Invisible = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetLabelEditableFreeze(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.LabelEditableFreeze = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetLink(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Link = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetNotPrint(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.NotPrint = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetNotUpper(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.NotUpper = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetOptions(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Options = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetPayEnable(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.PayEnable = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetPlaceholder(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Placeholder = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetRequired(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Required = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetRequiredEditableFreeze(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.RequiredEditableFreeze = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetStatField(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.StatField = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps) SetVerticalPrint(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps {
	s.VerticalPrint = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource struct {
	Target *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget `json:"target,omitempty" xml:"target,omitempty" type:"Struct"`
	Type   *string                                                                               `json:"type,omitempty" xml:"type,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource) SetTarget(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource {
	s.Target = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource) SetType(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource {
	s.Type = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget struct {
	AppType  *int64  `json:"appType,omitempty" xml:"appType,omitempty"`
	AppUuid  *string `json:"appUuid,omitempty" xml:"appUuid,omitempty"`
	BizType  *string `json:"bizType,omitempty" xml:"bizType,omitempty"`
	FormCode *string `json:"formCode,omitempty" xml:"formCode,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) SetAppType(v int64) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget {
	s.AppType = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) SetAppUuid(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget {
	s.AppUuid = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) SetBizType(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget {
	s.BizType = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget) SetFormCode(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget {
	s.FormCode = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields struct {
	ComponentName *string                                                                                `json:"componentName,omitempty" xml:"componentName,omitempty"`
	RelateProps   *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps `json:"relateProps,omitempty" xml:"relateProps,omitempty" type:"Struct"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields) SetComponentName(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields {
	s.ComponentName = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields) SetRelateProps(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields {
	s.RelateProps = v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps struct {
	Align         *string                                                                                           `json:"align,omitempty" xml:"align,omitempty"`
	BizAlias      *string                                                                                           `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Choice        *int64                                                                                            `json:"choice,omitempty" xml:"choice,omitempty"`
	Content       *string                                                                                           `json:"content,omitempty" xml:"content,omitempty"`
	Disabled      *bool                                                                                             `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Duration      *bool                                                                                             `json:"duration,omitempty" xml:"duration,omitempty"`
	Format        *string                                                                                           `json:"format,omitempty" xml:"format,omitempty"`
	Formula       *string                                                                                           `json:"formula,omitempty" xml:"formula,omitempty"`
	FieldId       *string                                                                                           `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Invisible     *bool                                                                                             `json:"invisible,omitempty" xml:"invisible,omitempty"`
	Label         *string                                                                                           `json:"label,omitempty" xml:"label,omitempty"`
	Link          *string                                                                                           `json:"link,omitempty" xml:"link,omitempty"`
	NotUpper      *string                                                                                           `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Options       []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions   `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	PayEnable     *bool                                                                                             `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	Placeholder   *string                                                                                           `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	Required      *bool                                                                                             `json:"required,omitempty" xml:"required,omitempty"`
	StatField     []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	Unit          *string                                                                                           `json:"unit,omitempty" xml:"unit,omitempty"`
	VerticalPrint *bool                                                                                             `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetAlign(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Align = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetBizAlias(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.BizAlias = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetChoice(v int64) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Choice = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetContent(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Content = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetDisabled(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Disabled = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetDuration(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Duration = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetFormat(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Format = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetFormula(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Formula = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetInvisible(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Invisible = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetLink(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Link = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetNotUpper(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.NotUpper = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetOptions(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Options = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetPayEnable(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.PayEnable = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetPlaceholder(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Placeholder = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetRequired(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Required = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetStatField(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.StatField = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps) SetVerticalPrint(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps {
	s.VerticalPrint = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions) SetKey(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions {
	s.Key = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions) SetValue(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions {
	s.Value = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField) SetUpper(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField {
	s.Upper = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions) SetKey(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions {
	s.Key = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions) SetValue(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions {
	s.Value = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField) SetUpper(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField {
	s.Upper = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps struct {
	Align                  *string                                                                  `json:"align,omitempty" xml:"align,omitempty"`
	BizAlias               *string                                                                  `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Choice                 *int64                                                                   `json:"choice,omitempty" xml:"choice,omitempty"`
	Content                *string                                                                  `json:"content,omitempty" xml:"content,omitempty"`
	DataSource             *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource  `json:"dataSource,omitempty" xml:"dataSource,omitempty" type:"Struct"`
	Disabled               *bool                                                                    `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Duration               *bool                                                                    `json:"duration,omitempty" xml:"duration,omitempty"`
	Fields                 []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields    `json:"fields,omitempty" xml:"fields,omitempty" type:"Repeated"`
	Format                 *string                                                                  `json:"format,omitempty" xml:"format,omitempty"`
	Formula                *string                                                                  `json:"formula,omitempty" xml:"formula,omitempty"`
	FieldId                *string                                                                  `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Invisible              *bool                                                                    `json:"invisible,omitempty" xml:"invisible,omitempty"`
	Label                  *string                                                                  `json:"label,omitempty" xml:"label,omitempty"`
	LabelEditableFreeze    *bool                                                                    `json:"labelEditableFreeze,omitempty" xml:"labelEditableFreeze,omitempty"`
	Link                   *string                                                                  `json:"link,omitempty" xml:"link,omitempty"`
	NotPrint               *string                                                                  `json:"notPrint,omitempty" xml:"notPrint,omitempty"`
	NotUpper               *string                                                                  `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Options                []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions   `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	PayEnable              *bool                                                                    `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	Placeholder            *string                                                                  `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	Required               *bool                                                                    `json:"required,omitempty" xml:"required,omitempty"`
	RequiredEditableFreeze *bool                                                                    `json:"requiredEditableFreeze,omitempty" xml:"requiredEditableFreeze,omitempty"`
	StatField              []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	Unit                   *string                                                                  `json:"unit,omitempty" xml:"unit,omitempty"`
	VerticalPrint          *bool                                                                    `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetAlign(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Align = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetBizAlias(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.BizAlias = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetChoice(v int64) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Choice = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetContent(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Content = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetDataSource(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.DataSource = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetDisabled(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Disabled = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetDuration(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Duration = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetFields(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Fields = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetFormat(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Format = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetFormula(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Formula = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetInvisible(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Invisible = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetLabelEditableFreeze(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.LabelEditableFreeze = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetLink(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Link = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetNotPrint(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.NotPrint = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetNotUpper(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.NotUpper = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetOptions(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Options = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetPayEnable(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.PayEnable = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetPlaceholder(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Placeholder = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetRequired(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Required = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetRequiredEditableFreeze(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.RequiredEditableFreeze = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetStatField(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.StatField = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps) SetVerticalPrint(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps {
	s.VerticalPrint = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource struct {
	Target *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget `json:"target,omitempty" xml:"target,omitempty" type:"Struct"`
	Type   *string                                                                       `json:"type,omitempty" xml:"type,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource) SetTarget(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource {
	s.Target = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource) SetType(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource {
	s.Type = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget struct {
	AppType  *int64  `json:"appType,omitempty" xml:"appType,omitempty"`
	AppUuid  *string `json:"appUuid,omitempty" xml:"appUuid,omitempty"`
	BizType  *string `json:"bizType,omitempty" xml:"bizType,omitempty"`
	FormCode *string `json:"formCode,omitempty" xml:"formCode,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) SetAppType(v int64) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget {
	s.AppType = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) SetAppUuid(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget {
	s.AppUuid = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) SetBizType(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget {
	s.BizType = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget) SetFormCode(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget {
	s.FormCode = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields struct {
	ComponentName *string                                                                        `json:"componentName,omitempty" xml:"componentName,omitempty"`
	RelateProps   *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps `json:"relateProps,omitempty" xml:"relateProps,omitempty" type:"Struct"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields) SetComponentName(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields {
	s.ComponentName = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields) SetRelateProps(v *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields {
	s.RelateProps = v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps struct {
	Align         *string                                                                                   `json:"align,omitempty" xml:"align,omitempty"`
	BizAlias      *string                                                                                   `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Choice        *int64                                                                                    `json:"choice,omitempty" xml:"choice,omitempty"`
	Content       *string                                                                                   `json:"content,omitempty" xml:"content,omitempty"`
	Disabled      *bool                                                                                     `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Duration      *string                                                                                   `json:"duration,omitempty" xml:"duration,omitempty"`
	Format        *string                                                                                   `json:"format,omitempty" xml:"format,omitempty"`
	Formula       *string                                                                                   `json:"formula,omitempty" xml:"formula,omitempty"`
	FieldId       *string                                                                                   `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Invisible     *bool                                                                                     `json:"invisible,omitempty" xml:"invisible,omitempty"`
	Label         *string                                                                                   `json:"label,omitempty" xml:"label,omitempty"`
	Link          *string                                                                                   `json:"link,omitempty" xml:"link,omitempty"`
	NotUpper      *string                                                                                   `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Options       []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions   `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	PayEnable     *bool                                                                                     `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	Placeholder   *string                                                                                   `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	Required      *bool                                                                                     `json:"required,omitempty" xml:"required,omitempty"`
	StatField     []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	Unit          *string                                                                                   `json:"unit,omitempty" xml:"unit,omitempty"`
	VerticalPrint *bool                                                                                     `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetAlign(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Align = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetBizAlias(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.BizAlias = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetChoice(v int64) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Choice = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetContent(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Content = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetDisabled(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Disabled = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetDuration(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Duration = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetFormat(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Format = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetFormula(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Formula = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetInvisible(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Invisible = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetLink(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Link = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetNotUpper(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.NotUpper = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetOptions(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Options = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetPayEnable(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.PayEnable = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetPlaceholder(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Placeholder = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetRequired(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Required = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetStatField(v []*UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.StatField = v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps) SetVerticalPrint(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps {
	s.VerticalPrint = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions) SetKey(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions {
	s.Key = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions) SetValue(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions {
	s.Value = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField) SetUpper(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField {
	s.Upper = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions) SetKey(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions {
	s.Key = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions) SetValue(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions {
	s.Value = &v
	return s
}

type UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) SetFieldId(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField {
	s.FieldId = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) SetLabel(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField {
	s.Label = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) SetUnit(v string) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField {
	s.Unit = &v
	return s
}

func (s *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField) SetUpper(v bool) *UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField {
	s.Upper = &v
	return s
}

type UpdateRelationMetaFieldResponse struct {
	Headers map[string]*string                   `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *UpdateRelationMetaFieldResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s UpdateRelationMetaFieldResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateRelationMetaFieldResponse) GoString() string {
	return s.String()
}

func (s *UpdateRelationMetaFieldResponse) SetHeaders(v map[string]*string) *UpdateRelationMetaFieldResponse {
	s.Headers = v
	return s
}

func (s *UpdateRelationMetaFieldResponse) SetBody(v *UpdateRelationMetaFieldResponseBody) *UpdateRelationMetaFieldResponse {
	s.Body = v
	return s
}

type SendOfficialAccountOTOMessageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s SendOfficialAccountOTOMessageHeaders) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageHeaders) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageHeaders) SetCommonHeaders(v map[string]*string) *SendOfficialAccountOTOMessageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *SendOfficialAccountOTOMessageHeaders) SetXAcsDingtalkAccessToken(v string) *SendOfficialAccountOTOMessageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type SendOfficialAccountOTOMessageRequest struct {
	// 消息详情
	Detail *SendOfficialAccountOTOMessageRequestDetail `json:"detail,omitempty" xml:"detail,omitempty" type:"Struct"`
	// API调用标识，可选参数
	BizId              *string `json:"bizId,omitempty" xml:"bizId,omitempty"`
	DingTokenGrantType *int64  `json:"dingTokenGrantType,omitempty" xml:"dingTokenGrantType,omitempty"`
	DingIsvOrgId       *int64  `json:"dingIsvOrgId,omitempty" xml:"dingIsvOrgId,omitempty"`
	DingOrgId          *int64  `json:"dingOrgId,omitempty" xml:"dingOrgId,omitempty"`
	DingSuiteKey       *string `json:"dingSuiteKey,omitempty" xml:"dingSuiteKey,omitempty"`
	// 服务窗帐号ID
	AccountId *string `json:"accountId,omitempty" xml:"accountId,omitempty"`
}

func (s SendOfficialAccountOTOMessageRequest) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequest) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequest) SetDetail(v *SendOfficialAccountOTOMessageRequestDetail) *SendOfficialAccountOTOMessageRequest {
	s.Detail = v
	return s
}

func (s *SendOfficialAccountOTOMessageRequest) SetBizId(v string) *SendOfficialAccountOTOMessageRequest {
	s.BizId = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequest) SetDingTokenGrantType(v int64) *SendOfficialAccountOTOMessageRequest {
	s.DingTokenGrantType = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequest) SetDingIsvOrgId(v int64) *SendOfficialAccountOTOMessageRequest {
	s.DingIsvOrgId = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequest) SetDingOrgId(v int64) *SendOfficialAccountOTOMessageRequest {
	s.DingOrgId = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequest) SetDingSuiteKey(v string) *SendOfficialAccountOTOMessageRequest {
	s.DingSuiteKey = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequest) SetAccountId(v string) *SendOfficialAccountOTOMessageRequest {
	s.AccountId = &v
	return s
}

type SendOfficialAccountOTOMessageRequestDetail struct {
	// 消息类型
	MsgType *string `json:"msgType,omitempty" xml:"msgType,omitempty"`
	// 请求唯一 ID
	Uuid *string `json:"uuid,omitempty" xml:"uuid,omitempty"`
	// 消息接收人id
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
	// 消息接收人unionId
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
	// 消息体
	MessageBody *SendOfficialAccountOTOMessageRequestDetailMessageBody `json:"messageBody,omitempty" xml:"messageBody,omitempty" type:"Struct"`
}

func (s SendOfficialAccountOTOMessageRequestDetail) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetail) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetail) SetMsgType(v string) *SendOfficialAccountOTOMessageRequestDetail {
	s.MsgType = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetail) SetUuid(v string) *SendOfficialAccountOTOMessageRequestDetail {
	s.Uuid = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetail) SetUserId(v string) *SendOfficialAccountOTOMessageRequestDetail {
	s.UserId = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetail) SetUnionId(v string) *SendOfficialAccountOTOMessageRequestDetail {
	s.UnionId = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetail) SetMessageBody(v *SendOfficialAccountOTOMessageRequestDetailMessageBody) *SendOfficialAccountOTOMessageRequestDetail {
	s.MessageBody = v
	return s
}

type SendOfficialAccountOTOMessageRequestDetailMessageBody struct {
	// 文本消息体  对于文本类型消息时必填
	Text *SendOfficialAccountOTOMessageRequestDetailMessageBodyText `json:"text,omitempty" xml:"text,omitempty" type:"Struct"`
	// markdown消息，仅对消息类型为markdown时有效
	Markdown *SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown `json:"markdown,omitempty" xml:"markdown,omitempty" type:"Struct"`
	// 链接消息类型
	Link *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink `json:"link,omitempty" xml:"link,omitempty" type:"Struct"`
	// 卡片消息
	ActionCard *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard `json:"actionCard,omitempty" xml:"actionCard,omitempty" type:"Struct"`
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBody) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBody) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBody) SetText(v *SendOfficialAccountOTOMessageRequestDetailMessageBodyText) *SendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.Text = v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBody) SetMarkdown(v *SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) *SendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.Markdown = v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBody) SetLink(v *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) *SendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.Link = v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBody) SetActionCard(v *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) *SendOfficialAccountOTOMessageRequestDetailMessageBody {
	s.ActionCard = v
	return s
}

type SendOfficialAccountOTOMessageRequestDetailMessageBodyText struct {
	// 消息内容，建议500字符以内。
	Content *string `json:"content,omitempty" xml:"content,omitempty"`
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyText) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyText) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyText) SetContent(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyText {
	s.Content = &v
	return s
}

type SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown struct {
	// 首屏会话透出的展示内容。
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// markdown格式的消息，建议500字符以内。
	Text *string `json:"text,omitempty" xml:"text,omitempty"`
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) SetTitle(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown {
	s.Title = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown) SetText(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown {
	s.Text = &v
	return s
}

type SendOfficialAccountOTOMessageRequestDetailMessageBodyLink struct {
	// 图片地址
	PicUrl *string `json:"picUrl,omitempty" xml:"picUrl,omitempty"`
	// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
	MessageUrl *string `json:"messageUrl,omitempty" xml:"messageUrl,omitempty"`
	// 消息标题，建议100字符以内。
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// 消息描述，建议500字符以内。
	Text *string `json:"text,omitempty" xml:"text,omitempty"`
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetPicUrl(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.PicUrl = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetMessageUrl(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.MessageUrl = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetTitle(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.Title = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink) SetText(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyLink {
	s.Text = &v
	return s
}

type SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard struct {
	// 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
	ButtonOrientation *string `json:"buttonOrientation,omitempty" xml:"buttonOrientation,omitempty"`
	// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
	SingleUrl *string `json:"singleUrl,omitempty" xml:"singleUrl,omitempty"`
	// 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
	SingleTitle *string `json:"singleTitle,omitempty" xml:"singleTitle,omitempty"`
	// 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
	Markdown *string `json:"markdown,omitempty" xml:"markdown,omitempty"`
	// 透出到会话列表和通知的文案
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
	ButtonList []*SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList `json:"buttonList,omitempty" xml:"buttonList,omitempty" type:"Repeated"`
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetButtonOrientation(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.ButtonOrientation = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetSingleUrl(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.SingleUrl = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetSingleTitle(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.SingleTitle = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetMarkdown(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.Markdown = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetTitle(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.Title = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard) SetButtonList(v []*SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard {
	s.ButtonList = v
	return s
}

type SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList struct {
	// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// 使用独立跳转ActionCard样式时的跳转链接。
	ActionUrl *string `json:"actionUrl,omitempty" xml:"actionUrl,omitempty"`
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) SetTitle(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList {
	s.Title = &v
	return s
}

func (s *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList) SetActionUrl(v string) *SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList {
	s.ActionUrl = &v
	return s
}

type SendOfficialAccountOTOMessageResponseBody struct {
	// Id of the request
	RequestId *string `json:"requestId,omitempty" xml:"requestId,omitempty"`
	// 推送结果
	Result *SendOfficialAccountOTOMessageResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s SendOfficialAccountOTOMessageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageResponseBody) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageResponseBody) SetRequestId(v string) *SendOfficialAccountOTOMessageResponseBody {
	s.RequestId = &v
	return s
}

func (s *SendOfficialAccountOTOMessageResponseBody) SetResult(v *SendOfficialAccountOTOMessageResponseBodyResult) *SendOfficialAccountOTOMessageResponseBody {
	s.Result = v
	return s
}

type SendOfficialAccountOTOMessageResponseBodyResult struct {
	// 推送ID
	OpenPushId *string `json:"openPushId,omitempty" xml:"openPushId,omitempty"`
}

func (s SendOfficialAccountOTOMessageResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageResponseBodyResult) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageResponseBodyResult) SetOpenPushId(v string) *SendOfficialAccountOTOMessageResponseBodyResult {
	s.OpenPushId = &v
	return s
}

type SendOfficialAccountOTOMessageResponse struct {
	Headers map[string]*string                         `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *SendOfficialAccountOTOMessageResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s SendOfficialAccountOTOMessageResponse) String() string {
	return tea.Prettify(s)
}

func (s SendOfficialAccountOTOMessageResponse) GoString() string {
	return s.String()
}

func (s *SendOfficialAccountOTOMessageResponse) SetHeaders(v map[string]*string) *SendOfficialAccountOTOMessageResponse {
	s.Headers = v
	return s
}

func (s *SendOfficialAccountOTOMessageResponse) SetBody(v *SendOfficialAccountOTOMessageResponseBody) *SendOfficialAccountOTOMessageResponse {
	s.Body = v
	return s
}

type GetOfficialAccountOTOMessageResultHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetOfficialAccountOTOMessageResultHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountOTOMessageResultHeaders) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountOTOMessageResultHeaders) SetCommonHeaders(v map[string]*string) *GetOfficialAccountOTOMessageResultHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetOfficialAccountOTOMessageResultHeaders) SetXAcsDingtalkAccessToken(v string) *GetOfficialAccountOTOMessageResultHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetOfficialAccountOTOMessageResultRequest struct {
	// 推送ID
	OpenPushId *string `json:"openPushId,omitempty" xml:"openPushId,omitempty"`
	AccountId  *string `json:"accountId,omitempty" xml:"accountId,omitempty"`
}

func (s GetOfficialAccountOTOMessageResultRequest) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountOTOMessageResultRequest) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountOTOMessageResultRequest) SetOpenPushId(v string) *GetOfficialAccountOTOMessageResultRequest {
	s.OpenPushId = &v
	return s
}

func (s *GetOfficialAccountOTOMessageResultRequest) SetAccountId(v string) *GetOfficialAccountOTOMessageResultRequest {
	s.AccountId = &v
	return s
}

type GetOfficialAccountOTOMessageResultResponseBody struct {
	// Id of the request
	RequestId *string `json:"requestId,omitempty" xml:"requestId,omitempty"`
	// 查询结果
	Result *GetOfficialAccountOTOMessageResultResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
}

func (s GetOfficialAccountOTOMessageResultResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountOTOMessageResultResponseBody) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountOTOMessageResultResponseBody) SetRequestId(v string) *GetOfficialAccountOTOMessageResultResponseBody {
	s.RequestId = &v
	return s
}

func (s *GetOfficialAccountOTOMessageResultResponseBody) SetResult(v *GetOfficialAccountOTOMessageResultResponseBodyResult) *GetOfficialAccountOTOMessageResultResponseBody {
	s.Result = v
	return s
}

type GetOfficialAccountOTOMessageResultResponseBodyResult struct {
	// 执行状态： 0：未开始  1：处理中  2：处理完毕
	Status *int64 `json:"status,omitempty" xml:"status,omitempty"`
	// 已读消息的userid列表
	ReadUserIdList []*string `json:"readUserIdList,omitempty" xml:"readUserIdList,omitempty" type:"Repeated"`
}

func (s GetOfficialAccountOTOMessageResultResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountOTOMessageResultResponseBodyResult) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountOTOMessageResultResponseBodyResult) SetStatus(v int64) *GetOfficialAccountOTOMessageResultResponseBodyResult {
	s.Status = &v
	return s
}

func (s *GetOfficialAccountOTOMessageResultResponseBodyResult) SetReadUserIdList(v []*string) *GetOfficialAccountOTOMessageResultResponseBodyResult {
	s.ReadUserIdList = v
	return s
}

type GetOfficialAccountOTOMessageResultResponse struct {
	Headers map[string]*string                              `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *GetOfficialAccountOTOMessageResultResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s GetOfficialAccountOTOMessageResultResponse) String() string {
	return tea.Prettify(s)
}

func (s GetOfficialAccountOTOMessageResultResponse) GoString() string {
	return s.String()
}

func (s *GetOfficialAccountOTOMessageResultResponse) SetHeaders(v map[string]*string) *GetOfficialAccountOTOMessageResultResponse {
	s.Headers = v
	return s
}

func (s *GetOfficialAccountOTOMessageResultResponse) SetBody(v *GetOfficialAccountOTOMessageResultResponseBody) *GetOfficialAccountOTOMessageResultResponse {
	s.Body = v
	return s
}

type DescribeRelationMetaHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DescribeRelationMetaHeaders) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaHeaders) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaHeaders) SetCommonHeaders(v map[string]*string) *DescribeRelationMetaHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DescribeRelationMetaHeaders) SetXAcsDingtalkAccessToken(v string) *DescribeRelationMetaHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DescribeRelationMetaRequest struct {
	Tenant         *string   `json:"tenant,omitempty" xml:"tenant,omitempty"`
	OperatorUserId *string   `json:"operatorUserId,omitempty" xml:"operatorUserId,omitempty"`
	RelationTypes  []*string `json:"relationTypes,omitempty" xml:"relationTypes,omitempty" type:"Repeated"`
}

func (s DescribeRelationMetaRequest) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaRequest) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaRequest) SetTenant(v string) *DescribeRelationMetaRequest {
	s.Tenant = &v
	return s
}

func (s *DescribeRelationMetaRequest) SetOperatorUserId(v string) *DescribeRelationMetaRequest {
	s.OperatorUserId = &v
	return s
}

func (s *DescribeRelationMetaRequest) SetRelationTypes(v []*string) *DescribeRelationMetaRequest {
	s.RelationTypes = v
	return s
}

type DescribeRelationMetaResponseBody struct {
	RelationMetaDTOList []*DescribeRelationMetaResponseBodyRelationMetaDTOList `json:"relationMetaDTOList,omitempty" xml:"relationMetaDTOList,omitempty" type:"Repeated"`
}

func (s DescribeRelationMetaResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBody) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBody) SetRelationMetaDTOList(v []*DescribeRelationMetaResponseBodyRelationMetaDTOList) *DescribeRelationMetaResponseBody {
	s.RelationMetaDTOList = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOList struct {
	// 关系类型
	RelationType *string `json:"relationType,omitempty" xml:"relationType,omitempty"`
	// 模型结构名称
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// 模型结构描述
	Desc *string `json:"desc,omitempty" xml:"desc,omitempty"`
	// 模型结构字段集合
	Items []*DescribeRelationMetaResponseBodyRelationMetaDTOListItems `json:"items,omitempty" xml:"items,omitempty" type:"Repeated"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOList) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOList) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOList) SetRelationType(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOList {
	s.RelationType = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOList) SetName(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOList {
	s.Name = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOList) SetDesc(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOList {
	s.Desc = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOList) SetItems(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItems) *DescribeRelationMetaResponseBodyRelationMetaDTOList {
	s.Items = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItems struct {
	// 字段类型
	ComponentName *string `json:"componentName,omitempty" xml:"componentName,omitempty"`
	// 字段属性
	Props []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps `json:"props,omitempty" xml:"props,omitempty" type:"Repeated"`
	// 子字段列表
	Children []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren `json:"children,omitempty" xml:"children,omitempty" type:"Repeated"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItems) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItems) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItems) SetComponentName(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItems {
	s.ComponentName = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItems) SetProps(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) *DescribeRelationMetaResponseBodyRelationMetaDTOListItems {
	s.Props = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItems) SetChildren(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren) *DescribeRelationMetaResponseBodyRelationMetaDTOListItems {
	s.Children = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps struct {
	// 字段id
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	// 字段标题
	Label *string `json:"label,omitempty" xml:"label,omitempty"`
	// 字段标题是否可修改
	LabelEditableFreeze *bool `json:"labelEditableFreeze,omitempty" xml:"labelEditableFreeze,omitempty"`
	// 字段是否必填
	Required *bool `json:"required,omitempty" xml:"required,omitempty"`
	// 字段必填是否修改
	RequiredEditableFreeze *bool `json:"requiredEditableFreeze,omitempty" xml:"requiredEditableFreeze,omitempty"`
	// 是否参与打印
	NotPrint *string `json:"notPrint,omitempty" xml:"notPrint,omitempty"`
	// 说明文字内容
	Content *string `json:"content,omitempty" xml:"content,omitempty"`
	// 时间格式
	Format *string `json:"format,omitempty" xml:"format,omitempty"`
	// 选项内容列表
	Options []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	// 是否需要大写 默认是需要
	NotUpper *string `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	// 数字组件/日期区间组件单位属性
	Unit *string `json:"unit,omitempty" xml:"unit,omitempty"`
	// 界面空值提示占位符 前后端统一用placeholder
	Placeholder *string `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	// 字段别名
	BizAlias *string `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	// 是否自动计算时长
	Duration *bool `json:"duration,omitempty" xml:"duration,omitempty"`
	// 内部联系人choice
	Choice *int64 `json:"choice,omitempty" xml:"choice,omitempty"`
	// 是否可编辑
	Disabled *bool `json:"disabled,omitempty" xml:"disabled,omitempty"`
	// textnote的样式
	Align *string `json:"align,omitempty" xml:"align,omitempty"`
	// 关联表单的关联控件显示
	Fields []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields `json:"fields,omitempty" xml:"fields,omitempty" type:"Repeated"`
	// 关联表单的数据源配置
	DataSource *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource `json:"dataSource,omitempty" xml:"dataSource,omitempty" type:"Struct"`
	// 隐藏字段
	Invisible *bool `json:"invisible,omitempty" xml:"invisible,omitempty"`
	// 是否有支付属性
	PayEnable *bool `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	// 需要计算总和的明细组件
	StatField []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	// 说明文案的链接地址
	Link *string `json:"link,omitempty" xml:"link,omitempty"`
	// 明细打印排版方式
	VerticalPrint *bool `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
	// 公式
	Formula *string `json:"formula,omitempty" xml:"formula,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetLabelEditableFreeze(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.LabelEditableFreeze = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetRequired(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Required = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetRequiredEditableFreeze(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.RequiredEditableFreeze = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetNotPrint(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.NotPrint = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetContent(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Content = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetFormat(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Format = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetOptions(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Options = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetNotUpper(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.NotUpper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Unit = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetPlaceholder(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Placeholder = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetBizAlias(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.BizAlias = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetDuration(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Duration = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetChoice(v int64) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Choice = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetDisabled(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Disabled = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetAlign(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Align = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetFields(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Fields = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetDataSource(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.DataSource = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetInvisible(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Invisible = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetPayEnable(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.PayEnable = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetStatField(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.StatField = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetLink(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Link = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetVerticalPrint(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.VerticalPrint = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps) SetFormula(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps {
	s.Formula = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions struct {
	// 选项数据主键
	Key *string `json:"key,omitempty" xml:"key,omitempty"`
	// 选项显示内容
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions) SetKey(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions {
	s.Key = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions) SetValue(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions {
	s.Value = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields struct {
	// 字段类型
	ComponentName *string `json:"componentName,omitempty" xml:"componentName,omitempty"`
	// 字段属性
	RelateProps *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps `json:"relateProps,omitempty" xml:"relateProps,omitempty" type:"Struct"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields) SetComponentName(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields {
	s.ComponentName = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields) SetRelateProps(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields {
	s.RelateProps = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps struct {
	// 字段id
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	// 字段标题
	Label *string `json:"label,omitempty" xml:"label,omitempty"`
	// 字段是否必填
	Required *bool `json:"required,omitempty" xml:"required,omitempty"`
	// 说明文字内容
	Content *string `json:"content,omitempty" xml:"content,omitempty"`
	// 时间格式
	Format *string `json:"format,omitempty" xml:"format,omitempty"`
	// 选项内容列表
	Options []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	// 是否需要大写 默认是需要
	NotUpper *string `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	// 数字组件/日期区间组件单位属性
	Unit *string `json:"unit,omitempty" xml:"unit,omitempty"`
	// 界面空值提示占位符 前后端统一用placeholder
	Placeholder *string `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	// 字段别名
	BizAlias *string `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	// 是否自动计算时长
	Duration *string `json:"duration,omitempty" xml:"duration,omitempty"`
	// 内部联系人choice
	Choice *int64 `json:"choice,omitempty" xml:"choice,omitempty"`
	// 是否可编辑
	Disabled *bool `json:"disabled,omitempty" xml:"disabled,omitempty"`
	// textnote的样式
	Align *string `json:"align,omitempty" xml:"align,omitempty"`
	// 隐藏字段
	Invisible *bool `json:"invisible,omitempty" xml:"invisible,omitempty"`
	// 是否有支付属性
	PayEnable *bool `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	// 需要计算总和的明细组件
	StatField []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	// 说明文案的链接地址
	Link *string `json:"link,omitempty" xml:"link,omitempty"`
	// 明细打印排版方式
	VerticalPrint *bool `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
	// 公式
	Formula *string `json:"formula,omitempty" xml:"formula,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetRequired(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Required = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetContent(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Content = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetFormat(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Format = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetOptions(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Options = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetNotUpper(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.NotUpper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Unit = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetPlaceholder(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Placeholder = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetBizAlias(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.BizAlias = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetDuration(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Duration = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetChoice(v int64) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Choice = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetDisabled(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Disabled = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetAlign(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Align = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetInvisible(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Invisible = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetPayEnable(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.PayEnable = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetStatField(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.StatField = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetLink(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Link = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetVerticalPrint(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.VerticalPrint = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps) SetFormula(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps {
	s.Formula = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions struct {
	// 选项数据主键
	Key *string `json:"key,omitempty" xml:"key,omitempty"`
	// 选项显示内容
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions) SetKey(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions {
	s.Key = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions) SetValue(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions {
	s.Value = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) SetUpper(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField {
	s.Upper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField {
	s.Unit = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource struct {
	// 关联类型{ "form": 关联表单 }
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
	// 关联表单的业务标识
	Target *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget `json:"target,omitempty" xml:"target,omitempty" type:"Struct"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource) SetType(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource {
	s.Type = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource) SetTarget(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource {
	s.Target = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget struct {
	// 应用搭建id
	AppUuid *string `json:"appUuid,omitempty" xml:"appUuid,omitempty"`
	// 应用类型
	AppType *int64 `json:"appType,omitempty" xml:"appType,omitempty"`
	// 表单业务标识
	BizType *string `json:"bizType,omitempty" xml:"bizType,omitempty"`
	// 被关联表单的formCode
	FormCode *string `json:"formCode,omitempty" xml:"formCode,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) SetAppUuid(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget {
	s.AppUuid = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) SetAppType(v int64) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget {
	s.AppType = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) SetBizType(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget {
	s.BizType = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget) SetFormCode(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget {
	s.FormCode = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) SetUpper(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField {
	s.Upper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField {
	s.Unit = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren struct {
	ComponentName *string                                                                `json:"componentName,omitempty" xml:"componentName,omitempty"`
	Props         *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps `json:"props,omitempty" xml:"props,omitempty" type:"Struct"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren) SetComponentName(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren {
	s.ComponentName = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren) SetProps(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren {
	s.Props = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps struct {
	FieldId                *string                                                                           `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label                  *string                                                                           `json:"label,omitempty" xml:"label,omitempty"`
	LabelEditableFreeze    *bool                                                                             `json:"labelEditableFreeze,omitempty" xml:"labelEditableFreeze,omitempty"`
	Required               *bool                                                                             `json:"required,omitempty" xml:"required,omitempty"`
	RequiredEditableFreeze *bool                                                                             `json:"requiredEditableFreeze,omitempty" xml:"requiredEditableFreeze,omitempty"`
	NotPrint               *string                                                                           `json:"notPrint,omitempty" xml:"notPrint,omitempty"`
	Content                *string                                                                           `json:"content,omitempty" xml:"content,omitempty"`
	Format                 *string                                                                           `json:"format,omitempty" xml:"format,omitempty"`
	Options                []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions   `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	NotUpper               *string                                                                           `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Unit                   *string                                                                           `json:"unit,omitempty" xml:"unit,omitempty"`
	Placeholder            *string                                                                           `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	BizAlias               *string                                                                           `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Duration               *bool                                                                             `json:"duration,omitempty" xml:"duration,omitempty"`
	Choice                 *int64                                                                            `json:"choice,omitempty" xml:"choice,omitempty"`
	Disabled               *bool                                                                             `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Align                  *string                                                                           `json:"align,omitempty" xml:"align,omitempty"`
	Fields                 []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields    `json:"fields,omitempty" xml:"fields,omitempty" type:"Repeated"`
	DataSource             *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource  `json:"dataSource,omitempty" xml:"dataSource,omitempty" type:"Struct"`
	Invisible              *bool                                                                             `json:"invisible,omitempty" xml:"invisible,omitempty"`
	PayEnable              *bool                                                                             `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	StatField              []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	Link                   *string                                                                           `json:"link,omitempty" xml:"link,omitempty"`
	VerticalPrint          *bool                                                                             `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
	Formula                *string                                                                           `json:"formula,omitempty" xml:"formula,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetLabelEditableFreeze(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.LabelEditableFreeze = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetRequired(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Required = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetRequiredEditableFreeze(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.RequiredEditableFreeze = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetNotPrint(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.NotPrint = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetContent(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Content = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetFormat(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Format = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetOptions(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Options = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetNotUpper(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.NotUpper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Unit = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetPlaceholder(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Placeholder = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetBizAlias(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.BizAlias = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetDuration(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Duration = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetChoice(v int64) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Choice = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetDisabled(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Disabled = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetAlign(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Align = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetFields(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Fields = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetDataSource(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.DataSource = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetInvisible(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Invisible = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetPayEnable(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.PayEnable = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetStatField(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.StatField = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetLink(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Link = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetVerticalPrint(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.VerticalPrint = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps) SetFormula(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps {
	s.Formula = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions) SetKey(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions {
	s.Key = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions) SetValue(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions {
	s.Value = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields struct {
	ComponentName *string                                                                                 `json:"componentName,omitempty" xml:"componentName,omitempty"`
	RelateProps   *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps `json:"relateProps,omitempty" xml:"relateProps,omitempty" type:"Struct"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields) SetComponentName(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields {
	s.ComponentName = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields) SetRelateProps(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields {
	s.RelateProps = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps struct {
	FieldId       *string                                                                                            `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label         *string                                                                                            `json:"label,omitempty" xml:"label,omitempty"`
	Required      *bool                                                                                              `json:"required,omitempty" xml:"required,omitempty"`
	Content       *string                                                                                            `json:"content,omitempty" xml:"content,omitempty"`
	Format        *string                                                                                            `json:"format,omitempty" xml:"format,omitempty"`
	Options       []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions   `json:"options,omitempty" xml:"options,omitempty" type:"Repeated"`
	NotUpper      *string                                                                                            `json:"notUpper,omitempty" xml:"notUpper,omitempty"`
	Unit          *string                                                                                            `json:"unit,omitempty" xml:"unit,omitempty"`
	Placeholder   *string                                                                                            `json:"placeholder,omitempty" xml:"placeholder,omitempty"`
	BizAlias      *string                                                                                            `json:"bizAlias,omitempty" xml:"bizAlias,omitempty"`
	Duration      *bool                                                                                              `json:"duration,omitempty" xml:"duration,omitempty"`
	Choice        *int64                                                                                             `json:"choice,omitempty" xml:"choice,omitempty"`
	Disabled      *bool                                                                                              `json:"disabled,omitempty" xml:"disabled,omitempty"`
	Align         *string                                                                                            `json:"align,omitempty" xml:"align,omitempty"`
	Invisible     *bool                                                                                              `json:"invisible,omitempty" xml:"invisible,omitempty"`
	PayEnable     *bool                                                                                              `json:"payEnable,omitempty" xml:"payEnable,omitempty"`
	StatField     []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField `json:"statField,omitempty" xml:"statField,omitempty" type:"Repeated"`
	Link          *string                                                                                            `json:"link,omitempty" xml:"link,omitempty"`
	VerticalPrint *bool                                                                                              `json:"verticalPrint,omitempty" xml:"verticalPrint,omitempty"`
	Formula       *string                                                                                            `json:"formula,omitempty" xml:"formula,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetRequired(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Required = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetContent(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Content = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetFormat(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Format = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetOptions(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Options = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetNotUpper(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.NotUpper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Unit = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetPlaceholder(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Placeholder = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetBizAlias(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.BizAlias = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetDuration(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Duration = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetChoice(v int64) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Choice = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetDisabled(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Disabled = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetAlign(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Align = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetInvisible(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Invisible = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetPayEnable(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.PayEnable = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetStatField(v []*DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.StatField = v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetLink(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Link = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetVerticalPrint(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.VerticalPrint = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps) SetFormula(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps {
	s.Formula = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions) SetKey(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions {
	s.Key = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions) SetValue(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions {
	s.Value = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) SetUpper(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField {
	s.Upper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField {
	s.Unit = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource struct {
	Type   *string                                                                                `json:"type,omitempty" xml:"type,omitempty"`
	Target *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget `json:"target,omitempty" xml:"target,omitempty" type:"Struct"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource) SetType(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource {
	s.Type = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource) SetTarget(v *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource {
	s.Target = v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget struct {
	AppUuid  *string `json:"appUuid,omitempty" xml:"appUuid,omitempty"`
	AppType  *int64  `json:"appType,omitempty" xml:"appType,omitempty"`
	BizType  *string `json:"bizType,omitempty" xml:"bizType,omitempty"`
	FormCode *string `json:"formCode,omitempty" xml:"formCode,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) SetAppUuid(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget {
	s.AppUuid = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) SetAppType(v int64) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget {
	s.AppType = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) SetBizType(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget {
	s.BizType = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget) SetFormCode(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget {
	s.FormCode = &v
	return s
}

type DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField struct {
	FieldId *string `json:"fieldId,omitempty" xml:"fieldId,omitempty"`
	Label   *string `json:"label,omitempty" xml:"label,omitempty"`
	Upper   *bool   `json:"upper,omitempty" xml:"upper,omitempty"`
	Unit    *string `json:"unit,omitempty" xml:"unit,omitempty"`
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) SetFieldId(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField {
	s.FieldId = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) SetLabel(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField {
	s.Label = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) SetUpper(v bool) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField {
	s.Upper = &v
	return s
}

func (s *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField) SetUnit(v string) *DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField {
	s.Unit = &v
	return s
}

type DescribeRelationMetaResponse struct {
	Headers map[string]*string                `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *DescribeRelationMetaResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s DescribeRelationMetaResponse) String() string {
	return tea.Prettify(s)
}

func (s DescribeRelationMetaResponse) GoString() string {
	return s.String()
}

func (s *DescribeRelationMetaResponse) SetHeaders(v map[string]*string) *DescribeRelationMetaResponse {
	s.Headers = v
	return s
}

func (s *DescribeRelationMetaResponse) SetBody(v *DescribeRelationMetaResponseBody) *DescribeRelationMetaResponse {
	s.Body = v
	return s
}

type AddCrmPersonalCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s AddCrmPersonalCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s AddCrmPersonalCustomerHeaders) GoString() string {
	return s.String()
}

func (s *AddCrmPersonalCustomerHeaders) SetCommonHeaders(v map[string]*string) *AddCrmPersonalCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *AddCrmPersonalCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *AddCrmPersonalCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type AddCrmPersonalCustomerRequest struct {
	// 记录创建人的用户ID
	CreatorUserId *string `json:"creatorUserId,omitempty" xml:"creatorUserId,omitempty"`
	// 记录创建人的昵称
	CreatorNick *string `json:"creatorNick,omitempty" xml:"creatorNick,omitempty"`
	// 数据内容
	Data map[string]interface{} `json:"data,omitempty" xml:"data,omitempty"`
	// 扩展数据内容
	ExtendData map[string]interface{} `json:"extendData,omitempty" xml:"extendData,omitempty"`
	// 权限
	Permission *AddCrmPersonalCustomerRequestPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
	// 跳过uk查重
	SkipDuplicateCheck *bool `json:"skipDuplicateCheck,omitempty" xml:"skipDuplicateCheck,omitempty"`
	// 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
	Action *string `json:"action,omitempty" xml:"action,omitempty"`
}

func (s AddCrmPersonalCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s AddCrmPersonalCustomerRequest) GoString() string {
	return s.String()
}

func (s *AddCrmPersonalCustomerRequest) SetCreatorUserId(v string) *AddCrmPersonalCustomerRequest {
	s.CreatorUserId = &v
	return s
}

func (s *AddCrmPersonalCustomerRequest) SetCreatorNick(v string) *AddCrmPersonalCustomerRequest {
	s.CreatorNick = &v
	return s
}

func (s *AddCrmPersonalCustomerRequest) SetData(v map[string]interface{}) *AddCrmPersonalCustomerRequest {
	s.Data = v
	return s
}

func (s *AddCrmPersonalCustomerRequest) SetExtendData(v map[string]interface{}) *AddCrmPersonalCustomerRequest {
	s.ExtendData = v
	return s
}

func (s *AddCrmPersonalCustomerRequest) SetPermission(v *AddCrmPersonalCustomerRequestPermission) *AddCrmPersonalCustomerRequest {
	s.Permission = v
	return s
}

func (s *AddCrmPersonalCustomerRequest) SetSkipDuplicateCheck(v bool) *AddCrmPersonalCustomerRequest {
	s.SkipDuplicateCheck = &v
	return s
}

func (s *AddCrmPersonalCustomerRequest) SetAction(v string) *AddCrmPersonalCustomerRequest {
	s.Action = &v
	return s
}

type AddCrmPersonalCustomerRequestPermission struct {
	// 负责人的用户ID
	OwnerStaffIds []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
	// 协同人的用户ID
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
}

func (s AddCrmPersonalCustomerRequestPermission) String() string {
	return tea.Prettify(s)
}

func (s AddCrmPersonalCustomerRequestPermission) GoString() string {
	return s.String()
}

func (s *AddCrmPersonalCustomerRequestPermission) SetOwnerStaffIds(v []*string) *AddCrmPersonalCustomerRequestPermission {
	s.OwnerStaffIds = v
	return s
}

func (s *AddCrmPersonalCustomerRequestPermission) SetParticipantStaffIds(v []*string) *AddCrmPersonalCustomerRequestPermission {
	s.ParticipantStaffIds = v
	return s
}

type AddCrmPersonalCustomerResponseBody struct {
	// 客户数据id
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
}

func (s AddCrmPersonalCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s AddCrmPersonalCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *AddCrmPersonalCustomerResponseBody) SetInstanceId(v string) *AddCrmPersonalCustomerResponseBody {
	s.InstanceId = &v
	return s
}

type AddCrmPersonalCustomerResponse struct {
	Headers map[string]*string                  `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *AddCrmPersonalCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s AddCrmPersonalCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s AddCrmPersonalCustomerResponse) GoString() string {
	return s.String()
}

func (s *AddCrmPersonalCustomerResponse) SetHeaders(v map[string]*string) *AddCrmPersonalCustomerResponse {
	s.Headers = v
	return s
}

func (s *AddCrmPersonalCustomerResponse) SetBody(v *AddCrmPersonalCustomerResponseBody) *AddCrmPersonalCustomerResponse {
	s.Body = v
	return s
}

type RecallOfficialAccountOTOMessageHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s RecallOfficialAccountOTOMessageHeaders) String() string {
	return tea.Prettify(s)
}

func (s RecallOfficialAccountOTOMessageHeaders) GoString() string {
	return s.String()
}

func (s *RecallOfficialAccountOTOMessageHeaders) SetCommonHeaders(v map[string]*string) *RecallOfficialAccountOTOMessageHeaders {
	s.CommonHeaders = v
	return s
}

func (s *RecallOfficialAccountOTOMessageHeaders) SetXAcsDingtalkAccessToken(v string) *RecallOfficialAccountOTOMessageHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type RecallOfficialAccountOTOMessageRequest struct {
	DingSuiteKey       *string `json:"dingSuiteKey,omitempty" xml:"dingSuiteKey,omitempty"`
	DingOrgId          *int64  `json:"dingOrgId,omitempty" xml:"dingOrgId,omitempty"`
	DingIsvOrgId       *int64  `json:"dingIsvOrgId,omitempty" xml:"dingIsvOrgId,omitempty"`
	DingTokenGrantType *int64  `json:"dingTokenGrantType,omitempty" xml:"dingTokenGrantType,omitempty"`
	// 帐号ID 可空
	AccountId *string `json:"accountId,omitempty" xml:"accountId,omitempty"`
	// 消息推送时返回的ID
	OpenPushId *string `json:"openPushId,omitempty" xml:"openPushId,omitempty"`
}

func (s RecallOfficialAccountOTOMessageRequest) String() string {
	return tea.Prettify(s)
}

func (s RecallOfficialAccountOTOMessageRequest) GoString() string {
	return s.String()
}

func (s *RecallOfficialAccountOTOMessageRequest) SetDingSuiteKey(v string) *RecallOfficialAccountOTOMessageRequest {
	s.DingSuiteKey = &v
	return s
}

func (s *RecallOfficialAccountOTOMessageRequest) SetDingOrgId(v int64) *RecallOfficialAccountOTOMessageRequest {
	s.DingOrgId = &v
	return s
}

func (s *RecallOfficialAccountOTOMessageRequest) SetDingIsvOrgId(v int64) *RecallOfficialAccountOTOMessageRequest {
	s.DingIsvOrgId = &v
	return s
}

func (s *RecallOfficialAccountOTOMessageRequest) SetDingTokenGrantType(v int64) *RecallOfficialAccountOTOMessageRequest {
	s.DingTokenGrantType = &v
	return s
}

func (s *RecallOfficialAccountOTOMessageRequest) SetAccountId(v string) *RecallOfficialAccountOTOMessageRequest {
	s.AccountId = &v
	return s
}

func (s *RecallOfficialAccountOTOMessageRequest) SetOpenPushId(v string) *RecallOfficialAccountOTOMessageRequest {
	s.OpenPushId = &v
	return s
}

type RecallOfficialAccountOTOMessageResponseBody struct {
	// Id of the request
	RequestId *string `json:"requestId,omitempty" xml:"requestId,omitempty"`
}

func (s RecallOfficialAccountOTOMessageResponseBody) String() string {
	return tea.Prettify(s)
}

func (s RecallOfficialAccountOTOMessageResponseBody) GoString() string {
	return s.String()
}

func (s *RecallOfficialAccountOTOMessageResponseBody) SetRequestId(v string) *RecallOfficialAccountOTOMessageResponseBody {
	s.RequestId = &v
	return s
}

type RecallOfficialAccountOTOMessageResponse struct {
	Headers map[string]*string                           `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *RecallOfficialAccountOTOMessageResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s RecallOfficialAccountOTOMessageResponse) String() string {
	return tea.Prettify(s)
}

func (s RecallOfficialAccountOTOMessageResponse) GoString() string {
	return s.String()
}

func (s *RecallOfficialAccountOTOMessageResponse) SetHeaders(v map[string]*string) *RecallOfficialAccountOTOMessageResponse {
	s.Headers = v
	return s
}

func (s *RecallOfficialAccountOTOMessageResponse) SetBody(v *RecallOfficialAccountOTOMessageResponseBody) *RecallOfficialAccountOTOMessageResponse {
	s.Body = v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DescribeCrmPersonalCustomerObjectMetaHeaders) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaHeaders) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaHeaders) SetCommonHeaders(v map[string]*string) *DescribeCrmPersonalCustomerObjectMetaHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaHeaders) SetXAcsDingtalkAccessToken(v string) *DescribeCrmPersonalCustomerObjectMetaHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponseBody struct {
	// 对象名称
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// 是否自定义对象
	Customized *bool `json:"customized,omitempty" xml:"customized,omitempty"`
	// 字段列表
	Fields []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFields `json:"fields,omitempty" xml:"fields,omitempty" type:"Repeated"`
	// 表单状态
	Status *string `json:"status,omitempty" xml:"status,omitempty"`
	// 表单code
	Code *string `json:"code,omitempty" xml:"code,omitempty"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBody) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBody) SetName(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBody {
	s.Name = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBody) SetCustomized(v bool) *DescribeCrmPersonalCustomerObjectMetaResponseBody {
	s.Customized = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBody) SetFields(v []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) *DescribeCrmPersonalCustomerObjectMetaResponseBody {
	s.Fields = v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBody) SetStatus(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBody {
	s.Status = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBody) SetCode(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBody {
	s.Code = &v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponseBodyFields struct {
	Name                *string                                                                       `json:"name,omitempty" xml:"name,omitempty"`
	Customized          *bool                                                                         `json:"customized,omitempty" xml:"customized,omitempty"`
	Label               *string                                                                       `json:"label,omitempty" xml:"label,omitempty"`
	Type                *string                                                                       `json:"type,omitempty" xml:"type,omitempty"`
	Nillable            *bool                                                                         `json:"nillable,omitempty" xml:"nillable,omitempty"`
	Format              *string                                                                       `json:"format,omitempty" xml:"format,omitempty"`
	Unit                *string                                                                       `json:"unit,omitempty" xml:"unit,omitempty"`
	SelectOptions       []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions       `json:"selectOptions,omitempty" xml:"selectOptions,omitempty" type:"Repeated"`
	Quote               *bool                                                                         `json:"quote,omitempty" xml:"quote,omitempty"`
	ReferenceTo         *string                                                                       `json:"referenceTo,omitempty" xml:"referenceTo,omitempty"`
	ReferenceFields     []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields     `json:"referenceFields,omitempty" xml:"referenceFields,omitempty" type:"Repeated"`
	RollUpSummaryFields []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields `json:"rollUpSummaryFields,omitempty" xml:"rollUpSummaryFields,omitempty" type:"Repeated"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetName(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Name = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetCustomized(v bool) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Customized = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetLabel(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Label = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetType(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Type = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetNillable(v bool) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Nillable = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetFormat(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Format = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetUnit(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Unit = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetSelectOptions(v []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.SelectOptions = v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetQuote(v bool) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.Quote = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetReferenceTo(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.ReferenceTo = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetReferenceFields(v []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.ReferenceFields = v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields) SetRollUpSummaryFields(v []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFields {
	s.RollUpSummaryFields = v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions) SetKey(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions {
	s.Key = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions) SetValue(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions {
	s.Value = &v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields struct {
	Label         *string                                                                                `json:"label,omitempty" xml:"label,omitempty"`
	Type          *string                                                                                `json:"type,omitempty" xml:"type,omitempty"`
	Nillable      *bool                                                                                  `json:"nillable,omitempty" xml:"nillable,omitempty"`
	Unit          *string                                                                                `json:"unit,omitempty" xml:"unit,omitempty"`
	Format        *string                                                                                `json:"format,omitempty" xml:"format,omitempty"`
	SelectOptions []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions `json:"selectOptions,omitempty" xml:"selectOptions,omitempty" type:"Repeated"`
	Name          *string                                                                                `json:"name,omitempty" xml:"name,omitempty"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetLabel(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.Label = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetType(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.Type = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetNillable(v bool) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.Nillable = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetUnit(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.Unit = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetFormat(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.Format = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetSelectOptions(v []*DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.SelectOptions = v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields) SetName(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields {
	s.Name = &v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions struct {
	Key   *string `json:"key,omitempty" xml:"key,omitempty"`
	Value *string `json:"value,omitempty" xml:"value,omitempty"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions) SetKey(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions {
	s.Key = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions) SetValue(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions {
	s.Value = &v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields struct {
	Name       *string `json:"name,omitempty" xml:"name,omitempty"`
	Aggregator *string `json:"aggregator,omitempty" xml:"aggregator,omitempty"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields) SetName(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields {
	s.Name = &v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields) SetAggregator(v string) *DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields {
	s.Aggregator = &v
	return s
}

type DescribeCrmPersonalCustomerObjectMetaResponse struct {
	Headers map[string]*string                                 `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *DescribeCrmPersonalCustomerObjectMetaResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s DescribeCrmPersonalCustomerObjectMetaResponse) String() string {
	return tea.Prettify(s)
}

func (s DescribeCrmPersonalCustomerObjectMetaResponse) GoString() string {
	return s.String()
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponse) SetHeaders(v map[string]*string) *DescribeCrmPersonalCustomerObjectMetaResponse {
	s.Headers = v
	return s
}

func (s *DescribeCrmPersonalCustomerObjectMetaResponse) SetBody(v *DescribeCrmPersonalCustomerObjectMetaResponseBody) *DescribeCrmPersonalCustomerObjectMetaResponse {
	s.Body = v
	return s
}

type DeleteCrmPersonalCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DeleteCrmPersonalCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmPersonalCustomerHeaders) GoString() string {
	return s.String()
}

func (s *DeleteCrmPersonalCustomerHeaders) SetCommonHeaders(v map[string]*string) *DeleteCrmPersonalCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DeleteCrmPersonalCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *DeleteCrmPersonalCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DeleteCrmPersonalCustomerRequest struct {
	// 操作人用户ID
	CurrentOperatorUserId *string `json:"currentOperatorUserId,omitempty" xml:"currentOperatorUserId,omitempty"`
}

func (s DeleteCrmPersonalCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmPersonalCustomerRequest) GoString() string {
	return s.String()
}

func (s *DeleteCrmPersonalCustomerRequest) SetCurrentOperatorUserId(v string) *DeleteCrmPersonalCustomerRequest {
	s.CurrentOperatorUserId = &v
	return s
}

type DeleteCrmPersonalCustomerResponseBody struct {
	// 客户数据id
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
}

func (s DeleteCrmPersonalCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmPersonalCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *DeleteCrmPersonalCustomerResponseBody) SetInstanceId(v string) *DeleteCrmPersonalCustomerResponseBody {
	s.InstanceId = &v
	return s
}

type DeleteCrmPersonalCustomerResponse struct {
	Headers map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *DeleteCrmPersonalCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s DeleteCrmPersonalCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteCrmPersonalCustomerResponse) GoString() string {
	return s.String()
}

func (s *DeleteCrmPersonalCustomerResponse) SetHeaders(v map[string]*string) *DeleteCrmPersonalCustomerResponse {
	s.Headers = v
	return s
}

func (s *DeleteCrmPersonalCustomerResponse) SetBody(v *DeleteCrmPersonalCustomerResponseBody) *DeleteCrmPersonalCustomerResponse {
	s.Body = v
	return s
}

type AbandonCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s AbandonCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s AbandonCustomerHeaders) GoString() string {
	return s.String()
}

func (s *AbandonCustomerHeaders) SetCommonHeaders(v map[string]*string) *AbandonCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *AbandonCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *AbandonCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type AbandonCustomerRequest struct {
	// 操作人staffId，一般为企业员工
	OperatorUserId *string `json:"operatorUserId,omitempty" xml:"operatorUserId,omitempty"`
	// 客户实例 id 数组
	InstanceIdList []*string `json:"instanceIdList,omitempty" xml:"instanceIdList,omitempty" type:"Repeated"`
	// 自定义动态描述
	CustomTrackDesc *string `json:"customTrackDesc,omitempty" xml:"customTrackDesc,omitempty"`
	// 释放类型：returnPool-退回公海（默认），innerAbandon-仅清除负责人
	OptType *string `json:"optType,omitempty" xml:"optType,omitempty"`
}

func (s AbandonCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s AbandonCustomerRequest) GoString() string {
	return s.String()
}

func (s *AbandonCustomerRequest) SetOperatorUserId(v string) *AbandonCustomerRequest {
	s.OperatorUserId = &v
	return s
}

func (s *AbandonCustomerRequest) SetInstanceIdList(v []*string) *AbandonCustomerRequest {
	s.InstanceIdList = v
	return s
}

func (s *AbandonCustomerRequest) SetCustomTrackDesc(v string) *AbandonCustomerRequest {
	s.CustomTrackDesc = &v
	return s
}

func (s *AbandonCustomerRequest) SetOptType(v string) *AbandonCustomerRequest {
	s.OptType = &v
	return s
}

type AbandonCustomerResponseBody struct {
	// 成功退回公海的客户实例 id 数组
	InstanceIdList []*string `json:"instanceIdList,omitempty" xml:"instanceIdList,omitempty" type:"Repeated"`
}

func (s AbandonCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s AbandonCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *AbandonCustomerResponseBody) SetInstanceIdList(v []*string) *AbandonCustomerResponseBody {
	s.InstanceIdList = v
	return s
}

type AbandonCustomerResponse struct {
	Headers map[string]*string           `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *AbandonCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s AbandonCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s AbandonCustomerResponse) GoString() string {
	return s.String()
}

func (s *AbandonCustomerResponse) SetHeaders(v map[string]*string) *AbandonCustomerResponse {
	s.Headers = v
	return s
}

func (s *AbandonCustomerResponse) SetBody(v *AbandonCustomerResponseBody) *AbandonCustomerResponse {
	s.Body = v
	return s
}

type UpdateCrmPersonalCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateCrmPersonalCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateCrmPersonalCustomerHeaders) GoString() string {
	return s.String()
}

func (s *UpdateCrmPersonalCustomerHeaders) SetCommonHeaders(v map[string]*string) *UpdateCrmPersonalCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateCrmPersonalCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateCrmPersonalCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateCrmPersonalCustomerRequest struct {
	InstanceId     *string                                     `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	ModifierUserId *string                                     `json:"modifierUserId,omitempty" xml:"modifierUserId,omitempty"`
	ModifierNick   *string                                     `json:"modifierNick,omitempty" xml:"modifierNick,omitempty"`
	Data           map[string]interface{}                      `json:"data,omitempty" xml:"data,omitempty"`
	ExtendData     map[string]interface{}                      `json:"extendData,omitempty" xml:"extendData,omitempty"`
	Permission     *UpdateCrmPersonalCustomerRequestPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
	// 跳过uk查重
	SkipDuplicateCheck *bool `json:"skipDuplicateCheck,omitempty" xml:"skipDuplicateCheck,omitempty"`
	// 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
	Action *string `json:"action,omitempty" xml:"action,omitempty"`
}

func (s UpdateCrmPersonalCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateCrmPersonalCustomerRequest) GoString() string {
	return s.String()
}

func (s *UpdateCrmPersonalCustomerRequest) SetInstanceId(v string) *UpdateCrmPersonalCustomerRequest {
	s.InstanceId = &v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetModifierUserId(v string) *UpdateCrmPersonalCustomerRequest {
	s.ModifierUserId = &v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetModifierNick(v string) *UpdateCrmPersonalCustomerRequest {
	s.ModifierNick = &v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetData(v map[string]interface{}) *UpdateCrmPersonalCustomerRequest {
	s.Data = v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetExtendData(v map[string]interface{}) *UpdateCrmPersonalCustomerRequest {
	s.ExtendData = v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetPermission(v *UpdateCrmPersonalCustomerRequestPermission) *UpdateCrmPersonalCustomerRequest {
	s.Permission = v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetSkipDuplicateCheck(v bool) *UpdateCrmPersonalCustomerRequest {
	s.SkipDuplicateCheck = &v
	return s
}

func (s *UpdateCrmPersonalCustomerRequest) SetAction(v string) *UpdateCrmPersonalCustomerRequest {
	s.Action = &v
	return s
}

type UpdateCrmPersonalCustomerRequestPermission struct {
	OwnerStaffIds       []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
}

func (s UpdateCrmPersonalCustomerRequestPermission) String() string {
	return tea.Prettify(s)
}

func (s UpdateCrmPersonalCustomerRequestPermission) GoString() string {
	return s.String()
}

func (s *UpdateCrmPersonalCustomerRequestPermission) SetOwnerStaffIds(v []*string) *UpdateCrmPersonalCustomerRequestPermission {
	s.OwnerStaffIds = v
	return s
}

func (s *UpdateCrmPersonalCustomerRequestPermission) SetParticipantStaffIds(v []*string) *UpdateCrmPersonalCustomerRequestPermission {
	s.ParticipantStaffIds = v
	return s
}

type UpdateCrmPersonalCustomerResponseBody struct {
	// 客户数据id
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
}

func (s UpdateCrmPersonalCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateCrmPersonalCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateCrmPersonalCustomerResponseBody) SetInstanceId(v string) *UpdateCrmPersonalCustomerResponseBody {
	s.InstanceId = &v
	return s
}

type UpdateCrmPersonalCustomerResponse struct {
	Headers map[string]*string                     `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *UpdateCrmPersonalCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s UpdateCrmPersonalCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateCrmPersonalCustomerResponse) GoString() string {
	return s.String()
}

func (s *UpdateCrmPersonalCustomerResponse) SetHeaders(v map[string]*string) *UpdateCrmPersonalCustomerResponse {
	s.Headers = v
	return s
}

func (s *UpdateCrmPersonalCustomerResponse) SetBody(v *UpdateCrmPersonalCustomerResponseBody) *UpdateCrmPersonalCustomerResponse {
	s.Body = v
	return s
}

type QueryCrmPersonalCustomerHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryCrmPersonalCustomerHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryCrmPersonalCustomerHeaders) GoString() string {
	return s.String()
}

func (s *QueryCrmPersonalCustomerHeaders) SetCommonHeaders(v map[string]*string) *QueryCrmPersonalCustomerHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryCrmPersonalCustomerHeaders) SetXAcsDingtalkAccessToken(v string) *QueryCrmPersonalCustomerHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryCrmPersonalCustomerRequest struct {
	// 用户ID
	CurrentOperatorUserId *string `json:"currentOperatorUserId,omitempty" xml:"currentOperatorUserId,omitempty"`
	// 分页页码
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 分页条数
	MaxResults *int32 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	// 查询条件
	QueryDsl *string `json:"queryDsl,omitempty" xml:"queryDsl,omitempty"`
}

func (s QueryCrmPersonalCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryCrmPersonalCustomerRequest) GoString() string {
	return s.String()
}

func (s *QueryCrmPersonalCustomerRequest) SetCurrentOperatorUserId(v string) *QueryCrmPersonalCustomerRequest {
	s.CurrentOperatorUserId = &v
	return s
}

func (s *QueryCrmPersonalCustomerRequest) SetNextToken(v string) *QueryCrmPersonalCustomerRequest {
	s.NextToken = &v
	return s
}

func (s *QueryCrmPersonalCustomerRequest) SetMaxResults(v int32) *QueryCrmPersonalCustomerRequest {
	s.MaxResults = &v
	return s
}

func (s *QueryCrmPersonalCustomerRequest) SetQueryDsl(v string) *QueryCrmPersonalCustomerRequest {
	s.QueryDsl = &v
	return s
}

type QueryCrmPersonalCustomerResponseBody struct {
	Values     []*QueryCrmPersonalCustomerResponseBodyValues `json:"values,omitempty" xml:"values,omitempty" type:"Repeated"`
	HasMore    *bool                                         `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	NextToken  *string                                       `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	MaxResults *int32                                        `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
}

func (s QueryCrmPersonalCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryCrmPersonalCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *QueryCrmPersonalCustomerResponseBody) SetValues(v []*QueryCrmPersonalCustomerResponseBodyValues) *QueryCrmPersonalCustomerResponseBody {
	s.Values = v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBody) SetHasMore(v bool) *QueryCrmPersonalCustomerResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBody) SetNextToken(v string) *QueryCrmPersonalCustomerResponseBody {
	s.NextToken = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBody) SetMaxResults(v int32) *QueryCrmPersonalCustomerResponseBody {
	s.MaxResults = &v
	return s
}

type QueryCrmPersonalCustomerResponseBodyValues struct {
	// 数据ID
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	// 数据类型
	ObjectType *string `json:"objectType,omitempty" xml:"objectType,omitempty"`
	// 创建记录的用户ID
	CreatorUserId *string `json:"creatorUserId,omitempty" xml:"creatorUserId,omitempty"`
	// 创建记录的用户昵称
	CreatorNick *string `json:"creatorNick,omitempty" xml:"creatorNick,omitempty"`
	// 数据内容
	Data map[string]interface{} `json:"data,omitempty" xml:"data,omitempty"`
	// 扩展数据内容
	ExtendData map[string]interface{} `json:"extendData,omitempty" xml:"extendData,omitempty"`
	// 数据权限信息
	Permission *QueryCrmPersonalCustomerResponseBodyValuesPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
	// 审批结果
	ProcOutResult *string `json:"procOutResult,omitempty" xml:"procOutResult,omitempty"`
	// 审批状态
	ProcInstStatus *string `json:"procInstStatus,omitempty" xml:"procInstStatus,omitempty"`
	// 记录创建时间
	GmtCreate *string `json:"gmtCreate,omitempty" xml:"gmtCreate,omitempty"`
	// 记录修改时间
	GmtModified *string `json:"gmtModified,omitempty" xml:"gmtModified,omitempty"`
}

func (s QueryCrmPersonalCustomerResponseBodyValues) String() string {
	return tea.Prettify(s)
}

func (s QueryCrmPersonalCustomerResponseBodyValues) GoString() string {
	return s.String()
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetInstanceId(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.InstanceId = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetObjectType(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.ObjectType = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetCreatorUserId(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.CreatorUserId = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetCreatorNick(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.CreatorNick = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetData(v map[string]interface{}) *QueryCrmPersonalCustomerResponseBodyValues {
	s.Data = v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetExtendData(v map[string]interface{}) *QueryCrmPersonalCustomerResponseBodyValues {
	s.ExtendData = v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetPermission(v *QueryCrmPersonalCustomerResponseBodyValuesPermission) *QueryCrmPersonalCustomerResponseBodyValues {
	s.Permission = v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetProcOutResult(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.ProcOutResult = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetProcInstStatus(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.ProcInstStatus = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetGmtCreate(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.GmtCreate = &v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValues) SetGmtModified(v string) *QueryCrmPersonalCustomerResponseBodyValues {
	s.GmtModified = &v
	return s
}

type QueryCrmPersonalCustomerResponseBodyValuesPermission struct {
	// 负责人用户ID列表
	OwnerStaffIds []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
	// 协同人用户ID列表
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
}

func (s QueryCrmPersonalCustomerResponseBodyValuesPermission) String() string {
	return tea.Prettify(s)
}

func (s QueryCrmPersonalCustomerResponseBodyValuesPermission) GoString() string {
	return s.String()
}

func (s *QueryCrmPersonalCustomerResponseBodyValuesPermission) SetOwnerStaffIds(v []*string) *QueryCrmPersonalCustomerResponseBodyValuesPermission {
	s.OwnerStaffIds = v
	return s
}

func (s *QueryCrmPersonalCustomerResponseBodyValuesPermission) SetParticipantStaffIds(v []*string) *QueryCrmPersonalCustomerResponseBodyValuesPermission {
	s.ParticipantStaffIds = v
	return s
}

type QueryCrmPersonalCustomerResponse struct {
	Headers map[string]*string                    `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *QueryCrmPersonalCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s QueryCrmPersonalCustomerResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryCrmPersonalCustomerResponse) GoString() string {
	return s.String()
}

func (s *QueryCrmPersonalCustomerResponse) SetHeaders(v map[string]*string) *QueryCrmPersonalCustomerResponse {
	s.Headers = v
	return s
}

func (s *QueryCrmPersonalCustomerResponse) SetBody(v *QueryCrmPersonalCustomerResponseBody) *QueryCrmPersonalCustomerResponse {
	s.Body = v
	return s
}

type ListCrmPersonalCustomersHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s ListCrmPersonalCustomersHeaders) String() string {
	return tea.Prettify(s)
}

func (s ListCrmPersonalCustomersHeaders) GoString() string {
	return s.String()
}

func (s *ListCrmPersonalCustomersHeaders) SetCommonHeaders(v map[string]*string) *ListCrmPersonalCustomersHeaders {
	s.CommonHeaders = v
	return s
}

func (s *ListCrmPersonalCustomersHeaders) SetXAcsDingtalkAccessToken(v string) *ListCrmPersonalCustomersHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type ListCrmPersonalCustomersRequest struct {
	// 操作人用户ID
	CurrentOperatorUserId *string `json:"currentOperatorUserId,omitempty" xml:"currentOperatorUserId,omitempty"`
	// 数据客户列表
	Body []*string `json:"body,omitempty" xml:"body,omitempty" type:"Repeated"`
}

func (s ListCrmPersonalCustomersRequest) String() string {
	return tea.Prettify(s)
}

func (s ListCrmPersonalCustomersRequest) GoString() string {
	return s.String()
}

func (s *ListCrmPersonalCustomersRequest) SetCurrentOperatorUserId(v string) *ListCrmPersonalCustomersRequest {
	s.CurrentOperatorUserId = &v
	return s
}

func (s *ListCrmPersonalCustomersRequest) SetBody(v []*string) *ListCrmPersonalCustomersRequest {
	s.Body = v
	return s
}

type ListCrmPersonalCustomersResponseBody struct {
	Result []*ListCrmPersonalCustomersResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Repeated"`
}

func (s ListCrmPersonalCustomersResponseBody) String() string {
	return tea.Prettify(s)
}

func (s ListCrmPersonalCustomersResponseBody) GoString() string {
	return s.String()
}

func (s *ListCrmPersonalCustomersResponseBody) SetResult(v []*ListCrmPersonalCustomersResponseBodyResult) *ListCrmPersonalCustomersResponseBody {
	s.Result = v
	return s
}

type ListCrmPersonalCustomersResponseBodyResult struct {
	OrgId          *int64                                                `json:"orgId,omitempty" xml:"orgId,omitempty"`
	InstanceId     *string                                               `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	ObjectType     *string                                               `json:"objectType,omitempty" xml:"objectType,omitempty"`
	CreatorUserId  *string                                               `json:"creatorUserId,omitempty" xml:"creatorUserId,omitempty"`
	CreatorNick    *string                                               `json:"creatorNick,omitempty" xml:"creatorNick,omitempty"`
	Data           map[string]interface{}                                `json:"data,omitempty" xml:"data,omitempty"`
	ExtendData     map[string]interface{}                                `json:"extendData,omitempty" xml:"extendData,omitempty"`
	Permission     *ListCrmPersonalCustomersResponseBodyResultPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
	AppUuid        *string                                               `json:"appUuid,omitempty" xml:"appUuid,omitempty"`
	FormCode       *string                                               `json:"formCode,omitempty" xml:"formCode,omitempty"`
	ProcOutResult  *string                                               `json:"procOutResult,omitempty" xml:"procOutResult,omitempty"`
	ProcInstStatus *string                                               `json:"procInstStatus,omitempty" xml:"procInstStatus,omitempty"`
	GmtCreate      *string                                               `json:"gmtCreate,omitempty" xml:"gmtCreate,omitempty"`
	GmtModified    *string                                               `json:"gmtModified,omitempty" xml:"gmtModified,omitempty"`
}

func (s ListCrmPersonalCustomersResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s ListCrmPersonalCustomersResponseBodyResult) GoString() string {
	return s.String()
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetOrgId(v int64) *ListCrmPersonalCustomersResponseBodyResult {
	s.OrgId = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetInstanceId(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.InstanceId = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetObjectType(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.ObjectType = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetCreatorUserId(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.CreatorUserId = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetCreatorNick(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.CreatorNick = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetData(v map[string]interface{}) *ListCrmPersonalCustomersResponseBodyResult {
	s.Data = v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetExtendData(v map[string]interface{}) *ListCrmPersonalCustomersResponseBodyResult {
	s.ExtendData = v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetPermission(v *ListCrmPersonalCustomersResponseBodyResultPermission) *ListCrmPersonalCustomersResponseBodyResult {
	s.Permission = v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetAppUuid(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.AppUuid = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetFormCode(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.FormCode = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetProcOutResult(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.ProcOutResult = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetProcInstStatus(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.ProcInstStatus = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetGmtCreate(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.GmtCreate = &v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResult) SetGmtModified(v string) *ListCrmPersonalCustomersResponseBodyResult {
	s.GmtModified = &v
	return s
}

type ListCrmPersonalCustomersResponseBodyResultPermission struct {
	OwnerStaffIds       []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
}

func (s ListCrmPersonalCustomersResponseBodyResultPermission) String() string {
	return tea.Prettify(s)
}

func (s ListCrmPersonalCustomersResponseBodyResultPermission) GoString() string {
	return s.String()
}

func (s *ListCrmPersonalCustomersResponseBodyResultPermission) SetOwnerStaffIds(v []*string) *ListCrmPersonalCustomersResponseBodyResultPermission {
	s.OwnerStaffIds = v
	return s
}

func (s *ListCrmPersonalCustomersResponseBodyResultPermission) SetParticipantStaffIds(v []*string) *ListCrmPersonalCustomersResponseBodyResultPermission {
	s.ParticipantStaffIds = v
	return s
}

type ListCrmPersonalCustomersResponse struct {
	Headers map[string]*string                    `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *ListCrmPersonalCustomersResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s ListCrmPersonalCustomersResponse) String() string {
	return tea.Prettify(s)
}

func (s ListCrmPersonalCustomersResponse) GoString() string {
	return s.String()
}

func (s *ListCrmPersonalCustomersResponse) SetHeaders(v map[string]*string) *ListCrmPersonalCustomersResponse {
	s.Headers = v
	return s
}

func (s *ListCrmPersonalCustomersResponse) SetBody(v *ListCrmPersonalCustomersResponseBody) *ListCrmPersonalCustomersResponse {
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
	// 写入客户类型：个人客户crm_customer_personal; 企业客户crm_customer
	ObjectType *string `json:"objectType,omitempty" xml:"objectType,omitempty"`
	// 已存在客户时，添加联系人，可以传入客户的instanceId用作关联绑定
	InstanceId *string `json:"instanceId,omitempty" xml:"instanceId,omitempty"`
	// 创建人的userId
	CreatorUserId *string `json:"creatorUserId,omitempty" xml:"creatorUserId,omitempty"`
	// 客户实例数据（表单数据）
	Data map[string]interface{} `json:"data,omitempty" xml:"data,omitempty"`
	// 客户实例扩展数据
	ExtendData map[string]interface{} `json:"extendData,omitempty" xml:"extendData,omitempty"`
	// 关联联系人数据
	Contacts []*CreateCustomerRequestContacts `json:"contacts,omitempty" xml:"contacts,omitempty" type:"Repeated"`
	// 权限
	Permission *CreateCustomerRequestPermission `json:"permission,omitempty" xml:"permission,omitempty" type:"Struct"`
	// 保存配置项
	SaveOption *CreateCustomerRequestSaveOption `json:"saveOption,omitempty" xml:"saveOption,omitempty" type:"Struct"`
}

func (s CreateCustomerRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerRequest) GoString() string {
	return s.String()
}

func (s *CreateCustomerRequest) SetObjectType(v string) *CreateCustomerRequest {
	s.ObjectType = &v
	return s
}

func (s *CreateCustomerRequest) SetInstanceId(v string) *CreateCustomerRequest {
	s.InstanceId = &v
	return s
}

func (s *CreateCustomerRequest) SetCreatorUserId(v string) *CreateCustomerRequest {
	s.CreatorUserId = &v
	return s
}

func (s *CreateCustomerRequest) SetData(v map[string]interface{}) *CreateCustomerRequest {
	s.Data = v
	return s
}

func (s *CreateCustomerRequest) SetExtendData(v map[string]interface{}) *CreateCustomerRequest {
	s.ExtendData = v
	return s
}

func (s *CreateCustomerRequest) SetContacts(v []*CreateCustomerRequestContacts) *CreateCustomerRequest {
	s.Contacts = v
	return s
}

func (s *CreateCustomerRequest) SetPermission(v *CreateCustomerRequestPermission) *CreateCustomerRequest {
	s.Permission = v
	return s
}

func (s *CreateCustomerRequest) SetSaveOption(v *CreateCustomerRequestSaveOption) *CreateCustomerRequest {
	s.SaveOption = v
	return s
}

type CreateCustomerRequestContacts struct {
	// 联系人表单数据
	Data map[string]interface{} `json:"data,omitempty" xml:"data,omitempty"`
	// 联系人扩展数据
	ExtendData map[string]interface{} `json:"extendData,omitempty" xml:"extendData,omitempty"`
}

func (s CreateCustomerRequestContacts) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerRequestContacts) GoString() string {
	return s.String()
}

func (s *CreateCustomerRequestContacts) SetData(v map[string]interface{}) *CreateCustomerRequestContacts {
	s.Data = v
	return s
}

func (s *CreateCustomerRequestContacts) SetExtendData(v map[string]interface{}) *CreateCustomerRequestContacts {
	s.ExtendData = v
	return s
}

type CreateCustomerRequestPermission struct {
	// 负责人
	OwnerStaffIds []*string `json:"ownerStaffIds,omitempty" xml:"ownerStaffIds,omitempty" type:"Repeated"`
	// 协同人
	ParticipantStaffIds []*string `json:"participantStaffIds,omitempty" xml:"participantStaffIds,omitempty" type:"Repeated"`
}

func (s CreateCustomerRequestPermission) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerRequestPermission) GoString() string {
	return s.String()
}

func (s *CreateCustomerRequestPermission) SetOwnerStaffIds(v []*string) *CreateCustomerRequestPermission {
	s.OwnerStaffIds = v
	return s
}

func (s *CreateCustomerRequestPermission) SetParticipantStaffIds(v []*string) *CreateCustomerRequestPermission {
	s.ParticipantStaffIds = v
	return s
}

type CreateCustomerRequestSaveOption struct {
	// 关注配置：0 不处理， 1 自动关注（需要单独申请白名单）
	SubscribePolicy *int64 `json:"subscribePolicy,omitempty" xml:"subscribePolicy,omitempty"`
	// 保存联系人失败时是否阻断
	ThrowExceptionWhileSavingContactFailed *bool `json:"throwExceptionWhileSavingContactFailed,omitempty" xml:"throwExceptionWhileSavingContactFailed,omitempty"`
	// 客户已存在时的处理策略：APPEND_CONTACT_FORCE 直接追加联系人； REJECT 返回失败
	CustomerExistedPolicy *string `json:"customerExistedPolicy,omitempty" xml:"customerExistedPolicy,omitempty"`
	// 跳过uk查重
	SkipDuplicateCheck *bool `json:"skipDuplicateCheck,omitempty" xml:"skipDuplicateCheck,omitempty"`
}

func (s CreateCustomerRequestSaveOption) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerRequestSaveOption) GoString() string {
	return s.String()
}

func (s *CreateCustomerRequestSaveOption) SetSubscribePolicy(v int64) *CreateCustomerRequestSaveOption {
	s.SubscribePolicy = &v
	return s
}

func (s *CreateCustomerRequestSaveOption) SetThrowExceptionWhileSavingContactFailed(v bool) *CreateCustomerRequestSaveOption {
	s.ThrowExceptionWhileSavingContactFailed = &v
	return s
}

func (s *CreateCustomerRequestSaveOption) SetCustomerExistedPolicy(v string) *CreateCustomerRequestSaveOption {
	s.CustomerExistedPolicy = &v
	return s
}

func (s *CreateCustomerRequestSaveOption) SetSkipDuplicateCheck(v bool) *CreateCustomerRequestSaveOption {
	s.SkipDuplicateCheck = &v
	return s
}

type CreateCustomerResponseBody struct {
	// 客户实例id
	CustomerInstanceId *string `json:"customerInstanceId,omitempty" xml:"customerInstanceId,omitempty"`
	// 保存客户类型
	ObjectType *string `json:"objectType,omitempty" xml:"objectType,omitempty"`
	// 联系人保存结果
	Contacts []*CreateCustomerResponseBodyContacts `json:"contacts,omitempty" xml:"contacts,omitempty" type:"Repeated"`
}

func (s CreateCustomerResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerResponseBody) GoString() string {
	return s.String()
}

func (s *CreateCustomerResponseBody) SetCustomerInstanceId(v string) *CreateCustomerResponseBody {
	s.CustomerInstanceId = &v
	return s
}

func (s *CreateCustomerResponseBody) SetObjectType(v string) *CreateCustomerResponseBody {
	s.ObjectType = &v
	return s
}

func (s *CreateCustomerResponseBody) SetContacts(v []*CreateCustomerResponseBodyContacts) *CreateCustomerResponseBody {
	s.Contacts = v
	return s
}

type CreateCustomerResponseBodyContacts struct {
	// 联系人实例id
	ContactInstanceId *string `json:"contactInstanceId,omitempty" xml:"contactInstanceId,omitempty"`
}

func (s CreateCustomerResponseBodyContacts) String() string {
	return tea.Prettify(s)
}

func (s CreateCustomerResponseBodyContacts) GoString() string {
	return s.String()
}

func (s *CreateCustomerResponseBodyContacts) SetContactInstanceId(v string) *CreateCustomerResponseBodyContacts {
	s.ContactInstanceId = &v
	return s
}

type CreateCustomerResponse struct {
	Headers map[string]*string          `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *CreateCustomerResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
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

func (s *CreateCustomerResponse) SetBody(v *CreateCustomerResponseBody) *CreateCustomerResponse {
	s.Body = v
	return s
}

type QueryAllTracksHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s QueryAllTracksHeaders) String() string {
	return tea.Prettify(s)
}

func (s QueryAllTracksHeaders) GoString() string {
	return s.String()
}

func (s *QueryAllTracksHeaders) SetCommonHeaders(v map[string]*string) *QueryAllTracksHeaders {
	s.CommonHeaders = v
	return s
}

func (s *QueryAllTracksHeaders) SetXAcsDingtalkAccessToken(v string) *QueryAllTracksHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type QueryAllTracksRequest struct {
	// 分页游标
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 分页size
	MaxResults *int32 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	// 排序
	Order *string `json:"order,omitempty" xml:"order,omitempty"`
}

func (s QueryAllTracksRequest) String() string {
	return tea.Prettify(s)
}

func (s QueryAllTracksRequest) GoString() string {
	return s.String()
}

func (s *QueryAllTracksRequest) SetNextToken(v string) *QueryAllTracksRequest {
	s.NextToken = &v
	return s
}

func (s *QueryAllTracksRequest) SetMaxResults(v int32) *QueryAllTracksRequest {
	s.MaxResults = &v
	return s
}

func (s *QueryAllTracksRequest) SetOrder(v string) *QueryAllTracksRequest {
	s.Order = &v
	return s
}

type QueryAllTracksResponseBody struct {
	// 客户动态分页数据
	Values []*QueryAllTracksResponseBodyValues `json:"values,omitempty" xml:"values,omitempty" type:"Repeated"`
	// 是否还有数据
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// 下页翻页起始游标
	NextToken *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// 翻页size
	MaxResults *int32 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
}

func (s QueryAllTracksResponseBody) String() string {
	return tea.Prettify(s)
}

func (s QueryAllTracksResponseBody) GoString() string {
	return s.String()
}

func (s *QueryAllTracksResponseBody) SetValues(v []*QueryAllTracksResponseBodyValues) *QueryAllTracksResponseBody {
	s.Values = v
	return s
}

func (s *QueryAllTracksResponseBody) SetHasMore(v bool) *QueryAllTracksResponseBody {
	s.HasMore = &v
	return s
}

func (s *QueryAllTracksResponseBody) SetNextToken(v string) *QueryAllTracksResponseBody {
	s.NextToken = &v
	return s
}

func (s *QueryAllTracksResponseBody) SetMaxResults(v int32) *QueryAllTracksResponseBody {
	s.MaxResults = &v
	return s
}

type QueryAllTracksResponseBodyValues struct {
	// 企业id
	CorpId *string `json:"corpId,omitempty" xml:"corpId,omitempty"`
	// 客户id
	CustomerId *string `json:"customerId,omitempty" xml:"customerId,omitempty"`
	// 动态类型
	Type *int32 `json:"type,omitempty" xml:"type,omitempty"`
	// 动态子类型
	SubType *int32 `json:"subType,omitempty" xml:"subType,omitempty"`
	// 创建时间
	GmtCreate *int64 `json:"gmtCreate,omitempty" xml:"gmtCreate,omitempty"`
	// 创建人userId
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
	// 动态外键
	BizId *string `json:"bizId,omitempty" xml:"bizId,omitempty"`
	// 动态加密主键
	Id *string `json:"id,omitempty" xml:"id,omitempty"`
}

func (s QueryAllTracksResponseBodyValues) String() string {
	return tea.Prettify(s)
}

func (s QueryAllTracksResponseBodyValues) GoString() string {
	return s.String()
}

func (s *QueryAllTracksResponseBodyValues) SetCorpId(v string) *QueryAllTracksResponseBodyValues {
	s.CorpId = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetCustomerId(v string) *QueryAllTracksResponseBodyValues {
	s.CustomerId = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetType(v int32) *QueryAllTracksResponseBodyValues {
	s.Type = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetSubType(v int32) *QueryAllTracksResponseBodyValues {
	s.SubType = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetGmtCreate(v int64) *QueryAllTracksResponseBodyValues {
	s.GmtCreate = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetCreator(v string) *QueryAllTracksResponseBodyValues {
	s.Creator = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetBizId(v string) *QueryAllTracksResponseBodyValues {
	s.BizId = &v
	return s
}

func (s *QueryAllTracksResponseBodyValues) SetId(v string) *QueryAllTracksResponseBodyValues {
	s.Id = &v
	return s
}

type QueryAllTracksResponse struct {
	Headers map[string]*string          `json:"headers,omitempty" xml:"headers,omitempty" require:"true"`
	Body    *QueryAllTracksResponseBody `json:"body,omitempty" xml:"body,omitempty" require:"true"`
}

func (s QueryAllTracksResponse) String() string {
	return tea.Prettify(s)
}

func (s QueryAllTracksResponse) GoString() string {
	return s.String()
}

func (s *QueryAllTracksResponse) SetHeaders(v map[string]*string) *QueryAllTracksResponse {
	s.Headers = v
	return s
}

func (s *QueryAllTracksResponse) SetBody(v *QueryAllTracksResponseBody) *QueryAllTracksResponse {
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
	client.EndpointRule = tea.String("")
	if tea.BoolValue(util.Empty(client.Endpoint)) {
		client.Endpoint = tea.String("api.dingtalk.com")
	}

	return nil
}

func (client *Client) GetOfficialAccountContacts(request *GetOfficialAccountContactsRequest) (_result *GetOfficialAccountContactsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetOfficialAccountContactsHeaders{}
	_result = &GetOfficialAccountContactsResponse{}
	_body, _err := client.GetOfficialAccountContactsWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) GetOfficialAccountContactsWithOptions(request *GetOfficialAccountContactsRequest, headers *GetOfficialAccountContactsHeaders, runtime *util.RuntimeOptions) (_result *GetOfficialAccountContactsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		query["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		query["maxResults"] = request.MaxResults
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &GetOfficialAccountContactsResponse{}
	_body, _err := client.DoROARequest(tea.String("GetOfficialAccountContacts"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/officialAccounts/contacts"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) ServiceWindowMessageBatchPush(request *ServiceWindowMessageBatchPushRequest) (_result *ServiceWindowMessageBatchPushResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &ServiceWindowMessageBatchPushHeaders{}
	_result = &ServiceWindowMessageBatchPushResponse{}
	_body, _err := client.ServiceWindowMessageBatchPushWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) ServiceWindowMessageBatchPushWithOptions(request *ServiceWindowMessageBatchPushRequest, headers *ServiceWindowMessageBatchPushHeaders, runtime *util.RuntimeOptions) (_result *ServiceWindowMessageBatchPushResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Detail))) {
		body["detail"] = request.Detail
	}

	if !tea.BoolValue(util.IsUnset(request.BizId)) {
		body["bizId"] = request.BizId
	}

	if !tea.BoolValue(util.IsUnset(request.DingIsvOrgId)) {
		body["dingIsvOrgId"] = request.DingIsvOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingOrgId)) {
		body["dingOrgId"] = request.DingOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingTokenGrantType)) {
		body["dingTokenGrantType"] = request.DingTokenGrantType
	}

	if !tea.BoolValue(util.IsUnset(request.DingSuiteKey)) {
		body["dingSuiteKey"] = request.DingSuiteKey
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &ServiceWindowMessageBatchPushResponse{}
	_body, _err := client.DoROARequest(tea.String("ServiceWindowMessageBatchPush"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/messages/batchSend"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) DeleteCrmFormInstance(instanceId *string, request *DeleteCrmFormInstanceRequest) (_result *DeleteCrmFormInstanceResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DeleteCrmFormInstanceHeaders{}
	_result = &DeleteCrmFormInstanceResponse{}
	_body, _err := client.DeleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) DeleteCrmFormInstanceWithOptions(instanceId *string, request *DeleteCrmFormInstanceRequest, headers *DeleteCrmFormInstanceHeaders, runtime *util.RuntimeOptions) (_result *DeleteCrmFormInstanceResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CurrentOperatorUserId)) {
		query["currentOperatorUserId"] = request.CurrentOperatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.Name)) {
		query["name"] = request.Name
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &DeleteCrmFormInstanceResponse{}
	_body, _err := client.DoROARequest(tea.String("DeleteCrmFormInstance"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("DELETE"), tea.String("AK"), tea.String("/v1.0/crm/formInstances/"+tea.StringValue(instanceId)), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) GetCrmRolePermission(request *GetCrmRolePermissionRequest) (_result *GetCrmRolePermissionResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetCrmRolePermissionHeaders{}
	_result = &GetCrmRolePermissionResponse{}
	_body, _err := client.GetCrmRolePermissionWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) GetCrmRolePermissionWithOptions(request *GetCrmRolePermissionRequest, headers *GetCrmRolePermissionHeaders, runtime *util.RuntimeOptions) (_result *GetCrmRolePermissionResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.FormCode)) {
		query["formCode"] = request.FormCode
	}

	if !tea.BoolValue(util.IsUnset(request.BizType)) {
		query["bizType"] = request.BizType
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &GetCrmRolePermissionResponse{}
	_body, _err := client.DoROARequest(tea.String("GetCrmRolePermission"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/permissions"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) BatchSendOfficialAccountOTOMessage(request *BatchSendOfficialAccountOTOMessageRequest) (_result *BatchSendOfficialAccountOTOMessageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &BatchSendOfficialAccountOTOMessageHeaders{}
	_result = &BatchSendOfficialAccountOTOMessageResponse{}
	_body, _err := client.BatchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) BatchSendOfficialAccountOTOMessageWithOptions(request *BatchSendOfficialAccountOTOMessageRequest, headers *BatchSendOfficialAccountOTOMessageHeaders, runtime *util.RuntimeOptions) (_result *BatchSendOfficialAccountOTOMessageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Detail))) {
		body["detail"] = request.Detail
	}

	if !tea.BoolValue(util.IsUnset(request.BizId)) {
		body["bizId"] = request.BizId
	}

	if !tea.BoolValue(util.IsUnset(request.AccountId)) {
		body["accountId"] = request.AccountId
	}

	if !tea.BoolValue(util.IsUnset(request.DingIsvOrgId)) {
		body["dingIsvOrgId"] = request.DingIsvOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingOrgId)) {
		body["dingOrgId"] = request.DingOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingTokenGrantType)) {
		body["dingTokenGrantType"] = request.DingTokenGrantType
	}

	if !tea.BoolValue(util.IsUnset(request.DingSuiteKey)) {
		body["dingSuiteKey"] = request.DingSuiteKey
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &BatchSendOfficialAccountOTOMessageResponse{}
	_body, _err := client.DoROARequest(tea.String("BatchSendOfficialAccountOTOMessage"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/officialAccounts/oToMessages/batchSend"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) GetOfficialAccountContactInfo(userId *string) (_result *GetOfficialAccountContactInfoResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetOfficialAccountContactInfoHeaders{}
	_result = &GetOfficialAccountContactInfoResponse{}
	_body, _err := client.GetOfficialAccountContactInfoWithOptions(userId, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) GetOfficialAccountContactInfoWithOptions(userId *string, headers *GetOfficialAccountContactInfoHeaders, runtime *util.RuntimeOptions) (_result *GetOfficialAccountContactInfoResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	_result = &GetOfficialAccountContactInfoResponse{}
	_body, _err := client.DoROARequest(tea.String("GetOfficialAccountContactInfo"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/officialAccounts/contacts/"+tea.StringValue(userId)), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) QueryAllCustomer(request *QueryAllCustomerRequest) (_result *QueryAllCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryAllCustomerHeaders{}
	_result = &QueryAllCustomerResponse{}
	_body, _err := client.QueryAllCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) QueryAllCustomerWithOptions(request *QueryAllCustomerRequest, headers *QueryAllCustomerHeaders, runtime *util.RuntimeOptions) (_result *QueryAllCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.DingIsvOrgId)) {
		body["dingIsvOrgId"] = request.DingIsvOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingOrgId)) {
		body["dingOrgId"] = request.DingOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingTokenGrantType)) {
		body["dingTokenGrantType"] = request.DingTokenGrantType
	}

	if !tea.BoolValue(util.IsUnset(request.DingCorpId)) {
		body["dingCorpId"] = request.DingCorpId
	}

	if !tea.BoolValue(util.IsUnset(request.DingSuiteKey)) {
		body["dingSuiteKey"] = request.DingSuiteKey
	}

	if !tea.BoolValue(util.IsUnset(request.OperatorUserId)) {
		body["operatorUserId"] = request.OperatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		body["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		body["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.ObjectType)) {
		body["objectType"] = request.ObjectType
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &QueryAllCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("QueryAllCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/customerInstances"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) UpdateRelationMetaField(request *UpdateRelationMetaFieldRequest) (_result *UpdateRelationMetaFieldResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateRelationMetaFieldHeaders{}
	_result = &UpdateRelationMetaFieldResponse{}
	_body, _err := client.UpdateRelationMetaFieldWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) UpdateRelationMetaFieldWithOptions(request *UpdateRelationMetaFieldRequest, headers *UpdateRelationMetaFieldHeaders, runtime *util.RuntimeOptions) (_result *UpdateRelationMetaFieldResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Tenant)) {
		body["tenant"] = request.Tenant
	}

	if !tea.BoolValue(util.IsUnset(request.OperatorUserId)) {
		body["operatorUserId"] = request.OperatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.RelationType)) {
		body["relationType"] = request.RelationType
	}

	if !tea.BoolValue(util.IsUnset(request.FieldDTOList)) {
		body["fieldDTOList"] = request.FieldDTOList
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &UpdateRelationMetaFieldResponse{}
	_body, _err := client.DoROARequest(tea.String("UpdateRelationMetaField"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("PUT"), tea.String("AK"), tea.String("/v1.0/crm/relations/metas/fields"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) SendOfficialAccountOTOMessage(request *SendOfficialAccountOTOMessageRequest) (_result *SendOfficialAccountOTOMessageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &SendOfficialAccountOTOMessageHeaders{}
	_result = &SendOfficialAccountOTOMessageResponse{}
	_body, _err := client.SendOfficialAccountOTOMessageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) SendOfficialAccountOTOMessageWithOptions(request *SendOfficialAccountOTOMessageRequest, headers *SendOfficialAccountOTOMessageHeaders, runtime *util.RuntimeOptions) (_result *SendOfficialAccountOTOMessageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Detail))) {
		body["detail"] = request.Detail
	}

	if !tea.BoolValue(util.IsUnset(request.BizId)) {
		body["bizId"] = request.BizId
	}

	if !tea.BoolValue(util.IsUnset(request.DingTokenGrantType)) {
		body["dingTokenGrantType"] = request.DingTokenGrantType
	}

	if !tea.BoolValue(util.IsUnset(request.DingIsvOrgId)) {
		body["dingIsvOrgId"] = request.DingIsvOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingOrgId)) {
		body["dingOrgId"] = request.DingOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingSuiteKey)) {
		body["dingSuiteKey"] = request.DingSuiteKey
	}

	if !tea.BoolValue(util.IsUnset(request.AccountId)) {
		body["accountId"] = request.AccountId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &SendOfficialAccountOTOMessageResponse{}
	_body, _err := client.DoROARequest(tea.String("SendOfficialAccountOTOMessage"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/officialAccounts/oToMessages/send"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) GetOfficialAccountOTOMessageResult(request *GetOfficialAccountOTOMessageResultRequest) (_result *GetOfficialAccountOTOMessageResultResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetOfficialAccountOTOMessageResultHeaders{}
	_result = &GetOfficialAccountOTOMessageResultResponse{}
	_body, _err := client.GetOfficialAccountOTOMessageResultWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) GetOfficialAccountOTOMessageResultWithOptions(request *GetOfficialAccountOTOMessageResultRequest, headers *GetOfficialAccountOTOMessageResultHeaders, runtime *util.RuntimeOptions) (_result *GetOfficialAccountOTOMessageResultResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OpenPushId)) {
		query["openPushId"] = request.OpenPushId
	}

	if !tea.BoolValue(util.IsUnset(request.AccountId)) {
		query["accountId"] = request.AccountId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &GetOfficialAccountOTOMessageResultResponse{}
	_body, _err := client.DoROARequest(tea.String("GetOfficialAccountOTOMessageResult"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/officialAccounts/oToMessages/sendResults"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) DescribeRelationMeta(request *DescribeRelationMetaRequest) (_result *DescribeRelationMetaResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DescribeRelationMetaHeaders{}
	_result = &DescribeRelationMetaResponse{}
	_body, _err := client.DescribeRelationMetaWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) DescribeRelationMetaWithOptions(request *DescribeRelationMetaRequest, headers *DescribeRelationMetaHeaders, runtime *util.RuntimeOptions) (_result *DescribeRelationMetaResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Tenant)) {
		body["tenant"] = request.Tenant
	}

	if !tea.BoolValue(util.IsUnset(request.OperatorUserId)) {
		body["operatorUserId"] = request.OperatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.RelationTypes)) {
		body["relationTypes"] = request.RelationTypes
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &DescribeRelationMetaResponse{}
	_body, _err := client.DoROARequest(tea.String("DescribeRelationMeta"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/relations/metas/query"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) AddCrmPersonalCustomer(request *AddCrmPersonalCustomerRequest) (_result *AddCrmPersonalCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &AddCrmPersonalCustomerHeaders{}
	_result = &AddCrmPersonalCustomerResponse{}
	_body, _err := client.AddCrmPersonalCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) AddCrmPersonalCustomerWithOptions(request *AddCrmPersonalCustomerRequest, headers *AddCrmPersonalCustomerHeaders, runtime *util.RuntimeOptions) (_result *AddCrmPersonalCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CreatorUserId)) {
		body["creatorUserId"] = request.CreatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.CreatorNick)) {
		body["creatorNick"] = request.CreatorNick
	}

	if !tea.BoolValue(util.IsUnset(request.Data)) {
		body["data"] = request.Data
	}

	if !tea.BoolValue(util.IsUnset(request.ExtendData)) {
		body["extendData"] = request.ExtendData
	}

	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Permission))) {
		body["permission"] = request.Permission
	}

	if !tea.BoolValue(util.IsUnset(request.SkipDuplicateCheck)) {
		body["skipDuplicateCheck"] = request.SkipDuplicateCheck
	}

	if !tea.BoolValue(util.IsUnset(request.Action)) {
		body["action"] = request.Action
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &AddCrmPersonalCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("AddCrmPersonalCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/personalCustomers"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) RecallOfficialAccountOTOMessage(request *RecallOfficialAccountOTOMessageRequest) (_result *RecallOfficialAccountOTOMessageResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &RecallOfficialAccountOTOMessageHeaders{}
	_result = &RecallOfficialAccountOTOMessageResponse{}
	_body, _err := client.RecallOfficialAccountOTOMessageWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) RecallOfficialAccountOTOMessageWithOptions(request *RecallOfficialAccountOTOMessageRequest, headers *RecallOfficialAccountOTOMessageHeaders, runtime *util.RuntimeOptions) (_result *RecallOfficialAccountOTOMessageResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.DingSuiteKey)) {
		body["dingSuiteKey"] = request.DingSuiteKey
	}

	if !tea.BoolValue(util.IsUnset(request.DingOrgId)) {
		body["dingOrgId"] = request.DingOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingIsvOrgId)) {
		body["dingIsvOrgId"] = request.DingIsvOrgId
	}

	if !tea.BoolValue(util.IsUnset(request.DingTokenGrantType)) {
		body["dingTokenGrantType"] = request.DingTokenGrantType
	}

	if !tea.BoolValue(util.IsUnset(request.AccountId)) {
		body["accountId"] = request.AccountId
	}

	if !tea.BoolValue(util.IsUnset(request.OpenPushId)) {
		body["openPushId"] = request.OpenPushId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &RecallOfficialAccountOTOMessageResponse{}
	_body, _err := client.DoROARequest(tea.String("RecallOfficialAccountOTOMessage"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/officialAccounts/oToMessages/recall"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) DescribeCrmPersonalCustomerObjectMeta() (_result *DescribeCrmPersonalCustomerObjectMetaResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DescribeCrmPersonalCustomerObjectMetaHeaders{}
	_result = &DescribeCrmPersonalCustomerObjectMetaResponse{}
	_body, _err := client.DescribeCrmPersonalCustomerObjectMetaWithOptions(headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) DescribeCrmPersonalCustomerObjectMetaWithOptions(headers *DescribeCrmPersonalCustomerObjectMetaHeaders, runtime *util.RuntimeOptions) (_result *DescribeCrmPersonalCustomerObjectMetaResponse, _err error) {
	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
	}
	_result = &DescribeCrmPersonalCustomerObjectMetaResponse{}
	_body, _err := client.DoROARequest(tea.String("DescribeCrmPersonalCustomerObjectMeta"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/personalCustomers/objectMeta"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) DeleteCrmPersonalCustomer(dataId *string, request *DeleteCrmPersonalCustomerRequest) (_result *DeleteCrmPersonalCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DeleteCrmPersonalCustomerHeaders{}
	_result = &DeleteCrmPersonalCustomerResponse{}
	_body, _err := client.DeleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) DeleteCrmPersonalCustomerWithOptions(dataId *string, request *DeleteCrmPersonalCustomerRequest, headers *DeleteCrmPersonalCustomerHeaders, runtime *util.RuntimeOptions) (_result *DeleteCrmPersonalCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CurrentOperatorUserId)) {
		query["currentOperatorUserId"] = request.CurrentOperatorUserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &DeleteCrmPersonalCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("DeleteCrmPersonalCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("DELETE"), tea.String("AK"), tea.String("/v1.0/crm/personalCustomers/"+tea.StringValue(dataId)), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) AbandonCustomer(request *AbandonCustomerRequest) (_result *AbandonCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &AbandonCustomerHeaders{}
	_result = &AbandonCustomerResponse{}
	_body, _err := client.AbandonCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) AbandonCustomerWithOptions(request *AbandonCustomerRequest, headers *AbandonCustomerHeaders, runtime *util.RuntimeOptions) (_result *AbandonCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorUserId)) {
		body["operatorUserId"] = request.OperatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.InstanceIdList)) {
		body["instanceIdList"] = request.InstanceIdList
	}

	if !tea.BoolValue(util.IsUnset(request.CustomTrackDesc)) {
		body["customTrackDesc"] = request.CustomTrackDesc
	}

	if !tea.BoolValue(util.IsUnset(request.OptType)) {
		body["optType"] = request.OptType
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &AbandonCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("AbandonCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/customers/abandon"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) UpdateCrmPersonalCustomer(request *UpdateCrmPersonalCustomerRequest) (_result *UpdateCrmPersonalCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateCrmPersonalCustomerHeaders{}
	_result = &UpdateCrmPersonalCustomerResponse{}
	_body, _err := client.UpdateCrmPersonalCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) UpdateCrmPersonalCustomerWithOptions(request *UpdateCrmPersonalCustomerRequest, headers *UpdateCrmPersonalCustomerHeaders, runtime *util.RuntimeOptions) (_result *UpdateCrmPersonalCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.InstanceId)) {
		body["instanceId"] = request.InstanceId
	}

	if !tea.BoolValue(util.IsUnset(request.ModifierUserId)) {
		body["modifierUserId"] = request.ModifierUserId
	}

	if !tea.BoolValue(util.IsUnset(request.ModifierNick)) {
		body["modifierNick"] = request.ModifierNick
	}

	if !tea.BoolValue(util.IsUnset(request.Data)) {
		body["data"] = request.Data
	}

	if !tea.BoolValue(util.IsUnset(request.ExtendData)) {
		body["extendData"] = request.ExtendData
	}

	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Permission))) {
		body["permission"] = request.Permission
	}

	if !tea.BoolValue(util.IsUnset(request.SkipDuplicateCheck)) {
		body["skipDuplicateCheck"] = request.SkipDuplicateCheck
	}

	if !tea.BoolValue(util.IsUnset(request.Action)) {
		body["action"] = request.Action
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &UpdateCrmPersonalCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("UpdateCrmPersonalCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("PUT"), tea.String("AK"), tea.String("/v1.0/crm/personalCustomers"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) QueryCrmPersonalCustomer(request *QueryCrmPersonalCustomerRequest) (_result *QueryCrmPersonalCustomerResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryCrmPersonalCustomerHeaders{}
	_result = &QueryCrmPersonalCustomerResponse{}
	_body, _err := client.QueryCrmPersonalCustomerWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) QueryCrmPersonalCustomerWithOptions(request *QueryCrmPersonalCustomerRequest, headers *QueryCrmPersonalCustomerHeaders, runtime *util.RuntimeOptions) (_result *QueryCrmPersonalCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CurrentOperatorUserId)) {
		query["currentOperatorUserId"] = request.CurrentOperatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		query["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		query["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.QueryDsl)) {
		query["queryDsl"] = request.QueryDsl
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &QueryCrmPersonalCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("QueryCrmPersonalCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/personalCustomers"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) ListCrmPersonalCustomers(request *ListCrmPersonalCustomersRequest) (_result *ListCrmPersonalCustomersResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &ListCrmPersonalCustomersHeaders{}
	_result = &ListCrmPersonalCustomersResponse{}
	_body, _err := client.ListCrmPersonalCustomersWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) ListCrmPersonalCustomersWithOptions(request *ListCrmPersonalCustomersRequest, headers *ListCrmPersonalCustomersHeaders, runtime *util.RuntimeOptions) (_result *ListCrmPersonalCustomersResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.CurrentOperatorUserId)) {
		query["currentOperatorUserId"] = request.CurrentOperatorUserId
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
		Body:    request.Body,
	}
	_result = &ListCrmPersonalCustomersResponse{}
	_body, _err := client.DoROARequest(tea.String("ListCrmPersonalCustomers"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/personalCustomers/batchQuery"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

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

func (client *Client) CreateCustomerWithOptions(request *CreateCustomerRequest, headers *CreateCustomerHeaders, runtime *util.RuntimeOptions) (_result *CreateCustomerResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.ObjectType)) {
		body["objectType"] = request.ObjectType
	}

	if !tea.BoolValue(util.IsUnset(request.InstanceId)) {
		body["instanceId"] = request.InstanceId
	}

	if !tea.BoolValue(util.IsUnset(request.CreatorUserId)) {
		body["creatorUserId"] = request.CreatorUserId
	}

	if !tea.BoolValue(util.IsUnset(request.Data)) {
		body["data"] = request.Data
	}

	if !tea.BoolValue(util.IsUnset(request.ExtendData)) {
		body["extendData"] = request.ExtendData
	}

	if !tea.BoolValue(util.IsUnset(request.Contacts)) {
		body["contacts"] = request.Contacts
	}

	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.Permission))) {
		body["permission"] = request.Permission
	}

	if !tea.BoolValue(util.IsUnset(tea.ToMap(request.SaveOption))) {
		body["saveOption"] = request.SaveOption
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Body:    openapiutil.ParseToMap(body),
	}
	_result = &CreateCustomerResponse{}
	_body, _err := client.DoROARequest(tea.String("CreateCustomer"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("POST"), tea.String("AK"), tea.String("/v1.0/crm/customers"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

func (client *Client) QueryAllTracks(request *QueryAllTracksRequest) (_result *QueryAllTracksResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &QueryAllTracksHeaders{}
	_result = &QueryAllTracksResponse{}
	_body, _err := client.QueryAllTracksWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

func (client *Client) QueryAllTracksWithOptions(request *QueryAllTracksRequest, headers *QueryAllTracksHeaders, runtime *util.RuntimeOptions) (_result *QueryAllTracksResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		query["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		query["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.Order)) {
		query["order"] = request.Order
	}

	realHeaders := make(map[string]*string)
	if !tea.BoolValue(util.IsUnset(headers.CommonHeaders)) {
		realHeaders = headers.CommonHeaders
	}

	if !tea.BoolValue(util.IsUnset(headers.XAcsDingtalkAccessToken)) {
		realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken
	}

	req := &openapi.OpenApiRequest{
		Headers: realHeaders,
		Query:   openapiutil.Query(query),
	}
	_result = &QueryAllTracksResponse{}
	_body, _err := client.DoROARequest(tea.String("QueryAllTracks"), tea.String("crm_1.0"), tea.String("HTTP"), tea.String("GET"), tea.String("AK"), tea.String("/v1.0/crm/customers/tracks"), tea.String("json"), req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}
