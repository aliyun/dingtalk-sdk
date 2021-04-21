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
  static names(): { [key: string]: string } {
    return {
      parentId: 'parentId',
      fileType: 'fileType',
      fileName: 'fileName',
      mediaId: 'mediaId',
      addConflictPolicy: 'addConflictPolicy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentId: 'string',
      fileType: 'string',
      fileName: 'string',
      mediaId: 'string',
      addConflictPolicy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileResponseBody extends $tea.Model {
  spaceId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  fileExtension?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      fileExtension: 'fileExtension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      fileExtension: 'string',
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
  static names(): { [key: string]: string } {
    return {
      recycleItemIdList: 'recycleItemIdList',
      recycleType: 'recycleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItemIdList: { 'type': 'array', 'itemType': 'number' },
      recycleType: 'string',
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
  static names(): { [key: string]: string } {
    return {
      recycleItemIdList: 'recycleItemIdList',
      recycleType: 'recycleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleItemIdList: { 'type': 'array', 'itemType': 'number' },
      recycleType: 'string',
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

export class GetFileInfoResponseBody extends $tea.Model {
  spaceId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  fileExtension?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      fileExtension: 'fileExtension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      fileExtension: 'string',
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
  recycleType?: string;
  nextToken?: string;
  maxResults?: number;
  orderType?: string;
  static names(): { [key: string]: string } {
    return {
      recycleType: 'recycleType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      orderType: 'orderType',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  static names(): { [key: string]: string } {
    return {
      newFileName: 'newFileName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newFileName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameFileResponseBody extends $tea.Model {
  spaceId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  fileExtension?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      fileExtension: 'fileExtension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      fileExtension: 'string',
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
  parentId?: string;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      parentId: 'parentId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentId: 'string',
      nextToken: 'string',
      maxResults: 'number',
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
  static names(): { [key: string]: string } {
    return {
      targetSpaceId: 'targetSpaceId',
      targetParentId: 'targetParentId',
      addConflictPolicy: 'addConflictPolicy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetSpaceId: 'string',
      targetParentId: 'string',
      addConflictPolicy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileResponseBody extends $tea.Model {
  spaceId?: string;
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  fileExtension?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      fileExtension: 'fileExtension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      fileExtension: 'string',
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
  fileName?: string;
  fileSize?: number;
  md5?: string;
  addConflictPolicy?: string;
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileSize: 'fileSize',
      md5: 'md5',
      addConflictPolicy: 'addConflictPolicy',
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  spaceType?: string;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  static names(): { [key: string]: string } {
    return {
      recycleType: 'recycleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recycleType: 'string',
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
  deletePolicy?: string;
  static names(): { [key: string]: string } {
    return {
      deletePolicy: 'deletePolicy',
    };
  }

  static types(): { [key: string]: any } {
    return {
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

export class ListRecycleFilesResponseBodyRecycleItems extends $tea.Model {
  recycleItemId?: string;
  deleteUid?: number;
  deleteTime?: string;
  fileSize?: number;
  fileType?: string;
  contentType?: string;
  fileName?: string;
  filePath?: string;
  static names(): { [key: string]: string } {
    return {
      recycleItemId: 'recycleItemId',
      deleteUid: 'deleteUid',
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
      deleteUid: 'number',
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
  fileId?: string;
  fileName?: string;
  filePath?: string;
  fileType?: string;
  fileExtension?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      fileId: 'fileId',
      fileName: 'fileName',
      filePath: 'filePath',
      fileType: 'fileType',
      fileExtension: 'fileExtension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      fileType: 'string',
      fileExtension: 'string',
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
  createTime?: string;
  modifyTime?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceName: 'spaceName',
      spaceType: 'spaceType',
      quota: 'quota',
      usedQuota: 'usedQuota',
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
      createTime: 'string',
      modifyTime: 'string',
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


  async addFile(unionId: string, spaceId: string, request: AddFileRequest): Promise<AddFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFileHeaders({ });
    return await this.addFileWithOptions(unionId, spaceId, request, headers, runtime);
  }

  async addFileWithOptions(unionId: string, spaceId: string, request: AddFileRequest, headers: AddFileHeaders, runtime: $Util.RuntimeOptions): Promise<AddFileResponse> {
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
    return $tea.cast<AddFileResponse>(await this.doROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files`, "json", req, runtime), new AddFileResponse({}));
  }

  async recoverRecycleFiles(unionId: string, request: RecoverRecycleFilesRequest): Promise<RecoverRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecoverRecycleFilesHeaders({ });
    return await this.recoverRecycleFilesWithOptions(unionId, request, headers, runtime);
  }

  async recoverRecycleFilesWithOptions(unionId: string, request: RecoverRecycleFilesRequest, headers: RecoverRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<RecoverRecycleFilesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleItemIdList)) {
      body["recycleItemIdList"] = request.recycleItemIdList;
    }

    if (!Util.isUnset(request.recycleType)) {
      body["recycleType"] = request.recycleType;
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
    return $tea.cast<RecoverRecycleFilesResponse>(await this.doROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/users/${unionId}/recycleItems/recover`, "none", req, runtime), new RecoverRecycleFilesResponse({}));
  }

  async deleteRecycleFiles(unionId: string, request: DeleteRecycleFilesRequest): Promise<DeleteRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecycleFilesHeaders({ });
    return await this.deleteRecycleFilesWithOptions(unionId, request, headers, runtime);
  }

  async deleteRecycleFilesWithOptions(unionId: string, request: DeleteRecycleFilesRequest, headers: DeleteRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecycleFilesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleItemIdList)) {
      body["recycleItemIdList"] = request.recycleItemIdList;
    }

    if (!Util.isUnset(request.recycleType)) {
      body["recycleType"] = request.recycleType;
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
    return $tea.cast<DeleteRecycleFilesResponse>(await this.doROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/users/${unionId}/recycleItems/delete`, "none", req, runtime), new DeleteRecycleFilesResponse({}));
  }

  async getFileInfo(unionId: string, spaceId: string, fileId: string): Promise<GetFileInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileInfoHeaders({ });
    return await this.getFileInfoWithOptions(unionId, spaceId, fileId, headers, runtime);
  }

  async getFileInfoWithOptions(unionId: string, spaceId: string, fileId: string, headers: GetFileInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileInfoResponse> {
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
    return $tea.cast<GetFileInfoResponse>(await this.doROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files/${fileId}`, "json", req, runtime), new GetFileInfoResponse({}));
  }

  async listRecycleFiles(unionId: string, request: ListRecycleFilesRequest): Promise<ListRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRecycleFilesHeaders({ });
    return await this.listRecycleFilesWithOptions(unionId, request, headers, runtime);
  }

  async listRecycleFilesWithOptions(unionId: string, request: ListRecycleFilesRequest, headers: ListRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ListRecycleFilesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<ListRecycleFilesResponse>(await this.doROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${unionId}/recycleItems`, "json", req, runtime), new ListRecycleFilesResponse({}));
  }

  async renameFile(unionId: string, spaceId: string, fileId: string, request: RenameFileRequest): Promise<RenameFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenameFileHeaders({ });
    return await this.renameFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
  }

  async renameFileWithOptions(unionId: string, spaceId: string, fileId: string, request: RenameFileRequest, headers: RenameFileHeaders, runtime: $Util.RuntimeOptions): Promise<RenameFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.newFileName)) {
      body["newFileName"] = request.newFileName;
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
    return $tea.cast<RenameFileResponse>(await this.doROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files/${fileId}/rename`, "json", req, runtime), new RenameFileResponse({}));
  }

  async listFiles(unionId: string, spaceId: string, request: ListFilesRequest): Promise<ListFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFilesHeaders({ });
    return await this.listFilesWithOptions(unionId, spaceId, request, headers, runtime);
  }

  async listFilesWithOptions(unionId: string, spaceId: string, request: ListFilesRequest, headers: ListFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ListFilesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.parentId)) {
      query["parentId"] = request.parentId;
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
    return $tea.cast<ListFilesResponse>(await this.doROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files`, "json", req, runtime), new ListFilesResponse({}));
  }

  async moveFile(unionId: string, spaceId: string, fileId: string, request: MoveFileRequest): Promise<MoveFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveFileHeaders({ });
    return await this.moveFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
  }

  async moveFileWithOptions(unionId: string, spaceId: string, fileId: string, request: MoveFileRequest, headers: MoveFileHeaders, runtime: $Util.RuntimeOptions): Promise<MoveFileResponse> {
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
    return $tea.cast<MoveFileResponse>(await this.doROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files/${fileId}/move`, "json", req, runtime), new MoveFileResponse({}));
  }

  async getDownloadInfo(unionId: string, spaceId: string, fileId: string): Promise<GetDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDownloadInfoHeaders({ });
    return await this.getDownloadInfoWithOptions(unionId, spaceId, fileId, headers, runtime);
  }

  async getDownloadInfoWithOptions(unionId: string, spaceId: string, fileId: string, headers: GetDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDownloadInfoResponse> {
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
    return $tea.cast<GetDownloadInfoResponse>(await this.doROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files/${fileId}/downloadInfos`, "json", req, runtime), new GetDownloadInfoResponse({}));
  }

  async getUploadInfo(unionId: string, spaceId: string, parentId: string, request: GetUploadInfoRequest): Promise<GetUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadInfoHeaders({ });
    return await this.getUploadInfoWithOptions(unionId, spaceId, parentId, request, headers, runtime);
  }

  async getUploadInfoWithOptions(unionId: string, spaceId: string, parentId: string, request: GetUploadInfoRequest, headers: GetUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<GetUploadInfoResponse>(await this.doROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files/${parentId}/uploadInfos`, "json", req, runtime), new GetUploadInfoResponse({}));
  }

  async listSpaces(unionId: string, request: ListSpacesRequest): Promise<ListSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSpacesHeaders({ });
    return await this.listSpacesWithOptions(unionId, request, headers, runtime);
  }

  async listSpacesWithOptions(unionId: string, request: ListSpacesRequest, headers: ListSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<ListSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<ListSpacesResponse>(await this.doROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${unionId}/spaces`, "json", req, runtime), new ListSpacesResponse({}));
  }

  async clearRecycleFiles(unionId: string, request: ClearRecycleFilesRequest): Promise<ClearRecycleFilesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearRecycleFilesHeaders({ });
    return await this.clearRecycleFilesWithOptions(unionId, request, headers, runtime);
  }

  async clearRecycleFilesWithOptions(unionId: string, request: ClearRecycleFilesRequest, headers: ClearRecycleFilesHeaders, runtime: $Util.RuntimeOptions): Promise<ClearRecycleFilesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recycleType)) {
      body["recycleType"] = request.recycleType;
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
    return $tea.cast<ClearRecycleFilesResponse>(await this.doROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", `/v1.0/drive/users/${unionId}/recycleItems/clear`, "none", req, runtime), new ClearRecycleFilesResponse({}));
  }

  async deleteFile(unionId: string, spaceId: string, fileId: string, request: DeleteFileRequest): Promise<DeleteFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFileHeaders({ });
    return await this.deleteFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
  }

  async deleteFileWithOptions(unionId: string, spaceId: string, fileId: string, request: DeleteFileRequest, headers: DeleteFileHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<DeleteFileResponse>(await this.doROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", `/v1.0/drive/users/${unionId}/spaces/${spaceId}/files/${fileId}`, "json", req, runtime), new DeleteFileResponse({}));
  }

}
