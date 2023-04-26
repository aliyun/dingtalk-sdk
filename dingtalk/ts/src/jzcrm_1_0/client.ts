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

export class EditContactHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactRequest extends $tea.Model {
  data?: EditContactRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditContactRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditContactResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditContactResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerRequest extends $tea.Model {
  data?: EditCustomerRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditCustomerRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolRequest extends $tea.Model {
  data?: EditCustomerPoolRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditCustomerPoolRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditCustomerPoolResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditCustomerPoolResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeRequest extends $tea.Model {
  data?: EditExchangeRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditExchangeRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditExchangeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditExchangeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsRequest extends $tea.Model {
  data?: EditGoodsRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditGoodsRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditGoodsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditGoodsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockRequest extends $tea.Model {
  data?: EditIntostockRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditIntostockRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditIntostockResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditIntostockResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceRequest extends $tea.Model {
  data?: EditInvoiceRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditInvoiceRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderRequest extends $tea.Model {
  data?: EditOrderRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditOrderRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockRequest extends $tea.Model {
  data?: EditOutstockRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditOutstockRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditOutstockResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditOutstockResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionRequest extends $tea.Model {
  data?: EditProductionRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditProductionRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditProductionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditProductionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseRequest extends $tea.Model {
  data?: EditPurchaseRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditPurchaseRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditPurchaseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditPurchaseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordRequest extends $tea.Model {
  data?: EditQuotationRecordRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditQuotationRecordRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditQuotationRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditQuotationRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesRequest extends $tea.Model {
  data?: EditSalesRequestData;
  datatype?: number;
  msgid?: number;
  stamp?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      datatype: 'datatype',
      msgid: 'msgid',
      stamp: 'stamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: EditSalesRequestData,
      datatype: 'number',
      msgid: 'number',
      stamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesResponseBody extends $tea.Model {
  msgid?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      msgid: 'msgid',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgid: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EditSalesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: EditSalesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataListRequest extends $tea.Model {
  datatype?: string;
  page?: number;
  pagesize?: number;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      page: 'page',
      pagesize: 'pagesize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'string',
      page: 'number',
      pagesize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataListResponseBody extends $tea.Model {
  data?: GetDataListResponseBodyData[];
  dataname?: { [key: string]: string };
  page?: number;
  pageSize?: number;
  time?: string;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      dataname: 'dataname',
      page: 'page',
      pageSize: 'pageSize',
      time: 'time',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetDataListResponseBodyData },
      dataname: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      page: 'number',
      pageSize: 'number',
      time: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDataListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetDataListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataViewHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataViewRequest extends $tea.Model {
  datatype?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataViewResponseBody extends $tea.Model {
  data?: GetDataViewResponseBodyData;
  dataname?: { [key: string]: {[key: string]: any} };
  time?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      dataname: 'dataname',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetDataViewResponseBodyData,
      dataname: { 'type': 'map', 'keyType': 'string', 'valueType': '{[key: string]: any}' },
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataViewResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDataViewResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetDataViewResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactRequestData extends $tea.Model {
  dataUserid?: string;
  lxrAddress?: string;
  lxrBirthday?: string;
  lxrChengwei?: string;
  lxrCtnumber?: string;
  lxrCttype?: string;
  lxrCustomerid?: string;
  lxrDepartment?: string;
  lxrDingtalk?: string;
  lxrEmail?: string;
  lxrFax?: string;
  lxrGroup?: string;
  lxrHandset?: string;
  lxrHeadship?: string;
  lxrLike?: string;
  lxrName?: string;
  lxrPhoto?: string;
  lxrPreside?: string;
  lxrPst?: string;
  lxrQq?: string;
  lxrRemark?: string;
  lxrSex?: string;
  lxrSkype?: string;
  lxrTel?: string;
  lxrType?: string;
  lxrWangwang?: string;
  lxrWeixin?: string;
  lxrWorktel?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      lxrAddress: 'lxr_address',
      lxrBirthday: 'lxr_birthday',
      lxrChengwei: 'lxr_chengwei',
      lxrCtnumber: 'lxr_ctnumber',
      lxrCttype: 'lxr_cttype',
      lxrCustomerid: 'lxr_customerid',
      lxrDepartment: 'lxr_department',
      lxrDingtalk: 'lxr_dingtalk',
      lxrEmail: 'lxr_email',
      lxrFax: 'lxr_fax',
      lxrGroup: 'lxr_group',
      lxrHandset: 'lxr_handset',
      lxrHeadship: 'lxr_headship',
      lxrLike: 'lxr_like',
      lxrName: 'lxr_name',
      lxrPhoto: 'lxr_photo',
      lxrPreside: 'lxr_preside',
      lxrPst: 'lxr_pst',
      lxrQq: 'lxr_qq',
      lxrRemark: 'lxr_remark',
      lxrSex: 'lxr_sex',
      lxrSkype: 'lxr_skype',
      lxrTel: 'lxr_tel',
      lxrType: 'lxr_type',
      lxrWangwang: 'lxr_wangwang',
      lxrWeixin: 'lxr_weixin',
      lxrWorktel: 'lxr_worktel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      lxrAddress: 'string',
      lxrBirthday: 'string',
      lxrChengwei: 'string',
      lxrCtnumber: 'string',
      lxrCttype: 'string',
      lxrCustomerid: 'string',
      lxrDepartment: 'string',
      lxrDingtalk: 'string',
      lxrEmail: 'string',
      lxrFax: 'string',
      lxrGroup: 'string',
      lxrHandset: 'string',
      lxrHeadship: 'string',
      lxrLike: 'string',
      lxrName: 'string',
      lxrPhoto: 'string',
      lxrPreside: 'string',
      lxrPst: 'string',
      lxrQq: 'string',
      lxrRemark: 'string',
      lxrSex: 'string',
      lxrSkype: 'string',
      lxrTel: 'string',
      lxrType: 'string',
      lxrWangwang: 'string',
      lxrWeixin: 'string',
      lxrWorktel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerRequestData extends $tea.Model {
  dataUserid?: string;
  khAddress?: string;
  khAppellation?: string;
  khBefontof?: string;
  khBillinfo?: string;
  khCity?: string;
  khClass?: string;
  khCoaddress?: string;
  khContype?: string;
  khCountry?: string;
  khCreditgrade?: string;
  khCtnumber?: string;
  khCttype?: string;
  khDepartment?: string;
  khDingtalk?: string;
  khEmail?: string;
  khEmployees?: string;
  khFax?: string;
  khFrom?: string;
  khHandset?: string;
  khHeadship?: string;
  khHotfl?: string;
  khHotlevel?: string;
  khHotmemo?: string;
  khHottype?: string;
  khIndustry?: string;
  khInfo?: string;
  khJibie?: string;
  khName?: string;
  khPkhid?: string;
  khPreside?: string;
  khProvince?: string;
  khPst?: string;
  khQq?: string;
  khRalagrade?: string;
  khRemark?: string;
  khSex?: string;
  khShortname?: string;
  khSkype?: string;
  khSn?: string;
  khStatus?: string;
  khTel?: string;
  khType?: string;
  khValrating?: string;
  khWangwang?: string;
  khWeb?: string;
  khWeixin?: string;
  khWorktel?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      khAddress: 'kh_address',
      khAppellation: 'kh_appellation',
      khBefontof: 'kh_befontof',
      khBillinfo: 'kh_billinfo',
      khCity: 'kh_city',
      khClass: 'kh_class',
      khCoaddress: 'kh_coaddress',
      khContype: 'kh_contype',
      khCountry: 'kh_country',
      khCreditgrade: 'kh_creditgrade',
      khCtnumber: 'kh_ctnumber',
      khCttype: 'kh_cttype',
      khDepartment: 'kh_department',
      khDingtalk: 'kh_dingtalk',
      khEmail: 'kh_email',
      khEmployees: 'kh_employees',
      khFax: 'kh_fax',
      khFrom: 'kh_from',
      khHandset: 'kh_handset',
      khHeadship: 'kh_headship',
      khHotfl: 'kh_hotfl',
      khHotlevel: 'kh_hotlevel',
      khHotmemo: 'kh_hotmemo',
      khHottype: 'kh_hottype',
      khIndustry: 'kh_industry',
      khInfo: 'kh_info',
      khJibie: 'kh_jibie',
      khName: 'kh_name',
      khPkhid: 'kh_pkhid',
      khPreside: 'kh_preside',
      khProvince: 'kh_province',
      khPst: 'kh_pst',
      khQq: 'kh_qq',
      khRalagrade: 'kh_ralagrade',
      khRemark: 'kh_remark',
      khSex: 'kh_sex',
      khShortname: 'kh_shortname',
      khSkype: 'kh_skype',
      khSn: 'kh_sn',
      khStatus: 'kh_status',
      khTel: 'kh_tel',
      khType: 'kh_type',
      khValrating: 'kh_valrating',
      khWangwang: 'kh_wangwang',
      khWeb: 'kh_web',
      khWeixin: 'kh_weixin',
      khWorktel: 'kh_worktel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      khAddress: 'string',
      khAppellation: 'string',
      khBefontof: 'string',
      khBillinfo: 'string',
      khCity: 'string',
      khClass: 'string',
      khCoaddress: 'string',
      khContype: 'string',
      khCountry: 'string',
      khCreditgrade: 'string',
      khCtnumber: 'string',
      khCttype: 'string',
      khDepartment: 'string',
      khDingtalk: 'string',
      khEmail: 'string',
      khEmployees: 'string',
      khFax: 'string',
      khFrom: 'string',
      khHandset: 'string',
      khHeadship: 'string',
      khHotfl: 'string',
      khHotlevel: 'string',
      khHotmemo: 'string',
      khHottype: 'string',
      khIndustry: 'string',
      khInfo: 'string',
      khJibie: 'string',
      khName: 'string',
      khPkhid: 'string',
      khPreside: 'string',
      khProvince: 'string',
      khPst: 'string',
      khQq: 'string',
      khRalagrade: 'string',
      khRemark: 'string',
      khSex: 'string',
      khShortname: 'string',
      khSkype: 'string',
      khSn: 'string',
      khStatus: 'string',
      khTel: 'string',
      khType: 'string',
      khValrating: 'string',
      khWangwang: 'string',
      khWeb: 'string',
      khWeixin: 'string',
      khWorktel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolRequestData extends $tea.Model {
  dataUserid?: string;
  khAddress?: string;
  khAppellation?: string;
  khBefontof?: string;
  khBillinfo?: string;
  khCity?: string;
  khClass?: string;
  khCoaddress?: string;
  khContype?: string;
  khCountry?: string;
  khCreditgrade?: string;
  khCtnumber?: string;
  khCttype?: string;
  khDepartment?: string;
  khDingtalk?: string;
  khEmail?: string;
  khEmployees?: string;
  khFax?: string;
  khFrom?: string;
  khGenzongtime?: string;
  khHandset?: string;
  khHeadship?: string;
  khHotfl?: string;
  khHotlevel?: string;
  khHotmemo?: string;
  khHottype?: string;
  khIndustry?: string;
  khInfo?: string;
  khJibie?: string;
  khName?: string;
  khPkhid?: string;
  khPreside?: string;
  khProvince?: string;
  khPst?: string;
  khQq?: string;
  khRalagrade?: string;
  khRemark?: string;
  khSex?: string;
  khShortname?: string;
  khSkype?: string;
  khSn?: string;
  khStatus?: string;
  khTel?: string;
  khType?: string;
  khValrating?: string;
  khWangwang?: string;
  khWeb?: string;
  khWeixin?: string;
  khWorktel?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      khAddress: 'kh_address',
      khAppellation: 'kh_appellation',
      khBefontof: 'kh_befontof',
      khBillinfo: 'kh_billinfo',
      khCity: 'kh_city',
      khClass: 'kh_class',
      khCoaddress: 'kh_coaddress',
      khContype: 'kh_contype',
      khCountry: 'kh_country',
      khCreditgrade: 'kh_creditgrade',
      khCtnumber: 'kh_ctnumber',
      khCttype: 'kh_cttype',
      khDepartment: 'kh_department',
      khDingtalk: 'kh_dingtalk',
      khEmail: 'kh_email',
      khEmployees: 'kh_employees',
      khFax: 'kh_fax',
      khFrom: 'kh_from',
      khGenzongtime: 'kh_genzongtime',
      khHandset: 'kh_handset',
      khHeadship: 'kh_headship',
      khHotfl: 'kh_hotfl',
      khHotlevel: 'kh_hotlevel',
      khHotmemo: 'kh_hotmemo',
      khHottype: 'kh_hottype',
      khIndustry: 'kh_industry',
      khInfo: 'kh_info',
      khJibie: 'kh_jibie',
      khName: 'kh_name',
      khPkhid: 'kh_pkhid',
      khPreside: 'kh_preside',
      khProvince: 'kh_province',
      khPst: 'kh_pst',
      khQq: 'kh_qq',
      khRalagrade: 'kh_ralagrade',
      khRemark: 'kh_remark',
      khSex: 'kh_sex',
      khShortname: 'kh_shortname',
      khSkype: 'kh_skype',
      khSn: 'kh_sn',
      khStatus: 'kh_status',
      khTel: 'kh_tel',
      khType: 'kh_type',
      khValrating: 'kh_valrating',
      khWangwang: 'kh_wangwang',
      khWeb: 'kh_web',
      khWeixin: 'kh_weixin',
      khWorktel: 'kh_worktel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      khAddress: 'string',
      khAppellation: 'string',
      khBefontof: 'string',
      khBillinfo: 'string',
      khCity: 'string',
      khClass: 'string',
      khCoaddress: 'string',
      khContype: 'string',
      khCountry: 'string',
      khCreditgrade: 'string',
      khCtnumber: 'string',
      khCttype: 'string',
      khDepartment: 'string',
      khDingtalk: 'string',
      khEmail: 'string',
      khEmployees: 'string',
      khFax: 'string',
      khFrom: 'string',
      khGenzongtime: 'string',
      khHandset: 'string',
      khHeadship: 'string',
      khHotfl: 'string',
      khHotlevel: 'string',
      khHotmemo: 'string',
      khHottype: 'string',
      khIndustry: 'string',
      khInfo: 'string',
      khJibie: 'string',
      khName: 'string',
      khPkhid: 'string',
      khPreside: 'string',
      khProvince: 'string',
      khPst: 'string',
      khQq: 'string',
      khRalagrade: 'string',
      khRemark: 'string',
      khSex: 'string',
      khShortname: 'string',
      khSkype: 'string',
      khSn: 'string',
      khStatus: 'string',
      khTel: 'string',
      khType: 'string',
      khValrating: 'string',
      khWangwang: 'string',
      khWeb: 'string',
      khWeixin: 'string',
      khWorktel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeRequestData extends $tea.Model {
  childMx?: string;
  dataUserid?: string;
  hhCustomerid?: string;
  hhDate?: string;
  hhInempid?: string;
  hhInlibid?: string;
  hhIntime?: string;
  hhNumber?: string;
  hhOrderid?: string;
  hhOutempid?: string;
  hhOutlibid?: string;
  hhOuttime?: string;
  hhRemark?: string;
  hhState?: string;
  hhTitle?: string;
  hhType?: string;
  static names(): { [key: string]: string } {
    return {
      childMx: 'child_mx',
      dataUserid: 'data_userid',
      hhCustomerid: 'hh_customerid',
      hhDate: 'hh_date',
      hhInempid: 'hh_inempid',
      hhInlibid: 'hh_inlibid',
      hhIntime: 'hh_intime',
      hhNumber: 'hh_number',
      hhOrderid: 'hh_orderid',
      hhOutempid: 'hh_outempid',
      hhOutlibid: 'hh_outlibid',
      hhOuttime: 'hh_outtime',
      hhRemark: 'hh_remark',
      hhState: 'hh_state',
      hhTitle: 'hh_title',
      hhType: 'hh_type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      childMx: 'string',
      dataUserid: 'string',
      hhCustomerid: 'string',
      hhDate: 'string',
      hhInempid: 'string',
      hhInlibid: 'string',
      hhIntime: 'string',
      hhNumber: 'string',
      hhOrderid: 'string',
      hhOutempid: 'string',
      hhOutlibid: 'string',
      hhOuttime: 'string',
      hhRemark: 'string',
      hhState: 'string',
      hhTitle: 'string',
      hhType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsRequestData extends $tea.Model {
  addedtime?: string;
  cbprice?: string;
  cpParentid?: string;
  cparea?: string;
  cpbarcode?: string;
  cpbrand?: string;
  cpcontent?: string;
  cpguige?: string;
  cpimg?: string;
  cpname?: string;
  cpno?: string;
  cpremark?: string;
  cptype?: string;
  cpunit?: string;
  cpweight?: string;
  dataUserid?: string;
  gysid?: string;
  ispicimanage?: string;
  issnmanage?: string;
  isstock?: string;
  isstop?: string;
  preprice1?: string;
  preprice2?: string;
  preprice3?: string;
  preprice4?: string;
  stockdown?: string;
  stockup?: string;
  typeid?: string;
  unitrate?: string;
  static names(): { [key: string]: string } {
    return {
      addedtime: 'addedtime',
      cbprice: 'cbprice',
      cpParentid: 'cp_parentid',
      cparea: 'cparea',
      cpbarcode: 'cpbarcode',
      cpbrand: 'cpbrand',
      cpcontent: 'cpcontent',
      cpguige: 'cpguige',
      cpimg: 'cpimg',
      cpname: 'cpname',
      cpno: 'cpno',
      cpremark: 'cpremark',
      cptype: 'cptype',
      cpunit: 'cpunit',
      cpweight: 'cpweight',
      dataUserid: 'data_userid',
      gysid: 'gysid',
      ispicimanage: 'ispicimanage',
      issnmanage: 'issnmanage',
      isstock: 'isstock',
      isstop: 'isstop',
      preprice1: 'preprice1',
      preprice2: 'preprice2',
      preprice3: 'preprice3',
      preprice4: 'preprice4',
      stockdown: 'stockdown',
      stockup: 'stockup',
      typeid: 'typeid',
      unitrate: 'unitrate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addedtime: 'string',
      cbprice: 'string',
      cpParentid: 'string',
      cparea: 'string',
      cpbarcode: 'string',
      cpbrand: 'string',
      cpcontent: 'string',
      cpguige: 'string',
      cpimg: 'string',
      cpname: 'string',
      cpno: 'string',
      cpremark: 'string',
      cptype: 'string',
      cpunit: 'string',
      cpweight: 'string',
      dataUserid: 'string',
      gysid: 'string',
      ispicimanage: 'string',
      issnmanage: 'string',
      isstock: 'string',
      isstop: 'string',
      preprice1: 'string',
      preprice2: 'string',
      preprice3: 'string',
      preprice4: 'string',
      stockdown: 'string',
      stockup: 'string',
      typeid: 'string',
      unitrate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockRequestData extends $tea.Model {
  askempid?: string;
  auditreson?: string;
  billno?: string;
  childMx?: string;
  customerid?: string;
  dataUserid?: string;
  empid?: string;
  inorout?: string;
  libiodate?: string;
  libioname?: string;
  libiostate?: string;
  orderid?: string;
  remark?: string;
  stocklibid?: string;
  static names(): { [key: string]: string } {
    return {
      askempid: 'askempid',
      auditreson: 'auditreson',
      billno: 'billno',
      childMx: 'child_mx',
      customerid: 'customerid',
      dataUserid: 'data_userid',
      empid: 'empid',
      inorout: 'inorout',
      libiodate: 'libiodate',
      libioname: 'libioname',
      libiostate: 'libiostate',
      orderid: 'orderid',
      remark: 'remark',
      stocklibid: 'stocklibid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      askempid: 'string',
      auditreson: 'string',
      billno: 'string',
      childMx: 'string',
      customerid: 'string',
      dataUserid: 'string',
      empid: 'string',
      inorout: 'string',
      libiodate: 'string',
      libioname: 'string',
      libiostate: 'string',
      orderid: 'string',
      remark: 'string',
      stocklibid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceRequestData extends $tea.Model {
  childMx?: string;
  dataUserid?: string;
  fhAddress?: string;
  fhCustomerid?: string;
  fhDate?: string;
  fhEmail?: string;
  fhHandset?: string;
  fhHtorder?: string;
  fhJianshu?: string;
  fhKg?: string;
  fhLinkman?: string;
  fhLxrid?: string;
  fhMode?: string;
  fhMsn?: string;
  fhNumber?: string;
  fhPost?: string;
  fhPreside?: string;
  fhRemark?: string;
  fhShipper?: string;
  fhState?: string;
  fhTel?: string;
  fhTitle?: string;
  fhYunfei?: string;
  static names(): { [key: string]: string } {
    return {
      childMx: 'child_mx',
      dataUserid: 'data_userid',
      fhAddress: 'fh_address',
      fhCustomerid: 'fh_customerid',
      fhDate: 'fh_date',
      fhEmail: 'fh_email',
      fhHandset: 'fh_handset',
      fhHtorder: 'fh_htorder',
      fhJianshu: 'fh_jianshu',
      fhKg: 'fh_kg',
      fhLinkman: 'fh_linkman',
      fhLxrid: 'fh_lxrid',
      fhMode: 'fh_mode',
      fhMsn: 'fh_msn',
      fhNumber: 'fh_number',
      fhPost: 'fh_post',
      fhPreside: 'fh_preside',
      fhRemark: 'fh_remark',
      fhShipper: 'fh_shipper',
      fhState: 'fh_state',
      fhTel: 'fh_tel',
      fhTitle: 'fh_title',
      fhYunfei: 'fh_yunfei',
    };
  }

  static types(): { [key: string]: any } {
    return {
      childMx: 'string',
      dataUserid: 'string',
      fhAddress: 'string',
      fhCustomerid: 'string',
      fhDate: 'string',
      fhEmail: 'string',
      fhHandset: 'string',
      fhHtorder: 'string',
      fhJianshu: 'string',
      fhKg: 'string',
      fhLinkman: 'string',
      fhLxrid: 'string',
      fhMode: 'string',
      fhMsn: 'string',
      fhNumber: 'string',
      fhPost: 'string',
      fhPreside: 'string',
      fhRemark: 'string',
      fhShipper: 'string',
      fhState: 'string',
      fhTel: 'string',
      fhTitle: 'string',
      fhYunfei: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderRequestData extends $tea.Model {
  childMx?: string;
  dataUserid?: string;
  fahuoaddressid?: string;
  htBegindate?: string;
  htContract?: string;
  htCustomerid?: string;
  htCusub?: string;
  htDate?: string;
  htDeliplace?: string;
  htEnddate?: string;
  htFjmoney?: string;
  htFjmoneylx?: string;
  htKjmoney?: string;
  htLxrid?: string;
  htLxrinfo?: string;
  htMoneyzhekou?: string;
  htNumber?: string;
  htOrder?: string;
  htPaymode?: string;
  htPreside?: string;
  htRemark?: string;
  htState?: string;
  htSummemo?: string;
  htSummoney?: string;
  htTitle?: string;
  htType?: string;
  htWesub?: string;
  htWuliutype?: string;
  htXshid?: string;
  htYunfeimoney?: string;
  static names(): { [key: string]: string } {
    return {
      childMx: 'child_mx',
      dataUserid: 'data_userid',
      fahuoaddressid: 'fahuoaddressid',
      htBegindate: 'ht_begindate',
      htContract: 'ht_contract',
      htCustomerid: 'ht_customerid',
      htCusub: 'ht_cusub',
      htDate: 'ht_date',
      htDeliplace: 'ht_deliplace',
      htEnddate: 'ht_enddate',
      htFjmoney: 'ht_fjmoney',
      htFjmoneylx: 'ht_fjmoneylx',
      htKjmoney: 'ht_kjmoney',
      htLxrid: 'ht_lxrid',
      htLxrinfo: 'ht_lxrinfo',
      htMoneyzhekou: 'ht_moneyzhekou',
      htNumber: 'ht_number',
      htOrder: 'ht_order',
      htPaymode: 'ht_paymode',
      htPreside: 'ht_preside',
      htRemark: 'ht_remark',
      htState: 'ht_state',
      htSummemo: 'ht_summemo',
      htSummoney: 'ht_summoney',
      htTitle: 'ht_title',
      htType: 'ht_type',
      htWesub: 'ht_wesub',
      htWuliutype: 'ht_wuliutype',
      htXshid: 'ht_xshid',
      htYunfeimoney: 'ht_yunfeimoney',
    };
  }

  static types(): { [key: string]: any } {
    return {
      childMx: 'string',
      dataUserid: 'string',
      fahuoaddressid: 'string',
      htBegindate: 'string',
      htContract: 'string',
      htCustomerid: 'string',
      htCusub: 'string',
      htDate: 'string',
      htDeliplace: 'string',
      htEnddate: 'string',
      htFjmoney: 'string',
      htFjmoneylx: 'string',
      htKjmoney: 'string',
      htLxrid: 'string',
      htLxrinfo: 'string',
      htMoneyzhekou: 'string',
      htNumber: 'string',
      htOrder: 'string',
      htPaymode: 'string',
      htPreside: 'string',
      htRemark: 'string',
      htState: 'string',
      htSummemo: 'string',
      htSummoney: 'string',
      htTitle: 'string',
      htType: 'string',
      htWesub: 'string',
      htWuliutype: 'string',
      htXshid: 'string',
      htYunfeimoney: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockRequestData extends $tea.Model {
  askempid?: string;
  auditreson?: string;
  billno?: string;
  childMx?: string;
  customerid?: string;
  dataUserid?: string;
  empid?: string;
  inorout?: string;
  libiodate?: string;
  libioname?: string;
  libiostate?: string;
  orderid?: string;
  remark?: string;
  stocklibid?: string;
  static names(): { [key: string]: string } {
    return {
      askempid: 'askempid',
      auditreson: 'auditreson',
      billno: 'billno',
      childMx: 'child_mx',
      customerid: 'customerid',
      dataUserid: 'data_userid',
      empid: 'empid',
      inorout: 'inorout',
      libiodate: 'libiodate',
      libioname: 'libioname',
      libiostate: 'libiostate',
      orderid: 'orderid',
      remark: 'remark',
      stocklibid: 'stocklibid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      askempid: 'string',
      auditreson: 'string',
      billno: 'string',
      childMx: 'string',
      customerid: 'string',
      dataUserid: 'string',
      empid: 'string',
      inorout: 'string',
      libiodate: 'string',
      libioname: 'string',
      libiostate: 'string',
      orderid: 'string',
      remark: 'string',
      stocklibid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionRequestData extends $tea.Model {
  dataUserid?: string;
  schCustomerid?: string;
  schEndtime?: string;
  schFinished?: string;
  schHtid?: string;
  schMakeemp?: string;
  schNumber?: string;
  schPlanendtime?: string;
  schPrincipal?: string;
  schRemark?: string;
  schStarttime?: string;
  schStatesstr?: string;
  schTitle?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      schCustomerid: 'sch_customerid',
      schEndtime: 'sch_endtime',
      schFinished: 'sch_finished',
      schHtid: 'sch_htid',
      schMakeemp: 'sch_makeemp',
      schNumber: 'sch_number',
      schPlanendtime: 'sch_planendtime',
      schPrincipal: 'sch_principal',
      schRemark: 'sch_remark',
      schStarttime: 'sch_starttime',
      schStatesstr: 'sch_statesstr',
      schTitle: 'sch_title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      schCustomerid: 'string',
      schEndtime: 'string',
      schFinished: 'string',
      schHtid: 'string',
      schMakeemp: 'string',
      schNumber: 'string',
      schPlanendtime: 'string',
      schPrincipal: 'string',
      schRemark: 'string',
      schStarttime: 'string',
      schStatesstr: 'string',
      schTitle: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseRequestData extends $tea.Model {
  cgFjmoney?: string;
  cgFjmoneylx?: string;
  cgKjmoney?: string;
  cgMoneyzhekou?: string;
  cgZxstate?: string;
  cgdate?: string;
  cgname?: string;
  cgno?: string;
  cgremark?: string;
  cgtype?: string;
  childMx?: string;
  dataUserid?: string;
  empid?: string;
  gysLxrid?: string;
  gysLxrinfo?: string;
  gysid?: string;
  gysjingban?: string;
  orderHtid?: string;
  orderKhid?: string;
  summoney?: string;
  static names(): { [key: string]: string } {
    return {
      cgFjmoney: 'cg_fjmoney',
      cgFjmoneylx: 'cg_fjmoneylx',
      cgKjmoney: 'cg_kjmoney',
      cgMoneyzhekou: 'cg_moneyzhekou',
      cgZxstate: 'cg_zxstate',
      cgdate: 'cgdate',
      cgname: 'cgname',
      cgno: 'cgno',
      cgremark: 'cgremark',
      cgtype: 'cgtype',
      childMx: 'child_mx',
      dataUserid: 'data_userid',
      empid: 'empid',
      gysLxrid: 'gys_lxrid',
      gysLxrinfo: 'gys_lxrinfo',
      gysid: 'gysid',
      gysjingban: 'gysjingban',
      orderHtid: 'order_htid',
      orderKhid: 'order_khid',
      summoney: 'summoney',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cgFjmoney: 'string',
      cgFjmoneylx: 'string',
      cgKjmoney: 'string',
      cgMoneyzhekou: 'string',
      cgZxstate: 'string',
      cgdate: 'string',
      cgname: 'string',
      cgno: 'string',
      cgremark: 'string',
      cgtype: 'string',
      childMx: 'string',
      dataUserid: 'string',
      empid: 'string',
      gysLxrid: 'string',
      gysLxrinfo: 'string',
      gysid: 'string',
      gysjingban: 'string',
      orderHtid: 'string',
      orderKhid: 'string',
      summoney: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordRequestData extends $tea.Model {
  bjBjren?: string;
  bjBzremark?: string;
  bjCustomerid?: string;
  bjDate?: string;
  bjFjmoney?: string;
  bjFjmoneylx?: string;
  bjFkremark?: string;
  bjJfremark?: string;
  bjJshren?: string;
  bjKjmoney?: string;
  bjLianxi?: string;
  bjMoneyzhekou?: string;
  bjNumber?: string;
  bjPrice?: string;
  bjRemark?: string;
  bjState?: string;
  bjTitle?: string;
  bjXshid?: string;
  childMx?: string;
  dataUserid?: string;
  static names(): { [key: string]: string } {
    return {
      bjBjren: 'bj_bjren',
      bjBzremark: 'bj_bzremark',
      bjCustomerid: 'bj_customerid',
      bjDate: 'bj_date',
      bjFjmoney: 'bj_fjmoney',
      bjFjmoneylx: 'bj_fjmoneylx',
      bjFkremark: 'bj_fkremark',
      bjJfremark: 'bj_jfremark',
      bjJshren: 'bj_jshren',
      bjKjmoney: 'bj_kjmoney',
      bjLianxi: 'bj_lianxi',
      bjMoneyzhekou: 'bj_moneyzhekou',
      bjNumber: 'bj_number',
      bjPrice: 'bj_price',
      bjRemark: 'bj_remark',
      bjState: 'bj_state',
      bjTitle: 'bj_title',
      bjXshid: 'bj_xshid',
      childMx: 'child_mx',
      dataUserid: 'data_userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bjBjren: 'string',
      bjBzremark: 'string',
      bjCustomerid: 'string',
      bjDate: 'string',
      bjFjmoney: 'string',
      bjFjmoneylx: 'string',
      bjFkremark: 'string',
      bjJfremark: 'string',
      bjJshren: 'string',
      bjKjmoney: 'string',
      bjLianxi: 'string',
      bjMoneyzhekou: 'string',
      bjNumber: 'string',
      bjPrice: 'string',
      bjRemark: 'string',
      bjState: 'string',
      bjTitle: 'string',
      bjXshid: 'string',
      childMx: 'string',
      dataUserid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesRequestData extends $tea.Model {
  dataUserid?: string;
  xshCustomerid?: string;
  xshDate?: string;
  xshExpdate?: string;
  xshExpmoney?: string;
  xshFrom?: string;
  xshKnx?: string;
  xshLianxi?: string;
  xshLxrid?: string;
  xshMoneynote?: string;
  xshNumber?: string;
  xshPhase?: string;
  xshPhasenote?: string;
  xshPreside?: string;
  xshProvider?: string;
  xshRequire?: string;
  xshState?: string;
  xshTitle?: string;
  xshType?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      xshCustomerid: 'xsh_customerid',
      xshDate: 'xsh_date',
      xshExpdate: 'xsh_expdate',
      xshExpmoney: 'xsh_expmoney',
      xshFrom: 'xsh_from',
      xshKnx: 'xsh_knx',
      xshLianxi: 'xsh_lianxi',
      xshLxrid: 'xsh_lxrid',
      xshMoneynote: 'xsh_moneynote',
      xshNumber: 'xsh_number',
      xshPhase: 'xsh_phase',
      xshPhasenote: 'xsh_phasenote',
      xshPreside: 'xsh_preside',
      xshProvider: 'xsh_provider',
      xshRequire: 'xsh_require',
      xshState: 'xsh_state',
      xshTitle: 'xsh_title',
      xshType: 'xsh_type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      xshCustomerid: 'string',
      xshDate: 'string',
      xshExpdate: 'string',
      xshExpmoney: 'string',
      xshFrom: 'string',
      xshKnx: 'string',
      xshLianxi: 'string',
      xshLxrid: 'string',
      xshMoneynote: 'string',
      xshNumber: 'string',
      xshPhase: 'string',
      xshPhasenote: 'string',
      xshPreside: 'string',
      xshProvider: 'string',
      xshRequire: 'string',
      xshState: 'string',
      xshTitle: 'string',
      xshType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataListResponseBodyData extends $tea.Model {
  detail?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataViewResponseBodyData extends $tea.Model {
  detail?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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


  async editContactWithOptions(request: EditContactRequest, headers: EditContactHeaders, runtime: $Util.RuntimeOptions): Promise<EditContactResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditContact",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/contacts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditContactResponse>(await this.execute(params, req, runtime), new EditContactResponse({}));
  }

  async editContact(request: EditContactRequest): Promise<EditContactResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditContactHeaders({ });
    return await this.editContactWithOptions(request, headers, runtime);
  }

  async editCustomerWithOptions(request: EditCustomerRequest, headers: EditCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<EditCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditCustomer",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/customers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditCustomerResponse>(await this.execute(params, req, runtime), new EditCustomerResponse({}));
  }

  async editCustomer(request: EditCustomerRequest): Promise<EditCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditCustomerHeaders({ });
    return await this.editCustomerWithOptions(request, headers, runtime);
  }

  async editCustomerPoolWithOptions(request: EditCustomerPoolRequest, headers: EditCustomerPoolHeaders, runtime: $Util.RuntimeOptions): Promise<EditCustomerPoolResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditCustomerPool",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/customerPools`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditCustomerPoolResponse>(await this.execute(params, req, runtime), new EditCustomerPoolResponse({}));
  }

  async editCustomerPool(request: EditCustomerPoolRequest): Promise<EditCustomerPoolResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditCustomerPoolHeaders({ });
    return await this.editCustomerPoolWithOptions(request, headers, runtime);
  }

  async editExchangeWithOptions(request: EditExchangeRequest, headers: EditExchangeHeaders, runtime: $Util.RuntimeOptions): Promise<EditExchangeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditExchange",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/exchanges`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditExchangeResponse>(await this.execute(params, req, runtime), new EditExchangeResponse({}));
  }

  async editExchange(request: EditExchangeRequest): Promise<EditExchangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditExchangeHeaders({ });
    return await this.editExchangeWithOptions(request, headers, runtime);
  }

  async editGoodsWithOptions(request: EditGoodsRequest, headers: EditGoodsHeaders, runtime: $Util.RuntimeOptions): Promise<EditGoodsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditGoods",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/goods`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditGoodsResponse>(await this.execute(params, req, runtime), new EditGoodsResponse({}));
  }

  async editGoods(request: EditGoodsRequest): Promise<EditGoodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditGoodsHeaders({ });
    return await this.editGoodsWithOptions(request, headers, runtime);
  }

  async editIntostockWithOptions(request: EditIntostockRequest, headers: EditIntostockHeaders, runtime: $Util.RuntimeOptions): Promise<EditIntostockResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditIntostock",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/intostocks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditIntostockResponse>(await this.execute(params, req, runtime), new EditIntostockResponse({}));
  }

  async editIntostock(request: EditIntostockRequest): Promise<EditIntostockResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditIntostockHeaders({ });
    return await this.editIntostockWithOptions(request, headers, runtime);
  }

  async editInvoiceWithOptions(request: EditInvoiceRequest, headers: EditInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<EditInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditInvoice",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/invoices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditInvoiceResponse>(await this.execute(params, req, runtime), new EditInvoiceResponse({}));
  }

  async editInvoice(request: EditInvoiceRequest): Promise<EditInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditInvoiceHeaders({ });
    return await this.editInvoiceWithOptions(request, headers, runtime);
  }

  async editOrderWithOptions(request: EditOrderRequest, headers: EditOrderHeaders, runtime: $Util.RuntimeOptions): Promise<EditOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditOrder",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/orders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditOrderResponse>(await this.execute(params, req, runtime), new EditOrderResponse({}));
  }

  async editOrder(request: EditOrderRequest): Promise<EditOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditOrderHeaders({ });
    return await this.editOrderWithOptions(request, headers, runtime);
  }

  async editOutstockWithOptions(request: EditOutstockRequest, headers: EditOutstockHeaders, runtime: $Util.RuntimeOptions): Promise<EditOutstockResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditOutstock",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/outstocks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditOutstockResponse>(await this.execute(params, req, runtime), new EditOutstockResponse({}));
  }

  async editOutstock(request: EditOutstockRequest): Promise<EditOutstockResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditOutstockHeaders({ });
    return await this.editOutstockWithOptions(request, headers, runtime);
  }

  async editProductionWithOptions(request: EditProductionRequest, headers: EditProductionHeaders, runtime: $Util.RuntimeOptions): Promise<EditProductionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditProduction",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/productions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditProductionResponse>(await this.execute(params, req, runtime), new EditProductionResponse({}));
  }

  async editProduction(request: EditProductionRequest): Promise<EditProductionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditProductionHeaders({ });
    return await this.editProductionWithOptions(request, headers, runtime);
  }

  async editPurchaseWithOptions(request: EditPurchaseRequest, headers: EditPurchaseHeaders, runtime: $Util.RuntimeOptions): Promise<EditPurchaseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditPurchase",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/purchases`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditPurchaseResponse>(await this.execute(params, req, runtime), new EditPurchaseResponse({}));
  }

  async editPurchase(request: EditPurchaseRequest): Promise<EditPurchaseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditPurchaseHeaders({ });
    return await this.editPurchaseWithOptions(request, headers, runtime);
  }

  async editQuotationRecordWithOptions(request: EditQuotationRecordRequest, headers: EditQuotationRecordHeaders, runtime: $Util.RuntimeOptions): Promise<EditQuotationRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditQuotationRecord",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/quotationRecords`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditQuotationRecordResponse>(await this.execute(params, req, runtime), new EditQuotationRecordResponse({}));
  }

  async editQuotationRecord(request: EditQuotationRecordRequest): Promise<EditQuotationRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditQuotationRecordHeaders({ });
    return await this.editQuotationRecordWithOptions(request, headers, runtime);
  }

  async editSalesWithOptions(request: EditSalesRequest, headers: EditSalesHeaders, runtime: $Util.RuntimeOptions): Promise<EditSalesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

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
      action: "EditSales",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/sales`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EditSalesResponse>(await this.execute(params, req, runtime), new EditSalesResponse({}));
  }

  async editSales(request: EditSalesRequest): Promise<EditSalesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditSalesHeaders({ });
    return await this.editSalesWithOptions(request, headers, runtime);
  }

  async getDataListWithOptions(request: GetDataListRequest, headers: GetDataListHeaders, runtime: $Util.RuntimeOptions): Promise<GetDataListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      query["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.page)) {
      query["page"] = request.page;
    }

    if (!Util.isUnset(request.pagesize)) {
      query["pagesize"] = request.pagesize;
    }

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
      action: "GetDataList",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/data`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDataListResponse>(await this.execute(params, req, runtime), new GetDataListResponse({}));
  }

  async getDataList(request: GetDataListRequest): Promise<GetDataListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDataListHeaders({ });
    return await this.getDataListWithOptions(request, headers, runtime);
  }

  async getDataViewWithOptions(request: GetDataViewRequest, headers: GetDataViewHeaders, runtime: $Util.RuntimeOptions): Promise<GetDataViewResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      query["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.msgid)) {
      query["msgid"] = request.msgid;
    }

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
      action: "GetDataView",
      version: "jzcrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jzcrm/dataView`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDataViewResponse>(await this.execute(params, req, runtime), new GetDataViewResponse({}));
  }

  async getDataView(request: GetDataViewRequest): Promise<GetDataViewResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDataViewHeaders({ });
    return await this.getDataViewWithOptions(request, headers, runtime);
  }

}
