// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class IndustrializeManufactureJobBookRequest extends $tea.Model {
  /**
   * @example
   * ding2fff8349a3ae0105d
   */
  corpId?: string;
  /**
   * @example
   * [     { 		"code": "equipmentName"， 		"name": "设备名称", 		"value": "8000", 		"valueType": "类型：字符串，数字等" 	}, { 		"code": "唯一标识"， 		"name": "自定义字段1", 		"value": "值", 		"valueType": "类型：字符串，数字等" 	}, { 		"code": "唯一标识"， 		"name": "自定义字段2", 		"value": "值", 		"valueType": "类型：字符串，数字等" 	}  ]
   */
  extend?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  instNo?: string;
  /**
   * @example
   * n
   */
  isBatchJob?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-07-05 08:00:21
   */
  manufactureDate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mesAppKey?: string;
  processEnName?: string;
  processName?: string;
  productCode?: string;
  productEnName?: string;
  productName?: string;
  productSpecification?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  qualifiedQuantity?: string;
  reworkableQuantity?: string;
  scrappedQuantity?: string;
  /**
   * @example
   * 1.02
   */
  unitPrice?: string;
  /**
   * @example
   * 1919442747879777, 1919442747879774
   */
  userIdList?: string;
  userName?: string;
  /**
   * @example
   * 张三,李四
   */
  userNameList?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: IndustrializeManufactureJobBookResponseBody;
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
  /**
   * @example
   * 1
   */
  currentPage?: number;
  /**
   * @example
   * d41d8cd98f00b204e9800998ecf8427e
   */
  instNo?: string;
  /**
   * @example
   * 2021-07-05
   */
  manufactureDay?: string;
  /**
   * @example
   * mes41d8cd98f00b204e9800998ecf8427e
   */
  mesAppKey?: string;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  processName?: string;
  /**
   * @example
   * A001
   */
  productCode?: string;
  /**
   * @example
   * 双头螺柱001
   */
  productName?: string;
  /**
   * @example
   * M56*3*10501
   */
  productSpecification?: string;
  /**
   * @example
   * 100
   */
  qualifiedQuantity?: string;
  /**
   * @example
   * 1.2
   */
  unitPrice?: string;
  /**
   * @example
   * 1919442747879773
   */
  userId?: string;
  /**
   * @example
   * 111,222
   */
  userIdList?: string;
  /**
   * @example
   * 张三
   */
  userName?: string;
  /**
   * @example
   * d41d8cd98f00b204e9800998ecf8427e
   */
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
  /**
   * @example
   * 200
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: IndustrializeManufactureQueryJobsResponseBody;
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
      body: IndustrializeManufactureQueryJobsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponseBodyContent extends $tea.Model {
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingdb6elngd253073ad370d8dc3ec89bb366ab
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  instNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  isBatchJob?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  manufactureDate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  manufactureDay?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mesAppKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  qualifiedQuantity?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  scrappedQuantity?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unitPrice?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userIdList?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userNameList?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 日清月结-计件报工接口
   * 
   * @param request - IndustrializeManufactureJobBookRequest
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns IndustrializeManufactureJobBookResponse
   */
  async industrializeManufactureJobBookWithOptions(userId: string, request: IndustrializeManufactureJobBookRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<IndustrializeManufactureJobBookResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "IndustrializeManufactureJobBook",
      version: "manufacturing_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/manufacturing/users/${userId}/jobs`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustrializeManufactureJobBookResponse>(await this.execute(params, req, runtime), new IndustrializeManufactureJobBookResponse({}));
  }

  /**
   * 日清月结-计件报工接口
   * 
   * @param request - IndustrializeManufactureJobBookRequest
   * @returns IndustrializeManufactureJobBookResponse
   */
  async industrializeManufactureJobBook(userId: string, request: IndustrializeManufactureJobBookRequest): Promise<IndustrializeManufactureJobBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.industrializeManufactureJobBookWithOptions(userId, request, headers, runtime);
  }

  /**
   * 日清月结-计件报工查询接口
   * 
   * @param request - IndustrializeManufactureQueryJobsRequest
   * @param headers - IndustrializeManufactureQueryJobsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns IndustrializeManufactureQueryJobsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "IndustrializeManufactureQueryJobs",
      version: "manufacturing_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/manufacturing/users/jobs/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IndustrializeManufactureQueryJobsResponse>(await this.execute(params, req, runtime), new IndustrializeManufactureQueryJobsResponse({}));
  }

  /**
   * 日清月结-计件报工查询接口
   * 
   * @param request - IndustrializeManufactureQueryJobsRequest
   * @returns IndustrializeManufactureQueryJobsResponse
   */
  async industrializeManufactureQueryJobs(request: IndustrializeManufactureQueryJobsRequest): Promise<IndustrializeManufactureQueryJobsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustrializeManufactureQueryJobsHeaders({ });
    return await this.industrializeManufactureQueryJobsWithOptions(request, headers, runtime);
  }

}
