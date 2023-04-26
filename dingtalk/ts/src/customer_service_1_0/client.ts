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
  foreignId?: string;
  foreignName?: string;
  openInstanceId?: string;
  productionType?: number;
  properties?: CreateTicketRequestProperties[];
  sourceId?: string;
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      foreignId: 'foreignId',
      foreignName: 'foreignName',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      properties: 'properties',
      sourceId: 'sourceId',
      templateId: 'templateId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      foreignId: 'string',
      foreignName: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      properties: { 'type': 'array', 'itemType': CreateTicketRequestProperties },
      sourceId: 'string',
      templateId: 'string',
      title: 'string',
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
  statusCode: number;
  body: CreateTicketResponseBody;
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
      body: CreateTicketResponseBody,
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
  activityCode?: string;
  foreignId?: string;
  foreignName?: string;
  openInstanceId?: string;
  productionType?: number;
  properties?: ExecuteActivityRequestProperties[];
  sourceId?: string;
  static names(): { [key: string]: string } {
    return {
      activityCode: 'activityCode',
      foreignId: 'foreignId',
      foreignName: 'foreignName',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      properties: 'properties',
      sourceId: 'sourceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityCode: 'string',
      foreignId: 'string',
      foreignName: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      properties: { 'type': 'array', 'itemType': ExecuteActivityRequestProperties },
      sourceId: 'string',
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
  statusCode: number;
  body: ExecuteActivityResponseBody;
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
      body: ExecuteActivityResponseBody,
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
  corpId?: string;
  description?: string;
  openInstanceId?: string;
  orgId?: number;
  orgName?: string;
  productionType?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      description: 'description',
      openInstanceId: 'openInstanceId',
      orgId: 'orgId',
      orgName: 'orgName',
      productionType: 'productionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      description: 'string',
      openInstanceId: 'string',
      orgId: 'number',
      orgName: 'string',
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
  statusCode: number;
  body: GetUserSourceListResponseBody;
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
      body: GetUserSourceListResponseBody,
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
  maxResults?: number;
  nextToken?: string;
  openInstanceId?: string;
  productionType?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openInstanceId: 'string',
      productionType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponseBody extends $tea.Model {
  list?: PageListActionResponseBodyList[];
  nextCursor?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': PageListActionResponseBodyList },
      nextCursor: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PageListActionResponseBody;
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
      body: PageListActionResponseBody,
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
  maxResults?: number;
  nextToken?: number;
  openInstanceId?: string;
  productionType?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      maxResults: 'number',
      nextToken: 'number',
      openInstanceId: 'string',
      productionType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: PageListRobotResponseBodyList[];
  nextCursor?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': PageListRobotResponseBodyList },
      nextCursor: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PageListRobotResponseBody;
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
      body: PageListRobotResponseBody,
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
  endTime?: number;
  foreignId?: string;
  maxResults?: number;
  nextToken?: string;
  openInstanceId?: string;
  productionType?: number;
  sourceId?: string;
  startTime?: number;
  templateId?: string;
  ticketId?: string;
  ticketStatus?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      foreignId: 'foreignId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      sourceId: 'sourceId',
      startTime: 'startTime',
      templateId: 'templateId',
      ticketId: 'ticketId',
      ticketStatus: 'ticketStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      foreignId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      sourceId: 'string',
      startTime: 'number',
      templateId: 'string',
      ticketId: 'string',
      ticketStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketResponseBody extends $tea.Model {
  list?: PageListTicketResponseBodyList[];
  nextCursor?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': PageListTicketResponseBodyList },
      nextCursor: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PageListTicketResponseBody;
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

export class GetUserSourceListResponseBodyResult extends $tea.Model {
  config?: string;
  description?: string;
  id?: number;
  name?: string;
  status?: number;
  vendor?: string;
  static names(): { [key: string]: string } {
    return {
      config: 'config',
      description: 'description',
      id: 'id',
      name: 'name',
      status: 'status',
      vendor: 'vendor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      config: 'string',
      description: 'string',
      id: 'number',
      name: 'string',
      status: 'number',
      vendor: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListActionResponseBodyListActionContent extends $tea.Model {
  displayName?: string;
  displayValue?: string;
  name?: string;
  value?: string;
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      displayValue: 'displayValue',
      name: 'name',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      displayValue: 'string',
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
  actionCode?: string;
  actionContent?: PageListActionResponseBodyListActionContent[];
  operator?: string;
  operatorId?: string;
  operatorRole?: string;
  static names(): { [key: string]: string } {
    return {
      actionCode: 'actionCode',
      actionContent: 'actionContent',
      operator: 'operator',
      operatorId: 'operatorId',
      operatorRole: 'operatorRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCode: 'string',
      actionContent: { 'type': 'array', 'itemType': PageListActionResponseBodyListActionContent },
      operator: 'string',
      operatorId: 'string',
      operatorRole: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListRobotResponseBodyList extends $tea.Model {
  accountId?: number;
  appKey?: string;
  id?: number;
  name?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      appKey: 'appKey',
      id: 'id',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'number',
      appKey: 'string',
      id: 'number',
      name: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListTicketResponseBodyList extends $tea.Model {
  bizDataMap?: { [key: string]: any };
  foreignId?: string;
  foreignName?: string;
  gmtCreate?: string;
  gmtModified?: string;
  openInstanceId?: string;
  productionType?: number;
  sourceId?: string;
  templateId?: string;
  ticketId?: string;
  ticketStatus?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataMap: 'bizDataMap',
      foreignId: 'foreignId',
      foreignName: 'foreignName',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      openInstanceId: 'openInstanceId',
      productionType: 'productionType',
      sourceId: 'sourceId',
      templateId: 'templateId',
      ticketId: 'ticketId',
      ticketStatus: 'ticketStatus',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      foreignId: 'string',
      foreignName: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      openInstanceId: 'string',
      productionType: 'number',
      sourceId: 'string',
      templateId: 'string',
      ticketId: 'string',
      ticketStatus: 'string',
      title: 'string',
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


  async createTicketWithOptions(request: CreateTicketRequest, headers: CreateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    if (!Util.isUnset(request.sourceId)) {
      body["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "CreateTicket",
      version: "customerService_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/customerService/tickets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateTicketResponse>(await this.execute(params, req, runtime), new CreateTicketResponse({}));
  }

  async createTicket(request: CreateTicketRequest): Promise<CreateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTicketHeaders({ });
    return await this.createTicketWithOptions(request, headers, runtime);
  }

  async executeActivityWithOptions(ticketId: string, request: ExecuteActivityRequest, headers: ExecuteActivityHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteActivityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.activityCode)) {
      body["activityCode"] = request.activityCode;
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

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    if (!Util.isUnset(request.sourceId)) {
      body["sourceId"] = request.sourceId;
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
      action: "ExecuteActivity",
      version: "customerService_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/customerService/tickets/${ticketId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ExecuteActivityResponse>(await this.execute(params, req, runtime), new ExecuteActivityResponse({}));
  }

  async executeActivity(ticketId: string, request: ExecuteActivityRequest): Promise<ExecuteActivityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteActivityHeaders({ });
    return await this.executeActivityWithOptions(ticketId, request, headers, runtime);
  }

  async getUserSourceListWithOptions(request: GetUserSourceListRequest, headers: GetUserSourceListHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserSourceListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.description)) {
      query["description"] = request.description;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.orgId)) {
      query["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.orgName)) {
      query["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
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
      action: "GetUserSourceList",
      version: "customerService_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/customerService/customers/sources`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserSourceListResponse>(await this.execute(params, req, runtime), new GetUserSourceListResponse({}));
  }

  async getUserSourceList(request: GetUserSourceListRequest): Promise<GetUserSourceListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserSourceListHeaders({ });
    return await this.getUserSourceListWithOptions(request, headers, runtime);
  }

  async pageListActionWithOptions(ticketId: string, request: PageListActionRequest, headers: PageListActionHeaders, runtime: $Util.RuntimeOptions): Promise<PageListActionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
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
      action: "PageListAction",
      version: "customerService_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/customerService/tickets/${ticketId}/actions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<PageListActionResponse>(await this.execute(params, req, runtime), new PageListActionResponse({}));
  }

  async pageListAction(ticketId: string, request: PageListActionRequest): Promise<PageListActionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListActionHeaders({ });
    return await this.pageListActionWithOptions(ticketId, request, headers, runtime);
  }

  async pageListRobotWithOptions(request: PageListRobotRequest, headers: PageListRobotHeaders, runtime: $Util.RuntimeOptions): Promise<PageListRobotResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
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
      action: "PageListRobot",
      version: "customerService_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/customerService/robots`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<PageListRobotResponse>(await this.execute(params, req, runtime), new PageListRobotResponse({}));
  }

  async pageListRobot(request: PageListRobotRequest): Promise<PageListRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListRobotHeaders({ });
    return await this.pageListRobotWithOptions(request, headers, runtime);
  }

  async pageListTicketWithOptions(request: PageListTicketRequest, headers: PageListTicketHeaders, runtime: $Util.RuntimeOptions): Promise<PageListTicketResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.foreignId)) {
      query["foreignId"] = request.foreignId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openInstanceId)) {
      query["openInstanceId"] = request.openInstanceId;
    }

    if (!Util.isUnset(request.productionType)) {
      query["productionType"] = request.productionType;
    }

    if (!Util.isUnset(request.sourceId)) {
      query["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.templateId)) {
      query["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.ticketId)) {
      query["ticketId"] = request.ticketId;
    }

    if (!Util.isUnset(request.ticketStatus)) {
      query["ticketStatus"] = request.ticketStatus;
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
      action: "PageListTicket",
      version: "customerService_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/customerService/tickets`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<PageListTicketResponse>(await this.execute(params, req, runtime), new PageListTicketResponse({}));
  }

  async pageListTicket(request: PageListTicketRequest): Promise<PageListTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListTicketHeaders({ });
    return await this.pageListTicketWithOptions(request, headers, runtime);
  }

}
