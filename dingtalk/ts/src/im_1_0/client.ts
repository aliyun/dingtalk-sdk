// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class UpdateGroupPermissionHeaders extends $tea.Model {
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

export class UpdateGroupPermissionRequest extends $tea.Model {
  openConversationId?: string;
  permissionGroup?: string;
  status?: string;
  dingTokenGrantType?: number;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingOauthAppId?: number;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      permissionGroup: 'permissionGroup',
      status: 'status',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOauthAppId: 'dingOauthAppId',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      permissionGroup: 'string',
      status: 'string',
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingOauthAppId: 'number',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupPermissionResponseBody extends $tea.Model {
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

export class UpdateGroupPermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateGroupPermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateGroupPermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTheGroupRolesOfGroupMemberHeaders extends $tea.Model {
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

export class UpdateTheGroupRolesOfGroupMemberRequest extends $tea.Model {
  openConversationId?: string;
  userId?: string;
  openRoleIds?: string[];
  dingTokenGrantType?: number;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingOauthAppId?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      userId: 'userId',
      openRoleIds: 'openRoleIds',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingOauthAppId: 'dingOauthAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      userId: 'string',
      openRoleIds: { 'type': 'array', 'itemType': 'string' },
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingOauthAppId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTheGroupRolesOfGroupMemberResponseBody extends $tea.Model {
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

export class UpdateTheGroupRolesOfGroupMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateTheGroupRolesOfGroupMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateTheGroupRolesOfGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardHeaders extends $tea.Model {
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

export class SendInteractiveCardRequest extends $tea.Model {
  dingIsvOrgId?: number;
  cardTemplateId?: string;
  openConversationId?: string;
  receiverUserIdList?: string[];
  dingTokenGrantType?: number;
  outTrackId?: string;
  dingSuiteKey?: string;
  robotCode?: string;
  dingOrgId?: number;
  conversationType?: number;
  callbackRouteKey?: string;
  cardData?: SendInteractiveCardRequestCardData;
  privateData?: { [key: string]: PrivateDataValue };
  dingOauthAppId?: number;
  chatBotId?: string;
  userIdType?: number;
  atOpenIds?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      cardTemplateId: 'cardTemplateId',
      openConversationId: 'openConversationId',
      receiverUserIdList: 'receiverUserIdList',
      dingTokenGrantType: 'dingTokenGrantType',
      outTrackId: 'outTrackId',
      dingSuiteKey: 'dingSuiteKey',
      robotCode: 'robotCode',
      dingOrgId: 'dingOrgId',
      conversationType: 'conversationType',
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      privateData: 'privateData',
      dingOauthAppId: 'dingOauthAppId',
      chatBotId: 'chatBotId',
      userIdType: 'userIdType',
      atOpenIds: 'atOpenIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      cardTemplateId: 'string',
      openConversationId: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      dingTokenGrantType: 'number',
      outTrackId: 'string',
      dingSuiteKey: 'string',
      robotCode: 'string',
      dingOrgId: 'number',
      conversationType: 'number',
      callbackRouteKey: 'string',
      cardData: SendInteractiveCardRequestCardData,
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      dingOauthAppId: 'number',
      chatBotId: 'string',
      userIdType: 'number',
      atOpenIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardResponseBody extends $tea.Model {
  success?: boolean;
  result?: SendInteractiveCardResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: SendInteractiveCardResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardHeaders extends $tea.Model {
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

export class UpdateInteractiveCardRequest extends $tea.Model {
  outTrackId?: string;
  cardData?: UpdateInteractiveCardRequestCardData;
  privateData?: { [key: string]: PrivateDataValue };
  dingTokenGrantType?: number;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingOauthAppId?: number;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      outTrackId: 'outTrackId',
      cardData: 'cardData',
      privateData: 'privateData',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingOauthAppId: 'dingOauthAppId',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTrackId: 'string',
      cardData: UpdateInteractiveCardRequestCardData,
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingOauthAppId: 'number',
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardResponseBody extends $tea.Model {
  success?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMembersOfGroupRoleHeaders extends $tea.Model {
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

export class QueryMembersOfGroupRoleRequest extends $tea.Model {
  openConversationId?: string;
  openRoleId?: string;
  timestamp?: number;
  dingTokenGrantType?: number;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingOauthAppId?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openRoleId: 'openRoleId',
      timestamp: 'timestamp',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingOauthAppId: 'dingOauthAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openRoleId: 'string',
      timestamp: 'number',
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingOauthAppId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMembersOfGroupRoleResponseBody extends $tea.Model {
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

export class QueryMembersOfGroupRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMembersOfGroupRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMembersOfGroupRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateDataValue extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  cardMediaIdParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
      cardMediaIdParamMap: 'cardMediaIdParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  cardMediaIdParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
      cardMediaIdParamMap: 'cardMediaIdParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardResponseBodyResult extends $tea.Model {
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  cardMediaIdParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
      cardMediaIdParamMap: 'cardMediaIdParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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


  async updateGroupPermission(request: UpdateGroupPermissionRequest): Promise<UpdateGroupPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupPermissionHeaders({ });
    return await this.updateGroupPermissionWithOptions(request, headers, runtime);
  }

  async updateGroupPermissionWithOptions(request: UpdateGroupPermissionRequest, headers: UpdateGroupPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupPermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.permissionGroup)) {
      body["permissionGroup"] = request.permissionGroup;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<UpdateGroupPermissionResponse>(await this.doROARequest("UpdateGroupPermission", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/sceneGroups/permissions`, "json", req, runtime), new UpdateGroupPermissionResponse({}));
  }

  async updateTheGroupRolesOfGroupMember(request: UpdateTheGroupRolesOfGroupMemberRequest): Promise<UpdateTheGroupRolesOfGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTheGroupRolesOfGroupMemberHeaders({ });
    return await this.updateTheGroupRolesOfGroupMemberWithOptions(request, headers, runtime);
  }

  async updateTheGroupRolesOfGroupMemberWithOptions(request: UpdateTheGroupRolesOfGroupMemberRequest, headers: UpdateTheGroupRolesOfGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTheGroupRolesOfGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.openRoleIds)) {
      body["openRoleIds"] = request.openRoleIds;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
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
    return $tea.cast<UpdateTheGroupRolesOfGroupMemberResponse>(await this.doROARequest("UpdateTheGroupRolesOfGroupMember", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/sceneGroups/members/groupRoles`, "json", req, runtime), new UpdateTheGroupRolesOfGroupMemberResponse({}));
  }

  async sendInteractiveCard(request: SendInteractiveCardRequest): Promise<SendInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInteractiveCardHeaders({ });
    return await this.sendInteractiveCardWithOptions(request, headers, runtime);
  }

  async sendInteractiveCardWithOptions(request: SendInteractiveCardRequest, headers: SendInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.chatBotId)) {
      body["chatBotId"] = request.chatBotId;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
    }

    if (!Util.isUnset(request.atOpenIds)) {
      body["atOpenIds"] = request.atOpenIds;
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
    return $tea.cast<SendInteractiveCardResponse>(await this.doROARequest("SendInteractiveCard", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interactiveCards/send`, "json", req, runtime), new SendInteractiveCardResponse({}));
  }

  async updateInteractiveCard(request: UpdateInteractiveCardRequest): Promise<UpdateInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInteractiveCardHeaders({ });
    return await this.updateInteractiveCardWithOptions(request, headers, runtime);
  }

  async updateInteractiveCardWithOptions(request: UpdateInteractiveCardRequest, headers: UpdateInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
    return $tea.cast<UpdateInteractiveCardResponse>(await this.doROARequest("UpdateInteractiveCard", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/interactiveCards`, "json", req, runtime), new UpdateInteractiveCardResponse({}));
  }

  async queryMembersOfGroupRole(request: QueryMembersOfGroupRoleRequest): Promise<QueryMembersOfGroupRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMembersOfGroupRoleHeaders({ });
    return await this.queryMembersOfGroupRoleWithOptions(request, headers, runtime);
  }

  async queryMembersOfGroupRoleWithOptions(request: QueryMembersOfGroupRoleRequest, headers: QueryMembersOfGroupRoleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMembersOfGroupRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openRoleId)) {
      body["openRoleId"] = request.openRoleId;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
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
    return $tea.cast<QueryMembersOfGroupRoleResponse>(await this.doROARequest("QueryMembersOfGroupRole", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/sceneGroups/roles/members/query`, "json", req, runtime), new QueryMembersOfGroupRoleResponse({}));
  }

}
