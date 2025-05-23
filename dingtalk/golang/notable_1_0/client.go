// This file is auto-generated, don't edit it. Thanks.
package notable_1_0

import (
	openapi "github.com/alibabacloud-go/darabonba-openapi/v2/client"
	gatewayclient "github.com/alibabacloud-go/gateway-dingtalk/client"
	openapiutil "github.com/alibabacloud-go/openapi-util/service"
	util "github.com/alibabacloud-go/tea-utils/v2/service"
	"github.com/alibabacloud-go/tea/tea"
)

type CreateFieldHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CreateFieldHeaders) String() string {
	return tea.Prettify(s)
}

func (s CreateFieldHeaders) GoString() string {
	return s.String()
}

func (s *CreateFieldHeaders) SetCommonHeaders(v map[string]*string) *CreateFieldHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CreateFieldHeaders) SetXAcsDingtalkAccessToken(v string) *CreateFieldHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CreateFieldRequest struct {
	// This parameter is required.
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// key: id或者name
	//
	//     value: 对应字段值,不同类型的字段传入的value值不同
	//
	//       - text: "TextString"          // 文本字符串
	//
	//       - number: 123                 // 整数/浮点数均可
	//
	//       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
	//
	//       - date: 1688601600000 ｜ "2023-12-20 03:00"
	//
	//                                     // 支持传时间戳或ISO 8601字符串
	//
	//       - user: [{
	//
	//           uid: \"1234567\"            // 用户uid
	//
	//         }, {
	//
	//           uid: \"2345678\"
	//
	//         }]
	Property map[string]interface{} `json:"property,omitempty" xml:"property,omitempty"`
	// This parameter is required.
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s CreateFieldRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateFieldRequest) GoString() string {
	return s.String()
}

func (s *CreateFieldRequest) SetName(v string) *CreateFieldRequest {
	s.Name = &v
	return s
}

func (s *CreateFieldRequest) SetProperty(v map[string]interface{}) *CreateFieldRequest {
	s.Property = v
	return s
}

func (s *CreateFieldRequest) SetType(v string) *CreateFieldRequest {
	s.Type = &v
	return s
}

func (s *CreateFieldRequest) SetOperatorId(v string) *CreateFieldRequest {
	s.OperatorId = &v
	return s
}

type CreateFieldResponseBody struct {
	Id   *string `json:"id,omitempty" xml:"id,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// key: id或者name
	//
	//     value: 对应字段值,不同类型的字段传入的value值不同
	//
	//       - text: "TextString"          // 文本字符串
	//
	//       - number: 123                 // 整数/浮点数均可
	//
	//       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
	//
	//       - date: 1688601600000 ｜ "2023-12-20 03:00"
	//
	//                                     // 支持传时间戳或ISO 8601字符串
	//
	//       - user: [{
	//
	//           uid: \"1234567\"            // 用户uid
	//
	//         }, {
	//
	//           uid: \"2345678\"
	//
	//         }]
	Property map[string]interface{} `json:"property,omitempty" xml:"property,omitempty"`
	Type     *string                `json:"type,omitempty" xml:"type,omitempty"`
}

func (s CreateFieldResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateFieldResponseBody) GoString() string {
	return s.String()
}

func (s *CreateFieldResponseBody) SetId(v string) *CreateFieldResponseBody {
	s.Id = &v
	return s
}

func (s *CreateFieldResponseBody) SetName(v string) *CreateFieldResponseBody {
	s.Name = &v
	return s
}

func (s *CreateFieldResponseBody) SetProperty(v map[string]interface{}) *CreateFieldResponseBody {
	s.Property = v
	return s
}

func (s *CreateFieldResponseBody) SetType(v string) *CreateFieldResponseBody {
	s.Type = &v
	return s
}

type CreateFieldResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CreateFieldResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CreateFieldResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateFieldResponse) GoString() string {
	return s.String()
}

func (s *CreateFieldResponse) SetHeaders(v map[string]*string) *CreateFieldResponse {
	s.Headers = v
	return s
}

func (s *CreateFieldResponse) SetStatusCode(v int32) *CreateFieldResponse {
	s.StatusCode = &v
	return s
}

func (s *CreateFieldResponse) SetBody(v *CreateFieldResponseBody) *CreateFieldResponse {
	s.Body = v
	return s
}

type CreateSheetHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s CreateSheetHeaders) String() string {
	return tea.Prettify(s)
}

func (s CreateSheetHeaders) GoString() string {
	return s.String()
}

func (s *CreateSheetHeaders) SetCommonHeaders(v map[string]*string) *CreateSheetHeaders {
	s.CommonHeaders = v
	return s
}

func (s *CreateSheetHeaders) SetXAcsDingtalkAccessToken(v string) *CreateSheetHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type CreateSheetRequest struct {
	Fields []*CreateSheetRequestFields `json:"fields,omitempty" xml:"fields,omitempty" type:"Repeated"`
	Name   *string                     `json:"name,omitempty" xml:"name,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s CreateSheetRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateSheetRequest) GoString() string {
	return s.String()
}

func (s *CreateSheetRequest) SetFields(v []*CreateSheetRequestFields) *CreateSheetRequest {
	s.Fields = v
	return s
}

func (s *CreateSheetRequest) SetName(v string) *CreateSheetRequest {
	s.Name = &v
	return s
}

func (s *CreateSheetRequest) SetOperatorId(v string) *CreateSheetRequest {
	s.OperatorId = &v
	return s
}

type CreateSheetRequestFields struct {
	// This parameter is required.
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// key: id或者name
	//
	//     value: 对应字段值,不同类型的字段传入的value值不同
	//
	//       - text: "TextString"          // 文本字符串
	//
	//       - number: 123                 // 整数/浮点数均可
	//
	//       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
	//
	//       - date: 1688601600000 ｜ "2023-12-20 03:00"
	//
	//                                     // 支持传时间戳或ISO 8601字符串
	//
	//       - user: [{
	//
	//           uid: \"1234567\"            // 用户uid
	//
	//         }, {
	//
	//           uid: \"2345678\"
	//
	//         }]
	Property map[string]interface{} `json:"property,omitempty" xml:"property,omitempty"`
	// This parameter is required.
	Type *string `json:"type,omitempty" xml:"type,omitempty"`
}

func (s CreateSheetRequestFields) String() string {
	return tea.Prettify(s)
}

func (s CreateSheetRequestFields) GoString() string {
	return s.String()
}

func (s *CreateSheetRequestFields) SetName(v string) *CreateSheetRequestFields {
	s.Name = &v
	return s
}

func (s *CreateSheetRequestFields) SetProperty(v map[string]interface{}) *CreateSheetRequestFields {
	s.Property = v
	return s
}

func (s *CreateSheetRequestFields) SetType(v string) *CreateSheetRequestFields {
	s.Type = &v
	return s
}

type CreateSheetResponseBody struct {
	Id   *string `json:"id,omitempty" xml:"id,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s CreateSheetResponseBody) String() string {
	return tea.Prettify(s)
}

func (s CreateSheetResponseBody) GoString() string {
	return s.String()
}

func (s *CreateSheetResponseBody) SetId(v string) *CreateSheetResponseBody {
	s.Id = &v
	return s
}

func (s *CreateSheetResponseBody) SetName(v string) *CreateSheetResponseBody {
	s.Name = &v
	return s
}

type CreateSheetResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *CreateSheetResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s CreateSheetResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateSheetResponse) GoString() string {
	return s.String()
}

func (s *CreateSheetResponse) SetHeaders(v map[string]*string) *CreateSheetResponse {
	s.Headers = v
	return s
}

func (s *CreateSheetResponse) SetStatusCode(v int32) *CreateSheetResponse {
	s.StatusCode = &v
	return s
}

func (s *CreateSheetResponse) SetBody(v *CreateSheetResponseBody) *CreateSheetResponse {
	s.Body = v
	return s
}

type DeleteFieldHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DeleteFieldHeaders) String() string {
	return tea.Prettify(s)
}

func (s DeleteFieldHeaders) GoString() string {
	return s.String()
}

func (s *DeleteFieldHeaders) SetCommonHeaders(v map[string]*string) *DeleteFieldHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DeleteFieldHeaders) SetXAcsDingtalkAccessToken(v string) *DeleteFieldHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DeleteFieldRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s DeleteFieldRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteFieldRequest) GoString() string {
	return s.String()
}

func (s *DeleteFieldRequest) SetOperatorId(v string) *DeleteFieldRequest {
	s.OperatorId = &v
	return s
}

type DeleteFieldResponseBody struct {
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s DeleteFieldResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteFieldResponseBody) GoString() string {
	return s.String()
}

func (s *DeleteFieldResponseBody) SetSuccess(v bool) *DeleteFieldResponseBody {
	s.Success = &v
	return s
}

type DeleteFieldResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *DeleteFieldResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s DeleteFieldResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteFieldResponse) GoString() string {
	return s.String()
}

func (s *DeleteFieldResponse) SetHeaders(v map[string]*string) *DeleteFieldResponse {
	s.Headers = v
	return s
}

func (s *DeleteFieldResponse) SetStatusCode(v int32) *DeleteFieldResponse {
	s.StatusCode = &v
	return s
}

func (s *DeleteFieldResponse) SetBody(v *DeleteFieldResponseBody) *DeleteFieldResponse {
	s.Body = v
	return s
}

type DeleteRecordsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DeleteRecordsHeaders) String() string {
	return tea.Prettify(s)
}

func (s DeleteRecordsHeaders) GoString() string {
	return s.String()
}

func (s *DeleteRecordsHeaders) SetCommonHeaders(v map[string]*string) *DeleteRecordsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DeleteRecordsHeaders) SetXAcsDingtalkAccessToken(v string) *DeleteRecordsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DeleteRecordsRequest struct {
	// This parameter is required.
	RecordIds []*string `json:"recordIds,omitempty" xml:"recordIds,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s DeleteRecordsRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteRecordsRequest) GoString() string {
	return s.String()
}

