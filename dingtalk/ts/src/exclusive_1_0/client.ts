// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class SearchOrgInnerGroupInfoHeaders extends $tea.Model {
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

export class SearchOrgInnerGroupInfoRequest extends $tea.Model {
  groupMembersCountEnd?: number;
  syncToDingpan?: number;
  groupOwner?: string;
  createTimeEnd?: number;
  pageSize?: number;
  createTimeStart?: number;
  uuid?: string;
  groupMembersCountStart?: number;
  lastActiveTimeEnd?: number;
  operatorUserId?: string;
  groupName?: string;
  pageStart?: number;
  lastActiveTimeStart?: number;
  static names(): { [key: string]: string } {
    return {
      groupMembersCountEnd: 'groupMembersCountEnd',
      syncToDingpan: 'syncToDingpan',
      groupOwner: 'groupOwner',
      createTimeEnd: 'createTimeEnd',
      pageSize: 'pageSize',
      createTimeStart: 'createTimeStart',
      uuid: 'uuid',
      groupMembersCountStart: 'groupMembersCountStart',
      lastActiveTimeEnd: 'lastActiveTimeEnd',
      operatorUserId: 'operatorUserId',
      groupName: 'groupName',
      pageStart: 'pageStart',
      lastActiveTimeStart: 'lastActiveTimeStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMembersCountEnd: 'number',
      syncToDingpan: 'number',
      groupOwner: 'string',
      createTimeEnd: 'number',
      pageSize: 'number',
      createTimeStart: 'number',
      uuid: 'string',
      groupMembersCountStart: 'number',
      lastActiveTimeEnd: 'number',
      operatorUserId: 'string',
      groupName: 'string',
      pageStart: 'number',
      lastActiveTimeStart: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOrgInnerGroupInfoResponseBody extends $tea.Model {
  totalCount?: number;
  itemCount?: number;
  items?: SearchOrgInnerGroupInfoResponseBodyItems[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      itemCount: 'itemCount',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      itemCount: 'number',
      items: { 'type': 'array', 'itemType': SearchOrgInnerGroupInfoResponseBodyItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOrgInnerGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchOrgInnerGroupInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchOrgInnerGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOrgInnerGroupInfoResponseBodyItems extends $tea.Model {
  openConversationId?: string;
  groupOwner?: string;
  groupName?: string;
  groupAdminsCount?: number;
  groupMembersCount?: number;
  groupCreateTime?: number;
  groupLastActiveTime?: number;
  groupLastActiveTimeShow?: string;
  syncToDingpan?: number;
  usedQuota?: number;
  groupOwnerUserId?: string;
  status?: number;
  templateId?: string;
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      groupOwner: 'groupOwner',
      groupName: 'groupName',
      groupAdminsCount: 'groupAdminsCount',
      groupMembersCount: 'groupMembersCount',
      groupCreateTime: 'groupCreateTime',
      groupLastActiveTime: 'groupLastActiveTime',
      groupLastActiveTimeShow: 'groupLastActiveTimeShow',
      syncToDingpan: 'syncToDingpan',
      usedQuota: 'usedQuota',
      groupOwnerUserId: 'groupOwnerUserId',
      status: 'status',
      templateId: 'templateId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      groupOwner: 'string',
      groupName: 'string',
      groupAdminsCount: 'number',
      groupMembersCount: 'number',
      groupCreateTime: 'number',
      groupLastActiveTime: 'number',
      groupLastActiveTimeShow: 'string',
      syncToDingpan: 'number',
      usedQuota: 'number',
      groupOwnerUserId: 'string',
      status: 'number',
      templateId: 'string',
      templateName: 'string',
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


  async searchOrgInnerGroupInfo(request: SearchOrgInnerGroupInfoRequest): Promise<SearchOrgInnerGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchOrgInnerGroupInfoHeaders({ });
    return await this.searchOrgInnerGroupInfoWithOptions(request, headers, runtime);
  }

  async searchOrgInnerGroupInfoWithOptions(request: SearchOrgInnerGroupInfoRequest, headers: SearchOrgInnerGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SearchOrgInnerGroupInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupMembersCountEnd)) {
      query["groupMembersCountEnd"] = request.groupMembersCountEnd;
    }

    if (!Util.isUnset(request.syncToDingpan)) {
      query["syncToDingpan"] = request.syncToDingpan;
    }

    if (!Util.isUnset(request.groupOwner)) {
      query["groupOwner"] = request.groupOwner;
    }

    if (!Util.isUnset(request.createTimeEnd)) {
      query["createTimeEnd"] = request.createTimeEnd;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.createTimeStart)) {
      query["createTimeStart"] = request.createTimeStart;
    }

    if (!Util.isUnset(request.uuid)) {
      query["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.groupMembersCountStart)) {
      query["groupMembersCountStart"] = request.groupMembersCountStart;
    }

    if (!Util.isUnset(request.lastActiveTimeEnd)) {
      query["lastActiveTimeEnd"] = request.lastActiveTimeEnd;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      query["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.groupName)) {
      query["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.pageStart)) {
      query["pageStart"] = request.pageStart;
    }

    if (!Util.isUnset(request.lastActiveTimeStart)) {
      query["lastActiveTimeStart"] = request.lastActiveTimeStart;
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
    return $tea.cast<SearchOrgInnerGroupInfoResponse>(await this.doROARequest("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/securities/orgGroupInfos`, "json", req, runtime), new SearchOrgInnerGroupInfoResponse({}));
  }

}
