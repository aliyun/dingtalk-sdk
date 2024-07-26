// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @remarks
   * This parameter is required.
   */
  appKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  signTimestampStr?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  signature?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.aliwork.com/APP_xx/workbench
   */
  fullUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AppLoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * true
   */
  needFormInstanceValue?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchGetFormDataByIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * true
   */
  asynchronousExecution?: boolean;
  /**
   * @example
   * true
   */
  executeExpression?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * true
   */
  asynchronousExecution?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "{\"countrySelectField_l0c1cwiu\":[{\"value\":\"US\"}],\"addressField_l0c1cwiy\":{\"address\":\"111\",\"regionIds\":[460000,469027,469023401],\"regionText\":[{\"en_US\":\"hai+nan+sheng\",\"zh_CN\":\"海南省\"},{\"en_US\":\"cheng+mai+xian\",\"zh_CN\":\"澄迈县\"},{\"en_US\":\"guo+ying+hong+gang+nong+chang\",\"zh_CN\":\"国营红岗农场\"}]}}"
   */
  formDataJsonList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * true
   */
  keepRunningAfterException?: boolean;
  /**
   * @example
   * true
   */
  noExecuteExpression?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchSaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * true
   */
  asynchronousExecution?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * true
   */
  ignoreEmpty?: boolean;
  /**
   * @example
   * true
   */
  noExecuteExpression?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"countrySelectField_l0c1cwiu":[{"value":"US"}],"addressField_l0c1cwiy":{"address":"111","regionIds":[460000,469027,469023401],"regionText":[{"en_US":"hai+nan+sheng","zh_CN":"海南省"},{"en_US":"cheng+mai+xian","zh_CN":"澄迈县"},{"en_US":"guo+ying+hong+gang+nong+chang","zh_CN":"国营红岗农场"}]}}
   */
  updateFormDataJson?: string;
  /**
   * @example
   * false
   */
  useLatestFormSchemaVersion?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateFormDataByInstanceIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * true
   */
  asynchronousExecution?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * true
   */
  ignoreEmpty?: boolean;
  /**
   * @example
   * true
   */
  noExecuteExpression?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"FINST-ANSFSNNDS2212NSKLKKSFD":"{\"rateField_l0c1cwis\":3,\"countrySelectField_l0c1cwiu\":[{\"value\":\"US\"}]}"}
   */
  updateFormDataJsonMap?: { [key: string]: any };
  /**
   * @example
   * false
   */
  useLatestFormSchemaVersion?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateFormDataByInstanceMapResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 123
   */
  accountNumber?: string;
  /**
   * @example
   * 1234123423459
   */
  beginTimeGMT?: number;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * subscribe
   */
  chargeType?: string;
  /**
   * @example
   * subscribe
   */
  commerceType?: string;
  /**
   * @example
   * Business
   */
  commodityType?: string;
  /**
   * @example
   * 1023451234123
   */
  endTimeGMT?: number;
  /**
   * @example
   * 12
   */
  instanceId?: string;
  /**
   * @example
   * A发起的实例
   */
  instanceName?: string;
  /**
   * @example
   * yun-1234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BuyAuthorizationOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 123
   */
  accountNumber?: string;
  /**
   * @example
   * 1234567891234
   */
  beginTimeGMT?: number;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * subscribe
   */
  chargeType?: string;
  /**
   * @example
   * subscribe
   */
  commerceType?: string;
  /**
   * @example
   * Business
   */
  commodityType?: string;
  /**
   * @example
   * 1234567891234
   */
  endTimeGMT?: number;
  /**
   * @example
   * 12
   */
  instanceId?: string;
  /**
   * @example
   * A发起的实例
   */
  instanceName?: string;
  /**
   * @example
   * yun-1234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BuyFreshOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckCloudAccountStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"countrySelectField_l0c1cwiu":[{"value":"US"}]}
   */
  formDataJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * false
   */
  noExecuteExpression?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * [{"key":"currentNodeName","value":"当前审批节点名称","type":"TEXT","operator":"like","componentName":"TextField"}]。详情参考 https://www.yuque.com/yida/support/agb8im#F4S8e
   */
  searchCondition?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateOrUpdateFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33f6d221-17f8-42b7-836a-682b95a046c2
   */
  formInstanceId?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * helxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 202201061234
   */
  appId?: string;
  /**
   * @example
   * abc.com
   */
  customDomain?: string;
  /**
   * @example
   * RELEASE
   */
  deployStage?: string;
  /**
   * @example
   * assdfasdfWwd12212
   */
  gateWayAppKey?: string;
  /**
   * @example
   * fasdfsfasdf1212Sff
   */
  gateWayAppSecret?: string;
  /**
   * @example
   * 1111shanghai-aliyunapi.com
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeployFunctionCallbackResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备选值：agree/disagree
   */
  outResult?: string;
  /**
   * @example
   * OK
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * [{"taskId":"2267855699","formInstId":"4d226eb1-1f4e-4348-a9cc-616477c3daa6"},{"taskId":"2267855700","formInstId":"905a922e-da05-4ef9-ba1c-db9ad60bbe60"}]
   */
  taskInformationList?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  failNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  successNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExecuteBatchTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  data?: string;
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  serviceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExecuteCustomApiResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * 未知
   */
  formDataJson?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * y
   */
  noExecuteExpressions?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ●
   * agree
   * 
   * ●
   * disagree
   */
  outResult?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 确认同意
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxyyddd
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yida_pub_account
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * https://tianshu-vpc.oss-cn-sahnghai.aliyuncs.com
   */
  digitalSignUrl?: string;
  /**
   * @example
   * 未知
   */
  formDataJson?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * y
   */
  noExecuteExpressions?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AGREE
   */
  outResult?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 确认同意
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxyy
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12002575
   */
  taskId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExpireCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetActivationCodeByCallerUnionIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hello1234
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetActivityButtonListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetActivityListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
  keywords?: string;
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
   * 100
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllAuthCubesResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetApplicationAuthorizationServicePlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class GetAutoFlowLogDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAutoFlowLogDetailRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
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
   * 100
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  procInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B073AF673BEB044D59F8F612D65E1EA2
   */
  token?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      procInstanceId: 'procInstanceId',
      token: 'token',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      procInstanceId: 'string',
      token: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAutoFlowLogDetailResponseBody extends $tea.Model {
  data?: GetAutoFlowLogDetailResponseBodyData[];
  /**
   * @example
   * true
   */
  hasMoreData?: boolean;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
      data: { 'type': 'array', 'itemType': GetAutoFlowLogDetailResponseBodyData },
      hasMoreData: 'boolean',
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAutoFlowLogDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAutoFlowLogDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAutoFlowLogDetailResponseBody,
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
  /**
   * @example
   * ["APP_xxx","APP_xxx"]
   */
  appTypes?: string;
  /**
   * @example
   * 未知
   */
  createFromTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  createToTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  keyword?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * ["xx","xxx"]
   */
  processCodes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCorpAccomplishmentTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCorpLevelByAccountIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * ["APP_xxx","APP_xxx"]
   */
  appTypes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  corpId?: string;
  /**
   * @example
   * 未知
   */
  createFromTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  createToTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  keyword?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * ["xx","xxx"]
   */
  processCodes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  token?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCorpTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1160440651754805
   */
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
  /**
   * @example
   * {\"dbName\":\"yida_exclusive_pg_db\",\"exclusiveType\":\"DATABASE\",\"maxActive\":1600,\"minIdle\":160,\"password\":\"xxx\",\"sharding\":true,\"type\":\"POSTGRES\",\"url\":\"pgm-bp17c85t9363an74194040.pg.rds.aliyuncs.com:0000\",\"username\":\"yida_xxx\"}
   */
  config?: string;
  /**
   * @example
   * ding5d17e3add038d44535c2f4657eb6378f
   */
  corpId?: string;
  /**
   * @example
   * 2022-02-23T14:46Z
   */
  createTimeGMT?: string;
  /**
   * @example
   * 092824253426603595
   */
  creator?: string;
  /**
   * @example
   * ding5d17e3add038d44535c2f4657eb6378f
   */
  exclusive?: string;
  /**
   * @example
   * 600001
   */
  id?: string;
  /**
   * @example
   * 2023-08-15T10:37Z
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * 5014533041684350
   */
  modifier?: string;
  /**
   * @example
   * DATABASE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDbConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-J7966ZA1XN940B88DYNMNABXUXNU3F3FMLJ8L5
   */
  formUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FO866D71GM94CE3KBMAFL4Q6WDG93MG6MLJ8L64
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5014533041684350
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFieldDefByUuidResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  userId?: string;
  /**
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFormComponentDefinitionListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * hexxx
   */
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
  /**
   * @example
   * {       "numberField_jcr0069o": 1,       "multiSelectField_jcr0069s": [         "选项三",         "选项二"       ],       "textareaField_jcr0069n": "duohang",       "employeeField_jcr0069x": [         "xxxx"       ],       "departmentField_jcr0069z": "xxxx",       "cascadeDate_jcr0069u": [         "1514736000000",         "1517328000000"       ],       "cascadeSelectField_jcr006a0": [         "part",         "part_b"       ],       "tableField_jcr006a1": [         {           "departmentField_jcr006ad": "xxxx",           "cascadeDate_jcr006aa": [             "1514736000000",             "1517328000000"           ],           "selectField_jcr006a6": "选项三",           "citySelectField_jcr006ac": [             "天津",             "天津市",             "河东区"           ],           "radioField_jcr006a5": "选项二",           "employeeField_jcr006ab": [             "xxxxxx",             "yyyyyy"           ],           "dateField_jcr006a9": 1517328000000,           "textField_jcr006a2": "明细下单行",           "textareaField_jcr006a3": "明细下多行",           "cascadeSelectField_jcr006ae": [             "product",             "product_a"           ],           "numberField_jcr006a4": 2,           "checkboxField_jcr006a7": [             "选项一",             "选项三",             "选项二"           ],           "multiSelectField_jcr006a8": [             "选项一",             "选项三",             "选项二"           ]         }       ],       "selectField_jcr0069q": "选项一",       "citySelectField_jcr0069y": [         "北京",         "北京市",         "东城区"       ],       "checkboxField_jcr0069r": [         "选项三",         "选项二"       ],       "textField_jcr0069m": "danhang",       "radioField_jcr0069p": "选项一",       "dateField_jcr0069t": 1516636800000     }
   */
  formData?: { [key: string]: any };
  /**
   * @example
   * 33f6d221-17f8-42b7-836a-682b95a046c2
   */
  formInstId?: string;
  /**
   * @example
   * 2018-01-24 11:22:01
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFormDataByIDResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * receipt,process
   */
  formTypes?: string;
  pageNumber?: number;
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FO866D71GM94CE3KBMAFL4Q6WDG93MG6MLJ8L64
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5014533041684350
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFormListInAppResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxyy
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInstanceByIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * agree
   */
  approvedResult?: string;
  /**
   * @example
   * 2018-01-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  createToTimeGMT?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
   */
  formUuid?: string;
  /**
   * @example
   * RUNNING
   */
  instanceStatus?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 2018-01-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  modifiedToTimeGMT?: string;
  /**
   * @example
   * ding123
   */
  originatorId?: string;
  /**
   * @example
   * {"text_field":"123"}
   */
  searchFieldJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @example
   * 2199132092
   */
  taskId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding123
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInstanceIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * agree
   */
  approvedResult?: string;
  /**
   * @example
   * 2018-01-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  createToTimeGMT?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
   */
  formUuid?: string;
  /**
   * @example
   * RUNNING
   */
  instanceStatus?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 2018-01-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  modifiedToTimeGMT?: string;
  /**
   * @example
   * 例如按照创建时间升序再按照文本组件值升序排序则填{\"gmt_create\":\"+\",\"textField_1234\":\"+\"} ，详情参考 https://www.yuque.com/yida/support/agb8im#CQro8
   */
  orderConfigJson?: string;
  /**
   * @example
   * manager123
   */
  originatorId?: string;
  /**
   * @example
   * 模式1：根据组件值模糊匹配，示例：{"textField_jcr0069m":"danhang","selectField_jcr0069q":"K"}     模式2: 采用数据管理的查询过滤条件，匹配功能更强大，示例：[{"key":"currentNodeName","value":"步凡","type":"TEXT","operator":"like","componentName":"TextField”}]，详情参考  https://www.yuque.com/yida/support/agb8im#F4S8e
   */
  searchFieldJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @example
   * 2199132092
   */
  taskId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530,d230233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceIds?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxyy
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInstancesByIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * ["APP_xxx","APP_xxx"]
   */
  appTypes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  corpId?: string;
  /**
   * @example
   * 未知
   */
  createFromTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  createToTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  keyword?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * ["xx","xxx"]
   */
  processCodes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMeCorpSubmissionResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * ["APP_xxx","APP_xxx"]
   */
  appTypes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  corpId?: string;
  /**
   * @example
   * 未知
   */
  createFromTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  createToTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  instanceCreateFromTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  instanceCreateToTimeGMT?: number;
  /**
   * @example
   * 未知
   */
  keyword?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * ["xx","xxx"]
   */
  processCodes?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetNotifyMeResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.aliwork.com/fileHandle?appType=APP_VN7I6HVKUTXES7XX4OI8&fileName=2a4103a6-44d5-4114-990d-4147a2d53811.xlsx&instId=&type=download
   */
  fileUrl?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @example
   * 60000
   */
  timeout?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOpenUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxyy
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOperationRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  nameLike?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPrintAppInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XABJJSJ
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-XABJJSJ
   */
  formUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abfefw
   */
  userId?: string;
  /**
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPrintDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProcessDefinitionResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xaff,afdfaf,fdsfasdf
   */
  processInstanceIdList?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRunningTaskListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRunningTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  namespace?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSaleUserInfoByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_Q7D2TFJZWNMDS145Z7DP
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378f
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM_MT866EA17HGCUHIV7GROU72YO499257KRS0KLB
   */
  cubeCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378f
   */
  cubeTenantId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * U66663B1LLGCVCVPAF76H6955VYG2408RS0KL0
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1160440651754805
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSimpleCubeModelListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * 1234567891234
   */
  createFromTimeGMT?: number;
  /**
   * @example
   * 1234567891234
   */
  createToTimeGMT?: number;
  keyword?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * ["xx","xxx"]
   */
  processCodes?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTaskCopiesResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * createdByMe
   */
  appFilter?: string;
  /**
   * @example
   * 步凡的测试应用
   */
  appNameSearchKeyword?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
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
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B073AF673BEB044D59F8F612D65E1EA2
   */
  token?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListApplicationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListApplicationAuthorizationServiceApplicationInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  plugInformation?: ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation[];
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListApplicationAuthorizationServiceConnectorInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListApplicationInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * accessKey
   */
  accessKey?: string;
  /**
   * @example
   * callerUid
   */
  callerUid?: string;
  /**
   * @example
   * currentPage
   */
  pageNumber?: number;
  /**
   * @example
   * pageSize
   */
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
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  pluginInfos?: ListConnectorInformationResponseBodyPluginInfos[];
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListConnectorInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * FORM-INST-123
   */
  formInstanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * {"FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0":[{"creator":"manager9358","replyUserId":null,"images":"[]","formInstId":"FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0","replyId":null,"files":"[]","id":3261500001,"gmtCreate":1649387753000,"class":"com.alibaba.work.tianshu.api.model.form.RemarkVO","atUserId":null,"content":"评论1"}],"FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6":[{"creator":"manager9358","replyUserId":null,"images":"[]","formInstId":"FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6","replyId":null,"files":"[]","id":3261500003,"gmtCreate":1649387988000,"class":"com.alibaba.work.tianshu.api.model.form.RemarkVO","atUserId":null,"content":"评论4"}]}
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListFormRemarksResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  formType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListNavigationByFormTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * FORM-INST-123
   */
  formInstanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager9358
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0":[{"currentText":null,"componentType":null,"gmtModified":"2022-04-08 11:15:34","preText":null,"operationType":"CREATE","componentName":"","operator":{"userInfo":null,"tbWang":null,"depDesc":null,"displayName":"娄修俊","mastedataDeptments":null,"orderNum":null,"displayEnName":null,"userId":null,"personalPhoto":null,"status":null},"fieldId":null}]}
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListOperationLogsResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
   */
  formUuid?: string;
  /**
   * @example
   * 10
   */
  pageNumber?: number;
  /**
   * @example
   * 50
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tableField_ksyaujq1
   */
  tableFieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListTableDataByFormInstanceIdTableIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * zs123
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

export class LoginCodeGenResponseBody extends $tea.Model {
  /**
   * @example
   * cdxxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: NotifyAuthorizationResultResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class PageAutoFlowLogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageAutoFlowLogRequest extends $tea.Model {
  /**
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
  /**
   * @example
   * 2021-01-01
   */
  endTimeGMT?: number;
  /**
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
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
   * 100
   */
  pageSize?: number;
  processCode?: string;
  startTimeGMT?: number;
  /**
   * @example
   * running
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B073AF673BEB044D59F8F612D65E1EA2
   */
  token?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      corpId: 'corpId',
      endTimeGMT: 'endTimeGMT',
      formUuid: 'formUuid',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      processCode: 'processCode',
      startTimeGMT: 'startTimeGMT',
      status: 'status',
      token: 'token',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      corpId: 'string',
      endTimeGMT: 'number',
      formUuid: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      processCode: 'string',
      startTimeGMT: 'number',
      status: 'number',
      token: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageAutoFlowLogResponseBody extends $tea.Model {
  data?: PageAutoFlowLogResponseBodyData[];
  /**
   * @example
   * true
   */
  hasMoreData?: boolean;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
      data: { 'type': 'array', 'itemType': PageAutoFlowLogResponseBodyData },
      hasMoreData: 'boolean',
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageAutoFlowLogResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PageAutoFlowLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PageAutoFlowLogResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appKey?: string;
  formTypeList?: string[];
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pageIndex?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * david123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PageFormBaseInfosResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class PreviewPublishedProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreviewPublishedProcessRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * 18295
   */
  departmentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"textField_jcpm6agt": "单行","employeeField_jcos0sar": ["workno"]}
   */
  formDataJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB
   */
  formUuid?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4
   */
  processCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1731234567
   */
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

export class PreviewPublishedProcessResponseBody extends $tea.Model {
  result?: PreviewPublishedProcessResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': PreviewPublishedProcessResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreviewPublishedProcessResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PreviewPublishedProcessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PreviewPublishedProcessResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * HTTP
   */
  hookType?: string;
  /**
   * @example
   * INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1L0
   */
  hookUuid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FINST-NJS33HHSLFNH533HHOFN
   */
  instanceId?: string;
  /**
   * @example
   * 2022-03-28
   */
  invokeAfterDateGMT?: string;
  /**
   * @example
   * 2022-03-29
   */
  invokeBeforeDateGMT?: string;
  /**
   * @example
   * 可选值：SUCCESS、FAIL、FINAL_SUCCESS、ERROR
   */
  invokeStatus?: string;
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
   * www.aliwork.com/query/
   */
  requestUrl?: string;
  /**
   * @example
   * INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1LI
   */
  sourceUuid?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryServiceRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * y
   */
  byManager?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  nowActionExecutorId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * task-123
   */
  taskId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RefundCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * acc-1732245789
   */
  activeCode?: string;
  /**
   * @example
   * ding123
   */
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
  /**
   * @example
   * 12
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

export class RegisterAccountsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RegisterAccountsResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReleaseCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * accessKey
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveTenantResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @example
   * 123789
   */
  fileSize?: number;
  language?: string;
  /**
   * @example
   * dingtalk
   */
  namespace?: string;
  /**
   * @example
   * https://oss/com/a/b.pdf
   */
  ossUrl?: string;
  /**
   * @example
   * seq-xxx
   */
  sequenceId?: string;
  /**
   * @example
   * 宜搭
   */
  source?: string;
  /**
   * @example
   * running
   */
  status?: string;
  systemToken?: string;
  /**
   * @example
   * GMT
   */
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * 1234567891234
   */
  endTimeGMT?: number;
  /**
   * @example
   * 12
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RenewApplicationAuthorizationServiceOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * 1234567891234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RenewTenantOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"textField_jcpm6agt": "单行","employeeField_jcos0sar": ["workno"]}
   */
  formDataJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB
   */
  formUuid?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * FINST-XIA66E71N7HSLK7H4KOZ388EEOP03A46YAYRK1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * 多个工号,用英文逗号分隔
   */
  atUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33f6d221-17f8-42b7-836a-682b95a046c2
   */
  formInstanceId?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 12
   */
  replyId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * 123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveFormRemarkResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  appType?: string;
  description?: string;
  fileNameConfig?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  formUuid?: string;
  /**
   * @example
   * 123456
   */
  formVersion?: number;
  /**
   * @example
   * 123456
   */
  setting?: string;
  /**
   * @example
   * 123456
   */
  templateId?: number;
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  userId?: string;
  /**
   * @example
   * 123456
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SavePrintTplDetailInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchActivationCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchEmployeeFieldValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * 2018-01-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  createToTimeGMT?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 2018-01-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  modifiedToTimeGMT?: string;
  /**
   * @example
   * dign1234
   */
  originatorId?: string;
  searchFieldJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding1234
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchFormDataIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * 2021-05-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2021-05-01
   */
  createToTimeGMT?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2021-09-10
   */
  modifiedToTimeGMT?: string;
  /**
   * @example
   * 示例: 按照创建时间和文本组件值做升序排序则填写 {\"gmt_create\":\"+\",\"textField_1234\":\"+\"}。详情参考 https://www.yuque.com/yida/support/agb8im#CQro8
   */
  orderConfigJson?: string;
  /**
   * @example
   * manager123
   */
  originatorId?: string;
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
   * 支持2种检索规则{"numberField_l0c1cwiu":1}或者[{"key":"currentNodeName","value":"步凡","type":"TEXT","operator":"like","componentName":"TextField"}], 前一种规则仅仅做模糊匹配无法设置精确匹配, 第二种可以设置精确匹配条件。详情参考 https://www.yuque.com/yida/support/agb8im#F4S8e
   */
  searchFieldJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * true
   */
  hasMoreData?: boolean;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchFormDataRemovalTableDataResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * 2021-05-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2021-05-01
   */
  createToTimeGMT?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2021-09-10
   */
  modifiedToTimeGMT?: string;
  /**
   * @example
   * 例如按照创建时间升序按照文本组件值升序排序则填{\"gmt_create\":\"+\",\"textField_1234\":\"+\"}。详情参考 https://www.yuque.com/yida/support/agb8im#CQro8
   */
  orderConfigJson?: string;
  /**
   * @example
   * manager123
   */
  originatorId?: string;
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
   * [{"key":"currentNodeName","value":"当前审批节点名称","type":"TEXT","operator":"like","componentName":"TextField"}]。详情参考 https://www.yuque.com/yida/support/agb8im#F4S8e
   */
  searchCondition?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchFormDataSecondGenerationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * 2021-05-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2021-05-01
   */
  createToTimeGMT?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2021-09-10
   */
  modifiedToTimeGMT?: string;
  /**
   * @example
   * 例如按照创建时间升序再按照文本组件值升序排序则填{\"gmt_create\":\"+\",\"textField_1234\":\"+\"}。详情参考 https://www.yuque.com/yida/support/agb8im#CQro8
   */
  orderConfigJson?: string;
  /**
   * @example
   * manager123
   */
  originatorId?: string;
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
   * [{"key":"currentNodeName","value":"当前审批节点名称","type":"TEXT","operator":"like","componentName":"TextField"}]。详情参考 https://www.yuque.com/yida/support/agb8im#F4S8e
   */
  searchCondition?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchFormDataSecondGenerationNoTableFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * 2018-01-01
   */
  createFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  createToTimeGMT?: string;
  /**
   * @example
   * 1
   */
  currentPage?: number;
  /**
   * @example
   * {"numberField_1ac":"+"}, 表示按照字段numberField_1ac升序排列
   */
  dynamicOrder?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
   */
  formUuid?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * 2018-01-01
   */
  modifiedFromTimeGMT?: string;
  /**
   * @example
   * 2018-02-01
   */
  modifiedToTimeGMT?: string;
  originatorId?: string;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * {"textField_jcr0069m":"danhang","textareaField_jcr0069n":"duohang","numberField_jcr0069o":["1","10"],"radioField_jcr0069p":"选项一","selectField_jcr0069q":"选项一","checkboxField_jcr0069r":["选项二"],"multiSelectField_jcr0069s":["选项二","选项三"],"dateField_jcr0069t":[1514736000000,1517414399000],"cascadeDate_jcr0069u":[[1514736000000,1517414399000],[1514736000000,1517414399000]],"employeeField_jcr0069x":["xxxxx"],"citySelectField_jcr0069y":["110000","110100","110101"],"departmentField_jcr0069z":1123456,"cascadeSelectField_jcr006a0":["part","part_b"],"tableField_jcr006a1":"明细数据"}
   */
  searchFieldJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 173112212211
   */
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
  /**
   * @example
   * 1
   */
  currentPage?: number;
  data?: SearchFormDatasResponseBodyData[];
  /**
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchFormDatasResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * 18295
   */
  departmentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"textField_jcpm6agt": "单行","employeeField_jcos0sar": ["workno"]}
   */
  formDataJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB
   */
  formUuid?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @example
   * TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4
   */
  processCode?: string;
  /**
   * @example
   * [{ 	"key": "__optionalApproval_node_ocltdztr2b1", 	"value": ["5014533041684350"] }, { 	"key": "__optionalApproval_node_ocltdztr2b3", 	"value": ["5014533041684350", "01536610064226180419"] }, { 	"key": "__optionalApproval_node_oclte07cwn1", 	"value": ["01432910392321237660"] }]
   */
  processData?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1731234567
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      departmentId: 'departmentId',
      formDataJson: 'formDataJson',
      formUuid: 'formUuid',
      language: 'language',
      processCode: 'processCode',
      processData: 'processData',
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
      processData: 'string',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StartInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * 12
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TerminateCloudAuthorizationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 123
   */
  accountNumber?: string;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * Business
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateCloudAccountInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33f6d221-17f8-42b7-836a-682b95a046c2
   */
  formInstanceId?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hexxx
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"textField_jcr0069m":"danhang","textareaField_jcr0069n":"duohang","numberField_jcr0069o":1,"radioField_jcr0069p":"选项一","selectField_jcr0069q":"选项一","checkboxField_jcr0069r":["选项二","选项三"],"multiSelectField_jcr0069s":["选项二","选项三"],"dateField_jcr0069t":1516636800000,"cascadeDate_jcr0069u":["1514736000000","1517328000000"],"employeeField_jcr0069x":["xxxxx"],"citySelectField_jcr0069y":["110000","110100","110101"],"departmentField_jcr0069z":1123456,"cascadeSelectField_jcr006a0":["part","part_b"],{"attachmentField_jna1lvyb":[{"downloadUrl":"https://www.aliwork.com/fileHandle?appType=default_tianshu_app&fileName=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&instId=&type=download","name":"test.txt","previewUrl":"https://www.aliwork.com/inst/preview?appType=default_tianshu_app&fileName=test.txt&fileSize=4&downloadUrl=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt","url":"https://www.aliwork.com/fileHandle?appType=default_tianshu_app&fileName=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&instId=&type=download","ext":"txt"}]},"tableField_jcr006a1":[{"cascadeDate_jcr006aa":["1514736000000","1517328000000"],"cascadeSelectField_jcr006ae":["product","product_a"],"checkboxField_jcr006a7":["选项一","选项二","选项三"],"citySelectField_jcr006ac":["120000","120100","120102"],"dateField_jcr006a9":1517328000000,"departmentField_jcr006ad":1123456,"employeeField_jcr006ab":["yyyyy","xxxxx"],"multiSelectField_jcr006a8":["选项一","选项二","选项三"],"numberField_jcr006a4":2,"radioField_jcr006a5":"选项二","selectField_jcr006a6":"选项三","textField_jcr006a2":"明细下单行","textareaField_jcr006a3":"明细下多行"}]}
   */
  updateFormDataJson?: string;
  /**
   * @example
   * false
   */
  useLatestVersion?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * APP_PBKT0MFBEBTDO8T7SLVP
   */
  appType?: string;
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  processInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hello1234
   */
  systemToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
  updateFormDataJson?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 未知
   */
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
  /**
   * @example
   * hexaaaa
   */
  accessKey?: string;
  /**
   * @example
   * 123
   */
  accountNumber?: string;
  /**
   * @example
   * 44234122
   */
  callerUnionId?: string;
  /**
   * @example
   * Business
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpgradeTenantInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ValidateApplicationAuthorizationOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ValidateApplicationAuthorizationServiceOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * accessKey
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ValidateApplicationServiceOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ValidateOrderBuyResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ValidateOrderUpdateResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ValidateOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * ding173982232112232
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
      name: BatchGetFormDataByIdListResponseBodyResultModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResultOriginatorName extends $tea.Model {
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * ding173982232112232
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
      name: BatchGetFormDataByIdListResponseBodyResultOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetFormDataByIdListResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 2021-05-01
   */
  createTimeGMT?: string;
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  /**
   * @example
   * {"addressField_l0c1cwiy_id":"\"海南省/469027/国营红岗农场/111\"","associationFormField_l0c1hdz4_id":"\"[{\\\"formType\\\":\\\"receipt\\\",\\\"formUuid\\\":\\\"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\\\",\\\"instanceId\\\":\\\"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\\\",\\\"subTitle\\\":\\\"{\\\\\\\"type\\\\\\\":\\\\\\\"div\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":{\\\\\\\"type\\\\\\\":\\\\\\\"a\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":\\\\\\\"查看签名\\\\\\\",\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item-link\\\\\\\",\\\\\\\"style\\\\\\\":{\\\\\\\"cursor\\\\\\\":\\\\\\\"pointer\\\\\\\",\\\\\\\"color\\\\\\\":\\\\\\\"#0068ff\\\\\\\"}}},\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item\\\\\\\"}}\\\",\\\"appType\\\":\\\"APP_K6IGJJ6PFAARLPDSWKXQ\\\",\\\"title\\\":\\\"1\\\"}]\"","countrySelectField_l0c1cwiu_id":["PG"]}
   */
  formData?: { [key: string]: any };
  /**
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceId?: string;
  /**
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 12345
   */
  id?: number;
  /**
   * @example
   * 符合宜搭表单实例格式的json数据
   */
  instanceValue?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * manager123
   */
  modifier?: string;
  modifyUser?: BatchGetFormDataByIdListResponseBodyResultModifyUser;
  originator?: BatchGetFormDataByIdListResponseBodyResultOriginator;
  /**
   * @example
   * IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2
   */
  sequence?: string;
  /**
   * @example
   * YIDA909202202250027
   */
  serialNumber?: string;
  /**
   * @example
   * 李四发起的请购单
   */
  title?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * 同意
   */
  aliasInChinese?: string;
  /**
   * @example
   * agree
   */
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
  /**
   * @example
   * manager123
   */
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
  /**
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
  /**
   * @example
   * 开发部
   */
  departmentName?: string;
  /**
   * @example
   * 测试应用
   */
  name?: string;
  nickName?: string;
  realmId?: number;
  refererNamespaceCode?: string;
  /**
   * @example
   * 请购类型
   */
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
  /**
   * @example
   * all
   */
  authorizationType?: number;
  businessProcessCode?: string;
  categoriesFirst?: string;
  categoriesSecond?: string;
  /**
   * @example
   * 2021-05-01
   */
  createTimeGMT?: string;
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  cubeAuthType?: string;
  cubeCode?: string;
  cubeDataRange?: string;
  cubeDataRanges?: GetAllAuthCubesResponseBodyResultCubeDataRanges[];
  cubeSource?: string;
  dataCacheTimeConfiguration?: string;
  dataflowCode?: string;
  /**
   * @example
   * 步凡创建的宜搭应用
   */
  description?: string;
  domainCode?: string;
  enableCache?: boolean;
  /**
   * @example
   * 12345
   */
  id?: number;
  isNeedApplication?: string;
  isTrend?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * manager123
   */
  modifier?: string;
  /**
   * @example
   * 测试应用
   */
  name?: string;
  namespaceCode?: string;
  owner?: string;
  sharedDataSet?: boolean;
  tenantCorpId?: string;
  /**
   * @example
   * i18n
   */
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

export class GetAutoFlowLogDetailResponseBodyData extends $tea.Model {
  activityKey?: string;
  elapsedTimeGMT?: number;
  /**
   * @example
   * 2021-01-01
   */
  finishTimeGMT?: string;
  flag?: string;
  inputParams?: { [key: string]: any };
  /**
   * @example
   * 测试应用
   */
  name?: string;
  others?: string;
  outputParams?: { [key: string]: any };
  /**
   * @example
   * running
   */
  status?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      activityKey: 'activityKey',
      elapsedTimeGMT: 'elapsedTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      flag: 'flag',
      inputParams: 'inputParams',
      name: 'name',
      others: 'others',
      outputParams: 'outputParams',
      status: 'status',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityKey: 'string',
      elapsedTimeGMT: 'number',
      finishTimeGMT: 'string',
      flag: 'string',
      inputParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      others: 'string',
      outputParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      status: 'string',
      uuid: 'string',
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
  nameInEnglish?: string;
  /**
   * @example
   * i18n
   */
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
  /**
   * @example
   * 开发部
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
  nameInEnglish?: string;
  /**
   * @example
   * i18n
   */
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
  /**
   * @example
   * 开发部
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
  nameInEnglish?: string;
  /**
   * @example
   * i18n
   */
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
  /**
   * @example
   * 开发部
   */
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
  /**
   * @example
   * agree
   */
  approvedResult?: string;
  /**
   * @example
   * {"numberField_jcr0069o":1,"multiSelectField_jcr0069s":["选项三","选项二"],"textareaField_jcr0069n":"duohang","employeeField_jcr0069x":["xxxx"],"departmentField_jcr0069z":"信息xxx平台","cascadeDate_jcr0069u":["1514736000000","1517328000000"],"cascadeSelectField_jcr006a0":["part","part_b"],"tableField_jcr006a1":[{"departmentField_jcr006ad":"信息xxx","cascadeDate_jcr006aa":["1514736000000","1517328000000"],"selectField_jcr006a6":"选项三","citySelectField_jcr006ac":["天津","天津市","河东区"],"radioField_jcr006a5":"选项二","employeeField_jcr006ab":["yyyyy","xxxxxx"],"dateField_jcr006a9":1517328000000,"textField_jcr006a2":"明细下单行","textareaField_jcr006a3":"明细下多行","cascadeSelectField_jcr006ae":["product","product_a"],"numberField_jcr006a4":2,"checkboxField_jcr006a7":["选项一","选项三","选项二"],"multiSelectField_jcr006a8":["选项一","选项三","选项二"]}],"selectField_jcr0069q":"选项一","citySelectField_jcr0069y":["北京","北京市","东城区"],"checkboxField_jcr0069r":["选项三","选项二"],"textField_jcr0069m":"danhang","radioField_jcr0069p":"选项一","dateField_jcr0069t":1516636800000}
   */
  data?: { [key: string]: any };
  /**
   * @example
   * FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
   */
  formUuid?: string;
  /**
   * @example
   * RUNNING
   */
  instanceStatus?: string;
  originator?: GetInstancesByIdListResponseBodyResultOriginator;
  /**
   * @example
   * TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4
   */
  processCode?: string;
  /**
   * @example
   * f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
   */
  processInstanceId?: string;
  /**
   * @example
   * xxxx 发起的流程
   */
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
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  /**
   * @example
   * FORM_INST_12345
   */
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

export class GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList extends $tea.Model {
  /**
   * @example
   * 开发部成立于2000年
   */
  departmentDescription?: string;
  /**
   * @example
   * 测试应用
   */
  displayName?: string;
  /**
   * @example
   * ZhangSan
   */
  displayNameInEnglish?: string;
  /**
   * @example
   * o-YDJKINSSDLLND
   */
  orderNumber?: string;
  /**
   * @example
   * https://abc.com/a.png
   */
  personalPhoto?: string;
  /**
   * @example
   * running
   */
  status?: string;
  /**
   * @example
   * ding173982232112232
   */
  userId?: string;
  /**
   * @example
   * 张三
   */
  userInformation?: string;
  static names(): { [key: string]: string } {
    return {
      departmentDescription: 'departmentDescription',
      displayName: 'displayName',
      displayNameInEnglish: 'displayNameInEnglish',
      orderNumber: 'orderNumber',
      personalPhoto: 'personalPhoto',
      status: 'status',
      userId: 'userId',
      userInformation: 'userInformation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentDescription: 'string',
      displayName: 'string',
      displayNameInEnglish: 'string',
      orderNumber: 'string',
      personalPhoto: 'string',
      status: 'string',
      userId: 'string',
      userInformation: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponseBodyResultDomainList extends $tea.Model {
  /**
   * @example
   * return
   */
  action?: string;
  /**
   * @example
   * 2021-02-01
   */
  activeTimeGMT?: string;
  /**
   * @example
   * act-xxaanfaf
   */
  activityId?: string;
  /**
   * @example
   * https://oss.com/Signature.pdf
   */
  digitalSignature?: string;
  /**
   * @example
   * https://oss.com/a.pdf
   */
  files?: string;
  /**
   * @example
   * 同意
   */
  formatAction?: string;
  /**
   * @example
   * 2021-01-01
   */
  operateTimeGMT?: string;
  /**
   * @example
   * remove
   */
  operateType?: string;
  /**
   * @example
   * manager123
   */
  operator?: string;
  /**
   * @example
   * 1732223326,1232321888,12188991
   */
  operatorAgentIdList?: GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList[];
  /**
   * @example
   * 张三
   */
  operatorDisplayName?: string;
  /**
   * @example
   * 李四
   */
  operatorName?: string;
  /**
   * @example
   * 无冬
   */
  operatorNickName?: string;
  /**
   * @example
   * https://oss.com/a.jpeg
   */
  operatorPhotoUrl?: string;
  /**
   * @example
   * 良好
   */
  operatorStatus?: string;
  processInstanceId?: string;
  remark?: string;
  /**
   * @example
   * 请购类型
   */
  showName?: string;
  /**
   * @example
   * 12
   */
  size?: number;
  /**
   * @example
   * 同步
   */
  taskExecuteType?: string;
  /**
   * @example
   * 2021-01-01
   */
  taskHoldTimeGMT?: number;
  /**
   * @example
   * task-123
   */
  taskId?: string;
  /**
   * @example
   * append task
   */
  taskType?: string;
  /**
   * @example
   * i18n
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      activeTimeGMT: 'activeTimeGMT',
      activityId: 'activityId',
      digitalSignature: 'digitalSignature',
      files: 'files',
      formatAction: 'formatAction',
      operateTimeGMT: 'operateTimeGMT',
      operateType: 'operateType',
      operator: 'operator',
      operatorAgentIdList: 'operatorAgentIdList',
      operatorDisplayName: 'operatorDisplayName',
      operatorName: 'operatorName',
      operatorNickName: 'operatorNickName',
      operatorPhotoUrl: 'operatorPhotoUrl',
      operatorStatus: 'operatorStatus',
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
      activeTimeGMT: 'string',
      activityId: 'string',
      digitalSignature: 'string',
      files: 'string',
      formatAction: 'string',
      operateTimeGMT: 'string',
      operateType: 'string',
      operator: 'string',
      operatorAgentIdList: { 'type': 'array', 'itemType': GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList },
      operatorDisplayName: 'string',
      operatorName: 'string',
      operatorNickName: 'string',
      operatorPhotoUrl: 'string',
      operatorStatus: 'string',
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

export class GetOperationRecordsResponseBodyResult extends $tea.Model {
  action?: string;
  actionExit?: string;
  activeTimeGMT?: string;
  activityId?: string;
  dataId?: number;
  digitalSign?: string;
  domainList?: GetOperationRecordsResponseBodyResultDomainList[];
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
      domainList: 'domainList',
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
      domainList: { 'type': 'array', 'itemType': GetOperationRecordsResponseBodyResultDomainList },
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
  /**
   * @example
   * 李四的宜搭应用
   */
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
  /**
   * @example
   * 2021-02-01
   */
  activeTimeGMT?: string;
  /**
   * @example
   * manager123
   */
  actualActionExecutorId?: string;
  appType?: string;
  /**
   * @example
   * 2021-01-01
   */
  createTimeGMT?: string;
  /**
   * @example
   * 2021-01-01
   */
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
  /**
   * @example
   * running
   */
  status?: string;
  /**
   * @example
   * task-123
   */
  taskId?: string;
  /**
   * @example
   * append task
   */
  taskType?: string;
  /**
   * @example
   * 李四发起的请购单
   */
  title?: string;
  /**
   * @example
   * title A
   */
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
  /**
   * @example
   * 12345
   */
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
  /**
   * @example
   * 12345
   */
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
  /**
   * @example
   * act-xxaanfaf
   */
  activityId?: string;
  /**
   * @example
   * running
   */
  activityInstanceStatus?: string;
  /**
   * @example
   * activity-124
   */
  activityName?: string;
  /**
   * @example
   * redirect task
   */
  activityNameInEnglish?: string;
  /**
   * @example
   * 12345
   */
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
  /**
   * @example
   * 2021-01-01
   */
  createTimeGMT?: string;
  currentActivityInstances?: GetTaskCopiesResponseBodyDataCurrentActivityInstances[];
  dataMap?: { [key: string]: any };
  dataType?: string;
  /**
   * @example
   * 2021-01-01
   */
  finishTimeGMT?: string;
  formInstanceId?: string;
  formUuid?: string;
  /**
   * @example
   * 符合宜搭表单实例格式的json数据
   */
  instanceValue?: string;
  modifiedTimeGMT?: string;
  originatorAvatar?: string;
  originatorDisplayName?: string;
  originatorId?: string;
  processApprovedResult?: string;
  processApprovedResultText?: string;
  processCode?: string;
  /**
   * @example
   * proc-123
   */
  processId?: number;
  processInstanceId?: string;
  processInstanceStatus?: string;
  processInstanceStatusText?: string;
  processName?: string;
  /**
   * @example
   * ser-BNANFAHHYDFNK
   */
  serialNumber?: string;
  /**
   * @example
   * 李四发起的请购单
   */
  title?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * {"ODIN_TOPIC_ID":"2560649","APPPROVIDER":"vigo","NEEDAYALYSIS":"n","NAVTYPE":"top_side","SHOWICON":"n","REPORT_SUPPORT_META_3":"y","ALLOW_EXTERNAL_ADDRESS_BOOK":"y","REPORTVERSION":"V5","FORM_SCHEMA_VERSION":"V5","EXCEL_SOURCE":"LOCAL","DEVICETYPE":"web,mobile","ENABLE_CSRF_SWITCH":"y","NEW_ALLOW_EXTERNAL_ADDRESS_BOOK":"y","COLOUR":"blue","DINGTALK_CID":"LOCAL","APPMODE":"normal","NAVLAYOUT":"auto","SHOWNAV":"y","SHOWCRUMB":"y","SUPPORT_META_3":"y","SUPPORT_META_2":"y","SYSTEMLINK":"https://www.aliwork.com/APP_LDYQVBGT167NAON5KB1X/workbench","DATA_QUERY_VERSION":"V1","DB_SOURCE_TYPE":"TDDL_MYSQL","ISTODINGAPPCENTER":"n","REVERSION":"5.9.16","EDS_DB_INDEX":"24","NAVIGATION":"TODO,DONE,SUBMIT","APPTYPE":"single"}
   */
  appConfig?: string;
  /**
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  /**
   * @example
   * 上线:ONLINE，下线:OFFLINE
   */
  applicationStatus?: string;
  /**
   * @example
   * ding5d17e3add038d44535c2f4657eb6378e
   */
  corpId?: string;
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  /**
   * @example
   * 步凡创建的宜搭应用
   */
  description?: string;
  /**
   * @example
   * appdiqiu%%#0089FF
   */
  icon?: string;
  /**
   * @example
   * 已删除:y，未删除:n
   */
  inexistence?: string;
  /**
   * @example
   * 测试应用
   */
  name?: string;
  /**
   * @example
   * ding8eaadfkksj45343wksff334
   */
  subCorpId?: string;
  systemToken?: string;
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
      systemToken: 'systemToken',
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
      systemToken: 'string',
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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

export class PageAutoFlowLogResponseBodyData extends $tea.Model {
  /**
   * @example
   * APP_XCE0EVXS6DYG3YDYC5RD
   */
  appType?: string;
  elapsedTimeGMT?: number;
  /**
   * @example
   * 2021-01-01
   */
  finishTimeGMT?: string;
  flag?: string;
  procInstanceId?: string;
  processCode?: string;
  srcProcInstanceFinishTimeGMT?: string;
  srcProcInstanceId?: string;
  /**
   * @example
   * running
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      elapsedTimeGMT: 'elapsedTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      flag: 'flag',
      procInstanceId: 'procInstanceId',
      processCode: 'processCode',
      srcProcInstanceFinishTimeGMT: 'srcProcInstanceFinishTimeGMT',
      srcProcInstanceId: 'srcProcInstanceId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      elapsedTimeGMT: 'number',
      finishTimeGMT: 'string',
      flag: 'string',
      procInstanceId: 'string',
      processCode: 'string',
      srcProcInstanceFinishTimeGMT: 'string',
      srcProcInstanceId: 'string',
      status: 'number',
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

export class PreviewPublishedProcessResponseBodyResult extends $tea.Model {
  action?: string;
  actionExit?: string;
  activeTimeGMT?: string;
  activityId?: string;
  dataId?: number;
  digitalSign?: string;
  domains?: any[];
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
      domains: 'domains',
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
      domains: { 'type': 'array', 'itemType': 'any' },
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

export class QueryServiceRecordResponseBodyValues extends $tea.Model {
  /**
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceId?: string;
  /**
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * HTTP
   */
  hookType?: string;
  /**
   * @example
   * INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1L0
   */
  hookUuid?: string;
  /**
   * @example
   * {"parameter1":"测试服务执行"}
   */
  invokeParameter?: string;
  /**
   * @example
   * {"content":{"currentPage":1,"data":[{"industry_id":"互联网","role":"人事","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"用于企业员工假期请假、值班、就近办公等信息统计，便于假期工作事项安排。","orderNum":5,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"3365","textField_kzi3b7qm":"能力","scene":"企业应用","usageNum":3365,"role_id":"人事","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/49315603-3a20-4bd8-aeb0-a1430be3177a.jpg","templateTitle":"员工排班表","guide":"","orderNum_value":"5","author":"宜搭官方","appTplUuid":"TPL_RAOW06MPQBKKNENFMD5U","textField_kzp6ix74":"行业","scene_id":"企业应用","suggest":"快速入门","tags":["表单"],"isShow":"显示","isShow_id":"y","tags_id":["表单"]},{"industry_id":"互联网","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"1.可用于公司内部收集员工意见。\n2.可意见类型对意见进行整理。\n由杭州鑫峰维网络科技有限公司免费提供，可钉钉沟通或电话咨询 肖经理：15869116881","orderNum":14,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"678","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":678,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/72c0dcce-dded-417c-a003-db4679cc1c96.jpg","templateTitle":"意见反馈表","guide":"","orderNum_value":"14","author":"杭州鑫蜂维网络科技有限公司","appTplUuid":"TPL_KI4RE0NWXGTA1DV028XR","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["表单"],"isShow":"显示","isShow_id":"y","tags_id":["表单"]},{"industry_id":"制造业","role":"生产","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"一物一码，为每台设备生成二维码，并制作成标牌。业务巡检人员使用钉钉扫码，添加巡检和维修记录，上传现场照片，实现无纸化巡检。","orderNum":29,"industry":"制造业","textField_kzi3b7qj":"推荐","usageNum_value":"145","textField_kzi3b7qm":"能力","scene":"不展示","usageNum":145,"category_id":"NEW","role_id":"生产","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/bb437d98-4015-4830-9224-42d90cfe6089.jpeg","templateTitle":"设备扫码巡检","guide":"一物一码，为每台设备生成二维码，并制作成标牌。业务巡检人员使用钉钉扫码，添加巡检和维修记录，上传现场照片，实现无纸化巡检。","orderNum_value":"29","author":"宜搭官方","appTplUuid":"TPL_G4P53OFFXISLNOWZW0QT","textField_kzp6ix74":"行业","scene_id":"不展示","suggest":"快速入门","tags":["二维码"],"isShow":"显示","isShow_id":"y","tags_id":["二维码"],"category":"NEW"},{"industry_id":"互联网","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"是基于企业办公物品领用或申请的场景下，\n1、对物品自定义的录入和信息维护。\n2、库存流水，库存汇总的报表展示。\n由杭州鑫峰维网络科技有限公司免费提供，可钉钉沟通或电话咨询 肖经理：15869116881","orderNum":74,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"16238","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":16238,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/8c6d63b2-8a9f-4b05-8299-79e7dd97efc9.jpg","templateTitle":"办公物品申请","guide":"","orderNum_value":"74","author":"杭州鑫蜂维网络科技有限公司","appTplUuid":"TPL_WDGWQFTJD6FCG44NM4JC","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["流程表单"],"isShow":"显示","isShow_id":"y","tags_id":["流程表单"]},{"industry_id":"互联网","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"借用宜搭最新连接器能力，活动报名申请通过后自动拉入指定群。","orderNum":145,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"2522","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":2522,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/9b6d7f1a-135b-435a-88c5-97e9fed7e75c.jpg","templateTitle":"活动报名","guide":"","orderNum_value":"145","author":"宜搭官方","appTplUuid":"TPL_GLXCK24WLMDCRV8EMU0K","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["连接器"],"isShow":"显示","isShow_id":"y","tags_id":["连接器"]},{"industry_id":"互联网","role":"人事","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"一键导入工资，生成工资条消息，钉钉消息查看工资条","orderNum":277,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"746","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":746,"role_id":"人事","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/462be093-cc4f-4e7e-a72e-bdf15c2edfb7.jpg","templateTitle":"工资条","guide":"","orderNum_value":"277","author":"广州汇华信息科技有限公司","appTplUuid":"TPL_DQXKIBK2E06KKOP2BX2B","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["表单","快捷消息"],"isShow":"显示","isShow_id":"y","tags_id":["快捷消息","表单"]},{"industry_id":"教育行业","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"多岗位、多校区、涉及人员多，班次多，调班多；\n值班岗位，值班人员一目了然；线上调班，值班表信息同步；\n值班通知，系统自动推送；值班日志，记录留痕可查；\n值班阅览室，最新公告、流程汇总可查","orderNum":318,"industry":"教育行业","textField_kzi3b7qj":"推荐","usageNum_value":"608","textField_kzi3b7qm":"能力","scene":"不展示","usageNum":608,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/16d71251-a7ef-4a23-bcb0-77563bd3f7a9.jpg?x-oss-process=image/resize,m_fixed,h_380,w_680","templateTitle":"值班管理系统","guide":"多岗位、多校区、涉及人员多，班次多，调班多；\n值班岗位，值班人员一目了然；线上调班，值班表信息同步；\n值班通知，系统自动推送；值班日志，记录留痕可查；\n值班阅览室，最新公告、流程汇总可查","orderNum_value":"318","author":"宜搭官方","appTplUuid":"TPL_HC18Z4Y3SQDWO2SH1ZT9","textField_kzp6ix74":"行业","scene_id":"不展示","suggest":"快速入门","tags":["流程表单"],"isShow":"显示","isShow_id":"y","tags_id":["流程表单"]}],"entities":null,"hasMore":false,"idCursor":0,"totalCount":7},"errorCode":"","errorExtInfo":null,"errorLevel":"","errorMsg":"","success":true,"throwable":""}
   */
  invokeResult?: string;
  /**
   * @example
   * 可选值：SUCCESS、FAIL、FINAL_SUCCESS、ERROR
   */
  invokeStatus?: string;
  /**
   * @example
   * 成功：y，失败：n
   */
  invokeSuccess?: string;
  /**
   * @example
   * https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&pageSize=48&currentPage=1
   */
  invokeUrl?: string;
  /**
   * @example
   * {"url":"https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&pageSize=48&currentPage=1","isMd5":null,"signature":"","isSHA":null,"hmacSecret":"","type":"HttpExt","params":[{"field":"name","value":"name","label":{"zh_CN":"name","en_US":"name","type":"i18n"},"type":"java.lang.String"}]}
   */
  serviceContent?: string;
  /**
   * @example
   * 查询宜搭模板
   */
  serviceName?: string;
  /**
   * @example
   * {"parameter1":"测试服务执行"}
   */
  serviceParameter?: string;
  /**
   * @example
   * INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1LI
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * 开发部
   */
  departmentName?: string;
  /**
   * @example
   * abc@alimail.com
   */
  email?: string;
  name?: SearchFormDataRemovalTableDataResponseBodyDataModifyUserName;
  /**
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * 开发部
   */
  departmentName?: string;
  /**
   * @example
   * abc@alimail.com
   */
  email?: string;
  name?: SearchFormDataRemovalTableDataResponseBodyDataOriginatorName;
  /**
   * @example
   * ding173982232112232
   */
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
  /**
   * @example
   * 2021-05-01
   */
  createTimeGMT?: string;
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  /**
   * @example
   * {"countrySelectField_l0c1cwiu":[{"value":"US"}]}
   */
  formData?: { [key: string]: any };
  /**
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceId?: string;
  /**
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 12345
   */
  id?: number;
  /**
   * @example
   * 符合宜搭表单实例格式的json数据
   */
  instanceValue?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * manager123
   */
  modifier?: string;
  modifyUser?: SearchFormDataRemovalTableDataResponseBodyDataModifyUser;
  originator?: SearchFormDataRemovalTableDataResponseBodyDataOriginator;
  /**
   * @example
   * IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2
   */
  sequence?: string;
  /**
   * @example
   * YIDA909202202250027
   */
  serialNumber?: string;
  /**
   * @example
   * 李四发起的请购单
   */
  title?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * ding173982232112232
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
      name: SearchFormDataSecondGenerationResponseBodyDataModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyDataOriginatorName extends $tea.Model {
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * ding173982232112232
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
      name: SearchFormDataSecondGenerationResponseBodyDataOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationResponseBodyData extends $tea.Model {
  /**
   * @example
   * 2021-05-01
   */
  createTimeGMT?: string;
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  /**
   * @example
   * {"addressField_l0c1cwiy_id":"\"海南省/469027/国营红岗农场/111\"","associationFormField_l0c1hdz4_id":"\"[{\\\"formType\\\":\\\"receipt\\\",\\\"formUuid\\\":\\\"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\\\",\\\"instanceId\\\":\\\"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\\\",\\\"subTitle\\\":\\\"{\\\\\\\"type\\\\\\\":\\\\\\\"div\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":{\\\\\\\"type\\\\\\\":\\\\\\\"a\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":\\\\\\\"查看签名\\\\\\\",\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item-link\\\\\\\",\\\\\\\"style\\\\\\\":{\\\\\\\"cursor\\\\\\\":\\\\\\\"pointer\\\\\\\",\\\\\\\"color\\\\\\\":\\\\\\\"#0068ff\\\\\\\"}}},\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item\\\\\\\"}}\\\",\\\"appType\\\":\\\"APP_K6IGJJ6PFAARLPDSWKXQ\\\",\\\"title\\\":\\\"1\\\"}]\"","countrySelectField_l0c1cwiu_id":["PG"],"imageField_l0c1cwit":"[{\"previewUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80\",\"size\":2610734,\"name\":\"Bts2Z0e6oxA.jpg\",\"downloadUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\",\"url\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\"}]","rateField_l0c1cwis_value":"3","editorField_l0c1cwiz":"<div><strong>你好，这是测试</strong></div>\r\n<div><span style=\"font-family: kaiti;background-color: #ff0000;color: #ffff00;\"><em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>","rateField_l0c1cwis":3,"countrySelectField_l0c1cwiu":[],"attachmentField_l0ghkwv3":"[{\"downloadUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\",\"name\":\"Bts2Z0e6oxA.jpg\",\"previewUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80\",\"size\":2610734,\"url\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\"}]","addressField_l0c1cwiy":"{\"address\":\"111\",\"regionIds\":[460000,469027,469023401],\"regionText\":[{\"en_US\":\"hai+nan+sheng\",\"zh_CN\":\"海南省\"},{\"en_US\":\"cheng+mai+xian\",\"zh_CN\":\"澄迈县\"},{\"en_US\":\"guo+ying+hong+gang+nong+chang\",\"zh_CN\":\"国营红岗农场\"}]}"}
   */
  formData?: { [key: string]: any };
  /**
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceId?: string;
  /**
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 12345
   */
  id?: number;
  /**
   * @example
   * [{"componentName":"CountrySelectField","dateType":null,"fieldData":{"value":[{"text":{"en_US":"Papua New Guinea","zh_CN":"巴布亚新几内亚","type":"i18n"},"value":"PG"}]},"fieldDataUpdated":false,"fieldId":"countrySelectField_l0c1cwiu","format":null,"formatControls":null,"listNum":null,"options":[{"label":{"$ref":"$[0].fieldData.value[0].text"},"value":"PG"}],"rowId":null},{"componentName":"AssociationFormField","dateType":null,"fieldData":{"value":[{"formType":"receipt","formUuid":"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG","instanceId":"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31","subTitle":"{\"type\":\"div\",\"props\":{\"children\":{\"type\":\"a\",\"props\":{\"children\":\"查看签名\",\"className\":\"inst-cell-item-link\",\"style\":{\"cursor\":\"pointer\",\"color\":\"#0068ff\"}}},\"className\":\"inst-cell-item\"}}","appType":"APP_K6IGJJ6PFAARLPDSWKXQ","title":"1"}]},"fieldDataUpdated":false,"fieldId":"associationFormField_l0c1hdz4","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"ImageField","dateType":null,"fieldData":{"value":[{"previewUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80","size":2610734,"name":"Bts2Z0e6oxA.jpg","downloadUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download","url":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download"}]},"fieldDataUpdated":false,"fieldId":"imageField_l0c1cwit","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"AddressField","dateType":null,"fieldData":{"value":{"address":"111","regionIds":[460000,469027,469023401],"regionText":[{"en_US":"hai+nan+sheng","zh_CN":"海南省"},{"en_US":"cheng+mai+xian","zh_CN":"澄迈县"},{"en_US":"guo+ying+hong+gang+nong+chang","zh_CN":"国营红岗农场"}]}},"fieldDataUpdated":false,"fieldId":"addressField_l0c1cwiy","format":null,"formatControls":null,"listNum":null,"options":[{"label":{"pureEn_US":"hai+nan+sheng","en_US":"hai+nan+sheng","zh_CN":"海南省","type":"i18n","key":null},"value":460000},{"label":{"pureEn_US":"cheng+mai+xian","en_US":"cheng+mai+xian","zh_CN":"澄迈县","type":"i18n","key":null},"value":469027},{"label":{"pureEn_US":"guo+ying+hong+gang+nong+chang","en_US":"guo+ying+hong+gang+nong+chang","zh_CN":"国营红岗农场","type":"i18n","key":null},"value":469023401}],"rowId":null},{"componentName":"EditorField","dateType":null,"fieldData":{"value":"<div><strong>你好，这是测试</strong></div>\r\n<div><span style=\"font-family: kaiti;background-color: #ff0000;color: #ffff00;\"><em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>"},"fieldDataUpdated":false,"fieldId":"editorField_l0c1cwiz","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"RateField","dateType":null,"fieldData":{"value":"3"},"fieldDataUpdated":false,"fieldId":"rateField_l0c1cwis","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"AttachmentField","dateType":null,"fieldData":{"value":[{"previewUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80","size":2610734,"name":"Bts2Z0e6oxA.jpg","downloadUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download","url":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download"}]},"fieldDataUpdated":false,"fieldId":"attachmentField_l0ghkwv3","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null}]
   */
  instanceValue?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * manager123
   */
  modifier?: string;
  modifyUser?: SearchFormDataSecondGenerationResponseBodyDataModifyUser;
  originator?: SearchFormDataSecondGenerationResponseBodyDataOriginator;
  /**
   * @example
   * IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2
   */
  sequence?: string;
  /**
   * @example
   * YIDA909202202250027
   */
  serialNumber?: string;
  /**
   * @example
   * 李四发起的请购单
   */
  title?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * ding173982232112232
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
      name: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName extends $tea.Model {
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
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
  /**
   * @example
   * ding173982232112232
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
      name: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataSecondGenerationNoTableFieldResponseBodyData extends $tea.Model {
  /**
   * @example
   * 2021-05-01
   */
  createTimeGMT?: string;
  /**
   * @example
   * ding12345
   */
  creatorUserId?: string;
  /**
   * @example
   * {"addressField_l0c1cwiy_id":"\"海南省/469027/国营红岗农场/111\"","associationFormField_l0c1hdz4_id":"\"[{\\\"formType\\\":\\\"receipt\\\",\\\"formUuid\\\":\\\"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\\\",\\\"instanceId\\\":\\\"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\\\",\\\"subTitle\\\":\\\"{\\\\\\\"type\\\\\\\":\\\\\\\"div\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":{\\\\\\\"type\\\\\\\":\\\\\\\"a\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":\\\\\\\"查看签名\\\\\\\",\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item-link\\\\\\\",\\\\\\\"style\\\\\\\":{\\\\\\\"cursor\\\\\\\":\\\\\\\"pointer\\\\\\\",\\\\\\\"color\\\\\\\":\\\\\\\"#0068ff\\\\\\\"}}},\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item\\\\\\\"}}\\\",\\\"appType\\\":\\\"APP_K6IGJJ6PFAARLPDSWKXQ\\\",\\\"title\\\":\\\"1\\\"}]\"","countrySelectField_l0c1cwiu_id":["PG"],"imageField_l0c1cwit":"[{\"previewUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80\",\"size\":2610734,\"name\":\"Bts2Z0e6oxA.jpg\",\"downloadUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\",\"url\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\"}]","rateField_l0c1cwis_value":"3","editorField_l0c1cwiz":"<div><strong>你好，这是测试</strong></div>\r\n<div><span style=\"font-family: kaiti;background-color: #ff0000;color: #ffff00;\"><em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>","rateField_l0c1cwis":3,"countrySelectField_l0c1cwiu":[],"attachmentField_l0ghkwv3":"[{\"downloadUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\",\"name\":\"Bts2Z0e6oxA.jpg\",\"previewUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80\",\"size\":2610734,\"url\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\"}]","addressField_l0c1cwiy":"{\"address\":\"111\",\"regionIds\":[460000,469027,469023401],\"regionText\":[{\"en_US\":\"hai+nan+sheng\",\"zh_CN\":\"海南省\"},{\"en_US\":\"cheng+mai+xian\",\"zh_CN\":\"澄迈县\"},{\"en_US\":\"guo+ying+hong+gang+nong+chang\",\"zh_CN\":\"国营红岗农场\"}]}"}
   */
  formData?: { [key: string]: any };
  /**
   * @example
   * FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
   */
  formInstanceId?: string;
  /**
   * @example
   * FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
   */
  formUuid?: string;
  /**
   * @example
   * 12345
   */
  id?: number;
  /**
   * @example
   * [{"componentName":"AddressField","dateType":null,"fieldData":{"value":{"address":"白帝城","regionIds":[340000,340800,340803,340803401],"regionText":[{"en_US":"an hui sheng","zh_CN":"安徽省"},{"en_US":"an qing shi","zh_CN":"安庆市"},{"en_US":"da guan qu","zh_CN":"大观区"},{"en_US":"an hui an qing hai kou jing ji kai fa qu","zh_CN":"安徽安庆海口经济开发区"}]}},"fieldDataUpdated":false,"fieldId":"addressField_kwod1oza","format":null,"formatControls":null,"listNum":null,"options":[{"label":{"pureEn_US":"an hui sheng","en_US":"an hui sheng","zh_CN":"安徽省","type":"i18n","key":null},"value":340000},{"label":{"pureEn_US":"an qing shi","en_US":"an qing shi","zh_CN":"安庆市","type":"i18n","key":null},"value":340800},{"label":{"pureEn_US":"da guan qu","en_US":"da guan qu","zh_CN":"大观区","type":"i18n","key":null},"value":340803},{"label":{"pureEn_US":"an hui an qing hai kou jing ji kai fa qu","en_US":"an hui an qing hai kou jing ji kai fa qu","zh_CN":"安徽安庆海口经济开发区","type":"i18n","key":null},"value":340803401}],"rowId":null}]
   */
  instanceValue?: string;
  /**
   * @example
   * 2021-05-01
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * manager123
   */
  modifier?: string;
  modifyUser?: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser;
  originator?: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator;
  /**
   * @example
   * IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2
   */
  sequence?: string;
  /**
   * @example
   * YIDA909202202250027
   */
  serialNumber?: string;
  /**
   * @example
   * 李四发起的请购单
   */
  title?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
  nameInEnglish?: string;
  /**
   * @example
   * i18n
   */
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
  /**
   * @example
   * 张三
   */
  nameInChinese?: string;
  /**
   * @example
   * ZhangSan
   */
  nameInEnglish?: string;
  /**
   * @example
   * i18n
   */
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
  /**
   * @example
   * 2018-01-24 11:22:01
   */
  createdTimeGMT?: string;
  /**
   * @example
   * 1731234567
   */
  creatorUserId?: string;
  /**
   * @example
   * 1002
   */
  dataId?: number;
  /**
   * @example
   * {"numberField_jcr0069o":1,"multiSelectField_jcr0069s":["选项三","选项二"],"textareaField_jcr0069n":"duohang","employeeField_jcr0069x":["xxxx"],"departmentField_jcr0069z":"xxxx","cascadeDate_jcr0069u":["1514736000000","1517328000000"],"cascadeSelectField_jcr006a0":["part","part_b"],"tableField_jcr006a1":[{"departmentField_jcr006ad":"xxxx","cascadeDate_jcr006aa":["1514736000000","1517328000000"],"selectField_jcr006a6":"选项三","citySelectField_jcr006ac":["天津","天津市","河东区"],"radioField_jcr006a5":"选项二","employeeField_jcr006ab":["xxxxxx","yyyyyy"],"dateField_jcr006a9":1517328000000,"textField_jcr006a2":"明细下单行","textareaField_jcr006a3":"明细下多行","cascadeSelectField_jcr006ae":["product","product_a"],"numberField_jcr006a4":2,"checkboxField_jcr006a7":["选项一","选项三","选项二"],"multiSelectField_jcr006a8":["选项一","选项三","选项二"]}],"selectField_jcr0069q":"选项一","citySelectField_jcr0069y":["北京","北京市","东城区"],"checkboxField_jcr0069r":["选项三","选项二"],"textField_jcr0069m":"danhang","radioField_jcr0069p":"选项一","dateField_jcr0069t":1516636800000}
   */
  formData?: { [key: string]: any };
  /**
   * @example
   * FINST-BNKJDRF
   */
  formInstanceId?: string;
  /**
   * @example
   * FORM-EF6Y93URN24F1SCX15VA2P918LPEIJ2H3UFORCJ1
   */
  formUuid?: string;
  /**
   * @example
   * {"textField":"124"}
   */
  instanceValue?: string;
  modelUuid?: string;
  /**
   * @example
   * 2018-01-24 11:22:01
   */
  modifiedTimeGMT?: string;
  /**
   * @example
   * 1731234567
   */
  modifierUserId?: string;
  modifyUser?: SearchFormDatasResponseBodyDataModifyUser;
  originator?: SearchFormDatasResponseBodyDataOriginator;
  /**
   * @example
   * Squence-XXX
   */
  sequence?: string;
  /**
   * @example
   * 1234
   */
  serialNo?: string;
  /**
   * @example
   * 张三发起的表单
   */
  title?: string;
  /**
   * @example
   * 3
   */
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
   * 生成登录态传递用的code
   * 
   * @param request - AppLoginCodeGenRequest
   * @param headers - AppLoginCodeGenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AppLoginCodeGenResponse
   */
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

  /**
   * 生成登录态传递用的code
   * 
   * @param request - AppLoginCodeGenRequest
   * @returns AppLoginCodeGenResponse
   */
  async appLoginCodeGen(request: AppLoginCodeGenRequest): Promise<AppLoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppLoginCodeGenHeaders({ });
    return await this.appLoginCodeGenWithOptions(request, headers, runtime);
  }

  /**
   * 批量获取指定表单实例ID列表对应的表单实例数据
   * 
   * @param request - BatchGetFormDataByIdListRequest
   * @param headers - BatchGetFormDataByIdListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchGetFormDataByIdListResponse
   */
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

  /**
   * 批量获取指定表单实例ID列表对应的表单实例数据
   * 
   * @param request - BatchGetFormDataByIdListRequest
   * @returns BatchGetFormDataByIdListResponse
   */
  async batchGetFormDataByIdList(request: BatchGetFormDataByIdListRequest): Promise<BatchGetFormDataByIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetFormDataByIdListHeaders({ });
    return await this.batchGetFormDataByIdListWithOptions(request, headers, runtime);
  }

  /**
   * 批量删除指定的表单实例
   * 
   * @param request - BatchRemovalByFormInstanceIdListRequest
   * @param headers - BatchRemovalByFormInstanceIdListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRemovalByFormInstanceIdListResponse
   */
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

  /**
   * 批量删除指定的表单实例
   * 
   * @param request - BatchRemovalByFormInstanceIdListRequest
   * @returns BatchRemovalByFormInstanceIdListResponse
   */
  async batchRemovalByFormInstanceIdList(request: BatchRemovalByFormInstanceIdListRequest): Promise<BatchRemovalByFormInstanceIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRemovalByFormInstanceIdListHeaders({ });
    return await this.batchRemovalByFormInstanceIdListWithOptions(request, headers, runtime);
  }

  /**
   * 批量保存表单实例数据
   * 
   * @param request - BatchSaveFormDataRequest
   * @param headers - BatchSaveFormDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchSaveFormDataResponse
   */
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

  /**
   * 批量保存表单实例数据
   * 
   * @param request - BatchSaveFormDataRequest
   * @returns BatchSaveFormDataResponse
   */
  async batchSaveFormData(request: BatchSaveFormDataRequest): Promise<BatchSaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSaveFormDataHeaders({ });
    return await this.batchSaveFormDataWithOptions(request, headers, runtime);
  }

  /**
   * 将多条表单实例的指定表单组件更新成指定值
   * 
   * @param request - BatchUpdateFormDataByInstanceIdRequest
   * @param headers - BatchUpdateFormDataByInstanceIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateFormDataByInstanceIdResponse
   */
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

  /**
   * 将多条表单实例的指定表单组件更新成指定值
   * 
   * @param request - BatchUpdateFormDataByInstanceIdRequest
   * @returns BatchUpdateFormDataByInstanceIdResponse
   */
  async batchUpdateFormDataByInstanceId(request: BatchUpdateFormDataByInstanceIdRequest): Promise<BatchUpdateFormDataByInstanceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateFormDataByInstanceIdHeaders({ });
    return await this.batchUpdateFormDataByInstanceIdWithOptions(request, headers, runtime);
  }

  /**
   * 通过表单实例数据批量更新表单实例
   * 
   * @param request - BatchUpdateFormDataByInstanceMapRequest
   * @param headers - BatchUpdateFormDataByInstanceMapHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateFormDataByInstanceMapResponse
   */
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

  /**
   * 通过表单实例数据批量更新表单实例
   * 
   * @param request - BatchUpdateFormDataByInstanceMapRequest
   * @returns BatchUpdateFormDataByInstanceMapResponse
   */
  async batchUpdateFormDataByInstanceMap(request: BatchUpdateFormDataByInstanceMapRequest): Promise<BatchUpdateFormDataByInstanceMapResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateFormDataByInstanceMapHeaders({ });
    return await this.batchUpdateFormDataByInstanceMapWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道新购(通过应用授权服务)
   * 
   * @param request - BuyAuthorizationOrderRequest
   * @param headers - BuyAuthorizationOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BuyAuthorizationOrderResponse
   */
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

  /**
   * 多渠道新购(通过应用授权服务)
   * 
   * @param request - BuyAuthorizationOrderRequest
   * @returns BuyAuthorizationOrderResponse
   */
  async buyAuthorizationOrder(request: BuyAuthorizationOrderRequest): Promise<BuyAuthorizationOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BuyAuthorizationOrderHeaders({ });
    return await this.buyAuthorizationOrderWithOptions(request, headers, runtime);
  }

  /**
   * 新购宜搭产品
   * 
   * @param request - BuyFreshOrderRequest
   * @param headers - BuyFreshOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BuyFreshOrderResponse
   */
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

  /**
   * 新购宜搭产品
   * 
   * @param request - BuyFreshOrderRequest
   * @returns BuyFreshOrderResponse
   */
  async buyFreshOrder(request: BuyFreshOrderRequest): Promise<BuyFreshOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BuyFreshOrderHeaders({ });
    return await this.buyFreshOrderWithOptions(request, headers, runtime);
  }

  /**
   * 根据阿里云账号验证激活结果
   * 
   * @param request - CheckCloudAccountStatusRequest
   * @param headers - CheckCloudAccountStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckCloudAccountStatusResponse
   */
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

  /**
   * 根据阿里云账号验证激活结果
   * 
   * @param request - CheckCloudAccountStatusRequest
   * @returns CheckCloudAccountStatusResponse
   */
  async checkCloudAccountStatus(callerUid: string, request: CheckCloudAccountStatusRequest): Promise<CheckCloudAccountStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckCloudAccountStatusHeaders({ });
    return await this.checkCloudAccountStatusWithOptions(callerUid, request, headers, runtime);
  }

  /**
   * 新增或更新表单实例
   * 
   * @param request - CreateOrUpdateFormDataRequest
   * @param headers - CreateOrUpdateFormDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateOrUpdateFormDataResponse
   */
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

  /**
   * 新增或更新表单实例
   * 
   * @param request - CreateOrUpdateFormDataRequest
   * @returns CreateOrUpdateFormDataResponse
   */
  async createOrUpdateFormData(request: CreateOrUpdateFormDataRequest): Promise<CreateOrUpdateFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrUpdateFormDataHeaders({ });
    return await this.createOrUpdateFormDataWithOptions(request, headers, runtime);
  }

  /**
   * 删除表单实例
   * 
   * @param request - DeleteFormDataRequest
   * @param headers - DeleteFormDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteFormDataResponse
   */
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

  /**
   * 删除表单实例
   * 
   * @param request - DeleteFormDataRequest
   * @returns DeleteFormDataResponse
   */
  async deleteFormData(request: DeleteFormDataRequest): Promise<DeleteFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFormDataHeaders({ });
    return await this.deleteFormDataWithOptions(request, headers, runtime);
  }

  /**
   * 删除流程实例
   * 
   * @param request - DeleteInstanceRequest
   * @param headers - DeleteInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteInstanceResponse
   */
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

  /**
   * 删除流程实例
   * 
   * @param request - DeleteInstanceRequest
   * @returns DeleteInstanceResponse
   */
  async deleteInstance(request: DeleteInstanceRequest): Promise<DeleteInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInstanceHeaders({ });
    return await this.deleteInstanceWithOptions(request, headers, runtime);
  }

  /**
   * deleteSequence
   * 
   * @param request - DeleteSequenceRequest
   * @param headers - DeleteSequenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteSequenceResponse
   */
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

  /**
   * deleteSequence
   * 
   * @param request - DeleteSequenceRequest
   * @returns DeleteSequenceResponse
   */
  async deleteSequence(request: DeleteSequenceRequest): Promise<DeleteSequenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSequenceHeaders({ });
    return await this.deleteSequenceWithOptions(request, headers, runtime);
  }

  /**
   * 云开发平台函数计算部署完成回调宜搭
   * 
   * @param request - DeployFunctionCallbackRequest
   * @param headers - DeployFunctionCallbackHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeployFunctionCallbackResponse
   */
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

  /**
   * 云开发平台函数计算部署完成回调宜搭
   * 
   * @param request - DeployFunctionCallbackRequest
   * @returns DeployFunctionCallbackResponse
   */
  async deployFunctionCallback(request: DeployFunctionCallbackRequest): Promise<DeployFunctionCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeployFunctionCallbackHeaders({ });
    return await this.deployFunctionCallbackWithOptions(request, headers, runtime);
  }

  /**
   * 批量审批
   * 
   * @param request - ExecuteBatchTaskRequest
   * @param headers - ExecuteBatchTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecuteBatchTaskResponse
   */
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

  /**
   * 批量审批
   * 
   * @param request - ExecuteBatchTaskRequest
   * @returns ExecuteBatchTaskResponse
   */
  async executeBatchTask(request: ExecuteBatchTaskRequest): Promise<ExecuteBatchTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteBatchTaskHeaders({ });
    return await this.executeBatchTaskWithOptions(request, headers, runtime);
  }

  /**
   * 执行用户自定义的API接口
   * 
   * @param request - ExecuteCustomApiRequest
   * @param headers - ExecuteCustomApiHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecuteCustomApiResponse
   */
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

  /**
   * 执行用户自定义的API接口
   * 
   * @param request - ExecuteCustomApiRequest
   * @returns ExecuteCustomApiResponse
   */
  async executeCustomApi(request: ExecuteCustomApiRequest): Promise<ExecuteCustomApiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteCustomApiHeaders({ });
    return await this.executeCustomApiWithOptions(request, headers, runtime);
  }

  /**
   * 执行宜搭平台的审批任务
   * 
   * @param request - ExecutePlatformTaskRequest
   * @param headers - ExecutePlatformTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecutePlatformTaskResponse
   */
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

  /**
   * 执行宜搭平台的审批任务
   * 
   * @param request - ExecutePlatformTaskRequest
   * @returns ExecutePlatformTaskResponse
   */
  async executePlatformTask(request: ExecutePlatformTaskRequest): Promise<ExecutePlatformTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecutePlatformTaskHeaders({ });
    return await this.executePlatformTaskWithOptions(request, headers, runtime);
  }

  /**
   * 执行审批任务
   * 
   * @param request - ExecuteTaskRequest
   * @param headers - ExecuteTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecuteTaskResponse
   */
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

  /**
   * 执行审批任务
   * 
   * @param request - ExecuteTaskRequest
   * @returns ExecuteTaskResponse
   */
  async executeTask(request: ExecuteTaskRequest): Promise<ExecuteTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteTaskHeaders({ });
    return await this.executeTaskWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道到期
   * 
   * @param request - ExpireCommodityRequest
   * @param headers - ExpireCommodityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExpireCommodityResponse
   */
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

  /**
   * 多渠道到期
   * 
   * @param request - ExpireCommodityRequest
   * @returns ExpireCommodityResponse
   */
  async expireCommodity(request: ExpireCommodityRequest): Promise<ExpireCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExpireCommodityHeaders({ });
    return await this.expireCommodityWithOptions(request, headers, runtime);
  }

  /**
   * 根据阿里云账号获取激活码
   * 
   * @param request - GetActivationCodeByCallerUnionIdRequest
   * @param headers - GetActivationCodeByCallerUnionIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetActivationCodeByCallerUnionIdResponse
   */
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

  /**
   * 根据阿里云账号获取激活码
   * 
   * @param request - GetActivationCodeByCallerUnionIdRequest
   * @returns GetActivationCodeByCallerUnionIdResponse
   */
  async getActivationCodeByCallerUnionId(callerUid: string, request: GetActivationCodeByCallerUnionIdRequest): Promise<GetActivationCodeByCallerUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivationCodeByCallerUnionIdHeaders({ });
    return await this.getActivationCodeByCallerUnionIdWithOptions(callerUid, request, headers, runtime);
  }

  /**
   * 获取流程实例可操作功能列表
   * 
   * @param request - GetActivityButtonListRequest
   * @param headers - GetActivityButtonListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetActivityButtonListResponse
   */
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

  /**
   * 获取流程实例可操作功能列表
   * 
   * @param request - GetActivityButtonListRequest
   * @returns GetActivityButtonListResponse
   */
  async getActivityButtonList(appType: string, processCode: string, activityId: string, request: GetActivityButtonListRequest): Promise<GetActivityButtonListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityButtonListHeaders({ });
    return await this.getActivityButtonListWithOptions(appType, processCode, activityId, request, headers, runtime);
  }

  /**
   * 获取流程设计的节点信息
   * 
   * @param request - GetActivityListRequest
   * @param headers - GetActivityListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetActivityListResponse
   */
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

  /**
   * 获取流程设计的节点信息
   * 
   * @param request - GetActivityListRequest
   * @returns GetActivityListResponse
   */
  async getActivityList(request: GetActivityListRequest): Promise<GetActivityListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityListHeaders({ });
    return await this.getActivityListWithOptions(request, headers, runtime);
  }

  /**
   * 查询表单的接口，支持分页、表单名称模糊查询
   * 
   * @param request - GetAllAuthCubesRequest
   * @param headers - GetAllAuthCubesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllAuthCubesResponse
   */
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

  /**
   * 查询表单的接口，支持分页、表单名称模糊查询
   * 
   * @param request - GetAllAuthCubesRequest
   * @returns GetAllAuthCubesResponse
   */
  async getAllAuthCubes(request: GetAllAuthCubesRequest): Promise<GetAllAuthCubesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllAuthCubesHeaders({ });
    return await this.getAllAuthCubesWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道平台概览接口
   * 
   * @param request - GetApplicationAuthorizationServicePlatformResourceRequest
   * @param headers - GetApplicationAuthorizationServicePlatformResourceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetApplicationAuthorizationServicePlatformResourceResponse
   */
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

  /**
   * 多渠道平台概览接口
   * 
   * @param request - GetApplicationAuthorizationServicePlatformResourceRequest
   * @returns GetApplicationAuthorizationServicePlatformResourceResponse
   */
  async getApplicationAuthorizationServicePlatformResource(request: GetApplicationAuthorizationServicePlatformResourceRequest): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationAuthorizationServicePlatformResourceHeaders({ });
    return await this.getApplicationAuthorizationServicePlatformResourceWithOptions(request, headers, runtime);
  }

  /**
   * 获取自动化流日志详情
   * 
   * @param request - GetAutoFlowLogDetailRequest
   * @param headers - GetAutoFlowLogDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAutoFlowLogDetailResponse
   */
  async getAutoFlowLogDetailWithOptions(request: GetAutoFlowLogDetailRequest, headers: GetAutoFlowLogDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetAutoFlowLogDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.procInstanceId)) {
      query["procInstanceId"] = request.procInstanceId;
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
      action: "GetAutoFlowLogDetail",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/logs/automations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAutoFlowLogDetailResponse>(await this.execute(params, req, runtime), new GetAutoFlowLogDetailResponse({}));
  }

  /**
   * 获取自动化流日志详情
   * 
   * @param request - GetAutoFlowLogDetailRequest
   * @returns GetAutoFlowLogDetailResponse
   */
  async getAutoFlowLogDetail(request: GetAutoFlowLogDetailRequest): Promise<GetAutoFlowLogDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAutoFlowLogDetailHeaders({ });
    return await this.getAutoFlowLogDetailWithOptions(request, headers, runtime);
  }

  /**
   * 查询已完成任务列表
   * 
   * @param request - GetCorpAccomplishmentTasksRequest
   * @param headers - GetCorpAccomplishmentTasksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCorpAccomplishmentTasksResponse
   */
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

  /**
   * 查询已完成任务列表
   * 
   * @param request - GetCorpAccomplishmentTasksRequest
   * @returns GetCorpAccomplishmentTasksResponse
   */
  async getCorpAccomplishmentTasks(corpId: string, userId: string, request: GetCorpAccomplishmentTasksRequest): Promise<GetCorpAccomplishmentTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpAccomplishmentTasksHeaders({ });
    return await this.getCorpAccomplishmentTasksWithOptions(corpId, userId, request, headers, runtime);
  }

  /**
   * 根据accountId获取企业等级
   * 
   * @param request - GetCorpLevelByAccountIdRequest
   * @param headers - GetCorpLevelByAccountIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCorpLevelByAccountIdResponse
   */
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

  /**
   * 根据accountId获取企业等级
   * 
   * @param request - GetCorpLevelByAccountIdRequest
   * @returns GetCorpLevelByAccountIdResponse
   */
  async getCorpLevelByAccountId(request: GetCorpLevelByAccountIdRequest): Promise<GetCorpLevelByAccountIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpLevelByAccountIdHeaders({ });
    return await this.getCorpLevelByAccountIdWithOptions(request, headers, runtime);
  }

  /**
   * 查询待办任务列表
   * 
   * @param request - GetCorpTasksRequest
   * @param headers - GetCorpTasksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCorpTasksResponse
   */
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

  /**
   * 查询待办任务列表
   * 
   * @param request - GetCorpTasksRequest
   * @returns GetCorpTasksResponse
   */
  async getCorpTasks(request: GetCorpTasksRequest): Promise<GetCorpTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpTasksHeaders({ });
    return await this.getCorpTasksWithOptions(request, headers, runtime);
  }

  /**
   * 获取数据库连接串信息
   * 
   * @param request - GetDbConfigRequest
   * @param headers - GetDbConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDbConfigResponse
   */
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

  /**
   * 获取数据库连接串信息
   * 
   * @param request - GetDbConfigRequest
   * @returns GetDbConfigResponse
   */
  async getDbConfig(request: GetDbConfigRequest): Promise<GetDbConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDbConfigHeaders({ });
    return await this.getDbConfigWithOptions(request, headers, runtime);
  }

  /**
   * 根据表单ID获取字段信息
   * 
   * @param request - GetFieldDefByUuidRequest
   * @param headers - GetFieldDefByUuidHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFieldDefByUuidResponse
   */
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

  /**
   * 根据表单ID获取字段信息
   * 
   * @param request - GetFieldDefByUuidRequest
   * @returns GetFieldDefByUuidResponse
   */
  async getFieldDefByUuid(request: GetFieldDefByUuidRequest): Promise<GetFieldDefByUuidResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFieldDefByUuidHeaders({ });
    return await this.getFieldDefByUuidWithOptions(request, headers, runtime);
  }

  /**
   * 获取表单定义
   * 
   * @param request - GetFormComponentDefinitionListRequest
   * @param headers - GetFormComponentDefinitionListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFormComponentDefinitionListResponse
   */
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

  /**
   * 获取表单定义
   * 
   * @param request - GetFormComponentDefinitionListRequest
   * @returns GetFormComponentDefinitionListResponse
   */
  async getFormComponentDefinitionList(appType: string, formUuid: string, request: GetFormComponentDefinitionListRequest): Promise<GetFormComponentDefinitionListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormComponentDefinitionListHeaders({ });
    return await this.getFormComponentDefinitionListWithOptions(appType, formUuid, request, headers, runtime);
  }

  /**
   * 根据表单 ID 查询实例详情
   * 
   * @param request - GetFormDataByIDRequest
   * @param headers - GetFormDataByIDHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFormDataByIDResponse
   */
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

  /**
   * 根据表单 ID 查询实例详情
   * 
   * @param request - GetFormDataByIDRequest
   * @returns GetFormDataByIDResponse
   */
  async getFormDataByID(id: string, request: GetFormDataByIDRequest): Promise<GetFormDataByIDResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormDataByIDHeaders({ });
    return await this.getFormDataByIDWithOptions(id, request, headers, runtime);
  }

  /**
   * 获取应用内表单列表信息
   * 
   * @param request - GetFormListInAppRequest
   * @param headers - GetFormListInAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFormListInAppResponse
   */
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

  /**
   * 获取应用内表单列表信息
   * 
   * @param request - GetFormListInAppRequest
   * @returns GetFormListInAppResponse
   */
  async getFormListInApp(request: GetFormListInAppRequest): Promise<GetFormListInAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormListInAppHeaders({ });
    return await this.getFormListInAppWithOptions(request, headers, runtime);
  }

  /**
   * 根据实例 ID 获取流程实例详情
   * 
   * @param request - GetInstanceByIdRequest
   * @param headers - GetInstanceByIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInstanceByIdResponse
   */
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

  /**
   * 根据实例 ID 获取流程实例详情
   * 
   * @param request - GetInstanceByIdRequest
   * @returns GetInstanceByIdResponse
   */
  async getInstanceById(id: string, request: GetInstanceByIdRequest): Promise<GetInstanceByIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstanceByIdHeaders({ });
    return await this.getInstanceByIdWithOptions(id, request, headers, runtime);
  }

  /**
   * 根据条件搜索流程实例 ID
   * 
   * @param request - GetInstanceIdListRequest
   * @param headers - GetInstanceIdListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInstanceIdListResponse
   */
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

  /**
   * 根据条件搜索流程实例 ID
   * 
   * @param request - GetInstanceIdListRequest
   * @returns GetInstanceIdListResponse
   */
  async getInstanceIdList(request: GetInstanceIdListRequest): Promise<GetInstanceIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstanceIdListHeaders({ });
    return await this.getInstanceIdListWithOptions(request, headers, runtime);
  }

  /**
   * 根据搜索条件获取流程表单实例详情
   * 
   * @param request - GetInstancesRequest
   * @param headers - GetInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInstancesResponse
   */
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

  /**
   * 根据搜索条件获取流程表单实例详情
   * 
   * @param request - GetInstancesRequest
   * @returns GetInstancesResponse
   */
  async getInstances(request: GetInstancesRequest): Promise<GetInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesHeaders({ });
    return await this.getInstancesWithOptions(request, headers, runtime);
  }

  /**
   * 根据实例 ID 列表批量获取流程实例详情
   * 
   * @param request - GetInstancesByIdListRequest
   * @param headers - GetInstancesByIdListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInstancesByIdListResponse
   */
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

  /**
   * 根据实例 ID 列表批量获取流程实例详情
   * 
   * @param request - GetInstancesByIdListRequest
   * @returns GetInstancesByIdListResponse
   */
  async getInstancesByIdList(request: GetInstancesByIdListRequest): Promise<GetInstancesByIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesByIdListHeaders({ });
    return await this.getInstancesByIdListWithOptions(request, headers, runtime);
  }

  /**
   * 查询已提交任务列表
   * 
   * @param request - GetMeCorpSubmissionRequest
   * @param headers - GetMeCorpSubmissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMeCorpSubmissionResponse
   */
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
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMeCorpSubmissionResponse>(await this.execute(params, req, runtime), new GetMeCorpSubmissionResponse({}));
  }

  /**
   * 查询已提交任务列表
   * 
   * @param request - GetMeCorpSubmissionRequest
   * @returns GetMeCorpSubmissionResponse
   */
  async getMeCorpSubmission(userId: string, request: GetMeCorpSubmissionRequest): Promise<GetMeCorpSubmissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMeCorpSubmissionHeaders({ });
    return await this.getMeCorpSubmissionWithOptions(userId, request, headers, runtime);
  }

  /**
   * 查询抄送我的任务列表（企业维度）
   * 
   * @param request - GetNotifyMeRequest
   * @param headers - GetNotifyMeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetNotifyMeResponse
   */
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

  /**
   * 查询抄送我的任务列表（企业维度）
   * 
   * @param request - GetNotifyMeRequest
   * @returns GetNotifyMeResponse
   */
  async getNotifyMe(userId: string, request: GetNotifyMeRequest): Promise<GetNotifyMeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNotifyMeHeaders({ });
    return await this.getNotifyMeWithOptions(userId, request, headers, runtime);
  }

  /**
   * 附件地址转临时免登地址
   * 
   * @param request - GetOpenUrlRequest
   * @param headers - GetOpenUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOpenUrlResponse
   */
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

  /**
   * 附件地址转临时免登地址
   * 
   * @param request - GetOpenUrlRequest
   * @returns GetOpenUrlResponse
   */
  async getOpenUrl(appType: string, request: GetOpenUrlRequest): Promise<GetOpenUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenUrlHeaders({ });
    return await this.getOpenUrlWithOptions(appType, request, headers, runtime);
  }

  /**
   * 获取审批记录
   * 
   * @param request - GetOperationRecordsRequest
   * @param headers - GetOperationRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOperationRecordsResponse
   */
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

  /**
   * 获取审批记录
   * 
   * @param request - GetOperationRecordsRequest
   * @returns GetOperationRecordsResponse
   */
  async getOperationRecords(request: GetOperationRecordsRequest): Promise<GetOperationRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOperationRecordsHeaders({ });
    return await this.getOperationRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道平台概览接口
   * 
   * @param request - GetPlatformResourceRequest
   * @param headers - GetPlatformResourceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPlatformResourceResponse
   */
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

  /**
   * 多渠道平台概览接口
   * 
   * @param request - GetPlatformResourceRequest
   * @returns GetPlatformResourceResponse
   */
  async getPlatformResource(request: GetPlatformResourceRequest): Promise<GetPlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPlatformResourceHeaders({ });
    return await this.getPlatformResourceWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户开通打印模板的应用信息
   * 
   * @param request - GetPrintAppInfoRequest
   * @param headers - GetPrintAppInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPrintAppInfoResponse
   */
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

  /**
   * 查询用户开通打印模板的应用信息
   * 
   * @param request - GetPrintAppInfoRequest
   * @returns GetPrintAppInfoResponse
   */
  async getPrintAppInfo(request: GetPrintAppInfoRequest): Promise<GetPrintAppInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrintAppInfoHeaders({ });
    return await this.getPrintAppInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取打印所需的表单与流程节点
   * 
   * @param request - GetPrintDictionaryRequest
   * @param headers - GetPrintDictionaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPrintDictionaryResponse
   */
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

  /**
   * 获取打印所需的表单与流程节点
   * 
   * @param request - GetPrintDictionaryRequest
   * @returns GetPrintDictionaryResponse
   */
  async getPrintDictionary(request: GetPrintDictionaryRequest): Promise<GetPrintDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrintDictionaryHeaders({ });
    return await this.getPrintDictionaryWithOptions(request, headers, runtime);
  }

  /**
   * 获取流程定义
   * 
   * @param request - GetProcessDefinitionRequest
   * @param headers - GetProcessDefinitionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProcessDefinitionResponse
   */
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

  /**
   * 获取流程定义
   * 
   * @param request - GetProcessDefinitionRequest
   * @returns GetProcessDefinitionResponse
   */
  async getProcessDefinition(processInstanceId: string, request: GetProcessDefinitionRequest): Promise<GetProcessDefinitionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessDefinitionHeaders({ });
    return await this.getProcessDefinitionWithOptions(processInstanceId, request, headers, runtime);
  }

  /**
   * 通过实例id批量获取待办任务
   * 
   * @param request - GetRunningTaskListRequest
   * @param headers - GetRunningTaskListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRunningTaskListResponse
   */
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

  /**
   * 通过实例id批量获取待办任务
   * 
   * @param request - GetRunningTaskListRequest
   * @returns GetRunningTaskListResponse
   */
  async getRunningTaskList(request: GetRunningTaskListRequest): Promise<GetRunningTaskListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTaskListHeaders({ });
    return await this.getRunningTaskListWithOptions(request, headers, runtime);
  }

  /**
   * 查询流程运行任务（vpc）
   * 
   * @param request - GetRunningTasksRequest
   * @param headers - GetRunningTasksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRunningTasksResponse
   */
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

  /**
   * 查询流程运行任务（vpc）
   * 
   * @param request - GetRunningTasksRequest
   * @returns GetRunningTasksResponse
   */
  async getRunningTasks(request: GetRunningTasksRequest): Promise<GetRunningTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTasksHeaders({ });
    return await this.getRunningTasksWithOptions(request, headers, runtime);
  }

  /**
   * 根据用户employeeCode获取所在企业信息(包含售卖版本)
   * 
   * @param request - GetSaleUserInfoByUserIdRequest
   * @param headers - GetSaleUserInfoByUserIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSaleUserInfoByUserIdResponse
   */
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

  /**
   * 根据用户employeeCode获取所在企业信息(包含售卖版本)
   * 
   * @param request - GetSaleUserInfoByUserIdRequest
   * @returns GetSaleUserInfoByUserIdResponse
   */
  async getSaleUserInfoByUserId(request: GetSaleUserInfoByUserIdRequest): Promise<GetSaleUserInfoByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSaleUserInfoByUserIdHeaders({ });
    return await this.getSaleUserInfoByUserIdWithOptions(request, headers, runtime);
  }

  /**
   * 表单的元数据(字段)查询接口
   * 
   * @param request - GetSimpleCubeModelListRequest
   * @param headers - GetSimpleCubeModelListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSimpleCubeModelListResponse
   */
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

  /**
   * 表单的元数据(字段)查询接口
   * 
   * @param request - GetSimpleCubeModelListRequest
   * @returns GetSimpleCubeModelListResponse
   */
  async getSimpleCubeModelList(request: GetSimpleCubeModelListRequest): Promise<GetSimpleCubeModelListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSimpleCubeModelListHeaders({ });
    return await this.getSimpleCubeModelListWithOptions(request, headers, runtime);
  }

  /**
   * 查询抄送我的任务列表（应用维度）
   * 
   * @param request - GetTaskCopiesRequest
   * @param headers - GetTaskCopiesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTaskCopiesResponse
   */
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

  /**
   * 查询抄送我的任务列表（应用维度）
   * 
   * @param request - GetTaskCopiesRequest
   * @returns GetTaskCopiesResponse
   */
  async getTaskCopies(request: GetTaskCopiesRequest): Promise<GetTaskCopiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskCopiesHeaders({ });
    return await this.getTaskCopiesWithOptions(request, headers, runtime);
  }

  /**
   * 获取组织下的宜搭应用列表
   * 
   * @param request - ListApplicationRequest
   * @param headers - ListApplicationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListApplicationResponse
   */
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

  /**
   * 获取组织下的宜搭应用列表
   * 
   * @param request - ListApplicationRequest
   * @returns ListApplicationResponse
   */
  async listApplication(request: ListApplicationRequest): Promise<ListApplicationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationHeaders({ });
    return await this.listApplicationWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道应用概览
   * 
   * @param request - ListApplicationAuthorizationServiceApplicationInformationRequest
   * @param headers - ListApplicationAuthorizationServiceApplicationInformationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListApplicationAuthorizationServiceApplicationInformationResponse
   */
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

  /**
   * 多渠道应用概览
   * 
   * @param request - ListApplicationAuthorizationServiceApplicationInformationRequest
   * @returns ListApplicationAuthorizationServiceApplicationInformationResponse
   */
  async listApplicationAuthorizationServiceApplicationInformation(instanceId: string, request: ListApplicationAuthorizationServiceApplicationInformationRequest): Promise<ListApplicationAuthorizationServiceApplicationInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders({ });
    return await this.listApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 多渠道插件概览
   * 
   * @param request - ListApplicationAuthorizationServiceConnectorInformationRequest
   * @param headers - ListApplicationAuthorizationServiceConnectorInformationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListApplicationAuthorizationServiceConnectorInformationResponse
   */
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

  /**
   * 多渠道插件概览
   * 
   * @param request - ListApplicationAuthorizationServiceConnectorInformationRequest
   * @returns ListApplicationAuthorizationServiceConnectorInformationResponse
   */
  async listApplicationAuthorizationServiceConnectorInformation(instanceId: string, request: ListApplicationAuthorizationServiceConnectorInformationRequest): Promise<ListApplicationAuthorizationServiceConnectorInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders({ });
    return await this.listApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 多渠道应用概览
   * 
   * @param request - ListApplicationInformationRequest
   * @param headers - ListApplicationInformationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListApplicationInformationResponse
   */
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

  /**
   * 多渠道应用概览
   * 
   * @param request - ListApplicationInformationRequest
   * @returns ListApplicationInformationResponse
   */
  async listApplicationInformation(instanceId: string, request: ListApplicationInformationRequest): Promise<ListApplicationInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationInformationHeaders({ });
    return await this.listApplicationInformationWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 多渠道列出商品列表
   * 
   * @param request - ListCommodityRequest
   * @param headers - ListCommodityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListCommodityResponse
   */
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

  /**
   * 多渠道列出商品列表
   * 
   * @param request - ListCommodityRequest
   * @returns ListCommodityResponse
   */
  async listCommodity(request: ListCommodityRequest): Promise<ListCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCommodityHeaders({ });
    return await this.listCommodityWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道插件概览
   * 
   * @param request - ListConnectorInformationRequest
   * @param headers - ListConnectorInformationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListConnectorInformationResponse
   */
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

  /**
   * 多渠道插件概览
   * 
   * @param request - ListConnectorInformationRequest
   * @returns ListConnectorInformationResponse
   */
  async listConnectorInformation(instanceId: string, request: ListConnectorInformationRequest): Promise<ListConnectorInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListConnectorInformationHeaders({ });
    return await this.listConnectorInformationWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 查询表单实例评论列表
   * 
   * @param request - ListFormRemarksRequest
   * @param headers - ListFormRemarksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListFormRemarksResponse
   */
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

  /**
   * 查询表单实例评论列表
   * 
   * @param request - ListFormRemarksRequest
   * @returns ListFormRemarksResponse
   */
  async listFormRemarks(request: ListFormRemarksRequest): Promise<ListFormRemarksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFormRemarksHeaders({ });
    return await this.listFormRemarksWithOptions(request, headers, runtime);
  }

  /**
   * 获取应用下的页面列表
   * 
   * @param request - ListNavigationByFormTypeRequest
   * @param headers - ListNavigationByFormTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListNavigationByFormTypeResponse
   */
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

  /**
   * 获取应用下的页面列表
   * 
   * @param request - ListNavigationByFormTypeRequest
   * @returns ListNavigationByFormTypeResponse
   */
  async listNavigationByFormType(request: ListNavigationByFormTypeRequest): Promise<ListNavigationByFormTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListNavigationByFormTypeHeaders({ });
    return await this.listNavigationByFormTypeWithOptions(request, headers, runtime);
  }

  /**
   * 查询表单的变更记录
   * 
   * @param request - ListOperationLogsRequest
   * @param headers - ListOperationLogsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListOperationLogsResponse
   */
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

  /**
   * 查询表单的变更记录
   * 
   * @param request - ListOperationLogsRequest
   * @returns ListOperationLogsResponse
   */
  async listOperationLogs(request: ListOperationLogsRequest): Promise<ListOperationLogsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListOperationLogsHeaders({ });
    return await this.listOperationLogsWithOptions(request, headers, runtime);
  }

  /**
   * 获取子表单数据
   * 
   * @param request - ListTableDataByFormInstanceIdTableIdRequest
   * @param headers - ListTableDataByFormInstanceIdTableIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListTableDataByFormInstanceIdTableIdResponse
   */
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

  /**
   * 获取子表单数据
   * 
   * @param request - ListTableDataByFormInstanceIdTableIdRequest
   * @returns ListTableDataByFormInstanceIdTableIdResponse
   */
  async listTableDataByFormInstanceIdTableId(formInstanceId: string, request: ListTableDataByFormInstanceIdTableIdRequest): Promise<ListTableDataByFormInstanceIdTableIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTableDataByFormInstanceIdTableIdHeaders({ });
    return await this.listTableDataByFormInstanceIdTableIdWithOptions(formInstanceId, request, headers, runtime);
  }

  /**
   * 生成宜搭登录态穿透用的code
   * 
   * @param request - LoginCodeGenRequest
   * @param headers - LoginCodeGenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LoginCodeGenResponse
   */
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

  /**
   * 生成宜搭登录态穿透用的code
   * 
   * @param request - LoginCodeGenRequest
   * @returns LoginCodeGenResponse
   */
  async loginCodeGen(request: LoginCodeGenRequest): Promise<LoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoginCodeGenHeaders({ });
    return await this.loginCodeGenWithOptions(request, headers, runtime);
  }

  /**
   * 通知宜搭授权(购买)结果
   * 
   * @param request - NotifyAuthorizationResultRequest
   * @param headers - NotifyAuthorizationResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns NotifyAuthorizationResultResponse
   */
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

  /**
   * 通知宜搭授权(购买)结果
   * 
   * @param request - NotifyAuthorizationResultRequest
   * @returns NotifyAuthorizationResultResponse
   */
  async notifyAuthorizationResult(request: NotifyAuthorizationResultRequest): Promise<NotifyAuthorizationResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyAuthorizationResultHeaders({ });
    return await this.notifyAuthorizationResultWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询宜搭流程自动化运行记录
   * 
   * @param request - PageAutoFlowLogRequest
   * @param headers - PageAutoFlowLogHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PageAutoFlowLogResponse
   */
  async pageAutoFlowLogWithOptions(request: PageAutoFlowLogRequest, headers: PageAutoFlowLogHeaders, runtime: $Util.RuntimeOptions): Promise<PageAutoFlowLogResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.startTimeGMT)) {
      body["startTimeGMT"] = request.startTimeGMT;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.token)) {
      body["token"] = request.token;
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
      action: "PageAutoFlowLog",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/logs/automations/paginationQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PageAutoFlowLogResponse>(await this.execute(params, req, runtime), new PageAutoFlowLogResponse({}));
  }

  /**
   * 分页查询宜搭流程自动化运行记录
   * 
   * @param request - PageAutoFlowLogRequest
   * @returns PageAutoFlowLogResponse
   */
  async pageAutoFlowLog(request: PageAutoFlowLogRequest): Promise<PageAutoFlowLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageAutoFlowLogHeaders({ });
    return await this.pageAutoFlowLogWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取应用下表单列表
   * 
   * @param request - PageFormBaseInfosRequest
   * @param headers - PageFormBaseInfosHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PageFormBaseInfosResponse
   */
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

  /**
   * 分页获取应用下表单列表
   * 
   * @param request - PageFormBaseInfosRequest
   * @returns PageFormBaseInfosResponse
   */
  async pageFormBaseInfos(request: PageFormBaseInfosRequest): Promise<PageFormBaseInfosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageFormBaseInfosHeaders({ });
    return await this.pageFormBaseInfosWithOptions(request, headers, runtime);
  }

  /**
   * 预览审批流程
   * 
   * @param request - PreviewPublishedProcessRequest
   * @param headers - PreviewPublishedProcessHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PreviewPublishedProcessResponse
   */
  async previewPublishedProcessWithOptions(request: PreviewPublishedProcessRequest, headers: PreviewPublishedProcessHeaders, runtime: $Util.RuntimeOptions): Promise<PreviewPublishedProcessResponse> {
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
      action: "PreviewPublishedProcess",
      version: "yida_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yida/processes/preview`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PreviewPublishedProcessResponse>(await this.execute(params, req, runtime), new PreviewPublishedProcessResponse({}));
  }

  /**
   * 预览审批流程
   * 
   * @param request - PreviewPublishedProcessRequest
   * @returns PreviewPublishedProcessResponse
   */
  async previewPublishedProcess(request: PreviewPublishedProcessRequest): Promise<PreviewPublishedProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PreviewPublishedProcessHeaders({ });
    return await this.previewPublishedProcessWithOptions(request, headers, runtime);
  }

  /**
   * 查询服务调用记录
   * 
   * @param request - QueryServiceRecordRequest
   * @param headers - QueryServiceRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryServiceRecordResponse
   */
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

  /**
   * 查询服务调用记录
   * 
   * @param request - QueryServiceRecordRequest
   * @returns QueryServiceRecordResponse
   */
  async queryServiceRecord(request: QueryServiceRecordRequest): Promise<QueryServiceRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryServiceRecordHeaders({ });
    return await this.queryServiceRecordWithOptions(request, headers, runtime);
  }

  /**
   * 执行转交任务
   * 
   * @param request - RedirectTaskRequest
   * @param headers - RedirectTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RedirectTaskResponse
   */
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

  /**
   * 执行转交任务
   * 
   * @param request - RedirectTaskRequest
   * @returns RedirectTaskResponse
   */
  async redirectTask(request: RedirectTaskRequest): Promise<RedirectTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RedirectTaskHeaders({ });
    return await this.redirectTaskWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道退款
   * 
   * @param request - RefundCommodityRequest
   * @param headers - RefundCommodityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RefundCommodityResponse
   */
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

  /**
   * 多渠道退款
   * 
   * @param request - RefundCommodityRequest
   * @returns RefundCommodityResponse
   */
  async refundCommodity(request: RefundCommodityRequest): Promise<RefundCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RefundCommodityHeaders({ });
    return await this.refundCommodityWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道注册
   * 
   * @param request - RegisterAccountsRequest
   * @param headers - RegisterAccountsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RegisterAccountsResponse
   */
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

  /**
   * 多渠道注册
   * 
   * @param request - RegisterAccountsRequest
   * @returns RegisterAccountsResponse
   */
  async registerAccounts(request: RegisterAccountsRequest): Promise<RegisterAccountsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAccountsHeaders({ });
    return await this.registerAccountsWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道释放
   * 
   * @param request - ReleaseCommodityRequest
   * @param headers - ReleaseCommodityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReleaseCommodityResponse
   */
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

  /**
   * 多渠道释放
   * 
   * @param request - ReleaseCommodityRequest
   * @returns ReleaseCommodityResponse
   */
  async releaseCommodity(request: ReleaseCommodityRequest): Promise<ReleaseCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseCommodityHeaders({ });
    return await this.releaseCommodityWithOptions(request, headers, runtime);
  }

  /**
   * 租户到期30天后, 删除租户关联的资源
   * 
   * @param request - RemoveTenantResourceRequest
   * @param headers - RemoveTenantResourceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveTenantResourceResponse
   */
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

  /**
   * 租户到期30天后, 删除租户关联的资源
   * 
   * @param request - RemoveTenantResourceRequest
   * @returns RemoveTenantResourceResponse
   */
  async removeTenantResource(callerUid: string, request: RemoveTenantResourceRequest): Promise<RemoveTenantResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveTenantResourceHeaders({ });
    return await this.removeTenantResourceWithOptions(callerUid, request, headers, runtime);
  }

  /**
   * 宜搭vpc批量打印回调
   * 
   * @param request - RenderBatchCallbackRequest
   * @param headers - RenderBatchCallbackHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RenderBatchCallbackResponse
   */
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

  /**
   * 宜搭vpc批量打印回调
   * 
   * @param request - RenderBatchCallbackRequest
   * @returns RenderBatchCallbackResponse
   */
  async renderBatchCallback(request: RenderBatchCallbackRequest): Promise<RenderBatchCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenderBatchCallbackHeaders({ });
    return await this.renderBatchCallbackWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道续费
   * 
   * @param request - RenewApplicationAuthorizationServiceOrderRequest
   * @param headers - RenewApplicationAuthorizationServiceOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RenewApplicationAuthorizationServiceOrderResponse
   */
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

  /**
   * 多渠道续费
   * 
   * @param request - RenewApplicationAuthorizationServiceOrderRequest
   * @returns RenewApplicationAuthorizationServiceOrderResponse
   */
  async renewApplicationAuthorizationServiceOrder(request: RenewApplicationAuthorizationServiceOrderRequest): Promise<RenewApplicationAuthorizationServiceOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenewApplicationAuthorizationServiceOrderHeaders({ });
    return await this.renewApplicationAuthorizationServiceOrderWithOptions(request, headers, runtime);
  }

  /**
   * 续费租户
   * 
   * @param request - RenewTenantOrderRequest
   * @param headers - RenewTenantOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RenewTenantOrderResponse
   */
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

  /**
   * 续费租户
   * 
   * @param request - RenewTenantOrderRequest
   * @returns RenewTenantOrderResponse
   */
  async renewTenantOrder(request: RenewTenantOrderRequest): Promise<RenewTenantOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenewTenantOrderHeaders({ });
    return await this.renewTenantOrderWithOptions(request, headers, runtime);
  }

  /**
   * 新增表单实例
   * 
   * @param request - SaveFormDataRequest
   * @param headers - SaveFormDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveFormDataResponse
   */
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

  /**
   * 新增表单实例
   * 
   * @param request - SaveFormDataRequest
   * @returns SaveFormDataResponse
   */
  async saveFormData(request: SaveFormDataRequest): Promise<SaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormDataHeaders({ });
    return await this.saveFormDataWithOptions(request, headers, runtime);
  }

  /**
   * 提交表单/流程实例下的评论
   * 
   * @param request - SaveFormRemarkRequest
   * @param headers - SaveFormRemarkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveFormRemarkResponse
   */
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

  /**
   * 提交表单/流程实例下的评论
   * 
   * @param request - SaveFormRemarkRequest
   * @returns SaveFormRemarkResponse
   */
  async saveFormRemark(request: SaveFormRemarkRequest): Promise<SaveFormRemarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormRemarkHeaders({ });
    return await this.saveFormRemarkWithOptions(request, headers, runtime);
  }

  /**
   * 保存用户设计的模板结构
   * 
   * @param request - SavePrintTplDetailInfoRequest
   * @param headers - SavePrintTplDetailInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SavePrintTplDetailInfoResponse
   */
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

  /**
   * 保存用户设计的模板结构
   * 
   * @param request - SavePrintTplDetailInfoRequest
   * @returns SavePrintTplDetailInfoResponse
   */
  async savePrintTplDetailInfo(request: SavePrintTplDetailInfoRequest): Promise<SavePrintTplDetailInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SavePrintTplDetailInfoHeaders({ });
    return await this.savePrintTplDetailInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取阿里云账号购买宜搭的账号信息
   * 
   * @param request - SearchActivationCodeRequest
   * @param headers - SearchActivationCodeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchActivationCodeResponse
   */
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

  /**
   * 获取阿里云账号购买宜搭的账号信息
   * 
   * @param request - SearchActivationCodeRequest
   * @returns SearchActivationCodeResponse
   */
  async searchActivationCode(request: SearchActivationCodeRequest): Promise<SearchActivationCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchActivationCodeHeaders({ });
    return await this.searchActivationCodeWithOptions(request, headers, runtime);
  }

  /**
   * 搜索表单中指定人员组件的值
   * 
   * @param request - SearchEmployeeFieldValuesRequest
   * @param headers - SearchEmployeeFieldValuesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchEmployeeFieldValuesResponse
   */
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

  /**
   * 搜索表单中指定人员组件的值
   * 
   * @param request - SearchEmployeeFieldValuesRequest
   * @returns SearchEmployeeFieldValuesResponse
   */
  async searchEmployeeFieldValues(request: SearchEmployeeFieldValuesRequest): Promise<SearchEmployeeFieldValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchEmployeeFieldValuesHeaders({ });
    return await this.searchEmployeeFieldValuesWithOptions(request, headers, runtime);
  }

  /**
   * 根据条件搜索表单实例 ID 列表
   * 
   * @param request - SearchFormDataIdListRequest
   * @param headers - SearchFormDataIdListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchFormDataIdListResponse
   */
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

  /**
   * 根据条件搜索表单实例 ID 列表
   * 
   * @param request - SearchFormDataIdListRequest
   * @returns SearchFormDataIdListResponse
   */
  async searchFormDataIdList(appType: string, formUuid: string, request: SearchFormDataIdListRequest): Promise<SearchFormDataIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataIdListHeaders({ });
    return await this.searchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
  }

  /**
   * 查询表单实例数据(不返回表单的子表单组件数据)
   * 
   * @param request - SearchFormDataRemovalTableDataRequest
   * @param headers - SearchFormDataRemovalTableDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchFormDataRemovalTableDataResponse
   */
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

  /**
   * 查询表单实例数据(不返回表单的子表单组件数据)
   * 
   * @param request - SearchFormDataRemovalTableDataRequest
   * @returns SearchFormDataRemovalTableDataResponse
   */
  async searchFormDataRemovalTableData(request: SearchFormDataRemovalTableDataRequest): Promise<SearchFormDataRemovalTableDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataRemovalTableDataHeaders({ });
    return await this.searchFormDataRemovalTableDataWithOptions(request, headers, runtime);
  }

  /**
   * 通过高级检索条件查询表单实例
   * 
   * @param request - SearchFormDataSecondGenerationRequest
   * @param headers - SearchFormDataSecondGenerationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchFormDataSecondGenerationResponse
   */
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

  /**
   * 通过高级检索条件查询表单实例
   * 
   * @param request - SearchFormDataSecondGenerationRequest
   * @returns SearchFormDataSecondGenerationResponse
   */
  async searchFormDataSecondGeneration(request: SearchFormDataSecondGenerationRequest): Promise<SearchFormDataSecondGenerationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataSecondGenerationHeaders({ });
    return await this.searchFormDataSecondGenerationWithOptions(request, headers, runtime);
  }

  /**
   * 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
   * 
   * @param request - SearchFormDataSecondGenerationNoTableFieldRequest
   * @param headers - SearchFormDataSecondGenerationNoTableFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchFormDataSecondGenerationNoTableFieldResponse
   */
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

  /**
   * 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
   * 
   * @param request - SearchFormDataSecondGenerationNoTableFieldRequest
   * @returns SearchFormDataSecondGenerationNoTableFieldResponse
   */
  async searchFormDataSecondGenerationNoTableField(request: SearchFormDataSecondGenerationNoTableFieldRequest): Promise<SearchFormDataSecondGenerationNoTableFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataSecondGenerationNoTableFieldHeaders({ });
    return await this.searchFormDataSecondGenerationNoTableFieldWithOptions(request, headers, runtime);
  }

  /**
   * 根据条件搜索表单实例详情列表,对应原searchFormDatas
   * 
   * @param request - SearchFormDatasRequest
   * @param headers - SearchFormDatasHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchFormDatasResponse
   */
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

  /**
   * 根据条件搜索表单实例详情列表,对应原searchFormDatas
   * 
   * @param request - SearchFormDatasRequest
   * @returns SearchFormDatasResponse
   */
  async searchFormDatas(request: SearchFormDatasRequest): Promise<SearchFormDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDatasHeaders({ });
    return await this.searchFormDatasWithOptions(request, headers, runtime);
  }

  /**
   * 发起新的流程实例
   * 
   * @param request - StartInstanceRequest
   * @param headers - StartInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StartInstanceResponse
   */
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

    if (!Util.isUnset(request.processData)) {
      body["processData"] = request.processData;
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

  /**
   * 发起新的流程实例
   * 
   * @param request - StartInstanceRequest
   * @returns StartInstanceResponse
   */
  async startInstance(request: StartInstanceRequest): Promise<StartInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartInstanceHeaders({ });
    return await this.startInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 阿里云合同到期终止
   * 
   * @param request - TerminateCloudAuthorizationRequest
   * @param headers - TerminateCloudAuthorizationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TerminateCloudAuthorizationResponse
   */
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

  /**
   * 阿里云合同到期终止
   * 
   * @param request - TerminateCloudAuthorizationRequest
   * @returns TerminateCloudAuthorizationResponse
   */
  async terminateCloudAuthorization(request: TerminateCloudAuthorizationRequest): Promise<TerminateCloudAuthorizationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateCloudAuthorizationHeaders({ });
    return await this.terminateCloudAuthorizationWithOptions(request, headers, runtime);
  }

  /**
   * 终止流程实例
   * 
   * @param request - TerminateInstanceRequest
   * @param headers - TerminateInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TerminateInstanceResponse
   */
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

  /**
   * 终止流程实例
   * 
   * @param request - TerminateInstanceRequest
   * @returns TerminateInstanceResponse
   */
  async terminateInstance(request: TerminateInstanceRequest): Promise<TerminateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateInstanceHeaders({ });
    return await this.terminateInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 变配阿里云账号对应的租户信息
   * 
   * @param request - UpdateCloudAccountInformationRequest
   * @param headers - UpdateCloudAccountInformationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateCloudAccountInformationResponse
   */
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

  /**
   * 变配阿里云账号对应的租户信息
   * 
   * @param request - UpdateCloudAccountInformationRequest
   * @returns UpdateCloudAccountInformationResponse
   */
  async updateCloudAccountInformation(request: UpdateCloudAccountInformationRequest): Promise<UpdateCloudAccountInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCloudAccountInformationHeaders({ });
    return await this.updateCloudAccountInformationWithOptions(request, headers, runtime);
  }

  /**
   * 更新表单实例
   * 
   * @param request - UpdateFormDataRequest
   * @param headers - UpdateFormDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateFormDataResponse
   */
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

  /**
   * 更新表单实例
   * 
   * @param request - UpdateFormDataRequest
   * @returns UpdateFormDataResponse
   */
  async updateFormData(request: UpdateFormDataRequest): Promise<UpdateFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFormDataHeaders({ });
    return await this.updateFormDataWithOptions(request, headers, runtime);
  }

  /**
   * 更新流程实例
   * 
   * @param request - UpdateInstanceRequest
   * @param headers - UpdateInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInstanceResponse
   */
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

  /**
   * 更新流程实例
   * 
   * @param request - UpdateInstanceRequest
   * @returns UpdateInstanceResponse
   */
  async updateInstance(request: UpdateInstanceRequest): Promise<UpdateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceHeaders({ });
    return await this.updateInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 未知
   * 
   * @param request - UpdateStatusRequest
   * @param headers - UpdateStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateStatusResponse
   */
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

  /**
   * 未知
   * 
   * @param request - UpdateStatusRequest
   * @returns UpdateStatusResponse
   */
  async updateStatus(request: UpdateStatusRequest): Promise<UpdateStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStatusHeaders({ });
    return await this.updateStatusWithOptions(request, headers, runtime);
  }

  /**
   * 变配阿里云账号对应的租户信息
   * 
   * @param request - UpgradeTenantInformationRequest
   * @param headers - UpgradeTenantInformationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpgradeTenantInformationResponse
   */
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

  /**
   * 变配阿里云账号对应的租户信息
   * 
   * @param request - UpgradeTenantInformationRequest
   * @returns UpgradeTenantInformationResponse
   */
  async upgradeTenantInformation(request: UpgradeTenantInformationRequest): Promise<UpgradeTenantInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeTenantInformationHeaders({ });
    return await this.upgradeTenantInformationWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道续费前校验
   * 
   * @param request - ValidateApplicationAuthorizationOrderRequest
   * @param headers - ValidateApplicationAuthorizationOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ValidateApplicationAuthorizationOrderResponse
   */
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

  /**
   * 多渠道续费前校验
   * 
   * @param request - ValidateApplicationAuthorizationOrderRequest
   * @returns ValidateApplicationAuthorizationOrderResponse
   */
  async validateApplicationAuthorizationOrder(instanceId: string, request: ValidateApplicationAuthorizationOrderRequest): Promise<ValidateApplicationAuthorizationOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationAuthorizationOrderHeaders({ });
    return await this.validateApplicationAuthorizationOrderWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 多渠道新购校验
   * 
   * @param request - ValidateApplicationAuthorizationServiceOrderRequest
   * @param headers - ValidateApplicationAuthorizationServiceOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ValidateApplicationAuthorizationServiceOrderResponse
   */
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

  /**
   * 多渠道新购校验
   * 
   * @param request - ValidateApplicationAuthorizationServiceOrderRequest
   * @returns ValidateApplicationAuthorizationServiceOrderResponse
   */
  async validateApplicationAuthorizationServiceOrder(callerUid: string, request: ValidateApplicationAuthorizationServiceOrderRequest): Promise<ValidateApplicationAuthorizationServiceOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationAuthorizationServiceOrderHeaders({ });
    return await this.validateApplicationAuthorizationServiceOrderWithOptions(callerUid, request, headers, runtime);
  }

  /**
   * 校验变配
   * 
   * @param request - ValidateApplicationServiceOrderUpgradeRequest
   * @param headers - ValidateApplicationServiceOrderUpgradeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ValidateApplicationServiceOrderUpgradeResponse
   */
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

  /**
   * 校验变配
   * 
   * @param request - ValidateApplicationServiceOrderUpgradeRequest
   * @returns ValidateApplicationServiceOrderUpgradeResponse
   */
  async validateApplicationServiceOrderUpgrade(callerUnionid: string, request: ValidateApplicationServiceOrderUpgradeRequest): Promise<ValidateApplicationServiceOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationServiceOrderUpgradeHeaders({ });
    return await this.validateApplicationServiceOrderUpgradeWithOptions(callerUnionid, request, headers, runtime);
  }

  /**
   * 多渠道新购校验
   * 
   * @param request - ValidateOrderBuyRequest
   * @param headers - ValidateOrderBuyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ValidateOrderBuyResponse
   */
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

  /**
   * 多渠道新购校验
   * 
   * @param request - ValidateOrderBuyRequest
   * @returns ValidateOrderBuyResponse
   */
  async validateOrderBuy(request: ValidateOrderBuyRequest): Promise<ValidateOrderBuyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderBuyHeaders({ });
    return await this.validateOrderBuyWithOptions(request, headers, runtime);
  }

  /**
   * 多渠道续费前校验
   * 
   * @param request - ValidateOrderUpdateRequest
   * @param headers - ValidateOrderUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ValidateOrderUpdateResponse
   */
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

  /**
   * 多渠道续费前校验
   * 
   * @param request - ValidateOrderUpdateRequest
   * @returns ValidateOrderUpdateResponse
   */
  async validateOrderUpdate(instanceId: string, request: ValidateOrderUpdateRequest): Promise<ValidateOrderUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpdateHeaders({ });
    return await this.validateOrderUpdateWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 多渠道升配前校验
   * 
   * @param request - ValidateOrderUpgradeRequest
   * @param headers - ValidateOrderUpgradeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ValidateOrderUpgradeResponse
   */
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

  /**
   * 多渠道升配前校验
   * 
   * @param request - ValidateOrderUpgradeRequest
   * @returns ValidateOrderUpgradeResponse
   */
  async validateOrderUpgrade(request: ValidateOrderUpgradeRequest): Promise<ValidateOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpgradeHeaders({ });
    return await this.validateOrderUpgradeWithOptions(request, headers, runtime);
  }

}
