// This file is auto-generated, don't edit it. Thanks.
package flashmeeting_1_0

import (
	openapi "github.com/alibabacloud-go/darabonba-openapi/v2/client"
	gatewayclient "github.com/alibabacloud-go/gateway-dingtalk/client"
	openapiutil "github.com/alibabacloud-go/openapi-util/service"
	util "github.com/alibabacloud-go/tea-utils/v2/service"
	"github.com/alibabacloud-go/tea/tea"
)

type CreateFlashMeetingHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CreateFlashMeetingHeaders) String() string {
	return tea.Prettify(s)
}

func (s CreateFlashMeetingHeaders) GoString() string {
	return s.String()
}

func (s *CreateFlashMeetingHeaders) SetCommonHeaders(v map[string]*string) *CreateFlashMeetingHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CreateFlashMeetingHeaders) SetXAcsDingtalkAccessToken(v string) *CreateFlashMeetingHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CreateFlashMeetingRequest struct {
	// This parameter is required.
	Creator *string `json:"creator,omitempty" xml:"creator,omitempty"`
	// This parameter is required.
	EventId *string `json:"eventId,omitempty" xml:"eventId,omitempty"`
	Title   *string `json:"title,omitempty" xml:"title,omitempty"`
}

func (s CreateFlashMeetingRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateFlashMeetingRequest) GoString() string {
	return s.String()
}

func (s *CreateFlashMeetingRequest) SetCreator(v string) *CreateFlashMeetingRequest {
	s.Creator = &v
	return s
}

func (s *CreateFlashMeetingRequest) SetEventId(v string) *CreateFlashMeetingRequest {
	s.EventId = &v
	return s
}

func (s *CreateFlashMeetingRequest) SetTitle(v string) *CreateFlashMeetingRequest {
	s.Title = &v
	return s
}

type CreateFlashMeetingResponseBody struct {
	// This parameter is required.
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// This parameter is required.
	FlashMeetingKey *string `json:"flashMeetingKey,omitempty" xml:"flashMeetingKey,omitempty"`
	// This parameter is required.
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
	// This parameter is required.
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
	// This parameter is required.
	Url *string `json:"url,omitempty" xml:"url,omitempty"`
}

func (s CreateFlashMeetingResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateFlashMeetingResponseBody) GoString() string {
	return s.String()
}

func (s *CreateFlashMeetingResponseBody) SetEndTime(v int64) *CreateFlashMeetingResponseBody {
	s.EndTime = &v
	return s
}

func (s *CreateFlashMeetingResponseBody) SetFlashMeetingKey(v string) *CreateFlashMeetingResponseBody {
	s.FlashMeetingKey = &v
	return s
}

func (s *CreateFlashMeetingResponseBody) SetStartTime(v int64) *CreateFlashMeetingResponseBody {
	s.StartTime = &v
	return s
}

func (s *CreateFlashMeetingResponseBody) SetTitle(v string) *CreateFlashMeetingResponseBody {
	s.Title = &v
	return s
}

func (s *CreateFlashMeetingResponseBody) SetUrl(v string) *CreateFlashMeetingResponseBody {
	s.Url = &v
	return s
}

type CreateFlashMeetingResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CreateFlashMeetingResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CreateFlashMeetingResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateFlashMeetingResponse) GoString() string {
	return s.String()
}

func (s *CreateFlashMeetingResponse) SetHeaders(v map[string]*string) *CreateFlashMeetingResponse {
	s.Headers = v
	return s
}

func (s *CreateFlashMeetingResponse) SetStatusCode(v int32) *CreateFlashMeetingResponse {
	s.StatusCode = &v
	return s
}

func (s *CreateFlashMeetingResponse) SetBody(v *CreateFlashMeetingResponseBody) *CreateFlashMeetingResponse {
	s.Body = v
	return s
}

type ExportShanhuiToDocHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s ExportShanhuiToDocHeaders) String() string {
	return tea.Prettify(s)
}

func (s ExportShanhuiToDocHeaders) GoString() string {
	return s.String()
}

func (s *ExportShanhuiToDocHeaders) SetCommonHeaders(v map[string]*string) *ExportShanhuiToDocHeaders {
	s.CommonHeaders = v
	return s
}

