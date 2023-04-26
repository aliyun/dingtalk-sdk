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
  bizObjectJsonArray?: string[];
  isDraft?: boolean;
  opUserId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectJsonArray: 'bizObjectJsonArray',
      isDraft: 'isDraft',
      opUserId: 'opUserId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectJsonArray: { 'type': 'array', 'itemType': 'string' },
      isDraft: 'boolean',
      opUserId: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectResponseBody extends $tea.Model {
  code?: string;
  data?: BatchInsertBizObjectResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: BatchInsertBizObjectResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchInsertBizObjectResponseBody;
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
      body: BatchInsertBizObjectResponseBody,
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
  statusCode: number;
  body: CancelProcessInstanceResponseBody;
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
      body: CancelProcessInstanceResponseBody,
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
  bizObjectJson?: string;
  isDraft?: boolean;
  opUserId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectJson: 'bizObjectJson',
      isDraft: 'isDraft',
      opUserId: 'opUserId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectJson: 'string',
      isDraft: 'boolean',
      opUserId: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectResponseBody extends $tea.Model {
  code?: string;
  data?: CreateBizObjectResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: CreateBizObjectResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateBizObjectResponseBody;
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
      body: CreateBizObjectResponseBody,
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
  bizObjectId?: string;
  opUserId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      opUserId: 'opUserId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      opUserId: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceResponseBody extends $tea.Model {
  code?: string;
  data?: CreateProcessesInstanceResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: CreateProcessesInstanceResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessesInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateProcessesInstanceResponseBody;
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
      body: CreateProcessesInstanceResponseBody,
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
  bizObjectId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      schemaCode: 'string',
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
  statusCode: number;
  body: DeleteBizObjectResponseBody;
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
      body: DeleteBizObjectResponseBody,
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
  isAutoUpdateBizObject?: boolean;
  processInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      isAutoUpdateBizObject: 'isAutoUpdateBizObject',
      processInstanceId: 'processInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isAutoUpdateBizObject: 'boolean',
      processInstanceId: 'string',
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
  statusCode: number;
  body: DeleteProcessesInstanceResponseBody;
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
      body: DeleteProcessesInstanceResponseBody,
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
  data?: GetAppsResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': GetAppsResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAppsResponseBody;
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
      body: GetAppsResponseBody,
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
  data?: GetAttachmentTemporaryUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: GetAttachmentTemporaryUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachmentTemporaryUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAttachmentTemporaryUrlResponseBody;
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
      body: GetAttachmentTemporaryUrlResponseBody,
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
  data?: GetOrganizationsResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': GetOrganizationsResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrganizationsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOrganizationsResponseBody;
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
      body: GetOrganizationsResponseBody,
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
  data?: GetRoleUsersResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': GetRoleUsersResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRoleUsersResponseBody;
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
      body: GetRoleUsersResponseBody,
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
  data?: GetRolesResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: GetRolesResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRolesResponseBody;
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
      body: GetRolesResponseBody,
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
  bizObjectId?: string;
  fieldName?: string;
  isOverwrite?: boolean;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      fieldName: 'fieldName',
      isOverwrite: 'isOverwrite',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      fieldName: 'string',
      isOverwrite: 'boolean',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponseBody extends $tea.Model {
  code?: string;
  data?: GetUploadUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: GetUploadUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUploadUrlResponseBody;
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
  data?: GetUsersResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': GetUsersResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUsersResponseBody;
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
      body: GetUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  data?: LoadBizFieldsResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: LoadBizFieldsResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: LoadBizFieldsResponseBody;
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
      body: LoadBizFieldsResponseBody,
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
  bizObjectId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectResponseBody extends $tea.Model {
  code?: string;
  data?: { [key: string]: any };
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: LoadBizObjectResponseBody;
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
  matcherJson?: string;
  pageNumber?: number;
  pageSize?: number;
  returnFields?: string[];
  schemaCode?: string;
  sortByFields?: LoadBizObjectsRequestSortByFields[];
  static names(): { [key: string]: string } {
    return {
      matcherJson: 'matcherJson',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      returnFields: 'returnFields',
      schemaCode: 'schemaCode',
      sortByFields: 'sortByFields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      matcherJson: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      returnFields: { 'type': 'array', 'itemType': 'string' },
      schemaCode: 'string',
      sortByFields: { 'type': 'array', 'itemType': LoadBizObjectsRequestSortByFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsResponseBody extends $tea.Model {
  code?: string;
  data?: LoadBizObjectsResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: LoadBizObjectsResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: LoadBizObjectsResponseBody;
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
      body: LoadBizObjectsResponseBody,
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
  data?: QueryAppFunctionNodesResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': QueryAppFunctionNodesResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryAppFunctionNodesResponseBody;
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
      body: QueryAppFunctionNodesResponseBody,
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
  bizObjectId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponseBody extends $tea.Model {
  code?: string;
  data?: QueryProcessesInstanceResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': QueryProcessesInstanceResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryProcessesInstanceResponseBody;
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
      body: QueryProcessesInstanceResponseBody,
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
  data?: QueryProcessesWorkItemsResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': QueryProcessesWorkItemsResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryProcessesWorkItemsResponseBody;
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
  bizObjectId?: string;
  bizObjectJson?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      bizObjectJson: 'bizObjectJson',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      bizObjectJson: 'string',
      schemaCode: 'string',
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
  statusCode: number;
  body: UpdateBizObjectResponseBody;
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
      body: UpdateBizObjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertBizObjectResponseBodyData extends $tea.Model {
  bizObjectIds?: string[];
  failedDatas?: string[];
  failedMessages?: string[];
  processIds?: string[];
  static names(): { [key: string]: string } {
    return {
      bizObjectIds: 'bizObjectIds',
      failedDatas: 'failedDatas',
      failedMessages: 'failedMessages',
      processIds: 'processIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectIds: { 'type': 'array', 'itemType': 'string' },
      failedDatas: { 'type': 'array', 'itemType': 'string' },
      failedMessages: { 'type': 'array', 'itemType': 'string' },
      processIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBizObjectResponseBodyData extends $tea.Model {
  bizObjectId?: string;
  formUsageType?: string;
  processInstanceId?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizObjectId: 'bizObjectId',
      formUsageType: 'formUsageType',
      processInstanceId: 'processInstanceId',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjectId: 'string',
      formUsageType: 'string',
      processInstanceId: 'string',
      schemaCode: 'string',
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

export class GetAppsResponseBodyData extends $tea.Model {
  appCode?: string;
  appSource?: string;
  appState?: string;
  displayName?: string;
  solution?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      appSource: 'appSource',
      appState: 'appState',
      displayName: 'displayName',
      solution: 'solution',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      appSource: 'string',
      appState: 'string',
      displayName: 'string',
      solution: 'string',
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

export class GetOrganizationsResponseBodyData extends $tea.Model {
  code?: string;
  description?: string;
  id?: string;
  name?: string;
  parentId?: string;
  sortKey?: number;
  unitType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      description: 'description',
      id: 'id',
      name: 'name',
      parentId: 'parentId',
      sortKey: 'sortKey',
      unitType: 'unitType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      description: 'string',
      id: 'string',
      name: 'string',
      parentId: 'string',
      sortKey: 'number',
      unitType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRoleUsersResponseBodyData extends $tea.Model {
  code?: string;
  departmentId?: string;
  departmentName?: string;
  description?: string;
  domainType?: string;
  email?: string;
  mobile?: string;
  name?: string;
  partDepartmentIds?: string[];
  sex?: string;
  sortKey?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      description: 'description',
      domainType: 'domainType',
      email: 'email',
      mobile: 'mobile',
      name: 'name',
      partDepartmentIds: 'partDepartmentIds',
      sex: 'sex',
      sortKey: 'sortKey',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      departmentId: 'string',
      departmentName: 'string',
      description: 'string',
      domainType: 'string',
      email: 'string',
      mobile: 'string',
      name: 'string',
      partDepartmentIds: { 'type': 'array', 'itemType': 'string' },
      sex: 'string',
      sortKey: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponseBodyDataRoleGroups extends $tea.Model {
  companyId?: string;
  description?: string;
  groupCode?: string;
  groupId?: string;
  groupName?: string;
  state?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      companyId: 'companyId',
      description: 'description',
      groupCode: 'groupCode',
      groupId: 'groupId',
      groupName: 'groupName',
      state: 'state',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyId: 'string',
      description: 'string',
      groupCode: 'string',
      groupId: 'string',
      groupName: 'string',
      state: 'string',
      visibility: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRolesResponseBodyDataRoles extends $tea.Model {
  companyId?: string;
  description?: string;
  groupId?: string;
  roleCode?: string;
  roleId?: string;
  roleName?: string;
  state?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      companyId: 'companyId',
      description: 'description',
      groupId: 'groupId',
      roleCode: 'roleCode',
      roleId: 'roleId',
      roleName: 'roleName',
      state: 'state',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyId: 'string',
      description: 'string',
      groupId: 'string',
      roleCode: 'string',
      roleId: 'string',
      roleName: 'string',
      state: 'string',
      visibility: 'string',
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
  code?: string;
  departmentId?: string;
  departmentName?: string;
  description?: string;
  domainType?: string;
  email?: string;
  id?: string;
  mobile?: string;
  name?: string;
  partDepartmentIds?: string[];
  sex?: string;
  sortKey?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      description: 'description',
      domainType: 'domainType',
      email: 'email',
      id: 'id',
      mobile: 'mobile',
      name: 'name',
      partDepartmentIds: 'partDepartmentIds',
      sex: 'sex',
      sortKey: 'sortKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      departmentId: 'string',
      departmentName: 'string',
      description: 'string',
      domainType: 'string',
      email: 'string',
      id: 'string',
      mobile: 'string',
      name: 'string',
      partDepartmentIds: { 'type': 'array', 'itemType': 'string' },
      sex: 'string',
      sortKey: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyDataChildFormsFields extends $tea.Model {
  bizDataType?: string;
  fieldName?: string;
  label?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataType: 'bizDataType',
      fieldName: 'fieldName',
      label: 'label',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataType: 'string',
      fieldName: 'string',
      label: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyDataChildForms extends $tea.Model {
  fields?: LoadBizFieldsResponseBodyDataChildFormsFields[];
  formName?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      fields: 'fields',
      formName: 'formName',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fields: { 'type': 'array', 'itemType': LoadBizFieldsResponseBodyDataChildFormsFields },
      formName: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyDataFields extends $tea.Model {
  bizDataType?: string;
  fieldName?: string;
  label?: string;
  static names(): { [key: string]: string } {
    return {
      bizDataType: 'bizDataType',
      fieldName: 'fieldName',
      label: 'label',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizDataType: 'string',
      fieldName: 'string',
      label: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizFieldsResponseBodyData extends $tea.Model {
  childForms?: LoadBizFieldsResponseBodyDataChildForms[];
  fields?: LoadBizFieldsResponseBodyDataFields[];
  formName?: string;
  schemaCode?: string;
  static names(): { [key: string]: string } {
    return {
      childForms: 'childForms',
      fields: 'fields',
      formName: 'formName',
      schemaCode: 'schemaCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      childForms: { 'type': 'array', 'itemType': LoadBizFieldsResponseBodyDataChildForms },
      fields: { 'type': 'array', 'itemType': LoadBizFieldsResponseBodyDataFields },
      formName: 'string',
      schemaCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsRequestSortByFields extends $tea.Model {
  direction?: string;
  fieldName?: string;
  static names(): { [key: string]: string } {
    return {
      direction: 'direction',
      fieldName: 'fieldName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      direction: 'string',
      fieldName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoadBizObjectsResponseBodyData extends $tea.Model {
  bizObjects?: { [key: string]: any }[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      bizObjects: 'bizObjects',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizObjects: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppFunctionNodesResponseBodyData extends $tea.Model {
  appCode?: string;
  displayName?: string;
  isSystem?: boolean;
  nodeType?: string;
  nodeVisibleType?: string;
  parentCode?: string;
  schemaCode?: string;
  sortKey?: number;
  state?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      displayName: 'displayName',
      isSystem: 'isSystem',
      nodeType: 'nodeType',
      nodeVisibleType: 'nodeVisibleType',
      parentCode: 'parentCode',
      schemaCode: 'schemaCode',
      sortKey: 'sortKey',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      displayName: 'string',
      isSystem: 'boolean',
      nodeType: 'string',
      nodeVisibleType: 'string',
      parentCode: 'string',
      schemaCode: 'string',
      sortKey: 'number',
      state: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponseBodyDataOriginator extends $tea.Model {
  departmentId?: string;
  departmentName?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'string',
      departmentName: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesInstanceResponseBodyData extends $tea.Model {
  appCode?: string;
  bizObjectId?: string;
  createdTimeGMT?: string;
  dingTalkProcessId?: string;
  finishTimeGMT?: string;
  originator?: QueryProcessesInstanceResponseBodyDataOriginator;
  processDisplayName?: string;
  processInstanceId?: string;
  processVersion?: number;
  schemaCode?: string;
  startTimeGMT?: string;
  state?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      bizObjectId: 'bizObjectId',
      createdTimeGMT: 'createdTimeGMT',
      dingTalkProcessId: 'dingTalkProcessId',
      finishTimeGMT: 'finishTimeGMT',
      originator: 'originator',
      processDisplayName: 'processDisplayName',
      processInstanceId: 'processInstanceId',
      processVersion: 'processVersion',
      schemaCode: 'schemaCode',
      startTimeGMT: 'startTimeGMT',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      bizObjectId: 'string',
      createdTimeGMT: 'string',
      dingTalkProcessId: 'string',
      finishTimeGMT: 'string',
      originator: QueryProcessesInstanceResponseBodyDataOriginator,
      processDisplayName: 'string',
      processInstanceId: 'string',
      processVersion: 'number',
      schemaCode: 'string',
      startTimeGMT: 'string',
      state: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyDataFinisher extends $tea.Model {
  departmentId?: string;
  departmentName?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'string',
      departmentName: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyDataParticipant extends $tea.Model {
  departmentId?: string;
  departmentName?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'string',
      departmentName: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyDataReceiptor extends $tea.Model {
  departmentId?: string;
  departmentName?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'string',
      departmentName: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProcessesWorkItemsResponseBodyData extends $tea.Model {
  activityCode?: string;
  activityName?: string;
  appCode?: string;
  bizObjectId?: string;
  comment?: string;
  displayName?: string;
  finishTimeGMT?: string;
  finisher?: QueryProcessesWorkItemsResponseBodyDataFinisher;
  isApproval?: boolean;
  isFinish?: boolean;
  participant?: QueryProcessesWorkItemsResponseBodyDataParticipant;
  processInstanceId?: string;
  processVersion?: string;
  receiptor?: QueryProcessesWorkItemsResponseBodyDataReceiptor;
  receiveTimeGMT?: string;
  schemaCode?: string;
  startTimeGMT?: string;
  state?: string;
  workItemId?: string;
  workItemType?: string;
  static names(): { [key: string]: string } {
    return {
      activityCode: 'activityCode',
      activityName: 'activityName',
      appCode: 'appCode',
      bizObjectId: 'bizObjectId',
      comment: 'comment',
      displayName: 'displayName',
      finishTimeGMT: 'finishTimeGMT',
      finisher: 'finisher',
      isApproval: 'isApproval',
      isFinish: 'isFinish',
      participant: 'participant',
      processInstanceId: 'processInstanceId',
      processVersion: 'processVersion',
      receiptor: 'receiptor',
      receiveTimeGMT: 'receiveTimeGMT',
      schemaCode: 'schemaCode',
      startTimeGMT: 'startTimeGMT',
      state: 'state',
      workItemId: 'workItemId',
      workItemType: 'workItemType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityCode: 'string',
      activityName: 'string',
      appCode: 'string',
      bizObjectId: 'string',
      comment: 'string',
      displayName: 'string',
      finishTimeGMT: 'string',
      finisher: QueryProcessesWorkItemsResponseBodyDataFinisher,
      isApproval: 'boolean',
      isFinish: 'boolean',
      participant: QueryProcessesWorkItemsResponseBodyDataParticipant,
      processInstanceId: 'string',
      processVersion: 'string',
      receiptor: QueryProcessesWorkItemsResponseBodyDataReceiptor,
      receiveTimeGMT: 'string',
      schemaCode: 'string',
      startTimeGMT: 'string',
      state: 'string',
      workItemId: 'string',
      workItemType: 'string',
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


  async batchInsertBizObjectWithOptions(request: BatchInsertBizObjectRequest, headers: BatchInsertBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<BatchInsertBizObjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectJsonArray)) {
      body["bizObjectJsonArray"] = request.bizObjectJsonArray;
    }

    if (!Util.isUnset(request.isDraft)) {
      body["isDraft"] = request.isDraft;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
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
      action: "BatchInsertBizObject",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/instances/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchInsertBizObjectResponse>(await this.execute(params, req, runtime), new BatchInsertBizObjectResponse({}));
  }

  async batchInsertBizObject(request: BatchInsertBizObjectRequest): Promise<BatchInsertBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchInsertBizObjectHeaders({ });
    return await this.batchInsertBizObjectWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CancelProcessInstance",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/processes/instances/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelProcessInstanceResponse>(await this.execute(params, req, runtime), new CancelProcessInstanceResponse({}));
  }

  async cancelProcessInstance(request: CancelProcessInstanceRequest): Promise<CancelProcessInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelProcessInstanceHeaders({ });
    return await this.cancelProcessInstanceWithOptions(request, headers, runtime);
  }

  async createBizObjectWithOptions(request: CreateBizObjectRequest, headers: CreateBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBizObjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectJson)) {
      body["bizObjectJson"] = request.bizObjectJson;
    }

    if (!Util.isUnset(request.isDraft)) {
      body["isDraft"] = request.isDraft;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
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
      action: "CreateBizObject",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateBizObjectResponse>(await this.execute(params, req, runtime), new CreateBizObjectResponse({}));
  }

  async createBizObject(request: CreateBizObjectRequest): Promise<CreateBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBizObjectHeaders({ });
    return await this.createBizObjectWithOptions(request, headers, runtime);
  }

  async createProcessesInstanceWithOptions(request: CreateProcessesInstanceRequest, headers: CreateProcessesInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProcessesInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectId)) {
      body["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
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
      action: "CreateProcessesInstance",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/processes/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateProcessesInstanceResponse>(await this.execute(params, req, runtime), new CreateProcessesInstanceResponse({}));
  }

  async createProcessesInstance(request: CreateProcessesInstanceRequest): Promise<CreateProcessesInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProcessesInstanceHeaders({ });
    return await this.createProcessesInstanceWithOptions(request, headers, runtime);
  }

  async deleteBizObjectWithOptions(request: DeleteBizObjectRequest, headers: DeleteBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteBizObjectResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
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
      action: "DeleteBizObject",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/instances`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteBizObjectResponse>(await this.execute(params, req, runtime), new DeleteBizObjectResponse({}));
  }

  async deleteBizObject(request: DeleteBizObjectRequest): Promise<DeleteBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteBizObjectHeaders({ });
    return await this.deleteBizObjectWithOptions(request, headers, runtime);
  }

  async deleteProcessesInstanceWithOptions(request: DeleteProcessesInstanceRequest, headers: DeleteProcessesInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteProcessesInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isAutoUpdateBizObject)) {
      query["isAutoUpdateBizObject"] = request.isAutoUpdateBizObject;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      query["processInstanceId"] = request.processInstanceId;
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
      action: "DeleteProcessesInstance",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/processes/instances`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteProcessesInstanceResponse>(await this.execute(params, req, runtime), new DeleteProcessesInstanceResponse({}));
  }

  async deleteProcessesInstance(request: DeleteProcessesInstanceRequest): Promise<DeleteProcessesInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteProcessesInstanceHeaders({ });
    return await this.deleteProcessesInstanceWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetApps",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/apps/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAppsResponse>(await this.execute(params, req, runtime), new GetAppsResponse({}));
  }

  async getApps(request: GetAppsRequest): Promise<GetAppsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppsHeaders({ });
    return await this.getAppsWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetAttachmentTemporaryUrl",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/attachments/temporaryUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAttachmentTemporaryUrlResponse>(await this.execute(params, req, runtime), new GetAttachmentTemporaryUrlResponse({}));
  }

  async getAttachmentTemporaryUrl(request: GetAttachmentTemporaryUrlRequest): Promise<GetAttachmentTemporaryUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAttachmentTemporaryUrlHeaders({ });
    return await this.getAttachmentTemporaryUrlWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetOrganizations",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/departments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrganizationsResponse>(await this.execute(params, req, runtime), new GetOrganizationsResponse({}));
  }

  async getOrganizations(request: GetOrganizationsRequest): Promise<GetOrganizationsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrganizationsHeaders({ });
    return await this.getOrganizationsWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetRoleUsers",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/roles/roleUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRoleUsersResponse>(await this.execute(params, req, runtime), new GetRoleUsersResponse({}));
  }

  async getRoleUsers(request: GetRoleUsersRequest): Promise<GetRoleUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRoleUsersHeaders({ });
    return await this.getRoleUsersWithOptions(request, headers, runtime);
  }

  async getRolesWithOptions(headers: GetRolesHeaders, runtime: $Util.RuntimeOptions): Promise<GetRolesResponse> {
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
      action: "GetRoles",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRolesResponse>(await this.execute(params, req, runtime), new GetRolesResponse({}));
  }

  async getRoles(): Promise<GetRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRolesHeaders({ });
    return await this.getRolesWithOptions(headers, runtime);
  }

  async getUploadUrlWithOptions(request: GetUploadUrlRequest, headers: GetUploadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.fieldName)) {
      query["fieldName"] = request.fieldName;
    }

    if (!Util.isUnset(request.isOverwrite)) {
      query["isOverwrite"] = request.isOverwrite;
    }

    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
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
      action: "GetUploadUrl",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/attachments/uploadUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUploadUrlResponse>(await this.execute(params, req, runtime), new GetUploadUrlResponse({}));
  }

  async getUploadUrl(request: GetUploadUrlRequest): Promise<GetUploadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadUrlHeaders({ });
    return await this.getUploadUrlWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetUsers",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUsersResponse>(await this.execute(params, req, runtime), new GetUsersResponse({}));
  }

  async getUsers(request: GetUsersRequest): Promise<GetUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUsersHeaders({ });
    return await this.getUsersWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "LoadBizFields",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/loadBizFields`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LoadBizFieldsResponse>(await this.execute(params, req, runtime), new LoadBizFieldsResponse({}));
  }

  async loadBizFields(request: LoadBizFieldsRequest): Promise<LoadBizFieldsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoadBizFieldsHeaders({ });
    return await this.loadBizFieldsWithOptions(request, headers, runtime);
  }

  async loadBizObjectWithOptions(request: LoadBizObjectRequest, headers: LoadBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<LoadBizObjectResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
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
      action: "LoadBizObject",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/instances/loadInstances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LoadBizObjectResponse>(await this.execute(params, req, runtime), new LoadBizObjectResponse({}));
  }

  async loadBizObject(request: LoadBizObjectRequest): Promise<LoadBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoadBizObjectHeaders({ });
    return await this.loadBizObjectWithOptions(request, headers, runtime);
  }

  async loadBizObjectsWithOptions(request: LoadBizObjectsRequest, headers: LoadBizObjectsHeaders, runtime: $Util.RuntimeOptions): Promise<LoadBizObjectsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.matcherJson)) {
      body["matcherJson"] = request.matcherJson;
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

    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
    }

    if (!Util.isUnset(request.sortByFields)) {
      body["sortByFields"] = request.sortByFields;
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
      action: "LoadBizObjects",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/instances/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LoadBizObjectsResponse>(await this.execute(params, req, runtime), new LoadBizObjectsResponse({}));
  }

  async loadBizObjects(request: LoadBizObjectsRequest): Promise<LoadBizObjectsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LoadBizObjectsHeaders({ });
    return await this.loadBizObjectsWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryAppFunctionNodes",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/apps/functionNodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAppFunctionNodesResponse>(await this.execute(params, req, runtime), new QueryAppFunctionNodesResponse({}));
  }

  async queryAppFunctionNodes(request: QueryAppFunctionNodesRequest): Promise<QueryAppFunctionNodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAppFunctionNodesHeaders({ });
    return await this.queryAppFunctionNodesWithOptions(request, headers, runtime);
  }

  async queryProcessesInstanceWithOptions(request: QueryProcessesInstanceRequest, headers: QueryProcessesInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProcessesInstanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectId)) {
      query["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.schemaCode)) {
      query["schemaCode"] = request.schemaCode;
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
      action: "QueryProcessesInstance",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/processes/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryProcessesInstanceResponse>(await this.execute(params, req, runtime), new QueryProcessesInstanceResponse({}));
  }

  async queryProcessesInstance(request: QueryProcessesInstanceRequest): Promise<QueryProcessesInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProcessesInstanceHeaders({ });
    return await this.queryProcessesInstanceWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "QueryProcessesWorkItems",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/processes/workItems`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryProcessesWorkItemsResponse>(await this.execute(params, req, runtime), new QueryProcessesWorkItemsResponse({}));
  }

  async queryProcessesWorkItems(request: QueryProcessesWorkItemsRequest): Promise<QueryProcessesWorkItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProcessesWorkItemsHeaders({ });
    return await this.queryProcessesWorkItemsWithOptions(request, headers, runtime);
  }

  async updateBizObjectWithOptions(request: UpdateBizObjectRequest, headers: UpdateBizObjectHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateBizObjectResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizObjectId)) {
      body["bizObjectId"] = request.bizObjectId;
    }

    if (!Util.isUnset(request.bizObjectJson)) {
      body["bizObjectJson"] = request.bizObjectJson;
    }

    if (!Util.isUnset(request.schemaCode)) {
      body["schemaCode"] = request.schemaCode;
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
      action: "UpdateBizObject",
      version: "h3yun_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h3yun/forms/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateBizObjectResponse>(await this.execute(params, req, runtime), new UpdateBizObjectResponse({}));
  }

  async updateBizObject(request: UpdateBizObjectRequest): Promise<UpdateBizObjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateBizObjectHeaders({ });
    return await this.updateBizObjectWithOptions(request, headers, runtime);
  }

}
