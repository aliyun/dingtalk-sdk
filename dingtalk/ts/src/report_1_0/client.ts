// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class UserMapValue extends $tea.Model {
  userId?: string;
  name?: string;
  deptId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      deptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequest extends $tea.Model {
  allowAddReceivers?: boolean;
  allowEdit?: boolean;
  allowGetLocation?: boolean;
  authDeptIds?: string[];
  authUserIds?: string[];
  creator?: string;
  defaultReceivedCids?: string[];
  defaultReceivedMasterLevels?: string[];
  defaultReceivers?: string[];
  fields?: CreateTemplatesRequestFields[];
  logo?: string;
  maxWordCount?: number;
  minWordCount?: number;
  name?: string;
  templateManagers?: string[];
  static names(): { [key: string]: string } {
    return {
      allowAddReceivers: 'allowAddReceivers',
      allowEdit: 'allowEdit',
      allowGetLocation: 'allowGetLocation',
      authDeptIds: 'authDeptIds',
      authUserIds: 'authUserIds',
      creator: 'creator',
      defaultReceivedCids: 'defaultReceivedCids',
      defaultReceivedMasterLevels: 'defaultReceivedMasterLevels',
      defaultReceivers: 'defaultReceivers',
      fields: 'fields',
      logo: 'logo',
      maxWordCount: 'maxWordCount',
      minWordCount: 'minWordCount',
      name: 'name',
      templateManagers: 'templateManagers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowAddReceivers: 'boolean',
      allowEdit: 'boolean',
      allowGetLocation: 'boolean',
      authDeptIds: { 'type': 'array', 'itemType': 'string' },
      authUserIds: { 'type': 'array', 'itemType': 'string' },
      creator: 'string',
      defaultReceivedCids: { 'type': 'array', 'itemType': 'string' },
      defaultReceivedMasterLevels: { 'type': 'array', 'itemType': 'string' },
      defaultReceivers: { 'type': 'array', 'itemType': 'string' },
      fields: { 'type': 'array', 'itemType': CreateTemplatesRequestFields },
      logo: 'string',
      maxWordCount: 'number',
      minWordCount: 'number',
      name: 'string',
      templateManagers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesResponseBody extends $tea.Model {
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateTemplatesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSendAndReceiveReportListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSendAndReceiveReportListRequest extends $tea.Model {
  endTime?: number;
  maxResults?: number;
  nextToken?: number;
  operationUserId?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operationUserId: 'operationUserId',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      operationUserId: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSendAndReceiveReportListResponseBody extends $tea.Model {
  dataList?: GetSendAndReceiveReportListResponseBodyDataList[];
  hasMore?: boolean;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': GetSendAndReceiveReportListResponseBodyDataList },
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSendAndReceiveReportListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSendAndReceiveReportListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSendAndReceiveReportListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubmitStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubmitStatisticsRequest extends $tea.Model {
  endTime?: number;
  operationUserId?: string;
  remindId?: number;
  startTime?: number;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      operationUserId: 'operationUserId',
      remindId: 'remindId',
      startTime: 'startTime',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      operationUserId: 'string',
      remindId: 'number',
      startTime: 'number',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubmitStatisticsResponseBody extends $tea.Model {
  shouldRemindTimes?: number;
  templateName?: string;
  userDeptMap?: { [key: string]: string };
  userIdCountMap?: { [key: string]: number };
  userIdStatusMap?: { [key: string]: {[key: string]: any} };
  userIds?: string[];
  userMap?: { [key: string]: UserMapValue };
  static names(): { [key: string]: string } {
    return {
      shouldRemindTimes: 'shouldRemindTimes',
      templateName: 'templateName',
      userDeptMap: 'userDeptMap',
      userIdCountMap: 'userIdCountMap',
      userIdStatusMap: 'userIdStatusMap',
      userIds: 'userIds',
      userMap: 'userMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shouldRemindTimes: 'number',
      templateName: 'string',
      userDeptMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      userIdCountMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'number' },
      userIdStatusMap: { 'type': 'map', 'keyType': 'string', 'valueType': '{[key: string]: any}' },
      userIds: { 'type': 'array', 'itemType': 'string' },
      userMap: { 'type': 'map', 'keyType': 'string', 'valueType': UserMapValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubmitStatisticsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSubmitStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSubmitStatisticsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemindResultsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemindResultsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  operationUserId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operationUserId: 'operationUserId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      operationUserId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemindResultsResponseBody extends $tea.Model {
  dataList?: QueryRemindResultsResponseBodyDataList[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': QueryRemindResultsResponseBodyDataList },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemindResultsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRemindResultsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryRemindResultsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportDetailRequest extends $tea.Model {
  reportId?: string;
  static names(): { [key: string]: string } {
    return {
      reportId: 'reportId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reportId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportDetailResponseBody extends $tea.Model {
  content?: QueryReportDetailResponseBodyContent[];
  createTime?: number;
  creatorId?: string;
  creatorName?: string;
  deptName?: string;
  modifiedTime?: number;
  remark?: string;
  reportId?: string;
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      createTime: 'createTime',
      creatorId: 'creatorId',
      creatorName: 'creatorName',
      deptName: 'deptName',
      modifiedTime: 'modifiedTime',
      remark: 'remark',
      reportId: 'reportId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryReportDetailResponseBodyContent },
      createTime: 'number',
      creatorId: 'string',
      creatorName: 'string',
      deptName: 'string',
      modifiedTime: 'number',
      remark: 'string',
      reportId: 'string',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryReportDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryReportDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequestFieldsDataValueOpenInfo extends $tea.Model {
  attribute?: { [key: string]: string };
  openId?: string;
  static names(): { [key: string]: string } {
    return {
      attribute: 'attribute',
      openId: 'openId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attribute: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      openId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequestFieldsDataValue extends $tea.Model {
  openInfo?: CreateTemplatesRequestFieldsDataValueOpenInfo;
  options?: string[];
  placeholder?: string;
  static names(): { [key: string]: string } {
    return {
      openInfo: 'openInfo',
      options: 'options',
      placeholder: 'placeholder',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openInfo: CreateTemplatesRequestFieldsDataValueOpenInfo,
      options: { 'type': 'array', 'itemType': 'string' },
      placeholder: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequestFields extends $tea.Model {
  dataType?: number;
  dataValue?: CreateTemplatesRequestFieldsDataValue;
  fieldName?: string;
  need?: boolean;
  order?: number;
  sort?: number;
  static names(): { [key: string]: string } {
    return {
      dataType: 'dataType',
      dataValue: 'dataValue',
      fieldName: 'fieldName',
      need: 'need',
      order: 'order',
      sort: 'sort',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataType: 'number',
      dataValue: CreateTemplatesRequestFieldsDataValue,
      fieldName: 'string',
      need: 'boolean',
      order: 'number',
      sort: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSendAndReceiveReportListResponseBodyDataList extends $tea.Model {
  createTime?: number;
  creatorId?: string;
  creatorName?: string;
  modifiedTime?: number;
  reportId?: string;
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      creatorId: 'creatorId',
      creatorName: 'creatorName',
      modifiedTime: 'modifiedTime',
      reportId: 'reportId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      creatorId: 'string',
      creatorName: 'string',
      modifiedTime: 'number',
      reportId: 'string',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemindResultsResponseBodyDataListToGroups extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemindResultsResponseBodyDataList extends $tea.Model {
  creatorId?: string;
  endDateTime?: string[];
  modifierId?: string;
  periodType?: number;
  remindId?: number;
  startDateTime?: string[];
  templateId?: string;
  toGroups?: QueryRemindResultsResponseBodyDataListToGroups[];
  static names(): { [key: string]: string } {
    return {
      creatorId: 'creatorId',
      endDateTime: 'endDateTime',
      modifierId: 'modifierId',
      periodType: 'periodType',
      remindId: 'remindId',
      startDateTime: 'startDateTime',
      templateId: 'templateId',
      toGroups: 'toGroups',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorId: 'string',
      endDateTime: { 'type': 'array', 'itemType': 'string' },
      modifierId: 'string',
      periodType: 'number',
      remindId: 'number',
      startDateTime: { 'type': 'array', 'itemType': 'string' },
      templateId: 'string',
      toGroups: { 'type': 'array', 'itemType': QueryRemindResultsResponseBodyDataListToGroups },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportDetailResponseBodyContent extends $tea.Model {
  images?: string[];
  key?: string;
  sort?: string;
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      images: 'images',
      key: 'key',
      sort: 'sort',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      images: { 'type': 'array', 'itemType': 'string' },
      key: 'string',
      sort: 'string',
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * @summary 创建模板
   *
   * @param request CreateTemplatesRequest
   * @param headers CreateTemplatesHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateTemplatesResponse
   */
  async createTemplatesWithOptions(request: CreateTemplatesRequest, headers: CreateTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTemplatesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.allowAddReceivers)) {
      body["allowAddReceivers"] = request.allowAddReceivers;
    }

    if (!Util.isUnset(request.allowEdit)) {
      body["allowEdit"] = request.allowEdit;
    }

    if (!Util.isUnset(request.allowGetLocation)) {
      body["allowGetLocation"] = request.allowGetLocation;
    }

    if (!Util.isUnset(request.authDeptIds)) {
      body["authDeptIds"] = request.authDeptIds;
    }

    if (!Util.isUnset(request.authUserIds)) {
      body["authUserIds"] = request.authUserIds;
    }

    if (!Util.isUnset(request.creator)) {
      body["creator"] = request.creator;
    }

    if (!Util.isUnset(request.defaultReceivedCids)) {
      body["defaultReceivedCids"] = request.defaultReceivedCids;
    }

    if (!Util.isUnset(request.defaultReceivedMasterLevels)) {
      body["defaultReceivedMasterLevels"] = request.defaultReceivedMasterLevels;
    }

    if (!Util.isUnset(request.defaultReceivers)) {
      body["defaultReceivers"] = request.defaultReceivers;
    }

    if (!Util.isUnset(request.fields)) {
      body["fields"] = request.fields;
    }

    if (!Util.isUnset(request.logo)) {
      body["logo"] = request.logo;
    }

    if (!Util.isUnset(request.maxWordCount)) {
      body["maxWordCount"] = request.maxWordCount;
    }

    if (!Util.isUnset(request.minWordCount)) {
      body["minWordCount"] = request.minWordCount;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.templateManagers)) {
      body["templateManagers"] = request.templateManagers;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateTemplates",
      version: "report_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/report/templates`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTemplatesResponse>(await this.execute(params, req, runtime), new CreateTemplatesResponse({}));
  }

  /**
   * @summary 创建模板
   *
   * @param request CreateTemplatesRequest
   * @return CreateTemplatesResponse
   */
  async createTemplates(request: CreateTemplatesRequest): Promise<CreateTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTemplatesHeaders({ });
    return await this.createTemplatesWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询员工提交和收到的日志列表
   *
   * @param request GetSendAndReceiveReportListRequest
   * @param headers GetSendAndReceiveReportListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetSendAndReceiveReportListResponse
   */
  async getSendAndReceiveReportListWithOptions(request: GetSendAndReceiveReportListRequest, headers: GetSendAndReceiveReportListHeaders, runtime: $Util.RuntimeOptions): Promise<GetSendAndReceiveReportListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operationUserId)) {
      query["operationUserId"] = request.operationUserId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetSendAndReceiveReportList",
      version: "report_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/report/users/sendAndReceiveLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSendAndReceiveReportListResponse>(await this.execute(params, req, runtime), new GetSendAndReceiveReportListResponse({}));
  }

  /**
   * @summary 查询员工提交和收到的日志列表
   *
   * @param request GetSendAndReceiveReportListRequest
   * @return GetSendAndReceiveReportListResponse
   */
  async getSendAndReceiveReportList(request: GetSendAndReceiveReportListRequest): Promise<GetSendAndReceiveReportListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSendAndReceiveReportListHeaders({ });
    return await this.getSendAndReceiveReportListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取指定周期的提交统计结果
   *
   * @param request GetSubmitStatisticsRequest
   * @param headers GetSubmitStatisticsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetSubmitStatisticsResponse
   */
  async getSubmitStatisticsWithOptions(request: GetSubmitStatisticsRequest, headers: GetSubmitStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<GetSubmitStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.operationUserId)) {
      query["operationUserId"] = request.operationUserId;
    }

    if (!Util.isUnset(request.remindId)) {
      query["remindId"] = request.remindId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.templateId)) {
      query["templateId"] = request.templateId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetSubmitStatistics",
      version: "report_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/report/submitStatisticalResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSubmitStatisticsResponse>(await this.execute(params, req, runtime), new GetSubmitStatisticsResponse({}));
  }

  /**
   * @summary 获取指定周期的提交统计结果
   *
   * @param request GetSubmitStatisticsRequest
   * @return GetSubmitStatisticsResponse
   */
  async getSubmitStatistics(request: GetSubmitStatisticsRequest): Promise<GetSubmitStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSubmitStatisticsHeaders({ });
    return await this.getSubmitStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取创建的统计规则信息
   *
   * @param request QueryRemindResultsRequest
   * @param headers QueryRemindResultsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryRemindResultsResponse
   */
  async queryRemindResultsWithOptions(request: QueryRemindResultsRequest, headers: QueryRemindResultsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRemindResultsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operationUserId)) {
      query["operationUserId"] = request.operationUserId;
    }

    if (!Util.isUnset(request.templateId)) {
      query["templateId"] = request.templateId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryRemindResults",
      version: "report_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/report/statisticalRules/results`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRemindResultsResponse>(await this.execute(params, req, runtime), new QueryRemindResultsResponse({}));
  }

  /**
   * @summary 获取创建的统计规则信息
   *
   * @param request QueryRemindResultsRequest
   * @return QueryRemindResultsResponse
   */
  async queryRemindResults(request: QueryRemindResultsRequest): Promise<QueryRemindResultsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRemindResultsHeaders({ });
    return await this.queryRemindResultsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取日志详情
   *
   * @param request QueryReportDetailRequest
   * @param headers QueryReportDetailHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryReportDetailResponse
   */
  async queryReportDetailWithOptions(request: QueryReportDetailRequest, headers: QueryReportDetailHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReportDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.reportId)) {
      query["reportId"] = request.reportId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryReportDetail",
      version: "report_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/report/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryReportDetailResponse>(await this.execute(params, req, runtime), new QueryReportDetailResponse({}));
  }

  /**
   * @summary 获取日志详情
   *
   * @param request QueryReportDetailRequest
   * @return QueryReportDetailResponse
   */
  async queryReportDetail(request: QueryReportDetailRequest): Promise<QueryReportDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReportDetailHeaders({ });
    return await this.queryReportDetailWithOptions(request, headers, runtime);
  }

}
