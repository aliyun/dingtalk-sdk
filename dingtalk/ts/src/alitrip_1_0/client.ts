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

export class AddCityCarApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCityCarApplyRequest extends $tea.Model {
  cause?: string;
  city?: string;
  corpId?: string;
  date?: string;
  finishedDate?: string;
  projectCode?: string;
  projectName?: string;
  status?: number;
  thirdPartApplyId?: string;
  thirdPartCostCenterId?: string;
  thirdPartInvoiceId?: string;
  timesTotal?: number;
  timesType?: number;
  timesUsed?: number;
  title?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      city: 'city',
      corpId: 'corpId',
      date: 'date',
      finishedDate: 'finishedDate',
      projectCode: 'projectCode',
      projectName: 'projectName',
      status: 'status',
      thirdPartApplyId: 'thirdPartApplyId',
      thirdPartCostCenterId: 'thirdPartCostCenterId',
      thirdPartInvoiceId: 'thirdPartInvoiceId',
      timesTotal: 'timesTotal',
      timesType: 'timesType',
      timesUsed: 'timesUsed',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      city: 'string',
      corpId: 'string',
      date: 'string',
      finishedDate: 'string',
      projectCode: 'string',
      projectName: 'string',
      status: 'number',
      thirdPartApplyId: 'string',
      thirdPartCostCenterId: 'string',
      thirdPartInvoiceId: 'string',
      timesTotal: 'number',
      timesType: 'number',
      timesUsed: 'number',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCityCarApplyResponseBody extends $tea.Model {
  applyId?: number;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCityCarApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddCityCarApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AddCityCarApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyRequest extends $tea.Model {
  corpId?: string;
  operateTime?: string;
  remark?: string;
  status?: number;
  thirdPartApplyId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      operateTime: 'operateTime',
      remark: 'remark',
      status: 'status',
      thirdPartApplyId: 'thirdPartApplyId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      operateTime: 'string',
      remark: 'string',
      status: 'number',
      thirdPartApplyId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyResponseBody extends $tea.Model {
  approveResult?: boolean;
  static names(): { [key: string]: string } {
    return {
      approveResult: 'approveResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveResult: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApproveCityCarApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ApproveCityCarApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ApproveCityCarApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementBtripTrainHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementBtripTrainRequest extends $tea.Model {
  category?: number;
  corpId?: string;
  pageNumber?: number;
  pageSize?: number;
  periodEnd?: string;
  periodStart?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      periodEnd: 'string',
      periodStart: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementBtripTrainResponseBody extends $tea.Model {
  module?: BillSettementBtripTrainResponseBodyModule;
  resultCode?: number;
  resultMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
      resultCode: 'resultCode',
      resultMsg: 'resultMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: BillSettementBtripTrainResponseBodyModule,
      resultCode: 'number',
      resultMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementBtripTrainResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BillSettementBtripTrainResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BillSettementBtripTrainResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementCarHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementCarRequest extends $tea.Model {
  category?: number;
  corpId?: string;
  pageNumber?: number;
  pageSize?: number;
  periodEnd?: string;
  periodStart?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      periodEnd: 'string',
      periodStart: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementCarResponseBody extends $tea.Model {
  module?: BillSettementCarResponseBodyModule;
  resultCode?: number;
  resultMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
      resultCode: 'resultCode',
      resultMsg: 'resultMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: BillSettementCarResponseBodyModule,
      resultCode: 'number',
      resultMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementCarResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BillSettementCarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BillSettementCarResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementFlightHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementFlightRequest extends $tea.Model {
  category?: number;
  corpId?: string;
  pageNumber?: number;
  pageSize?: number;
  periodEnd?: string;
  periodStart?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      periodEnd: 'string',
      periodStart: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementFlightResponseBody extends $tea.Model {
  module?: BillSettementFlightResponseBodyModule;
  resultCode?: number;
  resultMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
      resultCode: 'resultCode',
      resultMsg: 'resultMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: BillSettementFlightResponseBodyModule,
      resultCode: 'number',
      resultMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementFlightResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BillSettementFlightResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BillSettementFlightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementHotelHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementHotelRequest extends $tea.Model {
  category?: number;
  corpId?: string;
  pageNumber?: number;
  pageSize?: number;
  periodEnd?: string;
  periodStart?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      periodEnd: 'string',
      periodStart: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementHotelResponseBody extends $tea.Model {
  module?: BillSettementHotelResponseBodyModule;
  resultCode?: number;
  resultMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
      resultCode: 'resultCode',
      resultMsg: 'resultMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: BillSettementHotelResponseBodyModule,
      resultCode: 'number',
      resultMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementHotelResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BillSettementHotelResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BillSettementHotelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlightExceedApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlightExceedApplyRequest extends $tea.Model {
  applyId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlightExceedApplyResponseBody extends $tea.Model {
  applyId?: number;
  applyIntentionInfoDO?: GetFlightExceedApplyResponseBodyApplyIntentionInfoDO;
  btripCause?: string;
  corpId?: string;
  exceedReason?: string;
  exceedType?: number;
  originStandard?: string;
  status?: number;
  submitTime?: string;
  thirdpartApplyId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      applyIntentionInfoDO: 'applyIntentionInfoDO',
      btripCause: 'btripCause',
      corpId: 'corpId',
      exceedReason: 'exceedReason',
      exceedType: 'exceedType',
      originStandard: 'originStandard',
      status: 'status',
      submitTime: 'submitTime',
      thirdpartApplyId: 'thirdpartApplyId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'number',
      applyIntentionInfoDO: GetFlightExceedApplyResponseBodyApplyIntentionInfoDO,
      btripCause: 'string',
      corpId: 'string',
      exceedReason: 'string',
      exceedType: 'number',
      originStandard: 'string',
      status: 'number',
      submitTime: 'string',
      thirdpartApplyId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlightExceedApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFlightExceedApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFlightExceedApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHotelExceedApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHotelExceedApplyRequest extends $tea.Model {
  applyId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHotelExceedApplyResponseBody extends $tea.Model {
  applyId?: number;
  applyIntentionInfoDO?: GetHotelExceedApplyResponseBodyApplyIntentionInfoDO;
  btripCause?: string;
  corpId?: string;
  exceedReason?: string;
  exceedType?: number;
  originStandard?: string;
  status?: number;
  submitTime?: string;
  thirdpartApplyId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      applyIntentionInfoDO: 'applyIntentionInfoDO',
      btripCause: 'btripCause',
      corpId: 'corpId',
      exceedReason: 'exceedReason',
      exceedType: 'exceedType',
      originStandard: 'originStandard',
      status: 'status',
      submitTime: 'submitTime',
      thirdpartApplyId: 'thirdpartApplyId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'number',
      applyIntentionInfoDO: GetHotelExceedApplyResponseBodyApplyIntentionInfoDO,
      btripCause: 'string',
      corpId: 'string',
      exceedReason: 'string',
      exceedType: 'number',
      originStandard: 'string',
      status: 'number',
      submitTime: 'string',
      thirdpartApplyId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHotelExceedApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetHotelExceedApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetHotelExceedApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrainExceedApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrainExceedApplyRequest extends $tea.Model {
  applyId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrainExceedApplyResponseBody extends $tea.Model {
  applyId?: number;
  applyIntentionInfoDO?: GetTrainExceedApplyResponseBodyApplyIntentionInfoDO;
  btripCause?: string;
  corpId?: string;
  exceedReason?: string;
  exceedType?: number;
  originStandard?: string;
  status?: number;
  submitTime?: string;
  thirdpartApplyId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      applyIntentionInfoDO: 'applyIntentionInfoDO',
      btripCause: 'btripCause',
      corpId: 'corpId',
      exceedReason: 'exceedReason',
      exceedType: 'exceedType',
      originStandard: 'originStandard',
      status: 'status',
      submitTime: 'submitTime',
      thirdpartApplyId: 'thirdpartApplyId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'number',
      applyIntentionInfoDO: GetTrainExceedApplyResponseBodyApplyIntentionInfoDO,
      btripCause: 'string',
      corpId: 'string',
      exceedReason: 'string',
      exceedType: 'number',
      originStandard: 'string',
      status: 'number',
      submitTime: 'string',
      thirdpartApplyId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrainExceedApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTrainExceedApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetTrainExceedApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyRequest extends $tea.Model {
  corpId?: string;
  createdEndAt?: string;
  createdStartAt?: string;
  pageNumber?: number;
  pageSize?: number;
  thirdPartApplyId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createdEndAt: 'createdEndAt',
      createdStartAt: 'createdStartAt',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      thirdPartApplyId: 'thirdPartApplyId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createdEndAt: 'string',
      createdStartAt: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      thirdPartApplyId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBody extends $tea.Model {
  applyList?: QueryCityCarApplyResponseBodyApplyList[];
  total?: number;
  static names(): { [key: string]: string } {
    return {
      applyList: 'applyList',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyList: { 'type': 'array', 'itemType': QueryCityCarApplyResponseBodyApplyList },
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCityCarApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCityCarApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderRequest extends $tea.Model {
  corpId?: string;
  thirdPartApplyId?: string;
  unionNo?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      thirdPartApplyId: 'thirdPartApplyId',
      unionNo: 'unionNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      thirdPartApplyId: 'string',
      unionNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBody extends $tea.Model {
  corpId?: string;
  flightList?: QueryUnionOrderResponseBodyFlightList[];
  hotelList?: QueryUnionOrderResponseBodyHotelList[];
  trainList?: QueryUnionOrderResponseBodyTrainList[];
  vehicleList?: QueryUnionOrderResponseBodyVehicleList[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      flightList: 'flightList',
      hotelList: 'hotelList',
      trainList: 'trainList',
      vehicleList: 'vehicleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      flightList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyFlightList },
      hotelList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyHotelList },
      trainList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyTrainList },
      vehicleList: { 'type': 'array', 'itemType': QueryUnionOrderResponseBodyVehicleList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUnionOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUnionOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncExceedApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncExceedApplyRequest extends $tea.Model {
  applyId?: string;
  corpId?: string;
  remark?: string;
  status?: number;
  thirdpartyFlowId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      applyId: 'applyId',
      corpId: 'corpId',
      remark: 'remark',
      status: 'status',
      thirdpartyFlowId: 'thirdpartyFlowId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applyId: 'string',
      corpId: 'string',
      remark: 'string',
      status: 'number',
      thirdpartyFlowId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncExceedApplyResponseBody extends $tea.Model {
  module?: boolean;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncExceedApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SyncExceedApplyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncExceedApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementBtripTrainResponseBodyModuleDataList extends $tea.Model {
  alipayTradeNo?: string;
  applyId?: string;
  arrDate?: string;
  arrStation?: string;
  arrTime?: string;
  billRecordTime?: string;
  bookTime?: string;
  bookerId?: string;
  bookerJobNo?: string;
  bookerName?: string;
  capitalDirection?: string;
  cascadeDepartment?: string;
  changeFee?: number;
  coachNo?: string;
  costCenter?: string;
  costCenterNumber?: string;
  coupon?: number;
  department?: string;
  departmentId?: string;
  deptDate?: string;
  deptStation?: string;
  deptTime?: string;
  feeType?: string;
  index?: string;
  invoiceTitle?: string;
  orderId?: string;
  orderPrice?: number;
  overApplyId?: string;
  primaryId?: number;
  projectCode?: string;
  projectName?: string;
  refundFee?: number;
  remark?: string;
  runTime?: string;
  seatNo?: string;
  seatType?: string;
  serviceFee?: number;
  settlementFee?: number;
  settlementGrantFee?: number;
  settlementTime?: string;
  settlementType?: string;
  shortTicketNo?: string;
  status?: number;
  ticketNo?: string;
  ticketPrice?: number;
  trainNo?: string;
  trainType?: string;
  travelerId?: string;
  travelerJobNo?: string;
  travelerName?: string;
  voucherType?: number;
  static names(): { [key: string]: string } {
    return {
      alipayTradeNo: 'alipayTradeNo',
      applyId: 'applyId',
      arrDate: 'arrDate',
      arrStation: 'arrStation',
      arrTime: 'arrTime',
      billRecordTime: 'billRecordTime',
      bookTime: 'bookTime',
      bookerId: 'bookerId',
      bookerJobNo: 'bookerJobNo',
      bookerName: 'bookerName',
      capitalDirection: 'capitalDirection',
      cascadeDepartment: 'cascadeDepartment',
      changeFee: 'changeFee',
      coachNo: 'coachNo',
      costCenter: 'costCenter',
      costCenterNumber: 'costCenterNumber',
      coupon: 'coupon',
      department: 'department',
      departmentId: 'departmentId',
      deptDate: 'deptDate',
      deptStation: 'deptStation',
      deptTime: 'deptTime',
      feeType: 'feeType',
      index: 'index',
      invoiceTitle: 'invoiceTitle',
      orderId: 'orderId',
      orderPrice: 'orderPrice',
      overApplyId: 'overApplyId',
      primaryId: 'primaryId',
      projectCode: 'projectCode',
      projectName: 'projectName',
      refundFee: 'refundFee',
      remark: 'remark',
      runTime: 'runTime',
      seatNo: 'seatNo',
      seatType: 'seatType',
      serviceFee: 'serviceFee',
      settlementFee: 'settlementFee',
      settlementGrantFee: 'settlementGrantFee',
      settlementTime: 'settlementTime',
      settlementType: 'settlementType',
      shortTicketNo: 'shortTicketNo',
      status: 'status',
      ticketNo: 'ticketNo',
      ticketPrice: 'ticketPrice',
      trainNo: 'trainNo',
      trainType: 'trainType',
      travelerId: 'travelerId',
      travelerJobNo: 'travelerJobNo',
      travelerName: 'travelerName',
      voucherType: 'voucherType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayTradeNo: 'string',
      applyId: 'string',
      arrDate: 'string',
      arrStation: 'string',
      arrTime: 'string',
      billRecordTime: 'string',
      bookTime: 'string',
      bookerId: 'string',
      bookerJobNo: 'string',
      bookerName: 'string',
      capitalDirection: 'string',
      cascadeDepartment: 'string',
      changeFee: 'number',
      coachNo: 'string',
      costCenter: 'string',
      costCenterNumber: 'string',
      coupon: 'number',
      department: 'string',
      departmentId: 'string',
      deptDate: 'string',
      deptStation: 'string',
      deptTime: 'string',
      feeType: 'string',
      index: 'string',
      invoiceTitle: 'string',
      orderId: 'string',
      orderPrice: 'number',
      overApplyId: 'string',
      primaryId: 'number',
      projectCode: 'string',
      projectName: 'string',
      refundFee: 'number',
      remark: 'string',
      runTime: 'string',
      seatNo: 'string',
      seatType: 'string',
      serviceFee: 'number',
      settlementFee: 'number',
      settlementGrantFee: 'number',
      settlementTime: 'string',
      settlementType: 'string',
      shortTicketNo: 'string',
      status: 'number',
      ticketNo: 'string',
      ticketPrice: 'number',
      trainNo: 'string',
      trainType: 'string',
      travelerId: 'string',
      travelerJobNo: 'string',
      travelerName: 'string',
      voucherType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementBtripTrainResponseBodyModule extends $tea.Model {
  category?: number;
  corpId?: string;
  dataList?: BillSettementBtripTrainResponseBodyModuleDataList[];
  periodEnd?: string;
  periodStart?: string;
  totalNum?: number;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      dataList: 'dataList',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      dataList: { 'type': 'array', 'itemType': BillSettementBtripTrainResponseBodyModuleDataList },
      periodEnd: 'string',
      periodStart: 'string',
      totalNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementCarResponseBodyModuleDataList extends $tea.Model {
  alipayTradeNo?: string;
  applyId?: string;
  arrCity?: string;
  arrDate?: string;
  arrLocation?: string;
  arrTime?: string;
  billRecordTime?: string;
  bookTime?: string;
  bookerId?: string;
  bookerJobNo?: string;
  bookerName?: string;
  businessCategory?: string;
  capitalDirection?: string;
  carLevel?: string;
  cascadeDepartment?: string;
  costCenter?: string;
  costCenterNumber?: string;
  coupon?: number;
  couponPrice?: number;
  department?: string;
  departmentId?: string;
  deptCity?: string;
  deptDate?: string;
  deptLocation?: string;
  deptTime?: string;
  estimateDriveDistance?: string;
  estimatePrice?: number;
  feeType?: string;
  index?: string;
  invoiceTitle?: string;
  memo?: string;
  orderId?: string;
  orderPrice?: number;
  overApplyId?: string;
  personSettleFee?: number;
  primaryId?: string;
  projectCode?: string;
  projectName?: string;
  providerName?: string;
  realDriveDistance?: string;
  realFromAddr?: string;
  realToAddr?: string;
  remark?: string;
  serviceFee?: string;
  settlementFee?: number;
  settlementGrantFee?: number;
  settlementTime?: string;
  settlementType?: string;
  specialOrder?: string;
  specialReason?: string;
  status?: number;
  subOrderId?: string;
  travelerId?: string;
  travelerJobNo?: string;
  travelerName?: string;
  userConfirmDesc?: string;
  voucherType?: number;
  static names(): { [key: string]: string } {
    return {
      alipayTradeNo: 'alipayTradeNo',
      applyId: 'applyId',
      arrCity: 'arrCity',
      arrDate: 'arrDate',
      arrLocation: 'arrLocation',
      arrTime: 'arrTime',
      billRecordTime: 'billRecordTime',
      bookTime: 'bookTime',
      bookerId: 'bookerId',
      bookerJobNo: 'bookerJobNo',
      bookerName: 'bookerName',
      businessCategory: 'businessCategory',
      capitalDirection: 'capitalDirection',
      carLevel: 'carLevel',
      cascadeDepartment: 'cascadeDepartment',
      costCenter: 'costCenter',
      costCenterNumber: 'costCenterNumber',
      coupon: 'coupon',
      couponPrice: 'couponPrice',
      department: 'department',
      departmentId: 'departmentId',
      deptCity: 'deptCity',
      deptDate: 'deptDate',
      deptLocation: 'deptLocation',
      deptTime: 'deptTime',
      estimateDriveDistance: 'estimateDriveDistance',
      estimatePrice: 'estimatePrice',
      feeType: 'feeType',
      index: 'index',
      invoiceTitle: 'invoiceTitle',
      memo: 'memo',
      orderId: 'orderId',
      orderPrice: 'orderPrice',
      overApplyId: 'overApplyId',
      personSettleFee: 'personSettleFee',
      primaryId: 'primaryId',
      projectCode: 'projectCode',
      projectName: 'projectName',
      providerName: 'providerName',
      realDriveDistance: 'realDriveDistance',
      realFromAddr: 'realFromAddr',
      realToAddr: 'realToAddr',
      remark: 'remark',
      serviceFee: 'serviceFee',
      settlementFee: 'settlementFee',
      settlementGrantFee: 'settlementGrantFee',
      settlementTime: 'settlementTime',
      settlementType: 'settlementType',
      specialOrder: 'specialOrder',
      specialReason: 'specialReason',
      status: 'status',
      subOrderId: 'subOrderId',
      travelerId: 'travelerId',
      travelerJobNo: 'travelerJobNo',
      travelerName: 'travelerName',
      userConfirmDesc: 'userConfirmDesc',
      voucherType: 'voucherType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayTradeNo: 'string',
      applyId: 'string',
      arrCity: 'string',
      arrDate: 'string',
      arrLocation: 'string',
      arrTime: 'string',
      billRecordTime: 'string',
      bookTime: 'string',
      bookerId: 'string',
      bookerJobNo: 'string',
      bookerName: 'string',
      businessCategory: 'string',
      capitalDirection: 'string',
      carLevel: 'string',
      cascadeDepartment: 'string',
      costCenter: 'string',
      costCenterNumber: 'string',
      coupon: 'number',
      couponPrice: 'number',
      department: 'string',
      departmentId: 'string',
      deptCity: 'string',
      deptDate: 'string',
      deptLocation: 'string',
      deptTime: 'string',
      estimateDriveDistance: 'string',
      estimatePrice: 'number',
      feeType: 'string',
      index: 'string',
      invoiceTitle: 'string',
      memo: 'string',
      orderId: 'string',
      orderPrice: 'number',
      overApplyId: 'string',
      personSettleFee: 'number',
      primaryId: 'string',
      projectCode: 'string',
      projectName: 'string',
      providerName: 'string',
      realDriveDistance: 'string',
      realFromAddr: 'string',
      realToAddr: 'string',
      remark: 'string',
      serviceFee: 'string',
      settlementFee: 'number',
      settlementGrantFee: 'number',
      settlementTime: 'string',
      settlementType: 'string',
      specialOrder: 'string',
      specialReason: 'string',
      status: 'number',
      subOrderId: 'string',
      travelerId: 'string',
      travelerJobNo: 'string',
      travelerName: 'string',
      userConfirmDesc: 'string',
      voucherType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementCarResponseBodyModule extends $tea.Model {
  category?: number;
  corpId?: string;
  dataList?: BillSettementCarResponseBodyModuleDataList[];
  periodEnd?: string;
  periodStart?: string;
  totalNum?: number;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      dataList: 'dataList',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      dataList: { 'type': 'array', 'itemType': BillSettementCarResponseBodyModuleDataList },
      periodEnd: 'string',
      periodStart: 'string',
      totalNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementFlightResponseBodyModuleDataList extends $tea.Model {
  advanceDay?: number;
  airlineCorpCode?: string;
  airlineCorpName?: string;
  alipayTradeNo?: string;
  applyId?: string;
  arrAirportCode?: string;
  arrCity?: string;
  arrDate?: string;
  arrStation?: string;
  arrTime?: string;
  billRecordTime?: string;
  bookTime?: string;
  bookerId?: string;
  bookerJobNo?: string;
  bookerName?: string;
  btripCouponFee?: number;
  buildFee?: number;
  cabin?: string;
  cabinClass?: string;
  capitalDirection?: string;
  cascadeDepartment?: string;
  changeFee?: number;
  corpPayOrderFee?: number;
  costCenter?: string;
  costCenterNumber?: string;
  coupon?: number;
  depAirportCode?: string;
  department?: string;
  departmentId?: string;
  deptCity?: string;
  deptDate?: string;
  deptStation?: string;
  deptTime?: string;
  discount?: string;
  feeType?: string;
  flightNo?: string;
  index?: string;
  insuranceFee?: number;
  invoiceTitle?: string;
  itineraryNum?: string;
  itineraryPrice?: number;
  mostDifferenceDeptTime?: string;
  mostDifferenceDiscount?: string;
  mostDifferenceFlightNo?: string;
  mostDifferencePrice?: number;
  mostDifferenceReason?: string;
  mostPrice?: number;
  negotiationCouponFee?: number;
  oilFee?: number;
  orderId?: string;
  overApplyId?: string;
  primaryId?: number;
  projectCode?: string;
  projectName?: string;
  refundFee?: number;
  refundUpgradeCost?: number;
  remark?: string;
  repeatRefund?: string;
  sealPrice?: number;
  serviceFee?: number;
  settlementFee?: number;
  settlementGrantFee?: number;
  settlementTime?: string;
  settlementType?: string;
  status?: number;
  ticketId?: string;
  travelerId?: string;
  travelerJobNo?: string;
  travelerName?: string;
  upgradeCost?: number;
  voucherType?: number;
  static names(): { [key: string]: string } {
    return {
      advanceDay: 'advanceDay',
      airlineCorpCode: 'airlineCorpCode',
      airlineCorpName: 'airlineCorpName',
      alipayTradeNo: 'alipayTradeNo',
      applyId: 'applyId',
      arrAirportCode: 'arrAirportCode',
      arrCity: 'arrCity',
      arrDate: 'arrDate',
      arrStation: 'arrStation',
      arrTime: 'arrTime',
      billRecordTime: 'billRecordTime',
      bookTime: 'bookTime',
      bookerId: 'bookerId',
      bookerJobNo: 'bookerJobNo',
      bookerName: 'bookerName',
      btripCouponFee: 'btripCouponFee',
      buildFee: 'buildFee',
      cabin: 'cabin',
      cabinClass: 'cabinClass',
      capitalDirection: 'capitalDirection',
      cascadeDepartment: 'cascadeDepartment',
      changeFee: 'changeFee',
      corpPayOrderFee: 'corpPayOrderFee',
      costCenter: 'costCenter',
      costCenterNumber: 'costCenterNumber',
      coupon: 'coupon',
      depAirportCode: 'depAirportCode',
      department: 'department',
      departmentId: 'departmentId',
      deptCity: 'deptCity',
      deptDate: 'deptDate',
      deptStation: 'deptStation',
      deptTime: 'deptTime',
      discount: 'discount',
      feeType: 'feeType',
      flightNo: 'flightNo',
      index: 'index',
      insuranceFee: 'insuranceFee',
      invoiceTitle: 'invoiceTitle',
      itineraryNum: 'itineraryNum',
      itineraryPrice: 'itineraryPrice',
      mostDifferenceDeptTime: 'mostDifferenceDeptTime',
      mostDifferenceDiscount: 'mostDifferenceDiscount',
      mostDifferenceFlightNo: 'mostDifferenceFlightNo',
      mostDifferencePrice: 'mostDifferencePrice',
      mostDifferenceReason: 'mostDifferenceReason',
      mostPrice: 'mostPrice',
      negotiationCouponFee: 'negotiationCouponFee',
      oilFee: 'oilFee',
      orderId: 'orderId',
      overApplyId: 'overApplyId',
      primaryId: 'primaryId',
      projectCode: 'projectCode',
      projectName: 'projectName',
      refundFee: 'refundFee',
      refundUpgradeCost: 'refundUpgradeCost',
      remark: 'remark',
      repeatRefund: 'repeatRefund',
      sealPrice: 'sealPrice',
      serviceFee: 'serviceFee',
      settlementFee: 'settlementFee',
      settlementGrantFee: 'settlementGrantFee',
      settlementTime: 'settlementTime',
      settlementType: 'settlementType',
      status: 'status',
      ticketId: 'ticketId',
      travelerId: 'travelerId',
      travelerJobNo: 'travelerJobNo',
      travelerName: 'travelerName',
      upgradeCost: 'upgradeCost',
      voucherType: 'voucherType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advanceDay: 'number',
      airlineCorpCode: 'string',
      airlineCorpName: 'string',
      alipayTradeNo: 'string',
      applyId: 'string',
      arrAirportCode: 'string',
      arrCity: 'string',
      arrDate: 'string',
      arrStation: 'string',
      arrTime: 'string',
      billRecordTime: 'string',
      bookTime: 'string',
      bookerId: 'string',
      bookerJobNo: 'string',
      bookerName: 'string',
      btripCouponFee: 'number',
      buildFee: 'number',
      cabin: 'string',
      cabinClass: 'string',
      capitalDirection: 'string',
      cascadeDepartment: 'string',
      changeFee: 'number',
      corpPayOrderFee: 'number',
      costCenter: 'string',
      costCenterNumber: 'string',
      coupon: 'number',
      depAirportCode: 'string',
      department: 'string',
      departmentId: 'string',
      deptCity: 'string',
      deptDate: 'string',
      deptStation: 'string',
      deptTime: 'string',
      discount: 'string',
      feeType: 'string',
      flightNo: 'string',
      index: 'string',
      insuranceFee: 'number',
      invoiceTitle: 'string',
      itineraryNum: 'string',
      itineraryPrice: 'number',
      mostDifferenceDeptTime: 'string',
      mostDifferenceDiscount: 'string',
      mostDifferenceFlightNo: 'string',
      mostDifferencePrice: 'number',
      mostDifferenceReason: 'string',
      mostPrice: 'number',
      negotiationCouponFee: 'number',
      oilFee: 'number',
      orderId: 'string',
      overApplyId: 'string',
      primaryId: 'number',
      projectCode: 'string',
      projectName: 'string',
      refundFee: 'number',
      refundUpgradeCost: 'number',
      remark: 'string',
      repeatRefund: 'string',
      sealPrice: 'number',
      serviceFee: 'number',
      settlementFee: 'number',
      settlementGrantFee: 'number',
      settlementTime: 'string',
      settlementType: 'string',
      status: 'number',
      ticketId: 'string',
      travelerId: 'string',
      travelerJobNo: 'string',
      travelerName: 'string',
      upgradeCost: 'number',
      voucherType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementFlightResponseBodyModule extends $tea.Model {
  category?: number;
  corpId?: string;
  dataList?: BillSettementFlightResponseBodyModuleDataList[];
  periodEnd?: string;
  periodStart?: string;
  totalNum?: number;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      dataList: 'dataList',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      dataList: { 'type': 'array', 'itemType': BillSettementFlightResponseBodyModuleDataList },
      periodEnd: 'string',
      periodStart: 'string',
      totalNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementHotelResponseBodyModuleDataList extends $tea.Model {
  alipayTradeNo?: string;
  applyId?: string;
  billRecordTime?: string;
  bookTime?: string;
  bookerId?: string;
  bookerJobNo?: string;
  bookerName?: string;
  capitalDirection?: string;
  cascadeDepartment?: string;
  checkInDate?: string;
  checkoutDate?: string;
  city?: string;
  cityCode?: string;
  corpRefundFee?: number;
  corpTotalFee?: number;
  costCenter?: string;
  costCenterNumber?: string;
  department?: string;
  departmentId?: string;
  feeType?: string;
  fees?: number;
  fuPointFee?: number;
  hotelName?: string;
  index?: string;
  invoiceTitle?: string;
  isNegotiation?: boolean;
  isShareStr?: string;
  nights?: number;
  orderId?: string;
  orderPrice?: number;
  orderType?: string;
  overApplyId?: string;
  personRefundFee?: number;
  personSettlePrice?: number;
  primaryId?: number;
  projectCode?: string;
  projectName?: string;
  promotionFee?: number;
  remark?: string;
  roomNumber?: number;
  roomPrice?: number;
  roomType?: string;
  serviceFee?: number;
  settlementFee?: number;
  settlementGrantFee?: number;
  settlementTime?: string;
  settlementType?: string;
  status?: number;
  totalNights?: number;
  travelerId?: string;
  travelerJobNo?: string;
  travelerName?: string;
  voucherType?: number;
  static names(): { [key: string]: string } {
    return {
      alipayTradeNo: 'alipayTradeNo',
      applyId: 'applyId',
      billRecordTime: 'billRecordTime',
      bookTime: 'bookTime',
      bookerId: 'bookerId',
      bookerJobNo: 'bookerJobNo',
      bookerName: 'bookerName',
      capitalDirection: 'capitalDirection',
      cascadeDepartment: 'cascadeDepartment',
      checkInDate: 'checkInDate',
      checkoutDate: 'checkoutDate',
      city: 'city',
      cityCode: 'cityCode',
      corpRefundFee: 'corpRefundFee',
      corpTotalFee: 'corpTotalFee',
      costCenter: 'costCenter',
      costCenterNumber: 'costCenterNumber',
      department: 'department',
      departmentId: 'departmentId',
      feeType: 'feeType',
      fees: 'fees',
      fuPointFee: 'fuPointFee',
      hotelName: 'hotelName',
      index: 'index',
      invoiceTitle: 'invoiceTitle',
      isNegotiation: 'isNegotiation',
      isShareStr: 'isShareStr',
      nights: 'nights',
      orderId: 'orderId',
      orderPrice: 'orderPrice',
      orderType: 'orderType',
      overApplyId: 'overApplyId',
      personRefundFee: 'personRefundFee',
      personSettlePrice: 'personSettlePrice',
      primaryId: 'primaryId',
      projectCode: 'projectCode',
      projectName: 'projectName',
      promotionFee: 'promotionFee',
      remark: 'remark',
      roomNumber: 'roomNumber',
      roomPrice: 'roomPrice',
      roomType: 'roomType',
      serviceFee: 'serviceFee',
      settlementFee: 'settlementFee',
      settlementGrantFee: 'settlementGrantFee',
      settlementTime: 'settlementTime',
      settlementType: 'settlementType',
      status: 'status',
      totalNights: 'totalNights',
      travelerId: 'travelerId',
      travelerJobNo: 'travelerJobNo',
      travelerName: 'travelerName',
      voucherType: 'voucherType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayTradeNo: 'string',
      applyId: 'string',
      billRecordTime: 'string',
      bookTime: 'string',
      bookerId: 'string',
      bookerJobNo: 'string',
      bookerName: 'string',
      capitalDirection: 'string',
      cascadeDepartment: 'string',
      checkInDate: 'string',
      checkoutDate: 'string',
      city: 'string',
      cityCode: 'string',
      corpRefundFee: 'number',
      corpTotalFee: 'number',
      costCenter: 'string',
      costCenterNumber: 'string',
      department: 'string',
      departmentId: 'string',
      feeType: 'string',
      fees: 'number',
      fuPointFee: 'number',
      hotelName: 'string',
      index: 'string',
      invoiceTitle: 'string',
      isNegotiation: 'boolean',
      isShareStr: 'string',
      nights: 'number',
      orderId: 'string',
      orderPrice: 'number',
      orderType: 'string',
      overApplyId: 'string',
      personRefundFee: 'number',
      personSettlePrice: 'number',
      primaryId: 'number',
      projectCode: 'string',
      projectName: 'string',
      promotionFee: 'number',
      remark: 'string',
      roomNumber: 'number',
      roomPrice: 'number',
      roomType: 'string',
      serviceFee: 'number',
      settlementFee: 'number',
      settlementGrantFee: 'number',
      settlementTime: 'string',
      settlementType: 'string',
      status: 'number',
      totalNights: 'number',
      travelerId: 'string',
      travelerJobNo: 'string',
      travelerName: 'string',
      voucherType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BillSettementHotelResponseBodyModule extends $tea.Model {
  category?: number;
  corpId?: string;
  dataList?: BillSettementHotelResponseBodyModuleDataList[];
  periodEnd?: string;
  periodStart?: string;
  totalNum?: number;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      corpId: 'corpId',
      dataList: 'dataList',
      periodEnd: 'periodEnd',
      periodStart: 'periodStart',
      totalNum: 'totalNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'number',
      corpId: 'string',
      dataList: { 'type': 'array', 'itemType': BillSettementHotelResponseBodyModuleDataList },
      periodEnd: 'string',
      periodStart: 'string',
      totalNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO extends $tea.Model {
  arrCity?: string;
  arrCityName?: string;
  arrTime?: string;
  cabin?: string;
  cabinClass?: number;
  cabinClassStr?: string;
  depCity?: string;
  depCityName?: string;
  depTime?: string;
  discount?: number;
  flightNo?: string;
  price?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      arrCity: 'arrCity',
      arrCityName: 'arrCityName',
      arrTime: 'arrTime',
      cabin: 'cabin',
      cabinClass: 'cabinClass',
      cabinClassStr: 'cabinClassStr',
      depCity: 'depCity',
      depCityName: 'depCityName',
      depTime: 'depTime',
      discount: 'discount',
      flightNo: 'flightNo',
      price: 'price',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrCity: 'string',
      arrCityName: 'string',
      arrTime: 'string',
      cabin: 'string',
      cabinClass: 'number',
      cabinClassStr: 'string',
      depCity: 'string',
      depCityName: 'string',
      depTime: 'string',
      discount: 'number',
      flightNo: 'string',
      price: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO extends $tea.Model {
  checkIn?: string;
  checkOut?: string;
  cityCode?: string;
  cityName?: string;
  price?: number;
  together?: boolean;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      checkIn: 'checkIn',
      checkOut: 'checkOut',
      cityCode: 'cityCode',
      cityName: 'cityName',
      price: 'price',
      together: 'together',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkIn: 'string',
      checkOut: 'string',
      cityCode: 'string',
      cityName: 'string',
      price: 'number',
      together: 'boolean',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrainExceedApplyResponseBodyApplyIntentionInfoDO extends $tea.Model {
  arrCity?: string;
  arrCityName?: string;
  arrStation?: string;
  arrTime?: string;
  depCity?: string;
  depCityName?: string;
  depStation?: string;
  depTime?: string;
  price?: number;
  seatName?: string;
  trainNo?: string;
  trainTypeDesc?: string;
  static names(): { [key: string]: string } {
    return {
      arrCity: 'arrCity',
      arrCityName: 'arrCityName',
      arrStation: 'arrStation',
      arrTime: 'arrTime',
      depCity: 'depCity',
      depCityName: 'depCityName',
      depStation: 'depStation',
      depTime: 'depTime',
      price: 'price',
      seatName: 'seatName',
      trainNo: 'trainNo',
      trainTypeDesc: 'trainTypeDesc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrCity: 'string',
      arrCityName: 'string',
      arrStation: 'string',
      arrTime: 'string',
      depCity: 'string',
      depCityName: 'string',
      depStation: 'string',
      depTime: 'string',
      price: 'number',
      seatName: 'string',
      trainNo: 'string',
      trainTypeDesc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBodyApplyListApproverList extends $tea.Model {
  note?: string;
  operateTime?: string;
  order?: number;
  status?: number;
  statusDesc?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      note: 'note',
      operateTime: 'operateTime',
      order: 'order',
      status: 'status',
      statusDesc: 'statusDesc',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      note: 'string',
      operateTime: 'string',
      order: 'number',
      status: 'number',
      statusDesc: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBodyApplyListItineraryList extends $tea.Model {
  arrCity?: string;
  arrCityCode?: string;
  arrDate?: string;
  costCenterId?: number;
  costCenterName?: string;
  depCity?: string;
  depCityCode?: string;
  depDate?: string;
  invoiceId?: number;
  invoiceName?: string;
  itineraryId?: string;
  projectCode?: string;
  projectTitle?: string;
  trafficType?: number;
  static names(): { [key: string]: string } {
    return {
      arrCity: 'arrCity',
      arrCityCode: 'arrCityCode',
      arrDate: 'arrDate',
      costCenterId: 'costCenterId',
      costCenterName: 'costCenterName',
      depCity: 'depCity',
      depCityCode: 'depCityCode',
      depDate: 'depDate',
      invoiceId: 'invoiceId',
      invoiceName: 'invoiceName',
      itineraryId: 'itineraryId',
      projectCode: 'projectCode',
      projectTitle: 'projectTitle',
      trafficType: 'trafficType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arrCity: 'string',
      arrCityCode: 'string',
      arrDate: 'string',
      costCenterId: 'number',
      costCenterName: 'string',
      depCity: 'string',
      depCityCode: 'string',
      depDate: 'string',
      invoiceId: 'number',
      invoiceName: 'string',
      itineraryId: 'string',
      projectCode: 'string',
      projectTitle: 'string',
      trafficType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCityCarApplyResponseBodyApplyList extends $tea.Model {
  approverList?: QueryCityCarApplyResponseBodyApplyListApproverList[];
  departId?: string;
  departName?: string;
  gmtCreate?: string;
  gmtModified?: string;
  itineraryList?: QueryCityCarApplyResponseBodyApplyListItineraryList[];
  status?: number;
  statusDesc?: string;
  thirdPartApplyId?: string;
  tripCause?: string;
  tripTitle?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      approverList: 'approverList',
      departId: 'departId',
      departName: 'departName',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      itineraryList: 'itineraryList',
      status: 'status',
      statusDesc: 'statusDesc',
      thirdPartApplyId: 'thirdPartApplyId',
      tripCause: 'tripCause',
      tripTitle: 'tripTitle',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approverList: { 'type': 'array', 'itemType': QueryCityCarApplyResponseBodyApplyListApproverList },
      departId: 'string',
      departName: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      itineraryList: { 'type': 'array', 'itemType': QueryCityCarApplyResponseBodyApplyListItineraryList },
      status: 'number',
      statusDesc: 'string',
      thirdPartApplyId: 'string',
      tripCause: 'string',
      tripTitle: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyFlightList extends $tea.Model {
  flightOrderId?: number;
  flightOrderStatus?: number;
  static names(): { [key: string]: string } {
    return {
      flightOrderId: 'flightOrderId',
      flightOrderStatus: 'flightOrderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flightOrderId: 'number',
      flightOrderStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyHotelList extends $tea.Model {
  hotelOrderId?: number;
  hotelOrderStatus?: number;
  static names(): { [key: string]: string } {
    return {
      hotelOrderId: 'hotelOrderId',
      hotelOrderStatus: 'hotelOrderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hotelOrderId: 'number',
      hotelOrderStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyTrainList extends $tea.Model {
  trainOrderId?: number;
  trainOrderstatus?: number;
  static names(): { [key: string]: string } {
    return {
      trainOrderId: 'trainOrderId',
      trainOrderstatus: 'trainOrderstatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      trainOrderId: 'number',
      trainOrderstatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnionOrderResponseBodyVehicleList extends $tea.Model {
  vehicleOrderId?: number;
  vehicleOrderStatus?: number;
  static names(): { [key: string]: string } {
    return {
      vehicleOrderId: 'vehicleOrderId',
      vehicleOrderStatus: 'vehicleOrderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      vehicleOrderId: 'number',
      vehicleOrderStatus: 'number',
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


  async addCityCarApplyWithOptions(request: AddCityCarApplyRequest, headers: AddCityCarApplyHeaders, runtime: $Util.RuntimeOptions): Promise<AddCityCarApplyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cause)) {
      body["cause"] = request.cause;
    }

    if (!Util.isUnset(request.city)) {
      body["city"] = request.city;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.date)) {
      body["date"] = request.date;
    }

    if (!Util.isUnset(request.finishedDate)) {
      body["finishedDate"] = request.finishedDate;
    }

    if (!Util.isUnset(request.projectCode)) {
      body["projectCode"] = request.projectCode;
    }

    if (!Util.isUnset(request.projectName)) {
      body["projectName"] = request.projectName;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      body["thirdPartApplyId"] = request.thirdPartApplyId;
    }

    if (!Util.isUnset(request.thirdPartCostCenterId)) {
      body["thirdPartCostCenterId"] = request.thirdPartCostCenterId;
    }

    if (!Util.isUnset(request.thirdPartInvoiceId)) {
      body["thirdPartInvoiceId"] = request.thirdPartInvoiceId;
    }

    if (!Util.isUnset(request.timesTotal)) {
      body["timesTotal"] = request.timesTotal;
    }

    if (!Util.isUnset(request.timesType)) {
      body["timesType"] = request.timesType;
    }

    if (!Util.isUnset(request.timesUsed)) {
      body["timesUsed"] = request.timesUsed;
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
      action: "AddCityCarApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/cityCarApprovals`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddCityCarApplyResponse>(await this.execute(params, req, runtime), new AddCityCarApplyResponse({}));
  }

  async addCityCarApply(request: AddCityCarApplyRequest): Promise<AddCityCarApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCityCarApplyHeaders({ });
    return await this.addCityCarApplyWithOptions(request, headers, runtime);
  }

  async approveCityCarApplyWithOptions(request: ApproveCityCarApplyRequest, headers: ApproveCityCarApplyHeaders, runtime: $Util.RuntimeOptions): Promise<ApproveCityCarApplyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.operateTime)) {
      body["operateTime"] = request.operateTime;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      body["thirdPartApplyId"] = request.thirdPartApplyId;
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
      action: "ApproveCityCarApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/cityCarApprovals`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ApproveCityCarApplyResponse>(await this.execute(params, req, runtime), new ApproveCityCarApplyResponse({}));
  }

  async approveCityCarApply(request: ApproveCityCarApplyRequest): Promise<ApproveCityCarApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApproveCityCarApplyHeaders({ });
    return await this.approveCityCarApplyWithOptions(request, headers, runtime);
  }

  async billSettementBtripTrainWithOptions(request: BillSettementBtripTrainRequest, headers: BillSettementBtripTrainHeaders, runtime: $Util.RuntimeOptions): Promise<BillSettementBtripTrainResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      query["category"] = request.category;
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

    if (!Util.isUnset(request.periodEnd)) {
      query["periodEnd"] = request.periodEnd;
    }

    if (!Util.isUnset(request.periodStart)) {
      query["periodStart"] = request.periodStart;
    }

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
      action: "BillSettementBtripTrain",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/billSettlements/btripTrains`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BillSettementBtripTrainResponse>(await this.execute(params, req, runtime), new BillSettementBtripTrainResponse({}));
  }

  async billSettementBtripTrain(request: BillSettementBtripTrainRequest): Promise<BillSettementBtripTrainResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BillSettementBtripTrainHeaders({ });
    return await this.billSettementBtripTrainWithOptions(request, headers, runtime);
  }

  async billSettementCarWithOptions(request: BillSettementCarRequest, headers: BillSettementCarHeaders, runtime: $Util.RuntimeOptions): Promise<BillSettementCarResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      query["category"] = request.category;
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

    if (!Util.isUnset(request.periodEnd)) {
      query["periodEnd"] = request.periodEnd;
    }

    if (!Util.isUnset(request.periodStart)) {
      query["periodStart"] = request.periodStart;
    }

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
      action: "BillSettementCar",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/billSettlements/cars`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BillSettementCarResponse>(await this.execute(params, req, runtime), new BillSettementCarResponse({}));
  }

  async billSettementCar(request: BillSettementCarRequest): Promise<BillSettementCarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BillSettementCarHeaders({ });
    return await this.billSettementCarWithOptions(request, headers, runtime);
  }

  async billSettementFlightWithOptions(request: BillSettementFlightRequest, headers: BillSettementFlightHeaders, runtime: $Util.RuntimeOptions): Promise<BillSettementFlightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      query["category"] = request.category;
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

    if (!Util.isUnset(request.periodEnd)) {
      query["periodEnd"] = request.periodEnd;
    }

    if (!Util.isUnset(request.periodStart)) {
      query["periodStart"] = request.periodStart;
    }

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
      action: "BillSettementFlight",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/billSettlements/flights`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BillSettementFlightResponse>(await this.execute(params, req, runtime), new BillSettementFlightResponse({}));
  }

  async billSettementFlight(request: BillSettementFlightRequest): Promise<BillSettementFlightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BillSettementFlightHeaders({ });
    return await this.billSettementFlightWithOptions(request, headers, runtime);
  }

  async billSettementHotelWithOptions(request: BillSettementHotelRequest, headers: BillSettementHotelHeaders, runtime: $Util.RuntimeOptions): Promise<BillSettementHotelResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      query["category"] = request.category;
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

    if (!Util.isUnset(request.periodEnd)) {
      query["periodEnd"] = request.periodEnd;
    }

    if (!Util.isUnset(request.periodStart)) {
      query["periodStart"] = request.periodStart;
    }

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
      action: "BillSettementHotel",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/billSettlements/hotels`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BillSettementHotelResponse>(await this.execute(params, req, runtime), new BillSettementHotelResponse({}));
  }

  async billSettementHotel(request: BillSettementHotelRequest): Promise<BillSettementHotelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BillSettementHotelHeaders({ });
    return await this.billSettementHotelWithOptions(request, headers, runtime);
  }

  async getFlightExceedApplyWithOptions(request: GetFlightExceedApplyRequest, headers: GetFlightExceedApplyHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlightExceedApplyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.applyId)) {
      query["applyId"] = request.applyId;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

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
      action: "GetFlightExceedApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/exceedapply/getFlight`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFlightExceedApplyResponse>(await this.execute(params, req, runtime), new GetFlightExceedApplyResponse({}));
  }

  async getFlightExceedApply(request: GetFlightExceedApplyRequest): Promise<GetFlightExceedApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlightExceedApplyHeaders({ });
    return await this.getFlightExceedApplyWithOptions(request, headers, runtime);
  }

  async getHotelExceedApplyWithOptions(request: GetHotelExceedApplyRequest, headers: GetHotelExceedApplyHeaders, runtime: $Util.RuntimeOptions): Promise<GetHotelExceedApplyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.applyId)) {
      query["applyId"] = request.applyId;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

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
      action: "GetHotelExceedApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/exceedapply/getHotel`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetHotelExceedApplyResponse>(await this.execute(params, req, runtime), new GetHotelExceedApplyResponse({}));
  }

  async getHotelExceedApply(request: GetHotelExceedApplyRequest): Promise<GetHotelExceedApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHotelExceedApplyHeaders({ });
    return await this.getHotelExceedApplyWithOptions(request, headers, runtime);
  }

  async getTrainExceedApplyWithOptions(request: GetTrainExceedApplyRequest, headers: GetTrainExceedApplyHeaders, runtime: $Util.RuntimeOptions): Promise<GetTrainExceedApplyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.applyId)) {
      query["applyId"] = request.applyId;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

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
      action: "GetTrainExceedApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/exceedapply/getTrain`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetTrainExceedApplyResponse>(await this.execute(params, req, runtime), new GetTrainExceedApplyResponse({}));
  }

  async getTrainExceedApply(request: GetTrainExceedApplyRequest): Promise<GetTrainExceedApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTrainExceedApplyHeaders({ });
    return await this.getTrainExceedApplyWithOptions(request, headers, runtime);
  }

  async queryCityCarApplyWithOptions(request: QueryCityCarApplyRequest, headers: QueryCityCarApplyHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCityCarApplyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createdEndAt)) {
      query["createdEndAt"] = request.createdEndAt;
    }

    if (!Util.isUnset(request.createdStartAt)) {
      query["createdStartAt"] = request.createdStartAt;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      query["thirdPartApplyId"] = request.thirdPartApplyId;
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
      action: "QueryCityCarApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/cityCarApprovals`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCityCarApplyResponse>(await this.execute(params, req, runtime), new QueryCityCarApplyResponse({}));
  }

  async queryCityCarApply(request: QueryCityCarApplyRequest): Promise<QueryCityCarApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCityCarApplyHeaders({ });
    return await this.queryCityCarApplyWithOptions(request, headers, runtime);
  }

  async queryUnionOrderWithOptions(request: QueryUnionOrderRequest, headers: QueryUnionOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUnionOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.thirdPartApplyId)) {
      query["thirdPartApplyId"] = request.thirdPartApplyId;
    }

    if (!Util.isUnset(request.unionNo)) {
      query["unionNo"] = request.unionNo;
    }

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
      action: "QueryUnionOrder",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/unionOrders`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryUnionOrderResponse>(await this.execute(params, req, runtime), new QueryUnionOrderResponse({}));
  }

  async queryUnionOrder(request: QueryUnionOrderRequest): Promise<QueryUnionOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUnionOrderHeaders({ });
    return await this.queryUnionOrderWithOptions(request, headers, runtime);
  }

  async syncExceedApplyWithOptions(request: SyncExceedApplyRequest, headers: SyncExceedApplyHeaders, runtime: $Util.RuntimeOptions): Promise<SyncExceedApplyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.applyId)) {
      query["applyId"] = request.applyId;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.remark)) {
      query["remark"] = request.remark;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
    }

    if (!Util.isUnset(request.thirdpartyFlowId)) {
      query["thirdpartyFlowId"] = request.thirdpartyFlowId;
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
      action: "SyncExceedApply",
      version: "alitrip_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/alitrip/exceedapply/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SyncExceedApplyResponse>(await this.execute(params, req, runtime), new SyncExceedApplyResponse({}));
  }

  async syncExceedApply(request: SyncExceedApplyRequest): Promise<SyncExceedApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncExceedApplyHeaders({ });
    return await this.syncExceedApplyWithOptions(request, headers, runtime);
  }

}
