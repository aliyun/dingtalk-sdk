// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      bizId: 'bizId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
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
      detail: BatchSendOfficialAccountOTOMessageRequestDetail,
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
  static names(): { [key: string]: string } {
    return {
      corpName: 'corpName',
      mobile: 'mobile',
      stateCode: 'stateCode',
      unionId: 'unionId',
      authItems: 'authItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpName: 'string',
      mobile: 'string',
      stateCode: 'string',
      unionId: 'string',
      authItems: { 'type': 'array', 'itemType': 'string' },
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
  messageBody?: SendOfficialAccountOTOMessageRequestDetailMessageBody;
  static names(): { [key: string]: string } {
    return {
      msgType: 'msgType',
      uuid: 'uuid',
      userId: 'userId',
      messageBody: 'messageBody',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgType: 'string',
      uuid: 'string',
      userId: 'string',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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

}
