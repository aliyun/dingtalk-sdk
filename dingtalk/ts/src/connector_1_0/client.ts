// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class PullDataByPageHeaders extends $tea.Model {
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

export class PullDataByPageRequest extends $tea.Model {
  dataModelId?: string;
  datetimeFilterField?: string;
  minDatetime?: number;
  maxDatetime?: number;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      dataModelId: 'dataModelId',
      datetimeFilterField: 'datetimeFilterField',
      minDatetime: 'minDatetime',
      maxDatetime: 'maxDatetime',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataModelId: 'string',
      datetimeFilterField: 'string',
      minDatetime: 'number',
      maxDatetime: 'number',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponseBody extends $tea.Model {
  list?: PullDataByPageResponseBodyList[];
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': PullDataByPageResponseBodyList },
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PullDataByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PullDataByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkHeaders extends $tea.Model {
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

export class PullDataByPkRequest extends $tea.Model {
  primaryKey?: string;
  static names(): { [key: string]: string } {
    return {
      primaryKey: 'primaryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      primaryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkResponseBody extends $tea.Model {
  dataGmtCreate?: number;
  dataGmtModified?: number;
  dataCreateAppType?: string;
  dataCreateAppId?: string;
  dataModifiedAppType?: string;
  dataModifiedAppId?: string;
  jsonData?: string;
  static names(): { [key: string]: string } {
    return {
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      dataCreateAppType: 'dataCreateAppType',
      dataCreateAppId: 'dataCreateAppId',
      dataModifiedAppType: 'dataModifiedAppType',
      dataModifiedAppId: 'dataModifiedAppId',
      jsonData: 'jsonData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      dataCreateAppType: 'string',
      dataCreateAppId: 'string',
      dataModifiedAppType: 'string',
      dataModifiedAppId: 'string',
      jsonData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PullDataByPkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PullDataByPkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  triggerDataList?: SyncDataRequestTriggerDataList[];
  static names(): { [key: string]: string } {
    return {
      triggerDataList: 'triggerDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      triggerDataList: { 'type': 'array', 'itemType': SyncDataRequestTriggerDataList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponseBody extends $tea.Model {
  list?: SyncDataResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': SyncDataResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SyncDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SyncDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponseBodyList extends $tea.Model {
  dataGmtCreate?: number;
  dataGmtModified?: number;
  dataCreateAppType?: string;
  dataCreateAppId?: string;
  dataModifiedAppType?: string;
  dataModifiedAppId?: string;
  jsonData?: string;
  static names(): { [key: string]: string } {
    return {
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      dataCreateAppType: 'dataCreateAppType',
      dataCreateAppId: 'dataCreateAppId',
      dataModifiedAppType: 'dataModifiedAppType',
      dataModifiedAppId: 'dataModifiedAppId',
      jsonData: 'jsonData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      dataCreateAppType: 'string',
      dataCreateAppId: 'string',
      dataModifiedAppType: 'string',
      dataModifiedAppId: 'string',
      jsonData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataRequestTriggerDataList extends $tea.Model {
  triggerId?: string;
  customTriggerId?: string;
  jsonData?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  action?: string;
  static names(): { [key: string]: string } {
    return {
      triggerId: 'triggerId',
      customTriggerId: 'customTriggerId',
      jsonData: 'jsonData',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      action: 'action',
    };
  }

  static types(): { [key: string]: any } {
    return {
      triggerId: 'string',
      customTriggerId: 'string',
      jsonData: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      action: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponseBodyList extends $tea.Model {
  triggerId?: string;
  bizPrimaryKey?: string;
  success?: boolean;
  subErrCode?: string;
  subErrMsg?: string;
  static names(): { [key: string]: string } {
    return {
      triggerId: 'triggerId',
      bizPrimaryKey: 'bizPrimaryKey',
      success: 'success',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      triggerId: 'string',
      bizPrimaryKey: 'string',
      success: 'boolean',
      subErrCode: 'string',
      subErrMsg: 'string',
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


  async pullDataByPage(request: PullDataByPageRequest): Promise<PullDataByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullDataByPageHeaders({ });
    return await this.pullDataByPageWithOptions(request, headers, runtime);
  }

  async pullDataByPageWithOptions(request: PullDataByPageRequest, headers: PullDataByPageHeaders, runtime: $Util.RuntimeOptions): Promise<PullDataByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dataModelId)) {
      query["dataModelId"] = request.dataModelId;
    }

    if (!Util.isUnset(request.datetimeFilterField)) {
      query["datetimeFilterField"] = request.datetimeFilterField;
    }

    if (!Util.isUnset(request.minDatetime)) {
      query["minDatetime"] = request.minDatetime;
    }

    if (!Util.isUnset(request.maxDatetime)) {
      query["maxDatetime"] = request.maxDatetime;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<PullDataByPageResponse>(await this.doROARequest("PullDataByPage", "connector_1.0", "HTTP", "GET", "AK", `/v1.0/connector/data`, "json", req, runtime), new PullDataByPageResponse({}));
  }

  async pullDataByPk(dataModelId: string, request: PullDataByPkRequest): Promise<PullDataByPkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullDataByPkHeaders({ });
    return await this.pullDataByPkWithOptions(dataModelId, request, headers, runtime);
  }

  async pullDataByPkWithOptions(dataModelId: string, request: PullDataByPkRequest, headers: PullDataByPkHeaders, runtime: $Util.RuntimeOptions): Promise<PullDataByPkResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.primaryKey)) {
      query["primaryKey"] = request.primaryKey;
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
    return $tea.cast<PullDataByPkResponse>(await this.doROARequest("PullDataByPk", "connector_1.0", "HTTP", "GET", "AK", `/v1.0/connector/data/${dataModelId}`, "json", req, runtime), new PullDataByPkResponse({}));
  }

  async syncData(request: SyncDataRequest): Promise<SyncDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncDataHeaders({ });
    return await this.syncDataWithOptions(request, headers, runtime);
  }

  async syncDataWithOptions(request: SyncDataRequest, headers: SyncDataHeaders, runtime: $Util.RuntimeOptions): Promise<SyncDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.triggerDataList)) {
      body["triggerDataList"] = request.triggerDataList;
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
    return $tea.cast<SyncDataResponse>(await this.doROARequest("SyncData", "connector_1.0", "HTTP", "POST", "AK", `/v1.0/connector/triggers/data/sync`, "json", req, runtime), new SyncDataResponse({}));
  }

}