func (s *DeleteRecordsRequest) SetRecordIds(v []*string) *DeleteRecordsRequest {
	s.RecordIds = v
	return s
}

func (s *DeleteRecordsRequest) SetOperatorId(v string) *DeleteRecordsRequest {
	s.OperatorId = &v
	return s
}

type DeleteRecordsResponseBody struct {
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s DeleteRecordsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteRecordsResponseBody) GoString() string {
	return s.String()
}

func (s *DeleteRecordsResponseBody) SetSuccess(v bool) *DeleteRecordsResponseBody {
	s.Success = &v
	return s
}

type DeleteRecordsResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *DeleteRecordsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s DeleteRecordsResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteRecordsResponse) GoString() string {
	return s.String()
}

func (s *DeleteRecordsResponse) SetHeaders(v map[string]*string) *DeleteRecordsResponse {
	s.Headers = v
	return s
}

func (s *DeleteRecordsResponse) SetStatusCode(v int32) *DeleteRecordsResponse {
	s.StatusCode = &v
	return s
}

func (s *DeleteRecordsResponse) SetBody(v *DeleteRecordsResponseBody) *DeleteRecordsResponse {
	s.Body = v
	return s
}

type DeleteSheetHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s DeleteSheetHeaders) String() string {
	return tea.Prettify(s)
}

func (s DeleteSheetHeaders) GoString() string {
	return s.String()
}

func (s *DeleteSheetHeaders) SetCommonHeaders(v map[string]*string) *DeleteSheetHeaders {
	s.CommonHeaders = v
	return s
}

func (s *DeleteSheetHeaders) SetXAcsDingtalkAccessToken(v string) *DeleteSheetHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type DeleteSheetRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s DeleteSheetRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteSheetRequest) GoString() string {
	return s.String()
}

func (s *DeleteSheetRequest) SetOperatorId(v string) *DeleteSheetRequest {
	s.OperatorId = &v
	return s
}

type DeleteSheetResponseBody struct {
	// example:
	//
	// true
	Success *bool `json:"success,omitempty" xml:"success,omitempty"`
}

func (s DeleteSheetResponseBody) String() string {
	return tea.Prettify(s)
}

func (s DeleteSheetResponseBody) GoString() string {
	return s.String()
}

func (s *DeleteSheetResponseBody) SetSuccess(v bool) *DeleteSheetResponseBody {
	s.Success = &v
	return s
}

type DeleteSheetResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *DeleteSheetResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s DeleteSheetResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteSheetResponse) GoString() string {
	return s.String()
}

func (s *DeleteSheetResponse) SetHeaders(v map[string]*string) *DeleteSheetResponse {
	s.Headers = v
	return s
}

func (s *DeleteSheetResponse) SetStatusCode(v int32) *DeleteSheetResponse {
	s.StatusCode = &v
	return s
}

func (s *DeleteSheetResponse) SetBody(v *DeleteSheetResponseBody) *DeleteSheetResponse {
	s.Body = v
	return s
}

type GetAllFieldsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetAllFieldsHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetAllFieldsHeaders) GoString() string {
	return s.String()
}

func (s *GetAllFieldsHeaders) SetCommonHeaders(v map[string]*string) *GetAllFieldsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetAllFieldsHeaders) SetXAcsDingtalkAccessToken(v string) *GetAllFieldsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetAllFieldsRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s GetAllFieldsRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAllFieldsRequest) GoString() string {
	return s.String()
}

func (s *GetAllFieldsRequest) SetOperatorId(v string) *GetAllFieldsRequest {
	s.OperatorId = &v
	return s
}

type GetAllFieldsResponseBody struct {
	Value []*GetAllFieldsResponseBodyValue `json:"value,omitempty" xml:"value,omitempty" type:"Repeated"`
}

func (s GetAllFieldsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetAllFieldsResponseBody) GoString() string {
	return s.String()
}

func (s *GetAllFieldsResponseBody) SetValue(v []*GetAllFieldsResponseBodyValue) *GetAllFieldsResponseBody {
	s.Value = v
	return s
}

type GetAllFieldsResponseBodyValue struct {
	Id   *string `json:"id,omitempty" xml:"id,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// key: id或者name
	//
	//     value: 对应字段值,不同类型的字段传入的value值不同
	//
	//       - text: "TextString"          // 文本字符串
	//
	//       - number: 123                 // 整数/浮点数均可
	//
	//       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
	//
	//       - date: 1688601600000 ｜ "2023-12-20 03:00"
	//
	//                                     // 支持传时间戳或ISO 8601字符串
	//
	//       - user: [{
	//
	//           uid: \"1234567\"            // 用户uid
	//
	//         }, {
	//
	//           uid: \"2345678\"
	//
	//         }]
	Property map[string]interface{} `json:"property,omitempty" xml:"property,omitempty"`
	Type     *string                `json:"type,omitempty" xml:"type,omitempty"`
}

func (s GetAllFieldsResponseBodyValue) String() string {
	return tea.Prettify(s)
}

func (s GetAllFieldsResponseBodyValue) GoString() string {
	return s.String()
}

func (s *GetAllFieldsResponseBodyValue) SetId(v string) *GetAllFieldsResponseBodyValue {
	s.Id = &v
	return s
}

func (s *GetAllFieldsResponseBodyValue) SetName(v string) *GetAllFieldsResponseBodyValue {
	s.Name = &v
	return s
}

func (s *GetAllFieldsResponseBodyValue) SetProperty(v map[string]interface{}) *GetAllFieldsResponseBodyValue {
	s.Property = v
	return s
}

func (s *GetAllFieldsResponseBodyValue) SetType(v string) *GetAllFieldsResponseBodyValue {
	s.Type = &v
	return s
}

type GetAllFieldsResponse struct {
	Headers    map[string]*string        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetAllFieldsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetAllFieldsResponse) String() string {
	return tea.Prettify(s)
}

func (s GetAllFieldsResponse) GoString() string {
	return s.String()
}

func (s *GetAllFieldsResponse) SetHeaders(v map[string]*string) *GetAllFieldsResponse {
	s.Headers = v
	return s
}

func (s *GetAllFieldsResponse) SetStatusCode(v int32) *GetAllFieldsResponse {
	s.StatusCode = &v
	return s
}

func (s *GetAllFieldsResponse) SetBody(v *GetAllFieldsResponseBody) *GetAllFieldsResponse {
	s.Body = v
	return s
}

type GetAllSheetsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetAllSheetsHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetAllSheetsHeaders) GoString() string {
	return s.String()
}

func (s *GetAllSheetsHeaders) SetCommonHeaders(v map[string]*string) *GetAllSheetsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetAllSheetsHeaders) SetXAcsDingtalkAccessToken(v string) *GetAllSheetsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetAllSheetsRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s GetAllSheetsRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAllSheetsRequest) GoString() string {
	return s.String()
}

func (s *GetAllSheetsRequest) SetOperatorId(v string) *GetAllSheetsRequest {
	s.OperatorId = &v
	return s
}

type GetAllSheetsResponseBody struct {
	Value []*GetAllSheetsResponseBodyValue `json:"value,omitempty" xml:"value,omitempty" type:"Repeated"`
}

func (s GetAllSheetsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetAllSheetsResponseBody) GoString() string {
	return s.String()
}

func (s *GetAllSheetsResponseBody) SetValue(v []*GetAllSheetsResponseBodyValue) *GetAllSheetsResponseBody {
	s.Value = v
	return s
}

type GetAllSheetsResponseBodyValue struct {
	Id   *string `json:"id,omitempty" xml:"id,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s GetAllSheetsResponseBodyValue) String() string {
	return tea.Prettify(s)
}

