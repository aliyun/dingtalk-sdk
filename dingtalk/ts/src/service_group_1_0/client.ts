// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class DeleteKnowledgeHeaders extends $tea.Model {
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

export class DeleteKnowledgeRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  libraryKey?: string;
  source?: string;
  sourcePrimaryKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      libraryKey: 'libraryKey',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      libraryKey: 'string',
      source: 'string',
      sourcePrimaryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKnowledgeResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKnowledgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteKnowledgeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeHeaders extends $tea.Model {
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

export class AddKnowledgeRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  libraryKey?: string;
  source?: string;
  sourcePrimaryKey?: string;
  type?: string;
  title?: string;
  content?: string;
  linkUrl?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      libraryKey: 'libraryKey',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
      type: 'type',
      title: 'title',
      content: 'content',
      linkUrl: 'linkUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      libraryKey: 'string',
      source: 'string',
      sourcePrimaryKey: 'string',
      type: 'string',
      title: 'string',
      content: 'string',
      linkUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeResponseBody extends $tea.Model {
  result?: AddKnowledgeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddKnowledgeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddKnowledgeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLibraryHeaders extends $tea.Model {
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

export class AddLibraryRequest extends $tea.Model {
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingOrgId?: number;
  openTeamIds?: string[];
  title?: string;
  description?: string;
  type?: string;
  source?: string;
  sourcePrimaryKey?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingOrgId: 'dingOrgId',
      openTeamIds: 'openTeamIds',
      title: 'title',
      description: 'description',
      type: 'type',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingOrgId: 'number',
      openTeamIds: { 'type': 'array', 'itemType': 'string' },
      title: 'string',
      description: 'string',
      type: 'string',
      source: 'string',
      sourcePrimaryKey: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLibraryResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLibraryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddLibraryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddLibraryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserTeamsHeaders extends $tea.Model {
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

export class ListUserTeamsResponseBody extends $tea.Model {
  teams?: ListUserTeamsResponseBodyTeams[];
  static names(): { [key: string]: string } {
    return {
      teams: 'teams',
    };
  }

  static types(): { [key: string]: any } {
    return {
      teams: { 'type': 'array', 'itemType': ListUserTeamsResponseBodyTeams },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserTeamsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListUserTeamsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListUserTeamsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeResponseBodyResult extends $tea.Model {
  openKnowledgeId?: string;
  static names(): { [key: string]: string } {
    return {
      openKnowledgeId: 'openKnowledgeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openKnowledgeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserTeamsResponseBodyTeams extends $tea.Model {
  openTeamId?: string;
  teamName?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      teamName: 'teamName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      teamName: 'string',
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


  async deleteKnowledge(request: DeleteKnowledgeRequest): Promise<DeleteKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKnowledgeHeaders({ });
    return await this.deleteKnowledgeWithOptions(request, headers, runtime);
  }

  async deleteKnowledgeWithOptions(request: DeleteKnowledgeRequest, headers: DeleteKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.libraryKey)) {
      body["libraryKey"] = request.libraryKey;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
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
    return $tea.cast<DeleteKnowledgeResponse>(await this.doROARequest("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/knowledges/batchDelete`, "json", req, runtime), new DeleteKnowledgeResponse({}));
  }

  async addKnowledge(request: AddKnowledgeRequest): Promise<AddKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddKnowledgeHeaders({ });
    return await this.addKnowledgeWithOptions(request, headers, runtime);
  }

  async addKnowledgeWithOptions(request: AddKnowledgeRequest, headers: AddKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<AddKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.libraryKey)) {
      body["libraryKey"] = request.libraryKey;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.linkUrl)) {
      body["linkUrl"] = request.linkUrl;
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
    return $tea.cast<AddKnowledgeResponse>(await this.doROARequest("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/knowledges`, "json", req, runtime), new AddKnowledgeResponse({}));
  }

  async addLibrary(request: AddLibraryRequest): Promise<AddLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLibraryHeaders({ });
    return await this.addLibraryWithOptions(request, headers, runtime);
  }

  async addLibraryWithOptions(request: AddLibraryRequest, headers: AddLibraryHeaders, runtime: $Util.RuntimeOptions): Promise<AddLibraryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.openTeamIds)) {
      body["openTeamIds"] = request.openTeamIds;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<AddLibraryResponse>(await this.doROARequest("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/librarys`, "json", req, runtime), new AddLibraryResponse({}));
  }

  async listUserTeams(userId: string): Promise<ListUserTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserTeamsHeaders({ });
    return await this.listUserTeamsWithOptions(userId, headers, runtime);
  }

  async listUserTeamsWithOptions(userId: string, headers: ListUserTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserTeamsResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<ListUserTeamsResponse>(await this.doROARequest("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/users/${userId}/teams`, "json", req, runtime), new ListUserTeamsResponse({}));
  }

}
