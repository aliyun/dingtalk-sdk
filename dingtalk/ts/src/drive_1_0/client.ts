// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddCustomSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomSpaceRequest extends $tea.Model {
  bizType?: string;
  identifier?: string;
  permissionMode?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      identifier: 'identifier',
      permissionMode: 'permissionMode',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      identifier: 'string',
      permissionMode: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomSpaceResponseBody extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddCustomSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddCustomSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileRequest extends $tea.Model {
  addConflictPolicy?: string;
  fileName?: string;
  fileType?: string;
  mediaId?: string;
  parentId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      addConflictPolicy: 'addConflictPolicy',
      fileName: 'fileName',
      fileType: 'fileType',
      mediaId: 'mediaId',
      parentId: 'parentId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addConflictPolicy: 'string',
      fileName: 'string',
      fileType: 'string',
      mediaId: 'string',
      parentId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileResponseBody extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddFileResponseBody,
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
  role?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      role: 'role',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': AddPermissionRequestMembers },
      role: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionResponse extends $tea.Model {
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
  name?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponseBody extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRecycleFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRecycleFilesRequest extends $tea.Model {
  recycleType?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      recycleType: 'recycleType',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleType: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRecycleFilesResponse extends $tea.Model {
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

export class CopyFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileRequest extends $tea.Model {
  addConflictPolicy?: string;
  targetParentId?: string;
  targetSpaceId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      addConflictPolicy: 'addConflictPolicy',
      targetParentId: 'targetParentId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addConflictPolicy: 'string',
      targetParentId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileResponseBody extends $tea.Model {
  file?: CopyFileResponseBodyFile;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      file: 'file',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      file: CopyFileResponseBodyFile,
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CopyFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CopyFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFileRequest extends $tea.Model {
  deletePolicy?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      deletePolicy: 'deletePolicy',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deletePolicy: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFileResponseBody extends $tea.Model {
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

export class DeleteFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFilesRequest extends $tea.Model {
  deletePolicy?: string;
  fileIds?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      deletePolicy: 'deletePolicy',
      fileIds: 'fileIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deletePolicy: 'string',
      fileIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFilesResponseBody extends $tea.Model {
  success?: boolean;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFilesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteFilesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteFilesResponseBody,
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
  role?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      role: 'role',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': DeletePermissionRequestMembers },
      role: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionResponse extends $tea.Model {
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

export class DeleteRecycleFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecycleFilesRequest extends $tea.Model {
  recycleItemIdList?: number[];
  recycleType?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      recycleItemIdList: 'recycleItemIdList',
      recycleType: 'recycleType',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItemIdList: { 'type': 'array', 'itemType': 'number' },
      recycleType: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecycleFilesResponse extends $tea.Model {
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

export class DeleteSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSpaceRequest extends $tea.Model {
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

export class DeleteSpaceResponse extends $tea.Model {
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

export class GetAsyncTaskInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAsyncTaskInfoRequest extends $tea.Model {
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

export class GetAsyncTaskInfoResponseBody extends $tea.Model {
  beginTime?: string;
  endTime?: string;
  failed?: number;
  status?: string;
  success?: number;
  taskId?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
      failed: 'failed',
      status: 'status',
      success: 'success',
      taskId: 'taskId',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'string',
      endTime: 'string',
      failed: 'number',
      status: 'string',
      success: 'number',
      taskId: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAsyncTaskInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAsyncTaskInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAsyncTaskInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoRequest extends $tea.Model {
  unionId?: string;
  withInternalResourceUrl?: boolean;
  withRegion?: boolean;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      withInternalResourceUrl: 'withInternalResourceUrl',
      withRegion: 'withRegion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      withInternalResourceUrl: 'boolean',
      withRegion: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponseBody extends $tea.Model {
  downloadInfo?: GetDownloadInfoResponseBodyDownloadInfo;
  region?: string;
  static names(): { [key: string]: string } {
    return {
      downloadInfo: 'downloadInfo',
      region: 'region',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadInfo: GetDownloadInfoResponseBodyDownloadInfo,
      region: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDownloadInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDownloadInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileInfoRequest extends $tea.Model {
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

export class GetFileInfoResponseBody extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFileInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFileInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMySpaceInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMySpaceInfoRequest extends $tea.Model {
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

export class GetMySpaceInfoResponseBody extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMySpaceInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMySpaceInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMySpaceInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPreviewInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPreviewInfoRequest extends $tea.Model {
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

export class GetPreviewInfoResponseBody extends $tea.Model {
  info?: GetPreviewInfoResponseBodyInfo;
  static names(): { [key: string]: string } {
    return {
      info: 'info',
    };
  }

  static types(): { [key: string]: any } {
    return {
      info: GetPreviewInfoResponseBodyInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPreviewInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPreviewInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPreviewInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrivilegeInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrivilegeInfoRequest extends $tea.Model {
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

export class GetPrivilegeInfoResponseBody extends $tea.Model {
  types?: string[];
  static names(): { [key: string]: string } {
    return {
      types: 'types',
    };
  }

  static types(): { [key: string]: any } {
    return {
      types: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrivilegeInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPrivilegeInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPrivilegeInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQuotaInfosHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQuotaInfosRequest extends $tea.Model {
  identifiers?: string[];
  type?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      identifiers: 'identifiers',
      type: 'type',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      identifiers: { 'type': 'array', 'itemType': 'string' },
      type: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQuotaInfosResponseBody extends $tea.Model {
  quotas?: GetQuotaInfosResponseBodyQuotas[];
  static names(): { [key: string]: string } {
    return {
      quotas: 'quotas',
    };
  }

  static types(): { [key: string]: any } {
    return {
      quotas: { 'type': 'array', 'itemType': GetQuotaInfosResponseBodyQuotas },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQuotaInfosResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetQuotaInfosResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetQuotaInfosResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoRequest extends $tea.Model {
  addConflictPolicy?: string;
  callerRegion?: string;
  fileName?: string;
  fileSize?: number;
  md5?: string;
  mediaId?: string;
  unionId?: string;
  withInternalEndPoint?: boolean;
  withRegion?: boolean;
  static names(): { [key: string]: string } {
    return {
      addConflictPolicy: 'addConflictPolicy',
      callerRegion: 'callerRegion',
      fileName: 'fileName',
      fileSize: 'fileSize',
      md5: 'md5',
      mediaId: 'mediaId',
      unionId: 'unionId',
      withInternalEndPoint: 'withInternalEndPoint',
      withRegion: 'withRegion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addConflictPolicy: 'string',
      callerRegion: 'string',
      fileName: 'string',
      fileSize: 'number',
      md5: 'string',
      mediaId: 'string',
      unionId: 'string',
      withInternalEndPoint: 'boolean',
      withRegion: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoResponseBody extends $tea.Model {
  headerSignatureUploadInfo?: GetUploadInfoResponseBodyHeaderSignatureUploadInfo;
  region?: string;
  stsUploadInfo?: GetUploadInfoResponseBodyStsUploadInfo;
  static names(): { [key: string]: string } {
    return {
      headerSignatureUploadInfo: 'headerSignatureUploadInfo',
      region: 'region',
      stsUploadInfo: 'stsUploadInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headerSignatureUploadInfo: GetUploadInfoResponseBodyHeaderSignatureUploadInfo,
      region: 'string',
      stsUploadInfo: GetUploadInfoResponseBodyStsUploadInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUploadInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUploadInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantPrivilegeOfCustomSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantPrivilegeOfCustomSpaceRequest extends $tea.Model {
  duration?: number;
  fileIds?: string[];
  type?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      fileIds: 'fileIds',
      type: 'type',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      fileIds: { 'type': 'array', 'itemType': 'string' },
      type: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantPrivilegeOfCustomSpaceResponse extends $tea.Model {
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

export class InfoSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InfoSpaceRequest extends $tea.Model {
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

export class InfoSpaceResponseBody extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InfoSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: InfoSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: InfoSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFilesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  orderType?: string;
  parentId?: string;
  unionId?: string;
  withIcon?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      orderType: 'orderType',
      parentId: 'parentId',
      unionId: 'unionId',
      withIcon: 'withIcon',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      orderType: 'string',
      parentId: 'string',
      unionId: 'string',
      withIcon: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFilesResponseBody extends $tea.Model {
  files?: ListFilesResponseBodyFiles[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      files: 'files',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      files: { 'type': 'array', 'itemType': ListFilesResponseBodyFiles },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFilesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListFilesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListFilesResponseBody,
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

export class ListPermissionsResponseBody extends $tea.Model {
  members?: ListPermissionsResponseBodyMembers[];
  outMembers?: ListPermissionsResponseBodyOutMembers[];
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      outMembers: 'outMembers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': ListPermissionsResponseBodyMembers },
      outMembers: { 'type': 'array', 'itemType': ListPermissionsResponseBodyOutMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListPermissionsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListPermissionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  orderType?: string;
  recycleType?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      orderType: 'orderType',
      recycleType: 'recycleType',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      orderType: 'string',
      recycleType: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesResponseBody extends $tea.Model {
  nextToken?: string;
  recycleItems?: ListRecycleFilesResponseBodyRecycleItems[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      recycleItems: 'recycleItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      recycleItems: { 'type': 'array', 'itemType': ListRecycleFilesResponseBodyRecycleItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListRecycleFilesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListRecycleFilesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  spaceType?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      spaceType: 'spaceType',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      spaceType: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesResponseBody extends $tea.Model {
  nextToken?: string;
  spaces?: ListSpacesResponseBodySpaces[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      spaces: 'spaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      spaces: { 'type': 'array', 'itemType': ListSpacesResponseBodySpaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSpacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementBuyQuotaHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementBuyQuotaRequest extends $tea.Model {
  order?: ManagementBuyQuotaRequestOrder;
  token?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      order: 'order',
      token: 'token',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      order: ManagementBuyQuotaRequestOrder,
      token: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementBuyQuotaResponse extends $tea.Model {
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

export class ManagementListSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementListSpacesRequest extends $tea.Model {
  spaceIds?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      spaceIds: 'spaceIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementListSpacesResponseBody extends $tea.Model {
  spaces?: ManagementListSpacesResponseBodySpaces[];
  static names(): { [key: string]: string } {
    return {
      spaces: 'spaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaces: { 'type': 'array', 'itemType': ManagementListSpacesResponseBodySpaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementListSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ManagementListSpacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ManagementListSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementModifySpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementModifySpaceRequest extends $tea.Model {
  quota?: number;
  spaceIds?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      quota: 'quota',
      spaceIds: 'spaceIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      quota: 'number',
      spaceIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementModifySpaceResponseBody extends $tea.Model {
  spaces?: ManagementModifySpaceResponseBodySpaces[];
  static names(): { [key: string]: string } {
    return {
      spaces: 'spaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaces: { 'type': 'array', 'itemType': ManagementModifySpaceResponseBodySpaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementModifySpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ManagementModifySpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ManagementModifySpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyPermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyPermissionRequest extends $tea.Model {
  members?: ModifyPermissionRequestMembers[];
  role?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      role: 'role',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': ModifyPermissionRequestMembers },
      role: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyPermissionResponse extends $tea.Model {
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

export class MoveFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileRequest extends $tea.Model {
  addConflictPolicy?: string;
  targetParentId?: string;
  targetSpaceId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      addConflictPolicy: 'addConflictPolicy',
      targetParentId: 'targetParentId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addConflictPolicy: 'string',
      targetParentId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileResponseBody extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: MoveFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MoveFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFilesRequest extends $tea.Model {
  addConflictPolicy?: string;
  fileIds?: string[];
  targetParentId?: string;
  targetSpaceId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      addConflictPolicy: 'addConflictPolicy',
      fileIds: 'fileIds',
      targetParentId: 'targetParentId',
      targetSpaceId: 'targetSpaceId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addConflictPolicy: 'string',
      fileIds: { 'type': 'array', 'itemType': 'string' },
      targetParentId: 'string',
      targetSpaceId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFilesResponseBody extends $tea.Model {
  files?: MoveFilesResponseBodyFiles[];
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      files: 'files',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      files: { 'type': 'array', 'itemType': MoveFilesResponseBodyFiles },
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFilesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: MoveFilesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MoveFilesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecoverRecycleFilesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecoverRecycleFilesRequest extends $tea.Model {
  recycleItemIdList?: number[];
  recycleType?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      recycleItemIdList: 'recycleItemIdList',
      recycleType: 'recycleType',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItemIdList: { 'type': 'array', 'itemType': 'number' },
      recycleType: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecoverRecycleFilesResponse extends $tea.Model {
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

export class RenameFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameFileRequest extends $tea.Model {
  newFileName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      newFileName: 'newFileName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newFileName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameFileResponseBody extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RenameFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RenameFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPermissionRequestMembers extends $tea.Model {
  corpId?: string;
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberId: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileResponseBodyFile extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionRequestMembers extends $tea.Model {
  corpId?: string;
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberId: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponseBodyDownloadInfo extends $tea.Model {
  expirationSeconds?: number;
  headers?: { [key: string]: any };
  internalResourceUrl?: string;
  resourceUrl?: string;
  static names(): { [key: string]: string } {
    return {
      expirationSeconds: 'expirationSeconds',
      headers: 'headers',
      internalResourceUrl: 'internalResourceUrl',
      resourceUrl: 'resourceUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationSeconds: 'number',
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      internalResourceUrl: 'string',
      resourceUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPreviewInfoResponseBodyInfo extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQuotaInfosResponseBodyQuotas extends $tea.Model {
  identifier?: string;
  quota?: number;
  type?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      identifier: 'identifier',
      quota: 'quota',
      type: 'type',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      identifier: 'string',
      quota: 'number',
      type: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoResponseBodyHeaderSignatureUploadInfo extends $tea.Model {
  expirationSeconds?: number;
  headers?: { [key: string]: any };
  internalResourceUrl?: string;
  mediaId?: string;
  resourceUrl?: string;
  static names(): { [key: string]: string } {
    return {
      expirationSeconds: 'expirationSeconds',
      headers: 'headers',
      internalResourceUrl: 'internalResourceUrl',
      mediaId: 'mediaId',
      resourceUrl: 'resourceUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationSeconds: 'number',
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      internalResourceUrl: 'string',
      mediaId: 'string',
      resourceUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoResponseBodyStsUploadInfo extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  accessToken?: string;
  accessTokenExpirationMillis?: number;
  bucket?: string;
  endPoint?: string;
  internalEndPoint?: string;
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      accessToken: 'accessToken',
      accessTokenExpirationMillis: 'accessTokenExpirationMillis',
      bucket: 'bucket',
      endPoint: 'endPoint',
      internalEndPoint: 'internalEndPoint',
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      accessToken: 'string',
      accessTokenExpirationMillis: 'number',
      bucket: 'string',
      endPoint: 'string',
      internalEndPoint: 'string',
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFilesResponseBodyFiles extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  icon?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  thumbnail?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      icon: 'icon',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
      thumbnail: 'thumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      icon: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
      thumbnail: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyMembersMember extends $tea.Model {
  corpId?: string;
  memberId?: string;
  memberName?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberId: 'memberId',
      memberName: 'memberName',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberId: 'string',
      memberName: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyMembers extends $tea.Model {
  extend?: boolean;
  member?: ListPermissionsResponseBodyMembersMember;
  role?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      member: 'member',
      role: 'role',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'boolean',
      member: ListPermissionsResponseBodyMembersMember,
      role: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyOutMembersMember extends $tea.Model {
  corpId?: string;
  memberId?: string;
  memberName?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberId: 'memberId',
      memberName: 'memberName',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberId: 'string',
      memberName: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyOutMembers extends $tea.Model {
  extend?: boolean;
  member?: ListPermissionsResponseBodyOutMembersMember;
  role?: string;
  static names(): { [key: string]: string } {
    return {
      extend: 'extend',
      member: 'member',
      role: 'role',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extend: 'boolean',
      member: ListPermissionsResponseBodyOutMembersMember,
      role: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesResponseBodyRecycleItems extends $tea.Model {
  contentType?: string;
  deleteStaffId?: string;
  deleteTime?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  recycleItemId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      deleteStaffId: 'deleteStaffId',
      deleteTime: 'deleteTime',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      recycleItemId: 'recycleItemId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      deleteStaffId: 'string',
      deleteTime: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      recycleItemId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesResponseBodySpaces extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementBuyQuotaRequestOrder extends $tea.Model {
  bizType?: string;
  capacity?: number;
  capacityType?: string;
  day?: number;
  money?: number;
  orderId?: number;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      capacity: 'capacity',
      capacityType: 'capacityType',
      day: 'day',
      money: 'money',
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      capacity: 'number',
      capacityType: 'string',
      day: 'number',
      money: 'number',
      orderId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementListSpacesResponseBodySpaces extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManagementModifySpaceResponseBodySpaces extends $tea.Model {
  createTime?: string;
  modifyTime?: string;
  permissionMode?: string;
  quota?: number;
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      permissionMode: 'permissionMode',
      quota: 'quota',
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      usedQuota: 'usedQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifyTime: 'string',
      permissionMode: 'string',
      quota: 'number',
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      usedQuota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyPermissionRequestMembers extends $tea.Model {
  corpId?: string;
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberId: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFilesResponseBodyFiles extends $tea.Model {
  contentType?: string;
  createTime?: string;
  creator?: string;
  fileExtension?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileSize?: number;
  fileType?: string;
  modifier?: string;
  modifyTime?: string;
  parentId?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createTime: 'createTime',
      creator: 'creator',
      fileExtension: 'fileExtension',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileSize: 'fileSize',
      fileType: 'fileType',
      modifier: 'modifier',
      modifyTime: 'modifyTime',
      parentId: 'parentId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createTime: 'string',
      creator: 'string',
      fileExtension: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileSize: 'number',
      fileType: 'string',
      modifier: 'string',
      modifyTime: 'string',
      parentId: 'string',
      spaceId: 'string',
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


  async addCustomSpace(request: AddCustomSpaceRequest): Promise<AddCustomSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCustomSpaceHeaders({ });
    return await this.addCustomSpaceWithOptions(request, headers, runtime);
  }

  async addCustomSpaceWithOptions(request: AddCustomSpaceRequest, headers: AddCustomSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AddCustomSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.identifier)) {
      body["identifier"] = request.identifier;
    }

    if (!Util.isUnset(request.permissionMode)) {
      body["permissionMode"] = request.permissionMode;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<AddCustomSpaceResponse>(await this.doROARequest("AddCustomSpace", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/customSpaces`, "json", req, runtime), new AddCustomSpaceResponse({}));
  }

  async addFile(spaceId: string, request: AddFileRequest): Promise<AddFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFileHeaders({ });
    return await this.addFileWithOptions(spaceId, request, headers, runtime);
  }

  async addFileWithOptions(spaceId: string, request: AddFileRequest, headers: AddFileHeaders, runtime: $Util.RuntimeOptions): Promise<AddFileResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileType)) {
      body["fileType"] = request.fileType;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<AddFileResponse>(await this.doROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files`, "json", req, runtime), new AddFileResponse({}));
  }

  async addPermission(spaceId: string, fileId: string, request: AddPermissionRequest): Promise<AddPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPermissionHeaders({ });
    return await this.addPermissionWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async addPermissionWithOptions(spaceId: string, fileId: string, request: AddPermissionRequest, headers: AddPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<AddPermissionResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<AddPermissionResponse>(await this.doROARequest("AddPermission", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions`, "none", req, runtime), new AddPermissionResponse({}));
  }

  async addSpace(request: AddSpaceRequest): Promise<AddSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddSpaceHeaders({ });
    return await this.addSpaceWithOptions(request, headers, runtime);
  }

  async addSpaceWithOptions(request: AddSpaceRequest, headers: AddSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AddSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<AddSpaceResponse>(await this.doROARequest("AddSpace", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces`, "json", req, runtime), new AddSpaceResponse({}));
  }

  async clearRecycleFiles(request: ClearRecycleFilesRequest): Promise<ClearRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearRecycleFilesHeaders({ });
    return await this.clearRecycleFilesWithOptions(request, headers, runtime);
  }

  async clearRecycleFilesWithOptions(request: ClearRecycleFilesRequest, headers: ClearRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ClearRecycleFilesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleType)) {
      body["recycleType"] = request.recycleType;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<ClearRecycleFilesResponse>(await this.doROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/recycleItems/clear`, "none", req, runtime), new ClearRecycleFilesResponse({}));
  }

  async copyFile(spaceId: string, fileId: string, request: CopyFileRequest): Promise<CopyFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyFileHeaders({ });
    return await this.copyFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async copyFileWithOptions(spaceId: string, fileId: string, request: CopyFileRequest, headers: CopyFileHeaders, runtime: $Util.RuntimeOptions): Promise<CopyFileResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.targetParentId)) {
      body["targetParentId"] = request.targetParentId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<CopyFileResponse>(await this.doROARequest("CopyFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/copy`, "json", req, runtime), new CopyFileResponse({}));
  }

  async deleteFile(spaceId: string, fileId: string, request: DeleteFileRequest): Promise<DeleteFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFileHeaders({ });
    return await this.deleteFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async deleteFileWithOptions(spaceId: string, fileId: string, request: DeleteFileRequest, headers: DeleteFileHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFileResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deletePolicy)) {
      query["deletePolicy"] = request.deletePolicy;
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
    return $tea.cast<DeleteFileResponse>(await this.doROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}`, "json", req, runtime), new DeleteFileResponse({}));
  }

  async deleteFiles(spaceId: string, request: DeleteFilesRequest): Promise<DeleteFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFilesHeaders({ });
    return await this.deleteFilesWithOptions(spaceId, request, headers, runtime);
  }

  async deleteFilesWithOptions(spaceId: string, request: DeleteFilesRequest, headers: DeleteFilesHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFilesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deletePolicy)) {
      body["deletePolicy"] = request.deletePolicy;
    }

    if (!Util.isUnset(request.fileIds)) {
      body["fileIds"] = request.fileIds;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<DeleteFilesResponse>(await this.doROARequest("DeleteFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/batchDelete`, "json", req, runtime), new DeleteFilesResponse({}));
  }

  async deletePermission(spaceId: string, fileId: string, request: DeletePermissionRequest): Promise<DeletePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePermissionHeaders({ });
    return await this.deletePermissionWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async deletePermissionWithOptions(spaceId: string, fileId: string, request: DeletePermissionRequest, headers: DeletePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePermissionResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<DeletePermissionResponse>(await this.doROARequest("DeletePermission", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions/delete`, "none", req, runtime), new DeletePermissionResponse({}));
  }

  async deleteRecycleFiles(request: DeleteRecycleFilesRequest): Promise<DeleteRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecycleFilesHeaders({ });
    return await this.deleteRecycleFilesWithOptions(request, headers, runtime);
  }

  async deleteRecycleFilesWithOptions(request: DeleteRecycleFilesRequest, headers: DeleteRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecycleFilesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleItemIdList)) {
      body["recycleItemIdList"] = request.recycleItemIdList;
    }

    if (!Util.isUnset(request.recycleType)) {
      body["recycleType"] = request.recycleType;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<DeleteRecycleFilesResponse>(await this.doROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/recycleItems/delete`, "none", req, runtime), new DeleteRecycleFilesResponse({}));
  }

  async deleteSpace(spaceId: string, request: DeleteSpaceRequest): Promise<DeleteSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSpaceHeaders({ });
    return await this.deleteSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async deleteSpaceWithOptions(spaceId: string, request: DeleteSpaceRequest, headers: DeleteSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSpaceResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
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
    return $tea.cast<DeleteSpaceResponse>(await this.doROARequest("DeleteSpace", "drive_1.0", "HTTP", "DELETE", "AK", `/v1.0/drive/spaces/${spaceId}`, "none", req, runtime), new DeleteSpaceResponse({}));
  }

  async getAsyncTaskInfo(taskId: string, request: GetAsyncTaskInfoRequest): Promise<GetAsyncTaskInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAsyncTaskInfoHeaders({ });
    return await this.getAsyncTaskInfoWithOptions(taskId, request, headers, runtime);
  }

  async getAsyncTaskInfoWithOptions(taskId: string, request: GetAsyncTaskInfoRequest, headers: GetAsyncTaskInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetAsyncTaskInfoResponse> {
    Util.validateModel(request);
    taskId = OpenApiUtil.getEncodeParam(taskId);
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
    return $tea.cast<GetAsyncTaskInfoResponse>(await this.doROARequest("GetAsyncTaskInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/tasks/${taskId}`, "json", req, runtime), new GetAsyncTaskInfoResponse({}));
  }

  async getDownloadInfo(spaceId: string, fileId: string, request: GetDownloadInfoRequest): Promise<GetDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDownloadInfoHeaders({ });
    return await this.getDownloadInfoWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async getDownloadInfoWithOptions(spaceId: string, fileId: string, request: GetDownloadInfoRequest, headers: GetDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDownloadInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.withInternalResourceUrl)) {
      query["withInternalResourceUrl"] = request.withInternalResourceUrl;
    }

    if (!Util.isUnset(request.withRegion)) {
      query["withRegion"] = request.withRegion;
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
    return $tea.cast<GetDownloadInfoResponse>(await this.doROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/downloadInfos`, "json", req, runtime), new GetDownloadInfoResponse({}));
  }

  async getFileInfo(spaceId: string, fileId: string, request: GetFileInfoRequest): Promise<GetFileInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileInfoHeaders({ });
    return await this.getFileInfoWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async getFileInfoWithOptions(spaceId: string, fileId: string, request: GetFileInfoRequest, headers: GetFileInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
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
    return $tea.cast<GetFileInfoResponse>(await this.doROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}`, "json", req, runtime), new GetFileInfoResponse({}));
  }

  async getMySpaceInfo(request: GetMySpaceInfoRequest): Promise<GetMySpaceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMySpaceInfoHeaders({ });
    return await this.getMySpaceInfoWithOptions(request, headers, runtime);
  }

  async getMySpaceInfoWithOptions(request: GetMySpaceInfoRequest, headers: GetMySpaceInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetMySpaceInfoResponse> {
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
    return $tea.cast<GetMySpaceInfoResponse>(await this.doROARequest("GetMySpaceInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/mySpaces`, "json", req, runtime), new GetMySpaceInfoResponse({}));
  }

  async getPreviewInfo(spaceId: string, fileId: string, request: GetPreviewInfoRequest): Promise<GetPreviewInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPreviewInfoHeaders({ });
    return await this.getPreviewInfoWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async getPreviewInfoWithOptions(spaceId: string, fileId: string, request: GetPreviewInfoRequest, headers: GetPreviewInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPreviewInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
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
    return $tea.cast<GetPreviewInfoResponse>(await this.doROARequest("GetPreviewInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/previewInfos`, "json", req, runtime), new GetPreviewInfoResponse({}));
  }

  async getPrivilegeInfo(spaceId: string, fileId: string, request: GetPrivilegeInfoRequest): Promise<GetPrivilegeInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrivilegeInfoHeaders({ });
    return await this.getPrivilegeInfoWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async getPrivilegeInfoWithOptions(spaceId: string, fileId: string, request: GetPrivilegeInfoRequest, headers: GetPrivilegeInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrivilegeInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
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
    return $tea.cast<GetPrivilegeInfoResponse>(await this.doROARequest("GetPrivilegeInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/privileges`, "json", req, runtime), new GetPrivilegeInfoResponse({}));
  }

  async getQuotaInfos(request: GetQuotaInfosRequest): Promise<GetQuotaInfosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetQuotaInfosHeaders({ });
    return await this.getQuotaInfosWithOptions(request, headers, runtime);
  }

  async getQuotaInfosWithOptions(request: GetQuotaInfosRequest, headers: GetQuotaInfosHeaders, runtime: $Util.RuntimeOptions): Promise<GetQuotaInfosResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.identifiers)) {
      body["identifiers"] = request.identifiers;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<GetQuotaInfosResponse>(await this.doROARequest("GetQuotaInfos", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/quotaInfos/query`, "json", req, runtime), new GetQuotaInfosResponse({}));
  }

  async getUploadInfo(spaceId: string, parentId: string, request: GetUploadInfoRequest): Promise<GetUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadInfoHeaders({ });
    return await this.getUploadInfoWithOptions(spaceId, parentId, request, headers, runtime);
  }

  async getUploadInfoWithOptions(spaceId: string, parentId: string, request: GetUploadInfoRequest, headers: GetUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    parentId = OpenApiUtil.getEncodeParam(parentId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addConflictPolicy)) {
      query["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.callerRegion)) {
      query["callerRegion"] = request.callerRegion;
    }

    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileSize)) {
      query["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.md5)) {
      query["md5"] = request.md5;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.withInternalEndPoint)) {
      query["withInternalEndPoint"] = request.withInternalEndPoint;
    }

    if (!Util.isUnset(request.withRegion)) {
      query["withRegion"] = request.withRegion;
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
    return $tea.cast<GetUploadInfoResponse>(await this.doROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${parentId}/uploadInfos`, "json", req, runtime), new GetUploadInfoResponse({}));
  }

  async grantPrivilegeOfCustomSpace(spaceId: string, request: GrantPrivilegeOfCustomSpaceRequest): Promise<GrantPrivilegeOfCustomSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantPrivilegeOfCustomSpaceHeaders({ });
    return await this.grantPrivilegeOfCustomSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async grantPrivilegeOfCustomSpaceWithOptions(spaceId: string, request: GrantPrivilegeOfCustomSpaceRequest, headers: GrantPrivilegeOfCustomSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GrantPrivilegeOfCustomSpaceResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.duration)) {
      body["duration"] = request.duration;
    }

    if (!Util.isUnset(request.fileIds)) {
      body["fileIds"] = request.fileIds;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<GrantPrivilegeOfCustomSpaceResponse>(await this.doROARequest("GrantPrivilegeOfCustomSpace", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/customSpacePrivileges`, "none", req, runtime), new GrantPrivilegeOfCustomSpaceResponse({}));
  }

  async infoSpace(spaceId: string, request: InfoSpaceRequest): Promise<InfoSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InfoSpaceHeaders({ });
    return await this.infoSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async infoSpaceWithOptions(spaceId: string, request: InfoSpaceRequest, headers: InfoSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<InfoSpaceResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
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
    return $tea.cast<InfoSpaceResponse>(await this.doROARequest("InfoSpace", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}`, "json", req, runtime), new InfoSpaceResponse({}));
  }

  async listFiles(spaceId: string, request: ListFilesRequest): Promise<ListFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFilesHeaders({ });
    return await this.listFilesWithOptions(spaceId, request, headers, runtime);
  }

  async listFilesWithOptions(spaceId: string, request: ListFilesRequest, headers: ListFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ListFilesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.orderType)) {
      query["orderType"] = request.orderType;
    }

    if (!Util.isUnset(request.parentId)) {
      query["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.withIcon)) {
      query["withIcon"] = request.withIcon;
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
    return $tea.cast<ListFilesResponse>(await this.doROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files`, "json", req, runtime), new ListFilesResponse({}));
  }

  async listPermissions(spaceId: string, fileId: string, request: ListPermissionsRequest): Promise<ListPermissionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPermissionsHeaders({ });
    return await this.listPermissionsWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async listPermissionsWithOptions(spaceId: string, fileId: string, request: ListPermissionsRequest, headers: ListPermissionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListPermissionsResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
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
    return $tea.cast<ListPermissionsResponse>(await this.doROARequest("ListPermissions", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions`, "json", req, runtime), new ListPermissionsResponse({}));
  }

  async listRecycleFiles(request: ListRecycleFilesRequest): Promise<ListRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRecycleFilesHeaders({ });
    return await this.listRecycleFilesWithOptions(request, headers, runtime);
  }

  async listRecycleFilesWithOptions(request: ListRecycleFilesRequest, headers: ListRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ListRecycleFilesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.orderType)) {
      query["orderType"] = request.orderType;
    }

    if (!Util.isUnset(request.recycleType)) {
      query["recycleType"] = request.recycleType;
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
    return $tea.cast<ListRecycleFilesResponse>(await this.doROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/recycleItems`, "json", req, runtime), new ListRecycleFilesResponse({}));
  }

  async listSpaces(request: ListSpacesRequest): Promise<ListSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSpacesHeaders({ });
    return await this.listSpacesWithOptions(request, headers, runtime);
  }

  async listSpacesWithOptions(request: ListSpacesRequest, headers: ListSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<ListSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.spaceType)) {
      query["spaceType"] = request.spaceType;
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
    return $tea.cast<ListSpacesResponse>(await this.doROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces`, "json", req, runtime), new ListSpacesResponse({}));
  }

  async managementBuyQuota(request: ManagementBuyQuotaRequest): Promise<ManagementBuyQuotaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ManagementBuyQuotaHeaders({ });
    return await this.managementBuyQuotaWithOptions(request, headers, runtime);
  }

  async managementBuyQuotaWithOptions(request: ManagementBuyQuotaRequest, headers: ManagementBuyQuotaHeaders, runtime: $Util.RuntimeOptions): Promise<ManagementBuyQuotaResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.order))) {
      body["order"] = request.order;
    }

    if (!Util.isUnset(request.token)) {
      body["token"] = request.token;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<ManagementBuyQuotaResponse>(await this.doROARequest("ManagementBuyQuota", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/managements/quotas/buy`, "none", req, runtime), new ManagementBuyQuotaResponse({}));
  }

  async managementListSpaces(request: ManagementListSpacesRequest): Promise<ManagementListSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ManagementListSpacesHeaders({ });
    return await this.managementListSpacesWithOptions(request, headers, runtime);
  }

  async managementListSpacesWithOptions(request: ManagementListSpacesRequest, headers: ManagementListSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<ManagementListSpacesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.spaceIds)) {
      body["spaceIds"] = request.spaceIds;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<ManagementListSpacesResponse>(await this.doROARequest("ManagementListSpaces", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/managements/spaces/query`, "json", req, runtime), new ManagementListSpacesResponse({}));
  }

  async managementModifySpace(request: ManagementModifySpaceRequest): Promise<ManagementModifySpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ManagementModifySpaceHeaders({ });
    return await this.managementModifySpaceWithOptions(request, headers, runtime);
  }

  async managementModifySpaceWithOptions(request: ManagementModifySpaceRequest, headers: ManagementModifySpaceHeaders, runtime: $Util.RuntimeOptions): Promise<ManagementModifySpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.quota)) {
      body["quota"] = request.quota;
    }

    if (!Util.isUnset(request.spaceIds)) {
      body["spaceIds"] = request.spaceIds;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<ManagementModifySpaceResponse>(await this.doROARequest("ManagementModifySpace", "drive_1.0", "HTTP", "PUT", "AK", `/v1.0/drive/managements/spaces`, "json", req, runtime), new ManagementModifySpaceResponse({}));
  }

  async modifyPermission(spaceId: string, fileId: string, request: ModifyPermissionRequest): Promise<ModifyPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyPermissionHeaders({ });
    return await this.modifyPermissionWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async modifyPermissionWithOptions(spaceId: string, fileId: string, request: ModifyPermissionRequest, headers: ModifyPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyPermissionResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<ModifyPermissionResponse>(await this.doROARequest("ModifyPermission", "drive_1.0", "HTTP", "PUT", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions`, "none", req, runtime), new ModifyPermissionResponse({}));
  }

  async moveFile(spaceId: string, fileId: string, request: MoveFileRequest): Promise<MoveFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveFileHeaders({ });
    return await this.moveFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async moveFileWithOptions(spaceId: string, fileId: string, request: MoveFileRequest, headers: MoveFileHeaders, runtime: $Util.RuntimeOptions): Promise<MoveFileResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.targetParentId)) {
      body["targetParentId"] = request.targetParentId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<MoveFileResponse>(await this.doROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/move`, "json", req, runtime), new MoveFileResponse({}));
  }

  async moveFiles(spaceId: string, request: MoveFilesRequest): Promise<MoveFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveFilesHeaders({ });
    return await this.moveFilesWithOptions(spaceId, request, headers, runtime);
  }

  async moveFilesWithOptions(spaceId: string, request: MoveFilesRequest, headers: MoveFilesHeaders, runtime: $Util.RuntimeOptions): Promise<MoveFilesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.fileIds)) {
      body["fileIds"] = request.fileIds;
    }

    if (!Util.isUnset(request.targetParentId)) {
      body["targetParentId"] = request.targetParentId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<MoveFilesResponse>(await this.doROARequest("MoveFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/batchMove`, "json", req, runtime), new MoveFilesResponse({}));
  }

  async recoverRecycleFiles(request: RecoverRecycleFilesRequest): Promise<RecoverRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecoverRecycleFilesHeaders({ });
    return await this.recoverRecycleFilesWithOptions(request, headers, runtime);
  }

  async recoverRecycleFilesWithOptions(request: RecoverRecycleFilesRequest, headers: RecoverRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<RecoverRecycleFilesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleItemIdList)) {
      body["recycleItemIdList"] = request.recycleItemIdList;
    }

    if (!Util.isUnset(request.recycleType)) {
      body["recycleType"] = request.recycleType;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<RecoverRecycleFilesResponse>(await this.doROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/recycleItems/recover`, "none", req, runtime), new RecoverRecycleFilesResponse({}));
  }

  async renameFile(spaceId: string, fileId: string, request: RenameFileRequest): Promise<RenameFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenameFileHeaders({ });
    return await this.renameFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async renameFileWithOptions(spaceId: string, fileId: string, request: RenameFileRequest, headers: RenameFileHeaders, runtime: $Util.RuntimeOptions): Promise<RenameFileResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    fileId = OpenApiUtil.getEncodeParam(fileId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.newFileName)) {
      body["newFileName"] = request.newFileName;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<RenameFileResponse>(await this.doROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/rename`, "json", req, runtime), new RenameFileResponse({}));
  }

}