func (s GetAllSheetsResponseBodyValue) GoString() string {
	return s.String()
}

func (s *GetAllSheetsResponseBodyValue) SetId(v string) *GetAllSheetsResponseBodyValue {
	s.Id = &v
	return s
}

func (s *GetAllSheetsResponseBodyValue) SetName(v string) *GetAllSheetsResponseBodyValue {
	s.Name = &v
	return s
}

type GetAllSheetsResponse struct {
	Headers    map[string]*string        `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                    `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetAllSheetsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetAllSheetsResponse) String() string {
	return tea.Prettify(s)
}

func (s GetAllSheetsResponse) GoString() string {
	return s.String()
}

func (s *GetAllSheetsResponse) SetHeaders(v map[string]*string) *GetAllSheetsResponse {
	s.Headers = v
	return s
}

func (s *GetAllSheetsResponse) SetStatusCode(v int32) *GetAllSheetsResponse {
	s.StatusCode = &v
	return s
}

func (s *GetAllSheetsResponse) SetBody(v *GetAllSheetsResponseBody) *GetAllSheetsResponse {
	s.Body = v
	return s
}

type GetRecordHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetRecordHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetRecordHeaders) GoString() string {
	return s.String()
}

func (s *GetRecordHeaders) SetCommonHeaders(v map[string]*string) *GetRecordHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetRecordHeaders) SetXAcsDingtalkAccessToken(v string) *GetRecordHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetRecordRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s GetRecordRequest) String() string {
	return tea.Prettify(s)
}

func (s GetRecordRequest) GoString() string {
	return s.String()
}

func (s *GetRecordRequest) SetOperatorId(v string) *GetRecordRequest {
	s.OperatorId = &v
	return s
}

type GetRecordResponseBody struct {
	CreatedBy        *GetRecordResponseBodyCreatedBy      `json:"createdBy,omitempty" xml:"createdBy,omitempty" type:"Struct"`
	CreatedTime      *int64                               `json:"createdTime,omitempty" xml:"createdTime,omitempty"`
	Fields           map[string]interface{}               `json:"fields,omitempty" xml:"fields,omitempty"`
	Id               *string                              `json:"id,omitempty" xml:"id,omitempty"`
	LastModifiedBy   *GetRecordResponseBodyLastModifiedBy `json:"lastModifiedBy,omitempty" xml:"lastModifiedBy,omitempty" type:"Struct"`
	LastModifiedTime *int64                               `json:"lastModifiedTime,omitempty" xml:"lastModifiedTime,omitempty"`
}

func (s GetRecordResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetRecordResponseBody) GoString() string {
	return s.String()
}

func (s *GetRecordResponseBody) SetCreatedBy(v *GetRecordResponseBodyCreatedBy) *GetRecordResponseBody {
	s.CreatedBy = v
	return s
}

func (s *GetRecordResponseBody) SetCreatedTime(v int64) *GetRecordResponseBody {
	s.CreatedTime = &v
	return s
}

func (s *GetRecordResponseBody) SetFields(v map[string]interface{}) *GetRecordResponseBody {
	s.Fields = v
	return s
}

func (s *GetRecordResponseBody) SetId(v string) *GetRecordResponseBody {
	s.Id = &v
	return s
}

func (s *GetRecordResponseBody) SetLastModifiedBy(v *GetRecordResponseBodyLastModifiedBy) *GetRecordResponseBody {
	s.LastModifiedBy = v
	return s
}

func (s *GetRecordResponseBody) SetLastModifiedTime(v int64) *GetRecordResponseBody {
	s.LastModifiedTime = &v
	return s
}

type GetRecordResponseBodyCreatedBy struct {
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s GetRecordResponseBodyCreatedBy) String() string {
	return tea.Prettify(s)
}

func (s GetRecordResponseBodyCreatedBy) GoString() string {
	return s.String()
}

func (s *GetRecordResponseBodyCreatedBy) SetUnionId(v string) *GetRecordResponseBodyCreatedBy {
	s.UnionId = &v
	return s
}

type GetRecordResponseBodyLastModifiedBy struct {
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s GetRecordResponseBodyLastModifiedBy) String() string {
	return tea.Prettify(s)
}

func (s GetRecordResponseBodyLastModifiedBy) GoString() string {
	return s.String()
}

func (s *GetRecordResponseBodyLastModifiedBy) SetUnionId(v string) *GetRecordResponseBodyLastModifiedBy {
	s.UnionId = &v
	return s
}

type GetRecordResponse struct {
	Headers    map[string]*string     `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                 `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetRecordResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetRecordResponse) String() string {
	return tea.Prettify(s)
}

func (s GetRecordResponse) GoString() string {
	return s.String()
}

func (s *GetRecordResponse) SetHeaders(v map[string]*string) *GetRecordResponse {
	s.Headers = v
	return s
}

func (s *GetRecordResponse) SetStatusCode(v int32) *GetRecordResponse {
	s.StatusCode = &v
	return s
}

func (s *GetRecordResponse) SetBody(v *GetRecordResponseBody) *GetRecordResponse {
	s.Body = v
	return s
}

type GetRecordsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetRecordsHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsHeaders) GoString() string {
	return s.String()
}

func (s *GetRecordsHeaders) SetCommonHeaders(v map[string]*string) *GetRecordsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetRecordsHeaders) SetXAcsDingtalkAccessToken(v string) *GetRecordsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetRecordsRequest struct {
	MaxResults *int32  `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	NextToken  *string `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s GetRecordsRequest) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsRequest) GoString() string {
	return s.String()
}

func (s *GetRecordsRequest) SetMaxResults(v int32) *GetRecordsRequest {
	s.MaxResults = &v
	return s
}

func (s *GetRecordsRequest) SetNextToken(v string) *GetRecordsRequest {
	s.NextToken = &v
	return s
}

func (s *GetRecordsRequest) SetOperatorId(v string) *GetRecordsRequest {
	s.OperatorId = &v
	return s
}

