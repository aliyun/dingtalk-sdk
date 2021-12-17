// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetOfficialAccountContactsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsRequest extends $tea.Model {
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBody extends $tea.Model {
  nextToken?: string;
  maxResults?: number;
  values?: GetOfficialAccountContactsResponseBodyValues[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      maxResults: 'number',
      values: { 'type': 'array', 'itemType': GetOfficialAccountContactsResponseBodyValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOfficialAccountContactsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOfficialAccountContactsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequest extends $tea.Model {
  detail?: ServiceWindowMessageBatchPushRequestDetail;
  bizId?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      bizId: 'bizId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: ServiceWindowMessageBatchPushRequestDetail,
      bizId: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushResponseBody extends $tea.Model {
  result?: ServiceWindowMessageBatchPushResponseBodyResult;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ServiceWindowMessageBatchPushResponseBodyResult,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ServiceWindowMessageBatchPushResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ServiceWindowMessageBatchPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmFormInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmFormInstanceRequest extends $tea.Model {
  currentOperatorUserId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmFormInstanceResponseBody extends $tea.Model {
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmFormInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteCrmFormInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteCrmFormInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionRequest extends $tea.Model {
  formCode?: string;
  bizType?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      bizType: 'bizType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      bizType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBody extends $tea.Model {
  permissions?: GetCrmRolePermissionResponseBodyPermissions[];
  static names(): { [key: string]: string } {
    return {
      permissions: 'permissions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      permissions: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCrmRolePermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCrmRolePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequest extends $tea.Model {
  detail?: BatchSendOfficialAccountOTOMessageRequestDetail;
  bizId?: string;
  accountId?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      bizId: 'bizId',
      accountId: 'accountId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: BatchSendOfficialAccountOTOMessageRequestDetail,
      bizId: 'string',
      accountId: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageResponseBody extends $tea.Model {
  result?: BatchSendOfficialAccountOTOMessageResponseBodyResult;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchSendOfficialAccountOTOMessageResponseBodyResult,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchSendOfficialAccountOTOMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchSendOfficialAccountOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactInfoResponseBody extends $tea.Model {
  corpName?: string;
  mobile?: string;
  stateCode?: string;
  unionId?: string;
  authItems?: string[];
  userInfos?: string[];
  static names(): { [key: string]: string } {
    return {
      corpName: 'corpName',
      mobile: 'mobile',
      stateCode: 'stateCode',
      unionId: 'unionId',
      authItems: 'authItems',
      userInfos: 'userInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpName: 'string',
      mobile: 'string',
      stateCode: 'string',
      unionId: 'string',
      authItems: { 'type': 'array', 'itemType': 'string' },
      userInfos: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOfficialAccountContactInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOfficialAccountContactInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingCorpId?: string;
  dingSuiteKey?: string;
  operatorUserId?: string;
  maxResults?: number;
  nextToken?: string;
  objectType?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingCorpId: 'dingCorpId',
      dingSuiteKey: 'dingSuiteKey',
      operatorUserId: 'operatorUserId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      objectType: 'objectType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingCorpId: 'string',
      dingSuiteKey: 'string',
      operatorUserId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      objectType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBody extends $tea.Model {
  result?: QueryAllCustomerResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAllCustomerResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldRequest extends $tea.Model {
  tenant?: string;
  operatorUserId?: string;
  relationType?: string;
  fieldDTOList?: UpdateRelationMetaFieldRequestFieldDTOList[];
  static names(): { [key: string]: string } {
    return {
      tenant: 'tenant',
      operatorUserId: 'operatorUserId',
      relationType: 'relationType',
      fieldDTOList: 'fieldDTOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenant: 'string',
      operatorUserId: 'string',
      relationType: 'string',
      fieldDTOList: { 'type': 'array', 'itemType': UpdateRelationMetaFieldRequestFieldDTOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBody extends $tea.Model {
  relationMetaDTO?: UpdateRelationMetaFieldResponseBodyRelationMetaDTO;
  static names(): { [key: string]: string } {
    return {
      relationMetaDTO: 'relationMetaDTO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationMetaDTO: UpdateRelationMetaFieldResponseBodyRelationMetaDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateRelationMetaFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateRelationMetaFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequest extends $tea.Model {
  detail?: SendOfficialAccountOTOMessageRequestDetail;
  bizId?: string;
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  accountId?: string;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      bizId: 'bizId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      accountId: 'accountId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: SendOfficialAccountOTOMessageRequestDetail,
      bizId: 'string',
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      accountId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  result?: SendOfficialAccountOTOMessageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: SendOfficialAccountOTOMessageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendOfficialAccountOTOMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendOfficialAccountOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultRequest extends $tea.Model {
  openPushId?: string;
  accountId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
      accountId: 'accountId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
      accountId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultResponseBody extends $tea.Model {
  requestId?: string;
  result?: GetOfficialAccountOTOMessageResultResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: GetOfficialAccountOTOMessageResultResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOfficialAccountOTOMessageResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOfficialAccountOTOMessageResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaRequest extends $tea.Model {
  tenant?: string;
  operatorUserId?: string;
  relationTypes?: string[];
  static names(): { [key: string]: string } {
    return {
      tenant: 'tenant',
      operatorUserId: 'operatorUserId',
      relationTypes: 'relationTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenant: 'string',
      operatorUserId: 'string',
      relationTypes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBody extends $tea.Model {
  relationMetaDTOList?: DescribeRelationMetaResponseBodyRelationMetaDTOList[];
  static names(): { [key: string]: string } {
    return {
      relationMetaDTOList: 'relationMetaDTOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationMetaDTOList: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DescribeRelationMetaResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DescribeRelationMetaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCrmPersonalCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCrmPersonalCustomerRequest extends $tea.Model {
  creatorUserId?: string;
  creatorNick?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: AddCrmPersonalCustomerRequestPermission;
  skipDuplicateCheck?: boolean;
  action?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      creatorNick: 'creatorNick',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
      skipDuplicateCheck: 'skipDuplicateCheck',
      action: 'action',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      creatorNick: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      permission: AddCrmPersonalCustomerRequestPermission,
      skipDuplicateCheck: 'boolean',
      action: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCrmPersonalCustomerResponseBody extends $tea.Model {
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCrmPersonalCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddCrmPersonalCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallOfficialAccountOTOMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallOfficialAccountOTOMessageRequest extends $tea.Model {
  dingSuiteKey?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingTokenGrantType?: number;
  accountId?: string;
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      dingSuiteKey: 'dingSuiteKey',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      accountId: 'accountId',
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingSuiteKey: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingTokenGrantType: 'number',
      accountId: 'string',
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallOfficialAccountOTOMessageResponseBody extends $tea.Model {
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

export class RecallOfficialAccountOTOMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RecallOfficialAccountOTOMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RecallOfficialAccountOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBody extends $tea.Model {
  name?: string;
  customized?: boolean;
  fields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFields[];
  status?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      customized: 'customized',
      fields: 'fields',
      status: 'status',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      customized: 'boolean',
      fields: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFields },
      status: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DescribeCrmPersonalCustomerObjectMetaResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DescribeCrmPersonalCustomerObjectMetaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmPersonalCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmPersonalCustomerRequest extends $tea.Model {
  currentOperatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmPersonalCustomerResponseBody extends $tea.Model {
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmPersonalCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteCrmPersonalCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbandonCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbandonCustomerRequest extends $tea.Model {
  operatorUserId?: string;
  instanceIdList?: string[];
  customTrackDesc?: string;
  optType?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      instanceIdList: 'instanceIdList',
      customTrackDesc: 'customTrackDesc',
      optType: 'optType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      instanceIdList: { 'type': 'array', 'itemType': 'string' },
      customTrackDesc: 'string',
      optType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbandonCustomerResponseBody extends $tea.Model {
  instanceIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      instanceIdList: 'instanceIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AbandonCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AbandonCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AbandonCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequest extends $tea.Model {
  detail?: SendOfficialAccountSNSMessageRequestDetail;
  bizId?: string;
  dingTokenGrantType?: number;
  dingClientId?: string;
  bindingToken?: string;
  dingUid?: number;
  dingOpenAppOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      bizId: 'bizId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingClientId: 'dingClientId',
      bindingToken: 'bindingToken',
      dingUid: 'dingUid',
      dingOpenAppOrgId: 'dingOpenAppOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: SendOfficialAccountSNSMessageRequestDetail,
      bizId: 'string',
      dingTokenGrantType: 'number',
      dingClientId: 'string',
      bindingToken: 'string',
      dingUid: 'number',
      dingOpenAppOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageResponseBody extends $tea.Model {
  requestId?: string;
  result?: SendOfficialAccountSNSMessageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: SendOfficialAccountSNSMessageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendOfficialAccountSNSMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendOfficialAccountSNSMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCrmPersonalCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCrmPersonalCustomerRequest extends $tea.Model {
  instanceId?: string;
  modifierUserId?: string;
  modifierNick?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: UpdateCrmPersonalCustomerRequestPermission;
  skipDuplicateCheck?: boolean;
  action?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      modifierUserId: 'modifierUserId',
      modifierNick: 'modifierNick',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
      skipDuplicateCheck: 'skipDuplicateCheck',
      action: 'action',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      modifierUserId: 'string',
      modifierNick: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      permission: UpdateCrmPersonalCustomerRequestPermission,
      skipDuplicateCheck: 'boolean',
      action: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCrmPersonalCustomerResponseBody extends $tea.Model {
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCrmPersonalCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateCrmPersonalCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerRequest extends $tea.Model {
  currentOperatorUserId?: string;
  relationType?: string;
  nextToken?: string;
  maxResults?: number;
  queryDsl?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      relationType: 'relationType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      queryDsl: 'queryDsl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      relationType: 'string',
      nextToken: 'string',
      maxResults: 'number',
      queryDsl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponseBody extends $tea.Model {
  values?: QueryCrmPersonalCustomerResponseBodyValues[];
  hasMore?: boolean;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      values: 'values',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      values: { 'type': 'array', 'itemType': QueryCrmPersonalCustomerResponseBodyValues },
      hasMore: 'boolean',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCrmPersonalCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersRequest extends $tea.Model {
  currentOperatorUserId?: string;
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersResponseBody extends $tea.Model {
  result?: ListCrmPersonalCustomersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListCrmPersonalCustomersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListCrmPersonalCustomersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListCrmPersonalCustomersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerRequest extends $tea.Model {
  objectType?: string;
  instanceId?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  contacts?: CreateCustomerRequestContacts[];
  permission?: CreateCustomerRequestPermission;
  saveOption?: CreateCustomerRequestSaveOption;
  static names(): { [key: string]: string } {
    return {
      objectType: 'objectType',
      instanceId: 'instanceId',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      contacts: 'contacts',
      permission: 'permission',
      saveOption: 'saveOption',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectType: 'string',
      instanceId: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      contacts: { 'type': 'array', 'itemType': CreateCustomerRequestContacts },
      permission: CreateCustomerRequestPermission,
      saveOption: CreateCustomerRequestSaveOption,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponseBody extends $tea.Model {
  customerInstanceId?: string;
  objectType?: string;
  contacts?: CreateCustomerResponseBodyContacts[];
  static names(): { [key: string]: string } {
    return {
      customerInstanceId: 'customerInstanceId',
      objectType: 'objectType',
      contacts: 'contacts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerInstanceId: 'string',
      objectType: 'string',
      contacts: { 'type': 'array', 'itemType': CreateCustomerResponseBodyContacts },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksRequest extends $tea.Model {
  nextToken?: string;
  maxResults?: number;
  order?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      maxResults: 'number',
      order: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksResponseBody extends $tea.Model {
  values?: QueryAllTracksResponseBodyValues[];
  hasMore?: boolean;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      values: 'values',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      values: { 'type': 'array', 'itemType': QueryAllTracksResponseBodyValues },
      hasMore: 'boolean',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllTracksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllTracksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBodyValuesContactsPermission extends $tea.Model {
  participantStaffIds?: string[];
  ownerStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      participantStaffIds: 'participantStaffIds',
      ownerStaffIds: 'ownerStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBodyValuesContacts extends $tea.Model {
  creatorNick?: string;
  modifyTime?: string;
  createTime?: string;
  creatorUserId?: string;
  instanceId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: GetOfficialAccountContactsResponseBodyValuesContactsPermission;
  static names(): { [key: string]: string } {
    return {
      creatorNick: 'creatorNick',
      modifyTime: 'modifyTime',
      createTime: 'createTime',
      creatorUserId: 'creatorUserId',
      instanceId: 'instanceId',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorNick: 'string',
      modifyTime: 'string',
      createTime: 'string',
      creatorUserId: 'string',
      instanceId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      permission: GetOfficialAccountContactsResponseBodyValuesContactsPermission,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBodyValues extends $tea.Model {
  userId?: string;
  contacts?: GetOfficialAccountContactsResponseBodyValuesContacts[];
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      contacts: 'contacts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      contacts: { 'type': 'array', 'itemType': GetOfficialAccountContactsResponseBodyValuesContacts },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyText extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown extends $tea.Model {
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyLink extends $tea.Model {
  picUrl?: string;
  messageUrl?: string;
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      picUrl: 'picUrl',
      messageUrl: 'messageUrl',
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      picUrl: 'string',
      messageUrl: 'string',
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  title?: string;
  actionUrl?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      actionUrl: 'actionUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      actionUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonOrientation?: string;
  singleUrl?: string;
  singleTitle?: string;
  markdown?: string;
  title?: string;
  buttonList?: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList[];
  static names(): { [key: string]: string } {
    return {
      buttonOrientation: 'buttonOrientation',
      singleUrl: 'singleUrl',
      singleTitle: 'singleTitle',
      markdown: 'markdown',
      title: 'title',
      buttonList: 'buttonList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonOrientation: 'string',
      singleUrl: 'string',
      singleTitle: 'string',
      markdown: 'string',
      title: 'string',
      buttonList: { 'type': 'array', 'itemType': ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBody extends $tea.Model {
  text?: ServiceWindowMessageBatchPushRequestDetailMessageBodyText;
  markdown?: ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown;
  link?: ServiceWindowMessageBatchPushRequestDetailMessageBodyLink;
  actionCard?: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      markdown: 'markdown',
      link: 'link',
      actionCard: 'actionCard',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: ServiceWindowMessageBatchPushRequestDetailMessageBodyText,
      markdown: ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown,
      link: ServiceWindowMessageBatchPushRequestDetailMessageBodyLink,
      actionCard: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetail extends $tea.Model {
  msgType?: string;
  uuid?: string;
  bizRequestId?: string;
  userIdList?: string[];
  messageBody?: ServiceWindowMessageBatchPushRequestDetailMessageBody;
  sendToAll?: boolean;
  static names(): { [key: string]: string } {
    return {
      msgType: 'msgType',
      uuid: 'uuid',
      bizRequestId: 'bizRequestId',
      userIdList: 'userIdList',
      messageBody: 'messageBody',
      sendToAll: 'sendToAll',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgType: 'string',
      uuid: 'string',
      bizRequestId: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      messageBody: ServiceWindowMessageBatchPushRequestDetailMessageBody,
      sendToAll: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushResponseBodyResult extends $tea.Model {
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList extends $tea.Model {
  name?: string;
  staffId?: string;
  type?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      staffId: 'staffId',
      type: 'type',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      staffId: 'string',
      type: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt extends $tea.Model {
  staffIdList?: string[];
  deptIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      staffIdList: 'staffIdList',
      deptIdList: 'deptIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffIdList: { 'type': 'array', 'itemType': 'string' },
      deptIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList extends $tea.Model {
  type?: string;
  manager?: boolean;
  ext?: GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      manager: 'manager',
      ext: 'ext',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      manager: 'boolean',
      ext: GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsOperateScopes extends $tea.Model {
  type?: string;
  hasAuth?: boolean;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      hasAuth: 'hasAuth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      hasAuth: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsFieldScopes extends $tea.Model {
  fieldId?: string;
  fieldActions?: string[];
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      fieldActions: 'fieldActions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      fieldActions: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissions extends $tea.Model {
  roleMemberList?: GetCrmRolePermissionResponseBodyPermissionsRoleMemberList[];
  managingScopeList?: GetCrmRolePermissionResponseBodyPermissionsManagingScopeList[];
  defaultRole?: boolean;
  resourceId?: string;
  roleName?: string;
  roleId?: number;
  operateScopes?: GetCrmRolePermissionResponseBodyPermissionsOperateScopes[];
  fieldScopes?: GetCrmRolePermissionResponseBodyPermissionsFieldScopes[];
  static names(): { [key: string]: string } {
    return {
      roleMemberList: 'roleMemberList',
      managingScopeList: 'managingScopeList',
      defaultRole: 'defaultRole',
      resourceId: 'resourceId',
      roleName: 'roleName',
      roleId: 'roleId',
      operateScopes: 'operateScopes',
      fieldScopes: 'fieldScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleMemberList: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsRoleMemberList },
      managingScopeList: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsManagingScopeList },
      defaultRole: 'boolean',
      resourceId: 'string',
      roleName: 'string',
      roleId: 'number',
      operateScopes: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsOperateScopes },
      fieldScopes: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsFieldScopes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends $tea.Model {
  picUrl?: string;
  messageUrl?: string;
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      picUrl: 'picUrl',
      messageUrl: 'messageUrl',
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      picUrl: 'string',
      messageUrl: 'string',
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  title?: string;
  actionUrl?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      actionUrl: 'actionUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      actionUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonOrientation?: string;
  singleUrl?: string;
  singleTitle?: string;
  markdown?: string;
  title?: string;
  buttonList?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList[];
  static names(): { [key: string]: string } {
    return {
      buttonOrientation: 'buttonOrientation',
      singleUrl: 'singleUrl',
      singleTitle: 'singleTitle',
      markdown: 'markdown',
      title: 'title',
      buttonList: 'buttonList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonOrientation: 'string',
      singleUrl: 'string',
      singleTitle: 'string',
      markdown: 'string',
      title: 'string',
      buttonList: { 'type': 'array', 'itemType': BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody extends $tea.Model {
  text?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText;
  markdown?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown;
  link?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink;
  actionCard?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      markdown: 'markdown',
      link: 'link',
      actionCard: 'actionCard',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText,
      markdown: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown,
      link: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink,
      actionCard: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetail extends $tea.Model {
  msgType?: string;
  uuid?: string;
  bizRequestId?: string;
  userIdList?: string[];
  messageBody?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBody;
  sendToAll?: boolean;
  static names(): { [key: string]: string } {
    return {
      msgType: 'msgType',
      uuid: 'uuid',
      bizRequestId: 'bizRequestId',
      userIdList: 'userIdList',
      messageBody: 'messageBody',
      sendToAll: 'sendToAll',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgType: 'string',
      uuid: 'string',
      bizRequestId: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      messageBody: BatchSendOfficialAccountOTOMessageRequestDetailMessageBody,
      sendToAll: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageResponseBodyResult extends $tea.Model {
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResultValuesPermission extends $tea.Model {
  participantStaffIds?: string[];
  ownerStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      participantStaffIds: 'participantStaffIds',
      ownerStaffIds: 'ownerStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResultValues extends $tea.Model {
  creatorNick?: string;
  modifyTime?: string;
  creatorUserId?: string;
  instanceId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  createTime?: string;
  orgId?: number;
  objectType?: string;
  permission?: QueryAllCustomerResponseBodyResultValuesPermission;
  processOutResult?: string;
  processInstanceStatus?: string;
  static names(): { [key: string]: string } {
    return {
      creatorNick: 'creatorNick',
      modifyTime: 'modifyTime',
      creatorUserId: 'creatorUserId',
      instanceId: 'instanceId',
      data: 'data',
      extendData: 'extendData',
      createTime: 'createTime',
      orgId: 'orgId',
      objectType: 'objectType',
      permission: 'permission',
      processOutResult: 'processOutResult',
      processInstanceStatus: 'processInstanceStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorNick: 'string',
      modifyTime: 'string',
      creatorUserId: 'string',
      instanceId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      createTime: 'string',
      orgId: 'number',
      objectType: 'string',
      permission: QueryAllCustomerResponseBodyResultValuesPermission,
      processOutResult: 'string',
      processInstanceStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResult extends $tea.Model {
  nextToken?: string;
  values?: QueryAllCustomerResponseBodyResultValues[];
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      values: 'values',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': QueryAllCustomerResponseBodyResultValues },
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldRequestFieldDTOListPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldRequestFieldDTOListProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  labelEditableFreeze?: boolean;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  notPrint?: string;
  content?: string;
  format?: string;
  options?: UpdateRelationMetaFieldRequestFieldDTOListPropsOptions[];
  notUpper?: string;
  unit?: string;
  placeholder?: string;
  bizAlias?: string;
  duration?: boolean;
  choice?: number;
  disabled?: boolean;
  align?: string;
  invisible?: boolean;
  payEnable?: boolean;
  link?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      notPrint: 'notPrint',
      content: 'content',
      format: 'format',
      options: 'options',
      notUpper: 'notUpper',
      unit: 'unit',
      placeholder: 'placeholder',
      bizAlias: 'bizAlias',
      duration: 'duration',
      choice: 'choice',
      disabled: 'disabled',
      align: 'align',
      invisible: 'invisible',
      payEnable: 'payEnable',
      link: 'link',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      labelEditableFreeze: 'boolean',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      notPrint: 'string',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': UpdateRelationMetaFieldRequestFieldDTOListPropsOptions },
      notUpper: 'string',
      unit: 'string',
      placeholder: 'string',
      bizAlias: 'string',
      duration: 'boolean',
      choice: 'number',
      disabled: 'boolean',
      align: 'string',
      invisible: 'boolean',
      payEnable: 'boolean',
      link: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldRequestFieldDTOList extends $tea.Model {
  componentName?: string;
  props?: UpdateRelationMetaFieldRequestFieldDTOListProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: UpdateRelationMetaFieldRequestFieldDTOListProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget extends $tea.Model {
  appType?: number;
  appUuid?: string;
  bizType?: string;
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      appUuid: 'appUuid',
      bizType: 'bizType',
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      appUuid: 'string',
      bizType: 'string',
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource extends $tea.Model {
  target?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      target: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  unit?: string;
  upper?: boolean;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      unit: 'unit',
      upper: 'upper',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      unit: 'string',
      upper: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  format?: string;
  formula?: string;
  fieldId?: string;
  invisible?: boolean;
  label?: string;
  link?: string;
  notUpper?: string;
  options?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  required?: boolean;
  statField?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField[];
  unit?: string;
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      format: 'format',
      formula: 'formula',
      fieldId: 'fieldId',
      invisible: 'invisible',
      label: 'label',
      link: 'link',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      align: 'string',
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      disabled: 'boolean',
      duration: 'boolean',
      format: 'string',
      formula: 'string',
      fieldId: 'string',
      invisible: 'boolean',
      label: 'string',
      link: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      statField: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields extends $tea.Model {
  componentName?: string;
  relateProps?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  unit?: string;
  upper?: boolean;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      unit: 'unit',
      upper: 'upper',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      unit: 'string',
      upper: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  dataSource?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource;
  disabled?: boolean;
  duration?: boolean;
  fields?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields[];
  format?: string;
  formula?: string;
  fieldId?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  notPrint?: string;
  notUpper?: string;
  options?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  statField?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField[];
  unit?: string;
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      dataSource: 'dataSource',
      disabled: 'disabled',
      duration: 'duration',
      fields: 'fields',
      format: 'format',
      formula: 'formula',
      fieldId: 'fieldId',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      align: 'string',
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      dataSource: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource,
      disabled: 'boolean',
      duration: 'boolean',
      fields: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields },
      format: 'string',
      formula: 'string',
      fieldId: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      statField: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren extends $tea.Model {
  componentName?: string;
  props?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget extends $tea.Model {
  appType?: number;
  appUuid?: string;
  bizType?: string;
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      appUuid: 'appUuid',
      bizType: 'bizType',
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'number',
      appUuid: 'string',
      bizType: 'string',
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource extends $tea.Model {
  target?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      target: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  unit?: string;
  upper?: boolean;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      unit: 'unit',
      upper: 'upper',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      unit: 'string',
      upper: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: string;
  format?: string;
  formula?: string;
  fieldId?: string;
  invisible?: boolean;
  label?: string;
  link?: string;
  notUpper?: string;
  options?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  required?: boolean;
  statField?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField[];
  unit?: string;
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      format: 'format',
      formula: 'formula',
      fieldId: 'fieldId',
      invisible: 'invisible',
      label: 'label',
      link: 'link',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      align: 'string',
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      disabled: 'boolean',
      duration: 'string',
      format: 'string',
      formula: 'string',
      fieldId: 'string',
      invisible: 'boolean',
      label: 'string',
      link: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      statField: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields extends $tea.Model {
  componentName?: string;
  relateProps?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  unit?: string;
  upper?: boolean;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      unit: 'unit',
      upper: 'upper',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      unit: 'string',
      upper: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  dataSource?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource;
  disabled?: boolean;
  duration?: boolean;
  fields?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields[];
  format?: string;
  formula?: string;
  fieldId?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  notPrint?: string;
  notUpper?: string;
  options?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  statField?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField[];
  unit?: string;
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      dataSource: 'dataSource',
      disabled: 'disabled',
      duration: 'duration',
      fields: 'fields',
      format: 'format',
      formula: 'formula',
      fieldId: 'fieldId',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      align: 'string',
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      dataSource: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource,
      disabled: 'boolean',
      duration: 'boolean',
      fields: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields },
      format: 'string',
      formula: 'string',
      fieldId: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      statField: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems extends $tea.Model {
  children?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren[];
  componentName?: string;
  props?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps[];
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren },
      componentName: 'string',
      props: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBodyRelationMetaDTO extends $tea.Model {
  desc?: string;
  items?: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems[];
  name?: string;
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      items: 'items',
      name: 'name',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      items: { 'type': 'array', 'itemType': UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems },
      name: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyText extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends $tea.Model {
  picUrl?: string;
  messageUrl?: string;
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      picUrl: 'picUrl',
      messageUrl: 'messageUrl',
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      picUrl: 'string',
      messageUrl: 'string',
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  title?: string;
  actionUrl?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      actionUrl: 'actionUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      actionUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonOrientation?: string;
  singleUrl?: string;
  singleTitle?: string;
  markdown?: string;
  title?: string;
  buttonList?: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList[];
  static names(): { [key: string]: string } {
    return {
      buttonOrientation: 'buttonOrientation',
      singleUrl: 'singleUrl',
      singleTitle: 'singleTitle',
      markdown: 'markdown',
      title: 'title',
      buttonList: 'buttonList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonOrientation: 'string',
      singleUrl: 'string',
      singleTitle: 'string',
      markdown: 'string',
      title: 'string',
      buttonList: { 'type': 'array', 'itemType': SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBody extends $tea.Model {
  text?: SendOfficialAccountOTOMessageRequestDetailMessageBodyText;
  markdown?: SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown;
  link?: SendOfficialAccountOTOMessageRequestDetailMessageBodyLink;
  actionCard?: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      markdown: 'markdown',
      link: 'link',
      actionCard: 'actionCard',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: SendOfficialAccountOTOMessageRequestDetailMessageBodyText,
      markdown: SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown,
      link: SendOfficialAccountOTOMessageRequestDetailMessageBodyLink,
      actionCard: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetail extends $tea.Model {
  msgType?: string;
  uuid?: string;
  userId?: string;
  unionId?: string;
  messageBody?: SendOfficialAccountOTOMessageRequestDetailMessageBody;
  static names(): { [key: string]: string } {
    return {
      msgType: 'msgType',
      uuid: 'uuid',
      userId: 'userId',
      unionId: 'unionId',
      messageBody: 'messageBody',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgType: 'string',
      uuid: 'string',
      userId: 'string',
      unionId: 'string',
      messageBody: SendOfficialAccountOTOMessageRequestDetailMessageBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageResponseBodyResult extends $tea.Model {
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultResponseBodyResult extends $tea.Model {
  status?: number;
  readUserIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      readUserIdList: 'readUserIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
      readUserIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  upper?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      upper: 'upper',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      upper: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  required?: boolean;
  content?: string;
  format?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions[];
  notUpper?: string;
  unit?: string;
  placeholder?: string;
  bizAlias?: string;
  duration?: string;
  choice?: number;
  disabled?: boolean;
  align?: string;
  invisible?: boolean;
  payEnable?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      required: 'required',
      content: 'content',
      format: 'format',
      options: 'options',
      notUpper: 'notUpper',
      unit: 'unit',
      placeholder: 'placeholder',
      bizAlias: 'bizAlias',
      duration: 'duration',
      choice: 'choice',
      disabled: 'disabled',
      align: 'align',
      invisible: 'invisible',
      payEnable: 'payEnable',
      statField: 'statField',
      link: 'link',
      verticalPrint: 'verticalPrint',
      formula: 'formula',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      required: 'boolean',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions },
      notUpper: 'string',
      unit: 'string',
      placeholder: 'string',
      bizAlias: 'string',
      duration: 'string',
      choice: 'number',
      disabled: 'boolean',
      align: 'string',
      invisible: 'boolean',
      payEnable: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields extends $tea.Model {
  componentName?: string;
  relateProps?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget extends $tea.Model {
  appUuid?: string;
  appType?: number;
  bizType?: string;
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      appType: 'appType',
      bizType: 'bizType',
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      appType: 'number',
      bizType: 'string',
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource extends $tea.Model {
  type?: string;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      target: 'target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  upper?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      upper: 'upper',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      upper: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  labelEditableFreeze?: boolean;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  notPrint?: string;
  content?: string;
  format?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions[];
  notUpper?: string;
  unit?: string;
  placeholder?: string;
  bizAlias?: string;
  duration?: boolean;
  choice?: number;
  disabled?: boolean;
  align?: string;
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields[];
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource;
  invisible?: boolean;
  payEnable?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      notPrint: 'notPrint',
      content: 'content',
      format: 'format',
      options: 'options',
      notUpper: 'notUpper',
      unit: 'unit',
      placeholder: 'placeholder',
      bizAlias: 'bizAlias',
      duration: 'duration',
      choice: 'choice',
      disabled: 'disabled',
      align: 'align',
      fields: 'fields',
      dataSource: 'dataSource',
      invisible: 'invisible',
      payEnable: 'payEnable',
      statField: 'statField',
      link: 'link',
      verticalPrint: 'verticalPrint',
      formula: 'formula',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      labelEditableFreeze: 'boolean',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      notPrint: 'string',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions },
      notUpper: 'string',
      unit: 'string',
      placeholder: 'string',
      bizAlias: 'string',
      duration: 'boolean',
      choice: 'number',
      disabled: 'boolean',
      align: 'string',
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields },
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource,
      invisible: 'boolean',
      payEnable: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  upper?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      upper: 'upper',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      upper: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  required?: boolean;
  content?: string;
  format?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions[];
  notUpper?: string;
  unit?: string;
  placeholder?: string;
  bizAlias?: string;
  duration?: boolean;
  choice?: number;
  disabled?: boolean;
  align?: string;
  invisible?: boolean;
  payEnable?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      required: 'required',
      content: 'content',
      format: 'format',
      options: 'options',
      notUpper: 'notUpper',
      unit: 'unit',
      placeholder: 'placeholder',
      bizAlias: 'bizAlias',
      duration: 'duration',
      choice: 'choice',
      disabled: 'disabled',
      align: 'align',
      invisible: 'invisible',
      payEnable: 'payEnable',
      statField: 'statField',
      link: 'link',
      verticalPrint: 'verticalPrint',
      formula: 'formula',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      required: 'boolean',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions },
      notUpper: 'string',
      unit: 'string',
      placeholder: 'string',
      bizAlias: 'string',
      duration: 'boolean',
      choice: 'number',
      disabled: 'boolean',
      align: 'string',
      invisible: 'boolean',
      payEnable: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields extends $tea.Model {
  componentName?: string;
  relateProps?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget extends $tea.Model {
  appUuid?: string;
  appType?: number;
  bizType?: string;
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      appType: 'appType',
      bizType: 'bizType',
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      appType: 'number',
      bizType: 'string',
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource extends $tea.Model {
  type?: string;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      target: 'target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField extends $tea.Model {
  fieldId?: string;
  label?: string;
  upper?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      upper: 'upper',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      upper: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  labelEditableFreeze?: boolean;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  notPrint?: string;
  content?: string;
  format?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions[];
  notUpper?: string;
  unit?: string;
  placeholder?: string;
  bizAlias?: string;
  duration?: boolean;
  choice?: number;
  disabled?: boolean;
  align?: string;
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields[];
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource;
  invisible?: boolean;
  payEnable?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      notPrint: 'notPrint',
      content: 'content',
      format: 'format',
      options: 'options',
      notUpper: 'notUpper',
      unit: 'unit',
      placeholder: 'placeholder',
      bizAlias: 'bizAlias',
      duration: 'duration',
      choice: 'choice',
      disabled: 'disabled',
      align: 'align',
      fields: 'fields',
      dataSource: 'dataSource',
      invisible: 'invisible',
      payEnable: 'payEnable',
      statField: 'statField',
      link: 'link',
      verticalPrint: 'verticalPrint',
      formula: 'formula',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      labelEditableFreeze: 'boolean',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      notPrint: 'string',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions },
      notUpper: 'string',
      unit: 'string',
      placeholder: 'string',
      bizAlias: 'string',
      duration: 'boolean',
      choice: 'number',
      disabled: 'boolean',
      align: 'string',
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields },
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource,
      invisible: 'boolean',
      payEnable: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren extends $tea.Model {
  componentName?: string;
  props?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItems extends $tea.Model {
  componentName?: string;
  props?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps[];
  children?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren[];
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
      children: 'children',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps },
      children: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOList extends $tea.Model {
  relationType?: string;
  name?: string;
  desc?: string;
  items?: DescribeRelationMetaResponseBodyRelationMetaDTOListItems[];
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
      name: 'name',
      desc: 'desc',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
      name: 'string',
      desc: 'string',
      items: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCrmPersonalCustomerRequestPermission extends $tea.Model {
  ownerStaffIds?: string[];
  participantStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerStaffIds: 'ownerStaffIds',
      participantStaffIds: 'participantStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields extends $tea.Model {
  label?: string;
  type?: string;
  nillable?: boolean;
  unit?: string;
  format?: string;
  selectOptions?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions[];
  name?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      type: 'type',
      nillable: 'nillable',
      unit: 'unit',
      format: 'format',
      selectOptions: 'selectOptions',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      type: 'string',
      nillable: 'boolean',
      unit: 'string',
      format: 'string',
      selectOptions: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions },
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields extends $tea.Model {
  name?: string;
  aggregator?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      aggregator: 'aggregator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      aggregator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFields extends $tea.Model {
  name?: string;
  customized?: boolean;
  label?: string;
  type?: string;
  nillable?: boolean;
  format?: string;
  unit?: string;
  selectOptions?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions[];
  quote?: boolean;
  referenceTo?: string;
  referenceFields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields[];
  rollUpSummaryFields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields[];
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      customized: 'customized',
      label: 'label',
      type: 'type',
      nillable: 'nillable',
      format: 'format',
      unit: 'unit',
      selectOptions: 'selectOptions',
      quote: 'quote',
      referenceTo: 'referenceTo',
      referenceFields: 'referenceFields',
      rollUpSummaryFields: 'rollUpSummaryFields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      customized: 'boolean',
      label: 'string',
      type: 'string',
      nillable: 'boolean',
      format: 'string',
      unit: 'string',
      selectOptions: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions },
      quote: 'boolean',
      referenceTo: 'string',
      referenceFields: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields },
      rollUpSummaryFields: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyText extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyLink extends $tea.Model {
  picUrl?: string;
  messageUrl?: string;
  title?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      picUrl: 'picUrl',
      messageUrl: 'messageUrl',
      title: 'title',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      picUrl: 'string',
      messageUrl: 'string',
      title: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  title?: string;
  actionUrl?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      actionUrl: 'actionUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      actionUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonOrientation?: string;
  singleUrl?: string;
  singleTitle?: string;
  markdown?: string;
  title?: string;
  buttonList?: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList[];
  static names(): { [key: string]: string } {
    return {
      buttonOrientation: 'buttonOrientation',
      singleUrl: 'singleUrl',
      singleTitle: 'singleTitle',
      markdown: 'markdown',
      title: 'title',
      buttonList: 'buttonList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonOrientation: 'string',
      singleUrl: 'string',
      singleTitle: 'string',
      markdown: 'string',
      title: 'string',
      buttonList: { 'type': 'array', 'itemType': SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBody extends $tea.Model {
  text?: SendOfficialAccountSNSMessageRequestDetailMessageBodyText;
  markdown?: SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown;
  link?: SendOfficialAccountSNSMessageRequestDetailMessageBodyLink;
  actionCard?: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      markdown: 'markdown',
      link: 'link',
      actionCard: 'actionCard',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: SendOfficialAccountSNSMessageRequestDetailMessageBodyText,
      markdown: SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown,
      link: SendOfficialAccountSNSMessageRequestDetailMessageBodyLink,
      actionCard: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetail extends $tea.Model {
  msgType?: string;
  uuid?: string;
  messageBody?: SendOfficialAccountSNSMessageRequestDetailMessageBody;
  static names(): { [key: string]: string } {
    return {
      msgType: 'msgType',
      uuid: 'uuid',
      messageBody: 'messageBody',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgType: 'string',
      uuid: 'string',
      messageBody: SendOfficialAccountSNSMessageRequestDetailMessageBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageResponseBodyResult extends $tea.Model {
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCrmPersonalCustomerRequestPermission extends $tea.Model {
  ownerStaffIds?: string[];
  participantStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerStaffIds: 'ownerStaffIds',
      participantStaffIds: 'participantStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponseBodyValuesPermission extends $tea.Model {
  ownerStaffIds?: string[];
  participantStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerStaffIds: 'ownerStaffIds',
      participantStaffIds: 'participantStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponseBodyValues extends $tea.Model {
  instanceId?: string;
  objectType?: string;
  creatorUserId?: string;
  creatorNick?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: QueryCrmPersonalCustomerResponseBodyValuesPermission;
  procOutResult?: string;
  procInstStatus?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      objectType: 'objectType',
      creatorUserId: 'creatorUserId',
      creatorNick: 'creatorNick',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
      procOutResult: 'procOutResult',
      procInstStatus: 'procInstStatus',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      objectType: 'string',
      creatorUserId: 'string',
      creatorNick: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      permission: QueryCrmPersonalCustomerResponseBodyValuesPermission,
      procOutResult: 'string',
      procInstStatus: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersResponseBodyResultPermission extends $tea.Model {
  ownerStaffIds?: string[];
  participantStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerStaffIds: 'ownerStaffIds',
      participantStaffIds: 'participantStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersResponseBodyResult extends $tea.Model {
  orgId?: number;
  instanceId?: string;
  objectType?: string;
  creatorUserId?: string;
  creatorNick?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: ListCrmPersonalCustomersResponseBodyResultPermission;
  appUuid?: string;
  formCode?: string;
  procOutResult?: string;
  procInstStatus?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      orgId: 'orgId',
      instanceId: 'instanceId',
      objectType: 'objectType',
      creatorUserId: 'creatorUserId',
      creatorNick: 'creatorNick',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
      appUuid: 'appUuid',
      formCode: 'formCode',
      procOutResult: 'procOutResult',
      procInstStatus: 'procInstStatus',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgId: 'number',
      instanceId: 'string',
      objectType: 'string',
      creatorUserId: 'string',
      creatorNick: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      permission: ListCrmPersonalCustomersResponseBodyResultPermission,
      appUuid: 'string',
      formCode: 'string',
      procOutResult: 'string',
      procInstStatus: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerRequestContacts extends $tea.Model {
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      extendData: 'extendData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerRequestPermission extends $tea.Model {
  ownerStaffIds?: string[];
  participantStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerStaffIds: 'ownerStaffIds',
      participantStaffIds: 'participantStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerRequestSaveOption extends $tea.Model {
  subscribePolicy?: number;
  throwExceptionWhileSavingContactFailed?: boolean;
  customerExistedPolicy?: string;
  skipDuplicateCheck?: boolean;
  static names(): { [key: string]: string } {
    return {
      subscribePolicy: 'subscribePolicy',
      throwExceptionWhileSavingContactFailed: 'throwExceptionWhileSavingContactFailed',
      customerExistedPolicy: 'customerExistedPolicy',
      skipDuplicateCheck: 'skipDuplicateCheck',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subscribePolicy: 'number',
      throwExceptionWhileSavingContactFailed: 'boolean',
      customerExistedPolicy: 'string',
      skipDuplicateCheck: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponseBodyContacts extends $tea.Model {
  contactInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      contactInstanceId: 'contactInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksResponseBodyValues extends $tea.Model {
  corpId?: string;
  customerId?: string;
  type?: number;
  subType?: number;
  gmtCreate?: number;
  creator?: string;
  bizId?: string;
  id?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      customerId: 'customerId',
      type: 'type',
      subType: 'subType',
      gmtCreate: 'gmtCreate',
      creator: 'creator',
      bizId: 'bizId',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      customerId: 'string',
      type: 'number',
      subType: 'number',
      gmtCreate: 'number',
      creator: 'string',
      bizId: 'string',
      id: 'string',
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


  async getOfficialAccountContacts(request: GetOfficialAccountContactsRequest): Promise<GetOfficialAccountContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountContactsHeaders({ });
    return await this.getOfficialAccountContactsWithOptions(request, headers, runtime);
  }

  async getOfficialAccountContactsWithOptions(request: GetOfficialAccountContactsRequest, headers: GetOfficialAccountContactsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountContactsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<GetOfficialAccountContactsResponse>(await this.doROARequest("GetOfficialAccountContacts", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/officialAccounts/contacts`, "json", req, runtime), new GetOfficialAccountContactsResponse({}));
  }

  async serviceWindowMessageBatchPush(request: ServiceWindowMessageBatchPushRequest): Promise<ServiceWindowMessageBatchPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ServiceWindowMessageBatchPushHeaders({ });
    return await this.serviceWindowMessageBatchPushWithOptions(request, headers, runtime);
  }

  async serviceWindowMessageBatchPushWithOptions(request: ServiceWindowMessageBatchPushRequest, headers: ServiceWindowMessageBatchPushHeaders, runtime: $Util.RuntimeOptions): Promise<ServiceWindowMessageBatchPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.detail))) {
      body["detail"] = request.detail;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<ServiceWindowMessageBatchPushResponse>(await this.doROARequest("ServiceWindowMessageBatchPush", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/messages/batchSend`, "json", req, runtime), new ServiceWindowMessageBatchPushResponse({}));
  }

  async deleteCrmFormInstance(instanceId: string, request: DeleteCrmFormInstanceRequest): Promise<DeleteCrmFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmFormInstanceHeaders({ });
    return await this.deleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
  }

  async deleteCrmFormInstanceWithOptions(instanceId: string, request: DeleteCrmFormInstanceRequest, headers: DeleteCrmFormInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCrmFormInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
    }

    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
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
    return $tea.cast<DeleteCrmFormInstanceResponse>(await this.doROARequest("DeleteCrmFormInstance", "crm_1.0", "HTTP", "DELETE", "AK", `/v1.0/crm/formInstances/${instanceId}`, "json", req, runtime), new DeleteCrmFormInstanceResponse({}));
  }

  async getCrmRolePermission(request: GetCrmRolePermissionRequest): Promise<GetCrmRolePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmRolePermissionHeaders({ });
    return await this.getCrmRolePermissionWithOptions(request, headers, runtime);
  }

  async getCrmRolePermissionWithOptions(request: GetCrmRolePermissionRequest, headers: GetCrmRolePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmRolePermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
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
    return $tea.cast<GetCrmRolePermissionResponse>(await this.doROARequest("GetCrmRolePermission", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/permissions`, "json", req, runtime), new GetCrmRolePermissionResponse({}));
  }

  async batchSendOfficialAccountOTOMessage(request: BatchSendOfficialAccountOTOMessageRequest): Promise<BatchSendOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendOfficialAccountOTOMessageHeaders({ });
    return await this.batchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  async batchSendOfficialAccountOTOMessageWithOptions(request: BatchSendOfficialAccountOTOMessageRequest, headers: BatchSendOfficialAccountOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSendOfficialAccountOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.detail))) {
      body["detail"] = request.detail;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<BatchSendOfficialAccountOTOMessageResponse>(await this.doROARequest("BatchSendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/officialAccounts/oToMessages/batchSend`, "json", req, runtime), new BatchSendOfficialAccountOTOMessageResponse({}));
  }

  async getOfficialAccountContactInfo(userId: string): Promise<GetOfficialAccountContactInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountContactInfoHeaders({ });
    return await this.getOfficialAccountContactInfoWithOptions(userId, headers, runtime);
  }

  async getOfficialAccountContactInfoWithOptions(userId: string, headers: GetOfficialAccountContactInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountContactInfoResponse> {
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
    return $tea.cast<GetOfficialAccountContactInfoResponse>(await this.doROARequest("GetOfficialAccountContactInfo", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/officialAccounts/contacts/${userId}`, "json", req, runtime), new GetOfficialAccountContactInfoResponse({}));
  }

  async queryAllCustomer(request: QueryAllCustomerRequest): Promise<QueryAllCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllCustomerHeaders({ });
    return await this.queryAllCustomerWithOptions(request, headers, runtime);
  }

  async queryAllCustomerWithOptions(request: QueryAllCustomerRequest, headers: QueryAllCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
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
    return $tea.cast<QueryAllCustomerResponse>(await this.doROARequest("QueryAllCustomer", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/customerInstances`, "json", req, runtime), new QueryAllCustomerResponse({}));
  }

  async updateRelationMetaField(request: UpdateRelationMetaFieldRequest): Promise<UpdateRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRelationMetaFieldHeaders({ });
    return await this.updateRelationMetaFieldWithOptions(request, headers, runtime);
  }

  async updateRelationMetaFieldWithOptions(request: UpdateRelationMetaFieldRequest, headers: UpdateRelationMetaFieldHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRelationMetaFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.fieldDTOList)) {
      body["fieldDTOList"] = request.fieldDTOList;
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
    return $tea.cast<UpdateRelationMetaFieldResponse>(await this.doROARequest("UpdateRelationMetaField", "crm_1.0", "HTTP", "PUT", "AK", `/v1.0/crm/relations/metas/fields`, "json", req, runtime), new UpdateRelationMetaFieldResponse({}));
  }

  async sendOfficialAccountOTOMessage(request: SendOfficialAccountOTOMessageRequest): Promise<SendOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOfficialAccountOTOMessageHeaders({ });
    return await this.sendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  async sendOfficialAccountOTOMessageWithOptions(request: SendOfficialAccountOTOMessageRequest, headers: SendOfficialAccountOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendOfficialAccountOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.detail))) {
      body["detail"] = request.detail;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
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
    return $tea.cast<SendOfficialAccountOTOMessageResponse>(await this.doROARequest("SendOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/officialAccounts/oToMessages/send`, "json", req, runtime), new SendOfficialAccountOTOMessageResponse({}));
  }

  async getOfficialAccountOTOMessageResult(request: GetOfficialAccountOTOMessageResultRequest): Promise<GetOfficialAccountOTOMessageResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountOTOMessageResultHeaders({ });
    return await this.getOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
  }

  async getOfficialAccountOTOMessageResultWithOptions(request: GetOfficialAccountOTOMessageResultRequest, headers: GetOfficialAccountOTOMessageResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountOTOMessageResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openPushId)) {
      query["openPushId"] = request.openPushId;
    }

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
    return $tea.cast<GetOfficialAccountOTOMessageResultResponse>(await this.doROARequest("GetOfficialAccountOTOMessageResult", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/officialAccounts/oToMessages/sendResults`, "json", req, runtime), new GetOfficialAccountOTOMessageResultResponse({}));
  }

  async describeRelationMeta(request: DescribeRelationMetaRequest): Promise<DescribeRelationMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeRelationMetaHeaders({ });
    return await this.describeRelationMetaWithOptions(request, headers, runtime);
  }

  async describeRelationMetaWithOptions(request: DescribeRelationMetaRequest, headers: DescribeRelationMetaHeaders, runtime: $Util.RuntimeOptions): Promise<DescribeRelationMetaResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationTypes)) {
      body["relationTypes"] = request.relationTypes;
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
    return $tea.cast<DescribeRelationMetaResponse>(await this.doROARequest("DescribeRelationMeta", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/relations/metas/query`, "json", req, runtime), new DescribeRelationMetaResponse({}));
  }

  async addCrmPersonalCustomer(request: AddCrmPersonalCustomerRequest): Promise<AddCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCrmPersonalCustomerHeaders({ });
    return await this.addCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  async addCrmPersonalCustomerWithOptions(request: AddCrmPersonalCustomerRequest, headers: AddCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<AddCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUserId)) {
      body["creatorUserId"] = request.creatorUserId;
    }

    if (!Util.isUnset(request.creatorNick)) {
      body["creatorNick"] = request.creatorNick;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset($tea.toMap(request.permission))) {
      body["permission"] = request.permission;
    }

    if (!Util.isUnset(request.skipDuplicateCheck)) {
      body["skipDuplicateCheck"] = request.skipDuplicateCheck;
    }

    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
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
    return $tea.cast<AddCrmPersonalCustomerResponse>(await this.doROARequest("AddCrmPersonalCustomer", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/personalCustomers`, "json", req, runtime), new AddCrmPersonalCustomerResponse({}));
  }

  async recallOfficialAccountOTOMessage(request: RecallOfficialAccountOTOMessageRequest): Promise<RecallOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallOfficialAccountOTOMessageHeaders({ });
    return await this.recallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  async recallOfficialAccountOTOMessageWithOptions(request: RecallOfficialAccountOTOMessageRequest, headers: RecallOfficialAccountOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<RecallOfficialAccountOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.openPushId)) {
      body["openPushId"] = request.openPushId;
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
    return $tea.cast<RecallOfficialAccountOTOMessageResponse>(await this.doROARequest("RecallOfficialAccountOTOMessage", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/officialAccounts/oToMessages/recall`, "json", req, runtime), new RecallOfficialAccountOTOMessageResponse({}));
  }

  async describeCrmPersonalCustomerObjectMeta(): Promise<DescribeCrmPersonalCustomerObjectMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeCrmPersonalCustomerObjectMetaHeaders({ });
    return await this.describeCrmPersonalCustomerObjectMetaWithOptions(headers, runtime);
  }

  async describeCrmPersonalCustomerObjectMetaWithOptions(headers: DescribeCrmPersonalCustomerObjectMetaHeaders, runtime: $Util.RuntimeOptions): Promise<DescribeCrmPersonalCustomerObjectMetaResponse> {
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
    return $tea.cast<DescribeCrmPersonalCustomerObjectMetaResponse>(await this.doROARequest("DescribeCrmPersonalCustomerObjectMeta", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/personalCustomers/objectMeta`, "json", req, runtime), new DescribeCrmPersonalCustomerObjectMetaResponse({}));
  }

  async deleteCrmPersonalCustomer(dataId: string, request: DeleteCrmPersonalCustomerRequest): Promise<DeleteCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmPersonalCustomerHeaders({ });
    return await this.deleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
  }

  async deleteCrmPersonalCustomerWithOptions(dataId: string, request: DeleteCrmPersonalCustomerRequest, headers: DeleteCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
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
    return $tea.cast<DeleteCrmPersonalCustomerResponse>(await this.doROARequest("DeleteCrmPersonalCustomer", "crm_1.0", "HTTP", "DELETE", "AK", `/v1.0/crm/personalCustomers/${dataId}`, "json", req, runtime), new DeleteCrmPersonalCustomerResponse({}));
  }

  async abandonCustomer(request: AbandonCustomerRequest): Promise<AbandonCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AbandonCustomerHeaders({ });
    return await this.abandonCustomerWithOptions(request, headers, runtime);
  }

  async abandonCustomerWithOptions(request: AbandonCustomerRequest, headers: AbandonCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<AbandonCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.instanceIdList)) {
      body["instanceIdList"] = request.instanceIdList;
    }

    if (!Util.isUnset(request.customTrackDesc)) {
      body["customTrackDesc"] = request.customTrackDesc;
    }

    if (!Util.isUnset(request.optType)) {
      body["optType"] = request.optType;
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
    return $tea.cast<AbandonCustomerResponse>(await this.doROARequest("AbandonCustomer", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/customers/abandon`, "json", req, runtime), new AbandonCustomerResponse({}));
  }

  async sendOfficialAccountSNSMessage(request: SendOfficialAccountSNSMessageRequest): Promise<SendOfficialAccountSNSMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOfficialAccountSNSMessageHeaders({ });
    return await this.sendOfficialAccountSNSMessageWithOptions(request, headers, runtime);
  }

  async sendOfficialAccountSNSMessageWithOptions(request: SendOfficialAccountSNSMessageRequest, headers: SendOfficialAccountSNSMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendOfficialAccountSNSMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.detail))) {
      body["detail"] = request.detail;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.bindingToken)) {
      body["bindingToken"] = request.bindingToken;
    }

    if (!Util.isUnset(request.dingUid)) {
      body["dingUid"] = request.dingUid;
    }

    if (!Util.isUnset(request.dingOpenAppOrgId)) {
      body["dingOpenAppOrgId"] = request.dingOpenAppOrgId;
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
    return $tea.cast<SendOfficialAccountSNSMessageResponse>(await this.doROARequest("SendOfficialAccountSNSMessage", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/officialAccounts/snsMessages/send`, "json", req, runtime), new SendOfficialAccountSNSMessageResponse({}));
  }

  async updateCrmPersonalCustomer(request: UpdateCrmPersonalCustomerRequest): Promise<UpdateCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCrmPersonalCustomerHeaders({ });
    return await this.updateCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  async updateCrmPersonalCustomerWithOptions(request: UpdateCrmPersonalCustomerRequest, headers: UpdateCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.modifierUserId)) {
      body["modifierUserId"] = request.modifierUserId;
    }

    if (!Util.isUnset(request.modifierNick)) {
      body["modifierNick"] = request.modifierNick;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset($tea.toMap(request.permission))) {
      body["permission"] = request.permission;
    }

    if (!Util.isUnset(request.skipDuplicateCheck)) {
      body["skipDuplicateCheck"] = request.skipDuplicateCheck;
    }

    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
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
    return $tea.cast<UpdateCrmPersonalCustomerResponse>(await this.doROARequest("UpdateCrmPersonalCustomer", "crm_1.0", "HTTP", "PUT", "AK", `/v1.0/crm/personalCustomers`, "json", req, runtime), new UpdateCrmPersonalCustomerResponse({}));
  }

  async queryCrmPersonalCustomer(request: QueryCrmPersonalCustomerRequest): Promise<QueryCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmPersonalCustomerHeaders({ });
    return await this.queryCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  async queryCrmPersonalCustomerWithOptions(request: QueryCrmPersonalCustomerRequest, headers: QueryCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      query["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.queryDsl)) {
      query["queryDsl"] = request.queryDsl;
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
    return $tea.cast<QueryCrmPersonalCustomerResponse>(await this.doROARequest("QueryCrmPersonalCustomer", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/personalCustomers`, "json", req, runtime), new QueryCrmPersonalCustomerResponse({}));
  }

  async listCrmPersonalCustomers(request: ListCrmPersonalCustomersRequest): Promise<ListCrmPersonalCustomersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCrmPersonalCustomersHeaders({ });
    return await this.listCrmPersonalCustomersWithOptions(request, headers, runtime);
  }

  async listCrmPersonalCustomersWithOptions(request: ListCrmPersonalCustomersRequest, headers: ListCrmPersonalCustomersHeaders, runtime: $Util.RuntimeOptions): Promise<ListCrmPersonalCustomersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
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
      body: request.body,
    });
    return $tea.cast<ListCrmPersonalCustomersResponse>(await this.doROARequest("ListCrmPersonalCustomers", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/personalCustomers/batchQuery`, "json", req, runtime), new ListCrmPersonalCustomersResponse({}));
  }

  async createCustomer(request: CreateCustomerRequest): Promise<CreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomerHeaders({ });
    return await this.createCustomerWithOptions(request, headers, runtime);
  }

  async createCustomerWithOptions(request: CreateCustomerRequest, headers: CreateCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.creatorUserId)) {
      body["creatorUserId"] = request.creatorUserId;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.contacts)) {
      body["contacts"] = request.contacts;
    }

    if (!Util.isUnset($tea.toMap(request.permission))) {
      body["permission"] = request.permission;
    }

    if (!Util.isUnset($tea.toMap(request.saveOption))) {
      body["saveOption"] = request.saveOption;
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
    return $tea.cast<CreateCustomerResponse>(await this.doROARequest("CreateCustomer", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/customers`, "json", req, runtime), new CreateCustomerResponse({}));
  }

  async queryAllTracks(request: QueryAllTracksRequest): Promise<QueryAllTracksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllTracksHeaders({ });
    return await this.queryAllTracksWithOptions(request, headers, runtime);
  }

  async queryAllTracksWithOptions(request: QueryAllTracksRequest, headers: QueryAllTracksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllTracksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.order)) {
      query["order"] = request.order;
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
    return $tea.cast<QueryAllTracksResponse>(await this.doROARequest("QueryAllTracks", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/customers/tracks`, "json", req, runtime), new QueryAllTracksResponse({}));
  }

}
