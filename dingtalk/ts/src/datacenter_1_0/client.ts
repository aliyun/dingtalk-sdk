// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  body: PostCorpAuthInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryActiveUserStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryAnhmdStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryApprovalStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryAttendanceStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryBlackboardStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryCalendarStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryCheckinStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryCircleStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryCompanyBasicInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryDigitalDistrictOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryDingReciveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryDingSendStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryDocumentStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryDriveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryEmployeeTypeStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryEmployeeTypeStatisticalDataResponseBody,
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
  body: QueryGroupLiveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryGroupMessageStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryHealthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryMailStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMailStatisticalDataResponseBody,
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
  body: QueryOnlineUserStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryRedEnvelopeReciveStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryRedEnvelopeSendStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryReportStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QuerySingleMessageStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryTelMeetingStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryTodoStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryVedioMeetingStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydActiveDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydActiveMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydActiveWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydAppDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydAppMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydAppStdStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydAppWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydCalendarDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydCalendarMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydCalendarWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydDingMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydDingMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydDingMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydGroupMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydGroupMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydGroupMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydLogDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydLogMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydLogWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydMeetingDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydMeetingMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydMeetingWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydNoticeDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydNoticeMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydNoticeWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydSingleMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydSingleMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydSingleMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydToatlMsgDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydToatlMsgMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydToatlMsgWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTodoDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTodoMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTodoWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTotalDayStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTotalMonthStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTotalStdStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryYydTotalWeekStatisticalDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryYydTotalWeekStatisticalDataResponseBody,
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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async postCorpAuthInfo(): Promise<PostCorpAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PostCorpAuthInfoHeaders({ });
    return await this.postCorpAuthInfoWithOptions(headers, runtime);
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
    return $tea.cast<PostCorpAuthInfoResponse>(await this.doROARequest("PostCorpAuthInfo", "datacenter_1.0", "HTTP", "POST", "AK", `/v1.0/datacenter/corporations/authorize`, "json", req, runtime), new PostCorpAuthInfoResponse({}));
  }

  async queryActiveUserStatisticalData(request: QueryActiveUserStatisticalDataRequest): Promise<QueryActiveUserStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryActiveUserStatisticalDataHeaders({ });
    return await this.queryActiveUserStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryActiveUserStatisticalDataResponse>(await this.doROARequest("QueryActiveUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/activeUserData`, "json", req, runtime), new QueryActiveUserStatisticalDataResponse({}));
  }

  async queryAnhmdStatisticalData(request: QueryAnhmdStatisticalDataRequest): Promise<QueryAnhmdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAnhmdStatisticalDataHeaders({ });
    return await this.queryAnhmdStatisticalDataWithOptions(request, headers, runtime);
  }

  async queryAnhmdStatisticalDataWithOptions(request: QueryAnhmdStatisticalDataRequest, headers: QueryAnhmdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAnhmdStatisticalDataResponse> {
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
    return $tea.cast<QueryAnhmdStatisticalDataResponse>(await this.doROARequest("QueryAnhmdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/statisticDatas/anHmd`, "json", req, runtime), new QueryAnhmdStatisticalDataResponse({}));
  }

  async queryApprovalStatisticalData(request: QueryApprovalStatisticalDataRequest): Promise<QueryApprovalStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryApprovalStatisticalDataHeaders({ });
    return await this.queryApprovalStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryApprovalStatisticalDataResponse>(await this.doROARequest("QueryApprovalStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/approvalData`, "json", req, runtime), new QueryApprovalStatisticalDataResponse({}));
  }

  async queryAttendanceStatisticalData(request: QueryAttendanceStatisticalDataRequest): Promise<QueryAttendanceStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAttendanceStatisticalDataHeaders({ });
    return await this.queryAttendanceStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryAttendanceStatisticalDataResponse>(await this.doROARequest("QueryAttendanceStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/attendanceData`, "json", req, runtime), new QueryAttendanceStatisticalDataResponse({}));
  }

  async queryBlackboardStatisticalData(request: QueryBlackboardStatisticalDataRequest): Promise<QueryBlackboardStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBlackboardStatisticalDataHeaders({ });
    return await this.queryBlackboardStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryBlackboardStatisticalDataResponse>(await this.doROARequest("QueryBlackboardStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/blackboardData`, "json", req, runtime), new QueryBlackboardStatisticalDataResponse({}));
  }

  async queryCalendarStatisticalData(request: QueryCalendarStatisticalDataRequest): Promise<QueryCalendarStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCalendarStatisticalDataHeaders({ });
    return await this.queryCalendarStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryCalendarStatisticalDataResponse>(await this.doROARequest("QueryCalendarStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/calendarData`, "json", req, runtime), new QueryCalendarStatisticalDataResponse({}));
  }

  async queryCheckinStatisticalData(request: QueryCheckinStatisticalDataRequest): Promise<QueryCheckinStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCheckinStatisticalDataHeaders({ });
    return await this.queryCheckinStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryCheckinStatisticalDataResponse>(await this.doROARequest("QueryCheckinStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/checkinData`, "json", req, runtime), new QueryCheckinStatisticalDataResponse({}));
  }

  async queryCircleStatisticalData(request: QueryCircleStatisticalDataRequest): Promise<QueryCircleStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCircleStatisticalDataHeaders({ });
    return await this.queryCircleStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryCircleStatisticalDataResponse>(await this.doROARequest("QueryCircleStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/circleData`, "json", req, runtime), new QueryCircleStatisticalDataResponse({}));
  }

  async queryCompanyBasicInfo(request: QueryCompanyBasicInfoRequest): Promise<QueryCompanyBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCompanyBasicInfoHeaders({ });
    return await this.queryCompanyBasicInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryCompanyBasicInfoResponse>(await this.doROARequest("QueryCompanyBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/companies/basicInfo`, "json", req, runtime), new QueryCompanyBasicInfoResponse({}));
  }

  async queryDigitalDistrictOrgInfo(request: QueryDigitalDistrictOrgInfoRequest): Promise<QueryDigitalDistrictOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDigitalDistrictOrgInfoHeaders({ });
    return await this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryDigitalDistrictOrgInfoResponse>(await this.doROARequest("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", `/v1.0/datacenter/digitalCounty/orgInfos/query`, "json", req, runtime), new QueryDigitalDistrictOrgInfoResponse({}));
  }

  async queryDingReciveStatisticalData(request: QueryDingReciveStatisticalDataRequest): Promise<QueryDingReciveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDingReciveStatisticalDataHeaders({ });
    return await this.queryDingReciveStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryDingReciveStatisticalDataResponse>(await this.doROARequest("QueryDingReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/dingReciveData`, "json", req, runtime), new QueryDingReciveStatisticalDataResponse({}));
  }

  async queryDingSendStatisticalData(request: QueryDingSendStatisticalDataRequest): Promise<QueryDingSendStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDingSendStatisticalDataHeaders({ });
    return await this.queryDingSendStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryDingSendStatisticalDataResponse>(await this.doROARequest("QueryDingSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/dingSendData`, "json", req, runtime), new QueryDingSendStatisticalDataResponse({}));
  }

  async queryDocumentStatisticalData(request: QueryDocumentStatisticalDataRequest): Promise<QueryDocumentStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDocumentStatisticalDataHeaders({ });
    return await this.queryDocumentStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryDocumentStatisticalDataResponse>(await this.doROARequest("QueryDocumentStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/documentData`, "json", req, runtime), new QueryDocumentStatisticalDataResponse({}));
  }

  async queryDriveStatisticalData(request: QueryDriveStatisticalDataRequest): Promise<QueryDriveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDriveStatisticalDataHeaders({ });
    return await this.queryDriveStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryDriveStatisticalDataResponse>(await this.doROARequest("QueryDriveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/driveData`, "json", req, runtime), new QueryDriveStatisticalDataResponse({}));
  }

  async queryEmployeeTypeStatisticalData(request: QueryEmployeeTypeStatisticalDataRequest): Promise<QueryEmployeeTypeStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEmployeeTypeStatisticalDataHeaders({ });
    return await this.queryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryEmployeeTypeStatisticalDataResponse>(await this.doROARequest("QueryEmployeeTypeStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/employeeTypeData`, "json", req, runtime), new QueryEmployeeTypeStatisticalDataResponse({}));
  }

  async queryGroupLiveStatisticalData(request: QueryGroupLiveStatisticalDataRequest): Promise<QueryGroupLiveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupLiveStatisticalDataHeaders({ });
    return await this.queryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryGroupLiveStatisticalDataResponse>(await this.doROARequest("QueryGroupLiveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/groupLiveData`, "json", req, runtime), new QueryGroupLiveStatisticalDataResponse({}));
  }

  async queryGroupMessageStatisticalData(request: QueryGroupMessageStatisticalDataRequest): Promise<QueryGroupMessageStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMessageStatisticalDataHeaders({ });
    return await this.queryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryGroupMessageStatisticalDataResponse>(await this.doROARequest("QueryGroupMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/groupMessageData`, "json", req, runtime), new QueryGroupMessageStatisticalDataResponse({}));
  }

  async queryHealthStatisticalData(request: QueryHealthStatisticalDataRequest): Promise<QueryHealthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHealthStatisticalDataHeaders({ });
    return await this.queryHealthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryHealthStatisticalDataResponse>(await this.doROARequest("QueryHealthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/healtheUserData`, "json", req, runtime), new QueryHealthStatisticalDataResponse({}));
  }

  async queryMailStatisticalData(request: QueryMailStatisticalDataRequest): Promise<QueryMailStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMailStatisticalDataHeaders({ });
    return await this.queryMailStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryMailStatisticalDataResponse>(await this.doROARequest("QueryMailStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/mailData`, "json", req, runtime), new QueryMailStatisticalDataResponse({}));
  }

  async queryOnlineUserStatisticalData(request: QueryOnlineUserStatisticalDataRequest): Promise<QueryOnlineUserStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOnlineUserStatisticalDataHeaders({ });
    return await this.queryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryOnlineUserStatisticalDataResponse>(await this.doROARequest("QueryOnlineUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/onlineUserData`, "json", req, runtime), new QueryOnlineUserStatisticalDataResponse({}));
  }

  async queryRedEnvelopeReciveStatisticalData(request: QueryRedEnvelopeReciveStatisticalDataRequest): Promise<QueryRedEnvelopeReciveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRedEnvelopeReciveStatisticalDataHeaders({ });
    return await this.queryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryRedEnvelopeReciveStatisticalDataResponse>(await this.doROARequest("QueryRedEnvelopeReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/redEnvelopeReciveData`, "json", req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse({}));
  }

  async queryRedEnvelopeSendStatisticalData(request: QueryRedEnvelopeSendStatisticalDataRequest): Promise<QueryRedEnvelopeSendStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRedEnvelopeSendStatisticalDataHeaders({ });
    return await this.queryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryRedEnvelopeSendStatisticalDataResponse>(await this.doROARequest("QueryRedEnvelopeSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/redEnvelopeSendData`, "json", req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse({}));
  }

  async queryReportStatisticalData(request: QueryReportStatisticalDataRequest): Promise<QueryReportStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReportStatisticalDataHeaders({ });
    return await this.queryReportStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryReportStatisticalDataResponse>(await this.doROARequest("QueryReportStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/reportData`, "json", req, runtime), new QueryReportStatisticalDataResponse({}));
  }

  async querySingleMessageStatisticalData(request: QuerySingleMessageStatisticalDataRequest): Promise<QuerySingleMessageStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySingleMessageStatisticalDataHeaders({ });
    return await this.querySingleMessageStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QuerySingleMessageStatisticalDataResponse>(await this.doROARequest("QuerySingleMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/singleMessagerData`, "json", req, runtime), new QuerySingleMessageStatisticalDataResponse({}));
  }

  async queryTelMeetingStatisticalData(request: QueryTelMeetingStatisticalDataRequest): Promise<QueryTelMeetingStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTelMeetingStatisticalDataHeaders({ });
    return await this.queryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryTelMeetingStatisticalDataResponse>(await this.doROARequest("QueryTelMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/telMeetingData`, "json", req, runtime), new QueryTelMeetingStatisticalDataResponse({}));
  }

  async queryTodoStatisticalData(request: QueryTodoStatisticalDataRequest): Promise<QueryTodoStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTodoStatisticalDataHeaders({ });
    return await this.queryTodoStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryTodoStatisticalDataResponse>(await this.doROARequest("QueryTodoStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/todoUserData`, "json", req, runtime), new QueryTodoStatisticalDataResponse({}));
  }

  async queryVedioMeetingStatisticalData(request: QueryVedioMeetingStatisticalDataRequest): Promise<QueryVedioMeetingStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryVedioMeetingStatisticalDataHeaders({ });
    return await this.queryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryVedioMeetingStatisticalDataResponse>(await this.doROARequest("QueryVedioMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/vedioMeetingData`, "json", req, runtime), new QueryVedioMeetingStatisticalDataResponse({}));
  }

  async queryYydActiveDayStatisticalData(request: QueryYydActiveDayStatisticalDataRequest): Promise<QueryYydActiveDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveDayStatisticalDataHeaders({ });
    return await this.queryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydActiveDayStatisticalDataResponse>(await this.doROARequest("QueryYydActiveDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydActiveDayDatas`, "json", req, runtime), new QueryYydActiveDayStatisticalDataResponse({}));
  }

  async queryYydActiveMonthStatisticalData(request: QueryYydActiveMonthStatisticalDataRequest): Promise<QueryYydActiveMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveMonthStatisticalDataHeaders({ });
    return await this.queryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydActiveMonthStatisticalDataResponse>(await this.doROARequest("QueryYydActiveMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydActiveMonthDatas`, "json", req, runtime), new QueryYydActiveMonthStatisticalDataResponse({}));
  }

  async queryYydActiveWeekStatisticalData(request: QueryYydActiveWeekStatisticalDataRequest): Promise<QueryYydActiveWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveWeekStatisticalDataHeaders({ });
    return await this.queryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydActiveWeekStatisticalDataResponse>(await this.doROARequest("QueryYydActiveWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydActiveWeekDatas`, "json", req, runtime), new QueryYydActiveWeekStatisticalDataResponse({}));
  }

  async queryYydAppDayStatisticalData(request: QueryYydAppDayStatisticalDataRequest): Promise<QueryYydAppDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppDayStatisticalDataHeaders({ });
    return await this.queryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydAppDayStatisticalDataResponse>(await this.doROARequest("QueryYydAppDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydAppDayDatas`, "json", req, runtime), new QueryYydAppDayStatisticalDataResponse({}));
  }

  async queryYydAppMonthStatisticalData(request: QueryYydAppMonthStatisticalDataRequest): Promise<QueryYydAppMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppMonthStatisticalDataHeaders({ });
    return await this.queryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydAppMonthStatisticalDataResponse>(await this.doROARequest("QueryYydAppMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydAppMonthDatas`, "json", req, runtime), new QueryYydAppMonthStatisticalDataResponse({}));
  }

  async queryYydAppStdStatisticalData(request: QueryYydAppStdStatisticalDataRequest): Promise<QueryYydAppStdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppStdStatisticalDataHeaders({ });
    return await this.queryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydAppStdStatisticalDataResponse>(await this.doROARequest("QueryYydAppStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydAppStdDatas`, "json", req, runtime), new QueryYydAppStdStatisticalDataResponse({}));
  }

  async queryYydAppWeekStatisticalData(request: QueryYydAppWeekStatisticalDataRequest): Promise<QueryYydAppWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppWeekStatisticalDataHeaders({ });
    return await this.queryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydAppWeekStatisticalDataResponse>(await this.doROARequest("QueryYydAppWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydAppWeekDatas`, "json", req, runtime), new QueryYydAppWeekStatisticalDataResponse({}));
  }

  async queryYydCalendarDayStatisticalData(request: QueryYydCalendarDayStatisticalDataRequest): Promise<QueryYydCalendarDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarDayStatisticalDataHeaders({ });
    return await this.queryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydCalendarDayStatisticalDataResponse>(await this.doROARequest("QueryYydCalendarDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydCalendarDayDatas`, "json", req, runtime), new QueryYydCalendarDayStatisticalDataResponse({}));
  }

  async queryYydCalendarMonthStatisticalData(request: QueryYydCalendarMonthStatisticalDataRequest): Promise<QueryYydCalendarMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarMonthStatisticalDataHeaders({ });
    return await this.queryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydCalendarMonthStatisticalDataResponse>(await this.doROARequest("QueryYydCalendarMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydCalendarMonthDatas`, "json", req, runtime), new QueryYydCalendarMonthStatisticalDataResponse({}));
  }

  async queryYydCalendarWeekStatisticalData(request: QueryYydCalendarWeekStatisticalDataRequest): Promise<QueryYydCalendarWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarWeekStatisticalDataHeaders({ });
    return await this.queryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydCalendarWeekStatisticalDataResponse>(await this.doROARequest("QueryYydCalendarWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydCalendarWeekDatas`, "json", req, runtime), new QueryYydCalendarWeekStatisticalDataResponse({}));
  }

  async queryYydDingMsgDayStatisticalData(request: QueryYydDingMsgDayStatisticalDataRequest): Promise<QueryYydDingMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgDayStatisticalDataHeaders({ });
    return await this.queryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydDingMsgDayStatisticalDataResponse>(await this.doROARequest("QueryYydDingMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydDingMsgDayDatas`, "json", req, runtime), new QueryYydDingMsgDayStatisticalDataResponse({}));
  }

  async queryYydDingMsgMonthStatisticalData(request: QueryYydDingMsgMonthStatisticalDataRequest): Promise<QueryYydDingMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydDingMsgMonthStatisticalDataResponse>(await this.doROARequest("QueryYydDingMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydDingMsgMonthDatas`, "json", req, runtime), new QueryYydDingMsgMonthStatisticalDataResponse({}));
  }

  async queryYydDingMsgWeekStatisticalData(request: QueryYydDingMsgWeekStatisticalDataRequest): Promise<QueryYydDingMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydDingMsgWeekStatisticalDataResponse>(await this.doROARequest("QueryYydDingMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydDingMsgWeekDatas`, "json", req, runtime), new QueryYydDingMsgWeekStatisticalDataResponse({}));
  }

  async queryYydGroupMsgDayStatisticalData(request: QueryYydGroupMsgDayStatisticalDataRequest): Promise<QueryYydGroupMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgDayStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydGroupMsgDayStatisticalDataResponse>(await this.doROARequest("QueryYydGroupMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydGroupMsgDayDatas`, "json", req, runtime), new QueryYydGroupMsgDayStatisticalDataResponse({}));
  }

  async queryYydGroupMsgMonthStatisticalData(request: QueryYydGroupMsgMonthStatisticalDataRequest): Promise<QueryYydGroupMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydGroupMsgMonthStatisticalDataResponse>(await this.doROARequest("QueryYydGroupMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydGroupMsgMonthDatas`, "json", req, runtime), new QueryYydGroupMsgMonthStatisticalDataResponse({}));
  }

  async queryYydGroupMsgWeekStatisticalData(request: QueryYydGroupMsgWeekStatisticalDataRequest): Promise<QueryYydGroupMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydGroupMsgWeekStatisticalDataResponse>(await this.doROARequest("QueryYydGroupMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydGroupMsgWeekDatas`, "json", req, runtime), new QueryYydGroupMsgWeekStatisticalDataResponse({}));
  }

  async queryYydLogDayStatisticalData(request: QueryYydLogDayStatisticalDataRequest): Promise<QueryYydLogDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogDayStatisticalDataHeaders({ });
    return await this.queryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydLogDayStatisticalDataResponse>(await this.doROARequest("QueryYydLogDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydLogDayDatas`, "json", req, runtime), new QueryYydLogDayStatisticalDataResponse({}));
  }

  async queryYydLogMonthStatisticalData(request: QueryYydLogMonthStatisticalDataRequest): Promise<QueryYydLogMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogMonthStatisticalDataHeaders({ });
    return await this.queryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydLogMonthStatisticalDataResponse>(await this.doROARequest("QueryYydLogMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydLogMonthDatas`, "json", req, runtime), new QueryYydLogMonthStatisticalDataResponse({}));
  }

  async queryYydLogWeekStatisticalData(request: QueryYydLogWeekStatisticalDataRequest): Promise<QueryYydLogWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogWeekStatisticalDataHeaders({ });
    return await this.queryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydLogWeekStatisticalDataResponse>(await this.doROARequest("QueryYydLogWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydLogWeekDatas`, "json", req, runtime), new QueryYydLogWeekStatisticalDataResponse({}));
  }

  async queryYydMeetingDayStatisticalData(request: QueryYydMeetingDayStatisticalDataRequest): Promise<QueryYydMeetingDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingDayStatisticalDataHeaders({ });
    return await this.queryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydMeetingDayStatisticalDataResponse>(await this.doROARequest("QueryYydMeetingDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydMeetingDayDatas`, "json", req, runtime), new QueryYydMeetingDayStatisticalDataResponse({}));
  }

  async queryYydMeetingMonthStatisticalData(request: QueryYydMeetingMonthStatisticalDataRequest): Promise<QueryYydMeetingMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingMonthStatisticalDataHeaders({ });
    return await this.queryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydMeetingMonthStatisticalDataResponse>(await this.doROARequest("QueryYydMeetingMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydMeetingMonthDatas`, "json", req, runtime), new QueryYydMeetingMonthStatisticalDataResponse({}));
  }

  async queryYydMeetingWeekStatisticalData(request: QueryYydMeetingWeekStatisticalDataRequest): Promise<QueryYydMeetingWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingWeekStatisticalDataHeaders({ });
    return await this.queryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydMeetingWeekStatisticalDataResponse>(await this.doROARequest("QueryYydMeetingWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydMeetingWeekDatas`, "json", req, runtime), new QueryYydMeetingWeekStatisticalDataResponse({}));
  }

  async queryYydNoticeDayStatisticalData(request: QueryYydNoticeDayStatisticalDataRequest): Promise<QueryYydNoticeDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeDayStatisticalDataHeaders({ });
    return await this.queryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydNoticeDayStatisticalDataResponse>(await this.doROARequest("QueryYydNoticeDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydNoticeDayDatas`, "json", req, runtime), new QueryYydNoticeDayStatisticalDataResponse({}));
  }

  async queryYydNoticeMonthStatisticalData(request: QueryYydNoticeMonthStatisticalDataRequest): Promise<QueryYydNoticeMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeMonthStatisticalDataHeaders({ });
    return await this.queryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydNoticeMonthStatisticalDataResponse>(await this.doROARequest("QueryYydNoticeMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydNoticeMonthDatas`, "json", req, runtime), new QueryYydNoticeMonthStatisticalDataResponse({}));
  }

  async queryYydNoticeWeekStatisticalData(request: QueryYydNoticeWeekStatisticalDataRequest): Promise<QueryYydNoticeWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeWeekStatisticalDataHeaders({ });
    return await this.queryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydNoticeWeekStatisticalDataResponse>(await this.doROARequest("QueryYydNoticeWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydNoticeWeekDatas`, "json", req, runtime), new QueryYydNoticeWeekStatisticalDataResponse({}));
  }

  async queryYydSingleMsgDayStatisticalData(request: QueryYydSingleMsgDayStatisticalDataRequest): Promise<QueryYydSingleMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgDayStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydSingleMsgDayStatisticalDataResponse>(await this.doROARequest("QueryYydSingleMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydSingleMsgDayDatas`, "json", req, runtime), new QueryYydSingleMsgDayStatisticalDataResponse({}));
  }

  async queryYydSingleMsgMonthStatisticalData(request: QueryYydSingleMsgMonthStatisticalDataRequest): Promise<QueryYydSingleMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydSingleMsgMonthStatisticalDataResponse>(await this.doROARequest("QueryYydSingleMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydSingleMsgMonthDatas`, "json", req, runtime), new QueryYydSingleMsgMonthStatisticalDataResponse({}));
  }

  async queryYydSingleMsgWeekStatisticalData(request: QueryYydSingleMsgWeekStatisticalDataRequest): Promise<QueryYydSingleMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydSingleMsgWeekStatisticalDataResponse>(await this.doROARequest("QueryYydSingleMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydSingleMsgWeekDatas`, "json", req, runtime), new QueryYydSingleMsgWeekStatisticalDataResponse({}));
  }

  async queryYydToatlMsgDayStatisticalData(request: QueryYydToatlMsgDayStatisticalDataRequest): Promise<QueryYydToatlMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgDayStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydToatlMsgDayStatisticalDataResponse>(await this.doROARequest("QueryYydToatlMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydToatlMsgDayDatas`, "json", req, runtime), new QueryYydToatlMsgDayStatisticalDataResponse({}));
  }

  async queryYydToatlMsgMonthStatisticalData(request: QueryYydToatlMsgMonthStatisticalDataRequest): Promise<QueryYydToatlMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydToatlMsgMonthStatisticalDataResponse>(await this.doROARequest("QueryYydToatlMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydToatlMsgMonthDatas`, "json", req, runtime), new QueryYydToatlMsgMonthStatisticalDataResponse({}));
  }

  async queryYydToatlMsgWeekStatisticalData(request: QueryYydToatlMsgWeekStatisticalDataRequest): Promise<QueryYydToatlMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydToatlMsgWeekStatisticalDataResponse>(await this.doROARequest("QueryYydToatlMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydToatlMsgWeekDatas`, "json", req, runtime), new QueryYydToatlMsgWeekStatisticalDataResponse({}));
  }

  async queryYydTodoDayStatisticalData(request: QueryYydTodoDayStatisticalDataRequest): Promise<QueryYydTodoDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoDayStatisticalDataHeaders({ });
    return await this.queryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTodoDayStatisticalDataResponse>(await this.doROARequest("QueryYydTodoDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTodoDayDatas`, "json", req, runtime), new QueryYydTodoDayStatisticalDataResponse({}));
  }

  async queryYydTodoMonthStatisticalData(request: QueryYydTodoMonthStatisticalDataRequest): Promise<QueryYydTodoMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoMonthStatisticalDataHeaders({ });
    return await this.queryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTodoMonthStatisticalDataResponse>(await this.doROARequest("QueryYydTodoMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTodoMonthDatas`, "json", req, runtime), new QueryYydTodoMonthStatisticalDataResponse({}));
  }

  async queryYydTodoWeekStatisticalData(request: QueryYydTodoWeekStatisticalDataRequest): Promise<QueryYydTodoWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoWeekStatisticalDataHeaders({ });
    return await this.queryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTodoWeekStatisticalDataResponse>(await this.doROARequest("QueryYydTodoWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTodoWeekDatas`, "json", req, runtime), new QueryYydTodoWeekStatisticalDataResponse({}));
  }

  async queryYydTotalDayStatisticalData(request: QueryYydTotalDayStatisticalDataRequest): Promise<QueryYydTotalDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalDayStatisticalDataHeaders({ });
    return await this.queryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTotalDayStatisticalDataResponse>(await this.doROARequest("QueryYydTotalDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTotalDayDatas`, "json", req, runtime), new QueryYydTotalDayStatisticalDataResponse({}));
  }

  async queryYydTotalMonthStatisticalData(request: QueryYydTotalMonthStatisticalDataRequest): Promise<QueryYydTotalMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalMonthStatisticalDataHeaders({ });
    return await this.queryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTotalMonthStatisticalDataResponse>(await this.doROARequest("QueryYydTotalMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTotalMonthDatas`, "json", req, runtime), new QueryYydTotalMonthStatisticalDataResponse({}));
  }

  async queryYydTotalStdStatisticalData(request: QueryYydTotalStdStatisticalDataRequest): Promise<QueryYydTotalStdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalStdStatisticalDataHeaders({ });
    return await this.queryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTotalStdStatisticalDataResponse>(await this.doROARequest("QueryYydTotalStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTotalStdDatas`, "json", req, runtime), new QueryYydTotalStdStatisticalDataResponse({}));
  }

  async queryYydTotalWeekStatisticalData(request: QueryYydTotalWeekStatisticalDataRequest): Promise<QueryYydTotalWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalWeekStatisticalDataHeaders({ });
    return await this.queryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryYydTotalWeekStatisticalDataResponse>(await this.doROARequest("QueryYydTotalWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/yydTotalWeekDatas`, "json", req, runtime), new QueryYydTotalWeekStatisticalDataResponse({}));
  }

}
