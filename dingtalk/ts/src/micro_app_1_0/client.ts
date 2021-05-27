// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddAppToWorkBenchGroupHeaders extends $tea.Model {
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

export class AddAppToWorkBenchGroupRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  componentId?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      componentId: 'componentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      componentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppToWorkBenchGroupResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppToWorkBenchGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddAppToWorkBenchGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddAppToWorkBenchGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInnerAppHeaders extends $tea.Model {
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

export class CreateInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  ipWhiteList?: string[];
  scopeType?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
      ipWhiteList: 'ipWhiteList',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
      scopeType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInnerAppResponseBody extends $tea.Model {
  agentId?: number;
  appKey?: string;
  appSecret?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appKey: 'appKey',
      appSecret: 'appSecret',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appKey: 'string',
      appSecret: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInnerAppHeaders extends $tea.Model {
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

export class UpdateInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  ipWhiteList?: string[];
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
      ipWhiteList: 'ipWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInnerAppResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInnerAppHeaders extends $tea.Model {
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

export class DeleteInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInnerAppResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppHeaders extends $tea.Model {
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

export class GetInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppResponseBody extends $tea.Model {
  agentId?: number;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  appKey?: string;
  appSecret?: string;
  ipWhiteList?: string[];
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
      appKey: 'appKey',
      appSecret: 'appSecret',
      ipWhiteList: 'ipWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
      appKey: 'string',
      appSecret: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppHeaders extends $tea.Model {
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

export class ListInnerAppRequest extends $tea.Model {
  ecologicalCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      ecologicalCorpId: 'ecologicalCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ecologicalCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponseBody extends $tea.Model {
  appList?: ListInnerAppResponseBodyAppList[];
  static names(): { [key: string]: string } {
    return {
      appList: 'appList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appList: { 'type': 'array', 'itemType': ListInnerAppResponseBodyAppList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponseBodyAppList extends $tea.Model {
  agentId?: number;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
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


  async addAppToWorkBenchGroup(agentId: string, request: AddAppToWorkBenchGroupRequest): Promise<AddAppToWorkBenchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAppToWorkBenchGroupHeaders({ });
    return await this.addAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
  }

  async addAppToWorkBenchGroupWithOptions(agentId: string, request: AddAppToWorkBenchGroupRequest, headers: AddAppToWorkBenchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddAppToWorkBenchGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.componentId)) {
      body["componentId"] = request.componentId;
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
    return $tea.cast<AddAppToWorkBenchGroupResponse>(await this.doROARequest("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/addToWorkBenchGroup`, "json", req, runtime), new AddAppToWorkBenchGroupResponse({}));
  }

  async createInnerApp(request: CreateInnerAppRequest): Promise<CreateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInnerAppHeaders({ });
    return await this.createInnerAppWithOptions(request, headers, runtime);
  }

  async createInnerAppWithOptions(request: CreateInnerAppRequest, headers: CreateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.ipWhiteList)) {
      body["ipWhiteList"] = request.ipWhiteList;
    }

    if (!Util.isUnset(request.scopeType)) {
      body["scopeType"] = request.scopeType;
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
    return $tea.cast<CreateInnerAppResponse>(await this.doROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps`, "json", req, runtime), new CreateInnerAppResponse({}));
  }

  async updateInnerApp(agentId: string, request: UpdateInnerAppRequest): Promise<UpdateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInnerAppHeaders({ });
    return await this.updateInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async updateInnerAppWithOptions(agentId: string, request: UpdateInnerAppRequest, headers: UpdateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.ipWhiteList)) {
      body["ipWhiteList"] = request.ipWhiteList;
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
    return $tea.cast<UpdateInnerAppResponse>(await this.doROARequest("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new UpdateInnerAppResponse({}));
  }

  async deleteInnerApp(agentId: string, request: DeleteInnerAppRequest): Promise<DeleteInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInnerAppHeaders({ });
    return await this.deleteInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async deleteInnerAppWithOptions(agentId: string, request: DeleteInnerAppRequest, headers: DeleteInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInnerAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      query["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<DeleteInnerAppResponse>(await this.doROARequest("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new DeleteInnerAppResponse({}));
  }

  async getInnerApp(agentId: string, request: GetInnerAppRequest): Promise<GetInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInnerAppHeaders({ });
    return await this.getInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async getInnerAppWithOptions(agentId: string, request: GetInnerAppRequest, headers: GetInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<GetInnerAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      query["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<GetInnerAppResponse>(await this.doROARequest("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new GetInnerAppResponse({}));
  }

  async listInnerApp(request: ListInnerAppRequest): Promise<ListInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListInnerAppHeaders({ });
    return await this.listInnerAppWithOptions(request, headers, runtime);
  }

  async listInnerAppWithOptions(request: ListInnerAppRequest, headers: ListInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<ListInnerAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<ListInnerAppResponse>(await this.doROARequest("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps`, "json", req, runtime), new ListInnerAppResponse({}));
  }

}
