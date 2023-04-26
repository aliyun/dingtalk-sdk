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

export class GetTranscribeBriefHeaders extends $tea.Model {
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

export class GetTranscribeBriefResponseBody extends $tea.Model {
  data?: GetTranscribeBriefResponseBodyData;
  statusCode?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      statusCode: 'statusCode',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetTranscribeBriefResponseBodyData,
      statusCode: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranscribeBriefResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTranscribeBriefResponseBody;
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
      body: GetTranscribeBriefResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemovePermissionHeaders extends $tea.Model {
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

export class RemovePermissionRequest extends $tea.Model {
  bizType?: number;
  members?: RemovePermissionRequestMembers[];
  taskCreator?: number;
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      members: 'members',
      taskCreator: 'taskCreator',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      members: { 'type': 'array', 'itemType': RemovePermissionRequestMembers },
      taskCreator: 'number',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemovePermissionResponseBody extends $tea.Model {
  data?: RemovePermissionResponseBodyData;
  statusCode?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      statusCode: 'statusCode',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: RemovePermissionResponseBodyData,
      statusCode: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemovePermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemovePermissionResponseBody;
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
      body: RemovePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionForUsersHeaders extends $tea.Model {
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

export class UpdatePermissionForUsersRequest extends $tea.Model {
  bizType?: number;
  members?: UpdatePermissionForUsersRequestMembers[];
  taskCreator?: number;
  operatorUid?: number;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      members: 'members',
      taskCreator: 'taskCreator',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      members: { 'type': 'array', 'itemType': UpdatePermissionForUsersRequestMembers },
      taskCreator: 'number',
      operatorUid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionForUsersResponseBody extends $tea.Model {
  isSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccess: 'isSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionForUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdatePermissionForUsersResponseBody;
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
      body: UpdatePermissionForUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranscribeBriefResponseBodyData extends $tea.Model {
  bizType?: number;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemovePermissionRequestMembers extends $tea.Model {
  memberId?: number;
  memberType?: string;
  policyType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      policyType: 'policyType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'number',
      memberType: 'string',
      policyType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemovePermissionResponseBodyData extends $tea.Model {
  failNameList?: string[];
  static names(): { [key: string]: string } {
    return {
      failNameList: 'failNameList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failNameList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionForUsersRequestMembers extends $tea.Model {
  memberId?: number;
  memberType?: string;
  policyType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      policyType: 'policyType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'number',
      memberType: 'string',
      policyType: 'string',
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


  async getTranscribeBriefWithOptions(taskUuid: string, headers: GetTranscribeBriefHeaders, runtime: $Util.RuntimeOptions): Promise<GetTranscribeBriefResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetTranscribeBrief",
      version: "transcribe_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/transcribe/tasks/${taskUuid}/briefInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTranscribeBriefResponse>(await this.execute(params, req, runtime), new GetTranscribeBriefResponse({}));
  }

  async getTranscribeBrief(taskUuid: string): Promise<GetTranscribeBriefResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTranscribeBriefHeaders({ });
    return await this.getTranscribeBriefWithOptions(taskUuid, headers, runtime);
  }

  async removePermissionWithOptions(taskUuid: string, request: RemovePermissionRequest, headers: RemovePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<RemovePermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.taskCreator)) {
      body["taskCreator"] = request.taskCreator;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      action: "RemovePermission",
      version: "transcribe_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/transcribe/tasks/${taskUuid}/permissions/remove`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemovePermissionResponse>(await this.execute(params, req, runtime), new RemovePermissionResponse({}));
  }

  async removePermission(taskUuid: string, request: RemovePermissionRequest): Promise<RemovePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemovePermissionHeaders({ });
    return await this.removePermissionWithOptions(taskUuid, request, headers, runtime);
  }

  async updatePermissionForUsersWithOptions(taskUuid: string, request: UpdatePermissionForUsersRequest, headers: UpdatePermissionForUsersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePermissionForUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      query["operatorUid"] = request.operatorUid;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.taskCreator)) {
      body["taskCreator"] = request.taskCreator;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdatePermissionForUsers",
      version: "transcribe_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/transcribe/tasks/${taskUuid}/permissions`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdatePermissionForUsersResponse>(await this.execute(params, req, runtime), new UpdatePermissionForUsersResponse({}));
  }

  async updatePermissionForUsers(taskUuid: string, request: UpdatePermissionForUsersRequest): Promise<UpdatePermissionForUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePermissionForUsersHeaders({ });
    return await this.updatePermissionForUsersWithOptions(taskUuid, request, headers, runtime);
  }

}