func (s *ExportShanhuiToDocHeaders) SetXAcsDingtalkAccessToken(v string) *ExportShanhuiToDocHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type ExportShanhuiToDocRequest struct {
	ContentEnums  []*string `json:"contentEnums,omitempty" xml:"contentEnums,omitempty" type:"Repeated"`
	ParentNodeKey *string   `json:"parentNodeKey,omitempty" xml:"parentNodeKey,omitempty"`
	ShanhuiKey    *string   `json:"shanhuiKey,omitempty" xml:"shanhuiKey,omitempty"`
	UserId        *string   `json:"userId,omitempty" xml:"userId,omitempty"`
	WorkspaceKey  *string   `json:"workspaceKey,omitempty" xml:"workspaceKey,omitempty"`
}

func (s ExportShanhuiToDocRequest) String() string {
	return tea.Prettify(s)
}

func (s ExportShanhuiToDocRequest) GoString() string {
	return s.String()
}

func (s *ExportShanhuiToDocRequest) SetContentEnums(v []*string) *ExportShanhuiToDocRequest {
	s.ContentEnums = v
	return s
}

func (s *ExportShanhuiToDocRequest) SetParentNodeKey(v string) *ExportShanhuiToDocRequest {
	s.ParentNodeKey = &v
	return s
}

func (s *ExportShanhuiToDocRequest) SetShanhuiKey(v string) *ExportShanhuiToDocRequest {
	s.ShanhuiKey = &v
	return s
}

func (s *ExportShanhuiToDocRequest) SetUserId(v string) *ExportShanhuiToDocRequest {
	s.UserId = &v
	return s
}

func (s *ExportShanhuiToDocRequest) SetWorkspaceKey(v string) *ExportShanhuiToDocRequest {
	s.WorkspaceKey = &v
	return s
}

type ExportShanhuiToDocResponseBody struct {
	Result  *string `json:"result,omitempty" xml:"result,omitempty"`
	Success *bool   `json:"success,omitempty" xml:"success,omitempty"`
}

func (s ExportShanhuiToDocResponseBody) String() string {
	return tea.Prettify(s)
}

func (s ExportShanhuiToDocResponseBody) GoString() string {
	return s.String()
}

func (s *ExportShanhuiToDocResponseBody) SetResult(v string) *ExportShanhuiToDocResponseBody {
	s.Result = &v
	return s
}

func (s *ExportShanhuiToDocResponseBody) SetSuccess(v bool) *ExportShanhuiToDocResponseBody {
	s.Success = &v
	return s
}

type ExportShanhuiToDocResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *ExportShanhuiToDocResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s ExportShanhuiToDocResponse) String() string {
	return tea.Prettify(s)
}

func (s ExportShanhuiToDocResponse) GoString() string {
	return s.String()
}

func (s *ExportShanhuiToDocResponse) SetHeaders(v map[string]*string) *ExportShanhuiToDocResponse {
	s.Headers = v
	return s
}

func (s *ExportShanhuiToDocResponse) SetStatusCode(v int32) *ExportShanhuiToDocResponse {
	s.StatusCode = &v
	return s
}

func (s *ExportShanhuiToDocResponse) SetBody(v *ExportShanhuiToDocResponseBody) *ExportShanhuiToDocResponse {
	s.Body = v
	return s
}

type GetShanhuiByCalendarHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetShanhuiByCalendarHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByCalendarHeaders) GoString() string {
	return s.String()
}

