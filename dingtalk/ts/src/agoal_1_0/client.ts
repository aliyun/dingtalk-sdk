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

export class OpenAgoalKeyActionDTO extends $tea.Model {
  keyActionId?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      keyActionId: 'keyActionId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyActionId: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenAgoalKeyResultDTO extends $tea.Model {
  keyActions?: OpenAgoalKeyActionDTO[];
  keyResultId?: string;
  progress?: number;
  status?: number;
  title?: string;
  titleMentions?: TitleMention[];
  type?: number;
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      keyActions: 'keyActions',
      keyResultId: 'keyResultId',
      progress: 'progress',
      status: 'status',
      title: 'title',
      titleMentions: 'titleMentions',
      type: 'type',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyActions: { 'type': 'array', 'itemType': OpenAgoalKeyActionDTO },
      keyResultId: 'string',
      progress: 'number',
      status: 'number',
      title: 'string',
      titleMentions: { 'type': 'array', 'itemType': TitleMention },
      type: 'number',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenAgoalLatestProgressDTO extends $tea.Model {
  created?: number;
  creator?: OpenAgoalUserDTO;
  htmldescription?: string;
  progressId?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creator: 'creator',
      htmldescription: 'htmldescription',
      progressId: 'progressId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'number',
      creator: OpenAgoalUserDTO,
      htmldescription: 'string',
      progressId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenAgoalObjectiveDTO extends $tea.Model {
  executor?: OpenAgoalUserDTO;
  keyActions?: OpenAgoalKeyActionDTO[];
  keyResults?: OpenAgoalKeyResultDTO[];
  latestProgress?: OpenAgoalLatestProgressDTO;
  objectiveId?: string;
  objectiveRule?: OpenOrgObjectiveRuleDTO;
  period?: OpenObjectiveRulePeriodDTO;
  progress?: number;
  status?: number;
  teams?: OpenAgoalTeamDTO[];
  title?: string;
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      executor: 'executor',
      keyActions: 'keyActions',
      keyResults: 'keyResults',
      latestProgress: 'latestProgress',
      objectiveId: 'objectiveId',
      objectiveRule: 'objectiveRule',
      period: 'period',
      progress: 'progress',
      status: 'status',
      teams: 'teams',
      title: 'title',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executor: OpenAgoalUserDTO,
      keyActions: { 'type': 'array', 'itemType': OpenAgoalKeyActionDTO },
      keyResults: { 'type': 'array', 'itemType': OpenAgoalKeyResultDTO },
      latestProgress: OpenAgoalLatestProgressDTO,
      objectiveId: 'string',
      objectiveRule: OpenOrgObjectiveRuleDTO,
      period: OpenObjectiveRulePeriodDTO,
      progress: 'number',
      status: 'number',
      teams: { 'type': 'array', 'itemType': OpenAgoalTeamDTO },
      title: 'string',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenAgoalTeamDTO extends $tea.Model {
  deptId?: string;
  name?: string;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      name: 'name',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      name: 'string',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenAgoalUserDTO extends $tea.Model {
  dingUserId?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingUserId: 'dingUserId',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingUserId: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenObjectiveRulePeriodDTO extends $tea.Model {
  endDate?: number;
  name?: string;
  periodId?: string;
  periodType?: string;
  startDate?: number;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      name: 'name',
      periodId: 'periodId',
      periodType: 'periodType',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'number',
      name: 'string',
      periodId: 'string',
      periodType: 'string',
      startDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenOrgObjectiveRuleDTO extends $tea.Model {
  objectiveRuleId?: string;
  objectiveRuleName?: string;
  static names(): { [key: string]: string } {
    return {
      objectiveRuleId: 'objectiveRuleId',
      objectiveRuleName: 'objectiveRuleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveRuleId: 'string',
      objectiveRuleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserAdminDTO extends $tea.Model {
  dingCorpId?: string;
  dingUserId?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      dingUserId: 'dingUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      dingUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TitleMention extends $tea.Model {
  length?: number;
  offset?: number;
  user?: OpenAgoalUserDTO;
  static names(): { [key: string]: string } {
    return {
      length: 'length',
      offset: 'offset',
      user: 'user',
    };
  }

  static types(): { [key: string]: any } {
    return {
      length: 'number',
      offset: 'number',
      user: OpenAgoalUserDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalObjectiveRulePeriodListHeaders extends $tea.Model {
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

export class AgoalObjectiveRulePeriodListRequest extends $tea.Model {
  objectiveRuleId?: string;
  static names(): { [key: string]: string } {
    return {
      objectiveRuleId: 'objectiveRuleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveRuleId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalObjectiveRulePeriodListResponseBody extends $tea.Model {
  content?: OpenObjectiveRulePeriodDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenObjectiveRulePeriodDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalObjectiveRulePeriodListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AgoalObjectiveRulePeriodListResponseBody;
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
      body: AgoalObjectiveRulePeriodListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalOrgObjectiveRuleListHeaders extends $tea.Model {
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

export class AgoalOrgObjectiveRuleListResponseBody extends $tea.Model {
  content?: OpenOrgObjectiveRuleDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenOrgObjectiveRuleDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalOrgObjectiveRuleListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AgoalOrgObjectiveRuleListResponseBody;
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
      body: AgoalOrgObjectiveRuleListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalSendMessageHeaders extends $tea.Model {
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

export class AgoalSendMessageRequest extends $tea.Model {
  mobileUrl?: string;
  params?: string;
  pcUrl?: string;
  sourceDingUserId?: string;
  targetDingUserIds?: string[];
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      params: 'params',
      pcUrl: 'pcUrl',
      sourceDingUserId: 'sourceDingUserId',
      targetDingUserIds: 'targetDingUserIds',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      params: 'string',
      pcUrl: 'string',
      sourceDingUserId: 'string',
      targetDingUserIds: { 'type': 'array', 'itemType': 'string' },
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalSendMessageResponseBody extends $tea.Model {
  content?: boolean;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalSendMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AgoalSendMessageResponseBody;
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
      body: AgoalSendMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalUserAdminListHeaders extends $tea.Model {
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

export class AgoalUserAdminListResponseBody extends $tea.Model {
  content?: OpenUserAdminDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenUserAdminDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalUserAdminListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AgoalUserAdminListResponseBody;
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
      body: AgoalUserAdminListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalUserObjectiveListHeaders extends $tea.Model {
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

export class AgoalUserObjectiveListRequest extends $tea.Model {
  dingUserId?: string;
  objectiveRuleId?: string;
  periodIds?: string[];
  static names(): { [key: string]: string } {
    return {
      dingUserId: 'dingUserId',
      objectiveRuleId: 'objectiveRuleId',
      periodIds: 'periodIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingUserId: 'string',
      objectiveRuleId: 'string',
      periodIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalUserObjectiveListResponseBody extends $tea.Model {
  content?: OpenAgoalObjectiveDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenAgoalObjectiveDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AgoalUserObjectiveListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AgoalUserObjectiveListResponseBody;
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
      body: AgoalUserObjectiveListResponseBody,
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


  /**
   * @summary 获取Agoal目标规则下的周期列表
   *
   * @param request AgoalObjectiveRulePeriodListRequest
   * @param headers AgoalObjectiveRulePeriodListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AgoalObjectiveRulePeriodListResponse
   */
  async agoalObjectiveRulePeriodListWithOptions(request: AgoalObjectiveRulePeriodListRequest, headers: AgoalObjectiveRulePeriodListHeaders, runtime: $Util.RuntimeOptions): Promise<AgoalObjectiveRulePeriodListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveRuleId)) {
      query["objectiveRuleId"] = request.objectiveRuleId;
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
    let params = new $OpenApi.Params({
      action: "AgoalObjectiveRulePeriodList",
      version: "agoal_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/agoal/objectiveRules/periodLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AgoalObjectiveRulePeriodListResponse>(await this.execute(params, req, runtime), new AgoalObjectiveRulePeriodListResponse({}));
  }

  /**
   * @summary 获取Agoal目标规则下的周期列表
   *
   * @param request AgoalObjectiveRulePeriodListRequest
   * @return AgoalObjectiveRulePeriodListResponse
   */
  async agoalObjectiveRulePeriodList(request: AgoalObjectiveRulePeriodListRequest): Promise<AgoalObjectiveRulePeriodListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AgoalObjectiveRulePeriodListHeaders({ });
    return await this.agoalObjectiveRulePeriodListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取Agoal目标规则列表
   *
   * @param headers AgoalOrgObjectiveRuleListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AgoalOrgObjectiveRuleListResponse
   */
  async agoalOrgObjectiveRuleListWithOptions(headers: AgoalOrgObjectiveRuleListHeaders, runtime: $Util.RuntimeOptions): Promise<AgoalOrgObjectiveRuleListResponse> {
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
      action: "AgoalOrgObjectiveRuleList",
      version: "agoal_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/agoal/objectiveRules/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AgoalOrgObjectiveRuleListResponse>(await this.execute(params, req, runtime), new AgoalOrgObjectiveRuleListResponse({}));
  }

  /**
   * @summary 获取Agoal目标规则列表
   *
   * @return AgoalOrgObjectiveRuleListResponse
   */
  async agoalOrgObjectiveRuleList(): Promise<AgoalOrgObjectiveRuleListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AgoalOrgObjectiveRuleListHeaders({ });
    return await this.agoalOrgObjectiveRuleListWithOptions(headers, runtime);
  }

  /**
   * @summary Agoal消息发送
   *
   * @param request AgoalSendMessageRequest
   * @param headers AgoalSendMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AgoalSendMessageResponse
   */
  async agoalSendMessageWithOptions(request: AgoalSendMessageRequest, headers: AgoalSendMessageHeaders, runtime: $Util.RuntimeOptions): Promise<AgoalSendMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobileUrl)) {
      body["mobileUrl"] = request.mobileUrl;
    }

    if (!Util.isUnset(request.params)) {
      body["params"] = request.params;
    }

    if (!Util.isUnset(request.pcUrl)) {
      body["pcUrl"] = request.pcUrl;
    }

    if (!Util.isUnset(request.sourceDingUserId)) {
      body["sourceDingUserId"] = request.sourceDingUserId;
    }

    if (!Util.isUnset(request.targetDingUserIds)) {
      body["targetDingUserIds"] = request.targetDingUserIds;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "AgoalSendMessage",
      version: "agoal_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/agoal/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AgoalSendMessageResponse>(await this.execute(params, req, runtime), new AgoalSendMessageResponse({}));
  }

  /**
   * @summary Agoal消息发送
   *
   * @param request AgoalSendMessageRequest
   * @return AgoalSendMessageResponse
   */
  async agoalSendMessage(request: AgoalSendMessageRequest): Promise<AgoalSendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AgoalSendMessageHeaders({ });
    return await this.agoalSendMessageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取Agoal管理员列表
   *
   * @param headers AgoalUserAdminListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AgoalUserAdminListResponse
   */
  async agoalUserAdminListWithOptions(headers: AgoalUserAdminListHeaders, runtime: $Util.RuntimeOptions): Promise<AgoalUserAdminListResponse> {
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
      action: "AgoalUserAdminList",
      version: "agoal_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/agoal/administrators/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AgoalUserAdminListResponse>(await this.execute(params, req, runtime), new AgoalUserAdminListResponse({}));
  }

  /**
   * @summary 获取Agoal管理员列表
   *
   * @return AgoalUserAdminListResponse
   */
  async agoalUserAdminList(): Promise<AgoalUserAdminListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AgoalUserAdminListHeaders({ });
    return await this.agoalUserAdminListWithOptions(headers, runtime);
  }

  /**
   * @summary Agoal用户目标列表
   *
   * @param request AgoalUserObjectiveListRequest
   * @param headers AgoalUserObjectiveListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AgoalUserObjectiveListResponse
   */
  async agoalUserObjectiveListWithOptions(request: AgoalUserObjectiveListRequest, headers: AgoalUserObjectiveListHeaders, runtime: $Util.RuntimeOptions): Promise<AgoalUserObjectiveListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingUserId)) {
      body["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.objectiveRuleId)) {
      body["objectiveRuleId"] = request.objectiveRuleId;
    }

    if (!Util.isUnset(request.periodIds)) {
      body["periodIds"] = request.periodIds;
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
      action: "AgoalUserObjectiveList",
      version: "agoal_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/agoal/users/objectiveLists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AgoalUserObjectiveListResponse>(await this.execute(params, req, runtime), new AgoalUserObjectiveListResponse({}));
  }

  /**
   * @summary Agoal用户目标列表
   *
   * @param request AgoalUserObjectiveListRequest
   * @return AgoalUserObjectiveListResponse
   */
  async agoalUserObjectiveList(request: AgoalUserObjectiveListRequest): Promise<AgoalUserObjectiveListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AgoalUserObjectiveListHeaders({ });
    return await this.agoalUserObjectiveListWithOptions(request, headers, runtime);
  }

}
