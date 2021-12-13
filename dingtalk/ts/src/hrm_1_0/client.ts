// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  realName?: string;
  certNO?: string;
  mainDeptId?: number;
  mainDeptName?: string;
  employJobId?: string;
  employJobIdLabel?: string;
  employPositionId?: string;
  employPositionIdLabel?: string;
  employPositionRankId?: string;
  employPositionRankIdLabel?: string;
  hiredDate?: string;
  lastWorkDay?: string;
  terminationReasonVoluntary?: string[];
  terminationReasonPassive?: string[];
  name?: string;
  static names(): { [key: string]: string } {
    return {
      realName: 'realName',
      certNO: 'certNO',
      mainDeptId: 'mainDeptId',
      mainDeptName: 'mainDeptName',
      employJobId: 'employJobId',
      employJobIdLabel: 'employJobIdLabel',
      employPositionId: 'employPositionId',
      employPositionIdLabel: 'employPositionIdLabel',
      employPositionRankId: 'employPositionRankId',
      employPositionRankIdLabel: 'employPositionRankIdLabel',
      hiredDate: 'hiredDate',
      lastWorkDay: 'lastWorkDay',
      terminationReasonVoluntary: 'terminationReasonVoluntary',
      terminationReasonPassive: 'terminationReasonPassive',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      realName: 'string',
      certNO: 'string',
      mainDeptId: 'number',
      mainDeptName: 'string',
      employJobId: 'string',
      employJobIdLabel: 'string',
      employPositionId: 'string',
      employPositionIdLabel: 'string',
      employPositionRankId: 'string',
      employPositionRankIdLabel: 'string',
      hiredDate: 'string',
      lastWorkDay: 'string',
      terminationReasonVoluntary: { 'type': 'array', 'itemType': 'string' },
      terminationReasonPassive: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
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
  rankCategoryId?: string;
  rankCode?: string;
  rankName?: string;
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      rankCategoryId: 'rankCategoryId',
      rankCode: 'rankCode',
      rankName: 'rankName',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rankCategoryId: 'string',
      rankCode: 'string',
      rankName: 'string',
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponseBody extends $tea.Model {
  nextToken?: number;
  hasMore?: boolean;
  list?: QueryJobRanksResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryJobRanksResponseBodyList },
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
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      jobName: 'jobName',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobName: 'string',
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponseBody extends $tea.Model {
  nextToken?: number;
  hasMore?: boolean;
  list?: QueryJobsResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryJobsResponseBodyList },
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
  operateUserId?: string;
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      operateUserId: 'operateUserId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operateUserId: 'string',
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponseBody extends $tea.Model {
  nextToken?: number;
  hasMore?: boolean;
  list?: QueryCustomEntryProcessesResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCustomEntryProcessesResponseBodyList },
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
  positionName?: string;
  inCategoryIds?: string[];
  inPositionIds?: string[];
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      positionName: 'positionName',
      inCategoryIds: 'inCategoryIds',
      inPositionIds: 'inPositionIds',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      positionName: 'string',
      inCategoryIds: { 'type': 'array', 'itemType': 'string' },
      inPositionIds: { 'type': 'array', 'itemType': 'string' },
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponseBody extends $tea.Model {
  nextToken?: number;
  hasMore?: boolean;
  list?: QueryPositionsResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryPositionsResponseBodyList },
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
  scopeCode?: string;
  viewEntityCode?: string;
  tenantId?: number;
  bizUK?: string;
  relationIds?: string[];
  optUserId?: string;
  nextToken?: number;
  maxResults?: number;
  queryParams?: MasterDataQueryRequestQueryParams[];
  static names(): { [key: string]: string } {
    return {
      scopeCode: 'scopeCode',
      viewEntityCode: 'viewEntityCode',
      tenantId: 'tenantId',
      bizUK: 'bizUK',
      relationIds: 'relationIds',
      optUserId: 'optUserId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      queryParams: 'queryParams',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeCode: 'string',
      viewEntityCode: 'string',
      tenantId: 'number',
      bizUK: 'string',
      relationIds: { 'type': 'array', 'itemType': 'string' },
      optUserId: 'string',
      nextToken: 'number',
      maxResults: 'number',
      queryParams: { 'type': 'array', 'itemType': MasterDataQueryRequestQueryParams },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBody extends $tea.Model {
  total?: number;
  hasMore?: boolean;
  nextToken?: number;
  success?: boolean;
  result?: MasterDataQueryResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      total: 'total',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      total: 'number',
      hasMore: 'boolean',
      nextToken: 'number',
      success: 'boolean',
      result: { 'type': 'array', 'itemType': MasterDataQueryResponseBodyResult },
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
  preEntryTime?: number;
  name?: string;
  mobile?: string;
  agentId?: number;
  groups?: AddHrmPreentryRequestGroups[];
  static names(): { [key: string]: string } {
    return {
      preEntryTime: 'preEntryTime',
      name: 'name',
      mobile: 'mobile',
      agentId: 'agentId',
      groups: 'groups',
    };
  }

  static types(): { [key: string]: any } {
    return {
      preEntryTime: 'number',
      name: 'string',
      mobile: 'string',
      agentId: 'number',
      groups: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroups },
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

export class QueryJobRanksResponseBodyList extends $tea.Model {
  rankId?: string;
  rankCategoryId?: string;
  rankCode?: string;
  rankName?: string;
  minJobGrade?: number;
  maxJobGrade?: number;
  rankDescription?: string;
  static names(): { [key: string]: string } {
    return {
      rankId: 'rankId',
      rankCategoryId: 'rankCategoryId',
      rankCode: 'rankCode',
      rankName: 'rankName',
      minJobGrade: 'minJobGrade',
      maxJobGrade: 'maxJobGrade',
      rankDescription: 'rankDescription',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rankId: 'string',
      rankCategoryId: 'string',
      rankCode: 'string',
      rankName: 'string',
      minJobGrade: 'number',
      maxJobGrade: 'number',
      rankDescription: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponseBodyList extends $tea.Model {
  jobId?: string;
  jobName?: string;
  jobDescription?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      jobName: 'jobName',
      jobDescription: 'jobDescription',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
      jobName: 'string',
      jobDescription: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponseBodyList extends $tea.Model {
  formId?: string;
  formName?: string;
  formDesc?: string;
  shortUrl?: string;
  static names(): { [key: string]: string } {
    return {
      formId: 'formId',
      formName: 'formName',
      formDesc: 'formDesc',
      shortUrl: 'shortUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formId: 'string',
      formName: 'string',
      formDesc: 'string',
      shortUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponseBodyList extends $tea.Model {
  positionId?: string;
  positionName?: string;
  positionCategoryId?: string;
  jobId?: string;
  positionDes?: string;
  rankIdList?: string[];
  status?: number;
  static names(): { [key: string]: string } {
    return {
      positionId: 'positionId',
      positionName: 'positionName',
      positionCategoryId: 'positionCategoryId',
      jobId: 'jobId',
      positionDes: 'positionDes',
      rankIdList: 'rankIdList',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      positionId: 'string',
      positionName: 'string',
      positionCategoryId: 'string',
      jobId: 'string',
      positionDes: 'string',
      rankIdList: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
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
  fieldCode?: string;
  joinType?: string;
  conditionList?: MasterDataQueryRequestQueryParamsConditionList[];
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      joinType: 'joinType',
      conditionList: 'conditionList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      joinType: 'string',
      conditionList: { 'type': 'array', 'itemType': MasterDataQueryRequestQueryParamsConditionList },
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
  scopeCode?: string;
  viewEntityCode?: string;
  viewEntityFieldVOList?: MasterDataQueryResponseBodyResultViewEntityFieldVOList[];
  relationId?: string;
  static names(): { [key: string]: string } {
    return {
      outerId: 'outerId',
      scopeCode: 'scopeCode',
      viewEntityCode: 'viewEntityCode',
      viewEntityFieldVOList: 'viewEntityFieldVOList',
      relationId: 'relationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outerId: 'string',
      scopeCode: 'string',
      viewEntityCode: 'string',
      viewEntityFieldVOList: { 'type': 'array', 'itemType': MasterDataQueryResponseBodyResultViewEntityFieldVOList },
      relationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList extends $tea.Model {
  value?: string;
  fieldCode?: string;
  static names(): { [key: string]: string } {
    return {
      value: 'value',
      fieldCode: 'fieldCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: 'string',
      fieldCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSections extends $tea.Model {
  oldIndex?: number;
  empFieldVOList?: AddHrmPreentryRequestGroupsSectionsEmpFieldVOList[];
  static names(): { [key: string]: string } {
    return {
      oldIndex: 'oldIndex',
      empFieldVOList: 'empFieldVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      oldIndex: 'number',
      empFieldVOList: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroupsSectionsEmpFieldVOList },
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ECertQueryResponse>(await this.doROARequest("ECertQuery", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/eCerts`, "json", req, runtime), new ECertQueryResponse({}));
  }

  async queryJobRanks(request: QueryJobRanksRequest): Promise<QueryJobRanksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobRanksHeaders({ });
    return await this.queryJobRanksWithOptions(request, headers, runtime);
  }

  async queryJobRanksWithOptions(request: QueryJobRanksRequest, headers: QueryJobRanksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobRanksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.rankCategoryId)) {
      query["rankCategoryId"] = request.rankCategoryId;
    }

    if (!Util.isUnset(request.rankCode)) {
      query["rankCode"] = request.rankCode;
    }

    if (!Util.isUnset(request.rankName)) {
      query["rankName"] = request.rankName;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<QueryJobsResponse>(await this.doROARequest("QueryJobs", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/jobs`, "json", req, runtime), new QueryJobsResponse({}));
  }

  async queryCustomEntryProcesses(request: QueryCustomEntryProcessesRequest): Promise<QueryCustomEntryProcessesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomEntryProcessesHeaders({ });
    return await this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
  }

  async queryCustomEntryProcessesWithOptions(request: QueryCustomEntryProcessesRequest, headers: QueryCustomEntryProcessesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomEntryProcessesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operateUserId)) {
      query["operateUserId"] = request.operateUserId;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<QueryCustomEntryProcessesResponse>(await this.doROARequest("QueryCustomEntryProcesses", "hrm_1.0", "HTTP", "GET", "AK", `/v1.0/hrm/customEntryProcesses`, "json", req, runtime), new QueryCustomEntryProcessesResponse({}));
  }

  async queryPositions(request: QueryPositionsRequest): Promise<QueryPositionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPositionsHeaders({ });
    return await this.queryPositionsWithOptions(request, headers, runtime);
  }

  async queryPositionsWithOptions(request: QueryPositionsRequest, headers: QueryPositionsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPositionsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.positionName)) {
      body["positionName"] = request.positionName;
    }

    if (!Util.isUnset(request.inCategoryIds)) {
      body["inCategoryIds"] = request.inCategoryIds;
    }

    if (!Util.isUnset(request.inPositionIds)) {
      body["inPositionIds"] = request.inPositionIds;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<QueryPositionsResponse>(await this.doROARequest("QueryPositions", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/positions/query`, "json", req, runtime), new QueryPositionsResponse({}));
  }

  async masterDataQuery(request: MasterDataQueryRequest): Promise<MasterDataQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataQueryHeaders({ });
    return await this.masterDataQueryWithOptions(request, headers, runtime);
  }

  async masterDataQueryWithOptions(request: MasterDataQueryRequest, headers: MasterDataQueryHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scopeCode)) {
      body["scopeCode"] = request.scopeCode;
    }

    if (!Util.isUnset(request.viewEntityCode)) {
      body["viewEntityCode"] = request.viewEntityCode;
    }

    if (!Util.isUnset(request.tenantId)) {
      body["tenantId"] = request.tenantId;
    }

    if (!Util.isUnset(request.bizUK)) {
      body["bizUK"] = request.bizUK;
    }

    if (!Util.isUnset(request.relationIds)) {
      body["relationIds"] = request.relationIds;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.queryParams)) {
      body["queryParams"] = request.queryParams;
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
    return $tea.cast<MasterDataQueryResponse>(await this.doROARequest("MasterDataQuery", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/masters/datas/query`, "json", req, runtime), new MasterDataQueryResponse({}));
  }

  async addHrmPreentry(request: AddHrmPreentryRequest): Promise<AddHrmPreentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddHrmPreentryHeaders({ });
    return await this.addHrmPreentryWithOptions(request, headers, runtime);
  }

  async addHrmPreentryWithOptions(request: AddHrmPreentryRequest, headers: AddHrmPreentryHeaders, runtime: $Util.RuntimeOptions): Promise<AddHrmPreentryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.preEntryTime)) {
      body["preEntryTime"] = request.preEntryTime;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.groups)) {
      body["groups"] = request.groups;
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
    return $tea.cast<AddHrmPreentryResponse>(await this.doROARequest("AddHrmPreentry", "hrm_1.0", "HTTP", "POST", "AK", `/v1.0/hrm/preentries`, "json", req, runtime), new AddHrmPreentryResponse({}));
  }

}