func (s *GetShanhuiByCalendarHeaders) SetCommonHeaders(v map[string]*string) *GetShanhuiByCalendarHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetShanhuiByCalendarHeaders) SetXAcsDingtalkAccessToken(v string) *GetShanhuiByCalendarHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetShanhuiByCalendarRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// VGZCWXpvTmxpQmorbUhiSXUveTB98Iok
	EventId *string `json:"eventId,omitempty" xml:"eventId,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// EUiSN7beu1Q2wR
	UserId *string `json:"userId,omitempty" xml:"userId,omitempty"`
}

func (s GetShanhuiByCalendarRequest) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByCalendarRequest) GoString() string {
	return s.String()
}

func (s *GetShanhuiByCalendarRequest) SetEventId(v string) *GetShanhuiByCalendarRequest {
	s.EventId = &v
	return s
}

func (s *GetShanhuiByCalendarRequest) SetUserId(v string) *GetShanhuiByCalendarRequest {
	s.UserId = &v
	return s
}

type GetShanhuiByCalendarResponseBody struct {
	Result *GetShanhuiByCalendarResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s GetShanhuiByCalendarResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByCalendarResponseBody) GoString() string {
	return s.String()
}

func (s *GetShanhuiByCalendarResponseBody) SetResult(v *GetShanhuiByCalendarResponseBodyResult) *GetShanhuiByCalendarResponseBody {
	s.Result = v
	return s
}

func (s *GetShanhuiByCalendarResponseBody) SetSuccess(v bool) *GetShanhuiByCalendarResponseBody {
	s.Success = &v
	return s
}

type GetShanhuiByCalendarResponseBodyResult struct {
	// example:
	//
	// 1685332800000
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 8K4ny9P9No06sjhk
	FlashmeetingKey *string `json:"flashmeetingKey,omitempty" xml:"flashmeetingKey,omitempty"`
	// example:
	//
	// false
	HasSummary *bool `json:"hasSummary,omitempty" xml:"hasSummary,omitempty"`
	// example:
	//
	// 1685318400000
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
	// example:
	//
	// 2Hj32Uio28fjmMiu9Klsk
	SummaryDocKey *string `json:"summaryDocKey,omitempty" xml:"summaryDocKey,omitempty"`
	// example:
	//
	// 测试闪会
	Title  *string                                         `json:"title,omitempty" xml:"title,omitempty"`
	Topics []*GetShanhuiByCalendarResponseBodyResultTopics `json:"topics,omitempty" xml:"topics,omitempty" type:"Repeated"`
}

func (s GetShanhuiByCalendarResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByCalendarResponseBodyResult) GoString() string {
	return s.String()
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetEndTime(v int64) *GetShanhuiByCalendarResponseBodyResult {
	s.EndTime = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetFlashmeetingKey(v string) *GetShanhuiByCalendarResponseBodyResult {
	s.FlashmeetingKey = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetHasSummary(v bool) *GetShanhuiByCalendarResponseBodyResult {
	s.HasSummary = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetStartTime(v int64) *GetShanhuiByCalendarResponseBodyResult {
	s.StartTime = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetSummaryDocKey(v string) *GetShanhuiByCalendarResponseBodyResult {
	s.SummaryDocKey = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetTitle(v string) *GetShanhuiByCalendarResponseBodyResult {
	s.Title = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResult) SetTopics(v []*GetShanhuiByCalendarResponseBodyResultTopics) *GetShanhuiByCalendarResponseBodyResult {
	s.Topics = v
	return s
}

type GetShanhuiByCalendarResponseBodyResultTopics struct {
	// example:
	//
	// 27Hio9BV23Ghj8LkRe34QzSdP94UtMkju
	DocKey *string `json:"docKey,omitempty" xml:"docKey,omitempty"`
	// example:
	//
	// 会议1
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
}

func (s GetShanhuiByCalendarResponseBodyResultTopics) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByCalendarResponseBodyResultTopics) GoString() string {
	return s.String()
}

func (s *GetShanhuiByCalendarResponseBodyResultTopics) SetDocKey(v string) *GetShanhuiByCalendarResponseBodyResultTopics {
	s.DocKey = &v
	return s
}

func (s *GetShanhuiByCalendarResponseBodyResultTopics) SetTitle(v string) *GetShanhuiByCalendarResponseBodyResultTopics {
	s.Title = &v
	return s
}

type GetShanhuiByCalendarResponse struct {
	Headers    map[string]*string                `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                            `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetShanhuiByCalendarResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetShanhuiByCalendarResponse) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByCalendarResponse) GoString() string {
	return s.String()
}

func (s *GetShanhuiByCalendarResponse) SetHeaders(v map[string]*string) *GetShanhuiByCalendarResponse {
	s.Headers = v
	return s
}

func (s *GetShanhuiByCalendarResponse) SetStatusCode(v int32) *GetShanhuiByCalendarResponse {
	s.StatusCode = &v
	return s
}

func (s *GetShanhuiByCalendarResponse) SetBody(v *GetShanhuiByCalendarResponseBody) *GetShanhuiByCalendarResponse {
	s.Body = v
	return s
}

type GetShanhuiByShanhuiKeyHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetShanhuiByShanhuiKeyHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByShanhuiKeyHeaders) GoString() string {
	return s.String()
}

func (s *GetShanhuiByShanhuiKeyHeaders) SetCommonHeaders(v map[string]*string) *GetShanhuiByShanhuiKeyHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetShanhuiByShanhuiKeyHeaders) SetXAcsDingtalkAccessToken(v string) *GetShanhuiByShanhuiKeyHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetShanhuiByShanhuiKeyResponseBody struct {
	Result *GetShanhuiByShanhuiKeyResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s GetShanhuiByShanhuiKeyResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByShanhuiKeyResponseBody) GoString() string {
	return s.String()
}

func (s *GetShanhuiByShanhuiKeyResponseBody) SetResult(v *GetShanhuiByShanhuiKeyResponseBodyResult) *GetShanhuiByShanhuiKeyResponseBody {
	s.Result = v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBody) SetSuccess(v bool) *GetShanhuiByShanhuiKeyResponseBody {
	s.Success = &v
	return s
}

type GetShanhuiByShanhuiKeyResponseBodyResult struct {
	// example:
	//
	// 1685332800000
	EndTime *int64 `json:"endTime,omitempty" xml:"endTime,omitempty"`
	// example:
	//
	// 2kms47sjhb882
	EventId *string `json:"eventId,omitempty" xml:"eventId,omitempty"`
	// example:
	//
	// 8K4ny9P9No06sjhk
	FlashmeetingKey *string `json:"flashmeetingKey,omitempty" xml:"flashmeetingKey,omitempty"`
	// example:
	//
	// false
	HasSummary *bool `json:"hasSummary,omitempty" xml:"hasSummary,omitempty"`
	// example:
	//
	// 1685318400000
	StartTime *int64 `json:"startTime,omitempty" xml:"startTime,omitempty"`
	// example:
	//
	// 2Hj32Uio28fjmMiu9Klsk
	SummaryDocKey *string `json:"summaryDocKey,omitempty" xml:"summaryDocKey,omitempty"`
	// example:
	//
	// 测试闪会
	Title  *string                                           `json:"title,omitempty" xml:"title,omitempty"`
	Topics []*GetShanhuiByShanhuiKeyResponseBodyResultTopics `json:"topics,omitempty" xml:"topics,omitempty" type:"Repeated"`
}

func (s GetShanhuiByShanhuiKeyResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByShanhuiKeyResponseBodyResult) GoString() string {
	return s.String()
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetEndTime(v int64) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.EndTime = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetEventId(v string) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.EventId = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetFlashmeetingKey(v string) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.FlashmeetingKey = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetHasSummary(v bool) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.HasSummary = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetStartTime(v int64) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.StartTime = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetSummaryDocKey(v string) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.SummaryDocKey = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetTitle(v string) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.Title = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResult) SetTopics(v []*GetShanhuiByShanhuiKeyResponseBodyResultTopics) *GetShanhuiByShanhuiKeyResponseBodyResult {
	s.Topics = v
	return s
}

type GetShanhuiByShanhuiKeyResponseBodyResultTopics struct {
	// This parameter is required.
	//
	// example:
	//
	// 27Hio9BV23Ghj8LkRe34QzSdP94UtMkju
	DocKey *string `json:"docKey,omitempty" xml:"docKey,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// 会议1
	Title *string `json:"title,omitempty" xml:"title,omitempty"`
}

