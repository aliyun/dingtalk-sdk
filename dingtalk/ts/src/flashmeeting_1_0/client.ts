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

export class CreateFlashMeetingHeaders extends $tea.Model {
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

export class CreateFlashMeetingRequest extends $tea.Model {
  creator?: string;
  eventId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      eventId: 'eventId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      eventId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFlashMeetingResponseBody extends $tea.Model {
  endTime?: number;
  flashMeetingKey?: string;
  startTime?: number;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      flashMeetingKey: 'flashMeetingKey',
      startTime: 'startTime',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      flashMeetingKey: 'string',
      startTime: 'number',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFlashMeetingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateFlashMeetingResponseBody;
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
      body: CreateFlashMeetingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByCalendarHeaders extends $tea.Model {
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

export class GetShanhuiByCalendarRequest extends $tea.Model {
  eventId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      eventId: 'eventId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByCalendarResponseBody extends $tea.Model {
  result?: GetShanhuiByCalendarResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetShanhuiByCalendarResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByCalendarResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetShanhuiByCalendarResponseBody;
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
      body: GetShanhuiByCalendarResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByShanhuiKeyHeaders extends $tea.Model {
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

export class GetShanhuiByShanhuiKeyResponseBody extends $tea.Model {
  result?: GetShanhuiByShanhuiKeyResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetShanhuiByShanhuiKeyResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByShanhuiKeyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetShanhuiByShanhuiKeyResponseBody;
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
      body: GetShanhuiByShanhuiKeyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskFromShanhuiDocHeaders extends $tea.Model {
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

export class GetTaskFromShanhuiDocRequest extends $tea.Model {
  docKey?: string;
  maxResults?: number;
  nextToken?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      docKey: 'docKey',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docKey: 'string',
      maxResults: 'number',
      nextToken: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskFromShanhuiDocResponseBody extends $tea.Model {
  result?: GetTaskFromShanhuiDocResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetTaskFromShanhuiDocResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskFromShanhuiDocResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTaskFromShanhuiDocResponseBody;
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
      body: GetTaskFromShanhuiDocResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByCalendarResponseBodyResultTopics extends $tea.Model {
  docKey?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      docKey: 'docKey',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docKey: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByCalendarResponseBodyResult extends $tea.Model {
  endTime?: number;
  flashmeetingKey?: string;
  hasSummary?: boolean;
  startTime?: number;
  summaryDocKey?: string;
  title?: string;
  topics?: GetShanhuiByCalendarResponseBodyResultTopics[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      flashmeetingKey: 'flashmeetingKey',
      hasSummary: 'hasSummary',
      startTime: 'startTime',
      summaryDocKey: 'summaryDocKey',
      title: 'title',
      topics: 'topics',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      flashmeetingKey: 'string',
      hasSummary: 'boolean',
      startTime: 'number',
      summaryDocKey: 'string',
      title: 'string',
      topics: { 'type': 'array', 'itemType': GetShanhuiByCalendarResponseBodyResultTopics },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByShanhuiKeyResponseBodyResultTopics extends $tea.Model {
  docKey?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      docKey: 'docKey',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docKey: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShanhuiByShanhuiKeyResponseBodyResult extends $tea.Model {
  endTime?: number;
  eventId?: string;
  flashmeetingKey?: string;
  hasSummary?: boolean;
  startTime?: number;
  summaryDocKey?: string;
  title?: string;
  topics?: GetShanhuiByShanhuiKeyResponseBodyResultTopics[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      eventId: 'eventId',
      flashmeetingKey: 'flashmeetingKey',
      hasSummary: 'hasSummary',
      startTime: 'startTime',
      summaryDocKey: 'summaryDocKey',
      title: 'title',
      topics: 'topics',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      eventId: 'string',
      flashmeetingKey: 'string',
      hasSummary: 'boolean',
      startTime: 'number',
      summaryDocKey: 'string',
      title: 'string',
      topics: { 'type': 'array', 'itemType': GetShanhuiByShanhuiKeyResponseBodyResultTopics },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskFromShanhuiDocResponseBodyResultItems extends $tea.Model {
  createTime?: number;
  deadline?: number;
  deleted?: boolean;
  priority?: number;
  taskKey?: string;
  taskStatus?: string;
  taskType?: string;
  title?: string;
  updateTime?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      deadline: 'deadline',
      deleted: 'deleted',
      priority: 'priority',
      taskKey: 'taskKey',
      taskStatus: 'taskStatus',
      taskType: 'taskType',
      title: 'title',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      deadline: 'number',
      deleted: 'boolean',
      priority: 'number',
      taskKey: 'string',
      taskStatus: 'string',
      taskType: 'string',
      title: 'string',
      updateTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskFromShanhuiDocResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  items?: GetTaskFromShanhuiDocResponseBodyResultItems[];
  nextToken?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      items: 'items',
      nextToken: 'nextToken',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': GetTaskFromShanhuiDocResponseBodyResultItems },
      nextToken: 'string',
      total: 'number',
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


  async createFlashMeetingWithOptions(request: CreateFlashMeetingRequest, headers: CreateFlashMeetingHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFlashMeetingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creator)) {
      body["creator"] = request.creator;
    }

    if (!Util.isUnset(request.eventId)) {
      body["eventId"] = request.eventId;
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
      action: "CreateFlashMeeting",
      version: "flashmeeting_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmeeting/meetings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateFlashMeetingResponse>(await this.execute(params, req, runtime), new CreateFlashMeetingResponse({}));
  }

  async createFlashMeeting(request: CreateFlashMeetingRequest): Promise<CreateFlashMeetingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFlashMeetingHeaders({ });
    return await this.createFlashMeetingWithOptions(request, headers, runtime);
  }

  async getShanhuiByCalendarWithOptions(request: GetShanhuiByCalendarRequest, headers: GetShanhuiByCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<GetShanhuiByCalendarResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.eventId)) {
      query["eventId"] = request.eventId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
      action: "GetShanhuiByCalendar",
      version: "flashmeeting_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmeeting/calendars/meeting`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetShanhuiByCalendarResponse>(await this.execute(params, req, runtime), new GetShanhuiByCalendarResponse({}));
  }

  async getShanhuiByCalendar(request: GetShanhuiByCalendarRequest): Promise<GetShanhuiByCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShanhuiByCalendarHeaders({ });
    return await this.getShanhuiByCalendarWithOptions(request, headers, runtime);
  }

  async getShanhuiByShanhuiKeyWithOptions(flashmeetingKey: string, headers: GetShanhuiByShanhuiKeyHeaders, runtime: $Util.RuntimeOptions): Promise<GetShanhuiByShanhuiKeyResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetShanhuiByShanhuiKey",
      version: "flashmeeting_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmeeting/meetings/keys/${flashmeetingKey}/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetShanhuiByShanhuiKeyResponse>(await this.execute(params, req, runtime), new GetShanhuiByShanhuiKeyResponse({}));
  }

  async getShanhuiByShanhuiKey(flashmeetingKey: string): Promise<GetShanhuiByShanhuiKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShanhuiByShanhuiKeyHeaders({ });
    return await this.getShanhuiByShanhuiKeyWithOptions(flashmeetingKey, headers, runtime);
  }

  async getTaskFromShanhuiDocWithOptions(request: GetTaskFromShanhuiDocRequest, headers: GetTaskFromShanhuiDocHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskFromShanhuiDocResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.docKey)) {
      query["docKey"] = request.docKey;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetTaskFromShanhuiDoc",
      version: "flashmeeting_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmeeting/meetings/tasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTaskFromShanhuiDocResponse>(await this.execute(params, req, runtime), new GetTaskFromShanhuiDocResponse({}));
  }

  async getTaskFromShanhuiDoc(request: GetTaskFromShanhuiDocRequest): Promise<GetTaskFromShanhuiDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskFromShanhuiDocHeaders({ });
    return await this.getTaskFromShanhuiDocWithOptions(request, headers, runtime);
  }

}
