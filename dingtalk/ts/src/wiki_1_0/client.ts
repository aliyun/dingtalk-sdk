// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class WikiWordsDetailHeaders extends $tea.Model {
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

export class WikiWordsDetailRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  wordName?: string;
  static names(): { [key: string]: string } {
    return {
      wordName: 'wordName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      wordName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsDetailResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: WikiWordsDetailResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   */
  errMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      errMsg: 'errMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': WikiWordsDetailResponseBodyData },
      errMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: WikiWordsDetailResponseBody;
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
      body: WikiWordsDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsParseHeaders extends $tea.Model {
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

export class WikiWordsParseRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsParseResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: WikiWordsParseResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   */
  errMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      errMsg: 'errMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': WikiWordsParseResponseBodyData },
      errMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsParseResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: WikiWordsParseResponseBody;
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
      body: WikiWordsParseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsDetailResponseBodyDataAppLink extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  iconLink?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pcLink?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  phoneLink?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      appName: 'appName',
      iconLink: 'iconLink',
      pcLink: 'pcLink',
      phoneLink: 'phoneLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      appName: 'string',
      iconLink: 'string',
      pcLink: 'string',
      phoneLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsDetailResponseBodyDataRelatedDoc extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsDetailResponseBodyDataRelatedLink extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsDetailResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appLink?: WikiWordsDetailResponseBodyDataAppLink[];
  /**
   * @remarks
   * This parameter is required.
   */
  approveName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contacts?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  creatorName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModify?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  highLightWordAlias?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  imHighLight?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  orgName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relatedDoc?: WikiWordsDetailResponseBodyDataRelatedDoc[];
  /**
   * @remarks
   * This parameter is required.
   */
  relatedLink?: WikiWordsDetailResponseBodyDataRelatedLink[];
  /**
   * @remarks
   * This parameter is required.
   */
  simHighLight?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  simpleWordParaphrase?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tagsList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  updaterName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uuid?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  wordAlias?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  wordFullName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  wordName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  wordParaphrase?: string;
  static names(): { [key: string]: string } {
    return {
      appLink: 'appLink',
      approveName: 'approveName',
      contacts: 'contacts',
      creatorName: 'creatorName',
      gmtCreate: 'gmtCreate',
      gmtModify: 'gmtModify',
      highLightWordAlias: 'highLightWordAlias',
      imHighLight: 'imHighLight',
      orgName: 'orgName',
      relatedDoc: 'relatedDoc',
      relatedLink: 'relatedLink',
      simHighLight: 'simHighLight',
      simpleWordParaphrase: 'simpleWordParaphrase',
      tagsList: 'tagsList',
      updaterName: 'updaterName',
      uuid: 'uuid',
      wordAlias: 'wordAlias',
      wordFullName: 'wordFullName',
      wordName: 'wordName',
      wordParaphrase: 'wordParaphrase',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appLink: { 'type': 'array', 'itemType': WikiWordsDetailResponseBodyDataAppLink },
      approveName: 'string',
      contacts: { 'type': 'array', 'itemType': 'string' },
      creatorName: 'string',
      gmtCreate: 'number',
      gmtModify: 'number',
      highLightWordAlias: { 'type': 'array', 'itemType': 'string' },
      imHighLight: 'boolean',
      orgName: 'string',
      relatedDoc: { 'type': 'array', 'itemType': WikiWordsDetailResponseBodyDataRelatedDoc },
      relatedLink: { 'type': 'array', 'itemType': WikiWordsDetailResponseBodyDataRelatedLink },
      simHighLight: 'boolean',
      simpleWordParaphrase: 'string',
      tagsList: { 'type': 'array', 'itemType': 'string' },
      updaterName: 'string',
      uuid: 'number',
      wordAlias: { 'type': 'array', 'itemType': 'string' },
      wordFullName: 'string',
      wordName: 'string',
      wordParaphrase: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WikiWordsParseResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  endIndex?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  startIndex?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  wordName?: string;
  static names(): { [key: string]: string } {
    return {
      endIndex: 'endIndex',
      startIndex: 'startIndex',
      wordName: 'wordName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endIndex: 'number',
      startIndex: 'number',
      wordName: 'string',
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
   * 根据词条名称获取该词条释义
   * 
   * @param request - WikiWordsDetailRequest
   * @param headers - WikiWordsDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns WikiWordsDetailResponse
   */
  async wikiWordsDetailWithOptions(request: WikiWordsDetailRequest, headers: WikiWordsDetailHeaders, runtime: $Util.RuntimeOptions): Promise<WikiWordsDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.wordName)) {
      query["wordName"] = request.wordName;
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
      action: "WikiWordsDetail",
      version: "wiki_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/wiki/words/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<WikiWordsDetailResponse>(await this.execute(params, req, runtime), new WikiWordsDetailResponse({}));
  }

  /**
   * 根据词条名称获取该词条释义
   * 
   * @param request - WikiWordsDetailRequest
   * @returns WikiWordsDetailResponse
   */
  async wikiWordsDetail(request: WikiWordsDetailRequest): Promise<WikiWordsDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WikiWordsDetailHeaders({ });
    return await this.wikiWordsDetailWithOptions(request, headers, runtime);
  }

  /**
   * 外部传递过来的消息根据百科词库分词
   * 
   * @param request - WikiWordsParseRequest
   * @param headers - WikiWordsParseHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns WikiWordsParseResponse
   */
  async wikiWordsParseWithOptions(request: WikiWordsParseRequest, headers: WikiWordsParseHeaders, runtime: $Util.RuntimeOptions): Promise<WikiWordsParseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
      action: "WikiWordsParse",
      version: "wiki_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/wiki/words/parse`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<WikiWordsParseResponse>(await this.execute(params, req, runtime), new WikiWordsParseResponse({}));
  }

  /**
   * 外部传递过来的消息根据百科词库分词
   * 
   * @param request - WikiWordsParseRequest
   * @returns WikiWordsParseResponse
   */
  async wikiWordsParse(request: WikiWordsParseRequest): Promise<WikiWordsParseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WikiWordsParseHeaders({ });
    return await this.wikiWordsParseWithOptions(request, headers, runtime);
  }

}
