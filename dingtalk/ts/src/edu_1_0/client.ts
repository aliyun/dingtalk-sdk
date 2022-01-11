// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryStatisticsDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataRequest extends $tea.Model {
  startTime?: number;
  endTime?: number;
  opUserId?: string;
  sectionIndexList?: number[];
  teacherUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      startTime: 'startTime',
      endTime: 'endTime',
      opUserId: 'opUserId',
      sectionIndexList: 'sectionIndexList',
      teacherUserIds: 'teacherUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'number',
      endTime: 'number',
      opUserId: 'string',
      sectionIndexList: { 'type': 'array', 'itemType': 'number' },
      teacherUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataResponseBody extends $tea.Model {
  result?: QueryStatisticsDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryStatisticsDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryStatisticsDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryStatisticsDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigShrinkRequest extends $tea.Model {
  classIdsShrink?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classIdsShrink: 'classIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIdsShrink: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBody extends $tea.Model {
  result?: QueryClassScheduleConfigResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryClassScheduleConfigResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryClassScheduleConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryClassScheduleConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildResponseBody extends $tea.Model {
  name?: string;
  nick?: string;
  avatar?: string;
  unionId?: string;
  period?: string;
  grade?: number;
  bindStudents?: GetDefaultChildResponseBodyBindStudents[];
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      nick: 'nick',
      avatar: 'avatar',
      unionId: 'unionId',
      period: 'period',
      grade: 'grade',
      bindStudents: 'bindStudents',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      nick: 'string',
      avatar: 'string',
      unionId: 'string',
      period: 'string',
      grade: 'number',
      bindStudents: { 'type': 'array', 'itemType': GetDefaultChildResponseBodyBindStudents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDefaultChildResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDefaultChildResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesResponseBody extends $tea.Model {
  totalCount?: number;
  courseList?: GetOpenCoursesResponseBodyCourseList[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      courseList: 'courseList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      courseList: { 'type': 'array', 'itemType': GetOpenCoursesResponseBodyCourseList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOpenCoursesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOpenCoursesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityStudentRequest extends $tea.Model {
  studentNumber?: string;
  classId?: number;
  gender?: string;
  mobile?: string;
  name?: string;
  identityNumber?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      studentNumber: 'studentNumber',
      classId: 'classId',
      gender: 'gender',
      mobile: 'mobile',
      name: 'name',
      identityNumber: 'identityNumber',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studentNumber: 'string',
      classId: 'number',
      gender: 'string',
      mobile: 'string',
      name: 'string',
      identityNumber: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityStudentResponseBody extends $tea.Model {
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

export class CreateUniversityStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateUniversityStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateUniversityStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequest extends $tea.Model {
  cardBizCode?: string;
  data?: BatchCreateRequestData;
  identifier?: string;
  sourceType?: string;
  userid?: string;
  dingCorpId?: string;
  jsVersion?: number;
  static names(): { [key: string]: string } {
    return {
      cardBizCode: 'cardBizCode',
      data: 'data',
      identifier: 'identifier',
      sourceType: 'sourceType',
      userid: 'userid',
      dingCorpId: 'dingCorpId',
      jsVersion: 'jsVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizCode: 'string',
      data: BatchCreateRequestData,
      identifier: 'string',
      sourceType: 'string',
      userid: 'string',
      dingCorpId: 'string',
      jsVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateResponseBody extends $tea.Model {
  result?: BatchCreateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchCreateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequest extends $tea.Model {
  courses?: InitCoursesOfClassRequestCourses[];
  sectionConfig?: InitCoursesOfClassRequestSectionConfig;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courses: 'courses',
      sectionConfig: 'sectionConfig',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courses: { 'type': 'array', 'itemType': InitCoursesOfClassRequestCourses },
      sectionConfig: InitCoursesOfClassRequestSectionConfig,
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassResponseBody extends $tea.Model {
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

export class InitCoursesOfClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: InitCoursesOfClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: InitCoursesOfClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlRequest extends $tea.Model {
  dingCorpId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingOauthAppId?: number;
  targetCorpId?: string;
  authCode?: string;
  targetOperator?: string;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOauthAppId: 'dingOauthAppId',
      targetCorpId: 'targetCorpId',
      authCode: 'authCode',
      targetOperator: 'targetOperator',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingOauthAppId: 'number',
      targetCorpId: 'string',
      authCode: 'string',
      targetOperator: 'string',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlResponseBody extends $tea.Model {
  success?: boolean;
  result?: CreateInviteUrlResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: CreateInviteUrlResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateInviteUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateInviteUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusRequest extends $tea.Model {
  ext?: string;
  isvCode?: string;
  courseCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      ext: 'ext',
      isvCode: 'isvCode',
      courseCode: 'courseCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ext: 'string',
      isvCode: 'string',
      courseCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponseBody extends $tea.Model {
  universityPollingCourseStatusResponse?: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse;
  static names(): { [key: string]: string } {
    return {
      universityPollingCourseStatusResponse: 'universityPollingCourseStatusResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityPollingCourseStatusResponse: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PollingConfirmStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PollingConfirmStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceRequest extends $tea.Model {
  spaceName?: string;
  spaceDesc?: string;
  spaceIcon?: string;
  userId?: string;
  bizCode?: string;
  dingCorpId?: string;
  dingOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      spaceName: 'spaceName',
      spaceDesc: 'spaceDesc',
      spaceIcon: 'spaceIcon',
      userId: 'userId',
      bizCode: 'bizCode',
      dingCorpId: 'dingCorpId',
      dingOrgId: 'dingOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceName: 'string',
      spaceDesc: 'string',
      spaceIcon: 'string',
      userId: 'string',
      bizCode: 'string',
      dingCorpId: 'string',
      dingOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceResponseBody extends $tea.Model {
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  quota?: number;
  usedQuota?: number;
  permissionMode?: string;
  createTimeMillis?: number;
  modifyTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
      permissionMode: 'permissionMode',
      createTimeMillis: 'createTimeMillis',
      modifyTimeMillis: 'modifyTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      quota: 'number',
      usedQuota: 'number',
      permissionMode: 'string',
      createTimeMillis: 'number',
      modifyTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEduAssetSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateEduAssetSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateEduAssetSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeacherHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeacherRequest extends $tea.Model {
  adviser?: number;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      adviser: 'adviser',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adviser: 'number',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeacherResponseBody extends $tea.Model {
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

export class DeleteTeacherResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteTeacherResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteTeacherResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityTeacherHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityTeacherRequest extends $tea.Model {
  classId?: number;
  role?: string;
  teacherUserId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      role: 'role',
      teacherUserId: 'teacherUserId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      role: 'string',
      teacherUserId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityTeacherResponseBody extends $tea.Model {
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

export class DeleteUniversityTeacherResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteUniversityTeacherResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteUniversityTeacherResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoRequest extends $tea.Model {
  sn?: string;
  userId?: string;
  merchantId?: string;
  scene?: number;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
      userId: 'userId',
      merchantId: 'merchantId',
      scene: 'scene',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
      userId: 'string',
      merchantId: 'string',
      scene: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoResponseBody extends $tea.Model {
  corpId?: string;
  userId?: string;
  merchantId?: string;
  scene?: number;
  status?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      merchantId: 'merchantId',
      scene: 'scene',
      status: 'status',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      merchantId: 'string',
      scene: 'number',
      status: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPurchaseInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPurchaseInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPurchaseInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceOrgRequest extends $tea.Model {
  deviceCode?: string;
  authCode?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      authCode: 'authCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      authCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceOrgResponseBody extends $tea.Model {
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

export class DeleteDeviceOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteDeviceOrgResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteDeviceOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRemoteClassCourseRequest extends $tea.Model {
  authCode?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRemoteClassCourseResponseBody extends $tea.Model {
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

export class DeleteRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailResponseBody extends $tea.Model {
  courseId?: string;
  title?: string;
  courseType?: number;
  teacherName?: string;
  coverUrl?: string;
  startTime?: number;
  teacherId?: string;
  introduction?: string;
  pushModel?: GetOpenCourseDetailResponseBodyPushModel;
  static names(): { [key: string]: string } {
    return {
      courseId: 'courseId',
      title: 'title',
      courseType: 'courseType',
      teacherName: 'teacherName',
      coverUrl: 'coverUrl',
      startTime: 'startTime',
      teacherId: 'teacherId',
      introduction: 'introduction',
      pushModel: 'pushModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseId: 'string',
      title: 'string',
      courseType: 'number',
      teacherName: 'string',
      coverUrl: 'string',
      startTime: 'number',
      teacherId: 'string',
      introduction: 'string',
      pushModel: GetOpenCourseDetailResponseBodyPushModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOpenCourseDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOpenCourseDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteStudentRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteStudentResponseBody extends $tea.Model {
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

export class DeleteStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequest extends $tea.Model {
  courses?: UpdateCoursesOfClassRequestCourses[];
  sectionConfig?: UpdateCoursesOfClassRequestSectionConfig;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courses: 'courses',
      sectionConfig: 'sectionConfig',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courses: { 'type': 'array', 'itemType': UpdateCoursesOfClassRequestCourses },
      sectionConfig: UpdateCoursesOfClassRequestSectionConfig,
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassResponseBody extends $tea.Model {
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

export class UpdateCoursesOfClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateCoursesOfClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateCoursesOfClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequest extends $tea.Model {
  ext?: string;
  sectionConfigs?: CreateSectionConfigRequestSectionConfigs[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      ext: 'ext',
      sectionConfigs: 'sectionConfigs',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ext: 'string',
      sectionConfigs: { 'type': 'array', 'itemType': CreateSectionConfigRequestSectionConfigs },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigResponseBody extends $tea.Model {
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

export class CreateSectionConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateSectionConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateSectionConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  subjectCode?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
      subjectCode: 'subjectCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      subjectCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersResponseBody extends $tea.Model {
  result?: QuerySubjectTeachersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QuerySubjectTeachersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QuerySubjectTeachersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QuerySubjectTeachersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseRequest extends $tea.Model {
  operator?: string;
  startTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      startTime: 'startTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      startTime: 'number',
      endTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBody extends $tea.Model {
  success?: boolean;
  result?: QueryRemoteClassCourseResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: { 'type': 'array', 'itemType': QueryRemoteClassCourseResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomRequest extends $tea.Model {
  opUserId?: string;
  classroomFloor?: string;
  ext?: string;
  classroomBuilding?: string;
  directBroadcast?: string;
  classroomName?: string;
  classroomCampus?: string;
  classroomNumber?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      classroomFloor: 'classroomFloor',
      ext: 'ext',
      classroomBuilding: 'classroomBuilding',
      directBroadcast: 'directBroadcast',
      classroomName: 'classroomName',
      classroomCampus: 'classroomCampus',
      classroomNumber: 'classroomNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      classroomFloor: 'string',
      ext: 'string',
      classroomBuilding: 'string',
      directBroadcast: 'string',
      classroomName: 'string',
      classroomCampus: 'string',
      classroomNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomResponseBody extends $tea.Model {
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreatePhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreatePhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleRequest extends $tea.Model {
  subscriberType?: string;
  startTime?: number;
  endTime?: number;
  opUserId?: string;
  subscriberIds?: string[];
  sectionIndexList?: number[];
  static names(): { [key: string]: string } {
    return {
      subscriberType: 'subscriberType',
      startTime: 'startTime',
      endTime: 'endTime',
      opUserId: 'opUserId',
      subscriberIds: 'subscriberIds',
      sectionIndexList: 'sectionIndexList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subscriberType: 'string',
      startTime: 'number',
      endTime: 'number',
      opUserId: 'string',
      subscriberIds: { 'type': 'array', 'itemType': 'string' },
      sectionIndexList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBody extends $tea.Model {
  config?: QueryClassScheduleResponseBodyConfig;
  courseDTOS?: QueryClassScheduleResponseBodyCourseDTOS[];
  static names(): { [key: string]: string } {
    return {
      config: 'config',
      courseDTOS: 'courseDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      config: QueryClassScheduleResponseBodyConfig,
      courseDTOS: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyCourseDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryClassScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryClassScheduleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseRequest extends $tea.Model {
  courseName?: string;
  startTime?: number;
  endTime?: number;
  teachingParticipant?: CreateRemoteClassCourseRequestTeachingParticipant;
  attendParticipants?: CreateRemoteClassCourseRequestAttendParticipants[];
  authCode?: string;
  dingClientId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingOauthAppId?: number;
  dingIsvOrgId?: number;
  dingCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      courseName: 'courseName',
      startTime: 'startTime',
      endTime: 'endTime',
      teachingParticipant: 'teachingParticipant',
      attendParticipants: 'attendParticipants',
      authCode: 'authCode',
      dingClientId: 'dingClientId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOauthAppId: 'dingOauthAppId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingCorpId: 'dingCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseName: 'string',
      startTime: 'number',
      endTime: 'number',
      teachingParticipant: CreateRemoteClassCourseRequestTeachingParticipant,
      attendParticipants: { 'type': 'array', 'itemType': CreateRemoteClassCourseRequestAttendParticipants },
      authCode: 'string',
      dingClientId: 'string',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingOauthAppId: 'number',
      dingIsvOrgId: 'number',
      dingCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseResponseBody extends $tea.Model {
  success?: boolean;
  result?: CreateRemoteClassCourseResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: CreateRemoteClassCourseResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassDeviceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassDeviceRequest extends $tea.Model {
  deviceCode?: string;
  authCode?: string;
  deviceName?: string;
  static names(): { [key: string]: string } {
    return {
      deviceCode: 'deviceCode',
      authCode: 'authCode',
      deviceName: 'deviceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCode: 'string',
      authCode: 'string',
      deviceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassDeviceResponseBody extends $tea.Model {
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

export class UpdateRemoteClassDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateRemoteClassDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateRemoteClassDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceLogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceLogRequest extends $tea.Model {
  sn?: string;
  mediaId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
      mediaId: 'mediaId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
      mediaId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportDeviceLogResponseBody extends $tea.Model {
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

export class ReportDeviceLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReportDeviceLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReportDeviceLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassRequest extends $tea.Model {
  customClass?: CreateCustomClassRequestCustomClass;
  superId?: number;
  operator?: string;
  dingIsvOrgId?: number;
  dingCorpId?: string;
  dingOauthAppId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      customClass: 'customClass',
      superId: 'superId',
      operator: 'operator',
      dingIsvOrgId: 'dingIsvOrgId',
      dingCorpId: 'dingCorpId',
      dingOauthAppId: 'dingOauthAppId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customClass: CreateCustomClassRequestCustomClass,
      superId: 'number',
      operator: 'string',
      dingIsvOrgId: 'number',
      dingCorpId: 'string',
      dingOauthAppId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassResponseBody extends $tea.Model {
  result?: CreateCustomClassResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateCustomClassResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCustomClassResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCustomClassResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePhysicalClassroomRequest extends $tea.Model {
  opUserId?: string;
  classroomFloor?: string;
  ext?: string;
  classroomBuilding?: string;
  directBroadcast?: string;
  classroomName?: string;
  classroomCampus?: string;
  classroomNumber?: string;
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      classroomFloor: 'classroomFloor',
      ext: 'ext',
      classroomBuilding: 'classroomBuilding',
      directBroadcast: 'directBroadcast',
      classroomName: 'classroomName',
      classroomCampus: 'classroomCampus',
      classroomNumber: 'classroomNumber',
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      classroomFloor: 'string',
      ext: 'string',
      classroomBuilding: 'string',
      directBroadcast: 'string',
      classroomName: 'string',
      classroomCampus: 'string',
      classroomNumber: 'string',
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePhysicalClassroomResponseBody extends $tea.Model {
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

export class UpdatePhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdatePhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdatePhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveStudentRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingCorpId?: string;
  dingOauthAppId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingOrgId?: number;
  operator?: string;
  userId?: string;
  originClassId?: number;
  targetClassId?: number;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingCorpId: 'dingCorpId',
      dingOauthAppId: 'dingOauthAppId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      operator: 'operator',
      userId: 'userId',
      originClassId: 'originClassId',
      targetClassId: 'targetClassId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingCorpId: 'string',
      dingOauthAppId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      operator: 'string',
      userId: 'string',
      originClassId: 'number',
      targetClassId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveStudentResponseBody extends $tea.Model {
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

export class MoveStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: MoveStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MoveStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesRequest extends $tea.Model {
  nextToken?: number;
  maxResults?: number;
  bizCode?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      bizCode: 'bizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      maxResults: 'number',
      bizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesResponseBody extends $tea.Model {
  nextToken?: string;
  hasMore?: boolean;
  spaces?: QueryEduAssetSpacesResponseBodySpaces[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      spaces: 'spaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      hasMore: 'boolean',
      spaces: { 'type': 'array', 'itemType': QueryEduAssetSpacesResponseBodySpaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryEduAssetSpacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryEduAssetSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequest extends $tea.Model {
  opUserId?: string;
  isvCourseGroupCode?: string;
  ext?: string;
  courseGroupIntroduce?: string;
  semester?: number;
  subjectName?: string;
  courseGroupName?: string;
  schoolYear?: string;
  periodCode?: string;
  teacherInfos?: CreateUniversityCourseGroupRequestTeacherInfos[];
  courserGroupItemModels?: CreateUniversityCourseGroupRequestCourserGroupItemModels[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      isvCourseGroupCode: 'isvCourseGroupCode',
      ext: 'ext',
      courseGroupIntroduce: 'courseGroupIntroduce',
      semester: 'semester',
      subjectName: 'subjectName',
      courseGroupName: 'courseGroupName',
      schoolYear: 'schoolYear',
      periodCode: 'periodCode',
      teacherInfos: 'teacherInfos',
      courserGroupItemModels: 'courserGroupItemModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      isvCourseGroupCode: 'string',
      ext: 'string',
      courseGroupIntroduce: 'string',
      semester: 'number',
      subjectName: 'string',
      courseGroupName: 'string',
      schoolYear: 'string',
      periodCode: 'string',
      teacherInfos: { 'type': 'array', 'itemType': CreateUniversityCourseGroupRequestTeacherInfos },
      courserGroupItemModels: { 'type': 'array', 'itemType': CreateUniversityCourseGroupRequestCourserGroupItemModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupResponseBody extends $tea.Model {
  courseGroupInfo?: CreateUniversityCourseGroupResponseBodyCourseGroupInfo;
  static names(): { [key: string]: string } {
    return {
      courseGroupInfo: 'courseGroupInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupInfo: CreateUniversityCourseGroupResponseBodyCourseGroupInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBody extends $tea.Model {
  success?: boolean;
  result?: GetRemoteClassCourseResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: GetRemoteClassCourseResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupRequest extends $tea.Model {
  opUserId?: string;
  courseGroupCode?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      courseGroupCode: 'courseGroupCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      courseGroupCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBody extends $tea.Model {
  universityCourseGroupInfo?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo;
  static names(): { [key: string]: string } {
    return {
      universityCourseGroupInfo: 'universityCourseGroupInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseGroupInfo: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  periodCode?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
      periodCode: 'periodCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      periodCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleShrinkRequest extends $tea.Model {
  classIdsShrink?: string;
  opUserId?: string;
  periodCode?: string;
  static names(): { [key: string]: string } {
    return {
      classIdsShrink: 'classIds',
      opUserId: 'opUserId',
      periodCode: 'periodCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIdsShrink: 'string',
      opUserId: 'string',
      periodCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBody extends $tea.Model {
  result?: QueryAllSubjectsFromClassScheduleResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryAllSubjectsFromClassScheduleResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllSubjectsFromClassScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllSubjectsFromClassScheduleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CourseSchedulingComplimentNoticeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CourseSchedulingComplimentNoticeRequest extends $tea.Model {
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CourseSchedulingComplimentNoticeResponseBody extends $tea.Model {
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

export class CourseSchedulingComplimentNoticeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CourseSchedulingComplimentNoticeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CourseSchedulingComplimentNoticeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityCourseGroupRequest extends $tea.Model {
  opUserId?: string;
  courseGroupCode?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      courseGroupCode: 'courseGroupCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      courseGroupCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityCourseGroupResponseBody extends $tea.Model {
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

export class DeleteUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatRequest extends $tea.Model {
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatResponseBody extends $tea.Model {
  command?: number;
  static names(): { [key: string]: string } {
    return {
      command: 'command',
    };
  }

  static types(): { [key: string]: any } {
    return {
      command: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceHeartbeatResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeviceHeartbeatResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeviceHeartbeatResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeptRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeptResponseBody extends $tea.Model {
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

export class DeleteDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGuardianHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGuardianRequest extends $tea.Model {
  stuId?: string;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      stuId: 'stuId',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      stuId: 'string',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGuardianResponseBody extends $tea.Model {
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

export class DeleteGuardianResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteGuardianResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteGuardianResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequest extends $tea.Model {
  sectionModels?: InsertSectionConfigRequestSectionModels[];
  start?: InsertSectionConfigRequestStart;
  end?: InsertSectionConfigRequestEnd;
  scheduleName?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      sectionModels: 'sectionModels',
      start: 'start',
      end: 'end',
      scheduleName: 'scheduleName',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionModels: { 'type': 'array', 'itemType': InsertSectionConfigRequestSectionModels },
      start: InsertSectionConfigRequestStart,
      end: InsertSectionConfigRequestEnd,
      scheduleName: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigResponseBody extends $tea.Model {
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

export class InsertSectionConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: InsertSectionConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: InsertSectionConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceRequest extends $tea.Model {
  sn?: string;
  faceId?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
      faceId: 'faceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
      faceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceResponseBody extends $tea.Model {
  corpId?: string;
  faceId?: string;
  userId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      faceId: 'faceId',
      userId: 'userId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      faceId: 'string',
      userId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserFaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserFaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdRequest extends $tea.Model {
  operator?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponseBody extends $tea.Model {
  success?: boolean;
  result?: QueryDeviceListByCorpIdResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: QueryDeviceListByCorpIdResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDeviceListByCorpIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDeviceListByCorpIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequest extends $tea.Model {
  opUserId?: string;
  ext?: string;
  courseGroupCode?: string;
  courseGroupIntroduce?: string;
  courseGroupName?: string;
  courserGroupItemModels?: UpdateUniversityCourseGroupRequestCourserGroupItemModels[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      ext: 'ext',
      courseGroupCode: 'courseGroupCode',
      courseGroupIntroduce: 'courseGroupIntroduce',
      courseGroupName: 'courseGroupName',
      courserGroupItemModels: 'courserGroupItemModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      ext: 'string',
      courseGroupCode: 'string',
      courseGroupIntroduce: 'string',
      courseGroupName: 'string',
      courserGroupItemModels: { 'type': 'array', 'itemType': UpdateUniversityCourseGroupRequestCourserGroupItemModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupResponseBody extends $tea.Model {
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

export class UpdateUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequest extends $tea.Model {
  hwMedia?: string;
  hwContent?: string;
  hwTitle?: string;
  courseName?: string;
  hwPhoto?: string;
  hwVideo?: string;
  teacherName?: string;
  teacherUserId?: string;
  identifier?: string;
  attributes?: string;
  targetRole?: string;
  bizCode?: string;
  status?: string;
  scheduledRelease?: string;
  scheduledTime?: string;
  hwDeadlineOpen?: string;
  hwDeadline?: number;
  hwType?: string;
  openSelectItemList?: BatchOrgCreateHWRequestOpenSelectItemList[];
  dingOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      hwMedia: 'hwMedia',
      hwContent: 'hwContent',
      hwTitle: 'hwTitle',
      courseName: 'courseName',
      hwPhoto: 'hwPhoto',
      hwVideo: 'hwVideo',
      teacherName: 'teacherName',
      teacherUserId: 'teacherUserId',
      identifier: 'identifier',
      attributes: 'attributes',
      targetRole: 'targetRole',
      bizCode: 'bizCode',
      status: 'status',
      scheduledRelease: 'scheduledRelease',
      scheduledTime: 'scheduledTime',
      hwDeadlineOpen: 'hwDeadlineOpen',
      hwDeadline: 'hwDeadline',
      hwType: 'hwType',
      openSelectItemList: 'openSelectItemList',
      dingOrgId: 'dingOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hwMedia: 'string',
      hwContent: 'string',
      hwTitle: 'string',
      courseName: 'string',
      hwPhoto: 'string',
      hwVideo: 'string',
      teacherName: 'string',
      teacherUserId: 'string',
      identifier: 'string',
      attributes: 'string',
      targetRole: 'string',
      bizCode: 'string',
      status: 'string',
      scheduledRelease: 'string',
      scheduledTime: 'string',
      hwDeadlineOpen: 'string',
      hwDeadline: 'number',
      hwType: 'string',
      openSelectItemList: { 'type': 'array', 'itemType': BatchOrgCreateHWRequestOpenSelectItemList },
      dingOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponseBody extends $tea.Model {
  result?: BatchOrgCreateHWResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchOrgCreateHWResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchOrgCreateHWResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchOrgCreateHWResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptRequest extends $tea.Model {
  customDept?: CreateCustomDeptRequestCustomDept;
  superId?: number;
  operator?: string;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  dingOauthAppId?: number;
  dingCorpId?: string;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      customDept: 'customDept',
      superId: 'superId',
      operator: 'operator',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      dingOauthAppId: 'dingOauthAppId',
      dingCorpId: 'dingCorpId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customDept: CreateCustomDeptRequestCustomDept,
      superId: 'number',
      operator: 'string',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      dingOauthAppId: 'number',
      dingCorpId: 'string',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptResponseBody extends $tea.Model {
  success?: boolean;
  result?: CreateCustomDeptResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: CreateCustomDeptResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCustomDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCustomDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareRequest extends $tea.Model {
  ext?: string;
  courseGroupCode?: string;
  sectionIndex?: number[];
  deviceId?: string;
  liveCoverImage?: string;
  courseDate?: string;
  isvCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      ext: 'ext',
      courseGroupCode: 'courseGroupCode',
      sectionIndex: 'sectionIndex',
      deviceId: 'deviceId',
      liveCoverImage: 'liveCoverImage',
      courseDate: 'courseDate',
      isvCode: 'isvCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ext: 'string',
      courseGroupCode: 'string',
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
      deviceId: 'string',
      liveCoverImage: 'string',
      courseDate: 'string',
      isvCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareResponseBody extends $tea.Model {
  universityCourseCommonResponse?: StartCoursePrepareResponseBodyUniversityCourseCommonResponse;
  static names(): { [key: string]: string } {
    return {
      universityCourseCommonResponse: 'universityCourseCommonResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseCommonResponse: StartCoursePrepareResponseBodyUniversityCourseCommonResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartCoursePrepareResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartCoursePrepareResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolRequest extends $tea.Model {
  startTime?: number;
  endTime?: number;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      startTime: 'startTime',
      endTime: 'endTime',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'number',
      endTime: 'number',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBody extends $tea.Model {
  result?: QueryClassScheduleByTimeSchoolResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryClassScheduleByTimeSchoolResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryClassScheduleByTimeSchoolResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryClassScheduleByTimeSchoolResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsRequest extends $tea.Model {
  classIds?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classIds: 'classIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsResponseBody extends $tea.Model {
  result?: QueryTeachSubjectsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryTeachSubjectsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryTeachSubjectsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryTeachSubjectsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesResponseBody extends $tea.Model {
  result?: GetShareRolesResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetShareRolesResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetShareRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetShareRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdRequest extends $tea.Model {
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdResponseBody extends $tea.Model {
  pid?: string;
  name?: string;
  merchantId?: string;
  merchantName?: string;
  corpId?: string;
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      pid: 'pid',
      name: 'name',
      merchantId: 'merchantId',
      merchantName: 'merchantName',
      corpId: 'corpId',
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pid: 'string',
      name: 'string',
      merchantId: 'string',
      merchantName: 'string',
      corpId: 'string',
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGroupIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  studentUserIds?: string[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      studentUserIds: 'studentUserIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      studentUserIds: { 'type': 'array', 'itemType': 'string' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeUniversityCourseGroupResponseBody extends $tea.Model {
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

export class SubscribeUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SubscribeUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SubscribeUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgRelationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgRelationRequest extends $tea.Model {
  targetCorpId?: string;
  authCode?: string;
  static names(): { [key: string]: string } {
    return {
      targetCorpId: 'targetCorpId',
      authCode: 'authCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCorpId: 'string',
      authCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgRelationResponseBody extends $tea.Model {
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

export class DeleteOrgRelationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteOrgRelationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteOrgRelationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseRequest extends $tea.Model {
  opUserId?: string;
  ext?: string;
  courseCode?: string;
  livePlayInfoList?: StartCourseRequestLivePlayInfoList[];
  isvCode?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      ext: 'ext',
      courseCode: 'courseCode',
      livePlayInfoList: 'livePlayInfoList',
      isvCode: 'isvCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      ext: 'string',
      courseCode: 'string',
      livePlayInfoList: { 'type': 'array', 'itemType': StartCourseRequestLivePlayInfoList },
      isvCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseResponseBody extends $tea.Model {
  universityCourseCommonResponse?: StartCourseResponseBodyUniversityCourseCommonResponse;
  static names(): { [key: string]: string } {
    return {
      universityCourseCommonResponse: 'universityCourseCommonResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseCommonResponse: StartCourseResponseBodyUniversityCourseCommonResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomRequest extends $tea.Model {
  opUserId?: string;
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomResponseBody extends $tea.Model {
  success?: boolean;
  result?: QueryPhysicalClassroomResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: QueryPhysicalClassroomResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseRequest extends $tea.Model {
  courseName?: string;
  startTime?: number;
  endTime?: number;
  teachingParticipant?: UpdateRemoteClassCourseRequestTeachingParticipant;
  attendParticipants?: UpdateRemoteClassCourseRequestAttendParticipants[];
  courseCode?: string;
  dingClientId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingOauthAppId?: number;
  dingCorpId?: string;
  dingIsvOrgId?: number;
  authCode?: string;
  static names(): { [key: string]: string } {
    return {
      courseName: 'courseName',
      startTime: 'startTime',
      endTime: 'endTime',
      teachingParticipant: 'teachingParticipant',
      attendParticipants: 'attendParticipants',
      courseCode: 'courseCode',
      dingClientId: 'dingClientId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOauthAppId: 'dingOauthAppId',
      dingCorpId: 'dingCorpId',
      dingIsvOrgId: 'dingIsvOrgId',
      authCode: 'authCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseName: 'string',
      startTime: 'number',
      endTime: 'number',
      teachingParticipant: UpdateRemoteClassCourseRequestTeachingParticipant,
      attendParticipants: { 'type': 'array', 'itemType': UpdateRemoteClassCourseRequestAttendParticipants },
      courseCode: 'string',
      dingClientId: 'string',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingOauthAppId: 'number',
      dingCorpId: 'string',
      dingIsvOrgId: 'number',
      authCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseResponseBody extends $tea.Model {
  success?: boolean;
  result?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateRemoteClassCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateRemoteClassCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeUniversityCourseGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeUniversityCourseGroupRequest extends $tea.Model {
  courseGroupCode?: string;
  studentUserIds?: string[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
      studentUserIds: 'studentUserIds',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
      studentUserIds: { 'type': 'array', 'itemType': 'string' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeUniversityCourseGroupResponseBody extends $tea.Model {
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

export class UnsubscribeUniversityCourseGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UnsubscribeUniversityCourseGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UnsubscribeUniversityCourseGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyRequest extends $tea.Model {
  isvCode?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      isvCode: 'isvCode',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvCode: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyResponseBody extends $tea.Model {
  universitySecretKeyInfo?: QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo;
  static names(): { [key: string]: string } {
    return {
      universitySecretKeyInfo: 'universitySecretKeyInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universitySecretKeyInfo: QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryOrgSecretKeyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryOrgSecretKeyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersRequest extends $tea.Model {
  nameKeyword?: string;
  static names(): { [key: string]: string } {
    return {
      nameKeyword: 'nameKeyword',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameKeyword: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersResponseBody extends $tea.Model {
  users?: SearchTeachersResponseBodyUsers[];
  static names(): { [key: string]: string } {
    return {
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      users: { 'type': 'array', 'itemType': SearchTeachersResponseBodyUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchTeachersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchTeachersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePhysicalClassroomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePhysicalClassroomRequest extends $tea.Model {
  opUserId?: string;
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePhysicalClassroomResponseBody extends $tea.Model {
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

export class DeletePhysicalClassroomResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeletePhysicalClassroomResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeletePhysicalClassroomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListRequest extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListResponseBody extends $tea.Model {
  success?: boolean;
  result?: QueryOrgRelationListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: { 'type': 'array', 'itemType': QueryOrgRelationListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryOrgRelationListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryOrgRelationListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceRequest extends $tea.Model {
  type?: number;
  sn?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      sn: 'sn',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'number',
      sn: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceResponseBody extends $tea.Model {
  corpId?: string;
  hasMore?: boolean;
  userFaceList?: QuerySchoolUserFaceResponseBodyUserFaceList[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      hasMore: 'hasMore',
      userFaceList: 'userFaceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      hasMore: 'boolean',
      userFaceList: { 'type': 'array', 'itemType': QuerySchoolUserFaceResponseBodyUserFaceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QuerySchoolUserFaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QuerySchoolUserFaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTypeResponseBody extends $tea.Model {
  orgType?: number;
  static names(): { [key: string]: string } {
    return {
      orgType: 'orgType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryOrgTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryOrgTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityStudentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityStudentRequest extends $tea.Model {
  classId?: number;
  studentUserId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      studentUserId: 'studentUserId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      studentUserId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUniversityStudentResponseBody extends $tea.Model {
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

export class DeleteUniversityStudentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteUniversityStudentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteUniversityStudentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseRequest extends $tea.Model {
  opUserId?: string;
  ext?: string;
  courseCode?: string;
  livePlayInfoList?: EndCourseRequestLivePlayInfoList[];
  isvCode?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      ext: 'ext',
      courseCode: 'courseCode',
      livePlayInfoList: 'livePlayInfoList',
      isvCode: 'isvCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      ext: 'string',
      courseCode: 'string',
      livePlayInfoList: { 'type': 'array', 'itemType': EndCourseRequestLivePlayInfoList },
      isvCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseResponseBody extends $tea.Model {
  universityCourseCommonResponse?: EndCourseResponseBodyUniversityCourseCommonResponse;
  static names(): { [key: string]: string } {
    return {
      universityCourseCommonResponse: 'universityCourseCommonResponse',
    };
  }

  static types(): { [key: string]: any } {
    return {
      universityCourseCommonResponse: EndCourseResponseBodyUniversityCourseCommonResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EndCourseResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EndCourseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersResponseBody extends $tea.Model {
  result?: GetShareRoleMembersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetShareRoleMembersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetShareRoleMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetShareRoleMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityTeacherHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityTeacherRequest extends $tea.Model {
  dingIsvOrgId?: number;
  classId?: number;
  role?: string;
  teacherUserId?: string;
  dingSuiteKey?: string;
  opUserId?: string;
  dingOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      classId: 'classId',
      role: 'role',
      teacherUserId: 'teacherUserId',
      dingSuiteKey: 'dingSuiteKey',
      opUserId: 'opUserId',
      dingOrgId: 'dingOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      classId: 'number',
      role: 'string',
      teacherUserId: 'string',
      dingSuiteKey: 'string',
      opUserId: 'string',
      dingOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityTeacherResponseBody extends $tea.Model {
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

export class CreateUniversityTeacherResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateUniversityTeacherResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateUniversityTeacherResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatisticsDataResponseBodyResult extends $tea.Model {
  userId?: string;
  userName?: string;
  classId?: number;
  subjectName?: number;
  subjectCode?: string;
  courseHours?: number;
  courseCount?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      classId: 'classId',
      subjectName: 'subjectName',
      subjectCode: 'subjectCode',
      courseHours: 'courseHours',
      courseCount: 'courseCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: 'string',
      classId: 'number',
      subjectName: 'number',
      subjectCode: 'string',
      courseHours: 'number',
      courseCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultStart extends $tea.Model {
  year?: number;
  month?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      year: 'year',
      month: 'month',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      year: 'number',
      month: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultEnd extends $tea.Model {
  year?: number;
  month?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      year: 'year',
      month: 'month',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      year: 'number',
      month: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultSectionModelsStart extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResultSectionModels extends $tea.Model {
  sectionType?: string;
  start?: QueryClassScheduleConfigResponseBodyResultSectionModelsStart;
  sectionIndex?: number;
  end?: QueryClassScheduleConfigResponseBodyResultSectionModelsEnd;
  sectionName?: string;
  static names(): { [key: string]: string } {
    return {
      sectionType: 'sectionType',
      start: 'start',
      sectionIndex: 'sectionIndex',
      end: 'end',
      sectionName: 'sectionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionType: 'string',
      start: QueryClassScheduleConfigResponseBodyResultSectionModelsStart,
      sectionIndex: 'number',
      end: QueryClassScheduleConfigResponseBodyResultSectionModelsEnd,
      sectionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleConfigResponseBodyResult extends $tea.Model {
  classId?: number;
  start?: QueryClassScheduleConfigResponseBodyResultStart;
  end?: QueryClassScheduleConfigResponseBodyResultEnd;
  sectionModels?: QueryClassScheduleConfigResponseBodyResultSectionModels[];
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      start: 'start',
      end: 'end',
      sectionModels: 'sectionModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      start: QueryClassScheduleConfigResponseBodyResultStart,
      end: QueryClassScheduleConfigResponseBodyResultEnd,
      sectionModels: { 'type': 'array', 'itemType': QueryClassScheduleConfigResponseBodyResultSectionModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultChildResponseBodyBindStudents extends $tea.Model {
  corpId?: string;
  staffId?: string;
  classId?: number;
  period?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      staffId: 'staffId',
      classId: 'classId',
      period: 'period',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      staffId: 'string',
      classId: 'number',
      period: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCoursesResponseBodyCourseList extends $tea.Model {
  courseId?: string;
  title?: string;
  feedType?: number;
  teacherName?: string;
  coverUrl?: string;
  startTime?: number;
  jumpUrl?: string;
  teacherId?: string;
  static names(): { [key: string]: string } {
    return {
      courseId: 'courseId',
      title: 'title',
      feedType: 'feedType',
      teacherName: 'teacherName',
      coverUrl: 'coverUrl',
      startTime: 'startTime',
      jumpUrl: 'jumpUrl',
      teacherId: 'teacherId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseId: 'string',
      title: 'string',
      feedType: 'number',
      teacherName: 'string',
      coverUrl: 'string',
      startTime: 'number',
      jumpUrl: 'string',
      teacherId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataCardRuleItemParamList extends $tea.Model {
  cardTaskCode?: string;
  relationId?: string;
  cardRuleAttr?: string;
  dailyDubbing?: number;
  relationTitle?: string;
  relationUrl?: string;
  static names(): { [key: string]: string } {
    return {
      cardTaskCode: 'cardTaskCode',
      relationId: 'relationId',
      cardRuleAttr: 'cardRuleAttr',
      dailyDubbing: 'dailyDubbing',
      relationTitle: 'relationTitle',
      relationUrl: 'relationUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardTaskCode: 'string',
      relationId: 'string',
      cardRuleAttr: 'string',
      dailyDubbing: 'number',
      relationTitle: 'string',
      relationUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents extends $tea.Model {
  name?: string;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataOrgClassStudentGroupListClassList extends $tea.Model {
  classId?: number;
  className?: string;
  students?: BatchCreateRequestDataOrgClassStudentGroupListClassListStudents[];
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      className: 'className',
      students: 'students',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      className: 'string',
      students: { 'type': 'array', 'itemType': BatchCreateRequestDataOrgClassStudentGroupListClassListStudents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestDataOrgClassStudentGroupList extends $tea.Model {
  corpId?: string;
  classList?: BatchCreateRequestDataOrgClassStudentGroupListClassList[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      classList: 'classList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      classList: { 'type': 'array', 'itemType': BatchCreateRequestDataOrgClassStudentGroupListClassList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateRequestData extends $tea.Model {
  canReissueCard?: boolean;
  cardCycle?: number;
  cardFrequency?: number[];
  cardRuleItemParamList?: BatchCreateRequestDataCardRuleItemParamList[];
  classIds?: string[];
  classNames?: string[];
  content?: string;
  effectDate?: number;
  medias?: string;
  needMetering?: string;
  orgClassStudentGroupList?: BatchCreateRequestDataOrgClassStudentGroupList[];
  remindHour?: number;
  remindMinute?: number;
  targetRole?: string;
  templateId?: number;
  title?: string;
  unitOfMeasurement?: string;
  static names(): { [key: string]: string } {
    return {
      canReissueCard: 'canReissueCard',
      cardCycle: 'cardCycle',
      cardFrequency: 'cardFrequency',
      cardRuleItemParamList: 'cardRuleItemParamList',
      classIds: 'classIds',
      classNames: 'classNames',
      content: 'content',
      effectDate: 'effectDate',
      medias: 'medias',
      needMetering: 'needMetering',
      orgClassStudentGroupList: 'orgClassStudentGroupList',
      remindHour: 'remindHour',
      remindMinute: 'remindMinute',
      targetRole: 'targetRole',
      templateId: 'templateId',
      title: 'title',
      unitOfMeasurement: 'unitOfMeasurement',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canReissueCard: 'boolean',
      cardCycle: 'number',
      cardFrequency: { 'type': 'array', 'itemType': 'number' },
      cardRuleItemParamList: { 'type': 'array', 'itemType': BatchCreateRequestDataCardRuleItemParamList },
      classIds: { 'type': 'array', 'itemType': 'string' },
      classNames: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      effectDate: 'number',
      medias: 'string',
      needMetering: 'string',
      orgClassStudentGroupList: { 'type': 'array', 'itemType': BatchCreateRequestDataOrgClassStudentGroupList },
      remindHour: 'number',
      remindMinute: 'number',
      targetRole: 'string',
      templateId: 'number',
      title: 'string',
      unitOfMeasurement: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateResponseBodyResult extends $tea.Model {
  corpIdCardIdMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      corpIdCardIdMap: 'corpIdCardIdMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIdCardIdMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestCoursesDateModel extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestCoursesSectionModel extends $tea.Model {
  sectionIndex?: number;
  sectionName?: string;
  static names(): { [key: string]: string } {
    return {
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionIndex: 'number',
      sectionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestCourses extends $tea.Model {
  teacherStaffIds?: string[];
  courseName?: string;
  dateModel?: InitCoursesOfClassRequestCoursesDateModel;
  sectionModel?: InitCoursesOfClassRequestCoursesSectionModel;
  creatorName?: string;
  location?: string;
  static names(): { [key: string]: string } {
    return {
      teacherStaffIds: 'teacherStaffIds',
      courseName: 'courseName',
      dateModel: 'dateModel',
      sectionModel: 'sectionModel',
      creatorName: 'creatorName',
      location: 'location',
    };
  }

  static types(): { [key: string]: any } {
    return {
      teacherStaffIds: { 'type': 'array', 'itemType': 'string' },
      courseName: 'string',
      dateModel: InitCoursesOfClassRequestCoursesDateModel,
      sectionModel: InitCoursesOfClassRequestCoursesSectionModel,
      creatorName: 'string',
      location: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigSectionModelsStart extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigSectionModelsEnd extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigSectionModels extends $tea.Model {
  sectionType?: string;
  start?: InitCoursesOfClassRequestSectionConfigSectionModelsStart;
  sectionIndex?: number;
  end?: InitCoursesOfClassRequestSectionConfigSectionModelsEnd;
  static names(): { [key: string]: string } {
    return {
      sectionType: 'sectionType',
      start: 'start',
      sectionIndex: 'sectionIndex',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionType: 'string',
      start: InitCoursesOfClassRequestSectionConfigSectionModelsStart,
      sectionIndex: 'number',
      end: InitCoursesOfClassRequestSectionConfigSectionModelsEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigStart extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfigEnd extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitCoursesOfClassRequestSectionConfig extends $tea.Model {
  sectionModels?: InitCoursesOfClassRequestSectionConfigSectionModels[];
  start?: InitCoursesOfClassRequestSectionConfigStart;
  end?: InitCoursesOfClassRequestSectionConfigEnd;
  static names(): { [key: string]: string } {
    return {
      sectionModels: 'sectionModels',
      start: 'start',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionModels: { 'type': 'array', 'itemType': InitCoursesOfClassRequestSectionConfigSectionModels },
      start: InitCoursesOfClassRequestSectionConfigStart,
      end: InitCoursesOfClassRequestSectionConfigEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInviteUrlResponseBodyResult extends $tea.Model {
  inviteUrl?: string;
  static names(): { [key: string]: string } {
    return {
      inviteUrl: 'inviteUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList extends $tea.Model {
  liveInputUrl?: string;
  liveOutputUrl?: string;
  liveType?: number;
  replayUrl?: string;
  static names(): { [key: string]: string } {
    return {
      liveInputUrl: 'liveInputUrl',
      liveOutputUrl: 'liveOutputUrl',
      liveType: 'liveType',
      replayUrl: 'replayUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveInputUrl: 'string',
      liveOutputUrl: 'string',
      liveType: 'number',
      replayUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse extends $tea.Model {
  confirmStatus?: boolean;
  courseCode?: string;
  livePlayInfoList?: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList[];
  static names(): { [key: string]: string } {
    return {
      confirmStatus: 'confirmStatus',
      courseCode: 'courseCode',
      livePlayInfoList: 'livePlayInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      confirmStatus: 'boolean',
      courseCode: 'string',
      livePlayInfoList: { 'type': 'array', 'itemType': PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenCourseDetailResponseBodyPushModel extends $tea.Model {
  pushOrgNameList?: string[];
  pushRoleNameList?: string[];
  static names(): { [key: string]: string } {
    return {
      pushOrgNameList: 'pushOrgNameList',
      pushRoleNameList: 'pushRoleNameList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pushOrgNameList: { 'type': 'array', 'itemType': 'string' },
      pushRoleNameList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestCoursesDateModel extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestCoursesSectionModel extends $tea.Model {
  sectionType?: string;
  sectionIndex?: number;
  sectionName?: string;
  static names(): { [key: string]: string } {
    return {
      sectionType: 'sectionType',
      sectionIndex: 'sectionIndex',
      sectionName: 'sectionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionType: 'string',
      sectionIndex: 'number',
      sectionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestCourses extends $tea.Model {
  teacherStaffIds?: string[];
  courseName?: string;
  dateModel?: UpdateCoursesOfClassRequestCoursesDateModel;
  sectionModel?: UpdateCoursesOfClassRequestCoursesSectionModel;
  creatorName?: string;
  location?: string;
  deleteTag?: boolean;
  courseCode?: string;
  courseGroupCode?: string;
  static names(): { [key: string]: string } {
    return {
      teacherStaffIds: 'teacherStaffIds',
      courseName: 'courseName',
      dateModel: 'dateModel',
      sectionModel: 'sectionModel',
      creatorName: 'creatorName',
      location: 'location',
      deleteTag: 'deleteTag',
      courseCode: 'courseCode',
      courseGroupCode: 'courseGroupCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      teacherStaffIds: { 'type': 'array', 'itemType': 'string' },
      courseName: 'string',
      dateModel: UpdateCoursesOfClassRequestCoursesDateModel,
      sectionModel: UpdateCoursesOfClassRequestCoursesSectionModel,
      creatorName: 'string',
      location: 'string',
      deleteTag: 'boolean',
      courseCode: 'string',
      courseGroupCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfigSectionModels extends $tea.Model {
  sectionType?: string;
  start?: UpdateCoursesOfClassRequestSectionConfigSectionModelsStart;
  sectionIndex?: number;
  end?: UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd;
  static names(): { [key: string]: string } {
    return {
      sectionType: 'sectionType',
      start: 'start',
      sectionIndex: 'sectionIndex',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionType: 'string',
      start: UpdateCoursesOfClassRequestSectionConfigSectionModelsStart,
      sectionIndex: 'number',
      end: UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCoursesOfClassRequestSectionConfig extends $tea.Model {
  sectionModels?: UpdateCoursesOfClassRequestSectionConfigSectionModels[];
  static names(): { [key: string]: string } {
    return {
      sectionModels: 'sectionModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionModels: { 'type': 'array', 'itemType': UpdateCoursesOfClassRequestSectionConfigSectionModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionStartDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionModels extends $tea.Model {
  sectionType?: string;
  sectionStartTime?: CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime;
  sectionIndex?: number;
  sectionEndTime?: CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime;
  sectionName?: string;
  static names(): { [key: string]: string } {
    return {
      sectionType: 'sectionType',
      sectionStartTime: 'sectionStartTime',
      sectionIndex: 'sectionIndex',
      sectionEndTime: 'sectionEndTime',
      sectionName: 'sectionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionType: 'string',
      sectionStartTime: CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime,
      sectionIndex: 'number',
      sectionEndTime: CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime,
      sectionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSectionEndDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSemesterStartDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigsSemesterEndDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSectionConfigRequestSectionConfigs extends $tea.Model {
  semester?: number;
  sectionStartDate?: CreateSectionConfigRequestSectionConfigsSectionStartDate;
  schoolYear?: string;
  scheduleName?: string;
  sectionModels?: CreateSectionConfigRequestSectionConfigsSectionModels[];
  sectionEndDate?: CreateSectionConfigRequestSectionConfigsSectionEndDate;
  semesterStartDate?: CreateSectionConfigRequestSectionConfigsSemesterStartDate;
  semesterEndDate?: CreateSectionConfigRequestSectionConfigsSemesterEndDate;
  static names(): { [key: string]: string } {
    return {
      semester: 'semester',
      sectionStartDate: 'sectionStartDate',
      schoolYear: 'schoolYear',
      scheduleName: 'scheduleName',
      sectionModels: 'sectionModels',
      sectionEndDate: 'sectionEndDate',
      semesterStartDate: 'semesterStartDate',
      semesterEndDate: 'semesterEndDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      semester: 'number',
      sectionStartDate: CreateSectionConfigRequestSectionConfigsSectionStartDate,
      schoolYear: 'string',
      scheduleName: 'string',
      sectionModels: { 'type': 'array', 'itemType': CreateSectionConfigRequestSectionConfigsSectionModels },
      sectionEndDate: CreateSectionConfigRequestSectionConfigsSectionEndDate,
      semesterStartDate: CreateSectionConfigRequestSectionConfigsSemesterStartDate,
      semesterEndDate: CreateSectionConfigRequestSectionConfigsSemesterEndDate,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubjectTeachersResponseBodyResult extends $tea.Model {
  teacherName?: string;
  subjectName?: string;
  subjectCode?: string;
  periodCode?: string;
  corpId?: string;
  teacherUserId?: string;
  classId?: number;
  static names(): { [key: string]: string } {
    return {
      teacherName: 'teacherName',
      subjectName: 'subjectName',
      subjectCode: 'subjectCode',
      periodCode: 'periodCode',
      corpId: 'corpId',
      teacherUserId: 'teacherUserId',
      classId: 'classId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      teacherName: 'string',
      subjectName: 'string',
      subjectCode: 'string',
      periodCode: 'string',
      corpId: 'string',
      teacherUserId: 'string',
      classId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBodyResultTeachingParticipant extends $tea.Model {
  participantName?: string;
  participantId?: string;
  corpId?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      participantName: 'participantName',
      participantId: 'participantId',
      corpId: 'corpId',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantName: 'string',
      participantId: 'string',
      corpId: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBodyResultAttendParticipants extends $tea.Model {
  participantName?: string;
  participantId?: string;
  corpId?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      participantName: 'participantName',
      participantId: 'participantId',
      corpId: 'corpId',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantName: 'string',
      participantId: 'string',
      corpId: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRemoteClassCourseResponseBodyResult extends $tea.Model {
  courseCode?: string;
  courseName?: string;
  status?: number;
  startTime?: number;
  endTime?: number;
  canEdit?: boolean;
  teachingParticipant?: QueryRemoteClassCourseResponseBodyResultTeachingParticipant;
  attendParticipants?: QueryRemoteClassCourseResponseBodyResultAttendParticipants[];
  courseWays?: string[];
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      courseName: 'courseName',
      status: 'status',
      startTime: 'startTime',
      endTime: 'endTime',
      canEdit: 'canEdit',
      teachingParticipant: 'teachingParticipant',
      attendParticipants: 'attendParticipants',
      courseWays: 'courseWays',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      courseName: 'string',
      status: 'number',
      startTime: 'number',
      endTime: 'number',
      canEdit: 'boolean',
      teachingParticipant: QueryRemoteClassCourseResponseBodyResultTeachingParticipant,
      attendParticipants: { 'type': 'array', 'itemType': QueryRemoteClassCourseResponseBodyResultAttendParticipants },
      courseWays: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigStart extends $tea.Model {
  year?: number;
  month?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      year: 'year',
      month: 'month',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      year: 'number',
      month: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigSectionModelsStart extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigSectionModelsEnd extends $tea.Model {
  hour?: number;
  min?: number;
  static names(): { [key: string]: string } {
    return {
      hour: 'hour',
      min: 'min',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hour: 'number',
      min: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigSectionModels extends $tea.Model {
  sectionName?: string;
  sectionType?: string;
  sectionIndex?: number;
  start?: QueryClassScheduleResponseBodyConfigSectionModelsStart;
  end?: QueryClassScheduleResponseBodyConfigSectionModelsEnd;
  static names(): { [key: string]: string } {
    return {
      sectionName: 'sectionName',
      sectionType: 'sectionType',
      sectionIndex: 'sectionIndex',
      start: 'start',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionName: 'string',
      sectionType: 'string',
      sectionIndex: 'number',
      start: QueryClassScheduleResponseBodyConfigSectionModelsStart,
      end: QueryClassScheduleResponseBodyConfigSectionModelsEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfigEnd extends $tea.Model {
  year?: number;
  month?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      year: 'year',
      month: 'month',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      year: 'number',
      month: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyConfig extends $tea.Model {
  start?: QueryClassScheduleResponseBodyConfigStart;
  sectionModels?: QueryClassScheduleResponseBodyConfigSectionModels[];
  end?: QueryClassScheduleResponseBodyConfigEnd;
  static names(): { [key: string]: string } {
    return {
      start: 'start',
      sectionModels: 'sectionModels',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      start: QueryClassScheduleResponseBodyConfigStart,
      sectionModels: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyConfigSectionModels },
      end: QueryClassScheduleResponseBodyConfigEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyCourseDTOSClassrooms extends $tea.Model {
  targetId?: string;
  interactInfo?: string;
  static names(): { [key: string]: string } {
    return {
      targetId: 'targetId',
      interactInfo: 'interactInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetId: 'string',
      interactInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyCourseDTOSEduUserModels extends $tea.Model {
  userId?: string;
  uid?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      uid: 'uid',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      uid: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleResponseBodyCourseDTOS extends $tea.Model {
  code?: string;
  name?: string;
  introduce?: string;
  coverUrl?: string;
  startTime?: number;
  endTime?: number;
  creatorCorpId?: string;
  creatorUserId?: string;
  creatorUserName?: string;
  teacherCorpId?: string;
  teacherUserId?: string;
  teacherUserName?: string;
  subjectCode?: string;
  courseGroupCode?: string;
  status?: number;
  classrooms?: QueryClassScheduleResponseBodyCourseDTOSClassrooms[];
  eduUserModels?: QueryClassScheduleResponseBodyCourseDTOSEduUserModels[];
  sectionName?: string;
  sectionIndex?: number;
  classId?: number;
  extInfo?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      introduce: 'introduce',
      coverUrl: 'coverUrl',
      startTime: 'startTime',
      endTime: 'endTime',
      creatorCorpId: 'creatorCorpId',
      creatorUserId: 'creatorUserId',
      creatorUserName: 'creatorUserName',
      teacherCorpId: 'teacherCorpId',
      teacherUserId: 'teacherUserId',
      teacherUserName: 'teacherUserName',
      subjectCode: 'subjectCode',
      courseGroupCode: 'courseGroupCode',
      status: 'status',
      classrooms: 'classrooms',
      eduUserModels: 'eduUserModels',
      sectionName: 'sectionName',
      sectionIndex: 'sectionIndex',
      classId: 'classId',
      extInfo: 'extInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      introduce: 'string',
      coverUrl: 'string',
      startTime: 'number',
      endTime: 'number',
      creatorCorpId: 'string',
      creatorUserId: 'string',
      creatorUserName: 'string',
      teacherCorpId: 'string',
      teacherUserId: 'string',
      teacherUserName: 'string',
      subjectCode: 'string',
      courseGroupCode: 'string',
      status: 'number',
      classrooms: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyCourseDTOSClassrooms },
      eduUserModels: { 'type': 'array', 'itemType': QueryClassScheduleResponseBodyCourseDTOSEduUserModels },
      sectionName: 'string',
      sectionIndex: 'number',
      classId: 'number',
      extInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseRequestTeachingParticipant extends $tea.Model {
  participantId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseRequestAttendParticipants extends $tea.Model {
  participantId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRemoteClassCourseResponseBodyResult extends $tea.Model {
  courseCode?: string;
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassRequestCustomClass extends $tea.Model {
  name?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomClassResponseBodyResult extends $tea.Model {
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEduAssetSpacesResponseBodySpaces extends $tea.Model {
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  quota?: number;
  usedQuota?: number;
  permissionMode?: string;
  createTimeMillis?: number;
  modifyTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
      permissionMode: 'permissionMode',
      createTimeMillis: 'createTimeMillis',
      modifyTimeMillis: 'modifyTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      quota: 'number',
      usedQuota: 'number',
      permissionMode: 'string',
      createTimeMillis: 'number',
      modifyTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestTeacherInfos extends $tea.Model {
  userId?: string;
  participantRole?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      participantRole: 'participantRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      participantRole: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupRequestCourserGroupItemModels extends $tea.Model {
  dayOfWeek?: number;
  classPeriodType?: number;
  courserGroupItemStartDate?: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate;
  sectionIndex?: number[];
  courserGroupItemEndDate?: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate;
  courseType?: number;
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfWeek: 'dayOfWeek',
      classPeriodType: 'classPeriodType',
      courserGroupItemStartDate: 'courserGroupItemStartDate',
      sectionIndex: 'sectionIndex',
      courserGroupItemEndDate: 'courserGroupItemEndDate',
      courseType: 'courseType',
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfWeek: 'number',
      classPeriodType: 'number',
      courserGroupItemStartDate: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate,
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
      courserGroupItemEndDate: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate,
      courseType: 'number',
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUniversityCourseGroupResponseBodyCourseGroupInfo extends $tea.Model {
  courseGroupCode?: string;
  static names(): { [key: string]: string } {
    return {
      courseGroupCode: 'courseGroupCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseGroupCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResultTeachingParticipant extends $tea.Model {
  participantId?: string;
  participantName?: string;
  corpId?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      participantName: 'participantName',
      corpId: 'corpId',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      participantName: 'string',
      corpId: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResultAttendParticipants extends $tea.Model {
  participantId?: string;
  participantName?: string;
  corpId?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      participantName: 'participantName',
      corpId: 'corpId',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      participantName: 'string',
      corpId: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResultRecordInfos extends $tea.Model {
  url?: string;
  startTime?: string;
  stopTime?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
      startTime: 'startTime',
      stopTime: 'stopTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
      startTime: 'string',
      stopTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRemoteClassCourseResponseBodyResult extends $tea.Model {
  courseCode?: string;
  courseName?: string;
  startTime?: number;
  endTime?: number;
  status?: number;
  roomStatus?: number;
  canEdit?: boolean;
  teachingParticipant?: GetRemoteClassCourseResponseBodyResultTeachingParticipant;
  attendParticipants?: GetRemoteClassCourseResponseBodyResultAttendParticipants[];
  liveUrl?: string;
  recordInfos?: GetRemoteClassCourseResponseBodyResultRecordInfos[];
  static names(): { [key: string]: string } {
    return {
      courseCode: 'courseCode',
      courseName: 'courseName',
      startTime: 'startTime',
      endTime: 'endTime',
      status: 'status',
      roomStatus: 'roomStatus',
      canEdit: 'canEdit',
      teachingParticipant: 'teachingParticipant',
      attendParticipants: 'attendParticipants',
      liveUrl: 'liveUrl',
      recordInfos: 'recordInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseCode: 'string',
      courseName: 'string',
      startTime: 'number',
      endTime: 'number',
      status: 'number',
      roomStatus: 'number',
      canEdit: 'boolean',
      teachingParticipant: GetRemoteClassCourseResponseBodyResultTeachingParticipant,
      attendParticipants: { 'type': 'array', 'itemType': GetRemoteClassCourseResponseBodyResultAttendParticipants },
      liveUrl: 'string',
      recordInfos: { 'type': 'array', 'itemType': GetRemoteClassCourseResponseBodyResultRecordInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate extends $tea.Model {
  year?: number;
  month?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      year: 'year',
      month: 'month',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      year: 'number',
      month: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate extends $tea.Model {
  year?: number;
  month?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      year: 'year',
      month: 'month',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      year: 'number',
      month: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels extends $tea.Model {
  classroomId?: number;
  classPeriodType?: number;
  dayOfWeek?: number;
  sectionIndex?: number[];
  courserGroupItemStartDate?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate;
  courserGroupItemEndDate?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate;
  courseType?: number;
  static names(): { [key: string]: string } {
    return {
      classroomId: 'classroomId',
      classPeriodType: 'classPeriodType',
      dayOfWeek: 'dayOfWeek',
      sectionIndex: 'sectionIndex',
      courserGroupItemStartDate: 'courserGroupItemStartDate',
      courserGroupItemEndDate: 'courserGroupItemEndDate',
      courseType: 'courseType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomId: 'number',
      classPeriodType: 'number',
      dayOfWeek: 'number',
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
      courserGroupItemStartDate: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate,
      courserGroupItemEndDate: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate,
      courseType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo extends $tea.Model {
  isvCourseGroupCode?: string;
  courseGroupCode?: string;
  courseGroupName?: string;
  courseGroupIntroduce?: string;
  schoolYear?: string;
  semester?: number;
  periodCode?: string;
  subjectName?: string;
  courserGroupItemModels?: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels[];
  static names(): { [key: string]: string } {
    return {
      isvCourseGroupCode: 'isvCourseGroupCode',
      courseGroupCode: 'courseGroupCode',
      courseGroupName: 'courseGroupName',
      courseGroupIntroduce: 'courseGroupIntroduce',
      schoolYear: 'schoolYear',
      semester: 'semester',
      periodCode: 'periodCode',
      subjectName: 'subjectName',
      courserGroupItemModels: 'courserGroupItemModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvCourseGroupCode: 'string',
      courseGroupCode: 'string',
      courseGroupName: 'string',
      courseGroupIntroduce: 'string',
      schoolYear: 'string',
      semester: 'number',
      periodCode: 'string',
      subjectName: 'string',
      courserGroupItemModels: { 'type': 'array', 'itemType': QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList extends $tea.Model {
  userId?: string;
  name?: string;
  avator?: string;
  uid?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      avator: 'avator',
      uid: 'uid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      avator: 'string',
      uid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBodyResultExt extends $tea.Model {
  fontColor?: string;
  backgroundColor?: string;
  classId?: number;
  teacherList?: QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList[];
  static names(): { [key: string]: string } {
    return {
      fontColor: 'fontColor',
      backgroundColor: 'backgroundColor',
      classId: 'classId',
      teacherList: 'teacherList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fontColor: 'string',
      backgroundColor: 'string',
      classId: 'number',
      teacherList: { 'type': 'array', 'itemType': QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllSubjectsFromClassScheduleResponseBodyResult extends $tea.Model {
  subjectName?: string;
  subjectCode?: string;
  periodCode?: string;
  creatorOrgId?: number;
  ext?: QueryAllSubjectsFromClassScheduleResponseBodyResultExt;
  static names(): { [key: string]: string } {
    return {
      subjectName: 'subjectName',
      subjectCode: 'subjectCode',
      periodCode: 'periodCode',
      creatorOrgId: 'creatorOrgId',
      ext: 'ext',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subjectName: 'string',
      subjectCode: 'string',
      periodCode: 'string',
      creatorOrgId: 'number',
      ext: QueryAllSubjectsFromClassScheduleResponseBodyResultExt,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestSectionModelsStart extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestSectionModelsEnd extends $tea.Model {
  min?: number;
  hour?: number;
  static names(): { [key: string]: string } {
    return {
      min: 'min',
      hour: 'hour',
    };
  }

  static types(): { [key: string]: any } {
    return {
      min: 'number',
      hour: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestSectionModels extends $tea.Model {
  sectionType?: string;
  start?: InsertSectionConfigRequestSectionModelsStart;
  sectionIndex?: number;
  end?: InsertSectionConfigRequestSectionModelsEnd;
  sectionName?: string;
  static names(): { [key: string]: string } {
    return {
      sectionType: 'sectionType',
      start: 'start',
      sectionIndex: 'sectionIndex',
      end: 'end',
      sectionName: 'sectionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sectionType: 'string',
      start: InsertSectionConfigRequestSectionModelsStart,
      sectionIndex: 'number',
      end: InsertSectionConfigRequestSectionModelsEnd,
      sectionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestStart extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSectionConfigRequestEnd extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponseBodyResultList extends $tea.Model {
  appStatus?: number;
  deviceCode?: string;
  deviceName?: string;
  static names(): { [key: string]: string } {
    return {
      appStatus: 'appStatus',
      deviceCode: 'deviceCode',
      deviceName: 'deviceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appStatus: 'number',
      deviceCode: 'string',
      deviceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceListByCorpIdResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: QueryDeviceListByCorpIdResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryDeviceListByCorpIdResponseBodyResultList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends $tea.Model {
  month?: number;
  year?: number;
  dayOfMonth?: number;
  static names(): { [key: string]: string } {
    return {
      month: 'month',
      year: 'year',
      dayOfMonth: 'dayOfMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      month: 'number',
      year: 'number',
      dayOfMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUniversityCourseGroupRequestCourserGroupItemModels extends $tea.Model {
  dayOfWeek?: number;
  classPeriodType?: number;
  courserGroupItemStartDate?: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate;
  sectionIndex?: number[];
  courserGroupItemEndDate?: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate;
  courseType?: number;
  classroomId?: number;
  static names(): { [key: string]: string } {
    return {
      dayOfWeek: 'dayOfWeek',
      classPeriodType: 'classPeriodType',
      courserGroupItemStartDate: 'courserGroupItemStartDate',
      sectionIndex: 'sectionIndex',
      courserGroupItemEndDate: 'courserGroupItemEndDate',
      courseType: 'courseType',
      classroomId: 'classroomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfWeek: 'number',
      classPeriodType: 'number',
      courserGroupItemStartDate: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate,
      sectionIndex: { 'type': 'array', 'itemType': 'number' },
      courserGroupItemEndDate: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate,
      courseType: 'number',
      classroomId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents extends $tea.Model {
  name?: string;
  staffId?: string;
  avatar?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      staffId: 'staffId',
      avatar: 'avatar',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      staffId: 'string',
      avatar: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequestOpenSelectItemListClassList extends $tea.Model {
  classId?: string;
  className?: string;
  all?: boolean;
  students?: BatchOrgCreateHWRequestOpenSelectItemListClassListStudents[];
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      className: 'className',
      all: 'all',
      students: 'students',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'string',
      className: 'string',
      all: 'boolean',
      students: { 'type': 'array', 'itemType': BatchOrgCreateHWRequestOpenSelectItemListClassListStudents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWRequestOpenSelectItemList extends $tea.Model {
  corpId?: string;
  selectedClassesDesc?: string;
  classList?: BatchOrgCreateHWRequestOpenSelectItemListClassList[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      selectedClassesDesc: 'selectedClassesDesc',
      classList: 'classList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      selectedClassesDesc: 'string',
      classList: { 'type': 'array', 'itemType': BatchOrgCreateHWRequestOpenSelectItemListClassList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponseBodyResultPublishList extends $tea.Model {
  corpid?: string;
  hwid?: number;
  static names(): { [key: string]: string } {
    return {
      corpid: 'corpid',
      hwid: 'hwid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpid: 'string',
      hwid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOrgCreateHWResponseBodyResult extends $tea.Model {
  publishList?: BatchOrgCreateHWResponseBodyResultPublishList[];
  static names(): { [key: string]: string } {
    return {
      publishList: 'publishList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      publishList: { 'type': 'array', 'itemType': BatchOrgCreateHWResponseBodyResultPublishList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptRequestCustomDept extends $tea.Model {
  type?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomDeptResponseBodyResult extends $tea.Model {
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCoursePrepareResponseBodyUniversityCourseCommonResponse extends $tea.Model {
  success?: boolean;
  courseCode?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      courseCode: 'courseCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      courseCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms extends $tea.Model {
  targetId?: string;
  interactInfo?: string;
  static names(): { [key: string]: string } {
    return {
      targetId: 'targetId',
      interactInfo: 'interactInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetId: 'string',
      interactInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels extends $tea.Model {
  userId?: string;
  uid?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      uid: 'uid',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      uid: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryClassScheduleByTimeSchoolResponseBodyResult extends $tea.Model {
  code?: string;
  name?: string;
  introduce?: string;
  coverUrl?: string;
  startTime?: number;
  endTime?: number;
  creatorCorpId?: string;
  creatorUserId?: string;
  creatorUserName?: string;
  teacherCorpId?: string;
  teacherUserId?: string;
  teacherUserName?: string;
  bizKey?: string;
  subjectCode?: string;
  courseGroupCode?: string;
  status?: number;
  classrooms?: QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms[];
  eduUserModels?: QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels[];
  sectionName?: string;
  sectionIndex?: number;
  classId?: number;
  extInfo?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
      introduce: 'introduce',
      coverUrl: 'coverUrl',
      startTime: 'startTime',
      endTime: 'endTime',
      creatorCorpId: 'creatorCorpId',
      creatorUserId: 'creatorUserId',
      creatorUserName: 'creatorUserName',
      teacherCorpId: 'teacherCorpId',
      teacherUserId: 'teacherUserId',
      teacherUserName: 'teacherUserName',
      bizKey: 'bizKey',
      subjectCode: 'subjectCode',
      courseGroupCode: 'courseGroupCode',
      status: 'status',
      classrooms: 'classrooms',
      eduUserModels: 'eduUserModels',
      sectionName: 'sectionName',
      sectionIndex: 'sectionIndex',
      classId: 'classId',
      extInfo: 'extInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
      introduce: 'string',
      coverUrl: 'string',
      startTime: 'number',
      endTime: 'number',
      creatorCorpId: 'string',
      creatorUserId: 'string',
      creatorUserName: 'string',
      teacherCorpId: 'string',
      teacherUserId: 'string',
      teacherUserName: 'string',
      bizKey: 'string',
      subjectCode: 'string',
      courseGroupCode: 'string',
      status: 'number',
      classrooms: { 'type': 'array', 'itemType': QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms },
      eduUserModels: { 'type': 'array', 'itemType': QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels },
      sectionName: 'string',
      sectionIndex: 'number',
      classId: 'number',
      extInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTeachSubjectsResponseBodyResult extends $tea.Model {
  teacherName?: string;
  subjectName?: string;
  subjectCode?: string;
  periodCode?: string;
  corpId?: string;
  teacherUserId?: string;
  classId?: number;
  static names(): { [key: string]: string } {
    return {
      teacherName: 'teacherName',
      subjectName: 'subjectName',
      subjectCode: 'subjectCode',
      periodCode: 'periodCode',
      corpId: 'corpId',
      teacherUserId: 'teacherUserId',
      classId: 'classId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      teacherName: 'string',
      subjectName: 'string',
      subjectCode: 'string',
      periodCode: 'string',
      corpId: 'string',
      teacherUserId: 'string',
      classId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRolesResponseBodyResult extends $tea.Model {
  shareRoleCode?: string;
  shareRoleName?: string;
  static names(): { [key: string]: string } {
    return {
      shareRoleCode: 'shareRoleCode',
      shareRoleName: 'shareRoleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shareRoleCode: 'string',
      shareRoleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseRequestLivePlayInfoList extends $tea.Model {
  liveOutputHlsUrl?: string;
  liveType?: number;
  liveInputUrl?: string;
  replayUrl?: string;
  liveOutputFlvUrl?: string;
  static names(): { [key: string]: string } {
    return {
      liveOutputHlsUrl: 'liveOutputHlsUrl',
      liveType: 'liveType',
      liveInputUrl: 'liveInputUrl',
      replayUrl: 'replayUrl',
      liveOutputFlvUrl: 'liveOutputFlvUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveOutputHlsUrl: 'string',
      liveType: 'number',
      liveInputUrl: 'string',
      replayUrl: 'string',
      liveOutputFlvUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCourseResponseBodyUniversityCourseCommonResponse extends $tea.Model {
  success?: boolean;
  courseCode?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      courseCode: 'courseCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      courseCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPhysicalClassroomResponseBodyResult extends $tea.Model {
  classroomId?: number;
  classroomName?: string;
  classroomCampus?: string;
  classroomBuilding?: string;
  classroomFloor?: string;
  classroomNumber?: string;
  directBroadcast?: string;
  static names(): { [key: string]: string } {
    return {
      classroomId: 'classroomId',
      classroomName: 'classroomName',
      classroomCampus: 'classroomCampus',
      classroomBuilding: 'classroomBuilding',
      classroomFloor: 'classroomFloor',
      classroomNumber: 'classroomNumber',
      directBroadcast: 'directBroadcast',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classroomId: 'number',
      classroomName: 'string',
      classroomCampus: 'string',
      classroomBuilding: 'string',
      classroomFloor: 'string',
      classroomNumber: 'string',
      directBroadcast: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseRequestTeachingParticipant extends $tea.Model {
  participantId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRemoteClassCourseRequestAttendParticipants extends $tea.Model {
  participantId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo extends $tea.Model {
  secretKey?: string;
  static names(): { [key: string]: string } {
    return {
      secretKey: 'secretKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      secretKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTeachersResponseBodyUsers extends $tea.Model {
  userId?: string;
  name?: string;
  classId?: number;
  deptName?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      classId: 'classId',
      deptName: 'deptName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      classId: 'number',
      deptName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgRelationListResponseBodyResult extends $tea.Model {
  corpId?: string;
  name?: string;
  deviceCount?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      name: 'name',
      deviceCount: 'deviceCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      name: 'string',
      deviceCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySchoolUserFaceResponseBodyUserFaceList extends $tea.Model {
  faceId?: string;
  userId?: string;
  name?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      faceId: 'faceId',
      userId: 'userId',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      faceId: 'string',
      userId: 'string',
      name: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseRequestLivePlayInfoList extends $tea.Model {
  liveOutputHlsUrl?: string;
  liveType?: number;
  liveInputUrl?: string;
  replayUrl?: string;
  liveOutputFlvUrl?: string;
  static names(): { [key: string]: string } {
    return {
      liveOutputHlsUrl: 'liveOutputHlsUrl',
      liveType: 'liveType',
      liveInputUrl: 'liveInputUrl',
      replayUrl: 'replayUrl',
      liveOutputFlvUrl: 'liveOutputFlvUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveOutputHlsUrl: 'string',
      liveType: 'number',
      liveInputUrl: 'string',
      replayUrl: 'string',
      liveOutputFlvUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EndCourseResponseBodyUniversityCourseCommonResponse extends $tea.Model {
  success?: boolean;
  courseCode?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      courseCode: 'courseCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      courseCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRoleMembersResponseBodyResult extends $tea.Model {
  corpId?: string;
  memberUserIdListInTrunkOrg?: string[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberUserIdListInTrunkOrg: 'memberUserIdListInTrunkOrg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberUserIdListInTrunkOrg: { 'type': 'array', 'itemType': 'string' },
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


  async queryStatisticsData(request: QueryStatisticsDataRequest): Promise<QueryStatisticsDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryStatisticsDataHeaders({ });
    return await this.queryStatisticsDataWithOptions(request, headers, runtime);
  }

  async queryStatisticsDataWithOptions(request: QueryStatisticsDataRequest, headers: QueryStatisticsDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryStatisticsDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sectionIndexList)) {
      body["sectionIndexList"] = request.sectionIndexList;
    }

    if (!Util.isUnset(request.teacherUserIds)) {
      body["teacherUserIds"] = request.teacherUserIds;
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
    return $tea.cast<QueryStatisticsDataResponse>(await this.doROARequest("QueryStatisticsData", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/classes/schedules/statisticData/query`, "json", req, runtime), new QueryStatisticsDataResponse({}));
  }

  async queryClassScheduleConfig(request: QueryClassScheduleConfigRequest): Promise<QueryClassScheduleConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClassScheduleConfigHeaders({ });
    return await this.queryClassScheduleConfigWithOptions(request, headers, runtime);
  }

  async queryClassScheduleConfigWithOptions(tmpReq: QueryClassScheduleConfigRequest, headers: QueryClassScheduleConfigHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClassScheduleConfigResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryClassScheduleConfigShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.classIds)) {
      request.classIdsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIdsShrink)) {
      query["classIds"] = request.classIdsShrink;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<QueryClassScheduleConfigResponse>(await this.doROARequest("QueryClassScheduleConfig", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/schedules/configs`, "json", req, runtime), new QueryClassScheduleConfigResponse({}));
  }

  async getDefaultChild(): Promise<GetDefaultChildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDefaultChildHeaders({ });
    return await this.getDefaultChildWithOptions(headers, runtime);
  }

  async getDefaultChildWithOptions(headers: GetDefaultChildHeaders, runtime: $Util.RuntimeOptions): Promise<GetDefaultChildResponse> {
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
    return $tea.cast<GetDefaultChildResponse>(await this.doROARequest("GetDefaultChild", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/defaultChildren`, "json", req, runtime), new GetDefaultChildResponse({}));
  }

  async getOpenCourses(request: GetOpenCoursesRequest): Promise<GetOpenCoursesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenCoursesHeaders({ });
    return await this.getOpenCoursesWithOptions(request, headers, runtime);
  }

  async getOpenCoursesWithOptions(request: GetOpenCoursesRequest, headers: GetOpenCoursesHeaders, runtime: $Util.RuntimeOptions): Promise<GetOpenCoursesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<GetOpenCoursesResponse>(await this.doROARequest("GetOpenCourses", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/openCourses`, "json", req, runtime), new GetOpenCoursesResponse({}));
  }

  async createUniversityStudent(request: CreateUniversityStudentRequest): Promise<CreateUniversityStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUniversityStudentHeaders({ });
    return await this.createUniversityStudentWithOptions(request, headers, runtime);
  }

  async createUniversityStudentWithOptions(request: CreateUniversityStudentRequest, headers: CreateUniversityStudentHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUniversityStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.studentNumber)) {
      body["studentNumber"] = request.studentNumber;
    }

    if (!Util.isUnset(request.classId)) {
      body["classId"] = request.classId;
    }

    if (!Util.isUnset(request.gender)) {
      body["gender"] = request.gender;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.identityNumber)) {
      body["identityNumber"] = request.identityNumber;
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
    return $tea.cast<CreateUniversityStudentResponse>(await this.doROARequest("CreateUniversityStudent", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/students`, "json", req, runtime), new CreateUniversityStudentResponse({}));
  }

  async batchCreate(request: BatchCreateRequest): Promise<BatchCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateHeaders({ });
    return await this.batchCreateWithOptions(request, headers, runtime);
  }

  async batchCreateWithOptions(request: BatchCreateRequest, headers: BatchCreateHeaders, runtime: $Util.RuntimeOptions): Promise<BatchCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizCode)) {
      body["cardBizCode"] = request.cardBizCode;
    }

    if (!Util.isUnset($tea.toMap(request.data))) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.identifier)) {
      body["identifier"] = request.identifier;
    }

    if (!Util.isUnset(request.sourceType)) {
      body["sourceType"] = request.sourceType;
    }

    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.jsVersion)) {
      body["jsVersion"] = request.jsVersion;
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
    return $tea.cast<BatchCreateResponse>(await this.doROARequest("BatchCreate", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/cards`, "json", req, runtime), new BatchCreateResponse({}));
  }

  async initCoursesOfClass(classId: string, request: InitCoursesOfClassRequest): Promise<InitCoursesOfClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitCoursesOfClassHeaders({ });
    return await this.initCoursesOfClassWithOptions(classId, request, headers, runtime);
  }

  async initCoursesOfClassWithOptions(classId: string, request: InitCoursesOfClassRequest, headers: InitCoursesOfClassHeaders, runtime: $Util.RuntimeOptions): Promise<InitCoursesOfClassResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courses)) {
      body["courses"] = request.courses;
    }

    if (!Util.isUnset($tea.toMap(request.sectionConfig))) {
      body["sectionConfig"] = request.sectionConfig;
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
    return $tea.cast<InitCoursesOfClassResponse>(await this.doROARequest("InitCoursesOfClass", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/classes/${classId}/courses/init`, "json", req, runtime), new InitCoursesOfClassResponse({}));
  }

  async createInviteUrl(request: CreateInviteUrlRequest): Promise<CreateInviteUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInviteUrlHeaders({ });
    return await this.createInviteUrlWithOptions(request, headers, runtime);
  }

  async createInviteUrlWithOptions(request: CreateInviteUrlRequest, headers: CreateInviteUrlHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInviteUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.targetOperator)) {
      body["targetOperator"] = request.targetOperator;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<CreateInviteUrlResponse>(await this.doROARequest("CreateInviteUrl", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/remoteClasses/orgRelations/inviteUrls`, "json", req, runtime), new CreateInviteUrlResponse({}));
  }

  async pollingConfirmStatus(request: PollingConfirmStatusRequest): Promise<PollingConfirmStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PollingConfirmStatusHeaders({ });
    return await this.pollingConfirmStatusWithOptions(request, headers, runtime);
  }

  async pollingConfirmStatusWithOptions(request: PollingConfirmStatusRequest, headers: PollingConfirmStatusHeaders, runtime: $Util.RuntimeOptions): Promise<PollingConfirmStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      query["ext"] = request.ext;
    }

    if (!Util.isUnset(request.isvCode)) {
      query["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.courseCode)) {
      query["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<PollingConfirmStatusResponse>(await this.doROARequest("PollingConfirmStatus", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/universities/courses/pollingConfirmStatus`, "json", req, runtime), new PollingConfirmStatusResponse({}));
  }

  async createEduAssetSpace(request: CreateEduAssetSpaceRequest): Promise<CreateEduAssetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEduAssetSpaceHeaders({ });
    return await this.createEduAssetSpaceWithOptions(request, headers, runtime);
  }

  async createEduAssetSpaceWithOptions(request: CreateEduAssetSpaceRequest, headers: CreateEduAssetSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEduAssetSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.spaceName)) {
      body["spaceName"] = request.spaceName;
    }

    if (!Util.isUnset(request.spaceDesc)) {
      body["spaceDesc"] = request.spaceDesc;
    }

    if (!Util.isUnset(request.spaceIcon)) {
      body["spaceIcon"] = request.spaceIcon;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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
    return $tea.cast<CreateEduAssetSpaceResponse>(await this.doROARequest("CreateEduAssetSpace", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/assets/spaces`, "json", req, runtime), new CreateEduAssetSpaceResponse({}));
  }

  async deleteTeacher(classId: string, userId: string, request: DeleteTeacherRequest): Promise<DeleteTeacherResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTeacherHeaders({ });
    return await this.deleteTeacherWithOptions(classId, userId, request, headers, runtime);
  }

  async deleteTeacherWithOptions(classId: string, userId: string, request: DeleteTeacherRequest, headers: DeleteTeacherHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTeacherResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.adviser)) {
      query["adviser"] = request.adviser;
    }

    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<DeleteTeacherResponse>(await this.doROARequest("DeleteTeacher", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/classes/${classId}/teachers/${userId}`, "json", req, runtime), new DeleteTeacherResponse({}));
  }

  async deleteUniversityTeacher(request: DeleteUniversityTeacherRequest): Promise<DeleteUniversityTeacherResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteUniversityTeacherHeaders({ });
    return await this.deleteUniversityTeacherWithOptions(request, headers, runtime);
  }

  async deleteUniversityTeacherWithOptions(request: DeleteUniversityTeacherRequest, headers: DeleteUniversityTeacherHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteUniversityTeacherResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      query["classId"] = request.classId;
    }

    if (!Util.isUnset(request.role)) {
      query["role"] = request.role;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      query["teacherUserId"] = request.teacherUserId;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<DeleteUniversityTeacherResponse>(await this.doROARequest("DeleteUniversityTeacher", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/universities/teachers`, "json", req, runtime), new DeleteUniversityTeacherResponse({}));
  }

  async queryPurchaseInfo(request: QueryPurchaseInfoRequest): Promise<QueryPurchaseInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPurchaseInfoHeaders({ });
    return await this.queryPurchaseInfoWithOptions(request, headers, runtime);
  }

  async queryPurchaseInfoWithOptions(request: QueryPurchaseInfoRequest, headers: QueryPurchaseInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPurchaseInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.merchantId)) {
      query["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.scene)) {
      query["scene"] = request.scene;
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
    return $tea.cast<QueryPurchaseInfoResponse>(await this.doROARequest("QueryPurchaseInfo", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/users/purchases`, "json", req, runtime), new QueryPurchaseInfoResponse({}));
  }

  async deleteDeviceOrg(request: DeleteDeviceOrgRequest): Promise<DeleteDeviceOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDeviceOrgHeaders({ });
    return await this.deleteDeviceOrgWithOptions(request, headers, runtime);
  }

  async deleteDeviceOrgWithOptions(request: DeleteDeviceOrgRequest, headers: DeleteDeviceOrgHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDeviceOrgResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCode)) {
      query["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
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
    return $tea.cast<DeleteDeviceOrgResponse>(await this.doROARequest("DeleteDeviceOrg", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/remoteClasses/deviceOrgs`, "json", req, runtime), new DeleteDeviceOrgResponse({}));
  }

  async deleteRemoteClassCourse(courseCode: string, request: DeleteRemoteClassCourseRequest): Promise<DeleteRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRemoteClassCourseHeaders({ });
    return await this.deleteRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
  }

  async deleteRemoteClassCourseWithOptions(courseCode: string, request: DeleteRemoteClassCourseRequest, headers: DeleteRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRemoteClassCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
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
    return $tea.cast<DeleteRemoteClassCourseResponse>(await this.doROARequest("DeleteRemoteClassCourse", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/remoteClasses/courses/${courseCode}`, "json", req, runtime), new DeleteRemoteClassCourseResponse({}));
  }

  async getOpenCourseDetail(courseId: string): Promise<GetOpenCourseDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenCourseDetailHeaders({ });
    return await this.getOpenCourseDetailWithOptions(courseId, headers, runtime);
  }

  async getOpenCourseDetailWithOptions(courseId: string, headers: GetOpenCourseDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetOpenCourseDetailResponse> {
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
    return $tea.cast<GetOpenCourseDetailResponse>(await this.doROARequest("GetOpenCourseDetail", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/openCourse/${courseId}`, "json", req, runtime), new GetOpenCourseDetailResponse({}));
  }

  async deleteStudent(classId: string, userId: string, request: DeleteStudentRequest): Promise<DeleteStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteStudentHeaders({ });
    return await this.deleteStudentWithOptions(classId, userId, request, headers, runtime);
  }

  async deleteStudentWithOptions(classId: string, userId: string, request: DeleteStudentRequest, headers: DeleteStudentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<DeleteStudentResponse>(await this.doROARequest("DeleteStudent", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/classes/${classId}/students/${userId}`, "json", req, runtime), new DeleteStudentResponse({}));
  }

  async updateCoursesOfClass(classId: string, request: UpdateCoursesOfClassRequest): Promise<UpdateCoursesOfClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCoursesOfClassHeaders({ });
    return await this.updateCoursesOfClassWithOptions(classId, request, headers, runtime);
  }

  async updateCoursesOfClassWithOptions(classId: string, request: UpdateCoursesOfClassRequest, headers: UpdateCoursesOfClassHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCoursesOfClassResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courses)) {
      body["courses"] = request.courses;
    }

    if (!Util.isUnset($tea.toMap(request.sectionConfig))) {
      body["sectionConfig"] = request.sectionConfig;
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
    return $tea.cast<UpdateCoursesOfClassResponse>(await this.doROARequest("UpdateCoursesOfClass", "edu_1.0", "HTTP", "PUT", "AK", `/v1.0/edu/classes/${classId}/courses/schedules`, "json", req, runtime), new UpdateCoursesOfClassResponse({}));
  }

  async createSectionConfig(request: CreateSectionConfigRequest): Promise<CreateSectionConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSectionConfigHeaders({ });
    return await this.createSectionConfigWithOptions(request, headers, runtime);
  }

  async createSectionConfigWithOptions(request: CreateSectionConfigRequest, headers: CreateSectionConfigHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSectionConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.sectionConfigs)) {
      body["sectionConfigs"] = request.sectionConfigs;
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
    return $tea.cast<CreateSectionConfigResponse>(await this.doROARequest("CreateSectionConfig", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/sectionConfigs`, "json", req, runtime), new CreateSectionConfigResponse({}));
  }

  async querySubjectTeachers(request: QuerySubjectTeachersRequest): Promise<QuerySubjectTeachersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySubjectTeachersHeaders({ });
    return await this.querySubjectTeachersWithOptions(request, headers, runtime);
  }

  async querySubjectTeachersWithOptions(request: QuerySubjectTeachersRequest, headers: QuerySubjectTeachersHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySubjectTeachersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIds)) {
      query["classIds"] = request.classIds;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.subjectCode)) {
      query["subjectCode"] = request.subjectCode;
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
    return $tea.cast<QuerySubjectTeachersResponse>(await this.doROARequest("QuerySubjectTeachers", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/subjects/teachers`, "json", req, runtime), new QuerySubjectTeachersResponse({}));
  }

  async queryRemoteClassCourse(request: QueryRemoteClassCourseRequest): Promise<QueryRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRemoteClassCourseHeaders({ });
    return await this.queryRemoteClassCourseWithOptions(request, headers, runtime);
  }

  async queryRemoteClassCourseWithOptions(request: QueryRemoteClassCourseRequest, headers: QueryRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRemoteClassCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
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
    return $tea.cast<QueryRemoteClassCourseResponse>(await this.doROARequest("QueryRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/remoteClasses/courses`, "json", req, runtime), new QueryRemoteClassCourseResponse({}));
  }

  async createPhysicalClassroom(request: CreatePhysicalClassroomRequest): Promise<CreatePhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatePhysicalClassroomHeaders({ });
    return await this.createPhysicalClassroomWithOptions(request, headers, runtime);
  }

  async createPhysicalClassroomWithOptions(request: CreatePhysicalClassroomRequest, headers: CreatePhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<CreatePhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classroomFloor)) {
      body["classroomFloor"] = request.classroomFloor;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.classroomBuilding)) {
      body["classroomBuilding"] = request.classroomBuilding;
    }

    if (!Util.isUnset(request.directBroadcast)) {
      body["directBroadcast"] = request.directBroadcast;
    }

    if (!Util.isUnset(request.classroomName)) {
      body["classroomName"] = request.classroomName;
    }

    if (!Util.isUnset(request.classroomCampus)) {
      body["classroomCampus"] = request.classroomCampus;
    }

    if (!Util.isUnset(request.classroomNumber)) {
      body["classroomNumber"] = request.classroomNumber;
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
    return $tea.cast<CreatePhysicalClassroomResponse>(await this.doROARequest("CreatePhysicalClassroom", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/physicalClassrooms`, "json", req, runtime), new CreatePhysicalClassroomResponse({}));
  }

  async queryClassSchedule(request: QueryClassScheduleRequest): Promise<QueryClassScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClassScheduleHeaders({ });
    return await this.queryClassScheduleWithOptions(request, headers, runtime);
  }

  async queryClassScheduleWithOptions(request: QueryClassScheduleRequest, headers: QueryClassScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClassScheduleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subscriberType)) {
      query["subscriberType"] = request.subscriberType;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subscriberIds)) {
      body["subscriberIds"] = request.subscriberIds;
    }

    if (!Util.isUnset(request.sectionIndexList)) {
      body["sectionIndexList"] = request.sectionIndexList;
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
    return $tea.cast<QueryClassScheduleResponse>(await this.doROARequest("QueryClassSchedule", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/classes/schedules/query`, "json", req, runtime), new QueryClassScheduleResponse({}));
  }

  async createRemoteClassCourse(request: CreateRemoteClassCourseRequest): Promise<CreateRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRemoteClassCourseHeaders({ });
    return await this.createRemoteClassCourseWithOptions(request, headers, runtime);
  }

  async createRemoteClassCourseWithOptions(request: CreateRemoteClassCourseRequest, headers: CreateRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRemoteClassCourseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseName)) {
      body["courseName"] = request.courseName;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset($tea.toMap(request.teachingParticipant))) {
      body["teachingParticipant"] = request.teachingParticipant;
    }

    if (!Util.isUnset(request.attendParticipants)) {
      body["attendParticipants"] = request.attendParticipants;
    }

    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
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
    return $tea.cast<CreateRemoteClassCourseResponse>(await this.doROARequest("CreateRemoteClassCourse", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/remoteClasses/courses`, "json", req, runtime), new CreateRemoteClassCourseResponse({}));
  }

  async updateRemoteClassDevice(request: UpdateRemoteClassDeviceRequest): Promise<UpdateRemoteClassDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRemoteClassDeviceHeaders({ });
    return await this.updateRemoteClassDeviceWithOptions(request, headers, runtime);
  }

  async updateRemoteClassDeviceWithOptions(request: UpdateRemoteClassDeviceRequest, headers: UpdateRemoteClassDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRemoteClassDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceCode)) {
      query["deviceCode"] = request.deviceCode;
    }

    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.deviceName)) {
      query["deviceName"] = request.deviceName;
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
    return $tea.cast<UpdateRemoteClassDeviceResponse>(await this.doROARequest("UpdateRemoteClassDevice", "edu_1.0", "HTTP", "PUT", "AK", `/v1.0/edu/remoteClasses/deviceNames`, "json", req, runtime), new UpdateRemoteClassDeviceResponse({}));
  }

  async reportDeviceLog(request: ReportDeviceLogRequest): Promise<ReportDeviceLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportDeviceLogHeaders({ });
    return await this.reportDeviceLogWithOptions(request, headers, runtime);
  }

  async reportDeviceLogWithOptions(request: ReportDeviceLogRequest, headers: ReportDeviceLogHeaders, runtime: $Util.RuntimeOptions): Promise<ReportDeviceLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
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
    return $tea.cast<ReportDeviceLogResponse>(await this.doROARequest("ReportDeviceLog", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/deviceLogs/report`, "json", req, runtime), new ReportDeviceLogResponse({}));
  }

  async createCustomClass(request: CreateCustomClassRequest): Promise<CreateCustomClassResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomClassHeaders({ });
    return await this.createCustomClassWithOptions(request, headers, runtime);
  }

  async createCustomClassWithOptions(request: CreateCustomClassRequest, headers: CreateCustomClassHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomClassResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.customClass))) {
      body["customClass"] = request.customClass;
    }

    if (!Util.isUnset(request.superId)) {
      body["superId"] = request.superId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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
    return $tea.cast<CreateCustomClassResponse>(await this.doROARequest("CreateCustomClass", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/customClasses`, "json", req, runtime), new CreateCustomClassResponse({}));
  }

  async updatePhysicalClassroom(request: UpdatePhysicalClassroomRequest): Promise<UpdatePhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePhysicalClassroomHeaders({ });
    return await this.updatePhysicalClassroomWithOptions(request, headers, runtime);
  }

  async updatePhysicalClassroomWithOptions(request: UpdatePhysicalClassroomRequest, headers: UpdatePhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classroomFloor)) {
      body["classroomFloor"] = request.classroomFloor;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.classroomBuilding)) {
      body["classroomBuilding"] = request.classroomBuilding;
    }

    if (!Util.isUnset(request.directBroadcast)) {
      body["directBroadcast"] = request.directBroadcast;
    }

    if (!Util.isUnset(request.classroomName)) {
      body["classroomName"] = request.classroomName;
    }

    if (!Util.isUnset(request.classroomCampus)) {
      body["classroomCampus"] = request.classroomCampus;
    }

    if (!Util.isUnset(request.classroomNumber)) {
      body["classroomNumber"] = request.classroomNumber;
    }

    if (!Util.isUnset(request.classroomId)) {
      body["classroomId"] = request.classroomId;
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
    return $tea.cast<UpdatePhysicalClassroomResponse>(await this.doROARequest("UpdatePhysicalClassroom", "edu_1.0", "HTTP", "PUT", "AK", `/v1.0/edu/physicalClassrooms`, "json", req, runtime), new UpdatePhysicalClassroomResponse({}));
  }

  async moveStudent(request: MoveStudentRequest): Promise<MoveStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveStudentHeaders({ });
    return await this.moveStudentWithOptions(request, headers, runtime);
  }

  async moveStudentWithOptions(request: MoveStudentRequest, headers: MoveStudentHeaders, runtime: $Util.RuntimeOptions): Promise<MoveStudentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.originClassId)) {
      body["originClassId"] = request.originClassId;
    }

    if (!Util.isUnset(request.targetClassId)) {
      body["targetClassId"] = request.targetClassId;
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
    return $tea.cast<MoveStudentResponse>(await this.doROARequest("MoveStudent", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/students/move`, "json", req, runtime), new MoveStudentResponse({}));
  }

  async queryEduAssetSpaces(request: QueryEduAssetSpacesRequest): Promise<QueryEduAssetSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEduAssetSpacesHeaders({ });
    return await this.queryEduAssetSpacesWithOptions(request, headers, runtime);
  }

  async queryEduAssetSpacesWithOptions(request: QueryEduAssetSpacesRequest, headers: QueryEduAssetSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEduAssetSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
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
    return $tea.cast<QueryEduAssetSpacesResponse>(await this.doROARequest("QueryEduAssetSpaces", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/assets/spaces`, "json", req, runtime), new QueryEduAssetSpacesResponse({}));
  }

  async createUniversityCourseGroup(request: CreateUniversityCourseGroupRequest): Promise<CreateUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUniversityCourseGroupHeaders({ });
    return await this.createUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async createUniversityCourseGroupWithOptions(request: CreateUniversityCourseGroupRequest, headers: CreateUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvCourseGroupCode)) {
      body["isvCourseGroupCode"] = request.isvCourseGroupCode;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.courseGroupIntroduce)) {
      body["courseGroupIntroduce"] = request.courseGroupIntroduce;
    }

    if (!Util.isUnset(request.semester)) {
      body["semester"] = request.semester;
    }

    if (!Util.isUnset(request.subjectName)) {
      body["subjectName"] = request.subjectName;
    }

    if (!Util.isUnset(request.courseGroupName)) {
      body["courseGroupName"] = request.courseGroupName;
    }

    if (!Util.isUnset(request.schoolYear)) {
      body["schoolYear"] = request.schoolYear;
    }

    if (!Util.isUnset(request.periodCode)) {
      body["periodCode"] = request.periodCode;
    }

    if (!Util.isUnset(request.teacherInfos)) {
      body["teacherInfos"] = request.teacherInfos;
    }

    if (!Util.isUnset(request.courserGroupItemModels)) {
      body["courserGroupItemModels"] = request.courserGroupItemModels;
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
    return $tea.cast<CreateUniversityCourseGroupResponse>(await this.doROARequest("CreateUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/courseGroups`, "json", req, runtime), new CreateUniversityCourseGroupResponse({}));
  }

  async getRemoteClassCourse(courseCode: string, request: GetRemoteClassCourseRequest): Promise<GetRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRemoteClassCourseHeaders({ });
    return await this.getRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
  }

  async getRemoteClassCourseWithOptions(courseCode: string, request: GetRemoteClassCourseRequest, headers: GetRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<GetRemoteClassCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<GetRemoteClassCourseResponse>(await this.doROARequest("GetRemoteClassCourse", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/remoteClasses/courses/${courseCode}`, "json", req, runtime), new GetRemoteClassCourseResponse({}));
  }

  async queryUniversityCourseGroup(request: QueryUniversityCourseGroupRequest): Promise<QueryUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUniversityCourseGroupHeaders({ });
    return await this.queryUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async queryUniversityCourseGroupWithOptions(request: QueryUniversityCourseGroupRequest, headers: QueryUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.courseGroupCode)) {
      query["courseGroupCode"] = request.courseGroupCode;
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
    return $tea.cast<QueryUniversityCourseGroupResponse>(await this.doROARequest("QueryUniversityCourseGroup", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/universities/courseGroups`, "json", req, runtime), new QueryUniversityCourseGroupResponse({}));
  }

  async queryAllSubjectsFromClassSchedule(request: QueryAllSubjectsFromClassScheduleRequest): Promise<QueryAllSubjectsFromClassScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllSubjectsFromClassScheduleHeaders({ });
    return await this.queryAllSubjectsFromClassScheduleWithOptions(request, headers, runtime);
  }

  async queryAllSubjectsFromClassScheduleWithOptions(tmpReq: QueryAllSubjectsFromClassScheduleRequest, headers: QueryAllSubjectsFromClassScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllSubjectsFromClassScheduleResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryAllSubjectsFromClassScheduleShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.classIds)) {
      request.classIdsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIdsShrink)) {
      query["classIds"] = request.classIdsShrink;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.periodCode)) {
      query["periodCode"] = request.periodCode;
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
    return $tea.cast<QueryAllSubjectsFromClassScheduleResponse>(await this.doROARequest("QueryAllSubjectsFromClassSchedule", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/subjects/instances`, "json", req, runtime), new QueryAllSubjectsFromClassScheduleResponse({}));
  }

  async courseSchedulingComplimentNotice(request: CourseSchedulingComplimentNoticeRequest): Promise<CourseSchedulingComplimentNoticeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CourseSchedulingComplimentNoticeHeaders({ });
    return await this.courseSchedulingComplimentNoticeWithOptions(request, headers, runtime);
  }

  async courseSchedulingComplimentNoticeWithOptions(request: CourseSchedulingComplimentNoticeRequest, headers: CourseSchedulingComplimentNoticeHeaders, runtime: $Util.RuntimeOptions): Promise<CourseSchedulingComplimentNoticeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<CourseSchedulingComplimentNoticeResponse>(await this.doROARequest("CourseSchedulingComplimentNotice", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/schedules/finishNotify`, "json", req, runtime), new CourseSchedulingComplimentNoticeResponse({}));
  }

  async deleteUniversityCourseGroup(request: DeleteUniversityCourseGroupRequest): Promise<DeleteUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteUniversityCourseGroupHeaders({ });
    return await this.deleteUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async deleteUniversityCourseGroupWithOptions(request: DeleteUniversityCourseGroupRequest, headers: DeleteUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.courseGroupCode)) {
      query["courseGroupCode"] = request.courseGroupCode;
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
    return $tea.cast<DeleteUniversityCourseGroupResponse>(await this.doROARequest("DeleteUniversityCourseGroup", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/universities/courseGroups`, "json", req, runtime), new DeleteUniversityCourseGroupResponse({}));
  }

  async deviceHeartbeat(request: DeviceHeartbeatRequest): Promise<DeviceHeartbeatResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceHeartbeatHeaders({ });
    return await this.deviceHeartbeatWithOptions(request, headers, runtime);
  }

  async deviceHeartbeatWithOptions(request: DeviceHeartbeatRequest, headers: DeviceHeartbeatHeaders, runtime: $Util.RuntimeOptions): Promise<DeviceHeartbeatResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
    return $tea.cast<DeviceHeartbeatResponse>(await this.doROARequest("DeviceHeartbeat", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/heartbeats/report`, "json", req, runtime), new DeviceHeartbeatResponse({}));
  }

  async deleteDept(deptId: string, request: DeleteDeptRequest): Promise<DeleteDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDeptHeaders({ });
    return await this.deleteDeptWithOptions(deptId, request, headers, runtime);
  }

  async deleteDeptWithOptions(deptId: string, request: DeleteDeptRequest, headers: DeleteDeptHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<DeleteDeptResponse>(await this.doROARequest("DeleteDept", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/depts/${deptId}`, "json", req, runtime), new DeleteDeptResponse({}));
  }

  async deleteGuardian(classId: string, userId: string, request: DeleteGuardianRequest): Promise<DeleteGuardianResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteGuardianHeaders({ });
    return await this.deleteGuardianWithOptions(classId, userId, request, headers, runtime);
  }

  async deleteGuardianWithOptions(classId: string, userId: string, request: DeleteGuardianRequest, headers: DeleteGuardianHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteGuardianResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.stuId)) {
      query["stuId"] = request.stuId;
    }

    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<DeleteGuardianResponse>(await this.doROARequest("DeleteGuardian", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/classes/${classId}/guardians/${userId}`, "json", req, runtime), new DeleteGuardianResponse({}));
  }

  async insertSectionConfig(request: InsertSectionConfigRequest): Promise<InsertSectionConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertSectionConfigHeaders({ });
    return await this.insertSectionConfigWithOptions(request, headers, runtime);
  }

  async insertSectionConfigWithOptions(request: InsertSectionConfigRequest, headers: InsertSectionConfigHeaders, runtime: $Util.RuntimeOptions): Promise<InsertSectionConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sectionModels)) {
      body["sectionModels"] = request.sectionModels;
    }

    if (!Util.isUnset($tea.toMap(request.start))) {
      body["start"] = request.start;
    }

    if (!Util.isUnset($tea.toMap(request.end))) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.scheduleName)) {
      body["scheduleName"] = request.scheduleName;
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
    return $tea.cast<InsertSectionConfigResponse>(await this.doROARequest("InsertSectionConfig", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/schedules/configs`, "json", req, runtime), new InsertSectionConfigResponse({}));
  }

  async queryUserFace(request: QueryUserFaceRequest): Promise<QueryUserFaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserFaceHeaders({ });
    return await this.queryUserFaceWithOptions(request, headers, runtime);
  }

  async queryUserFaceWithOptions(request: QueryUserFaceRequest, headers: QueryUserFaceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserFaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
    }

    if (!Util.isUnset(request.faceId)) {
      query["faceId"] = request.faceId;
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
    return $tea.cast<QueryUserFaceResponse>(await this.doROARequest("QueryUserFace", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/users/faces`, "json", req, runtime), new QueryUserFaceResponse({}));
  }

  async queryDeviceListByCorpId(request: QueryDeviceListByCorpIdRequest): Promise<QueryDeviceListByCorpIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceListByCorpIdHeaders({ });
    return await this.queryDeviceListByCorpIdWithOptions(request, headers, runtime);
  }

  async queryDeviceListByCorpIdWithOptions(request: QueryDeviceListByCorpIdRequest, headers: QueryDeviceListByCorpIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceListByCorpIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<QueryDeviceListByCorpIdResponse>(await this.doROARequest("QueryDeviceListByCorpId", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/remoteClasses/devices`, "json", req, runtime), new QueryDeviceListByCorpIdResponse({}));
  }

  async updateUniversityCourseGroup(request: UpdateUniversityCourseGroupRequest): Promise<UpdateUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUniversityCourseGroupHeaders({ });
    return await this.updateUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async updateUniversityCourseGroupWithOptions(request: UpdateUniversityCourseGroupRequest, headers: UpdateUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.courseGroupIntroduce)) {
      body["courseGroupIntroduce"] = request.courseGroupIntroduce;
    }

    if (!Util.isUnset(request.courseGroupName)) {
      body["courseGroupName"] = request.courseGroupName;
    }

    if (!Util.isUnset(request.courserGroupItemModels)) {
      body["courserGroupItemModels"] = request.courserGroupItemModels;
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
    return $tea.cast<UpdateUniversityCourseGroupResponse>(await this.doROARequest("UpdateUniversityCourseGroup", "edu_1.0", "HTTP", "PUT", "AK", `/v1.0/edu/universities/courseGroups`, "json", req, runtime), new UpdateUniversityCourseGroupResponse({}));
  }

  async batchOrgCreateHW(request: BatchOrgCreateHWRequest): Promise<BatchOrgCreateHWResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchOrgCreateHWHeaders({ });
    return await this.batchOrgCreateHWWithOptions(request, headers, runtime);
  }

  async batchOrgCreateHWWithOptions(request: BatchOrgCreateHWRequest, headers: BatchOrgCreateHWHeaders, runtime: $Util.RuntimeOptions): Promise<BatchOrgCreateHWResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.hwMedia)) {
      body["hwMedia"] = request.hwMedia;
    }

    if (!Util.isUnset(request.hwContent)) {
      body["hwContent"] = request.hwContent;
    }

    if (!Util.isUnset(request.hwTitle)) {
      body["hwTitle"] = request.hwTitle;
    }

    if (!Util.isUnset(request.courseName)) {
      body["courseName"] = request.courseName;
    }

    if (!Util.isUnset(request.hwPhoto)) {
      body["hwPhoto"] = request.hwPhoto;
    }

    if (!Util.isUnset(request.hwVideo)) {
      body["hwVideo"] = request.hwVideo;
    }

    if (!Util.isUnset(request.teacherName)) {
      body["teacherName"] = request.teacherName;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      body["teacherUserId"] = request.teacherUserId;
    }

    if (!Util.isUnset(request.identifier)) {
      body["identifier"] = request.identifier;
    }

    if (!Util.isUnset(request.attributes)) {
      body["attributes"] = request.attributes;
    }

    if (!Util.isUnset(request.targetRole)) {
      body["targetRole"] = request.targetRole;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.scheduledRelease)) {
      body["scheduledRelease"] = request.scheduledRelease;
    }

    if (!Util.isUnset(request.scheduledTime)) {
      body["scheduledTime"] = request.scheduledTime;
    }

    if (!Util.isUnset(request.hwDeadlineOpen)) {
      body["hwDeadlineOpen"] = request.hwDeadlineOpen;
    }

    if (!Util.isUnset(request.hwDeadline)) {
      body["hwDeadline"] = request.hwDeadline;
    }

    if (!Util.isUnset(request.hwType)) {
      body["hwType"] = request.hwType;
    }

    if (!Util.isUnset(request.openSelectItemList)) {
      body["openSelectItemList"] = request.openSelectItemList;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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
    return $tea.cast<BatchOrgCreateHWResponse>(await this.doROARequest("BatchOrgCreateHW", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/homeworks`, "json", req, runtime), new BatchOrgCreateHWResponse({}));
  }

  async createCustomDept(request: CreateCustomDeptRequest): Promise<CreateCustomDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomDeptHeaders({ });
    return await this.createCustomDeptWithOptions(request, headers, runtime);
  }

  async createCustomDeptWithOptions(request: CreateCustomDeptRequest, headers: CreateCustomDeptHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomDeptResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.customDept))) {
      body["customDept"] = request.customDept;
    }

    if (!Util.isUnset(request.superId)) {
      body["superId"] = request.superId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<CreateCustomDeptResponse>(await this.doROARequest("CreateCustomDept", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/customDepts`, "json", req, runtime), new CreateCustomDeptResponse({}));
  }

  async startCoursePrepare(request: StartCoursePrepareRequest): Promise<StartCoursePrepareResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCoursePrepareHeaders({ });
    return await this.startCoursePrepareWithOptions(request, headers, runtime);
  }

  async startCoursePrepareWithOptions(request: StartCoursePrepareRequest, headers: StartCoursePrepareHeaders, runtime: $Util.RuntimeOptions): Promise<StartCoursePrepareResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.sectionIndex)) {
      body["sectionIndex"] = request.sectionIndex;
    }

    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.liveCoverImage)) {
      body["liveCoverImage"] = request.liveCoverImage;
    }

    if (!Util.isUnset(request.courseDate)) {
      body["courseDate"] = request.courseDate;
    }

    if (!Util.isUnset(request.isvCode)) {
      body["isvCode"] = request.isvCode;
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
    return $tea.cast<StartCoursePrepareResponse>(await this.doROARequest("StartCoursePrepare", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/courses/prepare`, "json", req, runtime), new StartCoursePrepareResponse({}));
  }

  async queryClassScheduleByTimeSchool(request: QueryClassScheduleByTimeSchoolRequest): Promise<QueryClassScheduleByTimeSchoolResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryClassScheduleByTimeSchoolHeaders({ });
    return await this.queryClassScheduleByTimeSchoolWithOptions(request, headers, runtime);
  }

  async queryClassScheduleByTimeSchoolWithOptions(request: QueryClassScheduleByTimeSchoolRequest, headers: QueryClassScheduleByTimeSchoolHeaders, runtime: $Util.RuntimeOptions): Promise<QueryClassScheduleByTimeSchoolResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<QueryClassScheduleByTimeSchoolResponse>(await this.doROARequest("QueryClassScheduleByTimeSchool", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/schools/classes/courses `, "json", req, runtime), new QueryClassScheduleByTimeSchoolResponse({}));
  }

  async queryTeachSubjects(request: QueryTeachSubjectsRequest): Promise<QueryTeachSubjectsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTeachSubjectsHeaders({ });
    return await this.queryTeachSubjectsWithOptions(request, headers, runtime);
  }

  async queryTeachSubjectsWithOptions(request: QueryTeachSubjectsRequest, headers: QueryTeachSubjectsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTeachSubjectsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classIds)) {
      query["classIds"] = request.classIds;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<QueryTeachSubjectsResponse>(await this.doROARequest("QueryTeachSubjects", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/teachers/subjects`, "json", req, runtime), new QueryTeachSubjectsResponse({}));
  }

  async getShareRoles(): Promise<GetShareRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShareRolesHeaders({ });
    return await this.getShareRolesWithOptions(headers, runtime);
  }

  async getShareRolesWithOptions(headers: GetShareRolesHeaders, runtime: $Util.RuntimeOptions): Promise<GetShareRolesResponse> {
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
    return $tea.cast<GetShareRolesResponse>(await this.doROARequest("GetShareRoles", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/shareRoles`, "json", req, runtime), new GetShareRolesResponse({}));
  }

  async queryGroupId(request: QueryGroupIdRequest): Promise<QueryGroupIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupIdHeaders({ });
    return await this.queryGroupIdWithOptions(request, headers, runtime);
  }

  async queryGroupIdWithOptions(request: QueryGroupIdRequest, headers: QueryGroupIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
    return $tea.cast<QueryGroupIdResponse>(await this.doROARequest("QueryGroupId", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/faces/groups`, "json", req, runtime), new QueryGroupIdResponse({}));
  }

  async subscribeUniversityCourseGroup(request: SubscribeUniversityCourseGroupRequest): Promise<SubscribeUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeUniversityCourseGroupHeaders({ });
    return await this.subscribeUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async subscribeUniversityCourseGroupWithOptions(request: SubscribeUniversityCourseGroupRequest, headers: SubscribeUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.studentUserIds)) {
      body["studentUserIds"] = request.studentUserIds;
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
    return $tea.cast<SubscribeUniversityCourseGroupResponse>(await this.doROARequest("SubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/courseGroups/subscribe`, "json", req, runtime), new SubscribeUniversityCourseGroupResponse({}));
  }

  async deleteOrgRelation(request: DeleteOrgRelationRequest): Promise<DeleteOrgRelationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteOrgRelationHeaders({ });
    return await this.deleteOrgRelationWithOptions(request, headers, runtime);
  }

  async deleteOrgRelationWithOptions(request: DeleteOrgRelationRequest, headers: DeleteOrgRelationHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteOrgRelationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
    }

    if (!Util.isUnset(request.authCode)) {
      query["authCode"] = request.authCode;
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
    return $tea.cast<DeleteOrgRelationResponse>(await this.doROARequest("DeleteOrgRelation", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/remoteClasses/orgRelations`, "json", req, runtime), new DeleteOrgRelationResponse({}));
  }

  async startCourse(request: StartCourseRequest): Promise<StartCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCourseHeaders({ });
    return await this.startCourseWithOptions(request, headers, runtime);
  }

  async startCourseWithOptions(request: StartCourseRequest, headers: StartCourseHeaders, runtime: $Util.RuntimeOptions): Promise<StartCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.courseCode)) {
      body["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.livePlayInfoList)) {
      body["livePlayInfoList"] = request.livePlayInfoList;
    }

    if (!Util.isUnset(request.isvCode)) {
      body["isvCode"] = request.isvCode;
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
    return $tea.cast<StartCourseResponse>(await this.doROARequest("StartCourse", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/courses/start`, "json", req, runtime), new StartCourseResponse({}));
  }

  async queryPhysicalClassroom(request: QueryPhysicalClassroomRequest): Promise<QueryPhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPhysicalClassroomHeaders({ });
    return await this.queryPhysicalClassroomWithOptions(request, headers, runtime);
  }

  async queryPhysicalClassroomWithOptions(request: QueryPhysicalClassroomRequest, headers: QueryPhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.classroomId)) {
      query["classroomId"] = request.classroomId;
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
    return $tea.cast<QueryPhysicalClassroomResponse>(await this.doROARequest("QueryPhysicalClassroom", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/physicalClassrooms`, "json", req, runtime), new QueryPhysicalClassroomResponse({}));
  }

  async updateRemoteClassCourse(request: UpdateRemoteClassCourseRequest): Promise<UpdateRemoteClassCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRemoteClassCourseHeaders({ });
    return await this.updateRemoteClassCourseWithOptions(request, headers, runtime);
  }

  async updateRemoteClassCourseWithOptions(request: UpdateRemoteClassCourseRequest, headers: UpdateRemoteClassCourseHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRemoteClassCourseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseName)) {
      body["courseName"] = request.courseName;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset($tea.toMap(request.teachingParticipant))) {
      body["teachingParticipant"] = request.teachingParticipant;
    }

    if (!Util.isUnset(request.attendParticipants)) {
      body["attendParticipants"] = request.attendParticipants;
    }

    if (!Util.isUnset(request.courseCode)) {
      body["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
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
    return $tea.cast<UpdateRemoteClassCourseResponse>(await this.doROARequest("UpdateRemoteClassCourse", "edu_1.0", "HTTP", "PUT", "AK", `/v1.0/edu/remoteClasses/courses`, "json", req, runtime), new UpdateRemoteClassCourseResponse({}));
  }

  async unsubscribeUniversityCourseGroup(request: UnsubscribeUniversityCourseGroupRequest): Promise<UnsubscribeUniversityCourseGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsubscribeUniversityCourseGroupHeaders({ });
    return await this.unsubscribeUniversityCourseGroupWithOptions(request, headers, runtime);
  }

  async unsubscribeUniversityCourseGroupWithOptions(request: UnsubscribeUniversityCourseGroupRequest, headers: UnsubscribeUniversityCourseGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UnsubscribeUniversityCourseGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseGroupCode)) {
      body["courseGroupCode"] = request.courseGroupCode;
    }

    if (!Util.isUnset(request.studentUserIds)) {
      body["studentUserIds"] = request.studentUserIds;
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
    return $tea.cast<UnsubscribeUniversityCourseGroupResponse>(await this.doROARequest("UnsubscribeUniversityCourseGroup", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/courseGroups/unsubscribe`, "json", req, runtime), new UnsubscribeUniversityCourseGroupResponse({}));
  }

  async queryOrgSecretKey(request: QueryOrgSecretKeyRequest): Promise<QueryOrgSecretKeyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgSecretKeyHeaders({ });
    return await this.queryOrgSecretKeyWithOptions(request, headers, runtime);
  }

  async queryOrgSecretKeyWithOptions(request: QueryOrgSecretKeyRequest, headers: QueryOrgSecretKeyHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgSecretKeyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvCode)) {
      query["isvCode"] = request.isvCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<QueryOrgSecretKeyResponse>(await this.doROARequest("QueryOrgSecretKey", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/universities/secretKeys`, "json", req, runtime), new QueryOrgSecretKeyResponse({}));
  }

  async searchTeachers(request: SearchTeachersRequest): Promise<SearchTeachersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTeachersHeaders({ });
    return await this.searchTeachersWithOptions(request, headers, runtime);
  }

  async searchTeachersWithOptions(request: SearchTeachersRequest, headers: SearchTeachersHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTeachersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nameKeyword)) {
      query["nameKeyword"] = request.nameKeyword;
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
    return $tea.cast<SearchTeachersResponse>(await this.doROARequest("SearchTeachers", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/teachers/search`, "json", req, runtime), new SearchTeachersResponse({}));
  }

  async deletePhysicalClassroom(request: DeletePhysicalClassroomRequest): Promise<DeletePhysicalClassroomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePhysicalClassroomHeaders({ });
    return await this.deletePhysicalClassroomWithOptions(request, headers, runtime);
  }

  async deletePhysicalClassroomWithOptions(request: DeletePhysicalClassroomRequest, headers: DeletePhysicalClassroomHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePhysicalClassroomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.classroomId)) {
      query["classroomId"] = request.classroomId;
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
    return $tea.cast<DeletePhysicalClassroomResponse>(await this.doROARequest("DeletePhysicalClassroom", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/physicalClassrooms`, "json", req, runtime), new DeletePhysicalClassroomResponse({}));
  }

  async queryOrgRelationList(request: QueryOrgRelationListRequest): Promise<QueryOrgRelationListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgRelationListHeaders({ });
    return await this.queryOrgRelationListWithOptions(request, headers, runtime);
  }

  async queryOrgRelationListWithOptions(request: QueryOrgRelationListRequest, headers: QueryOrgRelationListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgRelationListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
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
    return $tea.cast<QueryOrgRelationListResponse>(await this.doROARequest("QueryOrgRelationList", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/remoteClasses/orgRelations`, "json", req, runtime), new QueryOrgRelationListResponse({}));
  }

  async querySchoolUserFace(request: QuerySchoolUserFaceRequest): Promise<QuerySchoolUserFaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySchoolUserFaceHeaders({ });
    return await this.querySchoolUserFaceWithOptions(request, headers, runtime);
  }

  async querySchoolUserFaceWithOptions(request: QuerySchoolUserFaceRequest, headers: QuerySchoolUserFaceHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySchoolUserFaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

    if (!Util.isUnset(request.sn)) {
      query["sn"] = request.sn;
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
    return $tea.cast<QuerySchoolUserFaceResponse>(await this.doROARequest("QuerySchoolUserFace", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/schools/faces`, "json", req, runtime), new QuerySchoolUserFaceResponse({}));
  }

  async queryOrgType(): Promise<QueryOrgTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgTypeHeaders({ });
    return await this.queryOrgTypeWithOptions(headers, runtime);
  }

  async queryOrgTypeWithOptions(headers: QueryOrgTypeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgTypeResponse> {
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
    return $tea.cast<QueryOrgTypeResponse>(await this.doROARequest("QueryOrgType", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/orgTypes`, "json", req, runtime), new QueryOrgTypeResponse({}));
  }

  async deleteUniversityStudent(request: DeleteUniversityStudentRequest): Promise<DeleteUniversityStudentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteUniversityStudentHeaders({ });
    return await this.deleteUniversityStudentWithOptions(request, headers, runtime);
  }

  async deleteUniversityStudentWithOptions(request: DeleteUniversityStudentRequest, headers: DeleteUniversityStudentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteUniversityStudentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.classId)) {
      query["classId"] = request.classId;
    }

    if (!Util.isUnset(request.studentUserId)) {
      query["studentUserId"] = request.studentUserId;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<DeleteUniversityStudentResponse>(await this.doROARequest("DeleteUniversityStudent", "edu_1.0", "HTTP", "DELETE", "AK", `/v1.0/edu/universities/students`, "json", req, runtime), new DeleteUniversityStudentResponse({}));
  }

  async endCourse(request: EndCourseRequest): Promise<EndCourseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EndCourseHeaders({ });
    return await this.endCourseWithOptions(request, headers, runtime);
  }

  async endCourseWithOptions(request: EndCourseRequest, headers: EndCourseHeaders, runtime: $Util.RuntimeOptions): Promise<EndCourseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.courseCode)) {
      body["courseCode"] = request.courseCode;
    }

    if (!Util.isUnset(request.livePlayInfoList)) {
      body["livePlayInfoList"] = request.livePlayInfoList;
    }

    if (!Util.isUnset(request.isvCode)) {
      body["isvCode"] = request.isvCode;
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
    return $tea.cast<EndCourseResponse>(await this.doROARequest("EndCourse", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/courses/end`, "json", req, runtime), new EndCourseResponse({}));
  }

  async getShareRoleMembers(shareRoleCode: string): Promise<GetShareRoleMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShareRoleMembersHeaders({ });
    return await this.getShareRoleMembersWithOptions(shareRoleCode, headers, runtime);
  }

  async getShareRoleMembersWithOptions(shareRoleCode: string, headers: GetShareRoleMembersHeaders, runtime: $Util.RuntimeOptions): Promise<GetShareRoleMembersResponse> {
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
    return $tea.cast<GetShareRoleMembersResponse>(await this.doROARequest("GetShareRoleMembers", "edu_1.0", "HTTP", "GET", "AK", `/v1.0/edu/shareRoles/${shareRoleCode}/members`, "json", req, runtime), new GetShareRoleMembersResponse({}));
  }

  async createUniversityTeacher(request: CreateUniversityTeacherRequest): Promise<CreateUniversityTeacherResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUniversityTeacherHeaders({ });
    return await this.createUniversityTeacherWithOptions(request, headers, runtime);
  }

  async createUniversityTeacherWithOptions(request: CreateUniversityTeacherRequest, headers: CreateUniversityTeacherHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUniversityTeacherResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.classId)) {
      body["classId"] = request.classId;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.teacherUserId)) {
      body["teacherUserId"] = request.teacherUserId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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
    return $tea.cast<CreateUniversityTeacherResponse>(await this.doROARequest("CreateUniversityTeacher", "edu_1.0", "HTTP", "POST", "AK", `/v1.0/edu/universities/teachers`, "json", req, runtime), new CreateUniversityTeacherResponse({}));
  }

}
