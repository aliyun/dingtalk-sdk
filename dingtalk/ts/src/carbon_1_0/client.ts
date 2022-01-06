// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  success?: boolean;
  result?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'number',
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
  success?: boolean;
  result?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'number',
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
  success?: boolean;
  result?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'number',
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
  success?: boolean;
  result?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'number',
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

export class WriteAlibabaOrgCarbonRequestOrgDetailsList extends $tea.Model {
  actionId?: string;
  corpId?: string;
  deptId?: number;
  actionType?: string;
  carbonAmount?: string;
  actionTime?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionId: 'actionId',
      corpId: 'corpId',
      deptId: 'deptId',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      actionTime: 'actionTime',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionId: 'string',
      corpId: 'string',
      deptId: 'number',
      actionType: 'string',
      carbonAmount: 'string',
      actionTime: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteOrgCarbonRequestOrgDetailsList extends $tea.Model {
  actionId?: string;
  corpId?: string;
  deptId?: number;
  actionType?: string;
  carbonAmount?: string;
  actionTime?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionId: 'actionId',
      corpId: 'corpId',
      deptId: 'deptId',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      actionTime: 'actionTime',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionId: 'string',
      corpId: 'string',
      deptId: 'number',
      actionType: 'string',
      carbonAmount: 'string',
      actionTime: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteUserCarbonRequestUserDetailsList extends $tea.Model {
  actionId?: string;
  userId?: string;
  corpId?: string;
  deptId?: number;
  actionType?: string;
  carbonAmount?: string;
  actionStartTime?: string;
  actionEndTime?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionId: 'actionId',
      userId: 'userId',
      corpId: 'corpId',
      deptId: 'deptId',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      actionStartTime: 'actionStartTime',
      actionEndTime: 'actionEndTime',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionId: 'string',
      userId: 'string',
      corpId: 'string',
      deptId: 'number',
      actionType: 'string',
      carbonAmount: 'string',
      actionStartTime: 'string',
      actionEndTime: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WriteAlibabaUserCarbonRequestUserDetailsList extends $tea.Model {
  actionId?: string;
  userId?: string;
  corpId?: string;
  deptId?: number;
  actionType?: string;
  carbonAmount?: string;
  actionStartTime?: string;
  actionEndTime?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionId: 'actionId',
      userId: 'userId',
      corpId: 'corpId',
      deptId: 'deptId',
      actionType: 'actionType',
      carbonAmount: 'carbonAmount',
      actionStartTime: 'actionStartTime',
      actionEndTime: 'actionEndTime',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionId: 'string',
      userId: 'string',
      corpId: 'string',
      deptId: 'number',
      actionType: 'string',
      carbonAmount: 'string',
      actionStartTime: 'string',
      actionEndTime: 'string',
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<WriteAlibabaOrgCarbonResponse>(await this.doROARequest("WriteAlibabaOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/alibabaOrgDetails/write`, "json", req, runtime), new WriteAlibabaOrgCarbonResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<WriteUserCarbonResponse>(await this.doROARequest("WriteUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/userDetails/write`, "json", req, runtime), new WriteUserCarbonResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<WriteAlibabaUserCarbonResponse>(await this.doROARequest("WriteAlibabaUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", `/v1.0/carbon/alibabaUserDetails/write`, "json", req, runtime), new WriteAlibabaUserCarbonResponse({}));
  }

}