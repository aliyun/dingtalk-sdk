// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class IndustrializeManufactureJobBookRequest extends $tea.Model {
  scrappedQuantity?: string;
  productSpecification?: string;
  qualifiedQuantity?: string;
  reworkableQuantity?: string;
  userName?: string;
  uuid?: string;
  productName?: string;
  productEnName?: string;
  extend?: string;
  productCode?: string;
  processName?: string;
  processEnName?: string;
  mesAppKey?: string;
  instNo?: string;
  manufactureDate?: string;
  dingCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      scrappedQuantity: 'scrappedQuantity',
      productSpecification: 'productSpecification',
      qualifiedQuantity: 'qualifiedQuantity',
      reworkableQuantity: 'reworkableQuantity',
      userName: 'userName',
      uuid: 'uuid',
      productName: 'productName',
      productEnName: 'productEnName',
      extend: 'extend',
      productCode: 'productCode',
      processName: 'processName',
      processEnName: 'processEnName',
      mesAppKey: 'mesAppKey',
      instNo: 'instNo',
      manufactureDate: 'manufactureDate',
      dingCorpId: 'dingCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scrappedQuantity: 'string',
      productSpecification: 'string',
      qualifiedQuantity: 'string',
      reworkableQuantity: 'string',
      userName: 'string',
      uuid: 'string',
      productName: 'string',
      productEnName: 'string',
      extend: 'string',
      productCode: 'string',
      processName: 'string',
      processEnName: 'string',
      mesAppKey: 'string',
      instNo: 'string',
      manufactureDate: 'string',
      dingCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponseBody extends $tea.Model {
  httpCode?: string;
  uuid?: string;
  content?: string;
  errorMsg?: string;
  errorLevel?: number;
  errorCode?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      httpCode: 'httpCode',
      uuid: 'uuid',
      content: 'content',
      errorMsg: 'errorMsg',
      errorLevel: 'errorLevel',
      errorCode: 'errorCode',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      httpCode: 'string',
      uuid: 'string',
      content: 'string',
      errorMsg: 'string',
      errorLevel: 'number',
      errorCode: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustrializeManufactureJobBookResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustrializeManufactureJobBookResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureQueryJobsHeaders extends $tea.Model {
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

export class IndustrializeManufactureQueryJobsRequest extends $tea.Model {
  productName?: string;
  pageSize?: number;
  qualifiedQuantity?: string;
  manufactureDay?: string;
  instNo?: string;
  userName?: string;
  productCode?: string;
  productSpecification?: string;
  unitPrice?: string;
  uuid?: string;
  currentPage?: number;
  userId?: string;
  mesAppKey?: string;
  static names(): { [key: string]: string } {
    return {
      productName: 'productName',
      pageSize: 'pageSize',
      qualifiedQuantity: 'qualifiedQuantity',
      manufactureDay: 'manufactureDay',
      instNo: 'instNo',
      userName: 'userName',
      productCode: 'productCode',
      productSpecification: 'productSpecification',
      unitPrice: 'unitPrice',
      uuid: 'uuid',
      currentPage: 'currentPage',
      userId: 'userId',
      mesAppKey: 'mesAppKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      productName: 'string',
      pageSize: 'number',
      qualifiedQuantity: 'string',
      manufactureDay: 'string',
      instNo: 'string',
      userName: 'string',
      productCode: 'string',
      productSpecification: 'string',
      unitPrice: 'string',
      uuid: 'string',
      currentPage: 'number',
      userId: 'string',
      mesAppKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureQueryJobsResponseBody extends $tea.Model {
  httpCode?: string;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      httpCode: 'httpCode',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      httpCode: 'string',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureQueryJobsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustrializeManufactureQueryJobsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustrializeManufactureQueryJobsResponseBody,
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


  async industrializeManufactureJobBook(userId: string, request: IndustrializeManufactureJobBookRequest): Promise<IndustrializeManufactureJobBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.industrializeManufactureJobBookWithOptions(userId, request, headers, runtime);
  }

  async industrializeManufactureJobBookWithOptions(userId: string, request: IndustrializeManufactureJobBookRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<IndustrializeManufactureJobBookResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scrappedQuantity)) {
      body["scrappedQuantity"] = request.scrappedQuantity;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.qualifiedQuantity)) {
      body["qualifiedQuantity"] = request.qualifiedQuantity;
    }

    if (!Util.isUnset(request.reworkableQuantity)) {
      body["reworkableQuantity"] = request.reworkableQuantity;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productEnName)) {
      body["productEnName"] = request.productEnName;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.processName)) {
      body["processName"] = request.processName;
    }

    if (!Util.isUnset(request.processEnName)) {
      body["processEnName"] = request.processEnName;
    }

    if (!Util.isUnset(request.mesAppKey)) {
      body["mesAppKey"] = request.mesAppKey;
    }

    if (!Util.isUnset(request.instNo)) {
      body["instNo"] = request.instNo;
    }

    if (!Util.isUnset(request.manufactureDate)) {
      body["manufactureDate"] = request.manufactureDate;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<IndustrializeManufactureJobBookResponse>(await this.doROARequest("IndustrializeManufactureJobBook", "manufacturing_1.0", "HTTP", "POST", "AK", `/v1.0/manufacturing/users/${userId}/jobs`, "json", req, runtime), new IndustrializeManufactureJobBookResponse({}));
  }

  async industrializeManufactureQueryJobs(request: IndustrializeManufactureQueryJobsRequest): Promise<IndustrializeManufactureQueryJobsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustrializeManufactureQueryJobsHeaders({ });
    return await this.industrializeManufactureQueryJobsWithOptions(request, headers, runtime);
  }

  async industrializeManufactureQueryJobsWithOptions(request: IndustrializeManufactureQueryJobsRequest, headers: IndustrializeManufactureQueryJobsHeaders, runtime: $Util.RuntimeOptions): Promise<IndustrializeManufactureQueryJobsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.qualifiedQuantity)) {
      body["qualifiedQuantity"] = request.qualifiedQuantity;
    }

    if (!Util.isUnset(request.manufactureDay)) {
      body["manufactureDay"] = request.manufactureDay;
    }

    if (!Util.isUnset(request.instNo)) {
      body["instNo"] = request.instNo;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.unitPrice)) {
      body["unitPrice"] = request.unitPrice;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.mesAppKey)) {
      body["mesAppKey"] = request.mesAppKey;
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
    return $tea.cast<IndustrializeManufactureQueryJobsResponse>(await this.doROARequest("IndustrializeManufactureQueryJobs", "manufacturing_1.0", "HTTP", "POST", "AK", `/v1.0/manufacturing/users/jobs/query`, "json", req, runtime), new IndustrializeManufactureQueryJobsResponse({}));
  }

}
