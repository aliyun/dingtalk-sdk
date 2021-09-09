// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  message?: string;
  requestId?: string;
  total?: number;
  data?: string;
  code?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      requestId: 'requestId',
      total: 'total',
      data: 'data',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      requestId: 'string',
      total: 'number',
      data: 'string',
      code: 'number',
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
  kpiGroupId?: string;
  statDates?: string[];
  corpIds?: string[];
  static names(): { [key: string]: string } {
    return {
      kpiGroupId: 'kpiGroupId',
      statDates: 'statDates',
      corpIds: 'corpIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiGroupId: 'string',
      statDates: { 'type': 'array', 'itemType': 'string' },
      corpIds: { 'type': 'array', 'itemType': 'string' },
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

export class QueryGroupMessageStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponseBodyMetaList extends $tea.Model {
  kpiId?: string;
  kpiName?: string;
  unit?: string;
  kpiCaliber?: string;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      unit: 'unit',
      kpiCaliber: 'kpiCaliber',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiId: 'string',
      kpiName: 'string',
      unit: 'string',
      kpiCaliber: 'string',
      period: 'string',
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryGroupMessageStatisticalDataResponse>(await this.doROARequest("QueryGroupMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/groupMessageData`, "json", req, runtime), new QueryGroupMessageStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryVedioMeetingStatisticalDataResponse>(await this.doROARequest("QueryVedioMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/vedioMeetingData`, "json", req, runtime), new QueryVedioMeetingStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryHealthStatisticalDataResponse>(await this.doROARequest("QueryHealthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/healtheUserData`, "json", req, runtime), new QueryHealthStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QuerySingleMessageStatisticalDataResponse>(await this.doROARequest("QuerySingleMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/singleMessagerData`, "json", req, runtime), new QuerySingleMessageStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryTodoStatisticalDataResponse>(await this.doROARequest("QueryTodoStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/todoUserData`, "json", req, runtime), new QueryTodoStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCheckinStatisticalDataResponse>(await this.doROARequest("QueryCheckinStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/checkinData`, "json", req, runtime), new QueryCheckinStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryEmployeeTypeStatisticalDataResponse>(await this.doROARequest("QueryEmployeeTypeStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/employeeTypeData`, "json", req, runtime), new QueryEmployeeTypeStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryMailStatisticalDataResponse>(await this.doROARequest("QueryMailStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/mailData`, "json", req, runtime), new QueryMailStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCalendarStatisticalDataResponse>(await this.doROARequest("QueryCalendarStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/calendarData`, "json", req, runtime), new QueryCalendarStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryDocumentStatisticalDataResponse>(await this.doROARequest("QueryDocumentStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/documentData`, "json", req, runtime), new QueryDocumentStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryReportStatisticalDataResponse>(await this.doROARequest("QueryReportStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/reportData`, "json", req, runtime), new QueryReportStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryOnlineUserStatisticalDataResponse>(await this.doROARequest("QueryOnlineUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/onlineUserData`, "json", req, runtime), new QueryOnlineUserStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCompanyBasicInfoResponse>(await this.doROARequest("QueryCompanyBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/companies/basicInfo`, "json", req, runtime), new QueryCompanyBasicInfoResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryApprovalStatisticalDataResponse>(await this.doROARequest("QueryApprovalStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/approvalData`, "json", req, runtime), new QueryApprovalStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryDriveStatisticalDataResponse>(await this.doROARequest("QueryDriveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/driveData`, "json", req, runtime), new QueryDriveStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryDingSendStatisticalDataResponse>(await this.doROARequest("QueryDingSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/dingSendData`, "json", req, runtime), new QueryDingSendStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryActiveUserStatisticalDataResponse>(await this.doROARequest("QueryActiveUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/activeUserData`, "json", req, runtime), new QueryActiveUserStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryGroupLiveStatisticalDataResponse>(await this.doROARequest("QueryGroupLiveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/groupLiveData`, "json", req, runtime), new QueryGroupLiveStatisticalDataResponse({}));
  }

  async queryDigitalDistrictOrgInfo(request: QueryDigitalDistrictOrgInfoRequest): Promise<QueryDigitalDistrictOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDigitalDistrictOrgInfoHeaders({ });
    return await this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
  }

  async queryDigitalDistrictOrgInfoWithOptions(request: QueryDigitalDistrictOrgInfoRequest, headers: QueryDigitalDistrictOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDigitalDistrictOrgInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.kpiGroupId)) {
      body["kpiGroupId"] = request.kpiGroupId;
    }

    if (!Util.isUnset(request.statDates)) {
      body["statDates"] = request.statDates;
    }

    if (!Util.isUnset(request.corpIds)) {
      body["corpIds"] = request.corpIds;
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
    return $tea.cast<QueryDigitalDistrictOrgInfoResponse>(await this.doROARequest("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", `/v1.0/datacenter/digitalCounty/orgInfos/query`, "json", req, runtime), new QueryDigitalDistrictOrgInfoResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryAttendanceStatisticalDataResponse>(await this.doROARequest("QueryAttendanceStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/attendanceData`, "json", req, runtime), new QueryAttendanceStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryDingReciveStatisticalDataResponse>(await this.doROARequest("QueryDingReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/dingReciveData`, "json", req, runtime), new QueryDingReciveStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryRedEnvelopeReciveStatisticalDataResponse>(await this.doROARequest("QueryRedEnvelopeReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/redEnvelopeReciveData`, "json", req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCircleStatisticalDataResponse>(await this.doROARequest("QueryCircleStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/circleData`, "json", req, runtime), new QueryCircleStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryRedEnvelopeSendStatisticalDataResponse>(await this.doROARequest("QueryRedEnvelopeSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/redEnvelopeSendData`, "json", req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryTelMeetingStatisticalDataResponse>(await this.doROARequest("QueryTelMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/telMeetingData`, "json", req, runtime), new QueryTelMeetingStatisticalDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryBlackboardStatisticalDataResponse>(await this.doROARequest("QueryBlackboardStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", `/v1.0/datacenter/blackboardData`, "json", req, runtime), new QueryBlackboardStatisticalDataResponse({}));
  }

}
