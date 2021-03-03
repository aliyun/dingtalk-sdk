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

}
