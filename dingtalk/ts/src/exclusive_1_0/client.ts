// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetConferenceDetailHeaders extends $tea.Model {
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

export class GetConferenceDetailResponseBody extends $tea.Model {
  conferenceId?: string;
  title?: string;
  confStartTime?: number;
  duration?: number;
  totalNum?: number;
  attendeeNum?: number;
  attendeePercentage?: string;
  callerId?: string;
  callerName?: string;
  memberList?: GetConferenceDetailResponseBodyMemberList[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      title: 'title',
      confStartTime: 'confStartTime',
      duration: 'duration',
      totalNum: 'totalNum',
      attendeeNum: 'attendeeNum',
      attendeePercentage: 'attendeePercentage',
      callerId: 'callerId',
      callerName: 'callerName',
      memberList: 'memberList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      title: 'string',
      confStartTime: 'number',
      duration: 'number',
      totalNum: 'number',
      attendeeNum: 'number',
      attendeePercentage: 'string',
      callerId: 'string',
      callerName: 'string',
      memberList: { 'type': 'array', 'itemType': GetConferenceDetailResponseBodyMemberList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConferenceDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetConferenceDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetConferenceDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOaOperatorLogListHeaders extends $tea.Model {
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

export class GetOaOperatorLogListRequest extends $tea.Model {
  opUserId?: string;
  startTime?: number;
  endTime?: number;
  pageNumber?: number;
  pageSize?: number;
  categoryList?: string[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      startTime: 'startTime',
      endTime: 'endTime',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      categoryList: 'categoryList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      startTime: 'number',
      endTime: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      categoryList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOaOperatorLogListResponseBody extends $tea.Model {
  data?: GetOaOperatorLogListResponseBodyData[];
  itemCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      itemCount: 'itemCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetOaOperatorLogListResponseBodyData },
      itemCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOaOperatorLogListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOaOperatorLogListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOaOperatorLogListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCommentHeaders extends $tea.Model {
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

export class DeleteCommentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: boolean;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsHeaders extends $tea.Model {
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

export class GetAllLabelableDeptsResponseBody extends $tea.Model {
  data?: GetAllLabelableDeptsResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetAllLabelableDeptsResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAllLabelableDeptsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAllLabelableDeptsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrustDeviceListHeaders extends $tea.Model {
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

export class GetTrustDeviceListRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrustDeviceListResponseBody extends $tea.Model {
  data?: GetTrustDeviceListResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetTrustDeviceListResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrustDeviceListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTrustDeviceListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTrustDeviceListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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

export class CreateTrustedDeviceHeaders extends $tea.Model {
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

export class CreateTrustedDeviceRequest extends $tea.Model {
  userId?: string;
  platform?: string;
  macAddress?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      platform: 'platform',
      macAddress: 'macAddress',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      platform: 'string',
      macAddress: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustedDeviceResponseBody extends $tea.Model {
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

export class CreateTrustedDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTrustedDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTrustedDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupActiveInfoHeaders extends $tea.Model {
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

export class GetGroupActiveInfoRequest extends $tea.Model {
  statDate?: string;
  dingGroupId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
      dingGroupId: 'dingGroupId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
      dingGroupId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupActiveInfoResponseBody extends $tea.Model {
  data?: GetGroupActiveInfoResponseBodyData[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetGroupActiveInfoResponseBodyData },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupActiveInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetGroupActiveInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetGroupActiveInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCommentListHeaders extends $tea.Model {
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

export class GetCommentListRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCommentListResponseBody extends $tea.Model {
  data?: GetCommentListResponseBodyData[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetCommentListResponseBodyData },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCommentListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCommentListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCommentListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPartnerTypeByParentIdHeaders extends $tea.Model {
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

export class GetPartnerTypeByParentIdResponseBody extends $tea.Model {
  data?: GetPartnerTypeByParentIdResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetPartnerTypeByParentIdResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPartnerTypeByParentIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPartnerTypeByParentIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPartnerTypeByParentIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDeptPartnerTypeAndNumHeaders extends $tea.Model {
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

export class SetDeptPartnerTypeAndNumRequest extends $tea.Model {
  deptId?: string;
  partnerNum?: string;
  labelIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      partnerNum: 'partnerNum',
      labelIds: 'labelIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      partnerNum: 'string',
      labelIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDeptPartnerTypeAndNumResponse extends $tea.Model {
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

export class GetConferenceDetailResponseBodyMemberList extends $tea.Model {
  unionId?: string;
  name?: string;
  attendDuration?: number;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      name: 'name',
      attendDuration: 'attendDuration',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      name: 'string',
      attendDuration: 'number',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOaOperatorLogListResponseBodyData extends $tea.Model {
  opUserId?: string;
  opName?: string;
  opTime?: number;
  category1Name?: string;
  category2Name?: string;
  content?: string;
  extension?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      opName: 'opName',
      opTime: 'opTime',
      category1Name: 'category1Name',
      category2Name: 'category2Name',
      content: 'content',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      opName: 'string',
      opTime: 'number',
      category1Name: 'string',
      category2Name: 'string',
      content: 'string',
      extension: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 extends $tea.Model {
  labelId?: number;
  labelName?: string;
  levelNum?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
      levelNum: 'levelNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
      levelNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 extends $tea.Model {
  labelId?: number;
  labelName?: string;
  levelNum?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
      levelNum: 'levelNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
      levelNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 extends $tea.Model {
  labelId?: number;
  labelName?: string;
  levelNum?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
      levelNum: 'levelNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
      levelNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 extends $tea.Model {
  labelId?: number;
  labelName?: string;
  levelNum?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
      levelNum: 'levelNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
      levelNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 extends $tea.Model {
  labelId?: number;
  labelName?: string;
  levelNum?: number;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
      levelNum: 'levelNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
      levelNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllLabelableDeptsResponseBodyData extends $tea.Model {
  deptId?: string;
  superDeptId?: string;
  deptName?: string;
  memberCount?: number;
  partnerNum?: string;
  partnerLabelVOLevel1?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1;
  partnerLabelVOLevel2?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2;
  partnerLabelVOLevel3?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3;
  partnerLabelVOLevel4?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4;
  partnerLabelVOLevel5?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      superDeptId: 'superDeptId',
      deptName: 'deptName',
      memberCount: 'memberCount',
      partnerNum: 'partnerNum',
      partnerLabelVOLevel1: 'partnerLabelVOLevel1',
      partnerLabelVOLevel2: 'partnerLabelVOLevel2',
      partnerLabelVOLevel3: 'partnerLabelVOLevel3',
      partnerLabelVOLevel4: 'partnerLabelVOLevel4',
      partnerLabelVOLevel5: 'partnerLabelVOLevel5',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      superDeptId: 'string',
      deptName: 'string',
      memberCount: 'number',
      partnerNum: 'string',
      partnerLabelVOLevel1: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1,
      partnerLabelVOLevel2: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2,
      partnerLabelVOLevel3: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3,
      partnerLabelVOLevel4: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4,
      partnerLabelVOLevel5: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrustDeviceListResponseBodyData extends $tea.Model {
  userId?: string;
  platform?: string;
  macAddress?: string;
  status?: number;
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      platform: 'platform',
      macAddress: 'macAddress',
      status: 'status',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      platform: 'string',
      macAddress: 'string',
      status: 'number',
      createTime: 'number',
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

export class GetGroupActiveInfoResponseBodyData extends $tea.Model {
  statDate?: string;
  dingGroupId?: string;
  groupCreateTime?: string;
  groupCreateUserId?: string;
  groupCreateUserName?: string;
  groupName?: string;
  groupType?: number;
  groupUserCnt1d?: number;
  sendMessageUserCnt1d?: number;
  sendMessageCnt1d?: number;
  openConvUv1d?: number;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
      dingGroupId: 'dingGroupId',
      groupCreateTime: 'groupCreateTime',
      groupCreateUserId: 'groupCreateUserId',
      groupCreateUserName: 'groupCreateUserName',
      groupName: 'groupName',
      groupType: 'groupType',
      groupUserCnt1d: 'groupUserCnt1d',
      sendMessageUserCnt1d: 'sendMessageUserCnt1d',
      sendMessageCnt1d: 'sendMessageCnt1d',
      openConvUv1d: 'openConvUv1d',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
      dingGroupId: 'string',
      groupCreateTime: 'string',
      groupCreateUserId: 'string',
      groupCreateUserName: 'string',
      groupName: 'string',
      groupType: 'number',
      groupUserCnt1d: 'number',
      sendMessageUserCnt1d: 'number',
      sendMessageCnt1d: 'number',
      openConvUv1d: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCommentListResponseBodyData extends $tea.Model {
  commentUserName?: string;
  content?: string;
  commentTime?: number;
  commentId?: string;
  static names(): { [key: string]: string } {
    return {
      commentUserName: 'commentUserName',
      content: 'content',
      commentTime: 'commentTime',
      commentId: 'commentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commentUserName: 'string',
      content: 'string',
      commentTime: 'number',
      commentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPartnerTypeByParentIdResponseBodyData extends $tea.Model {
  typeId?: number;
  typeName?: string;
  static names(): { [key: string]: string } {
    return {
      typeId: 'typeId',
      typeName: 'typeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      typeId: 'number',
      typeName: 'string',
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


  async getConferenceDetail(conferenceId: string): Promise<GetConferenceDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConferenceDetailHeaders({ });
    return await this.getConferenceDetailWithOptions(conferenceId, headers, runtime);
  }

  async getConferenceDetailWithOptions(conferenceId: string, headers: GetConferenceDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetConferenceDetailResponse> {
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
    return $tea.cast<GetConferenceDetailResponse>(await this.doROARequest("GetConferenceDetail", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/conferences/${conferenceId}`, "json", req, runtime), new GetConferenceDetailResponse({}));
  }

  async getOaOperatorLogList(request: GetOaOperatorLogListRequest): Promise<GetOaOperatorLogListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOaOperatorLogListHeaders({ });
    return await this.getOaOperatorLogListWithOptions(request, headers, runtime);
  }

  async getOaOperatorLogListWithOptions(request: GetOaOperatorLogListRequest, headers: GetOaOperatorLogListHeaders, runtime: $Util.RuntimeOptions): Promise<GetOaOperatorLogListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.categoryList)) {
      body["categoryList"] = request.categoryList;
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
    return $tea.cast<GetOaOperatorLogListResponse>(await this.doROARequest("GetOaOperatorLogList", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/oaOperatorLogs/query`, "json", req, runtime), new GetOaOperatorLogListResponse({}));
  }

  async deleteComment(publisherId: string, commentId: string): Promise<DeleteCommentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCommentHeaders({ });
    return await this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
  }

  async deleteCommentWithOptions(publisherId: string, commentId: string, headers: DeleteCommentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCommentResponse> {
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
    return $tea.cast<DeleteCommentResponse>(await this.doROARequest("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", `/v1.0/exclusive/publishers/${publisherId}/comments/${commentId}`, "boolean", req, runtime), new DeleteCommentResponse({}));
  }

  async getAllLabelableDepts(): Promise<GetAllLabelableDeptsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllLabelableDeptsHeaders({ });
    return await this.getAllLabelableDeptsWithOptions(headers, runtime);
  }

  async getAllLabelableDeptsWithOptions(headers: GetAllLabelableDeptsHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllLabelableDeptsResponse> {
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
    return $tea.cast<GetAllLabelableDeptsResponse>(await this.doROARequest("GetAllLabelableDepts", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/partnerDepartments`, "json", req, runtime), new GetAllLabelableDeptsResponse({}));
  }

  async getTrustDeviceList(request: GetTrustDeviceListRequest): Promise<GetTrustDeviceListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTrustDeviceListHeaders({ });
    return await this.getTrustDeviceListWithOptions(request, headers, runtime);
  }

  async getTrustDeviceListWithOptions(request: GetTrustDeviceListRequest, headers: GetTrustDeviceListHeaders, runtime: $Util.RuntimeOptions): Promise<GetTrustDeviceListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<GetTrustDeviceListResponse>(await this.doROARequest("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/trustedDevices/query`, "json", req, runtime), new GetTrustDeviceListResponse({}));
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

  async createTrustedDevice(request: CreateTrustedDeviceRequest): Promise<CreateTrustedDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceHeaders({ });
    return await this.createTrustedDeviceWithOptions(request, headers, runtime);
  }

  async createTrustedDeviceWithOptions(request: CreateTrustedDeviceRequest, headers: CreateTrustedDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTrustedDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.platform)) {
      body["platform"] = request.platform;
    }

    if (!Util.isUnset(request.macAddress)) {
      body["macAddress"] = request.macAddress;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<CreateTrustedDeviceResponse>(await this.doROARequest("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/trustedDevices`, "json", req, runtime), new CreateTrustedDeviceResponse({}));
  }

  async getGroupActiveInfo(request: GetGroupActiveInfoRequest): Promise<GetGroupActiveInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupActiveInfoHeaders({ });
    return await this.getGroupActiveInfoWithOptions(request, headers, runtime);
  }

  async getGroupActiveInfoWithOptions(request: GetGroupActiveInfoRequest, headers: GetGroupActiveInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetGroupActiveInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

    if (!Util.isUnset(request.dingGroupId)) {
      query["dingGroupId"] = request.dingGroupId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<GetGroupActiveInfoResponse>(await this.doROARequest("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/activeGroups`, "json", req, runtime), new GetGroupActiveInfoResponse({}));
  }

  async getCommentList(publisherId: string, request: GetCommentListRequest): Promise<GetCommentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCommentListHeaders({ });
    return await this.getCommentListWithOptions(publisherId, request, headers, runtime);
  }

  async getCommentListWithOptions(publisherId: string, request: GetCommentListRequest, headers: GetCommentListHeaders, runtime: $Util.RuntimeOptions): Promise<GetCommentListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<GetCommentListResponse>(await this.doROARequest("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/publishers/${publisherId}/comments/list`, "json", req, runtime), new GetCommentListResponse({}));
  }

  async getPartnerTypeByParentId(parentId: string): Promise<GetPartnerTypeByParentIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPartnerTypeByParentIdHeaders({ });
    return await this.getPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
  }

  async getPartnerTypeByParentIdWithOptions(parentId: string, headers: GetPartnerTypeByParentIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetPartnerTypeByParentIdResponse> {
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
    return $tea.cast<GetPartnerTypeByParentIdResponse>(await this.doROARequest("GetPartnerTypeByParentId", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/partnerLabels/${parentId}`, "json", req, runtime), new GetPartnerTypeByParentIdResponse({}));
  }

  async setDeptPartnerTypeAndNum(request: SetDeptPartnerTypeAndNumRequest): Promise<SetDeptPartnerTypeAndNumResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetDeptPartnerTypeAndNumHeaders({ });
    return await this.setDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
  }

  async setDeptPartnerTypeAndNumWithOptions(request: SetDeptPartnerTypeAndNumRequest, headers: SetDeptPartnerTypeAndNumHeaders, runtime: $Util.RuntimeOptions): Promise<SetDeptPartnerTypeAndNumResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.partnerNum)) {
      body["partnerNum"] = request.partnerNum;
    }

    if (!Util.isUnset(request.labelIds)) {
      body["labelIds"] = request.labelIds;
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
    return $tea.cast<SetDeptPartnerTypeAndNumResponse>(await this.doROARequest("SetDeptPartnerTypeAndNum", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/partnerDepartments`, "none", req, runtime), new SetDeptPartnerTypeAndNumResponse({}));
  }

}
