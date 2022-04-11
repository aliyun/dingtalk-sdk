// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetPersonalCarbonInfoHeaders extends $tea.Model {
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

export class GetPersonalCarbonInfoRequest extends $tea.Model {
  actionType?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalCarbonInfoResponseBody extends $tea.Model {
  content?: string;
  personalCarbonAmount?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      personalCarbonAmount: 'personalCarbonAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      personalCarbonAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalCarbonInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPersonalCarbonInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPersonalCarbonInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaOrgCarbonHeaders extends $tea.Model {
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

export class WriteAlibabaOrgCarbonRequest extends $tea.Model {
  orgDetailsList?: WriteAlibabaOrgCarbonRequestOrgDetailsList[];
  static names(): { [key: string]: string } {
    return {
      orgDetailsList: 'orgDetailsList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgDetailsList: { 'type': 'array', 'itemType': WriteAlibabaOrgCarbonRequestOrgDetailsList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaOrgCarbonResponseBody extends $tea.Model {
  result?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaOrgCarbonResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: WriteAlibabaOrgCarbonResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: WriteAlibabaOrgCarbonResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaUserCarbonHeaders extends $tea.Model {
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

export class WriteAlibabaUserCarbonRequest extends $tea.Model {
  userDetailsList?: WriteAlibabaUserCarbonRequestUserDetailsList[];
  static names(): { [key: string]: string } {
    return {
      userDetailsList: 'userDetailsList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userDetailsList: { 'type': 'array', 'itemType': WriteAlibabaUserCarbonRequestUserDetailsList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaUserCarbonResponseBody extends $tea.Model {
  result?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaUserCarbonResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: WriteAlibabaUserCarbonResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: WriteAlibabaUserCarbonResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteIsvStateHeaders extends $tea.Model {
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

export class WriteIsvStateRequest extends $tea.Model {
  isvName?: string;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      isvName: 'isvName',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvName: 'string',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteIsvStateResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteIsvStateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: WriteIsvStateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: WriteIsvStateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteOrgCarbonHeaders extends $tea.Model {
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

export class WriteOrgCarbonRequest extends $tea.Model {
  orgDetailsList?: WriteOrgCarbonRequestOrgDetailsList[];
  static names(): { [key: string]: string } {
    return {
      orgDetailsList: 'orgDetailsList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgDetailsList: { 'type': 'array', 'itemType': WriteOrgCarbonRequestOrgDetailsList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteOrgCarbonResponseBody extends $tea.Model {
  result?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteOrgCarbonResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: WriteOrgCarbonResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: WriteOrgCarbonResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteUserCarbonHeaders extends $tea.Model {
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

export class WriteUserCarbonRequest extends $tea.Model {
  userDetailsList?: WriteUserCarbonRequestUserDetailsList[];
  static names(): { [key: string]: string } {
    return {
      userDetailsList: 'userDetailsList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userDetailsList: { 'type': 'array', 'itemType': WriteUserCarbonRequestUserDetailsList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteUserCarbonResponseBody extends $tea.Model {
  result?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteUserCarbonResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: WriteUserCarbonResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: WriteUserCarbonResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaOrgCarbonRequestOrgDetailsList extends $tea.Model {
  actionId?: string;
  actionTime?: string;
  actionType?: string;
  carbonAmount?: string;
  corpId?: string;
  deptId?: number;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionId: 'actionId',
      actionTime: 'actionTime',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      corpId: 'corpId',
      deptId: 'deptId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionId: 'string',
      actionTime: 'string',
      actionType: 'string',
      carbonAmount: 'string',
      corpId: 'string',
      deptId: 'number',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaUserCarbonRequestUserDetailsList extends $tea.Model {
  actionEndTime?: string;
  actionId?: string;
  actionStartTime?: string;
  actionType?: string;
  carbonAmount?: string;
  corpId?: string;
  deptId?: number;
  userId?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionEndTime: 'actionEndTime',
      actionId: 'actionId',
      actionStartTime: 'actionStartTime',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      corpId: 'corpId',
      deptId: 'deptId',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionEndTime: 'string',
      actionId: 'string',
      actionStartTime: 'string',
      actionType: 'string',
      carbonAmount: 'string',
      corpId: 'string',
      deptId: 'number',
      userId: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteOrgCarbonRequestOrgDetailsList extends $tea.Model {
  actionId?: string;
  actionTime?: string;
  actionType?: string;
  carbonAmount?: string;
  corpId?: string;
  deptId?: number;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionId: 'actionId',
      actionTime: 'actionTime',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      corpId: 'corpId',
      deptId: 'deptId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionId: 'string',
      actionTime: 'string',
      actionType: 'string',
      carbonAmount: 'string',
      corpId: 'string',
      deptId: 'number',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteUserCarbonRequestUserDetailsList extends $tea.Model {
  actionEndTime?: string;
  actionId?: string;
  actionStartTime?: string;
  actionType?: string;
  carbonAmount?: string;
  corpId?: string;
  deptId?: number;
  userId?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionEndTime: 'actionEndTime',
      actionId: 'actionId',
      actionStartTime: 'actionStartTime',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      corpId: 'corpId',
      deptId: 'deptId',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionEndTime: 'string',
      actionId: 'string',
      actionStartTime: 'string',
      actionType: 'string',
      carbonAmount: 'string',
      corpId: 'string',
      deptId: 'number',
      userId: 'string',
      version: 'number',
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


  async getPersonalCarbonInfo(request: GetPersonalCarbonInfoRequest): Promise<GetPersonalCarbonInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPersonalCarbonInfoHeaders({ });
    return await this.getPersonalCarbonInfoWithOptions(request, headers, runtime);
  }

  async getPersonalCarbonInfoWithOptions(request: GetPersonalCarbonInfoRequest, headers: GetPersonalCarbonInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPersonalCarbonInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionType)) {
      query["actionType"] = request.actionType;
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
    return $tea.cast<GetPersonalCarbonInfoResponse>(await this.doROARequest("GetPersonalCarbonInfo", "carbon_1.0", "HTTP", "GET", "AK", `/v1.0/carbon/personals/infos`, "json", req, runtime), new GetPersonalCarbonInfoResponse({}));
  }

  async writeAlibabaOrgCarbon(request: WriteAlibabaOrgCarbonRequest): Promise<WriteAlibabaOrgCarbonResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WriteAlibabaOrgCarbonHeaders({ });
    return await this.writeAlibabaOrgCarbonWithOptions(request, headers, runtime);
  }

  async writeAlibabaOrgCarbonWithOptions(request: WriteAlibabaOrgCarbonRequest, headers: WriteAlibabaOrgCarbonHeaders, runtime: $Util.RuntimeOptions): Promise<WriteAlibabaOrgCarbonResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orgDetailsList)) {
      body["orgDetailsList"] = request.orgDetailsList;
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
    return $tea.cast<WriteAlibabaOrgCarbonResponse>(await this.doROARequest("WriteAlibabaOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/alibabaOrgDetails/write`, "json", req, runtime), new WriteAlibabaOrgCarbonResponse({}));
  }

  async writeAlibabaUserCarbon(request: WriteAlibabaUserCarbonRequest): Promise<WriteAlibabaUserCarbonResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WriteAlibabaUserCarbonHeaders({ });
    return await this.writeAlibabaUserCarbonWithOptions(request, headers, runtime);
  }

  async writeAlibabaUserCarbonWithOptions(request: WriteAlibabaUserCarbonRequest, headers: WriteAlibabaUserCarbonHeaders, runtime: $Util.RuntimeOptions): Promise<WriteAlibabaUserCarbonResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userDetailsList)) {
      body["userDetailsList"] = request.userDetailsList;
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
    return $tea.cast<WriteAlibabaUserCarbonResponse>(await this.doROARequest("WriteAlibabaUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/alibabaUserDetails/write`, "json", req, runtime), new WriteAlibabaUserCarbonResponse({}));
  }

  async writeIsvState(request: WriteIsvStateRequest): Promise<WriteIsvStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WriteIsvStateHeaders({ });
    return await this.writeIsvStateWithOptions(request, headers, runtime);
  }

  async writeIsvStateWithOptions(request: WriteIsvStateRequest, headers: WriteIsvStateHeaders, runtime: $Util.RuntimeOptions): Promise<WriteIsvStateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvName)) {
      query["isvName"] = request.isvName;
    }

    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
    return $tea.cast<WriteIsvStateResponse>(await this.doROARequest("WriteIsvState", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/datas/states/write`, "json", req, runtime), new WriteIsvStateResponse({}));
  }

  async writeOrgCarbon(request: WriteOrgCarbonRequest): Promise<WriteOrgCarbonResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WriteOrgCarbonHeaders({ });
    return await this.writeOrgCarbonWithOptions(request, headers, runtime);
  }

  async writeOrgCarbonWithOptions(request: WriteOrgCarbonRequest, headers: WriteOrgCarbonHeaders, runtime: $Util.RuntimeOptions): Promise<WriteOrgCarbonResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orgDetailsList)) {
      body["orgDetailsList"] = request.orgDetailsList;
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
    return $tea.cast<WriteOrgCarbonResponse>(await this.doROARequest("WriteOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/orgDetails/write`, "json", req, runtime), new WriteOrgCarbonResponse({}));
  }

  async writeUserCarbon(request: WriteUserCarbonRequest): Promise<WriteUserCarbonResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WriteUserCarbonHeaders({ });
    return await this.writeUserCarbonWithOptions(request, headers, runtime);
  }

  async writeUserCarbonWithOptions(request: WriteUserCarbonRequest, headers: WriteUserCarbonHeaders, runtime: $Util.RuntimeOptions): Promise<WriteUserCarbonResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userDetailsList)) {
      body["userDetailsList"] = request.userDetailsList;
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
    return $tea.cast<WriteUserCarbonResponse>(await this.doROARequest("WriteUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/userDetails/write`, "json", req, runtime), new WriteUserCarbonResponse({}));
  }

}
