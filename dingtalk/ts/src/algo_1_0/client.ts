// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class NlpWordDistinguishHeaders extends $tea.Model {
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

export class NlpWordDistinguishRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  attachExtractDecisionInfo?: NlpWordDistinguishRequestAttachExtractDecisionInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  isvAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  text?: string;
  static names(): { [key: string]: string } {
    return {
      attachExtractDecisionInfo: 'attachExtractDecisionInfo',
      isvAppId: 'isvAppId',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachExtractDecisionInfo: NlpWordDistinguishRequestAttachExtractDecisionInfo,
      isvAppId: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NlpWordDistinguishResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  requestId?: string;
  wordEntities?: NlpWordDistinguishResponseBodyWordEntities[];
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      wordEntities: 'wordEntities',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      wordEntities: { 'type': 'array', 'itemType': NlpWordDistinguishResponseBodyWordEntities },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NlpWordDistinguishResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: NlpWordDistinguishResponseBody;
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
      body: NlpWordDistinguishResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendHeaders extends $tea.Model {
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

export class OkrOpenRecommendRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  candidateOkrItems?: OkrOpenRecommendRequestCandidateOkrItems[];
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  deptIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  isvAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  words?: string[];
  static names(): { [key: string]: string } {
    return {
      candidateOkrItems: 'candidateOkrItems',
      corpId: 'corpId',
      deptIds: 'deptIds',
      isvAppId: 'isvAppId',
      userId: 'userId',
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      candidateOkrItems: { 'type': 'array', 'itemType': OkrOpenRecommendRequestCandidateOkrItems },
      corpId: 'string',
      deptIds: { 'type': 'array', 'itemType': 'string' },
      isvAppId: 'string',
      userId: 'string',
      words: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendResponseBody extends $tea.Model {
  okrRecommendItems?: OkrOpenRecommendResponseBodyOkrRecommendItems[];
  /**
   * @remarks
   * This parameter is required.
   */
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      okrRecommendItems: 'okrRecommendItems',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      okrRecommendItems: { 'type': 'array', 'itemType': OkrOpenRecommendResponseBodyOkrRecommendItems },
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OkrOpenRecommendResponseBody;
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
      body: OkrOpenRecommendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NlpWordDistinguishRequestAttachExtractDecisionInfo extends $tea.Model {
  blackWords?: string[];
  candidateWords?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  deptIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      blackWords: 'blackWords',
      candidateWords: 'candidateWords',
      corpId: 'corpId',
      deptIds: 'deptIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blackWords: { 'type': 'array', 'itemType': 'string' },
      candidateWords: { 'type': 'array', 'itemType': 'string' },
      corpId: 'string',
      deptIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NlpWordDistinguishResponseBodyWordEntities extends $tea.Model {
  word?: string;
  static names(): { [key: string]: string } {
    return {
      word: 'word',
    };
  }

  static types(): { [key: string]: any } {
    return {
      word: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos extends $tea.Model {
  kr?: string;
  krId?: string;
  words?: string[];
  static names(): { [key: string]: string } {
    return {
      kr: 'kr',
      krId: 'krId',
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kr: 'string',
      krId: 'string',
      words: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendRequestCandidateOkrItemsOkrInfos extends $tea.Model {
  keyResultInfos?: OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos[];
  objective?: string;
  objectiveId?: string;
  words?: string[];
  static names(): { [key: string]: string } {
    return {
      keyResultInfos: 'keyResultInfos',
      objective: 'objective',
      objectiveId: 'objectiveId',
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyResultInfos: { 'type': 'array', 'itemType': OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos },
      objective: 'string',
      objectiveId: 'string',
      words: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendRequestCandidateOkrItems extends $tea.Model {
  okrInfos?: OkrOpenRecommendRequestCandidateOkrItemsOkrInfos[];
  /**
   * @remarks
   * This parameter is required.
   */
  relation?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      okrInfos: 'okrInfos',
      relation: 'relation',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      okrInfos: { 'type': 'array', 'itemType': OkrOpenRecommendRequestCandidateOkrItemsOkrInfos },
      relation: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  krId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  semanticLevel?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  words?: string[];
  static names(): { [key: string]: string } {
    return {
      krId: 'krId',
      semanticLevel: 'semanticLevel',
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      krId: 'string',
      semanticLevel: 'number',
      words: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  objectiveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  semanticLevel?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  words?: string[];
  static names(): { [key: string]: string } {
    return {
      objectiveId: 'objectiveId',
      semanticLevel: 'semanticLevel',
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveId: 'string',
      semanticLevel: 'number',
      words: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrOpenRecommendResponseBodyOkrRecommendItems extends $tea.Model {
  krResultRelatedResults?: OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults[];
  objectiveRelatedResults?: OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults[];
  /**
   * @remarks
   * This parameter is required.
   */
  relatedLevel?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  semanticLevel?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      krResultRelatedResults: 'krResultRelatedResults',
      objectiveRelatedResults: 'objectiveRelatedResults',
      relatedLevel: 'relatedLevel',
      semanticLevel: 'semanticLevel',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      krResultRelatedResults: { 'type': 'array', 'itemType': OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults },
      objectiveRelatedResults: { 'type': 'array', 'itemType': OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults },
      relatedLevel: 'number',
      semanticLevel: 'number',
      userId: 'string',
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
   * 自然语言处理之关键词识别
   * 
   * @param request - NlpWordDistinguishRequest
   * @param headers - NlpWordDistinguishHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns NlpWordDistinguishResponse
   */
  async nlpWordDistinguishWithOptions(request: NlpWordDistinguishRequest, headers: NlpWordDistinguishHeaders, runtime: $Util.RuntimeOptions): Promise<NlpWordDistinguishResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachExtractDecisionInfo)) {
      body["attachExtractDecisionInfo"] = request.attachExtractDecisionInfo;
    }

    if (!Util.isUnset(request.isvAppId)) {
      body["isvAppId"] = request.isvAppId;
    }

    if (!Util.isUnset(request.text)) {
      body["text"] = request.text;
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
      action: "NlpWordDistinguish",
      version: "algo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/algo/okrs/keywords/extract`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<NlpWordDistinguishResponse>(await this.execute(params, req, runtime), new NlpWordDistinguishResponse({}));
  }

  /**
   * 自然语言处理之关键词识别
   * 
   * @param request - NlpWordDistinguishRequest
   * @returns NlpWordDistinguishResponse
   */
  async nlpWordDistinguish(request: NlpWordDistinguishRequest): Promise<NlpWordDistinguishResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NlpWordDistinguishHeaders({ });
    return await this.nlpWordDistinguishWithOptions(request, headers, runtime);
  }

  /**
   * Okr内容推荐
   * 
   * @param request - OkrOpenRecommendRequest
   * @param headers - OkrOpenRecommendHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OkrOpenRecommendResponse
   */
  async okrOpenRecommendWithOptions(request: OkrOpenRecommendRequest, headers: OkrOpenRecommendHeaders, runtime: $Util.RuntimeOptions): Promise<OkrOpenRecommendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.candidateOkrItems)) {
      body["candidateOkrItems"] = request.candidateOkrItems;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.isvAppId)) {
      body["isvAppId"] = request.isvAppId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.words)) {
      body["words"] = request.words;
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
      action: "OkrOpenRecommend",
      version: "algo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/algo/okrs/recommend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OkrOpenRecommendResponse>(await this.execute(params, req, runtime), new OkrOpenRecommendResponse({}));
  }

  /**
   * Okr内容推荐
   * 
   * @param request - OkrOpenRecommendRequest
   * @returns OkrOpenRecommendResponse
   */
  async okrOpenRecommend(request: OkrOpenRecommendRequest): Promise<OkrOpenRecommendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OkrOpenRecommendHeaders({ });
    return await this.okrOpenRecommendWithOptions(request, headers, runtime);
  }

}
