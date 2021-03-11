// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateApproveHeaders extends $tea.Model {
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

export class CreateApproveRequest extends $tea.Model {
  userid?: string;
  tagName?: string;
  subType?: string;
  punchParam?: CreateApproveRequestPunchParam;
  approveId?: string;
  opUserid?: string;
  static names(): { [key: string]: string } {
    return {
      userid: 'userid',
      tagName: 'tagName',
      subType: 'subType',
      punchParam: 'punchParam',
      approveId: 'approveId',
      opUserid: 'opUserid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userid: 'string',
      tagName: 'string',
      subType: 'string',
      punchParam: CreateApproveRequestPunchParam,
      approveId: 'string',
      opUserid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveResponseBody extends $tea.Model {
  dingtalkApproveId?: string;
  static names(): { [key: string]: string } {
    return {
      dingtalkApproveId: 'dingtalkApproveId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingtalkApproveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateApproveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateApproveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysHeaders extends $tea.Model {
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

export class GetUserHolidaysRequest extends $tea.Model {
  topHolidayQueryParam?: GetUserHolidaysRequestTopHolidayQueryParam;
  static names(): { [key: string]: string } {
    return {
      topHolidayQueryParam: 'topHolidayQueryParam',
    };
  }

  static types(): { [key: string]: any } {
    return {
      topHolidayQueryParam: GetUserHolidaysRequestTopHolidayQueryParam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysShrinkRequest extends $tea.Model {
  topHolidayQueryParamShrink?: string;
  static names(): { [key: string]: string } {
    return {
      topHolidayQueryParamShrink: 'topHolidayQueryParam',
    };
  }

  static types(): { [key: string]: any } {
    return {
      topHolidayQueryParamShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBody extends $tea.Model {
  result?: GetUserHolidaysResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetUserHolidaysResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserHolidaysResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserHolidaysResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveRequestPunchParam extends $tea.Model {
  punchTime?: number;
  positionId?: string;
  positionType?: string;
  positionName?: string;
  static names(): { [key: string]: string } {
    return {
      punchTime: 'punchTime',
      positionId: 'positionId',
      positionType: 'positionType',
      positionName: 'positionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      punchTime: 'number',
      positionId: 'string',
      positionType: 'string',
      positionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysRequestTopHolidayQueryParam extends $tea.Model {
  userIds?: string[];
  workDateFrom?: number;
  workDateTo?: number;
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
      workDateFrom: 'workDateFrom',
      workDateTo: 'workDateTo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
      workDateFrom: 'number',
      workDateTo: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBodyResultHolidays extends $tea.Model {
  workDate?: number;
  holidayName?: string;
  holidayType?: string;
  realWorkDate?: number;
  static names(): { [key: string]: string } {
    return {
      workDate: 'workDate',
      holidayName: 'holidayName',
      holidayType: 'holidayType',
      realWorkDate: 'realWorkDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workDate: 'number',
      holidayName: 'string',
      holidayType: 'string',
      realWorkDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBodyResult extends $tea.Model {
  userId?: string;
  holidays?: GetUserHolidaysResponseBodyResultHolidays[];
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      holidays: 'holidays',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      holidays: { 'type': 'array', 'itemType': GetUserHolidaysResponseBodyResultHolidays },
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


  async createApprove(request: CreateApproveRequest): Promise<CreateApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateApproveHeaders({ });
    return await this.createApproveWithOptions(request, headers, runtime);
  }

  async createApproveWithOptions(request: CreateApproveRequest, headers: CreateApproveHeaders, runtime: $Util.RuntimeOptions): Promise<CreateApproveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
    }

    if (!Util.isUnset(request.tagName)) {
      body["tagName"] = request.tagName;
    }

    if (!Util.isUnset(request.subType)) {
      body["subType"] = request.subType;
    }

    if (!Util.isUnset($tea.toMap(request.punchParam))) {
      body["punchParam"] = request.punchParam;
    }

    if (!Util.isUnset(request.approveId)) {
      body["approveId"] = request.approveId;
    }

    if (!Util.isUnset(request.opUserid)) {
      body["opUserid"] = request.opUserid;
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
    return $tea.cast<CreateApproveResponse>(await this.doROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/approves`, "json", req, runtime), new CreateApproveResponse({}));
  }

  async getUserHolidays(request: GetUserHolidaysRequest): Promise<GetUserHolidaysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHolidaysHeaders({ });
    return await this.getUserHolidaysWithOptions(request, headers, runtime);
  }

  async getUserHolidaysWithOptions(tmpReq: GetUserHolidaysRequest, headers: GetUserHolidaysHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserHolidaysResponse> {
    Util.validateModel(tmpReq);
    let request = new GetUserHolidaysShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset($tea.toMap(tmpReq.topHolidayQueryParam))) {
      request.topHolidayQueryParamShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle($tea.toMap(tmpReq.topHolidayQueryParam), "topHolidayQueryParam", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.topHolidayQueryParamShrink)) {
      query["topHolidayQueryParam"] = request.topHolidayQueryParamShrink;
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
    return $tea.cast<GetUserHolidaysResponse>(await this.doROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/holidays`, "json", req, runtime), new GetUserHolidaysResponse({}));
  }

}
