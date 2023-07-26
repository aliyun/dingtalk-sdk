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

export class UnionIdPrivateDataMapValue extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserIdPrivateDataMapValue extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopboxHeaders extends $tea.Model {
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

export class CloseTopboxRequest extends $tea.Model {
  conversationType?: number;
  coolAppCode?: string;
  groupTemplateId?: string;
  openConversationId?: string;
  outTrackId?: string;
  robotCode?: string;
  unoinId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationType: 'conversationType',
      coolAppCode: 'coolAppCode',
      groupTemplateId: 'groupTemplateId',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      robotCode: 'robotCode',
      unoinId: 'unoinId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationType: 'number',
      coolAppCode: 'string',
      groupTemplateId: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
      robotCode: 'string',
      unoinId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopboxResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopboxResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CloseTopboxResponseBody;
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
      body: CloseTopboxResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupHeaders extends $tea.Model {
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

export class CreateCoupleGroupRequest extends $tea.Model {
  groupTemplateId?: string;
  operatorId?: string;
  users?: CreateCoupleGroupRequestUsers[];
  static names(): { [key: string]: string } {
    return {
      groupTemplateId: 'groupTemplateId',
      operatorId: 'operatorId',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupTemplateId: 'string',
      operatorId: 'string',
      users: { 'type': 'array', 'itemType': CreateCoupleGroupRequestUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupResponseBody extends $tea.Model {
  appUserIds?: string[];
  conversationId?: string;
  openConversationId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      conversationId: 'conversationId',
      openConversationId: 'openConversationId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      conversationId: 'string',
      openConversationId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateCoupleGroupResponseBody;
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
      body: CreateCoupleGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupHeaders extends $tea.Model {
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

export class CreateGroupRequest extends $tea.Model {
  groupAvatar?: string;
  groupName?: string;
  groupTemplateId?: string;
  operatorId?: string;
  users?: CreateGroupRequestUsers[];
  static names(): { [key: string]: string } {
    return {
      groupAvatar: 'groupAvatar',
      groupName: 'groupName',
      groupTemplateId: 'groupTemplateId',
      operatorId: 'operatorId',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupAvatar: 'string',
      groupName: 'string',
      groupTemplateId: 'string',
      operatorId: 'string',
      users: { 'type': 'array', 'itemType': CreateGroupRequestUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponseBody extends $tea.Model {
  appUserIds?: string[];
  conversationId?: string;
  openConversationId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      conversationId: 'conversationId',
      openConversationId: 'openConversationId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      conversationId: 'string',
      openConversationId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateGroupResponseBody;
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
      body: CreateGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTopboxHeaders extends $tea.Model {
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

export class CreateTopboxRequest extends $tea.Model {
  callbackRouteKey?: string;
  cardData?: CreateTopboxRequestCardData;
  cardSettings?: CreateTopboxRequestCardSettings;
  cardTemplateId?: string;
  conversationType?: number;
  coolAppCode?: string;
  expiredTime?: number;
  groupTemplateId?: string;
  openConversationId?: string;
  outTrackId?: string;
  platforms?: string;
  receiverUnionIdList?: string[];
  receiverUserIdList?: string[];
  robotCode?: string;
  unionIdPrivateDataMap?: { [key: string]: UnionIdPrivateDataMapValue };
  unoinId?: string;
  userId?: string;
  userIdPrivateDataMap?: { [key: string]: UserIdPrivateDataMapValue };
  static names(): { [key: string]: string } {
    return {
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardSettings: 'cardSettings',
      cardTemplateId: 'cardTemplateId',
      conversationType: 'conversationType',
      coolAppCode: 'coolAppCode',
      expiredTime: 'expiredTime',
      groupTemplateId: 'groupTemplateId',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      platforms: 'platforms',
      receiverUnionIdList: 'receiverUnionIdList',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
      unionIdPrivateDataMap: 'unionIdPrivateDataMap',
      unoinId: 'unoinId',
      userId: 'userId',
      userIdPrivateDataMap: 'userIdPrivateDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackRouteKey: 'string',
      cardData: CreateTopboxRequestCardData,
      cardSettings: CreateTopboxRequestCardSettings,
      cardTemplateId: 'string',
      conversationType: 'number',
      coolAppCode: 'string',
      expiredTime: 'number',
      groupTemplateId: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
      platforms: 'string',
      receiverUnionIdList: { 'type': 'array', 'itemType': 'string' },
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
      unionIdPrivateDataMap: { 'type': 'map', 'keyType': 'string', 'valueType': UnionIdPrivateDataMapValue },
      unoinId: 'string',
      userId: 'string',
      userIdPrivateDataMap: { 'type': 'map', 'keyType': 'string', 'valueType': UserIdPrivateDataMapValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTopboxResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTopboxResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateTopboxResponseBody;
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
      body: CreateTopboxResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManagerDeviceMarketResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManagerDeviceMarketResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GroupManagerDeviceMarketResponseBody;
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
      body: GroupManagerDeviceMarketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupRequestUsers extends $tea.Model {
  appUserId?: string;
  groupOwner?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      groupOwner: 'groupOwner',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      groupOwner: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupRequestUsers extends $tea.Model {
  appUserId?: string;
  groupOwner?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      groupOwner: 'groupOwner',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      groupOwner: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTopboxRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTopboxRequestCardSettings extends $tea.Model {
  pullStrategy?: boolean;
  static names(): { [key: string]: string } {
    return {
      pullStrategy: 'pullStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pullStrategy: 'boolean',
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
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async closeTopboxWithOptions(request: CloseTopboxRequest, headers: CloseTopboxHeaders, runtime: $Util.RuntimeOptions): Promise<CloseTopboxResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.unoinId)) {
      body["unoinId"] = request.unoinId;
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
      action: "CloseTopbox",
      version: "im_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/im/topBoxes/close`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CloseTopboxResponse>(await this.execute(params, req, runtime), new CloseTopboxResponse({}));
  }

  async closeTopbox(request: CloseTopboxRequest): Promise<CloseTopboxResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseTopboxHeaders({ });
    return await this.closeTopboxWithOptions(request, headers, runtime);
  }

  async createCoupleGroupWithOptions(request: CreateCoupleGroupRequest, headers: CreateCoupleGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCoupleGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.users)) {
      body["users"] = request.users;
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
      action: "CreateCoupleGroup",
      version: "im_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/im/interconnections/couples/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCoupleGroupResponse>(await this.execute(params, req, runtime), new CreateCoupleGroupResponse({}));
  }

  async createCoupleGroup(request: CreateCoupleGroupRequest): Promise<CreateCoupleGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCoupleGroupHeaders({ });
    return await this.createCoupleGroupWithOptions(request, headers, runtime);
  }

  async createGroupWithOptions(request: CreateGroupRequest, headers: CreateGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupAvatar)) {
      body["groupAvatar"] = request.groupAvatar;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.users)) {
      body["users"] = request.users;
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
      action: "CreateGroup",
      version: "im_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/im/interconnections/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupResponse>(await this.execute(params, req, runtime), new CreateGroupResponse({}));
  }

  async createGroup(request: CreateGroupRequest): Promise<CreateGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupHeaders({ });
    return await this.createGroupWithOptions(request, headers, runtime);
  }

  async createTopboxWithOptions(request: CreateTopboxRequest, headers: CreateTopboxHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTopboxResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardSettings)) {
      body["cardSettings"] = request.cardSettings;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.expiredTime)) {
      body["expiredTime"] = request.expiredTime;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.platforms)) {
      body["platforms"] = request.platforms;
    }

    if (!Util.isUnset(request.receiverUnionIdList)) {
      body["receiverUnionIdList"] = request.receiverUnionIdList;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.unionIdPrivateDataMap)) {
      body["unionIdPrivateDataMap"] = request.unionIdPrivateDataMap;
    }

    if (!Util.isUnset(request.unoinId)) {
      body["unoinId"] = request.unoinId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userIdPrivateDataMap)) {
      body["userIdPrivateDataMap"] = request.userIdPrivateDataMap;
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
      action: "CreateTopbox",
      version: "im_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/im/topBoxes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTopboxResponse>(await this.execute(params, req, runtime), new CreateTopboxResponse({}));
  }

  async createTopbox(request: CreateTopboxRequest): Promise<CreateTopboxResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTopboxHeaders({ });
    return await this.createTopboxWithOptions(request, headers, runtime);
  }

  async groupManagerDeviceMarketWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GroupManagerDeviceMarketResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "GroupManagerDeviceMarket",
      version: "im_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/im/group/device/market/manager`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupManagerDeviceMarketResponse>(await this.execute(params, req, runtime), new GroupManagerDeviceMarketResponse({}));
  }

  async groupManagerDeviceMarket(): Promise<GroupManagerDeviceMarketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.groupManagerDeviceMarketWithOptions(headers, runtime);
  }

}
