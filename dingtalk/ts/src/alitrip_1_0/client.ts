// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddCityCarApplyHeaders extends $tea.Model {
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

export class AddCityCarApplyRequest extends $tea.Model {
  cause?: string;
  city?: string;
  corpId?: string;
  date?: string;
  projectCode?: string;
  projectName?: string;
  status?: number;
  thirdPartApplyId?: string;
  thirdPartCostCenterId?: string;
  thirdPartInvoiceId?: string;
  timesTotal?: number;
  timesType?: number;
  timesUsed?: number;
  title?: string;
  userId?: string;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  finishedDate?: string;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      city: 'city',
      corpId: 'corpId',
      date: 'date',
      projectCode: 'projectCode',
      projectName: 'projectName',
      status: 'status',
      thirdPartApplyId: 'thirdPartApplyId',
      thirdPartCostCenterId: 'thirdPartCostCenterId',
      thirdPartInvoiceId: 'thirdPartInvoiceId',
      timesTotal: 'timesTotal',
      timesType: 'timesType',
      timesUsed: 'timesUsed',
      title: 'title',
      userId: 'userId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
      finishedDate: 'finishedDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      city: 'string',
      corpId: 'string',
      date: 'string',
      projectCode: 'string',
      projectName: 'string',
      status: 'number',
      thirdPartApplyId: 'string',
      thirdPartCostCenterId: 'string',
      thirdPartInvoiceId: 'string',
      timesTotal: 'number',
      timesType: 'number',
      timesUsed: 'number',
      title: 'string',
      userId: 'string',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
      finishedDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCityCarApplyResponseBody extends $tea.Model {
  applyId?: number;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCityCarApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddCityCarApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddCityCarApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyHeaders extends $tea.Model {
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

export class ApproveCityCarApplyRequest extends $tea.Model {
  corpId?: string;
  operateTime?: string;
  remark?: string;
  status?: number;
  thirdPartApplyId?: string;
  userId?: string;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      operateTime: 'operateTime',
      remark: 'remark',
      status: 'status',
      thirdPartApplyId: 'thirdPartApplyId',
      userId: 'userId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      operateTime: 'string',
      remark: 'string',
      status: 'number',
      thirdPartApplyId: 'string',
      userId: 'string',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyResponseBody extends $tea.Model {
  approveResult?: boolean;
  static names(): { [key: string]: string } {
    return {
      approveResult: 'approveResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveResult: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ApproveCityCarApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ApproveCityCarApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderHeaders extends $tea.Model {
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

export class QueryUnionOrderRequest extends $tea.Model {
  corpId?: string;
  thirdPartApplyId?: string;
  unionNo?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      thirdPartApplyId: 'thirdPartApplyId',
      unionNo: 'unionNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      thirdPartApplyId: 'string',
      unionNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBody extends $tea.Model {
  flightList?: QueryUnionOrderResponseBodyFlightList[];
  corpId?: string;
  trainList?: QueryUnionOrderResponseBodyTrainList[];
  hotelList?: QueryUnionOrderResponseBodyHotelList[];
  vehicleList?: QueryUnionOrderResponseBodyVehicleList[];
  static names(): { [key: string]: string } {
    return {
      flightList: 'flightList',
      corpId: 'corpId',
      trainList: 'trainList',
      hotelList: 'hotelList',
      vehicleList: 'vehicleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flightList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyFlightList },
      corpId: 'string',
      trainList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyTrainList },
      hotelList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyHotelList },
      vehicleList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyVehicleList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUnionOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUnionOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyHeaders extends $tea.Model {
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

export class QueryCityCarApplyRequest extends $tea.Model {
  corpId?: string;
  createdEndAt?: string;
  createdStartAt?: string;
  pageNumber?: number;
  pageSize?: number;
  thirdPartApplyId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createdEndAt: 'createdEndAt',
      createdStartAt: 'createdStartAt',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      thirdPartApplyId: 'thirdPartApplyId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createdEndAt: 'string',
      createdStartAt: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      thirdPartApplyId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBody extends $tea.Model {
  applyList?: QueryCityCarApplyResponseBodyApplyList[];
  total?: number;
  static names(): { [key: string]: string } {
    return {
      applyList: 'applyList',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyList: { 'type': 'array', 'itemType': QueryCityCarApplyResponseBodyApplyList },
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCityCarApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCityCarApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyFlightList extends $tea.Model {
  flightOrderId?: number;
  flightOrderStatus?: number;
  static names(): { [key: string]: string } {
    return {
      flightOrderId: 'flightOrderId',
      flightOrderStatus: 'flightOrderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flightOrderId: 'number',
      flightOrderStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyTrainList extends $tea.Model {
  trainOrderId?: number;
  trainOrderstatus?: number;
  static names(): { [key: string]: string } {
    return {
      trainOrderId: 'trainOrderId',
      trainOrderstatus: 'trainOrderstatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      trainOrderId: 'number',
      trainOrderstatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyHotelList extends $tea.Model {
  hotelOrderId?: number;
  hotelOrderStatus?: number;
  static names(): { [key: string]: string } {
    return {
      hotelOrderId: 'hotelOrderId',
      hotelOrderStatus: 'hotelOrderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hotelOrderId: 'number',
      hotelOrderStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyVehicleList extends $tea.Model {
  vehicleOrderId?: number;
  vehicleOrderStatus?: number;
  static names(): { [key: string]: string } {
    return {
      vehicleOrderId: 'vehicleOrderId',
      vehicleOrderStatus: 'vehicleOrderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      vehicleOrderId: 'number',
      vehicleOrderStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBodyApplyListApproverList extends $tea.Model {
  note?: string;
  operateTime?: string;
  order?: number;
  status?: number;
  statusDesc?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      note: 'note',
      operateTime: 'operateTime',
      order: 'order',
      status: 'status',
      statusDesc: 'statusDesc',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      note: 'string',
      operateTime: 'string',
      order: 'number',
      status: 'number',
      statusDesc: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBodyApplyListItineraryList extends $tea.Model {
  arrCity?: string;
  arrCityCode?: string;
  arrDate?: string;
  costCenterId?: number;
  costCenterName?: string;
  depCity?: string;
  depCityCode?: string;
  depDate?: string;
  invoiceId?: number;
  invoiceName?: string;
  itineraryId?: string;
  projectCode?: string;
  projectTitle?: string;
  trafficType?: number;
  static names(): { [key: string]: string } {
    return {
      arrCity: 'arrCity',
      arrCityCode: 'arrCityCode',
      arrDate: 'arrDate',
      costCenterId: 'costCenterId',
      costCenterName: 'costCenterName',
      depCity: 'depCity',
      depCityCode: 'depCityCode',
      depDate: 'depDate',
      invoiceId: 'invoiceId',
      invoiceName: 'invoiceName',
      itineraryId: 'itineraryId',
      projectCode: 'projectCode',
      projectTitle: 'projectTitle',
      trafficType: 'trafficType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrCity: 'string',
      arrCityCode: 'string',
      arrDate: 'string',
      costCenterId: 'number',
      costCenterName: 'string',
      depCity: 'string',
      depCityCode: 'string',
      depDate: 'string',
      invoiceId: 'number',
      invoiceName: 'string',
      itineraryId: 'string',
      projectCode: 'string',
      projectTitle: 'string',
      trafficType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBodyApplyList extends $tea.Model {
  approverList?: QueryCityCarApplyResponseBodyApplyListApproverList[];
  departId?: string;
  departName?: string;
  gmtCreate?: string;
  gmtModified?: string;
  itineraryList?: QueryCityCarApplyResponseBodyApplyListItineraryList[];
  status?: number;
  statusDesc?: string;
  thirdPartApplyId?: string;
  tripCause?: string;
  tripTitle?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      approverList: 'approverList',
      departId: 'departId',
      departName: 'departName',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      itineraryList: 'itineraryList',
      status: 'status',
      statusDesc: 'statusDesc',
      thirdPartApplyId: 'thirdPartApplyId',
      tripCause: 'tripCause',
      tripTitle: 'tripTitle',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approverList: { 'type': 'array', 'itemType': QueryCityCarApplyResponseBodyApplyListApproverList },
      departId: 'string',
      departName: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      itineraryList: { 'type': 'array', 'itemType': QueryCityCarApplyResponseBodyApplyListItineraryList },
      status: 'number',
      statusDesc: 'string',
      thirdPartApplyId: 'string',
      tripCause: 'string',
      tripTitle: 'string',
      userId: 'string',
      userName: 'string',
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


  async addCityCarApply(request: AddCityCarApplyRequest): Promise<AddCityCarApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCityCarApplyHeaders({ });
    return await this.addCityCarApplyWithOptions(request, headers, runtime);
  }

  async addCityCarApplyWithOptions(request: AddCityCarApplyRequest, headers: AddCityCarApplyHeaders, runtime: $Util.RuntimeOptions): Promise<AddCityCarApplyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cause)) {
      body["cause"] = request.cause;
    }

    if (!Util.isUnset(request.city)) {
      body["city"] = request.city;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.date)) {
      body["date"] = request.date;
    }

    if (!Util.isUnset(request.projectCode)) {
      body["projectCode"] = request.projectCode;
    }

    if (!Util.isUnset(request.projectName)) {
      body["projectName"] = request.projectName;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      body["thirdPartApplyId"] = request.thirdPartApplyId;
    }

    if (!Util.isUnset(request.thirdPartCostCenterId)) {
      body["thirdPartCostCenterId"] = request.thirdPartCostCenterId;
    }

    if (!Util.isUnset(request.thirdPartInvoiceId)) {
      body["thirdPartInvoiceId"] = request.thirdPartInvoiceId;
    }

    if (!Util.isUnset(request.timesTotal)) {
      body["timesTotal"] = request.timesTotal;
    }

    if (!Util.isUnset(request.timesType)) {
      body["timesType"] = request.timesType;
    }

    if (!Util.isUnset(request.timesUsed)) {
      body["timesUsed"] = request.timesUsed;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.finishedDate)) {
      body["finishedDate"] = request.finishedDate;
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
    return $tea.cast<AddCityCarApplyResponse>(await this.doROARequest("AddCityCarApply", "alitrip_1.0", "HTTP", "POST", "AK", `/v1.0/alitrip/cityCarApprovals`, "json", req, runtime), new AddCityCarApplyResponse({}));
  }

  async approveCityCarApply(request: ApproveCityCarApplyRequest): Promise<ApproveCityCarApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApproveCityCarApplyHeaders({ });
    return await this.approveCityCarApplyWithOptions(request, headers, runtime);
  }

  async approveCityCarApplyWithOptions(request: ApproveCityCarApplyRequest, headers: ApproveCityCarApplyHeaders, runtime: $Util.RuntimeOptions): Promise<ApproveCityCarApplyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.operateTime)) {
      body["operateTime"] = request.operateTime;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      body["thirdPartApplyId"] = request.thirdPartApplyId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<ApproveCityCarApplyResponse>(await this.doROARequest("ApproveCityCarApply", "alitrip_1.0", "HTTP", "PUT", "AK", `/v1.0/alitrip/cityCarApprovals`, "json", req, runtime), new ApproveCityCarApplyResponse({}));
  }

  async queryUnionOrder(request: QueryUnionOrderRequest): Promise<QueryUnionOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUnionOrderHeaders({ });
    return await this.queryUnionOrderWithOptions(request, headers, runtime);
  }

  async queryUnionOrderWithOptions(request: QueryUnionOrderRequest, headers: QueryUnionOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUnionOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      query["thirdPartApplyId"] = request.thirdPartApplyId;
    }

    if (!Util.isUnset(request.unionNo)) {
      query["unionNo"] = request.unionNo;
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
    return $tea.cast<QueryUnionOrderResponse>(await this.doROARequest("QueryUnionOrder", "alitrip_1.0", "HTTP", "GET", "AK", `/v1.0/alitrip/unionOrders`, "json", req, runtime), new QueryUnionOrderResponse({}));
  }

  async queryCityCarApply(request: QueryCityCarApplyRequest): Promise<QueryCityCarApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCityCarApplyHeaders({ });
    return await this.queryCityCarApplyWithOptions(request, headers, runtime);
  }

  async queryCityCarApplyWithOptions(request: QueryCityCarApplyRequest, headers: QueryCityCarApplyHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCityCarApplyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createdEndAt)) {
      query["createdEndAt"] = request.createdEndAt;
    }

    if (!Util.isUnset(request.createdStartAt)) {
      query["createdStartAt"] = request.createdStartAt;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      query["thirdPartApplyId"] = request.thirdPartApplyId;
    }

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
    return $tea.cast<QueryCityCarApplyResponse>(await this.doROARequest("QueryCityCarApply", "alitrip_1.0", "HTTP", "GET", "AK", `/v1.0/alitrip/cityCarApprovals`, "json", req, runtime), new QueryCityCarApplyResponse({}));
  }

}
