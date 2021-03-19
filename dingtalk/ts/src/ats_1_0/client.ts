// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetJobAuthHeaders extends $tea.Model {
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

export class GetJobAuthRequest extends $tea.Model {
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthResponseBody extends $tea.Model {
  jobId?: string;
  jobOwners?: GetJobAuthResponseBodyJobOwners[];
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      jobOwners: 'jobOwners',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
      jobOwners: { 'type': 'array', 'itemType': GetJobAuthResponseBodyJobOwners },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetJobAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetJobAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthResponseBodyJobOwners extends $tea.Model {
  userId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
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


  async getJobAuth(jobId: string, request: GetJobAuthRequest): Promise<GetJobAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobAuthHeaders({ });
    return await this.getJobAuthWithOptions(jobId, request, headers, runtime);
  }

  async getJobAuthWithOptions(jobId: string, request: GetJobAuthRequest, headers: GetJobAuthHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobAuthResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<GetJobAuthResponse>(await this.doROARequest("GetJobAuth", "ats_1.0", "HTTP", "GET", "AK", `/v1.0/ats/auths/jobs/${jobId}`, "json", req, runtime), new GetJobAuthResponse({}));
  }

}