type GetRecordsResponseBody struct {
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// example:
	//
	// nextToken
	NextToken *string                          `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	Records   []*GetRecordsResponseBodyRecords `json:"records,omitempty" xml:"records,omitempty" type:"Repeated"`
}

func (s GetRecordsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsResponseBody) GoString() string {
	return s.String()
}

func (s *GetRecordsResponseBody) SetHasMore(v bool) *GetRecordsResponseBody {
	s.HasMore = &v
	return s
}

func (s *GetRecordsResponseBody) SetNextToken(v string) *GetRecordsResponseBody {
	s.NextToken = &v
	return s
}

func (s *GetRecordsResponseBody) SetRecords(v []*GetRecordsResponseBodyRecords) *GetRecordsResponseBody {
	s.Records = v
	return s
}

type GetRecordsResponseBodyRecords struct {
	CreatedBy        *GetRecordsResponseBodyRecordsCreatedBy      `json:"createdBy,omitempty" xml:"createdBy,omitempty" type:"Struct"`
	CreatedTime      *int64                                       `json:"createdTime,omitempty" xml:"createdTime,omitempty"`
	Fields           map[string]interface{}                       `json:"fields,omitempty" xml:"fields,omitempty"`
	Id               *string                                      `json:"id,omitempty" xml:"id,omitempty"`
	LastModifiedBy   *GetRecordsResponseBodyRecordsLastModifiedBy `json:"lastModifiedBy,omitempty" xml:"lastModifiedBy,omitempty" type:"Struct"`
	LastModifiedTime *int64                                       `json:"lastModifiedTime,omitempty" xml:"lastModifiedTime,omitempty"`
}

func (s GetRecordsResponseBodyRecords) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsResponseBodyRecords) GoString() string {
	return s.String()
}

func (s *GetRecordsResponseBodyRecords) SetCreatedBy(v *GetRecordsResponseBodyRecordsCreatedBy) *GetRecordsResponseBodyRecords {
	s.CreatedBy = v
	return s
}

func (s *GetRecordsResponseBodyRecords) SetCreatedTime(v int64) *GetRecordsResponseBodyRecords {
	s.CreatedTime = &v
	return s
}

func (s *GetRecordsResponseBodyRecords) SetFields(v map[string]interface{}) *GetRecordsResponseBodyRecords {
	s.Fields = v
	return s
}

func (s *GetRecordsResponseBodyRecords) SetId(v string) *GetRecordsResponseBodyRecords {
	s.Id = &v
	return s
}

func (s *GetRecordsResponseBodyRecords) SetLastModifiedBy(v *GetRecordsResponseBodyRecordsLastModifiedBy) *GetRecordsResponseBodyRecords {
	s.LastModifiedBy = v
	return s
}

func (s *GetRecordsResponseBodyRecords) SetLastModifiedTime(v int64) *GetRecordsResponseBodyRecords {
	s.LastModifiedTime = &v
	return s
}

type GetRecordsResponseBodyRecordsCreatedBy struct {
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s GetRecordsResponseBodyRecordsCreatedBy) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsResponseBodyRecordsCreatedBy) GoString() string {
	return s.String()
}

func (s *GetRecordsResponseBodyRecordsCreatedBy) SetUnionId(v string) *GetRecordsResponseBodyRecordsCreatedBy {
	s.UnionId = &v
	return s
}

type GetRecordsResponseBodyRecordsLastModifiedBy struct {
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s GetRecordsResponseBodyRecordsLastModifiedBy) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsResponseBodyRecordsLastModifiedBy) GoString() string {
	return s.String()
}

func (s *GetRecordsResponseBodyRecordsLastModifiedBy) SetUnionId(v string) *GetRecordsResponseBodyRecordsLastModifiedBy {
	s.UnionId = &v
	return s
}

type GetRecordsResponse struct {
	Headers    map[string]*string      `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                  `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetRecordsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetRecordsResponse) String() string {
	return tea.Prettify(s)
}

func (s GetRecordsResponse) GoString() string {
	return s.String()
}

func (s *GetRecordsResponse) SetHeaders(v map[string]*string) *GetRecordsResponse {
	s.Headers = v
	return s
}

func (s *GetRecordsResponse) SetStatusCode(v int32) *GetRecordsResponse {
	s.StatusCode = &v
	return s
}

func (s *GetRecordsResponse) SetBody(v *GetRecordsResponseBody) *GetRecordsResponse {
	s.Body = v
	return s
}

type GetSheetHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s GetSheetHeaders) String() string {
	return tea.Prettify(s)
}

func (s GetSheetHeaders) GoString() string {
	return s.String()
}

func (s *GetSheetHeaders) SetCommonHeaders(v map[string]*string) *GetSheetHeaders {
	s.CommonHeaders = v
	return s
}

func (s *GetSheetHeaders) SetXAcsDingtalkAccessToken(v string) *GetSheetHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type GetSheetRequest struct {
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s GetSheetRequest) String() string {
	return tea.Prettify(s)
}

func (s GetSheetRequest) GoString() string {
	return s.String()
}

func (s *GetSheetRequest) SetOperatorId(v string) *GetSheetRequest {
	s.OperatorId = &v
	return s
}

type GetSheetResponseBody struct {
	Id   *string `json:"id,omitempty" xml:"id,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s GetSheetResponseBody) String() string {
	return tea.Prettify(s)
}

func (s GetSheetResponseBody) GoString() string {
	return s.String()
}

func (s *GetSheetResponseBody) SetId(v string) *GetSheetResponseBody {
	s.Id = &v
	return s
}

func (s *GetSheetResponseBody) SetName(v string) *GetSheetResponseBody {
	s.Name = &v
	return s
}

type GetSheetResponse struct {
	Headers    map[string]*string    `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *GetSheetResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s GetSheetResponse) String() string {
	return tea.Prettify(s)
}

func (s GetSheetResponse) GoString() string {
	return s.String()
}

func (s *GetSheetResponse) SetHeaders(v map[string]*string) *GetSheetResponse {
	s.Headers = v
	return s
}

func (s *GetSheetResponse) SetStatusCode(v int32) *GetSheetResponse {
	s.StatusCode = &v
	return s
}

func (s *GetSheetResponse) SetBody(v *GetSheetResponseBody) *GetSheetResponse {
	s.Body = v
	return s
}

type InsertRecordsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s InsertRecordsHeaders) String() string {
	return tea.Prettify(s)
}

func (s InsertRecordsHeaders) GoString() string {
	return s.String()
}

func (s *InsertRecordsHeaders) SetCommonHeaders(v map[string]*string) *InsertRecordsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *InsertRecordsHeaders) SetXAcsDingtalkAccessToken(v string) *InsertRecordsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type InsertRecordsRequest struct {
	// This parameter is required.
	Records []*InsertRecordsRequestRecords `json:"records,omitempty" xml:"records,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s InsertRecordsRequest) String() string {
	return tea.Prettify(s)
}

func (s InsertRecordsRequest) GoString() string {
	return s.String()
}

func (s *InsertRecordsRequest) SetRecords(v []*InsertRecordsRequestRecords) *InsertRecordsRequest {
	s.Records = v
	return s
}

func (s *InsertRecordsRequest) SetOperatorId(v string) *InsertRecordsRequest {
	s.OperatorId = &v
	return s
}

type InsertRecordsRequestRecords struct {
	// This parameter is required.
	Fields map[string]interface{} `json:"fields,omitempty" xml:"fields,omitempty"`
}

func (s InsertRecordsRequestRecords) String() string {
	return tea.Prettify(s)
}

func (s InsertRecordsRequestRecords) GoString() string {
	return s.String()
}

func (s *InsertRecordsRequestRecords) SetFields(v map[string]interface{}) *InsertRecordsRequestRecords {
	s.Fields = v
	return s
}

type InsertRecordsResponseBody struct {
	Value []*InsertRecordsResponseBodyValue `json:"value,omitempty" xml:"value,omitempty" type:"Repeated"`
}

func (s InsertRecordsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s InsertRecordsResponseBody) GoString() string {
	return s.String()
}

func (s *InsertRecordsResponseBody) SetValue(v []*InsertRecordsResponseBodyValue) *InsertRecordsResponseBody {
	s.Value = v
	return s
}

type InsertRecordsResponseBodyValue struct {
	Id *string `json:"id,omitempty" xml:"id,omitempty"`
}

func (s InsertRecordsResponseBodyValue) String() string {
	return tea.Prettify(s)
}

func (s InsertRecordsResponseBodyValue) GoString() string {
	return s.String()
}

func (s *InsertRecordsResponseBodyValue) SetId(v string) *InsertRecordsResponseBodyValue {
	s.Id = &v
	return s
}

type InsertRecordsResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *InsertRecordsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s InsertRecordsResponse) String() string {
	return tea.Prettify(s)
}

func (s InsertRecordsResponse) GoString() string {
	return s.String()
}

func (s *InsertRecordsResponse) SetHeaders(v map[string]*string) *InsertRecordsResponse {
	s.Headers = v
	return s
}

func (s *InsertRecordsResponse) SetStatusCode(v int32) *InsertRecordsResponse {
	s.StatusCode = &v
	return s
}

func (s *InsertRecordsResponse) SetBody(v *InsertRecordsResponseBody) *InsertRecordsResponse {
	s.Body = v
	return s
}

type ListRecordsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s ListRecordsHeaders) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsHeaders) GoString() string {
	return s.String()
}

