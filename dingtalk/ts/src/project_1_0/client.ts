// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  dueDate?: string;
  executorId?: string;
  note?: string;
  priority?: number;
  projectId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      dueDate: 'dueDate',
      executorId: 'executorId',
      note: 'note',
      priority: 'priority',
      projectId: 'projectId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      dueDate: 'string',
      executorId: 'string',
      note: 'string',
      priority: 'number',
      projectId: 'string',
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

export class CreateTaskResponseBodyResult extends $tea.Model {
  content?: string;
  created?: string;
  creatorId?: string;
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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

    if (!Util.isUnset(request.dueDate)) {
      body["dueDate"] = request.dueDate;
    }

    if (!Util.isUnset(request.executorId)) {
      body["executorId"] = request.executorId;
    }

    if (!Util.isUnset(request.note)) {
      body["note"] = request.note;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
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
    if (!Util.isUnset($tea.toMap(request.linkedData))) {
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

}
