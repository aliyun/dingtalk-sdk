// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateUserHeaders extends $tea.Model {
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

export class CreateUserRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user@yourcompany.org
   */
  email?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  employeeType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * password
   */
  password?: string;
  static names(): { [key: string]: string } {
    return {
      email: 'email',
      employeeType: 'employeeType',
      name: 'name',
      password: 'password',
    };
  }

  static types(): { [key: string]: any } {
    return {
      email: 'string',
      employeeType: 'string',
      name: 'string',
      password: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserResponseBody extends $tea.Model {
  email?: string;
  static names(): { [key: string]: string } {
    return {
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateUserResponseBody;
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
      body: CreateUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMailFoldersHeaders extends $tea.Model {
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

export class ListMailFoldersRequest extends $tea.Model {
  folderId?: string;
  static names(): { [key: string]: string } {
    return {
      folderId: 'folderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      folderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMailFoldersResponseBody extends $tea.Model {
  folders?: ListMailFoldersResponseBodyFolders[];
  static names(): { [key: string]: string } {
    return {
      folders: 'folders',
    };
  }

  static types(): { [key: string]: any } {
    return {
      folders: { 'type': 'array', 'itemType': ListMailFoldersResponseBodyFolders },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMailFoldersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListMailFoldersResponseBody;
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
      body: ListMailFoldersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMailFoldersResponseBodyFolders extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  childFolderCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  displayName?: string;
  extensions?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  parentFolderId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  totalItemCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  unreadItemCount?: number;
  static names(): { [key: string]: string } {
    return {
      childFolderCount: 'childFolderCount',
      displayName: 'displayName',
      extensions: 'extensions',
      id: 'id',
      parentFolderId: 'parentFolderId',
      totalItemCount: 'totalItemCount',
      unreadItemCount: 'unreadItemCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      childFolderCount: 'number',
      displayName: 'string',
      extensions: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      id: 'string',
      parentFolderId: 'string',
      totalItemCount: 'number',
      unreadItemCount: 'number',
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
   * 创建企业邮箱用户
   * 
   * @param request - CreateUserRequest
   * @param headers - CreateUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateUserResponse
   */
  async createUserWithOptions(request: CreateUserRequest, headers: CreateUserHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.email)) {
      body["email"] = request.email;
    }

    if (!Util.isUnset(request.employeeType)) {
      body["employeeType"] = request.employeeType;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.password)) {
      body["password"] = request.password;
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
      action: "CreateUser",
      version: "mail_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/mail/users`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateUserResponse>(await this.execute(params, req, runtime), new CreateUserResponse({}));
  }

  /**
   * 创建企业邮箱用户
   * 
   * @param request - CreateUserRequest
   * @returns CreateUserResponse
   */
  async createUser(request: CreateUserRequest): Promise<CreateUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUserHeaders({ });
    return await this.createUserWithOptions(request, headers, runtime);
  }

  /**
   * 获取指定文件夹的子文件夹列表
   * 
   * @param request - ListMailFoldersRequest
   * @param headers - ListMailFoldersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListMailFoldersResponse
   */
  async listMailFoldersWithOptions(email: string, request: ListMailFoldersRequest, headers: ListMailFoldersHeaders, runtime: $Util.RuntimeOptions): Promise<ListMailFoldersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.folderId)) {
      query["folderId"] = request.folderId;
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
      action: "ListMailFolders",
      version: "mail_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/mail/users/${email}/mailFolders`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListMailFoldersResponse>(await this.execute(params, req, runtime), new ListMailFoldersResponse({}));
  }

  /**
   * 获取指定文件夹的子文件夹列表
   * 
   * @param request - ListMailFoldersRequest
   * @returns ListMailFoldersResponse
   */
  async listMailFolders(email: string, request: ListMailFoldersRequest): Promise<ListMailFoldersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMailFoldersHeaders({ });
    return await this.listMailFoldersWithOptions(email, request, headers, runtime);
  }

}
