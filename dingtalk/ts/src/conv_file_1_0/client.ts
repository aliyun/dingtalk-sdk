// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetSpaceHeaders extends $tea.Model {
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

export class GetSpaceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * open_conversation_id
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBody extends $tea.Model {
  space?: GetSpaceResponseBodySpace;
  static names(): { [key: string]: string } {
    return {
      space: 'space',
    };
  }

  static types(): { [key: string]: any } {
    return {
      space: GetSpaceResponseBodySpace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpaceResponseBody;
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
      body: GetSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendHeaders extends $tea.Model {
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

export class SendRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * file_id
   */
  dentryId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * open_conversation_id
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      openConversationId: 'openConversationId',
      spaceId: 'spaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      openConversationId: 'string',
      spaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendResponseBody extends $tea.Model {
  file?: SendResponseBodyFile;
  static names(): { [key: string]: string } {
    return {
      file: 'file',
    };
  }

  static types(): { [key: string]: any } {
    return {
      file: SendResponseBodyFile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendResponseBody;
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
      body: SendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendByAppHeaders extends $tea.Model {
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

export class SendByAppRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * file_id
   */
  dentryId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      spaceId: 'spaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      spaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendByAppResponseBody extends $tea.Model {
  file?: SendByAppResponseBodyFile;
  static names(): { [key: string]: string } {
    return {
      file: 'file',
    };
  }

  static types(): { [key: string]: any } {
    return {
      file: SendByAppResponseBodyFile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendByAppResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendByAppResponseBody;
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
      body: SendByAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLinkHeaders extends $tea.Model {
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

export class SendLinkRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * file_id
   */
  dentryId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * open_conversation_id
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      openConversationId: 'openConversationId',
      spaceId: 'spaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      openConversationId: 'string',
      spaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLinkResponseBody extends $tea.Model {
  file?: SendLinkResponseBodyFile;
  static names(): { [key: string]: string } {
    return {
      file: 'file',
    };
  }

  static types(): { [key: string]: any } {
    return {
      file: SendLinkResponseBodyFile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLinkResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendLinkResponseBody;
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
      body: SendLinkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpace extends $tea.Model {
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createTime: 'createTime',
      modifiedTime: 'modifiedTime',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createTime: 'string',
      modifiedTime: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendResponseBodyFile extends $tea.Model {
  /**
   * @example
   * open_conversation_id
   */
  conversationId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * file_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modified_id
   */
  modifierId?: string;
  /**
   * @example
   * file_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * file_path
   */
  path?: string;
  /**
   * @example
   * 256
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      path: 'path',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      path: 'string',
      size: 'number',
      spaceId: 'string',
      status: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendByAppResponseBodyFile extends $tea.Model {
  /**
   * @example
   * open_conversation_id
   */
  conversationId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * file_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modified_id
   */
  modifierId?: string;
  /**
   * @example
   * file_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * file_path
   */
  path?: string;
  /**
   * @example
   * 256
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      path: 'path',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      path: 'string',
      size: 'number',
      spaceId: 'string',
      status: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLinkResponseBodyFile extends $tea.Model {
  /**
   * @example
   * open_conversation_id
   */
  conversationId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * file_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modified_id
   */
  modifierId?: string;
  /**
   * @example
   * file_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * file_path
   */
  path?: string;
  /**
   * @example
   * 256
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      path: 'path',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      path: 'string',
      size: 'number',
      spaceId: 'string',
      status: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
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
   * 获取IM会话存储空间信息
   * 
   * @param request - GetSpaceRequest
   * @param headers - GetSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpaceResponse
   */
  async getSpaceWithOptions(request: GetSpaceRequest, headers: GetSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetSpace",
      version: "convFile_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/convFile/conversations/spaces/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceResponse>(await this.execute(params, req, runtime), new GetSpaceResponse({}));
  }

  /**
   * 获取IM会话存储空间信息
   * 
   * @param request - GetSpaceRequest
   * @returns GetSpaceResponse
   */
  async getSpace(request: GetSpaceRequest): Promise<GetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceHeaders({ });
    return await this.getSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 发送文件到指定会话
   * 
   * @param request - SendRequest
   * @param headers - SendHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendResponse
   */
  async sendWithOptions(request: SendRequest, headers: SendHeaders, runtime: $Util.RuntimeOptions): Promise<SendResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryId)) {
      body["dentryId"] = request.dentryId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "Send",
      version: "convFile_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/convFile/conversations/files/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendResponse>(await this.execute(params, req, runtime), new SendResponse({}));
  }

  /**
   * 发送文件到指定会话
   * 
   * @param request - SendRequest
   * @returns SendResponse
   */
  async send(request: SendRequest): Promise<SendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendHeaders({ });
    return await this.sendWithOptions(request, headers, runtime);
  }

  /**
   * 以应用身份发送文件给自己
   * 
   * @param request - SendByAppRequest
   * @param headers - SendByAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendByAppResponse
   */
  async sendByAppWithOptions(request: SendByAppRequest, headers: SendByAppHeaders, runtime: $Util.RuntimeOptions): Promise<SendByAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryId)) {
      body["dentryId"] = request.dentryId;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SendByApp",
      version: "convFile_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/convFile/apps/conversations/files/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendByAppResponse>(await this.execute(params, req, runtime), new SendByAppResponse({}));
  }

  /**
   * 以应用身份发送文件给自己
   * 
   * @param request - SendByAppRequest
   * @returns SendByAppResponse
   */
  async sendByApp(request: SendByAppRequest): Promise<SendByAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendByAppHeaders({ });
    return await this.sendByAppWithOptions(request, headers, runtime);
  }

  /**
   * 发送文件链接到指定会话
   * 
   * @param request - SendLinkRequest
   * @param headers - SendLinkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendLinkResponse
   */
  async sendLinkWithOptions(request: SendLinkRequest, headers: SendLinkHeaders, runtime: $Util.RuntimeOptions): Promise<SendLinkResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryId)) {
      body["dentryId"] = request.dentryId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SendLink",
      version: "convFile_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/convFile/conversations/files/links/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendLinkResponse>(await this.execute(params, req, runtime), new SendLinkResponse({}));
  }

  /**
   * 发送文件链接到指定会话
   * 
   * @param request - SendLinkRequest
   * @returns SendLinkResponse
   */
  async sendLink(request: SendLinkRequest): Promise<SendLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendLinkHeaders({ });
    return await this.sendLinkWithOptions(request, headers, runtime);
  }

}
