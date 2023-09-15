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

export class AppLoginCodeGenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppLoginCodeGenRequest extends $tea.Model {
  appKey?: string;
  signTimestampStr?: string;
  signature?: string;
  fullUrl?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appKey: 'appKey',
      signTimestampStr: 'signTimestampStr',
      signature: 'signature',
      fullUrl: 'fullUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appKey: 'string',
      signTimestampStr: 'string',
      signature: 'string',
      fullUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppLoginCodeGenResponseBody extends $tea.Model {
  loginCode?: string;
  static names(): { [key: string]: string } {
    return {
      loginCode: 'loginCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      loginCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppLoginCodeGenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AppLoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AppLoginCodeGenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListRequest extends $tea.Model {
  appType?: string;
  formInstanceIdList?: string[];
  formUuid?: string;
  needFormInstanceValue?: boolean;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formInstanceIdList: 'formInstanceIdList',
      formUuid: 'formUuid',
      needFormInstanceValue: 'needFormInstanceValue',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formInstanceIdList: { 'type': 'array', 'itemType': 'string' },
      formUuid: 'string',
      needFormInstanceValue: 'boolean',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBody extends $tea.Model {
  result?: BatchGetFormDataByIdListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': BatchGetFormDataByIdListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchGetFormDataByIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchGetFormDataByIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemovalByFormInstanceIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemovalByFormInstanceIdListRequest extends $tea.Model {
  appType?: string;
  asynchronousExecution?: boolean;
  executeExpression?: boolean;
  formInstanceIdList?: string[];
  formUuid?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      asynchronousExecution: 'asynchronousExecution',
      executeExpression: 'executeExpression',
      formInstanceIdList: 'formInstanceIdList',
      formUuid: 'formUuid',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      asynchronousExecution: 'boolean',
      executeExpression: 'boolean',
      formInstanceIdList: { 'type': 'array', 'itemType': 'string' },
      formUuid: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRemovalByFormInstanceIdListResponse extends $tea.Model {
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

export class BatchSaveFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSaveFormDataRequest extends $tea.Model {
  appType?: string;
  asynchronousExecution?: boolean;
  formDataJsonList?: string[];
  formUuid?: string;
  keepRunningAfterException?: boolean;
  noExecuteExpression?: boolean;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      asynchronousExecution: 'asynchronousExecution',
      formDataJsonList: 'formDataJsonList',
      formUuid: 'formUuid',
      keepRunningAfterException: 'keepRunningAfterException',
      noExecuteExpression: 'noExecuteExpression',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      asynchronousExecution: 'boolean',
      formDataJsonList: { 'type': 'array', 'itemType': 'string' },
      formUuid: 'string',
      keepRunningAfterException: 'boolean',
      noExecuteExpression: 'boolean',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSaveFormDataResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSaveFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchSaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchSaveFormDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceIdRequest extends $tea.Model {
  appType?: string;
  asynchronousExecution?: boolean;
  formInstanceIdList?: string[];
  formUuid?: string;
  ignoreEmpty?: boolean;
  noExecuteExpression?: boolean;
  systemToken?: string;
  updateFormDataJson?: string;
  useLatestFormSchemaVersion?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      asynchronousExecution: 'asynchronousExecution',
      formInstanceIdList: 'formInstanceIdList',
      formUuid: 'formUuid',
      ignoreEmpty: 'ignoreEmpty',
      noExecuteExpression: 'noExecuteExpression',
      systemToken: 'systemToken',
      updateFormDataJson: 'updateFormDataJson',
      useLatestFormSchemaVersion: 'useLatestFormSchemaVersion',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      asynchronousExecution: 'boolean',
      formInstanceIdList: { 'type': 'array', 'itemType': 'string' },
      formUuid: 'string',
      ignoreEmpty: 'boolean',
      noExecuteExpression: 'boolean',
      systemToken: 'string',
      updateFormDataJson: 'string',
      useLatestFormSchemaVersion: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceIdResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchUpdateFormDataByInstanceIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchUpdateFormDataByInstanceIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceMapHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceMapRequest extends $tea.Model {
  appType?: string;
  asynchronousExecution?: boolean;
  formUuid?: string;
  ignoreEmpty?: boolean;
  noExecuteExpression?: boolean;
  systemToken?: string;
  updateFormDataJsonMap?: { [key: string]: any };
  useLatestFormSchemaVersion?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      asynchronousExecution: 'asynchronousExecution',
      formUuid: 'formUuid',
      ignoreEmpty: 'ignoreEmpty',
      noExecuteExpression: 'noExecuteExpression',
      systemToken: 'systemToken',
      updateFormDataJsonMap: 'updateFormDataJsonMap',
      useLatestFormSchemaVersion: 'useLatestFormSchemaVersion',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      asynchronousExecution: 'boolean',
      formUuid: 'string',
      ignoreEmpty: 'boolean',
      noExecuteExpression: 'boolean',
      systemToken: 'string',
      updateFormDataJsonMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      useLatestFormSchemaVersion: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceMapResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateFormDataByInstanceMapResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchUpdateFormDataByInstanceMapResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchUpdateFormDataByInstanceMapResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyAuthorizationOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyAuthorizationOrderRequest extends $tea.Model {
  accessKey?: string;
  accountNumber?: string;
  beginTimeGMT?: number;
  callerUnionId?: string;
  chargeType?: string;
  commerceType?: string;
  commodityType?: string;
  endTimeGMT?: number;
  instanceId?: string;
  instanceName?: string;
  produceCode?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      accountNumber: 'accountNumber',
      beginTimeGMT: 'beginTimeGMT',
      callerUnionId: 'callerUnionId',
      chargeType: 'chargeType',
      commerceType: 'commerceType',
      commodityType: 'commodityType',
      endTimeGMT: 'endTimeGMT',
      instanceId: 'instanceId',
      instanceName: 'instanceName',
      produceCode: 'produceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      accountNumber: 'string',
      beginTimeGMT: 'number',
      callerUnionId: 'string',
      chargeType: 'string',
      commerceType: 'string',
      commodityType: 'string',
      endTimeGMT: 'number',
      instanceId: 'string',
      instanceName: 'string',
      produceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyAuthorizationOrderResponseBody extends $tea.Model {
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

export class BuyAuthorizationOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BuyAuthorizationOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BuyAuthorizationOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyFreshOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyFreshOrderRequest extends $tea.Model {
  accessKey?: string;
  accountNumber?: string;
  beginTimeGMT?: number;
  callerUnionId?: string;
  chargeType?: string;
  commerceType?: string;
  commodityType?: string;
  endTimeGMT?: number;
  instanceId?: string;
  instanceName?: string;
  produceCode?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      accountNumber: 'accountNumber',
      beginTimeGMT: 'beginTimeGMT',
      callerUnionId: 'callerUnionId',
      chargeType: 'chargeType',
      commerceType: 'commerceType',
      commodityType: 'commodityType',
      endTimeGMT: 'endTimeGMT',
      instanceId: 'instanceId',
      instanceName: 'instanceName',
      produceCode: 'produceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      accountNumber: 'string',
      beginTimeGMT: 'number',
      callerUnionId: 'string',
      chargeType: 'string',
      commerceType: 'string',
      commodityType: 'string',
      endTimeGMT: 'number',
      instanceId: 'string',
      instanceName: 'string',
      produceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyFreshOrderResponseBody extends $tea.Model {
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

export class BuyFreshOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BuyFreshOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BuyFreshOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckCloudAccountStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckCloudAccountStatusRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckCloudAccountStatusResponseBody extends $tea.Model {
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

export class CheckCloudAccountStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CheckCloudAccountStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CheckCloudAccountStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrUpdateFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrUpdateFormDataRequest extends $tea.Model {
  appType?: string;
  formDataJson?: string;
  formUuid?: string;
  noExecuteExpression?: boolean;
  searchCondition?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formDataJson: 'formDataJson',
      formUuid: 'formUuid',
      noExecuteExpression: 'noExecuteExpression',
      searchCondition: 'searchCondition',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formDataJson: 'string',
      formUuid: 'string',
      noExecuteExpression: 'boolean',
      searchCondition: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrUpdateFormDataResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrUpdateFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateOrUpdateFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateOrUpdateFormDataResponseBody,
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
  formInstanceId?: string;
  language?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formInstanceId: 'formInstanceId',
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formInstanceId: 'string',
      language: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataResponse extends $tea.Model {
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
  language?: string;
  processInstanceId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processInstanceId: 'processInstanceId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processInstanceId: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceResponse extends $tea.Model {
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
  appType?: string;
  language?: string;
  sequence?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      sequence: 'sequence',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      sequence: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceResponse extends $tea.Model {
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

export class DeployFunctionCallbackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeployFunctionCallbackRequest extends $tea.Model {
  appId?: string;
  customDomain?: string;
  deployStage?: string;
  gateWayAppKey?: string;
  gateWayAppSecret?: string;
  gateWayDomain?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      customDomain: 'customDomain',
      deployStage: 'deployStage',
      gateWayAppKey: 'gateWayAppKey',
      gateWayAppSecret: 'gateWayAppSecret',
      gateWayDomain: 'gateWayDomain',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      customDomain: 'string',
      deployStage: 'string',
      gateWayAppKey: 'string',
      gateWayAppSecret: 'string',
      gateWayDomain: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeployFunctionCallbackResponseBody extends $tea.Model {
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

export class DeployFunctionCallbackResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeployFunctionCallbackResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeployFunctionCallbackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteBatchTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteBatchTaskRequest extends $tea.Model {
  appType?: string;
  outResult?: string;
  remark?: string;
  systemToken?: string;
  taskInformationList?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      outResult: 'outResult',
      remark: 'remark',
      systemToken: 'systemToken',
      taskInformationList: 'taskInformationList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      outResult: 'string',
      remark: 'string',
      systemToken: 'string',
      taskInformationList: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteBatchTaskResponseBody extends $tea.Model {
  failNumber?: number;
  successNumber?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      failNumber: 'failNumber',
      successNumber: 'successNumber',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failNumber: 'number',
      successNumber: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteBatchTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ExecuteBatchTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ExecuteBatchTaskResponseBody,
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
  appType?: string;
  data?: string;
  language?: string;
  serviceId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      data: 'data',
      language: 'language',
      serviceId: 'serviceId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      data: 'string',
      language: 'string',
      serviceId: 'string',
      systemToken: 'string',
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
  statusCode: number;
  body: ExecuteCustomApiResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ExecuteCustomApiResponseBody,
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
  appType?: string;
  formDataJson?: string;
  language?: string;
  noExecuteExpressions?: string;
  outResult?: string;
  processInstanceId?: string;
  remark?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formDataJson: 'formDataJson',
      language: 'language',
      noExecuteExpressions: 'noExecuteExpressions',
      outResult: 'outResult',
      processInstanceId: 'processInstanceId',
      remark: 'remark',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formDataJson: 'string',
      language: 'string',
      noExecuteExpressions: 'string',
      outResult: 'string',
      processInstanceId: 'string',
      remark: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecutePlatformTaskResponse extends $tea.Model {
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
  appType?: string;
  digitalSignUrl?: string;
  formDataJson?: string;
  language?: string;
  noExecuteExpressions?: string;
  outResult?: string;
  processInstanceId?: string;
  remark?: string;
  systemToken?: string;
  taskId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      digitalSignUrl: 'digitalSignUrl',
      formDataJson: 'formDataJson',
      language: 'language',
      noExecuteExpressions: 'noExecuteExpressions',
      outResult: 'outResult',
      processInstanceId: 'processInstanceId',
      remark: 'remark',
      systemToken: 'systemToken',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      digitalSignUrl: 'string',
      formDataJson: 'string',
      language: 'string',
      noExecuteExpressions: 'string',
      outResult: 'string',
      processInstanceId: 'string',
      remark: 'string',
      systemToken: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskResponse extends $tea.Model {
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
  accessKey?: string;
  callerUid?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      instanceId: 'string',
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
  statusCode: number;
  body: ExpireCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ExpireCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdResponseBody extends $tea.Model {
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

export class GetActivationCodeByCallerUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetActivationCodeByCallerUnionIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetActivationCodeByCallerUnionIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListRequest extends $tea.Model {
  language?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      language: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListResponseBody extends $tea.Model {
  result?: GetActivityButtonListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetActivityButtonListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetActivityButtonListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetActivityButtonListResponseBody,
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
  appType?: string;
  language?: string;
  processCode?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processCode: 'processCode',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processCode: 'string',
      systemToken: 'string',
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
  statusCode: number;
  body: GetActivityListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetActivityListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesRequest extends $tea.Model {
  appType?: string;
  corpId?: string;
  keywords?: string;
  pageNumber?: number;
  pageSize?: number;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      corpId: 'corpId',
      keywords: 'keywords',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      corpId: 'string',
      keywords: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesResponseBody extends $tea.Model {
  count?: number;
  result?: GetAllAuthCubesResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      result: { 'type': 'array', 'itemType': GetAllAuthCubesResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAllAuthCubesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAllAuthCubesResponseBody,
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
  accessKey?: string;
  callerUid?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceResponseBody extends $tea.Model {
  accountTotalAmount?: number;
  accountUsageAmount?: number;
  appTotalAmount?: number;
  attachmentTotalAmount?: number;
  attachmentUsageAmount?: number;
  instanceId?: string;
  instanceTotalAmount?: number;
  instanceUsageAmount?: number;
  pluginUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      accountTotalAmount: 'accountTotalAmount',
      accountUsageAmount: 'accountUsageAmount',
      appTotalAmount: 'appTotalAmount',
      attachmentTotalAmount: 'attachmentTotalAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
      instanceId: 'instanceId',
      instanceTotalAmount: 'instanceTotalAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      pluginUsageAmount: 'pluginUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountTotalAmount: 'number',
      accountUsageAmount: 'number',
      appTotalAmount: 'number',
      attachmentTotalAmount: 'number',
      attachmentUsageAmount: 'number',
      instanceId: 'string',
      instanceTotalAmount: 'number',
      instanceUsageAmount: 'number',
      pluginUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetApplicationAuthorizationServicePlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetApplicationAuthorizationServicePlatformResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksRequest extends $tea.Model {
  appTypes?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  keyword?: string;
  language?: string;
  pageNumber?: number;
  pageSize?: number;
  processCodes?: string;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      appTypes: 'appTypes',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      keyword: 'keyword',
      language: 'language',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processCodes: 'processCodes',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTypes: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      keyword: 'string',
      language: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      processCodes: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksResponseBody extends $tea.Model {
  data?: GetCorpAccomplishmentTasksResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetCorpAccomplishmentTasksResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCorpAccomplishmentTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetCorpAccomplishmentTasksResponseBody,
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
  statusCode: number;
  body: GetCorpLevelByAccountIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetCorpLevelByAccountIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksRequest extends $tea.Model {
  appTypes?: string;
  corpId?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  keyword?: string;
  language?: string;
  pageNumber?: number;
  pageSize?: number;
  processCodes?: string;
  token?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appTypes: 'appTypes',
      corpId: 'corpId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      keyword: 'keyword',
      language: 'language',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processCodes: 'processCodes',
      token: 'token',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTypes: 'string',
      corpId: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      keyword: 'string',
      language: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      processCodes: 'string',
      token: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksResponseBody extends $tea.Model {
  data?: GetCorpTasksResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetCorpTasksResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCorpTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetCorpTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDbConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDbConfigRequest extends $tea.Model {
  appType?: string;
  corpId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      corpId: 'corpId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      corpId: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDbConfigResponseBody extends $tea.Model {
  config?: string;
  corpId?: string;
  createTimeGMT?: string;
  creator?: string;
  exclusive?: string;
  id?: string;
  modifiedTimeGMT?: string;
  modifier?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      config: 'config',
      corpId: 'corpId',
      createTimeGMT: 'createTimeGMT',
      creator: 'creator',
      exclusive: 'exclusive',
      id: 'id',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifier: 'modifier',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      config: 'string',
      corpId: 'string',
      createTimeGMT: 'string',
      creator: 'string',
      exclusive: 'string',
      id: 'string',
      modifiedTimeGMT: 'string',
      modifier: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDbConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDbConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetDbConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldDefByUuidHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldDefByUuidRequest extends $tea.Model {
  appType?: string;
  formUuid?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formUuid: 'formUuid',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formUuid: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldDefByUuidResponseBody extends $tea.Model {
  result?: GetFieldDefByUuidResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetFieldDefByUuidResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldDefByUuidResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFieldDefByUuidResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFieldDefByUuidResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListRequest extends $tea.Model {
  language?: string;
  systemToken?: string;
  userId?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      language: 'string',
      systemToken: 'string',
      userId: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListResponseBody extends $tea.Model {
  result?: GetFormComponentDefinitionListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetFormComponentDefinitionListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFormComponentDefinitionListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFormComponentDefinitionListResponseBody,
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
  language?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBody extends $tea.Model {
  formData?: { [key: string]: any };
  formInstId?: string;
  modifiedTimeGMT?: string;
  originator?: GetFormDataByIDResponseBodyOriginator;
  static names(): { [key: string]: string } {
    return {
      formData: 'formData',
      formInstId: 'formInstId',
      modifiedTimeGMT: 'modifiedTimeGMT',
      originator: 'originator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstId: 'string',
      modifiedTimeGMT: 'string',
      originator: GetFormDataByIDResponseBodyOriginator,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFormDataByIDResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFormDataByIDResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppRequest extends $tea.Model {
  appType?: string;
  formTypes?: string;
  pageNumber?: number;
  pageSize?: number;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formTypes: 'formTypes',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formTypes: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppResponseBody extends $tea.Model {
  result?: GetFormListInAppResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetFormListInAppResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFormListInAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFormListInAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdRequest extends $tea.Model {
  appType?: string;
  language?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBody extends $tea.Model {
  actionExecutor?: GetInstanceByIdResponseBodyActionExecutor[];
  approvedResult?: string;
  createTimeGMT?: string;
  data?: { [key: string]: any };
  formUuid?: string;
  instanceStatus?: string;
  modifiedTimeGMT?: string;
  originator?: GetInstanceByIdResponseBodyOriginator;
  processCode?: string;
  processInstanceId?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionExecutor: 'actionExecutor',
      approvedResult: 'approvedResult',
      createTimeGMT: 'createTimeGMT',
      data: 'data',
      formUuid: 'formUuid',
      instanceStatus: 'instanceStatus',
      modifiedTimeGMT: 'modifiedTimeGMT',
      originator: 'originator',
      processCode: 'processCode',
      processInstanceId: 'processInstanceId',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionExecutor: { 'type': 'array', 'itemType': GetInstanceByIdResponseBodyActionExecutor },
      approvedResult: 'string',
      createTimeGMT: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formUuid: 'string',
      instanceStatus: 'string',
      modifiedTimeGMT: 'string',
      originator: GetInstanceByIdResponseBodyOriginator,
      processCode: 'string',
      processInstanceId: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetInstanceByIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetInstanceByIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListRequest extends $tea.Model {
  appType?: string;
  approvedResult?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  formUuid?: string;
  instanceStatus?: string;
  language?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  originatorId?: string;
  searchFieldJson?: string;
  systemToken?: string;
  taskId?: string;
  userId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      approvedResult: 'approvedResult',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      formUuid: 'formUuid',
      instanceStatus: 'instanceStatus',
      language: 'language',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      originatorId: 'originatorId',
      searchFieldJson: 'searchFieldJson',
      systemToken: 'systemToken',
      taskId: 'taskId',
      userId: 'userId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      approvedResult: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      formUuid: 'string',
      instanceStatus: 'string',
      language: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      originatorId: 'string',
      searchFieldJson: 'string',
      systemToken: 'string',
      taskId: 'string',
      userId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListResponseBody extends $tea.Model {
  data?: string[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': 'string' },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetInstanceIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetInstanceIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesRequest extends $tea.Model {
  appType?: string;
  approvedResult?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  formUuid?: string;
  instanceStatus?: string;
  language?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  orderConfigJson?: string;
  originatorId?: string;
  searchFieldJson?: string;
  systemToken?: string;
  taskId?: string;
  userId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      approvedResult: 'approvedResult',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      formUuid: 'formUuid',
      instanceStatus: 'instanceStatus',
      language: 'language',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      orderConfigJson: 'orderConfigJson',
      originatorId: 'originatorId',
      searchFieldJson: 'searchFieldJson',
      systemToken: 'systemToken',
      taskId: 'taskId',
      userId: 'userId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      approvedResult: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      formUuid: 'string',
      instanceStatus: 'string',
      language: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      orderConfigJson: 'string',
      originatorId: 'string',
      searchFieldJson: 'string',
      systemToken: 'string',
      taskId: 'string',
      userId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBody extends $tea.Model {
  data?: GetInstancesResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetInstancesResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListRequest extends $tea.Model {
  appType?: string;
  language?: string;
  processInstanceIds?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processInstanceIds: 'processInstanceIds',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processInstanceIds: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBody extends $tea.Model {
  result?: GetInstancesByIdListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetInstancesByIdListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetInstancesByIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetInstancesByIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionRequest extends $tea.Model {
  appTypes?: string;
  corpId?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  keyword?: string;
  language?: string;
  pageNumber?: number;
  pageSize?: number;
  processCodes?: string;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      appTypes: 'appTypes',
      corpId: 'corpId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      keyword: 'keyword',
      language: 'language',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processCodes: 'processCodes',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTypes: 'string',
      corpId: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      keyword: 'string',
      language: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      processCodes: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBody extends $tea.Model {
  data?: GetMeCorpSubmissionResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetMeCorpSubmissionResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMeCorpSubmissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetMeCorpSubmissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeRequest extends $tea.Model {
  appTypes?: string;
  corpId?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  instanceCreateFromTimeGMT?: number;
  instanceCreateToTimeGMT?: number;
  keyword?: string;
  language?: string;
  pageNumber?: number;
  pageSize?: number;
  processCodes?: string;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      appTypes: 'appTypes',
      corpId: 'corpId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      instanceCreateFromTimeGMT: 'instanceCreateFromTimeGMT',
      instanceCreateToTimeGMT: 'instanceCreateToTimeGMT',
      keyword: 'keyword',
      language: 'language',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processCodes: 'processCodes',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTypes: 'string',
      corpId: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      instanceCreateFromTimeGMT: 'number',
      instanceCreateToTimeGMT: 'number',
      keyword: 'string',
      language: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      processCodes: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeResponseBody extends $tea.Model {
  data?: GetNotifyMeResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetNotifyMeResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetNotifyMeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetNotifyMeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlRequest extends $tea.Model {
  fileUrl?: string;
  language?: string;
  systemToken?: string;
  timeout?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      fileUrl: 'fileUrl',
      language: 'language',
      systemToken: 'systemToken',
      timeout: 'timeout',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileUrl: 'string',
      language: 'string',
      systemToken: 'string',
      timeout: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlResponseBody extends $tea.Model {
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

export class GetOpenUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOpenUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetOpenUrlResponseBody,
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
  language?: string;
  processInstanceId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processInstanceId: 'processInstanceId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processInstanceId: 'string',
      systemToken: 'string',
      userId: 'string',
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
  statusCode: number;
  body: GetOperationRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  accessKey?: string;
  callerUid?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceResponseBody extends $tea.Model {
  accountTotalAmount?: number;
  accountUsageAmount?: number;
  appTotalAmount?: number;
  attachmentTotalAmount?: number;
  attachmentUsageAmount?: number;
  instanceTotalAmount?: number;
  instanceUsageAmount?: number;
  pluginUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      accountTotalAmount: 'accountTotalAmount',
      accountUsageAmount: 'accountUsageAmount',
      appTotalAmount: 'appTotalAmount',
      attachmentTotalAmount: 'attachmentTotalAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
      instanceTotalAmount: 'instanceTotalAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      pluginUsageAmount: 'pluginUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountTotalAmount: 'number',
      accountUsageAmount: 'number',
      appTotalAmount: 'number',
      attachmentTotalAmount: 'number',
      attachmentUsageAmount: 'number',
      instanceTotalAmount: 'number',
      instanceUsageAmount: 'number',
      pluginUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPlatformResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoRequest extends $tea.Model {
  nameLike?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      nameLike: 'nameLike',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameLike: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponseBody extends $tea.Model {
  result?: GetPrintAppInfoResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetPrintAppInfoResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPrintAppInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPrintAppInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryRequest extends $tea.Model {
  appType?: string;
  formUuid?: string;
  userId?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formUuid: 'formUuid',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formUuid: 'string',
      userId: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryResponseBody extends $tea.Model {
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

export class GetPrintDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPrintDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPrintDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionRequest extends $tea.Model {
  appType?: string;
  corpId?: string;
  groupId?: string;
  language?: string;
  nameSpace?: string;
  orderNumber?: string;
  systemToken?: string;
  systemType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      corpId: 'corpId',
      groupId: 'groupId',
      language: 'language',
      nameSpace: 'nameSpace',
      orderNumber: 'orderNumber',
      systemToken: 'systemToken',
      systemType: 'systemType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      corpId: 'string',
      groupId: 'string',
      language: 'string',
      nameSpace: 'string',
      orderNumber: 'string',
      systemToken: 'string',
      systemType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBody extends $tea.Model {
  formUuid?: string;
  originator?: GetProcessDefinitionResponseBodyOriginator;
  outResult?: string;
  owners?: GetProcessDefinitionResponseBodyOwners[];
  processId?: string;
  processInstanceId?: string;
  status?: string;
  tasks?: GetProcessDefinitionResponseBodyTasks[];
  title?: string;
  variables?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      originator: 'originator',
      outResult: 'outResult',
      owners: 'owners',
      processId: 'processId',
      processInstanceId: 'processInstanceId',
      status: 'status',
      tasks: 'tasks',
      title: 'title',
      variables: 'variables',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      originator: GetProcessDefinitionResponseBodyOriginator,
      outResult: 'string',
      owners: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyOwners },
      processId: 'string',
      processInstanceId: 'string',
      status: 'string',
      tasks: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyTasks },
      title: 'string',
      variables: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetProcessDefinitionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProcessDefinitionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListRequest extends $tea.Model {
  appType?: string;
  processInstanceIdList?: string;
  systemToken?: string;
  userCorpId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      processInstanceIdList: 'processInstanceIdList',
      systemToken: 'systemToken',
      userCorpId: 'userCorpId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      processInstanceIdList: 'string',
      systemToken: 'string',
      userCorpId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListResponseBody extends $tea.Model {
  result?: GetRunningTaskListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetRunningTaskListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRunningTaskListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetRunningTaskListResponseBody,
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
  appType?: string;
  language?: string;
  processInstanceId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processInstanceId: 'processInstanceId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processInstanceId: 'string',
      systemToken: 'string',
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
  statusCode: number;
  body: GetRunningTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetRunningTasksResponseBody,
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
  accountId?: number;
  corpList?: GetSaleUserInfoByUserIdResponseBodyCorpList[];
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      corpList: 'corpList',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'number',
      corpList: { 'type': 'array', 'itemType': GetSaleUserInfoByUserIdResponseBodyCorpList },
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSaleUserInfoByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSaleUserInfoByUserIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleCubeModelListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleCubeModelListRequest extends $tea.Model {
  appType?: string;
  corpId?: string;
  cubeCode?: string;
  cubeTenantId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      corpId: 'corpId',
      cubeCode: 'cubeCode',
      cubeTenantId: 'cubeTenantId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      corpId: 'string',
      cubeCode: 'string',
      cubeTenantId: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleCubeModelListResponseBody extends $tea.Model {
  result?: GetSimpleCubeModelListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetSimpleCubeModelListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleCubeModelListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSimpleCubeModelListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSimpleCubeModelListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesRequest extends $tea.Model {
  appType?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  keyword?: string;
  language?: string;
  pageNumber?: number;
  pageSize?: number;
  processCodes?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      keyword: 'keyword',
      language: 'language',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processCodes: 'processCodes',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      keyword: 'string',
      language: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      processCodes: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponseBody extends $tea.Model {
  data?: GetTaskCopiesResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetTaskCopiesResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTaskCopiesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetTaskCopiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationRequest extends $tea.Model {
  appFilter?: string;
  appNameSearchKeyword?: string;
  corpId?: string;
  pageNumber?: number;
  pageSize?: number;
  token?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appFilter: 'appFilter',
      appNameSearchKeyword: 'appNameSearchKeyword',
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      token: 'token',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appFilter: 'string',
      appNameSearchKeyword: 'string',
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      token: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationResponseBody extends $tea.Model {
  data?: ListApplicationResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': ListApplicationResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListApplicationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListApplicationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponseBody extends $tea.Model {
  applicationInformation?: ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      applicationInformation: 'applicationInformation',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applicationInformation: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListApplicationAuthorizationServiceApplicationInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListApplicationAuthorizationServiceApplicationInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponseBody extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  plugInformation?: ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      plugInformation: 'plugInformation',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      plugInformation: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListApplicationAuthorizationServiceConnectorInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListApplicationAuthorizationServiceConnectorInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponseBody extends $tea.Model {
  applicationInformation?: ListApplicationInformationResponseBodyApplicationInformation[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      applicationInformation: 'applicationInformation',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applicationInformation: { 'type': 'array', 'itemType': ListApplicationInformationResponseBodyApplicationInformation },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListApplicationInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListApplicationInformationResponseBody,
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
  callerUid?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponseBody extends $tea.Model {
  commodityVOList?: ListCommodityResponseBodyCommodityVOList[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      commodityVOList: 'commodityVOList',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commodityVOList: { 'type': 'array', 'itemType': ListCommodityResponseBodyCommodityVOList },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponseBody extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  pluginInfos?: ListConnectorInformationResponseBodyPluginInfos[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      pluginInfos: 'pluginInfos',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      pluginInfos: { 'type': 'array', 'itemType': ListConnectorInformationResponseBodyPluginInfos },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListConnectorInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListConnectorInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormRemarksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormRemarksRequest extends $tea.Model {
  appType?: string;
  formInstanceIdList?: string[];
  formUuid?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formInstanceIdList: 'formInstanceIdList',
      formUuid: 'formUuid',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formInstanceIdList: { 'type': 'array', 'itemType': 'string' },
      formUuid: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormRemarksResponseBody extends $tea.Model {
  formRemarkVoMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      formRemarkVoMap: 'formRemarkVoMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formRemarkVoMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFormRemarksResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListFormRemarksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListFormRemarksResponseBody,
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
  formType?: string;
  language?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formType: 'formType',
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formType: 'string',
      language: 'string',
      systemToken: 'string',
      userId: 'string',
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
  statusCode: number;
  body: ListNavigationByFormTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListNavigationByFormTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOperationLogsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOperationLogsRequest extends $tea.Model {
  appType?: string;
  formInstanceIdList?: string[];
  formUuid?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formInstanceIdList: 'formInstanceIdList',
      formUuid: 'formUuid',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formInstanceIdList: { 'type': 'array', 'itemType': 'string' },
      formUuid: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOperationLogsResponseBody extends $tea.Model {
  operationLogMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      operationLogMap: 'operationLogMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operationLogMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOperationLogsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListOperationLogsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListOperationLogsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdRequest extends $tea.Model {
  appType?: string;
  formUuid?: string;
  pageNumber?: number;
  pageSize?: number;
  systemToken?: string;
  tableFieldId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formUuid: 'formUuid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      systemToken: 'systemToken',
      tableFieldId: 'tableFieldId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formUuid: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      systemToken: 'string',
      tableFieldId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdResponseBody extends $tea.Model {
  data?: { [key: string]: any }[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListTableDataByFormInstanceIdTableIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListTableDataByFormInstanceIdTableIdResponseBody,
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
  statusCode: number;
  body: LoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: LoginCodeGenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyAuthorizationResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyAuthorizationResultRequest extends $tea.Model {
  accessKey?: string;
  accountNumber?: string;
  beginTimeGMT?: number;
  callerUid?: string;
  chargeType?: string;
  commerceType?: string;
  commodityType?: string;
  endTimeGMT?: number;
  instanceId?: string;
  instanceName?: string;
  produceCode?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      accountNumber: 'accountNumber',
      beginTimeGMT: 'beginTimeGMT',
      callerUid: 'callerUid',
      chargeType: 'chargeType',
      commerceType: 'commerceType',
      commodityType: 'commodityType',
      endTimeGMT: 'endTimeGMT',
      instanceId: 'instanceId',
      instanceName: 'instanceName',
      produceCode: 'produceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      accountNumber: 'string',
      beginTimeGMT: 'number',
      callerUid: 'string',
      chargeType: 'string',
      commerceType: 'string',
      commodityType: 'string',
      endTimeGMT: 'number',
      instanceId: 'string',
      instanceName: 'string',
      produceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyAuthorizationResultResponseBody extends $tea.Model {
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

export class NotifyAuthorizationResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: NotifyAuthorizationResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: NotifyAuthorizationResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosRequest extends $tea.Model {
  appKey?: string;
  formTypeList?: string[];
  language?: string;
  pageIndex?: number;
  pageSize?: number;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appKey: 'appKey',
      formTypeList: 'formTypeList',
      language: 'language',
      pageIndex: 'pageIndex',
      pageSize: 'pageSize',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appKey: 'string',
      formTypeList: { 'type': 'array', 'itemType': 'string' },
      language: 'string',
      pageIndex: 'number',
      pageSize: 'number',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosResponseBody extends $tea.Model {
  result?: PageFormBaseInfosResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PageFormBaseInfosResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PageFormBaseInfosResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PageFormBaseInfosResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceRecordRequest extends $tea.Model {
  appType?: string;
  formUuid?: string;
  hookType?: string;
  hookUuid?: string;
  instanceId?: string;
  invokeAfterDateGMT?: string;
  invokeBeforeDateGMT?: string;
  invokeStatus?: string;
  pageNumber?: number;
  pageSize?: number;
  requestUrl?: string;
  sourceUuid?: string;
  success?: boolean;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formUuid: 'formUuid',
      hookType: 'hookType',
      hookUuid: 'hookUuid',
      instanceId: 'instanceId',
      invokeAfterDateGMT: 'invokeAfterDateGMT',
      invokeBeforeDateGMT: 'invokeBeforeDateGMT',
      invokeStatus: 'invokeStatus',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      requestUrl: 'requestUrl',
      sourceUuid: 'sourceUuid',
      success: 'success',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formUuid: 'string',
      hookType: 'string',
      hookUuid: 'string',
      instanceId: 'string',
      invokeAfterDateGMT: 'string',
      invokeBeforeDateGMT: 'string',
      invokeStatus: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      requestUrl: 'string',
      sourceUuid: 'string',
      success: 'boolean',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceRecordResponseBody extends $tea.Model {
  totalCount?: number;
  values?: QueryServiceRecordResponseBodyValues[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      values: { 'type': 'array', 'itemType': QueryServiceRecordResponseBodyValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryServiceRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryServiceRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectTaskRequest extends $tea.Model {
  appType?: string;
  byManager?: string;
  language?: string;
  nowActionExecutorId?: string;
  processInstanceId?: string;
  remark?: string;
  systemToken?: string;
  taskId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      byManager: 'byManager',
      language: 'language',
      nowActionExecutorId: 'nowActionExecutorId',
      processInstanceId: 'processInstanceId',
      remark: 'remark',
      systemToken: 'systemToken',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      byManager: 'string',
      language: 'string',
      nowActionExecutorId: 'string',
      processInstanceId: 'string',
      remark: 'string',
      systemToken: 'string',
      taskId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectTaskResponse extends $tea.Model {
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
  accessKey?: string;
  callerUid?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      instanceId: 'string',
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
  statusCode: number;
  body: RefundCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RefundCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsRequest extends $tea.Model {
  accessKey?: string;
  activeCode?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      activeCode: 'activeCode',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      activeCode: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsResponseBody extends $tea.Model {
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

export class RegisterAccountsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RegisterAccountsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RegisterAccountsResponseBody,
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
  accessKey?: string;
  callerUid?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      instanceId: 'string',
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
  statusCode: number;
  body: ReleaseCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ReleaseCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTenantResourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTenantResourceRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTenantResourceResponseBody extends $tea.Model {
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

export class RemoveTenantResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemoveTenantResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RemoveTenantResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenderBatchCallbackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenderBatchCallbackRequest extends $tea.Model {
  appType?: string;
  corpId?: string;
  fileSize?: number;
  language?: string;
  namespace?: string;
  ossUrl?: string;
  sequenceId?: string;
  source?: string;
  status?: string;
  systemToken?: string;
  timeZone?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      corpId: 'corpId',
      fileSize: 'fileSize',
      language: 'language',
      namespace: 'namespace',
      ossUrl: 'ossUrl',
      sequenceId: 'sequenceId',
      source: 'source',
      status: 'status',
      systemToken: 'systemToken',
      timeZone: 'timeZone',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      corpId: 'string',
      fileSize: 'number',
      language: 'string',
      namespace: 'string',
      ossUrl: 'string',
      sequenceId: 'string',
      source: 'string',
      status: 'string',
      systemToken: 'string',
      timeZone: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenderBatchCallbackResponse extends $tea.Model {
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

export class RenewApplicationAuthorizationServiceOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewApplicationAuthorizationServiceOrderRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  endTimeGMT?: number;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      endTimeGMT: 'endTimeGMT',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      endTimeGMT: 'number',
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewApplicationAuthorizationServiceOrderResponseBody extends $tea.Model {
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

export class RenewApplicationAuthorizationServiceOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RenewApplicationAuthorizationServiceOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RenewApplicationAuthorizationServiceOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewTenantOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewTenantOrderRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  endTimeGMT?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      endTimeGMT: 'endTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      endTimeGMT: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewTenantOrderResponseBody extends $tea.Model {
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

export class RenewTenantOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RenewTenantOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RenewTenantOrderResponseBody,
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
  formDataJson?: string;
  formUuid?: string;
  language?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formDataJson: 'formDataJson',
      formUuid: 'formUuid',
      language: 'language',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formDataJson: 'string',
      formUuid: 'string',
      language: 'string',
      systemToken: 'string',
      userId: 'string',
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
  statusCode: number;
  body: SaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveFormDataResponseBody,
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
  atUserId?: string;
  content?: string;
  formInstanceId?: string;
  language?: string;
  replyId?: number;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      atUserId: 'atUserId',
      content: 'content',
      formInstanceId: 'formInstanceId',
      language: 'language',
      replyId: 'replyId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      atUserId: 'string',
      content: 'string',
      formInstanceId: 'string',
      language: 'string',
      replyId: 'number',
      systemToken: 'string',
      userId: 'string',
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
  statusCode: number;
  body: SaveFormRemarkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveFormRemarkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoRequest extends $tea.Model {
  appType?: string;
  description?: string;
  fileNameConfig?: string;
  formUuid?: string;
  formVersion?: number;
  setting?: string;
  templateId?: number;
  title?: string;
  userId?: string;
  vm?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      description: 'description',
      fileNameConfig: 'fileNameConfig',
      formUuid: 'formUuid',
      formVersion: 'formVersion',
      setting: 'setting',
      templateId: 'templateId',
      title: 'title',
      userId: 'userId',
      vm: 'vm',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      description: 'string',
      fileNameConfig: 'string',
      formUuid: 'string',
      formVersion: 'number',
      setting: 'string',
      templateId: 'number',
      title: 'string',
      userId: 'string',
      vm: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoResponseBody extends $tea.Model {
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

export class SavePrintTplDetailInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SavePrintTplDetailInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SavePrintTplDetailInfoResponseBody,
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
  activationCode?: string;
  authType?: string;
  expireTimeGMT?: string;
  instanceId?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      activationCode: 'activationCode',
      authType: 'authType',
      expireTimeGMT: 'expireTimeGMT',
      instanceId: 'instanceId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activationCode: 'string',
      authType: 'string',
      expireTimeGMT: 'string',
      instanceId: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchActivationCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  appType?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  formUuid?: string;
  language?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  originatorId?: string;
  searchFieldJson?: string;
  systemToken?: string;
  targetFieldJson?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      formUuid: 'formUuid',
      language: 'language',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      originatorId: 'originatorId',
      searchFieldJson: 'searchFieldJson',
      systemToken: 'systemToken',
      targetFieldJson: 'targetFieldJson',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      formUuid: 'string',
      language: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      originatorId: 'string',
      searchFieldJson: 'string',
      systemToken: 'string',
      targetFieldJson: 'string',
      userId: 'string',
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
  statusCode: number;
  body: SearchEmployeeFieldValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchEmployeeFieldValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListRequest extends $tea.Model {
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  language?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  originatorId?: string;
  searchFieldJson?: string;
  systemToken?: string;
  userId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      language: 'language',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      originatorId: 'originatorId',
      searchFieldJson: 'searchFieldJson',
      systemToken: 'systemToken',
      userId: 'userId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      language: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      originatorId: 'string',
      searchFieldJson: 'string',
      systemToken: 'string',
      userId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListResponseBody extends $tea.Model {
  data?: string[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': 'string' },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchFormDataIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchFormDataIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataRequest extends $tea.Model {
  appType?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  formUuid?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  orderConfigJson?: string;
  originatorId?: string;
  pageNumber?: number;
  pageSize?: number;
  searchFieldJson?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      formUuid: 'formUuid',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      orderConfigJson: 'orderConfigJson',
      originatorId: 'originatorId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchFieldJson: 'searchFieldJson',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      formUuid: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      orderConfigJson: 'string',
      originatorId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      searchFieldJson: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponseBody extends $tea.Model {
  data?: SearchFormDataRemovalTableDataResponseBodyData[];
  hasMoreData?: boolean;
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMoreData: 'hasMoreData',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': SearchFormDataRemovalTableDataResponseBodyData },
      hasMoreData: 'boolean',
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchFormDataRemovalTableDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchFormDataRemovalTableDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationRequest extends $tea.Model {
  appType?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  formUuid?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  orderConfigJson?: string;
  originatorId?: string;
  pageNumber?: number;
  pageSize?: number;
  searchCondition?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      formUuid: 'formUuid',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      orderConfigJson: 'orderConfigJson',
      originatorId: 'originatorId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchCondition: 'searchCondition',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      formUuid: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      orderConfigJson: 'string',
      originatorId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      searchCondition: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBody extends $tea.Model {
  data?: SearchFormDataSecondGenerationResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': SearchFormDataSecondGenerationResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchFormDataSecondGenerationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchFormDataSecondGenerationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldRequest extends $tea.Model {
  appType?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  formUuid?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  orderConfigJson?: string;
  originatorId?: string;
  pageNumber?: number;
  pageSize?: number;
  searchCondition?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      formUuid: 'formUuid',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      orderConfigJson: 'orderConfigJson',
      originatorId: 'originatorId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchCondition: 'searchCondition',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      formUuid: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      orderConfigJson: 'string',
      originatorId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      searchCondition: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBody extends $tea.Model {
  data?: SearchFormDataSecondGenerationNoTableFieldResponseBodyData[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': SearchFormDataSecondGenerationNoTableFieldResponseBodyData },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchFormDataSecondGenerationNoTableFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchFormDataSecondGenerationNoTableFieldResponseBody,
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
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  currentPage?: number;
  dynamicOrder?: string;
  formUuid?: string;
  language?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  originatorId?: string;
  pageSize?: number;
  searchFieldJson?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      currentPage: 'currentPage',
      dynamicOrder: 'dynamicOrder',
      formUuid: 'formUuid',
      language: 'language',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      originatorId: 'originatorId',
      pageSize: 'pageSize',
      searchFieldJson: 'searchFieldJson',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      currentPage: 'number',
      dynamicOrder: 'string',
      formUuid: 'string',
      language: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      originatorId: 'string',
      pageSize: 'number',
      searchFieldJson: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBody extends $tea.Model {
  currentPage?: number;
  data?: SearchFormDatasResponseBodyData[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      data: 'data',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      data: { 'type': 'array', 'itemType': SearchFormDatasResponseBodyData },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchFormDatasResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchFormDatasResponseBody,
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
  departmentId?: string;
  formDataJson?: string;
  formUuid?: string;
  language?: string;
  processCode?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      departmentId: 'departmentId',
      formDataJson: 'formDataJson',
      formUuid: 'formUuid',
      language: 'language',
      processCode: 'processCode',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      departmentId: 'string',
      formDataJson: 'string',
      formUuid: 'string',
      language: 'string',
      processCode: 'string',
      systemToken: 'string',
      userId: 'string',
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
  statusCode: number;
  body: StartInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: StartInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateCloudAuthorizationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateCloudAuthorizationRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateCloudAuthorizationResponseBody extends $tea.Model {
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

export class TerminateCloudAuthorizationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TerminateCloudAuthorizationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: TerminateCloudAuthorizationResponseBody,
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
  language?: string;
  processInstanceId?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processInstanceId: 'processInstanceId',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processInstanceId: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceResponse extends $tea.Model {
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

export class UpdateCloudAccountInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCloudAccountInformationRequest extends $tea.Model {
  accessKey?: string;
  accountNumber?: string;
  callerUnionId?: string;
  commodityType?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      accountNumber: 'accountNumber',
      callerUnionId: 'callerUnionId',
      commodityType: 'commodityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      accountNumber: 'string',
      callerUnionId: 'string',
      commodityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCloudAccountInformationResponseBody extends $tea.Model {
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

export class UpdateCloudAccountInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateCloudAccountInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateCloudAccountInformationResponseBody,
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
  formInstanceId?: string;
  language?: string;
  systemToken?: string;
  updateFormDataJson?: string;
  useLatestVersion?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      formInstanceId: 'formInstanceId',
      language: 'language',
      systemToken: 'systemToken',
      updateFormDataJson: 'updateFormDataJson',
      useLatestVersion: 'useLatestVersion',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      formInstanceId: 'string',
      language: 'string',
      systemToken: 'string',
      updateFormDataJson: 'string',
      useLatestVersion: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataResponse extends $tea.Model {
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
  appType?: string;
  language?: string;
  processInstanceId?: string;
  systemToken?: string;
  updateFormDataJson?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      language: 'language',
      processInstanceId: 'processInstanceId',
      systemToken: 'systemToken',
      updateFormDataJson: 'updateFormDataJson',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      language: 'string',
      processInstanceId: 'string',
      systemToken: 'string',
      updateFormDataJson: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceResponse extends $tea.Model {
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
  appType?: string;
  errorLines?: number[];
  importSequence?: string;
  language?: string;
  status?: string;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      errorLines: 'errorLines',
      importSequence: 'importSequence',
      language: 'language',
      status: 'status',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      errorLines: { 'type': 'array', 'itemType': 'number' },
      importSequence: 'string',
      language: 'string',
      status: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStatusResponse extends $tea.Model {
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

export class UpgradeTenantInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTenantInformationRequest extends $tea.Model {
  accessKey?: string;
  accountNumber?: string;
  callerUnionId?: string;
  commodityType?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      accountNumber: 'accountNumber',
      callerUnionId: 'callerUnionId',
      commodityType: 'commodityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      accountNumber: 'string',
      callerUnionId: 'string',
      commodityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTenantInformationResponseBody extends $tea.Model {
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

export class UpgradeTenantInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpgradeTenantInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpgradeTenantInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderResponseBody extends $tea.Model {
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

export class ValidateApplicationAuthorizationOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ValidateApplicationAuthorizationOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateApplicationAuthorizationOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderResponseBody extends $tea.Model {
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

export class ValidateApplicationAuthorizationServiceOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ValidateApplicationAuthorizationServiceOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateApplicationAuthorizationServiceOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeResponseBody extends $tea.Model {
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

export class ValidateApplicationServiceOrderUpgradeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ValidateApplicationServiceOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateApplicationServiceOrderUpgradeResponseBody,
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
  statusCode: number;
  body: ValidateOrderBuyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateOrderBuyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpdateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpdateRequest extends $tea.Model {
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

export class ValidateOrderUpdateResponseBody extends $tea.Model {
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

export class ValidateOrderUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ValidateOrderUpdateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateOrderUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  accessKey?: string;
  callerUid?: string;
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
      instanceId: 'string',
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
  statusCode: number;
  body: ValidateOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateOrderUpgradeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResultModifyUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResultModifyUser extends $tea.Model {
  name?: BatchGetFormDataByIdListResponseBodyResultModifyUserName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: BatchGetFormDataByIdListResponseBodyResultModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResultOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResultOriginator extends $tea.Model {
  name?: BatchGetFormDataByIdListResponseBodyResultOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: BatchGetFormDataByIdListResponseBodyResultOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResult extends $tea.Model {
  createTimeGMT?: string;
  creatorUserId?: string;
  formData?: { [key: string]: any };
  formInstanceId?: string;
  formUuid?: string;
  id?: number;
  instanceValue?: string;
  modifiedTimeGMT?: string;
  modifier?: string;
  modifyUser?: BatchGetFormDataByIdListResponseBodyResultModifyUser;
  originator?: BatchGetFormDataByIdListResponseBodyResultOriginator;
  sequence?: string;
  serialNumber?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      creatorUserId: 'creatorUserId',
      formData: 'formData',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      id: 'id',
      instanceValue: 'instanceValue',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifier: 'modifier',
      modifyUser: 'modifyUser',
      originator: 'originator',
      sequence: 'sequence',
      serialNumber: 'serialNumber',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      creatorUserId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstanceId: 'string',
      formUuid: 'string',
      id: 'number',
      instanceValue: 'string',
      modifiedTimeGMT: 'string',
      modifier: 'string',
      modifyUser: BatchGetFormDataByIdListResponseBodyResultModifyUser,
      originator: BatchGetFormDataByIdListResponseBodyResultOriginator,
      sequence: 'string',
      serialNumber: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListResponseBodyResult extends $tea.Model {
  aliasInChinese?: string;
  aliasInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      aliasInChinese: 'aliasInChinese',
      aliasInEnglish: 'aliasInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aliasInChinese: 'string',
      aliasInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponseBodyResult extends $tea.Model {
  activityId?: string;
  activityName?: string;
  activityNameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      activityName: 'string',
      activityNameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesResponseBodyResultCubeDataRanges extends $tea.Model {
  classifiedCode?: string;
  conditionKey?: string;
  conditionValue?: any[];
  elementCode?: string;
  elementType?: string;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      classifiedCode: 'classifiedCode',
      conditionKey: 'conditionKey',
      conditionValue: 'conditionValue',
      elementCode: 'elementCode',
      elementType: 'elementType',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classifiedCode: 'string',
      conditionKey: 'string',
      conditionValue: { 'type': 'array', 'itemType': 'any' },
      elementCode: 'string',
      elementType: 'string',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesResponseBodyResultUserInformation extends $tea.Model {
  authProvider?: string;
  corpId?: string;
  departmentName?: string;
  name?: string;
  nickName?: string;
  realmId?: number;
  refererNamespaceCode?: string;
  showName?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      authProvider: 'authProvider',
      corpId: 'corpId',
      departmentName: 'departmentName',
      name: 'name',
      nickName: 'nickName',
      realmId: 'realmId',
      refererNamespaceCode: 'refererNamespaceCode',
      showName: 'showName',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authProvider: 'string',
      corpId: 'string',
      departmentName: 'string',
      name: 'string',
      nickName: 'string',
      realmId: 'number',
      refererNamespaceCode: 'string',
      showName: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllAuthCubesResponseBodyResult extends $tea.Model {
  apappliedCount?: number;
  appCode?: string;
  appInstanceCode?: string;
  appStoreCode?: string;
  authMode?: string;
  authorizationType?: number;
  businessProcessCode?: string;
  categoriesFirst?: string;
  categoriesSecond?: string;
  createTimeGMT?: string;
  creatorUserId?: string;
  cubeAuthType?: string;
  cubeCode?: string;
  cubeDataRange?: string;
  cubeDataRanges?: GetAllAuthCubesResponseBodyResultCubeDataRanges[];
  cubeSource?: string;
  dataCacheTimeConfiguration?: string;
  dataflowCode?: string;
  description?: string;
  domainCode?: string;
  enableCache?: boolean;
  id?: number;
  isNeedApplication?: string;
  isTrend?: string;
  modifiedTimeGMT?: string;
  modifier?: string;
  name?: string;
  namespaceCode?: string;
  owner?: string;
  sharedDataSet?: boolean;
  tenantCorpId?: string;
  type?: string;
  userInformation?: GetAllAuthCubesResponseBodyResultUserInformation;
  static names(): { [key: string]: string } {
    return {
      apappliedCount: 'apappliedCount',
      appCode: 'appCode',
      appInstanceCode: 'appInstanceCode',
      appStoreCode: 'appStoreCode',
      authMode: 'authMode',
      authorizationType: 'authorizationType',
      businessProcessCode: 'businessProcessCode',
      categoriesFirst: 'categoriesFirst',
      categoriesSecond: 'categoriesSecond',
      createTimeGMT: 'createTimeGMT',
      creatorUserId: 'creatorUserId',
      cubeAuthType: 'cubeAuthType',
      cubeCode: 'cubeCode',
      cubeDataRange: 'cubeDataRange',
      cubeDataRanges: 'cubeDataRanges',
      cubeSource: 'cubeSource',
      dataCacheTimeConfiguration: 'dataCacheTimeConfiguration',
      dataflowCode: 'dataflowCode',
      description: 'description',
      domainCode: 'domainCode',
      enableCache: 'enableCache',
      id: 'id',
      isNeedApplication: 'isNeedApplication',
      isTrend: 'isTrend',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifier: 'modifier',
      name: 'name',
      namespaceCode: 'namespaceCode',
      owner: 'owner',
      sharedDataSet: 'sharedDataSet',
      tenantCorpId: 'tenantCorpId',
      type: 'type',
      userInformation: 'userInformation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apappliedCount: 'number',
      appCode: 'string',
      appInstanceCode: 'string',
      appStoreCode: 'string',
      authMode: 'string',
      authorizationType: 'number',
      businessProcessCode: 'string',
      categoriesFirst: 'string',
      categoriesSecond: 'string',
      createTimeGMT: 'string',
      creatorUserId: 'string',
      cubeAuthType: 'string',
      cubeCode: 'string',
      cubeDataRange: 'string',
      cubeDataRanges: { 'type': 'array', 'itemType': GetAllAuthCubesResponseBodyResultCubeDataRanges },
      cubeSource: 'string',
      dataCacheTimeConfiguration: 'string',
      dataflowCode: 'string',
      description: 'string',
      domainCode: 'string',
      enableCache: 'boolean',
      id: 'number',
      isNeedApplication: 'string',
      isTrend: 'string',
      modifiedTimeGMT: 'string',
      modifier: 'string',
      name: 'string',
      namespaceCode: 'string',
      owner: 'string',
      sharedDataSet: 'boolean',
      tenantCorpId: 'string',
      type: 'string',
      userInformation: GetAllAuthCubesResponseBodyResultUserInformation,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksResponseBodyData extends $tea.Model {
  activeTimeGMT?: string;
  actualActionerId?: string;
  appType?: string;
  createTimeGMT?: string;
  finishTimeGMT?: string;
  originatorEmail?: string;
  originatorId?: string;
  originatorName?: string;
  originatorNameInEnglish?: string;
  originatorNickName?: string;
  originatorNickNameInEnglish?: string;
  originatorPhoto?: string;
  outResult?: string;
  outResultName?: string;
  processInstanceId?: string;
  status?: string;
  taskId?: string;
  taskType?: string;
  title?: string;
  titleInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      activeTimeGMT: 'activeTimeGMT',
      actualActionerId: 'actualActionerId',
      appType: 'appType',
      createTimeGMT: 'createTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      originatorEmail: 'originatorEmail',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorNameInEnglish: 'originatorNameInEnglish',
      originatorNickName: 'originatorNickName',
      originatorNickNameInEnglish: 'originatorNickNameInEnglish',
      originatorPhoto: 'originatorPhoto',
      outResult: 'outResult',
      outResultName: 'outResultName',
      processInstanceId: 'processInstanceId',
      status: 'status',
      taskId: 'taskId',
      taskType: 'taskType',
      title: 'title',
      titleInEnglish: 'titleInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeTimeGMT: 'string',
      actualActionerId: 'string',
      appType: 'string',
      createTimeGMT: 'string',
      finishTimeGMT: 'string',
      originatorEmail: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorNameInEnglish: 'string',
      originatorNickName: 'string',
      originatorNickNameInEnglish: 'string',
      originatorPhoto: 'string',
      outResult: 'string',
      outResultName: 'string',
      processInstanceId: 'string',
      status: 'string',
      taskId: 'string',
      taskType: 'string',
      title: 'string',
      titleInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksResponseBodyData extends $tea.Model {
  activeTimeGMT?: string;
  actualActionerId?: string;
  appType?: string;
  createTimeGMT?: string;
  finishTimeGMT?: string;
  originatorEmail?: string;
  originatorId?: string;
  originatorName?: string;
  originatorNameInEnglish?: string;
  originatorNickName?: string;
  originatorNickNameEn?: string;
  originatorPhoto?: string;
  outResult?: string;
  outResultName?: string;
  processInstanceId?: string;
  status?: string;
  taskId?: string;
  taskType?: string;
  title?: string;
  titleInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      activeTimeGMT: 'activeTimeGMT',
      actualActionerId: 'actualActionerId',
      appType: 'appType',
      createTimeGMT: 'createTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      originatorEmail: 'originatorEmail',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorNameInEnglish: 'originatorNameInEnglish',
      originatorNickName: 'originatorNickName',
      originatorNickNameEn: 'originatorNickNameEn',
      originatorPhoto: 'originatorPhoto',
      outResult: 'outResult',
      outResultName: 'outResultName',
      processInstanceId: 'processInstanceId',
      status: 'status',
      taskId: 'taskId',
      taskType: 'taskType',
      title: 'title',
      titleInEnglish: 'titleInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeTimeGMT: 'string',
      actualActionerId: 'string',
      appType: 'string',
      createTimeGMT: 'string',
      finishTimeGMT: 'string',
      originatorEmail: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorNameInEnglish: 'string',
      originatorNickName: 'string',
      originatorNickNameEn: 'string',
      originatorPhoto: 'string',
      outResult: 'string',
      outResultName: 'string',
      processInstanceId: 'string',
      status: 'string',
      taskId: 'string',
      taskType: 'string',
      title: 'string',
      titleInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFieldDefByUuidResponseBodyResult extends $tea.Model {
  behavior?: string;
  children?: string;
  componentName?: string;
  fieldId?: string;
  label?: any;
  props?: any;
  static names(): { [key: string]: string } {
    return {
      behavior: 'behavior',
      children: 'children',
      componentName: 'componentName',
      fieldId: 'fieldId',
      label: 'label',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      behavior: 'string',
      children: 'string',
      componentName: 'string',
      fieldId: 'string',
      label: 'any',
      props: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListResponseBodyResult extends $tea.Model {
  componentName?: string;
  fieldId?: string;
  label?: string;
  parentId?: string;
  static names(): { [key: string]: string } {
    return {
      componentName: 'componentName',
      fieldId: 'fieldId',
      label: 'label',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentName: 'string',
      fieldId: 'string',
      label: 'string',
      parentId: 'string',
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
  departmentName?: string;
  email?: string;
  name?: GetFormDataByIDResponseBodyOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentName: 'departmentName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentName: 'string',
      email: 'string',
      name: GetFormDataByIDResponseBodyOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppResponseBodyResultDataTitle extends $tea.Model {
  enUS?: string;
  zhCN?: string;
  static names(): { [key: string]: string } {
    return {
      enUS: 'enUS',
      zhCN: 'zhCN',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enUS: 'string',
      zhCN: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppResponseBodyResultData extends $tea.Model {
  creator?: string;
  formType?: string;
  formUuid?: string;
  gmtCreate?: string;
  title?: GetFormListInAppResponseBodyResultDataTitle;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      formType: 'formType',
      formUuid: 'formUuid',
      gmtCreate: 'gmtCreate',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      formType: 'string',
      formUuid: 'string',
      gmtCreate: 'string',
      title: GetFormListInAppResponseBodyResultDataTitle,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormListInAppResponseBodyResult extends $tea.Model {
  currentPage?: number;
  data?: GetFormListInAppResponseBodyResultData[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      data: 'data',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      data: { 'type': 'array', 'itemType': GetFormListInAppResponseBodyResultData },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBodyActionExecutorName extends $tea.Model {
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

export class GetInstanceByIdResponseBodyActionExecutor extends $tea.Model {
  deptName?: string;
  email?: string;
  name?: GetInstanceByIdResponseBodyActionExecutorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      email: 'string',
      name: GetInstanceByIdResponseBodyActionExecutorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBodyOriginatorName extends $tea.Model {
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

export class GetInstanceByIdResponseBodyOriginator extends $tea.Model {
  deptName?: string;
  email?: string;
  name?: GetInstanceByIdResponseBodyOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      email: 'string',
      name: GetInstanceByIdResponseBodyOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyDataActionExecutorName extends $tea.Model {
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

export class GetInstancesResponseBodyDataActionExecutor extends $tea.Model {
  deptName?: string;
  email?: string;
  name?: GetInstancesResponseBodyDataActionExecutorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      email: 'string',
      name: GetInstancesResponseBodyDataActionExecutorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyDataOriginatorName extends $tea.Model {
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

export class GetInstancesResponseBodyDataOriginator extends $tea.Model {
  deptName?: string;
  email?: string;
  name?: GetInstancesResponseBodyDataOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      email: 'string',
      name: GetInstancesResponseBodyDataOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyData extends $tea.Model {
  actionExecutor?: GetInstancesResponseBodyDataActionExecutor[];
  approvedResult?: string;
  createTimeGMT?: string;
  data?: { [key: string]: any };
  formUuid?: string;
  instanceStatus?: string;
  modifiedTimeGMT?: string;
  originator?: GetInstancesResponseBodyDataOriginator;
  processCode?: string;
  processInstanceId?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionExecutor: 'actionExecutor',
      approvedResult: 'approvedResult',
      createTimeGMT: 'createTimeGMT',
      data: 'data',
      formUuid: 'formUuid',
      instanceStatus: 'instanceStatus',
      modifiedTimeGMT: 'modifiedTimeGMT',
      originator: 'originator',
      processCode: 'processCode',
      processInstanceId: 'processInstanceId',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionExecutor: { 'type': 'array', 'itemType': GetInstancesResponseBodyDataActionExecutor },
      approvedResult: 'string',
      createTimeGMT: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formUuid: 'string',
      instanceStatus: 'string',
      modifiedTimeGMT: 'string',
      originator: GetInstancesResponseBodyDataOriginator,
      processCode: 'string',
      processInstanceId: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResultActionExecutorName extends $tea.Model {
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

export class GetInstancesByIdListResponseBodyResultActionExecutor extends $tea.Model {
  departmentName?: string;
  email?: string;
  name?: GetInstancesByIdListResponseBodyResultActionExecutorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentName: 'departmentName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentName: 'string',
      email: 'string',
      name: GetInstancesByIdListResponseBodyResultActionExecutorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResultOriginatorName extends $tea.Model {
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

export class GetInstancesByIdListResponseBodyResultOriginator extends $tea.Model {
  departmentName?: string;
  email?: string;
  name?: GetInstancesByIdListResponseBodyResultOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentName: 'departmentName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentName: 'string',
      email: 'string',
      name: GetInstancesByIdListResponseBodyResultOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResult extends $tea.Model {
  actionExecutor?: GetInstancesByIdListResponseBodyResultActionExecutor[];
  approvedResult?: string;
  data?: { [key: string]: any };
  formUuid?: string;
  instanceStatus?: string;
  originator?: GetInstancesByIdListResponseBodyResultOriginator;
  processCode?: string;
  processInstanceId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionExecutor: 'actionExecutor',
      approvedResult: 'approvedResult',
      data: 'data',
      formUuid: 'formUuid',
      instanceStatus: 'instanceStatus',
      originator: 'originator',
      processCode: 'processCode',
      processInstanceId: 'processInstanceId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionExecutor: { 'type': 'array', 'itemType': GetInstancesByIdListResponseBodyResultActionExecutor },
      approvedResult: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formUuid: 'string',
      instanceStatus: 'string',
      originator: GetInstancesByIdListResponseBodyResultOriginator,
      processCode: 'string',
      processInstanceId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBodyDataActioner extends $tea.Model {
  buName?: string;
  email?: string;
  employeeType?: string;
  employeeTypeInformation?: string;
  humanResourceGroupWorkNumber?: string;
  isSystemAdmin?: boolean;
  level?: string;
  name?: string;
  nickName?: string;
  orderNumber?: string;
  personalPhoto?: string;
  personalPhotoUrl?: string;
  pinyinNameAll?: string;
  pinyinNickName?: string;
  state?: string;
  superUserId?: string;
  tbWang?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      buName: 'buName',
      email: 'email',
      employeeType: 'employeeType',
      employeeTypeInformation: 'employeeTypeInformation',
      humanResourceGroupWorkNumber: 'humanResourceGroupWorkNumber',
      isSystemAdmin: 'isSystemAdmin',
      level: 'level',
      name: 'name',
      nickName: 'nickName',
      orderNumber: 'orderNumber',
      personalPhoto: 'personalPhoto',
      personalPhotoUrl: 'personalPhotoUrl',
      pinyinNameAll: 'pinyinNameAll',
      pinyinNickName: 'pinyinNickName',
      state: 'state',
      superUserId: 'superUserId',
      tbWang: 'tbWang',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buName: 'string',
      email: 'string',
      employeeType: 'string',
      employeeTypeInformation: 'string',
      humanResourceGroupWorkNumber: 'string',
      isSystemAdmin: 'boolean',
      level: 'string',
      name: 'string',
      nickName: 'string',
      orderNumber: 'string',
      personalPhoto: 'string',
      personalPhotoUrl: 'string',
      pinyinNameAll: 'string',
      pinyinNickName: 'string',
      state: 'string',
      superUserId: 'string',
      tbWang: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances extends $tea.Model {
  activityId?: string;
  activityInstanceStatus?: string;
  activityName?: string;
  activityNameEn?: string;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      activityInstanceStatus: 'activityInstanceStatus',
      activityName: 'activityName',
      activityNameEn: 'activityNameEn',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      activityInstanceStatus: 'string',
      activityName: 'string',
      activityNameEn: 'string',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBodyData extends $tea.Model {
  actioner?: GetMeCorpSubmissionResponseBodyDataActioner[];
  actionerId?: string[];
  actionerName?: string[];
  appType?: string;
  createTimeGMT?: string;
  currentActivityInstances?: GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances[];
  dataMap?: { [key: string]: any };
  dataType?: string;
  finishTimeGMT?: string;
  formInstanceId?: string;
  formUuid?: string;
  instanceValue?: string;
  modifiedTimeGMT?: string;
  originatorAvatar?: string;
  originatorDisplayName?: string;
  originatorId?: string;
  processApprovedResult?: string;
  processApprovedResultText?: string;
  processCode?: string;
  processId?: number;
  processInstanceId?: string;
  processInstanceStatus?: string;
  processInstanceStatusText?: string;
  processName?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actioner: 'actioner',
      actionerId: 'actionerId',
      actionerName: 'actionerName',
      appType: 'appType',
      createTimeGMT: 'createTimeGMT',
      currentActivityInstances: 'currentActivityInstances',
      dataMap: 'dataMap',
      dataType: 'dataType',
      finishTimeGMT: 'finishTimeGMT',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      instanceValue: 'instanceValue',
      modifiedTimeGMT: 'modifiedTimeGMT',
      originatorAvatar: 'originatorAvatar',
      originatorDisplayName: 'originatorDisplayName',
      originatorId: 'originatorId',
      processApprovedResult: 'processApprovedResult',
      processApprovedResultText: 'processApprovedResultText',
      processCode: 'processCode',
      processId: 'processId',
      processInstanceId: 'processInstanceId',
      processInstanceStatus: 'processInstanceStatus',
      processInstanceStatusText: 'processInstanceStatusText',
      processName: 'processName',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actioner: { 'type': 'array', 'itemType': GetMeCorpSubmissionResponseBodyDataActioner },
      actionerId: { 'type': 'array', 'itemType': 'string' },
      actionerName: { 'type': 'array', 'itemType': 'string' },
      appType: 'string',
      createTimeGMT: 'string',
      currentActivityInstances: { 'type': 'array', 'itemType': GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances },
      dataMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dataType: 'string',
      finishTimeGMT: 'string',
      formInstanceId: 'string',
      formUuid: 'string',
      instanceValue: 'string',
      modifiedTimeGMT: 'string',
      originatorAvatar: 'string',
      originatorDisplayName: 'string',
      originatorId: 'string',
      processApprovedResult: 'string',
      processApprovedResultText: 'string',
      processCode: 'string',
      processId: 'number',
      processInstanceId: 'string',
      processInstanceStatus: 'string',
      processInstanceStatusText: 'string',
      processName: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeResponseBodyData extends $tea.Model {
  activityId?: string;
  appType?: string;
  corpId?: string;
  createTimeGMT?: string;
  creatorUserId?: string;
  formInstanceId?: string;
  instStatus?: string;
  mobileUrl?: string;
  modifiedTimeGMT?: string;
  processCode?: string;
  title?: string;
  titleInEnglish?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      appType: 'appType',
      corpId: 'corpId',
      createTimeGMT: 'createTimeGMT',
      creatorUserId: 'creatorUserId',
      formInstanceId: 'formInstanceId',
      instStatus: 'instStatus',
      mobileUrl: 'mobileUrl',
      modifiedTimeGMT: 'modifiedTimeGMT',
      processCode: 'processCode',
      title: 'title',
      titleInEnglish: 'titleInEnglish',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      appType: 'string',
      corpId: 'string',
      createTimeGMT: 'string',
      creatorUserId: 'string',
      formInstanceId: 'string',
      instStatus: 'string',
      mobileUrl: 'string',
      modifiedTimeGMT: 'string',
      processCode: 'string',
      title: 'string',
      titleInEnglish: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponseBodyResult extends $tea.Model {
  action?: string;
  actionExit?: string;
  activeTimeGMT?: string;
  activityId?: string;
  dataId?: number;
  digitalSign?: string;
  files?: string;
  operateTimeGMT?: string;
  operateType?: string;
  operatorDisplayName?: string;
  operatorName?: string;
  operatorNickName?: string;
  operatorPhotoUrl?: string;
  operatorStatus?: string;
  operatorUserId?: string;
  processInstanceId?: string;
  remark?: string;
  showName?: string;
  size?: number;
  taskExecuteType?: string;
  taskHoldTimeGMT?: number;
  taskId?: string;
  taskType?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      actionExit: 'actionExit',
      activeTimeGMT: 'activeTimeGMT',
      activityId: 'activityId',
      dataId: 'dataId',
      digitalSign: 'digitalSign',
      files: 'files',
      operateTimeGMT: 'operateTimeGMT',
      operateType: 'operateType',
      operatorDisplayName: 'operatorDisplayName',
      operatorName: 'operatorName',
      operatorNickName: 'operatorNickName',
      operatorPhotoUrl: 'operatorPhotoUrl',
      operatorStatus: 'operatorStatus',
      operatorUserId: 'operatorUserId',
      processInstanceId: 'processInstanceId',
      remark: 'remark',
      showName: 'showName',
      size: 'size',
      taskExecuteType: 'taskExecuteType',
      taskHoldTimeGMT: 'taskHoldTimeGMT',
      taskId: 'taskId',
      taskType: 'taskType',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      actionExit: 'string',
      activeTimeGMT: 'string',
      activityId: 'string',
      dataId: 'number',
      digitalSign: 'string',
      files: 'string',
      operateTimeGMT: 'string',
      operateType: 'string',
      operatorDisplayName: 'string',
      operatorName: 'string',
      operatorNickName: 'string',
      operatorPhotoUrl: 'string',
      operatorStatus: 'string',
      operatorUserId: 'string',
      processInstanceId: 'string',
      remark: 'string',
      showName: 'string',
      size: 'number',
      taskExecuteType: 'string',
      taskHoldTimeGMT: 'number',
      taskId: 'string',
      taskType: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponseBodyResultFormInfoList extends $tea.Model {
  formName?: string;
  formUuid?: string;
  static names(): { [key: string]: string } {
    return {
      formName: 'formName',
      formUuid: 'formUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formName: 'string',
      formUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponseBodyResult extends $tea.Model {
  appName?: string;
  appType?: string;
  formInfoList?: GetPrintAppInfoResponseBodyResultFormInfoList[];
  iconUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      appType: 'appType',
      formInfoList: 'formInfoList',
      iconUrl: 'iconUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      appType: 'string',
      formInfoList: { 'type': 'array', 'itemType': GetPrintAppInfoResponseBodyResultFormInfoList },
      iconUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments extends $tea.Model {
  deptName?: string;
  deptNameInEnglish?: string;
  deptNo?: string;
  deptPath?: string;
  humanSourceGroupOrderNumber?: string;
  humanSourceGroupWorkNo?: string;
  id?: number;
  masterWorkNo?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      deptNameInEnglish: 'deptNameInEnglish',
      deptNo: 'deptNo',
      deptPath: 'deptPath',
      humanSourceGroupOrderNumber: 'humanSourceGroupOrderNumber',
      humanSourceGroupWorkNo: 'humanSourceGroupWorkNo',
      id: 'id',
      masterWorkNo: 'masterWorkNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      deptNameInEnglish: 'string',
      deptNo: 'string',
      deptPath: 'string',
      humanSourceGroupOrderNumber: 'string',
      humanSourceGroupWorkNo: 'string',
      id: 'number',
      masterWorkNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOriginator extends $tea.Model {
  departmentDescription?: string;
  displayEnName?: string;
  displayName?: string;
  masterDataDepartments?: GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments[];
  orderNumber?: string;
  personalPhoto?: string;
  status?: string;
  tbWang?: string;
  userId?: string;
  userInfo?: string;
  static names(): { [key: string]: string } {
    return {
      departmentDescription: 'departmentDescription',
      displayEnName: 'displayEnName',
      displayName: 'displayName',
      masterDataDepartments: 'masterDataDepartments',
      orderNumber: 'orderNumber',
      personalPhoto: 'personalPhoto',
      status: 'status',
      tbWang: 'tbWang',
      userId: 'userId',
      userInfo: 'userInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentDescription: 'string',
      displayEnName: 'string',
      displayName: 'string',
      masterDataDepartments: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments },
      orderNumber: 'string',
      personalPhoto: 'string',
      status: 'string',
      tbWang: 'string',
      userId: 'string',
      userInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments extends $tea.Model {
  deptName?: string;
  deptNameInEnglish?: string;
  deptNo?: string;
  deptPath?: string;
  humanSourceGroupOrderNumber?: string;
  humanSourceGroupWorkNo?: string;
  id?: number;
  masterWorkNo?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      deptNameInEnglish: 'deptNameInEnglish',
      deptNo: 'deptNo',
      deptPath: 'deptPath',
      humanSourceGroupOrderNumber: 'humanSourceGroupOrderNumber',
      humanSourceGroupWorkNo: 'humanSourceGroupWorkNo',
      id: 'id',
      masterWorkNo: 'masterWorkNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      deptNameInEnglish: 'string',
      deptNo: 'string',
      deptPath: 'string',
      humanSourceGroupOrderNumber: 'string',
      humanSourceGroupWorkNo: 'string',
      id: 'number',
      masterWorkNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOwners extends $tea.Model {
  departmentDescription?: string;
  displayEnName?: string;
  displayName?: string;
  masterDataDepartments?: GetProcessDefinitionResponseBodyOwnersMasterDataDepartments[];
  orderNumber?: string;
  personalPhoto?: string;
  status?: string;
  tbWang?: string;
  userId?: string;
  userInfo?: string;
  static names(): { [key: string]: string } {
    return {
      departmentDescription: 'departmentDescription',
      displayEnName: 'displayEnName',
      displayName: 'displayName',
      masterDataDepartments: 'masterDataDepartments',
      orderNumber: 'orderNumber',
      personalPhoto: 'personalPhoto',
      status: 'status',
      tbWang: 'tbWang',
      userId: 'userId',
      userInfo: 'userInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentDescription: 'string',
      displayEnName: 'string',
      displayName: 'string',
      masterDataDepartments: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyOwnersMasterDataDepartments },
      orderNumber: 'string',
      personalPhoto: 'string',
      status: 'string',
      tbWang: 'string',
      userId: 'string',
      userInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyTasksActivity extends $tea.Model {
  activityId?: string;
  activityInstanceStatus?: string;
  activityName?: string;
  activityNameInEnglish?: string;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      activityInstanceStatus: 'activityInstanceStatus',
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      activityInstanceStatus: 'string',
      activityName: 'string',
      activityNameInEnglish: 'string',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyTasks extends $tea.Model {
  actionerId?: string;
  activity?: GetProcessDefinitionResponseBodyTasksActivity;
  status?: string;
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      actionerId: 'actionerId',
      activity: 'activity',
      status: 'status',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerId: 'string',
      activity: GetProcessDefinitionResponseBodyTasksActivity,
      status: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListResponseBodyResult extends $tea.Model {
  activeTimeGMT?: string;
  actualActionExecutorId?: string;
  appType?: string;
  createTimeGMT?: string;
  finishTimeGMT?: string;
  originatorEmail?: string;
  originatorId?: string;
  originatorName?: string;
  originatorNameInEnglish?: string;
  originatorNickName?: string;
  originatorNickNameInEnglish?: string;
  originatorPhoto?: string;
  outResult?: string;
  outResultName?: string;
  processInstanceId?: string;
  status?: string;
  taskId?: string;
  taskType?: string;
  title?: string;
  titleInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      activeTimeGMT: 'activeTimeGMT',
      actualActionExecutorId: 'actualActionExecutorId',
      appType: 'appType',
      createTimeGMT: 'createTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      originatorEmail: 'originatorEmail',
      originatorId: 'originatorId',
      originatorName: 'originatorName',
      originatorNameInEnglish: 'originatorNameInEnglish',
      originatorNickName: 'originatorNickName',
      originatorNickNameInEnglish: 'originatorNickNameInEnglish',
      originatorPhoto: 'originatorPhoto',
      outResult: 'outResult',
      outResultName: 'outResultName',
      processInstanceId: 'processInstanceId',
      status: 'status',
      taskId: 'taskId',
      taskType: 'taskType',
      title: 'title',
      titleInEnglish: 'titleInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeTimeGMT: 'string',
      actualActionExecutorId: 'string',
      appType: 'string',
      createTimeGMT: 'string',
      finishTimeGMT: 'string',
      originatorEmail: 'string',
      originatorId: 'string',
      originatorName: 'string',
      originatorNameInEnglish: 'string',
      originatorNickName: 'string',
      originatorNickNameInEnglish: 'string',
      originatorPhoto: 'string',
      outResult: 'string',
      outResultName: 'string',
      processInstanceId: 'string',
      status: 'string',
      taskId: 'string',
      taskType: 'string',
      title: 'string',
      titleInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponseBodyResult extends $tea.Model {
  activeTimeGMT?: string;
  activityId?: string;
  actualActionerId?: string;
  createTimeGMT?: string;
  finishTimeGMT?: string;
  originatorId?: string;
  processInstanceId?: string;
  status?: string;
  taskId?: string;
  taskType?: string;
  title?: string;
  titleInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      activeTimeGMT: 'activeTimeGMT',
      activityId: 'activityId',
      actualActionerId: 'actualActionerId',
      createTimeGMT: 'createTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      originatorId: 'originatorId',
      processInstanceId: 'processInstanceId',
      status: 'status',
      taskId: 'taskId',
      taskType: 'taskType',
      title: 'title',
      titleInEnglish: 'titleInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeTimeGMT: 'string',
      activityId: 'string',
      actualActionerId: 'string',
      createTimeGMT: 'string',
      finishTimeGMT: 'string',
      originatorId: 'string',
      processInstanceId: 'string',
      status: 'string',
      taskId: 'string',
      taskType: 'string',
      title: 'string',
      titleInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponseBodyCorpList extends $tea.Model {
  corpId?: string;
  corpName?: string;
  namespace?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
      namespace: 'namespace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
      namespace: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleCubeModelListResponseBodyResultChildren extends $tea.Model {
  classifiedCode?: string;
  cubeCode?: string;
  dataType?: string;
  dimensionType?: string;
  fieldCode?: string;
  id?: string;
  isDimension?: string;
  isVisible?: string;
  measureType?: string;
  text?: string;
  timeFormat?: string;
  timeGranularityType?: string;
  static names(): { [key: string]: string } {
    return {
      classifiedCode: 'classifiedCode',
      cubeCode: 'cubeCode',
      dataType: 'dataType',
      dimensionType: 'dimensionType',
      fieldCode: 'fieldCode',
      id: 'id',
      isDimension: 'isDimension',
      isVisible: 'isVisible',
      measureType: 'measureType',
      text: 'text',
      timeFormat: 'timeFormat',
      timeGranularityType: 'timeGranularityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classifiedCode: 'string',
      cubeCode: 'string',
      dataType: 'string',
      dimensionType: 'string',
      fieldCode: 'string',
      id: 'string',
      isDimension: 'string',
      isVisible: 'string',
      measureType: 'string',
      text: 'string',
      timeFormat: 'string',
      timeGranularityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleCubeModelListResponseBodyResult extends $tea.Model {
  children?: GetSimpleCubeModelListResponseBodyResultChildren[];
  id?: string;
  isDimension?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      id: 'id',
      isDimension: 'isDimension',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': GetSimpleCubeModelListResponseBodyResultChildren },
      id: 'string',
      isDimension: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponseBodyDataCurrentActivityInstances extends $tea.Model {
  activityId?: string;
  activityInstanceStatus?: string;
  activityName?: string;
  activityNameInEnglish?: string;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      activityInstanceStatus: 'activityInstanceStatus',
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      activityInstanceStatus: 'string',
      activityName: 'string',
      activityNameInEnglish: 'string',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponseBodyData extends $tea.Model {
  actionExecutorId?: string[];
  actionExecutorName?: string[];
  appType?: string;
  carbonActivityId?: string;
  createTimeGMT?: string;
  currentActivityInstances?: GetTaskCopiesResponseBodyDataCurrentActivityInstances[];
  dataMap?: { [key: string]: any };
  dataType?: string;
  finishTimeGMT?: string;
  formInstanceId?: string;
  formUuid?: string;
  instanceValue?: string;
  modifiedTimeGMT?: string;
  originatorAvatar?: string;
  originatorDisplayName?: string;
  originatorId?: string;
  processApprovedResult?: string;
  processApprovedResultText?: string;
  processCode?: string;
  processId?: number;
  processInstanceId?: string;
  processInstanceStatus?: string;
  processInstanceStatusText?: string;
  processName?: string;
  serialNumber?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      actionExecutorId: 'actionExecutorId',
      actionExecutorName: 'actionExecutorName',
      appType: 'appType',
      carbonActivityId: 'carbonActivityId',
      createTimeGMT: 'createTimeGMT',
      currentActivityInstances: 'currentActivityInstances',
      dataMap: 'dataMap',
      dataType: 'dataType',
      finishTimeGMT: 'finishTimeGMT',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      instanceValue: 'instanceValue',
      modifiedTimeGMT: 'modifiedTimeGMT',
      originatorAvatar: 'originatorAvatar',
      originatorDisplayName: 'originatorDisplayName',
      originatorId: 'originatorId',
      processApprovedResult: 'processApprovedResult',
      processApprovedResultText: 'processApprovedResultText',
      processCode: 'processCode',
      processId: 'processId',
      processInstanceId: 'processInstanceId',
      processInstanceStatus: 'processInstanceStatus',
      processInstanceStatusText: 'processInstanceStatusText',
      processName: 'processName',
      serialNumber: 'serialNumber',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionExecutorId: { 'type': 'array', 'itemType': 'string' },
      actionExecutorName: { 'type': 'array', 'itemType': 'string' },
      appType: 'string',
      carbonActivityId: 'string',
      createTimeGMT: 'string',
      currentActivityInstances: { 'type': 'array', 'itemType': GetTaskCopiesResponseBodyDataCurrentActivityInstances },
      dataMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dataType: 'string',
      finishTimeGMT: 'string',
      formInstanceId: 'string',
      formUuid: 'string',
      instanceValue: 'string',
      modifiedTimeGMT: 'string',
      originatorAvatar: 'string',
      originatorDisplayName: 'string',
      originatorId: 'string',
      processApprovedResult: 'string',
      processApprovedResultText: 'string',
      processCode: 'string',
      processId: 'number',
      processInstanceId: 'string',
      processInstanceStatus: 'string',
      processInstanceStatusText: 'string',
      processName: 'string',
      serialNumber: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationResponseBodyData extends $tea.Model {
  appConfig?: string;
  appType?: string;
  applicationStatus?: string;
  corpId?: string;
  creatorUserId?: string;
  description?: string;
  icon?: string;
  inexistence?: string;
  name?: string;
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      appConfig: 'appConfig',
      appType: 'appType',
      applicationStatus: 'applicationStatus',
      corpId: 'corpId',
      creatorUserId: 'creatorUserId',
      description: 'description',
      icon: 'icon',
      inexistence: 'inexistence',
      name: 'name',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appConfig: 'string',
      appType: 'string',
      applicationStatus: 'string',
      corpId: 'string',
      creatorUserId: 'string',
      description: 'string',
      icon: 'string',
      inexistence: 'string',
      name: 'string',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins extends $tea.Model {
  iconUrl?: string;
  pluginName?: string;
  static names(): { [key: string]: string } {
    return {
      iconUrl: 'iconUrl',
      pluginName: 'pluginName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iconUrl: 'string',
      pluginName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation extends $tea.Model {
  appName?: string;
  appType?: string;
  attachmentUsageAmount?: number;
  instanceUsageAmount?: number;
  usagePlugins?: ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins[];
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      appType: 'appType',
      attachmentUsageAmount: 'attachmentUsageAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      usagePlugins: 'usagePlugins',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      appType: 'string',
      attachmentUsageAmount: 'number',
      instanceUsageAmount: 'number',
      usagePlugins: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications extends $tea.Model {
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation extends $tea.Model {
  applications?: ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications[];
  iconUrl?: string;
  plugName?: string;
  plugPayType?: number;
  plugStatus?: number;
  plugTotalAmount?: number;
  plugUsageAmount?: number;
  plugUuid?: string;
  static names(): { [key: string]: string } {
    return {
      applications: 'applications',
      iconUrl: 'iconUrl',
      plugName: 'plugName',
      plugPayType: 'plugPayType',
      plugStatus: 'plugStatus',
      plugTotalAmount: 'plugTotalAmount',
      plugUsageAmount: 'plugUsageAmount',
      plugUuid: 'plugUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applications: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications },
      iconUrl: 'string',
      plugName: 'string',
      plugPayType: 'number',
      plugStatus: 'number',
      plugTotalAmount: 'number',
      plugUsageAmount: 'number',
      plugUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponseBodyApplicationInformationUsagePlugins extends $tea.Model {
  iconUrl?: string;
  pluginName?: string;
  static names(): { [key: string]: string } {
    return {
      iconUrl: 'iconUrl',
      pluginName: 'pluginName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iconUrl: 'string',
      pluginName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponseBodyApplicationInformation extends $tea.Model {
  appName?: string;
  appType?: string;
  attachmentUsageAmount?: number;
  instanceUsageAmount?: number;
  usagePlugins?: ListApplicationInformationResponseBodyApplicationInformationUsagePlugins[];
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      appType: 'appType',
      attachmentUsageAmount: 'attachmentUsageAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      usagePlugins: 'usagePlugins',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      appType: 'string',
      attachmentUsageAmount: 'number',
      instanceUsageAmount: 'number',
      usagePlugins: { 'type': 'array', 'itemType': ListApplicationInformationResponseBodyApplicationInformationUsagePlugins },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponseBodyCommodityVOList extends $tea.Model {
  accountDistributionNumber?: number;
  accountNumber?: number;
  activationCode?: string;
  buyDateGMT?: string;
  expireDateGMT?: string;
  instanceId?: string;
  status?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      accountDistributionNumber: 'accountDistributionNumber',
      accountNumber: 'accountNumber',
      activationCode: 'activationCode',
      buyDateGMT: 'buyDateGMT',
      expireDateGMT: 'expireDateGMT',
      instanceId: 'instanceId',
      status: 'status',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountDistributionNumber: 'number',
      accountNumber: 'number',
      activationCode: 'string',
      buyDateGMT: 'string',
      expireDateGMT: 'string',
      instanceId: 'string',
      status: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponseBodyPluginInfosApps extends $tea.Model {
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponseBodyPluginInfos extends $tea.Model {
  apps?: ListConnectorInformationResponseBodyPluginInfosApps[];
  iconUrl?: string;
  pluginName?: string;
  pluginPayType?: number;
  pluginStatus?: number;
  pluginTotalAmount?: number;
  pluginUsageAmount?: number;
  pluginUuid?: string;
  static names(): { [key: string]: string } {
    return {
      apps: 'apps',
      iconUrl: 'iconUrl',
      pluginName: 'pluginName',
      pluginPayType: 'pluginPayType',
      pluginStatus: 'pluginStatus',
      pluginTotalAmount: 'pluginTotalAmount',
      pluginUsageAmount: 'pluginUsageAmount',
      pluginUuid: 'pluginUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apps: { 'type': 'array', 'itemType': ListConnectorInformationResponseBodyPluginInfosApps },
      iconUrl: 'string',
      pluginName: 'string',
      pluginPayType: 'number',
      pluginStatus: 'number',
      pluginTotalAmount: 'number',
      pluginUsageAmount: 'number',
      pluginUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBodyResultTitle extends $tea.Model {
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

export class ListNavigationByFormTypeResponseBodyResult extends $tea.Model {
  formUuid?: string;
  processCode?: string;
  title?: ListNavigationByFormTypeResponseBodyResultTitle;
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      processCode: 'processCode',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      processCode: 'string',
      title: ListNavigationByFormTypeResponseBodyResultTitle,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosResponseBodyResultDataTitle extends $tea.Model {
  enUS?: string;
  zhCN?: string;
  static names(): { [key: string]: string } {
    return {
      enUS: 'enUS',
      zhCN: 'zhCN',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enUS: 'string',
      zhCN: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosResponseBodyResultData extends $tea.Model {
  creator?: string;
  formType?: string;
  formUuid?: string;
  gmtCreate?: string;
  title?: PageFormBaseInfosResponseBodyResultDataTitle;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      formType: 'formType',
      formUuid: 'formUuid',
      gmtCreate: 'gmtCreate',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      formType: 'string',
      formUuid: 'string',
      gmtCreate: 'string',
      title: PageFormBaseInfosResponseBodyResultDataTitle,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFormBaseInfosResponseBodyResult extends $tea.Model {
  currentPage?: number;
  data?: PageFormBaseInfosResponseBodyResultData[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      data: 'data',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      data: { 'type': 'array', 'itemType': PageFormBaseInfosResponseBodyResultData },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceRecordResponseBodyValues extends $tea.Model {
  formInstanceId?: string;
  formUuid?: string;
  hookType?: string;
  hookUuid?: string;
  invokeParameter?: string;
  invokeResult?: string;
  invokeStatus?: string;
  invokeSuccess?: string;
  invokeUrl?: string;
  serviceContent?: string;
  serviceName?: string;
  serviceParameter?: string;
  sourceUuid?: string;
  static names(): { [key: string]: string } {
    return {
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      hookType: 'hookType',
      hookUuid: 'hookUuid',
      invokeParameter: 'invokeParameter',
      invokeResult: 'invokeResult',
      invokeStatus: 'invokeStatus',
      invokeSuccess: 'invokeSuccess',
      invokeUrl: 'invokeUrl',
      serviceContent: 'serviceContent',
      serviceName: 'serviceName',
      serviceParameter: 'serviceParameter',
      sourceUuid: 'sourceUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formInstanceId: 'string',
      formUuid: 'string',
      hookType: 'string',
      hookUuid: 'string',
      invokeParameter: 'string',
      invokeResult: 'string',
      invokeStatus: 'string',
      invokeSuccess: 'string',
      invokeUrl: 'string',
      serviceContent: 'string',
      serviceName: 'string',
      serviceParameter: 'string',
      sourceUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponseBodyDataModifyUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponseBodyDataModifyUser extends $tea.Model {
  departmentName?: string;
  email?: string;
  name?: SearchFormDataRemovalTableDataResponseBodyDataModifyUserName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentName: 'departmentName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentName: 'string',
      email: 'string',
      name: SearchFormDataRemovalTableDataResponseBodyDataModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponseBodyDataOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponseBodyDataOriginator extends $tea.Model {
  departmentName?: string;
  email?: string;
  name?: SearchFormDataRemovalTableDataResponseBodyDataOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentName: 'departmentName',
      email: 'email',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentName: 'string',
      email: 'string',
      name: SearchFormDataRemovalTableDataResponseBodyDataOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataRemovalTableDataResponseBodyData extends $tea.Model {
  createTimeGMT?: string;
  creatorUserId?: string;
  formData?: { [key: string]: any };
  formInstanceId?: string;
  formUuid?: string;
  id?: number;
  instanceValue?: string;
  modifiedTimeGMT?: string;
  modifier?: string;
  modifyUser?: SearchFormDataRemovalTableDataResponseBodyDataModifyUser;
  originator?: SearchFormDataRemovalTableDataResponseBodyDataOriginator;
  sequence?: string;
  serialNumber?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      creatorUserId: 'creatorUserId',
      formData: 'formData',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      id: 'id',
      instanceValue: 'instanceValue',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifier: 'modifier',
      modifyUser: 'modifyUser',
      originator: 'originator',
      sequence: 'sequence',
      serialNumber: 'serialNumber',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      creatorUserId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstanceId: 'string',
      formUuid: 'string',
      id: 'number',
      instanceValue: 'string',
      modifiedTimeGMT: 'string',
      modifier: 'string',
      modifyUser: SearchFormDataRemovalTableDataResponseBodyDataModifyUser,
      originator: SearchFormDataRemovalTableDataResponseBodyDataOriginator,
      sequence: 'string',
      serialNumber: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyDataModifyUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyDataModifyUser extends $tea.Model {
  name?: SearchFormDataSecondGenerationResponseBodyDataModifyUserName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: SearchFormDataSecondGenerationResponseBodyDataModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyDataOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyDataOriginator extends $tea.Model {
  name?: SearchFormDataSecondGenerationResponseBodyDataOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: SearchFormDataSecondGenerationResponseBodyDataOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyData extends $tea.Model {
  createTimeGMT?: string;
  creatorUserId?: string;
  formData?: { [key: string]: any };
  formInstanceId?: string;
  formUuid?: string;
  id?: number;
  instanceValue?: string;
  modifiedTimeGMT?: string;
  modifier?: string;
  modifyUser?: SearchFormDataSecondGenerationResponseBodyDataModifyUser;
  originator?: SearchFormDataSecondGenerationResponseBodyDataOriginator;
  sequence?: string;
  serialNumber?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      creatorUserId: 'creatorUserId',
      formData: 'formData',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      id: 'id',
      instanceValue: 'instanceValue',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifier: 'modifier',
      modifyUser: 'modifyUser',
      originator: 'originator',
      sequence: 'sequence',
      serialNumber: 'serialNumber',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      creatorUserId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstanceId: 'string',
      formUuid: 'string',
      id: 'number',
      instanceValue: 'string',
      modifiedTimeGMT: 'string',
      modifier: 'string',
      modifyUser: SearchFormDataSecondGenerationResponseBodyDataModifyUser,
      originator: SearchFormDataSecondGenerationResponseBodyDataOriginator,
      sequence: 'string',
      serialNumber: 'string',
      title: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser extends $tea.Model {
  name?: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator extends $tea.Model {
  name?: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyData extends $tea.Model {
  createTimeGMT?: string;
  creatorUserId?: string;
  formData?: { [key: string]: any };
  formInstanceId?: string;
  formUuid?: string;
  id?: number;
  instanceValue?: string;
  modifiedTimeGMT?: string;
  modifier?: string;
  modifyUser?: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser;
  originator?: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator;
  sequence?: string;
  serialNumber?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      creatorUserId: 'creatorUserId',
      formData: 'formData',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      id: 'id',
      instanceValue: 'instanceValue',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifier: 'modifier',
      modifyUser: 'modifyUser',
      originator: 'originator',
      sequence: 'sequence',
      serialNumber: 'serialNumber',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      creatorUserId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstanceId: 'string',
      formUuid: 'string',
      id: 'number',
      instanceValue: 'string',
      modifiedTimeGMT: 'string',
      modifier: 'string',
      modifyUser: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser,
      originator: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator,
      sequence: 'string',
      serialNumber: 'string',
      title: 'string',
      version: 'number',
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
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataModifyUserUserName,
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
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataOriginatorUserName,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyData extends $tea.Model {
  createdTimeGMT?: string;
  creatorUserId?: string;
  dataId?: number;
  formData?: { [key: string]: any };
  formInstanceId?: string;
  formUuid?: string;
  instanceValue?: string;
  modelUuid?: string;
  modifiedTimeGMT?: string;
  modifierUserId?: string;
  modifyUser?: SearchFormDatasResponseBodyDataModifyUser;
  originator?: SearchFormDatasResponseBodyDataOriginator;
  sequence?: string;
  serialNo?: string;
  title?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createdTimeGMT: 'createdTimeGMT',
      creatorUserId: 'creatorUserId',
      dataId: 'dataId',
      formData: 'formData',
      formInstanceId: 'formInstanceId',
      formUuid: 'formUuid',
      instanceValue: 'instanceValue',
      modelUuid: 'modelUuid',
      modifiedTimeGMT: 'modifiedTimeGMT',
      modifierUserId: 'modifierUserId',
      modifyUser: 'modifyUser',
      originator: 'originator',
      sequence: 'sequence',
      serialNo: 'serialNo',
      title: 'title',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdTimeGMT: 'string',
      creatorUserId: 'string',
      dataId: 'number',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formInstanceId: 'string',
      formUuid: 'string',
      instanceValue: 'string',
      modelUuid: 'string',
      modifiedTimeGMT: 'string',
      modifierUserId: 'string',
      modifyUser: SearchFormDatasResponseBodyDataModifyUser,
      originator: SearchFormDatasResponseBodyDataOriginator,
      sequence: 'string',
      serialNo: 'string',
      title: 'string',
      version: 'number',
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


  async appLoginCodeGenWithOptions(request: AppLoginCodeGenRequest, headers: AppLoginCodeGenHeaders, runtime: $Util.RuntimeOptions): Promise<AppLoginCodeGenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fullUrl)) {
      query["fullUrl"] = request.fullUrl;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.signTimestampStr)) {
      body["signTimestampStr"] = request.signTimestampStr;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AppLoginCodeGen",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/authorizations/appLoginCodes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AppLoginCodeGenResponse>(await this.execute(params, req, runtime), new AppLoginCodeGenResponse({}));
  }

  async appLoginCodeGen(request: AppLoginCodeGenRequest): Promise<AppLoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppLoginCodeGenHeaders({ });
    return await this.appLoginCodeGenWithOptions(request, headers, runtime);
  }

  async batchGetFormDataByIdListWithOptions(request: BatchGetFormDataByIdListRequest, headers: BatchGetFormDataByIdListHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetFormDataByIdListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formInstanceIdList)) {
      body["formInstanceIdList"] = request.formInstanceIdList;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.needFormInstanceValue)) {
      body["needFormInstanceValue"] = request.needFormInstanceValue;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "BatchGetFormDataByIdList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/ids/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchGetFormDataByIdListResponse>(await this.execute(params, req, runtime), new BatchGetFormDataByIdListResponse({}));
  }

  async batchGetFormDataByIdList(request: BatchGetFormDataByIdListRequest): Promise<BatchGetFormDataByIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetFormDataByIdListHeaders({ });
    return await this.batchGetFormDataByIdListWithOptions(request, headers, runtime);
  }

  async batchRemovalByFormInstanceIdListWithOptions(request: BatchRemovalByFormInstanceIdListRequest, headers: BatchRemovalByFormInstanceIdListHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRemovalByFormInstanceIdListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.asynchronousExecution)) {
      body["asynchronousExecution"] = request.asynchronousExecution;
    }

    if (!Util.isUnset(request.executeExpression)) {
      body["executeExpression"] = request.executeExpression;
    }

    if (!Util.isUnset(request.formInstanceIdList)) {
      body["formInstanceIdList"] = request.formInstanceIdList;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "BatchRemovalByFormInstanceIdList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<BatchRemovalByFormInstanceIdListResponse>(await this.execute(params, req, runtime), new BatchRemovalByFormInstanceIdListResponse({}));
  }

  async batchRemovalByFormInstanceIdList(request: BatchRemovalByFormInstanceIdListRequest): Promise<BatchRemovalByFormInstanceIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRemovalByFormInstanceIdListHeaders({ });
    return await this.batchRemovalByFormInstanceIdListWithOptions(request, headers, runtime);
  }

  async batchSaveFormDataWithOptions(request: BatchSaveFormDataRequest, headers: BatchSaveFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSaveFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.asynchronousExecution)) {
      body["asynchronousExecution"] = request.asynchronousExecution;
    }

    if (!Util.isUnset(request.formDataJsonList)) {
      body["formDataJsonList"] = request.formDataJsonList;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.keepRunningAfterException)) {
      body["keepRunningAfterException"] = request.keepRunningAfterException;
    }

    if (!Util.isUnset(request.noExecuteExpression)) {
      body["noExecuteExpression"] = request.noExecuteExpression;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "BatchSaveFormData",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/batchSave`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchSaveFormDataResponse>(await this.execute(params, req, runtime), new BatchSaveFormDataResponse({}));
  }

  async batchSaveFormData(request: BatchSaveFormDataRequest): Promise<BatchSaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSaveFormDataHeaders({ });
    return await this.batchSaveFormDataWithOptions(request, headers, runtime);
  }

  async batchUpdateFormDataByInstanceIdWithOptions(request: BatchUpdateFormDataByInstanceIdRequest, headers: BatchUpdateFormDataByInstanceIdHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateFormDataByInstanceIdResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.asynchronousExecution)) {
      body["asynchronousExecution"] = request.asynchronousExecution;
    }

    if (!Util.isUnset(request.formInstanceIdList)) {
      body["formInstanceIdList"] = request.formInstanceIdList;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.ignoreEmpty)) {
      body["ignoreEmpty"] = request.ignoreEmpty;
    }

    if (!Util.isUnset(request.noExecuteExpression)) {
      body["noExecuteExpression"] = request.noExecuteExpression;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
    }

    if (!Util.isUnset(request.useLatestFormSchemaVersion)) {
      body["useLatestFormSchemaVersion"] = request.useLatestFormSchemaVersion;
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
      action: "BatchUpdateFormDataByInstanceId",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/components`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateFormDataByInstanceIdResponse>(await this.execute(params, req, runtime), new BatchUpdateFormDataByInstanceIdResponse({}));
  }

  async batchUpdateFormDataByInstanceId(request: BatchUpdateFormDataByInstanceIdRequest): Promise<BatchUpdateFormDataByInstanceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateFormDataByInstanceIdHeaders({ });
    return await this.batchUpdateFormDataByInstanceIdWithOptions(request, headers, runtime);
  }

  async batchUpdateFormDataByInstanceMapWithOptions(request: BatchUpdateFormDataByInstanceMapRequest, headers: BatchUpdateFormDataByInstanceMapHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateFormDataByInstanceMapResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.asynchronousExecution)) {
      body["asynchronousExecution"] = request.asynchronousExecution;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.ignoreEmpty)) {
      body["ignoreEmpty"] = request.ignoreEmpty;
    }

    if (!Util.isUnset(request.noExecuteExpression)) {
      body["noExecuteExpression"] = request.noExecuteExpression;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.updateFormDataJsonMap)) {
      body["updateFormDataJsonMap"] = request.updateFormDataJsonMap;
    }

    if (!Util.isUnset(request.useLatestFormSchemaVersion)) {
      body["useLatestFormSchemaVersion"] = request.useLatestFormSchemaVersion;
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
      action: "BatchUpdateFormDataByInstanceMap",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/datas`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateFormDataByInstanceMapResponse>(await this.execute(params, req, runtime), new BatchUpdateFormDataByInstanceMapResponse({}));
  }

  async batchUpdateFormDataByInstanceMap(request: BatchUpdateFormDataByInstanceMapRequest): Promise<BatchUpdateFormDataByInstanceMapResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateFormDataByInstanceMapHeaders({ });
    return await this.batchUpdateFormDataByInstanceMapWithOptions(request, headers, runtime);
  }

  async buyAuthorizationOrderWithOptions(request: BuyAuthorizationOrderRequest, headers: BuyAuthorizationOrderHeaders, runtime: $Util.RuntimeOptions): Promise<BuyAuthorizationOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.beginTimeGMT)) {
      body["beginTimeGMT"] = request.beginTimeGMT;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.chargeType)) {
      body["chargeType"] = request.chargeType;
    }

    if (!Util.isUnset(request.commerceType)) {
      body["commerceType"] = request.commerceType;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.instanceName)) {
      body["instanceName"] = request.instanceName;
    }

    if (!Util.isUnset(request.produceCode)) {
      body["produceCode"] = request.produceCode;
    }

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
      action: "BuyAuthorizationOrder",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/appAuthorizations/order`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BuyAuthorizationOrderResponse>(await this.execute(params, req, runtime), new BuyAuthorizationOrderResponse({}));
  }

  async buyAuthorizationOrder(request: BuyAuthorizationOrderRequest): Promise<BuyAuthorizationOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BuyAuthorizationOrderHeaders({ });
    return await this.buyAuthorizationOrderWithOptions(request, headers, runtime);
  }

  async buyFreshOrderWithOptions(request: BuyFreshOrderRequest, headers: BuyFreshOrderHeaders, runtime: $Util.RuntimeOptions): Promise<BuyFreshOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.beginTimeGMT)) {
      body["beginTimeGMT"] = request.beginTimeGMT;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.chargeType)) {
      body["chargeType"] = request.chargeType;
    }

    if (!Util.isUnset(request.commerceType)) {
      body["commerceType"] = request.commerceType;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.instanceName)) {
      body["instanceName"] = request.instanceName;
    }

    if (!Util.isUnset(request.produceCode)) {
      body["produceCode"] = request.produceCode;
    }

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
      action: "BuyFreshOrder",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/freshOrders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BuyFreshOrderResponse>(await this.execute(params, req, runtime), new BuyFreshOrderResponse({}));
  }

  async buyFreshOrder(request: BuyFreshOrderRequest): Promise<BuyFreshOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BuyFreshOrderHeaders({ });
    return await this.buyFreshOrderWithOptions(request, headers, runtime);
  }

  async checkCloudAccountStatusWithOptions(callerUid: string, request: CheckCloudAccountStatusRequest, headers: CheckCloudAccountStatusHeaders, runtime: $Util.RuntimeOptions): Promise<CheckCloudAccountStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

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
      action: "CheckCloudAccountStatus",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/cloudAccountStatus/${callerUid}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<CheckCloudAccountStatusResponse>(await this.execute(params, req, runtime), new CheckCloudAccountStatusResponse({}));
  }

  async checkCloudAccountStatus(callerUid: string, request: CheckCloudAccountStatusRequest): Promise<CheckCloudAccountStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckCloudAccountStatusHeaders({ });
    return await this.checkCloudAccountStatusWithOptions(callerUid, request, headers, runtime);
  }

  async createOrUpdateFormDataWithOptions(request: CreateOrUpdateFormDataRequest, headers: CreateOrUpdateFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOrUpdateFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.noExecuteExpression)) {
      body["noExecuteExpression"] = request.noExecuteExpression;
    }

    if (!Util.isUnset(request.searchCondition)) {
      body["searchCondition"] = request.searchCondition;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "CreateOrUpdateFormData",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/insertOrUpdate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateOrUpdateFormDataResponse>(await this.execute(params, req, runtime), new CreateOrUpdateFormDataResponse({}));
  }

  async createOrUpdateFormData(request: CreateOrUpdateFormDataRequest): Promise<CreateOrUpdateFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrUpdateFormDataHeaders({ });
    return await this.createOrUpdateFormDataWithOptions(request, headers, runtime);
  }

  async deleteFormDataWithOptions(request: DeleteFormDataRequest, headers: DeleteFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFormDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      query["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "DeleteFormData",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteFormDataResponse>(await this.execute(params, req, runtime), new DeleteFormDataResponse({}));
  }

  async deleteFormData(request: DeleteFormDataRequest): Promise<DeleteFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFormDataHeaders({ });
    return await this.deleteFormDataWithOptions(request, headers, runtime);
  }

  async deleteInstanceWithOptions(request: DeleteInstanceRequest, headers: DeleteInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "DeleteInstance",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instances`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteInstanceResponse>(await this.execute(params, req, runtime), new DeleteInstanceResponse({}));
  }

  async deleteInstance(request: DeleteInstanceRequest): Promise<DeleteInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInstanceHeaders({ });
    return await this.deleteInstanceWithOptions(request, headers, runtime);
  }

  async deleteSequenceWithOptions(request: DeleteSequenceRequest, headers: DeleteSequenceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSequenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.sequence)) {
      query["sequence"] = request.sequence;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "DeleteSequence",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/deleteSequence`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<DeleteSequenceResponse>(await this.execute(params, req, runtime), new DeleteSequenceResponse({}));
  }

  async deleteSequence(request: DeleteSequenceRequest): Promise<DeleteSequenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSequenceHeaders({ });
    return await this.deleteSequenceWithOptions(request, headers, runtime);
  }

  async deployFunctionCallbackWithOptions(request: DeployFunctionCallbackRequest, headers: DeployFunctionCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<DeployFunctionCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.customDomain)) {
      body["customDomain"] = request.customDomain;
    }

    if (!Util.isUnset(request.deployStage)) {
      body["deployStage"] = request.deployStage;
    }

    if (!Util.isUnset(request.gateWayAppKey)) {
      body["gateWayAppKey"] = request.gateWayAppKey;
    }

    if (!Util.isUnset(request.gateWayAppSecret)) {
      body["gateWayAppSecret"] = request.gateWayAppSecret;
    }

    if (!Util.isUnset(request.gateWayDomain)) {
      body["gateWayDomain"] = request.gateWayDomain;
    }

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
      action: "DeployFunctionCallback",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/functionComputeConnectors/completeDeployments/notify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeployFunctionCallbackResponse>(await this.execute(params, req, runtime), new DeployFunctionCallbackResponse({}));
  }

  async deployFunctionCallback(request: DeployFunctionCallbackRequest): Promise<DeployFunctionCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeployFunctionCallbackHeaders({ });
    return await this.deployFunctionCallbackWithOptions(request, headers, runtime);
  }

  async executeBatchTaskWithOptions(request: ExecuteBatchTaskRequest, headers: ExecuteBatchTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteBatchTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.taskInformationList)) {
      body["taskInformationList"] = request.taskInformationList;
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
      action: "ExecuteBatchTask",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/batches/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExecuteBatchTaskResponse>(await this.execute(params, req, runtime), new ExecuteBatchTaskResponse({}));
  }

  async executeBatchTask(request: ExecuteBatchTaskRequest): Promise<ExecuteBatchTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteBatchTaskHeaders({ });
    return await this.executeBatchTaskWithOptions(request, headers, runtime);
  }

  async executeCustomApiWithOptions(request: ExecuteCustomApiRequest, headers: ExecuteCustomApiHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteCustomApiResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.data)) {
      query["data"] = request.data;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.serviceId)) {
      query["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "ExecuteCustomApi",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/customApi/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ExecuteCustomApiResponse>(await this.execute(params, req, runtime), new ExecuteCustomApiResponse({}));
  }

  async executeCustomApi(request: ExecuteCustomApiRequest): Promise<ExecuteCustomApiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteCustomApiHeaders({ });
    return await this.executeCustomApiWithOptions(request, headers, runtime);
  }

  async executePlatformTaskWithOptions(request: ExecutePlatformTaskRequest, headers: ExecutePlatformTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecutePlatformTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.noExecuteExpressions)) {
      body["noExecuteExpressions"] = request.noExecuteExpressions;
    }

    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "ExecutePlatformTask",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/platformTasks/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<ExecutePlatformTaskResponse>(await this.execute(params, req, runtime), new ExecutePlatformTaskResponse({}));
  }

  async executePlatformTask(request: ExecutePlatformTaskRequest): Promise<ExecutePlatformTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecutePlatformTaskHeaders({ });
    return await this.executePlatformTaskWithOptions(request, headers, runtime);
  }

  async executeTaskWithOptions(request: ExecuteTaskRequest, headers: ExecuteTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.digitalSignUrl)) {
      body["digitalSignUrl"] = request.digitalSignUrl;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.noExecuteExpressions)) {
      body["noExecuteExpressions"] = request.noExecuteExpressions;
    }

    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      action: "ExecuteTask",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<ExecuteTaskResponse>(await this.execute(params, req, runtime), new ExecuteTaskResponse({}));
  }

  async executeTask(request: ExecuteTaskRequest): Promise<ExecuteTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteTaskHeaders({ });
    return await this.executeTaskWithOptions(request, headers, runtime);
  }

  async expireCommodityWithOptions(request: ExpireCommodityRequest, headers: ExpireCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ExpireCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "ExpireCommodity",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/appAuth/commodities/expire`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ExpireCommodityResponse>(await this.execute(params, req, runtime), new ExpireCommodityResponse({}));
  }

  async expireCommodity(request: ExpireCommodityRequest): Promise<ExpireCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExpireCommodityHeaders({ });
    return await this.expireCommodityWithOptions(request, headers, runtime);
  }

  async getActivationCodeByCallerUnionIdWithOptions(callerUid: string, request: GetActivationCodeByCallerUnionIdRequest, headers: GetActivationCodeByCallerUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivationCodeByCallerUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

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
      action: "GetActivationCodeByCallerUnionId",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applications/activationCodes/${callerUid}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetActivationCodeByCallerUnionIdResponse>(await this.execute(params, req, runtime), new GetActivationCodeByCallerUnionIdResponse({}));
  }

  async getActivationCodeByCallerUnionId(callerUid: string, request: GetActivationCodeByCallerUnionIdRequest): Promise<GetActivationCodeByCallerUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivationCodeByCallerUnionIdHeaders({ });
    return await this.getActivationCodeByCallerUnionIdWithOptions(callerUid, request, headers, runtime);
  }

  async getActivityButtonListWithOptions(appType: string, processCode: string, activityId: string, request: GetActivityButtonListRequest, headers: GetActivityButtonListHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivityButtonListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetActivityButtonList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processDefinitions/buttons/${appType}/${processCode}/${activityId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetActivityButtonListResponse>(await this.execute(params, req, runtime), new GetActivityButtonListResponse({}));
  }

  async getActivityButtonList(appType: string, processCode: string, activityId: string, request: GetActivityButtonListRequest): Promise<GetActivityButtonListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityButtonListHeaders({ });
    return await this.getActivityButtonListWithOptions(appType, processCode, activityId, request, headers, runtime);
  }

  async getActivityListWithOptions(request: GetActivityListRequest, headers: GetActivityListHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivityListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetActivityList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/activities`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetActivityListResponse>(await this.execute(params, req, runtime), new GetActivityListResponse({}));
  }

  async getActivityList(request: GetActivityListRequest): Promise<GetActivityListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityListHeaders({ });
    return await this.getActivityListWithOptions(request, headers, runtime);
  }

  async getAllAuthCubesWithOptions(request: GetAllAuthCubesRequest, headers: GetAllAuthCubesHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllAuthCubesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.keywords)) {
      body["keywords"] = request.keywords;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "GetAllAuthCubes",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/metadata/allAuthCubes/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllAuthCubesResponse>(await this.execute(params, req, runtime), new GetAllAuthCubesResponse({}));
  }

  async getAllAuthCubes(request: GetAllAuthCubesRequest): Promise<GetAllAuthCubesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllAuthCubesHeaders({ });
    return await this.getAllAuthCubesWithOptions(request, headers, runtime);
  }

  async getApplicationAuthorizationServicePlatformResourceWithOptions(request: GetApplicationAuthorizationServicePlatformResourceRequest, headers: GetApplicationAuthorizationServicePlatformResourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "GetApplicationAuthorizationServicePlatformResource",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/authorization/platformResources`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetApplicationAuthorizationServicePlatformResourceResponse>(await this.execute(params, req, runtime), new GetApplicationAuthorizationServicePlatformResourceResponse({}));
  }

  async getApplicationAuthorizationServicePlatformResource(request: GetApplicationAuthorizationServicePlatformResourceRequest): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationAuthorizationServicePlatformResourceHeaders({ });
    return await this.getApplicationAuthorizationServicePlatformResourceWithOptions(request, headers, runtime);
  }

  async getCorpAccomplishmentTasksWithOptions(corpId: string, userId: string, request: GetCorpAccomplishmentTasksRequest, headers: GetCorpAccomplishmentTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpAccomplishmentTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
    }

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
      action: "GetCorpAccomplishmentTasks",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/completedTasks/${corpId}/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCorpAccomplishmentTasksResponse>(await this.execute(params, req, runtime), new GetCorpAccomplishmentTasksResponse({}));
  }

  async getCorpAccomplishmentTasks(corpId: string, userId: string, request: GetCorpAccomplishmentTasksRequest): Promise<GetCorpAccomplishmentTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpAccomplishmentTasksHeaders({ });
    return await this.getCorpAccomplishmentTasksWithOptions(corpId, userId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetCorpLevelByAccountId",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/corpLevel`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetCorpLevelByAccountIdResponse>(await this.execute(params, req, runtime), new GetCorpLevelByAccountIdResponse({}));
  }

  async getCorpLevelByAccountId(request: GetCorpLevelByAccountIdRequest): Promise<GetCorpLevelByAccountIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpLevelByAccountIdHeaders({ });
    return await this.getCorpLevelByAccountIdWithOptions(request, headers, runtime);
  }

  async getCorpTasksWithOptions(request: GetCorpTasksRequest, headers: GetCorpTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
    }

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
      action: "GetCorpTasks",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/corpTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCorpTasksResponse>(await this.execute(params, req, runtime), new GetCorpTasksResponse({}));
  }

  async getCorpTasks(request: GetCorpTasksRequest): Promise<GetCorpTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpTasksHeaders({ });
    return await this.getCorpTasksWithOptions(request, headers, runtime);
  }

  async getDbConfigWithOptions(request: GetDbConfigRequest, headers: GetDbConfigHeaders, runtime: $Util.RuntimeOptions): Promise<GetDbConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetDbConfig",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/metadata/dbConfigs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDbConfigResponse>(await this.execute(params, req, runtime), new GetDbConfigResponse({}));
  }

  async getDbConfig(request: GetDbConfigRequest): Promise<GetDbConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDbConfigHeaders({ });
    return await this.getDbConfigWithOptions(request, headers, runtime);
  }

  async getFieldDefByUuidWithOptions(request: GetFieldDefByUuidRequest, headers: GetFieldDefByUuidHeaders, runtime: $Util.RuntimeOptions): Promise<GetFieldDefByUuidResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formUuid)) {
      query["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetFieldDefByUuid",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/formFields`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFieldDefByUuidResponse>(await this.execute(params, req, runtime), new GetFieldDefByUuidResponse({}));
  }

  async getFieldDefByUuid(request: GetFieldDefByUuidRequest): Promise<GetFieldDefByUuidResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFieldDefByUuidHeaders({ });
    return await this.getFieldDefByUuidWithOptions(request, headers, runtime);
  }

  async getFormComponentDefinitionListWithOptions(appType: string, formUuid: string, request: GetFormComponentDefinitionListRequest, headers: GetFormComponentDefinitionListHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormComponentDefinitionListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
    }

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
      action: "GetFormComponentDefinitionList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/definitions/${appType}/${formUuid}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFormComponentDefinitionListResponse>(await this.execute(params, req, runtime), new GetFormComponentDefinitionListResponse({}));
  }

  async getFormComponentDefinitionList(appType: string, formUuid: string, request: GetFormComponentDefinitionListRequest): Promise<GetFormComponentDefinitionListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormComponentDefinitionListHeaders({ });
    return await this.getFormComponentDefinitionListWithOptions(appType, formUuid, request, headers, runtime);
  }

  async getFormDataByIDWithOptions(id: string, request: GetFormDataByIDRequest, headers: GetFormDataByIDHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormDataByIDResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetFormDataByID",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/${id}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFormDataByIDResponse>(await this.execute(params, req, runtime), new GetFormDataByIDResponse({}));
  }

  async getFormDataByID(id: string, request: GetFormDataByIDRequest): Promise<GetFormDataByIDResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormDataByIDHeaders({ });
    return await this.getFormDataByIDWithOptions(id, request, headers, runtime);
  }

  async getFormListInAppWithOptions(request: GetFormListInAppRequest, headers: GetFormListInAppHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormListInAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formTypes)) {
      query["formTypes"] = request.formTypes;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetFormListInApp",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFormListInAppResponse>(await this.execute(params, req, runtime), new GetFormListInAppResponse({}));
  }

  async getFormListInApp(request: GetFormListInAppRequest): Promise<GetFormListInAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormListInAppHeaders({ });
    return await this.getFormListInAppWithOptions(request, headers, runtime);
  }

  async getInstanceByIdWithOptions(id: string, request: GetInstanceByIdRequest, headers: GetInstanceByIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstanceByIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetInstanceById",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instancesInfos/${id}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInstanceByIdResponse>(await this.execute(params, req, runtime), new GetInstanceByIdResponse({}));
  }

  async getInstanceById(id: string, request: GetInstanceByIdRequest): Promise<GetInstanceByIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstanceByIdHeaders({ });
    return await this.getInstanceByIdWithOptions(id, request, headers, runtime);
  }

  async getInstanceIdListWithOptions(request: GetInstanceIdListRequest, headers: GetInstanceIdListHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstanceIdListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.approvedResult)) {
      body["approvedResult"] = request.approvedResult;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.instanceStatus)) {
      body["instanceStatus"] = request.instanceStatus;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetInstanceIdList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instanceIds`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInstanceIdListResponse>(await this.execute(params, req, runtime), new GetInstanceIdListResponse({}));
  }

  async getInstanceIdList(request: GetInstanceIdListRequest): Promise<GetInstanceIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstanceIdListHeaders({ });
    return await this.getInstanceIdListWithOptions(request, headers, runtime);
  }

  async getInstancesWithOptions(request: GetInstancesRequest, headers: GetInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.approvedResult)) {
      body["approvedResult"] = request.approvedResult;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.instanceStatus)) {
      body["instanceStatus"] = request.instanceStatus;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.orderConfigJson)) {
      body["orderConfigJson"] = request.orderConfigJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetInstances",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInstancesResponse>(await this.execute(params, req, runtime), new GetInstancesResponse({}));
  }

  async getInstances(request: GetInstancesRequest): Promise<GetInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesHeaders({ });
    return await this.getInstancesWithOptions(request, headers, runtime);
  }

  async getInstancesByIdListWithOptions(request: GetInstancesByIdListRequest, headers: GetInstancesByIdListHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstancesByIdListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceIds)) {
      query["processInstanceIds"] = request.processInstanceIds;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetInstancesByIdList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instances/searchWithIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInstancesByIdListResponse>(await this.execute(params, req, runtime), new GetInstancesByIdListResponse({}));
  }

  async getInstancesByIdList(request: GetInstancesByIdListRequest): Promise<GetInstancesByIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesByIdListHeaders({ });
    return await this.getInstancesByIdListWithOptions(request, headers, runtime);
  }

  async getMeCorpSubmissionWithOptions(userId: string, request: GetMeCorpSubmissionRequest, headers: GetMeCorpSubmissionHeaders, runtime: $Util.RuntimeOptions): Promise<GetMeCorpSubmissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
    }

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
      action: "GetMeCorpSubmission",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/myCorpSubmission/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetMeCorpSubmissionResponse>(await this.execute(params, req, runtime), new GetMeCorpSubmissionResponse({}));
  }

  async getMeCorpSubmission(userId: string, request: GetMeCorpSubmissionRequest): Promise<GetMeCorpSubmissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMeCorpSubmissionHeaders({ });
    return await this.getMeCorpSubmissionWithOptions(userId, request, headers, runtime);
  }

  async getNotifyMeWithOptions(userId: string, request: GetNotifyMeRequest, headers: GetNotifyMeHeaders, runtime: $Util.RuntimeOptions): Promise<GetNotifyMeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.instanceCreateFromTimeGMT)) {
      query["instanceCreateFromTimeGMT"] = request.instanceCreateFromTimeGMT;
    }

    if (!Util.isUnset(request.instanceCreateToTimeGMT)) {
      query["instanceCreateToTimeGMT"] = request.instanceCreateToTimeGMT;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
    }

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
      action: "GetNotifyMe",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/corpNotifications/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNotifyMeResponse>(await this.execute(params, req, runtime), new GetNotifyMeResponse({}));
  }

  async getNotifyMe(userId: string, request: GetNotifyMeRequest): Promise<GetNotifyMeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNotifyMeHeaders({ });
    return await this.getNotifyMeWithOptions(userId, request, headers, runtime);
  }

  async getOpenUrlWithOptions(appType: string, request: GetOpenUrlRequest, headers: GetOpenUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetOpenUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileUrl)) {
      query["fileUrl"] = request.fileUrl;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.timeout)) {
      query["timeout"] = request.timeout;
    }

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
      action: "GetOpenUrl",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/temporaryUrls/${appType}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOpenUrlResponse>(await this.execute(params, req, runtime), new GetOpenUrlResponse({}));
  }

  async getOpenUrl(appType: string, request: GetOpenUrlRequest): Promise<GetOpenUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenUrlHeaders({ });
    return await this.getOpenUrlWithOptions(appType, request, headers, runtime);
  }

  async getOperationRecordsWithOptions(request: GetOperationRecordsRequest, headers: GetOperationRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOperationRecordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetOperationRecords",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/operationRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOperationRecordsResponse>(await this.execute(params, req, runtime), new GetOperationRecordsResponse({}));
  }

  async getOperationRecords(request: GetOperationRecordsRequest): Promise<GetOperationRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOperationRecordsHeaders({ });
    return await this.getOperationRecordsWithOptions(request, headers, runtime);
  }

  async getPlatformResourceWithOptions(request: GetPlatformResourceRequest, headers: GetPlatformResourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetPlatformResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "GetPlatformResource",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/platformResources`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetPlatformResourceResponse>(await this.execute(params, req, runtime), new GetPlatformResourceResponse({}));
  }

  async getPlatformResource(request: GetPlatformResourceRequest): Promise<GetPlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPlatformResourceHeaders({ });
    return await this.getPlatformResourceWithOptions(request, headers, runtime);
  }

  async getPrintAppInfoWithOptions(request: GetPrintAppInfoRequest, headers: GetPrintAppInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrintAppInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nameLike)) {
      query["nameLike"] = request.nameLike;
    }

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
      action: "GetPrintAppInfo",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/printTemplates/printAppInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetPrintAppInfoResponse>(await this.execute(params, req, runtime), new GetPrintAppInfoResponse({}));
  }

  async getPrintAppInfo(request: GetPrintAppInfoRequest): Promise<GetPrintAppInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrintAppInfoHeaders({ });
    return await this.getPrintAppInfoWithOptions(request, headers, runtime);
  }

  async getPrintDictionaryWithOptions(request: GetPrintDictionaryRequest, headers: GetPrintDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrintDictionaryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formUuid)) {
      query["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
    }

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
      action: "GetPrintDictionary",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/printTemplates/printDictionaries`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetPrintDictionaryResponse>(await this.execute(params, req, runtime), new GetPrintDictionaryResponse({}));
  }

  async getPrintDictionary(request: GetPrintDictionaryRequest): Promise<GetPrintDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrintDictionaryHeaders({ });
    return await this.getPrintDictionaryWithOptions(request, headers, runtime);
  }

  async getProcessDefinitionWithOptions(processInstanceId: string, request: GetProcessDefinitionRequest, headers: GetProcessDefinitionHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessDefinitionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.groupId)) {
      query["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.nameSpace)) {
      query["nameSpace"] = request.nameSpace;
    }

    if (!Util.isUnset(request.orderNumber)) {
      query["orderNumber"] = request.orderNumber;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.systemType)) {
      query["systemType"] = request.systemType;
    }

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
      action: "GetProcessDefinition",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/definitions/${processInstanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProcessDefinitionResponse>(await this.execute(params, req, runtime), new GetProcessDefinitionResponse({}));
  }

  async getProcessDefinition(processInstanceId: string, request: GetProcessDefinitionRequest): Promise<GetProcessDefinitionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessDefinitionHeaders({ });
    return await this.getProcessDefinitionWithOptions(processInstanceId, request, headers, runtime);
  }

  async getRunningTaskListWithOptions(request: GetRunningTaskListRequest, headers: GetRunningTaskListHeaders, runtime: $Util.RuntimeOptions): Promise<GetRunningTaskListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.processInstanceIdList)) {
      body["processInstanceIdList"] = request.processInstanceIdList;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userCorpId)) {
      body["userCorpId"] = request.userCorpId;
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
      action: "GetRunningTaskList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/runningTasks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRunningTaskListResponse>(await this.execute(params, req, runtime), new GetRunningTaskListResponse({}));
  }

  async getRunningTaskList(request: GetRunningTaskListRequest): Promise<GetRunningTaskListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTaskListHeaders({ });
    return await this.getRunningTaskListWithOptions(request, headers, runtime);
  }

  async getRunningTasksWithOptions(request: GetRunningTasksRequest, headers: GetRunningTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetRunningTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetRunningTasks",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/tasks/getRunningTasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRunningTasksResponse>(await this.execute(params, req, runtime), new GetRunningTasksResponse({}));
  }

  async getRunningTasks(request: GetRunningTasksRequest): Promise<GetRunningTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTasksHeaders({ });
    return await this.getRunningTasksWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetSaleUserInfoByUserId",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/saleUserInfo`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<GetSaleUserInfoByUserIdResponse>(await this.execute(params, req, runtime), new GetSaleUserInfoByUserIdResponse({}));
  }

  async getSaleUserInfoByUserId(request: GetSaleUserInfoByUserIdRequest): Promise<GetSaleUserInfoByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSaleUserInfoByUserIdHeaders({ });
    return await this.getSaleUserInfoByUserIdWithOptions(request, headers, runtime);
  }

  async getSimpleCubeModelListWithOptions(request: GetSimpleCubeModelListRequest, headers: GetSimpleCubeModelListHeaders, runtime: $Util.RuntimeOptions): Promise<GetSimpleCubeModelListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.cubeCode)) {
      query["cubeCode"] = request.cubeCode;
    }

    if (!Util.isUnset(request.cubeTenantId)) {
      query["cubeTenantId"] = request.cubeTenantId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetSimpleCubeModelList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/metadata/simpleCubeModelLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSimpleCubeModelListResponse>(await this.execute(params, req, runtime), new GetSimpleCubeModelListResponse({}));
  }

  async getSimpleCubeModelList(request: GetSimpleCubeModelListRequest): Promise<GetSimpleCubeModelListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSimpleCubeModelListHeaders({ });
    return await this.getSimpleCubeModelListWithOptions(request, headers, runtime);
  }

  async getTaskCopiesWithOptions(request: GetTaskCopiesRequest, headers: GetTaskCopiesHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskCopiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "GetTaskCopies",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/taskCopies`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTaskCopiesResponse>(await this.execute(params, req, runtime), new GetTaskCopiesResponse({}));
  }

  async getTaskCopies(request: GetTaskCopiesRequest): Promise<GetTaskCopiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskCopiesHeaders({ });
    return await this.getTaskCopiesWithOptions(request, headers, runtime);
  }

  async listApplicationWithOptions(request: ListApplicationRequest, headers: ListApplicationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appFilter)) {
      query["appFilter"] = request.appFilter;
    }

    if (!Util.isUnset(request.appNameSearchKeyword)) {
      query["appNameSearchKeyword"] = request.appNameSearchKeyword;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
    }

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
      action: "ListApplication",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/organizations/applications`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListApplicationResponse>(await this.execute(params, req, runtime), new ListApplicationResponse({}));
  }

  async listApplication(request: ListApplicationRequest): Promise<ListApplicationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationHeaders({ });
    return await this.listApplicationWithOptions(request, headers, runtime);
  }

  async listApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId: string, request: ListApplicationAuthorizationServiceApplicationInformationRequest, headers: ListApplicationAuthorizationServiceApplicationInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationAuthorizationServiceApplicationInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      query["callerUnionId"] = request.callerUnionId;
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
      action: "ListApplicationAuthorizationServiceApplicationInformation",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/authorizations/applicationInfos/${instanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ListApplicationAuthorizationServiceApplicationInformationResponse>(await this.execute(params, req, runtime), new ListApplicationAuthorizationServiceApplicationInformationResponse({}));
  }

  async listApplicationAuthorizationServiceApplicationInformation(instanceId: string, request: ListApplicationAuthorizationServiceApplicationInformationRequest): Promise<ListApplicationAuthorizationServiceApplicationInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders({ });
    return await this.listApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId: string, request: ListApplicationAuthorizationServiceConnectorInformationRequest, headers: ListApplicationAuthorizationServiceConnectorInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationAuthorizationServiceConnectorInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
      action: "ListApplicationAuthorizationServiceConnectorInformation",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applicationAuthorizations/plugs/${instanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ListApplicationAuthorizationServiceConnectorInformationResponse>(await this.execute(params, req, runtime), new ListApplicationAuthorizationServiceConnectorInformationResponse({}));
  }

  async listApplicationAuthorizationServiceConnectorInformation(instanceId: string, request: ListApplicationAuthorizationServiceConnectorInformationRequest): Promise<ListApplicationAuthorizationServiceConnectorInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders({ });
    return await this.listApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listApplicationInformationWithOptions(instanceId: string, request: ListApplicationInformationRequest, headers: ListApplicationInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
      action: "ListApplicationInformation",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/infos/${instanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ListApplicationInformationResponse>(await this.execute(params, req, runtime), new ListApplicationInformationResponse({}));
  }

  async listApplicationInformation(instanceId: string, request: ListApplicationInformationRequest): Promise<ListApplicationInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationInformationHeaders({ });
    return await this.listApplicationInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listCommodityWithOptions(request: ListCommodityRequest, headers: ListCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ListCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
      action: "ListCommodity",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/appAuth/commodities`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ListCommodityResponse>(await this.execute(params, req, runtime), new ListCommodityResponse({}));
  }

  async listCommodity(request: ListCommodityRequest): Promise<ListCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCommodityHeaders({ });
    return await this.listCommodityWithOptions(request, headers, runtime);
  }

  async listConnectorInformationWithOptions(instanceId: string, request: ListConnectorInformationRequest, headers: ListConnectorInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListConnectorInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
      action: "ListConnectorInformation",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/plugins/infos/${instanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ListConnectorInformationResponse>(await this.execute(params, req, runtime), new ListConnectorInformationResponse({}));
  }

  async listConnectorInformation(instanceId: string, request: ListConnectorInformationRequest): Promise<ListConnectorInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListConnectorInformationHeaders({ });
    return await this.listConnectorInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listFormRemarksWithOptions(request: ListFormRemarksRequest, headers: ListFormRemarksHeaders, runtime: $Util.RuntimeOptions): Promise<ListFormRemarksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formInstanceIdList)) {
      body["formInstanceIdList"] = request.formInstanceIdList;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "ListFormRemarks",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/remarks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListFormRemarksResponse>(await this.execute(params, req, runtime), new ListFormRemarksResponse({}));
  }

  async listFormRemarks(request: ListFormRemarksRequest): Promise<ListFormRemarksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFormRemarksHeaders({ });
    return await this.listFormRemarksWithOptions(request, headers, runtime);
  }

  async listNavigationByFormTypeWithOptions(request: ListNavigationByFormTypeRequest, headers: ListNavigationByFormTypeHeaders, runtime: $Util.RuntimeOptions): Promise<ListNavigationByFormTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formType)) {
      query["formType"] = request.formType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "ListNavigationByFormType",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/navigations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ListNavigationByFormTypeResponse>(await this.execute(params, req, runtime), new ListNavigationByFormTypeResponse({}));
  }

  async listNavigationByFormType(request: ListNavigationByFormTypeRequest): Promise<ListNavigationByFormTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListNavigationByFormTypeHeaders({ });
    return await this.listNavigationByFormTypeWithOptions(request, headers, runtime);
  }

  async listOperationLogsWithOptions(request: ListOperationLogsRequest, headers: ListOperationLogsHeaders, runtime: $Util.RuntimeOptions): Promise<ListOperationLogsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formInstanceIdList)) {
      body["formInstanceIdList"] = request.formInstanceIdList;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "ListOperationLogs",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/operationsLogs/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListOperationLogsResponse>(await this.execute(params, req, runtime), new ListOperationLogsResponse({}));
  }

  async listOperationLogs(request: ListOperationLogsRequest): Promise<ListOperationLogsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListOperationLogsHeaders({ });
    return await this.listOperationLogsWithOptions(request, headers, runtime);
  }

  async listTableDataByFormInstanceIdTableIdWithOptions(formInstanceId: string, request: ListTableDataByFormInstanceIdTableIdRequest, headers: ListTableDataByFormInstanceIdTableIdHeaders, runtime: $Util.RuntimeOptions): Promise<ListTableDataByFormInstanceIdTableIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formUuid)) {
      query["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.tableFieldId)) {
      query["tableFieldId"] = request.tableFieldId;
    }

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
      action: "ListTableDataByFormInstanceIdTableId",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/innerTables/${formInstanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListTableDataByFormInstanceIdTableIdResponse>(await this.execute(params, req, runtime), new ListTableDataByFormInstanceIdTableIdResponse({}));
  }

  async listTableDataByFormInstanceIdTableId(formInstanceId: string, request: ListTableDataByFormInstanceIdTableIdRequest): Promise<ListTableDataByFormInstanceIdTableIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTableDataByFormInstanceIdTableIdHeaders({ });
    return await this.listTableDataByFormInstanceIdTableIdWithOptions(formInstanceId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "LoginCodeGen",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/authorizations/loginCodes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LoginCodeGenResponse>(await this.execute(params, req, runtime), new LoginCodeGenResponse({}));
  }

  async loginCodeGen(request: LoginCodeGenRequest): Promise<LoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoginCodeGenHeaders({ });
    return await this.loginCodeGenWithOptions(request, headers, runtime);
  }

  async notifyAuthorizationResultWithOptions(request: NotifyAuthorizationResultRequest, headers: NotifyAuthorizationResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyAuthorizationResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.beginTimeGMT)) {
      body["beginTimeGMT"] = request.beginTimeGMT;
    }

    if (!Util.isUnset(request.callerUid)) {
      body["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.chargeType)) {
      body["chargeType"] = request.chargeType;
    }

    if (!Util.isUnset(request.commerceType)) {
      body["commerceType"] = request.commerceType;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.instanceName)) {
      body["instanceName"] = request.instanceName;
    }

    if (!Util.isUnset(request.produceCode)) {
      body["produceCode"] = request.produceCode;
    }

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
      action: "NotifyAuthorizationResult",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/authorizationResults/notify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<NotifyAuthorizationResultResponse>(await this.execute(params, req, runtime), new NotifyAuthorizationResultResponse({}));
  }

  async notifyAuthorizationResult(request: NotifyAuthorizationResultRequest): Promise<NotifyAuthorizationResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyAuthorizationResultHeaders({ });
    return await this.notifyAuthorizationResultWithOptions(request, headers, runtime);
  }

  async pageFormBaseInfosWithOptions(request: PageFormBaseInfosRequest, headers: PageFormBaseInfosHeaders, runtime: $Util.RuntimeOptions): Promise<PageFormBaseInfosResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.formTypeList)) {
      body["formTypeList"] = request.formTypeList;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.pageIndex)) {
      body["pageIndex"] = request.pageIndex;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "PageFormBaseInfos",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/forms/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PageFormBaseInfosResponse>(await this.execute(params, req, runtime), new PageFormBaseInfosResponse({}));
  }

  async pageFormBaseInfos(request: PageFormBaseInfosRequest): Promise<PageFormBaseInfosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageFormBaseInfosHeaders({ });
    return await this.pageFormBaseInfosWithOptions(request, headers, runtime);
  }

  async queryServiceRecordWithOptions(request: QueryServiceRecordRequest, headers: QueryServiceRecordHeaders, runtime: $Util.RuntimeOptions): Promise<QueryServiceRecordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formUuid)) {
      query["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.hookType)) {
      query["hookType"] = request.hookType;
    }

    if (!Util.isUnset(request.hookUuid)) {
      query["hookUuid"] = request.hookUuid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.invokeAfterDateGMT)) {
      query["invokeAfterDateGMT"] = request.invokeAfterDateGMT;
    }

    if (!Util.isUnset(request.invokeBeforeDateGMT)) {
      query["invokeBeforeDateGMT"] = request.invokeBeforeDateGMT;
    }

    if (!Util.isUnset(request.invokeStatus)) {
      query["invokeStatus"] = request.invokeStatus;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.requestUrl)) {
      query["requestUrl"] = request.requestUrl;
    }

    if (!Util.isUnset(request.sourceUuid)) {
      query["sourceUuid"] = request.sourceUuid;
    }

    if (!Util.isUnset(request.success)) {
      query["success"] = request.success;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "QueryServiceRecord",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/services/invocationRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryServiceRecordResponse>(await this.execute(params, req, runtime), new QueryServiceRecordResponse({}));
  }

  async queryServiceRecord(request: QueryServiceRecordRequest): Promise<QueryServiceRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryServiceRecordHeaders({ });
    return await this.queryServiceRecordWithOptions(request, headers, runtime);
  }

  async redirectTaskWithOptions(request: RedirectTaskRequest, headers: RedirectTaskHeaders, runtime: $Util.RuntimeOptions): Promise<RedirectTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.byManager)) {
      body["byManager"] = request.byManager;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.nowActionExecutorId)) {
      body["nowActionExecutorId"] = request.nowActionExecutorId;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      action: "RedirectTask",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/tasks/redirect`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<RedirectTaskResponse>(await this.execute(params, req, runtime), new RedirectTaskResponse({}));
  }

  async redirectTask(request: RedirectTaskRequest): Promise<RedirectTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RedirectTaskHeaders({ });
    return await this.redirectTaskWithOptions(request, headers, runtime);
  }

  async refundCommodityWithOptions(request: RefundCommodityRequest, headers: RefundCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<RefundCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "RefundCommodity",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/appAuth/commodities/refund`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RefundCommodityResponse>(await this.execute(params, req, runtime), new RefundCommodityResponse({}));
  }

  async refundCommodity(request: RefundCommodityRequest): Promise<RefundCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RefundCommodityHeaders({ });
    return await this.refundCommodityWithOptions(request, headers, runtime);
  }

  async registerAccountsWithOptions(request: RegisterAccountsRequest, headers: RegisterAccountsHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAccountsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.activeCode)) {
      body["activeCode"] = request.activeCode;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

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
      action: "RegisterAccounts",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applicationAuthorizations/accounts/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RegisterAccountsResponse>(await this.execute(params, req, runtime), new RegisterAccountsResponse({}));
  }

  async registerAccounts(request: RegisterAccountsRequest): Promise<RegisterAccountsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAccountsHeaders({ });
    return await this.registerAccountsWithOptions(request, headers, runtime);
  }

  async releaseCommodityWithOptions(request: ReleaseCommodityRequest, headers: ReleaseCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "ReleaseCommodity",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/appAuth/commodities/release`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ReleaseCommodityResponse>(await this.execute(params, req, runtime), new ReleaseCommodityResponse({}));
  }

  async releaseCommodity(request: ReleaseCommodityRequest): Promise<ReleaseCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseCommodityHeaders({ });
    return await this.releaseCommodityWithOptions(request, headers, runtime);
  }

  async removeTenantResourceWithOptions(callerUid: string, request: RemoveTenantResourceRequest, headers: RemoveTenantResourceHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveTenantResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

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
      action: "RemoveTenantResource",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applications/tenantRelatedResources/${callerUid}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<RemoveTenantResourceResponse>(await this.execute(params, req, runtime), new RemoveTenantResourceResponse({}));
  }

  async removeTenantResource(callerUid: string, request: RemoveTenantResourceRequest): Promise<RemoveTenantResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveTenantResourceHeaders({ });
    return await this.removeTenantResourceWithOptions(callerUid, request, headers, runtime);
  }

  async renderBatchCallbackWithOptions(request: RenderBatchCallbackRequest, headers: RenderBatchCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<RenderBatchCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.namespace)) {
      body["namespace"] = request.namespace;
    }

    if (!Util.isUnset(request.ossUrl)) {
      body["ossUrl"] = request.ossUrl;
    }

    if (!Util.isUnset(request.sequenceId)) {
      body["sequenceId"] = request.sequenceId;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.timeZone)) {
      body["timeZone"] = request.timeZone;
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
      action: "RenderBatchCallback",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/printings/callbacks/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RenderBatchCallbackResponse>(await this.execute(params, req, runtime), new RenderBatchCallbackResponse({}));
  }

  async renderBatchCallback(request: RenderBatchCallbackRequest): Promise<RenderBatchCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenderBatchCallbackHeaders({ });
    return await this.renderBatchCallbackWithOptions(request, headers, runtime);
  }

  async renewApplicationAuthorizationServiceOrderWithOptions(request: RenewApplicationAuthorizationServiceOrderRequest, headers: RenewApplicationAuthorizationServiceOrderHeaders, runtime: $Util.RuntimeOptions): Promise<RenewApplicationAuthorizationServiceOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

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
      action: "RenewApplicationAuthorizationServiceOrder",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applicationAuthorizations/orders/renew`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RenewApplicationAuthorizationServiceOrderResponse>(await this.execute(params, req, runtime), new RenewApplicationAuthorizationServiceOrderResponse({}));
  }

  async renewApplicationAuthorizationServiceOrder(request: RenewApplicationAuthorizationServiceOrderRequest): Promise<RenewApplicationAuthorizationServiceOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenewApplicationAuthorizationServiceOrderHeaders({ });
    return await this.renewApplicationAuthorizationServiceOrderWithOptions(request, headers, runtime);
  }

  async renewTenantOrderWithOptions(request: RenewTenantOrderRequest, headers: RenewTenantOrderHeaders, runtime: $Util.RuntimeOptions): Promise<RenewTenantOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

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
      action: "RenewTenantOrder",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/tenants/reorder`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RenewTenantOrderResponse>(await this.execute(params, req, runtime), new RenewTenantOrderResponse({}));
  }

  async renewTenantOrder(request: RenewTenantOrderRequest): Promise<RenewTenantOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenewTenantOrderHeaders({ });
    return await this.renewTenantOrderWithOptions(request, headers, runtime);
  }

  async saveFormDataWithOptions(request: SaveFormDataRequest, headers: SaveFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "SaveFormData",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveFormDataResponse>(await this.execute(params, req, runtime), new SaveFormDataResponse({}));
  }

  async saveFormData(request: SaveFormDataRequest): Promise<SaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormDataHeaders({ });
    return await this.saveFormDataWithOptions(request, headers, runtime);
  }

  async saveFormRemarkWithOptions(request: SaveFormRemarkRequest, headers: SaveFormRemarkHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormRemarkResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.atUserId)) {
      body["atUserId"] = request.atUserId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      body["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.replyId)) {
      body["replyId"] = request.replyId;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "SaveFormRemark",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/remarks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveFormRemarkResponse>(await this.execute(params, req, runtime), new SaveFormRemarkResponse({}));
  }

  async saveFormRemark(request: SaveFormRemarkRequest): Promise<SaveFormRemarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormRemarkHeaders({ });
    return await this.saveFormRemarkWithOptions(request, headers, runtime);
  }

  async savePrintTplDetailInfoWithOptions(request: SavePrintTplDetailInfoRequest, headers: SavePrintTplDetailInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SavePrintTplDetailInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.fileNameConfig)) {
      body["fileNameConfig"] = request.fileNameConfig;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.formVersion)) {
      body["formVersion"] = request.formVersion;
    }

    if (!Util.isUnset(request.setting)) {
      body["setting"] = request.setting;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.vm)) {
      body["vm"] = request.vm;
    }

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
      action: "SavePrintTplDetailInfo",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/printTemplates/printTplDetailInfos`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SavePrintTplDetailInfoResponse>(await this.execute(params, req, runtime), new SavePrintTplDetailInfoResponse({}));
  }

  async savePrintTplDetailInfo(request: SavePrintTplDetailInfoRequest): Promise<SavePrintTplDetailInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SavePrintTplDetailInfoHeaders({ });
    return await this.savePrintTplDetailInfoWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "SearchActivationCode",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/activationCode/information`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<SearchActivationCodeResponse>(await this.execute(params, req, runtime), new SearchActivationCodeResponse({}));
  }

  async searchActivationCode(request: SearchActivationCodeRequest): Promise<SearchActivationCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchActivationCodeHeaders({ });
    return await this.searchActivationCodeWithOptions(request, headers, runtime);
  }

  async searchEmployeeFieldValuesWithOptions(request: SearchEmployeeFieldValuesRequest, headers: SearchEmployeeFieldValuesHeaders, runtime: $Util.RuntimeOptions): Promise<SearchEmployeeFieldValuesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.targetFieldJson)) {
      body["targetFieldJson"] = request.targetFieldJson;
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
      action: "SearchEmployeeFieldValues",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/employeeFields`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchEmployeeFieldValuesResponse>(await this.execute(params, req, runtime), new SearchEmployeeFieldValuesResponse({}));
  }

  async searchEmployeeFieldValues(request: SearchEmployeeFieldValuesRequest): Promise<SearchEmployeeFieldValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchEmployeeFieldValuesHeaders({ });
    return await this.searchEmployeeFieldValuesWithOptions(request, headers, runtime);
  }

  async searchFormDataIdListWithOptions(appType: string, formUuid: string, request: SearchFormDataIdListRequest, headers: SearchFormDataIdListHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDataIdListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SearchFormDataIdList",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/ids/${appType}/${formUuid}`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchFormDataIdListResponse>(await this.execute(params, req, runtime), new SearchFormDataIdListResponse({}));
  }

  async searchFormDataIdList(appType: string, formUuid: string, request: SearchFormDataIdListRequest): Promise<SearchFormDataIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataIdListHeaders({ });
    return await this.searchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
  }

  async searchFormDataRemovalTableDataWithOptions(request: SearchFormDataRemovalTableDataRequest, headers: SearchFormDataRemovalTableDataHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDataRemovalTableDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.orderConfigJson)) {
      body["orderConfigJson"] = request.orderConfigJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "SearchFormDataRemovalTableData",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchFormDataRemovalTableDataResponse>(await this.execute(params, req, runtime), new SearchFormDataRemovalTableDataResponse({}));
  }

  async searchFormDataRemovalTableData(request: SearchFormDataRemovalTableDataRequest): Promise<SearchFormDataRemovalTableDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataRemovalTableDataHeaders({ });
    return await this.searchFormDataRemovalTableDataWithOptions(request, headers, runtime);
  }

  async searchFormDataSecondGenerationWithOptions(request: SearchFormDataSecondGenerationRequest, headers: SearchFormDataSecondGenerationHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDataSecondGenerationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.orderConfigJson)) {
      body["orderConfigJson"] = request.orderConfigJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchCondition)) {
      body["searchCondition"] = request.searchCondition;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "SearchFormDataSecondGeneration",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/advances/queryAll`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchFormDataSecondGenerationResponse>(await this.execute(params, req, runtime), new SearchFormDataSecondGenerationResponse({}));
  }

  async searchFormDataSecondGeneration(request: SearchFormDataSecondGenerationRequest): Promise<SearchFormDataSecondGenerationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataSecondGenerationHeaders({ });
    return await this.searchFormDataSecondGenerationWithOptions(request, headers, runtime);
  }

  async searchFormDataSecondGenerationNoTableFieldWithOptions(request: SearchFormDataSecondGenerationNoTableFieldRequest, headers: SearchFormDataSecondGenerationNoTableFieldHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDataSecondGenerationNoTableFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.orderConfigJson)) {
      body["orderConfigJson"] = request.orderConfigJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchCondition)) {
      body["searchCondition"] = request.searchCondition;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "SearchFormDataSecondGenerationNoTableField",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/advances/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchFormDataSecondGenerationNoTableFieldResponse>(await this.execute(params, req, runtime), new SearchFormDataSecondGenerationNoTableFieldResponse({}));
  }

  async searchFormDataSecondGenerationNoTableField(request: SearchFormDataSecondGenerationNoTableFieldRequest): Promise<SearchFormDataSecondGenerationNoTableFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataSecondGenerationNoTableFieldHeaders({ });
    return await this.searchFormDataSecondGenerationNoTableFieldWithOptions(request, headers, runtime);
  }

  async searchFormDatasWithOptions(request: SearchFormDatasRequest, headers: SearchFormDatasHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDatasResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.dynamicOrder)) {
      body["dynamicOrder"] = request.dynamicOrder;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "SearchFormDatas",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchFormDatasResponse>(await this.execute(params, req, runtime), new SearchFormDatasResponse({}));
  }

  async searchFormDatas(request: SearchFormDatasRequest): Promise<SearchFormDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDatasHeaders({ });
    return await this.searchFormDatasWithOptions(request, headers, runtime);
  }

  async startInstanceWithOptions(request: StartInstanceRequest, headers: StartInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<StartInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.departmentId)) {
      body["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "StartInstance",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instances/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StartInstanceResponse>(await this.execute(params, req, runtime), new StartInstanceResponse({}));
  }

  async startInstance(request: StartInstanceRequest): Promise<StartInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartInstanceHeaders({ });
    return await this.startInstanceWithOptions(request, headers, runtime);
  }

  async terminateCloudAuthorizationWithOptions(request: TerminateCloudAuthorizationRequest, headers: TerminateCloudAuthorizationHeaders, runtime: $Util.RuntimeOptions): Promise<TerminateCloudAuthorizationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

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
      action: "TerminateCloudAuthorization",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/cloudAuthorizations/terminate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<TerminateCloudAuthorizationResponse>(await this.execute(params, req, runtime), new TerminateCloudAuthorizationResponse({}));
  }

  async terminateCloudAuthorization(request: TerminateCloudAuthorizationRequest): Promise<TerminateCloudAuthorizationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateCloudAuthorizationHeaders({ });
    return await this.terminateCloudAuthorizationWithOptions(request, headers, runtime);
  }

  async terminateInstanceWithOptions(request: TerminateInstanceRequest, headers: TerminateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<TerminateInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

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
      action: "TerminateInstance",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instances/terminate`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<TerminateInstanceResponse>(await this.execute(params, req, runtime), new TerminateInstanceResponse({}));
  }

  async terminateInstance(request: TerminateInstanceRequest): Promise<TerminateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateInstanceHeaders({ });
    return await this.terminateInstanceWithOptions(request, headers, runtime);
  }

  async updateCloudAccountInformationWithOptions(request: UpdateCloudAccountInformationRequest, headers: UpdateCloudAccountInformationHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCloudAccountInformationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
    }

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
      action: "UpdateCloudAccountInformation",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/cloudAccountInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateCloudAccountInformationResponse>(await this.execute(params, req, runtime), new UpdateCloudAccountInformationResponse({}));
  }

  async updateCloudAccountInformation(request: UpdateCloudAccountInformationRequest): Promise<UpdateCloudAccountInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCloudAccountInformationHeaders({ });
    return await this.updateCloudAccountInformationWithOptions(request, headers, runtime);
  }

  async updateFormDataWithOptions(request: UpdateFormDataRequest, headers: UpdateFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      body["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
    }

    if (!Util.isUnset(request.useLatestVersion)) {
      body["useLatestVersion"] = request.useLatestVersion;
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
      action: "UpdateFormData",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateFormDataResponse>(await this.execute(params, req, runtime), new UpdateFormDataResponse({}));
  }

  async updateFormData(request: UpdateFormDataRequest): Promise<UpdateFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFormDataHeaders({ });
    return await this.updateFormDataWithOptions(request, headers, runtime);
  }

  async updateInstanceWithOptions(request: UpdateInstanceRequest, headers: UpdateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
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
      action: "UpdateInstance",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateInstanceResponse>(await this.execute(params, req, runtime), new UpdateInstanceResponse({}));
  }

  async updateInstance(request: UpdateInstanceRequest): Promise<UpdateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceHeaders({ });
    return await this.updateInstanceWithOptions(request, headers, runtime);
  }

  async updateStatusWithOptions(request: UpdateStatusRequest, headers: UpdateStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.errorLines)) {
      body["errorLines"] = request.errorLines;
    }

    if (!Util.isUnset(request.importSequence)) {
      body["importSequence"] = request.importSequence;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
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
      action: "UpdateStatus",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/forms/status`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateStatusResponse>(await this.execute(params, req, runtime), new UpdateStatusResponse({}));
  }

  async updateStatus(request: UpdateStatusRequest): Promise<UpdateStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStatusHeaders({ });
    return await this.updateStatusWithOptions(request, headers, runtime);
  }

  async upgradeTenantInformationWithOptions(request: UpgradeTenantInformationRequest, headers: UpgradeTenantInformationHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeTenantInformationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
    }

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
      action: "UpgradeTenantInformation",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/tenantInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpgradeTenantInformationResponse>(await this.execute(params, req, runtime), new UpgradeTenantInformationResponse({}));
  }

  async upgradeTenantInformation(request: UpgradeTenantInformationRequest): Promise<UpgradeTenantInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeTenantInformationHeaders({ });
    return await this.upgradeTenantInformationWithOptions(request, headers, runtime);
  }

  async validateApplicationAuthorizationOrderWithOptions(instanceId: string, request: ValidateApplicationAuthorizationOrderRequest, headers: ValidateApplicationAuthorizationOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateApplicationAuthorizationOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      query["callerUnionId"] = request.callerUnionId;
    }

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
      action: "ValidateApplicationAuthorizationOrder",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applicationOrderUpdateAuthorizations/${instanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ValidateApplicationAuthorizationOrderResponse>(await this.execute(params, req, runtime), new ValidateApplicationAuthorizationOrderResponse({}));
  }

  async validateApplicationAuthorizationOrder(instanceId: string, request: ValidateApplicationAuthorizationOrderRequest): Promise<ValidateApplicationAuthorizationOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationAuthorizationOrderHeaders({ });
    return await this.validateApplicationAuthorizationOrderWithOptions(instanceId, request, headers, runtime);
  }

  async validateApplicationAuthorizationServiceOrderWithOptions(callerUid: string, request: ValidateApplicationAuthorizationServiceOrderRequest, headers: ValidateApplicationAuthorizationServiceOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateApplicationAuthorizationServiceOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

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
      action: "ValidateApplicationAuthorizationServiceOrder",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/${callerUid}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ValidateApplicationAuthorizationServiceOrderResponse>(await this.execute(params, req, runtime), new ValidateApplicationAuthorizationServiceOrderResponse({}));
  }

  async validateApplicationAuthorizationServiceOrder(callerUid: string, request: ValidateApplicationAuthorizationServiceOrderRequest): Promise<ValidateApplicationAuthorizationServiceOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationAuthorizationServiceOrderHeaders({ });
    return await this.validateApplicationAuthorizationServiceOrderWithOptions(callerUid, request, headers, runtime);
  }

  async validateApplicationServiceOrderUpgradeWithOptions(callerUnionid: string, request: ValidateApplicationServiceOrderUpgradeRequest, headers: ValidateApplicationServiceOrderUpgradeHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateApplicationServiceOrderUpgradeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

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
      action: "ValidateApplicationServiceOrderUpgrade",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/applications/orderValidations/${callerUnionid}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ValidateApplicationServiceOrderUpgradeResponse>(await this.execute(params, req, runtime), new ValidateApplicationServiceOrderUpgradeResponse({}));
  }

  async validateApplicationServiceOrderUpgrade(callerUnionid: string, request: ValidateApplicationServiceOrderUpgradeRequest): Promise<ValidateApplicationServiceOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationServiceOrderUpgradeHeaders({ });
    return await this.validateApplicationServiceOrderUpgradeWithOptions(callerUnionid, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ValidateOrderBuy",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/orderBuy/validate`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ValidateOrderBuyResponse>(await this.execute(params, req, runtime), new ValidateOrderBuyResponse({}));
  }

  async validateOrderBuy(request: ValidateOrderBuyRequest): Promise<ValidateOrderBuyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderBuyHeaders({ });
    return await this.validateOrderBuyWithOptions(request, headers, runtime);
  }

  async validateOrderUpdateWithOptions(instanceId: string, request: ValidateOrderUpdateRequest, headers: ValidateOrderUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderUpdateResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ValidateOrderUpdate",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/orders/renewalReviews/${instanceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ValidateOrderUpdateResponse>(await this.execute(params, req, runtime), new ValidateOrderUpdateResponse({}));
  }

  async validateOrderUpdate(instanceId: string, request: ValidateOrderUpdateRequest): Promise<ValidateOrderUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpdateHeaders({ });
    return await this.validateOrderUpdateWithOptions(instanceId, request, headers, runtime);
  }

  async validateOrderUpgradeWithOptions(request: ValidateOrderUpgradeRequest, headers: ValidateOrderUpgradeHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderUpgradeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "ValidateOrderUpgrade",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/apps/orderUpgrade/validate`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<ValidateOrderUpgradeResponse>(await this.execute(params, req, runtime), new ValidateOrderUpgradeResponse({}));
  }

  async validateOrderUpgrade(request: ValidateOrderUpgradeRequest): Promise<ValidateOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpgradeHeaders({ });
    return await this.validateOrderUpgradeWithOptions(request, headers, runtime);
  }

}
