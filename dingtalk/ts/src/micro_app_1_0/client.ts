// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  creatorUnionId?: string;
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
      creatorUnionId: 'creatorUnionId',
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
      creatorUnionId: 'string',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async createInnerApp(request: CreateInnerAppRequest): Promise<CreateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInnerAppHeaders({ });
    return await this.createInnerAppWithOptions(request, headers, runtime);
  }

  async createInnerAppWithOptions(request: CreateInnerAppRequest, headers: CreateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
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

}
