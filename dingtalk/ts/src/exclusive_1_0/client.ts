// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddOrgHeaders extends $tea.Model {
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

export class AddOrgRequest extends $tea.Model {
  mobileNum?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      mobileNum: 'mobileNum',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileNum: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOrgResponseBody extends $tea.Model {
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddOrgResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BanOrOpenGroupWordsHeaders extends $tea.Model {
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

export class BanOrOpenGroupWordsRequest extends $tea.Model {
  banWordsType?: number;
  openConverationId?: string;
  static names(): { [key: string]: string } {
    return {
      banWordsType: 'banWordsType',
      openConverationId: 'openConverationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      banWordsType: 'number',
      openConverationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BanOrOpenGroupWordsResponseBody extends $tea.Model {
  cause?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BanOrOpenGroupWordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BanOrOpenGroupWordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BanOrOpenGroupWordsResponseBody,
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
  did?: string;
  macAddress?: string;
  platform?: string;
  status?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      did: 'did',
      macAddress: 'macAddress',
      platform: 'platform',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      did: 'string',
      macAddress: 'string',
      platform: 'string',
      status: 'number',
      userId: 'string',
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

export class CreateTrustedDeviceBatchHeaders extends $tea.Model {
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

export class CreateTrustedDeviceBatchRequest extends $tea.Model {
  macAddressList?: string[];
  platform?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      macAddressList: 'macAddressList',
      platform: 'platform',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      macAddressList: { 'type': 'array', 'itemType': 'string' },
      platform: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustedDeviceBatchResponseBody extends $tea.Model {
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

export class CreateTrustedDeviceBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTrustedDeviceBatchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTrustedDeviceBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAcrossCloudStroageConfigsHeaders extends $tea.Model {
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

export class DeleteAcrossCloudStroageConfigsResponseBody extends $tea.Model {
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

export class DeleteAcrossCloudStroageConfigsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteAcrossCloudStroageConfigsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteAcrossCloudStroageConfigsResponseBody,
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

export class DistributePartnerAppHeaders extends $tea.Model {
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

export class DistributePartnerAppRequest extends $tea.Model {
  appId?: number;
  deptId?: number;
  subCorpId?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      deptId: 'deptId',
      subCorpId: 'subCorpId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      deptId: 'number',
      subCorpId: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DistributePartnerAppResponseBody extends $tea.Model {
  inviteUrl?: string;
  static names(): { [key: string]: string } {
    return {
      inviteUrl: 'inviteUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DistributePartnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DistributePartnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DistributePartnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExclusiveCreateDingPortalHeaders extends $tea.Model {
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

export class ExclusiveCreateDingPortalRequest extends $tea.Model {
  dingPortalName?: string;
  targetCorpId?: string;
  templateAppUuid?: string;
  templateCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      dingPortalName: 'dingPortalName',
      targetCorpId: 'targetCorpId',
      templateAppUuid: 'templateAppUuid',
      templateCorpId: 'templateCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingPortalName: 'string',
      targetCorpId: 'string',
      templateAppUuid: 'string',
      templateCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExclusiveCreateDingPortalResponseBody extends $tea.Model {
  success?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExclusiveCreateDingPortalResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExclusiveCreateDingPortalResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExclusiveCreateDingPortalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageActiveStorageHeaders extends $tea.Model {
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

export class FileStorageActiveStorageRequest extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  oss?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      oss: 'oss',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      oss: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageActiveStorageResponseBody extends $tea.Model {
  createDate?: string;
  fileStorageOpenStatus?: number;
  storageStatus?: number;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createDate: 'createDate',
      fileStorageOpenStatus: 'fileStorageOpenStatus',
      storageStatus: 'storageStatus',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createDate: 'string',
      fileStorageOpenStatus: 'number',
      storageStatus: 'number',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageActiveStorageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: FileStorageActiveStorageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: FileStorageActiveStorageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageCheckConnectionHeaders extends $tea.Model {
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

export class FileStorageCheckConnectionRequest extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  oss?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      oss: 'oss',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      oss: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageCheckConnectionResponseBody extends $tea.Model {
  accessKeyId?: string;
  checkState?: number;
  oss?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      checkState: 'checkState',
      oss: 'oss',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      checkState: 'number',
      oss: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageCheckConnectionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: FileStorageCheckConnectionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: FileStorageCheckConnectionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetQuotaDataHeaders extends $tea.Model {
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

export class FileStorageGetQuotaDataRequest extends $tea.Model {
  endTime?: string;
  startTime?: string;
  targetCorpId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      targetCorpId: 'targetCorpId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      startTime: 'string',
      targetCorpId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetQuotaDataResponseBody extends $tea.Model {
  quotaModelList?: FileStorageGetQuotaDataResponseBodyQuotaModelList[];
  static names(): { [key: string]: string } {
    return {
      quotaModelList: 'quotaModelList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      quotaModelList: { 'type': 'array', 'itemType': FileStorageGetQuotaDataResponseBodyQuotaModelList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetQuotaDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: FileStorageGetQuotaDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: FileStorageGetQuotaDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetStorageStateHeaders extends $tea.Model {
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

export class FileStorageGetStorageStateRequest extends $tea.Model {
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetStorageStateResponseBody extends $tea.Model {
  accessKeyId?: string;
  createDate?: string;
  fileStorageOpenStatus?: number;
  oss?: string;
  storageStatus?: number;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      createDate: 'createDate',
      fileStorageOpenStatus: 'fileStorageOpenStatus',
      oss: 'oss',
      storageStatus: 'storageStatus',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      createDate: 'string',
      fileStorageOpenStatus: 'number',
      oss: 'string',
      storageStatus: 'number',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetStorageStateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: FileStorageGetStorageStateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: FileStorageGetStorageStateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageUpdateStorageHeaders extends $tea.Model {
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

export class FileStorageUpdateStorageRequest extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageUpdateStorageResponseBody extends $tea.Model {
  accessKeyId?: string;
  oss?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      oss: 'oss',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      oss: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageUpdateStorageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: FileStorageUpdateStorageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: FileStorageUpdateStorageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateDarkWaterMarkHeaders extends $tea.Model {
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

export class GenerateDarkWaterMarkRequest extends $tea.Model {
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateDarkWaterMarkResponseBody extends $tea.Model {
  darkWatermarkVOList?: GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList[];
  static names(): { [key: string]: string } {
    return {
      darkWatermarkVOList: 'darkWatermarkVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      darkWatermarkVOList: { 'type': 'array', 'itemType': GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateDarkWaterMarkResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GenerateDarkWaterMarkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GenerateDarkWaterMarkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActiveUserSummaryHeaders extends $tea.Model {
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

export class GetActiveUserSummaryResponseBody extends $tea.Model {
  actUsrCnt1m?: string;
  static names(): { [key: string]: string } {
    return {
      actUsrCnt1m: 'actUsrCnt1m',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actUsrCnt1m: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActiveUserSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetActiveUserSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetActiveUserSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAgentIdByRelatedAppIdHeaders extends $tea.Model {
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

export class GetAgentIdByRelatedAppIdRequest extends $tea.Model {
  appId?: number;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAgentIdByRelatedAppIdResponseBody extends $tea.Model {
  agentId?: number;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAgentIdByRelatedAppIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAgentIdByRelatedAppIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAgentIdByRelatedAppIdResponseBody,
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

export class GetAppDispatchInfoHeaders extends $tea.Model {
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

export class GetAppDispatchInfoRequest extends $tea.Model {
  endTime?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponseBody extends $tea.Model {
  android?: GetAppDispatchInfoResponseBodyAndroid[];
  iOS?: GetAppDispatchInfoResponseBodyIOS[];
  mac?: GetAppDispatchInfoResponseBodyMac[];
  windows?: GetAppDispatchInfoResponseBodyWindows[];
  static names(): { [key: string]: string } {
    return {
      android: 'android',
      iOS: 'iOS',
      mac: 'mac',
      windows: 'windows',
    };
  }

  static types(): { [key: string]: any } {
    return {
      android: { 'type': 'array', 'itemType': GetAppDispatchInfoResponseBodyAndroid },
      iOS: { 'type': 'array', 'itemType': GetAppDispatchInfoResponseBodyIOS },
      mac: { 'type': 'array', 'itemType': GetAppDispatchInfoResponseBodyMac },
      windows: { 'type': 'array', 'itemType': GetAppDispatchInfoResponseBodyWindows },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAppDispatchInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAppDispatchInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCalenderSummaryHeaders extends $tea.Model {
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

export class GetCalenderSummaryResponseBody extends $tea.Model {
  calendarCreateUserCnt?: string;
  recvCalendarUserCnt1d?: string;
  useCalendarUserCnt1d?: string;
  static names(): { [key: string]: string } {
    return {
      calendarCreateUserCnt: 'calendarCreateUserCnt',
      recvCalendarUserCnt1d: 'recvCalendarUserCnt1d',
      useCalendarUserCnt1d: 'useCalendarUserCnt1d',
    };
  }

  static types(): { [key: string]: any } {
    return {
      calendarCreateUserCnt: 'string',
      recvCalendarUserCnt1d: 'string',
      useCalendarUserCnt1d: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCalenderSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCalenderSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCalenderSummaryResponseBody,
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

export class GetConfBaseInfoByLogicalIdHeaders extends $tea.Model {
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

export class GetConfBaseInfoByLogicalIdRequest extends $tea.Model {
  logicalConferenceId?: string;
  static names(): { [key: string]: string } {
    return {
      logicalConferenceId: 'logicalConferenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      logicalConferenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfBaseInfoByLogicalIdResponseBody extends $tea.Model {
  conferenceId?: string;
  logicalConferenceId?: string;
  nickname?: string;
  startTime?: number;
  title?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      logicalConferenceId: 'logicalConferenceId',
      nickname: 'nickname',
      startTime: 'startTime',
      title: 'title',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      logicalConferenceId: 'string',
      nickname: 'string',
      startTime: 'number',
      title: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfBaseInfoByLogicalIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetConfBaseInfoByLogicalIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetConfBaseInfoByLogicalIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  attendeeNum?: number;
  attendeePercentage?: string;
  callerId?: string;
  callerName?: string;
  confStartTime?: number;
  conferenceId?: string;
  duration?: number;
  memberList?: GetConferenceDetailResponseBodyMemberList[];
  title?: string;
  totalNum?: number;
  static names(): { [key: string]: string } {
    return {
      attendeeNum: 'attendeeNum',
      attendeePercentage: 'attendeePercentage',
      callerId: 'callerId',
      callerName: 'callerName',
      confStartTime: 'confStartTime',
      conferenceId: 'conferenceId',
      duration: 'duration',
      memberList: 'memberList',
      title: 'title',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendeeNum: 'number',
      attendeePercentage: 'string',
      callerId: 'string',
      callerName: 'string',
      confStartTime: 'number',
      conferenceId: 'string',
      duration: 'number',
      memberList: { 'type': 'array', 'itemType': GetConferenceDetailResponseBodyMemberList },
      title: 'string',
      totalNum: 'number',
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

export class GetDingReportDeptSummaryHeaders extends $tea.Model {
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

export class GetDingReportDeptSummaryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingReportDeptSummaryResponseBody extends $tea.Model {
  data?: GetDingReportDeptSummaryResponseBodyData[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetDingReportDeptSummaryResponseBodyData },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingReportDeptSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDingReportDeptSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDingReportDeptSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingReportSummaryHeaders extends $tea.Model {
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

export class GetDingReportSummaryResponseBody extends $tea.Model {
  reportCommentUserCnt1d?: string;
  static names(): { [key: string]: string } {
    return {
      reportCommentUserCnt1d: 'reportCommentUserCnt1d',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reportCommentUserCnt1d: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingReportSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDingReportSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDingReportSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocCreatedDeptSummaryHeaders extends $tea.Model {
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

export class GetDocCreatedDeptSummaryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocCreatedDeptSummaryResponseBody extends $tea.Model {
  data?: GetDocCreatedDeptSummaryResponseBodyData[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetDocCreatedDeptSummaryResponseBodyData },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocCreatedDeptSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDocCreatedDeptSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDocCreatedDeptSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocCreatedSummaryHeaders extends $tea.Model {
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

export class GetDocCreatedSummaryResponseBody extends $tea.Model {
  docCreateUserCnt1d?: string;
  docCreatedCnt?: string;
  static names(): { [key: string]: string } {
    return {
      docCreateUserCnt1d: 'docCreateUserCnt1d',
      docCreatedCnt: 'docCreatedCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docCreateUserCnt1d: 'string',
      docCreatedCnt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocCreatedSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDocCreatedSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDocCreatedSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGeneralFormCreatedDeptSummaryHeaders extends $tea.Model {
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

export class GetGeneralFormCreatedDeptSummaryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGeneralFormCreatedDeptSummaryResponseBody extends $tea.Model {
  data?: GetGeneralFormCreatedDeptSummaryResponseBodyData[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetGeneralFormCreatedDeptSummaryResponseBodyData },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGeneralFormCreatedDeptSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetGeneralFormCreatedDeptSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetGeneralFormCreatedDeptSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGeneralFormCreatedSummaryHeaders extends $tea.Model {
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

export class GetGeneralFormCreatedSummaryResponseBody extends $tea.Model {
  generalFormCreatedCnt?: string;
  useGeneralFormUserCnt1d?: string;
  static names(): { [key: string]: string } {
    return {
      generalFormCreatedCnt: 'generalFormCreatedCnt',
      useGeneralFormUserCnt1d: 'useGeneralFormUserCnt1d',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generalFormCreatedCnt: 'string',
      useGeneralFormUserCnt1d: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGeneralFormCreatedSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetGeneralFormCreatedSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetGeneralFormCreatedSummaryResponseBody,
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
  dingGroupId?: string;
  groupType?: number;
  pageNumber?: number;
  pageSize?: number;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      dingGroupId: 'dingGroupId',
      groupType: 'groupType',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingGroupId: 'string',
      groupType: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      statDate: 'string',
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

export class GetInActiveUserListHeaders extends $tea.Model {
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

export class GetInActiveUserListRequest extends $tea.Model {
  deptIds?: string[];
  pageNumber?: number;
  pageSize?: number;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'string' },
      pageNumber: 'number',
      pageSize: 'number',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInActiveUserListResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: GetInActiveUserListResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': GetInActiveUserListResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInActiveUserListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInActiveUserListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInActiveUserListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLastOrgAuthDataHeaders extends $tea.Model {
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

export class GetLastOrgAuthDataRequest extends $tea.Model {
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLastOrgAuthDataResponseBody extends $tea.Model {
  authRemark?: string;
  authStatus?: number;
  static names(): { [key: string]: string } {
    return {
      authRemark: 'authRemark',
      authStatus: 'authStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authRemark: 'string',
      authStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLastOrgAuthDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetLastOrgAuthDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLastOrgAuthDataResponseBody,
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
  categoryList?: string[];
  endTime?: number;
  opUserId?: string;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      categoryList: 'categoryList',
      endTime: 'endTime',
      opUserId: 'opUserId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryList: { 'type': 'array', 'itemType': 'string' },
      endTime: 'number',
      opUserId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
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

export class GetPublisherSummaryHeaders extends $tea.Model {
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

export class GetPublisherSummaryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublisherSummaryResponseBody extends $tea.Model {
  data?: GetPublisherSummaryResponseBodyData[];
  hasMore?: boolean;
  nextToken?: number;
  publisherArticleCntStd?: string;
  publisherArticlePvCntStd?: string;
  publisherArticlePvTop5?: GetPublisherSummaryResponseBodyPublisherArticlePvTop5[];
  publisherCntStd?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      publisherArticleCntStd: 'publisherArticleCntStd',
      publisherArticlePvCntStd: 'publisherArticlePvCntStd',
      publisherArticlePvTop5: 'publisherArticlePvTop5',
      publisherCntStd: 'publisherCntStd',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetPublisherSummaryResponseBodyData },
      hasMore: 'boolean',
      nextToken: 'number',
      publisherArticleCntStd: 'string',
      publisherArticlePvCntStd: 'string',
      publisherArticlePvTop5: { 'type': 'array', 'itemType': GetPublisherSummaryResponseBodyPublisherArticlePvTop5 },
      publisherCntStd: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublisherSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPublisherSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPublisherSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignedDetailByPageHeaders extends $tea.Model {
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

export class GetSignedDetailByPageRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  signStatus?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      signStatus: 'signStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      signStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignedDetailByPageResponseBody extends $tea.Model {
  auditSignedDetailDTOList?: GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList[];
  currentPage?: number;
  pageSize?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      auditSignedDetailDTOList: 'auditSignedDetailDTOList',
      currentPage: 'currentPage',
      pageSize: 'pageSize',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auditSignedDetailDTOList: { 'type': 'array', 'itemType': GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList },
      currentPage: 'number',
      pageSize: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignedDetailByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSignedDetailByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSignedDetailByPageResponseBody,
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

export class GetUserAppVersionSummaryHeaders extends $tea.Model {
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

export class GetUserAppVersionSummaryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAppVersionSummaryResponseBody extends $tea.Model {
  data?: GetUserAppVersionSummaryResponseBodyData[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetUserAppVersionSummaryResponseBodyData },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAppVersionSummaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserAppVersionSummaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserAppVersionSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserStayLengthHeaders extends $tea.Model {
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

export class GetUserStayLengthRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserStayLengthResponseBody extends $tea.Model {
  itemList?: GetUserStayLengthResponseBodyItemList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      itemList: 'itemList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemList: { 'type': 'array', 'itemType': GetUserStayLengthResponseBodyItemList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserStayLengthResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserStayLengthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserStayLengthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAuditLogHeaders extends $tea.Model {
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

export class ListAuditLogRequest extends $tea.Model {
  endDate?: number;
  nextBizId?: number;
  nextGmtCreate?: number;
  pageSize?: number;
  startDate?: number;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      nextBizId: 'nextBizId',
      nextGmtCreate: 'nextGmtCreate',
      pageSize: 'pageSize',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'number',
      nextBizId: 'number',
      nextGmtCreate: 'number',
      pageSize: 'number',
      startDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAuditLogResponseBody extends $tea.Model {
  list?: ListAuditLogResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListAuditLogResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAuditLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAuditLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAuditLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListJoinOrgInfoHeaders extends $tea.Model {
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

export class ListJoinOrgInfoRequest extends $tea.Model {
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListJoinOrgInfoResponseBody extends $tea.Model {
  orgInfoList?: ListJoinOrgInfoResponseBodyOrgInfoList[];
  static names(): { [key: string]: string } {
    return {
      orgInfoList: 'orgInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgInfoList: { 'type': 'array', 'itemType': ListJoinOrgInfoResponseBodyOrgInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListJoinOrgInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListJoinOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListJoinOrgInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppAvailableVersionHeaders extends $tea.Model {
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

export class ListMiniAppAvailableVersionRequest extends $tea.Model {
  miniAppId?: string;
  pageNumber?: number;
  pageSize?: number;
  versionTypeSet?: number[];
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      versionTypeSet: 'versionTypeSet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      versionTypeSet: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppAvailableVersionResponseBody extends $tea.Model {
  list?: ListMiniAppAvailableVersionResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListMiniAppAvailableVersionResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppAvailableVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListMiniAppAvailableVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListMiniAppAvailableVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppHistoryVersionHeaders extends $tea.Model {
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

export class ListMiniAppHistoryVersionRequest extends $tea.Model {
  miniAppId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppHistoryVersionResponseBody extends $tea.Model {
  list?: ListMiniAppHistoryVersionResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListMiniAppHistoryVersionResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppHistoryVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListMiniAppHistoryVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListMiniAppHistoryVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesHeaders extends $tea.Model {
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

export class ListPartnerRolesResponseBody extends $tea.Model {
  list?: ListPartnerRolesResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListPartnerRolesResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListPartnerRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListPartnerRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPunchScheduleByConditionWithPagingHeaders extends $tea.Model {
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

export class ListPunchScheduleByConditionWithPagingRequest extends $tea.Model {
  bizInstanceId?: string;
  maxResults?: number;
  nextToken?: number;
  scheduleDateEnd?: string;
  scheduleDateStart?: string;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      bizInstanceId: 'bizInstanceId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      scheduleDateEnd: 'scheduleDateEnd',
      scheduleDateStart: 'scheduleDateStart',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizInstanceId: 'string',
      maxResults: 'number',
      nextToken: 'number',
      scheduleDateEnd: 'string',
      scheduleDateStart: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPunchScheduleByConditionWithPagingResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: ListPunchScheduleByConditionWithPagingResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListPunchScheduleByConditionWithPagingResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPunchScheduleByConditionWithPagingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListPunchScheduleByConditionWithPagingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListPunchScheduleByConditionWithPagingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishFileChangeNoticeHeaders extends $tea.Model {
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

export class PublishFileChangeNoticeRequest extends $tea.Model {
  fileId?: string;
  operateType?: string;
  operatorUnionId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      operateType: 'operateType',
      operatorUnionId: 'operatorUnionId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      operateType: 'string',
      operatorUnionId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishFileChangeNoticeResponse extends $tea.Model {
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

export class PushBadgeHeaders extends $tea.Model {
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

export class PushBadgeRequest extends $tea.Model {
  agentId?: string;
  badgeItems?: PushBadgeRequestBadgeItems[];
  pushType?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      badgeItems: 'badgeItems',
      pushType: 'pushType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'string',
      badgeItems: { 'type': 'array', 'itemType': PushBadgeRequestBadgeItems },
      pushType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushBadgeResponseBody extends $tea.Model {
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

export class PushBadgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PushBadgeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PushBadgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcrossCloudStroageConfigsHeaders extends $tea.Model {
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

export class QueryAcrossCloudStroageConfigsRequest extends $tea.Model {
  targetCloudType?: number;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      targetCloudType: 'targetCloudType',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCloudType: 'number',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcrossCloudStroageConfigsResponseBody extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  bucketName?: string;
  cloudType?: number;
  endpoint?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      bucketName: 'bucketName',
      cloudType: 'cloudType',
      endpoint: 'endpoint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      bucketName: 'string',
      cloudType: 'number',
      endpoint: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcrossCloudStroageConfigsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAcrossCloudStroageConfigsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAcrossCloudStroageConfigsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPartnerInfoHeaders extends $tea.Model {
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

export class QueryPartnerInfoResponseBody extends $tea.Model {
  partnerDeptList?: QueryPartnerInfoResponseBodyPartnerDeptList[];
  partnerLabelList?: QueryPartnerInfoResponseBodyPartnerLabelList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      partnerDeptList: 'partnerDeptList',
      partnerLabelList: 'partnerLabelList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partnerDeptList: { 'type': 'array', 'itemType': QueryPartnerInfoResponseBodyPartnerDeptList },
      partnerLabelList: { 'type': 'array', 'itemType': QueryPartnerInfoResponseBodyPartnerLabelList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPartnerInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPartnerInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPartnerInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackMiniAppVersionHeaders extends $tea.Model {
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

export class RollbackMiniAppVersionRequest extends $tea.Model {
  miniAppId?: string;
  rollbackVersion?: string;
  targetVersion?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      rollbackVersion: 'rollbackVersion',
      targetVersion: 'targetVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      rollbackVersion: 'string',
      targetVersion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackMiniAppVersionResponseBody extends $tea.Model {
  cause?: string;
  code?: number;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      code: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackMiniAppVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RollbackMiniAppVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RollbackMiniAppVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveAcrossCloudStroageConfigsHeaders extends $tea.Model {
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

export class SaveAcrossCloudStroageConfigsRequest extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  bucketName?: string;
  cloudType?: number;
  endpoint?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      bucketName: 'bucketName',
      cloudType: 'cloudType',
      endpoint: 'endpoint',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      bucketName: 'string',
      cloudType: 'number',
      endpoint: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveAcrossCloudStroageConfigsResponseBody extends $tea.Model {
  accessKeyId?: string;
  endpoint?: string;
  state?: number;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      endpoint: 'endpoint',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      endpoint: 'string',
      state: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveAcrossCloudStroageConfigsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveAcrossCloudStroageConfigsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveAcrossCloudStroageConfigsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveAndSubmitAuthInfoHeaders extends $tea.Model {
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

export class SaveAndSubmitAuthInfoRequest extends $tea.Model {
  applyRemark?: string;
  authorizeMediaId?: string;
  industry?: string;
  legalPerson?: string;
  legalPersonIdCard?: string;
  licenseMediaId?: string;
  locCity?: number;
  locCityName?: string;
  locProvince?: number;
  locProvinceName?: string;
  mobileNum?: string;
  orgName?: string;
  organizationCode?: string;
  organizationCodeMediaId?: string;
  registLocation?: string;
  registNum?: string;
  targetCorpId?: string;
  unifiedSocialCredit?: string;
  static names(): { [key: string]: string } {
    return {
      applyRemark: 'applyRemark',
      authorizeMediaId: 'authorizeMediaId',
      industry: 'industry',
      legalPerson: 'legalPerson',
      legalPersonIdCard: 'legalPersonIdCard',
      licenseMediaId: 'licenseMediaId',
      locCity: 'locCity',
      locCityName: 'locCityName',
      locProvince: 'locProvince',
      locProvinceName: 'locProvinceName',
      mobileNum: 'mobileNum',
      orgName: 'orgName',
      organizationCode: 'organizationCode',
      organizationCodeMediaId: 'organizationCodeMediaId',
      registLocation: 'registLocation',
      registNum: 'registNum',
      targetCorpId: 'targetCorpId',
      unifiedSocialCredit: 'unifiedSocialCredit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyRemark: 'string',
      authorizeMediaId: 'string',
      industry: 'string',
      legalPerson: 'string',
      legalPersonIdCard: 'string',
      licenseMediaId: 'string',
      locCity: 'number',
      locCityName: 'string',
      locProvince: 'number',
      locProvinceName: 'string',
      mobileNum: 'string',
      orgName: 'string',
      organizationCode: 'string',
      organizationCodeMediaId: 'string',
      registLocation: 'string',
      registNum: 'string',
      targetCorpId: 'string',
      unifiedSocialCredit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveAndSubmitAuthInfoResponseBody extends $tea.Model {
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

export class SaveAndSubmitAuthInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveAndSubmitAuthInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveAndSubmitAuthInfoResponseBody,
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
  createTimeEnd?: number;
  createTimeStart?: number;
  groupMembersCountEnd?: number;
  groupMembersCountStart?: number;
  groupName?: string;
  groupOwner?: string;
  lastActiveTimeEnd?: number;
  lastActiveTimeStart?: number;
  operatorUserId?: string;
  pageSize?: number;
  pageStart?: number;
  syncToDingpan?: number;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      createTimeEnd: 'createTimeEnd',
      createTimeStart: 'createTimeStart',
      groupMembersCountEnd: 'groupMembersCountEnd',
      groupMembersCountStart: 'groupMembersCountStart',
      groupName: 'groupName',
      groupOwner: 'groupOwner',
      lastActiveTimeEnd: 'lastActiveTimeEnd',
      lastActiveTimeStart: 'lastActiveTimeStart',
      operatorUserId: 'operatorUserId',
      pageSize: 'pageSize',
      pageStart: 'pageStart',
      syncToDingpan: 'syncToDingpan',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeEnd: 'number',
      createTimeStart: 'number',
      groupMembersCountEnd: 'number',
      groupMembersCountStart: 'number',
      groupName: 'string',
      groupOwner: 'string',
      lastActiveTimeEnd: 'number',
      lastActiveTimeStart: 'number',
      operatorUserId: 'string',
      pageSize: 'number',
      pageStart: 'number',
      syncToDingpan: 'number',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOrgInnerGroupInfoResponseBody extends $tea.Model {
  itemCount?: number;
  items?: SearchOrgInnerGroupInfoResponseBodyItems[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      itemCount: 'itemCount',
      items: 'items',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemCount: 'number',
      items: { 'type': 'array', 'itemType': SearchOrgInnerGroupInfoResponseBodyItems },
      totalCount: 'number',
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

export class SendAppDingHeaders extends $tea.Model {
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

export class SendAppDingRequest extends $tea.Model {
  content?: string;
  userids?: string[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      userids: 'userids',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      userids: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAppDingResponse extends $tea.Model {
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

export class SendInvitationHeaders extends $tea.Model {
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

export class SendInvitationRequest extends $tea.Model {
  deptId?: string;
  orgAlias?: string;
  partnerLabelId?: number;
  partnerNum?: string;
  phone?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      orgAlias: 'orgAlias',
      partnerLabelId: 'partnerLabelId',
      partnerNum: 'partnerNum',
      phone: 'phone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      orgAlias: 'string',
      partnerLabelId: 'number',
      partnerNum: 'string',
      phone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInvitationResponse extends $tea.Model {
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
  labelIds?: string[];
  partnerNum?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      labelIds: 'labelIds',
      partnerNum: 'partnerNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      labelIds: { 'type': 'array', 'itemType': 'string' },
      partnerNum: 'string',
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

export class UpdateFileStatusHeaders extends $tea.Model {
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

export class UpdateFileStatusRequest extends $tea.Model {
  requestIds?: string[];
  status?: number;
  static names(): { [key: string]: string } {
    return {
      requestIds: 'requestIds',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestIds: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFileStatusResponseBody extends $tea.Model {
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

export class UpdateFileStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateFileStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateFileStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMiniAppVersionStatusHeaders extends $tea.Model {
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

export class UpdateMiniAppVersionStatusRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  versionType?: number;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
      versionType: 'versionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
      versionType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMiniAppVersionStatusResponseBody extends $tea.Model {
  cause?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMiniAppVersionStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateMiniAppVersionStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateMiniAppVersionStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePartnerVisibilityHeaders extends $tea.Model {
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

export class UpdatePartnerVisibilityRequest extends $tea.Model {
  deptIds?: number[];
  labelId?: number;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      labelId: 'labelId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      labelId: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePartnerVisibilityResponse extends $tea.Model {
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

export class UpdateRoleVisibilityHeaders extends $tea.Model {
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

export class UpdateRoleVisibilityRequest extends $tea.Model {
  deptIds?: number[];
  labelId?: number;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      labelId: 'labelId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      labelId: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRoleVisibilityResponse extends $tea.Model {
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

export class UpdateStorageModeHeaders extends $tea.Model {
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

export class UpdateStorageModeRequest extends $tea.Model {
  fileStorageMode?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      fileStorageMode: 'fileStorageMode',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileStorageMode: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStorageModeResponseBody extends $tea.Model {
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStorageModeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateStorageModeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateStorageModeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FileStorageGetQuotaDataResponseBodyQuotaModelList extends $tea.Model {
  statisticTime?: string;
  usedStorage?: number;
  static names(): { [key: string]: string } {
    return {
      statisticTime: 'statisticTime',
      usedStorage: 'usedStorage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statisticTime: 'string',
      usedStorage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList extends $tea.Model {
  darkWatermark?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      darkWatermark: 'darkWatermark',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      darkWatermark: 'string',
      userId: 'string',
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
  deptName?: string;
  memberCount?: number;
  partnerLabelVOLevel1?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1;
  partnerLabelVOLevel2?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2;
  partnerLabelVOLevel3?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3;
  partnerLabelVOLevel4?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4;
  partnerLabelVOLevel5?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5;
  partnerNum?: string;
  superDeptId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      memberCount: 'memberCount',
      partnerLabelVOLevel1: 'partnerLabelVOLevel1',
      partnerLabelVOLevel2: 'partnerLabelVOLevel2',
      partnerLabelVOLevel3: 'partnerLabelVOLevel3',
      partnerLabelVOLevel4: 'partnerLabelVOLevel4',
      partnerLabelVOLevel5: 'partnerLabelVOLevel5',
      partnerNum: 'partnerNum',
      superDeptId: 'superDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptName: 'string',
      memberCount: 'number',
      partnerLabelVOLevel1: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1,
      partnerLabelVOLevel2: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2,
      partnerLabelVOLevel3: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3,
      partnerLabelVOLevel4: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4,
      partnerLabelVOLevel5: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5,
      partnerNum: 'string',
      superDeptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponseBodyAndroid extends $tea.Model {
  baseLineVersion?: string;
  downloadUrl?: string;
  inGray?: boolean;
  packTime?: number;
  platform?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      baseLineVersion: 'baseLineVersion',
      downloadUrl: 'downloadUrl',
      inGray: 'inGray',
      packTime: 'packTime',
      platform: 'platform',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      baseLineVersion: 'string',
      downloadUrl: 'string',
      inGray: 'boolean',
      packTime: 'number',
      platform: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponseBodyIOSExt extends $tea.Model {
  plist?: string;
  static names(): { [key: string]: string } {
    return {
      plist: 'plist',
    };
  }

  static types(): { [key: string]: any } {
    return {
      plist: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponseBodyIOS extends $tea.Model {
  baseLineVersion?: string;
  downloadUrl?: string;
  ext?: GetAppDispatchInfoResponseBodyIOSExt;
  inGray?: boolean;
  packTime?: number;
  platform?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      baseLineVersion: 'baseLineVersion',
      downloadUrl: 'downloadUrl',
      ext: 'ext',
      inGray: 'inGray',
      packTime: 'packTime',
      platform: 'platform',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      baseLineVersion: 'string',
      downloadUrl: 'string',
      ext: GetAppDispatchInfoResponseBodyIOSExt,
      inGray: 'boolean',
      packTime: 'number',
      platform: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponseBodyMac extends $tea.Model {
  baseLineVersion?: string;
  downloadUrl?: string;
  inGray?: boolean;
  packTime?: number;
  platform?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      baseLineVersion: 'baseLineVersion',
      downloadUrl: 'downloadUrl',
      inGray: 'inGray',
      packTime: 'packTime',
      platform: 'platform',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      baseLineVersion: 'string',
      downloadUrl: 'string',
      inGray: 'boolean',
      packTime: 'number',
      platform: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppDispatchInfoResponseBodyWindows extends $tea.Model {
  baseLineVersion?: string;
  downloadUrl?: string;
  inGray?: boolean;
  packTime?: number;
  platform?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      baseLineVersion: 'baseLineVersion',
      downloadUrl: 'downloadUrl',
      inGray: 'inGray',
      packTime: 'packTime',
      platform: 'platform',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      baseLineVersion: 'string',
      downloadUrl: 'string',
      inGray: 'boolean',
      packTime: 'number',
      platform: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCommentListResponseBodyData extends $tea.Model {
  commentId?: string;
  commentTime?: number;
  commentUserName?: string;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      commentId: 'commentId',
      commentTime: 'commentTime',
      commentUserName: 'commentUserName',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commentId: 'string',
      commentTime: 'number',
      commentUserName: 'string',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConferenceDetailResponseBodyMemberList extends $tea.Model {
  attendDuration?: number;
  name?: string;
  staffId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      attendDuration: 'attendDuration',
      name: 'name',
      staffId: 'staffId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendDuration: 'number',
      name: 'string',
      staffId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingReportDeptSummaryResponseBodyData extends $tea.Model {
  deptId?: string;
  deptName?: string;
  dingReportSendCnt?: string;
  dingReportSendUsrCnt?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      dingReportSendCnt: 'dingReportSendCnt',
      dingReportSendUsrCnt: 'dingReportSendUsrCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptName: 'string',
      dingReportSendCnt: 'string',
      dingReportSendUsrCnt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocCreatedDeptSummaryResponseBodyData extends $tea.Model {
  createDocUserCnt1d?: string;
  deptId?: string;
  deptName?: string;
  docCreatedCnt?: string;
  static names(): { [key: string]: string } {
    return {
      createDocUserCnt1d: 'createDocUserCnt1d',
      deptId: 'deptId',
      deptName: 'deptName',
      docCreatedCnt: 'docCreatedCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createDocUserCnt1d: 'string',
      deptId: 'string',
      deptName: 'string',
      docCreatedCnt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGeneralFormCreatedDeptSummaryResponseBodyData extends $tea.Model {
  deptId?: string;
  deptName?: string;
  generalFormCreateCnt1d?: string;
  useGeneralFormUserCnt1d?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
      generalFormCreateCnt1d: 'generalFormCreateCnt1d',
      useGeneralFormUserCnt1d: 'useGeneralFormUserCnt1d',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptName: 'string',
      generalFormCreateCnt1d: 'string',
      useGeneralFormUserCnt1d: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupActiveInfoResponseBodyData extends $tea.Model {
  dingGroupId?: string;
  groupCreateTime?: string;
  groupCreateUserId?: string;
  groupCreateUserName?: string;
  groupName?: string;
  groupType?: number;
  groupUserCnt1d?: number;
  openConvUv1d?: number;
  sendMessageCnt1d?: number;
  sendMessageUserCnt1d?: number;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      dingGroupId: 'dingGroupId',
      groupCreateTime: 'groupCreateTime',
      groupCreateUserId: 'groupCreateUserId',
      groupCreateUserName: 'groupCreateUserName',
      groupName: 'groupName',
      groupType: 'groupType',
      groupUserCnt1d: 'groupUserCnt1d',
      openConvUv1d: 'openConvUv1d',
      sendMessageCnt1d: 'sendMessageCnt1d',
      sendMessageUserCnt1d: 'sendMessageUserCnt1d',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingGroupId: 'string',
      groupCreateTime: 'string',
      groupCreateUserId: 'string',
      groupCreateUserName: 'string',
      groupName: 'string',
      groupType: 'number',
      groupUserCnt1d: 'number',
      openConvUv1d: 'number',
      sendMessageCnt1d: 'number',
      sendMessageUserCnt1d: 'number',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInActiveUserListResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOaOperatorLogListResponseBodyData extends $tea.Model {
  category1Name?: string;
  category2Name?: string;
  content?: string;
  opName?: string;
  opTime?: number;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      category1Name: 'category1Name',
      category2Name: 'category2Name',
      content: 'content',
      opName: 'opName',
      opTime: 'opTime',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category1Name: 'string',
      category2Name: 'string',
      content: 'string',
      opName: 'string',
      opTime: 'number',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPartnerTypeByParentIdResponseBodyData extends $tea.Model {
  labelId?: string;
  typeId?: number;
  typeName?: string;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      typeId: 'typeId',
      typeName: 'typeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'string',
      typeId: 'number',
      typeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublisherSummaryResponseBodyData extends $tea.Model {
  publisherArticleCntStd?: string;
  publisherArticlePvCntStd?: string;
  publisherName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      publisherArticleCntStd: 'publisherArticleCntStd',
      publisherArticlePvCntStd: 'publisherArticlePvCntStd',
      publisherName: 'publisherName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      publisherArticleCntStd: 'string',
      publisherArticlePvCntStd: 'string',
      publisherName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublisherSummaryResponseBodyPublisherArticlePvTop5 extends $tea.Model {
  name?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList extends $tea.Model {
  deptName?: string;
  email?: string;
  name?: string;
  phone?: string;
  roles?: string;
  staffId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      email: 'email',
      name: 'name',
      phone: 'phone',
      roles: 'roles',
      staffId: 'staffId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      email: 'string',
      name: 'string',
      phone: 'string',
      roles: 'string',
      staffId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrustDeviceListResponseBodyData extends $tea.Model {
  createTime?: number;
  macAddress?: string;
  model?: string;
  platform?: string;
  status?: number;
  title?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      macAddress: 'macAddress',
      model: 'model',
      platform: 'platform',
      status: 'status',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      macAddress: 'string',
      model: 'string',
      platform: 'string',
      status: 'number',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAppVersionSummaryResponseBodyData extends $tea.Model {
  appVersion?: string;
  client?: string;
  orgName?: string;
  statDate?: string;
  userCnt?: number;
  static names(): { [key: string]: string } {
    return {
      appVersion: 'appVersion',
      client: 'client',
      orgName: 'orgName',
      statDate: 'statDate',
      userCnt: 'userCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appVersion: 'string',
      client: 'string',
      orgName: 'string',
      statDate: 'string',
      userCnt: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserStayLengthResponseBodyItemList extends $tea.Model {
  name?: string;
  statDate?: string;
  stayTimeLenApp1d?: number;
  stayTimeLenPc1d?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      statDate: 'statDate',
      stayTimeLenApp1d: 'stayTimeLenApp1d',
      stayTimeLenPc1d: 'stayTimeLenPc1d',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      statDate: 'string',
      stayTimeLenApp1d: 'number',
      stayTimeLenPc1d: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAuditLogResponseBodyListDocMemberList extends $tea.Model {
  memberName?: string;
  memberType?: number;
  memberTypeView?: string;
  permissionRole?: number;
  permissionRoleView?: string;
  static names(): { [key: string]: string } {
    return {
      memberName: 'memberName',
      memberType: 'memberType',
      memberTypeView: 'memberTypeView',
      permissionRole: 'permissionRole',
      permissionRoleView: 'permissionRoleView',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberName: 'string',
      memberType: 'number',
      memberTypeView: 'string',
      permissionRole: 'number',
      permissionRoleView: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAuditLogResponseBodyListDocReceiverList extends $tea.Model {
  receiverName?: string;
  receiverType?: number;
  receiverTypeView?: string;
  static names(): { [key: string]: string } {
    return {
      receiverName: 'receiverName',
      receiverType: 'receiverType',
      receiverTypeView: 'receiverTypeView',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receiverName: 'string',
      receiverType: 'number',
      receiverTypeView: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAuditLogResponseBodyList extends $tea.Model {
  action?: number;
  actionView?: string;
  bizId?: string;
  docMemberList?: ListAuditLogResponseBodyListDocMemberList[];
  docReceiverList?: ListAuditLogResponseBodyListDocReceiverList[];
  gmtCreate?: number;
  gmtModified?: number;
  ipAddress?: string;
  operateModule?: number;
  operateModuleView?: string;
  operatorName?: string;
  orgName?: string;
  platform?: number;
  platformView?: string;
  realName?: string;
  receiverName?: string;
  receiverType?: number;
  receiverTypeView?: string;
  resource?: string;
  resourceExtension?: string;
  resourceSize?: number;
  status?: number;
  targetSpaceId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      actionView: 'actionView',
      bizId: 'bizId',
      docMemberList: 'docMemberList',
      docReceiverList: 'docReceiverList',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      ipAddress: 'ipAddress',
      operateModule: 'operateModule',
      operateModuleView: 'operateModuleView',
      operatorName: 'operatorName',
      orgName: 'orgName',
      platform: 'platform',
      platformView: 'platformView',
      realName: 'realName',
      receiverName: 'receiverName',
      receiverType: 'receiverType',
      receiverTypeView: 'receiverTypeView',
      resource: 'resource',
      resourceExtension: 'resourceExtension',
      resourceSize: 'resourceSize',
      status: 'status',
      targetSpaceId: 'targetSpaceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'number',
      actionView: 'string',
      bizId: 'string',
      docMemberList: { 'type': 'array', 'itemType': ListAuditLogResponseBodyListDocMemberList },
      docReceiverList: { 'type': 'array', 'itemType': ListAuditLogResponseBodyListDocReceiverList },
      gmtCreate: 'number',
      gmtModified: 'number',
      ipAddress: 'string',
      operateModule: 'number',
      operateModuleView: 'string',
      operatorName: 'string',
      orgName: 'string',
      platform: 'number',
      platformView: 'string',
      realName: 'string',
      receiverName: 'string',
      receiverType: 'number',
      receiverTypeView: 'string',
      resource: 'string',
      resourceExtension: 'string',
      resourceSize: 'number',
      status: 'number',
      targetSpaceId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListJoinOrgInfoResponseBodyOrgInfoList extends $tea.Model {
  corpId?: string;
  domain?: string;
  orgFullName?: string;
  orgName?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      domain: 'domain',
      orgFullName: 'orgFullName',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      domain: 'string',
      orgFullName: 'string',
      orgName: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppAvailableVersionResponseBodyList extends $tea.Model {
  buildStatus?: number;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      buildStatus: 'buildStatus',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buildStatus: 'number',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMiniAppHistoryVersionResponseBodyList extends $tea.Model {
  buildStatus?: number;
  h5Bundle?: string;
  packageSize?: string;
  packageUrl?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      buildStatus: 'buildStatus',
      h5Bundle: 'h5Bundle',
      packageSize: 'packageSize',
      packageUrl: 'packageUrl',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buildStatus: 'number',
      h5Bundle: 'string',
      packageSize: 'string',
      packageUrl: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesResponseBodyListVisibleDepts extends $tea.Model {
  deptId?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesResponseBodyListVisibleUsers extends $tea.Model {
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesResponseBodyListWarningDepts extends $tea.Model {
  deptId?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesResponseBodyListWarningUsers extends $tea.Model {
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPartnerRolesResponseBodyList extends $tea.Model {
  id?: number;
  isNecessary?: number;
  name?: string;
  visibleDepts?: ListPartnerRolesResponseBodyListVisibleDepts[];
  visibleUsers?: ListPartnerRolesResponseBodyListVisibleUsers[];
  warningDepts?: ListPartnerRolesResponseBodyListWarningDepts[];
  warningUsers?: ListPartnerRolesResponseBodyListWarningUsers[];
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      isNecessary: 'isNecessary',
      name: 'name',
      visibleDepts: 'visibleDepts',
      visibleUsers: 'visibleUsers',
      warningDepts: 'warningDepts',
      warningUsers: 'warningUsers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      isNecessary: 'number',
      name: 'string',
      visibleDepts: { 'type': 'array', 'itemType': ListPartnerRolesResponseBodyListVisibleDepts },
      visibleUsers: { 'type': 'array', 'itemType': ListPartnerRolesResponseBodyListVisibleUsers },
      warningDepts: { 'type': 'array', 'itemType': ListPartnerRolesResponseBodyListWarningDepts },
      warningUsers: { 'type': 'array', 'itemType': ListPartnerRolesResponseBodyListWarningUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPunchScheduleByConditionWithPagingResponseBodyList extends $tea.Model {
  bizOuterId?: string;
  positionName?: string;
  punchSymbol?: string;
  userId?: string;
  userPunchTime?: number;
  static names(): { [key: string]: string } {
    return {
      bizOuterId: 'bizOuterId',
      positionName: 'positionName',
      punchSymbol: 'punchSymbol',
      userId: 'userId',
      userPunchTime: 'userPunchTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizOuterId: 'string',
      positionName: 'string',
      punchSymbol: 'string',
      userId: 'string',
      userPunchTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushBadgeRequestBadgeItems extends $tea.Model {
  pushValue?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      pushValue: 'pushValue',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pushValue: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 extends $tea.Model {
  labelId?: number;
  labelname?: string;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelname: 'labelname',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelname: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPartnerInfoResponseBodyPartnerDeptList extends $tea.Model {
  memberCount?: number;
  partnerLabelModelLevel1?: QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1;
  partnerNum?: string;
  title?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      memberCount: 'memberCount',
      partnerLabelModelLevel1: 'partnerLabelModelLevel1',
      partnerNum: 'partnerNum',
      title: 'title',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberCount: 'number',
      partnerLabelModelLevel1: QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1,
      partnerNum: 'string',
      title: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPartnerInfoResponseBodyPartnerLabelList extends $tea.Model {
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOrgInnerGroupInfoResponseBodyItems extends $tea.Model {
  groupAdminsCount?: number;
  groupCreateTime?: number;
  groupLastActiveTime?: number;
  groupLastActiveTimeShow?: string;
  groupMembersCount?: number;
  groupName?: string;
  groupOwner?: string;
  groupOwnerUserId?: string;
  openConversationId?: string;
  status?: number;
  syncToDingpan?: number;
  templateId?: string;
  templateName?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      groupAdminsCount: 'groupAdminsCount',
      groupCreateTime: 'groupCreateTime',
      groupLastActiveTime: 'groupLastActiveTime',
      groupLastActiveTimeShow: 'groupLastActiveTimeShow',
      groupMembersCount: 'groupMembersCount',
      groupName: 'groupName',
      groupOwner: 'groupOwner',
      groupOwnerUserId: 'groupOwnerUserId',
      openConversationId: 'openConversationId',
      status: 'status',
      syncToDingpan: 'syncToDingpan',
      templateId: 'templateId',
      templateName: 'templateName',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupAdminsCount: 'number',
      groupCreateTime: 'number',
      groupLastActiveTime: 'number',
      groupLastActiveTimeShow: 'string',
      groupMembersCount: 'number',
      groupName: 'string',
      groupOwner: 'string',
      groupOwnerUserId: 'string',
      openConversationId: 'string',
      status: 'number',
      syncToDingpan: 'number',
      templateId: 'string',
      templateName: 'string',
      usedQuota: 'number',
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


  async addOrg(request: AddOrgRequest): Promise<AddOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOrgHeaders({ });
    return await this.addOrgWithOptions(request, headers, runtime);
  }

  async addOrgWithOptions(request: AddOrgRequest, headers: AddOrgHeaders, runtime: $Util.RuntimeOptions): Promise<AddOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobileNum)) {
      body["mobileNum"] = request.mobileNum;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
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
    return $tea.cast<AddOrgResponse>(await this.doROARequest("AddOrg", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/orgnizations`, "json", req, runtime), new AddOrgResponse({}));
  }

  async banOrOpenGroupWords(request: BanOrOpenGroupWordsRequest): Promise<BanOrOpenGroupWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BanOrOpenGroupWordsHeaders({ });
    return await this.banOrOpenGroupWordsWithOptions(request, headers, runtime);
  }

  async banOrOpenGroupWordsWithOptions(request: BanOrOpenGroupWordsRequest, headers: BanOrOpenGroupWordsHeaders, runtime: $Util.RuntimeOptions): Promise<BanOrOpenGroupWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.banWordsType)) {
      body["banWordsType"] = request.banWordsType;
    }

    if (!Util.isUnset(request.openConverationId)) {
      body["openConverationId"] = request.openConverationId;
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
    return $tea.cast<BanOrOpenGroupWordsResponse>(await this.doROARequest("BanOrOpenGroupWords", "exclusive_1.0", "HTTP", "PUT", "AK", `/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords`, "json", req, runtime), new BanOrOpenGroupWordsResponse({}));
  }

  async createTrustedDevice(request: CreateTrustedDeviceRequest): Promise<CreateTrustedDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceHeaders({ });
    return await this.createTrustedDeviceWithOptions(request, headers, runtime);
  }

  async createTrustedDeviceWithOptions(request: CreateTrustedDeviceRequest, headers: CreateTrustedDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTrustedDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.did)) {
      body["did"] = request.did;
    }

    if (!Util.isUnset(request.macAddress)) {
      body["macAddress"] = request.macAddress;
    }

    if (!Util.isUnset(request.platform)) {
      body["platform"] = request.platform;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<CreateTrustedDeviceResponse>(await this.doROARequest("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/trustedDevices`, "json", req, runtime), new CreateTrustedDeviceResponse({}));
  }

  async createTrustedDeviceBatch(request: CreateTrustedDeviceBatchRequest): Promise<CreateTrustedDeviceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceBatchHeaders({ });
    return await this.createTrustedDeviceBatchWithOptions(request, headers, runtime);
  }

  async createTrustedDeviceBatchWithOptions(request: CreateTrustedDeviceBatchRequest, headers: CreateTrustedDeviceBatchHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTrustedDeviceBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.macAddressList)) {
      body["macAddressList"] = request.macAddressList;
    }

    if (!Util.isUnset(request.platform)) {
      body["platform"] = request.platform;
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
    return $tea.cast<CreateTrustedDeviceBatchResponse>(await this.doROARequest("CreateTrustedDeviceBatch", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/trusts/devices`, "json", req, runtime), new CreateTrustedDeviceBatchResponse({}));
  }

  async deleteAcrossCloudStroageConfigs(targetCorpId: string): Promise<DeleteAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAcrossCloudStroageConfigsHeaders({ });
    return await this.deleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
  }

  async deleteAcrossCloudStroageConfigsWithOptions(targetCorpId: string, headers: DeleteAcrossCloudStroageConfigsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAcrossCloudStroageConfigsResponse> {
    targetCorpId = OpenApiUtil.getEncodeParam(targetCorpId);
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
    return $tea.cast<DeleteAcrossCloudStroageConfigsResponse>(await this.doROARequest("DeleteAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "DELETE", "AK", `/v1.0/exclusive/fileStorages/acrossClouds/configurations/${targetCorpId}`, "json", req, runtime), new DeleteAcrossCloudStroageConfigsResponse({}));
  }

  async deleteComment(publisherId: string, commentId: string): Promise<DeleteCommentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCommentHeaders({ });
    return await this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
  }

  async deleteCommentWithOptions(publisherId: string, commentId: string, headers: DeleteCommentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCommentResponse> {
    publisherId = OpenApiUtil.getEncodeParam(publisherId);
    commentId = OpenApiUtil.getEncodeParam(commentId);
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
    return $tea.cast<DeleteCommentResponse>(await this.doROARequest("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", `/v1.0/exclusive/publishers/${publisherId}/comments/${commentId}`, "boolean", req, runtime), new DeleteCommentResponse({}));
  }

  async distributePartnerApp(request: DistributePartnerAppRequest): Promise<DistributePartnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DistributePartnerAppHeaders({ });
    return await this.distributePartnerAppWithOptions(request, headers, runtime);
  }

  async distributePartnerAppWithOptions(request: DistributePartnerAppRequest, headers: DistributePartnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<DistributePartnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.subCorpId)) {
      body["subCorpId"] = request.subCorpId;
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
    return $tea.cast<DistributePartnerAppResponse>(await this.doROARequest("DistributePartnerApp", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/partners/applications/distribute`, "json", req, runtime), new DistributePartnerAppResponse({}));
  }

  async exclusiveCreateDingPortal(request: ExclusiveCreateDingPortalRequest): Promise<ExclusiveCreateDingPortalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExclusiveCreateDingPortalHeaders({ });
    return await this.exclusiveCreateDingPortalWithOptions(request, headers, runtime);
  }

  async exclusiveCreateDingPortalWithOptions(request: ExclusiveCreateDingPortalRequest, headers: ExclusiveCreateDingPortalHeaders, runtime: $Util.RuntimeOptions): Promise<ExclusiveCreateDingPortalResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingPortalName)) {
      body["dingPortalName"] = request.dingPortalName;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.templateAppUuid)) {
      body["templateAppUuid"] = request.templateAppUuid;
    }

    if (!Util.isUnset(request.templateCorpId)) {
      body["templateCorpId"] = request.templateCorpId;
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
    return $tea.cast<ExclusiveCreateDingPortalResponse>(await this.doROARequest("ExclusiveCreateDingPortal", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/workbenches/templates/spread`, "json", req, runtime), new ExclusiveCreateDingPortalResponse({}));
  }

  async fileStorageActiveStorage(request: FileStorageActiveStorageRequest): Promise<FileStorageActiveStorageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageActiveStorageHeaders({ });
    return await this.fileStorageActiveStorageWithOptions(request, headers, runtime);
  }

  async fileStorageActiveStorageWithOptions(request: FileStorageActiveStorageRequest, headers: FileStorageActiveStorageHeaders, runtime: $Util.RuntimeOptions): Promise<FileStorageActiveStorageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKeyId)) {
      body["accessKeyId"] = request.accessKeyId;
    }

    if (!Util.isUnset(request.accessKeySecret)) {
      body["accessKeySecret"] = request.accessKeySecret;
    }

    if (!Util.isUnset(request.oss)) {
      body["oss"] = request.oss;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<FileStorageActiveStorageResponse>(await this.doROARequest("FileStorageActiveStorage", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/fileStorages/active`, "json", req, runtime), new FileStorageActiveStorageResponse({}));
  }

  async fileStorageCheckConnection(request: FileStorageCheckConnectionRequest): Promise<FileStorageCheckConnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageCheckConnectionHeaders({ });
    return await this.fileStorageCheckConnectionWithOptions(request, headers, runtime);
  }

  async fileStorageCheckConnectionWithOptions(request: FileStorageCheckConnectionRequest, headers: FileStorageCheckConnectionHeaders, runtime: $Util.RuntimeOptions): Promise<FileStorageCheckConnectionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKeyId)) {
      body["accessKeyId"] = request.accessKeyId;
    }

    if (!Util.isUnset(request.accessKeySecret)) {
      body["accessKeySecret"] = request.accessKeySecret;
    }

    if (!Util.isUnset(request.oss)) {
      body["oss"] = request.oss;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<FileStorageCheckConnectionResponse>(await this.doROARequest("FileStorageCheckConnection", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/fileStorages/connections/check`, "json", req, runtime), new FileStorageCheckConnectionResponse({}));
  }

  async fileStorageGetQuotaData(request: FileStorageGetQuotaDataRequest): Promise<FileStorageGetQuotaDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageGetQuotaDataHeaders({ });
    return await this.fileStorageGetQuotaDataWithOptions(request, headers, runtime);
  }

  async fileStorageGetQuotaDataWithOptions(request: FileStorageGetQuotaDataRequest, headers: FileStorageGetQuotaDataHeaders, runtime: $Util.RuntimeOptions): Promise<FileStorageGetQuotaDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
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
    return $tea.cast<FileStorageGetQuotaDataResponse>(await this.doROARequest("FileStorageGetQuotaData", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/fileStorages/quotaDatas`, "json", req, runtime), new FileStorageGetQuotaDataResponse({}));
  }

  async fileStorageGetStorageState(request: FileStorageGetStorageStateRequest): Promise<FileStorageGetStorageStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageGetStorageStateHeaders({ });
    return await this.fileStorageGetStorageStateWithOptions(request, headers, runtime);
  }

  async fileStorageGetStorageStateWithOptions(request: FileStorageGetStorageStateRequest, headers: FileStorageGetStorageStateHeaders, runtime: $Util.RuntimeOptions): Promise<FileStorageGetStorageStateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<FileStorageGetStorageStateResponse>(await this.doROARequest("FileStorageGetStorageState", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/fileStorages/states`, "json", req, runtime), new FileStorageGetStorageStateResponse({}));
  }

  async fileStorageUpdateStorage(request: FileStorageUpdateStorageRequest): Promise<FileStorageUpdateStorageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageUpdateStorageHeaders({ });
    return await this.fileStorageUpdateStorageWithOptions(request, headers, runtime);
  }

  async fileStorageUpdateStorageWithOptions(request: FileStorageUpdateStorageRequest, headers: FileStorageUpdateStorageHeaders, runtime: $Util.RuntimeOptions): Promise<FileStorageUpdateStorageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKeyId)) {
      body["accessKeyId"] = request.accessKeyId;
    }

    if (!Util.isUnset(request.accessKeySecret)) {
      body["accessKeySecret"] = request.accessKeySecret;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<FileStorageUpdateStorageResponse>(await this.doROARequest("FileStorageUpdateStorage", "exclusive_1.0", "HTTP", "PUT", "AK", `/v1.0/exclusive/fileStorages/configurations`, "json", req, runtime), new FileStorageUpdateStorageResponse({}));
  }

  async generateDarkWaterMark(request: GenerateDarkWaterMarkRequest): Promise<GenerateDarkWaterMarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GenerateDarkWaterMarkHeaders({ });
    return await this.generateDarkWaterMarkWithOptions(request, headers, runtime);
  }

  async generateDarkWaterMarkWithOptions(request: GenerateDarkWaterMarkRequest, headers: GenerateDarkWaterMarkHeaders, runtime: $Util.RuntimeOptions): Promise<GenerateDarkWaterMarkResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<GenerateDarkWaterMarkResponse>(await this.doROARequest("GenerateDarkWaterMark", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate`, "json", req, runtime), new GenerateDarkWaterMarkResponse({}));
  }

  async getActiveUserSummary(dataId: string): Promise<GetActiveUserSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActiveUserSummaryHeaders({ });
    return await this.getActiveUserSummaryWithOptions(dataId, headers, runtime);
  }

  async getActiveUserSummaryWithOptions(dataId: string, headers: GetActiveUserSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetActiveUserSummaryResponse> {
    dataId = OpenApiUtil.getEncodeParam(dataId);
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
    return $tea.cast<GetActiveUserSummaryResponse>(await this.doROARequest("GetActiveUserSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/dau/org/${dataId}`, "json", req, runtime), new GetActiveUserSummaryResponse({}));
  }

  async getAgentIdByRelatedAppId(request: GetAgentIdByRelatedAppIdRequest): Promise<GetAgentIdByRelatedAppIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAgentIdByRelatedAppIdHeaders({ });
    return await this.getAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
  }

  async getAgentIdByRelatedAppIdWithOptions(request: GetAgentIdByRelatedAppIdRequest, headers: GetAgentIdByRelatedAppIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetAgentIdByRelatedAppIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<GetAgentIdByRelatedAppIdResponse>(await this.doROARequest("GetAgentIdByRelatedAppId", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/exclusiveDesigns/agentId`, "json", req, runtime), new GetAgentIdByRelatedAppIdResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetAllLabelableDeptsResponse>(await this.doROARequest("GetAllLabelableDepts", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/partnerDepartments`, "json", req, runtime), new GetAllLabelableDeptsResponse({}));
  }

  async getAppDispatchInfo(request: GetAppDispatchInfoRequest): Promise<GetAppDispatchInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppDispatchInfoHeaders({ });
    return await this.getAppDispatchInfoWithOptions(request, headers, runtime);
  }

  async getAppDispatchInfoWithOptions(request: GetAppDispatchInfoRequest, headers: GetAppDispatchInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetAppDispatchInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
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
    return $tea.cast<GetAppDispatchInfoResponse>(await this.doROARequest("GetAppDispatchInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/apps/distributionInfos`, "json", req, runtime), new GetAppDispatchInfoResponse({}));
  }

  async getCalenderSummary(dataId: string): Promise<GetCalenderSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCalenderSummaryHeaders({ });
    return await this.getCalenderSummaryWithOptions(dataId, headers, runtime);
  }

  async getCalenderSummaryWithOptions(dataId: string, headers: GetCalenderSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetCalenderSummaryResponse> {
    dataId = OpenApiUtil.getEncodeParam(dataId);
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
    return $tea.cast<GetCalenderSummaryResponse>(await this.doROARequest("GetCalenderSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/calendar/org/${dataId}`, "json", req, runtime), new GetCalenderSummaryResponse({}));
  }

  async getCommentList(publisherId: string, request: GetCommentListRequest): Promise<GetCommentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCommentListHeaders({ });
    return await this.getCommentListWithOptions(publisherId, request, headers, runtime);
  }

  async getCommentListWithOptions(publisherId: string, request: GetCommentListRequest, headers: GetCommentListHeaders, runtime: $Util.RuntimeOptions): Promise<GetCommentListResponse> {
    Util.validateModel(request);
    publisherId = OpenApiUtil.getEncodeParam(publisherId);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetCommentListResponse>(await this.doROARequest("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/publishers/${publisherId}/comments/list`, "json", req, runtime), new GetCommentListResponse({}));
  }

  async getConfBaseInfoByLogicalId(request: GetConfBaseInfoByLogicalIdRequest): Promise<GetConfBaseInfoByLogicalIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfBaseInfoByLogicalIdHeaders({ });
    return await this.getConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
  }

  async getConfBaseInfoByLogicalIdWithOptions(request: GetConfBaseInfoByLogicalIdRequest, headers: GetConfBaseInfoByLogicalIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetConfBaseInfoByLogicalIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.logicalConferenceId)) {
      query["logicalConferenceId"] = request.logicalConferenceId;
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
    return $tea.cast<GetConfBaseInfoByLogicalIdResponse>(await this.doROARequest("GetConfBaseInfoByLogicalId", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/conferences`, "json", req, runtime), new GetConfBaseInfoByLogicalIdResponse({}));
  }

  async getConferenceDetail(conferenceId: string): Promise<GetConferenceDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConferenceDetailHeaders({ });
    return await this.getConferenceDetailWithOptions(conferenceId, headers, runtime);
  }

  async getConferenceDetailWithOptions(conferenceId: string, headers: GetConferenceDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetConferenceDetailResponse> {
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
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
    return $tea.cast<GetConferenceDetailResponse>(await this.doROARequest("GetConferenceDetail", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/conferences/${conferenceId}`, "json", req, runtime), new GetConferenceDetailResponse({}));
  }

  async getDingReportDeptSummary(dataId: string, request: GetDingReportDeptSummaryRequest): Promise<GetDingReportDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingReportDeptSummaryHeaders({ });
    return await this.getDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getDingReportDeptSummaryWithOptions(dataId: string, request: GetDingReportDeptSummaryRequest, headers: GetDingReportDeptSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingReportDeptSummaryResponse> {
    Util.validateModel(request);
    dataId = OpenApiUtil.getEncodeParam(dataId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetDingReportDeptSummaryResponse>(await this.doROARequest("GetDingReportDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/report/dept/${dataId}`, "json", req, runtime), new GetDingReportDeptSummaryResponse({}));
  }

  async getDingReportSummary(dataId: string): Promise<GetDingReportSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingReportSummaryHeaders({ });
    return await this.getDingReportSummaryWithOptions(dataId, headers, runtime);
  }

  async getDingReportSummaryWithOptions(dataId: string, headers: GetDingReportSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingReportSummaryResponse> {
    dataId = OpenApiUtil.getEncodeParam(dataId);
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
    return $tea.cast<GetDingReportSummaryResponse>(await this.doROARequest("GetDingReportSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/datas/${dataId}/reports/organizations`, "json", req, runtime), new GetDingReportSummaryResponse({}));
  }

  async getDocCreatedDeptSummary(dataId: string, request: GetDocCreatedDeptSummaryRequest): Promise<GetDocCreatedDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocCreatedDeptSummaryHeaders({ });
    return await this.getDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getDocCreatedDeptSummaryWithOptions(dataId: string, request: GetDocCreatedDeptSummaryRequest, headers: GetDocCreatedDeptSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocCreatedDeptSummaryResponse> {
    Util.validateModel(request);
    dataId = OpenApiUtil.getEncodeParam(dataId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetDocCreatedDeptSummaryResponse>(await this.doROARequest("GetDocCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/doc/dept/${dataId}`, "json", req, runtime), new GetDocCreatedDeptSummaryResponse({}));
  }

  async getDocCreatedSummary(dataId: string): Promise<GetDocCreatedSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocCreatedSummaryHeaders({ });
    return await this.getDocCreatedSummaryWithOptions(dataId, headers, runtime);
  }

  async getDocCreatedSummaryWithOptions(dataId: string, headers: GetDocCreatedSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocCreatedSummaryResponse> {
    dataId = OpenApiUtil.getEncodeParam(dataId);
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
    return $tea.cast<GetDocCreatedSummaryResponse>(await this.doROARequest("GetDocCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/doc/org/${dataId}`, "json", req, runtime), new GetDocCreatedSummaryResponse({}));
  }

  async getGeneralFormCreatedDeptSummary(dataId: string, request: GetGeneralFormCreatedDeptSummaryRequest): Promise<GetGeneralFormCreatedDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGeneralFormCreatedDeptSummaryHeaders({ });
    return await this.getGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getGeneralFormCreatedDeptSummaryWithOptions(dataId: string, request: GetGeneralFormCreatedDeptSummaryRequest, headers: GetGeneralFormCreatedDeptSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetGeneralFormCreatedDeptSummaryResponse> {
    Util.validateModel(request);
    dataId = OpenApiUtil.getEncodeParam(dataId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetGeneralFormCreatedDeptSummaryResponse>(await this.doROARequest("GetGeneralFormCreatedDeptSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/generalForm/dept/${dataId}`, "json", req, runtime), new GetGeneralFormCreatedDeptSummaryResponse({}));
  }

  async getGeneralFormCreatedSummary(dataId: string): Promise<GetGeneralFormCreatedSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGeneralFormCreatedSummaryHeaders({ });
    return await this.getGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
  }

  async getGeneralFormCreatedSummaryWithOptions(dataId: string, headers: GetGeneralFormCreatedSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetGeneralFormCreatedSummaryResponse> {
    dataId = OpenApiUtil.getEncodeParam(dataId);
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
    return $tea.cast<GetGeneralFormCreatedSummaryResponse>(await this.doROARequest("GetGeneralFormCreatedSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/generalForm/org/${dataId}`, "json", req, runtime), new GetGeneralFormCreatedSummaryResponse({}));
  }

  async getGroupActiveInfo(request: GetGroupActiveInfoRequest): Promise<GetGroupActiveInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupActiveInfoHeaders({ });
    return await this.getGroupActiveInfoWithOptions(request, headers, runtime);
  }

  async getGroupActiveInfoWithOptions(request: GetGroupActiveInfoRequest, headers: GetGroupActiveInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetGroupActiveInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingGroupId)) {
      query["dingGroupId"] = request.dingGroupId;
    }

    if (!Util.isUnset(request.groupType)) {
      query["groupType"] = request.groupType;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
    return $tea.cast<GetGroupActiveInfoResponse>(await this.doROARequest("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/activeGroups`, "json", req, runtime), new GetGroupActiveInfoResponse({}));
  }

  async getInActiveUserList(request: GetInActiveUserListRequest): Promise<GetInActiveUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInActiveUserListHeaders({ });
    return await this.getInActiveUserListWithOptions(request, headers, runtime);
  }

  async getInActiveUserListWithOptions(request: GetInActiveUserListRequest, headers: GetInActiveUserListHeaders, runtime: $Util.RuntimeOptions): Promise<GetInActiveUserListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.statDate)) {
      body["statDate"] = request.statDate;
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
    return $tea.cast<GetInActiveUserListResponse>(await this.doROARequest("GetInActiveUserList", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/inactives/users/query`, "json", req, runtime), new GetInActiveUserListResponse({}));
  }

  async getLastOrgAuthData(request: GetLastOrgAuthDataRequest): Promise<GetLastOrgAuthDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLastOrgAuthDataHeaders({ });
    return await this.getLastOrgAuthDataWithOptions(request, headers, runtime);
  }

  async getLastOrgAuthDataWithOptions(request: GetLastOrgAuthDataRequest, headers: GetLastOrgAuthDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetLastOrgAuthDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<GetLastOrgAuthDataResponse>(await this.doROARequest("GetLastOrgAuthData", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/organizations/authInfos`, "json", req, runtime), new GetLastOrgAuthDataResponse({}));
  }

  async getOaOperatorLogList(request: GetOaOperatorLogListRequest): Promise<GetOaOperatorLogListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOaOperatorLogListHeaders({ });
    return await this.getOaOperatorLogListWithOptions(request, headers, runtime);
  }

  async getOaOperatorLogListWithOptions(request: GetOaOperatorLogListRequest, headers: GetOaOperatorLogListHeaders, runtime: $Util.RuntimeOptions): Promise<GetOaOperatorLogListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.categoryList)) {
      body["categoryList"] = request.categoryList;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
    return $tea.cast<GetOaOperatorLogListResponse>(await this.doROARequest("GetOaOperatorLogList", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/oaOperatorLogs/query`, "json", req, runtime), new GetOaOperatorLogListResponse({}));
  }

  async getPartnerTypeByParentId(parentId: string): Promise<GetPartnerTypeByParentIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPartnerTypeByParentIdHeaders({ });
    return await this.getPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
  }

  async getPartnerTypeByParentIdWithOptions(parentId: string, headers: GetPartnerTypeByParentIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetPartnerTypeByParentIdResponse> {
    parentId = OpenApiUtil.getEncodeParam(parentId);
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
    return $tea.cast<GetPartnerTypeByParentIdResponse>(await this.doROARequest("GetPartnerTypeByParentId", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/partnerLabels/${parentId}`, "json", req, runtime), new GetPartnerTypeByParentIdResponse({}));
  }

  async getPublisherSummary(dataId: string, request: GetPublisherSummaryRequest): Promise<GetPublisherSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPublisherSummaryHeaders({ });
    return await this.getPublisherSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getPublisherSummaryWithOptions(dataId: string, request: GetPublisherSummaryRequest, headers: GetPublisherSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetPublisherSummaryResponse> {
    Util.validateModel(request);
    dataId = OpenApiUtil.getEncodeParam(dataId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetPublisherSummaryResponse>(await this.doROARequest("GetPublisherSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/publisher/${dataId}`, "json", req, runtime), new GetPublisherSummaryResponse({}));
  }

  async getSignedDetailByPage(request: GetSignedDetailByPageRequest): Promise<GetSignedDetailByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignedDetailByPageHeaders({ });
    return await this.getSignedDetailByPageWithOptions(request, headers, runtime);
  }

  async getSignedDetailByPageWithOptions(request: GetSignedDetailByPageRequest, headers: GetSignedDetailByPageHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignedDetailByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.signStatus)) {
      query["signStatus"] = request.signStatus;
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
    return $tea.cast<GetSignedDetailByPageResponse>(await this.doROARequest("GetSignedDetailByPage", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/audits/users`, "json", req, runtime), new GetSignedDetailByPageResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetTrustDeviceListResponse>(await this.doROARequest("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/trustedDevices/query`, "json", req, runtime), new GetTrustDeviceListResponse({}));
  }

  async getUserAppVersionSummary(dataId: string, request: GetUserAppVersionSummaryRequest): Promise<GetUserAppVersionSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserAppVersionSummaryHeaders({ });
    return await this.getUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getUserAppVersionSummaryWithOptions(dataId: string, request: GetUserAppVersionSummaryRequest, headers: GetUserAppVersionSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserAppVersionSummaryResponse> {
    Util.validateModel(request);
    dataId = OpenApiUtil.getEncodeParam(dataId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetUserAppVersionSummaryResponse>(await this.doROARequest("GetUserAppVersionSummary", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/appVersion/org/${dataId}`, "json", req, runtime), new GetUserAppVersionSummaryResponse({}));
  }

  async getUserStayLength(request: GetUserStayLengthRequest): Promise<GetUserStayLengthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserStayLengthHeaders({ });
    return await this.getUserStayLengthWithOptions(request, headers, runtime);
  }

  async getUserStayLengthWithOptions(request: GetUserStayLengthRequest, headers: GetUserStayLengthHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserStayLengthResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
    return $tea.cast<GetUserStayLengthResponse>(await this.doROARequest("GetUserStayLength", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/data/users/stayTimes`, "json", req, runtime), new GetUserStayLengthResponse({}));
  }

  async listAuditLog(request: ListAuditLogRequest): Promise<ListAuditLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAuditLogHeaders({ });
    return await this.listAuditLogWithOptions(request, headers, runtime);
  }

  async listAuditLogWithOptions(request: ListAuditLogRequest, headers: ListAuditLogHeaders, runtime: $Util.RuntimeOptions): Promise<ListAuditLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endDate)) {
      query["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.nextBizId)) {
      query["nextBizId"] = request.nextBizId;
    }

    if (!Util.isUnset(request.nextGmtCreate)) {
      query["nextGmtCreate"] = request.nextGmtCreate;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startDate)) {
      query["startDate"] = request.startDate;
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
    return $tea.cast<ListAuditLogResponse>(await this.doROARequest("ListAuditLog", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/fileAuditLogs`, "json", req, runtime), new ListAuditLogResponse({}));
  }

  async listJoinOrgInfo(request: ListJoinOrgInfoRequest): Promise<ListJoinOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListJoinOrgInfoHeaders({ });
    return await this.listJoinOrgInfoWithOptions(request, headers, runtime);
  }

  async listJoinOrgInfoWithOptions(request: ListJoinOrgInfoRequest, headers: ListJoinOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<ListJoinOrgInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
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
    return $tea.cast<ListJoinOrgInfoResponse>(await this.doROARequest("ListJoinOrgInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/exclusiveAccounts/organizations/infos`, "json", req, runtime), new ListJoinOrgInfoResponse({}));
  }

  async listMiniAppAvailableVersion(request: ListMiniAppAvailableVersionRequest): Promise<ListMiniAppAvailableVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMiniAppAvailableVersionHeaders({ });
    return await this.listMiniAppAvailableVersionWithOptions(request, headers, runtime);
  }

  async listMiniAppAvailableVersionWithOptions(request: ListMiniAppAvailableVersionRequest, headers: ListMiniAppAvailableVersionHeaders, runtime: $Util.RuntimeOptions): Promise<ListMiniAppAvailableVersionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.versionTypeSet)) {
      body["versionTypeSet"] = request.versionTypeSet;
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
    return $tea.cast<ListMiniAppAvailableVersionResponse>(await this.doROARequest("ListMiniAppAvailableVersion", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/miniApps/versions/availableLists`, "json", req, runtime), new ListMiniAppAvailableVersionResponse({}));
  }

  async listMiniAppHistoryVersion(request: ListMiniAppHistoryVersionRequest): Promise<ListMiniAppHistoryVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMiniAppHistoryVersionHeaders({ });
    return await this.listMiniAppHistoryVersionWithOptions(request, headers, runtime);
  }

  async listMiniAppHistoryVersionWithOptions(request: ListMiniAppHistoryVersionRequest, headers: ListMiniAppHistoryVersionHeaders, runtime: $Util.RuntimeOptions): Promise<ListMiniAppHistoryVersionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
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
    return $tea.cast<ListMiniAppHistoryVersionResponse>(await this.doROARequest("ListMiniAppHistoryVersion", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/miniApps/versions/historyLists`, "json", req, runtime), new ListMiniAppHistoryVersionResponse({}));
  }

  async listPartnerRoles(parentId: string): Promise<ListPartnerRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPartnerRolesHeaders({ });
    return await this.listPartnerRolesWithOptions(parentId, headers, runtime);
  }

  async listPartnerRolesWithOptions(parentId: string, headers: ListPartnerRolesHeaders, runtime: $Util.RuntimeOptions): Promise<ListPartnerRolesResponse> {
    parentId = OpenApiUtil.getEncodeParam(parentId);
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
    return $tea.cast<ListPartnerRolesResponse>(await this.doROARequest("ListPartnerRoles", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/partners/roles/${parentId}`, "json", req, runtime), new ListPartnerRolesResponse({}));
  }

  async listPunchScheduleByConditionWithPaging(request: ListPunchScheduleByConditionWithPagingRequest): Promise<ListPunchScheduleByConditionWithPagingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPunchScheduleByConditionWithPagingHeaders({ });
    return await this.listPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
  }

  async listPunchScheduleByConditionWithPagingWithOptions(request: ListPunchScheduleByConditionWithPagingRequest, headers: ListPunchScheduleByConditionWithPagingHeaders, runtime: $Util.RuntimeOptions): Promise<ListPunchScheduleByConditionWithPagingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizInstanceId)) {
      body["bizInstanceId"] = request.bizInstanceId;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.scheduleDateEnd)) {
      body["scheduleDateEnd"] = request.scheduleDateEnd;
    }

    if (!Util.isUnset(request.scheduleDateStart)) {
      body["scheduleDateStart"] = request.scheduleDateStart;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<ListPunchScheduleByConditionWithPagingResponse>(await this.doROARequest("ListPunchScheduleByConditionWithPaging", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/punchSchedules/query`, "json", req, runtime), new ListPunchScheduleByConditionWithPagingResponse({}));
  }

  async publishFileChangeNotice(request: PublishFileChangeNoticeRequest): Promise<PublishFileChangeNoticeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PublishFileChangeNoticeHeaders({ });
    return await this.publishFileChangeNoticeWithOptions(request, headers, runtime);
  }

  async publishFileChangeNoticeWithOptions(request: PublishFileChangeNoticeRequest, headers: PublishFileChangeNoticeHeaders, runtime: $Util.RuntimeOptions): Promise<PublishFileChangeNoticeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileId)) {
      body["fileId"] = request.fileId;
    }

    if (!Util.isUnset(request.operateType)) {
      body["operateType"] = request.operateType;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
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
    return $tea.cast<PublishFileChangeNoticeResponse>(await this.doROARequest("PublishFileChangeNotice", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/comments/send`, "none", req, runtime), new PublishFileChangeNoticeResponse({}));
  }

  async pushBadge(request: PushBadgeRequest): Promise<PushBadgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushBadgeHeaders({ });
    return await this.pushBadgeWithOptions(request, headers, runtime);
  }

  async pushBadgeWithOptions(request: PushBadgeRequest, headers: PushBadgeHeaders, runtime: $Util.RuntimeOptions): Promise<PushBadgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.badgeItems)) {
      body["badgeItems"] = request.badgeItems;
    }

    if (!Util.isUnset(request.pushType)) {
      body["pushType"] = request.pushType;
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
    return $tea.cast<PushBadgeResponse>(await this.doROARequest("PushBadge", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/exclusiveDesigns/redPoints/push`, "json", req, runtime), new PushBadgeResponse({}));
  }

  async queryAcrossCloudStroageConfigs(request: QueryAcrossCloudStroageConfigsRequest): Promise<QueryAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAcrossCloudStroageConfigsHeaders({ });
    return await this.queryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
  }

  async queryAcrossCloudStroageConfigsWithOptions(request: QueryAcrossCloudStroageConfigsRequest, headers: QueryAcrossCloudStroageConfigsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAcrossCloudStroageConfigsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetCloudType)) {
      query["targetCloudType"] = request.targetCloudType;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<QueryAcrossCloudStroageConfigsResponse>(await this.doROARequest("QueryAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/fileStorages/acrossClouds/configurations`, "json", req, runtime), new QueryAcrossCloudStroageConfigsResponse({}));
  }

  async queryPartnerInfo(userId: string): Promise<QueryPartnerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPartnerInfoHeaders({ });
    return await this.queryPartnerInfoWithOptions(userId, headers, runtime);
  }

  async queryPartnerInfoWithOptions(userId: string, headers: QueryPartnerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPartnerInfoResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<QueryPartnerInfoResponse>(await this.doROARequest("QueryPartnerInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/partners/users/${userId}`, "json", req, runtime), new QueryPartnerInfoResponse({}));
  }

  async rollbackMiniAppVersion(request: RollbackMiniAppVersionRequest): Promise<RollbackMiniAppVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RollbackMiniAppVersionHeaders({ });
    return await this.rollbackMiniAppVersionWithOptions(request, headers, runtime);
  }

  async rollbackMiniAppVersionWithOptions(request: RollbackMiniAppVersionRequest, headers: RollbackMiniAppVersionHeaders, runtime: $Util.RuntimeOptions): Promise<RollbackMiniAppVersionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.rollbackVersion)) {
      body["rollbackVersion"] = request.rollbackVersion;
    }

    if (!Util.isUnset(request.targetVersion)) {
      body["targetVersion"] = request.targetVersion;
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
    return $tea.cast<RollbackMiniAppVersionResponse>(await this.doROARequest("RollbackMiniAppVersion", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/miniApps/versions/rollback`, "json", req, runtime), new RollbackMiniAppVersionResponse({}));
  }

  async saveAcrossCloudStroageConfigs(request: SaveAcrossCloudStroageConfigsRequest): Promise<SaveAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveAcrossCloudStroageConfigsHeaders({ });
    return await this.saveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
  }

  async saveAcrossCloudStroageConfigsWithOptions(request: SaveAcrossCloudStroageConfigsRequest, headers: SaveAcrossCloudStroageConfigsHeaders, runtime: $Util.RuntimeOptions): Promise<SaveAcrossCloudStroageConfigsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKeyId)) {
      body["accessKeyId"] = request.accessKeyId;
    }

    if (!Util.isUnset(request.accessKeySecret)) {
      body["accessKeySecret"] = request.accessKeySecret;
    }

    if (!Util.isUnset(request.bucketName)) {
      body["bucketName"] = request.bucketName;
    }

    if (!Util.isUnset(request.cloudType)) {
      body["cloudType"] = request.cloudType;
    }

    if (!Util.isUnset(request.endpoint)) {
      body["endpoint"] = request.endpoint;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<SaveAcrossCloudStroageConfigsResponse>(await this.doROARequest("SaveAcrossCloudStroageConfigs", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/fileStorages/acrossClouds/configurations`, "json", req, runtime), new SaveAcrossCloudStroageConfigsResponse({}));
  }

  async saveAndSubmitAuthInfo(request: SaveAndSubmitAuthInfoRequest): Promise<SaveAndSubmitAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveAndSubmitAuthInfoHeaders({ });
    return await this.saveAndSubmitAuthInfoWithOptions(request, headers, runtime);
  }

  async saveAndSubmitAuthInfoWithOptions(request: SaveAndSubmitAuthInfoRequest, headers: SaveAndSubmitAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SaveAndSubmitAuthInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.applyRemark)) {
      body["applyRemark"] = request.applyRemark;
    }

    if (!Util.isUnset(request.authorizeMediaId)) {
      body["authorizeMediaId"] = request.authorizeMediaId;
    }

    if (!Util.isUnset(request.industry)) {
      body["industry"] = request.industry;
    }

    if (!Util.isUnset(request.legalPerson)) {
      body["legalPerson"] = request.legalPerson;
    }

    if (!Util.isUnset(request.legalPersonIdCard)) {
      body["legalPersonIdCard"] = request.legalPersonIdCard;
    }

    if (!Util.isUnset(request.licenseMediaId)) {
      body["licenseMediaId"] = request.licenseMediaId;
    }

    if (!Util.isUnset(request.locCity)) {
      body["locCity"] = request.locCity;
    }

    if (!Util.isUnset(request.locCityName)) {
      body["locCityName"] = request.locCityName;
    }

    if (!Util.isUnset(request.locProvince)) {
      body["locProvince"] = request.locProvince;
    }

    if (!Util.isUnset(request.locProvinceName)) {
      body["locProvinceName"] = request.locProvinceName;
    }

    if (!Util.isUnset(request.mobileNum)) {
      body["mobileNum"] = request.mobileNum;
    }

    if (!Util.isUnset(request.orgName)) {
      body["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.organizationCode)) {
      body["organizationCode"] = request.organizationCode;
    }

    if (!Util.isUnset(request.organizationCodeMediaId)) {
      body["organizationCodeMediaId"] = request.organizationCodeMediaId;
    }

    if (!Util.isUnset(request.registLocation)) {
      body["registLocation"] = request.registLocation;
    }

    if (!Util.isUnset(request.registNum)) {
      body["registNum"] = request.registNum;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.unifiedSocialCredit)) {
      body["unifiedSocialCredit"] = request.unifiedSocialCredit;
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
    return $tea.cast<SaveAndSubmitAuthInfoResponse>(await this.doROARequest("SaveAndSubmitAuthInfo", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/ognizations/authInfos/saveAndSubmit`, "json", req, runtime), new SaveAndSubmitAuthInfoResponse({}));
  }

  async searchOrgInnerGroupInfo(request: SearchOrgInnerGroupInfoRequest): Promise<SearchOrgInnerGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchOrgInnerGroupInfoHeaders({ });
    return await this.searchOrgInnerGroupInfoWithOptions(request, headers, runtime);
  }

  async searchOrgInnerGroupInfoWithOptions(request: SearchOrgInnerGroupInfoRequest, headers: SearchOrgInnerGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SearchOrgInnerGroupInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createTimeEnd)) {
      query["createTimeEnd"] = request.createTimeEnd;
    }

    if (!Util.isUnset(request.createTimeStart)) {
      query["createTimeStart"] = request.createTimeStart;
    }

    if (!Util.isUnset(request.groupMembersCountEnd)) {
      query["groupMembersCountEnd"] = request.groupMembersCountEnd;
    }

    if (!Util.isUnset(request.groupMembersCountStart)) {
      query["groupMembersCountStart"] = request.groupMembersCountStart;
    }

    if (!Util.isUnset(request.groupName)) {
      query["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupOwner)) {
      query["groupOwner"] = request.groupOwner;
    }

    if (!Util.isUnset(request.lastActiveTimeEnd)) {
      query["lastActiveTimeEnd"] = request.lastActiveTimeEnd;
    }

    if (!Util.isUnset(request.lastActiveTimeStart)) {
      query["lastActiveTimeStart"] = request.lastActiveTimeStart;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      query["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageStart)) {
      query["pageStart"] = request.pageStart;
    }

    if (!Util.isUnset(request.syncToDingpan)) {
      query["syncToDingpan"] = request.syncToDingpan;
    }

    if (!Util.isUnset(request.uuid)) {
      query["uuid"] = request.uuid;
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
    return $tea.cast<SearchOrgInnerGroupInfoResponse>(await this.doROARequest("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", `/v1.0/exclusive/securities/orgGroupInfos`, "json", req, runtime), new SearchOrgInnerGroupInfoResponse({}));
  }

  async sendAppDing(request: SendAppDingRequest): Promise<SendAppDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendAppDingHeaders({ });
    return await this.sendAppDingWithOptions(request, headers, runtime);
  }

  async sendAppDingWithOptions(request: SendAppDingRequest, headers: SendAppDingHeaders, runtime: $Util.RuntimeOptions): Promise<SendAppDingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.userids)) {
      body["userids"] = request.userids;
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
    return $tea.cast<SendAppDingResponse>(await this.doROARequest("SendAppDing", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/appDings/send`, "none", req, runtime), new SendAppDingResponse({}));
  }

  async sendInvitation(request: SendInvitationRequest): Promise<SendInvitationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInvitationHeaders({ });
    return await this.sendInvitationWithOptions(request, headers, runtime);
  }

  async sendInvitationWithOptions(request: SendInvitationRequest, headers: SendInvitationHeaders, runtime: $Util.RuntimeOptions): Promise<SendInvitationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.orgAlias)) {
      body["orgAlias"] = request.orgAlias;
    }

    if (!Util.isUnset(request.partnerLabelId)) {
      body["partnerLabelId"] = request.partnerLabelId;
    }

    if (!Util.isUnset(request.partnerNum)) {
      body["partnerNum"] = request.partnerNum;
    }

    if (!Util.isUnset(request.phone)) {
      body["phone"] = request.phone;
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
    return $tea.cast<SendInvitationResponse>(await this.doROARequest("SendInvitation", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/partnerDepartments/invitations/send`, "none", req, runtime), new SendInvitationResponse({}));
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

    if (!Util.isUnset(request.labelIds)) {
      body["labelIds"] = request.labelIds;
    }

    if (!Util.isUnset(request.partnerNum)) {
      body["partnerNum"] = request.partnerNum;
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
    return $tea.cast<SetDeptPartnerTypeAndNumResponse>(await this.doROARequest("SetDeptPartnerTypeAndNum", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/partnerDepartments`, "none", req, runtime), new SetDeptPartnerTypeAndNumResponse({}));
  }

  async updateFileStatus(request: UpdateFileStatusRequest): Promise<UpdateFileStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFileStatusHeaders({ });
    return await this.updateFileStatusWithOptions(request, headers, runtime);
  }

  async updateFileStatusWithOptions(request: UpdateFileStatusRequest, headers: UpdateFileStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFileStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.requestIds)) {
      body["requestIds"] = request.requestIds;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<UpdateFileStatusResponse>(await this.doROARequest("UpdateFileStatus", "exclusive_1.0", "HTTP", "PUT", "AK", `/v1.0/exclusive/sending/files/status`, "json", req, runtime), new UpdateFileStatusResponse({}));
  }

  async updateMiniAppVersionStatus(request: UpdateMiniAppVersionStatusRequest): Promise<UpdateMiniAppVersionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMiniAppVersionStatusHeaders({ });
    return await this.updateMiniAppVersionStatusWithOptions(request, headers, runtime);
  }

  async updateMiniAppVersionStatusWithOptions(request: UpdateMiniAppVersionStatusRequest, headers: UpdateMiniAppVersionStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMiniAppVersionStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    if (!Util.isUnset(request.versionType)) {
      body["versionType"] = request.versionType;
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
    return $tea.cast<UpdateMiniAppVersionStatusResponse>(await this.doROARequest("UpdateMiniAppVersionStatus", "exclusive_1.0", "HTTP", "POST", "AK", `/v1.0/exclusive/miniApps/versions/versionStatus`, "json", req, runtime), new UpdateMiniAppVersionStatusResponse({}));
  }

  async updatePartnerVisibility(request: UpdatePartnerVisibilityRequest): Promise<UpdatePartnerVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePartnerVisibilityHeaders({ });
    return await this.updatePartnerVisibilityWithOptions(request, headers, runtime);
  }

  async updatePartnerVisibilityWithOptions(request: UpdatePartnerVisibilityRequest, headers: UpdatePartnerVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePartnerVisibilityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.labelId)) {
      body["labelId"] = request.labelId;
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
    return $tea.cast<UpdatePartnerVisibilityResponse>(await this.doROARequest("UpdatePartnerVisibility", "exclusive_1.0", "HTTP", "PUT", "AK", `/v1.0/exclusive/partnerDepartments/visibilityPartners`, "boolean", req, runtime), new UpdatePartnerVisibilityResponse({}));
  }

  async updateRoleVisibility(request: UpdateRoleVisibilityRequest): Promise<UpdateRoleVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRoleVisibilityHeaders({ });
    return await this.updateRoleVisibilityWithOptions(request, headers, runtime);
  }

  async updateRoleVisibilityWithOptions(request: UpdateRoleVisibilityRequest, headers: UpdateRoleVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRoleVisibilityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.labelId)) {
      body["labelId"] = request.labelId;
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
    return $tea.cast<UpdateRoleVisibilityResponse>(await this.doROARequest("UpdateRoleVisibility", "exclusive_1.0", "HTTP", "PUT", "AK", `/v1.0/exclusive/partnerDepartments/visibilityRoles`, "boolean", req, runtime), new UpdateRoleVisibilityResponse({}));
  }

  async updateStorageMode(request: UpdateStorageModeRequest): Promise<UpdateStorageModeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStorageModeHeaders({ });
    return await this.updateStorageModeWithOptions(request, headers, runtime);
  }

  async updateStorageModeWithOptions(request: UpdateStorageModeRequest, headers: UpdateStorageModeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateStorageModeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileStorageMode)) {
      body["fileStorageMode"] = request.fileStorageMode;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<UpdateStorageModeResponse>(await this.doROARequest("UpdateStorageMode", "exclusive_1.0", "HTTP", "PUT", "AK", `/v1.0/exclusive/fileStorages/acrossClouds/storageModes`, "json", req, runtime), new UpdateStorageModeResponse({}));
  }

}
