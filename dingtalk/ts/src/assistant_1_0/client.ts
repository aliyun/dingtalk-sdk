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
  assistantId?: string;
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
   * @summary 删除助理知识
   *
   * @param request DeleteKnowledgeRequest
   * @param headers DeleteKnowledgeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeleteKnowledgeResponse
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
   * @summary 删除助理知识
   *
   * @param request DeleteKnowledgeRequest
   * @return DeleteKnowledgeResponse
   */
  async deleteKnowledge(request: DeleteKnowledgeRequest): Promise<DeleteKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKnowledgeHeaders({ });
    return await this.deleteKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取助理知识列表
   *
   * @param request GetKnowledgeListRequest
   * @param headers GetKnowledgeListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetKnowledgeListResponse
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
   * @summary 获取助理知识列表
   *
   * @param request GetKnowledgeListRequest
   * @return GetKnowledgeListResponse
   */
  async getKnowledgeList(request: GetKnowledgeListRequest): Promise<GetKnowledgeListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetKnowledgeListHeaders({ });
    return await this.getKnowledgeListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 安装助理
   *
   * @param request InstallAssistantRequest
   * @param headers InstallAssistantHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return InstallAssistantResponse
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
   * @summary 安装助理
   *
   * @param request InstallAssistantRequest
   * @return InstallAssistantResponse
   */
  async installAssistant(request: InstallAssistantRequest): Promise<InstallAssistantResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallAssistantHeaders({ });
    return await this.installAssistantWithOptions(request, headers, runtime);
  }

  /**
   * @summary 助理学习知识
   *
   * @param request LearnKnowledgeRequest
   * @param headers LearnKnowledgeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return LearnKnowledgeResponse
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
   * @summary 助理学习知识
   *
   * @param request LearnKnowledgeRequest
   * @return LearnKnowledgeResponse
   */
  async learnKnowledge(request: LearnKnowledgeRequest): Promise<LearnKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LearnKnowledgeHeaders({ });
    return await this.learnKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * @summary 助理学习增量知识
   *
   * @param request RelearnKnowledgeRequest
   * @param headers RelearnKnowledgeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return RelearnKnowledgeResponse
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
   * @summary 助理学习增量知识
   *
   * @param request RelearnKnowledgeRequest
   * @return RelearnKnowledgeResponse
   */
  async relearnKnowledge(request: RelearnKnowledgeRequest): Promise<RelearnKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RelearnKnowledgeHeaders({ });
    return await this.relearnKnowledgeWithOptions(request, headers, runtime);
  }

}
