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

export class GetTravelProcessDetailHeaders extends $tea.Model {
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

export class GetTravelProcessDetailRequest extends $tea.Model {
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBody extends $tea.Model {
  result?: GetTravelProcessDetailResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetTravelProcessDetailResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTravelProcessDetailResponseBody;
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
      body: GetTravelProcessDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoHeaders extends $tea.Model {
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

export class SyncBusinessSignInfoRequest extends $tea.Model {
  bizTypeList?: string[];
  gmtOrgPay?: string;
  gmtSign?: string;
  orgPayStatus?: string;
  signStatus?: string;
  targetCorpId?: string;
  tmcProductDetailList?: SyncBusinessSignInfoRequestTmcProductDetailList[];
  tmcProductList?: SyncBusinessSignInfoRequestTmcProductList[];
  static names(): { [key: string]: string } {
    return {
      bizTypeList: 'bizTypeList',
      gmtOrgPay: 'gmtOrgPay',
      gmtSign: 'gmtSign',
      orgPayStatus: 'orgPayStatus',
      signStatus: 'signStatus',
      targetCorpId: 'targetCorpId',
      tmcProductDetailList: 'tmcProductDetailList',
      tmcProductList: 'tmcProductList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTypeList: { 'type': 'array', 'itemType': 'string' },
      gmtOrgPay: 'string',
      gmtSign: 'string',
      orgPayStatus: 'string',
      signStatus: 'string',
      targetCorpId: 'string',
      tmcProductDetailList: { 'type': 'array', 'itemType': SyncBusinessSignInfoRequestTmcProductDetailList },
      tmcProductList: { 'type': 'array', 'itemType': SyncBusinessSignInfoRequestTmcProductList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoResponseBody extends $tea.Model {
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SyncBusinessSignInfoResponseBody;
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
      body: SyncBusinessSignInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyHeaders extends $tea.Model {
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

export class SyncSecretKeyRequest extends $tea.Model {
  actionType?: string;
  secretString?: string;
  targetCorpId?: string;
  tripAppKey?: string;
  tripAppSecurity?: string;
  tripCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      secretString: 'secretString',
      targetCorpId: 'targetCorpId',
      tripAppKey: 'tripAppKey',
      tripAppSecurity: 'tripAppSecurity',
      tripCorpId: 'tripCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      secretString: 'string',
      targetCorpId: 'string',
      tripAppKey: 'string',
      tripAppSecurity: 'string',
      tripCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyResponseBody extends $tea.Model {
  result?: SyncSecretKeyResponseBodyResult;
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SyncSecretKeyResponseBodyResult,
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SyncSecretKeyResponseBody;
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
      body: SyncSecretKeyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderHeaders extends $tea.Model {
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

export class SyncTripOrderRequest extends $tea.Model {
  channelType?: string;
  currency?: string;
  dingUserId?: string;
  discountAmount?: string;
  endorseFlag?: boolean;
  event?: SyncTripOrderRequestEvent;
  gmtOrder?: string;
  gmtPay?: string;
  gmtRefund?: string;
  invoiceApplyUrl?: string;
  journeyBizNo?: string;
  orderDetails?: SyncTripOrderRequestOrderDetails[];
  orderNo?: string;
  orderUrl?: string;
  processId?: string;
  realAmount?: string;
  refundAmount?: string;
  relativeOrderNo?: string;
  source?: string;
  supplyLogo?: string;
  supplyName?: string;
  targetCorpId?: string;
  tmcCorpId?: string;
  totalAmount?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      channelType: 'channelType',
      currency: 'currency',
      dingUserId: 'dingUserId',
      discountAmount: 'discountAmount',
      endorseFlag: 'endorseFlag',
      event: 'event',
      gmtOrder: 'gmtOrder',
      gmtPay: 'gmtPay',
      gmtRefund: 'gmtRefund',
      invoiceApplyUrl: 'invoiceApplyUrl',
      journeyBizNo: 'journeyBizNo',
      orderDetails: 'orderDetails',
      orderNo: 'orderNo',
      orderUrl: 'orderUrl',
      processId: 'processId',
      realAmount: 'realAmount',
      refundAmount: 'refundAmount',
      relativeOrderNo: 'relativeOrderNo',
      source: 'source',
      supplyLogo: 'supplyLogo',
      supplyName: 'supplyName',
      targetCorpId: 'targetCorpId',
      tmcCorpId: 'tmcCorpId',
      totalAmount: 'totalAmount',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelType: 'string',
      currency: 'string',
      dingUserId: 'string',
      discountAmount: 'string',
      endorseFlag: 'boolean',
      event: SyncTripOrderRequestEvent,
      gmtOrder: 'string',
      gmtPay: 'string',
      gmtRefund: 'string',
      invoiceApplyUrl: 'string',
      journeyBizNo: 'string',
      orderDetails: { 'type': 'array', 'itemType': SyncTripOrderRequestOrderDetails },
      orderNo: 'string',
      orderUrl: 'string',
      processId: 'string',
      realAmount: 'string',
      refundAmount: 'string',
      relativeOrderNo: 'string',
      source: 'string',
      supplyLogo: 'string',
      supplyName: 'string',
      targetCorpId: 'string',
      tmcCorpId: 'string',
      totalAmount: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderResponseBody extends $tea.Model {
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SyncTripOrderResponseBody;
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
      body: SyncTripOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultJourneysArrival extends $tea.Model {
  code?: string;
  name?: string;
  nationalCityCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      nationalCityCode: 'nationalCityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      nationalCityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultJourneysDeparture extends $tea.Model {
  code?: string;
  name?: string;
  nationalCityCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      nationalCityCode: 'nationalCityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      nationalCityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultJourneys extends $tea.Model {
  arrival?: GetTravelProcessDetailResponseBodyResultJourneysArrival;
  departure?: GetTravelProcessDetailResponseBodyResultJourneysDeparture;
  endTime?: string;
  journeyBizNo?: string;
  startTime?: string;
  travelType?: string;
  tripWay?: string;
  static names(): { [key: string]: string } {
    return {
      arrival: 'arrival',
      departure: 'departure',
      endTime: 'endTime',
      journeyBizNo: 'journeyBizNo',
      startTime: 'startTime',
      travelType: 'travelType',
      tripWay: 'tripWay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrival: GetTravelProcessDetailResponseBodyResultJourneysArrival,
      departure: GetTravelProcessDetailResponseBodyResultJourneysDeparture,
      endTime: 'string',
      journeyBizNo: 'string',
      startTime: 'string',
      travelType: 'string',
      tripWay: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResult extends $tea.Model {
  businessId?: string;
  corpId?: string;
  costCenter?: string;
  itineraryProject?: string;
  journeys?: GetTravelProcessDetailResponseBodyResultJourneys[];
  mainProcessInstanceId?: string;
  memo?: string;
  originatorId?: string;
  processInstanceId?: string;
  processResult?: string;
  processStatus?: string;
  remark?: string;
  travelCategory?: string;
  travelers?: string[];
  static names(): { [key: string]: string } {
    return {
      businessId: 'businessId',
      corpId: 'corpId',
      costCenter: 'costCenter',
      itineraryProject: 'itineraryProject',
      journeys: 'journeys',
      mainProcessInstanceId: 'mainProcessInstanceId',
      memo: 'memo',
      originatorId: 'originatorId',
      processInstanceId: 'processInstanceId',
      processResult: 'processResult',
      processStatus: 'processStatus',
      remark: 'remark',
      travelCategory: 'travelCategory',
      travelers: 'travelers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessId: 'string',
      corpId: 'string',
      costCenter: 'string',
      itineraryProject: 'string',
      journeys: { 'type': 'array', 'itemType': GetTravelProcessDetailResponseBodyResultJourneys },
      mainProcessInstanceId: 'string',
      memo: 'string',
      originatorId: 'string',
      processInstanceId: 'string',
      processResult: 'string',
      processStatus: 'string',
      remark: 'string',
      travelCategory: 'string',
      travelers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequestTmcProductDetailList extends $tea.Model {
  gmtOrgPay?: string;
  payType?: string;
  product?: string;
  static names(): { [key: string]: string } {
    return {
      gmtOrgPay: 'gmtOrgPay',
      payType: 'payType',
      product: 'product',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtOrgPay: 'string',
      payType: 'string',
      product: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequestTmcProductListProductDetailList extends $tea.Model {
  categoryType?: string;
  gmtOrgPay?: string;
  openStatus?: boolean;
  payType?: string;
  product?: string;
  static names(): { [key: string]: string } {
    return {
      categoryType: 'categoryType',
      gmtOrgPay: 'gmtOrgPay',
      openStatus: 'openStatus',
      payType: 'payType',
      product: 'product',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryType: 'string',
      gmtOrgPay: 'string',
      openStatus: 'boolean',
      payType: 'string',
      product: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequestTmcProductList extends $tea.Model {
  productDetailList?: SyncBusinessSignInfoRequestTmcProductListProductDetailList[];
  tmcCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      productDetailList: 'productDetailList',
      tmcCorpId: 'tmcCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      productDetailList: { 'type': 'array', 'itemType': SyncBusinessSignInfoRequestTmcProductListProductDetailList },
      tmcCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyResponseBodyResult extends $tea.Model {
  secretString?: string;
  targetCorpId?: string;
  tripAppKey?: string;
  tripAppSecurity?: string;
  tripCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      secretString: 'secretString',
      targetCorpId: 'targetCorpId',
      tripAppKey: 'tripAppKey',
      tripAppSecurity: 'tripAppSecurity',
      tripCorpId: 'tripCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      secretString: 'string',
      targetCorpId: 'string',
      tripAppKey: 'string',
      tripAppSecurity: 'string',
      tripCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestEvent extends $tea.Model {
  action?: string;
  gmtAction?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      gmtAction: 'gmtAction',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      gmtAction: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestOrderDetailsHotelLocation extends $tea.Model {
  lat?: string;
  lon?: string;
  source?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      lat: 'lat',
      lon: 'lon',
      source: 'source',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lat: 'string',
      lon: 'string',
      source: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestOrderDetailsOpenConsumerInfo extends $tea.Model {
  corpId?: string;
  name?: string;
  staffFlag?: boolean;
  status?: string;
  ticketAmount?: string;
  ticketNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      name: 'name',
      staffFlag: 'staffFlag',
      status: 'status',
      ticketAmount: 'ticketAmount',
      ticketNo: 'ticketNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      name: 'string',
      staffFlag: 'boolean',
      status: 'string',
      ticketAmount: 'string',
      ticketNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestOrderDetails extends $tea.Model {
  arrivalTime?: string;
  carColor?: string;
  carModel?: string;
  carNumber?: string;
  cateringType?: string;
  checkInTime?: string;
  checkOutTime?: string;
  departTime?: string;
  destinationCity?: string;
  destinationCityCode?: string;
  destinationStation?: string;
  detailAmount?: string;
  hotelAddress?: string;
  hotelCity?: string;
  hotelLocation?: SyncTripOrderRequestOrderDetailsHotelLocation;
  hotelName?: string;
  openConsumerInfo?: SyncTripOrderRequestOrderDetailsOpenConsumerInfo[];
  originCity?: string;
  originCityCode?: string;
  originStation?: string;
  roomCount?: number;
  seatInfo?: string;
  serviceType?: string;
  subSupplyLogo?: string;
  subSupplyName?: string;
  taxiType?: string;
  telephone?: string;
  transportNumber?: string;
  typeDescription?: string;
  static names(): { [key: string]: string } {
    return {
      arrivalTime: 'arrivalTime',
      carColor: 'carColor',
      carModel: 'carModel',
      carNumber: 'carNumber',
      cateringType: 'cateringType',
      checkInTime: 'checkInTime',
      checkOutTime: 'checkOutTime',
      departTime: 'departTime',
      destinationCity: 'destinationCity',
      destinationCityCode: 'destinationCityCode',
      destinationStation: 'destinationStation',
      detailAmount: 'detailAmount',
      hotelAddress: 'hotelAddress',
      hotelCity: 'hotelCity',
      hotelLocation: 'hotelLocation',
      hotelName: 'hotelName',
      openConsumerInfo: 'openConsumerInfo',
      originCity: 'originCity',
      originCityCode: 'originCityCode',
      originStation: 'originStation',
      roomCount: 'roomCount',
      seatInfo: 'seatInfo',
      serviceType: 'serviceType',
      subSupplyLogo: 'subSupplyLogo',
      subSupplyName: 'subSupplyName',
      taxiType: 'taxiType',
      telephone: 'telephone',
      transportNumber: 'transportNumber',
      typeDescription: 'typeDescription',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrivalTime: 'string',
      carColor: 'string',
      carModel: 'string',
      carNumber: 'string',
      cateringType: 'string',
      checkInTime: 'string',
      checkOutTime: 'string',
      departTime: 'string',
      destinationCity: 'string',
      destinationCityCode: 'string',
      destinationStation: 'string',
      detailAmount: 'string',
      hotelAddress: 'string',
      hotelCity: 'string',
      hotelLocation: SyncTripOrderRequestOrderDetailsHotelLocation,
      hotelName: 'string',
      openConsumerInfo: { 'type': 'array', 'itemType': SyncTripOrderRequestOrderDetailsOpenConsumerInfo },
      originCity: 'string',
      originCityCode: 'string',
      originStation: 'string',
      roomCount: 'number',
      seatInfo: 'string',
      serviceType: 'string',
      subSupplyLogo: 'string',
      subSupplyName: 'string',
      taxiType: 'string',
      telephone: 'string',
      transportNumber: 'string',
      typeDescription: 'string',
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


  async getTravelProcessDetailWithOptions(request: GetTravelProcessDetailRequest, headers: GetTravelProcessDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetTravelProcessDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    let params = new $OpenApi.Params({
      action: "GetTravelProcessDetail",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTravelProcessDetailResponse>(await this.execute(params, req, runtime), new GetTravelProcessDetailResponse({}));
  }

  async getTravelProcessDetail(request: GetTravelProcessDetailRequest): Promise<GetTravelProcessDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTravelProcessDetailHeaders({ });
    return await this.getTravelProcessDetailWithOptions(request, headers, runtime);
  }

  async syncBusinessSignInfoWithOptions(request: SyncBusinessSignInfoRequest, headers: SyncBusinessSignInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SyncBusinessSignInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizTypeList)) {
      body["bizTypeList"] = request.bizTypeList;
    }

    if (!Util.isUnset(request.gmtOrgPay)) {
      body["gmtOrgPay"] = request.gmtOrgPay;
    }

    if (!Util.isUnset(request.gmtSign)) {
      body["gmtSign"] = request.gmtSign;
    }

    if (!Util.isUnset(request.orgPayStatus)) {
      body["orgPayStatus"] = request.orgPayStatus;
    }

    if (!Util.isUnset(request.signStatus)) {
      body["signStatus"] = request.signStatus;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tmcProductDetailList)) {
      body["tmcProductDetailList"] = request.tmcProductDetailList;
    }

    if (!Util.isUnset(request.tmcProductList)) {
      body["tmcProductList"] = request.tmcProductList;
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
      action: "SyncBusinessSignInfo",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/businessSignInfos/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncBusinessSignInfoResponse>(await this.execute(params, req, runtime), new SyncBusinessSignInfoResponse({}));
  }

  async syncBusinessSignInfo(request: SyncBusinessSignInfoRequest): Promise<SyncBusinessSignInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncBusinessSignInfoHeaders({ });
    return await this.syncBusinessSignInfoWithOptions(request, headers, runtime);
  }

  async syncSecretKeyWithOptions(request: SyncSecretKeyRequest, headers: SyncSecretKeyHeaders, runtime: $Util.RuntimeOptions): Promise<SyncSecretKeyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionType)) {
      body["actionType"] = request.actionType;
    }

    if (!Util.isUnset(request.secretString)) {
      body["secretString"] = request.secretString;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tripAppKey)) {
      body["tripAppKey"] = request.tripAppKey;
    }

    if (!Util.isUnset(request.tripAppSecurity)) {
      body["tripAppSecurity"] = request.tripAppSecurity;
    }

    if (!Util.isUnset(request.tripCorpId)) {
      body["tripCorpId"] = request.tripCorpId;
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
      action: "SyncSecretKey",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/secretKeys/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncSecretKeyResponse>(await this.execute(params, req, runtime), new SyncSecretKeyResponse({}));
  }

  async syncSecretKey(request: SyncSecretKeyRequest): Promise<SyncSecretKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncSecretKeyHeaders({ });
    return await this.syncSecretKeyWithOptions(request, headers, runtime);
  }

  async syncTripOrderWithOptions(request: SyncTripOrderRequest, headers: SyncTripOrderHeaders, runtime: $Util.RuntimeOptions): Promise<SyncTripOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelType)) {
      body["channelType"] = request.channelType;
    }

    if (!Util.isUnset(request.currency)) {
      body["currency"] = request.currency;
    }

    if (!Util.isUnset(request.dingUserId)) {
      body["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.discountAmount)) {
      body["discountAmount"] = request.discountAmount;
    }

    if (!Util.isUnset(request.endorseFlag)) {
      body["endorseFlag"] = request.endorseFlag;
    }

    if (!Util.isUnset(request.event)) {
      body["event"] = request.event;
    }

    if (!Util.isUnset(request.gmtOrder)) {
      body["gmtOrder"] = request.gmtOrder;
    }

    if (!Util.isUnset(request.gmtPay)) {
      body["gmtPay"] = request.gmtPay;
    }

    if (!Util.isUnset(request.gmtRefund)) {
      body["gmtRefund"] = request.gmtRefund;
    }

    if (!Util.isUnset(request.invoiceApplyUrl)) {
      body["invoiceApplyUrl"] = request.invoiceApplyUrl;
    }

    if (!Util.isUnset(request.journeyBizNo)) {
      body["journeyBizNo"] = request.journeyBizNo;
    }

    if (!Util.isUnset(request.orderDetails)) {
      body["orderDetails"] = request.orderDetails;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.orderUrl)) {
      body["orderUrl"] = request.orderUrl;
    }

    if (!Util.isUnset(request.processId)) {
      body["processId"] = request.processId;
    }

    if (!Util.isUnset(request.realAmount)) {
      body["realAmount"] = request.realAmount;
    }

    if (!Util.isUnset(request.refundAmount)) {
      body["refundAmount"] = request.refundAmount;
    }

    if (!Util.isUnset(request.relativeOrderNo)) {
      body["relativeOrderNo"] = request.relativeOrderNo;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.supplyLogo)) {
      body["supplyLogo"] = request.supplyLogo;
    }

    if (!Util.isUnset(request.supplyName)) {
      body["supplyName"] = request.supplyName;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tmcCorpId)) {
      body["tmcCorpId"] = request.tmcCorpId;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
      action: "SyncTripOrder",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/tripOrders/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncTripOrderResponse>(await this.execute(params, req, runtime), new SyncTripOrderResponse({}));
  }

  async syncTripOrder(request: SyncTripOrderRequest): Promise<SyncTripOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTripOrderHeaders({ });
    return await this.syncTripOrderWithOptions(request, headers, runtime);
  }

}
