// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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

}
