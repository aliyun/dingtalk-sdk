// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class UpdateStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStatusRequest extends $tea.Model {
  importSequence?: string;
  errorLines?: number[];
  appType?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      importSequence: 'importSequence',
      errorLines: 'errorLines',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      importSequence: 'string',
      errorLines: { 'type': 'array', 'itemType': 'number' },
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceIds?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceIds: 'processInstanceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBody extends $tea.Model {
  result?: GetInstancesByIdListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetInstancesByIdListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInstancesByIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInstancesByIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormRemarkHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormRemarkRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  replyId?: number;
  language?: string;
  formInstanceId?: string;
  userId?: string;
  atUserId?: string;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      replyId: 'replyId',
      language: 'language',
      formInstanceId: 'formInstanceId',
      userId: 'userId',
      atUserId: 'atUserId',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      replyId: 'number',
      language: 'string',
      formInstanceId: 'string',
      userId: 'string',
      atUserId: 'string',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormRemarkResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormRemarkResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveFormRemarkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveFormRemarkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdRequest extends $tea.Model {
  formUuid?: string;
  tableFieldId?: string;
  pageNumber?: number;
  pageSize?: number;
  systemToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      tableFieldId: 'tableFieldId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      systemToken: 'systemToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      tableFieldId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      systemToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: { [key: string]: any }[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTableDataByFormInstanceIdTableIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListTableDataByFormInstanceIdTableIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListTableDataByFormInstanceIdTableIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  pageSize?: number;
  language?: string;
  pageNumber?: number;
  keyword?: string;
  userId?: string;
  processCodes?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      pageSize: 'pageSize',
      language: 'language',
      pageNumber: 'pageNumber',
      keyword: 'keyword',
      userId: 'userId',
      processCodes: 'processCodes',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      pageSize: 'number',
      language: 'string',
      pageNumber: 'number',
      keyword: 'string',
      userId: 'string',
      processCodes: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponseBody extends $tea.Model {
  pageNumber?: number;
  totalCount?: number;
  data?: GetTaskCopiesResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      totalCount: 'number',
      data: { 'type': 'array', 'itemType': GetTaskCopiesResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTaskCopiesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTaskCopiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksRequest extends $tea.Model {
  processInstanceId?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponseBody extends $tea.Model {
  result?: GetRunningTasksResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetRunningTasksResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRunningTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRunningTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formType?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formType: 'formType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBody extends $tea.Model {
  result?: ListNavigationByFormTypeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListNavigationByFormTypeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListNavigationByFormTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListNavigationByFormTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckCloudAccountStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckCloudAccountStatusRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckCloudAccountStatusResponseBody extends $tea.Model {
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

export class CheckCloudAccountStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CheckCloudAccountStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CheckCloudAccountStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksRequest extends $tea.Model {
  pageSize?: number;
  language?: string;
  pageNumber?: number;
  keyword?: string;
  appTypes?: string;
  processCodes?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      language: 'language',
      pageNumber: 'pageNumber',
      keyword: 'keyword',
      appTypes: 'appTypes',
      processCodes: 'processCodes',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      language: 'string',
      pageNumber: 'number',
      keyword: 'string',
      appTypes: 'string',
      processCodes: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: GetCorpAccomplishmentTasksResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': GetCorpAccomplishmentTasksResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCorpAccomplishmentTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCorpAccomplishmentTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  searchFieldJson?: string;
  originatorId?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  taskId?: string;
  instanceStatus?: string;
  approvedResult?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      searchFieldJson: 'searchFieldJson',
      originatorId: 'originatorId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      taskId: 'taskId',
      instanceStatus: 'instanceStatus',
      approvedResult: 'approvedResult',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      searchFieldJson: 'string',
      originatorId: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      taskId: 'string',
      instanceStatus: 'string',
      approvedResult: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: GetInstancesResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': GetInstancesResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationRequest extends $tea.Model {
  accessKey?: string;
  pageSize?: number;
  callerUid?: string;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      pageSize: 'pageSize',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      pageSize: 'number',
      callerUid: 'string',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponseBody extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  totalCount?: number;
  plugInformation?: ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation[];
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
      plugInformation: 'plugInformation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
      totalCount: 'number',
      plugInformation: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListApplicationAuthorizationServiceConnectorInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListApplicationAuthorizationServiceConnectorInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderBuyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateOrderBuyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateOrderBuyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewTenantOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewTenantOrderRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  endTimeGMT?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      endTimeGMT: 'endTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      endTimeGMT: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewTenantOrderResponseBody extends $tea.Model {
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

export class RenewTenantOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RenewTenantOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RenewTenantOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryRequest extends $tea.Model {
  formUuid?: string;
  appType?: string;
  version?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      appType: 'appType',
      version: 'version',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      appType: 'string',
      version: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPrintDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPrintDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceRequest extends $tea.Model {
  processInstanceId?: string;
  appType?: string;
  updateFormDataJson?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      appType: 'appType',
      updateFormDataJson: 'updateFormDataJson',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      appType: 'string',
      updateFormDataJson: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyAuthorizationOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyAuthorizationOrderRequest extends $tea.Model {
  produceCode?: string;
  instanceId?: string;
  instanceName?: string;
  accessKey?: string;
  callerUnionId?: string;
  chargeType?: string;
  endTimeGMT?: number;
  beginTimeGMT?: number;
  accountNumber?: string;
  commerceType?: string;
  commodityType?: string;
  static names(): { [key: string]: string } {
    return {
      produceCode: 'produceCode',
      instanceId: 'instanceId',
      instanceName: 'instanceName',
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      chargeType: 'chargeType',
      endTimeGMT: 'endTimeGMT',
      beginTimeGMT: 'beginTimeGMT',
      accountNumber: 'accountNumber',
      commerceType: 'commerceType',
      commodityType: 'commodityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      produceCode: 'string',
      instanceId: 'string',
      instanceName: 'string',
      accessKey: 'string',
      callerUnionId: 'string',
      chargeType: 'string',
      endTimeGMT: 'number',
      beginTimeGMT: 'number',
      accountNumber: 'string',
      commerceType: 'string',
      commodityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyAuthorizationOrderResponseBody extends $tea.Model {
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

export class BuyAuthorizationOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BuyAuthorizationOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BuyAuthorizationOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationServiceOrderUpgradeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateApplicationServiceOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateApplicationServiceOrderUpgradeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksRequest extends $tea.Model {
  corpId?: string;
  pageSize?: number;
  language?: string;
  pageNumber?: number;
  keyword?: string;
  appTypes?: string;
  processCodes?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  userId?: string;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      pageSize: 'pageSize',
      language: 'language',
      pageNumber: 'pageNumber',
      keyword: 'keyword',
      appTypes: 'appTypes',
      processCodes: 'processCodes',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      userId: 'userId',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      pageSize: 'number',
      language: 'string',
      pageNumber: 'number',
      keyword: 'string',
      appTypes: 'string',
      processCodes: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      userId: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: GetCorpTasksResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': GetCorpTasksResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCorpTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCorpTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityRequest extends $tea.Model {
  accessKey?: string;
  pageSize?: number;
  callerUid?: string;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      pageSize: 'pageSize',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      pageSize: 'number',
      callerUid: 'string',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponseBody extends $tea.Model {
  pageSize?: number;
  commodityVOList?: ListCommodityResponseBodyCommodityVOList[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      commodityVOList: 'commodityVOList',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      commodityVOList: { 'type': 'array', 'itemType': ListCommodityResponseBodyCommodityVOList },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyAuthorizationResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyAuthorizationResultRequest extends $tea.Model {
  instanceId?: string;
  accountNumber?: string;
  instanceName?: string;
  accessKey?: string;
  chargeType?: string;
  endTimeGMT?: number;
  beginTimeGMT?: number;
  callerUid?: string;
  commerceType?: string;
  commodityType?: string;
  produceCode?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accountNumber: 'accountNumber',
      instanceName: 'instanceName',
      accessKey: 'accessKey',
      chargeType: 'chargeType',
      endTimeGMT: 'endTimeGMT',
      beginTimeGMT: 'beginTimeGMT',
      callerUid: 'callerUid',
      commerceType: 'commerceType',
      commodityType: 'commodityType',
      produceCode: 'produceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accountNumber: 'string',
      instanceName: 'string',
      accessKey: 'string',
      chargeType: 'string',
      endTimeGMT: 'number',
      beginTimeGMT: 'number',
      callerUid: 'string',
      commerceType: 'string',
      commodityType: 'string',
      produceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyAuthorizationResultResponseBody extends $tea.Model {
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

export class NotifyAuthorizationResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: NotifyAuthorizationResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: NotifyAuthorizationResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListRequest extends $tea.Model {
  processInstanceIdList?: string;
  appType?: string;
  systemToken?: string;
  userId?: string;
  userCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceIdList: 'processInstanceIdList',
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      userCorpId: 'userCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceIdList: 'string',
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      userCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListResponseBody extends $tea.Model {
  result?: GetRunningTaskListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetRunningTaskListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRunningTaskListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRunningTaskListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyFreshOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyFreshOrderRequest extends $tea.Model {
  produceCode?: string;
  instanceId?: string;
  instanceName?: string;
  accessKey?: string;
  callerUnionId?: string;
  chargeType?: string;
  endTimeGMT?: number;
  beginTimeGMT?: number;
  accountNumber?: string;
  commerceType?: string;
  commodityType?: string;
  static names(): { [key: string]: string } {
    return {
      produceCode: 'produceCode',
      instanceId: 'instanceId',
      instanceName: 'instanceName',
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      chargeType: 'chargeType',
      endTimeGMT: 'endTimeGMT',
      beginTimeGMT: 'beginTimeGMT',
      accountNumber: 'accountNumber',
      commerceType: 'commerceType',
      commodityType: 'commodityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      produceCode: 'string',
      instanceId: 'string',
      instanceName: 'string',
      accessKey: 'string',
      callerUnionId: 'string',
      chargeType: 'string',
      endTimeGMT: 'number',
      beginTimeGMT: 'number',
      accountNumber: 'string',
      commerceType: 'string',
      commodityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BuyFreshOrderResponseBody extends $tea.Model {
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

export class BuyFreshOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BuyFreshOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BuyFreshOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTenantResourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTenantResourceRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTenantResourceResponseBody extends $tea.Model {
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

export class RemoveTenantResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RemoveTenantResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RemoveTenantResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewApplicationAuthorizationServiceOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewApplicationAuthorizationServiceOrderRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUnionId?: string;
  endTimeGMT?: number;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      endTimeGMT: 'endTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUnionId: 'string',
      endTimeGMT: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenewApplicationAuthorizationServiceOrderResponseBody extends $tea.Model {
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

export class RenewApplicationAuthorizationServiceOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RenewApplicationAuthorizationServiceOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RenewApplicationAuthorizationServiceOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionRequest extends $tea.Model {
  corpId?: string;
  groupId?: string;
  appType?: string;
  orderNumber?: string;
  systemType?: string;
  systemToken?: string;
  nameSpace?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      groupId: 'groupId',
      appType: 'appType',
      orderNumber: 'orderNumber',
      systemType: 'systemType',
      systemToken: 'systemToken',
      nameSpace: 'nameSpace',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      groupId: 'string',
      appType: 'string',
      orderNumber: 'string',
      systemType: 'string',
      systemToken: 'string',
      nameSpace: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBody extends $tea.Model {
  outResult?: string;
  processInstanceId?: string;
  variables?: { [key: string]: any };
  formUuid?: string;
  processId?: string;
  owners?: GetProcessDefinitionResponseBodyOwners[];
  originator?: GetProcessDefinitionResponseBodyOriginator;
  title?: string;
  tasks?: GetProcessDefinitionResponseBodyTasks[];
  status?: string;
  static names(): { [key: string]: string } {
    return {
      outResult: 'outResult',
      processInstanceId: 'processInstanceId',
      variables: 'variables',
      formUuid: 'formUuid',
      processId: 'processId',
      owners: 'owners',
      originator: 'originator',
      title: 'title',
      tasks: 'tasks',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outResult: 'string',
      processInstanceId: 'string',
      variables: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      formUuid: 'string',
      processId: 'string',
      owners: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyOwners },
      originator: GetProcessDefinitionResponseBodyOriginator,
      title: 'string',
      tasks: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyTasks },
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetProcessDefinitionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetProcessDefinitionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTenantInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTenantInformationRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  accountNumber?: string;
  commodityType?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      accountNumber: 'accountNumber',
      commodityType: 'commodityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      accountNumber: 'string',
      commodityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeTenantInformationResponseBody extends $tea.Model {
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

export class UpgradeTenantInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpgradeTenantInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpgradeTenantInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceResponseBody extends $tea.Model {
  appTotalAmount?: number;
  instanceId?: string;
  instanceTotalAmount?: number;
  instanceUsageAmount?: number;
  accountUsageAmount?: number;
  accountTotalAmount?: number;
  pluginUsageAmount?: number;
  attachmentTotalAmount?: number;
  attachmentUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      appTotalAmount: 'appTotalAmount',
      instanceId: 'instanceId',
      instanceTotalAmount: 'instanceTotalAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      accountUsageAmount: 'accountUsageAmount',
      accountTotalAmount: 'accountTotalAmount',
      pluginUsageAmount: 'pluginUsageAmount',
      attachmentTotalAmount: 'attachmentTotalAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTotalAmount: 'number',
      instanceId: 'string',
      instanceTotalAmount: 'number',
      instanceUsageAmount: 'number',
      accountUsageAmount: 'number',
      accountTotalAmount: 'number',
      pluginUsageAmount: 'number',
      attachmentTotalAmount: 'number',
      attachmentUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationAuthorizationServicePlatformResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetApplicationAuthorizationServicePlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetApplicationAuthorizationServicePlatformResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationRequest extends $tea.Model {
  accessKey?: string;
  pageSize?: number;
  callerUnionId?: string;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      pageSize: 'pageSize',
      callerUnionId: 'callerUnionId',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      pageSize: 'number',
      callerUnionId: 'string',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponseBody extends $tea.Model {
  pageSize?: number;
  applicationInformation?: ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      applicationInformation: 'applicationInformation',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      applicationInformation: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListApplicationAuthorizationServiceApplicationInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListApplicationAuthorizationServiceApplicationInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationServiceOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateApplicationAuthorizationServiceOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateApplicationAuthorizationServiceOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListRequest extends $tea.Model {
  processCode?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      processCode: 'processCode',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processCode: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponseBody extends $tea.Model {
  result?: GetActivityListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetActivityListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetActivityListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetActivityListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiRequest extends $tea.Model {
  data?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  serviceId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      serviceId: 'serviceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      serviceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteCustomApiResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExecuteCustomApiResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExecuteCustomApiResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeployFunctionCallbackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeployFunctionCallbackRequest extends $tea.Model {
  gateWayAppKey?: string;
  gateWayAppSecret?: string;
  deployStage?: string;
  appId?: string;
  customDomain?: string;
  gateWayDomain?: string;
  static names(): { [key: string]: string } {
    return {
      gateWayAppKey: 'gateWayAppKey',
      gateWayAppSecret: 'gateWayAppSecret',
      deployStage: 'deployStage',
      appId: 'appId',
      customDomain: 'customDomain',
      gateWayDomain: 'gateWayDomain',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gateWayAppKey: 'string',
      gateWayAppSecret: 'string',
      deployStage: 'string',
      appId: 'string',
      customDomain: 'string',
      gateWayDomain: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeployFunctionCallbackResponseBody extends $tea.Model {
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

export class DeployFunctionCallbackResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeployFunctionCallbackResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeployFunctionCallbackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginCodeGenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: LoginCodeGenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LoginCodeGenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateCloudAuthorizationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateCloudAuthorizationRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TerminateCloudAuthorizationResponseBody extends $tea.Model {
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

export class TerminateCloudAuthorizationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: TerminateCloudAuthorizationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TerminateCloudAuthorizationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListRequest extends $tea.Model {
  systemToken?: string;
  userId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      systemToken: 'string',
      userId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListResponseBody extends $tea.Model {
  result?: GetActivityButtonListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetActivityButtonListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetActivityButtonListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetActivityButtonListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  formDataJson?: string;
  processCode?: string;
  departmentId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      formDataJson: 'formDataJson',
      processCode: 'processCode',
      departmentId: 'departmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      formDataJson: 'string',
      processCode: 'string',
      departmentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationRequest extends $tea.Model {
  accessKey?: string;
  pageSize?: number;
  callerUid?: string;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      pageSize: 'pageSize',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      pageSize: 'number',
      callerUid: 'string',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponseBody extends $tea.Model {
  pageSize?: number;
  applicationInformation?: ListApplicationInformationResponseBodyApplicationInformation[];
  pageNumber?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      applicationInformation: 'applicationInformation',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      applicationInformation: { 'type': 'array', 'itemType': ListApplicationInformationResponseBodyApplicationInformation },
      pageNumber: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListApplicationInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListApplicationInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpgradeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateOrderUpgradeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateOrderUpgradeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCloudAccountInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCloudAccountInformationRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  accountNumber?: string;
  commodityType?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
      accountNumber: 'accountNumber',
      commodityType: 'commodityType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
      accountNumber: 'string',
      commodityType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCloudAccountInformationResponseBody extends $tea.Model {
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

export class UpdateCloudAccountInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateCloudAccountInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateCloudAccountInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdRequest extends $tea.Model {
  accountId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpLevelByAccountIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCorpLevelByAccountIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCorpLevelByAccountIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecutePlatformTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecutePlatformTaskRequest extends $tea.Model {
  outResult?: string;
  noExecuteExpressions?: string;
  appType?: string;
  formDataJson?: string;
  systemToken?: string;
  language?: string;
  remark?: string;
  processInstanceId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      outResult: 'outResult',
      noExecuteExpressions: 'noExecuteExpressions',
      appType: 'appType',
      formDataJson: 'formDataJson',
      systemToken: 'systemToken',
      language: 'language',
      remark: 'remark',
      processInstanceId: 'processInstanceId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outResult: 'string',
      noExecuteExpressions: 'string',
      appType: 'string',
      formDataJson: 'string',
      systemToken: 'string',
      language: 'string',
      remark: 'string',
      processInstanceId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecutePlatformTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  searchFieldJson?: string;
  currentPage?: number;
  pageSize?: number;
  originatorId?: string;
  createFromTimeGMT?: string;
  createToTimeGMT?: string;
  modifiedFromTimeGMT?: string;
  modifiedToTimeGMT?: string;
  dynamicOrder?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      searchFieldJson: 'searchFieldJson',
      currentPage: 'currentPage',
      pageSize: 'pageSize',
      originatorId: 'originatorId',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      dynamicOrder: 'dynamicOrder',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      searchFieldJson: 'string',
      currentPage: 'number',
      pageSize: 'number',
      originatorId: 'string',
      createFromTimeGMT: 'string',
      createToTimeGMT: 'string',
      modifiedFromTimeGMT: 'string',
      modifiedToTimeGMT: 'string',
      dynamicOrder: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBody extends $tea.Model {
  currentPage?: number;
  totalCount?: number;
  data?: SearchFormDatasResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      totalCount: 'totalCount',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      totalCount: 'number',
      data: { 'type': 'array', 'itemType': SearchFormDatasResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchFormDatasResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchFormDatasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeResponseBody extends $tea.Model {
  instanceId?: string;
  activationCode?: string;
  authType?: string;
  expireTimeGMT?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      activationCode: 'activationCode',
      authType: 'authType',
      expireTimeGMT: 'expireTimeGMT',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      activationCode: 'string',
      authType: 'string',
      expireTimeGMT: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActivationCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchActivationCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchActivationCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoRequest extends $tea.Model {
  formUuid?: string;
  appType?: string;
  vm?: string;
  formVersion?: number;
  templateId?: number;
  userId?: string;
  setting?: string;
  title?: string;
  description?: string;
  fileNameConfig?: string;
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      appType: 'appType',
      vm: 'vm',
      formVersion: 'formVersion',
      templateId: 'templateId',
      userId: 'userId',
      setting: 'setting',
      title: 'title',
      description: 'description',
      fileNameConfig: 'fileNameConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      appType: 'string',
      vm: 'string',
      formVersion: 'number',
      templateId: 'number',
      userId: 'string',
      setting: 'string',
      title: 'string',
      description: 'string',
      fileNameConfig: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SavePrintTplDetailInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SavePrintTplDetailInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SavePrintTplDetailInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesRequest extends $tea.Model {
  targetFieldJson?: string;
  formUuid?: string;
  appType?: string;
  modifiedToTimeGMT?: string;
  systemToken?: string;
  modifiedFromTimeGMT?: string;
  language?: string;
  searchFieldJson?: string;
  originatorId?: string;
  userId?: string;
  createToTimeGMT?: string;
  createFromTimeGMT?: string;
  static names(): { [key: string]: string } {
    return {
      targetFieldJson: 'targetFieldJson',
      formUuid: 'formUuid',
      appType: 'appType',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      systemToken: 'systemToken',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      language: 'language',
      searchFieldJson: 'searchFieldJson',
      originatorId: 'originatorId',
      userId: 'userId',
      createToTimeGMT: 'createToTimeGMT',
      createFromTimeGMT: 'createFromTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetFieldJson: 'string',
      formUuid: 'string',
      appType: 'string',
      modifiedToTimeGMT: 'string',
      systemToken: 'string',
      modifiedFromTimeGMT: 'string',
      language: 'string',
      searchFieldJson: 'string',
      originatorId: 'string',
      userId: 'string',
      createToTimeGMT: 'string',
      createFromTimeGMT: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchEmployeeFieldValuesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchEmployeeFieldValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchEmployeeFieldValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formInstanceId?: string;
  useLatestVersion?: boolean;
  updateFormDataJson?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formInstanceId: 'formInstanceId',
      useLatestVersion: 'useLatestVersion',
      updateFormDataJson: 'updateFormDataJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formInstanceId: 'string',
      useLatestVersion: 'boolean',
      updateFormDataJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListRequest extends $tea.Model {
  formUuid?: string;
  modifiedToTimeGMT?: string;
  systemToken?: string;
  modifiedFromTimeGMT?: string;
  language?: string;
  searchFieldJson?: string;
  userId?: string;
  instanceStatus?: string;
  approvedResult?: string;
  appType?: string;
  originatorId?: string;
  createToTimeGMT?: string;
  taskId?: string;
  createFromTimeGMT?: string;
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      systemToken: 'systemToken',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      language: 'language',
      searchFieldJson: 'searchFieldJson',
      userId: 'userId',
      instanceStatus: 'instanceStatus',
      approvedResult: 'approvedResult',
      appType: 'appType',
      originatorId: 'originatorId',
      createToTimeGMT: 'createToTimeGMT',
      taskId: 'taskId',
      createFromTimeGMT: 'createFromTimeGMT',
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      modifiedToTimeGMT: 'string',
      systemToken: 'string',
      modifiedFromTimeGMT: 'string',
      language: 'string',
      searchFieldJson: 'string',
      userId: 'string',
      instanceStatus: 'string',
      approvedResult: 'string',
      appType: 'string',
      originatorId: 'string',
      createToTimeGMT: 'string',
      taskId: 'string',
      createFromTimeGMT: 'string',
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: string[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInstanceIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInstanceIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponseBody extends $tea.Model {
  result?: GetOperationRecordsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetOperationRecordsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOperationRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOperationRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceResponseBody extends $tea.Model {
  appTotalAmount?: number;
  instanceTotalAmount?: number;
  instanceUsageAmount?: number;
  accountUsageAmount?: number;
  accountTotalAmount?: number;
  pluginUsageAmount?: number;
  attachmentTotalAmount?: number;
  attachmentUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      appTotalAmount: 'appTotalAmount',
      instanceTotalAmount: 'instanceTotalAmount',
      instanceUsageAmount: 'instanceUsageAmount',
      accountUsageAmount: 'accountUsageAmount',
      accountTotalAmount: 'accountTotalAmount',
      pluginUsageAmount: 'pluginUsageAmount',
      attachmentTotalAmount: 'attachmentTotalAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTotalAmount: 'number',
      instanceTotalAmount: 'number',
      instanceUsageAmount: 'number',
      accountUsageAmount: 'number',
      accountTotalAmount: 'number',
      pluginUsageAmount: 'number',
      attachmentTotalAmount: 'number',
      attachmentUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPlatformResourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPlatformResourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPlatformResourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationRequest extends $tea.Model {
  accessKey?: string;
  pageSize?: number;
  callerUid?: string;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      pageSize: 'pageSize',
      callerUid: 'callerUid',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      pageSize: 'number',
      callerUid: 'string',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponseBody extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  totalCount?: number;
  pluginInfos?: ListConnectorInformationResponseBodyPluginInfos[];
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
      totalCount: 'totalCount',
      pluginInfos: 'pluginInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
      totalCount: 'number',
      pluginInfos: { 'type': 'array', 'itemType': ListConnectorInformationResponseBodyPluginInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListConnectorInformationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListConnectorInformationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsRequest extends $tea.Model {
  corpId?: string;
  accessKey?: string;
  activeCode?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      accessKey: 'accessKey',
      activeCode: 'activeCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      accessKey: 'string',
      activeCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsResponseBody extends $tea.Model {
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterAccountsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RegisterAccountsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RegisterAccountsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeRequest extends $tea.Model {
  corpId?: string;
  token?: string;
  pageNumber?: number;
  pageSize?: number;
  language?: string;
  keyword?: string;
  appTypes?: string;
  processCodes?: string;
  instanceCreateFromTimeGMT?: number;
  instanceCreateToTimeGMT?: number;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      token: 'token',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      language: 'language',
      keyword: 'keyword',
      appTypes: 'appTypes',
      processCodes: 'processCodes',
      instanceCreateFromTimeGMT: 'instanceCreateFromTimeGMT',
      instanceCreateToTimeGMT: 'instanceCreateToTimeGMT',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      token: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      language: 'string',
      keyword: 'string',
      appTypes: 'string',
      processCodes: 'string',
      instanceCreateFromTimeGMT: 'number',
      instanceCreateToTimeGMT: 'number',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: GetNotifyMeResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': GetNotifyMeResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetNotifyMeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetNotifyMeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityResponseBody extends $tea.Model {
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExpireCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ExpireCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ExpireCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBody extends $tea.Model {
  createTimeGMT?: string;
  processInstanceId?: string;
  actionExecutor?: GetInstanceByIdResponseBodyActionExecutor[];
  approvedResult?: string;
  formUuid?: string;
  data?: { [key: string]: any };
  modifiedTimeGMT?: string;
  processCode?: string;
  originator?: GetInstanceByIdResponseBodyOriginator;
  title?: string;
  instanceStatus?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      processInstanceId: 'processInstanceId',
      actionExecutor: 'actionExecutor',
      approvedResult: 'approvedResult',
      formUuid: 'formUuid',
      data: 'data',
      modifiedTimeGMT: 'modifiedTimeGMT',
      processCode: 'processCode',
      originator: 'originator',
      title: 'title',
      instanceStatus: 'instanceStatus',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      processInstanceId: 'string',
      actionExecutor: { 'type': 'array', 'itemType': GetInstanceByIdResponseBodyActionExecutor },
      approvedResult: 'string',
      formUuid: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      modifiedTimeGMT: 'string',
      processCode: 'string',
      originator: GetInstanceByIdResponseBodyOriginator,
      title: 'string',
      instanceStatus: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInstanceByIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInstanceByIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectTaskRequest extends $tea.Model {
  processInstanceId?: string;
  byManager?: string;
  appType?: string;
  systemToken?: string;
  language?: string;
  remark?: string;
  nowActionExecutorId?: string;
  userId?: string;
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      byManager: 'byManager',
      appType: 'appType',
      systemToken: 'systemToken',
      language: 'language',
      remark: 'remark',
      nowActionExecutorId: 'nowActionExecutorId',
      userId: 'userId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      byManager: 'string',
      appType: 'string',
      systemToken: 'string',
      language: 'string',
      remark: 'string',
      nowActionExecutorId: 'string',
      userId: 'string',
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RedirectTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpdateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpdateRequest extends $tea.Model {
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpdateResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateOrderUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateOrderUpdateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateOrderUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListRequest extends $tea.Model {
  systemToken?: string;
  userId?: string;
  language?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListResponseBody extends $tea.Model {
  result?: GetFormComponentDefinitionListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetFormComponentDefinitionListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFormComponentDefinitionListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFormComponentDefinitionListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoRequest extends $tea.Model {
  userId?: string;
  nameLike?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      nameLike: 'nameLike',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      nameLike: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponseBody extends $tea.Model {
  result?: GetPrintAppInfoResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetPrintAppInfoResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPrintAppInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPrintAppInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formUuid?: string;
  formDataJson?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formUuid: 'formUuid',
      formDataJson: 'formDataJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formUuid: 'string',
      formDataJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveFormDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveFormDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionRequest extends $tea.Model {
  corpId?: string;
  pageSize?: number;
  language?: string;
  pageNumber?: number;
  keyword?: string;
  appTypes?: string;
  processCodes?: string;
  createFromTimeGMT?: number;
  createToTimeGMT?: number;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      pageSize: 'pageSize',
      language: 'language',
      pageNumber: 'pageNumber',
      keyword: 'keyword',
      appTypes: 'appTypes',
      processCodes: 'processCodes',
      createFromTimeGMT: 'createFromTimeGMT',
      createToTimeGMT: 'createToTimeGMT',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      pageSize: 'number',
      language: 'string',
      pageNumber: 'number',
      keyword: 'string',
      appTypes: 'string',
      processCodes: 'string',
      createFromTimeGMT: 'number',
      createToTimeGMT: 'number',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: GetMeCorpSubmissionResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': GetMeCorpSubmissionResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMeCorpSubmissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMeCorpSubmissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  formInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      formInstanceId: 'formInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      formInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFormDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListRequest extends $tea.Model {
  modifiedToTimeGMT?: string;
  systemToken?: string;
  modifiedFromTimeGMT?: string;
  language?: string;
  searchFieldJson?: string;
  userId?: string;
  originatorId?: string;
  createToTimeGMT?: string;
  createFromTimeGMT?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      modifiedToTimeGMT: 'modifiedToTimeGMT',
      systemToken: 'systemToken',
      modifiedFromTimeGMT: 'modifiedFromTimeGMT',
      language: 'language',
      searchFieldJson: 'searchFieldJson',
      userId: 'userId',
      originatorId: 'originatorId',
      createToTimeGMT: 'createToTimeGMT',
      createFromTimeGMT: 'createFromTimeGMT',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      modifiedToTimeGMT: 'string',
      systemToken: 'string',
      modifiedFromTimeGMT: 'string',
      language: 'string',
      searchFieldJson: 'string',
      userId: 'string',
      originatorId: 'string',
      createToTimeGMT: 'string',
      createFromTimeGMT: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListResponseBody extends $tea.Model {
  totalCount?: number;
  pageNumber?: number;
  data?: string[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      pageNumber: 'pageNumber',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      pageNumber: 'number',
      data: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDataIdListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchFormDataIdListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchFormDataIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdRequest extends $tea.Model {
  accessKey?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivationCodeByCallerUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetActivationCodeByCallerUnionIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetActivationCodeByCallerUnionIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBody extends $tea.Model {
  originator?: GetFormDataByIDResponseBodyOriginator;
  modifiedTimeGMT?: string;
  formUuid?: string;
  formInstId?: string;
  formData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      originator: 'originator',
      modifiedTimeGMT: 'modifiedTimeGMT',
      formUuid: 'formUuid',
      formInstId: 'formInstId',
      formData: 'formData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      originator: GetFormDataByIDResponseBodyOriginator,
      modifiedTimeGMT: 'string',
      formUuid: 'string',
      formInstId: 'string',
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFormDataByIDResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFormDataByIDResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityResponseBody extends $tea.Model {
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefundCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RefundCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RefundCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceRequest extends $tea.Model {
  userId?: string;
  sequence?: string;
  systemToken?: string;
  language?: string;
  appType?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      sequence: 'sequence',
      systemToken: 'systemToken',
      language: 'language',
      appType: 'appType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      sequence: 'string',
      systemToken: 'string',
      language: 'string',
      appType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSequenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityRequest extends $tea.Model {
  instanceId?: string;
  accessKey?: string;
  callerUid?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      accessKey: 'accessKey',
      callerUid: 'callerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      accessKey: 'string',
      callerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityResponseBody extends $tea.Model {
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseCommodityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseCommodityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseCommodityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenderBatchCallbackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenderBatchCallbackRequest extends $tea.Model {
  ossUrl?: string;
  corpId?: string;
  fileSize?: number;
  appType?: string;
  systemToken?: string;
  namespace?: string;
  timeZone?: string;
  language?: string;
  source?: string;
  sequenceId?: string;
  userId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      ossUrl: 'ossUrl',
      corpId: 'corpId',
      fileSize: 'fileSize',
      appType: 'appType',
      systemToken: 'systemToken',
      namespace: 'namespace',
      timeZone: 'timeZone',
      language: 'language',
      source: 'source',
      sequenceId: 'sequenceId',
      userId: 'userId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ossUrl: 'string',
      corpId: 'string',
      fileSize: 'number',
      appType: 'string',
      systemToken: 'string',
      namespace: 'string',
      timeZone: 'string',
      language: 'string',
      source: 'string',
      sequenceId: 'string',
      userId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenderBatchCallbackResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlRequest extends $tea.Model {
  systemToken?: string;
  userId?: string;
  language?: string;
  fileUrl?: string;
  timeout?: number;
  static names(): { [key: string]: string } {
    return {
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      fileUrl: 'fileUrl',
      timeout: 'timeout',
    };
  }

  static types(): { [key: string]: any } {
    return {
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      fileUrl: 'string',
      timeout: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOpenUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOpenUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOpenUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdRequest extends $tea.Model {
  corpId?: string;
  namespace?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      namespace: 'namespace',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      namespace: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponseBody extends $tea.Model {
  userName?: string;
  userId?: string;
  accountId?: number;
  corpList?: GetSaleUserInfoByUserIdResponseBodyCorpList[];
  static names(): { [key: string]: string } {
    return {
      userName: 'userName',
      userId: 'userId',
      accountId: 'accountId',
      corpList: 'corpList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userName: 'string',
      userId: 'string',
      accountId: 'number',
      corpList: { 'type': 'array', 'itemType': GetSaleUserInfoByUserIdResponseBodyCorpList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSaleUserInfoByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSaleUserInfoByUserIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderRequest extends $tea.Model {
  accessKey?: string;
  callerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKey: 'accessKey',
      callerUnionId: 'callerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKey: 'string',
      callerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderResponseBody extends $tea.Model {
  message?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ValidateApplicationAuthorizationOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ValidateApplicationAuthorizationOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ValidateApplicationAuthorizationOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskRequest extends $tea.Model {
  outResult?: string;
  noExecuteExpressions?: string;
  appType?: string;
  formDataJson?: string;
  systemToken?: string;
  language?: string;
  remark?: string;
  processInstanceId?: string;
  userId?: string;
  taskId?: number;
  digitalSignUrl?: string;
  static names(): { [key: string]: string } {
    return {
      outResult: 'outResult',
      noExecuteExpressions: 'noExecuteExpressions',
      appType: 'appType',
      formDataJson: 'formDataJson',
      systemToken: 'systemToken',
      language: 'language',
      remark: 'remark',
      processInstanceId: 'processInstanceId',
      userId: 'userId',
      taskId: 'taskId',
      digitalSignUrl: 'digitalSignUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outResult: 'string',
      noExecuteExpressions: 'string',
      appType: 'string',
      formDataJson: 'string',
      systemToken: 'string',
      language: 'string',
      remark: 'string',
      processInstanceId: 'string',
      userId: 'string',
      taskId: 'number',
      digitalSignUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceRequest extends $tea.Model {
  appType?: string;
  systemToken?: string;
  userId?: string;
  language?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      appType: 'appType',
      systemToken: 'systemToken',
      userId: 'userId',
      language: 'language',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appType: 'string',
      systemToken: 'string',
      userId: 'string',
      language: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResultActionExecutorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResultActionExecutor extends $tea.Model {
  userId?: string;
  name?: GetInstancesByIdListResponseBodyResultActionExecutorName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: GetInstancesByIdListResponseBodyResultActionExecutorName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResultOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResultOriginator extends $tea.Model {
  userId?: string;
  name?: GetInstancesByIdListResponseBodyResultOriginatorName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: GetInstancesByIdListResponseBodyResultOriginatorName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdListResponseBodyResult extends $tea.Model {
  actionExecutor?: GetInstancesByIdListResponseBodyResultActionExecutor[];
  processInstanceId?: string;
  formUuid?: string;
  processCode?: string;
  title?: string;
  instanceStatus?: string;
  approvedResult?: string;
  originator?: GetInstancesByIdListResponseBodyResultOriginator;
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      actionExecutor: 'actionExecutor',
      processInstanceId: 'processInstanceId',
      formUuid: 'formUuid',
      processCode: 'processCode',
      title: 'title',
      instanceStatus: 'instanceStatus',
      approvedResult: 'approvedResult',
      originator: 'originator',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionExecutor: { 'type': 'array', 'itemType': GetInstancesByIdListResponseBodyResultActionExecutor },
      processInstanceId: 'string',
      formUuid: 'string',
      processCode: 'string',
      title: 'string',
      instanceStatus: 'string',
      approvedResult: 'string',
      originator: GetInstancesByIdListResponseBodyResultOriginator,
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponseBodyDataCurrentActivityInstances extends $tea.Model {
  activityName?: string;
  activityNameInEnglish?: string;
  activityId?: string;
  id?: number;
  activityInstanceStatus?: string;
  static names(): { [key: string]: string } {
    return {
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
      activityId: 'activityId',
      id: 'id',
      activityInstanceStatus: 'activityInstanceStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityName: 'string',
      activityNameInEnglish: 'string',
      activityId: 'string',
      id: 'number',
      activityInstanceStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskCopiesResponseBodyData extends $tea.Model {
  actionExecutorId?: string[];
  processInstanceId?: string;
  formUuid?: string;
  serialNumber?: string;
  processInstanceStatus?: string;
  originatorDisplayName?: string;
  modifiedTimeGMT?: string;
  carbonActivityId?: string;
  dataType?: string;
  actionExecutorName?: string[];
  originatorAvatar?: string;
  processInstanceStatusText?: string;
  processApprovedResultText?: string;
  formInstanceId?: string;
  title?: string;
  version?: number;
  instanceValue?: string;
  createTimeGMT?: string;
  processApprovedResult?: string;
  processId?: number;
  processName?: string;
  processCode?: string;
  appType?: string;
  dataMap?: { [key: string]: any };
  currentActivityInstances?: GetTaskCopiesResponseBodyDataCurrentActivityInstances[];
  finishTimeGMT?: string;
  originatorId?: string;
  static names(): { [key: string]: string } {
    return {
      actionExecutorId: 'actionExecutorId',
      processInstanceId: 'processInstanceId',
      formUuid: 'formUuid',
      serialNumber: 'serialNumber',
      processInstanceStatus: 'processInstanceStatus',
      originatorDisplayName: 'originatorDisplayName',
      modifiedTimeGMT: 'modifiedTimeGMT',
      carbonActivityId: 'carbonActivityId',
      dataType: 'dataType',
      actionExecutorName: 'actionExecutorName',
      originatorAvatar: 'originatorAvatar',
      processInstanceStatusText: 'processInstanceStatusText',
      processApprovedResultText: 'processApprovedResultText',
      formInstanceId: 'formInstanceId',
      title: 'title',
      version: 'version',
      instanceValue: 'instanceValue',
      createTimeGMT: 'createTimeGMT',
      processApprovedResult: 'processApprovedResult',
      processId: 'processId',
      processName: 'processName',
      processCode: 'processCode',
      appType: 'appType',
      dataMap: 'dataMap',
      currentActivityInstances: 'currentActivityInstances',
      finishTimeGMT: 'finishTimeGMT',
      originatorId: 'originatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionExecutorId: { 'type': 'array', 'itemType': 'string' },
      processInstanceId: 'string',
      formUuid: 'string',
      serialNumber: 'string',
      processInstanceStatus: 'string',
      originatorDisplayName: 'string',
      modifiedTimeGMT: 'string',
      carbonActivityId: 'string',
      dataType: 'string',
      actionExecutorName: { 'type': 'array', 'itemType': 'string' },
      originatorAvatar: 'string',
      processInstanceStatusText: 'string',
      processApprovedResultText: 'string',
      formInstanceId: 'string',
      title: 'string',
      version: 'number',
      instanceValue: 'string',
      createTimeGMT: 'string',
      processApprovedResult: 'string',
      processId: 'number',
      processName: 'string',
      processCode: 'string',
      appType: 'string',
      dataMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      currentActivityInstances: { 'type': 'array', 'itemType': GetTaskCopiesResponseBodyDataCurrentActivityInstances },
      finishTimeGMT: 'string',
      originatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTasksResponseBodyResult extends $tea.Model {
  createTimeGMT?: string;
  activityId?: string;
  processInstanceId?: string;
  taskType?: string;
  titleInEnglish?: string;
  activeTimeGMT?: string;
  actualActionerId?: string;
  originatorId?: string;
  finishTimeGMT?: string;
  title?: string;
  taskId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      activityId: 'activityId',
      processInstanceId: 'processInstanceId',
      taskType: 'taskType',
      titleInEnglish: 'titleInEnglish',
      activeTimeGMT: 'activeTimeGMT',
      actualActionerId: 'actualActionerId',
      originatorId: 'originatorId',
      finishTimeGMT: 'finishTimeGMT',
      title: 'title',
      taskId: 'taskId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      activityId: 'string',
      processInstanceId: 'string',
      taskType: 'string',
      titleInEnglish: 'string',
      activeTimeGMT: 'string',
      actualActionerId: 'string',
      originatorId: 'string',
      finishTimeGMT: 'string',
      title: 'string',
      taskId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBodyResultTitle extends $tea.Model {
  nameInEnglish?: string;
  type?: string;
  nameInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      nameInEnglish: 'nameInEnglish',
      type: 'type',
      nameInChinese: 'nameInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInEnglish: 'string',
      type: 'string',
      nameInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNavigationByFormTypeResponseBodyResult extends $tea.Model {
  title?: ListNavigationByFormTypeResponseBodyResultTitle;
  processCode?: string;
  formUuid?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      processCode: 'processCode',
      formUuid: 'formUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: ListNavigationByFormTypeResponseBodyResultTitle,
      processCode: 'string',
      formUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccomplishmentTasksResponseBodyData extends $tea.Model {
  originatorNickName?: string;
  processInstanceId?: string;
  originatorName?: string;
  finishTimeGMT?: string;
  activeTimeGMT?: string;
  actualActionerId?: string;
  originatorEmail?: string;
  title?: string;
  outResultName?: string;
  outResult?: string;
  originatorPhoto?: string;
  taskType?: string;
  originatorNickNameInEnglish?: string;
  createTimeGMT?: string;
  titleInEnglish?: string;
  appType?: string;
  originatorNameInEnglish?: string;
  originatorId?: string;
  taskId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      originatorNickName: 'originatorNickName',
      processInstanceId: 'processInstanceId',
      originatorName: 'originatorName',
      finishTimeGMT: 'finishTimeGMT',
      activeTimeGMT: 'activeTimeGMT',
      actualActionerId: 'actualActionerId',
      originatorEmail: 'originatorEmail',
      title: 'title',
      outResultName: 'outResultName',
      outResult: 'outResult',
      originatorPhoto: 'originatorPhoto',
      taskType: 'taskType',
      originatorNickNameInEnglish: 'originatorNickNameInEnglish',
      createTimeGMT: 'createTimeGMT',
      titleInEnglish: 'titleInEnglish',
      appType: 'appType',
      originatorNameInEnglish: 'originatorNameInEnglish',
      originatorId: 'originatorId',
      taskId: 'taskId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      originatorNickName: 'string',
      processInstanceId: 'string',
      originatorName: 'string',
      finishTimeGMT: 'string',
      activeTimeGMT: 'string',
      actualActionerId: 'string',
      originatorEmail: 'string',
      title: 'string',
      outResultName: 'string',
      outResult: 'string',
      originatorPhoto: 'string',
      taskType: 'string',
      originatorNickNameInEnglish: 'string',
      createTimeGMT: 'string',
      titleInEnglish: 'string',
      appType: 'string',
      originatorNameInEnglish: 'string',
      originatorId: 'string',
      taskId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyDataActionExecutorName extends $tea.Model {
  nameInEnglish?: string;
  type?: string;
  nameInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      nameInEnglish: 'nameInEnglish',
      type: 'type',
      nameInChinese: 'nameInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInEnglish: 'string',
      type: 'string',
      nameInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyDataActionExecutor extends $tea.Model {
  name?: GetInstancesResponseBodyDataActionExecutorName;
  deptName?: string;
  userId?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      deptName: 'deptName',
      userId: 'userId',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: GetInstancesResponseBodyDataActionExecutorName,
      deptName: 'string',
      userId: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyDataOriginatorName extends $tea.Model {
  nameInEnglish?: string;
  type?: string;
  nameInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      nameInEnglish: 'nameInEnglish',
      type: 'type',
      nameInChinese: 'nameInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInEnglish: 'string',
      type: 'string',
      nameInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyDataOriginator extends $tea.Model {
  name?: GetInstancesResponseBodyDataOriginatorName;
  deptName?: string;
  userId?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      deptName: 'deptName',
      userId: 'userId',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: GetInstancesResponseBodyDataOriginatorName,
      deptName: 'string',
      userId: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesResponseBodyData extends $tea.Model {
  createTimeGMT?: string;
  processInstanceId?: string;
  actionExecutor?: GetInstancesResponseBodyDataActionExecutor[];
  approvedResult?: string;
  formUuid?: string;
  data?: { [key: string]: any };
  processCode?: string;
  modifiedTimeGMT?: string;
  originator?: GetInstancesResponseBodyDataOriginator;
  title?: string;
  instanceStatus?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      processInstanceId: 'processInstanceId',
      actionExecutor: 'actionExecutor',
      approvedResult: 'approvedResult',
      formUuid: 'formUuid',
      data: 'data',
      processCode: 'processCode',
      modifiedTimeGMT: 'modifiedTimeGMT',
      originator: 'originator',
      title: 'title',
      instanceStatus: 'instanceStatus',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      processInstanceId: 'string',
      actionExecutor: { 'type': 'array', 'itemType': GetInstancesResponseBodyDataActionExecutor },
      approvedResult: 'string',
      formUuid: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      processCode: 'string',
      modifiedTimeGMT: 'string',
      originator: GetInstancesResponseBodyDataOriginator,
      title: 'string',
      instanceStatus: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications extends $tea.Model {
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation extends $tea.Model {
  plugUuid?: string;
  plugTotalAmount?: number;
  plugName?: string;
  iconUrl?: string;
  plugPayType?: number;
  plugUsageAmount?: number;
  plugStatus?: number;
  applications?: ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications[];
  static names(): { [key: string]: string } {
    return {
      plugUuid: 'plugUuid',
      plugTotalAmount: 'plugTotalAmount',
      plugName: 'plugName',
      iconUrl: 'iconUrl',
      plugPayType: 'plugPayType',
      plugUsageAmount: 'plugUsageAmount',
      plugStatus: 'plugStatus',
      applications: 'applications',
    };
  }

  static types(): { [key: string]: any } {
    return {
      plugUuid: 'string',
      plugTotalAmount: 'number',
      plugName: 'string',
      iconUrl: 'string',
      plugPayType: 'number',
      plugUsageAmount: 'number',
      plugStatus: 'number',
      applications: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpTasksResponseBodyData extends $tea.Model {
  originatorNickName?: string;
  processInstanceId?: string;
  originatorName?: string;
  finishTimeGMT?: string;
  activeTimeGMT?: string;
  actualActionerId?: string;
  originatorEmail?: string;
  title?: string;
  outResultName?: string;
  outResult?: string;
  originatorPhoto?: string;
  taskType?: string;
  originatorNickNameEn?: string;
  createTimeGMT?: string;
  titleInEnglish?: string;
  appType?: string;
  originatorNameInEnglish?: string;
  originatorId?: string;
  taskId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      originatorNickName: 'originatorNickName',
      processInstanceId: 'processInstanceId',
      originatorName: 'originatorName',
      finishTimeGMT: 'finishTimeGMT',
      activeTimeGMT: 'activeTimeGMT',
      actualActionerId: 'actualActionerId',
      originatorEmail: 'originatorEmail',
      title: 'title',
      outResultName: 'outResultName',
      outResult: 'outResult',
      originatorPhoto: 'originatorPhoto',
      taskType: 'taskType',
      originatorNickNameEn: 'originatorNickNameEn',
      createTimeGMT: 'createTimeGMT',
      titleInEnglish: 'titleInEnglish',
      appType: 'appType',
      originatorNameInEnglish: 'originatorNameInEnglish',
      originatorId: 'originatorId',
      taskId: 'taskId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      originatorNickName: 'string',
      processInstanceId: 'string',
      originatorName: 'string',
      finishTimeGMT: 'string',
      activeTimeGMT: 'string',
      actualActionerId: 'string',
      originatorEmail: 'string',
      title: 'string',
      outResultName: 'string',
      outResult: 'string',
      originatorPhoto: 'string',
      taskType: 'string',
      originatorNickNameEn: 'string',
      createTimeGMT: 'string',
      titleInEnglish: 'string',
      appType: 'string',
      originatorNameInEnglish: 'string',
      originatorId: 'string',
      taskId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCommodityResponseBodyCommodityVOList extends $tea.Model {
  instanceId?: string;
  buyDateGMT?: string;
  expireDateGMT?: string;
  activationCode?: string;
  accountNumber?: number;
  accountDistributionNumber?: number;
  version?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      buyDateGMT: 'buyDateGMT',
      expireDateGMT: 'expireDateGMT',
      activationCode: 'activationCode',
      accountNumber: 'accountNumber',
      accountDistributionNumber: 'accountDistributionNumber',
      version: 'version',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      buyDateGMT: 'string',
      expireDateGMT: 'string',
      activationCode: 'string',
      accountNumber: 'number',
      accountDistributionNumber: 'number',
      version: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRunningTaskListResponseBodyResult extends $tea.Model {
  originatorNickName?: string;
  processInstanceId?: string;
  originatorName?: string;
  titleInEnglish?: string;
  originatorNickNameInEnglish?: string;
  originatorEmail?: string;
  title?: string;
  outResultName?: string;
  actualActionExecutorId?: string;
  outResult?: string;
  createTimeGMT?: string;
  originatorPhoto?: string;
  taskType?: string;
  originatorNameInEnglish?: string;
  appType?: string;
  activeTimeGMT?: string;
  finishTimeGMT?: string;
  originatorId?: string;
  taskId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      originatorNickName: 'originatorNickName',
      processInstanceId: 'processInstanceId',
      originatorName: 'originatorName',
      titleInEnglish: 'titleInEnglish',
      originatorNickNameInEnglish: 'originatorNickNameInEnglish',
      originatorEmail: 'originatorEmail',
      title: 'title',
      outResultName: 'outResultName',
      actualActionExecutorId: 'actualActionExecutorId',
      outResult: 'outResult',
      createTimeGMT: 'createTimeGMT',
      originatorPhoto: 'originatorPhoto',
      taskType: 'taskType',
      originatorNameInEnglish: 'originatorNameInEnglish',
      appType: 'appType',
      activeTimeGMT: 'activeTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      originatorId: 'originatorId',
      taskId: 'taskId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      originatorNickName: 'string',
      processInstanceId: 'string',
      originatorName: 'string',
      titleInEnglish: 'string',
      originatorNickNameInEnglish: 'string',
      originatorEmail: 'string',
      title: 'string',
      outResultName: 'string',
      actualActionExecutorId: 'string',
      outResult: 'string',
      createTimeGMT: 'string',
      originatorPhoto: 'string',
      taskType: 'string',
      originatorNameInEnglish: 'string',
      appType: 'string',
      activeTimeGMT: 'string',
      finishTimeGMT: 'string',
      originatorId: 'string',
      taskId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments extends $tea.Model {
  humanSourceGroupOrderNumber?: string;
  deptPath?: string;
  deptName?: string;
  deptNameInEnglish?: string;
  humanSourceGroupWorkNo?: string;
  id?: number;
  masterWorkNo?: string;
  deptNo?: string;
  static names(): { [key: string]: string } {
    return {
      humanSourceGroupOrderNumber: 'humanSourceGroupOrderNumber',
      deptPath: 'deptPath',
      deptName: 'deptName',
      deptNameInEnglish: 'deptNameInEnglish',
      humanSourceGroupWorkNo: 'humanSourceGroupWorkNo',
      id: 'id',
      masterWorkNo: 'masterWorkNo',
      deptNo: 'deptNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      humanSourceGroupOrderNumber: 'string',
      deptPath: 'string',
      deptName: 'string',
      deptNameInEnglish: 'string',
      humanSourceGroupWorkNo: 'string',
      id: 'number',
      masterWorkNo: 'string',
      deptNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOwners extends $tea.Model {
  userInfo?: string;
  tbWang?: string;
  orderNumber?: string;
  departmentDescription?: string;
  displayName?: string;
  masterDataDepartments?: GetProcessDefinitionResponseBodyOwnersMasterDataDepartments[];
  displayEnName?: string;
  userId?: string;
  personalPhoto?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      userInfo: 'userInfo',
      tbWang: 'tbWang',
      orderNumber: 'orderNumber',
      departmentDescription: 'departmentDescription',
      displayName: 'displayName',
      masterDataDepartments: 'masterDataDepartments',
      displayEnName: 'displayEnName',
      userId: 'userId',
      personalPhoto: 'personalPhoto',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userInfo: 'string',
      tbWang: 'string',
      orderNumber: 'string',
      departmentDescription: 'string',
      displayName: 'string',
      masterDataDepartments: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyOwnersMasterDataDepartments },
      displayEnName: 'string',
      userId: 'string',
      personalPhoto: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments extends $tea.Model {
  humanSourceGroupOrderNumber?: string;
  deptPath?: string;
  deptName?: string;
  deptNameInEnglish?: string;
  humanSourceGroupWorkNo?: string;
  id?: number;
  masterWorkNo?: string;
  deptNo?: string;
  static names(): { [key: string]: string } {
    return {
      humanSourceGroupOrderNumber: 'humanSourceGroupOrderNumber',
      deptPath: 'deptPath',
      deptName: 'deptName',
      deptNameInEnglish: 'deptNameInEnglish',
      humanSourceGroupWorkNo: 'humanSourceGroupWorkNo',
      id: 'id',
      masterWorkNo: 'masterWorkNo',
      deptNo: 'deptNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      humanSourceGroupOrderNumber: 'string',
      deptPath: 'string',
      deptName: 'string',
      deptNameInEnglish: 'string',
      humanSourceGroupWorkNo: 'string',
      id: 'number',
      masterWorkNo: 'string',
      deptNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyOriginator extends $tea.Model {
  userInfo?: string;
  tbWang?: string;
  orderNumber?: string;
  departmentDescription?: string;
  displayName?: string;
  masterDataDepartments?: GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments[];
  displayEnName?: string;
  userId?: string;
  personalPhoto?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      userInfo: 'userInfo',
      tbWang: 'tbWang',
      orderNumber: 'orderNumber',
      departmentDescription: 'departmentDescription',
      displayName: 'displayName',
      masterDataDepartments: 'masterDataDepartments',
      displayEnName: 'displayEnName',
      userId: 'userId',
      personalPhoto: 'personalPhoto',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userInfo: 'string',
      tbWang: 'string',
      orderNumber: 'string',
      departmentDescription: 'string',
      displayName: 'string',
      masterDataDepartments: { 'type': 'array', 'itemType': GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments },
      displayEnName: 'string',
      userId: 'string',
      personalPhoto: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyTasksActivity extends $tea.Model {
  activityName?: string;
  activityNameInEnglish?: string;
  activityId?: string;
  id?: number;
  activityInstanceStatus?: string;
  static names(): { [key: string]: string } {
    return {
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
      activityId: 'activityId',
      id: 'id',
      activityInstanceStatus: 'activityInstanceStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityName: 'string',
      activityNameInEnglish: 'string',
      activityId: 'string',
      id: 'number',
      activityInstanceStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessDefinitionResponseBodyTasks extends $tea.Model {
  actionerId?: string;
  activity?: GetProcessDefinitionResponseBodyTasksActivity;
  taskId?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      actionerId: 'actionerId',
      activity: 'activity',
      taskId: 'taskId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerId: 'string',
      activity: GetProcessDefinitionResponseBodyTasksActivity,
      taskId: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins extends $tea.Model {
  pluginName?: string;
  iconUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pluginName: 'pluginName',
      iconUrl: 'iconUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pluginName: 'string',
      iconUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation extends $tea.Model {
  usagePlugins?: ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins[];
  appName?: string;
  appType?: string;
  instanceUsageAmount?: number;
  attachmentUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      usagePlugins: 'usagePlugins',
      appName: 'appName',
      appType: 'appType',
      instanceUsageAmount: 'instanceUsageAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      usagePlugins: { 'type': 'array', 'itemType': ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins },
      appName: 'string',
      appType: 'string',
      instanceUsageAmount: 'number',
      attachmentUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityListResponseBodyResult extends $tea.Model {
  activityName?: string;
  activityNameInEnglish?: string;
  activityId?: string;
  static names(): { [key: string]: string } {
    return {
      activityName: 'activityName',
      activityNameInEnglish: 'activityNameInEnglish',
      activityId: 'activityId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityName: 'string',
      activityNameInEnglish: 'string',
      activityId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActivityButtonListResponseBodyResult extends $tea.Model {
  aliasInEnglish?: string;
  aliasInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      aliasInEnglish: 'aliasInEnglish',
      aliasInChinese: 'aliasInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aliasInEnglish: 'string',
      aliasInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponseBodyApplicationInformationUsagePlugins extends $tea.Model {
  pluginName?: string;
  iconUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pluginName: 'pluginName',
      iconUrl: 'iconUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pluginName: 'string',
      iconUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApplicationInformationResponseBodyApplicationInformation extends $tea.Model {
  usagePlugins?: ListApplicationInformationResponseBodyApplicationInformationUsagePlugins[];
  appName?: string;
  appType?: string;
  instanceUsageAmount?: number;
  attachmentUsageAmount?: number;
  static names(): { [key: string]: string } {
    return {
      usagePlugins: 'usagePlugins',
      appName: 'appName',
      appType: 'appType',
      instanceUsageAmount: 'instanceUsageAmount',
      attachmentUsageAmount: 'attachmentUsageAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      usagePlugins: { 'type': 'array', 'itemType': ListApplicationInformationResponseBodyApplicationInformationUsagePlugins },
      appName: 'string',
      appType: 'string',
      instanceUsageAmount: 'number',
      attachmentUsageAmount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataOriginatorUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataOriginator extends $tea.Model {
  userId?: string;
  userName?: SearchFormDatasResponseBodyDataOriginatorUserName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataOriginatorUserName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataModifyUserUserName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyDataModifyUser extends $tea.Model {
  userId?: string;
  userName?: SearchFormDatasResponseBodyDataModifyUserUserName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: SearchFormDatasResponseBodyDataModifyUserUserName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFormDatasResponseBodyData extends $tea.Model {
  dataId?: number;
  formInstanceId?: string;
  createdTimeGMT?: string;
  modifiedTimeGMT?: string;
  formUuid?: string;
  modelUuid?: string;
  originator?: SearchFormDatasResponseBodyDataOriginator;
  modifyUser?: SearchFormDatasResponseBodyDataModifyUser;
  formData?: { [key: string]: any };
  title?: string;
  serialNo?: string;
  instanceValue?: string;
  version?: number;
  creatorUserId?: string;
  modifierUserId?: string;
  sequence?: string;
  static names(): { [key: string]: string } {
    return {
      dataId: 'dataId',
      formInstanceId: 'formInstanceId',
      createdTimeGMT: 'createdTimeGMT',
      modifiedTimeGMT: 'modifiedTimeGMT',
      formUuid: 'formUuid',
      modelUuid: 'modelUuid',
      originator: 'originator',
      modifyUser: 'modifyUser',
      formData: 'formData',
      title: 'title',
      serialNo: 'serialNo',
      instanceValue: 'instanceValue',
      version: 'version',
      creatorUserId: 'creatorUserId',
      modifierUserId: 'modifierUserId',
      sequence: 'sequence',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataId: 'number',
      formInstanceId: 'string',
      createdTimeGMT: 'string',
      modifiedTimeGMT: 'string',
      formUuid: 'string',
      modelUuid: 'string',
      originator: SearchFormDatasResponseBodyDataOriginator,
      modifyUser: SearchFormDatasResponseBodyDataModifyUser,
      formData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      title: 'string',
      serialNo: 'string',
      instanceValue: 'string',
      version: 'number',
      creatorUserId: 'string',
      modifierUserId: 'string',
      sequence: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOperationRecordsResponseBodyResult extends $tea.Model {
  processInstanceId?: string;
  showName?: string;
  operatorNickName?: string;
  activeTimeGMT?: string;
  operateTimeGMT?: string;
  operateType?: string;
  operatorStatus?: string;
  remark?: string;
  taskHoldTimeGMT?: number;
  type?: string;
  operatorName?: string;
  operatorUserId?: string;
  activityId?: string;
  taskType?: string;
  taskExecuteType?: string;
  size?: number;
  operatorDisplayName?: string;
  files?: string;
  action?: string;
  actionExit?: string;
  dataId?: number;
  taskId?: string;
  digitalSign?: string;
  operatorPhotoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      showName: 'showName',
      operatorNickName: 'operatorNickName',
      activeTimeGMT: 'activeTimeGMT',
      operateTimeGMT: 'operateTimeGMT',
      operateType: 'operateType',
      operatorStatus: 'operatorStatus',
      remark: 'remark',
      taskHoldTimeGMT: 'taskHoldTimeGMT',
      type: 'type',
      operatorName: 'operatorName',
      operatorUserId: 'operatorUserId',
      activityId: 'activityId',
      taskType: 'taskType',
      taskExecuteType: 'taskExecuteType',
      size: 'size',
      operatorDisplayName: 'operatorDisplayName',
      files: 'files',
      action: 'action',
      actionExit: 'actionExit',
      dataId: 'dataId',
      taskId: 'taskId',
      digitalSign: 'digitalSign',
      operatorPhotoUrl: 'operatorPhotoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      showName: 'string',
      operatorNickName: 'string',
      activeTimeGMT: 'string',
      operateTimeGMT: 'string',
      operateType: 'string',
      operatorStatus: 'string',
      remark: 'string',
      taskHoldTimeGMT: 'number',
      type: 'string',
      operatorName: 'string',
      operatorUserId: 'string',
      activityId: 'string',
      taskType: 'string',
      taskExecuteType: 'string',
      size: 'number',
      operatorDisplayName: 'string',
      files: 'string',
      action: 'string',
      actionExit: 'string',
      dataId: 'number',
      taskId: 'string',
      digitalSign: 'string',
      operatorPhotoUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponseBodyPluginInfosApps extends $tea.Model {
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListConnectorInformationResponseBodyPluginInfos extends $tea.Model {
  pluginUuid?: string;
  pluginTotalAmount?: number;
  pluginName?: string;
  iconUrl?: string;
  pluginPayType?: number;
  pluginUsageAmount?: number;
  pluginStatus?: number;
  apps?: ListConnectorInformationResponseBodyPluginInfosApps[];
  static names(): { [key: string]: string } {
    return {
      pluginUuid: 'pluginUuid',
      pluginTotalAmount: 'pluginTotalAmount',
      pluginName: 'pluginName',
      iconUrl: 'iconUrl',
      pluginPayType: 'pluginPayType',
      pluginUsageAmount: 'pluginUsageAmount',
      pluginStatus: 'pluginStatus',
      apps: 'apps',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pluginUuid: 'string',
      pluginTotalAmount: 'number',
      pluginName: 'string',
      iconUrl: 'string',
      pluginPayType: 'number',
      pluginUsageAmount: 'number',
      pluginStatus: 'number',
      apps: { 'type': 'array', 'itemType': ListConnectorInformationResponseBodyPluginInfosApps },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNotifyMeResponseBodyData extends $tea.Model {
  createTimeGMT?: string;
  activityId?: string;
  creatorUserId?: string;
  corpId?: string;
  titleInEnglish?: string;
  modifiedTimeGMT?: string;
  appType?: string;
  processCode?: string;
  mobileUrl?: string;
  formInstanceId?: string;
  instStatus?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      createTimeGMT: 'createTimeGMT',
      activityId: 'activityId',
      creatorUserId: 'creatorUserId',
      corpId: 'corpId',
      titleInEnglish: 'titleInEnglish',
      modifiedTimeGMT: 'modifiedTimeGMT',
      appType: 'appType',
      processCode: 'processCode',
      mobileUrl: 'mobileUrl',
      formInstanceId: 'formInstanceId',
      instStatus: 'instStatus',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeGMT: 'string',
      activityId: 'string',
      creatorUserId: 'string',
      corpId: 'string',
      titleInEnglish: 'string',
      modifiedTimeGMT: 'string',
      appType: 'string',
      processCode: 'string',
      mobileUrl: 'string',
      formInstanceId: 'string',
      instStatus: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBodyActionExecutorName extends $tea.Model {
  nameInEnglish?: string;
  type?: string;
  nameInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      nameInEnglish: 'nameInEnglish',
      type: 'type',
      nameInChinese: 'nameInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInEnglish: 'string',
      type: 'string',
      nameInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBodyActionExecutor extends $tea.Model {
  name?: GetInstanceByIdResponseBodyActionExecutorName;
  deptName?: string;
  userId?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      deptName: 'deptName',
      userId: 'userId',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: GetInstanceByIdResponseBodyActionExecutorName,
      deptName: 'string',
      userId: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBodyOriginatorName extends $tea.Model {
  nameInEnglish?: string;
  type?: string;
  nameInChinese?: string;
  static names(): { [key: string]: string } {
    return {
      nameInEnglish: 'nameInEnglish',
      type: 'type',
      nameInChinese: 'nameInChinese',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInEnglish: 'string',
      type: 'string',
      nameInChinese: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstanceByIdResponseBodyOriginator extends $tea.Model {
  name?: GetInstanceByIdResponseBodyOriginatorName;
  deptName?: string;
  userId?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      deptName: 'deptName',
      userId: 'userId',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: GetInstanceByIdResponseBodyOriginatorName,
      deptName: 'string',
      userId: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormComponentDefinitionListResponseBodyResult extends $tea.Model {
  label?: string;
  componentName?: string;
  fieldId?: string;
  parentId?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      componentName: 'componentName',
      fieldId: 'fieldId',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      componentName: 'string',
      fieldId: 'string',
      parentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponseBodyResultFormInfoList extends $tea.Model {
  formUuid?: string;
  formName?: string;
  static names(): { [key: string]: string } {
    return {
      formUuid: 'formUuid',
      formName: 'formName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formUuid: 'string',
      formName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrintAppInfoResponseBodyResult extends $tea.Model {
  formInfoList?: GetPrintAppInfoResponseBodyResultFormInfoList[];
  appType?: string;
  appName?: string;
  iconUrl?: string;
  static names(): { [key: string]: string } {
    return {
      formInfoList: 'formInfoList',
      appType: 'appType',
      appName: 'appName',
      iconUrl: 'iconUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formInfoList: { 'type': 'array', 'itemType': GetPrintAppInfoResponseBodyResultFormInfoList },
      appType: 'string',
      appName: 'string',
      iconUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBodyDataActioner extends $tea.Model {
  employeeTypeInformation?: string;
  employeeType?: string;
  level?: string;
  nickName?: string;
  orderNumber?: string;
  pinyinNickName?: string;
  superUserId?: string;
  userId?: string;
  buName?: string;
  tbWang?: string;
  humanResourceGroupWorkNumber?: string;
  pinyinNameAll?: string;
  name?: string;
  state?: string;
  personalPhotoUrl?: string;
  isSystemAdmin?: boolean;
  email?: string;
  personalPhoto?: string;
  static names(): { [key: string]: string } {
    return {
      employeeTypeInformation: 'employeeTypeInformation',
      employeeType: 'employeeType',
      level: 'level',
      nickName: 'nickName',
      orderNumber: 'orderNumber',
      pinyinNickName: 'pinyinNickName',
      superUserId: 'superUserId',
      userId: 'userId',
      buName: 'buName',
      tbWang: 'tbWang',
      humanResourceGroupWorkNumber: 'humanResourceGroupWorkNumber',
      pinyinNameAll: 'pinyinNameAll',
      name: 'name',
      state: 'state',
      personalPhotoUrl: 'personalPhotoUrl',
      isSystemAdmin: 'isSystemAdmin',
      email: 'email',
      personalPhoto: 'personalPhoto',
    };
  }

  static types(): { [key: string]: any } {
    return {
      employeeTypeInformation: 'string',
      employeeType: 'string',
      level: 'string',
      nickName: 'string',
      orderNumber: 'string',
      pinyinNickName: 'string',
      superUserId: 'string',
      userId: 'string',
      buName: 'string',
      tbWang: 'string',
      humanResourceGroupWorkNumber: 'string',
      pinyinNameAll: 'string',
      name: 'string',
      state: 'string',
      personalPhotoUrl: 'string',
      isSystemAdmin: 'boolean',
      email: 'string',
      personalPhoto: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances extends $tea.Model {
  activityName?: string;
  activityNameEn?: string;
  activityId?: string;
  id?: number;
  activityInstanceStatus?: string;
  static names(): { [key: string]: string } {
    return {
      activityName: 'activityName',
      activityNameEn: 'activityNameEn',
      activityId: 'activityId',
      id: 'id',
      activityInstanceStatus: 'activityInstanceStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityName: 'string',
      activityNameEn: 'string',
      activityId: 'string',
      id: 'number',
      activityInstanceStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeCorpSubmissionResponseBodyData extends $tea.Model {
  actionerName?: string[];
  processInstanceId?: string;
  modifiedTimeGMT?: string;
  finishTimeGMT?: string;
  formUuid?: string;
  processInstanceStatus?: string;
  originatorDisplayName?: string;
  dataType?: string;
  originatorAvatar?: string;
  processInstanceStatusText?: string;
  actioner?: GetMeCorpSubmissionResponseBodyDataActioner[];
  processApprovedResultText?: string;
  formInstanceId?: string;
  title?: string;
  version?: number;
  instanceValue?: string;
  processApprovedResult?: string;
  createTimeGMT?: string;
  processId?: number;
  processName?: string;
  processCode?: string;
  appType?: string;
  actionerId?: string[];
  dataMap?: { [key: string]: any };
  currentActivityInstances?: GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances[];
  originatorId?: string;
  static names(): { [key: string]: string } {
    return {
      actionerName: 'actionerName',
      processInstanceId: 'processInstanceId',
      modifiedTimeGMT: 'modifiedTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      formUuid: 'formUuid',
      processInstanceStatus: 'processInstanceStatus',
      originatorDisplayName: 'originatorDisplayName',
      dataType: 'dataType',
      originatorAvatar: 'originatorAvatar',
      processInstanceStatusText: 'processInstanceStatusText',
      actioner: 'actioner',
      processApprovedResultText: 'processApprovedResultText',
      formInstanceId: 'formInstanceId',
      title: 'title',
      version: 'version',
      instanceValue: 'instanceValue',
      processApprovedResult: 'processApprovedResult',
      createTimeGMT: 'createTimeGMT',
      processId: 'processId',
      processName: 'processName',
      processCode: 'processCode',
      appType: 'appType',
      actionerId: 'actionerId',
      dataMap: 'dataMap',
      currentActivityInstances: 'currentActivityInstances',
      originatorId: 'originatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionerName: { 'type': 'array', 'itemType': 'string' },
      processInstanceId: 'string',
      modifiedTimeGMT: 'string',
      finishTimeGMT: 'string',
      formUuid: 'string',
      processInstanceStatus: 'string',
      originatorDisplayName: 'string',
      dataType: 'string',
      originatorAvatar: 'string',
      processInstanceStatusText: 'string',
      actioner: { 'type': 'array', 'itemType': GetMeCorpSubmissionResponseBodyDataActioner },
      processApprovedResultText: 'string',
      formInstanceId: 'string',
      title: 'string',
      version: 'number',
      instanceValue: 'string',
      processApprovedResult: 'string',
      createTimeGMT: 'string',
      processId: 'number',
      processName: 'string',
      processCode: 'string',
      appType: 'string',
      actionerId: { 'type': 'array', 'itemType': 'string' },
      dataMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      currentActivityInstances: { 'type': 'array', 'itemType': GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances },
      originatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBodyOriginatorName extends $tea.Model {
  nameInChinese?: string;
  nameInEnglish?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      nameInChinese: 'nameInChinese',
      nameInEnglish: 'nameInEnglish',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nameInChinese: 'string',
      nameInEnglish: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormDataByIDResponseBodyOriginator extends $tea.Model {
  userId?: string;
  name?: GetFormDataByIDResponseBodyOriginatorName;
  departmentName?: string;
  email?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentName: 'departmentName',
      email: 'email',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: GetFormDataByIDResponseBodyOriginatorName,
      departmentName: 'string',
      email: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSaleUserInfoByUserIdResponseBodyCorpList extends $tea.Model {
  namespace?: string;
  corpId?: string;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      namespace: 'namespace',
      corpId: 'corpId',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      namespace: 'string',
      corpId: 'string',
      corpName: 'string',
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


  async updateStatus(request: UpdateStatusRequest): Promise<UpdateStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateStatusHeaders({ });
    return await this.updateStatusWithOptions(request, headers, runtime);
  }

  async updateStatusWithOptions(request: UpdateStatusRequest, headers: UpdateStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.importSequence)) {
      body["importSequence"] = request.importSequence;
    }

    if (!Util.isUnset(request.errorLines)) {
      body["errorLines"] = request.errorLines;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<UpdateStatusResponse>(await this.doROARequest("UpdateStatus", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/forms/status`, "none", req, runtime), new UpdateStatusResponse({}));
  }

  async getInstancesByIdList(request: GetInstancesByIdListRequest): Promise<GetInstancesByIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesByIdListHeaders({ });
    return await this.getInstancesByIdListWithOptions(request, headers, runtime);
  }

  async getInstancesByIdListWithOptions(request: GetInstancesByIdListRequest, headers: GetInstancesByIdListHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstancesByIdListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceIds)) {
      query["processInstanceIds"] = request.processInstanceIds;
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
    return $tea.cast<GetInstancesByIdListResponse>(await this.doROARequest("GetInstancesByIdList", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/instances/searchWithIds`, "json", req, runtime), new GetInstancesByIdListResponse({}));
  }

  async saveFormRemark(request: SaveFormRemarkRequest): Promise<SaveFormRemarkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormRemarkHeaders({ });
    return await this.saveFormRemarkWithOptions(request, headers, runtime);
  }

  async saveFormRemarkWithOptions(request: SaveFormRemarkRequest, headers: SaveFormRemarkHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormRemarkResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.replyId)) {
      body["replyId"] = request.replyId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      body["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.atUserId)) {
      body["atUserId"] = request.atUserId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
    return $tea.cast<SaveFormRemarkResponse>(await this.doROARequest("SaveFormRemark", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/remarks`, "json", req, runtime), new SaveFormRemarkResponse({}));
  }

  async listTableDataByFormInstanceIdTableId(formInstanceId: string, request: ListTableDataByFormInstanceIdTableIdRequest): Promise<ListTableDataByFormInstanceIdTableIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTableDataByFormInstanceIdTableIdHeaders({ });
    return await this.listTableDataByFormInstanceIdTableIdWithOptions(formInstanceId, request, headers, runtime);
  }

  async listTableDataByFormInstanceIdTableIdWithOptions(formInstanceId: string, request: ListTableDataByFormInstanceIdTableIdRequest, headers: ListTableDataByFormInstanceIdTableIdHeaders, runtime: $Util.RuntimeOptions): Promise<ListTableDataByFormInstanceIdTableIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formUuid)) {
      query["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.tableFieldId)) {
      query["tableFieldId"] = request.tableFieldId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<ListTableDataByFormInstanceIdTableIdResponse>(await this.doROARequest("ListTableDataByFormInstanceIdTableId", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/forms/innerTables/${formInstanceId}`, "json", req, runtime), new ListTableDataByFormInstanceIdTableIdResponse({}));
  }

  async getTaskCopies(request: GetTaskCopiesRequest): Promise<GetTaskCopiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskCopiesHeaders({ });
    return await this.getTaskCopiesWithOptions(request, headers, runtime);
  }

  async getTaskCopiesWithOptions(request: GetTaskCopiesRequest, headers: GetTaskCopiesHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskCopiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
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
    return $tea.cast<GetTaskCopiesResponse>(await this.doROARequest("GetTaskCopies", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/tasks/taskCopies`, "json", req, runtime), new GetTaskCopiesResponse({}));
  }

  async getRunningTasks(request: GetRunningTasksRequest): Promise<GetRunningTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTasksHeaders({ });
    return await this.getRunningTasksWithOptions(request, headers, runtime);
  }

  async getRunningTasksWithOptions(request: GetRunningTasksRequest, headers: GetRunningTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetRunningTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetRunningTasksResponse>(await this.doROARequest("GetRunningTasks", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/tasks/getRunningTasks`, "json", req, runtime), new GetRunningTasksResponse({}));
  }

  async listNavigationByFormType(request: ListNavigationByFormTypeRequest): Promise<ListNavigationByFormTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListNavigationByFormTypeHeaders({ });
    return await this.listNavigationByFormTypeWithOptions(request, headers, runtime);
  }

  async listNavigationByFormTypeWithOptions(request: ListNavigationByFormTypeRequest, headers: ListNavigationByFormTypeHeaders, runtime: $Util.RuntimeOptions): Promise<ListNavigationByFormTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.formType)) {
      query["formType"] = request.formType;
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
    return $tea.cast<ListNavigationByFormTypeResponse>(await this.doROARequest("ListNavigationByFormType", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/navigations`, "json", req, runtime), new ListNavigationByFormTypeResponse({}));
  }

  async terminateInstance(request: TerminateInstanceRequest): Promise<TerminateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateInstanceHeaders({ });
    return await this.terminateInstanceWithOptions(request, headers, runtime);
  }

  async terminateInstanceWithOptions(request: TerminateInstanceRequest, headers: TerminateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<TerminateInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<TerminateInstanceResponse>(await this.doROARequest("TerminateInstance", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/processes/instances/terminate`, "none", req, runtime), new TerminateInstanceResponse({}));
  }

  async checkCloudAccountStatus(callerUid: string, request: CheckCloudAccountStatusRequest): Promise<CheckCloudAccountStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckCloudAccountStatusHeaders({ });
    return await this.checkCloudAccountStatusWithOptions(callerUid, request, headers, runtime);
  }

  async checkCloudAccountStatusWithOptions(callerUid: string, request: CheckCloudAccountStatusRequest, headers: CheckCloudAccountStatusHeaders, runtime: $Util.RuntimeOptions): Promise<CheckCloudAccountStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
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
    return $tea.cast<CheckCloudAccountStatusResponse>(await this.doROARequest("CheckCloudAccountStatus", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/cloudAccountStatus/${callerUid}`, "json", req, runtime), new CheckCloudAccountStatusResponse({}));
  }

  async getCorpAccomplishmentTasks(corpId: string, userId: string, request: GetCorpAccomplishmentTasksRequest): Promise<GetCorpAccomplishmentTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpAccomplishmentTasksHeaders({ });
    return await this.getCorpAccomplishmentTasksWithOptions(corpId, userId, request, headers, runtime);
  }

  async getCorpAccomplishmentTasksWithOptions(corpId: string, userId: string, request: GetCorpAccomplishmentTasksRequest, headers: GetCorpAccomplishmentTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpAccomplishmentTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
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
    return $tea.cast<GetCorpAccomplishmentTasksResponse>(await this.doROARequest("GetCorpAccomplishmentTasks", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/tasks/completedTasks/${corpId}/${userId}`, "json", req, runtime), new GetCorpAccomplishmentTasksResponse({}));
  }

  async getInstances(request: GetInstancesRequest): Promise<GetInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesHeaders({ });
    return await this.getInstancesWithOptions(request, headers, runtime);
  }

  async getInstancesWithOptions(request: GetInstancesRequest, headers: GetInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstancesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    if (!Util.isUnset(request.instanceStatus)) {
      body["instanceStatus"] = request.instanceStatus;
    }

    if (!Util.isUnset(request.approvedResult)) {
      body["approvedResult"] = request.approvedResult;
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
    return $tea.cast<GetInstancesResponse>(await this.doROARequest("GetInstances", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/processes/instances`, "json", req, runtime), new GetInstancesResponse({}));
  }

  async listApplicationAuthorizationServiceConnectorInformation(instanceId: string, request: ListApplicationAuthorizationServiceConnectorInformationRequest): Promise<ListApplicationAuthorizationServiceConnectorInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders({ });
    return await this.listApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listApplicationAuthorizationServiceConnectorInformationWithOptions(instanceId: string, request: ListApplicationAuthorizationServiceConnectorInformationRequest, headers: ListApplicationAuthorizationServiceConnectorInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationAuthorizationServiceConnectorInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ListApplicationAuthorizationServiceConnectorInformationResponse>(await this.doROARequest("ListApplicationAuthorizationServiceConnectorInformation", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/applicationAuthorizations/plugs/${instanceId}`, "json", req, runtime), new ListApplicationAuthorizationServiceConnectorInformationResponse({}));
  }

  async validateOrderBuy(request: ValidateOrderBuyRequest): Promise<ValidateOrderBuyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderBuyHeaders({ });
    return await this.validateOrderBuyWithOptions(request, headers, runtime);
  }

  async validateOrderBuyWithOptions(request: ValidateOrderBuyRequest, headers: ValidateOrderBuyHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderBuyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ValidateOrderBuyResponse>(await this.doROARequest("ValidateOrderBuy", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/orderBuy/validate`, "json", req, runtime), new ValidateOrderBuyResponse({}));
  }

  async renewTenantOrder(request: RenewTenantOrderRequest): Promise<RenewTenantOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenewTenantOrderHeaders({ });
    return await this.renewTenantOrderWithOptions(request, headers, runtime);
  }

  async renewTenantOrderWithOptions(request: RenewTenantOrderRequest, headers: RenewTenantOrderHeaders, runtime: $Util.RuntimeOptions): Promise<RenewTenantOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
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
    return $tea.cast<RenewTenantOrderResponse>(await this.doROARequest("RenewTenantOrder", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/apps/tenants/reorder`, "json", req, runtime), new RenewTenantOrderResponse({}));
  }

  async getPrintDictionary(request: GetPrintDictionaryRequest): Promise<GetPrintDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrintDictionaryHeaders({ });
    return await this.getPrintDictionaryWithOptions(request, headers, runtime);
  }

  async getPrintDictionaryWithOptions(request: GetPrintDictionaryRequest, headers: GetPrintDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrintDictionaryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formUuid)) {
      query["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetPrintDictionaryResponse>(await this.doROARequest("GetPrintDictionary", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/printTemplates/printDictionaries`, "json", req, runtime), new GetPrintDictionaryResponse({}));
  }

  async updateInstance(request: UpdateInstanceRequest): Promise<UpdateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceHeaders({ });
    return await this.updateInstanceWithOptions(request, headers, runtime);
  }

  async updateInstanceWithOptions(request: UpdateInstanceRequest, headers: UpdateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<UpdateInstanceResponse>(await this.doROARequest("UpdateInstance", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/processes/instances`, "none", req, runtime), new UpdateInstanceResponse({}));
  }

  async buyAuthorizationOrder(request: BuyAuthorizationOrderRequest): Promise<BuyAuthorizationOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BuyAuthorizationOrderHeaders({ });
    return await this.buyAuthorizationOrderWithOptions(request, headers, runtime);
  }

  async buyAuthorizationOrderWithOptions(request: BuyAuthorizationOrderRequest, headers: BuyAuthorizationOrderHeaders, runtime: $Util.RuntimeOptions): Promise<BuyAuthorizationOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.produceCode)) {
      body["produceCode"] = request.produceCode;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.instanceName)) {
      body["instanceName"] = request.instanceName;
    }

    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.chargeType)) {
      body["chargeType"] = request.chargeType;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.beginTimeGMT)) {
      body["beginTimeGMT"] = request.beginTimeGMT;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.commerceType)) {
      body["commerceType"] = request.commerceType;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
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
    return $tea.cast<BuyAuthorizationOrderResponse>(await this.doROARequest("BuyAuthorizationOrder", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/appAuthorizations/order`, "json", req, runtime), new BuyAuthorizationOrderResponse({}));
  }

  async validateApplicationServiceOrderUpgrade(callerUnionid: string, request: ValidateApplicationServiceOrderUpgradeRequest): Promise<ValidateApplicationServiceOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationServiceOrderUpgradeHeaders({ });
    return await this.validateApplicationServiceOrderUpgradeWithOptions(callerUnionid, request, headers, runtime);
  }

  async validateApplicationServiceOrderUpgradeWithOptions(callerUnionid: string, request: ValidateApplicationServiceOrderUpgradeRequest, headers: ValidateApplicationServiceOrderUpgradeHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateApplicationServiceOrderUpgradeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
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
    return $tea.cast<ValidateApplicationServiceOrderUpgradeResponse>(await this.doROARequest("ValidateApplicationServiceOrderUpgrade", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/applications/orderValidations/${callerUnionid}`, "json", req, runtime), new ValidateApplicationServiceOrderUpgradeResponse({}));
  }

  async getCorpTasks(request: GetCorpTasksRequest): Promise<GetCorpTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpTasksHeaders({ });
    return await this.getCorpTasksWithOptions(request, headers, runtime);
  }

  async getCorpTasksWithOptions(request: GetCorpTasksRequest, headers: GetCorpTasksHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpTasksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
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
    return $tea.cast<GetCorpTasksResponse>(await this.doROARequest("GetCorpTasks", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/corpTasks`, "json", req, runtime), new GetCorpTasksResponse({}));
  }

  async listCommodity(request: ListCommodityRequest): Promise<ListCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCommodityHeaders({ });
    return await this.listCommodityWithOptions(request, headers, runtime);
  }

  async listCommodityWithOptions(request: ListCommodityRequest, headers: ListCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ListCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ListCommodityResponse>(await this.doROARequest("ListCommodity", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/appAuth/commodities`, "json", req, runtime), new ListCommodityResponse({}));
  }

  async notifyAuthorizationResult(request: NotifyAuthorizationResultRequest): Promise<NotifyAuthorizationResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyAuthorizationResultHeaders({ });
    return await this.notifyAuthorizationResultWithOptions(request, headers, runtime);
  }

  async notifyAuthorizationResultWithOptions(request: NotifyAuthorizationResultRequest, headers: NotifyAuthorizationResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyAuthorizationResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.instanceName)) {
      body["instanceName"] = request.instanceName;
    }

    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.chargeType)) {
      body["chargeType"] = request.chargeType;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.beginTimeGMT)) {
      body["beginTimeGMT"] = request.beginTimeGMT;
    }

    if (!Util.isUnset(request.callerUid)) {
      body["callerUid"] = request.callerUid;
    }

    if (!Util.isUnset(request.commerceType)) {
      body["commerceType"] = request.commerceType;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
    }

    if (!Util.isUnset(request.produceCode)) {
      body["produceCode"] = request.produceCode;
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
    return $tea.cast<NotifyAuthorizationResultResponse>(await this.doROARequest("NotifyAuthorizationResult", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/apps/authorizationResults/notify`, "json", req, runtime), new NotifyAuthorizationResultResponse({}));
  }

  async getRunningTaskList(request: GetRunningTaskListRequest): Promise<GetRunningTaskListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRunningTaskListHeaders({ });
    return await this.getRunningTaskListWithOptions(request, headers, runtime);
  }

  async getRunningTaskListWithOptions(request: GetRunningTaskListRequest, headers: GetRunningTaskListHeaders, runtime: $Util.RuntimeOptions): Promise<GetRunningTaskListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceIdList)) {
      body["processInstanceIdList"] = request.processInstanceIdList;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userCorpId)) {
      body["userCorpId"] = request.userCorpId;
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
    return $tea.cast<GetRunningTaskListResponse>(await this.doROARequest("GetRunningTaskList", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/tasks/runningTasks/query`, "json", req, runtime), new GetRunningTaskListResponse({}));
  }

  async buyFreshOrder(request: BuyFreshOrderRequest): Promise<BuyFreshOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BuyFreshOrderHeaders({ });
    return await this.buyFreshOrderWithOptions(request, headers, runtime);
  }

  async buyFreshOrderWithOptions(request: BuyFreshOrderRequest, headers: BuyFreshOrderHeaders, runtime: $Util.RuntimeOptions): Promise<BuyFreshOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.produceCode)) {
      body["produceCode"] = request.produceCode;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.instanceName)) {
      body["instanceName"] = request.instanceName;
    }

    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.chargeType)) {
      body["chargeType"] = request.chargeType;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
    }

    if (!Util.isUnset(request.beginTimeGMT)) {
      body["beginTimeGMT"] = request.beginTimeGMT;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.commerceType)) {
      body["commerceType"] = request.commerceType;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
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
    return $tea.cast<BuyFreshOrderResponse>(await this.doROARequest("BuyFreshOrder", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/apps/freshOrders`, "json", req, runtime), new BuyFreshOrderResponse({}));
  }

  async removeTenantResource(callerUid: string, request: RemoveTenantResourceRequest): Promise<RemoveTenantResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveTenantResourceHeaders({ });
    return await this.removeTenantResourceWithOptions(callerUid, request, headers, runtime);
  }

  async removeTenantResourceWithOptions(callerUid: string, request: RemoveTenantResourceRequest, headers: RemoveTenantResourceHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveTenantResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
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
    return $tea.cast<RemoveTenantResourceResponse>(await this.doROARequest("RemoveTenantResource", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/applications/tenantRelatedResources/${callerUid}`, "json", req, runtime), new RemoveTenantResourceResponse({}));
  }

  async renewApplicationAuthorizationServiceOrder(request: RenewApplicationAuthorizationServiceOrderRequest): Promise<RenewApplicationAuthorizationServiceOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenewApplicationAuthorizationServiceOrderHeaders({ });
    return await this.renewApplicationAuthorizationServiceOrderWithOptions(request, headers, runtime);
  }

  async renewApplicationAuthorizationServiceOrderWithOptions(request: RenewApplicationAuthorizationServiceOrderRequest, headers: RenewApplicationAuthorizationServiceOrderHeaders, runtime: $Util.RuntimeOptions): Promise<RenewApplicationAuthorizationServiceOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.endTimeGMT)) {
      body["endTimeGMT"] = request.endTimeGMT;
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
    return $tea.cast<RenewApplicationAuthorizationServiceOrderResponse>(await this.doROARequest("RenewApplicationAuthorizationServiceOrder", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/applicationAuthorizations/orders/renew`, "json", req, runtime), new RenewApplicationAuthorizationServiceOrderResponse({}));
  }

  async getProcessDefinition(processInstanceId: string, request: GetProcessDefinitionRequest): Promise<GetProcessDefinitionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessDefinitionHeaders({ });
    return await this.getProcessDefinitionWithOptions(processInstanceId, request, headers, runtime);
  }

  async getProcessDefinitionWithOptions(processInstanceId: string, request: GetProcessDefinitionRequest, headers: GetProcessDefinitionHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessDefinitionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.groupId)) {
      query["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.orderNumber)) {
      query["orderNumber"] = request.orderNumber;
    }

    if (!Util.isUnset(request.systemType)) {
      query["systemType"] = request.systemType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.nameSpace)) {
      query["nameSpace"] = request.nameSpace;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetProcessDefinitionResponse>(await this.doROARequest("GetProcessDefinition", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/definitions/${processInstanceId}`, "json", req, runtime), new GetProcessDefinitionResponse({}));
  }

  async upgradeTenantInformation(request: UpgradeTenantInformationRequest): Promise<UpgradeTenantInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeTenantInformationHeaders({ });
    return await this.upgradeTenantInformationWithOptions(request, headers, runtime);
  }

  async upgradeTenantInformationWithOptions(request: UpgradeTenantInformationRequest, headers: UpgradeTenantInformationHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeTenantInformationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
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
    return $tea.cast<UpgradeTenantInformationResponse>(await this.doROARequest("UpgradeTenantInformation", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/apps/tenantInfos`, "json", req, runtime), new UpgradeTenantInformationResponse({}));
  }

  async getApplicationAuthorizationServicePlatformResource(request: GetApplicationAuthorizationServicePlatformResourceRequest): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationAuthorizationServicePlatformResourceHeaders({ });
    return await this.getApplicationAuthorizationServicePlatformResourceWithOptions(request, headers, runtime);
  }

  async getApplicationAuthorizationServicePlatformResourceWithOptions(request: GetApplicationAuthorizationServicePlatformResourceRequest, headers: GetApplicationAuthorizationServicePlatformResourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplicationAuthorizationServicePlatformResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<GetApplicationAuthorizationServicePlatformResourceResponse>(await this.doROARequest("GetApplicationAuthorizationServicePlatformResource", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/authorization/platformResources`, "json", req, runtime), new GetApplicationAuthorizationServicePlatformResourceResponse({}));
  }

  async listApplicationAuthorizationServiceApplicationInformation(instanceId: string, request: ListApplicationAuthorizationServiceApplicationInformationRequest): Promise<ListApplicationAuthorizationServiceApplicationInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders({ });
    return await this.listApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listApplicationAuthorizationServiceApplicationInformationWithOptions(instanceId: string, request: ListApplicationAuthorizationServiceApplicationInformationRequest, headers: ListApplicationAuthorizationServiceApplicationInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationAuthorizationServiceApplicationInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      query["callerUnionId"] = request.callerUnionId;
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
    return $tea.cast<ListApplicationAuthorizationServiceApplicationInformationResponse>(await this.doROARequest("ListApplicationAuthorizationServiceApplicationInformation", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/authorizations/applicationInfos/${instanceId}`, "json", req, runtime), new ListApplicationAuthorizationServiceApplicationInformationResponse({}));
  }

  async validateApplicationAuthorizationServiceOrder(callerUid: string, request: ValidateApplicationAuthorizationServiceOrderRequest): Promise<ValidateApplicationAuthorizationServiceOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationAuthorizationServiceOrderHeaders({ });
    return await this.validateApplicationAuthorizationServiceOrderWithOptions(callerUid, request, headers, runtime);
  }

  async validateApplicationAuthorizationServiceOrderWithOptions(callerUid: string, request: ValidateApplicationAuthorizationServiceOrderRequest, headers: ValidateApplicationAuthorizationServiceOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateApplicationAuthorizationServiceOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
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
    return $tea.cast<ValidateApplicationAuthorizationServiceOrderResponse>(await this.doROARequest("ValidateApplicationAuthorizationServiceOrder", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/${callerUid}`, "json", req, runtime), new ValidateApplicationAuthorizationServiceOrderResponse({}));
  }

  async getActivityList(request: GetActivityListRequest): Promise<GetActivityListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityListHeaders({ });
    return await this.getActivityListWithOptions(request, headers, runtime);
  }

  async getActivityListWithOptions(request: GetActivityListRequest, headers: GetActivityListHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivityListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processCode)) {
      query["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetActivityListResponse>(await this.doROARequest("GetActivityList", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/activities`, "json", req, runtime), new GetActivityListResponse({}));
  }

  async executeCustomApi(request: ExecuteCustomApiRequest): Promise<ExecuteCustomApiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteCustomApiHeaders({ });
    return await this.executeCustomApiWithOptions(request, headers, runtime);
  }

  async executeCustomApiWithOptions(request: ExecuteCustomApiRequest, headers: ExecuteCustomApiHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteCustomApiResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.data)) {
      query["data"] = request.data;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.serviceId)) {
      query["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<ExecuteCustomApiResponse>(await this.doROARequest("ExecuteCustomApi", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/apps/customApi/execute`, "json", req, runtime), new ExecuteCustomApiResponse({}));
  }

  async deployFunctionCallback(request: DeployFunctionCallbackRequest): Promise<DeployFunctionCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeployFunctionCallbackHeaders({ });
    return await this.deployFunctionCallbackWithOptions(request, headers, runtime);
  }

  async deployFunctionCallbackWithOptions(request: DeployFunctionCallbackRequest, headers: DeployFunctionCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<DeployFunctionCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.gateWayAppKey)) {
      body["gateWayAppKey"] = request.gateWayAppKey;
    }

    if (!Util.isUnset(request.gateWayAppSecret)) {
      body["gateWayAppSecret"] = request.gateWayAppSecret;
    }

    if (!Util.isUnset(request.deployStage)) {
      body["deployStage"] = request.deployStage;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.customDomain)) {
      body["customDomain"] = request.customDomain;
    }

    if (!Util.isUnset(request.gateWayDomain)) {
      body["gateWayDomain"] = request.gateWayDomain;
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
    return $tea.cast<DeployFunctionCallbackResponse>(await this.doROARequest("DeployFunctionCallback", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/functionComputeConnectors/completeDeployments/notify`, "json", req, runtime), new DeployFunctionCallbackResponse({}));
  }

  async loginCodeGen(request: LoginCodeGenRequest): Promise<LoginCodeGenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoginCodeGenHeaders({ });
    return await this.loginCodeGenWithOptions(request, headers, runtime);
  }

  async loginCodeGenWithOptions(request: LoginCodeGenRequest, headers: LoginCodeGenHeaders, runtime: $Util.RuntimeOptions): Promise<LoginCodeGenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<LoginCodeGenResponse>(await this.doROARequest("LoginCodeGen", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/authorizations/loginCodes`, "json", req, runtime), new LoginCodeGenResponse({}));
  }

  async terminateCloudAuthorization(request: TerminateCloudAuthorizationRequest): Promise<TerminateCloudAuthorizationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TerminateCloudAuthorizationHeaders({ });
    return await this.terminateCloudAuthorizationWithOptions(request, headers, runtime);
  }

  async terminateCloudAuthorizationWithOptions(request: TerminateCloudAuthorizationRequest, headers: TerminateCloudAuthorizationHeaders, runtime: $Util.RuntimeOptions): Promise<TerminateCloudAuthorizationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
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
    return $tea.cast<TerminateCloudAuthorizationResponse>(await this.doROARequest("TerminateCloudAuthorization", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/apps/cloudAuthorizations/terminate`, "json", req, runtime), new TerminateCloudAuthorizationResponse({}));
  }

  async getActivityButtonList(appType: string, processCode: string, activityId: string, request: GetActivityButtonListRequest): Promise<GetActivityButtonListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivityButtonListHeaders({ });
    return await this.getActivityButtonListWithOptions(appType, processCode, activityId, request, headers, runtime);
  }

  async getActivityButtonListWithOptions(appType: string, processCode: string, activityId: string, request: GetActivityButtonListRequest, headers: GetActivityButtonListHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivityButtonListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetActivityButtonListResponse>(await this.doROARequest("GetActivityButtonList", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processDefinitions/buttons/${appType}/${processCode}/${activityId}`, "json", req, runtime), new GetActivityButtonListResponse({}));
  }

  async startInstance(request: StartInstanceRequest): Promise<StartInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartInstanceHeaders({ });
    return await this.startInstanceWithOptions(request, headers, runtime);
  }

  async startInstanceWithOptions(request: StartInstanceRequest, headers: StartInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<StartInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.processCode)) {
      body["processCode"] = request.processCode;
    }

    if (!Util.isUnset(request.departmentId)) {
      body["departmentId"] = request.departmentId;
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
    return $tea.cast<StartInstanceResponse>(await this.doROARequest("StartInstance", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/processes/instances/start`, "json", req, runtime), new StartInstanceResponse({}));
  }

  async listApplicationInformation(instanceId: string, request: ListApplicationInformationRequest): Promise<ListApplicationInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApplicationInformationHeaders({ });
    return await this.listApplicationInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listApplicationInformationWithOptions(instanceId: string, request: ListApplicationInformationRequest, headers: ListApplicationInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListApplicationInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ListApplicationInformationResponse>(await this.doROARequest("ListApplicationInformation", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/infos/${instanceId}`, "json", req, runtime), new ListApplicationInformationResponse({}));
  }

  async validateOrderUpgrade(request: ValidateOrderUpgradeRequest): Promise<ValidateOrderUpgradeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpgradeHeaders({ });
    return await this.validateOrderUpgradeWithOptions(request, headers, runtime);
  }

  async validateOrderUpgradeWithOptions(request: ValidateOrderUpgradeRequest, headers: ValidateOrderUpgradeHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderUpgradeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ValidateOrderUpgradeResponse>(await this.doROARequest("ValidateOrderUpgrade", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/orderUpgrade/validate`, "json", req, runtime), new ValidateOrderUpgradeResponse({}));
  }

  async updateCloudAccountInformation(request: UpdateCloudAccountInformationRequest): Promise<UpdateCloudAccountInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCloudAccountInformationHeaders({ });
    return await this.updateCloudAccountInformationWithOptions(request, headers, runtime);
  }

  async updateCloudAccountInformationWithOptions(request: UpdateCloudAccountInformationRequest, headers: UpdateCloudAccountInformationHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCloudAccountInformationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      body["callerUnionId"] = request.callerUnionId;
    }

    if (!Util.isUnset(request.accountNumber)) {
      body["accountNumber"] = request.accountNumber;
    }

    if (!Util.isUnset(request.commodityType)) {
      body["commodityType"] = request.commodityType;
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
    return $tea.cast<UpdateCloudAccountInformationResponse>(await this.doROARequest("UpdateCloudAccountInformation", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/apps/cloudAccountInfos`, "json", req, runtime), new UpdateCloudAccountInformationResponse({}));
  }

  async getCorpLevelByAccountId(request: GetCorpLevelByAccountIdRequest): Promise<GetCorpLevelByAccountIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpLevelByAccountIdHeaders({ });
    return await this.getCorpLevelByAccountIdWithOptions(request, headers, runtime);
  }

  async getCorpLevelByAccountIdWithOptions(request: GetCorpLevelByAccountIdRequest, headers: GetCorpLevelByAccountIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpLevelByAccountIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
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
    return $tea.cast<GetCorpLevelByAccountIdResponse>(await this.doROARequest("GetCorpLevelByAccountId", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/corpLevel`, "json", req, runtime), new GetCorpLevelByAccountIdResponse({}));
  }

  async executePlatformTask(request: ExecutePlatformTaskRequest): Promise<ExecutePlatformTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecutePlatformTaskHeaders({ });
    return await this.executePlatformTaskWithOptions(request, headers, runtime);
  }

  async executePlatformTaskWithOptions(request: ExecutePlatformTaskRequest, headers: ExecutePlatformTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecutePlatformTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.noExecuteExpressions)) {
      body["noExecuteExpressions"] = request.noExecuteExpressions;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<ExecutePlatformTaskResponse>(await this.doROARequest("ExecutePlatformTask", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/tasks/platformTasks/execute`, "none", req, runtime), new ExecutePlatformTaskResponse({}));
  }

  async searchFormDatas(request: SearchFormDatasRequest): Promise<SearchFormDatasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDatasHeaders({ });
    return await this.searchFormDatasWithOptions(request, headers, runtime);
  }

  async searchFormDatasWithOptions(request: SearchFormDatasRequest, headers: SearchFormDatasHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDatasResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.dynamicOrder)) {
      body["dynamicOrder"] = request.dynamicOrder;
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
    return $tea.cast<SearchFormDatasResponse>(await this.doROARequest("SearchFormDatas", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances/search`, "json", req, runtime), new SearchFormDatasResponse({}));
  }

  async searchActivationCode(request: SearchActivationCodeRequest): Promise<SearchActivationCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchActivationCodeHeaders({ });
    return await this.searchActivationCodeWithOptions(request, headers, runtime);
  }

  async searchActivationCodeWithOptions(request: SearchActivationCodeRequest, headers: SearchActivationCodeHeaders, runtime: $Util.RuntimeOptions): Promise<SearchActivationCodeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<SearchActivationCodeResponse>(await this.doROARequest("SearchActivationCode", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/activationCode/information`, "json", req, runtime), new SearchActivationCodeResponse({}));
  }

  async savePrintTplDetailInfo(request: SavePrintTplDetailInfoRequest): Promise<SavePrintTplDetailInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SavePrintTplDetailInfoHeaders({ });
    return await this.savePrintTplDetailInfoWithOptions(request, headers, runtime);
  }

  async savePrintTplDetailInfoWithOptions(request: SavePrintTplDetailInfoRequest, headers: SavePrintTplDetailInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SavePrintTplDetailInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.vm)) {
      body["vm"] = request.vm;
    }

    if (!Util.isUnset(request.formVersion)) {
      body["formVersion"] = request.formVersion;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.setting)) {
      body["setting"] = request.setting;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.fileNameConfig)) {
      body["fileNameConfig"] = request.fileNameConfig;
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
    return $tea.cast<SavePrintTplDetailInfoResponse>(await this.doROARequest("SavePrintTplDetailInfo", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/printTemplates/printTplDetailInfos`, "json", req, runtime), new SavePrintTplDetailInfoResponse({}));
  }

  async searchEmployeeFieldValues(request: SearchEmployeeFieldValuesRequest): Promise<SearchEmployeeFieldValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchEmployeeFieldValuesHeaders({ });
    return await this.searchEmployeeFieldValuesWithOptions(request, headers, runtime);
  }

  async searchEmployeeFieldValuesWithOptions(request: SearchEmployeeFieldValuesRequest, headers: SearchEmployeeFieldValuesHeaders, runtime: $Util.RuntimeOptions): Promise<SearchEmployeeFieldValuesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetFieldJson)) {
      body["targetFieldJson"] = request.targetFieldJson;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
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
    return $tea.cast<SearchEmployeeFieldValuesResponse>(await this.doROARequest("SearchEmployeeFieldValues", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/employeeFields`, "json", req, runtime), new SearchEmployeeFieldValuesResponse({}));
  }

  async updateFormData(request: UpdateFormDataRequest): Promise<UpdateFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFormDataHeaders({ });
    return await this.updateFormDataWithOptions(request, headers, runtime);
  }

  async updateFormDataWithOptions(request: UpdateFormDataRequest, headers: UpdateFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      body["formInstanceId"] = request.formInstanceId;
    }

    if (!Util.isUnset(request.useLatestVersion)) {
      body["useLatestVersion"] = request.useLatestVersion;
    }

    if (!Util.isUnset(request.updateFormDataJson)) {
      body["updateFormDataJson"] = request.updateFormDataJson;
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
    return $tea.cast<UpdateFormDataResponse>(await this.doROARequest("UpdateFormData", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/forms/instances`, "none", req, runtime), new UpdateFormDataResponse({}));
  }

  async getInstanceIdList(request: GetInstanceIdListRequest): Promise<GetInstanceIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstanceIdListHeaders({ });
    return await this.getInstanceIdListWithOptions(request, headers, runtime);
  }

  async getInstanceIdListWithOptions(request: GetInstanceIdListRequest, headers: GetInstanceIdListHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstanceIdListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.instanceStatus)) {
      body["instanceStatus"] = request.instanceStatus;
    }

    if (!Util.isUnset(request.approvedResult)) {
      body["approvedResult"] = request.approvedResult;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
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
    return $tea.cast<GetInstanceIdListResponse>(await this.doROARequest("GetInstanceIdList", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/processes/instanceIds`, "json", req, runtime), new GetInstanceIdListResponse({}));
  }

  async getOperationRecords(request: GetOperationRecordsRequest): Promise<GetOperationRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOperationRecordsHeaders({ });
    return await this.getOperationRecordsWithOptions(request, headers, runtime);
  }

  async getOperationRecordsWithOptions(request: GetOperationRecordsRequest, headers: GetOperationRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOperationRecordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<GetOperationRecordsResponse>(await this.doROARequest("GetOperationRecords", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/operationRecords`, "json", req, runtime), new GetOperationRecordsResponse({}));
  }

  async getPlatformResource(request: GetPlatformResourceRequest): Promise<GetPlatformResourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPlatformResourceHeaders({ });
    return await this.getPlatformResourceWithOptions(request, headers, runtime);
  }

  async getPlatformResourceWithOptions(request: GetPlatformResourceRequest, headers: GetPlatformResourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetPlatformResourceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<GetPlatformResourceResponse>(await this.doROARequest("GetPlatformResource", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/platformResources`, "json", req, runtime), new GetPlatformResourceResponse({}));
  }

  async listConnectorInformation(instanceId: string, request: ListConnectorInformationRequest): Promise<ListConnectorInformationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListConnectorInformationHeaders({ });
    return await this.listConnectorInformationWithOptions(instanceId, request, headers, runtime);
  }

  async listConnectorInformationWithOptions(instanceId: string, request: ListConnectorInformationRequest, headers: ListConnectorInformationHeaders, runtime: $Util.RuntimeOptions): Promise<ListConnectorInformationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ListConnectorInformationResponse>(await this.doROARequest("ListConnectorInformation", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/plugins/infos/${instanceId}`, "json", req, runtime), new ListConnectorInformationResponse({}));
  }

  async registerAccounts(request: RegisterAccountsRequest): Promise<RegisterAccountsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterAccountsHeaders({ });
    return await this.registerAccountsWithOptions(request, headers, runtime);
  }

  async registerAccountsWithOptions(request: RegisterAccountsRequest, headers: RegisterAccountsHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterAccountsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.accessKey)) {
      body["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.activeCode)) {
      body["activeCode"] = request.activeCode;
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
    return $tea.cast<RegisterAccountsResponse>(await this.doROARequest("RegisterAccounts", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/applicationAuthorizations/accounts/register`, "json", req, runtime), new RegisterAccountsResponse({}));
  }

  async getNotifyMe(userId: string, request: GetNotifyMeRequest): Promise<GetNotifyMeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNotifyMeHeaders({ });
    return await this.getNotifyMeWithOptions(userId, request, headers, runtime);
  }

  async getNotifyMeWithOptions(userId: string, request: GetNotifyMeRequest, headers: GetNotifyMeHeaders, runtime: $Util.RuntimeOptions): Promise<GetNotifyMeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.instanceCreateFromTimeGMT)) {
      query["instanceCreateFromTimeGMT"] = request.instanceCreateFromTimeGMT;
    }

    if (!Util.isUnset(request.instanceCreateToTimeGMT)) {
      query["instanceCreateToTimeGMT"] = request.instanceCreateToTimeGMT;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
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
    return $tea.cast<GetNotifyMeResponse>(await this.doROARequest("GetNotifyMe", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/corpNotifications/${userId}`, "json", req, runtime), new GetNotifyMeResponse({}));
  }

  async expireCommodity(request: ExpireCommodityRequest): Promise<ExpireCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExpireCommodityHeaders({ });
    return await this.expireCommodityWithOptions(request, headers, runtime);
  }

  async expireCommodityWithOptions(request: ExpireCommodityRequest, headers: ExpireCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ExpireCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ExpireCommodityResponse>(await this.doROARequest("ExpireCommodity", "yida_1.0", "HTTP", "PUT", "AK", `/v1.0/yida/appAuth/commodities/expire`, "json", req, runtime), new ExpireCommodityResponse({}));
  }

  async getInstanceById(id: string, request: GetInstanceByIdRequest): Promise<GetInstanceByIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstanceByIdHeaders({ });
    return await this.getInstanceByIdWithOptions(id, request, headers, runtime);
  }

  async getInstanceByIdWithOptions(id: string, request: GetInstanceByIdRequest, headers: GetInstanceByIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstanceByIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetInstanceByIdResponse>(await this.doROARequest("GetInstanceById", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/processes/instancesInfos/${id}`, "json", req, runtime), new GetInstanceByIdResponse({}));
  }

  async redirectTask(request: RedirectTaskRequest): Promise<RedirectTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RedirectTaskHeaders({ });
    return await this.redirectTaskWithOptions(request, headers, runtime);
  }

  async redirectTaskWithOptions(request: RedirectTaskRequest, headers: RedirectTaskHeaders, runtime: $Util.RuntimeOptions): Promise<RedirectTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.byManager)) {
      body["byManager"] = request.byManager;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.nowActionExecutorId)) {
      body["nowActionExecutorId"] = request.nowActionExecutorId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
    return $tea.cast<RedirectTaskResponse>(await this.doROARequest("RedirectTask", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/tasks/redirect`, "none", req, runtime), new RedirectTaskResponse({}));
  }

  async validateOrderUpdate(instanceId: string, request: ValidateOrderUpdateRequest): Promise<ValidateOrderUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateOrderUpdateHeaders({ });
    return await this.validateOrderUpdateWithOptions(instanceId, request, headers, runtime);
  }

  async validateOrderUpdateWithOptions(instanceId: string, request: ValidateOrderUpdateRequest, headers: ValidateOrderUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateOrderUpdateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ValidateOrderUpdateResponse>(await this.doROARequest("ValidateOrderUpdate", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/orders/renewalReviews/${instanceId}`, "json", req, runtime), new ValidateOrderUpdateResponse({}));
  }

  async getFormComponentDefinitionList(appType: string, formUuid: string, request: GetFormComponentDefinitionListRequest): Promise<GetFormComponentDefinitionListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormComponentDefinitionListHeaders({ });
    return await this.getFormComponentDefinitionListWithOptions(appType, formUuid, request, headers, runtime);
  }

  async getFormComponentDefinitionListWithOptions(appType: string, formUuid: string, request: GetFormComponentDefinitionListRequest, headers: GetFormComponentDefinitionListHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormComponentDefinitionListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
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
    return $tea.cast<GetFormComponentDefinitionListResponse>(await this.doROARequest("GetFormComponentDefinitionList", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/forms/definitions/${appType}/${formUuid}`, "json", req, runtime), new GetFormComponentDefinitionListResponse({}));
  }

  async getPrintAppInfo(request: GetPrintAppInfoRequest): Promise<GetPrintAppInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrintAppInfoHeaders({ });
    return await this.getPrintAppInfoWithOptions(request, headers, runtime);
  }

  async getPrintAppInfoWithOptions(request: GetPrintAppInfoRequest, headers: GetPrintAppInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrintAppInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.nameLike)) {
      query["nameLike"] = request.nameLike;
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
    return $tea.cast<GetPrintAppInfoResponse>(await this.doROARequest("GetPrintAppInfo", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/printTemplates/printAppInfos`, "json", req, runtime), new GetPrintAppInfoResponse({}));
  }

  async saveFormData(request: SaveFormDataRequest): Promise<SaveFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormDataHeaders({ });
    return await this.saveFormDataWithOptions(request, headers, runtime);
  }

  async saveFormDataWithOptions(request: SaveFormDataRequest, headers: SaveFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.formUuid)) {
      body["formUuid"] = request.formUuid;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
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
    return $tea.cast<SaveFormDataResponse>(await this.doROARequest("SaveFormData", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances`, "json", req, runtime), new SaveFormDataResponse({}));
  }

  async getMeCorpSubmission(userId: string, request: GetMeCorpSubmissionRequest): Promise<GetMeCorpSubmissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMeCorpSubmissionHeaders({ });
    return await this.getMeCorpSubmissionWithOptions(userId, request, headers, runtime);
  }

  async getMeCorpSubmissionWithOptions(userId: string, request: GetMeCorpSubmissionRequest, headers: GetMeCorpSubmissionHeaders, runtime: $Util.RuntimeOptions): Promise<GetMeCorpSubmissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.appTypes)) {
      query["appTypes"] = request.appTypes;
    }

    if (!Util.isUnset(request.processCodes)) {
      query["processCodes"] = request.processCodes;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      query["createFromTimeGMT"] = request.createFromTimeGMT;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      query["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.token)) {
      query["token"] = request.token;
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
    return $tea.cast<GetMeCorpSubmissionResponse>(await this.doROARequest("GetMeCorpSubmission", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/tasks/myCorpSubmission/${userId}`, "json", req, runtime), new GetMeCorpSubmissionResponse({}));
  }

  async deleteFormData(request: DeleteFormDataRequest): Promise<DeleteFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFormDataHeaders({ });
    return await this.deleteFormDataWithOptions(request, headers, runtime);
  }

  async deleteFormDataWithOptions(request: DeleteFormDataRequest, headers: DeleteFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFormDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.formInstanceId)) {
      query["formInstanceId"] = request.formInstanceId;
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
    return $tea.cast<DeleteFormDataResponse>(await this.doROARequest("DeleteFormData", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/forms/instances`, "none", req, runtime), new DeleteFormDataResponse({}));
  }

  async searchFormDataIdList(appType: string, formUuid: string, request: SearchFormDataIdListRequest): Promise<SearchFormDataIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchFormDataIdListHeaders({ });
    return await this.searchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
  }

  async searchFormDataIdListWithOptions(appType: string, formUuid: string, request: SearchFormDataIdListRequest, headers: SearchFormDataIdListHeaders, runtime: $Util.RuntimeOptions): Promise<SearchFormDataIdListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.modifiedToTimeGMT)) {
      body["modifiedToTimeGMT"] = request.modifiedToTimeGMT;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.modifiedFromTimeGMT)) {
      body["modifiedFromTimeGMT"] = request.modifiedFromTimeGMT;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.searchFieldJson)) {
      body["searchFieldJson"] = request.searchFieldJson;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.originatorId)) {
      body["originatorId"] = request.originatorId;
    }

    if (!Util.isUnset(request.createToTimeGMT)) {
      body["createToTimeGMT"] = request.createToTimeGMT;
    }

    if (!Util.isUnset(request.createFromTimeGMT)) {
      body["createFromTimeGMT"] = request.createFromTimeGMT;
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
    return $tea.cast<SearchFormDataIdListResponse>(await this.doROARequest("SearchFormDataIdList", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/forms/instances/ids/${appType}/${formUuid}`, "json", req, runtime), new SearchFormDataIdListResponse({}));
  }

  async getActivationCodeByCallerUnionId(callerUid: string, request: GetActivationCodeByCallerUnionIdRequest): Promise<GetActivationCodeByCallerUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActivationCodeByCallerUnionIdHeaders({ });
    return await this.getActivationCodeByCallerUnionIdWithOptions(callerUid, request, headers, runtime);
  }

  async getActivationCodeByCallerUnionIdWithOptions(callerUid: string, request: GetActivationCodeByCallerUnionIdRequest, headers: GetActivationCodeByCallerUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetActivationCodeByCallerUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
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
    return $tea.cast<GetActivationCodeByCallerUnionIdResponse>(await this.doROARequest("GetActivationCodeByCallerUnionId", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/applications/activationCodes/${callerUid}`, "json", req, runtime), new GetActivationCodeByCallerUnionIdResponse({}));
  }

  async getFormDataByID(id: string, request: GetFormDataByIDRequest): Promise<GetFormDataByIDResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormDataByIDHeaders({ });
    return await this.getFormDataByIDWithOptions(id, request, headers, runtime);
  }

  async getFormDataByIDWithOptions(id: string, request: GetFormDataByIDRequest, headers: GetFormDataByIDHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormDataByIDResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetFormDataByIDResponse>(await this.doROARequest("GetFormDataByID", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/forms/instances/${id}`, "json", req, runtime), new GetFormDataByIDResponse({}));
  }

  async refundCommodity(request: RefundCommodityRequest): Promise<RefundCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RefundCommodityHeaders({ });
    return await this.refundCommodityWithOptions(request, headers, runtime);
  }

  async refundCommodityWithOptions(request: RefundCommodityRequest, headers: RefundCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<RefundCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<RefundCommodityResponse>(await this.doROARequest("RefundCommodity", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/appAuth/commodities/refund`, "json", req, runtime), new RefundCommodityResponse({}));
  }

  async deleteSequence(request: DeleteSequenceRequest): Promise<DeleteSequenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSequenceHeaders({ });
    return await this.deleteSequenceWithOptions(request, headers, runtime);
  }

  async deleteSequenceWithOptions(request: DeleteSequenceRequest, headers: DeleteSequenceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSequenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.sequence)) {
      query["sequence"] = request.sequence;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
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
    return $tea.cast<DeleteSequenceResponse>(await this.doROARequest("DeleteSequence", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/forms/deleteSequence`, "none", req, runtime), new DeleteSequenceResponse({}));
  }

  async releaseCommodity(request: ReleaseCommodityRequest): Promise<ReleaseCommodityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseCommodityHeaders({ });
    return await this.releaseCommodityWithOptions(request, headers, runtime);
  }

  async releaseCommodityWithOptions(request: ReleaseCommodityRequest, headers: ReleaseCommodityHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseCommodityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUid)) {
      query["callerUid"] = request.callerUid;
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
    return $tea.cast<ReleaseCommodityResponse>(await this.doROARequest("ReleaseCommodity", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/appAuth/commodities/release`, "json", req, runtime), new ReleaseCommodityResponse({}));
  }

  async renderBatchCallback(request: RenderBatchCallbackRequest): Promise<RenderBatchCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenderBatchCallbackHeaders({ });
    return await this.renderBatchCallbackWithOptions(request, headers, runtime);
  }

  async renderBatchCallbackWithOptions(request: RenderBatchCallbackRequest, headers: RenderBatchCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<RenderBatchCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ossUrl)) {
      body["ossUrl"] = request.ossUrl;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.namespace)) {
      body["namespace"] = request.namespace;
    }

    if (!Util.isUnset(request.timeZone)) {
      body["timeZone"] = request.timeZone;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sequenceId)) {
      body["sequenceId"] = request.sequenceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<RenderBatchCallbackResponse>(await this.doROARequest("RenderBatchCallback", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/printings/callbacks/batch`, "none", req, runtime), new RenderBatchCallbackResponse({}));
  }

  async getOpenUrl(appType: string, request: GetOpenUrlRequest): Promise<GetOpenUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOpenUrlHeaders({ });
    return await this.getOpenUrlWithOptions(appType, request, headers, runtime);
  }

  async getOpenUrlWithOptions(appType: string, request: GetOpenUrlRequest, headers: GetOpenUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetOpenUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.fileUrl)) {
      query["fileUrl"] = request.fileUrl;
    }

    if (!Util.isUnset(request.timeout)) {
      query["timeout"] = request.timeout;
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
    return $tea.cast<GetOpenUrlResponse>(await this.doROARequest("GetOpenUrl", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/temporaryUrls/${appType}`, "json", req, runtime), new GetOpenUrlResponse({}));
  }

  async getSaleUserInfoByUserId(request: GetSaleUserInfoByUserIdRequest): Promise<GetSaleUserInfoByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSaleUserInfoByUserIdHeaders({ });
    return await this.getSaleUserInfoByUserIdWithOptions(request, headers, runtime);
  }

  async getSaleUserInfoByUserIdWithOptions(request: GetSaleUserInfoByUserIdRequest, headers: GetSaleUserInfoByUserIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetSaleUserInfoByUserIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.namespace)) {
      query["namespace"] = request.namespace;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetSaleUserInfoByUserIdResponse>(await this.doROARequest("GetSaleUserInfoByUserId", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/apps/saleUserInfo`, "json", req, runtime), new GetSaleUserInfoByUserIdResponse({}));
  }

  async validateApplicationAuthorizationOrder(instanceId: string, request: ValidateApplicationAuthorizationOrderRequest): Promise<ValidateApplicationAuthorizationOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ValidateApplicationAuthorizationOrderHeaders({ });
    return await this.validateApplicationAuthorizationOrderWithOptions(instanceId, request, headers, runtime);
  }

  async validateApplicationAuthorizationOrderWithOptions(instanceId: string, request: ValidateApplicationAuthorizationOrderRequest, headers: ValidateApplicationAuthorizationOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ValidateApplicationAuthorizationOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accessKey)) {
      query["accessKey"] = request.accessKey;
    }

    if (!Util.isUnset(request.callerUnionId)) {
      query["callerUnionId"] = request.callerUnionId;
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
    return $tea.cast<ValidateApplicationAuthorizationOrderResponse>(await this.doROARequest("ValidateApplicationAuthorizationOrder", "yida_1.0", "HTTP", "GET", "AK", `/v1.0/yida/applicationOrderUpdateAuthorizations/${instanceId}`, "json", req, runtime), new ValidateApplicationAuthorizationOrderResponse({}));
  }

  async executeTask(request: ExecuteTaskRequest): Promise<ExecuteTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteTaskHeaders({ });
    return await this.executeTaskWithOptions(request, headers, runtime);
  }

  async executeTaskWithOptions(request: ExecuteTaskRequest, headers: ExecuteTaskHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outResult)) {
      body["outResult"] = request.outResult;
    }

    if (!Util.isUnset(request.noExecuteExpressions)) {
      body["noExecuteExpressions"] = request.noExecuteExpressions;
    }

    if (!Util.isUnset(request.appType)) {
      body["appType"] = request.appType;
    }

    if (!Util.isUnset(request.formDataJson)) {
      body["formDataJson"] = request.formDataJson;
    }

    if (!Util.isUnset(request.systemToken)) {
      body["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.language)) {
      body["language"] = request.language;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    if (!Util.isUnset(request.digitalSignUrl)) {
      body["digitalSignUrl"] = request.digitalSignUrl;
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
    return $tea.cast<ExecuteTaskResponse>(await this.doROARequest("ExecuteTask", "yida_1.0", "HTTP", "POST", "AK", `/v1.0/yida/tasks/execute`, "none", req, runtime), new ExecuteTaskResponse({}));
  }

  async deleteInstance(request: DeleteInstanceRequest): Promise<DeleteInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInstanceHeaders({ });
    return await this.deleteInstanceWithOptions(request, headers, runtime);
  }

  async deleteInstanceWithOptions(request: DeleteInstanceRequest, headers: DeleteInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appType)) {
      query["appType"] = request.appType;
    }

    if (!Util.isUnset(request.systemToken)) {
      query["systemToken"] = request.systemToken;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<DeleteInstanceResponse>(await this.doROARequest("DeleteInstance", "yida_1.0", "HTTP", "DELETE", "AK", `/v1.0/yida/processes/instances`, "none", req, runtime), new DeleteInstanceResponse({}));
  }

}
