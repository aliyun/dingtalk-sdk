// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  body: CloseTopboxResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CloseTopboxResponseBody,
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
  body: CreateTopboxResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTopboxResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async closeTopbox(request: CloseTopboxRequest): Promise<CloseTopboxResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseTopboxHeaders({ });
    return await this.closeTopboxWithOptions(request, headers, runtime);
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
    return $tea.cast<CloseTopboxResponse>(await this.doROARequest("CloseTopbox", "im_2.0", "HTTP", "POST", "AK", `/v2.0/im/topBoxes/close`, "json", req, runtime), new CloseTopboxResponse({}));
  }

  async createTopbox(request: CreateTopboxRequest): Promise<CreateTopboxResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTopboxHeaders({ });
    return await this.createTopboxWithOptions(request, headers, runtime);
  }

  async createTopboxWithOptions(request: CreateTopboxRequest, headers: CreateTopboxHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTopboxResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset($tea.toMap(request.cardSettings))) {
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
    return $tea.cast<CreateTopboxResponse>(await this.doROARequest("CreateTopbox", "im_2.0", "HTTP", "POST", "AK", `/v2.0/im/topBoxes`, "json", req, runtime), new CreateTopboxResponse({}));
  }

}
