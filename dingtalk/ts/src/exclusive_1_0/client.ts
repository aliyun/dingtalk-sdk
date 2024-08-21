// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15800000000
   */
  mobileNum?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试组织
   */
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
  /**
   * @example
   * dinge4a454fa5f32aba6f5bf40edxxxxxxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddOrgResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleSecretId1234
   */
  accessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  request?: ApproveProcessCallbackRequestRequest;
  /**
   * @example
   * dingxxxxxxxxxxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ApproveProcessCallbackResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  banWordsType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 成功
   */
  cause?: string;
  /**
   * @example
   * 200
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BanOrOpenGroupWordsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCategoryAndBindingGroupsResponseBody;
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

export class CreateDlpTaskHeaders extends $tea.Model {
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

export class CreateDlpTaskRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dentryId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      spaceId: 'spaceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      spaceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDlpTaskResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDlpTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateDlpTaskResponseBody;
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
      body: CreateDlpTaskResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateMessageCategoryResponseBody;
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
  /**
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateRuleResponseBody;
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
  /**
   * @example
   * CV11z5d2bdbb2260d1576000b4a9955fa
   */
  did?: string;
  /**
   * @example
   * 88:92:5a:1f:e8:24
   */
  macAddress?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Mac
   */
  platform?: string;
  /**
   * @example
   * 2
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 65224157501039784
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateTrustedDeviceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  macAddressList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Win
   */
  platform?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateTrustedDeviceBatchResponseBody;
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

