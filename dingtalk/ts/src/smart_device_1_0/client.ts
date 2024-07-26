// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateDeviceVideoConferenceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  mediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExtractFacialFeatureResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @example
   * 165441111
   */
  deviceId?: number;
  scopeDeptIds?: number[];
  /**
   * @example
   * user01
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @remarks
   * This parameter is required.
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDeviceVideoConferenceBookResponseBody;
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
      body: QueryDeviceVideoConferenceBookResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TextToImageHeaders extends $tea.Model {
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

export class TextToImageRequest extends $tea.Model {
  modelId?: string;
  /**
   * @example
   * 1
   */
  pictureNum?: number;
  /**
   * @example
   * 1024*1024
   */
  pictureSize?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 帮我生成一个小猫在草坪上奔跑的图片
   */
  query?: string;
  static names(): { [key: string]: string } {
    return {
      modelId: 'modelId',
      pictureNum: 'pictureNum',
      pictureSize: 'pictureSize',
      query: 'query',
    };
  }

  static types(): { [key: string]: any } {
    return {
      modelId: 'string',
      pictureNum: 'number',
      pictureSize: 'string',
      query: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TextToImageResponseBody extends $tea.Model {
  result?: TextToImageResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: TextToImageResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TextToImageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TextToImageResponseBody;
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
      body: TextToImageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VoiceCloneHeaders extends $tea.Model {
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

export class VoiceCloneRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 你好，我叫小智，是来自阿里云的超大规模语言模型。我是一个能够回答问题、创作文字，还能表达观点、撰写代码的全能型AI助手。如果您有任何问题或需要帮助，请随时告诉我，我会尽我所能为您提供帮助！
   */
  text?: string;
  /**
   * @example
   * manager4224
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qhtestvoice-01
   */
  voiceId?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      userId: 'userId',
      voiceId: 'voiceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      userId: 'string',
      voiceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VoiceCloneResponseBody extends $tea.Model {
  result?: VoiceCloneResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: VoiceCloneResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VoiceCloneResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: VoiceCloneResponseBody;
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
      body: VoiceCloneResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MachineManagerUpdateRequestAtmManagerRightMap extends $tea.Model {
  /**
   * @example
   * true
   */
  attendancePersonManage?: boolean;
  /**
   * @example
   * true
   */
  bluetoothPunchManage?: boolean;
  /**
   * @example
   * true
   */
  deviceReset?: boolean;
  /**
   * @example
   * true
   */
  deviceSettings?: boolean;
  /**
   * @example
   * true
   */
  facePunchManage?: boolean;
  /**
   * @example
   * true
   */
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

export class TextToImageResponseBodyResult extends $tea.Model {
  requestId?: string;
  taskId?: string;
  taskStatus?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      taskId: 'taskId',
      taskStatus: 'taskStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      taskId: 'string',
      taskStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VoiceCloneResponseBodyResult extends $tea.Model {
  /**
   * @example
   * https://xxxx
   */
  mediaUrl?: string;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      mediaUrl: 'mediaUrl',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaUrl: 'string',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 添加硬件视频会议参会人
   * 
   * @param request - AddDeviceVideoConferenceMembersRequest
   * @param headers - AddDeviceVideoConferenceMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddDeviceVideoConferenceMembersResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddDeviceVideoConferenceMembers",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/devices/${deviceId}/videoConferences/${conferenceId}/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "none",
    });
    return $tea.cast<AddDeviceVideoConferenceMembersResponse>(await this.execute(params, req, runtime), new AddDeviceVideoConferenceMembersResponse({}));
  }

  /**
   * 添加硬件视频会议参会人
   * 
   * @param request - AddDeviceVideoConferenceMembersRequest
   * @returns AddDeviceVideoConferenceMembersResponse
   */
  async addDeviceVideoConferenceMembers(deviceId: string, conferenceId: string, request: AddDeviceVideoConferenceMembersRequest): Promise<AddDeviceVideoConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddDeviceVideoConferenceMembersHeaders({ });
    return await this.addDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
  }

  /**
   * 创建硬件视频会议
   * 
   * @param request - CreateDeviceVideoConferenceRequest
   * @param headers - CreateDeviceVideoConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDeviceVideoConferenceResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateDeviceVideoConference",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/devices/${deviceId}/videoConferences`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateDeviceVideoConferenceResponse>(await this.execute(params, req, runtime), new CreateDeviceVideoConferenceResponse({}));
  }

  /**
   * 创建硬件视频会议
   * 
   * @param request - CreateDeviceVideoConferenceRequest
   * @returns CreateDeviceVideoConferenceResponse
   */
  async createDeviceVideoConference(deviceId: string, request: CreateDeviceVideoConferenceRequest): Promise<CreateDeviceVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeviceVideoConferenceHeaders({ });
    return await this.createDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
  }

  /**
   * 基于企业员工照片为终端提取人脸识别特征
   * 
   * @param request - ExtractFacialFeatureRequest
   * @param headers - ExtractFacialFeatureHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExtractFacialFeatureResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ExtractFacialFeature",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/faceRecognitions/features/extract`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ExtractFacialFeatureResponse>(await this.execute(params, req, runtime), new ExtractFacialFeatureResponse({}));
  }

  /**
   * 基于企业员工照片为终端提取人脸识别特征
   * 
   * @param request - ExtractFacialFeatureRequest
   * @returns ExtractFacialFeatureResponse
   */
  async extractFacialFeature(request: ExtractFacialFeatureRequest): Promise<ExtractFacialFeatureResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExtractFacialFeatureHeaders({ });
    return await this.extractFacialFeatureWithOptions(request, headers, runtime);
  }

  /**
   * 踢出硬件视频会议参会人
   * 
   * @param request - KickDeviceVideoConferenceMembersRequest
   * @param headers - KickDeviceVideoConferenceMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns KickDeviceVideoConferenceMembersResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "KickDeviceVideoConferenceMembers",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/devices/${deviceId}/videoConferences/${conferenceId}/members/batchDelete`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "none",
    });
    return $tea.cast<KickDeviceVideoConferenceMembersResponse>(await this.execute(params, req, runtime), new KickDeviceVideoConferenceMembersResponse({}));
  }

  /**
   * 踢出硬件视频会议参会人
   * 
   * @param request - KickDeviceVideoConferenceMembersRequest
   * @returns KickDeviceVideoConferenceMembersResponse
   */
  async kickDeviceVideoConferenceMembers(deviceId: string, conferenceId: string, request: KickDeviceVideoConferenceMembersRequest): Promise<KickDeviceVideoConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new KickDeviceVideoConferenceMembersHeaders({ });
    return await this.kickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
  }

  /**
   * 变更智能考勤机设备管理员
   * 
   * @param request - MachineManagerUpdateRequest
   * @param headers - MachineManagerUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MachineManagerUpdateResponse
   */
  async machineManagerUpdateWithOptions(request: MachineManagerUpdateRequest, headers: MachineManagerUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<MachineManagerUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atmManagerRightMap)) {
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
    let params = new $OpenApi.Params({
      action: "MachineManagerUpdate",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/atmachines/managers`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<MachineManagerUpdateResponse>(await this.execute(params, req, runtime), new MachineManagerUpdateResponse({}));
  }

  /**
   * 变更智能考勤机设备管理员
   * 
   * @param request - MachineManagerUpdateRequest
   * @returns MachineManagerUpdateResponse
   */
  async machineManagerUpdate(request: MachineManagerUpdateRequest): Promise<MachineManagerUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MachineManagerUpdateHeaders({ });
    return await this.machineManagerUpdateWithOptions(request, headers, runtime);
  }

  /**
   * 变更智能考勤机员工
   * 
   * @param request - MachineUsersUpdateRequest
   * @param headers - MachineUsersUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MachineUsersUpdateResponse
   */
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
    let params = new $OpenApi.Params({
      action: "MachineUsersUpdate",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/atmachines/users`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<MachineUsersUpdateResponse>(await this.execute(params, req, runtime), new MachineUsersUpdateResponse({}));
  }

  /**
   * 变更智能考勤机员工
   * 
   * @param request - MachineUsersUpdateRequest
   * @returns MachineUsersUpdateResponse
   */
  async machineUsersUpdate(request: MachineUsersUpdateRequest): Promise<MachineUsersUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MachineUsersUpdateHeaders({ });
    return await this.machineUsersUpdateWithOptions(request, headers, runtime);
  }

  /**
   * 查询硬件视频会议预约信息
   * 
   * @param headers - QueryDeviceVideoConferenceBookHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDeviceVideoConferenceBookResponse
   */
  async queryDeviceVideoConferenceBookWithOptions(deviceId: string, bookId: string, headers: QueryDeviceVideoConferenceBookHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceVideoConferenceBookResponse> {
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
      action: "QueryDeviceVideoConferenceBook",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/devices/${deviceId}/books/${bookId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceVideoConferenceBookResponse>(await this.execute(params, req, runtime), new QueryDeviceVideoConferenceBookResponse({}));
  }

  /**
   * 查询硬件视频会议预约信息
   * @returns QueryDeviceVideoConferenceBookResponse
   */
  async queryDeviceVideoConferenceBook(deviceId: string, bookId: string): Promise<QueryDeviceVideoConferenceBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceVideoConferenceBookHeaders({ });
    return await this.queryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
  }

  /**
   * 文生图开放接口
   * 
   * @param request - TextToImageRequest
   * @param headers - TextToImageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TextToImageResponse
   */
  async textToImageWithOptions(request: TextToImageRequest, headers: TextToImageHeaders, runtime: $Util.RuntimeOptions): Promise<TextToImageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.modelId)) {
      body["modelId"] = request.modelId;
    }

    if (!Util.isUnset(request.pictureNum)) {
      body["pictureNum"] = request.pictureNum;
    }

    if (!Util.isUnset(request.pictureSize)) {
      body["pictureSize"] = request.pictureSize;
    }

    if (!Util.isUnset(request.query)) {
      body["query"] = request.query;
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
      action: "TextToImage",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/textToImages/generate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TextToImageResponse>(await this.execute(params, req, runtime), new TextToImageResponse({}));
  }

  /**
   * 文生图开放接口
   * 
   * @param request - TextToImageRequest
   * @returns TextToImageResponse
   */
  async textToImage(request: TextToImageRequest): Promise<TextToImageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TextToImageHeaders({ });
    return await this.textToImageWithOptions(request, headers, runtime);
  }

  /**
   * 音频复刻
   * 
   * @param request - VoiceCloneRequest
   * @param headers - VoiceCloneHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns VoiceCloneResponse
   */
  async voiceCloneWithOptions(request: VoiceCloneRequest, headers: VoiceCloneHeaders, runtime: $Util.RuntimeOptions): Promise<VoiceCloneResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.text)) {
      body["text"] = request.text;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.voiceId)) {
      body["voiceId"] = request.voiceId;
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
      action: "VoiceClone",
      version: "smartDevice_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/smartDevice/voices/clone`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<VoiceCloneResponse>(await this.execute(params, req, runtime), new VoiceCloneResponse({}));
  }

  /**
   * 音频复刻
   * 
   * @param request - VoiceCloneRequest
   * @returns VoiceCloneResponse
   */
  async voiceClone(request: VoiceCloneRequest): Promise<VoiceCloneResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new VoiceCloneHeaders({ });
    return await this.voiceCloneWithOptions(request, headers, runtime);
  }

}
