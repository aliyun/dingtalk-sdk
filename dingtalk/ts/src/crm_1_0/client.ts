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

export class QueryCrmGroupChatsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupChatsRequest extends $tea.Model {
  relationType?: string;
  nextToken?: string;
  maxResults?: number;
  queryDsl?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      queryDsl: 'queryDsl',
    };
  }

  static types(): { [key: string]: any } {
    return {
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

export class QueryCrmGroupChatsResponseBody extends $tea.Model {
  resultList?: QueryCrmGroupChatsResponseBodyResultList[];
  hasMore?: boolean;
  nextToken?: string;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      resultList: 'resultList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultList: { 'type': 'array', 'itemType': QueryCrmGroupChatsResponseBodyResultList },
      hasMore: 'boolean',
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupChatsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCrmGroupChatsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCrmGroupChatsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupSetRequest extends $tea.Model {
  openGroupSetId?: string;
  static names(): { [key: string]: string } {
    return {
      openGroupSetId: 'openGroupSetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openGroupSetId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupSetResponseBody extends $tea.Model {
  name?: string;
  openGroupSetId?: string;
  relationType?: string;
  memberQuota?: number;
  corpId?: string;
  memberCount?: number;
  templateId?: string;
  ownerUserId?: string;
  managerUserIds?: string;
  notice?: string;
  noticeToped?: number;
  owner?: GetGroupSetResponseBodyOwner;
  manager?: GetGroupSetResponseBodyManager[];
  lastOpenConversationId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      openGroupSetId: 'openGroupSetId',
      relationType: 'relationType',
      memberQuota: 'memberQuota',
      corpId: 'corpId',
      memberCount: 'memberCount',
      templateId: 'templateId',
      ownerUserId: 'ownerUserId',
      managerUserIds: 'managerUserIds',
      notice: 'notice',
      noticeToped: 'noticeToped',
      owner: 'owner',
      manager: 'manager',
      lastOpenConversationId: 'lastOpenConversationId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      openGroupSetId: 'string',
      relationType: 'string',
      memberQuota: 'number',
      corpId: 'string',
      memberCount: 'number',
      templateId: 'string',
      ownerUserId: 'string',
      managerUserIds: 'string',
      notice: 'string',
      noticeToped: 'number',
      owner: GetGroupSetResponseBodyOwner,
      manager: { 'type': 'array', 'itemType': GetGroupSetResponseBodyManager },
      lastOpenConversationId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetGroupSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaRequest extends $tea.Model {
  tenant?: string;
  operatorUserId?: string;
  relationMetaDTO?: CreateRelationMetaRequestRelationMetaDTO;
  static names(): { [key: string]: string } {
    return {
      tenant: 'tenant',
      operatorUserId: 'operatorUserId',
      relationMetaDTO: 'relationMetaDTO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenant: 'string',
      operatorUserId: 'string',
      relationMetaDTO: CreateRelationMetaRequestRelationMetaDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaResponseBody extends $tea.Model {
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateRelationMetaResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateRelationMetaResponseBody,
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
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
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

export class ListGroupSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupSetRequest extends $tea.Model {
  nextToken?: string;
  maxResults?: number;
  queryDsl?: string;
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      queryDsl: 'queryDsl',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      maxResults: 'number',
      queryDsl: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupSetResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  resultList?: ListGroupSetResponseBodyResultList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      resultList: 'resultList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      resultList: { 'type': 'array', 'itemType': ListGroupSetResponseBodyResultList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListGroupSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListGroupSetResponseBody,
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

export class GetCrmGroupChatHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatResponseBody extends $tea.Model {
  chatId?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  ownerUserId?: string;
  ownerUserName?: string;
  name?: string;
  memberCount?: number;
  gmtCreate?: number;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      ownerUserName: 'ownerUserName',
      name: 'name',
      memberCount: 'memberCount',
      gmtCreate: 'gmtCreate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      ownerUserName: 'string',
      name: 'string',
      memberCount: 'number',
      gmtCreate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCrmGroupChatResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCrmGroupChatResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRelationDatasByTargetIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRelationDatasByTargetIdRequest extends $tea.Model {
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRelationDatasByTargetIdResponseBody extends $tea.Model {
  relations?: QueryRelationDatasByTargetIdResponseBodyRelations[];
  static names(): { [key: string]: string } {
    return {
      relations: 'relations',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relations: { 'type': 'array', 'itemType': QueryRelationDatasByTargetIdResponseBodyRelations },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRelationDatasByTargetIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryRelationDatasByTargetIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryRelationDatasByTargetIdResponseBody,
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
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      values: 'values',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      values: { 'type': 'array', 'itemType': QueryCrmPersonalCustomerResponseBodyValues },
      hasMore: 'boolean',
      nextToken: 'string',
      maxResults: 'number',
      totalCount: 'number',
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

export class JoinGroupSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class JoinGroupSetRequest extends $tea.Model {
  bizDataList?: JoinGroupSetRequestBizDataList[];
  unionId?: string;
  openGroupSetId?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      unionId: 'unionId',
      openGroupSetId: 'openGroupSetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': JoinGroupSetRequestBizDataList },
      unionId: 'string',
      openGroupSetId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class JoinGroupSetResponseBody extends $tea.Model {
  success?: boolean;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class JoinGroupSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: JoinGroupSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: JoinGroupSetResponseBody,
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

export class DeleteRelationMetaFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRelationMetaFieldRequest extends $tea.Model {
  tenant?: string;
  operatorUserId?: string;
  relationType?: string;
  fieldIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      tenant: 'tenant',
      operatorUserId: 'operatorUserId',
      relationType: 'relationType',
      fieldIdList: 'fieldIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenant: 'string',
      operatorUserId: 'string',
      relationType: 'string',
      fieldIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRelationMetaFieldResponseBody extends $tea.Model {
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRelationMetaFieldResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteRelationMetaFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteRelationMetaFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetRequest extends $tea.Model {
  name?: string;
  ownerUserId?: string;
  creatorUserId?: string;
  templateId?: string;
  memberQuota?: number;
  managerUserIds?: string;
  notice?: string;
  noticeToped?: number;
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      ownerUserId: 'ownerUserId',
      creatorUserId: 'creatorUserId',
      templateId: 'templateId',
      memberQuota: 'memberQuota',
      managerUserIds: 'managerUserIds',
      notice: 'notice',
      noticeToped: 'noticeToped',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      ownerUserId: 'string',
      creatorUserId: 'string',
      templateId: 'string',
      memberQuota: 'number',
      managerUserIds: 'string',
      notice: 'string',
      noticeToped: 'number',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetResponseBody extends $tea.Model {
  name?: string;
  openGroupSetId?: string;
  relationType?: string;
  memberQuota?: number;
  corpId?: string;
  memberCount?: number;
  templateId?: string;
  ownerUserId?: string;
  managerUserIds?: string;
  notice?: string;
  noticeToped?: number;
  owner?: CreateGroupSetResponseBodyOwner;
  manager?: CreateGroupSetResponseBodyManager[];
  lastOpenConversationId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      openGroupSetId: 'openGroupSetId',
      relationType: 'relationType',
      memberQuota: 'memberQuota',
      corpId: 'corpId',
      memberCount: 'memberCount',
      templateId: 'templateId',
      ownerUserId: 'ownerUserId',
      managerUserIds: 'managerUserIds',
      notice: 'notice',
      noticeToped: 'noticeToped',
      owner: 'owner',
      manager: 'manager',
      lastOpenConversationId: 'lastOpenConversationId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      openGroupSetId: 'string',
      relationType: 'string',
      memberQuota: 'number',
      corpId: 'string',
      memberCount: 'number',
      templateId: 'string',
      ownerUserId: 'string',
      managerUserIds: 'string',
      notice: 'string',
      noticeToped: 'number',
      owner: CreateGroupSetResponseBodyOwner,
      manager: { 'type': 'array', 'itemType': CreateGroupSetResponseBodyManager },
      lastOpenConversationId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateGroupSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRelationMetaFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRelationMetaFieldRequest extends $tea.Model {
  tenant?: string;
  operatorUserId?: string;
  relationType?: string;
  fieldDTOList?: AddRelationMetaFieldRequestFieldDTOList[];
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
      fieldDTOList: { 'type': 'array', 'itemType': AddRelationMetaFieldRequestFieldDTOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRelationMetaFieldResponseBody extends $tea.Model {
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRelationMetaFieldResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddRelationMetaFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddRelationMetaFieldResponseBody,
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
  relationType?: string;
  skipDuplicateCheck?: boolean;
  action?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      creatorNick: 'creatorNick',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
      relationType: 'relationType',
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
      relationType: 'string',
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

export class UpdateGroupSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSetRequest extends $tea.Model {
  openGroupSetId?: string;
  name?: string;
  memberQuota?: number;
  ownerUserId?: string;
  managerUserIds?: string;
  notice?: string;
  noticeToped?: number;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      openGroupSetId: 'openGroupSetId',
      name: 'name',
      memberQuota: 'memberQuota',
      ownerUserId: 'ownerUserId',
      managerUserIds: 'managerUserIds',
      notice: 'notice',
      noticeToped: 'noticeToped',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openGroupSetId: 'string',
      name: 'string',
      memberQuota: 'number',
      ownerUserId: 'string',
      managerUserIds: 'string',
      notice: 'string',
      noticeToped: 'number',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSetResponse extends $tea.Model {
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

export class QueryCrmGroupChatsResponseBodyResultList extends $tea.Model {
  chatId?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  ownerUserId?: string;
  ownerUserName?: string;
  name?: string;
  memberCount?: number;
  gmtCreate?: number;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      ownerUserName: 'ownerUserName',
      name: 'name',
      memberCount: 'memberCount',
      gmtCreate: 'gmtCreate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      ownerUserName: 'string',
      name: 'string',
      memberCount: 'number',
      gmtCreate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupSetResponseBodyOwner extends $tea.Model {
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

export class GetGroupSetResponseBodyManager extends $tea.Model {
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

export class CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions extends $tea.Model {
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

export class CreateRelationMetaRequestRelationMetaDTOItemsProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  sortable?: boolean;
  needDetail?: string;
  labelEditableFreeze?: boolean;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  notPrint?: string;
  content?: string;
  format?: string;
  options?: CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions[];
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
      sortable: 'sortable',
      needDetail: 'needDetail',
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
      sortable: 'boolean',
      needDetail: 'string',
      labelEditableFreeze: 'boolean',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      notPrint: 'string',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions },
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

export class CreateRelationMetaRequestRelationMetaDTOItems extends $tea.Model {
  componentName?: string;
  props?: CreateRelationMetaRequestRelationMetaDTOItemsProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: CreateRelationMetaRequestRelationMetaDTOItemsProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaRequestRelationMetaDTO extends $tea.Model {
  relationType?: string;
  name?: string;
  desc?: string;
  items?: CreateRelationMetaRequestRelationMetaDTOItems[];
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
      items: { 'type': 'array', 'itemType': CreateRelationMetaRequestRelationMetaDTOItems },
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
  sortable?: boolean;
  needDetail?: string;
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
      sortable: 'sortable',
      needDetail: 'needDetail',
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
      sortable: 'boolean',
      needDetail: 'string',
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

export class ListGroupSetResponseBodyResultListOwner extends $tea.Model {
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

export class ListGroupSetResponseBodyResultListManager extends $tea.Model {
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

export class ListGroupSetResponseBodyResultList extends $tea.Model {
  name?: string;
  openGroupSetId?: string;
  relationType?: string;
  memberQuota?: number;
  corpId?: string;
  memberCount?: number;
  templateId?: string;
  ownerUserId?: string;
  managerUserIds?: string;
  notice?: string;
  noticeToped?: number;
  owner?: ListGroupSetResponseBodyResultListOwner;
  manager?: ListGroupSetResponseBodyResultListManager[];
  lastOpenConversationId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      openGroupSetId: 'openGroupSetId',
      relationType: 'relationType',
      memberQuota: 'memberQuota',
      corpId: 'corpId',
      memberCount: 'memberCount',
      templateId: 'templateId',
      ownerUserId: 'ownerUserId',
      managerUserIds: 'managerUserIds',
      notice: 'notice',
      noticeToped: 'noticeToped',
      owner: 'owner',
      manager: 'manager',
      lastOpenConversationId: 'lastOpenConversationId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      openGroupSetId: 'string',
      relationType: 'string',
      memberQuota: 'number',
      corpId: 'string',
      memberCount: 'number',
      templateId: 'string',
      ownerUserId: 'string',
      managerUserIds: 'string',
      notice: 'string',
      noticeToped: 'number',
      owner: ListGroupSetResponseBodyResultListOwner,
      manager: { 'type': 'array', 'itemType': ListGroupSetResponseBodyResultListManager },
      lastOpenConversationId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
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

export class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList extends $tea.Model {
  key?: string;
  value?: string;
  extendValue?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
      extendValue: 'extendValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
      extendValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRelationDatasByTargetIdResponseBodyRelations extends $tea.Model {
  relationId?: string;
  relationType?: string;
  bizDataList?: QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList[];
  static names(): { [key: string]: string } {
    return {
      relationId: 'relationId',
      relationType: 'relationType',
      bizDataList: 'bizDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationId: 'string',
      relationType: 'string',
      bizDataList: { 'type': 'array', 'itemType': QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList },
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

export class JoinGroupSetRequestBizDataList extends $tea.Model {
  extendValue?: string;
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extendValue: 'extendValue',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendValue: 'string',
      key: 'string',
      value: 'string',
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

export class CreateGroupSetResponseBodyOwner extends $tea.Model {
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

export class CreateGroupSetResponseBodyManager extends $tea.Model {
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

export class AddRelationMetaFieldRequestFieldDTOListPropsOptions extends $tea.Model {
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

export class AddRelationMetaFieldRequestFieldDTOListProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  sortable?: boolean;
  labelEditableFreeze?: boolean;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  notPrint?: string;
  content?: string;
  format?: string;
  options?: AddRelationMetaFieldRequestFieldDTOListPropsOptions[];
  notUpper?: string;
  unit?: string;
  needDetail?: string;
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
      sortable: 'sortable',
      labelEditableFreeze: 'labelEditableFreeze',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      notPrint: 'notPrint',
      content: 'content',
      format: 'format',
      options: 'options',
      notUpper: 'notUpper',
      unit: 'unit',
      needDetail: 'needDetail',
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
      sortable: 'boolean',
      labelEditableFreeze: 'boolean',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      notPrint: 'string',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': AddRelationMetaFieldRequestFieldDTOListPropsOptions },
      notUpper: 'string',
      unit: 'string',
      needDetail: 'string',
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

export class AddRelationMetaFieldRequestFieldDTOList extends $tea.Model {
  componentName?: string;
  props?: AddRelationMetaFieldRequestFieldDTOListProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: AddRelationMetaFieldRequestFieldDTOListProps,
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extends $tea.Model {
  editFreeze?: boolean;
  static names(): { [key: string]: string } {
    return {
      editFreeze: 'editFreeze',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editFreeze: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  warn?: boolean;
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
      warn: 'warn',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
      warn: 'boolean',
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extends $tea.Model {
  editFreeze?: boolean;
  static names(): { [key: string]: string } {
    return {
      editFreeze: 'editFreeze',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editFreeze: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  labelEditableFreeze?: boolean;
  content?: string;
  format?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions[];
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
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  quote?: number;
  multi?: number;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      labelEditableFreeze: 'labelEditableFreeze',
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
      quote: 'quote',
      multi: 'multi',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      labelEditableFreeze: 'boolean',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions },
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
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
      quote: 'number',
      multi: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields extends $tea.Model {
  componentName?: string;
  relateProps?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters extends $tea.Model {
  valueType?: string;
  filterType?: string;
  value?: string;
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      valueType: 'valueType',
      filterType: 'filterType',
      value: 'value',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      valueType: 'string',
      filterType: 'string',
      value: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams extends $tea.Model {
  filters?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource extends $tea.Model {
  type?: string;
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      params: 'params',
      target: 'target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams,
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource extends $tea.Model {
  bizType?: string;
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields[];
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      fields: 'fields',
      dataSource: 'dataSource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields },
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extends $tea.Model {
  editFreeze?: boolean;
  static names(): { [key: string]: string } {
    return {
      editFreeze: 'editFreeze',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editFreeze: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension,
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
  requiredEditableFreeze?: boolean;
  labelEditableFreeze?: boolean;
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
  watermark?: boolean;
  limit?: number;
  spread?: boolean;
  ratio?: number;
  durationLabel?: string;
  mode?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      labelEditableFreeze: 'labelEditableFreeze',
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
      watermark: 'watermark',
      limit: 'limit',
      spread: 'spread',
      ratio: 'ratio',
      durationLabel: 'durationLabel',
      mode: 'mode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      labelEditableFreeze: 'boolean',
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
      watermark: 'boolean',
      limit: 'number',
      spread: 'boolean',
      ratio: 'number',
      durationLabel: 'string',
      mode: 'string',
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters extends $tea.Model {
  valueType?: string;
  filterType?: string;
  value?: string;
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      valueType: 'valueType',
      filterType: 'filterType',
      value: 'value',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      valueType: 'string',
      filterType: 'string',
      value: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams extends $tea.Model {
  filters?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters },
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
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      params: 'params',
      target: 'target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams,
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  sortable?: boolean;
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
  relateSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource[];
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields[];
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource;
  invisible?: boolean;
  payEnable?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  needDetail?: string;
  quote?: number;
  multi?: number;
  rule?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule[];
  tableViewMode?: string;
  actionName?: string;
  watermark?: boolean;
  limit?: number;
  spread?: boolean;
  ratio?: number;
  durationLabel?: string;
  mode?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      sortable: 'sortable',
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
      relateSource: 'relateSource',
      fields: 'fields',
      dataSource: 'dataSource',
      invisible: 'invisible',
      payEnable: 'payEnable',
      statField: 'statField',
      link: 'link',
      verticalPrint: 'verticalPrint',
      formula: 'formula',
      needDetail: 'needDetail',
      quote: 'quote',
      multi: 'multi',
      rule: 'rule',
      tableViewMode: 'tableViewMode',
      actionName: 'actionName',
      watermark: 'watermark',
      limit: 'limit',
      spread: 'spread',
      ratio: 'ratio',
      durationLabel: 'durationLabel',
      mode: 'mode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      sortable: 'boolean',
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
      relateSource: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource },
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields },
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource,
      invisible: 'boolean',
      payEnable: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
      needDetail: 'string',
      quote: 'number',
      multi: 'number',
      rule: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule },
      tableViewMode: 'string',
      actionName: 'string',
      watermark: 'boolean',
      limit: 'number',
      spread: 'boolean',
      ratio: 'number',
      durationLabel: 'string',
      mode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extends $tea.Model {
  editFreeze?: boolean;
  static names(): { [key: string]: string } {
    return {
      editFreeze: 'editFreeze',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editFreeze: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  labelEditableFreeze?: boolean;
  content?: string;
  format?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions[];
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
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  quote?: number;
  multi?: number;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      labelEditableFreeze: 'labelEditableFreeze',
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
      quote: 'quote',
      multi: 'multi',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      labelEditableFreeze: 'boolean',
      content: 'string',
      format: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions },
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
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
      quote: 'number',
      multi: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields extends $tea.Model {
  componentName?: string;
  relateProps?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters extends $tea.Model {
  valueType?: string;
  filterType?: string;
  value?: string;
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      valueType: 'valueType',
      filterType: 'filterType',
      value: 'value',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      valueType: 'string',
      filterType: 'string',
      value: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams extends $tea.Model {
  filters?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource extends $tea.Model {
  type?: string;
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      params: 'params',
      target: 'target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams,
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource extends $tea.Model {
  bizType?: string;
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields[];
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      fields: 'fields',
      dataSource: 'dataSource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields },
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extends $tea.Model {
  editFreeze?: boolean;
  static names(): { [key: string]: string } {
    return {
      editFreeze: 'editFreeze',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editFreeze: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions extends $tea.Model {
  key?: string;
  value?: string;
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension,
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
  requiredEditableFreeze?: boolean;
  labelEditableFreeze?: boolean;
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
  watermark?: boolean;
  limit?: number;
  spread?: boolean;
  ratio?: number;
  durationLabel?: string;
  mode?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      labelEditableFreeze: 'labelEditableFreeze',
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
      watermark: 'watermark',
      limit: 'limit',
      spread: 'spread',
      ratio: 'ratio',
      durationLabel: 'durationLabel',
      mode: 'mode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      labelEditableFreeze: 'boolean',
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
      watermark: 'boolean',
      limit: 'number',
      spread: 'boolean',
      ratio: 'number',
      durationLabel: 'string',
      mode: 'string',
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters extends $tea.Model {
  valueType?: string;
  filterType?: string;
  value?: string;
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      valueType: 'valueType',
      filterType: 'filterType',
      value: 'value',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      valueType: 'string',
      filterType: 'string',
      value: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams extends $tea.Model {
  filters?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters },
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
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      params: 'params',
      target: 'target',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams,
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps extends $tea.Model {
  fieldId?: string;
  label?: string;
  sortable?: boolean;
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
  relateSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource[];
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields[];
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource;
  invisible?: boolean;
  payEnable?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField[];
  link?: string;
  verticalPrint?: boolean;
  formula?: string;
  quote?: number;
  rule?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule[];
  tableViewMode?: string;
  actionName?: string;
  watermark?: boolean;
  limit?: number;
  spread?: boolean;
  ratio?: number;
  durationLabel?: string;
  mode?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      label: 'label',
      sortable: 'sortable',
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
      relateSource: 'relateSource',
      fields: 'fields',
      dataSource: 'dataSource',
      invisible: 'invisible',
      payEnable: 'payEnable',
      statField: 'statField',
      link: 'link',
      verticalPrint: 'verticalPrint',
      formula: 'formula',
      quote: 'quote',
      rule: 'rule',
      tableViewMode: 'tableViewMode',
      actionName: 'actionName',
      watermark: 'watermark',
      limit: 'limit',
      spread: 'spread',
      ratio: 'ratio',
      durationLabel: 'durationLabel',
      mode: 'mode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      label: 'string',
      sortable: 'boolean',
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
      relateSource: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource },
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields },
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource,
      invisible: 'boolean',
      payEnable: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField },
      link: 'string',
      verticalPrint: 'boolean',
      formula: 'string',
      quote: 'number',
      rule: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule },
      tableViewMode: 'string',
      actionName: 'string',
      watermark: 'boolean',
      limit: 'number',
      spread: 'boolean',
      ratio: 'number',
      durationLabel: 'string',
      mode: 'string',
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
  props?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps;
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
      props: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps,
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
  relationMetaCode?: string;
  relationMetaStatus?: string;
  creatorUserId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  items?: DescribeRelationMetaResponseBodyRelationMetaDTOListItems[];
  static names(): { [key: string]: string } {
    return {
      relationType: 'relationType',
      name: 'name',
      desc: 'desc',
      relationMetaCode: 'relationMetaCode',
      relationMetaStatus: 'relationMetaStatus',
      creatorUserId: 'creatorUserId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationType: 'string',
      name: 'string',
      desc: 'string',
      relationMetaCode: 'string',
      relationMetaStatus: 'string',
      creatorUserId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
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

  async queryCrmGroupChats(request: QueryCrmGroupChatsRequest): Promise<QueryCrmGroupChatsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmGroupChatsHeaders({ });
    return await this.queryCrmGroupChatsWithOptions(request, headers, runtime);
  }

  async queryCrmGroupChatsWithOptions(request: QueryCrmGroupChatsRequest, headers: QueryCrmGroupChatsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCrmGroupChatsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<QueryCrmGroupChatsResponse>(await this.doROARequest("QueryCrmGroupChats", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/crmGroupChats`, "json", req, runtime), new QueryCrmGroupChatsResponse({}));
  }

  async getGroupSet(request: GetGroupSetRequest): Promise<GetGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupSetHeaders({ });
    return await this.getGroupSetWithOptions(request, headers, runtime);
  }

  async getGroupSetWithOptions(request: GetGroupSetRequest, headers: GetGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<GetGroupSetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openGroupSetId)) {
      query["openGroupSetId"] = request.openGroupSetId;
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
    return $tea.cast<GetGroupSetResponse>(await this.doROARequest("GetGroupSet", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/groupSets`, "json", req, runtime), new GetGroupSetResponse({}));
  }

  async createRelationMeta(request: CreateRelationMetaRequest): Promise<CreateRelationMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRelationMetaHeaders({ });
    return await this.createRelationMetaWithOptions(request, headers, runtime);
  }

  async createRelationMetaWithOptions(request: CreateRelationMetaRequest, headers: CreateRelationMetaHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRelationMetaResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset($tea.toMap(request.relationMetaDTO))) {
      body["relationMetaDTO"] = request.relationMetaDTO;
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
    return $tea.cast<CreateRelationMetaResponse>(await this.doROARequest("CreateRelationMeta", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/relations/metas/create`, "json", req, runtime), new CreateRelationMetaResponse({}));
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

  async listGroupSet(request: ListGroupSetRequest): Promise<ListGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListGroupSetHeaders({ });
    return await this.listGroupSetWithOptions(request, headers, runtime);
  }

  async listGroupSetWithOptions(request: ListGroupSetRequest, headers: ListGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<ListGroupSetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.queryDsl)) {
      query["queryDsl"] = request.queryDsl;
    }

    if (!Util.isUnset(request.relationType)) {
      query["relationType"] = request.relationType;
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
    return $tea.cast<ListGroupSetResponse>(await this.doROARequest("ListGroupSet", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/groupSets/lists`, "json", req, runtime), new ListGroupSetResponse({}));
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

  async getCrmGroupChat(openConversationId: string): Promise<GetCrmGroupChatResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatHeaders({ });
    return await this.getCrmGroupChatWithOptions(openConversationId, headers, runtime);
  }

  async getCrmGroupChatWithOptions(openConversationId: string, headers: GetCrmGroupChatHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmGroupChatResponse> {
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
    return $tea.cast<GetCrmGroupChatResponse>(await this.doROARequest("GetCrmGroupChat", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/crmGroupChats/${openConversationId}`, "json", req, runtime), new GetCrmGroupChatResponse({}));
  }

  async queryRelationDatasByTargetId(targetId: string, request: QueryRelationDatasByTargetIdRequest): Promise<QueryRelationDatasByTargetIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRelationDatasByTargetIdHeaders({ });
    return await this.queryRelationDatasByTargetIdWithOptions(targetId, request, headers, runtime);
  }

  async queryRelationDatasByTargetIdWithOptions(targetId: string, request: QueryRelationDatasByTargetIdRequest, headers: QueryRelationDatasByTargetIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRelationDatasByTargetIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.relationType)) {
      query["relationType"] = request.relationType;
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
    return $tea.cast<QueryRelationDatasByTargetIdResponse>(await this.doROARequest("QueryRelationDatasByTargetId", "crm_1.0", "HTTP", "GET", "AK", `/v1.0/crm/relations/datas/targets/${targetId}`, "json", req, runtime), new QueryRelationDatasByTargetIdResponse({}));
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

  async joinGroupSet(request: JoinGroupSetRequest): Promise<JoinGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new JoinGroupSetHeaders({ });
    return await this.joinGroupSetWithOptions(request, headers, runtime);
  }

  async joinGroupSetWithOptions(request: JoinGroupSetRequest, headers: JoinGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<JoinGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizDataList)) {
      body["bizDataList"] = request.bizDataList;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
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
    return $tea.cast<JoinGroupSetResponse>(await this.doROARequest("JoinGroupSet", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/groupSets/join`, "json", req, runtime), new JoinGroupSetResponse({}));
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

  async deleteRelationMetaField(request: DeleteRelationMetaFieldRequest): Promise<DeleteRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRelationMetaFieldHeaders({ });
    return await this.deleteRelationMetaFieldWithOptions(request, headers, runtime);
  }

  async deleteRelationMetaFieldWithOptions(request: DeleteRelationMetaFieldRequest, headers: DeleteRelationMetaFieldHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRelationMetaFieldResponse> {
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

    if (!Util.isUnset(request.fieldIdList)) {
      body["fieldIdList"] = request.fieldIdList;
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
    return $tea.cast<DeleteRelationMetaFieldResponse>(await this.doROARequest("DeleteRelationMetaField", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/relations/metas/fields/remove`, "json", req, runtime), new DeleteRelationMetaFieldResponse({}));
  }

  async createGroupSet(request: CreateGroupSetRequest): Promise<CreateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupSetHeaders({ });
    return await this.createGroupSetWithOptions(request, headers, runtime);
  }

  async createGroupSetWithOptions(request: CreateGroupSetRequest, headers: CreateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.creatorUserId)) {
      body["creatorUserId"] = request.creatorUserId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.memberQuota)) {
      body["memberQuota"] = request.memberQuota;
    }

    if (!Util.isUnset(request.managerUserIds)) {
      body["managerUserIds"] = request.managerUserIds;
    }

    if (!Util.isUnset(request.notice)) {
      body["notice"] = request.notice;
    }

    if (!Util.isUnset(request.noticeToped)) {
      body["noticeToped"] = request.noticeToped;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
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
    return $tea.cast<CreateGroupSetResponse>(await this.doROARequest("CreateGroupSet", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/groupSets`, "json", req, runtime), new CreateGroupSetResponse({}));
  }

  async addRelationMetaField(request: AddRelationMetaFieldRequest): Promise<AddRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRelationMetaFieldHeaders({ });
    return await this.addRelationMetaFieldWithOptions(request, headers, runtime);
  }

  async addRelationMetaFieldWithOptions(request: AddRelationMetaFieldRequest, headers: AddRelationMetaFieldHeaders, runtime: $Util.RuntimeOptions): Promise<AddRelationMetaFieldResponse> {
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
    return $tea.cast<AddRelationMetaFieldResponse>(await this.doROARequest("AddRelationMetaField", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/relations/metas/fields`, "json", req, runtime), new AddRelationMetaFieldResponse({}));
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

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
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

  async updateGroupSet(request: UpdateGroupSetRequest): Promise<UpdateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupSetHeaders({ });
    return await this.updateGroupSetWithOptions(request, headers, runtime);
  }

  async updateGroupSetWithOptions(request: UpdateGroupSetRequest, headers: UpdateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.memberQuota)) {
      body["memberQuota"] = request.memberQuota;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.managerUserIds)) {
      body["managerUserIds"] = request.managerUserIds;
    }

    if (!Util.isUnset(request.notice)) {
      body["notice"] = request.notice;
    }

    if (!Util.isUnset(request.noticeToped)) {
      body["noticeToped"] = request.noticeToped;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
    return $tea.cast<UpdateGroupSetResponse>(await this.doROARequest("UpdateGroupSet", "crm_1.0", "HTTP", "PUT", "AK", `/v1.0/crm/groupSets/set`, "boolean", req, runtime), new UpdateGroupSetResponse({}));
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
