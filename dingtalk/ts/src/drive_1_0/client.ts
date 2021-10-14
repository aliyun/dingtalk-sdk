// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  parentId?: string;
  fileType?: string;
  fileName?: string;
  mediaId?: string;
  addConflictPolicy?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      parentId: 'parentId',
      fileType: 'fileType',
      fileName: 'fileName',
      mediaId: 'mediaId',
      addConflictPolicy: 'addConflictPolicy',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentId: 'string',
      fileType: 'string',
      fileName: 'string',
      mediaId: 'string',
      addConflictPolicy: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileResponseBody extends $tea.Model {
  spaceId?: string;
  parentId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  contentType?: string;
  fileExtension?: string;
  fileSize?: number;
  createTime?: string;
  modifyTime?: string;
  creator?: string;
  modifier?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      parentId: 'parentId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      contentType: 'contentType',
      fileExtension: 'fileExtension',
      fileSize: 'fileSize',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      creator: 'creator',
      modifier: 'modifier',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      parentId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      contentType: 'string',
      fileExtension: 'string',
      fileSize: 'number',
      createTime: 'string',
      modifyTime: 'string',
      creator: 'string',
      modifier: 'string',
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
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  quota?: number;
  usedQuota?: number;
  permissionMode?: string;
  createTime?: string;
  modifyTime?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
      permissionMode: 'permissionMode',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      quota: 'number',
      usedQuota: 'number',
      permissionMode: 'string',
      createTime: 'string',
      modifyTime: 'string',
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
  role?: string;
  members?: AddPermissionRequestMembers[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      members: 'members',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      members: { 'type': 'array', 'itemType': AddPermissionRequestMembers },
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
  spaceId?: string;
  parentId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  contentType?: string;
  fileExtension?: string;
  fileSize?: number;
  createTime?: string;
  modifyTime?: string;
  creator?: string;
  modifier?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      parentId: 'parentId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      contentType: 'contentType',
      fileExtension: 'fileExtension',
      fileSize: 'fileSize',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      creator: 'creator',
      modifier: 'modifier',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      parentId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      contentType: 'string',
      fileExtension: 'string',
      fileSize: 'number',
      createTime: 'string',
      modifyTime: 'string',
      creator: 'string',
      modifier: 'string',
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
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  quota?: number;
  usedQuota?: number;
  permissionMode?: string;
  createTime?: string;
  modifyTime?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
      permissionMode: 'permissionMode',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      quota: 'number',
      usedQuota: 'number',
      permissionMode: 'string',
      createTime: 'string',
      modifyTime: 'string',
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
  unionId?: string;
  recycleType?: string;
  nextToken?: string;
  maxResults?: number;
  orderType?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      recycleType: 'recycleType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      orderType: 'orderType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      recycleType: 'string',
      nextToken: 'string',
      maxResults: 'number',
      orderType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesResponseBody extends $tea.Model {
  recycleItems?: ListRecycleFilesResponseBodyRecycleItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      recycleItems: 'recycleItems',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItems: { 'type': 'array', 'itemType': ListRecycleFilesResponseBodyRecycleItems },
      nextToken: 'string',
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
  spaceId?: string;
  parentId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  contentType?: string;
  fileExtension?: string;
  fileSize?: number;
  createTime?: string;
  modifyTime?: string;
  creator?: string;
  modifier?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      parentId: 'parentId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      contentType: 'contentType',
      fileExtension: 'fileExtension',
      fileSize: 'fileSize',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      creator: 'creator',
      modifier: 'modifier',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      parentId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      contentType: 'string',
      fileExtension: 'string',
      fileSize: 'number',
      createTime: 'string',
      modifyTime: 'string',
      creator: 'string',
      modifier: 'string',
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
  taskId?: string;
  total?: number;
  success?: number;
  failed?: number;
  status?: string;
  beginTime?: string;
  endTime?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      total: 'total',
      success: 'success',
      failed: 'failed',
      status: 'status',
      beginTime: 'beginTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      total: 'number',
      success: 'number',
      failed: 'number',
      status: 'string',
      beginTime: 'string',
      endTime: 'string',
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
  unionId?: string;
  parentId?: string;
  nextToken?: string;
  maxResults?: number;
  orderType?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      parentId: 'parentId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      orderType: 'orderType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      parentId: 'string',
      nextToken: 'string',
      maxResults: 'number',
      orderType: 'string',
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
  role?: string;
  members?: ModifyPermissionRequestMembers[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      members: 'members',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      members: { 'type': 'array', 'itemType': ModifyPermissionRequestMembers },
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
  type?: string;
  userId?: string;
  fileIds?: string[];
  duration?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      userId: 'userId',
      fileIds: 'fileIds',
      duration: 'duration',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      userId: 'string',
      fileIds: { 'type': 'array', 'itemType': 'string' },
      duration: 'number',
      unionId: 'string',
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
  targetSpaceId?: string;
  targetParentId?: string;
  addConflictPolicy?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      targetSpaceId: 'targetSpaceId',
      targetParentId: 'targetParentId',
      addConflictPolicy: 'addConflictPolicy',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetSpaceId: 'string',
      targetParentId: 'string',
      addConflictPolicy: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileResponseBody extends $tea.Model {
  spaceId?: string;
  parentId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  contentType?: string;
  fileExtension?: string;
  fileSize?: number;
  createTime?: string;
  modifyTime?: string;
  creator?: string;
  modifier?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      parentId: 'parentId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      contentType: 'contentType',
      fileExtension: 'fileExtension',
      fileSize: 'fileSize',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      creator: 'creator',
      modifier: 'modifier',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      parentId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      contentType: 'string',
      fileExtension: 'string',
      fileSize: 'number',
      createTime: 'string',
      modifyTime: 'string',
      creator: 'string',
      modifier: 'string',
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

export class GetDownloadInfoResponseBody extends $tea.Model {
  downloadInfo?: GetDownloadInfoResponseBodyDownloadInfo;
  static names(): { [key: string]: string } {
    return {
      downloadInfo: 'downloadInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadInfo: GetDownloadInfoResponseBodyDownloadInfo,
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
  unionId?: string;
  fileName?: string;
  fileSize?: number;
  md5?: string;
  addConflictPolicy?: string;
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      md5: 'md5',
      addConflictPolicy: 'addConflictPolicy',
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      fileName: 'string',
      fileSize: 'number',
      md5: 'string',
      addConflictPolicy: 'string',
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoResponseBody extends $tea.Model {
  stsUploadInfo?: GetUploadInfoResponseBodyStsUploadInfo;
  static names(): { [key: string]: string } {
    return {
      stsUploadInfo: 'stsUploadInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  unionId?: string;
  spaceType?: string;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      spaceType: 'spaceType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      spaceType: 'string',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesResponseBody extends $tea.Model {
  spaces?: ListSpacesResponseBodySpaces[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      spaces: 'spaces',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaces: { 'type': 'array', 'itemType': ListSpacesResponseBodySpaces },
      nextToken: 'string',
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
  role?: string;
  members?: DeletePermissionRequestMembers[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      members: 'members',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      members: { 'type': 'array', 'itemType': DeletePermissionRequestMembers },
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
  identifier?: string;
  bizType?: string;
  permissionMode?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      identifier: 'identifier',
      bizType: 'bizType',
      permissionMode: 'permissionMode',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      identifier: 'string',
      bizType: 'string',
      permissionMode: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCustomSpaceResponseBody extends $tea.Model {
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  quota?: number;
  usedQuota?: number;
  permissionMode?: string;
  createTime?: string;
  modifyTime?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
      permissionMode: 'permissionMode',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      quota: 'number',
      usedQuota: 'number',
      permissionMode: 'string',
      createTime: 'string',
      modifyTime: 'string',
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
  targetSpaceId?: string;
  targetParentId?: string;
  addConflictPolicy?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      targetSpaceId: 'targetSpaceId',
      targetParentId: 'targetParentId',
      addConflictPolicy: 'addConflictPolicy',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetSpaceId: 'string',
      targetParentId: 'string',
      addConflictPolicy: 'string',
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
  unionId?: string;
  deletePolicy?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      deletePolicy: 'deletePolicy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      deletePolicy: 'string',
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

export class AddPermissionRequestMembers extends $tea.Model {
  corpId?: string;
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecycleFilesResponseBodyRecycleItems extends $tea.Model {
  recycleItemId?: string;
  deleteStaffId?: string;
  deleteTime?: string;
  fileSize?: number;
  fileType?: string;
  contentType?: string;
  fileName?: string;
  filePath?: string;
  static names(): { [key: string]: string } {
    return {
      recycleItemId: 'recycleItemId',
      deleteStaffId: 'deleteStaffId',
      deleteTime: 'deleteTime',
      fileSize: 'fileSize',
      fileType: 'fileType',
      contentType: 'contentType',
      fileName: 'fileName',
      filePath: 'filePath',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItemId: 'string',
      deleteStaffId: 'string',
      deleteTime: 'string',
      fileSize: 'number',
      fileType: 'string',
      contentType: 'string',
      fileName: 'string',
      filePath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFilesResponseBodyFiles extends $tea.Model {
  spaceId?: string;
  parentId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  contentType?: string;
  fileExtension?: string;
  fileSize?: number;
  createTime?: string;
  modifyTime?: string;
  creator?: string;
  modifier?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      parentId: 'parentId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      contentType: 'contentType',
      fileExtension: 'fileExtension',
      fileSize: 'fileSize',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      creator: 'creator',
      modifier: 'modifier',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      parentId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      contentType: 'string',
      fileExtension: 'string',
      fileSize: 'number',
      createTime: 'string',
      modifyTime: 'string',
      creator: 'string',
      modifier: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyPermissionRequestMembers extends $tea.Model {
  corpId?: string;
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyMembersMember extends $tea.Model {
  corpId?: string;
  memberType?: string;
  memberId?: string;
  memberName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberType: 'memberType',
      memberId: 'memberId',
      memberName: 'memberName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberType: 'string',
      memberId: 'string',
      memberName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyMembers extends $tea.Model {
  role?: string;
  member?: ListPermissionsResponseBodyMembersMember;
  extend?: boolean;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      member: 'member',
      extend: 'extend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      member: ListPermissionsResponseBodyMembersMember,
      extend: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyOutMembersMember extends $tea.Model {
  corpId?: string;
  memberType?: string;
  memberId?: string;
  memberName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberType: 'memberType',
      memberId: 'memberId',
      memberName: 'memberName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberType: 'string',
      memberId: 'string',
      memberName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPermissionsResponseBodyOutMembers extends $tea.Model {
  role?: string;
  member?: ListPermissionsResponseBodyOutMembersMember;
  extend?: boolean;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      member: 'member',
      extend: 'extend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      member: ListPermissionsResponseBodyOutMembersMember,
      extend: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponseBodyDownloadInfo extends $tea.Model {
  resourceUrl?: string;
  expirationSeconds?: number;
  headers?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      resourceUrl: 'resourceUrl',
      expirationSeconds: 'expirationSeconds',
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resourceUrl: 'string',
      expirationSeconds: 'number',
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadInfoResponseBodyStsUploadInfo extends $tea.Model {
  bucket?: string;
  endPoint?: string;
  accessKeyId?: string;
  accessKeySecret?: string;
  accessToken?: string;
  accessTokenExpirationMillis?: number;
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      bucket: 'bucket',
      endPoint: 'endPoint',
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      accessToken: 'accessToken',
      accessTokenExpirationMillis: 'accessTokenExpirationMillis',
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bucket: 'string',
      endPoint: 'string',
      accessKeyId: 'string',
      accessKeySecret: 'string',
      accessToken: 'string',
      accessTokenExpirationMillis: 'number',
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpacesResponseBodySpaces extends $tea.Model {
  spaceId?: string;
  spaceName?: string;
  spaceType?: string;
  quota?: number;
  usedQuota?: number;
  permissionMode?: string;
  createTime?: string;
  modifyTime?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
      permissionMode: 'permissionMode',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceName: 'string',
      spaceType: 'string',
      quota: 'number',
      usedQuota: 'number',
      permissionMode: 'string',
      createTime: 'string',
      modifyTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionRequestMembers extends $tea.Model {
  corpId?: string;
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileResponseBodyFile extends $tea.Model {
  spaceId?: string;
  parentId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  contentType?: string;
  fileExtension?: string;
  fileSize?: number;
  createTime?: string;
  modifyTime?: string;
  creator?: string;
  modifier?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      parentId: 'parentId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      contentType: 'contentType',
      fileExtension: 'fileExtension',
      fileSize: 'fileSize',
      createTime: 'createTime',
      modifyTime: 'modifyTime',
      creator: 'creator',
      modifier: 'modifier',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      parentId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      contentType: 'string',
      fileExtension: 'string',
      fileSize: 'number',
      createTime: 'string',
      modifyTime: 'string',
      creator: 'string',
      modifier: 'string',
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


  async addFile(spaceId: string, request: AddFileRequest): Promise<AddFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFileHeaders({ });
    return await this.addFileWithOptions(spaceId, request, headers, runtime);
  }

  async addFileWithOptions(spaceId: string, request: AddFileRequest, headers: AddFileHeaders, runtime: $Util.RuntimeOptions): Promise<AddFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.fileType)) {
      body["fileType"] = request.fileType;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<AddFileResponse>(await this.doROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files`, "json", req, runtime), new AddFileResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RecoverRecycleFilesResponse>(await this.doROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/recycleItems/recover`, "none", req, runtime), new RecoverRecycleFilesResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AddSpaceResponse>(await this.doROARequest("AddSpace", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces`, "json", req, runtime), new AddSpaceResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<DeleteRecycleFilesResponse>(await this.doROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/recycleItems/delete`, "none", req, runtime), new DeleteRecycleFilesResponse({}));
  }

  async addPermission(spaceId: string, fileId: string, request: AddPermissionRequest): Promise<AddPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPermissionHeaders({ });
    return await this.addPermissionWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async addPermissionWithOptions(spaceId: string, fileId: string, request: AddPermissionRequest, headers: AddPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<AddPermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<AddPermissionResponse>(await this.doROARequest("AddPermission", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions`, "none", req, runtime), new AddPermissionResponse({}));
  }

  async getFileInfo(spaceId: string, fileId: string, request: GetFileInfoRequest): Promise<GetFileInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileInfoHeaders({ });
    return await this.getFileInfoWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async getFileInfoWithOptions(spaceId: string, fileId: string, request: GetFileInfoRequest, headers: GetFileInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileInfoResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetFileInfoResponse>(await this.doROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}`, "json", req, runtime), new GetFileInfoResponse({}));
  }

  async infoSpace(spaceId: string, request: InfoSpaceRequest): Promise<InfoSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InfoSpaceHeaders({ });
    return await this.infoSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async infoSpaceWithOptions(spaceId: string, request: InfoSpaceRequest, headers: InfoSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<InfoSpaceResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<InfoSpaceResponse>(await this.doROARequest("InfoSpace", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}`, "json", req, runtime), new InfoSpaceResponse({}));
  }

  async listRecycleFiles(request: ListRecycleFilesRequest): Promise<ListRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRecycleFilesHeaders({ });
    return await this.listRecycleFilesWithOptions(request, headers, runtime);
  }

  async listRecycleFilesWithOptions(request: ListRecycleFilesRequest, headers: ListRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ListRecycleFilesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.recycleType)) {
      query["recycleType"] = request.recycleType;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.orderType)) {
      query["orderType"] = request.orderType;
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
    return $tea.cast<ListRecycleFilesResponse>(await this.doROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/recycleItems`, "json", req, runtime), new ListRecycleFilesResponse({}));
  }

  async renameFile(spaceId: string, fileId: string, request: RenameFileRequest): Promise<RenameFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenameFileHeaders({ });
    return await this.renameFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async renameFileWithOptions(spaceId: string, fileId: string, request: RenameFileRequest, headers: RenameFileHeaders, runtime: $Util.RuntimeOptions): Promise<RenameFileResponse> {
    Util.validateModel(request);
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RenameFileResponse>(await this.doROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/rename`, "json", req, runtime), new RenameFileResponse({}));
  }

  async getAsyncTaskInfo(taskId: string, request: GetAsyncTaskInfoRequest): Promise<GetAsyncTaskInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAsyncTaskInfoHeaders({ });
    return await this.getAsyncTaskInfoWithOptions(taskId, request, headers, runtime);
  }

  async getAsyncTaskInfoWithOptions(taskId: string, request: GetAsyncTaskInfoRequest, headers: GetAsyncTaskInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetAsyncTaskInfoResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetAsyncTaskInfoResponse>(await this.doROARequest("GetAsyncTaskInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/tasks/${taskId}`, "json", req, runtime), new GetAsyncTaskInfoResponse({}));
  }

  async listFiles(spaceId: string, request: ListFilesRequest): Promise<ListFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFilesHeaders({ });
    return await this.listFilesWithOptions(spaceId, request, headers, runtime);
  }

  async listFilesWithOptions(spaceId: string, request: ListFilesRequest, headers: ListFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ListFilesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.parentId)) {
      query["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.orderType)) {
      query["orderType"] = request.orderType;
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
    return $tea.cast<ListFilesResponse>(await this.doROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files`, "json", req, runtime), new ListFilesResponse({}));
  }

  async modifyPermission(spaceId: string, fileId: string, request: ModifyPermissionRequest): Promise<ModifyPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyPermissionHeaders({ });
    return await this.modifyPermissionWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async modifyPermissionWithOptions(spaceId: string, fileId: string, request: ModifyPermissionRequest, headers: ModifyPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyPermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<ModifyPermissionResponse>(await this.doROARequest("ModifyPermission", "drive_1.0", "HTTP", "PUT", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions`, "none", req, runtime), new ModifyPermissionResponse({}));
  }

  async listPermissions(spaceId: string, fileId: string, request: ListPermissionsRequest): Promise<ListPermissionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPermissionsHeaders({ });
    return await this.listPermissionsWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async listPermissionsWithOptions(spaceId: string, fileId: string, request: ListPermissionsRequest, headers: ListPermissionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListPermissionsResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListPermissionsResponse>(await this.doROARequest("ListPermissions", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions`, "json", req, runtime), new ListPermissionsResponse({}));
  }

  async grantPrivilegeOfCustomSpace(spaceId: string, request: GrantPrivilegeOfCustomSpaceRequest): Promise<GrantPrivilegeOfCustomSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantPrivilegeOfCustomSpaceHeaders({ });
    return await this.grantPrivilegeOfCustomSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async grantPrivilegeOfCustomSpaceWithOptions(spaceId: string, request: GrantPrivilegeOfCustomSpaceRequest, headers: GrantPrivilegeOfCustomSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GrantPrivilegeOfCustomSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.fileIds)) {
      body["fileIds"] = request.fileIds;
    }

    if (!Util.isUnset(request.duration)) {
      body["duration"] = request.duration;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<GrantPrivilegeOfCustomSpaceResponse>(await this.doROARequest("GrantPrivilegeOfCustomSpace", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/customSpacePrivileges`, "none", req, runtime), new GrantPrivilegeOfCustomSpaceResponse({}));
  }

  async moveFile(spaceId: string, fileId: string, request: MoveFileRequest): Promise<MoveFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveFileHeaders({ });
    return await this.moveFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async moveFileWithOptions(spaceId: string, fileId: string, request: MoveFileRequest, headers: MoveFileHeaders, runtime: $Util.RuntimeOptions): Promise<MoveFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.targetParentId)) {
      body["targetParentId"] = request.targetParentId;
    }

    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<MoveFileResponse>(await this.doROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/move`, "json", req, runtime), new MoveFileResponse({}));
  }

  async getDownloadInfo(spaceId: string, fileId: string, request: GetDownloadInfoRequest): Promise<GetDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDownloadInfoHeaders({ });
    return await this.getDownloadInfoWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async getDownloadInfoWithOptions(spaceId: string, fileId: string, request: GetDownloadInfoRequest, headers: GetDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDownloadInfoResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetDownloadInfoResponse>(await this.doROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/downloadInfos`, "json", req, runtime), new GetDownloadInfoResponse({}));
  }

  async getUploadInfo(spaceId: string, parentId: string, request: GetUploadInfoRequest): Promise<GetUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadInfoHeaders({ });
    return await this.getUploadInfoWithOptions(spaceId, parentId, request, headers, runtime);
  }

  async getUploadInfoWithOptions(spaceId: string, parentId: string, request: GetUploadInfoRequest, headers: GetUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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

    if (!Util.isUnset(request.addConflictPolicy)) {
      query["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
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
    return $tea.cast<GetUploadInfoResponse>(await this.doROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces/${spaceId}/files/${parentId}/uploadInfos`, "json", req, runtime), new GetUploadInfoResponse({}));
  }

  async listSpaces(request: ListSpacesRequest): Promise<ListSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSpacesHeaders({ });
    return await this.listSpacesWithOptions(request, headers, runtime);
  }

  async listSpacesWithOptions(request: ListSpacesRequest, headers: ListSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<ListSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.spaceType)) {
      query["spaceType"] = request.spaceType;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<ListSpacesResponse>(await this.doROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/spaces`, "json", req, runtime), new ListSpacesResponse({}));
  }

  async deletePermission(spaceId: string, fileId: string, request: DeletePermissionRequest): Promise<DeletePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePermissionHeaders({ });
    return await this.deletePermissionWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async deletePermissionWithOptions(spaceId: string, fileId: string, request: DeletePermissionRequest, headers: DeletePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<DeletePermissionResponse>(await this.doROARequest("DeletePermission", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/permissions/delete`, "none", req, runtime), new DeletePermissionResponse({}));
  }

  async addCustomSpace(request: AddCustomSpaceRequest): Promise<AddCustomSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCustomSpaceHeaders({ });
    return await this.addCustomSpaceWithOptions(request, headers, runtime);
  }

  async addCustomSpaceWithOptions(request: AddCustomSpaceRequest, headers: AddCustomSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AddCustomSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.identifier)) {
      body["identifier"] = request.identifier;
    }

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AddCustomSpaceResponse>(await this.doROARequest("AddCustomSpace", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/customSpaces`, "json", req, runtime), new AddCustomSpaceResponse({}));
  }

  async copyFile(spaceId: string, fileId: string, request: CopyFileRequest): Promise<CopyFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyFileHeaders({ });
    return await this.copyFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async copyFileWithOptions(spaceId: string, fileId: string, request: CopyFileRequest, headers: CopyFileHeaders, runtime: $Util.RuntimeOptions): Promise<CopyFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.targetParentId)) {
      body["targetParentId"] = request.targetParentId;
    }

    if (!Util.isUnset(request.addConflictPolicy)) {
      body["addConflictPolicy"] = request.addConflictPolicy;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
    return $tea.cast<CopyFileResponse>(await this.doROARequest("CopyFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}/copy`, "json", req, runtime), new CopyFileResponse({}));
  }

  async deleteSpace(spaceId: string, request: DeleteSpaceRequest): Promise<DeleteSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSpaceHeaders({ });
    return await this.deleteSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async deleteSpaceWithOptions(spaceId: string, request: DeleteSpaceRequest, headers: DeleteSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSpaceResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<DeleteSpaceResponse>(await this.doROARequest("DeleteSpace", "drive_1.0", "HTTP", "DELETE", "AK", `/v1.0/drive/spaces/${spaceId}`, "none", req, runtime), new DeleteSpaceResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ClearRecycleFilesResponse>(await this.doROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/recycleItems/clear`, "none", req, runtime), new ClearRecycleFilesResponse({}));
  }

  async deleteFile(spaceId: string, fileId: string, request: DeleteFileRequest): Promise<DeleteFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFileHeaders({ });
    return await this.deleteFileWithOptions(spaceId, fileId, request, headers, runtime);
  }

  async deleteFileWithOptions(spaceId: string, fileId: string, request: DeleteFileRequest, headers: DeleteFileHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.deletePolicy)) {
      query["deletePolicy"] = request.deletePolicy;
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
    return $tea.cast<DeleteFileResponse>(await this.doROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", `/v1.0/drive/spaces/${spaceId}/files/${fileId}`, "json", req, runtime), new DeleteFileResponse({}));
  }

}
