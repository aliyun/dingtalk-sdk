// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class IndustrializeManufactureJobBookRequest extends $tea.Model {
  corpId?: string;
  extend?: string;
  instNo?: string;
  isBatchJob?: string;
  manufactureDate?: string;
  mesAppKey?: string;
  processEnName?: string;
  processName?: string;
  productCode?: string;
  productEnName?: string;
  productName?: string;
  productSpecification?: string;
  qualifiedQuantity?: string;
  reworkableQuantity?: string;
  scrappedQuantity?: string;
  unitPrice?: string;
  userIdList?: string;
  userName?: string;
  userNameList?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      extend: 'extend',
      instNo: 'instNo',
      isBatchJob: 'isBatchJob',
      manufactureDate: 'manufactureDate',
      mesAppKey: 'mesAppKey',
      processEnName: 'processEnName',
      processName: 'processName',
      productCode: 'productCode',
      productEnName: 'productEnName',
      productName: 'productName',
      productSpecification: 'productSpecification',
      qualifiedQuantity: 'qualifiedQuantity',
      reworkableQuantity: 'reworkableQuantity',
      scrappedQuantity: 'scrappedQuantity',
      unitPrice: 'unitPrice',
      userIdList: 'userIdList',
      userName: 'userName',
      userNameList: 'userNameList',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      extend: 'string',
      instNo: 'string',
      isBatchJob: 'string',
      manufactureDate: 'string',
      mesAppKey: 'string',
      processEnName: 'string',
      processName: 'string',
      productCode: 'string',
      productEnName: 'string',
      productName: 'string',
      productSpecification: 'string',
      qualifiedQuantity: 'string',
      reworkableQuantity: 'string',
      scrappedQuantity: 'string',
      unitPrice: 'string',
      userIdList: 'string',
      userName: 'string',
      userNameList: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponseBody extends $tea.Model {
  content?: IndustrializeManufactureJobBookResponseBodyContent;
  errorCode?: string;
  errorLevel?: number;
  errorMsg?: string;
  httpCode?: string;
  success?: boolean;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      errorCode: 'errorCode',
      errorLevel: 'errorLevel',
      errorMsg: 'errorMsg',
      httpCode: 'httpCode',
      success: 'success',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: IndustrializeManufactureJobBookResponseBodyContent,
      errorCode: 'string',
      errorLevel: 'number',
      errorMsg: 'string',
      httpCode: 'string',
      success: 'boolean',
      uuid: 'string',
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
  currentPage?: number;
  instNo?: string;
  manufactureDay?: string;
  mesAppKey?: string;
  pageSize?: number;
  processName?: string;
  productCode?: string;
  productName?: string;
  productSpecification?: string;
  qualifiedQuantity?: string;
  unitPrice?: string;
  userId?: string;
  userIdList?: string;
  userName?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      instNo: 'instNo',
      manufactureDay: 'manufactureDay',
      mesAppKey: 'mesAppKey',
      pageSize: 'pageSize',
      processName: 'processName',
      productCode: 'productCode',
      productName: 'productName',
      productSpecification: 'productSpecification',
      qualifiedQuantity: 'qualifiedQuantity',
      unitPrice: 'unitPrice',
      userId: 'userId',
      userIdList: 'userIdList',
      userName: 'userName',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      instNo: 'string',
      manufactureDay: 'string',
      mesAppKey: 'string',
      pageSize: 'number',
      processName: 'string',
      productCode: 'string',
      productName: 'string',
      productSpecification: 'string',
      qualifiedQuantity: 'string',
      unitPrice: 'string',
      userId: 'string',
      userIdList: 'string',
      userName: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureQueryJobsResponseBody extends $tea.Model {
  content?: IndustrializeManufactureQueryJobsResponseBodyContent;
  httpCode?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      httpCode: 'httpCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: IndustrializeManufactureQueryJobsResponseBodyContent,
      httpCode: 'string',
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

export class IndustrializeManufactureJobBookResponseBodyContent extends $tea.Model {
  count?: number;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureQueryJobsResponseBodyContent extends $tea.Model {
  corpId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  id?: number;
  instNo?: string;
  isBatchJob?: string;
  manufactureDate?: string;
  manufactureDay?: string;
  mesAppKey?: string;
  processName?: string;
  qualifiedQuantity?: string;
  scrappedQuantity?: string;
  unitPrice?: string;
  userId?: string;
  userIdList?: string;
  userNameList?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      instNo: 'instNo',
      isBatchJob: 'isBatchJob',
      manufactureDate: 'manufactureDate',
      manufactureDay: 'manufactureDay',
      mesAppKey: 'mesAppKey',
      processName: 'processName',
      qualifiedQuantity: 'qualifiedQuantity',
      scrappedQuantity: 'scrappedQuantity',
      unitPrice: 'unitPrice',
      userId: 'userId',
      userIdList: 'userIdList',
      userNameList: 'userNameList',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      id: 'number',
      instNo: 'string',
      isBatchJob: 'string',
      manufactureDate: 'string',
      manufactureDay: 'string',
      mesAppKey: 'string',
      processName: 'string',
      qualifiedQuantity: 'string',
      scrappedQuantity: 'string',
      unitPrice: 'string',
      userId: 'string',
      userIdList: 'string',
      userNameList: 'string',
      uuid: 'string',
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
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.instNo)) {
      body["instNo"] = request.instNo;
    }

    if (!Util.isUnset(request.isBatchJob)) {
      body["isBatchJob"] = request.isBatchJob;
    }

    if (!Util.isUnset(request.manufactureDate)) {
      body["manufactureDate"] = request.manufactureDate;
    }

    if (!Util.isUnset(request.mesAppKey)) {
      body["mesAppKey"] = request.mesAppKey;
    }

    if (!Util.isUnset(request.processEnName)) {
      body["processEnName"] = request.processEnName;
    }

    if (!Util.isUnset(request.processName)) {
      body["processName"] = request.processName;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productEnName)) {
      body["productEnName"] = request.productEnName;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
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

    if (!Util.isUnset(request.scrappedQuantity)) {
      body["scrappedQuantity"] = request.scrappedQuantity;
    }

    if (!Util.isUnset(request.unitPrice)) {
      body["unitPrice"] = request.unitPrice;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.userNameList)) {
      body["userNameList"] = request.userNameList;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.instNo)) {
      body["instNo"] = request.instNo;
    }

    if (!Util.isUnset(request.manufactureDay)) {
      body["manufactureDay"] = request.manufactureDay;
    }

    if (!Util.isUnset(request.mesAppKey)) {
      body["mesAppKey"] = request.mesAppKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processName)) {
      body["processName"] = request.processName;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.qualifiedQuantity)) {
      body["qualifiedQuantity"] = request.qualifiedQuantity;
    }

    if (!Util.isUnset(request.unitPrice)) {
      body["unitPrice"] = request.unitPrice;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
    return $tea.cast<IndustrializeManufactureQueryJobsResponse>(await this.doROARequest("IndustrializeManufactureQueryJobs", "manufacturing_1.0", "HTTP", "POST", "AK", `/v1.0/manufacturing/users/jobs/query`, "json", req, runtime), new IndustrializeManufactureQueryJobsResponse({}));
  }

}
