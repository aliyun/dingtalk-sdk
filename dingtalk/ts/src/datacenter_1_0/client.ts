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

export class GetAbnormalOperationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAbnormalOperationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAbnormalOperationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAdministrativeLicensingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAdministrativeLicensingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAdministrativePenaltiesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAdministrativePenaltiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetBasicInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetBasicInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetBiddingInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetBiddingInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetBranchInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetBranchInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetChangeRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetChangeRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDomainInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetDomainInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDoubleRandomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetDoubleRandomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetEnvironmentalPenaltiesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetEnvironmentalPenaltiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetHolderInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetHolderInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetIntellectualPropertyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetIntellectualPropertyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetInvestmentAbroadResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetInvestmentAbroadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetJobInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetJobInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPatentInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPatentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPrincipalEmployeeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetPrincipalEmployeeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetQeneralTaxpayerInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetQeneralTaxpayerInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetQualificationCertResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetQualificationCertResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSeriousViolationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSeriousViolationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSoftwareCopyrightResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSoftwareCopyrightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTrademarkInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetTrademarkInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetWorkCopyrightResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetWorkCopyrightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostCorpAuthInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostCorpAuthInfoResponseBody extends $tea.Model {
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

export class PostCorpAuthInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PostCorpAuthInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PostCorpAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryActiveUserStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryActiveUserStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryActiveUserStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryActiveUserStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryAnhmdStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryAnhmdStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryAnhmdStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryAnhmdStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryApprovalStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryApprovalStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryApprovalStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryApprovalStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryAttendanceStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryAttendanceStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryAttendanceStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryAttendanceStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryBlackboardStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryBlackboardStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryBlackboardStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryBlackboardStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryCalendarStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryCalendarStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCalendarStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCalendarStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryCheckinStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryCheckinStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCheckinStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCheckinStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryCircleStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryCircleStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCircleStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCircleStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoRequest extends $tea.Model {
  keyword?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoResponseBody extends $tea.Model {
  code?: string;
  data?: { [key: string]: string }[];
  message?: string;
  requestId?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      requestId: 'requestId',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
      message: 'string',
      requestId: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCompanyBasicInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCompanyBasicInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoRequest extends $tea.Model {
  corpIds?: string[];
  statDates?: string[];
  static names(): { [key: string]: string } {
    return {
      corpIds: 'corpIds',
      statDates: 'statDates',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIds: { 'type': 'array', 'itemType': 'string' },
      statDates: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoResponseBody extends $tea.Model {
  arguments?: string[];
  result?: string;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'string' },
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDigitalDistrictOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDigitalDistrictOrgInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDingReciveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDingReciveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDingReciveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDingReciveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDingSendStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDingSendStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDingSendStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDingSendStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDocumentStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDocumentStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDocumentStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDocumentStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDriveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDriveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDriveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryDriveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryEmployeeTypeStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryEmployeeTypeStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryEmployeeTypeStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryEmployeeTypeStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceRequest extends $tea.Model {
  deptId?: string;
  endDate?: string;
  pageNumber?: number;
  pageSize?: number;
  serviceId?: string;
  startDate?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      endDate: 'endDate',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      serviceId: 'serviceId',
      startDate: 'startDate',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      endDate: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      serviceId: 'string',
      startDate: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGeneralDataServiceResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGeneralDataServiceResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryGeneralDataServiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryGeneralDataServiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGroupLiveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGroupLiveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryGroupLiveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryGroupLiveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGroupMessageStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGroupMessageStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryGroupMessageStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryGroupMessageStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryHealthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryHealthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryHealthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryHealthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryMailStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryMailStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryMailStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryMailStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDataRequest extends $tea.Model {
  param?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDataResponseBody extends $tea.Model {
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

export class QueryOfficialDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOfficialDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOfficialDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsRequest extends $tea.Model {
  dsId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dsId: 'dsId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dsId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponseBody extends $tea.Model {
  result?: QueryOfficialDatasetFieldsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOfficialDatasetFieldsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOfficialDatasetFieldsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOfficialDatasetFieldsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListRequest extends $tea.Model {
  keyword?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponseBody extends $tea.Model {
  result?: QueryOfficialDatasetListResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOfficialDatasetListResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOfficialDatasetListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOfficialDatasetListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataRequest extends $tea.Model {
  param?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataResponseBody extends $tea.Model {
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

export class QueryOfficialFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOfficialFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOfficialFormDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryOnlineUserStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryOnlineUserStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOnlineUserStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOnlineUserStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryRedEnvelopeReciveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryRedEnvelopeReciveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryRedEnvelopeSendStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryRedEnvelopeSendStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryReportStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryReportStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryReportStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryReportStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QuerySingleMessageStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QuerySingleMessageStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QuerySingleMessageStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySingleMessageStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryTelMeetingStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryTelMeetingStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryTelMeetingStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryTelMeetingStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryTodoStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryTodoStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryTodoStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryTodoStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryVedioMeetingStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryVedioMeetingStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryVedioMeetingStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryVedioMeetingStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydActiveDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydActiveDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydActiveDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydActiveDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydActiveMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydActiveMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydActiveMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydActiveMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydActiveWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydActiveWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydActiveWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydActiveWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydAppDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydAppDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydAppMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydAppMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppStdStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppStdStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydAppStdStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydAppStdStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydAppWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydAppWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydCalendarDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydCalendarDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydCalendarDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydCalendarDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydCalendarMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydCalendarMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydCalendarMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydCalendarMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydCalendarWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydCalendarWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydCalendarWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydCalendarWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydDingMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydDingMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydDingMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydDingMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydDingMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydDingMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydDingMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydDingMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydGroupMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydGroupMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydGroupMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydGroupMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydGroupMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydGroupMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydLogDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydLogDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydLogDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydLogDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydLogMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydLogMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydLogMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydLogMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydLogWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydLogWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydLogWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydLogWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydMeetingDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydMeetingDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydMeetingDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydMeetingDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydMeetingMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydMeetingMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydMeetingMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydMeetingMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydMeetingWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydMeetingWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydMeetingWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydMeetingWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydNoticeDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydNoticeDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydNoticeDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydNoticeDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydNoticeMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydNoticeMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydNoticeMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydNoticeMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydNoticeWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydNoticeWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydNoticeWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydNoticeWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydSingleMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydSingleMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydSingleMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydSingleMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydSingleMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydSingleMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydToatlMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydToatlMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydToatlMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydToatlMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydToatlMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydToatlMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTodoDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTodoDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTodoDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTodoDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTodoMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTodoMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTodoMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTodoMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTodoWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTodoWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTodoWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTodoWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTotalDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTotalDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTotalMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTotalMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalStdStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalStdStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTotalStdStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTotalStdStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataRequest extends $tea.Model {
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryYydTotalWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryYydTotalWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyResponseBody extends $tea.Model {
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchCompanyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SearchCompanyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceResponseBodyMetaList extends $tea.Model {
  fieldDesc?: string;
  fieldId?: string;
  fieldName?: string;
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldDesc: 'fieldDesc',
      fieldId: 'fieldId',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldDesc: 'string',
      fieldId: 'string',
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponseBodyResultFields extends $tea.Model {
  displayName?: string;
  fieldId?: string;
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      fieldId: 'fieldId',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      fieldId: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponseBodyResult extends $tea.Model {
  displayName?: string;
  dsId?: string;
  fields?: QueryOfficialDatasetFieldsResponseBodyResultFields[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      dsId: 'dsId',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      dsId: 'string',
      fields: { 'type': 'array', 'itemType': QueryOfficialDatasetFieldsResponseBodyResultFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponseBodyResultRows extends $tea.Model {
  displayName?: string;
  dsId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      dsId: 'dsId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      dsId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponseBodyResult extends $tea.Model {
  rows?: QueryOfficialDatasetListResponseBodyResultRows[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      rows: 'rows',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rows: { 'type': 'array', 'itemType': QueryOfficialDatasetListResponseBodyResultRows },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiCaliber?: string;
  kpiId?: string;
  kpiName?: string;
  period?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
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


  async getAbnormalOperationWithOptions(request: GetAbnormalOperationRequest, headers: GetAbnormalOperationHeaders, runtime: $Util.RuntimeOptions): Promise<GetAbnormalOperationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetAbnormalOperation",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/abnormalOperations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAbnormalOperationResponse>(await this.execute(params, req, runtime), new GetAbnormalOperationResponse({}));
  }

  async getAbnormalOperation(request: GetAbnormalOperationRequest): Promise<GetAbnormalOperationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAbnormalOperationHeaders({ });
    return await this.getAbnormalOperationWithOptions(request, headers, runtime);
  }

  async getAdministrativeLicensingWithOptions(request: GetAdministrativeLicensingRequest, headers: GetAdministrativeLicensingHeaders, runtime: $Util.RuntimeOptions): Promise<GetAdministrativeLicensingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetAdministrativeLicensing",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/administrativeLicenses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAdministrativeLicensingResponse>(await this.execute(params, req, runtime), new GetAdministrativeLicensingResponse({}));
  }

  async getAdministrativeLicensing(request: GetAdministrativeLicensingRequest): Promise<GetAdministrativeLicensingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdministrativeLicensingHeaders({ });
    return await this.getAdministrativeLicensingWithOptions(request, headers, runtime);
  }

  async getAdministrativePenaltiesWithOptions(request: GetAdministrativePenaltiesRequest, headers: GetAdministrativePenaltiesHeaders, runtime: $Util.RuntimeOptions): Promise<GetAdministrativePenaltiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetAdministrativePenalties",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/administrativePenalties`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAdministrativePenaltiesResponse>(await this.execute(params, req, runtime), new GetAdministrativePenaltiesResponse({}));
  }

  async getAdministrativePenalties(request: GetAdministrativePenaltiesRequest): Promise<GetAdministrativePenaltiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdministrativePenaltiesHeaders({ });
    return await this.getAdministrativePenaltiesWithOptions(request, headers, runtime);
  }

  async getBasicInfoWithOptions(request: GetBasicInfoRequest, headers: GetBasicInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBasicInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetBasicInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/businessBasicInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBasicInfoResponse>(await this.execute(params, req, runtime), new GetBasicInfoResponse({}));
  }

  async getBasicInfo(request: GetBasicInfoRequest): Promise<GetBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBasicInfoHeaders({ });
    return await this.getBasicInfoWithOptions(request, headers, runtime);
  }

  async getBiddingInfoWithOptions(request: GetBiddingInfoRequest, headers: GetBiddingInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBiddingInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetBiddingInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/biddingInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBiddingInfoResponse>(await this.execute(params, req, runtime), new GetBiddingInfoResponse({}));
  }

  async getBiddingInfo(request: GetBiddingInfoRequest): Promise<GetBiddingInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBiddingInfoHeaders({ });
    return await this.getBiddingInfoWithOptions(request, headers, runtime);
  }

  async getBranchInfoWithOptions(request: GetBranchInfoRequest, headers: GetBranchInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBranchInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetBranchInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/branchInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBranchInfoResponse>(await this.execute(params, req, runtime), new GetBranchInfoResponse({}));
  }

  async getBranchInfo(request: GetBranchInfoRequest): Promise<GetBranchInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBranchInfoHeaders({ });
    return await this.getBranchInfoWithOptions(request, headers, runtime);
  }

  async getChangeRecordWithOptions(request: GetChangeRecordRequest, headers: GetChangeRecordHeaders, runtime: $Util.RuntimeOptions): Promise<GetChangeRecordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetChangeRecord",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/changeRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetChangeRecordResponse>(await this.execute(params, req, runtime), new GetChangeRecordResponse({}));
  }

  async getChangeRecord(request: GetChangeRecordRequest): Promise<GetChangeRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetChangeRecordHeaders({ });
    return await this.getChangeRecordWithOptions(request, headers, runtime);
  }

  async getDomainInfoWithOptions(request: GetDomainInfoRequest, headers: GetDomainInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDomainInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetDomainInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/domainInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDomainInfoResponse>(await this.execute(params, req, runtime), new GetDomainInfoResponse({}));
  }

  async getDomainInfo(request: GetDomainInfoRequest): Promise<GetDomainInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDomainInfoHeaders({ });
    return await this.getDomainInfoWithOptions(request, headers, runtime);
  }

  async getDoubleRandomWithOptions(request: GetDoubleRandomRequest, headers: GetDoubleRandomHeaders, runtime: $Util.RuntimeOptions): Promise<GetDoubleRandomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetDoubleRandom",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/doubleRandomness`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDoubleRandomResponse>(await this.execute(params, req, runtime), new GetDoubleRandomResponse({}));
  }

  async getDoubleRandom(request: GetDoubleRandomRequest): Promise<GetDoubleRandomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDoubleRandomHeaders({ });
    return await this.getDoubleRandomWithOptions(request, headers, runtime);
  }

  async getEnvironmentalPenaltiesWithOptions(request: GetEnvironmentalPenaltiesRequest, headers: GetEnvironmentalPenaltiesHeaders, runtime: $Util.RuntimeOptions): Promise<GetEnvironmentalPenaltiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetEnvironmentalPenalties",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/environmentalPenalties`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEnvironmentalPenaltiesResponse>(await this.execute(params, req, runtime), new GetEnvironmentalPenaltiesResponse({}));
  }

  async getEnvironmentalPenalties(request: GetEnvironmentalPenaltiesRequest): Promise<GetEnvironmentalPenaltiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEnvironmentalPenaltiesHeaders({ });
    return await this.getEnvironmentalPenaltiesWithOptions(request, headers, runtime);
  }

  async getHolderInfoWithOptions(request: GetHolderInfoRequest, headers: GetHolderInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetHolderInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetHolderInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/shareholderInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetHolderInfoResponse>(await this.execute(params, req, runtime), new GetHolderInfoResponse({}));
  }

  async getHolderInfo(request: GetHolderInfoRequest): Promise<GetHolderInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHolderInfoHeaders({ });
    return await this.getHolderInfoWithOptions(request, headers, runtime);
  }

  async getIntellectualPropertyWithOptions(request: GetIntellectualPropertyRequest, headers: GetIntellectualPropertyHeaders, runtime: $Util.RuntimeOptions): Promise<GetIntellectualPropertyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetIntellectualProperty",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/intellectualProperties`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetIntellectualPropertyResponse>(await this.execute(params, req, runtime), new GetIntellectualPropertyResponse({}));
  }

  async getIntellectualProperty(request: GetIntellectualPropertyRequest): Promise<GetIntellectualPropertyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIntellectualPropertyHeaders({ });
    return await this.getIntellectualPropertyWithOptions(request, headers, runtime);
  }

  async getInvestmentAbroadWithOptions(request: GetInvestmentAbroadRequest, headers: GetInvestmentAbroadHeaders, runtime: $Util.RuntimeOptions): Promise<GetInvestmentAbroadResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetInvestmentAbroad",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/abroadInvestments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInvestmentAbroadResponse>(await this.execute(params, req, runtime), new GetInvestmentAbroadResponse({}));
  }

  async getInvestmentAbroad(request: GetInvestmentAbroadRequest): Promise<GetInvestmentAbroadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInvestmentAbroadHeaders({ });
    return await this.getInvestmentAbroadWithOptions(request, headers, runtime);
  }

