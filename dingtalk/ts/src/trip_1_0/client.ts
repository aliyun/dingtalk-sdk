// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetTravelProcessDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailRequest extends $tea.Model {
  /**
   * @example
   * dingLamaXHExxxxxx
   */
  processCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1fbmtOweRdqLamaXHExxxxxx
   */
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processCorpId: 'processCorpId',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCorpId: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBody extends $tea.Model {
  result?: GetTravelProcessDetailResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetTravelProcessDetailResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTravelProcessDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetTravelProcessDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCheckTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCheckTemplateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding60f2b247ac1cb24024f2f5cc6abecb85
   */
  customerCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      customerCorpId: 'customerCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCheckTemplateResponseBody extends $tea.Model {
  result?: PreCheckTemplateResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PreCheckTemplateResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCheckTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PreCheckTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PreCheckTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTripProcessTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTripProcessTemplatesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingcd2016f425331dc1acaaa37764f94726
   */
  customerCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      customerCorpId: 'customerCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTripProcessTemplatesResponseBody extends $tea.Model {
  result?: QueryTripProcessTemplatesResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryTripProcessTemplatesResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTripProcessTemplatesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryTripProcessTemplatesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryTripProcessTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequest extends $tea.Model {
  bizTypeList?: string[];
  /**
   * @example
   * 1661927020219
   */
  gmtOrgPay?: string;
  /**
   * @example
   * 1661927020219
   */
  gmtSign?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ORG_PAY
   */
  orgPayStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SIGN
   */
  signStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  targetCorpId?: string;
  tmcProductDetailList?: SyncBusinessSignInfoRequestTmcProductDetailList[];
  tmcProductList?: SyncBusinessSignInfoRequestTmcProductList[];
  static names(): { [key: string]: string } {
    return {
      bizTypeList: 'bizTypeList',
      gmtOrgPay: 'gmtOrgPay',
      gmtSign: 'gmtSign',
      orgPayStatus: 'orgPayStatus',
      signStatus: 'signStatus',
      targetCorpId: 'targetCorpId',
      tmcProductDetailList: 'tmcProductDetailList',
      tmcProductList: 'tmcProductList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTypeList: { 'type': 'array', 'itemType': 'string' },
      gmtOrgPay: 'string',
      gmtSign: 'string',
      orgPayStatus: 'string',
      signStatus: 'string',
      targetCorpId: 'string',
      tmcProductDetailList: { 'type': 'array', 'itemType': SyncBusinessSignInfoRequestTmcProductDetailList },
      tmcProductList: { 'type': 'array', 'itemType': SyncBusinessSignInfoRequestTmcProductList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoResponseBody extends $tea.Model {
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncBusinessSignInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncBusinessSignInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  channelCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  costCenterId?: string;
  /**
   * **if can be null:**
   * false
   */
  deleteFlag?: boolean;
  /**
   * **if can be null:**
   * true
   */
  extension?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-02-21 11:11:11
   */
  gmtAction?: string;
  /**
   * @example
   * 123456
   */
  number?: string;
  /**
   * @example
   * 1
   */
  scope?: number;
  /**
   * @example
   * 阿里商旅
   */
  source?: string;
  thirdPartId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认成本中心
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      channelCorpId: 'channelCorpId',
      costCenterId: 'costCenterId',
      deleteFlag: 'deleteFlag',
      extension: 'extension',
      gmtAction: 'gmtAction',
      number: 'number',
      scope: 'scope',
      source: 'source',
      thirdPartId: 'thirdPartId',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelCorpId: 'string',
      costCenterId: 'string',
      deleteFlag: 'boolean',
      extension: 'string',
      gmtAction: 'string',
      number: 'string',
      scope: 'number',
      source: 'string',
      thirdPartId: 'string',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterResponseBody extends $tea.Model {
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

export class SyncCostCenterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncCostCenterResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncCostCenterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterEntityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterEntityRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  channelCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  costCenterId?: string;
  /**
   * **if can be null:**
   * true
   */
  delAll?: boolean;
  entityList?: SyncCostCenterEntityRequestEntityList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      channelCorpId: 'channelCorpId',
      costCenterId: 'costCenterId',
      delAll: 'delAll',
      entityList: 'entityList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelCorpId: 'string',
      costCenterId: 'string',
      delAll: 'boolean',
      entityList: { 'type': 'array', 'itemType': SyncCostCenterEntityRequestEntityList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterEntityResponseBody extends $tea.Model {
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

export class SyncCostCenterEntityResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncCostCenterEntityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncCostCenterEntityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceRequest extends $tea.Model {
  address?: string;
  /**
   * @example
   * xxx银行
   */
  bankName?: string;
  bankNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  channelCorpId?: string;
  deleteFlag?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-02-21 11:11:11
   */
  gmtAction?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  invoiceId?: string;
  projectIds?: string[];
  /**
   * @example
   * 1
   */
  scope?: number;
  source?: string;
  taxNo?: string;
  tel?: string;
  /**
   * @example
   * 123456
   */
  thirdPartId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认发票抬头
   */
  title?: string;
  type?: number;
  unitType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      bankName: 'bankName',
      bankNo: 'bankNo',
      channelCorpId: 'channelCorpId',
      deleteFlag: 'deleteFlag',
      gmtAction: 'gmtAction',
      invoiceId: 'invoiceId',
      projectIds: 'projectIds',
      scope: 'scope',
      source: 'source',
      taxNo: 'taxNo',
      tel: 'tel',
      thirdPartId: 'thirdPartId',
      title: 'title',
      type: 'type',
      unitType: 'unitType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      bankName: 'string',
      bankNo: 'string',
      channelCorpId: 'string',
      deleteFlag: 'boolean',
      gmtAction: 'string',
      invoiceId: 'string',
      projectIds: { 'type': 'array', 'itemType': 'string' },
      scope: 'number',
      source: 'string',
      taxNo: 'string',
      tel: 'string',
      thirdPartId: 'string',
      title: 'string',
      type: 'number',
      unitType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceResponseBody extends $tea.Model {
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

export class SyncInvoiceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceEntityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceEntityRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  channelCorpId?: string;
  /**
   * **if can be null:**
   * true
   */
  delAll?: boolean;
  entityList?: SyncInvoiceEntityRequestEntityList[];
  /**
   * @remarks
   * This parameter is required.
   */
  invoiceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      channelCorpId: 'channelCorpId',
      delAll: 'delAll',
      entityList: 'entityList',
      invoiceId: 'invoiceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelCorpId: 'string',
      delAll: 'boolean',
      entityList: { 'type': 'array', 'itemType': SyncInvoiceEntityRequestEntityList },
      invoiceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceEntityResponseBody extends $tea.Model {
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

export class SyncInvoiceEntityResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncInvoiceEntityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncInvoiceEntityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  channelCorpId?: string;
  code?: string;
  costCenterId?: string;
  deleteFlag?: boolean;
  /**
   * **if can be null:**
   * true
   */
  extension?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-02-21 11:11:11
   */
  gmtAction?: string;
  invoiceId?: string;
  managerIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  projectId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认项目
   */
  projectName?: string;
  /**
   * @example
   * 1
   */
  scope?: number;
  source?: string;
  thirdPartId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      channelCorpId: 'channelCorpId',
      code: 'code',
      costCenterId: 'costCenterId',
      deleteFlag: 'deleteFlag',
      extension: 'extension',
      gmtAction: 'gmtAction',
      invoiceId: 'invoiceId',
      managerIds: 'managerIds',
      projectId: 'projectId',
      projectName: 'projectName',
      scope: 'scope',
      source: 'source',
      thirdPartId: 'thirdPartId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelCorpId: 'string',
      code: 'string',
      costCenterId: 'string',
      deleteFlag: 'boolean',
      extension: 'string',
      gmtAction: 'string',
      invoiceId: 'string',
      managerIds: { 'type': 'array', 'itemType': 'string' },
      projectId: 'string',
      projectName: 'string',
      scope: 'number',
      source: 'string',
      thirdPartId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectResponseBody extends $tea.Model {
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

export class SyncProjectResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncProjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectEntityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectEntityRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding89233847892ndkas
   */
  channelCorpId?: string;
  /**
   * **if can be null:**
   * true
   */
  delAll?: boolean;
  entityList?: SyncProjectEntityRequestEntityList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  projectId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      channelCorpId: 'channelCorpId',
      delAll: 'delAll',
      entityList: 'entityList',
      projectId: 'projectId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelCorpId: 'string',
      delAll: 'boolean',
      entityList: { 'type': 'array', 'itemType': SyncProjectEntityRequestEntityList },
      projectId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectEntityResponseBody extends $tea.Model {
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

export class SyncProjectEntityResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncProjectEntityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncProjectEntityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ADD
   */
  actionType?: string;
  /**
   * @example
   * dnsuuiwenudsjid
   */
  secretString?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding001
   */
  targetCorpId?: string;
  /**
   * @example
   * dingduisdvfd
   */
  tripAppKey?: string;
  /**
   * @example
   * dhsuibdusijue
   */
  tripAppSecurity?: string;
  /**
   * @example
   * isv001
   */
  tripCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      secretString: 'secretString',
      targetCorpId: 'targetCorpId',
      tripAppKey: 'tripAppKey',
      tripAppSecurity: 'tripAppSecurity',
      tripCorpId: 'tripCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      secretString: 'string',
      targetCorpId: 'string',
      tripAppKey: 'string',
      tripAppSecurity: 'string',
      tripCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyResponseBody extends $tea.Model {
  result?: SyncSecretKeyResponseBodyResult;
  /**
   * @example
   * true
   */
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SyncSecretKeyResponseBodyResult,
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncSecretKeyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncSecretKeyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequest extends $tea.Model {
  /**
   * **if can be null:**
   * true
   */
  bizExtension?: string;
  /**
   * @example
   * BUSSINESS
   */
  channelType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CNY
   */
  currency?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  dingUserId?: string;
  /**
   * @example
   * 0
   */
  discountAmount?: string;
  endorseFlag?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  event?: SyncTripOrderRequestEvent;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-05-15 10:10:10
   */
  gmtOrder?: string;
  /**
   * @example
   * 2022-05-15 10:10:10
   */
  gmtPay?: string;
  /**
   * @example
   * 2022-05-15 10:10:10
   */
  gmtRefund?: string;
  invoiceApplyUrl?: string;
  /**
   * @example
   * 20220510170058192311
   */
  journeyBizNo?: string;
  orderDetails?: SyncTripOrderRequestOrderDetails[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20881001829000
   */
  orderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https:dingtalk.com/tripOrder/20220510170058192311
   */
  orderUrl?: string;
  processId?: string;
  /**
   * @example
   * 100.00
   */
  realAmount?: string;
  /**
   * @example
   * 0
   */
  refundAmount?: string;
  /**
   * @example
   * 20881001829000
   */
  relativeOrderNo?: string;
  source?: string;
  supplyLogo?: string;
  supplyName?: string;
  /**
   * @example
   * ding32fff839a3e0105d
   */
  targetCorpId?: string;
  tmcCorpId?: string;
  /**
   * @example
   * 100.00
   */
  totalAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FLIGHT
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      bizExtension: 'bizExtension',
      channelType: 'channelType',
      currency: 'currency',
      dingUserId: 'dingUserId',
      discountAmount: 'discountAmount',
      endorseFlag: 'endorseFlag',
      event: 'event',
      gmtOrder: 'gmtOrder',
      gmtPay: 'gmtPay',
      gmtRefund: 'gmtRefund',
      invoiceApplyUrl: 'invoiceApplyUrl',
      journeyBizNo: 'journeyBizNo',
      orderDetails: 'orderDetails',
      orderNo: 'orderNo',
      orderUrl: 'orderUrl',
      processId: 'processId',
      realAmount: 'realAmount',
      refundAmount: 'refundAmount',
      relativeOrderNo: 'relativeOrderNo',
      source: 'source',
      supplyLogo: 'supplyLogo',
      supplyName: 'supplyName',
      targetCorpId: 'targetCorpId',
      tmcCorpId: 'tmcCorpId',
      totalAmount: 'totalAmount',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizExtension: 'string',
      channelType: 'string',
      currency: 'string',
      dingUserId: 'string',
      discountAmount: 'string',
      endorseFlag: 'boolean',
      event: SyncTripOrderRequestEvent,
      gmtOrder: 'string',
      gmtPay: 'string',
      gmtRefund: 'string',
      invoiceApplyUrl: 'string',
      journeyBizNo: 'string',
      orderDetails: { 'type': 'array', 'itemType': SyncTripOrderRequestOrderDetails },
      orderNo: 'string',
      orderUrl: 'string',
      processId: 'string',
      realAmount: 'string',
      refundAmount: 'string',
      relativeOrderNo: 'string',
      source: 'string',
      supplyLogo: 'string',
      supplyName: 'string',
      targetCorpId: 'string',
      tmcCorpId: 'string',
      totalAmount: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncTripOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncTripOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripProductConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripProductConfigRequest extends $tea.Model {
  targetCorpId?: string;
  tripProductConfigList?: SyncTripProductConfigRequestTripProductConfigList[];
  static names(): { [key: string]: string } {
    return {
      targetCorpId: 'targetCorpId',
      tripProductConfigList: 'tripProductConfigList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCorpId: 'string',
      tripProductConfigList: { 'type': 'array', 'itemType': SyncTripProductConfigRequestTripProductConfigList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripProductConfigResponseBody extends $tea.Model {
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

export class SyncTripProductConfigResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncTripProductConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncTripProductConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TripPlatformUnifiedEntryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TripPlatformUnifiedEntryRequest extends $tea.Model {
  /**
   * @example
   * {"projects":[{"thirdId":"00001","number":"00001","scope":1,"action":0,"name":"总务01项目"}]}
   */
  messages?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * partner_syncProject
   */
  method?: string;
  static names(): { [key: string]: string } {
    return {
      messages: 'messages',
      method: 'method',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messages: 'string',
      method: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TripPlatformUnifiedEntryResponseBody extends $tea.Model {
  requestId?: string;
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TripPlatformUnifiedEntryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TripPlatformUnifiedEntryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: TripPlatformUnifiedEntryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTemplateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingcd2016f425331dc1acaaa37764f94726
   */
  channelCorpId?: string;
  forceUpgrade?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingcd2016f425331dc1acaaa37764f94726
   */
  tmcCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      channelCorpId: 'channelCorpId',
      forceUpgrade: 'forceUpgrade',
      tmcCorpId: 'tmcCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channelCorpId: 'string',
      forceUpgrade: 'boolean',
      tmcCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTemplateResponseBody extends $tea.Model {
  result?: UpgradeTemplateResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpgradeTemplateResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpgradeTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpgradeTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultExtFormComponent extends $tea.Model {
  /**
   * @example
   * ""
   */
  bizAlias?: string;
  /**
   * @example
   * MoneyField
   */
  componentType?: string;
  /**
   * @example
   * "{\"upper\":\"玖元玖角玖分\",\"componentName\":\"MoneyField\"}"
   */
  extValue?: string;
  /**
   * @example
   * MoneyField_18PDM5K773FK0
   */
  id?: string;
  /**
   * @example
   * 预估金额
   */
  name?: string;
  /**
   * @example
   * 9.99
   */
  value?: string;
  static names(): { [key: string]: string } {
    return {
      bizAlias: 'bizAlias',
      componentType: 'componentType',
      extValue: 'extValue',
      id: 'id',
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAlias: 'string',
      componentType: 'string',
      extValue: 'string',
      id: 'string',
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultJourneysArrival extends $tea.Model {
  /**
   * @example
   * TSN
   */
  code?: string;
  /**
   * @example
   * CN
   */
  countryCode?: string;
  /**
   * @example
   * 中国
   */
  countryName?: string;
  /**
   * @example
   * 天津市
   */
  name?: string;
  /**
   * @example
   * 120000
   */
  nationalCityCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      countryCode: 'countryCode',
      countryName: 'countryName',
      name: 'name',
      nationalCityCode: 'nationalCityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      countryCode: 'string',
      countryName: 'string',
      name: 'string',
      nationalCityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultJourneysDeparture extends $tea.Model {
  /**
   * @example
   * BJK
   */
  code?: string;
  /**
   * @example
   * CN
   */
  countryCode?: string;
  /**
   * @example
   * 中国
   */
  countryName?: string;
  /**
   * @example
   * 北京市
   */
  name?: string;
  /**
   * @example
   * 110000
   */
  nationalCityCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      countryCode: 'countryCode',
      countryName: 'countryName',
      name: 'name',
      nationalCityCode: 'nationalCityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      countryCode: 'string',
      countryName: 'string',
      name: 'string',
      nationalCityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultJourneys extends $tea.Model {
  arrival?: GetTravelProcessDetailResponseBodyResultJourneysArrival;
  /**
   * @example
   * 成本中心一
   */
  costCenter?: string;
  /**
   * @example
   * 123
   */
  costCenterId?: string;
  /**
   * @example
   * c00001
   */
  costCenterThirdPartyId?: string;
  departure?: GetTravelProcessDetailResponseBodyResultJourneysDeparture;
  /**
   * @example
   * 2023-10-25
   */
  endTime?: string;
  /**
   * @example
   * 2024-03-12 10:54:00
   */
  endTimeAcc?: string;
  /**
   * @example
   * 发票抬头一
   */
  invoiceTitle?: string;
  /**
   * @example
   * 123
   */
  invoiceTitleId?: string;
  /**
   * @example
   * i0001
   */
  invoiceTitleThirdPartyId?: string;
  /**
   * @example
   * 费用归属项目一
   */
  itineraryProject?: string;
  /**
   * @example
   * 123
   */
  itineraryProjectId?: string;
  /**
   * @example
   * y00001
   */
  itineraryProjectThirdPartyId?: string;
  /**
   * @example
   * 123455xxxxxxxx
   */
  journeyBizNo?: string;
  /**
   * @example
   * 2023-10-20
   */
  startTime?: string;
  /**
   * @example
   * 2024-03-12 10:54:00
   */
  startTimeAcc?: string;
  /**
   * @example
   * 天
   */
  timeUnit?: string;
  /**
   * @example
   * 飞机
   */
  travelType?: string;
  /**
   * @example
   * 单程
   */
  tripWay?: string;
  static names(): { [key: string]: string } {
    return {
      arrival: 'arrival',
      costCenter: 'costCenter',
      costCenterId: 'costCenterId',
      costCenterThirdPartyId: 'costCenterThirdPartyId',
      departure: 'departure',
      endTime: 'endTime',
      endTimeAcc: 'endTimeAcc',
      invoiceTitle: 'invoiceTitle',
      invoiceTitleId: 'invoiceTitleId',
      invoiceTitleThirdPartyId: 'invoiceTitleThirdPartyId',
      itineraryProject: 'itineraryProject',
      itineraryProjectId: 'itineraryProjectId',
      itineraryProjectThirdPartyId: 'itineraryProjectThirdPartyId',
      journeyBizNo: 'journeyBizNo',
      startTime: 'startTime',
      startTimeAcc: 'startTimeAcc',
      timeUnit: 'timeUnit',
      travelType: 'travelType',
      tripWay: 'tripWay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrival: GetTravelProcessDetailResponseBodyResultJourneysArrival,
      costCenter: 'string',
      costCenterId: 'string',
      costCenterThirdPartyId: 'string',
      departure: GetTravelProcessDetailResponseBodyResultJourneysDeparture,
      endTime: 'string',
      endTimeAcc: 'string',
      invoiceTitle: 'string',
      invoiceTitleId: 'string',
      invoiceTitleThirdPartyId: 'string',
      itineraryProject: 'string',
      itineraryProjectId: 'string',
      itineraryProjectThirdPartyId: 'string',
      journeyBizNo: 'string',
      startTime: 'string',
      startTimeAcc: 'string',
      timeUnit: 'string',
      travelType: 'string',
      tripWay: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResultTasks extends $tea.Model {
  /**
   * @example
   * 1918_5cd3
   */
  activityId?: string;
  /**
   * @example
   * 2024-07-01 00:00:00
   */
  createTime?: string;
  /**
   * @example
   * 2024-07-01 01:00:00
   */
  finishTime?: string;
  /**
   * @example
   * 12374
   */
  originUserId?: string;
  /**
   * @example
   * e7fh112WTTawy6dLtiIlqQ10051721014983
   */
  processInstanceId?: string;
  /**
   * @example
   * AGREE
   */
  result?: string;
  /**
   * @example
   * COMPLETED
   */
  status?: string;
  /**
   * @example
   * 87882310449
   */
  taskId?: number;
  /**
   * @example
   * aflow.dingtalk.com?procInsId=xxx&taskId=yyy&businessId=zzz
   */
  url?: string;
  /**
   * @example
   * 2220314
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      createTime: 'createTime',
      finishTime: 'finishTime',
      originUserId: 'originUserId',
      processInstanceId: 'processInstanceId',
      result: 'result',
      status: 'status',
      taskId: 'taskId',
      url: 'url',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      createTime: 'string',
      finishTime: 'string',
      originUserId: 'string',
      processInstanceId: 'string',
      result: 'string',
      status: 'string',
      taskId: 'number',
      url: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTravelProcessDetailResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 2024-07-18 00:00:00
   */
  archiveTime?: string;
  /**
   * @example
   * alitrip.business
   */
  bizCategoryId?: string;
  /**
   * @example
   * 202310231720000276784
   */
  businessId?: string;
  /**
   * @example
   * ding123456xxxx
   */
  corpId?: string;
  /**
   * @example
   * it成本中心
   */
  costCenter?: string;
  /**
   * @example
   * 成本中心id
   */
  costCenterId?: string;
  /**
   * @example
   * c00001
   */
  costCenterThirdPartyId?: string;
  /**
   * @example
   * 2024-03-18 17:07:00
   */
  createTime?: string;
  extFormComponent?: GetTravelProcessDetailResponseBodyResultExtFormComponent[];
  /**
   * @example
   * 部门费用
   */
  feeType?: string;
  /**
   * @example
   * 发票抬头
   */
  invoiceTitle?: string;
  /**
   * @example
   * 发票抬头id
   */
  invoiceTitleId?: string;
  /**
   * @example
   * i0001
   */
  invoiceTitleThirdPartyId?: string;
  /**
   * @example
   * 电商对接项目
   */
  itineraryProject?: string;
  /**
   * @example
   * y00001
   */
  itineraryProjectThirdPartyId?: string;
  journeys?: GetTravelProcessDetailResponseBodyResultJourneys[];
  /**
   * @example
   * AG3WERxWRFex63xxxxx
   */
  mainProcessInstanceId?: string;
  /**
   * @example
   * 坐飞机出差
   */
  memo?: string;
  /**
   * @example
   * staffidxxxxx
   */
  originatorId?: string;
  /**
   * @example
   * staffIdxyy
   */
  originatorIdOnBehalf?: string;
  /**
   * @example
   * AG3U12xWRFex63hxxxxx
   */
  processInstanceId?: string;
  /**
   * @example
   * agree
   */
  processResult?: string;
  /**
   * @example
   * COMPLETED
   */
  processStatus?: string;
  /**
   * @example
   * 因公出差
   */
  remark?: string;
  tasks?: GetTravelProcessDetailResponseBodyResultTasks[];
  /**
   * @example
   * 费用归属部门
   */
  travelCategory?: string;
  travelers?: string[];
  /**
   * @example
   * 2
   */
  tripDays?: string;
  static names(): { [key: string]: string } {
    return {
      archiveTime: 'archiveTime',
      bizCategoryId: 'bizCategoryId',
      businessId: 'businessId',
      corpId: 'corpId',
      costCenter: 'costCenter',
      costCenterId: 'costCenterId',
      costCenterThirdPartyId: 'costCenterThirdPartyId',
      createTime: 'createTime',
      extFormComponent: 'extFormComponent',
      feeType: 'feeType',
      invoiceTitle: 'invoiceTitle',
      invoiceTitleId: 'invoiceTitleId',
      invoiceTitleThirdPartyId: 'invoiceTitleThirdPartyId',
      itineraryProject: 'itineraryProject',
      itineraryProjectThirdPartyId: 'itineraryProjectThirdPartyId',
      journeys: 'journeys',
      mainProcessInstanceId: 'mainProcessInstanceId',
      memo: 'memo',
      originatorId: 'originatorId',
      originatorIdOnBehalf: 'originatorIdOnBehalf',
      processInstanceId: 'processInstanceId',
      processResult: 'processResult',
      processStatus: 'processStatus',
      remark: 'remark',
      tasks: 'tasks',
      travelCategory: 'travelCategory',
      travelers: 'travelers',
      tripDays: 'tripDays',
    };
  }

  static types(): { [key: string]: any } {
    return {
      archiveTime: 'string',
      bizCategoryId: 'string',
      businessId: 'string',
      corpId: 'string',
      costCenter: 'string',
      costCenterId: 'string',
      costCenterThirdPartyId: 'string',
      createTime: 'string',
      extFormComponent: { 'type': 'array', 'itemType': GetTravelProcessDetailResponseBodyResultExtFormComponent },
      feeType: 'string',
      invoiceTitle: 'string',
      invoiceTitleId: 'string',
      invoiceTitleThirdPartyId: 'string',
      itineraryProject: 'string',
      itineraryProjectThirdPartyId: 'string',
      journeys: { 'type': 'array', 'itemType': GetTravelProcessDetailResponseBodyResultJourneys },
      mainProcessInstanceId: 'string',
      memo: 'string',
      originatorId: 'string',
      originatorIdOnBehalf: 'string',
      processInstanceId: 'string',
      processResult: 'string',
      processStatus: 'string',
      remark: 'string',
      tasks: { 'type': 'array', 'itemType': GetTravelProcessDetailResponseBodyResultTasks },
      travelCategory: 'string',
      travelers: { 'type': 'array', 'itemType': 'string' },
      tripDays: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCheckTemplateResponseBodyResultBlockRecords extends $tea.Model {
  blockType?: string;
  reason?: string;
  static names(): { [key: string]: string } {
    return {
      blockType: 'blockType',
      reason: 'reason',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blockType: 'string',
      reason: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCheckTemplateResponseBodyResult extends $tea.Model {
  blockRecords?: PreCheckTemplateResponseBodyResultBlockRecords[];
  pass?: boolean;
  static names(): { [key: string]: string } {
    return {
      blockRecords: 'blockRecords',
      pass: 'pass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blockRecords: { 'type': 'array', 'itemType': PreCheckTemplateResponseBodyResultBlockRecords },
      pass: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTripProcessTemplatesResponseBodyResultSchemas extends $tea.Model {
  processCode?: string;
  processName?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
      processName: 'processName',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
      processName: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTripProcessTemplatesResponseBodyResult extends $tea.Model {
  schemas?: QueryTripProcessTemplatesResponseBodyResultSchemas[];
  static names(): { [key: string]: string } {
    return {
      schemas: 'schemas',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemas: { 'type': 'array', 'itemType': QueryTripProcessTemplatesResponseBodyResultSchemas },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequestTmcProductDetailList extends $tea.Model {
  /**
   * @example
   * 1661927020219
   */
  gmtOrgPay?: string;
  payType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  product?: string;
  static names(): { [key: string]: string } {
    return {
      gmtOrgPay: 'gmtOrgPay',
      payType: 'payType',
      product: 'product',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtOrgPay: 'string',
      payType: 'string',
      product: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequestTmcProductListProductDetailList extends $tea.Model {
  categoryType?: string;
  /**
   * @example
   * 1661927020219
   */
  gmtOrgPay?: string;
  openStatus?: boolean;
  payType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  product?: string;
  static names(): { [key: string]: string } {
    return {
      categoryType: 'categoryType',
      gmtOrgPay: 'gmtOrgPay',
      openStatus: 'openStatus',
      payType: 'payType',
      product: 'product',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryType: 'string',
      gmtOrgPay: 'string',
      openStatus: 'boolean',
      payType: 'string',
      product: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncBusinessSignInfoRequestTmcProductList extends $tea.Model {
  productDetailList?: SyncBusinessSignInfoRequestTmcProductListProductDetailList[];
  /**
   * @remarks
   * This parameter is required.
   */
  tmcCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      productDetailList: 'productDetailList',
      tmcCorpId: 'tmcCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      productDetailList: { 'type': 'array', 'itemType': SyncBusinessSignInfoRequestTmcProductListProductDetailList },
      tmcCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncCostCenterEntityRequestEntityList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  entityId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  entityType?: string;
  static names(): { [key: string]: string } {
    return {
      entityId: 'entityId',
      entityType: 'entityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      entityId: 'string',
      entityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncInvoiceEntityRequestEntityList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  entityId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  entityType?: string;
  static names(): { [key: string]: string } {
    return {
      entityId: 'entityId',
      entityType: 'entityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      entityId: 'string',
      entityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncProjectEntityRequestEntityList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  entityId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  entityType?: string;
  static names(): { [key: string]: string } {
    return {
      entityId: 'entityId',
      entityType: 'entityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      entityId: 'string',
      entityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSecretKeyResponseBodyResult extends $tea.Model {
  /**
   * @example
   * dsiuuuuiasudnuai
   */
  secretString?: string;
  /**
   * @example
   * ding001
   */
  targetCorpId?: string;
  /**
   * @example
   * dingwieudsiu
   */
  tripAppKey?: string;
  /**
   * @example
   * dusuduiidvs
   */
  tripAppSecurity?: string;
  /**
   * @example
   * isv001
   */
  tripCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      secretString: 'secretString',
      targetCorpId: 'targetCorpId',
      tripAppKey: 'tripAppKey',
      tripAppSecurity: 'tripAppSecurity',
      tripCorpId: 'tripCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      secretString: 'string',
      targetCorpId: 'string',
      tripAppKey: 'string',
      tripAppSecurity: 'string',
      tripCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestEvent extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INIT
   */
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-05-15 10:10:10
   */
  gmtAction?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      gmtAction: 'gmtAction',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      gmtAction: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestOrderDetailsHotelLocation extends $tea.Model {
  /**
   * @example
   * 30.278569
   */
  lat?: string;
  /**
   * @example
   * 120.023458
   */
  lon?: string;
  /**
   * @example
   * GCJ02
   */
  source?: string;
  /**
   * @example
   * https://ditu.amap.com/place/B0FFIYYAIA
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      lat: 'lat',
      lon: 'lon',
      source: 'source',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lat: 'string',
      lon: 'string',
      source: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestOrderDetailsOpenConsumerInfo extends $tea.Model {
  corpId?: string;
  name?: string;
  staffFlag?: boolean;
  status?: string;
  ticketAmount?: string;
  ticketNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      name: 'name',
      staffFlag: 'staffFlag',
      status: 'status',
      ticketAmount: 'ticketAmount',
      ticketNo: 'ticketNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      name: 'string',
      staffFlag: 'boolean',
      status: 'string',
      ticketAmount: 'string',
      ticketNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripOrderRequestOrderDetails extends $tea.Model {
  /**
   * @example
   * 2022-05-20 12:20:00
   */
  arrivalTime?: string;
  /**
   * @example
   * 红色
   */
  carColor?: string;
  /**
   * @example
   * 帕萨特
   */
  carModel?: string;
  /**
   * @example
   * 浙A0Z***7
   */
  carNumber?: string;
  /**
   * @example
   * 单早
   */
  cateringType?: string;
  /**
   * @example
   * 2022-05-20 14:00:00
   */
  checkInTime?: string;
  /**
   * @example
   * 2022-05-21 12:00:00
   */
  checkOutTime?: string;
  /**
   * @example
   * 2022-05-20 10:00:00
   */
  departTime?: string;
  /**
   * @example
   * 杭州
   */
  destinationCity?: string;
  /**
   * @example
   * 151
   */
  destinationCityCode?: string;
  /**
   * @example
   * 杭州
   */
  destinationStation?: string;
  /**
   * @example
   * T3
   */
  destinationTerminalBuilding?: string;
  detailAmount?: string;
  /**
   * @example
   * 浙江省杭州市余杭区聚橙路文昌路
   */
  hotelAddress?: string;
  /**
   * @example
   * 杭州
   */
  hotelCity?: string;
  hotelLocation?: SyncTripOrderRequestOrderDetailsHotelLocation;
  /**
   * @example
   * 亲橙客栈
   */
  hotelName?: string;
  openConsumerInfo?: SyncTripOrderRequestOrderDetailsOpenConsumerInfo[];
  /**
   * @example
   * 北京
   */
  originCity?: string;
  /**
   * @example
   * 150
   */
  originCityCode?: string;
  /**
   * @example
   * 北京
   */
  originStation?: string;
  /**
   * @example
   * T3
   */
  originTerminalBuilding?: string;
  roomCount?: number;
  /**
   * @example
   * 经济舱/7车12A
   */
  seatInfo?: string;
  /**
   * @example
   * REALTIME
   */
  serviceType?: string;
  /**
   * @example
   * http://dingtalk.com/static/logo.png
   */
  subSupplyLogo?: string;
  /**
   * @example
   * 国航
   */
  subSupplyName?: string;
  /**
   * @example
   * 专车
   */
  taxiType?: string;
  /**
   * @example
   * 2022-05-20 14:00:00
   */
  telephone?: string;
  /**
   * @example
   * CA1762
   */
  transportNumber?: string;
  /**
   * @example
   * 商务标准间
   */
  typeDescription?: string;
  static names(): { [key: string]: string } {
    return {
      arrivalTime: 'arrivalTime',
      carColor: 'carColor',
      carModel: 'carModel',
      carNumber: 'carNumber',
      cateringType: 'cateringType',
      checkInTime: 'checkInTime',
      checkOutTime: 'checkOutTime',
      departTime: 'departTime',
      destinationCity: 'destinationCity',
      destinationCityCode: 'destinationCityCode',
      destinationStation: 'destinationStation',
      destinationTerminalBuilding: 'destinationTerminalBuilding',
      detailAmount: 'detailAmount',
      hotelAddress: 'hotelAddress',
      hotelCity: 'hotelCity',
      hotelLocation: 'hotelLocation',
      hotelName: 'hotelName',
      openConsumerInfo: 'openConsumerInfo',
      originCity: 'originCity',
      originCityCode: 'originCityCode',
      originStation: 'originStation',
      originTerminalBuilding: 'originTerminalBuilding',
      roomCount: 'roomCount',
      seatInfo: 'seatInfo',
      serviceType: 'serviceType',
      subSupplyLogo: 'subSupplyLogo',
      subSupplyName: 'subSupplyName',
      taxiType: 'taxiType',
      telephone: 'telephone',
      transportNumber: 'transportNumber',
      typeDescription: 'typeDescription',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrivalTime: 'string',
      carColor: 'string',
      carModel: 'string',
      carNumber: 'string',
      cateringType: 'string',
      checkInTime: 'string',
      checkOutTime: 'string',
      departTime: 'string',
      destinationCity: 'string',
      destinationCityCode: 'string',
      destinationStation: 'string',
      destinationTerminalBuilding: 'string',
      detailAmount: 'string',
      hotelAddress: 'string',
      hotelCity: 'string',
      hotelLocation: SyncTripOrderRequestOrderDetailsHotelLocation,
      hotelName: 'string',
      openConsumerInfo: { 'type': 'array', 'itemType': SyncTripOrderRequestOrderDetailsOpenConsumerInfo },
      originCity: 'string',
      originCityCode: 'string',
      originStation: 'string',
      originTerminalBuilding: 'string',
      roomCount: 'number',
      seatInfo: 'string',
      serviceType: 'string',
      subSupplyLogo: 'string',
      subSupplyName: 'string',
      taxiType: 'string',
      telephone: 'string',
      transportNumber: 'string',
      typeDescription: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripProductConfigRequestTripProductConfigListTmcInfos extends $tea.Model {
  categoryType?: string;
  gmtOrgPay?: string;
  payType?: string;
  tmcCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      categoryType: 'categoryType',
      gmtOrgPay: 'gmtOrgPay',
      payType: 'payType',
      tmcCorpId: 'tmcCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryType: 'string',
      gmtOrgPay: 'string',
      payType: 'string',
      tmcCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTripProductConfigRequestTripProductConfigList extends $tea.Model {
  allVisible?: boolean;
  deptVisibleScopes?: string[];
  openStatus?: boolean;
  productType?: string;
  roleVisibleScopes?: string[];
  staffVisibleScopes?: string[];
  tmcInfos?: SyncTripProductConfigRequestTripProductConfigListTmcInfos[];
  static names(): { [key: string]: string } {
    return {
      allVisible: 'allVisible',
      deptVisibleScopes: 'deptVisibleScopes',
      openStatus: 'openStatus',
      productType: 'productType',
      roleVisibleScopes: 'roleVisibleScopes',
      staffVisibleScopes: 'staffVisibleScopes',
      tmcInfos: 'tmcInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allVisible: 'boolean',
      deptVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      openStatus: 'boolean',
      productType: 'string',
      roleVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      staffVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      tmcInfos: { 'type': 'array', 'itemType': SyncTripProductConfigRequestTripProductConfigListTmcInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTemplateResponseBodyResult extends $tea.Model {
  upgradeResult?: boolean;
  static names(): { [key: string]: string } {
    return {
      upgradeResult: 'upgradeResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      upgradeResult: 'boolean',
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
   * 获取差旅审批实例详情
   * 
   * @param request - GetTravelProcessDetailRequest
   * @param headers - GetTravelProcessDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTravelProcessDetailResponse
   */
  async getTravelProcessDetailWithOptions(request: GetTravelProcessDetailRequest, headers: GetTravelProcessDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetTravelProcessDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processCorpId)) {
      query["processCorpId"] = request.processCorpId;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

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
      action: "GetTravelProcessDetail",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTravelProcessDetailResponse>(await this.execute(params, req, runtime), new GetTravelProcessDetailResponse({}));
  }

  /**
   * 获取差旅审批实例详情
   * 
   * @param request - GetTravelProcessDetailRequest
   * @returns GetTravelProcessDetailResponse
   */
  async getTravelProcessDetail(request: GetTravelProcessDetailRequest): Promise<GetTravelProcessDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTravelProcessDetailHeaders({ });
    return await this.getTravelProcessDetailWithOptions(request, headers, runtime);
  }

  /**
   * 表单升级预校验
   * 
   * @param request - PreCheckTemplateRequest
   * @param headers - PreCheckTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PreCheckTemplateResponse
   */
  async preCheckTemplateWithOptions(request: PreCheckTemplateRequest, headers: PreCheckTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<PreCheckTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customerCorpId)) {
      body["customerCorpId"] = request.customerCorpId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PreCheckTemplate",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/templateUpgrades/preCheck`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PreCheckTemplateResponse>(await this.execute(params, req, runtime), new PreCheckTemplateResponse({}));
  }

  /**
   * 表单升级预校验
   * 
   * @param request - PreCheckTemplateRequest
   * @returns PreCheckTemplateResponse
   */
  async preCheckTemplate(request: PreCheckTemplateRequest): Promise<PreCheckTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PreCheckTemplateHeaders({ });
    return await this.preCheckTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 查询审批套件详情
   * 
   * @param request - QueryTripProcessTemplatesRequest
   * @param headers - QueryTripProcessTemplatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryTripProcessTemplatesResponse
   */
  async queryTripProcessTemplatesWithOptions(request: QueryTripProcessTemplatesRequest, headers: QueryTripProcessTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTripProcessTemplatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customerCorpId)) {
      query["customerCorpId"] = request.customerCorpId;
    }

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
      action: "QueryTripProcessTemplates",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/templatesDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryTripProcessTemplatesResponse>(await this.execute(params, req, runtime), new QueryTripProcessTemplatesResponse({}));
  }

  /**
   * 查询审批套件详情
   * 
   * @param request - QueryTripProcessTemplatesRequest
   * @returns QueryTripProcessTemplatesResponse
   */
  async queryTripProcessTemplates(request: QueryTripProcessTemplatesRequest): Promise<QueryTripProcessTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTripProcessTemplatesHeaders({ });
    return await this.queryTripProcessTemplatesWithOptions(request, headers, runtime);
  }

  /**
   * 同步服务商企业签约变更事件
   * 
   * @param request - SyncBusinessSignInfoRequest
   * @param headers - SyncBusinessSignInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncBusinessSignInfoResponse
   */
  async syncBusinessSignInfoWithOptions(request: SyncBusinessSignInfoRequest, headers: SyncBusinessSignInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SyncBusinessSignInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizTypeList)) {
      body["bizTypeList"] = request.bizTypeList;
    }

    if (!Util.isUnset(request.gmtOrgPay)) {
      body["gmtOrgPay"] = request.gmtOrgPay;
    }

    if (!Util.isUnset(request.gmtSign)) {
      body["gmtSign"] = request.gmtSign;
    }

    if (!Util.isUnset(request.orgPayStatus)) {
      body["orgPayStatus"] = request.orgPayStatus;
    }

    if (!Util.isUnset(request.signStatus)) {
      body["signStatus"] = request.signStatus;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tmcProductDetailList)) {
      body["tmcProductDetailList"] = request.tmcProductDetailList;
    }

    if (!Util.isUnset(request.tmcProductList)) {
      body["tmcProductList"] = request.tmcProductList;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SyncBusinessSignInfo",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/businessSignInfos/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncBusinessSignInfoResponse>(await this.execute(params, req, runtime), new SyncBusinessSignInfoResponse({}));
  }

  /**
   * 同步服务商企业签约变更事件
   * 
   * @param request - SyncBusinessSignInfoRequest
   * @returns SyncBusinessSignInfoResponse
   */
  async syncBusinessSignInfo(request: SyncBusinessSignInfoRequest): Promise<SyncBusinessSignInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncBusinessSignInfoHeaders({ });
    return await this.syncBusinessSignInfoWithOptions(request, headers, runtime);
  }

  /**
   * 出差表单成本中心同步
   * 
   * @param request - SyncCostCenterRequest
   * @param headers - SyncCostCenterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncCostCenterResponse
   */
  async syncCostCenterWithOptions(request: SyncCostCenterRequest, headers: SyncCostCenterHeaders, runtime: $Util.RuntimeOptions): Promise<SyncCostCenterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.costCenterId)) {
      body["costCenterId"] = request.costCenterId;
    }

    if (!Util.isUnset(request.deleteFlag)) {
      body["deleteFlag"] = request.deleteFlag;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.gmtAction)) {
      body["gmtAction"] = request.gmtAction;
    }

    if (!Util.isUnset(request.number)) {
      body["number"] = request.number;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.thirdPartId)) {
      body["thirdPartId"] = request.thirdPartId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "SyncCostCenter",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/costCenters/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncCostCenterResponse>(await this.execute(params, req, runtime), new SyncCostCenterResponse({}));
  }

  /**
   * 出差表单成本中心同步
   * 
   * @param request - SyncCostCenterRequest
   * @returns SyncCostCenterResponse
   */
  async syncCostCenter(request: SyncCostCenterRequest): Promise<SyncCostCenterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncCostCenterHeaders({ });
    return await this.syncCostCenterWithOptions(request, headers, runtime);
  }

  /**
   * 出差表单成本中心可用范围
   * 
   * @param request - SyncCostCenterEntityRequest
   * @param headers - SyncCostCenterEntityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncCostCenterEntityResponse
   */
  async syncCostCenterEntityWithOptions(request: SyncCostCenterEntityRequest, headers: SyncCostCenterEntityHeaders, runtime: $Util.RuntimeOptions): Promise<SyncCostCenterEntityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.costCenterId)) {
      body["costCenterId"] = request.costCenterId;
    }

    if (!Util.isUnset(request.delAll)) {
      body["delAll"] = request.delAll;
    }

    if (!Util.isUnset(request.entityList)) {
      body["entityList"] = request.entityList;
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
      action: "SyncCostCenterEntity",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/costCenters/applicableScopes/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncCostCenterEntityResponse>(await this.execute(params, req, runtime), new SyncCostCenterEntityResponse({}));
  }

  /**
   * 出差表单成本中心可用范围
   * 
   * @param request - SyncCostCenterEntityRequest
   * @returns SyncCostCenterEntityResponse
   */
  async syncCostCenterEntity(request: SyncCostCenterEntityRequest): Promise<SyncCostCenterEntityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncCostCenterEntityHeaders({ });
    return await this.syncCostCenterEntityWithOptions(request, headers, runtime);
  }

  /**
   * 出差表单发票抬头
   * 
   * @param request - SyncInvoiceRequest
   * @param headers - SyncInvoiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncInvoiceResponse
   */
  async syncInvoiceWithOptions(request: SyncInvoiceRequest, headers: SyncInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<SyncInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      body["address"] = request.address;
    }

    if (!Util.isUnset(request.bankName)) {
      body["bankName"] = request.bankName;
    }

    if (!Util.isUnset(request.bankNo)) {
      body["bankNo"] = request.bankNo;
    }

    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.deleteFlag)) {
      body["deleteFlag"] = request.deleteFlag;
    }

    if (!Util.isUnset(request.gmtAction)) {
      body["gmtAction"] = request.gmtAction;
    }

    if (!Util.isUnset(request.invoiceId)) {
      body["invoiceId"] = request.invoiceId;
    }

    if (!Util.isUnset(request.projectIds)) {
      body["projectIds"] = request.projectIds;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.taxNo)) {
      body["taxNo"] = request.taxNo;
    }

    if (!Util.isUnset(request.tel)) {
      body["tel"] = request.tel;
    }

    if (!Util.isUnset(request.thirdPartId)) {
      body["thirdPartId"] = request.thirdPartId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.unitType)) {
      body["unitType"] = request.unitType;
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
      action: "SyncInvoice",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/invoiceTitles/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncInvoiceResponse>(await this.execute(params, req, runtime), new SyncInvoiceResponse({}));
  }

  /**
   * 出差表单发票抬头
   * 
   * @param request - SyncInvoiceRequest
   * @returns SyncInvoiceResponse
   */
  async syncInvoice(request: SyncInvoiceRequest): Promise<SyncInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncInvoiceHeaders({ });
    return await this.syncInvoiceWithOptions(request, headers, runtime);
  }

  /**
   * 出差表单发票抬头可用范围
   * 
   * @param request - SyncInvoiceEntityRequest
   * @param headers - SyncInvoiceEntityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncInvoiceEntityResponse
   */
  async syncInvoiceEntityWithOptions(request: SyncInvoiceEntityRequest, headers: SyncInvoiceEntityHeaders, runtime: $Util.RuntimeOptions): Promise<SyncInvoiceEntityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.delAll)) {
      body["delAll"] = request.delAll;
    }

    if (!Util.isUnset(request.entityList)) {
      body["entityList"] = request.entityList;
    }

    if (!Util.isUnset(request.invoiceId)) {
      body["invoiceId"] = request.invoiceId;
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
      action: "SyncInvoiceEntity",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/invoiceTitles/applicableScopes/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncInvoiceEntityResponse>(await this.execute(params, req, runtime), new SyncInvoiceEntityResponse({}));
  }

  /**
   * 出差表单发票抬头可用范围
   * 
   * @param request - SyncInvoiceEntityRequest
   * @returns SyncInvoiceEntityResponse
   */
  async syncInvoiceEntity(request: SyncInvoiceEntityRequest): Promise<SyncInvoiceEntityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncInvoiceEntityHeaders({ });
    return await this.syncInvoiceEntityWithOptions(request, headers, runtime);
  }

  /**
   * 出差表单项目
   * 
   * @param request - SyncProjectRequest
   * @param headers - SyncProjectHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncProjectResponse
   */
  async syncProjectWithOptions(request: SyncProjectRequest, headers: SyncProjectHeaders, runtime: $Util.RuntimeOptions): Promise<SyncProjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.costCenterId)) {
      body["costCenterId"] = request.costCenterId;
    }

    if (!Util.isUnset(request.deleteFlag)) {
      body["deleteFlag"] = request.deleteFlag;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.gmtAction)) {
      body["gmtAction"] = request.gmtAction;
    }

    if (!Util.isUnset(request.invoiceId)) {
      body["invoiceId"] = request.invoiceId;
    }

    if (!Util.isUnset(request.managerIds)) {
      body["managerIds"] = request.managerIds;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.projectName)) {
      body["projectName"] = request.projectName;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.thirdPartId)) {
      body["thirdPartId"] = request.thirdPartId;
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
      action: "SyncProject",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/projects/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncProjectResponse>(await this.execute(params, req, runtime), new SyncProjectResponse({}));
  }

  /**
   * 出差表单项目
   * 
   * @param request - SyncProjectRequest
   * @returns SyncProjectResponse
   */
  async syncProject(request: SyncProjectRequest): Promise<SyncProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncProjectHeaders({ });
    return await this.syncProjectWithOptions(request, headers, runtime);
  }

  /**
   * 出差表单项目可用范围
   * 
   * @param request - SyncProjectEntityRequest
   * @param headers - SyncProjectEntityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncProjectEntityResponse
   */
  async syncProjectEntityWithOptions(request: SyncProjectEntityRequest, headers: SyncProjectEntityHeaders, runtime: $Util.RuntimeOptions): Promise<SyncProjectEntityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.delAll)) {
      body["delAll"] = request.delAll;
    }

    if (!Util.isUnset(request.entityList)) {
      body["entityList"] = request.entityList;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
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
      action: "SyncProjectEntity",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/processes/projects/applicableScopes/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncProjectEntityResponse>(await this.execute(params, req, runtime), new SyncProjectEntityResponse({}));
  }

  /**
   * 出差表单项目可用范围
   * 
   * @param request - SyncProjectEntityRequest
   * @returns SyncProjectEntityResponse
   */
  async syncProjectEntity(request: SyncProjectEntityRequest): Promise<SyncProjectEntityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncProjectEntityHeaders({ });
    return await this.syncProjectEntityWithOptions(request, headers, runtime);
  }

  /**
   * 调用本接口同步公司密钥信息。
   * 
   * @param request - SyncSecretKeyRequest
   * @param headers - SyncSecretKeyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncSecretKeyResponse
   */
  async syncSecretKeyWithOptions(request: SyncSecretKeyRequest, headers: SyncSecretKeyHeaders, runtime: $Util.RuntimeOptions): Promise<SyncSecretKeyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionType)) {
      body["actionType"] = request.actionType;
    }

    if (!Util.isUnset(request.secretString)) {
      body["secretString"] = request.secretString;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tripAppKey)) {
      body["tripAppKey"] = request.tripAppKey;
    }

    if (!Util.isUnset(request.tripAppSecurity)) {
      body["tripAppSecurity"] = request.tripAppSecurity;
    }

    if (!Util.isUnset(request.tripCorpId)) {
      body["tripCorpId"] = request.tripCorpId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SyncSecretKey",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/secretKeys/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncSecretKeyResponse>(await this.execute(params, req, runtime), new SyncSecretKeyResponse({}));
  }

  /**
   * 调用本接口同步公司密钥信息。
   * 
   * @param request - SyncSecretKeyRequest
   * @returns SyncSecretKeyResponse
   */
  async syncSecretKey(request: SyncSecretKeyRequest): Promise<SyncSecretKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncSecretKeyHeaders({ });
    return await this.syncSecretKeyWithOptions(request, headers, runtime);
  }

  /**
   * 同步出行订单变更事件
   * 
   * @param request - SyncTripOrderRequest
   * @param headers - SyncTripOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncTripOrderResponse
   */
  async syncTripOrderWithOptions(request: SyncTripOrderRequest, headers: SyncTripOrderHeaders, runtime: $Util.RuntimeOptions): Promise<SyncTripOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizExtension)) {
      body["bizExtension"] = request.bizExtension;
    }

    if (!Util.isUnset(request.channelType)) {
      body["channelType"] = request.channelType;
    }

    if (!Util.isUnset(request.currency)) {
      body["currency"] = request.currency;
    }

    if (!Util.isUnset(request.dingUserId)) {
      body["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.discountAmount)) {
      body["discountAmount"] = request.discountAmount;
    }

    if (!Util.isUnset(request.endorseFlag)) {
      body["endorseFlag"] = request.endorseFlag;
    }

    if (!Util.isUnset(request.event)) {
      body["event"] = request.event;
    }

    if (!Util.isUnset(request.gmtOrder)) {
      body["gmtOrder"] = request.gmtOrder;
    }

    if (!Util.isUnset(request.gmtPay)) {
      body["gmtPay"] = request.gmtPay;
    }

    if (!Util.isUnset(request.gmtRefund)) {
      body["gmtRefund"] = request.gmtRefund;
    }

    if (!Util.isUnset(request.invoiceApplyUrl)) {
      body["invoiceApplyUrl"] = request.invoiceApplyUrl;
    }

    if (!Util.isUnset(request.journeyBizNo)) {
      body["journeyBizNo"] = request.journeyBizNo;
    }

    if (!Util.isUnset(request.orderDetails)) {
      body["orderDetails"] = request.orderDetails;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.orderUrl)) {
      body["orderUrl"] = request.orderUrl;
    }

    if (!Util.isUnset(request.processId)) {
      body["processId"] = request.processId;
    }

    if (!Util.isUnset(request.realAmount)) {
      body["realAmount"] = request.realAmount;
    }

    if (!Util.isUnset(request.refundAmount)) {
      body["refundAmount"] = request.refundAmount;
    }

    if (!Util.isUnset(request.relativeOrderNo)) {
      body["relativeOrderNo"] = request.relativeOrderNo;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.supplyLogo)) {
      body["supplyLogo"] = request.supplyLogo;
    }

    if (!Util.isUnset(request.supplyName)) {
      body["supplyName"] = request.supplyName;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tmcCorpId)) {
      body["tmcCorpId"] = request.tmcCorpId;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
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
      action: "SyncTripOrder",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/tripOrders/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncTripOrderResponse>(await this.execute(params, req, runtime), new SyncTripOrderResponse({}));
  }

  /**
   * 同步出行订单变更事件
   * 
   * @param request - SyncTripOrderRequest
   * @returns SyncTripOrderResponse
   */
  async syncTripOrder(request: SyncTripOrderRequest): Promise<SyncTripOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTripOrderHeaders({ });
    return await this.syncTripOrderWithOptions(request, headers, runtime);
  }

  /**
   * 预订管理产品线配置同步
   * 
   * @param request - SyncTripProductConfigRequest
   * @param headers - SyncTripProductConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncTripProductConfigResponse
   */
  async syncTripProductConfigWithOptions(request: SyncTripProductConfigRequest, headers: SyncTripProductConfigHeaders, runtime: $Util.RuntimeOptions): Promise<SyncTripProductConfigResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.tripProductConfigList)) {
      body["tripProductConfigList"] = request.tripProductConfigList;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SyncTripProductConfig",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/productConfigs/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncTripProductConfigResponse>(await this.execute(params, req, runtime), new SyncTripProductConfigResponse({}));
  }

  /**
   * 预订管理产品线配置同步
   * 
   * @param request - SyncTripProductConfigRequest
   * @returns SyncTripProductConfigResponse
   */
  async syncTripProductConfig(request: SyncTripProductConfigRequest): Promise<SyncTripProductConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTripProductConfigHeaders({ });
    return await this.syncTripProductConfigWithOptions(request, headers, runtime);
  }

  /**
   * 智能差旅平台数据互通统一入口
   * 
   * @param request - TripPlatformUnifiedEntryRequest
   * @param headers - TripPlatformUnifiedEntryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TripPlatformUnifiedEntryResponse
   */
  async tripPlatformUnifiedEntryWithOptions(request: TripPlatformUnifiedEntryRequest, headers: TripPlatformUnifiedEntryHeaders, runtime: $Util.RuntimeOptions): Promise<TripPlatformUnifiedEntryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messages)) {
      body["messages"] = request.messages;
    }

    if (!Util.isUnset(request.method)) {
      body["method"] = request.method;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "TripPlatformUnifiedEntry",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/platforms/entrances/unify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TripPlatformUnifiedEntryResponse>(await this.execute(params, req, runtime), new TripPlatformUnifiedEntryResponse({}));
  }

  /**
   * 智能差旅平台数据互通统一入口
   * 
   * @param request - TripPlatformUnifiedEntryRequest
   * @returns TripPlatformUnifiedEntryResponse
   */
  async tripPlatformUnifiedEntry(request: TripPlatformUnifiedEntryRequest): Promise<TripPlatformUnifiedEntryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TripPlatformUnifiedEntryHeaders({ });
    return await this.tripPlatformUnifiedEntryWithOptions(request, headers, runtime);
  }

  /**
   * 升级套件
   * 
   * @param request - UpgradeTemplateRequest
   * @param headers - UpgradeTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpgradeTemplateResponse
   */
  async upgradeTemplateWithOptions(request: UpgradeTemplateRequest, headers: UpgradeTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCorpId)) {
      body["channelCorpId"] = request.channelCorpId;
    }

    if (!Util.isUnset(request.forceUpgrade)) {
      body["forceUpgrade"] = request.forceUpgrade;
    }

    if (!Util.isUnset(request.tmcCorpId)) {
      body["tmcCorpId"] = request.tmcCorpId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpgradeTemplate",
      version: "trip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trip/process/templates/upgrade`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpgradeTemplateResponse>(await this.execute(params, req, runtime), new UpgradeTemplateResponse({}));
  }

  /**
   * 升级套件
   * 
   * @param request - UpgradeTemplateRequest
   * @returns UpgradeTemplateResponse
   */
  async upgradeTemplate(request: UpgradeTemplateRequest): Promise<UpgradeTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeTemplateHeaders({ });
    return await this.upgradeTemplateWithOptions(request, headers, runtime);
  }

}
