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

export class GetCheckinRecordByUserHeaders extends $tea.Model {
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

export class GetCheckinRecordByUserRequest extends $tea.Model {
  endTime?: number;
  maxResults?: number;
  nextToken?: number;
  operatorUserId?: string;
  startTime?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorUserId: 'operatorUserId',
      startTime: 'startTime',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      operatorUserId: 'string',
      startTime: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBody extends $tea.Model {
  result?: GetCheckinRecordByUserResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetCheckinRecordByUserResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCheckinRecordByUserResponseBody;
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
      body: GetCheckinRecordByUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBodyResultPageListCustomDataList extends $tea.Model {
  key?: string;
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBodyResultPageList extends $tea.Model {
  checkinTime?: number;
  customDataList?: GetCheckinRecordByUserResponseBodyResultPageListCustomDataList[];
  detailPlace?: string;
  imageList?: string[];
  place?: string;
  remark?: string;
  userId?: string;
  visitUser?: string;
  static names(): { [key: string]: string } {
    return {
      checkinTime: 'checkinTime',
      customDataList: 'customDataList',
      detailPlace: 'detailPlace',
      imageList: 'imageList',
      place: 'place',
      remark: 'remark',
      userId: 'userId',
      visitUser: 'visitUser',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkinTime: 'number',
      customDataList: { 'type': 'array', 'itemType': GetCheckinRecordByUserResponseBodyResultPageListCustomDataList },
      detailPlace: 'string',
      imageList: { 'type': 'array', 'itemType': 'string' },
      place: 'string',
      remark: 'string',
      userId: 'string',
      visitUser: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBodyResult extends $tea.Model {
  nextToken?: number;
  pageList?: GetCheckinRecordByUserResponseBodyResultPageList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      pageList: 'pageList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      pageList: { 'type': 'array', 'itemType': GetCheckinRecordByUserResponseBodyResultPageList },
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


  async getCheckinRecordByUserWithOptions(request: GetCheckinRecordByUserRequest, headers: GetCheckinRecordByUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetCheckinRecordByUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
      action: "GetCheckinRecordByUser",
      version: "checkIn_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/checkIn/records/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCheckinRecordByUserResponse>(await this.execute(params, req, runtime), new GetCheckinRecordByUserResponse({}));
  }

  async getCheckinRecordByUser(request: GetCheckinRecordByUserRequest): Promise<GetCheckinRecordByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCheckinRecordByUserHeaders({ });
    return await this.getCheckinRecordByUserWithOptions(request, headers, runtime);
  }

}
