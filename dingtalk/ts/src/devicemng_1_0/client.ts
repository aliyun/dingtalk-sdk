// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  body: BatchRegisterDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchRegisterDeviceResponseBody,
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
  body: CreateChatRoomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: CreateDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateDepartmentResponseBody,
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
  body: DeviceDingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeviceDingResponseBody,
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
  deviceCode?: string;
  deviceTypeId?: string;
  groupId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceTypeId: 'deviceTypeId',
      groupId: 'groupId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  body: ListActivateDevicesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListActivateDevicesResponseBody,
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
  body: RegisterAndActivateDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: RegisterAndActivateDeviceBatchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: RegisterDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RegisterDeviceResponseBody,
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
  body: UploadEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class ListActivateDevicesResponseBodyResult extends $tea.Model {
  bizExt?: string;
  corpId?: string;
  deviceCallbackUrl?: string;
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
      corpId: 'corpId',
      deviceCallbackUrl: 'deviceCallbackUrl',
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
      corpId: 'string',
      deviceCallbackUrl: 'string',
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

export class RegisterAndActivateDeviceResponseBodyResult extends $tea.Model {
  corpId?: string;
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
      corpId: 'corpId',
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
      corpId: 'string',
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
  corpId?: string;
  deviceCallbackUrl?: string;
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
      corpId: 'corpId',
      deviceCallbackUrl: 'deviceCallbackUrl',
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
      corpId: 'string',
      deviceCallbackUrl: 'string',
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
  corpId?: string;
  deviceCallbackUrl?: string;
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
      corpId: 'corpId',
      deviceCallbackUrl: 'deviceCallbackUrl',
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
      corpId: 'string',
      deviceCallbackUrl: 'string',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async batchRegisterDevice(request: BatchRegisterDeviceRequest): Promise<BatchRegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRegisterDeviceHeaders({ });
    return await this.batchRegisterDeviceWithOptions(request, headers, runtime);
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
    return $tea.cast<BatchRegisterDeviceResponse>(await this.doROARequest("BatchRegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/devices/batch`, "json", req, runtime), new BatchRegisterDeviceResponse({}));
  }

  async createChatRoom(request: CreateChatRoomRequest): Promise<CreateChatRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateChatRoomHeaders({ });
    return await this.createChatRoomWithOptions(request, headers, runtime);
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
    return $tea.cast<CreateChatRoomResponse>(await this.doROARequest("CreateChatRoom", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/customers/chatRoom`, "json", req, runtime), new CreateChatRoomResponse({}));
  }

  async createDepartment(request: CreateDepartmentRequest): Promise<CreateDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDepartmentHeaders({ });
    return await this.createDepartmentWithOptions(request, headers, runtime);
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
    return $tea.cast<CreateDepartmentResponse>(await this.doROARequest("CreateDepartment", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/departments`, "json", req, runtime), new CreateDepartmentResponse({}));
  }

  async deviceDing(request: DeviceDingRequest): Promise<DeviceDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceDingHeaders({ });
    return await this.deviceDingWithOptions(request, headers, runtime);
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
    return $tea.cast<DeviceDingResponse>(await this.doROARequest("DeviceDing", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/ding`, "json", req, runtime), new DeviceDingResponse({}));
  }

  async listActivateDevices(request: ListActivateDevicesRequest): Promise<ListActivateDevicesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListActivateDevicesHeaders({ });
    return await this.listActivateDevicesWithOptions(request, headers, runtime);
  }

  async listActivateDevicesWithOptions(request: ListActivateDevicesRequest, headers: ListActivateDevicesHeaders, runtime: $Util.RuntimeOptions): Promise<ListActivateDevicesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<ListActivateDevicesResponse>(await this.doROARequest("ListActivateDevices", "devicemng_1.0", "HTTP", "GET", "AK", `/v1.0/devicemng/customers/devices/activations/infos`, "json", req, runtime), new ListActivateDevicesResponse({}));
  }

  async registerAndActivateDevice(request: RegisterAndActivateDeviceRequest): Promise<RegisterAndActivateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAndActivateDeviceHeaders({ });
    return await this.registerAndActivateDeviceWithOptions(request, headers, runtime);
  }

  async registerAndActivateDeviceWithOptions(request: RegisterAndActivateDeviceRequest, headers: RegisterAndActivateDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAndActivateDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCallbackUrl)) {
      body["deviceCallbackUrl"] = request.deviceCallbackUrl;
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
    return $tea.cast<RegisterAndActivateDeviceResponse>(await this.doROARequest("RegisterAndActivateDevice", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/customers/devices/registerAndActivate`, "json", req, runtime), new RegisterAndActivateDeviceResponse({}));
  }

  async registerAndActivateDeviceBatch(request: RegisterAndActivateDeviceBatchRequest): Promise<RegisterAndActivateDeviceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAndActivateDeviceBatchHeaders({ });
    return await this.registerAndActivateDeviceBatchWithOptions(request, headers, runtime);
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
    return $tea.cast<RegisterAndActivateDeviceBatchResponse>(await this.doROARequest("RegisterAndActivateDeviceBatch", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/customers/devices/registrationActivations/batch`, "json", req, runtime), new RegisterAndActivateDeviceBatchResponse({}));
  }

  async registerDevice(request: RegisterDeviceRequest): Promise<RegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterDeviceHeaders({ });
    return await this.registerDeviceWithOptions(request, headers, runtime);
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
    return $tea.cast<RegisterDeviceResponse>(await this.doROARequest("RegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/devices`, "json", req, runtime), new RegisterDeviceResponse({}));
  }

  async uploadEvent(request: UploadEventRequest): Promise<UploadEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadEventHeaders({ });
    return await this.uploadEventWithOptions(request, headers, runtime);
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
    return $tea.cast<UploadEventResponse>(await this.doROARequest("UploadEvent", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/suppliers/events/upload`, "json", req, runtime), new UploadEventResponse({}));
  }

}
