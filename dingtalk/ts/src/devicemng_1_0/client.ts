// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  dingCorpId?: string;
  deviceKey?: string;
  deviceName?: string;
  departmentId?: number;
  managers?: string;
  collaborators?: string;
  description?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      deviceKey: 'deviceKey',
      deviceName: 'deviceName',
      departmentId: 'departmentId',
      managers: 'managers',
      collaborators: 'collaborators',
      description: 'description',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      deviceKey: 'string',
      deviceName: 'string',
      departmentId: 'number',
      managers: 'string',
      collaborators: 'string',
      description: 'string',
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
  dingCorpId?: string;
  registerAndActivateVOS?: RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS[];
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      registerAndActivateVOS: 'registerAndActivateVOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      registerAndActivateVOS: { 'type': 'array', 'itemType': RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceBatchResponseBody extends $tea.Model {
  successItems?: RegisterAndActivateDeviceBatchResponseBodySuccessItems[];
  success?: boolean;
  failItems?: RegisterAndActivateDeviceBatchResponseBodyFailItems[];
  static names(): { [key: string]: string } {
    return {
      successItems: 'successItems',
      success: 'success',
      failItems: 'failItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      successItems: { 'type': 'array', 'itemType': RegisterAndActivateDeviceBatchResponseBodySuccessItems },
      success: 'boolean',
      failItems: { 'type': 'array', 'itemType': RegisterAndActivateDeviceBatchResponseBodyFailItems },
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
  dingCorpId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceList: 'deviceList',
      dingCorpId: 'dingCorpId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceList: { 'type': 'array', 'itemType': BatchRegisterDeviceRequestDeviceList },
      dingCorpId: 'string',
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
  deviceCode?: string;
  deviceName?: string;
  introduction?: string;
  typeUuid?: string;
  dingCorpId?: string;
  userIds?: string[];
  roleUuid?: string;
  deviceDetailUrl?: string;
  deviceCallbackUrl?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
      introduction: 'introduction',
      typeUuid: 'typeUuid',
      dingCorpId: 'dingCorpId',
      userIds: 'userIds',
      roleUuid: 'roleUuid',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceCallbackUrl: 'deviceCallbackUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      deviceName: 'string',
      introduction: 'string',
      typeUuid: 'string',
      dingCorpId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      roleUuid: 'string',
      deviceDetailUrl: 'string',
      deviceCallbackUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceResponseBody extends $tea.Model {
  success?: boolean;
  result?: RegisterAndActivateDeviceResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: RegisterAndActivateDeviceResponseBodyResult,
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
  deviceTypeId?: string;
  pageNumber?: number;
  groupId?: string;
  pageSize?: number;
  deviceCode?: string;
  static names(): { [key: string]: string } {
    return {
      deviceTypeId: 'deviceTypeId',
      pageNumber: 'pageNumber',
      groupId: 'groupId',
      pageSize: 'pageSize',
      deviceCode: 'deviceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceTypeId: 'string',
      pageNumber: 'number',
      groupId: 'string',
      pageSize: 'number',
      deviceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivateDevicesResponseBody extends $tea.Model {
  totalCount?: number;
  success?: boolean;
  result?: ListActivateDevicesResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      success: 'boolean',
      result: { 'type': 'array', 'itemType': ListActivateDevicesResponseBodyResult },
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
  dingCorpId?: string;
  paramsJson?: string;
  deviceKey?: string;
  receiverUserIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      paramsJson: 'paramsJson',
      deviceKey: 'deviceKey',
      receiverUserIdList: 'receiverUserIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      paramsJson: 'string',
      deviceKey: 'string',
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
  dingCorpId?: string;
  departmentName?: string;
  departmentType?: string;
  systemUrl?: string;
  authType?: string;
  authInfo?: string;
  description?: string;
  bizExt?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      departmentName: 'departmentName',
      departmentType: 'departmentType',
      systemUrl: 'systemUrl',
      authType: 'authType',
      authInfo: 'authInfo',
      description: 'description',
      bizExt: 'bizExt',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      departmentName: 'string',
      departmentType: 'string',
      systemUrl: 'string',
      authType: 'string',
      authInfo: 'string',
      description: 'string',
      bizExt: 'string',
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
  deviceUuid?: string;
  content?: string;
  dingCorpId?: string;
  deviceCode?: string;
  level?: string;
  eventTime?: string;
  eventType?: string;
  static names(): { [key: string]: string } {
    return {
      deviceUuid: 'deviceUuid',
      content: 'content',
      dingCorpId: 'dingCorpId',
      deviceCode: 'deviceCode',
      level: 'level',
      eventTime: 'eventTime',
      eventType: 'eventType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceUuid: 'string',
      content: 'string',
      dingCorpId: 'string',
      deviceCode: 'string',
      level: 'string',
      eventTime: 'string',
      eventType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadEventResponseBody extends $tea.Model {
  success?: boolean;
  result?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'string',
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
  dingCorpId?: string;
  deviceCodes?: string[];
  deviceTypeId?: string;
  roleList?: string[];
  ownerUserId?: string;
  static names(): { [key: string]: string } {
    return {
      chatGroupName: 'chatGroupName',
      dingCorpId: 'dingCorpId',
      deviceCodes: 'deviceCodes',
      deviceTypeId: 'deviceTypeId',
      roleList: 'roleList',
      ownerUserId: 'ownerUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatGroupName: 'string',
      dingCorpId: 'string',
      deviceCodes: { 'type': 'array', 'itemType': 'string' },
      deviceTypeId: 'string',
      roleList: { 'type': 'array', 'itemType': 'string' },
      ownerUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateChatRoomResponseBody extends $tea.Model {
  success?: boolean;
  result?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'string',
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

export class RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS extends $tea.Model {
  deviceCode?: string;
  deviceDetailUrl?: string;
  deviceCallbackUrl?: string;
  deviceName?: string;
  groupUuid?: string;
  introduction?: string;
  roleUuid?: string;
  typeUuid?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceDetailUrl: 'deviceDetailUrl',
      deviceCallbackUrl: 'deviceCallbackUrl',
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
      deviceCode: 'string',
      deviceDetailUrl: 'string',
      deviceCallbackUrl: 'string',
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
  userIds?: string[];
  status?: number;
  typeUuid?: string;
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
      userIds: 'userIds',
      status: 'status',
      typeUuid: 'typeUuid',
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
      userIds: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
      typeUuid: 'string',
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
  userIds?: string[];
  status?: number;
  typeUuid?: string;
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
      userIds: 'userIds',
      status: 'status',
      typeUuid: 'typeUuid',
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
      userIds: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
      typeUuid: 'string',
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

export class BatchRegisterDeviceRequestDeviceList extends $tea.Model {
  deviceKey?: string;
  deviceName?: string;
  departmentId?: number;
  managers?: string;
  collaborators?: string;
  description?: string;
  static names(): { [key: string]: string } {
    return {
      deviceKey: 'deviceKey',
      deviceName: 'deviceName',
      departmentId: 'departmentId',
      managers: 'managers',
      collaborators: 'collaborators',
      description: 'description',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceKey: 'string',
      deviceName: 'string',
      departmentId: 'number',
      managers: 'string',
      collaborators: 'string',
      description: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAndActivateDeviceResponseBodyResult extends $tea.Model {
  deviceCode?: string;
  deviceUuid?: string;
  deviceName?: string;
  introduction?: string;
  typeUuid?: string;
  corpId?: string;
  roleUuid?: string;
  deviceDetailUrl?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      deviceUuid: 'deviceUuid',
      deviceName: 'deviceName',
      introduction: 'introduction',
      typeUuid: 'typeUuid',
      corpId: 'corpId',
      roleUuid: 'roleUuid',
      deviceDetailUrl: 'deviceDetailUrl',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      deviceUuid: 'string',
      deviceName: 'string',
      introduction: 'string',
      typeUuid: 'string',
      corpId: 'string',
      roleUuid: 'string',
      deviceDetailUrl: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async registerDevice(request: RegisterDeviceRequest): Promise<RegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterDeviceHeaders({ });
    return await this.registerDeviceWithOptions(request, headers, runtime);
  }

  async registerDeviceWithOptions(request: RegisterDeviceRequest, headers: RegisterDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.deviceKey)) {
      body["deviceKey"] = request.deviceKey;
    }

    if (!Util.isUnset(request.deviceName)) {
      body["deviceName"] = request.deviceName;
    }

    if (!Util.isUnset(request.departmentId)) {
      body["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.managers)) {
      body["managers"] = request.managers;
    }

    if (!Util.isUnset(request.collaborators)) {
      body["collaborators"] = request.collaborators;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
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
    return $tea.cast<RegisterDeviceResponse>(await this.doROARequest("RegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/devices`, "json", req, runtime), new RegisterDeviceResponse({}));
  }

  async registerAndActivateDeviceBatch(request: RegisterAndActivateDeviceBatchRequest): Promise<RegisterAndActivateDeviceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAndActivateDeviceBatchHeaders({ });
    return await this.registerAndActivateDeviceBatchWithOptions(request, headers, runtime);
  }

  async registerAndActivateDeviceBatchWithOptions(request: RegisterAndActivateDeviceBatchRequest, headers: RegisterAndActivateDeviceBatchHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAndActivateDeviceBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.registerAndActivateVOS)) {
      body["registerAndActivateVOS"] = request.registerAndActivateVOS;
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
    return $tea.cast<RegisterAndActivateDeviceBatchResponse>(await this.doROARequest("RegisterAndActivateDeviceBatch", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/customers/devices/registrationActivations/batch`, "json", req, runtime), new RegisterAndActivateDeviceBatchResponse({}));
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

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
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
    return $tea.cast<BatchRegisterDeviceResponse>(await this.doROARequest("BatchRegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/devices/batch`, "json", req, runtime), new BatchRegisterDeviceResponse({}));
  }

  async registerAndActivateDevice(request: RegisterAndActivateDeviceRequest): Promise<RegisterAndActivateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAndActivateDeviceHeaders({ });
    return await this.registerAndActivateDeviceWithOptions(request, headers, runtime);
  }

  async registerAndActivateDeviceWithOptions(request: RegisterAndActivateDeviceRequest, headers: RegisterAndActivateDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAndActivateDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceName)) {
      body["deviceName"] = request.deviceName;
    }

    if (!Util.isUnset(request.introduction)) {
      body["introduction"] = request.introduction;
    }

    if (!Util.isUnset(request.typeUuid)) {
      body["typeUuid"] = request.typeUuid;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.roleUuid)) {
      body["roleUuid"] = request.roleUuid;
    }

    if (!Util.isUnset(request.deviceDetailUrl)) {
      body["deviceDetailUrl"] = request.deviceDetailUrl;
    }

    if (!Util.isUnset(request.deviceCallbackUrl)) {
      body["deviceCallbackUrl"] = request.deviceCallbackUrl;
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
    return $tea.cast<RegisterAndActivateDeviceResponse>(await this.doROARequest("RegisterAndActivateDevice", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/customers/devices/registerAndActivate`, "json", req, runtime), new RegisterAndActivateDeviceResponse({}));
  }

  async listActivateDevices(request: ListActivateDevicesRequest): Promise<ListActivateDevicesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListActivateDevicesHeaders({ });
    return await this.listActivateDevicesWithOptions(request, headers, runtime);
  }

  async listActivateDevicesWithOptions(request: ListActivateDevicesRequest, headers: ListActivateDevicesHeaders, runtime: $Util.RuntimeOptions): Promise<ListActivateDevicesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceTypeId)) {
      query["deviceTypeId"] = request.deviceTypeId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.groupId)) {
      query["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.deviceCode)) {
      query["deviceCode"] = request.deviceCode;
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
    return $tea.cast<ListActivateDevicesResponse>(await this.doROARequest("ListActivateDevices", "devicemng_1.0", "HTTP", "GET", "AK", `/v1.0/devicemng/customers/devices/activations/infos`, "json", req, runtime), new ListActivateDevicesResponse({}));
  }

  async deviceDing(request: DeviceDingRequest): Promise<DeviceDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceDingHeaders({ });
    return await this.deviceDingWithOptions(request, headers, runtime);
  }

  async deviceDingWithOptions(request: DeviceDingRequest, headers: DeviceDingHeaders, runtime: $Util.RuntimeOptions): Promise<DeviceDingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.paramsJson)) {
      body["paramsJson"] = request.paramsJson;
    }

    if (!Util.isUnset(request.deviceKey)) {
      body["deviceKey"] = request.deviceKey;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
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
    return $tea.cast<DeviceDingResponse>(await this.doROARequest("DeviceDing", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/ding`, "json", req, runtime), new DeviceDingResponse({}));
  }

  async createDepartment(request: CreateDepartmentRequest): Promise<CreateDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDepartmentHeaders({ });
    return await this.createDepartmentWithOptions(request, headers, runtime);
  }

  async createDepartmentWithOptions(request: CreateDepartmentRequest, headers: CreateDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDepartmentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.departmentName)) {
      body["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.departmentType)) {
      body["departmentType"] = request.departmentType;
    }

    if (!Util.isUnset(request.systemUrl)) {
      body["systemUrl"] = request.systemUrl;
    }

    if (!Util.isUnset(request.authType)) {
      body["authType"] = request.authType;
    }

    if (!Util.isUnset(request.authInfo)) {
      body["authInfo"] = request.authInfo;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.bizExt)) {
      body["bizExt"] = request.bizExt;
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
    return $tea.cast<CreateDepartmentResponse>(await this.doROARequest("CreateDepartment", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/departments`, "json", req, runtime), new CreateDepartmentResponse({}));
  }

  async uploadEvent(request: UploadEventRequest): Promise<UploadEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadEventHeaders({ });
    return await this.uploadEventWithOptions(request, headers, runtime);
  }

  async uploadEventWithOptions(request: UploadEventRequest, headers: UploadEventHeaders, runtime: $Util.RuntimeOptions): Promise<UploadEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceUuid)) {
      body["deviceUuid"] = request.deviceUuid;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.deviceCode)) {
      body["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.level)) {
      body["level"] = request.level;
    }

    if (!Util.isUnset(request.eventTime)) {
      body["eventTime"] = request.eventTime;
    }

    if (!Util.isUnset(request.eventType)) {
      body["eventType"] = request.eventType;
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
    return $tea.cast<UploadEventResponse>(await this.doROARequest("UploadEvent", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/suppliers/events/upload`, "json", req, runtime), new UploadEventResponse({}));
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

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.deviceCodes)) {
      body["deviceCodes"] = request.deviceCodes;
    }

    if (!Util.isUnset(request.deviceTypeId)) {
      body["deviceTypeId"] = request.deviceTypeId;
    }

    if (!Util.isUnset(request.roleList)) {
      body["roleList"] = request.roleList;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
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
    return $tea.cast<CreateChatRoomResponse>(await this.doROARequest("CreateChatRoom", "devicemng_1.0", "HTTP", "POST", "AK", `/v1.0/devicemng/customers/chatRoom`, "json", req, runtime), new CreateChatRoomResponse({}));
  }

}
