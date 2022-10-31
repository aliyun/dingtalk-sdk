// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CheckInCrowdsByMobileRequest extends $tea.Model {
  crowdIds?: Buffer;
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      crowdIds: 'crowdIds',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      crowdIds: 'Buffer',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInCrowdsByMobileResponseBody extends $tea.Model {
  data?: boolean;
  success?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'boolean',
      success: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInCrowdsByMobileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CheckInCrowdsByMobileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CheckInCrowdsByMobileResponseBody,
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


  async checkInCrowdsByMobile(request: CheckInCrowdsByMobileRequest): Promise<CheckInCrowdsByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.checkInCrowdsByMobileWithOptions(request, headers, runtime);
  }

  async checkInCrowdsByMobileWithOptions(request: CheckInCrowdsByMobileRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<CheckInCrowdsByMobileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.crowdIds)) {
      query["crowdIds"] = request.crowdIds;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<CheckInCrowdsByMobileResponse>(await this.doROARequest("CheckInCrowdsByMobile", "watt_1.0", "HTTP", "POST", "AK", `/v1.0/watt/crowdIdentifications/query`, "json", req, runtime), new CheckInCrowdsByMobileResponse({}));
  }

}
