// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CfEmploymentRecordResp extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 666
   */
  deptCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 开发部
   */
  deptName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  employeeStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1652198400000
   */
  endDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  isLatestRecord?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * P1
   */
  jobLevelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 23
   */
  jobPositionCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Java开发工程师
   */
  jobPositionName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 343
   */
  jobPostCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 技术岗位
   */
  jobPostName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  serviceStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5
   */
  serviceType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1638892800000
   */
  startDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  level?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * P1
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1639065600000
   */
  startDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1652198400000
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  jobPositionCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Java开发
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  jobPostCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 技术岗
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 01
   */
  deptCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 一级部门
   */
  deptName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  level?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1/01
   */
  organizationCodePath?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 公司/一级部门
   */
  organizationPath?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  deptCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 开发部
   */
  deptName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 17*******@qq.com
   */
  email?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 151********
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 松柏
   */
  nickName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  deptCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 22
   */
  noAlignObjectiveCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33
   */
  noKeyActionCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33.2
   */
  objectiveAlignRate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  objectiveNoSetCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 11
   */
  objectiveRiskCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33.3
   */
  objectiveSetRate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 44
   */
  onlyOneKeyResultCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33
   */
  onlyOneObjectiveCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 22.3
   */
  progressUpdateRateLast15Days?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33.11
   */
  progressUpdateRateLast30Days?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33.4
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33
   */
  progress?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 完成数据迁移
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  titleMentions?: TitleMention[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  executor?: OpenUserDTO;
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  keyResults?: OpenKeyResultDTO[];
  /**
   * @remarks
   * This parameter is required.
   */
  period?: OpenPeriodDTO;
  /**
   * @remarks
   * This parameter is required.
   */
  progress?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  teams?: OpenTeamDTO[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 提升系统性能
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 311212121
   */
  endDate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2023
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FY_S1
   */
  periodBizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8383838383
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 48383883
   */
  created?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  creator?: OpenUserDTO;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 我的目标
   */
  htmlContent?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 11
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  modifier?: OpenUserDTO;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 48383883
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 销售部
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 30211
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 王五
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 015310183065939140
   */
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

export class SlsLogResp extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 新增
   */
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * HolidayChangeRecord
   */
  entity?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0ba35cd517156543461401313d12b4|null
   */
  header?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 提交申请
   */
  info?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 维同
   */
  operator?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 橙奕科技
   */
  tenant?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  tenantId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1638892800000
   */
  time?: number;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      entity: 'entity',
      header: 'header',
      id: 'id',
      info: 'info',
      operator: 'operator',
      tenant: 'tenant',
      tenantId: 'tenantId',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      entity: 'string',
      header: 'string',
      id: 'string',
      info: 'string',
      operator: 'string',
      tenant: 'string',
      tenantId: 'string',
      time: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TitleMention extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 22
   */
  length?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  offset?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 请求ID
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllJobLevelResponseBody;
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
  /**
   * @example
   * 123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllJobPositionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  content?: CfJobPostResp[];
  /**
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllJobPostResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 32222
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAnalyzeDataResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   * 
   * **if can be null:**
   * false
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetChildOrgListResponseBody;
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
  /**
   * @example
   * 305932
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetEmployeeInfoByWorkNoResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetEmploymentRecordByWorkNoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetJobPositionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetJobPostResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOrgInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetStaffInfoByWorkNoResponseBody;
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
  /**
   * @example
   * 123
   */
  deptCode?: string;
  /**
   * @example
   * 张三
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * 123456
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetStaffPageQueryResponseBody;
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
  /**
   * @example
   * 3adeaddeddddd
   */
  okrUserId?: string;
  /**
   * @example
   * 0344333
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAnalyzePeriodsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
  requestId?: string;
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListObjectiveByIdsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListObjectiveByUserResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListProgressByIdsResponseBody;
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
      body: ListProgressByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSlsLogHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSlsLogRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * it-hr
   */
  appCode?: string;
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      endTime: 'endTime',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      endTime: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSlsLogResponseBody extends $tea.Model {
  content?: ListSlsLogResponseBodyContent;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: ListSlsLogResponseBodyContent,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSlsLogResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSlsLogResponseBody;
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
      body: ListSlsLogResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  objectiveId?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PageListObjectiveProgressResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  objectiveId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * true
   */
  content?: boolean;
  /**
   * @example
   * 1111
   */
  requestId?: string;
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TransferUserObjectiveResponseBody;
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
      body: TransferUserObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponseBodyContent extends $tea.Model {
  /**
   * @example
   * 姜小白
   */
  name?: string;
  /**
   * @example
   * 305932
   */
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
  /**
   * @example
   * 1678886770065
   */
  description?: string;
  /**
   * @example
   * 1678886770065
   */
  establishDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  jobCode?: string;
  /**
   * @example
   * 有良好的技术素养
   */
  jobRequirements?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 技术开发
   */
  name?: string;
  /**
   * @example
   * 1678886770065
   */
  startDate?: string;
  /**
   * @example
   * 1678886770065
   */
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
  /**
   * @example
   * 123
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  establishDate?: string;
  /**
   * @example
   * 测试
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  startDate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 123
   */
  deptCode?: string;
  /**
   * @example
   * 开发技术部
   */
  deptName?: string;
  /**
   * @example
   * 10
   */
  deptNum?: string;
  /**
   * @example
   * 1
   */
  level?: string;
  /**
   * @example
   * /1/123
   */
  organizationCodePath?: string;
  /**
   * @example
   * /开发技术部
   */
  organizationPath?: string;
  /**
   * @example
   * 1
   */
  parentDeptCode?: string;
  /**
   * @example
   * 开发部
   */
  shortName?: string;
  /**
   * @example
   * 1678886770065
   */
  startDate?: string;
  /**
   * @example
   * 1678886770065
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  deptCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 开发部
   */
  deptName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 17********@qq.com
   */
  email?: string;
  /**
   * @example
   * 1
   */
  employType?: string;
  /**
   * @example
   * 1
   */
  employeeStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  jobLevelName?: string;
  /**
   * @example
   * 1
   */
  jobPositionCode?: string;
  /**
   * @example
   * Java开发
   */
  jobPositionName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  jobPostCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 技术开发
   */
  jobPostName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 151********
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 花名
   */
  nickName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * 1
   */
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

export class ListSlsLogResponseBodyContent extends $tea.Model {
  currentPageSize?: number;
  data?: SlsLogResp[];
  pageNumber?: number;
  pageSize?: number;
  pages?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      currentPageSize: 'currentPageSize',
      data: 'data',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      pages: 'pages',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPageSize: 'number',
      data: { 'type': 'array', 'itemType': SlsLogResp },
      pageNumber: 'number',
      pageSize: 'number',
      pages: 'number',
      totalCount: 'number',
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 获取组织下的全部职级
   * 
   * @param headers - GetAllJobLevelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllJobLevelResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetAllJobLevel",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/jobLevels`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllJobLevelResponse>(await this.execute(params, req, runtime), new GetAllJobLevelResponse({}));
  }

  /**
   * 获取组织下的全部职级
   * @returns GetAllJobLevelResponse
   */
  async getAllJobLevel(): Promise<GetAllJobLevelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllJobLevelHeaders({ });
    return await this.getAllJobLevelWithOptions(headers, runtime);
  }

  /**
   * 获取公司全部职位
   * 
   * @param headers - GetAllJobPositionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllJobPositionResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetAllJobPosition",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/jobPositions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllJobPositionResponse>(await this.execute(params, req, runtime), new GetAllJobPositionResponse({}));
  }

  /**
   * 获取公司全部职位
   * @returns GetAllJobPositionResponse
   */
  async getAllJobPosition(): Promise<GetAllJobPositionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllJobPositionHeaders({ });
    return await this.getAllJobPositionWithOptions(headers, runtime);
  }

  /**
   * 获取组织下的所有职务
   * 
   * @param headers - GetAllJobPostHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllJobPostResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetAllJobPost",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/jobPosts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllJobPostResponse>(await this.execute(params, req, runtime), new GetAllJobPostResponse({}));
  }

  /**
   * 获取组织下的所有职务
   * @returns GetAllJobPostResponse
   */
  async getAllJobPost(): Promise<GetAllJobPostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllJobPostHeaders({ });
    return await this.getAllJobPostWithOptions(headers, runtime);
  }

  /**
   * 获取分析运营数据
   * 
   * @param request - GetAnalyzeDataRequest
   * @param headers - GetAnalyzeDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAnalyzeDataResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetAnalyzeData",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/analyses/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAnalyzeDataResponse>(await this.execute(params, req, runtime), new GetAnalyzeDataResponse({}));
  }

  /**
   * 获取分析运营数据
   * 
   * @param request - GetAnalyzeDataRequest
   * @returns GetAnalyzeDataResponse
   */
  async getAnalyzeData(request: GetAnalyzeDataRequest): Promise<GetAnalyzeDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAnalyzeDataHeaders({ });
    return await this.getAnalyzeDataWithOptions(request, headers, runtime);
  }

  /**
   * 根据部门编码查询下组织列表
   * 
   * @param request - GetChildOrgListRequest
   * @param headers - GetChildOrgListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetChildOrgListResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetChildOrgList",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/organizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetChildOrgListResponse>(await this.execute(params, req, runtime), new GetChildOrgListResponse({}));
  }

  /**
   * 根据部门编码查询下组织列表
   * 
   * @param request - GetChildOrgListRequest
   * @returns GetChildOrgListResponse
   */
  async getChildOrgList(request: GetChildOrgListRequest): Promise<GetChildOrgListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetChildOrgListHeaders({ });
    return await this.getChildOrgListWithOptions(request, headers, runtime);
  }

  /**
   * 根据工号查询员工基础信息
   * 
   * @param request - GetEmployeeInfoByWorkNoRequest
   * @param headers - GetEmployeeInfoByWorkNoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetEmployeeInfoByWorkNoResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetEmployeeInfoByWorkNo",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/workNumbers/employees`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEmployeeInfoByWorkNoResponse>(await this.execute(params, req, runtime), new GetEmployeeInfoByWorkNoResponse({}));
  }

  /**
   * 根据工号查询员工基础信息
   * 
   * @param request - GetEmployeeInfoByWorkNoRequest
   * @returns GetEmployeeInfoByWorkNoResponse
   */
  async getEmployeeInfoByWorkNo(request: GetEmployeeInfoByWorkNoRequest): Promise<GetEmployeeInfoByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmployeeInfoByWorkNoHeaders({ });
    return await this.getEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
  }

  /**
   * 根据人员工号查询人员任职记录
   * 
   * @param headers - GetEmploymentRecordByWorkNoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetEmploymentRecordByWorkNoResponse
   */
  async getEmploymentRecordByWorkNoWithOptions(workNumbers: string, headers: GetEmploymentRecordByWorkNoHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmploymentRecordByWorkNoResponse> {
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
      action: "GetEmploymentRecordByWorkNo",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/users/workNumber/${workNumbers}employmentRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEmploymentRecordByWorkNoResponse>(await this.execute(params, req, runtime), new GetEmploymentRecordByWorkNoResponse({}));
  }

  /**
   * 根据人员工号查询人员任职记录
   * @returns GetEmploymentRecordByWorkNoResponse
   */
  async getEmploymentRecordByWorkNo(workNumbers: string): Promise<GetEmploymentRecordByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmploymentRecordByWorkNoHeaders({ });
    return await this.getEmploymentRecordByWorkNoWithOptions(workNumbers, headers, runtime);
  }

  /**
   * 获取职位详情
   * 
   * @param request - GetJobPositionRequest
   * @param headers - GetJobPositionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetJobPositionResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetJobPosition",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/jobPositions/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetJobPositionResponse>(await this.execute(params, req, runtime), new GetJobPositionResponse({}));
  }

  /**
   * 获取职位详情
   * 
   * @param request - GetJobPositionRequest
   * @returns GetJobPositionResponse
   */
  async getJobPosition(request: GetJobPositionRequest): Promise<GetJobPositionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobPositionHeaders({ });
    return await this.getJobPositionWithOptions(request, headers, runtime);
  }

  /**
   * 根据编码获取职位详情
   * 
   * @param request - GetJobPostRequest
   * @param headers - GetJobPostHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetJobPostResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetJobPost",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/jobPosts/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetJobPostResponse>(await this.execute(params, req, runtime), new GetJobPostResponse({}));
  }

  /**
   * 根据编码获取职位详情
   * 
   * @param request - GetJobPostRequest
   * @returns GetJobPostResponse
   */
  async getJobPost(request: GetJobPostRequest): Promise<GetJobPostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobPostHeaders({ });
    return await this.getJobPostWithOptions(request, headers, runtime);
  }

  /**
   * 获取组织详情
   * 
   * @param request - GetOrgInfoRequest
   * @param headers - GetOrgInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOrgInfoResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetOrgInfo",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/organizations/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrgInfoResponse>(await this.execute(params, req, runtime), new GetOrgInfoResponse({}));
  }

  /**
   * 获取组织详情
   * 
   * @param request - GetOrgInfoRequest
   * @returns GetOrgInfoResponse
   */
  async getOrgInfo(request: GetOrgInfoRequest): Promise<GetOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrgInfoHeaders({ });
    return await this.getOrgInfoWithOptions(request, headers, runtime);
  }

  /**
   * 根据员工工号获取员工的基本信息
   * 
   * @param request - GetStaffInfoByWorkNoRequest
   * @param headers - GetStaffInfoByWorkNoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetStaffInfoByWorkNoResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetStaffInfoByWorkNo",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetStaffInfoByWorkNoResponse>(await this.execute(params, req, runtime), new GetStaffInfoByWorkNoResponse({}));
  }

  /**
   * 根据员工工号获取员工的基本信息
   * 
   * @param request - GetStaffInfoByWorkNoRequest
   * @returns GetStaffInfoByWorkNoResponse
   */
  async getStaffInfoByWorkNo(request: GetStaffInfoByWorkNoRequest): Promise<GetStaffInfoByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStaffInfoByWorkNoHeaders({ });
    return await this.getStaffInfoByWorkNoWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询员工信息
   * 
   * @param request - GetStaffPageQueryRequest
   * @param headers - GetStaffPageQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetStaffPageQueryResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetStaffPageQuery",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/users/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetStaffPageQueryResponse>(await this.execute(params, req, runtime), new GetStaffPageQueryResponse({}));
  }

  /**
   * 分页查询员工信息
   * 
   * @param request - GetStaffPageQueryRequest
   * @returns GetStaffPageQueryResponse
   */
  async getStaffPageQuery(request: GetStaffPageQueryRequest): Promise<GetStaffPageQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStaffPageQueryHeaders({ });
    return await this.getStaffPageQueryWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户信息
   * 
   * @param request - GetUserRequest
   * @param headers - GetUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetUser",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserResponse>(await this.execute(params, req, runtime), new GetUserResponse({}));
  }

  /**
   * 获取用户信息
   * 
   * @param request - GetUserRequest
   * @returns GetUserResponse
   */
  async getUser(request: GetUserRequest): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(request, headers, runtime);
  }

  /**
   * 运营数据分析下的周期列表
   * 
   * @param headers - ListAnalyzePeriodsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAnalyzePeriodsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ListAnalyzePeriods",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/analyses/periods`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAnalyzePeriodsResponse>(await this.execute(params, req, runtime), new ListAnalyzePeriodsResponse({}));
  }

  /**
   * 运营数据分析下的周期列表
   * @returns ListAnalyzePeriodsResponse
   */
  async listAnalyzePeriods(): Promise<ListAnalyzePeriodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAnalyzePeriodsHeaders({ });
    return await this.listAnalyzePeriodsWithOptions(headers, runtime);
  }

  /**
   * 根据目标id批量获取目标列表
   * 
   * @param request - ListObjectiveByIdsRequest
   * @param headers - ListObjectiveByIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListObjectiveByIdsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ListObjectiveByIds",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/objectives/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListObjectiveByIdsResponse>(await this.execute(params, req, runtime), new ListObjectiveByIdsResponse({}));
  }

  /**
   * 根据目标id批量获取目标列表
   * 
   * @param request - ListObjectiveByIdsRequest
   * @returns ListObjectiveByIdsResponse
   */
  async listObjectiveByIds(request: ListObjectiveByIdsRequest): Promise<ListObjectiveByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListObjectiveByIdsHeaders({ });
    return await this.listObjectiveByIdsWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户的 OKR 列表
   * 
   * @param request - ListObjectiveByUserRequest
   * @param headers - ListObjectiveByUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListObjectiveByUserResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ListObjectiveByUser",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/users/objectives`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListObjectiveByUserResponse>(await this.execute(params, req, runtime), new ListObjectiveByUserResponse({}));
  }

  /**
   * 获取用户的 OKR 列表
   * 
   * @param request - ListObjectiveByUserRequest
   * @returns ListObjectiveByUserResponse
   */
  async listObjectiveByUser(request: ListObjectiveByUserRequest): Promise<ListObjectiveByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListObjectiveByUserHeaders({ });
    return await this.listObjectiveByUserWithOptions(request, headers, runtime);
  }

  /**
   * 根据进展id获取进展列表
   * 
   * @param request - ListProgressByIdsRequest
   * @param headers - ListProgressByIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListProgressByIdsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ListProgressByIds",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/objectives/progresses/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListProgressByIdsResponse>(await this.execute(params, req, runtime), new ListProgressByIdsResponse({}));
  }

  /**
   * 根据进展id获取进展列表
   * 
   * @param request - ListProgressByIdsRequest
   * @returns ListProgressByIdsResponse
   */
  async listProgressByIds(request: ListProgressByIdsRequest): Promise<ListProgressByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListProgressByIdsHeaders({ });
    return await this.listProgressByIdsWithOptions(request, headers, runtime);
  }

  /**
   * 获取组织下的日志数据
   * 
   * @param request - ListSlsLogRequest
   * @param headers - ListSlsLogHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSlsLogResponse
   */
  async listSlsLogWithOptions(request: ListSlsLogRequest, headers: ListSlsLogHeaders, runtime: $Util.RuntimeOptions): Promise<ListSlsLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appCode)) {
      query["appCode"] = request.appCode;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
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
      action: "ListSlsLog",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/organizations/slsLogDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListSlsLogResponse>(await this.execute(params, req, runtime), new ListSlsLogResponse({}));
  }

  /**
   * 获取组织下的日志数据
   * 
   * @param request - ListSlsLogRequest
   * @returns ListSlsLogResponse
   */
  async listSlsLog(request: ListSlsLogRequest): Promise<ListSlsLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSlsLogHeaders({ });
    return await this.listSlsLogWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取目标进展记录
   * 
   * @param request - PageListObjectiveProgressRequest
   * @param headers - PageListObjectiveProgressHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PageListObjectiveProgressResponse
   */
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
    let params = new $OpenApi.Params({
      action: "PageListObjectiveProgress",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/objectives/progresses/records`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PageListObjectiveProgressResponse>(await this.execute(params, req, runtime), new PageListObjectiveProgressResponse({}));
  }

  /**
   * 分页获取目标进展记录
   * 
   * @param request - PageListObjectiveProgressRequest
   * @returns PageListObjectiveProgressResponse
   */
  async pageListObjectiveProgress(request: PageListObjectiveProgressRequest): Promise<PageListObjectiveProgressResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListObjectiveProgressHeaders({ });
    return await this.pageListObjectiveProgressWithOptions(request, headers, runtime);
  }

  /**
   * 转交目标OKR
   * 
   * @param request - TransferUserObjectiveRequest
   * @param headers - TransferUserObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TransferUserObjectiveResponse
   */
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
    let params = new $OpenApi.Params({
      action: "TransferUserObjective",
      version: "chengfeng_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/chengfeng/okr/objectives/transfer`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TransferUserObjectiveResponse>(await this.execute(params, req, runtime), new TransferUserObjectiveResponse({}));
  }

  /**
   * 转交目标OKR
   * 
   * @param request - TransferUserObjectiveRequest
   * @returns TransferUserObjectiveResponse
   */
  async transferUserObjective(request: TransferUserObjectiveRequest): Promise<TransferUserObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferUserObjectiveHeaders({ });
    return await this.transferUserObjectiveWithOptions(request, headers, runtime);
  }

}
