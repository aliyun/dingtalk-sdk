// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddDomainWordsHeaders extends $tea.Model {
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

export class AddDomainWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  domainWords?: AddDomainWordsRequestDomainWords[];
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      domainWords: 'domainWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      domainWords: { 'type': 'array', 'itemType': AddDomainWordsRequestDomainWords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDomainWordsResponseBody extends $tea.Model {
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

export class AddDomainWordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddDomainWordsResponseBody;
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
      body: AddDomainWordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsHeaders extends $tea.Model {
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

export class DeleteDomainWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  domainWords?: DeleteDomainWordsRequestDomainWords[];
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      domainWords: 'domainWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      domainWords: { 'type': 'array', 'itemType': DeleteDomainWordsRequestDomainWords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsResponseBody extends $tea.Model {
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

export class DeleteDomainWordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDomainWordsResponseBody;
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
      body: DeleteDomainWordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKnowledgeHeaders extends $tea.Model {
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

export class DeleteKnowledgeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  studyId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      studyId: 'studyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      studyId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKnowledgeResponseBody extends $tea.Model {
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

export class DeleteKnowledgeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteKnowledgeResponseBody;
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
      body: DeleteKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailHeaders extends $tea.Model {
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

export class GetAskDetailRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  offset?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      endTime: 'endTime',
      offset: 'offset',
      pageSize: 'pageSize',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      endTime: 'number',
      offset: 'number',
      pageSize: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBody extends $tea.Model {
  result?: GetAskDetailResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetAskDetailResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAskDetailResponseBody;
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
      body: GetAskDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsHeaders extends $tea.Model {
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

export class GetDomainWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsResponseBody extends $tea.Model {
  result?: string[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDomainWordsResponseBody;
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
      body: GetDomainWordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListHeaders extends $tea.Model {
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

export class GetKnowledgeListRequest extends $tea.Model {
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListResponseBody extends $tea.Model {
  result?: GetKnowledgeListResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetKnowledgeListResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetKnowledgeListResponseBody;
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
      body: GetKnowledgeListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAssistantHeaders extends $tea.Model {
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

export class InstallAssistantRequest extends $tea.Model {
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAssistantResponseBody extends $tea.Model {
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

export class InstallAssistantResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InstallAssistantResponseBody;
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
      body: InstallAssistantResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LearnKnowledgeHeaders extends $tea.Model {
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

export class LearnKnowledgeRequest extends $tea.Model {
  assistantId?: string;
  docUrl?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      docUrl: 'docUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      docUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LearnKnowledgeResponseBody extends $tea.Model {
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

export class LearnKnowledgeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LearnKnowledgeResponseBody;
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
      body: LearnKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelearnKnowledgeHeaders extends $tea.Model {
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

export class RelearnKnowledgeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelearnKnowledgeResponseBody extends $tea.Model {
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

export class RelearnKnowledgeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RelearnKnowledgeResponseBody;
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
      body: RelearnKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDomainWordsRequestDomainWords extends $tea.Model {
  description?: string;
  domainWord?: string;
  formalWords?: string[];
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      domainWord: 'domainWord',
      formalWords: 'formalWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      domainWord: 'string',
      formalWords: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsRequestDomainWords extends $tea.Model {
  description?: string;
  domainWord?: string;
  formalWords?: string[];
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      domainWord: 'domainWord',
      formalWords: 'formalWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      domainWord: 'string',
      formalWords: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBodyResultListReferences extends $tea.Model {
  name?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBodyResultList extends $tea.Model {
  answer?: string;
  answerResult?: string;
  commentTags?: string[];
  isMarkResolved?: boolean;
  nick?: string;
  question?: string;
  references?: GetAskDetailResponseBodyResultListReferences[];
  time?: number;
  static names(): { [key: string]: string } {
    return {
      answer: 'answer',
      answerResult: 'answerResult',
      commentTags: 'commentTags',
      isMarkResolved: 'isMarkResolved',
      nick: 'nick',
      question: 'question',
      references: 'references',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      answer: 'string',
      answerResult: 'string',
      commentTags: { 'type': 'array', 'itemType': 'string' },
      isMarkResolved: 'boolean',
      nick: 'string',
      question: 'string',
      references: { 'type': 'array', 'itemType': GetAskDetailResponseBodyResultListReferences },
      time: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: GetAskDetailResponseBodyResultList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': GetAskDetailResponseBodyResultList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListResponseBodyResult extends $tea.Model {
  docFormat?: string;
  docName?: string;
  docUrl?: string;
  status?: string;
  studyId?: string;
  static names(): { [key: string]: string } {
    return {
      docFormat: 'docFormat',
      docName: 'docName',
      docUrl: 'docUrl',
      status: 'status',
      studyId: 'studyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docFormat: 'string',
      docName: 'string',
      docUrl: 'string',
      status: 'string',
      studyId: 'string',
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
   * 助理添加专业词汇
   * 
   * @param request - AddDomainWordsRequest
   * @param headers - AddDomainWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddDomainWordsResponse
   */
  async addDomainWordsWithOptions(request: AddDomainWordsRequest, headers: AddDomainWordsHeaders, runtime: $Util.RuntimeOptions): Promise<AddDomainWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.domainWords)) {
      body["domainWords"] = request.domainWords;
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
      action: "AddDomainWords",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/domainWords`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddDomainWordsResponse>(await this.execute(params, req, runtime), new AddDomainWordsResponse({}));
  }

  /**
   * 助理添加专业词汇
   * 
   * @param request - AddDomainWordsRequest
   * @returns AddDomainWordsResponse
   */
  async addDomainWords(request: AddDomainWordsRequest): Promise<AddDomainWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddDomainWordsHeaders({ });
    return await this.addDomainWordsWithOptions(request, headers, runtime);
  }

  /**
   * 助理删除专业词汇
   * 
   * @param request - DeleteDomainWordsRequest
   * @param headers - DeleteDomainWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDomainWordsResponse
   */
  async deleteDomainWordsWithOptions(request: DeleteDomainWordsRequest, headers: DeleteDomainWordsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDomainWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.domainWords)) {
      body["domainWords"] = request.domainWords;
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
      action: "DeleteDomainWords",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/domainWords/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDomainWordsResponse>(await this.execute(params, req, runtime), new DeleteDomainWordsResponse({}));
  }

  /**
   * 助理删除专业词汇
   * 
   * @param request - DeleteDomainWordsRequest
   * @returns DeleteDomainWordsResponse
   */
  async deleteDomainWords(request: DeleteDomainWordsRequest): Promise<DeleteDomainWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDomainWordsHeaders({ });
    return await this.deleteDomainWordsWithOptions(request, headers, runtime);
  }

  /**
   * 删除助理知识
   * 
   * @param request - DeleteKnowledgeRequest
   * @param headers - DeleteKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteKnowledgeResponse
   */
  async deleteKnowledgeWithOptions(request: DeleteKnowledgeRequest, headers: DeleteKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteKnowledgeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.studyId)) {
      query["studyId"] = request.studyId;
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
      action: "DeleteKnowledge",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/items`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteKnowledgeResponse>(await this.execute(params, req, runtime), new DeleteKnowledgeResponse({}));
  }

  /**
   * 删除助理知识
   * 
   * @param request - DeleteKnowledgeRequest
   * @returns DeleteKnowledgeResponse
   */
  async deleteKnowledge(request: DeleteKnowledgeRequest): Promise<DeleteKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKnowledgeHeaders({ });
    return await this.deleteKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 获取助理问答明细
   * 
   * @param request - GetAskDetailRequest
   * @param headers - GetAskDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAskDetailResponse
   */
  async getAskDetailWithOptions(request: GetAskDetailRequest, headers: GetAskDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetAskDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.offset)) {
      query["offset"] = request.offset;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
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
      action: "GetAskDetail",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/askDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAskDetailResponse>(await this.execute(params, req, runtime), new GetAskDetailResponse({}));
  }

  /**
   * 获取助理问答明细
   * 
   * @param request - GetAskDetailRequest
   * @returns GetAskDetailResponse
   */
  async getAskDetail(request: GetAskDetailRequest): Promise<GetAskDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAskDetailHeaders({ });
    return await this.getAskDetailWithOptions(request, headers, runtime);
  }

  /**
   * 获取助理专业词汇
   * 
   * @param request - GetDomainWordsRequest
   * @param headers - GetDomainWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDomainWordsResponse
   */
  async getDomainWordsWithOptions(request: GetDomainWordsRequest, headers: GetDomainWordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetDomainWordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
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
      action: "GetDomainWords",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/domainWords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDomainWordsResponse>(await this.execute(params, req, runtime), new GetDomainWordsResponse({}));
  }

  /**
   * 获取助理专业词汇
   * 
   * @param request - GetDomainWordsRequest
   * @returns GetDomainWordsResponse
   */
  async getDomainWords(request: GetDomainWordsRequest): Promise<GetDomainWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDomainWordsHeaders({ });
    return await this.getDomainWordsWithOptions(request, headers, runtime);
  }

  /**
   * 获取助理知识列表
   * 
   * @param request - GetKnowledgeListRequest
   * @param headers - GetKnowledgeListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetKnowledgeListResponse
   */
  async getKnowledgeListWithOptions(request: GetKnowledgeListRequest, headers: GetKnowledgeListHeaders, runtime: $Util.RuntimeOptions): Promise<GetKnowledgeListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
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
      action: "GetKnowledgeList",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/items`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetKnowledgeListResponse>(await this.execute(params, req, runtime), new GetKnowledgeListResponse({}));
  }

  /**
   * 获取助理知识列表
   * 
   * @param request - GetKnowledgeListRequest
   * @returns GetKnowledgeListResponse
   */
  async getKnowledgeList(request: GetKnowledgeListRequest): Promise<GetKnowledgeListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetKnowledgeListHeaders({ });
    return await this.getKnowledgeListWithOptions(request, headers, runtime);
  }

  /**
   * 安装助理
   * 
   * @param request - InstallAssistantRequest
   * @param headers - InstallAssistantHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InstallAssistantResponse
   */
  async installAssistantWithOptions(request: InstallAssistantRequest, headers: InstallAssistantHeaders, runtime: $Util.RuntimeOptions): Promise<InstallAssistantResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
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
      action: "InstallAssistant",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallAssistantResponse>(await this.execute(params, req, runtime), new InstallAssistantResponse({}));
  }

  /**
   * 安装助理
   * 
   * @param request - InstallAssistantRequest
   * @returns InstallAssistantResponse
   */
  async installAssistant(request: InstallAssistantRequest): Promise<InstallAssistantResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallAssistantHeaders({ });
    return await this.installAssistantWithOptions(request, headers, runtime);
  }

  /**
   * 助理学习知识
   * 
   * @param request - LearnKnowledgeRequest
   * @param headers - LearnKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LearnKnowledgeResponse
   */
  async learnKnowledgeWithOptions(request: LearnKnowledgeRequest, headers: LearnKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<LearnKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.docUrl)) {
      body["docUrl"] = request.docUrl;
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
      action: "LearnKnowledge",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/items`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LearnKnowledgeResponse>(await this.execute(params, req, runtime), new LearnKnowledgeResponse({}));
  }

  /**
   * 助理学习知识
   * 
   * @param request - LearnKnowledgeRequest
   * @returns LearnKnowledgeResponse
   */
  async learnKnowledge(request: LearnKnowledgeRequest): Promise<LearnKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LearnKnowledgeHeaders({ });
    return await this.learnKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 助理学习增量知识
   * 
   * @param request - RelearnKnowledgeRequest
   * @param headers - RelearnKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RelearnKnowledgeResponse
   */
  async relearnKnowledgeWithOptions(request: RelearnKnowledgeRequest, headers: RelearnKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<RelearnKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
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
      action: "RelearnKnowledge",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/incrLearning`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RelearnKnowledgeResponse>(await this.execute(params, req, runtime), new RelearnKnowledgeResponse({}));
  }

  /**
   * 助理学习增量知识
   * 
   * @param request - RelearnKnowledgeRequest
   * @returns RelearnKnowledgeResponse
   */
  async relearnKnowledge(request: RelearnKnowledgeRequest): Promise<RelearnKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RelearnKnowledgeHeaders({ });
    return await this.relearnKnowledgeWithOptions(request, headers, runtime);
  }

}
