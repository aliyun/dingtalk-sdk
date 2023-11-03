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

export class DentryModel extends $tea.Model {
  contentType?: string;
  createdTime?: number;
  creator?: DentryModelCreator;
  dentryId?: string;
  dentryType?: string;
  dentryUuid?: string;
  docKey?: string;
  extension?: string;
  hasChildren?: boolean;
  linkSourceInfo?: LinkSourceInfo;
  name?: string;
  path?: string;
  space?: SpaceModel;
  spaceId?: string;
  statisticalInfo?: DentryModelStatisticalInfo;
  updatedTime?: number;
  updater?: DentryModelUpdater;
  url?: string;
  visitorInfo?: DentryModelVisitorInfo;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createdTime: 'createdTime',
      creator: 'creator',
      dentryId: 'dentryId',
      dentryType: 'dentryType',
      dentryUuid: 'dentryUuid',
      docKey: 'docKey',
      extension: 'extension',
      hasChildren: 'hasChildren',
      linkSourceInfo: 'linkSourceInfo',
      name: 'name',
      path: 'path',
      space: 'space',
      spaceId: 'spaceId',
      statisticalInfo: 'statisticalInfo',
      updatedTime: 'updatedTime',
      updater: 'updater',
      url: 'url',
      visitorInfo: 'visitorInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createdTime: 'number',
      creator: DentryModelCreator,
      dentryId: 'string',
      dentryType: 'string',
      dentryUuid: 'string',
      docKey: 'string',
      extension: 'string',
      hasChildren: 'boolean',
      linkSourceInfo: LinkSourceInfo,
      name: 'string',
      path: 'string',
      space: SpaceModel,
      spaceId: 'string',
      statisticalInfo: DentryModelStatisticalInfo,
      updatedTime: 'number',
      updater: DentryModelUpdater,
      url: 'string',
      visitorInfo: DentryModelVisitorInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DentryVO extends $tea.Model {
  contentType?: string;
  createdTime?: number;
  creator?: DentryVOCreator;
  dentryId?: string;
  dentryType?: string;
  dentryUuid?: string;
  docKey?: string;
  extension?: string;
  hasChildren?: boolean;
  linkSourceInfo?: LinkSourceInfo;
  name?: string;
  path?: string;
  space?: SpaceModel;
  spaceId?: string;
  updatedTime?: number;
  updater?: DentryVOUpdater;
  url?: string;
  visitorInfo?: DentryVOVisitorInfo;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createdTime: 'createdTime',
      creator: 'creator',
      dentryId: 'dentryId',
      dentryType: 'dentryType',
      dentryUuid: 'dentryUuid',
      docKey: 'docKey',
      extension: 'extension',
      hasChildren: 'hasChildren',
      linkSourceInfo: 'linkSourceInfo',
      name: 'name',
      path: 'path',
      space: 'space',
      spaceId: 'spaceId',
      updatedTime: 'updatedTime',
      updater: 'updater',
      url: 'url',
      visitorInfo: 'visitorInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'string',
      createdTime: 'number',
      creator: DentryVOCreator,
      dentryId: 'string',
      dentryType: 'string',
      dentryUuid: 'string',
      docKey: 'string',
      extension: 'string',
      hasChildren: 'boolean',
      linkSourceInfo: LinkSourceInfo,
      name: 'string',
      path: 'string',
      space: SpaceModel,
      spaceId: 'string',
      updatedTime: 'number',
      updater: DentryVOUpdater,
      url: 'string',
      visitorInfo: DentryVOVisitorInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkSourceInfo extends $tea.Model {
  extension?: string;
  iconUrl?: LinkSourceInfoIconUrl;
  id?: string;
  linkType?: number;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      iconUrl: 'iconUrl',
      id: 'id',
      linkType: 'linkType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: 'string',
      iconUrl: LinkSourceInfoIconUrl,
      id: 'string',
      linkType: 'number',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenActionModel extends $tea.Model {
  name?: string;
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceModel extends $tea.Model {
  cover?: string;
  description?: string;
  hdIconVO?: SpaceModelHdIconVO;
  iconVO?: SpaceModelIconVO;
  id?: string;
  name?: string;
  owner?: SpaceModelOwner;
  recentList?: DentryModel[];
  type?: number;
  url?: string;
  visitorInfo?: SpaceModelVisitorInfo;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      description: 'description',
      hdIconVO: 'hdIconVO',
      iconVO: 'iconVO',
      id: 'id',
      name: 'name',
      owner: 'owner',
      recentList: 'recentList',
      type: 'type',
      url: 'url',
      visitorInfo: 'visitorInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      description: 'string',
      hdIconVO: SpaceModelHdIconVO,
      iconVO: SpaceModelIconVO,
      id: 'string',
      name: 'string',
      owner: SpaceModelOwner,
      recentList: { 'type': 'array', 'itemType': DentryModel },
      type: 'number',
      url: 'string',
      visitorInfo: SpaceModelVisitorInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceVO extends $tea.Model {
  cover?: string;
  description?: string;
  iconVO?: SpaceVOIconVO;
  id?: string;
  name?: string;
  owner?: SpaceVOOwner;
  type?: number;
  url?: string;
  visitorInfo?: SpaceVOVisitorInfo;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      description: 'description',
      iconVO: 'iconVO',
      id: 'id',
      name: 'name',
      owner: 'owner',
      type: 'type',
      url: 'url',
      visitorInfo: 'visitorInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      description: 'string',
      iconVO: SpaceVOIconVO,
      id: 'string',
      name: 'string',
      owner: SpaceVOOwner,
      type: 'number',
      url: 'string',
      visitorInfo: SpaceVOVisitorInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamModel extends $tea.Model {
  cover?: string;
  createdTime?: number;
  creator?: TeamModelCreator;
  description?: string;
  icon?: string;
  id?: string;
  name?: string;
  relatedDeptInfo?: TeamModelRelatedDeptInfo;
  status?: number;
  type?: number;
  updatedTime?: number;
  updater?: TeamModelUpdater;
  url?: string;
  visitInfo?: TeamModelVisitInfo;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      createdTime: 'createdTime',
      creator: 'creator',
      description: 'description',
      icon: 'icon',
      id: 'id',
      name: 'name',
      relatedDeptInfo: 'relatedDeptInfo',
      status: 'status',
      type: 'type',
      updatedTime: 'updatedTime',
      updater: 'updater',
      url: 'url',
      visitInfo: 'visitInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      createdTime: 'number',
      creator: TeamModelCreator,
      description: 'string',
      icon: 'string',
      id: 'string',
      name: 'string',
      relatedDeptInfo: TeamModelRelatedDeptInfo,
      status: 'number',
      type: 'number',
      updatedTime: 'number',
      updater: TeamModelUpdater,
      url: 'string',
      visitInfo: TeamModelVisitInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamVO extends $tea.Model {
  cover?: string;
  createdTime?: number;
  creator?: TeamVOCreator;
  description?: string;
  icon?: string;
  id?: string;
  name?: string;
  relatedDeptInfo?: TeamVORelatedDeptInfo;
  shareScopeInfo?: TeamVOShareScopeInfo;
  status?: number;
  type?: number;
  updatedTime?: number;
  updater?: TeamVOUpdater;
  url?: string;
  visitInfo?: TeamVOVisitInfo;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      createdTime: 'createdTime',
      creator: 'creator',
      description: 'description',
      icon: 'icon',
      id: 'id',
      name: 'name',
      relatedDeptInfo: 'relatedDeptInfo',
      shareScopeInfo: 'shareScopeInfo',
      status: 'status',
      type: 'type',
      updatedTime: 'updatedTime',
      updater: 'updater',
      url: 'url',
      visitInfo: 'visitInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      createdTime: 'number',
      creator: TeamVOCreator,
      description: 'string',
      icon: 'string',
      id: 'string',
      name: 'string',
      relatedDeptInfo: TeamVORelatedDeptInfo,
      shareScopeInfo: TeamVOShareScopeInfo,
      status: 'number',
      type: 'number',
      updatedTime: 'number',
      updater: TeamVOUpdater,
      url: 'string',
      visitInfo: TeamVOVisitInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MapValue extends $tea.Model {
  templateId?: string;
  title?: string;
  type?: number;
  coverDownloadUrl?: string;
  description?: string;
  authorName?: string;
  createTime?: string;
  modifiedTime?: string;
  workspaceId?: string;
  workspaceName?: string;
  usedCount?: number;
  belong?: string;
  contentDownloadUrl?: string;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
      title: 'title',
      type: 'type',
      coverDownloadUrl: 'coverDownloadUrl',
      description: 'description',
      authorName: 'authorName',
      createTime: 'createTime',
      modifiedTime: 'modifiedTime',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
      usedCount: 'usedCount',
      belong: 'belong',
      contentDownloadUrl: 'contentDownloadUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'string',
      title: 'string',
      type: 'number',
      coverDownloadUrl: 'string',
      description: 'string',
      authorName: 'string',
      createTime: 'string',
      modifiedTime: 'string',
      workspaceId: 'string',
      workspaceName: 'string',
      usedCount: 'number',
      belong: 'string',
      contentDownloadUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTeamHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTeamRequest extends $tea.Model {
  param?: BatchCreateTeamRequestParam;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: BatchCreateTeamRequestParam,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTeamResponseBody extends $tea.Model {
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

export class BatchCreateTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchCreateTeamResponseBody;
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
      body: BatchCreateTeamResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteRecentsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteRecentsRequest extends $tea.Model {
  dentryUuids?: string[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryUuids: 'dentryUuids',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryUuids: { 'type': 'array', 'itemType': 'string' },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteRecentsResponseBody extends $tea.Model {
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

export class BatchDeleteRecentsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchDeleteRecentsResponseBody;
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
      body: BatchDeleteRecentsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoriesTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoriesTemplatesRequest extends $tea.Model {
  option?: CategoriesTemplatesRequestOption;
  param?: CategoriesTemplatesRequestParam;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      param: 'param',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: CategoriesTemplatesRequestOption,
      param: CategoriesTemplatesRequestParam,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoriesTemplatesResponseBody extends $tea.Model {
  map?: { [key: string]: MapValue[] };
  static names(): { [key: string]: string } {
    return {
      map: 'map',
    };
  }

  static types(): { [key: string]: any } {
    return {
      map: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': MapValue } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoriesTemplatesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CategoriesTemplatesResponseBody;
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
      body: CategoriesTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesRequest extends $tea.Model {
  option?: CategoryTemplatesRequestOption;
  param?: CategoryTemplatesRequestParam;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      param: 'param',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: CategoryTemplatesRequestOption,
      param: CategoryTemplatesRequestParam,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesResponseBody extends $tea.Model {
  list?: CategoryTemplatesResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': CategoryTemplatesResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CategoryTemplatesResponseBody;
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
      body: CategoryTemplatesResponseBody,
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
  name?: string;
  operatorId?: string;
  targetSpaceId?: string;
  toNextDentryId?: string;
  toParentDentryId?: string;
  toPrevDentryId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      operatorId: 'operatorId',
      targetSpaceId: 'targetSpaceId',
      toNextDentryId: 'toNextDentryId',
      toParentDentryId: 'toParentDentryId',
      toPrevDentryId: 'toPrevDentryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      operatorId: 'string',
      targetSpaceId: 'string',
      toNextDentryId: 'string',
      toParentDentryId: 'string',
      toPrevDentryId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyDentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DentryVO;
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
      body: DentryVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDentryRequest extends $tea.Model {
  dentryType?: string;
  documentType?: number;
  name?: string;
  operatorId?: string;
  parentDentryId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryType: 'dentryType',
      documentType: 'documentType',
      name: 'name',
      operatorId: 'operatorId',
      parentDentryId: 'parentDentryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryType: 'string',
      documentType: 'number',
      name: 'string',
      operatorId: 'string',
      parentDentryId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DentryVO;
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
      body: DentryVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceRequest extends $tea.Model {
  description?: string;
  icon?: string;
  name?: string;
  operatorId?: string;
  sectionId?: string;
  shareScope?: CreateSpaceRequestShareScope;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      icon: 'icon',
      name: 'name',
      operatorId: 'operatorId',
      sectionId: 'sectionId',
      shareScope: 'shareScope',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      icon: 'string',
      name: 'string',
      operatorId: 'string',
      sectionId: 'string',
      shareScope: CreateSpaceRequestShareScope,
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SpaceVO;
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
      body: SpaceVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTeamHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTeamRequest extends $tea.Model {
  cover?: string;
  description?: string;
  icon?: string;
  members?: CreateTeamRequestMembers[];
  name?: string;
  operatorId?: string;
  teamType?: number;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      description: 'description',
      icon: 'icon',
      members: 'members',
      name: 'name',
      operatorId: 'operatorId',
      teamType: 'teamType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      description: 'string',
      icon: 'string',
      members: { 'type': 'array', 'itemType': CreateTeamRequestMembers },
      name: 'string',
      operatorId: 'string',
      teamType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TeamVO;
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
      body: TeamVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CrossOrgMigrateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CrossOrgMigrateRequest extends $tea.Model {
  option?: CrossOrgMigrateRequestOption;
  param?: CrossOrgMigrateRequestParam;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      param: 'param',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: CrossOrgMigrateRequestOption,
      param: CrossOrgMigrateRequestParam,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CrossOrgMigrateResponseBody extends $tea.Model {
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

export class CrossOrgMigrateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CrossOrgMigrateResponseBody;
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
      body: CrossOrgMigrateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeamHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTeamRequest extends $tea.Model {
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

export class DeleteTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TeamVO;
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
      body: TeamVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocContentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocContentRequest extends $tea.Model {
  option?: DocContentRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: DocContentRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocContentResponseBody extends $tea.Model {
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocContentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocContentResponseBody;
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
      body: DocContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocContentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocContentRequest extends $tea.Model {
  targetFormat?: string;
  static names(): { [key: string]: string } {
    return {
      targetFormat: 'targetFormat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetFormat: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocContentResponseBody extends $tea.Model {
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocContentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDocContentResponseBody;
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
      body: GetDocContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaRequest extends $tea.Model {
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

export class GetSchemaResponseBody extends $tea.Model {
  revision?: number;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      revision: 'revision',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      revision: 'number',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSchemaResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSchemaResponseBody;
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
      body: GetSchemaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceDirectoriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceDirectoriesRequest extends $tea.Model {
  dentryId?: string;
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceDirectoriesResponseBody extends $tea.Model {
  children?: DentryModel[];
  hasMore?: boolean;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': DentryModel },
      hasMore: 'boolean',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceDirectoriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSpaceDirectoriesResponseBody;
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
      body: GetSpaceDirectoriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStarInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStarInfoRequest extends $tea.Model {
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

export class GetStarInfoResponseBody extends $tea.Model {
  starred?: boolean;
  static names(): { [key: string]: string } {
    return {
      starred: 'starred',
    };
  }

  static types(): { [key: string]: any } {
    return {
      starred: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStarInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetStarInfoResponseBody;
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
      body: GetStarInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTeamHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTeamRequest extends $tea.Model {
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

export class GetTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TeamVO;
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
      body: TeamVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfDentriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfDentriesRequest extends $tea.Model {
  includeFolder?: boolean;
  operatorId?: string;
  spaceTypes?: string;
  static names(): { [key: string]: string } {
    return {
      includeFolder: 'includeFolder',
      operatorId: 'operatorId',
      spaceTypes: 'spaceTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeFolder: 'boolean',
      operatorId: 'string',
      spaceTypes: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfDentriesResponseBody extends $tea.Model {
  dentriesCount?: string;
  static names(): { [key: string]: string } {
    return {
      dentriesCount: 'dentriesCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentriesCount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfDentriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTotalNumberOfDentriesResponseBody;
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
      body: GetTotalNumberOfDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfSpacesRequest extends $tea.Model {
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

export class GetTotalNumberOfSpacesResponseBody extends $tea.Model {
  spacesCount?: string;
  static names(): { [key: string]: string } {
    return {
      spacesCount: 'spacesCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spacesCount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTotalNumberOfSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTotalNumberOfSpacesResponseBody;
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
      body: GetTotalNumberOfSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoByOpenTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoByOpenTokenRequest extends $tea.Model {
  docKey?: string;
  openToken?: string;
  static names(): { [key: string]: string } {
    return {
      docKey: 'docKey',
      openToken: 'openToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docKey: 'string',
      openToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoByOpenTokenResponseBody extends $tea.Model {
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoByOpenTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserInfoByOpenTokenResponseBody;
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
      body: GetUserInfoByOpenTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFeedsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFeedsRequest extends $tea.Model {
  excludeFile?: boolean;
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      excludeFile: 'excludeFile',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      excludeFile: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFeedsResponseBody extends $tea.Model {
  hasMore?: boolean;
  items?: ListFeedsResponseBodyItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': ListFeedsResponseBodyItems },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFeedsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListFeedsResponseBody;
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
      body: ListFeedsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListHotDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListHotDocsRequest extends $tea.Model {
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

export class ListHotDocsResponseBody extends $tea.Model {
  items?: DentryModel[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': DentryModel },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListHotDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListHotDocsResponseBody;
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
      body: ListHotDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesRequest extends $tea.Model {
  option?: ListPinSpacesRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: ListPinSpacesRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesResponseBody extends $tea.Model {
  nextToken?: string;
  resultItems?: ListPinSpacesResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      resultItems: { 'type': 'array', 'itemType': ListPinSpacesResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListPinSpacesResponseBody;
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
      body: ListPinSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedSpaceTeamsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedSpaceTeamsRequest extends $tea.Model {
  operatorId?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedSpaceTeamsResponseBody extends $tea.Model {
  items?: TeamModel[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': TeamModel },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedSpaceTeamsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListRelatedSpaceTeamsResponseBody;
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
      body: ListRelatedSpaceTeamsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedTeamsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedTeamsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedTeamsResponseBody extends $tea.Model {
  hasMore?: boolean;
  items?: TeamModel[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': TeamModel },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRelatedTeamsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListRelatedTeamsResponseBody;
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
      body: ListRelatedTeamsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpaceSectionsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpaceSectionsRequest extends $tea.Model {
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

export class ListSpaceSectionsResponseBody extends $tea.Model {
  items?: ListSpaceSectionsResponseBodyItems[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': ListSpaceSectionsResponseBodyItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpaceSectionsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListSpaceSectionsResponseBody;
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
      body: ListSpaceSectionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsRequest extends $tea.Model {
  option?: ListStarsRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: ListStarsRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsResponseBody extends $tea.Model {
  nextToken?: string;
  starList?: ListStarsResponseBodyStarList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      starList: 'starList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      starList: { 'type': 'array', 'itemType': ListStarsResponseBodyStarList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListStarsResponseBody;
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
      body: ListStarsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamMembersRequest extends $tea.Model {
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

export class ListTeamMembersResponseBody extends $tea.Model {
  members?: ListTeamMembersResponseBodyMembers[];
  teamName?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      teamName: 'teamName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': ListTeamMembersResponseBodyMembers },
      teamName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListTeamMembersResponseBody;
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
      body: ListTeamMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MarkStarHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MarkStarRequest extends $tea.Model {
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

export class MarkStarResponseBody extends $tea.Model {
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

export class MarkStarResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: MarkStarResponseBody;
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
      body: MarkStarResponseBody,
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
  operatorId?: string;
  targetSpaceId?: string;
  toNextDentryId?: string;
  toParentDentryId?: string;
  toPrevDentryId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      targetSpaceId: 'targetSpaceId',
      toNextDentryId: 'toNextDentryId',
      toParentDentryId: 'toParentDentryId',
      toPrevDentryId: 'toPrevDentryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      targetSpaceId: 'string',
      toNextDentryId: 'string',
      toParentDentryId: 'string',
      toPrevDentryId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveDentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DentryVO;
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
      body: DentryVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PinSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PinSpaceRequest extends $tea.Model {
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

export class PinSpaceResponseBody extends $tea.Model {
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

export class PinSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PinSpaceResponseBody;
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
      body: PinSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDentryRequest extends $tea.Model {
  includeSpace?: boolean;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      includeSpace: 'includeSpace',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeSpace: 'boolean',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DentryVO;
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
      body: DentryVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocContentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocContentRequest extends $tea.Model {
  operatorId?: string;
  targetFormat?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      targetFormat: 'targetFormat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      targetFormat: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocContentResponseBody extends $tea.Model {
  taskId?: number;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocContentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryDocContentResponseBody;
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
      body: QueryDocContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryItemByUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryItemByUrlRequest extends $tea.Model {
  operatorId?: string;
  url?: string;
  withStatisticalInfo?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      url: 'url',
      withStatisticalInfo: 'withStatisticalInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      url: 'string',
      withStatisticalInfo: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryItemByUrlResponseBody extends $tea.Model {
  bizType?: string;
  dentry?: DentryModel;
  resourceType?: string;
  space?: QueryItemByUrlResponseBodySpace;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      dentry: 'dentry',
      resourceType: 'resourceType',
      space: 'space',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      dentry: DentryModel,
      resourceType: 'string',
      space: QueryItemByUrlResponseBodySpace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryItemByUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryItemByUrlResponseBody;
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
      body: QueryItemByUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMineSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMineSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SpaceVO;
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
      body: SpaceVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentListRequest extends $tea.Model {
  creatorType?: number;
  fileType?: number;
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  recentType?: number;
  static names(): { [key: string]: string } {
    return {
      creatorType: 'creatorType',
      fileType: 'fileType',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      recentType: 'recentType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorType: 'number',
      fileType: 'number',
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      recentType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentListResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  recentList?: QueryRecentListResponseBodyRecentList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      recentList: 'recentList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      recentList: { 'type': 'array', 'itemType': QueryRecentListResponseBodyRecentList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryRecentListResponseBody;
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
      body: QueryRecentListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySpaceRequest extends $tea.Model {
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

export class QuerySpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SpaceVO;
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
      body: SpaceVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponseBody extends $tea.Model {
  hasMore?: boolean;
  items?: RelatedSpacesResponseBodyItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': RelatedSpacesResponseBodyItems },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RelatedSpacesResponseBody;
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
      body: RelatedSpacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTeamMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTeamMembersRequest extends $tea.Model {
  members?: RemoveTeamMembersRequestMembers[];
  notify?: boolean;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      notify: 'notify',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': RemoveTeamMembersRequestMembers },
      notify: 'boolean',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTeamMembersResponseBody extends $tea.Model {
  notInOrgMembers?: RemoveTeamMembersResponseBodyNotInOrgMembers[];
  saveSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      notInOrgMembers: 'notInOrgMembers',
      saveSuccess: 'saveSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notInOrgMembers: { 'type': 'array', 'itemType': RemoveTeamMembersResponseBodyNotInOrgMembers },
      saveSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTeamMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemoveTeamMembersResponseBody;
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
      body: RemoveTeamMembersResponseBody,
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
  name?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RenameDentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DentryVO;
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
      body: DentryVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveTeamMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveTeamMembersRequest extends $tea.Model {
  members?: SaveTeamMembersRequestMembers[];
  notify?: boolean;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      notify: 'notify',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': SaveTeamMembersRequestMembers },
      notify: 'boolean',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveTeamMembersResponseBody extends $tea.Model {
  notInOrgMembers?: SaveTeamMembersResponseBodyNotInOrgMembers[];
  saveSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      notInOrgMembers: 'notInOrgMembers',
      saveSuccess: 'saveSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notInOrgMembers: { 'type': 'array', 'itemType': SaveTeamMembersResponseBodyNotInOrgMembers },
      saveSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveTeamMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveTeamMembersResponseBody;
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
      body: SaveTeamMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchRequest extends $tea.Model {
  dentryRequest?: SearchRequestDentryRequest;
  keyword?: string;
  operatorId?: string;
  spaceRequest?: SearchRequestSpaceRequest;
  static names(): { [key: string]: string } {
    return {
      dentryRequest: 'dentryRequest',
      keyword: 'keyword',
      operatorId: 'operatorId',
      spaceRequest: 'spaceRequest',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryRequest: SearchRequestDentryRequest,
      keyword: 'string',
      operatorId: 'string',
      spaceRequest: SearchRequestSpaceRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBody extends $tea.Model {
  dentryResult?: SearchResponseBodyDentryResult;
  spaceResult?: SearchResponseBodySpaceResult;
  static names(): { [key: string]: string } {
    return {
      dentryResult: 'dentryResult',
      spaceResult: 'spaceResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryResult: SearchResponseBodyDentryResult,
      spaceResult: SearchResponseBodySpaceResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchResponseBody;
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
      body: SearchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesRequest extends $tea.Model {
  option?: SearchTemplatesRequestOption;
  param?: SearchTemplatesRequestParam;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      param: 'param',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: SearchTemplatesRequestOption,
      param: SearchTemplatesRequestParam,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesResponseBody extends $tea.Model {
  nextToken?: string;
  templateList?: SearchTemplatesResponseBodyTemplateList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      templateList: { 'type': 'array', 'itemType': SearchTemplatesResponseBodyTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchTemplatesResponseBody;
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
      body: SearchTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesRequest extends $tea.Model {
  option?: TeamTemplatesRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: TeamTemplatesRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesResponseBody extends $tea.Model {
  nextToken?: string;
  templateList?: TeamTemplatesResponseBodyTemplateList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      templateList: { 'type': 'array', 'itemType': TeamTemplatesResponseBodyTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TeamTemplatesResponseBody;
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
      body: TeamTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesRequest extends $tea.Model {
  option?: TemplateCategoriesRequestOption;
  param?: TemplateCategoriesRequestParam;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      param: 'param',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: TemplateCategoriesRequestOption,
      param: TemplateCategoriesRequestParam,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesResponseBody extends $tea.Model {
  list?: TemplateCategoriesResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': TemplateCategoriesResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TemplateCategoriesResponseBody;
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
      body: TemplateCategoriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnmarkStarHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnmarkStarRequest extends $tea.Model {
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

export class UnmarkStarResponseBody extends $tea.Model {
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

export class UnmarkStarResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnmarkStarResponseBody;
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
      body: UnmarkStarResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnpinSpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnpinSpaceRequest extends $tea.Model {
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

export class UnpinSpaceResponseBody extends $tea.Model {
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

export class UnpinSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnpinSpaceResponseBody;
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
      body: UnpinSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTeamHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTeamRequest extends $tea.Model {
  description?: string;
  name?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      name: 'name',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      name: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TeamVO;
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
      body: TeamVO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTemplatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTemplatesRequest extends $tea.Model {
  option?: UserTemplatesRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: UserTemplatesRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTemplatesResponseBody extends $tea.Model {
  nextToken?: string;
  templateList?: UserTemplatesResponseBodyTemplateList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      templateList: { 'type': 'array', 'itemType': UserTemplatesResponseBodyTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTemplatesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UserTemplatesResponseBody;
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
      body: UserTemplatesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DentryModelCreator extends $tea.Model {
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

export class DentryModelStatisticalInfo extends $tea.Model {
  wordCount?: number;
  static names(): { [key: string]: string } {
    return {
      wordCount: 'wordCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      wordCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DentryModelUpdater extends $tea.Model {
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

export class DentryModelVisitorInfo extends $tea.Model {
  dentryActions?: string[];
  roleCode?: string;
  spaceActions?: string[];
  static names(): { [key: string]: string } {
    return {
      dentryActions: 'dentryActions',
      roleCode: 'roleCode',
      spaceActions: 'spaceActions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryActions: { 'type': 'array', 'itemType': 'string' },
      roleCode: 'string',
      spaceActions: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DentryVOCreator extends $tea.Model {
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

export class DentryVOUpdater extends $tea.Model {
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

export class DentryVOVisitorInfo extends $tea.Model {
  dentryActions?: string[];
  roleCode?: string;
  spaceActions?: string[];
  static names(): { [key: string]: string } {
    return {
      dentryActions: 'dentryActions',
      roleCode: 'roleCode',
      spaceActions: 'spaceActions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryActions: { 'type': 'array', 'itemType': 'string' },
      roleCode: 'string',
      spaceActions: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkSourceInfoIconUrl extends $tea.Model {
  line?: string;
  small?: string;
  static names(): { [key: string]: string } {
    return {
      line: 'line',
      small: 'small',
    };
  }

  static types(): { [key: string]: any } {
    return {
      line: 'string',
      small: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceModelHdIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceModelIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceModelOwner extends $tea.Model {
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

export class SpaceModelVisitorInfo extends $tea.Model {
  dentryActions?: string[];
  roleCode?: string;
  spaceActions?: string[];
  static names(): { [key: string]: string } {
    return {
      dentryActions: 'dentryActions',
      roleCode: 'roleCode',
      spaceActions: 'spaceActions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryActions: { 'type': 'array', 'itemType': 'string' },
      roleCode: 'string',
      spaceActions: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceVOIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SpaceVOOwner extends $tea.Model {
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

export class SpaceVOVisitorInfo extends $tea.Model {
  dentryActions?: string[];
  roleCode?: string;
  spaceActions?: string[];
  static names(): { [key: string]: string } {
    return {
      dentryActions: 'dentryActions',
      roleCode: 'roleCode',
      spaceActions: 'spaceActions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryActions: { 'type': 'array', 'itemType': 'string' },
      roleCode: 'string',
      spaceActions: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamModelCreator extends $tea.Model {
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

export class TeamModelRelatedDeptInfo extends $tea.Model {
  deptId?: string;
  deptName?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamModelUpdater extends $tea.Model {
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

export class TeamModelVisitInfo extends $tea.Model {
  joinTime?: string;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      joinTime: 'joinTime',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      joinTime: 'string',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamVOCreator extends $tea.Model {
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

export class TeamVORelatedDeptInfo extends $tea.Model {
  deptId?: string;
  deptName?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      deptName: 'deptName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      deptName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamVOShareScopeInfo extends $tea.Model {
  roleId?: string;
  scope?: number;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'string',
      scope: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamVOUpdater extends $tea.Model {
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

export class TeamVOVisitInfo extends $tea.Model {
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTeamRequestParamCreateTeamParamList extends $tea.Model {
  adminUnionIdList?: string[];
  creatorUnionId?: string;
  deptId?: string;
  teamName?: string;
  static names(): { [key: string]: string } {
    return {
      adminUnionIdList: 'adminUnionIdList',
      creatorUnionId: 'creatorUnionId',
      deptId: 'deptId',
      teamName: 'teamName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adminUnionIdList: { 'type': 'array', 'itemType': 'string' },
      creatorUnionId: 'string',
      deptId: 'string',
      teamName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateTeamRequestParam extends $tea.Model {
  createTeamParamList?: BatchCreateTeamRequestParamCreateTeamParamList[];
  static names(): { [key: string]: string } {
    return {
      createTeamParamList: 'createTeamParamList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTeamParamList: { 'type': 'array', 'itemType': BatchCreateTeamRequestParamCreateTeamParamList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoriesTemplatesRequestOption extends $tea.Model {
  categoryStatus?: number;
  queryPlatform?: string;
  size?: number;
  templateStatus?: number;
  static names(): { [key: string]: string } {
    return {
      categoryStatus: 'categoryStatus',
      queryPlatform: 'queryPlatform',
      size: 'size',
      templateStatus: 'templateStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryStatus: 'number',
      queryPlatform: 'string',
      size: 'number',
      templateStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoriesTemplatesRequestParam extends $tea.Model {
  categoryIds?: string[];
  static names(): { [key: string]: string } {
    return {
      categoryIds: 'categoryIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesRequestOption extends $tea.Model {
  categoryStatus?: number;
  templateStatus?: number;
  static names(): { [key: string]: string } {
    return {
      categoryStatus: 'categoryStatus',
      templateStatus: 'templateStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryStatus: 'number',
      templateStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesRequestParam extends $tea.Model {
  categoryId?: string;
  static names(): { [key: string]: string } {
    return {
      categoryId: 'categoryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryTemplatesResponseBodyList extends $tea.Model {
  authorName?: string;
  belong?: string;
  contentDownloadUrl?: string;
  coverDownloadUrl?: string;
  createTime?: string;
  description?: string;
  modifiedTime?: string;
  templateId?: string;
  title?: string;
  type?: number;
  usedCount?: number;
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      authorName: 'authorName',
      belong: 'belong',
      contentDownloadUrl: 'contentDownloadUrl',
      coverDownloadUrl: 'coverDownloadUrl',
      createTime: 'createTime',
      description: 'description',
      modifiedTime: 'modifiedTime',
      templateId: 'templateId',
      title: 'title',
      type: 'type',
      usedCount: 'usedCount',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorName: 'string',
      belong: 'string',
      contentDownloadUrl: 'string',
      coverDownloadUrl: 'string',
      createTime: 'string',
      description: 'string',
      modifiedTime: 'string',
      templateId: 'string',
      title: 'string',
      type: 'number',
      usedCount: 'number',
      workspaceId: 'string',
      workspaceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceRequestShareScope extends $tea.Model {
  scope?: number;
  static names(): { [key: string]: string } {
    return {
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scope: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTeamRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: number;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'number',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CrossOrgMigrateRequestOption extends $tea.Model {
  checkOperatorSourceRole?: boolean;
  deleteSource?: boolean;
  needRecycleFailedWorkspaceId?: boolean;
  relateTeamId?: number;
  relateTeamIdStr?: string;
  retainOrgGroup?: boolean;
  skipRole?: boolean;
  workspaceIdStrs?: string[];
  workspaceIds?: number[];
  static names(): { [key: string]: string } {
    return {
      checkOperatorSourceRole: 'checkOperatorSourceRole',
      deleteSource: 'deleteSource',
      needRecycleFailedWorkspaceId: 'needRecycleFailedWorkspaceId',
      relateTeamId: 'relateTeamId',
      relateTeamIdStr: 'relateTeamIdStr',
      retainOrgGroup: 'retainOrgGroup',
      skipRole: 'skipRole',
      workspaceIdStrs: 'workspaceIdStrs',
      workspaceIds: 'workspaceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkOperatorSourceRole: 'boolean',
      deleteSource: 'boolean',
      needRecycleFailedWorkspaceId: 'boolean',
      relateTeamId: 'number',
      relateTeamIdStr: 'string',
      retainOrgGroup: 'boolean',
      skipRole: 'boolean',
      workspaceIdStrs: { 'type': 'array', 'itemType': 'string' },
      workspaceIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CrossOrgMigrateRequestParam extends $tea.Model {
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocContentRequestOption extends $tea.Model {
  targetFormat?: string;
  static names(): { [key: string]: string } {
    return {
      targetFormat: 'targetFormat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetFormat: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFeedsResponseBodyItems extends $tea.Model {
  content?: string;
  time?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      time: 'time',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      time: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesRequestOption extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  withSpaceCreatorInfo?: boolean;
  withSpaceModifierInfo?: boolean;
  withSpacePermissionRole?: boolean;
  withTeamDetail?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      withSpaceCreatorInfo: 'withSpaceCreatorInfo',
      withSpaceModifierInfo: 'withSpaceModifierInfo',
      withSpacePermissionRole: 'withSpacePermissionRole',
      withTeamDetail: 'withTeamDetail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      withSpaceCreatorInfo: 'boolean',
      withSpaceModifierInfo: 'boolean',
      withSpacePermissionRole: 'boolean',
      withTeamDetail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesResponseBodyResultItemsSpaceInfoCreator extends $tea.Model {
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

export class ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesResponseBodyResultItemsSpaceInfoModifier extends $tea.Model {
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

export class ListPinSpacesResponseBodyResultItemsSpaceInfo extends $tea.Model {
  cover?: string;
  createTime?: string;
  creator?: ListPinSpacesResponseBodyResultItemsSpaceInfoCreator;
  description?: string;
  iconVO?: ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO;
  id?: string;
  mobileUrl?: string;
  modifiedTime?: string;
  modifier?: ListPinSpacesResponseBodyResultItemsSpaceInfoModifier;
  name?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      createTime: 'createTime',
      creator: 'creator',
      description: 'description',
      iconVO: 'iconVO',
      id: 'id',
      mobileUrl: 'mobileUrl',
      modifiedTime: 'modifiedTime',
      modifier: 'modifier',
      name: 'name',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      createTime: 'string',
      creator: ListPinSpacesResponseBodyResultItemsSpaceInfoCreator,
      description: 'string',
      iconVO: ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO,
      id: 'string',
      mobileUrl: 'string',
      modifiedTime: 'string',
      modifier: ListPinSpacesResponseBodyResultItemsSpaceInfoModifier,
      name: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPinSpacesResponseBodyResultItemsTeamInfo extends $tea.Model {
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

export class ListPinSpacesResponseBodyResultItems extends $tea.Model {
  createTime?: string;
  modifiedTime?: string;
  spaceInfo?: ListPinSpacesResponseBodyResultItemsSpaceInfo;
  spacePermissionRole?: string;
  teamInfo?: ListPinSpacesResponseBodyResultItemsTeamInfo;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifiedTime: 'modifiedTime',
      spaceInfo: 'spaceInfo',
      spacePermissionRole: 'spacePermissionRole',
      teamInfo: 'teamInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      modifiedTime: 'string',
      spaceInfo: ListPinSpacesResponseBodyResultItemsSpaceInfo,
      spacePermissionRole: 'string',
      teamInfo: ListPinSpacesResponseBodyResultItemsTeamInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpaceSectionsResponseBodyItems extends $tea.Model {
  displayType?: string;
  id?: string;
  name?: string;
  spaceNum?: number;
  spaces?: SpaceModel[];
  static names(): { [key: string]: string } {
    return {
      displayType: 'displayType',
      id: 'id',
      name: 'name',
      spaceNum: 'spaceNum',
      spaces: 'spaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayType: 'string',
      id: 'string',
      name: 'string',
      spaceNum: 'number',
      spaces: { 'type': 'array', 'itemType': SpaceModel },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsRequestOption extends $tea.Model {
  contentTypeList?: string[];
  filterDocTypes?: string[];
  listV2?: boolean;
  maxResults?: number;
  nextToken?: string;
  order?: string;
  orderBy?: string;
  withDentryCreatorInfo?: boolean;
  withDentryModifierInfo?: boolean;
  withDentryPermissionRole?: boolean;
  withSpaceDetail?: boolean;
  withSpacePermissionRole?: boolean;
  withTeamDetail?: boolean;
  static names(): { [key: string]: string } {
    return {
      contentTypeList: 'contentTypeList',
      filterDocTypes: 'filterDocTypes',
      listV2: 'listV2',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
      orderBy: 'orderBy',
      withDentryCreatorInfo: 'withDentryCreatorInfo',
      withDentryModifierInfo: 'withDentryModifierInfo',
      withDentryPermissionRole: 'withDentryPermissionRole',
      withSpaceDetail: 'withSpaceDetail',
      withSpacePermissionRole: 'withSpacePermissionRole',
      withTeamDetail: 'withTeamDetail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentTypeList: { 'type': 'array', 'itemType': 'string' },
      filterDocTypes: { 'type': 'array', 'itemType': 'string' },
      listV2: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      order: 'string',
      orderBy: 'string',
      withDentryCreatorInfo: 'boolean',
      withDentryModifierInfo: 'boolean',
      withDentryPermissionRole: 'boolean',
      withSpaceDetail: 'boolean',
      withSpacePermissionRole: 'boolean',
      withTeamDetail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsResponseBodyStarListDentryInfoCreator extends $tea.Model {
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

export class ListStarsResponseBodyStarListDentryInfoModifier extends $tea.Model {
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

export class ListStarsResponseBodyStarListDentryInfo extends $tea.Model {
  createTime?: string;
  creator?: ListStarsResponseBodyStarListDentryInfoCreator;
  extension?: string;
  id?: string;
  mobileUrl?: string;
  modifiedTime?: string;
  modifier?: ListStarsResponseBodyStarListDentryInfoModifier;
  name?: string;
  pcUrl?: string;
  spaceId?: string;
  status?: string;
  type?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      creator: 'creator',
      extension: 'extension',
      id: 'id',
      mobileUrl: 'mobileUrl',
      modifiedTime: 'modifiedTime',
      modifier: 'modifier',
      name: 'name',
      pcUrl: 'pcUrl',
      spaceId: 'spaceId',
      status: 'status',
      type: 'type',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      creator: ListStarsResponseBodyStarListDentryInfoCreator,
      extension: 'string',
      id: 'string',
      mobileUrl: 'string',
      modifiedTime: 'string',
      modifier: ListStarsResponseBodyStarListDentryInfoModifier,
      name: 'string',
      pcUrl: 'string',
      spaceId: 'string',
      status: 'string',
      type: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListStarsResponseBodyStarListSpaceInfo extends $tea.Model {
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

export class ListStarsResponseBodyStarListTeamInfo extends $tea.Model {
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

export class ListStarsResponseBodyStarList extends $tea.Model {
  createTime?: string;
  dentryInfo?: ListStarsResponseBodyStarListDentryInfo;
  dentryPermissionRole?: string;
  id?: string;
  isDeleted?: boolean;
  modifiedTime?: string;
  spaceInfo?: ListStarsResponseBodyStarListSpaceInfo;
  spacePermissionRole?: string;
  starType?: string;
  teamInfo?: ListStarsResponseBodyStarListTeamInfo;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      dentryInfo: 'dentryInfo',
      dentryPermissionRole: 'dentryPermissionRole',
      id: 'id',
      isDeleted: 'isDeleted',
      modifiedTime: 'modifiedTime',
      spaceInfo: 'spaceInfo',
      spacePermissionRole: 'spacePermissionRole',
      starType: 'starType',
      teamInfo: 'teamInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      dentryInfo: ListStarsResponseBodyStarListDentryInfo,
      dentryPermissionRole: 'string',
      id: 'string',
      isDeleted: 'boolean',
      modifiedTime: 'string',
      spaceInfo: ListStarsResponseBodyStarListSpaceInfo,
      spacePermissionRole: 'string',
      starType: 'string',
      teamInfo: ListStarsResponseBodyStarListTeamInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamMembersResponseBodyMembers extends $tea.Model {
  memberId?: string;
  memberType?: number;
  name?: string;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      name: 'name',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'number',
      name: 'string',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryItemByUrlResponseBodySpaceOwner extends $tea.Model {
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

export class QueryItemByUrlResponseBodySpace extends $tea.Model {
  description?: string;
  id?: string;
  name?: string;
  owner?: QueryItemByUrlResponseBodySpaceOwner;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      id: 'id',
      name: 'name',
      owner: 'owner',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      id: 'string',
      name: 'string',
      owner: QueryItemByUrlResponseBodySpaceOwner,
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentListResponseBodyRecentListTeam extends $tea.Model {
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

export class QueryRecentListResponseBodyRecentList extends $tea.Model {
  deleted?: boolean;
  dentry?: DentryModel;
  recentTime?: number;
  team?: QueryRecentListResponseBodyRecentListTeam;
  static names(): { [key: string]: string } {
    return {
      deleted: 'deleted',
      dentry: 'dentry',
      recentTime: 'recentTime',
      team: 'team',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleted: 'boolean',
      dentry: DentryModel,
      recentTime: 'number',
      team: QueryRecentListResponseBodyRecentListTeam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponseBodyItemsHdIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponseBodyItemsIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponseBodyItemsOwner extends $tea.Model {
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

export class RelatedSpacesResponseBodyItemsVisitorInfo extends $tea.Model {
  dentryActions?: string[];
  pinned?: boolean;
  roleCode?: string;
  spaceActions?: string[];
  static names(): { [key: string]: string } {
    return {
      dentryActions: 'dentryActions',
      pinned: 'pinned',
      roleCode: 'roleCode',
      spaceActions: 'spaceActions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryActions: { 'type': 'array', 'itemType': 'string' },
      pinned: 'boolean',
      roleCode: 'string',
      spaceActions: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponseBodyItems extends $tea.Model {
  cover?: string;
  description?: string;
  hdIconVO?: RelatedSpacesResponseBodyItemsHdIconVO;
  iconVO?: RelatedSpacesResponseBodyItemsIconVO;
  id?: string;
  name?: string;
  owner?: RelatedSpacesResponseBodyItemsOwner;
  recentList?: DentryModel[];
  type?: number;
  url?: string;
  visitorInfo?: RelatedSpacesResponseBodyItemsVisitorInfo;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      description: 'description',
      hdIconVO: 'hdIconVO',
      iconVO: 'iconVO',
      id: 'id',
      name: 'name',
      owner: 'owner',
      recentList: 'recentList',
      type: 'type',
      url: 'url',
      visitorInfo: 'visitorInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      description: 'string',
      hdIconVO: RelatedSpacesResponseBodyItemsHdIconVO,
      iconVO: RelatedSpacesResponseBodyItemsIconVO,
      id: 'string',
      name: 'string',
      owner: RelatedSpacesResponseBodyItemsOwner,
      recentList: { 'type': 'array', 'itemType': DentryModel },
      type: 'number',
      url: 'string',
      visitorInfo: RelatedSpacesResponseBodyItemsVisitorInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTeamMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: number;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'number',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveTeamMembersResponseBodyNotInOrgMembers extends $tea.Model {
  memberId?: string;
  memberType?: number;
  name?: string;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      name: 'name',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'number',
      name: 'string',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveTeamMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: number;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'number',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveTeamMembersResponseBodyNotInOrgMembers extends $tea.Model {
  memberId?: string;
  memberType?: number;
  name?: string;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      name: 'name',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'number',
      name: 'string',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchRequestDentryRequestVisitTimeRange extends $tea.Model {
  end?: number;
  start?: number;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      start: 'start',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: 'number',
      start: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchRequestDentryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  searchField?: number;
  searchFileType?: number;
  spaceId?: string;
  spaceIds?: string[];
  summaryLength?: number;
  visitTimeRange?: SearchRequestDentryRequestVisitTimeRange;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      searchField: 'searchField',
      searchFileType: 'searchFileType',
      spaceId: 'spaceId',
      spaceIds: 'spaceIds',
      summaryLength: 'summaryLength',
      visitTimeRange: 'visitTimeRange',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      searchField: 'number',
      searchFileType: 'number',
      spaceId: 'string',
      spaceIds: { 'type': 'array', 'itemType': 'string' },
      summaryLength: 'number',
      visitTimeRange: SearchRequestDentryRequestVisitTimeRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchRequestSpaceRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  withTeamInfo?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      withTeamInfo: 'withTeamInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      withTeamInfo: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBodyDentryResultItems extends $tea.Model {
  content?: string;
  creation?: OpenActionModel;
  dentryId?: string;
  dentryUuid?: string;
  extension?: string;
  iconUrl?: string;
  lastEdition?: OpenActionModel;
  name?: string;
  originName?: string;
  path?: string;
  sceneType?: number;
  searchFileType?: number;
  spaceId?: string;
  thumbnailUrl?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      creation: 'creation',
      dentryId: 'dentryId',
      dentryUuid: 'dentryUuid',
      extension: 'extension',
      iconUrl: 'iconUrl',
      lastEdition: 'lastEdition',
      name: 'name',
      originName: 'originName',
      path: 'path',
      sceneType: 'sceneType',
      searchFileType: 'searchFileType',
      spaceId: 'spaceId',
      thumbnailUrl: 'thumbnailUrl',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      creation: OpenActionModel,
      dentryId: 'string',
      dentryUuid: 'string',
      extension: 'string',
      iconUrl: 'string',
      lastEdition: OpenActionModel,
      name: 'string',
      originName: 'string',
      path: 'string',
      sceneType: 'number',
      searchFileType: 'number',
      spaceId: 'string',
      thumbnailUrl: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBodyDentryResult extends $tea.Model {
  hasMore?: boolean;
  items?: SearchResponseBodyDentryResultItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': SearchResponseBodyDentryResultItems },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBodySpaceResultItemsIconVO extends $tea.Model {
  icon?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBodySpaceResultItemsTeamVO extends $tea.Model {
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

export class SearchResponseBodySpaceResultItemsUserLastOperation extends $tea.Model {
  name?: string;
  time?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      time: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBodySpaceResultItems extends $tea.Model {
  iconVO?: SearchResponseBodySpaceResultItemsIconVO;
  name?: string;
  originName?: string;
  spaceId?: string;
  teamVO?: SearchResponseBodySpaceResultItemsTeamVO;
  url?: string;
  userLastOperation?: SearchResponseBodySpaceResultItemsUserLastOperation;
  static names(): { [key: string]: string } {
    return {
      iconVO: 'iconVO',
      name: 'name',
      originName: 'originName',
      spaceId: 'spaceId',
      teamVO: 'teamVO',
      url: 'url',
      userLastOperation: 'userLastOperation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      iconVO: SearchResponseBodySpaceResultItemsIconVO,
      name: 'string',
      originName: 'string',
      spaceId: 'string',
      teamVO: SearchResponseBodySpaceResultItemsTeamVO,
      url: 'string',
      userLastOperation: SearchResponseBodySpaceResultItemsUserLastOperation,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResponseBodySpaceResult extends $tea.Model {
  hasMore?: boolean;
  items?: SearchResponseBodySpaceResultItems[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      items: 'items',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': SearchResponseBodySpaceResultItems },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesRequestOption extends $tea.Model {
  excludeWorkspaceIds?: string[];
  maxResults?: number;
  nextToken?: string;
  platform?: string;
  templateTypes?: number[];
  version?: number;
  workspaceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      excludeWorkspaceIds: 'excludeWorkspaceIds',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      platform: 'platform',
      templateTypes: 'templateTypes',
      version: 'version',
      workspaceIds: 'workspaceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      excludeWorkspaceIds: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      nextToken: 'string',
      platform: 'string',
      templateTypes: { 'type': 'array', 'itemType': 'number' },
      version: 'number',
      workspaceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesRequestParam extends $tea.Model {
  belong?: string;
  searchName?: string;
  static names(): { [key: string]: string } {
    return {
      belong: 'belong',
      searchName: 'searchName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belong: 'string',
      searchName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchTemplatesResponseBodyTemplateList extends $tea.Model {
  authorName?: string;
  belong?: string;
  contentDownloadUrl?: string;
  coverDownloadUrl?: string;
  createTime?: string;
  description?: string;
  modifiedTime?: string;
  templateId?: string;
  title?: string;
  type?: number;
  usedCount?: number;
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      authorName: 'authorName',
      belong: 'belong',
      contentDownloadUrl: 'contentDownloadUrl',
      coverDownloadUrl: 'coverDownloadUrl',
      createTime: 'createTime',
      description: 'description',
      modifiedTime: 'modifiedTime',
      templateId: 'templateId',
      title: 'title',
      type: 'type',
      usedCount: 'usedCount',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorName: 'string',
      belong: 'string',
      contentDownloadUrl: 'string',
      coverDownloadUrl: 'string',
      createTime: 'string',
      description: 'string',
      modifiedTime: 'string',
      templateId: 'string',
      title: 'string',
      type: 'number',
      usedCount: 'number',
      workspaceId: 'string',
      workspaceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesRequestOption extends $tea.Model {
  excludeWorkspaceIds?: string[];
  maxResults?: number;
  nextToken?: string;
  platform?: string;
  templateTypes?: number[];
  version?: number;
  workspaceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      excludeWorkspaceIds: 'excludeWorkspaceIds',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      platform: 'platform',
      templateTypes: 'templateTypes',
      version: 'version',
      workspaceIds: 'workspaceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      excludeWorkspaceIds: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      nextToken: 'string',
      platform: 'string',
      templateTypes: { 'type': 'array', 'itemType': 'number' },
      version: 'number',
      workspaceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesResponseBodyTemplateList extends $tea.Model {
  authorName?: string;
  belong?: string;
  contentDownloadUrl?: string;
  coverDownloadUrl?: string;
  createTime?: string;
  description?: string;
  modifiedTime?: string;
  templateId?: string;
  title?: string;
  type?: number;
  usedCount?: number;
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      authorName: 'authorName',
      belong: 'belong',
      contentDownloadUrl: 'contentDownloadUrl',
      coverDownloadUrl: 'coverDownloadUrl',
      createTime: 'createTime',
      description: 'description',
      modifiedTime: 'modifiedTime',
      templateId: 'templateId',
      title: 'title',
      type: 'type',
      usedCount: 'usedCount',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorName: 'string',
      belong: 'string',
      contentDownloadUrl: 'string',
      coverDownloadUrl: 'string',
      createTime: 'string',
      description: 'string',
      modifiedTime: 'string',
      templateId: 'string',
      title: 'string',
      type: 'number',
      usedCount: 'number',
      workspaceId: 'string',
      workspaceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesRequestOption extends $tea.Model {
  categoryStatus?: number;
  industryId?: number;
  static names(): { [key: string]: string } {
    return {
      categoryStatus: 'categoryStatus',
      industryId: 'industryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryStatus: 'number',
      industryId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesRequestParam extends $tea.Model {
  tenantId?: string;
  static names(): { [key: string]: string } {
    return {
      tenantId: 'tenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TemplateCategoriesResponseBodyList extends $tea.Model {
  categoryId?: string;
  categoryName?: string;
  sort?: string;
  static names(): { [key: string]: string } {
    return {
      categoryId: 'categoryId',
      categoryName: 'categoryName',
      sort: 'sort',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryId: 'string',
      categoryName: 'string',
      sort: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTemplatesRequestOption extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  platform?: string;
  templateTypes?: number[];
  version?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      platform: 'platform',
      templateTypes: 'templateTypes',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      platform: 'string',
      templateTypes: { 'type': 'array', 'itemType': 'number' },
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTemplatesResponseBodyTemplateList extends $tea.Model {
  authorName?: string;
  belong?: string;
  contentDownloadUrl?: string;
  coverDownloadUrl?: string;
  createTime?: string;
  description?: string;
  modifiedTime?: string;
  templateId?: string;
  title?: string;
  type?: number;
  usedCount?: number;
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      authorName: 'authorName',
      belong: 'belong',
      contentDownloadUrl: 'contentDownloadUrl',
      coverDownloadUrl: 'coverDownloadUrl',
      createTime: 'createTime',
      description: 'description',
      modifiedTime: 'modifiedTime',
      templateId: 'templateId',
      title: 'title',
      type: 'type',
      usedCount: 'usedCount',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorName: 'string',
      belong: 'string',
      contentDownloadUrl: 'string',
      coverDownloadUrl: 'string',
      createTime: 'string',
      description: 'string',
      modifiedTime: 'string',
      templateId: 'string',
      title: 'string',
      type: 'number',
      usedCount: 'number',
      workspaceId: 'string',
      workspaceName: 'string',
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


  async batchCreateTeamWithOptions(request: BatchCreateTeamRequest, headers: BatchCreateTeamHeaders, runtime: $Util.RuntimeOptions): Promise<BatchCreateTeamResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "BatchCreateTeam",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchCreateTeamResponse>(await this.execute(params, req, runtime), new BatchCreateTeamResponse({}));
  }

  async batchCreateTeam(request: BatchCreateTeamRequest): Promise<BatchCreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateTeamHeaders({ });
    return await this.batchCreateTeamWithOptions(request, headers, runtime);
  }

  async batchDeleteRecentsWithOptions(request: BatchDeleteRecentsRequest, headers: BatchDeleteRecentsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchDeleteRecentsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryUuids)) {
      body["dentryUuids"] = request.dentryUuids;
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
      action: "BatchDeleteRecents",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/recentRecords/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchDeleteRecentsResponse>(await this.execute(params, req, runtime), new BatchDeleteRecentsResponse({}));
  }

  async batchDeleteRecents(request: BatchDeleteRecentsRequest): Promise<BatchDeleteRecentsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteRecentsHeaders({ });
    return await this.batchDeleteRecentsWithOptions(request, headers, runtime);
  }

  async categoriesTemplatesWithOptions(request: CategoriesTemplatesRequest, headers: CategoriesTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<CategoriesTemplatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "CategoriesTemplates",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/categoryLists/templates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CategoriesTemplatesResponse>(await this.execute(params, req, runtime), new CategoriesTemplatesResponse({}));
  }

  async categoriesTemplates(request: CategoriesTemplatesRequest): Promise<CategoriesTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CategoriesTemplatesHeaders({ });
    return await this.categoriesTemplatesWithOptions(request, headers, runtime);
  }

  async categoryTemplatesWithOptions(request: CategoryTemplatesRequest, headers: CategoryTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<CategoryTemplatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "CategoryTemplates",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/categories/templates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CategoryTemplatesResponse>(await this.execute(params, req, runtime), new CategoryTemplatesResponse({}));
  }

  async categoryTemplates(request: CategoryTemplatesRequest): Promise<CategoryTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CategoryTemplatesHeaders({ });
    return await this.categoryTemplatesWithOptions(request, headers, runtime);
  }

  async copyDentryWithOptions(spaceId: string, dentryId: string, request: CopyDentryRequest, headers: CopyDentryHeaders, runtime: $Util.RuntimeOptions): Promise<CopyDentryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.toNextDentryId)) {
      body["toNextDentryId"] = request.toNextDentryId;
    }

    if (!Util.isUnset(request.toParentDentryId)) {
      body["toParentDentryId"] = request.toParentDentryId;
    }

    if (!Util.isUnset(request.toPrevDentryId)) {
      body["toPrevDentryId"] = request.toPrevDentryId;
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
      action: "CopyDentry",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}/copy`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CopyDentryResponse>(await this.execute(params, req, runtime), new CopyDentryResponse({}));
  }

  async copyDentry(spaceId: string, dentryId: string, request: CopyDentryRequest): Promise<CopyDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyDentryHeaders({ });
    return await this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async createDentryWithOptions(spaceId: string, request: CreateDentryRequest, headers: CreateDentryHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDentryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryType)) {
      body["dentryType"] = request.dentryType;
    }

    if (!Util.isUnset(request.documentType)) {
      body["documentType"] = request.documentType;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.parentDentryId)) {
      body["parentDentryId"] = request.parentDentryId;
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
      action: "CreateDentry",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/dentries`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDentryResponse>(await this.execute(params, req, runtime), new CreateDentryResponse({}));
  }

  async createDentry(spaceId: string, request: CreateDentryRequest): Promise<CreateDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDentryHeaders({ });
    return await this.createDentryWithOptions(spaceId, request, headers, runtime);
  }

  async createSpaceWithOptions(request: CreateSpaceRequest, headers: CreateSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.sectionId)) {
      body["sectionId"] = request.sectionId;
    }

    if (!Util.isUnset(request.shareScope)) {
      body["shareScope"] = request.shareScope;
    }

    if (!Util.isUnset(request.teamId)) {
      body["teamId"] = request.teamId;
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
      action: "CreateSpace",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSpaceResponse>(await this.execute(params, req, runtime), new CreateSpaceResponse({}));
  }

  async createSpace(request: CreateSpaceRequest): Promise<CreateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSpaceHeaders({ });
    return await this.createSpaceWithOptions(request, headers, runtime);
  }

  async createTeamWithOptions(request: CreateTeamRequest, headers: CreateTeamHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTeamResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cover)) {
      body["cover"] = request.cover;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.teamType)) {
      body["teamType"] = request.teamType;
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
      action: "CreateTeam",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTeamResponse>(await this.execute(params, req, runtime), new CreateTeamResponse({}));
  }

  async createTeam(request: CreateTeamRequest): Promise<CreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTeamHeaders({ });
    return await this.createTeamWithOptions(request, headers, runtime);
  }

  async crossOrgMigrateWithOptions(request: CrossOrgMigrateRequest, headers: CrossOrgMigrateHeaders, runtime: $Util.RuntimeOptions): Promise<CrossOrgMigrateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "CrossOrgMigrate",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/crossOrganizations/spaces/migrate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CrossOrgMigrateResponse>(await this.execute(params, req, runtime), new CrossOrgMigrateResponse({}));
  }

  async crossOrgMigrate(request: CrossOrgMigrateRequest): Promise<CrossOrgMigrateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CrossOrgMigrateHeaders({ });
    return await this.crossOrgMigrateWithOptions(request, headers, runtime);
  }

  async deleteTeamWithOptions(teamId: string, request: DeleteTeamRequest, headers: DeleteTeamHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTeamResponse> {
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
      action: "DeleteTeam",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteTeamResponse>(await this.execute(params, req, runtime), new DeleteTeamResponse({}));
  }

  async deleteTeam(teamId: string, request: DeleteTeamRequest): Promise<DeleteTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTeamHeaders({ });
    return await this.deleteTeamWithOptions(teamId, request, headers, runtime);
  }

  async docContentWithOptions(dentryUuid: string, request: DocContentRequest, headers: DocContentHeaders, runtime: $Util.RuntimeOptions): Promise<DocContentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "DocContent",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/${dentryUuid}/contents`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocContentResponse>(await this.execute(params, req, runtime), new DocContentResponse({}));
  }

  async docContent(dentryUuid: string, request: DocContentRequest): Promise<DocContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocContentHeaders({ });
    return await this.docContentWithOptions(dentryUuid, request, headers, runtime);
  }

  async getDocContentWithOptions(dentryUuid: string, request: GetDocContentRequest, headers: GetDocContentHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocContentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetFormat)) {
      query["targetFormat"] = request.targetFormat;
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
      action: "GetDocContent",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/me/query/${dentryUuid}/contents`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDocContentResponse>(await this.execute(params, req, runtime), new GetDocContentResponse({}));
  }

  async getDocContent(dentryUuid: string, request: GetDocContentRequest): Promise<GetDocContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocContentHeaders({ });
    return await this.getDocContentWithOptions(dentryUuid, request, headers, runtime);
  }

  async getSchemaWithOptions(teamId: string, request: GetSchemaRequest, headers: GetSchemaHeaders, runtime: $Util.RuntimeOptions): Promise<GetSchemaResponse> {
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
      action: "GetSchema",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/schemas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSchemaResponse>(await this.execute(params, req, runtime), new GetSchemaResponse({}));
  }

  async getSchema(teamId: string, request: GetSchemaRequest): Promise<GetSchemaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSchemaHeaders({ });
    return await this.getSchemaWithOptions(teamId, request, headers, runtime);
  }

  async getSpaceDirectoriesWithOptions(spaceId: string, request: GetSpaceDirectoriesRequest, headers: GetSpaceDirectoriesHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceDirectoriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryId)) {
      query["dentryId"] = request.dentryId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

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
      action: "GetSpaceDirectories",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/directories`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceDirectoriesResponse>(await this.execute(params, req, runtime), new GetSpaceDirectoriesResponse({}));
  }

  async getSpaceDirectories(spaceId: string, request: GetSpaceDirectoriesRequest): Promise<GetSpaceDirectoriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceDirectoriesHeaders({ });
    return await this.getSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
  }

  async getStarInfoWithOptions(dentryUuid: string, request: GetStarInfoRequest, headers: GetStarInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetStarInfoResponse> {
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
      action: "GetStarInfo",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/${dentryUuid}/starInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetStarInfoResponse>(await this.execute(params, req, runtime), new GetStarInfoResponse({}));
  }

  async getStarInfo(dentryUuid: string, request: GetStarInfoRequest): Promise<GetStarInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStarInfoHeaders({ });
    return await this.getStarInfoWithOptions(dentryUuid, request, headers, runtime);
  }

  async getTeamWithOptions(teamId: string, request: GetTeamRequest, headers: GetTeamHeaders, runtime: $Util.RuntimeOptions): Promise<GetTeamResponse> {
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
      action: "GetTeam",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTeamResponse>(await this.execute(params, req, runtime), new GetTeamResponse({}));
  }

  async getTeam(teamId: string, request: GetTeamRequest): Promise<GetTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTeamHeaders({ });
    return await this.getTeamWithOptions(teamId, request, headers, runtime);
  }

  async getTotalNumberOfDentriesWithOptions(request: GetTotalNumberOfDentriesRequest, headers: GetTotalNumberOfDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<GetTotalNumberOfDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.includeFolder)) {
      query["includeFolder"] = request.includeFolder;
    }

    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.spaceTypes)) {
      query["spaceTypes"] = request.spaceTypes;
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
      action: "GetTotalNumberOfDentries",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/statistics/dentryCounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTotalNumberOfDentriesResponse>(await this.execute(params, req, runtime), new GetTotalNumberOfDentriesResponse({}));
  }

  async getTotalNumberOfDentries(request: GetTotalNumberOfDentriesRequest): Promise<GetTotalNumberOfDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTotalNumberOfDentriesHeaders({ });
    return await this.getTotalNumberOfDentriesWithOptions(request, headers, runtime);
  }

  async getTotalNumberOfSpacesWithOptions(request: GetTotalNumberOfSpacesRequest, headers: GetTotalNumberOfSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<GetTotalNumberOfSpacesResponse> {
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
      action: "GetTotalNumberOfSpaces",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/statistics/spaceCounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTotalNumberOfSpacesResponse>(await this.execute(params, req, runtime), new GetTotalNumberOfSpacesResponse({}));
  }

  async getTotalNumberOfSpaces(request: GetTotalNumberOfSpacesRequest): Promise<GetTotalNumberOfSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTotalNumberOfSpacesHeaders({ });
    return await this.getTotalNumberOfSpacesWithOptions(request, headers, runtime);
  }

  async getUserInfoByOpenTokenWithOptions(request: GetUserInfoByOpenTokenRequest, headers: GetUserInfoByOpenTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserInfoByOpenTokenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.docKey)) {
      query["docKey"] = request.docKey;
    }

    if (!Util.isUnset(request.openToken)) {
      query["openToken"] = request.openToken;
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
      action: "GetUserInfoByOpenToken",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/userInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserInfoByOpenTokenResponse>(await this.execute(params, req, runtime), new GetUserInfoByOpenTokenResponse({}));
  }

  async getUserInfoByOpenToken(request: GetUserInfoByOpenTokenRequest): Promise<GetUserInfoByOpenTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserInfoByOpenTokenHeaders({ });
    return await this.getUserInfoByOpenTokenWithOptions(request, headers, runtime);
  }

  async listFeedsWithOptions(teamId: string, request: ListFeedsRequest, headers: ListFeedsHeaders, runtime: $Util.RuntimeOptions): Promise<ListFeedsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.excludeFile)) {
      query["excludeFile"] = request.excludeFile;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

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
      action: "ListFeeds",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/feeds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListFeedsResponse>(await this.execute(params, req, runtime), new ListFeedsResponse({}));
  }

  async listFeeds(teamId: string, request: ListFeedsRequest): Promise<ListFeedsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFeedsHeaders({ });
    return await this.listFeedsWithOptions(teamId, request, headers, runtime);
  }

  async listHotDocsWithOptions(teamId: string, request: ListHotDocsRequest, headers: ListHotDocsHeaders, runtime: $Util.RuntimeOptions): Promise<ListHotDocsResponse> {
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
      action: "ListHotDocs",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/hotDocs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListHotDocsResponse>(await this.execute(params, req, runtime), new ListHotDocsResponse({}));
  }

  async listHotDocs(teamId: string, request: ListHotDocsRequest): Promise<ListHotDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListHotDocsHeaders({ });
    return await this.listHotDocsWithOptions(teamId, request, headers, runtime);
  }

  async listPinSpacesWithOptions(request: ListPinSpacesRequest, headers: ListPinSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<ListPinSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "ListPinSpaces",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/pinLists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListPinSpacesResponse>(await this.execute(params, req, runtime), new ListPinSpacesResponse({}));
  }

  async listPinSpaces(request: ListPinSpacesRequest): Promise<ListPinSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPinSpacesHeaders({ });
    return await this.listPinSpacesWithOptions(request, headers, runtime);
  }

  async listRelatedSpaceTeamsWithOptions(request: ListRelatedSpaceTeamsRequest, headers: ListRelatedSpaceTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListRelatedSpaceTeamsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
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
      action: "ListRelatedSpaceTeams",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/relations/spaceTeams`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListRelatedSpaceTeamsResponse>(await this.execute(params, req, runtime), new ListRelatedSpaceTeamsResponse({}));
  }

  async listRelatedSpaceTeams(request: ListRelatedSpaceTeamsRequest): Promise<ListRelatedSpaceTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRelatedSpaceTeamsHeaders({ });
    return await this.listRelatedSpaceTeamsWithOptions(request, headers, runtime);
  }

  async listRelatedTeamsWithOptions(request: ListRelatedTeamsRequest, headers: ListRelatedTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListRelatedTeamsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
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
      action: "ListRelatedTeams",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListRelatedTeamsResponse>(await this.execute(params, req, runtime), new ListRelatedTeamsResponse({}));
  }

  async listRelatedTeams(request: ListRelatedTeamsRequest): Promise<ListRelatedTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRelatedTeamsHeaders({ });
    return await this.listRelatedTeamsWithOptions(request, headers, runtime);
  }

  async listSpaceSectionsWithOptions(teamId: string, request: ListSpaceSectionsRequest, headers: ListSpaceSectionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSpaceSectionsResponse> {
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
      action: "ListSpaceSections",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/spaceSections`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListSpaceSectionsResponse>(await this.execute(params, req, runtime), new ListSpaceSectionsResponse({}));
  }

  async listSpaceSections(teamId: string, request: ListSpaceSectionsRequest): Promise<ListSpaceSectionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSpaceSectionsHeaders({ });
    return await this.listSpaceSectionsWithOptions(teamId, request, headers, runtime);
  }

  async listStarsWithOptions(request: ListStarsRequest, headers: ListStarsHeaders, runtime: $Util.RuntimeOptions): Promise<ListStarsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "ListStars",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/starLists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListStarsResponse>(await this.execute(params, req, runtime), new ListStarsResponse({}));
  }

  async listStars(request: ListStarsRequest): Promise<ListStarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListStarsHeaders({ });
    return await this.listStarsWithOptions(request, headers, runtime);
  }

  async listTeamMembersWithOptions(teamId: string, request: ListTeamMembersRequest, headers: ListTeamMembersHeaders, runtime: $Util.RuntimeOptions): Promise<ListTeamMembersResponse> {
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
      action: "ListTeamMembers",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListTeamMembersResponse>(await this.execute(params, req, runtime), new ListTeamMembersResponse({}));
  }

  async listTeamMembers(teamId: string, request: ListTeamMembersRequest): Promise<ListTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTeamMembersHeaders({ });
    return await this.listTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  async markStarWithOptions(dentryUuid: string, request: MarkStarRequest, headers: MarkStarHeaders, runtime: $Util.RuntimeOptions): Promise<MarkStarResponse> {
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
      action: "MarkStar",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/${dentryUuid}/stars/mark`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MarkStarResponse>(await this.execute(params, req, runtime), new MarkStarResponse({}));
  }

  async markStar(dentryUuid: string, request: MarkStarRequest): Promise<MarkStarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MarkStarHeaders({ });
    return await this.markStarWithOptions(dentryUuid, request, headers, runtime);
  }

  async moveDentryWithOptions(spaceId: string, dentryId: string, request: MoveDentryRequest, headers: MoveDentryHeaders, runtime: $Util.RuntimeOptions): Promise<MoveDentryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.targetSpaceId)) {
      body["targetSpaceId"] = request.targetSpaceId;
    }

    if (!Util.isUnset(request.toNextDentryId)) {
      body["toNextDentryId"] = request.toNextDentryId;
    }

    if (!Util.isUnset(request.toParentDentryId)) {
      body["toParentDentryId"] = request.toParentDentryId;
    }

    if (!Util.isUnset(request.toPrevDentryId)) {
      body["toPrevDentryId"] = request.toPrevDentryId;
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
      action: "MoveDentry",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}/move`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MoveDentryResponse>(await this.execute(params, req, runtime), new MoveDentryResponse({}));
  }

  async moveDentry(spaceId: string, dentryId: string, request: MoveDentryRequest): Promise<MoveDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MoveDentryHeaders({ });
    return await this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async pinSpaceWithOptions(spaceId: string, request: PinSpaceRequest, headers: PinSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<PinSpaceResponse> {
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
      action: "PinSpace",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/pin`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PinSpaceResponse>(await this.execute(params, req, runtime), new PinSpaceResponse({}));
  }

  async pinSpace(spaceId: string, request: PinSpaceRequest): Promise<PinSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PinSpaceHeaders({ });
    return await this.pinSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async queryDentryWithOptions(spaceId: string, dentryId: string, request: QueryDentryRequest, headers: QueryDentryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.includeSpace)) {
      query["includeSpace"] = request.includeSpace;
    }

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
      action: "QueryDentry",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDentryResponse>(await this.execute(params, req, runtime), new QueryDentryResponse({}));
  }

  async queryDentry(spaceId: string, dentryId: string, request: QueryDentryRequest): Promise<QueryDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDentryHeaders({ });
    return await this.queryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async queryDocContentWithOptions(dentryUuid: string, request: QueryDocContentRequest, headers: QueryDocContentHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDocContentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.targetFormat)) {
      query["targetFormat"] = request.targetFormat;
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
      action: "QueryDocContent",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/query/${dentryUuid}/contents`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDocContentResponse>(await this.execute(params, req, runtime), new QueryDocContentResponse({}));
  }

  async queryDocContent(dentryUuid: string, request: QueryDocContentRequest): Promise<QueryDocContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDocContentHeaders({ });
    return await this.queryDocContentWithOptions(dentryUuid, request, headers, runtime);
  }

  async queryItemByUrlWithOptions(request: QueryItemByUrlRequest, headers: QueryItemByUrlHeaders, runtime: $Util.RuntimeOptions): Promise<QueryItemByUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.url)) {
      query["url"] = request.url;
    }

    if (!Util.isUnset(request.withStatisticalInfo)) {
      query["withStatisticalInfo"] = request.withStatisticalInfo;
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
      action: "QueryItemByUrl",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/items`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryItemByUrlResponse>(await this.execute(params, req, runtime), new QueryItemByUrlResponse({}));
  }

  async queryItemByUrl(request: QueryItemByUrlRequest): Promise<QueryItemByUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryItemByUrlHeaders({ });
    return await this.queryItemByUrlWithOptions(request, headers, runtime);
  }

  async queryMineSpaceWithOptions(unionId: string, headers: QueryMineSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMineSpaceResponse> {
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
      action: "QueryMineSpace",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/users/${unionId}/mine`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMineSpaceResponse>(await this.execute(params, req, runtime), new QueryMineSpaceResponse({}));
  }

  async queryMineSpace(unionId: string): Promise<QueryMineSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMineSpaceHeaders({ });
    return await this.queryMineSpaceWithOptions(unionId, headers, runtime);
  }

  async queryRecentListWithOptions(request: QueryRecentListRequest, headers: QueryRecentListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRecentListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorType)) {
      query["creatorType"] = request.creatorType;
    }

    if (!Util.isUnset(request.fileType)) {
      query["fileType"] = request.fileType;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.recentType)) {
      query["recentType"] = request.recentType;
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
      action: "QueryRecentList",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/docs/recent`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRecentListResponse>(await this.execute(params, req, runtime), new QueryRecentListResponse({}));
  }

  async queryRecentList(request: QueryRecentListRequest): Promise<QueryRecentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRecentListHeaders({ });
    return await this.queryRecentListWithOptions(request, headers, runtime);
  }

  async querySpaceWithOptions(spaceId: string, request: QuerySpaceRequest, headers: QuerySpaceHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySpaceResponse> {
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
      action: "QuerySpace",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySpaceResponse>(await this.execute(params, req, runtime), new QuerySpaceResponse({}));
  }

  async querySpace(spaceId: string, request: QuerySpaceRequest): Promise<QuerySpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySpaceHeaders({ });
    return await this.querySpaceWithOptions(spaceId, request, headers, runtime);
  }

  async relatedSpacesWithOptions(request: RelatedSpacesRequest, headers: RelatedSpacesHeaders, runtime: $Util.RuntimeOptions): Promise<RelatedSpacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.teamId)) {
      query["teamId"] = request.teamId;
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
      action: "RelatedSpaces",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/relations/spaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RelatedSpacesResponse>(await this.execute(params, req, runtime), new RelatedSpacesResponse({}));
  }

  async relatedSpaces(request: RelatedSpacesRequest): Promise<RelatedSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RelatedSpacesHeaders({ });
    return await this.relatedSpacesWithOptions(request, headers, runtime);
  }

  async removeTeamMembersWithOptions(teamId: string, request: RemoveTeamMembersRequest, headers: RemoveTeamMembersHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveTeamMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.notify)) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
      action: "RemoveTeamMembers",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/members/remove`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveTeamMembersResponse>(await this.execute(params, req, runtime), new RemoveTeamMembersResponse({}));
  }

  async removeTeamMembers(teamId: string, request: RemoveTeamMembersRequest): Promise<RemoveTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveTeamMembersHeaders({ });
    return await this.removeTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  async renameDentryWithOptions(spaceId: string, dentryId: string, request: RenameDentryRequest, headers: RenameDentryHeaders, runtime: $Util.RuntimeOptions): Promise<RenameDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

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
      action: "RenameDentry",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}/rename`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RenameDentryResponse>(await this.execute(params, req, runtime), new RenameDentryResponse({}));
  }

  async renameDentry(spaceId: string, dentryId: string, request: RenameDentryRequest): Promise<RenameDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RenameDentryHeaders({ });
    return await this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async saveTeamMembersWithOptions(teamId: string, request: SaveTeamMembersRequest, headers: SaveTeamMembersHeaders, runtime: $Util.RuntimeOptions): Promise<SaveTeamMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.notify)) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
      action: "SaveTeamMembers",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}/members`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveTeamMembersResponse>(await this.execute(params, req, runtime), new SaveTeamMembersResponse({}));
  }

  async saveTeamMembers(teamId: string, request: SaveTeamMembersRequest): Promise<SaveTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveTeamMembersHeaders({ });
    return await this.saveTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  async searchWithOptions(request: SearchRequest, headers: SearchHeaders, runtime: $Util.RuntimeOptions): Promise<SearchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryRequest)) {
      body["dentryRequest"] = request.dentryRequest;
    }

    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.spaceRequest)) {
      body["spaceRequest"] = request.spaceRequest;
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
      action: "Search",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchResponse>(await this.execute(params, req, runtime), new SearchResponse({}));
  }

  async search(request: SearchRequest): Promise<SearchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchHeaders({ });
    return await this.searchWithOptions(request, headers, runtime);
  }

  async searchTemplatesWithOptions(request: SearchTemplatesRequest, headers: SearchTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<SearchTemplatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "SearchTemplates",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/templates/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchTemplatesResponse>(await this.execute(params, req, runtime), new SearchTemplatesResponse({}));
  }

  async searchTemplates(request: SearchTemplatesRequest): Promise<SearchTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTemplatesHeaders({ });
    return await this.searchTemplatesWithOptions(request, headers, runtime);
  }

  async teamTemplatesWithOptions(request: TeamTemplatesRequest, headers: TeamTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<TeamTemplatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "TeamTemplates",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/workspaces/templates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TeamTemplatesResponse>(await this.execute(params, req, runtime), new TeamTemplatesResponse({}));
  }

  async teamTemplates(request: TeamTemplatesRequest): Promise<TeamTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TeamTemplatesHeaders({ });
    return await this.teamTemplatesWithOptions(request, headers, runtime);
  }

  async templateCategoriesWithOptions(request: TemplateCategoriesRequest, headers: TemplateCategoriesHeaders, runtime: $Util.RuntimeOptions): Promise<TemplateCategoriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "TemplateCategories",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/templates/categories/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TemplateCategoriesResponse>(await this.execute(params, req, runtime), new TemplateCategoriesResponse({}));
  }

  async templateCategories(request: TemplateCategoriesRequest): Promise<TemplateCategoriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TemplateCategoriesHeaders({ });
    return await this.templateCategoriesWithOptions(request, headers, runtime);
  }

  async unmarkStarWithOptions(dentryUuid: string, request: UnmarkStarRequest, headers: UnmarkStarHeaders, runtime: $Util.RuntimeOptions): Promise<UnmarkStarResponse> {
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
      action: "UnmarkStar",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/${dentryUuid}/stars/unmark`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnmarkStarResponse>(await this.execute(params, req, runtime), new UnmarkStarResponse({}));
  }

  async unmarkStar(dentryUuid: string, request: UnmarkStarRequest): Promise<UnmarkStarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnmarkStarHeaders({ });
    return await this.unmarkStarWithOptions(dentryUuid, request, headers, runtime);
  }

  async unpinSpaceWithOptions(spaceId: string, request: UnpinSpaceRequest, headers: UnpinSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<UnpinSpaceResponse> {
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
      action: "UnpinSpace",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/spaces/${spaceId}/unpin`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnpinSpaceResponse>(await this.execute(params, req, runtime), new UnpinSpaceResponse({}));
  }

  async unpinSpace(spaceId: string, request: UnpinSpaceRequest): Promise<UnpinSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnpinSpaceHeaders({ });
    return await this.unpinSpaceWithOptions(spaceId, request, headers, runtime);
  }

  async updateTeamWithOptions(teamId: string, request: UpdateTeamRequest, headers: UpdateTeamHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTeamResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
      action: "UpdateTeam",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/${teamId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTeamResponse>(await this.execute(params, req, runtime), new UpdateTeamResponse({}));
  }

  async updateTeam(teamId: string, request: UpdateTeamRequest): Promise<UpdateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTeamHeaders({ });
    return await this.updateTeamWithOptions(teamId, request, headers, runtime);
  }

  async userTemplatesWithOptions(request: UserTemplatesRequest, headers: UserTemplatesHeaders, runtime: $Util.RuntimeOptions): Promise<UserTemplatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "UserTemplates",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/users/templates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UserTemplatesResponse>(await this.execute(params, req, runtime), new UserTemplatesResponse({}));
  }

  async userTemplates(request: UserTemplatesRequest): Promise<UserTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserTemplatesHeaders({ });
    return await this.userTemplatesWithOptions(request, headers, runtime);
  }

}