func (s GetShanhuiByShanhuiKeyResponseBodyResultTopics) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByShanhuiKeyResponseBodyResultTopics) GoString() string {
	return s.String()
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResultTopics) SetDocKey(v string) *GetShanhuiByShanhuiKeyResponseBodyResultTopics {
	s.DocKey = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponseBodyResultTopics) SetTitle(v string) *GetShanhuiByShanhuiKeyResponseBodyResultTopics {
	s.Title = &v
	return s
}

type GetShanhuiByShanhuiKeyResponse struct {
	Headers    map[string]*string                  `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                              `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetShanhuiByShanhuiKeyResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetShanhuiByShanhuiKeyResponse) String() string {
	return tea.Prettify(s)
}

func (s GetShanhuiByShanhuiKeyResponse) GoString() string {
	return s.String()
}

func (s *GetShanhuiByShanhuiKeyResponse) SetHeaders(v map[string]*string) *GetShanhuiByShanhuiKeyResponse {
	s.Headers = v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponse) SetStatusCode(v int32) *GetShanhuiByShanhuiKeyResponse {
	s.StatusCode = &v
	return s
}

func (s *GetShanhuiByShanhuiKeyResponse) SetBody(v *GetShanhuiByShanhuiKeyResponseBody) *GetShanhuiByShanhuiKeyResponse {
	s.Body = v
	return s
}

type GetTaskFromShanhuiDocHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetTaskFromShanhuiDocHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocHeaders) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocHeaders) SetCommonHeaders(v map[string]*string) *GetTaskFromShanhuiDocHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetTaskFromShanhuiDocHeaders) SetXAcsDingtalkAccessToken(v string) *GetTaskFromShanhuiDocHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetTaskFromShanhuiDocRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// gMp7ldNxoWbAqBQN
	DocKey *string `json:"docKey,omitempty" xml:"docKey,omitempty"`
	// example:
	//
	// 10
	MaxResults *int64 `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	// example:
	//
	// 0
	NextToken *int64 `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// DMvP2vrwe5QVUk0RcNb2FgiEiE
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s GetTaskFromShanhuiDocRequest) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocRequest) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocRequest) SetDocKey(v string) *GetTaskFromShanhuiDocRequest {
	s.DocKey = &v
	return s
}

func (s *GetTaskFromShanhuiDocRequest) SetMaxResults(v int64) *GetTaskFromShanhuiDocRequest {
	s.MaxResults = &v
	return s
}

func (s *GetTaskFromShanhuiDocRequest) SetNextToken(v int64) *GetTaskFromShanhuiDocRequest {
	s.NextToken = &v
	return s
}

func (s *GetTaskFromShanhuiDocRequest) SetUnionId(v string) *GetTaskFromShanhuiDocRequest {
	s.UnionId = &v
	return s
}

type GetTaskFromShanhuiDocResponseBody struct {
	Result  *GetTaskFromShanhuiDocResponseBodyResult `json:"result,omitempty" xml:"result,omitempty" type:"Struct"`
	Success *bool                                    `json:"success,omitempty" xml:"success,omitempty"`
}

func (s GetTaskFromShanhuiDocResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocResponseBody) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocResponseBody) SetResult(v *GetTaskFromShanhuiDocResponseBodyResult) *GetTaskFromShanhuiDocResponseBody {
	s.Result = v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBody) SetSuccess(v bool) *GetTaskFromShanhuiDocResponseBody {
	s.Success = &v
	return s
}

type GetTaskFromShanhuiDocResponseBodyResult struct {
	HasMore   *bool                                           `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	Items     []*GetTaskFromShanhuiDocResponseBodyResultItems `json:"items,omitempty" xml:"items,omitempty" type:"Repeated"`
	NextToken *string                                         `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	Total     *int64                                          `json:"total,omitempty" xml:"total,omitempty"`
}

func (s GetTaskFromShanhuiDocResponseBodyResult) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocResponseBodyResult) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocResponseBodyResult) SetHasMore(v bool) *GetTaskFromShanhuiDocResponseBodyResult {
	s.HasMore = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResult) SetItems(v []*GetTaskFromShanhuiDocResponseBodyResultItems) *GetTaskFromShanhuiDocResponseBodyResult {
	s.Items = v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResult) SetNextToken(v string) *GetTaskFromShanhuiDocResponseBodyResult {
	s.NextToken = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResult) SetTotal(v int64) *GetTaskFromShanhuiDocResponseBodyResult {
	s.Total = &v
	return s
}

type GetTaskFromShanhuiDocResponseBodyResultItems struct {
	CreateTime   *int64                                                      `json:"createTime,omitempty" xml:"createTime,omitempty"`
	CreatorId    *string                                                     `json:"creatorId,omitempty" xml:"creatorId,omitempty"`
	Deadline     *int64                                                      `json:"deadline,omitempty" xml:"deadline,omitempty"`
	Deleted      *bool                                                       `json:"deleted,omitempty" xml:"deleted,omitempty"`
	ExecutorList []*GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList `json:"executorList,omitempty" xml:"executorList,omitempty" type:"Repeated"`
	Priority     *int64                                                      `json:"priority,omitempty" xml:"priority,omitempty"`
	TaskKey      *string                                                     `json:"taskKey,omitempty" xml:"taskKey,omitempty"`
	TaskStatus   *string                                                     `json:"taskStatus,omitempty" xml:"taskStatus,omitempty"`
	TaskType     *string                                                     `json:"taskType,omitempty" xml:"taskType,omitempty"`
	Title        *string                                                     `json:"title,omitempty" xml:"title,omitempty"`
	UpdateTime   *int64                                                      `json:"updateTime,omitempty" xml:"updateTime,omitempty"`
}

