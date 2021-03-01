// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class SyncDataHeaders extends $tea.Model {
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

export class SyncDataRequest extends $tea.Model {
  projectId?: string;
  schemaId?: string;
  dataId?: string;
  content?: string;
  etlTime?: string;
  static names(): { [key: string]: string } {
    return {
      projectId: 'projectId',
      schemaId: 'schemaId',
      dataId: 'dataId',
      content: 'content',
      etlTime: 'etlTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      projectId: 'string',
      schemaId: 'string',
      dataId: 'string',
      content: 'string',
      etlTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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


  async syncData(request: SyncDataRequest): Promise<SyncDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncDataHeaders({ });
    return await this.syncDataWithOptions(request, headers, runtime);
  }

  async syncDataWithOptions(request: SyncDataRequest, headers: SyncDataHeaders, runtime: $Util.RuntimeOptions): Promise<SyncDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.schemaId)) {
      body["schemaId"] = request.schemaId;
    }

    if (!Util.isUnset(request.dataId)) {
      body["dataId"] = request.dataId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.etlTime)) {
      body["etlTime"] = request.etlTime;
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
    return $tea.cast<SyncDataResponse>(await this.doROARequest("SyncData", "hrbrain_1.0", "HTTP", "POST", "AK", `/v1.0/hrbrain/datas`, "none", req, runtime), new SyncDataResponse({}));
  }

}
