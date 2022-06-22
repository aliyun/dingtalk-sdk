// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddHrmPreentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequest extends $tea.Model {
  agentId?: number;
  groups?: AddHrmPreentryRequestGroups[];
  mobile?: string;
  name?: string;
  preEntryTime?: number;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      groups: 'groups',
      mobile: 'mobile',
      name: 'name',
      preEntryTime: 'preEntryTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      groups: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroups },
      mobile: 'string',
      name: 'string',
      preEntryTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryResponseBody extends $tea.Model {
  tmpUserId?: string;
  static names(): { [key: string]: string } {
    return {
      tmpUserId: 'tmpUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tmpUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddHrmPreentryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddHrmPreentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ECertQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ECertQueryRequest extends $tea.Model {
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

export class ECertQueryResponseBody extends $tea.Model {
  certNO?: string;
  employJobId?: string;
  employJobIdLabel?: string;
  employPositionId?: string;
  employPositionIdLabel?: string;
  employPositionRankId?: string;
  employPositionRankIdLabel?: string;
  hiredDate?: string;
  lastWorkDay?: string;
  mainDeptId?: number;
  mainDeptName?: string;
  name?: string;
  realName?: string;
  terminationReasonPassive?: string[];
  terminationReasonVoluntary?: string[];
  static names(): { [key: string]: string } {
    return {
      certNO: 'certNO',
      employJobId: 'employJobId',
      employJobIdLabel: 'employJobIdLabel',
      employPositionId: 'employPositionId',
      employPositionIdLabel: 'employPositionIdLabel',
      employPositionRankId: 'employPositionRankId',
      employPositionRankIdLabel: 'employPositionRankIdLabel',
      hiredDate: 'hiredDate',
      lastWorkDay: 'lastWorkDay',
      mainDeptId: 'mainDeptId',
      mainDeptName: 'mainDeptName',
      name: 'name',
      realName: 'realName',
      terminationReasonPassive: 'terminationReasonPassive',
      terminationReasonVoluntary: 'terminationReasonVoluntary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certNO: 'string',
      employJobId: 'string',
      employJobIdLabel: 'string',
      employPositionId: 'string',
      employPositionIdLabel: 'string',
      employPositionRankId: 'string',
      employPositionRankIdLabel: 'string',
      hiredDate: 'string',
      lastWorkDay: 'string',
      mainDeptId: 'number',
      mainDeptName: 'string',
      name: 'string',
      realName: 'string',
      terminationReasonPassive: { 'type': 'array', 'itemType': 'string' },
      terminationReasonVoluntary: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ECertQueryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ECertQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ECertQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTransferHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTransferRequest extends $tea.Model {
  deptIdsAfterTransfer?: number[];
  jobIdAfterTransfer?: string;
  mainDeptIdAfterTransfer?: number;
  operateUserId?: string;
  positionIdAfterTransfer?: string;
  positionLevelAfterTransfer?: string;
  positionNameAfterTransfer?: string;
  rankIdAfterTransfer?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptIdsAfterTransfer: 'deptIdsAfterTransfer',
      jobIdAfterTransfer: 'jobIdAfterTransfer',
      mainDeptIdAfterTransfer: 'mainDeptIdAfterTransfer',
      operateUserId: 'operateUserId',
      positionIdAfterTransfer: 'positionIdAfterTransfer',
      positionLevelAfterTransfer: 'positionLevelAfterTransfer',
      positionNameAfterTransfer: 'positionNameAfterTransfer',
      rankIdAfterTransfer: 'rankIdAfterTransfer',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdsAfterTransfer: { 'type': 'array', 'itemType': 'number' },
      jobIdAfterTransfer: 'string',
      mainDeptIdAfterTransfer: 'number',
      operateUserId: 'string',
      positionIdAfterTransfer: 'string',
      positionLevelAfterTransfer: 'string',
      positionNameAfterTransfer: 'string',
      rankIdAfterTransfer: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTransferResponseBody extends $tea.Model {
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

export class HrmProcessTransferResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HrmProcessTransferResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HrmProcessTransferResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryRequest extends $tea.Model {
  bizUK?: string;
  maxResults?: number;
  nextToken?: number;
  optUserId?: string;
  queryParams?: MasterDataQueryRequestQueryParams[];
  relationIds?: string[];
  scopeCode?: string;
  tenantId?: number;
  viewEntityCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizUK: 'bizUK',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      optUserId: 'optUserId',
      queryParams: 'queryParams',
      relationIds: 'relationIds',
      scopeCode: 'scopeCode',
      tenantId: 'tenantId',
      viewEntityCode: 'viewEntityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizUK: 'string',
      maxResults: 'number',
      nextToken: 'number',
      optUserId: 'string',
      queryParams: { 'type': 'array', 'itemType': MasterDataQueryRequestQueryParams },
      relationIds: { 'type': 'array', 'itemType': 'string' },
      scopeCode: 'string',
      tenantId: 'number',
      viewEntityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  result?: MasterDataQueryResponseBodyResult[];
  success?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      result: 'result',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      result: { 'type': 'array', 'itemType': MasterDataQueryResponseBodyResult },
      success: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: MasterDataQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MasterDataQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequest extends $tea.Model {
  body?: MasterDataSaveRequestBody[];
  tenantId?: number;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      tenantId: 'tenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': MasterDataSaveRequestBody },
      tenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveResponseBody extends $tea.Model {
  allSuccess?: boolean;
  failResult?: MasterDataSaveResponseBodyFailResult[];
  static names(): { [key: string]: string } {
    return {
      allSuccess: 'allSuccess',
      failResult: 'failResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allSuccess: 'boolean',
      failResult: { 'type': 'array', 'itemType': MasterDataSaveResponseBodyFailResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: MasterDataSaveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MasterDataSaveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyRequest extends $tea.Model {
  entityCode?: string;
  scopeCode?: string;
  static names(): { [key: string]: string } {
    return {
      entityCode: 'entityCode',
      scopeCode: 'scopeCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      entityCode: 'string',
      scopeCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyResponseBody extends $tea.Model {
  result?: MasterDataTenantQueyResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': MasterDataTenantQueyResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: MasterDataTenantQueyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MasterDataTenantQueyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryCustomEntryProcessesResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCustomEntryProcessesResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCustomEntryProcessesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCustomEntryProcessesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoRequest extends $tea.Model {
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoShrinkRequest extends $tea.Model {
  userIdListShrink?: string;
  static names(): { [key: string]: string } {
    return {
      userIdListShrink: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIdListShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponseBody extends $tea.Model {
  result?: QueryHrmEmployeeDismissionInfoResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryHrmEmployeeDismissionInfoResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHrmEmployeeDismissionInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHrmEmployeeDismissionInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  rankCategoryId?: string;
  rankCode?: string;
  rankName?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      rankCategoryId: 'rankCategoryId',
      rankCode: 'rankCode',
      rankName: 'rankName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      rankCategoryId: 'string',
      rankCode: 'string',
      rankName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryJobRanksResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryJobRanksResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryJobRanksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryJobRanksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsRequest extends $tea.Model {
  jobName?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      jobName: 'jobName',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobName: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryJobsResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryJobsResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryJobsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryJobsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsRequest extends $tea.Model {
  deptId?: number;
  inCategoryIds?: string[];
  inPositionIds?: string[];
  positionName?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      inCategoryIds: 'inCategoryIds',
      inPositionIds: 'inPositionIds',
      positionName: 'positionName',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      inCategoryIds: { 'type': 'array', 'itemType': 'string' },
      inPositionIds: { 'type': 'array', 'itemType': 'string' },
      positionName: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryPositionsResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryPositionsResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPositionsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPositionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskInitHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskInitRequest extends $tea.Model {
  category?: string;
  claimTime?: number;
  description?: string;
  finishTime?: number;
  outerId?: string;
  status?: string;
  title?: string;
  userId?: string;
  solutionType?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      claimTime: 'claimTime',
      description: 'description',
      finishTime: 'finishTime',
      outerId: 'outerId',
      status: 'status',
      title: 'title',
      userId: 'userId',
      solutionType: 'solutionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      claimTime: 'number',
      description: 'string',
      finishTime: 'number',
      outerId: 'string',
      status: 'string',
      title: 'string',
      userId: 'string',
      solutionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskInitResponseBody extends $tea.Model {
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

export class SolutionTaskInitResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SolutionTaskInitResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SolutionTaskInitResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskSaveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskSaveRequest extends $tea.Model {
  claimTime?: number;
  description?: string;
  finishTime?: number;
  outerId?: string;
  solutionInstanceId?: string;
  startTime?: number;
  status?: string;
  taskType?: string;
  templateOuterId?: string;
  title?: string;
  userId?: string;
  solutionType?: string;
  static names(): { [key: string]: string } {
    return {
      claimTime: 'claimTime',
      description: 'description',
      finishTime: 'finishTime',
      outerId: 'outerId',
      solutionInstanceId: 'solutionInstanceId',
      startTime: 'startTime',
      status: 'status',
      taskType: 'taskType',
      templateOuterId: 'templateOuterId',
      title: 'title',
      userId: 'userId',
      solutionType: 'solutionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      claimTime: 'number',
      description: 'string',
      finishTime: 'number',
      outerId: 'string',
      solutionInstanceId: 'string',
      startTime: 'number',
      status: 'string',
      taskType: 'string',
      templateOuterId: 'string',
      title: 'string',
      userId: 'string',
      solutionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskSaveResponseBody extends $tea.Model {
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

export class SolutionTaskSaveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SolutionTaskSaveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SolutionTaskSaveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateRequest extends $tea.Model {
  delete?: boolean;
  des?: string;
  ext?: string;
  name?: string;
  optUserId?: string;
  outerId?: string;
  taskScopeVO?: SyncTaskTemplateRequestTaskScopeVO;
  taskType?: string;
  solutionType?: string;
  static names(): { [key: string]: string } {
    return {
      delete: 'delete',
      des: 'des',
      ext: 'ext',
      name: 'name',
      optUserId: 'optUserId',
      outerId: 'outerId',
      taskScopeVO: 'taskScopeVO',
      taskType: 'taskType',
      solutionType: 'solutionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delete: 'boolean',
      des: 'string',
      ext: 'string',
      name: 'string',
      optUserId: 'string',
      outerId: 'string',
      taskScopeVO: SyncTaskTemplateRequestTaskScopeVO,
      taskType: 'string',
      solutionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateResponseBody extends $tea.Model {
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

export class SyncTaskTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SyncTaskTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SyncTaskTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList extends $tea.Model {
  fieldCode?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSections extends $tea.Model {
  empFieldVOList?: AddHrmPreentryRequestGroupsSectionsEmpFieldVOList[];
  oldIndex?: number;
  static names(): { [key: string]: string } {
    return {
      empFieldVOList: 'empFieldVOList',
      oldIndex: 'oldIndex',
    };
  }

  static types(): { [key: string]: any } {
    return {
      empFieldVOList: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroupsSectionsEmpFieldVOList },
      oldIndex: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroups extends $tea.Model {
  groupId?: string;
  sections?: AddHrmPreentryRequestGroupsSections[];
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      sections: 'sections',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
      sections: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroupsSections },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryRequestQueryParamsConditionList extends $tea.Model {
  operate?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      operate: 'operate',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operate: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryRequestQueryParams extends $tea.Model {
  conditionList?: MasterDataQueryRequestQueryParamsConditionList[];
  fieldCode?: string;
  joinType?: string;
  static names(): { [key: string]: string } {
    return {
      conditionList: 'conditionList',
      fieldCode: 'fieldCode',
      joinType: 'joinType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conditionList: { 'type': 'array', 'itemType': MasterDataQueryRequestQueryParamsConditionList },
      fieldCode: 'string',
      joinType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO extends $tea.Model {
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

export class MasterDataQueryResponseBodyResultViewEntityFieldVOList extends $tea.Model {
  fieldCode?: string;
  fieldDataVO?: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO;
  fieldName?: string;
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldDataVO: 'fieldDataVO',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldDataVO: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO,
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBodyResult extends $tea.Model {
  outerId?: string;
  relationId?: string;
  scopeCode?: string;
  viewEntityCode?: string;
  viewEntityFieldVOList?: MasterDataQueryResponseBodyResultViewEntityFieldVOList[];
  static names(): { [key: string]: string } {
    return {
      outerId: 'outerId',
      relationId: 'relationId',
      scopeCode: 'scopeCode',
      viewEntityCode: 'viewEntityCode',
      viewEntityFieldVOList: 'viewEntityFieldVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outerId: 'string',
      relationId: 'string',
      scopeCode: 'string',
      viewEntityCode: 'string',
      viewEntityFieldVOList: { 'type': 'array', 'itemType': MasterDataQueryResponseBodyResultViewEntityFieldVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequestBodyFieldList extends $tea.Model {
  name?: string;
  valueStr?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      valueStr: 'valueStr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      valueStr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequestBodyScope extends $tea.Model {
  scopeCode?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      scopeCode: 'scopeCode',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeCode: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequestBody extends $tea.Model {
  bizTime?: number;
  bizUk?: string;
  entityCode?: string;
  fieldList?: MasterDataSaveRequestBodyFieldList[];
  scope?: MasterDataSaveRequestBodyScope;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizTime: 'bizTime',
      bizUk: 'bizUk',
      entityCode: 'entityCode',
      fieldList: 'fieldList',
      scope: 'scope',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTime: 'number',
      bizUk: 'string',
      entityCode: 'string',
      fieldList: { 'type': 'array', 'itemType': MasterDataSaveRequestBodyFieldList },
      scope: MasterDataSaveRequestBodyScope,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveResponseBodyFailResult extends $tea.Model {
  bizUk?: string;
  errorCode?: string;
  errorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizUk: 'bizUk',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizUk: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyResponseBodyResult extends $tea.Model {
  hasData?: boolean;
  integrateDataAuth?: boolean;
  name?: string;
  readAuth?: boolean;
  tenantId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      hasData: 'hasData',
      integrateDataAuth: 'integrateDataAuth',
      name: 'name',
      readAuth: 'readAuth',
      tenantId: 'tenantId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasData: 'boolean',
      integrateDataAuth: 'boolean',
      name: 'string',
      readAuth: 'boolean',
      tenantId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponseBodyList extends $tea.Model {
  formDesc?: string;
  formId?: string;
  formName?: string;
  shortUrl?: string;
  static names(): { [key: string]: string } {
    return {
      formDesc: 'formDesc',
      formId: 'formId',
      formName: 'formName',
      shortUrl: 'shortUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formDesc: 'string',
      formId: 'string',
      formName: 'string',
      shortUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList extends $tea.Model {
  deptId?: number;
  deptPath?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'dept_id',
      deptPath: 'dept_path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptPath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponseBodyResult extends $tea.Model {
  deptList?: QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList[];
  handoverUserId?: string;
  lastWorkDay?: number;
  mainDeptId?: number;
  mainDeptName?: string;
  passiveReason?: string[];
  preStatus?: number;
  reasonMemo?: string;
  status?: number;
  userId?: string;
  voluntaryReason?: string[];
  static names(): { [key: string]: string } {
    return {
      deptList: 'deptList',
      handoverUserId: 'handoverUserId',
      lastWorkDay: 'lastWorkDay',
      mainDeptId: 'mainDeptId',
      mainDeptName: 'mainDeptName',
      passiveReason: 'passiveReason',
      preStatus: 'preStatus',
      reasonMemo: 'reasonMemo',
      status: 'status',
      userId: 'userId',
      voluntaryReason: 'voluntaryReason',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptList: { 'type': 'array', 'itemType': QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList },
      handoverUserId: 'string',
      lastWorkDay: 'number',
      mainDeptId: 'number',
      mainDeptName: 'string',
      passiveReason: { 'type': 'array', 'itemType': 'string' },
      preStatus: 'number',
      reasonMemo: 'string',
      status: 'number',
      userId: 'string',
      voluntaryReason: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponseBodyList extends $tea.Model {
  maxJobGrade?: number;
  minJobGrade?: number;
  rankCategoryId?: string;
  rankCode?: string;
  rankDescription?: string;
  rankId?: string;
  rankName?: string;
  static names(): { [key: string]: string } {
    return {
      maxJobGrade: 'maxJobGrade',
      minJobGrade: 'minJobGrade',
      rankCategoryId: 'rankCategoryId',
      rankCode: 'rankCode',
      rankDescription: 'rankDescription',
      rankId: 'rankId',
      rankName: 'rankName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxJobGrade: 'number',
      minJobGrade: 'number',
      rankCategoryId: 'string',
      rankCode: 'string',
      rankDescription: 'string',
      rankId: 'string',
      rankName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponseBodyList extends $tea.Model {
  jobDescription?: string;
  jobId?: string;
  jobName?: string;
  static names(): { [key: string]: string } {
    return {
      jobDescription: 'jobDescription',
      jobId: 'jobId',
      jobName: 'jobName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobDescription: 'string',
      jobId: 'string',
      jobName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponseBodyList extends $tea.Model {
  jobId?: string;
  positionCategoryId?: string;
  positionDes?: string;
  positionId?: string;
  positionName?: string;
  rankIdList?: string[];
  status?: number;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      positionCategoryId: 'positionCategoryId',
      positionDes: 'positionDes',
      positionId: 'positionId',
      positionName: 'positionName',
      rankIdList: 'rankIdList',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
      positionCategoryId: 'string',
      positionDes: 'string',
      positionId: 'string',
      positionName: 'string',
      rankIdList: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateRequestTaskScopeVO extends $tea.Model {
  deptIds?: number[];
  positionIds?: string[];
  roleIds?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      positionIds: 'positionIds',
      roleIds: 'roleIds',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      positionIds: { 'type': 'array', 'itemType': 'string' },
      roleIds: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
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


  async addHrmPreentry(request: AddHrmPreentryRequest): Promise<AddHrmPreentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddHrmPreentryHeaders({ });
    return await this.addHrmPreentryWithOptions(request, headers, runtime);
  }

  async addHrmPreentryWithOptions(request: AddHrmPreentryRequest, headers: AddHrmPreentryHeaders, runtime: $Util.RuntimeOptions): Promise<AddHrmPreentryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.groups)) {
      body["groups"] = request.groups;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.preEntryTime)) {
      body["preEntryTime"] = request.preEntryTime;
    }

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
    return $tea.cast<AddHrmPreentryResponse>(await this.doROARequest("AddHrmPreentry", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/preentries`, "json", req, runtime), new AddHrmPreentryResponse({}));
  }

  async eCertQuery(request: ECertQueryRequest): Promise<ECertQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ECertQueryHeaders({ });
    return await this.eCertQueryWithOptions(request, headers, runtime);
  }

  async eCertQueryWithOptions(request: ECertQueryRequest, headers: ECertQueryHeaders, runtime: $Util.RuntimeOptions): Promise<ECertQueryResponse> {
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
    return $tea.cast<ECertQueryResponse>(await this.doROARequest("ECertQuery", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/eCerts`, "json", req, runtime), new ECertQueryResponse({}));
  }

  async hrmProcessTransfer(request: HrmProcessTransferRequest): Promise<HrmProcessTransferResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessTransferHeaders({ });
    return await this.hrmProcessTransferWithOptions(request, headers, runtime);
  }

  async hrmProcessTransferWithOptions(request: HrmProcessTransferRequest, headers: HrmProcessTransferHeaders, runtime: $Util.RuntimeOptions): Promise<HrmProcessTransferResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIdsAfterTransfer)) {
      body["deptIdsAfterTransfer"] = request.deptIdsAfterTransfer;
    }

    if (!Util.isUnset(request.jobIdAfterTransfer)) {
      body["jobIdAfterTransfer"] = request.jobIdAfterTransfer;
    }

    if (!Util.isUnset(request.mainDeptIdAfterTransfer)) {
      body["mainDeptIdAfterTransfer"] = request.mainDeptIdAfterTransfer;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    if (!Util.isUnset(request.positionIdAfterTransfer)) {
      body["positionIdAfterTransfer"] = request.positionIdAfterTransfer;
    }

    if (!Util.isUnset(request.positionLevelAfterTransfer)) {
      body["positionLevelAfterTransfer"] = request.positionLevelAfterTransfer;
    }

    if (!Util.isUnset(request.positionNameAfterTransfer)) {
      body["positionNameAfterTransfer"] = request.positionNameAfterTransfer;
    }

    if (!Util.isUnset(request.rankIdAfterTransfer)) {
      body["rankIdAfterTransfer"] = request.rankIdAfterTransfer;
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
    return $tea.cast<HrmProcessTransferResponse>(await this.doROARequest("HrmProcessTransfer", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/processes/transfer`, "json", req, runtime), new HrmProcessTransferResponse({}));
  }

  async masterDataQuery(request: MasterDataQueryRequest): Promise<MasterDataQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataQueryHeaders({ });
    return await this.masterDataQueryWithOptions(request, headers, runtime);
  }

  async masterDataQueryWithOptions(request: MasterDataQueryRequest, headers: MasterDataQueryHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizUK)) {
      body["bizUK"] = request.bizUK;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.queryParams)) {
      body["queryParams"] = request.queryParams;
    }

    if (!Util.isUnset(request.relationIds)) {
      body["relationIds"] = request.relationIds;
    }

    if (!Util.isUnset(request.scopeCode)) {
      body["scopeCode"] = request.scopeCode;
    }

    if (!Util.isUnset(request.tenantId)) {
      body["tenantId"] = request.tenantId;
    }

    if (!Util.isUnset(request.viewEntityCode)) {
      body["viewEntityCode"] = request.viewEntityCode;
    }

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
    return $tea.cast<MasterDataQueryResponse>(await this.doROARequest("MasterDataQuery", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/masters/datas/query`, "json", req, runtime), new MasterDataQueryResponse({}));
  }

  async masterDataSave(request: MasterDataSaveRequest): Promise<MasterDataSaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataSaveHeaders({ });
    return await this.masterDataSaveWithOptions(request, headers, runtime);
  }

  async masterDataSaveWithOptions(request: MasterDataSaveRequest, headers: MasterDataSaveHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataSaveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantId)) {
      query["tenantId"] = request.tenantId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
      body: Util.toArray(request.body),
    });
    return $tea.cast<MasterDataSaveResponse>(await this.doROARequest("MasterDataSave", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/masters/datas/save`, "json", req, runtime), new MasterDataSaveResponse({}));
  }

  async masterDataTenantQuey(request: MasterDataTenantQueyRequest): Promise<MasterDataTenantQueyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataTenantQueyHeaders({ });
    return await this.masterDataTenantQueyWithOptions(request, headers, runtime);
  }

  async masterDataTenantQueyWithOptions(request: MasterDataTenantQueyRequest, headers: MasterDataTenantQueyHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataTenantQueyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.entityCode)) {
      query["entityCode"] = request.entityCode;
    }

    if (!Util.isUnset(request.scopeCode)) {
      query["scopeCode"] = request.scopeCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<MasterDataTenantQueyResponse>(await this.doROARequest("MasterDataTenantQuey", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/masters/tenants`, "json", req, runtime), new MasterDataTenantQueyResponse({}));
  }

  async queryCustomEntryProcesses(request: QueryCustomEntryProcessesRequest): Promise<QueryCustomEntryProcessesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomEntryProcessesHeaders({ });
    return await this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
  }

  async queryCustomEntryProcessesWithOptions(request: QueryCustomEntryProcessesRequest, headers: QueryCustomEntryProcessesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomEntryProcessesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operateUserId)) {
      query["operateUserId"] = request.operateUserId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCustomEntryProcessesResponse>(await this.doROARequest("QueryCustomEntryProcesses", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/customEntryProcesses`, "json", req, runtime), new QueryCustomEntryProcessesResponse({}));
  }

  async queryHrmEmployeeDismissionInfo(request: QueryHrmEmployeeDismissionInfoRequest): Promise<QueryHrmEmployeeDismissionInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHrmEmployeeDismissionInfoHeaders({ });
    return await this.queryHrmEmployeeDismissionInfoWithOptions(request, headers, runtime);
  }

  async queryHrmEmployeeDismissionInfoWithOptions(tmpReq: QueryHrmEmployeeDismissionInfoRequest, headers: QueryHrmEmployeeDismissionInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHrmEmployeeDismissionInfoResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryHrmEmployeeDismissionInfoShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.userIdList)) {
      request.userIdListShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.userIdList, "userIdList", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIdListShrink)) {
      query["userIdList"] = request.userIdListShrink;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryHrmEmployeeDismissionInfoResponse>(await this.doROARequest("QueryHrmEmployeeDismissionInfo", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/employees/dimissionInfos`, "json", req, runtime), new QueryHrmEmployeeDismissionInfoResponse({}));
  }

  async queryJobRanks(request: QueryJobRanksRequest): Promise<QueryJobRanksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobRanksHeaders({ });
    return await this.queryJobRanksWithOptions(request, headers, runtime);
  }

  async queryJobRanksWithOptions(request: QueryJobRanksRequest, headers: QueryJobRanksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobRanksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.rankCategoryId)) {
      query["rankCategoryId"] = request.rankCategoryId;
    }

    if (!Util.isUnset(request.rankCode)) {
      query["rankCode"] = request.rankCode;
    }

    if (!Util.isUnset(request.rankName)) {
      query["rankName"] = request.rankName;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryJobRanksResponse>(await this.doROARequest("QueryJobRanks", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/jobRanks`, "json", req, runtime), new QueryJobRanksResponse({}));
  }

  async queryJobs(request: QueryJobsRequest): Promise<QueryJobsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobsHeaders({ });
    return await this.queryJobsWithOptions(request, headers, runtime);
  }

  async queryJobsWithOptions(request: QueryJobsRequest, headers: QueryJobsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobName)) {
      query["jobName"] = request.jobName;
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
    return $tea.cast<QueryJobsResponse>(await this.doROARequest("QueryJobs", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/jobs`, "json", req, runtime), new QueryJobsResponse({}));
  }

  async queryPositions(request: QueryPositionsRequest): Promise<QueryPositionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPositionsHeaders({ });
    return await this.queryPositionsWithOptions(request, headers, runtime);
  }

  async queryPositionsWithOptions(request: QueryPositionsRequest, headers: QueryPositionsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPositionsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.inCategoryIds)) {
      body["inCategoryIds"] = request.inCategoryIds;
    }

    if (!Util.isUnset(request.inPositionIds)) {
      body["inPositionIds"] = request.inPositionIds;
    }

    if (!Util.isUnset(request.positionName)) {
      body["positionName"] = request.positionName;
    }

    let realHeaders : {[key: string ]: string} = { };
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
    return $tea.cast<QueryPositionsResponse>(await this.doROARequest("QueryPositions", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/positions/query`, "json", req, runtime), new QueryPositionsResponse({}));
  }

  async solutionTaskInit(request: SolutionTaskInitRequest): Promise<SolutionTaskInitResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SolutionTaskInitHeaders({ });
    return await this.solutionTaskInitWithOptions(request, headers, runtime);
  }

  async solutionTaskInitWithOptions(request: SolutionTaskInitRequest, headers: SolutionTaskInitHeaders, runtime: $Util.RuntimeOptions): Promise<SolutionTaskInitResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.solutionType)) {
      query["solutionType"] = request.solutionType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.claimTime)) {
      body["claimTime"] = request.claimTime;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.finishTime)) {
      body["finishTime"] = request.finishTime;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<SolutionTaskInitResponse>(await this.doROARequest("SolutionTaskInit", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/solutions/tasks/init`, "json", req, runtime), new SolutionTaskInitResponse({}));
  }

  async solutionTaskSave(request: SolutionTaskSaveRequest): Promise<SolutionTaskSaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SolutionTaskSaveHeaders({ });
    return await this.solutionTaskSaveWithOptions(request, headers, runtime);
  }

  async solutionTaskSaveWithOptions(request: SolutionTaskSaveRequest, headers: SolutionTaskSaveHeaders, runtime: $Util.RuntimeOptions): Promise<SolutionTaskSaveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.solutionType)) {
      query["solutionType"] = request.solutionType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.claimTime)) {
      body["claimTime"] = request.claimTime;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.finishTime)) {
      body["finishTime"] = request.finishTime;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.solutionInstanceId)) {
      body["solutionInstanceId"] = request.solutionInstanceId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
    }

    if (!Util.isUnset(request.templateOuterId)) {
      body["templateOuterId"] = request.templateOuterId;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<SolutionTaskSaveResponse>(await this.doROARequest("SolutionTaskSave", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/solutions/tasks/save`, "json", req, runtime), new SolutionTaskSaveResponse({}));
  }

  async syncTaskTemplate(request: SyncTaskTemplateRequest): Promise<SyncTaskTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTaskTemplateHeaders({ });
    return await this.syncTaskTemplateWithOptions(request, headers, runtime);
  }

  async syncTaskTemplateWithOptions(request: SyncTaskTemplateRequest, headers: SyncTaskTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<SyncTaskTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.solutionType)) {
      query["solutionType"] = request.solutionType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.delete)) {
      body["delete"] = request.delete;
    }

    if (!Util.isUnset(request.des)) {
      body["des"] = request.des;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset($tea.toMap(request.taskScopeVO))) {
      body["taskScopeVO"] = request.taskScopeVO;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
    }

    let realHeaders : {[key: string ]: string} = { };
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
    return $tea.cast<SyncTaskTemplateResponse>(await this.doROARequest("SyncTaskTemplate", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/solutions/tasks/templates/sync`, "json", req, runtime), new SyncTaskTemplateResponse({}));
  }

}
