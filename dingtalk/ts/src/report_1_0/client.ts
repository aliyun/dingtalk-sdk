// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateTemplatesHeaders extends $tea.Model {
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

export class CreateTemplatesRequest extends $tea.Model {
  allowAddReceivers?: boolean;
  allowEdit?: boolean;
  allowGetLocation?: boolean;
  authDeptIds?: string[];
  authUserIds?: string[];
  creator?: string;
  defaultReceivedCids?: string[];
  defaultReceivedMasterLevels?: string[];
  defaultReceivers?: string[];
  fields?: CreateTemplatesRequestFields[];
  logo?: string;
  maxWordCount?: number;
  minWordCount?: number;
  name?: string;
  templateManagers?: string[];
  static names(): { [key: string]: string } {
    return {
      allowAddReceivers: 'allowAddReceivers',
      allowEdit: 'allowEdit',
      allowGetLocation: 'allowGetLocation',
      authDeptIds: 'authDeptIds',
      authUserIds: 'authUserIds',
      creator: 'creator',
      defaultReceivedCids: 'defaultReceivedCids',
      defaultReceivedMasterLevels: 'defaultReceivedMasterLevels',
      defaultReceivers: 'defaultReceivers',
      fields: 'fields',
      logo: 'logo',
      maxWordCount: 'maxWordCount',
      minWordCount: 'minWordCount',
      name: 'name',
      templateManagers: 'templateManagers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowAddReceivers: 'boolean',
      allowEdit: 'boolean',
      allowGetLocation: 'boolean',
      authDeptIds: { 'type': 'array', 'itemType': 'string' },
      authUserIds: { 'type': 'array', 'itemType': 'string' },
      creator: 'string',
      defaultReceivedCids: { 'type': 'array', 'itemType': 'string' },
      defaultReceivedMasterLevels: { 'type': 'array', 'itemType': 'string' },
      defaultReceivers: { 'type': 'array', 'itemType': 'string' },
      fields: { 'type': 'array', 'itemType': CreateTemplatesRequestFields },
      logo: 'string',
      maxWordCount: 'number',
      minWordCount: 'number',
      name: 'string',
      templateManagers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesResponseBody extends $tea.Model {
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateTemplatesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequestFieldsDataValueOpenInfo extends $tea.Model {
  attribute?: { [key: string]: string };
  openId?: string;
  static names(): { [key: string]: string } {
    return {
      attribute: 'attribute',
      openId: 'openId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attribute: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      openId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequestFieldsDataValue extends $tea.Model {
  openInfo?: CreateTemplatesRequestFieldsDataValueOpenInfo;
  options?: string[];
  placeholder?: string;
  static names(): { [key: string]: string } {
    return {
      openInfo: 'openInfo',
      options: 'options',
      placeholder: 'placeholder',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openInfo: CreateTemplatesRequestFieldsDataValueOpenInfo,
      options: { 'type': 'array', 'itemType': 'string' },
      placeholder: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTemplatesRequestFields extends $tea.Model {
  dataType?: number;
  dataValue?: CreateTemplatesRequestFieldsDataValue;
  fieldName?: string;
  need?: boolean;
  order?: number;
  sort?: number;
  static names(): { [key: string]: string } {
    return {
      dataType: 'dataType',
      dataValue: 'dataValue',
      fieldName: 'fieldName',
      need: 'need',
      order: 'order',
      sort: 'sort',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataType: 'number',
      dataValue: CreateTemplatesRequestFieldsDataValue,
      fieldName: 'string',
      need: 'boolean',
      order: 'number',
      sort: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async createTemplatesWithOptions(request: CreateTemplatesRequest, headers: CreateTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTemplatesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.allowAddReceivers)) {
      body["allowAddReceivers"] = request.allowAddReceivers;
    }

    if (!Util.isUnset(request.allowEdit)) {
      body["allowEdit"] = request.allowEdit;
    }

    if (!Util.isUnset(request.allowGetLocation)) {
      body["allowGetLocation"] = request.allowGetLocation;
    }

    if (!Util.isUnset(request.authDeptIds)) {
      body["authDeptIds"] = request.authDeptIds;
    }

    if (!Util.isUnset(request.authUserIds)) {
      body["authUserIds"] = request.authUserIds;
    }

    if (!Util.isUnset(request.creator)) {
      body["creator"] = request.creator;
    }

    if (!Util.isUnset(request.defaultReceivedCids)) {
      body["defaultReceivedCids"] = request.defaultReceivedCids;
    }

    if (!Util.isUnset(request.defaultReceivedMasterLevels)) {
      body["defaultReceivedMasterLevels"] = request.defaultReceivedMasterLevels;
    }

    if (!Util.isUnset(request.defaultReceivers)) {
      body["defaultReceivers"] = request.defaultReceivers;
    }

    if (!Util.isUnset(request.fields)) {
      body["fields"] = request.fields;
    }

    if (!Util.isUnset(request.logo)) {
      body["logo"] = request.logo;
    }

    if (!Util.isUnset(request.maxWordCount)) {
      body["maxWordCount"] = request.maxWordCount;
    }

    if (!Util.isUnset(request.minWordCount)) {
      body["minWordCount"] = request.minWordCount;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.templateManagers)) {
      body["templateManagers"] = request.templateManagers;
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
    let params = new $OpenApi.Params({
      action: "CreateTemplates",
      version: "report_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/report/templates`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTemplatesResponse>(await this.execute(params, req, runtime), new CreateTemplatesResponse({}));
  }

  async createTemplates(request: CreateTemplatesRequest): Promise<CreateTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTemplatesHeaders({ });
    return await this.createTemplatesWithOptions(request, headers, runtime);
  }

}
