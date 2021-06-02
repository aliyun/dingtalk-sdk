// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditExchangeRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditExchangeRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditExchangeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditExchangeResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditProductionRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditProductionRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditProductionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditProductionResponseBody,
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
  body: GetDataViewResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDataViewResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditSalesRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditSalesRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditSalesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditSalesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditSalesResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditGoodsRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditGoodsRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditGoodsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditGoodsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditContactRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditContactRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditContactResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditContactResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditOrderRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditOrderRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditOrderResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditQuotationRecordRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditQuotationRecordRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditQuotationRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditQuotationRecordResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditCustomerPoolRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditCustomerPoolRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditCustomerPoolResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditCustomerPoolResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditPurchaseRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditPurchaseRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditPurchaseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditPurchaseResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditIntostockRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditIntostockRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditIntostockResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditIntostockResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditCustomerRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditCustomerRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditCustomerResponseBody,
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
  totalCount?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      dataname: 'dataname',
      page: 'page',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetDataListResponseBodyData },
      dataname: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      page: 'number',
      pageSize: 'number',
      totalCount: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDataListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDataListResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditInvoiceRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditInvoiceRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditInvoiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditInvoiceResponseBody,
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
  datatype?: number;
  stamp?: number;
  msgid?: number;
  data?: EditOutstockRequestData;
  static names(): { [key: string]: string } {
    return {
      datatype: 'datatype',
      stamp: 'stamp',
      msgid: 'msgid',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      datatype: 'number',
      stamp: 'number',
      msgid: 'number',
      data: EditOutstockRequestData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockResponseBody extends $tea.Model {
  time?: string;
  msgid?: number;
  static names(): { [key: string]: string } {
    return {
      time: 'time',
      msgid: 'msgid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      time: 'string',
      msgid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditOutstockResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditOutstockResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditExchangeRequestData extends $tea.Model {
  dataUserid?: string;
  hhInlibid?: string;
  hhOutlibid?: string;
  hhTitle?: string;
  hhNumber?: string;
  hhCustomerid?: string;
  hhOrderid?: string;
  hhType?: string;
  hhDate?: string;
  hhInempid?: string;
  hhIntime?: string;
  hhOutempid?: string;
  hhOuttime?: string;
  hhRemark?: string;
  hhState?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      hhInlibid: 'hh_inlibid',
      hhOutlibid: 'hh_outlibid',
      hhTitle: 'hh_title',
      hhNumber: 'hh_number',
      hhCustomerid: 'hh_customerid',
      hhOrderid: 'hh_orderid',
      hhType: 'hh_type',
      hhDate: 'hh_date',
      hhInempid: 'hh_inempid',
      hhIntime: 'hh_intime',
      hhOutempid: 'hh_outempid',
      hhOuttime: 'hh_outtime',
      hhRemark: 'hh_remark',
      hhState: 'hh_state',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      hhInlibid: 'string',
      hhOutlibid: 'string',
      hhTitle: 'string',
      hhNumber: 'string',
      hhCustomerid: 'string',
      hhOrderid: 'string',
      hhType: 'string',
      hhDate: 'string',
      hhInempid: 'string',
      hhIntime: 'string',
      hhOutempid: 'string',
      hhOuttime: 'string',
      hhRemark: 'string',
      hhState: 'string',
      childMx: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditProductionRequestData extends $tea.Model {
  dataUserid?: string;
  schTitle?: string;
  schNumber?: string;
  schStarttime?: string;
  schPlanendtime?: string;
  schCustomerid?: string;
  schHtid?: string;
  schEndtime?: string;
  schPrincipal?: string;
  schMakeemp?: string;
  schRemark?: string;
  schStatesstr?: string;
  schFinished?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      schTitle: 'sch_title',
      schNumber: 'sch_number',
      schStarttime: 'sch_starttime',
      schPlanendtime: 'sch_planendtime',
      schCustomerid: 'sch_customerid',
      schHtid: 'sch_htid',
      schEndtime: 'sch_endtime',
      schPrincipal: 'sch_principal',
      schMakeemp: 'sch_makeemp',
      schRemark: 'sch_remark',
      schStatesstr: 'sch_statesstr',
      schFinished: 'sch_finished',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      schTitle: 'string',
      schNumber: 'string',
      schStarttime: 'string',
      schPlanendtime: 'string',
      schCustomerid: 'string',
      schHtid: 'string',
      schEndtime: 'string',
      schPrincipal: 'string',
      schMakeemp: 'string',
      schRemark: 'string',
      schStatesstr: 'string',
      schFinished: 'string',
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

export class EditSalesRequestData extends $tea.Model {
  dataUserid?: string;
  xshCustomerid?: string;
  xshTitle?: string;
  xshDate?: string;
  xshNumber?: string;
  xshLxrid?: string;
  xshLianxi?: string;
  xshType?: string;
  xshFrom?: string;
  xshPreside?: string;
  xshProvider?: string;
  xshRequire?: string;
  xshExpdate?: string;
  xshExpmoney?: string;
  xshMoneynote?: string;
  xshPhase?: string;
  xshKnx?: string;
  xshState?: string;
  xshPhasenote?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      xshCustomerid: 'xsh_customerid',
      xshTitle: 'xsh_title',
      xshDate: 'xsh_date',
      xshNumber: 'xsh_number',
      xshLxrid: 'xsh_lxrid',
      xshLianxi: 'xsh_lianxi',
      xshType: 'xsh_type',
      xshFrom: 'xsh_from',
      xshPreside: 'xsh_preside',
      xshProvider: 'xsh_provider',
      xshRequire: 'xsh_require',
      xshExpdate: 'xsh_expdate',
      xshExpmoney: 'xsh_expmoney',
      xshMoneynote: 'xsh_moneynote',
      xshPhase: 'xsh_phase',
      xshKnx: 'xsh_knx',
      xshState: 'xsh_state',
      xshPhasenote: 'xsh_phasenote',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      xshCustomerid: 'string',
      xshTitle: 'string',
      xshDate: 'string',
      xshNumber: 'string',
      xshLxrid: 'string',
      xshLianxi: 'string',
      xshType: 'string',
      xshFrom: 'string',
      xshPreside: 'string',
      xshProvider: 'string',
      xshRequire: 'string',
      xshExpdate: 'string',
      xshExpmoney: 'string',
      xshMoneynote: 'string',
      xshPhase: 'string',
      xshKnx: 'string',
      xshState: 'string',
      xshPhasenote: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditGoodsRequestData extends $tea.Model {
  dataUserid?: string;
  cpname?: string;
  cpunit?: string;
  unitrate?: string;
  cpParentid?: string;
  cptype?: string;
  cpguige?: string;
  typeid?: string;
  cpno?: string;
  isstop?: string;
  addedtime?: string;
  cparea?: string;
  cpbrand?: string;
  cbprice?: string;
  issnmanage?: string;
  ispicimanage?: string;
  gysid?: string;
  cpimg?: string;
  cpbarcode?: string;
  cpweight?: string;
  preprice1?: string;
  preprice2?: string;
  preprice3?: string;
  preprice4?: string;
  isstock?: string;
  stockup?: string;
  stockdown?: string;
  cpcontent?: string;
  cpremark?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      cpname: 'cpname',
      cpunit: 'cpunit',
      unitrate: 'unitrate',
      cpParentid: 'cp_parentid',
      cptype: 'cptype',
      cpguige: 'cpguige',
      typeid: 'typeid',
      cpno: 'cpno',
      isstop: 'isstop',
      addedtime: 'addedtime',
      cparea: 'cparea',
      cpbrand: 'cpbrand',
      cbprice: 'cbprice',
      issnmanage: 'issnmanage',
      ispicimanage: 'ispicimanage',
      gysid: 'gysid',
      cpimg: 'cpimg',
      cpbarcode: 'cpbarcode',
      cpweight: 'cpweight',
      preprice1: 'preprice1',
      preprice2: 'preprice2',
      preprice3: 'preprice3',
      preprice4: 'preprice4',
      isstock: 'isstock',
      stockup: 'stockup',
      stockdown: 'stockdown',
      cpcontent: 'cpcontent',
      cpremark: 'cpremark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      cpname: 'string',
      cpunit: 'string',
      unitrate: 'string',
      cpParentid: 'string',
      cptype: 'string',
      cpguige: 'string',
      typeid: 'string',
      cpno: 'string',
      isstop: 'string',
      addedtime: 'string',
      cparea: 'string',
      cpbrand: 'string',
      cbprice: 'string',
      issnmanage: 'string',
      ispicimanage: 'string',
      gysid: 'string',
      cpimg: 'string',
      cpbarcode: 'string',
      cpweight: 'string',
      preprice1: 'string',
      preprice2: 'string',
      preprice3: 'string',
      preprice4: 'string',
      isstock: 'string',
      stockup: 'string',
      stockdown: 'string',
      cpcontent: 'string',
      cpremark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditContactRequestData extends $tea.Model {
  dataUserid?: string;
  lxrCustomerid?: string;
  lxrName?: string;
  lxrHandset?: string;
  lxrWorktel?: string;
  lxrSex?: string;
  lxrGroup?: string;
  lxrPreside?: string;
  lxrCttype?: string;
  lxrCtnumber?: string;
  lxrChengwei?: string;
  lxrType?: string;
  lxrDepartment?: string;
  lxrHeadship?: string;
  lxrDingtalk?: string;
  lxrFax?: string;
  lxrWangwang?: string;
  lxrEmail?: string;
  lxrWeixin?: string;
  lxrQq?: string;
  lxrTel?: string;
  lxrPst?: string;
  lxrSkype?: string;
  lxrAddress?: string;
  lxrBirthday?: string;
  lxrLike?: string;
  lxrRemark?: string;
  lxrPhoto?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      lxrCustomerid: 'lxr_customerid',
      lxrName: 'lxr_name',
      lxrHandset: 'lxr_handset',
      lxrWorktel: 'lxr_worktel',
      lxrSex: 'lxr_sex',
      lxrGroup: 'lxr_group',
      lxrPreside: 'lxr_preside',
      lxrCttype: 'lxr_cttype',
      lxrCtnumber: 'lxr_ctnumber',
      lxrChengwei: 'lxr_chengwei',
      lxrType: 'lxr_type',
      lxrDepartment: 'lxr_department',
      lxrHeadship: 'lxr_headship',
      lxrDingtalk: 'lxr_dingtalk',
      lxrFax: 'lxr_fax',
      lxrWangwang: 'lxr_wangwang',
      lxrEmail: 'lxr_email',
      lxrWeixin: 'lxr_weixin',
      lxrQq: 'lxr_qq',
      lxrTel: 'lxr_tel',
      lxrPst: 'lxr_pst',
      lxrSkype: 'lxr_skype',
      lxrAddress: 'lxr_address',
      lxrBirthday: 'lxr_birthday',
      lxrLike: 'lxr_like',
      lxrRemark: 'lxr_remark',
      lxrPhoto: 'lxr_photo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      lxrCustomerid: 'string',
      lxrName: 'string',
      lxrHandset: 'string',
      lxrWorktel: 'string',
      lxrSex: 'string',
      lxrGroup: 'string',
      lxrPreside: 'string',
      lxrCttype: 'string',
      lxrCtnumber: 'string',
      lxrChengwei: 'string',
      lxrType: 'string',
      lxrDepartment: 'string',
      lxrHeadship: 'string',
      lxrDingtalk: 'string',
      lxrFax: 'string',
      lxrWangwang: 'string',
      lxrEmail: 'string',
      lxrWeixin: 'string',
      lxrQq: 'string',
      lxrTel: 'string',
      lxrPst: 'string',
      lxrSkype: 'string',
      lxrAddress: 'string',
      lxrBirthday: 'string',
      lxrLike: 'string',
      lxrRemark: 'string',
      lxrPhoto: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOrderRequestData extends $tea.Model {
  dataUserid?: string;
  htCustomerid?: string;
  htDate?: string;
  htPreside?: string;
  htState?: string;
  htSummoney?: string;
  htOrder?: string;
  htTitle?: string;
  htNumber?: string;
  htLxrid?: string;
  htLxrinfo?: string;
  htXshid?: string;
  htType?: string;
  htPaymode?: string;
  htBegindate?: string;
  htCusub?: string;
  htWesub?: string;
  htMoneyzhekou?: string;
  htKjmoney?: string;
  htFjmoneylx?: string;
  htFjmoney?: string;
  htSummemo?: string;
  htDeliplace?: string;
  htEnddate?: string;
  htWuliutype?: string;
  htYunfeimoney?: string;
  fahuoaddressid?: string;
  htContract?: string;
  htRemark?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      htCustomerid: 'ht_customerid',
      htDate: 'ht_date',
      htPreside: 'ht_preside',
      htState: 'ht_state',
      htSummoney: 'ht_summoney',
      htOrder: 'ht_order',
      htTitle: 'ht_title',
      htNumber: 'ht_number',
      htLxrid: 'ht_lxrid',
      htLxrinfo: 'ht_lxrinfo',
      htXshid: 'ht_xshid',
      htType: 'ht_type',
      htPaymode: 'ht_paymode',
      htBegindate: 'ht_begindate',
      htCusub: 'ht_cusub',
      htWesub: 'ht_wesub',
      htMoneyzhekou: 'ht_moneyzhekou',
      htKjmoney: 'ht_kjmoney',
      htFjmoneylx: 'ht_fjmoneylx',
      htFjmoney: 'ht_fjmoney',
      htSummemo: 'ht_summemo',
      htDeliplace: 'ht_deliplace',
      htEnddate: 'ht_enddate',
      htWuliutype: 'ht_wuliutype',
      htYunfeimoney: 'ht_yunfeimoney',
      fahuoaddressid: 'fahuoaddressid',
      htContract: 'ht_contract',
      htRemark: 'ht_remark',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      htCustomerid: 'string',
      htDate: 'string',
      htPreside: 'string',
      htState: 'string',
      htSummoney: 'string',
      htOrder: 'string',
      htTitle: 'string',
      htNumber: 'string',
      htLxrid: 'string',
      htLxrinfo: 'string',
      htXshid: 'string',
      htType: 'string',
      htPaymode: 'string',
      htBegindate: 'string',
      htCusub: 'string',
      htWesub: 'string',
      htMoneyzhekou: 'string',
      htKjmoney: 'string',
      htFjmoneylx: 'string',
      htFjmoney: 'string',
      htSummemo: 'string',
      htDeliplace: 'string',
      htEnddate: 'string',
      htWuliutype: 'string',
      htYunfeimoney: 'string',
      fahuoaddressid: 'string',
      htContract: 'string',
      htRemark: 'string',
      childMx: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditQuotationRecordRequestData extends $tea.Model {
  dataUserid?: string;
  bjCustomerid?: string;
  bjBjren?: string;
  bjDate?: string;
  bjPrice?: string;
  bjTitle?: string;
  bjNumber?: string;
  bjState?: string;
  bjJshren?: string;
  bjLianxi?: string;
  bjXshid?: string;
  bjMoneyzhekou?: string;
  bjKjmoney?: string;
  bjFjmoneylx?: string;
  bjFjmoney?: string;
  bjJfremark?: string;
  bjFkremark?: string;
  bjBzremark?: string;
  bjRemark?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      bjCustomerid: 'bj_customerid',
      bjBjren: 'bj_bjren',
      bjDate: 'bj_date',
      bjPrice: 'bj_price',
      bjTitle: 'bj_title',
      bjNumber: 'bj_number',
      bjState: 'bj_state',
      bjJshren: 'bj_jshren',
      bjLianxi: 'bj_lianxi',
      bjXshid: 'bj_xshid',
      bjMoneyzhekou: 'bj_moneyzhekou',
      bjKjmoney: 'bj_kjmoney',
      bjFjmoneylx: 'bj_fjmoneylx',
      bjFjmoney: 'bj_fjmoney',
      bjJfremark: 'bj_jfremark',
      bjFkremark: 'bj_fkremark',
      bjBzremark: 'bj_bzremark',
      bjRemark: 'bj_remark',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      bjCustomerid: 'string',
      bjBjren: 'string',
      bjDate: 'string',
      bjPrice: 'string',
      bjTitle: 'string',
      bjNumber: 'string',
      bjState: 'string',
      bjJshren: 'string',
      bjLianxi: 'string',
      bjXshid: 'string',
      bjMoneyzhekou: 'string',
      bjKjmoney: 'string',
      bjFjmoneylx: 'string',
      bjFjmoney: 'string',
      bjJfremark: 'string',
      bjFkremark: 'string',
      bjBzremark: 'string',
      bjRemark: 'string',
      childMx: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerPoolRequestData extends $tea.Model {
  dataUserid?: string;
  khPkhid?: string;
  khClass?: string;
  khName?: string;
  khSex?: string;
  khShortname?: string;
  khIndustry?: string;
  khEmployees?: string;
  khAddress?: string;
  khCountry?: string;
  khProvince?: string;
  khCity?: string;
  khCoaddress?: string;
  khHottype?: string;
  khHotlevel?: string;
  khHotfl?: string;
  khHotmemo?: string;
  khType?: string;
  khStatus?: string;
  khSn?: string;
  khHandset?: string;
  khEmail?: string;
  khDingtalk?: string;
  khTel?: string;
  khWeixin?: string;
  khQq?: string;
  khSkype?: string;
  khWangwang?: string;
  khWorktel?: string;
  khFax?: string;
  khPst?: string;
  khDepartment?: string;
  khAppellation?: string;
  khPreside?: string;
  khHeadship?: string;
  khWeb?: string;
  khBefontof?: string;
  khFrom?: string;
  khBillinfo?: string;
  khInfo?: string;
  khRalagrade?: string;
  khCreditgrade?: string;
  khValrating?: string;
  khCttype?: string;
  khCtnumber?: string;
  khContype?: string;
  khRemark?: string;
  khJibie?: string;
  khGenzongtime?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      khPkhid: 'kh_pkhid',
      khClass: 'kh_class',
      khName: 'kh_name',
      khSex: 'kh_sex',
      khShortname: 'kh_shortname',
      khIndustry: 'kh_industry',
      khEmployees: 'kh_employees',
      khAddress: 'kh_address',
      khCountry: 'kh_country',
      khProvince: 'kh_province',
      khCity: 'kh_city',
      khCoaddress: 'kh_coaddress',
      khHottype: 'kh_hottype',
      khHotlevel: 'kh_hotlevel',
      khHotfl: 'kh_hotfl',
      khHotmemo: 'kh_hotmemo',
      khType: 'kh_type',
      khStatus: 'kh_status',
      khSn: 'kh_sn',
      khHandset: 'kh_handset',
      khEmail: 'kh_email',
      khDingtalk: 'kh_dingtalk',
      khTel: 'kh_tel',
      khWeixin: 'kh_weixin',
      khQq: 'kh_qq',
      khSkype: 'kh_skype',
      khWangwang: 'kh_wangwang',
      khWorktel: 'kh_worktel',
      khFax: 'kh_fax',
      khPst: 'kh_pst',
      khDepartment: 'kh_department',
      khAppellation: 'kh_appellation',
      khPreside: 'kh_preside',
      khHeadship: 'kh_headship',
      khWeb: 'kh_web',
      khBefontof: 'kh_befontof',
      khFrom: 'kh_from',
      khBillinfo: 'kh_billinfo',
      khInfo: 'kh_info',
      khRalagrade: 'kh_ralagrade',
      khCreditgrade: 'kh_creditgrade',
      khValrating: 'kh_valrating',
      khCttype: 'kh_cttype',
      khCtnumber: 'kh_ctnumber',
      khContype: 'kh_contype',
      khRemark: 'kh_remark',
      khJibie: 'kh_jibie',
      khGenzongtime: 'kh_genzongtime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      khPkhid: 'string',
      khClass: 'string',
      khName: 'string',
      khSex: 'string',
      khShortname: 'string',
      khIndustry: 'string',
      khEmployees: 'string',
      khAddress: 'string',
      khCountry: 'string',
      khProvince: 'string',
      khCity: 'string',
      khCoaddress: 'string',
      khHottype: 'string',
      khHotlevel: 'string',
      khHotfl: 'string',
      khHotmemo: 'string',
      khType: 'string',
      khStatus: 'string',
      khSn: 'string',
      khHandset: 'string',
      khEmail: 'string',
      khDingtalk: 'string',
      khTel: 'string',
      khWeixin: 'string',
      khQq: 'string',
      khSkype: 'string',
      khWangwang: 'string',
      khWorktel: 'string',
      khFax: 'string',
      khPst: 'string',
      khDepartment: 'string',
      khAppellation: 'string',
      khPreside: 'string',
      khHeadship: 'string',
      khWeb: 'string',
      khBefontof: 'string',
      khFrom: 'string',
      khBillinfo: 'string',
      khInfo: 'string',
      khRalagrade: 'string',
      khCreditgrade: 'string',
      khValrating: 'string',
      khCttype: 'string',
      khCtnumber: 'string',
      khContype: 'string',
      khRemark: 'string',
      khJibie: 'string',
      khGenzongtime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditPurchaseRequestData extends $tea.Model {
  dataUserid?: string;
  gysid?: string;
  cgno?: string;
  summoney?: string;
  cgdate?: string;
  cgZxstate?: string;
  orderKhid?: string;
  cgname?: string;
  gysLxrid?: string;
  gysLxrinfo?: string;
  cgtype?: string;
  gysjingban?: string;
  empid?: string;
  cgMoneyzhekou?: string;
  cgKjmoney?: string;
  cgFjmoneylx?: string;
  cgFjmoney?: string;
  orderHtid?: string;
  cgremark?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      gysid: 'gysid',
      cgno: 'cgno',
      summoney: 'summoney',
      cgdate: 'cgdate',
      cgZxstate: 'cg_zxstate',
      orderKhid: 'order_khid',
      cgname: 'cgname',
      gysLxrid: 'gys_lxrid',
      gysLxrinfo: 'gys_lxrinfo',
      cgtype: 'cgtype',
      gysjingban: 'gysjingban',
      empid: 'empid',
      cgMoneyzhekou: 'cg_moneyzhekou',
      cgKjmoney: 'cg_kjmoney',
      cgFjmoneylx: 'cg_fjmoneylx',
      cgFjmoney: 'cg_fjmoney',
      orderHtid: 'order_htid',
      cgremark: 'cgremark',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      gysid: 'string',
      cgno: 'string',
      summoney: 'string',
      cgdate: 'string',
      cgZxstate: 'string',
      orderKhid: 'string',
      cgname: 'string',
      gysLxrid: 'string',
      gysLxrinfo: 'string',
      cgtype: 'string',
      gysjingban: 'string',
      empid: 'string',
      cgMoneyzhekou: 'string',
      cgKjmoney: 'string',
      cgFjmoneylx: 'string',
      cgFjmoney: 'string',
      orderHtid: 'string',
      cgremark: 'string',
      childMx: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditIntostockRequestData extends $tea.Model {
  dataUserid?: string;
  libiodate?: string;
  stocklibid?: string;
  libiostate?: string;
  billno?: string;
  customerid?: string;
  empid?: string;
  inorout?: string;
  libioname?: string;
  orderid?: string;
  askempid?: string;
  remark?: string;
  auditreson?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      libiodate: 'libiodate',
      stocklibid: 'stocklibid',
      libiostate: 'libiostate',
      billno: 'billno',
      customerid: 'customerid',
      empid: 'empid',
      inorout: 'inorout',
      libioname: 'libioname',
      orderid: 'orderid',
      askempid: 'askempid',
      remark: 'remark',
      auditreson: 'auditreson',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      libiodate: 'string',
      stocklibid: 'string',
      libiostate: 'string',
      billno: 'string',
      customerid: 'string',
      empid: 'string',
      inorout: 'string',
      libioname: 'string',
      orderid: 'string',
      askempid: 'string',
      remark: 'string',
      auditreson: 'string',
      childMx: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditCustomerRequestData extends $tea.Model {
  dataUserid?: string;
  khPkhid?: string;
  khClass?: string;
  khName?: string;
  khSex?: string;
  khShortname?: string;
  khIndustry?: string;
  khEmployees?: string;
  khAddress?: string;
  khCountry?: string;
  khProvince?: string;
  khCity?: string;
  khCoaddress?: string;
  khHottype?: string;
  khHotlevel?: string;
  khHotfl?: string;
  khHotmemo?: string;
  khType?: string;
  khStatus?: string;
  khSn?: string;
  khHandset?: string;
  khEmail?: string;
  khDingtalk?: string;
  khTel?: string;
  khWeixin?: string;
  khQq?: string;
  khSkype?: string;
  khWangwang?: string;
  khWorktel?: string;
  khFax?: string;
  khPst?: string;
  khDepartment?: string;
  khAppellation?: string;
  khPreside?: string;
  khHeadship?: string;
  khWeb?: string;
  khBefontof?: string;
  khFrom?: string;
  khBillinfo?: string;
  khInfo?: string;
  khRalagrade?: string;
  khCreditgrade?: string;
  khValrating?: string;
  khCttype?: string;
  khCtnumber?: string;
  khContype?: string;
  khRemark?: string;
  khJibie?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      khPkhid: 'kh_pkhid',
      khClass: 'kh_class',
      khName: 'kh_name',
      khSex: 'kh_sex',
      khShortname: 'kh_shortname',
      khIndustry: 'kh_industry',
      khEmployees: 'kh_employees',
      khAddress: 'kh_address',
      khCountry: 'kh_country',
      khProvince: 'kh_province',
      khCity: 'kh_city',
      khCoaddress: 'kh_coaddress',
      khHottype: 'kh_hottype',
      khHotlevel: 'kh_hotlevel',
      khHotfl: 'kh_hotfl',
      khHotmemo: 'kh_hotmemo',
      khType: 'kh_type',
      khStatus: 'kh_status',
      khSn: 'kh_sn',
      khHandset: 'kh_handset',
      khEmail: 'kh_email',
      khDingtalk: 'kh_dingtalk',
      khTel: 'kh_tel',
      khWeixin: 'kh_weixin',
      khQq: 'kh_qq',
      khSkype: 'kh_skype',
      khWangwang: 'kh_wangwang',
      khWorktel: 'kh_worktel',
      khFax: 'kh_fax',
      khPst: 'kh_pst',
      khDepartment: 'kh_department',
      khAppellation: 'kh_appellation',
      khPreside: 'kh_preside',
      khHeadship: 'kh_headship',
      khWeb: 'kh_web',
      khBefontof: 'kh_befontof',
      khFrom: 'kh_from',
      khBillinfo: 'kh_billinfo',
      khInfo: 'kh_info',
      khRalagrade: 'kh_ralagrade',
      khCreditgrade: 'kh_creditgrade',
      khValrating: 'kh_valrating',
      khCttype: 'kh_cttype',
      khCtnumber: 'kh_ctnumber',
      khContype: 'kh_contype',
      khRemark: 'kh_remark',
      khJibie: 'kh_jibie',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      khPkhid: 'string',
      khClass: 'string',
      khName: 'string',
      khSex: 'string',
      khShortname: 'string',
      khIndustry: 'string',
      khEmployees: 'string',
      khAddress: 'string',
      khCountry: 'string',
      khProvince: 'string',
      khCity: 'string',
      khCoaddress: 'string',
      khHottype: 'string',
      khHotlevel: 'string',
      khHotfl: 'string',
      khHotmemo: 'string',
      khType: 'string',
      khStatus: 'string',
      khSn: 'string',
      khHandset: 'string',
      khEmail: 'string',
      khDingtalk: 'string',
      khTel: 'string',
      khWeixin: 'string',
      khQq: 'string',
      khSkype: 'string',
      khWangwang: 'string',
      khWorktel: 'string',
      khFax: 'string',
      khPst: 'string',
      khDepartment: 'string',
      khAppellation: 'string',
      khPreside: 'string',
      khHeadship: 'string',
      khWeb: 'string',
      khBefontof: 'string',
      khFrom: 'string',
      khBillinfo: 'string',
      khInfo: 'string',
      khRalagrade: 'string',
      khCreditgrade: 'string',
      khValrating: 'string',
      khCttype: 'string',
      khCtnumber: 'string',
      khContype: 'string',
      khRemark: 'string',
      khJibie: 'string',
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

export class EditInvoiceRequestData extends $tea.Model {
  dataUserid?: string;
  fhCustomerid?: string;
  fhDate?: string;
  fhNumber?: string;
  fhMode?: string;
  fhHtorder?: string;
  fhTitle?: string;
  fhYunfei?: string;
  fhJianshu?: string;
  fhKg?: string;
  fhShipper?: string;
  fhPreside?: string;
  fhLxrid?: string;
  fhLinkman?: string;
  fhTel?: string;
  fhHandset?: string;
  fhPost?: string;
  fhAddress?: string;
  fhEmail?: string;
  fhMsn?: string;
  fhRemark?: string;
  fhState?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      fhCustomerid: 'fh_customerid',
      fhDate: 'fh_date',
      fhNumber: 'fh_number',
      fhMode: 'fh_mode',
      fhHtorder: 'fh_htorder',
      fhTitle: 'fh_title',
      fhYunfei: 'fh_yunfei',
      fhJianshu: 'fh_jianshu',
      fhKg: 'fh_kg',
      fhShipper: 'fh_shipper',
      fhPreside: 'fh_preside',
      fhLxrid: 'fh_lxrid',
      fhLinkman: 'fh_linkman',
      fhTel: 'fh_tel',
      fhHandset: 'fh_handset',
      fhPost: 'fh_post',
      fhAddress: 'fh_address',
      fhEmail: 'fh_email',
      fhMsn: 'fh_msn',
      fhRemark: 'fh_remark',
      fhState: 'fh_state',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      fhCustomerid: 'string',
      fhDate: 'string',
      fhNumber: 'string',
      fhMode: 'string',
      fhHtorder: 'string',
      fhTitle: 'string',
      fhYunfei: 'string',
      fhJianshu: 'string',
      fhKg: 'string',
      fhShipper: 'string',
      fhPreside: 'string',
      fhLxrid: 'string',
      fhLinkman: 'string',
      fhTel: 'string',
      fhHandset: 'string',
      fhPost: 'string',
      fhAddress: 'string',
      fhEmail: 'string',
      fhMsn: 'string',
      fhRemark: 'string',
      fhState: 'string',
      childMx: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditOutstockRequestData extends $tea.Model {
  dataUserid?: string;
  libiodate?: string;
  stocklibid?: string;
  libiostate?: string;
  billno?: string;
  customerid?: string;
  empid?: string;
  inorout?: string;
  libioname?: string;
  orderid?: string;
  askempid?: string;
  remark?: string;
  auditreson?: string;
  childMx?: string;
  static names(): { [key: string]: string } {
    return {
      dataUserid: 'data_userid',
      libiodate: 'libiodate',
      stocklibid: 'stocklibid',
      libiostate: 'libiostate',
      billno: 'billno',
      customerid: 'customerid',
      empid: 'empid',
      inorout: 'inorout',
      libioname: 'libioname',
      orderid: 'orderid',
      askempid: 'askempid',
      remark: 'remark',
      auditreson: 'auditreson',
      childMx: 'child_mx',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataUserid: 'string',
      libiodate: 'string',
      stocklibid: 'string',
      libiostate: 'string',
      billno: 'string',
      customerid: 'string',
      empid: 'string',
      inorout: 'string',
      libioname: 'string',
      orderid: 'string',
      askempid: 'string',
      remark: 'string',
      auditreson: 'string',
      childMx: 'string',
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


  async editExchange(request: EditExchangeRequest): Promise<EditExchangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditExchangeHeaders({ });
    return await this.editExchangeWithOptions(request, headers, runtime);
  }

  async editExchangeWithOptions(request: EditExchangeRequest, headers: EditExchangeHeaders, runtime: $Util.RuntimeOptions): Promise<EditExchangeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditExchangeResponse>(await this.doROARequest("EditExchange", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/exchanges`, "json", req, runtime), new EditExchangeResponse({}));
  }

  async editProduction(request: EditProductionRequest): Promise<EditProductionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditProductionHeaders({ });
    return await this.editProductionWithOptions(request, headers, runtime);
  }

  async editProductionWithOptions(request: EditProductionRequest, headers: EditProductionHeaders, runtime: $Util.RuntimeOptions): Promise<EditProductionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditProductionResponse>(await this.doROARequest("EditProduction", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/productions`, "json", req, runtime), new EditProductionResponse({}));
  }

  async getDataView(request: GetDataViewRequest): Promise<GetDataViewResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDataViewHeaders({ });
    return await this.getDataViewWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetDataViewResponse>(await this.doROARequest("GetDataView", "jzcrm_1.0", "HTTP", "GET", "AK", `/v1.0/jzcrm/dataView`, "json", req, runtime), new GetDataViewResponse({}));
  }

  async editSales(request: EditSalesRequest): Promise<EditSalesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditSalesHeaders({ });
    return await this.editSalesWithOptions(request, headers, runtime);
  }

  async editSalesWithOptions(request: EditSalesRequest, headers: EditSalesHeaders, runtime: $Util.RuntimeOptions): Promise<EditSalesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditSalesResponse>(await this.doROARequest("EditSales", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/sales`, "json", req, runtime), new EditSalesResponse({}));
  }

  async editGoods(request: EditGoodsRequest): Promise<EditGoodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditGoodsHeaders({ });
    return await this.editGoodsWithOptions(request, headers, runtime);
  }

  async editGoodsWithOptions(request: EditGoodsRequest, headers: EditGoodsHeaders, runtime: $Util.RuntimeOptions): Promise<EditGoodsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditGoodsResponse>(await this.doROARequest("EditGoods", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/goods`, "json", req, runtime), new EditGoodsResponse({}));
  }

  async editContact(request: EditContactRequest): Promise<EditContactResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditContactHeaders({ });
    return await this.editContactWithOptions(request, headers, runtime);
  }

  async editContactWithOptions(request: EditContactRequest, headers: EditContactHeaders, runtime: $Util.RuntimeOptions): Promise<EditContactResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditContactResponse>(await this.doROARequest("EditContact", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/contacts`, "json", req, runtime), new EditContactResponse({}));
  }

  async editOrder(request: EditOrderRequest): Promise<EditOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditOrderHeaders({ });
    return await this.editOrderWithOptions(request, headers, runtime);
  }

  async editOrderWithOptions(request: EditOrderRequest, headers: EditOrderHeaders, runtime: $Util.RuntimeOptions): Promise<EditOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditOrderResponse>(await this.doROARequest("EditOrder", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/orders`, "json", req, runtime), new EditOrderResponse({}));
  }

  async editQuotationRecord(request: EditQuotationRecordRequest): Promise<EditQuotationRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditQuotationRecordHeaders({ });
    return await this.editQuotationRecordWithOptions(request, headers, runtime);
  }

  async editQuotationRecordWithOptions(request: EditQuotationRecordRequest, headers: EditQuotationRecordHeaders, runtime: $Util.RuntimeOptions): Promise<EditQuotationRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditQuotationRecordResponse>(await this.doROARequest("EditQuotationRecord", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/quotationRecords`, "json", req, runtime), new EditQuotationRecordResponse({}));
  }

  async editCustomerPool(request: EditCustomerPoolRequest): Promise<EditCustomerPoolResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditCustomerPoolHeaders({ });
    return await this.editCustomerPoolWithOptions(request, headers, runtime);
  }

  async editCustomerPoolWithOptions(request: EditCustomerPoolRequest, headers: EditCustomerPoolHeaders, runtime: $Util.RuntimeOptions): Promise<EditCustomerPoolResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditCustomerPoolResponse>(await this.doROARequest("EditCustomerPool", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/customerPools`, "json", req, runtime), new EditCustomerPoolResponse({}));
  }

  async editPurchase(request: EditPurchaseRequest): Promise<EditPurchaseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditPurchaseHeaders({ });
    return await this.editPurchaseWithOptions(request, headers, runtime);
  }

  async editPurchaseWithOptions(request: EditPurchaseRequest, headers: EditPurchaseHeaders, runtime: $Util.RuntimeOptions): Promise<EditPurchaseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditPurchaseResponse>(await this.doROARequest("EditPurchase", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/purchases`, "json", req, runtime), new EditPurchaseResponse({}));
  }

  async editIntostock(request: EditIntostockRequest): Promise<EditIntostockResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditIntostockHeaders({ });
    return await this.editIntostockWithOptions(request, headers, runtime);
  }

  async editIntostockWithOptions(request: EditIntostockRequest, headers: EditIntostockHeaders, runtime: $Util.RuntimeOptions): Promise<EditIntostockResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditIntostockResponse>(await this.doROARequest("EditIntostock", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/intostocks`, "json", req, runtime), new EditIntostockResponse({}));
  }

  async editCustomer(request: EditCustomerRequest): Promise<EditCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditCustomerHeaders({ });
    return await this.editCustomerWithOptions(request, headers, runtime);
  }

  async editCustomerWithOptions(request: EditCustomerRequest, headers: EditCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<EditCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditCustomerResponse>(await this.doROARequest("EditCustomer", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/customers`, "json", req, runtime), new EditCustomerResponse({}));
  }

  async getDataList(request: GetDataListRequest): Promise<GetDataListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDataListHeaders({ });
    return await this.getDataListWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetDataListResponse>(await this.doROARequest("GetDataList", "jzcrm_1.0", "HTTP", "GET", "AK", `/v1.0/jzcrm/data`, "json", req, runtime), new GetDataListResponse({}));
  }

  async editInvoice(request: EditInvoiceRequest): Promise<EditInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditInvoiceHeaders({ });
    return await this.editInvoiceWithOptions(request, headers, runtime);
  }

  async editInvoiceWithOptions(request: EditInvoiceRequest, headers: EditInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<EditInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditInvoiceResponse>(await this.doROARequest("EditInvoice", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/invoices`, "json", req, runtime), new EditInvoiceResponse({}));
  }

  async editOutstock(request: EditOutstockRequest): Promise<EditOutstockResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditOutstockHeaders({ });
    return await this.editOutstockWithOptions(request, headers, runtime);
  }

  async editOutstockWithOptions(request: EditOutstockRequest, headers: EditOutstockHeaders, runtime: $Util.RuntimeOptions): Promise<EditOutstockResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.datatype)) {
      body["datatype"] = request.datatype;
    }

    if (!Util.isUnset(request.stamp)) {
      body["stamp"] = request.stamp;
    }

    if (!Util.isUnset(request.msgid)) {
      body["msgid"] = request.msgid;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
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
    return $tea.cast<EditOutstockResponse>(await this.doROARequest("EditOutstock", "jzcrm_1.0", "HTTP", "POST", "AK", `/v1.0/jzcrm/outstocks`, "json", req, runtime), new EditOutstockResponse({}));
  }

}
