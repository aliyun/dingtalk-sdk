// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetApplyInviteInfoHeaders extends $tea.Model {
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

export class GetApplyInviteInfoRequest extends $tea.Model {
  inviterUserId?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      inviterUserId: 'inviterUserId',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviterUserId: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoResponseBody extends $tea.Model {
  inviteSwitch?: boolean;
  searchNameInvite?: boolean;
  orgApplyCodeInvite?: boolean;
  linkInvite?: boolean;
  inviteUrl?: string;
  auditType?: number;
  empApplyJoinDept?: boolean;
  static names(): { [key: string]: string } {
    return {
      inviteSwitch: 'inviteSwitch',
      searchNameInvite: 'searchNameInvite',
      orgApplyCodeInvite: 'orgApplyCodeInvite',
      linkInvite: 'linkInvite',
      inviteUrl: 'inviteUrl',
      auditType: 'auditType',
      empApplyJoinDept: 'empApplyJoinDept',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteSwitch: 'boolean',
      searchNameInvite: 'boolean',
      orgApplyCodeInvite: 'boolean',
      linkInvite: 'boolean',
      inviteUrl: 'string',
      auditType: 'number',
      empApplyJoinDept: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetApplyInviteInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetApplyInviteInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataHeaders extends $tea.Model {
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

export class GetBranchAuthDataRequest extends $tea.Model {
  branchCorpId?: string;
  code?: string;
  body?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      branchCorpId: 'branchCorpId',
      code: 'code',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      branchCorpId: 'string',
      code: 'string',
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponseBody extends $tea.Model {
  result?: GetBranchAuthDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetBranchAuthDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetBranchAuthDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetBranchAuthDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexHeaders extends $tea.Model {
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

export class GetLatestDingIndexResponseBody extends $tea.Model {
  statDate?: string;
  idxTotal?: number;
  idxEfficiency?: number;
  idxCarbon?: number;
  idxMonthlyAvg?: number;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
      idxTotal: 'idxTotal',
      idxEfficiency: 'idxEfficiency',
      idxCarbon: 'idxCarbon',
      idxMonthlyAvg: 'idxMonthlyAvg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
      idxTotal: 'number',
      idxEfficiency: 'number',
      idxCarbon: 'number',
      idxMonthlyAvg: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetLatestDingIndexResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLatestDingIndexResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHeaders extends $tea.Model {
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

export class GetUserResponseBody extends $tea.Model {
  nick?: string;
  avatarUrl?: string;
  mobile?: string;
  openId?: string;
  unionId?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      avatarUrl: 'avatarUrl',
      mobile: 'mobile',
      openId: 'openId',
      unionId: 'unionId',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      avatarUrl: 'string',
      mobile: 'string',
      openId: 'string',
      unionId: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponseBodyResult extends $tea.Model {
  fieldCode?: string;
  fieldName?: string;
  fieldValue?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldValue: 'fieldValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldValue: 'string',
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


  async getApplyInviteInfo(request: GetApplyInviteInfoRequest): Promise<GetApplyInviteInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplyInviteInfoHeaders({ });
    return await this.getApplyInviteInfoWithOptions(request, headers, runtime);
  }

  async getApplyInviteInfoWithOptions(request: GetApplyInviteInfoRequest, headers: GetApplyInviteInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplyInviteInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.inviterUserId)) {
      query["inviterUserId"] = request.inviterUserId;
    }

    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
    return $tea.cast<GetApplyInviteInfoResponse>(await this.doROARequest("GetApplyInviteInfo", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/invites/infos`, "json", req, runtime), new GetApplyInviteInfoResponse({}));
  }

  async getBranchAuthData(request: GetBranchAuthDataRequest): Promise<GetBranchAuthDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBranchAuthDataHeaders({ });
    return await this.getBranchAuthDataWithOptions(request, headers, runtime);
  }

  async getBranchAuthDataWithOptions(request: GetBranchAuthDataRequest, headers: GetBranchAuthDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetBranchAuthDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.branchCorpId)) {
      query["branchCorpId"] = request.branchCorpId;
    }

    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.body)) {
      body["body"] = request.body;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetBranchAuthDataResponse>(await this.doROARequest("GetBranchAuthData", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/branchAuthDatas/search`, "json", req, runtime), new GetBranchAuthDataResponse({}));
  }

  async getLatestDingIndex(): Promise<GetLatestDingIndexResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLatestDingIndexHeaders({ });
    return await this.getLatestDingIndexWithOptions(headers, runtime);
  }

  async getLatestDingIndexWithOptions(headers: GetLatestDingIndexHeaders, runtime: $Util.RuntimeOptions): Promise<GetLatestDingIndexResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetLatestDingIndexResponse>(await this.doROARequest("GetLatestDingIndex", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/dingIndexs`, "json", req, runtime), new GetLatestDingIndexResponse({}));
  }

  async getUser(unionId: string): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(unionId, headers, runtime);
  }

  async getUserWithOptions(unionId: string, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetUserResponse>(await this.doROARequest("GetUser", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/users/${unionId}`, "json", req, runtime), new GetUserResponse({}));
  }

}