func (s GetTaskFromShanhuiDocResponseBodyResultItems) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocResponseBodyResultItems) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetCreateTime(v int64) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.CreateTime = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetCreatorId(v string) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.CreatorId = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetDeadline(v int64) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.Deadline = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetDeleted(v bool) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.Deleted = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetExecutorList(v []*GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.ExecutorList = v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetPriority(v int64) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.Priority = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetTaskKey(v string) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.TaskKey = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetTaskStatus(v string) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.TaskStatus = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetTaskType(v string) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.TaskType = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetTitle(v string) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.Title = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItems) SetUpdateTime(v int64) *GetTaskFromShanhuiDocResponseBodyResultItems {
	s.UpdateTime = &v
	return s
}

type GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList struct {
	ExecutorId  *string `json:"executorId,omitempty" xml:"executorId,omitempty"`
	StatusStage *int32  `json:"statusStage,omitempty" xml:"statusStage,omitempty"`
	SubTaskKey  *string `json:"subTaskKey,omitempty" xml:"subTaskKey,omitempty"`
}

func (s GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList) SetExecutorId(v string) *GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList {
	s.ExecutorId = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList) SetStatusStage(v int32) *GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList {
	s.StatusStage = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList) SetSubTaskKey(v string) *GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList {
	s.SubTaskKey = &v
	return s
}

type GetTaskFromShanhuiDocResponse struct {
	Headers    map[string]*string                 `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                             `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetTaskFromShanhuiDocResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetTaskFromShanhuiDocResponse) String() string {
	return tea.Prettify(s)
}

func (s GetTaskFromShanhuiDocResponse) GoString() string {
	return s.String()
}

func (s *GetTaskFromShanhuiDocResponse) SetHeaders(v map[string]*string) *GetTaskFromShanhuiDocResponse {
	s.Headers = v
	return s
}

func (s *GetTaskFromShanhuiDocResponse) SetStatusCode(v int32) *GetTaskFromShanhuiDocResponse {
	s.StatusCode = &v
	return s
}