func (s *ListRecordsHeaders) SetCommonHeaders(v map[string]*string) *ListRecordsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *ListRecordsHeaders) SetXAcsDingtalkAccessToken(v string) *ListRecordsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type ListRecordsRequest struct {
	Filter     *ListRecordsRequestFilter `json:"filter,omitempty" xml:"filter,omitempty" type:"Struct"`
	MaxResults *int32                    `json:"maxResults,omitempty" xml:"maxResults,omitempty"`
	NextToken  *string                   `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s ListRecordsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsRequest) GoString() string {
	return s.String()
}

func (s *ListRecordsRequest) SetFilter(v *ListRecordsRequestFilter) *ListRecordsRequest {
	s.Filter = v
	return s
}

func (s *ListRecordsRequest) SetMaxResults(v int32) *ListRecordsRequest {
	s.MaxResults = &v
	return s
}

func (s *ListRecordsRequest) SetNextToken(v string) *ListRecordsRequest {
	s.NextToken = &v
	return s
}

func (s *ListRecordsRequest) SetOperatorId(v string) *ListRecordsRequest {
	s.OperatorId = &v
	return s
}

type ListRecordsRequestFilter struct {
	Combination *string `json:"combination,omitempty" xml:"combination,omitempty"`
	// This parameter is required.
	Conditions []*ListRecordsRequestFilterConditions `json:"conditions,omitempty" xml:"conditions,omitempty" type:"Repeated"`
}

func (s ListRecordsRequestFilter) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsRequestFilter) GoString() string {
	return s.String()
}

func (s *ListRecordsRequestFilter) SetCombination(v string) *ListRecordsRequestFilter {
	s.Combination = &v
	return s
}

func (s *ListRecordsRequestFilter) SetConditions(v []*ListRecordsRequestFilterConditions) *ListRecordsRequestFilter {
	s.Conditions = v
	return s
}

type ListRecordsRequestFilterConditions struct {
	// This parameter is required.
	Field *string `json:"field,omitempty" xml:"field,omitempty"`
	// This parameter is required.
	Operator *string       `json:"operator,omitempty" xml:"operator,omitempty"`
	Value    []interface{} `json:"value,omitempty" xml:"value,omitempty" type:"Repeated"`
}

func (s ListRecordsRequestFilterConditions) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsRequestFilterConditions) GoString() string {
	return s.String()
}

func (s *ListRecordsRequestFilterConditions) SetField(v string) *ListRecordsRequestFilterConditions {
	s.Field = &v
	return s
}

func (s *ListRecordsRequestFilterConditions) SetOperator(v string) *ListRecordsRequestFilterConditions {
	s.Operator = &v
	return s
}

func (s *ListRecordsRequestFilterConditions) SetValue(v []interface{}) *ListRecordsRequestFilterConditions {
	s.Value = v
	return s
}

type ListRecordsResponseBody struct {
	// example:
	//
	// true
	HasMore *bool `json:"hasMore,omitempty" xml:"hasMore,omitempty"`
	// example:
	//
	// nextToken
	NextToken *string                           `json:"nextToken,omitempty" xml:"nextToken,omitempty"`
	Records   []*ListRecordsResponseBodyRecords `json:"records,omitempty" xml:"records,omitempty" type:"Repeated"`
}

func (s ListRecordsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsResponseBody) GoString() string {
	return s.String()
}

func (s *ListRecordsResponseBody) SetHasMore(v bool) *ListRecordsResponseBody {
	s.HasMore = &v
	return s
}

func (s *ListRecordsResponseBody) SetNextToken(v string) *ListRecordsResponseBody {
	s.NextToken = &v
	return s
}

func (s *ListRecordsResponseBody) SetRecords(v []*ListRecordsResponseBodyRecords) *ListRecordsResponseBody {
	s.Records = v
	return s
}

type ListRecordsResponseBodyRecords struct {
	CreatedBy        *ListRecordsResponseBodyRecordsCreatedBy      `json:"createdBy,omitempty" xml:"createdBy,omitempty" type:"Struct"`
	CreatedTime      *int64                                        `json:"createdTime,omitempty" xml:"createdTime,omitempty"`
	Fields           map[string]interface{}                        `json:"fields,omitempty" xml:"fields,omitempty"`
	Id               *string                                       `json:"id,omitempty" xml:"id,omitempty"`
	LastModifiedBy   *ListRecordsResponseBodyRecordsLastModifiedBy `json:"lastModifiedBy,omitempty" xml:"lastModifiedBy,omitempty" type:"Struct"`
	LastModifiedTime *int64                                        `json:"lastModifiedTime,omitempty" xml:"lastModifiedTime,omitempty"`
}

func (s ListRecordsResponseBodyRecords) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsResponseBodyRecords) GoString() string {
	return s.String()
}

func (s *ListRecordsResponseBodyRecords) SetCreatedBy(v *ListRecordsResponseBodyRecordsCreatedBy) *ListRecordsResponseBodyRecords {
	s.CreatedBy = v
	return s
}

func (s *ListRecordsResponseBodyRecords) SetCreatedTime(v int64) *ListRecordsResponseBodyRecords {
	s.CreatedTime = &v
	return s
}

func (s *ListRecordsResponseBodyRecords) SetFields(v map[string]interface{}) *ListRecordsResponseBodyRecords {
	s.Fields = v
	return s
}

func (s *ListRecordsResponseBodyRecords) SetId(v string) *ListRecordsResponseBodyRecords {
	s.Id = &v
	return s
}

func (s *ListRecordsResponseBodyRecords) SetLastModifiedBy(v *ListRecordsResponseBodyRecordsLastModifiedBy) *ListRecordsResponseBodyRecords {
	s.LastModifiedBy = v
	return s
}

func (s *ListRecordsResponseBodyRecords) SetLastModifiedTime(v int64) *ListRecordsResponseBodyRecords {
	s.LastModifiedTime = &v
	return s
}

type ListRecordsResponseBodyRecordsCreatedBy struct {
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s ListRecordsResponseBodyRecordsCreatedBy) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsResponseBodyRecordsCreatedBy) GoString() string {
	return s.String()
}

func (s *ListRecordsResponseBodyRecordsCreatedBy) SetUnionId(v string) *ListRecordsResponseBodyRecordsCreatedBy {
	s.UnionId = &v
	return s
}

type ListRecordsResponseBodyRecordsLastModifiedBy struct {
	UnionId *string `json:"unionId,omitempty" xml:"unionId,omitempty"`
}

func (s ListRecordsResponseBodyRecordsLastModifiedBy) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsResponseBodyRecordsLastModifiedBy) GoString() string {
	return s.String()
}

func (s *ListRecordsResponseBodyRecordsLastModifiedBy) SetUnionId(v string) *ListRecordsResponseBodyRecordsLastModifiedBy {
	s.UnionId = &v
	return s
}

type ListRecordsResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *ListRecordsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s ListRecordsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListRecordsResponse) GoString() string {
	return s.String()
}

func (s *ListRecordsResponse) SetHeaders(v map[string]*string) *ListRecordsResponse {
	s.Headers = v
	return s
}

func (s *ListRecordsResponse) SetStatusCode(v int32) *ListRecordsResponse {
	s.StatusCode = &v
	return s
}

func (s *ListRecordsResponse) SetBody(v *ListRecordsResponseBody) *ListRecordsResponse {
	s.Body = v
	return s
}

type PrepareSetRichTextHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s PrepareSetRichTextHeaders) String() string {
	return tea.Prettify(s)
}

func (s PrepareSetRichTextHeaders) GoString() string {
	return s.String()
}

func (s *PrepareSetRichTextHeaders) SetCommonHeaders(v map[string]*string) *PrepareSetRichTextHeaders {
	s.CommonHeaders = v
	return s
}

func (s *PrepareSetRichTextHeaders) SetXAcsDingtalkAccessToken(v string) *PrepareSetRichTextHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type PrepareSetRichTextRequest struct {
	Markdown *string `json:"markdown,omitempty" xml:"markdown,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s PrepareSetRichTextRequest) String() string {
	return tea.Prettify(s)
}

func (s PrepareSetRichTextRequest) GoString() string {
	return s.String()
}

func (s *PrepareSetRichTextRequest) SetMarkdown(v string) *PrepareSetRichTextRequest {
	s.Markdown = &v
	return s
}

func (s *PrepareSetRichTextRequest) SetOperatorId(v string) *PrepareSetRichTextRequest {
	s.OperatorId = &v
	return s
}

type PrepareSetRichTextResponseBody struct {
	Markdown    *string                                      `json:"markdown,omitempty" xml:"markdown,omitempty"`
	UploadInfos []*PrepareSetRichTextResponseBodyUploadInfos `json:"uploadInfos,omitempty" xml:"uploadInfos,omitempty" type:"Repeated"`
}

func (s PrepareSetRichTextResponseBody) String() string {
	return tea.Prettify(s)
}

func (s PrepareSetRichTextResponseBody) GoString() string {
	return s.String()
}

func (s *PrepareSetRichTextResponseBody) SetMarkdown(v string) *PrepareSetRichTextResponseBody {
	s.Markdown = &v
	return s
}

func (s *PrepareSetRichTextResponseBody) SetUploadInfos(v []*PrepareSetRichTextResponseBodyUploadInfos) *PrepareSetRichTextResponseBody {
	s.UploadInfos = v
	return s
}

