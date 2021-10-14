// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateTicketHeaders extends $tea.Model {
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

export class CreateTicketRequest extends $tea.Model {
  sourceId?: string;
  foreignId?: string;
  foreignName?: string;
  openInstanceId?: string;
  productionType?: number;
  templateId?: string;
  title?: string;
  properties?: CreateTicketRequestProperties[];
  static names(): { [key: string]: string } {
    return {
      sourceId: 'sourceId',
      foreignId: 'foreignId',
      foreignName: 'foreignName',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      templateId: 'templateId',
      title: 'title',
      properties: 'properties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sourceId: 'string',
      foreignId: 'string',
      foreignName: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      templateId: 'string',
      title: 'string',
      properties: { 'type': 'array', 'itemType': CreateTicketRequestProperties },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketResponseBody extends $tea.Model {
  ticketId?: string;
  static names(): { [key: string]: string } {
    return {
      ticketId: 'ticketId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ticketId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTicketResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserSourceListHeaders extends $tea.Model {
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

export class GetUserSourceListRequest extends $tea.Model {
  openInstanceId?: string;
  description?: string;
  orgName?: string;
  orgId?: number;
  corpId?: string;
  productionType?: number;
  static names(): { [key: string]: string } {
    return {
      openInstanceId: 'openInstanceId',
      description: 'description',
      orgName: 'orgName',
      orgId: 'orgId',
      corpId: 'corpId',
      productionType: 'productionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openInstanceId: 'string',
      description: 'string',
      orgName: 'string',
      orgId: 'number',
      corpId: 'string',
      productionType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserSourceListResponseBody extends $tea.Model {
  result?: GetUserSourceListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetUserSourceListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserSourceListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserSourceListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserSourceListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotHeaders extends $tea.Model {
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

export class PageListRobotRequest extends $tea.Model {
  corpId?: string;
  openInstanceId?: string;
  productionType?: number;
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotResponseBody extends $tea.Model {
  total?: number;
  nextCursor?: number;
  hasMore?: boolean;
  list?: PageListRobotResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      total: 'total',
      nextCursor: 'nextCursor',
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      total: 'number',
      nextCursor: 'number',
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PageListRobotResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PageListRobotResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PageListRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionHeaders extends $tea.Model {
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

export class PageListActionRequest extends $tea.Model {
  openInstanceId?: string;
  productionType?: number;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openInstanceId: 'string',
      productionType: 'number',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponseBody extends $tea.Model {
  nextCursor?: number;
  total?: number;
  list?: PageListActionResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextCursor: 'nextCursor',
      total: 'total',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextCursor: 'number',
      total: 'number',
      list: { 'type': 'array', 'itemType': PageListActionResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PageListActionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PageListActionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteActivityHeaders extends $tea.Model {
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

export class ExecuteActivityRequest extends $tea.Model {
  sourceId?: string;
  foreignId?: string;
  foreignName?: string;
  activityCode?: string;
  openInstanceId?: string;
  productionType?: number;
  properties?: ExecuteActivityRequestProperties[];
  static names(): { [key: string]: string } {
    return {
      sourceId: 'sourceId',
      foreignId: 'foreignId',
      foreignName: 'foreignName',
      activityCode: 'activityCode',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      properties: 'properties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sourceId: 'string',
      foreignId: 'string',
      foreignName: 'string',
      activityCode: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      properties: { 'type': 'array', 'itemType': ExecuteActivityRequestProperties },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteActivityResponseBody extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteActivityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExecuteActivityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExecuteActivityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketHeaders extends $tea.Model {
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

export class PageListTicketRequest extends $tea.Model {
  openInstanceId?: string;
  productionType?: number;
  templateId?: string;
  ticketId?: string;
  sourceId?: string;
  foreignId?: string;
  ticketStatus?: string;
  startTime?: number;
  endTime?: number;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      templateId: 'templateId',
      ticketId: 'ticketId',
      sourceId: 'sourceId',
      foreignId: 'foreignId',
      ticketStatus: 'ticketStatus',
      startTime: 'startTime',
      endTime: 'endTime',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openInstanceId: 'string',
      productionType: 'number',
      templateId: 'string',
      ticketId: 'string',
      sourceId: 'string',
      foreignId: 'string',
      ticketStatus: 'string',
      startTime: 'number',
      endTime: 'number',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketResponseBody extends $tea.Model {
  nextCursor?: number;
  total?: number;
  list?: PageListTicketResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextCursor: 'nextCursor',
      total: 'total',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextCursor: 'number',
      total: 'number',
      list: { 'type': 'array', 'itemType': PageListTicketResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PageListTicketResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PageListTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestProperties extends $tea.Model {
  name?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserSourceListResponseBodyResult extends $tea.Model {
  id?: number;
  status?: number;
  description?: string;
  config?: string;
  vendor?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      status: 'status',
      description: 'description',
      config: 'config',
      vendor: 'vendor',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      status: 'number',
      description: 'string',
      config: 'string',
      vendor: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotResponseBodyList extends $tea.Model {
  id?: number;
  name?: string;
  appKey?: string;
  accountId?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      appKey: 'appKey',
      accountId: 'accountId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      appKey: 'string',
      accountId: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponseBodyListActionContent extends $tea.Model {
  displayValue?: string;
  displayName?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      displayValue: 'displayValue',
      displayName: 'displayName',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayValue: 'string',
      displayName: 'string',
      name: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponseBodyList extends $tea.Model {
  operatorId?: string;
  operator?: string;
  operatorRole?: string;
  actionCode?: string;
  actionContent?: PageListActionResponseBodyListActionContent[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      operator: 'operator',
      operatorRole: 'operatorRole',
      actionCode: 'actionCode',
      actionContent: 'actionContent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      operator: 'string',
      operatorRole: 'string',
      actionCode: 'string',
      actionContent: { 'type': 'array', 'itemType': PageListActionResponseBodyListActionContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteActivityRequestProperties extends $tea.Model {
  name?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketResponseBodyList extends $tea.Model {
  foreignId?: string;
  sourceId?: string;
  foreignName?: string;
  templateId?: string;
  title?: string;
  ticketId?: string;
  ticketStatus?: string;
  openInstanceId?: string;
  productionType?: number;
  gmtCreate?: string;
  gmtModified?: string;
  bizDataMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      foreignId: 'foreignId',
      sourceId: 'sourceId',
      foreignName: 'foreignName',
      templateId: 'templateId',
      title: 'title',
      ticketId: 'ticketId',
      ticketStatus: 'ticketStatus',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      bizDataMap: 'bizDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      foreignId: 'string',
      sourceId: 'string',
      foreignName: 'string',
      templateId: 'string',
      title: 'string',
      ticketId: 'string',
      ticketStatus: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      gmtCreate: 'string',
      gmtModified: 'string',
      bizDataMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async createTicket(request: CreateTicketRequest): Promise<CreateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTicketHeaders({ });
    return await this.createTicketWithOptions(request, headers, runtime);
  }

  async createTicketWithOptions(request: CreateTicketRequest, headers: CreateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sourceId)) {
      body["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.foreignId)) {
      body["foreignId"] = request.foreignId;
    }

    if (!Util.isUnset(request.foreignName)) {
      body["foreignName"] = request.foreignName;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      body["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      body["productionType"] = request.productionType;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateTicketResponse>(await this.doROARequest("CreateTicket", "customerService_1.0", "HTTP", "POST", "AK", `/v1.0/customerService/tickets`, "json", req, runtime), new CreateTicketResponse({}));
  }

  async getUserSourceList(request: GetUserSourceListRequest): Promise<GetUserSourceListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserSourceListHeaders({ });
    return await this.getUserSourceListWithOptions(request, headers, runtime);
  }

  async getUserSourceListWithOptions(request: GetUserSourceListRequest, headers: GetUserSourceListHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserSourceListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.description)) {
      query["description"] = request.description;
    }

    if (!Util.isUnset(request.orgName)) {
      query["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.orgId)) {
      query["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetUserSourceListResponse>(await this.doROARequest("GetUserSourceList", "customerService_1.0", "HTTP", "GET", "AK", `/v1.0/customerService/customers/sources`, "json", req, runtime), new GetUserSourceListResponse({}));
  }

  async pageListRobot(request: PageListRobotRequest): Promise<PageListRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListRobotHeaders({ });
    return await this.pageListRobotWithOptions(request, headers, runtime);
  }

  async pageListRobotWithOptions(request: PageListRobotRequest, headers: PageListRobotHeaders, runtime: $Util.RuntimeOptions): Promise<PageListRobotResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<PageListRobotResponse>(await this.doROARequest("PageListRobot", "customerService_1.0", "HTTP", "GET", "AK", `/v1.0/customerService/robots`, "json", req, runtime), new PageListRobotResponse({}));
  }

  async pageListAction(ticketId: string, request: PageListActionRequest): Promise<PageListActionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListActionHeaders({ });
    return await this.pageListActionWithOptions(ticketId, request, headers, runtime);
  }

  async pageListActionWithOptions(ticketId: string, request: PageListActionRequest, headers: PageListActionHeaders, runtime: $Util.RuntimeOptions): Promise<PageListActionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<PageListActionResponse>(await this.doROARequest("PageListAction", "customerService_1.0", "HTTP", "GET", "AK", `/v1.0/customerService/tickets/${ticketId}/actions`, "json", req, runtime), new PageListActionResponse({}));
  }

  async executeActivity(ticketId: string, request: ExecuteActivityRequest): Promise<ExecuteActivityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteActivityHeaders({ });
    return await this.executeActivityWithOptions(ticketId, request, headers, runtime);
  }

  async executeActivityWithOptions(ticketId: string, request: ExecuteActivityRequest, headers: ExecuteActivityHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteActivityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sourceId)) {
      body["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.foreignId)) {
      body["foreignId"] = request.foreignId;
    }

    if (!Util.isUnset(request.foreignName)) {
      body["foreignName"] = request.foreignName;
    }

    if (!Util.isUnset(request.activityCode)) {
      body["activityCode"] = request.activityCode;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      body["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      body["productionType"] = request.productionType;
    }

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ExecuteActivityResponse>(await this.doROARequest("ExecuteActivity", "customerService_1.0", "HTTP", "PUT", "AK", `/v1.0/customerService/tickets/${ticketId}`, "json", req, runtime), new ExecuteActivityResponse({}));
  }

  async pageListTicket(request: PageListTicketRequest): Promise<PageListTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListTicketHeaders({ });
    return await this.pageListTicketWithOptions(request, headers, runtime);
  }

  async pageListTicketWithOptions(request: PageListTicketRequest, headers: PageListTicketHeaders, runtime: $Util.RuntimeOptions): Promise<PageListTicketResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
    }

    if (!Util.isUnset(request.templateId)) {
      query["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.ticketId)) {
      query["ticketId"] = request.ticketId;
    }

    if (!Util.isUnset(request.sourceId)) {
      query["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.foreignId)) {
      query["foreignId"] = request.foreignId;
    }

    if (!Util.isUnset(request.ticketStatus)) {
      query["ticketStatus"] = request.ticketStatus;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<PageListTicketResponse>(await this.doROARequest("PageListTicket", "customerService_1.0", "HTTP", "GET", "AK", `/v1.0/customerService/tickets`, "json", req, runtime), new PageListTicketResponse({}));
  }

}