  async getJobInfoWithOptions(request: GetJobInfoRequest, headers: GetJobInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetJobInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/jobInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetJobInfoResponse>(await this.execute(params, req, runtime), new GetJobInfoResponse({}));
  }

  async getJobInfo(request: GetJobInfoRequest): Promise<GetJobInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobInfoHeaders({ });
    return await this.getJobInfoWithOptions(request, headers, runtime);
  }

  async getPatentInfoWithOptions(request: GetPatentInfoRequest, headers: GetPatentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPatentInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetPatentInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/patentInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPatentInfoResponse>(await this.execute(params, req, runtime), new GetPatentInfoResponse({}));
  }

  async getPatentInfo(request: GetPatentInfoRequest): Promise<GetPatentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPatentInfoHeaders({ });
    return await this.getPatentInfoWithOptions(request, headers, runtime);
  }

  async getPrincipalEmployeeWithOptions(request: GetPrincipalEmployeeRequest, headers: GetPrincipalEmployeeHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrincipalEmployeeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetPrincipalEmployee",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/principalEmployees`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPrincipalEmployeeResponse>(await this.execute(params, req, runtime), new GetPrincipalEmployeeResponse({}));
  }

  async getPrincipalEmployee(request: GetPrincipalEmployeeRequest): Promise<GetPrincipalEmployeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrincipalEmployeeHeaders({ });
    return await this.getPrincipalEmployeeWithOptions(request, headers, runtime);
  }

  async getQeneralTaxpayerInfoWithOptions(request: GetQeneralTaxpayerInfoRequest, headers: GetQeneralTaxpayerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetQeneralTaxpayerInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetQeneralTaxpayerInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/generalTaxpayerInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetQeneralTaxpayerInfoResponse>(await this.execute(params, req, runtime), new GetQeneralTaxpayerInfoResponse({}));
  }

  async getQeneralTaxpayerInfo(request: GetQeneralTaxpayerInfoRequest): Promise<GetQeneralTaxpayerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetQeneralTaxpayerInfoHeaders({ });
    return await this.getQeneralTaxpayerInfoWithOptions(request, headers, runtime);
  }

  async getQualificationCertWithOptions(request: GetQualificationCertRequest, headers: GetQualificationCertHeaders, runtime: $Util.RuntimeOptions): Promise<GetQualificationCertResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetQualificationCert",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/qualificationCerts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetQualificationCertResponse>(await this.execute(params, req, runtime), new GetQualificationCertResponse({}));
  }

  async getQualificationCert(request: GetQualificationCertRequest): Promise<GetQualificationCertResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetQualificationCertHeaders({ });
    return await this.getQualificationCertWithOptions(request, headers, runtime);
  }

  async getSeriousViolationWithOptions(request: GetSeriousViolationRequest, headers: GetSeriousViolationHeaders, runtime: $Util.RuntimeOptions): Promise<GetSeriousViolationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetSeriousViolation",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/seriousViolations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSeriousViolationResponse>(await this.execute(params, req, runtime), new GetSeriousViolationResponse({}));
  }

  async getSeriousViolation(request: GetSeriousViolationRequest): Promise<GetSeriousViolationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSeriousViolationHeaders({ });
    return await this.getSeriousViolationWithOptions(request, headers, runtime);
  }

  async getSoftwareCopyrightWithOptions(request: GetSoftwareCopyrightRequest, headers: GetSoftwareCopyrightHeaders, runtime: $Util.RuntimeOptions): Promise<GetSoftwareCopyrightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetSoftwareCopyright",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/softwareCopyrights`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSoftwareCopyrightResponse>(await this.execute(params, req, runtime), new GetSoftwareCopyrightResponse({}));
  }

  async getSoftwareCopyright(request: GetSoftwareCopyrightRequest): Promise<GetSoftwareCopyrightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSoftwareCopyrightHeaders({ });
    return await this.getSoftwareCopyrightWithOptions(request, headers, runtime);
  }

  async getTrademarkInfoWithOptions(request: GetTrademarkInfoRequest, headers: GetTrademarkInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetTrademarkInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetTrademarkInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/trademarkInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTrademarkInfoResponse>(await this.execute(params, req, runtime), new GetTrademarkInfoResponse({}));
  }

  async getTrademarkInfo(request: GetTrademarkInfoRequest): Promise<GetTrademarkInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTrademarkInfoHeaders({ });
    return await this.getTrademarkInfoWithOptions(request, headers, runtime);
  }

  async getWorkCopyrightWithOptions(request: GetWorkCopyrightRequest, headers: GetWorkCopyrightHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkCopyrightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "GetWorkCopyright",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/workCopyrights`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWorkCopyrightResponse>(await this.execute(params, req, runtime), new GetWorkCopyrightResponse({}));
  }

  async getWorkCopyright(request: GetWorkCopyrightRequest): Promise<GetWorkCopyrightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkCopyrightHeaders({ });
    return await this.getWorkCopyrightWithOptions(request, headers, runtime);
  }

  async postCorpAuthInfoWithOptions(headers: PostCorpAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<PostCorpAuthInfoResponse> {
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
      action: "PostCorpAuthInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/corporations/authorize`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PostCorpAuthInfoResponse>(await this.execute(params, req, runtime), new PostCorpAuthInfoResponse({}));
  }

  async postCorpAuthInfo(): Promise<PostCorpAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PostCorpAuthInfoHeaders({ });
    return await this.postCorpAuthInfoWithOptions(headers, runtime);
  }

  async queryActiveUserStatisticalDataWithOptions(request: QueryActiveUserStatisticalDataRequest, headers: QueryActiveUserStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryActiveUserStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryActiveUserStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/activeUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryActiveUserStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryActiveUserStatisticalDataResponse({}));
  }

  async queryActiveUserStatisticalData(request: QueryActiveUserStatisticalDataRequest): Promise<QueryActiveUserStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryActiveUserStatisticalDataHeaders({ });
    return await this.queryActiveUserStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryAnhmdStatisticalDataWithOptions(request: QueryAnhmdStatisticalDataRequest, headers: QueryAnhmdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAnhmdStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryAnhmdStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/statisticDatas/anHmd`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAnhmdStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryAnhmdStatisticalDataResponse({}));
  }

  async queryAnhmdStatisticalData(request: QueryAnhmdStatisticalDataRequest): Promise<QueryAnhmdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAnhmdStatisticalDataHeaders({ });
    return await this.queryAnhmdStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryApprovalStatisticalDataWithOptions(request: QueryApprovalStatisticalDataRequest, headers: QueryApprovalStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryApprovalStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryApprovalStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/approvalData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryApprovalStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryApprovalStatisticalDataResponse({}));
  }

  async queryApprovalStatisticalData(request: QueryApprovalStatisticalDataRequest): Promise<QueryApprovalStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryApprovalStatisticalDataHeaders({ });
    return await this.queryApprovalStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryAttendanceStatisticalDataWithOptions(request: QueryAttendanceStatisticalDataRequest, headers: QueryAttendanceStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAttendanceStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryAttendanceStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/attendanceData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryAttendanceStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryAttendanceStatisticalDataResponse({}));
  }

  async queryAttendanceStatisticalData(request: QueryAttendanceStatisticalDataRequest): Promise<QueryAttendanceStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAttendanceStatisticalDataHeaders({ });
    return await this.queryAttendanceStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryBlackboardStatisticalDataWithOptions(request: QueryBlackboardStatisticalDataRequest, headers: QueryBlackboardStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBlackboardStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryBlackboardStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/blackboardData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryBlackboardStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryBlackboardStatisticalDataResponse({}));
  }

  async queryBlackboardStatisticalData(request: QueryBlackboardStatisticalDataRequest): Promise<QueryBlackboardStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBlackboardStatisticalDataHeaders({ });
    return await this.queryBlackboardStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryCalendarStatisticalDataWithOptions(request: QueryCalendarStatisticalDataRequest, headers: QueryCalendarStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCalendarStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryCalendarStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/calendarData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCalendarStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryCalendarStatisticalDataResponse({}));
  }

  async queryCalendarStatisticalData(request: QueryCalendarStatisticalDataRequest): Promise<QueryCalendarStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCalendarStatisticalDataHeaders({ });
    return await this.queryCalendarStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryCheckinStatisticalDataWithOptions(request: QueryCheckinStatisticalDataRequest, headers: QueryCheckinStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCheckinStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryCheckinStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/checkinData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCheckinStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryCheckinStatisticalDataResponse({}));
  }

  async queryCheckinStatisticalData(request: QueryCheckinStatisticalDataRequest): Promise<QueryCheckinStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCheckinStatisticalDataHeaders({ });
    return await this.queryCheckinStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryCircleStatisticalDataWithOptions(request: QueryCircleStatisticalDataRequest, headers: QueryCircleStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCircleStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryCircleStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/circleData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCircleStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryCircleStatisticalDataResponse({}));
  }

  async queryCircleStatisticalData(request: QueryCircleStatisticalDataRequest): Promise<QueryCircleStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCircleStatisticalDataHeaders({ });
    return await this.queryCircleStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryCompanyBasicInfoWithOptions(request: QueryCompanyBasicInfoRequest, headers: QueryCompanyBasicInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCompanyBasicInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
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
      action: "QueryCompanyBasicInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/basicInfo`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCompanyBasicInfoResponse>(await this.execute(params, req, runtime), new QueryCompanyBasicInfoResponse({}));
  }

  async queryCompanyBasicInfo(request: QueryCompanyBasicInfoRequest): Promise<QueryCompanyBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCompanyBasicInfoHeaders({ });
    return await this.queryCompanyBasicInfoWithOptions(request, headers, runtime);
  }

  async queryDigitalDistrictOrgInfoWithOptions(request: QueryDigitalDistrictOrgInfoRequest, headers: QueryDigitalDistrictOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDigitalDistrictOrgInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpIds)) {
      body["corpIds"] = request.corpIds;
    }

    if (!Util.isUnset(request.statDates)) {
      body["statDates"] = request.statDates;
    }

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
      action: "QueryDigitalDistrictOrgInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/digitalCounty/orgInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDigitalDistrictOrgInfoResponse>(await this.execute(params, req, runtime), new QueryDigitalDistrictOrgInfoResponse({}));
  }

  async queryDigitalDistrictOrgInfo(request: QueryDigitalDistrictOrgInfoRequest): Promise<QueryDigitalDistrictOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDigitalDistrictOrgInfoHeaders({ });
    return await this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
  }

  async queryDingReciveStatisticalDataWithOptions(request: QueryDingReciveStatisticalDataRequest, headers: QueryDingReciveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDingReciveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryDingReciveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dingReciveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDingReciveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDingReciveStatisticalDataResponse({}));
  }

  async queryDingReciveStatisticalData(request: QueryDingReciveStatisticalDataRequest): Promise<QueryDingReciveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDingReciveStatisticalDataHeaders({ });
    return await this.queryDingReciveStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryDingSendStatisticalDataWithOptions(request: QueryDingSendStatisticalDataRequest, headers: QueryDingSendStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDingSendStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryDingSendStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dingSendData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDingSendStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDingSendStatisticalDataResponse({}));
  }

  async queryDingSendStatisticalData(request: QueryDingSendStatisticalDataRequest): Promise<QueryDingSendStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDingSendStatisticalDataHeaders({ });
    return await this.queryDingSendStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryDocumentStatisticalDataWithOptions(request: QueryDocumentStatisticalDataRequest, headers: QueryDocumentStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDocumentStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryDocumentStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/documentData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDocumentStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDocumentStatisticalDataResponse({}));
  }

  async queryDocumentStatisticalData(request: QueryDocumentStatisticalDataRequest): Promise<QueryDocumentStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDocumentStatisticalDataHeaders({ });
    return await this.queryDocumentStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryDriveStatisticalDataWithOptions(request: QueryDriveStatisticalDataRequest, headers: QueryDriveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDriveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryDriveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/driveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDriveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDriveStatisticalDataResponse({}));
  }

  async queryDriveStatisticalData(request: QueryDriveStatisticalDataRequest): Promise<QueryDriveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDriveStatisticalDataHeaders({ });
    return await this.queryDriveStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryEmployeeTypeStatisticalDataWithOptions(request: QueryEmployeeTypeStatisticalDataRequest, headers: QueryEmployeeTypeStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEmployeeTypeStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryEmployeeTypeStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/employeeTypeData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryEmployeeTypeStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryEmployeeTypeStatisticalDataResponse({}));
  }

  async queryEmployeeTypeStatisticalData(request: QueryEmployeeTypeStatisticalDataRequest): Promise<QueryEmployeeTypeStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEmployeeTypeStatisticalDataHeaders({ });
    return await this.queryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryGeneralDataServiceWithOptions(request: QueryGeneralDataServiceRequest, headers: QueryGeneralDataServiceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGeneralDataServiceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.endDate)) {
      query["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.serviceId)) {
      query["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.startDate)) {
      query["startDate"] = request.startDate;
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
      action: "QueryGeneralDataService",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/generalDataServices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGeneralDataServiceResponse>(await this.execute(params, req, runtime), new QueryGeneralDataServiceResponse({}));
  }

  async queryGeneralDataService(request: QueryGeneralDataServiceRequest): Promise<QueryGeneralDataServiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGeneralDataServiceHeaders({ });
    return await this.queryGeneralDataServiceWithOptions(request, headers, runtime);
  }

  async queryGroupLiveStatisticalDataWithOptions(request: QueryGroupLiveStatisticalDataRequest, headers: QueryGroupLiveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupLiveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryGroupLiveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/groupLiveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupLiveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryGroupLiveStatisticalDataResponse({}));
  }

  async queryGroupLiveStatisticalData(request: QueryGroupLiveStatisticalDataRequest): Promise<QueryGroupLiveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupLiveStatisticalDataHeaders({ });
    return await this.queryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryGroupMessageStatisticalDataWithOptions(request: QueryGroupMessageStatisticalDataRequest, headers: QueryGroupMessageStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupMessageStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryGroupMessageStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/groupMessageData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupMessageStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryGroupMessageStatisticalDataResponse({}));
  }

  async queryGroupMessageStatisticalData(request: QueryGroupMessageStatisticalDataRequest): Promise<QueryGroupMessageStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMessageStatisticalDataHeaders({ });
    return await this.queryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryHealthStatisticalDataWithOptions(request: QueryHealthStatisticalDataRequest, headers: QueryHealthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHealthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryHealthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/healtheUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryHealthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryHealthStatisticalDataResponse({}));
  }

  async queryHealthStatisticalData(request: QueryHealthStatisticalDataRequest): Promise<QueryHealthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHealthStatisticalDataHeaders({ });
    return await this.queryHealthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryMailStatisticalDataWithOptions(request: QueryMailStatisticalDataRequest, headers: QueryMailStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMailStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryMailStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/mailData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryMailStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryMailStatisticalDataResponse({}));
  }

  async queryMailStatisticalData(request: QueryMailStatisticalDataRequest): Promise<QueryMailStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMailStatisticalDataHeaders({ });
    return await this.queryMailStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryOfficialDataWithOptions(request: QueryOfficialDataRequest, headers: QueryOfficialDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      query["param"] = request.param;
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
      action: "QueryOfficialData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialDataResponse>(await this.execute(params, req, runtime), new QueryOfficialDataResponse({}));
  }

  async queryOfficialData(request: QueryOfficialDataRequest): Promise<QueryOfficialDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialDataHeaders({ });
    return await this.queryOfficialDataWithOptions(request, headers, runtime);
  }

  async queryOfficialDatasetFieldsWithOptions(request: QueryOfficialDatasetFieldsRequest, headers: QueryOfficialDatasetFieldsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialDatasetFieldsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dsId)) {
      query["dsId"] = request.dsId;
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
      action: "QueryOfficialDatasetFields",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datasetFields`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialDatasetFieldsResponse>(await this.execute(params, req, runtime), new QueryOfficialDatasetFieldsResponse({}));
  }

  async queryOfficialDatasetFields(request: QueryOfficialDatasetFieldsRequest): Promise<QueryOfficialDatasetFieldsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialDatasetFieldsHeaders({ });
    return await this.queryOfficialDatasetFieldsWithOptions(request, headers, runtime);
  }

  async queryOfficialDatasetListWithOptions(request: QueryOfficialDatasetListRequest, headers: QueryOfficialDatasetListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialDatasetListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
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
      action: "QueryOfficialDatasetList",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datasetLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialDatasetListResponse>(await this.execute(params, req, runtime), new QueryOfficialDatasetListResponse({}));
  }

  async queryOfficialDatasetList(request: QueryOfficialDatasetListRequest): Promise<QueryOfficialDatasetListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialDatasetListHeaders({ });
    return await this.queryOfficialDatasetListWithOptions(request, headers, runtime);
  }

  async queryOfficialFormDataWithOptions(request: QueryOfficialFormDataRequest, headers: QueryOfficialFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "QueryOfficialFormData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialFormDataResponse>(await this.execute(params, req, runtime), new QueryOfficialFormDataResponse({}));
  }

  async queryOfficialFormData(request: QueryOfficialFormDataRequest): Promise<QueryOfficialFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialFormDataHeaders({ });
    return await this.queryOfficialFormDataWithOptions(request, headers, runtime);
  }

  async queryOnlineUserStatisticalDataWithOptions(request: QueryOnlineUserStatisticalDataRequest, headers: QueryOnlineUserStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOnlineUserStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryOnlineUserStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/onlineUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryOnlineUserStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryOnlineUserStatisticalDataResponse({}));
  }

  async queryOnlineUserStatisticalData(request: QueryOnlineUserStatisticalDataRequest): Promise<QueryOnlineUserStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOnlineUserStatisticalDataHeaders({ });
    return await this.queryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryRedEnvelopeReciveStatisticalDataWithOptions(request: QueryRedEnvelopeReciveStatisticalDataRequest, headers: QueryRedEnvelopeReciveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRedEnvelopeReciveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryRedEnvelopeReciveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/redEnvelopeReciveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryRedEnvelopeReciveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse({}));
  }

  async queryRedEnvelopeReciveStatisticalData(request: QueryRedEnvelopeReciveStatisticalDataRequest): Promise<QueryRedEnvelopeReciveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRedEnvelopeReciveStatisticalDataHeaders({ });
    return await this.queryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryRedEnvelopeSendStatisticalDataWithOptions(request: QueryRedEnvelopeSendStatisticalDataRequest, headers: QueryRedEnvelopeSendStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRedEnvelopeSendStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryRedEnvelopeSendStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/redEnvelopeSendData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryRedEnvelopeSendStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse({}));
  }

  async queryRedEnvelopeSendStatisticalData(request: QueryRedEnvelopeSendStatisticalDataRequest): Promise<QueryRedEnvelopeSendStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRedEnvelopeSendStatisticalDataHeaders({ });
    return await this.queryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryReportStatisticalDataWithOptions(request: QueryReportStatisticalDataRequest, headers: QueryReportStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReportStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryReportStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/reportData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryReportStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryReportStatisticalDataResponse({}));
  }

  async queryReportStatisticalData(request: QueryReportStatisticalDataRequest): Promise<QueryReportStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReportStatisticalDataHeaders({ });
    return await this.queryReportStatisticalDataWithOptions(request, headers, runtime);
  }

  async querySingleMessageStatisticalDataWithOptions(request: QuerySingleMessageStatisticalDataRequest, headers: QuerySingleMessageStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySingleMessageStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QuerySingleMessageStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/singleMessagerData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QuerySingleMessageStatisticalDataResponse>(await this.execute(params, req, runtime), new QuerySingleMessageStatisticalDataResponse({}));
  }

  async querySingleMessageStatisticalData(request: QuerySingleMessageStatisticalDataRequest): Promise<QuerySingleMessageStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySingleMessageStatisticalDataHeaders({ });
    return await this.querySingleMessageStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryTelMeetingStatisticalDataWithOptions(request: QueryTelMeetingStatisticalDataRequest, headers: QueryTelMeetingStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTelMeetingStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryTelMeetingStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/telMeetingData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryTelMeetingStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryTelMeetingStatisticalDataResponse({}));
  }

  async queryTelMeetingStatisticalData(request: QueryTelMeetingStatisticalDataRequest): Promise<QueryTelMeetingStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTelMeetingStatisticalDataHeaders({ });
    return await this.queryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryTodoStatisticalDataWithOptions(request: QueryTodoStatisticalDataRequest, headers: QueryTodoStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTodoStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryTodoStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/todoUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryTodoStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryTodoStatisticalDataResponse({}));
  }

  async queryTodoStatisticalData(request: QueryTodoStatisticalDataRequest): Promise<QueryTodoStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTodoStatisticalDataHeaders({ });
    return await this.queryTodoStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryVedioMeetingStatisticalDataWithOptions(request: QueryVedioMeetingStatisticalDataRequest, headers: QueryVedioMeetingStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryVedioMeetingStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryVedioMeetingStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/vedioMeetingData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryVedioMeetingStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryVedioMeetingStatisticalDataResponse({}));
  }

  async queryVedioMeetingStatisticalData(request: QueryVedioMeetingStatisticalDataRequest): Promise<QueryVedioMeetingStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryVedioMeetingStatisticalDataHeaders({ });
    return await this.queryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydActiveDayStatisticalDataWithOptions(request: QueryYydActiveDayStatisticalDataRequest, headers: QueryYydActiveDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydActiveDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydActiveDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydActiveDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydActiveDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydActiveDayStatisticalDataResponse({}));
  }

  async queryYydActiveDayStatisticalData(request: QueryYydActiveDayStatisticalDataRequest): Promise<QueryYydActiveDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveDayStatisticalDataHeaders({ });
    return await this.queryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydActiveMonthStatisticalDataWithOptions(request: QueryYydActiveMonthStatisticalDataRequest, headers: QueryYydActiveMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydActiveMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydActiveMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydActiveMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydActiveMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydActiveMonthStatisticalDataResponse({}));
  }

  async queryYydActiveMonthStatisticalData(request: QueryYydActiveMonthStatisticalDataRequest): Promise<QueryYydActiveMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveMonthStatisticalDataHeaders({ });
    return await this.queryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydActiveWeekStatisticalDataWithOptions(request: QueryYydActiveWeekStatisticalDataRequest, headers: QueryYydActiveWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydActiveWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydActiveWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydActiveWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydActiveWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydActiveWeekStatisticalDataResponse({}));
  }

  async queryYydActiveWeekStatisticalData(request: QueryYydActiveWeekStatisticalDataRequest): Promise<QueryYydActiveWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveWeekStatisticalDataHeaders({ });
    return await this.queryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydAppDayStatisticalDataWithOptions(request: QueryYydAppDayStatisticalDataRequest, headers: QueryYydAppDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydAppDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppDayStatisticalDataResponse({}));
  }

  async queryYydAppDayStatisticalData(request: QueryYydAppDayStatisticalDataRequest): Promise<QueryYydAppDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppDayStatisticalDataHeaders({ });
    return await this.queryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydAppMonthStatisticalDataWithOptions(request: QueryYydAppMonthStatisticalDataRequest, headers: QueryYydAppMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydAppMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppMonthStatisticalDataResponse({}));
  }

  async queryYydAppMonthStatisticalData(request: QueryYydAppMonthStatisticalDataRequest): Promise<QueryYydAppMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppMonthStatisticalDataHeaders({ });
    return await this.queryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydAppStdStatisticalDataWithOptions(request: QueryYydAppStdStatisticalDataRequest, headers: QueryYydAppStdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppStdStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydAppStdStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppStdDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppStdStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppStdStatisticalDataResponse({}));
  }

  async queryYydAppStdStatisticalData(request: QueryYydAppStdStatisticalDataRequest): Promise<QueryYydAppStdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppStdStatisticalDataHeaders({ });
    return await this.queryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydAppWeekStatisticalDataWithOptions(request: QueryYydAppWeekStatisticalDataRequest, headers: QueryYydAppWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydAppWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppWeekStatisticalDataResponse({}));
  }

  async queryYydAppWeekStatisticalData(request: QueryYydAppWeekStatisticalDataRequest): Promise<QueryYydAppWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppWeekStatisticalDataHeaders({ });
    return await this.queryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydCalendarDayStatisticalDataWithOptions(request: QueryYydCalendarDayStatisticalDataRequest, headers: QueryYydCalendarDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydCalendarDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydCalendarDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydCalendarDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydCalendarDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydCalendarDayStatisticalDataResponse({}));
  }

  async queryYydCalendarDayStatisticalData(request: QueryYydCalendarDayStatisticalDataRequest): Promise<QueryYydCalendarDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarDayStatisticalDataHeaders({ });
    return await this.queryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydCalendarMonthStatisticalDataWithOptions(request: QueryYydCalendarMonthStatisticalDataRequest, headers: QueryYydCalendarMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydCalendarMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydCalendarMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydCalendarMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydCalendarMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydCalendarMonthStatisticalDataResponse({}));
  }

  async queryYydCalendarMonthStatisticalData(request: QueryYydCalendarMonthStatisticalDataRequest): Promise<QueryYydCalendarMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarMonthStatisticalDataHeaders({ });
    return await this.queryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydCalendarWeekStatisticalDataWithOptions(request: QueryYydCalendarWeekStatisticalDataRequest, headers: QueryYydCalendarWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydCalendarWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydCalendarWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydCalendarWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydCalendarWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydCalendarWeekStatisticalDataResponse({}));
  }

  async queryYydCalendarWeekStatisticalData(request: QueryYydCalendarWeekStatisticalDataRequest): Promise<QueryYydCalendarWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarWeekStatisticalDataHeaders({ });
    return await this.queryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydDingMsgDayStatisticalDataWithOptions(request: QueryYydDingMsgDayStatisticalDataRequest, headers: QueryYydDingMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydDingMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydDingMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydDingMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydDingMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydDingMsgDayStatisticalDataResponse({}));
  }

  async queryYydDingMsgDayStatisticalData(request: QueryYydDingMsgDayStatisticalDataRequest): Promise<QueryYydDingMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgDayStatisticalDataHeaders({ });
    return await this.queryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydDingMsgMonthStatisticalDataWithOptions(request: QueryYydDingMsgMonthStatisticalDataRequest, headers: QueryYydDingMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydDingMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydDingMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydDingMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydDingMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydDingMsgMonthStatisticalDataResponse({}));
  }

  async queryYydDingMsgMonthStatisticalData(request: QueryYydDingMsgMonthStatisticalDataRequest): Promise<QueryYydDingMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydDingMsgWeekStatisticalDataWithOptions(request: QueryYydDingMsgWeekStatisticalDataRequest, headers: QueryYydDingMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydDingMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydDingMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydDingMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydDingMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydDingMsgWeekStatisticalDataResponse({}));
  }

  async queryYydDingMsgWeekStatisticalData(request: QueryYydDingMsgWeekStatisticalDataRequest): Promise<QueryYydDingMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydGroupMsgDayStatisticalDataWithOptions(request: QueryYydGroupMsgDayStatisticalDataRequest, headers: QueryYydGroupMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydGroupMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydGroupMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydGroupMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydGroupMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydGroupMsgDayStatisticalDataResponse({}));
  }

  async queryYydGroupMsgDayStatisticalData(request: QueryYydGroupMsgDayStatisticalDataRequest): Promise<QueryYydGroupMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgDayStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydGroupMsgMonthStatisticalDataWithOptions(request: QueryYydGroupMsgMonthStatisticalDataRequest, headers: QueryYydGroupMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydGroupMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydGroupMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydGroupMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydGroupMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydGroupMsgMonthStatisticalDataResponse({}));
  }

  async queryYydGroupMsgMonthStatisticalData(request: QueryYydGroupMsgMonthStatisticalDataRequest): Promise<QueryYydGroupMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydGroupMsgWeekStatisticalDataWithOptions(request: QueryYydGroupMsgWeekStatisticalDataRequest, headers: QueryYydGroupMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydGroupMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydGroupMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydGroupMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydGroupMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydGroupMsgWeekStatisticalDataResponse({}));
  }

  async queryYydGroupMsgWeekStatisticalData(request: QueryYydGroupMsgWeekStatisticalDataRequest): Promise<QueryYydGroupMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydLogDayStatisticalDataWithOptions(request: QueryYydLogDayStatisticalDataRequest, headers: QueryYydLogDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydLogDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydLogDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydLogDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydLogDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydLogDayStatisticalDataResponse({}));
  }

  async queryYydLogDayStatisticalData(request: QueryYydLogDayStatisticalDataRequest): Promise<QueryYydLogDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogDayStatisticalDataHeaders({ });
    return await this.queryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydLogMonthStatisticalDataWithOptions(request: QueryYydLogMonthStatisticalDataRequest, headers: QueryYydLogMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydLogMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydLogMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydLogMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydLogMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydLogMonthStatisticalDataResponse({}));
  }

  async queryYydLogMonthStatisticalData(request: QueryYydLogMonthStatisticalDataRequest): Promise<QueryYydLogMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogMonthStatisticalDataHeaders({ });
    return await this.queryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydLogWeekStatisticalDataWithOptions(request: QueryYydLogWeekStatisticalDataRequest, headers: QueryYydLogWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydLogWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydLogWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydLogWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydLogWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydLogWeekStatisticalDataResponse({}));
  }

  async queryYydLogWeekStatisticalData(request: QueryYydLogWeekStatisticalDataRequest): Promise<QueryYydLogWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogWeekStatisticalDataHeaders({ });
    return await this.queryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydMeetingDayStatisticalDataWithOptions(request: QueryYydMeetingDayStatisticalDataRequest, headers: QueryYydMeetingDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydMeetingDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydMeetingDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydMeetingDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydMeetingDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydMeetingDayStatisticalDataResponse({}));
  }

  async queryYydMeetingDayStatisticalData(request: QueryYydMeetingDayStatisticalDataRequest): Promise<QueryYydMeetingDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingDayStatisticalDataHeaders({ });
    return await this.queryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydMeetingMonthStatisticalDataWithOptions(request: QueryYydMeetingMonthStatisticalDataRequest, headers: QueryYydMeetingMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydMeetingMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydMeetingMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydMeetingMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydMeetingMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydMeetingMonthStatisticalDataResponse({}));
  }

  async queryYydMeetingMonthStatisticalData(request: QueryYydMeetingMonthStatisticalDataRequest): Promise<QueryYydMeetingMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingMonthStatisticalDataHeaders({ });
    return await this.queryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydMeetingWeekStatisticalDataWithOptions(request: QueryYydMeetingWeekStatisticalDataRequest, headers: QueryYydMeetingWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydMeetingWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydMeetingWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydMeetingWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydMeetingWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydMeetingWeekStatisticalDataResponse({}));
  }

  async queryYydMeetingWeekStatisticalData(request: QueryYydMeetingWeekStatisticalDataRequest): Promise<QueryYydMeetingWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingWeekStatisticalDataHeaders({ });
    return await this.queryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydNoticeDayStatisticalDataWithOptions(request: QueryYydNoticeDayStatisticalDataRequest, headers: QueryYydNoticeDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydNoticeDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydNoticeDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydNoticeDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydNoticeDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydNoticeDayStatisticalDataResponse({}));
  }

  async queryYydNoticeDayStatisticalData(request: QueryYydNoticeDayStatisticalDataRequest): Promise<QueryYydNoticeDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeDayStatisticalDataHeaders({ });
    return await this.queryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydNoticeMonthStatisticalDataWithOptions(request: QueryYydNoticeMonthStatisticalDataRequest, headers: QueryYydNoticeMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydNoticeMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydNoticeMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydNoticeMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydNoticeMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydNoticeMonthStatisticalDataResponse({}));
  }

  async queryYydNoticeMonthStatisticalData(request: QueryYydNoticeMonthStatisticalDataRequest): Promise<QueryYydNoticeMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeMonthStatisticalDataHeaders({ });
    return await this.queryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydNoticeWeekStatisticalDataWithOptions(request: QueryYydNoticeWeekStatisticalDataRequest, headers: QueryYydNoticeWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydNoticeWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydNoticeWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydNoticeWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydNoticeWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydNoticeWeekStatisticalDataResponse({}));
  }

  async queryYydNoticeWeekStatisticalData(request: QueryYydNoticeWeekStatisticalDataRequest): Promise<QueryYydNoticeWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeWeekStatisticalDataHeaders({ });
    return await this.queryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydSingleMsgDayStatisticalDataWithOptions(request: QueryYydSingleMsgDayStatisticalDataRequest, headers: QueryYydSingleMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydSingleMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydSingleMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydSingleMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydSingleMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydSingleMsgDayStatisticalDataResponse({}));
  }

  async queryYydSingleMsgDayStatisticalData(request: QueryYydSingleMsgDayStatisticalDataRequest): Promise<QueryYydSingleMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgDayStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydSingleMsgMonthStatisticalDataWithOptions(request: QueryYydSingleMsgMonthStatisticalDataRequest, headers: QueryYydSingleMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydSingleMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydSingleMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydSingleMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydSingleMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydSingleMsgMonthStatisticalDataResponse({}));
  }

  async queryYydSingleMsgMonthStatisticalData(request: QueryYydSingleMsgMonthStatisticalDataRequest): Promise<QueryYydSingleMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydSingleMsgWeekStatisticalDataWithOptions(request: QueryYydSingleMsgWeekStatisticalDataRequest, headers: QueryYydSingleMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydSingleMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydSingleMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydSingleMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydSingleMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydSingleMsgWeekStatisticalDataResponse({}));
  }

  async queryYydSingleMsgWeekStatisticalData(request: QueryYydSingleMsgWeekStatisticalDataRequest): Promise<QueryYydSingleMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydToatlMsgDayStatisticalDataWithOptions(request: QueryYydToatlMsgDayStatisticalDataRequest, headers: QueryYydToatlMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydToatlMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydToatlMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydToatlMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydToatlMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydToatlMsgDayStatisticalDataResponse({}));
  }

  async queryYydToatlMsgDayStatisticalData(request: QueryYydToatlMsgDayStatisticalDataRequest): Promise<QueryYydToatlMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgDayStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydToatlMsgMonthStatisticalDataWithOptions(request: QueryYydToatlMsgMonthStatisticalDataRequest, headers: QueryYydToatlMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydToatlMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydToatlMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydToatlMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydToatlMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydToatlMsgMonthStatisticalDataResponse({}));
  }

  async queryYydToatlMsgMonthStatisticalData(request: QueryYydToatlMsgMonthStatisticalDataRequest): Promise<QueryYydToatlMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydToatlMsgWeekStatisticalDataWithOptions(request: QueryYydToatlMsgWeekStatisticalDataRequest, headers: QueryYydToatlMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydToatlMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydToatlMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydToatlMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydToatlMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydToatlMsgWeekStatisticalDataResponse({}));
  }

  async queryYydToatlMsgWeekStatisticalData(request: QueryYydToatlMsgWeekStatisticalDataRequest): Promise<QueryYydToatlMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTodoDayStatisticalDataWithOptions(request: QueryYydTodoDayStatisticalDataRequest, headers: QueryYydTodoDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTodoDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTodoDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTodoDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTodoDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTodoDayStatisticalDataResponse({}));
  }

  async queryYydTodoDayStatisticalData(request: QueryYydTodoDayStatisticalDataRequest): Promise<QueryYydTodoDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoDayStatisticalDataHeaders({ });
    return await this.queryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTodoMonthStatisticalDataWithOptions(request: QueryYydTodoMonthStatisticalDataRequest, headers: QueryYydTodoMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTodoMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTodoMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTodoMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTodoMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTodoMonthStatisticalDataResponse({}));
  }

  async queryYydTodoMonthStatisticalData(request: QueryYydTodoMonthStatisticalDataRequest): Promise<QueryYydTodoMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoMonthStatisticalDataHeaders({ });
    return await this.queryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTodoWeekStatisticalDataWithOptions(request: QueryYydTodoWeekStatisticalDataRequest, headers: QueryYydTodoWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTodoWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTodoWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTodoWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTodoWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTodoWeekStatisticalDataResponse({}));
  }

  async queryYydTodoWeekStatisticalData(request: QueryYydTodoWeekStatisticalDataRequest): Promise<QueryYydTodoWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoWeekStatisticalDataHeaders({ });
    return await this.queryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTotalDayStatisticalDataWithOptions(request: QueryYydTotalDayStatisticalDataRequest, headers: QueryYydTotalDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTotalDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalDayStatisticalDataResponse({}));
  }

  async queryYydTotalDayStatisticalData(request: QueryYydTotalDayStatisticalDataRequest): Promise<QueryYydTotalDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalDayStatisticalDataHeaders({ });
    return await this.queryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTotalMonthStatisticalDataWithOptions(request: QueryYydTotalMonthStatisticalDataRequest, headers: QueryYydTotalMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTotalMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalMonthStatisticalDataResponse({}));
  }

  async queryYydTotalMonthStatisticalData(request: QueryYydTotalMonthStatisticalDataRequest): Promise<QueryYydTotalMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalMonthStatisticalDataHeaders({ });
    return await this.queryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTotalStdStatisticalDataWithOptions(request: QueryYydTotalStdStatisticalDataRequest, headers: QueryYydTotalStdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalStdStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTotalStdStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalStdDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalStdStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalStdStatisticalDataResponse({}));
  }

  async queryYydTotalStdStatisticalData(request: QueryYydTotalStdStatisticalDataRequest): Promise<QueryYydTotalStdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalStdStatisticalDataHeaders({ });
    return await this.queryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryYydTotalWeekStatisticalDataWithOptions(request: QueryYydTotalWeekStatisticalDataRequest, headers: QueryYydTotalWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
    }

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
      action: "QueryYydTotalWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalWeekStatisticalDataResponse({}));
  }

  async queryYydTotalWeekStatisticalData(request: QueryYydTotalWeekStatisticalDataRequest): Promise<QueryYydTotalWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalWeekStatisticalDataHeaders({ });
    return await this.queryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  async searchCompanyWithOptions(request: SearchCompanyRequest, headers: SearchCompanyHeaders, runtime: $Util.RuntimeOptions): Promise<SearchCompanyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
    }

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
      action: "SearchCompany",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/keywords/companies`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchCompanyResponse>(await this.execute(params, req, runtime), new SearchCompanyResponse({}));
  }

  async searchCompany(request: SearchCompanyRequest): Promise<SearchCompanyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchCompanyHeaders({ });
    return await this.searchCompanyWithOptions(request, headers, runtime);
  }

}