type PrepareSetRichTextResponseBodyUploadInfos struct {
	ResourceId  *string `json:"resourceId,omitempty" xml:"resourceId,omitempty"`
	ResourceUrl *string `json:"resourceUrl,omitempty" xml:"resourceUrl,omitempty"`
	UploadUrl   *string `json:"uploadUrl,omitempty" xml:"uploadUrl,omitempty"`
}

func (s PrepareSetRichTextResponseBodyUploadInfos) String() string {
	return tea.Prettify(s)
}

func (s PrepareSetRichTextResponseBodyUploadInfos) GoString() string {
	return s.String()
}

func (s *PrepareSetRichTextResponseBodyUploadInfos) SetResourceId(v string) *PrepareSetRichTextResponseBodyUploadInfos {
	s.ResourceId = &v
	return s
}

func (s *PrepareSetRichTextResponseBodyUploadInfos) SetResourceUrl(v string) *PrepareSetRichTextResponseBodyUploadInfos {
	s.ResourceUrl = &v
	return s
}

func (s *PrepareSetRichTextResponseBodyUploadInfos) SetUploadUrl(v string) *PrepareSetRichTextResponseBodyUploadInfos {
	s.UploadUrl = &v
	return s
}

type PrepareSetRichTextResponse struct {
	Headers    map[string]*string              `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                          `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *PrepareSetRichTextResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s PrepareSetRichTextResponse) String() string {
	return tea.Prettify(s)
}

func (s PrepareSetRichTextResponse) GoString() string {
	return s.String()
}

func (s *PrepareSetRichTextResponse) SetHeaders(v map[string]*string) *PrepareSetRichTextResponse {
	s.Headers = v
	return s
}

func (s *PrepareSetRichTextResponse) SetStatusCode(v int32) *PrepareSetRichTextResponse {
	s.StatusCode = &v
	return s
}

func (s *PrepareSetRichTextResponse) SetBody(v *PrepareSetRichTextResponseBody) *PrepareSetRichTextResponse {
	s.Body = v
	return s
}

type UpdateFieldHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateFieldHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateFieldHeaders) GoString() string {
	return s.String()
}

func (s *UpdateFieldHeaders) SetCommonHeaders(v map[string]*string) *UpdateFieldHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateFieldHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateFieldHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateFieldRequest struct {
	// This parameter is required.
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// example:
	//
	// key: id或者name
	//
	//     value: 对应字段值,不同类型的字段传入的value值不同
	//
	//       - text: "TextString"          // 文本字符串
	//
	//       - number: 123                 // 整数/浮点数均可
	//
	//       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
	//
	//       - date: 1688601600000 ｜ "2023-12-20 03:00"
	//
	//                                     // 支持传时间戳或ISO 8601字符串
	//
	//       - user: [{
	//
	//           uid: \"1234567\"            // 用户uid
	//
	//         }, {
	//
	//           uid: \"2345678\"
	//
	//         }]
	Property map[string]interface{} `json:"property,omitempty" xml:"property,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s UpdateFieldRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateFieldRequest) GoString() string {
	return s.String()
}

func (s *UpdateFieldRequest) SetName(v string) *UpdateFieldRequest {
	s.Name = &v
	return s
}

func (s *UpdateFieldRequest) SetProperty(v map[string]interface{}) *UpdateFieldRequest {
	s.Property = v
	return s
}

func (s *UpdateFieldRequest) SetOperatorId(v string) *UpdateFieldRequest {
	s.OperatorId = &v
	return s
}

type UpdateFieldResponseBody struct {
	Id *string `json:"id,omitempty" xml:"id,omitempty"`
}

func (s UpdateFieldResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateFieldResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateFieldResponseBody) SetId(v string) *UpdateFieldResponseBody {
	s.Id = &v
	return s
}

type UpdateFieldResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateFieldResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateFieldResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateFieldResponse) GoString() string {
	return s.String()
}

func (s *UpdateFieldResponse) SetHeaders(v map[string]*string) *UpdateFieldResponse {
	s.Headers = v
	return s
}

func (s *UpdateFieldResponse) SetStatusCode(v int32) *UpdateFieldResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateFieldResponse) SetBody(v *UpdateFieldResponseBody) *UpdateFieldResponse {
	s.Body = v
	return s
}

type UpdateRecordsHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateRecordsHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateRecordsHeaders) GoString() string {
	return s.String()
}

func (s *UpdateRecordsHeaders) SetCommonHeaders(v map[string]*string) *UpdateRecordsHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateRecordsHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateRecordsHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateRecordsRequest struct {
	// This parameter is required.
	Records []*UpdateRecordsRequestRecords `json:"records,omitempty" xml:"records,omitempty" type:"Repeated"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s UpdateRecordsRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateRecordsRequest) GoString() string {
	return s.String()
}

func (s *UpdateRecordsRequest) SetRecords(v []*UpdateRecordsRequestRecords) *UpdateRecordsRequest {
	s.Records = v
	return s
}

func (s *UpdateRecordsRequest) SetOperatorId(v string) *UpdateRecordsRequest {
	s.OperatorId = &v
	return s
}

type UpdateRecordsRequestRecords struct {
	// This parameter is required.
	Fields map[string]interface{} `json:"fields,omitempty" xml:"fields,omitempty"`
	// This parameter is required.
	Id *string `json:"id,omitempty" xml:"id,omitempty"`
}

func (s UpdateRecordsRequestRecords) String() string {
	return tea.Prettify(s)
}

func (s UpdateRecordsRequestRecords) GoString() string {
	return s.String()
}

func (s *UpdateRecordsRequestRecords) SetFields(v map[string]interface{}) *UpdateRecordsRequestRecords {
	s.Fields = v
	return s
}

func (s *UpdateRecordsRequestRecords) SetId(v string) *UpdateRecordsRequestRecords {
	s.Id = &v
	return s
}

type UpdateRecordsResponseBody struct {
	Value []*UpdateRecordsResponseBodyValue `json:"value,omitempty" xml:"value,omitempty" type:"Repeated"`
}

func (s UpdateRecordsResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateRecordsResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateRecordsResponseBody) SetValue(v []*UpdateRecordsResponseBodyValue) *UpdateRecordsResponseBody {
	s.Value = v
	return s
}

type UpdateRecordsResponseBodyValue struct {
	Id *string `json:"id,omitempty" xml:"id,omitempty"`
}

func (s UpdateRecordsResponseBodyValue) String() string {
	return tea.Prettify(s)
}

func (s UpdateRecordsResponseBodyValue) GoString() string {
	return s.String()
}

func (s *UpdateRecordsResponseBodyValue) SetId(v string) *UpdateRecordsResponseBodyValue {
	s.Id = &v
	return s
}

type UpdateRecordsResponse struct {
	Headers    map[string]*string         `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                     `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateRecordsResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateRecordsResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateRecordsResponse) GoString() string {
	return s.String()
}

func (s *UpdateRecordsResponse) SetHeaders(v map[string]*string) *UpdateRecordsResponse {
	s.Headers = v
	return s
}

func (s *UpdateRecordsResponse) SetStatusCode(v int32) *UpdateRecordsResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateRecordsResponse) SetBody(v *UpdateRecordsResponseBody) *UpdateRecordsResponse {
	s.Body = v
	return s
}

type UpdateSheetHeaders struct {
	CommonHeaders           map[string]*string `json:"commonHeaders,omitempty" xml:"commonHeaders,omitempty"`
	XAcsDingtalkAccessToken *string            `json:"x-acs-dingtalk-access-token,omitempty" xml:"x-acs-dingtalk-access-token,omitempty"`
}

func (s UpdateSheetHeaders) String() string {
	return tea.Prettify(s)
}

func (s UpdateSheetHeaders) GoString() string {
	return s.String()
}

func (s *UpdateSheetHeaders) SetCommonHeaders(v map[string]*string) *UpdateSheetHeaders {
	s.CommonHeaders = v
	return s
}

func (s *UpdateSheetHeaders) SetXAcsDingtalkAccessToken(v string) *UpdateSheetHeaders {
	s.XAcsDingtalkAccessToken = &v
	return s
}

type UpdateSheetRequest struct {
	// This parameter is required.
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
	// This parameter is required.
	//
	// example:
	//
	// union_id
	OperatorId *string `json:"operatorId,omitempty" xml:"operatorId,omitempty"`
}

func (s UpdateSheetRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateSheetRequest) GoString() string {
	return s.String()
}

func (s *UpdateSheetRequest) SetName(v string) *UpdateSheetRequest {
	s.Name = &v
	return s
}

