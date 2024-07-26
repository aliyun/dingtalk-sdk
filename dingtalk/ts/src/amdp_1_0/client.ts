// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AmdpEmpRoleDataPushHeaders extends $tea.Model {
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

export class AmdpEmpRoleDataPushRequest extends $tea.Model {
  param?: AmdpEmpRoleDataPushRequestParam[];
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: { 'type': 'array', 'itemType': AmdpEmpRoleDataPushRequestParam },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmpRoleDataPushResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  status?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      status: 'status',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      status: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmpRoleDataPushResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AmdpEmpRoleDataPushResponseBody;
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
      body: AmdpEmpRoleDataPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmployeeDataPushHeaders extends $tea.Model {
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

export class AmdpEmployeeDataPushRequest extends $tea.Model {
  param?: AmdpEmployeeDataPushRequestParam[];
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: { 'type': 'array', 'itemType': AmdpEmployeeDataPushRequestParam },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmployeeDataPushResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  status?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      status: 'status',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      status: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmployeeDataPushResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AmdpEmployeeDataPushResponseBody;
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
      body: AmdpEmployeeDataPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpJobPositionDataPushHeaders extends $tea.Model {
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

export class AmdpJobPositionDataPushRequest extends $tea.Model {
  param?: AmdpJobPositionDataPushRequestParam[];
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: { 'type': 'array', 'itemType': AmdpJobPositionDataPushRequestParam },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpJobPositionDataPushResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  status?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      status: 'status',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      status: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpJobPositionDataPushResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AmdpJobPositionDataPushResponseBody;
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
      body: AmdpJobPositionDataPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpOrganizationDataPushHeaders extends $tea.Model {
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

export class AmdpOrganizationDataPushRequest extends $tea.Model {
  param?: AmdpOrganizationDataPushRequestParam[];
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: { 'type': 'array', 'itemType': AmdpOrganizationDataPushRequestParam },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpOrganizationDataPushResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  status?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      status: 'status',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      status: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpOrganizationDataPushResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AmdpOrganizationDataPushResponseBody;
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
      body: AmdpOrganizationDataPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmpRoleDataPushRequestParam extends $tea.Model {
  deptId?: string;
  isDelete?: string;
  roleCode?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      isDelete: 'isDelete',
      roleCode: 'roleCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      isDelete: 'string',
      roleCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpEmployeeDataPushRequestParam extends $tea.Model {
  avatar?: string;
  isDelete?: string;
  name?: string;
  unionId?: string;
  userId?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      isDelete: 'isDelete',
      name: 'name',
      unionId: 'unionId',
      userId: 'userId',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      isDelete: 'string',
      name: 'string',
      unionId: 'string',
      userId: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpJobPositionDataPushRequestParam extends $tea.Model {
  deptId?: string;
  deptLeader?: string;
  isDelete?: string;
  leaderDeptId?: string;
  orderNumber?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptLeader: 'deptLeader',
      isDelete: 'isDelete',
      leaderDeptId: 'leaderDeptId',
      orderNumber: 'orderNumber',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptLeader: 'string',
      isDelete: 'string',
      leaderDeptId: 'string',
      orderNumber: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AmdpOrganizationDataPushRequestParam extends $tea.Model {
  deptId?: string;
  deptManagerIdList?: string[];
  dingTalkDeptId?: string;
  dingTalkParentId?: string;
  isDelete?: string;
  name?: string;
  parentId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptManagerIdList: 'deptManagerIdList',
      dingTalkDeptId: 'dingTalkDeptId',
      dingTalkParentId: 'dingTalkParentId',
      isDelete: 'isDelete',
      name: 'name',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptManagerIdList: { 'type': 'array', 'itemType': 'string' },
      dingTalkDeptId: 'string',
      dingTalkParentId: 'string',
      isDelete: 'string',
      name: 'string',
      parentId: 'string',
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
   * 人员角色数据推送
   * 
   * @param request - AmdpEmpRoleDataPushRequest
   * @param headers - AmdpEmpRoleDataPushHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AmdpEmpRoleDataPushResponse
   */
  async amdpEmpRoleDataPushWithOptions(request: AmdpEmpRoleDataPushRequest, headers: AmdpEmpRoleDataPushHeaders, runtime: $Util.RuntimeOptions): Promise<AmdpEmpRoleDataPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "AmdpEmpRoleDataPush",
      version: "amdp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/amdp/employeeRoles/datas/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AmdpEmpRoleDataPushResponse>(await this.execute(params, req, runtime), new AmdpEmpRoleDataPushResponse({}));
  }

  /**
   * 人员角色数据推送
   * 
   * @param request - AmdpEmpRoleDataPushRequest
   * @returns AmdpEmpRoleDataPushResponse
   */
  async amdpEmpRoleDataPush(request: AmdpEmpRoleDataPushRequest): Promise<AmdpEmpRoleDataPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AmdpEmpRoleDataPushHeaders({ });
    return await this.amdpEmpRoleDataPushWithOptions(request, headers, runtime);
  }

  /**
   * 人员数据推送
   * 
   * @param request - AmdpEmployeeDataPushRequest
   * @param headers - AmdpEmployeeDataPushHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AmdpEmployeeDataPushResponse
   */
  async amdpEmployeeDataPushWithOptions(request: AmdpEmployeeDataPushRequest, headers: AmdpEmployeeDataPushHeaders, runtime: $Util.RuntimeOptions): Promise<AmdpEmployeeDataPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "AmdpEmployeeDataPush",
      version: "amdp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/amdp/employees/datas/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AmdpEmployeeDataPushResponse>(await this.execute(params, req, runtime), new AmdpEmployeeDataPushResponse({}));
  }

  /**
   * 人员数据推送
   * 
   * @param request - AmdpEmployeeDataPushRequest
   * @returns AmdpEmployeeDataPushResponse
   */
  async amdpEmployeeDataPush(request: AmdpEmployeeDataPushRequest): Promise<AmdpEmployeeDataPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AmdpEmployeeDataPushHeaders({ });
    return await this.amdpEmployeeDataPushWithOptions(request, headers, runtime);
  }

  /**
   * 任职数据推送
   * 
   * @param request - AmdpJobPositionDataPushRequest
   * @param headers - AmdpJobPositionDataPushHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AmdpJobPositionDataPushResponse
   */
  async amdpJobPositionDataPushWithOptions(request: AmdpJobPositionDataPushRequest, headers: AmdpJobPositionDataPushHeaders, runtime: $Util.RuntimeOptions): Promise<AmdpJobPositionDataPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "AmdpJobPositionDataPush",
      version: "amdp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/amdp/empJobs/datas/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AmdpJobPositionDataPushResponse>(await this.execute(params, req, runtime), new AmdpJobPositionDataPushResponse({}));
  }

  /**
   * 任职数据推送
   * 
   * @param request - AmdpJobPositionDataPushRequest
   * @returns AmdpJobPositionDataPushResponse
   */
  async amdpJobPositionDataPush(request: AmdpJobPositionDataPushRequest): Promise<AmdpJobPositionDataPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AmdpJobPositionDataPushHeaders({ });
    return await this.amdpJobPositionDataPushWithOptions(request, headers, runtime);
  }

  /**
   * 组织部门数据推送
   * 
   * @param request - AmdpOrganizationDataPushRequest
   * @param headers - AmdpOrganizationDataPushHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AmdpOrganizationDataPushResponse
   */
  async amdpOrganizationDataPushWithOptions(request: AmdpOrganizationDataPushRequest, headers: AmdpOrganizationDataPushHeaders, runtime: $Util.RuntimeOptions): Promise<AmdpOrganizationDataPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "AmdpOrganizationDataPush",
      version: "amdp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/amdp/organizations/departments/datas/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AmdpOrganizationDataPushResponse>(await this.execute(params, req, runtime), new AmdpOrganizationDataPushResponse({}));
  }

  /**
   * 组织部门数据推送
   * 
   * @param request - AmdpOrganizationDataPushRequest
   * @returns AmdpOrganizationDataPushResponse
   */
  async amdpOrganizationDataPush(request: AmdpOrganizationDataPushRequest): Promise<AmdpOrganizationDataPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AmdpOrganizationDataPushHeaders({ });
    return await this.amdpOrganizationDataPushWithOptions(request, headers, runtime);
  }

}
