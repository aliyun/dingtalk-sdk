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

export class AssignOrgHoldingToEmpHoldingBatchHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignOrgHoldingToEmpHoldingBatchRequest extends $tea.Model {
  remark?: string;
  sendOrgCultureInform?: boolean;
  singleAmount?: number;
  sourceUsage?: string;
  targetUsage?: string;
  targetUserList?: AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList[];
  static names(): { [key: string]: string } {
    return {
      remark: 'remark',
      sendOrgCultureInform: 'sendOrgCultureInform',
      singleAmount: 'singleAmount',
      sourceUsage: 'sourceUsage',
      targetUsage: 'targetUsage',
      targetUserList: 'targetUserList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      remark: 'string',
      sendOrgCultureInform: 'boolean',
      singleAmount: 'number',
      sourceUsage: 'string',
      targetUsage: 'string',
      targetUserList: { 'type': 'array', 'itemType': AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignOrgHoldingToEmpHoldingBatchResponseBody extends $tea.Model {
  result?: AssignOrgHoldingToEmpHoldingBatchResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AssignOrgHoldingToEmpHoldingBatchResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignOrgHoldingToEmpHoldingBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AssignOrgHoldingToEmpHoldingBatchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AssignOrgHoldingToEmpHoldingBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsRequest extends $tea.Model {
  amount?: number;
  outId?: string;
  remark?: string;
  usage?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      outId: 'outId',
      remark: 'remark',
      usage: 'usage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
      outId: 'string',
      remark: 'string',
      usage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsResponseBody extends $tea.Model {
  result?: ConsumeUserPointsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ConsumeUserPointsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ConsumeUserPointsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ConsumeUserPointsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrgHonorHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrgHonorRequest extends $tea.Model {
  avatarFrameMediaId?: string;
  defaultBgColor?: string;
  medalDesc?: string;
  medalMediaId?: string;
  medalName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarFrameMediaId: 'avatarFrameMediaId',
      defaultBgColor: 'defaultBgColor',
      medalDesc: 'medalDesc',
      medalMediaId: 'medalMediaId',
      medalName: 'medalName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarFrameMediaId: 'string',
      defaultBgColor: 'string',
      medalDesc: 'string',
      medalMediaId: 'string',
      medalName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrgHonorResponseBody extends $tea.Model {
  result?: CreateOrgHonorResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateOrgHonorResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrgHonorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateOrgHonorResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateOrgHonorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchRequest extends $tea.Model {
  deductionAmount?: number;
  remark?: string;
  sendOrgCultureInform?: boolean;
  targetUserList?: DeductionPointBatchRequestTargetUserList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deductionAmount: 'deductionAmount',
      remark: 'remark',
      sendOrgCultureInform: 'sendOrgCultureInform',
      targetUserList: 'targetUserList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deductionAmount: 'number',
      remark: 'string',
      sendOrgCultureInform: 'boolean',
      targetUserList: { 'type': 'array', 'itemType': DeductionPointBatchRequestTargetUserList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchResponseBody extends $tea.Model {
  result?: DeductionPointBatchResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DeductionPointBatchResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeductionPointBatchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeductionPointBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExportPointOpenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExportPointOpenRequest extends $tea.Model {
  exportDate?: string;
  exportType?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      exportDate: 'exportDate',
      exportType: 'exportType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      exportDate: 'string',
      exportType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExportPointOpenResponseBody extends $tea.Model {
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

export class ExportPointOpenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ExportPointOpenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ExportPointOpenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorRequest extends $tea.Model {
  expirationTime?: number;
  grantReason?: string;
  granterName?: string;
  noticeAnnouncer?: boolean;
  noticeSingle?: boolean;
  openConversationIds?: string[];
  receiverUserIds?: string[];
  senderUserId?: string;
  static names(): { [key: string]: string } {
    return {
      expirationTime: 'expirationTime',
      grantReason: 'grantReason',
      granterName: 'granterName',
      noticeAnnouncer: 'noticeAnnouncer',
      noticeSingle: 'noticeSingle',
      openConversationIds: 'openConversationIds',
      receiverUserIds: 'receiverUserIds',
      senderUserId: 'senderUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationTime: 'number',
      grantReason: 'string',
      granterName: 'string',
      noticeAnnouncer: 'boolean',
      noticeSingle: 'boolean',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      receiverUserIds: { 'type': 'array', 'itemType': 'string' },
      senderUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorResponseBody extends $tea.Model {
  result?: GrantHonorResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GrantHonorResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GrantHonorResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GrantHonorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsRequest extends $tea.Model {
  optUserId?: string;
  static names(): { [key: string]: string } {
    return {
      optUserId: 'optUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      optUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsResponseBody extends $tea.Model {
  result?: QueryCorpPointsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryCorpPointsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCorpPointsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCorpPointsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponseBody extends $tea.Model {
  result?: QueryEmpPointDetailsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryEmpPointDetailsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryEmpPointDetailsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryEmpPointDetailsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsRequest extends $tea.Model {
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

export class QueryOrgHonorsResponseBody extends $tea.Model {
  result?: QueryOrgHonorsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOrgHonorsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrgHonorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOrgHonorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsRequest extends $tea.Model {
  accountType?: string;
  pageNumber?: number;
  pageSize?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponseBody extends $tea.Model {
  result?: QueryOrgPointDetailsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOrgPointDetailsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrgPointDetailsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryOrgPointDetailsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointActionAutoAssignRuleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointActionAutoAssignRuleResponseBody extends $tea.Model {
  result?: QueryPointActionAutoAssignRuleResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryPointActionAutoAssignRuleResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointActionAutoAssignRuleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryPointActionAutoAssignRuleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPointActionAutoAssignRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointAutoIssueSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointAutoIssueSettingResponseBody extends $tea.Model {
  result?: QueryPointAutoIssueSettingResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryPointAutoIssueSettingResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointAutoIssueSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryPointAutoIssueSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPointAutoIssueSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsRequest extends $tea.Model {
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

export class QueryUserHonorsResponseBody extends $tea.Model {
  result?: QueryUserHonorsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryUserHonorsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserHonorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserHonorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPointsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPointsResponseBody extends $tea.Model {
  result?: QueryUserPointsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryUserPointsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPointsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserPointsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserPointsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallHonorHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallHonorRequest extends $tea.Model {
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

export class RecallHonorResponseBody extends $tea.Model {
  result?: RecallHonorResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: RecallHonorResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallHonorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RecallHonorResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RecallHonorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAutoIssuePointHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAutoIssuePointRequest extends $tea.Model {
  pointAutoNum?: number;
  pointAutoState?: boolean;
  pointAutoTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      pointAutoNum: 'pointAutoNum',
      pointAutoState: 'pointAutoState',
      pointAutoTime: 'pointAutoTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointAutoNum: 'number',
      pointAutoState: 'boolean',
      pointAutoTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAutoIssuePointResponseBody extends $tea.Model {
  result?: UpdateAutoIssuePointResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateAutoIssuePointResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAutoIssuePointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateAutoIssuePointResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateAutoIssuePointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePointActionAutoAssignRuleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePointActionAutoAssignRuleRequest extends $tea.Model {
  updatePointRuleRequestDTOList?: UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      updatePointRuleRequestDTOList: 'updatePointRuleRequestDTOList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updatePointRuleRequestDTOList: { 'type': 'array', 'itemType': UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePointActionAutoAssignRuleResponseBody extends $tea.Model {
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

export class UpdatePointActionAutoAssignRuleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdatePointActionAutoAssignRuleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdatePointActionAutoAssignRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WearOrgHonorHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WearOrgHonorRequest extends $tea.Model {
  userId?: string;
  wear?: boolean;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      wear: 'wear',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      wear: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WearOrgHonorResponseBody extends $tea.Model {
  result?: WearOrgHonorResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: WearOrgHonorResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WearOrgHonorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: WearOrgHonorResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: WearOrgHonorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList extends $tea.Model {
  outId?: string;
  targetUserId?: string;
  static names(): { [key: string]: string } {
    return {
      outId: 'outId',
      targetUserId: 'targetUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outId: 'string',
      targetUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS extends $tea.Model {
  code?: string;
  invokeStatus?: string;
  msg?: string;
  outId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      invokeStatus: 'invokeStatus',
      msg: 'msg',
      outId: 'outId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      invokeStatus: 'string',
      msg: 'string',
      outId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignOrgHoldingToEmpHoldingBatchResponseBodyResult extends $tea.Model {
  openPointInvokeResultDTOS?: AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS[];
  static names(): { [key: string]: string } {
    return {
      openPointInvokeResultDTOS: 'openPointInvokeResultDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPointInvokeResultDTOS: { 'type': 'array', 'itemType': AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsResponseBodyResult extends $tea.Model {
  amount?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrgHonorResponseBodyResult extends $tea.Model {
  honorId?: string;
  static names(): { [key: string]: string } {
    return {
      honorId: 'honorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchRequestTargetUserList extends $tea.Model {
  outId?: string;
  targetUserId?: string;
  static names(): { [key: string]: string } {
    return {
      outId: 'outId',
      targetUserId: 'targetUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outId: 'string',
      targetUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS extends $tea.Model {
  code?: string;
  invokeStatus?: string;
  msg?: string;
  outId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      invokeStatus: 'invokeStatus',
      msg: 'msg',
      outId: 'outId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      invokeStatus: 'string',
      msg: 'string',
      outId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeductionPointBatchResponseBodyResult extends $tea.Model {
  openPointInvokeResultDTOS?: DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS[];
  static names(): { [key: string]: string } {
    return {
      openPointInvokeResultDTOS: 'openPointInvokeResultDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPointInvokeResultDTOS: { 'type': 'array', 'itemType': DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorResponseBodyResult extends $tea.Model {
  failedUserIds?: string[];
  successUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      failedUserIds: 'failedUserIds',
      successUserIds: 'successUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedUserIds: { 'type': 'array', 'itemType': 'string' },
      successUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsResponseBodyResult extends $tea.Model {
  amount?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource extends $tea.Model {
  accountType?: string;
  empName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      empName: 'empName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      empName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget extends $tea.Model {
  accountType?: string;
  empName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      empName: 'empName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      empName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO extends $tea.Model {
  accountSource?: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource;
  accountTarget?: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget;
  remark?: string;
  usage?: string;
  static names(): { [key: string]: string } {
    return {
      accountSource: 'accountSource',
      accountTarget: 'accountTarget',
      remark: 'remark',
      usage: 'usage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountSource: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource,
      accountTarget: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget,
      remark: 'string',
      usage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponseBodyResultDetails extends $tea.Model {
  amount?: number;
  gmtCreate?: number;
  outId?: string;
  pointOperateFeatureResponseDTO?: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO;
  sourceBizCode?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      gmtCreate: 'gmtCreate',
      outId: 'outId',
      pointOperateFeatureResponseDTO: 'pointOperateFeatureResponseDTO',
      sourceBizCode: 'sourceBizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
      gmtCreate: 'number',
      outId: 'string',
      pointOperateFeatureResponseDTO: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO,
      sourceBizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmpPointDetailsResponseBodyResult extends $tea.Model {
  details?: QueryEmpPointDetailsResponseBodyResultDetails[];
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      details: 'details',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      details: { 'type': 'array', 'itemType': QueryEmpPointDetailsResponseBodyResultDetails },
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsResponseBodyResultOpenHonors extends $tea.Model {
  honorDesc?: string;
  honorId?: number;
  honorImgUrl?: string;
  honorName?: string;
  honorPendantImgUrl?: string;
  static names(): { [key: string]: string } {
    return {
      honorDesc: 'honorDesc',
      honorId: 'honorId',
      honorImgUrl: 'honorImgUrl',
      honorName: 'honorName',
      honorPendantImgUrl: 'honorPendantImgUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honorDesc: 'string',
      honorId: 'number',
      honorImgUrl: 'string',
      honorName: 'string',
      honorPendantImgUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsResponseBodyResult extends $tea.Model {
  nextToken?: string;
  openHonors?: QueryOrgHonorsResponseBodyResultOpenHonors[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      openHonors: 'openHonors',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      openHonors: { 'type': 'array', 'itemType': QueryOrgHonorsResponseBodyResultOpenHonors },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource extends $tea.Model {
  accountType?: string;
  empName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      empName: 'empName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      empName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget extends $tea.Model {
  accountType?: string;
  empName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      empName: 'empName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      empName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO extends $tea.Model {
  accountSource?: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource;
  accountTarget?: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget;
  remark?: string;
  usage?: string;
  static names(): { [key: string]: string } {
    return {
      accountSource: 'accountSource',
      accountTarget: 'accountTarget',
      remark: 'remark',
      usage: 'usage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountSource: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource,
      accountTarget: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget,
      remark: 'string',
      usage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponseBodyResultDetails extends $tea.Model {
  amount?: number;
  gmtCreate?: number;
  outId?: string;
  pointOperateFeatureResponseDTO?: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO;
  sourceBizCode?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      gmtCreate: 'gmtCreate',
      outId: 'outId',
      pointOperateFeatureResponseDTO: 'pointOperateFeatureResponseDTO',
      sourceBizCode: 'sourceBizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
      gmtCreate: 'number',
      outId: 'string',
      pointOperateFeatureResponseDTO: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO,
      sourceBizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgPointDetailsResponseBodyResult extends $tea.Model {
  details?: QueryOrgPointDetailsResponseBodyResultDetails[];
  hasMore?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      details: 'details',
      hasMore: 'hasMore',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      details: { 'type': 'array', 'itemType': QueryOrgPointDetailsResponseBodyResultDetails },
      hasMore: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS extends $tea.Model {
  awardScore?: number;
  code?: string;
  dayLimitTimes?: number;
  description?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      awardScore: 'awardScore',
      code: 'code',
      dayLimitTimes: 'dayLimitTimes',
      description: 'description',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      awardScore: 'number',
      code: 'string',
      dayLimitTimes: 'number',
      description: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointActionAutoAssignRuleResponseBodyResult extends $tea.Model {
  queryPointRuleResponseDTOS?: QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS[];
  static names(): { [key: string]: string } {
    return {
      queryPointRuleResponseDTOS: 'queryPointRuleResponseDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      queryPointRuleResponseDTOS: { 'type': 'array', 'itemType': QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPointAutoIssueSettingResponseBodyResult extends $tea.Model {
  pointAutoNum?: number;
  pointAutoState?: boolean;
  pointAutoTime?: number;
  static names(): { [key: string]: string } {
    return {
      pointAutoNum: 'pointAutoNum',
      pointAutoState: 'pointAutoState',
      pointAutoTime: 'pointAutoTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointAutoNum: 'number',
      pointAutoState: 'boolean',
      pointAutoTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponseBodyResultHonorsGrantHistory extends $tea.Model {
  grantTime?: number;
  senderUserid?: string;
  static names(): { [key: string]: string } {
    return {
      grantTime: 'grantTime',
      senderUserid: 'senderUserid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      grantTime: 'number',
      senderUserid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponseBodyResultHonors extends $tea.Model {
  expirationTime?: number;
  grantHistory?: QueryUserHonorsResponseBodyResultHonorsGrantHistory[];
  honorDesc?: string;
  honorId?: string;
  honorName?: string;
  static names(): { [key: string]: string } {
    return {
      expirationTime: 'expirationTime',
      grantHistory: 'grantHistory',
      honorDesc: 'honorDesc',
      honorId: 'honorId',
      honorName: 'honorName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationTime: 'number',
      grantHistory: { 'type': 'array', 'itemType': QueryUserHonorsResponseBodyResultHonorsGrantHistory },
      honorDesc: 'string',
      honorId: 'string',
      honorName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponseBodyResult extends $tea.Model {
  honors?: QueryUserHonorsResponseBodyResultHonors[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      honors: 'honors',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honors: { 'type': 'array', 'itemType': QueryUserHonorsResponseBodyResultHonors },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPointsResponseBodyResult extends $tea.Model {
  amount?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallHonorResponseBodyResult extends $tea.Model {
  honorId?: string;
  static names(): { [key: string]: string } {
    return {
      honorId: 'honorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAutoIssuePointResponseBodyResult extends $tea.Model {
  nextAutoIssuePointTime?: number;
  static names(): { [key: string]: string } {
    return {
      nextAutoIssuePointTime: 'nextAutoIssuePointTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextAutoIssuePointTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList extends $tea.Model {
  awardScore?: number;
  code?: string;
  dayLimitTimes?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      awardScore: 'awardScore',
      code: 'code',
      dayLimitTimes: 'dayLimitTimes',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      awardScore: 'number',
      code: 'string',
      dayLimitTimes: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WearOrgHonorResponseBodyResult extends $tea.Model {
  honorId?: string;
  static names(): { [key: string]: string } {
    return {
      honorId: 'honorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honorId: 'string',
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


  async assignOrgHoldingToEmpHoldingBatchWithOptions(request: AssignOrgHoldingToEmpHoldingBatchRequest, headers: AssignOrgHoldingToEmpHoldingBatchHeaders, runtime: $Util.RuntimeOptions): Promise<AssignOrgHoldingToEmpHoldingBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.sendOrgCultureInform)) {
      body["sendOrgCultureInform"] = request.sendOrgCultureInform;
    }

    if (!Util.isUnset(request.singleAmount)) {
      body["singleAmount"] = request.singleAmount;
    }

    if (!Util.isUnset(request.sourceUsage)) {
      body["sourceUsage"] = request.sourceUsage;
    }

    if (!Util.isUnset(request.targetUsage)) {
      body["targetUsage"] = request.targetUsage;
    }

    if (!Util.isUnset(request.targetUserList)) {
      body["targetUserList"] = request.targetUserList;
    }

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
      action: "AssignOrgHoldingToEmpHoldingBatch",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/organizations/points/assign`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AssignOrgHoldingToEmpHoldingBatchResponse>(await this.execute(params, req, runtime), new AssignOrgHoldingToEmpHoldingBatchResponse({}));
  }

  async assignOrgHoldingToEmpHoldingBatch(request: AssignOrgHoldingToEmpHoldingBatchRequest): Promise<AssignOrgHoldingToEmpHoldingBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AssignOrgHoldingToEmpHoldingBatchHeaders({ });
    return await this.assignOrgHoldingToEmpHoldingBatchWithOptions(request, headers, runtime);
  }

  async consumeUserPointsWithOptions(userId: string, request: ConsumeUserPointsRequest, headers: ConsumeUserPointsHeaders, runtime: $Util.RuntimeOptions): Promise<ConsumeUserPointsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.outId)) {
      body["outId"] = request.outId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.usage)) {
      body["usage"] = request.usage;
    }

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
      action: "ConsumeUserPoints",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/${userId}/points/deduct`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConsumeUserPointsResponse>(await this.execute(params, req, runtime), new ConsumeUserPointsResponse({}));
  }

  async consumeUserPoints(userId: string, request: ConsumeUserPointsRequest): Promise<ConsumeUserPointsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsumeUserPointsHeaders({ });
    return await this.consumeUserPointsWithOptions(userId, request, headers, runtime);
  }

  async createOrgHonorWithOptions(request: CreateOrgHonorRequest, headers: CreateOrgHonorHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOrgHonorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.avatarFrameMediaId)) {
      body["avatarFrameMediaId"] = request.avatarFrameMediaId;
    }

    if (!Util.isUnset(request.defaultBgColor)) {
      body["defaultBgColor"] = request.defaultBgColor;
    }

    if (!Util.isUnset(request.medalDesc)) {
      body["medalDesc"] = request.medalDesc;
    }

    if (!Util.isUnset(request.medalMediaId)) {
      body["medalMediaId"] = request.medalMediaId;
    }

    if (!Util.isUnset(request.medalName)) {
      body["medalName"] = request.medalName;
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
      action: "CreateOrgHonor",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/honors/templates`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateOrgHonorResponse>(await this.execute(params, req, runtime), new CreateOrgHonorResponse({}));
  }

  async createOrgHonor(request: CreateOrgHonorRequest): Promise<CreateOrgHonorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrgHonorHeaders({ });
    return await this.createOrgHonorWithOptions(request, headers, runtime);
  }

  async deductionPointBatchWithOptions(request: DeductionPointBatchRequest, headers: DeductionPointBatchHeaders, runtime: $Util.RuntimeOptions): Promise<DeductionPointBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deductionAmount)) {
      body["deductionAmount"] = request.deductionAmount;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.sendOrgCultureInform)) {
      body["sendOrgCultureInform"] = request.sendOrgCultureInform;
    }

    if (!Util.isUnset(request.targetUserList)) {
      body["targetUserList"] = request.targetUserList;
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
      action: "DeductionPointBatch",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/points/deduct`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeductionPointBatchResponse>(await this.execute(params, req, runtime), new DeductionPointBatchResponse({}));
  }

  async deductionPointBatch(request: DeductionPointBatchRequest): Promise<DeductionPointBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeductionPointBatchHeaders({ });
    return await this.deductionPointBatchWithOptions(request, headers, runtime);
  }

  async exportPointOpenWithOptions(request: ExportPointOpenRequest, headers: ExportPointOpenHeaders, runtime: $Util.RuntimeOptions): Promise<ExportPointOpenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.exportDate)) {
      body["exportDate"] = request.exportDate;
    }

    if (!Util.isUnset(request.exportType)) {
      body["exportType"] = request.exportType;
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
      action: "ExportPointOpen",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/points/export`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExportPointOpenResponse>(await this.execute(params, req, runtime), new ExportPointOpenResponse({}));
  }

  async exportPointOpen(request: ExportPointOpenRequest): Promise<ExportPointOpenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExportPointOpenHeaders({ });
    return await this.exportPointOpenWithOptions(request, headers, runtime);
  }

  async grantHonorWithOptions(honorId: string, request: GrantHonorRequest, headers: GrantHonorHeaders, runtime: $Util.RuntimeOptions): Promise<GrantHonorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.expirationTime)) {
      body["expirationTime"] = request.expirationTime;
    }

    if (!Util.isUnset(request.grantReason)) {
      body["grantReason"] = request.grantReason;
    }

    if (!Util.isUnset(request.granterName)) {
      body["granterName"] = request.granterName;
    }

    if (!Util.isUnset(request.noticeAnnouncer)) {
      body["noticeAnnouncer"] = request.noticeAnnouncer;
    }

    if (!Util.isUnset(request.noticeSingle)) {
      body["noticeSingle"] = request.noticeSingle;
    }

    if (!Util.isUnset(request.openConversationIds)) {
      body["openConversationIds"] = request.openConversationIds;
    }

    if (!Util.isUnset(request.receiverUserIds)) {
      body["receiverUserIds"] = request.receiverUserIds;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
    }

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
      action: "GrantHonor",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/honors/${honorId}/grant`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GrantHonorResponse>(await this.execute(params, req, runtime), new GrantHonorResponse({}));
  }

  async grantHonor(honorId: string, request: GrantHonorRequest): Promise<GrantHonorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantHonorHeaders({ });
    return await this.grantHonorWithOptions(honorId, request, headers, runtime);
  }

  async queryCorpPointsWithOptions(request: QueryCorpPointsRequest, headers: QueryCorpPointsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCorpPointsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.optUserId)) {
      query["optUserId"] = request.optUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryCorpPoints",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/organizations/points`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCorpPointsResponse>(await this.execute(params, req, runtime), new QueryCorpPointsResponse({}));
  }

  async queryCorpPoints(request: QueryCorpPointsRequest): Promise<QueryCorpPointsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCorpPointsHeaders({ });
    return await this.queryCorpPointsWithOptions(request, headers, runtime);
  }

  async queryEmpPointDetailsWithOptions(request: QueryEmpPointDetailsRequest, headers: QueryEmpPointDetailsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEmpPointDetailsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
      action: "QueryEmpPointDetails",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/points/empDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryEmpPointDetailsResponse>(await this.execute(params, req, runtime), new QueryEmpPointDetailsResponse({}));
  }

  async queryEmpPointDetails(request: QueryEmpPointDetailsRequest): Promise<QueryEmpPointDetailsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEmpPointDetailsHeaders({ });
    return await this.queryEmpPointDetailsWithOptions(request, headers, runtime);
  }

  async queryOrgHonorsWithOptions(request: QueryOrgHonorsRequest, headers: QueryOrgHonorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgHonorsResponse> {
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
      action: "QueryOrgHonors",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/organizations/honors`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgHonorsResponse>(await this.execute(params, req, runtime), new QueryOrgHonorsResponse({}));
  }

  async queryOrgHonors(request: QueryOrgHonorsRequest): Promise<QueryOrgHonorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgHonorsHeaders({ });
    return await this.queryOrgHonorsWithOptions(request, headers, runtime);
  }

  async queryOrgPointDetailsWithOptions(request: QueryOrgPointDetailsRequest, headers: QueryOrgPointDetailsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgPointDetailsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountType)) {
      query["accountType"] = request.accountType;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
      action: "QueryOrgPointDetails",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/points/orgDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgPointDetailsResponse>(await this.execute(params, req, runtime), new QueryOrgPointDetailsResponse({}));
  }

  async queryOrgPointDetails(request: QueryOrgPointDetailsRequest): Promise<QueryOrgPointDetailsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgPointDetailsHeaders({ });
    return await this.queryOrgPointDetailsWithOptions(request, headers, runtime);
  }

  async queryPointActionAutoAssignRuleWithOptions(headers: QueryPointActionAutoAssignRuleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPointActionAutoAssignRuleResponse> {
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
      action: "QueryPointActionAutoAssignRule",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/points/actionRules`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPointActionAutoAssignRuleResponse>(await this.execute(params, req, runtime), new QueryPointActionAutoAssignRuleResponse({}));
  }

  async queryPointActionAutoAssignRule(): Promise<QueryPointActionAutoAssignRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPointActionAutoAssignRuleHeaders({ });
    return await this.queryPointActionAutoAssignRuleWithOptions(headers, runtime);
  }

  async queryPointAutoIssueSettingWithOptions(headers: QueryPointAutoIssueSettingHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPointAutoIssueSettingResponse> {
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
      action: "QueryPointAutoIssueSetting",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/points`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPointAutoIssueSettingResponse>(await this.execute(params, req, runtime), new QueryPointAutoIssueSettingResponse({}));
  }

  async queryPointAutoIssueSetting(): Promise<QueryPointAutoIssueSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPointAutoIssueSettingHeaders({ });
    return await this.queryPointAutoIssueSettingWithOptions(headers, runtime);
  }

  async queryUserHonorsWithOptions(userId: string, request: QueryUserHonorsRequest, headers: QueryUserHonorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserHonorsResponse> {
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
      action: "QueryUserHonors",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/honors/users/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserHonorsResponse>(await this.execute(params, req, runtime), new QueryUserHonorsResponse({}));
  }

  async queryUserHonors(userId: string, request: QueryUserHonorsRequest): Promise<QueryUserHonorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserHonorsHeaders({ });
    return await this.queryUserHonorsWithOptions(userId, request, headers, runtime);
  }

  async queryUserPointsWithOptions(userId: string, headers: QueryUserPointsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserPointsResponse> {
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
      action: "QueryUserPoints",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/${userId}/points`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserPointsResponse>(await this.execute(params, req, runtime), new QueryUserPointsResponse({}));
  }

  async queryUserPoints(userId: string): Promise<QueryUserPointsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserPointsHeaders({ });
    return await this.queryUserPointsWithOptions(userId, headers, runtime);
  }

  async recallHonorWithOptions(honorId: string, request: RecallHonorRequest, headers: RecallHonorHeaders, runtime: $Util.RuntimeOptions): Promise<RecallHonorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      action: "RecallHonor",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/honors/${honorId}/recall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RecallHonorResponse>(await this.execute(params, req, runtime), new RecallHonorResponse({}));
  }

  async recallHonor(honorId: string, request: RecallHonorRequest): Promise<RecallHonorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallHonorHeaders({ });
    return await this.recallHonorWithOptions(honorId, request, headers, runtime);
  }

  async updateAutoIssuePointWithOptions(request: UpdateAutoIssuePointRequest, headers: UpdateAutoIssuePointHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateAutoIssuePointResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pointAutoNum)) {
      body["pointAutoNum"] = request.pointAutoNum;
    }

    if (!Util.isUnset(request.pointAutoState)) {
      body["pointAutoState"] = request.pointAutoState;
    }

    if (!Util.isUnset(request.pointAutoTime)) {
      body["pointAutoTime"] = request.pointAutoTime;
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
      action: "UpdateAutoIssuePoint",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/points/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateAutoIssuePointResponse>(await this.execute(params, req, runtime), new UpdateAutoIssuePointResponse({}));
  }

  async updateAutoIssuePoint(request: UpdateAutoIssuePointRequest): Promise<UpdateAutoIssuePointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateAutoIssuePointHeaders({ });
    return await this.updateAutoIssuePointWithOptions(request, headers, runtime);
  }

  async updatePointActionAutoAssignRuleWithOptions(request: UpdatePointActionAutoAssignRuleRequest, headers: UpdatePointActionAutoAssignRuleHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePointActionAutoAssignRuleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.updatePointRuleRequestDTOList)) {
      body["updatePointRuleRequestDTOList"] = request.updatePointRuleRequestDTOList;
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
      action: "UpdatePointActionAutoAssignRule",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/users/points/actionRules`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdatePointActionAutoAssignRuleResponse>(await this.execute(params, req, runtime), new UpdatePointActionAutoAssignRuleResponse({}));
  }

  async updatePointActionAutoAssignRule(request: UpdatePointActionAutoAssignRuleRequest): Promise<UpdatePointActionAutoAssignRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePointActionAutoAssignRuleHeaders({ });
    return await this.updatePointActionAutoAssignRuleWithOptions(request, headers, runtime);
  }

  async wearOrgHonorWithOptions(honorId: string, request: WearOrgHonorRequest, headers: WearOrgHonorHeaders, runtime: $Util.RuntimeOptions): Promise<WearOrgHonorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.wear)) {
      body["wear"] = request.wear;
    }

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
      action: "WearOrgHonor",
      version: "orgCulture_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/orgCulture/honors/${honorId}/wear`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<WearOrgHonorResponse>(await this.execute(params, req, runtime), new WearOrgHonorResponse({}));
  }

  async wearOrgHonor(honorId: string, request: WearOrgHonorRequest): Promise<WearOrgHonorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new WearOrgHonorHeaders({ });
    return await this.wearOrgHonorWithOptions(honorId, request, headers, runtime);
  }

}
