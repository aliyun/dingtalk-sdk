// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class ValidateOrderUpgradeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateOrderUpgradeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdRequest extends $tea.Model {
  accountId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdResponseBody extends $tea.Model {
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

export class GetCorpLevelByAccountIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCorpLevelByAccountIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCorpLevelByAccountIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStatusRequest extends $tea.Model {
  importSequence?: string;
  errorLines?: number[];
  appType?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      importSequence: 'importSequence',
      errorLines: 'errorLines',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      importSequence: 'string',
      errorLines: { 'type': 'array', 'itemType': 'number' },
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStatusResponse extends $tea.Model {
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

export class ExecutePlatformTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecutePlatformTaskRequest extends $tea.Model {
  outResult?: string;
  noExecuteExpressions?: string;
  appType?: string;
  formDataJson?: string;
  systemToken?: string;
  language?: string;
  remark?: string;
  processInstanceId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      outResult: 'outResult',
      noExecuteExpressions: 'noExecuteExpressions',
      appType: 'appType',
      formDataJson: 'formDataJson',
      systemToken: 'systemToken',
      language: 'language',
      remark: 'remark',
      processInstanceId: 'processInstanceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outResult: 'string',
      noExecuteExpressions: 'string',
      appType: 'string',
      formDataJson: 'string',
      systemToken: 'string',
      language: 'string',
      remark: 'string',
      processInstanceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecutePlatformTaskResponse extends $tea.Model {
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

export class SaveFormRemarkHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormRemarkRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  replyId?: number;
  language?: string;
  formInstanceId?: string;
  userId?: string;
  atUserId?: string;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      replyId: 'replyId',
      language: 'language',
      formInstanceId: 'formInstanceId',
      userId: 'userId',
      atUserId: 'atUserId',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      replyId: 'number',
      language: 'string',
      formInstanceId: 'string',
      userId: 'string',
      atUserId: 'string',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormRemarkResponseBody extends $tea.Model {
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

export class SaveFormRemarkResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveFormRemarkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveFormRemarkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  searchFieldJson?: string;
  currentPage?: number;
  pageSize?: number;
  originatorId?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  dynamicOrder?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      searchFieldJson: 'searchFieldJson',
      currentPage: 'currentPage',
      pageSize: 'pageSize',
      originatorId: 'originatorId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      dynamicOrder: 'dynamicOrder',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      searchFieldJson: 'string',
      currentPage: 'number',
      pageSize: 'number',
      originatorId: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      dynamicOrder: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBody extends $tea.Model {
  currentPage?: number;
  totalCount?: number;
  data?: SearchFormDatasResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      totalCount: 'number',
      data: { 'type': 'array', 'itemType': SearchFormDatasResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchFormDatasResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchFormDatasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeResponseBody extends $tea.Model {
  instanceId?: string;
  activationCode?: string;
  authType?: string;
  expireTimeGMT?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      activationCode: 'activationCode',
      authType: 'authType',
      expireTimeGMT: 'expireTimeGMT',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      activationCode: 'string',
      authType: 'string',
      expireTimeGMT: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchActivationCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchActivationCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesRequest extends $tea.Model {
  targetFieldJson?: string;
  formUuid?: string;
  appType?: string;
  modifiedToTimeGMT?: string;
  systemToken?: string;
  modifiedFromTimeGMT?: string;
  language?: string;
  searchFieldJson?: string;
  originatorId?: string;
  userId?: string;
  createToTimeGMT?: string;
  createFromTimeGMT?: string;
  static names(): { [key: string]: string } {
    return {
      targetFieldJson: 'targetFieldJson',
      formUuid: 'formUuid',
      appType: 'appType',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      systemToken: 'systemToken',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      language: 'language',
      searchFieldJson: 'searchFieldJson',
      originatorId: 'originatorId',
      userId: 'userId',
      createToTimeGMT: 'createToTimeGMT',
      createFromTimeGMT: 'createFromTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetFieldJson: 'string',
      formUuid: 'string',
      appType: 'string',
      modifiedToTimeGMT: 'string',
      systemToken: 'string',
      modifiedFromTimeGMT: 'string',
      language: 'string',
      searchFieldJson: 'string',
      originatorId: 'string',
      userId: 'string',
      createToTimeGMT: 'string',
      createFromTimeGMT: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesResponseBody extends $tea.Model {
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

export class SearchEmployeeFieldValuesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchEmployeeFieldValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchEmployeeFieldValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formInstanceId?: string;
  useLatestVersion?: boolean;
  updateFormDataJson?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formInstanceId: 'formInstanceId',
      useLatestVersion: 'useLatestVersion',
      updateFormDataJson: 'updateFormDataJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formInstanceId: 'string',
      useLatestVersion: 'boolean',
      updateFormDataJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataResponse extends $tea.Model {
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

export class GetOperationRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponseBody extends $tea.Model {
  result?: GetOperationRecordsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetOperationRecordsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOperationRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOperationRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceResponseBody extends $tea.Model {
  appTotalAmount?: number;
  instanceTotalAmount?: number;
  instanceUsageAmount?: number;
  accountUsageAmount?: number;
  accountTotalAmount?: number;
  pluginUsageAmount?: number;
  attachmentTotalAmount?: number;
  attachmentUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      appTotalAmount: 'appTotalAmount',
      instanceTotalAmount: 'instanceTotalAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      accountUsageAmount: 'accountUsageAmount',
      accountTotalAmount: 'accountTotalAmount',
      pluginUsageAmount: 'pluginUsageAmount',
      attachmentTotalAmount: 'attachmentTotalAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTotalAmount: 'number',
      instanceTotalAmount: 'number',
      instanceUsageAmount: 'number',
      accountUsageAmount: 'number',
      accountTotalAmount: 'number',
      pluginUsageAmount: 'number',
      attachmentTotalAmount: 'number',
      attachmentUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPlatformResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksRequest extends $tea.Model {
  processInstanceId?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponseBody extends $tea.Model {
  result?: GetRunningTasksResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetRunningTasksResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRunningTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRunningTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formType?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formType: 'formType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBody extends $tea.Model {
  result?: ListNavigationByFormTypeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListNavigationByFormTypeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListNavigationByFormTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListNavigationByFormTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceResponse extends $tea.Model {
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

export class ExpireCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityResponseBody extends $tea.Model {
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExpireCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExpireCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateOrderBuyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateOrderBuyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  formDataJson?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      formDataJson: 'formDataJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      formDataJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataResponseBody extends $tea.Model {
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

export class SaveFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveFormDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formInstanceId: 'formInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataResponse extends $tea.Model {
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

export class UpdateInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceRequest extends $tea.Model {
  processInstanceId?: string;
  appType?: string;
  updateFormDataJson?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      appType: 'appType',
      updateFormDataJson: 'updateFormDataJson',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      appType: 'string',
      updateFormDataJson: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceResponse extends $tea.Model {
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

export class ListCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityRequest extends $tea.Model {
  accessKey?: string;
  pageSize?: number;
  callerUid?: string;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      pageSize: 'pageSize',
      callerUid: 'callerUid',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      pageSize: 'number',
      callerUid: 'string',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponseBody extends $tea.Model {
  pageSize?: number;
  commodityVOList?: ListCommodityResponseBodyCommodityVOList[];
  currentPage?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      commodityVOList: 'commodityVOList',
      currentPage: 'currentPage',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      commodityVOList: { 'type': 'array', 'itemType': ListCommodityResponseBodyCommodityVOList },
      currentPage: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceResponseBody extends $tea.Model {
  appTotalAmount?: number;
  instanceId?: string;
  instanceTotalAmount?: number;
  instanceUsageAmount?: number;
  accountUsageAmount?: number;
  accountTotalAmount?: number;
  pluginUsageAmount?: number;
  attachmentTotalAmount?: number;
  attachmentUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      appTotalAmount: 'appTotalAmount',
      instanceId: 'instanceId',
      instanceTotalAmount: 'instanceTotalAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      accountUsageAmount: 'accountUsageAmount',
      accountTotalAmount: 'accountTotalAmount',
      pluginUsageAmount: 'pluginUsageAmount',
      attachmentTotalAmount: 'attachmentTotalAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTotalAmount: 'number',
      instanceId: 'string',
      instanceTotalAmount: 'number',
      instanceUsageAmount: 'number',
      accountUsageAmount: 'number',
      accountTotalAmount: 'number',
      pluginUsageAmount: 'number',
      attachmentTotalAmount: 'number',
      attachmentUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetApplicationAuthorizationServicePlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetApplicationAuthorizationServicePlatformResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListRequest extends $tea.Model {
  processCode?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponseBody extends $tea.Model {
  result?: GetActivityListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetActivityListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetActivityListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetActivityListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBody extends $tea.Model {
  originator?: GetFormDataByIDResponseBodyOriginator;
  modifiedTimeGMT?: string;
  formUuid?: string;
  formInstId?: string;
  formData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      originator: 'originator',
      modifiedTimeGMT: 'modifiedTimeGMT',
      formUuid: 'formUuid',
      formInstId: 'formInstId',
      formData: 'formData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      originator: GetFormDataByIDResponseBodyOriginator,
      modifiedTimeGMT: 'string',
      formUuid: 'string',
      formInstId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFormDataByIDResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFormDataByIDResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiRequest extends $tea.Model {
  data?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  serviceId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      serviceId: 'serviceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      serviceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiResponseBody extends $tea.Model {
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

export class ExecuteCustomApiResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExecuteCustomApiResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExecuteCustomApiResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityResponseBody extends $tea.Model {
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RefundCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RefundCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceRequest extends $tea.Model {
  userId?: string;
  sequence?: string;
  systemToken?: string;
  language?: string;
  appType?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      sequence: 'sequence',
      systemToken: 'systemToken',
      language: 'language',
      appType: 'appType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      sequence: 'string',
      systemToken: 'string',
      language: 'string',
      appType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceResponse extends $tea.Model {
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

export class ReleaseCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityResponseBody extends $tea.Model {
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenResponseBody extends $tea.Model {
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

export class LoginCodeGenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: LoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LoginCodeGenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdRequest extends $tea.Model {
  corpId?: string;
  namespace?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      namespace: 'namespace',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      namespace: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponseBody extends $tea.Model {
  userName?: string;
  userId?: string;
  accountId?: number;
  corpList?: GetSaleUserInfoByUserIdResponseBodyCorpList[];
  static names(): { [key: string]: string } {
    return {
      userName: 'userName',
      userId: 'userId',
      accountId: 'accountId',
      corpList: 'corpList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userName: 'string',
      userId: 'string',
      accountId: 'number',
      corpList: { 'type': 'array', 'itemType': GetSaleUserInfoByUserIdResponseBodyCorpList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSaleUserInfoByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSaleUserInfoByUserIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskRequest extends $tea.Model {
  outResult?: string;
  noExecuteExpressions?: string;
  appType?: string;
  formDataJson?: string;
  systemToken?: string;
  language?: string;
  remark?: string;
  processInstanceId?: string;
  userId?: string;
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      outResult: 'outResult',
      noExecuteExpressions: 'noExecuteExpressions',
      appType: 'appType',
      formDataJson: 'formDataJson',
      systemToken: 'systemToken',
      language: 'language',
      remark: 'remark',
      processInstanceId: 'processInstanceId',
      userId: 'userId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outResult: 'string',
      noExecuteExpressions: 'string',
      appType: 'string',
      formDataJson: 'string',
      systemToken: 'string',
      language: 'string',
      remark: 'string',
      processInstanceId: 'string',
      userId: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskResponse extends $tea.Model {
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

export class StartInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  formDataJson?: string;
  processCode?: string;
  departmentId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      formDataJson: 'formDataJson',
      processCode: 'processCode',
      departmentId: 'departmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      formDataJson: 'string',
      processCode: 'string',
      departmentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceResponseBody extends $tea.Model {
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

export class StartInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceResponse extends $tea.Model {
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

export class SearchFormDatasResponseBodyDataOriginatorUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataOriginator extends $tea.Model {
  userId?: string;
  userName?: SearchFormDatasResponseBodyDataOriginatorUserName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataOriginatorUserName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataModifyUserUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataModifyUser extends $tea.Model {
  userId?: string;
  userName?: SearchFormDatasResponseBodyDataModifyUserUserName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataModifyUserUserName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyData extends $tea.Model {
  dataId?: number;
  formInstanceId?: string;
  createdTimeGMT?: string;
  modifiedTimeGMT?: string;
  formUuid?: string;
  modelUuid?: string;
  originator?: SearchFormDatasResponseBodyDataOriginator;
  modifyUser?: SearchFormDatasResponseBodyDataModifyUser;
  formData?: { [key: string]: any };
  title?: string;
  serialNo?: string;
  instanceValue?: string;
  version?: number;
  creatorUserId?: string;
  modifierUserId?: string;
  sequence?: string;
  static names(): { [key: string]: string } {
    return {
      dataId: 'dataId',
      formInstanceId: 'formInstanceId',
      createdTimeGMT: 'createdTimeGMT',
      modifiedTimeGMT: 'modifiedTimeGMT',
      formUuid: 'formUuid',
      modelUuid: 'modelUuid',
      originator: 'originator',
      modifyUser: 'modifyUser',
      formData: 'formData',
      title: 'title',
      serialNo: 'serialNo',
      instanceValue: 'instanceValue',
      version: 'version',
      creatorUserId: 'creatorUserId',
      modifierUserId: 'modifierUserId',
      sequence: 'sequence',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataId: 'number',
      formInstanceId: 'string',
      createdTimeGMT: 'string',
      modifiedTimeGMT: 'string',
      formUuid: 'string',
      modelUuid: 'string',
      originator: SearchFormDatasResponseBodyDataOriginator,
      modifyUser: SearchFormDatasResponseBodyDataModifyUser,
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      title: 'string',
      serialNo: 'string',
      instanceValue: 'string',
      version: 'number',
      creatorUserId: 'string',
      modifierUserId: 'string',
      sequence: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponseBodyResult extends $tea.Model {
  processInstanceId?: string;
  showName?: string;
  operatorNickName?: string;
  activeTimeGMT?: string;
  operateTimeGMT?: string;
  operateType?: string;
  operatorStatus?: string;
  remark?: string;
  taskHoldTimeGMT?: number;
  type?: string;
  operatorName?: string;
  operatorUserId?: string;
  activityId?: string;
  taskType?: string;
  taskExecuteType?: string;
  size?: number;
  operatorDisplayName?: string;
  files?: string;
  action?: string;
  actionExit?: string;
  dataId?: number;
  taskId?: string;
  digitalSign?: string;
  operatorPhotoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      showName: 'showName',
      operatorNickName: 'operatorNickName',
      activeTimeGMT: 'activeTimeGMT',
      operateTimeGMT: 'operateTimeGMT',
      operateType: 'operateType',
      operatorStatus: 'operatorStatus',
      remark: 'remark',
      taskHoldTimeGMT: 'taskHoldTimeGMT',
      type: 'type',
      operatorName: 'operatorName',
      operatorUserId: 'operatorUserId',
      activityId: 'activityId',
      taskType: 'taskType',
      taskExecuteType: 'taskExecuteType',
      size: 'size',
      operatorDisplayName: 'operatorDisplayName',
      files: 'files',
      action: 'action',
      actionExit: 'actionExit',
      dataId: 'dataId',
      taskId: 'taskId',
      digitalSign: 'digitalSign',
      operatorPhotoUrl: 'operatorPhotoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      showName: 'string',
      operatorNickName: 'string',
      activeTimeGMT: 'string',
      operateTimeGMT: 'string',
      operateType: 'string',
      operatorStatus: 'string',
      remark: 'string',
      taskHoldTimeGMT: 'number',
      type: 'string',
      operatorName: 'string',
      operatorUserId: 'string',
      activityId: 'string',
      taskType: 'string',
      taskExecuteType: 'string',
      size: 'number',
      operatorDisplayName: 'string',
      files: 'string',
      action: 'string',
      actionExit: 'string',
      dataId: 'number',
      taskId: 'string',
      digitalSign: 'string',
      operatorPhotoUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponseBodyResult extends $tea.Model {
  createTimeGMT?: string;
  activityId?: string;
  processInstanceId?: string;
  taskType?: string;
  titleInEnglish?: string;
  activeTimeGMT?: string;
  actualActionerId?: string;
  originatorId?: string;
  finishTimeGMT?: string;
  title?: string;
  taskId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      activityId: 'activityId',
      processInstanceId: 'processInstanceId',
      taskType: 'taskType',
      titleInEnglish: 'titleInEnglish',
      activeTimeGMT: 'activeTimeGMT',
      actualActionerId: 'actualActionerId',
      originatorId: 'originatorId',
      finishTimeGMT: 'finishTimeGMT',
      title: 'title',
      taskId: 'taskId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      activityId: 'string',
      processInstanceId: 'string',
      taskType: 'string',
      titleInEnglish: 'string',
      activeTimeGMT: 'string',
      actualActionerId: 'string',
      originatorId: 'string',
      finishTimeGMT: 'string',
      title: 'string',
      taskId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBodyResultTitle extends $tea.Model {
  nameInEnglish?: string;
  type?: string;
  nameInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      nameInEnglish: 'nameInEnglish',
      type: 'type',
      nameInChinese: 'nameInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInEnglish: 'string',
      type: 'string',
      nameInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBodyResult extends $tea.Model {
  title?: ListNavigationByFormTypeResponseBodyResultTitle;
  processCode?: string;
  formUuid?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      processCode: 'processCode',
      formUuid: 'formUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: ListNavigationByFormTypeResponseBodyResultTitle,
      processCode: 'string',
      formUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponseBodyCommodityVOList extends $tea.Model {
  instanceId?: string;
  buyDateGMT?: string;
  expireDateGMT?: string;
  activationCode?: string;
  accountNumber?: number;
  accountDistributionNumber?: number;
  version?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      buyDateGMT: 'buyDateGMT',
      expireDateGMT: 'expireDateGMT',
      activationCode: 'activationCode',
      accountNumber: 'accountNumber',
      accountDistributionNumber: 'accountDistributionNumber',
      version: 'version',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      buyDateGMT: 'string',
      expireDateGMT: 'string',
      activationCode: 'string',
      accountNumber: 'number',
      accountDistributionNumber: 'number',
      version: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponseBodyResult extends $tea.Model {
  activityName?: string;
  activityNameInEnglish?: string;
  activityId?: string;
  static names(): { [key: string]: string } {
    return {
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
      activityId: 'activityId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityName: 'string',
      activityNameInEnglish: 'string',
      activityId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBodyOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBodyOriginator extends $tea.Model {
  userId?: string;
  name?: GetFormDataByIDResponseBodyOriginatorName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: GetFormDataByIDResponseBodyOriginatorName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponseBodyCorpList extends $tea.Model {
  namespace?: string;
  corpId?: string;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      namespace: 'namespace',
      corpId: 'corpId',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      namespace: 'string',
      corpId: 'string',
      corpName: 'string',
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


  async validateOrderUpgrade(request: ValidateOrderUpgradeRequest): Promise<ValidateOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpgradeHeaders({ });
    return await this.validateOrderUpgradeWithOptions(request, headers, runtime);
  }

  async validateOrderUpgradeWithOptions(request: ValidateOrderUpgradeRequest, headers: ValidateOrderUpgradeHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderUpgradeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ValidateOrderUpgradeResponse>(await this.doROARequest("ValidateOrderUpgrade", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/orderUpgrade/validate`, "json", req, runtime), new ValidateOrderUpgradeResponse({}));
  }

  async getCorpLevelByAccountId(request: GetCorpLevelByAccountIdRequest): Promise<GetCorpLevelByAccountIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpLevelByAccountIdHeaders({ });
    return await this.getCorpLevelByAccountIdWithOptions(request, headers, runtime);
  }

  async getCorpLevelByAccountIdWithOptions(request: GetCorpLevelByAccountIdRequest, headers: GetCorpLevelByAccountIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpLevelByAccountIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
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
    return $tea.cast<GetCorpLevelByAccountIdResponse>(await this.doROARequest("GetCorpLevelByAccountId", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/corpLevel`, "json", req, runtime), new GetCorpLevelByAccountIdResponse({}));
  }

  async updateStatus(request: UpdateStatusRequest): Promise<UpdateStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStatusHeaders({ });
    return await this.updateStatusWithOptions(request, headers, runtime);
  }

  async updateStatusWithOptions(request: UpdateStatusRequest, headers: UpdateStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.importSequence)) {
      body["importSequence"] = request.importSequence;
    }

    if (!Util.isUnset(request.errorLines)) {
      body["errorLines"] = request.errorLines;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<UpdateStatusResponse>(await this.doROARequest("UpdateStatus", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/forms/status`, "none", req, runtime), new UpdateStatusResponse({}));
  }

  async executePlatformTask(request: ExecutePlatformTaskRequest): Promise<ExecutePlatformTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecutePlatformTaskHeaders({ });
    return await this.executePlatformTaskWithOptions(request, headers, runtime);
  }

  async executePlatformTaskWithOptions(request: ExecutePlatformTaskRequest, headers: ExecutePlatformTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecutePlatformTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.noExecuteExpressions)) {
      body["noExecuteExpressions"] = request.noExecuteExpressions;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<ExecutePlatformTaskResponse>(await this.doROARequest("ExecutePlatformTask", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/tasks/platformTasks/execute`, "none", req, runtime), new ExecutePlatformTaskResponse({}));
  }

  async saveFormRemark(request: SaveFormRemarkRequest): Promise<SaveFormRemarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormRemarkHeaders({ });
    return await this.saveFormRemarkWithOptions(request, headers, runtime);
  }

  async saveFormRemarkWithOptions(request: SaveFormRemarkRequest, headers: SaveFormRemarkHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormRemarkResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.replyId)) {
      body["replyId"] = request.replyId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      body["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.atUserId)) {
      body["atUserId"] = request.atUserId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
    return $tea.cast<SaveFormRemarkResponse>(await this.doROARequest("SaveFormRemark", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/remarks`, "json", req, runtime), new SaveFormRemarkResponse({}));
  }

  async searchFormDatas(request: SearchFormDatasRequest): Promise<SearchFormDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDatasHeaders({ });
    return await this.searchFormDatasWithOptions(request, headers, runtime);
  }

  async searchFormDatasWithOptions(request: SearchFormDatasRequest, headers: SearchFormDatasHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDatasResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.dynamicOrder)) {
      body["dynamicOrder"] = request.dynamicOrder;
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
    return $tea.cast<SearchFormDatasResponse>(await this.doROARequest("SearchFormDatas", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances/search`, "json", req, runtime), new SearchFormDatasResponse({}));
  }

  async searchActivationCode(request: SearchActivationCodeRequest): Promise<SearchActivationCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchActivationCodeHeaders({ });
    return await this.searchActivationCodeWithOptions(request, headers, runtime);
  }

  async searchActivationCodeWithOptions(request: SearchActivationCodeRequest, headers: SearchActivationCodeHeaders, runtime: $Util.RuntimeOptions): Promise<SearchActivationCodeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<SearchActivationCodeResponse>(await this.doROARequest("SearchActivationCode", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/activationCode/information`, "json", req, runtime), new SearchActivationCodeResponse({}));
  }

  async searchEmployeeFieldValues(request: SearchEmployeeFieldValuesRequest): Promise<SearchEmployeeFieldValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchEmployeeFieldValuesHeaders({ });
    return await this.searchEmployeeFieldValuesWithOptions(request, headers, runtime);
  }

  async searchEmployeeFieldValuesWithOptions(request: SearchEmployeeFieldValuesRequest, headers: SearchEmployeeFieldValuesHeaders, runtime: $Util.RuntimeOptions): Promise<SearchEmployeeFieldValuesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetFieldJson)) {
      body["targetFieldJson"] = request.targetFieldJson;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
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
    return $tea.cast<SearchEmployeeFieldValuesResponse>(await this.doROARequest("SearchEmployeeFieldValues", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/employeeFields`, "json", req, runtime), new SearchEmployeeFieldValuesResponse({}));
  }

  async updateFormData(request: UpdateFormDataRequest): Promise<UpdateFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFormDataHeaders({ });
    return await this.updateFormDataWithOptions(request, headers, runtime);
  }

  async updateFormDataWithOptions(request: UpdateFormDataRequest, headers: UpdateFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      body["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.useLatestVersion)) {
      body["useLatestVersion"] = request.useLatestVersion;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
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
    return $tea.cast<UpdateFormDataResponse>(await this.doROARequest("UpdateFormData", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/forms/instances`, "none", req, runtime), new UpdateFormDataResponse({}));
  }

  async getOperationRecords(request: GetOperationRecordsRequest): Promise<GetOperationRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOperationRecordsHeaders({ });
    return await this.getOperationRecordsWithOptions(request, headers, runtime);
  }

  async getOperationRecordsWithOptions(request: GetOperationRecordsRequest, headers: GetOperationRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOperationRecordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<GetOperationRecordsResponse>(await this.doROARequest("GetOperationRecords", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/operationRecords`, "json", req, runtime), new GetOperationRecordsResponse({}));
  }

  async getPlatformResource(request: GetPlatformResourceRequest): Promise<GetPlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPlatformResourceHeaders({ });
    return await this.getPlatformResourceWithOptions(request, headers, runtime);
  }

  async getPlatformResourceWithOptions(request: GetPlatformResourceRequest, headers: GetPlatformResourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetPlatformResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<GetPlatformResourceResponse>(await this.doROARequest("GetPlatformResource", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/platformResources`, "json", req, runtime), new GetPlatformResourceResponse({}));
  }

  async getRunningTasks(request: GetRunningTasksRequest): Promise<GetRunningTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTasksHeaders({ });
    return await this.getRunningTasksWithOptions(request, headers, runtime);
  }

  async getRunningTasksWithOptions(request: GetRunningTasksRequest, headers: GetRunningTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetRunningTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetRunningTasksResponse>(await this.doROARequest("GetRunningTasks", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/tasks/getRunningTasks`, "json", req, runtime), new GetRunningTasksResponse({}));
  }

  async listNavigationByFormType(request: ListNavigationByFormTypeRequest): Promise<ListNavigationByFormTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListNavigationByFormTypeHeaders({ });
    return await this.listNavigationByFormTypeWithOptions(request, headers, runtime);
  }

  async listNavigationByFormTypeWithOptions(request: ListNavigationByFormTypeRequest, headers: ListNavigationByFormTypeHeaders, runtime: $Util.RuntimeOptions): Promise<ListNavigationByFormTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.formType)) {
      query["formType"] = request.formType;
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
    return $tea.cast<ListNavigationByFormTypeResponse>(await this.doROARequest("ListNavigationByFormType", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/navigations`, "json", req, runtime), new ListNavigationByFormTypeResponse({}));
  }

  async terminateInstance(request: TerminateInstanceRequest): Promise<TerminateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateInstanceHeaders({ });
    return await this.terminateInstanceWithOptions(request, headers, runtime);
  }

  async terminateInstanceWithOptions(request: TerminateInstanceRequest, headers: TerminateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<TerminateInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<TerminateInstanceResponse>(await this.doROARequest("TerminateInstance", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/processes/instances/terminate`, "none", req, runtime), new TerminateInstanceResponse({}));
  }

  async expireCommodity(request: ExpireCommodityRequest): Promise<ExpireCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExpireCommodityHeaders({ });
    return await this.expireCommodityWithOptions(request, headers, runtime);
  }

  async expireCommodityWithOptions(request: ExpireCommodityRequest, headers: ExpireCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ExpireCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ExpireCommodityResponse>(await this.doROARequest("ExpireCommodity", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/appAuth/commodities/expire`, "json", req, runtime), new ExpireCommodityResponse({}));
  }

  async validateOrderBuy(request: ValidateOrderBuyRequest): Promise<ValidateOrderBuyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderBuyHeaders({ });
    return await this.validateOrderBuyWithOptions(request, headers, runtime);
  }

  async validateOrderBuyWithOptions(request: ValidateOrderBuyRequest, headers: ValidateOrderBuyHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderBuyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ValidateOrderBuyResponse>(await this.doROARequest("ValidateOrderBuy", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/orderBuy/validate`, "json", req, runtime), new ValidateOrderBuyResponse({}));
  }

  async saveFormData(request: SaveFormDataRequest): Promise<SaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormDataHeaders({ });
    return await this.saveFormDataWithOptions(request, headers, runtime);
  }

  async saveFormDataWithOptions(request: SaveFormDataRequest, headers: SaveFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
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
    return $tea.cast<SaveFormDataResponse>(await this.doROARequest("SaveFormData", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances`, "json", req, runtime), new SaveFormDataResponse({}));
  }

  async deleteFormData(request: DeleteFormDataRequest): Promise<DeleteFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFormDataHeaders({ });
    return await this.deleteFormDataWithOptions(request, headers, runtime);
  }

  async deleteFormDataWithOptions(request: DeleteFormDataRequest, headers: DeleteFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFormDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      query["formInstanceId"] = request.formInstanceId;
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
    return $tea.cast<DeleteFormDataResponse>(await this.doROARequest("DeleteFormData", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/forms/instances`, "none", req, runtime), new DeleteFormDataResponse({}));
  }

  async updateInstance(request: UpdateInstanceRequest): Promise<UpdateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceHeaders({ });
    return await this.updateInstanceWithOptions(request, headers, runtime);
  }

  async updateInstanceWithOptions(request: UpdateInstanceRequest, headers: UpdateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
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
    return $tea.cast<UpdateInstanceResponse>(await this.doROARequest("UpdateInstance", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/processes/instances`, "none", req, runtime), new UpdateInstanceResponse({}));
  }

  async listCommodity(request: ListCommodityRequest): Promise<ListCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCommodityHeaders({ });
    return await this.listCommodityWithOptions(request, headers, runtime);
  }

  async listCommodityWithOptions(request: ListCommodityRequest, headers: ListCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ListCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.currentPage)) {
      query["currentPage"] = request.currentPage;
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
    return $tea.cast<ListCommodityResponse>(await this.doROARequest("ListCommodity", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/appAuth/commodities`, "json", req, runtime), new ListCommodityResponse({}));
  }

  async getApplicationAuthorizationServicePlatformResource(request: GetApplicationAuthorizationServicePlatformResourceRequest): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationAuthorizationServicePlatformResourceHeaders({ });
    return await this.getApplicationAuthorizationServicePlatformResourceWithOptions(request, headers, runtime);
  }

  async getApplicationAuthorizationServicePlatformResourceWithOptions(request: GetApplicationAuthorizationServicePlatformResourceRequest, headers: GetApplicationAuthorizationServicePlatformResourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<GetApplicationAuthorizationServicePlatformResourceResponse>(await this.doROARequest("GetApplicationAuthorizationServicePlatformResource", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/authorization/platformResources`, "json", req, runtime), new GetApplicationAuthorizationServicePlatformResourceResponse({}));
  }

  async getActivityList(request: GetActivityListRequest): Promise<GetActivityListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityListHeaders({ });
    return await this.getActivityListWithOptions(request, headers, runtime);
  }

  async getActivityListWithOptions(request: GetActivityListRequest, headers: GetActivityListHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivityListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetActivityListResponse>(await this.doROARequest("GetActivityList", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/activities`, "json", req, runtime), new GetActivityListResponse({}));
  }

  async getFormDataByID(id: string, request: GetFormDataByIDRequest): Promise<GetFormDataByIDResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormDataByIDHeaders({ });
    return await this.getFormDataByIDWithOptions(id, request, headers, runtime);
  }

  async getFormDataByIDWithOptions(id: string, request: GetFormDataByIDRequest, headers: GetFormDataByIDHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormDataByIDResponse> {
    Util.validateModel(request);
    id = OpenApiUtil.getEncodeParam(id);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetFormDataByIDResponse>(await this.doROARequest("GetFormDataByID", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/forms/instances/${id}`, "json", req, runtime), new GetFormDataByIDResponse({}));
  }

  async executeCustomApi(request: ExecuteCustomApiRequest): Promise<ExecuteCustomApiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteCustomApiHeaders({ });
    return await this.executeCustomApiWithOptions(request, headers, runtime);
  }

  async executeCustomApiWithOptions(request: ExecuteCustomApiRequest, headers: ExecuteCustomApiHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteCustomApiResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      query["data"] = request.data;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.serviceId)) {
      query["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<ExecuteCustomApiResponse>(await this.doROARequest("ExecuteCustomApi", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/apps/customApi/execute`, "json", req, runtime), new ExecuteCustomApiResponse({}));
  }

  async refundCommodity(request: RefundCommodityRequest): Promise<RefundCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RefundCommodityHeaders({ });
    return await this.refundCommodityWithOptions(request, headers, runtime);
  }

  async refundCommodityWithOptions(request: RefundCommodityRequest, headers: RefundCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<RefundCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<RefundCommodityResponse>(await this.doROARequest("RefundCommodity", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/appAuth/commodities/refund`, "json", req, runtime), new RefundCommodityResponse({}));
  }

  async deleteSequence(request: DeleteSequenceRequest): Promise<DeleteSequenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSequenceHeaders({ });
    return await this.deleteSequenceWithOptions(request, headers, runtime);
  }

  async deleteSequenceWithOptions(request: DeleteSequenceRequest, headers: DeleteSequenceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSequenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.sequence)) {
      query["sequence"] = request.sequence;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
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
    return $tea.cast<DeleteSequenceResponse>(await this.doROARequest("DeleteSequence", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/forms/deleteSequence`, "none", req, runtime), new DeleteSequenceResponse({}));
  }

  async releaseCommodity(request: ReleaseCommodityRequest): Promise<ReleaseCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseCommodityHeaders({ });
    return await this.releaseCommodityWithOptions(request, headers, runtime);
  }

  async releaseCommodityWithOptions(request: ReleaseCommodityRequest, headers: ReleaseCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ReleaseCommodityResponse>(await this.doROARequest("ReleaseCommodity", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/appAuth/commodities/release`, "json", req, runtime), new ReleaseCommodityResponse({}));
  }

  async loginCodeGen(request: LoginCodeGenRequest): Promise<LoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoginCodeGenHeaders({ });
    return await this.loginCodeGenWithOptions(request, headers, runtime);
  }

  async loginCodeGenWithOptions(request: LoginCodeGenRequest, headers: LoginCodeGenHeaders, runtime: $Util.RuntimeOptions): Promise<LoginCodeGenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<LoginCodeGenResponse>(await this.doROARequest("LoginCodeGen", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/authorizations/loginCodes`, "json", req, runtime), new LoginCodeGenResponse({}));
  }

  async getSaleUserInfoByUserId(request: GetSaleUserInfoByUserIdRequest): Promise<GetSaleUserInfoByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSaleUserInfoByUserIdHeaders({ });
    return await this.getSaleUserInfoByUserIdWithOptions(request, headers, runtime);
  }

  async getSaleUserInfoByUserIdWithOptions(request: GetSaleUserInfoByUserIdRequest, headers: GetSaleUserInfoByUserIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetSaleUserInfoByUserIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.namespace)) {
      query["namespace"] = request.namespace;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetSaleUserInfoByUserIdResponse>(await this.doROARequest("GetSaleUserInfoByUserId", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/saleUserInfo`, "json", req, runtime), new GetSaleUserInfoByUserIdResponse({}));
  }

  async executeTask(request: ExecuteTaskRequest): Promise<ExecuteTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteTaskHeaders({ });
    return await this.executeTaskWithOptions(request, headers, runtime);
  }

  async executeTaskWithOptions(request: ExecuteTaskRequest, headers: ExecuteTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.noExecuteExpressions)) {
      body["noExecuteExpressions"] = request.noExecuteExpressions;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
    return $tea.cast<ExecuteTaskResponse>(await this.doROARequest("ExecuteTask", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/tasks/execute`, "none", req, runtime), new ExecuteTaskResponse({}));
  }

  async startInstance(request: StartInstanceRequest): Promise<StartInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartInstanceHeaders({ });
    return await this.startInstanceWithOptions(request, headers, runtime);
  }

  async startInstanceWithOptions(request: StartInstanceRequest, headers: StartInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<StartInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.departmentId)) {
      body["departmentId"] = request.departmentId;
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
    return $tea.cast<StartInstanceResponse>(await this.doROARequest("StartInstance", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/processes/instances/start`, "json", req, runtime), new StartInstanceResponse({}));
  }

  async deleteInstance(request: DeleteInstanceRequest): Promise<DeleteInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInstanceHeaders({ });
    return await this.deleteInstanceWithOptions(request, headers, runtime);
  }

  async deleteInstanceWithOptions(request: DeleteInstanceRequest, headers: DeleteInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<DeleteInstanceResponse>(await this.doROARequest("DeleteInstance", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/processes/instances`, "none", req, runtime), new DeleteInstanceResponse({}));
  }

}
