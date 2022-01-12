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
  appId?: string;
  dataModelId?: string;
  datetimeFilterField?: string;
  maxDatetime?: number;
  maxResults?: number;
  minDatetime?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      dataModelId: 'dataModelId',
      datetimeFilterField: 'datetimeFilterField',
      maxDatetime: 'maxDatetime',
      maxResults: 'maxResults',
      minDatetime: 'minDatetime',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      dataModelId: 'string',
      datetimeFilterField: 'string',
      maxDatetime: 'number',
      maxResults: 'number',
      minDatetime: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponseBody extends $tea.Model {
  list?: PullDataByPageResponseBodyList[];
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': PullDataByPageResponseBodyList },
      maxResults: 'number',
      nextToken: 'string',
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
  appId?: string;
  primaryKey?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      primaryKey: 'primaryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      primaryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkResponseBody extends $tea.Model {
  dataCreateAppId?: string;
  dataCreateAppType?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  dataModifiedAppId?: string;
  dataModifiedAppType?: string;
  jsonData?: string;
  static names(): { [key: string]: string } {
    return {
      dataCreateAppId: 'dataCreateAppId',
      dataCreateAppType: 'dataCreateAppType',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      dataModifiedAppId: 'dataModifiedAppId',
      dataModifiedAppType: 'dataModifiedAppType',
      jsonData: 'jsonData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataCreateAppId: 'string',
      dataCreateAppType: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      dataModifiedAppId: 'string',
      dataModifiedAppType: 'string',
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
  appId?: string;
  triggerDataList?: SyncDataRequestTriggerDataList[];
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      triggerDataList: 'triggerDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
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
  dataCreateAppId?: string;
  dataCreateAppType?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  dataModifiedAppId?: string;
  dataModifiedAppType?: string;
  jsonData?: string;
  static names(): { [key: string]: string } {
    return {
      dataCreateAppId: 'dataCreateAppId',
      dataCreateAppType: 'dataCreateAppType',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      dataModifiedAppId: 'dataModifiedAppId',
      dataModifiedAppType: 'dataModifiedAppType',
      jsonData: 'jsonData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataCreateAppId: 'string',
      dataCreateAppType: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      dataModifiedAppId: 'string',
      dataModifiedAppType: 'string',
      jsonData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataRequestTriggerDataList extends $tea.Model {
  action?: string;
  customTriggerId?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  jsonData?: string;
  triggerId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      customTriggerId: 'customTriggerId',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      jsonData: 'jsonData',
      triggerId: 'triggerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      customTriggerId: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      jsonData: 'string',
      triggerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponseBodyList extends $tea.Model {
  bizPrimaryKey?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: boolean;
  triggerId?: string;
  static names(): { [key: string]: string } {
    return {
      bizPrimaryKey: 'bizPrimaryKey',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
      triggerId: 'triggerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizPrimaryKey: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'boolean',
      triggerId: 'string',
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
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.dataModelId)) {
      query["dataModelId"] = request.dataModelId;
    }

    if (!Util.isUnset(request.datetimeFilterField)) {
      query["datetimeFilterField"] = request.datetimeFilterField;
    }

    if (!Util.isUnset(request.maxDatetime)) {
      query["maxDatetime"] = request.maxDatetime;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.minDatetime)) {
      query["minDatetime"] = request.minDatetime;
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
    return $tea.cast<PullDataByPageResponse>(await this.doROARequest("PullDataByPage", "connector_1.0", "HTTP", "GET", "AK", `/v1.0/connector/data`, "json", req, runtime), new PullDataByPageResponse({}));
  }

  async pullDataByPk(dataModelId: string, request: PullDataByPkRequest): Promise<PullDataByPkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullDataByPkHeaders({ });
    return await this.pullDataByPkWithOptions(dataModelId, request, headers, runtime);
  }

  async pullDataByPkWithOptions(dataModelId: string, request: PullDataByPkRequest, headers: PullDataByPkHeaders, runtime: $Util.RuntimeOptions): Promise<PullDataByPkResponse> {
    Util.validateModel(request);
    dataModelId = OpenApiUtil.getEncodeParam(dataModelId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.primaryKey)) {
      query["primaryKey"] = request.primaryKey;
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
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.triggerDataList)) {
      body["triggerDataList"] = request.triggerDataList;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<SyncDataResponse>(await this.doROARequest("SyncData", "connector_1.0", "HTTP", "POST", "AK", `/v1.0/connector/triggers/data/sync`, "json", req, runtime), new SyncDataResponse({}));
  }

}
