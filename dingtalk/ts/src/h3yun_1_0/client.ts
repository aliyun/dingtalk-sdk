// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class LoadBizFieldsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsRequest extends $tea.Model {
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: LoadBizFieldsResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: LoadBizFieldsResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: LoadBizFieldsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LoadBizFieldsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelProcessInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelProcessInstanceRequest extends $tea.Model {
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelProcessInstanceResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelProcessInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CancelProcessInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CancelProcessInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentTemporaryUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentTemporaryUrlRequest extends $tea.Model {
  attachmentId?: string;
  static names(): { [key: string]: string } {
    return {
      attachmentId: 'attachmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachmentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentTemporaryUrlResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetAttachmentTemporaryUrlResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: GetAttachmentTemporaryUrlResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentTemporaryUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAttachmentTemporaryUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAttachmentTemporaryUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlRequest extends $tea.Model {
  schemaCode?: string;
  bizObjectId?: string;
  fieldName?: string;
  isOverwrite?: boolean;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
      fieldName: 'fieldName',
      isOverwrite: 'isOverwrite',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      bizObjectId: 'string',
      fieldName: 'string',
      isOverwrite: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetUploadUrlResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: GetUploadUrlResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUploadUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUploadUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUsersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUsersRequest extends $tea.Model {
  departmentId?: string;
  isRecursive?: boolean;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      isRecursive: 'isRecursive',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'string',
      isRecursive: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUsersResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetUsersResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': GetUsersResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersRequest extends $tea.Model {
  roleId?: string;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetRoleUsersResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': GetRoleUsersResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRoleUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRoleUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectRequest extends $tea.Model {
  schemaCode?: string;
  bizObjectId?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      bizObjectId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: LoadBizObjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LoadBizObjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsRequest extends $tea.Model {
  schemaCode?: string;
  pageNumber?: number;
  pageSize?: number;
  returnFields?: string[];
  sortByFields?: LoadBizObjectsRequestSortByFields[];
  matcherJson?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      returnFields: 'returnFields',
      sortByFields: 'sortByFields',
      matcherJson: 'matcherJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      returnFields: { 'type': 'array', 'itemType': 'string' },
      sortByFields: { 'type': 'array', 'itemType': LoadBizObjectsRequestSortByFields },
      matcherJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: LoadBizObjectsResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: LoadBizObjectsResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: LoadBizObjectsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LoadBizObjectsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessesInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessesInstanceRequest extends $tea.Model {
  processInstanceId?: string;
  isAutoUpdateBizObject?: boolean;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      isAutoUpdateBizObject: 'isAutoUpdateBizObject',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      isAutoUpdateBizObject: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessesInstanceResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteProcessesInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteProcessesInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteProcessesInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsRequest extends $tea.Model {
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: QueryProcessesWorkItemsResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': QueryProcessesWorkItemsResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryProcessesWorkItemsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryProcessesWorkItemsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBizObjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBizObjectRequest extends $tea.Model {
  schemaCode?: string;
  bizObjectId?: string;
  bizObjectJson?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
      bizObjectJson: 'bizObjectJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      bizObjectId: 'string',
      bizObjectJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBizObjectResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateBizObjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateBizObjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceRequest extends $tea.Model {
  schemaCode?: string;
  bizObjectId?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      bizObjectId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: QueryProcessesInstanceResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': QueryProcessesInstanceResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryProcessesInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryProcessesInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetRolesResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: GetRolesResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationsRequest extends $tea.Model {
  departmentId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationsResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetOrganizationsResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': GetOrganizationsResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOrganizationsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOrganizationsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBizObjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBizObjectRequest extends $tea.Model {
  schemaCode?: string;
  bizObjectId?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      bizObjectId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBizObjectResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteBizObjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteBizObjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesRequest extends $tea.Model {
  appCode?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: QueryAppFunctionNodesResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': QueryAppFunctionNodesResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAppFunctionNodesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAppFunctionNodesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectRequest extends $tea.Model {
  schemaCode?: string;
  opUserId?: string;
  bizObjectJson?: string;
  isDraft?: boolean;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      opUserId: 'opUserId',
      bizObjectJson: 'bizObjectJson',
      isDraft: 'isDraft',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      opUserId: 'string',
      bizObjectJson: 'string',
      isDraft: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: CreateBizObjectResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: CreateBizObjectResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateBizObjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateBizObjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppsRequest extends $tea.Model {
  queryType?: string;
  values?: string[];
  static names(): { [key: string]: string } {
    return {
      queryType: 'queryType',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      queryType: 'string',
      values: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppsResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: GetAppsResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: { 'type': 'array', 'itemType': GetAppsResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAppsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAppsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceRequest extends $tea.Model {
  schemaCode?: string;
  bizObjectId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      bizObjectId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: CreateProcessesInstanceResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: CreateProcessesInstanceResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateProcessesInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateProcessesInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectRequest extends $tea.Model {
  schemaCode?: string;
  opUserId?: string;
  bizObjectJsonArray?: string[];
  isDraft?: boolean;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      opUserId: 'opUserId',
      bizObjectJsonArray: 'bizObjectJsonArray',
      isDraft: 'isDraft',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      opUserId: 'string',
      bizObjectJsonArray: { 'type': 'array', 'itemType': 'string' },
      isDraft: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectResponseBody extends $tea.Model {
  code?: string;
  message?: string;
  data?: BatchInsertBizObjectResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      data: BatchInsertBizObjectResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchInsertBizObjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchInsertBizObjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyDataFields extends $tea.Model {
  label?: string;
  fieldName?: string;
  bizDataType?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      fieldName: 'fieldName',
      bizDataType: 'bizDataType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      fieldName: 'string',
      bizDataType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyDataChildFormsFields extends $tea.Model {
  label?: string;
  fieldName?: string;
  bizDataType?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      fieldName: 'fieldName',
      bizDataType: 'bizDataType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      fieldName: 'string',
      bizDataType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyDataChildForms extends $tea.Model {
  schemaCode?: string;
  formName?: string;
  fields?: LoadBizFieldsResponseBodyDataChildFormsFields[];
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      formName: 'formName',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      formName: 'string',
      fields: { 'type': 'array', 'itemType': LoadBizFieldsResponseBodyDataChildFormsFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyData extends $tea.Model {
  schemaCode?: string;
  formName?: string;
  fields?: LoadBizFieldsResponseBodyDataFields[];
  childForms?: LoadBizFieldsResponseBodyDataChildForms[];
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      formName: 'formName',
      fields: 'fields',
      childForms: 'childForms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      formName: 'string',
      fields: { 'type': 'array', 'itemType': LoadBizFieldsResponseBodyDataFields },
      childForms: { 'type': 'array', 'itemType': LoadBizFieldsResponseBodyDataChildForms },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentTemporaryUrlResponseBodyData extends $tea.Model {
  attachmentUrl?: string;
  static names(): { [key: string]: string } {
    return {
      attachmentUrl: 'attachmentUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachmentUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponseBodyData extends $tea.Model {
  uploadUrl?: string;
  static names(): { [key: string]: string } {
    return {
      uploadUrl: 'uploadUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uploadUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUsersResponseBodyData extends $tea.Model {
  id?: string;
  name?: string;
  code?: string;
  sex?: string;
  description?: string;
  mobile?: string;
  email?: string;
  departmentId?: string;
  departmentName?: string;
  domainType?: string;
  partDepartmentIds?: string[];
  sortKey?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      code: 'code',
      sex: 'sex',
      description: 'description',
      mobile: 'mobile',
      email: 'email',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      domainType: 'domainType',
      partDepartmentIds: 'partDepartmentIds',
      sortKey: 'sortKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      code: 'string',
      sex: 'string',
      description: 'string',
      mobile: 'string',
      email: 'string',
      departmentId: 'string',
      departmentName: 'string',
      domainType: 'string',
      partDepartmentIds: { 'type': 'array', 'itemType': 'string' },
      sortKey: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersResponseBodyData extends $tea.Model {
  userId?: string;
  name?: string;
  code?: string;
  sex?: string;
  description?: string;
  mobile?: string;
  email?: string;
  departmentId?: string;
  departmentName?: string;
  domainType?: string;
  partDepartmentIds?: string[];
  sortKey?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      code: 'code',
      sex: 'sex',
      description: 'description',
      mobile: 'mobile',
      email: 'email',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      domainType: 'domainType',
      partDepartmentIds: 'partDepartmentIds',
      sortKey: 'sortKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      code: 'string',
      sex: 'string',
      description: 'string',
      mobile: 'string',
      email: 'string',
      departmentId: 'string',
      departmentName: 'string',
      domainType: 'string',
      partDepartmentIds: { 'type': 'array', 'itemType': 'string' },
      sortKey: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsRequestSortByFields extends $tea.Model {
  fieldName?: string;
  direction?: string;
  static names(): { [key: string]: string } {
    return {
      fieldName: 'fieldName',
      direction: 'direction',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldName: 'string',
      direction: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsResponseBodyData extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  bizObjects?: { [key: string]: any }[];
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
      bizObjects: 'bizObjects',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
      bizObjects: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyDataParticipant extends $tea.Model {
  userId?: string;
  name?: string;
  departmentId?: string;
  departmentName?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      departmentId: 'string',
      departmentName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyDataFinisher extends $tea.Model {
  userId?: string;
  name?: string;
  departmentId?: string;
  departmentName?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      departmentId: 'string',
      departmentName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyDataReceiptor extends $tea.Model {
  userId?: string;
  name?: string;
  departmentId?: string;
  departmentName?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      departmentId: 'string',
      departmentName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyData extends $tea.Model {
  workItemId?: string;
  workItemType?: string;
  processInstanceId?: string;
  appCode?: string;
  schemaCode?: string;
  bizObjectId?: string;
  processVersion?: string;
  activityCode?: string;
  activityName?: string;
  displayName?: string;
  state?: string;
  isFinish?: boolean;
  receiveTimeGMT?: string;
  startTimeGMT?: string;
  finishTimeGMT?: string;
  comment?: string;
  isApproval?: boolean;
  participant?: QueryProcessesWorkItemsResponseBodyDataParticipant;
  finisher?: QueryProcessesWorkItemsResponseBodyDataFinisher;
  receiptor?: QueryProcessesWorkItemsResponseBodyDataReceiptor;
  static names(): { [key: string]: string } {
    return {
      workItemId: 'workItemId',
      workItemType: 'workItemType',
      processInstanceId: 'processInstanceId',
      appCode: 'appCode',
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
      processVersion: 'processVersion',
      activityCode: 'activityCode',
      activityName: 'activityName',
      displayName: 'displayName',
      state: 'state',
      isFinish: 'isFinish',
      receiveTimeGMT: 'receiveTimeGMT',
      startTimeGMT: 'startTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
      comment: 'comment',
      isApproval: 'isApproval',
      participant: 'participant',
      finisher: 'finisher',
      receiptor: 'receiptor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workItemId: 'string',
      workItemType: 'string',
      processInstanceId: 'string',
      appCode: 'string',
      schemaCode: 'string',
      bizObjectId: 'string',
      processVersion: 'string',
      activityCode: 'string',
      activityName: 'string',
      displayName: 'string',
      state: 'string',
      isFinish: 'boolean',
      receiveTimeGMT: 'string',
      startTimeGMT: 'string',
      finishTimeGMT: 'string',
      comment: 'string',
      isApproval: 'boolean',
      participant: QueryProcessesWorkItemsResponseBodyDataParticipant,
      finisher: QueryProcessesWorkItemsResponseBodyDataFinisher,
      receiptor: QueryProcessesWorkItemsResponseBodyDataReceiptor,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponseBodyDataOriginator extends $tea.Model {
  userId?: string;
  name?: string;
  departmentId?: string;
  departmentName?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      departmentId: 'string',
      departmentName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponseBodyData extends $tea.Model {
  processInstanceId?: string;
  dingTalkProcessId?: string;
  processDisplayName?: string;
  processVersion?: number;
  schemaCode?: string;
  bizObjectId?: string;
  appCode?: string;
  state?: string;
  originator?: QueryProcessesInstanceResponseBodyDataOriginator;
  createdTimeGMT?: string;
  startTimeGMT?: string;
  finishTimeGMT?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
      dingTalkProcessId: 'dingTalkProcessId',
      processDisplayName: 'processDisplayName',
      processVersion: 'processVersion',
      schemaCode: 'schemaCode',
      bizObjectId: 'bizObjectId',
      appCode: 'appCode',
      state: 'state',
      originator: 'originator',
      createdTimeGMT: 'createdTimeGMT',
      startTimeGMT: 'startTimeGMT',
      finishTimeGMT: 'finishTimeGMT',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
      dingTalkProcessId: 'string',
      processDisplayName: 'string',
      processVersion: 'number',
      schemaCode: 'string',
      bizObjectId: 'string',
      appCode: 'string',
      state: 'string',
      originator: QueryProcessesInstanceResponseBodyDataOriginator,
      createdTimeGMT: 'string',
      startTimeGMT: 'string',
      finishTimeGMT: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponseBodyDataRoleGroups extends $tea.Model {
  groupId?: string;
  groupName?: string;
  groupCode?: string;
  companyId?: string;
  visibility?: string;
  state?: string;
  description?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      groupCode: 'groupCode',
      companyId: 'companyId',
      visibility: 'visibility',
      state: 'state',
      description: 'description',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
      groupName: 'string',
      groupCode: 'string',
      companyId: 'string',
      visibility: 'string',
      state: 'string',
      description: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponseBodyDataRoles extends $tea.Model {
  roleId?: string;
  roleName?: string;
  roleCode?: string;
  description?: string;
  groupId?: string;
  state?: string;
  visibility?: string;
  companyId?: string;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
      roleName: 'roleName',
      roleCode: 'roleCode',
      description: 'description',
      groupId: 'groupId',
      state: 'state',
      visibility: 'visibility',
      companyId: 'companyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'string',
      roleName: 'string',
      roleCode: 'string',
      description: 'string',
      groupId: 'string',
      state: 'string',
      visibility: 'string',
      companyId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponseBodyData extends $tea.Model {
  roleGroups?: GetRolesResponseBodyDataRoleGroups[];
  roles?: GetRolesResponseBodyDataRoles[];
  static names(): { [key: string]: string } {
    return {
      roleGroups: 'roleGroups',
      roles: 'roles',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleGroups: { 'type': 'array', 'itemType': GetRolesResponseBodyDataRoleGroups },
      roles: { 'type': 'array', 'itemType': GetRolesResponseBodyDataRoles },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationsResponseBodyData extends $tea.Model {
  id?: string;
  parentId?: string;
  name?: string;
  code?: string;
  unitType?: string;
  sortKey?: number;
  description?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      parentId: 'parentId',
      name: 'name',
      code: 'code',
      unitType: 'unitType',
      sortKey: 'sortKey',
      description: 'description',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      parentId: 'string',
      name: 'string',
      code: 'string',
      unitType: 'string',
      sortKey: 'number',
      description: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesResponseBodyData extends $tea.Model {
  schemaCode?: string;
  appCode?: string;
  parentCode?: string;
  displayName?: string;
  nodeVisibleType?: string;
  nodeType?: string;
  state?: string;
  sortKey?: number;
  isSystem?: boolean;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      appCode: 'appCode',
      parentCode: 'parentCode',
      displayName: 'displayName',
      nodeVisibleType: 'nodeVisibleType',
      nodeType: 'nodeType',
      state: 'state',
      sortKey: 'sortKey',
      isSystem: 'isSystem',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      appCode: 'string',
      parentCode: 'string',
      displayName: 'string',
      nodeVisibleType: 'string',
      nodeType: 'string',
      state: 'string',
      sortKey: 'number',
      isSystem: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectResponseBodyData extends $tea.Model {
  schemaCode?: string;
  formUsageType?: string;
  bizObjectId?: string;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      schemaCode: 'schemaCode',
      formUsageType: 'formUsageType',
      bizObjectId: 'bizObjectId',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      schemaCode: 'string',
      formUsageType: 'string',
      bizObjectId: 'string',
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppsResponseBodyData extends $tea.Model {
  appCode?: string;
  displayName?: string;
  appSource?: string;
  appState?: string;
  solution?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      displayName: 'displayName',
      appSource: 'appSource',
      appState: 'appState',
      solution: 'solution',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      displayName: 'string',
      appSource: 'string',
      appState: 'string',
      solution: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceResponseBodyData extends $tea.Model {
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectResponseBodyData extends $tea.Model {
  bizObjectIds?: string[];
  processIds?: string[];
  failedDatas?: string[];
  failedMessages?: string[];
  static names(): { [key: string]: string } {
    return {
      bizObjectIds: 'bizObjectIds',
      processIds: 'processIds',
      failedDatas: 'failedDatas',
      failedMessages: 'failedMessages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectIds: { 'type': 'array', 'itemType': 'string' },
      processIds: { 'type': 'array', 'itemType': 'string' },
      failedDatas: { 'type': 'array', 'itemType': 'string' },
      failedMessages: { 'type': 'array', 'itemType': 'string' },
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


  async loadBizFields(request: LoadBizFieldsRequest): Promise<LoadBizFieldsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoadBizFieldsHeaders({ });
    return await this.loadBizFieldsWithOptions(request, headers, runtime);
  }

  async loadBizFieldsWithOptions(request: LoadBizFieldsRequest, headers: LoadBizFieldsHeaders, runtime: $Util.RuntimeOptions): Promise<LoadBizFieldsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
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
    return $tea.cast<LoadBizFieldsResponse>(await this.doROARequest("LoadBizFields", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/forms/loadBizFields`, "json", req, runtime), new LoadBizFieldsResponse({}));
  }

  async cancelProcessInstance(request: CancelProcessInstanceRequest): Promise<CancelProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelProcessInstanceHeaders({ });
    return await this.cancelProcessInstanceWithOptions(request, headers, runtime);
  }

  async cancelProcessInstanceWithOptions(request: CancelProcessInstanceRequest, headers: CancelProcessInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CancelProcessInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
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
    return $tea.cast<CancelProcessInstanceResponse>(await this.doROARequest("CancelProcessInstance", "h3yun_1.0", "HTTP", "POST", "AK", `/v1.0/h3yun/processes/instances/cancel`, "json", req, runtime), new CancelProcessInstanceResponse({}));
  }

  async getAttachmentTemporaryUrl(request: GetAttachmentTemporaryUrlRequest): Promise<GetAttachmentTemporaryUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAttachmentTemporaryUrlHeaders({ });
    return await this.getAttachmentTemporaryUrlWithOptions(request, headers, runtime);
  }

  async getAttachmentTemporaryUrlWithOptions(request: GetAttachmentTemporaryUrlRequest, headers: GetAttachmentTemporaryUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetAttachmentTemporaryUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachmentId)) {
      query["attachmentId"] = request.attachmentId;
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
    return $tea.cast<GetAttachmentTemporaryUrlResponse>(await this.doROARequest("GetAttachmentTemporaryUrl", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/attachments/temporaryUrls`, "json", req, runtime), new GetAttachmentTemporaryUrlResponse({}));
  }

  async getUploadUrl(request: GetUploadUrlRequest): Promise<GetUploadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadUrlHeaders({ });
    return await this.getUploadUrlWithOptions(request, headers, runtime);
  }

  async getUploadUrlWithOptions(request: GetUploadUrlRequest, headers: GetUploadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.fieldName)) {
      query["fieldName"] = request.fieldName;
    }

    if (!Util.isUnset(request.isOverwrite)) {
      query["isOverwrite"] = request.isOverwrite;
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
    return $tea.cast<GetUploadUrlResponse>(await this.doROARequest("GetUploadUrl", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/attachments/uploadUrls`, "json", req, runtime), new GetUploadUrlResponse({}));
  }

  async getUsers(request: GetUsersRequest): Promise<GetUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUsersHeaders({ });
    return await this.getUsersWithOptions(request, headers, runtime);
  }

  async getUsersWithOptions(request: GetUsersRequest, headers: GetUsersHeaders, runtime: $Util.RuntimeOptions): Promise<GetUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.isRecursive)) {
      query["isRecursive"] = request.isRecursive;
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
    return $tea.cast<GetUsersResponse>(await this.doROARequest("GetUsers", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/users`, "json", req, runtime), new GetUsersResponse({}));
  }

  async getRoleUsers(request: GetRoleUsersRequest): Promise<GetRoleUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRoleUsersHeaders({ });
    return await this.getRoleUsersWithOptions(request, headers, runtime);
  }

  async getRoleUsersWithOptions(request: GetRoleUsersRequest, headers: GetRoleUsersHeaders, runtime: $Util.RuntimeOptions): Promise<GetRoleUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.roleId)) {
      query["roleId"] = request.roleId;
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
    return $tea.cast<GetRoleUsersResponse>(await this.doROARequest("GetRoleUsers", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/roles/roleUsers`, "json", req, runtime), new GetRoleUsersResponse({}));
  }

  async loadBizObject(request: LoadBizObjectRequest): Promise<LoadBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoadBizObjectHeaders({ });
    return await this.loadBizObjectWithOptions(request, headers, runtime);
  }

  async loadBizObjectWithOptions(request: LoadBizObjectRequest, headers: LoadBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<LoadBizObjectResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
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
    return $tea.cast<LoadBizObjectResponse>(await this.doROARequest("LoadBizObject", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/forms/instances/loadInstances`, "json", req, runtime), new LoadBizObjectResponse({}));
  }

  async loadBizObjects(request: LoadBizObjectsRequest): Promise<LoadBizObjectsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoadBizObjectsHeaders({ });
    return await this.loadBizObjectsWithOptions(request, headers, runtime);
  }

  async loadBizObjectsWithOptions(request: LoadBizObjectsRequest, headers: LoadBizObjectsHeaders, runtime: $Util.RuntimeOptions): Promise<LoadBizObjectsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.returnFields)) {
      body["returnFields"] = request.returnFields;
    }

    if (!Util.isUnset(request.sortByFields)) {
      body["sortByFields"] = request.sortByFields;
    }

    if (!Util.isUnset(request.matcherJson)) {
      body["matcherJson"] = request.matcherJson;
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
    return $tea.cast<LoadBizObjectsResponse>(await this.doROARequest("LoadBizObjects", "h3yun_1.0", "HTTP", "POST", "AK", `/v1.0/h3yun/forms/instances/search`, "json", req, runtime), new LoadBizObjectsResponse({}));
  }

  async deleteProcessesInstance(request: DeleteProcessesInstanceRequest): Promise<DeleteProcessesInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteProcessesInstanceHeaders({ });
    return await this.deleteProcessesInstanceWithOptions(request, headers, runtime);
  }

  async deleteProcessesInstanceWithOptions(request: DeleteProcessesInstanceRequest, headers: DeleteProcessesInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteProcessesInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.isAutoUpdateBizObject)) {
      query["isAutoUpdateBizObject"] = request.isAutoUpdateBizObject;
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
    return $tea.cast<DeleteProcessesInstanceResponse>(await this.doROARequest("DeleteProcessesInstance", "h3yun_1.0", "HTTP", "DELETE", "AK", `/v1.0/h3yun/processes/instances`, "json", req, runtime), new DeleteProcessesInstanceResponse({}));
  }

  async queryProcessesWorkItems(request: QueryProcessesWorkItemsRequest): Promise<QueryProcessesWorkItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProcessesWorkItemsHeaders({ });
    return await this.queryProcessesWorkItemsWithOptions(request, headers, runtime);
  }

  async queryProcessesWorkItemsWithOptions(request: QueryProcessesWorkItemsRequest, headers: QueryProcessesWorkItemsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProcessesWorkItemsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<QueryProcessesWorkItemsResponse>(await this.doROARequest("QueryProcessesWorkItems", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/processes/workItems`, "json", req, runtime), new QueryProcessesWorkItemsResponse({}));
  }

  async updateBizObject(request: UpdateBizObjectRequest): Promise<UpdateBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateBizObjectHeaders({ });
    return await this.updateBizObjectWithOptions(request, headers, runtime);
  }

  async updateBizObjectWithOptions(request: UpdateBizObjectRequest, headers: UpdateBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateBizObjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.bizObjectId)) {
      body["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.bizObjectJson)) {
      body["bizObjectJson"] = request.bizObjectJson;
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
    return $tea.cast<UpdateBizObjectResponse>(await this.doROARequest("UpdateBizObject", "h3yun_1.0", "HTTP", "PUT", "AK", `/v1.0/h3yun/forms/instances`, "json", req, runtime), new UpdateBizObjectResponse({}));
  }

  async queryProcessesInstance(request: QueryProcessesInstanceRequest): Promise<QueryProcessesInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProcessesInstanceHeaders({ });
    return await this.queryProcessesInstanceWithOptions(request, headers, runtime);
  }

  async queryProcessesInstanceWithOptions(request: QueryProcessesInstanceRequest, headers: QueryProcessesInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProcessesInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
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
    return $tea.cast<QueryProcessesInstanceResponse>(await this.doROARequest("QueryProcessesInstance", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/processes/instances`, "json", req, runtime), new QueryProcessesInstanceResponse({}));
  }

  async getRoles(): Promise<GetRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRolesHeaders({ });
    return await this.getRolesWithOptions(headers, runtime);
  }

  async getRolesWithOptions(headers: GetRolesHeaders, runtime: $Util.RuntimeOptions): Promise<GetRolesResponse> {
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
    return $tea.cast<GetRolesResponse>(await this.doROARequest("GetRoles", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/roles`, "json", req, runtime), new GetRolesResponse({}));
  }

  async getOrganizations(request: GetOrganizationsRequest): Promise<GetOrganizationsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizationsHeaders({ });
    return await this.getOrganizationsWithOptions(request, headers, runtime);
  }

  async getOrganizationsWithOptions(request: GetOrganizationsRequest, headers: GetOrganizationsHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrganizationsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
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
    return $tea.cast<GetOrganizationsResponse>(await this.doROARequest("GetOrganizations", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/departments`, "json", req, runtime), new GetOrganizationsResponse({}));
  }

  async deleteBizObject(request: DeleteBizObjectRequest): Promise<DeleteBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteBizObjectHeaders({ });
    return await this.deleteBizObjectWithOptions(request, headers, runtime);
  }

  async deleteBizObjectWithOptions(request: DeleteBizObjectRequest, headers: DeleteBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteBizObjectResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
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
    return $tea.cast<DeleteBizObjectResponse>(await this.doROARequest("DeleteBizObject", "h3yun_1.0", "HTTP", "DELETE", "AK", `/v1.0/h3yun/forms/instances`, "json", req, runtime), new DeleteBizObjectResponse({}));
  }

  async queryAppFunctionNodes(request: QueryAppFunctionNodesRequest): Promise<QueryAppFunctionNodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAppFunctionNodesHeaders({ });
    return await this.queryAppFunctionNodesWithOptions(request, headers, runtime);
  }

  async queryAppFunctionNodesWithOptions(request: QueryAppFunctionNodesRequest, headers: QueryAppFunctionNodesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAppFunctionNodesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appCode)) {
      query["appCode"] = request.appCode;
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
    return $tea.cast<QueryAppFunctionNodesResponse>(await this.doROARequest("QueryAppFunctionNodes", "h3yun_1.0", "HTTP", "GET", "AK", `/v1.0/h3yun/apps/functionNodes`, "json", req, runtime), new QueryAppFunctionNodesResponse({}));
  }

  async createBizObject(request: CreateBizObjectRequest): Promise<CreateBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBizObjectHeaders({ });
    return await this.createBizObjectWithOptions(request, headers, runtime);
  }

  async createBizObjectWithOptions(request: CreateBizObjectRequest, headers: CreateBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBizObjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.bizObjectJson)) {
      body["bizObjectJson"] = request.bizObjectJson;
    }

    if (!Util.isUnset(request.isDraft)) {
      body["isDraft"] = request.isDraft;
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
    return $tea.cast<CreateBizObjectResponse>(await this.doROARequest("CreateBizObject", "h3yun_1.0", "HTTP", "POST", "AK", `/v1.0/h3yun/forms/instances`, "json", req, runtime), new CreateBizObjectResponse({}));
  }

  async getApps(request: GetAppsRequest): Promise<GetAppsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppsHeaders({ });
    return await this.getAppsWithOptions(request, headers, runtime);
  }

  async getAppsWithOptions(request: GetAppsRequest, headers: GetAppsHeaders, runtime: $Util.RuntimeOptions): Promise<GetAppsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.queryType)) {
      body["queryType"] = request.queryType;
    }

    if (!Util.isUnset(request.values)) {
      body["values"] = request.values;
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
    return $tea.cast<GetAppsResponse>(await this.doROARequest("GetApps", "h3yun_1.0", "HTTP", "POST", "AK", `/v1.0/h3yun/apps/search`, "json", req, runtime), new GetAppsResponse({}));
  }

  async createProcessesInstance(request: CreateProcessesInstanceRequest): Promise<CreateProcessesInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProcessesInstanceHeaders({ });
    return await this.createProcessesInstanceWithOptions(request, headers, runtime);
  }

  async createProcessesInstanceWithOptions(request: CreateProcessesInstanceRequest, headers: CreateProcessesInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProcessesInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.bizObjectId)) {
      body["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
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
    return $tea.cast<CreateProcessesInstanceResponse>(await this.doROARequest("CreateProcessesInstance", "h3yun_1.0", "HTTP", "POST", "AK", `/v1.0/h3yun/processes/instances`, "json", req, runtime), new CreateProcessesInstanceResponse({}));
  }

  async batchInsertBizObject(request: BatchInsertBizObjectRequest): Promise<BatchInsertBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchInsertBizObjectHeaders({ });
    return await this.batchInsertBizObjectWithOptions(request, headers, runtime);
  }

  async batchInsertBizObjectWithOptions(request: BatchInsertBizObjectRequest, headers: BatchInsertBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<BatchInsertBizObjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.bizObjectJsonArray)) {
      body["bizObjectJsonArray"] = request.bizObjectJsonArray;
    }

    if (!Util.isUnset(request.isDraft)) {
      body["isDraft"] = request.isDraft;
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
    return $tea.cast<BatchInsertBizObjectResponse>(await this.doROARequest("BatchInsertBizObject", "h3yun_1.0", "HTTP", "POST", "AK", `/v1.0/h3yun/forms/instances/batch`, "json", req, runtime), new BatchInsertBizObjectResponse({}));
  }

}
