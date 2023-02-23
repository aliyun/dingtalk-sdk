// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddProjectMemberHeaders extends $tea.Model {
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

export class AddProjectMemberRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProjectMemberResponseBody extends $tea.Model {
  result?: AddProjectMemberResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': AddProjectMemberResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProjectMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddProjectMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddProjectMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskHeaders extends $tea.Model {
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

export class CreateOrganizationTaskRequest extends $tea.Model {
  content?: string;
  createTime?: string;
  disableActivity?: boolean;
  disableNotification?: boolean;
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  note?: string;
  priority?: number;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      createTime: 'createTime',
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      note: 'note',
      priority: 'priority',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      createTime: 'string',
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      note: 'string',
      priority: 'number',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskResponseBody extends $tea.Model {
  result?: CreateOrganizationTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateOrganizationTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateOrganizationTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateOrganizationTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePlanTimeHeaders extends $tea.Model {
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

export class CreatePlanTimeRequest extends $tea.Model {
  endDate?: string;
  executorId?: string;
  includesHolidays?: boolean;
  isDuration?: boolean;
  objectId?: string;
  objectType?: string;
  planTime?: number;
  startDate?: string;
  submitterId?: string;
  tenantType?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      executorId: 'executorId',
      includesHolidays: 'includesHolidays',
      isDuration: 'isDuration',
      objectId: 'objectId',
      objectType: 'objectType',
      planTime: 'planTime',
      startDate: 'startDate',
      submitterId: 'submitterId',
      tenantType: 'tenantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      executorId: 'string',
      includesHolidays: 'boolean',
      isDuration: 'boolean',
      objectId: 'string',
      objectType: 'string',
      planTime: 'number',
      startDate: 'string',
      submitterId: 'string',
      tenantType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePlanTimeResponseBody extends $tea.Model {
  result?: CreatePlanTimeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreatePlanTimeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePlanTimeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreatePlanTimeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreatePlanTimeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectByTemplateHeaders extends $tea.Model {
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

export class CreateProjectByTemplateRequest extends $tea.Model {
  name?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectByTemplateResponseBody extends $tea.Model {
  result?: CreateProjectByTemplateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateProjectByTemplateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectByTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateProjectByTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateProjectByTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskHeaders extends $tea.Model {
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

export class CreateTaskRequest extends $tea.Model {
  content?: string;
  customfields?: CreateTaskRequestCustomfields[];
  dueDate?: string;
  executorId?: string;
  note?: string;
  parentTaskId?: string;
  priority?: number;
  projectId?: string;
  scenariofieldconfigId?: string;
  stageId?: string;
  startDate?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      customfields: 'customfields',
      dueDate: 'dueDate',
      executorId: 'executorId',
      note: 'note',
      parentTaskId: 'parentTaskId',
      priority: 'priority',
      projectId: 'projectId',
      scenariofieldconfigId: 'scenariofieldconfigId',
      stageId: 'stageId',
      startDate: 'startDate',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      customfields: { 'type': 'array', 'itemType': CreateTaskRequestCustomfields },
      dueDate: 'string',
      executorId: 'string',
      note: 'string',
      parentTaskId: 'string',
      priority: 'number',
      projectId: 'string',
      scenariofieldconfigId: 'string',
      stageId: 'string',
      startDate: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskResponseBody extends $tea.Model {
  result?: CreateTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskObjectLinkHeaders extends $tea.Model {
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

export class CreateTaskObjectLinkRequest extends $tea.Model {
  linkedData?: CreateTaskObjectLinkRequestLinkedData;
  static names(): { [key: string]: string } {
    return {
      linkedData: 'linkedData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      linkedData: CreateTaskObjectLinkRequestLinkedData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskObjectLinkResponseBody extends $tea.Model {
  result?: CreateTaskObjectLinkResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateTaskObjectLinkResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskObjectLinkResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTaskObjectLinkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTaskObjectLinkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeHeaders extends $tea.Model {
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

export class CreateWorkTimeRequest extends $tea.Model {
  endDate?: string;
  executorId?: string;
  includesHolidays?: boolean;
  isDuration?: boolean;
  objectId?: string;
  objectType?: string;
  startDate?: string;
  submitterId?: string;
  workTime?: number;
  tenantType?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      executorId: 'executorId',
      includesHolidays: 'includesHolidays',
      isDuration: 'isDuration',
      objectId: 'objectId',
      objectType: 'objectType',
      startDate: 'startDate',
      submitterId: 'submitterId',
      workTime: 'workTime',
      tenantType: 'tenantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      executorId: 'string',
      includesHolidays: 'boolean',
      isDuration: 'boolean',
      objectId: 'string',
      objectType: 'string',
      startDate: 'string',
      submitterId: 'string',
      workTime: 'number',
      tenantType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeResponseBody extends $tea.Model {
  result?: CreateWorkTimeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateWorkTimeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateWorkTimeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateWorkTimeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingOrgId?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingOrgId: 'dingOrgId',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingOrgId: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdResponseBody extends $tea.Model {
  deptList?: GetDeptsByOrgIdResponseBodyDeptList[];
  hasMore?: boolean;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      deptList: 'deptList',
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptList: { 'type': 'array', 'itemType': GetDeptsByOrgIdResponseBodyDeptList },
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDeptsByOrgIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDeptsByOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingOrgId?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingOrgId: 'dingOrgId',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingOrgId: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdRequest extends $tea.Model {
  maxResults?: number;
  needDept?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      needDept: 'needDept',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      needDept: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdResponseBody extends $tea.Model {
  empList?: GetEmpsByOrgIdResponseBodyEmpList[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      empList: 'empList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      empList: { 'type': 'array', 'itemType': GetEmpsByOrgIdResponseBodyEmpList },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetEmpsByOrgIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetEmpsByOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizatioTaskByIdsHeaders extends $tea.Model {
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

export class GetOrganizatioTaskByIdsRequest extends $tea.Model {
  taskIds?: string;
  static names(): { [key: string]: string } {
    return {
      taskIds: 'taskIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizatioTaskByIdsResponseBody extends $tea.Model {
  result?: GetOrganizatioTaskByIdsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetOrganizatioTaskByIdsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizatioTaskByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOrganizatioTaskByIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOrganizatioTaskByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationPriorityListHeaders extends $tea.Model {
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

export class GetOrganizationPriorityListResponseBody extends $tea.Model {
  result?: GetOrganizationPriorityListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetOrganizationPriorityListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationPriorityListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOrganizationPriorityListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOrganizationPriorityListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationTaskHeaders extends $tea.Model {
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

export class GetOrganizationTaskResponseBody extends $tea.Model {
  result?: GetOrganizationTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetOrganizationTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOrganizationTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOrganizationTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectGroupHeaders extends $tea.Model {
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

export class GetProjectGroupRequest extends $tea.Model {
  pageSize?: number;
  viewerId?: string;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      viewerId: 'viewerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      viewerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectGroupResponseBody extends $tea.Model {
  result?: GetProjectGroupResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetProjectGroupResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetProjectGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetProjectGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbOrgIdByDingOrgIdHeaders extends $tea.Model {
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

export class GetTbOrgIdByDingOrgIdRequest extends $tea.Model {
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

export class GetTbOrgIdByDingOrgIdResponseBody extends $tea.Model {
  result?: GetTbOrgIdByDingOrgIdResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetTbOrgIdByDingOrgIdResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbOrgIdByDingOrgIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbOrgIdByDingOrgIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbOrgIdByDingOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingCorpId?: string;
  dingIsvOrgId?: string;
  dingOrgId?: string;
  dingSuiteKey?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingCorpId: 'dingCorpId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingCorpId: 'string',
      dingIsvOrgId: 'string',
      dingOrgId: 'string',
      dingSuiteKey: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayRequest extends $tea.Model {
  label?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbProjectGrayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbProjectGrayResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingCorpId?: string;
  dingIsvOrgId?: string;
  dingOrgId?: string;
  dingSuiteKey?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingCorpId: 'dingCorpId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingCorpId: 'string',
      dingIsvOrgId: 'string',
      dingOrgId: 'string',
      dingSuiteKey: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceResponseBody extends $tea.Model {
  installSource?: string;
  static names(): { [key: string]: string } {
    return {
      installSource: 'installSource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      installSource: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbProjectSourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbProjectSourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbUserIdByStaffIdHeaders extends $tea.Model {
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

export class GetTbUserIdByStaffIdRequest extends $tea.Model {
  optUserId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      optUserId: 'optUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      optUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbUserIdByStaffIdResponseBody extends $tea.Model {
  result?: GetTbUserIdByStaffIdResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetTbUserIdByStaffIdResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbUserIdByStaffIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbUserIdByStaffIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbUserIdByStaffIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTaskOfProjectHeaders extends $tea.Model {
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

export class QueryTaskOfProjectRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  query?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      query: 'query',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      query: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTaskOfProjectResponseBody extends $tea.Model {
  nextToken?: string;
  result?: QueryTaskOfProjectResponseBodyResult[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      result: 'result',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      result: { 'type': 'array', 'itemType': QueryTaskOfProjectResponseBodyResult },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTaskOfProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryTaskOfProjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryTaskOfProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectTemplateHeaders extends $tea.Model {
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

export class SearchProjectTemplateRequest extends $tea.Model {
  keyword?: string;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectTemplateResponseBody extends $tea.Model {
  result?: SearchProjectTemplateResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SearchProjectTemplateResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchProjectTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchProjectTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskflowStatusHeaders extends $tea.Model {
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

export class SearchTaskflowStatusRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  query?: string;
  tfIds?: string;
  tfsIds?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      query: 'query',
      tfIds: 'tfIds',
      tfsIds: 'tfsIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      query: 'string',
      tfIds: 'string',
      tfsIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskflowStatusResponseBody extends $tea.Model {
  result?: SearchTaskflowStatusResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SearchTaskflowStatusResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskflowStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchTaskflowStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchTaskflowStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueHeaders extends $tea.Model {
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

export class UpdateCustomfieldValueRequest extends $tea.Model {
  customfieldId?: string;
  customfieldName?: string;
  value?: UpdateCustomfieldValueRequestValue[];
  static names(): { [key: string]: string } {
    return {
      customfieldId: 'customfieldId',
      customfieldName: 'customfieldName',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customfieldId: 'string',
      customfieldName: 'string',
      value: { 'type': 'array', 'itemType': UpdateCustomfieldValueRequestValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueResponseBody extends $tea.Model {
  result?: UpdateCustomfieldValueResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateCustomfieldValueResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateCustomfieldValueResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateCustomfieldValueResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskContentHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskContentRequest extends $tea.Model {
  content?: string;
  disableActivity?: boolean;
  disableNotification?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      disableActivity: 'boolean',
      disableNotification: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskContentResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskContentResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskContentResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskContentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskContentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskDueDateHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskDueDateRequest extends $tea.Model {
  disableActivity?: boolean;
  disableNotification?: boolean;
  dueDate?: string;
  static names(): { [key: string]: string } {
    return {
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      dueDate: 'dueDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      dueDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskDueDateResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskDueDateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskDueDateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskDueDateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskDueDateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskDueDateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskExecutorHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskExecutorRequest extends $tea.Model {
  disableActivity?: boolean;
  disableNotification?: boolean;
  executorId?: string;
  static names(): { [key: string]: string } {
    return {
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      executorId: 'executorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      executorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskExecutorResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskExecutorResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskExecutorResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskExecutorResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskExecutorResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskExecutorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskInvolveMembersHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskInvolveMembersRequest extends $tea.Model {
  addInvolvers?: string[];
  delInvolvers?: string[];
  disableActivity?: boolean;
  disableNotification?: boolean;
  involveMembers?: string[];
  static names(): { [key: string]: string } {
    return {
      addInvolvers: 'addInvolvers',
      delInvolvers: 'delInvolvers',
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      involveMembers: 'involveMembers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addInvolvers: { 'type': 'array', 'itemType': 'string' },
      delInvolvers: { 'type': 'array', 'itemType': 'string' },
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskInvolveMembersResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskInvolveMembersResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskInvolveMembersResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskInvolveMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskInvolveMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskInvolveMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskNoteHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskNoteRequest extends $tea.Model {
  disableActivity?: boolean;
  disableNotification?: boolean;
  note?: string;
  static names(): { [key: string]: string } {
    return {
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      note: 'note',
    };
  }

  static types(): { [key: string]: any } {
    return {
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      note: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskNoteResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskNoteResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskNoteResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskNoteResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskNoteResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskNoteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskPriorityHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskPriorityRequest extends $tea.Model {
  disableActivity?: boolean;
  disableNotification?: boolean;
  priority?: number;
  static names(): { [key: string]: string } {
    return {
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      priority: 'priority',
    };
  }

  static types(): { [key: string]: any } {
    return {
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      priority: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskPriorityResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskPriorityResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskPriorityResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskPriorityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskPriorityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskPriorityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskStatusHeaders extends $tea.Model {
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

export class UpdateOrganizationTaskStatusRequest extends $tea.Model {
  disableActivity?: boolean;
  disableNotification?: boolean;
  isDone?: boolean;
  static names(): { [key: string]: string } {
    return {
      disableActivity: 'disableActivity',
      disableNotification: 'disableNotification',
      isDone: 'isDone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      disableActivity: 'boolean',
      disableNotification: 'boolean',
      isDone: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskStatusResponseBody extends $tea.Model {
  result?: UpdateOrganizationTaskStatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateOrganizationTaskStatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateOrganizationTaskStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateOrganizationTaskStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProjectGroupHeaders extends $tea.Model {
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

export class UpdateProjectGroupRequest extends $tea.Model {
  addProjectGroupIds?: string[];
  delProjectGroupIds?: string[];
  static names(): { [key: string]: string } {
    return {
      addProjectGroupIds: 'addProjectGroupIds',
      delProjectGroupIds: 'delProjectGroupIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addProjectGroupIds: { 'type': 'array', 'itemType': 'string' },
      delProjectGroupIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProjectGroupResponseBody extends $tea.Model {
  result?: UpdateProjectGroupResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateProjectGroupResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProjectGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateProjectGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateProjectGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskTaskflowstatusHeaders extends $tea.Model {
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

export class UpdateTaskTaskflowstatusRequest extends $tea.Model {
  taskflowStatusId?: string;
  tfsUpdateNote?: string;
  static names(): { [key: string]: string } {
    return {
      taskflowStatusId: 'taskflowStatusId',
      tfsUpdateNote: 'tfsUpdateNote',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskflowStatusId: 'string',
      tfsUpdateNote: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskTaskflowstatusResponseBody extends $tea.Model {
  result?: UpdateTaskTaskflowstatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskTaskflowstatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskTaskflowstatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateTaskTaskflowstatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateTaskTaskflowstatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProjectMemberResponseBodyResult extends $tea.Model {
  joined?: string;
  nickname?: string;
  static names(): { [key: string]: string } {
    return {
      joined: 'joined',
      nickname: 'nickname',
    };
  }

  static types(): { [key: string]: any } {
    return {
      joined: 'string',
      nickname: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskResponseBodyResultCreator extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskResponseBodyResultExecutor extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskResponseBodyResultInvolvers extends $tea.Model {
  avatarUrl?: string;
  id?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOrganizationTaskResponseBodyResult extends $tea.Model {
  ancestorIds?: string[];
  attachmentsCount?: number;
  content?: string;
  created?: string;
  creator?: CreateOrganizationTaskResponseBodyResultCreator;
  creatorId?: string;
  dueDate?: string;
  executor?: CreateOrganizationTaskResponseBodyResultExecutor;
  executorId?: string;
  hasReminder?: boolean;
  id?: string;
  involveMembers?: string[];
  involvers?: CreateOrganizationTaskResponseBodyResultInvolvers[];
  isDeleted?: boolean;
  isDone?: string;
  note?: string;
  priority?: number;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      ancestorIds: 'ancestorIds',
      attachmentsCount: 'attachmentsCount',
      content: 'content',
      created: 'created',
      creator: 'creator',
      creatorId: 'creatorId',
      dueDate: 'dueDate',
      executor: 'executor',
      executorId: 'executorId',
      hasReminder: 'hasReminder',
      id: 'id',
      involveMembers: 'involveMembers',
      involvers: 'involvers',
      isDeleted: 'isDeleted',
      isDone: 'isDone',
      note: 'note',
      priority: 'priority',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ancestorIds: { 'type': 'array', 'itemType': 'string' },
      attachmentsCount: 'number',
      content: 'string',
      created: 'string',
      creator: CreateOrganizationTaskResponseBodyResultCreator,
      creatorId: 'string',
      dueDate: 'string',
      executor: CreateOrganizationTaskResponseBodyResultExecutor,
      executorId: 'string',
      hasReminder: 'boolean',
      id: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      involvers: { 'type': 'array', 'itemType': CreateOrganizationTaskResponseBodyResultInvolvers },
      isDeleted: 'boolean',
      isDone: 'string',
      note: 'string',
      priority: 'number',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePlanTimeResponseBodyResultBody extends $tea.Model {
  date?: string;
  objectId?: string;
  planTime?: number;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      objectId: 'objectId',
      planTime: 'planTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      objectId: 'string',
      planTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePlanTimeResponseBodyResult extends $tea.Model {
  body?: CreatePlanTimeResponseBodyResultBody[];
  message?: string;
  ok?: boolean;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      message: 'message',
      ok: 'ok',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': CreatePlanTimeResponseBodyResultBody },
      message: 'string',
      ok: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectByTemplateResponseBodyResult extends $tea.Model {
  created?: string;
  id?: string;
  logo?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      id: 'id',
      logo: 'logo',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      id: 'string',
      logo: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskRequestCustomfieldsValue extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskRequestCustomfields extends $tea.Model {
  customfieldId?: string;
  customfieldName?: string;
  value?: CreateTaskRequestCustomfieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customfieldId: 'customfieldId',
      customfieldName: 'customfieldName',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customfieldId: 'string',
      customfieldName: 'string',
      value: { 'type': 'array', 'itemType': CreateTaskRequestCustomfieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskResponseBodyResultCustomfieldsValue extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskResponseBodyResultCustomfields extends $tea.Model {
  customfieldId?: string;
  value?: CreateTaskResponseBodyResultCustomfieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customfieldId: 'customfieldId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customfieldId: 'string',
      value: { 'type': 'array', 'itemType': CreateTaskResponseBodyResultCustomfieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskResponseBodyResult extends $tea.Model {
  content?: string;
  created?: string;
  creatorId?: string;
  customfields?: CreateTaskResponseBodyResultCustomfields[];
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  note?: string;
  priority?: number;
  projectId?: string;
  taskId?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      customfields: 'customfields',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      note: 'note',
      priority: 'priority',
      projectId: 'projectId',
      taskId: 'taskId',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      created: 'string',
      creatorId: 'string',
      customfields: { 'type': 'array', 'itemType': CreateTaskResponseBodyResultCustomfields },
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      note: 'string',
      priority: 'number',
      projectId: 'string',
      taskId: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskObjectLinkRequestLinkedData extends $tea.Model {
  content?: string;
  thumbnailUrl?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      thumbnailUrl: 'thumbnailUrl',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      thumbnailUrl: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTaskObjectLinkResponseBodyResult extends $tea.Model {
  created?: string;
  objectLinkId?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      objectLinkId: 'objectLinkId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      objectLinkId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeResponseBodyResultBody extends $tea.Model {
  date?: string;
  taskId?: string;
  workTime?: number;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      taskId: 'taskId',
      workTime: 'workTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      taskId: 'string',
      workTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeResponseBodyResult extends $tea.Model {
  body?: CreateWorkTimeResponseBodyResultBody[];
  message?: string;
  ok?: boolean;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      message: 'message',
      ok: 'ok',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': CreateWorkTimeResponseBodyResultBody },
      message: 'string',
      ok: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdResponseBodyDeptList extends $tea.Model {
  deptId?: number;
  name?: string;
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'dept_id',
      name: 'name',
      parentId: 'parent_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdResponseBodyEmpList extends $tea.Model {
  avatar?: string;
  deptIdList?: number[];
  dingId?: string;
  name?: string;
  nick?: string;
  orgId?: number;
  position?: string;
  unionid?: string;
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      deptIdList: 'dept_id_list',
      dingId: 'dingId',
      name: 'name',
      nick: 'nick',
      orgId: 'orgId',
      position: 'position',
      unionid: 'unionid',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      dingId: 'string',
      name: 'string',
      nick: 'string',
      orgId: 'number',
      position: 'string',
      unionid: 'string',
      userid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizatioTaskByIdsResponseBodyResult extends $tea.Model {
  ancestorIds?: string[];
  content?: string;
  created?: string;
  creatorId?: string;
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  isDeleted?: boolean;
  isDone?: boolean;
  labels?: string[];
  note?: string;
  priority?: number;
  startDate?: string;
  taskId?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      ancestorIds: 'ancestorIds',
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      isDeleted: 'isDeleted',
      isDone: 'isDone',
      labels: 'labels',
      note: 'note',
      priority: 'priority',
      startDate: 'startDate',
      taskId: 'taskId',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ancestorIds: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      created: 'string',
      creatorId: 'string',
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      isDeleted: 'boolean',
      isDone: 'boolean',
      labels: { 'type': 'array', 'itemType': 'string' },
      note: 'string',
      priority: 'number',
      startDate: 'string',
      taskId: 'string',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationPriorityListResponseBodyResult extends $tea.Model {
  color?: string;
  name?: string;
  priority?: string;
  priorityId?: string;
  static names(): { [key: string]: string } {
    return {
      color: 'color',
      name: 'name',
      priority: 'priority',
      priorityId: 'priorityId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      color: 'string',
      name: 'string',
      priority: 'string',
      priorityId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationTaskResponseBodyResult extends $tea.Model {
  ancestorIds?: string[];
  content?: string;
  created?: string;
  creatorId?: string;
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  isDeleted?: boolean;
  isDone?: boolean;
  labels?: string[];
  note?: string;
  priority?: number;
  startDate?: string;
  taskId?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      ancestorIds: 'ancestorIds',
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      isDeleted: 'isDeleted',
      isDone: 'isDone',
      labels: 'labels',
      note: 'note',
      priority: 'priority',
      startDate: 'startDate',
      taskId: 'taskId',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ancestorIds: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      created: 'string',
      creatorId: 'string',
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      isDeleted: 'boolean',
      isDone: 'boolean',
      labels: { 'type': 'array', 'itemType': 'string' },
      note: 'string',
      priority: 'number',
      startDate: 'string',
      taskId: 'string',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectGroupResponseBodyResult extends $tea.Model {
  created?: string;
  id?: string;
  name?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      id: 'id',
      name: 'name',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      id: 'string',
      name: 'string',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbOrgIdByDingOrgIdResponseBodyResult extends $tea.Model {
  tbOrganizationId?: string;
  static names(): { [key: string]: string } {
    return {
      tbOrganizationId: 'tbOrganizationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tbOrganizationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbUserIdByStaffIdResponseBodyResult extends $tea.Model {
  tbUserId?: string;
  static names(): { [key: string]: string } {
    return {
      tbUserId: 'tbUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tbUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTaskOfProjectResponseBodyResultCustomfields extends $tea.Model {
  customfieldId?: string;
  static names(): { [key: string]: string } {
    return {
      customfieldId: 'customfieldId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customfieldId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTaskOfProjectResponseBodyResult extends $tea.Model {
  accomplished?: string;
  ancestorIds?: string[];
  content?: string;
  created?: string;
  creatorId?: string;
  customfields?: QueryTaskOfProjectResponseBodyResultCustomfields[];
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  isArchived?: boolean;
  isDeleted?: boolean;
  isDone?: boolean;
  labels?: string[];
  note?: string;
  priority?: number;
  progress?: number;
  projectId?: string;
  scenariofieldconfigId?: string;
  sprintId?: string;
  stageId?: string;
  startDate?: string;
  storyPoint?: number;
  tagIds?: string[];
  taskId?: string;
  taskflowstatusId?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      accomplished: 'accomplished',
      ancestorIds: 'ancestorIds',
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      customfields: 'customfields',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      isArchived: 'isArchived',
      isDeleted: 'isDeleted',
      isDone: 'isDone',
      labels: 'labels',
      note: 'note',
      priority: 'priority',
      progress: 'progress',
      projectId: 'projectId',
      scenariofieldconfigId: 'scenariofieldconfigId',
      sprintId: 'sprintId',
      stageId: 'stageId',
      startDate: 'startDate',
      storyPoint: 'storyPoint',
      tagIds: 'tagIds',
      taskId: 'taskId',
      taskflowstatusId: 'taskflowstatusId',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accomplished: 'string',
      ancestorIds: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      created: 'string',
      creatorId: 'string',
      customfields: { 'type': 'array', 'itemType': QueryTaskOfProjectResponseBodyResultCustomfields },
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      isArchived: 'boolean',
      isDeleted: 'boolean',
      isDone: 'boolean',
      labels: { 'type': 'array', 'itemType': 'string' },
      note: 'string',
      priority: 'number',
      progress: 'number',
      projectId: 'string',
      scenariofieldconfigId: 'string',
      sprintId: 'string',
      stageId: 'string',
      startDate: 'string',
      storyPoint: 'number',
      tagIds: { 'type': 'array', 'itemType': 'string' },
      taskId: 'string',
      taskflowstatusId: 'string',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectTemplateResponseBodyResult extends $tea.Model {
  created?: string;
  description?: string;
  id?: string;
  isDeleted?: boolean;
  isDemo?: boolean;
  logo?: string;
  name?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      description: 'description',
      id: 'id',
      isDeleted: 'isDeleted',
      isDemo: 'isDemo',
      logo: 'logo',
      name: 'name',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      description: 'string',
      id: 'string',
      isDeleted: 'boolean',
      isDemo: 'boolean',
      logo: 'string',
      name: 'string',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskflowStatusResponseBodyResult extends $tea.Model {
  created?: string;
  creatorId?: string;
  isDeleted?: boolean;
  isTaskflowstatusruleexector?: boolean;
  kind?: string;
  name?: string;
  pos?: number;
  rejectStatusIds?: string[];
  taskflowId?: string;
  taskflowStatusId?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creatorId: 'creatorId',
      isDeleted: 'isDeleted',
      isTaskflowstatusruleexector: 'isTaskflowstatusruleexector',
      kind: 'kind',
      name: 'name',
      pos: 'pos',
      rejectStatusIds: 'rejectStatusIds',
      taskflowId: 'taskflowId',
      taskflowStatusId: 'taskflowStatusId',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      creatorId: 'string',
      isDeleted: 'boolean',
      isTaskflowstatusruleexector: 'boolean',
      kind: 'string',
      name: 'string',
      pos: 'number',
      rejectStatusIds: { 'type': 'array', 'itemType': 'string' },
      taskflowId: 'string',
      taskflowStatusId: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueRequestValue extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueResponseBodyResultCustomfieldsValue extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueResponseBodyResultCustomfields extends $tea.Model {
  customfieldId?: string;
  value?: UpdateCustomfieldValueResponseBodyResultCustomfieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customfieldId: 'customfieldId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customfieldId: 'string',
      value: { 'type': 'array', 'itemType': UpdateCustomfieldValueResponseBodyResultCustomfieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueResponseBodyResult extends $tea.Model {
  customfields?: UpdateCustomfieldValueResponseBodyResultCustomfields[];
  static names(): { [key: string]: string } {
    return {
      customfields: 'customfields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customfields: { 'type': 'array', 'itemType': UpdateCustomfieldValueResponseBodyResultCustomfields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskContentResponseBodyResult extends $tea.Model {
  content?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskDueDateResponseBodyResult extends $tea.Model {
  dueDate?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      dueDate: 'dueDate',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dueDate: 'string',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskExecutorResponseBodyResultExecutor extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskExecutorResponseBodyResultInvolvers extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskExecutorResponseBodyResult extends $tea.Model {
  executor?: UpdateOrganizationTaskExecutorResponseBodyResultExecutor;
  executorId?: string;
  involvers?: UpdateOrganizationTaskExecutorResponseBodyResultInvolvers[];
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      executor: 'executor',
      executorId: 'executorId',
      involvers: 'involvers',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executor: UpdateOrganizationTaskExecutorResponseBodyResultExecutor,
      executorId: 'string',
      involvers: { 'type': 'array', 'itemType': UpdateOrganizationTaskExecutorResponseBodyResultInvolvers },
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskInvolveMembersResponseBodyResult extends $tea.Model {
  involvers?: UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers[];
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      involvers: 'involvers',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      involvers: { 'type': 'array', 'itemType': UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers },
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskNoteResponseBodyResult extends $tea.Model {
  note?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      note: 'note',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      note: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskPriorityResponseBodyResult extends $tea.Model {
  priority?: number;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      priority: 'priority',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      priority: 'number',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOrganizationTaskStatusResponseBodyResult extends $tea.Model {
  isDone?: boolean;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      isDone: 'isDone',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isDone: 'boolean',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateProjectGroupResponseBodyResult extends $tea.Model {
  ok?: boolean;
  static names(): { [key: string]: string } {
    return {
      ok: 'ok',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ok: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskTaskflowstatusResponseBodyResult extends $tea.Model {
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updated: 'string',
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


  async addProjectMember(userId: string, projectId: string, request: AddProjectMemberRequest): Promise<AddProjectMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddProjectMemberHeaders({ });
    return await this.addProjectMemberWithOptions(userId, projectId, request, headers, runtime);
  }

  async addProjectMemberWithOptions(userId: string, projectId: string, request: AddProjectMemberRequest, headers: AddProjectMemberHeaders, runtime: $Util.RuntimeOptions): Promise<AddProjectMemberResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    projectId = OpenApiUtil.getEncodeParam(projectId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<AddProjectMemberResponse>(await this.doROARequest("AddProjectMember", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/users/${userId}/projects/${projectId}/members`, "json", req, runtime), new AddProjectMemberResponse({}));
  }

  async createOrganizationTask(userId: string, request: CreateOrganizationTaskRequest): Promise<CreateOrganizationTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrganizationTaskHeaders({ });
    return await this.createOrganizationTaskWithOptions(userId, request, headers, runtime);
  }

  async createOrganizationTaskWithOptions(userId: string, request: CreateOrganizationTaskRequest, headers: CreateOrganizationTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOrganizationTaskResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
    }

    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.dueDate)) {
      body["dueDate"] = request.dueDate;
    }

    if (!Util.isUnset(request.executorId)) {
      body["executorId"] = request.executorId;
    }

    if (!Util.isUnset(request.involveMembers)) {
      body["involveMembers"] = request.involveMembers;
    }

    if (!Util.isUnset(request.note)) {
      body["note"] = request.note;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.visible)) {
      body["visible"] = request.visible;
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
    return $tea.cast<CreateOrganizationTaskResponse>(await this.doROARequest("CreateOrganizationTask", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/organizations/users/${userId}/tasks`, "json", req, runtime), new CreateOrganizationTaskResponse({}));
  }

  async createPlanTime(userId: string, request: CreatePlanTimeRequest): Promise<CreatePlanTimeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatePlanTimeHeaders({ });
    return await this.createPlanTimeWithOptions(userId, request, headers, runtime);
  }

  async createPlanTimeWithOptions(userId: string, request: CreatePlanTimeRequest, headers: CreatePlanTimeHeaders, runtime: $Util.RuntimeOptions): Promise<CreatePlanTimeResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantType)) {
      query["tenantType"] = request.tenantType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endDate)) {
      body["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.executorId)) {
      body["executorId"] = request.executorId;
    }

    if (!Util.isUnset(request.includesHolidays)) {
      body["includesHolidays"] = request.includesHolidays;
    }

    if (!Util.isUnset(request.isDuration)) {
      body["isDuration"] = request.isDuration;
    }

    if (!Util.isUnset(request.objectId)) {
      body["objectId"] = request.objectId;
    }

    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
    }

    if (!Util.isUnset(request.planTime)) {
      body["planTime"] = request.planTime;
    }

    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
    }

    if (!Util.isUnset(request.submitterId)) {
      body["submitterId"] = request.submitterId;
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
    return $tea.cast<CreatePlanTimeResponse>(await this.doROARequest("CreatePlanTime", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/users/${userId}/planTimes`, "json", req, runtime), new CreatePlanTimeResponse({}));
  }

  async createProjectByTemplate(userId: string, request: CreateProjectByTemplateRequest): Promise<CreateProjectByTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProjectByTemplateHeaders({ });
    return await this.createProjectByTemplateWithOptions(userId, request, headers, runtime);
  }

  async createProjectByTemplateWithOptions(userId: string, request: CreateProjectByTemplateRequest, headers: CreateProjectByTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProjectByTemplateResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
    return $tea.cast<CreateProjectByTemplateResponse>(await this.doROARequest("CreateProjectByTemplate", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/users/${userId}/templates/projects`, "json", req, runtime), new CreateProjectByTemplateResponse({}));
  }

  async createTask(userId: string, request: CreateTaskRequest): Promise<CreateTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTaskHeaders({ });
    return await this.createTaskWithOptions(userId, request, headers, runtime);
  }

  async createTaskWithOptions(userId: string, request: CreateTaskRequest, headers: CreateTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTaskResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.customfields)) {
      body["customfields"] = request.customfields;
    }

    if (!Util.isUnset(request.dueDate)) {
      body["dueDate"] = request.dueDate;
    }

    if (!Util.isUnset(request.executorId)) {
      body["executorId"] = request.executorId;
    }

    if (!Util.isUnset(request.note)) {
      body["note"] = request.note;
    }

    if (!Util.isUnset(request.parentTaskId)) {
      body["parentTaskId"] = request.parentTaskId;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.scenariofieldconfigId)) {
      body["scenariofieldconfigId"] = request.scenariofieldconfigId;
    }

    if (!Util.isUnset(request.stageId)) {
      body["stageId"] = request.stageId;
    }

    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
    }

    if (!Util.isUnset(request.visible)) {
      body["visible"] = request.visible;
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
    return $tea.cast<CreateTaskResponse>(await this.doROARequest("CreateTask", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/users/${userId}/tasks`, "json", req, runtime), new CreateTaskResponse({}));
  }

  async createTaskObjectLink(userId: string, taskId: string, request: CreateTaskObjectLinkRequest): Promise<CreateTaskObjectLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTaskObjectLinkHeaders({ });
    return await this.createTaskObjectLinkWithOptions(userId, taskId, request, headers, runtime);
  }

  async createTaskObjectLinkWithOptions(userId: string, taskId: string, request: CreateTaskObjectLinkRequest, headers: CreateTaskObjectLinkHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTaskObjectLinkResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.linkedData)) {
      body["linkedData"] = request.linkedData;
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
    return $tea.cast<CreateTaskObjectLinkResponse>(await this.doROARequest("CreateTaskObjectLink", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/users/${userId}/tasks/${taskId}/objectLinks`, "json", req, runtime), new CreateTaskObjectLinkResponse({}));
  }

  async createWorkTime(userId: string, request: CreateWorkTimeRequest): Promise<CreateWorkTimeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkTimeHeaders({ });
    return await this.createWorkTimeWithOptions(userId, request, headers, runtime);
  }

  async createWorkTimeWithOptions(userId: string, request: CreateWorkTimeRequest, headers: CreateWorkTimeHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkTimeResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantType)) {
      query["tenantType"] = request.tenantType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endDate)) {
      body["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.executorId)) {
      body["executorId"] = request.executorId;
    }

    if (!Util.isUnset(request.includesHolidays)) {
      body["includesHolidays"] = request.includesHolidays;
    }

    if (!Util.isUnset(request.isDuration)) {
      body["isDuration"] = request.isDuration;
    }

    if (!Util.isUnset(request.objectId)) {
      body["objectId"] = request.objectId;
    }

    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
    }

    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
    }

    if (!Util.isUnset(request.submitterId)) {
      body["submitterId"] = request.submitterId;
    }

    if (!Util.isUnset(request.workTime)) {
      body["workTime"] = request.workTime;
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
    return $tea.cast<CreateWorkTimeResponse>(await this.doROARequest("CreateWorkTime", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/users/${userId}/workTimes`, "json", req, runtime), new CreateWorkTimeResponse({}));
  }

  async getDeptsByOrgId(request: GetDeptsByOrgIdRequest): Promise<GetDeptsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeptsByOrgIdHeaders({ });
    return await this.getDeptsByOrgIdWithOptions(request, headers, runtime);
  }

  async getDeptsByOrgIdWithOptions(request: GetDeptsByOrgIdRequest, headers: GetDeptsByOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetDeptsByOrgIdResponse> {
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

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetDeptsByOrgIdResponse>(await this.doROARequest("GetDeptsByOrgId", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/orgs/depts`, "json", req, runtime), new GetDeptsByOrgIdResponse({}));
  }

  async getEmpsByOrgId(request: GetEmpsByOrgIdRequest): Promise<GetEmpsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmpsByOrgIdHeaders({ });
    return await this.getEmpsByOrgIdWithOptions(request, headers, runtime);
  }

  async getEmpsByOrgIdWithOptions(request: GetEmpsByOrgIdRequest, headers: GetEmpsByOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmpsByOrgIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.needDept)) {
      query["needDept"] = request.needDept;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetEmpsByOrgIdResponse>(await this.doROARequest("GetEmpsByOrgId", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/orgs/employees`, "json", req, runtime), new GetEmpsByOrgIdResponse({}));
  }

  async getOrganizatioTaskByIds(userId: string, request: GetOrganizatioTaskByIdsRequest): Promise<GetOrganizatioTaskByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizatioTaskByIdsHeaders({ });
    return await this.getOrganizatioTaskByIdsWithOptions(userId, request, headers, runtime);
  }

  async getOrganizatioTaskByIdsWithOptions(userId: string, request: GetOrganizatioTaskByIdsRequest, headers: GetOrganizatioTaskByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizatioTaskByIdsResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskIds)) {
      query["taskIds"] = request.taskIds;
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
    return $tea.cast<GetOrganizatioTaskByIdsResponse>(await this.doROARequest("GetOrganizatioTaskByIds", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/organizations/users/${userId}/tasks`, "json", req, runtime), new GetOrganizatioTaskByIdsResponse({}));
  }

  async getOrganizationPriorityList(userId: string): Promise<GetOrganizationPriorityListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizationPriorityListHeaders({ });
    return await this.getOrganizationPriorityListWithOptions(userId, headers, runtime);
  }

  async getOrganizationPriorityListWithOptions(userId: string, headers: GetOrganizationPriorityListHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizationPriorityListResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<GetOrganizationPriorityListResponse>(await this.doROARequest("GetOrganizationPriorityList", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/organizations/users/${userId}/priorities`, "json", req, runtime), new GetOrganizationPriorityListResponse({}));
  }

  async getOrganizationTask(taskId: string, userId: string): Promise<GetOrganizationTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizationTaskHeaders({ });
    return await this.getOrganizationTaskWithOptions(taskId, userId, headers, runtime);
  }

  async getOrganizationTaskWithOptions(taskId: string, userId: string, headers: GetOrganizationTaskHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizationTaskResponse> {
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<GetOrganizationTaskResponse>(await this.doROARequest("GetOrganizationTask", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}`, "json", req, runtime), new GetOrganizationTaskResponse({}));
  }

  async getProjectGroup(userId: string, request: GetProjectGroupRequest): Promise<GetProjectGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectGroupHeaders({ });
    return await this.getProjectGroupWithOptions(userId, request, headers, runtime);
  }

  async getProjectGroupWithOptions(userId: string, request: GetProjectGroupRequest, headers: GetProjectGroupHeaders, runtime: $Util.RuntimeOptions): Promise<GetProjectGroupResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.viewerId)) {
      query["viewerId"] = request.viewerId;
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
    return $tea.cast<GetProjectGroupResponse>(await this.doROARequest("GetProjectGroup", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/organizations/users/${userId}/groups`, "json", req, runtime), new GetProjectGroupResponse({}));
  }

  async getTbOrgIdByDingOrgId(request: GetTbOrgIdByDingOrgIdRequest): Promise<GetTbOrgIdByDingOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbOrgIdByDingOrgIdHeaders({ });
    return await this.getTbOrgIdByDingOrgIdWithOptions(request, headers, runtime);
  }

  async getTbOrgIdByDingOrgIdWithOptions(request: GetTbOrgIdByDingOrgIdRequest, headers: GetTbOrgIdByDingOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbOrgIdByDingOrgIdResponse> {
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
    return $tea.cast<GetTbOrgIdByDingOrgIdResponse>(await this.doROARequest("GetTbOrgIdByDingOrgId", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/teambition/organizations`, "json", req, runtime), new GetTbOrgIdByDingOrgIdResponse({}));
  }

  async getTbProjectGray(request: GetTbProjectGrayRequest): Promise<GetTbProjectGrayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectGrayHeaders({ });
    return await this.getTbProjectGrayWithOptions(request, headers, runtime);
  }

  async getTbProjectGrayWithOptions(request: GetTbProjectGrayRequest, headers: GetTbProjectGrayHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbProjectGrayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.label)) {
      body["label"] = request.label;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingCorpId)) {
      realHeaders["dingCorpId"] = Util.toJSONString(headers.dingCorpId);
    }

    if (!Util.isUnset(headers.dingIsvOrgId)) {
      realHeaders["dingIsvOrgId"] = Util.toJSONString(headers.dingIsvOrgId);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.dingSuiteKey)) {
      realHeaders["dingSuiteKey"] = Util.toJSONString(headers.dingSuiteKey);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetTbProjectGrayResponse>(await this.doROARequest("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/projects/gray`, "json", req, runtime), new GetTbProjectGrayResponse({}));
  }

  async getTbProjectSource(): Promise<GetTbProjectSourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectSourceHeaders({ });
    return await this.getTbProjectSourceWithOptions(headers, runtime);
  }

  async getTbProjectSourceWithOptions(headers: GetTbProjectSourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbProjectSourceResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingCorpId)) {
      realHeaders["dingCorpId"] = Util.toJSONString(headers.dingCorpId);
    }

    if (!Util.isUnset(headers.dingIsvOrgId)) {
      realHeaders["dingIsvOrgId"] = Util.toJSONString(headers.dingIsvOrgId);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.dingSuiteKey)) {
      realHeaders["dingSuiteKey"] = Util.toJSONString(headers.dingSuiteKey);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetTbProjectSourceResponse>(await this.doROARequest("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/projects/source`, "json", req, runtime), new GetTbProjectSourceResponse({}));
  }

  async getTbUserIdByStaffId(request: GetTbUserIdByStaffIdRequest): Promise<GetTbUserIdByStaffIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbUserIdByStaffIdHeaders({ });
    return await this.getTbUserIdByStaffIdWithOptions(request, headers, runtime);
  }

  async getTbUserIdByStaffIdWithOptions(request: GetTbUserIdByStaffIdRequest, headers: GetTbUserIdByStaffIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbUserIdByStaffIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.optUserId)) {
      query["optUserId"] = request.optUserId;
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
    return $tea.cast<GetTbUserIdByStaffIdResponse>(await this.doROARequest("GetTbUserIdByStaffId", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/teambition/users`, "json", req, runtime), new GetTbUserIdByStaffIdResponse({}));
  }

  async queryTaskOfProject(userId: string, projectId: string, request: QueryTaskOfProjectRequest): Promise<QueryTaskOfProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTaskOfProjectHeaders({ });
    return await this.queryTaskOfProjectWithOptions(userId, projectId, request, headers, runtime);
  }

  async queryTaskOfProjectWithOptions(userId: string, projectId: string, request: QueryTaskOfProjectRequest, headers: QueryTaskOfProjectHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTaskOfProjectResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    projectId = OpenApiUtil.getEncodeParam(projectId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.query)) {
      query["query"] = request.query;
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
    return $tea.cast<QueryTaskOfProjectResponse>(await this.doROARequest("QueryTaskOfProject", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/users/${userId}/projectIds/${projectId}/tasks`, "json", req, runtime), new QueryTaskOfProjectResponse({}));
  }

  async searchProjectTemplate(userId: string, request: SearchProjectTemplateRequest): Promise<SearchProjectTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchProjectTemplateHeaders({ });
    return await this.searchProjectTemplateWithOptions(userId, request, headers, runtime);
  }

  async searchProjectTemplateWithOptions(userId: string, request: SearchProjectTemplateRequest, headers: SearchProjectTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<SearchProjectTemplateResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
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
    return $tea.cast<SearchProjectTemplateResponse>(await this.doROARequest("SearchProjectTemplate", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/organizations/users/${userId}/templates`, "json", req, runtime), new SearchProjectTemplateResponse({}));
  }

  async searchTaskflowStatus(userId: string, projectId: string, request: SearchTaskflowStatusRequest): Promise<SearchTaskflowStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTaskflowStatusHeaders({ });
    return await this.searchTaskflowStatusWithOptions(userId, projectId, request, headers, runtime);
  }

  async searchTaskflowStatusWithOptions(userId: string, projectId: string, request: SearchTaskflowStatusRequest, headers: SearchTaskflowStatusHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTaskflowStatusResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    projectId = OpenApiUtil.getEncodeParam(projectId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.query)) {
      query["query"] = request.query;
    }

    if (!Util.isUnset(request.tfIds)) {
      query["tfIds"] = request.tfIds;
    }

    if (!Util.isUnset(request.tfsIds)) {
      query["tfsIds"] = request.tfsIds;
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
    return $tea.cast<SearchTaskflowStatusResponse>(await this.doROARequest("SearchTaskflowStatus", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/users/${userId}/projects/${projectId}/taskflowStatuses/search`, "json", req, runtime), new SearchTaskflowStatusResponse({}));
  }

  async updateCustomfieldValue(userId: string, taskId: string, request: UpdateCustomfieldValueRequest): Promise<UpdateCustomfieldValueResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCustomfieldValueHeaders({ });
    return await this.updateCustomfieldValueWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateCustomfieldValueWithOptions(userId: string, taskId: string, request: UpdateCustomfieldValueRequest, headers: UpdateCustomfieldValueHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCustomfieldValueResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customfieldId)) {
      body["customfieldId"] = request.customfieldId;
    }

    if (!Util.isUnset(request.customfieldName)) {
      body["customfieldName"] = request.customfieldName;
    }

    if (!Util.isUnset(request.value)) {
      body["value"] = request.value;
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
    return $tea.cast<UpdateCustomfieldValueResponse>(await this.doROARequest("UpdateCustomfieldValue", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/users/${userId}/tasks/${taskId}/customFields`, "json", req, runtime), new UpdateCustomfieldValueResponse({}));
  }

  async updateOrganizationTaskContent(taskId: string, userId: string, request: UpdateOrganizationTaskContentRequest): Promise<UpdateOrganizationTaskContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskContentHeaders({ });
    return await this.updateOrganizationTaskContentWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskContentWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskContentRequest, headers: UpdateOrganizationTaskContentHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskContentResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
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
    return $tea.cast<UpdateOrganizationTaskContentResponse>(await this.doROARequest("UpdateOrganizationTaskContent", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/contents`, "json", req, runtime), new UpdateOrganizationTaskContentResponse({}));
  }

  async updateOrganizationTaskDueDate(taskId: string, userId: string, request: UpdateOrganizationTaskDueDateRequest): Promise<UpdateOrganizationTaskDueDateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskDueDateHeaders({ });
    return await this.updateOrganizationTaskDueDateWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskDueDateWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskDueDateRequest, headers: UpdateOrganizationTaskDueDateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskDueDateResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.dueDate)) {
      body["dueDate"] = request.dueDate;
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
    return $tea.cast<UpdateOrganizationTaskDueDateResponse>(await this.doROARequest("UpdateOrganizationTaskDueDate", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/dueDates`, "json", req, runtime), new UpdateOrganizationTaskDueDateResponse({}));
  }

  async updateOrganizationTaskExecutor(taskId: string, userId: string, request: UpdateOrganizationTaskExecutorRequest): Promise<UpdateOrganizationTaskExecutorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskExecutorHeaders({ });
    return await this.updateOrganizationTaskExecutorWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskExecutorWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskExecutorRequest, headers: UpdateOrganizationTaskExecutorHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskExecutorResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.executorId)) {
      body["executorId"] = request.executorId;
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
    return $tea.cast<UpdateOrganizationTaskExecutorResponse>(await this.doROARequest("UpdateOrganizationTaskExecutor", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/executors`, "json", req, runtime), new UpdateOrganizationTaskExecutorResponse({}));
  }

  async updateOrganizationTaskInvolveMembers(taskId: string, userId: string, request: UpdateOrganizationTaskInvolveMembersRequest): Promise<UpdateOrganizationTaskInvolveMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskInvolveMembersHeaders({ });
    return await this.updateOrganizationTaskInvolveMembersWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskInvolveMembersWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskInvolveMembersRequest, headers: UpdateOrganizationTaskInvolveMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskInvolveMembersResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addInvolvers)) {
      body["addInvolvers"] = request.addInvolvers;
    }

    if (!Util.isUnset(request.delInvolvers)) {
      body["delInvolvers"] = request.delInvolvers;
    }

    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.involveMembers)) {
      body["involveMembers"] = request.involveMembers;
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
    return $tea.cast<UpdateOrganizationTaskInvolveMembersResponse>(await this.doROARequest("UpdateOrganizationTaskInvolveMembers", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/involveMembers`, "json", req, runtime), new UpdateOrganizationTaskInvolveMembersResponse({}));
  }

  async updateOrganizationTaskNote(taskId: string, userId: string, request: UpdateOrganizationTaskNoteRequest): Promise<UpdateOrganizationTaskNoteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskNoteHeaders({ });
    return await this.updateOrganizationTaskNoteWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskNoteWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskNoteRequest, headers: UpdateOrganizationTaskNoteHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskNoteResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.note)) {
      body["note"] = request.note;
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
    return $tea.cast<UpdateOrganizationTaskNoteResponse>(await this.doROARequest("UpdateOrganizationTaskNote", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/notes`, "json", req, runtime), new UpdateOrganizationTaskNoteResponse({}));
  }

  async updateOrganizationTaskPriority(taskId: string, userId: string, request: UpdateOrganizationTaskPriorityRequest): Promise<UpdateOrganizationTaskPriorityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskPriorityHeaders({ });
    return await this.updateOrganizationTaskPriorityWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskPriorityWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskPriorityRequest, headers: UpdateOrganizationTaskPriorityHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskPriorityResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
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
    return $tea.cast<UpdateOrganizationTaskPriorityResponse>(await this.doROARequest("UpdateOrganizationTaskPriority", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/priorities`, "json", req, runtime), new UpdateOrganizationTaskPriorityResponse({}));
  }

  async updateOrganizationTaskStatus(taskId: string, userId: string, request: UpdateOrganizationTaskStatusRequest): Promise<UpdateOrganizationTaskStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskStatusHeaders({ });
    return await this.updateOrganizationTaskStatusWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskStatusWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskStatusRequest, headers: UpdateOrganizationTaskStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskStatusResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.disableActivity)) {
      body["disableActivity"] = request.disableActivity;
    }

    if (!Util.isUnset(request.disableNotification)) {
      body["disableNotification"] = request.disableNotification;
    }

    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
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
    return $tea.cast<UpdateOrganizationTaskStatusResponse>(await this.doROARequest("UpdateOrganizationTaskStatus", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/states`, "json", req, runtime), new UpdateOrganizationTaskStatusResponse({}));
  }

  async updateProjectGroup(userId: string, projectId: string, request: UpdateProjectGroupRequest): Promise<UpdateProjectGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateProjectGroupHeaders({ });
    return await this.updateProjectGroupWithOptions(userId, projectId, request, headers, runtime);
  }

  async updateProjectGroupWithOptions(userId: string, projectId: string, request: UpdateProjectGroupRequest, headers: UpdateProjectGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateProjectGroupResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    projectId = OpenApiUtil.getEncodeParam(projectId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addProjectGroupIds)) {
      body["addProjectGroupIds"] = request.addProjectGroupIds;
    }

    if (!Util.isUnset(request.delProjectGroupIds)) {
      body["delProjectGroupIds"] = request.delProjectGroupIds;
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
    return $tea.cast<UpdateProjectGroupResponse>(await this.doROARequest("UpdateProjectGroup", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/users/${userId}/projects/${projectId}/groups`, "json", req, runtime), new UpdateProjectGroupResponse({}));
  }

  async updateTaskTaskflowstatus(userId: string, taskId: string, request: UpdateTaskTaskflowstatusRequest): Promise<UpdateTaskTaskflowstatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskTaskflowstatusHeaders({ });
    return await this.updateTaskTaskflowstatusWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskTaskflowstatusWithOptions(userId: string, taskId: string, request: UpdateTaskTaskflowstatusRequest, headers: UpdateTaskTaskflowstatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskTaskflowstatusResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    taskId = OpenApiUtil.getEncodeParam(taskId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskflowStatusId)) {
      body["taskflowStatusId"] = request.taskflowStatusId;
    }

    if (!Util.isUnset(request.tfsUpdateNote)) {
      body["tfsUpdateNote"] = request.tfsUpdateNote;
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
    return $tea.cast<UpdateTaskTaskflowstatusResponse>(await this.doROARequest("UpdateTaskTaskflowstatus", "project_1.0", "HTTP", "PUT", "AK", `/v1.0/project/users/${userId}/tasks/${taskId}/taskflowStatuses`, "json", req, runtime), new UpdateTaskTaskflowstatusResponse({}));
  }

}