func (s *GetTaskFromShanhuiDocResponse) SetBody(v *GetTaskFromShanhuiDocResponseBody) *GetTaskFromShanhuiDocResponse {
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
// 创建钉闪会并绑定日程
//
// @param request - CreateFlashMeetingRequest
//
// @param headers - CreateFlashMeetingHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CreateFlashMeetingResponse
func (client *Client) CreateFlashMeetingWithOptions(request *CreateFlashMeetingRequest, headers *CreateFlashMeetingHeaders, runtime *util.RuntimeOptions) (_result *CreateFlashMeetingResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Creator)) {
		body["creator"] = request.Creator
	}

	if !tea.BoolValue(util.IsUnset(request.EventId)) {
		body["eventId"] = request.EventId
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
		Action:      tea.String("CreateFlashMeeting"),
		Version:     tea.String("flashmeeting_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/flashmeeting/meetings"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CreateFlashMeetingResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 创建钉闪会并绑定日程
//
// @param request - CreateFlashMeetingRequest
//
// @return CreateFlashMeetingResponse
func (client *Client) CreateFlashMeeting(request *CreateFlashMeetingRequest) (_result *CreateFlashMeetingResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CreateFlashMeetingHeaders{}
	_result = &CreateFlashMeetingResponse{}
	_body, _err := client.CreateFlashMeetingWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 将闪会导出到文档
//
// @param request - ExportShanhuiToDocRequest
//
// @param headers - ExportShanhuiToDocHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return ExportShanhuiToDocResponse
func (client *Client) ExportShanhuiToDocWithOptions(request *ExportShanhuiToDocRequest, headers *ExportShanhuiToDocHeaders, runtime *util.RuntimeOptions) (_result *ExportShanhuiToDocResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.ContentEnums)) {
		body["contentEnums"] = request.ContentEnums
	}

	if !tea.BoolValue(util.IsUnset(request.ParentNodeKey)) {
		body["parentNodeKey"] = request.ParentNodeKey
	}

	if !tea.BoolValue(util.IsUnset(request.ShanhuiKey)) {
		body["shanhuiKey"] = request.ShanhuiKey
	}

	if !tea.BoolValue(util.IsUnset(request.UserId)) {
		body["userId"] = request.UserId
	}

	if !tea.BoolValue(util.IsUnset(request.WorkspaceKey)) {
		body["workspaceKey"] = request.WorkspaceKey
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
		Action:      tea.String("ExportShanhuiToDoc"),
		Version:     tea.String("flashmeeting_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/flashmeeting/meetings/export"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &ExportShanhuiToDocResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 将闪会导出到文档
//
// @param request - ExportShanhuiToDocRequest
//
// @return ExportShanhuiToDocResponse
func (client *Client) ExportShanhuiToDoc(request *ExportShanhuiToDocRequest) (_result *ExportShanhuiToDocResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &ExportShanhuiToDocHeaders{}
	_result = &ExportShanhuiToDocResponse{}
	_body, _err := client.ExportShanhuiToDocWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 根据日程获取闪会的信息
//
// @param request - GetShanhuiByCalendarRequest
//
// @param headers - GetShanhuiByCalendarHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetShanhuiByCalendarResponse
func (client *Client) GetShanhuiByCalendarWithOptions(request *GetShanhuiByCalendarRequest, headers *GetShanhuiByCalendarHeaders, runtime *util.RuntimeOptions) (_result *GetShanhuiByCalendarResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.EventId)) {
		query["eventId"] = request.EventId
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
		Action:      tea.String("GetShanhuiByCalendar"),
		Version:     tea.String("flashmeeting_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/flashmeeting/calendars/meeting"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetShanhuiByCalendarResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 根据日程获取闪会的信息
//
// @param request - GetShanhuiByCalendarRequest
//
// @return GetShanhuiByCalendarResponse
func (client *Client) GetShanhuiByCalendar(request *GetShanhuiByCalendarRequest) (_result *GetShanhuiByCalendarResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetShanhuiByCalendarHeaders{}
	_result = &GetShanhuiByCalendarResponse{}
	_body, _err := client.GetShanhuiByCalendarWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
//
// @param headers - GetShanhuiByShanhuiKeyHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetShanhuiByShanhuiKeyResponse
func (client *Client) GetShanhuiByShanhuiKeyWithOptions(flashmeetingKey *string, headers *GetShanhuiByShanhuiKeyHeaders, runtime *util.RuntimeOptions) (_result *GetShanhuiByShanhuiKeyResponse, _err error) {
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
		Action:      tea.String("GetShanhuiByShanhuiKey"),
		Version:     tea.String("flashmeeting_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/flashmeeting/meetings/keys/" + tea.StringValue(flashmeetingKey) + "/infos"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetShanhuiByShanhuiKeyResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
//
// @return GetShanhuiByShanhuiKeyResponse
func (client *Client) GetShanhuiByShanhuiKey(flashmeetingKey *string) (_result *GetShanhuiByShanhuiKeyResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetShanhuiByShanhuiKeyHeaders{}
	_result = &GetShanhuiByShanhuiKeyResponse{}
	_body, _err := client.GetShanhuiByShanhuiKeyWithOptions(flashmeetingKey, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 根据闪会文档id获取待办任务
//
// @param request - GetTaskFromShanhuiDocRequest
//
// @param headers - GetTaskFromShanhuiDocHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetTaskFromShanhuiDocResponse
func (client *Client) GetTaskFromShanhuiDocWithOptions(request *GetTaskFromShanhuiDocRequest, headers *GetTaskFromShanhuiDocHeaders, runtime *util.RuntimeOptions) (_result *GetTaskFromShanhuiDocResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.DocKey)) {
		query["docKey"] = request.DocKey
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		query["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		query["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.UnionId)) {
		query["unionId"] = request.UnionId
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
		Action:      tea.String("GetTaskFromShanhuiDoc"),
		Version:     tea.String("flashmeeting_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/flashmeeting/meetings/tasks"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetTaskFromShanhuiDocResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 根据闪会文档id获取待办任务
//
// @param request - GetTaskFromShanhuiDocRequest
//
// @return GetTaskFromShanhuiDocResponse
func (client *Client) GetTaskFromShanhuiDoc(request *GetTaskFromShanhuiDocRequest) (_result *GetTaskFromShanhuiDocResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetTaskFromShanhuiDocHeaders{}
	_result = &GetTaskFromShanhuiDocResponse{}
	_body, _err := client.GetTaskFromShanhuiDocWithOptions(request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}
