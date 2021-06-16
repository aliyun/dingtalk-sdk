// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryAllMemberByDeptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBody extends $tea.Model {
  content?: QueryAllMemberByDeptResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllMemberByDeptResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllMemberByDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllMemberByDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBody extends $tea.Model {
  content?: QueryAllMemberByGroupResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllMemberByGroupResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllMemberByGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllMemberByGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponseBody extends $tea.Model {
  content?: QueryAllGroupResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllGroupResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsRequest extends $tea.Model {
  pageSize?: number;
  pageNum?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNum: 'pageNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBody extends $tea.Model {
  content?: QueryAllDoctorsResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllDoctorsResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllDoctorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllDoctorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponseBody extends $tea.Model {
  content?: QueryAllGroupsInDeptResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllGroupsInDeptResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllGroupsInDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllGroupsInDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogRequest extends $tea.Model {
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponseBody extends $tea.Model {
  content?: QueryBizOptLogResponseBodyContent[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryBizOptLogResponseBodyContent },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryBizOptLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryBizOptLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponseBody extends $tea.Model {
  content?: QueryUserExtInfoResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserExtInfoResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserExtInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserExtInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBody extends $tea.Model {
  content?: QueryAllDepartmentResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBody extends $tea.Model {
  content?: QueryDepartmentInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryDepartmentInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDepartmentInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDepartmentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBody extends $tea.Model {
  content?: QueryGroupInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryGroupInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGroupInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBodyContentJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBodyContentJobStatus extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBodyContentUserProb extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBodyContent extends $tea.Model {
  staffId?: string;
  uid?: string;
  userName?: string;
  job?: QueryAllMemberByDeptResponseBodyContentJob;
  jobNum?: string;
  jobStatus?: QueryAllMemberByDeptResponseBodyContentJobStatus;
  userProb?: QueryAllMemberByDeptResponseBodyContentUserProb;
  static names(): { [key: string]: string } {
    return {
      staffId: 'staffId',
      uid: 'uid',
      userName: 'userName',
      job: 'job',
      jobNum: 'jobNum',
      jobStatus: 'jobStatus',
      userProb: 'userProb',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffId: 'string',
      uid: 'string',
      userName: 'string',
      job: QueryAllMemberByDeptResponseBodyContentJob,
      jobNum: 'string',
      jobStatus: QueryAllMemberByDeptResponseBodyContentJobStatus,
      userProb: QueryAllMemberByDeptResponseBodyContentUserProb,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBodyContentJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBodyContentJobStatus extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBodyContentUserProb extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBodyContent extends $tea.Model {
  staffId?: string;
  uid?: string;
  userName?: string;
  job?: QueryAllMemberByGroupResponseBodyContentJob;
  jobNum?: string;
  jobStatus?: QueryAllMemberByGroupResponseBodyContentJobStatus;
  userProb?: QueryAllMemberByGroupResponseBodyContentUserProb;
  static names(): { [key: string]: string } {
    return {
      staffId: 'staffId',
      uid: 'uid',
      userName: 'userName',
      job: 'job',
      jobNum: 'jobNum',
      jobStatus: 'jobStatus',
      userProb: 'userProb',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffId: 'string',
      uid: 'string',
      userName: 'string',
      job: QueryAllMemberByGroupResponseBodyContentJob,
      jobNum: 'string',
      jobStatus: QueryAllMemberByGroupResponseBodyContentJobStatus,
      userProb: QueryAllMemberByGroupResponseBodyContentUserProb,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBodyContentJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBodyContentJobStatus extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBodyContentUserProb extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBodyContent extends $tea.Model {
  staffId?: string;
  uid?: string;
  userName?: string;
  job?: QueryAllDoctorsResponseBodyContentJob;
  jobNum?: string;
  jobStatus?: QueryAllDoctorsResponseBodyContentJobStatus;
  userProb?: QueryAllDoctorsResponseBodyContentUserProb;
  static names(): { [key: string]: string } {
    return {
      staffId: 'staffId',
      uid: 'uid',
      userName: 'userName',
      job: 'job',
      jobNum: 'jobNum',
      jobStatus: 'jobStatus',
      userProb: 'userProb',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffId: 'string',
      uid: 'string',
      userName: 'string',
      job: QueryAllDoctorsResponseBodyContentJob,
      jobNum: 'string',
      jobStatus: QueryAllDoctorsResponseBodyContentJobStatus,
      userProb: QueryAllDoctorsResponseBodyContentUserProb,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponseBodyContent extends $tea.Model {
  id?: number;
  dataType?: number;
  bizType?: number;
  optTime?: number;
  optUserCode?: string;
  optUserName?: string;
  optJobNumber?: string;
  optType?: number;
  optBizType?: number;
  optObjectCode?: string;
  optObjectUserJobNo?: string;
  optObjectName?: string;
  optSuccess?: number;
  remark?: string;
  optBeforeData?: string;
  optAfterData?: string;
  optExtend?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      dataType: 'dataType',
      bizType: 'bizType',
      optTime: 'optTime',
      optUserCode: 'optUserCode',
      optUserName: 'optUserName',
      optJobNumber: 'optJobNumber',
      optType: 'optType',
      optBizType: 'optBizType',
      optObjectCode: 'optObjectCode',
      optObjectUserJobNo: 'optObjectUserJobNo',
      optObjectName: 'optObjectName',
      optSuccess: 'optSuccess',
      remark: 'remark',
      optBeforeData: 'optBeforeData',
      optAfterData: 'optAfterData',
      optExtend: 'optExtend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      dataType: 'number',
      bizType: 'number',
      optTime: 'number',
      optUserCode: 'string',
      optUserName: 'string',
      optJobNumber: 'string',
      optType: 'number',
      optBizType: 'number',
      optObjectCode: 'string',
      optObjectUserJobNo: 'string',
      optObjectName: 'string',
      optSuccess: 'number',
      remark: 'string',
      optBeforeData: 'string',
      optAfterData: 'string',
      optExtend: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponseBodyContent extends $tea.Model {
  userExtendKey?: string;
  userExtendValue?: string;
  userExtendDisplayName?: string;
  static names(): { [key: string]: string } {
    return {
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
      userExtendDisplayName: 'userExtendDisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userExtendKey: 'string',
      userExtendValue: 'string',
      userExtendDisplayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentLeaderJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  job?: QueryDepartmentInfoResponseBodyContentLeaderJob;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
      job: 'job',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
      job: QueryDepartmentInfoResponseBodyContentLeaderJob,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentResidentLeaderJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentResidentLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  job?: QueryDepartmentInfoResponseBodyContentResidentLeaderJob;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
      job: 'job',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
      job: QueryDepartmentInfoResponseBodyContentResidentLeaderJob,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  leader?: QueryDepartmentInfoResponseBodyContentLeader;
  residentLeader?: QueryDepartmentInfoResponseBodyContentResidentLeader;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      leader: 'leader',
      residentLeader: 'residentLeader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      leader: QueryDepartmentInfoResponseBodyContentLeader,
      residentLeader: QueryDepartmentInfoResponseBodyContentResidentLeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentLeaderJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  job?: QueryGroupInfoResponseBodyContentLeaderJob;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
      job: 'job',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
      job: QueryGroupInfoResponseBodyContentLeaderJob,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  leader?: QueryGroupInfoResponseBodyContentLeader;
  startTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
      leader: 'leader',
      startTime: 'startTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
      leader: QueryGroupInfoResponseBodyContentLeader,
      startTime: 'number',
      endTime: 'number',
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


  async queryAllMemberByDept(deptId: string, request: QueryAllMemberByDeptRequest): Promise<QueryAllMemberByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByDeptHeaders({ });
    return await this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllMemberByDeptWithOptions(deptId: string, request: QueryAllMemberByDeptRequest, headers: QueryAllMemberByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllMemberByDeptResponse>(await this.doROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}/members`, "json", req, runtime), new QueryAllMemberByDeptResponse({}));
  }

  async queryAllMemberByGroup(groupId: string, request: QueryAllMemberByGroupRequest): Promise<QueryAllMemberByGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByGroupHeaders({ });
    return await this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
  }

  async queryAllMemberByGroupWithOptions(groupId: string, request: QueryAllMemberByGroupRequest, headers: QueryAllMemberByGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllMemberByGroupResponse>(await this.doROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups/${groupId}/members`, "json", req, runtime), new QueryAllMemberByGroupResponse({}));
  }

  async queryAllGroup(request: QueryAllGroupRequest): Promise<QueryAllGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupHeaders({ });
    return await this.queryAllGroupWithOptions(request, headers, runtime);
  }

  async queryAllGroupWithOptions(request: QueryAllGroupRequest, headers: QueryAllGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllGroupResponse>(await this.doROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups`, "json", req, runtime), new QueryAllGroupResponse({}));
  }

  async queryAllDoctors(request: QueryAllDoctorsRequest): Promise<QueryAllDoctorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDoctorsHeaders({ });
    return await this.queryAllDoctorsWithOptions(request, headers, runtime);
  }

  async queryAllDoctorsWithOptions(request: QueryAllDoctorsRequest, headers: QueryAllDoctorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDoctorsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNum)) {
      query["pageNum"] = request.pageNum;
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
    return $tea.cast<QueryAllDoctorsResponse>(await this.doROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/doctors`, "json", req, runtime), new QueryAllDoctorsResponse({}));
  }

  async queryAllGroupsInDept(deptId: string, request: QueryAllGroupsInDeptRequest): Promise<QueryAllGroupsInDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupsInDeptHeaders({ });
    return await this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllGroupsInDeptWithOptions(deptId: string, request: QueryAllGroupsInDeptRequest, headers: QueryAllGroupsInDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupsInDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllGroupsInDeptResponse>(await this.doROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}/groups`, "json", req, runtime), new QueryAllGroupsInDeptResponse({}));
  }

  async queryBizOptLog(request: QueryBizOptLogRequest): Promise<QueryBizOptLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBizOptLogHeaders({ });
    return await this.queryBizOptLogWithOptions(request, headers, runtime);
  }

  async queryBizOptLogWithOptions(request: QueryBizOptLogRequest, headers: QueryBizOptLogHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBizOptLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<QueryBizOptLogResponse>(await this.doROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/bizOptLogs`, "json", req, runtime), new QueryBizOptLogResponse({}));
  }

  async queryUserExtInfo(userId: string): Promise<QueryUserExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtInfoHeaders({ });
    return await this.queryUserExtInfoWithOptions(userId, headers, runtime);
  }

  async queryUserExtInfoWithOptions(userId: string, headers: QueryUserExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserExtInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryUserExtInfoResponse>(await this.doROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}/extInfos`, "json", req, runtime), new QueryUserExtInfoResponse({}));
  }

  async queryAllDepartment(request: QueryAllDepartmentRequest): Promise<QueryAllDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDepartmentHeaders({ });
    return await this.queryAllDepartmentWithOptions(request, headers, runtime);
  }

  async queryAllDepartmentWithOptions(request: QueryAllDepartmentRequest, headers: QueryAllDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDepartmentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllDepartmentResponse>(await this.doROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments`, "json", req, runtime), new QueryAllDepartmentResponse({}));
  }

  async queryDepartmentInfo(deptId: string): Promise<QueryDepartmentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDepartmentInfoHeaders({ });
    return await this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
  }

  async queryDepartmentInfoWithOptions(deptId: string, headers: QueryDepartmentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDepartmentInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryDepartmentInfoResponse>(await this.doROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}`, "json", req, runtime), new QueryDepartmentInfoResponse({}));
  }

  async queryGroupInfo(groupId: string): Promise<QueryGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupInfoHeaders({ });
    return await this.queryGroupInfoWithOptions(groupId, headers, runtime);
  }

  async queryGroupInfoWithOptions(groupId: string, headers: QueryGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryGroupInfoResponse>(await this.doROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups/${groupId}`, "json", req, runtime), new QueryGroupInfoResponse({}));
  }

}
