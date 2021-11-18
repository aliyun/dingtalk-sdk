// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryFormInstanceHeaders extends $tea.Model {
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

export class QueryFormInstanceRequest extends $tea.Model {
  formInstanceId?: string;
  formCode?: string;
  appUuid?: string;
  static names(): { [key: string]: string } {
    return {
      formInstanceId: 'formInstanceId',
      formCode: 'formCode',
      appUuid: 'appUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formInstanceId: 'string',
      formCode: 'string',
      appUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceResponseBody extends $tea.Model {
  formInstanceId?: string;
  formInstDataList?: QueryFormInstanceResponseBodyFormInstDataList[];
  appUuid?: string;
  formCode?: string;
  title?: string;
  creator?: string;
  modifier?: string;
  createTimestamp?: number;
  modifyTimestamp?: number;
  outInstanceId?: string;
  outBizCode?: string;
  attributes?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      formInstanceId: 'formInstanceId',
      formInstDataList: 'formInstDataList',
      appUuid: 'appUuid',
      formCode: 'formCode',
      title: 'title',
      creator: 'creator',
      modifier: 'modifier',
      createTimestamp: 'createTimestamp',
      modifyTimestamp: 'modifyTimestamp',
      outInstanceId: 'outInstanceId',
      outBizCode: 'outBizCode',
      attributes: 'attributes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formInstanceId: 'string',
      formInstDataList: { 'type': 'array', 'itemType': QueryFormInstanceResponseBodyFormInstDataList },
      appUuid: 'string',
      formCode: 'string',
      title: 'string',
      creator: 'string',
      modifier: 'string',
      createTimestamp: 'number',
      modifyTimestamp: 'number',
      outInstanceId: 'string',
      outBizCode: 'string',
      attributes: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryFormInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryFormInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeHeaders extends $tea.Model {
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

export class QueryFormByBizTypeRequest extends $tea.Model {
  appUuid?: string;
  bizTypes?: string[];
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      bizTypes: 'bizTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      bizTypes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeResponseBody extends $tea.Model {
  result?: QueryFormByBizTypeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryFormByBizTypeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryFormByBizTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryFormByBizTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesHeaders extends $tea.Model {
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

export class QueryAllProcessInstancesRequest extends $tea.Model {
  nextToken?: string;
  maxResults?: number;
  startTimeInMills?: number;
  endTimeInMills?: number;
  processCode?: string;
  appUuid?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      startTimeInMills: 'startTimeInMills',
      endTimeInMills: 'endTimeInMills',
      processCode: 'processCode',
      appUuid: 'appUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      maxResults: 'number',
      startTimeInMills: 'number',
      endTimeInMills: 'number',
      processCode: 'string',
      appUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBody extends $tea.Model {
  result?: QueryAllProcessInstancesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAllProcessInstancesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllProcessInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllProcessInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesHeaders extends $tea.Model {
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

export class QueryAllFormInstancesRequest extends $tea.Model {
  nextToken?: string;
  maxResults?: number;
  appUuid?: string;
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      appUuid: 'appUuid',
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      maxResults: 'number',
      appUuid: 'string',
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBody extends $tea.Model {
  result?: QueryAllFormInstancesResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAllFormInstancesResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllFormInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllFormInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormInstanceResponseBodyFormInstDataList extends $tea.Model {
  componentType?: string;
  bizAlias?: string;
  extendValue?: string;
  label?: string;
  value?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      componentType: 'componentType',
      bizAlias: 'bizAlias',
      extendValue: 'extendValue',
      label: 'label',
      value: 'value',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentType: 'string',
      bizAlias: 'string',
      extendValue: 'string',
      label: 'string',
      value: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFormByBizTypeResponseBodyResult extends $tea.Model {
  creator?: string;
  appUuid?: string;
  formCode?: string;
  formUuid?: string;
  name?: string;
  memo?: string;
  ownerId?: string;
  appType?: number;
  bizType?: string;
  status?: string;
  createTime?: number;
  modifedTime?: number;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      appUuid: 'appUuid',
      formCode: 'formCode',
      formUuid: 'formUuid',
      name: 'name',
      memo: 'memo',
      ownerId: 'ownerId',
      appType: 'appType',
      bizType: 'bizType',
      status: 'status',
      createTime: 'createTime',
      modifedTime: 'modifedTime',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      appUuid: 'string',
      formCode: 'string',
      formUuid: 'string',
      name: 'string',
      memo: 'string',
      ownerId: 'string',
      appType: 'number',
      bizType: 'string',
      status: 'string',
      createTime: 'number',
      modifedTime: 'number',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultListFormComponentValues extends $tea.Model {
  name?: string;
  id?: string;
  value?: string;
  extValue?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      id: 'id',
      value: 'value',
      extValue: 'extValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      id: 'string',
      value: 'string',
      extValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResultList extends $tea.Model {
  processInstanceId?: string;
  mainProcessInstanceId?: string;
  finishTime?: number;
  attachedProcessInstanceIds?: string;
  businessId?: string;
  title?: string;
  originatorDeptId?: string;
  result?: string;
  createTime?: number;
  originatorUserid?: string;
  status?: string;
  formComponentValues?: QueryAllProcessInstancesResponseBodyResultListFormComponentValues[];
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      mainProcessInstanceId: 'mainProcessInstanceId',
      finishTime: 'finishTime',
      attachedProcessInstanceIds: 'attachedProcessInstanceIds',
      businessId: 'businessId',
      title: 'title',
      originatorDeptId: 'originatorDeptId',
      result: 'result',
      createTime: 'createTime',
      originatorUserid: 'originatorUserid',
      status: 'status',
      formComponentValues: 'formComponentValues',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      mainProcessInstanceId: 'string',
      finishTime: 'number',
      attachedProcessInstanceIds: 'string',
      businessId: 'string',
      title: 'string',
      originatorDeptId: 'string',
      result: 'string',
      createTime: 'number',
      originatorUserid: 'string',
      status: 'string',
      formComponentValues: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultListFormComponentValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllProcessInstancesResponseBodyResult extends $tea.Model {
  nextToken?: string;
  hasMore?: boolean;
  maxResults?: number;
  list?: QueryAllProcessInstancesResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      hasMore: 'boolean',
      maxResults: 'number',
      list: { 'type': 'array', 'itemType': QueryAllProcessInstancesResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList extends $tea.Model {
  componentType?: string;
  bizAlias?: string;
  extendValue?: string;
  label?: string;
  value?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      componentType: 'componentType',
      bizAlias: 'bizAlias',
      extendValue: 'extendValue',
      label: 'label',
      value: 'value',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentType: 'string',
      bizAlias: 'string',
      extendValue: 'string',
      label: 'string',
      value: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBodyResultValues extends $tea.Model {
  formInstanceId?: string;
  appUuid?: string;
  formCode?: string;
  title?: string;
  creator?: string;
  modifier?: string;
  createTimestamp?: number;
  modifyTimestamp?: number;
  outInstanceId?: string;
  outBizCode?: string;
  attributes?: { [key: string]: any };
  formInstDataList?: QueryAllFormInstancesResponseBodyResultValuesFormInstDataList[];
  static names(): { [key: string]: string } {
    return {
      formInstanceId: 'formInstanceId',
      appUuid: 'appUuid',
      formCode: 'formCode',
      title: 'title',
      creator: 'creator',
      modifier: 'modifier',
      createTimestamp: 'createTimestamp',
      modifyTimestamp: 'modifyTimestamp',
      outInstanceId: 'outInstanceId',
      outBizCode: 'outBizCode',
      attributes: 'attributes',
      formInstDataList: 'formInstDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formInstanceId: 'string',
      appUuid: 'string',
      formCode: 'string',
      title: 'string',
      creator: 'string',
      modifier: 'string',
      createTimestamp: 'number',
      modifyTimestamp: 'number',
      outInstanceId: 'string',
      outBizCode: 'string',
      attributes: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstDataList: { 'type': 'array', 'itemType': QueryAllFormInstancesResponseBodyResultValuesFormInstDataList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllFormInstancesResponseBodyResult extends $tea.Model {
  nextToken?: string;
  hasMore?: boolean;
  maxResults?: number;
  values?: QueryAllFormInstancesResponseBodyResultValues[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      hasMore: 'boolean',
      maxResults: 'number',
      values: { 'type': 'array', 'itemType': QueryAllFormInstancesResponseBodyResultValues },
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


  async queryFormInstance(request: QueryFormInstanceRequest): Promise<QueryFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFormInstanceHeaders({ });
    return await this.queryFormInstanceWithOptions(request, headers, runtime);
  }

  async queryFormInstanceWithOptions(request: QueryFormInstanceRequest, headers: QueryFormInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFormInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formInstanceId)) {
      query["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryFormInstanceResponse>(await this.doROARequest("QueryFormInstance", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/forms/instances`, "json", req, runtime), new QueryFormInstanceResponse({}));
  }

  async queryFormByBizType(request: QueryFormByBizTypeRequest): Promise<QueryFormByBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFormByBizTypeHeaders({ });
    return await this.queryFormByBizTypeWithOptions(request, headers, runtime);
  }

  async queryFormByBizTypeWithOptions(request: QueryFormByBizTypeRequest, headers: QueryFormByBizTypeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFormByBizTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUuid)) {
      body["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.bizTypes)) {
      body["bizTypes"] = request.bizTypes;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<QueryFormByBizTypeResponse>(await this.doROARequest("QueryFormByBizType", "workflow_1.0", "HTTP", "POST", "AK", `/v1.0/workflow/forms/forminfos/query`, "json", req, runtime), new QueryFormByBizTypeResponse({}));
  }

  async queryAllProcessInstances(request: QueryAllProcessInstancesRequest): Promise<QueryAllProcessInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllProcessInstancesHeaders({ });
    return await this.queryAllProcessInstancesWithOptions(request, headers, runtime);
  }

  async queryAllProcessInstancesWithOptions(request: QueryAllProcessInstancesRequest, headers: QueryAllProcessInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllProcessInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.startTimeInMills)) {
      query["startTimeInMills"] = request.startTimeInMills;
    }

    if (!Util.isUnset(request.endTimeInMills)) {
      query["endTimeInMills"] = request.endTimeInMills;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryAllProcessInstancesResponse>(await this.doROARequest("QueryAllProcessInstances", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/processes/pages/instances`, "json", req, runtime), new QueryAllProcessInstancesResponse({}));
  }

  async queryAllFormInstances(request: QueryAllFormInstancesRequest): Promise<QueryAllFormInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllFormInstancesHeaders({ });
    return await this.queryAllFormInstancesWithOptions(request, headers, runtime);
  }

  async queryAllFormInstancesWithOptions(request: QueryAllFormInstancesRequest, headers: QueryAllFormInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllFormInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.appUuid)) {
      query["appUuid"] = request.appUuid;
    }

    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryAllFormInstancesResponse>(await this.doROARequest("QueryAllFormInstances", "workflow_1.0", "HTTP", "GET", "AK", `/v1.0/workflow/forms/pages/instances`, "json", req, runtime), new QueryAllFormInstancesResponse({}));
  }

}
