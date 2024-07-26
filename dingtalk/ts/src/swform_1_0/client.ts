// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetFormInstanceHeaders extends $tea.Model {
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

export class GetFormInstanceRequest extends $tea.Model {
  /**
   * @example
   * 0
   */
  bizType?: number;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormInstanceResponseBody extends $tea.Model {
  result?: GetFormInstanceResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetFormInstanceResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFormInstanceResponseBody;
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
      body: GetFormInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormInstancesHeaders extends $tea.Model {
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

export class ListFormInstancesRequest extends $tea.Model {
  /**
   * @example
   * 2019-01-01
   */
  actionDate?: string;
  /**
   * @example
   * 0
   */
  bizType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      actionDate: 'actionDate',
      bizType: 'bizType',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionDate: 'string',
      bizType: 'number',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormInstancesResponseBody extends $tea.Model {
  result?: ListFormInstancesResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ListFormInstancesResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListFormInstancesResponseBody;
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
      body: ListFormInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormSchemasByCreatorHeaders extends $tea.Model {
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

export class ListFormSchemasByCreatorRequest extends $tea.Model {
  /**
   * @example
   * 0
   */
  bizType?: number;
  /**
   * @example
   * user123
   */
  creator?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      creator: 'creator',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      creator: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormSchemasByCreatorResponseBody extends $tea.Model {
  result?: ListFormSchemasByCreatorResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ListFormSchemasByCreatorResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormSchemasByCreatorResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListFormSchemasByCreatorResponseBody;
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
      body: ListFormSchemasByCreatorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormInstanceResponseBodyResultForms extends $tea.Model {
  /**
   * @example
   * TextareaField_KGAW58AQ
   */
  key?: string;
  /**
   * @example
   * 你希望的主题
   */
  label?: string;
  /**
   * @example
   * 操作演示
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormInstanceResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-07-27T18:53Z
   */
  createTime?: string;
  /**
   * @example
   * manager4220
   */
  creator?: string;
  /**
   * @example
   * PROC-E5BD2166-B6F4-xxxx
   */
  formCode?: string;
  forms?: GetFormInstanceResponseBodyResultForms[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-07-27T18:53Z
   */
  modifyTime?: string;
  /**
   * @example
   * 智能填表测试
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      creator: 'creator',
      formCode: 'formCode',
      forms: 'forms',
      modifyTime: 'modifyTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      creator: 'string',
      formCode: 'string',
      forms: { 'type': 'array', 'itemType': GetFormInstanceResponseBodyResultForms },
      modifyTime: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormInstancesResponseBodyResultListForms extends $tea.Model {
  /**
   * @example
   * TextareaField_KGAW58AQ
   */
  key?: string;
  /**
   * @example
   * 你希望的主题
   */
  label?: string;
  /**
   * @example
   * 操作演示
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormInstancesResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-07-27T18:53Z
   */
  createTime?: string;
  /**
   * @example
   * PROC-E5BD2166-B6F4-xxxx
   */
  formCode?: string;
  /**
   * @example
   * 11125769-fxxxx
   */
  formInstanceId?: string;
  forms?: ListFormInstancesResponseBodyResultListForms[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-07-27T18:53Z
   */
  modifyTime?: string;
  /**
   * @example
   * 1
   */
  studentClassId?: string;
  /**
   * @example
   * 三年二班
   */
  studentClassName?: string;
  /**
   * @example
   * 钉三多
   */
  studentName?: string;
  /**
   * @example
   * 1
   */
  studentUserId?: string;
  /**
   * @example
   * user123
   */
  submitterUserId?: string;
  /**
   * @example
   * 钉三多
   */
  submitterUserName?: string;
  /**
   * @example
   * 智能填表测试
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      formCode: 'formCode',
      formInstanceId: 'formInstanceId',
      forms: 'forms',
      modifyTime: 'modifyTime',
      studentClassId: 'studentClassId',
      studentClassName: 'studentClassName',
      studentName: 'studentName',
      studentUserId: 'studentUserId',
      submitterUserId: 'submitterUserId',
      submitterUserName: 'submitterUserName',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      formCode: 'string',
      formInstanceId: 'string',
      forms: { 'type': 'array', 'itemType': ListFormInstancesResponseBodyResultListForms },
      modifyTime: 'string',
      studentClassId: 'string',
      studentClassName: 'string',
      studentName: 'string',
      studentUserId: 'string',
      submitterUserId: 'string',
      submitterUserName: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormInstancesResponseBodyResult extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  list?: ListFormInstancesResponseBodyResultList[];
  /**
   * @example
   * 10
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListFormInstancesResponseBodyResultList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormSchemasByCreatorResponseBodyResultListSetting extends $tea.Model {
  /**
   * @example
   * 0
   */
  bizType?: number;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-07-27T18:53Z
   */
  createTime?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2022-07-27T18:53Z
   */
  endTime?: string;
  /**
   * @example
   * 0
   */
  formType?: number;
  loopDays?: number[];
  /**
   * @example
   * 18:00
   */
  loopTime?: string;
  /**
   * @example
   * true
   */
  stop?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      createTime: 'createTime',
      endTime: 'endTime',
      formType: 'formType',
      loopDays: 'loopDays',
      loopTime: 'loopTime',
      stop: 'stop',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      createTime: 'string',
      endTime: 'string',
      formType: 'number',
      loopDays: { 'type': 'array', 'itemType': 'number' },
      loopTime: 'string',
      stop: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormSchemasByCreatorResponseBodyResultList extends $tea.Model {
  /**
   * @example
   * user123
   */
  creator?: string;
  /**
   * @example
   * PROC-E5BD2166-B6F4-xxxx
   */
  formCode?: string;
  /**
   * @example
   * 请大家仔细填写，谢谢合作
   */
  memo?: string;
  /**
   * @example
   * 智能填表测试
   */
  name?: string;
  setting?: ListFormSchemasByCreatorResponseBodyResultListSetting;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      formCode: 'formCode',
      memo: 'memo',
      name: 'name',
      setting: 'setting',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      formCode: 'string',
      memo: 'string',
      name: 'string',
      setting: ListFormSchemasByCreatorResponseBodyResultListSetting,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormSchemasByCreatorResponseBodyResult extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  list?: ListFormSchemasByCreatorResponseBodyResultList[];
  /**
   * @example
   * 10
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListFormSchemasByCreatorResponseBodyResultList },
      nextToken: 'number',
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
   * 获取单个填表实例详情接口
   * 
   * @param request - GetFormInstanceRequest
   * @param headers - GetFormInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFormInstanceResponse
   */
  async getFormInstanceWithOptions(formInstanceId: string, request: GetFormInstanceRequest, headers: GetFormInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
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
      action: "GetFormInstance",
      version: "swform_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/swform/instances/${formInstanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFormInstanceResponse>(await this.execute(params, req, runtime), new GetFormInstanceResponse({}));
  }

  /**
   * 获取单个填表实例详情接口
   * 
   * @param request - GetFormInstanceRequest
   * @returns GetFormInstanceResponse
   */
  async getFormInstance(formInstanceId: string, request: GetFormInstanceRequest): Promise<GetFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormInstanceHeaders({ });
    return await this.getFormInstanceWithOptions(formInstanceId, request, headers, runtime);
  }

  /**
   * 获取填表模版下的填表实例列表接口
   * 
   * @param request - ListFormInstancesRequest
   * @param headers - ListFormInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListFormInstancesResponse
   */
  async listFormInstancesWithOptions(formCode: string, request: ListFormInstancesRequest, headers: ListFormInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<ListFormInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionDate)) {
      query["actionDate"] = request.actionDate;
    }

    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      action: "ListFormInstances",
      version: "swform_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/swform/forms/${formCode}/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListFormInstancesResponse>(await this.execute(params, req, runtime), new ListFormInstancesResponse({}));
  }

  /**
   * 获取填表模版下的填表实例列表接口
   * 
   * @param request - ListFormInstancesRequest
   * @returns ListFormInstancesResponse
   */
  async listFormInstances(formCode: string, request: ListFormInstancesRequest): Promise<ListFormInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFormInstancesHeaders({ });
    return await this.listFormInstancesWithOptions(formCode, request, headers, runtime);
  }

  /**
   * 获取用户创建的填表模板列表接口
   * 
   * @param request - ListFormSchemasByCreatorRequest
   * @param headers - ListFormSchemasByCreatorHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListFormSchemasByCreatorResponse
   */
  async listFormSchemasByCreatorWithOptions(request: ListFormSchemasByCreatorRequest, headers: ListFormSchemasByCreatorHeaders, runtime: $Util.RuntimeOptions): Promise<ListFormSchemasByCreatorResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.creator)) {
      query["creator"] = request.creator;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      action: "ListFormSchemasByCreator",
      version: "swform_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/swform/users/forms`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListFormSchemasByCreatorResponse>(await this.execute(params, req, runtime), new ListFormSchemasByCreatorResponse({}));
  }

  /**
   * 获取用户创建的填表模板列表接口
   * 
   * @param request - ListFormSchemasByCreatorRequest
   * @returns ListFormSchemasByCreatorResponse
   */
  async listFormSchemasByCreator(request: ListFormSchemasByCreatorRequest): Promise<ListFormSchemasByCreatorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFormSchemasByCreatorHeaders({ });
    return await this.listFormSchemasByCreatorWithOptions(request, headers, runtime);
  }

}
