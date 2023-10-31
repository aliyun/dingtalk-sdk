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
  statusCode: number;
  body: AddOrgResponseBody;
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
      body: AddOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveProcessCallbackHeaders extends $tea.Model {
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

export class ApproveProcessCallbackRequest extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  request?: ApproveProcessCallbackRequestRequest;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      request: 'request',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      request: ApproveProcessCallbackRequestRequest,
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveProcessCallbackResponseBody extends $tea.Model {
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

export class ApproveProcessCallbackResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ApproveProcessCallbackResponseBody;
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
      body: ApproveProcessCallbackResponseBody,
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
  statusCode: number;
  body: BanOrOpenGroupWordsResponseBody;
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
      body: BanOrOpenGroupWordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCategoryAndBindingGroupsHeaders extends $tea.Model {
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

export class CreateCategoryAndBindingGroupsRequest extends $tea.Model {
  categoryName?: string;
  groupIds?: number[];
  static names(): { [key: string]: string } {
    return {
      categoryName: 'categoryName',
      groupIds: 'groupIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryName: 'string',
      groupIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCategoryAndBindingGroupsResponseBody extends $tea.Model {
  id?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCategoryAndBindingGroupsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateCategoryAndBindingGroupsResponseBody;
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
      body: CreateCategoryAndBindingGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMessageCategoryHeaders extends $tea.Model {
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

export class CreateMessageCategoryRequest extends $tea.Model {
  categoryName?: string;
  groupIds?: string[];
  static names(): { [key: string]: string } {
    return {
      categoryName: 'categoryName',
      groupIds: 'groupIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryName: 'string',
      groupIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMessageCategoryResponseBody extends $tea.Model {
  id?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMessageCategoryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateMessageCategoryResponseBody;
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
      body: CreateMessageCategoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRuleHeaders extends $tea.Model {
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

export class CreateRuleRequest extends $tea.Model {
  customPlan?: CreateRuleRequestCustomPlan;
  static names(): { [key: string]: string } {
    return {
      customPlan: 'customPlan',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customPlan: CreateRuleRequestCustomPlan,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRuleResponseBody extends $tea.Model {
  id?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRuleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateRuleResponseBody;
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
      body: CreateRuleResponseBody,
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
  statusCode: number;
  body: CreateTrustedDeviceResponseBody;
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
  statusCode: number;
  body: CreateTrustedDeviceBatchResponseBody;
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
  statusCode: number;
  body: DeleteAcrossCloudStroageConfigsResponseBody;
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
  statusCode: number;
  body: boolean;
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
      body: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTrustedDeviceHeaders extends $tea.Model {
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

export class DeleteTrustedDeviceRequest extends $tea.Model {
  kickOff?: boolean;
  macAddress?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      kickOff: 'kickOff',
      macAddress: 'macAddress',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kickOff: 'boolean',
      macAddress: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTrustedDeviceResponseBody extends $tea.Model {
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

export class DeleteTrustedDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteTrustedDeviceResponseBody;
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
      body: DeleteTrustedDeviceResponseBody,
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
  statusCode: number;
  body: DistributePartnerAppResponseBody;
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
  statusCode: number;
  body: ExclusiveCreateDingPortalResponseBody;
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
  statusCode: number;
  body: FileStorageActiveStorageResponseBody;
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
  statusCode: number;
  body: FileStorageCheckConnectionResponseBody;
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
  statusCode: number;
  body: FileStorageGetQuotaDataResponseBody;
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
  statusCode: number;
  body: FileStorageGetStorageStateResponseBody;
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
  statusCode: number;
  body: FileStorageUpdateStorageResponseBody;
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
  statusCode: number;
  body: GenerateDarkWaterMarkResponseBody;
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
      body: GenerateDarkWaterMarkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountTransferListHeaders extends $tea.Model {
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

export class GetAccountTransferListRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountTransferListResponseBody extends $tea.Model {
  itemList?: GetAccountTransferListResponseBodyItemList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      itemList: 'itemList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemList: { 'type': 'array', 'itemType': GetAccountTransferListResponseBodyItemList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountTransferListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAccountTransferListResponseBody;
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
      body: GetAccountTransferListResponseBody,
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
  statusCode: number;
  body: GetActiveUserSummaryResponseBody;
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
  statusCode: number;
  body: GetAgentIdByRelatedAppIdResponseBody;
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
  statusCode: number;
  body: GetAllLabelableDeptsResponseBody;
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
  statusCode: number;
  body: GetAppDispatchInfoResponseBody;
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
  statusCode: number;
  body: GetCalenderSummaryResponseBody;
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
  statusCode: number;
  body: GetCommentListResponseBody;
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
  statusCode: number;
  body: GetConfBaseInfoByLogicalIdResponseBody;
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
  statusCode: number;
  body: GetConferenceDetailResponseBody;
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
  statusCode: number;
  body: GetDingReportDeptSummaryResponseBody;
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
  statusCode: number;
  body: GetDingReportSummaryResponseBody;
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
  statusCode: number;
  body: GetDocCreatedDeptSummaryResponseBody;
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
  statusCode: number;
  body: GetDocCreatedSummaryResponseBody;
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
      body: GetDocCreatedSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetExclusiveAccountAllOrgListHeaders extends $tea.Model {
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

export class GetExclusiveAccountAllOrgListRequest extends $tea.Model {
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

export class GetExclusiveAccountAllOrgListResponseBody extends $tea.Model {
  orgInfoList?: GetExclusiveAccountAllOrgListResponseBodyOrgInfoList[];
  static names(): { [key: string]: string } {
    return {
      orgInfoList: 'orgInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgInfoList: { 'type': 'array', 'itemType': GetExclusiveAccountAllOrgListResponseBodyOrgInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetExclusiveAccountAllOrgListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetExclusiveAccountAllOrgListResponseBody;
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
      body: GetExclusiveAccountAllOrgListResponseBody,
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
  statusCode: number;
  body: GetGeneralFormCreatedDeptSummaryResponseBody;
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
  statusCode: number;
  body: GetGeneralFormCreatedSummaryResponseBody;
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
  statusCode: number;
  body: GetGroupActiveInfoResponseBody;
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
  statusCode: number;
  body: GetInActiveUserListResponseBody;
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
  statusCode: number;
  body: GetLastOrgAuthDataResponseBody;
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
  statusCode: number;
  body: GetOaOperatorLogListResponseBody;
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
      body: GetOaOperatorLogListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutGroupsByPageHeaders extends $tea.Model {
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

export class GetOutGroupsByPageRequest extends $tea.Model {
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

export class GetOutGroupsByPageResponseBody extends $tea.Model {
  responseBody?: GetOutGroupsByPageResponseBodyResponseBody;
  static names(): { [key: string]: string } {
    return {
      responseBody: 'responseBody',
    };
  }

  static types(): { [key: string]: any } {
    return {
      responseBody: GetOutGroupsByPageResponseBodyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutGroupsByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOutGroupsByPageResponseBody;
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
      body: GetOutGroupsByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutsideAuditGroupMessageByPageHeaders extends $tea.Model {
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

export class GetOutsideAuditGroupMessageByPageRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutsideAuditGroupMessageByPageResponseBody extends $tea.Model {
  responseBody?: GetOutsideAuditGroupMessageByPageResponseBodyResponseBody;
  static names(): { [key: string]: string } {
    return {
      responseBody: 'responseBody',
    };
  }

  static types(): { [key: string]: any } {
    return {
      responseBody: GetOutsideAuditGroupMessageByPageResponseBodyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutsideAuditGroupMessageByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOutsideAuditGroupMessageByPageResponseBody;
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
      body: GetOutsideAuditGroupMessageByPageResponseBody,
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
  statusCode: number;
  body: GetPartnerTypeByParentIdResponseBody;
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
      body: GetPartnerTypeByParentIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublicDevicesHeaders extends $tea.Model {
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

export class GetPublicDevicesRequest extends $tea.Model {
  endTime?: number;
  macAddress?: string;
  pageNumber?: number;
  pageSize?: number;
  platform?: string;
  startTime?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      macAddress: 'macAddress',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      platform: 'platform',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      macAddress: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      platform: 'string',
      startTime: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublicDevicesResponseBody extends $tea.Model {
  data?: GetPublicDevicesResponseBodyData[];
  dataCnt?: number;
  totalCnt?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      dataCnt: 'dataCnt',
      totalCnt: 'totalCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetPublicDevicesResponseBodyData },
      dataCnt: 'number',
      totalCnt: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublicDevicesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPublicDevicesResponseBody;
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
      body: GetPublicDevicesResponseBody,
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
  statusCode: number;
  body: GetPublisherSummaryResponseBody;
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
      body: GetPublisherSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRealPeopleRecordsHeaders extends $tea.Model {
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

export class GetRealPeopleRecordsRequest extends $tea.Model {
  agentId?: number;
  fromTime?: number;
  maxResults?: number;
  nextToken?: number;
  personIdentification?: number;
  scene?: number;
  toTime?: number;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      fromTime: 'fromTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      personIdentification: 'personIdentification',
      scene: 'scene',
      toTime: 'toTime',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      fromTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      personIdentification: 'number',
      scene: 'number',
      toTime: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRealPeopleRecordsResponseBody extends $tea.Model {
  data?: GetRealPeopleRecordsResponseBodyData[];
  nextToken?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      nextToken: 'nextToken',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetRealPeopleRecordsResponseBodyData },
      nextToken: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRealPeopleRecordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRealPeopleRecordsResponseBody;
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
      body: GetRealPeopleRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecognizeRecordsHeaders extends $tea.Model {
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

export class GetRecognizeRecordsRequest extends $tea.Model {
  agentId?: number;
  faceCompareResult?: number;
  fromTime?: number;
  maxResults?: number;
  nextToken?: number;
  toTime?: number;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      faceCompareResult: 'faceCompareResult',
      fromTime: 'fromTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      toTime: 'toTime',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      faceCompareResult: 'number',
      fromTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      toTime: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecognizeRecordsResponseBody extends $tea.Model {
  data?: GetRecognizeRecordsResponseBodyData[];
  nextToken?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      nextToken: 'nextToken',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetRecognizeRecordsResponseBodyData },
      nextToken: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecognizeRecordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRecognizeRecordsResponseBody;
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
      body: GetRecognizeRecordsResponseBody,
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
  statusCode: number;
  body: GetSignedDetailByPageResponseBody;
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
  statusCode: number;
  body: GetTrustDeviceListResponseBody;
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
  statusCode: number;
  body: GetUserAppVersionSummaryResponseBody;
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
      body: GetUserAppVersionSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserFaceStateHeaders extends $tea.Model {
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

export class GetUserFaceStateRequest extends $tea.Model {
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

export class GetUserFaceStateResponseBody extends $tea.Model {
  data?: GetUserFaceStateResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetUserFaceStateResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserFaceStateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserFaceStateResponseBody;
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
      body: GetUserFaceStateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealPeopleStateHeaders extends $tea.Model {
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

export class GetUserRealPeopleStateRequest extends $tea.Model {
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

export class GetUserRealPeopleStateResponseBody extends $tea.Model {
  data?: GetUserRealPeopleStateResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetUserRealPeopleStateResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealPeopleStateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserRealPeopleStateResponseBody;
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
      body: GetUserRealPeopleStateResponseBody,
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
  statusCode: number;
  body: GetUserStayLengthResponseBody;
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
  statusCode: number;
  body: ListAuditLogResponseBody;
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
      body: ListAuditLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCategorysHeaders extends $tea.Model {
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

export class ListCategorysRequest extends $tea.Model {
  body?: ListCategorysRequestBody;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: ListCategorysRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCategorysShrinkRequest extends $tea.Model {
  bodyShrink?: string;
  static names(): { [key: string]: string } {
    return {
      bodyShrink: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bodyShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCategorysResponseBody extends $tea.Model {
  detailModelList?: { [key: string]: string }[];
  static names(): { [key: string]: string } {
    return {
      detailModelList: 'detailModelList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailModelList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCategorysResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListCategorysResponseBody;
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
      body: ListCategorysResponseBody,
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
  statusCode: number;
  body: ListJoinOrgInfoResponseBody;
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
  statusCode: number;
  body: ListMiniAppAvailableVersionResponseBody;
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
  statusCode: number;
  body: ListMiniAppHistoryVersionResponseBody;
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
  statusCode: number;
  body: ListPartnerRolesResponseBody;
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
  statusCode: number;
  body: ListPunchScheduleByConditionWithPagingResponseBody;
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
      body: ListPunchScheduleByConditionWithPagingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRulesHeaders extends $tea.Model {
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

export class ListRulesRequest extends $tea.Model {
  body?: ListRulesRequestBody;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: ListRulesRequestBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRulesShrinkRequest extends $tea.Model {
  bodyShrink?: string;
  static names(): { [key: string]: string } {
    return {
      bodyShrink: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bodyShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRulesResponseBody extends $tea.Model {
  detailModelList?: { [key: string]: string }[];
  static names(): { [key: string]: string } {
    return {
      detailModelList: 'detailModelList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailModelList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRulesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListRulesResponseBody;
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
      body: ListRulesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LogoutHeaders extends $tea.Model {
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

export class LogoutRequest extends $tea.Model {
  deviceType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceType: 'deviceType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LogoutResponseBody extends $tea.Model {
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

export class LogoutResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: LogoutResponseBody;
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
      body: LogoutResponseBody,
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishRuleHeaders extends $tea.Model {
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

export class PublishRuleRequest extends $tea.Model {
  status?: number;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishRuleResponseBody extends $tea.Model {
  isPublish?: boolean;
  static names(): { [key: string]: string } {
    return {
      isPublish: 'isPublish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isPublish: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishRuleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PublishRuleResponseBody;
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
      body: PublishRuleResponseBody,
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
  statusCode: number;
  body: PushBadgeResponseBody;
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
  statusCode: number;
  body: QueryAcrossCloudStroageConfigsResponseBody;
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
  statusCode: number;
  body: QueryPartnerInfoResponseBody;
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
      body: QueryPartnerInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserBehaviorHeaders extends $tea.Model {
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

export class QueryUserBehaviorRequest extends $tea.Model {
  endTime?: number;
  pageNumber?: number;
  pageSize?: number;
  platform?: number;
  startTime?: number;
  type?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      platform: 'platform',
      startTime: 'startTime',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      platform: 'number',
      startTime: 'number',
      type: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserBehaviorResponseBody extends $tea.Model {
  data?: QueryUserBehaviorResponseBodyData[];
  dataCnt?: number;
  totalCnt?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      dataCnt: 'dataCnt',
      totalCnt: 'totalCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': QueryUserBehaviorResponseBodyData },
      dataCnt: 'number',
      totalCnt: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserBehaviorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserBehaviorResponseBody;
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
      body: QueryUserBehaviorResponseBody,
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
  statusCode: number;
  body: RollbackMiniAppVersionResponseBody;
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
  statusCode: number;
  body: SaveAcrossCloudStroageConfigsResponseBody;
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
  statusCode: number;
  body: SaveAndSubmitAuthInfoResponseBody;
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
      body: SaveAndSubmitAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveOpenTerminalInfoHeaders extends $tea.Model {
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

export class SaveOpenTerminalInfoRequest extends $tea.Model {
  corpId?: string;
  logSource?: string;
  logType?: string;
  openExt?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      logSource: 'logSource',
      logType: 'logType',
      openExt: 'openExt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      logSource: 'string',
      logType: 'string',
      openExt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveOpenTerminalInfoResponseBody extends $tea.Model {
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

export class SaveOpenTerminalInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveOpenTerminalInfoResponseBody;
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
      body: SaveOpenTerminalInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveWhiteAppHeaders extends $tea.Model {
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

export class SaveWhiteAppRequest extends $tea.Model {
  agentIdList?: number[];
  agentIdMap?: string;
  operation?: string;
  static names(): { [key: string]: string } {
    return {
      agentIdList: 'agentIdList',
      agentIdMap: 'agentIdMap',
      operation: 'operation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentIdList: { 'type': 'array', 'itemType': 'number' },
      agentIdMap: 'string',
      operation: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveWhiteAppResponseBody extends $tea.Model {
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

export class SaveWhiteAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveWhiteAppResponseBody;
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
      body: SaveWhiteAppResponseBody,
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
  statusCode: number;
  body: SearchOrgInnerGroupInfoResponseBody;
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPhoneDingHeaders extends $tea.Model {
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

export class SendPhoneDingRequest extends $tea.Model {
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

export class SendPhoneDingResponseBody extends $tea.Model {
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

export class SendPhoneDingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendPhoneDingResponseBody;
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
      body: SendPhoneDingResponseBody,
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCategoryNameHeaders extends $tea.Model {
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

export class UpdateCategoryNameRequest extends $tea.Model {
  currentCategoryName?: string;
  targetCategoryName?: string;
  static names(): { [key: string]: string } {
    return {
      currentCategoryName: 'currentCategoryName',
      targetCategoryName: 'targetCategoryName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentCategoryName: 'string',
      targetCategoryName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCategoryNameResponseBody extends $tea.Model {
  status?: number;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCategoryNameResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateCategoryNameResponseBody;
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
      body: UpdateCategoryNameResponseBody,
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
  statusCode: number;
  body: UpdateFileStatusResponseBody;
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
  statusCode: number;
  body: UpdateMiniAppVersionStatusResponseBody;
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
  statusCode: number;
  body: boolean;
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
  statusCode: number;
  body: boolean;
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
  statusCode: number;
  body: UpdateStorageModeResponseBody;
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
      body: UpdateStorageModeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveProcessCallbackRequestRequest extends $tea.Model {
  approveResult?: string;
  approveType?: string;
  approvers?: string[];
  createTime?: number;
  eventType?: string;
  finishTime?: number;
  params?: string;
  processInstanceId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      approveResult: 'approveResult',
      approveType: 'approveType',
      approvers: 'approvers',
      createTime: 'createTime',
      eventType: 'eventType',
      finishTime: 'finishTime',
      params: 'params',
      processInstanceId: 'processInstanceId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveResult: 'string',
      approveType: 'string',
      approvers: { 'type': 'array', 'itemType': 'string' },
      createTime: 'number',
      eventType: 'string',
      finishTime: 'number',
      params: 'string',
      processInstanceId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRuleRequestCustomPlan extends $tea.Model {
  currentCategoryList?: string[];
  deptIds?: number[];
  planName?: string;
  unSelectCategoryList?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      currentCategoryList: 'currentCategoryList',
      deptIds: 'deptIds',
      planName: 'planName',
      unSelectCategoryList: 'unSelectCategoryList',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentCategoryList: { 'type': 'array', 'itemType': 'string' },
      deptIds: { 'type': 'array', 'itemType': 'number' },
      planName: 'string',
      unSelectCategoryList: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
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

export class GetAccountTransferListResponseBodyItemList extends $tea.Model {
  deptName?: number;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'number',
      name: 'string',
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

export class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList extends $tea.Model {
  corpId?: string;
  isMainOrg?: boolean;
  logoUrl?: string;
  orgFullName?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isMainOrg: 'isMainOrg',
      logoUrl: 'logoUrl',
      orgFullName: 'orgFullName',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isMainOrg: 'boolean',
      logoUrl: 'string',
      orgFullName: 'string',
      orgName: 'string',
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

export class GetOutGroupsByPageResponseBodyResponseBodyGroupList extends $tea.Model {
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

export class GetOutGroupsByPageResponseBodyResponseBody extends $tea.Model {
  groupList?: GetOutGroupsByPageResponseBodyResponseBodyGroupList[];
  total?: number;
  static names(): { [key: string]: string } {
    return {
      groupList: 'groupList',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupList: { 'type': 'array', 'itemType': GetOutGroupsByPageResponseBodyResponseBodyGroupList },
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender extends $tea.Model {
  id?: string;
  idType?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      idType: 'idType',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      idType: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList extends $tea.Model {
  content?: string;
  contentType?: string;
  createAt?: string;
  openConversationId?: string;
  sender?: GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      contentType: 'contentType',
      createAt: 'createAt',
      openConversationId: 'openConversationId',
      sender: 'sender',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      contentType: 'string',
      createAt: 'string',
      openConversationId: 'string',
      sender: GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOutsideAuditGroupMessageByPageResponseBodyResponseBody extends $tea.Model {
  messageList?: GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      messageList: 'messageList',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageList: { 'type': 'array', 'itemType': GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList },
      nextToken: 'string',
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

export class GetPublicDevicesResponseBodyDataDeviceDepts extends $tea.Model {
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

export class GetPublicDevicesResponseBodyDataDeviceRoles extends $tea.Model {
  name?: string;
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublicDevicesResponseBodyDataDeviceStaffs extends $tea.Model {
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

export class GetPublicDevicesResponseBodyData extends $tea.Model {
  deviceDepts?: GetPublicDevicesResponseBodyDataDeviceDepts[];
  deviceRoles?: GetPublicDevicesResponseBodyDataDeviceRoles[];
  deviceScopeType?: number;
  deviceStaffs?: GetPublicDevicesResponseBodyDataDeviceStaffs[];
  gmtCreate?: number;
  gmtModified?: number;
  macAddress?: string;
  platform?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      deviceDepts: 'deviceDepts',
      deviceRoles: 'deviceRoles',
      deviceScopeType: 'deviceScopeType',
      deviceStaffs: 'deviceStaffs',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      macAddress: 'macAddress',
      platform: 'platform',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceDepts: { 'type': 'array', 'itemType': GetPublicDevicesResponseBodyDataDeviceDepts },
      deviceRoles: { 'type': 'array', 'itemType': GetPublicDevicesResponseBodyDataDeviceRoles },
      deviceScopeType: 'number',
      deviceStaffs: { 'type': 'array', 'itemType': GetPublicDevicesResponseBodyDataDeviceStaffs },
      gmtCreate: 'number',
      gmtModified: 'number',
      macAddress: 'string',
      platform: 'string',
      title: 'string',
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

export class GetRealPeopleRecordsResponseBodyData extends $tea.Model {
  agentId?: number;
  invokeTime?: number;
  personIdentification?: number;
  platform?: number;
  scene?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      invokeTime: 'invokeTime',
      personIdentification: 'personIdentification',
      platform: 'platform',
      scene: 'scene',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      invokeTime: 'number',
      personIdentification: 'number',
      platform: 'number',
      scene: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecognizeRecordsResponseBodyData extends $tea.Model {
  agentId?: number;
  faceCompareResult?: number;
  invokeTime?: number;
  platform?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      faceCompareResult: 'faceCompareResult',
      invokeTime: 'invokeTime',
      platform: 'platform',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      faceCompareResult: 'number',
      invokeTime: 'number',
      platform: 'number',
      userId: 'string',
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

export class GetUserFaceStateResponseBodyData extends $tea.Model {
  state?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      state: 'state',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      state: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealPeopleStateResponseBodyData extends $tea.Model {
  state?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      state: 'state',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      state: 'number',
      userId: 'string',
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
  docMobileUrl?: string;
  docPcUrl?: string;
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
  prevWorkSpaceId?: number;
  prevWorkSpaceMobileUrl?: string;
  prevWorkSpaceName?: string;
  prevWorkSpacePcUrl?: string;
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
  workSpaceId?: number;
  workSpaceMobileUrl?: string;
  workSpaceName?: string;
  workSpacePcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      actionView: 'actionView',
      bizId: 'bizId',
      docMemberList: 'docMemberList',
      docMobileUrl: 'docMobileUrl',
      docPcUrl: 'docPcUrl',
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
      prevWorkSpaceId: 'prevWorkSpaceId',
      prevWorkSpaceMobileUrl: 'prevWorkSpaceMobileUrl',
      prevWorkSpaceName: 'prevWorkSpaceName',
      prevWorkSpacePcUrl: 'prevWorkSpacePcUrl',
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
      workSpaceId: 'workSpaceId',
      workSpaceMobileUrl: 'workSpaceMobileUrl',
      workSpaceName: 'workSpaceName',
      workSpacePcUrl: 'workSpacePcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'number',
      actionView: 'string',
      bizId: 'string',
      docMemberList: { 'type': 'array', 'itemType': ListAuditLogResponseBodyListDocMemberList },
      docMobileUrl: 'string',
      docPcUrl: 'string',
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
      prevWorkSpaceId: 'number',
      prevWorkSpaceMobileUrl: 'string',
      prevWorkSpaceName: 'string',
      prevWorkSpacePcUrl: 'string',
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
      workSpaceId: 'number',
      workSpaceMobileUrl: 'string',
      workSpaceName: 'string',
      workSpacePcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCategorysRequestBody extends $tea.Model {
  status?: number;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
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

export class ListRulesRequestBody extends $tea.Model {
  status?: number;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
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

export class QueryUserBehaviorResponseBodyData extends $tea.Model {
  pictureUrl?: string;
  platform?: number;
  scene?: string;
  time?: number;
  type?: number;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      pictureUrl: 'pictureUrl',
      platform: 'platform',
      scene: 'scene',
      time: 'time',
      type: 'type',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pictureUrl: 'string',
      platform: 'number',
      scene: 'string',
      time: 'number',
      type: 'number',
      userId: 'string',
      userName: 'string',
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
    let params = new $OpenApi.Params({
      action: "AddOrg",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/orgnizations`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddOrgResponse>(await this.execute(params, req, runtime), new AddOrgResponse({}));
  }

  async addOrg(request: AddOrgRequest): Promise<AddOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOrgHeaders({ });
    return await this.addOrgWithOptions(request, headers, runtime);
  }

  async approveProcessCallbackWithOptions(request: ApproveProcessCallbackRequest, headers: ApproveProcessCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<ApproveProcessCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKeyId)) {
      body["accessKeyId"] = request.accessKeyId;
    }

    if (!Util.isUnset(request.accessKeySecret)) {
      body["accessKeySecret"] = request.accessKeySecret;
    }

    if (!Util.isUnset(request.request)) {
      body["request"] = request.request;
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
    let params = new $OpenApi.Params({
      action: "ApproveProcessCallback",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/approvalResults/callback`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ApproveProcessCallbackResponse>(await this.execute(params, req, runtime), new ApproveProcessCallbackResponse({}));
  }

  async approveProcessCallback(request: ApproveProcessCallbackRequest): Promise<ApproveProcessCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApproveProcessCallbackHeaders({ });
    return await this.approveProcessCallbackWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "BanOrOpenGroupWords",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BanOrOpenGroupWordsResponse>(await this.execute(params, req, runtime), new BanOrOpenGroupWordsResponse({}));
  }

  async banOrOpenGroupWords(request: BanOrOpenGroupWordsRequest): Promise<BanOrOpenGroupWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BanOrOpenGroupWordsHeaders({ });
    return await this.banOrOpenGroupWordsWithOptions(request, headers, runtime);
  }

  async createCategoryAndBindingGroupsWithOptions(request: CreateCategoryAndBindingGroupsRequest, headers: CreateCategoryAndBindingGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCategoryAndBindingGroupsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.categoryName)) {
      body["categoryName"] = request.categoryName;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
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
      action: "CreateCategoryAndBindingGroups",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/categories/createAndBind`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCategoryAndBindingGroupsResponse>(await this.execute(params, req, runtime), new CreateCategoryAndBindingGroupsResponse({}));
  }

  async createCategoryAndBindingGroups(request: CreateCategoryAndBindingGroupsRequest): Promise<CreateCategoryAndBindingGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCategoryAndBindingGroupsHeaders({ });
    return await this.createCategoryAndBindingGroupsWithOptions(request, headers, runtime);
  }

  async createMessageCategoryWithOptions(request: CreateMessageCategoryRequest, headers: CreateMessageCategoryHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMessageCategoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.categoryName)) {
      body["categoryName"] = request.categoryName;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
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
      action: "CreateMessageCategory",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/categories/create`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateMessageCategoryResponse>(await this.execute(params, req, runtime), new CreateMessageCategoryResponse({}));
  }

  async createMessageCategory(request: CreateMessageCategoryRequest): Promise<CreateMessageCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMessageCategoryHeaders({ });
    return await this.createMessageCategoryWithOptions(request, headers, runtime);
  }

  async createRuleWithOptions(request: CreateRuleRequest, headers: CreateRuleHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRuleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customPlan)) {
      body["customPlan"] = request.customPlan;
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
      action: "CreateRule",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/rules`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateRuleResponse>(await this.execute(params, req, runtime), new CreateRuleResponse({}));
  }

  async createRule(request: CreateRuleRequest): Promise<CreateRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRuleHeaders({ });
    return await this.createRuleWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CreateTrustedDevice",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/trustedDevices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTrustedDeviceResponse>(await this.execute(params, req, runtime), new CreateTrustedDeviceResponse({}));
  }

  async createTrustedDevice(request: CreateTrustedDeviceRequest): Promise<CreateTrustedDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceHeaders({ });
    return await this.createTrustedDeviceWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CreateTrustedDeviceBatch",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/trusts/devices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTrustedDeviceBatchResponse>(await this.execute(params, req, runtime), new CreateTrustedDeviceBatchResponse({}));
  }

  async createTrustedDeviceBatch(request: CreateTrustedDeviceBatchRequest): Promise<CreateTrustedDeviceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceBatchHeaders({ });
    return await this.createTrustedDeviceBatchWithOptions(request, headers, runtime);
  }

  async deleteAcrossCloudStroageConfigsWithOptions(targetCorpId: string, headers: DeleteAcrossCloudStroageConfigsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAcrossCloudStroageConfigsResponse> {
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
      action: "DeleteAcrossCloudStroageConfigs",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/acrossClouds/configurations/${targetCorpId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteAcrossCloudStroageConfigsResponse>(await this.execute(params, req, runtime), new DeleteAcrossCloudStroageConfigsResponse({}));
  }

  async deleteAcrossCloudStroageConfigs(targetCorpId: string): Promise<DeleteAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAcrossCloudStroageConfigsHeaders({ });
    return await this.deleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
  }

  async deleteCommentWithOptions(publisherId: string, commentId: string, headers: DeleteCommentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCommentResponse> {
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
      action: "DeleteComment",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/publishers/${publisherId}/comments/${commentId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "boolean",
    });
    return $tea.cast<DeleteCommentResponse>(await this.execute(params, req, runtime), new DeleteCommentResponse({}));
  }

  async deleteComment(publisherId: string, commentId: string): Promise<DeleteCommentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCommentHeaders({ });
    return await this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
  }

  async deleteTrustedDeviceWithOptions(request: DeleteTrustedDeviceRequest, headers: DeleteTrustedDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTrustedDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.kickOff)) {
      body["kickOff"] = request.kickOff;
    }

    if (!Util.isUnset(request.macAddress)) {
      body["macAddress"] = request.macAddress;
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
      action: "DeleteTrustedDevice",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/trustedDevices/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteTrustedDeviceResponse>(await this.execute(params, req, runtime), new DeleteTrustedDeviceResponse({}));
  }

  async deleteTrustedDevice(request: DeleteTrustedDeviceRequest): Promise<DeleteTrustedDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTrustedDeviceHeaders({ });
    return await this.deleteTrustedDeviceWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "DistributePartnerApp",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partners/applications/distribute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DistributePartnerAppResponse>(await this.execute(params, req, runtime), new DistributePartnerAppResponse({}));
  }

  async distributePartnerApp(request: DistributePartnerAppRequest): Promise<DistributePartnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DistributePartnerAppHeaders({ });
    return await this.distributePartnerAppWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ExclusiveCreateDingPortal",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/workbenches/templates/spread`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExclusiveCreateDingPortalResponse>(await this.execute(params, req, runtime), new ExclusiveCreateDingPortalResponse({}));
  }

  async exclusiveCreateDingPortal(request: ExclusiveCreateDingPortalRequest): Promise<ExclusiveCreateDingPortalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExclusiveCreateDingPortalHeaders({ });
    return await this.exclusiveCreateDingPortalWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "FileStorageActiveStorage",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/active`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FileStorageActiveStorageResponse>(await this.execute(params, req, runtime), new FileStorageActiveStorageResponse({}));
  }

  async fileStorageActiveStorage(request: FileStorageActiveStorageRequest): Promise<FileStorageActiveStorageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageActiveStorageHeaders({ });
    return await this.fileStorageActiveStorageWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "FileStorageCheckConnection",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/connections/check`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FileStorageCheckConnectionResponse>(await this.execute(params, req, runtime), new FileStorageCheckConnectionResponse({}));
  }

  async fileStorageCheckConnection(request: FileStorageCheckConnectionRequest): Promise<FileStorageCheckConnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageCheckConnectionHeaders({ });
    return await this.fileStorageCheckConnectionWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "FileStorageGetQuotaData",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/quotaDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FileStorageGetQuotaDataResponse>(await this.execute(params, req, runtime), new FileStorageGetQuotaDataResponse({}));
  }

  async fileStorageGetQuotaData(request: FileStorageGetQuotaDataRequest): Promise<FileStorageGetQuotaDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageGetQuotaDataHeaders({ });
    return await this.fileStorageGetQuotaDataWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "FileStorageGetStorageState",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/states`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FileStorageGetStorageStateResponse>(await this.execute(params, req, runtime), new FileStorageGetStorageStateResponse({}));
  }

  async fileStorageGetStorageState(request: FileStorageGetStorageStateRequest): Promise<FileStorageGetStorageStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageGetStorageStateHeaders({ });
    return await this.fileStorageGetStorageStateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "FileStorageUpdateStorage",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/configurations`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FileStorageUpdateStorageResponse>(await this.execute(params, req, runtime), new FileStorageUpdateStorageResponse({}));
  }

  async fileStorageUpdateStorage(request: FileStorageUpdateStorageRequest): Promise<FileStorageUpdateStorageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageUpdateStorageHeaders({ });
    return await this.fileStorageUpdateStorageWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GenerateDarkWaterMark",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GenerateDarkWaterMarkResponse>(await this.execute(params, req, runtime), new GenerateDarkWaterMarkResponse({}));
  }

  async generateDarkWaterMark(request: GenerateDarkWaterMarkRequest): Promise<GenerateDarkWaterMarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GenerateDarkWaterMarkHeaders({ });
    return await this.generateDarkWaterMarkWithOptions(request, headers, runtime);
  }

  async getAccountTransferListWithOptions(request: GetAccountTransferListRequest, headers: GetAccountTransferListHeaders, runtime: $Util.RuntimeOptions): Promise<GetAccountTransferListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
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
      action: "GetAccountTransferList",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/dataTransfer/accounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAccountTransferListResponse>(await this.execute(params, req, runtime), new GetAccountTransferListResponse({}));
  }

  async getAccountTransferList(request: GetAccountTransferListRequest): Promise<GetAccountTransferListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAccountTransferListHeaders({ });
    return await this.getAccountTransferListWithOptions(request, headers, runtime);
  }

  async getActiveUserSummaryWithOptions(dataId: string, headers: GetActiveUserSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetActiveUserSummaryResponse> {
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
      action: "GetActiveUserSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/dau/org/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetActiveUserSummaryResponse>(await this.execute(params, req, runtime), new GetActiveUserSummaryResponse({}));
  }

  async getActiveUserSummary(dataId: string): Promise<GetActiveUserSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActiveUserSummaryHeaders({ });
    return await this.getActiveUserSummaryWithOptions(dataId, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetAgentIdByRelatedAppId",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/exclusiveDesigns/agentId`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAgentIdByRelatedAppIdResponse>(await this.execute(params, req, runtime), new GetAgentIdByRelatedAppIdResponse({}));
  }

  async getAgentIdByRelatedAppId(request: GetAgentIdByRelatedAppIdRequest): Promise<GetAgentIdByRelatedAppIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAgentIdByRelatedAppIdHeaders({ });
    return await this.getAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetAllLabelableDepts",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partnerDepartments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetAllLabelableDeptsResponse>(await this.execute(params, req, runtime), new GetAllLabelableDeptsResponse({}));
  }

  async getAllLabelableDepts(): Promise<GetAllLabelableDeptsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllLabelableDeptsHeaders({ });
    return await this.getAllLabelableDeptsWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetAppDispatchInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/apps/distributionInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAppDispatchInfoResponse>(await this.execute(params, req, runtime), new GetAppDispatchInfoResponse({}));
  }

  async getAppDispatchInfo(request: GetAppDispatchInfoRequest): Promise<GetAppDispatchInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppDispatchInfoHeaders({ });
    return await this.getAppDispatchInfoWithOptions(request, headers, runtime);
  }

  async getCalenderSummaryWithOptions(dataId: string, headers: GetCalenderSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetCalenderSummaryResponse> {
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
      action: "GetCalenderSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/calendar/org/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCalenderSummaryResponse>(await this.execute(params, req, runtime), new GetCalenderSummaryResponse({}));
  }

  async getCalenderSummary(dataId: string): Promise<GetCalenderSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCalenderSummaryHeaders({ });
    return await this.getCalenderSummaryWithOptions(dataId, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetCommentList",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/publishers/${publisherId}/comments/list`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetCommentListResponse>(await this.execute(params, req, runtime), new GetCommentListResponse({}));
  }

  async getCommentList(publisherId: string, request: GetCommentListRequest): Promise<GetCommentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCommentListHeaders({ });
    return await this.getCommentListWithOptions(publisherId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetConfBaseInfoByLogicalId",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/conferences`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConfBaseInfoByLogicalIdResponse>(await this.execute(params, req, runtime), new GetConfBaseInfoByLogicalIdResponse({}));
  }

  async getConfBaseInfoByLogicalId(request: GetConfBaseInfoByLogicalIdRequest): Promise<GetConfBaseInfoByLogicalIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfBaseInfoByLogicalIdHeaders({ });
    return await this.getConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
  }

  async getConferenceDetailWithOptions(conferenceId: string, headers: GetConferenceDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetConferenceDetailResponse> {
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
      action: "GetConferenceDetail",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/conferences/${conferenceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetConferenceDetailResponse>(await this.execute(params, req, runtime), new GetConferenceDetailResponse({}));
  }

  async getConferenceDetail(conferenceId: string): Promise<GetConferenceDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConferenceDetailHeaders({ });
    return await this.getConferenceDetailWithOptions(conferenceId, headers, runtime);
  }

  async getDingReportDeptSummaryWithOptions(dataId: string, request: GetDingReportDeptSummaryRequest, headers: GetDingReportDeptSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingReportDeptSummaryResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetDingReportDeptSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/report/dept/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetDingReportDeptSummaryResponse>(await this.execute(params, req, runtime), new GetDingReportDeptSummaryResponse({}));
  }

  async getDingReportDeptSummary(dataId: string, request: GetDingReportDeptSummaryRequest): Promise<GetDingReportDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingReportDeptSummaryHeaders({ });
    return await this.getDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getDingReportSummaryWithOptions(dataId: string, headers: GetDingReportSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingReportSummaryResponse> {
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
      action: "GetDingReportSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/datas/${dataId}/reports/organizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDingReportSummaryResponse>(await this.execute(params, req, runtime), new GetDingReportSummaryResponse({}));
  }

  async getDingReportSummary(dataId: string): Promise<GetDingReportSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingReportSummaryHeaders({ });
    return await this.getDingReportSummaryWithOptions(dataId, headers, runtime);
  }

  async getDocCreatedDeptSummaryWithOptions(dataId: string, request: GetDocCreatedDeptSummaryRequest, headers: GetDocCreatedDeptSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocCreatedDeptSummaryResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetDocCreatedDeptSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/doc/dept/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDocCreatedDeptSummaryResponse>(await this.execute(params, req, runtime), new GetDocCreatedDeptSummaryResponse({}));
  }

  async getDocCreatedDeptSummary(dataId: string, request: GetDocCreatedDeptSummaryRequest): Promise<GetDocCreatedDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocCreatedDeptSummaryHeaders({ });
    return await this.getDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getDocCreatedSummaryWithOptions(dataId: string, headers: GetDocCreatedSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocCreatedSummaryResponse> {
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
      action: "GetDocCreatedSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/doc/org/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDocCreatedSummaryResponse>(await this.execute(params, req, runtime), new GetDocCreatedSummaryResponse({}));
  }

  async getDocCreatedSummary(dataId: string): Promise<GetDocCreatedSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocCreatedSummaryHeaders({ });
    return await this.getDocCreatedSummaryWithOptions(dataId, headers, runtime);
  }

  async getExclusiveAccountAllOrgListWithOptions(request: GetExclusiveAccountAllOrgListRequest, headers: GetExclusiveAccountAllOrgListHeaders, runtime: $Util.RuntimeOptions): Promise<GetExclusiveAccountAllOrgListResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetExclusiveAccountAllOrgList",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/exclusiveAccounts/organizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetExclusiveAccountAllOrgListResponse>(await this.execute(params, req, runtime), new GetExclusiveAccountAllOrgListResponse({}));
  }

  async getExclusiveAccountAllOrgList(request: GetExclusiveAccountAllOrgListRequest): Promise<GetExclusiveAccountAllOrgListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetExclusiveAccountAllOrgListHeaders({ });
    return await this.getExclusiveAccountAllOrgListWithOptions(request, headers, runtime);
  }

  async getGeneralFormCreatedDeptSummaryWithOptions(dataId: string, request: GetGeneralFormCreatedDeptSummaryRequest, headers: GetGeneralFormCreatedDeptSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetGeneralFormCreatedDeptSummaryResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetGeneralFormCreatedDeptSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/generalForm/dept/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetGeneralFormCreatedDeptSummaryResponse>(await this.execute(params, req, runtime), new GetGeneralFormCreatedDeptSummaryResponse({}));
  }

  async getGeneralFormCreatedDeptSummary(dataId: string, request: GetGeneralFormCreatedDeptSummaryRequest): Promise<GetGeneralFormCreatedDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGeneralFormCreatedDeptSummaryHeaders({ });
    return await this.getGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getGeneralFormCreatedSummaryWithOptions(dataId: string, headers: GetGeneralFormCreatedSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetGeneralFormCreatedSummaryResponse> {
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
      action: "GetGeneralFormCreatedSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/generalForm/org/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetGeneralFormCreatedSummaryResponse>(await this.execute(params, req, runtime), new GetGeneralFormCreatedSummaryResponse({}));
  }

  async getGeneralFormCreatedSummary(dataId: string): Promise<GetGeneralFormCreatedSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGeneralFormCreatedSummaryHeaders({ });
    return await this.getGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetGroupActiveInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/activeGroups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetGroupActiveInfoResponse>(await this.execute(params, req, runtime), new GetGroupActiveInfoResponse({}));
  }

  async getGroupActiveInfo(request: GetGroupActiveInfoRequest): Promise<GetGroupActiveInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupActiveInfoHeaders({ });
    return await this.getGroupActiveInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetInActiveUserList",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/inactives/users/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetInActiveUserListResponse>(await this.execute(params, req, runtime), new GetInActiveUserListResponse({}));
  }

  async getInActiveUserList(request: GetInActiveUserListRequest): Promise<GetInActiveUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInActiveUserListHeaders({ });
    return await this.getInActiveUserListWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetLastOrgAuthData",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/organizations/authInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetLastOrgAuthDataResponse>(await this.execute(params, req, runtime), new GetLastOrgAuthDataResponse({}));
  }

  async getLastOrgAuthData(request: GetLastOrgAuthDataRequest): Promise<GetLastOrgAuthDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLastOrgAuthDataHeaders({ });
    return await this.getLastOrgAuthDataWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetOaOperatorLogList",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/oaOperatorLogs/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetOaOperatorLogListResponse>(await this.execute(params, req, runtime), new GetOaOperatorLogListResponse({}));
  }

  async getOaOperatorLogList(request: GetOaOperatorLogListRequest): Promise<GetOaOperatorLogListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOaOperatorLogListHeaders({ });
    return await this.getOaOperatorLogListWithOptions(request, headers, runtime);
  }

  async getOutGroupsByPageWithOptions(request: GetOutGroupsByPageRequest, headers: GetOutGroupsByPageHeaders, runtime: $Util.RuntimeOptions): Promise<GetOutGroupsByPageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      action: "GetOutGroupsByPage",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/audits/outsideGroups/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOutGroupsByPageResponse>(await this.execute(params, req, runtime), new GetOutGroupsByPageResponse({}));
  }

  async getOutGroupsByPage(request: GetOutGroupsByPageRequest): Promise<GetOutGroupsByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOutGroupsByPageHeaders({ });
    return await this.getOutGroupsByPageWithOptions(request, headers, runtime);
  }

  async getOutsideAuditGroupMessageByPageWithOptions(request: GetOutsideAuditGroupMessageByPageRequest, headers: GetOutsideAuditGroupMessageByPageHeaders, runtime: $Util.RuntimeOptions): Promise<GetOutsideAuditGroupMessageByPageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

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
      action: "GetOutsideAuditGroupMessageByPage",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/audits/outsideGroups/messages/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOutsideAuditGroupMessageByPageResponse>(await this.execute(params, req, runtime), new GetOutsideAuditGroupMessageByPageResponse({}));
  }

  async getOutsideAuditGroupMessageByPage(request: GetOutsideAuditGroupMessageByPageRequest): Promise<GetOutsideAuditGroupMessageByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOutsideAuditGroupMessageByPageHeaders({ });
    return await this.getOutsideAuditGroupMessageByPageWithOptions(request, headers, runtime);
  }

  async getPartnerTypeByParentIdWithOptions(parentId: string, headers: GetPartnerTypeByParentIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetPartnerTypeByParentIdResponse> {
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
      action: "GetPartnerTypeByParentId",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partnerLabels/${parentId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPartnerTypeByParentIdResponse>(await this.execute(params, req, runtime), new GetPartnerTypeByParentIdResponse({}));
  }

  async getPartnerTypeByParentId(parentId: string): Promise<GetPartnerTypeByParentIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPartnerTypeByParentIdHeaders({ });
    return await this.getPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
  }

  async getPublicDevicesWithOptions(request: GetPublicDevicesRequest, headers: GetPublicDevicesHeaders, runtime: $Util.RuntimeOptions): Promise<GetPublicDevicesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.macAddress)) {
      query["macAddress"] = request.macAddress;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.platform)) {
      query["platform"] = request.platform;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      query["title"] = request.title;
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
      action: "GetPublicDevices",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/trusts/publicDevices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPublicDevicesResponse>(await this.execute(params, req, runtime), new GetPublicDevicesResponse({}));
  }

  async getPublicDevices(request: GetPublicDevicesRequest): Promise<GetPublicDevicesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPublicDevicesHeaders({ });
    return await this.getPublicDevicesWithOptions(request, headers, runtime);
  }

  async getPublisherSummaryWithOptions(dataId: string, request: GetPublisherSummaryRequest, headers: GetPublisherSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetPublisherSummaryResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetPublisherSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/publisher/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetPublisherSummaryResponse>(await this.execute(params, req, runtime), new GetPublisherSummaryResponse({}));
  }

  async getPublisherSummary(dataId: string, request: GetPublisherSummaryRequest): Promise<GetPublisherSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPublisherSummaryHeaders({ });
    return await this.getPublisherSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getRealPeopleRecordsWithOptions(request: GetRealPeopleRecordsRequest, headers: GetRealPeopleRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetRealPeopleRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.fromTime)) {
      body["fromTime"] = request.fromTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.personIdentification)) {
      body["personIdentification"] = request.personIdentification;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.toTime)) {
      body["toTime"] = request.toTime;
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
      action: "GetRealPeopleRecords",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/persons/identificationRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRealPeopleRecordsResponse>(await this.execute(params, req, runtime), new GetRealPeopleRecordsResponse({}));
  }

  async getRealPeopleRecords(request: GetRealPeopleRecordsRequest): Promise<GetRealPeopleRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRealPeopleRecordsHeaders({ });
    return await this.getRealPeopleRecordsWithOptions(request, headers, runtime);
  }

  async getRecognizeRecordsWithOptions(request: GetRecognizeRecordsRequest, headers: GetRecognizeRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecognizeRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.faceCompareResult)) {
      body["faceCompareResult"] = request.faceCompareResult;
    }

    if (!Util.isUnset(request.fromTime)) {
      body["fromTime"] = request.fromTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.toTime)) {
      body["toTime"] = request.toTime;
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
      action: "GetRecognizeRecords",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/faces/recognizeRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecognizeRecordsResponse>(await this.execute(params, req, runtime), new GetRecognizeRecordsResponse({}));
  }

  async getRecognizeRecords(request: GetRecognizeRecordsRequest): Promise<GetRecognizeRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecognizeRecordsHeaders({ });
    return await this.getRecognizeRecordsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetSignedDetailByPage",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/audits/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignedDetailByPageResponse>(await this.execute(params, req, runtime), new GetSignedDetailByPageResponse({}));
  }

  async getSignedDetailByPage(request: GetSignedDetailByPageRequest): Promise<GetSignedDetailByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignedDetailByPageHeaders({ });
    return await this.getSignedDetailByPageWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetTrustDeviceList",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/trustedDevices/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTrustDeviceListResponse>(await this.execute(params, req, runtime), new GetTrustDeviceListResponse({}));
  }

  async getTrustDeviceList(request: GetTrustDeviceListRequest): Promise<GetTrustDeviceListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTrustDeviceListHeaders({ });
    return await this.getTrustDeviceListWithOptions(request, headers, runtime);
  }

  async getUserAppVersionSummaryWithOptions(dataId: string, request: GetUserAppVersionSummaryRequest, headers: GetUserAppVersionSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserAppVersionSummaryResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetUserAppVersionSummary",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/appVersion/org/${dataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserAppVersionSummaryResponse>(await this.execute(params, req, runtime), new GetUserAppVersionSummaryResponse({}));
  }

  async getUserAppVersionSummary(dataId: string, request: GetUserAppVersionSummaryRequest): Promise<GetUserAppVersionSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserAppVersionSummaryHeaders({ });
    return await this.getUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
  }

  async getUserFaceStateWithOptions(request: GetUserFaceStateRequest, headers: GetUserFaceStateHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserFaceStateResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetUserFaceState",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/faces/recognizeStates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserFaceStateResponse>(await this.execute(params, req, runtime), new GetUserFaceStateResponse({}));
  }

  async getUserFaceState(request: GetUserFaceStateRequest): Promise<GetUserFaceStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserFaceStateHeaders({ });
    return await this.getUserFaceStateWithOptions(request, headers, runtime);
  }

  async getUserRealPeopleStateWithOptions(request: GetUserRealPeopleStateRequest, headers: GetUserRealPeopleStateHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserRealPeopleStateResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetUserRealPeopleState",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/persons/identificationStates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserRealPeopleStateResponse>(await this.execute(params, req, runtime), new GetUserRealPeopleStateResponse({}));
  }

  async getUserRealPeopleState(request: GetUserRealPeopleStateRequest): Promise<GetUserRealPeopleStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserRealPeopleStateHeaders({ });
    return await this.getUserRealPeopleStateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetUserStayLength",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/data/users/stayTimes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserStayLengthResponse>(await this.execute(params, req, runtime), new GetUserStayLengthResponse({}));
  }

  async getUserStayLength(request: GetUserStayLengthRequest): Promise<GetUserStayLengthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserStayLengthHeaders({ });
    return await this.getUserStayLengthWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ListAuditLog",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileAuditLogs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAuditLogResponse>(await this.execute(params, req, runtime), new ListAuditLogResponse({}));
  }

  async listAuditLog(request: ListAuditLogRequest): Promise<ListAuditLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAuditLogHeaders({ });
    return await this.listAuditLogWithOptions(request, headers, runtime);
  }

  async listCategorysWithOptions(tmpReq: ListCategorysRequest, headers: ListCategorysHeaders, runtime: $Util.RuntimeOptions): Promise<ListCategorysResponse> {
    Util.validateModel(tmpReq);
    let request = new ListCategorysShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.body)) {
      request.bodyShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bodyShrink)) {
      query["body"] = request.bodyShrink;
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
      action: "ListCategorys",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/categories/listCategories`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListCategorysResponse>(await this.execute(params, req, runtime), new ListCategorysResponse({}));
  }

  async listCategorys(request: ListCategorysRequest): Promise<ListCategorysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCategorysHeaders({ });
    return await this.listCategorysWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ListJoinOrgInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/exclusiveAccounts/organizations/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListJoinOrgInfoResponse>(await this.execute(params, req, runtime), new ListJoinOrgInfoResponse({}));
  }

  async listJoinOrgInfo(request: ListJoinOrgInfoRequest): Promise<ListJoinOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListJoinOrgInfoHeaders({ });
    return await this.listJoinOrgInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ListMiniAppAvailableVersion",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/miniApps/versions/availableLists`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListMiniAppAvailableVersionResponse>(await this.execute(params, req, runtime), new ListMiniAppAvailableVersionResponse({}));
  }

  async listMiniAppAvailableVersion(request: ListMiniAppAvailableVersionRequest): Promise<ListMiniAppAvailableVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMiniAppAvailableVersionHeaders({ });
    return await this.listMiniAppAvailableVersionWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ListMiniAppHistoryVersion",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/miniApps/versions/historyLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListMiniAppHistoryVersionResponse>(await this.execute(params, req, runtime), new ListMiniAppHistoryVersionResponse({}));
  }

  async listMiniAppHistoryVersion(request: ListMiniAppHistoryVersionRequest): Promise<ListMiniAppHistoryVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMiniAppHistoryVersionHeaders({ });
    return await this.listMiniAppHistoryVersionWithOptions(request, headers, runtime);
  }

  async listPartnerRolesWithOptions(parentId: string, headers: ListPartnerRolesHeaders, runtime: $Util.RuntimeOptions): Promise<ListPartnerRolesResponse> {
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
      action: "ListPartnerRoles",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partners/roles/${parentId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListPartnerRolesResponse>(await this.execute(params, req, runtime), new ListPartnerRolesResponse({}));
  }

  async listPartnerRoles(parentId: string): Promise<ListPartnerRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPartnerRolesHeaders({ });
    return await this.listPartnerRolesWithOptions(parentId, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ListPunchScheduleByConditionWithPaging",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/punchSchedules/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListPunchScheduleByConditionWithPagingResponse>(await this.execute(params, req, runtime), new ListPunchScheduleByConditionWithPagingResponse({}));
  }

  async listPunchScheduleByConditionWithPaging(request: ListPunchScheduleByConditionWithPagingRequest): Promise<ListPunchScheduleByConditionWithPagingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPunchScheduleByConditionWithPagingHeaders({ });
    return await this.listPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
  }

  async listRulesWithOptions(tmpReq: ListRulesRequest, headers: ListRulesHeaders, runtime: $Util.RuntimeOptions): Promise<ListRulesResponse> {
    Util.validateModel(tmpReq);
    let request = new ListRulesShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.body)) {
      request.bodyShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bodyShrink)) {
      query["body"] = request.bodyShrink;
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
      action: "ListRules",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/rules/listRules`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListRulesResponse>(await this.execute(params, req, runtime), new ListRulesResponse({}));
  }

  async listRules(request: ListRulesRequest): Promise<ListRulesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRulesHeaders({ });
    return await this.listRulesWithOptions(request, headers, runtime);
  }

  async logoutWithOptions(request: LogoutRequest, headers: LogoutHeaders, runtime: $Util.RuntimeOptions): Promise<LogoutResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceType)) {
      body["deviceType"] = request.deviceType;
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
      action: "Logout",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/users/logout`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LogoutResponse>(await this.execute(params, req, runtime), new LogoutResponse({}));
  }

  async logout(request: LogoutRequest): Promise<LogoutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LogoutHeaders({ });
    return await this.logoutWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "PublishFileChangeNotice",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/comments/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<PublishFileChangeNoticeResponse>(await this.execute(params, req, runtime), new PublishFileChangeNoticeResponse({}));
  }

  async publishFileChangeNotice(request: PublishFileChangeNoticeRequest): Promise<PublishFileChangeNoticeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PublishFileChangeNoticeHeaders({ });
    return await this.publishFileChangeNoticeWithOptions(request, headers, runtime);
  }

  async publishRuleWithOptions(request: PublishRuleRequest, headers: PublishRuleHeaders, runtime: $Util.RuntimeOptions): Promise<PublishRuleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "PublishRule",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/rules/publish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PublishRuleResponse>(await this.execute(params, req, runtime), new PublishRuleResponse({}));
  }

  async publishRule(request: PublishRuleRequest): Promise<PublishRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PublishRuleHeaders({ });
    return await this.publishRuleWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "PushBadge",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/exclusiveDesigns/redPoints/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushBadgeResponse>(await this.execute(params, req, runtime), new PushBadgeResponse({}));
  }

  async pushBadge(request: PushBadgeRequest): Promise<PushBadgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushBadgeHeaders({ });
    return await this.pushBadgeWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryAcrossCloudStroageConfigs",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/acrossClouds/configurations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAcrossCloudStroageConfigsResponse>(await this.execute(params, req, runtime), new QueryAcrossCloudStroageConfigsResponse({}));
  }

  async queryAcrossCloudStroageConfigs(request: QueryAcrossCloudStroageConfigsRequest): Promise<QueryAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAcrossCloudStroageConfigsHeaders({ });
    return await this.queryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
  }

  async queryPartnerInfoWithOptions(userId: string, headers: QueryPartnerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPartnerInfoResponse> {
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
      action: "QueryPartnerInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partners/users/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPartnerInfoResponse>(await this.execute(params, req, runtime), new QueryPartnerInfoResponse({}));
  }

  async queryPartnerInfo(userId: string): Promise<QueryPartnerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPartnerInfoHeaders({ });
    return await this.queryPartnerInfoWithOptions(userId, headers, runtime);
  }

  async queryUserBehaviorWithOptions(request: QueryUserBehaviorRequest, headers: QueryUserBehaviorHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserBehaviorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.platform)) {
      body["platform"] = request.platform;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
      action: "QueryUserBehavior",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserBehaviorResponse>(await this.execute(params, req, runtime), new QueryUserBehaviorResponse({}));
  }

  async queryUserBehavior(request: QueryUserBehaviorRequest): Promise<QueryUserBehaviorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserBehaviorHeaders({ });
    return await this.queryUserBehaviorWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "RollbackMiniAppVersion",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/miniApps/versions/rollback`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RollbackMiniAppVersionResponse>(await this.execute(params, req, runtime), new RollbackMiniAppVersionResponse({}));
  }

  async rollbackMiniAppVersion(request: RollbackMiniAppVersionRequest): Promise<RollbackMiniAppVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RollbackMiniAppVersionHeaders({ });
    return await this.rollbackMiniAppVersionWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SaveAcrossCloudStroageConfigs",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/acrossClouds/configurations`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveAcrossCloudStroageConfigsResponse>(await this.execute(params, req, runtime), new SaveAcrossCloudStroageConfigsResponse({}));
  }

  async saveAcrossCloudStroageConfigs(request: SaveAcrossCloudStroageConfigsRequest): Promise<SaveAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveAcrossCloudStroageConfigsHeaders({ });
    return await this.saveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SaveAndSubmitAuthInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/ognizations/authInfos/saveAndSubmit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveAndSubmitAuthInfoResponse>(await this.execute(params, req, runtime), new SaveAndSubmitAuthInfoResponse({}));
  }

  async saveAndSubmitAuthInfo(request: SaveAndSubmitAuthInfoRequest): Promise<SaveAndSubmitAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveAndSubmitAuthInfoHeaders({ });
    return await this.saveAndSubmitAuthInfoWithOptions(request, headers, runtime);
  }

  async saveOpenTerminalInfoWithOptions(request: SaveOpenTerminalInfoRequest, headers: SaveOpenTerminalInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SaveOpenTerminalInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.logSource)) {
      body["logSource"] = request.logSource;
    }

    if (!Util.isUnset(request.logType)) {
      body["logType"] = request.logType;
    }

    if (!Util.isUnset(request.openExt)) {
      body["openExt"] = request.openExt;
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
      action: "SaveOpenTerminalInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/externalLogs/terminalInfos/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveOpenTerminalInfoResponse>(await this.execute(params, req, runtime), new SaveOpenTerminalInfoResponse({}));
  }

  async saveOpenTerminalInfo(request: SaveOpenTerminalInfoRequest): Promise<SaveOpenTerminalInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveOpenTerminalInfoHeaders({ });
    return await this.saveOpenTerminalInfoWithOptions(request, headers, runtime);
  }

  async saveWhiteAppWithOptions(request: SaveWhiteAppRequest, headers: SaveWhiteAppHeaders, runtime: $Util.RuntimeOptions): Promise<SaveWhiteAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentIdList)) {
      body["agentIdList"] = request.agentIdList;
    }

    if (!Util.isUnset(request.agentIdMap)) {
      body["agentIdMap"] = request.agentIdMap;
    }

    if (!Util.isUnset(request.operation)) {
      body["operation"] = request.operation;
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
      action: "SaveWhiteApp",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/miniApps/whiteLists/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveWhiteAppResponse>(await this.execute(params, req, runtime), new SaveWhiteAppResponse({}));
  }

  async saveWhiteApp(request: SaveWhiteAppRequest): Promise<SaveWhiteAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveWhiteAppHeaders({ });
    return await this.saveWhiteAppWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SearchOrgInnerGroupInfo",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/securities/orgGroupInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchOrgInnerGroupInfoResponse>(await this.execute(params, req, runtime), new SearchOrgInnerGroupInfoResponse({}));
  }

  async searchOrgInnerGroupInfo(request: SearchOrgInnerGroupInfoRequest): Promise<SearchOrgInnerGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchOrgInnerGroupInfoHeaders({ });
    return await this.searchOrgInnerGroupInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SendAppDing",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/appDings/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<SendAppDingResponse>(await this.execute(params, req, runtime), new SendAppDingResponse({}));
  }

  async sendAppDing(request: SendAppDingRequest): Promise<SendAppDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendAppDingHeaders({ });
    return await this.sendAppDingWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SendInvitation",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partnerDepartments/invitations/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<SendInvitationResponse>(await this.execute(params, req, runtime), new SendInvitationResponse({}));
  }

  async sendInvitation(request: SendInvitationRequest): Promise<SendInvitationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInvitationHeaders({ });
    return await this.sendInvitationWithOptions(request, headers, runtime);
  }

  async sendPhoneDingWithOptions(request: SendPhoneDingRequest, headers: SendPhoneDingHeaders, runtime: $Util.RuntimeOptions): Promise<SendPhoneDingResponse> {
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
    let params = new $OpenApi.Params({
      action: "SendPhoneDing",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/phoneDings/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendPhoneDingResponse>(await this.execute(params, req, runtime), new SendPhoneDingResponse({}));
  }

  async sendPhoneDing(request: SendPhoneDingRequest): Promise<SendPhoneDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendPhoneDingHeaders({ });
    return await this.sendPhoneDingWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SetDeptPartnerTypeAndNum",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partnerDepartments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SetDeptPartnerTypeAndNumResponse>(await this.execute(params, req, runtime), new SetDeptPartnerTypeAndNumResponse({}));
  }

  async setDeptPartnerTypeAndNum(request: SetDeptPartnerTypeAndNumRequest): Promise<SetDeptPartnerTypeAndNumResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetDeptPartnerTypeAndNumHeaders({ });
    return await this.setDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
  }

  async updateCategoryNameWithOptions(request: UpdateCategoryNameRequest, headers: UpdateCategoryNameHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCategoryNameResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentCategoryName)) {
      body["currentCategoryName"] = request.currentCategoryName;
    }

    if (!Util.isUnset(request.targetCategoryName)) {
      body["targetCategoryName"] = request.targetCategoryName;
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
      action: "UpdateCategoryName",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageCategories/categories/names`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCategoryNameResponse>(await this.execute(params, req, runtime), new UpdateCategoryNameResponse({}));
  }

  async updateCategoryName(request: UpdateCategoryNameRequest): Promise<UpdateCategoryNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCategoryNameHeaders({ });
    return await this.updateCategoryNameWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "UpdateFileStatus",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/sending/files/status`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateFileStatusResponse>(await this.execute(params, req, runtime), new UpdateFileStatusResponse({}));
  }

  async updateFileStatus(request: UpdateFileStatusRequest): Promise<UpdateFileStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFileStatusHeaders({ });
    return await this.updateFileStatusWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "UpdateMiniAppVersionStatus",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/miniApps/versions/versionStatus`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateMiniAppVersionStatusResponse>(await this.execute(params, req, runtime), new UpdateMiniAppVersionStatusResponse({}));
  }

  async updateMiniAppVersionStatus(request: UpdateMiniAppVersionStatusRequest): Promise<UpdateMiniAppVersionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMiniAppVersionStatusHeaders({ });
    return await this.updateMiniAppVersionStatusWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "UpdatePartnerVisibility",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partnerDepartments/visibilityPartners`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "boolean",
    });
    return $tea.cast<UpdatePartnerVisibilityResponse>(await this.execute(params, req, runtime), new UpdatePartnerVisibilityResponse({}));
  }

  async updatePartnerVisibility(request: UpdatePartnerVisibilityRequest): Promise<UpdatePartnerVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePartnerVisibilityHeaders({ });
    return await this.updatePartnerVisibilityWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "UpdateRoleVisibility",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/partnerDepartments/visibilityRoles`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "boolean",
    });
    return $tea.cast<UpdateRoleVisibilityResponse>(await this.execute(params, req, runtime), new UpdateRoleVisibilityResponse({}));
  }

  async updateRoleVisibility(request: UpdateRoleVisibilityRequest): Promise<UpdateRoleVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRoleVisibilityHeaders({ });
    return await this.updateRoleVisibilityWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "UpdateStorageMode",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/fileStorages/acrossClouds/storageModes`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateStorageModeResponse>(await this.execute(params, req, runtime), new UpdateStorageModeResponse({}));
  }

  async updateStorageMode(request: UpdateStorageModeRequest): Promise<UpdateStorageModeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStorageModeHeaders({ });
    return await this.updateStorageModeWithOptions(request, headers, runtime);
  }

}
