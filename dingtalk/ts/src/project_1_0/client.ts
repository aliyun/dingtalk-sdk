// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetTbProjectSourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingOrgId?: string;
  dingIsvOrgId?: string;
  dingCorpId?: string;
  dingSuiteKey?: string;
  dingAccessTokenType?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingCorpId: 'dingCorpId',
      dingSuiteKey: 'dingSuiteKey',
      dingAccessTokenType: 'dingAccessTokenType',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingOrgId: 'string',
      dingIsvOrgId: 'string',
      dingCorpId: 'string',
      dingSuiteKey: 'string',
      dingAccessTokenType: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceResponseBody extends $tea.Model {
  installSource?: string;
  static names(): { [key: string]: string } {
    return {
      installSource: 'installSource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      installSource: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbProjectSourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbProjectSourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingSuiteKey?: string;
  dingIsvOrgId?: string;
  dingOrgId?: string;
  dingCorpId?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingSuiteKey: 'dingSuiteKey',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingCorpId: 'dingCorpId',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingSuiteKey: 'string',
      dingIsvOrgId: 'string',
      dingOrgId: 'string',
      dingCorpId: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayRequest extends $tea.Model {
  label?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayResponseBody extends $tea.Model {
  result?: boolean;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbProjectGrayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbProjectGrayResponseBody,
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


  async getTbProjectSource(): Promise<GetTbProjectSourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectSourceHeaders({ });
    return await this.getTbProjectSourceWithOptions(headers, runtime);
  }

  async getTbProjectSourceWithOptions(headers: GetTbProjectSourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbProjectSourceResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = headers.dingOrgId;
    }

    if (!Util.isUnset(headers.dingIsvOrgId)) {
      realHeaders["dingIsvOrgId"] = headers.dingIsvOrgId;
    }

    if (!Util.isUnset(headers.dingCorpId)) {
      realHeaders["dingCorpId"] = headers.dingCorpId;
    }

    if (!Util.isUnset(headers.dingSuiteKey)) {
      realHeaders["dingSuiteKey"] = headers.dingSuiteKey;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = headers.dingAccessTokenType;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetTbProjectSourceResponse>(await this.doROARequest("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/projects/source`, "json", req, runtime), new GetTbProjectSourceResponse({}));
  }

  async getTbProjectGray(request: GetTbProjectGrayRequest): Promise<GetTbProjectGrayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectGrayHeaders({ });
    return await this.getTbProjectGrayWithOptions(request, headers, runtime);
  }

  async getTbProjectGrayWithOptions(request: GetTbProjectGrayRequest, headers: GetTbProjectGrayHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbProjectGrayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.label)) {
      body["label"] = request.label;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = headers.dingAccessTokenType;
    }

    if (!Util.isUnset(headers.dingSuiteKey)) {
      realHeaders["dingSuiteKey"] = headers.dingSuiteKey;
    }

    if (!Util.isUnset(headers.dingIsvOrgId)) {
      realHeaders["dingIsvOrgId"] = headers.dingIsvOrgId;
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = headers.dingOrgId;
    }

    if (!Util.isUnset(headers.dingCorpId)) {
      realHeaders["dingCorpId"] = headers.dingCorpId;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetTbProjectGrayResponse>(await this.doROARequest("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/projects/gray`, "json", req, runtime), new GetTbProjectGrayResponse({}));
  }

}
