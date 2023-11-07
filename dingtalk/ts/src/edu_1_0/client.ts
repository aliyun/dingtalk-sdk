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

export class ActivateDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ActivateDeviceRequest extends $tea.Model {
  licenseKey?: string;
  model?: string;
  name?: string;
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      licenseKey: 'licenseKey',
      model: 'model',
      name: 'name',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      licenseKey: 'string',
      model: 'string',
      name: 'string',
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ActivateDeviceResponseBody extends $tea.Model {
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

export class ActivateDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ActivateDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ActivateDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDeviceRequest extends $tea.Model {
  merchantId?: string;
  model?: string;
  name?: string;
  scene?: number;
  sn?: string;
  status?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      merchantId: 'merchantId',
      model: 'model',
      name: 'name',
      scene: 'scene',
      sn: 'sn',
      status: 'status',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      merchantId: 'string',
      model: 'string',
      name: 'string',
      scene: 'number',
      sn: 'string',
      status: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDeviceResponseBody extends $tea.Model {
  corpId?: string;
  id?: number;
  merchantId?: string;
  sn?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      merchantId: 'merchantId',
      sn: 'sn',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'number',
      merchantId: 'string',
      sn: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AddDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSchoolConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSchoolConfigRequest extends $tea.Model {
  operatorId?: string;
  operatorName?: string;
  temperatureUpLimit?: number;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      operatorName: 'operatorName',
      temperatureUpLimit: 'temperatureUpLimit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      operatorName: 'string',
      temperatureUpLimit: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSchoolConfigResponseBody extends $tea.Model {
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

export class AddSchoolConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddSchoolConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AddSchoolConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignClassRequest extends $tea.Model {
  classId?: number;
  isFinish?: boolean;
  operator?: string;
  studentId?: number;
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      isFinish: 'isFinish',
      operator: 'operator',
      studentId: 'studentId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      isFinish: 'boolean',
      operator: 'string',
      studentId: 'number',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignClassResponseBody extends $tea.Model {
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

export class AssignClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AssignClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AssignClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequest extends $tea.Model {
  cardBizCode?: string;
  data?: BatchCreateRequestData;
  identifier?: string;
  jsVersion?: number;
  sourceType?: string;
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      data: 'data',
      identifier: 'identifier',
      jsVersion: 'jsVersion',
      sourceType: 'sourceType',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      data: BatchCreateRequestData,
      identifier: 'string',
      jsVersion: 'number',
      sourceType: 'string',
      userid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateResponseBody extends $tea.Model {
  result?: BatchCreateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchCreateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequest extends $tea.Model {
  attributes?: string;
  bizCode?: string;
  courseName?: string;
  hwContent?: string;
  hwDeadline?: number;
  hwDeadlineOpen?: string;
  hwMedia?: string;
  hwPhoto?: string;
  hwTitle?: string;
  hwType?: string;
  hwVideo?: string;
  identifier?: string;
  openSelectItemList?: BatchOrgCreateHWRequestOpenSelectItemList[];
  scheduledRelease?: string;
  scheduledTime?: string;
  status?: string;
  targetRole?: string;
  teacherName?: string;
  teacherUserId?: string;
  static names(): { [key: string]: string } {
    return {
      attributes: 'attributes',
      bizCode: 'bizCode',
      courseName: 'courseName',
      hwContent: 'hwContent',
      hwDeadline: 'hwDeadline',
      hwDeadlineOpen: 'hwDeadlineOpen',
      hwMedia: 'hwMedia',
      hwPhoto: 'hwPhoto',
      hwTitle: 'hwTitle',
      hwType: 'hwType',
      hwVideo: 'hwVideo',
      identifier: 'identifier',
      openSelectItemList: 'openSelectItemList',
      scheduledRelease: 'scheduledRelease',
      scheduledTime: 'scheduledTime',
      status: 'status',
      targetRole: 'targetRole',
      teacherName: 'teacherName',
      teacherUserId: 'teacherUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attributes: 'string',
      bizCode: 'string',
      courseName: 'string',
      hwContent: 'string',
      hwDeadline: 'number',
      hwDeadlineOpen: 'string',
      hwMedia: 'string',
      hwPhoto: 'string',
      hwTitle: 'string',
      hwType: 'string',
      hwVideo: 'string',
      identifier: 'string',
      openSelectItemList: { 'type': 'array', 'itemType': BatchOrgCreateHWRequestOpenSelectItemList },
      scheduledRelease: 'string',
      scheduledTime: 'string',
      status: 'string',
      targetRole: 'string',
      teacherName: 'string',
      teacherUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponseBody extends $tea.Model {
  result?: BatchOrgCreateHWResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchOrgCreateHWResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchOrgCreateHWResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchOrgCreateHWResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelOrderRequest extends $tea.Model {
  faceId?: string;
  orderNo?: string;
  signature?: string;
  sn?: string;
  timestamp?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      orderNo: 'orderNo',
      signature: 'signature',
      sn: 'sn',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      orderNo: 'string',
      signature: 'string',
      sn: 'string',
      timestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelOrderResponseBody extends $tea.Model {
  needRetry?: boolean;
  tradeAction?: string;
  static names(): { [key: string]: string } {
    return {
      needRetry: 'needRetry',
      tradeAction: 'tradeAction',
    };
  }

  static types(): { [key: string]: any } {
    return {
      needRetry: 'boolean',
      tradeAction: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CancelOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CancelOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelSnsOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelSnsOrderRequest extends $tea.Model {
  alipayAppId?: string;
  merchantId?: string;
  orderNo?: string;
  signature?: string;
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      alipayAppId: 'alipayAppId',
      merchantId: 'merchantId',
      orderNo: 'orderNo',
      signature: 'signature',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayAppId: 'string',
      merchantId: 'string',
      orderNo: 'string',
      signature: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelSnsOrderResponseBody extends $tea.Model {
  alipayAppId?: string;
  merchantId?: string;
  merchantOrderNo?: string;
  orderNo?: string;
  payStatus?: number;
  refundStatus?: number;
  totalAmount?: number;
  static names(): { [key: string]: string } {
    return {
      alipayAppId: 'alipayAppId',
      merchantId: 'merchantId',
      merchantOrderNo: 'merchantOrderNo',
      orderNo: 'orderNo',
      payStatus: 'payStatus',
      refundStatus: 'refundStatus',
      totalAmount: 'totalAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayAppId: 'string',
      merchantId: 'string',
      merchantOrderNo: 'string',
      orderNo: 'string',
      payStatus: 'number',
      refundStatus: 'number',
      totalAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelSnsOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CancelSnsOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CancelSnsOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelUserOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelUserOrderRequest extends $tea.Model {
  alipayAppId?: string;
  merchantId?: string;
  orderNo?: string;
  signature?: string;
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      alipayAppId: 'alipayAppId',
      merchantId: 'merchantId',
      orderNo: 'orderNo',
      signature: 'signature',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayAppId: 'string',
      merchantId: 'string',
      orderNo: 'string',
      signature: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelUserOrderResponseBody extends $tea.Model {
  alipayAppId?: string;
  merchantId?: string;
  merchantOrderNo?: string;
  orderNo?: string;
  payStatus?: number;
  refundStatus?: number;
  totalAmount?: number;
  static names(): { [key: string]: string } {
    return {
      alipayAppId: 'alipayAppId',
      merchantId: 'merchantId',
      merchantOrderNo: 'merchantOrderNo',
      orderNo: 'orderNo',
      payStatus: 'payStatus',
      refundStatus: 'refundStatus',
      totalAmount: 'totalAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayAppId: 'string',
      merchantId: 'string',
      merchantOrderNo: 'string',
      orderNo: 'string',
      payStatus: 'number',
      refundStatus: 'number',
      totalAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelUserOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CancelUserOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CancelUserOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardBatchQueryCardsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardBatchQueryCardsRequest extends $tea.Model {
  cardBizCode?: string;
  cardIds?: number[];
  sourceType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      cardIds: 'cardIds',
      sourceType: 'sourceType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      cardIds: { 'type': 'array', 'itemType': 'number' },
      sourceType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardBatchQueryCardsResponseBody extends $tea.Model {
  result?: CardBatchQueryCardsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CardBatchQueryCardsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardBatchQueryCardsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CardBatchQueryCardsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CardBatchQueryCardsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardDeleteCardHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardDeleteCardRequest extends $tea.Model {
  cardBizCode?: string;
  cardBizId?: string;
  cardId?: number;
  sourceType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      cardBizId: 'cardBizId',
      cardId: 'cardId',
      sourceType: 'sourceType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      cardBizId: 'string',
      cardId: 'number',
      sourceType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardDeleteCardResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardDeleteCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CardDeleteCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CardDeleteCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardEndCardHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardEndCardRequest extends $tea.Model {
  cardBizCode?: string;
  cardBizId?: string;
  cardId?: number;
  sourceType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      cardBizId: 'cardBizId',
      cardId: 'cardId',
      sourceType: 'sourceType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      cardBizId: 'string',
      cardId: 'number',
      sourceType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardEndCardResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardEndCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CardEndCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CardEndCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardRequest extends $tea.Model {
  cardId?: number;
  sourceType?: string;
  static names(): { [key: string]: string } {
    return {
      cardId: 'cardId',
      sourceType: 'sourceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardId: 'number',
      sourceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardResponseBody extends $tea.Model {
  result?: CardGetCardResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CardGetCardResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CardGetCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CardGetCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressRequest extends $tea.Model {
  cardBizCode?: string;
  cardBizId?: string;
  cardId?: number;
  sourceType?: string;
  studentId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      cardBizId: 'cardBizId',
      cardId: 'cardId',
      sourceType: 'sourceType',
      studentId: 'studentId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      cardBizId: 'string',
      cardId: 'number',
      sourceType: 'string',
      studentId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressResponseBody extends $tea.Model {
  result?: CardGetCardFinishProgressResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CardGetCardFinishProgressResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CardGetCardFinishProgressResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CardGetCardFinishProgressResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsRequest extends $tea.Model {
  bizType?: number;
  cardBizCode?: string;
  cardBizId?: string;
  cardId?: number;
  count?: number;
  cursor?: number;
  feedType?: number;
  needFinishProcess?: boolean;
  sourceType?: string;
  studentId?: string;
  subBizId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      cardBizCode: 'cardBizCode',
      cardBizId: 'cardBizId',
      cardId: 'cardId',
      count: 'count',
      cursor: 'cursor',
      feedType: 'feedType',
      needFinishProcess: 'needFinishProcess',
      sourceType: 'sourceType',
      studentId: 'studentId',
      subBizId: 'subBizId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      cardBizCode: 'string',
      cardBizId: 'string',
      cardId: 'number',
      count: 'number',
      cursor: 'number',
      feedType: 'number',
      needFinishProcess: 'boolean',
      sourceType: 'string',
      studentId: 'string',
      subBizId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsResponseBody extends $tea.Model {
  result?: CardQueryCardFeedsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CardQueryCardFeedsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CardQueryCardFeedsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CardQueryCardFeedsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckRestrictionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckRestrictionRequest extends $tea.Model {
  actualAmount?: number;
  faceId?: string;
  scene?: number;
  sn?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      faceId: 'faceId',
      scene: 'scene',
      sn: 'sn',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      faceId: 'string',
      scene: 'number',
      sn: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckRestrictionResponseBody extends $tea.Model {
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

export class CheckRestrictionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CheckRestrictionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CheckRestrictionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointRequest extends $tea.Model {
  amount?: number;
  bizId?: string;
  description?: string;
  productCode?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      bizId: 'bizId',
      description: 'description',
      productCode: 'productCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
      bizId: 'string',
      description: 'string',
      productCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumePointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ConsumePointResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ConsumePointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CourseSchedulingComplimentNoticeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CourseSchedulingComplimentNoticeRequest extends $tea.Model {
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CourseSchedulingComplimentNoticeResponseBody extends $tea.Model {
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

export class CourseSchedulingComplimentNoticeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CourseSchedulingComplimentNoticeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CourseSchedulingComplimentNoticeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppOrderRequest extends $tea.Model {
  actualAmount?: number;
  alipayAppId?: string;
  bizCode?: number;
  detailList?: CreateAppOrderRequestDetailList[];
  labelAmount?: number;
  merchantId?: string;
  merchantOrderNo?: string;
  outerUserId?: string;
  signature?: string;
  subject?: string;
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayAppId: 'alipayAppId',
      bizCode: 'bizCode',
      detailList: 'detailList',
      labelAmount: 'labelAmount',
      merchantId: 'merchantId',
      merchantOrderNo: 'merchantOrderNo',
      outerUserId: 'outerUserId',
      signature: 'signature',
      subject: 'subject',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayAppId: 'string',
      bizCode: 'number',
      detailList: { 'type': 'array', 'itemType': CreateAppOrderRequestDetailList },
      labelAmount: 'number',
      merchantId: 'string',
      merchantOrderNo: 'string',
      outerUserId: 'string',
      signature: 'string',
      subject: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppOrderResponseBody extends $tea.Model {
  actualAmount?: number;
  alipayAppId?: string;
  body?: string;
  merchantId?: string;
  merchantOrderNo?: string;
  orderNo?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayAppId: 'alipayAppId',
      body: 'body',
      merchantId: 'merchantId',
      merchantOrderNo: 'merchantOrderNo',
      orderNo: 'orderNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayAppId: 'string',
      body: 'string',
      merchantId: 'string',
      merchantOrderNo: 'string',
      orderNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateAppOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateAppOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassRequest extends $tea.Model {
  customClass?: CreateCustomClassRequestCustomClass;
  operator?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      customClass: 'customClass',
      operator: 'operator',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customClass: CreateCustomClassRequestCustomClass,
      operator: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassResponseBody extends $tea.Model {
  result?: CreateCustomClassResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateCustomClassResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateCustomClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateCustomClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptRequest extends $tea.Model {
  customDept?: CreateCustomDeptRequestCustomDept;
  operator?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      customDept: 'customDept',
      operator: 'operator',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customDept: CreateCustomDeptRequestCustomDept,
      operator: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptResponseBody extends $tea.Model {
  result?: CreateCustomDeptResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateCustomDeptResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateCustomDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateCustomDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceRequest extends $tea.Model {
  bizCode?: string;
  spaceDesc?: string;
  spaceIcon?: string;
  spaceName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      spaceDesc: 'spaceDesc',
      spaceIcon: 'spaceIcon',
      spaceName: 'spaceName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      spaceDesc: 'string',
      spaceIcon: 'string',
      spaceName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceResponseBody extends $tea.Model {
  createTimeMillis?: number;
  modifyTimeMillis?: number;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeMillis: 'createTimeMillis',
      modifyTimeMillis: 'modifyTimeMillis',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeMillis: 'number',
      modifyTimeMillis: 'number',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateEduAssetSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateEduAssetSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFulfilRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFulfilRecordRequest extends $tea.Model {
  bizTime?: number;
  extInfo?: string;
  faceId?: string;
  scene?: number;
  sn?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizTime: 'bizTime',
      extInfo: 'extInfo',
      faceId: 'faceId',
      scene: 'scene',
      sn: 'sn',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTime: 'number',
      extInfo: 'string',
      faceId: 'string',
      scene: 'number',
      sn: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFulfilRecordResponseBody extends $tea.Model {
  successInfo?: string;
  static names(): { [key: string]: string } {
    return {
      successInfo: 'successInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      successInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFulfilRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateFulfilRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateFulfilRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlRequest extends $tea.Model {
  authCode?: string;
  targetCorpId?: string;
  targetOperator?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
      targetCorpId: 'targetCorpId',
      targetOperator: 'targetOperator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
      targetCorpId: 'string',
      targetOperator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlResponseBody extends $tea.Model {
  result?: CreateInviteUrlResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateInviteUrlResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateInviteUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateInviteUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateItemHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateItemRequest extends $tea.Model {
  description?: string;
  effectType?: number;
  endTime?: number;
  merchantId?: string;
  name?: string;
  optUser?: string;
  periodType?: number;
  price?: number;
  scene?: number;
  startTime?: number;
  status?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      effectType: 'effectType',
      endTime: 'endTime',
      merchantId: 'merchantId',
      name: 'name',
      optUser: 'optUser',
      periodType: 'periodType',
      price: 'price',
      scene: 'scene',
      startTime: 'startTime',
      status: 'status',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      effectType: 'number',
      endTime: 'number',
      merchantId: 'string',
      name: 'string',
      optUser: 'string',
      periodType: 'number',
      price: 'number',
      scene: 'number',
      startTime: 'number',
      status: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateItemResponseBody extends $tea.Model {
  corpId?: string;
  id?: number;
  merchantId?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      merchantId: 'merchantId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'number',
      merchantId: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateItemResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateItemResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateItemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderRequest extends $tea.Model {
  actualAmount?: number;
  createTime?: number;
  detailList?: CreateOrderRequestDetailList[];
  faceId?: string;
  ftoken?: string;
  signature?: string;
  sn?: string;
  terminalParams?: string;
  timestamp?: number;
  totalAmount?: number;
  userId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      createTime: 'createTime',
      detailList: 'detailList',
      faceId: 'faceId',
      ftoken: 'ftoken',
      signature: 'signature',
      sn: 'sn',
      terminalParams: 'terminalParams',
      timestamp: 'timestamp',
      totalAmount: 'totalAmount',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      createTime: 'number',
      detailList: { 'type': 'array', 'itemType': CreateOrderRequestDetailList },
      faceId: 'string',
      ftoken: 'string',
      signature: 'string',
      sn: 'string',
      terminalParams: 'string',
      timestamp: 'number',
      totalAmount: 'number',
      userId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderResponseBody extends $tea.Model {
  orderNo?: string;
  static names(): { [key: string]: string } {
    return {
      orderNo: 'orderNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderFlowHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderFlowRequest extends $tea.Model {
  actualAmount?: number;
  alipayUid?: string;
  createTime?: number;
  detailList?: CreateOrderFlowRequestDetailList[];
  faceId?: string;
  guardianUserId?: string;
  merchantId?: string;
  orderNo?: string;
  signature?: string;
  sn?: string;
  timestamp?: number;
  totalAmount?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayUid: 'alipayUid',
      createTime: 'createTime',
      detailList: 'detailList',
      faceId: 'faceId',
      guardianUserId: 'guardianUserId',
      merchantId: 'merchantId',
      orderNo: 'orderNo',
      signature: 'signature',
      sn: 'sn',
      timestamp: 'timestamp',
      totalAmount: 'totalAmount',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayUid: 'string',
      createTime: 'number',
      detailList: { 'type': 'array', 'itemType': CreateOrderFlowRequestDetailList },
      faceId: 'string',
      guardianUserId: 'string',
      merchantId: 'string',
      orderNo: 'string',
      signature: 'string',
      sn: 'string',
      timestamp: 'number',
      totalAmount: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderFlowResponseBody extends $tea.Model {
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

export class CreateOrderFlowResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateOrderFlowResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateOrderFlowResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomRequest extends $tea.Model {
  classroomBuilding?: string;
  classroomCampus?: string;
  classroomFloor?: string;
  classroomName?: string;
  classroomNumber?: string;
  directBroadcast?: string;
  ext?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classroomBuilding: 'classroomBuilding',
      classroomCampus: 'classroomCampus',
      classroomFloor: 'classroomFloor',
      classroomName: 'classroomName',
      classroomNumber: 'classroomNumber',
      directBroadcast: 'directBroadcast',
      ext: 'ext',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomBuilding: 'string',
      classroomCampus: 'string',
      classroomFloor: 'string',
      classroomName: 'string',
      classroomNumber: 'string',
      directBroadcast: 'string',
      ext: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomResponseBody extends $tea.Model {
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreatePhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreatePhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRefundFlowHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRefundFlowRequest extends $tea.Model {
  faceId?: string;
  operatorId?: string;
  operatorName?: string;
  orderNo?: string;
  signature?: string;
  sn?: string;
  timestamp?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      operatorId: 'operatorId',
      operatorName: 'operatorName',
      orderNo: 'orderNo',
      signature: 'signature',
      sn: 'sn',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      operatorId: 'string',
      operatorName: 'string',
      orderNo: 'string',
      signature: 'string',
      sn: 'string',
      timestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRefundFlowResponseBody extends $tea.Model {
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

export class CreateRefundFlowResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateRefundFlowResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateRefundFlowResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseRequest extends $tea.Model {
  attendParticipants?: CreateRemoteClassCourseRequestAttendParticipants[];
  authCode?: string;
  courseName?: string;
  endTime?: number;
  startTime?: number;
  teachingParticipant?: CreateRemoteClassCourseRequestTeachingParticipant;
  static names(): { [key: string]: string } {
    return {
      attendParticipants: 'attendParticipants',
      authCode: 'authCode',
      courseName: 'courseName',
      endTime: 'endTime',
      startTime: 'startTime',
      teachingParticipant: 'teachingParticipant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendParticipants: { 'type': 'array', 'itemType': CreateRemoteClassCourseRequestAttendParticipants },
      authCode: 'string',
      courseName: 'string',
      endTime: 'number',
      startTime: 'number',
      teachingParticipant: CreateRemoteClassCourseRequestTeachingParticipant,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseResponseBody extends $tea.Model {
  result?: CreateRemoteClassCourseResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateRemoteClassCourseResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequest extends $tea.Model {
  ext?: string;
  sectionConfigs?: CreateSectionConfigRequestSectionConfigs[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      ext: 'ext',
      sectionConfigs: 'sectionConfigs',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ext: 'string',
      sectionConfigs: { 'type': 'array', 'itemType': CreateSectionConfigRequestSectionConfigs },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigResponseBody extends $tea.Model {
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

export class CreateSectionConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateSectionConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateSectionConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSnsAppOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSnsAppOrderRequest extends $tea.Model {
  actualAmount?: number;
  alipayAppId?: string;
  bizCode?: number;
  detailList?: CreateSnsAppOrderRequestDetailList[];
  labelAmount?: number;
  merchantId?: string;
  merchantOrderNo?: string;
  signature?: string;
  subject?: string;
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayAppId: 'alipayAppId',
      bizCode: 'bizCode',
      detailList: 'detailList',
      labelAmount: 'labelAmount',
      merchantId: 'merchantId',
      merchantOrderNo: 'merchantOrderNo',
      signature: 'signature',
      subject: 'subject',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayAppId: 'string',
      bizCode: 'number',
      detailList: { 'type': 'array', 'itemType': CreateSnsAppOrderRequestDetailList },
      labelAmount: 'number',
      merchantId: 'string',
      merchantOrderNo: 'string',
      signature: 'string',
      subject: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSnsAppOrderResponseBody extends $tea.Model {
  actualAmount?: number;
  alipayAppId?: string;
  body?: string;
  merchantId?: string;
  merchantOrderNo?: string;
  orderNo?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayAppId: 'alipayAppId',
      body: 'body',
      merchantId: 'merchantId',
      merchantOrderNo: 'merchantOrderNo',
      orderNo: 'orderNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayAppId: 'string',
      body: 'string',
      merchantId: 'string',
      merchantOrderNo: 'string',
      orderNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSnsAppOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateSnsAppOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateSnsAppOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStsTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStsTokenRequest extends $tea.Model {
  deviceSn?: string;
  stsType?: string;
  static names(): { [key: string]: string } {
    return {
      deviceSn: 'deviceSn',
      stsType: 'stsType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceSn: 'string',
      stsType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStsTokenResponseBody extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  expiration?: string;
  extInfo?: string;
  securityToken?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      expiration: 'expiration',
      extInfo: 'extInfo',
      securityToken: 'securityToken',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      expiration: 'string',
      extInfo: 'string',
      securityToken: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStsTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateStsTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateStsTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTokenRequest extends $tea.Model {
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTokenResponseBody extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  expiration?: string;
  extInfo?: string;
  securityToken?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      expiration: 'expiration',
      extInfo: 'extInfo',
      securityToken: 'securityToken',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      expiration: 'string',
      extInfo: 'string',
      securityToken: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequest extends $tea.Model {
  courseGroupIntroduce?: string;
  courseGroupName?: string;
  courserGroupItemModels?: CreateUniversityCourseGroupRequestCourserGroupItemModels[];
  ext?: string;
  isvCourseGroupCode?: string;
  periodCode?: string;
  schoolYear?: string;
  semester?: number;
  subjectName?: string;
  teacherInfos?: CreateUniversityCourseGroupRequestTeacherInfos[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupIntroduce: 'courseGroupIntroduce',
      courseGroupName: 'courseGroupName',
      courserGroupItemModels: 'courserGroupItemModels',
      ext: 'ext',
      isvCourseGroupCode: 'isvCourseGroupCode',
      periodCode: 'periodCode',
      schoolYear: 'schoolYear',
      semester: 'semester',
      subjectName: 'subjectName',
      teacherInfos: 'teacherInfos',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupIntroduce: 'string',
      courseGroupName: 'string',
      courserGroupItemModels: { 'type': 'array', 'itemType': CreateUniversityCourseGroupRequestCourserGroupItemModels },
      ext: 'string',
      isvCourseGroupCode: 'string',
      periodCode: 'string',
      schoolYear: 'string',
      semester: 'number',
      subjectName: 'string',
      teacherInfos: { 'type': 'array', 'itemType': CreateUniversityCourseGroupRequestTeacherInfos },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupResponseBody extends $tea.Model {
  courseGroupInfo?: CreateUniversityCourseGroupResponseBodyCourseGroupInfo;
  static names(): { [key: string]: string } {
    return {
      courseGroupInfo: 'courseGroupInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupInfo: CreateUniversityCourseGroupResponseBodyCourseGroupInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityStudentRequest extends $tea.Model {
  classId?: number;
  gender?: string;
  identityNumber?: string;
  mobile?: string;
  name?: string;
  studentNumber?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      gender: 'gender',
      identityNumber: 'identityNumber',
      mobile: 'mobile',
      name: 'name',
      studentNumber: 'studentNumber',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      gender: 'string',
      identityNumber: 'string',
      mobile: 'string',
      name: 'string',
      studentNumber: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityStudentResponseBody extends $tea.Model {
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

export class CreateUniversityStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateUniversityStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateUniversityStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityTeacherHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityTeacherRequest extends $tea.Model {
  classId?: number;
  opUserId?: string;
  role?: string;
  teacherUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      opUserId: 'opUserId',
      role: 'role',
      teacherUserId: 'teacherUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      opUserId: 'string',
      role: 'string',
      teacherUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityTeacherResponseBody extends $tea.Model {
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

export class CreateUniversityTeacherResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateUniversityTeacherResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateUniversityTeacherResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeactivateDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeactivateDeviceRequest extends $tea.Model {
  model?: string;
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      model: 'model',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      model: 'string',
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeactivateDeviceResponseBody extends $tea.Model {
  activateTimes?: number;
  static names(): { [key: string]: string } {
    return {
      activateTimes: 'activateTimes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activateTimes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeactivateDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeactivateDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeactivateDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductPointHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductPointRequest extends $tea.Model {
  bizId?: string;
  deductDesc?: string;
  deductDetailUrl?: string;
  deductNum?: number;
  pointType?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      deductDesc: 'deductDesc',
      deductDetailUrl: 'deductDetailUrl',
      deductNum: 'deductNum',
      pointType: 'pointType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      deductDesc: 'string',
      deductDetailUrl: 'string',
      deductNum: 'number',
      pointType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductPointResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductPointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeductPointResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeductPointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeptRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeptResponseBody extends $tea.Model {
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

export class DeleteDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceRequest extends $tea.Model {
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceResponseBody extends $tea.Model {
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

export class DeleteDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceOrgRequest extends $tea.Model {
  authCode?: string;
  deviceCode?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
      deviceCode: 'deviceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
      deviceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceOrgResponseBody extends $tea.Model {
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

export class DeleteDeviceOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteDeviceOrgResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteDeviceOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGuardianHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGuardianRequest extends $tea.Model {
  operator?: string;
  stuId?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      stuId: 'stuId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      stuId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGuardianResponseBody extends $tea.Model {
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

export class DeleteGuardianResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteGuardianResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteGuardianResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgRelationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgRelationRequest extends $tea.Model {
  authCode?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgRelationResponseBody extends $tea.Model {
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

export class DeleteOrgRelationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteOrgRelationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteOrgRelationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePhysicalClassroomRequest extends $tea.Model {
  classroomId?: number;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classroomId: 'classroomId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomId: 'number',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePhysicalClassroomResponseBody extends $tea.Model {
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

export class DeletePhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeletePhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeletePhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRemoteClassCourseRequest extends $tea.Model {
  authCode?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRemoteClassCourseResponseBody extends $tea.Model {
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

export class DeleteRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteStudentRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteStudentResponseBody extends $tea.Model {
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

export class DeleteStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeacherHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeacherRequest extends $tea.Model {
  adviser?: number;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      adviser: 'adviser',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adviser: 'number',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeacherResponseBody extends $tea.Model {
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

export class DeleteTeacherResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteTeacherResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteTeacherResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityCourseGroupResponseBody extends $tea.Model {
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

export class DeleteUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityStudentRequest extends $tea.Model {
  classId?: number;
  opUserId?: string;
  studentUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      opUserId: 'opUserId',
      studentUserId: 'studentUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      opUserId: 'string',
      studentUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityStudentResponseBody extends $tea.Model {
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

export class DeleteUniversityStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteUniversityStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteUniversityStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityTeacherHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityTeacherRequest extends $tea.Model {
  classId?: number;
  opUserId?: string;
  role?: string;
  teacherUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      opUserId: 'opUserId',
      role: 'role',
      teacherUserId: 'teacherUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      opUserId: 'string',
      role: 'string',
      teacherUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityTeacherResponseBody extends $tea.Model {
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

export class DeleteUniversityTeacherResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteUniversityTeacherResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteUniversityTeacherResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatRequest extends $tea.Model {
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatResponseBody extends $tea.Model {
  command?: number;
  static names(): { [key: string]: string } {
    return {
      command: 'command',
    };
  }

  static types(): { [key: string]: any } {
    return {
      command: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeviceHeartbeatResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeviceHeartbeatResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EduTeacherListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EduTeacherListRequest extends $tea.Model {
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

export class EduTeacherListResponseBody extends $tea.Model {
  result?: EduTeacherListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: EduTeacherListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EduTeacherListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EduTeacherListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EduTeacherListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseRequest extends $tea.Model {
  courseCode?: string;
  ext?: string;
  isvCode?: string;
  livePlayInfoList?: EndCourseRequestLivePlayInfoList[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      ext: 'ext',
      isvCode: 'isvCode',
      livePlayInfoList: 'livePlayInfoList',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      ext: 'string',
      isvCode: 'string',
      livePlayInfoList: { 'type': 'array', 'itemType': EndCourseRequestLivePlayInfoList },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseResponseBody extends $tea.Model {
  universityCourseCommonResponse?: EndCourseResponseBodyUniversityCourseCommonResponse;
  static names(): { [key: string]: string } {
    return {
      universityCourseCommonResponse: 'universityCourseCommonResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseCommonResponse: EndCourseResponseBodyUniversityCourseCommonResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EndCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EndCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBindChildInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBindChildInfoRequest extends $tea.Model {
  schoolCorpId?: string;
  studentUserId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      schoolCorpId: 'schoolCorpId',
      studentUserId: 'studentUserId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schoolCorpId: 'string',
      studentUserId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBindChildInfoResponseBody extends $tea.Model {
  childUserId?: string;
  currentUserId?: string;
  familyCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      childUserId: 'childUserId',
      currentUserId: 'currentUserId',
      familyCorpId: 'familyCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      childUserId: 'string',
      currentUserId: 'string',
      familyCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBindChildInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetBindChildInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetBindChildInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildResponseBody extends $tea.Model {
  avatar?: string;
  bindStudents?: GetDefaultChildResponseBodyBindStudents[];
  grade?: number;
  name?: string;
  nick?: string;
  period?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      bindStudents: 'bindStudents',
      grade: 'grade',
      name: 'name',
      nick: 'nick',
      period: 'period',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      bindStudents: { 'type': 'array', 'itemType': GetDefaultChildResponseBodyBindStudents },
      grade: 'number',
      name: 'string',
      nick: 'string',
      period: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDefaultChildResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetDefaultChildResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEduUserIdentityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEduUserIdentityRequest extends $tea.Model {
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

export class GetEduUserIdentityResponseBody extends $tea.Model {
  data?: GetEduUserIdentityResponseBodyData;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetEduUserIdentityResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEduUserIdentityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetEduUserIdentityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetEduUserIdentityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailResponseBody extends $tea.Model {
  courseId?: string;
  courseType?: number;
  coverUrl?: string;
  introduction?: string;
  pushModel?: GetOpenCourseDetailResponseBodyPushModel;
  startTime?: number;
  teacherId?: string;
  teacherName?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      courseId: 'courseId',
      courseType: 'courseType',
      coverUrl: 'coverUrl',
      introduction: 'introduction',
      pushModel: 'pushModel',
      startTime: 'startTime',
      teacherId: 'teacherId',
      teacherName: 'teacherName',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseId: 'string',
      courseType: 'number',
      coverUrl: 'string',
      introduction: 'string',
      pushModel: GetOpenCourseDetailResponseBodyPushModel,
      startTime: 'number',
      teacherId: 'string',
      teacherName: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOpenCourseDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetOpenCourseDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesRequest extends $tea.Model {
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

export class GetOpenCoursesResponseBody extends $tea.Model {
  courseList?: GetOpenCoursesResponseBodyCourseList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      courseList: 'courseList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseList: { 'type': 'array', 'itemType': GetOpenCoursesResponseBodyCourseList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOpenCoursesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetOpenCoursesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointActionRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointActionRecordRequest extends $tea.Model {
  bizId?: string;
  pointType?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      pointType: 'pointType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      pointType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointActionRecordResponseBody extends $tea.Model {
  result?: GetPointActionRecordResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetPointActionRecordResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointActionRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPointActionRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPointActionRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoRequest extends $tea.Model {
  pointType?: string;
  static names(): { [key: string]: string } {
    return {
      pointType: 'pointType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoResponseBody extends $tea.Model {
  result?: GetPointInfoResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetPointInfoResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPointInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPointInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBody extends $tea.Model {
  result?: GetRemoteClassCourseResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetRemoteClassCourseResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersResponseBody extends $tea.Model {
  result?: GetShareRoleMembersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetShareRoleMembersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetShareRoleMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetShareRoleMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesResponseBody extends $tea.Model {
  result?: GetShareRolesResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetShareRolesResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetShareRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetShareRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskListRequest extends $tea.Model {
  operator?: string;
  pageNumber?: number;
  pageSize?: number;
  taskYear?: number;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      taskYear: 'taskYear',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      taskYear: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskListResponseBody extends $tea.Model {
  count?: number;
  taskList?: GetTaskListResponseBodyTaskList[];
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      taskList: 'taskList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      taskList: { 'type': 'array', 'itemType': GetTaskListResponseBodyTaskList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTaskListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetTaskListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskStudentListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskStudentListRequest extends $tea.Model {
  operator?: string;
  pageNumber?: number;
  pageSize?: number;
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskStudentListResponseBody extends $tea.Model {
  count?: number;
  studentList?: GetTaskStudentListResponseBodyStudentList[];
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      studentList: 'studentList',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      studentList: { 'type': 'array', 'itemType': GetTaskStudentListResponseBodyStudentList },
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskStudentListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTaskStudentListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetTaskStudentListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequest extends $tea.Model {
  courses?: InitCoursesOfClassRequestCourses[];
  sectionConfig?: InitCoursesOfClassRequestSectionConfig;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courses: 'courses',
      sectionConfig: 'sectionConfig',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courses: { 'type': 'array', 'itemType': InitCoursesOfClassRequestCourses },
      sectionConfig: InitCoursesOfClassRequestSectionConfig,
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassResponseBody extends $tea.Model {
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

export class InitCoursesOfClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InitCoursesOfClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InitCoursesOfClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDeviceRequest extends $tea.Model {
  encryptPubKey?: string;
  signature?: string;
  sn?: string;
  timestamp?: number;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      encryptPubKey: 'encryptPubKey',
      signature: 'signature',
      sn: 'sn',
      timestamp: 'timestamp',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      encryptPubKey: 'string',
      signature: 'string',
      sn: 'string',
      timestamp: 'number',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDeviceResponseBody extends $tea.Model {
  successInfo?: string;
  static names(): { [key: string]: string } {
    return {
      successInfo: 'successInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      successInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InitDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InitDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitVPaasDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitVPaasDeviceRequest extends $tea.Model {
  sn?: string;
  timestamp?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
      timestamp: 'timestamp',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
      timestamp: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitVPaasDeviceResponseBody extends $tea.Model {
  pspk?: string;
  static names(): { [key: string]: string } {
    return {
      pspk: 'pspk',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pspk: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitVPaasDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InitVPaasDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InitVPaasDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequest extends $tea.Model {
  end?: InsertSectionConfigRequestEnd;
  scheduleName?: string;
  sectionModels?: InsertSectionConfigRequestSectionModels[];
  start?: InsertSectionConfigRequestStart;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      scheduleName: 'scheduleName',
      sectionModels: 'sectionModels',
      start: 'start',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: InsertSectionConfigRequestEnd,
      scheduleName: 'string',
      sectionModels: { 'type': 'array', 'itemType': InsertSectionConfigRequestSectionModels },
      start: InsertSectionConfigRequestStart,
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigResponseBody extends $tea.Model {
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

export class InsertSectionConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InsertSectionConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InsertSectionConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrderRequest extends $tea.Model {
  createTimeEnd?: number;
  createTimeStart?: number;
  merchantId?: string;
  orderNo?: string;
  pageNumber?: number;
  pageSize?: number;
  scene?: number;
  status?: number;
  tradeNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      createTimeEnd: 'createTimeEnd',
      createTimeStart: 'createTimeStart',
      merchantId: 'merchantId',
      orderNo: 'orderNo',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      scene: 'scene',
      status: 'status',
      tradeNo: 'tradeNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeEnd: 'number',
      createTimeStart: 'number',
      merchantId: 'string',
      orderNo: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      scene: 'number',
      status: 'number',
      tradeNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrderResponseBody extends $tea.Model {
  list?: ListOrderResponseBodyList[];
  total?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListOrderResponseBodyList },
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveStudentRequest extends $tea.Model {
  operator?: string;
  originClassId?: number;
  targetClassId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      originClassId: 'originClassId',
      targetClassId: 'targetClassId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      originClassId: 'number',
      targetClassId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveStudentResponseBody extends $tea.Model {
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

export class MoveStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: MoveStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: MoveStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageQueryDevicesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageQueryDevicesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageQueryDevicesResponseBody extends $tea.Model {
  list?: PageQueryDevicesResponseBodyList[];
  nextToken?: string;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': PageQueryDevicesResponseBodyList },
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageQueryDevicesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PageQueryDevicesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PageQueryDevicesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PayOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PayOrderRequest extends $tea.Model {
  faceId?: string;
  orderNo?: string;
  signature?: string;
  sn?: string;
  timestamp?: number;
  userId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      orderNo: 'orderNo',
      signature: 'signature',
      sn: 'sn',
      timestamp: 'timestamp',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      orderNo: 'string',
      signature: 'string',
      sn: 'string',
      timestamp: 'number',
      userId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PayOrderResponseBody extends $tea.Model {
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

export class PayOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PayOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PayOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusRequest extends $tea.Model {
  courseCode?: string;
  ext?: string;
  isvCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      ext: 'ext',
      isvCode: 'isvCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      ext: 'string',
      isvCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponseBody extends $tea.Model {
  universityPollingCourseStatusResponse?: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse;
  static names(): { [key: string]: string } {
    return {
      universityPollingCourseStatusResponse: 'universityPollingCourseStatusResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityPollingCourseStatusResponse: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PollingConfirmStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PollingConfirmStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreDialHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreDialRequest extends $tea.Model {
  callerUserId?: string;
  receiverUserId?: string;
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      callerUserId: 'callerUserId',
      receiverUserId: 'receiverUserId',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callerUserId: 'string',
      receiverUserId: 'string',
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreDialResponseBody extends $tea.Model {
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

export class PreDialResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PreDialResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PreDialResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProvidePointHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProvidePointRequest extends $tea.Model {
  actionCode?: string;
  bizId?: string;
  pointType?: string;
  static names(): { [key: string]: string } {
    return {
      actionCode: 'actionCode',
      bizId: 'bizId',
      pointType: 'pointType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCode: 'string',
      bizId: 'string',
      pointType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProvidePointResponseBody extends $tea.Model {
  result?: ProvidePointResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ProvidePointResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProvidePointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ProvidePointResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ProvidePointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  periodCode?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
      periodCode: 'periodCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      periodCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleShrinkRequest extends $tea.Model {
  classIdsShrink?: string;
  opUserId?: string;
  periodCode?: string;
  static names(): { [key: string]: string } {
    return {
      classIdsShrink: 'classIds',
      opUserId: 'opUserId',
      periodCode: 'periodCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIdsShrink: 'string',
      opUserId: 'string',
      periodCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBody extends $tea.Model {
  result?: QueryAllSubjectsFromClassScheduleResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryAllSubjectsFromClassScheduleResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryAllSubjectsFromClassScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryAllSubjectsFromClassScheduleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleRequest extends $tea.Model {
  sectionIndexList?: number[];
  subscriberIds?: string[];
  endTime?: number;
  opUserId?: string;
  startTime?: number;
  subscriberType?: string;
  static names(): { [key: string]: string } {
    return {
      sectionIndexList: 'sectionIndexList',
      subscriberIds: 'subscriberIds',
      endTime: 'endTime',
      opUserId: 'opUserId',
      startTime: 'startTime',
      subscriberType: 'subscriberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionIndexList: { 'type': 'array', 'itemType': 'number' },
      subscriberIds: { 'type': 'array', 'itemType': 'string' },
      endTime: 'number',
      opUserId: 'string',
      startTime: 'number',
      subscriberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBody extends $tea.Model {
  config?: QueryClassScheduleResponseBodyConfig;
  courseDTOS?: QueryClassScheduleResponseBodyCourseDTOS[];
  static names(): { [key: string]: string } {
    return {
      config: 'config',
      courseDTOS: 'courseDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      config: QueryClassScheduleResponseBodyConfig,
      courseDTOS: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyCourseDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryClassScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryClassScheduleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolRequest extends $tea.Model {
  endTime?: number;
  opUserId?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      opUserId: 'opUserId',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      opUserId: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBody extends $tea.Model {
  result?: QueryClassScheduleByTimeSchoolResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryClassScheduleByTimeSchoolResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryClassScheduleByTimeSchoolResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryClassScheduleByTimeSchoolResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigShrinkRequest extends $tea.Model {
  classIdsShrink?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classIdsShrink: 'classIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIdsShrink: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBody extends $tea.Model {
  result?: QueryClassScheduleConfigResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryClassScheduleConfigResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryClassScheduleConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryClassScheduleConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceRequest extends $tea.Model {
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceResponseBody extends $tea.Model {
  gmtExpiry?: number;
  model?: string;
  name?: string;
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      gmtExpiry: 'gmtExpiry',
      model: 'model',
      name: 'name',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtExpiry: 'number',
      model: 'string',
      name: 'string',
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdRequest extends $tea.Model {
  operator?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponseBody extends $tea.Model {
  result?: QueryDeviceListByCorpIdResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryDeviceListByCorpIdResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDeviceListByCorpIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDeviceListByCorpIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesRequest extends $tea.Model {
  bizCode?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  spaces?: QueryEduAssetSpacesResponseBodySpaces[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      spaces: 'spaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      spaces: { 'type': 'array', 'itemType': QueryEduAssetSpacesResponseBodySpaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryEduAssetSpacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryEduAssetSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdRequest extends $tea.Model {
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdResponseBody extends $tea.Model {
  corpId?: string;
  groupId?: string;
  merchantId?: string;
  merchantName?: string;
  name?: string;
  pid?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      groupId: 'groupId',
      merchantId: 'merchantId',
      merchantName: 'merchantName',
      name: 'name',
      pid: 'pid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      groupId: 'string',
      merchantId: 'string',
      merchantName: 'string',
      name: 'string',
      pid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryGroupIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryGroupIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrderRequest extends $tea.Model {
  alipayAppId?: string;
  merchantId?: string;
  orderNo?: string;
  signature?: string;
  static names(): { [key: string]: string } {
    return {
      alipayAppId: 'alipayAppId',
      merchantId: 'merchantId',
      orderNo: 'orderNo',
      signature: 'signature',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayAppId: 'string',
      merchantId: 'string',
      orderNo: 'string',
      signature: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrderResponseBody extends $tea.Model {
  actualAmount?: number;
  alipayAppId?: string;
  closeTime?: string;
  closeTimestamp?: number;
  createTime?: string;
  createTimestamp?: number;
  labelAmount?: number;
  merchantId?: string;
  merchantMergeOrderNo?: string;
  merchantOrderNo?: string;
  orderNo?: string;
  orderType?: string;
  outerUserId?: string;
  payLogonId?: string;
  payStatus?: number;
  payTime?: string;
  payTimestamp?: number;
  payType?: string;
  refundAmount?: number;
  refundStatus?: number;
  refundTime?: string;
  refundTimestamp?: number;
  subject?: string;
  tradeNo?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayAppId: 'alipayAppId',
      closeTime: 'closeTime',
      closeTimestamp: 'closeTimestamp',
      createTime: 'createTime',
      createTimestamp: 'createTimestamp',
      labelAmount: 'labelAmount',
      merchantId: 'merchantId',
      merchantMergeOrderNo: 'merchantMergeOrderNo',
      merchantOrderNo: 'merchantOrderNo',
      orderNo: 'orderNo',
      orderType: 'orderType',
      outerUserId: 'outerUserId',
      payLogonId: 'payLogonId',
      payStatus: 'payStatus',
      payTime: 'payTime',
      payTimestamp: 'payTimestamp',
      payType: 'payType',
      refundAmount: 'refundAmount',
      refundStatus: 'refundStatus',
      refundTime: 'refundTime',
      refundTimestamp: 'refundTimestamp',
      subject: 'subject',
      tradeNo: 'tradeNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayAppId: 'string',
      closeTime: 'string',
      closeTimestamp: 'number',
      createTime: 'string',
      createTimestamp: 'number',
      labelAmount: 'number',
      merchantId: 'string',
      merchantMergeOrderNo: 'string',
      merchantOrderNo: 'string',
      orderNo: 'string',
      orderType: 'string',
      outerUserId: 'string',
      payLogonId: 'string',
      payStatus: 'number',
      payTime: 'string',
      payTimestamp: 'number',
      payType: 'string',
      refundAmount: 'number',
      refundStatus: 'number',
      refundTime: 'string',
      refundTimestamp: 'number',
      subject: 'string',
      tradeNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListResponseBody extends $tea.Model {
  result?: QueryOrgRelationListResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryOrgRelationListResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrgRelationListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOrgRelationListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyRequest extends $tea.Model {
  isvCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      isvCode: 'isvCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyResponseBody extends $tea.Model {
  universitySecretKeyInfo?: QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo;
  static names(): { [key: string]: string } {
    return {
      universitySecretKeyInfo: 'universitySecretKeyInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universitySecretKeyInfo: QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrgSecretKeyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOrgSecretKeyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTypeResponseBody extends $tea.Model {
  orgType?: number;
  static names(): { [key: string]: string } {
    return {
      orgType: 'orgType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrgTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOrgTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayResultRequest extends $tea.Model {
  faceId?: string;
  orderNo?: string;
  signature?: string;
  sn?: string;
  timestamp?: number;
  userId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      orderNo: 'orderNo',
      signature: 'signature',
      sn: 'sn',
      timestamp: 'timestamp',
      userId: 'userId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      orderNo: 'string',
      signature: 'string',
      sn: 'string',
      timestamp: 'number',
      userId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayResultResponseBody extends $tea.Model {
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

export class QueryPayResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryPayResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPayResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomRequest extends $tea.Model {
  classroomId?: number;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classroomId: 'classroomId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomId: 'number',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomResponseBody extends $tea.Model {
  result?: QueryPhysicalClassroomResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryPhysicalClassroomResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryPhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoRequest extends $tea.Model {
  merchantId?: string;
  scene?: number;
  sn?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      merchantId: 'merchantId',
      scene: 'scene',
      sn: 'sn',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      merchantId: 'string',
      scene: 'number',
      sn: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoResponseBody extends $tea.Model {
  corpId?: string;
  merchantId?: string;
  name?: string;
  scene?: number;
  status?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      merchantId: 'merchantId',
      name: 'name',
      scene: 'scene',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      merchantId: 'string',
      name: 'string',
      scene: 'number',
      status: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryPurchaseInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPurchaseInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseRequest extends $tea.Model {
  endTime?: number;
  operator?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      operator: 'operator',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      operator: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBody extends $tea.Model {
  result?: QueryRemoteClassCourseResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryRemoteClassCourseResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  sn?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      sn: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceResponseBody extends $tea.Model {
  corpId?: string;
  hasMore?: boolean;
  userFaceList?: QuerySchoolUserFaceResponseBodyUserFaceList[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      hasMore: 'hasMore',
      userFaceList: 'userFaceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      hasMore: 'boolean',
      userFaceList: { 'type': 'array', 'itemType': QuerySchoolUserFaceResponseBodyUserFaceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QuerySchoolUserFaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySchoolUserFaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySnsOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySnsOrderRequest extends $tea.Model {
  alipayAppId?: string;
  merchantId?: string;
  orderNo?: string;
  signature?: string;
  static names(): { [key: string]: string } {
    return {
      alipayAppId: 'alipayAppId',
      merchantId: 'merchantId',
      orderNo: 'orderNo',
      signature: 'signature',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayAppId: 'string',
      merchantId: 'string',
      orderNo: 'string',
      signature: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySnsOrderResponseBody extends $tea.Model {
  actualAmount?: number;
  alipayAppId?: string;
  closeTime?: string;
  closeTimestamp?: number;
  createTime?: string;
  createTimestamp?: number;
  labelAmount?: number;
  merchantId?: string;
  merchantMergeOrderNo?: string;
  merchantOrderNo?: string;
  orderNo?: string;
  orderType?: string;
  outerUserId?: string;
  payLogonId?: string;
  payStatus?: number;
  payTime?: string;
  payTimestamp?: number;
  payType?: string;
  refundAmount?: number;
  refundStatus?: number;
  refundTime?: string;
  refundTimestamp?: number;
  subject?: string;
  tradeNo?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      alipayAppId: 'alipayAppId',
      closeTime: 'closeTime',
      closeTimestamp: 'closeTimestamp',
      createTime: 'createTime',
      createTimestamp: 'createTimestamp',
      labelAmount: 'labelAmount',
      merchantId: 'merchantId',
      merchantMergeOrderNo: 'merchantMergeOrderNo',
      merchantOrderNo: 'merchantOrderNo',
      orderNo: 'orderNo',
      orderType: 'orderType',
      outerUserId: 'outerUserId',
      payLogonId: 'payLogonId',
      payStatus: 'payStatus',
      payTime: 'payTime',
      payTimestamp: 'payTimestamp',
      payType: 'payType',
      refundAmount: 'refundAmount',
      refundStatus: 'refundStatus',
      refundTime: 'refundTime',
      refundTimestamp: 'refundTimestamp',
      subject: 'subject',
      tradeNo: 'tradeNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      alipayAppId: 'string',
      closeTime: 'string',
      closeTimestamp: 'number',
      createTime: 'string',
      createTimestamp: 'number',
      labelAmount: 'number',
      merchantId: 'string',
      merchantMergeOrderNo: 'string',
      merchantOrderNo: 'string',
      orderNo: 'string',
      orderType: 'string',
      outerUserId: 'string',
      payLogonId: 'string',
      payStatus: 'number',
      payTime: 'string',
      payTimestamp: 'number',
      payType: 'string',
      refundAmount: 'number',
      refundStatus: 'number',
      refundTime: 'string',
      refundTimestamp: 'number',
      subject: 'string',
      tradeNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySnsOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QuerySnsOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySnsOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataRequest extends $tea.Model {
  sectionIndexList?: number[];
  teacherUserIds?: string[];
  endTime?: number;
  opUserId?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      sectionIndexList: 'sectionIndexList',
      teacherUserIds: 'teacherUserIds',
      endTime: 'endTime',
      opUserId: 'opUserId',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionIndexList: { 'type': 'array', 'itemType': 'number' },
      teacherUserIds: { 'type': 'array', 'itemType': 'string' },
      endTime: 'number',
      opUserId: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataResponseBody extends $tea.Model {
  result?: QueryStatisticsDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryStatisticsDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryStatisticsDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryStatisticsDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  subjectCode?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
      subjectCode: 'subjectCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      subjectCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersResponseBody extends $tea.Model {
  result?: QuerySubjectTeachersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QuerySubjectTeachersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QuerySubjectTeachersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySubjectTeachersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsResponseBody extends $tea.Model {
  result?: QueryTeachSubjectsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryTeachSubjectsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryTeachSubjectsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryTeachSubjectsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBody extends $tea.Model {
  universityCourseGroupInfo?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo;
  static names(): { [key: string]: string } {
    return {
      universityCourseGroupInfo: 'universityCourseGroupInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseGroupInfo: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceRequest extends $tea.Model {
  faceId?: string;
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceResponseBody extends $tea.Model {
  corpId?: string;
  faceId?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      faceId: 'faceId',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      faceId: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserFaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserFaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPayInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPayInfoRequest extends $tea.Model {
  faceId?: string;
  sn?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      sn: 'sn',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      sn: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPayInfoResponseBody extends $tea.Model {
  signNo?: string;
  static names(): { [key: string]: string } {
    return {
      signNo: 'signNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      signNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPayInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserPayInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserPayInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveDeviceRequest extends $tea.Model {
  merchantId?: string;
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      merchantId: 'merchantId',
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      merchantId: 'string',
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveDeviceResponseBody extends $tea.Model {
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

export class RemoveDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemoveDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RemoveDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceLogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceLogRequest extends $tea.Model {
  mediaId?: string;
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceLogResponseBody extends $tea.Model {
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

export class ReportDeviceLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ReportDeviceLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ReportDeviceLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceUseLogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceUseLogRequest extends $tea.Model {
  action?: string;
  orderNo?: string;
  sn?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      orderNo: 'orderNo',
      sn: 'sn',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      orderNo: 'string',
      sn: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceUseLogResponseBody extends $tea.Model {
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

export class ReportDeviceUseLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ReportDeviceUseLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ReportDeviceUseLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackDeductPointHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackDeductPointRequest extends $tea.Model {
  bizId?: string;
  pointType?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      pointType: 'pointType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      pointType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackDeductPointResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollbackDeductPointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RollbackDeductPointResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RollbackDeductPointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveClassLearningDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveClassLearningDataRequest extends $tea.Model {
  assignNum?: number;
  assignStudentUserIds?: string[];
  bizId?: string;
  bizType?: string;
  corpId?: string;
  deptId?: number;
  fileSuffix?: string;
  generatedTime?: number;
  questionNum?: number;
  questionPictureNum?: number;
  standardAnswerPictureNum?: number;
  subjectCode?: string;
  teacherUserId?: string;
  static names(): { [key: string]: string } {
    return {
      assignNum: 'assignNum',
      assignStudentUserIds: 'assignStudentUserIds',
      bizId: 'bizId',
      bizType: 'bizType',
      corpId: 'corpId',
      deptId: 'deptId',
      fileSuffix: 'fileSuffix',
      generatedTime: 'generatedTime',
      questionNum: 'questionNum',
      questionPictureNum: 'questionPictureNum',
      standardAnswerPictureNum: 'standardAnswerPictureNum',
      subjectCode: 'subjectCode',
      teacherUserId: 'teacherUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assignNum: 'number',
      assignStudentUserIds: { 'type': 'array', 'itemType': 'string' },
      bizId: 'string',
      bizType: 'string',
      corpId: 'string',
      deptId: 'number',
      fileSuffix: 'string',
      generatedTime: 'number',
      questionNum: 'number',
      questionPictureNum: 'number',
      standardAnswerPictureNum: 'number',
      subjectCode: 'string',
      teacherUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveClassLearningDataResponseBody extends $tea.Model {
  result?: SaveClassLearningDataResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SaveClassLearningDataResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveClassLearningDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveClassLearningDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveClassLearningDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataRequest extends $tea.Model {
  assignNum?: number;
  bizId?: string;
  bizType?: string;
  corpId?: string;
  correctNum?: number;
  deptId?: number;
  fileSuffix?: string;
  generatedTime?: number;
  questionNum?: number;
  studentUserId?: string;
  subjectCode?: string;
  submitNum?: number;
  wrongQuestions?: SaveStudentLearningDataRequestWrongQuestions[];
  static names(): { [key: string]: string } {
    return {
      assignNum: 'assignNum',
      bizId: 'bizId',
      bizType: 'bizType',
      corpId: 'corpId',
      correctNum: 'correctNum',
      deptId: 'deptId',
      fileSuffix: 'fileSuffix',
      generatedTime: 'generatedTime',
      questionNum: 'questionNum',
      studentUserId: 'studentUserId',
      subjectCode: 'subjectCode',
      submitNum: 'submitNum',
      wrongQuestions: 'wrongQuestions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assignNum: 'number',
      bizId: 'string',
      bizType: 'string',
      corpId: 'string',
      correctNum: 'number',
      deptId: 'number',
      fileSuffix: 'string',
      generatedTime: 'number',
      questionNum: 'number',
      studentUserId: 'string',
      subjectCode: 'string',
      submitNum: 'number',
      wrongQuestions: { 'type': 'array', 'itemType': SaveStudentLearningDataRequestWrongQuestions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataResponseBody extends $tea.Model {
  result?: SaveStudentLearningDataResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SaveStudentLearningDataResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveStudentLearningDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveStudentLearningDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersRequest extends $tea.Model {
  nameKeyword?: string;
  static names(): { [key: string]: string } {
    return {
      nameKeyword: 'nameKeyword',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameKeyword: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersResponseBody extends $tea.Model {
  users?: SearchTeachersResponseBodyUsers[];
  static names(): { [key: string]: string } {
    return {
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      users: { 'type': 'array', 'itemType': SearchTeachersResponseBodyUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchTeachersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchTeachersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageRequest extends $tea.Model {
  bizId?: string;
  fromUserId?: string;
  sn?: string;
  toUserIdList?: string[];
  type?: number;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      fromUserId: 'fromUserId',
      sn: 'sn',
      toUserIdList: 'toUserIdList',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      fromUserId: 'string',
      sn: 'string',
      toUserIdList: { 'type': 'array', 'itemType': 'string' },
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageResponseBody extends $tea.Model {
  successInfo?: string;
  static names(): { [key: string]: string } {
    return {
      successInfo: 'successInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      successInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SendMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseRequest extends $tea.Model {
  courseCode?: string;
  ext?: string;
  isvCode?: string;
  livePlayInfoList?: StartCourseRequestLivePlayInfoList[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      ext: 'ext',
      isvCode: 'isvCode',
      livePlayInfoList: 'livePlayInfoList',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      ext: 'string',
      isvCode: 'string',
      livePlayInfoList: { 'type': 'array', 'itemType': StartCourseRequestLivePlayInfoList },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseResponseBody extends $tea.Model {
  universityCourseCommonResponse?: StartCourseResponseBodyUniversityCourseCommonResponse;
  static names(): { [key: string]: string } {
    return {
      universityCourseCommonResponse: 'universityCourseCommonResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseCommonResponse: StartCourseResponseBodyUniversityCourseCommonResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StartCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: StartCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareRequest extends $tea.Model {
  courseDate?: string;
  courseGroupCode?: string;
  deviceId?: string;
  ext?: string;
  isvCode?: string;
  liveCoverImage?: string;
  sectionIndex?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseDate: 'courseDate',
      courseGroupCode: 'courseGroupCode',
      deviceId: 'deviceId',
      ext: 'ext',
      isvCode: 'isvCode',
      liveCoverImage: 'liveCoverImage',
      sectionIndex: 'sectionIndex',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseDate: 'string',
      courseGroupCode: 'string',
      deviceId: 'string',
      ext: 'string',
      isvCode: 'string',
      liveCoverImage: 'string',
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareResponseBody extends $tea.Model {
  universityCourseCommonResponse?: StartCoursePrepareResponseBodyUniversityCourseCommonResponse;
  static names(): { [key: string]: string } {
    return {
      universityCourseCommonResponse: 'universityCourseCommonResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseCommonResponse: StartCoursePrepareResponseBodyUniversityCourseCommonResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StartCoursePrepareResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: StartCoursePrepareResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  studentUserIds?: string[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      studentUserIds: 'studentUserIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      studentUserIds: { 'type': 'array', 'itemType': 'string' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeUniversityCourseGroupResponseBody extends $tea.Model {
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

export class SubscribeUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SubscribeUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SubscribeUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  studentUserIds?: string[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      studentUserIds: 'studentUserIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      studentUserIds: { 'type': 'array', 'itemType': 'string' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeUniversityCourseGroupResponseBody extends $tea.Model {
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

export class UnsubscribeUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnsubscribeUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UnsubscribeUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequest extends $tea.Model {
  courses?: UpdateCoursesOfClassRequestCourses[];
  sectionConfig?: UpdateCoursesOfClassRequestSectionConfig;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courses: 'courses',
      sectionConfig: 'sectionConfig',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courses: { 'type': 'array', 'itemType': UpdateCoursesOfClassRequestCourses },
      sectionConfig: UpdateCoursesOfClassRequestSectionConfig,
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassResponseBody extends $tea.Model {
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

export class UpdateCoursesOfClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateCoursesOfClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateCoursesOfClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePhysicalClassroomRequest extends $tea.Model {
  classroomBuilding?: string;
  classroomCampus?: string;
  classroomFloor?: string;
  classroomId?: number;
  classroomName?: string;
  classroomNumber?: string;
  directBroadcast?: string;
  ext?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classroomBuilding: 'classroomBuilding',
      classroomCampus: 'classroomCampus',
      classroomFloor: 'classroomFloor',
      classroomId: 'classroomId',
      classroomName: 'classroomName',
      classroomNumber: 'classroomNumber',
      directBroadcast: 'directBroadcast',
      ext: 'ext',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomBuilding: 'string',
      classroomCampus: 'string',
      classroomFloor: 'string',
      classroomId: 'number',
      classroomName: 'string',
      classroomNumber: 'string',
      directBroadcast: 'string',
      ext: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePhysicalClassroomResponseBody extends $tea.Model {
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

export class UpdatePhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdatePhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdatePhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseRequest extends $tea.Model {
  attendParticipants?: UpdateRemoteClassCourseRequestAttendParticipants[];
  authCode?: string;
  courseCode?: string;
  courseName?: string;
  endTime?: number;
  startTime?: number;
  teachingParticipant?: UpdateRemoteClassCourseRequestTeachingParticipant;
  static names(): { [key: string]: string } {
    return {
      attendParticipants: 'attendParticipants',
      authCode: 'authCode',
      courseCode: 'courseCode',
      courseName: 'courseName',
      endTime: 'endTime',
      startTime: 'startTime',
      teachingParticipant: 'teachingParticipant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendParticipants: { 'type': 'array', 'itemType': UpdateRemoteClassCourseRequestAttendParticipants },
      authCode: 'string',
      courseCode: 'string',
      courseName: 'string',
      endTime: 'number',
      startTime: 'number',
      teachingParticipant: UpdateRemoteClassCourseRequestTeachingParticipant,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseResponseBody extends $tea.Model {
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

export class UpdateRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassDeviceRequest extends $tea.Model {
  authCode?: string;
  deviceCode?: string;
  deviceName?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
      deviceCode: 'string',
      deviceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassDeviceResponseBody extends $tea.Model {
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

export class UpdateRemoteClassDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateRemoteClassDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateRemoteClassDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  courseGroupIntroduce?: string;
  courseGroupName?: string;
  courserGroupItemModels?: UpdateUniversityCourseGroupRequestCourserGroupItemModels[];
  ext?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      courseGroupIntroduce: 'courseGroupIntroduce',
      courseGroupName: 'courseGroupName',
      courserGroupItemModels: 'courserGroupItemModels',
      ext: 'ext',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      courseGroupIntroduce: 'string',
      courseGroupName: 'string',
      courserGroupItemModels: { 'type': 'array', 'itemType': UpdateUniversityCourseGroupRequestCourserGroupItemModels },
      ext: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupResponseBody extends $tea.Model {
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

export class UpdateUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadLearningDataCallbackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadLearningDataCallbackRequest extends $tea.Model {
  bizId?: string;
  bizType?: string;
  corpId?: string;
  deptId?: number;
  generatedTime?: number;
  studentUserId?: string;
  subjectCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      bizType: 'bizType',
      corpId: 'corpId',
      deptId: 'deptId',
      generatedTime: 'generatedTime',
      studentUserId: 'studentUserId',
      subjectCode: 'subjectCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      bizType: 'string',
      corpId: 'string',
      deptId: 'number',
      generatedTime: 'number',
      studentUserId: 'string',
      subjectCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadLearningDataCallbackResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadLearningDataCallbackResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UploadLearningDataCallbackResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UploadLearningDataCallbackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VPaasProxyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VPaasProxyRequest extends $tea.Model {
  actionCode?: string;
  params?: string;
  publicKey?: string;
  static names(): { [key: string]: string } {
    return {
      actionCode: 'actionCode',
      params: 'params',
      publicKey: 'publicKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCode: 'string',
      params: 'string',
      publicKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VPaasProxyResponseBody extends $tea.Model {
  result?: string;
  ticket?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      ticket: 'ticket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      ticket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VPaasProxyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: VPaasProxyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: VPaasProxyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateNewGradeManagerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateNewGradeManagerRequest extends $tea.Model {
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

export class ValidateNewGradeManagerResponseBody extends $tea.Model {
  matchRule?: boolean;
  static names(): { [key: string]: string } {
    return {
      matchRule: 'matchRule',
    };
  }

  static types(): { [key: string]: any } {
    return {
      matchRule: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateNewGradeManagerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ValidateNewGradeManagerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateNewGradeManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateUserRoleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateUserRoleRequest extends $tea.Model {
  timeThreshold?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      timeThreshold: 'timeThreshold',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      timeThreshold: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateUserRoleResponseBody extends $tea.Model {
  matchParentIdentity?: boolean;
  matchTeacherIdentity?: boolean;
  static names(): { [key: string]: string } {
    return {
      matchParentIdentity: 'matchParentIdentity',
      matchTeacherIdentity: 'matchTeacherIdentity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      matchParentIdentity: 'boolean',
      matchTeacherIdentity: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateUserRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ValidateUserRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ValidateUserRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataCardRuleItemParamList extends $tea.Model {
  cardRuleAttr?: string;
  cardTaskCode?: string;
  dailyDubbing?: number;
  relationId?: string;
  relationTitle?: string;
  relationUrl?: string;
  static names(): { [key: string]: string } {
    return {
      cardRuleAttr: 'cardRuleAttr',
      cardTaskCode: 'cardTaskCode',
      dailyDubbing: 'dailyDubbing',
      relationId: 'relationId',
      relationTitle: 'relationTitle',
      relationUrl: 'relationUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardRuleAttr: 'string',
      cardTaskCode: 'string',
      dailyDubbing: 'number',
      relationId: 'string',
      relationTitle: 'string',
      relationUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents extends $tea.Model {
  name?: string;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataOrgClassStudentGroupListClassList extends $tea.Model {
  classId?: number;
  className?: string;
  students?: BatchCreateRequestDataOrgClassStudentGroupListClassListStudents[];
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      className: 'className',
      students: 'students',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      className: 'string',
      students: { 'type': 'array', 'itemType': BatchCreateRequestDataOrgClassStudentGroupListClassListStudents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataOrgClassStudentGroupList extends $tea.Model {
  classList?: BatchCreateRequestDataOrgClassStudentGroupListClassList[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      classList: 'classList',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classList: { 'type': 'array', 'itemType': BatchCreateRequestDataOrgClassStudentGroupListClassList },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestData extends $tea.Model {
  canReissueCard?: boolean;
  cardCycle?: number;
  cardFrequency?: number[];
  cardRuleItemParamList?: BatchCreateRequestDataCardRuleItemParamList[];
  classIds?: string[];
  classNames?: string[];
  content?: string;
  effectDate?: number;
  medias?: string;
  needMetering?: string;
  orgClassStudentGroupList?: BatchCreateRequestDataOrgClassStudentGroupList[];
  remindHour?: number;
  remindMinute?: number;
  targetRole?: string;
  templateId?: number;
  title?: string;
  unitOfMeasurement?: string;
  static names(): { [key: string]: string } {
    return {
      canReissueCard: 'canReissueCard',
      cardCycle: 'cardCycle',
      cardFrequency: 'cardFrequency',
      cardRuleItemParamList: 'cardRuleItemParamList',
      classIds: 'classIds',
      classNames: 'classNames',
      content: 'content',
      effectDate: 'effectDate',
      medias: 'medias',
      needMetering: 'needMetering',
      orgClassStudentGroupList: 'orgClassStudentGroupList',
      remindHour: 'remindHour',
      remindMinute: 'remindMinute',
      targetRole: 'targetRole',
      templateId: 'templateId',
      title: 'title',
      unitOfMeasurement: 'unitOfMeasurement',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canReissueCard: 'boolean',
      cardCycle: 'number',
      cardFrequency: { 'type': 'array', 'itemType': 'number' },
      cardRuleItemParamList: { 'type': 'array', 'itemType': BatchCreateRequestDataCardRuleItemParamList },
      classIds: { 'type': 'array', 'itemType': 'string' },
      classNames: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      effectDate: 'number',
      medias: 'string',
      needMetering: 'string',
      orgClassStudentGroupList: { 'type': 'array', 'itemType': BatchCreateRequestDataOrgClassStudentGroupList },
      remindHour: 'number',
      remindMinute: 'number',
      targetRole: 'string',
      templateId: 'number',
      title: 'string',
      unitOfMeasurement: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateResponseBodyResult extends $tea.Model {
  corpIdCardIdMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      corpIdCardIdMap: 'corpIdCardIdMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIdCardIdMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents extends $tea.Model {
  avatar?: string;
  name?: string;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      name: 'name',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      name: 'string',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequestOpenSelectItemListClassList extends $tea.Model {
  all?: boolean;
  classId?: string;
  className?: string;
  students?: BatchOrgCreateHWRequestOpenSelectItemListClassListStudents[];
  static names(): { [key: string]: string } {
    return {
      all: 'all',
      classId: 'classId',
      className: 'className',
      students: 'students',
    };
  }

  static types(): { [key: string]: any } {
    return {
      all: 'boolean',
      classId: 'string',
      className: 'string',
      students: { 'type': 'array', 'itemType': BatchOrgCreateHWRequestOpenSelectItemListClassListStudents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequestOpenSelectItemList extends $tea.Model {
  classList?: BatchOrgCreateHWRequestOpenSelectItemListClassList[];
  corpId?: string;
  selectedClassesDesc?: string;
  static names(): { [key: string]: string } {
    return {
      classList: 'classList',
      corpId: 'corpId',
      selectedClassesDesc: 'selectedClassesDesc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classList: { 'type': 'array', 'itemType': BatchOrgCreateHWRequestOpenSelectItemListClassList },
      corpId: 'string',
      selectedClassesDesc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponseBodyResultPublishList extends $tea.Model {
  corpid?: string;
  hwid?: number;
  static names(): { [key: string]: string } {
    return {
      corpid: 'corpid',
      hwid: 'hwid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpid: 'string',
      hwid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponseBodyResult extends $tea.Model {
  publishList?: BatchOrgCreateHWResponseBodyResultPublishList[];
  static names(): { [key: string]: string } {
    return {
      publishList: 'publishList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      publishList: { 'type': 'array', 'itemType': BatchOrgCreateHWResponseBodyResultPublishList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardBatchQueryCardsResponseBodyResultCards extends $tea.Model {
  cardBizCode?: string;
  cardId?: number;
  cardStatus?: number;
  content?: string;
  corpId?: string;
  effectTime?: number;
  finished?: boolean;
  gmtCreate?: number;
  optEndTime?: number;
  optEndUserId?: string;
  optEndUserName?: string;
  sendTime?: number;
  startTime?: number;
  status?: number;
  teacherId?: string;
  teacherName?: string;
  title?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      cardId: 'cardId',
      cardStatus: 'cardStatus',
      content: 'content',
      corpId: 'corpId',
      effectTime: 'effectTime',
      finished: 'finished',
      gmtCreate: 'gmtCreate',
      optEndTime: 'optEndTime',
      optEndUserId: 'optEndUserId',
      optEndUserName: 'optEndUserName',
      sendTime: 'sendTime',
      startTime: 'startTime',
      status: 'status',
      teacherId: 'teacherId',
      teacherName: 'teacherName',
      title: 'title',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      cardId: 'number',
      cardStatus: 'number',
      content: 'string',
      corpId: 'string',
      effectTime: 'number',
      finished: 'boolean',
      gmtCreate: 'number',
      optEndTime: 'number',
      optEndUserId: 'string',
      optEndUserName: 'string',
      sendTime: 'number',
      startTime: 'number',
      status: 'number',
      teacherId: 'string',
      teacherName: 'string',
      title: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardBatchQueryCardsResponseBodyResult extends $tea.Model {
  cards?: CardBatchQueryCardsResponseBodyResultCards[];
  static names(): { [key: string]: string } {
    return {
      cards: 'cards',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cards: { 'type': 'array', 'itemType': CardBatchQueryCardsResponseBodyResultCards },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardResponseBodyResult extends $tea.Model {
  attr?: string;
  cardBizCode?: string;
  cardBizId?: string;
  cardContentCount?: number;
  cardCycle?: number;
  cardFrequency?: number[];
  cardId?: number;
  cardStatus?: number;
  cardUrl?: string;
  categoryContentTag?: string;
  categoryCoverImageUrl?: string;
  categoryCreateCardSmallImageUrl?: string;
  categoryListSmallImageUrl?: string;
  categoryName?: string;
  classIds?: string[];
  classNames?: string[];
  content?: string;
  corpId?: string;
  effectTime?: number;
  finished?: boolean;
  media?: string;
  optEndTime?: number;
  optEndUserId?: string;
  optEndUserName?: string;
  remindNotPunchCardHour?: number;
  remindNotPunchCardMinute?: number;
  sendTime?: number;
  sourceType?: string;
  startTime?: number;
  status?: number;
  systemTime?: number;
  teacherId?: string;
  teacherName?: string;
  templateCoverImageUrl?: string;
  title?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      attr: 'attr',
      cardBizCode: 'cardBizCode',
      cardBizId: 'cardBizId',
      cardContentCount: 'cardContentCount',
      cardCycle: 'cardCycle',
      cardFrequency: 'cardFrequency',
      cardId: 'cardId',
      cardStatus: 'cardStatus',
      cardUrl: 'cardUrl',
      categoryContentTag: 'categoryContentTag',
      categoryCoverImageUrl: 'categoryCoverImageUrl',
      categoryCreateCardSmallImageUrl: 'categoryCreateCardSmallImageUrl',
      categoryListSmallImageUrl: 'categoryListSmallImageUrl',
      categoryName: 'categoryName',
      classIds: 'classIds',
      classNames: 'classNames',
      content: 'content',
      corpId: 'corpId',
      effectTime: 'effectTime',
      finished: 'finished',
      media: 'media',
      optEndTime: 'optEndTime',
      optEndUserId: 'optEndUserId',
      optEndUserName: 'optEndUserName',
      remindNotPunchCardHour: 'remindNotPunchCardHour',
      remindNotPunchCardMinute: 'remindNotPunchCardMinute',
      sendTime: 'sendTime',
      sourceType: 'sourceType',
      startTime: 'startTime',
      status: 'status',
      systemTime: 'systemTime',
      teacherId: 'teacherId',
      teacherName: 'teacherName',
      templateCoverImageUrl: 'templateCoverImageUrl',
      title: 'title',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attr: 'string',
      cardBizCode: 'string',
      cardBizId: 'string',
      cardContentCount: 'number',
      cardCycle: 'number',
      cardFrequency: { 'type': 'array', 'itemType': 'number' },
      cardId: 'number',
      cardStatus: 'number',
      cardUrl: 'string',
      categoryContentTag: 'string',
      categoryCoverImageUrl: 'string',
      categoryCreateCardSmallImageUrl: 'string',
      categoryListSmallImageUrl: 'string',
      categoryName: 'string',
      classIds: { 'type': 'array', 'itemType': 'string' },
      classNames: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      corpId: 'string',
      effectTime: 'number',
      finished: 'boolean',
      media: 'string',
      optEndTime: 'number',
      optEndUserId: 'string',
      optEndUserName: 'string',
      remindNotPunchCardHour: 'number',
      remindNotPunchCardMinute: 'number',
      sendTime: 'number',
      sourceType: 'string',
      startTime: 'number',
      status: 'number',
      systemTime: 'number',
      teacherId: 'string',
      teacherName: 'string',
      templateCoverImageUrl: 'string',
      title: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess extends $tea.Model {
  date?: string;
  finishedStudentsNum?: number;
  needFinishStudentsNum?: number;
  taskCode?: string;
  today?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      finishedStudentsNum: 'finishedStudentsNum',
      needFinishStudentsNum: 'needFinishStudentsNum',
      taskCode: 'taskCode',
      today: 'today',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      finishedStudentsNum: 'number',
      needFinishStudentsNum: 'number',
      taskCode: 'string',
      today: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressResponseBodyResultClassStatistics extends $tea.Model {
  cardBizId?: string;
  cardBizName?: string;
  classId?: string;
  className?: string;
  process?: CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess[];
  static names(): { [key: string]: string } {
    return {
      cardBizId: 'cardBizId',
      cardBizName: 'cardBizName',
      classId: 'classId',
      className: 'className',
      process: 'process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizId: 'string',
      cardBizName: 'string',
      classId: 'string',
      className: 'string',
      process: { 'type': 'array', 'itemType': CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressResponseBodyResultPatriarchStatistics extends $tea.Model {
  cardTaskCode?: string;
  date?: string;
  isFinished?: boolean;
  isFinishedByReissueCard?: boolean;
  isLastDay?: boolean;
  reissueCard?: boolean;
  studentId?: string;
  studentName?: string;
  today?: string;
  userSubTaskId?: number;
  static names(): { [key: string]: string } {
    return {
      cardTaskCode: 'cardTaskCode',
      date: 'date',
      isFinished: 'isFinished',
      isFinishedByReissueCard: 'isFinishedByReissueCard',
      isLastDay: 'isLastDay',
      reissueCard: 'reissueCard',
      studentId: 'studentId',
      studentName: 'studentName',
      today: 'today',
      userSubTaskId: 'userSubTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardTaskCode: 'string',
      date: 'string',
      isFinished: 'boolean',
      isFinishedByReissueCard: 'boolean',
      isLastDay: 'boolean',
      reissueCard: 'boolean',
      studentId: 'string',
      studentName: 'string',
      today: 'string',
      userSubTaskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardGetCardFinishProgressResponseBodyResult extends $tea.Model {
  classStatistics?: CardGetCardFinishProgressResponseBodyResultClassStatistics[];
  patriarchStatistics?: CardGetCardFinishProgressResponseBodyResultPatriarchStatistics[];
  studentNameList?: string[];
  static names(): { [key: string]: string } {
    return {
      classStatistics: 'classStatistics',
      patriarchStatistics: 'patriarchStatistics',
      studentNameList: 'studentNameList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classStatistics: { 'type': 'array', 'itemType': CardGetCardFinishProgressResponseBodyResultClassStatistics },
      patriarchStatistics: { 'type': 'array', 'itemType': CardGetCardFinishProgressResponseBodyResultPatriarchStatistics },
      studentNameList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsResponseBodyResultPostsAuthor extends $tea.Model {
  showName?: string;
  userId?: string;
  userRole?: string;
  static names(): { [key: string]: string } {
    return {
      showName: 'showName',
      userId: 'userId',
      userRole: 'userRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      showName: 'string',
      userId: 'string',
      userRole: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsResponseBodyResultPostsContent extends $tea.Model {
  contentType?: number;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'number',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsResponseBodyResultPosts extends $tea.Model {
  author?: CardQueryCardFeedsResponseBodyResultPostsAuthor;
  bizType?: number;
  content?: CardQueryCardFeedsResponseBodyResultPostsContent;
  createAt?: number;
  feedType?: number;
  postId?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      author: 'author',
      bizType: 'bizType',
      content: 'content',
      createAt: 'createAt',
      feedType: 'feedType',
      postId: 'postId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      author: CardQueryCardFeedsResponseBodyResultPostsAuthor,
      bizType: 'number',
      content: CardQueryCardFeedsResponseBodyResultPostsContent,
      createAt: 'number',
      feedType: 'number',
      postId: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardQueryCardFeedsResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  posts?: CardQueryCardFeedsResponseBodyResultPosts[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      posts: 'posts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      posts: { 'type': 'array', 'itemType': CardQueryCardFeedsResponseBodyResultPosts },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppOrderRequestDetailList extends $tea.Model {
  goodsId?: string;
  goodsName?: string;
  goodsPrice?: number;
  goodsQuantity?: number;
  static names(): { [key: string]: string } {
    return {
      goodsId: 'goodsId',
      goodsName: 'goodsName',
      goodsPrice: 'goodsPrice',
      goodsQuantity: 'goodsQuantity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsId: 'string',
      goodsName: 'string',
      goodsPrice: 'number',
      goodsQuantity: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassRequestCustomClass extends $tea.Model {
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

export class CreateCustomClassResponseBodyResult extends $tea.Model {
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptRequestCustomDept extends $tea.Model {
  name?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptResponseBodyResult extends $tea.Model {
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlResponseBodyResult extends $tea.Model {
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

export class CreateOrderRequestDetailList extends $tea.Model {
  actualAmount?: number;
  itemAmount?: number;
  itemName?: string;
  scene?: number;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      itemAmount: 'itemAmount',
      itemName: 'itemName',
      scene: 'scene',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      itemAmount: 'number',
      itemName: 'string',
      scene: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrderFlowRequestDetailList extends $tea.Model {
  actualAmount?: number;
  itemAmount?: number;
  itemId?: number;
  itemName?: string;
  scene?: number;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      itemAmount: 'itemAmount',
      itemId: 'itemId',
      itemName: 'itemName',
      scene: 'scene',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      itemAmount: 'number',
      itemId: 'number',
      itemName: 'string',
      scene: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseRequestAttendParticipants extends $tea.Model {
  corpId?: string;
  participantId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      participantId: 'participantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      participantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseRequestTeachingParticipant extends $tea.Model {
  corpId?: string;
  participantId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      participantId: 'participantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      participantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseResponseBodyResult extends $tea.Model {
  courseCode?: string;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionEndDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionModels extends $tea.Model {
  sectionEndTime?: CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime;
  sectionIndex?: number;
  sectionName?: string;
  sectionStartTime?: CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime;
  sectionType?: string;
  static names(): { [key: string]: string } {
    return {
      sectionEndTime: 'sectionEndTime',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      sectionStartTime: 'sectionStartTime',
      sectionType: 'sectionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionEndTime: CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime,
      sectionIndex: 'number',
      sectionName: 'string',
      sectionStartTime: CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime,
      sectionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionStartDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSemesterEndDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSemesterStartDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigs extends $tea.Model {
  scheduleName?: string;
  schoolYear?: string;
  sectionEndDate?: CreateSectionConfigRequestSectionConfigsSectionEndDate;
  sectionModels?: CreateSectionConfigRequestSectionConfigsSectionModels[];
  sectionStartDate?: CreateSectionConfigRequestSectionConfigsSectionStartDate;
  semester?: number;
  semesterEndDate?: CreateSectionConfigRequestSectionConfigsSemesterEndDate;
  semesterStartDate?: CreateSectionConfigRequestSectionConfigsSemesterStartDate;
  static names(): { [key: string]: string } {
    return {
      scheduleName: 'scheduleName',
      schoolYear: 'schoolYear',
      sectionEndDate: 'sectionEndDate',
      sectionModels: 'sectionModels',
      sectionStartDate: 'sectionStartDate',
      semester: 'semester',
      semesterEndDate: 'semesterEndDate',
      semesterStartDate: 'semesterStartDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleName: 'string',
      schoolYear: 'string',
      sectionEndDate: CreateSectionConfigRequestSectionConfigsSectionEndDate,
      sectionModels: { 'type': 'array', 'itemType': CreateSectionConfigRequestSectionConfigsSectionModels },
      sectionStartDate: CreateSectionConfigRequestSectionConfigsSectionStartDate,
      semester: 'number',
      semesterEndDate: CreateSectionConfigRequestSectionConfigsSemesterEndDate,
      semesterStartDate: CreateSectionConfigRequestSectionConfigsSemesterStartDate,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSnsAppOrderRequestDetailList extends $tea.Model {
  goodsId?: string;
  goodsName?: string;
  goodsPrice?: number;
  goodsQuantity?: number;
  static names(): { [key: string]: string } {
    return {
      goodsId: 'goodsId',
      goodsName: 'goodsName',
      goodsPrice: 'goodsPrice',
      goodsQuantity: 'goodsQuantity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsId: 'string',
      goodsName: 'string',
      goodsPrice: 'number',
      goodsQuantity: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestCourserGroupItemModels extends $tea.Model {
  classPeriodType?: number;
  classroomId?: number;
  courseType?: number;
  courserGroupItemEndDate?: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate;
  courserGroupItemStartDate?: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate;
  dayOfWeek?: number;
  sectionIndex?: number[];
  static names(): { [key: string]: string } {
    return {
      classPeriodType: 'classPeriodType',
      classroomId: 'classroomId',
      courseType: 'courseType',
      courserGroupItemEndDate: 'courserGroupItemEndDate',
      courserGroupItemStartDate: 'courserGroupItemStartDate',
      dayOfWeek: 'dayOfWeek',
      sectionIndex: 'sectionIndex',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classPeriodType: 'number',
      classroomId: 'number',
      courseType: 'number',
      courserGroupItemEndDate: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate,
      courserGroupItemStartDate: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate,
      dayOfWeek: 'number',
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestTeacherInfos extends $tea.Model {
  participantRole?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      participantRole: 'participantRole',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantRole: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupResponseBodyCourseGroupInfo extends $tea.Model {
  courseGroupCode?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EduTeacherListResponseBodyResultTeacherDetails extends $tea.Model {
  name?: string;
  role?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      role: 'role',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      role: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EduTeacherListResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  teacherDetails?: EduTeacherListResponseBodyResultTeacherDetails[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      teacherDetails: 'teacherDetails',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      teacherDetails: { 'type': 'array', 'itemType': EduTeacherListResponseBodyResultTeacherDetails },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseRequestLivePlayInfoList extends $tea.Model {
  liveInputUrl?: string;
  liveOutputFlvUrl?: string;
  liveOutputHlsUrl?: string;
  liveType?: number;
  replayUrl?: string;
  static names(): { [key: string]: string } {
    return {
      liveInputUrl: 'liveInputUrl',
      liveOutputFlvUrl: 'liveOutputFlvUrl',
      liveOutputHlsUrl: 'liveOutputHlsUrl',
      liveType: 'liveType',
      replayUrl: 'replayUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveInputUrl: 'string',
      liveOutputFlvUrl: 'string',
      liveOutputHlsUrl: 'string',
      liveType: 'number',
      replayUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseResponseBodyUniversityCourseCommonResponse extends $tea.Model {
  courseCode?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildResponseBodyBindStudents extends $tea.Model {
  classId?: number;
  corpId?: string;
  period?: string;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      corpId: 'corpId',
      period: 'period',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      corpId: 'string',
      period: 'string',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEduUserIdentityResponseBodyData extends $tea.Model {
  matchGuardianRule?: boolean;
  matchTeacherRule?: boolean;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      matchGuardianRule: 'matchGuardianRule',
      matchTeacherRule: 'matchTeacherRule',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      matchGuardianRule: 'boolean',
      matchTeacherRule: 'boolean',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailResponseBodyPushModel extends $tea.Model {
  pushOrgNameList?: string[];
  pushRoleNameList?: string[];
  static names(): { [key: string]: string } {
    return {
      pushOrgNameList: 'pushOrgNameList',
      pushRoleNameList: 'pushRoleNameList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pushOrgNameList: { 'type': 'array', 'itemType': 'string' },
      pushRoleNameList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesResponseBodyCourseList extends $tea.Model {
  courseId?: string;
  coverUrl?: string;
  feedType?: number;
  jumpUrl?: string;
  startTime?: number;
  teacherId?: string;
  teacherName?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      courseId: 'courseId',
      coverUrl: 'coverUrl',
      feedType: 'feedType',
      jumpUrl: 'jumpUrl',
      startTime: 'startTime',
      teacherId: 'teacherId',
      teacherName: 'teacherName',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseId: 'string',
      coverUrl: 'string',
      feedType: 'number',
      jumpUrl: 'string',
      startTime: 'number',
      teacherId: 'string',
      teacherName: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointActionRecordResponseBodyResult extends $tea.Model {
  actionTime?: string;
  quantity?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      actionTime: 'actionTime',
      quantity: 'quantity',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionTime: 'string',
      quantity: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPointInfoResponseBodyResult extends $tea.Model {
  availableQuota?: number;
  endTime?: string;
  startTime?: string;
  static names(): { [key: string]: string } {
    return {
      availableQuota: 'availableQuota',
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      availableQuota: 'number',
      endTime: 'string',
      startTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResultAttendParticipants extends $tea.Model {
  corpId?: string;
  orgName?: string;
  participantId?: string;
  participantName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      orgName: 'orgName',
      participantId: 'participantId',
      participantName: 'participantName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      orgName: 'string',
      participantId: 'string',
      participantName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResultRecordInfos extends $tea.Model {
  startTime?: string;
  stopTime?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      startTime: 'startTime',
      stopTime: 'stopTime',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'string',
      stopTime: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResultTeachingParticipant extends $tea.Model {
  corpId?: string;
  orgName?: string;
  participantId?: string;
  participantName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      orgName: 'orgName',
      participantId: 'participantId',
      participantName: 'participantName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      orgName: 'string',
      participantId: 'string',
      participantName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResult extends $tea.Model {
  attendParticipants?: GetRemoteClassCourseResponseBodyResultAttendParticipants[];
  canEdit?: boolean;
  courseCode?: string;
  courseName?: string;
  endTime?: number;
  liveUrl?: string;
  recordInfos?: GetRemoteClassCourseResponseBodyResultRecordInfos[];
  roomStatus?: number;
  startTime?: number;
  status?: number;
  teachingParticipant?: GetRemoteClassCourseResponseBodyResultTeachingParticipant;
  static names(): { [key: string]: string } {
    return {
      attendParticipants: 'attendParticipants',
      canEdit: 'canEdit',
      courseCode: 'courseCode',
      courseName: 'courseName',
      endTime: 'endTime',
      liveUrl: 'liveUrl',
      recordInfos: 'recordInfos',
      roomStatus: 'roomStatus',
      startTime: 'startTime',
      status: 'status',
      teachingParticipant: 'teachingParticipant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendParticipants: { 'type': 'array', 'itemType': GetRemoteClassCourseResponseBodyResultAttendParticipants },
      canEdit: 'boolean',
      courseCode: 'string',
      courseName: 'string',
      endTime: 'number',
      liveUrl: 'string',
      recordInfos: { 'type': 'array', 'itemType': GetRemoteClassCourseResponseBodyResultRecordInfos },
      roomStatus: 'number',
      startTime: 'number',
      status: 'number',
      teachingParticipant: GetRemoteClassCourseResponseBodyResultTeachingParticipant,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersResponseBodyResult extends $tea.Model {
  corpId?: string;
  memberUserIdListInTrunkOrg?: string[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberUserIdListInTrunkOrg: 'memberUserIdListInTrunkOrg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberUserIdListInTrunkOrg: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesResponseBodyResult extends $tea.Model {
  shareRoleCode?: string;
  shareRoleName?: string;
  static names(): { [key: string]: string } {
    return {
      shareRoleCode: 'shareRoleCode',
      shareRoleName: 'shareRoleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shareRoleCode: 'string',
      shareRoleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskListResponseBodyTaskList extends $tea.Model {
  name?: string;
  taskId?: number;
  taskYear?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      taskId: 'taskId',
      taskYear: 'taskYear',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      taskId: 'number',
      taskYear: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskStudentListResponseBodyStudentList extends $tea.Model {
  name?: string;
  sexuality?: string;
  studentId?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      sexuality: 'sexuality',
      studentId: 'studentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      sexuality: 'string',
      studentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestCoursesDateModel extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestCoursesSectionModel extends $tea.Model {
  sectionIndex?: number;
  sectionName?: string;
  static names(): { [key: string]: string } {
    return {
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionIndex: 'number',
      sectionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestCourses extends $tea.Model {
  courseName?: string;
  creatorName?: string;
  dateModel?: InitCoursesOfClassRequestCoursesDateModel;
  location?: string;
  sectionModel?: InitCoursesOfClassRequestCoursesSectionModel;
  teacherStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      courseName: 'courseName',
      creatorName: 'creatorName',
      dateModel: 'dateModel',
      location: 'location',
      sectionModel: 'sectionModel',
      teacherStaffIds: 'teacherStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseName: 'string',
      creatorName: 'string',
      dateModel: InitCoursesOfClassRequestCoursesDateModel,
      location: 'string',
      sectionModel: InitCoursesOfClassRequestCoursesSectionModel,
      teacherStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigEnd extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigSectionModelsEnd extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigSectionModelsStart extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigSectionModels extends $tea.Model {
  end?: InitCoursesOfClassRequestSectionConfigSectionModelsEnd;
  sectionIndex?: number;
  sectionType?: string;
  start?: InitCoursesOfClassRequestSectionConfigSectionModelsStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionIndex: 'sectionIndex',
      sectionType: 'sectionType',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: InitCoursesOfClassRequestSectionConfigSectionModelsEnd,
      sectionIndex: 'number',
      sectionType: 'string',
      start: InitCoursesOfClassRequestSectionConfigSectionModelsStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigStart extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfig extends $tea.Model {
  end?: InitCoursesOfClassRequestSectionConfigEnd;
  sectionModels?: InitCoursesOfClassRequestSectionConfigSectionModels[];
  start?: InitCoursesOfClassRequestSectionConfigStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionModels: 'sectionModels',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: InitCoursesOfClassRequestSectionConfigEnd,
      sectionModels: { 'type': 'array', 'itemType': InitCoursesOfClassRequestSectionConfigSectionModels },
      start: InitCoursesOfClassRequestSectionConfigStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestEnd extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestSectionModelsEnd extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestSectionModelsStart extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestSectionModels extends $tea.Model {
  end?: InsertSectionConfigRequestSectionModelsEnd;
  sectionIndex?: number;
  sectionName?: string;
  sectionType?: string;
  start?: InsertSectionConfigRequestSectionModelsStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      sectionType: 'sectionType',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: InsertSectionConfigRequestSectionModelsEnd,
      sectionIndex: 'number',
      sectionName: 'string',
      sectionType: 'string',
      start: InsertSectionConfigRequestSectionModelsStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestStart extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrderResponseBodyList extends $tea.Model {
  actualAmount?: number;
  buyerId?: string;
  corpId?: string;
  createTime?: number;
  endTime?: number;
  orderNo?: string;
  payTime?: number;
  refundNo?: string;
  scene?: number;
  startTime?: number;
  status?: number;
  tradeNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      actualAmount: 'actualAmount',
      buyerId: 'buyerId',
      corpId: 'corpId',
      createTime: 'createTime',
      endTime: 'endTime',
      orderNo: 'orderNo',
      payTime: 'payTime',
      refundNo: 'refundNo',
      scene: 'scene',
      startTime: 'startTime',
      status: 'status',
      tradeNo: 'tradeNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualAmount: 'number',
      buyerId: 'string',
      corpId: 'string',
      createTime: 'number',
      endTime: 'number',
      orderNo: 'string',
      payTime: 'number',
      refundNo: 'string',
      scene: 'number',
      startTime: 'number',
      status: 'number',
      tradeNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageQueryDevicesResponseBodyList extends $tea.Model {
  gmtExpiry?: number;
  model?: string;
  name?: string;
  sn?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      gmtExpiry: 'gmtExpiry',
      model: 'model',
      name: 'name',
      sn: 'sn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtExpiry: 'number',
      model: 'string',
      name: 'string',
      sn: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList extends $tea.Model {
  liveInputUrl?: string;
  liveOutputUrl?: string;
  liveType?: number;
  replayUrl?: string;
  static names(): { [key: string]: string } {
    return {
      liveInputUrl: 'liveInputUrl',
      liveOutputUrl: 'liveOutputUrl',
      liveType: 'liveType',
      replayUrl: 'replayUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveInputUrl: 'string',
      liveOutputUrl: 'string',
      liveType: 'number',
      replayUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse extends $tea.Model {
  confirmStatus?: boolean;
  courseCode?: string;
  livePlayInfoList?: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList[];
  static names(): { [key: string]: string } {
    return {
      confirmStatus: 'confirmStatus',
      courseCode: 'courseCode',
      livePlayInfoList: 'livePlayInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      confirmStatus: 'boolean',
      courseCode: 'string',
      livePlayInfoList: { 'type': 'array', 'itemType': PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProvidePointResponseBodyResult extends $tea.Model {
  availableQuota?: number;
  provideNum?: number;
  provideSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      availableQuota: 'availableQuota',
      provideNum: 'provideNum',
      provideSuccess: 'provideSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      availableQuota: 'number',
      provideNum: 'number',
      provideSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList extends $tea.Model {
  avator?: string;
  name?: string;
  uid?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avator: 'avator',
      name: 'name',
      uid: 'uid',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avator: 'string',
      name: 'string',
      uid: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBodyResultExt extends $tea.Model {
  backgroundColor?: string;
  classId?: number;
  fontColor?: string;
  teacherList?: QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList[];
  static names(): { [key: string]: string } {
    return {
      backgroundColor: 'backgroundColor',
      classId: 'classId',
      fontColor: 'fontColor',
      teacherList: 'teacherList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundColor: 'string',
      classId: 'number',
      fontColor: 'string',
      teacherList: { 'type': 'array', 'itemType': QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBodyResult extends $tea.Model {
  creatorOrgId?: number;
  ext?: QueryAllSubjectsFromClassScheduleResponseBodyResultExt;
  periodCode?: string;
  subjectCode?: string;
  subjectName?: string;
  static names(): { [key: string]: string } {
    return {
      creatorOrgId: 'creatorOrgId',
      ext: 'ext',
      periodCode: 'periodCode',
      subjectCode: 'subjectCode',
      subjectName: 'subjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorOrgId: 'number',
      ext: QueryAllSubjectsFromClassScheduleResponseBodyResultExt,
      periodCode: 'string',
      subjectCode: 'string',
      subjectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigEnd extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigSectionModelsEnd extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigSectionModelsStart extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigSectionModels extends $tea.Model {
  end?: QueryClassScheduleResponseBodyConfigSectionModelsEnd;
  sectionIndex?: number;
  sectionName?: string;
  sectionType?: string;
  start?: QueryClassScheduleResponseBodyConfigSectionModelsStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      sectionType: 'sectionType',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: QueryClassScheduleResponseBodyConfigSectionModelsEnd,
      sectionIndex: 'number',
      sectionName: 'string',
      sectionType: 'string',
      start: QueryClassScheduleResponseBodyConfigSectionModelsStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigStart extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfig extends $tea.Model {
  end?: QueryClassScheduleResponseBodyConfigEnd;
  sectionModels?: QueryClassScheduleResponseBodyConfigSectionModels[];
  start?: QueryClassScheduleResponseBodyConfigStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionModels: 'sectionModels',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: QueryClassScheduleResponseBodyConfigEnd,
      sectionModels: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyConfigSectionModels },
      start: QueryClassScheduleResponseBodyConfigStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyCourseDTOSClassrooms extends $tea.Model {
  interactInfo?: string;
  targetId?: string;
  static names(): { [key: string]: string } {
    return {
      interactInfo: 'interactInfo',
      targetId: 'targetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      interactInfo: 'string',
      targetId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyCourseDTOSEduUserModels extends $tea.Model {
  name?: string;
  uid?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      uid: 'uid',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      uid: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyCourseDTOS extends $tea.Model {
  classId?: number;
  classrooms?: QueryClassScheduleResponseBodyCourseDTOSClassrooms[];
  code?: string;
  courseGroupCode?: string;
  coverUrl?: string;
  creatorCorpId?: string;
  creatorUserId?: string;
  creatorUserName?: string;
  eduUserModels?: QueryClassScheduleResponseBodyCourseDTOSEduUserModels[];
  endTime?: number;
  extInfo?: string;
  introduce?: string;
  name?: string;
  sectionIndex?: number;
  sectionName?: string;
  startTime?: number;
  status?: number;
  subjectCode?: string;
  teacherCorpId?: string;
  teacherUserId?: string;
  teacherUserName?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      classrooms: 'classrooms',
      code: 'code',
      courseGroupCode: 'courseGroupCode',
      coverUrl: 'coverUrl',
      creatorCorpId: 'creatorCorpId',
      creatorUserId: 'creatorUserId',
      creatorUserName: 'creatorUserName',
      eduUserModels: 'eduUserModels',
      endTime: 'endTime',
      extInfo: 'extInfo',
      introduce: 'introduce',
      name: 'name',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      startTime: 'startTime',
      status: 'status',
      subjectCode: 'subjectCode',
      teacherCorpId: 'teacherCorpId',
      teacherUserId: 'teacherUserId',
      teacherUserName: 'teacherUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      classrooms: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyCourseDTOSClassrooms },
      code: 'string',
      courseGroupCode: 'string',
      coverUrl: 'string',
      creatorCorpId: 'string',
      creatorUserId: 'string',
      creatorUserName: 'string',
      eduUserModels: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyCourseDTOSEduUserModels },
      endTime: 'number',
      extInfo: 'string',
      introduce: 'string',
      name: 'string',
      sectionIndex: 'number',
      sectionName: 'string',
      startTime: 'number',
      status: 'number',
      subjectCode: 'string',
      teacherCorpId: 'string',
      teacherUserId: 'string',
      teacherUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms extends $tea.Model {
  interactInfo?: string;
  targetId?: string;
  static names(): { [key: string]: string } {
    return {
      interactInfo: 'interactInfo',
      targetId: 'targetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      interactInfo: 'string',
      targetId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels extends $tea.Model {
  name?: string;
  uid?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      uid: 'uid',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      uid: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBodyResult extends $tea.Model {
  bizKey?: string;
  classId?: number;
  classrooms?: QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms[];
  code?: string;
  courseGroupCode?: string;
  coverUrl?: string;
  creatorCorpId?: string;
  creatorUserId?: string;
  creatorUserName?: string;
  eduUserModels?: QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels[];
  endTime?: number;
  extInfo?: string;
  introduce?: string;
  name?: string;
  sectionIndex?: number;
  sectionName?: string;
  startTime?: number;
  status?: number;
  subjectCode?: string;
  teacherCorpId?: string;
  teacherUserId?: string;
  teacherUserName?: string;
  static names(): { [key: string]: string } {
    return {
      bizKey: 'bizKey',
      classId: 'classId',
      classrooms: 'classrooms',
      code: 'code',
      courseGroupCode: 'courseGroupCode',
      coverUrl: 'coverUrl',
      creatorCorpId: 'creatorCorpId',
      creatorUserId: 'creatorUserId',
      creatorUserName: 'creatorUserName',
      eduUserModels: 'eduUserModels',
      endTime: 'endTime',
      extInfo: 'extInfo',
      introduce: 'introduce',
      name: 'name',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      startTime: 'startTime',
      status: 'status',
      subjectCode: 'subjectCode',
      teacherCorpId: 'teacherCorpId',
      teacherUserId: 'teacherUserId',
      teacherUserName: 'teacherUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizKey: 'string',
      classId: 'number',
      classrooms: { 'type': 'array', 'itemType': QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms },
      code: 'string',
      courseGroupCode: 'string',
      coverUrl: 'string',
      creatorCorpId: 'string',
      creatorUserId: 'string',
      creatorUserName: 'string',
      eduUserModels: { 'type': 'array', 'itemType': QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels },
      endTime: 'number',
      extInfo: 'string',
      introduce: 'string',
      name: 'string',
      sectionIndex: 'number',
      sectionName: 'string',
      startTime: 'number',
      status: 'number',
      subjectCode: 'string',
      teacherCorpId: 'string',
      teacherUserId: 'string',
      teacherUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultEnd extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultSectionModelsStart extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultSectionModels extends $tea.Model {
  end?: QueryClassScheduleConfigResponseBodyResultSectionModelsEnd;
  sectionIndex?: number;
  sectionName?: string;
  sectionType?: string;
  start?: QueryClassScheduleConfigResponseBodyResultSectionModelsStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      sectionType: 'sectionType',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: QueryClassScheduleConfigResponseBodyResultSectionModelsEnd,
      sectionIndex: 'number',
      sectionName: 'string',
      sectionType: 'string',
      start: QueryClassScheduleConfigResponseBodyResultSectionModelsStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultStart extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResult extends $tea.Model {
  classId?: number;
  end?: QueryClassScheduleConfigResponseBodyResultEnd;
  sectionModels?: QueryClassScheduleConfigResponseBodyResultSectionModels[];
  start?: QueryClassScheduleConfigResponseBodyResultStart;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      end: 'end',
      sectionModels: 'sectionModels',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      end: QueryClassScheduleConfigResponseBodyResultEnd,
      sectionModels: { 'type': 'array', 'itemType': QueryClassScheduleConfigResponseBodyResultSectionModels },
      start: QueryClassScheduleConfigResponseBodyResultStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponseBodyResultList extends $tea.Model {
  appStatus?: number;
  deviceCode?: string;
  deviceName?: string;
  static names(): { [key: string]: string } {
    return {
      appStatus: 'appStatus',
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appStatus: 'number',
      deviceCode: 'string',
      deviceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: QueryDeviceListByCorpIdResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryDeviceListByCorpIdResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesResponseBodySpaces extends $tea.Model {
  createTimeMillis?: number;
  modifyTimeMillis?: number;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeMillis: 'createTimeMillis',
      modifyTimeMillis: 'modifyTimeMillis',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeMillis: 'number',
      modifyTimeMillis: 'number',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListResponseBodyResult extends $tea.Model {
  corpId?: string;
  deviceCount?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceCount: 'deviceCount',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceCount: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo extends $tea.Model {
  secretKey?: string;
  static names(): { [key: string]: string } {
    return {
      secretKey: 'secretKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      secretKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomResponseBodyResult extends $tea.Model {
  classroomBuilding?: string;
  classroomCampus?: string;
  classroomFloor?: string;
  classroomId?: number;
  classroomName?: string;
  classroomNumber?: string;
  directBroadcast?: string;
  static names(): { [key: string]: string } {
    return {
      classroomBuilding: 'classroomBuilding',
      classroomCampus: 'classroomCampus',
      classroomFloor: 'classroomFloor',
      classroomId: 'classroomId',
      classroomName: 'classroomName',
      classroomNumber: 'classroomNumber',
      directBroadcast: 'directBroadcast',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomBuilding: 'string',
      classroomCampus: 'string',
      classroomFloor: 'string',
      classroomId: 'number',
      classroomName: 'string',
      classroomNumber: 'string',
      directBroadcast: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBodyResultAttendParticipants extends $tea.Model {
  corpId?: string;
  orgName?: string;
  participantId?: string;
  participantName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      orgName: 'orgName',
      participantId: 'participantId',
      participantName: 'participantName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      orgName: 'string',
      participantId: 'string',
      participantName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBodyResultTeachingParticipant extends $tea.Model {
  corpId?: string;
  orgName?: string;
  participantId?: string;
  participantName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      orgName: 'orgName',
      participantId: 'participantId',
      participantName: 'participantName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      orgName: 'string',
      participantId: 'string',
      participantName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBodyResult extends $tea.Model {
  attendParticipants?: QueryRemoteClassCourseResponseBodyResultAttendParticipants[];
  canEdit?: boolean;
  courseCode?: string;
  courseName?: string;
  courseWays?: string[];
  endTime?: number;
  startTime?: number;
  status?: number;
  teachingParticipant?: QueryRemoteClassCourseResponseBodyResultTeachingParticipant;
  static names(): { [key: string]: string } {
    return {
      attendParticipants: 'attendParticipants',
      canEdit: 'canEdit',
      courseCode: 'courseCode',
      courseName: 'courseName',
      courseWays: 'courseWays',
      endTime: 'endTime',
      startTime: 'startTime',
      status: 'status',
      teachingParticipant: 'teachingParticipant',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendParticipants: { 'type': 'array', 'itemType': QueryRemoteClassCourseResponseBodyResultAttendParticipants },
      canEdit: 'boolean',
      courseCode: 'string',
      courseName: 'string',
      courseWays: { 'type': 'array', 'itemType': 'string' },
      endTime: 'number',
      startTime: 'number',
      status: 'number',
      teachingParticipant: QueryRemoteClassCourseResponseBodyResultTeachingParticipant,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceResponseBodyUserFaceList extends $tea.Model {
  faceId?: string;
  name?: string;
  status?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      name: 'name',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      name: 'string',
      status: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataResponseBodyResult extends $tea.Model {
  classId?: number;
  courseCount?: number;
  courseHours?: number;
  subjectCode?: string;
  subjectName?: number;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      courseCount: 'courseCount',
      courseHours: 'courseHours',
      subjectCode: 'subjectCode',
      subjectName: 'subjectName',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      courseCount: 'number',
      courseHours: 'number',
      subjectCode: 'string',
      subjectName: 'number',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersResponseBodyResult extends $tea.Model {
  classId?: number;
  corpId?: string;
  periodCode?: string;
  subjectCode?: string;
  subjectName?: string;
  teacherName?: string;
  teacherUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      corpId: 'corpId',
      periodCode: 'periodCode',
      subjectCode: 'subjectCode',
      subjectName: 'subjectName',
      teacherName: 'teacherName',
      teacherUserId: 'teacherUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      corpId: 'string',
      periodCode: 'string',
      subjectCode: 'string',
      subjectName: 'string',
      teacherName: 'string',
      teacherUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsResponseBodyResult extends $tea.Model {
  classId?: number;
  corpId?: string;
  periodCode?: string;
  subjectCode?: string;
  subjectName?: string;
  teacherName?: string;
  teacherUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      corpId: 'corpId',
      periodCode: 'periodCode',
      subjectCode: 'subjectCode',
      subjectName: 'subjectName',
      teacherName: 'teacherName',
      teacherUserId: 'teacherUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      corpId: 'string',
      periodCode: 'string',
      subjectCode: 'string',
      subjectName: 'string',
      teacherName: 'string',
      teacherUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels extends $tea.Model {
  classPeriodType?: number;
  classroomId?: number;
  courseType?: number;
  courserGroupItemEndDate?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate;
  courserGroupItemStartDate?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate;
  dayOfWeek?: number;
  sectionIndex?: number[];
  static names(): { [key: string]: string } {
    return {
      classPeriodType: 'classPeriodType',
      classroomId: 'classroomId',
      courseType: 'courseType',
      courserGroupItemEndDate: 'courserGroupItemEndDate',
      courserGroupItemStartDate: 'courserGroupItemStartDate',
      dayOfWeek: 'dayOfWeek',
      sectionIndex: 'sectionIndex',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classPeriodType: 'number',
      classroomId: 'number',
      courseType: 'number',
      courserGroupItemEndDate: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate,
      courserGroupItemStartDate: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate,
      dayOfWeek: 'number',
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo extends $tea.Model {
  courseGroupCode?: string;
  courseGroupIntroduce?: string;
  courseGroupName?: string;
  courserGroupItemModels?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels[];
  isvCourseGroupCode?: string;
  periodCode?: string;
  schoolYear?: string;
  semester?: number;
  subjectName?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      courseGroupIntroduce: 'courseGroupIntroduce',
      courseGroupName: 'courseGroupName',
      courserGroupItemModels: 'courserGroupItemModels',
      isvCourseGroupCode: 'isvCourseGroupCode',
      periodCode: 'periodCode',
      schoolYear: 'schoolYear',
      semester: 'semester',
      subjectName: 'subjectName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      courseGroupIntroduce: 'string',
      courseGroupName: 'string',
      courserGroupItemModels: { 'type': 'array', 'itemType': QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels },
      isvCourseGroupCode: 'string',
      periodCode: 'string',
      schoolYear: 'string',
      semester: 'number',
      subjectName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveClassLearningDataResponseBodyResult extends $tea.Model {
  questionUploadUrlList?: string[];
  standardAnswerUploadUrlList?: string[];
  static names(): { [key: string]: string } {
    return {
      questionUploadUrlList: 'questionUploadUrlList',
      standardAnswerUploadUrlList: 'standardAnswerUploadUrlList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      questionUploadUrlList: { 'type': 'array', 'itemType': 'string' },
      standardAnswerUploadUrlList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataRequestWrongQuestions extends $tea.Model {
  knowledgePoints?: string[];
  questionNo?: string;
  questionPictureNum?: number;
  standardAnswerPictureNum?: number;
  userAnswerPictureNum?: number;
  static names(): { [key: string]: string } {
    return {
      knowledgePoints: 'knowledgePoints',
      questionNo: 'questionNo',
      questionPictureNum: 'questionPictureNum',
      standardAnswerPictureNum: 'standardAnswerPictureNum',
      userAnswerPictureNum: 'userAnswerPictureNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      knowledgePoints: { 'type': 'array', 'itemType': 'string' },
      questionNo: 'string',
      questionPictureNum: 'number',
      standardAnswerPictureNum: 'number',
      userAnswerPictureNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataResponseBodyResultWrongQuestions extends $tea.Model {
  questionNo?: string;
  questionUploadUrlList?: string[];
  standardAnswerUploadUrlList?: string[];
  userAnswerUploadUrlList?: string[];
  static names(): { [key: string]: string } {
    return {
      questionNo: 'questionNo',
      questionUploadUrlList: 'questionUploadUrlList',
      standardAnswerUploadUrlList: 'standardAnswerUploadUrlList',
      userAnswerUploadUrlList: 'userAnswerUploadUrlList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      questionNo: 'string',
      questionUploadUrlList: { 'type': 'array', 'itemType': 'string' },
      standardAnswerUploadUrlList: { 'type': 'array', 'itemType': 'string' },
      userAnswerUploadUrlList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveStudentLearningDataResponseBodyResult extends $tea.Model {
  saveSuccess?: boolean;
  wrongQuestions?: SaveStudentLearningDataResponseBodyResultWrongQuestions[];
  static names(): { [key: string]: string } {
    return {
      saveSuccess: 'saveSuccess',
      wrongQuestions: 'wrongQuestions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      saveSuccess: 'boolean',
      wrongQuestions: { 'type': 'array', 'itemType': SaveStudentLearningDataResponseBodyResultWrongQuestions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersResponseBodyUsers extends $tea.Model {
  classId?: number;
  deptName?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      deptName: 'deptName',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      deptName: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseRequestLivePlayInfoList extends $tea.Model {
  liveInputUrl?: string;
  liveOutputFlvUrl?: string;
  liveOutputHlsUrl?: string;
  liveType?: number;
  replayUrl?: string;
  static names(): { [key: string]: string } {
    return {
      liveInputUrl: 'liveInputUrl',
      liveOutputFlvUrl: 'liveOutputFlvUrl',
      liveOutputHlsUrl: 'liveOutputHlsUrl',
      liveType: 'liveType',
      replayUrl: 'replayUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveInputUrl: 'string',
      liveOutputFlvUrl: 'string',
      liveOutputHlsUrl: 'string',
      liveType: 'number',
      replayUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseResponseBodyUniversityCourseCommonResponse extends $tea.Model {
  courseCode?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareResponseBodyUniversityCourseCommonResponse extends $tea.Model {
  courseCode?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestCoursesDateModel extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestCoursesSectionModel extends $tea.Model {
  sectionIndex?: number;
  sectionName?: string;
  sectionType?: string;
  static names(): { [key: string]: string } {
    return {
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
      sectionType: 'sectionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionIndex: 'number',
      sectionName: 'string',
      sectionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestCourses extends $tea.Model {
  courseCode?: string;
  courseGroupCode?: string;
  courseName?: string;
  creatorName?: string;
  dateModel?: UpdateCoursesOfClassRequestCoursesDateModel;
  deleteTag?: boolean;
  location?: string;
  sectionModel?: UpdateCoursesOfClassRequestCoursesSectionModel;
  teacherStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      courseGroupCode: 'courseGroupCode',
      courseName: 'courseName',
      creatorName: 'creatorName',
      dateModel: 'dateModel',
      deleteTag: 'deleteTag',
      location: 'location',
      sectionModel: 'sectionModel',
      teacherStaffIds: 'teacherStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      courseGroupCode: 'string',
      courseName: 'string',
      creatorName: 'string',
      dateModel: UpdateCoursesOfClassRequestCoursesDateModel,
      deleteTag: 'boolean',
      location: 'string',
      sectionModel: UpdateCoursesOfClassRequestCoursesSectionModel,
      teacherStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfigSectionModels extends $tea.Model {
  end?: UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd;
  sectionIndex?: number;
  sectionType?: string;
  start?: UpdateCoursesOfClassRequestSectionConfigSectionModelsStart;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      sectionIndex: 'sectionIndex',
      sectionType: 'sectionType',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd,
      sectionIndex: 'number',
      sectionType: 'string',
      start: UpdateCoursesOfClassRequestSectionConfigSectionModelsStart,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfig extends $tea.Model {
  sectionModels?: UpdateCoursesOfClassRequestSectionConfigSectionModels[];
  static names(): { [key: string]: string } {
    return {
      sectionModels: 'sectionModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionModels: { 'type': 'array', 'itemType': UpdateCoursesOfClassRequestSectionConfigSectionModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseRequestAttendParticipants extends $tea.Model {
  corpId?: string;
  participantId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      participantId: 'participantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      participantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseRequestTeachingParticipant extends $tea.Model {
  corpId?: string;
  participantId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      participantId: 'participantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      participantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends $tea.Model {
  dayOfMonth?: number;
  month?: number;
  year?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      month: 'month',
      year: 'year',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      month: 'number',
      year: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequestCourserGroupItemModels extends $tea.Model {
  classPeriodType?: number;
  classroomId?: number;
  courseType?: number;
  courserGroupItemEndDate?: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate;
  courserGroupItemStartDate?: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate;
  dayOfWeek?: number;
  sectionIndex?: number[];
  static names(): { [key: string]: string } {
    return {
      classPeriodType: 'classPeriodType',
      classroomId: 'classroomId',
      courseType: 'courseType',
      courserGroupItemEndDate: 'courserGroupItemEndDate',
      courserGroupItemStartDate: 'courserGroupItemStartDate',
      dayOfWeek: 'dayOfWeek',
      sectionIndex: 'sectionIndex',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classPeriodType: 'number',
      classroomId: 'number',
      courseType: 'number',
      courserGroupItemEndDate: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate,
      courserGroupItemStartDate: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate,
      dayOfWeek: 'number',
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
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


  async activateDeviceWithOptions(request: ActivateDeviceRequest, headers: ActivateDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<ActivateDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.licenseKey)) {
      body["licenseKey"] = request.licenseKey;
    }

    if (!Util.isUnset(request.model)) {
      body["model"] = request.model;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "ActivateDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/devices/activate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ActivateDeviceResponse>(await this.execute(params, req, runtime), new ActivateDeviceResponse({}));
  }

  async activateDevice(request: ActivateDeviceRequest): Promise<ActivateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ActivateDeviceHeaders({ });
    return await this.activateDeviceWithOptions(request, headers, runtime);
  }

  async addDeviceWithOptions(request: AddDeviceRequest, headers: AddDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<AddDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.model)) {
      body["model"] = request.model;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
      action: "AddDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/devices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddDeviceResponse>(await this.execute(params, req, runtime), new AddDeviceResponse({}));
  }

  async addDevice(request: AddDeviceRequest): Promise<AddDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddDeviceHeaders({ });
    return await this.addDeviceWithOptions(request, headers, runtime);
  }

  async addSchoolConfigWithOptions(request: AddSchoolConfigRequest, headers: AddSchoolConfigHeaders, runtime: $Util.RuntimeOptions): Promise<AddSchoolConfigResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.operatorName)) {
      body["operatorName"] = request.operatorName;
    }

    if (!Util.isUnset(request.temperatureUpLimit)) {
      body["temperatureUpLimit"] = request.temperatureUpLimit;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddSchoolConfig",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/schools/configurations`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddSchoolConfigResponse>(await this.execute(params, req, runtime), new AddSchoolConfigResponse({}));
  }

  async addSchoolConfig(request: AddSchoolConfigRequest): Promise<AddSchoolConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddSchoolConfigHeaders({ });
    return await this.addSchoolConfigWithOptions(request, headers, runtime);
  }

  async assignClassWithOptions(request: AssignClassRequest, headers: AssignClassHeaders, runtime: $Util.RuntimeOptions): Promise<AssignClassResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      body["classId"] = request.classId;
    }

    if (!Util.isUnset(request.isFinish)) {
      body["isFinish"] = request.isFinish;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.studentId)) {
      body["studentId"] = request.studentId;
    }

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
      action: "AssignClass",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/newGrades/tasks/students/classes/assign`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AssignClassResponse>(await this.execute(params, req, runtime), new AssignClassResponse({}));
  }

  async assignClass(request: AssignClassRequest): Promise<AssignClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AssignClassHeaders({ });
    return await this.assignClassWithOptions(request, headers, runtime);
  }

  async batchCreateWithOptions(request: BatchCreateRequest, headers: BatchCreateHeaders, runtime: $Util.RuntimeOptions): Promise<BatchCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizCode)) {
      body["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.identifier)) {
      body["identifier"] = request.identifier;
    }

    if (!Util.isUnset(request.jsVersion)) {
      body["jsVersion"] = request.jsVersion;
    }

    if (!Util.isUnset(request.sourceType)) {
      body["sourceType"] = request.sourceType;
    }

    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchCreate",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BatchCreateResponse>(await this.execute(params, req, runtime), new BatchCreateResponse({}));
  }

  async batchCreate(request: BatchCreateRequest): Promise<BatchCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateHeaders({ });
    return await this.batchCreateWithOptions(request, headers, runtime);
  }

  async batchOrgCreateHWWithOptions(request: BatchOrgCreateHWRequest, headers: BatchOrgCreateHWHeaders, runtime: $Util.RuntimeOptions): Promise<BatchOrgCreateHWResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attributes)) {
      body["attributes"] = request.attributes;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.courseName)) {
      body["courseName"] = request.courseName;
    }

    if (!Util.isUnset(request.hwContent)) {
      body["hwContent"] = request.hwContent;
    }

    if (!Util.isUnset(request.hwDeadline)) {
      body["hwDeadline"] = request.hwDeadline;
    }

    if (!Util.isUnset(request.hwDeadlineOpen)) {
      body["hwDeadlineOpen"] = request.hwDeadlineOpen;
    }

    if (!Util.isUnset(request.hwMedia)) {
      body["hwMedia"] = request.hwMedia;
    }

    if (!Util.isUnset(request.hwPhoto)) {
      body["hwPhoto"] = request.hwPhoto;
    }

    if (!Util.isUnset(request.hwTitle)) {
      body["hwTitle"] = request.hwTitle;
    }

    if (!Util.isUnset(request.hwType)) {
      body["hwType"] = request.hwType;
    }

    if (!Util.isUnset(request.hwVideo)) {
      body["hwVideo"] = request.hwVideo;
    }

    if (!Util.isUnset(request.identifier)) {
      body["identifier"] = request.identifier;
    }

    if (!Util.isUnset(request.openSelectItemList)) {
      body["openSelectItemList"] = request.openSelectItemList;
    }

    if (!Util.isUnset(request.scheduledRelease)) {
      body["scheduledRelease"] = request.scheduledRelease;
    }

    if (!Util.isUnset(request.scheduledTime)) {
      body["scheduledTime"] = request.scheduledTime;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.targetRole)) {
      body["targetRole"] = request.targetRole;
    }

    if (!Util.isUnset(request.teacherName)) {
      body["teacherName"] = request.teacherName;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      body["teacherUserId"] = request.teacherUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchOrgCreateHW",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/homeworks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BatchOrgCreateHWResponse>(await this.execute(params, req, runtime), new BatchOrgCreateHWResponse({}));
  }

  async batchOrgCreateHW(request: BatchOrgCreateHWRequest): Promise<BatchOrgCreateHWResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchOrgCreateHWHeaders({ });
    return await this.batchOrgCreateHWWithOptions(request, headers, runtime);
  }

  async cancelOrderWithOptions(request: CancelOrderRequest, headers: CancelOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CancelOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
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
      action: "CancelOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelOrderResponse>(await this.execute(params, req, runtime), new CancelOrderResponse({}));
  }

  async cancelOrder(request: CancelOrderRequest): Promise<CancelOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelOrderHeaders({ });
    return await this.cancelOrderWithOptions(request, headers, runtime);
  }

  async cancelSnsOrderWithOptions(request: CancelSnsOrderRequest, headers: CancelSnsOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CancelSnsOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.alipayAppId)) {
      body["alipayAppId"] = request.alipayAppId;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CancelSnsOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/snsUserOrders/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelSnsOrderResponse>(await this.execute(params, req, runtime), new CancelSnsOrderResponse({}));
  }

  async cancelSnsOrder(request: CancelSnsOrderRequest): Promise<CancelSnsOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelSnsOrderHeaders({ });
    return await this.cancelSnsOrderWithOptions(request, headers, runtime);
  }

  async cancelUserOrderWithOptions(request: CancelUserOrderRequest, headers: CancelUserOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CancelUserOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.alipayAppId)) {
      body["alipayAppId"] = request.alipayAppId;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CancelUserOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/userOrders/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelUserOrderResponse>(await this.execute(params, req, runtime), new CancelUserOrderResponse({}));
  }

  async cancelUserOrder(request: CancelUserOrderRequest): Promise<CancelUserOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelUserOrderHeaders({ });
    return await this.cancelUserOrderWithOptions(request, headers, runtime);
  }

  async cardBatchQueryCardsWithOptions(request: CardBatchQueryCardsRequest, headers: CardBatchQueryCardsHeaders, runtime: $Util.RuntimeOptions): Promise<CardBatchQueryCardsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizCode)) {
      body["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset(request.cardIds)) {
      body["cardIds"] = request.cardIds;
    }

    if (!Util.isUnset(request.sourceType)) {
      body["sourceType"] = request.sourceType;
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
      action: "CardBatchQueryCards",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards/tasks/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardBatchQueryCardsResponse>(await this.execute(params, req, runtime), new CardBatchQueryCardsResponse({}));
  }

  async cardBatchQueryCards(request: CardBatchQueryCardsRequest): Promise<CardBatchQueryCardsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardBatchQueryCardsHeaders({ });
    return await this.cardBatchQueryCardsWithOptions(request, headers, runtime);
  }

  async cardDeleteCardWithOptions(request: CardDeleteCardRequest, headers: CardDeleteCardHeaders, runtime: $Util.RuntimeOptions): Promise<CardDeleteCardResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizCode)) {
      query["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset(request.cardBizId)) {
      query["cardBizId"] = request.cardBizId;
    }

    if (!Util.isUnset(request.cardId)) {
      query["cardId"] = request.cardId;
    }

    if (!Util.isUnset(request.sourceType)) {
      query["sourceType"] = request.sourceType;
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
      action: "CardDeleteCard",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardDeleteCardResponse>(await this.execute(params, req, runtime), new CardDeleteCardResponse({}));
  }

  async cardDeleteCard(request: CardDeleteCardRequest): Promise<CardDeleteCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardDeleteCardHeaders({ });
    return await this.cardDeleteCardWithOptions(request, headers, runtime);
  }

  async cardEndCardWithOptions(request: CardEndCardRequest, headers: CardEndCardHeaders, runtime: $Util.RuntimeOptions): Promise<CardEndCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizCode)) {
      body["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset(request.cardBizId)) {
      body["cardBizId"] = request.cardBizId;
    }

    if (!Util.isUnset(request.cardId)) {
      body["cardId"] = request.cardId;
    }

    if (!Util.isUnset(request.sourceType)) {
      body["sourceType"] = request.sourceType;
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
      action: "CardEndCard",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards/finish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardEndCardResponse>(await this.execute(params, req, runtime), new CardEndCardResponse({}));
  }

  async cardEndCard(request: CardEndCardRequest): Promise<CardEndCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardEndCardHeaders({ });
    return await this.cardEndCardWithOptions(request, headers, runtime);
  }

  async cardGetCardWithOptions(request: CardGetCardRequest, headers: CardGetCardHeaders, runtime: $Util.RuntimeOptions): Promise<CardGetCardResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardId)) {
      query["cardId"] = request.cardId;
    }

    if (!Util.isUnset(request.sourceType)) {
      query["sourceType"] = request.sourceType;
    }

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
      action: "CardGetCard",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards/tasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardGetCardResponse>(await this.execute(params, req, runtime), new CardGetCardResponse({}));
  }

  async cardGetCard(request: CardGetCardRequest): Promise<CardGetCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardGetCardHeaders({ });
    return await this.cardGetCardWithOptions(request, headers, runtime);
  }

  async cardGetCardFinishProgressWithOptions(request: CardGetCardFinishProgressRequest, headers: CardGetCardFinishProgressHeaders, runtime: $Util.RuntimeOptions): Promise<CardGetCardFinishProgressResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizCode)) {
      query["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset(request.cardBizId)) {
      query["cardBizId"] = request.cardBizId;
    }

    if (!Util.isUnset(request.cardId)) {
      query["cardId"] = request.cardId;
    }

    if (!Util.isUnset(request.sourceType)) {
      query["sourceType"] = request.sourceType;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
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
      action: "CardGetCardFinishProgress",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards/completionProgress`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardGetCardFinishProgressResponse>(await this.execute(params, req, runtime), new CardGetCardFinishProgressResponse({}));
  }

  async cardGetCardFinishProgress(request: CardGetCardFinishProgressRequest): Promise<CardGetCardFinishProgressResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardGetCardFinishProgressHeaders({ });
    return await this.cardGetCardFinishProgressWithOptions(request, headers, runtime);
  }

  async cardQueryCardFeedsWithOptions(request: CardQueryCardFeedsRequest, headers: CardQueryCardFeedsHeaders, runtime: $Util.RuntimeOptions): Promise<CardQueryCardFeedsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.cardBizCode)) {
      query["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset(request.cardBizId)) {
      query["cardBizId"] = request.cardBizId;
    }

    if (!Util.isUnset(request.cardId)) {
      query["cardId"] = request.cardId;
    }

    if (!Util.isUnset(request.count)) {
      query["count"] = request.count;
    }

    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.feedType)) {
      query["feedType"] = request.feedType;
    }

    if (!Util.isUnset(request.needFinishProcess)) {
      query["needFinishProcess"] = request.needFinishProcess;
    }

    if (!Util.isUnset(request.sourceType)) {
      query["sourceType"] = request.sourceType;
    }

    if (!Util.isUnset(request.studentId)) {
      query["studentId"] = request.studentId;
    }

    if (!Util.isUnset(request.subBizId)) {
      query["subBizId"] = request.subBizId;
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
      action: "CardQueryCardFeeds",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/cards/feeds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardQueryCardFeedsResponse>(await this.execute(params, req, runtime), new CardQueryCardFeedsResponse({}));
  }

  async cardQueryCardFeeds(request: CardQueryCardFeedsRequest): Promise<CardQueryCardFeedsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardQueryCardFeedsHeaders({ });
    return await this.cardQueryCardFeedsWithOptions(request, headers, runtime);
  }

  async checkRestrictionWithOptions(request: CheckRestrictionRequest, headers: CheckRestrictionHeaders, runtime: $Util.RuntimeOptions): Promise<CheckRestrictionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actualAmount)) {
      body["actualAmount"] = request.actualAmount;
    }

    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "CheckRestriction",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/restrictions/check`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckRestrictionResponse>(await this.execute(params, req, runtime), new CheckRestrictionResponse({}));
  }

  async checkRestriction(request: CheckRestrictionRequest): Promise<CheckRestrictionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckRestrictionHeaders({ });
    return await this.checkRestrictionWithOptions(request, headers, runtime);
  }

  async consumePointWithOptions(request: ConsumePointRequest, headers: ConsumePointHeaders, runtime: $Util.RuntimeOptions): Promise<ConsumePointResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ConsumePoint",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/poins/consume`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConsumePointResponse>(await this.execute(params, req, runtime), new ConsumePointResponse({}));
  }

  async consumePoint(request: ConsumePointRequest): Promise<ConsumePointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsumePointHeaders({ });
    return await this.consumePointWithOptions(request, headers, runtime);
  }

  async courseSchedulingComplimentNoticeWithOptions(request: CourseSchedulingComplimentNoticeRequest, headers: CourseSchedulingComplimentNoticeHeaders, runtime: $Util.RuntimeOptions): Promise<CourseSchedulingComplimentNoticeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "CourseSchedulingComplimentNotice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/schedules/finishNotify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CourseSchedulingComplimentNoticeResponse>(await this.execute(params, req, runtime), new CourseSchedulingComplimentNoticeResponse({}));
  }

  async courseSchedulingComplimentNotice(request: CourseSchedulingComplimentNoticeRequest): Promise<CourseSchedulingComplimentNoticeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CourseSchedulingComplimentNoticeHeaders({ });
    return await this.courseSchedulingComplimentNoticeWithOptions(request, headers, runtime);
  }

  async createAppOrderWithOptions(request: CreateAppOrderRequest, headers: CreateAppOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAppOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actualAmount)) {
      body["actualAmount"] = request.actualAmount;
    }

    if (!Util.isUnset(request.alipayAppId)) {
      body["alipayAppId"] = request.alipayAppId;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.detailList)) {
      body["detailList"] = request.detailList;
    }

    if (!Util.isUnset(request.labelAmount)) {
      body["labelAmount"] = request.labelAmount;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.merchantOrderNo)) {
      body["merchantOrderNo"] = request.merchantOrderNo;
    }

    if (!Util.isUnset(request.outerUserId)) {
      body["outerUserId"] = request.outerUserId;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateAppOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/appOrders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAppOrderResponse>(await this.execute(params, req, runtime), new CreateAppOrderResponse({}));
  }

  async createAppOrder(request: CreateAppOrderRequest): Promise<CreateAppOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAppOrderHeaders({ });
    return await this.createAppOrderWithOptions(request, headers, runtime);
  }

  async createCustomClassWithOptions(request: CreateCustomClassRequest, headers: CreateCustomClassHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomClassResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customClass)) {
      body["customClass"] = request.customClass;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.superId)) {
      body["superId"] = request.superId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateCustomClass",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/customClasses`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateCustomClassResponse>(await this.execute(params, req, runtime), new CreateCustomClassResponse({}));
  }

  async createCustomClass(request: CreateCustomClassRequest): Promise<CreateCustomClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomClassHeaders({ });
    return await this.createCustomClassWithOptions(request, headers, runtime);
  }

  async createCustomDeptWithOptions(request: CreateCustomDeptRequest, headers: CreateCustomDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomDeptResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customDept)) {
      body["customDept"] = request.customDept;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.superId)) {
      body["superId"] = request.superId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateCustomDept",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/customDepts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateCustomDeptResponse>(await this.execute(params, req, runtime), new CreateCustomDeptResponse({}));
  }

  async createCustomDept(request: CreateCustomDeptRequest): Promise<CreateCustomDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomDeptHeaders({ });
    return await this.createCustomDeptWithOptions(request, headers, runtime);
  }

  async createEduAssetSpaceWithOptions(request: CreateEduAssetSpaceRequest, headers: CreateEduAssetSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEduAssetSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.spaceDesc)) {
      body["spaceDesc"] = request.spaceDesc;
    }

    if (!Util.isUnset(request.spaceIcon)) {
      body["spaceIcon"] = request.spaceIcon;
    }

    if (!Util.isUnset(request.spaceName)) {
      body["spaceName"] = request.spaceName;
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
      action: "CreateEduAssetSpace",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/assets/spaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateEduAssetSpaceResponse>(await this.execute(params, req, runtime), new CreateEduAssetSpaceResponse({}));
  }

  async createEduAssetSpace(request: CreateEduAssetSpaceRequest): Promise<CreateEduAssetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEduAssetSpaceHeaders({ });
    return await this.createEduAssetSpaceWithOptions(request, headers, runtime);
  }

  async createFulfilRecordWithOptions(request: CreateFulfilRecordRequest, headers: CreateFulfilRecordHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFulfilRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizTime)) {
      body["bizTime"] = request.bizTime;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "CreateFulfilRecord",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/fulfilRecords`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateFulfilRecordResponse>(await this.execute(params, req, runtime), new CreateFulfilRecordResponse({}));
  }

  async createFulfilRecord(request: CreateFulfilRecordRequest): Promise<CreateFulfilRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFulfilRecordHeaders({ });
    return await this.createFulfilRecordWithOptions(request, headers, runtime);
  }

  async createInviteUrlWithOptions(request: CreateInviteUrlRequest, headers: CreateInviteUrlHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInviteUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.targetOperator)) {
      body["targetOperator"] = request.targetOperator;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateInviteUrl",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/orgRelations/inviteUrls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateInviteUrlResponse>(await this.execute(params, req, runtime), new CreateInviteUrlResponse({}));
  }

  async createInviteUrl(request: CreateInviteUrlRequest): Promise<CreateInviteUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInviteUrlHeaders({ });
    return await this.createInviteUrlWithOptions(request, headers, runtime);
  }

  async createItemWithOptions(request: CreateItemRequest, headers: CreateItemHeaders, runtime: $Util.RuntimeOptions): Promise<CreateItemResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.effectType)) {
      body["effectType"] = request.effectType;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.optUser)) {
      body["optUser"] = request.optUser;
    }

    if (!Util.isUnset(request.periodType)) {
      body["periodType"] = request.periodType;
    }

    if (!Util.isUnset(request.price)) {
      body["price"] = request.price;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
      action: "CreateItem",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/items`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateItemResponse>(await this.execute(params, req, runtime), new CreateItemResponse({}));
  }

  async createItem(request: CreateItemRequest): Promise<CreateItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateItemHeaders({ });
    return await this.createItemWithOptions(request, headers, runtime);
  }

  async createOrderWithOptions(request: CreateOrderRequest, headers: CreateOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actualAmount)) {
      body["actualAmount"] = request.actualAmount;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
    }

    if (!Util.isUnset(request.detailList)) {
      body["detailList"] = request.detailList;
    }

    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.ftoken)) {
      body["ftoken"] = request.ftoken;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.terminalParams)) {
      body["terminalParams"] = request.terminalParams;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateOrderResponse>(await this.execute(params, req, runtime), new CreateOrderResponse({}));
  }

  async createOrder(request: CreateOrderRequest): Promise<CreateOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrderHeaders({ });
    return await this.createOrderWithOptions(request, headers, runtime);
  }

  async createOrderFlowWithOptions(request: CreateOrderFlowRequest, headers: CreateOrderFlowHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOrderFlowResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actualAmount)) {
      body["actualAmount"] = request.actualAmount;
    }

    if (!Util.isUnset(request.alipayUid)) {
      body["alipayUid"] = request.alipayUid;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
    }

    if (!Util.isUnset(request.detailList)) {
      body["detailList"] = request.detailList;
    }

    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.guardianUserId)) {
      body["guardianUserId"] = request.guardianUserId;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
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
      action: "CreateOrderFlow",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders/flows`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateOrderFlowResponse>(await this.execute(params, req, runtime), new CreateOrderFlowResponse({}));
  }

  async createOrderFlow(request: CreateOrderFlowRequest): Promise<CreateOrderFlowResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrderFlowHeaders({ });
    return await this.createOrderFlowWithOptions(request, headers, runtime);
  }

  async createPhysicalClassroomWithOptions(request: CreatePhysicalClassroomRequest, headers: CreatePhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<CreatePhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classroomBuilding)) {
      body["classroomBuilding"] = request.classroomBuilding;
    }

    if (!Util.isUnset(request.classroomCampus)) {
      body["classroomCampus"] = request.classroomCampus;
    }

    if (!Util.isUnset(request.classroomFloor)) {
      body["classroomFloor"] = request.classroomFloor;
    }

    if (!Util.isUnset(request.classroomName)) {
      body["classroomName"] = request.classroomName;
    }

    if (!Util.isUnset(request.classroomNumber)) {
      body["classroomNumber"] = request.classroomNumber;
    }

    if (!Util.isUnset(request.directBroadcast)) {
      body["directBroadcast"] = request.directBroadcast;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

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
      action: "CreatePhysicalClassroom",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/physicalClassrooms`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreatePhysicalClassroomResponse>(await this.execute(params, req, runtime), new CreatePhysicalClassroomResponse({}));
  }

  async createPhysicalClassroom(request: CreatePhysicalClassroomRequest): Promise<CreatePhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatePhysicalClassroomHeaders({ });
    return await this.createPhysicalClassroomWithOptions(request, headers, runtime);
  }

  async createRefundFlowWithOptions(request: CreateRefundFlowRequest, headers: CreateRefundFlowHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRefundFlowResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.operatorName)) {
      body["operatorName"] = request.operatorName;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
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
      action: "CreateRefundFlow",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/refunds/flows`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateRefundFlowResponse>(await this.execute(params, req, runtime), new CreateRefundFlowResponse({}));
  }

  async createRefundFlow(request: CreateRefundFlowRequest): Promise<CreateRefundFlowResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRefundFlowHeaders({ });
    return await this.createRefundFlowWithOptions(request, headers, runtime);
  }

  async createRemoteClassCourseWithOptions(request: CreateRemoteClassCourseRequest, headers: CreateRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRemoteClassCourseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendParticipants)) {
      body["attendParticipants"] = request.attendParticipants;
    }

    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.courseName)) {
      body["courseName"] = request.courseName;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.teachingParticipant)) {
      body["teachingParticipant"] = request.teachingParticipant;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateRemoteClassCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/courses`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateRemoteClassCourseResponse>(await this.execute(params, req, runtime), new CreateRemoteClassCourseResponse({}));
  }

  async createRemoteClassCourse(request: CreateRemoteClassCourseRequest): Promise<CreateRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRemoteClassCourseHeaders({ });
    return await this.createRemoteClassCourseWithOptions(request, headers, runtime);
  }

  async createSectionConfigWithOptions(request: CreateSectionConfigRequest, headers: CreateSectionConfigHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSectionConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.sectionConfigs)) {
      body["sectionConfigs"] = request.sectionConfigs;
    }

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
      action: "CreateSectionConfig",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/sectionConfigs`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateSectionConfigResponse>(await this.execute(params, req, runtime), new CreateSectionConfigResponse({}));
  }

  async createSectionConfig(request: CreateSectionConfigRequest): Promise<CreateSectionConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSectionConfigHeaders({ });
    return await this.createSectionConfigWithOptions(request, headers, runtime);
  }

  async createSnsAppOrderWithOptions(request: CreateSnsAppOrderRequest, headers: CreateSnsAppOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSnsAppOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actualAmount)) {
      body["actualAmount"] = request.actualAmount;
    }

    if (!Util.isUnset(request.alipayAppId)) {
      body["alipayAppId"] = request.alipayAppId;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.detailList)) {
      body["detailList"] = request.detailList;
    }

    if (!Util.isUnset(request.labelAmount)) {
      body["labelAmount"] = request.labelAmount;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.merchantOrderNo)) {
      body["merchantOrderNo"] = request.merchantOrderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateSnsAppOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/snsAppOrders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSnsAppOrderResponse>(await this.execute(params, req, runtime), new CreateSnsAppOrderResponse({}));
  }

  async createSnsAppOrder(request: CreateSnsAppOrderRequest): Promise<CreateSnsAppOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSnsAppOrderHeaders({ });
    return await this.createSnsAppOrderWithOptions(request, headers, runtime);
  }

  async createStsTokenWithOptions(request: CreateStsTokenRequest, headers: CreateStsTokenHeaders, runtime: $Util.RuntimeOptions): Promise<CreateStsTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceSn)) {
      body["deviceSn"] = request.deviceSn;
    }

    if (!Util.isUnset(request.stsType)) {
      body["stsType"] = request.stsType;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateStsToken",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/ststoken`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateStsTokenResponse>(await this.execute(params, req, runtime), new CreateStsTokenResponse({}));
  }

  async createStsToken(request: CreateStsTokenRequest): Promise<CreateStsTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateStsTokenHeaders({ });
    return await this.createStsTokenWithOptions(request, headers, runtime);
  }

  async createTokenWithOptions(request: CreateTokenRequest, headers: CreateTokenHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "CreateToken",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/tokens`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTokenResponse>(await this.execute(params, req, runtime), new CreateTokenResponse({}));
  }

  async createToken(request: CreateTokenRequest): Promise<CreateTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTokenHeaders({ });
    return await this.createTokenWithOptions(request, headers, runtime);
  }

  async createUniversityCourseGroupWithOptions(request: CreateUniversityCourseGroupRequest, headers: CreateUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupIntroduce)) {
      body["courseGroupIntroduce"] = request.courseGroupIntroduce;
    }

    if (!Util.isUnset(request.courseGroupName)) {
      body["courseGroupName"] = request.courseGroupName;
    }

    if (!Util.isUnset(request.courserGroupItemModels)) {
      body["courserGroupItemModels"] = request.courserGroupItemModels;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.isvCourseGroupCode)) {
      body["isvCourseGroupCode"] = request.isvCourseGroupCode;
    }

    if (!Util.isUnset(request.periodCode)) {
      body["periodCode"] = request.periodCode;
    }

    if (!Util.isUnset(request.schoolYear)) {
      body["schoolYear"] = request.schoolYear;
    }

    if (!Util.isUnset(request.semester)) {
      body["semester"] = request.semester;
    }

    if (!Util.isUnset(request.subjectName)) {
      body["subjectName"] = request.subjectName;
    }

    if (!Util.isUnset(request.teacherInfos)) {
      body["teacherInfos"] = request.teacherInfos;
    }

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
      action: "CreateUniversityCourseGroup",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courseGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateUniversityCourseGroupResponse>(await this.execute(params, req, runtime), new CreateUniversityCourseGroupResponse({}));
  }

  async createUniversityCourseGroup(request: CreateUniversityCourseGroupRequest): Promise<CreateUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUniversityCourseGroupHeaders({ });
    return await this.createUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async createUniversityStudentWithOptions(request: CreateUniversityStudentRequest, headers: CreateUniversityStudentHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUniversityStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      body["classId"] = request.classId;
    }

    if (!Util.isUnset(request.gender)) {
      body["gender"] = request.gender;
    }

    if (!Util.isUnset(request.identityNumber)) {
      body["identityNumber"] = request.identityNumber;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.studentNumber)) {
      body["studentNumber"] = request.studentNumber;
    }

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
      action: "CreateUniversityStudent",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/students`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateUniversityStudentResponse>(await this.execute(params, req, runtime), new CreateUniversityStudentResponse({}));
  }

  async createUniversityStudent(request: CreateUniversityStudentRequest): Promise<CreateUniversityStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUniversityStudentHeaders({ });
    return await this.createUniversityStudentWithOptions(request, headers, runtime);
  }

  async createUniversityTeacherWithOptions(request: CreateUniversityTeacherRequest, headers: CreateUniversityTeacherHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUniversityTeacherResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      body["classId"] = request.classId;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      body["teacherUserId"] = request.teacherUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateUniversityTeacher",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/teachers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateUniversityTeacherResponse>(await this.execute(params, req, runtime), new CreateUniversityTeacherResponse({}));
  }

  async createUniversityTeacher(request: CreateUniversityTeacherRequest): Promise<CreateUniversityTeacherResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUniversityTeacherHeaders({ });
    return await this.createUniversityTeacherWithOptions(request, headers, runtime);
  }

  async deactivateDeviceWithOptions(request: DeactivateDeviceRequest, headers: DeactivateDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<DeactivateDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.model)) {
      body["model"] = request.model;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "DeactivateDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/devices/deactivate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeactivateDeviceResponse>(await this.execute(params, req, runtime), new DeactivateDeviceResponse({}));
  }

  async deactivateDevice(request: DeactivateDeviceRequest): Promise<DeactivateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeactivateDeviceHeaders({ });
    return await this.deactivateDeviceWithOptions(request, headers, runtime);
  }

  async deductPointWithOptions(request: DeductPointRequest, headers: DeductPointHeaders, runtime: $Util.RuntimeOptions): Promise<DeductPointResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.deductDesc)) {
      body["deductDesc"] = request.deductDesc;
    }

    if (!Util.isUnset(request.deductDetailUrl)) {
      body["deductDetailUrl"] = request.deductDetailUrl;
    }

    if (!Util.isUnset(request.deductNum)) {
      body["deductNum"] = request.deductNum;
    }

    if (!Util.isUnset(request.pointType)) {
      body["pointType"] = request.pointType;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "DeductPoint",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/points/deduct`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeductPointResponse>(await this.execute(params, req, runtime), new DeductPointResponse({}));
  }

  async deductPoint(request: DeductPointRequest): Promise<DeductPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeductPointHeaders({ });
    return await this.deductPointWithOptions(request, headers, runtime);
  }

  async deleteDeptWithOptions(deptId: string, request: DeleteDeptRequest, headers: DeleteDeptHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

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
      action: "DeleteDept",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/depts/${deptId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteDeptResponse>(await this.execute(params, req, runtime), new DeleteDeptResponse({}));
  }

  async deleteDept(deptId: string, request: DeleteDeptRequest): Promise<DeleteDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDeptHeaders({ });
    return await this.deleteDeptWithOptions(deptId, request, headers, runtime);
  }

  async deleteDeviceWithOptions(request: DeleteDeviceRequest, headers: DeleteDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

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
      action: "DeleteDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/devices`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDeviceResponse>(await this.execute(params, req, runtime), new DeleteDeviceResponse({}));
  }

  async deleteDevice(request: DeleteDeviceRequest): Promise<DeleteDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDeviceHeaders({ });
    return await this.deleteDeviceWithOptions(request, headers, runtime);
  }

  async deleteDeviceOrgWithOptions(request: DeleteDeviceOrgRequest, headers: DeleteDeviceOrgHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDeviceOrgResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.deviceCode)) {
      query["deviceCode"] = request.deviceCode;
    }

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
      action: "DeleteDeviceOrg",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/deviceOrgs`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteDeviceOrgResponse>(await this.execute(params, req, runtime), new DeleteDeviceOrgResponse({}));
  }

  async deleteDeviceOrg(request: DeleteDeviceOrgRequest): Promise<DeleteDeviceOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDeviceOrgHeaders({ });
    return await this.deleteDeviceOrgWithOptions(request, headers, runtime);
  }

  async deleteGuardianWithOptions(classId: string, userId: string, request: DeleteGuardianRequest, headers: DeleteGuardianHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteGuardianResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

    if (!Util.isUnset(request.stuId)) {
      query["stuId"] = request.stuId;
    }

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
      action: "DeleteGuardian",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/${classId}/guardians/${userId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteGuardianResponse>(await this.execute(params, req, runtime), new DeleteGuardianResponse({}));
  }

  async deleteGuardian(classId: string, userId: string, request: DeleteGuardianRequest): Promise<DeleteGuardianResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteGuardianHeaders({ });
    return await this.deleteGuardianWithOptions(classId, userId, request, headers, runtime);
  }

  async deleteOrgRelationWithOptions(request: DeleteOrgRelationRequest, headers: DeleteOrgRelationHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteOrgRelationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
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
      action: "DeleteOrgRelation",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/orgRelations`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteOrgRelationResponse>(await this.execute(params, req, runtime), new DeleteOrgRelationResponse({}));
  }

  async deleteOrgRelation(request: DeleteOrgRelationRequest): Promise<DeleteOrgRelationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteOrgRelationHeaders({ });
    return await this.deleteOrgRelationWithOptions(request, headers, runtime);
  }

  async deletePhysicalClassroomWithOptions(request: DeletePhysicalClassroomRequest, headers: DeletePhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classroomId)) {
      query["classroomId"] = request.classroomId;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "DeletePhysicalClassroom",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/physicalClassrooms`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeletePhysicalClassroomResponse>(await this.execute(params, req, runtime), new DeletePhysicalClassroomResponse({}));
  }

  async deletePhysicalClassroom(request: DeletePhysicalClassroomRequest): Promise<DeletePhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePhysicalClassroomHeaders({ });
    return await this.deletePhysicalClassroomWithOptions(request, headers, runtime);
  }

  async deleteRemoteClassCourseWithOptions(courseCode: string, request: DeleteRemoteClassCourseRequest, headers: DeleteRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRemoteClassCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
    }

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
      action: "DeleteRemoteClassCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/courses/${courseCode}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteRemoteClassCourseResponse>(await this.execute(params, req, runtime), new DeleteRemoteClassCourseResponse({}));
  }

  async deleteRemoteClassCourse(courseCode: string, request: DeleteRemoteClassCourseRequest): Promise<DeleteRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRemoteClassCourseHeaders({ });
    return await this.deleteRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
  }

  async deleteStudentWithOptions(classId: string, userId: string, request: DeleteStudentRequest, headers: DeleteStudentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

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
      action: "DeleteStudent",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/${classId}/students/${userId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteStudentResponse>(await this.execute(params, req, runtime), new DeleteStudentResponse({}));
  }

  async deleteStudent(classId: string, userId: string, request: DeleteStudentRequest): Promise<DeleteStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteStudentHeaders({ });
    return await this.deleteStudentWithOptions(classId, userId, request, headers, runtime);
  }

  async deleteTeacherWithOptions(classId: string, userId: string, request: DeleteTeacherRequest, headers: DeleteTeacherHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTeacherResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.adviser)) {
      query["adviser"] = request.adviser;
    }

    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

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
      action: "DeleteTeacher",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/${classId}/teachers/${userId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteTeacherResponse>(await this.execute(params, req, runtime), new DeleteTeacherResponse({}));
  }

  async deleteTeacher(classId: string, userId: string, request: DeleteTeacherRequest): Promise<DeleteTeacherResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTeacherHeaders({ });
    return await this.deleteTeacherWithOptions(classId, userId, request, headers, runtime);
  }

  async deleteUniversityCourseGroupWithOptions(request: DeleteUniversityCourseGroupRequest, headers: DeleteUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      query["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "DeleteUniversityCourseGroup",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courseGroups`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteUniversityCourseGroupResponse>(await this.execute(params, req, runtime), new DeleteUniversityCourseGroupResponse({}));
  }

  async deleteUniversityCourseGroup(request: DeleteUniversityCourseGroupRequest): Promise<DeleteUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteUniversityCourseGroupHeaders({ });
    return await this.deleteUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async deleteUniversityStudentWithOptions(request: DeleteUniversityStudentRequest, headers: DeleteUniversityStudentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteUniversityStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      query["classId"] = request.classId;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.studentUserId)) {
      query["studentUserId"] = request.studentUserId;
    }

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
      action: "DeleteUniversityStudent",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/students`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteUniversityStudentResponse>(await this.execute(params, req, runtime), new DeleteUniversityStudentResponse({}));
  }

  async deleteUniversityStudent(request: DeleteUniversityStudentRequest): Promise<DeleteUniversityStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteUniversityStudentHeaders({ });
    return await this.deleteUniversityStudentWithOptions(request, headers, runtime);
  }

  async deleteUniversityTeacherWithOptions(request: DeleteUniversityTeacherRequest, headers: DeleteUniversityTeacherHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteUniversityTeacherResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      query["classId"] = request.classId;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.role)) {
      query["role"] = request.role;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      query["teacherUserId"] = request.teacherUserId;
    }

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
      action: "DeleteUniversityTeacher",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/teachers`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteUniversityTeacherResponse>(await this.execute(params, req, runtime), new DeleteUniversityTeacherResponse({}));
  }

  async deleteUniversityTeacher(request: DeleteUniversityTeacherRequest): Promise<DeleteUniversityTeacherResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteUniversityTeacherHeaders({ });
    return await this.deleteUniversityTeacherWithOptions(request, headers, runtime);
  }

  async deviceHeartbeatWithOptions(request: DeviceHeartbeatRequest, headers: DeviceHeartbeatHeaders, runtime: $Util.RuntimeOptions): Promise<DeviceHeartbeatResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

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
      action: "DeviceHeartbeat",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/heartbeats/report`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeviceHeartbeatResponse>(await this.execute(params, req, runtime), new DeviceHeartbeatResponse({}));
  }

  async deviceHeartbeat(request: DeviceHeartbeatRequest): Promise<DeviceHeartbeatResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceHeartbeatHeaders({ });
    return await this.deviceHeartbeatWithOptions(request, headers, runtime);
  }

  async eduTeacherListWithOptions(request: EduTeacherListRequest, headers: EduTeacherListHeaders, runtime: $Util.RuntimeOptions): Promise<EduTeacherListResponse> {
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
      action: "EduTeacherList",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/teachers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EduTeacherListResponse>(await this.execute(params, req, runtime), new EduTeacherListResponse({}));
  }

  async eduTeacherList(request: EduTeacherListRequest): Promise<EduTeacherListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EduTeacherListHeaders({ });
    return await this.eduTeacherListWithOptions(request, headers, runtime);
  }

  async endCourseWithOptions(request: EndCourseRequest, headers: EndCourseHeaders, runtime: $Util.RuntimeOptions): Promise<EndCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseCode)) {
      body["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.isvCode)) {
      body["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.livePlayInfoList)) {
      body["livePlayInfoList"] = request.livePlayInfoList;
    }

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
      action: "EndCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courses/end`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EndCourseResponse>(await this.execute(params, req, runtime), new EndCourseResponse({}));
  }

  async endCourse(request: EndCourseRequest): Promise<EndCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EndCourseHeaders({ });
    return await this.endCourseWithOptions(request, headers, runtime);
  }

  async getBindChildInfoWithOptions(request: GetBindChildInfoRequest, headers: GetBindChildInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBindChildInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schoolCorpId)) {
      query["schoolCorpId"] = request.schoolCorpId;
    }

    if (!Util.isUnset(request.studentUserId)) {
      query["studentUserId"] = request.studentUserId;
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
      action: "GetBindChildInfo",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/families/childs/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBindChildInfoResponse>(await this.execute(params, req, runtime), new GetBindChildInfoResponse({}));
  }

  async getBindChildInfo(request: GetBindChildInfoRequest): Promise<GetBindChildInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBindChildInfoHeaders({ });
    return await this.getBindChildInfoWithOptions(request, headers, runtime);
  }

  async getDefaultChildWithOptions(headers: GetDefaultChildHeaders, runtime: $Util.RuntimeOptions): Promise<GetDefaultChildResponse> {
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
      action: "GetDefaultChild",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/defaultChildren`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetDefaultChildResponse>(await this.execute(params, req, runtime), new GetDefaultChildResponse({}));
  }

  async getDefaultChild(): Promise<GetDefaultChildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDefaultChildHeaders({ });
    return await this.getDefaultChildWithOptions(headers, runtime);
  }

  async getEduUserIdentityWithOptions(request: GetEduUserIdentityRequest, headers: GetEduUserIdentityHeaders, runtime: $Util.RuntimeOptions): Promise<GetEduUserIdentityResponse> {
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
      action: "GetEduUserIdentity",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/apollos/activities/userIdentities`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEduUserIdentityResponse>(await this.execute(params, req, runtime), new GetEduUserIdentityResponse({}));
  }

  async getEduUserIdentity(request: GetEduUserIdentityRequest): Promise<GetEduUserIdentityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEduUserIdentityHeaders({ });
    return await this.getEduUserIdentityWithOptions(request, headers, runtime);
  }

  async getOpenCourseDetailWithOptions(courseId: string, headers: GetOpenCourseDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetOpenCourseDetailResponse> {
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
      action: "GetOpenCourseDetail",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/openCourse/${courseId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOpenCourseDetailResponse>(await this.execute(params, req, runtime), new GetOpenCourseDetailResponse({}));
  }

  async getOpenCourseDetail(courseId: string): Promise<GetOpenCourseDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenCourseDetailHeaders({ });
    return await this.getOpenCourseDetailWithOptions(courseId, headers, runtime);
  }

  async getOpenCoursesWithOptions(request: GetOpenCoursesRequest, headers: GetOpenCoursesHeaders, runtime: $Util.RuntimeOptions): Promise<GetOpenCoursesResponse> {
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
      action: "GetOpenCourses",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/openCourses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOpenCoursesResponse>(await this.execute(params, req, runtime), new GetOpenCoursesResponse({}));
  }

  async getOpenCourses(request: GetOpenCoursesRequest): Promise<GetOpenCoursesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenCoursesHeaders({ });
    return await this.getOpenCoursesWithOptions(request, headers, runtime);
  }

  async getPointActionRecordWithOptions(request: GetPointActionRecordRequest, headers: GetPointActionRecordHeaders, runtime: $Util.RuntimeOptions): Promise<GetPointActionRecordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      query["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.pointType)) {
      query["pointType"] = request.pointType;
    }

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
      action: "GetPointActionRecord",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/points/actionRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPointActionRecordResponse>(await this.execute(params, req, runtime), new GetPointActionRecordResponse({}));
  }

  async getPointActionRecord(request: GetPointActionRecordRequest): Promise<GetPointActionRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPointActionRecordHeaders({ });
    return await this.getPointActionRecordWithOptions(request, headers, runtime);
  }

  async getPointInfoWithOptions(request: GetPointInfoRequest, headers: GetPointInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPointInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pointType)) {
      query["pointType"] = request.pointType;
    }

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
      action: "GetPointInfo",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/points/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPointInfoResponse>(await this.execute(params, req, runtime), new GetPointInfoResponse({}));
  }

  async getPointInfo(request: GetPointInfoRequest): Promise<GetPointInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPointInfoHeaders({ });
    return await this.getPointInfoWithOptions(request, headers, runtime);
  }

  async getRemoteClassCourseWithOptions(courseCode: string, request: GetRemoteClassCourseRequest, headers: GetRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<GetRemoteClassCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

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
      action: "GetRemoteClassCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/courses/${courseCode}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetRemoteClassCourseResponse>(await this.execute(params, req, runtime), new GetRemoteClassCourseResponse({}));
  }

  async getRemoteClassCourse(courseCode: string, request: GetRemoteClassCourseRequest): Promise<GetRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRemoteClassCourseHeaders({ });
    return await this.getRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
  }

  async getShareRoleMembersWithOptions(shareRoleCode: string, headers: GetShareRoleMembersHeaders, runtime: $Util.RuntimeOptions): Promise<GetShareRoleMembersResponse> {
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
      action: "GetShareRoleMembers",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/shareRoles/${shareRoleCode}/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetShareRoleMembersResponse>(await this.execute(params, req, runtime), new GetShareRoleMembersResponse({}));
  }

  async getShareRoleMembers(shareRoleCode: string): Promise<GetShareRoleMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShareRoleMembersHeaders({ });
    return await this.getShareRoleMembersWithOptions(shareRoleCode, headers, runtime);
  }

  async getShareRolesWithOptions(headers: GetShareRolesHeaders, runtime: $Util.RuntimeOptions): Promise<GetShareRolesResponse> {
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
      action: "GetShareRoles",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/shareRoles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetShareRolesResponse>(await this.execute(params, req, runtime), new GetShareRolesResponse({}));
  }

  async getShareRoles(): Promise<GetShareRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShareRolesHeaders({ });
    return await this.getShareRolesWithOptions(headers, runtime);
  }

  async getTaskListWithOptions(request: GetTaskListRequest, headers: GetTaskListHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.taskYear)) {
      query["taskYear"] = request.taskYear;
    }

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
      action: "GetTaskList",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/newGrades/tasks/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTaskListResponse>(await this.execute(params, req, runtime), new GetTaskListResponse({}));
  }

  async getTaskList(request: GetTaskListRequest): Promise<GetTaskListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskListHeaders({ });
    return await this.getTaskListWithOptions(request, headers, runtime);
  }

  async getTaskStudentListWithOptions(request: GetTaskStudentListRequest, headers: GetTaskStudentListHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskStudentListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
    }

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
      action: "GetTaskStudentList",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/newGrades/tasks/students/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTaskStudentListResponse>(await this.execute(params, req, runtime), new GetTaskStudentListResponse({}));
  }

  async getTaskStudentList(request: GetTaskStudentListRequest): Promise<GetTaskStudentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskStudentListHeaders({ });
    return await this.getTaskStudentListWithOptions(request, headers, runtime);
  }

  async initCoursesOfClassWithOptions(classId: string, request: InitCoursesOfClassRequest, headers: InitCoursesOfClassHeaders, runtime: $Util.RuntimeOptions): Promise<InitCoursesOfClassResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courses)) {
      body["courses"] = request.courses;
    }

    if (!Util.isUnset(request.sectionConfig)) {
      body["sectionConfig"] = request.sectionConfig;
    }

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
      action: "InitCoursesOfClass",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/${classId}/courses/init`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<InitCoursesOfClassResponse>(await this.execute(params, req, runtime), new InitCoursesOfClassResponse({}));
  }

  async initCoursesOfClass(classId: string, request: InitCoursesOfClassRequest): Promise<InitCoursesOfClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitCoursesOfClassHeaders({ });
    return await this.initCoursesOfClassWithOptions(classId, request, headers, runtime);
  }

  async initDeviceWithOptions(request: InitDeviceRequest, headers: InitDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<InitDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.encryptPubKey)) {
      body["encryptPubKey"] = request.encryptPubKey;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "InitDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/devices/init`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InitDeviceResponse>(await this.execute(params, req, runtime), new InitDeviceResponse({}));
  }

  async initDevice(request: InitDeviceRequest): Promise<InitDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitDeviceHeaders({ });
    return await this.initDeviceWithOptions(request, headers, runtime);
  }

  async initVPaasDeviceWithOptions(request: InitVPaasDeviceRequest, headers: InitVPaasDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<InitVPaasDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
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
      action: "InitVPaasDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/devices/init`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InitVPaasDeviceResponse>(await this.execute(params, req, runtime), new InitVPaasDeviceResponse({}));
  }

  async initVPaasDevice(request: InitVPaasDeviceRequest): Promise<InitVPaasDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitVPaasDeviceHeaders({ });
    return await this.initVPaasDeviceWithOptions(request, headers, runtime);
  }

  async insertSectionConfigWithOptions(request: InsertSectionConfigRequest, headers: InsertSectionConfigHeaders, runtime: $Util.RuntimeOptions): Promise<InsertSectionConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.end)) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.scheduleName)) {
      body["scheduleName"] = request.scheduleName;
    }

    if (!Util.isUnset(request.sectionModels)) {
      body["sectionModels"] = request.sectionModels;
    }

    if (!Util.isUnset(request.start)) {
      body["start"] = request.start;
    }

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
      action: "InsertSectionConfig",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/schedules/configs`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<InsertSectionConfigResponse>(await this.execute(params, req, runtime), new InsertSectionConfigResponse({}));
  }

  async insertSectionConfig(request: InsertSectionConfigRequest): Promise<InsertSectionConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertSectionConfigHeaders({ });
    return await this.insertSectionConfigWithOptions(request, headers, runtime);
  }

  async listOrderWithOptions(request: ListOrderRequest, headers: ListOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ListOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createTimeEnd)) {
      body["createTimeEnd"] = request.createTimeEnd;
    }

    if (!Util.isUnset(request.createTimeStart)) {
      body["createTimeStart"] = request.createTimeStart;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.tradeNo)) {
      body["tradeNo"] = request.tradeNo;
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
      action: "ListOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListOrderResponse>(await this.execute(params, req, runtime), new ListOrderResponse({}));
  }

  async listOrder(request: ListOrderRequest): Promise<ListOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListOrderHeaders({ });
    return await this.listOrderWithOptions(request, headers, runtime);
  }

  async moveStudentWithOptions(request: MoveStudentRequest, headers: MoveStudentHeaders, runtime: $Util.RuntimeOptions): Promise<MoveStudentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.originClassId)) {
      body["originClassId"] = request.originClassId;
    }

    if (!Util.isUnset(request.targetClassId)) {
      body["targetClassId"] = request.targetClassId;
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
      action: "MoveStudent",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/students/move`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<MoveStudentResponse>(await this.execute(params, req, runtime), new MoveStudentResponse({}));
  }

  async moveStudent(request: MoveStudentRequest): Promise<MoveStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveStudentHeaders({ });
    return await this.moveStudentWithOptions(request, headers, runtime);
  }

  async pageQueryDevicesWithOptions(request: PageQueryDevicesRequest, headers: PageQueryDevicesHeaders, runtime: $Util.RuntimeOptions): Promise<PageQueryDevicesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      action: "PageQueryDevices",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/devices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PageQueryDevicesResponse>(await this.execute(params, req, runtime), new PageQueryDevicesResponse({}));
  }

  async pageQueryDevices(request: PageQueryDevicesRequest): Promise<PageQueryDevicesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageQueryDevicesHeaders({ });
    return await this.pageQueryDevicesWithOptions(request, headers, runtime);
  }

  async payOrderWithOptions(request: PayOrderRequest, headers: PayOrderHeaders, runtime: $Util.RuntimeOptions): Promise<PayOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PayOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders/pay`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PayOrderResponse>(await this.execute(params, req, runtime), new PayOrderResponse({}));
  }

  async payOrder(request: PayOrderRequest): Promise<PayOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PayOrderHeaders({ });
    return await this.payOrderWithOptions(request, headers, runtime);
  }

  async pollingConfirmStatusWithOptions(request: PollingConfirmStatusRequest, headers: PollingConfirmStatusHeaders, runtime: $Util.RuntimeOptions): Promise<PollingConfirmStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseCode)) {
      query["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.ext)) {
      query["ext"] = request.ext;
    }

    if (!Util.isUnset(request.isvCode)) {
      query["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "PollingConfirmStatus",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courses/pollingConfirmStatus`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PollingConfirmStatusResponse>(await this.execute(params, req, runtime), new PollingConfirmStatusResponse({}));
  }

  async pollingConfirmStatus(request: PollingConfirmStatusRequest): Promise<PollingConfirmStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PollingConfirmStatusHeaders({ });
    return await this.pollingConfirmStatusWithOptions(request, headers, runtime);
  }

  async preDialWithOptions(request: PreDialRequest, headers: PreDialHeaders, runtime: $Util.RuntimeOptions): Promise<PreDialResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callerUserId)) {
      body["callerUserId"] = request.callerUserId;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "PreDial",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/devices/preDial`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PreDialResponse>(await this.execute(params, req, runtime), new PreDialResponse({}));
  }

  async preDial(request: PreDialRequest): Promise<PreDialResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PreDialHeaders({ });
    return await this.preDialWithOptions(request, headers, runtime);
  }

  async providePointWithOptions(request: ProvidePointRequest, headers: ProvidePointHeaders, runtime: $Util.RuntimeOptions): Promise<ProvidePointResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionCode)) {
      body["actionCode"] = request.actionCode;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.pointType)) {
      body["pointType"] = request.pointType;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ProvidePoint",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/points/provide`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ProvidePointResponse>(await this.execute(params, req, runtime), new ProvidePointResponse({}));
  }

  async providePoint(request: ProvidePointRequest): Promise<ProvidePointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProvidePointHeaders({ });
    return await this.providePointWithOptions(request, headers, runtime);
  }

  async queryAllSubjectsFromClassScheduleWithOptions(tmpReq: QueryAllSubjectsFromClassScheduleRequest, headers: QueryAllSubjectsFromClassScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllSubjectsFromClassScheduleResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryAllSubjectsFromClassScheduleShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.classIds)) {
      request.classIdsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIdsShrink)) {
      query["classIds"] = request.classIdsShrink;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.periodCode)) {
      query["periodCode"] = request.periodCode;
    }

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
      action: "QueryAllSubjectsFromClassSchedule",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/subjects/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryAllSubjectsFromClassScheduleResponse>(await this.execute(params, req, runtime), new QueryAllSubjectsFromClassScheduleResponse({}));
  }

  async queryAllSubjectsFromClassSchedule(request: QueryAllSubjectsFromClassScheduleRequest): Promise<QueryAllSubjectsFromClassScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllSubjectsFromClassScheduleHeaders({ });
    return await this.queryAllSubjectsFromClassScheduleWithOptions(request, headers, runtime);
  }

  async queryClassScheduleWithOptions(request: QueryClassScheduleRequest, headers: QueryClassScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClassScheduleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.subscriberType)) {
      query["subscriberType"] = request.subscriberType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sectionIndexList)) {
      body["sectionIndexList"] = request.sectionIndexList;
    }

    if (!Util.isUnset(request.subscriberIds)) {
      body["subscriberIds"] = request.subscriberIds;
    }

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
      action: "QueryClassSchedule",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/schedules/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryClassScheduleResponse>(await this.execute(params, req, runtime), new QueryClassScheduleResponse({}));
  }

  async queryClassSchedule(request: QueryClassScheduleRequest): Promise<QueryClassScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClassScheduleHeaders({ });
    return await this.queryClassScheduleWithOptions(request, headers, runtime);
  }

  async queryClassScheduleByTimeSchoolWithOptions(request: QueryClassScheduleByTimeSchoolRequest, headers: QueryClassScheduleByTimeSchoolHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClassScheduleByTimeSchoolResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
      action: "QueryClassScheduleByTimeSchool",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/schools/classes/courses `,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryClassScheduleByTimeSchoolResponse>(await this.execute(params, req, runtime), new QueryClassScheduleByTimeSchoolResponse({}));
  }

  async queryClassScheduleByTimeSchool(request: QueryClassScheduleByTimeSchoolRequest): Promise<QueryClassScheduleByTimeSchoolResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClassScheduleByTimeSchoolHeaders({ });
    return await this.queryClassScheduleByTimeSchoolWithOptions(request, headers, runtime);
  }

  async queryClassScheduleConfigWithOptions(tmpReq: QueryClassScheduleConfigRequest, headers: QueryClassScheduleConfigHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClassScheduleConfigResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryClassScheduleConfigShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.classIds)) {
      request.classIdsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIdsShrink)) {
      query["classIds"] = request.classIdsShrink;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "QueryClassScheduleConfig",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/schedules/configs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryClassScheduleConfigResponse>(await this.execute(params, req, runtime), new QueryClassScheduleConfigResponse({}));
  }

  async queryClassScheduleConfig(request: QueryClassScheduleConfigRequest): Promise<QueryClassScheduleConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClassScheduleConfigHeaders({ });
    return await this.queryClassScheduleConfigWithOptions(request, headers, runtime);
  }

  async queryDeviceWithOptions(request: QueryDeviceRequest, headers: QueryDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

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
      action: "QueryDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpass/devices/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceResponse>(await this.execute(params, req, runtime), new QueryDeviceResponse({}));
  }

  async queryDevice(request: QueryDeviceRequest): Promise<QueryDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceHeaders({ });
    return await this.queryDeviceWithOptions(request, headers, runtime);
  }

  async queryDeviceListByCorpIdWithOptions(request: QueryDeviceListByCorpIdRequest, headers: QueryDeviceListByCorpIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceListByCorpIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
      action: "QueryDeviceListByCorpId",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/devices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceListByCorpIdResponse>(await this.execute(params, req, runtime), new QueryDeviceListByCorpIdResponse({}));
  }

  async queryDeviceListByCorpId(request: QueryDeviceListByCorpIdRequest): Promise<QueryDeviceListByCorpIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceListByCorpIdHeaders({ });
    return await this.queryDeviceListByCorpIdWithOptions(request, headers, runtime);
  }

  async queryEduAssetSpacesWithOptions(request: QueryEduAssetSpacesRequest, headers: QueryEduAssetSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEduAssetSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

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
      action: "QueryEduAssetSpaces",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/assets/spaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryEduAssetSpacesResponse>(await this.execute(params, req, runtime), new QueryEduAssetSpacesResponse({}));
  }

  async queryEduAssetSpaces(request: QueryEduAssetSpacesRequest): Promise<QueryEduAssetSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEduAssetSpacesHeaders({ });
    return await this.queryEduAssetSpacesWithOptions(request, headers, runtime);
  }

  async queryGroupIdWithOptions(request: QueryGroupIdRequest, headers: QueryGroupIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

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
      action: "QueryGroupId",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/faces/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupIdResponse>(await this.execute(params, req, runtime), new QueryGroupIdResponse({}));
  }

  async queryGroupId(request: QueryGroupIdRequest): Promise<QueryGroupIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupIdHeaders({ });
    return await this.queryGroupIdWithOptions(request, headers, runtime);
  }

  async queryOrderWithOptions(request: QueryOrderRequest, headers: QueryOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.alipayAppId)) {
      query["alipayAppId"] = request.alipayAppId;
    }

    if (!Util.isUnset(request.merchantId)) {
      query["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.orderNo)) {
      query["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      query["signature"] = request.signature;
    }

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
      action: "QueryOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOrderResponse>(await this.execute(params, req, runtime), new QueryOrderResponse({}));
  }

  async queryOrder(request: QueryOrderRequest): Promise<QueryOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrderHeaders({ });
    return await this.queryOrderWithOptions(request, headers, runtime);
  }

  async queryOrgRelationListWithOptions(request: QueryOrgRelationListRequest, headers: QueryOrgRelationListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgRelationListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

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
      action: "QueryOrgRelationList",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/orgRelations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgRelationListResponse>(await this.execute(params, req, runtime), new QueryOrgRelationListResponse({}));
  }

  async queryOrgRelationList(request: QueryOrgRelationListRequest): Promise<QueryOrgRelationListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgRelationListHeaders({ });
    return await this.queryOrgRelationListWithOptions(request, headers, runtime);
  }

  async queryOrgSecretKeyWithOptions(request: QueryOrgSecretKeyRequest, headers: QueryOrgSecretKeyHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgSecretKeyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvCode)) {
      query["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "QueryOrgSecretKey",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/secretKeys`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgSecretKeyResponse>(await this.execute(params, req, runtime), new QueryOrgSecretKeyResponse({}));
  }

  async queryOrgSecretKey(request: QueryOrgSecretKeyRequest): Promise<QueryOrgSecretKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgSecretKeyHeaders({ });
    return await this.queryOrgSecretKeyWithOptions(request, headers, runtime);
  }

  async queryOrgTypeWithOptions(headers: QueryOrgTypeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgTypeResponse> {
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
      action: "QueryOrgType",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orgTypes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgTypeResponse>(await this.execute(params, req, runtime), new QueryOrgTypeResponse({}));
  }

  async queryOrgType(): Promise<QueryOrgTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgTypeHeaders({ });
    return await this.queryOrgTypeWithOptions(headers, runtime);
  }

  async queryPayResultWithOptions(request: QueryPayResultRequest, headers: QueryPayResultHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPayResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.faceId)) {
      body["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "QueryPayResult",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/payResults/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPayResultResponse>(await this.execute(params, req, runtime), new QueryPayResultResponse({}));
  }

  async queryPayResult(request: QueryPayResultRequest): Promise<QueryPayResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPayResultHeaders({ });
    return await this.queryPayResultWithOptions(request, headers, runtime);
  }

  async queryPhysicalClassroomWithOptions(request: QueryPhysicalClassroomRequest, headers: QueryPhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classroomId)) {
      query["classroomId"] = request.classroomId;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "QueryPhysicalClassroom",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/physicalClassrooms`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryPhysicalClassroomResponse>(await this.execute(params, req, runtime), new QueryPhysicalClassroomResponse({}));
  }

  async queryPhysicalClassroom(request: QueryPhysicalClassroomRequest): Promise<QueryPhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPhysicalClassroomHeaders({ });
    return await this.queryPhysicalClassroomWithOptions(request, headers, runtime);
  }

  async queryPurchaseInfoWithOptions(request: QueryPurchaseInfoRequest, headers: QueryPurchaseInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPurchaseInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.merchantId)) {
      query["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.scene)) {
      query["scene"] = request.scene;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
      action: "QueryPurchaseInfo",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/users/purchases`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPurchaseInfoResponse>(await this.execute(params, req, runtime), new QueryPurchaseInfoResponse({}));
  }

  async queryPurchaseInfo(request: QueryPurchaseInfoRequest): Promise<QueryPurchaseInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPurchaseInfoHeaders({ });
    return await this.queryPurchaseInfoWithOptions(request, headers, runtime);
  }

  async queryRemoteClassCourseWithOptions(request: QueryRemoteClassCourseRequest, headers: QueryRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRemoteClassCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
      action: "QueryRemoteClassCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/courses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryRemoteClassCourseResponse>(await this.execute(params, req, runtime), new QueryRemoteClassCourseResponse({}));
  }

  async queryRemoteClassCourse(request: QueryRemoteClassCourseRequest): Promise<QueryRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRemoteClassCourseHeaders({ });
    return await this.queryRemoteClassCourseWithOptions(request, headers, runtime);
  }

  async querySchoolUserFaceWithOptions(request: QuerySchoolUserFaceRequest, headers: QuerySchoolUserFaceHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySchoolUserFaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
      action: "QuerySchoolUserFace",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/schools/faces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySchoolUserFaceResponse>(await this.execute(params, req, runtime), new QuerySchoolUserFaceResponse({}));
  }

  async querySchoolUserFace(request: QuerySchoolUserFaceRequest): Promise<QuerySchoolUserFaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySchoolUserFaceHeaders({ });
    return await this.querySchoolUserFaceWithOptions(request, headers, runtime);
  }

  async querySnsOrderWithOptions(request: QuerySnsOrderRequest, headers: QuerySnsOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySnsOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.alipayAppId)) {
      query["alipayAppId"] = request.alipayAppId;
    }

    if (!Util.isUnset(request.merchantId)) {
      query["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.orderNo)) {
      query["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.signature)) {
      query["signature"] = request.signature;
    }

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
      action: "QuerySnsOrder",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/snsOrders`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySnsOrderResponse>(await this.execute(params, req, runtime), new QuerySnsOrderResponse({}));
  }

  async querySnsOrder(request: QuerySnsOrderRequest): Promise<QuerySnsOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySnsOrderHeaders({ });
    return await this.querySnsOrderWithOptions(request, headers, runtime);
  }

  async queryStatisticsDataWithOptions(request: QueryStatisticsDataRequest, headers: QueryStatisticsDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryStatisticsDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sectionIndexList)) {
      body["sectionIndexList"] = request.sectionIndexList;
    }

    if (!Util.isUnset(request.teacherUserIds)) {
      body["teacherUserIds"] = request.teacherUserIds;
    }

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
      action: "QueryStatisticsData",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/schedules/statisticData/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryStatisticsDataResponse>(await this.execute(params, req, runtime), new QueryStatisticsDataResponse({}));
  }

  async queryStatisticsData(request: QueryStatisticsDataRequest): Promise<QueryStatisticsDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryStatisticsDataHeaders({ });
    return await this.queryStatisticsDataWithOptions(request, headers, runtime);
  }

  async querySubjectTeachersWithOptions(request: QuerySubjectTeachersRequest, headers: QuerySubjectTeachersHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySubjectTeachersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIds)) {
      query["classIds"] = request.classIds;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.subjectCode)) {
      query["subjectCode"] = request.subjectCode;
    }

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
      action: "QuerySubjectTeachers",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/subjects/teachers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QuerySubjectTeachersResponse>(await this.execute(params, req, runtime), new QuerySubjectTeachersResponse({}));
  }

  async querySubjectTeachers(request: QuerySubjectTeachersRequest): Promise<QuerySubjectTeachersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySubjectTeachersHeaders({ });
    return await this.querySubjectTeachersWithOptions(request, headers, runtime);
  }

  async queryTeachSubjectsWithOptions(request: QueryTeachSubjectsRequest, headers: QueryTeachSubjectsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTeachSubjectsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIds)) {
      query["classIds"] = request.classIds;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "QueryTeachSubjects",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/teachers/subjects`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryTeachSubjectsResponse>(await this.execute(params, req, runtime), new QueryTeachSubjectsResponse({}));
  }

  async queryTeachSubjects(request: QueryTeachSubjectsRequest): Promise<QueryTeachSubjectsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTeachSubjectsHeaders({ });
    return await this.queryTeachSubjectsWithOptions(request, headers, runtime);
  }

  async queryUniversityCourseGroupWithOptions(request: QueryUniversityCourseGroupRequest, headers: QueryUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      query["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "QueryUniversityCourseGroup",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courseGroups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryUniversityCourseGroupResponse>(await this.execute(params, req, runtime), new QueryUniversityCourseGroupResponse({}));
  }

  async queryUniversityCourseGroup(request: QueryUniversityCourseGroupRequest): Promise<QueryUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUniversityCourseGroupHeaders({ });
    return await this.queryUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async queryUserFaceWithOptions(request: QueryUserFaceRequest, headers: QueryUserFaceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserFaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.faceId)) {
      query["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

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
      action: "QueryUserFace",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/users/faces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserFaceResponse>(await this.execute(params, req, runtime), new QueryUserFaceResponse({}));
  }

  async queryUserFace(request: QueryUserFaceRequest): Promise<QueryUserFaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserFaceHeaders({ });
    return await this.queryUserFaceWithOptions(request, headers, runtime);
  }

  async queryUserPayInfoWithOptions(request: QueryUserPayInfoRequest, headers: QueryUserPayInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserPayInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.faceId)) {
      query["faceId"] = request.faceId;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
      action: "QueryUserPayInfo",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/orders/payInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserPayInfoResponse>(await this.execute(params, req, runtime), new QueryUserPayInfoResponse({}));
  }

  async queryUserPayInfo(request: QueryUserPayInfoRequest): Promise<QueryUserPayInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserPayInfoHeaders({ });
    return await this.queryUserPayInfoWithOptions(request, headers, runtime);
  }

  async removeDeviceWithOptions(request: RemoveDeviceRequest, headers: RemoveDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.merchantId)) {
      query["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

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
      action: "RemoveDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/devices`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveDeviceResponse>(await this.execute(params, req, runtime), new RemoveDeviceResponse({}));
  }

  async removeDevice(request: RemoveDeviceRequest): Promise<RemoveDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveDeviceHeaders({ });
    return await this.removeDeviceWithOptions(request, headers, runtime);
  }

  async reportDeviceLogWithOptions(request: ReportDeviceLogRequest, headers: ReportDeviceLogHeaders, runtime: $Util.RuntimeOptions): Promise<ReportDeviceLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
      action: "ReportDeviceLog",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/deviceLogs/report`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReportDeviceLogResponse>(await this.execute(params, req, runtime), new ReportDeviceLogResponse({}));
  }

  async reportDeviceLog(request: ReportDeviceLogRequest): Promise<ReportDeviceLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportDeviceLogHeaders({ });
    return await this.reportDeviceLogWithOptions(request, headers, runtime);
  }

  async reportDeviceUseLogWithOptions(request: ReportDeviceUseLogRequest, headers: ReportDeviceUseLogHeaders, runtime: $Util.RuntimeOptions): Promise<ReportDeviceUseLogResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
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
      action: "ReportDeviceUseLog",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/deviceUseLogs/report`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReportDeviceUseLogResponse>(await this.execute(params, req, runtime), new ReportDeviceUseLogResponse({}));
  }

  async reportDeviceUseLog(request: ReportDeviceUseLogRequest): Promise<ReportDeviceUseLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportDeviceUseLogHeaders({ });
    return await this.reportDeviceUseLogWithOptions(request, headers, runtime);
  }

  async rollbackDeductPointWithOptions(request: RollbackDeductPointRequest, headers: RollbackDeductPointHeaders, runtime: $Util.RuntimeOptions): Promise<RollbackDeductPointResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.pointType)) {
      body["pointType"] = request.pointType;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RollbackDeductPoint",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/deductPoints/rollback`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RollbackDeductPointResponse>(await this.execute(params, req, runtime), new RollbackDeductPointResponse({}));
  }

  async rollbackDeductPoint(request: RollbackDeductPointRequest): Promise<RollbackDeductPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RollbackDeductPointHeaders({ });
    return await this.rollbackDeductPointWithOptions(request, headers, runtime);
  }

  async saveClassLearningDataWithOptions(request: SaveClassLearningDataRequest, headers: SaveClassLearningDataHeaders, runtime: $Util.RuntimeOptions): Promise<SaveClassLearningDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assignNum)) {
      body["assignNum"] = request.assignNum;
    }

    if (!Util.isUnset(request.assignStudentUserIds)) {
      body["assignStudentUserIds"] = request.assignStudentUserIds;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.fileSuffix)) {
      body["fileSuffix"] = request.fileSuffix;
    }

    if (!Util.isUnset(request.generatedTime)) {
      body["generatedTime"] = request.generatedTime;
    }

    if (!Util.isUnset(request.questionNum)) {
      body["questionNum"] = request.questionNum;
    }

    if (!Util.isUnset(request.questionPictureNum)) {
      body["questionPictureNum"] = request.questionPictureNum;
    }

    if (!Util.isUnset(request.standardAnswerPictureNum)) {
      body["standardAnswerPictureNum"] = request.standardAnswerPictureNum;
    }

    if (!Util.isUnset(request.subjectCode)) {
      body["subjectCode"] = request.subjectCode;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      body["teacherUserId"] = request.teacherUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SaveClassLearningData",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/learnings/datas/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveClassLearningDataResponse>(await this.execute(params, req, runtime), new SaveClassLearningDataResponse({}));
  }

  async saveClassLearningData(request: SaveClassLearningDataRequest): Promise<SaveClassLearningDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveClassLearningDataHeaders({ });
    return await this.saveClassLearningDataWithOptions(request, headers, runtime);
  }

  async saveStudentLearningDataWithOptions(request: SaveStudentLearningDataRequest, headers: SaveStudentLearningDataHeaders, runtime: $Util.RuntimeOptions): Promise<SaveStudentLearningDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assignNum)) {
      body["assignNum"] = request.assignNum;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.correctNum)) {
      body["correctNum"] = request.correctNum;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.fileSuffix)) {
      body["fileSuffix"] = request.fileSuffix;
    }

    if (!Util.isUnset(request.generatedTime)) {
      body["generatedTime"] = request.generatedTime;
    }

    if (!Util.isUnset(request.questionNum)) {
      body["questionNum"] = request.questionNum;
    }

    if (!Util.isUnset(request.studentUserId)) {
      body["studentUserId"] = request.studentUserId;
    }

    if (!Util.isUnset(request.subjectCode)) {
      body["subjectCode"] = request.subjectCode;
    }

    if (!Util.isUnset(request.submitNum)) {
      body["submitNum"] = request.submitNum;
    }

    if (!Util.isUnset(request.wrongQuestions)) {
      body["wrongQuestions"] = request.wrongQuestions;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SaveStudentLearningData",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/students/learnings/datas/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveStudentLearningDataResponse>(await this.execute(params, req, runtime), new SaveStudentLearningDataResponse({}));
  }

  async saveStudentLearningData(request: SaveStudentLearningDataRequest): Promise<SaveStudentLearningDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveStudentLearningDataHeaders({ });
    return await this.saveStudentLearningDataWithOptions(request, headers, runtime);
  }

  async searchTeachersWithOptions(request: SearchTeachersRequest, headers: SearchTeachersHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTeachersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nameKeyword)) {
      query["nameKeyword"] = request.nameKeyword;
    }

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
      action: "SearchTeachers",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/teachers/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SearchTeachersResponse>(await this.execute(params, req, runtime), new SearchTeachersResponse({}));
  }

  async searchTeachers(request: SearchTeachersRequest): Promise<SearchTeachersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTeachersHeaders({ });
    return await this.searchTeachersWithOptions(request, headers, runtime);
  }

  async sendMessageWithOptions(request: SendMessageRequest, headers: SendMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.fromUserId)) {
      body["fromUserId"] = request.fromUserId;
    }

    if (!Util.isUnset(request.sn)) {
      body["sn"] = request.sn;
    }

    if (!Util.isUnset(request.toUserIdList)) {
      body["toUserIdList"] = request.toUserIdList;
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
      action: "SendMessage",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMessageResponse>(await this.execute(params, req, runtime), new SendMessageResponse({}));
  }

  async sendMessage(request: SendMessageRequest): Promise<SendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageHeaders({ });
    return await this.sendMessageWithOptions(request, headers, runtime);
  }

  async startCourseWithOptions(request: StartCourseRequest, headers: StartCourseHeaders, runtime: $Util.RuntimeOptions): Promise<StartCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseCode)) {
      body["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.isvCode)) {
      body["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.livePlayInfoList)) {
      body["livePlayInfoList"] = request.livePlayInfoList;
    }

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
      action: "StartCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courses/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StartCourseResponse>(await this.execute(params, req, runtime), new StartCourseResponse({}));
  }

  async startCourse(request: StartCourseRequest): Promise<StartCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCourseHeaders({ });
    return await this.startCourseWithOptions(request, headers, runtime);
  }

  async startCoursePrepareWithOptions(request: StartCoursePrepareRequest, headers: StartCoursePrepareHeaders, runtime: $Util.RuntimeOptions): Promise<StartCoursePrepareResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseDate)) {
      body["courseDate"] = request.courseDate;
    }

    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.isvCode)) {
      body["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.liveCoverImage)) {
      body["liveCoverImage"] = request.liveCoverImage;
    }

    if (!Util.isUnset(request.sectionIndex)) {
      body["sectionIndex"] = request.sectionIndex;
    }

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
      action: "StartCoursePrepare",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courses/prepare`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StartCoursePrepareResponse>(await this.execute(params, req, runtime), new StartCoursePrepareResponse({}));
  }

  async startCoursePrepare(request: StartCoursePrepareRequest): Promise<StartCoursePrepareResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCoursePrepareHeaders({ });
    return await this.startCoursePrepareWithOptions(request, headers, runtime);
  }

  async subscribeUniversityCourseGroupWithOptions(request: SubscribeUniversityCourseGroupRequest, headers: SubscribeUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.studentUserIds)) {
      body["studentUserIds"] = request.studentUserIds;
    }

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
      action: "SubscribeUniversityCourseGroup",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courseGroups/subscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SubscribeUniversityCourseGroupResponse>(await this.execute(params, req, runtime), new SubscribeUniversityCourseGroupResponse({}));
  }

  async subscribeUniversityCourseGroup(request: SubscribeUniversityCourseGroupRequest): Promise<SubscribeUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeUniversityCourseGroupHeaders({ });
    return await this.subscribeUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async unsubscribeUniversityCourseGroupWithOptions(request: UnsubscribeUniversityCourseGroupRequest, headers: UnsubscribeUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UnsubscribeUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.studentUserIds)) {
      body["studentUserIds"] = request.studentUserIds;
    }

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
      action: "UnsubscribeUniversityCourseGroup",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courseGroups/unsubscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UnsubscribeUniversityCourseGroupResponse>(await this.execute(params, req, runtime), new UnsubscribeUniversityCourseGroupResponse({}));
  }

  async unsubscribeUniversityCourseGroup(request: UnsubscribeUniversityCourseGroupRequest): Promise<UnsubscribeUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsubscribeUniversityCourseGroupHeaders({ });
    return await this.unsubscribeUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async updateCoursesOfClassWithOptions(classId: string, request: UpdateCoursesOfClassRequest, headers: UpdateCoursesOfClassHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCoursesOfClassResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courses)) {
      body["courses"] = request.courses;
    }

    if (!Util.isUnset(request.sectionConfig)) {
      body["sectionConfig"] = request.sectionConfig;
    }

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
      action: "UpdateCoursesOfClass",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/classes/${classId}/courses/schedules`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateCoursesOfClassResponse>(await this.execute(params, req, runtime), new UpdateCoursesOfClassResponse({}));
  }

  async updateCoursesOfClass(classId: string, request: UpdateCoursesOfClassRequest): Promise<UpdateCoursesOfClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCoursesOfClassHeaders({ });
    return await this.updateCoursesOfClassWithOptions(classId, request, headers, runtime);
  }

  async updatePhysicalClassroomWithOptions(request: UpdatePhysicalClassroomRequest, headers: UpdatePhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classroomBuilding)) {
      body["classroomBuilding"] = request.classroomBuilding;
    }

    if (!Util.isUnset(request.classroomCampus)) {
      body["classroomCampus"] = request.classroomCampus;
    }

    if (!Util.isUnset(request.classroomFloor)) {
      body["classroomFloor"] = request.classroomFloor;
    }

    if (!Util.isUnset(request.classroomId)) {
      body["classroomId"] = request.classroomId;
    }

    if (!Util.isUnset(request.classroomName)) {
      body["classroomName"] = request.classroomName;
    }

    if (!Util.isUnset(request.classroomNumber)) {
      body["classroomNumber"] = request.classroomNumber;
    }

    if (!Util.isUnset(request.directBroadcast)) {
      body["directBroadcast"] = request.directBroadcast;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

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
      action: "UpdatePhysicalClassroom",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/physicalClassrooms`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdatePhysicalClassroomResponse>(await this.execute(params, req, runtime), new UpdatePhysicalClassroomResponse({}));
  }

  async updatePhysicalClassroom(request: UpdatePhysicalClassroomRequest): Promise<UpdatePhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePhysicalClassroomHeaders({ });
    return await this.updatePhysicalClassroomWithOptions(request, headers, runtime);
  }

  async updateRemoteClassCourseWithOptions(request: UpdateRemoteClassCourseRequest, headers: UpdateRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRemoteClassCourseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendParticipants)) {
      body["attendParticipants"] = request.attendParticipants;
    }

    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.courseCode)) {
      body["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.courseName)) {
      body["courseName"] = request.courseName;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.teachingParticipant)) {
      body["teachingParticipant"] = request.teachingParticipant;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateRemoteClassCourse",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/courses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateRemoteClassCourseResponse>(await this.execute(params, req, runtime), new UpdateRemoteClassCourseResponse({}));
  }

  async updateRemoteClassCourse(request: UpdateRemoteClassCourseRequest): Promise<UpdateRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRemoteClassCourseHeaders({ });
    return await this.updateRemoteClassCourseWithOptions(request, headers, runtime);
  }

  async updateRemoteClassDeviceWithOptions(request: UpdateRemoteClassDeviceRequest, headers: UpdateRemoteClassDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRemoteClassDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.deviceCode)) {
      query["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.deviceName)) {
      query["deviceName"] = request.deviceName;
    }

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
      action: "UpdateRemoteClassDevice",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/remoteClasses/deviceNames`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRemoteClassDeviceResponse>(await this.execute(params, req, runtime), new UpdateRemoteClassDeviceResponse({}));
  }

  async updateRemoteClassDevice(request: UpdateRemoteClassDeviceRequest): Promise<UpdateRemoteClassDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRemoteClassDeviceHeaders({ });
    return await this.updateRemoteClassDeviceWithOptions(request, headers, runtime);
  }

  async updateUniversityCourseGroupWithOptions(request: UpdateUniversityCourseGroupRequest, headers: UpdateUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.courseGroupIntroduce)) {
      body["courseGroupIntroduce"] = request.courseGroupIntroduce;
    }

    if (!Util.isUnset(request.courseGroupName)) {
      body["courseGroupName"] = request.courseGroupName;
    }

    if (!Util.isUnset(request.courserGroupItemModels)) {
      body["courserGroupItemModels"] = request.courserGroupItemModels;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

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
      action: "UpdateUniversityCourseGroup",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/universities/courseGroups`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateUniversityCourseGroupResponse>(await this.execute(params, req, runtime), new UpdateUniversityCourseGroupResponse({}));
  }

  async updateUniversityCourseGroup(request: UpdateUniversityCourseGroupRequest): Promise<UpdateUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUniversityCourseGroupHeaders({ });
    return await this.updateUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async uploadLearningDataCallbackWithOptions(request: UploadLearningDataCallbackRequest, headers: UploadLearningDataCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<UploadLearningDataCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.generatedTime)) {
      body["generatedTime"] = request.generatedTime;
    }

    if (!Util.isUnset(request.studentUserId)) {
      body["studentUserId"] = request.studentUserId;
    }

    if (!Util.isUnset(request.subjectCode)) {
      body["subjectCode"] = request.subjectCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UploadLearningDataCallback",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/uploadLearnings/datas/callback`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadLearningDataCallbackResponse>(await this.execute(params, req, runtime), new UploadLearningDataCallbackResponse({}));
  }

  async uploadLearningDataCallback(request: UploadLearningDataCallbackRequest): Promise<UploadLearningDataCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadLearningDataCallbackHeaders({ });
    return await this.uploadLearningDataCallbackWithOptions(request, headers, runtime);
  }

  async vPaasProxyWithOptions(request: VPaasProxyRequest, headers: VPaasProxyHeaders, runtime: $Util.RuntimeOptions): Promise<VPaasProxyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionCode)) {
      body["actionCode"] = request.actionCode;
    }

    if (!Util.isUnset(request.params)) {
      body["params"] = request.params;
    }

    if (!Util.isUnset(request.publicKey)) {
      body["publicKey"] = request.publicKey;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "VPaasProxy",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/vpaas/proxy`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<VPaasProxyResponse>(await this.execute(params, req, runtime), new VPaasProxyResponse({}));
  }

  async vPaasProxy(request: VPaasProxyRequest): Promise<VPaasProxyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new VPaasProxyHeaders({ });
    return await this.vPaasProxyWithOptions(request, headers, runtime);
  }

  async validateNewGradeManagerWithOptions(request: ValidateNewGradeManagerRequest, headers: ValidateNewGradeManagerHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateNewGradeManagerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      action: "ValidateNewGradeManager",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/newGrades/tasks/validate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ValidateNewGradeManagerResponse>(await this.execute(params, req, runtime), new ValidateNewGradeManagerResponse({}));
  }

  async validateNewGradeManager(request: ValidateNewGradeManagerRequest): Promise<ValidateNewGradeManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateNewGradeManagerHeaders({ });
    return await this.validateNewGradeManagerWithOptions(request, headers, runtime);
  }

  async validateUserRoleWithOptions(request: ValidateUserRoleRequest, headers: ValidateUserRoleHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateUserRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.timeThreshold)) {
      body["timeThreshold"] = request.timeThreshold;
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
      action: "ValidateUserRole",
      version: "edu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/edu/users/roles/validate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ValidateUserRoleResponse>(await this.execute(params, req, runtime), new ValidateUserRoleResponse({}));
  }

  async validateUserRole(request: ValidateUserRoleRequest): Promise<ValidateUserRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateUserRoleHeaders({ });
    return await this.validateUserRoleWithOptions(request, headers, runtime);
  }

}
