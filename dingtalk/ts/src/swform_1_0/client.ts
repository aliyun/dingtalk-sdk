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
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFormInstanceResponseBody;
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
  actionDate?: string;
  bizType?: number;
  maxResults?: number;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: ListFormInstancesResponseBody;
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
  bizType?: number;
  creator?: string;
  maxResults?: number;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: ListFormSchemasByCreatorResponseBody;
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
  key?: string;
  label?: string;
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
  createTime?: string;
  creator?: string;
  formCode?: string;
  forms?: GetFormInstanceResponseBodyResultForms[];
  modifyTime?: string;
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
  key?: string;
  label?: string;
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
  createTime?: string;
  formCode?: string;
  formInstanceId?: string;
  forms?: ListFormInstancesResponseBodyResultListForms[];
  modifyTime?: string;
  studentClassId?: string;
  studentClassName?: string;
  studentName?: string;
  studentUserId?: string;
  submitterUserId?: string;
  submitterUserName?: string;
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
  hasMore?: boolean;
  list?: ListFormInstancesResponseBodyResultList[];
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
  bizType?: number;
  createTime?: string;
  endTime?: string;
  formType?: number;
  loopDays?: number[];
  loopTime?: string;
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
  creator?: string;
  formCode?: string;
  memo?: string;
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
  hasMore?: boolean;
  list?: ListFormSchemasByCreatorResponseBodyResultList[];
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

  async getFormInstance(formInstanceId: string, request: GetFormInstanceRequest): Promise<GetFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormInstanceHeaders({ });
    return await this.getFormInstanceWithOptions(formInstanceId, request, headers, runtime);
  }

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

  async listFormInstances(formCode: string, request: ListFormInstancesRequest): Promise<ListFormInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFormInstancesHeaders({ });
    return await this.listFormInstancesWithOptions(formCode, request, headers, runtime);
  }

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

  async listFormSchemasByCreator(request: ListFormSchemasByCreatorRequest): Promise<ListFormSchemasByCreatorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFormSchemasByCreatorHeaders({ });
    return await this.listFormSchemasByCreatorWithOptions(request, headers, runtime);
  }

}
