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

export class BatchRegisterDeviceHeaders extends $tea.Model {
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

export class BatchRegisterDeviceRequest extends $tea.Model {
  deviceList?: BatchRegisterDeviceRequestDeviceList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceList: 'deviceList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceList: { 'type': 'array', 'itemType': BatchRegisterDeviceRequestDeviceList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceResponseBody extends $tea.Model {
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

export class BatchRegisterDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchRegisterDeviceResponseBody;
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
      body: BatchRegisterDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConnectorEventPushHeaders extends $tea.Model {
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

export class ConnectorEventPushRequest extends $tea.Model {
  deviceTypeUuid?: string;
  eventName?: string;
  input?: string;
  static names(): { [key: string]: string } {
    return {
      deviceTypeUuid: 'deviceTypeUuid',
      eventName: 'eventName',
      input: 'input',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceTypeUuid: 'string',
      eventName: 'string',
      input: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConnectorEventPushResponseBody extends $tea.Model {
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

export class ConnectorEventPushResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ConnectorEventPushResponseBody;
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
      body: ConnectorEventPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateChatRoomHeaders extends $tea.Model {
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

export class CreateChatRoomRequest extends $tea.Model {
  chatGroupName?: string;
  deviceCodes?: string[];
  deviceTypeId?: string;
  ownerUserId?: string;
  roleList?: string[];
  static names(): { [key: string]: string } {
    return {
      chatGroupName: 'chatGroupName',
      deviceCodes: 'deviceCodes',
      deviceTypeId: 'deviceTypeId',
      ownerUserId: 'ownerUserId',
      roleList: 'roleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatGroupName: 'string',
      deviceCodes: { 'type': 'array', 'itemType': 'string' },
      deviceTypeId: 'string',
      ownerUserId: 'string',
      roleList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateChatRoomResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateChatRoomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateChatRoomResponseBody;
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
      body: CreateChatRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDepartmentHeaders extends $tea.Model {
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

export class CreateDepartmentRequest extends $tea.Model {
  authInfo?: string;
  authType?: string;
  bizExt?: string;
  departmentName?: string;
  departmentType?: string;
  description?: string;
  systemUrl?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      authInfo: 'authInfo',
      authType: 'authType',
      bizExt: 'bizExt',
      departmentName: 'departmentName',
      departmentType: 'departmentType',
      description: 'description',
      systemUrl: 'systemUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authInfo: 'string',
      authType: 'string',
      bizExt: 'string',
      departmentName: 'string',
      departmentType: 'string',
      description: 'string',
      systemUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDepartmentResponseBody extends $tea.Model {
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

export class CreateDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateDepartmentResponseBody;
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
      body: CreateDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceChatRoomHeaders extends $tea.Model {
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

export class CreateDeviceChatRoomRequest extends $tea.Model {
  chatType?: string;
  deviceCodes?: string[];
  deviceUuids?: string[];
  ownerUserId?: string;
  title?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      chatType: 'chatType',
      deviceCodes: 'deviceCodes',
      deviceUuids: 'deviceUuids',
      ownerUserId: 'ownerUserId',
      title: 'title',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatType: 'string',
      deviceCodes: { 'type': 'array', 'itemType': 'string' },
      deviceUuids: { 'type': 'array', 'itemType': 'string' },
      ownerUserId: 'string',
      title: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceChatRoomResponseBody extends $tea.Model {
  result?: CreateDeviceChatRoomResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateDeviceChatRoomResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceChatRoomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateDeviceChatRoomResponseBody;
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
      body: CreateDeviceChatRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceDingHeaders extends $tea.Model {
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

export class DeviceDingRequest extends $tea.Model {
  deviceKey?: string;
  paramsJson?: string;
  receiverUserIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceKey: 'deviceKey',
      paramsJson: 'paramsJson',
      receiverUserIdList: 'receiverUserIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceKey: 'string',
      paramsJson: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceDingResponseBody extends $tea.Model {
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

export class DeviceDingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeviceDingResponseBody;
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
      body: DeviceDingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DissolveGroupHeaders extends $tea.Model {
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

export class DissolveGroupRequest extends $tea.Model {
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DissolveGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DissolveGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DissolveGroupResponseBody;
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
      body: DissolveGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditDeviceAdminHeaders extends $tea.Model {
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

export class EditDeviceAdminRequest extends $tea.Model {
  deviceCode?: string;
  roleUuid?: string;
  userIds?: string[];
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      roleUuid: 'roleUuid',
      userIds: 'userIds',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      roleUuid: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditDeviceAdminResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditDeviceAdminResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditDeviceAdminResponseBody;
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
      body: EditDeviceAdminResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeviceGroupInfoHeaders extends $tea.Model {
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

export class GetDeviceGroupInfoRequest extends $tea.Model {
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeviceGroupInfoResponseBody extends $tea.Model {
  result?: GetDeviceGroupInfoResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetDeviceGroupInfoResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeviceGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDeviceGroupInfoResponseBody;
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
      body: GetDeviceGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWholeDeviceGroupHeaders extends $tea.Model {
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

export class GetWholeDeviceGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWholeDeviceGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetWholeDeviceGroupResponseBody;
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
      body: GetWholeDeviceGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivateDevicesHeaders extends $tea.Model {
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

export class ListActivateDevicesRequest extends $tea.Model {
  deviceCategory?: number;
  deviceCode?: string;
  deviceTypeId?: string;
  groupId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceTypeId: 'deviceTypeId',
      groupId: 'groupId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceTypeId: 'string',
      groupId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivateDevicesResponseBody extends $tea.Model {
  result?: ListActivateDevicesResponseBodyResult[];
  success?: boolean;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListActivateDevicesResponseBodyResult },
      success: 'boolean',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivateDevicesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListActivateDevicesResponseBody;
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
      body: ListActivateDevicesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInspectInfoHeaders extends $tea.Model {
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

export class ListInspectInfoRequest extends $tea.Model {
  deviceUuid?: string[];
  pageNumber?: number;
  pageSize?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      deviceUuid: 'deviceUuid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceUuid: { 'type': 'array', 'itemType': 'string' },
      pageNumber: 'number',
      pageSize: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInspectInfoResponseBody extends $tea.Model {
  result?: ListInspectInfoResponseBodyResult[];
  success?: boolean;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListInspectInfoResponseBodyResult },
      success: 'boolean',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInspectInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListInspectInfoResponseBody;
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
      body: ListInspectInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMaintainInfoHeaders extends $tea.Model {
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

export class ListMaintainInfoRequest extends $tea.Model {
  deviceUuid?: string[];
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      deviceUuid: 'deviceUuid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceUuid: { 'type': 'array', 'itemType': 'string' },
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMaintainInfoResponseBody extends $tea.Model {
  result?: ListMaintainInfoResponseBodyResult[];
  success?: boolean;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListMaintainInfoResponseBodyResult },
      success: 'boolean',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMaintainInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListMaintainInfoResponseBody;
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
      body: ListMaintainInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDeviceToGroupHeaders extends $tea.Model {
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

export class PullDeviceToGroupRequest extends $tea.Model {
  deviceCodes?: string[];
  deviceUuids?: string[];
  openConversationId?: string;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCodes: 'deviceCodes',
      deviceUuids: 'deviceUuids',
      openConversationId: 'openConversationId',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCodes: { 'type': 'array', 'itemType': 'string' },
      deviceUuids: { 'type': 'array', 'itemType': 'string' },
      openConversationId: 'string',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDeviceToGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDeviceToGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PullDeviceToGroupResponseBody;
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
      body: PullDeviceToGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullUserToGroupHeaders extends $tea.Model {
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

export class PullUserToGroupRequest extends $tea.Model {
  openConversationId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullUserToGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullUserToGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PullUserToGroupResponseBody;
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
      body: PullUserToGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceHeaders extends $tea.Model {
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

export class RegisterAndActivateDeviceRequest extends $tea.Model {
  deviceCallbackUrl?: string;
  deviceCategory?: number;
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceName?: string;
  introduction?: string;
  roleUuid?: string;
  typeUuid?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceCallbackUrl: 'deviceCallbackUrl',
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceName: 'deviceName',
      introduction: 'introduction',
      roleUuid: 'roleUuid',
      typeUuid: 'typeUuid',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCallbackUrl: 'string',
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceName: 'string',
      introduction: 'string',
      roleUuid: 'string',
      typeUuid: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceResponseBody extends $tea.Model {
  result?: RegisterAndActivateDeviceResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: RegisterAndActivateDeviceResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RegisterAndActivateDeviceResponseBody;
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
      body: RegisterAndActivateDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchHeaders extends $tea.Model {
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

export class RegisterAndActivateDeviceBatchRequest extends $tea.Model {
  registerAndActivateVOS?: RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS[];
  static names(): { [key: string]: string } {
    return {
      registerAndActivateVOS: 'registerAndActivateVOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      registerAndActivateVOS: { 'type': 'array', 'itemType': RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponseBody extends $tea.Model {
  failItems?: RegisterAndActivateDeviceBatchResponseBodyFailItems[];
  success?: boolean;
  successItems?: RegisterAndActivateDeviceBatchResponseBodySuccessItems[];
  static names(): { [key: string]: string } {
    return {
      failItems: 'failItems',
      success: 'success',
      successItems: 'successItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failItems: { 'type': 'array', 'itemType': RegisterAndActivateDeviceBatchResponseBodyFailItems },
      success: 'boolean',
      successItems: { 'type': 'array', 'itemType': RegisterAndActivateDeviceBatchResponseBodySuccessItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RegisterAndActivateDeviceBatchResponseBody;
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
      body: RegisterAndActivateDeviceBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterDeviceHeaders extends $tea.Model {
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

export class RegisterDeviceRequest extends $tea.Model {
  collaborators?: string;
  departmentId?: number;
  description?: string;
  deviceKey?: string;
  deviceName?: string;
  managers?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      collaborators: 'collaborators',
      departmentId: 'departmentId',
      description: 'description',
      deviceKey: 'deviceKey',
      deviceName: 'deviceName',
      managers: 'managers',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      collaborators: 'string',
      departmentId: 'number',
      description: 'string',
      deviceKey: 'string',
      deviceName: 'string',
      managers: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterDeviceResponseBody extends $tea.Model {
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

export class RegisterDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RegisterDeviceResponseBody;
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
      body: RegisterDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveDeviceFromGroupHeaders extends $tea.Model {
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

export class RemoveDeviceFromGroupRequest extends $tea.Model {
  deviceCodes?: string[];
  deviceUuids?: string[];
  openConversationId?: string;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCodes: 'deviceCodes',
      deviceUuids: 'deviceUuids',
      openConversationId: 'openConversationId',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCodes: { 'type': 'array', 'itemType': 'string' },
      deviceUuids: { 'type': 'array', 'itemType': 'string' },
      openConversationId: 'string',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveDeviceFromGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveDeviceFromGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemoveDeviceFromGroupResponseBody;
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
      body: RemoveDeviceFromGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveUserFromGroupHeaders extends $tea.Model {
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

export class RemoveUserFromGroupRequest extends $tea.Model {
  openConversationId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveUserFromGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveUserFromGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemoveUserFromGroupResponseBody;
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
      body: RemoveUserFromGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendCardHeaders extends $tea.Model {
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

export class SendCardRequest extends $tea.Model {
  bizId?: string;
  cardData?: string;
  deviceCode?: string;
  deviceUuid?: string;
  openConversationId?: string;
  partVisible?: boolean;
  receivers?: string[];
  templateId?: string;
  topbox?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      cardData: 'cardData',
      deviceCode: 'deviceCode',
      deviceUuid: 'deviceUuid',
      openConversationId: 'openConversationId',
      partVisible: 'partVisible',
      receivers: 'receivers',
      templateId: 'templateId',
      topbox: 'topbox',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      cardData: 'string',
      deviceCode: 'string',
      deviceUuid: 'string',
      openConversationId: 'string',
      partVisible: 'boolean',
      receivers: { 'type': 'array', 'itemType': 'string' },
      templateId: 'string',
      topbox: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendCardResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendCardResponseBody;
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
      body: SendCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgHeaders extends $tea.Model {
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

export class SendMsgRequest extends $tea.Model {
  content?: string;
  deviceCode?: string;
  deviceUuid?: string;
  openConversationId?: string;
  userList?: string[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      deviceCode: 'deviceCode',
      deviceUuid: 'deviceUuid',
      openConversationId: 'openConversationId',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      deviceCode: 'string',
      deviceUuid: 'string',
      openConversationId: 'string',
      userList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendMsgResponseBody;
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
      body: SendMsgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UninstallDeviceRobotHeaders extends $tea.Model {
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

export class UninstallDeviceRobotRequest extends $tea.Model {
  deviceCode?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UninstallDeviceRobotResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UninstallDeviceRobotResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UninstallDeviceRobotResponseBody;
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
      body: UninstallDeviceRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardHeaders extends $tea.Model {
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

export class UpdateCardRequest extends $tea.Model {
  bizId?: string;
  cardData?: string;
  tips?: UpdateCardRequestTips;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      cardData: 'cardData',
      tips: 'tips',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      cardData: 'string',
      tips: UpdateCardRequestTips,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateCardResponseBody;
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
      body: UpdateCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadEventHeaders extends $tea.Model {
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

export class UploadEventRequest extends $tea.Model {
  content?: string;
  coverUrl?: string;
  deviceCode?: string;
  deviceUuid?: string;
  eventTime?: string;
  eventType?: string;
  level?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      coverUrl: 'coverUrl',
      deviceCode: 'deviceCode',
      deviceUuid: 'deviceUuid',
      eventTime: 'eventTime',
      eventType: 'eventType',
      level: 'level',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      coverUrl: 'string',
      deviceCode: 'string',
      deviceUuid: 'string',
      eventTime: 'string',
      eventType: 'string',
      level: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadEventResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UploadEventResponseBody;
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
      body: UploadEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceRequestDeviceList extends $tea.Model {
  collaborators?: string;
  departmentId?: number;
  description?: string;
  deviceKey?: string;
  deviceName?: string;
  managers?: string;
  static names(): { [key: string]: string } {
    return {
      collaborators: 'collaborators',
      departmentId: 'departmentId',
      description: 'description',
      deviceKey: 'deviceKey',
      deviceName: 'deviceName',
      managers: 'managers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      collaborators: 'string',
      departmentId: 'number',
      description: 'string',
      deviceKey: 'string',
      deviceName: 'string',
      managers: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceChatRoomResponseBodyResult extends $tea.Model {
  chatId?: string;
  encodedCid?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      encodedCid: 'encodedCid',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      encodedCid: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeviceGroupInfoResponseBodyResultDevices extends $tea.Model {
  deviceCode?: string;
  deviceName?: string;
  deviceUuid?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
      deviceUuid: 'deviceUuid',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      deviceName: 'string',
      deviceUuid: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeviceGroupInfoResponseBodyResult extends $tea.Model {
  devices?: GetDeviceGroupInfoResponseBodyResultDevices[];
  ownerUser?: string;
  subAdminUsers?: string[];
  title?: string;
  users?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      devices: 'devices',
      ownerUser: 'ownerUser',
      subAdminUsers: 'subAdminUsers',
      title: 'title',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      devices: { 'type': 'array', 'itemType': GetDeviceGroupInfoResponseBodyResultDevices },
      ownerUser: 'string',
      subAdminUsers: { 'type': 'array', 'itemType': 'string' },
      title: 'string',
      users: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivateDevicesResponseBodyResult extends $tea.Model {
  bizExt?: string;
  deviceCallbackUrl?: string;
  deviceCategory?: number;
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceName?: string;
  groupUuid?: string;
  icon?: string;
  introduction?: string;
  typeUuid?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      bizExt: 'bizExt',
      deviceCallbackUrl: 'deviceCallbackUrl',
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceName: 'deviceName',
      groupUuid: 'groupUuid',
      icon: 'icon',
      introduction: 'introduction',
      typeUuid: 'typeUuid',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizExt: 'string',
      deviceCallbackUrl: 'string',
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceName: 'string',
      groupUuid: 'string',
      icon: 'string',
      introduction: 'string',
      typeUuid: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInspectInfoResponseBodyResult extends $tea.Model {
  deviceCode?: string;
  deviceName?: string;
  gmtCreate?: string;
  handleTime?: string;
  maintenanceStaff?: string[];
  name?: string;
  remark?: string;
  repairStatus?: number;
  status?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
      gmtCreate: 'gmtCreate',
      handleTime: 'handleTime',
      maintenanceStaff: 'maintenanceStaff',
      name: 'name',
      remark: 'remark',
      repairStatus: 'repairStatus',
      status: 'status',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      deviceName: 'string',
      gmtCreate: 'string',
      handleTime: 'string',
      maintenanceStaff: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      remark: 'string',
      repairStatus: 'number',
      status: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMaintainInfoResponseBodyResult extends $tea.Model {
  deviceCode?: string;
  deviceName?: string;
  gmtCreate?: string;
  handleTime?: string;
  maintenanceStaff?: string[];
  processState?: number;
  remark?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
      gmtCreate: 'gmtCreate',
      handleTime: 'handleTime',
      maintenanceStaff: 'maintenanceStaff',
      processState: 'processState',
      remark: 'remark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      deviceName: 'string',
      gmtCreate: 'string',
      handleTime: 'string',
      maintenanceStaff: { 'type': 'array', 'itemType': 'string' },
      processState: 'number',
      remark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceResponseBodyResult extends $tea.Model {
  deviceCategory?: number;
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceName?: string;
  deviceUuid?: string;
  introduction?: string;
  roleUuid?: string;
  typeUuid?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceName: 'deviceName',
      deviceUuid: 'deviceUuid',
      introduction: 'introduction',
      roleUuid: 'roleUuid',
      typeUuid: 'typeUuid',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceName: 'string',
      deviceUuid: 'string',
      introduction: 'string',
      roleUuid: 'string',
      typeUuid: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS extends $tea.Model {
  deviceCallbackUrl?: string;
  deviceCategory?: number;
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceName?: string;
  groupUuid?: string;
  introduction?: string;
  roleUuid?: string;
  typeUuid?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceCallbackUrl: 'deviceCallbackUrl',
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceName: 'deviceName',
      groupUuid: 'groupUuid',
      introduction: 'introduction',
      roleUuid: 'roleUuid',
      typeUuid: 'typeUuid',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCallbackUrl: 'string',
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceName: 'string',
      groupUuid: 'string',
      introduction: 'string',
      roleUuid: 'string',
      typeUuid: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponseBodyFailItemsResult extends $tea.Model {
  deviceCallbackUrl?: string;
  deviceCategory?: number;
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceName?: string;
  groupUuid?: string;
  icon?: string;
  introduction?: string;
  roleUuid?: string;
  status?: number;
  typeUuid?: string;
  userIds?: string[];
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCallbackUrl: 'deviceCallbackUrl',
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceName: 'deviceName',
      groupUuid: 'groupUuid',
      icon: 'icon',
      introduction: 'introduction',
      roleUuid: 'roleUuid',
      status: 'status',
      typeUuid: 'typeUuid',
      userIds: 'userIds',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCallbackUrl: 'string',
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceName: 'string',
      groupUuid: 'string',
      icon: 'string',
      introduction: 'string',
      roleUuid: 'string',
      status: 'number',
      typeUuid: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponseBodyFailItems extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  result?: RegisterAndActivateDeviceBatchResponseBodyFailItemsResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      result: RegisterAndActivateDeviceBatchResponseBodyFailItemsResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult extends $tea.Model {
  deviceCallbackUrl?: string;
  deviceCategory?: number;
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceName?: string;
  groupUuid?: string;
  icon?: string;
  introduction?: string;
  roleUuid?: string;
  status?: number;
  typeUuid?: string;
  userIds?: string[];
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCallbackUrl: 'deviceCallbackUrl',
      deviceCategory: 'deviceCategory',
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceName: 'deviceName',
      groupUuid: 'groupUuid',
      icon: 'icon',
      introduction: 'introduction',
      roleUuid: 'roleUuid',
      status: 'status',
      typeUuid: 'typeUuid',
      userIds: 'userIds',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCallbackUrl: 'string',
      deviceCategory: 'number',
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceName: 'string',
      groupUuid: 'string',
      icon: 'string',
      introduction: 'string',
      roleUuid: 'string',
      status: 'number',
      typeUuid: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponseBodySuccessItems extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  result?: RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      result: RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardRequestTips extends $tea.Model {
  cids?: string;
  content?: string;
  sender?: string;
  static names(): { [key: string]: string } {
    return {
      cids: 'cids',
      content: 'content',
      sender: 'sender',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cids: 'string',
      content: 'string',
      sender: 'string',
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


  async batchRegisterDeviceWithOptions(request: BatchRegisterDeviceRequest, headers: BatchRegisterDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRegisterDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceList)) {
      body["deviceList"] = request.deviceList;
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
      action: "BatchRegisterDevice",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/devices/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BatchRegisterDeviceResponse>(await this.execute(params, req, runtime), new BatchRegisterDeviceResponse({}));
  }

  async batchRegisterDevice(request: BatchRegisterDeviceRequest): Promise<BatchRegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRegisterDeviceHeaders({ });
    return await this.batchRegisterDeviceWithOptions(request, headers, runtime);
  }

  async connectorEventPushWithOptions(request: ConnectorEventPushRequest, headers: ConnectorEventPushHeaders, runtime: $Util.RuntimeOptions): Promise<ConnectorEventPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceTypeUuid)) {
      body["deviceTypeUuid"] = request.deviceTypeUuid;
    }

    if (!Util.isUnset(request.eventName)) {
      body["eventName"] = request.eventName;
    }

    if (!Util.isUnset(request.input)) {
      body["input"] = request.input;
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
      action: "ConnectorEventPush",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/connectors/events/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConnectorEventPushResponse>(await this.execute(params, req, runtime), new ConnectorEventPushResponse({}));
  }

  async connectorEventPush(request: ConnectorEventPushRequest): Promise<ConnectorEventPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConnectorEventPushHeaders({ });
    return await this.connectorEventPushWithOptions(request, headers, runtime);
  }

  async createChatRoomWithOptions(request: CreateChatRoomRequest, headers: CreateChatRoomHeaders, runtime: $Util.RuntimeOptions): Promise<CreateChatRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatGroupName)) {
      body["chatGroupName"] = request.chatGroupName;
    }

    if (!Util.isUnset(request.deviceCodes)) {
      body["deviceCodes"] = request.deviceCodes;
    }

    if (!Util.isUnset(request.deviceTypeId)) {
      body["deviceTypeId"] = request.deviceTypeId;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.roleList)) {
      body["roleList"] = request.roleList;
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
      action: "CreateChatRoom",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRoom`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateChatRoomResponse>(await this.execute(params, req, runtime), new CreateChatRoomResponse({}));
  }

  async createChatRoom(request: CreateChatRoomRequest): Promise<CreateChatRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateChatRoomHeaders({ });
    return await this.createChatRoomWithOptions(request, headers, runtime);
  }

  async createDepartmentWithOptions(request: CreateDepartmentRequest, headers: CreateDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDepartmentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authInfo)) {
      body["authInfo"] = request.authInfo;
    }

    if (!Util.isUnset(request.authType)) {
      body["authType"] = request.authType;
    }

    if (!Util.isUnset(request.bizExt)) {
      body["bizExt"] = request.bizExt;
    }

    if (!Util.isUnset(request.departmentName)) {
      body["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.departmentType)) {
      body["departmentType"] = request.departmentType;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.systemUrl)) {
      body["systemUrl"] = request.systemUrl;
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
      action: "CreateDepartment",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/departments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateDepartmentResponse>(await this.execute(params, req, runtime), new CreateDepartmentResponse({}));
  }

  async createDepartment(request: CreateDepartmentRequest): Promise<CreateDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDepartmentHeaders({ });
    return await this.createDepartmentWithOptions(request, headers, runtime);
  }

  async createDeviceChatRoomWithOptions(request: CreateDeviceChatRoomRequest, headers: CreateDeviceChatRoomHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeviceChatRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatType)) {
      body["chatType"] = request.chatType;
    }

    if (!Util.isUnset(request.deviceCodes)) {
      body["deviceCodes"] = request.deviceCodes;
    }

    if (!Util.isUnset(request.deviceUuids)) {
      body["deviceUuids"] = request.deviceUuids;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "CreateDeviceChatRoom",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDeviceChatRoomResponse>(await this.execute(params, req, runtime), new CreateDeviceChatRoomResponse({}));
  }

  async createDeviceChatRoom(request: CreateDeviceChatRoomRequest): Promise<CreateDeviceChatRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeviceChatRoomHeaders({ });
    return await this.createDeviceChatRoomWithOptions(request, headers, runtime);
  }

  async deviceDingWithOptions(request: DeviceDingRequest, headers: DeviceDingHeaders, runtime: $Util.RuntimeOptions): Promise<DeviceDingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceKey)) {
      body["deviceKey"] = request.deviceKey;
    }

    if (!Util.isUnset(request.paramsJson)) {
      body["paramsJson"] = request.paramsJson;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
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
      action: "DeviceDing",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/ding`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeviceDingResponse>(await this.execute(params, req, runtime), new DeviceDingResponse({}));
  }

  async deviceDing(request: DeviceDingRequest): Promise<DeviceDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceDingHeaders({ });
    return await this.deviceDingWithOptions(request, headers, runtime);
  }

  async dissolveGroupWithOptions(request: DissolveGroupRequest, headers: DissolveGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DissolveGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "DissolveGroup",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/groups/dissolve`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DissolveGroupResponse>(await this.execute(params, req, runtime), new DissolveGroupResponse({}));
  }

  async dissolveGroup(request: DissolveGroupRequest): Promise<DissolveGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DissolveGroupHeaders({ });
    return await this.dissolveGroupWithOptions(request, headers, runtime);
  }

  async editDeviceAdminWithOptions(request: EditDeviceAdminRequest, headers: EditDeviceAdminHeaders, runtime: $Util.RuntimeOptions): Promise<EditDeviceAdminResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.roleUuid)) {
      body["roleUuid"] = request.roleUuid;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    let params = new $OpenApi.Params({
      action: "EditDeviceAdmin",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/administrators/edit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditDeviceAdminResponse>(await this.execute(params, req, runtime), new EditDeviceAdminResponse({}));
  }

  async editDeviceAdmin(request: EditDeviceAdminRequest): Promise<EditDeviceAdminResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditDeviceAdminHeaders({ });
    return await this.editDeviceAdminWithOptions(request, headers, runtime);
  }

  async getDeviceGroupInfoWithOptions(request: GetDeviceGroupInfoRequest, headers: GetDeviceGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDeviceGroupInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetDeviceGroupInfo",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/groupInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDeviceGroupInfoResponse>(await this.execute(params, req, runtime), new GetDeviceGroupInfoResponse({}));
  }

  async getDeviceGroupInfo(request: GetDeviceGroupInfoRequest): Promise<GetDeviceGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeviceGroupInfoHeaders({ });
    return await this.getDeviceGroupInfoWithOptions(request, headers, runtime);
  }

  async getWholeDeviceGroupWithOptions(headers: GetWholeDeviceGroupHeaders, runtime: $Util.RuntimeOptions): Promise<GetWholeDeviceGroupResponse> {
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
      action: "GetWholeDeviceGroup",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/wholeGroupId`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWholeDeviceGroupResponse>(await this.execute(params, req, runtime), new GetWholeDeviceGroupResponse({}));
  }

  async getWholeDeviceGroup(): Promise<GetWholeDeviceGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWholeDeviceGroupHeaders({ });
    return await this.getWholeDeviceGroupWithOptions(headers, runtime);
  }

  async listActivateDevicesWithOptions(request: ListActivateDevicesRequest, headers: ListActivateDevicesHeaders, runtime: $Util.RuntimeOptions): Promise<ListActivateDevicesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCategory)) {
      query["deviceCategory"] = request.deviceCategory;
    }

    if (!Util.isUnset(request.deviceCode)) {
      query["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceTypeId)) {
      query["deviceTypeId"] = request.deviceTypeId;
    }

    if (!Util.isUnset(request.groupId)) {
      query["groupId"] = request.groupId;
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListActivateDevices",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/activations/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListActivateDevicesResponse>(await this.execute(params, req, runtime), new ListActivateDevicesResponse({}));
  }

  async listActivateDevices(request: ListActivateDevicesRequest): Promise<ListActivateDevicesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListActivateDevicesHeaders({ });
    return await this.listActivateDevicesWithOptions(request, headers, runtime);
  }

  async listInspectInfoWithOptions(request: ListInspectInfoRequest, headers: ListInspectInfoHeaders, runtime: $Util.RuntimeOptions): Promise<ListInspectInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceUuid)) {
      body["deviceUuid"] = request.deviceUuid;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
      action: "ListInspectInfo",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/inspectInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListInspectInfoResponse>(await this.execute(params, req, runtime), new ListInspectInfoResponse({}));
  }

  async listInspectInfo(request: ListInspectInfoRequest): Promise<ListInspectInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListInspectInfoHeaders({ });
    return await this.listInspectInfoWithOptions(request, headers, runtime);
  }

  async listMaintainInfoWithOptions(request: ListMaintainInfoRequest, headers: ListMaintainInfoHeaders, runtime: $Util.RuntimeOptions): Promise<ListMaintainInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceUuid)) {
      body["deviceUuid"] = request.deviceUuid;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
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
      action: "ListMaintainInfo",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/maintainInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListMaintainInfoResponse>(await this.execute(params, req, runtime), new ListMaintainInfoResponse({}));
  }

  async listMaintainInfo(request: ListMaintainInfoRequest): Promise<ListMaintainInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMaintainInfoHeaders({ });
    return await this.listMaintainInfoWithOptions(request, headers, runtime);
  }

  async pullDeviceToGroupWithOptions(request: PullDeviceToGroupRequest, headers: PullDeviceToGroupHeaders, runtime: $Util.RuntimeOptions): Promise<PullDeviceToGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCodes)) {
      body["deviceCodes"] = request.deviceCodes;
    }

    if (!Util.isUnset(request.deviceUuids)) {
      body["deviceUuids"] = request.deviceUuids;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
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
      action: "PullDeviceToGroup",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/devices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PullDeviceToGroupResponse>(await this.execute(params, req, runtime), new PullDeviceToGroupResponse({}));
  }

  async pullDeviceToGroup(request: PullDeviceToGroupRequest): Promise<PullDeviceToGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullDeviceToGroupHeaders({ });
    return await this.pullDeviceToGroupWithOptions(request, headers, runtime);
  }

  async pullUserToGroupWithOptions(request: PullUserToGroupRequest, headers: PullUserToGroupHeaders, runtime: $Util.RuntimeOptions): Promise<PullUserToGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "PullUserToGroup",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/users`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PullUserToGroupResponse>(await this.execute(params, req, runtime), new PullUserToGroupResponse({}));
  }

  async pullUserToGroup(request: PullUserToGroupRequest): Promise<PullUserToGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullUserToGroupHeaders({ });
    return await this.pullUserToGroupWithOptions(request, headers, runtime);
  }

  async registerAndActivateDeviceWithOptions(request: RegisterAndActivateDeviceRequest, headers: RegisterAndActivateDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAndActivateDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCallbackUrl)) {
      body["deviceCallbackUrl"] = request.deviceCallbackUrl;
    }

    if (!Util.isUnset(request.deviceCategory)) {
      body["deviceCategory"] = request.deviceCategory;
    }

    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceDetailUrl)) {
      body["deviceDetailUrl"] = request.deviceDetailUrl;
    }

    if (!Util.isUnset(request.deviceName)) {
      body["deviceName"] = request.deviceName;
    }

    if (!Util.isUnset(request.introduction)) {
      body["introduction"] = request.introduction;
    }

    if (!Util.isUnset(request.roleUuid)) {
      body["roleUuid"] = request.roleUuid;
    }

    if (!Util.isUnset(request.typeUuid)) {
      body["typeUuid"] = request.typeUuid;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "RegisterAndActivateDevice",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/registerAndActivate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterAndActivateDeviceResponse>(await this.execute(params, req, runtime), new RegisterAndActivateDeviceResponse({}));
  }

  async registerAndActivateDevice(request: RegisterAndActivateDeviceRequest): Promise<RegisterAndActivateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAndActivateDeviceHeaders({ });
    return await this.registerAndActivateDeviceWithOptions(request, headers, runtime);
  }

  async registerAndActivateDeviceBatchWithOptions(request: RegisterAndActivateDeviceBatchRequest, headers: RegisterAndActivateDeviceBatchHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAndActivateDeviceBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.registerAndActivateVOS)) {
      body["registerAndActivateVOS"] = request.registerAndActivateVOS;
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
      action: "RegisterAndActivateDeviceBatch",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/registrationActivations/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterAndActivateDeviceBatchResponse>(await this.execute(params, req, runtime), new RegisterAndActivateDeviceBatchResponse({}));
  }

  async registerAndActivateDeviceBatch(request: RegisterAndActivateDeviceBatchRequest): Promise<RegisterAndActivateDeviceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAndActivateDeviceBatchHeaders({ });
    return await this.registerAndActivateDeviceBatchWithOptions(request, headers, runtime);
  }

  async registerDeviceWithOptions(request: RegisterDeviceRequest, headers: RegisterDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.collaborators)) {
      body["collaborators"] = request.collaborators;
    }

    if (!Util.isUnset(request.departmentId)) {
      body["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.deviceKey)) {
      body["deviceKey"] = request.deviceKey;
    }

    if (!Util.isUnset(request.deviceName)) {
      body["deviceName"] = request.deviceName;
    }

    if (!Util.isUnset(request.managers)) {
      body["managers"] = request.managers;
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
      action: "RegisterDevice",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/devices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RegisterDeviceResponse>(await this.execute(params, req, runtime), new RegisterDeviceResponse({}));
  }

  async registerDevice(request: RegisterDeviceRequest): Promise<RegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterDeviceHeaders({ });
    return await this.registerDeviceWithOptions(request, headers, runtime);
  }

  async removeDeviceFromGroupWithOptions(request: RemoveDeviceFromGroupRequest, headers: RemoveDeviceFromGroupHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveDeviceFromGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCodes)) {
      body["deviceCodes"] = request.deviceCodes;
    }

    if (!Util.isUnset(request.deviceUuids)) {
      body["deviceUuids"] = request.deviceUuids;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
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
      action: "RemoveDeviceFromGroup",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/devices/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveDeviceFromGroupResponse>(await this.execute(params, req, runtime), new RemoveDeviceFromGroupResponse({}));
  }

  async removeDeviceFromGroup(request: RemoveDeviceFromGroupRequest): Promise<RemoveDeviceFromGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveDeviceFromGroupHeaders({ });
    return await this.removeDeviceFromGroupWithOptions(request, headers, runtime);
  }

  async removeUserFromGroupWithOptions(request: RemoveUserFromGroupRequest, headers: RemoveUserFromGroupHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveUserFromGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "RemoveUserFromGroup",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/chatRooms/users/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveUserFromGroupResponse>(await this.execute(params, req, runtime), new RemoveUserFromGroupResponse({}));
  }

  async removeUserFromGroup(request: RemoveUserFromGroupRequest): Promise<RemoveUserFromGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveUserFromGroupHeaders({ });
    return await this.removeUserFromGroupWithOptions(request, headers, runtime);
  }

  async sendCardWithOptions(request: SendCardRequest, headers: SendCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceUuid)) {
      body["deviceUuid"] = request.deviceUuid;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.partVisible)) {
      body["partVisible"] = request.partVisible;
    }

    if (!Util.isUnset(request.receivers)) {
      body["receivers"] = request.receivers;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.topbox)) {
      body["topbox"] = request.topbox;
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
      action: "SendCard",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/cards/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendCardResponse>(await this.execute(params, req, runtime), new SendCardResponse({}));
  }

  async sendCard(request: SendCardRequest): Promise<SendCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendCardHeaders({ });
    return await this.sendCardWithOptions(request, headers, runtime);
  }

  async sendMsgWithOptions(request: SendMsgRequest, headers: SendMsgHeaders, runtime: $Util.RuntimeOptions): Promise<SendMsgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceUuid)) {
      body["deviceUuid"] = request.deviceUuid;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userList)) {
      body["userList"] = request.userList;
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
      action: "SendMsg",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMsgResponse>(await this.execute(params, req, runtime), new SendMsgResponse({}));
  }

  async sendMsg(request: SendMsgRequest): Promise<SendMsgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMsgHeaders({ });
    return await this.sendMsgWithOptions(request, headers, runtime);
  }

  async uninstallDeviceRobotWithOptions(request: UninstallDeviceRobotRequest, headers: UninstallDeviceRobotHeaders, runtime: $Util.RuntimeOptions): Promise<UninstallDeviceRobotResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
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
    let params = new $OpenApi.Params({
      action: "UninstallDeviceRobot",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/devices/uninstall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UninstallDeviceRobotResponse>(await this.execute(params, req, runtime), new UninstallDeviceRobotResponse({}));
  }

  async uninstallDeviceRobot(request: UninstallDeviceRobotRequest): Promise<UninstallDeviceRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UninstallDeviceRobotHeaders({ });
    return await this.uninstallDeviceRobotWithOptions(request, headers, runtime);
  }

  async updateCardWithOptions(request: UpdateCardRequest, headers: UpdateCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.tips)) {
      body["tips"] = request.tips;
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
      action: "UpdateCard",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/customers/cards`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCardResponse>(await this.execute(params, req, runtime), new UpdateCardResponse({}));
  }

  async updateCard(request: UpdateCardRequest): Promise<UpdateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCardHeaders({ });
    return await this.updateCardWithOptions(request, headers, runtime);
  }

  async uploadEventWithOptions(request: UploadEventRequest, headers: UploadEventHeaders, runtime: $Util.RuntimeOptions): Promise<UploadEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.coverUrl)) {
      body["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceUuid)) {
      body["deviceUuid"] = request.deviceUuid;
    }

    if (!Util.isUnset(request.eventTime)) {
      body["eventTime"] = request.eventTime;
    }

    if (!Util.isUnset(request.eventType)) {
      body["eventType"] = request.eventType;
    }

    if (!Util.isUnset(request.level)) {
      body["level"] = request.level;
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
      action: "UploadEvent",
      version: "devicemng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/devicemng/suppliers/events/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadEventResponse>(await this.execute(params, req, runtime), new UploadEventResponse({}));
  }

  async uploadEvent(request: UploadEventRequest): Promise<UploadEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadEventHeaders({ });
    return await this.uploadEventWithOptions(request, headers, runtime);
  }

}
