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

export class DentryAppPropertiesValue extends $tea.Model {
  name?: string;
  value?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
      visibility: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionRequest extends $tea.Model {
  members?: AddPermissionRequestMembers[];
  option?: AddPermissionRequestOption;
  roleId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      option: 'option',
      roleId: 'roleId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': AddPermissionRequestMembers },
      option: AddPermissionRequestOption,
      roleId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionResponseBody extends $tea.Model {
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

export class AddPermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddPermissionResponseBody;
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
      body: AddPermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileRequest extends $tea.Model {
  name?: string;
  option?: CommitFileRequestOption;
  uploadKey?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      option: 'option',
      uploadKey: 'uploadKey',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      option: CommitFileRequestOption,
      uploadKey: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileResponseBody extends $tea.Model {
  dentry?: CommitFileResponseBodyDentry;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: CommitFileResponseBodyDentry,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CommitFileResponseBody;
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
      body: CommitFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionRequest extends $tea.Model {
  members?: DeletePermissionRequestMembers[];
  roleId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      roleId: 'roleId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': DeletePermissionRequestMembers },
      roleId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionResponseBody extends $tea.Model {
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

export class DeletePermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeletePermissionResponseBody;
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
      body: DeletePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoRequest extends $tea.Model {
  option?: GetFileUploadInfoRequestOption;
  protocol?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      protocol: 'protocol',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetFileUploadInfoRequestOption,
      protocol: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoResponseBody extends $tea.Model {
  headerSignatureInfo?: GetFileUploadInfoResponseBodyHeaderSignatureInfo;
  protocol?: string;
  storageDriver?: string;
  uploadKey?: string;
  static names(): { [key: string]: string } {
    return {
      headerSignatureInfo: 'headerSignatureInfo',
      protocol: 'protocol',
      storageDriver: 'storageDriver',
      uploadKey: 'uploadKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headerSignatureInfo: GetFileUploadInfoResponseBodyHeaderSignatureInfo,
      protocol: 'string',
      storageDriver: 'string',
      uploadKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFileUploadInfoResponseBody;
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
      body: GetFileUploadInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionInheritanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionInheritanceRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionInheritanceResponseBody extends $tea.Model {
  inheritance?: string;
  static names(): { [key: string]: string } {
    return {
      inheritance: 'inheritance',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inheritance: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionInheritanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPermissionInheritanceResponseBody;
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
      body: GetPermissionInheritanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsRequest extends $tea.Model {
  option?: ListPermissionsRequestOption;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: ListPermissionsRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBody extends $tea.Model {
  nextToken?: string;
  permissions?: ListPermissionsResponseBodyPermissions[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      permissions: 'permissions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      permissions: { 'type': 'array', 'itemType': ListPermissionsResponseBodyPermissions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListPermissionsResponseBody;
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
      body: ListPermissionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerGetDefaultHandOverUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerGetDefaultHandOverUserRequest extends $tea.Model {
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerGetDefaultHandOverUserResponseBody extends $tea.Model {
  defaultHandoverUserId?: string;
  static names(): { [key: string]: string } {
    return {
      defaultHandoverUserId: 'defaultHandoverUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultHandoverUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerGetDefaultHandOverUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ManagerGetDefaultHandOverUserResponseBody;
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
      body: ManagerGetDefaultHandOverUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerSetDefaultHandOverUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerSetDefaultHandOverUserRequest extends $tea.Model {
  defaultHandoverUserId?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      defaultHandoverUserId: 'defaultHandoverUserId',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultHandoverUserId: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagerSetDefaultHandOverUserResponseBody extends $tea.Model {
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

export class ManagerSetDefaultHandOverUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ManagerSetDefaultHandOverUserResponseBody;
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
      body: ManagerSetDefaultHandOverUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesRequest extends $tea.Model {
  keyword?: string;
  option?: SearchDentriesRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      option: SearchDentriesRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesResponseBody extends $tea.Model {
  items?: SearchDentriesResponseBodyItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': SearchDentriesResponseBodyItems },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchDentriesResponseBody;
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
      body: SearchDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspacesRequest extends $tea.Model {
  keyword?: string;
  option?: SearchWorkspacesRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      option: SearchWorkspacesRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspacesResponseBody extends $tea.Model {
  items?: SearchWorkspacesResponseBodyItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': SearchWorkspacesResponseBodyItems },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchWorkspacesResponseBody;
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
      body: SearchWorkspacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetPermissionInheritanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetPermissionInheritanceRequest extends $tea.Model {
  inheritance?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      inheritance: 'inheritance',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inheritance: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetPermissionInheritanceResponseBody extends $tea.Model {
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

export class SetPermissionInheritanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetPermissionInheritanceResponseBody;
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
      body: SetPermissionInheritanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionRequest extends $tea.Model {
  members?: UpdatePermissionRequestMembers[];
  option?: UpdatePermissionRequestOption;
  roleId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      option: 'option',
      roleId: 'roleId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': UpdatePermissionRequestMembers },
      option: UpdatePermissionRequestOption,
      roleId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionResponseBody extends $tea.Model {
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

export class UpdatePermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdatePermissionResponseBody;
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
      body: UpdatePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionRequestMembers extends $tea.Model {
  corpId?: string;
  id?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionRequestOption extends $tea.Model {
  duration?: number;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileRequestOptionAppProperties extends $tea.Model {
  name?: string;
  value?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
      visibility: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileRequestOption extends $tea.Model {
  appProperties?: CommitFileRequestOptionAppProperties[];
  conflictStrategy?: string;
  convertToOnlineDoc?: boolean;
  convertToOnlineDocTargetDocumentType?: string;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      conflictStrategy: 'conflictStrategy',
      convertToOnlineDoc: 'convertToOnlineDoc',
      convertToOnlineDocTargetDocumentType: 'convertToOnlineDocTargetDocumentType',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'array', 'itemType': CommitFileRequestOptionAppProperties },
      conflictStrategy: 'string',
      convertToOnlineDoc: 'boolean',
      convertToOnlineDocTargetDocumentType: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileResponseBodyDentryProperties extends $tea.Model {
  readOnly?: boolean;
  static names(): { [key: string]: string } {
    return {
      readOnly: 'readOnly',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readOnly: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileResponseBodyDentryThumbnail extends $tea.Model {
  height?: number;
  url?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      url: 'url',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      url: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  category?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  partitionType?: string;
  path?: string;
  properties?: CommitFileResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  thumbnail?: CommitFileResponseBodyDentryThumbnail;
  type?: string;
  uuid?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      category: 'category',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      partitionType: 'partitionType',
      path: 'path',
      properties: 'properties',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      storageDriver: 'storageDriver',
      thumbnail: 'thumbnail',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
      category: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      partitionType: 'string',
      path: 'string',
      properties: CommitFileResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: CommitFileResponseBodyDentryThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionRequestMembers extends $tea.Model {
  corpId?: string;
  id?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoRequestOptionPreCheckParam extends $tea.Model {
  name?: string;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoRequestOption extends $tea.Model {
  preCheckParam?: GetFileUploadInfoRequestOptionPreCheckParam;
  preferIntranet?: boolean;
  preferRegion?: string;
  storageDriver?: string;
  static names(): { [key: string]: string } {
    return {
      preCheckParam: 'preCheckParam',
      preferIntranet: 'preferIntranet',
      preferRegion: 'preferRegion',
      storageDriver: 'storageDriver',
    };
  }

  static types(): { [key: string]: any } {
    return {
      preCheckParam: GetFileUploadInfoRequestOptionPreCheckParam,
      preferIntranet: 'boolean',
      preferRegion: 'string',
      storageDriver: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoResponseBodyHeaderSignatureInfo extends $tea.Model {
  expirationSeconds?: number;
  headers?: { [key: string]: string };
  internalResourceUrls?: string[];
  region?: string;
  resourceUrls?: string[];
  static names(): { [key: string]: string } {
    return {
      expirationSeconds: 'expirationSeconds',
      headers: 'headers',
      internalResourceUrls: 'internalResourceUrls',
      region: 'region',
      resourceUrls: 'resourceUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationSeconds: 'number',
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      internalResourceUrls: { 'type': 'array', 'itemType': 'string' },
      region: 'string',
      resourceUrls: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsRequestOption extends $tea.Model {
  filterRoleIds?: string[];
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      filterRoleIds: 'filterRoleIds',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filterRoleIds: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyPermissionsMember extends $tea.Model {
  corpId?: string;
  id?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyPermissionsRole extends $tea.Model {
  id?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyPermissions extends $tea.Model {
  dentryUuid?: string;
  duration?: number;
  member?: ListPermissionsResponseBodyPermissionsMember;
  role?: ListPermissionsResponseBodyPermissionsRole;
  static names(): { [key: string]: string } {
    return {
      dentryUuid: 'dentryUuid',
      duration: 'duration',
      member: 'member',
      role: 'role',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryUuid: 'string',
      duration: 'number',
      member: ListPermissionsResponseBodyPermissionsMember,
      role: ListPermissionsResponseBodyPermissionsRole,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesRequestOptionCreateTimeRange extends $tea.Model {
  endTime?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesRequestOptionVisitTimeRange extends $tea.Model {
  endTime?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesRequestOption extends $tea.Model {
  createTimeRange?: SearchDentriesRequestOptionCreateTimeRange;
  creatorIds?: string[];
  dentryCategories?: string[];
  maxResults?: number;
  modifierIds?: string[];
  nextToken?: string;
  visitTimeRange?: SearchDentriesRequestOptionVisitTimeRange;
  static names(): { [key: string]: string } {
    return {
      createTimeRange: 'createTimeRange',
      creatorIds: 'creatorIds',
      dentryCategories: 'dentryCategories',
      maxResults: 'maxResults',
      modifierIds: 'modifierIds',
      nextToken: 'nextToken',
      visitTimeRange: 'visitTimeRange',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTimeRange: SearchDentriesRequestOptionCreateTimeRange,
      creatorIds: { 'type': 'array', 'itemType': 'string' },
      dentryCategories: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      modifierIds: { 'type': 'array', 'itemType': 'string' },
      nextToken: 'string',
      visitTimeRange: SearchDentriesRequestOptionVisitTimeRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesResponseBodyItemsCreator extends $tea.Model {
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesResponseBodyItemsModifier extends $tea.Model {
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDentriesResponseBodyItems extends $tea.Model {
  creator?: SearchDentriesResponseBodyItemsCreator;
  dentryUuid?: string;
  modifier?: SearchDentriesResponseBodyItemsModifier;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      dentryUuid: 'dentryUuid',
      modifier: 'modifier',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: SearchDentriesResponseBodyItemsCreator,
      dentryUuid: 'string',
      modifier: SearchDentriesResponseBodyItemsModifier,
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspacesRequestOption extends $tea.Model {
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

export class SearchWorkspacesResponseBodyItems extends $tea.Model {
  name?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionRequestMembers extends $tea.Model {
  corpId?: string;
  id?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePermissionRequestOption extends $tea.Model {
  duration?: number;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
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


  async addPermissionWithOptions(dentryUuid: string, request: AddPermissionRequest, headers: AddPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<AddPermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.roleId)) {
      body["roleId"] = request.roleId;
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
      action: "AddPermission",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/dentries/${dentryUuid}/permissions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddPermissionResponse>(await this.execute(params, req, runtime), new AddPermissionResponse({}));
  }

  async addPermission(dentryUuid: string, request: AddPermissionRequest): Promise<AddPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPermissionHeaders({ });
    return await this.addPermissionWithOptions(dentryUuid, request, headers, runtime);
  }

  async commitFileWithOptions(parentDentryUuid: string, request: CommitFileRequest, headers: CommitFileHeaders, runtime: $Util.RuntimeOptions): Promise<CommitFileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.uploadKey)) {
      body["uploadKey"] = request.uploadKey;
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
      action: "CommitFile",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/files/${parentDentryUuid}/commit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CommitFileResponse>(await this.execute(params, req, runtime), new CommitFileResponse({}));
  }

  async commitFile(parentDentryUuid: string, request: CommitFileRequest): Promise<CommitFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CommitFileHeaders({ });
    return await this.commitFileWithOptions(parentDentryUuid, request, headers, runtime);
  }

  async deletePermissionWithOptions(dentryUuid: string, request: DeletePermissionRequest, headers: DeletePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.roleId)) {
      body["roleId"] = request.roleId;
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
      action: "DeletePermission",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/dentries/${dentryUuid}/permissions/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeletePermissionResponse>(await this.execute(params, req, runtime), new DeletePermissionResponse({}));
  }

  async deletePermission(dentryUuid: string, request: DeletePermissionRequest): Promise<DeletePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePermissionHeaders({ });
    return await this.deletePermissionWithOptions(dentryUuid, request, headers, runtime);
  }

  async getFileUploadInfoWithOptions(parentDentryUuid: string, request: GetFileUploadInfoRequest, headers: GetFileUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileUploadInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.protocol)) {
      body["protocol"] = request.protocol;
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
      action: "GetFileUploadInfo",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/files/${parentDentryUuid}/uploadInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFileUploadInfoResponse>(await this.execute(params, req, runtime), new GetFileUploadInfoResponse({}));
  }

  async getFileUploadInfo(parentDentryUuid: string, request: GetFileUploadInfoRequest): Promise<GetFileUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadInfoHeaders({ });
    return await this.getFileUploadInfoWithOptions(parentDentryUuid, request, headers, runtime);
  }

  async getPermissionInheritanceWithOptions(dentryUuid: string, request: GetPermissionInheritanceRequest, headers: GetPermissionInheritanceHeaders, runtime: $Util.RuntimeOptions): Promise<GetPermissionInheritanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetPermissionInheritance",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/dentries/${dentryUuid}/permissions/inheritances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPermissionInheritanceResponse>(await this.execute(params, req, runtime), new GetPermissionInheritanceResponse({}));
  }

  async getPermissionInheritance(dentryUuid: string, request: GetPermissionInheritanceRequest): Promise<GetPermissionInheritanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPermissionInheritanceHeaders({ });
    return await this.getPermissionInheritanceWithOptions(dentryUuid, request, headers, runtime);
  }

  async listPermissionsWithOptions(dentryUuid: string, request: ListPermissionsRequest, headers: ListPermissionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListPermissionsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "ListPermissions",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/dentries/${dentryUuid}/permissions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListPermissionsResponse>(await this.execute(params, req, runtime), new ListPermissionsResponse({}));
  }

  async listPermissions(dentryUuid: string, request: ListPermissionsRequest): Promise<ListPermissionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPermissionsHeaders({ });
    return await this.listPermissionsWithOptions(dentryUuid, request, headers, runtime);
  }

  async managerGetDefaultHandOverUserWithOptions(request: ManagerGetDefaultHandOverUserRequest, headers: ManagerGetDefaultHandOverUserHeaders, runtime: $Util.RuntimeOptions): Promise<ManagerGetDefaultHandOverUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "ManagerGetDefaultHandOverUser",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/managementSettings/defaultHandOverUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ManagerGetDefaultHandOverUserResponse>(await this.execute(params, req, runtime), new ManagerGetDefaultHandOverUserResponse({}));
  }

  async managerGetDefaultHandOverUser(request: ManagerGetDefaultHandOverUserRequest): Promise<ManagerGetDefaultHandOverUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ManagerGetDefaultHandOverUserHeaders({ });
    return await this.managerGetDefaultHandOverUserWithOptions(request, headers, runtime);
  }

  async managerSetDefaultHandOverUserWithOptions(request: ManagerSetDefaultHandOverUserRequest, headers: ManagerSetDefaultHandOverUserHeaders, runtime: $Util.RuntimeOptions): Promise<ManagerSetDefaultHandOverUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.defaultHandoverUserId)) {
      body["defaultHandoverUserId"] = request.defaultHandoverUserId;
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
      action: "ManagerSetDefaultHandOverUser",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/managementSettings/defaultHandOverUsers/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ManagerSetDefaultHandOverUserResponse>(await this.execute(params, req, runtime), new ManagerSetDefaultHandOverUserResponse({}));
  }

  async managerSetDefaultHandOverUser(request: ManagerSetDefaultHandOverUserRequest): Promise<ManagerSetDefaultHandOverUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ManagerSetDefaultHandOverUserHeaders({ });
    return await this.managerSetDefaultHandOverUserWithOptions(request, headers, runtime);
  }

  async searchDentriesWithOptions(request: SearchDentriesRequest, headers: SearchDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<SearchDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "SearchDentries",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/dentries/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchDentriesResponse>(await this.execute(params, req, runtime), new SearchDentriesResponse({}));
  }

  async searchDentries(request: SearchDentriesRequest): Promise<SearchDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchDentriesHeaders({ });
    return await this.searchDentriesWithOptions(request, headers, runtime);
  }

  async searchWorkspacesWithOptions(request: SearchWorkspacesRequest, headers: SearchWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<SearchWorkspacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "SearchWorkspaces",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/workspaces/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchWorkspacesResponse>(await this.execute(params, req, runtime), new SearchWorkspacesResponse({}));
  }

  async searchWorkspaces(request: SearchWorkspacesRequest): Promise<SearchWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchWorkspacesHeaders({ });
    return await this.searchWorkspacesWithOptions(request, headers, runtime);
  }

  async setPermissionInheritanceWithOptions(dentryUuid: string, request: SetPermissionInheritanceRequest, headers: SetPermissionInheritanceHeaders, runtime: $Util.RuntimeOptions): Promise<SetPermissionInheritanceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.inheritance)) {
      body["inheritance"] = request.inheritance;
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
      action: "SetPermissionInheritance",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/dentries/${dentryUuid}/permissions/inheritances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetPermissionInheritanceResponse>(await this.execute(params, req, runtime), new SetPermissionInheritanceResponse({}));
  }

  async setPermissionInheritance(dentryUuid: string, request: SetPermissionInheritanceRequest): Promise<SetPermissionInheritanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetPermissionInheritanceHeaders({ });
    return await this.setPermissionInheritanceWithOptions(dentryUuid, request, headers, runtime);
  }

  async updatePermissionWithOptions(dentryUuid: string, request: UpdatePermissionRequest, headers: UpdatePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.roleId)) {
      body["roleId"] = request.roleId;
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
      action: "UpdatePermission",
      version: "storage_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/storage/spaces/dentries/${dentryUuid}/permissions`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdatePermissionResponse>(await this.execute(params, req, runtime), new UpdatePermissionResponse({}));
  }

  async updatePermission(dentryUuid: string, request: UpdatePermissionRequest): Promise<UpdatePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePermissionHeaders({ });
    return await this.updatePermissionWithOptions(dentryUuid, request, headers, runtime);
  }

}
