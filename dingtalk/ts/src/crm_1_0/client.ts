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
  instanceIdList?: string[];
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
  action?: string;
  creatorNick?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  permission?: AddCrmPersonalCustomerRequestPermission;
  relationType?: string;
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
  content?: string;
  customerId?: string;
  extraBizInfo?: string;
  idempotentKey?: string;
  maskedContent?: string;
  operatorUserId?: string;
  relationType?: string;
  title?: string;
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
  assignTimestamp?: number;
  assignUserId?: string;
  assignedUserId?: string;
  leads?: AddLeadsRequestLeads[];
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
  fieldDTOList?: AddRelationMetaFieldRequestFieldDTOList[];
  operatorUserId?: string;
  relationType?: string;
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
  operatorUserId?: string;
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
  instanceList?: BatchAddFollowRecordsRequestInstanceList[];
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
  operatorUserId?: string;
  relationList?: BatchAddRelationDatasRequestRelationList[];
  relationType?: string;
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
  instanceIds?: string[];
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
  bizId?: string;
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
  operatorUserId?: string;
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
  instanceList?: BatchUpdateFollowRecordsRequestInstanceList[];
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
  operatorUserId?: string;
  relationList?: BatchUpdateRelationDatasRequestRelationList[];
  relationType?: string;
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
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  instanceId?: string;
  objectType?: string;
  permission?: CreateCustomerRequestPermission;
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
  customerInstanceId?: string;
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
  groupName?: string;
  memberUserIds?: string;
  ownerUserId?: string;
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
  creatorUserId?: string;
  managerUserIds?: string;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  ownerUserId?: string;
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
  lastOpenConversationId?: string;
  manager?: CreateGroupSetResponseBodyManager[];
  managerUserIds?: string;
  memberCount?: number;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  openGroupSetId?: string;
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
  operatorUserId?: string;
  relationMetaDTO?: CreateRelationMetaRequestRelationMetaDTO;
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
  fieldIdList?: string[];
  operatorUserId?: string;
  relationType?: string;
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
  code?: string;
  customized?: boolean;
  fields?: DescribeCrmPersonalCustomerObjectMetaResponseBodyFields[];
  name?: string;
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
  operatorUserId?: string;
  relationTypes?: string[];
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
  followTargetDataId?: string;
  followTargetType?: string;
  maxResults?: number;
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
  hasMore?: boolean;
  nextToken?: string;
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
  currentOperatorUserId?: string;
  maxResults?: number;
  nextToken?: string;
  objectType?: string;
  providerCorpId?: string;
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
  bizType?: string;
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
  maxResults?: number;
  nextToken?: string;
  relationId?: string;
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
  hasMore?: boolean;
  nextToken?: string;
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
  groupChatCount?: number;
  inviteLink?: string;
  lastOpenConversationId?: string;
  manager?: GetGroupSetResponseBodyManager[];
  managerUserIds?: string;
  memberCount?: number;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  openGroupSetId?: string;
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
  bizTraceId?: string;
  module?: string;
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
  currentOperatorUserId?: string;
  maxResults?: number;
  name?: string;
  nextToken?: string;
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
  corpName?: string;
  mobile?: string;
  stateCode?: string;
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

