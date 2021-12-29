// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class MachineUsersUpdateHeaders extends $tea.Model {
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

export class MachineUsersUpdateRequest extends $tea.Model {
  delUserIds?: string[];
  deviceIds?: string[];
  addUserIds?: string[];
  devIds?: number[];
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      delUserIds: 'delUserIds',
      deviceIds: 'deviceIds',
      addUserIds: 'addUserIds',
      devIds: 'devIds',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delUserIds: { 'type': 'array', 'itemType': 'string' },
      deviceIds: { 'type': 'array', 'itemType': 'string' },
      addUserIds: { 'type': 'array', 'itemType': 'string' },
      devIds: { 'type': 'array', 'itemType': 'number' },
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MachineUsersUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDeviceVideoConferenceMembersHeaders extends $tea.Model {
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

export class AddDeviceVideoConferenceMembersRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDeviceVideoConferenceMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceVideoConferenceHeaders extends $tea.Model {
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

export class CreateDeviceVideoConferenceRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceVideoConferenceResponseBody extends $tea.Model {
  conferenceId?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateDeviceVideoConferenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateDeviceVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceVideoConferenceBookHeaders extends $tea.Model {
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

export class QueryDeviceVideoConferenceBookResponseBody extends $tea.Model {
  code?: string;
  conferenceId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      conferenceId: 'conferenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      conferenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceVideoConferenceBookResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDeviceVideoConferenceBookResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDeviceVideoConferenceBookResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MachineManagerUpdateHeaders extends $tea.Model {
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

export class MachineManagerUpdateRequest extends $tea.Model {
  deviceId?: number;
  userId?: string;
  scopeDeptIds?: number[];
  atmManagerRightMap?: { [key: string]: boolean };
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      userId: 'userId',
      scopeDeptIds: 'scopeDeptIds',
      atmManagerRightMap: 'atmManagerRightMap',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'number',
      userId: 'string',
      scopeDeptIds: { 'type': 'array', 'itemType': 'number' },
      atmManagerRightMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'boolean' },
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MachineManagerUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickDeviceVideoConferenceMembersHeaders extends $tea.Model {
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

export class KickDeviceVideoConferenceMembersRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickDeviceVideoConferenceMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExtractFacialFeatureHeaders extends $tea.Model {
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

export class ExtractFacialFeatureRequest extends $tea.Model {
  userid?: string;
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      userid: 'userid',
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userid: 'string',
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExtractFacialFeatureResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExtractFacialFeatureResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExtractFacialFeatureResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExtractFacialFeatureResponseBody,
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


  async machineUsersUpdate(request: MachineUsersUpdateRequest): Promise<MachineUsersUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MachineUsersUpdateHeaders({ });
    return await this.machineUsersUpdateWithOptions(request, headers, runtime);
  }

  async machineUsersUpdateWithOptions(request: MachineUsersUpdateRequest, headers: MachineUsersUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<MachineUsersUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.delUserIds)) {
      body["delUserIds"] = request.delUserIds;
    }

    if (!Util.isUnset(request.deviceIds)) {
      body["deviceIds"] = request.deviceIds;
    }

    if (!Util.isUnset(request.addUserIds)) {
      body["addUserIds"] = request.addUserIds;
    }

    if (!Util.isUnset(request.devIds)) {
      body["devIds"] = request.devIds;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<MachineUsersUpdateResponse>(await this.doROARequest("MachineUsersUpdate", "smartDevice_1.0", "HTTP", "PUT", "AK", `/v1.0/smartDevice/atmachines/users`, "none", req, runtime), new MachineUsersUpdateResponse({}));
  }

  async addDeviceVideoConferenceMembers(deviceId: string, conferenceId: string, request: AddDeviceVideoConferenceMembersRequest): Promise<AddDeviceVideoConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddDeviceVideoConferenceMembersHeaders({ });
    return await this.addDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
  }

  async addDeviceVideoConferenceMembersWithOptions(deviceId: string, conferenceId: string, request: AddDeviceVideoConferenceMembersRequest, headers: AddDeviceVideoConferenceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddDeviceVideoConferenceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<AddDeviceVideoConferenceMembersResponse>(await this.doROARequest("AddDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/devices/${deviceId}/videoConferences/${conferenceId}/members`, "none", req, runtime), new AddDeviceVideoConferenceMembersResponse({}));
  }

  async createDeviceVideoConference(deviceId: string, request: CreateDeviceVideoConferenceRequest): Promise<CreateDeviceVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeviceVideoConferenceHeaders({ });
    return await this.createDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
  }

  async createDeviceVideoConferenceWithOptions(deviceId: string, request: CreateDeviceVideoConferenceRequest, headers: CreateDeviceVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeviceVideoConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<CreateDeviceVideoConferenceResponse>(await this.doROARequest("CreateDeviceVideoConference", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/devices/${deviceId}/videoConferences`, "json", req, runtime), new CreateDeviceVideoConferenceResponse({}));
  }

  async queryDeviceVideoConferenceBook(deviceId: string, bookId: string): Promise<QueryDeviceVideoConferenceBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceVideoConferenceBookHeaders({ });
    return await this.queryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
  }

  async queryDeviceVideoConferenceBookWithOptions(deviceId: string, bookId: string, headers: QueryDeviceVideoConferenceBookHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceVideoConferenceBookResponse> {
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
    return $tea.cast<QueryDeviceVideoConferenceBookResponse>(await this.doROARequest("QueryDeviceVideoConferenceBook", "smartDevice_1.0", "HTTP", "GET", "AK", `/v1.0/smartDevice/devices/${deviceId}/books/${bookId}`, "json", req, runtime), new QueryDeviceVideoConferenceBookResponse({}));
  }

  async machineManagerUpdate(request: MachineManagerUpdateRequest): Promise<MachineManagerUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MachineManagerUpdateHeaders({ });
    return await this.machineManagerUpdateWithOptions(request, headers, runtime);
  }

  async machineManagerUpdateWithOptions(request: MachineManagerUpdateRequest, headers: MachineManagerUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<MachineManagerUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.scopeDeptIds)) {
      body["scopeDeptIds"] = request.scopeDeptIds;
    }

    if (!Util.isUnset(request.atmManagerRightMap)) {
      body["atmManagerRightMap"] = request.atmManagerRightMap;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<MachineManagerUpdateResponse>(await this.doROARequest("MachineManagerUpdate", "smartDevice_1.0", "HTTP", "PUT", "AK", `/v1.0/smartDevice/atmachines/managers`, "none", req, runtime), new MachineManagerUpdateResponse({}));
  }

  async kickDeviceVideoConferenceMembers(deviceId: string, conferenceId: string, request: KickDeviceVideoConferenceMembersRequest): Promise<KickDeviceVideoConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new KickDeviceVideoConferenceMembersHeaders({ });
    return await this.kickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
  }

  async kickDeviceVideoConferenceMembersWithOptions(deviceId: string, conferenceId: string, request: KickDeviceVideoConferenceMembersRequest, headers: KickDeviceVideoConferenceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<KickDeviceVideoConferenceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<KickDeviceVideoConferenceMembersResponse>(await this.doROARequest("KickDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/devices/${deviceId}/videoConferences/${conferenceId}/members/batchDelete`, "none", req, runtime), new KickDeviceVideoConferenceMembersResponse({}));
  }

  async extractFacialFeature(request: ExtractFacialFeatureRequest): Promise<ExtractFacialFeatureResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExtractFacialFeatureHeaders({ });
    return await this.extractFacialFeatureWithOptions(request, headers, runtime);
  }

  async extractFacialFeatureWithOptions(request: ExtractFacialFeatureRequest, headers: ExtractFacialFeatureHeaders, runtime: $Util.RuntimeOptions): Promise<ExtractFacialFeatureResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
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
    return $tea.cast<ExtractFacialFeatureResponse>(await this.doROARequest("ExtractFacialFeature", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/faceRecognitions/features/extract`, "json", req, runtime), new ExtractFacialFeatureResponse({}));
  }

}
