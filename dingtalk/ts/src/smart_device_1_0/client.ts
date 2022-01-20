// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  mediaId?: string;
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      userid: 'string',
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
  atmManagerRightMap?: MachineManagerUpdateRequestAtmManagerRightMap;
  deviceId?: number;
  scopeDeptIds?: number[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      atmManagerRightMap: 'atmManagerRightMap',
      deviceId: 'deviceId',
      scopeDeptIds: 'scopeDeptIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atmManagerRightMap: MachineManagerUpdateRequestAtmManagerRightMap,
      deviceId: 'number',
      scopeDeptIds: { 'type': 'array', 'itemType': 'number' },
      userId: 'string',
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
  addDeptIds?: number[];
  addUserIds?: string[];
  delDeptIds?: number[];
  delUserIds?: string[];
  devIds?: number[];
  deviceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      addDeptIds: 'addDeptIds',
      addUserIds: 'addUserIds',
      delDeptIds: 'delDeptIds',
      delUserIds: 'delUserIds',
      devIds: 'devIds',
      deviceIds: 'deviceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addDeptIds: { 'type': 'array', 'itemType': 'number' },
      addUserIds: { 'type': 'array', 'itemType': 'string' },
      delDeptIds: { 'type': 'array', 'itemType': 'number' },
      delUserIds: { 'type': 'array', 'itemType': 'string' },
      devIds: { 'type': 'array', 'itemType': 'number' },
      deviceIds: { 'type': 'array', 'itemType': 'string' },
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

export class MachineManagerUpdateRequestAtmManagerRightMap extends $tea.Model {
  attendancePersonManage?: boolean;
  bluetoothPunchManage?: boolean;
  deviceReset?: boolean;
  deviceSettings?: boolean;
  facePunchManage?: boolean;
  fingerPunchManage?: boolean;
  static names(): { [key: string]: string } {
    return {
      attendancePersonManage: 'attendancePersonManage',
      bluetoothPunchManage: 'bluetoothPunchManage',
      deviceReset: 'deviceReset',
      deviceSettings: 'deviceSettings',
      facePunchManage: 'facePunchManage',
      fingerPunchManage: 'fingerPunchManage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendancePersonManage: 'boolean',
      bluetoothPunchManage: 'boolean',
      deviceReset: 'boolean',
      deviceSettings: 'boolean',
      facePunchManage: 'boolean',
      fingerPunchManage: 'boolean',
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


  async addDeviceVideoConferenceMembers(deviceId: string, conferenceId: string, request: AddDeviceVideoConferenceMembersRequest): Promise<AddDeviceVideoConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddDeviceVideoConferenceMembersHeaders({ });
    return await this.addDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
  }

  async addDeviceVideoConferenceMembersWithOptions(deviceId: string, conferenceId: string, request: AddDeviceVideoConferenceMembersRequest, headers: AddDeviceVideoConferenceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddDeviceVideoConferenceMembersResponse> {
    Util.validateModel(request);
    deviceId = OpenApiUtil.getEncodeParam(deviceId);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<AddDeviceVideoConferenceMembersResponse>(await this.doROARequest("AddDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/devices/${deviceId}/videoConferences/${conferenceId}/members`, "none", req, runtime), new AddDeviceVideoConferenceMembersResponse({}));
  }

  async createDeviceVideoConference(deviceId: string, request: CreateDeviceVideoConferenceRequest): Promise<CreateDeviceVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeviceVideoConferenceHeaders({ });
    return await this.createDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
  }

  async createDeviceVideoConferenceWithOptions(deviceId: string, request: CreateDeviceVideoConferenceRequest, headers: CreateDeviceVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeviceVideoConferenceResponse> {
    Util.validateModel(request);
    deviceId = OpenApiUtil.getEncodeParam(deviceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<CreateDeviceVideoConferenceResponse>(await this.doROARequest("CreateDeviceVideoConference", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/devices/${deviceId}/videoConferences`, "json", req, runtime), new CreateDeviceVideoConferenceResponse({}));
  }

  async extractFacialFeature(request: ExtractFacialFeatureRequest): Promise<ExtractFacialFeatureResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExtractFacialFeatureHeaders({ });
    return await this.extractFacialFeatureWithOptions(request, headers, runtime);
  }

  async extractFacialFeatureWithOptions(request: ExtractFacialFeatureRequest, headers: ExtractFacialFeatureHeaders, runtime: $Util.RuntimeOptions): Promise<ExtractFacialFeatureResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
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
    return $tea.cast<ExtractFacialFeatureResponse>(await this.doROARequest("ExtractFacialFeature", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/faceRecognitions/features/extract`, "json", req, runtime), new ExtractFacialFeatureResponse({}));
  }

  async kickDeviceVideoConferenceMembers(deviceId: string, conferenceId: string, request: KickDeviceVideoConferenceMembersRequest): Promise<KickDeviceVideoConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new KickDeviceVideoConferenceMembersHeaders({ });
    return await this.kickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
  }

  async kickDeviceVideoConferenceMembersWithOptions(deviceId: string, conferenceId: string, request: KickDeviceVideoConferenceMembersRequest, headers: KickDeviceVideoConferenceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<KickDeviceVideoConferenceMembersResponse> {
    Util.validateModel(request);
    deviceId = OpenApiUtil.getEncodeParam(deviceId);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<KickDeviceVideoConferenceMembersResponse>(await this.doROARequest("KickDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", `/v1.0/smartDevice/devices/${deviceId}/videoConferences/${conferenceId}/members/batchDelete`, "none", req, runtime), new KickDeviceVideoConferenceMembersResponse({}));
  }

  async machineManagerUpdate(request: MachineManagerUpdateRequest): Promise<MachineManagerUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MachineManagerUpdateHeaders({ });
    return await this.machineManagerUpdateWithOptions(request, headers, runtime);
  }

  async machineManagerUpdateWithOptions(request: MachineManagerUpdateRequest, headers: MachineManagerUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<MachineManagerUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.atmManagerRightMap))) {
      body["atmManagerRightMap"] = request.atmManagerRightMap;
    }

    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.scopeDeptIds)) {
      body["scopeDeptIds"] = request.scopeDeptIds;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<MachineManagerUpdateResponse>(await this.doROARequest("MachineManagerUpdate", "smartDevice_1.0", "HTTP", "PUT", "AK", `/v1.0/smartDevice/atmachines/managers`, "none", req, runtime), new MachineManagerUpdateResponse({}));
  }

  async machineUsersUpdate(request: MachineUsersUpdateRequest): Promise<MachineUsersUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MachineUsersUpdateHeaders({ });
    return await this.machineUsersUpdateWithOptions(request, headers, runtime);
  }

  async machineUsersUpdateWithOptions(request: MachineUsersUpdateRequest, headers: MachineUsersUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<MachineUsersUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addDeptIds)) {
      body["addDeptIds"] = request.addDeptIds;
    }

    if (!Util.isUnset(request.addUserIds)) {
      body["addUserIds"] = request.addUserIds;
    }

    if (!Util.isUnset(request.delDeptIds)) {
      body["delDeptIds"] = request.delDeptIds;
    }

    if (!Util.isUnset(request.delUserIds)) {
      body["delUserIds"] = request.delUserIds;
    }

    if (!Util.isUnset(request.devIds)) {
      body["devIds"] = request.devIds;
    }

    if (!Util.isUnset(request.deviceIds)) {
      body["deviceIds"] = request.deviceIds;
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
    return $tea.cast<MachineUsersUpdateResponse>(await this.doROARequest("MachineUsersUpdate", "smartDevice_1.0", "HTTP", "PUT", "AK", `/v1.0/smartDevice/atmachines/users`, "none", req, runtime), new MachineUsersUpdateResponse({}));
  }

  async queryDeviceVideoConferenceBook(deviceId: string, bookId: string): Promise<QueryDeviceVideoConferenceBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceVideoConferenceBookHeaders({ });
    return await this.queryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
  }

  async queryDeviceVideoConferenceBookWithOptions(deviceId: string, bookId: string, headers: QueryDeviceVideoConferenceBookHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceVideoConferenceBookResponse> {
    deviceId = OpenApiUtil.getEncodeParam(deviceId);
    bookId = OpenApiUtil.getEncodeParam(bookId);
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
    return $tea.cast<QueryDeviceVideoConferenceBookResponse>(await this.doROARequest("QueryDeviceVideoConferenceBook", "smartDevice_1.0", "HTTP", "GET", "AK", `/v1.0/smartDevice/devices/${deviceId}/books/${bookId}`, "json", req, runtime), new QueryDeviceVideoConferenceBookResponse({}));
  }

}