export class CreateVirusScanTaskHeaders extends $tea.Model {
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

export class CreateVirusScanTaskRequest extends $tea.Model {
  dentryId?: string;
  downloadUrl?: string;
  fileMd5?: string;
  fileName?: string;
  fileSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  source?: number;
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      downloadUrl: 'downloadUrl',
      fileMd5: 'fileMd5',
      fileName: 'fileName',
      fileSize: 'fileSize',
      source: 'source',
      spaceId: 'spaceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      downloadUrl: 'string',
      fileMd5: 'string',
      fileName: 'string',
      fileSize: 'number',
      source: 'number',
      spaceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVirusScanTaskResponseBody extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVirusScanTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateVirusScanTaskResponseBody;
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
      body: CreateVirusScanTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DataSyncHeaders extends $tea.Model {
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

export class DataSyncRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sql语句
   */
  sql?: string;
  static names(): { [key: string]: string } {
    return {
      sql: 'sql',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sql: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DataSyncResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  /**
   * @example
   * 1
   */
  rowsAffected?: number;
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      rowsAffected: 'rowsAffected',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      rowsAffected: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DataSyncResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DataSyncResponseBody;
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
      body: DataSyncResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteAcrossCloudStroageConfigsResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: boolean;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  kickOff?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 88:92:5a:1f:e8:24
   */
  macAddress?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0119194439361061403
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteTrustedDeviceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  appId?: number;
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DistributePartnerAppResponseBody;
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

export class ExchangeMainAdminHeaders extends $tea.Model {
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

export class ExchangeMainAdminRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 509999
   */
  newAdminUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4045678
   */
  oldAdminUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxxx
   */
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      newAdminUserId: 'newAdminUserId',
      oldAdminUserId: 'oldAdminUserId',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newAdminUserId: 'string',
      oldAdminUserId: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExchangeMainAdminResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class ExchangeMainAdminResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExchangeMainAdminResponseBody;
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
      body: ExchangeMainAdminResponseBody,
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
  /**
   * @example
   * XX工作台
   */
  dingPortalName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
  targetCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TPL_APP-C97B75277B144ED7AEFE7XXXXXXXX6BA
   */
  templateAppUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExclusiveCreateDingPortalResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleSecretId1234
   */
  accessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://oss.aliyuncs.com/bucket-name/
   */
  oss?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FileStorageActiveStorageResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleSecretId1234
   */
  accessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://oss.aliyuncs.com/bucket-name/
   */
  oss?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
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
  /**
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  checkState?: number;
  /**
   * @example
   * https://oss-cn-test.aliyuncs.com\
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FileStorageCheckConnectionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-04
   */
  endTime?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-04
   */
  startTime?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding77b8cac4e026cc123xxxxxxxxeb6378f
   */
  targetCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FileStorageGetQuotaDataResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding77b8cac4e026cc123xxxxxxxxeb6378f
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FileStorageGetStorageStateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleSecretId1234
   */
  accessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
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
  /**
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @example
   * https://oss-cn-test.aliyuncs.com\
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FileStorageUpdateStorageResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 200
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GenerateDarkWaterMarkResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @example
   * 1000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAccountTransferListResponseBody;
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
  /**
   * @example
   * 20
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetActiveUserSummaryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10000
   */
  appId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding24f2f5ccxxxxxxxx
   */
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
  /**
   * @example
   * 3300000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAgentIdByRelatedAppIdResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllLabelableDeptsResponseBody;
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
  /**
   * @example
   * 1655709383307
   */
  endTime?: number;
  /**
   * @example
   * 1655709383307
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAppDispatchInfoResponseBody;
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
  /**
   * @example
   * 20
   */
  calendarCreateUserCnt?: string;
  /**
   * @example
   * 20
   */
  recvCalendarUserCnt1d?: string;
  /**
   * @example
   * 20
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCalenderSummaryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  data?: GetCommentListResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCommentListResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConfBaseInfoByLogicalIdResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConferenceDetailResponseBody;
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

export class GetConversationCategoryHeaders extends $tea.Model {
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

export class GetConversationCategoryResponseBody extends $tea.Model {
  result?: GetConversationCategoryResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetConversationCategoryResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationCategoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConversationCategoryResponseBody;
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
      body: GetConversationCategoryResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * 2
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDingReportDeptSummaryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDingReportSummaryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * 2
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDocCreatedDeptSummaryResponseBody;
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
  /**
   * @example
   * 100
   */
  docCreateUserCnt1d?: string;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDocCreatedSummaryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TBXK65QHiiorHvxxxxxxxxP6giEiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetExclusiveAccountAllOrgListResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * 2
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetGeneralFormCreatedDeptSummaryResponseBody;
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
  /**
   * @example
   * 100
   */
  generalFormCreatedCnt?: string;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetGeneralFormCreatedSummaryResponseBody;
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
  /**
   * @example
   * cidV3xxxrSuxxxxxxnB8o8gJw==
   */
  dingGroupId?: string;
  /**
   * @example
   * 1
   */
  groupType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20200305
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  data?: GetGroupActiveInfoResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetGroupActiveInfoResponseBody;
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
  /**
   * **if can be null:**
   * true
   */
  deptIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInActiveUserListResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding77b8cac4e026cc123xxxxxxxxeb6378f
   */
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
  /**
   * @example
   * 营业执照照片不清晰
   */
  authRemark?: string;
  /**
   * @example
   * 2
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetLastOrgAuthDataResponseBody;
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

export class GetMsgConfigHeaders extends $tea.Model {
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

export class GetMsgConfigRequest extends $tea.Model {
  groupTopic?: string;
  groupType?: string;
  listDynamicAttr?: GetMsgConfigRequestListDynamicAttr[];
  listEmployeeCode?: string[];
  listUnitId?: number[];
  ownerJobNo?: string;
  ruleBusinessCode?: string;
  ruleCategory?: number;
  ruleCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  secretKey?: string;
  sysCode?: string;
  static names(): { [key: string]: string } {
    return {
      groupTopic: 'groupTopic',
      groupType: 'groupType',
      listDynamicAttr: 'listDynamicAttr',
      listEmployeeCode: 'listEmployeeCode',
      listUnitId: 'listUnitId',
      ownerJobNo: 'ownerJobNo',
      ruleBusinessCode: 'ruleBusinessCode',
      ruleCategory: 'ruleCategory',
      ruleCode: 'ruleCode',
      secretKey: 'secretKey',
      sysCode: 'sysCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupTopic: 'string',
      groupType: 'string',
      listDynamicAttr: { 'type': 'array', 'itemType': GetMsgConfigRequestListDynamicAttr },
      listEmployeeCode: { 'type': 'array', 'itemType': 'string' },
      listUnitId: { 'type': 'array', 'itemType': 'number' },
      ownerJobNo: 'string',
      ruleBusinessCode: 'string',
      ruleCategory: 'number',
      ruleCode: 'string',
      secretKey: 'string',
      sysCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBody extends $tea.Model {
  code?: number;
  data?: GetMsgConfigResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetMsgConfigResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMsgConfigResponseBody;
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
      body: GetMsgConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgLocationHeaders extends $tea.Model {
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

export class GetMsgLocationRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openMsgId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openMsgId: 'openMsgId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openMsgId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgLocationResponseBody extends $tea.Model {
  msgLocationUrl?: string;
  static names(): { [key: string]: string } {
    return {
      msgLocationUrl: 'msgLocationUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgLocationUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgLocationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMsgLocationResponseBody;
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
      body: GetMsgLocationResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  endTime?: number;
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  data?: GetOaOperatorLogListResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOaOperatorLogListResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 20
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOutGroupsByPageResponseBody;
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
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1680493837426
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOutsideAuditGroupMessageByPageResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPartnerTypeByParentIdResponseBody;
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
  /**
   * @example
   * 1671767361000
   */
  endTime?: number;
  /**
   * @example
   * 88:66:5a:07:2b:04
   */
  macAddress?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
  pageSize?: number;
  /**
   * @example
   * Mac
   */
  platform?: string;
  /**
   * @example
   * 1671767361000
   */
  startTime?: number;
  /**
   * @example
   * 这是标题
   */
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
  /**
   * @example
   * 100
   */
  dataCnt?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPublicDevicesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * 2
   */
  nextToken?: number;
  /**
   * @example
   * 100
   */
  publisherArticleCntStd?: string;
  /**
   * @example
   * 100
   */
  publisherArticlePvCntStd?: string;
  /**
   * @example
   * 阅读量最高文章，阅读量第二高文章
   */
  publisherArticlePvTop5?: GetPublisherSummaryResponseBodyPublisherArticlePvTop5[];
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPublisherSummaryResponseBody;
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
  /**
   * @example
   * 123333
   */
  agentId?: number;
  /**
   * @example
   * 1667000000
   */
  fromTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * 1
   */
  personIdentification?: number;
  /**
   * @example
   * 1
   */
  scene?: number;
  /**
   * @example
   * 1669000000
   */
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
  /**
   * @example
   * 1
   */
  nextToken?: number;
  /**
   * @example
   * 20
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRealPeopleRecordsResponseBody;
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
  /**
   * @example
   * 123333
   */
  agentId?: number;
  /**
   * @example
   * 1
   */
  faceCompareResult?: number;
  /**
   * @example
   * 1667000000
   */
  fromTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * 1669000000
   */
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
  /**
   * @example
   * 1
   */
  nextToken?: number;
  /**
   * @example
   * 20
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRecognizeRecordsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @example
   * 1
   */
  currentPage?: number;
  /**
   * @example
   * 50
   */
  pageSize?: number;
  /**
   * @example
   * 1000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignedDetailByPageResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTrustDeviceListResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserAppVersionSummaryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserFaceStateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserRealPeopleStateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220501
   */
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
  /**
   * @example
   * 1000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserStayLengthResponseBody;
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

export class GetVirusScanResultHeaders extends $tea.Model {
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

export class GetVirusScanResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVirusScanResultResponseBody extends $tea.Model {
  reason?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      reason: 'reason',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reason: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVirusScanResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetVirusScanResultResponseBody;
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
      body: GetVirusScanResultResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1577945731837
   */
  endDate?: number;
  /**
   * @example
   * 6406817113
   */
  nextBizId?: number;
  /**
   * @example
   * 1577340931837
   */
  nextGmtCreate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 500
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1577340931837
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAuditLogResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListCategorysResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15800000000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListJoinOrgInfoResponseBody;
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
  /**
   * @example
   * 5000003
   */
  miniAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListMiniAppAvailableVersionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 500000003
   */
  miniAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListMiniAppHistoryVersionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListPartnerRolesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2aa6736c715944329xxxxxxxxd38be41
   */
  bizInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: number;
  /**
   * @example
   * 2022-03-13
   */
  scheduleDateEnd?: string;
  /**
   * @example
   * 2022-03-13
   */
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
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  list?: ListPunchScheduleByConditionWithPagingResponseBodyList[];
  /**
   * @example
   * 10000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListPunchScheduleByConditionWithPagingResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListRulesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  deviceType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a523641
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LogoutResponseBody;
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

export class OpenBenefitPackageHeaders extends $tea.Model {
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

export class OpenBenefitPackageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  benefitPackage?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  endDate?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  startDate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxx
   */
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      benefitPackage: 'benefitPackage',
      endDate: 'endDate',
      startDate: 'startDate',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitPackage: 'number',
      endDate: 'number',
      startDate: 'number',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenBenefitPackageResponseBody extends $tea.Model {
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

export class OpenBenefitPackageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenBenefitPackageResponseBody;
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
      body: OpenBenefitPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreventCheatingCheckRiskHeaders extends $tea.Model {
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

export class PreventCheatingCheckRiskRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6.3.30
   */
  clientVer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iOS
   */
  platform?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15
   */
  platformVer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"lbsWuaToken": "lbsWua","ddSec":"ddSec"}
   */
  sec?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      clientVer: 'clientVer',
      platform: 'platform',
      platformVer: 'platformVer',
      sec: 'sec',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientVer: 'string',
      platform: 'string',
      platformVer: 'string',
      sec: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreventCheatingCheckRiskResponseBody extends $tea.Model {
  result?: PreventCheatingCheckRiskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PreventCheatingCheckRiskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreventCheatingCheckRiskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PreventCheatingCheckRiskResponseBody;
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
      body: PreventCheatingCheckRiskResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx
   */
  fileId?: string;
  /**
   * @example
   * 1
   */
  operateType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx
   */
  operatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PublishRuleResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 110000000
   */
  agentId?: string;
  badgeItems?: PushBadgeRequestBadgeItems[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PushBadgeResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  targetCloudType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding77b8cac4e026cc123xxxxxxxxeb6378f
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleSecretId1234
   */
  accessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxbucket
   */
  bucketName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  cloudType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://oss-cn-test.aliyuncs.com
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAcrossCloudStroageConfigsResponseBody;
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

export class QueryChannelStaffInfoByMobileHeaders extends $tea.Model {
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

export class QueryChannelStaffInfoByMobileRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 158xxxxxxxx
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxx
   */
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      mobile: 'mobile',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobile: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryChannelStaffInfoByMobileResponseBody extends $tea.Model {
  empInfo?: QueryChannelStaffInfoByMobileResponseBodyEmpInfo;
  exclusiveAccountEmpInfoList?: QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList[];
  static names(): { [key: string]: string } {
    return {
      empInfo: 'empInfo',
      exclusiveAccountEmpInfoList: 'exclusiveAccountEmpInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      empInfo: QueryChannelStaffInfoByMobileResponseBodyEmpInfo,
      exclusiveAccountEmpInfoList: { 'type': 'array', 'itemType': QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryChannelStaffInfoByMobileResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryChannelStaffInfoByMobileResponseBody;
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
      body: QueryChannelStaffInfoByMobileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryExclusiveBenefitsHeaders extends $tea.Model {
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

export class QueryExclusiveBenefitsResponseBody extends $tea.Model {
  benefitsList?: string[];
  static names(): { [key: string]: string } {
    return {
      benefitsList: 'benefitsList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitsList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryExclusiveBenefitsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryExclusiveBenefitsResponseBody;
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
      body: QueryExclusiveBenefitsResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPartnerInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  platform?: number;
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: number;
  /**
   * @example
   * 12034-1233
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUserBehaviorResponseBody;
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
  /**
   * @example
   * 5000000003
   */
  miniAppId?: string;
  /**
   * @example
   * 0.0.5
   */
  rollbackVersion?: string;
  /**
   * @example
   * 0.0.4
   */
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
  /**
   * @example
   * 成功
   */
  cause?: string;
  /**
   * @example
   * 200
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RollbackMiniAppVersionResponseBody;
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

export class RuleBatchReceiverHeaders extends $tea.Model {
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

export class RuleBatchReceiverRequest extends $tea.Model {
  batchNo?: string;
  cardOptions?: string;
  data?: RuleBatchReceiverRequestData[];
  ruleCode?: string;
  secretKey?: string;
  specialStrategy?: boolean;
  taskBatchNo?: string;
  static names(): { [key: string]: string } {
    return {
      batchNo: 'batchNo',
      cardOptions: 'cardOptions',
      data: 'data',
      ruleCode: 'ruleCode',
      secretKey: 'secretKey',
      specialStrategy: 'specialStrategy',
      taskBatchNo: 'taskBatchNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      batchNo: 'string',
      cardOptions: 'string',
      data: { 'type': 'array', 'itemType': RuleBatchReceiverRequestData },
      ruleCode: 'string',
      secretKey: 'string',
      specialStrategy: 'boolean',
      taskBatchNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RuleBatchReceiverResponseBody extends $tea.Model {
  code?: number;
  data?: RuleBatchReceiverResponseBodyData[];
  msg?: string;
  msgId?: string;
  rows?: RuleBatchReceiverResponseBodyRows[][];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      msg: 'msg',
      msgId: 'msgId',
      rows: 'rows',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: { 'type': 'array', 'itemType': RuleBatchReceiverResponseBodyData },
      msg: 'string',
      msgId: 'string',
      rows: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': RuleBatchReceiverResponseBodyRows } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RuleBatchReceiverResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RuleBatchReceiverResponseBody;
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
      body: RuleBatchReceiverResponseBody,
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
  /**
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @example
   * sampleSecretId1234
   */
  accessKeySecret?: string;
  /**
   * @example
   * xxxxbucket
   */
  bucketName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  cloudType?: number;
  /**
   * @example
   * https://oss-cn-test.aliyuncs.com
   */
  endpoint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
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
  /**
   * @example
   * sampleKeyId1234
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://oss-cn-test.aliyuncs.com
   */
  endpoint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveAcrossCloudStroageConfigsResponseBody;
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
  /**
   * @example
   * XXX组织申请高级认证
   */
  applyRemark?: string;
  /**
   * @example
   * @lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA
   */
  authorizeMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 计算机
   */
  industry?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉三多
   */
  legalPerson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3301XX1997XXXXXXXXX
   */
  legalPersonIdCard?: string;
  /**
   * @example
   * @lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA
   */
  licenseMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 330100
   */
  locCity?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 杭州
   */
  locCityName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 330000
   */
  locProvince?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 浙江
   */
  locProvinceName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15869110714
   */
  mobileNum?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试组织
   */
  orgName?: string;
  /**
   * @example
   * 11111111-1
   */
  organizationCode?: string;
  /**
   * @example
   * @lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA
   */
  organizationCodeMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 余杭区文一西路XX号
   */
  registLocation?: string;
  /**
   * @example
   * 1111111111111111
   */
  registNum?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
  targetCorpId?: string;
  /**
   * @example
   * 9111111XX2957XX4X
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveAndSubmitAuthInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingf8d907412a586
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 云枢
   */
  logSource?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * terminalInfo
   */
  logType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * [{"date":"2023-05-10","macAddress":"34-2E-B7-AF-EA-JF","devSn":"68D1F0-B76A-5CC9-BCFC-BD7548BA","staffId":"05166141678164"}]
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveOpenTerminalInfoResponseBody;
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

export class SaveStorageFunctionSwitchHeaders extends $tea.Model {
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

export class SaveStorageFunctionSwitchRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15800000000
   */
  functionList?: SaveStorageFunctionSwitchRequestFunctionList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxx
   */
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      functionList: 'functionList',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      functionList: { 'type': 'array', 'itemType': SaveStorageFunctionSwitchRequestFunctionList },
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStorageFunctionSwitchResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class SaveStorageFunctionSwitchResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveStorageFunctionSwitchResponseBody;
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
      body: SaveStorageFunctionSwitchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStorageSwitchHeaders extends $tea.Model {
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

export class SaveStorageSwitchRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0-关闭，1-开启
   */
  openStorage?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxx
   */
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      openStorage: 'openStorage',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openStorage: 'number',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStorageSwitchResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class SaveStorageSwitchResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveStorageSwitchResponseBody;
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
      body: SaveStorageSwitchResponseBody,
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
  /**
   * @deprecated
   */
  agentIdList?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"openShareControl":[123],"openClipboardPaste":[123]}
   */
  agentIdMap?: string;
  /**
   * @example
   * add
   * 
   * @deprecated
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveWhiteAppResponseBody;
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
  /**
   * @example
   * 创建时间查询最大时间戳
   */
  createTimeEnd?: number;
  /**
   * @example
   * 创建时间查询最小时间戳
   */
  createTimeStart?: number;
  /**
   * @example
   * 群人数范围最大值，例如100
   */
  groupMembersCountEnd?: number;
  /**
   * @example
   * 群人数范围最小值，例如1
   */
  groupMembersCountStart?: number;
  /**
   * @example
   * 群名称
   */
  groupName?: string;
  /**
   * @example
   * 群主userId
   */
  groupOwner?: string;
  /**
   * @example
   * 最后一次活跃时间戳最大值
   */
  lastActiveTimeEnd?: number;
  /**
   * @example
   * 最后一次活跃时间戳最小值
   */
  lastActiveTimeStart?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 当前查询人的userId
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 分页大小，最大不能超过100
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 分页号，从1开始
   */
  pageStart?: number;
  /**
   * @example
   * 是否同步到钉盘 0不同步 1同步
   */
  syncToDingpan?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 每次查询唯一标识，保证每次分页查询时该值不变
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  itemCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  items?: SearchOrgInnerGroupInfoResponseBodyItems[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchOrgInnerGroupInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 开会
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  deptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉开放组织别名
   */
  orgAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  partnerLabelId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  partnerNum?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 133XXXXXX57
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 开会
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendPhoneDingResponseBody;
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

export class SetConversationCategoryHeaders extends $tea.Model {
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

export class SetConversationCategoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * -1
   */
  categoryId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      categoryId: 'categoryId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryId: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetConversationCategoryResponseBody extends $tea.Model {
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

export class SetConversationCategoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SetConversationCategoryResponseBody;
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
      body: SetConversationCategoryResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  deptId?: string;
  labelIds?: string[];
  /**
   * @example
   * 1234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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

export class SpecialRuleBatchReceiverHeaders extends $tea.Model {
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

export class SpecialRuleBatchReceiverRequest extends $tea.Model {
  batchNo?: string;
  cardOptions?: string;
  data?: SpecialRuleBatchReceiverRequestData[];
  ruleCode?: string;
  secretKey?: string;
  specialStrategy?: boolean;
  taskBatchNo?: string;
  static names(): { [key: string]: string } {
    return {
      batchNo: 'batchNo',
      cardOptions: 'cardOptions',
      data: 'data',
      ruleCode: 'ruleCode',
      secretKey: 'secretKey',
      specialStrategy: 'specialStrategy',
      taskBatchNo: 'taskBatchNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      batchNo: 'string',
      cardOptions: 'string',
      data: { 'type': 'array', 'itemType': SpecialRuleBatchReceiverRequestData },
      ruleCode: 'string',
      secretKey: 'string',
      specialStrategy: 'boolean',
      taskBatchNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpecialRuleBatchReceiverResponseBody extends $tea.Model {
  code?: number;
  data?: SpecialRuleBatchReceiverResponseBodyData[];
  msg?: string;
  msgId?: string;
  rows?: SpecialRuleBatchReceiverResponseBodyRows[][];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      msg: 'msg',
      msgId: 'msgId',
      rows: 'rows',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: { 'type': 'array', 'itemType': SpecialRuleBatchReceiverResponseBodyData },
      msg: 'string',
      msgId: 'string',
      rows: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': SpecialRuleBatchReceiverResponseBodyRows } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpecialRuleBatchReceiverResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SpecialRuleBatchReceiverResponseBody;
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
      body: SpecialRuleBatchReceiverResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoAddDelTaskPersonHeaders extends $tea.Model {
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

export class TaskInfoAddDelTaskPersonRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  operateType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorAccount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  projId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  secretKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskExecutePersonDTOS?: TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS[];
  static names(): { [key: string]: string } {
    return {
      operateType: 'operateType',
      operatorAccount: 'operatorAccount',
      outTaskId: 'outTaskId',
      projId: 'projId',
      secretKey: 'secretKey',
      taskExecutePersonDTOS: 'taskExecutePersonDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operateType: 'number',
      operatorAccount: 'string',
      outTaskId: 'string',
      projId: 'string',
      secretKey: 'string',
      taskExecutePersonDTOS: { 'type': 'array', 'itemType': TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoAddDelTaskPersonResponseBody extends $tea.Model {
  code?: number;
  data?: any;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: 'any',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoAddDelTaskPersonResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TaskInfoAddDelTaskPersonResponseBody;
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
      body: TaskInfoAddDelTaskPersonResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCancelOrDelTaskHeaders extends $tea.Model {
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

export class TaskInfoCancelOrDelTaskRequest extends $tea.Model {
  cardDTO?: TaskInfoCancelOrDelTaskRequestCardDTO;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorAccount?: string;
  outTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  projId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  secretKey?: string;
  sendMsgFlag?: number;
  taskExecutePersonDTOS?: TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS[];
  static names(): { [key: string]: string } {
    return {
      cardDTO: 'cardDTO',
      operatorAccount: 'operatorAccount',
      outTaskId: 'outTaskId',
      projId: 'projId',
      secretKey: 'secretKey',
      sendMsgFlag: 'sendMsgFlag',
      taskExecutePersonDTOS: 'taskExecutePersonDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardDTO: TaskInfoCancelOrDelTaskRequestCardDTO,
      operatorAccount: 'string',
      outTaskId: 'string',
      projId: 'string',
      secretKey: 'string',
      sendMsgFlag: 'number',
      taskExecutePersonDTOS: { 'type': 'array', 'itemType': TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCancelOrDelTaskResponseBody extends $tea.Model {
  code?: number;
  data?: any;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: 'any',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCancelOrDelTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TaskInfoCancelOrDelTaskResponseBody;
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
      body: TaskInfoCancelOrDelTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskHeaders extends $tea.Model {
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

export class TaskInfoCreateAndStartTaskRequest extends $tea.Model {
  attr?: TaskInfoCreateAndStartTaskRequestAttr;
  backlogDTO?: TaskInfoCreateAndStartTaskRequestBacklogDTO;
  backlogGenerateFlag?: number;
  businessCode?: string;
  canceldelTaskCardId?: string;
  cardDTO?: TaskInfoCreateAndStartTaskRequestCardDTO;
  /**
   * @remarks
   * This parameter is required.
   */
  customFlag?: number;
  detailUrl?: TaskInfoCreateAndStartTaskRequestDetailUrl;
  finishTaskCardId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorAccount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  projId?: string;
  robotCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  secretKey?: string;
  sendMsgFlag?: number;
  sort?: number;
  startTaskCardId?: string;
  state?: number;
  taskContent?: string;
  taskEndTime?: number;
  taskExecutePersonDTOS?: TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS[];
  taskGroupDTOList?: TaskInfoCreateAndStartTaskRequestTaskGroupDTOList[];
  /**
   * @remarks
   * This parameter is required.
   */
  taskSystem?: string;
  taskTemplCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskTitle?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  taskType?: string;
  taskUrlMobile?: string;
  taskUrlPc?: string;
  updateTaskCardId?: string;
  static names(): { [key: string]: string } {
    return {
      attr: 'attr',
      backlogDTO: 'backlogDTO',
      backlogGenerateFlag: 'backlogGenerateFlag',
      businessCode: 'businessCode',
      canceldelTaskCardId: 'canceldelTaskCardId',
      cardDTO: 'cardDTO',
      customFlag: 'customFlag',
      detailUrl: 'detailUrl',
      finishTaskCardId: 'finishTaskCardId',
      operatorAccount: 'operatorAccount',
      outTaskId: 'outTaskId',
      projId: 'projId',
      robotCode: 'robotCode',
      secretKey: 'secretKey',
      sendMsgFlag: 'sendMsgFlag',
      sort: 'sort',
      startTaskCardId: 'startTaskCardId',
      state: 'state',
      taskContent: 'taskContent',
      taskEndTime: 'taskEndTime',
      taskExecutePersonDTOS: 'taskExecutePersonDTOS',
      taskGroupDTOList: 'taskGroupDTOList',
      taskSystem: 'taskSystem',
      taskTemplCode: 'taskTemplCode',
      taskTitle: 'taskTitle',
      taskType: 'taskType',
      taskUrlMobile: 'taskUrlMobile',
      taskUrlPc: 'taskUrlPc',
      updateTaskCardId: 'updateTaskCardId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attr: TaskInfoCreateAndStartTaskRequestAttr,
      backlogDTO: TaskInfoCreateAndStartTaskRequestBacklogDTO,
      backlogGenerateFlag: 'number',
      businessCode: 'string',
      canceldelTaskCardId: 'string',
      cardDTO: TaskInfoCreateAndStartTaskRequestCardDTO,
      customFlag: 'number',
      detailUrl: TaskInfoCreateAndStartTaskRequestDetailUrl,
      finishTaskCardId: 'string',
      operatorAccount: 'string',
      outTaskId: 'string',
      projId: 'string',
      robotCode: 'string',
      secretKey: 'string',
      sendMsgFlag: 'number',
      sort: 'number',
      startTaskCardId: 'string',
      state: 'number',
      taskContent: 'string',
      taskEndTime: 'number',
      taskExecutePersonDTOS: { 'type': 'array', 'itemType': TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS },
      taskGroupDTOList: { 'type': 'array', 'itemType': TaskInfoCreateAndStartTaskRequestTaskGroupDTOList },
      taskSystem: 'string',
      taskTemplCode: 'string',
      taskTitle: 'string',
      taskType: 'string',
      taskUrlMobile: 'string',
      taskUrlPc: 'string',
      updateTaskCardId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskResponseBody extends $tea.Model {
  code?: number;
  data?: TaskInfoCreateAndStartTaskResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: TaskInfoCreateAndStartTaskResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TaskInfoCreateAndStartTaskResponseBody;
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
      body: TaskInfoCreateAndStartTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoFinishTaskHeaders extends $tea.Model {
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

export class TaskInfoFinishTaskRequest extends $tea.Model {
  cardDTO?: TaskInfoFinishTaskRequestCardDTO;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorAccount?: string;
  outTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  projId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  secretKey?: string;
  sendMsgFlag?: number;
  taskExecutePersonDTOS?: TaskInfoFinishTaskRequestTaskExecutePersonDTOS[];
  static names(): { [key: string]: string } {
    return {
      cardDTO: 'cardDTO',
      operatorAccount: 'operatorAccount',
      outTaskId: 'outTaskId',
      projId: 'projId',
      secretKey: 'secretKey',
      sendMsgFlag: 'sendMsgFlag',
      taskExecutePersonDTOS: 'taskExecutePersonDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardDTO: TaskInfoFinishTaskRequestCardDTO,
      operatorAccount: 'string',
      outTaskId: 'string',
      projId: 'string',
      secretKey: 'string',
      sendMsgFlag: 'number',
      taskExecutePersonDTOS: { 'type': 'array', 'itemType': TaskInfoFinishTaskRequestTaskExecutePersonDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoFinishTaskResponseBody extends $tea.Model {
  code?: number;
  data?: any;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: 'any',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoFinishTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TaskInfoFinishTaskResponseBody;
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
      body: TaskInfoFinishTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskHeaders extends $tea.Model {
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

export class TaskInfoUpdateTaskRequest extends $tea.Model {
  attr?: TaskInfoUpdateTaskRequestAttr;
  canceldelTaskCardId?: string;
  cardDTO?: TaskInfoUpdateTaskRequestCardDTO;
  detailUrl?: TaskInfoUpdateTaskRequestDetailUrl;
  finishTaskCardId?: string;
  listOpenConversationId?: string[];
  operateType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorAccount?: string;
  outTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  projId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  secretKey?: string;
  sendMsgFlag?: number;
  startTaskCardId?: string;
  taskContent?: string;
  taskEndTime?: number;
  taskExecutePersonDTOS?: TaskInfoUpdateTaskRequestTaskExecutePersonDTOS[];
  taskTitle?: string;
  taskUrlMobile?: string;
  taskUrlPc?: string;
  updateTaskCardId?: string;
  static names(): { [key: string]: string } {
    return {
      attr: 'attr',
      canceldelTaskCardId: 'canceldelTaskCardId',
      cardDTO: 'cardDTO',
      detailUrl: 'detailUrl',
      finishTaskCardId: 'finishTaskCardId',
      listOpenConversationId: 'listOpenConversationId',
      operateType: 'operateType',
      operatorAccount: 'operatorAccount',
      outTaskId: 'outTaskId',
      projId: 'projId',
      secretKey: 'secretKey',
      sendMsgFlag: 'sendMsgFlag',
      startTaskCardId: 'startTaskCardId',
      taskContent: 'taskContent',
      taskEndTime: 'taskEndTime',
      taskExecutePersonDTOS: 'taskExecutePersonDTOS',
      taskTitle: 'taskTitle',
      taskUrlMobile: 'taskUrlMobile',
      taskUrlPc: 'taskUrlPc',
      updateTaskCardId: 'updateTaskCardId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attr: TaskInfoUpdateTaskRequestAttr,
      canceldelTaskCardId: 'string',
      cardDTO: TaskInfoUpdateTaskRequestCardDTO,
      detailUrl: TaskInfoUpdateTaskRequestDetailUrl,
      finishTaskCardId: 'string',
      listOpenConversationId: { 'type': 'array', 'itemType': 'string' },
      operateType: 'number',
      operatorAccount: 'string',
      outTaskId: 'string',
      projId: 'string',
      secretKey: 'string',
      sendMsgFlag: 'number',
      startTaskCardId: 'string',
      taskContent: 'string',
      taskEndTime: 'number',
      taskExecutePersonDTOS: { 'type': 'array', 'itemType': TaskInfoUpdateTaskRequestTaskExecutePersonDTOS },
      taskTitle: 'string',
      taskUrlMobile: 'string',
      taskUrlPc: 'string',
      updateTaskCardId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskResponseBody extends $tea.Model {
  code?: number;
  data?: TaskInfoUpdateTaskResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: TaskInfoUpdateTaskResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TaskInfoUpdateTaskResponseBody;
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
      body: TaskInfoUpdateTaskResponseBody,
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
  /**
   * @example
   * demo
   */
  currentCategoryName?: string;
  /**
   * @example
   * demo01
   */
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
  /**
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateCategoryNameResponseBody;
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

export class UpdateConversationTypeHeaders extends $tea.Model {
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

export class UpdateConversationTypeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  manageSign?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      manageSign: 'manageSign',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      manageSign: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateConversationTypeResponseBody extends $tea.Model {
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

export class UpdateConversationTypeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateConversationTypeResponseBody;
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
      body: UpdateConversationTypeResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  requestIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1-检测通过，2-检测失败
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateFileStatusResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 500000003
   */
  miniAppId?: string;
  /**
   * @example
   * 0.0.5
   */
  version?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0-开发版，1-灰度版，2-发布版，3-体验版
   */
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
  /**
   * @example
   * 成功
   */
  cause?: string;
  /**
   * @example
   * 200
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateMiniAppVersionStatusResponseBody;
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
  /**
   * @example
   * 0.0.5
   */
  deptIds?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1312312
   */
  labelId?: number;
  /**
   * @example
   * 500000003
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: boolean;
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

export class UpdateRealmLicenseHeaders extends $tea.Model {
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

export class UpdateRealmLicenseRequest extends $tea.Model {
  detailList?: UpdateRealmLicenseRequestDetailList[];
  static names(): { [key: string]: string } {
    return {
      detailList: 'detailList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailList: { 'type': 'array', 'itemType': UpdateRealmLicenseRequestDetailList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRealmLicenseResponseBody extends $tea.Model {
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

export class UpdateRealmLicenseResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateRealmLicenseResponseBody;
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
      body: UpdateRealmLicenseResponseBody,
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
  /**
   * @example
   * 0.0.5
   */
  deptIds?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1312312
   */
  labelId?: number;
  /**
   * @example
   * 500000003
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: boolean;
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
  /**
   * @example
   * 0
   */
  fileStorageMode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxxxxxxxx
   */
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
  /**
   * @example
   * ding66b0e9d003fc91ed35c2f4xxxxxxxxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateStorageModeResponseBody;
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

export class UpdateVoiceMsgCtrlStatusHeaders extends $tea.Model {
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

export class UpdateVoiceMsgCtrlStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1-检测通过，2-检测失败
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  voiceMsgCtrlInfo?: UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      voiceMsgCtrlInfo: 'voiceMsgCtrlInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
      voiceMsgCtrlInfo: UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVoiceMsgCtrlStatusResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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

export class UpdateVoiceMsgCtrlStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateVoiceMsgCtrlStatusResponseBody;
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
      body: UpdateVoiceMsgCtrlStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveProcessCallbackRequestRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * agree
   */
  approveResult?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  approveType?: string;
  approvers?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1495592259000
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * approve_open_group_expansion
   */
  eventType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1495592259000
   */
  finishTime?: number;
  params?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * test
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-04
   */
  statisticTime?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14000
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://down-cdn.dingtalk.com/ddmedia/iAEKAqRmaWxlAwYEzh55BdsFzlFx040G2gAhhAGkC1HdIgKqLZPt3bUH2pAeUAPPAAABgRPQ5KgEzTBIBwAIAA.file
   */
  darkWatermark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0138350100401024915916
   */
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
  /**
   * @example
   * 财务部
   */
  deptName?: number;
  /**
   * @example
   * 小张
   */
  name?: string;
  /**
   * @example
   * 123***
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  labelId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 一级供应商
   */
  labelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  labelId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 二级供应商
   */
  labelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  labelId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 三级供应商
   */
  labelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  labelId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 四级供应商
   */
  labelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  labelId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 五级供应商
   */
  labelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  deptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 管理部
   */
  deptName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  memberCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  partnerLabelVOLevel1?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1;
  /**
   * @remarks
   * This parameter is required.
   */
  partnerLabelVOLevel2?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2;
  /**
   * @remarks
   * This parameter is required.
   */
  partnerLabelVOLevel3?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3;
  /**
   * @remarks
   * This parameter is required.
   */
  partnerLabelVOLevel4?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4;
  /**
   * @remarks
   * This parameter is required.
   */
  partnerLabelVOLevel5?: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  partnerNum?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  attendDuration?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  staffId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetConversationCategoryResponseBodyResultChildren extends $tea.Model {
  categoryId?: number;
  categoryName?: string;
  levelNum?: number;
  order?: number;
  static names(): { [key: string]: string } {
    return {
      categoryId: 'categoryId',
      categoryName: 'categoryName',
      levelNum: 'levelNum',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryId: 'number',
      categoryName: 'string',
      levelNum: 'number',
      order: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationCategoryResponseBodyResult extends $tea.Model {
  categoryId?: number;
  categoryName?: string;
  children?: GetConversationCategoryResponseBodyResultChildren[];
  levelNum?: number;
  order?: number;
  static names(): { [key: string]: string } {
    return {
      categoryId: 'categoryId',
      categoryName: 'categoryName',
      children: 'children',
      levelNum: 'levelNum',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryId: 'number',
      categoryName: 'string',
      children: { 'type': 'array', 'itemType': GetConversationCategoryResponseBodyResultChildren },
      levelNum: 'number',
      order: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingReportDeptSummaryResponseBodyData extends $tea.Model {
  /**
   * @example
   * 123
   */
  deptId?: string;
  /**
   * @example
   * 部门A
   */
  deptName?: string;
  /**
   * @example
   * 100
   */
  dingReportSendCnt?: string;
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * 100
   */
  createDocUserCnt1d?: string;
  /**
   * @example
   * 123
   */
  deptId?: string;
  /**
   * @example
   * 部门A
   */
  deptName?: string;
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * ding32xxxxxxxxe0105d
   */
  corpId?: string;
  /**
   * @example
   * true
   */
  isMainOrg?: boolean;
  /**
   * @example
   * http://xxx.dingtalk.com/xxx.jpg
   */
  logoUrl?: string;
  /**
   * @example
   * 钉钉(中国)信息技术有限公司
   */
  orgFullName?: string;
  /**
   * @example
   * 钉钉
   */
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
  /**
   * @example
   * 123
   */
  deptId?: string;
  /**
   * @example
   * 部门A
   */
  deptName?: string;
  /**
   * @example
   * 100
   */
  generalFormCreateCnt1d?: string;
  /**
   * @example
   * 100
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetMsgConfigRequestListDynamicAttr extends $tea.Model {
  attrCode?: string;
  listAttrOptionsCode?: string[];
  static names(): { [key: string]: string } {
    return {
      attrCode: 'attrCode',
      listAttrOptionsCode: 'listAttrOptionsCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attrCode: 'string',
      listAttrOptionsCode: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr extends $tea.Model {
  attrCode?: string;
  listAttrOptionsCode?: string[];
  static names(): { [key: string]: string } {
    return {
      attrCode: 'attrCode',
      listAttrOptionsCode: 'listAttrOptionsCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attrCode: 'string',
      listAttrOptionsCode: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyDataGroupAttributesListReceiver extends $tea.Model {
  employeeCode?: string;
  employeeName?: string;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
      employeeName: 'employeeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
      employeeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyDataGroupAttributes extends $tea.Model {
  configGroupId?: number;
  corpId?: string;
  groupTopic?: string;
  groupType?: string;
  listDynamicAttr?: GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr[];
  listReceiver?: GetMsgConfigResponseBodyDataGroupAttributesListReceiver[];
  openConversationId?: string;
  ownerJobNo?: string;
  subRuleCode?: string;
  static names(): { [key: string]: string } {
    return {
      configGroupId: 'configGroupId',
      corpId: 'corpId',
      groupTopic: 'groupTopic',
      groupType: 'groupType',
      listDynamicAttr: 'listDynamicAttr',
      listReceiver: 'listReceiver',
      openConversationId: 'openConversationId',
      ownerJobNo: 'ownerJobNo',
      subRuleCode: 'subRuleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      configGroupId: 'number',
      corpId: 'string',
      groupTopic: 'string',
      groupType: 'string',
      listDynamicAttr: { 'type': 'array', 'itemType': GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr },
      listReceiver: { 'type': 'array', 'itemType': GetMsgConfigResponseBodyDataGroupAttributesListReceiver },
      openConversationId: 'string',
      ownerJobNo: 'string',
      subRuleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyDataMsgConfigs extends $tea.Model {
  cardId?: string;
  corpId?: string;
  customParameters?: string;
  msgContentConsisFlag?: number;
  msgId?: string;
  robotCode?: string;
  ruleBusinessCode?: string;
  ruleCategory?: number;
  ruleCode?: string;
  ruleName?: string;
  subRuleCode?: string;
  systemCode?: string;
  taskBatchNo?: string;
  static names(): { [key: string]: string } {
    return {
      cardId: 'cardId',
      corpId: 'corpId',
      customParameters: 'customParameters',
      msgContentConsisFlag: 'msgContentConsisFlag',
      msgId: 'msgId',
      robotCode: 'robotCode',
      ruleBusinessCode: 'ruleBusinessCode',
      ruleCategory: 'ruleCategory',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
      subRuleCode: 'subRuleCode',
      systemCode: 'systemCode',
      taskBatchNo: 'taskBatchNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardId: 'string',
      corpId: 'string',
      customParameters: 'string',
      msgContentConsisFlag: 'number',
      msgId: 'string',
      robotCode: 'string',
      ruleBusinessCode: 'string',
      ruleCategory: 'number',
      ruleCode: 'string',
      ruleName: 'string',
      subRuleCode: 'string',
      systemCode: 'string',
      taskBatchNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyDataReceiverAttributes extends $tea.Model {
  employeeCode?: string;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyDataUnitAttributes extends $tea.Model {
  unitId?: number;
  static names(): { [key: string]: string } {
    return {
      unitId: 'unitId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unitId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMsgConfigResponseBodyData extends $tea.Model {
  groupAttributes?: GetMsgConfigResponseBodyDataGroupAttributes[];
  msgConfigs?: GetMsgConfigResponseBodyDataMsgConfigs;
  receiverAttributes?: GetMsgConfigResponseBodyDataReceiverAttributes[];
  unitAttributes?: GetMsgConfigResponseBodyDataUnitAttributes[];
  static names(): { [key: string]: string } {
    return {
      groupAttributes: 'groupAttributes',
      msgConfigs: 'msgConfigs',
      receiverAttributes: 'receiverAttributes',
      unitAttributes: 'unitAttributes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupAttributes: { 'type': 'array', 'itemType': GetMsgConfigResponseBodyDataGroupAttributes },
      msgConfigs: GetMsgConfigResponseBodyDataMsgConfigs,
      receiverAttributes: { 'type': 'array', 'itemType': GetMsgConfigResponseBodyDataReceiverAttributes },
      unitAttributes: { 'type': 'array', 'itemType': GetMsgConfigResponseBodyDataUnitAttributes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOaOperatorLogListResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  category1Name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  category2Name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  opName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  opTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * {   "text": {     "content": "这是一段文本"   } }
   */
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
  /**
   * @example
   * 10
   */
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
  /**
   * @example
   * user1234
   */
  id?: string;
  /**
   * @example
   * userId
   */
  idType?: string;
  /**
   * @example
   * user
   */
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
  /**
   * @example
   * {   "text": {     "content": "这是一段文本"   } }
   */
  content?: string;
  /**
   * @example
   * text/audio/video
   */
  contentType?: string;
  /**
   * @example
   * 2022-07-05 15:43:03
   */
  createAt?: string;
  /**
   * @example
   * cid123456
   */
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
  /**
   * @example
   * 1680493837428
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  labelId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 目前无意义
   */
  typeId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 经销商
   */
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
  /**
   * @example
   * 123
   */
  id?: number;
  /**
   * @example
   * 测试部门
   */
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
  /**
   * @example
   * 测试角色
   */
  name?: string;
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * 张三
   */
  name?: string;
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * 1
   */
  deviceScopeType?: number;
  deviceStaffs?: GetPublicDevicesResponseBodyDataDeviceStaffs[];
  /**
   * @example
   * 1671767361000
   */
  gmtCreate?: number;
  /**
   * @example
   * 1671767361000
   */
  gmtModified?: number;
  /**
   * @example
   * 88:66:5a:07:2b:04
   */
  macAddress?: string;
  /**
   * @example
   * Mac
   */
  platform?: string;
  /**
   * @example
   * 这是标题
   */
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
  /**
   * @example
   * 100
   */
  publisherArticleCntStd?: string;
  /**
   * @example
   * 100
   */
  publisherArticlePvCntStd?: string;
  /**
   * @example
   * 服务窗1
   */
  publisherName?: string;
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * 文章1
   */
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
  /**
   * @example
   * agentId
   */
  agentId?: number;
  /**
   * @example
   * 166700000
   */
  invokeTime?: number;
  /**
   * @example
   * 1
   */
  personIdentification?: number;
  /**
   * @example
   * 1
   */
  platform?: number;
  /**
   * @example
   * 1
   */
  scene?: number;
  /**
   * @example
   * 1234
   */
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
  /**
   * @example
   * agentId
   */
  agentId?: number;
  /**
   * @example
   * 1
   */
  faceCompareResult?: number;
  /**
   * @example
   * 166700000
   */
  invokeTime?: number;
  /**
   * @example
   * 1
   */
  platform?: number;
  /**
   * @example
   * 1234
   */
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
  /**
   * @example
   * 部门1
   */
  deptName?: string;
  /**
   * @example
   * **@**.com
   */
  email?: string;
  /**
   * @example
   * 小张
   */
  name?: string;
  /**
   * @example
   * ***
   */
  phone?: string;
  /**
   * @example
   * 主管理员
   */
  roles?: string;
  /**
   * @example
   * 123***
   */
  staffId?: string;
  /**
   * @example
   * 经理
   */
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
  /**
   * @example
   * 1628650483
   */
  createTime?: number;
  /**
   * @example
   * 88:92:5a:1f:e8:24
   */
  macAddress?: string;
  model?: string;
  /**
   * @example
   * Mac
   */
  platform?: string;
  /**
   * @example
   * 2
   */
  status?: number;
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 65224157501039784
   */
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
  /**
   * @example
   * 6.0
   */
  appVersion?: string;
  /**
   * @example
   * iOS
   */
  client?: string;
  /**
   * @example
   * 组织1
   */
  orgName?: string;
  /**
   * @example
   * 20210808
   */
  statDate?: string;
  /**
   * @example
   * 10
   */
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
  /**
   * @example
   * 1
   */
  state?: number;
  /**
   * @example
   * userId
   */
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
  /**
   * @example
   * 1
   */
  state?: number;
  /**
   * @example
   * userId
   */
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
  /**
   * @example
   * 小张
   */
  name?: string;
  /**
   * @example
   * 20220501
   */
  statDate?: string;
  /**
   * @example
   * 1000
   */
  stayTimeLenApp1d?: number;
  /**
   * @example
   * 2000
   */
  stayTimeLenPc1d?: number;
  /**
   * @example
   * 123***
   */
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
  /**
   * @example
   * 张三
   */
  memberName?: string;
  /**
   * @example
   * 0
   */
  memberType?: number;
  /**
   * @example
   * 部门
   */
  memberTypeView?: string;
  /**
   * @example
   * 1
   */
  permissionRole?: number;
  /**
   * @example
   * 阅读者（可查看\下载）
   */
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
  /**
   * @example
   * 张三
   */
  receiverName?: string;
  /**
   * @example
   * 1
   */
  receiverType?: number;
  /**
   * @example
   * 单聊
   */
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
  /**
   * @example
   * 0
   */
  action?: number;
  /**
   * @example
   * 企业群
   */
  actionView?: string;
  /**
   * @example
   * 11258620701
   */
  bizId?: string;
  docMemberList?: ListAuditLogResponseBodyListDocMemberList[];
  docMobileUrl?: string;
  docPcUrl?: string;
  docReceiverList?: ListAuditLogResponseBodyListDocReceiverList[];
  /**
   * @example
   * 1577601221260
   */
  gmtCreate?: number;
  /**
   * @example
   * 1577601221260
   */
  gmtModified?: number;
  /**
   * @example
   * 1.1.1.1
   */
  ipAddress?: string;
  /**
   * @example
   * 2
   */
  operateModule?: number;
  /**
   * @example
   * 企业群
   */
  operateModuleView?: string;
  /**
   * @example
   * 测试
   */
  operatorName?: string;
  /**
   * @example
   * 水果公司
   */
  orgName?: string;
  /**
   * @example
   * 11
   */
  platform?: number;
  /**
   * @example
   * WIN
   */
  platformView?: string;
  prevWorkSpaceId?: number;
  prevWorkSpaceMobileUrl?: string;
  prevWorkSpaceName?: string;
  prevWorkSpacePcUrl?: string;
  /**
   * @example
   * 张三
   */
  realName?: string;
  /**
   * @example
   * 总经理办公室
   */
  receiverName?: string;
  /**
   * @example
   * 0
   */
  receiverType?: number;
  /**
   * @example
   * 单聊
   */
  receiverTypeView?: string;
  /**
   * @example
   * 文件名
   */
  resource?: string;
  /**
   * @example
   * doc
   */
  resourceExtension?: string;
  /**
   * @example
   * 1024
   */
  resourceSize?: number;
  /**
   * @example
   * 0
   */
  status?: number;
  /**
   * @example
   * 11258620
   */
  targetSpaceId?: number;
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding32xxxxxxxxe0105d
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * testCode
   */
  domain?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉(中国)信息技术有限公司
   */
  orgFullName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  buildStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.0.5
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0-打包中 ，1-成功，2-失败
   */
  buildStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://xxx.con/download/id
   */
  h5Bundle?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5000
   */
  packageSize?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://xxx.con/download/id
   */
  packageUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.0.5
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 123
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  isNecessary?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 供应商
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  visibleDepts?: ListPartnerRolesResponseBodyListVisibleDepts[];
  /**
   * @remarks
   * This parameter is required.
   */
  visibleUsers?: ListPartnerRolesResponseBodyListVisibleUsers[];
  /**
   * @remarks
   * This parameter is required.
   */
  warningDepts?: ListPartnerRolesResponseBodyListWarningDepts[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * be0d84e04316488cxxxxxxxx129522b0
   */
  bizOuterId?: string;
  /**
   * @example
   * 测试打卡机
   */
  positionName?: string;
  /**
   * @example
   * checkIn
   */
  punchSymbol?: string;
  /**
   * @example
   * 200003
   */
  userId?: string;
  /**
   * @example
   * 1647333408000
   */
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
  /**
   * @example
   * 1
   */
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

export class PreventCheatingCheckRiskResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  hasRisk?: boolean;
  riskInfo?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      hasRisk: 'hasRisk',
      riskInfo: 'riskInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasRisk: 'boolean',
      riskInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushBadgeRequestBadgeItems extends $tea.Model {
  /**
   * @example
   * 1
   */
  pushValue?: string;
  /**
   * @example
   * 12345
   */
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

export class QueryChannelStaffInfoByMobileResponseBodyEmpInfo extends $tea.Model {
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

export class QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList extends $tea.Model {
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
  /**
   * @remarks
   * This parameter is required.
   */
  memberCount?: number;
  partnerLabelModelLevel1?: QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1;
  partnerNum?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class RuleBatchReceiverRequestDataAttrs extends $tea.Model {
  listUnitId?: number[];
  static names(): { [key: string]: string } {
    return {
      listUnitId: 'listUnitId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      listUnitId: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RuleBatchReceiverRequestData extends $tea.Model {
  atAccount?: string;
  attrs?: RuleBatchReceiverRequestDataAttrs;
  callbackUrl?: string;
  cardCallbackUrl?: string;
  content?: { [key: string]: {[key: string]: any} };
  isAtAll?: boolean;
  receiverAccount?: string;
  receiverType?: number;
  serialNumber?: string;
  static names(): { [key: string]: string } {
    return {
      atAccount: 'atAccount',
      attrs: 'attrs',
      callbackUrl: 'callbackUrl',
      cardCallbackUrl: 'cardCallbackUrl',
      content: 'content',
      isAtAll: 'isAtAll',
      receiverAccount: 'receiverAccount',
      receiverType: 'receiverType',
      serialNumber: 'serialNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAccount: 'string',
      attrs: RuleBatchReceiverRequestDataAttrs,
      callbackUrl: 'string',
      cardCallbackUrl: 'string',
      content: { 'type': 'map', 'keyType': 'string', 'valueType': '{[key: string]: any}' },
      isAtAll: 'boolean',
      receiverAccount: 'string',
      receiverType: 'number',
      serialNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RuleBatchReceiverResponseBodyData extends $tea.Model {
  msgId?: string;
  serialNumber?: string;
  static names(): { [key: string]: string } {
    return {
      msgId: 'msgId',
      serialNumber: 'serialNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgId: 'string',
      serialNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RuleBatchReceiverResponseBodyRows extends $tea.Model {
  serialNumber?: string;
  msgId?: string;
  static names(): { [key: string]: string } {
    return {
      serialNumber: 'serialNumber',
      msgId: 'msgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serialNumber: 'string',
      msgId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStorageFunctionSwitchRequestFunctionList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  functionKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  functionValue?: string;
  static names(): { [key: string]: string } {
    return {
      functionKey: 'functionKey',
      functionValue: 'functionValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      functionKey: 'string',
      functionValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOrgInnerGroupInfoResponseBodyItems extends $tea.Model {
  extensions?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  groupAdminsCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  groupCreateTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  groupLastActiveTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  groupLastActiveTimeShow?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  groupMembersCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  groupOwner?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  groupOwnerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  syncToDingpan?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  templateId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  templateName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      extensions: 'extensions',
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
      extensions: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class SpecialRuleBatchReceiverRequestDataAttrs extends $tea.Model {
  listUnitId?: number[];
  static names(): { [key: string]: string } {
    return {
      listUnitId: 'listUnitId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      listUnitId: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpecialRuleBatchReceiverRequestData extends $tea.Model {
  atAccount?: string;
  attrs?: SpecialRuleBatchReceiverRequestDataAttrs;
  callbackUrl?: string;
  cardCallbackUrl?: string;
  content?: { [key: string]: {[key: string]: any} };
  isAtAll?: boolean;
  privateContent?: { [key: string]: {[key: string]: any} };
  receiverAccount?: string;
  receiverType?: number;
  serialNumber?: string;
  static names(): { [key: string]: string } {
    return {
      atAccount: 'atAccount',
      attrs: 'attrs',
      callbackUrl: 'callbackUrl',
      cardCallbackUrl: 'cardCallbackUrl',
      content: 'content',
      isAtAll: 'isAtAll',
      privateContent: 'privateContent',
      receiverAccount: 'receiverAccount',
      receiverType: 'receiverType',
      serialNumber: 'serialNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAccount: 'string',
      attrs: SpecialRuleBatchReceiverRequestDataAttrs,
      callbackUrl: 'string',
      cardCallbackUrl: 'string',
      content: { 'type': 'map', 'keyType': 'string', 'valueType': '{[key: string]: any}' },
      isAtAll: 'boolean',
      privateContent: { 'type': 'map', 'keyType': 'string', 'valueType': '{[key: string]: any}' },
      receiverAccount: 'string',
      receiverType: 'number',
      serialNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpecialRuleBatchReceiverResponseBodyData extends $tea.Model {
  msgId?: string;
  serialNumber?: string;
  static names(): { [key: string]: string } {
    return {
      msgId: 'msgId',
      serialNumber: 'serialNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgId: 'string',
      serialNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpecialRuleBatchReceiverResponseBodyRows extends $tea.Model {
  serialNumber?: string;
  msgId?: string;
  static names(): { [key: string]: string } {
    return {
      serialNumber: 'serialNumber',
      msgId: 'msgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serialNumber: 'string',
      msgId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS extends $tea.Model {
  employeeCode?: string;
  personType?: number;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
      personType: 'personType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
      personType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCancelOrDelTaskRequestCardDTO extends $tea.Model {
  atAccount?: string;
  cardCallbackUrl?: string;
  content?: any;
  isAtAll?: boolean;
  receiverAccount?: string;
  static names(): { [key: string]: string } {
    return {
      atAccount: 'atAccount',
      cardCallbackUrl: 'cardCallbackUrl',
      content: 'content',
      isAtAll: 'isAtAll',
      receiverAccount: 'receiverAccount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAccount: 'string',
      cardCallbackUrl: 'string',
      content: 'any',
      isAtAll: 'boolean',
      receiverAccount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS extends $tea.Model {
  employeeCode?: string;
  personType?: number;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
      personType: 'personType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
      personType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr extends $tea.Model {
  attrCode?: string;
  listAttrOptionsCode?: string[];
  static names(): { [key: string]: string } {
    return {
      attrCode: 'attrCode',
      listAttrOptionsCode: 'listAttrOptionsCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attrCode: 'string',
      listAttrOptionsCode: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestAttr extends $tea.Model {
  listTaskDynamicAttr?: TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr[];
  static names(): { [key: string]: string } {
    return {
      listTaskDynamicAttr: 'listTaskDynamicAttr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      listTaskDynamicAttr: { 'type': 'array', 'itemType': TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestBacklogDTOContent extends $tea.Model {
  isOnlyShowExecutor?: boolean;
  priority?: number;
  static names(): { [key: string]: string } {
    return {
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      priority: 'priority',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isOnlyShowExecutor: 'boolean',
      priority: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestBacklogDTO extends $tea.Model {
  content?: TaskInfoCreateAndStartTaskRequestBacklogDTOContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: TaskInfoCreateAndStartTaskRequestBacklogDTOContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestCardDTO extends $tea.Model {
  atAccount?: string;
  cardCallbackUrl?: string;
  content?: any;
  isAtAll?: boolean;
  receiverAccount?: string;
  static names(): { [key: string]: string } {
    return {
      atAccount: 'atAccount',
      cardCallbackUrl: 'cardCallbackUrl',
      content: 'content',
      isAtAll: 'isAtAll',
      receiverAccount: 'receiverAccount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAccount: 'string',
      cardCallbackUrl: 'string',
      content: 'any',
      isAtAll: 'boolean',
      receiverAccount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestDetailUrl extends $tea.Model {
  appUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appUrl: 'appUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS extends $tea.Model {
  employeeCode?: string;
  personType?: number;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
      personType: 'personType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
      personType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskRequestTaskGroupDTOList extends $tea.Model {
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

export class TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList extends $tea.Model {
  corpId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoCreateAndStartTaskResponseBodyData extends $tea.Model {
  groupVoList?: TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList[];
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      groupVoList: 'groupVoList',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupVoList: { 'type': 'array', 'itemType': TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList },
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoFinishTaskRequestCardDTO extends $tea.Model {
  atAccount?: string;
  cardCallbackUrl?: string;
  content?: any;
  isAtAll?: boolean;
  receiverAccount?: string;
  static names(): { [key: string]: string } {
    return {
      atAccount: 'atAccount',
      cardCallbackUrl: 'cardCallbackUrl',
      content: 'content',
      isAtAll: 'isAtAll',
      receiverAccount: 'receiverAccount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAccount: 'string',
      cardCallbackUrl: 'string',
      content: 'any',
      isAtAll: 'boolean',
      receiverAccount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoFinishTaskRequestTaskExecutePersonDTOS extends $tea.Model {
  employeeCode?: string;
  personType?: number;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
      personType: 'personType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
      personType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr extends $tea.Model {
  attrCode?: string;
  listAttrOptionsCode?: string[];
  static names(): { [key: string]: string } {
    return {
      attrCode: 'attrCode',
      listAttrOptionsCode: 'listAttrOptionsCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attrCode: 'string',
      listAttrOptionsCode: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskRequestAttr extends $tea.Model {
  listTaskDynamicAttr?: TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr[];
  static names(): { [key: string]: string } {
    return {
      listTaskDynamicAttr: 'listTaskDynamicAttr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      listTaskDynamicAttr: { 'type': 'array', 'itemType': TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskRequestCardDTO extends $tea.Model {
  atAccount?: string;
  cardCallbackUrl?: string;
  content?: any;
  isAtAll?: boolean;
  receiverAccount?: string;
  static names(): { [key: string]: string } {
    return {
      atAccount: 'atAccount',
      cardCallbackUrl: 'cardCallbackUrl',
      content: 'content',
      isAtAll: 'isAtAll',
      receiverAccount: 'receiverAccount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAccount: 'string',
      cardCallbackUrl: 'string',
      content: 'any',
      isAtAll: 'boolean',
      receiverAccount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskRequestDetailUrl extends $tea.Model {
  appUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appUrl: 'appUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskRequestTaskExecutePersonDTOS extends $tea.Model {
  employeeCode?: string;
  personType?: number;
  static names(): { [key: string]: string } {
    return {
      employeeCode: 'employeeCode',
      personType: 'personType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeCode: 'string',
      personType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskResponseBodyDataGroupVoList extends $tea.Model {
  corpId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TaskInfoUpdateTaskResponseBodyData extends $tea.Model {
  groupVoList?: TaskInfoUpdateTaskResponseBodyDataGroupVoList[];
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      groupVoList: 'groupVoList',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupVoList: { 'type': 'array', 'itemType': TaskInfoUpdateTaskResponseBodyDataGroupVoList },
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRealmLicenseRequestDetailList extends $tea.Model {
  /**
   * @example
   * 1001
   */
  licenseType?: number;
  /**
   * @example
   * 123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      licenseType: 'licenseType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      licenseType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openMsgId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openMsgId: 'openMsgId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openMsgId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 新增企业
   * 
   * @param request - AddOrgRequest
   * @param headers - AddOrgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddOrgResponse
   */
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

  /**
   * 新增企业
   * 
   * @param request - AddOrgRequest
   * @returns AddOrgResponse
   */
  async addOrg(request: AddOrgRequest): Promise<AddOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOrgHeaders({ });
    return await this.addOrgWithOptions(request, headers, runtime);
  }

  /**
   * 专属审批结果回调
   * 
   * @param request - ApproveProcessCallbackRequest
   * @param headers - ApproveProcessCallbackHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ApproveProcessCallbackResponse
   */
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

  /**
   * 专属审批结果回调
   * 
   * @param request - ApproveProcessCallbackRequest
   * @returns ApproveProcessCallbackResponse
   */
  async approveProcessCallback(request: ApproveProcessCallbackRequest): Promise<ApproveProcessCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApproveProcessCallbackHeaders({ });
    return await this.approveProcessCallbackWithOptions(request, headers, runtime);
  }

  /**
   * 群禁言或解禁
   * 
   * @param request - BanOrOpenGroupWordsRequest
   * @param headers - BanOrOpenGroupWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BanOrOpenGroupWordsResponse
   */
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

  /**
   * 群禁言或解禁
   * 
   * @param request - BanOrOpenGroupWordsRequest
   * @returns BanOrOpenGroupWordsResponse
   */
  async banOrOpenGroupWords(request: BanOrOpenGroupWordsRequest): Promise<BanOrOpenGroupWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BanOrOpenGroupWordsHeaders({ });
    return await this.banOrOpenGroupWordsWithOptions(request, headers, runtime);
  }

  /**
   * 创建分组并绑定会话
   * 
   * @param request - CreateCategoryAndBindingGroupsRequest
   * @param headers - CreateCategoryAndBindingGroupsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateCategoryAndBindingGroupsResponse
   */
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

  /**
   * 创建分组并绑定会话
   * 
   * @param request - CreateCategoryAndBindingGroupsRequest
   * @returns CreateCategoryAndBindingGroupsResponse
   */
  async createCategoryAndBindingGroups(request: CreateCategoryAndBindingGroupsRequest): Promise<CreateCategoryAndBindingGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCategoryAndBindingGroupsHeaders({ });
    return await this.createCategoryAndBindingGroupsWithOptions(request, headers, runtime);
  }

  /**
   * 创建文件检测任务
   * 
   * @param request - CreateDlpTaskRequest
   * @param headers - CreateDlpTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDlpTaskResponse
   */
  async createDlpTaskWithOptions(request: CreateDlpTaskRequest, headers: CreateDlpTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDlpTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryId)) {
      body["dentryId"] = request.dentryId;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
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
      action: "CreateDlpTask",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/dlpTasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDlpTaskResponse>(await this.execute(params, req, runtime), new CreateDlpTaskResponse({}));
  }

  /**
   * 创建文件检测任务
   * 
   * @param request - CreateDlpTaskRequest
   * @returns CreateDlpTaskResponse
   */
  async createDlpTask(request: CreateDlpTaskRequest): Promise<CreateDlpTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDlpTaskHeaders({ });
    return await this.createDlpTaskWithOptions(request, headers, runtime);
  }

  /**
   * 创建分组并绑定会话
   * 
   * @param request - CreateMessageCategoryRequest
   * @param headers - CreateMessageCategoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateMessageCategoryResponse
   */
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

  /**
   * 创建分组并绑定会话
   * 
   * @param request - CreateMessageCategoryRequest
   * @returns CreateMessageCategoryResponse
   */
  async createMessageCategory(request: CreateMessageCategoryRequest): Promise<CreateMessageCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMessageCategoryHeaders({ });
    return await this.createMessageCategoryWithOptions(request, headers, runtime);
  }

  /**
   * 创建规则
   * 
   * @param request - CreateRuleRequest
   * @param headers - CreateRuleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateRuleResponse
   */
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

  /**
   * 创建规则
   * 
   * @param request - CreateRuleRequest
   * @returns CreateRuleResponse
   */
  async createRule(request: CreateRuleRequest): Promise<CreateRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRuleHeaders({ });
    return await this.createRuleWithOptions(request, headers, runtime);
  }

  /**
   * 存入可信设备信息
   * 
   * @param request - CreateTrustedDeviceRequest
   * @param headers - CreateTrustedDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateTrustedDeviceResponse
   */
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

  /**
   * 存入可信设备信息
   * 
   * @param request - CreateTrustedDeviceRequest
   * @returns CreateTrustedDeviceResponse
   */
  async createTrustedDevice(request: CreateTrustedDeviceRequest): Promise<CreateTrustedDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceHeaders({ });
    return await this.createTrustedDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 批量新增可信设备
   * 
   * @param request - CreateTrustedDeviceBatchRequest
   * @param headers - CreateTrustedDeviceBatchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateTrustedDeviceBatchResponse
   */
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

  /**
   * 批量新增可信设备
   * 
   * @param request - CreateTrustedDeviceBatchRequest
   * @returns CreateTrustedDeviceBatchResponse
   */
  async createTrustedDeviceBatch(request: CreateTrustedDeviceBatchRequest): Promise<CreateTrustedDeviceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustedDeviceBatchHeaders({ });
    return await this.createTrustedDeviceBatchWithOptions(request, headers, runtime);
  }

  /**
   * 触发文件病毒扫描任务
   * 
   * @param request - CreateVirusScanTaskRequest
   * @param headers - CreateVirusScanTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateVirusScanTaskResponse
   */
  async createVirusScanTaskWithOptions(request: CreateVirusScanTaskRequest, headers: CreateVirusScanTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVirusScanTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryId)) {
      body["dentryId"] = request.dentryId;
    }

    if (!Util.isUnset(request.downloadUrl)) {
      body["downloadUrl"] = request.downloadUrl;
    }

    if (!Util.isUnset(request.fileMd5)) {
      body["fileMd5"] = request.fileMd5;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.spaceId)) {
      body["spaceId"] = request.spaceId;
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
      action: "CreateVirusScanTask",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/virusScanTasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateVirusScanTaskResponse>(await this.execute(params, req, runtime), new CreateVirusScanTaskResponse({}));
  }

  /**
   * 触发文件病毒扫描任务
   * 
   * @param request - CreateVirusScanTaskRequest
   * @returns CreateVirusScanTaskResponse
   */
  async createVirusScanTask(request: CreateVirusScanTaskRequest): Promise<CreateVirusScanTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVirusScanTaskHeaders({ });
    return await this.createVirusScanTaskWithOptions(request, headers, runtime);
  }

  /**
   * 为应用同步数据到专属存储
   * 
   * @param request - DataSyncRequest
   * @param headers - DataSyncHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DataSyncResponse
   */
  async dataSyncWithOptions(request: DataSyncRequest, headers: DataSyncHeaders, runtime: $Util.RuntimeOptions): Promise<DataSyncResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sql)) {
      body["sql"] = request.sql;
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
      action: "DataSync",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/datas/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DataSyncResponse>(await this.execute(params, req, runtime), new DataSyncResponse({}));
  }

  /**
   * 为应用同步数据到专属存储
   * 
   * @param request - DataSyncRequest
   * @returns DataSyncResponse
   */
  async dataSync(request: DataSyncRequest): Promise<DataSyncResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DataSyncHeaders({ });
    return await this.dataSyncWithOptions(request, headers, runtime);
  }

  /**
   * 删除跨云存储配置
   * 
   * @param headers - DeleteAcrossCloudStroageConfigsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteAcrossCloudStroageConfigsResponse
   */
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

  /**
   * 删除跨云存储配置
   * @returns DeleteAcrossCloudStroageConfigsResponse
   */
  async deleteAcrossCloudStroageConfigs(targetCorpId: string): Promise<DeleteAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAcrossCloudStroageConfigsHeaders({ });
    return await this.deleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
  }

  /**
   * 删除评论
   * 
   * @param headers - DeleteCommentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteCommentResponse
   */
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

  /**
   * 删除评论
   * @returns DeleteCommentResponse
   */
  async deleteComment(publisherId: string, commentId: string): Promise<DeleteCommentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCommentHeaders({ });
    return await this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
  }

  /**
   * 删除指定可信设备
   * 
   * @param request - DeleteTrustedDeviceRequest
   * @param headers - DeleteTrustedDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteTrustedDeviceResponse
   */
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

  /**
   * 删除指定可信设备
   * 
   * @param request - DeleteTrustedDeviceRequest
   * @returns DeleteTrustedDeviceResponse
   */
  async deleteTrustedDevice(request: DeleteTrustedDeviceRequest): Promise<DeleteTrustedDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTrustedDeviceHeaders({ });
    return await this.deleteTrustedDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 分发伙伴应用
   * 
   * @param request - DistributePartnerAppRequest
   * @param headers - DistributePartnerAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DistributePartnerAppResponse
   */
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

  /**
   * 分发伙伴应用
   * 
   * @param request - DistributePartnerAppRequest
   * @returns DistributePartnerAppResponse
   */
  async distributePartnerApp(request: DistributePartnerAppRequest): Promise<DistributePartnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DistributePartnerAppHeaders({ });
    return await this.distributePartnerAppWithOptions(request, headers, runtime);
  }

  /**
   * 更换组织主管理员
   * 
   * @param request - ExchangeMainAdminRequest
   * @param headers - ExchangeMainAdminHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExchangeMainAdminResponse
   */
  async exchangeMainAdminWithOptions(request: ExchangeMainAdminRequest, headers: ExchangeMainAdminHeaders, runtime: $Util.RuntimeOptions): Promise<ExchangeMainAdminResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.newAdminUserId)) {
      body["newAdminUserId"] = request.newAdminUserId;
    }

    if (!Util.isUnset(request.oldAdminUserId)) {
      body["oldAdminUserId"] = request.oldAdminUserId;
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
      action: "ExchangeMainAdmin",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/orgnizations/mainAdministrators/exchange`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExchangeMainAdminResponse>(await this.execute(params, req, runtime), new ExchangeMainAdminResponse({}));
  }

  /**
   * 更换组织主管理员
   * 
   * @param request - ExchangeMainAdminRequest
   * @returns ExchangeMainAdminResponse
   */
  async exchangeMainAdmin(request: ExchangeMainAdminRequest): Promise<ExchangeMainAdminResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExchangeMainAdminHeaders({ });
    return await this.exchangeMainAdminWithOptions(request, headers, runtime);
  }

  /**
   * 分发工作台模版
   * 
   * @param request - ExclusiveCreateDingPortalRequest
   * @param headers - ExclusiveCreateDingPortalHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExclusiveCreateDingPortalResponse
   */
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

  /**
   * 分发工作台模版
   * 
   * @param request - ExclusiveCreateDingPortalRequest
   * @returns ExclusiveCreateDingPortalResponse
   */
  async exclusiveCreateDingPortal(request: ExclusiveCreateDingPortalRequest): Promise<ExclusiveCreateDingPortalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExclusiveCreateDingPortalHeaders({ });
    return await this.exclusiveCreateDingPortalWithOptions(request, headers, runtime);
  }

  /**
   * 专属文件第一次设置，激活配置
   * 
   * @param request - FileStorageActiveStorageRequest
   * @param headers - FileStorageActiveStorageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FileStorageActiveStorageResponse
   */
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

  /**
   * 专属文件第一次设置，激活配置
   * 
   * @param request - FileStorageActiveStorageRequest
   * @returns FileStorageActiveStorageResponse
   */
  async fileStorageActiveStorage(request: FileStorageActiveStorageRequest): Promise<FileStorageActiveStorageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageActiveStorageHeaders({ });
    return await this.fileStorageActiveStorageWithOptions(request, headers, runtime);
  }

  /**
   * 检查专属存储OSS连接
   * 
   * @param request - FileStorageCheckConnectionRequest
   * @param headers - FileStorageCheckConnectionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FileStorageCheckConnectionResponse
   */
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

  /**
   * 检查专属存储OSS连接
   * 
   * @param request - FileStorageCheckConnectionRequest
   * @returns FileStorageCheckConnectionResponse
   */
  async fileStorageCheckConnection(request: FileStorageCheckConnectionRequest): Promise<FileStorageCheckConnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageCheckConnectionHeaders({ });
    return await this.fileStorageCheckConnectionWithOptions(request, headers, runtime);
  }

  /**
   * 专属文件存储获取存储情况(按时间区间)
   * 
   * @param request - FileStorageGetQuotaDataRequest
   * @param headers - FileStorageGetQuotaDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FileStorageGetQuotaDataResponse
   */
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

  /**
   * 专属文件存储获取存储情况(按时间区间)
   * 
   * @param request - FileStorageGetQuotaDataRequest
   * @returns FileStorageGetQuotaDataResponse
   */
  async fileStorageGetQuotaData(request: FileStorageGetQuotaDataRequest): Promise<FileStorageGetQuotaDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageGetQuotaDataHeaders({ });
    return await this.fileStorageGetQuotaDataWithOptions(request, headers, runtime);
  }

  /**
   * 专属文件存储获取存储情况和配置
   * 
   * @param request - FileStorageGetStorageStateRequest
   * @param headers - FileStorageGetStorageStateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FileStorageGetStorageStateResponse
   */
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

  /**
   * 专属文件存储获取存储情况和配置
   * 
   * @param request - FileStorageGetStorageStateRequest
   * @returns FileStorageGetStorageStateResponse
   */
  async fileStorageGetStorageState(request: FileStorageGetStorageStateRequest): Promise<FileStorageGetStorageStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageGetStorageStateHeaders({ });
    return await this.fileStorageGetStorageStateWithOptions(request, headers, runtime);
  }

  /**
   * 更新文件专属存储配置
   * 
   * @param request - FileStorageUpdateStorageRequest
   * @param headers - FileStorageUpdateStorageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FileStorageUpdateStorageResponse
   */
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

  /**
   * 更新文件专属存储配置
   * 
   * @param request - FileStorageUpdateStorageRequest
   * @returns FileStorageUpdateStorageResponse
   */
  async fileStorageUpdateStorage(request: FileStorageUpdateStorageRequest): Promise<FileStorageUpdateStorageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FileStorageUpdateStorageHeaders({ });
    return await this.fileStorageUpdateStorageWithOptions(request, headers, runtime);
  }

  /**
   * 生成暗水印
   * 
   * @param request - GenerateDarkWaterMarkRequest
   * @param headers - GenerateDarkWaterMarkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GenerateDarkWaterMarkResponse
   */
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

  /**
   * 生成暗水印
   * 
   * @param request - GenerateDarkWaterMarkRequest
   * @returns GenerateDarkWaterMarkResponse
   */
  async generateDarkWaterMark(request: GenerateDarkWaterMarkRequest): Promise<GenerateDarkWaterMarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GenerateDarkWaterMarkHeaders({ });
    return await this.generateDarkWaterMarkWithOptions(request, headers, runtime);
  }

  /**
   * 获取专属钉钉账号数据迁移结果
   * 
   * @param request - GetAccountTransferListRequest
   * @param headers - GetAccountTransferListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAccountTransferListResponse
   */
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

  /**
   * 获取专属钉钉账号数据迁移结果
   * 
   * @param request - GetAccountTransferListRequest
   * @returns GetAccountTransferListResponse
   */
  async getAccountTransferList(request: GetAccountTransferListRequest): Promise<GetAccountTransferListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAccountTransferListHeaders({ });
    return await this.getAccountTransferListWithOptions(request, headers, runtime);
  }

  /**
   * 获得组织维度的用户dau
   * 
   * @param headers - GetActiveUserSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetActiveUserSummaryResponse
   */
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

  /**
   * 获得组织维度的用户dau
   * @returns GetActiveUserSummaryResponse
   */
  async getActiveUserSummary(dataId: string): Promise<GetActiveUserSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActiveUserSummaryHeaders({ });
    return await this.getActiveUserSummaryWithOptions(dataId, headers, runtime);
  }

  /**
   * 根据AppId获取微应用在该组织下的agentId
   * 
   * @param request - GetAgentIdByRelatedAppIdRequest
   * @param headers - GetAgentIdByRelatedAppIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAgentIdByRelatedAppIdResponse
   */
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

  /**
   * 根据AppId获取微应用在该组织下的agentId
   * 
   * @param request - GetAgentIdByRelatedAppIdRequest
   * @returns GetAgentIdByRelatedAppIdResponse
   */
  async getAgentIdByRelatedAppId(request: GetAgentIdByRelatedAppIdRequest): Promise<GetAgentIdByRelatedAppIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAgentIdByRelatedAppIdHeaders({ });
    return await this.getAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
  }

  /**
   * 伙伴钉可打标签部门查询
   * 
   * @param headers - GetAllLabelableDeptsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllLabelableDeptsResponse
   */
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

  /**
   * 伙伴钉可打标签部门查询
   * @returns GetAllLabelableDeptsResponse
   */
  async getAllLabelableDepts(): Promise<GetAllLabelableDeptsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllLabelableDeptsHeaders({ });
    return await this.getAllLabelableDeptsWithOptions(headers, runtime);
  }

  /**
   * 获得app分发信息
   * 
   * @param request - GetAppDispatchInfoRequest
   * @param headers - GetAppDispatchInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAppDispatchInfoResponse
   */
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

  /**
   * 获得app分发信息
   * 
   * @param request - GetAppDispatchInfoRequest
   * @returns GetAppDispatchInfoResponse
   */
  async getAppDispatchInfo(request: GetAppDispatchInfoRequest): Promise<GetAppDispatchInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppDispatchInfoHeaders({ });
    return await this.getAppDispatchInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获得组织维度日程相关信息
   * 
   * @param headers - GetCalenderSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCalenderSummaryResponse
   */
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

  /**
   * 获得组织维度日程相关信息
   * @returns GetCalenderSummaryResponse
   */
  async getCalenderSummary(dataId: string): Promise<GetCalenderSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCalenderSummaryHeaders({ });
    return await this.getCalenderSummaryWithOptions(dataId, headers, runtime);
  }

  /**
   * 获取发布号的评论列表
   * 
   * @param request - GetCommentListRequest
   * @param headers - GetCommentListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCommentListResponse
   */
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

  /**
   * 获取发布号的评论列表
   * 
   * @param request - GetCommentListRequest
   * @returns GetCommentListResponse
   */
  async getCommentList(publisherId: string, request: GetCommentListRequest): Promise<GetCommentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCommentListHeaders({ });
    return await this.getCommentListWithOptions(publisherId, request, headers, runtime);
  }

  /**
   * 根据逻辑会议id获取会议基本信息
   * 
   * @param request - GetConfBaseInfoByLogicalIdRequest
   * @param headers - GetConfBaseInfoByLogicalIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConfBaseInfoByLogicalIdResponse
   */
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

  /**
   * 根据逻辑会议id获取会议基本信息
   * 
   * @param request - GetConfBaseInfoByLogicalIdRequest
   * @returns GetConfBaseInfoByLogicalIdResponse
   */
  async getConfBaseInfoByLogicalId(request: GetConfBaseInfoByLogicalIdRequest): Promise<GetConfBaseInfoByLogicalIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfBaseInfoByLogicalIdHeaders({ });
    return await this.getConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
  }

  /**
   * 获取视频会议明细
   * 
   * @param headers - GetConferenceDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConferenceDetailResponse
   */
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

  /**
   * 获取视频会议明细
   * @returns GetConferenceDetailResponse
   */
  async getConferenceDetail(conferenceId: string): Promise<GetConferenceDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConferenceDetailHeaders({ });
    return await this.getConferenceDetailWithOptions(conferenceId, headers, runtime);
  }

  /**
   * 获取会话分组数据
   * 
   * @param headers - GetConversationCategoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConversationCategoryResponse
   */
  async getConversationCategoryWithOptions(headers: GetConversationCategoryHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationCategoryResponse> {
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
      action: "GetConversationCategory",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/conversationCategories`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConversationCategoryResponse>(await this.execute(params, req, runtime), new GetConversationCategoryResponse({}));
  }

  /**
   * 获取会话分组数据
   * @returns GetConversationCategoryResponse
   */
  async getConversationCategory(): Promise<GetConversationCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationCategoryHeaders({ });
    return await this.getConversationCategoryWithOptions(headers, runtime);
  }

  /**
   * 获取部门维度发布日志信息
   * 
   * @param request - GetDingReportDeptSummaryRequest
   * @param headers - GetDingReportDeptSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDingReportDeptSummaryResponse
   */
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

  /**
   * 获取部门维度发布日志信息
   * 
   * @param request - GetDingReportDeptSummaryRequest
   * @returns GetDingReportDeptSummaryResponse
   */
  async getDingReportDeptSummary(dataId: string, request: GetDingReportDeptSummaryRequest): Promise<GetDingReportDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingReportDeptSummaryHeaders({ });
    return await this.getDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  /**
   * 获取组织维度发布日志信息
   * 
   * @param headers - GetDingReportSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDingReportSummaryResponse
   */
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

  /**
   * 获取组织维度发布日志信息
   * @returns GetDingReportSummaryResponse
   */
  async getDingReportSummary(dataId: string): Promise<GetDingReportSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingReportSummaryHeaders({ });
    return await this.getDingReportSummaryWithOptions(dataId, headers, runtime);
  }

  /**
   * 获得部门维度用户创建文档数和创建文档人数
   * 
   * @param request - GetDocCreatedDeptSummaryRequest
   * @param headers - GetDocCreatedDeptSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDocCreatedDeptSummaryResponse
   */
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

  /**
   * 获得部门维度用户创建文档数和创建文档人数
   * 
   * @param request - GetDocCreatedDeptSummaryRequest
   * @returns GetDocCreatedDeptSummaryResponse
   */
  async getDocCreatedDeptSummary(dataId: string, request: GetDocCreatedDeptSummaryRequest): Promise<GetDocCreatedDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocCreatedDeptSummaryHeaders({ });
    return await this.getDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  /**
   * 获取组织维度用户创建文档数和创建文档人数
   * 
   * @param headers - GetDocCreatedSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDocCreatedSummaryResponse
   */
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

  /**
   * 获取组织维度用户创建文档数和创建文档人数
   * @returns GetDocCreatedSummaryResponse
   */
  async getDocCreatedSummary(dataId: string): Promise<GetDocCreatedSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocCreatedSummaryHeaders({ });
    return await this.getDocCreatedSummaryWithOptions(dataId, headers, runtime);
  }

  /**
   * 获取专属账号所有组织列表
   * 
   * @param request - GetExclusiveAccountAllOrgListRequest
   * @param headers - GetExclusiveAccountAllOrgListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetExclusiveAccountAllOrgListResponse
   */
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

  /**
   * 获取专属账号所有组织列表
   * 
   * @param request - GetExclusiveAccountAllOrgListRequest
   * @returns GetExclusiveAccountAllOrgListResponse
   */
  async getExclusiveAccountAllOrgList(request: GetExclusiveAccountAllOrgListRequest): Promise<GetExclusiveAccountAllOrgListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetExclusiveAccountAllOrgListHeaders({ });
    return await this.getExclusiveAccountAllOrgListWithOptions(request, headers, runtime);
  }

  /**
   * 获取部门维度发布智能填表数量和使用智能填表人数
   * 
   * @param request - GetGeneralFormCreatedDeptSummaryRequest
   * @param headers - GetGeneralFormCreatedDeptSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetGeneralFormCreatedDeptSummaryResponse
   */
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

  /**
   * 获取部门维度发布智能填表数量和使用智能填表人数
   * 
   * @param request - GetGeneralFormCreatedDeptSummaryRequest
   * @returns GetGeneralFormCreatedDeptSummaryResponse
   */
  async getGeneralFormCreatedDeptSummary(dataId: string, request: GetGeneralFormCreatedDeptSummaryRequest): Promise<GetGeneralFormCreatedDeptSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGeneralFormCreatedDeptSummaryHeaders({ });
    return await this.getGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
  }

  /**
   * 获取组织维度发布智能填表数量和使用智能填表人数
   * 
   * @param headers - GetGeneralFormCreatedSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetGeneralFormCreatedSummaryResponse
   */
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

  /**
   * 获取组织维度发布智能填表数量和使用智能填表人数
   * @returns GetGeneralFormCreatedSummaryResponse
   */
  async getGeneralFormCreatedSummary(dataId: string): Promise<GetGeneralFormCreatedSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGeneralFormCreatedSummaryHeaders({ });
    return await this.getGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
  }

  /**
   * 获取群活跃明细
   * 
   * @param request - GetGroupActiveInfoRequest
   * @param headers - GetGroupActiveInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetGroupActiveInfoResponse
   */
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

  /**
   * 获取群活跃明细
   * 
   * @param request - GetGroupActiveInfoRequest
   * @returns GetGroupActiveInfoResponse
   */
  async getGroupActiveInfo(request: GetGroupActiveInfoRequest): Promise<GetGroupActiveInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupActiveInfoHeaders({ });
    return await this.getGroupActiveInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取未活跃用户登陆统计明细
   * 
   * @param request - GetInActiveUserListRequest
   * @param headers - GetInActiveUserListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInActiveUserListResponse
   */
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

  /**
   * 获取未活跃用户登陆统计明细
   * 
   * @param request - GetInActiveUserListRequest
   * @returns GetInActiveUserListResponse
   */
  async getInActiveUserList(request: GetInActiveUserListRequest): Promise<GetInActiveUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInActiveUserListHeaders({ });
    return await this.getInActiveUserListWithOptions(request, headers, runtime);
  }

  /**
   * 获取最后一次验证通过的企业认证信息
   * 
   * @param request - GetLastOrgAuthDataRequest
   * @param headers - GetLastOrgAuthDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetLastOrgAuthDataResponse
   */
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

  /**
   * 获取最后一次验证通过的企业认证信息
   * 
   * @param request - GetLastOrgAuthDataRequest
   * @returns GetLastOrgAuthDataResponse
   */
  async getLastOrgAuthData(request: GetLastOrgAuthDataRequest): Promise<GetLastOrgAuthDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLastOrgAuthDataHeaders({ });
    return await this.getLastOrgAuthDataWithOptions(request, headers, runtime);
  }

  /**
   * 消息规则配置和群属性接口
   * 
   * @param request - GetMsgConfigRequest
   * @param headers - GetMsgConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMsgConfigResponse
   */
  async getMsgConfigWithOptions(request: GetMsgConfigRequest, headers: GetMsgConfigHeaders, runtime: $Util.RuntimeOptions): Promise<GetMsgConfigResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupTopic)) {
      body["groupTopic"] = request.groupTopic;
    }

    if (!Util.isUnset(request.groupType)) {
      body["groupType"] = request.groupType;
    }

    if (!Util.isUnset(request.listDynamicAttr)) {
      body["listDynamicAttr"] = request.listDynamicAttr;
    }

    if (!Util.isUnset(request.listEmployeeCode)) {
      body["listEmployeeCode"] = request.listEmployeeCode;
    }

    if (!Util.isUnset(request.listUnitId)) {
      body["listUnitId"] = request.listUnitId;
    }

    if (!Util.isUnset(request.ownerJobNo)) {
      body["ownerJobNo"] = request.ownerJobNo;
    }

    if (!Util.isUnset(request.ruleBusinessCode)) {
      body["ruleBusinessCode"] = request.ruleBusinessCode;
    }

    if (!Util.isUnset(request.ruleCategory)) {
      body["ruleCategory"] = request.ruleCategory;
    }

    if (!Util.isUnset(request.ruleCode)) {
      body["ruleCode"] = request.ruleCode;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.sysCode)) {
      body["sysCode"] = request.sysCode;
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
      action: "GetMsgConfig",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/portals/msgConfigs/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMsgConfigResponse>(await this.execute(params, req, runtime), new GetMsgConfigResponse({}));
  }

  /**
   * 消息规则配置和群属性接口
   * 
   * @param request - GetMsgConfigRequest
   * @returns GetMsgConfigResponse
   */
  async getMsgConfig(request: GetMsgConfigRequest): Promise<GetMsgConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMsgConfigHeaders({ });
    return await this.getMsgConfigWithOptions(request, headers, runtime);
  }

  /**
   * 获取消息定位链接
   * 
   * @param request - GetMsgLocationRequest
   * @param headers - GetMsgLocationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMsgLocationResponse
   */
  async getMsgLocationWithOptions(request: GetMsgLocationRequest, headers: GetMsgLocationHeaders, runtime: $Util.RuntimeOptions): Promise<GetMsgLocationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openMsgId)) {
      body["openMsgId"] = request.openMsgId;
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
      action: "GetMsgLocation",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/messageLocations/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMsgLocationResponse>(await this.execute(params, req, runtime), new GetMsgLocationResponse({}));
  }

  /**
   * 获取消息定位链接
   * 
   * @param request - GetMsgLocationRequest
   * @returns GetMsgLocationResponse
   */
  async getMsgLocation(request: GetMsgLocationRequest): Promise<GetMsgLocationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMsgLocationHeaders({ });
    return await this.getMsgLocationWithOptions(request, headers, runtime);
  }

  /**
   * 获取oa后台操作日志记录
   * 
   * @param request - GetOaOperatorLogListRequest
   * @param headers - GetOaOperatorLogListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOaOperatorLogListResponse
   */
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

  /**
   * 获取oa后台操作日志记录
   * 
   * @param request - GetOaOperatorLogListRequest
   * @returns GetOaOperatorLogListResponse
   */
  async getOaOperatorLogList(request: GetOaOperatorLogListRequest): Promise<GetOaOperatorLogListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOaOperatorLogListHeaders({ });
    return await this.getOaOperatorLogListWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业的外部审计群列表
   * 
   * @param request - GetOutGroupsByPageRequest
   * @param headers - GetOutGroupsByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOutGroupsByPageResponse
   */
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

  /**
   * 获取企业的外部审计群列表
   * 
   * @param request - GetOutGroupsByPageRequest
   * @returns GetOutGroupsByPageResponse
   */
  async getOutGroupsByPage(request: GetOutGroupsByPageRequest): Promise<GetOutGroupsByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOutGroupsByPageHeaders({ });
    return await this.getOutGroupsByPageWithOptions(request, headers, runtime);
  }

  /**
   * 获取外部审计群消息记录
   * 
   * @param request - GetOutsideAuditGroupMessageByPageRequest
   * @param headers - GetOutsideAuditGroupMessageByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOutsideAuditGroupMessageByPageResponse
   */
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

  /**
   * 获取外部审计群消息记录
   * 
   * @param request - GetOutsideAuditGroupMessageByPageRequest
   * @returns GetOutsideAuditGroupMessageByPageResponse
   */
  async getOutsideAuditGroupMessageByPage(request: GetOutsideAuditGroupMessageByPageRequest): Promise<GetOutsideAuditGroupMessageByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOutsideAuditGroupMessageByPageHeaders({ });
    return await this.getOutsideAuditGroupMessageByPageWithOptions(request, headers, runtime);
  }

  /**
   * 伙伴钉根据父标签查询子标签
   * 
   * @param headers - GetPartnerTypeByParentIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPartnerTypeByParentIdResponse
   */
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

  /**
   * 伙伴钉根据父标签查询子标签
   * @returns GetPartnerTypeByParentIdResponse
   */
  async getPartnerTypeByParentId(parentId: string): Promise<GetPartnerTypeByParentIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPartnerTypeByParentIdHeaders({ });
    return await this.getPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
  }

  /**
   * 获取公共设备列表。
   * 
   * @param request - GetPublicDevicesRequest
   * @param headers - GetPublicDevicesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPublicDevicesResponse
   */
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

  /**
   * 获取公共设备列表。
   * 
   * @param request - GetPublicDevicesRequest
   * @returns GetPublicDevicesResponse
   */
  async getPublicDevices(request: GetPublicDevicesRequest): Promise<GetPublicDevicesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPublicDevicesHeaders({ });
    return await this.getPublicDevicesWithOptions(request, headers, runtime);
  }

  /**
   * 获取互动服务窗相关数据
   * 
   * @param request - GetPublisherSummaryRequest
   * @param headers - GetPublisherSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPublisherSummaryResponse
   */
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

  /**
   * 获取互动服务窗相关数据
   * 
   * @param request - GetPublisherSummaryRequest
   * @returns GetPublisherSummaryResponse
   */
  async getPublisherSummary(dataId: string, request: GetPublisherSummaryRequest): Promise<GetPublisherSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPublisherSummaryHeaders({ });
    return await this.getPublisherSummaryWithOptions(dataId, request, headers, runtime);
  }

  /**
   * 获取实人认证接口调用记录
   * 
   * @param request - GetRealPeopleRecordsRequest
   * @param headers - GetRealPeopleRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRealPeopleRecordsResponse
   */
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

  /**
   * 获取实人认证接口调用记录
   * 
   * @param request - GetRealPeopleRecordsRequest
   * @returns GetRealPeopleRecordsResponse
   */
  async getRealPeopleRecords(request: GetRealPeopleRecordsRequest): Promise<GetRealPeopleRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRealPeopleRecordsHeaders({ });
    return await this.getRealPeopleRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 获取人脸对比接口调用记录
   * 
   * @param request - GetRecognizeRecordsRequest
   * @param headers - GetRecognizeRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRecognizeRecordsResponse
   */
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

  /**
   * 获取人脸对比接口调用记录
   * 
   * @param request - GetRecognizeRecordsRequest
   * @returns GetRecognizeRecordsResponse
   */
  async getRecognizeRecords(request: GetRecognizeRecordsRequest): Promise<GetRecognizeRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecognizeRecordsHeaders({ });
    return await this.getRecognizeRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 获取审计协议签署人员信息
   * 
   * @param request - GetSignedDetailByPageRequest
   * @param headers - GetSignedDetailByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignedDetailByPageResponse
   */
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

  /**
   * 获取审计协议签署人员信息
   * 
   * @param request - GetSignedDetailByPageRequest
   * @returns GetSignedDetailByPageResponse
   */
  async getSignedDetailByPage(request: GetSignedDetailByPageRequest): Promise<GetSignedDetailByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignedDetailByPageHeaders({ });
    return await this.getSignedDetailByPageWithOptions(request, headers, runtime);
  }

  /**
   * 获取多个可信设备信息，包括mac地址、staffId、platform
   * 
   * @param request - GetTrustDeviceListRequest
   * @param headers - GetTrustDeviceListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTrustDeviceListResponse
   */
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

  /**
   * 获取多个可信设备信息，包括mac地址、staffId、platform
   * 
   * @param request - GetTrustDeviceListRequest
   * @returns GetTrustDeviceListResponse
   */
  async getTrustDeviceList(request: GetTrustDeviceListRequest): Promise<GetTrustDeviceListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTrustDeviceListHeaders({ });
    return await this.getTrustDeviceListWithOptions(request, headers, runtime);
  }

  /**
   * 获得组织维度用户版本分布情况
   * 
   * @param request - GetUserAppVersionSummaryRequest
   * @param headers - GetUserAppVersionSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserAppVersionSummaryResponse
   */
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

  /**
   * 获得组织维度用户版本分布情况
   * 
   * @param request - GetUserAppVersionSummaryRequest
   * @returns GetUserAppVersionSummaryResponse
   */
  async getUserAppVersionSummary(dataId: string, request: GetUserAppVersionSummaryRequest): Promise<GetUserAppVersionSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserAppVersionSummaryHeaders({ });
    return await this.getUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
  }

  /**
   * 人脸录入状态查询
   * 
   * @param request - GetUserFaceStateRequest
   * @param headers - GetUserFaceStateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserFaceStateResponse
   */
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

  /**
   * 人脸录入状态查询
   * 
   * @param request - GetUserFaceStateRequest
   * @returns GetUserFaceStateResponse
   */
  async getUserFaceState(request: GetUserFaceStateRequest): Promise<GetUserFaceStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserFaceStateHeaders({ });
    return await this.getUserFaceStateWithOptions(request, headers, runtime);
  }

  /**
   * 实人认证状态查询
   * 
   * @param request - GetUserRealPeopleStateRequest
   * @param headers - GetUserRealPeopleStateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserRealPeopleStateResponse
   */
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

  /**
   * 实人认证状态查询
   * 
   * @param request - GetUserRealPeopleStateRequest
   * @returns GetUserRealPeopleStateResponse
   */
  async getUserRealPeopleState(request: GetUserRealPeopleStateRequest): Promise<GetUserRealPeopleStateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserRealPeopleStateHeaders({ });
    return await this.getUserRealPeopleStateWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户停留时长
   * 
   * @param request - GetUserStayLengthRequest
   * @param headers - GetUserStayLengthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserStayLengthResponse
   */
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

  /**
   * 获取用户停留时长
   * 
   * @param request - GetUserStayLengthRequest
   * @returns GetUserStayLengthResponse
   */
  async getUserStayLength(request: GetUserStayLengthRequest): Promise<GetUserStayLengthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserStayLengthHeaders({ });
    return await this.getUserStayLengthWithOptions(request, headers, runtime);
  }

  /**
   * 获取文件病毒扫描结果
   * 
   * @param request - GetVirusScanResultRequest
   * @param headers - GetVirusScanResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetVirusScanResultResponse
   */
  async getVirusScanResultWithOptions(request: GetVirusScanResultRequest, headers: GetVirusScanResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetVirusScanResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      action: "GetVirusScanResult",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/virusScanTasks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetVirusScanResultResponse>(await this.execute(params, req, runtime), new GetVirusScanResultResponse({}));
  }

  /**
   * 获取文件病毒扫描结果
   * 
   * @param request - GetVirusScanResultRequest
   * @returns GetVirusScanResultResponse
   */
  async getVirusScanResult(request: GetVirusScanResultRequest): Promise<GetVirusScanResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetVirusScanResultHeaders({ });
    return await this.getVirusScanResultWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业文件审计日志
   * 
   * @param request - ListAuditLogRequest
   * @param headers - ListAuditLogHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAuditLogResponse
   */
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

  /**
   * 获取企业文件审计日志
   * 
   * @param request - ListAuditLogRequest
   * @returns ListAuditLogResponse
   */
  async listAuditLog(request: ListAuditLogRequest): Promise<ListAuditLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAuditLogHeaders({ });
    return await this.listAuditLogWithOptions(request, headers, runtime);
  }

  /**
   * 查询分组列表
   * 
   * @param tmpReq - ListCategorysRequest
   * @param headers - ListCategorysHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListCategorysResponse
   */
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

  /**
   * 查询分组列表
   * 
   * @param request - ListCategorysRequest
   * @returns ListCategorysResponse
   */
  async listCategorys(request: ListCategorysRequest): Promise<ListCategorysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCategorysHeaders({ });
    return await this.listCategorysWithOptions(request, headers, runtime);
  }

  /**
   * 通过手机号获取已加入的属于渠道组织的列表信息
   * 
   * @param request - ListJoinOrgInfoRequest
   * @param headers - ListJoinOrgInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListJoinOrgInfoResponse
   */
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

  /**
   * 通过手机号获取已加入的属于渠道组织的列表信息
   * 
   * @param request - ListJoinOrgInfoRequest
   * @returns ListJoinOrgInfoResponse
   */
  async listJoinOrgInfo(request: ListJoinOrgInfoRequest): Promise<ListJoinOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListJoinOrgInfoHeaders({ });
    return await this.listJoinOrgInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取小程序版本列表
   * 
   * @param request - ListMiniAppAvailableVersionRequest
   * @param headers - ListMiniAppAvailableVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListMiniAppAvailableVersionResponse
   */
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

  /**
   * 获取小程序版本列表
   * 
   * @param request - ListMiniAppAvailableVersionRequest
   * @returns ListMiniAppAvailableVersionResponse
   */
  async listMiniAppAvailableVersion(request: ListMiniAppAvailableVersionRequest): Promise<ListMiniAppAvailableVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMiniAppAvailableVersionHeaders({ });
    return await this.listMiniAppAvailableVersionWithOptions(request, headers, runtime);
  }

  /**
   * 获取小程序历史版本列表
   * 
   * @param request - ListMiniAppHistoryVersionRequest
   * @param headers - ListMiniAppHistoryVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListMiniAppHistoryVersionResponse
   */
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

  /**
   * 获取小程序历史版本列表
   * 
   * @param request - ListMiniAppHistoryVersionRequest
   * @returns ListMiniAppHistoryVersionResponse
   */
  async listMiniAppHistoryVersion(request: ListMiniAppHistoryVersionRequest): Promise<ListMiniAppHistoryVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListMiniAppHistoryVersionHeaders({ });
    return await this.listMiniAppHistoryVersionWithOptions(request, headers, runtime);
  }

  /**
   * 查询伙伴角色
   * 
   * @param headers - ListPartnerRolesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListPartnerRolesResponse
   */
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

  /**
   * 查询伙伴角色
   * @returns ListPartnerRolesResponse
   */
  async listPartnerRoles(parentId: string): Promise<ListPartnerRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPartnerRolesHeaders({ });
    return await this.listPartnerRolesWithOptions(parentId, headers, runtime);
  }

  /**
   * 获取巡点信息列表
   * 
   * @param request - ListPunchScheduleByConditionWithPagingRequest
   * @param headers - ListPunchScheduleByConditionWithPagingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListPunchScheduleByConditionWithPagingResponse
   */
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

  /**
   * 获取巡点信息列表
   * 
   * @param request - ListPunchScheduleByConditionWithPagingRequest
   * @returns ListPunchScheduleByConditionWithPagingResponse
   */
  async listPunchScheduleByConditionWithPaging(request: ListPunchScheduleByConditionWithPagingRequest): Promise<ListPunchScheduleByConditionWithPagingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPunchScheduleByConditionWithPagingHeaders({ });
    return await this.listPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
  }

  /**
   * 查询规则列表
   * 
   * @param tmpReq - ListRulesRequest
   * @param headers - ListRulesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListRulesResponse
   */
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

  /**
   * 查询规则列表
   * 
   * @param request - ListRulesRequest
   * @returns ListRulesResponse
   */
  async listRules(request: ListRulesRequest): Promise<ListRulesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRulesHeaders({ });
    return await this.listRulesWithOptions(request, headers, runtime);
  }

  /**
   * 指定用户强制下线
   * 
   * @param request - LogoutRequest
   * @param headers - LogoutHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LogoutResponse
   */
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

  /**
   * 指定用户强制下线
   * 
   * @param request - LogoutRequest
   * @returns LogoutResponse
   */
  async logout(request: LogoutRequest): Promise<LogoutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LogoutHeaders({ });
    return await this.logoutWithOptions(request, headers, runtime);
  }

  /**
   * 购买权益包
   * 
   * @param request - OpenBenefitPackageRequest
   * @param headers - OpenBenefitPackageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenBenefitPackageResponse
   */
  async openBenefitPackageWithOptions(request: OpenBenefitPackageRequest, headers: OpenBenefitPackageHeaders, runtime: $Util.RuntimeOptions): Promise<OpenBenefitPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitPackage)) {
      body["benefitPackage"] = request.benefitPackage;
    }

    if (!Util.isUnset(request.endDate)) {
      body["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
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
      action: "OpenBenefitPackage",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/benefitPackages/purchase`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenBenefitPackageResponse>(await this.execute(params, req, runtime), new OpenBenefitPackageResponse({}));
  }

  /**
   * 购买权益包
   * 
   * @param request - OpenBenefitPackageRequest
   * @returns OpenBenefitPackageResponse
   */
  async openBenefitPackage(request: OpenBenefitPackageRequest): Promise<OpenBenefitPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenBenefitPackageHeaders({ });
    return await this.openBenefitPackageWithOptions(request, headers, runtime);
  }

  /**
   * 防作弊风险检测
   * 
   * @param request - PreventCheatingCheckRiskRequest
   * @param headers - PreventCheatingCheckRiskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PreventCheatingCheckRiskResponse
   */
  async preventCheatingCheckRiskWithOptions(request: PreventCheatingCheckRiskRequest, headers: PreventCheatingCheckRiskHeaders, runtime: $Util.RuntimeOptions): Promise<PreventCheatingCheckRiskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.clientVer)) {
      body["clientVer"] = request.clientVer;
    }

    if (!Util.isUnset(request.platform)) {
      body["platform"] = request.platform;
    }

    if (!Util.isUnset(request.platformVer)) {
      body["platformVer"] = request.platformVer;
    }

    if (!Util.isUnset(request.sec)) {
      body["sec"] = request.sec;
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
      action: "PreventCheatingCheckRisk",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/preventCheats/risks/check`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PreventCheatingCheckRiskResponse>(await this.execute(params, req, runtime), new PreventCheatingCheckRiskResponse({}));
  }

  /**
   * 防作弊风险检测
   * 
   * @param request - PreventCheatingCheckRiskRequest
   * @returns PreventCheatingCheckRiskResponse
   */
  async preventCheatingCheckRisk(request: PreventCheatingCheckRiskRequest): Promise<PreventCheatingCheckRiskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PreventCheatingCheckRiskHeaders({ });
    return await this.preventCheatingCheckRiskWithOptions(request, headers, runtime);
  }

  /**
   * 发送文件更改的评论
   * 
   * @param request - PublishFileChangeNoticeRequest
   * @param headers - PublishFileChangeNoticeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PublishFileChangeNoticeResponse
   */
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

  /**
   * 发送文件更改的评论
   * 
   * @param request - PublishFileChangeNoticeRequest
   * @returns PublishFileChangeNoticeResponse
   */
  async publishFileChangeNotice(request: PublishFileChangeNoticeRequest): Promise<PublishFileChangeNoticeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PublishFileChangeNoticeHeaders({ });
    return await this.publishFileChangeNoticeWithOptions(request, headers, runtime);
  }

  /**
   * 发布规则
   * 
   * @param request - PublishRuleRequest
   * @param headers - PublishRuleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PublishRuleResponse
   */
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

  /**
   * 发布规则
   * 
   * @param request - PublishRuleRequest
   * @returns PublishRuleResponse
   */
  async publishRule(request: PublishRuleRequest): Promise<PublishRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PublishRuleHeaders({ });
    return await this.publishRuleWithOptions(request, headers, runtime);
  }

  /**
   * 推送专属设计中自建/第三方应用的小红点
   * 
   * @param request - PushBadgeRequest
   * @param headers - PushBadgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PushBadgeResponse
   */
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

  /**
   * 推送专属设计中自建/第三方应用的小红点
   * 
   * @param request - PushBadgeRequest
   * @returns PushBadgeResponse
   */
  async pushBadge(request: PushBadgeRequest): Promise<PushBadgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushBadgeHeaders({ });
    return await this.pushBadgeWithOptions(request, headers, runtime);
  }

  /**
   * 查询跨云存储配置
   * 
   * @param request - QueryAcrossCloudStroageConfigsRequest
   * @param headers - QueryAcrossCloudStroageConfigsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAcrossCloudStroageConfigsResponse
   */
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

  /**
   * 查询跨云存储配置
   * 
   * @param request - QueryAcrossCloudStroageConfigsRequest
   * @returns QueryAcrossCloudStroageConfigsResponse
   */
  async queryAcrossCloudStroageConfigs(request: QueryAcrossCloudStroageConfigsRequest): Promise<QueryAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAcrossCloudStroageConfigsHeaders({ });
    return await this.queryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
  }

  /**
   * 根据手机号查询渠道组织中的员工信息
   * 
   * @param request - QueryChannelStaffInfoByMobileRequest
   * @param headers - QueryChannelStaffInfoByMobileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryChannelStaffInfoByMobileResponse
   */
  async queryChannelStaffInfoByMobileWithOptions(request: QueryChannelStaffInfoByMobileRequest, headers: QueryChannelStaffInfoByMobileHeaders, runtime: $Util.RuntimeOptions): Promise<QueryChannelStaffInfoByMobileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
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
      action: "QueryChannelStaffInfoByMobile",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/channelOrganizations/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryChannelStaffInfoByMobileResponse>(await this.execute(params, req, runtime), new QueryChannelStaffInfoByMobileResponse({}));
  }

  /**
   * 根据手机号查询渠道组织中的员工信息
   * 
   * @param request - QueryChannelStaffInfoByMobileRequest
   * @returns QueryChannelStaffInfoByMobileResponse
   */
  async queryChannelStaffInfoByMobile(request: QueryChannelStaffInfoByMobileRequest): Promise<QueryChannelStaffInfoByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryChannelStaffInfoByMobileHeaders({ });
    return await this.queryChannelStaffInfoByMobileWithOptions(request, headers, runtime);
  }

  /**
   * 查询专属版权益
   * 
   * @param headers - QueryExclusiveBenefitsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryExclusiveBenefitsResponse
   */
  async queryExclusiveBenefitsWithOptions(headers: QueryExclusiveBenefitsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryExclusiveBenefitsResponse> {
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
      action: "QueryExclusiveBenefits",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/benefits`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryExclusiveBenefitsResponse>(await this.execute(params, req, runtime), new QueryExclusiveBenefitsResponse({}));
  }

  /**
   * 查询专属版权益
   * @returns QueryExclusiveBenefitsResponse
   */
  async queryExclusiveBenefits(): Promise<QueryExclusiveBenefitsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryExclusiveBenefitsHeaders({ });
    return await this.queryExclusiveBenefitsWithOptions(headers, runtime);
  }

  /**
   * 伙伴钉根据uid查询人员的标签信息
   * 
   * @param headers - QueryPartnerInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPartnerInfoResponse
   */
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

  /**
   * 伙伴钉根据uid查询人员的标签信息
   * @returns QueryPartnerInfoResponse
   */
  async queryPartnerInfo(userId: string): Promise<QueryPartnerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPartnerInfoHeaders({ });
    return await this.queryPartnerInfoWithOptions(userId, headers, runtime);
  }

  /**
   * 获取用户截屏操作记录
   * 
   * @param request - QueryUserBehaviorRequest
   * @param headers - QueryUserBehaviorHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserBehaviorResponse
   */
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

  /**
   * 获取用户截屏操作记录
   * 
   * @param request - QueryUserBehaviorRequest
   * @returns QueryUserBehaviorResponse
   */
  async queryUserBehavior(request: QueryUserBehaviorRequest): Promise<QueryUserBehaviorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserBehaviorHeaders({ });
    return await this.queryUserBehaviorWithOptions(request, headers, runtime);
  }

  /**
   * 小程序版本回滚
   * 
   * @param request - RollbackMiniAppVersionRequest
   * @param headers - RollbackMiniAppVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RollbackMiniAppVersionResponse
   */
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

  /**
   * 小程序版本回滚
   * 
   * @param request - RollbackMiniAppVersionRequest
   * @returns RollbackMiniAppVersionResponse
   */
  async rollbackMiniAppVersion(request: RollbackMiniAppVersionRequest): Promise<RollbackMiniAppVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RollbackMiniAppVersionHeaders({ });
    return await this.rollbackMiniAppVersionWithOptions(request, headers, runtime);
  }

  /**
   * 按规则批量发消息
   * 
   * @param request - RuleBatchReceiverRequest
   * @param headers - RuleBatchReceiverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RuleBatchReceiverResponse
   */
  async ruleBatchReceiverWithOptions(request: RuleBatchReceiverRequest, headers: RuleBatchReceiverHeaders, runtime: $Util.RuntimeOptions): Promise<RuleBatchReceiverResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.batchNo)) {
      body["batchNo"] = request.batchNo;
    }

    if (!Util.isUnset(request.cardOptions)) {
      body["cardOptions"] = request.cardOptions;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.ruleCode)) {
      body["ruleCode"] = request.ruleCode;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.specialStrategy)) {
      body["specialStrategy"] = request.specialStrategy;
    }

    if (!Util.isUnset(request.taskBatchNo)) {
      body["taskBatchNo"] = request.taskBatchNo;
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
      action: "RuleBatchReceiver",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/dmc/rules/messages/batchSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RuleBatchReceiverResponse>(await this.execute(params, req, runtime), new RuleBatchReceiverResponse({}));
  }

  /**
   * 按规则批量发消息
   * 
   * @param request - RuleBatchReceiverRequest
   * @returns RuleBatchReceiverResponse
   */
  async ruleBatchReceiver(request: RuleBatchReceiverRequest): Promise<RuleBatchReceiverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RuleBatchReceiverHeaders({ });
    return await this.ruleBatchReceiverWithOptions(request, headers, runtime);
  }

  /**
   * 新增跨云存储配置
   * 
   * @param request - SaveAcrossCloudStroageConfigsRequest
   * @param headers - SaveAcrossCloudStroageConfigsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveAcrossCloudStroageConfigsResponse
   */
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

  /**
   * 新增跨云存储配置
   * 
   * @param request - SaveAcrossCloudStroageConfigsRequest
   * @returns SaveAcrossCloudStroageConfigsResponse
   */
  async saveAcrossCloudStroageConfigs(request: SaveAcrossCloudStroageConfigsRequest): Promise<SaveAcrossCloudStroageConfigsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveAcrossCloudStroageConfigsHeaders({ });
    return await this.saveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
  }

  /**
   * 保存并提交认证信息
   * 
   * @param request - SaveAndSubmitAuthInfoRequest
   * @param headers - SaveAndSubmitAuthInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveAndSubmitAuthInfoResponse
   */
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

  /**
   * 保存并提交认证信息
   * 
   * @param request - SaveAndSubmitAuthInfoRequest
   * @returns SaveAndSubmitAuthInfoResponse
   */
  async saveAndSubmitAuthInfo(request: SaveAndSubmitAuthInfoRequest): Promise<SaveAndSubmitAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveAndSubmitAuthInfoHeaders({ });
    return await this.saveAndSubmitAuthInfoWithOptions(request, headers, runtime);
  }

  /**
   * 亿格云能力结合
   * 
   * @param request - SaveOpenTerminalInfoRequest
   * @param headers - SaveOpenTerminalInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveOpenTerminalInfoResponse
   */
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

  /**
   * 亿格云能力结合
   * 
   * @param request - SaveOpenTerminalInfoRequest
   * @returns SaveOpenTerminalInfoResponse
   */
  async saveOpenTerminalInfo(request: SaveOpenTerminalInfoRequest): Promise<SaveOpenTerminalInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveOpenTerminalInfoHeaders({ });
    return await this.saveOpenTerminalInfoWithOptions(request, headers, runtime);
  }

  /**
   * 保存专属文件存储的功能项
   * 
   * @param request - SaveStorageFunctionSwitchRequest
   * @param headers - SaveStorageFunctionSwitchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveStorageFunctionSwitchResponse
   */
  async saveStorageFunctionSwitchWithOptions(request: SaveStorageFunctionSwitchRequest, headers: SaveStorageFunctionSwitchHeaders, runtime: $Util.RuntimeOptions): Promise<SaveStorageFunctionSwitchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.functionList)) {
      body["functionList"] = request.functionList;
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
      action: "SaveStorageFunctionSwitch",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/storages/functions/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveStorageFunctionSwitchResponse>(await this.execute(params, req, runtime), new SaveStorageFunctionSwitchResponse({}));
  }

  /**
   * 保存专属文件存储的功能项
   * 
   * @param request - SaveStorageFunctionSwitchRequest
   * @returns SaveStorageFunctionSwitchResponse
   */
  async saveStorageFunctionSwitch(request: SaveStorageFunctionSwitchRequest): Promise<SaveStorageFunctionSwitchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveStorageFunctionSwitchHeaders({ });
    return await this.saveStorageFunctionSwitchWithOptions(request, headers, runtime);
  }

  /**
   * 保存专属文件存储整体开关
   * 
   * @param request - SaveStorageSwitchRequest
   * @param headers - SaveStorageSwitchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveStorageSwitchResponse
   */
  async saveStorageSwitchWithOptions(request: SaveStorageSwitchRequest, headers: SaveStorageSwitchHeaders, runtime: $Util.RuntimeOptions): Promise<SaveStorageSwitchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openStorage)) {
      body["openStorage"] = request.openStorage;
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
      action: "SaveStorageSwitch",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/storages/switches/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveStorageSwitchResponse>(await this.execute(params, req, runtime), new SaveStorageSwitchResponse({}));
  }

  /**
   * 保存专属文件存储整体开关
   * 
   * @param request - SaveStorageSwitchRequest
   * @returns SaveStorageSwitchResponse
   */
  async saveStorageSwitch(request: SaveStorageSwitchRequest): Promise<SaveStorageSwitchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveStorageSwitchHeaders({ });
    return await this.saveStorageSwitchWithOptions(request, headers, runtime);
  }

  /**
   * 用于提供mdm微应用白名单配置能力
   * 
   * @param request - SaveWhiteAppRequest
   * @param headers - SaveWhiteAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveWhiteAppResponse
   */
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

  /**
   * 用于提供mdm微应用白名单配置能力
   * 
   * @param request - SaveWhiteAppRequest
   * @returns SaveWhiteAppResponse
   */
  async saveWhiteApp(request: SaveWhiteAppRequest): Promise<SaveWhiteAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveWhiteAppHeaders({ });
    return await this.saveWhiteAppWithOptions(request, headers, runtime);
  }

  /**
   * 查询企业内部群信息
   * 
   * @param request - SearchOrgInnerGroupInfoRequest
   * @param headers - SearchOrgInnerGroupInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchOrgInnerGroupInfoResponse
   */
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

  /**
   * 查询企业内部群信息
   * 
   * @param request - SearchOrgInnerGroupInfoRequest
   * @returns SearchOrgInnerGroupInfoResponse
   */
  async searchOrgInnerGroupInfo(request: SearchOrgInnerGroupInfoRequest): Promise<SearchOrgInnerGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchOrgInnerGroupInfoHeaders({ });
    return await this.searchOrgInnerGroupInfoWithOptions(request, headers, runtime);
  }

  /**
   * 通过接口发送应用内DING
   * 
   * @param request - SendAppDingRequest
   * @param headers - SendAppDingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendAppDingResponse
   */
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

  /**
   * 通过接口发送应用内DING
   * 
   * @param request - SendAppDingRequest
   * @returns SendAppDingResponse
   */
  async sendAppDing(request: SendAppDingRequest): Promise<SendAppDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendAppDingHeaders({ });
    return await this.sendAppDingWithOptions(request, headers, runtime);
  }

  /**
   * 发送邀请函
   * 
   * @param request - SendInvitationRequest
   * @param headers - SendInvitationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendInvitationResponse
   */
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

  /**
   * 发送邀请函
   * 
   * @param request - SendInvitationRequest
   * @returns SendInvitationResponse
   */
  async sendInvitation(request: SendInvitationRequest): Promise<SendInvitationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInvitationHeaders({ });
    return await this.sendInvitationWithOptions(request, headers, runtime);
  }

  /**
   * 通过接口发送电话DING
   * 
   * @param request - SendPhoneDingRequest
   * @param headers - SendPhoneDingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendPhoneDingResponse
   */
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

  /**
   * 通过接口发送电话DING
   * 
   * @param request - SendPhoneDingRequest
   * @returns SendPhoneDingResponse
   */
  async sendPhoneDing(request: SendPhoneDingRequest): Promise<SendPhoneDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendPhoneDingHeaders({ });
    return await this.sendPhoneDingWithOptions(request, headers, runtime);
  }

  /**
   * 设置会话所属分组
   * 
   * @param request - SetConversationCategoryRequest
   * @param headers - SetConversationCategoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetConversationCategoryResponse
   */
  async setConversationCategoryWithOptions(request: SetConversationCategoryRequest, headers: SetConversationCategoryHeaders, runtime: $Util.RuntimeOptions): Promise<SetConversationCategoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.categoryId)) {
      body["categoryId"] = request.categoryId;
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
      action: "SetConversationCategory",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/conversationCategories/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetConversationCategoryResponse>(await this.execute(params, req, runtime), new SetConversationCategoryResponse({}));
  }

  /**
   * 设置会话所属分组
   * 
   * @param request - SetConversationCategoryRequest
   * @returns SetConversationCategoryResponse
   */
  async setConversationCategory(request: SetConversationCategoryRequest): Promise<SetConversationCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetConversationCategoryHeaders({ });
    return await this.setConversationCategoryWithOptions(request, headers, runtime);
  }

  /**
   * 伙伴钉设置部门伙伴编码和伙伴类型
   * 
   * @param request - SetDeptPartnerTypeAndNumRequest
   * @param headers - SetDeptPartnerTypeAndNumHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetDeptPartnerTypeAndNumResponse
   */
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

  /**
   * 伙伴钉设置部门伙伴编码和伙伴类型
   * 
   * @param request - SetDeptPartnerTypeAndNumRequest
   * @returns SetDeptPartnerTypeAndNumResponse
   */
  async setDeptPartnerTypeAndNum(request: SetDeptPartnerTypeAndNumRequest): Promise<SetDeptPartnerTypeAndNumResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetDeptPartnerTypeAndNumHeaders({ });
    return await this.setDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
  }

  /**
   * 千人千面按规则批量发消息
   * 
   * @param request - SpecialRuleBatchReceiverRequest
   * @param headers - SpecialRuleBatchReceiverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SpecialRuleBatchReceiverResponse
   */
  async specialRuleBatchReceiverWithOptions(request: SpecialRuleBatchReceiverRequest, headers: SpecialRuleBatchReceiverHeaders, runtime: $Util.RuntimeOptions): Promise<SpecialRuleBatchReceiverResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.batchNo)) {
      body["batchNo"] = request.batchNo;
    }

    if (!Util.isUnset(request.cardOptions)) {
      body["cardOptions"] = request.cardOptions;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.ruleCode)) {
      body["ruleCode"] = request.ruleCode;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.specialStrategy)) {
      body["specialStrategy"] = request.specialStrategy;
    }

    if (!Util.isUnset(request.taskBatchNo)) {
      body["taskBatchNo"] = request.taskBatchNo;
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
      action: "SpecialRuleBatchReceiver",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/dmc/rules/specialMessages/batchSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SpecialRuleBatchReceiverResponse>(await this.execute(params, req, runtime), new SpecialRuleBatchReceiverResponse({}));
  }

  /**
   * 千人千面按规则批量发消息
   * 
   * @param request - SpecialRuleBatchReceiverRequest
   * @returns SpecialRuleBatchReceiverResponse
   */
  async specialRuleBatchReceiver(request: SpecialRuleBatchReceiverRequest): Promise<SpecialRuleBatchReceiverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SpecialRuleBatchReceiverHeaders({ });
    return await this.specialRuleBatchReceiverWithOptions(request, headers, runtime);
  }

  /**
   * 增加/删除任务人员
   * 
   * @param request - TaskInfoAddDelTaskPersonRequest
   * @param headers - TaskInfoAddDelTaskPersonHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TaskInfoAddDelTaskPersonResponse
   */
  async taskInfoAddDelTaskPersonWithOptions(request: TaskInfoAddDelTaskPersonRequest, headers: TaskInfoAddDelTaskPersonHeaders, runtime: $Util.RuntimeOptions): Promise<TaskInfoAddDelTaskPersonResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operateType)) {
      body["operateType"] = request.operateType;
    }

    if (!Util.isUnset(request.operatorAccount)) {
      body["operatorAccount"] = request.operatorAccount;
    }

    if (!Util.isUnset(request.outTaskId)) {
      body["outTaskId"] = request.outTaskId;
    }

    if (!Util.isUnset(request.projId)) {
      body["projId"] = request.projId;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.taskExecutePersonDTOS)) {
      body["taskExecutePersonDTOS"] = request.taskExecutePersonDTOS;
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
      action: "TaskInfoAddDelTaskPerson",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TaskInfoAddDelTaskPersonResponse>(await this.execute(params, req, runtime), new TaskInfoAddDelTaskPersonResponse({}));
  }

  /**
   * 增加/删除任务人员
   * 
   * @param request - TaskInfoAddDelTaskPersonRequest
   * @returns TaskInfoAddDelTaskPersonResponse
   */
  async taskInfoAddDelTaskPerson(request: TaskInfoAddDelTaskPersonRequest): Promise<TaskInfoAddDelTaskPersonResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TaskInfoAddDelTaskPersonHeaders({ });
    return await this.taskInfoAddDelTaskPersonWithOptions(request, headers, runtime);
  }

  /**
   * 删除任务
   * 
   * @param request - TaskInfoCancelOrDelTaskRequest
   * @param headers - TaskInfoCancelOrDelTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TaskInfoCancelOrDelTaskResponse
   */
  async taskInfoCancelOrDelTaskWithOptions(request: TaskInfoCancelOrDelTaskRequest, headers: TaskInfoCancelOrDelTaskHeaders, runtime: $Util.RuntimeOptions): Promise<TaskInfoCancelOrDelTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardDTO)) {
      body["cardDTO"] = request.cardDTO;
    }

    if (!Util.isUnset(request.operatorAccount)) {
      body["operatorAccount"] = request.operatorAccount;
    }

    if (!Util.isUnset(request.outTaskId)) {
      body["outTaskId"] = request.outTaskId;
    }

    if (!Util.isUnset(request.projId)) {
      body["projId"] = request.projId;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.sendMsgFlag)) {
      body["sendMsgFlag"] = request.sendMsgFlag;
    }

    if (!Util.isUnset(request.taskExecutePersonDTOS)) {
      body["taskExecutePersonDTOS"] = request.taskExecutePersonDTOS;
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
      action: "TaskInfoCancelOrDelTask",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TaskInfoCancelOrDelTaskResponse>(await this.execute(params, req, runtime), new TaskInfoCancelOrDelTaskResponse({}));
  }

  /**
   * 删除任务
   * 
   * @param request - TaskInfoCancelOrDelTaskRequest
   * @returns TaskInfoCancelOrDelTaskResponse
   */
  async taskInfoCancelOrDelTask(request: TaskInfoCancelOrDelTaskRequest): Promise<TaskInfoCancelOrDelTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TaskInfoCancelOrDelTaskHeaders({ });
    return await this.taskInfoCancelOrDelTaskWithOptions(request, headers, runtime);
  }

  /**
   * 创建并启动任务
   * 
   * @param request - TaskInfoCreateAndStartTaskRequest
   * @param headers - TaskInfoCreateAndStartTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TaskInfoCreateAndStartTaskResponse
   */
  async taskInfoCreateAndStartTaskWithOptions(request: TaskInfoCreateAndStartTaskRequest, headers: TaskInfoCreateAndStartTaskHeaders, runtime: $Util.RuntimeOptions): Promise<TaskInfoCreateAndStartTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attr)) {
      body["attr"] = request.attr;
    }

    if (!Util.isUnset(request.backlogDTO)) {
      body["backlogDTO"] = request.backlogDTO;
    }

    if (!Util.isUnset(request.backlogGenerateFlag)) {
      body["backlogGenerateFlag"] = request.backlogGenerateFlag;
    }

    if (!Util.isUnset(request.businessCode)) {
      body["businessCode"] = request.businessCode;
    }

    if (!Util.isUnset(request.canceldelTaskCardId)) {
      body["canceldelTaskCardId"] = request.canceldelTaskCardId;
    }

    if (!Util.isUnset(request.cardDTO)) {
      body["cardDTO"] = request.cardDTO;
    }

    if (!Util.isUnset(request.customFlag)) {
      body["customFlag"] = request.customFlag;
    }

    if (!Util.isUnset(request.detailUrl)) {
      body["detailUrl"] = request.detailUrl;
    }

    if (!Util.isUnset(request.finishTaskCardId)) {
      body["finishTaskCardId"] = request.finishTaskCardId;
    }

    if (!Util.isUnset(request.operatorAccount)) {
      body["operatorAccount"] = request.operatorAccount;
    }

    if (!Util.isUnset(request.outTaskId)) {
      body["outTaskId"] = request.outTaskId;
    }

    if (!Util.isUnset(request.projId)) {
      body["projId"] = request.projId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.sendMsgFlag)) {
      body["sendMsgFlag"] = request.sendMsgFlag;
    }

    if (!Util.isUnset(request.sort)) {
      body["sort"] = request.sort;
    }

    if (!Util.isUnset(request.startTaskCardId)) {
      body["startTaskCardId"] = request.startTaskCardId;
    }

    if (!Util.isUnset(request.state)) {
      body["state"] = request.state;
    }

    if (!Util.isUnset(request.taskContent)) {
      body["taskContent"] = request.taskContent;
    }

    if (!Util.isUnset(request.taskEndTime)) {
      body["taskEndTime"] = request.taskEndTime;
    }

    if (!Util.isUnset(request.taskExecutePersonDTOS)) {
      body["taskExecutePersonDTOS"] = request.taskExecutePersonDTOS;
    }

    if (!Util.isUnset(request.taskGroupDTOList)) {
      body["taskGroupDTOList"] = request.taskGroupDTOList;
    }

    if (!Util.isUnset(request.taskSystem)) {
      body["taskSystem"] = request.taskSystem;
    }

    if (!Util.isUnset(request.taskTemplCode)) {
      body["taskTemplCode"] = request.taskTemplCode;
    }

    if (!Util.isUnset(request.taskTitle)) {
      body["taskTitle"] = request.taskTitle;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
    }

    if (!Util.isUnset(request.taskUrlMobile)) {
      body["taskUrlMobile"] = request.taskUrlMobile;
    }

    if (!Util.isUnset(request.taskUrlPc)) {
      body["taskUrlPc"] = request.taskUrlPc;
    }

    if (!Util.isUnset(request.updateTaskCardId)) {
      body["updateTaskCardId"] = request.updateTaskCardId;
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
      action: "TaskInfoCreateAndStartTask",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/taskCenters/taskInfos/createAndStart`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TaskInfoCreateAndStartTaskResponse>(await this.execute(params, req, runtime), new TaskInfoCreateAndStartTaskResponse({}));
  }

  /**
   * 创建并启动任务
   * 
   * @param request - TaskInfoCreateAndStartTaskRequest
   * @returns TaskInfoCreateAndStartTaskResponse
   */
  async taskInfoCreateAndStartTask(request: TaskInfoCreateAndStartTaskRequest): Promise<TaskInfoCreateAndStartTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TaskInfoCreateAndStartTaskHeaders({ });
    return await this.taskInfoCreateAndStartTaskWithOptions(request, headers, runtime);
  }

  /**
   * 完成任务
   * 
   * @param request - TaskInfoFinishTaskRequest
   * @param headers - TaskInfoFinishTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TaskInfoFinishTaskResponse
   */
  async taskInfoFinishTaskWithOptions(request: TaskInfoFinishTaskRequest, headers: TaskInfoFinishTaskHeaders, runtime: $Util.RuntimeOptions): Promise<TaskInfoFinishTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardDTO)) {
      body["cardDTO"] = request.cardDTO;
    }

    if (!Util.isUnset(request.operatorAccount)) {
      body["operatorAccount"] = request.operatorAccount;
    }

    if (!Util.isUnset(request.outTaskId)) {
      body["outTaskId"] = request.outTaskId;
    }

    if (!Util.isUnset(request.projId)) {
      body["projId"] = request.projId;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.sendMsgFlag)) {
      body["sendMsgFlag"] = request.sendMsgFlag;
    }

    if (!Util.isUnset(request.taskExecutePersonDTOS)) {
      body["taskExecutePersonDTOS"] = request.taskExecutePersonDTOS;
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
      action: "TaskInfoFinishTask",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/taskCenters/taskInfos/finishTask`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TaskInfoFinishTaskResponse>(await this.execute(params, req, runtime), new TaskInfoFinishTaskResponse({}));
  }

  /**
   * 完成任务
   * 
   * @param request - TaskInfoFinishTaskRequest
   * @returns TaskInfoFinishTaskResponse
   */
  async taskInfoFinishTask(request: TaskInfoFinishTaskRequest): Promise<TaskInfoFinishTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TaskInfoFinishTaskHeaders({ });
    return await this.taskInfoFinishTaskWithOptions(request, headers, runtime);
  }

  /**
   * 更新任务
   * 
   * @param request - TaskInfoUpdateTaskRequest
   * @param headers - TaskInfoUpdateTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TaskInfoUpdateTaskResponse
   */
  async taskInfoUpdateTaskWithOptions(request: TaskInfoUpdateTaskRequest, headers: TaskInfoUpdateTaskHeaders, runtime: $Util.RuntimeOptions): Promise<TaskInfoUpdateTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attr)) {
      body["attr"] = request.attr;
    }

    if (!Util.isUnset(request.canceldelTaskCardId)) {
      body["canceldelTaskCardId"] = request.canceldelTaskCardId;
    }

    if (!Util.isUnset(request.cardDTO)) {
      body["cardDTO"] = request.cardDTO;
    }

    if (!Util.isUnset(request.detailUrl)) {
      body["detailUrl"] = request.detailUrl;
    }

    if (!Util.isUnset(request.finishTaskCardId)) {
      body["finishTaskCardId"] = request.finishTaskCardId;
    }

    if (!Util.isUnset(request.listOpenConversationId)) {
      body["listOpenConversationId"] = request.listOpenConversationId;
    }

    if (!Util.isUnset(request.operateType)) {
      body["operateType"] = request.operateType;
    }

    if (!Util.isUnset(request.operatorAccount)) {
      body["operatorAccount"] = request.operatorAccount;
    }

    if (!Util.isUnset(request.outTaskId)) {
      body["outTaskId"] = request.outTaskId;
    }

    if (!Util.isUnset(request.projId)) {
      body["projId"] = request.projId;
    }

    if (!Util.isUnset(request.secretKey)) {
      body["secretKey"] = request.secretKey;
    }

    if (!Util.isUnset(request.sendMsgFlag)) {
      body["sendMsgFlag"] = request.sendMsgFlag;
    }

    if (!Util.isUnset(request.startTaskCardId)) {
      body["startTaskCardId"] = request.startTaskCardId;
    }

    if (!Util.isUnset(request.taskContent)) {
      body["taskContent"] = request.taskContent;
    }

    if (!Util.isUnset(request.taskEndTime)) {
      body["taskEndTime"] = request.taskEndTime;
    }

    if (!Util.isUnset(request.taskExecutePersonDTOS)) {
      body["taskExecutePersonDTOS"] = request.taskExecutePersonDTOS;
    }

    if (!Util.isUnset(request.taskTitle)) {
      body["taskTitle"] = request.taskTitle;
    }

    if (!Util.isUnset(request.taskUrlMobile)) {
      body["taskUrlMobile"] = request.taskUrlMobile;
    }

    if (!Util.isUnset(request.taskUrlPc)) {
      body["taskUrlPc"] = request.taskUrlPc;
    }

    if (!Util.isUnset(request.updateTaskCardId)) {
      body["updateTaskCardId"] = request.updateTaskCardId;
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
      action: "TaskInfoUpdateTask",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/taskCenters/taskInfos/update`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TaskInfoUpdateTaskResponse>(await this.execute(params, req, runtime), new TaskInfoUpdateTaskResponse({}));
  }

  /**
   * 更新任务
   * 
   * @param request - TaskInfoUpdateTaskRequest
   * @returns TaskInfoUpdateTaskResponse
   */
  async taskInfoUpdateTask(request: TaskInfoUpdateTaskRequest): Promise<TaskInfoUpdateTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TaskInfoUpdateTaskHeaders({ });
    return await this.taskInfoUpdateTaskWithOptions(request, headers, runtime);
  }

  /**
   * 更改分组名称
   * 
   * @param request - UpdateCategoryNameRequest
   * @param headers - UpdateCategoryNameHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateCategoryNameResponse
   */
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

  /**
   * 更改分组名称
   * 
   * @param request - UpdateCategoryNameRequest
   * @returns UpdateCategoryNameResponse
   */
  async updateCategoryName(request: UpdateCategoryNameRequest): Promise<UpdateCategoryNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCategoryNameHeaders({ });
    return await this.updateCategoryNameWithOptions(request, headers, runtime);
  }

  /**
   * 变更群聊类型
   * 
   * @param request - UpdateConversationTypeRequest
   * @param headers - UpdateConversationTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateConversationTypeResponse
   */
  async updateConversationTypeWithOptions(request: UpdateConversationTypeRequest, headers: UpdateConversationTypeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateConversationTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.manageSign)) {
      body["manageSign"] = request.manageSign;
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
      action: "UpdateConversationType",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/conversationTypes`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateConversationTypeResponse>(await this.execute(params, req, runtime), new UpdateConversationTypeResponse({}));
  }

  /**
   * 变更群聊类型
   * 
   * @param request - UpdateConversationTypeRequest
   * @returns UpdateConversationTypeResponse
   */
  async updateConversationType(request: UpdateConversationTypeRequest): Promise<UpdateConversationTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateConversationTypeHeaders({ });
    return await this.updateConversationTypeWithOptions(request, headers, runtime);
  }

  /**
   * 更新发送文件的检测状态
   * 
   * @param request - UpdateFileStatusRequest
   * @param headers - UpdateFileStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateFileStatusResponse
   */
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

  /**
   * 更新发送文件的检测状态
   * 
   * @param request - UpdateFileStatusRequest
   * @returns UpdateFileStatusResponse
   */
  async updateFileStatus(request: UpdateFileStatusRequest): Promise<UpdateFileStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFileStatusHeaders({ });
    return await this.updateFileStatusWithOptions(request, headers, runtime);
  }

  /**
   * 发布版本
   * 
   * @param request - UpdateMiniAppVersionStatusRequest
   * @param headers - UpdateMiniAppVersionStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMiniAppVersionStatusResponse
   */
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

  /**
   * 发布版本
   * 
   * @param request - UpdateMiniAppVersionStatusRequest
   * @returns UpdateMiniAppVersionStatusResponse
   */
  async updateMiniAppVersionStatus(request: UpdateMiniAppVersionStatusRequest): Promise<UpdateMiniAppVersionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMiniAppVersionStatusHeaders({ });
    return await this.updateMiniAppVersionStatusWithOptions(request, headers, runtime);
  }

  /**
   * 修改伙伴类型可见性
   * 
   * @param request - UpdatePartnerVisibilityRequest
   * @param headers - UpdatePartnerVisibilityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdatePartnerVisibilityResponse
   */
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

  /**
   * 修改伙伴类型可见性
   * 
   * @param request - UpdatePartnerVisibilityRequest
   * @returns UpdatePartnerVisibilityResponse
   */
  async updatePartnerVisibility(request: UpdatePartnerVisibilityRequest): Promise<UpdatePartnerVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePartnerVisibilityHeaders({ });
    return await this.updatePartnerVisibilityWithOptions(request, headers, runtime);
  }

  /**
   * 专属一线版-企业修改员工license
   * 
   * @param request - UpdateRealmLicenseRequest
   * @param headers - UpdateRealmLicenseHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateRealmLicenseResponse
   */
  async updateRealmLicenseWithOptions(request: UpdateRealmLicenseRequest, headers: UpdateRealmLicenseHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRealmLicenseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detailList)) {
      body["detailList"] = request.detailList;
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
      action: "UpdateRealmLicense",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/frontLines/licenses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRealmLicenseResponse>(await this.execute(params, req, runtime), new UpdateRealmLicenseResponse({}));
  }

  /**
   * 专属一线版-企业修改员工license
   * 
   * @param request - UpdateRealmLicenseRequest
   * @returns UpdateRealmLicenseResponse
   */
  async updateRealmLicense(request: UpdateRealmLicenseRequest): Promise<UpdateRealmLicenseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRealmLicenseHeaders({ });
    return await this.updateRealmLicenseWithOptions(request, headers, runtime);
  }

  /**
   * 修改角色可见性
   * 
   * @param request - UpdateRoleVisibilityRequest
   * @param headers - UpdateRoleVisibilityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateRoleVisibilityResponse
   */
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

  /**
   * 修改角色可见性
   * 
   * @param request - UpdateRoleVisibilityRequest
   * @returns UpdateRoleVisibilityResponse
   */
  async updateRoleVisibility(request: UpdateRoleVisibilityRequest): Promise<UpdateRoleVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRoleVisibilityHeaders({ });
    return await this.updateRoleVisibilityWithOptions(request, headers, runtime);
  }

  /**
   * 更新组织专属存储模式
   * 
   * @param request - UpdateStorageModeRequest
   * @param headers - UpdateStorageModeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateStorageModeResponse
   */
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

  /**
   * 更新组织专属存储模式
   * 
   * @param request - UpdateStorageModeRequest
   * @returns UpdateStorageModeResponse
   */
  async updateStorageMode(request: UpdateStorageModeRequest): Promise<UpdateStorageModeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStorageModeHeaders({ });
    return await this.updateStorageModeWithOptions(request, headers, runtime);
  }

  /**
   * 允许三方调用该API，决定对应的语音消息管控状态
   * 
   * @param request - UpdateVoiceMsgCtrlStatusRequest
   * @param headers - UpdateVoiceMsgCtrlStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateVoiceMsgCtrlStatusResponse
   */
  async updateVoiceMsgCtrlStatusWithOptions(request: UpdateVoiceMsgCtrlStatusRequest, headers: UpdateVoiceMsgCtrlStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVoiceMsgCtrlStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.voiceMsgCtrlInfo)) {
      body["voiceMsgCtrlInfo"] = request.voiceMsgCtrlInfo;
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
      action: "UpdateVoiceMsgCtrlStatus",
      version: "exclusive_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/exclusive/voiceMessages/ctrlStatuses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateVoiceMsgCtrlStatusResponse>(await this.execute(params, req, runtime), new UpdateVoiceMsgCtrlStatusResponse({}));
  }

  /**
   * 允许三方调用该API，决定对应的语音消息管控状态
   * 
   * @param request - UpdateVoiceMsgCtrlStatusRequest
   * @returns UpdateVoiceMsgCtrlStatusResponse
   */
  async updateVoiceMsgCtrlStatus(request: UpdateVoiceMsgCtrlStatusRequest): Promise<UpdateVoiceMsgCtrlStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVoiceMsgCtrlStatusHeaders({ });
    return await this.updateVoiceMsgCtrlStatusWithOptions(request, headers, runtime);
  }

}
