// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  openConversationId?: string;
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
  headers: { [key: string]: string };
  body: GetSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSpaceResponseBody,
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
  dentryId?: string;
  spaceId?: string;
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
  headers: { [key: string]: string };
  body: SendByAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendByAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpace extends $tea.Model {
  corpId?: string;
  createTime?: string;
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

export class SendByAppResponseBodyFile extends $tea.Model {
  conversationId?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  path?: string;
  size?: number;
  spaceId?: string;
  status?: string;
  type?: string;
  uuid?: string;
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
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async getSpace(request: GetSpaceRequest): Promise<GetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceHeaders({ });
    return await this.getSpaceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetSpaceResponse>(await this.doROARequest("GetSpace", "convFile_1.0", "HTTP", "POST", "AK", `/v1.0/convFile/conversations/spaces/query`, "json", req, runtime), new GetSpaceResponse({}));
  }

  async sendByApp(request: SendByAppRequest): Promise<SendByAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendByAppHeaders({ });
    return await this.sendByAppWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<SendByAppResponse>(await this.doROARequest("SendByApp", "convFile_1.0", "HTTP", "POST", "AK", `/v1.0/convFile/apps/conversations/files/send`, "json", req, runtime), new SendByAppResponse({}));
  }

}
