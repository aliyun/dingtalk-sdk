// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      members: 'members',
      taskCreator: 'taskCreator',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      members: { 'type': 'array', 'itemType': UpdatePermissionForUsersRequestMembers },
      taskCreator: 'number',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionForUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async updatePermissionForUsers(taskId: string, request: UpdatePermissionForUsersRequest): Promise<UpdatePermissionForUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePermissionForUsersHeaders({ });
    return await this.updatePermissionForUsersWithOptions(taskId, request, headers, runtime);
  }

  async updatePermissionForUsersWithOptions(taskId: string, request: UpdatePermissionForUsersRequest, headers: UpdatePermissionForUsersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePermissionForUsersResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
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
    return $tea.cast<UpdatePermissionForUsersResponse>(await this.doROARequest("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", `/v1.0/transcribe/tasks/${taskId}/permissions`, "none", req, runtime), new UpdatePermissionForUsersResponse({}));
  }

}