func (s *UpdateSheetRequest) SetOperatorId(v string) *UpdateSheetRequest {
	s.OperatorId = &v
	return s
}

type UpdateSheetResponseBody struct {
	Id   *string `json:"id,omitempty" xml:"id,omitempty"`
	Name *string `json:"name,omitempty" xml:"name,omitempty"`
}

func (s UpdateSheetResponseBody) String() string {
	return tea.Prettify(s)
}

func (s UpdateSheetResponseBody) GoString() string {
	return s.String()
}

func (s *UpdateSheetResponseBody) SetId(v string) *UpdateSheetResponseBody {
	s.Id = &v
	return s
}

func (s *UpdateSheetResponseBody) SetName(v string) *UpdateSheetResponseBody {
	s.Name = &v
	return s
}

type UpdateSheetResponse struct {
	Headers    map[string]*string       `json:"headers,omitempty" xml:"headers,omitempty"`
	StatusCode *int32                   `json:"statusCode,omitempty" xml:"statusCode,omitempty"`
	Body       *UpdateSheetResponseBody `json:"body,omitempty" xml:"body,omitempty"`
}

func (s UpdateSheetResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateSheetResponse) GoString() string {
	return s.String()
}

func (s *UpdateSheetResponse) SetHeaders(v map[string]*string) *UpdateSheetResponse {
	s.Headers = v
	return s
}

func (s *UpdateSheetResponse) SetStatusCode(v int32) *UpdateSheetResponse {
	s.StatusCode = &v
	return s
}

