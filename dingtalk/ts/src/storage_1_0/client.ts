// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class DentryAppPropertiesValue extends $tea.Model {
  /**
   * @example
   * property_name
   */
  name?: string;
  /**
   * @example
   * property_value
   */
  value?: string;
  /**
   * @example
   * PRIVATE
   */
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

export class ResultItemsDentryAppPropertiesValue extends $tea.Model {
  /**
   * @example
   * property_name
   */
  name?: string;
  /**
   * @example
   * property_value
   */
  value?: string;
  /**
   * @example
   * PRIVATE
   */
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

export class DentriesAppPropertiesValue extends $tea.Model {
  /**
   * @example
   * property_name
   */
  name?: string;
  /**
   * @example
   * property_value
   */
  value?: string;
  /**
   * @example
   * PRIVATE
   */
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

export class AddFolderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFolderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dentry_name
   */
  name?: string;
  option?: AddFolderRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      option: AddFolderRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFolderResponseBody extends $tea.Model {
  dentry?: AddFolderResponseBodyDentry;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: AddFolderResponseBodyDentry,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFolderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddFolderResponseBody;
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
      body: AddFolderResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  members?: AddPermissionRequestMembers[];
  option?: AddPermissionRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * MANAGER
   */
  roleId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddPermissionResponseBody;
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

export class AddSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceRequest extends $tea.Model {
  option?: AddSpaceRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: AddSpaceRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponseBody extends $tea.Model {
  space?: AddSpaceResponseBodySpace;
  static names(): { [key: string]: string } {
    return {
      space: 'space',
    };
  }

  static types(): { [key: string]: any } {
    return {
      space: AddSpaceResponseBodySpace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddSpaceResponseBody;
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
      body: AddSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRecycleBinHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRecycleBinRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class ClearRecycleBinResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class ClearRecycleBinResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ClearRecycleBinResponseBody;
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
      body: ClearRecycleBinResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dentry_name
   */
  name?: string;
  option?: CommitFileRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * upload_key
   */
  uploadKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      option: 'option',
      parentId: 'parentId',
      uploadKey: 'uploadKey',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      option: CommitFileRequestOption,
      parentId: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CommitFileResponseBody;
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

export class CopyDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentriesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dentryIds?: string[];
  option?: CopyDentriesRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_folder_id
   */
  targetFolderId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_space_id
   */
  targetSpaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      option: 'option',
      targetFolderId: 'targetFolderId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      option: CopyDentriesRequestOption,
      targetFolderId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentriesResponseBody extends $tea.Model {
  resultItems?: CopyDentriesResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': CopyDentriesResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentriesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CopyDentriesResponseBody;
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
      body: CopyDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryRequest extends $tea.Model {
  option?: CopyDentryRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_folder_id
   */
  targetFolderId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_space_id
   */
  targetSpaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      targetFolderId: 'targetFolderId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: CopyDentryRequestOption,
      targetFolderId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  dentry?: CopyDentryResponseBodyDentry;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentry: 'dentry',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentry: CopyDentryResponseBodyDentry,
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CopyDentryResponseBody;
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
      body: CopyDentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentriesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dentryIds?: string[];
  option?: DeleteDentriesRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      option: DeleteDentriesRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentriesResponseBody extends $tea.Model {
  resultItems?: DeleteDentriesResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': DeleteDentriesResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentriesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDentriesResponseBody;
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
      body: DeleteDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryRequest extends $tea.Model {
  /**
   * @example
   * true
   */
  toRecycleBin?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      toRecycleBin: 'toRecycleBin',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      toRecycleBin: 'boolean',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDentryResponseBody;
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
      body: DeleteDentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryAppPropertiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryAppPropertiesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  propertyNames?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      propertyNames: 'propertyNames',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      propertyNames: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentryAppPropertiesResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class DeleteDentryAppPropertiesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDentryAppPropertiesResponseBody;
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
      body: DeleteDentryAppPropertiesResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  members?: DeletePermissionRequestMembers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * MANAGER
   */
  roleId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeletePermissionResponseBody;
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

export class DeleteRecycleItemHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecycleItemRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class DeleteRecycleItemResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class DeleteRecycleItemResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteRecycleItemResponseBody;
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
      body: DeleteRecycleItemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecycleItemsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecycleItemsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  recycleItemIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      recycleItemIds: 'recycleItemIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItemIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecycleItemsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class DeleteRecycleItemsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteRecycleItemsResponseBody;
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
      body: DeleteRecycleItemsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCurrentAppHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCurrentAppRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetCurrentAppResponseBody extends $tea.Model {
  app?: GetCurrentAppResponseBodyApp;
  static names(): { [key: string]: string } {
    return {
      app: 'app',
    };
  }

  static types(): { [key: string]: any } {
    return {
      app: GetCurrentAppResponseBodyApp,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCurrentAppResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCurrentAppResponseBody;
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
      body: GetCurrentAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dentryIds?: string[];
  option?: GetDentriesRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      option: GetDentriesRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBody extends $tea.Model {
  resultItems?: GetDentriesResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': GetDentriesResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDentriesResponseBody;
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
      body: GetDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryRequest extends $tea.Model {
  option?: GetDentryRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetDentryRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBody extends $tea.Model {
  dentry?: GetDentryResponseBodyDentry;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: GetDentryResponseBodyDentry,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDentryResponseBody;
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
      body: GetDentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryOpenInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryOpenInfoRequest extends $tea.Model {
  option?: GetDentryOpenInfoRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetDentryOpenInfoRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryOpenInfoResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasWaterMark?: boolean;
  /**
   * @example
   * url
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      hasWaterMark: 'hasWaterMark',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasWaterMark: 'boolean',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryOpenInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDentryOpenInfoResponseBody;
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
      body: GetDentryOpenInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dentryIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponseBody extends $tea.Model {
  resultItems?: GetDentryThumbnailsResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': GetDentryThumbnailsResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDentryThumbnailsResponseBody;
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
      body: GetDentryThumbnailsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoRequest extends $tea.Model {
  option?: GetFileDownloadInfoRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetFileDownloadInfoRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponseBody extends $tea.Model {
  headerSignatureInfo?: GetFileDownloadInfoResponseBodyHeaderSignatureInfo;
  /**
   * @example
   * HEADER_SIGNATURE
   */
  protocol?: string;
  static names(): { [key: string]: string } {
    return {
      headerSignatureInfo: 'headerSignatureInfo',
      protocol: 'protocol',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headerSignatureInfo: GetFileDownloadInfoResponseBodyHeaderSignatureInfo,
      protocol: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFileDownloadInfoResponseBody;
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
      body: GetFileDownloadInfoResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  multipart?: boolean;
  option?: GetFileUploadInfoRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * HEADER_SIGNATURE
   */
  protocol?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      multipart: 'multipart',
      option: 'option',
      protocol: 'protocol',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      multipart: 'boolean',
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
  /**
   * @example
   * HEADER_SIGNATURE
   */
  protocol?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * upload_key
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFileUploadInfoResponseBody;
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

export class GetMultipartFileUploadInfosHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultipartFileUploadInfosRequest extends $tea.Model {
  option?: GetMultipartFileUploadInfosRequestOption;
  /**
   * @remarks
   * This parameter is required.
   */
  partNumbers?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * upload_key
   */
  uploadKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      partNumbers: 'partNumbers',
      uploadKey: 'uploadKey',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetMultipartFileUploadInfosRequestOption,
      partNumbers: { 'type': 'array', 'itemType': 'number' },
      uploadKey: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultipartFileUploadInfosResponseBody extends $tea.Model {
  multipartHeaderSignatureInfos?: GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos[];
  static names(): { [key: string]: string } {
    return {
      multipartHeaderSignatureInfos: 'multipartHeaderSignatureInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      multipartHeaderSignatureInfos: { 'type': 'array', 'itemType': GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultipartFileUploadInfosResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMultipartFileUploadInfosResponseBody;
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
      body: GetMultipartFileUploadInfosResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetOrgResponseBody extends $tea.Model {
  org?: GetOrgResponseBodyOrg;
  static names(): { [key: string]: string } {
    return {
      org: 'org',
    };
  }

  static types(): { [key: string]: any } {
    return {
      org: GetOrgResponseBodyOrg,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOrgResponseBody;
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
      body: GetOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleBinHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleBinRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SPACE
   */
  recycleBinScope?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * scope_id
   */
  scopeId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      recycleBinScope: 'recycleBinScope',
      scopeId: 'scopeId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleBinScope: 'string',
      scopeId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleBinResponseBody extends $tea.Model {
  recycleBin?: GetRecycleBinResponseBodyRecycleBin;
  static names(): { [key: string]: string } {
    return {
      recycleBin: 'recycleBin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleBin: GetRecycleBinResponseBodyRecycleBin,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleBinResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRecycleBinResponseBody;
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
      body: GetRecycleBinResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleItemHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleItemRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetRecycleItemResponseBody extends $tea.Model {
  item?: GetRecycleItemResponseBodyItem;
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: GetRecycleItemResponseBodyItem,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleItemResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRecycleItemResponseBody;
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
      body: GetRecycleItemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetSpaceResponseBody extends $tea.Model {
  space?: GetSpaceResponseBodySpace;
  static names(): { [key: string]: string } {
    return {
      space: 'space',
    };
  }

  static types(): { [key: string]: any } {
    return {
      space: GetSpaceResponseBodySpace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpaceResponseBody;
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
      body: GetSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetTaskResponseBody extends $tea.Model {
  task?: GetTaskResponseBodyTask;
  static names(): { [key: string]: string } {
    return {
      task: 'task',
    };
  }

  static types(): { [key: string]: any } {
    return {
      task: GetTaskResponseBodyTask,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTaskResponseBody;
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
      body: GetTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWebOfficeUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWebOfficeUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetWebOfficeUrlResponseBody extends $tea.Model {
  webOfficeAccessToken?: string;
  webOfficeRefreshToken?: string;
  webOfficeUrl?: string;
  static names(): { [key: string]: string } {
    return {
      webOfficeAccessToken: 'webOfficeAccessToken',
      webOfficeRefreshToken: 'webOfficeRefreshToken',
      webOfficeUrl: 'webOfficeUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      webOfficeAccessToken: 'string',
      webOfficeRefreshToken: 'string',
      webOfficeUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWebOfficeUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetWebOfficeUrlResponseBody;
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
      body: GetWebOfficeUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitMultipartFileUploadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitMultipartFileUploadRequest extends $tea.Model {
  option?: InitMultipartFileUploadRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: InitMultipartFileUploadRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitMultipartFileUploadResponseBody extends $tea.Model {
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * upload_key
   */
  uploadKey?: string;
  static names(): { [key: string]: string } {
    return {
      storageDriver: 'storageDriver',
      uploadKey: 'uploadKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      storageDriver: 'string',
      uploadKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitMultipartFileUploadResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InitMultipartFileUploadResponseBody;
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
      body: InitMultipartFileUploadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesRequest extends $tea.Model {
  option?: ListAllDentriesRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: ListAllDentriesRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponseBody extends $tea.Model {
  dentries?: ListAllDentriesResponseBodyDentries[];
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      dentries: 'dentries',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentries: { 'type': 'array', 'itemType': ListAllDentriesResponseBodyDentries },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAllDentriesResponseBody;
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
      body: ListAllDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesRequest extends $tea.Model {
  /**
   * @example
   * 30
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * DESC
   */
  order?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  orderBy?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  /**
   * @example
   * true
   */
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
      orderBy: 'orderBy',
      parentId: 'parentId',
      unionId: 'unionId',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      order: 'string',
      orderBy: 'string',
      parentId: 'string',
      unionId: 'string',
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBody extends $tea.Model {
  dentries?: ListDentriesResponseBodyDentries[];
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      dentries: 'dentries',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentries: { 'type': 'array', 'itemType': ListDentriesResponseBodyDentries },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListDentriesResponseBody;
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
      body: ListDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentryVersionsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentryVersionsRequest extends $tea.Model {
  /**
   * @example
   * 30
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentryVersionsResponseBody extends $tea.Model {
  dentries?: ListDentryVersionsResponseBodyDentries[];
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      dentries: 'dentries',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentries: { 'type': 'array', 'itemType': ListDentryVersionsResponseBodyDentries },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentryVersionsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListDentryVersionsResponseBody;
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
      body: ListDentryVersionsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * next_token
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListPermissionsResponseBody;
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

export class ListRecycleItemsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleItemsRequest extends $tea.Model {
  /**
   * @example
   * 30
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleItemsResponseBody extends $tea.Model {
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  recycleItems?: ListRecycleItemsResponseBodyRecycleItems[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      recycleItems: 'recycleItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      recycleItems: { 'type': 'array', 'itemType': ListRecycleItemsResponseBodyRecycleItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleItemsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListRecycleItemsResponseBody;
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
      body: ListRecycleItemsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentriesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dentryIds?: string[];
  option?: MoveDentriesRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_folder_id
   */
  targetFolderId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_space_id
   */
  targetSpaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      option: 'option',
      targetFolderId: 'targetFolderId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      option: MoveDentriesRequestOption,
      targetFolderId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentriesResponseBody extends $tea.Model {
  resultItems?: MoveDentriesResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': MoveDentriesResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentriesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MoveDentriesResponseBody;
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
      body: MoveDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryRequest extends $tea.Model {
  option?: MoveDentryRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_folder_id
   */
  targetFolderId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * target_space_id
   */
  targetSpaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      targetFolderId: 'targetFolderId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: MoveDentryRequestOption,
      targetFolderId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  dentry?: MoveDentryResponseBodyDentry;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentry: 'dentry',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentry: MoveDentryResponseBodyDentry,
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MoveDentryResponseBody;
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
      body: MoveDentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefreshWebOfficeTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefreshWebOfficeTokenRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  webOfficeAccessToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  webOfficeRefreshToken?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      webOfficeAccessToken: 'webOfficeAccessToken',
      webOfficeRefreshToken: 'webOfficeRefreshToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      webOfficeAccessToken: 'string',
      webOfficeRefreshToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefreshWebOfficeTokenResponseBody extends $tea.Model {
  webOfficeAccessToken?: string;
  webOfficeRefreshToken?: string;
  static names(): { [key: string]: string } {
    return {
      webOfficeAccessToken: 'webOfficeAccessToken',
      webOfficeRefreshToken: 'webOfficeRefreshToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      webOfficeAccessToken: 'string',
      webOfficeRefreshToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RefreshWebOfficeTokenResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RefreshWebOfficeTokenResponseBody;
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
      body: RefreshWebOfficeTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterOpenInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterOpenInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openInfos?: RegisterOpenInfoRequestOpenInfos[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DINGTALK
   */
  provider?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      openInfos: 'openInfos',
      provider: 'provider',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openInfos: { 'type': 'array', 'itemType': RegisterOpenInfoRequestOpenInfos },
      provider: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterOpenInfoResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class RegisterOpenInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RegisterOpenInfoResponseBody;
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
      body: RegisterOpenInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameDentryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dentry_name
   */
  newName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      newName: 'newName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameDentryResponseBody extends $tea.Model {
  dentry?: RenameDentryResponseBodyDentry;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: RenameDentryResponseBodyDentry,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameDentryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RenameDentryResponseBody;
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
      body: RenameDentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemRequest extends $tea.Model {
  option?: RestoreRecycleItemRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: RestoreRecycleItemRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentryId: 'dentryId',
      spaceId: 'spaceId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentryId: 'string',
      spaceId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RestoreRecycleItemResponseBody;
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
      body: RestoreRecycleItemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemsRequest extends $tea.Model {
  option?: RestoreRecycleItemsRequestOption;
  /**
   * @remarks
   * This parameter is required.
   */
  recycleItemIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      recycleItemIds: 'recycleItemIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: RestoreRecycleItemsRequestOption,
      recycleItemIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemsResponseBody extends $tea.Model {
  resultItems?: RestoreRecycleItemsResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': RestoreRecycleItemsResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RestoreRecycleItemsResponseBody;
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
      body: RestoreRecycleItemsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertDentryVersionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevertDentryVersionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class RevertDentryVersionResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class RevertDentryVersionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RevertDentryVersionResponseBody;
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
      body: RevertDentryVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeEventRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SPACE
   */
  scope?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * scope_id
   */
  scopeId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      scope: 'scope',
      scopeId: 'scopeId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scope: 'string',
      scopeId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeEventResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class SubscribeEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SubscribeEventResponseBody;
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
      body: SubscribeEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeEventRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SPACE
   */
  scope?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * scope_id
   */
  scopeId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      scope: 'scope',
      scopeId: 'scopeId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scope: 'string',
      scopeId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeEventResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class UnsubscribeEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UnsubscribeEventResponseBody;
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
      body: UnsubscribeEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDentryAppPropertiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDentryAppPropertiesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appProperties?: UpdateDentryAppPropertiesRequestAppProperties[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'array', 'itemType': UpdateDentryAppPropertiesRequestAppProperties },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDentryAppPropertiesResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class UpdateDentryAppPropertiesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateDentryAppPropertiesResponseBody;
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
      body: UpdateDentryAppPropertiesResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  members?: UpdatePermissionRequestMembers[];
  option?: UpdatePermissionRequestOption;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * MANAGER
   */
  roleId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdatePermissionResponseBody;
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

export class AddFolderRequestOptionAppProperties extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * property_name
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * property_value
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PRIVATE
   */
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

export class AddFolderRequestOption extends $tea.Model {
  appProperties?: AddFolderRequestOptionAppProperties[];
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      conflictStrategy: 'conflictStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'array', 'itemType': AddFolderRequestOptionAppProperties },
      conflictStrategy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFolderResponseBodyDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class AddFolderResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: AddFolderResponseBodyDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
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
      properties: AddFolderResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionRequestMembers extends $tea.Model {
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * member_id
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * USER
   */
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
  /**
   * @example
   * 3600
   */
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

export class AddSpaceRequestOptionCapabilities extends $tea.Model {
  /**
   * @example
   * true
   */
  canRecordRecentFile?: boolean;
  /**
   * @example
   * true
   */
  canRename?: boolean;
  /**
   * @example
   * true
   */
  canSearch?: boolean;
  static names(): { [key: string]: string } {
    return {
      canRecordRecentFile: 'canRecordRecentFile',
      canRename: 'canRename',
      canSearch: 'canSearch',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canRecordRecentFile: 'boolean',
      canRename: 'boolean',
      canSearch: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceRequestOption extends $tea.Model {
  capabilities?: AddSpaceRequestOptionCapabilities;
  /**
   * @example
   * space_name
   */
  name?: string;
  /**
   * @example
   * USER
   */
  ownerType?: string;
  quota?: number;
  /**
   * @example
   * scene
   */
  scene?: string;
  /**
   * @example
   * scene_id
   */
  sceneId?: string;
  static names(): { [key: string]: string } {
    return {
      capabilities: 'capabilities',
      name: 'name',
      ownerType: 'ownerType',
      quota: 'quota',
      scene: 'scene',
      sceneId: 'sceneId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      capabilities: AddSpaceRequestOptionCapabilities,
      name: 'string',
      ownerType: 'string',
      quota: 'number',
      scene: 'string',
      sceneId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponseBodySpaceCapabilities extends $tea.Model {
  /**
   * @example
   * true
   */
  canRecordRecentFile?: boolean;
  /**
   * @example
   * true
   */
  canRename?: boolean;
  /**
   * @example
   * true
   */
  canSearch?: boolean;
  static names(): { [key: string]: string } {
    return {
      canRecordRecentFile: 'canRecordRecentFile',
      canRename: 'canRename',
      canSearch: 'canSearch',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canRecordRecentFile: 'boolean',
      canRename: 'boolean',
      canSearch: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponseBodySpacePartitionsQuota extends $tea.Model {
  /**
   * @example
   * 10000
   */
  max?: number;
  /**
   * @example
   * 1000
   */
  reserved?: number;
  /**
   * @example
   * SHARE
   */
  type?: string;
  /**
   * @example
   * 1024
   */
  used?: number;
  static names(): { [key: string]: string } {
    return {
      max: 'max',
      reserved: 'reserved',
      type: 'type',
      used: 'used',
    };
  }

  static types(): { [key: string]: any } {
    return {
      max: 'number',
      reserved: 'number',
      type: 'string',
      used: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponseBodySpacePartitions extends $tea.Model {
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  quota?: AddSpaceResponseBodySpacePartitionsQuota;
  static names(): { [key: string]: string } {
    return {
      partitionType: 'partitionType',
      quota: 'quota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partitionType: 'string',
      quota: AddSpaceResponseBodySpacePartitionsQuota,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponseBodySpace extends $tea.Model {
  /**
   * @example
   * app_id
   */
  appId?: string;
  capabilities?: AddSpaceResponseBodySpaceCapabilities;
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * space_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * space_name
   */
  name?: string;
  /**
   * @example
   * owner_id
   */
  ownerId?: string;
  /**
   * @example
   * USER
   */
  ownerType?: string;
  partitions?: AddSpaceResponseBodySpacePartitions[];
  /**
   * @example
   * 1048576
   */
  quota?: number;
  /**
   * @example
   * scene
   */
  scene?: string;
  /**
   * @example
   * scene_id
   */
  sceneId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * 1024
   */
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      capabilities: 'capabilities',
      corpId: 'corpId',
      createTime: 'createTime',
      creatorId: 'creatorId',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      ownerId: 'ownerId',
      ownerType: 'ownerType',
      partitions: 'partitions',
      quota: 'quota',
      scene: 'scene',
      sceneId: 'sceneId',
      status: 'status',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      capabilities: AddSpaceResponseBodySpaceCapabilities,
      corpId: 'string',
      createTime: 'string',
      creatorId: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      ownerId: 'string',
      ownerType: 'string',
      partitions: { 'type': 'array', 'itemType': AddSpaceResponseBodySpacePartitions },
      quota: 'number',
      scene: 'string',
      sceneId: 'string',
      status: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileRequestOptionAppProperties extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * property_name
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * property_value
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PRIVATE
   */
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
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  /**
   * @example
   * 512
   */
  size?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      conflictStrategy: 'conflictStrategy',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'array', 'itemType': CommitFileRequestOptionAppProperties },
      conflictStrategy: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitFileResponseBodyDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class CommitFileResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: CommitFileResponseBodyDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
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
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentriesRequestOption extends $tea.Model {
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  static names(): { [key: string]: string } {
    return {
      conflictStrategy: 'conflictStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conflictStrategy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentriesResponseBodyResultItems extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * permissionDenied
   */
  errorCode?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  /**
   * @example
   * target_dentry_id
   */
  targetDentryId?: string;
  /**
   * @example
   * target_space_id
   */
  targetSpaceId?: string;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
      targetDentryId: 'targetDentryId',
      targetSpaceId: 'targetSpaceId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
      targetDentryId: 'string',
      targetSpaceId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryRequestOption extends $tea.Model {
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  static names(): { [key: string]: string } {
    return {
      conflictStrategy: 'conflictStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conflictStrategy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryResponseBodyDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class CopyDentryResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: CopyDentryResponseBodyDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
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
      properties: CopyDentryResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentriesRequestOption extends $tea.Model {
  /**
   * @example
   * true
   */
  toRecycleBin?: boolean;
  static names(): { [key: string]: string } {
    return {
      toRecycleBin: 'toRecycleBin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      toRecycleBin: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDentriesResponseBodyResultItems extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * permissionDenied
   */
  errorCode?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionRequestMembers extends $tea.Model {
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * member_id
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * USER
   */
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

export class GetCurrentAppResponseBodyAppPartitionsQuota extends $tea.Model {
  /**
   * @example
   * 10000
   */
  max?: number;
  /**
   * @example
   * 1000
   */
  reserved?: number;
  /**
   * @example
   * SHARE
   */
  type?: string;
  /**
   * @example
   * 1024
   */
  used?: number;
  static names(): { [key: string]: string } {
    return {
      max: 'max',
      reserved: 'reserved',
      type: 'type',
      used: 'used',
    };
  }

  static types(): { [key: string]: any } {
    return {
      max: 'number',
      reserved: 'number',
      type: 'string',
      used: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCurrentAppResponseBodyAppPartitions extends $tea.Model {
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  quota?: GetCurrentAppResponseBodyAppPartitionsQuota;
  static names(): { [key: string]: string } {
    return {
      partitionType: 'partitionType',
      quota: 'quota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partitionType: 'string',
      quota: GetCurrentAppResponseBodyAppPartitionsQuota,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCurrentAppResponseBodyApp extends $tea.Model {
  /**
   * @example
   * app_id
   */
  appId?: string;
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * app_name
   */
  name?: string;
  partitions?: GetCurrentAppResponseBodyAppPartitions[];
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      corpId: 'corpId',
      createTime: 'createTime',
      modifiedTime: 'modifiedTime',
      name: 'name',
      partitions: 'partitions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      corpId: 'string',
      createTime: 'string',
      modifiedTime: 'string',
      name: 'string',
      partitions: { 'type': 'array', 'itemType': GetCurrentAppResponseBodyAppPartitions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesRequestOption extends $tea.Model {
  appIdsForAppProperties?: string[];
  /**
   * @example
   * true
   */
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      appIdsForAppProperties: 'appIdsForAppProperties',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appIdsForAppProperties: { 'type': 'array', 'itemType': 'string' },
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBodyResultItemsDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class GetDentriesResponseBodyResultItemsDentryThumbnail extends $tea.Model {
  /**
   * @example
   * 64
   */
  height?: number;
  /**
   * @example
   * url
   */
  url?: string;
  /**
   * @example
   * 64
   */
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

export class GetDentriesResponseBodyResultItemsDentry extends $tea.Model {
  appProperties?: { [key: string]: ResultItemsDentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: GetDentriesResponseBodyResultItemsDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  thumbnail?: GetDentriesResponseBodyResultItemsDentryThumbnail;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': ResultItemsDentryAppPropertiesValue } },
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
      properties: GetDentriesResponseBodyResultItemsDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: GetDentriesResponseBodyResultItemsDentryThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBodyResultItems extends $tea.Model {
  dentry?: GetDentriesResponseBodyResultItemsDentry;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * permissionDenied
   */
  errorCode?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: GetDentriesResponseBodyResultItemsDentry,
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryRequestOption extends $tea.Model {
  appIdsForAppProperties?: string[];
  /**
   * @example
   * true
   */
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      appIdsForAppProperties: 'appIdsForAppProperties',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appIdsForAppProperties: { 'type': 'array', 'itemType': 'string' },
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBodyDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class GetDentryResponseBodyDentryThumbnail extends $tea.Model {
  /**
   * @example
   * 64
   */
  height?: number;
  /**
   * @example
   * url
   */
  url?: string;
  /**
   * @example
   * 64
   */
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

export class GetDentryResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: GetDentryResponseBodyDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  thumbnail?: GetDentryResponseBodyDentryThumbnail;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      properties: GetDentryResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: GetDentryResponseBodyDentryThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryOpenInfoRequestOption extends $tea.Model {
  /**
   * @example
   * true
   */
  checkLogin?: boolean;
  /**
   * @example
   * PREVIEW
   */
  type?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  /**
   * @example
   * true
   */
  waterMark?: boolean;
  static names(): { [key: string]: string } {
    return {
      checkLogin: 'checkLogin',
      type: 'type',
      version: 'version',
      waterMark: 'waterMark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkLogin: 'boolean',
      type: 'string',
      version: 'number',
      waterMark: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponseBodyResultItemsThumbnail extends $tea.Model {
  /**
   * @example
   * 64
   */
  height?: number;
  /**
   * @example
   * url
   */
  url?: string;
  /**
   * @example
   * 64
   */
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

export class GetDentryThumbnailsResponseBodyResultItems extends $tea.Model {
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * permissionDenied
   */
  errorCode?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  thumbnail?: GetDentryThumbnailsResponseBodyResultItemsThumbnail;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
      thumbnail: 'thumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
      thumbnail: GetDentryThumbnailsResponseBodyResultItemsThumbnail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoRequestOption extends $tea.Model {
  /**
   * @example
   * true
   */
  preferIntranet?: boolean;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      preferIntranet: 'preferIntranet',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      preferIntranet: 'boolean',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponseBodyHeaderSignatureInfo extends $tea.Model {
  /**
   * @example
   * 900
   */
  expirationSeconds?: number;
  headers?: { [key: string]: string };
  internalResourceUrls?: string[];
  /**
   * @example
   * ZHANGJIAKOU
   */
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

export class GetFileUploadInfoRequestOptionPreCheckParam extends $tea.Model {
  /**
   * @example
   * md5
   */
  md5?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * 512
   */
  size?: number;
  static names(): { [key: string]: string } {
    return {
      md5: 'md5',
      name: 'name',
      parentId: 'parentId',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      md5: 'string',
      name: 'string',
      parentId: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoRequestOption extends $tea.Model {
  preCheckParam?: GetFileUploadInfoRequestOptionPreCheckParam;
  /**
   * @example
   * true
   */
  preferIntranet?: boolean;
  /**
   * @example
   * ZHANGJIAKOU
   */
  preferRegion?: string;
  /**
   * @example
   * DINGTALK
   */
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
  /**
   * @example
   * 900
   */
  expirationSeconds?: number;
  headers?: { [key: string]: string };
  internalResourceUrls?: string[];
  /**
   * @example
   * ZHANGJIAKOU
   */
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

export class GetMultipartFileUploadInfosRequestOption extends $tea.Model {
  /**
   * @example
   * true
   */
  preferIntranet?: boolean;
  static names(): { [key: string]: string } {
    return {
      preferIntranet: 'preferIntranet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      preferIntranet: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo extends $tea.Model {
  /**
   * @example
   * 900
   */
  expirationSeconds?: number;
  headers?: { [key: string]: string };
  internalResourceUrls?: string[];
  /**
   * @example
   * ZHANGJIAKOU
   */
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

export class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos extends $tea.Model {
  headerSignatureInfo?: GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo;
  partNumber?: number;
  static names(): { [key: string]: string } {
    return {
      headerSignatureInfo: 'headerSignatureInfo',
      partNumber: 'partNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headerSignatureInfo: GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo,
      partNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgResponseBodyOrgPartitionsQuota extends $tea.Model {
  /**
   * @example
   * 10000
   */
  max?: number;
  /**
   * @example
   * 1000
   */
  reserved?: number;
  /**
   * @example
   * SHARE
   */
  type?: string;
  /**
   * @example
   * 1024
   */
  used?: number;
  static names(): { [key: string]: string } {
    return {
      max: 'max',
      reserved: 'reserved',
      type: 'type',
      used: 'used',
    };
  }

  static types(): { [key: string]: any } {
    return {
      max: 'number',
      reserved: 'number',
      type: 'string',
      used: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgResponseBodyOrgPartitions extends $tea.Model {
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  quota?: GetOrgResponseBodyOrgPartitionsQuota;
  static names(): { [key: string]: string } {
    return {
      partitionType: 'partitionType',
      quota: 'quota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partitionType: 'string',
      quota: GetOrgResponseBodyOrgPartitionsQuota,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgResponseBodyOrg extends $tea.Model {
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  partitions?: GetOrgResponseBodyOrgPartitions[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      partitions: 'partitions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      partitions: { 'type': 'array', 'itemType': GetOrgResponseBodyOrgPartitions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleBinResponseBodyRecycleBin extends $tea.Model {
  /**
   * @example
   * recyclebin_id
   */
  id?: string;
  /**
   * @example
   * SPACE
   */
  scope?: string;
  /**
   * @example
   * scope_id
   */
  scopeId?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      scope: 'scope',
      scopeId: 'scopeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      scope: 'string',
      scopeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecycleItemResponseBodyItem extends $tea.Model {
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * recycle_item_id
   */
  id?: string;
  /**
   * @example
   * operator_id
   */
  operatorId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  operatorTime?: string;
  /**
   * @example
   * dentry_name
   */
  originalName?: string;
  /**
   * @example
   * dentry_path
   */
  originalPath?: string;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * file
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      id: 'id',
      operatorId: 'operatorId',
      operatorTime: 'operatorTime',
      originalName: 'originalName',
      originalPath: 'originalPath',
      size: 'size',
      spaceId: 'spaceId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      id: 'string',
      operatorId: 'string',
      operatorTime: 'string',
      originalName: 'string',
      originalPath: 'string',
      size: 'number',
      spaceId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpaceCapabilities extends $tea.Model {
  /**
   * @example
   * true
   */
  canRecordRecentFile?: boolean;
  /**
   * @example
   * true
   */
  canRename?: boolean;
  /**
   * @example
   * true
   */
  canSearch?: boolean;
  static names(): { [key: string]: string } {
    return {
      canRecordRecentFile: 'canRecordRecentFile',
      canRename: 'canRename',
      canSearch: 'canSearch',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canRecordRecentFile: 'boolean',
      canRename: 'boolean',
      canSearch: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpacePartitionsQuota extends $tea.Model {
  /**
   * @example
   * 10000
   */
  max?: number;
  /**
   * @example
   * 1000
   */
  reserved?: number;
  /**
   * @example
   * SHARE
   */
  type?: string;
  /**
   * @example
   * 1024
   */
  used?: number;
  static names(): { [key: string]: string } {
    return {
      max: 'max',
      reserved: 'reserved',
      type: 'type',
      used: 'used',
    };
  }

  static types(): { [key: string]: any } {
    return {
      max: 'number',
      reserved: 'number',
      type: 'string',
      used: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpacePartitions extends $tea.Model {
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  quota?: GetSpaceResponseBodySpacePartitionsQuota;
  static names(): { [key: string]: string } {
    return {
      partitionType: 'partitionType',
      quota: 'quota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partitionType: 'string',
      quota: GetSpaceResponseBodySpacePartitionsQuota,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpace extends $tea.Model {
  /**
   * @example
   * app_id
   */
  appId?: string;
  capabilities?: GetSpaceResponseBodySpaceCapabilities;
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * space_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * space_name
   */
  name?: string;
  /**
   * @example
   * owner_id
   */
  ownerId?: string;
  /**
   * @example
   * USER
   */
  ownerType?: string;
  partitions?: GetSpaceResponseBodySpacePartitions[];
  /**
   * @example
   * 1048576
   */
  quota?: number;
  /**
   * @example
   * scene
   */
  scene?: string;
  /**
   * @example
   * scene_id
   */
  sceneId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * 1024
   */
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      capabilities: 'capabilities',
      corpId: 'corpId',
      createTime: 'createTime',
      creatorId: 'creatorId',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      ownerId: 'ownerId',
      ownerType: 'ownerType',
      partitions: 'partitions',
      quota: 'quota',
      scene: 'scene',
      sceneId: 'sceneId',
      status: 'status',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      capabilities: GetSpaceResponseBodySpaceCapabilities,
      corpId: 'string',
      createTime: 'string',
      creatorId: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      ownerId: 'string',
      ownerType: 'string',
      partitions: { 'type': 'array', 'itemType': GetSpaceResponseBodySpacePartitions },
      quota: 'number',
      scene: 'string',
      sceneId: 'string',
      status: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTaskResponseBodyTask extends $tea.Model {
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  beginTime?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  endTime?: string;
  /**
   * @example
   * 1
   */
  failCount?: number;
  /**
   * @example
   * permissionDenied
   */
  failMessage?: string;
  /**
   * @example
   * task_id
   */
  id?: string;
  /**
   * @example
   * IN_PROGRESS
   */
  status?: string;
  /**
   * @example
   * 3
   */
  successCount?: number;
  /**
   * @example
   * 6
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
      failCount: 'failCount',
      failMessage: 'failMessage',
      id: 'id',
      status: 'status',
      successCount: 'successCount',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'string',
      endTime: 'string',
      failCount: 'number',
      failMessage: 'string',
      id: 'string',
      status: 'string',
      successCount: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitMultipartFileUploadRequestOptionPreCheckParam extends $tea.Model {
  /**
   * @example
   * md5
   */
  md5?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * 512
   */
  size?: number;
  static names(): { [key: string]: string } {
    return {
      md5: 'md5',
      name: 'name',
      parentId: 'parentId',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      md5: 'string',
      name: 'string',
      parentId: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitMultipartFileUploadRequestOption extends $tea.Model {
  preCheckParam?: InitMultipartFileUploadRequestOptionPreCheckParam;
  /**
   * @example
   * ZHANGJIAKOU
   */
  preferRegion?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  static names(): { [key: string]: string } {
    return {
      preCheckParam: 'preCheckParam',
      preferRegion: 'preferRegion',
      storageDriver: 'storageDriver',
    };
  }

  static types(): { [key: string]: any } {
    return {
      preCheckParam: InitMultipartFileUploadRequestOptionPreCheckParam,
      preferRegion: 'string',
      storageDriver: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesRequestOption extends $tea.Model {
  /**
   * @example
   * 30
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * DESC
   */
  order?: string;
  /**
   * @example
   * true
   */
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      order: 'string',
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponseBodyDentriesProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class ListAllDentriesResponseBodyDentriesThumbnail extends $tea.Model {
  /**
   * @example
   * 64
   */
  height?: number;
  /**
   * @example
   * url
   */
  url?: string;
  /**
   * @example
   * 64
   */
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

export class ListAllDentriesResponseBodyDentries extends $tea.Model {
  appProperties?: { [key: string]: DentriesAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: ListAllDentriesResponseBodyDentriesProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  thumbnail?: ListAllDentriesResponseBodyDentriesThumbnail;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentriesAppPropertiesValue } },
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
      properties: ListAllDentriesResponseBodyDentriesProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: ListAllDentriesResponseBodyDentriesThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBodyDentriesProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class ListDentriesResponseBodyDentriesThumbnail extends $tea.Model {
  /**
   * @example
   * 64
   */
  height?: number;
  /**
   * @example
   * url
   */
  url?: string;
  /**
   * @example
   * 64
   */
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

export class ListDentriesResponseBodyDentries extends $tea.Model {
  appProperties?: { [key: string]: DentriesAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: ListDentriesResponseBodyDentriesProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  thumbnail?: ListDentriesResponseBodyDentriesThumbnail;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentriesAppPropertiesValue } },
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
      properties: ListDentriesResponseBodyDentriesProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: ListDentriesResponseBodyDentriesThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentryVersionsResponseBodyDentriesProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class ListDentryVersionsResponseBodyDentries extends $tea.Model {
  appProperties?: { [key: string]: DentriesAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: ListDentryVersionsResponseBodyDentriesProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentriesAppPropertiesValue } },
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
      properties: ListDentryVersionsResponseBodyDentriesProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsRequestOption extends $tea.Model {
  filterRoleIds?: string[];
  /**
   * @example
   * 30
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
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
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @example
   * member_id
   */
  id?: string;
  /**
   * @example
   * USER
   */
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
  /**
   * @example
   * MANAGER
   */
  id?: string;
  /**
   * @example
   * MANAGER
   */
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
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * 3600
   */
  duration?: number;
  member?: ListPermissionsResponseBodyPermissionsMember;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * operator_id
   */
  operatorId?: string;
  role?: ListPermissionsResponseBodyPermissionsRole;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      dentryId: 'dentryId',
      duration: 'duration',
      member: 'member',
      modifiedTime: 'modifiedTime',
      operatorId: 'operatorId',
      role: 'role',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      dentryId: 'string',
      duration: 'number',
      member: ListPermissionsResponseBodyPermissionsMember,
      modifiedTime: 'string',
      operatorId: 'string',
      role: ListPermissionsResponseBodyPermissionsRole,
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleItemsResponseBodyRecycleItems extends $tea.Model {
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * recycle_item_id
   */
  id?: string;
  /**
   * @example
   * operator_id
   */
  operatorId?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  operatorTime?: string;
  /**
   * @example
   * dentry_name
   */
  originalName?: string;
  /**
   * @example
   * dentry_path
   */
  originalPath?: string;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * file
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      id: 'id',
      operatorId: 'operatorId',
      operatorTime: 'operatorTime',
      originalName: 'originalName',
      originalPath: 'originalPath',
      size: 'size',
      spaceId: 'spaceId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      id: 'string',
      operatorId: 'string',
      operatorTime: 'string',
      originalName: 'string',
      originalPath: 'string',
      size: 'number',
      spaceId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentriesRequestOption extends $tea.Model {
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  /**
   * @example
   * true
   */
  preservePermissions?: boolean;
  static names(): { [key: string]: string } {
    return {
      conflictStrategy: 'conflictStrategy',
      preservePermissions: 'preservePermissions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conflictStrategy: 'string',
      preservePermissions: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentriesResponseBodyResultItems extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * permissionDenied
   */
  errorCode?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  /**
   * @example
   * target_dentry_id
   */
  targetDentryId?: string;
  /**
   * @example
   * target_space_id
   */
  targetSpaceId?: string;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
      targetDentryId: 'targetDentryId',
      targetSpaceId: 'targetSpaceId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
      targetDentryId: 'string',
      targetSpaceId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryRequestOption extends $tea.Model {
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  /**
   * @example
   * true
   */
  presevePermissions?: boolean;
  static names(): { [key: string]: string } {
    return {
      conflictStrategy: 'conflictStrategy',
      presevePermissions: 'presevePermissions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conflictStrategy: 'string',
      presevePermissions: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryResponseBodyDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class MoveDentryResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: MoveDentryResponseBodyDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
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
      properties: MoveDentryResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterOpenInfoRequestOpenInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PREVIEW
   */
  openType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * url
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      openType: 'openType',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openType: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameDentryResponseBodyDentryProperties extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class RenameDentryResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * creator_id
   */
  creatorId?: string;
  /**
   * @example
   * txt
   */
  extension?: string;
  /**
   * @example
   * dentry_id
   */
  id?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  /**
   * @example
   * modifier_id
   */
  modifierId?: string;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * parent_id
   */
  parentId?: string;
  /**
   * @example
   * PUBLIC_OSS_PARTITION
   */
  partitionType?: string;
  /**
   * @example
   * dentry_path
   */
  path?: string;
  properties?: RenameDentryResponseBodyDentryProperties;
  /**
   * @example
   * 512
   */
  size?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * NORMAL
   */
  status?: string;
  /**
   * @example
   * DINGTALK
   */
  storageDriver?: string;
  /**
   * @example
   * file
   */
  type?: string;
  /**
   * @example
   * uuid
   */
  uuid?: string;
  /**
   * @example
   * 1
   */
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
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
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
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
      properties: RenameDentryResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemRequestOption extends $tea.Model {
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  static names(): { [key: string]: string } {
    return {
      conflictStrategy: 'conflictStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conflictStrategy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemsRequestOption extends $tea.Model {
  /**
   * @example
   * AUTO_RENAME
   */
  conflictStrategy?: string;
  static names(): { [key: string]: string } {
    return {
      conflictStrategy: 'conflictStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conflictStrategy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RestoreRecycleItemsResponseBodyResultItems extends $tea.Model {
  /**
   * @example
   * true
   */
  async?: boolean;
  /**
   * @example
   * dentry_id
   */
  dentryId?: string;
  /**
   * @example
   * permissionDenied
   */
  errorCode?: string;
  /**
   * @example
   * recyclebin_id
   */
  recycleBinId?: string;
  /**
   * @example
   * recycle_item_id
   */
  recycleItemId?: string;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * true
   */
  success?: boolean;
  /**
   * @example
   * task_id
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      async: 'async',
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      recycleBinId: 'recycleBinId',
      recycleItemId: 'recycleItemId',
      spaceId: 'spaceId',
      success: 'success',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      async: 'boolean',
      dentryId: 'string',
      errorCode: 'string',
      recycleBinId: 'string',
      recycleItemId: 'string',
      spaceId: 'string',
      success: 'boolean',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDentryAppPropertiesRequestAppProperties extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * property_name
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * property_value
   */
  value?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PRIVATE
   */
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

export class UpdatePermissionRequestMembers extends $tea.Model {
  /**
   * @example
   * corp_id
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * member_id
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * USER
   */
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
  /**
   * @example
   * 3600
   */
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
   * 添加文件夹
   * 
   * @param request - AddFolderRequest
   * @param headers - AddFolderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddFolderResponse
   */
  async addFolderWithOptions(spaceId: string, parentId: string, request: AddFolderRequest, headers: AddFolderHeaders, runtime: $Util.RuntimeOptions): Promise<AddFolderResponse> {
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
      action: "AddFolder",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${parentId}/folders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddFolderResponse>(await this.execute(params, req, runtime), new AddFolderResponse({}));
  }

  /**
   * 添加文件夹
   * 
   * @param request - AddFolderRequest
   * @returns AddFolderResponse
   */
  async addFolder(spaceId: string, parentId: string, request: AddFolderRequest): Promise<AddFolderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFolderHeaders({ });
    return await this.addFolderWithOptions(spaceId, parentId, request, headers, runtime);
  }

  /**
   * 添加权限
   * 
   * @param request - AddPermissionRequest
   * @param headers - AddPermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddPermissionResponse
   */
  async addPermissionWithOptions(spaceId: string, dentryId: string, request: AddPermissionRequest, headers: AddPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<AddPermissionResponse> {
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
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/permissions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddPermissionResponse>(await this.execute(params, req, runtime), new AddPermissionResponse({}));
  }

  /**
   * 添加权限
   * 
   * @param request - AddPermissionRequest
   * @returns AddPermissionResponse
   */
  async addPermission(spaceId: string, dentryId: string, request: AddPermissionRequest): Promise<AddPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPermissionHeaders({ });
    return await this.addPermissionWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 添加空间
   * 
   * @param request - AddSpaceRequest
   * @param headers - AddSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddSpaceResponse
   */
  async addSpaceWithOptions(request: AddSpaceRequest, headers: AddSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AddSpaceResponse> {
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
      action: "AddSpace",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddSpaceResponse>(await this.execute(params, req, runtime), new AddSpaceResponse({}));
  }

  /**
   * 添加空间
   * 
   * @param request - AddSpaceRequest
   * @returns AddSpaceResponse
   */
  async addSpace(request: AddSpaceRequest): Promise<AddSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddSpaceHeaders({ });
    return await this.addSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 清空回收站
   * 
   * @param request - ClearRecycleBinRequest
   * @param headers - ClearRecycleBinHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ClearRecycleBinResponse
   */
  async clearRecycleBinWithOptions(recycleBinId: string, request: ClearRecycleBinRequest, headers: ClearRecycleBinHeaders, runtime: $Util.RuntimeOptions): Promise<ClearRecycleBinResponse> {
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
      action: "ClearRecycleBin",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/clear`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ClearRecycleBinResponse>(await this.execute(params, req, runtime), new ClearRecycleBinResponse({}));
  }

  /**
   * 清空回收站
   * 
   * @param request - ClearRecycleBinRequest
   * @returns ClearRecycleBinResponse
   */
  async clearRecycleBin(recycleBinId: string, request: ClearRecycleBinRequest): Promise<ClearRecycleBinResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearRecycleBinHeaders({ });
    return await this.clearRecycleBinWithOptions(recycleBinId, request, headers, runtime);
  }

  /**
   * 提交文件
   * 
   * @param request - CommitFileRequest
   * @param headers - CommitFileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CommitFileResponse
   */
  async commitFileWithOptions(spaceId: string, request: CommitFileRequest, headers: CommitFileHeaders, runtime: $Util.RuntimeOptions): Promise<CommitFileResponse> {
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

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
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
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/files/commit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CommitFileResponse>(await this.execute(params, req, runtime), new CommitFileResponse({}));
  }

  /**
   * 提交文件
   * 
   * @param request - CommitFileRequest
   * @returns CommitFileResponse
   */
  async commitFile(spaceId: string, request: CommitFileRequest): Promise<CommitFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CommitFileHeaders({ });
    return await this.commitFileWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 批量拷贝文件或文件夹
   * 
   * @param request - CopyDentriesRequest
   * @param headers - CopyDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CopyDentriesResponse
   */
  async copyDentriesWithOptions(spaceId: string, request: CopyDentriesRequest, headers: CopyDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<CopyDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.targetFolderId)) {
      body["targetFolderId"] = request.targetFolderId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
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
      action: "CopyDentries",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/batchCopy`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CopyDentriesResponse>(await this.execute(params, req, runtime), new CopyDentriesResponse({}));
  }

  /**
   * 批量拷贝文件或文件夹
   * 
   * @param request - CopyDentriesRequest
   * @returns CopyDentriesResponse
   */
  async copyDentries(spaceId: string, request: CopyDentriesRequest): Promise<CopyDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyDentriesHeaders({ });
    return await this.copyDentriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 拷贝文件或文件夹
   * 
   * @param request - CopyDentryRequest
   * @param headers - CopyDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CopyDentryResponse
   */
  async copyDentryWithOptions(spaceId: string, dentryId: string, request: CopyDentryRequest, headers: CopyDentryHeaders, runtime: $Util.RuntimeOptions): Promise<CopyDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.targetFolderId)) {
      body["targetFolderId"] = request.targetFolderId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
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
      action: "CopyDentry",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/copy`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CopyDentryResponse>(await this.execute(params, req, runtime), new CopyDentryResponse({}));
  }

  /**
   * 拷贝文件或文件夹
   * 
   * @param request - CopyDentryRequest
   * @returns CopyDentryResponse
   */
  async copyDentry(spaceId: string, dentryId: string, request: CopyDentryRequest): Promise<CopyDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyDentryHeaders({ });
    return await this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 批量删除文件或文件夹
   * 
   * @param request - DeleteDentriesRequest
   * @param headers - DeleteDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDentriesResponse
   */
  async deleteDentriesWithOptions(spaceId: string, request: DeleteDentriesRequest, headers: DeleteDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
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
      action: "DeleteDentries",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDentriesResponse>(await this.execute(params, req, runtime), new DeleteDentriesResponse({}));
  }

  /**
   * 批量删除文件或文件夹
   * 
   * @param request - DeleteDentriesRequest
   * @returns DeleteDentriesResponse
   */
  async deleteDentries(spaceId: string, request: DeleteDentriesRequest): Promise<DeleteDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDentriesHeaders({ });
    return await this.deleteDentriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 删除文件或文件夹
   * 
   * @param request - DeleteDentryRequest
   * @param headers - DeleteDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDentryResponse
   */
  async deleteDentryWithOptions(spaceId: string, dentryId: string, request: DeleteDentryRequest, headers: DeleteDentryHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.toRecycleBin)) {
      query["toRecycleBin"] = request.toRecycleBin;
    }

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
      action: "DeleteDentry",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDentryResponse>(await this.execute(params, req, runtime), new DeleteDentryResponse({}));
  }

  /**
   * 删除文件或文件夹
   * 
   * @param request - DeleteDentryRequest
   * @returns DeleteDentryResponse
   */
  async deleteDentry(spaceId: string, dentryId: string, request: DeleteDentryRequest): Promise<DeleteDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDentryHeaders({ });
    return await this.deleteDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 删除文件上的App属性值
   * 
   * @param request - DeleteDentryAppPropertiesRequest
   * @param headers - DeleteDentryAppPropertiesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDentryAppPropertiesResponse
   */
  async deleteDentryAppPropertiesWithOptions(spaceId: string, dentryId: string, request: DeleteDentryAppPropertiesRequest, headers: DeleteDentryAppPropertiesHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDentryAppPropertiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.propertyNames)) {
      body["propertyNames"] = request.propertyNames;
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
      action: "DeleteDentryAppProperties",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/appProperties/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDentryAppPropertiesResponse>(await this.execute(params, req, runtime), new DeleteDentryAppPropertiesResponse({}));
  }

  /**
   * 删除文件上的App属性值
   * 
   * @param request - DeleteDentryAppPropertiesRequest
   * @returns DeleteDentryAppPropertiesResponse
   */
  async deleteDentryAppProperties(spaceId: string, dentryId: string, request: DeleteDentryAppPropertiesRequest): Promise<DeleteDentryAppPropertiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDentryAppPropertiesHeaders({ });
    return await this.deleteDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 删除权限
   * 
   * @param request - DeletePermissionRequest
   * @param headers - DeletePermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeletePermissionResponse
   */
  async deletePermissionWithOptions(spaceId: string, dentryId: string, request: DeletePermissionRequest, headers: DeletePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePermissionResponse> {
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
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/permissions/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeletePermissionResponse>(await this.execute(params, req, runtime), new DeletePermissionResponse({}));
  }

  /**
   * 删除权限
   * 
   * @param request - DeletePermissionRequest
   * @returns DeletePermissionResponse
   */
  async deletePermission(spaceId: string, dentryId: string, request: DeletePermissionRequest): Promise<DeletePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePermissionHeaders({ });
    return await this.deletePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
   * 
   * @param request - DeleteRecycleItemRequest
   * @param headers - DeleteRecycleItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteRecycleItemResponse
   */
  async deleteRecycleItemWithOptions(recycleBinId: string, recycleItemId: string, request: DeleteRecycleItemRequest, headers: DeleteRecycleItemHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecycleItemResponse> {
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
      action: "DeleteRecycleItem",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/${recycleItemId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteRecycleItemResponse>(await this.execute(params, req, runtime), new DeleteRecycleItemResponse({}));
  }

  /**
   * 删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
   * 
   * @param request - DeleteRecycleItemRequest
   * @returns DeleteRecycleItemResponse
   */
  async deleteRecycleItem(recycleBinId: string, recycleItemId: string, request: DeleteRecycleItemRequest): Promise<DeleteRecycleItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecycleItemHeaders({ });
    return await this.deleteRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
  }

  /**
   * 批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
   * 
   * @param request - DeleteRecycleItemsRequest
   * @param headers - DeleteRecycleItemsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteRecycleItemsResponse
   */
  async deleteRecycleItemsWithOptions(recycleBinId: string, request: DeleteRecycleItemsRequest, headers: DeleteRecycleItemsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecycleItemsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleItemIds)) {
      body["recycleItemIds"] = request.recycleItemIds;
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
      action: "DeleteRecycleItems",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteRecycleItemsResponse>(await this.execute(params, req, runtime), new DeleteRecycleItemsResponse({}));
  }

  /**
   * 批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
   * 
   * @param request - DeleteRecycleItemsRequest
   * @returns DeleteRecycleItemsResponse
   */
  async deleteRecycleItems(recycleBinId: string, request: DeleteRecycleItemsRequest): Promise<DeleteRecycleItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecycleItemsHeaders({ });
    return await this.deleteRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
  }

  /**
   * 获取开放平台应用在企业存储中的相关应用信息
   * 
   * @param request - GetCurrentAppRequest
   * @param headers - GetCurrentAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCurrentAppResponse
   */
  async getCurrentAppWithOptions(request: GetCurrentAppRequest, headers: GetCurrentAppHeaders, runtime: $Util.RuntimeOptions): Promise<GetCurrentAppResponse> {
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
      action: "GetCurrentApp",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/currentApps/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCurrentAppResponse>(await this.execute(params, req, runtime), new GetCurrentAppResponse({}));
  }

  /**
   * 获取开放平台应用在企业存储中的相关应用信息
   * 
   * @param request - GetCurrentAppRequest
   * @returns GetCurrentAppResponse
   */
  async getCurrentApp(request: GetCurrentAppRequest): Promise<GetCurrentAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCurrentAppHeaders({ });
    return await this.getCurrentAppWithOptions(request, headers, runtime);
  }

  /**
   * 批量获取文件(夹)信息
   * 
   * @param request - GetDentriesRequest
   * @param headers - GetDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDentriesResponse
   */
  async getDentriesWithOptions(spaceId: string, request: GetDentriesRequest, headers: GetDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
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
      action: "GetDentries",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentriesResponse>(await this.execute(params, req, runtime), new GetDentriesResponse({}));
  }

  /**
   * 批量获取文件(夹)信息
   * 
   * @param request - GetDentriesRequest
   * @returns GetDentriesResponse
   */
  async getDentries(spaceId: string, request: GetDentriesRequest): Promise<GetDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentriesHeaders({ });
    return await this.getDentriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取文件(夹)信息
   * 
   * @param request - GetDentryRequest
   * @param headers - GetDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDentryResponse
   */
  async getDentryWithOptions(spaceId: string, dentryId: string, request: GetDentryRequest, headers: GetDentryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryResponse> {
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
      action: "GetDentry",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentryResponse>(await this.execute(params, req, runtime), new GetDentryResponse({}));
  }

  /**
   * 获取文件(夹)信息
   * 
   * @param request - GetDentryRequest
   * @returns GetDentryResponse
   */
  async getDentry(spaceId: string, dentryId: string, request: GetDentryRequest): Promise<GetDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryHeaders({ });
    return await this.getDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 获取文件打开链接
   * 
   * @param request - GetDentryOpenInfoRequest
   * @param headers - GetDentryOpenInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDentryOpenInfoResponse
   */
  async getDentryOpenInfoWithOptions(spaceId: string, dentryId: string, request: GetDentryOpenInfoRequest, headers: GetDentryOpenInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryOpenInfoResponse> {
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
      action: "GetDentryOpenInfo",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/openInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentryOpenInfoResponse>(await this.execute(params, req, runtime), new GetDentryOpenInfoResponse({}));
  }

  /**
   * 获取文件打开链接
   * 
   * @param request - GetDentryOpenInfoRequest
   * @returns GetDentryOpenInfoResponse
   */
  async getDentryOpenInfo(spaceId: string, dentryId: string, request: GetDentryOpenInfoRequest): Promise<GetDentryOpenInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryOpenInfoHeaders({ });
    return await this.getDentryOpenInfoWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 批量获取文件缩略图
   * 
   * @param request - GetDentryThumbnailsRequest
   * @param headers - GetDentryThumbnailsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDentryThumbnailsResponse
   */
  async getDentryThumbnailsWithOptions(spaceId: string, request: GetDentryThumbnailsRequest, headers: GetDentryThumbnailsHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryThumbnailsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
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
      action: "GetDentryThumbnails",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/thumbnails/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentryThumbnailsResponse>(await this.execute(params, req, runtime), new GetDentryThumbnailsResponse({}));
  }

  /**
   * 批量获取文件缩略图
   * 
   * @param request - GetDentryThumbnailsRequest
   * @returns GetDentryThumbnailsResponse
   */
  async getDentryThumbnails(spaceId: string, request: GetDentryThumbnailsRequest): Promise<GetDentryThumbnailsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryThumbnailsHeaders({ });
    return await this.getDentryThumbnailsWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取文件下载信息
   * 
   * @param request - GetFileDownloadInfoRequest
   * @param headers - GetFileDownloadInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFileDownloadInfoResponse
   */
  async getFileDownloadInfoWithOptions(spaceId: string, dentryId: string, request: GetFileDownloadInfoRequest, headers: GetFileDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileDownloadInfoResponse> {
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
      action: "GetFileDownloadInfo",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/downloadInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFileDownloadInfoResponse>(await this.execute(params, req, runtime), new GetFileDownloadInfoResponse({}));
  }

  /**
   * 获取文件下载信息
   * 
   * @param request - GetFileDownloadInfoRequest
   * @returns GetFileDownloadInfoResponse
   */
  async getFileDownloadInfo(spaceId: string, dentryId: string, request: GetFileDownloadInfoRequest): Promise<GetFileDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileDownloadInfoHeaders({ });
    return await this.getFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 获取文件上传信息
   * 
   * @param request - GetFileUploadInfoRequest
   * @param headers - GetFileUploadInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFileUploadInfoResponse
   */
  async getFileUploadInfoWithOptions(spaceId: string, request: GetFileUploadInfoRequest, headers: GetFileUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileUploadInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.multipart)) {
      body["multipart"] = request.multipart;
    }

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
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/files/uploadInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFileUploadInfoResponse>(await this.execute(params, req, runtime), new GetFileUploadInfoResponse({}));
  }

  /**
   * 获取文件上传信息
   * 
   * @param request - GetFileUploadInfoRequest
   * @returns GetFileUploadInfoResponse
   */
  async getFileUploadInfo(spaceId: string, request: GetFileUploadInfoRequest): Promise<GetFileUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadInfoHeaders({ });
    return await this.getFileUploadInfoWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取文件上传信息(分片上传)
   * 
   * @param request - GetMultipartFileUploadInfosRequest
   * @param headers - GetMultipartFileUploadInfosHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMultipartFileUploadInfosResponse
   */
  async getMultipartFileUploadInfosWithOptions(request: GetMultipartFileUploadInfosRequest, headers: GetMultipartFileUploadInfosHeaders, runtime: $Util.RuntimeOptions): Promise<GetMultipartFileUploadInfosResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.partNumbers)) {
      body["partNumbers"] = request.partNumbers;
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
      action: "GetMultipartFileUploadInfos",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/files/multiPartUploadInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMultipartFileUploadInfosResponse>(await this.execute(params, req, runtime), new GetMultipartFileUploadInfosResponse({}));
  }

  /**
   * 获取文件上传信息(分片上传)
   * 
   * @param request - GetMultipartFileUploadInfosRequest
   * @returns GetMultipartFileUploadInfosResponse
   */
  async getMultipartFileUploadInfos(request: GetMultipartFileUploadInfosRequest): Promise<GetMultipartFileUploadInfosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMultipartFileUploadInfosHeaders({ });
    return await this.getMultipartFileUploadInfosWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业存储中企业维度的信息
   * 
   * @param request - GetOrgRequest
   * @param headers - GetOrgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOrgResponse
   */
  async getOrgWithOptions(corpId: string, request: GetOrgRequest, headers: GetOrgHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrgResponse> {
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
      action: "GetOrg",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/orgs/${corpId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrgResponse>(await this.execute(params, req, runtime), new GetOrgResponse({}));
  }

  /**
   * 获取企业存储中企业维度的信息
   * 
   * @param request - GetOrgRequest
   * @returns GetOrgResponse
   */
  async getOrg(corpId: string, request: GetOrgRequest): Promise<GetOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrgHeaders({ });
    return await this.getOrgWithOptions(corpId, request, headers, runtime);
  }

  /**
   * 获取回收站信息
   * 
   * @param request - GetRecycleBinRequest
   * @param headers - GetRecycleBinHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRecycleBinResponse
   */
  async getRecycleBinWithOptions(request: GetRecycleBinRequest, headers: GetRecycleBinHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecycleBinResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleBinScope)) {
      query["recycleBinScope"] = request.recycleBinScope;
    }

    if (!Util.isUnset(request.scopeId)) {
      query["scopeId"] = request.scopeId;
    }

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
      action: "GetRecycleBin",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecycleBinResponse>(await this.execute(params, req, runtime), new GetRecycleBinResponse({}));
  }

  /**
   * 获取回收站信息
   * 
   * @param request - GetRecycleBinRequest
   * @returns GetRecycleBinResponse
   */
  async getRecycleBin(request: GetRecycleBinRequest): Promise<GetRecycleBinResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecycleBinHeaders({ });
    return await this.getRecycleBinWithOptions(request, headers, runtime);
  }

  /**
   * 获取回收项详情
   * 
   * @param request - GetRecycleItemRequest
   * @param headers - GetRecycleItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRecycleItemResponse
   */
  async getRecycleItemWithOptions(recycleBinId: string, recycleItemId: string, request: GetRecycleItemRequest, headers: GetRecycleItemHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecycleItemResponse> {
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
      action: "GetRecycleItem",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/${recycleItemId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecycleItemResponse>(await this.execute(params, req, runtime), new GetRecycleItemResponse({}));
  }

  /**
   * 获取回收项详情
   * 
   * @param request - GetRecycleItemRequest
   * @returns GetRecycleItemResponse
   */
  async getRecycleItem(recycleBinId: string, recycleItemId: string, request: GetRecycleItemRequest): Promise<GetRecycleItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecycleItemHeaders({ });
    return await this.getRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
  }

  /**
   * 获取空间信息
   * 
   * @param request - GetSpaceRequest
   * @param headers - GetSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpaceResponse
   */
  async getSpaceWithOptions(spaceId: string, request: GetSpaceRequest, headers: GetSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceResponse> {
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
      action: "GetSpace",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceResponse>(await this.execute(params, req, runtime), new GetSpaceResponse({}));
  }

  /**
   * 获取空间信息
   * 
   * @param request - GetSpaceRequest
   * @returns GetSpaceResponse
   */
  async getSpace(spaceId: string, request: GetSpaceRequest): Promise<GetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceHeaders({ });
    return await this.getSpaceWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取异步任务信息
   * 
   * @param request - GetTaskRequest
   * @param headers - GetTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTaskResponse
   */
  async getTaskWithOptions(taskId: string, request: GetTaskRequest, headers: GetTaskHeaders, runtime: $Util.RuntimeOptions): Promise<GetTaskResponse> {
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
      action: "GetTask",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/tasks/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTaskResponse>(await this.execute(params, req, runtime), new GetTaskResponse({}));
  }

  /**
   * 获取异步任务信息
   * 
   * @param request - GetTaskRequest
   * @returns GetTaskResponse
   */
  async getTask(taskId: string, request: GetTaskRequest): Promise<GetTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTaskHeaders({ });
    return await this.getTaskWithOptions(taskId, request, headers, runtime);
  }

  /**
   * 获取 WebOfficeUrl 接口
   * 
   * @param request - GetWebOfficeUrlRequest
   * @param headers - GetWebOfficeUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetWebOfficeUrlResponse
   */
  async getWebOfficeUrlWithOptions(spaceId: string, dentryId: string, request: GetWebOfficeUrlRequest, headers: GetWebOfficeUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetWebOfficeUrlResponse> {
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
      action: "GetWebOfficeUrl",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/webOfficeUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWebOfficeUrlResponse>(await this.execute(params, req, runtime), new GetWebOfficeUrlResponse({}));
  }

  /**
   * 获取 WebOfficeUrl 接口
   * 
   * @param request - GetWebOfficeUrlRequest
   * @returns GetWebOfficeUrlResponse
   */
  async getWebOfficeUrl(spaceId: string, dentryId: string, request: GetWebOfficeUrlRequest): Promise<GetWebOfficeUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWebOfficeUrlHeaders({ });
    return await this.getWebOfficeUrlWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 初始化文件分片上传
   * 
   * @param request - InitMultipartFileUploadRequest
   * @param headers - InitMultipartFileUploadHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InitMultipartFileUploadResponse
   */
  async initMultipartFileUploadWithOptions(spaceId: string, request: InitMultipartFileUploadRequest, headers: InitMultipartFileUploadHeaders, runtime: $Util.RuntimeOptions): Promise<InitMultipartFileUploadResponse> {
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
      action: "InitMultipartFileUpload",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/files/multiPartUploadInfos/init`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InitMultipartFileUploadResponse>(await this.execute(params, req, runtime), new InitMultipartFileUploadResponse({}));
  }

  /**
   * 初始化文件分片上传
   * 
   * @param request - InitMultipartFileUploadRequest
   * @returns InitMultipartFileUploadResponse
   */
  async initMultipartFileUpload(spaceId: string, request: InitMultipartFileUploadRequest): Promise<InitMultipartFileUploadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitMultipartFileUploadHeaders({ });
    return await this.initMultipartFileUploadWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取文件列表
   * 
   * @param request - ListAllDentriesRequest
   * @param headers - ListAllDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAllDentriesResponse
   */
  async listAllDentriesWithOptions(spaceId: string, request: ListAllDentriesRequest, headers: ListAllDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<ListAllDentriesResponse> {
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
      action: "ListAllDentries",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/listAll`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAllDentriesResponse>(await this.execute(params, req, runtime), new ListAllDentriesResponse({}));
  }

  /**
   * 获取文件列表
   * 
   * @param request - ListAllDentriesRequest
   * @returns ListAllDentriesResponse
   */
  async listAllDentries(spaceId: string, request: ListAllDentriesRequest): Promise<ListAllDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAllDentriesHeaders({ });
    return await this.listAllDentriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取文件列表
   * 
   * @param request - ListDentriesRequest
   * @param headers - ListDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListDentriesResponse
   */
  async listDentriesWithOptions(spaceId: string, request: ListDentriesRequest, headers: ListDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<ListDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.order)) {
      query["order"] = request.order;
    }

    if (!Util.isUnset(request.orderBy)) {
      query["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.parentId)) {
      query["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.withThumbnail)) {
      query["withThumbnail"] = request.withThumbnail;
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
      action: "ListDentries",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListDentriesResponse>(await this.execute(params, req, runtime), new ListDentriesResponse({}));
  }

  /**
   * 获取文件列表
   * 
   * @param request - ListDentriesRequest
   * @returns ListDentriesResponse
   */
  async listDentries(spaceId: string, request: ListDentriesRequest): Promise<ListDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDentriesHeaders({ });
    return await this.listDentriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取文件历史版本
   * 
   * @param request - ListDentryVersionsRequest
   * @param headers - ListDentryVersionsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListDentryVersionsResponse
   */
  async listDentryVersionsWithOptions(spaceId: string, dentryId: string, request: ListDentryVersionsRequest, headers: ListDentryVersionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListDentryVersionsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

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
      action: "ListDentryVersions",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/versions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListDentryVersionsResponse>(await this.execute(params, req, runtime), new ListDentryVersionsResponse({}));
  }

  /**
   * 获取文件历史版本
   * 
   * @param request - ListDentryVersionsRequest
   * @returns ListDentryVersionsResponse
   */
  async listDentryVersions(spaceId: string, dentryId: string, request: ListDentryVersionsRequest): Promise<ListDentryVersionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDentryVersionsHeaders({ });
    return await this.listDentryVersionsWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 获取权限列表
   * 
   * @param request - ListPermissionsRequest
   * @param headers - ListPermissionsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListPermissionsResponse
   */
  async listPermissionsWithOptions(spaceId: string, dentryId: string, request: ListPermissionsRequest, headers: ListPermissionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListPermissionsResponse> {
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
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/permissions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListPermissionsResponse>(await this.execute(params, req, runtime), new ListPermissionsResponse({}));
  }

  /**
   * 获取权限列表
   * 
   * @param request - ListPermissionsRequest
   * @returns ListPermissionsResponse
   */
  async listPermissions(spaceId: string, dentryId: string, request: ListPermissionsRequest): Promise<ListPermissionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPermissionsHeaders({ });
    return await this.listPermissionsWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 获取回收项列表
   * 
   * @param request - ListRecycleItemsRequest
   * @param headers - ListRecycleItemsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListRecycleItemsResponse
   */
  async listRecycleItemsWithOptions(recycleBinId: string, request: ListRecycleItemsRequest, headers: ListRecycleItemsHeaders, runtime: $Util.RuntimeOptions): Promise<ListRecycleItemsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

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
      action: "ListRecycleItems",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListRecycleItemsResponse>(await this.execute(params, req, runtime), new ListRecycleItemsResponse({}));
  }

  /**
   * 获取回收项列表
   * 
   * @param request - ListRecycleItemsRequest
   * @returns ListRecycleItemsResponse
   */
  async listRecycleItems(recycleBinId: string, request: ListRecycleItemsRequest): Promise<ListRecycleItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRecycleItemsHeaders({ });
    return await this.listRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
  }

  /**
   * 批量移动文件或文件夹
   * 
   * @param request - MoveDentriesRequest
   * @param headers - MoveDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MoveDentriesResponse
   */
  async moveDentriesWithOptions(spaceId: string, request: MoveDentriesRequest, headers: MoveDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<MoveDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.targetFolderId)) {
      body["targetFolderId"] = request.targetFolderId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
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
      action: "MoveDentries",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/batchMove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MoveDentriesResponse>(await this.execute(params, req, runtime), new MoveDentriesResponse({}));
  }

  /**
   * 批量移动文件或文件夹
   * 
   * @param request - MoveDentriesRequest
   * @returns MoveDentriesResponse
   */
  async moveDentries(spaceId: string, request: MoveDentriesRequest): Promise<MoveDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveDentriesHeaders({ });
    return await this.moveDentriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 移动文件或文件夹
   * 
   * @param request - MoveDentryRequest
   * @param headers - MoveDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MoveDentryResponse
   */
  async moveDentryWithOptions(spaceId: string, dentryId: string, request: MoveDentryRequest, headers: MoveDentryHeaders, runtime: $Util.RuntimeOptions): Promise<MoveDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.targetFolderId)) {
      body["targetFolderId"] = request.targetFolderId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
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
      action: "MoveDentry",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/move`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MoveDentryResponse>(await this.execute(params, req, runtime), new MoveDentryResponse({}));
  }

  /**
   * 移动文件或文件夹
   * 
   * @param request - MoveDentryRequest
   * @returns MoveDentryResponse
   */
  async moveDentry(spaceId: string, dentryId: string, request: MoveDentryRequest): Promise<MoveDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveDentryHeaders({ });
    return await this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 获取 accessToken 接口
   * 
   * @param request - RefreshWebOfficeTokenRequest
   * @param headers - RefreshWebOfficeTokenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RefreshWebOfficeTokenResponse
   */
  async refreshWebOfficeTokenWithOptions(spaceId: string, dentryId: string, request: RefreshWebOfficeTokenRequest, headers: RefreshWebOfficeTokenHeaders, runtime: $Util.RuntimeOptions): Promise<RefreshWebOfficeTokenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.webOfficeAccessToken)) {
      query["webOfficeAccessToken"] = request.webOfficeAccessToken;
    }

    if (!Util.isUnset(request.webOfficeRefreshToken)) {
      query["webOfficeRefreshToken"] = request.webOfficeRefreshToken;
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
      action: "RefreshWebOfficeToken",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/refreshWebOfficeToken`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RefreshWebOfficeTokenResponse>(await this.execute(params, req, runtime), new RefreshWebOfficeTokenResponse({}));
  }

  /**
   * 获取 accessToken 接口
   * 
   * @param request - RefreshWebOfficeTokenRequest
   * @returns RefreshWebOfficeTokenResponse
   */
  async refreshWebOfficeToken(spaceId: string, dentryId: string, request: RefreshWebOfficeTokenRequest): Promise<RefreshWebOfficeTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RefreshWebOfficeTokenHeaders({ });
    return await this.refreshWebOfficeTokenWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 注册文件预览或编辑链接
   * 
   * @param request - RegisterOpenInfoRequest
   * @param headers - RegisterOpenInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RegisterOpenInfoResponse
   */
  async registerOpenInfoWithOptions(spaceId: string, dentryId: string, request: RegisterOpenInfoRequest, headers: RegisterOpenInfoHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterOpenInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openInfos)) {
      body["openInfos"] = request.openInfos;
    }

    if (!Util.isUnset(request.provider)) {
      body["provider"] = request.provider;
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
      action: "RegisterOpenInfo",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/openInfos/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterOpenInfoResponse>(await this.execute(params, req, runtime), new RegisterOpenInfoResponse({}));
  }

  /**
   * 注册文件预览或编辑链接
   * 
   * @param request - RegisterOpenInfoRequest
   * @returns RegisterOpenInfoResponse
   */
  async registerOpenInfo(spaceId: string, dentryId: string, request: RegisterOpenInfoRequest): Promise<RegisterOpenInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterOpenInfoHeaders({ });
    return await this.registerOpenInfoWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 重命名文件或文件夹
   * 
   * @param request - RenameDentryRequest
   * @param headers - RenameDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RenameDentryResponse
   */
  async renameDentryWithOptions(spaceId: string, dentryId: string, request: RenameDentryRequest, headers: RenameDentryHeaders, runtime: $Util.RuntimeOptions): Promise<RenameDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.newName)) {
      body["newName"] = request.newName;
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
      action: "RenameDentry",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/rename`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RenameDentryResponse>(await this.execute(params, req, runtime), new RenameDentryResponse({}));
  }

  /**
   * 重命名文件或文件夹
   * 
   * @param request - RenameDentryRequest
   * @returns RenameDentryResponse
   */
  async renameDentry(spaceId: string, dentryId: string, request: RenameDentryRequest): Promise<RenameDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenameDentryHeaders({ });
    return await this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 还原回收站中的回收项
   * 
   * @param request - RestoreRecycleItemRequest
   * @param headers - RestoreRecycleItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RestoreRecycleItemResponse
   */
  async restoreRecycleItemWithOptions(recycleBinId: string, recycleItemId: string, request: RestoreRecycleItemRequest, headers: RestoreRecycleItemHeaders, runtime: $Util.RuntimeOptions): Promise<RestoreRecycleItemResponse> {
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
      action: "RestoreRecycleItem",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/${recycleItemId}/restore`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RestoreRecycleItemResponse>(await this.execute(params, req, runtime), new RestoreRecycleItemResponse({}));
  }

  /**
   * 还原回收站中的回收项
   * 
   * @param request - RestoreRecycleItemRequest
   * @returns RestoreRecycleItemResponse
   */
  async restoreRecycleItem(recycleBinId: string, recycleItemId: string, request: RestoreRecycleItemRequest): Promise<RestoreRecycleItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RestoreRecycleItemHeaders({ });
    return await this.restoreRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
  }

  /**
   * 批量还原回收站中的回收项
   * 
   * @param request - RestoreRecycleItemsRequest
   * @param headers - RestoreRecycleItemsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RestoreRecycleItemsResponse
   */
  async restoreRecycleItemsWithOptions(recycleBinId: string, request: RestoreRecycleItemsRequest, headers: RestoreRecycleItemsHeaders, runtime: $Util.RuntimeOptions): Promise<RestoreRecycleItemsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.recycleItemIds)) {
      body["recycleItemIds"] = request.recycleItemIds;
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
      action: "RestoreRecycleItems",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/batchRestore`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RestoreRecycleItemsResponse>(await this.execute(params, req, runtime), new RestoreRecycleItemsResponse({}));
  }

  /**
   * 批量还原回收站中的回收项
   * 
   * @param request - RestoreRecycleItemsRequest
   * @returns RestoreRecycleItemsResponse
   */
  async restoreRecycleItems(recycleBinId: string, request: RestoreRecycleItemsRequest): Promise<RestoreRecycleItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RestoreRecycleItemsHeaders({ });
    return await this.restoreRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
  }

  /**
   * 恢复文件历史版本
   * 
   * @param request - RevertDentryVersionRequest
   * @param headers - RevertDentryVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RevertDentryVersionResponse
   */
  async revertDentryVersionWithOptions(spaceId: string, dentryId: string, version: string, request: RevertDentryVersionRequest, headers: RevertDentryVersionHeaders, runtime: $Util.RuntimeOptions): Promise<RevertDentryVersionResponse> {
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
      action: "RevertDentryVersion",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/versions/${version}/revert`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RevertDentryVersionResponse>(await this.execute(params, req, runtime), new RevertDentryVersionResponse({}));
  }

  /**
   * 恢复文件历史版本
   * 
   * @param request - RevertDentryVersionRequest
   * @returns RevertDentryVersionResponse
   */
  async revertDentryVersion(spaceId: string, dentryId: string, version: string, request: RevertDentryVersionRequest): Promise<RevertDentryVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RevertDentryVersionHeaders({ });
    return await this.revertDentryVersionWithOptions(spaceId, dentryId, version, request, headers, runtime);
  }

  /**
   * 订阅文件变更事件
   * 
   * @param request - SubscribeEventRequest
   * @param headers - SubscribeEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SubscribeEventResponse
   */
  async subscribeEventWithOptions(request: SubscribeEventRequest, headers: SubscribeEventHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeEventResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.scopeId)) {
      body["scopeId"] = request.scopeId;
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
      action: "SubscribeEvent",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/events/subscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SubscribeEventResponse>(await this.execute(params, req, runtime), new SubscribeEventResponse({}));
  }

  /**
   * 订阅文件变更事件
   * 
   * @param request - SubscribeEventRequest
   * @returns SubscribeEventResponse
   */
  async subscribeEvent(request: SubscribeEventRequest): Promise<SubscribeEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeEventHeaders({ });
    return await this.subscribeEventWithOptions(request, headers, runtime);
  }

  /**
   * 取消订阅文件变更事件
   * 
   * @param request - UnsubscribeEventRequest
   * @param headers - UnsubscribeEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnsubscribeEventResponse
   */
  async unsubscribeEventWithOptions(request: UnsubscribeEventRequest, headers: UnsubscribeEventHeaders, runtime: $Util.RuntimeOptions): Promise<UnsubscribeEventResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.scopeId)) {
      body["scopeId"] = request.scopeId;
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
      action: "UnsubscribeEvent",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/events/unsubscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnsubscribeEventResponse>(await this.execute(params, req, runtime), new UnsubscribeEventResponse({}));
  }

  /**
   * 取消订阅文件变更事件
   * 
   * @param request - UnsubscribeEventRequest
   * @returns UnsubscribeEventResponse
   */
  async unsubscribeEvent(request: UnsubscribeEventRequest): Promise<UnsubscribeEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsubscribeEventHeaders({ });
    return await this.unsubscribeEventWithOptions(request, headers, runtime);
  }

  /**
   * 修改文件上的App属性值
   * 
   * @param request - UpdateDentryAppPropertiesRequest
   * @param headers - UpdateDentryAppPropertiesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateDentryAppPropertiesResponse
   */
  async updateDentryAppPropertiesWithOptions(spaceId: string, dentryId: string, request: UpdateDentryAppPropertiesRequest, headers: UpdateDentryAppPropertiesHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDentryAppPropertiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appProperties)) {
      body["appProperties"] = request.appProperties;
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
      action: "UpdateDentryAppProperties",
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/appProperties`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateDentryAppPropertiesResponse>(await this.execute(params, req, runtime), new UpdateDentryAppPropertiesResponse({}));
  }

  /**
   * 修改文件上的App属性值
   * 
   * @param request - UpdateDentryAppPropertiesRequest
   * @returns UpdateDentryAppPropertiesResponse
   */
  async updateDentryAppProperties(spaceId: string, dentryId: string, request: UpdateDentryAppPropertiesRequest): Promise<UpdateDentryAppPropertiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDentryAppPropertiesHeaders({ });
    return await this.updateDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 修改权限
   * 
   * @param request - UpdatePermissionRequest
   * @param headers - UpdatePermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdatePermissionResponse
   */
  async updatePermissionWithOptions(spaceId: string, dentryId: string, request: UpdatePermissionRequest, headers: UpdatePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePermissionResponse> {
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
      version: "storage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/permissions`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdatePermissionResponse>(await this.execute(params, req, runtime), new UpdatePermissionResponse({}));
  }

  /**
   * 修改权限
   * 
   * @param request - UpdatePermissionRequest
   * @returns UpdatePermissionResponse
   */
  async updatePermission(spaceId: string, dentryId: string, request: UpdatePermissionRequest): Promise<UpdatePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePermissionHeaders({ });
    return await this.updatePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
  }

}
