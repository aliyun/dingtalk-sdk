// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchCreateTemplateHeaders extends $tea.Model {
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

export class BatchCreateTemplateRequest extends $tea.Model {
  templateList?: BatchCreateTemplateRequestTemplateList[];
  static names(): { [key: string]: string } {
    return {
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateList: { 'type': 'array', 'itemType': BatchCreateTemplateRequestTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTemplateResponseBody extends $tea.Model {
  createResultList?: BatchCreateTemplateResponseBodyCreateResultList[];
  static names(): { [key: string]: string } {
    return {
      createResultList: 'createResultList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createResultList: { 'type': 'array', 'itemType': BatchCreateTemplateResponseBodyCreateResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchCreateTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchCreateTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryByTemplateKeyHeaders extends $tea.Model {
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

export class BatchQueryByTemplateKeyRequest extends $tea.Model {
  templateKeys?: string[];
  static names(): { [key: string]: string } {
    return {
      templateKeys: 'templateKeys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateKeys: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryByTemplateKeyResponseBody extends $tea.Model {
  templateList?: BatchQueryByTemplateKeyResponseBodyTemplateList[];
  static names(): { [key: string]: string } {
    return {
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateList: { 'type': 'array', 'itemType': BatchQueryByTemplateKeyResponseBodyTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryByTemplateKeyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchQueryByTemplateKeyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchQueryByTemplateKeyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateTemplateHeaders extends $tea.Model {
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

export class BatchUpdateTemplateRequest extends $tea.Model {
  templateList?: BatchUpdateTemplateRequestTemplateList[];
  static names(): { [key: string]: string } {
    return {
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateList: { 'type': 'array', 'itemType': BatchUpdateTemplateRequestTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateTemplateResponseBody extends $tea.Model {
  updateResultList?: BatchUpdateTemplateResponseBodyUpdateResultList[];
  static names(): { [key: string]: string } {
    return {
      updateResultList: 'updateResultList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updateResultList: { 'type': 'array', 'itemType': BatchUpdateTemplateResponseBodyUpdateResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchUpdateTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchUpdateTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIndustryTagListHeaders extends $tea.Model {
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

export class QueryIndustryTagListResponseBody extends $tea.Model {
  industryList?: string[];
  static names(): { [key: string]: string } {
    return {
      industryList: 'industryList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      industryList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryIndustryTagListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryIndustryTagListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryIndustryTagListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRoleTagListHeaders extends $tea.Model {
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

export class QueryRoleTagListResponseBody extends $tea.Model {
  roleList?: string[];
  static names(): { [key: string]: string } {
    return {
      roleList: 'roleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRoleTagListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryRoleTagListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryRoleTagListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTemplateCategorysHeaders extends $tea.Model {
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

export class QueryTemplateCategorysResponseBody extends $tea.Model {
  categoryList?: QueryTemplateCategorysResponseBodyCategoryList[];
  total?: string;
  static names(): { [key: string]: string } {
    return {
      categoryList: 'categoryList',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryList: { 'type': 'array', 'itemType': QueryTemplateCategorysResponseBodyCategoryList },
      total: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTemplateCategorysResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryTemplateCategorysResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryTemplateCategorysResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallAuditTemplateHeaders extends $tea.Model {
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

export class RecallAuditTemplateRequest extends $tea.Model {
  templateKeys?: string[];
  static names(): { [key: string]: string } {
    return {
      templateKeys: 'templateKeys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateKeys: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallAuditTemplateResponseBody extends $tea.Model {
  recallResult?: RecallAuditTemplateResponseBodyRecallResult[];
  static names(): { [key: string]: string } {
    return {
      recallResult: 'recallResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recallResult: { 'type': 'array', 'itemType': RecallAuditTemplateResponseBodyRecallResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallAuditTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RecallAuditTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RecallAuditTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTemplateRequestTemplateList extends $tea.Model {
  adaptEnv?: string[];
  appDesc?: string;
  appIcon?: string;
  caseVideoList?: string[];
  categoryCode?: string;
  coverImgList?: string[];
  expUrl?: string;
  industryLabelList?: string[];
  installTimes?: number;
  mobilePreviewMediaList?: string[];
  name?: string;
  previewMediaList?: string[];
  providerName?: string;
  roleLabelList?: string[];
  simpleDesc?: string;
  templateKey?: string;
  useCasesMediaList?: string[];
  static names(): { [key: string]: string } {
    return {
      adaptEnv: 'adaptEnv',
      appDesc: 'appDesc',
      appIcon: 'appIcon',
      caseVideoList: 'caseVideoList',
      categoryCode: 'categoryCode',
      coverImgList: 'coverImgList',
      expUrl: 'expUrl',
      industryLabelList: 'industryLabelList',
      installTimes: 'installTimes',
      mobilePreviewMediaList: 'mobilePreviewMediaList',
      name: 'name',
      previewMediaList: 'previewMediaList',
      providerName: 'providerName',
      roleLabelList: 'roleLabelList',
      simpleDesc: 'simpleDesc',
      templateKey: 'templateKey',
      useCasesMediaList: 'useCasesMediaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adaptEnv: { 'type': 'array', 'itemType': 'string' },
      appDesc: 'string',
      appIcon: 'string',
      caseVideoList: { 'type': 'array', 'itemType': 'string' },
      categoryCode: 'string',
      coverImgList: { 'type': 'array', 'itemType': 'string' },
      expUrl: 'string',
      industryLabelList: { 'type': 'array', 'itemType': 'string' },
      installTimes: 'number',
      mobilePreviewMediaList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      previewMediaList: { 'type': 'array', 'itemType': 'string' },
      providerName: 'string',
      roleLabelList: { 'type': 'array', 'itemType': 'string' },
      simpleDesc: 'string',
      templateKey: 'string',
      useCasesMediaList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTemplateResponseBodyCreateResultList extends $tea.Model {
  templateKey?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      templateKey: 'templateKey',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateKey: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryByTemplateKeyResponseBodyTemplateList extends $tea.Model {
  adaptEnv?: string[];
  appDesc?: string;
  appIcon?: string;
  caseVideoList?: string[];
  category?: string;
  coverImgList?: string[];
  expUrl?: string;
  industryLabelList?: string[];
  installTimes?: number;
  mobilePreviewMediaList?: string[];
  name?: string;
  previewMediaList?: string[];
  providerName?: string;
  roleLabelList?: string[];
  simpleDesc?: string;
  templateKey?: string;
  useCasesMediaList?: string[];
  static names(): { [key: string]: string } {
    return {
      adaptEnv: 'adaptEnv',
      appDesc: 'appDesc',
      appIcon: 'appIcon',
      caseVideoList: 'caseVideoList',
      category: 'category',
      coverImgList: 'coverImgList',
      expUrl: 'expUrl',
      industryLabelList: 'industryLabelList',
      installTimes: 'installTimes',
      mobilePreviewMediaList: 'mobilePreviewMediaList',
      name: 'name',
      previewMediaList: 'previewMediaList',
      providerName: 'providerName',
      roleLabelList: 'roleLabelList',
      simpleDesc: 'simpleDesc',
      templateKey: 'templateKey',
      useCasesMediaList: 'useCasesMediaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adaptEnv: { 'type': 'array', 'itemType': 'string' },
      appDesc: 'string',
      appIcon: 'string',
      caseVideoList: { 'type': 'array', 'itemType': 'string' },
      category: 'string',
      coverImgList: { 'type': 'array', 'itemType': 'string' },
      expUrl: 'string',
      industryLabelList: { 'type': 'array', 'itemType': 'string' },
      installTimes: 'number',
      mobilePreviewMediaList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      previewMediaList: { 'type': 'array', 'itemType': 'string' },
      providerName: 'string',
      roleLabelList: { 'type': 'array', 'itemType': 'string' },
      simpleDesc: 'string',
      templateKey: 'string',
      useCasesMediaList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateTemplateRequestTemplateList extends $tea.Model {
  adaptEnv?: string[];
  appDesc?: string;
  appIcon?: string;
  caseVideoList?: string[];
  categoryCode?: string;
  coverImgList?: string[];
  expUrl?: string;
  industryLabelList?: string[];
  mobilePreviewMediaList?: string[];
  name?: string;
  previewMediaList?: string[];
  providerName?: string;
  roleLabelList?: string[];
  simpleDesc?: string;
  templateKey?: string;
  useCasesMediaList?: string[];
  static names(): { [key: string]: string } {
    return {
      adaptEnv: 'adaptEnv',
      appDesc: 'appDesc',
      appIcon: 'appIcon',
      caseVideoList: 'caseVideoList',
      categoryCode: 'categoryCode',
      coverImgList: 'coverImgList',
      expUrl: 'expUrl',
      industryLabelList: 'industryLabelList',
      mobilePreviewMediaList: 'mobilePreviewMediaList',
      name: 'name',
      previewMediaList: 'previewMediaList',
      providerName: 'providerName',
      roleLabelList: 'roleLabelList',
      simpleDesc: 'simpleDesc',
      templateKey: 'templateKey',
      useCasesMediaList: 'useCasesMediaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adaptEnv: { 'type': 'array', 'itemType': 'string' },
      appDesc: 'string',
      appIcon: 'string',
      caseVideoList: { 'type': 'array', 'itemType': 'string' },
      categoryCode: 'string',
      coverImgList: { 'type': 'array', 'itemType': 'string' },
      expUrl: 'string',
      industryLabelList: { 'type': 'array', 'itemType': 'string' },
      mobilePreviewMediaList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      previewMediaList: { 'type': 'array', 'itemType': 'string' },
      providerName: 'string',
      roleLabelList: { 'type': 'array', 'itemType': 'string' },
      simpleDesc: 'string',
      templateKey: 'string',
      useCasesMediaList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateTemplateResponseBodyUpdateResultList extends $tea.Model {
  templateKey?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      templateKey: 'templateKey',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateKey: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTemplateCategorysResponseBodyCategoryList extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallAuditTemplateResponseBodyRecallResult extends $tea.Model {
  templateKey?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      templateKey: 'templateKey',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateKey: 'string',
      value: 'string',
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


  async batchCreateTemplate(request: BatchCreateTemplateRequest): Promise<BatchCreateTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateTemplateHeaders({ });
    return await this.batchCreateTemplateWithOptions(request, headers, runtime);
  }

  async batchCreateTemplateWithOptions(request: BatchCreateTemplateRequest, headers: BatchCreateTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<BatchCreateTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateList)) {
      body["templateList"] = request.templateList;
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
    return $tea.cast<BatchCreateTemplateResponse>(await this.doROARequest("BatchCreateTemplate", "apaas_1.0", "HTTP", "POST", "AK", `/v1.0/apaas/templates`, "json", req, runtime), new BatchCreateTemplateResponse({}));
  }

  async batchQueryByTemplateKey(request: BatchQueryByTemplateKeyRequest): Promise<BatchQueryByTemplateKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryByTemplateKeyHeaders({ });
    return await this.batchQueryByTemplateKeyWithOptions(request, headers, runtime);
  }

  async batchQueryByTemplateKeyWithOptions(request: BatchQueryByTemplateKeyRequest, headers: BatchQueryByTemplateKeyHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryByTemplateKeyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateKeys)) {
      body["templateKeys"] = request.templateKeys;
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
    return $tea.cast<BatchQueryByTemplateKeyResponse>(await this.doROARequest("BatchQueryByTemplateKey", "apaas_1.0", "HTTP", "POST", "AK", `/v1.0/apaas/templates/query`, "json", req, runtime), new BatchQueryByTemplateKeyResponse({}));
  }

  async batchUpdateTemplate(request: BatchUpdateTemplateRequest): Promise<BatchUpdateTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateTemplateHeaders({ });
    return await this.batchUpdateTemplateWithOptions(request, headers, runtime);
  }

  async batchUpdateTemplateWithOptions(request: BatchUpdateTemplateRequest, headers: BatchUpdateTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateList)) {
      body["templateList"] = request.templateList;
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
    return $tea.cast<BatchUpdateTemplateResponse>(await this.doROARequest("BatchUpdateTemplate", "apaas_1.0", "HTTP", "PUT", "AK", `/v1.0/apaas/templates`, "json", req, runtime), new BatchUpdateTemplateResponse({}));
  }

  async queryIndustryTagList(): Promise<QueryIndustryTagListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryIndustryTagListHeaders({ });
    return await this.queryIndustryTagListWithOptions(headers, runtime);
  }

  async queryIndustryTagListWithOptions(headers: QueryIndustryTagListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryIndustryTagListResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryIndustryTagListResponse>(await this.doROARequest("QueryIndustryTagList", "apaas_1.0", "HTTP", "GET", "AK", `/v1.0/apaas/templates/industries`, "json", req, runtime), new QueryIndustryTagListResponse({}));
  }

  async queryRoleTagList(): Promise<QueryRoleTagListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRoleTagListHeaders({ });
    return await this.queryRoleTagListWithOptions(headers, runtime);
  }

  async queryRoleTagListWithOptions(headers: QueryRoleTagListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRoleTagListResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryRoleTagListResponse>(await this.doROARequest("QueryRoleTagList", "apaas_1.0", "HTTP", "GET", "AK", `/v1.0/apaas/templates/roles`, "json", req, runtime), new QueryRoleTagListResponse({}));
  }

  async queryTemplateCategorys(): Promise<QueryTemplateCategorysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTemplateCategorysHeaders({ });
    return await this.queryTemplateCategorysWithOptions(headers, runtime);
  }

  async queryTemplateCategorysWithOptions(headers: QueryTemplateCategorysHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTemplateCategorysResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryTemplateCategorysResponse>(await this.doROARequest("QueryTemplateCategorys", "apaas_1.0", "HTTP", "GET", "AK", `/v1.0/apaas/templates/categories`, "json", req, runtime), new QueryTemplateCategorysResponse({}));
  }

  async recallAuditTemplate(request: RecallAuditTemplateRequest): Promise<RecallAuditTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallAuditTemplateHeaders({ });
    return await this.recallAuditTemplateWithOptions(request, headers, runtime);
  }

  async recallAuditTemplateWithOptions(request: RecallAuditTemplateRequest, headers: RecallAuditTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<RecallAuditTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateKeys)) {
      body["templateKeys"] = request.templateKeys;
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
    return $tea.cast<RecallAuditTemplateResponse>(await this.doROARequest("RecallAuditTemplate", "apaas_1.0", "HTTP", "POST", "AK", `/v1.0/apaas/templates/audits/recall`, "json", req, runtime), new RecallAuditTemplateResponse({}));
  }

}