export class GetOfficialAccountContactsResponseBody extends $tea.Model {
  maxResults?: number;
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
  corpId?: string;
  openGroupSetId?: string;
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
  chatId?: string;
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
  maxResults?: number;
  nextToken?: string;
  objectType?: string;
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
  maxResults?: number;
  nextToken?: string;
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
  hasMore?: boolean;
  maxResults?: number;
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
  maxResults?: number;
  nextToken?: string;
  queryDsl?: string;
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
  hasMore?: boolean;
  nextToken?: string;
  resultList?: QueryCrmGroupChatsResponseBodyResultList[];
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
  maxResults?: number;
  nextToken?: string;
  queryDsl?: string;
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
  maxResults?: number;
  nextToken?: string;
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
  bindingToken?: string;
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
  accountId?: string;
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
  bindingToken?: string;
  bizId?: string;
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
  bizId?: string;
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
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  instanceId?: string;
  modifierNick?: string;
  modifierUserId?: string;
  permission?: UpdateCrmPersonalCustomerRequestPermission;
  relationType?: string;
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
  bizTraceId?: string;
  module?: string;
  navData?: UpdateMenuDataRequestNavData;
  operateType?: string;
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
  fieldDTOList?: UpdateRelationMetaFieldRequestFieldDTOList[];
  operatorUserId?: string;
  relationType?: string;
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
  leadsName?: string;
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
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: AddRelationMetaFieldRequestFieldDTOListPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
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

export class BatchAddContactsRequestRelationListBizDataList extends $tea.Model {
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

export class BatchAddContactsRequestRelationList extends $tea.Model {
  bizDataList?: BatchAddContactsRequestRelationListBizDataList[];
  bizExtMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      bizExtMap: 'bizExtMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': BatchAddContactsRequestRelationListBizDataList },
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddContactsResponseBodyResults extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  relationId?: string;
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

export class BatchAddFollowRecordsRequestInstanceList extends $tea.Model {
  dataArray?: BatchAddFollowRecordsRequestInstanceListDataArray[];
  static names(): { [key: string]: string } {
    return {
      dataArray: 'dataArray',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataArray: { 'type': 'array', 'itemType': BatchAddFollowRecordsRequestInstanceListDataArray },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddFollowRecordsResponseBodyResults extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  instanceId?: string;
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
  bizDataList?: BatchAddRelationDatasRequestRelationListBizDataList[];
  bizExtMap?: { [key: string]: string };
  relationPermissionDTO?: BatchAddRelationDatasRequestRelationListRelationPermissionDTO;
  static names(): { [key: string]: string } {
    return {
      bizDataList: 'bizDataList',
      bizExtMap: 'bizExtMap',
      relationPermissionDTO: 'relationPermissionDTO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataList: { 'type': 'array', 'itemType': BatchAddRelationDatasRequestRelationListBizDataList },
      bizExtMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      relationPermissionDTO: BatchAddRelationDatasRequestRelationListRelationPermissionDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddRelationDatasResponseBodyResults extends $tea.Model {
  duplicatedRelationIds?: string[];
  errorCode?: string;
  errorMsg?: string;
  relationId?: string;
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
  mobile?: string;
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
  contactList?: BatchCreateClueDataRequestDataListContactList[];
  enterprise?: BatchCreateClueDataRequestDataListEnterprise;
  name?: string;
  sourceId?: string;
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
  errorCode?: string;
  errorMsg?: string;
  instanceId?: string;
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

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList[];
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

export class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
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
  bizRequestId?: string;
  messageBody?: BatchSendOfficialAccountOTOMessageRequestDetailMessageBody;
  msgType?: string;
  sendToAll?: boolean;
  userIdList?: string[];
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

export class BatchUpdateContactsRequestRelationList extends $tea.Model {
  bizDataList?: BatchUpdateContactsRequestRelationListBizDataList[];
  bizExtMap?: { [key: string]: string };
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
  errorCode?: string;
  errorMsg?: string;
  relationId?: string;
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

export class BatchUpdateFollowRecordsRequestInstanceList extends $tea.Model {
  dataArray?: BatchUpdateFollowRecordsRequestInstanceListDataArray[];
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
  errorCode?: string;
  errorMsg?: string;
  instanceId?: string;
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

export class BatchUpdateRelationDatasRequestRelationList extends $tea.Model {
  bizDataList?: BatchUpdateRelationDatasRequestRelationListBizDataList[];
  bizExtMap?: { [key: string]: string };
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
  errorCode?: string;
  errorMsg?: string;
  relationId?: string;
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
  customerExistedPolicy?: string;
  skipDuplicateCheck?: boolean;
  subscribePolicy?: number;
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
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
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
  desc?: string;
  items?: CreateRelationMetaRequestRelationMetaDTOItems[];
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
  aggregator?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates extends $tea.Model {
  id?: string;
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
  fieldId?: string;
  filterType?: string;
  value?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource extends $tea.Model {
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget;
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
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension;
  key?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  durationLabel?: string;
  fieldId?: string;
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  limit?: number;
  link?: string;
  mode?: string;
  notUpper?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  ratio?: number;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  spread?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField[];
  unit?: string;
  verticalPrint?: boolean;
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
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension;
  key?: string;
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
  fieldId?: string;
  filterType?: string;
  value?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource extends $tea.Model {
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: string;
  fieldId?: string;
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  multi?: number;
  notUpper?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  quote?: number;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField[];
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource extends $tea.Model {
  bizType?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps extends $tea.Model {
  actionName?: string;
  align?: string;
  availableTemplates?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates[];
  bizAlias?: string;
  choice?: number;
  content?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource;
  defaultColor?: string;
  disabled?: boolean;
  duration?: boolean;
  durationLabel?: string;
  fieldId?: string;
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields[];
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  limit?: number;
  link?: string;
  mode?: string;
  multiple?: boolean;
  notPrint?: string;
  notUpper?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  quote?: number;
  ratio?: number;
  relateSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource[];
  required?: boolean;
  requiredEditableFreeze?: boolean;
  rule?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule[];
  sortable?: boolean;
  spread?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField[];
  tableViewMode?: string;
  unit?: string;
  verticalPrint?: boolean;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates extends $tea.Model {
  id?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters extends $tea.Model {
  fieldId?: string;
  filterType?: string;
  value?: string;
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
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension;
  key?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: string;
  durationLabel?: string;
  fieldId?: string;
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  limit?: number;
  link?: string;
  mode?: string;
  notUpper?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  ratio?: number;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  spread?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField[];
  unit?: string;
  verticalPrint?: boolean;
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
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension;
  key?: string;
  value?: string;
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
  fieldId?: string;
  filterType?: string;
  value?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource extends $tea.Model {
  params?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams;
  target?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget;
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
  extension?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension;
  key?: string;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps extends $tea.Model {
  align?: string;
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: string;
  fieldId?: string;
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  multi?: number;
  notUpper?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  quote?: number;
  required?: boolean;
  requiredEditableFreeze?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField[];
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource extends $tea.Model {
  bizType?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource;
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField extends $tea.Model {
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

export class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps extends $tea.Model {
  actionName?: string;
  align?: string;
  availableTemplates?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates[];
  bizAlias?: string;
  choice?: number;
  content?: string;
  dataSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource;
  defaultColor?: string;
  disabled?: boolean;
  duration?: boolean;
  durationLabel?: string;
  fieldId?: string;
  fields?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields[];
  format?: string;
  formula?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  limit?: number;
  link?: string;
  mode?: string;
  multi?: number;
  multiple?: boolean;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
  quote?: number;
  ratio?: number;
  relateSource?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource[];
  required?: boolean;
  requiredEditableFreeze?: boolean;
  rule?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule[];
  sortable?: boolean;
  spread?: boolean;
  statField?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField[];
  tableViewMode?: string;
  unit?: string;
  verticalPrint?: boolean;
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
  children?: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren[];
  componentName?: string;
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
  creatorUserId?: string;
  desc?: string;
  gmtCreate?: string;
  gmtModified?: string;
  items?: DescribeRelationMetaResponseBodyRelationMetaDTOListItems[];
  name?: string;
  relationMetaCode?: string;
  relationMetaStatus?: string;
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
  bizAlias?: string;
  extendValue?: string;
  key?: string;
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
  creatorUserId?: string;
  followContent?: FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent[];
  followTargetDataId?: string;
  followTargetType?: string;
  gmtCreateMilliseconds?: string;
  gmtModifiedMilliseconds?: string;
  modifierUserId?: string;
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
  hasMore?: boolean;
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
  customerId?: string;
  followUpActionTime?: string;
  isDeleted?: boolean;
  notifyTime?: string;
  recycleRuleId?: number;
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
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  gmtCreate?: string;
  gmtModified?: string;
  instanceId?: string;
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
  maxResults?: number;
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
  gmtCreate?: number;
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

export class GetCrmRolePermissionResponseBodyPermissionsFieldScopes extends $tea.Model {
  fieldActions?: string[];
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
  deptIdList?: number[];
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
  ext?: GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt;
  manager?: boolean;
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
  hasAuth?: boolean;
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
  memberId?: string;
  name?: string;
  type?: string;
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
  defaultRole?: boolean;
  fieldScopes?: GetCrmRolePermissionResponseBodyPermissionsFieldScopes[];
  managingScopeList?: GetCrmRolePermissionResponseBodyPermissionsManagingScopeList[];
  operateScopes?: GetCrmRolePermissionResponseBodyPermissionsOperateScopes[];
  resourceId?: string;
  roleId?: number;
  roleMemberList?: GetCrmRolePermissionResponseBodyPermissionsRoleMemberList[];
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
  content?: string;
  creatorName?: string;
  detail?: { [key: string]: string };
  format?: string;
  gmtCreate?: string;
  isvInfo?: GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo;
  title?: string;
  type?: number;
  typeGroup?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      creatorName: 'creatorName',
      detail: 'detail',
      format: 'format',
      gmtCreate: 'gmtCreate',
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
  creatorNick?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  gmtCreate?: string;
  gmtModified?: string;
  instanceId?: string;
  objectType?: string;
  permission?: GetObjectDataResponseBodyResultValuesPermission;
  procInstStatus?: string;
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
  maxResults?: number;
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
  createTime?: string;
  creatorNick?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  instanceId?: string;
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
  readUserIdList?: string[];
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

export class GetRelationUkSettingResponseBodyResult extends $tea.Model {
  bizAlias?: string;
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
  appUuid?: string;
  creatorNick?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  formCode?: string;
  gmtCreate?: string;
  gmtModified?: string;
  instanceId?: string;
  objectType?: string;
  permission?: ListCrmPersonalCustomersResponseBodyResultPermission;
  procInstStatus?: string;
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

export class ListGroupSetResponseBodyResultList extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  groupChatCount?: number;
  lastOpenConversationId?: string;
  manager?: ListGroupSetResponseBodyResultListManager[];
  managerUserIds?: string;
  memberCount?: number;
  memberQuota?: number;
  name?: string;
  notice?: string;
  noticeToped?: number;
  openGroupSetId?: string;
  owner?: ListGroupSetResponseBodyResultListOwner;
  ownerUserId?: string;
  relationType?: string;
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
  createTime?: string;
  creatorNick?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  instanceId?: string;
  modifyTime?: string;
  objectType?: string;
  permission?: QueryAllCustomerResponseBodyResultValuesPermission;
  processInstanceStatus?: string;
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
  maxResults?: number;
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
  bizId?: string;
  creator?: string;
  customerId?: string;
  gmtCreate?: number;
  id?: string;
  subType?: number;
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
  gmtCreate?: number;
  memberCount?: number;
  name?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  ownerUserId?: string;
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
  creatorNick?: string;
  creatorUserId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  gmtCreate?: string;
  gmtModified?: string;
  instanceId?: string;
  objectType?: string;
  permission?: QueryCrmPersonalCustomerResponseBodyValuesPermission;
  procInstStatus?: string;
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

export class QueryRelationDatasByTargetIdResponseBodyRelations extends $tea.Model {
  bizDataList?: QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList[];
  openConversationIds?: string[];
  relationId?: string;
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

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
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

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList[];
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

export class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
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
  messageBody?: SendOfficialAccountOTOMessageRequestDetailMessageBody;
  msgType?: string;
  unionId?: string;
  userId?: string;
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
  messageBody?: SendOfficialAccountSNSMessageRequestDetailMessageBody;
  msgType?: string;
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
  bizRequestId?: string;
  messageBody?: ServiceWindowMessageBatchPushRequestDetailMessageBody;
  msgType?: string;
  sendToAll?: boolean;
  userIdList?: string[];
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
  productMode?: string;
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
  displayStatus?: string;
  icon?: string;
  iconBgColor?: string;
  iconColor?: string;
  integrationProtocol?: string;
  mobileNavName?: string;
  mobileUrl?: string;
  navCode?: string;
  navExtInfo?: UpdateMenuDataRequestNavDataNavExtInfo;
  navId?: string;
  navName?: string;
  navStatus?: string;
  navType?: string;
  parentNavId?: string;
  provider?: string;
  sortNum?: number;
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
  bizAlias?: string;
  choice?: number;
  content?: string;
  disabled?: boolean;
  duration?: boolean;
  fieldId?: string;
  format?: string;
  invisible?: boolean;
  label?: string;
  labelEditableFreeze?: boolean;
  link?: string;
  needDetail?: string;
  notPrint?: string;
  notUpper?: string;
  options?: UpdateRelationMetaFieldRequestFieldDTOListPropsOptions[];
  payEnable?: boolean;
  placeholder?: string;
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


  /**
   * @summary 从私海放弃客户（退回公海）
   *
   * @param request AbandonCustomerRequest
   * @param headers AbandonCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AbandonCustomerResponse
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
   * @summary 从私海放弃客户（退回公海）
   *
   * @param request AbandonCustomerRequest
   * @return AbandonCustomerResponse
   */
  async abandonCustomer(request: AbandonCustomerRequest): Promise<AbandonCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AbandonCustomerHeaders({ });
    return await this.abandonCustomerWithOptions(request, headers, runtime);
  }

  /**
   * @summary 添加crm个人客户（或企业客户）
   *
   * @param request AddCrmPersonalCustomerRequest
   * @param headers AddCrmPersonalCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AddCrmPersonalCustomerResponse
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
   * @summary 添加crm个人客户（或企业客户）
   *
   * @param request AddCrmPersonalCustomerRequest
   * @return AddCrmPersonalCustomerResponse
   */
  async addCrmPersonalCustomer(request: AddCrmPersonalCustomerRequest): Promise<AddCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCrmPersonalCustomerHeaders({ });
    return await this.addCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  /**
   * @summary 新增动态
   *
   * @param request AddCustomerTrackRequest
   * @param headers AddCustomerTrackHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AddCustomerTrackResponse
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
   * @summary 新增动态
   *
   * @param request AddCustomerTrackRequest
   * @return AddCustomerTrackResponse
   */
  async addCustomerTrack(request: AddCustomerTrackRequest): Promise<AddCustomerTrackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCustomerTrackHeaders({ });
    return await this.addCustomerTrackWithOptions(request, headers, runtime);
  }

  /**
   * @summary 添加线索
   *
   * @param request AddLeadsRequest
   * @param headers AddLeadsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AddLeadsResponse
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
   * @summary 添加线索
   *
   * @param request AddLeadsRequest
   * @return AddLeadsResponse
   */
  async addLeads(request: AddLeadsRequest): Promise<AddLeadsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLeadsHeaders({ });
    return await this.addLeadsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 关系模型表结构增加字段
   *
   * @param request AddRelationMetaFieldRequest
   * @param headers AddRelationMetaFieldHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AddRelationMetaFieldResponse
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
   * @summary 关系模型表结构增加字段
   *
   * @param request AddRelationMetaFieldRequest
   * @return AddRelationMetaFieldResponse
   */
  async addRelationMetaField(request: AddRelationMetaFieldRequest): Promise<AddRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRelationMetaFieldHeaders({ });
    return await this.addRelationMetaFieldWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量新增联系人
   *
   * @param request BatchAddContactsRequest
   * @param headers BatchAddContactsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchAddContactsResponse
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
   * @summary 批量新增联系人
   *
   * @param request BatchAddContactsRequest
   * @return BatchAddContactsResponse
   */
  async batchAddContacts(request: BatchAddContactsRequest): Promise<BatchAddContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddContactsHeaders({ });
    return await this.batchAddContactsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量新增跟进记录
   *
   * @param request BatchAddFollowRecordsRequest
   * @param headers BatchAddFollowRecordsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchAddFollowRecordsResponse
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
   * @summary 批量新增跟进记录
   *
   * @param request BatchAddFollowRecordsRequest
   * @return BatchAddFollowRecordsResponse
   */
  async batchAddFollowRecords(request: BatchAddFollowRecordsRequest): Promise<BatchAddFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddFollowRecordsHeaders({ });
    return await this.batchAddFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量新增关系数据
   *
   * @param request BatchAddRelationDatasRequest
   * @param headers BatchAddRelationDatasHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchAddRelationDatasResponse
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
   * @summary 批量新增关系数据
   *
   * @param request BatchAddRelationDatasRequest
   * @return BatchAddRelationDatasResponse
   */
  async batchAddRelationDatas(request: BatchAddRelationDatasRequest): Promise<BatchAddRelationDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddRelationDatasHeaders({ });
    return await this.batchAddRelationDatasWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量创建线索数据
   *
   * @param request BatchCreateClueDataRequest
   * @param headers BatchCreateClueDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchCreateClueDataResponse
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
   * @summary 批量创建线索数据
   *
   * @param request BatchCreateClueDataRequest
   * @return BatchCreateClueDataResponse
   */
  async batchCreateClueData(request: BatchCreateClueDataRequest): Promise<BatchCreateClueDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateClueDataHeaders({ });
    return await this.batchCreateClueDataWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量删除跟进记录
   *
   * @param request BatchRemoveFollowRecordsRequest
   * @param headers BatchRemoveFollowRecordsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchRemoveFollowRecordsResponse
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
   * @summary 批量删除跟进记录
   *
   * @param request BatchRemoveFollowRecordsRequest
   * @return BatchRemoveFollowRecordsResponse
   */
  async batchRemoveFollowRecords(request: BatchRemoveFollowRecordsRequest): Promise<BatchRemoveFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRemoveFollowRecordsHeaders({ });
    return await this.batchRemoveFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 服务窗消息群发
   *
   * @param request BatchSendOfficialAccountOTOMessageRequest
   * @param headers BatchSendOfficialAccountOTOMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchSendOfficialAccountOTOMessageResponse
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
   * @summary 服务窗消息群发
   *
   * @param request BatchSendOfficialAccountOTOMessageRequest
   * @return BatchSendOfficialAccountOTOMessageResponse
   */
  async batchSendOfficialAccountOTOMessage(request: BatchSendOfficialAccountOTOMessageRequest): Promise<BatchSendOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendOfficialAccountOTOMessageHeaders({ });
    return await this.batchSendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量修改联系人
   *
   * @param request BatchUpdateContactsRequest
   * @param headers BatchUpdateContactsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchUpdateContactsResponse
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
   * @summary 批量修改联系人
   *
   * @param request BatchUpdateContactsRequest
   * @return BatchUpdateContactsResponse
   */
  async batchUpdateContacts(request: BatchUpdateContactsRequest): Promise<BatchUpdateContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateContactsHeaders({ });
    return await this.batchUpdateContactsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量修改跟进记录
   *
   * @param request BatchUpdateFollowRecordsRequest
   * @param headers BatchUpdateFollowRecordsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchUpdateFollowRecordsResponse
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
   * @summary 批量修改跟进记录
   *
   * @param request BatchUpdateFollowRecordsRequest
   * @return BatchUpdateFollowRecordsResponse
   */
  async batchUpdateFollowRecords(request: BatchUpdateFollowRecordsRequest): Promise<BatchUpdateFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateFollowRecordsHeaders({ });
    return await this.batchUpdateFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量修改关系数据
   *
   * @param request BatchUpdateRelationDatasRequest
   * @param headers BatchUpdateRelationDatasHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchUpdateRelationDatasResponse
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
   * @summary 批量修改关系数据
   *
   * @param request BatchUpdateRelationDatasRequest
   * @return BatchUpdateRelationDatasResponse
   */
  async batchUpdateRelationDatas(request: BatchUpdateRelationDatasRequest): Promise<BatchUpdateRelationDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateRelationDatasHeaders({ });
    return await this.batchUpdateRelationDatasWithOptions(request, headers, runtime);
  }

  /**
   * @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
   *
   * @param request CreateCustomerRequest
   * @param headers CreateCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateCustomerResponse
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
   * @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
   *
   * @param request CreateCustomerRequest
   * @return CreateCustomerResponse
   */
  async createCustomer(request: CreateCustomerRequest): Promise<CreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomerHeaders({ });
    return await this.createCustomerWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建客户群
   *
   * @param request CreateGroupRequest
   * @param headers CreateGroupHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateGroupResponse
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
   * @summary 创建客户群
   *
   * @param request CreateGroupRequest
   * @return CreateGroupResponse
   */
  async createGroup(request: CreateGroupRequest): Promise<CreateGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupHeaders({ });
    return await this.createGroupWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建群组
   *
   * @param request CreateGroupSetRequest
   * @param headers CreateGroupSetHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateGroupSetResponse
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
   * @summary 创建群组
   *
   * @param request CreateGroupSetRequest
   * @return CreateGroupSetResponse
   */
  async createGroupSet(request: CreateGroupSetRequest): Promise<CreateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupSetHeaders({ });
    return await this.createGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建关系模型表结构
   *
   * @param request CreateRelationMetaRequest
   * @param headers CreateRelationMetaHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateRelationMetaResponse
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
   * @summary 创建关系模型表结构
   *
   * @param request CreateRelationMetaRequest
   * @return CreateRelationMetaResponse
   */
  async createRelationMeta(request: CreateRelationMetaRequest): Promise<CreateRelationMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRelationMetaHeaders({ });
    return await this.createRelationMetaWithOptions(request, headers, runtime);
  }

  /**
   * @summary 删除CRM自定义对象数据
   *
   * @param request DeleteCrmCustomObjectDataRequest
   * @param headers DeleteCrmCustomObjectDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeleteCrmCustomObjectDataResponse
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
   * @summary 删除CRM自定义对象数据
   *
   * @param request DeleteCrmCustomObjectDataRequest
   * @return DeleteCrmCustomObjectDataResponse
   */
  async deleteCrmCustomObjectData(instanceId: string, request: DeleteCrmCustomObjectDataRequest): Promise<DeleteCrmCustomObjectDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmCustomObjectDataHeaders({ });
    return await this.deleteCrmCustomObjectDataWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * @summary crm自定义表单数据删除接口
   *
   * @param request DeleteCrmFormInstanceRequest
   * @param headers DeleteCrmFormInstanceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeleteCrmFormInstanceResponse
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
   * @summary crm自定义表单数据删除接口
   *
   * @param request DeleteCrmFormInstanceRequest
   * @return DeleteCrmFormInstanceResponse
   */
  async deleteCrmFormInstance(instanceId: string, request: DeleteCrmFormInstanceRequest): Promise<DeleteCrmFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmFormInstanceHeaders({ });
    return await this.deleteCrmFormInstanceWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * @summary 删除crm个人客户（或企业客户）
   *
   * @param request DeleteCrmPersonalCustomerRequest
   * @param headers DeleteCrmPersonalCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeleteCrmPersonalCustomerResponse
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
   * @summary 删除crm个人客户（或企业客户）
   *
   * @param request DeleteCrmPersonalCustomerRequest
   * @return DeleteCrmPersonalCustomerResponse
   */
  async deleteCrmPersonalCustomer(dataId: string, request: DeleteCrmPersonalCustomerRequest): Promise<DeleteCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteCrmPersonalCustomerHeaders({ });
    return await this.deleteCrmPersonalCustomerWithOptions(dataId, request, headers, runtime);
  }

  /**
   * @summary 删除线索
   *
   * @param request DeleteLeadsRequest
   * @param headers DeleteLeadsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeleteLeadsResponse
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
   * @summary 删除线索
   *
   * @param request DeleteLeadsRequest
   * @return DeleteLeadsResponse
   */
  async deleteLeads(request: DeleteLeadsRequest): Promise<DeleteLeadsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteLeadsHeaders({ });
    return await this.deleteLeadsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 关系模型表结构删除字段
   *
   * @param request DeleteRelationMetaFieldRequest
   * @param headers DeleteRelationMetaFieldHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeleteRelationMetaFieldResponse
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
   * @summary 关系模型表结构删除字段
   *
   * @param request DeleteRelationMetaFieldRequest
   * @return DeleteRelationMetaFieldResponse
   */
  async deleteRelationMetaField(request: DeleteRelationMetaFieldRequest): Promise<DeleteRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRelationMetaFieldHeaders({ });
    return await this.deleteRelationMetaFieldWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取CRM客户对象的元数据描述
   *
   * @param request DescribeCrmPersonalCustomerObjectMetaRequest
   * @param headers DescribeCrmPersonalCustomerObjectMetaHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DescribeCrmPersonalCustomerObjectMetaResponse
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
   * @summary 获取CRM客户对象的元数据描述
   *
   * @param request DescribeCrmPersonalCustomerObjectMetaRequest
   * @return DescribeCrmPersonalCustomerObjectMetaResponse
   */
  async describeCrmPersonalCustomerObjectMeta(request: DescribeCrmPersonalCustomerObjectMetaRequest): Promise<DescribeCrmPersonalCustomerObjectMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeCrmPersonalCustomerObjectMetaHeaders({ });
    return await this.describeCrmPersonalCustomerObjectMetaWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询关系模型表结构
   *
   * @param request DescribeRelationMetaRequest
   * @param headers DescribeRelationMetaHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DescribeRelationMetaResponse
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
   * @summary 查询关系模型表结构
   *
   * @param request DescribeRelationMetaRequest
   * @return DescribeRelationMetaResponse
   */
  async describeRelationMeta(request: DescribeRelationMetaRequest): Promise<DescribeRelationMetaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DescribeRelationMetaHeaders({ });
    return await this.describeRelationMetaWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页获取关联对象的跟进记录列表
   *
   * @param request FindTargetRelatedFollowRecordsRequest
   * @param headers FindTargetRelatedFollowRecordsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return FindTargetRelatedFollowRecordsResponse
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
   * @summary 分页获取关联对象的跟进记录列表
   *
   * @param request FindTargetRelatedFollowRecordsRequest
   * @return FindTargetRelatedFollowRecordsResponse
   */
  async findTargetRelatedFollowRecords(request: FindTargetRelatedFollowRecordsRequest): Promise<FindTargetRelatedFollowRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FindTargetRelatedFollowRecordsHeaders({ });
    return await this.findTargetRelatedFollowRecordsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页获取所有客户的掉保时间数据
   *
   * @param request GetAllCustomerRecyclesRequest
   * @param headers GetAllCustomerRecyclesHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetAllCustomerRecyclesResponse
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
   * @summary 分页获取所有客户的掉保时间数据
   *
   * @param request GetAllCustomerRecyclesRequest
   * @return GetAllCustomerRecyclesResponse
   */
  async getAllCustomerRecycles(request: GetAllCustomerRecyclesRequest): Promise<GetAllCustomerRecyclesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllCustomerRecyclesHeaders({ });
    return await this.getAllCustomerRecyclesWithOptions(request, headers, runtime);
  }

  /**
   * @summary 根据指定条件查询联系人数据
   *
   * @param request GetContactsRequest
   * @param headers GetContactsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetContactsResponse
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
   * @summary 根据指定条件查询联系人数据
   *
   * @param request GetContactsRequest
   * @return GetContactsResponse
   */
  async getContacts(request: GetContactsRequest): Promise<GetContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetContactsHeaders({ });
    return await this.getContactsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取单个客户群
   *
   * @param headers GetCrmGroupChatHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetCrmGroupChatResponse
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
   * @summary 获取单个客户群
   *
   * @return GetCrmGroupChatResponse
   */
  async getCrmGroupChat(openConversationId: string): Promise<GetCrmGroupChatResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatHeaders({ });
    return await this.getCrmGroupChatWithOptions(openConversationId, headers, runtime);
  }

  /**
   * @summary 批量获取多个客户群
   *
   * @param request GetCrmGroupChatMultiRequest
   * @param headers GetCrmGroupChatMultiHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetCrmGroupChatMultiResponse
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
   * @summary 批量获取多个客户群
   *
   * @param request GetCrmGroupChatMultiRequest
   * @return GetCrmGroupChatMultiResponse
   */
  async getCrmGroupChatMulti(request: GetCrmGroupChatMultiRequest): Promise<GetCrmGroupChatMultiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatMultiHeaders({ });
    return await this.getCrmGroupChatMultiWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取单个客户群
   *
   * @param request GetCrmGroupChatSingleRequest
   * @param headers GetCrmGroupChatSingleHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetCrmGroupChatSingleResponse
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
   * @summary 获取单个客户群
   *
   * @param request GetCrmGroupChatSingleRequest
   * @return GetCrmGroupChatSingleResponse
   */
  async getCrmGroupChatSingle(request: GetCrmGroupChatSingleRequest): Promise<GetCrmGroupChatSingleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmGroupChatSingleHeaders({ });
    return await this.getCrmGroupChatSingleWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取CRM表单权限配置
   *
   * @param request GetCrmRolePermissionRequest
   * @param headers GetCrmRolePermissionHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetCrmRolePermissionResponse
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
   * @summary 获取CRM表单权限配置
   *
   * @param request GetCrmRolePermissionRequest
   * @return GetCrmRolePermissionResponse
   */
  async getCrmRolePermission(request: GetCrmRolePermissionRequest): Promise<GetCrmRolePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCrmRolePermissionHeaders({ });
    return await this.getCrmRolePermissionWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页获取某个客户的客户动态
   *
   * @param request GetCustomerTracksByRelationIdRequest
   * @param headers GetCustomerTracksByRelationIdHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetCustomerTracksByRelationIdResponse
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
   * @summary 分页获取某个客户的客户动态
   *
   * @param request GetCustomerTracksByRelationIdRequest
   * @return GetCustomerTracksByRelationIdResponse
   */
  async getCustomerTracksByRelationId(request: GetCustomerTracksByRelationIdRequest): Promise<GetCustomerTracksByRelationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCustomerTracksByRelationIdHeaders({ });
    return await this.getCustomerTracksByRelationIdWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询群组
   *
   * @param request GetGroupSetRequest
   * @param headers GetGroupSetHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetGroupSetResponse
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
   * @summary 查询群组
   *
   * @param request GetGroupSetRequest
   * @return GetGroupSetResponse
   */
  async getGroupSet(request: GetGroupSetRequest): Promise<GetGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetGroupSetHeaders({ });
    return await this.getGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取自定义导航挂靠节点结构
   *
   * @param request GetNavigationCatalogRequest
   * @param headers GetNavigationCatalogHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetNavigationCatalogResponse
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
   * @summary 获取自定义导航挂靠节点结构
   *
   * @param request GetNavigationCatalogRequest
   * @return GetNavigationCatalogResponse
   */
  async getNavigationCatalog(request: GetNavigationCatalogRequest): Promise<GetNavigationCatalogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNavigationCatalogHeaders({ });
    return await this.getNavigationCatalogWithOptions(request, headers, runtime);
  }

  /**
   * @summary 根据指定条件查询自定义对象数据
   *
   * @param request GetObjectDataRequest
   * @param headers GetObjectDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetObjectDataResponse
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
   * @summary 根据指定条件查询自定义对象数据
   *
   * @param request GetObjectDataRequest
   * @return GetObjectDataResponse
   */
  async getObjectData(request: GetObjectDataRequest): Promise<GetObjectDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetObjectDataHeaders({ });
    return await this.getObjectDataWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
   *
   * @param headers GetOfficialAccountContactInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetOfficialAccountContactInfoResponse
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
   * @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
   *
   * @return GetOfficialAccountContactInfoResponse
   */
  async getOfficialAccountContactInfo(userId: string): Promise<GetOfficialAccountContactInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountContactInfoHeaders({ });
    return await this.getOfficialAccountContactInfoWithOptions(userId, headers, runtime);
  }

  /**
   * @summary 分页获取服务窗联系人信息
   *
   * @param request GetOfficialAccountContactsRequest
   * @param headers GetOfficialAccountContactsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetOfficialAccountContactsResponse
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
   * @summary 分页获取服务窗联系人信息
   *
   * @param request GetOfficialAccountContactsRequest
   * @return GetOfficialAccountContactsResponse
   */
  async getOfficialAccountContacts(request: GetOfficialAccountContactsRequest): Promise<GetOfficialAccountContactsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountContactsHeaders({ });
    return await this.getOfficialAccountContactsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取服务窗消息发送的结果
   *
   * @param request GetOfficialAccountOTOMessageResultRequest
   * @param headers GetOfficialAccountOTOMessageResultHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetOfficialAccountOTOMessageResultResponse
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
   * @summary 获取服务窗消息发送的结果
   *
   * @param request GetOfficialAccountOTOMessageResultRequest
   * @return GetOfficialAccountOTOMessageResultResponse
   */
  async getOfficialAccountOTOMessageResult(request: GetOfficialAccountOTOMessageResultRequest): Promise<GetOfficialAccountOTOMessageResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountOTOMessageResultHeaders({ });
    return await this.getOfficialAccountOTOMessageResultWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取关系数据查重规则
   *
   * @param request GetRelationUkSettingRequest
   * @param headers GetRelationUkSettingHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetRelationUkSettingResponse
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
   * @summary 获取关系数据查重规则
   *
   * @param request GetRelationUkSettingRequest
   * @return GetRelationUkSettingResponse
   */
  async getRelationUkSetting(request: GetRelationUkSettingRequest): Promise<GetRelationUkSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelationUkSettingHeaders({ });
    return await this.getRelationUkSettingWithOptions(request, headers, runtime);
  }

  /**
   * @summary 加入群组
   *
   * @param request JoinGroupSetRequest
   * @param headers JoinGroupSetHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return JoinGroupSetResponse
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
   * @summary 加入群组
   *
   * @param request JoinGroupSetRequest
   * @return JoinGroupSetResponse
   */
  async joinGroupSet(request: JoinGroupSetRequest): Promise<JoinGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new JoinGroupSetHeaders({ });
    return await this.joinGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取线索标签列表
   *
   * @param headers ListClueTagHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return ListClueTagResponse
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
   * @summary 获取线索标签列表
   *
   * @return ListClueTagResponse
   */
  async listClueTag(): Promise<ListClueTagResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListClueTagHeaders({ });
    return await this.listClueTagWithOptions(headers, runtime);
  }

  /**
   * @summary 批量获取crm个人客户
   *
   * @param request ListCrmPersonalCustomersRequest
   * @param headers ListCrmPersonalCustomersHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return ListCrmPersonalCustomersResponse
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
   * @summary 批量获取crm个人客户
   *
   * @param request ListCrmPersonalCustomersRequest
   * @return ListCrmPersonalCustomersResponse
   */
  async listCrmPersonalCustomers(request: ListCrmPersonalCustomersRequest): Promise<ListCrmPersonalCustomersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCrmPersonalCustomersHeaders({ });
    return await this.listCrmPersonalCustomersWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询群组列表
   *
   * @param request ListGroupSetRequest
   * @param headers ListGroupSetHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return ListGroupSetResponse
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
   * @summary 查询群组列表
   *
   * @param request ListGroupSetRequest
   * @return ListGroupSetResponse
   */
  async listGroupSet(request: ListGroupSetRequest): Promise<ListGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListGroupSetHeaders({ });
    return await this.listGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
   *
   * @param request QueryAllCustomerRequest
   * @param headers QueryAllCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryAllCustomerResponse
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
   * @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
   *
   * @param request QueryAllCustomerRequest
   * @return QueryAllCustomerResponse
   */
  async queryAllCustomer(request: QueryAllCustomerRequest): Promise<QueryAllCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllCustomerHeaders({ });
    return await this.queryAllCustomerWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量查询企业客户动态
   *
   * @param request QueryAllTracksRequest
   * @param headers QueryAllTracksHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryAllTracksResponse
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
   * @summary 批量查询企业客户动态
   *
   * @param request QueryAllTracksRequest
   * @return QueryAllTracksResponse
   */
  async queryAllTracks(request: QueryAllTracksRequest): Promise<QueryAllTracksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllTracksHeaders({ });
    return await this.queryAllTracksWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询线索跟进状态
   *
   * @param request QueryClueFollowStatusRequest
   * @param headers QueryClueFollowStatusHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryClueFollowStatusResponse
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
   * @summary 查询线索跟进状态
   *
   * @param request QueryClueFollowStatusRequest
   * @return QueryClueFollowStatusResponse
   */
  async queryClueFollowStatus(request: QueryClueFollowStatusRequest): Promise<QueryClueFollowStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClueFollowStatusHeaders({ });
    return await this.queryClueFollowStatusWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询客户群
   *
   * @param request QueryCrmGroupChatsRequest
   * @param headers QueryCrmGroupChatsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCrmGroupChatsResponse
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
   * @summary 查询客户群
   *
   * @param request QueryCrmGroupChatsRequest
   * @return QueryCrmGroupChatsResponse
   */
  async queryCrmGroupChats(request: QueryCrmGroupChatsRequest): Promise<QueryCrmGroupChatsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmGroupChatsHeaders({ });
    return await this.queryCrmGroupChatsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 根据指定查询条件批量获取客户数据
   *
   * @param request QueryCrmPersonalCustomerRequest
   * @param headers QueryCrmPersonalCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCrmPersonalCustomerResponse
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
   * @summary 根据指定查询条件批量获取客户数据
   *
   * @param request QueryCrmPersonalCustomerRequest
   * @return QueryCrmPersonalCustomerResponse
   */
  async queryCrmPersonalCustomer(request: QueryCrmPersonalCustomerRequest): Promise<QueryCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmPersonalCustomerHeaders({ });
    return await this.queryCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询客户模板启用类型
   *
   * @param headers QueryCustomerBizTypeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCustomerBizTypeResponse
   */
  async queryCustomerBizTypeWithOptions(headers: QueryCustomerBizTypeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerBizTypeResponse> {
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
      action: "QueryCustomerBizType",
      version: "crm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/crm/orgSettings/templates/customerBizTypes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomerBizTypeResponse>(await this.execute(params, req, runtime), new QueryCustomerBizTypeResponse({}));
  }

  /**
   * @summary 查询客户模板启用类型
   *
   * @return QueryCustomerBizTypeResponse
   */
  async queryCustomerBizType(): Promise<QueryCustomerBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerBizTypeHeaders({ });
    return await this.queryCustomerBizTypeWithOptions(headers, runtime);
  }

  /**
   * @summary 营销服融合三方全局信息
   *
   * @param request QueryGlobalInfoRequest
   * @param headers QueryGlobalInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryGlobalInfoResponse
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
   * @summary 营销服融合三方全局信息
   *
   * @param request QueryGlobalInfoRequest
   * @return QueryGlobalInfoResponse
   */
  async queryGlobalInfo(request: QueryGlobalInfoRequest): Promise<QueryGlobalInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGlobalInfoHeaders({ });
    return await this.queryGlobalInfoWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询服务窗用户基础信息
   *
   * @param request QueryOfficialAccountUserBasicInfoRequest
   * @param headers QueryOfficialAccountUserBasicInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryOfficialAccountUserBasicInfoResponse
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
   * @summary 查询服务窗用户基础信息
   *
   * @param request QueryOfficialAccountUserBasicInfoRequest
   * @return QueryOfficialAccountUserBasicInfoResponse
   */
  async queryOfficialAccountUserBasicInfo(request: QueryOfficialAccountUserBasicInfoRequest): Promise<QueryOfficialAccountUserBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialAccountUserBasicInfoHeaders({ });
    return await this.queryOfficialAccountUserBasicInfoWithOptions(request, headers, runtime);
  }

  /**
   * @summary 根据targetId查询关系数据
   *
   * @param request QueryRelationDatasByTargetIdRequest
   * @param headers QueryRelationDatasByTargetIdHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryRelationDatasByTargetIdResponse
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
   * @summary 根据targetId查询关系数据
   *
   * @param request QueryRelationDatasByTargetIdRequest
   * @return QueryRelationDatasByTargetIdResponse
   */
  async queryRelationDatasByTargetId(targetId: string, request: QueryRelationDatasByTargetIdRequest): Promise<QueryRelationDatasByTargetIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRelationDatasByTargetIdHeaders({ });
    return await this.queryRelationDatasByTargetIdWithOptions(targetId, request, headers, runtime);
  }

  /**
   * @summary 服务窗消息撤回
   *
   * @param request RecallOfficialAccountOTOMessageRequest
   * @param headers RecallOfficialAccountOTOMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return RecallOfficialAccountOTOMessageResponse
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
   * @summary 服务窗消息撤回
   *
   * @param request RecallOfficialAccountOTOMessageRequest
   * @return RecallOfficialAccountOTOMessageResponse
   */
  async recallOfficialAccountOTOMessage(request: RecallOfficialAccountOTOMessageRequest): Promise<RecallOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallOfficialAccountOTOMessageHeaders({ });
    return await this.recallOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 服务窗单发接口，指定消息接收人发送
   *
   * @param request SendOfficialAccountOTOMessageRequest
   * @param headers SendOfficialAccountOTOMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SendOfficialAccountOTOMessageResponse
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
   * @summary 服务窗单发接口，指定消息接收人发送
   *
   * @param request SendOfficialAccountOTOMessageRequest
   * @return SendOfficialAccountOTOMessageResponse
   */
  async sendOfficialAccountOTOMessage(request: SendOfficialAccountOTOMessageRequest): Promise<SendOfficialAccountOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOfficialAccountOTOMessageHeaders({ });
    return await this.sendOfficialAccountOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 个人应用发送服务窗消息
   *
   * @param request SendOfficialAccountSNSMessageRequest
   * @param headers SendOfficialAccountSNSMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SendOfficialAccountSNSMessageResponse
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
   * @summary 个人应用发送服务窗消息
   *
   * @param request SendOfficialAccountSNSMessageRequest
   * @return SendOfficialAccountSNSMessageResponse
   */
  async sendOfficialAccountSNSMessage(request: SendOfficialAccountSNSMessageRequest): Promise<SendOfficialAccountSNSMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOfficialAccountSNSMessageHeaders({ });
    return await this.sendOfficialAccountSNSMessageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 服务窗消息群发
   *
   * @param request ServiceWindowMessageBatchPushRequest
   * @param headers ServiceWindowMessageBatchPushHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return ServiceWindowMessageBatchPushResponse
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
   * @summary 服务窗消息群发
   *
   * @param request ServiceWindowMessageBatchPushRequest
   * @return ServiceWindowMessageBatchPushResponse
   */
  async serviceWindowMessageBatchPush(request: ServiceWindowMessageBatchPushRequest): Promise<ServiceWindowMessageBatchPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ServiceWindowMessageBatchPushHeaders({ });
    return await this.serviceWindowMessageBatchPushWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新crm个人客户（或企业客户）
   *
   * @param request UpdateCrmPersonalCustomerRequest
   * @param headers UpdateCrmPersonalCustomerHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateCrmPersonalCustomerResponse
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
   * @summary 更新crm个人客户（或企业客户）
   *
   * @param request UpdateCrmPersonalCustomerRequest
   * @return UpdateCrmPersonalCustomerResponse
   */
  async updateCrmPersonalCustomer(request: UpdateCrmPersonalCustomerRequest): Promise<UpdateCrmPersonalCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCrmPersonalCustomerHeaders({ });
    return await this.updateCrmPersonalCustomerWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新客户模板类型
   *
   * @param request UpdateCustomerBizTypeRequest
   * @param headers UpdateCustomerBizTypeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateCustomerBizTypeResponse
   */
  async updateCustomerBizTypeWithOptions(request: UpdateCustomerBizTypeRequest, headers: UpdateCustomerBizTypeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCustomerBizTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customerBizType)) {
      body["customerBizType"] = request.customerBizType;
    }

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
   * @summary 更新客户模板类型
   *
   * @param request UpdateCustomerBizTypeRequest
   * @return UpdateCustomerBizTypeResponse
   */
  async updateCustomerBizType(request: UpdateCustomerBizTypeRequest): Promise<UpdateCustomerBizTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCustomerBizTypeHeaders({ });
    return await this.updateCustomerBizTypeWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新群组
   *
   * @param request UpdateGroupSetRequest
   * @param headers UpdateGroupSetHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateGroupSetResponse
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
   * @summary 更新群组
   *
   * @param request UpdateGroupSetRequest
   * @return UpdateGroupSetResponse
   */
  async updateGroupSet(request: UpdateGroupSetRequest): Promise<UpdateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupSetHeaders({ });
    return await this.updateGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * @summary 增量同步导航数据
   *
   * @param request UpdateMenuDataRequest
   * @param headers UpdateMenuDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateMenuDataResponse
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
   * @summary 增量同步导航数据
   *
   * @param request UpdateMenuDataRequest
   * @return UpdateMenuDataResponse
   */
  async updateMenuData(request: UpdateMenuDataRequest): Promise<UpdateMenuDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMenuDataHeaders({ });
    return await this.updateMenuDataWithOptions(request, headers, runtime);
  }

  /**
   * @summary 关系模型表结构更新字段
   *
   * @param request UpdateRelationMetaFieldRequest
   * @param headers UpdateRelationMetaFieldHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateRelationMetaFieldResponse
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
   * @summary 关系模型表结构更新字段
   *
   * @param request UpdateRelationMetaFieldRequest
   * @return UpdateRelationMetaFieldResponse
   */
  async updateRelationMetaField(request: UpdateRelationMetaFieldRequest): Promise<UpdateRelationMetaFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRelationMetaFieldHeaders({ });
    return await this.updateRelationMetaFieldWithOptions(request, headers, runtime);
  }

}