func (s *UpdateSheetResponse) SetBody(v *UpdateSheetResponseBody) *UpdateSheetResponse {
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
// 新增数据表字段
//
// @param request - CreateFieldRequest
//
// @param headers - CreateFieldHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CreateFieldResponse
func (client *Client) CreateFieldWithOptions(baseId *string, sheetIdOrName *string, request *CreateFieldRequest, headers *CreateFieldHeaders, runtime *util.RuntimeOptions) (_result *CreateFieldResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Name)) {
		body["name"] = request.Name
	}

	if !tea.BoolValue(util.IsUnset(request.Property)) {
		body["property"] = request.Property
	}

	if !tea.BoolValue(util.IsUnset(request.Type)) {
		body["type"] = request.Type
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("CreateField"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/fields"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CreateFieldResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 新增数据表字段
//
// @param request - CreateFieldRequest
//
// @return CreateFieldResponse
func (client *Client) CreateField(baseId *string, sheetIdOrName *string, request *CreateFieldRequest) (_result *CreateFieldResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CreateFieldHeaders{}
	_result = &CreateFieldResponse{}
	_body, _err := client.CreateFieldWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 创建数据表
//
// @param request - CreateSheetRequest
//
// @param headers - CreateSheetHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return CreateSheetResponse
func (client *Client) CreateSheetWithOptions(baseId *string, request *CreateSheetRequest, headers *CreateSheetHeaders, runtime *util.RuntimeOptions) (_result *CreateSheetResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Fields)) {
		body["fields"] = request.Fields
	}

	if !tea.BoolValue(util.IsUnset(request.Name)) {
		body["name"] = request.Name
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("CreateSheet"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &CreateSheetResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 创建数据表
//
// @param request - CreateSheetRequest
//
// @return CreateSheetResponse
func (client *Client) CreateSheet(baseId *string, request *CreateSheetRequest) (_result *CreateSheetResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &CreateSheetHeaders{}
	_result = &CreateSheetResponse{}
	_body, _err := client.CreateSheetWithOptions(baseId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 删除数据表字段
//
// @param request - DeleteFieldRequest
//
// @param headers - DeleteFieldHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return DeleteFieldResponse
func (client *Client) DeleteFieldWithOptions(baseId *string, sheetIdOrName *string, fieldIdOrName *string, request *DeleteFieldRequest, headers *DeleteFieldHeaders, runtime *util.RuntimeOptions) (_result *DeleteFieldResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("DeleteField"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/fields/" + tea.StringValue(fieldIdOrName)),
		Method:      tea.String("DELETE"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &DeleteFieldResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 删除数据表字段
//
// @param request - DeleteFieldRequest
//
// @return DeleteFieldResponse
func (client *Client) DeleteField(baseId *string, sheetIdOrName *string, fieldIdOrName *string, request *DeleteFieldRequest) (_result *DeleteFieldResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DeleteFieldHeaders{}
	_result = &DeleteFieldResponse{}
	_body, _err := client.DeleteFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 删除数据表多行记录
//
// @param request - DeleteRecordsRequest
//
// @param headers - DeleteRecordsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return DeleteRecordsResponse
func (client *Client) DeleteRecordsWithOptions(baseId *string, sheetIdOrName *string, request *DeleteRecordsRequest, headers *DeleteRecordsHeaders, runtime *util.RuntimeOptions) (_result *DeleteRecordsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.RecordIds)) {
		body["recordIds"] = request.RecordIds
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("DeleteRecords"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/records/delete"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &DeleteRecordsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 删除数据表多行记录
//
// @param request - DeleteRecordsRequest
//
// @return DeleteRecordsResponse
func (client *Client) DeleteRecords(baseId *string, sheetIdOrName *string, request *DeleteRecordsRequest) (_result *DeleteRecordsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DeleteRecordsHeaders{}
	_result = &DeleteRecordsResponse{}
	_body, _err := client.DeleteRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 删除数据表
//
// @param request - DeleteSheetRequest
//
// @param headers - DeleteSheetHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return DeleteSheetResponse
func (client *Client) DeleteSheetWithOptions(baseId *string, sheetIdOrName *string, request *DeleteSheetRequest, headers *DeleteSheetHeaders, runtime *util.RuntimeOptions) (_result *DeleteSheetResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("DeleteSheet"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName)),
		Method:      tea.String("DELETE"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &DeleteSheetResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 删除数据表
//
// @param request - DeleteSheetRequest
//
// @return DeleteSheetResponse
func (client *Client) DeleteSheet(baseId *string, sheetIdOrName *string, request *DeleteSheetRequest) (_result *DeleteSheetResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &DeleteSheetHeaders{}
	_result = &DeleteSheetResponse{}
	_body, _err := client.DeleteSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取所有字段
//
// @param request - GetAllFieldsRequest
//
// @param headers - GetAllFieldsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetAllFieldsResponse
func (client *Client) GetAllFieldsWithOptions(baseId *string, sheetIdOrName *string, request *GetAllFieldsRequest, headers *GetAllFieldsHeaders, runtime *util.RuntimeOptions) (_result *GetAllFieldsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("GetAllFields"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/fields"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetAllFieldsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取所有字段
//
// @param request - GetAllFieldsRequest
//
// @return GetAllFieldsResponse
func (client *Client) GetAllFields(baseId *string, sheetIdOrName *string, request *GetAllFieldsRequest) (_result *GetAllFieldsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetAllFieldsHeaders{}
	_result = &GetAllFieldsResponse{}
	_body, _err := client.GetAllFieldsWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取所有数据表
//
// @param request - GetAllSheetsRequest
//
// @param headers - GetAllSheetsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetAllSheetsResponse
func (client *Client) GetAllSheetsWithOptions(baseId *string, request *GetAllSheetsRequest, headers *GetAllSheetsHeaders, runtime *util.RuntimeOptions) (_result *GetAllSheetsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("GetAllSheets"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetAllSheetsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取所有数据表
//
// @param request - GetAllSheetsRequest
//
// @return GetAllSheetsResponse
func (client *Client) GetAllSheets(baseId *string, request *GetAllSheetsRequest) (_result *GetAllSheetsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetAllSheetsHeaders{}
	_result = &GetAllSheetsResponse{}
	_body, _err := client.GetAllSheetsWithOptions(baseId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取记录
//
// @param request - GetRecordRequest
//
// @param headers - GetRecordHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetRecordResponse
func (client *Client) GetRecordWithOptions(baseId *string, sheetIdOrName *string, recordId *string, request *GetRecordRequest, headers *GetRecordHeaders, runtime *util.RuntimeOptions) (_result *GetRecordResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("GetRecord"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/records/" + tea.StringValue(recordId)),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetRecordResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取记录
//
// @param request - GetRecordRequest
//
// @return GetRecordResponse
func (client *Client) GetRecord(baseId *string, sheetIdOrName *string, recordId *string, request *GetRecordRequest) (_result *GetRecordResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetRecordHeaders{}
	_result = &GetRecordResponse{}
	_body, _err := client.GetRecordWithOptions(baseId, sheetIdOrName, recordId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取多行记录
//
// @param request - GetRecordsRequest
//
// @param headers - GetRecordsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetRecordsResponse
func (client *Client) GetRecordsWithOptions(baseId *string, sheetIdOrName *string, request *GetRecordsRequest, headers *GetRecordsHeaders, runtime *util.RuntimeOptions) (_result *GetRecordsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		query["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		query["nextToken"] = request.NextToken
	}

	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("GetRecords"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/records"),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetRecordsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取多行记录
//
// @param request - GetRecordsRequest
//
// @return GetRecordsResponse
func (client *Client) GetRecords(baseId *string, sheetIdOrName *string, request *GetRecordsRequest) (_result *GetRecordsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetRecordsHeaders{}
	_result = &GetRecordsResponse{}
	_body, _err := client.GetRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 获取数据表
//
// @param request - GetSheetRequest
//
// @param headers - GetSheetHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return GetSheetResponse
func (client *Client) GetSheetWithOptions(baseId *string, sheetIdOrName *string, request *GetSheetRequest, headers *GetSheetHeaders, runtime *util.RuntimeOptions) (_result *GetSheetResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
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
		Action:      tea.String("GetSheet"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName)),
		Method:      tea.String("GET"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &GetSheetResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 获取数据表
//
// @param request - GetSheetRequest
//
// @return GetSheetResponse
func (client *Client) GetSheet(baseId *string, sheetIdOrName *string, request *GetSheetRequest) (_result *GetSheetResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &GetSheetHeaders{}
	_result = &GetSheetResponse{}
	_body, _err := client.GetSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 新增记录
//
// @param request - InsertRecordsRequest
//
// @param headers - InsertRecordsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return InsertRecordsResponse
func (client *Client) InsertRecordsWithOptions(baseId *string, sheetIdOrName *string, request *InsertRecordsRequest, headers *InsertRecordsHeaders, runtime *util.RuntimeOptions) (_result *InsertRecordsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Records)) {
		body["records"] = request.Records
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("InsertRecords"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/records"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &InsertRecordsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 新增记录
//
// @param request - InsertRecordsRequest
//
// @return InsertRecordsResponse
func (client *Client) InsertRecords(baseId *string, sheetIdOrName *string, request *InsertRecordsRequest) (_result *InsertRecordsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &InsertRecordsHeaders{}
	_result = &InsertRecordsResponse{}
	_body, _err := client.InsertRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 列出多行记录
//
// @param request - ListRecordsRequest
//
// @param headers - ListRecordsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return ListRecordsResponse
func (client *Client) ListRecordsWithOptions(baseId *string, sheetIdOrName *string, request *ListRecordsRequest, headers *ListRecordsHeaders, runtime *util.RuntimeOptions) (_result *ListRecordsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Filter)) {
		body["filter"] = request.Filter
	}

	if !tea.BoolValue(util.IsUnset(request.MaxResults)) {
		body["maxResults"] = request.MaxResults
	}

	if !tea.BoolValue(util.IsUnset(request.NextToken)) {
		body["nextToken"] = request.NextToken
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("ListRecords"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/records/list"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &ListRecordsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 列出多行记录
//
// @param request - ListRecordsRequest
//
// @return ListRecordsResponse
func (client *Client) ListRecords(baseId *string, sheetIdOrName *string, request *ListRecordsRequest) (_result *ListRecordsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &ListRecordsHeaders{}
	_result = &ListRecordsResponse{}
	_body, _err := client.ListRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 富文本值预处理
//
// @param request - PrepareSetRichTextRequest
//
// @param headers - PrepareSetRichTextHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return PrepareSetRichTextResponse
func (client *Client) PrepareSetRichTextWithOptions(baseId *string, request *PrepareSetRichTextRequest, headers *PrepareSetRichTextHeaders, runtime *util.RuntimeOptions) (_result *PrepareSetRichTextResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Markdown)) {
		body["markdown"] = request.Markdown
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("PrepareSetRichText"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/prepareSetRichText"),
		Method:      tea.String("POST"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &PrepareSetRichTextResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 富文本值预处理
//
// @param request - PrepareSetRichTextRequest
//
// @return PrepareSetRichTextResponse
func (client *Client) PrepareSetRichText(baseId *string, request *PrepareSetRichTextRequest) (_result *PrepareSetRichTextResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &PrepareSetRichTextHeaders{}
	_result = &PrepareSetRichTextResponse{}
	_body, _err := client.PrepareSetRichTextWithOptions(baseId, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新数据表字段
//
// @param request - UpdateFieldRequest
//
// @param headers - UpdateFieldHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateFieldResponse
func (client *Client) UpdateFieldWithOptions(baseId *string, sheetIdOrName *string, fieldIdOrName *string, request *UpdateFieldRequest, headers *UpdateFieldHeaders, runtime *util.RuntimeOptions) (_result *UpdateFieldResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Name)) {
		body["name"] = request.Name
	}

	if !tea.BoolValue(util.IsUnset(request.Property)) {
		body["property"] = request.Property
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateField"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/fields/" + tea.StringValue(fieldIdOrName)),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateFieldResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新数据表字段
//
// @param request - UpdateFieldRequest
//
// @return UpdateFieldResponse
func (client *Client) UpdateField(baseId *string, sheetIdOrName *string, fieldIdOrName *string, request *UpdateFieldRequest) (_result *UpdateFieldResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateFieldHeaders{}
	_result = &UpdateFieldResponse{}
	_body, _err := client.UpdateFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新数据表多行记录
//
// @param request - UpdateRecordsRequest
//
// @param headers - UpdateRecordsHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateRecordsResponse
func (client *Client) UpdateRecordsWithOptions(baseId *string, sheetIdOrName *string, request *UpdateRecordsRequest, headers *UpdateRecordsHeaders, runtime *util.RuntimeOptions) (_result *UpdateRecordsResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Records)) {
		body["records"] = request.Records
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateRecords"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName) + "/records"),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateRecordsResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新数据表多行记录
//
// @param request - UpdateRecordsRequest
//
// @return UpdateRecordsResponse
func (client *Client) UpdateRecords(baseId *string, sheetIdOrName *string, request *UpdateRecordsRequest) (_result *UpdateRecordsResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateRecordsHeaders{}
	_result = &UpdateRecordsResponse{}
	_body, _err := client.UpdateRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}

// Summary:
//
// 更新数据表
//
// @param request - UpdateSheetRequest
//
// @param headers - UpdateSheetHeaders
//
// @param runtime - runtime options for this request RuntimeOptions
//
// @return UpdateSheetResponse
func (client *Client) UpdateSheetWithOptions(baseId *string, sheetIdOrName *string, request *UpdateSheetRequest, headers *UpdateSheetHeaders, runtime *util.RuntimeOptions) (_result *UpdateSheetResponse, _err error) {
	_err = util.ValidateModel(request)
	if _err != nil {
		return _result, _err
	}
	query := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.OperatorId)) {
		query["operatorId"] = request.OperatorId
	}

	body := map[string]interface{}{}
	if !tea.BoolValue(util.IsUnset(request.Name)) {
		body["name"] = request.Name
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
		Body:    openapiutil.ParseToMap(body),
	}
	params := &openapi.Params{
		Action:      tea.String("UpdateSheet"),
		Version:     tea.String("notable_1.0"),
		Protocol:    tea.String("HTTP"),
		Pathname:    tea.String("/v1.0/notable/bases/" + tea.StringValue(baseId) + "/sheets/" + tea.StringValue(sheetIdOrName)),
		Method:      tea.String("PUT"),
		AuthType:    tea.String("AK"),
		Style:       tea.String("ROA"),
		ReqBodyType: tea.String("none"),
		BodyType:    tea.String("json"),
	}
	_result = &UpdateSheetResponse{}
	_body, _err := client.Execute(params, req, runtime)
	if _err != nil {
		return _result, _err
	}
	_err = tea.Convert(_body, &_result)
	return _result, _err
}

// Summary:
//
// 更新数据表
//
// @param request - UpdateSheetRequest
//
// @return UpdateSheetResponse
func (client *Client) UpdateSheet(baseId *string, sheetIdOrName *string, request *UpdateSheetRequest) (_result *UpdateSheetResponse, _err error) {
	runtime := &util.RuntimeOptions{}
	headers := &UpdateSheetHeaders{}
	_result = &UpdateSheetResponse{}
	_body, _err := client.UpdateSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime)
	if _err != nil {
		return _result, _err
	}
	_result = _body
	return _result, _err
}
