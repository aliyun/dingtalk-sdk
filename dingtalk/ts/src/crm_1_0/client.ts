// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  customTrackDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  instanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123123123
   */
  operatorUserId?: string;
  optType?: string;
  static names(): { [key: string]: string } {
    return {
      customTrackDesc: 'customTrackDesc',
      instanceIdList: 'instanceIdList',
      operatorUserId: 'operatorUserId',
      optType: 'optType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customTrackDesc: 'string',
      instanceIdList: { 'type': 'array', 'itemType': 'string' },
      operatorUserId: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AbandonCustomerResponseBody;
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
      body: AbandonCustomerResponseBody,
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
  /**
   * @example
   * publicDraw
   */
  action?: string;
  creatorNick?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: AddCrmPersonalCustomerRequestPermission;
  /**
   * @example
   * crm_customer_personal
   */
  relationType?: string;
  /**
   * @example
   * false
   */
  skipDuplicateCheck?: boolean;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      creatorNick: 'creatorNick',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      permission: 'permission',
      relationType: 'relationType',
      skipDuplicateCheck: 'skipDuplicateCheck',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      creatorNick: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      permission: AddCrmPersonalCustomerRequestPermission,
      relationType: 'string',
      skipDuplicateCheck: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCrmPersonalCustomerResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddCrmPersonalCustomerResponseBody;
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
      body: AddCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomerTrackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomerTrackRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * [华佗](http://******)创建了合同：**今日合同**
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fb037d68-c1bd-4be2-8c3b-6739261d1332
   */
  customerId?: string;
  /**
   * @example
   * {"bizId":"1"}
   * 
   * **if can be null:**
   * true
   */
  extraBizInfo?: string;
  /**
   * @example
   * fb037d68-c1bd-4be2-8c3b-6739261d1332-1
   * 
   * **if can be null:**
   * true
   */
  idempotentKey?: string;
  /**
   * @example
   * [华佗](http://******)创建了合同：**今日合同**
   */
  maskedContent?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager1120
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
  relationType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 创建合同
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 212
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      customerId: 'customerId',
      extraBizInfo: 'extraBizInfo',
      idempotentKey: 'idempotentKey',
      maskedContent: 'maskedContent',
      operatorUserId: 'operatorUserId',
      relationType: 'relationType',
      title: 'title',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      customerId: 'string',
      extraBizInfo: 'string',
      idempotentKey: 'string',
      maskedContent: 'string',
      operatorUserId: 'string',
      relationType: 'string',
      title: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomerTrackResponseBody extends $tea.Model {
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

export class AddCustomerTrackResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddCustomerTrackResponseBody;
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
      body: AddCustomerTrackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeadsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeadsRequest extends $tea.Model {
  /**
   * @example
   * 1669360918000
   */
  assignTimestamp?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager1234
   */
  assignUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager1234
   */
  assignedUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  leads?: AddLeadsRequestLeads[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * t123123123
   */
  outTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      assignTimestamp: 'assignTimestamp',
      assignUserId: 'assignUserId',
      assignedUserId: 'assignedUserId',
      leads: 'leads',
      outTaskId: 'outTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assignTimestamp: 'number',
      assignUserId: 'string',
      assignedUserId: 'string',
      leads: { 'type': 'array', 'itemType': AddLeadsRequestLeads },
      outTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeadsResponseBody extends $tea.Model {
  outTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      outTaskId: 'outTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeadsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddLeadsResponseBody;
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
      body: AddLeadsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMetaModelFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMetaModelFieldRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldDTOList?: AddMetaModelFieldRequestFieldDTOList[];
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      fieldDTOList: 'fieldDTOList',
      operatorUserId: 'operatorUserId',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      fieldDTOList: { 'type': 'array', 'itemType': AddMetaModelFieldRequestFieldDTOList },
      operatorUserId: 'string',
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMetaModelFieldResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMetaModelFieldResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddMetaModelFieldResponseBody;
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
      body: AddMetaModelFieldResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  fieldDTOList?: AddRelationMetaFieldRequestFieldDTOList[];
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      fieldDTOList: 'fieldDTOList',
      operatorUserId: 'operatorUserId',
      relationType: 'relationType',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldDTOList: { 'type': 'array', 'itemType': AddRelationMetaFieldRequestFieldDTOList },
      operatorUserId: 'string',
      relationType: 'string',
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRelationMetaFieldResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddRelationMetaFieldResponseBody;
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
      body: AddRelationMetaFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendCustomerDataAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendCustomerDataAuthRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  customerIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  dataAuthUserIds?: string[];
  /**
   * @example
   * PROC-98187D45-EFC0-4FC4-887E-45BD24209D69
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId2
   */
  operateUserId?: string;
  /**
   * @example
   * crm_customer
   */
  relationType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * owner
   */
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      customerIds: 'customerIds',
      dataAuthUserIds: 'dataAuthUserIds',
      formCode: 'formCode',
      operateUserId: 'operateUserId',
      relationType: 'relationType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerIds: { 'type': 'array', 'itemType': 'string' },
      dataAuthUserIds: { 'type': 'array', 'itemType': 'string' },
      formCode: 'string',
      operateUserId: 'string',
      relationType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendCustomerDataAuthResponseBody extends $tea.Model {
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

export class AppendCustomerDataAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AppendCustomerDataAuthResponseBody;
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
      body: AppendCustomerDataAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddContactsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddContactsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationList?: BatchAddContactsRequestRelationList[];
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      relationList: 'relationList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      relationList: { 'type': 'array', 'itemType': BatchAddContactsRequestRelationList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddContactsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchAddContactsResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchAddContactsResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddContactsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchAddContactsResponseBody;
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
      body: BatchAddContactsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  instanceList?: BatchAddFollowRecordsRequestInstanceList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceList: 'instanceList',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceList: { 'type': 'array', 'itemType': BatchAddFollowRecordsRequestInstanceList },
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchAddFollowRecordsResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchAddFollowRecordsResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchAddFollowRecordsResponseBody;
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
      body: BatchAddFollowRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationList?: BatchAddRelationDatasRequestRelationList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
  relationType?: string;
  /**
   * @example
   * false
   */
  skipDuplicateCheck?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      relationList: 'relationList',
      relationType: 'relationType',
      skipDuplicateCheck: 'skipDuplicateCheck',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      relationList: { 'type': 'array', 'itemType': BatchAddRelationDatasRequestRelationList },
      relationType: 'string',
      skipDuplicateCheck: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchAddRelationDatasResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchAddRelationDatasResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchAddRelationDatasResponseBody;
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
      body: BatchAddRelationDatasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataRequest extends $tea.Model {
  dataList?: BatchCreateClueDataRequestDataList[];
  privateSeas?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * d124
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      privateSeas: 'privateSeas',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': BatchCreateClueDataRequestDataList },
      privateSeas: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataResponseBody extends $tea.Model {
  requestId?: string;
  result?: BatchCreateClueDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: { 'type': 'array', 'itemType': BatchCreateClueDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchCreateClueDataResponseBody;
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
      body: BatchCreateClueDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemoveFollowRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemoveFollowRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  instanceIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceIds: 'instanceIds',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceIds: { 'type': 'array', 'itemType': 'string' },
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemoveFollowRecordsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchRemoveFollowRecordsResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchRemoveFollowRecordsResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemoveFollowRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchRemoveFollowRecordsResponseBody;
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
      body: BatchRemoveFollowRecordsResponseBody,
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
  accountId?: string;
  /**
   * **if can be null:**
   * true
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: BatchSendOfficialAccountOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      bizId: 'bizId',
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      bizId: 'string',
      detail: BatchSendOfficialAccountOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageResponseBody extends $tea.Model {
  /**
   * @example
   * acs1234
   */
  requestId?: string;
  result?: BatchSendOfficialAccountOTOMessageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: BatchSendOfficialAccountOTOMessageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchSendOfficialAccountOTOMessageResponseBody;
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
      body: BatchSendOfficialAccountOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateContactsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateContactsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationList?: BatchUpdateContactsRequestRelationList[];
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      relationList: 'relationList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      relationList: { 'type': 'array', 'itemType': BatchUpdateContactsRequestRelationList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateContactsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchUpdateContactsResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchUpdateContactsResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateContactsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateContactsResponseBody;
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
      body: BatchUpdateContactsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFollowRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFollowRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  instanceList?: BatchUpdateFollowRecordsRequestInstanceList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceList: 'instanceList',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceList: { 'type': 'array', 'itemType': BatchUpdateFollowRecordsRequestInstanceList },
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFollowRecordsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchUpdateFollowRecordsResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchUpdateFollowRecordsResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFollowRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateFollowRecordsResponseBody;
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
      body: BatchUpdateFollowRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateRelationDatasHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateRelationDatasRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager021a
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationList?: BatchUpdateRelationDatasRequestRelationList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
  relationType?: string;
  /**
   * @example
   * false
   */
  skipDuplicateCheck?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      relationList: 'relationList',
      relationType: 'relationType',
      skipDuplicateCheck: 'skipDuplicateCheck',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      relationList: { 'type': 'array', 'itemType': BatchUpdateRelationDatasRequestRelationList },
      relationType: 'string',
      skipDuplicateCheck: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateRelationDatasResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  results?: BatchUpdateRelationDatasResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': BatchUpdateRelationDatasResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateRelationDatasResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateRelationDatasResponseBody;
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
      body: BatchUpdateRelationDatasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeBenefitInventoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeBenefitInventoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B_ACCOUNT_NUMBER
   */
  benefitCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * bizId
   */
  bizRequestId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  consumeQuota?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * optStaffId
   */
  optUserId?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      bizRequestId: 'bizRequestId',
      consumeQuota: 'consumeQuota',
      optUserId: 'optUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      bizRequestId: 'string',
      consumeQuota: 'number',
      optUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeBenefitInventoryResponseBody extends $tea.Model {
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

export class ConsumeBenefitInventoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConsumeBenefitInventoryResponseBody;
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
      body: ConsumeBenefitInventoryResponseBody,
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
  contacts?: CreateCustomerRequestContacts[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager123
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  /**
   * @example
   * xxxx-xxxx-xxxx-xxxx
   * 
   * **if can be null:**
   * true
   */
  instanceId?: string;
  /**
   * @example
   * crm_customer
   * 
   * **if can be null:**
   * true
   */
  objectType?: string;
  permission?: CreateCustomerRequestPermission;
  /**
   * @remarks
   * This parameter is required.
   */
  saveOption?: CreateCustomerRequestSaveOption;
  static names(): { [key: string]: string } {
    return {
      contacts: 'contacts',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      instanceId: 'instanceId',
      objectType: 'objectType',
      permission: 'permission',
      saveOption: 'saveOption',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contacts: { 'type': 'array', 'itemType': CreateCustomerRequestContacts },
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      instanceId: 'string',
      objectType: 'string',
      permission: CreateCustomerRequestPermission,
      saveOption: CreateCustomerRequestSaveOption,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponseBody extends $tea.Model {
  contacts?: CreateCustomerResponseBodyContacts[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * customer_id
   */
  customerInstanceId?: string;
  /**
   * @example
   * crm_customer
   */
  objectType?: string;
  static names(): { [key: string]: string } {
    return {
      contacts: 'contacts',
      customerInstanceId: 'customerInstanceId',
      objectType: 'objectType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contacts: { 'type': 'array', 'itemType': CreateCustomerResponseBodyContacts },
      customerInstanceId: 'string',
      objectType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCustomerResponseBody;
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
      body: CreateCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  groupName?: string;
  /**
   * @example
   * a,b,c
   */
  memberUserIds?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  ownerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      memberUserIds: 'memberUserIds',
      ownerUserId: 'ownerUserId',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      memberUserIds: 'string',
      ownerUserId: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class CreateGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateGroupResponseBody;
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
      body: CreateGroupResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUserId?: string;
  managerUserIds?: string;
  memberQuota?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  notice?: string;
  noticeToped?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  ownerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationType?: string;
  templateId?: string;
  welcome?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      managerUserIds: 'managerUserIds',
      memberQuota: 'memberQuota',
      name: 'name',
      notice: 'notice',
      noticeToped: 'noticeToped',
      ownerUserId: 'ownerUserId',
      relationType: 'relationType',
      templateId: 'templateId',
      welcome: 'welcome',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      managerUserIds: 'string',
      memberQuota: 'number',
      name: 'string',
      notice: 'string',
      noticeToped: 'number',
      ownerUserId: 'string',
      relationType: 'string',
      templateId: 'string',
      welcome: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetResponseBody extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  inviteLink?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  lastOpenConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  manager?: CreateGroupSetResponseBodyManager[];
  managerUserIds?: string;
  memberCount?: number;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  owner?: CreateGroupSetResponseBodyOwner;
  ownerUserId?: string;
  relationType?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      inviteLink: 'inviteLink',
      lastOpenConversationId: 'lastOpenConversationId',
      manager: 'manager',
      managerUserIds: 'managerUserIds',
      memberCount: 'memberCount',
      memberQuota: 'memberQuota',
      name: 'name',
      notice: 'notice',
      noticeToped: 'noticeToped',
      openGroupSetId: 'openGroupSetId',
      owner: 'owner',
      ownerUserId: 'ownerUserId',
      relationType: 'relationType',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      inviteLink: 'string',
      lastOpenConversationId: 'string',
      manager: { 'type': 'array', 'itemType': CreateGroupSetResponseBodyManager },
      managerUserIds: 'string',
      memberCount: 'number',
      memberQuota: 'number',
      name: 'string',
      notice: 'string',
      noticeToped: 'number',
      openGroupSetId: 'string',
      owner: CreateGroupSetResponseBodyOwner,
      ownerUserId: 'string',
      relationType: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateGroupSetResponseBody;
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
      body: CreateGroupSetResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationMetaDTO?: CreateRelationMetaRequestRelationMetaDTO;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      relationMetaDTO: 'relationMetaDTO',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      relationMetaDTO: CreateRelationMetaRequestRelationMetaDTO,
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateRelationMetaResponseBody;
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
      body: CreateRelationMetaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmCustomObjectDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmCustomObjectDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC_xx
   */
  formCode?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmCustomObjectDataResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INST_xx
   */
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

export class DeleteCrmCustomObjectDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteCrmCustomObjectDataResponseBody;
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
      body: DeleteCrmCustomObjectDataResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager123
   */
  currentOperatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-123
   */
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
  /**
   * @example
   * intanceId1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteCrmFormInstanceResponseBody;
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
      body: DeleteCrmFormInstanceResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  currentOperatorUserId?: string;
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteCrmPersonalCustomerResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteCrmPersonalCustomerResponseBody;
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
      body: DeleteCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLeadsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLeadsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  outLeadsIds?: string[];
  static names(): { [key: string]: string } {
    return {
      outLeadsIds: 'outLeadsIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outLeadsIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLeadsResponseBody extends $tea.Model {
  outLeadsIds?: string[];
  static names(): { [key: string]: string } {
    return {
      outLeadsIds: 'outLeadsIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outLeadsIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLeadsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteLeadsResponseBody;
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
      body: DeleteLeadsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  fieldIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      fieldIdList: 'fieldIdList',
      operatorUserId: 'operatorUserId',
      relationType: 'relationType',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldIdList: { 'type': 'array', 'itemType': 'string' },
      operatorUserId: 'string',
      relationType: 'string',
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRelationMetaFieldResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteRelationMetaFieldResponseBody;
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
      body: DeleteRelationMetaFieldResponseBody,
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

export class DescribeCrmPersonalCustomerObjectMetaRequest extends $tea.Model {
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

export class DescribeCrmPersonalCustomerObjectMetaResponseBody extends $tea.Model {
  /**
   * @example
   * PROC-XXXX
   */
  code?: string;
  customized?: boolean;
  fields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFields[];
  name?: string;
  /**
   * @example
   * PUBLISHED
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      customized: 'customized',
      fields: 'fields',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      customized: 'boolean',
      fields: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFields },
      name: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DescribeCrmPersonalCustomerObjectMetaResponseBody;
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
      body: DescribeCrmPersonalCustomerObjectMetaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizTypes?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      bizTypes: 'bizTypes',
      operatorUserId: 'operatorUserId',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTypes: { 'type': 'array', 'itemType': 'string' },
      operatorUserId: 'string',
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  metaModelDTOList?: DescribeMetaModelResponseBodyMetaModelDTOList[];
  static names(): { [key: string]: string } {
    return {
      metaModelDTOList: 'metaModelDTOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      metaModelDTOList: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DescribeMetaModelResponseBody;
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
      body: DescribeMetaModelResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationTypes?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
      relationTypes: 'relationTypes',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
      relationTypes: { 'type': 'array', 'itemType': 'string' },
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DescribeRelationMetaResponseBody;
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
      body: DescribeRelationMetaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * customerId
   */
  followTargetDataId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * customer
   */
  followTargetType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      followTargetDataId: 'followTargetDataId',
      followTargetType: 'followTargetType',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      followTargetDataId: 'string',
      followTargetType: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsResponseBody extends $tea.Model {
  result?: FindTargetRelatedFollowRecordsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: FindTargetRelatedFollowRecordsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FindTargetRelatedFollowRecordsResponseBody;
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
      body: FindTargetRelatedFollowRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllCustomerRecyclesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllCustomerRecyclesRequest extends $tea.Model {
  /**
   * @example
   * 10
   */
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllCustomerRecyclesResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  /**
   * @example
   * true
   */
  resultList?: GetAllCustomerRecyclesResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      resultList: 'resultList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      resultList: { 'type': 'array', 'itemType': GetAllCustomerRecyclesResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllCustomerRecyclesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllCustomerRecyclesResponseBody;
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
      body: GetAllCustomerRecyclesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsRequest extends $tea.Model {
  /**
   * @example
   * user01
   */
  currentOperatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: string;
  /**
   * @example
   * crm_contact
   */
  objectType?: string;
  /**
   * @example
   * dingxxx
   */
  providerCorpId?: string;
  /**
   * @example
   * {"queryGroupList":[{"logicType":"AND","queryObjectList":[{"fieldId":"contact_phone","value":"18000000000"},{"fieldId":"contact_related_customer","value":"INST-XXX"}]}]}
   */
  queryDsl?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      objectType: 'objectType',
      providerCorpId: 'providerCorpId',
      queryDsl: 'queryDsl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      objectType: 'string',
      providerCorpId: 'string',
      queryDsl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsResponseBody extends $tea.Model {
  result?: GetContactsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetContactsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetContactsResponseBody;
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
      body: GetContactsResponseBody,
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
  gmtCreate?: number;
  /**
   * @example
   * https://static/xx.com/xx.jpg
   */
  iconUrl?: string;
  memberCount?: number;
  name?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  ownerUserId?: string;
  ownerUserName?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      gmtCreate: 'gmtCreate',
      iconUrl: 'iconUrl',
      memberCount: 'memberCount',
      name: 'name',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      ownerUserName: 'ownerUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      gmtCreate: 'number',
      iconUrl: 'string',
      memberCount: 'number',
      name: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      ownerUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCrmGroupChatResponseBody;
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
      body: GetCrmGroupChatResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatMultiHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatMultiRequest extends $tea.Model {
  openConversationIds?: string[];
  static names(): { [key: string]: string } {
    return {
      openConversationIds: 'openConversationIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatMultiResponseBody extends $tea.Model {
  result?: GetCrmGroupChatMultiResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetCrmGroupChatMultiResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatMultiResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCrmGroupChatMultiResponseBody;
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
      body: GetCrmGroupChatMultiResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatSingleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatSingleRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class GetCrmGroupChatSingleResponseBody extends $tea.Model {
  gmtCreate?: number;
  /**
   * @example
   * https://static/xx.com/xx.jpg
   */
  iconUrl?: string;
  memberCount?: number;
  name?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  ownerUserId?: string;
  ownerUserName?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      iconUrl: 'iconUrl',
      memberCount: 'memberCount',
      name: 'name',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      ownerUserName: 'ownerUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'number',
      iconUrl: 'string',
      memberCount: 'number',
      name: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      ownerUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatSingleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCrmGroupChatSingleResponseBody;
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
      body: GetCrmGroupChatSingleResponseBody,
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
  /**
   * @example
   * crm_customer
   */
  bizType?: string;
  /**
   * @example
   * PROC-9EC85C45-E404-4E26-9300-E67455F0FF8F
   */
  resourceId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      resourceId: 'resourceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      resourceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCrmRolePermissionResponseBody;
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
      body: GetCrmRolePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerTracksByRelationIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerTracksByRelationIdRequest extends $tea.Model {
  /**
   * @example
   * 10
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fasd-afsd1-21312-faaa
   */
  relationId?: string;
  /**
   * @example
   * 0
   */
  typeGroup?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      relationId: 'relationId',
      typeGroup: 'typeGroup',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      relationId: 'string',
      typeGroup: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerTracksByRelationIdResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  /**
   * @example
   * true
   */
  resultList?: GetCustomerTracksByRelationIdResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      resultList: 'resultList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      resultList: { 'type': 'array', 'itemType': GetCustomerTracksByRelationIdResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerTracksByRelationIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCustomerTracksByRelationIdResponseBody;
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
      body: GetCustomerTracksByRelationIdResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  gmtCreate?: string;
  gmtModified?: string;
  /**
   * @example
   * 5
   */
  groupChatCount?: number;
  inviteLink?: string;
  lastOpenConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  manager?: GetGroupSetResponseBodyManager[];
  managerUserIds?: string;
  memberCount?: number;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  owner?: GetGroupSetResponseBodyOwner;
  ownerUserId?: string;
  relationType?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      groupChatCount: 'groupChatCount',
      inviteLink: 'inviteLink',
      lastOpenConversationId: 'lastOpenConversationId',
      manager: 'manager',
      managerUserIds: 'managerUserIds',
      memberCount: 'memberCount',
      memberQuota: 'memberQuota',
      name: 'name',
      notice: 'notice',
      noticeToped: 'noticeToped',
      openGroupSetId: 'openGroupSetId',
      owner: 'owner',
      ownerUserId: 'ownerUserId',
      relationType: 'relationType',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      groupChatCount: 'number',
      inviteLink: 'string',
      lastOpenConversationId: 'string',
      manager: { 'type': 'array', 'itemType': GetGroupSetResponseBodyManager },
      managerUserIds: 'string',
      memberCount: 'number',
      memberQuota: 'number',
      name: 'string',
      notice: 'string',
      noticeToped: 'number',
      openGroupSetId: 'string',
      owner: GetGroupSetResponseBodyOwner,
      ownerUserId: 'string',
      relationType: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetGroupSetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetGroupSetResponseBody;
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
      body: GetGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsRequest extends $tea.Model {
  /**
   * @example
   * uhdhjsabdfhjb
   */
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

export class GetInAppPurchaseGoodsResponseBody extends $tea.Model {
  result?: GetInAppPurchaseGoodsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetInAppPurchaseGoodsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInAppPurchaseGoodsResponseBody;
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
      body: GetInAppPurchaseGoodsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNavigationCatalogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNavigationCatalogRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6360a371-4ffa-464b-a935-39817c3ccbe8
   */
  bizTraceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sale
   */
  module?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16044739461008808747
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizTraceId: 'bizTraceId',
      module: 'module',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTraceId: 'string',
      module: 'string',
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNavigationCatalogResponseBody extends $tea.Model {
  result?: GetNavigationCatalogResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetNavigationCatalogResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNavigationCatalogResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetNavigationCatalogResponseBody;
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
      body: GetNavigationCatalogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataRequest extends $tea.Model {
  /**
   * @example
   * ding_userid
   */
  currentOperatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-EF199CCA-8AB6-482A-AE10-85EDE5E391D9
   */
  name?: string;
  /**
   * @example
   * 0
   */
  nextToken?: string;
  /**
   * @example
   * {"queryGroupList":[{"logicType":"AND","queryObjectList":[{"fieldId":"contact_phone","value":"18000000000"},{"fieldId":"contact_related_customer","value":"INST-XXX"}]}]}
   */
  queryDsl?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      maxResults: 'maxResults',
      name: 'name',
      nextToken: 'nextToken',
      queryDsl: 'queryDsl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      maxResults: 'number',
      name: 'string',
      nextToken: 'string',
      queryDsl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataResponseBody extends $tea.Model {
  result?: GetObjectDataResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetObjectDataResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetObjectDataResponseBody;
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
      body: GetObjectDataResponseBody,
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
  authItems?: string[];
  /**
   * @example
   * 阿里巴巴钉钉
   */
  corpName?: string;
  /**
   * @example
   * 18812341234
   */
  mobile?: string;
  /**
   * @example
   * +86
   */
  stateCode?: string;
  /**
   * @example
   * unionId
   */
  unionId?: string;
  userInfos?: string[];
  static names(): { [key: string]: string } {
    return {
      authItems: 'authItems',
      corpName: 'corpName',
      mobile: 'mobile',
      stateCode: 'stateCode',
      unionId: 'unionId',
      userInfos: 'userInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authItems: { 'type': 'array', 'itemType': 'string' },
      corpName: 'string',
      mobile: 'string',
      stateCode: 'string',
      unionId: 'string',
      userInfos: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOfficialAccountContactInfoResponseBody;
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
      body: GetOfficialAccountContactInfoResponseBody,
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
   * 123567
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBody extends $tea.Model {
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 10010
   */
  nextToken?: string;
  values?: GetOfficialAccountContactsResponseBodyValues[];
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': GetOfficialAccountContactsResponseBodyValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOfficialAccountContactsResponseBody;
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
      body: GetOfficialAccountContactsResponseBody,
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
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOfficialAccountOTOMessageResultResponseBody;
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
      body: GetOfficialAccountOTOMessageResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataRequest extends $tea.Model {
  /**
   * @example
   * PROC-62829702-A377-42A9-9CB3-E1C691A0CEDB
   */
  formCode?: string;
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * OpenDataField_OV2K4SOW2ZGG
   */
  relatedField?: string;
  /**
   * @example
   * u_dxcugzT0aPQvcK2PIkzQ00841721291058
   */
  relatedInstId?: string;
  /**
   * @example
   * manager6034
   */
  viewUserId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      relatedField: 'relatedField',
      relatedInstId: 'relatedInstId',
      viewUserId: 'viewUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      maxResults: 'number',
      nextToken: 'number',
      relatedField: 'string',
      relatedInstId: 'string',
      viewUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataResponseBody extends $tea.Model {
  result?: GetRelatedViewTabDataResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetRelatedViewTabDataResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRelatedViewTabDataResponseBody;
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
      body: GetRelatedViewTabDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabMetaHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabMetaRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-2DB0FF86-CE29-41FF-B0FE-BFDE5BD9A0C1
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  viewUserId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      viewUserId: 'viewUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      viewUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabMetaResponseBody extends $tea.Model {
  results?: GetRelatedViewTabMetaResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': GetRelatedViewTabMetaResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabMetaResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRelatedViewTabMetaResponseBody;
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
      body: GetRelatedViewTabMetaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
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

export class GetRelationUkSettingResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: GetRelationUkSettingResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetRelationUkSettingResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRelationUkSettingResponseBody;
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
      body: GetRelationUkSettingResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      corpId: 'corpId',
      openGroupSetId: 'openGroupSetId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': JoinGroupSetRequestBizDataList },
      corpId: 'string',
      openGroupSetId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class JoinGroupSetResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  chatId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class JoinGroupSetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: JoinGroupSetResponseBody;
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
      body: JoinGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvailableBenefitHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvailableBenefitRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  benefitCodeList?: string[];
  static names(): { [key: string]: string } {
    return {
      benefitCodeList: 'benefitCodeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCodeList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvailableBenefitResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: ListAvailableBenefitResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListAvailableBenefitResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvailableBenefitResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAvailableBenefitResponseBody;
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
      body: ListAvailableBenefitResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBenefitLicenseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBenefitLicenseRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  domains?: string[];
  static names(): { [key: string]: string } {
    return {
      domains: 'domains',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domains: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBenefitLicenseResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: ListBenefitLicenseResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListBenefitLicenseResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBenefitLicenseResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListBenefitLicenseResponseBody;
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
      body: ListBenefitLicenseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListClueTagHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListClueTagResponseBody extends $tea.Model {
  result?: ListClueTagResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListClueTagResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListClueTagResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListClueTagResponseBody;
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
      body: ListClueTagResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  body?: string[];
  currentOperatorUserId?: string;
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      currentOperatorUserId: 'currentOperatorUserId',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
      currentOperatorUserId: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListCrmPersonalCustomersResponseBody;
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
      body: ListCrmPersonalCustomersResponseBody,
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
  maxResults?: number;
  nextToken?: string;
  queryDsl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      queryDsl: 'queryDsl',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      queryDsl: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupSetResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * fasfasd
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  resultList?: ListGroupSetResponseBodyResultList[];
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListGroupSetResponseBody;
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
      body: ListGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OverrideUpdateCustomerDataAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OverrideUpdateCustomerDataAuthRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  customerIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  dataAuthUserIds?: string[];
  /**
   * @example
   * PROC-98187D45-EFC0-4FC4-887E-45BD24209D69
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId2
   */
  operateUserId?: string;
  /**
   * @example
   * crm_customer
   */
  relationType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * owner
   */
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      customerIds: 'customerIds',
      dataAuthUserIds: 'dataAuthUserIds',
      formCode: 'formCode',
      operateUserId: 'operateUserId',
      relationType: 'relationType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerIds: { 'type': 'array', 'itemType': 'string' },
      dataAuthUserIds: { 'type': 'array', 'itemType': 'string' },
      formCode: 'string',
      operateUserId: 'string',
      relationType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OverrideUpdateCustomerDataAuthResponseBody extends $tea.Model {
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

export class OverrideUpdateCustomerDataAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OverrideUpdateCustomerDataAuthResponseBody;
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
      body: OverrideUpdateCustomerDataAuthResponseBody,
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
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 100010
   * 
   * **if can be null:**
   * true
   */
  nextToken?: string;
  /**
   * @example
   * crm_customer
   * 
   * **if can be null:**
   * true
   */
  objectType?: string;
  /**
   * @example
   * ding_userid
   * 
   * **if can be null:**
   * true
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      objectType: 'objectType',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      objectType: 'string',
      operatorUserId: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAllCustomerResponseBody;
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
      body: QueryAllCustomerResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * 10000
   */
  nextToken?: string;
  /**
   * @example
   * asc
   * 
   * **if can be null:**
   * true
   */
  order?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      order: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * 10001
   */
  nextToken?: string;
  values?: QueryAllTracksResponseBodyValues[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': QueryAllTracksResponseBodyValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAllTracksResponseBody;
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
      body: QueryAllTracksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppManagerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppManagerRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 34234dfdfddd
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppManagerResponseBody extends $tea.Model {
  result?: QueryAppManagerResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryAppManagerResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppManagerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAppManagerResponseBody;
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
      body: QueryAppManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitInventoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitInventoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B_CUSTOMER_CAPACITY
   */
  benefitCode?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitInventoryResponseBody extends $tea.Model {
  result?: QueryBenefitInventoryResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryBenefitInventoryResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitInventoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBenefitInventoryResponseBody;
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
      body: QueryBenefitInventoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClueFollowStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClueFollowStatusRequest extends $tea.Model {
  clueId?: string;
  static names(): { [key: string]: string } {
    return {
      clueId: 'clueId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clueId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClueFollowStatusResponseBody extends $tea.Model {
  result?: QueryClueFollowStatusResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryClueFollowStatusResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClueFollowStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryClueFollowStatusResponseBody;
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
      body: QueryClueFollowStatusResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  nextToken?: string;
  queryDsl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      queryDsl: 'queryDsl',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      queryDsl: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupChatsResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * agds12
   */
  nextToken?: string;
  resultList?: QueryCrmGroupChatsResponseBodyResultList[];
  /**
   * @example
   * 1000
   */
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
      resultList: { 'type': 'array', 'itemType': QueryCrmGroupChatsResponseBodyResultList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupChatsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCrmGroupChatsResponseBody;
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
      body: QueryCrmGroupChatsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  queryDsl?: string;
  /**
   * **if can be null:**
   * false
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      currentOperatorUserId: 'currentOperatorUserId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      queryDsl: 'queryDsl',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentOperatorUserId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      queryDsl: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponseBody extends $tea.Model {
  hasMore?: boolean;
  /**
   * @example
   * 10
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @example
   * 1000
   */
  totalCount?: number;
  values?: QueryCrmPersonalCustomerResponseBodyValues[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      totalCount: 'number',
      values: { 'type': 'array', 'itemType': QueryCrmPersonalCustomerResponseBodyValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCrmPersonalCustomerResponseBody;
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
      body: QueryCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerBizTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerBizTypeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1343dfd1233
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerBizTypeResponseBody extends $tea.Model {
  result?: QueryCustomerBizTypeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryCustomerBizTypeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerBizTypeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCustomerBizTypeResponseBody;
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
      body: QueryCustomerBizTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGlobalInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGlobalInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 301227837938
   */
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

export class QueryGlobalInfoResponseBody extends $tea.Model {
  result?: QueryGlobalInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryGlobalInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGlobalInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGlobalInfoResponseBody;
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
      body: QueryGlobalInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHasAppPermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHasAppPermissionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 34234dfdfddd
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHasAppPermissionResponseBody extends $tea.Model {
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

export class QueryHasAppPermissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryHasAppPermissionResponseBody;
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
      body: QueryHasAppPermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialAccountUserBasicInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialAccountUserBasicInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bindingToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bindingToken: 'bindingToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingToken: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialAccountUserBasicInfoResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: QueryOfficialAccountUserBasicInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: QueryOfficialAccountUserBasicInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialAccountUserBasicInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOfficialAccountUserBasicInfoResponseBody;
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
      body: QueryOfficialAccountUserBasicInfoResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRelationDatasByTargetIdResponseBody;
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
      body: QueryRelationDatasByTargetIdResponseBody,
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
  /**
   * @example
   * ding123
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SWXXX
   */
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RecallOfficialAccountOTOMessageResponseBody;
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
      body: RecallOfficialAccountOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B_ACCOUNT_NUMBER
   */
  domain?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  licenses?: SaveBenefitLicenseRequestLicenses[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId
   */
  saveUserId?: string;
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      licenses: 'licenses',
      saveUserId: 'saveUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      licenses: { 'type': 'array', 'itemType': SaveBenefitLicenseRequestLicenses },
      saveUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseResponseBody extends $tea.Model {
  result?: SaveBenefitLicenseResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SaveBenefitLicenseResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveBenefitLicenseResponseBody;
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
      body: SaveBenefitLicenseResponseBody,
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
  accountId?: string;
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: SendOfficialAccountOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      bizId: 'bizId',
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      bizId: 'string',
      detail: SendOfficialAccountOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendOfficialAccountOTOMessageResponseBody;
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
      body: SendOfficialAccountOTOMessageResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  bindingToken?: string;
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: SendOfficialAccountSNSMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      bindingToken: 'bindingToken',
      bizId: 'bizId',
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingToken: 'string',
      bizId: 'string',
      detail: SendOfficialAccountSNSMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendOfficialAccountSNSMessageResponseBody;
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
      body: SendOfficialAccountSNSMessageResponseBody,
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
  /**
   * **if can be null:**
   * true
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: ServiceWindowMessageBatchPushRequestDetail;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      detail: ServiceWindowMessageBatchPushRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushResponseBody extends $tea.Model {
  requestId?: string;
  result?: ServiceWindowMessageBatchPushResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: ServiceWindowMessageBatchPushResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ServiceWindowMessageBatchPushResponseBody;
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
      body: ServiceWindowMessageBatchPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TwoPhaseCommitInventoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TwoPhaseCommitInventoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B_ACCOUNT_NUMBER
   */
  benefitCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * bizId
   */
  bizRequestId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  executeResult?: boolean;
  /**
   * @example
   * 10
   */
  quota?: number;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      bizRequestId: 'bizRequestId',
      executeResult: 'executeResult',
      quota: 'quota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      bizRequestId: 'string',
      executeResult: 'boolean',
      quota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TwoPhaseCommitInventoryResponseBody extends $tea.Model {
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

export class TwoPhaseCommitInventoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TwoPhaseCommitInventoryResponseBody;
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
      body: TwoPhaseCommitInventoryResponseBody,
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
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  instanceId?: string;
  modifierNick?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  modifierUserId?: string;
  permission?: UpdateCrmPersonalCustomerRequestPermission;
  relationType?: string;
  /**
   * @example
   * false
   */
  skipDuplicateCheck?: boolean;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      data: 'data',
      extendData: 'extendData',
      instanceId: 'instanceId',
      modifierNick: 'modifierNick',
      modifierUserId: 'modifierUserId',
      permission: 'permission',
      relationType: 'relationType',
      skipDuplicateCheck: 'skipDuplicateCheck',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      instanceId: 'string',
      modifierNick: 'string',
      modifierUserId: 'string',
      permission: UpdateCrmPersonalCustomerRequestPermission,
      relationType: 'string',
      skipDuplicateCheck: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCrmPersonalCustomerResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateCrmPersonalCustomerResponseBody;
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
      body: UpdateCrmPersonalCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomerBizTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomerBizTypeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
  customerBizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 34234234ddddad
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      customerBizType: 'customerBizType',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerBizType: 'string',
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomerBizTypeResponseBody extends $tea.Model {
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

export class UpdateCustomerBizTypeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateCustomerBizTypeResponseBody;
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
      body: UpdateCustomerBizTypeResponseBody,
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
  managerUserIds?: string;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  openGroupSetId?: string;
  ownerUserId?: string;
  templateId?: string;
  welcome?: string;
  static names(): { [key: string]: string } {
    return {
      managerUserIds: 'managerUserIds',
      memberQuota: 'memberQuota',
      name: 'name',
      notice: 'notice',
      noticeToped: 'noticeToped',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      templateId: 'templateId',
      welcome: 'welcome',
    };
  }

  static types(): { [key: string]: any } {
    return {
      managerUserIds: 'string',
      memberQuota: 'number',
      name: 'string',
      notice: 'string',
      noticeToped: 'number',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      templateId: 'string',
      welcome: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSetResponse extends $tea.Model {
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

export class UpdateMenuDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMenuDataRequest extends $tea.Model {
  attr?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 89ez9DwVWQVgkhwndJNt1ZY
   */
  bizTraceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sale
   */
  module?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  navData?: UpdateMenuDataRequestNavData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * add
   */
  operateType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16044739461008808646
   */
  operatorUserId?: string;
  static names(): { [key: string]: string } {
    return {
      attr: 'attr',
      bizTraceId: 'bizTraceId',
      module: 'module',
      navData: 'navData',
      operateType: 'operateType',
      operatorUserId: 'operatorUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attr: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      bizTraceId: 'string',
      module: 'string',
      navData: UpdateMenuDataRequestNavData,
      operateType: 'string',
      operatorUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMenuDataResponseBody extends $tea.Model {
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

export class UpdateMenuDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateMenuDataResponseBody;
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
      body: UpdateMenuDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMetaModelFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMetaModelFieldRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldDTOList?: UpdateMetaModelFieldRequestFieldDTOList[];
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      fieldDTOList: 'fieldDTOList',
      operatorUserId: 'operatorUserId',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      fieldDTOList: { 'type': 'array', 'itemType': UpdateMetaModelFieldRequestFieldDTOList },
      operatorUserId: 'string',
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMetaModelFieldResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMetaModelFieldResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateMetaModelFieldResponseBody;
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
      body: UpdateMetaModelFieldResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  fieldDTOList?: UpdateRelationMetaFieldRequestFieldDTOList[];
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tenant?: string;
  static names(): { [key: string]: string } {
    return {
      fieldDTOList: 'fieldDTOList',
      operatorUserId: 'operatorUserId',
      relationType: 'relationType',
      tenant: 'tenant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldDTOList: { 'type': 'array', 'itemType': UpdateRelationMetaFieldRequestFieldDTOList },
      operatorUserId: 'string',
      relationType: 'string',
      tenant: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateRelationMetaFieldResponseBody;
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
      body: UpdateRelationMetaFieldResponseBody,
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

export class AddLeadsRequestLeads extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX公司
   */
  leadsName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fasd123125
   */
  outLeadsId?: string;
  static names(): { [key: string]: string } {
    return {
      leadsName: 'leadsName',
      outLeadsId: 'outLeadsId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      leadsName: 'string',
      outLeadsId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMetaModelFieldRequestFieldDTOListPropsOptions extends $tea.Model {
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

export class AddMetaModelFieldRequestFieldDTOListProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: AddMetaModelFieldRequestFieldDTOListPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  requiredEditableFreeze?: boolean;
  sortable?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      sortable: 'sortable',
      unit: 'unit',
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
      fieldId: 'string',
      format: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': AddMetaModelFieldRequestFieldDTOListPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      sortable: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMetaModelFieldRequestFieldDTOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: AddMetaModelFieldRequestFieldDTOListProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: AddMetaModelFieldRequestFieldDTOListProps,
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
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: AddRelationMetaFieldRequestFieldDTOListPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  requiredEditableFreeze?: boolean;
  sortable?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      sortable: 'sortable',
      unit: 'unit',
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
      fieldId: 'string',
      format: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': AddRelationMetaFieldRequestFieldDTOListPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      sortable: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRelationMetaFieldRequestFieldDTOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class BatchAddContactsRequestRelationListBizDataList extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_71U51A
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
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

export class BatchAddContactsRequestRelationList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizDataList?: BatchAddContactsRequestRelationListBizDataList[];
  /**
   * **if can be null:**
   * true
   */
  bizExtMap?: { [key: string]: string };
  /**
   * @example
   * 1343434dd
   */
  sourceDataId?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      bizExtMap: 'bizExtMap',
      sourceDataId: 'sourceDataId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': BatchAddContactsRequestRelationListBizDataList },
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      sourceDataId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddContactsResponseBodyResults extends $tea.Model {
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * gads1ag-sfgasdfxcvxb
   */
  relationId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      relationId: 'relationId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      relationId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsRequestInstanceListDataArray extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_71U51A
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
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

export class BatchAddFollowRecordsRequestInstanceList extends $tea.Model {
  bizExtMap?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  dataArray?: BatchAddFollowRecordsRequestInstanceListDataArray[];
  static names(): { [key: string]: string } {
    return {
      bizExtMap: 'bizExtMap',
      dataArray: 'dataArray',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dataArray: { 'type': 'array', 'itemType': BatchAddFollowRecordsRequestInstanceListDataArray },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsResponseBodyResults extends $tea.Model {
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * yU9TbER1TDazjPq1rRCzwg04841675924041
   */
  instanceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      instanceId: 'instanceId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      instanceId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasRequestRelationListBizDataList extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_71U51A
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
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

export class BatchAddRelationDatasRequestRelationListRelationPermissionDTO extends $tea.Model {
  participantUserIds?: string[];
  principalUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      participantUserIds: 'participantUserIds',
      principalUserIds: 'principalUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantUserIds: { 'type': 'array', 'itemType': 'string' },
      principalUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasRequestRelationList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizDataList?: BatchAddRelationDatasRequestRelationListBizDataList[];
  /**
   * **if can be null:**
   * true
   */
  bizExtMap?: { [key: string]: string };
  relationPermissionDTO?: BatchAddRelationDatasRequestRelationListRelationPermissionDTO;
  /**
   * @example
   * ddsf3234234
   */
  sourceDataId?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      bizExtMap: 'bizExtMap',
      relationPermissionDTO: 'relationPermissionDTO',
      sourceDataId: 'sourceDataId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': BatchAddRelationDatasRequestRelationListBizDataList },
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      relationPermissionDTO: BatchAddRelationDatasRequestRelationListRelationPermissionDTO,
      sourceDataId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasResponseBodyResults extends $tea.Model {
  duplicatedRelationIds?: string[];
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * gads1ag-sfgasdfxcvxb
   */
  relationId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      duplicatedRelationIds: 'duplicatedRelationIds',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      relationId: 'relationId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duplicatedRelationIds: { 'type': 'array', 'itemType': 'string' },
      errorCode: 'string',
      errorMsg: 'string',
      relationId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataRequestDataListContactList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  phone?: string;
  qq?: string;
  wangWang?: string;
  weChat?: string;
  static names(): { [key: string]: string } {
    return {
      mobile: 'mobile',
      name: 'name',
      phone: 'phone',
      qq: 'qq',
      wangWang: 'wangWang',
      weChat: 'weChat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobile: 'string',
      name: 'string',
      phone: 'string',
      qq: 'string',
      wangWang: 'string',
      weChat: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataRequestDataListEnterprise extends $tea.Model {
  address?: string;
  industryCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  region?: string;
  unifiedSocialCreditCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      industryCode: 'industryCode',
      name: 'name',
      region: 'region',
      unifiedSocialCreditCode: 'unifiedSocialCreditCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      industryCode: 'string',
      name: 'string',
      region: 'string',
      unifiedSocialCreditCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataRequestDataListTagIdList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  tagId?: string;
  tagName?: string;
  static names(): { [key: string]: string } {
    return {
      tagId: 'tagId',
      tagName: 'tagName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagId: 'string',
      tagName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataRequestDataList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  contactList?: BatchCreateClueDataRequestDataListContactList[];
  enterprise?: BatchCreateClueDataRequestDataListEnterprise;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉中国
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  sourceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * demo
   */
  sourceType?: string;
  tagIdList?: BatchCreateClueDataRequestDataListTagIdList[];
  static names(): { [key: string]: string } {
    return {
      contactList: 'contactList',
      enterprise: 'enterprise',
      name: 'name',
      sourceId: 'sourceId',
      sourceType: 'sourceType',
      tagIdList: 'tagIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactList: { 'type': 'array', 'itemType': BatchCreateClueDataRequestDataListContactList },
      enterprise: BatchCreateClueDataRequestDataListEnterprise,
      name: 'string',
      sourceId: 'string',
      sourceType: 'string',
      tagIdList: { 'type': 'array', 'itemType': BatchCreateClueDataRequestDataListTagIdList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateClueDataResponseBodyResult extends $tea.Model {
  clueId?: string;
  dataId?: string;
  resultCode?: string;
  static names(): { [key: string]: string } {
    return {
      clueId: 'clueId',
      dataId: 'dataId',
      resultCode: 'resultCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clueId: 'string',
      dataId: 'string',
      resultCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemoveFollowRecordsResponseBodyResults extends $tea.Model {
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * yU9TbER1TDazjPq1rRCzwg04841675924041
   */
  instanceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      instanceId: 'instanceId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      instanceId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  actionUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionUrl: 'actionUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList[];
  buttonOrientation?: string;
  markdown?: string;
  singleTitle?: string;
  singleUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      buttonList: 'buttonList',
      buttonOrientation: 'buttonOrientation',
      markdown: 'markdown',
      singleTitle: 'singleTitle',
      singleUrl: 'singleUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonList: { 'type': 'array', 'itemType': BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList },
      buttonOrientation: 'string',
      markdown: 'string',
      singleTitle: 'string',
      singleUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  picUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  text?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      messageUrl: 'messageUrl',
      picUrl: 'picUrl',
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageUrl: 'string',
      picUrl: 'string',
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  text?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody extends $tea.Model {
  actionCard?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard;
  link?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink;
  markdown?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown;
  text?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText;
  static names(): { [key: string]: string } {
    return {
      actionCard: 'actionCard',
      link: 'link',
      markdown: 'markdown',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCard: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard,
      link: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink,
      markdown: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown,
      text: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageRequestDetail extends $tea.Model {
  /**
   * **if can be null:**
   * false
   */
  bizRequestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  messageBody?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBody;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  msgType?: string;
  sendToAll?: boolean;
  userIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      bizRequestId: 'bizRequestId',
      messageBody: 'messageBody',
      msgType: 'msgType',
      sendToAll: 'sendToAll',
      userIdList: 'userIdList',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizRequestId: 'string',
      messageBody: BatchSendOfficialAccountOTOMessageRequestDetailMessageBody,
      msgType: 'string',
      sendToAll: 'boolean',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOfficialAccountOTOMessageResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class BatchUpdateContactsRequestRelationListBizDataList extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_71U51A
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
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

export class BatchUpdateContactsRequestRelationList extends $tea.Model {
  bizDataList?: BatchUpdateContactsRequestRelationListBizDataList[];
  /**
   * **if can be null:**
   * true
   */
  bizExtMap?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fasdg8i814-0afsd
   */
  relationId?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      bizExtMap: 'bizExtMap',
      relationId: 'relationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': BatchUpdateContactsRequestRelationListBizDataList },
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      relationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateContactsResponseBodyResults extends $tea.Model {
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * gads1ag-sfgasdfxcvxb
   */
  relationId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      relationId: 'relationId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      relationId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFollowRecordsRequestInstanceListDataArray extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_71U51A
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
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

export class BatchUpdateFollowRecordsRequestInstanceList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dataArray?: BatchUpdateFollowRecordsRequestInstanceListDataArray[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yU9TbER1TDazjPq1rRCzwg04841675924041
   */
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      dataArray: 'dataArray',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataArray: { 'type': 'array', 'itemType': BatchUpdateFollowRecordsRequestInstanceListDataArray },
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFollowRecordsResponseBodyResults extends $tea.Model {
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * yU9TbER1TDazjPq1rRCzwg04841675924041
   */
  instanceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      instanceId: 'instanceId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      instanceId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateRelationDatasRequestRelationListBizDataList extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_71U51A
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
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

export class BatchUpdateRelationDatasRequestRelationList extends $tea.Model {
  bizDataList?: BatchUpdateRelationDatasRequestRelationListBizDataList[];
  /**
   * **if can be null:**
   * true
   */
  bizExtMap?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fasdg8i814-0afsd
   */
  relationId?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      bizExtMap: 'bizExtMap',
      relationId: 'relationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': BatchUpdateRelationDatasRequestRelationListBizDataList },
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      relationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateRelationDatasResponseBodyResults extends $tea.Model {
  duplicatedRelationIds?: string[];
  /**
   * @example
   * 1002
   */
  errorCode?: string;
  /**
   * @example
   * 查重失败
   */
  errorMsg?: string;
  /**
   * @example
   * gads1ag-sfgasdfxcvxb
   */
  relationId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      duplicatedRelationIds: 'duplicatedRelationIds',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      relationId: 'relationId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duplicatedRelationIds: { 'type': 'array', 'itemType': 'string' },
      errorCode: 'string',
      errorMsg: 'string',
      relationId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerRequestContacts extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * APPEND_CONTACT_FORCE
   */
  customerExistedPolicy?: string;
  /**
   * @example
   * false
   */
  skipDuplicateCheck?: boolean;
  /**
   * @example
   * 0
   */
  subscribePolicy?: number;
  /**
   * @example
   * true
   */
  throwExceptionWhileSavingContactFailed?: boolean;
  static names(): { [key: string]: string } {
    return {
      customerExistedPolicy: 'customerExistedPolicy',
      skipDuplicateCheck: 'skipDuplicateCheck',
      subscribePolicy: 'subscribePolicy',
      throwExceptionWhileSavingContactFailed: 'throwExceptionWhileSavingContactFailed',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerExistedPolicy: 'string',
      skipDuplicateCheck: 'boolean',
      subscribePolicy: 'number',
      throwExceptionWhileSavingContactFailed: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponseBodyContacts extends $tea.Model {
  /**
   * @example
   * contact_id
   */
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
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  requiredEditableFreeze?: boolean;
  sortable?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      sortable: 'sortable',
      unit: 'unit',
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
      fieldId: 'string',
      format: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      sortable: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRelationMetaRequestRelationMetaDTOItems extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  desc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  items?: CreateRelationMetaRequestRelationMetaDTOItems[];
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
      items: { 'type': 'array', 'itemType': CreateRelationMetaRequestRelationMetaDTOItems },
      name: 'string',
      relationType: 'string',
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
  format?: string;
  label?: string;
  name?: string;
  nillable?: boolean;
  selectOptions?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions[];
  type?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      format: 'format',
      label: 'label',
      name: 'name',
      nillable: 'nillable',
      selectOptions: 'selectOptions',
      type: 'type',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      format: 'string',
      label: 'string',
      name: 'string',
      nillable: 'boolean',
      selectOptions: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions },
      type: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  aggregator?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      aggregator: 'aggregator',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aggregator: 'string',
      name: 'string',
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

export class DescribeCrmPersonalCustomerObjectMetaResponseBodyFields extends $tea.Model {
  customized?: boolean;
  format?: string;
  label?: string;
  name?: string;
  nillable?: boolean;
  quote?: boolean;
  referenceFields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields[];
  referenceTo?: string;
  rollUpSummaryFields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields[];
  selectOptions?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions[];
  type?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      customized: 'customized',
      format: 'format',
      label: 'label',
      name: 'name',
      nillable: 'nillable',
      quote: 'quote',
      referenceFields: 'referenceFields',
      referenceTo: 'referenceTo',
      rollUpSummaryFields: 'rollUpSummaryFields',
      selectOptions: 'selectOptions',
      type: 'type',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customized: 'boolean',
      format: 'string',
      label: 'string',
      name: 'string',
      nillable: 'boolean',
      quote: 'boolean',
      referenceFields: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields },
      referenceTo: 'string',
      rollUpSummaryFields: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields },
      selectOptions: { 'type': 'array', 'itemType': DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions },
      type: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates extends $tea.Model {
  /**
   * @example
   * 审批模板id
   */
  id?: string;
  /**
   * @example
   * 审批模板名称
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
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  filters?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams;
  /**
   * @remarks
   * This parameter is required.
   */
  target?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams,
      target: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      ratio: 'ratio',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      spread: 'spread',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
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
      durationLabel: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      ratio: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relateProps?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  filters?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams;
  /**
   * @remarks
   * This parameter is required.
   */
  target?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams,
      target: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  multi?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      multi: 'multi',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
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
      disabled: 'boolean',
      duration: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      multi: 'number',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relateProps?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  dataSource?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      dataSource: 'dataSource',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      dataSource: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource,
      fields: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  actionName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  availableTemplates?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates[];
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  dataSource?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource;
  /**
   * @example
   * 标签字段 颜色属性，格式：#0089FF
   */
  defaultColor?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields[];
  /**
   * @remarks
   * This parameter is required.
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：支持多选，false：单选
   */
  multiple?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  notPrint?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  relateSource?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource[];
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  rule?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule[];
  /**
   * @remarks
   * This parameter is required.
   */
  sortable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  tableViewMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      align: 'align',
      availableTemplates: 'availableTemplates',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      dataSource: 'dataSource',
      defaultColor: 'defaultColor',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      fields: 'fields',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      multiple: 'multiple',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
      ratio: 'ratio',
      relateSource: 'relateSource',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      rule: 'rule',
      sortable: 'sortable',
      spread: 'spread',
      statField: 'statField',
      tableViewMode: 'tableViewMode',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      align: 'string',
      availableTemplates: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates },
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      dataSource: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource,
      defaultColor: 'string',
      disabled: 'boolean',
      duration: 'boolean',
      durationLabel: 'string',
      fieldId: 'string',
      fields: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields },
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      multiple: 'boolean',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      ratio: 'number',
      relateSource: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource },
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      rule: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule },
      sortable: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField },
      tableViewMode: 'string',
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates extends $tea.Model {
  /**
   * @example
   * 审批模板id
   */
  id?: string;
  /**
   * @example
   * 审批模板名称
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
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsBehaviorLinkageTargets extends $tea.Model {
  /**
   * @example
   * NORMAL
   */
  behavior?: string;
  /**
   * @example
   * TextField_1LTIYOR4XIF40
   */
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      behavior: 'behavior',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      behavior: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsBehaviorLinkage extends $tea.Model {
  /**
   * @example
   * option_0
   */
  optionKey?: string;
  targets?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsBehaviorLinkageTargets[];
  static names(): { [key: string]: string } {
    return {
      optionKey: 'optionKey',
      targets: 'targets',
    };
  }

  static types(): { [key: string]: any } {
    return {
      optionKey: 'string',
      targets: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsBehaviorLinkageTargets },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  filters?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget extends $tea.Model {
  /**
   * @example
   * 0：流程表单，1：纯表单
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams;
  target?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams,
      target: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      ratio: 'ratio',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      spread: 'spread',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
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
      durationLabel: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      ratio: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relateProps?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  warn?: boolean;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
      warn: 'warn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension,
      key: 'string',
      value: 'string',
      warn: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  filters?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters[];
  static names(): { [key: string]: string } {
    return {
      filters: 'filters',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filters: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams;
  /**
   * @remarks
   * This parameter is required.
   */
  target?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams,
      target: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  multi?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      multi: 'multi',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
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
      disabled: 'boolean',
      duration: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      multi: 'number',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relateProps?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      relateProps: 'relateProps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      relateProps: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  dataSource?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      dataSource: 'dataSource',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      dataSource: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource,
      fields: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeMetaModelResponseBodyMetaModelDTOListItemsProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 明细动作名称
   */
  actionName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * top|middle|bottom
   */
  align?: string;
  availableTemplates?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates[];
  behaviorLinkage?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsBehaviorLinkage[];
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  dataSource?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource;
  /**
   * @example
   * 标签字段 颜色属性，格式：#0089FF
   */
  defaultColor?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 日期区间控件，自动计算时长的标题
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：不可修改
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 评分组件限制
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 电话控件模式 phone：仅手机，phone_tel： 手机和固话，tel：仅固话
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  multi?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：支持多选，false：单选
   */
  multiple?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  needDetail?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：不打印，0：打印
   */
  notPrint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 关联表单 1：引用，0：拷贝
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 文本控件、选项控件等限制文本字数ratio
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  relateSource?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：不可修改
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  rule?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule[];
  /**
   * @remarks
   * This parameter is required.
   */
  sortable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 选项控件spread
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 明细填写方式 table：表格，list：列表
   */
  tableViewMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 是否水印照片 true：是，false：否
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      align: 'align',
      availableTemplates: 'availableTemplates',
      behaviorLinkage: 'behaviorLinkage',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      dataSource: 'dataSource',
      defaultColor: 'defaultColor',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      fields: 'fields',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      multi: 'multi',
      multiple: 'multiple',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
      ratio: 'ratio',
      relateSource: 'relateSource',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      rule: 'rule',
      sortable: 'sortable',
      spread: 'spread',
      statField: 'statField',
      tableViewMode: 'tableViewMode',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      align: 'string',
      availableTemplates: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates },
      behaviorLinkage: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsBehaviorLinkage },
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      dataSource: DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource,
      defaultColor: 'string',
      disabled: 'boolean',
      duration: 'boolean',
      durationLabel: 'string',
      fieldId: 'string',
      fields: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields },
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      multi: 'number',
      multiple: 'boolean',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      ratio: 'number',
      relateSource: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource },
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      rule: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule },
      sortable: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField },
      tableViewMode: 'string',
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOListItems extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  children?: DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren[];
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: DescribeMetaModelResponseBodyMetaModelDTOListItemsProps;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren },
      componentName: 'string',
      props: DescribeMetaModelResponseBodyMetaModelDTOListItemsProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeMetaModelResponseBodyMetaModelDTOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 企业客户表
   */
  desc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  items?: DescribeMetaModelResponseBodyMetaModelDTOListItems[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 企业客户
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationMetaCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationMetaStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      desc: 'desc',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      items: 'items',
      name: 'name',
      relationMetaCode: 'relationMetaCode',
      relationMetaStatus: 'relationMetaStatus',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      desc: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      items: { 'type': 'array', 'itemType': DescribeMetaModelResponseBodyMetaModelDTOListItems },
      name: 'string',
      relationMetaCode: 'string',
      relationMetaStatus: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates extends $tea.Model {
  /**
   * @example
   * 审批模板id
   */
  id?: string;
  /**
   * @example
   * 审批模板名称
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
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams;
  /**
   * @remarks
   * This parameter is required.
   */
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams,
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      ratio: 'ratio',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      spread: 'spread',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
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
      durationLabel: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      ratio: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams;
  /**
   * @remarks
   * This parameter is required.
   */
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams,
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  multi?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      multi: 'multi',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
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
      disabled: 'boolean',
      duration: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      multi: 'number',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      dataSource: 'dataSource',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource,
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  actionName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  availableTemplates?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates[];
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource;
  /**
   * @example
   * 标签字段 颜色属性，格式：#0089FF
   */
  defaultColor?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields[];
  /**
   * @remarks
   * This parameter is required.
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：支持多选，false：单选
   */
  multiple?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  notPrint?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  relateSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource[];
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  rule?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule[];
  /**
   * @remarks
   * This parameter is required.
   */
  sortable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  tableViewMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      align: 'align',
      availableTemplates: 'availableTemplates',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      dataSource: 'dataSource',
      defaultColor: 'defaultColor',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      fields: 'fields',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      multiple: 'multiple',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
      ratio: 'ratio',
      relateSource: 'relateSource',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      rule: 'rule',
      sortable: 'sortable',
      spread: 'spread',
      statField: 'statField',
      tableViewMode: 'tableViewMode',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      align: 'string',
      availableTemplates: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates },
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource,
      defaultColor: 'string',
      disabled: 'boolean',
      duration: 'boolean',
      durationLabel: 'string',
      fieldId: 'string',
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields },
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      multiple: 'boolean',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      ratio: 'number',
      relateSource: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource },
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      rule: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule },
      sortable: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField },
      tableViewMode: 'string',
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates extends $tea.Model {
  /**
   * @example
   * 审批模板id
   */
  id?: string;
  /**
   * @example
   * 审批模板名称
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
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets extends $tea.Model {
  /**
   * @example
   * NORMAL
   */
  behavior?: string;
  /**
   * @example
   * TextField_1LTIYOR4XIF40
   */
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      behavior: 'behavior',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      behavior: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage extends $tea.Model {
  /**
   * @example
   * option_0
   */
  optionKey?: string;
  targets?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets[];
  static names(): { [key: string]: string } {
    return {
      optionKey: 'optionKey',
      targets: 'targets',
    };
  }

  static types(): { [key: string]: any } {
    return {
      optionKey: 'string',
      targets: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 0：流程表单，1：纯表单
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams,
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      ratio: 'ratio',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      spread: 'spread',
      statField: 'statField',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
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
      durationLabel: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      ratio: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  warn?: boolean;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
      warn: 'warn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension,
      key: 'string',
      value: 'string',
      warn: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  filterType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  valueType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      filterType: 'filterType',
      value: 'value',
      valueType: 'valueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      filterType: 'string',
      value: 'string',
      valueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams;
  /**
   * @remarks
   * This parameter is required.
   */
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      params: 'params',
      target: 'target',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      params: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams,
      target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget,
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension,
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  multi?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      multi: 'multi',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
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
      disabled: 'boolean',
      duration: 'string',
      fieldId: 'string',
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      multi: 'number',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField },
      unit: 'string',
      verticalPrint: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      dataSource: 'dataSource',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource,
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 明细动作名称
   */
  actionName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * top|middle|bottom
   */
  align?: string;
  availableTemplates?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates[];
  behaviorLinkage?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage[];
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：多选，0：单选
   */
  choice?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource;
  /**
   * @example
   * 标签字段 颜色属性，格式：#0089FF
   */
  defaultColor?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：可编辑
   */
  disabled?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：自动
   */
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 日期区间控件，自动计算时长的标题
   */
  durationLabel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DDDateField和DDDateRangeField
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  formula?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：隐藏
   */
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：不可修改
   */
  labelEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 评分组件限制
   */
  limit?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  link?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 电话控件模式 phone：仅手机，phone_tel： 手机和固话，tel：仅固话
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  multi?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：支持多选，false：单选
   */
  multiple?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  needDetail?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1：不打印，0：打印
   */
  notPrint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:不需要大写, 空或者0:需要大写
   */
  notUpper?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：是
   */
  payEnable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 关联表单 1：引用，0：拷贝
   */
  quote?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 文本控件、选项控件等限制文本字数ratio
   */
  ratio?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  relateSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：必填
   */
  required?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：不可修改
   */
  requiredEditableFreeze?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  rule?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule[];
  /**
   * @remarks
   * This parameter is required.
   */
  sortable?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 选项控件spread
   */
  spread?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 明细填写方式 table：表格，list：列表
   */
  tableViewMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true：纵向，false：横向
   */
  verticalPrint?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 是否水印照片 true：是，false：否
   */
  watermark?: boolean;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      align: 'align',
      availableTemplates: 'availableTemplates',
      behaviorLinkage: 'behaviorLinkage',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      dataSource: 'dataSource',
      defaultColor: 'defaultColor',
      disabled: 'disabled',
      duration: 'duration',
      durationLabel: 'durationLabel',
      fieldId: 'fieldId',
      fields: 'fields',
      format: 'format',
      formula: 'formula',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      limit: 'limit',
      link: 'link',
      mode: 'mode',
      multi: 'multi',
      multiple: 'multiple',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      quote: 'quote',
      ratio: 'ratio',
      relateSource: 'relateSource',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      rule: 'rule',
      sortable: 'sortable',
      spread: 'spread',
      statField: 'statField',
      tableViewMode: 'tableViewMode',
      unit: 'unit',
      verticalPrint: 'verticalPrint',
      watermark: 'watermark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      align: 'string',
      availableTemplates: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates },
      behaviorLinkage: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage },
      bizAlias: 'string',
      choice: 'number',
      content: 'string',
      dataSource: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource,
      defaultColor: 'string',
      disabled: 'boolean',
      duration: 'boolean',
      durationLabel: 'string',
      fieldId: 'string',
      fields: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields },
      format: 'string',
      formula: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      limit: 'number',
      link: 'string',
      mode: 'string',
      multi: 'number',
      multiple: 'boolean',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      quote: 'number',
      ratio: 'number',
      relateSource: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource },
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      rule: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule },
      sortable: 'boolean',
      spread: 'boolean',
      statField: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField },
      tableViewMode: 'string',
      unit: 'string',
      verticalPrint: 'boolean',
      watermark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItems extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  children?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren[];
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren },
      componentName: 'string',
      props: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DescribeRelationMetaResponseBodyRelationMetaDTOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 企业客户表
   */
  desc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  items?: DescribeRelationMetaResponseBodyRelationMetaDTOListItems[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 企业客户
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationMetaCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  relationMetaStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * crm_customer
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      desc: 'desc',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      items: 'items',
      name: 'name',
      relationMetaCode: 'relationMetaCode',
      relationMetaStatus: 'relationMetaStatus',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      desc: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      items: { 'type': 'array', 'itemType': DescribeRelationMetaResponseBodyRelationMetaDTOListItems },
      name: 'string',
      relationMetaCode: 'string',
      relationMetaStatus: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent extends $tea.Model {
  /**
   * @example
   * follow_record_related_content
   */
  bizAlias?: string;
  /**
   * @example
   * 扩展value
   */
  extendValue?: string;
  /**
   * @example
   * TextareaField-K2U5UJAF
   */
  key?: string;
  /**
   * @example
   * 重点跟进
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      extendValue: 'extendValue',
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      extendValue: 'string',
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsResponseBodyResultResultList extends $tea.Model {
  /**
   * @example
   * manager7617
   */
  creatorUserId?: string;
  followContent?: FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent[];
  /**
   * @example
   * customerId
   */
  followTargetDataId?: string;
  /**
   * @example
   * customer
   */
  followTargetType?: string;
  /**
   * @example
   * 1712629910168
   */
  gmtCreateMilliseconds?: string;
  /**
   * @example
   * 1712629910168
   */
  gmtModifiedMilliseconds?: string;
  /**
   * @example
   * manager7617
   */
  modifierUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * _aFFogIuRrWlL3hLdvbb5w09951712629910
   */
  recordInstId?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      followContent: 'followContent',
      followTargetDataId: 'followTargetDataId',
      followTargetType: 'followTargetType',
      gmtCreateMilliseconds: 'gmtCreateMilliseconds',
      gmtModifiedMilliseconds: 'gmtModifiedMilliseconds',
      modifierUserId: 'modifierUserId',
      recordInstId: 'recordInstId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      followContent: { 'type': 'array', 'itemType': FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent },
      followTargetDataId: 'string',
      followTargetType: 'string',
      gmtCreateMilliseconds: 'string',
      gmtModifiedMilliseconds: 'string',
      modifierUserId: 'string',
      recordInstId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FindTargetRelatedFollowRecordsResponseBodyResult extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * 1000
   */
  nextToken?: string;
  resultList?: FindTargetRelatedFollowRecordsResponseBodyResultResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      resultList: 'resultList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      resultList: { 'type': 'array', 'itemType': FindTargetRelatedFollowRecordsResponseBodyResultResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllCustomerRecyclesResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  customerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-03-24T09:30Z
   */
  followUpActionTime?: string;
  isDeleted?: boolean;
  /**
   * @example
   * 2022-03-24T09:30Z
   */
  notifyTime?: string;
  recycleRuleId?: number;
  /**
   * @example
   * 2022-03-24T09:30Z
   */
  recycleTime?: string;
  static names(): { [key: string]: string } {
    return {
      customerId: 'customerId',
      followUpActionTime: 'followUpActionTime',
      isDeleted: 'isDeleted',
      notifyTime: 'notifyTime',
      recycleRuleId: 'recycleRuleId',
      recycleTime: 'recycleTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerId: 'string',
      followUpActionTime: 'string',
      isDeleted: 'boolean',
      notifyTime: 'string',
      recycleRuleId: 'number',
      recycleTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsResponseBodyResultValuesPermission extends $tea.Model {
  ownerUserIds?: string[];
  participantUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerUserIds: 'ownerUserIds',
      participantUserIds: 'participantUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerUserIds: { 'type': 'array', 'itemType': 'string' },
      participantUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsResponseBodyResultValues extends $tea.Model {
  /**
   * @example
   * user01
   */
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  /**
   * @example
   * 2023-11-25 15:33:12
   */
  gmtCreate?: string;
  /**
   * @example
   * 20123-12-25 15:33:12
   */
  gmtModified?: string;
  /**
   * @example
   * INST_XX
   */
  instanceId?: string;
  /**
   * @example
   * crm_contact
   */
  objectType?: string;
  permission?: GetContactsResponseBodyResultValuesPermission;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      objectType: 'objectType',
      permission: 'permission',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gmtCreate: 'string',
      gmtModified: 'string',
      instanceId: 'string',
      objectType: 'string',
      permission: GetContactsResponseBodyResultValuesPermission,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactsResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: string;
  values?: GetContactsResponseBodyResultValues[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': GetContactsResponseBodyResultValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmGroupChatMultiResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 1642078998377
   */
  gmtCreate?: number;
  /**
   * @example
   * https://static/xx.com/xx.jpg
   */
  iconUrl?: string;
  /**
   * @example
   * 12
   */
  memberCount?: number;
  /**
   * @example
   * 营销1群
   */
  name?: string;
  /**
   * @example
   * xx==
   */
  openConversationId?: string;
  /**
   * @example
   * xxa==
   */
  openGroupSetId?: string;
  /**
   * @example
   * axaf12
   */
  ownerUserId?: string;
  /**
   * @example
   * XX
   */
  ownerUserName?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      iconUrl: 'iconUrl',
      memberCount: 'memberCount',
      name: 'name',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      ownerUserName: 'ownerUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'number',
      iconUrl: 'string',
      memberCount: 'number',
      name: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      ownerUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsFieldScopes extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldActions?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "DDSelectField-KI5S975E"
   */
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      fieldActions: 'fieldActions',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldActions: { 'type': 'array', 'itemType': 'string' },
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  deptIdList?: number[];
  /**
   * @remarks
   * This parameter is required.
   */
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIdList: 'deptIdList',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  ext?: GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false 如果是主管，要做逻辑的单独处理。比如如果设置了管理下属或当前部门，只管理他是主管的部门
   */
  manager?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10_own 自己负责的 15_all_org 全公司 20_selfDept 同层级 30_selfSubDept 下属的 40_customized 自定义的
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      ext: 'ext',
      manager: 'manager',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ext: GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt,
      manager: 'boolean',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsOperateScopes extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasAuth?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * * 操作类型      * 发起：OPERATE_CREATE      * 查看：OPERATE_VIEW      * 编辑：OPERATE_EDIT      * 删除：OPERATE_DELETE      * 打印：OPERATE_PRINT      * 分配：ASSIGN      * 转交：TRANS      * 导入：IMPORT      * 导出：EXPORT
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      hasAuth: 'hasAuth',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasAuth: 'boolean',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 可以是员工 uid，可以是部门 ID 等，根据 type 确定
   */
  memberId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user：组织成员   dept：部门   tag：标签  org：组织     org_res_admin：组织管理员
   */
  type?: string;
  /**
   * @example
   * manager1234
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      name: 'name',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      name: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCrmRolePermissionResponseBodyPermissions extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  defaultRole?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldScopes?: GetCrmRolePermissionResponseBodyPermissionsFieldScopes[];
  /**
   * @remarks
   * This parameter is required.
   */
  managingScopeList?: GetCrmRolePermissionResponseBodyPermissionsManagingScopeList[];
  /**
   * @remarks
   * This parameter is required.
   */
  operateScopes?: GetCrmRolePermissionResponseBodyPermissionsOperateScopes[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-478E50CA-856C-4C08-B806-E664D4CEC8C4
   */
  resourceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12821738
   */
  roleId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  roleMemberList?: GetCrmRolePermissionResponseBodyPermissionsRoleMemberList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 销售权限组
   */
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      defaultRole: 'defaultRole',
      fieldScopes: 'fieldScopes',
      managingScopeList: 'managingScopeList',
      operateScopes: 'operateScopes',
      resourceId: 'resourceId',
      roleId: 'roleId',
      roleMemberList: 'roleMemberList',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultRole: 'boolean',
      fieldScopes: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsFieldScopes },
      managingScopeList: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsManagingScopeList },
      operateScopes: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsOperateScopes },
      resourceId: 'string',
      roleId: 'number',
      roleMemberList: { 'type': 'array', 'itemType': GetCrmRolePermissionResponseBodyPermissionsRoleMemberList },
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo extends $tea.Model {
  appName?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerTracksByRelationIdResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 华佗
   */
  creatorName?: string;
  detail?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * markdown
   */
  format?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-03-24T09:30Z
   */
  gmtCreate?: string;
  /**
   * @example
   * dadf134234
   */
  id?: string;
  isvInfo?: GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo;
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 201
   */
  type?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  typeGroup?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      creatorName: 'creatorName',
      detail: 'detail',
      format: 'format',
      gmtCreate: 'gmtCreate',
      id: 'id',
      isvInfo: 'isvInfo',
      title: 'title',
      type: 'type',
      typeGroup: 'typeGroup',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      creatorName: 'string',
      detail: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      format: 'string',
      gmtCreate: 'string',
      id: 'string',
      isvInfo: GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo,
      title: 'string',
      type: 'number',
      typeGroup: 'number',
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

export class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo extends $tea.Model {
  /**
   * @example
   * GOODS-002
   */
  goodsCode?: string;
  /**
   * @example
   * https://yyy
   */
  originalUrl?: string;
  /**
   * @example
   * https://xxx
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      goodsCode: 'goodsCode',
      originalUrl: 'originalUrl',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsCode: 'string',
      originalUrl: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia extends $tea.Model {
  /**
   * @example
   * image
   */
  mediaType?: string;
  /**
   * @example
   * https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/banner/进销存封面.png
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      mediaType: 'mediaType',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaType: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo extends $tea.Model {
  /**
   * @example
   * GOODS-2120
   */
  goodsCode?: string;
  /**
   * @example
   * https://yyy
   */
  originalUrl?: string;
  /**
   * @example
   * https://xxx
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      goodsCode: 'goodsCode',
      originalUrl: 'originalUrl',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsCode: 'string',
      originalUrl: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList extends $tea.Model {
  applicableVersion?: string[];
  applyNum?: number;
  belongIndustry?: string[];
  /**
   * @example
   * psi
   */
  goodsId?: string;
  /**
   * @example
   * app_function
   */
  goodsType?: string;
  /**
   * @example
   * https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/icon/进销存.png
   */
  icon?: string;
  mainOperationInfo?: GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo;
  media?: GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia[];
  /**
   * @example
   * 10000
   */
  price?: string;
  subOperationInfo?: GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo;
  /**
   * @example
   * 通过进销存管理，连接企业人、财、物，一站式解决进销存仓库管理难题。让货品成本有据可依，避免盲目采购；合理控制库存，防止滞销/脱销；通过往来对账确保资金安全。
   */
  subTitle?: string;
  tag?: string[];
  /**
   * @example
   * 进销存
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      applicableVersion: 'applicableVersion',
      applyNum: 'applyNum',
      belongIndustry: 'belongIndustry',
      goodsId: 'goodsId',
      goodsType: 'goodsType',
      icon: 'icon',
      mainOperationInfo: 'mainOperationInfo',
      media: 'media',
      price: 'price',
      subOperationInfo: 'subOperationInfo',
      subTitle: 'subTitle',
      tag: 'tag',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applicableVersion: { 'type': 'array', 'itemType': 'string' },
      applyNum: 'number',
      belongIndustry: { 'type': 'array', 'itemType': 'string' },
      goodsId: 'string',
      goodsType: 'string',
      icon: 'string',
      mainOperationInfo: GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo,
      media: { 'type': 'array', 'itemType': GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia },
      price: 'string',
      subOperationInfo: GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo,
      subTitle: 'string',
      tag: { 'type': 'array', 'itemType': 'string' },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppPurchaseGoodsResponseBodyResult extends $tea.Model {
  /**
   * @example
   * free
   */
  orderVersion?: string;
  purchaseGoodsList?: GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList[];
  static names(): { [key: string]: string } {
    return {
      orderVersion: 'orderVersion',
      purchaseGoodsList: 'purchaseGoodsList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderVersion: 'string',
      purchaseGoodsList: { 'type': 'array', 'itemType': GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNavigationCatalogResponseBodyResultNavCatalog extends $tea.Model {
  children?: any;
  navCode?: string;
  navId?: string;
  navName?: string;
  navType?: string;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      navCode: 'navCode',
      navId: 'navId',
      navName: 'navName',
      navType: 'navType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: 'any',
      navCode: 'string',
      navId: 'string',
      navName: 'string',
      navType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNavigationCatalogResponseBodyResult extends $tea.Model {
  bizTraceId?: string;
  module?: string;
  navCatalog?: GetNavigationCatalogResponseBodyResultNavCatalog[];
  static names(): { [key: string]: string } {
    return {
      bizTraceId: 'bizTraceId',
      module: 'module',
      navCatalog: 'navCatalog',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTraceId: 'string',
      module: 'string',
      navCatalog: { 'type': 'array', 'itemType': GetNavigationCatalogResponseBodyResultNavCatalog },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataResponseBodyResultValuesPermission extends $tea.Model {
  ownerUserIds?: string[];
  participantUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      ownerUserIds: 'ownerUserIds',
      participantUserIds: 'participantUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerUserIds: { 'type': 'array', 'itemType': 'string' },
      participantUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataResponseBodyResultValues extends $tea.Model {
  /**
   * @example
   * 张xx
   */
  creatorNick?: string;
  /**
   * @example
   * user01
   */
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  /**
   * @example
   * 2023-11-25 15:33:12
   */
  gmtCreate?: string;
  /**
   * @example
   * 2023-12-25 15:33:12
   */
  gmtModified?: string;
  /**
   * @example
   * INST_XX
   */
  instanceId?: string;
  /**
   * @example
   * crm_contact
   */
  objectType?: string;
  permission?: GetObjectDataResponseBodyResultValuesPermission;
  /**
   * @example
   * COMPLETE
   */
  procInstStatus?: string;
  /**
   * @example
   * agree
   */
  procOutResult?: string;
  static names(): { [key: string]: string } {
    return {
      creatorNick: 'creatorNick',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      objectType: 'objectType',
      permission: 'permission',
      procInstStatus: 'procInstStatus',
      procOutResult: 'procOutResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorNick: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gmtCreate: 'string',
      gmtModified: 'string',
      instanceId: 'string',
      objectType: 'string',
      permission: GetObjectDataResponseBodyResultValuesPermission,
      procInstStatus: 'string',
      procOutResult: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetObjectDataResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: string;
  values?: GetObjectDataResponseBodyResultValues[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': GetObjectDataResponseBodyResultValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBodyValuesContactsPermission extends $tea.Model {
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

export class GetOfficialAccountContactsResponseBodyValuesContacts extends $tea.Model {
  /**
   * @example
   * 2019-12-25 15:33:12
   */
  createTime?: string;
  /**
   * @example
   * 张三
   */
  creatorNick?: string;
  /**
   * @example
   * ding_userid
   */
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  /**
   * @example
   * instance_id
   */
  instanceId?: string;
  /**
   * @example
   * 2019-12-25 15:33:12
   */
  modifyTime?: string;
  permission?: GetOfficialAccountContactsResponseBodyValuesContactsPermission;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      creatorNick: 'creatorNick',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      instanceId: 'instanceId',
      modifyTime: 'modifyTime',
      permission: 'permission',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      creatorNick: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      instanceId: 'string',
      modifyTime: 'string',
      permission: GetOfficialAccountContactsResponseBodyValuesContactsPermission,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountContactsResponseBodyValues extends $tea.Model {
  contacts?: GetOfficialAccountContactsResponseBodyValuesContacts[];
  /**
   * @example
   * user_id
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      contacts: 'contacts',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contacts: { 'type': 'array', 'itemType': GetOfficialAccountContactsResponseBodyValuesContacts },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountOTOMessageResultResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  readUserIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      readUserIdList: 'readUserIdList',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readUserIdList: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataResponseBodyResultPageList extends $tea.Model {
  /**
   * @example
   * 西游四人组:孙悟空
   */
  abstractMessage?: string;
  createTime?: number;
  /**
   * @example
   * 王凯提交的楚衣的流程表单2
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      abstractMessage: 'abstractMessage',
      createTime: 'createTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      abstractMessage: 'string',
      createTime: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataResponseBodyResultPage extends $tea.Model {
  hasMore?: boolean;
  list?: GetRelatedViewTabDataResponseBodyResultPageList[];
  /**
   * @example
   * 10
   */
  nextToken?: number;
  /**
   * @example
   * 5
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': GetRelatedViewTabDataResponseBodyResultPageList },
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabDataResponseBodyResult extends $tea.Model {
  page?: GetRelatedViewTabDataResponseBodyResultPage;
  static names(): { [key: string]: string } {
    return {
      page: 'page',
    };
  }

  static types(): { [key: string]: any } {
    return {
      page: GetRelatedViewTabDataResponseBodyResultPage,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedViewTabMetaResponseBodyResults extends $tea.Model {
  /**
   * @example
   * PROC-4EFE895D-A291-4A65-9FD6-99431604DF67
   */
  formCode?: string;
  /**
   * @example
   * OpenDataField_K99RPMMRGJ40
   */
  relateComponentId?: string;
  /**
   * @example
   * 212
   */
  tabTitle?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      relateComponentId: 'relateComponentId',
      tabTitle: 'tabTitle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      relateComponentId: 'string',
      tabTitle: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelationUkSettingResponseBodyResult extends $tea.Model {
  /**
   * @example
   * customer_name
   */
  bizAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TextField_U2K5A122
   */
  fieldId?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      fieldId: 'fieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      fieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class JoinGroupSetRequestBizDataList extends $tea.Model {
  /**
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @example
   * customer_name
   */
  key?: string;
  /**
   * @example
   * abc123
   */
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

export class ListAvailableBenefitResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B_ACCOUNT_NUMBER
   */
  benefitCode?: string;
  /**
   * @example
   * 1718696461851
   */
  endTime?: number;
  /**
   * @example
   * 200
   */
  quota?: number;
  /**
   * @example
   * 1718696461851
   */
  startTime?: number;
  /**
   * @example
   * 10
   */
  usedQuota?: number;
  /**
   * @example
   * tryout
   */
  version?: string;
  /**
   * @example
   * 试用版
   */
  versionName?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      endTime: 'endTime',
      quota: 'quota',
      startTime: 'startTime',
      usedQuota: 'usedQuota',
      version: 'version',
      versionName: 'versionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      endTime: 'number',
      quota: 'number',
      startTime: 'number',
      usedQuota: 'number',
      version: 'string',
      versionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBenefitLicenseResponseBodyResultLicenses extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * staffId
   */
  licenseUserId?: string;
  static names(): { [key: string]: string } {
    return {
      licenseUserId: 'licenseUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      licenseUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBenefitLicenseResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B_ACCOUNT_NUMBER
   */
  domain?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  licenses?: ListBenefitLicenseResponseBodyResultLicenses[];
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      licenses: 'licenses',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      licenses: { 'type': 'array', 'itemType': ListBenefitLicenseResponseBodyResultLicenses },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListClueTagResponseBodyResult extends $tea.Model {
  name?: string;
  tagId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      tagId: 'tagId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      tagId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCrmPersonalCustomersResponseBodyResultPermission extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  ownerStaffIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  appUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  creatorNick?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  data?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  extendData?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  instanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  objectType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  permission?: ListCrmPersonalCustomersResponseBodyResultPermission;
  /**
   * @remarks
   * This parameter is required.
   */
  procInstStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  procOutResult?: string;
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      creatorNick: 'creatorNick',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      formCode: 'formCode',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      objectType: 'objectType',
      permission: 'permission',
      procInstStatus: 'procInstStatus',
      procOutResult: 'procOutResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      creatorNick: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formCode: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      instanceId: 'string',
      objectType: 'string',
      permission: ListCrmPersonalCustomersResponseBodyResultPermission,
      procInstStatus: 'string',
      procOutResult: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupSetResponseBodyResultListManager extends $tea.Model {
  /**
   * @example
   * XX
   */
  name?: string;
  /**
   * @example
   * afs1
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

export class ListGroupSetResponseBodyResultListOwner extends $tea.Model {
  /**
   * @example
   * XX
   */
  name?: string;
  /**
   * @example
   * afsd12
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

export class ListGroupSetResponseBodyResultList extends $tea.Model {
  /**
   * @example
   * 2021-12-23T13:00Z
   */
  gmtCreate?: string;
  /**
   * @example
   * 2021-12-23T13:00Z
   */
  gmtModified?: string;
  /**
   * @example
   * 10
   */
  groupChatCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123agsg
   */
  lastOpenConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  manager?: ListGroupSetResponseBodyResultListManager[];
  /**
   * @example
   * afsd12,afsd13
   */
  managerUserIds?: string;
  /**
   * @example
   * 10
   */
  memberCount?: number;
  /**
   * @example
   * 100
   */
  memberQuota?: number;
  /**
   * @example
   * 营销群
   */
  name?: string;
  /**
   * @example
   * 群公告
   */
  notice?: string;
  /**
   * @example
   * 0
   */
  noticeToped?: number;
  /**
   * @example
   * adfads
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  owner?: ListGroupSetResponseBodyResultListOwner;
  /**
   * @example
   * afsd12
   */
  ownerUserId?: string;
  /**
   * @example
   * crm_customer_personal
   */
  relationType?: string;
  /**
   * @example
   * sfasgsab
   */
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      groupChatCount: 'groupChatCount',
      lastOpenConversationId: 'lastOpenConversationId',
      manager: 'manager',
      managerUserIds: 'managerUserIds',
      memberCount: 'memberCount',
      memberQuota: 'memberQuota',
      name: 'name',
      notice: 'notice',
      noticeToped: 'noticeToped',
      openGroupSetId: 'openGroupSetId',
      owner: 'owner',
      ownerUserId: 'ownerUserId',
      relationType: 'relationType',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      groupChatCount: 'number',
      lastOpenConversationId: 'string',
      manager: { 'type': 'array', 'itemType': ListGroupSetResponseBodyResultListManager },
      managerUserIds: 'string',
      memberCount: 'number',
      memberQuota: 'number',
      name: 'string',
      notice: 'string',
      noticeToped: 'number',
      openGroupSetId: 'string',
      owner: ListGroupSetResponseBodyResultListOwner,
      ownerUserId: 'string',
      relationType: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResultValuesPermission extends $tea.Model {
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

export class QueryAllCustomerResponseBodyResultValues extends $tea.Model {
  /**
   * @example
   * 2019-12-25 15:33:12
   */
  createTime?: string;
  /**
   * @example
   * 张三
   */
  creatorNick?: string;
  /**
   * @example
   * ding_userid
   */
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  /**
   * @example
   * instance_id
   */
  instanceId?: string;
  /**
   * @example
   * 2019-12-25 15:33:12
   */
  modifyTime?: string;
  /**
   * @example
   * crm_customer
   */
  objectType?: string;
  permission?: QueryAllCustomerResponseBodyResultValuesPermission;
  /**
   * @example
   * COMPLATE
   */
  processInstanceStatus?: string;
  /**
   * @example
   * agree
   */
  processOutResult?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      creatorNick: 'creatorNick',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      instanceId: 'instanceId',
      modifyTime: 'modifyTime',
      objectType: 'objectType',
      permission: 'permission',
      processInstanceStatus: 'processInstanceStatus',
      processOutResult: 'processOutResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      creatorNick: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      instanceId: 'string',
      modifyTime: 'string',
      objectType: 'string',
      permission: QueryAllCustomerResponseBodyResultValuesPermission,
      processInstanceStatus: 'string',
      processOutResult: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 100
   */
  nextToken?: string;
  values?: QueryAllCustomerResponseBodyResultValues[];
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': QueryAllCustomerResponseBodyResultValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllTracksResponseBodyValues extends $tea.Model {
  /**
   * @example
   * 1234
   */
  bizId?: string;
  /**
   * @example
   * manager1234
   */
  creator?: string;
  /**
   * @example
   * customer_id
   */
  customerId?: string;
  /**
   * @example
   * 1237126786127
   */
  gmtCreate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * asjkdh189127836
   */
  id?: string;
  /**
   * @example
   * 4
   */
  subType?: number;
  /**
   * @example
   * 80
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      creator: 'creator',
      customerId: 'customerId',
      gmtCreate: 'gmtCreate',
      id: 'id',
      subType: 'subType',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      creator: 'string',
      customerId: 'string',
      gmtCreate: 'number',
      id: 'string',
      subType: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppManagerResponseBodyResult extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitInventoryResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 2000
   */
  totalQuota?: number;
  /**
   * @example
   * 10
   */
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      totalQuota: 'totalQuota',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalQuota: 'number',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClueFollowStatusResponseBodyResult extends $tea.Model {
  clueId?: string;
  scope?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      clueId: 'clueId',
      scope: 'scope',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clueId: 'string',
      scope: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupChatsResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1640239655539
   */
  gmtCreate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  memberCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 营销1群
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * afsad21
   */
  openConversationId?: string;
  /**
   * @example
   * afsdba23
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * afds12
   */
  ownerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX
   */
  ownerUserName?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      memberCount: 'memberCount',
      name: 'name',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      ownerUserId: 'ownerUserId',
      ownerUserName: 'ownerUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'number',
      memberCount: 'number',
      name: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      ownerUserId: 'string',
      ownerUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmPersonalCustomerResponseBodyValuesPermission extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  ownerStaffIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  creatorNick?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  data?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  extendData?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  instanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  objectType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  permission?: QueryCrmPersonalCustomerResponseBodyValuesPermission;
  /**
   * @remarks
   * This parameter is required.
   */
  procInstStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  procOutResult?: string;
  static names(): { [key: string]: string } {
    return {
      creatorNick: 'creatorNick',
      creatorUserId: 'creatorUserId',
      data: 'data',
      extendData: 'extendData',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      instanceId: 'instanceId',
      objectType: 'objectType',
      permission: 'permission',
      procInstStatus: 'procInstStatus',
      procOutResult: 'procOutResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorNick: 'string',
      creatorUserId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gmtCreate: 'string',
      gmtModified: 'string',
      instanceId: 'string',
      objectType: 'string',
      permission: QueryCrmPersonalCustomerResponseBodyValuesPermission,
      procInstStatus: 'string',
      procOutResult: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerBizTypeResponseBodyResult extends $tea.Model {
  /**
   * @example
   * crm_customer
   */
  customerBizType?: string;
  static names(): { [key: string]: string } {
    return {
      customerBizType: 'customerBizType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerBizType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGlobalInfoResponseBodyResult extends $tea.Model {
  oemEnable?: boolean;
  static names(): { [key: string]: string } {
    return {
      oemEnable: 'oemEnable',
    };
  }

  static types(): { [key: string]: any } {
    return {
      oemEnable: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialAccountUserBasicInfoResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FOLLOWED
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {}
   */
  extendValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * customer_name
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
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

export class QueryRelationDatasByTargetIdResponseBodyRelations extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizDataList?: QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList[];
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  relationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc123
   */
  relationType?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      openConversationIds: 'openConversationIds',
      relationId: 'relationId',
      relationType: 'relationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList },
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      relationId: 'string',
      relationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseRequestLicenses extends $tea.Model {
  /**
   * @example
   * licenseStaffId
   */
  licenseUserId?: string;
  static names(): { [key: string]: string } {
    return {
      licenseUserId: 'licenseUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      licenseUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseResponseBodyResultLicenses extends $tea.Model {
  /**
   * @example
   * license账号信息
   */
  licenseUserId?: string;
  static names(): { [key: string]: string } {
    return {
      licenseUserId: 'licenseUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      licenseUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBenefitLicenseResponseBodyResult extends $tea.Model {
  /**
   * @example
   * B_ACCOUNT_NUMBER
   */
  domain?: string;
  licenses?: SaveBenefitLicenseResponseBodyResultLicenses[];
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      licenses: 'licenses',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      licenses: { 'type': 'array', 'itemType': SaveBenefitLicenseResponseBodyResultLicenses },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  actionUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionUrl: 'actionUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList[];
  buttonOrientation?: string;
  markdown?: string;
  singleTitle?: string;
  singleUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      buttonList: 'buttonList',
      buttonOrientation: 'buttonOrientation',
      markdown: 'markdown',
      singleTitle: 'singleTitle',
      singleUrl: 'singleUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonList: { 'type': 'array', 'itemType': SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList },
      buttonOrientation: 'string',
      markdown: 'string',
      singleTitle: 'string',
      singleUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyImage extends $tea.Model {
  /**
   * @example
   * @lALPBbCc1XuaP_rNAljNAl
   */
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  picUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  text?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      messageUrl: 'messageUrl',
      picUrl: 'picUrl',
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageUrl: 'string',
      picUrl: 'string',
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  text?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyText extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class SendOfficialAccountOTOMessageRequestDetailMessageBody extends $tea.Model {
  actionCard?: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard;
  image?: SendOfficialAccountOTOMessageRequestDetailMessageBodyImage;
  link?: SendOfficialAccountOTOMessageRequestDetailMessageBodyLink;
  markdown?: SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown;
  text?: SendOfficialAccountOTOMessageRequestDetailMessageBodyText;
  static names(): { [key: string]: string } {
    return {
      actionCard: 'actionCard',
      image: 'image',
      link: 'link',
      markdown: 'markdown',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCard: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard,
      image: SendOfficialAccountOTOMessageRequestDetailMessageBodyImage,
      link: SendOfficialAccountOTOMessageRequestDetailMessageBodyLink,
      markdown: SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown,
      text: SendOfficialAccountOTOMessageRequestDetailMessageBodyText,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageRequestDetail extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageBody?: SendOfficialAccountOTOMessageRequestDetailMessageBody;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  msgType?: string;
  unionId?: string;
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      messageBody: 'messageBody',
      msgType: 'msgType',
      unionId: 'unionId',
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageBody: SendOfficialAccountOTOMessageRequestDetailMessageBody,
      msgType: 'string',
      unionId: 'string',
      userId: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountOTOMessageResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  actionUrl?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionUrl: 'actionUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList[];
  buttonOrientation?: string;
  markdown?: string;
  singleTitle?: string;
  singleUrl?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      buttonList: 'buttonList',
      buttonOrientation: 'buttonOrientation',
      markdown: 'markdown',
      singleTitle: 'singleTitle',
      singleUrl: 'singleUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonList: { 'type': 'array', 'itemType': SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList },
      buttonOrientation: 'string',
      markdown: 'string',
      singleTitle: 'string',
      singleUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyLink extends $tea.Model {
  messageUrl?: string;
  picUrl?: string;
  text?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      messageUrl: 'messageUrl',
      picUrl: 'picUrl',
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageUrl: 'string',
      picUrl: 'string',
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  text?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      title: 'string',
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

export class SendOfficialAccountSNSMessageRequestDetailMessageBody extends $tea.Model {
  actionCard?: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard;
  link?: SendOfficialAccountSNSMessageRequestDetailMessageBodyLink;
  markdown?: SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown;
  text?: SendOfficialAccountSNSMessageRequestDetailMessageBodyText;
  static names(): { [key: string]: string } {
    return {
      actionCard: 'actionCard',
      link: 'link',
      markdown: 'markdown',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCard: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard,
      link: SendOfficialAccountSNSMessageRequestDetailMessageBodyLink,
      markdown: SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown,
      text: SendOfficialAccountSNSMessageRequestDetailMessageBodyText,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageRequestDetail extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageBody?: SendOfficialAccountSNSMessageRequestDetailMessageBody;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  msgType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      messageBody: 'messageBody',
      msgType: 'msgType',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageBody: SendOfficialAccountSNSMessageRequestDetailMessageBody,
      msgType: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOfficialAccountSNSMessageResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  actionUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionUrl: 'actionUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList[];
  buttonOrientation?: string;
  markdown?: string;
  singleTitle?: string;
  singleUrl?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      buttonList: 'buttonList',
      buttonOrientation: 'buttonOrientation',
      markdown: 'markdown',
      singleTitle: 'singleTitle',
      singleUrl: 'singleUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonList: { 'type': 'array', 'itemType': ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList },
      buttonOrientation: 'string',
      markdown: 'string',
      singleTitle: 'string',
      singleUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyLink extends $tea.Model {
  messageUrl?: string;
  picUrl?: string;
  text?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      messageUrl: 'messageUrl',
      picUrl: 'picUrl',
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageUrl: 'string',
      picUrl: 'string',
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  text?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetailMessageBodyText extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class ServiceWindowMessageBatchPushRequestDetailMessageBody extends $tea.Model {
  actionCard?: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard;
  link?: ServiceWindowMessageBatchPushRequestDetailMessageBodyLink;
  markdown?: ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown;
  text?: ServiceWindowMessageBatchPushRequestDetailMessageBodyText;
  static names(): { [key: string]: string } {
    return {
      actionCard: 'actionCard',
      link: 'link',
      markdown: 'markdown',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCard: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard,
      link: ServiceWindowMessageBatchPushRequestDetailMessageBodyLink,
      markdown: ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown,
      text: ServiceWindowMessageBatchPushRequestDetailMessageBodyText,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushRequestDetail extends $tea.Model {
  /**
   * **if can be null:**
   * false
   */
  bizRequestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  messageBody?: ServiceWindowMessageBatchPushRequestDetailMessageBody;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * true
   */
  msgType?: string;
  sendToAll?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  userIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * true
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      bizRequestId: 'bizRequestId',
      messageBody: 'messageBody',
      msgType: 'msgType',
      sendToAll: 'sendToAll',
      userIdList: 'userIdList',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizRequestId: 'string',
      messageBody: ServiceWindowMessageBatchPushRequestDetailMessageBody,
      msgType: 'string',
      sendToAll: 'boolean',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ServiceWindowMessageBatchPushResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class UpdateMenuDataRequestNavDataNavExtInfo extends $tea.Model {
  /**
   * @example
   * oem
   */
  productMode?: string;
  /**
   * @example
   * tj
   */
  provider?: string;
  static names(): { [key: string]: string } {
    return {
      productMode: 'productMode',
      provider: 'provider',
    };
  }

  static types(): { [key: string]: any } {
    return {
      productMode: 'string',
      provider: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMenuDataRequestNavData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  displayStatus?: string;
  /**
   * @example
   * icon-biaodan_baogao
   */
  icon?: string;
  /**
   * @example
   * #CCEEFF
   */
  iconBgColor?: string;
  /**
   * @example
   * #007FFF
   */
  iconColor?: string;
  /**
   * @example
   * same_page
   */
  integrationProtocol?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 库存账单
   */
  mobileNavName?: string;
  /**
   * @example
   * https://tj-ali-crm-test.tangees.com/tungee/crm/mobile/?corpid=dinge18b222ec5637b04ffe93478753d9884#/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?库存流水&psi_stock_flow&fromPage=home
   */
  mobileUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lowcode_customize_form
   */
  navCode?: string;
  navExtInfo?: UpdateMenuDataRequestNavDataNavExtInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lowcode_customize_form:PROC-0279E824-ED47-4E75-86F2-11B665F3704D
   */
  navId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 库存流水
   */
  navName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PUBLISHED
   */
  navStatus?: string;
  /**
   * @example
   * item
   */
  navType?: string;
  /**
   * @example
   * crm_product
   */
  parentNavId?: string;
  /**
   * @example
   * tj
   */
  provider?: string;
  sortNum?: number;
  /**
   * @example
   * /form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?bizType=psi_stock_flow&formName=库存流水
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      displayStatus: 'displayStatus',
      icon: 'icon',
      iconBgColor: 'iconBgColor',
      iconColor: 'iconColor',
      integrationProtocol: 'integrationProtocol',
      mobileNavName: 'mobileNavName',
      mobileUrl: 'mobileUrl',
      navCode: 'navCode',
      navExtInfo: 'navExtInfo',
      navId: 'navId',
      navName: 'navName',
      navStatus: 'navStatus',
      navType: 'navType',
      parentNavId: 'parentNavId',
      provider: 'provider',
      sortNum: 'sortNum',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayStatus: 'string',
      icon: 'string',
      iconBgColor: 'string',
      iconColor: 'string',
      integrationProtocol: 'string',
      mobileNavName: 'string',
      mobileUrl: 'string',
      navCode: 'string',
      navExtInfo: UpdateMenuDataRequestNavDataNavExtInfo,
      navId: 'string',
      navName: 'string',
      navStatus: 'string',
      navType: 'string',
      parentNavId: 'string',
      provider: 'string',
      sortNum: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMetaModelFieldRequestFieldDTOListPropsOptions extends $tea.Model {
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

export class UpdateMetaModelFieldRequestFieldDTOListProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: UpdateMetaModelFieldRequestFieldDTOListPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  requiredEditableFreeze?: boolean;
  sortable?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      sortable: 'sortable',
      unit: 'unit',
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
      fieldId: 'string',
      format: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': UpdateMetaModelFieldRequestFieldDTOListPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      sortable: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMetaModelFieldRequestFieldDTOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  props?: UpdateMetaModelFieldRequestFieldDTOListProps;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      props: UpdateMetaModelFieldRequestFieldDTOListProps,
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
  align?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: UpdateRelationMetaFieldRequestFieldDTOListPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  required?: boolean;
  requiredEditableFreeze?: boolean;
  sortable?: boolean;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      align: 'align',
      bizAlias: 'bizAlias',
      choice: 'choice',
      content: 'content',
      disabled: 'disabled',
      duration: 'duration',
      fieldId: 'fieldId',
      format: 'format',
      invisible: 'invisible',
      label: 'label',
      labelEditableFreeze: 'labelEditableFreeze',
      link: 'link',
      needDetail: 'needDetail',
      notPrint: 'notPrint',
      notUpper: 'notUpper',
      options: 'options',
      payEnable: 'payEnable',
      placeholder: 'placeholder',
      required: 'required',
      requiredEditableFreeze: 'requiredEditableFreeze',
      sortable: 'sortable',
      unit: 'unit',
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
      fieldId: 'string',
      format: 'string',
      invisible: 'boolean',
      label: 'string',
      labelEditableFreeze: 'boolean',
      link: 'string',
      needDetail: 'string',
      notPrint: 'string',
      notUpper: 'string',
      options: { 'type': 'array', 'itemType': UpdateRelationMetaFieldRequestFieldDTOListPropsOptions },
      payEnable: 'boolean',
      placeholder: 'string',
      required: 'boolean',
      requiredEditableFreeze: 'boolean',
      sortable: 'boolean',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRelationMetaFieldRequestFieldDTOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  componentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
   * 从私海放弃客户（退回公海）
   * 
   * @param request - AbandonCustomerRequest
   * @param headers - AbandonCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AbandonCustomerResponse
   */
  async abandonCustomerWithOptions(request: AbandonCustomerRequest, headers: AbandonCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<AbandonCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customTrackDesc)) {
      body["customTrackDesc"] = request.customTrackDesc;
    }

    if (!Util.isUnset(request.instanceIdList)) {
      body["instanceIdList"] = request.instanceIdList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.optType)) {
      body["optType"] = request.optType;
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
      action: "AbandonCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customers/abandon`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AbandonCustomerResponse>(await this.execute(params, req, runtime), new AbandonCustomerResponse({}));
  }

  /**
   * 从私海放弃客户（退回公海）
   * 
   * @param request - AbandonCustomerRequest
   * @returns AbandonCustomerResponse
   */
  async abandonCustomer(request: AbandonCustomerRequest): Promise<AbandonCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AbandonCustomerHeaders({ });
    return await this.abandonCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 添加crm个人客户（或企业客户）
   * 
   * @param request - AddCrmPersonalCustomerRequest
   * @param headers - AddCrmPersonalCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddCrmPersonalCustomerResponse
   */
  async addCrmPersonalCustomerWithOptions(request: AddCrmPersonalCustomerRequest, headers: AddCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<AddCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.creatorNick)) {
      body["creatorNick"] = request.creatorNick;
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

    if (!Util.isUnset(request.permission)) {
      body["permission"] = request.permission;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.skipDuplicateCheck)) {
      body["skipDuplicateCheck"] = request.skipDuplicateCheck;
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
      action: "AddCrmPersonalCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/personalCustomers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddCrmPersonalCustomerResponse>(await this.execute(params, req, runtime), new AddCrmPersonalCustomerResponse({}));
  }

  /**
   * 添加crm个人客户（或企业客户）
   * 
   * @param request - AddCrmPersonalCustomerRequest
   * @returns AddCrmPersonalCustomerResponse
   */
  async addCrmPersonalCustomer(request: AddCrmPersonalCustomerRequest): Promise<AddCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCrmPersonalCustomerHeaders({ });
    return await this.addCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 新增动态
   * 
   * @param request - AddCustomerTrackRequest
   * @param headers - AddCustomerTrackHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddCustomerTrackResponse
   */
  async addCustomerTrackWithOptions(request: AddCustomerTrackRequest, headers: AddCustomerTrackHeaders, runtime: $Util.RuntimeOptions): Promise<AddCustomerTrackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.customerId)) {
      body["customerId"] = request.customerId;
    }

    if (!Util.isUnset(request.extraBizInfo)) {
      body["extraBizInfo"] = request.extraBizInfo;
    }

    if (!Util.isUnset(request.idempotentKey)) {
      body["idempotentKey"] = request.idempotentKey;
    }

    if (!Util.isUnset(request.maskedContent)) {
      body["maskedContent"] = request.maskedContent;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "AddCustomerTrack",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customerTracks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddCustomerTrackResponse>(await this.execute(params, req, runtime), new AddCustomerTrackResponse({}));
  }

  /**
   * 新增动态
   * 
   * @param request - AddCustomerTrackRequest
   * @returns AddCustomerTrackResponse
   */
  async addCustomerTrack(request: AddCustomerTrackRequest): Promise<AddCustomerTrackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCustomerTrackHeaders({ });
    return await this.addCustomerTrackWithOptions(request, headers, runtime);
  }

  /**
   * 添加线索
   * 
   * @param request - AddLeadsRequest
   * @param headers - AddLeadsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddLeadsResponse
   */
  async addLeadsWithOptions(request: AddLeadsRequest, headers: AddLeadsHeaders, runtime: $Util.RuntimeOptions): Promise<AddLeadsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assignTimestamp)) {
      body["assignTimestamp"] = request.assignTimestamp;
    }

    if (!Util.isUnset(request.assignUserId)) {
      body["assignUserId"] = request.assignUserId;
    }

    if (!Util.isUnset(request.assignedUserId)) {
      body["assignedUserId"] = request.assignedUserId;
    }

    if (!Util.isUnset(request.leads)) {
      body["leads"] = request.leads;
    }

    if (!Util.isUnset(request.outTaskId)) {
      body["outTaskId"] = request.outTaskId;
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
      action: "AddLeads",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/leads`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddLeadsResponse>(await this.execute(params, req, runtime), new AddLeadsResponse({}));
  }

  /**
   * 添加线索
   * 
   * @param request - AddLeadsRequest
   * @returns AddLeadsResponse
   */
  async addLeads(request: AddLeadsRequest): Promise<AddLeadsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLeadsHeaders({ });
    return await this.addLeadsWithOptions(request, headers, runtime);
  }

  /**
   * 模型表结构增加字段
   * 
   * @param request - AddMetaModelFieldRequest
   * @param headers - AddMetaModelFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddMetaModelFieldResponse
   */
  async addMetaModelFieldWithOptions(request: AddMetaModelFieldRequest, headers: AddMetaModelFieldHeaders, runtime: $Util.RuntimeOptions): Promise<AddMetaModelFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.fieldDTOList)) {
      body["fieldDTOList"] = request.fieldDTOList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "AddMetaModelField",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/metas/models/fields`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddMetaModelFieldResponse>(await this.execute(params, req, runtime), new AddMetaModelFieldResponse({}));
  }

  /**
   * 模型表结构增加字段
   * 
   * @param request - AddMetaModelFieldRequest
   * @returns AddMetaModelFieldResponse
   */
  async addMetaModelField(request: AddMetaModelFieldRequest): Promise<AddMetaModelFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddMetaModelFieldHeaders({ });
    return await this.addMetaModelFieldWithOptions(request, headers, runtime);
  }

  /**
   * 关系模型表结构增加字段
   * 
   * @param request - AddRelationMetaFieldRequest
   * @param headers - AddRelationMetaFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddRelationMetaFieldResponse
   */
  async addRelationMetaFieldWithOptions(request: AddRelationMetaFieldRequest, headers: AddRelationMetaFieldHeaders, runtime: $Util.RuntimeOptions): Promise<AddRelationMetaFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldDTOList)) {
      body["fieldDTOList"] = request.fieldDTOList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "AddRelationMetaField",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relations/metas/fields`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddRelationMetaFieldResponse>(await this.execute(params, req, runtime), new AddRelationMetaFieldResponse({}));
  }

  /**
   * 关系模型表结构增加字段
   * 
   * @param request - AddRelationMetaFieldRequest
   * @returns AddRelationMetaFieldResponse
   */
  async addRelationMetaField(request: AddRelationMetaFieldRequest): Promise<AddRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRelationMetaFieldHeaders({ });
    return await this.addRelationMetaFieldWithOptions(request, headers, runtime);
  }

  /**
   * 追加客户数据权限
   * 
   * @param request - AppendCustomerDataAuthRequest
   * @param headers - AppendCustomerDataAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AppendCustomerDataAuthResponse
   */
  async appendCustomerDataAuthWithOptions(request: AppendCustomerDataAuthRequest, headers: AppendCustomerDataAuthHeaders, runtime: $Util.RuntimeOptions): Promise<AppendCustomerDataAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customerIds)) {
      body["customerIds"] = request.customerIds;
    }

    if (!Util.isUnset(request.dataAuthUserIds)) {
      body["dataAuthUserIds"] = request.dataAuthUserIds;
    }

    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.roleType)) {
      body["roleType"] = request.roleType;
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
      action: "AppendCustomerDataAuth",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customers/dataAuth/append`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AppendCustomerDataAuthResponse>(await this.execute(params, req, runtime), new AppendCustomerDataAuthResponse({}));
  }

  /**
   * 追加客户数据权限
   * 
   * @param request - AppendCustomerDataAuthRequest
   * @returns AppendCustomerDataAuthResponse
   */
  async appendCustomerDataAuth(request: AppendCustomerDataAuthRequest): Promise<AppendCustomerDataAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendCustomerDataAuthHeaders({ });
    return await this.appendCustomerDataAuthWithOptions(request, headers, runtime);
  }

  /**
   * 批量新增联系人
   * 
   * @param request - BatchAddContactsRequest
   * @param headers - BatchAddContactsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchAddContactsResponse
   */
  async batchAddContactsWithOptions(request: BatchAddContactsRequest, headers: BatchAddContactsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchAddContactsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationList)) {
      body["relationList"] = request.relationList;
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
      action: "BatchAddContacts",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/contacts/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchAddContactsResponse>(await this.execute(params, req, runtime), new BatchAddContactsResponse({}));
  }

  /**
   * 批量新增联系人
   * 
   * @param request - BatchAddContactsRequest
   * @returns BatchAddContactsResponse
   */
  async batchAddContacts(request: BatchAddContactsRequest): Promise<BatchAddContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddContactsHeaders({ });
    return await this.batchAddContactsWithOptions(request, headers, runtime);
  }

  /**
   * 批量新增跟进记录
   * 
   * @param request - BatchAddFollowRecordsRequest
   * @param headers - BatchAddFollowRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchAddFollowRecordsResponse
   */
  async batchAddFollowRecordsWithOptions(request: BatchAddFollowRecordsRequest, headers: BatchAddFollowRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchAddFollowRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceList)) {
      body["instanceList"] = request.instanceList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "BatchAddFollowRecords",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/followRecords/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchAddFollowRecordsResponse>(await this.execute(params, req, runtime), new BatchAddFollowRecordsResponse({}));
  }

  /**
   * 批量新增跟进记录
   * 
   * @param request - BatchAddFollowRecordsRequest
   * @returns BatchAddFollowRecordsResponse
   */
  async batchAddFollowRecords(request: BatchAddFollowRecordsRequest): Promise<BatchAddFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddFollowRecordsHeaders({ });
    return await this.batchAddFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 批量新增关系数据
   * 
   * @param request - BatchAddRelationDatasRequest
   * @param headers - BatchAddRelationDatasHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchAddRelationDatasResponse
   */
  async batchAddRelationDatasWithOptions(request: BatchAddRelationDatasRequest, headers: BatchAddRelationDatasHeaders, runtime: $Util.RuntimeOptions): Promise<BatchAddRelationDatasResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationList)) {
      body["relationList"] = request.relationList;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.skipDuplicateCheck)) {
      body["skipDuplicateCheck"] = request.skipDuplicateCheck;
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
      action: "BatchAddRelationDatas",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relationDatas/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchAddRelationDatasResponse>(await this.execute(params, req, runtime), new BatchAddRelationDatasResponse({}));
  }

  /**
   * 批量新增关系数据
   * 
   * @param request - BatchAddRelationDatasRequest
   * @returns BatchAddRelationDatasResponse
   */
  async batchAddRelationDatas(request: BatchAddRelationDatasRequest): Promise<BatchAddRelationDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddRelationDatasHeaders({ });
    return await this.batchAddRelationDatasWithOptions(request, headers, runtime);
  }

  /**
   * 批量创建线索数据
   * 
   * @param request - BatchCreateClueDataRequest
   * @param headers - BatchCreateClueDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchCreateClueDataResponse
   */
  async batchCreateClueDataWithOptions(request: BatchCreateClueDataRequest, headers: BatchCreateClueDataHeaders, runtime: $Util.RuntimeOptions): Promise<BatchCreateClueDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dataList)) {
      body["dataList"] = request.dataList;
    }

    if (!Util.isUnset(request.privateSeas)) {
      body["privateSeas"] = request.privateSeas;
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
      action: "BatchCreateClueData",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/clues/datas/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchCreateClueDataResponse>(await this.execute(params, req, runtime), new BatchCreateClueDataResponse({}));
  }

  /**
   * 批量创建线索数据
   * 
   * @param request - BatchCreateClueDataRequest
   * @returns BatchCreateClueDataResponse
   */
  async batchCreateClueData(request: BatchCreateClueDataRequest): Promise<BatchCreateClueDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateClueDataHeaders({ });
    return await this.batchCreateClueDataWithOptions(request, headers, runtime);
  }

  /**
   * 批量删除跟进记录
   * 
   * @param request - BatchRemoveFollowRecordsRequest
   * @param headers - BatchRemoveFollowRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRemoveFollowRecordsResponse
   */
  async batchRemoveFollowRecordsWithOptions(request: BatchRemoveFollowRecordsRequest, headers: BatchRemoveFollowRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRemoveFollowRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceIds)) {
      body["instanceIds"] = request.instanceIds;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "BatchRemoveFollowRecords",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/followRecords/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchRemoveFollowRecordsResponse>(await this.execute(params, req, runtime), new BatchRemoveFollowRecordsResponse({}));
  }

  /**
   * 批量删除跟进记录
   * 
   * @param request - BatchRemoveFollowRecordsRequest
   * @returns BatchRemoveFollowRecordsResponse
   */
  async batchRemoveFollowRecords(request: BatchRemoveFollowRecordsRequest): Promise<BatchRemoveFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRemoveFollowRecordsHeaders({ });
    return await this.batchRemoveFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗消息群发
   * 
   * @param request - BatchSendOfficialAccountOTOMessageRequest
   * @param headers - BatchSendOfficialAccountOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchSendOfficialAccountOTOMessageResponse
   */
  async batchSendOfficialAccountOTOMessageWithOptions(request: BatchSendOfficialAccountOTOMessageRequest, headers: BatchSendOfficialAccountOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSendOfficialAccountOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "BatchSendOfficialAccountOTOMessage",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/oToMessages/batchSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchSendOfficialAccountOTOMessageResponse>(await this.execute(params, req, runtime), new BatchSendOfficialAccountOTOMessageResponse({}));
  }

  /**
   * 服务窗消息群发
   * 
   * @param request - BatchSendOfficialAccountOTOMessageRequest
   * @returns BatchSendOfficialAccountOTOMessageResponse
   */
  async batchSendOfficialAccountOTOMessage(request: BatchSendOfficialAccountOTOMessageRequest): Promise<BatchSendOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendOfficialAccountOTOMessageHeaders({ });
    return await this.batchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 批量修改联系人
   * 
   * @param request - BatchUpdateContactsRequest
   * @param headers - BatchUpdateContactsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateContactsResponse
   */
  async batchUpdateContactsWithOptions(request: BatchUpdateContactsRequest, headers: BatchUpdateContactsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateContactsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationList)) {
      body["relationList"] = request.relationList;
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
      action: "BatchUpdateContacts",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/contacts/batch`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateContactsResponse>(await this.execute(params, req, runtime), new BatchUpdateContactsResponse({}));
  }

  /**
   * 批量修改联系人
   * 
   * @param request - BatchUpdateContactsRequest
   * @returns BatchUpdateContactsResponse
   */
  async batchUpdateContacts(request: BatchUpdateContactsRequest): Promise<BatchUpdateContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateContactsHeaders({ });
    return await this.batchUpdateContactsWithOptions(request, headers, runtime);
  }

  /**
   * 批量修改跟进记录
   * 
   * @param request - BatchUpdateFollowRecordsRequest
   * @param headers - BatchUpdateFollowRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateFollowRecordsResponse
   */
  async batchUpdateFollowRecordsWithOptions(request: BatchUpdateFollowRecordsRequest, headers: BatchUpdateFollowRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateFollowRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceList)) {
      body["instanceList"] = request.instanceList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "BatchUpdateFollowRecords",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/followRecords/batch`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateFollowRecordsResponse>(await this.execute(params, req, runtime), new BatchUpdateFollowRecordsResponse({}));
  }

  /**
   * 批量修改跟进记录
   * 
   * @param request - BatchUpdateFollowRecordsRequest
   * @returns BatchUpdateFollowRecordsResponse
   */
  async batchUpdateFollowRecords(request: BatchUpdateFollowRecordsRequest): Promise<BatchUpdateFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateFollowRecordsHeaders({ });
    return await this.batchUpdateFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 批量修改关系数据
   * 
   * @param request - BatchUpdateRelationDatasRequest
   * @param headers - BatchUpdateRelationDatasHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateRelationDatasResponse
   */
  async batchUpdateRelationDatasWithOptions(request: BatchUpdateRelationDatasRequest, headers: BatchUpdateRelationDatasHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateRelationDatasResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationList)) {
      body["relationList"] = request.relationList;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.skipDuplicateCheck)) {
      body["skipDuplicateCheck"] = request.skipDuplicateCheck;
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
      action: "BatchUpdateRelationDatas",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relationDatas/batch`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateRelationDatasResponse>(await this.execute(params, req, runtime), new BatchUpdateRelationDatasResponse({}));
  }

  /**
   * 批量修改关系数据
   * 
   * @param request - BatchUpdateRelationDatasRequest
   * @returns BatchUpdateRelationDatasResponse
   */
  async batchUpdateRelationDatas(request: BatchUpdateRelationDatasRequest): Promise<BatchUpdateRelationDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateRelationDatasHeaders({ });
    return await this.batchUpdateRelationDatasWithOptions(request, headers, runtime);
  }

  /**
   * 核销权益库存
   * 
   * @param request - ConsumeBenefitInventoryRequest
   * @param headers - ConsumeBenefitInventoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConsumeBenefitInventoryResponse
   */
  async consumeBenefitInventoryWithOptions(request: ConsumeBenefitInventoryRequest, headers: ConsumeBenefitInventoryHeaders, runtime: $Util.RuntimeOptions): Promise<ConsumeBenefitInventoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      body["benefitCode"] = request.benefitCode;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      body["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.consumeQuota)) {
      body["consumeQuota"] = request.consumeQuota;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
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
      action: "ConsumeBenefitInventory",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/benefitInventories/consume`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConsumeBenefitInventoryResponse>(await this.execute(params, req, runtime), new ConsumeBenefitInventoryResponse({}));
  }

  /**
   * 核销权益库存
   * 
   * @param request - ConsumeBenefitInventoryRequest
   * @returns ConsumeBenefitInventoryResponse
   */
  async consumeBenefitInventory(request: ConsumeBenefitInventoryRequest): Promise<ConsumeBenefitInventoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsumeBenefitInventoryHeaders({ });
    return await this.consumeBenefitInventoryWithOptions(request, headers, runtime);
  }

  /**
   * CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
   * 
   * @param request - CreateCustomerRequest
   * @param headers - CreateCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateCustomerResponse
   */
  async createCustomerWithOptions(request: CreateCustomerRequest, headers: CreateCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.contacts)) {
      body["contacts"] = request.contacts;
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

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
    }

    if (!Util.isUnset(request.permission)) {
      body["permission"] = request.permission;
    }

    if (!Util.isUnset(request.saveOption)) {
      body["saveOption"] = request.saveOption;
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
      action: "CreateCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCustomerResponse>(await this.execute(params, req, runtime), new CreateCustomerResponse({}));
  }

  /**
   * CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
   * 
   * @param request - CreateCustomerRequest
   * @returns CreateCustomerResponse
   */
  async createCustomer(request: CreateCustomerRequest): Promise<CreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomerHeaders({ });
    return await this.createCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 创建客户群
   * 
   * @param request - CreateGroupRequest
   * @param headers - CreateGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupResponse
   */
  async createGroupWithOptions(request: CreateGroupRequest, headers: CreateGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.memberUserIds)) {
      body["memberUserIds"] = request.memberUserIds;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
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
      action: "CreateGroup",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupResponse>(await this.execute(params, req, runtime), new CreateGroupResponse({}));
  }

  /**
   * 创建客户群
   * 
   * @param request - CreateGroupRequest
   * @returns CreateGroupResponse
   */
  async createGroup(request: CreateGroupRequest): Promise<CreateGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupHeaders({ });
    return await this.createGroupWithOptions(request, headers, runtime);
  }

  /**
   * 创建群组
   * 
   * @param request - CreateGroupSetRequest
   * @param headers - CreateGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupSetResponse
   */
  async createGroupSetWithOptions(request: CreateGroupSetRequest, headers: CreateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUserId)) {
      body["creatorUserId"] = request.creatorUserId;
    }

    if (!Util.isUnset(request.managerUserIds)) {
      body["managerUserIds"] = request.managerUserIds;
    }

    if (!Util.isUnset(request.memberQuota)) {
      body["memberQuota"] = request.memberQuota;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.notice)) {
      body["notice"] = request.notice;
    }

    if (!Util.isUnset(request.noticeToped)) {
      body["noticeToped"] = request.noticeToped;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.welcome)) {
      body["welcome"] = request.welcome;
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
      action: "CreateGroupSet",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/groupSets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupSetResponse>(await this.execute(params, req, runtime), new CreateGroupSetResponse({}));
  }

  /**
   * 创建群组
   * 
   * @param request - CreateGroupSetRequest
   * @returns CreateGroupSetResponse
   */
  async createGroupSet(request: CreateGroupSetRequest): Promise<CreateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupSetHeaders({ });
    return await this.createGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 创建关系模型表结构
   * 
   * @param request - CreateRelationMetaRequest
   * @param headers - CreateRelationMetaHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateRelationMetaResponse
   */
  async createRelationMetaWithOptions(request: CreateRelationMetaRequest, headers: CreateRelationMetaHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRelationMetaResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationMetaDTO)) {
      body["relationMetaDTO"] = request.relationMetaDTO;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "CreateRelationMeta",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relations/metas/create`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateRelationMetaResponse>(await this.execute(params, req, runtime), new CreateRelationMetaResponse({}));
  }

  /**
   * 创建关系模型表结构
   * 
   * @param request - CreateRelationMetaRequest
   * @returns CreateRelationMetaResponse
   */
  async createRelationMeta(request: CreateRelationMetaRequest): Promise<CreateRelationMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRelationMetaHeaders({ });
    return await this.createRelationMetaWithOptions(request, headers, runtime);
  }

  /**
   * 删除CRM自定义对象数据
   * 
   * @param request - DeleteCrmCustomObjectDataRequest
   * @param headers - DeleteCrmCustomObjectDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteCrmCustomObjectDataResponse
   */
  async deleteCrmCustomObjectDataWithOptions(instanceId: string, request: DeleteCrmCustomObjectDataRequest, headers: DeleteCrmCustomObjectDataHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCrmCustomObjectDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
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
      action: "DeleteCrmCustomObjectData",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customObjectDatas/instances/${instanceId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteCrmCustomObjectDataResponse>(await this.execute(params, req, runtime), new DeleteCrmCustomObjectDataResponse({}));
  }

  /**
   * 删除CRM自定义对象数据
   * 
   * @param request - DeleteCrmCustomObjectDataRequest
   * @returns DeleteCrmCustomObjectDataResponse
   */
  async deleteCrmCustomObjectData(instanceId: string, request: DeleteCrmCustomObjectDataRequest): Promise<DeleteCrmCustomObjectDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmCustomObjectDataHeaders({ });
    return await this.deleteCrmCustomObjectDataWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * crm自定义表单数据删除接口
   * 
   * @param request - DeleteCrmFormInstanceRequest
   * @param headers - DeleteCrmFormInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteCrmFormInstanceResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteCrmFormInstance",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/formInstances/${instanceId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteCrmFormInstanceResponse>(await this.execute(params, req, runtime), new DeleteCrmFormInstanceResponse({}));
  }

  /**
   * crm自定义表单数据删除接口
   * 
   * @param request - DeleteCrmFormInstanceRequest
   * @returns DeleteCrmFormInstanceResponse
   */
  async deleteCrmFormInstance(instanceId: string, request: DeleteCrmFormInstanceRequest): Promise<DeleteCrmFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmFormInstanceHeaders({ });
    return await this.deleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 删除crm个人客户（或企业客户）
   * 
   * @param request - DeleteCrmPersonalCustomerRequest
   * @param headers - DeleteCrmPersonalCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteCrmPersonalCustomerResponse
   */
  async deleteCrmPersonalCustomerWithOptions(dataId: string, request: DeleteCrmPersonalCustomerRequest, headers: DeleteCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      query["relationType"] = request.relationType;
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
      action: "DeleteCrmPersonalCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/personalCustomers/${dataId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteCrmPersonalCustomerResponse>(await this.execute(params, req, runtime), new DeleteCrmPersonalCustomerResponse({}));
  }

  /**
   * 删除crm个人客户（或企业客户）
   * 
   * @param request - DeleteCrmPersonalCustomerRequest
   * @returns DeleteCrmPersonalCustomerResponse
   */
  async deleteCrmPersonalCustomer(dataId: string, request: DeleteCrmPersonalCustomerRequest): Promise<DeleteCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmPersonalCustomerHeaders({ });
    return await this.deleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
  }

  /**
   * 删除线索
   * 
   * @param request - DeleteLeadsRequest
   * @param headers - DeleteLeadsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteLeadsResponse
   */
  async deleteLeadsWithOptions(request: DeleteLeadsRequest, headers: DeleteLeadsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteLeadsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outLeadsIds)) {
      body["outLeadsIds"] = request.outLeadsIds;
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
      action: "DeleteLeads",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/leads/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteLeadsResponse>(await this.execute(params, req, runtime), new DeleteLeadsResponse({}));
  }

  /**
   * 删除线索
   * 
   * @param request - DeleteLeadsRequest
   * @returns DeleteLeadsResponse
   */
  async deleteLeads(request: DeleteLeadsRequest): Promise<DeleteLeadsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteLeadsHeaders({ });
    return await this.deleteLeadsWithOptions(request, headers, runtime);
  }

  /**
   * 关系模型表结构删除字段
   * 
   * @param request - DeleteRelationMetaFieldRequest
   * @param headers - DeleteRelationMetaFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteRelationMetaFieldResponse
   */
  async deleteRelationMetaFieldWithOptions(request: DeleteRelationMetaFieldRequest, headers: DeleteRelationMetaFieldHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRelationMetaFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldIdList)) {
      body["fieldIdList"] = request.fieldIdList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "DeleteRelationMetaField",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relations/metas/fields/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteRelationMetaFieldResponse>(await this.execute(params, req, runtime), new DeleteRelationMetaFieldResponse({}));
  }

  /**
   * 关系模型表结构删除字段
   * 
   * @param request - DeleteRelationMetaFieldRequest
   * @returns DeleteRelationMetaFieldResponse
   */
  async deleteRelationMetaField(request: DeleteRelationMetaFieldRequest): Promise<DeleteRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRelationMetaFieldHeaders({ });
    return await this.deleteRelationMetaFieldWithOptions(request, headers, runtime);
  }

  /**
   * 获取CRM客户对象的元数据描述
   * 
   * @param request - DescribeCrmPersonalCustomerObjectMetaRequest
   * @param headers - DescribeCrmPersonalCustomerObjectMetaHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DescribeCrmPersonalCustomerObjectMetaResponse
   */
  async describeCrmPersonalCustomerObjectMetaWithOptions(request: DescribeCrmPersonalCustomerObjectMetaRequest, headers: DescribeCrmPersonalCustomerObjectMetaHeaders, runtime: $Util.RuntimeOptions): Promise<DescribeCrmPersonalCustomerObjectMetaResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DescribeCrmPersonalCustomerObjectMeta",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/personalCustomers/objectMeta`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DescribeCrmPersonalCustomerObjectMetaResponse>(await this.execute(params, req, runtime), new DescribeCrmPersonalCustomerObjectMetaResponse({}));
  }

  /**
   * 获取CRM客户对象的元数据描述
   * 
   * @param request - DescribeCrmPersonalCustomerObjectMetaRequest
   * @returns DescribeCrmPersonalCustomerObjectMetaResponse
   */
  async describeCrmPersonalCustomerObjectMeta(request: DescribeCrmPersonalCustomerObjectMetaRequest): Promise<DescribeCrmPersonalCustomerObjectMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeCrmPersonalCustomerObjectMetaHeaders({ });
    return await this.describeCrmPersonalCustomerObjectMetaWithOptions(request, headers, runtime);
  }

  /**
   * 查询模型表结构
   * 
   * @param request - DescribeMetaModelRequest
   * @param headers - DescribeMetaModelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DescribeMetaModelResponse
   */
  async describeMetaModelWithOptions(request: DescribeMetaModelRequest, headers: DescribeMetaModelHeaders, runtime: $Util.RuntimeOptions): Promise<DescribeMetaModelResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizTypes)) {
      body["bizTypes"] = request.bizTypes;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "DescribeMetaModel",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/metas/models/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DescribeMetaModelResponse>(await this.execute(params, req, runtime), new DescribeMetaModelResponse({}));
  }

  /**
   * 查询模型表结构
   * 
   * @param request - DescribeMetaModelRequest
   * @returns DescribeMetaModelResponse
   */
  async describeMetaModel(request: DescribeMetaModelRequest): Promise<DescribeMetaModelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeMetaModelHeaders({ });
    return await this.describeMetaModelWithOptions(request, headers, runtime);
  }

  /**
   * 查询关系模型表结构
   * 
   * @param request - DescribeRelationMetaRequest
   * @param headers - DescribeRelationMetaHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DescribeRelationMetaResponse
   */
  async describeRelationMetaWithOptions(request: DescribeRelationMetaRequest, headers: DescribeRelationMetaHeaders, runtime: $Util.RuntimeOptions): Promise<DescribeRelationMetaResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationTypes)) {
      body["relationTypes"] = request.relationTypes;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "DescribeRelationMeta",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relations/metas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DescribeRelationMetaResponse>(await this.execute(params, req, runtime), new DescribeRelationMetaResponse({}));
  }

  /**
   * 查询关系模型表结构
   * 
   * @param request - DescribeRelationMetaRequest
   * @returns DescribeRelationMetaResponse
   */
  async describeRelationMeta(request: DescribeRelationMetaRequest): Promise<DescribeRelationMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeRelationMetaHeaders({ });
    return await this.describeRelationMetaWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取关联对象的跟进记录列表
   * 
   * @param request - FindTargetRelatedFollowRecordsRequest
   * @param headers - FindTargetRelatedFollowRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FindTargetRelatedFollowRecordsResponse
   */
  async findTargetRelatedFollowRecordsWithOptions(request: FindTargetRelatedFollowRecordsRequest, headers: FindTargetRelatedFollowRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<FindTargetRelatedFollowRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.followTargetDataId)) {
      body["followTargetDataId"] = request.followTargetDataId;
    }

    if (!Util.isUnset(request.followTargetType)) {
      body["followTargetType"] = request.followTargetType;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
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
      action: "FindTargetRelatedFollowRecords",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/targetFollowRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FindTargetRelatedFollowRecordsResponse>(await this.execute(params, req, runtime), new FindTargetRelatedFollowRecordsResponse({}));
  }

  /**
   * 分页获取关联对象的跟进记录列表
   * 
   * @param request - FindTargetRelatedFollowRecordsRequest
   * @returns FindTargetRelatedFollowRecordsResponse
   */
  async findTargetRelatedFollowRecords(request: FindTargetRelatedFollowRecordsRequest): Promise<FindTargetRelatedFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FindTargetRelatedFollowRecordsHeaders({ });
    return await this.findTargetRelatedFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取所有客户的掉保时间数据
   * 
   * @param request - GetAllCustomerRecyclesRequest
   * @param headers - GetAllCustomerRecyclesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllCustomerRecyclesResponse
   */
  async getAllCustomerRecyclesWithOptions(request: GetAllCustomerRecyclesRequest, headers: GetAllCustomerRecyclesHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllCustomerRecyclesResponse> {
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
      action: "GetAllCustomerRecycles",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customerRecycles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllCustomerRecyclesResponse>(await this.execute(params, req, runtime), new GetAllCustomerRecyclesResponse({}));
  }

  /**
   * 分页获取所有客户的掉保时间数据
   * 
   * @param request - GetAllCustomerRecyclesRequest
   * @returns GetAllCustomerRecyclesResponse
   */
  async getAllCustomerRecycles(request: GetAllCustomerRecyclesRequest): Promise<GetAllCustomerRecyclesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllCustomerRecyclesHeaders({ });
    return await this.getAllCustomerRecyclesWithOptions(request, headers, runtime);
  }

  /**
   * 根据指定条件查询联系人数据
   * 
   * @param request - GetContactsRequest
   * @param headers - GetContactsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetContactsResponse
   */
  async getContactsWithOptions(request: GetContactsRequest, headers: GetContactsHeaders, runtime: $Util.RuntimeOptions): Promise<GetContactsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      body["currentOperatorUserId"] = request.currentOperatorUserId;
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

    if (!Util.isUnset(request.providerCorpId)) {
      body["providerCorpId"] = request.providerCorpId;
    }

    if (!Util.isUnset(request.queryDsl)) {
      body["queryDsl"] = request.queryDsl;
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
      action: "GetContacts",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customObjects/contacts/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetContactsResponse>(await this.execute(params, req, runtime), new GetContactsResponse({}));
  }

  /**
   * 根据指定条件查询联系人数据
   * 
   * @param request - GetContactsRequest
   * @returns GetContactsResponse
   */
  async getContacts(request: GetContactsRequest): Promise<GetContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetContactsHeaders({ });
    return await this.getContactsWithOptions(request, headers, runtime);
  }

  /**
   * 获取单个客户群
   * 
   * @param headers - GetCrmGroupChatHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCrmGroupChatResponse
   */
  async getCrmGroupChatWithOptions(openConversationId: string, headers: GetCrmGroupChatHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmGroupChatResponse> {
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
      action: "GetCrmGroupChat",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/crmGroupChats/${openConversationId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCrmGroupChatResponse>(await this.execute(params, req, runtime), new GetCrmGroupChatResponse({}));
  }

  /**
   * 获取单个客户群
   * @returns GetCrmGroupChatResponse
   */
  async getCrmGroupChat(openConversationId: string): Promise<GetCrmGroupChatResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatHeaders({ });
    return await this.getCrmGroupChatWithOptions(openConversationId, headers, runtime);
  }

  /**
   * 批量获取多个客户群
   * 
   * @param request - GetCrmGroupChatMultiRequest
   * @param headers - GetCrmGroupChatMultiHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCrmGroupChatMultiResponse
   */
  async getCrmGroupChatMultiWithOptions(request: GetCrmGroupChatMultiRequest, headers: GetCrmGroupChatMultiHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmGroupChatMultiResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationIds)) {
      body["openConversationIds"] = request.openConversationIds;
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
      action: "GetCrmGroupChatMulti",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/crmGroupChats/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCrmGroupChatMultiResponse>(await this.execute(params, req, runtime), new GetCrmGroupChatMultiResponse({}));
  }

  /**
   * 批量获取多个客户群
   * 
   * @param request - GetCrmGroupChatMultiRequest
   * @returns GetCrmGroupChatMultiResponse
   */
  async getCrmGroupChatMulti(request: GetCrmGroupChatMultiRequest): Promise<GetCrmGroupChatMultiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatMultiHeaders({ });
    return await this.getCrmGroupChatMultiWithOptions(request, headers, runtime);
  }

  /**
   * 获取单个客户群
   * 
   * @param request - GetCrmGroupChatSingleRequest
   * @param headers - GetCrmGroupChatSingleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCrmGroupChatSingleResponse
   */
  async getCrmGroupChatSingleWithOptions(request: GetCrmGroupChatSingleRequest, headers: GetCrmGroupChatSingleHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmGroupChatSingleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
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
      action: "GetCrmGroupChatSingle",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/crmGroupChats/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCrmGroupChatSingleResponse>(await this.execute(params, req, runtime), new GetCrmGroupChatSingleResponse({}));
  }

  /**
   * 获取单个客户群
   * 
   * @param request - GetCrmGroupChatSingleRequest
   * @returns GetCrmGroupChatSingleResponse
   */
  async getCrmGroupChatSingle(request: GetCrmGroupChatSingleRequest): Promise<GetCrmGroupChatSingleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatSingleHeaders({ });
    return await this.getCrmGroupChatSingleWithOptions(request, headers, runtime);
  }

  /**
   * 获取CRM表单权限配置
   * 
   * @param request - GetCrmRolePermissionRequest
   * @param headers - GetCrmRolePermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCrmRolePermissionResponse
   */
  async getCrmRolePermissionWithOptions(request: GetCrmRolePermissionRequest, headers: GetCrmRolePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<GetCrmRolePermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.resourceId)) {
      query["resourceId"] = request.resourceId;
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
      action: "GetCrmRolePermission",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/permissions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCrmRolePermissionResponse>(await this.execute(params, req, runtime), new GetCrmRolePermissionResponse({}));
  }

  /**
   * 获取CRM表单权限配置
   * 
   * @param request - GetCrmRolePermissionRequest
   * @returns GetCrmRolePermissionResponse
   */
  async getCrmRolePermission(request: GetCrmRolePermissionRequest): Promise<GetCrmRolePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmRolePermissionHeaders({ });
    return await this.getCrmRolePermissionWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取某个客户的客户动态
   * 
   * @param request - GetCustomerTracksByRelationIdRequest
   * @param headers - GetCustomerTracksByRelationIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCustomerTracksByRelationIdResponse
   */
  async getCustomerTracksByRelationIdWithOptions(request: GetCustomerTracksByRelationIdRequest, headers: GetCustomerTracksByRelationIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetCustomerTracksByRelationIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.relationId)) {
      query["relationId"] = request.relationId;
    }

    if (!Util.isUnset(request.typeGroup)) {
      query["typeGroup"] = request.typeGroup;
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
      action: "GetCustomerTracksByRelationId",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customerTracks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCustomerTracksByRelationIdResponse>(await this.execute(params, req, runtime), new GetCustomerTracksByRelationIdResponse({}));
  }

  /**
   * 分页获取某个客户的客户动态
   * 
   * @param request - GetCustomerTracksByRelationIdRequest
   * @returns GetCustomerTracksByRelationIdResponse
   */
  async getCustomerTracksByRelationId(request: GetCustomerTracksByRelationIdRequest): Promise<GetCustomerTracksByRelationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCustomerTracksByRelationIdHeaders({ });
    return await this.getCustomerTracksByRelationIdWithOptions(request, headers, runtime);
  }

  /**
   * 查询群组
   * 
   * @param request - GetGroupSetRequest
   * @param headers - GetGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetGroupSetResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetGroupSet",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/groupSets`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetGroupSetResponse>(await this.execute(params, req, runtime), new GetGroupSetResponse({}));
  }

  /**
   * 查询群组
   * 
   * @param request - GetGroupSetRequest
   * @returns GetGroupSetResponse
   */
  async getGroupSet(request: GetGroupSetRequest): Promise<GetGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupSetHeaders({ });
    return await this.getGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 获取内购商品信息
   * 
   * @param request - GetInAppPurchaseGoodsRequest
   * @param headers - GetInAppPurchaseGoodsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInAppPurchaseGoodsResponse
   */
  async getInAppPurchaseGoodsWithOptions(request: GetInAppPurchaseGoodsRequest, headers: GetInAppPurchaseGoodsHeaders, runtime: $Util.RuntimeOptions): Promise<GetInAppPurchaseGoodsResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetInAppPurchaseGoods",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/inAppPurchaseGoods/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInAppPurchaseGoodsResponse>(await this.execute(params, req, runtime), new GetInAppPurchaseGoodsResponse({}));
  }

  /**
   * 获取内购商品信息
   * 
   * @param request - GetInAppPurchaseGoodsRequest
   * @returns GetInAppPurchaseGoodsResponse
   */
  async getInAppPurchaseGoods(request: GetInAppPurchaseGoodsRequest): Promise<GetInAppPurchaseGoodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInAppPurchaseGoodsHeaders({ });
    return await this.getInAppPurchaseGoodsWithOptions(request, headers, runtime);
  }

  /**
   * 获取自定义导航挂靠节点结构
   * 
   * @param request - GetNavigationCatalogRequest
   * @param headers - GetNavigationCatalogHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetNavigationCatalogResponse
   */
  async getNavigationCatalogWithOptions(request: GetNavigationCatalogRequest, headers: GetNavigationCatalogHeaders, runtime: $Util.RuntimeOptions): Promise<GetNavigationCatalogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizTraceId)) {
      query["bizTraceId"] = request.bizTraceId;
    }

    if (!Util.isUnset(request.module)) {
      query["module"] = request.module;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      query["operatorUserId"] = request.operatorUserId;
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
      action: "GetNavigationCatalog",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/navigations/catalogs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNavigationCatalogResponse>(await this.execute(params, req, runtime), new GetNavigationCatalogResponse({}));
  }

  /**
   * 获取自定义导航挂靠节点结构
   * 
   * @param request - GetNavigationCatalogRequest
   * @returns GetNavigationCatalogResponse
   */
  async getNavigationCatalog(request: GetNavigationCatalogRequest): Promise<GetNavigationCatalogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNavigationCatalogHeaders({ });
    return await this.getNavigationCatalogWithOptions(request, headers, runtime);
  }

  /**
   * 根据指定条件查询自定义对象数据
   * 
   * @param request - GetObjectDataRequest
   * @param headers - GetObjectDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetObjectDataResponse
   */
  async getObjectDataWithOptions(request: GetObjectDataRequest, headers: GetObjectDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetObjectDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      body["currentOperatorUserId"] = request.currentOperatorUserId;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.queryDsl)) {
      body["queryDsl"] = request.queryDsl;
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
      action: "GetObjectData",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customObjects/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetObjectDataResponse>(await this.execute(params, req, runtime), new GetObjectDataResponse({}));
  }

  /**
   * 根据指定条件查询自定义对象数据
   * 
   * @param request - GetObjectDataRequest
   * @returns GetObjectDataResponse
   */
  async getObjectData(request: GetObjectDataRequest): Promise<GetObjectDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetObjectDataHeaders({ });
    return await this.getObjectDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
   * 
   * @param headers - GetOfficialAccountContactInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOfficialAccountContactInfoResponse
   */
  async getOfficialAccountContactInfoWithOptions(userId: string, headers: GetOfficialAccountContactInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountContactInfoResponse> {
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
      action: "GetOfficialAccountContactInfo",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/contacts/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOfficialAccountContactInfoResponse>(await this.execute(params, req, runtime), new GetOfficialAccountContactInfoResponse({}));
  }

  /**
   * 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
   * @returns GetOfficialAccountContactInfoResponse
   */
  async getOfficialAccountContactInfo(userId: string): Promise<GetOfficialAccountContactInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountContactInfoHeaders({ });
    return await this.getOfficialAccountContactInfoWithOptions(userId, headers, runtime);
  }

  /**
   * 分页获取服务窗联系人信息
   * 
   * @param request - GetOfficialAccountContactsRequest
   * @param headers - GetOfficialAccountContactsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOfficialAccountContactsResponse
   */
  async getOfficialAccountContactsWithOptions(request: GetOfficialAccountContactsRequest, headers: GetOfficialAccountContactsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountContactsResponse> {
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
      action: "GetOfficialAccountContacts",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/contacts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOfficialAccountContactsResponse>(await this.execute(params, req, runtime), new GetOfficialAccountContactsResponse({}));
  }

  /**
   * 分页获取服务窗联系人信息
   * 
   * @param request - GetOfficialAccountContactsRequest
   * @returns GetOfficialAccountContactsResponse
   */
  async getOfficialAccountContacts(request: GetOfficialAccountContactsRequest): Promise<GetOfficialAccountContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountContactsHeaders({ });
    return await this.getOfficialAccountContactsWithOptions(request, headers, runtime);
  }

  /**
   * 获取服务窗消息发送的结果
   * 
   * @param request - GetOfficialAccountOTOMessageResultRequest
   * @param headers - GetOfficialAccountOTOMessageResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOfficialAccountOTOMessageResultResponse
   */
  async getOfficialAccountOTOMessageResultWithOptions(request: GetOfficialAccountOTOMessageResultRequest, headers: GetOfficialAccountOTOMessageResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountOTOMessageResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.openPushId)) {
      query["openPushId"] = request.openPushId;
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
      action: "GetOfficialAccountOTOMessageResult",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/oToMessages/sendResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOfficialAccountOTOMessageResultResponse>(await this.execute(params, req, runtime), new GetOfficialAccountOTOMessageResultResponse({}));
  }

  /**
   * 获取服务窗消息发送的结果
   * 
   * @param request - GetOfficialAccountOTOMessageResultRequest
   * @returns GetOfficialAccountOTOMessageResultResponse
   */
  async getOfficialAccountOTOMessageResult(request: GetOfficialAccountOTOMessageResultRequest): Promise<GetOfficialAccountOTOMessageResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountOTOMessageResultHeaders({ });
    return await this.getOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
  }

  /**
   * 获取某个和oa关联的表单的具体数据
   * 
   * @param request - GetRelatedViewTabDataRequest
   * @param headers - GetRelatedViewTabDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRelatedViewTabDataResponse
   */
  async getRelatedViewTabDataWithOptions(request: GetRelatedViewTabDataRequest, headers: GetRelatedViewTabDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetRelatedViewTabDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.relatedField)) {
      body["relatedField"] = request.relatedField;
    }

    if (!Util.isUnset(request.relatedInstId)) {
      body["relatedInstId"] = request.relatedInstId;
    }

    if (!Util.isUnset(request.viewUserId)) {
      body["viewUserId"] = request.viewUserId;
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
      action: "GetRelatedViewTabData",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/formRelatedTabs/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRelatedViewTabDataResponse>(await this.execute(params, req, runtime), new GetRelatedViewTabDataResponse({}));
  }

  /**
   * 获取某个和oa关联的表单的具体数据
   * 
   * @param request - GetRelatedViewTabDataRequest
   * @returns GetRelatedViewTabDataResponse
   */
  async getRelatedViewTabData(request: GetRelatedViewTabDataRequest): Promise<GetRelatedViewTabDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelatedViewTabDataHeaders({ });
    return await this.getRelatedViewTabDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取和oa关联的表单tab信息
   * 
   * @param request - GetRelatedViewTabMetaRequest
   * @param headers - GetRelatedViewTabMetaHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRelatedViewTabMetaResponse
   */
  async getRelatedViewTabMetaWithOptions(request: GetRelatedViewTabMetaRequest, headers: GetRelatedViewTabMetaHeaders, runtime: $Util.RuntimeOptions): Promise<GetRelatedViewTabMetaResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.viewUserId)) {
      body["viewUserId"] = request.viewUserId;
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
      action: "GetRelatedViewTabMeta",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/formRelatedTabs/meta/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRelatedViewTabMetaResponse>(await this.execute(params, req, runtime), new GetRelatedViewTabMetaResponse({}));
  }

  /**
   * 获取和oa关联的表单tab信息
   * 
   * @param request - GetRelatedViewTabMetaRequest
   * @returns GetRelatedViewTabMetaResponse
   */
  async getRelatedViewTabMeta(request: GetRelatedViewTabMetaRequest): Promise<GetRelatedViewTabMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelatedViewTabMetaHeaders({ });
    return await this.getRelatedViewTabMetaWithOptions(request, headers, runtime);
  }

  /**
   * 获取关系数据查重规则
   * 
   * @param request - GetRelationUkSettingRequest
   * @param headers - GetRelationUkSettingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRelationUkSettingResponse
   */
  async getRelationUkSettingWithOptions(request: GetRelationUkSettingRequest, headers: GetRelationUkSettingHeaders, runtime: $Util.RuntimeOptions): Promise<GetRelationUkSettingResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetRelationUkSetting",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relationUkSettings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRelationUkSettingResponse>(await this.execute(params, req, runtime), new GetRelationUkSettingResponse({}));
  }

  /**
   * 获取关系数据查重规则
   * 
   * @param request - GetRelationUkSettingRequest
   * @returns GetRelationUkSettingResponse
   */
  async getRelationUkSetting(request: GetRelationUkSettingRequest): Promise<GetRelationUkSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelationUkSettingHeaders({ });
    return await this.getRelationUkSettingWithOptions(request, headers, runtime);
  }

  /**
   * 加入群组
   * 
   * @param request - JoinGroupSetRequest
   * @param headers - JoinGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns JoinGroupSetResponse
   */
  async joinGroupSetWithOptions(request: JoinGroupSetRequest, headers: JoinGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<JoinGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizDataList)) {
      body["bizDataList"] = request.bizDataList;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "JoinGroupSet",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/groupSets/join`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<JoinGroupSetResponse>(await this.execute(params, req, runtime), new JoinGroupSetResponse({}));
  }

  /**
   * 加入群组
   * 
   * @param request - JoinGroupSetRequest
   * @returns JoinGroupSetResponse
   */
  async joinGroupSet(request: JoinGroupSetRequest): Promise<JoinGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new JoinGroupSetHeaders({ });
    return await this.joinGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询可用权益
   * 
   * @param request - ListAvailableBenefitRequest
   * @param headers - ListAvailableBenefitHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAvailableBenefitResponse
   */
  async listAvailableBenefitWithOptions(request: ListAvailableBenefitRequest, headers: ListAvailableBenefitHeaders, runtime: $Util.RuntimeOptions): Promise<ListAvailableBenefitResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCodeList)) {
      body["benefitCodeList"] = request.benefitCodeList;
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
      action: "ListAvailableBenefit",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/benefits/lists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAvailableBenefitResponse>(await this.execute(params, req, runtime), new ListAvailableBenefitResponse({}));
  }

  /**
   * 批量查询可用权益
   * 
   * @param request - ListAvailableBenefitRequest
   * @returns ListAvailableBenefitResponse
   */
  async listAvailableBenefit(request: ListAvailableBenefitRequest): Promise<ListAvailableBenefitResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAvailableBenefitHeaders({ });
    return await this.listAvailableBenefitWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询license
   * 
   * @param request - ListBenefitLicenseRequest
   * @param headers - ListBenefitLicenseHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListBenefitLicenseResponse
   */
  async listBenefitLicenseWithOptions(request: ListBenefitLicenseRequest, headers: ListBenefitLicenseHeaders, runtime: $Util.RuntimeOptions): Promise<ListBenefitLicenseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.domains)) {
      body["domains"] = request.domains;
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
      action: "ListBenefitLicense",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/benefitLicenses/lists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListBenefitLicenseResponse>(await this.execute(params, req, runtime), new ListBenefitLicenseResponse({}));
  }

  /**
   * 批量查询license
   * 
   * @param request - ListBenefitLicenseRequest
   * @returns ListBenefitLicenseResponse
   */
  async listBenefitLicense(request: ListBenefitLicenseRequest): Promise<ListBenefitLicenseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListBenefitLicenseHeaders({ });
    return await this.listBenefitLicenseWithOptions(request, headers, runtime);
  }

  /**
   * 获取线索标签列表
   * 
   * @param headers - ListClueTagHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListClueTagResponse
   */
  async listClueTagWithOptions(headers: ListClueTagHeaders, runtime: $Util.RuntimeOptions): Promise<ListClueTagResponse> {
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
      action: "ListClueTag",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/clues/tags`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListClueTagResponse>(await this.execute(params, req, runtime), new ListClueTagResponse({}));
  }

  /**
   * 获取线索标签列表
   * @returns ListClueTagResponse
   */
  async listClueTag(): Promise<ListClueTagResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListClueTagHeaders({ });
    return await this.listClueTagWithOptions(headers, runtime);
  }

  /**
   * 批量获取crm个人客户
   * 
   * @param request - ListCrmPersonalCustomersRequest
   * @param headers - ListCrmPersonalCustomersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListCrmPersonalCustomersResponse
   */
  async listCrmPersonalCustomersWithOptions(request: ListCrmPersonalCustomersRequest, headers: ListCrmPersonalCustomersHeaders, runtime: $Util.RuntimeOptions): Promise<ListCrmPersonalCustomersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      query["relationType"] = request.relationType;
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
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "ListCrmPersonalCustomers",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/personalCustomers/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListCrmPersonalCustomersResponse>(await this.execute(params, req, runtime), new ListCrmPersonalCustomersResponse({}));
  }

  /**
   * 批量获取crm个人客户
   * 
   * @param request - ListCrmPersonalCustomersRequest
   * @returns ListCrmPersonalCustomersResponse
   */
  async listCrmPersonalCustomers(request: ListCrmPersonalCustomersRequest): Promise<ListCrmPersonalCustomersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCrmPersonalCustomersHeaders({ });
    return await this.listCrmPersonalCustomersWithOptions(request, headers, runtime);
  }

  /**
   * 查询群组列表
   * 
   * @param request - ListGroupSetRequest
   * @param headers - ListGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListGroupSetResponse
   */
  async listGroupSetWithOptions(request: ListGroupSetRequest, headers: ListGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<ListGroupSetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListGroupSet",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/groupSets/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListGroupSetResponse>(await this.execute(params, req, runtime), new ListGroupSetResponse({}));
  }

  /**
   * 查询群组列表
   * 
   * @param request - ListGroupSetRequest
   * @returns ListGroupSetResponse
   */
  async listGroupSet(request: ListGroupSetRequest): Promise<ListGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListGroupSetHeaders({ });
    return await this.listGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 覆盖更新客户数据权限
   * 
   * @param request - OverrideUpdateCustomerDataAuthRequest
   * @param headers - OverrideUpdateCustomerDataAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OverrideUpdateCustomerDataAuthResponse
   */
  async overrideUpdateCustomerDataAuthWithOptions(request: OverrideUpdateCustomerDataAuthRequest, headers: OverrideUpdateCustomerDataAuthHeaders, runtime: $Util.RuntimeOptions): Promise<OverrideUpdateCustomerDataAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customerIds)) {
      body["customerIds"] = request.customerIds;
    }

    if (!Util.isUnset(request.dataAuthUserIds)) {
      body["dataAuthUserIds"] = request.dataAuthUserIds;
    }

    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.roleType)) {
      body["roleType"] = request.roleType;
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
      action: "OverrideUpdateCustomerDataAuth",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customers/dataAuth/overrideUpdate`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OverrideUpdateCustomerDataAuthResponse>(await this.execute(params, req, runtime), new OverrideUpdateCustomerDataAuthResponse({}));
  }

  /**
   * 覆盖更新客户数据权限
   * 
   * @param request - OverrideUpdateCustomerDataAuthRequest
   * @returns OverrideUpdateCustomerDataAuthResponse
   */
  async overrideUpdateCustomerDataAuth(request: OverrideUpdateCustomerDataAuthRequest): Promise<OverrideUpdateCustomerDataAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OverrideUpdateCustomerDataAuthHeaders({ });
    return await this.overrideUpdateCustomerDataAuthWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
   * 
   * @param request - QueryAllCustomerRequest
   * @param headers - QueryAllCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAllCustomerResponse
   */
  async queryAllCustomerWithOptions(request: QueryAllCustomerRequest, headers: QueryAllCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "QueryAllCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customerInstances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllCustomerResponse>(await this.execute(params, req, runtime), new QueryAllCustomerResponse({}));
  }

  /**
   * 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
   * 
   * @param request - QueryAllCustomerRequest
   * @returns QueryAllCustomerResponse
   */
  async queryAllCustomer(request: QueryAllCustomerRequest): Promise<QueryAllCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllCustomerHeaders({ });
    return await this.queryAllCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询企业客户动态
   * 
   * @param request - QueryAllTracksRequest
   * @param headers - QueryAllTracksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAllTracksResponse
   */
  async queryAllTracksWithOptions(request: QueryAllTracksRequest, headers: QueryAllTracksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllTracksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.order)) {
      query["order"] = request.order;
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
      action: "QueryAllTracks",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/customers/tracks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAllTracksResponse>(await this.execute(params, req, runtime), new QueryAllTracksResponse({}));
  }

  /**
   * 批量查询企业客户动态
   * 
   * @param request - QueryAllTracksRequest
   * @returns QueryAllTracksResponse
   */
  async queryAllTracks(request: QueryAllTracksRequest): Promise<QueryAllTracksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllTracksHeaders({ });
    return await this.queryAllTracksWithOptions(request, headers, runtime);
  }

  /**
   * 查询客户管理应用管理员
   * 
   * @param request - QueryAppManagerRequest
   * @param headers - QueryAppManagerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAppManagerResponse
   */
  async queryAppManagerWithOptions(request: QueryAppManagerRequest, headers: QueryAppManagerHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAppManagerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "QueryAppManager",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/apps/managers/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAppManagerResponse>(await this.execute(params, req, runtime), new QueryAppManagerResponse({}));
  }

  /**
   * 查询客户管理应用管理员
   * 
   * @param request - QueryAppManagerRequest
   * @returns QueryAppManagerResponse
   */
  async queryAppManager(request: QueryAppManagerRequest): Promise<QueryAppManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAppManagerHeaders({ });
    return await this.queryAppManagerWithOptions(request, headers, runtime);
  }

  /**
   * 查询权益库存
   * 
   * @param request - QueryBenefitInventoryRequest
   * @param headers - QueryBenefitInventoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBenefitInventoryResponse
   */
  async queryBenefitInventoryWithOptions(request: QueryBenefitInventoryRequest, headers: QueryBenefitInventoryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBenefitInventoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      body["benefitCode"] = request.benefitCode;
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
      action: "QueryBenefitInventory",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/benefitInventories/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBenefitInventoryResponse>(await this.execute(params, req, runtime), new QueryBenefitInventoryResponse({}));
  }

  /**
   * 查询权益库存
   * 
   * @param request - QueryBenefitInventoryRequest
   * @returns QueryBenefitInventoryResponse
   */
  async queryBenefitInventory(request: QueryBenefitInventoryRequest): Promise<QueryBenefitInventoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBenefitInventoryHeaders({ });
    return await this.queryBenefitInventoryWithOptions(request, headers, runtime);
  }

  /**
   * 查询线索跟进状态
   * 
   * @param request - QueryClueFollowStatusRequest
   * @param headers - QueryClueFollowStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryClueFollowStatusResponse
   */
  async queryClueFollowStatusWithOptions(request: QueryClueFollowStatusRequest, headers: QueryClueFollowStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClueFollowStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.clueId)) {
      query["clueId"] = request.clueId;
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
      action: "QueryClueFollowStatus",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/clues/followStatuses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryClueFollowStatusResponse>(await this.execute(params, req, runtime), new QueryClueFollowStatusResponse({}));
  }

  /**
   * 查询线索跟进状态
   * 
   * @param request - QueryClueFollowStatusRequest
   * @returns QueryClueFollowStatusResponse
   */
  async queryClueFollowStatus(request: QueryClueFollowStatusRequest): Promise<QueryClueFollowStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClueFollowStatusHeaders({ });
    return await this.queryClueFollowStatusWithOptions(request, headers, runtime);
  }

  /**
   * 查询客户群
   * 
   * @param request - QueryCrmGroupChatsRequest
   * @param headers - QueryCrmGroupChatsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCrmGroupChatsResponse
   */
  async queryCrmGroupChatsWithOptions(request: QueryCrmGroupChatsRequest, headers: QueryCrmGroupChatsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCrmGroupChatsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryCrmGroupChats",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/crmGroupChats`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCrmGroupChatsResponse>(await this.execute(params, req, runtime), new QueryCrmGroupChatsResponse({}));
  }

  /**
   * 查询客户群
   * 
   * @param request - QueryCrmGroupChatsRequest
   * @returns QueryCrmGroupChatsResponse
   */
  async queryCrmGroupChats(request: QueryCrmGroupChatsRequest): Promise<QueryCrmGroupChatsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmGroupChatsHeaders({ });
    return await this.queryCrmGroupChatsWithOptions(request, headers, runtime);
  }

  /**
   * 根据指定查询条件批量获取客户数据
   * 
   * @param request - QueryCrmPersonalCustomerRequest
   * @param headers - QueryCrmPersonalCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCrmPersonalCustomerResponse
   */
  async queryCrmPersonalCustomerWithOptions(request: QueryCrmPersonalCustomerRequest, headers: QueryCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.currentOperatorUserId)) {
      query["currentOperatorUserId"] = request.currentOperatorUserId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryCrmPersonalCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/personalCustomers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCrmPersonalCustomerResponse>(await this.execute(params, req, runtime), new QueryCrmPersonalCustomerResponse({}));
  }

  /**
   * 根据指定查询条件批量获取客户数据
   * 
   * @param request - QueryCrmPersonalCustomerRequest
   * @returns QueryCrmPersonalCustomerResponse
   */
  async queryCrmPersonalCustomer(request: QueryCrmPersonalCustomerRequest): Promise<QueryCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmPersonalCustomerHeaders({ });
    return await this.queryCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 查询客户模板启用类型
   * 
   * @param request - QueryCustomerBizTypeRequest
   * @param headers - QueryCustomerBizTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCustomerBizTypeResponse
   */
  async queryCustomerBizTypeWithOptions(request: QueryCustomerBizTypeRequest, headers: QueryCustomerBizTypeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerBizTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "QueryCustomerBizType",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/orgSettings/templates/customerBizTypes/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomerBizTypeResponse>(await this.execute(params, req, runtime), new QueryCustomerBizTypeResponse({}));
  }

  /**
   * 查询客户模板启用类型
   * 
   * @param request - QueryCustomerBizTypeRequest
   * @returns QueryCustomerBizTypeResponse
   */
  async queryCustomerBizType(request: QueryCustomerBizTypeRequest): Promise<QueryCustomerBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerBizTypeHeaders({ });
    return await this.queryCustomerBizTypeWithOptions(request, headers, runtime);
  }

  /**
   * 营销服融合三方全局信息
   * 
   * @param request - QueryGlobalInfoRequest
   * @param headers - QueryGlobalInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGlobalInfoResponse
   */
  async queryGlobalInfoWithOptions(request: QueryGlobalInfoRequest, headers: QueryGlobalInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGlobalInfoResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryGlobalInfo",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/globalInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGlobalInfoResponse>(await this.execute(params, req, runtime), new QueryGlobalInfoResponse({}));
  }

  /**
   * 营销服融合三方全局信息
   * 
   * @param request - QueryGlobalInfoRequest
   * @returns QueryGlobalInfoResponse
   */
  async queryGlobalInfo(request: QueryGlobalInfoRequest): Promise<QueryGlobalInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGlobalInfoHeaders({ });
    return await this.queryGlobalInfoWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户是否有应用管理员权限
   * 
   * @param request - QueryHasAppPermissionRequest
   * @param headers - QueryHasAppPermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryHasAppPermissionResponse
   */
  async queryHasAppPermissionWithOptions(request: QueryHasAppPermissionRequest, headers: QueryHasAppPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHasAppPermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "QueryHasAppPermission",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/apps/adminPermissions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHasAppPermissionResponse>(await this.execute(params, req, runtime), new QueryHasAppPermissionResponse({}));
  }

  /**
   * 查询用户是否有应用管理员权限
   * 
   * @param request - QueryHasAppPermissionRequest
   * @returns QueryHasAppPermissionResponse
   */
  async queryHasAppPermission(request: QueryHasAppPermissionRequest): Promise<QueryHasAppPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHasAppPermissionHeaders({ });
    return await this.queryHasAppPermissionWithOptions(request, headers, runtime);
  }

  /**
   * 查询服务窗用户基础信息
   * 
   * @param request - QueryOfficialAccountUserBasicInfoRequest
   * @param headers - QueryOfficialAccountUserBasicInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOfficialAccountUserBasicInfoResponse
   */
  async queryOfficialAccountUserBasicInfoWithOptions(request: QueryOfficialAccountUserBasicInfoRequest, headers: QueryOfficialAccountUserBasicInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialAccountUserBasicInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingToken)) {
      query["bindingToken"] = request.bindingToken;
    }

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
      action: "QueryOfficialAccountUserBasicInfo",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/basics/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialAccountUserBasicInfoResponse>(await this.execute(params, req, runtime), new QueryOfficialAccountUserBasicInfoResponse({}));
  }

  /**
   * 查询服务窗用户基础信息
   * 
   * @param request - QueryOfficialAccountUserBasicInfoRequest
   * @returns QueryOfficialAccountUserBasicInfoResponse
   */
  async queryOfficialAccountUserBasicInfo(request: QueryOfficialAccountUserBasicInfoRequest): Promise<QueryOfficialAccountUserBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialAccountUserBasicInfoHeaders({ });
    return await this.queryOfficialAccountUserBasicInfoWithOptions(request, headers, runtime);
  }

  /**
   * 根据targetId查询关系数据
   * 
   * @param request - QueryRelationDatasByTargetIdRequest
   * @param headers - QueryRelationDatasByTargetIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRelationDatasByTargetIdResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryRelationDatasByTargetId",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relations/datas/targets/${targetId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRelationDatasByTargetIdResponse>(await this.execute(params, req, runtime), new QueryRelationDatasByTargetIdResponse({}));
  }

  /**
   * 根据targetId查询关系数据
   * 
   * @param request - QueryRelationDatasByTargetIdRequest
   * @returns QueryRelationDatasByTargetIdResponse
   */
  async queryRelationDatasByTargetId(targetId: string, request: QueryRelationDatasByTargetIdRequest): Promise<QueryRelationDatasByTargetIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRelationDatasByTargetIdHeaders({ });
    return await this.queryRelationDatasByTargetIdWithOptions(targetId, request, headers, runtime);
  }

  /**
   * 服务窗消息撤回
   * 
   * @param request - RecallOfficialAccountOTOMessageRequest
   * @param headers - RecallOfficialAccountOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RecallOfficialAccountOTOMessageResponse
   */
  async recallOfficialAccountOTOMessageWithOptions(request: RecallOfficialAccountOTOMessageRequest, headers: RecallOfficialAccountOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<RecallOfficialAccountOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RecallOfficialAccountOTOMessage",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/oToMessages/recall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RecallOfficialAccountOTOMessageResponse>(await this.execute(params, req, runtime), new RecallOfficialAccountOTOMessageResponse({}));
  }

  /**
   * 服务窗消息撤回
   * 
   * @param request - RecallOfficialAccountOTOMessageRequest
   * @returns RecallOfficialAccountOTOMessageResponse
   */
  async recallOfficialAccountOTOMessage(request: RecallOfficialAccountOTOMessageRequest): Promise<RecallOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallOfficialAccountOTOMessageHeaders({ });
    return await this.recallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 保存license
   * 
   * @param request - SaveBenefitLicenseRequest
   * @param headers - SaveBenefitLicenseHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveBenefitLicenseResponse
   */
  async saveBenefitLicenseWithOptions(request: SaveBenefitLicenseRequest, headers: SaveBenefitLicenseHeaders, runtime: $Util.RuntimeOptions): Promise<SaveBenefitLicenseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.domain)) {
      body["domain"] = request.domain;
    }

    if (!Util.isUnset(request.licenses)) {
      body["licenses"] = request.licenses;
    }

    if (!Util.isUnset(request.saveUserId)) {
      body["saveUserId"] = request.saveUserId;
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
      action: "SaveBenefitLicense",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/benefitLicenses/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveBenefitLicenseResponse>(await this.execute(params, req, runtime), new SaveBenefitLicenseResponse({}));
  }

  /**
   * 保存license
   * 
   * @param request - SaveBenefitLicenseRequest
   * @returns SaveBenefitLicenseResponse
   */
  async saveBenefitLicense(request: SaveBenefitLicenseRequest): Promise<SaveBenefitLicenseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveBenefitLicenseHeaders({ });
    return await this.saveBenefitLicenseWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗单发接口，指定消息接收人发送
   * 
   * @param request - SendOfficialAccountOTOMessageRequest
   * @param headers - SendOfficialAccountOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendOfficialAccountOTOMessageResponse
   */
  async sendOfficialAccountOTOMessageWithOptions(request: SendOfficialAccountOTOMessageRequest, headers: SendOfficialAccountOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendOfficialAccountOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "SendOfficialAccountOTOMessage",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/oToMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendOfficialAccountOTOMessageResponse>(await this.execute(params, req, runtime), new SendOfficialAccountOTOMessageResponse({}));
  }

  /**
   * 服务窗单发接口，指定消息接收人发送
   * 
   * @param request - SendOfficialAccountOTOMessageRequest
   * @returns SendOfficialAccountOTOMessageResponse
   */
  async sendOfficialAccountOTOMessage(request: SendOfficialAccountOTOMessageRequest): Promise<SendOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOfficialAccountOTOMessageHeaders({ });
    return await this.sendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 个人应用发送服务窗消息
   * 
   * @param request - SendOfficialAccountSNSMessageRequest
   * @param headers - SendOfficialAccountSNSMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendOfficialAccountSNSMessageResponse
   */
  async sendOfficialAccountSNSMessageWithOptions(request: SendOfficialAccountSNSMessageRequest, headers: SendOfficialAccountSNSMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendOfficialAccountSNSMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingToken)) {
      body["bindingToken"] = request.bindingToken;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "SendOfficialAccountSNSMessage",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/officialAccounts/snsMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendOfficialAccountSNSMessageResponse>(await this.execute(params, req, runtime), new SendOfficialAccountSNSMessageResponse({}));
  }

  /**
   * 个人应用发送服务窗消息
   * 
   * @param request - SendOfficialAccountSNSMessageRequest
   * @returns SendOfficialAccountSNSMessageResponse
   */
  async sendOfficialAccountSNSMessage(request: SendOfficialAccountSNSMessageRequest): Promise<SendOfficialAccountSNSMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOfficialAccountSNSMessageHeaders({ });
    return await this.sendOfficialAccountSNSMessageWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗消息群发
   * 
   * @param request - ServiceWindowMessageBatchPushRequest
   * @param headers - ServiceWindowMessageBatchPushHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ServiceWindowMessageBatchPushResponse
   */
  async serviceWindowMessageBatchPushWithOptions(request: ServiceWindowMessageBatchPushRequest, headers: ServiceWindowMessageBatchPushHeaders, runtime: $Util.RuntimeOptions): Promise<ServiceWindowMessageBatchPushResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "ServiceWindowMessageBatchPush",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/messages/batchSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ServiceWindowMessageBatchPushResponse>(await this.execute(params, req, runtime), new ServiceWindowMessageBatchPushResponse({}));
  }

  /**
   * 服务窗消息群发
   * 
   * @param request - ServiceWindowMessageBatchPushRequest
   * @returns ServiceWindowMessageBatchPushResponse
   */
  async serviceWindowMessageBatchPush(request: ServiceWindowMessageBatchPushRequest): Promise<ServiceWindowMessageBatchPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ServiceWindowMessageBatchPushHeaders({ });
    return await this.serviceWindowMessageBatchPushWithOptions(request, headers, runtime);
  }

  /**
   * 二阶段提交权益库存结果
   * 
   * @param request - TwoPhaseCommitInventoryRequest
   * @param headers - TwoPhaseCommitInventoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TwoPhaseCommitInventoryResponse
   */
  async twoPhaseCommitInventoryWithOptions(request: TwoPhaseCommitInventoryRequest, headers: TwoPhaseCommitInventoryHeaders, runtime: $Util.RuntimeOptions): Promise<TwoPhaseCommitInventoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      body["benefitCode"] = request.benefitCode;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      body["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.executeResult)) {
      body["executeResult"] = request.executeResult;
    }

    if (!Util.isUnset(request.quota)) {
      body["quota"] = request.quota;
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
      action: "TwoPhaseCommitInventory",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/benefitInventories/twoPhases/commit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TwoPhaseCommitInventoryResponse>(await this.execute(params, req, runtime), new TwoPhaseCommitInventoryResponse({}));
  }

  /**
   * 二阶段提交权益库存结果
   * 
   * @param request - TwoPhaseCommitInventoryRequest
   * @returns TwoPhaseCommitInventoryResponse
   */
  async twoPhaseCommitInventory(request: TwoPhaseCommitInventoryRequest): Promise<TwoPhaseCommitInventoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TwoPhaseCommitInventoryHeaders({ });
    return await this.twoPhaseCommitInventoryWithOptions(request, headers, runtime);
  }

  /**
   * 更新crm个人客户（或企业客户）
   * 
   * @param request - UpdateCrmPersonalCustomerRequest
   * @param headers - UpdateCrmPersonalCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateCrmPersonalCustomerResponse
   */
  async updateCrmPersonalCustomerWithOptions(request: UpdateCrmPersonalCustomerRequest, headers: UpdateCrmPersonalCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCrmPersonalCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.extendData)) {
      body["extendData"] = request.extendData;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.modifierNick)) {
      body["modifierNick"] = request.modifierNick;
    }

    if (!Util.isUnset(request.modifierUserId)) {
      body["modifierUserId"] = request.modifierUserId;
    }

    if (!Util.isUnset(request.permission)) {
      body["permission"] = request.permission;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.skipDuplicateCheck)) {
      body["skipDuplicateCheck"] = request.skipDuplicateCheck;
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
      action: "UpdateCrmPersonalCustomer",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/personalCustomers`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCrmPersonalCustomerResponse>(await this.execute(params, req, runtime), new UpdateCrmPersonalCustomerResponse({}));
  }

  /**
   * 更新crm个人客户（或企业客户）
   * 
   * @param request - UpdateCrmPersonalCustomerRequest
   * @returns UpdateCrmPersonalCustomerResponse
   */
  async updateCrmPersonalCustomer(request: UpdateCrmPersonalCustomerRequest): Promise<UpdateCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCrmPersonalCustomerHeaders({ });
    return await this.updateCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 更新客户模板类型
   * 
   * @param request - UpdateCustomerBizTypeRequest
   * @param headers - UpdateCustomerBizTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateCustomerBizTypeResponse
   */
  async updateCustomerBizTypeWithOptions(request: UpdateCustomerBizTypeRequest, headers: UpdateCustomerBizTypeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCustomerBizTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customerBizType)) {
      body["customerBizType"] = request.customerBizType;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "UpdateCustomerBizType",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/orgSettings/templates/customerBizTypes`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCustomerBizTypeResponse>(await this.execute(params, req, runtime), new UpdateCustomerBizTypeResponse({}));
  }

  /**
   * 更新客户模板类型
   * 
   * @param request - UpdateCustomerBizTypeRequest
   * @returns UpdateCustomerBizTypeResponse
   */
  async updateCustomerBizType(request: UpdateCustomerBizTypeRequest): Promise<UpdateCustomerBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCustomerBizTypeHeaders({ });
    return await this.updateCustomerBizTypeWithOptions(request, headers, runtime);
  }

  /**
   * 更新群组
   * 
   * @param request - UpdateGroupSetRequest
   * @param headers - UpdateGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupSetResponse
   */
  async updateGroupSetWithOptions(request: UpdateGroupSetRequest, headers: UpdateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.managerUserIds)) {
      body["managerUserIds"] = request.managerUserIds;
    }

    if (!Util.isUnset(request.memberQuota)) {
      body["memberQuota"] = request.memberQuota;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.notice)) {
      body["notice"] = request.notice;
    }

    if (!Util.isUnset(request.noticeToped)) {
      body["noticeToped"] = request.noticeToped;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.ownerUserId)) {
      body["ownerUserId"] = request.ownerUserId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.welcome)) {
      body["welcome"] = request.welcome;
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
      action: "UpdateGroupSet",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/groupSets/set`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "boolean",
    });
    return $tea.cast<UpdateGroupSetResponse>(await this.execute(params, req, runtime), new UpdateGroupSetResponse({}));
  }

  /**
   * 更新群组
   * 
   * @param request - UpdateGroupSetRequest
   * @returns UpdateGroupSetResponse
   */
  async updateGroupSet(request: UpdateGroupSetRequest): Promise<UpdateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupSetHeaders({ });
    return await this.updateGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 增量同步导航数据
   * 
   * @param request - UpdateMenuDataRequest
   * @param headers - UpdateMenuDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMenuDataResponse
   */
  async updateMenuDataWithOptions(request: UpdateMenuDataRequest, headers: UpdateMenuDataHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMenuDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attr)) {
      body["attr"] = request.attr;
    }

    if (!Util.isUnset(request.bizTraceId)) {
      body["bizTraceId"] = request.bizTraceId;
    }

    if (!Util.isUnset(request.module)) {
      body["module"] = request.module;
    }

    if (!Util.isUnset(request.navData)) {
      body["navData"] = request.navData;
    }

    if (!Util.isUnset(request.operateType)) {
      body["operateType"] = request.operateType;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
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
      action: "UpdateMenuData",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/navigations/menus/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateMenuDataResponse>(await this.execute(params, req, runtime), new UpdateMenuDataResponse({}));
  }

  /**
   * 增量同步导航数据
   * 
   * @param request - UpdateMenuDataRequest
   * @returns UpdateMenuDataResponse
   */
  async updateMenuData(request: UpdateMenuDataRequest): Promise<UpdateMenuDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMenuDataHeaders({ });
    return await this.updateMenuDataWithOptions(request, headers, runtime);
  }

  /**
   * 模型表结构更新字段
   * 
   * @param request - UpdateMetaModelFieldRequest
   * @param headers - UpdateMetaModelFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMetaModelFieldResponse
   */
  async updateMetaModelFieldWithOptions(request: UpdateMetaModelFieldRequest, headers: UpdateMetaModelFieldHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMetaModelFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.fieldDTOList)) {
      body["fieldDTOList"] = request.fieldDTOList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "UpdateMetaModelField",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/metas/models/fields`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateMetaModelFieldResponse>(await this.execute(params, req, runtime), new UpdateMetaModelFieldResponse({}));
  }

  /**
   * 模型表结构更新字段
   * 
   * @param request - UpdateMetaModelFieldRequest
   * @returns UpdateMetaModelFieldResponse
   */
  async updateMetaModelField(request: UpdateMetaModelFieldRequest): Promise<UpdateMetaModelFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMetaModelFieldHeaders({ });
    return await this.updateMetaModelFieldWithOptions(request, headers, runtime);
  }

  /**
   * 关系模型表结构更新字段
   * 
   * @param request - UpdateRelationMetaFieldRequest
   * @param headers - UpdateRelationMetaFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateRelationMetaFieldResponse
   */
  async updateRelationMetaFieldWithOptions(request: UpdateRelationMetaFieldRequest, headers: UpdateRelationMetaFieldHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRelationMetaFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldDTOList)) {
      body["fieldDTOList"] = request.fieldDTOList;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.relationType)) {
      body["relationType"] = request.relationType;
    }

    if (!Util.isUnset(request.tenant)) {
      body["tenant"] = request.tenant;
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
      action: "UpdateRelationMetaField",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/relations/metas/fields`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRelationMetaFieldResponse>(await this.execute(params, req, runtime), new UpdateRelationMetaFieldResponse({}));
  }

  /**
   * 关系模型表结构更新字段
   * 
   * @param request - UpdateRelationMetaFieldRequest
   * @returns UpdateRelationMetaFieldResponse
   */
  async updateRelationMetaField(request: UpdateRelationMetaFieldRequest): Promise<UpdateRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRelationMetaFieldHeaders({ });
    return await this.updateRelationMetaFieldWithOptions(request, headers, runtime);
  }

}
