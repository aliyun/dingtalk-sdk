// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class DeleteWorkspaceMembersHeaders extends $tea.Model {
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

export class DeleteWorkspaceMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: DeleteWorkspaceMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': DeleteWorkspaceMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceMembersResponse extends $tea.Model {
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

export class AddWorkspaceDocMembersHeaders extends $tea.Model {
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

export class AddWorkspaceDocMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: AddWorkspaceDocMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': AddWorkspaceDocMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceDocMembersResponse extends $tea.Model {
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

export class UpdateWorkspaceMembersHeaders extends $tea.Model {
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

export class UpdateWorkspaceMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: UpdateWorkspaceMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': UpdateWorkspaceMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceMembersResponse extends $tea.Model {
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

export class UpdateWorkspaceDocMembersHeaders extends $tea.Model {
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

export class UpdateWorkspaceDocMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: UpdateWorkspaceDocMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': UpdateWorkspaceDocMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceDocMembersResponse extends $tea.Model {
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

export class CreateWorkspaceDocHeaders extends $tea.Model {
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

export class CreateWorkspaceDocRequest extends $tea.Model {
  name?: string;
  docType?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      docType: 'docType',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      docType: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceDocResponseBody extends $tea.Model {
  workspaceId?: string;
  nodeId?: string;
  docKey?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      nodeId: 'nodeId',
      docKey: 'docKey',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      nodeId: 'string',
      docKey: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceDocResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateWorkspaceDocResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateWorkspaceDocResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersHeaders extends $tea.Model {
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

export class AddWorkspaceMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: AddWorkspaceMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': AddWorkspaceMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersResponse extends $tea.Model {
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

export class CreateWorkspaceHeaders extends $tea.Model {
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

export class CreateWorkspaceRequest extends $tea.Model {
  name?: string;
  description?: string;
  operatorId?: string;
  dingOrgId?: number;
  dingUid?: number;
  dingAccessTokenType?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      description: 'description',
      operatorId: 'operatorId',
      dingOrgId: 'dingOrgId',
      dingUid: 'dingUid',
      dingAccessTokenType: 'dingAccessTokenType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      description: 'string',
      operatorId: 'string',
      dingOrgId: 'number',
      dingUid: 'number',
      dingAccessTokenType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceResponseBody extends $tea.Model {
  workspaceId?: string;
  name?: string;
  description?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      name: 'name',
      description: 'description',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      name: 'string',
      description: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateWorkspaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateWorkspaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersHeaders extends $tea.Model {
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

export class DeleteWorkspaceDocMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: DeleteWorkspaceDocMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': DeleteWorkspaceDocMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersResponse extends $tea.Model {
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

export class DeleteWorkspaceMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceDocMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceDocMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
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


  async deleteWorkspaceMembers(workspaceId: string, request: DeleteWorkspaceMembersRequest): Promise<DeleteWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceMembersHeaders({ });
    return await this.deleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async deleteWorkspaceMembersWithOptions(workspaceId: string, request: DeleteWorkspaceMembersRequest, headers: DeleteWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<DeleteWorkspaceMembersResponse>(await this.doROARequest("DeleteWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/members/remove`, "none", req, runtime), new DeleteWorkspaceMembersResponse({}));
  }

  async addWorkspaceDocMembers(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest): Promise<AddWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceDocMembersHeaders({ });
    return await this.addWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async addWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest, headers: AddWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<AddWorkspaceDocMembersResponse>(await this.doROARequest("AddWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`, "none", req, runtime), new AddWorkspaceDocMembersResponse({}));
  }

  async updateWorkspaceMembers(workspaceId: string, request: UpdateWorkspaceMembersRequest): Promise<UpdateWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceMembersHeaders({ });
    return await this.updateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async updateWorkspaceMembersWithOptions(workspaceId: string, request: UpdateWorkspaceMembersRequest, headers: UpdateWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<UpdateWorkspaceMembersResponse>(await this.doROARequest("UpdateWorkspaceMembers", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workspaces/${workspaceId}/members`, "none", req, runtime), new UpdateWorkspaceMembersResponse({}));
  }

  async updateWorkspaceDocMembers(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest): Promise<UpdateWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceDocMembersHeaders({ });
    return await this.updateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async updateWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest, headers: UpdateWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<UpdateWorkspaceDocMembersResponse>(await this.doROARequest("UpdateWorkspaceDocMembers", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`, "none", req, runtime), new UpdateWorkspaceDocMembersResponse({}));
  }

  async createWorkspaceDoc(workspaceId: string, request: CreateWorkspaceDocRequest): Promise<CreateWorkspaceDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceDocHeaders({ });
    return await this.createWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
  }

  async createWorkspaceDocWithOptions(workspaceId: string, request: CreateWorkspaceDocRequest, headers: CreateWorkspaceDocHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkspaceDocResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.docType)) {
      body["docType"] = request.docType;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
    return $tea.cast<CreateWorkspaceDocResponse>(await this.doROARequest("CreateWorkspaceDoc", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs`, "json", req, runtime), new CreateWorkspaceDocResponse({}));
  }

  async addWorkspaceMembers(workspaceId: string, request: AddWorkspaceMembersRequest): Promise<AddWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceMembersHeaders({ });
    return await this.addWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async addWorkspaceMembersWithOptions(workspaceId: string, request: AddWorkspaceMembersRequest, headers: AddWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<AddWorkspaceMembersResponse>(await this.doROARequest("AddWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/members`, "none", req, runtime), new AddWorkspaceMembersResponse({}));
  }

  async createWorkspace(request: CreateWorkspaceRequest): Promise<CreateWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceHeaders({ });
    return await this.createWorkspaceWithOptions(request, headers, runtime);
  }

  async createWorkspaceWithOptions(request: CreateWorkspaceRequest, headers: CreateWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkspaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingUid)) {
      body["dingUid"] = request.dingUid;
    }

    if (!Util.isUnset(request.dingAccessTokenType)) {
      body["dingAccessTokenType"] = request.dingAccessTokenType;
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
    return $tea.cast<CreateWorkspaceResponse>(await this.doROARequest("CreateWorkspace", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces`, "json", req, runtime), new CreateWorkspaceResponse({}));
  }

  async deleteWorkspaceDocMembers(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest): Promise<DeleteWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceDocMembersHeaders({ });
    return await this.deleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async deleteWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest, headers: DeleteWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<DeleteWorkspaceDocMembersResponse>(await this.doROARequest("DeleteWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members/remove`, "none", req, runtime), new DeleteWorkspaceDocMembersResponse({}));
  }

}
