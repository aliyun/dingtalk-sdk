// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
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
  statusCode: number;
  body: AddProjectMemberResponseBody;
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
      body: AddProjectMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveProjectResponseBody extends $tea.Model {
  result?: ArchiveProjectResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ArchiveProjectResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ArchiveProjectResponseBody;
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
      body: ArchiveProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveTaskResponseBody extends $tea.Model {
  result?: ArchiveTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ArchiveTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ArchiveTaskResponseBody;
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
      body: ArchiveTaskResponseBody,
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
  statusCode: number;
  body: CreateOrganizationTaskResponseBody;
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
  statusCode: number;
  body: CreatePlanTimeResponseBody;
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
      body: CreatePlanTimeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectRequest extends $tea.Model {
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

export class CreateProjectResponseBody extends $tea.Model {
  result?: CreateProjectResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateProjectResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateProjectResponseBody;
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
      body: CreateProjectResponseBody,
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
  statusCode: number;
  body: CreateProjectByTemplateResponseBody;
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
      body: CreateProjectByTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectCustomfieldStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectCustomfieldStatusRequest extends $tea.Model {
  customFieldId?: string;
  customFieldInstanceId?: string;
  customFieldName?: string;
  value?: CreateProjectCustomfieldStatusRequestValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      customFieldInstanceId: 'customFieldInstanceId',
      customFieldName: 'customFieldName',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      customFieldInstanceId: 'string',
      customFieldName: 'string',
      value: { 'type': 'array', 'itemType': CreateProjectCustomfieldStatusRequestValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectCustomfieldStatusResponseBody extends $tea.Model {
  result?: CreateProjectCustomfieldStatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateProjectCustomfieldStatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectCustomfieldStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateProjectCustomfieldStatusResponseBody;
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
      body: CreateProjectCustomfieldStatusResponseBody,
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
  statusCode: number;
  body: CreateTaskResponseBody;
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
  statusCode: number;
  body: CreateTaskObjectLinkResponseBody;
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
  description?: string;
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
      description: 'description',
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
      description: 'string',
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
  statusCode: number;
  body: CreateWorkTimeResponseBody;
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
      body: CreateWorkTimeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeApproveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeApproveRequest extends $tea.Model {
  workTimeIds?: string[];
  static names(): { [key: string]: string } {
    return {
      workTimeIds: 'workTimeIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workTimeIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeApproveResponseBody extends $tea.Model {
  message?: string;
  requestId?: string;
  result?: CreateWorkTimeApproveResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      requestId: 'string',
      result: CreateWorkTimeApproveResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkTimeApproveResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateWorkTimeApproveResponseBody;
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
      body: CreateWorkTimeApproveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProjectMemberHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProjectMemberRequest extends $tea.Model {
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

export class DeleteProjectMemberResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProjectMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteProjectMemberResponseBody;
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
      body: DeleteProjectMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTaskResponseBody extends $tea.Model {
  result?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteTaskResponseBody;
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
      body: DeleteTaskResponseBody,
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
  statusCode: number;
  body: GetDeptsByOrgIdResponseBody;
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
  statusCode: number;
  body: GetEmpsByOrgIdResponseBody;
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
  statusCode: number;
  body: GetOrganizatioTaskByIdsResponseBody;
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
  statusCode: number;
  body: GetOrganizationPriorityListResponseBody;
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
  statusCode: number;
  body: GetOrganizationTaskResponseBody;
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
  statusCode: number;
  body: GetProjectGroupResponseBody;
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
      body: GetProjectGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectMemebersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectMemebersRequest extends $tea.Model {
  maxResults?: number;
  projectRoleId?: string;
  skip?: number;
  userIds?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      projectRoleId: 'projectRoleId',
      skip: 'skip',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      projectRoleId: 'string',
      skip: 'number',
      userIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectMemebersResponseBody extends $tea.Model {
  result?: GetProjectMemebersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetProjectMemebersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectMemebersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetProjectMemebersResponseBody;
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
      body: GetProjectMemebersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectStatusListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectStatusListResponseBody extends $tea.Model {
  result?: GetProjectStatusListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetProjectStatusListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectStatusListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetProjectStatusListResponseBody;
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
      body: GetProjectStatusListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsRequest extends $tea.Model {
  parentTaskId?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      parentTaskId: 'parentTaskId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentTaskId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsResponseBody extends $tea.Model {
  result?: GetTaskByIdsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetTaskByIdsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTaskByIdsResponseBody;
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
      body: GetTaskByIdsResponseBody,
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
  statusCode: number;
  body: GetTbOrgIdByDingOrgIdResponseBody;
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
  statusCode: number;
  body: GetTbProjectGrayResponseBody;
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
  statusCode: number;
  body: GetTbProjectSourceResponseBody;
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
  statusCode: number;
  body: GetTbUserIdByStaffIdResponseBody;
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
      body: GetTbUserIdByStaffIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserJoinedProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserJoinedProjectRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserJoinedProjectResponseBody extends $tea.Model {
  nextToken?: string;
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserJoinedProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserJoinedProjectResponseBody;
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
      body: GetUserJoinedProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectRequest extends $tea.Model {
  maxResults?: number;
  name?: string;
  nextToken?: string;
  projectIds?: string;
  sourceId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      name: 'name',
      nextToken: 'nextToken',
      projectIds: 'projectIds',
      sourceId: 'sourceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      name: 'string',
      nextToken: 'string',
      projectIds: 'string',
      sourceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectResponseBody extends $tea.Model {
  nextToken?: string;
  requestId?: string;
  result?: QueryProjectResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      requestId: 'string',
      result: { 'type': 'array', 'itemType': QueryProjectResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryProjectResponseBody;
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
      body: QueryProjectResponseBody,
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
  statusCode: number;
  body: QueryTaskOfProjectResponseBody;
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
      body: QueryTaskOfProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeachTaskStageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeachTaskStageRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  query?: string;
  taskListId?: string;
  taskStageIds?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      query: 'query',
      taskListId: 'taskListId',
      taskStageIds: 'taskStageIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      query: 'string',
      taskListId: 'string',
      taskStageIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeachTaskStageResponseBody extends $tea.Model {
  nextToken?: string;
  result?: SeachTaskStageResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      result: { 'type': 'array', 'itemType': SeachTaskStageResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeachTaskStageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SeachTaskStageResponseBody;
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
      body: SeachTaskStageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchAllTasksByTqlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchAllTasksByTqlRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  tql?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      tql: 'tql',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      tql: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchAllTasksByTqlResponseBody extends $tea.Model {
  nextToken?: string;
  requestId?: string;
  result?: string[];
  totalSize?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      requestId: 'requestId',
      result: 'result',
      totalSize: 'totalSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      requestId: 'string',
      result: { 'type': 'array', 'itemType': 'string' },
      totalSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchAllTasksByTqlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchAllTasksByTqlResponseBody;
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
      body: SearchAllTasksByTqlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldRequest extends $tea.Model {
  customFieldIds?: string;
  instanceIds?: string;
  maxResults?: number;
  nextToken?: string;
  projectIds?: string;
  query?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldIds: 'customFieldIds',
      instanceIds: 'instanceIds',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      projectIds: 'projectIds',
      query: 'query',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldIds: 'string',
      instanceIds: 'string',
      maxResults: 'number',
      nextToken: 'string',
      projectIds: 'string',
      query: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldResponseBody extends $tea.Model {
  nextToken?: string;
  result?: SearchOranizationCustomfieldResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      result: { 'type': 'array', 'itemType': SearchOranizationCustomfieldResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchOranizationCustomfieldResponseBody;
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
      body: SearchOranizationCustomfieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldRequest extends $tea.Model {
  customFieldIds?: string;
  instanceIds?: string;
  maxResults?: number;
  nextToken?: string;
  query?: string;
  scenarioFieldConfigId?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldIds: 'customFieldIds',
      instanceIds: 'instanceIds',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      query: 'query',
      scenarioFieldConfigId: 'scenarioFieldConfigId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldIds: 'string',
      instanceIds: 'string',
      maxResults: 'number',
      nextToken: 'string',
      query: 'string',
      scenarioFieldConfigId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldResponseBody extends $tea.Model {
  nextToken?: string;
  result?: SearchProjectCustomfieldResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      result: { 'type': 'array', 'itemType': SearchProjectCustomfieldResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchProjectCustomfieldResponseBody;
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
      body: SearchProjectCustomfieldResponseBody,
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
  statusCode: number;
  body: SearchProjectTemplateResponseBody;
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
      body: SearchProjectTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskFlowHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskFlowRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  query?: string;
  taskflowIds?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      query: 'query',
      taskflowIds: 'taskflowIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      query: 'string',
      taskflowIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskFlowResponseBody extends $tea.Model {
  result?: SearchTaskFlowResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': SearchTaskFlowResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskFlowResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchTaskFlowResponseBody;
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
      body: SearchTaskFlowResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskListRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  query?: string;
  taskListIds?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      query: 'query',
      taskListIds: 'taskListIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      query: 'string',
      taskListIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskListResponseBody extends $tea.Model {
  nextToken?: string;
  result?: SearchTaskListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      result: { 'type': 'array', 'itemType': SearchTaskListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchTaskListResponseBody;
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
      body: SearchTaskListResponseBody,
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
  statusCode: number;
  body: SearchTaskflowStatusResponseBody;
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
      body: SearchTaskflowStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserTaskRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  roleTypes?: string;
  tql?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      roleTypes: 'roleTypes',
      tql: 'tql',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      roleTypes: 'string',
      tql: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserTaskResponseBody extends $tea.Model {
  nextToken?: string;
  requestId?: string;
  result?: SearchUserTaskResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      requestId: 'string',
      result: { 'type': 'array', 'itemType': SearchUserTaskResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchUserTaskResponseBody;
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
      body: SearchUserTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SuspendProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SuspendProjectResponseBody extends $tea.Model {
  result?: SuspendProjectResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SuspendProjectResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SuspendProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SuspendProjectResponseBody;
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
      body: SuspendProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnSuspendProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnSuspendProjectResponseBody extends $tea.Model {
  result?: UnSuspendProjectResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UnSuspendProjectResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnSuspendProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnSuspendProjectResponseBody;
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
      body: UnSuspendProjectResponseBody,
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
  customFieldId?: string;
  customFieldName?: string;
  value?: UpdateCustomfieldValueRequestValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      customFieldName: 'customFieldName',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      customFieldName: 'string',
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
  statusCode: number;
  body: UpdateCustomfieldValueResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskContentResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskDueDateResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskExecutorResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskInvolveMembersResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskNoteResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskPriorityResponseBody;
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
  statusCode: number;
  body: UpdateOrganizationTaskStatusResponseBody;
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
  statusCode: number;
  body: UpdateProjectGroupResponseBody;
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
      body: UpdateProjectGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskContentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskContentRequest extends $tea.Model {
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskContentResponseBody extends $tea.Model {
  result?: UpdateTaskContentResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskContentResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskContentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskContentResponseBody;
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
      body: UpdateTaskContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskDueDateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskDueDateRequest extends $tea.Model {
  dueDate?: string;
  static names(): { [key: string]: string } {
    return {
      dueDate: 'dueDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dueDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskDueDateResponseBody extends $tea.Model {
  result?: UpdateTaskDueDateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskDueDateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskDueDateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskDueDateResponseBody;
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
      body: UpdateTaskDueDateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskExecutorHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskExecutorRequest extends $tea.Model {
  executorId?: string;
  static names(): { [key: string]: string } {
    return {
      executorId: 'executorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskExecutorResponseBody extends $tea.Model {
  result?: UpdateTaskExecutorResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskExecutorResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskExecutorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskExecutorResponseBody;
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
      body: UpdateTaskExecutorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskInvolvemembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskInvolvemembersRequest extends $tea.Model {
  addInvolvers?: string[];
  delInvolvers?: string[];
  involveMembers?: string[];
  static names(): { [key: string]: string } {
    return {
      addInvolvers: 'addInvolvers',
      delInvolvers: 'delInvolvers',
      involveMembers: 'involveMembers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addInvolvers: { 'type': 'array', 'itemType': 'string' },
      delInvolvers: { 'type': 'array', 'itemType': 'string' },
      involveMembers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskInvolvemembersResponseBody extends $tea.Model {
  result?: UpdateTaskInvolvemembersResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskInvolvemembersResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskInvolvemembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskInvolvemembersResponseBody;
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
      body: UpdateTaskInvolvemembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskNoteHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskNoteRequest extends $tea.Model {
  note?: string;
  static names(): { [key: string]: string } {
    return {
      note: 'note',
    };
  }

  static types(): { [key: string]: any } {
    return {
      note: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskNoteResponseBody extends $tea.Model {
  result?: UpdateTaskNoteResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskNoteResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskNoteResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskNoteResponseBody;
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
      body: UpdateTaskNoteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskPriorityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskPriorityRequest extends $tea.Model {
  priority?: number;
  static names(): { [key: string]: string } {
    return {
      priority: 'priority',
    };
  }

  static types(): { [key: string]: any } {
    return {
      priority: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskPriorityResponseBody extends $tea.Model {
  result?: UpdateTaskPriorityResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskPriorityResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskPriorityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskPriorityResponseBody;
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
      body: UpdateTaskPriorityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStageRequest extends $tea.Model {
  taskStageId?: string;
  static names(): { [key: string]: string } {
    return {
      taskStageId: 'taskStageId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskStageId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStageResponseBody extends $tea.Model {
  result?: UpdateTaskStageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskStageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskStageResponseBody;
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
      body: UpdateTaskStageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStartdateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStartdateRequest extends $tea.Model {
  startDate?: string;
  static names(): { [key: string]: string } {
    return {
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStartdateResponseBody extends $tea.Model {
  result?: UpdateTaskStartdateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateTaskStartdateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStartdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTaskStartdateResponseBody;
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
      body: UpdateTaskStartdateResponseBody,
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
  taskflowStatusUpdateNote?: string;
  static names(): { [key: string]: string } {
    return {
      taskflowStatusId: 'taskflowStatusId',
      taskflowStatusUpdateNote: 'taskflowStatusUpdateNote',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskflowStatusId: 'string',
      taskflowStatusUpdateNote: 'string',
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
  statusCode: number;
  body: UpdateTaskTaskflowstatusResponseBody;
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
      body: UpdateTaskTaskflowstatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkTimeApproveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkTimeApproveRequest extends $tea.Model {
  finishTime?: string;
  instanceId?: string;
  status?: string;
  submitTime?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      finishTime: 'finishTime',
      instanceId: 'instanceId',
      status: 'status',
      submitTime: 'submitTime',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      finishTime: 'string',
      instanceId: 'string',
      status: 'string',
      submitTime: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkTimeApproveResponseBody extends $tea.Model {
  message?: string;
  requestId?: string;
  result?: UpdateWorkTimeApproveResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      requestId: 'string',
      result: UpdateWorkTimeApproveResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkTimeApproveResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateWorkTimeApproveResponseBody;
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
      body: UpdateWorkTimeApproveResponseBody,
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

export class ArchiveProjectResponseBodyResult extends $tea.Model {
  isArchived?: boolean;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      isArchived: 'isArchived',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isArchived: 'boolean',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ArchiveTaskResponseBodyResult extends $tea.Model {
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

export class CreateProjectResponseBodyResultCustomFieldsValue extends $tea.Model {
  customFieldValueId?: string;
  metaString?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldValueId: 'customFieldValueId',
      metaString: 'metaString',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldValueId: 'string',
      metaString: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectResponseBodyResultCustomFields extends $tea.Model {
  customFieldId?: string;
  type?: string;
  value?: CreateProjectResponseBodyResultCustomFieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      type: 'string',
      value: { 'type': 'array', 'itemType': CreateProjectResponseBodyResultCustomFieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectResponseBodyResult extends $tea.Model {
  created?: string;
  creatorId?: string;
  customFields?: CreateProjectResponseBodyResultCustomFields[];
  defaultCollectionId?: string;
  isArchived?: boolean;
  isSuspended?: boolean;
  isTemplate?: boolean;
  logo?: string;
  name?: string;
  normalType?: string;
  projectId?: string;
  rootCollectionId?: string;
  sourceId?: string;
  uniqueIdPrefix?: string;
  updated?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creatorId: 'creatorId',
      customFields: 'customFields',
      defaultCollectionId: 'defaultCollectionId',
      isArchived: 'isArchived',
      isSuspended: 'isSuspended',
      isTemplate: 'isTemplate',
      logo: 'logo',
      name: 'name',
      normalType: 'normalType',
      projectId: 'projectId',
      rootCollectionId: 'rootCollectionId',
      sourceId: 'sourceId',
      uniqueIdPrefix: 'uniqueIdPrefix',
      updated: 'updated',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      creatorId: 'string',
      customFields: { 'type': 'array', 'itemType': CreateProjectResponseBodyResultCustomFields },
      defaultCollectionId: 'string',
      isArchived: 'boolean',
      isSuspended: 'boolean',
      isTemplate: 'boolean',
      logo: 'string',
      name: 'string',
      normalType: 'string',
      projectId: 'string',
      rootCollectionId: 'string',
      sourceId: 'string',
      uniqueIdPrefix: 'string',
      updated: 'string',
      visibility: 'string',
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

export class CreateProjectCustomfieldStatusRequestValue extends $tea.Model {
  customFieldValueId?: string;
  metaString?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldValueId: 'customFieldValueId',
      metaString: 'metaString',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldValueId: 'string',
      metaString: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectCustomfieldStatusResponseBodyResultValue extends $tea.Model {
  customFieldValueId?: string;
  metaString?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldValueId: 'customFieldValueId',
      metaString: 'metaString',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldValueId: 'string',
      metaString: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProjectCustomfieldStatusResponseBodyResult extends $tea.Model {
  advancedCustomFieldObjectType?: string;
  customFieldId?: string;
  name?: string;
  originalId?: string;
  type?: string;
  value?: CreateProjectCustomfieldStatusResponseBodyResultValue[];
  static names(): { [key: string]: string } {
    return {
      advancedCustomFieldObjectType: 'advancedCustomFieldObjectType',
      customFieldId: 'customFieldId',
      name: 'name',
      originalId: 'originalId',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedCustomFieldObjectType: 'string',
      customFieldId: 'string',
      name: 'string',
      originalId: 'string',
      type: 'string',
      value: { 'type': 'array', 'itemType': CreateProjectCustomfieldStatusResponseBodyResultValue },
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

export class CreateWorkTimeApproveResponseBodyResult extends $tea.Model {
  approveOpenId?: string;
  createdAt?: string;
  creatorId?: string;
  organizationId?: string;
  status?: string;
  taskId?: string;
  time?: number;
  updatedAt?: string;
  userId?: string;
  workTimeIds?: string[];
  static names(): { [key: string]: string } {
    return {
      approveOpenId: 'approveOpenId',
      createdAt: 'createdAt',
      creatorId: 'creatorId',
      organizationId: 'organizationId',
      status: 'status',
      taskId: 'taskId',
      time: 'time',
      updatedAt: 'updatedAt',
      userId: 'userId',
      workTimeIds: 'workTimeIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveOpenId: 'string',
      createdAt: 'string',
      creatorId: 'string',
      organizationId: 'string',
      status: 'string',
      taskId: 'string',
      time: 'number',
      updatedAt: 'string',
      userId: 'string',
      workTimeIds: { 'type': 'array', 'itemType': 'string' },
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

export class GetProjectMemebersResponseBodyResult extends $tea.Model {
  memberId?: string;
  role?: number;
  roleIds?: string[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      role: 'role',
      roleIds: 'roleIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      role: 'number',
      roleIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectStatusListResponseBodyResult extends $tea.Model {
  content?: string;
  created?: string;
  creatorId?: string;
  degree?: string;
  name?: string;
  projectId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      degree: 'degree',
      name: 'name',
      projectId: 'projectId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      created: 'string',
      creatorId: 'string',
      degree: 'string',
      name: 'string',
      projectId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsResponseBodyResultCustomFieldsValue extends $tea.Model {
  customFieldValueId?: string;
  metaString?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldValueId: 'customFieldValueId',
      metaString: 'metaString',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldValueId: 'string',
      metaString: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsResponseBodyResultCustomFields extends $tea.Model {
  customFieldId?: string;
  type?: string;
  value?: GetTaskByIdsResponseBodyResultCustomFieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      type: 'string',
      value: { 'type': 'array', 'itemType': GetTaskByIdsResponseBodyResultCustomFieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskByIdsResponseBodyResult extends $tea.Model {
  accomplishTime?: string;
  ancestorIds?: string[];
  content?: string;
  created?: string;
  creatorId?: string;
  customFields?: GetTaskByIdsResponseBodyResultCustomFields[];
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  isArchived?: boolean;
  isDone?: boolean;
  note?: string;
  parentTaskId?: string;
  priority?: number;
  projectId?: string;
  recurrence?: string[];
  scenarioFieldConfigId?: string;
  sprintId?: string;
  startDate?: string;
  storyPoint?: string;
  tagIds?: string[];
  taskId?: string;
  taskListId?: string;
  taskStageId?: string;
  taskflowStatusId?: string;
  uniqueId?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      accomplishTime: 'accomplishTime',
      ancestorIds: 'ancestorIds',
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      customFields: 'customFields',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      isArchived: 'isArchived',
      isDone: 'isDone',
      note: 'note',
      parentTaskId: 'parentTaskId',
      priority: 'priority',
      projectId: 'projectId',
      recurrence: 'recurrence',
      scenarioFieldConfigId: 'scenarioFieldConfigId',
      sprintId: 'sprintId',
      startDate: 'startDate',
      storyPoint: 'storyPoint',
      tagIds: 'tagIds',
      taskId: 'taskId',
      taskListId: 'taskListId',
      taskStageId: 'taskStageId',
      taskflowStatusId: 'taskflowStatusId',
      uniqueId: 'uniqueId',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accomplishTime: 'string',
      ancestorIds: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      created: 'string',
      creatorId: 'string',
      customFields: { 'type': 'array', 'itemType': GetTaskByIdsResponseBodyResultCustomFields },
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      isArchived: 'boolean',
      isDone: 'boolean',
      note: 'string',
      parentTaskId: 'string',
      priority: 'number',
      projectId: 'string',
      recurrence: { 'type': 'array', 'itemType': 'string' },
      scenarioFieldConfigId: 'string',
      sprintId: 'string',
      startDate: 'string',
      storyPoint: 'string',
      tagIds: { 'type': 'array', 'itemType': 'string' },
      taskId: 'string',
      taskListId: 'string',
      taskStageId: 'string',
      taskflowStatusId: 'string',
      uniqueId: 'string',
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

export class QueryProjectResponseBodyResultCustomFieldsValue extends $tea.Model {
  customFieldValueId?: string;
  metaString?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldValueId: 'customFieldValueId',
      metaString: 'metaString',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldValueId: 'string',
      metaString: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectResponseBodyResultCustomFields extends $tea.Model {
  customFieldId?: string;
  type?: string;
  value?: QueryProjectResponseBodyResultCustomFieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      type: 'string',
      value: { 'type': 'array', 'itemType': QueryProjectResponseBodyResultCustomFieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectResponseBodyResult extends $tea.Model {
  created?: string;
  creatorId?: string;
  customFields?: QueryProjectResponseBodyResultCustomFields[];
  description?: string;
  endDate?: string;
  isArchived?: boolean;
  isSuspended?: boolean;
  isTemplate?: boolean;
  logo?: string;
  name?: string;
  organizationId?: string;
  projectId?: string;
  startDate?: string;
  uniqueIdPrefix?: string;
  updated?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creatorId: 'creatorId',
      customFields: 'customFields',
      description: 'description',
      endDate: 'endDate',
      isArchived: 'isArchived',
      isSuspended: 'isSuspended',
      isTemplate: 'isTemplate',
      logo: 'logo',
      name: 'name',
      organizationId: 'organizationId',
      projectId: 'projectId',
      startDate: 'startDate',
      uniqueIdPrefix: 'uniqueIdPrefix',
      updated: 'updated',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      creatorId: 'string',
      customFields: { 'type': 'array', 'itemType': QueryProjectResponseBodyResultCustomFields },
      description: 'string',
      endDate: 'string',
      isArchived: 'boolean',
      isSuspended: 'boolean',
      isTemplate: 'boolean',
      logo: 'string',
      name: 'string',
      organizationId: 'string',
      projectId: 'string',
      startDate: 'string',
      uniqueIdPrefix: 'string',
      updated: 'string',
      visibility: 'string',
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

export class SeachTaskStageResponseBodyResult extends $tea.Model {
  created?: string;
  creatorId?: string;
  description?: string;
  name?: string;
  projectId?: string;
  taskListId?: string;
  taskStageId?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creatorId: 'creatorId',
      description: 'description',
      name: 'name',
      projectId: 'projectId',
      taskListId: 'taskListId',
      taskStageId: 'taskStageId',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      creatorId: 'string',
      description: 'string',
      name: 'string',
      projectId: 'string',
      taskListId: 'string',
      taskStageId: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField extends $tea.Model {
  advancedCustomFieldId?: string;
  name?: string;
  objectType?: string;
  static names(): { [key: string]: string } {
    return {
      advancedCustomFieldId: 'advancedCustomFieldId',
      name: 'name',
      objectType: 'objectType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedCustomFieldId: 'string',
      name: 'string',
      objectType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldResponseBodyResultChoices extends $tea.Model {
  choiceId?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      choiceId: 'choiceId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      choiceId: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchOranizationCustomfieldResponseBodyResult extends $tea.Model {
  advancedCustomField?: SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField;
  choices?: SearchOranizationCustomfieldResponseBodyResultChoices[];
  created?: string;
  creatorId?: string;
  customFieldsId?: string;
  name?: string;
  payload?: { [key: string]: any };
  type?: string;
  static names(): { [key: string]: string } {
    return {
      advancedCustomField: 'advancedCustomField',
      choices: 'choices',
      created: 'created',
      creatorId: 'creatorId',
      customFieldsId: 'customFieldsId',
      name: 'name',
      payload: 'payload',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedCustomField: SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField,
      choices: { 'type': 'array', 'itemType': SearchOranizationCustomfieldResponseBodyResultChoices },
      created: 'string',
      creatorId: 'string',
      customFieldsId: 'string',
      name: 'string',
      payload: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldResponseBodyResultAdvancedCustomField extends $tea.Model {
  advancedCustomFieldId?: string;
  name?: string;
  objectType?: string;
  static names(): { [key: string]: string } {
    return {
      advancedCustomFieldId: 'advancedCustomFieldId',
      name: 'name',
      objectType: 'objectType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedCustomFieldId: 'string',
      name: 'string',
      objectType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldResponseBodyResultChoices extends $tea.Model {
  choiceId?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      choiceId: 'choiceId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      choiceId: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchProjectCustomfieldResponseBodyResult extends $tea.Model {
  advancedCustomField?: SearchProjectCustomfieldResponseBodyResultAdvancedCustomField;
  boundToObjectId?: string;
  choices?: SearchProjectCustomfieldResponseBodyResultChoices[];
  created?: string;
  creatorId?: string;
  customFieldId?: string;
  name?: string;
  originalId?: string;
  payload?: { [key: string]: any };
  type?: string;
  static names(): { [key: string]: string } {
    return {
      advancedCustomField: 'advancedCustomField',
      boundToObjectId: 'boundToObjectId',
      choices: 'choices',
      created: 'created',
      creatorId: 'creatorId',
      customFieldId: 'customFieldId',
      name: 'name',
      originalId: 'originalId',
      payload: 'payload',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedCustomField: SearchProjectCustomfieldResponseBodyResultAdvancedCustomField,
      boundToObjectId: 'string',
      choices: { 'type': 'array', 'itemType': SearchProjectCustomfieldResponseBodyResultChoices },
      created: 'string',
      creatorId: 'string',
      customFieldId: 'string',
      name: 'string',
      originalId: 'string',
      payload: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
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

export class SearchTaskFlowResponseBodyResult extends $tea.Model {
  boundToObjectId?: string;
  boundToObjectType?: string;
  created?: string;
  creatorId?: string;
  isDeleted?: boolean;
  name?: string;
  taskflowId?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      boundToObjectId: 'boundToObjectId',
      boundToObjectType: 'boundToObjectType',
      created: 'created',
      creatorId: 'creatorId',
      isDeleted: 'isDeleted',
      name: 'name',
      taskflowId: 'taskflowId',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      boundToObjectId: 'string',
      boundToObjectType: 'string',
      created: 'string',
      creatorId: 'string',
      isDeleted: 'boolean',
      name: 'string',
      taskflowId: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTaskListResponseBodyResult extends $tea.Model {
  created?: string;
  creatorId?: string;
  description?: string;
  projectId?: string;
  taskListId?: string;
  title?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creatorId: 'creatorId',
      description: 'description',
      projectId: 'projectId',
      taskListId: 'taskListId',
      title: 'title',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'string',
      creatorId: 'string',
      description: 'string',
      projectId: 'string',
      taskListId: 'string',
      title: 'string',
      updated: 'string',
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

export class SearchUserTaskResponseBodyResultCustomFieldsValue extends $tea.Model {
  customFieldValueId?: string;
  metaString?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      customFieldValueId: 'customFieldValueId',
      metaString: 'metaString',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldValueId: 'string',
      metaString: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserTaskResponseBodyResultCustomFields extends $tea.Model {
  customFieldId?: string;
  type?: string;
  value?: SearchUserTaskResponseBodyResultCustomFieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      type: 'string',
      value: { 'type': 'array', 'itemType': SearchUserTaskResponseBodyResultCustomFieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserTaskResponseBodyResult extends $tea.Model {
  accomplishTime?: string;
  ancestorIds?: string[];
  content?: string;
  created?: string;
  creatorId?: string;
  customFields?: SearchUserTaskResponseBodyResultCustomFields[];
  dueDate?: string;
  executorId?: string;
  involveMembers?: string[];
  isArchived?: boolean;
  isDone?: boolean;
  note?: string;
  parentTaskId?: string;
  priority?: number;
  projectId?: string;
  recurrence?: string[];
  scenarioFieldConfigId?: string;
  sprintId?: string;
  startDate?: string;
  storyPoint?: string;
  tagIds?: string[];
  taskId?: string;
  taskListId?: string;
  taskStageId?: string;
  taskflowStatusId?: string;
  uniqueId?: string;
  updated?: string;
  visible?: string;
  static names(): { [key: string]: string } {
    return {
      accomplishTime: 'accomplishTime',
      ancestorIds: 'ancestorIds',
      content: 'content',
      created: 'created',
      creatorId: 'creatorId',
      customFields: 'customFields',
      dueDate: 'dueDate',
      executorId: 'executorId',
      involveMembers: 'involveMembers',
      isArchived: 'isArchived',
      isDone: 'isDone',
      note: 'note',
      parentTaskId: 'parentTaskId',
      priority: 'priority',
      projectId: 'projectId',
      recurrence: 'recurrence',
      scenarioFieldConfigId: 'scenarioFieldConfigId',
      sprintId: 'sprintId',
      startDate: 'startDate',
      storyPoint: 'storyPoint',
      tagIds: 'tagIds',
      taskId: 'taskId',
      taskListId: 'taskListId',
      taskStageId: 'taskStageId',
      taskflowStatusId: 'taskflowStatusId',
      uniqueId: 'uniqueId',
      updated: 'updated',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accomplishTime: 'string',
      ancestorIds: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      created: 'string',
      creatorId: 'string',
      customFields: { 'type': 'array', 'itemType': SearchUserTaskResponseBodyResultCustomFields },
      dueDate: 'string',
      executorId: 'string',
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      isArchived: 'boolean',
      isDone: 'boolean',
      note: 'string',
      parentTaskId: 'string',
      priority: 'number',
      projectId: 'string',
      recurrence: { 'type': 'array', 'itemType': 'string' },
      scenarioFieldConfigId: 'string',
      sprintId: 'string',
      startDate: 'string',
      storyPoint: 'string',
      tagIds: { 'type': 'array', 'itemType': 'string' },
      taskId: 'string',
      taskListId: 'string',
      taskStageId: 'string',
      taskflowStatusId: 'string',
      uniqueId: 'string',
      updated: 'string',
      visible: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SuspendProjectResponseBodyResult extends $tea.Model {
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

export class UnSuspendProjectResponseBodyResult extends $tea.Model {
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

export class UpdateCustomfieldValueResponseBodyResultCustomFieldsValue extends $tea.Model {
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

export class UpdateCustomfieldValueResponseBodyResultCustomFields extends $tea.Model {
  customFieldId?: string;
  value?: UpdateCustomfieldValueResponseBodyResultCustomFieldsValue[];
  static names(): { [key: string]: string } {
    return {
      customFieldId: 'customFieldId',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFieldId: 'string',
      value: { 'type': 'array', 'itemType': UpdateCustomfieldValueResponseBodyResultCustomFieldsValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCustomfieldValueResponseBodyResult extends $tea.Model {
  customFields?: UpdateCustomfieldValueResponseBodyResultCustomFields[];
  static names(): { [key: string]: string } {
    return {
      customFields: 'customFields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFields: { 'type': 'array', 'itemType': UpdateCustomfieldValueResponseBodyResultCustomFields },
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

export class UpdateTaskContentResponseBodyResult extends $tea.Model {
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

export class UpdateTaskDueDateResponseBodyResult extends $tea.Model {
  dueDate?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      dueDate: 'dueDate',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dueDate: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskExecutorResponseBodyResult extends $tea.Model {
  executorId?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      executorId: 'executorId',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executorId: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskInvolvemembersResponseBodyResult extends $tea.Model {
  involveMembers?: string[];
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      involveMembers: 'involveMembers',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      involveMembers: { 'type': 'array', 'itemType': 'string' },
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskNoteResponseBodyResult extends $tea.Model {
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

export class UpdateTaskPriorityResponseBodyResult extends $tea.Model {
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

export class UpdateTaskStageResponseBodyResult extends $tea.Model {
  accomplishTime?: string;
  isDone?: boolean;
  projectId?: string;
  taskId?: string;
  taskListId?: string;
  taskStageId?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      accomplishTime: 'accomplishTime',
      isDone: 'isDone',
      projectId: 'projectId',
      taskId: 'taskId',
      taskListId: 'taskListId',
      taskStageId: 'taskStageId',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accomplishTime: 'string',
      isDone: 'boolean',
      projectId: 'string',
      taskId: 'string',
      taskListId: 'string',
      taskStageId: 'string',
      updated: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTaskStartdateResponseBodyResult extends $tea.Model {
  startDate?: string;
  updated?: string;
  static names(): { [key: string]: string } {
    return {
      startDate: 'startDate',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startDate: 'string',
      updated: 'string',
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

export class UpdateWorkTimeApproveResponseBodyResult extends $tea.Model {
  approveOpenId?: string;
  createdAt?: string;
  creatorId?: string;
  finishTime?: string;
  instanceId?: string;
  organizationId?: string;
  status?: string;
  submitTime?: string;
  taskId?: string;
  time?: number;
  title?: string;
  updatedAt?: string;
  url?: string;
  userId?: string;
  workTimeIds?: string[];
  static names(): { [key: string]: string } {
    return {
      approveOpenId: 'approveOpenId',
      createdAt: 'createdAt',
      creatorId: 'creatorId',
      finishTime: 'finishTime',
      instanceId: 'instanceId',
      organizationId: 'organizationId',
      status: 'status',
      submitTime: 'submitTime',
      taskId: 'taskId',
      time: 'time',
      title: 'title',
      updatedAt: 'updatedAt',
      url: 'url',
      userId: 'userId',
      workTimeIds: 'workTimeIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveOpenId: 'string',
      createdAt: 'string',
      creatorId: 'string',
      finishTime: 'string',
      instanceId: 'string',
      organizationId: 'string',
      status: 'string',
      submitTime: 'string',
      taskId: 'string',
      time: 'number',
      title: 'string',
      updatedAt: 'string',
      url: 'string',
      userId: 'string',
      workTimeIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async addProjectMemberWithOptions(userId: string, projectId: string, request: AddProjectMemberRequest, headers: AddProjectMemberHeaders, runtime: $Util.RuntimeOptions): Promise<AddProjectMemberResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "AddProjectMember",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddProjectMemberResponse>(await this.execute(params, req, runtime), new AddProjectMemberResponse({}));
  }

  async addProjectMember(userId: string, projectId: string, request: AddProjectMemberRequest): Promise<AddProjectMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddProjectMemberHeaders({ });
    return await this.addProjectMemberWithOptions(userId, projectId, request, headers, runtime);
  }

  async archiveProjectWithOptions(userId: string, projectId: string, headers: ArchiveProjectHeaders, runtime: $Util.RuntimeOptions): Promise<ArchiveProjectResponse> {
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
      action: "ArchiveProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/archive`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ArchiveProjectResponse>(await this.execute(params, req, runtime), new ArchiveProjectResponse({}));
  }

  async archiveProject(userId: string, projectId: string): Promise<ArchiveProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ArchiveProjectHeaders({ });
    return await this.archiveProjectWithOptions(userId, projectId, headers, runtime);
  }

  async archiveTaskWithOptions(userId: string, taskId: string, headers: ArchiveTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ArchiveTaskResponse> {
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
      action: "ArchiveTask",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/archive`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ArchiveTaskResponse>(await this.execute(params, req, runtime), new ArchiveTaskResponse({}));
  }

  async archiveTask(userId: string, taskId: string): Promise<ArchiveTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ArchiveTaskHeaders({ });
    return await this.archiveTaskWithOptions(userId, taskId, headers, runtime);
  }

  async createOrganizationTaskWithOptions(userId: string, request: CreateOrganizationTaskRequest, headers: CreateOrganizationTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOrganizationTaskResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "CreateOrganizationTask",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateOrganizationTaskResponse>(await this.execute(params, req, runtime), new CreateOrganizationTaskResponse({}));
  }

  async createOrganizationTask(userId: string, request: CreateOrganizationTaskRequest): Promise<CreateOrganizationTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOrganizationTaskHeaders({ });
    return await this.createOrganizationTaskWithOptions(userId, request, headers, runtime);
  }

  async createPlanTimeWithOptions(userId: string, request: CreatePlanTimeRequest, headers: CreatePlanTimeHeaders, runtime: $Util.RuntimeOptions): Promise<CreatePlanTimeResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "CreatePlanTime",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/planTimes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreatePlanTimeResponse>(await this.execute(params, req, runtime), new CreatePlanTimeResponse({}));
  }

  async createPlanTime(userId: string, request: CreatePlanTimeRequest): Promise<CreatePlanTimeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatePlanTimeHeaders({ });
    return await this.createPlanTimeWithOptions(userId, request, headers, runtime);
  }

  async createProjectWithOptions(userId: string, request: CreateProjectRequest, headers: CreateProjectHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
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
      action: "CreateProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateProjectResponse>(await this.execute(params, req, runtime), new CreateProjectResponse({}));
  }

  async createProject(userId: string, request: CreateProjectRequest): Promise<CreateProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProjectHeaders({ });
    return await this.createProjectWithOptions(userId, request, headers, runtime);
  }

  async createProjectByTemplateWithOptions(userId: string, request: CreateProjectByTemplateRequest, headers: CreateProjectByTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProjectByTemplateResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "CreateProjectByTemplate",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/templates/projects`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateProjectByTemplateResponse>(await this.execute(params, req, runtime), new CreateProjectByTemplateResponse({}));
  }

  async createProjectByTemplate(userId: string, request: CreateProjectByTemplateRequest): Promise<CreateProjectByTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProjectByTemplateHeaders({ });
    return await this.createProjectByTemplateWithOptions(userId, request, headers, runtime);
  }

  async createProjectCustomfieldStatusWithOptions(userId: string, projectId: string, request: CreateProjectCustomfieldStatusRequest, headers: CreateProjectCustomfieldStatusHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProjectCustomfieldStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customFieldId)) {
      body["customFieldId"] = request.customFieldId;
    }

    if (!Util.isUnset(request.customFieldInstanceId)) {
      body["customFieldInstanceId"] = request.customFieldInstanceId;
    }

    if (!Util.isUnset(request.customFieldName)) {
      body["customFieldName"] = request.customFieldName;
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
    let params = new $OpenApi.Params({
      action: "CreateProjectCustomfieldStatus",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/customfields`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateProjectCustomfieldStatusResponse>(await this.execute(params, req, runtime), new CreateProjectCustomfieldStatusResponse({}));
  }

  async createProjectCustomfieldStatus(userId: string, projectId: string, request: CreateProjectCustomfieldStatusRequest): Promise<CreateProjectCustomfieldStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProjectCustomfieldStatusHeaders({ });
    return await this.createProjectCustomfieldStatusWithOptions(userId, projectId, request, headers, runtime);
  }

  async createTaskWithOptions(userId: string, request: CreateTaskRequest, headers: CreateTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTaskResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "CreateTask",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTaskResponse>(await this.execute(params, req, runtime), new CreateTaskResponse({}));
  }

  async createTask(userId: string, request: CreateTaskRequest): Promise<CreateTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTaskHeaders({ });
    return await this.createTaskWithOptions(userId, request, headers, runtime);
  }

  async createTaskObjectLinkWithOptions(userId: string, taskId: string, request: CreateTaskObjectLinkRequest, headers: CreateTaskObjectLinkHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTaskObjectLinkResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "CreateTaskObjectLink",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/objectLinks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTaskObjectLinkResponse>(await this.execute(params, req, runtime), new CreateTaskObjectLinkResponse({}));
  }

  async createTaskObjectLink(userId: string, taskId: string, request: CreateTaskObjectLinkRequest): Promise<CreateTaskObjectLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTaskObjectLinkHeaders({ });
    return await this.createTaskObjectLinkWithOptions(userId, taskId, request, headers, runtime);
  }

  async createWorkTimeWithOptions(userId: string, request: CreateWorkTimeRequest, headers: CreateWorkTimeHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkTimeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantType)) {
      query["tenantType"] = request.tenantType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

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
    let params = new $OpenApi.Params({
      action: "CreateWorkTime",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/workTimes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateWorkTimeResponse>(await this.execute(params, req, runtime), new CreateWorkTimeResponse({}));
  }

  async createWorkTime(userId: string, request: CreateWorkTimeRequest): Promise<CreateWorkTimeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkTimeHeaders({ });
    return await this.createWorkTimeWithOptions(userId, request, headers, runtime);
  }

  async createWorkTimeApproveWithOptions(userId: string, request: CreateWorkTimeApproveRequest, headers: CreateWorkTimeApproveHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkTimeApproveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.workTimeIds)) {
      body["workTimeIds"] = request.workTimeIds;
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
      action: "CreateWorkTimeApprove",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/workTimes/approvals`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateWorkTimeApproveResponse>(await this.execute(params, req, runtime), new CreateWorkTimeApproveResponse({}));
  }

  async createWorkTimeApprove(userId: string, request: CreateWorkTimeApproveRequest): Promise<CreateWorkTimeApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkTimeApproveHeaders({ });
    return await this.createWorkTimeApproveWithOptions(userId, request, headers, runtime);
  }

  async deleteProjectMemberWithOptions(userId: string, projectId: string, request: DeleteProjectMemberRequest, headers: DeleteProjectMemberHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteProjectMemberResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "DeleteProjectMember",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/members/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteProjectMemberResponse>(await this.execute(params, req, runtime), new DeleteProjectMemberResponse({}));
  }

  async deleteProjectMember(userId: string, projectId: string, request: DeleteProjectMemberRequest): Promise<DeleteProjectMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteProjectMemberHeaders({ });
    return await this.deleteProjectMemberWithOptions(userId, projectId, request, headers, runtime);
  }

  async deleteTaskWithOptions(userId: string, taskId: string, headers: DeleteTaskHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTaskResponse> {
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
      action: "DeleteTask",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteTaskResponse>(await this.execute(params, req, runtime), new DeleteTaskResponse({}));
  }

  async deleteTask(userId: string, taskId: string): Promise<DeleteTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTaskHeaders({ });
    return await this.deleteTaskWithOptions(userId, taskId, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetDeptsByOrgId",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/orgs/depts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDeptsByOrgIdResponse>(await this.execute(params, req, runtime), new GetDeptsByOrgIdResponse({}));
  }

  async getDeptsByOrgId(request: GetDeptsByOrgIdRequest): Promise<GetDeptsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeptsByOrgIdHeaders({ });
    return await this.getDeptsByOrgIdWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetEmpsByOrgId",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/orgs/employees`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEmpsByOrgIdResponse>(await this.execute(params, req, runtime), new GetEmpsByOrgIdResponse({}));
  }

  async getEmpsByOrgId(request: GetEmpsByOrgIdRequest): Promise<GetEmpsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmpsByOrgIdHeaders({ });
    return await this.getEmpsByOrgIdWithOptions(request, headers, runtime);
  }

  async getOrganizatioTaskByIdsWithOptions(userId: string, request: GetOrganizatioTaskByIdsRequest, headers: GetOrganizatioTaskByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizatioTaskByIdsResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetOrganizatioTaskByIds",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrganizatioTaskByIdsResponse>(await this.execute(params, req, runtime), new GetOrganizatioTaskByIdsResponse({}));
  }

  async getOrganizatioTaskByIds(userId: string, request: GetOrganizatioTaskByIdsRequest): Promise<GetOrganizatioTaskByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizatioTaskByIdsHeaders({ });
    return await this.getOrganizatioTaskByIdsWithOptions(userId, request, headers, runtime);
  }

  async getOrganizationPriorityListWithOptions(userId: string, headers: GetOrganizationPriorityListHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizationPriorityListResponse> {
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
      action: "GetOrganizationPriorityList",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/priorities`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrganizationPriorityListResponse>(await this.execute(params, req, runtime), new GetOrganizationPriorityListResponse({}));
  }

  async getOrganizationPriorityList(userId: string): Promise<GetOrganizationPriorityListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizationPriorityListHeaders({ });
    return await this.getOrganizationPriorityListWithOptions(userId, headers, runtime);
  }

  async getOrganizationTaskWithOptions(taskId: string, userId: string, headers: GetOrganizationTaskHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizationTaskResponse> {
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
      action: "GetOrganizationTask",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrganizationTaskResponse>(await this.execute(params, req, runtime), new GetOrganizationTaskResponse({}));
  }

  async getOrganizationTask(taskId: string, userId: string): Promise<GetOrganizationTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizationTaskHeaders({ });
    return await this.getOrganizationTaskWithOptions(taskId, userId, headers, runtime);
  }

  async getProjectGroupWithOptions(userId: string, request: GetProjectGroupRequest, headers: GetProjectGroupHeaders, runtime: $Util.RuntimeOptions): Promise<GetProjectGroupResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetProjectGroup",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProjectGroupResponse>(await this.execute(params, req, runtime), new GetProjectGroupResponse({}));
  }

  async getProjectGroup(userId: string, request: GetProjectGroupRequest): Promise<GetProjectGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectGroupHeaders({ });
    return await this.getProjectGroupWithOptions(userId, request, headers, runtime);
  }

  async getProjectMemebersWithOptions(userId: string, projectId: string, request: GetProjectMemebersRequest, headers: GetProjectMemebersHeaders, runtime: $Util.RuntimeOptions): Promise<GetProjectMemebersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.projectRoleId)) {
      query["projectRoleId"] = request.projectRoleId;
    }

    if (!Util.isUnset(request.skip)) {
      query["skip"] = request.skip;
    }

    if (!Util.isUnset(request.userIds)) {
      query["userIds"] = request.userIds;
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
      action: "GetProjectMemebers",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProjectMemebersResponse>(await this.execute(params, req, runtime), new GetProjectMemebersResponse({}));
  }

  async getProjectMemebers(userId: string, projectId: string, request: GetProjectMemebersRequest): Promise<GetProjectMemebersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectMemebersHeaders({ });
    return await this.getProjectMemebersWithOptions(userId, projectId, request, headers, runtime);
  }

  async getProjectStatusListWithOptions(userId: string, projectId: string, headers: GetProjectStatusListHeaders, runtime: $Util.RuntimeOptions): Promise<GetProjectStatusListResponse> {
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
      action: "GetProjectStatusList",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/statuses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProjectStatusListResponse>(await this.execute(params, req, runtime), new GetProjectStatusListResponse({}));
  }

  async getProjectStatusList(userId: string, projectId: string): Promise<GetProjectStatusListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectStatusListHeaders({ });
    return await this.getProjectStatusListWithOptions(userId, projectId, headers, runtime);
  }

  async getTaskByIdsWithOptions(userId: string, request: GetTaskByIdsRequest, headers: GetTaskByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskByIdsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.parentTaskId)) {
      query["parentTaskId"] = request.parentTaskId;
    }

    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
      action: "GetTaskByIds",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTaskByIdsResponse>(await this.execute(params, req, runtime), new GetTaskByIdsResponse({}));
  }

  async getTaskByIds(userId: string, request: GetTaskByIdsRequest): Promise<GetTaskByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskByIdsHeaders({ });
    return await this.getTaskByIdsWithOptions(userId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetTbOrgIdByDingOrgId",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/teambition/organizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTbOrgIdByDingOrgIdResponse>(await this.execute(params, req, runtime), new GetTbOrgIdByDingOrgIdResponse({}));
  }

  async getTbOrgIdByDingOrgId(request: GetTbOrgIdByDingOrgIdRequest): Promise<GetTbOrgIdByDingOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbOrgIdByDingOrgIdHeaders({ });
    return await this.getTbOrgIdByDingOrgIdWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetTbProjectGray",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/projects/gray`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetTbProjectGrayResponse>(await this.execute(params, req, runtime), new GetTbProjectGrayResponse({}));
  }

  async getTbProjectGray(request: GetTbProjectGrayRequest): Promise<GetTbProjectGrayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectGrayHeaders({ });
    return await this.getTbProjectGrayWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetTbProjectSource",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/projects/source`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTbProjectSourceResponse>(await this.execute(params, req, runtime), new GetTbProjectSourceResponse({}));
  }

  async getTbProjectSource(): Promise<GetTbProjectSourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectSourceHeaders({ });
    return await this.getTbProjectSourceWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetTbUserIdByStaffId",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/teambition/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTbUserIdByStaffIdResponse>(await this.execute(params, req, runtime), new GetTbUserIdByStaffIdResponse({}));
  }

  async getTbUserIdByStaffId(request: GetTbUserIdByStaffIdRequest): Promise<GetTbUserIdByStaffIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbUserIdByStaffIdHeaders({ });
    return await this.getTbUserIdByStaffIdWithOptions(request, headers, runtime);
  }

  async getUserJoinedProjectWithOptions(userId: string, request: GetUserJoinedProjectRequest, headers: GetUserJoinedProjectHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserJoinedProjectResponse> {
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

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetUserJoinedProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/joinProjects`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserJoinedProjectResponse>(await this.execute(params, req, runtime), new GetUserJoinedProjectResponse({}));
  }

  async getUserJoinedProject(userId: string, request: GetUserJoinedProjectRequest): Promise<GetUserJoinedProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserJoinedProjectHeaders({ });
    return await this.getUserJoinedProjectWithOptions(userId, request, headers, runtime);
  }

  async queryProjectWithOptions(userId: string, request: QueryProjectRequest, headers: QueryProjectHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProjectResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.projectIds)) {
      query["projectIds"] = request.projectIds;
    }

    if (!Util.isUnset(request.sourceId)) {
      query["sourceId"] = request.sourceId;
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
      action: "QueryProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryProjectResponse>(await this.execute(params, req, runtime), new QueryProjectResponse({}));
  }

  async queryProject(userId: string, request: QueryProjectRequest): Promise<QueryProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProjectHeaders({ });
    return await this.queryProjectWithOptions(userId, request, headers, runtime);
  }

  async queryTaskOfProjectWithOptions(userId: string, projectId: string, request: QueryTaskOfProjectRequest, headers: QueryTaskOfProjectHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTaskOfProjectResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "QueryTaskOfProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projectIds/${projectId}/tasks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryTaskOfProjectResponse>(await this.execute(params, req, runtime), new QueryTaskOfProjectResponse({}));
  }

  async queryTaskOfProject(userId: string, projectId: string, request: QueryTaskOfProjectRequest): Promise<QueryTaskOfProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTaskOfProjectHeaders({ });
    return await this.queryTaskOfProjectWithOptions(userId, projectId, request, headers, runtime);
  }

  async seachTaskStageWithOptions(userId: string, projectId: string, request: SeachTaskStageRequest, headers: SeachTaskStageHeaders, runtime: $Util.RuntimeOptions): Promise<SeachTaskStageResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(request.taskListId)) {
      query["taskListId"] = request.taskListId;
    }

    if (!Util.isUnset(request.taskStageIds)) {
      query["taskStageIds"] = request.taskStageIds;
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
      action: "SeachTaskStage",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/taskStages/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SeachTaskStageResponse>(await this.execute(params, req, runtime), new SeachTaskStageResponse({}));
  }

  async seachTaskStage(userId: string, projectId: string, request: SeachTaskStageRequest): Promise<SeachTaskStageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SeachTaskStageHeaders({ });
    return await this.seachTaskStageWithOptions(userId, projectId, request, headers, runtime);
  }

  async searchAllTasksByTqlWithOptions(userId: string, request: SearchAllTasksByTqlRequest, headers: SearchAllTasksByTqlHeaders, runtime: $Util.RuntimeOptions): Promise<SearchAllTasksByTqlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.tql)) {
      query["tql"] = request.tql;
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
      action: "SearchAllTasksByTql",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tql/tasks/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchAllTasksByTqlResponse>(await this.execute(params, req, runtime), new SearchAllTasksByTqlResponse({}));
  }

  async searchAllTasksByTql(userId: string, request: SearchAllTasksByTqlRequest): Promise<SearchAllTasksByTqlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchAllTasksByTqlHeaders({ });
    return await this.searchAllTasksByTqlWithOptions(userId, request, headers, runtime);
  }

  async searchOranizationCustomfieldWithOptions(userId: string, request: SearchOranizationCustomfieldRequest, headers: SearchOranizationCustomfieldHeaders, runtime: $Util.RuntimeOptions): Promise<SearchOranizationCustomfieldResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customFieldIds)) {
      query["customFieldIds"] = request.customFieldIds;
    }

    if (!Util.isUnset(request.instanceIds)) {
      query["instanceIds"] = request.instanceIds;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.projectIds)) {
      query["projectIds"] = request.projectIds;
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
    let params = new $OpenApi.Params({
      action: "SearchOranizationCustomfield",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/customfields/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchOranizationCustomfieldResponse>(await this.execute(params, req, runtime), new SearchOranizationCustomfieldResponse({}));
  }

  async searchOranizationCustomfield(userId: string, request: SearchOranizationCustomfieldRequest): Promise<SearchOranizationCustomfieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchOranizationCustomfieldHeaders({ });
    return await this.searchOranizationCustomfieldWithOptions(userId, request, headers, runtime);
  }

  async searchProjectCustomfieldWithOptions(userId: string, projectId: string, request: SearchProjectCustomfieldRequest, headers: SearchProjectCustomfieldHeaders, runtime: $Util.RuntimeOptions): Promise<SearchProjectCustomfieldResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customFieldIds)) {
      query["customFieldIds"] = request.customFieldIds;
    }

    if (!Util.isUnset(request.instanceIds)) {
      query["instanceIds"] = request.instanceIds;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.query)) {
      query["query"] = request.query;
    }

    if (!Util.isUnset(request.scenarioFieldConfigId)) {
      query["scenarioFieldConfigId"] = request.scenarioFieldConfigId;
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
      action: "SearchProjectCustomfield",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/customfields/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchProjectCustomfieldResponse>(await this.execute(params, req, runtime), new SearchProjectCustomfieldResponse({}));
  }

  async searchProjectCustomfield(userId: string, projectId: string, request: SearchProjectCustomfieldRequest): Promise<SearchProjectCustomfieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchProjectCustomfieldHeaders({ });
    return await this.searchProjectCustomfieldWithOptions(userId, projectId, request, headers, runtime);
  }

  async searchProjectTemplateWithOptions(userId: string, request: SearchProjectTemplateRequest, headers: SearchProjectTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<SearchProjectTemplateResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "SearchProjectTemplate",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/templates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchProjectTemplateResponse>(await this.execute(params, req, runtime), new SearchProjectTemplateResponse({}));
  }

  async searchProjectTemplate(userId: string, request: SearchProjectTemplateRequest): Promise<SearchProjectTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchProjectTemplateHeaders({ });
    return await this.searchProjectTemplateWithOptions(userId, request, headers, runtime);
  }

  async searchTaskFlowWithOptions(userId: string, projectId: string, request: SearchTaskFlowRequest, headers: SearchTaskFlowHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTaskFlowResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(request.taskflowIds)) {
      query["taskflowIds"] = request.taskflowIds;
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
      action: "SearchTaskFlow",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/taskflows/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchTaskFlowResponse>(await this.execute(params, req, runtime), new SearchTaskFlowResponse({}));
  }

  async searchTaskFlow(userId: string, projectId: string, request: SearchTaskFlowRequest): Promise<SearchTaskFlowResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTaskFlowHeaders({ });
    return await this.searchTaskFlowWithOptions(userId, projectId, request, headers, runtime);
  }

  async searchTaskListWithOptions(userId: string, projectId: string, request: SearchTaskListRequest, headers: SearchTaskListHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTaskListResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(request.taskListIds)) {
      query["taskListIds"] = request.taskListIds;
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
      action: "SearchTaskList",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/taskLists/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchTaskListResponse>(await this.execute(params, req, runtime), new SearchTaskListResponse({}));
  }

  async searchTaskList(userId: string, projectId: string, request: SearchTaskListRequest): Promise<SearchTaskListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTaskListHeaders({ });
    return await this.searchTaskListWithOptions(userId, projectId, request, headers, runtime);
  }

  async searchTaskflowStatusWithOptions(userId: string, projectId: string, request: SearchTaskflowStatusRequest, headers: SearchTaskflowStatusHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTaskflowStatusResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "SearchTaskflowStatus",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/taskflowStatuses/search`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchTaskflowStatusResponse>(await this.execute(params, req, runtime), new SearchTaskflowStatusResponse({}));
  }

  async searchTaskflowStatus(userId: string, projectId: string, request: SearchTaskflowStatusRequest): Promise<SearchTaskflowStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTaskflowStatusHeaders({ });
    return await this.searchTaskflowStatusWithOptions(userId, projectId, request, headers, runtime);
  }

  async searchUserTaskWithOptions(userId: string, request: SearchUserTaskRequest, headers: SearchUserTaskHeaders, runtime: $Util.RuntimeOptions): Promise<SearchUserTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.roleTypes)) {
      query["roleTypes"] = request.roleTypes;
    }

    if (!Util.isUnset(request.tql)) {
      query["tql"] = request.tql;
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
      action: "SearchUserTask",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchUserTaskResponse>(await this.execute(params, req, runtime), new SearchUserTaskResponse({}));
  }

  async searchUserTask(userId: string, request: SearchUserTaskRequest): Promise<SearchUserTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchUserTaskHeaders({ });
    return await this.searchUserTaskWithOptions(userId, request, headers, runtime);
  }

  async suspendProjectWithOptions(projectId: string, userId: string, headers: SuspendProjectHeaders, runtime: $Util.RuntimeOptions): Promise<SuspendProjectResponse> {
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
      action: "SuspendProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/suspend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SuspendProjectResponse>(await this.execute(params, req, runtime), new SuspendProjectResponse({}));
  }

  async suspendProject(projectId: string, userId: string): Promise<SuspendProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SuspendProjectHeaders({ });
    return await this.suspendProjectWithOptions(projectId, userId, headers, runtime);
  }

  async unSuspendProjectWithOptions(projectId: string, userId: string, headers: UnSuspendProjectHeaders, runtime: $Util.RuntimeOptions): Promise<UnSuspendProjectResponse> {
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
      action: "UnSuspendProject",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/unsuspend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnSuspendProjectResponse>(await this.execute(params, req, runtime), new UnSuspendProjectResponse({}));
  }

  async unSuspendProject(projectId: string, userId: string): Promise<UnSuspendProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnSuspendProjectHeaders({ });
    return await this.unSuspendProjectWithOptions(projectId, userId, headers, runtime);
  }

  async updateCustomfieldValueWithOptions(userId: string, taskId: string, request: UpdateCustomfieldValueRequest, headers: UpdateCustomfieldValueHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCustomfieldValueResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customFieldId)) {
      body["customFieldId"] = request.customFieldId;
    }

    if (!Util.isUnset(request.customFieldName)) {
      body["customFieldName"] = request.customFieldName;
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
    let params = new $OpenApi.Params({
      action: "UpdateCustomfieldValue",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/customFields`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCustomfieldValueResponse>(await this.execute(params, req, runtime), new UpdateCustomfieldValueResponse({}));
  }

  async updateCustomfieldValue(userId: string, taskId: string, request: UpdateCustomfieldValueRequest): Promise<UpdateCustomfieldValueResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCustomfieldValueHeaders({ });
    return await this.updateCustomfieldValueWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateOrganizationTaskContentWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskContentRequest, headers: UpdateOrganizationTaskContentHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskContentResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskContent",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/contents`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskContentResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskContentResponse({}));
  }

  async updateOrganizationTaskContent(taskId: string, userId: string, request: UpdateOrganizationTaskContentRequest): Promise<UpdateOrganizationTaskContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskContentHeaders({ });
    return await this.updateOrganizationTaskContentWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskDueDateWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskDueDateRequest, headers: UpdateOrganizationTaskDueDateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskDueDateResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskDueDate",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/dueDates`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskDueDateResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskDueDateResponse({}));
  }

  async updateOrganizationTaskDueDate(taskId: string, userId: string, request: UpdateOrganizationTaskDueDateRequest): Promise<UpdateOrganizationTaskDueDateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskDueDateHeaders({ });
    return await this.updateOrganizationTaskDueDateWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskExecutorWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskExecutorRequest, headers: UpdateOrganizationTaskExecutorHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskExecutorResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskExecutor",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/executors`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskExecutorResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskExecutorResponse({}));
  }

  async updateOrganizationTaskExecutor(taskId: string, userId: string, request: UpdateOrganizationTaskExecutorRequest): Promise<UpdateOrganizationTaskExecutorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskExecutorHeaders({ });
    return await this.updateOrganizationTaskExecutorWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskInvolveMembersWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskInvolveMembersRequest, headers: UpdateOrganizationTaskInvolveMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskInvolveMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskInvolveMembers",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/involveMembers`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskInvolveMembersResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskInvolveMembersResponse({}));
  }

  async updateOrganizationTaskInvolveMembers(taskId: string, userId: string, request: UpdateOrganizationTaskInvolveMembersRequest): Promise<UpdateOrganizationTaskInvolveMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskInvolveMembersHeaders({ });
    return await this.updateOrganizationTaskInvolveMembersWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskNoteWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskNoteRequest, headers: UpdateOrganizationTaskNoteHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskNoteResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskNote",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/notes`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskNoteResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskNoteResponse({}));
  }

  async updateOrganizationTaskNote(taskId: string, userId: string, request: UpdateOrganizationTaskNoteRequest): Promise<UpdateOrganizationTaskNoteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskNoteHeaders({ });
    return await this.updateOrganizationTaskNoteWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskPriorityWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskPriorityRequest, headers: UpdateOrganizationTaskPriorityHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskPriorityResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskPriority",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/priorities`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskPriorityResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskPriorityResponse({}));
  }

  async updateOrganizationTaskPriority(taskId: string, userId: string, request: UpdateOrganizationTaskPriorityRequest): Promise<UpdateOrganizationTaskPriorityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskPriorityHeaders({ });
    return await this.updateOrganizationTaskPriorityWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateOrganizationTaskStatusWithOptions(taskId: string, userId: string, request: UpdateOrganizationTaskStatusRequest, headers: UpdateOrganizationTaskStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOrganizationTaskStatusResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateOrganizationTaskStatus",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/organizations/users/${userId}/tasks/${taskId}/states`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOrganizationTaskStatusResponse>(await this.execute(params, req, runtime), new UpdateOrganizationTaskStatusResponse({}));
  }

  async updateOrganizationTaskStatus(taskId: string, userId: string, request: UpdateOrganizationTaskStatusRequest): Promise<UpdateOrganizationTaskStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOrganizationTaskStatusHeaders({ });
    return await this.updateOrganizationTaskStatusWithOptions(taskId, userId, request, headers, runtime);
  }

  async updateProjectGroupWithOptions(userId: string, projectId: string, request: UpdateProjectGroupRequest, headers: UpdateProjectGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateProjectGroupResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateProjectGroup",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/projects/${projectId}/groups`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateProjectGroupResponse>(await this.execute(params, req, runtime), new UpdateProjectGroupResponse({}));
  }

  async updateProjectGroup(userId: string, projectId: string, request: UpdateProjectGroupRequest): Promise<UpdateProjectGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateProjectGroupHeaders({ });
    return await this.updateProjectGroupWithOptions(userId, projectId, request, headers, runtime);
  }

  async updateTaskContentWithOptions(userId: string, taskId: string, request: UpdateTaskContentRequest, headers: UpdateTaskContentHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskContentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
      action: "UpdateTaskContent",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/contents`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskContentResponse>(await this.execute(params, req, runtime), new UpdateTaskContentResponse({}));
  }

  async updateTaskContent(userId: string, taskId: string, request: UpdateTaskContentRequest): Promise<UpdateTaskContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskContentHeaders({ });
    return await this.updateTaskContentWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskDueDateWithOptions(userId: string, taskId: string, request: UpdateTaskDueDateRequest, headers: UpdateTaskDueDateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskDueDateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "UpdateTaskDueDate",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/dueDates`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskDueDateResponse>(await this.execute(params, req, runtime), new UpdateTaskDueDateResponse({}));
  }

  async updateTaskDueDate(userId: string, taskId: string, request: UpdateTaskDueDateRequest): Promise<UpdateTaskDueDateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskDueDateHeaders({ });
    return await this.updateTaskDueDateWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskExecutorWithOptions(userId: string, taskId: string, request: UpdateTaskExecutorRequest, headers: UpdateTaskExecutorHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskExecutorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "UpdateTaskExecutor",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/executors`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskExecutorResponse>(await this.execute(params, req, runtime), new UpdateTaskExecutorResponse({}));
  }

  async updateTaskExecutor(userId: string, taskId: string, request: UpdateTaskExecutorRequest): Promise<UpdateTaskExecutorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskExecutorHeaders({ });
    return await this.updateTaskExecutorWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskInvolvemembersWithOptions(userId: string, taskId: string, request: UpdateTaskInvolvemembersRequest, headers: UpdateTaskInvolvemembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskInvolvemembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addInvolvers)) {
      body["addInvolvers"] = request.addInvolvers;
    }

    if (!Util.isUnset(request.delInvolvers)) {
      body["delInvolvers"] = request.delInvolvers;
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
    let params = new $OpenApi.Params({
      action: "UpdateTaskInvolvemembers",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/involveMembers`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskInvolvemembersResponse>(await this.execute(params, req, runtime), new UpdateTaskInvolvemembersResponse({}));
  }

  async updateTaskInvolvemembers(userId: string, taskId: string, request: UpdateTaskInvolvemembersRequest): Promise<UpdateTaskInvolvemembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskInvolvemembersHeaders({ });
    return await this.updateTaskInvolvemembersWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskNoteWithOptions(userId: string, taskId: string, request: UpdateTaskNoteRequest, headers: UpdateTaskNoteHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskNoteResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "UpdateTaskNote",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/notes`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskNoteResponse>(await this.execute(params, req, runtime), new UpdateTaskNoteResponse({}));
  }

  async updateTaskNote(userId: string, taskId: string, request: UpdateTaskNoteRequest): Promise<UpdateTaskNoteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskNoteHeaders({ });
    return await this.updateTaskNoteWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskPriorityWithOptions(userId: string, taskId: string, request: UpdateTaskPriorityRequest, headers: UpdateTaskPriorityHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskPriorityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "UpdateTaskPriority",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/priorities`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskPriorityResponse>(await this.execute(params, req, runtime), new UpdateTaskPriorityResponse({}));
  }

  async updateTaskPriority(userId: string, taskId: string, request: UpdateTaskPriorityRequest): Promise<UpdateTaskPriorityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskPriorityHeaders({ });
    return await this.updateTaskPriorityWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskStageWithOptions(userId: string, taskId: string, request: UpdateTaskStageRequest, headers: UpdateTaskStageHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskStageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskStageId)) {
      body["taskStageId"] = request.taskStageId;
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
      action: "UpdateTaskStage",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/stages`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskStageResponse>(await this.execute(params, req, runtime), new UpdateTaskStageResponse({}));
  }

  async updateTaskStage(userId: string, taskId: string, request: UpdateTaskStageRequest): Promise<UpdateTaskStageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskStageHeaders({ });
    return await this.updateTaskStageWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskStartdateWithOptions(userId: string, taskId: string, request: UpdateTaskStartdateRequest, headers: UpdateTaskStartdateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskStartdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
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
      action: "UpdateTaskStartdate",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/startDates`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskStartdateResponse>(await this.execute(params, req, runtime), new UpdateTaskStartdateResponse({}));
  }

  async updateTaskStartdate(userId: string, taskId: string, request: UpdateTaskStartdateRequest): Promise<UpdateTaskStartdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskStartdateHeaders({ });
    return await this.updateTaskStartdateWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateTaskTaskflowstatusWithOptions(userId: string, taskId: string, request: UpdateTaskTaskflowstatusRequest, headers: UpdateTaskTaskflowstatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTaskTaskflowstatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskflowStatusId)) {
      body["taskflowStatusId"] = request.taskflowStatusId;
    }

    if (!Util.isUnset(request.taskflowStatusUpdateNote)) {
      body["taskflowStatusUpdateNote"] = request.taskflowStatusUpdateNote;
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
      action: "UpdateTaskTaskflowstatus",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/tasks/${taskId}/taskflowStatuses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTaskTaskflowstatusResponse>(await this.execute(params, req, runtime), new UpdateTaskTaskflowstatusResponse({}));
  }

  async updateTaskTaskflowstatus(userId: string, taskId: string, request: UpdateTaskTaskflowstatusRequest): Promise<UpdateTaskTaskflowstatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTaskTaskflowstatusHeaders({ });
    return await this.updateTaskTaskflowstatusWithOptions(userId, taskId, request, headers, runtime);
  }

  async updateWorkTimeApproveWithOptions(userId: string, approveOpenId: string, request: UpdateWorkTimeApproveRequest, headers: UpdateWorkTimeApproveHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkTimeApproveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.finishTime)) {
      body["finishTime"] = request.finishTime;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.submitTime)) {
      body["submitTime"] = request.submitTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
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
      action: "UpdateWorkTimeApprove",
      version: "project_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/project/users/${userId}/workTimes/approvals/${approveOpenId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateWorkTimeApproveResponse>(await this.execute(params, req, runtime), new UpdateWorkTimeApproveResponse({}));
  }

  async updateWorkTimeApprove(userId: string, approveOpenId: string, request: UpdateWorkTimeApproveRequest): Promise<UpdateWorkTimeApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkTimeApproveHeaders({ });
    return await this.updateWorkTimeApproveWithOptions(userId, approveOpenId, request, headers, runtime);
  }

}
