// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetRelationUkSettingHeaders extends $tea.Model {
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

export class GetRelationUkSettingRequest extends $tea.Model {
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponseBody extends $tea.Model {
  result?: GetRelationUkSettingResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetRelationUkSettingResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRelationUkSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRelationUkSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList extends $tea.Model {
  bizAlias?: string;
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponseBodyResultFormUkSettings extends $tea.Model {
  fieldList?: GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList[];
  static names(): { [key: string]: string } {
    return {
      fieldList: 'fieldList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldList: { 'type': 'array', 'itemType': GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponseBodyResult extends $tea.Model {
  formUkSettings?: GetRelationUkSettingResponseBodyResultFormUkSettings[];
  headerFieldIds?: string[];
  static names(): { [key: string]: string } {
    return {
      formUkSettings: 'formUkSettings',
      headerFieldIds: 'headerFieldIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUkSettings: { 'type': 'array', 'itemType': GetRelationUkSettingResponseBodyResultFormUkSettings },
      headerFieldIds: { 'type': 'array', 'itemType': 'string' },
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


  async getRelationUkSetting(request: GetRelationUkSettingRequest): Promise<GetRelationUkSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelationUkSettingHeaders({ });
    return await this.getRelationUkSettingWithOptions(request, headers, runtime);
  }

  async getRelationUkSettingWithOptions(request: GetRelationUkSettingRequest, headers: GetRelationUkSettingHeaders, runtime: $Util.RuntimeOptions): Promise<GetRelationUkSettingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.relationType)) {
      query["relationType"] = request.relationType;
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
    return $tea.cast<GetRelationUkSettingResponse>(await this.doROARequest("GetRelationUkSetting", "crm_2.0", "HTTP", "GET", "AK", `/v2.0/crm/relationUkSettings`, "json", req, runtime), new GetRelationUkSettingResponse({}));
  }

}
