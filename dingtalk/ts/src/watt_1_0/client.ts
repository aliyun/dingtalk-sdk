// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CheckInCrowdsByMobileRequest extends $tea.Model {
  /**
   * @example
   * 12520
   * 
   * **if can be null:**
   * true
   */
  crowdIds?: Buffer;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * N5u3hS6KJeoUdopXW4GzFg==
   */
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      crowdIds: 'crowdIds',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      crowdIds: 'Buffer',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInCrowdsByMobileResponseBody extends $tea.Model {
  data?: boolean;
  success?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'boolean',
      success: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInCrowdsByMobileResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckInCrowdsByMobileResponseBody;
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
      body: CheckInCrowdsByMobileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointHeaders extends $tea.Model {
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

export class ConsumePointRequest extends $tea.Model {
  body?: ConsumePointRequestBody;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: ConsumePointRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointShrinkRequest extends $tea.Model {
  bodyShrink?: string;
  static names(): { [key: string]: string } {
    return {
      bodyShrink: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bodyShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointResponseBody extends $tea.Model {
  result?: ConsumePointResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ConsumePointResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConsumePointResponseBody;
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
      body: ConsumePointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeliveryPlanHeaders extends $tea.Model {
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

export class CreateDeliveryPlanRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  /**
   * @example
   * 1028
   */
  resId?: string;
  startTime?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      resId: 'resId',
      startTime: 'startTime',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      resId: 'string',
      startTime: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeliveryPlanResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeliveryPlanResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateDeliveryPlanResponseBody;
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
      body: CreateDeliveryPlanResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoHeaders extends $tea.Model {
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

export class GetPointInfoRequest extends $tea.Model {
  pointPoolCode?: string;
  static names(): { [key: string]: string } {
    return {
      pointPoolCode: 'pointPoolCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointPoolCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoResponseBody extends $tea.Model {
  result?: GetPointInfoResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetPointInfoResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPointInfoResponseBody;
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
      body: GetPointInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertPointHeaders extends $tea.Model {
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

export class RevertPointRequest extends $tea.Model {
  body?: RevertPointRequestBody;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: RevertPointRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertPointShrinkRequest extends $tea.Model {
  bodyShrink?: string;
  static names(): { [key: string]: string } {
    return {
      bodyShrink: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bodyShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertPointResponseBody extends $tea.Model {
  result?: RevertPointResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: RevertPointResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertPointResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RevertPointResponseBody;
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
      body: RevertPointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendBannerHeaders extends $tea.Model {
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

export class SendBannerRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendBannerResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendBannerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendBannerResponseBody;
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
      body: SendBannerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPopupHeaders extends $tea.Model {
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

export class SendPopupRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPopupResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPopupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendPopupResponseBody;
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
      body: SendPopupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSearchShadeHeaders extends $tea.Model {
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

export class SendSearchShadeRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSearchShadeResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSearchShadeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendSearchShadeResponseBody;
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
      body: SendSearchShadeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointRequestBodyConsumeDetailBenefit extends $tea.Model {
  benefitId?: string;
  name?: string;
  supplierName?: string;
  useUrl?: string;
  static names(): { [key: string]: string } {
    return {
      benefitId: 'benefitId',
      name: 'name',
      supplierName: 'supplierName',
      useUrl: 'useUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitId: 'string',
      name: 'string',
      supplierName: 'string',
      useUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointRequestBodyConsumeDetail extends $tea.Model {
  benefit?: ConsumePointRequestBodyConsumeDetailBenefit;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      benefit: 'benefit',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefit: ConsumePointRequestBodyConsumeDetailBenefit,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointRequestBody extends $tea.Model {
  consumeDetail?: ConsumePointRequestBodyConsumeDetail;
  pointPoolCode?: string;
  points?: number;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      consumeDetail: 'consumeDetail',
      pointPoolCode: 'pointPoolCode',
      points: 'points',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      consumeDetail: ConsumePointRequestBodyConsumeDetail,
      pointPoolCode: 'string',
      points: 'number',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointResponseBodyResult extends $tea.Model {
  consumedPoints?: number;
  static names(): { [key: string]: string } {
    return {
      consumedPoints: 'consumedPoints',
    };
  }

  static types(): { [key: string]: any } {
    return {
      consumedPoints: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoResponseBodyResult extends $tea.Model {
  userPoints?: number;
  static names(): { [key: string]: string } {
    return {
      userPoints: 'userPoints',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userPoints: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertPointRequestBody extends $tea.Model {
  pointPoolCode?: string;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      pointPoolCode: 'pointPoolCode',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointPoolCode: 'string',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertPointResponseBodyResult extends $tea.Model {
  revertedPoints?: number;
  static names(): { [key: string]: string } {
    return {
      revertedPoints: 'revertedPoints',
    };
  }

  static types(): { [key: string]: any } {
    return {
      revertedPoints: 'number',
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
   * 根据加密后的用户手机号检查该用户是否在某人群中
   * 
   * @param request - CheckInCrowdsByMobileRequest
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckInCrowdsByMobileResponse
   */
  async checkInCrowdsByMobileWithOptions(request: CheckInCrowdsByMobileRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<CheckInCrowdsByMobileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.crowdIds)) {
      query["crowdIds"] = request.crowdIds;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "CheckInCrowdsByMobile",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/crowdIdentifications/query`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckInCrowdsByMobileResponse>(await this.execute(params, req, runtime), new CheckInCrowdsByMobileResponse({}));
  }

  /**
   * 根据加密后的用户手机号检查该用户是否在某人群中
   * 
   * @param request - CheckInCrowdsByMobileRequest
   * @returns CheckInCrowdsByMobileResponse
   */
  async checkInCrowdsByMobile(request: CheckInCrowdsByMobileRequest): Promise<CheckInCrowdsByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.checkInCrowdsByMobileWithOptions(request, headers, runtime);
  }

  /**
   * 消耗用户积分
   * 
   * @param tmpReq - ConsumePointRequest
   * @param headers - ConsumePointHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConsumePointResponse
   */
  async consumePointWithOptions(tmpReq: ConsumePointRequest, headers: ConsumePointHeaders, runtime: $Util.RuntimeOptions): Promise<ConsumePointResponse> {
    Util.validateModel(tmpReq);
    let request = new ConsumePointShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.body)) {
      request.bodyShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bodyShrink)) {
      query["body"] = request.bodyShrink;
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
      action: "ConsumePoint",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/points/consume`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConsumePointResponse>(await this.execute(params, req, runtime), new ConsumePointResponse({}));
  }

  /**
   * 消耗用户积分
   * 
   * @param request - ConsumePointRequest
   * @returns ConsumePointResponse
   */
  async consumePoint(request: ConsumePointRequest): Promise<ConsumePointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsumePointHeaders({ });
    return await this.consumePointWithOptions(request, headers, runtime);
  }

  /**
   * 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
   * 
   * @param request - CreateDeliveryPlanRequest
   * @param headers - CreateDeliveryPlanHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDeliveryPlanResponse
   */
  async createDeliveryPlanWithOptions(request: CreateDeliveryPlanRequest, headers: CreateDeliveryPlanHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeliveryPlanResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.resId)) {
      body["resId"] = request.resId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
      action: "CreateDeliveryPlan",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/deliveryPlans/publish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDeliveryPlanResponse>(await this.execute(params, req, runtime), new CreateDeliveryPlanResponse({}));
  }

  /**
   * 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
   * 
   * @param request - CreateDeliveryPlanRequest
   * @returns CreateDeliveryPlanResponse
   */
  async createDeliveryPlan(request: CreateDeliveryPlanRequest): Promise<CreateDeliveryPlanResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeliveryPlanHeaders({ });
    return await this.createDeliveryPlanWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户积分
   * 
   * @param request - GetPointInfoRequest
   * @param headers - GetPointInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPointInfoResponse
   */
  async getPointInfoWithOptions(request: GetPointInfoRequest, headers: GetPointInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPointInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pointPoolCode)) {
      query["pointPoolCode"] = request.pointPoolCode;
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
      action: "GetPointInfo",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/points`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPointInfoResponse>(await this.execute(params, req, runtime), new GetPointInfoResponse({}));
  }

  /**
   * 查询用户积分
   * 
   * @param request - GetPointInfoRequest
   * @returns GetPointInfoResponse
   */
  async getPointInfo(request: GetPointInfoRequest): Promise<GetPointInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPointInfoHeaders({ });
    return await this.getPointInfoWithOptions(request, headers, runtime);
  }

  /**
   * 撤销用户单笔积分消耗
   * 
   * @param tmpReq - RevertPointRequest
   * @param headers - RevertPointHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RevertPointResponse
   */
  async revertPointWithOptions(tmpReq: RevertPointRequest, headers: RevertPointHeaders, runtime: $Util.RuntimeOptions): Promise<RevertPointResponse> {
    Util.validateModel(tmpReq);
    let request = new RevertPointShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.body)) {
      request.bodyShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bodyShrink)) {
      query["body"] = request.bodyShrink;
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
      action: "RevertPoint",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/points/revert`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RevertPointResponse>(await this.execute(params, req, runtime), new RevertPointResponse({}));
  }

  /**
   * 撤销用户单笔积分消耗
   * 
   * @param request - RevertPointRequest
   * @returns RevertPointResponse
   */
  async revertPoint(request: RevertPointRequest): Promise<RevertPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RevertPointHeaders({ });
    return await this.revertPointWithOptions(request, headers, runtime);
  }

  /**
   * 发送钉钉统一引导Banner
   * 
   * @param request - SendBannerRequest
   * @param headers - SendBannerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendBannerResponse
   */
  async sendBannerWithOptions(request: SendBannerRequest, headers: SendBannerHeaders, runtime: $Util.RuntimeOptions): Promise<SendBannerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "SendBanner",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/banners/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendBannerResponse>(await this.execute(params, req, runtime), new SendBannerResponse({}));
  }

  /**
   * 发送钉钉统一引导Banner
   * 
   * @param request - SendBannerRequest
   * @returns SendBannerResponse
   */
  async sendBanner(request: SendBannerRequest): Promise<SendBannerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendBannerHeaders({ });
    return await this.sendBannerWithOptions(request, headers, runtime);
  }

  /**
   * 发送钉钉首页弹窗
   * 
   * @param request - SendPopupRequest
   * @param headers - SendPopupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendPopupResponse
   */
  async sendPopupWithOptions(request: SendPopupRequest, headers: SendPopupHeaders, runtime: $Util.RuntimeOptions): Promise<SendPopupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "SendPopup",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/popups/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendPopupResponse>(await this.execute(params, req, runtime), new SendPopupResponse({}));
  }

  /**
   * 发送钉钉首页弹窗
   * 
   * @param request - SendPopupRequest
   * @returns SendPopupResponse
   */
  async sendPopup(request: SendPopupRequest): Promise<SendPopupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendPopupHeaders({ });
    return await this.sendPopupWithOptions(request, headers, runtime);
  }

  /**
   * 发送钉钉搜索底纹
   * 
   * @param request - SendSearchShadeRequest
   * @param headers - SendSearchShadeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendSearchShadeResponse
   */
  async sendSearchShadeWithOptions(request: SendSearchShadeRequest, headers: SendSearchShadeHeaders, runtime: $Util.RuntimeOptions): Promise<SendSearchShadeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "SendSearchShade",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/searchShades/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendSearchShadeResponse>(await this.execute(params, req, runtime), new SendSearchShadeResponse({}));
  }

  /**
   * 发送钉钉搜索底纹
   * 
   * @param request - SendSearchShadeRequest
   * @returns SendSearchShadeResponse
   */
  async sendSearchShade(request: SendSearchShadeRequest): Promise<SendSearchShadeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendSearchShadeHeaders({ });
    return await this.sendSearchShadeWithOptions(request, headers, runtime);
  }

}
