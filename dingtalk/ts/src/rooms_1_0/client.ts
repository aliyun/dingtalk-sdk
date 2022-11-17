// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateMeetingRoomHeaders extends $tea.Model {
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

export class CreateMeetingRoomRequest extends $tea.Model {
  groupId?: number;
  isvRoomId?: string;
  roomCapacity?: number;
  roomLabelIds?: number[];
  roomLocation?: CreateMeetingRoomRequestRoomLocation;
  roomName?: string;
  roomPicture?: string;
  roomStatus?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      isvRoomId: 'isvRoomId',
      roomCapacity: 'roomCapacity',
      roomLabelIds: 'roomLabelIds',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStatus: 'roomStatus',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      isvRoomId: 'string',
      roomCapacity: 'number',
      roomLabelIds: { 'type': 'array', 'itemType': 'number' },
      roomLocation: CreateMeetingRoomRequestRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStatus: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateMeetingRoomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomGroupHeaders extends $tea.Model {
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

export class CreateMeetingRoomGroupRequest extends $tea.Model {
  groupName?: string;
  parentGroupId?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      parentGroupId: 'parentGroupId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      parentGroupId: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomGroupResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateMeetingRoomGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomHeaders extends $tea.Model {
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

export class DeleteMeetingRoomRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteMeetingRoomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomGroupHeaders extends $tea.Model {
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

export class DeleteMeetingRoomGroupRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomGroupResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteMeetingRoomGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeHeaders extends $tea.Model {
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

export class QueryDeviceIpByCodeRequest extends $tea.Model {
  deviceSn?: string;
  static names(): { [key: string]: string } {
    return {
      deviceSn: 'deviceSn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceSn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeResponseBody extends $tea.Model {
  result?: QueryDeviceIpByCodeResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryDeviceIpByCodeResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDeviceIpByCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDeviceIpByCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomHeaders extends $tea.Model {
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

export class QueryMeetingRoomRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBody extends $tea.Model {
  result?: QueryMeetingRoomResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryMeetingRoomResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMeetingRoomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupHeaders extends $tea.Model {
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

export class QueryMeetingRoomGroupRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupResponseBody extends $tea.Model {
  groupId?: number;
  groupName?: string;
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMeetingRoomGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListHeaders extends $tea.Model {
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

export class QueryMeetingRoomGroupListRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListResponseBody extends $tea.Model {
  result?: QueryMeetingRoomGroupListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryMeetingRoomGroupListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMeetingRoomGroupListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMeetingRoomGroupListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListHeaders extends $tea.Model {
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

export class QueryMeetingRoomListRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  result?: QueryMeetingRoomListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      result: { 'type': 'array', 'itemType': QueryMeetingRoomListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMeetingRoomListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMeetingRoomListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomHeaders extends $tea.Model {
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

export class UpdateMeetingRoomRequest extends $tea.Model {
  groupId?: number;
  isvRoomId?: string;
  roomCapacity?: number;
  roomId?: string;
  roomLabelIds?: number[];
  roomLocation?: UpdateMeetingRoomRequestRoomLocation;
  roomName?: string;
  roomPicture?: string;
  roomStatus?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      isvRoomId: 'isvRoomId',
      roomCapacity: 'roomCapacity',
      roomId: 'roomId',
      roomLabelIds: 'roomLabelIds',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStatus: 'roomStatus',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      isvRoomId: 'string',
      roomCapacity: 'number',
      roomId: 'string',
      roomLabelIds: { 'type': 'array', 'itemType': 'number' },
      roomLocation: UpdateMeetingRoomRequestRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStatus: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateMeetingRoomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomGroupHeaders extends $tea.Model {
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

export class UpdateMeetingRoomGroupRequest extends $tea.Model {
  groupId?: number;
  groupName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomGroupResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateMeetingRoomGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomRequestRoomLocation extends $tea.Model {
  desc?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeResponseBodyResult extends $tea.Model {
  deviceIp?: string;
  static names(): { [key: string]: string } {
    return {
      deviceIp: 'deviceIp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultRoomGroup extends $tea.Model {
  groupId?: number;
  groupName?: string;
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultRoomLabels extends $tea.Model {
  labelId?: number;
  labelName?: string;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultRoomLocation extends $tea.Model {
  desc?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResult extends $tea.Model {
  corpId?: string;
  isvRoomId?: string;
  roomCapacity?: number;
  roomGroup?: QueryMeetingRoomResponseBodyResultRoomGroup;
  roomId?: string;
  roomLabels?: QueryMeetingRoomResponseBodyResultRoomLabels[];
  roomLocation?: QueryMeetingRoomResponseBodyResultRoomLocation;
  roomName?: string;
  roomPicture?: string;
  roomStaffId?: string;
  roomStatus?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isvRoomId: 'isvRoomId',
      roomCapacity: 'roomCapacity',
      roomGroup: 'roomGroup',
      roomId: 'roomId',
      roomLabels: 'roomLabels',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStaffId: 'roomStaffId',
      roomStatus: 'roomStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isvRoomId: 'string',
      roomCapacity: 'number',
      roomGroup: QueryMeetingRoomResponseBodyResultRoomGroup,
      roomId: 'string',
      roomLabels: { 'type': 'array', 'itemType': QueryMeetingRoomResponseBodyResultRoomLabels },
      roomLocation: QueryMeetingRoomResponseBodyResultRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStaffId: 'string',
      roomStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListResponseBodyResult extends $tea.Model {
  groupId?: number;
  groupName?: string;
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResultRoomGroup extends $tea.Model {
  groupId?: number;
  groupName?: string;
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResultRoomLabels extends $tea.Model {
  labelId?: number;
  labelName?: string;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResultRoomLocation extends $tea.Model {
  desc?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResult extends $tea.Model {
  corpId?: string;
  isvRoomId?: string;
  roomCapacity?: number;
  roomGroup?: QueryMeetingRoomListResponseBodyResultRoomGroup;
  roomId?: string;
  roomLabels?: QueryMeetingRoomListResponseBodyResultRoomLabels[];
  roomLocation?: QueryMeetingRoomListResponseBodyResultRoomLocation;
  roomName?: string;
  roomPicture?: string;
  roomStaffId?: string;
  roomStatus?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isvRoomId: 'isvRoomId',
      roomCapacity: 'roomCapacity',
      roomGroup: 'roomGroup',
      roomId: 'roomId',
      roomLabels: 'roomLabels',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStaffId: 'roomStaffId',
      roomStatus: 'roomStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isvRoomId: 'string',
      roomCapacity: 'number',
      roomGroup: QueryMeetingRoomListResponseBodyResultRoomGroup,
      roomId: 'string',
      roomLabels: { 'type': 'array', 'itemType': QueryMeetingRoomListResponseBodyResultRoomLabels },
      roomLocation: QueryMeetingRoomListResponseBodyResultRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStaffId: 'string',
      roomStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomRequestRoomLocation extends $tea.Model {
  desc?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
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


  async createMeetingRoom(request: CreateMeetingRoomRequest): Promise<CreateMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMeetingRoomHeaders({ });
    return await this.createMeetingRoomWithOptions(request, headers, runtime);
  }

  async createMeetingRoomWithOptions(request: CreateMeetingRoomRequest, headers: CreateMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMeetingRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.isvRoomId)) {
      body["isvRoomId"] = request.isvRoomId;
    }

    if (!Util.isUnset(request.roomCapacity)) {
      body["roomCapacity"] = request.roomCapacity;
    }

    if (!Util.isUnset(request.roomLabelIds)) {
      body["roomLabelIds"] = request.roomLabelIds;
    }

    if (!Util.isUnset($tea.toMap(request.roomLocation))) {
      body["roomLocation"] = request.roomLocation;
    }

    if (!Util.isUnset(request.roomName)) {
      body["roomName"] = request.roomName;
    }

    if (!Util.isUnset(request.roomPicture)) {
      body["roomPicture"] = request.roomPicture;
    }

    if (!Util.isUnset(request.roomStatus)) {
      body["roomStatus"] = request.roomStatus;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<CreateMeetingRoomResponse>(await this.doROARequest("CreateMeetingRoom", "rooms_1.0", "HTTP", "POST", "AK", `/v1.0/rooms/meetingrooms`, "json", req, runtime), new CreateMeetingRoomResponse({}));
  }

  async createMeetingRoomGroup(request: CreateMeetingRoomGroupRequest): Promise<CreateMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMeetingRoomGroupHeaders({ });
    return await this.createMeetingRoomGroupWithOptions(request, headers, runtime);
  }

  async createMeetingRoomGroupWithOptions(request: CreateMeetingRoomGroupRequest, headers: CreateMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMeetingRoomGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.parentGroupId)) {
      body["parentGroupId"] = request.parentGroupId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<CreateMeetingRoomGroupResponse>(await this.doROARequest("CreateMeetingRoomGroup", "rooms_1.0", "HTTP", "POST", "AK", `/v1.0/rooms/groups`, "json", req, runtime), new CreateMeetingRoomGroupResponse({}));
  }

  async deleteMeetingRoom(roomId: string, request: DeleteMeetingRoomRequest): Promise<DeleteMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteMeetingRoomHeaders({ });
    return await this.deleteMeetingRoomWithOptions(roomId, request, headers, runtime);
  }

  async deleteMeetingRoomWithOptions(roomId: string, request: DeleteMeetingRoomRequest, headers: DeleteMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteMeetingRoomResponse> {
    Util.validateModel(request);
    roomId = OpenApiUtil.getEncodeParam(roomId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<DeleteMeetingRoomResponse>(await this.doROARequest("DeleteMeetingRoom", "rooms_1.0", "HTTP", "DELETE", "AK", `/v1.0/rooms/meetingRooms/${roomId}`, "json", req, runtime), new DeleteMeetingRoomResponse({}));
  }

  async deleteMeetingRoomGroup(groupId: string, request: DeleteMeetingRoomGroupRequest): Promise<DeleteMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteMeetingRoomGroupHeaders({ });
    return await this.deleteMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
  }

  async deleteMeetingRoomGroupWithOptions(groupId: string, request: DeleteMeetingRoomGroupRequest, headers: DeleteMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteMeetingRoomGroupResponse> {
    Util.validateModel(request);
    groupId = OpenApiUtil.getEncodeParam(groupId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<DeleteMeetingRoomGroupResponse>(await this.doROARequest("DeleteMeetingRoomGroup", "rooms_1.0", "HTTP", "DELETE", "AK", `/v1.0/rooms/groups/${groupId}`, "json", req, runtime), new DeleteMeetingRoomGroupResponse({}));
  }

  async queryDeviceIpByCode(shareCode: string, request: QueryDeviceIpByCodeRequest): Promise<QueryDeviceIpByCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceIpByCodeHeaders({ });
    return await this.queryDeviceIpByCodeWithOptions(shareCode, request, headers, runtime);
  }

  async queryDeviceIpByCodeWithOptions(shareCode: string, request: QueryDeviceIpByCodeRequest, headers: QueryDeviceIpByCodeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceIpByCodeResponse> {
    Util.validateModel(request);
    shareCode = OpenApiUtil.getEncodeParam(shareCode);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceSn)) {
      query["deviceSn"] = request.deviceSn;
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
    return $tea.cast<QueryDeviceIpByCodeResponse>(await this.doROARequest("QueryDeviceIpByCode", "rooms_1.0", "HTTP", "GET", "AK", `/v1.0/rooms/devices/shareCodes/${shareCode}`, "json", req, runtime), new QueryDeviceIpByCodeResponse({}));
  }

  async queryMeetingRoom(roomId: string, request: QueryMeetingRoomRequest): Promise<QueryMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomHeaders({ });
    return await this.queryMeetingRoomWithOptions(roomId, request, headers, runtime);
  }

  async queryMeetingRoomWithOptions(roomId: string, request: QueryMeetingRoomRequest, headers: QueryMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomResponse> {
    Util.validateModel(request);
    roomId = OpenApiUtil.getEncodeParam(roomId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<QueryMeetingRoomResponse>(await this.doROARequest("QueryMeetingRoom", "rooms_1.0", "HTTP", "GET", "AK", `/v1.0/rooms/meetingRooms/${roomId}`, "json", req, runtime), new QueryMeetingRoomResponse({}));
  }

  async queryMeetingRoomGroup(groupId: string, request: QueryMeetingRoomGroupRequest): Promise<QueryMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomGroupHeaders({ });
    return await this.queryMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
  }

  async queryMeetingRoomGroupWithOptions(groupId: string, request: QueryMeetingRoomGroupRequest, headers: QueryMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomGroupResponse> {
    Util.validateModel(request);
    groupId = OpenApiUtil.getEncodeParam(groupId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<QueryMeetingRoomGroupResponse>(await this.doROARequest("QueryMeetingRoomGroup", "rooms_1.0", "HTTP", "GET", "AK", `/v1.0/rooms/groups/${groupId}`, "json", req, runtime), new QueryMeetingRoomGroupResponse({}));
  }

  async queryMeetingRoomGroupList(request: QueryMeetingRoomGroupListRequest): Promise<QueryMeetingRoomGroupListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomGroupListHeaders({ });
    return await this.queryMeetingRoomGroupListWithOptions(request, headers, runtime);
  }

  async queryMeetingRoomGroupListWithOptions(request: QueryMeetingRoomGroupListRequest, headers: QueryMeetingRoomGroupListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomGroupListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<QueryMeetingRoomGroupListResponse>(await this.doROARequest("QueryMeetingRoomGroupList", "rooms_1.0", "HTTP", "GET", "AK", `/v1.0/rooms/groupLists`, "json", req, runtime), new QueryMeetingRoomGroupListResponse({}));
  }

  async queryMeetingRoomList(request: QueryMeetingRoomListRequest): Promise<QueryMeetingRoomListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomListHeaders({ });
    return await this.queryMeetingRoomListWithOptions(request, headers, runtime);
  }

  async queryMeetingRoomListWithOptions(request: QueryMeetingRoomListRequest, headers: QueryMeetingRoomListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<QueryMeetingRoomListResponse>(await this.doROARequest("QueryMeetingRoomList", "rooms_1.0", "HTTP", "GET", "AK", `/v1.0/rooms/meetingRoomLists`, "json", req, runtime), new QueryMeetingRoomListResponse({}));
  }

  async updateMeetingRoom(request: UpdateMeetingRoomRequest): Promise<UpdateMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMeetingRoomHeaders({ });
    return await this.updateMeetingRoomWithOptions(request, headers, runtime);
  }

  async updateMeetingRoomWithOptions(request: UpdateMeetingRoomRequest, headers: UpdateMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMeetingRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.isvRoomId)) {
      body["isvRoomId"] = request.isvRoomId;
    }

    if (!Util.isUnset(request.roomCapacity)) {
      body["roomCapacity"] = request.roomCapacity;
    }

    if (!Util.isUnset(request.roomId)) {
      body["roomId"] = request.roomId;
    }

    if (!Util.isUnset(request.roomLabelIds)) {
      body["roomLabelIds"] = request.roomLabelIds;
    }

    if (!Util.isUnset($tea.toMap(request.roomLocation))) {
      body["roomLocation"] = request.roomLocation;
    }

    if (!Util.isUnset(request.roomName)) {
      body["roomName"] = request.roomName;
    }

    if (!Util.isUnset(request.roomPicture)) {
      body["roomPicture"] = request.roomPicture;
    }

    if (!Util.isUnset(request.roomStatus)) {
      body["roomStatus"] = request.roomStatus;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<UpdateMeetingRoomResponse>(await this.doROARequest("UpdateMeetingRoom", "rooms_1.0", "HTTP", "PUT", "AK", `/v1.0/rooms/meetingRooms`, "json", req, runtime), new UpdateMeetingRoomResponse({}));
  }

  async updateMeetingRoomGroup(request: UpdateMeetingRoomGroupRequest): Promise<UpdateMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMeetingRoomGroupHeaders({ });
    return await this.updateMeetingRoomGroupWithOptions(request, headers, runtime);
  }

  async updateMeetingRoomGroupWithOptions(request: UpdateMeetingRoomGroupRequest, headers: UpdateMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMeetingRoomGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<UpdateMeetingRoomGroupResponse>(await this.doROARequest("UpdateMeetingRoomGroup", "rooms_1.0", "HTTP", "PUT", "AK", `/v1.0/rooms/groups`, "json", req, runtime), new UpdateMeetingRoomGroupResponse({}));
  }

}
