// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  name?: string;
  option?: AddFolderRequestOption;
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
  headers: { [key: string]: string };
  body: AddFolderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddFolderResponseBody,
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
  headers: { [key: string]: string };
  body: ClearRecycleBinResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  name?: string;
  option?: CommitFileRequestOption;
  parentId?: string;
  size?: number;
  uploadKey?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      option: 'option',
      parentId: 'parentId',
      size: 'size',
      uploadKey: 'uploadKey',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      option: CommitFileRequestOption,
      parentId: 'string',
      size: 'number',
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
  body: CommitFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CommitFileResponseBody,
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
  targetFolderId?: string;
  targetSpaceId?: string;
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
  async?: boolean;
  dentry?: CopyDentryResponseBodyDentry;
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
  headers: { [key: string]: string };
  body: CopyDentryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CopyDentryResponseBody,
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
  toRecycleBin?: boolean;
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
  async?: boolean;
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
  headers: { [key: string]: string };
  body: DeleteDentryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  propertyNames?: string[];
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
  headers: { [key: string]: string };
  body: DeleteDentryAppPropertiesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteDentryAppPropertiesResponseBody,
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
  headers: { [key: string]: string };
  body: DeleteRecycleItemResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  recycleItemIds?: string[];
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
  headers: { [key: string]: string };
  body: DeleteRecycleItemsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: GetCurrentAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCurrentAppResponseBody,
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
  headers: { [key: string]: string };
  body: GetDentryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDentryResponseBody,
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
  headers: { [key: string]: string };
  body: GetFileDownloadInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  multipart?: boolean;
  option?: GetFileUploadInfoRequestOption;
  protocol?: string;
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
  body: GetFileUploadInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFileUploadInfoResponseBody,
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
  recycleBinScope?: string;
  scopeId?: string;
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
  headers: { [key: string]: string };
  body: GetRecycleBinResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: GetRecycleItemResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: GetSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSpaceResponseBody,
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
  maxResults?: number;
  nextToken?: string;
  order?: string;
  orderBy?: string;
  parentId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
      orderBy: 'orderBy',
      parentId: 'parentId',
      unionId: 'unionId',
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
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBody extends $tea.Model {
  dentries?: ListDentriesResponseBodyDentries[];
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
  headers: { [key: string]: string };
  body: ListDentriesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  maxResults?: number;
  nextToken?: string;
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
  headers: { [key: string]: string };
  body: ListDentryVersionsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDentryVersionsResponseBody,
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
  maxResults?: number;
  nextToken?: string;
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
  headers: { [key: string]: string };
  body: ListRecycleItemsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListRecycleItemsResponseBody,
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
  targetFolderId?: string;
  targetSpaceId?: string;
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
  async?: boolean;
  dentry?: MoveDentryResponseBodyDentry;
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
  headers: { [key: string]: string };
  body: MoveDentryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MoveDentryResponseBody,
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
  newName?: string;
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
  headers: { [key: string]: string };
  body: RenameDentryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class RestoreRecycleItemResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RestoreRecycleItemResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RestoreRecycleItemResponseBody,
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
  headers: { [key: string]: string };
  body: RevertDentryVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RevertDentryVersionResponseBody,
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
  appProperties?: UpdateDentryAppPropertiesRequestAppProperties[];
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
  headers: { [key: string]: string };
  body: UpdateDentryAppPropertiesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateDentryAppPropertiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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

export class DentriesAppPropertiesValue extends $tea.Model {
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

export class AddFolderRequestOptionAppProperties extends $tea.Model {
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

export class AddFolderRequestOption extends $tea.Model {
  appProperties?: AddFolderRequestOptionAppProperties[];
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
  properties?: AddFolderResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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

export class AddSpaceRequestOptionCapabilities extends $tea.Model {
  canRecordRecentFile?: boolean;
  canRename?: boolean;
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
  name?: string;
  ownerType?: string;
  quota?: number;
  scene?: string;
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
  canRecordRecentFile?: boolean;
  canRename?: boolean;
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

export class AddSpaceResponseBodySpace extends $tea.Model {
  appId?: string;
  capabilities?: AddSpaceResponseBodySpaceCapabilities;
  corpId?: string;
  createTime?: string;
  creatorId?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  ownerId?: string;
  ownerType?: string;
  quota?: number;
  scene?: string;
  sceneId?: string;
  status?: string;
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
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      conflictStrategy: 'conflictStrategy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'array', 'itemType': CommitFileRequestOptionAppProperties },
      conflictStrategy: 'string',
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

export class CommitFileResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
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
  type?: string;
  uuid?: string;
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

export class CopyDentryRequestOption extends $tea.Model {
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
  properties?: CopyDentryResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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

export class GetCurrentAppResponseBodyAppPartitionsQuota extends $tea.Model {
  max?: number;
  type?: string;
  used?: number;
  static names(): { [key: string]: string } {
    return {
      max: 'max',
      type: 'type',
      used: 'used',
    };
  }

  static types(): { [key: string]: any } {
    return {
      max: 'number',
      type: 'string',
      used: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCurrentAppResponseBodyAppPartitions extends $tea.Model {
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
  appId?: string;
  corpId?: string;
  createTime?: string;
  modifiedTime?: string;
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

export class GetDentryRequestOption extends $tea.Model {
  appIdsForAppProperties?: string[];
  static names(): { [key: string]: string } {
    return {
      appIdsForAppProperties: 'appIdsForAppProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appIdsForAppProperties: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBodyDentryProperties extends $tea.Model {
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

export class GetDentryResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
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
  properties?: GetDentryResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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
      properties: GetDentryResponseBodyDentryProperties,
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

export class GetFileDownloadInfoRequestOption extends $tea.Model {
  version?: number;
  static names(): { [key: string]: string } {
    return {
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponseBodyHeaderSignatureInfo extends $tea.Model {
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

export class GetFileUploadInfoRequestOptionPreCheckParam extends $tea.Model {
  md5?: string;
  name?: string;
  parentId?: string;
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
  preferRegion?: string;
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
      preCheckParam: GetFileUploadInfoRequestOptionPreCheckParam,
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

export class GetRecycleBinResponseBodyRecycleBin extends $tea.Model {
  id?: string;
  scope?: string;
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
  appId?: string;
  dentryId?: string;
  id?: string;
  operatorId?: string;
  operatorTime?: string;
  originalName?: string;
  originalPath?: string;
  size?: number;
  spaceId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
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
      appId: 'string',
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
  canRecordRecentFile?: boolean;
  canRename?: boolean;
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

export class GetSpaceResponseBodySpace extends $tea.Model {
  appId?: string;
  capabilities?: GetSpaceResponseBodySpaceCapabilities;
  corpId?: string;
  createTime?: string;
  creatorId?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  ownerId?: string;
  ownerType?: string;
  quota?: number;
  scene?: string;
  sceneId?: string;
  status?: string;
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

export class ListDentriesResponseBodyDentriesProperties extends $tea.Model {
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

export class ListDentriesResponseBodyDentries extends $tea.Model {
  appProperties?: { [key: string]: DentriesAppPropertiesValue[] };
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
  properties?: ListDentriesResponseBodyDentriesProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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
      properties: ListDentriesResponseBodyDentriesProperties,
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

export class ListDentryVersionsResponseBodyDentriesProperties extends $tea.Model {
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
  properties?: ListDentryVersionsResponseBodyDentriesProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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

export class ListRecycleItemsResponseBodyRecycleItems extends $tea.Model {
  appId?: string;
  dentryId?: string;
  id?: string;
  operatorId?: string;
  operatorTime?: string;
  originalName?: string;
  originalPath?: string;
  size?: number;
  spaceId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
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
      appId: 'string',
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

export class MoveDentryRequestOption extends $tea.Model {
  conflictStrategy?: string;
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
  properties?: MoveDentryResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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

export class RenameDentryResponseBodyDentryProperties extends $tea.Model {
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
  properties?: RenameDentryResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  type?: string;
  uuid?: string;
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

export class UpdateDentryAppPropertiesRequestAppProperties extends $tea.Model {
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async addFolder(spaceId: string, parentId: string, request: AddFolderRequest): Promise<AddFolderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFolderHeaders({ });
    return await this.addFolderWithOptions(spaceId, parentId, request, headers, runtime);
  }

  async addFolderWithOptions(spaceId: string, parentId: string, request: AddFolderRequest, headers: AddFolderHeaders, runtime: $Util.RuntimeOptions): Promise<AddFolderResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    parentId = OpenApiUtil.getEncodeParam(parentId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<AddFolderResponse>(await this.doROARequest("AddFolder", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${parentId}/folders`, "json", req, runtime), new AddFolderResponse({}));
  }

  async addSpace(request: AddSpaceRequest): Promise<AddSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddSpaceHeaders({ });
    return await this.addSpaceWithOptions(request, headers, runtime);
  }

  async addSpaceWithOptions(request: AddSpaceRequest, headers: AddSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AddSpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<AddSpaceResponse>(await this.doROARequest("AddSpace", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces`, "json", req, runtime), new AddSpaceResponse({}));
  }

  async clearRecycleBin(recycleBinId: string, request: ClearRecycleBinRequest): Promise<ClearRecycleBinResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearRecycleBinHeaders({ });
    return await this.clearRecycleBinWithOptions(recycleBinId, request, headers, runtime);
  }

  async clearRecycleBinWithOptions(recycleBinId: string, request: ClearRecycleBinRequest, headers: ClearRecycleBinHeaders, runtime: $Util.RuntimeOptions): Promise<ClearRecycleBinResponse> {
    Util.validateModel(request);
    recycleBinId = OpenApiUtil.getEncodeParam(recycleBinId);
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
    return $tea.cast<ClearRecycleBinResponse>(await this.doROARequest("ClearRecycleBin", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/recycleBins/${recycleBinId}/clear`, "json", req, runtime), new ClearRecycleBinResponse({}));
  }

  async commitFile(spaceId: string, request: CommitFileRequest): Promise<CommitFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CommitFileHeaders({ });
    return await this.commitFileWithOptions(spaceId, request, headers, runtime);
  }

  async commitFileWithOptions(spaceId: string, request: CommitFileRequest, headers: CommitFileHeaders, runtime: $Util.RuntimeOptions): Promise<CommitFileResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset($tea.toMap(request.option))) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.size)) {
      body["size"] = request.size;
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
    return $tea.cast<CommitFileResponse>(await this.doROARequest("CommitFile", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/files/commit`, "json", req, runtime), new CommitFileResponse({}));
  }

  async copyDentry(spaceId: string, dentryId: string, request: CopyDentryRequest): Promise<CopyDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyDentryHeaders({ });
    return await this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async copyDentryWithOptions(spaceId: string, dentryId: string, request: CopyDentryRequest, headers: CopyDentryHeaders, runtime: $Util.RuntimeOptions): Promise<CopyDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<CopyDentryResponse>(await this.doROARequest("CopyDentry", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/copy`, "json", req, runtime), new CopyDentryResponse({}));
  }

  async deleteDentry(spaceId: string, dentryId: string, request: DeleteDentryRequest): Promise<DeleteDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDentryHeaders({ });
    return await this.deleteDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async deleteDentryWithOptions(spaceId: string, dentryId: string, request: DeleteDentryRequest, headers: DeleteDentryHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
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
    return $tea.cast<DeleteDentryResponse>(await this.doROARequest("DeleteDentry", "storage_1.0", "HTTP", "DELETE", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}`, "json", req, runtime), new DeleteDentryResponse({}));
  }

  async deleteDentryAppProperties(spaceId: string, dentryId: string, request: DeleteDentryAppPropertiesRequest): Promise<DeleteDentryAppPropertiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDentryAppPropertiesHeaders({ });
    return await this.deleteDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async deleteDentryAppPropertiesWithOptions(spaceId: string, dentryId: string, request: DeleteDentryAppPropertiesRequest, headers: DeleteDentryAppPropertiesHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDentryAppPropertiesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
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
    return $tea.cast<DeleteDentryAppPropertiesResponse>(await this.doROARequest("DeleteDentryAppProperties", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/appProperties/remove`, "json", req, runtime), new DeleteDentryAppPropertiesResponse({}));
  }

  async deleteRecycleItem(recycleBinId: string, recycleItemId: string, request: DeleteRecycleItemRequest): Promise<DeleteRecycleItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecycleItemHeaders({ });
    return await this.deleteRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
  }

  async deleteRecycleItemWithOptions(recycleBinId: string, recycleItemId: string, request: DeleteRecycleItemRequest, headers: DeleteRecycleItemHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecycleItemResponse> {
    Util.validateModel(request);
    recycleBinId = OpenApiUtil.getEncodeParam(recycleBinId);
    recycleItemId = OpenApiUtil.getEncodeParam(recycleItemId);
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
    return $tea.cast<DeleteRecycleItemResponse>(await this.doROARequest("DeleteRecycleItem", "storage_1.0", "HTTP", "DELETE", "AK", `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/${recycleItemId}`, "json", req, runtime), new DeleteRecycleItemResponse({}));
  }

  async deleteRecycleItems(recycleBinId: string, request: DeleteRecycleItemsRequest): Promise<DeleteRecycleItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecycleItemsHeaders({ });
    return await this.deleteRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
  }

  async deleteRecycleItemsWithOptions(recycleBinId: string, request: DeleteRecycleItemsRequest, headers: DeleteRecycleItemsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecycleItemsResponse> {
    Util.validateModel(request);
    recycleBinId = OpenApiUtil.getEncodeParam(recycleBinId);
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
    return $tea.cast<DeleteRecycleItemsResponse>(await this.doROARequest("DeleteRecycleItems", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/batchRemove`, "json", req, runtime), new DeleteRecycleItemsResponse({}));
  }

  async getCurrentApp(request: GetCurrentAppRequest): Promise<GetCurrentAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCurrentAppHeaders({ });
    return await this.getCurrentAppWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetCurrentAppResponse>(await this.doROARequest("GetCurrentApp", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/currentApps/query`, "json", req, runtime), new GetCurrentAppResponse({}));
  }

  async getDentry(spaceId: string, dentryId: string, request: GetDentryRequest): Promise<GetDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryHeaders({ });
    return await this.getDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async getDentryWithOptions(spaceId: string, dentryId: string, request: GetDentryRequest, headers: GetDentryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<GetDentryResponse>(await this.doROARequest("GetDentry", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/query`, "json", req, runtime), new GetDentryResponse({}));
  }

  async getFileDownloadInfo(spaceId: string, dentryId: string, request: GetFileDownloadInfoRequest): Promise<GetFileDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileDownloadInfoHeaders({ });
    return await this.getFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async getFileDownloadInfoWithOptions(spaceId: string, dentryId: string, request: GetFileDownloadInfoRequest, headers: GetFileDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileDownloadInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<GetFileDownloadInfoResponse>(await this.doROARequest("GetFileDownloadInfo", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/downloadInfos/query`, "json", req, runtime), new GetFileDownloadInfoResponse({}));
  }

  async getFileUploadInfo(spaceId: string, request: GetFileUploadInfoRequest): Promise<GetFileUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadInfoHeaders({ });
    return await this.getFileUploadInfoWithOptions(spaceId, request, headers, runtime);
  }

  async getFileUploadInfoWithOptions(spaceId: string, request: GetFileUploadInfoRequest, headers: GetFileUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileUploadInfoResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.multipart)) {
      body["multipart"] = request.multipart;
    }

    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<GetFileUploadInfoResponse>(await this.doROARequest("GetFileUploadInfo", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/files/uploadInfos/query`, "json", req, runtime), new GetFileUploadInfoResponse({}));
  }

  async getRecycleBin(request: GetRecycleBinRequest): Promise<GetRecycleBinResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecycleBinHeaders({ });
    return await this.getRecycleBinWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetRecycleBinResponse>(await this.doROARequest("GetRecycleBin", "storage_1.0", "HTTP", "GET", "AK", `/v1.0/storage/recycleBins`, "json", req, runtime), new GetRecycleBinResponse({}));
  }

  async getRecycleItem(recycleBinId: string, recycleItemId: string, request: GetRecycleItemRequest): Promise<GetRecycleItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecycleItemHeaders({ });
    return await this.getRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
  }

  async getRecycleItemWithOptions(recycleBinId: string, recycleItemId: string, request: GetRecycleItemRequest, headers: GetRecycleItemHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecycleItemResponse> {
    Util.validateModel(request);
    recycleBinId = OpenApiUtil.getEncodeParam(recycleBinId);
    recycleItemId = OpenApiUtil.getEncodeParam(recycleItemId);
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
    return $tea.cast<GetRecycleItemResponse>(await this.doROARequest("GetRecycleItem", "storage_1.0", "HTTP", "GET", "AK", `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/${recycleItemId}`, "json", req, runtime), new GetRecycleItemResponse({}));
  }

  async getSpace(spaceId: string, request: GetSpaceRequest): Promise<GetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceHeaders({ });
    return await this.getSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async getSpaceWithOptions(spaceId: string, request: GetSpaceRequest, headers: GetSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceResponse> {
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
    return $tea.cast<GetSpaceResponse>(await this.doROARequest("GetSpace", "storage_1.0", "HTTP", "GET", "AK", `/v1.0/storage/spaces/${spaceId}`, "json", req, runtime), new GetSpaceResponse({}));
  }

  async listDentries(spaceId: string, request: ListDentriesRequest): Promise<ListDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDentriesHeaders({ });
    return await this.listDentriesWithOptions(spaceId, request, headers, runtime);
  }

  async listDentriesWithOptions(spaceId: string, request: ListDentriesRequest, headers: ListDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<ListDentriesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
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
    return $tea.cast<ListDentriesResponse>(await this.doROARequest("ListDentries", "storage_1.0", "HTTP", "GET", "AK", `/v1.0/storage/spaces/${spaceId}/dentries`, "json", req, runtime), new ListDentriesResponse({}));
  }

  async listDentryVersions(spaceId: string, dentryId: string, request: ListDentryVersionsRequest): Promise<ListDentryVersionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDentryVersionsHeaders({ });
    return await this.listDentryVersionsWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async listDentryVersionsWithOptions(spaceId: string, dentryId: string, request: ListDentryVersionsRequest, headers: ListDentryVersionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListDentryVersionsResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
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
    return $tea.cast<ListDentryVersionsResponse>(await this.doROARequest("ListDentryVersions", "storage_1.0", "HTTP", "GET", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/versions`, "json", req, runtime), new ListDentryVersionsResponse({}));
  }

  async listRecycleItems(recycleBinId: string, request: ListRecycleItemsRequest): Promise<ListRecycleItemsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRecycleItemsHeaders({ });
    return await this.listRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
  }

  async listRecycleItemsWithOptions(recycleBinId: string, request: ListRecycleItemsRequest, headers: ListRecycleItemsHeaders, runtime: $Util.RuntimeOptions): Promise<ListRecycleItemsResponse> {
    Util.validateModel(request);
    recycleBinId = OpenApiUtil.getEncodeParam(recycleBinId);
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
    return $tea.cast<ListRecycleItemsResponse>(await this.doROARequest("ListRecycleItems", "storage_1.0", "HTTP", "GET", "AK", `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems`, "json", req, runtime), new ListRecycleItemsResponse({}));
  }

  async moveDentry(spaceId: string, dentryId: string, request: MoveDentryRequest): Promise<MoveDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveDentryHeaders({ });
    return await this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async moveDentryWithOptions(spaceId: string, dentryId: string, request: MoveDentryRequest, headers: MoveDentryHeaders, runtime: $Util.RuntimeOptions): Promise<MoveDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<MoveDentryResponse>(await this.doROARequest("MoveDentry", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/move`, "json", req, runtime), new MoveDentryResponse({}));
  }

  async renameDentry(spaceId: string, dentryId: string, request: RenameDentryRequest): Promise<RenameDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenameDentryHeaders({ });
    return await this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async renameDentryWithOptions(spaceId: string, dentryId: string, request: RenameDentryRequest, headers: RenameDentryHeaders, runtime: $Util.RuntimeOptions): Promise<RenameDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
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
    return $tea.cast<RenameDentryResponse>(await this.doROARequest("RenameDentry", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/rename`, "json", req, runtime), new RenameDentryResponse({}));
  }

  async restoreRecycleItem(recycleBinId: string, recycleItemId: string, request: RestoreRecycleItemRequest): Promise<RestoreRecycleItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RestoreRecycleItemHeaders({ });
    return await this.restoreRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
  }

  async restoreRecycleItemWithOptions(recycleBinId: string, recycleItemId: string, request: RestoreRecycleItemRequest, headers: RestoreRecycleItemHeaders, runtime: $Util.RuntimeOptions): Promise<RestoreRecycleItemResponse> {
    Util.validateModel(request);
    recycleBinId = OpenApiUtil.getEncodeParam(recycleBinId);
    recycleItemId = OpenApiUtil.getEncodeParam(recycleItemId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.option))) {
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
    return $tea.cast<RestoreRecycleItemResponse>(await this.doROARequest("RestoreRecycleItem", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/recycleBins/${recycleBinId}/recycleItems/${recycleItemId}/restore`, "json", req, runtime), new RestoreRecycleItemResponse({}));
  }

  async revertDentryVersion(spaceId: string, dentryId: string, version: string, request: RevertDentryVersionRequest): Promise<RevertDentryVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RevertDentryVersionHeaders({ });
    return await this.revertDentryVersionWithOptions(spaceId, dentryId, version, request, headers, runtime);
  }

  async revertDentryVersionWithOptions(spaceId: string, dentryId: string, version: string, request: RevertDentryVersionRequest, headers: RevertDentryVersionHeaders, runtime: $Util.RuntimeOptions): Promise<RevertDentryVersionResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
    version = OpenApiUtil.getEncodeParam(version);
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
    return $tea.cast<RevertDentryVersionResponse>(await this.doROARequest("RevertDentryVersion", "storage_1.0", "HTTP", "POST", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/versions/${version}/revert`, "json", req, runtime), new RevertDentryVersionResponse({}));
  }

  async updateDentryAppProperties(spaceId: string, dentryId: string, request: UpdateDentryAppPropertiesRequest): Promise<UpdateDentryAppPropertiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDentryAppPropertiesHeaders({ });
    return await this.updateDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async updateDentryAppPropertiesWithOptions(spaceId: string, dentryId: string, request: UpdateDentryAppPropertiesRequest, headers: UpdateDentryAppPropertiesHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDentryAppPropertiesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
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
    return $tea.cast<UpdateDentryAppPropertiesResponse>(await this.doROARequest("UpdateDentryAppProperties", "storage_1.0", "HTTP", "PUT", "AK", `/v1.0/storage/spaces/${spaceId}/dentries/${dentryId}/appProperties`, "json", req, runtime), new UpdateDentryAppPropertiesResponse({}));
  }

}
