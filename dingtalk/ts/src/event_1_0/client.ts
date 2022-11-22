// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetCallBackFaileResultHeaders extends $tea.Model {
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

export class GetCallBackFaileResultRequest extends $tea.Model {
  beginTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'number',
      endTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCallBackFaileResultResponseBody extends $tea.Model {
  failedList?: GetCallBackFaileResultResponseBodyFailedList[];
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      failedList: 'failedList',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedList: { 'type': 'array', 'itemType': GetCallBackFaileResultResponseBodyFailedList },
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCallBackFaileResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCallBackFaileResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCallBackFaileResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCallBackFaileResultResponseBodyFailedList extends $tea.Model {
  callBackData?: string;
  callBackTag?: string;
  corpId?: string;
  eventTime?: number;
  static names(): { [key: string]: string } {
    return {
      callBackData: 'callBackData',
      callBackTag: 'callBackTag',
      corpId: 'corpId',
      eventTime: 'eventTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callBackData: 'string',
      callBackTag: 'string',
      corpId: 'string',
      eventTime: 'number',
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


  async getCallBackFaileResult(request: GetCallBackFaileResultRequest): Promise<GetCallBackFaileResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCallBackFaileResultHeaders({ });
    return await this.getCallBackFaileResultWithOptions(request, headers, runtime);
  }

  async getCallBackFaileResultWithOptions(request: GetCallBackFaileResultRequest, headers: GetCallBackFaileResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetCallBackFaileResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.beginTime)) {
      query["beginTime"] = request.beginTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
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
    return $tea.cast<GetCallBackFaileResultResponse>(await this.doROARequest("GetCallBackFaileResult", "event_1.0", "HTTP", "GET", "AK", `/v1.0/event/callbacks/failedResults`, "json", req, runtime), new GetCallBackFaileResultResponse({}));
  }

}
