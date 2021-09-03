// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class SaveFormDataHeaders extends $tea.Model {
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

export class SaveFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  formDataJson?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      formDataJson: 'formDataJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      formDataJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveFormDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasHeaders extends $tea.Model {
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

export class SearchFormDatasRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  searchFieldJson?: string;
  currentPage?: number;
  pageSize?: number;
  originatorId?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  dynamicOrder?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      searchFieldJson: 'searchFieldJson',
      currentPage: 'currentPage',
      pageSize: 'pageSize',
      originatorId: 'originatorId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      dynamicOrder: 'dynamicOrder',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      searchFieldJson: 'string',
      currentPage: 'number',
      pageSize: 'number',
      originatorId: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      dynamicOrder: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBody extends $tea.Model {
  currentPage?: number;
  totalCount?: number;
  data?: SearchFormDatasResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      totalCount: 'number',
      data: { 'type': 'array', 'itemType': SearchFormDatasResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchFormDatasResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchFormDatasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenHeaders extends $tea.Model {
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

export class LoginCodeGenRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: LoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LoginCodeGenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDHeaders extends $tea.Model {
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

export class GetFormDataByIDRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBody extends $tea.Model {
  originator?: GetFormDataByIDResponseBodyOriginator;
  modifiedTimeGMT?: string;
  formUuid?: string;
  formInstId?: string;
  formData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      originator: 'originator',
      modifiedTimeGMT: 'modifiedTimeGMT',
      formUuid: 'formUuid',
      formInstId: 'formInstId',
      formData: 'formData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      originator: GetFormDataByIDResponseBodyOriginator,
      modifiedTimeGMT: 'string',
      formUuid: 'string',
      formInstId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFormDataByIDResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFormDataByIDResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataOriginatorUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataOriginator extends $tea.Model {
  userId?: string;
  userName?: SearchFormDatasResponseBodyDataOriginatorUserName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataOriginatorUserName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataModifyUserUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataModifyUser extends $tea.Model {
  userId?: string;
  userName?: SearchFormDatasResponseBodyDataModifyUserUserName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataModifyUserUserName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyData extends $tea.Model {
  dataId?: number;
  formInstanceId?: string;
  createdTimeGMT?: string;
  modifiedTimeGMT?: string;
  formUuid?: string;
  modelUuid?: string;
  originator?: SearchFormDatasResponseBodyDataOriginator;
  modifyUser?: SearchFormDatasResponseBodyDataModifyUser;
  formData?: { [key: string]: any };
  title?: string;
  serialNo?: string;
  instanceValue?: string;
  version?: number;
  creatorUserId?: string;
  modifierUserId?: string;
  sequence?: string;
  static names(): { [key: string]: string } {
    return {
      dataId: 'dataId',
      formInstanceId: 'formInstanceId',
      createdTimeGMT: 'createdTimeGMT',
      modifiedTimeGMT: 'modifiedTimeGMT',
      formUuid: 'formUuid',
      modelUuid: 'modelUuid',
      originator: 'originator',
      modifyUser: 'modifyUser',
      formData: 'formData',
      title: 'title',
      serialNo: 'serialNo',
      instanceValue: 'instanceValue',
      version: 'version',
      creatorUserId: 'creatorUserId',
      modifierUserId: 'modifierUserId',
      sequence: 'sequence',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataId: 'number',
      formInstanceId: 'string',
      createdTimeGMT: 'string',
      modifiedTimeGMT: 'string',
      formUuid: 'string',
      modelUuid: 'string',
      originator: SearchFormDatasResponseBodyDataOriginator,
      modifyUser: SearchFormDatasResponseBodyDataModifyUser,
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      title: 'string',
      serialNo: 'string',
      instanceValue: 'string',
      version: 'number',
      creatorUserId: 'string',
      modifierUserId: 'string',
      sequence: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBodyOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBodyOriginator extends $tea.Model {
  userId?: string;
  name?: GetFormDataByIDResponseBodyOriginatorName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: GetFormDataByIDResponseBodyOriginatorName,
      departmentName: 'string',
      email: 'string',
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


  async saveFormData(request: SaveFormDataRequest): Promise<SaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormDataHeaders({ });
    return await this.saveFormDataWithOptions(request, headers, runtime);
  }

  async saveFormDataWithOptions(request: SaveFormDataRequest, headers: SaveFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
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
    return $tea.cast<SaveFormDataResponse>(await this.doROARequest("SaveFormData", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances`, "json", req, runtime), new SaveFormDataResponse({}));
  }

  async searchFormDatas(request: SearchFormDatasRequest): Promise<SearchFormDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDatasHeaders({ });
    return await this.searchFormDatasWithOptions(request, headers, runtime);
  }

  async searchFormDatasWithOptions(request: SearchFormDatasRequest, headers: SearchFormDatasHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDatasResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.dynamicOrder)) {
      body["dynamicOrder"] = request.dynamicOrder;
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
    return $tea.cast<SearchFormDatasResponse>(await this.doROARequest("SearchFormDatas", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances/search`, "json", req, runtime), new SearchFormDatasResponse({}));
  }

  async loginCodeGen(request: LoginCodeGenRequest): Promise<LoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoginCodeGenHeaders({ });
    return await this.loginCodeGenWithOptions(request, headers, runtime);
  }

  async loginCodeGenWithOptions(request: LoginCodeGenRequest, headers: LoginCodeGenHeaders, runtime: $Util.RuntimeOptions): Promise<LoginCodeGenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<LoginCodeGenResponse>(await this.doROARequest("LoginCodeGen", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/authorizations/loginCodes`, "json", req, runtime), new LoginCodeGenResponse({}));
  }

  async getFormDataByID(id: string, request: GetFormDataByIDRequest): Promise<GetFormDataByIDResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormDataByIDHeaders({ });
    return await this.getFormDataByIDWithOptions(id, request, headers, runtime);
  }

  async getFormDataByIDWithOptions(id: string, request: GetFormDataByIDRequest, headers: GetFormDataByIDHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormDataByIDResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetFormDataByIDResponse>(await this.doROARequest("GetFormDataByID", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/forms/instances/${id}`, "json", req, runtime), new GetFormDataByIDResponse({}));
  }

}
