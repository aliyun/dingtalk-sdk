// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  body: SyncSecretKeyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  realAmount?: string;
  refundAmount?: string;
  relativeOrderNo?: string;
  source?: string;
  targetCorpId?: string;
  totalAmount?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
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
      realAmount: 'realAmount',
      refundAmount: 'refundAmount',
      relativeOrderNo: 'relativeOrderNo',
      source: 'source',
      targetCorpId: 'targetCorpId',
      totalAmount: 'totalAmount',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
      realAmount: 'string',
      refundAmount: 'string',
      relativeOrderNo: 'string',
      source: 'string',
      targetCorpId: 'string',
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
  body: SyncTripOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SyncTripOrderResponseBody,
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

export class SyncTripOrderRequestOrderDetails extends $tea.Model {
  arrivalTime?: string;
  carColor?: string;
  carModel?: string;
  carNumber?: string;
  cateringType?: string;
  checkInTime?: string;
  checkOutTime?: string;
  departTime?: string;
  destinationCityCode?: string;
  destinationStation?: string;
  hotelAddress?: string;
  hotelLocation?: SyncTripOrderRequestOrderDetailsHotelLocation;
  hotelName?: string;
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
      destinationCityCode: 'destinationCityCode',
      destinationStation: 'destinationStation',
      hotelAddress: 'hotelAddress',
      hotelLocation: 'hotelLocation',
      hotelName: 'hotelName',
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
      destinationCityCode: 'string',
      destinationStation: 'string',
      hotelAddress: 'string',
      hotelLocation: SyncTripOrderRequestOrderDetailsHotelLocation,
      hotelName: 'string',
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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async syncSecretKey(request: SyncSecretKeyRequest): Promise<SyncSecretKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncSecretKeyHeaders({ });
    return await this.syncSecretKeyWithOptions(request, headers, runtime);
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
    return $tea.cast<SyncSecretKeyResponse>(await this.doROARequest("SyncSecretKey", "trip_1.0", "HTTP", "POST", "AK", `/v1.0/trip/secretKeys/sync`, "json", req, runtime), new SyncSecretKeyResponse({}));
  }

  async syncTripOrder(request: SyncTripOrderRequest): Promise<SyncTripOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTripOrderHeaders({ });
    return await this.syncTripOrderWithOptions(request, headers, runtime);
  }

  async syncTripOrderWithOptions(request: SyncTripOrderRequest, headers: SyncTripOrderHeaders, runtime: $Util.RuntimeOptions): Promise<SyncTripOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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

    if (!Util.isUnset($tea.toMap(request.event))) {
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

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<SyncTripOrderResponse>(await this.doROARequest("SyncTripOrder", "trip_1.0", "HTTP", "POST", "AK", `/v1.0/trip/tripOrders/sync`, "json", req, runtime), new SyncTripOrderResponse({}));
  }

}
