// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CfEmploymentRecordResp extends $tea.Model {
  deptCode?: string;
  deptName?: string;
  employeeStatus?: string;
  endDate?: string;
  isLatestRecord?: boolean;
  jobLevelName?: string;
  jobPositionCode?: string;
  jobPositionName?: string;
  jobPostCode?: string;
  jobPostName?: string;
  serviceStatus?: string;
  serviceType?: string;
  startDate?: string;
  workNumbers?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      deptName: 'deptName',
      employeeStatus: 'employeeStatus',
      endDate: 'endDate',
      isLatestRecord: 'isLatestRecord',
      jobLevelName: 'jobLevelName',
      jobPositionCode: 'jobPositionCode',
      jobPositionName: 'jobPositionName',
      jobPostCode: 'jobPostCode',
      jobPostName: 'jobPostName',
      serviceStatus: 'serviceStatus',
      serviceType: 'serviceType',
      startDate: 'startDate',
      workNumbers: 'workNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
      deptName: 'string',
      employeeStatus: 'string',
      endDate: 'string',
      isLatestRecord: 'boolean',
      jobLevelName: 'string',
      jobPositionCode: 'string',
      jobPositionName: 'string',
      jobPostCode: 'string',
      jobPostName: 'string',
      serviceStatus: 'string',
      serviceType: 'string',
      startDate: 'string',
      workNumbers: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CfJobLevelResp extends $tea.Model {
  level?: number;
  name?: string;
  startDate?: string;
  stopDate?: string;
  static names(): { [key: string]: string } {
    return {
      level: 'level',
      name: 'name',
      startDate: 'startDate',
      stopDate: 'stopDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      level: 'number',
      name: 'string',
      startDate: 'string',
      stopDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CfJobPositionResp extends $tea.Model {
  jobPositionCode?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      jobPositionCode: 'jobPositionCode',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobPositionCode: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CfJobPostResp extends $tea.Model {
  jobPostCode?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      jobPostCode: 'jobPostCode',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobPostCode: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CfOrgResp extends $tea.Model {
  deptCode?: string;
  deptName?: string;
  level?: number;
  organizationCodePath?: string;
  organizationPath?: string;
  parentDeptCode?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      deptName: 'deptName',
      level: 'level',
      organizationCodePath: 'organizationCodePath',
      organizationPath: 'organizationPath',
      parentDeptCode: 'parentDeptCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
      deptName: 'string',
      level: 'number',
      organizationCodePath: 'string',
      organizationPath: 'string',
      parentDeptCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CfStaffResp extends $tea.Model {
  deptCode?: string;
  deptName?: string;
  email?: string;
  mobile?: string;
  name?: string;
  nickName?: string;
  workNumbers?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      deptName: 'deptName',
      email: 'email',
      mobile: 'mobile',
      name: 'name',
      nickName: 'nickName',
      workNumbers: 'workNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
      deptName: 'string',
      email: 'string',
      mobile: 'string',
      name: 'string',
      nickName: 'string',
      workNumbers: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenAnalyzeDataDTO extends $tea.Model {
  deptCount?: number;
  noAlignObjectiveCount?: number;
  noKeyActionCount?: number;
  objectiveAlignRate?: number;
  objectiveNoSetCount?: number;
  objectiveRiskCount?: number;
  objectiveSetRate?: number;
  onlyOneKeyResultCount?: number;
  onlyOneObjectiveCount?: number;
  progressUpdateRateLast15Days?: number;
  progressUpdateRateLast30Days?: number;
  progressUpdateRateLast7Days?: number;
  static names(): { [key: string]: string } {
    return {
      deptCount: 'deptCount',
      noAlignObjectiveCount: 'noAlignObjectiveCount',
      noKeyActionCount: 'noKeyActionCount',
      objectiveAlignRate: 'objectiveAlignRate',
      objectiveNoSetCount: 'objectiveNoSetCount',
      objectiveRiskCount: 'objectiveRiskCount',
      objectiveSetRate: 'objectiveSetRate',
      onlyOneKeyResultCount: 'onlyOneKeyResultCount',
      onlyOneObjectiveCount: 'onlyOneObjectiveCount',
      progressUpdateRateLast15Days: 'progressUpdateRateLast15Days',
      progressUpdateRateLast30Days: 'progressUpdateRateLast30Days',
      progressUpdateRateLast7Days: 'progressUpdateRateLast7Days',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCount: 'number',
      noAlignObjectiveCount: 'number',
      noKeyActionCount: 'number',
      objectiveAlignRate: 'number',
      objectiveNoSetCount: 'number',
      objectiveRiskCount: 'number',
      objectiveSetRate: 'number',
      onlyOneKeyResultCount: 'number',
      onlyOneObjectiveCount: 'number',
      progressUpdateRateLast15Days: 'number',
      progressUpdateRateLast30Days: 'number',
      progressUpdateRateLast7Days: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenKeyResultDTO extends $tea.Model {
  id?: string;
  progress?: number;
  status?: number;
  title?: string;
  titleMentions?: TitleMention[];
  type?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      progress: 'progress',
      status: 'status',
      title: 'title',
      titleMentions: 'titleMentions',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      progress: 'number',
      status: 'number',
      title: 'string',
      titleMentions: { 'type': 'array', 'itemType': TitleMention },
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenObjectiveDTO extends $tea.Model {
  executor?: OpenUserDTO;
  id?: string;
  keyResults?: OpenKeyResultDTO[];
  period?: OpenPeriodDTO;
  progress?: number;
  status?: number;
  teams?: OpenTeamDTO[];
  title?: string;
  static names(): { [key: string]: string } {
    return {
      executor: 'executor',
      id: 'id',
      keyResults: 'keyResults',
      period: 'period',
      progress: 'progress',
      status: 'status',
      teams: 'teams',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executor: OpenUserDTO,
      id: 'string',
      keyResults: { 'type': 'array', 'itemType': OpenKeyResultDTO },
      period: OpenPeriodDTO,
      progress: 'number',
      status: 'number',
      teams: { 'type': 'array', 'itemType': OpenTeamDTO },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenPeriodDTO extends $tea.Model {
  endDate?: number;
  id?: string;
  name?: string;
  periodBizType?: string;
  startDate?: number;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      id: 'id',
      name: 'name',
      periodBizType: 'periodBizType',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'number',
      id: 'string',
      name: 'string',
      periodBizType: 'string',
      startDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenProgressDTO extends $tea.Model {
  created?: number;
  creator?: OpenUserDTO;
  htmlContent?: string;
  id?: string;
  modifier?: OpenUserDTO;
  updated?: number;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creator: 'creator',
      htmlContent: 'htmlContent',
      id: 'id',
      modifier: 'modifier',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'number',
      creator: OpenUserDTO,
      htmlContent: 'string',
      id: 'string',
      modifier: OpenUserDTO,
      updated: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenTeamDTO extends $tea.Model {
  id?: string;
  name?: string;
  openId?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      openId: 'openId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      openId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserDTO extends $tea.Model {
  id?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TitleMention extends $tea.Model {
  length?: number;
  offset?: number;
  user?: OpenUserDTO;
  static names(): { [key: string]: string } {
    return {
      length: 'length',
      offset: 'offset',
      user: 'user',
    };
  }

  static types(): { [key: string]: any } {
    return {
      length: 'number',
      offset: 'number',
      user: OpenUserDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobLevelHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobLevelResponseBody extends $tea.Model {
  content?: CfJobLevelResp[];
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CfJobLevelResp },
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobLevelResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAllJobLevelResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAllJobLevelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobPositionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobPositionResponseBody extends $tea.Model {
  content?: CfJobPositionResp[];
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CfJobPositionResp },
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobPositionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAllJobPositionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAllJobPositionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobPostHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobPostResponseBody extends $tea.Model {
  content?: CfJobPostResp[];
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CfJobPostResp },
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllJobPostResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAllJobPostResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAllJobPostResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAnalyzeDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAnalyzeDataRequest extends $tea.Model {
  periodIds?: string[];
  deptId?: string;
  static names(): { [key: string]: string } {
    return {
      periodIds: 'periodIds',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodIds: { 'type': 'array', 'itemType': 'string' },
      deptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAnalyzeDataResponseBody extends $tea.Model {
  content?: OpenAnalyzeDataDTO;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: OpenAnalyzeDataDTO,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAnalyzeDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAnalyzeDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAnalyzeDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChildOrgListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChildOrgListRequest extends $tea.Model {
  deptCode?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChildOrgListResponseBody extends $tea.Model {
  content?: CfOrgResp[];
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CfOrgResp },
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChildOrgListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetChildOrgListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetChildOrgListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoRequest extends $tea.Model {
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponseBody extends $tea.Model {
  content?: GetEmployeeInfoByWorkNoResponseBodyContent;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetEmployeeInfoByWorkNoResponseBodyContent,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetEmployeeInfoByWorkNoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetEmployeeInfoByWorkNoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmploymentRecordByWorkNoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmploymentRecordByWorkNoResponseBody extends $tea.Model {
  content?: CfEmploymentRecordResp[];
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': CfEmploymentRecordResp },
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmploymentRecordByWorkNoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetEmploymentRecordByWorkNoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetEmploymentRecordByWorkNoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPositionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPositionRequest extends $tea.Model {
  jobPositionCode?: string;
  static names(): { [key: string]: string } {
    return {
      jobPositionCode: 'jobPositionCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobPositionCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPositionResponseBody extends $tea.Model {
  content?: GetJobPositionResponseBodyContent;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetJobPositionResponseBodyContent,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPositionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetJobPositionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetJobPositionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPostHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPostRequest extends $tea.Model {
  jobPostCode?: string;
  static names(): { [key: string]: string } {
    return {
      jobPostCode: 'jobPostCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobPostCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPostResponseBody extends $tea.Model {
  content?: GetJobPostResponseBodyContent;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetJobPostResponseBodyContent,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPostResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetJobPostResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetJobPostResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgInfoRequest extends $tea.Model {
  deptCode?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgInfoResponseBody extends $tea.Model {
  content?: GetOrgInfoResponseBodyContent;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetOrgInfoResponseBodyContent,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOrgInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffInfoByWorkNoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffInfoByWorkNoRequest extends $tea.Model {
  workNumbers?: string;
  static names(): { [key: string]: string } {
    return {
      workNumbers: 'workNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNumbers: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffInfoByWorkNoResponseBody extends $tea.Model {
  content?: GetStaffInfoByWorkNoResponseBodyContent;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetStaffInfoByWorkNoResponseBodyContent,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffInfoByWorkNoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetStaffInfoByWorkNoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetStaffInfoByWorkNoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffPageQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffPageQueryRequest extends $tea.Model {
  deptCode?: string;
  name?: string;
  pageNumber?: number;
  pageSize?: number;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      name: 'name',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
      name: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffPageQueryResponseBody extends $tea.Model {
  content?: GetStaffPageQueryResponseBodyContent;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetStaffPageQueryResponseBodyContent,
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffPageQueryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetStaffPageQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetStaffPageQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRequest extends $tea.Model {
  okrUserId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      okrUserId: 'okrUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      okrUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBody extends $tea.Model {
  content?: OpenUserDTO;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: OpenUserDTO,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAnalyzePeriodsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAnalyzePeriodsResponseBody extends $tea.Model {
  content?: OpenPeriodDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenPeriodDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAnalyzePeriodsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAnalyzePeriodsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAnalyzePeriodsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsRequest extends $tea.Model {
  objectiveIds?: string[];
  static names(): { [key: string]: string } {
    return {
      objectiveIds: 'objectiveIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsResponseBody extends $tea.Model {
  content?: OpenObjectiveDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenObjectiveDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListObjectiveByIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListObjectiveByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserRequest extends $tea.Model {
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

export class ListObjectiveByUserResponseBody extends $tea.Model {
  content?: ListObjectiveByUserResponseBodyContent;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: ListObjectiveByUserResponseBodyContent,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListObjectiveByUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListObjectiveByUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsRequest extends $tea.Model {
  progressIds?: string[];
  static names(): { [key: string]: string } {
    return {
      progressIds: 'progressIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      progressIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsResponseBody extends $tea.Model {
  content?: OpenProgressDTO[];
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenProgressDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListProgressByIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListProgressByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressRequest extends $tea.Model {
  objectiveId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      objectiveId: 'objectiveId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressResponseBody extends $tea.Model {
  content?: PageListObjectiveProgressResponseBodyContent;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: PageListObjectiveProgressResponseBodyContent,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PageListObjectiveProgressResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PageListObjectiveProgressResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveRequest extends $tea.Model {
  objectiveId?: string;
  targetUserId?: string;
  static names(): { [key: string]: string } {
    return {
      objectiveId: 'objectiveId',
      targetUserId: 'targetUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveId: 'string',
      targetUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveResponseBody extends $tea.Model {
  content?: boolean;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'boolean',
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: TransferUserObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TransferUserObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponseBodyContent extends $tea.Model {
  name?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPositionResponseBodyContent extends $tea.Model {
  description?: string;
  establishDate?: string;
  jobCode?: string;
  jobRequirements?: string;
  name?: string;
  startDate?: string;
  stopDate?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      establishDate: 'establishDate',
      jobCode: 'jobCode',
      jobRequirements: 'jobRequirements',
      name: 'name',
      startDate: 'startDate',
      stopDate: 'stopDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      establishDate: 'string',
      jobCode: 'string',
      jobRequirements: 'string',
      name: 'string',
      startDate: 'string',
      stopDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobPostResponseBodyContent extends $tea.Model {
  code?: string;
  establishDate?: string;
  name?: string;
  startDate?: string;
  stopDate?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      establishDate: 'establishDate',
      name: 'name',
      startDate: 'startDate',
      stopDate: 'stopDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      establishDate: 'string',
      name: 'string',
      startDate: 'string',
      stopDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgInfoResponseBodyContent extends $tea.Model {
  deptCode?: string;
  deptName?: string;
  deptNum?: string;
  level?: string;
  organizationCodePath?: string;
  organizationPath?: string;
  parentDeptCode?: string;
  shortName?: string;
  startDate?: string;
  stopDate?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      deptName: 'deptName',
      deptNum: 'deptNum',
      level: 'level',
      organizationCodePath: 'organizationCodePath',
      organizationPath: 'organizationPath',
      parentDeptCode: 'parentDeptCode',
      shortName: 'shortName',
      startDate: 'startDate',
      stopDate: 'stopDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
      deptName: 'string',
      deptNum: 'string',
      level: 'string',
      organizationCodePath: 'string',
      organizationPath: 'string',
      parentDeptCode: 'string',
      shortName: 'string',
      startDate: 'string',
      stopDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffInfoByWorkNoResponseBodyContent extends $tea.Model {
  deptCode?: string;
  deptName?: string;
  email?: string;
  employType?: string;
  employeeStatus?: string;
  jobLevelName?: string;
  jobPositionCode?: string;
  jobPositionName?: string;
  jobPostCode?: string;
  jobPostName?: string;
  mobile?: string;
  name?: string;
  nickName?: string;
  workNumbers?: string;
  static names(): { [key: string]: string } {
    return {
      deptCode: 'deptCode',
      deptName: 'deptName',
      email: 'email',
      employType: 'employType',
      employeeStatus: 'employeeStatus',
      jobLevelName: 'jobLevelName',
      jobPositionCode: 'jobPositionCode',
      jobPositionName: 'jobPositionName',
      jobPostCode: 'jobPostCode',
      jobPostName: 'jobPostName',
      mobile: 'mobile',
      name: 'name',
      nickName: 'nickName',
      workNumbers: 'workNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCode: 'string',
      deptName: 'string',
      email: 'string',
      employType: 'string',
      employeeStatus: 'string',
      jobLevelName: 'string',
      jobPositionCode: 'string',
      jobPositionName: 'string',
      jobPostCode: 'string',
      jobPostName: 'string',
      mobile: 'string',
      name: 'string',
      nickName: 'string',
      workNumbers: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStaffPageQueryResponseBodyContent extends $tea.Model {
  data?: CfStaffResp[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': CfStaffResp },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserResponseBodyContent extends $tea.Model {
  count?: number;
  objectives?: OpenObjectiveDTO[];
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      objectives: 'objectives',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      objectives: { 'type': 'array', 'itemType': OpenObjectiveDTO },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressResponseBodyContent extends $tea.Model {
  count?: number;
  progressList?: OpenProgressDTO[];
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      progressList: 'progressList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      progressList: { 'type': 'array', 'itemType': OpenProgressDTO },
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


  async getAllJobLevel(): Promise<GetAllJobLevelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllJobLevelHeaders({ });
    return await this.getAllJobLevelWithOptions(headers, runtime);
  }

  async getAllJobLevelWithOptions(headers: GetAllJobLevelHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllJobLevelResponse> {
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
    return $tea.cast<GetAllJobLevelResponse>(await this.doROARequest("GetAllJobLevel", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/jobLevels`, "json", req, runtime), new GetAllJobLevelResponse({}));
  }

  async getAllJobPosition(): Promise<GetAllJobPositionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllJobPositionHeaders({ });
    return await this.getAllJobPositionWithOptions(headers, runtime);
  }

  async getAllJobPositionWithOptions(headers: GetAllJobPositionHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllJobPositionResponse> {
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
    return $tea.cast<GetAllJobPositionResponse>(await this.doROARequest("GetAllJobPosition", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/jobPositions`, "json", req, runtime), new GetAllJobPositionResponse({}));
  }

  async getAllJobPost(): Promise<GetAllJobPostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllJobPostHeaders({ });
    return await this.getAllJobPostWithOptions(headers, runtime);
  }

  async getAllJobPostWithOptions(headers: GetAllJobPostHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllJobPostResponse> {
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
    return $tea.cast<GetAllJobPostResponse>(await this.doROARequest("GetAllJobPost", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/jobPosts`, "json", req, runtime), new GetAllJobPostResponse({}));
  }

  async getAnalyzeData(request: GetAnalyzeDataRequest): Promise<GetAnalyzeDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAnalyzeDataHeaders({ });
    return await this.getAnalyzeDataWithOptions(request, headers, runtime);
  }

  async getAnalyzeDataWithOptions(request: GetAnalyzeDataRequest, headers: GetAnalyzeDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetAnalyzeDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.periodIds)) {
      body["periodIds"] = request.periodIds;
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
    return $tea.cast<GetAnalyzeDataResponse>(await this.doROARequest("GetAnalyzeData", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/analyses/datas/query`, "json", req, runtime), new GetAnalyzeDataResponse({}));
  }

  async getChildOrgList(request: GetChildOrgListRequest): Promise<GetChildOrgListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetChildOrgListHeaders({ });
    return await this.getChildOrgListWithOptions(request, headers, runtime);
  }

  async getChildOrgListWithOptions(request: GetChildOrgListRequest, headers: GetChildOrgListHeaders, runtime: $Util.RuntimeOptions): Promise<GetChildOrgListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptCode)) {
      query["deptCode"] = request.deptCode;
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
    return $tea.cast<GetChildOrgListResponse>(await this.doROARequest("GetChildOrgList", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/organizations`, "json", req, runtime), new GetChildOrgListResponse({}));
  }

  async getEmployeeInfoByWorkNo(request: GetEmployeeInfoByWorkNoRequest): Promise<GetEmployeeInfoByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmployeeInfoByWorkNoHeaders({ });
    return await this.getEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
  }

  async getEmployeeInfoByWorkNoWithOptions(request: GetEmployeeInfoByWorkNoRequest, headers: GetEmployeeInfoByWorkNoHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmployeeInfoByWorkNoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.workNo)) {
      query["workNo"] = request.workNo;
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
    return $tea.cast<GetEmployeeInfoByWorkNoResponse>(await this.doROARequest("GetEmployeeInfoByWorkNo", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/workNumbers/employees`, "json", req, runtime), new GetEmployeeInfoByWorkNoResponse({}));
  }

  async getEmploymentRecordByWorkNo(workNumbers: string): Promise<GetEmploymentRecordByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmploymentRecordByWorkNoHeaders({ });
    return await this.getEmploymentRecordByWorkNoWithOptions(workNumbers, headers, runtime);
  }

  async getEmploymentRecordByWorkNoWithOptions(workNumbers: string, headers: GetEmploymentRecordByWorkNoHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmploymentRecordByWorkNoResponse> {
    workNumbers = OpenApiUtil.getEncodeParam(workNumbers);
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
    return $tea.cast<GetEmploymentRecordByWorkNoResponse>(await this.doROARequest("GetEmploymentRecordByWorkNo", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/users/workNumber/${workNumbers}employmentRecords`, "json", req, runtime), new GetEmploymentRecordByWorkNoResponse({}));
  }

  async getJobPosition(request: GetJobPositionRequest): Promise<GetJobPositionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobPositionHeaders({ });
    return await this.getJobPositionWithOptions(request, headers, runtime);
  }

  async getJobPositionWithOptions(request: GetJobPositionRequest, headers: GetJobPositionHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobPositionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobPositionCode)) {
      query["jobPositionCode"] = request.jobPositionCode;
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
    return $tea.cast<GetJobPositionResponse>(await this.doROARequest("GetJobPosition", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/jobPositions/infos`, "json", req, runtime), new GetJobPositionResponse({}));
  }

  async getJobPost(request: GetJobPostRequest): Promise<GetJobPostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobPostHeaders({ });
    return await this.getJobPostWithOptions(request, headers, runtime);
  }

  async getJobPostWithOptions(request: GetJobPostRequest, headers: GetJobPostHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobPostResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobPostCode)) {
      query["jobPostCode"] = request.jobPostCode;
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
    return $tea.cast<GetJobPostResponse>(await this.doROARequest("GetJobPost", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/jobPosts/infos`, "json", req, runtime), new GetJobPostResponse({}));
  }

  async getOrgInfo(request: GetOrgInfoRequest): Promise<GetOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrgInfoHeaders({ });
    return await this.getOrgInfoWithOptions(request, headers, runtime);
  }

  async getOrgInfoWithOptions(request: GetOrgInfoRequest, headers: GetOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrgInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptCode)) {
      query["deptCode"] = request.deptCode;
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
    return $tea.cast<GetOrgInfoResponse>(await this.doROARequest("GetOrgInfo", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/organizations/infos`, "json", req, runtime), new GetOrgInfoResponse({}));
  }

  async getStaffInfoByWorkNo(request: GetStaffInfoByWorkNoRequest): Promise<GetStaffInfoByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStaffInfoByWorkNoHeaders({ });
    return await this.getStaffInfoByWorkNoWithOptions(request, headers, runtime);
  }

  async getStaffInfoByWorkNoWithOptions(request: GetStaffInfoByWorkNoRequest, headers: GetStaffInfoByWorkNoHeaders, runtime: $Util.RuntimeOptions): Promise<GetStaffInfoByWorkNoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.workNumbers)) {
      query["workNumbers"] = request.workNumbers;
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
    return $tea.cast<GetStaffInfoByWorkNoResponse>(await this.doROARequest("GetStaffInfoByWorkNo", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/users`, "json", req, runtime), new GetStaffInfoByWorkNoResponse({}));
  }

  async getStaffPageQuery(request: GetStaffPageQueryRequest): Promise<GetStaffPageQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStaffPageQueryHeaders({ });
    return await this.getStaffPageQueryWithOptions(request, headers, runtime);
  }

  async getStaffPageQueryWithOptions(request: GetStaffPageQueryRequest, headers: GetStaffPageQueryHeaders, runtime: $Util.RuntimeOptions): Promise<GetStaffPageQueryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptCode)) {
      query["deptCode"] = request.deptCode;
    }

    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.workNo)) {
      query["workNo"] = request.workNo;
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
    return $tea.cast<GetStaffPageQueryResponse>(await this.doROARequest("GetStaffPageQuery", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/users/query`, "json", req, runtime), new GetStaffPageQueryResponse({}));
  }

  async getUser(request: GetUserRequest): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(request, headers, runtime);
  }

  async getUserWithOptions(request: GetUserRequest, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.okrUserId)) {
      query["okrUserId"] = request.okrUserId;
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
    return $tea.cast<GetUserResponse>(await this.doROARequest("GetUser", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/users`, "json", req, runtime), new GetUserResponse({}));
  }

  async listAnalyzePeriods(): Promise<ListAnalyzePeriodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAnalyzePeriodsHeaders({ });
    return await this.listAnalyzePeriodsWithOptions(headers, runtime);
  }

  async listAnalyzePeriodsWithOptions(headers: ListAnalyzePeriodsHeaders, runtime: $Util.RuntimeOptions): Promise<ListAnalyzePeriodsResponse> {
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
    return $tea.cast<ListAnalyzePeriodsResponse>(await this.doROARequest("ListAnalyzePeriods", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/analyses/periods`, "json", req, runtime), new ListAnalyzePeriodsResponse({}));
  }

  async listObjectiveByIds(request: ListObjectiveByIdsRequest): Promise<ListObjectiveByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListObjectiveByIdsHeaders({ });
    return await this.listObjectiveByIdsWithOptions(request, headers, runtime);
  }

  async listObjectiveByIdsWithOptions(request: ListObjectiveByIdsRequest, headers: ListObjectiveByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListObjectiveByIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveIds)) {
      body["objectiveIds"] = request.objectiveIds;
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
    return $tea.cast<ListObjectiveByIdsResponse>(await this.doROARequest("ListObjectiveByIds", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/objectives/query`, "json", req, runtime), new ListObjectiveByIdsResponse({}));
  }

  async listObjectiveByUser(request: ListObjectiveByUserRequest): Promise<ListObjectiveByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListObjectiveByUserHeaders({ });
    return await this.listObjectiveByUserWithOptions(request, headers, runtime);
  }

  async listObjectiveByUserWithOptions(request: ListObjectiveByUserRequest, headers: ListObjectiveByUserHeaders, runtime: $Util.RuntimeOptions): Promise<ListObjectiveByUserResponse> {
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
    return $tea.cast<ListObjectiveByUserResponse>(await this.doROARequest("ListObjectiveByUser", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/users/objectives`, "json", req, runtime), new ListObjectiveByUserResponse({}));
  }

  async listProgressByIds(request: ListProgressByIdsRequest): Promise<ListProgressByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListProgressByIdsHeaders({ });
    return await this.listProgressByIdsWithOptions(request, headers, runtime);
  }

  async listProgressByIdsWithOptions(request: ListProgressByIdsRequest, headers: ListProgressByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListProgressByIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.progressIds)) {
      body["progressIds"] = request.progressIds;
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
    return $tea.cast<ListProgressByIdsResponse>(await this.doROARequest("ListProgressByIds", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/objectives/progresses/query`, "json", req, runtime), new ListProgressByIdsResponse({}));
  }

  async pageListObjectiveProgress(request: PageListObjectiveProgressRequest): Promise<PageListObjectiveProgressResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListObjectiveProgressHeaders({ });
    return await this.pageListObjectiveProgressWithOptions(request, headers, runtime);
  }

  async pageListObjectiveProgressWithOptions(request: PageListObjectiveProgressRequest, headers: PageListObjectiveProgressHeaders, runtime: $Util.RuntimeOptions): Promise<PageListObjectiveProgressResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveId)) {
      query["objectiveId"] = request.objectiveId;
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
    return $tea.cast<PageListObjectiveProgressResponse>(await this.doROARequest("PageListObjectiveProgress", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/objectives/progresses/records`, "json", req, runtime), new PageListObjectiveProgressResponse({}));
  }

  async transferUserObjective(request: TransferUserObjectiveRequest): Promise<TransferUserObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferUserObjectiveHeaders({ });
    return await this.transferUserObjectiveWithOptions(request, headers, runtime);
  }

  async transferUserObjectiveWithOptions(request: TransferUserObjectiveRequest, headers: TransferUserObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<TransferUserObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveId)) {
      query["objectiveId"] = request.objectiveId;
    }

    if (!Util.isUnset(request.targetUserId)) {
      query["targetUserId"] = request.targetUserId;
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
    return $tea.cast<TransferUserObjectiveResponse>(await this.doROARequest("TransferUserObjective", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/objectives/transfer`, "json", req, runtime), new TransferUserObjectiveResponse({}));
  }

}
