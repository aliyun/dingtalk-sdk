// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class DentryModel extends $tea.Model {
  /**
   * @example
   * alidoc
   */
  contentType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1663918630284
   */
  createdTime?: number;
  creator?: DentryModelCreator;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YRBd*****KGDA
   */
  dentryId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * file
   */
  dentryType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6or0dp8Z****XWa91xzy3
   */
  dentryUuid?: string;
  /**
   * @example
   * v1GXn****KqD4
   */
  docKey?: string;
  /**
   * @example
   * adoc
   */
  extension?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  hasChildren?: boolean;
  linkSourceInfo?: LinkSourceInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉文档
   */
  name?: string;
  /**
   * @example
   * 测试组织/测试知识库/abc
   */
  path?: string;
  space?: SpaceModel;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YGv0****0xXAr
   */
  spaceId?: string;
  statisticalInfo?: DentryModelStatisticalInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1663918630284
   */
  updatedTime?: number;
  updater?: DentryModelUpdater;
  /**
   * @example
   * https://xxx.yy
   */
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
  /**
   * @example
   * alidoc
   */
  contentType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1663918630284
   */
  createdTime?: number;
  creator?: DentryVOCreator;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YRBd*****KGDA
   */
  dentryId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * file
   */
  dentryType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6or0dp8Z****XWa91xzy3
   */
  dentryUuid?: string;
  /**
   * @example
   * v1GXn****KqD4
   */
  docKey?: string;
  /**
   * @example
   * alidoc
   */
  extension?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  hasChildren?: boolean;
  linkSourceInfo?: LinkSourceInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉文档
   */
  name?: string;
  /**
   * @example
   * 测试组织/测试知识库/abc
   */
  path?: string;
  space?: SpaceModel;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YGv0****0xXAr
   */
  spaceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1663918630284
   */
  updatedTime?: number;
  updater?: DentryVOUpdater;
  /**
   * @example
   * https://xxx.yy
   */
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
  /**
   * @example
   * docx
   */
  extension?: string;
  iconUrl?: LinkSourceInfoIconUrl;
  /**
   * @example
   * abc
   */
  id?: string;
  /**
   * @example
   * 0
   */
  linkType?: number;
  /**
   * @example
   * def
   */
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
  /**
   * @example
   * sky
   */
  name?: string;
  /**
   * @example
   * 273829092
   */
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
  /**
   * @example
   * https://img.abc.yyy
   */
  cover?: string;
  /**
   * @example
   * This is some description.
   */
  description?: string;
  hdIconVO?: SpaceModelHdIconVO;
  iconVO?: SpaceModelIconVO;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hello
   */
  name?: string;
  owner?: SpaceModelOwner;
  recentList?: DentryModel[];
  /**
   * @example
   * 1
   */
  type?: number;
  /**
   * @example
   * https://xx.yy
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hello
   */
  name?: string;
  owner?: SpaceVOOwner;
  /**
   * @example
   * 1
   */
  type?: number;
  /**
   * @example
   * https://xx.yy
   */
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
  /**
   * @example
   * https://abc.com
   */
  cover?: string;
  /**
   * @example
   * 12340000
   */
  createdTime?: number;
  creator?: TeamModelCreator;
  /**
   * @example
   * 这里是团队描述
   */
  description?: string;
  /**
   * @example
   * https://def.com
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AbcDef
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试团队名称
   */
  name?: string;
  relatedDeptInfo?: TeamModelRelatedDeptInfo;
  /**
   * @example
   * 0
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  type?: number;
  /**
   * @example
   * 34560000
   */
  updatedTime?: number;
  updater?: TeamModelUpdater;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://abc.com
   */
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
  /**
   * @example
   * https://abc.com
   */
  cover?: string;
  /**
   * @example
   * 12340000
   */
  createdTime?: number;
  creator?: TeamVOCreator;
  /**
   * @example
   * 这里是团队描述
   */
  description?: string;
  /**
   * @example
   * https://def.com
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * AbcDef
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试团队名称
   */
  name?: string;
  relatedDeptInfo?: TeamVORelatedDeptInfo;
  shareScopeInfo?: TeamVOShareScopeInfo;
  /**
   * @example
   * 0
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  type?: number;
  /**
   * @example
   * 34560000
   */
  updatedTime?: number;
  updater?: TeamVOUpdater;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://abc.com
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  param?: BatchCreateTeamRequestParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class BatchCreateTeamResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchCreateTeamResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  dentryUuids?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class BatchDeleteRecentsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchDeleteRecentsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  param?: CategoriesTemplatesRequestParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CategoriesTemplatesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  param?: CategoryTemplatesRequestParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CategoryTemplatesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DentryVO;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * file
   */
  dentryType?: string;
  /**
   * @example
   * 0
   */
  documentType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingtalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  operatorId?: string;
  /**
   * @example
   * abcedf
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DentryVO;
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
  /**
   * @example
   * 这里是知识库的简介
   */
  description?: string;
  /**
   * @example
   * https://img.alicdn.com/imgextra/i1/O1***.png
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试知识库
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  operatorId?: string;
  /**
   * @example
   * l6gYG9****mo9Z
   */
  sectionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  shareScope?: CreateSpaceRequestShareScope;
  /**
   * @example
   * 5YRB***GDAr
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SpaceVO;
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
  /**
   * @example
   * https://img.alicdn.com/imgextra/i1/O1***.png
   */
  cover?: string;
  /**
   * @example
   * 这是小组的介绍
   */
  description?: string;
  /**
   * @example
   * https://img.alicdn.com/imgextra/i1/O1***.png
   */
  icon?: string;
  members?: CreateTeamRequestMembers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试小组名称
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  operatorId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TeamVO;
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
  /**
   * @remarks
   * This parameter is required.
   */
  param?: CrossOrgMigrateRequestParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class CrossOrgMigrateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CrossOrgMigrateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TeamVO;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DocContentResponseBody;
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

export class GetDentryIdByUuidHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryIdByUuidRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class GetDentryIdByUuidResponseBody extends $tea.Model {
  dentryId?: string;
  dentryUuid?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      dentryUuid: 'dentryUuid',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      dentryUuid: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryIdByUuidResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDentryIdByUuidResponseBody;
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
      body: GetDentryIdByUuidResponseBody,
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
  /**
   * @example
   * false
   */
  generateCp?: boolean;
  /**
   * @example
   * markdown
   */
  targetFormat?: string;
  static names(): { [key: string]: string } {
    return {
      generateCp: 'generateCp',
      targetFormat: 'targetFormat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generateCp: 'boolean',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDocContentResponseBody;
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

export class GetDocContentForELMHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDocContentForELMRequest extends $tea.Model {
  /**
   * @example
   * markdown
   */
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

export class GetDocContentForELMResponseBody extends $tea.Model {
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

export class GetDocContentForELMResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDocContentForELMResponseBody;
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
      body: GetDocContentForELMResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMySpaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMySpaceRequest extends $tea.Model {
  /**
   * @example
   * true
   */
  isMySpace?: boolean;
  static names(): { [key: string]: string } {
    return {
      isMySpace: 'isMySpace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isMySpace: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMySpaceResponseBody extends $tea.Model {
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifyTime?: string;
  /**
   * @example
   * 1L
   */
  quota?: number;
  /**
   * @example
   * space_id
   */
  spaceId?: string;
  /**
   * @example
   * space_name
   */
  spaceName?: string;
  /**
   * @example
   * personal|org|custom|unknown
   */
  spaceType?: string;
  /**
   * @example
   * 1L
   */
  usedQuota?: number;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      modifyTime: 'modifyTime',
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

export class GetMySpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMySpaceResponseBody;
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
      body: GetMySpaceResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  /**
   * @example
   * 0
   */
  revision?: number;
  /**
   * @example
   * "{\"pageVersion\":\"1.0.0\",\"pageSchema\":{\"version\":\"1.0.0\",\"componentsMap\":[],\"componentsTree\":[]}}"
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSchemaResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpaceDirectoriesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetStarInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TeamVO;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTotalNumberOfDentriesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTotalNumberOfSpacesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  docKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserInfoByOpenTokenResponseBody;
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

export class GetUuidByDentryIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUuidByDentryIdRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  operatorId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1L
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUuidByDentryIdResponseBody extends $tea.Model {
  dentryId?: string;
  dentryUuid?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      dentryUuid: 'dentryUuid',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      dentryUuid: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUuidByDentryIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUuidByDentryIdResponseBody;
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
      body: GetUuidByDentryIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HandoverTeamWithoutAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HandoverTeamWithoutAuthRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  param?: HandoverTeamWithoutAuthRequestParam;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: HandoverTeamWithoutAuthRequestParam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HandoverTeamWithoutAuthResponseBody extends $tea.Model {
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

export class HandoverTeamWithoutAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HandoverTeamWithoutAuthResponseBody;
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
      body: HandoverTeamWithoutAuthResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  /**
   * @example
   * abcdef
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListFeedsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListHotDocsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * next_token
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListPinSpacesResponseBody;
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

export class ListRecentsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecentsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  param?: ListRecentsRequestParam;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: ListRecentsRequestParam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecentsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * nextToken
   */
  nextToken?: string;
  /**
   * @example
   * recentDentryList
   */
  recentDentryList?: ListRecentsResponseBodyRecentDentryList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      recentDentryList: 'recentDentryList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      recentDentryList: { 'type': 'array', 'itemType': ListRecentsResponseBodyRecentDentryList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecentsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListRecentsResponseBody;
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
      body: ListRecentsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListRelatedSpaceTeamsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * ajYkbc7
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  operatorId?: string;
  /**
   * @example
   * 0
   */
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
  /**
   * @example
   * cjk72iEakdim
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListRelatedTeamsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSpaceSectionsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * next_token
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListStarsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  /**
   * @example
   * 测试小组名称
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListTeamMembersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class MarkStarResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MarkStarResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  operatorId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DentryVO;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class PinSpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PinSpaceResponseBody;
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
  /**
   * @example
   * false
   */
  includeSpace?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DentryVO;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
  operatorId?: string;
  /**
   * @example
   * markdown
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDocContentResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  operatorId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://alidocs.dingtalk.com/i/nodes/m0Xw6OYE4D7VLeaBP***
   */
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
  /**
   * @example
   * mainsite
   */
  bizType?: string;
  dentry?: DentryModel;
  /**
   * @example
   * file
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryItemByUrlResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SpaceVO;
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRecentListResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SpaceVO;
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
  operatorId?: string;
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RelatedSpacesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  members?: RemoveTeamMembersRequestMembers[];
  notify?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveTeamMembersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DentryVO;
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
  /**
   * @remarks
   * This parameter is required.
   */
  members?: SaveTeamMembersRequestMembers[];
  notify?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveTeamMembersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试搜索关键词
   */
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  param?: SearchTemplatesRequestParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * next_token
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchTemplatesResponseBody;
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

export class ShareUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShareUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  param?: ShareUrlRequestParam;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: ShareUrlRequestParam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShareUrlResponseBody extends $tea.Model {
  /**
   * @example
   * shareUrlInfo
   */
  shareUrlInfo?: ShareUrlResponseBodyShareUrlInfo;
  static names(): { [key: string]: string } {
    return {
      shareUrlInfo: 'shareUrlInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shareUrlInfo: ShareUrlResponseBodyShareUrlInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShareUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ShareUrlResponseBody;
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
      body: ShareUrlResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * next_token
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TeamTemplatesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  param?: TemplateCategoriesRequestParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TemplateCategoriesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class UnmarkStarResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UnmarkStarResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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

export class UnpinSpaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UnpinSpaceResponseBody;
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
  /**
   * @example
   * 这是更新后的简介
   */
  description?: string;
  /**
   * @example
   * 更新后的名称
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TeamVO;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * union_id
   */
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
  /**
   * @example
   * next_token
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UserTemplatesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DingTalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DingTalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  /**
   * @example
   * 5
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DingTalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DingTalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
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
  /**
   * @example
   * 5
   */
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
  /**
   * @example
   * gh
   */
  line?: string;
  /**
   * @example
   * def
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://img.xxx.yyy
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * url
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://img.xxx.yyy
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * url
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingtalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  /**
   * @example
   * 3
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingtalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  /**
   * @example
   * 测试
   */
  name?: string;
  /**
   * @example
   * abcd
   */
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
  /**
   * @example
   * abc
   */
  deptId?: string;
  /**
   * @example
   * 测试部门
   */
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
  /**
   * @example
   * 测试
   */
  name?: string;
  /**
   * @example
   * abcd
   */
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  joinTime?: string;
  /**
   * @example
   * 5
   */
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
  /**
   * @example
   * 测试
   */
  name?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * abc
   */
  deptId?: string;
  /**
   * @example
   * 测试部门
   */
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
  /**
   * @example
   * 测试
   */
  name?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * 5
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * creator_union_id
   */
  creatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dept_id
   */
  deptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * team_name
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
  categoryStatus?: number;
  /**
   * @example
   * pc
   */
  queryPlatform?: string;
  /**
   * @example
   * 1
   */
  size?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * categoryIds
   */
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
  /**
   * @example
   * 1
   */
  categoryStatus?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * categoryId
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  memberId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  memberType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
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
  /**
   * @example
   * true
   */
  checkOperatorSourceRole?: boolean;
  /**
   * @example
   * true
   */
  deleteSource?: boolean;
  /**
   * @example
   * true
   */
  needRecycleFailedWorkspaceId?: boolean;
  /**
   * @example
   * 1L
   */
  relateTeamId?: number;
  /**
   * @example
   * team_id
   */
  relateTeamIdStr?: string;
  /**
   * @example
   * true
   */
  retainOrgGroup?: boolean;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * corp_id
   */
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
  /**
   * @example
   * markdown
   */
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

export class HandoverTeamWithoutAuthRequestParam extends $tea.Model {
  leave?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  newOwner?: string;
  notify?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      leave: 'leave',
      newOwner: 'newOwner',
      notify: 'notify',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      leave: 'boolean',
      newOwner: 'string',
      notify: 'boolean',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFeedsResponseBodyItems extends $tea.Model {
  /**
   * @example
   * "{}"
   */
  content?: string;
  /**
   * @example
   * 12340000
   */
  time?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * true
   */
  withSpaceCreatorInfo?: boolean;
  /**
   * @example
   * true
   */
  withSpaceModifierInfo?: boolean;
  /**
   * @example
   * true
   */
  withSpacePermissionRole?: boolean;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * user_name
   */
  name?: string;
  /**
   * @example
   * union_id
   */
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
  /**
   * @example
   * icon_url
   */
  icon?: string;
  /**
   * @example
   * URL
   */
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
  /**
   * @example
   * user_name
   */
  name?: string;
  /**
   * @example
   * union_id
   */
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
  /**
   * @example
   * space_cover
   */
  cover?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  creator?: ListPinSpacesResponseBodyResultItemsSpaceInfoCreator;
  /**
   * @example
   * description
   */
  description?: string;
  iconVO?: ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO;
  /**
   * @example
   * space_id
   */
  id?: string;
  /**
   * @example
   * mobile_url
   */
  mobileUrl?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  modifier?: ListPinSpacesResponseBodyResultItemsSpaceInfoModifier;
  /**
   * @example
   * space_name
   */
  name?: string;
  /**
   * @example
   * pc_url
   */
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
  /**
   * @example
   * team_id
   */
  id?: string;
  /**
   * @example
   * team_name
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

export class ListPinSpacesResponseBodyResultItems extends $tea.Model {
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
  spaceInfo?: ListPinSpacesResponseBodyResultItemsSpaceInfo;
  /**
   * @example
   * NO_PERMISSION
   */
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

export class ListRecentsRequestParam extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  fileTypes?: number[];
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * nextToken
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  operateTypes?: number[];
  static names(): { [key: string]: string } {
    return {
      fileTypes: 'fileTypes',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operateTypes: 'operateTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileTypes: { 'type': 'array', 'itemType': 'number' },
      maxResults: 'number',
      nextToken: 'string',
      operateTypes: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecentsResponseBodyRecentDentryListResourceSpaceInfo extends $tea.Model {
  /**
   * @example
   * im
   */
  sceneType?: string;
  static names(): { [key: string]: string } {
    return {
      sceneType: 'sceneType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sceneType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecentsResponseBodyRecentDentryListResource extends $tea.Model {
  /**
   * @example
   * dentryUuid
   */
  dentryUuid?: string;
  /**
   * @example
   * driveDentryId
   */
  driveDentryId?: string;
  /**
   * @example
   * driveSpaceId
   */
  driveSpaceId?: string;
  /**
   * @example
   * docx
   */
  extension?: string;
  /**
   * @example
   * name
   */
  name?: string;
  /**
   * @example
   * spaceInfo
   */
  spaceInfo?: ListRecentsResponseBodyRecentDentryListResourceSpaceInfo;
  /**
   * @example
   * https://example.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      dentryUuid: 'dentryUuid',
      driveDentryId: 'driveDentryId',
      driveSpaceId: 'driveSpaceId',
      extension: 'extension',
      name: 'name',
      spaceInfo: 'spaceInfo',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryUuid: 'string',
      driveDentryId: 'string',
      driveSpaceId: 'string',
      extension: 'string',
      name: 'string',
      spaceInfo: ListRecentsResponseBodyRecentDentryListResourceSpaceInfo,
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRecentsResponseBodyRecentDentryList extends $tea.Model {
  /**
   * @example
   * 123
   */
  accessTime?: number;
  /**
   * @example
   * true
   */
  deleted?: boolean;
  /**
   * @example
   * https://example.com
   */
  icon?: string;
  /**
   * @example
   * 0
   */
  operateType?: number;
  /**
   * @example
   * resource
   */
  resource?: ListRecentsResponseBodyRecentDentryListResource;
  static names(): { [key: string]: string } {
    return {
      accessTime: 'accessTime',
      deleted: 'deleted',
      icon: 'icon',
      operateType: 'operateType',
      resource: 'resource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessTime: 'number',
      deleted: 'boolean',
      icon: 'string',
      operateType: 'number',
      resource: ListRecentsResponseBodyRecentDentryListResource,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSpaceSectionsResponseBodyItems extends $tea.Model {
  /**
   * @example
   * base
   */
  displayType?: string;
  /**
   * @example
   * abc
   */
  id?: string;
  /**
   * @example
   * 测试分组
   */
  name?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * true
   */
  listV2?: boolean;
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * ASC
   */
  order?: string;
  /**
   * @example
   * createTime
   */
  orderBy?: string;
  /**
   * @example
   * true
   */
  withDentryCreatorInfo?: boolean;
  /**
   * @example
   * true
   */
  withDentryModifierInfo?: boolean;
  /**
   * @example
   * true
   */
  withDentryPermissionRole?: boolean;
  /**
   * @example
   * true
   */
  withSpaceDetail?: boolean;
  /**
   * @example
   * true
   */
  withSpacePermissionRole?: boolean;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * user_name
   */
  name?: string;
  /**
   * @example
   * union_id
   */
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
  /**
   * @example
   * user_name
   */
  name?: string;
  /**
   * @example
   * union_id
   */
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
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  creator?: ListStarsResponseBodyStarListDentryInfoCreator;
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
   * mobile_url
   */
  mobileUrl?: string;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  modifier?: ListStarsResponseBodyStarListDentryInfoModifier;
  /**
   * @example
   * dentry_name
   */
  name?: string;
  /**
   * @example
   * pc_url
   */
  pcUrl?: string;
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
   * FILE
   */
  type?: string;
  /**
   * @example
   * uuid
   */
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
  /**
   * @example
   * space_id
   */
  id?: string;
  /**
   * @example
   * space_name
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

export class ListStarsResponseBodyStarListTeamInfo extends $tea.Model {
  /**
   * @example
   * team_id
   */
  id?: string;
  /**
   * @example
   * team_name
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

export class ListStarsResponseBodyStarList extends $tea.Model {
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  createTime?: string;
  dentryInfo?: ListStarsResponseBodyStarListDentryInfo;
  /**
   * @example
   * NO_PERMISSION
   */
  dentryPermissionRole?: string;
  /**
   * @example
   * star_id
   */
  id?: string;
  /**
   * @example
   * true
   */
  isDeleted?: boolean;
  /**
   * @example
   * 2022-01-01T10:00:00Z
   */
  modifiedTime?: string;
  spaceInfo?: ListStarsResponseBodyStarListSpaceInfo;
  /**
   * @example
   * NO_PERMISSION
   */
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
  /**
   * @example
   * YEp3JcM******UIbhwiE
   */
  memberId?: string;
  /**
   * @example
   * 2
   */
  memberType?: number;
  /**
   * @example
   * 小钉
   */
  name?: string;
  /**
   * @example
   * 2
   */
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
  /**
   * @example
   * 小钉
   */
  name?: string;
  /**
   * @example
   * SgExXM*******L0tAiEiE
   */
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
  /**
   * @example
   * 这是知识库简介
   */
  description?: string;
  /**
   * @example
   * YRBG******vJXDAr
   */
  id?: string;
  /**
   * @example
   * 这是知识库名称
   */
  name?: string;
  owner?: QueryItemByUrlResponseBodySpaceOwner;
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://img.xxx.yyy
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * url
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://img.xxx.yyy
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * url
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingtalk
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd
   */
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
  /**
   * @example
   * 3
   */
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
  /**
   * @example
   * https://img.abc.yyy
   */
  cover?: string;
  /**
   * @example
   * This is some description.
   */
  description?: string;
  hdIconVO?: RelatedSpacesResponseBodyItemsHdIconVO;
  iconVO?: RelatedSpacesResponseBodyItemsIconVO;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hello
   */
  name?: string;
  owner?: RelatedSpacesResponseBodyItemsOwner;
  recentList?: DentryModel[];
  /**
   * @example
   * 1
   */
  type?: number;
  /**
   * @example
   * https://xx.yy
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  memberId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  memberType?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * YEp3JcM******UIbhwiE
   */
  memberId?: string;
  /**
   * @example
   * 2
   */
  memberType?: number;
  /**
   * @example
   * 小钉
   */
  name?: string;
  /**
   * @example
   * 0
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * YEp3JcM******UIbhwiE
   */
  memberId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  memberType?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * YEp3JcM******UIbhwiE
   */
  memberId?: string;
  /**
   * @example
   * 2
   */
  memberType?: number;
  /**
   * @example
   * 小钉
   */
  name?: string;
  /**
   * @example
   * 0
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  searchField?: number;
  searchFileType?: number;
  spaceId?: string;
  spaceIds?: string[];
  /**
   * @example
   * 40
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * pc
   */
  platform?: string;
  templateTypes?: number[];
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user_template
   */
  belong?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * searchName
   */
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

export class ShareUrlRequestParam extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dentryUuid
   */
  dentryUuid?: string;
  /**
   * @example
   * true
   */
  triggerShare?: boolean;
  static names(): { [key: string]: string } {
    return {
      dentryUuid: 'dentryUuid',
      triggerShare: 'triggerShare',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryUuid: 'string',
      triggerShare: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShareUrlResponseBodyShareUrlInfo extends $tea.Model {
  /**
   * @example
   * http://example.com
   */
  mobileUrl?: string;
  /**
   * @example
   * http://example.com
   */
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TeamTemplatesRequestOption extends $tea.Model {
  excludeWorkspaceIds?: string[];
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * pc
   */
  platform?: string;
  templateTypes?: number[];
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 1
   */
  categoryStatus?: number;
  /**
   * @example
   * -1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tenantId
   */
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
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * next_token
   */
  nextToken?: string;
  /**
   * @example
   * pc
   */
  platform?: string;
  templateTypes?: number[];
  /**
   * @example
   * 1
   */
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
   * 批量创建小组
   * 
   * @param request - BatchCreateTeamRequest
   * @param headers - BatchCreateTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchCreateTeamResponse
   */
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

  /**
   * 批量创建小组
   * 
   * @param request - BatchCreateTeamRequest
   * @returns BatchCreateTeamResponse
   */
  async batchCreateTeam(request: BatchCreateTeamRequest): Promise<BatchCreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateTeamHeaders({ });
    return await this.batchCreateTeamWithOptions(request, headers, runtime);
  }

  /**
   * 批量删除文档最近记录
   * 
   * @param request - BatchDeleteRecentsRequest
   * @param headers - BatchDeleteRecentsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchDeleteRecentsResponse
   */
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

  /**
   * 批量删除文档最近记录
   * 
   * @param request - BatchDeleteRecentsRequest
   * @returns BatchDeleteRecentsResponse
   */
  async batchDeleteRecents(request: BatchDeleteRecentsRequest): Promise<BatchDeleteRecentsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteRecentsHeaders({ });
    return await this.batchDeleteRecentsWithOptions(request, headers, runtime);
  }

  /**
   * 按分类列表查询模板列表
   * 
   * @param request - CategoriesTemplatesRequest
   * @param headers - CategoriesTemplatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CategoriesTemplatesResponse
   */
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

  /**
   * 按分类列表查询模板列表
   * 
   * @param request - CategoriesTemplatesRequest
   * @returns CategoriesTemplatesResponse
   */
  async categoriesTemplates(request: CategoriesTemplatesRequest): Promise<CategoriesTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CategoriesTemplatesHeaders({ });
    return await this.categoriesTemplatesWithOptions(request, headers, runtime);
  }

  /**
   * 按分类查询模板列表
   * 
   * @param request - CategoryTemplatesRequest
   * @param headers - CategoryTemplatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CategoryTemplatesResponse
   */
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

  /**
   * 按分类查询模板列表
   * 
   * @param request - CategoryTemplatesRequest
   * @returns CategoryTemplatesResponse
   */
  async categoryTemplates(request: CategoryTemplatesRequest): Promise<CategoryTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CategoryTemplatesHeaders({ });
    return await this.categoryTemplatesWithOptions(request, headers, runtime);
  }

  /**
   * 拷贝知识库节点
   * 
   * @param request - CopyDentryRequest
   * @param headers - CopyDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CopyDentryResponse
   */
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

  /**
   * 拷贝知识库节点
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
   * 创建知识库节点（包括文档和文件夹）
   * 
   * @param request - CreateDentryRequest
   * @param headers - CreateDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDentryResponse
   */
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

  /**
   * 创建知识库节点（包括文档和文件夹）
   * 
   * @param request - CreateDentryRequest
   * @returns CreateDentryResponse
   */
  async createDentry(spaceId: string, request: CreateDentryRequest): Promise<CreateDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDentryHeaders({ });
    return await this.createDentryWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 创建知识库
   * 
   * @param request - CreateSpaceRequest
   * @param headers - CreateSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSpaceResponse
   */
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

  /**
   * 创建知识库
   * 
   * @param request - CreateSpaceRequest
   * @returns CreateSpaceResponse
   */
  async createSpace(request: CreateSpaceRequest): Promise<CreateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSpaceHeaders({ });
    return await this.createSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 创建小组
   * 
   * @param request - CreateTeamRequest
   * @param headers - CreateTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateTeamResponse
   */
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

  /**
   * 创建小组
   * 
   * @param request - CreateTeamRequest
   * @returns CreateTeamResponse
   */
  async createTeam(request: CreateTeamRequest): Promise<CreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTeamHeaders({ });
    return await this.createTeamWithOptions(request, headers, runtime);
  }

  /**
   * 跨组织迁移知识库
   * 
   * @param request - CrossOrgMigrateRequest
   * @param headers - CrossOrgMigrateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CrossOrgMigrateResponse
   */
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

  /**
   * 跨组织迁移知识库
   * 
   * @param request - CrossOrgMigrateRequest
   * @returns CrossOrgMigrateResponse
   */
  async crossOrgMigrate(request: CrossOrgMigrateRequest): Promise<CrossOrgMigrateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CrossOrgMigrateHeaders({ });
    return await this.crossOrgMigrateWithOptions(request, headers, runtime);
  }

  /**
   * 删除小组
   * 
   * @param request - DeleteTeamRequest
   * @param headers - DeleteTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteTeamResponse
   */
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

  /**
   * 删除小组
   * 
   * @param request - DeleteTeamRequest
   * @returns DeleteTeamResponse
   */
  async deleteTeam(teamId: string, request: DeleteTeamRequest): Promise<DeleteTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTeamHeaders({ });
    return await this.deleteTeamWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 获取文档内容
   * 
   * @param request - DocContentRequest
   * @param headers - DocContentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DocContentResponse
   */
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

  /**
   * 获取文档内容
   * 
   * @param request - DocContentRequest
   * @returns DocContentResponse
   */
  async docContent(dentryUuid: string, request: DocContentRequest): Promise<DocContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocContentHeaders({ });
    return await this.docContentWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 根据文件DentryUuid获取文件DentryId
   * 
   * @param request - GetDentryIdByUuidRequest
   * @param headers - GetDentryIdByUuidHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDentryIdByUuidResponse
   */
  async getDentryIdByUuidWithOptions(dentryUuid: string, request: GetDentryIdByUuidRequest, headers: GetDentryIdByUuidHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryIdByUuidResponse> {
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
      action: "GetDentryIdByUuid",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/${dentryUuid}/queryDentryId`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentryIdByUuidResponse>(await this.execute(params, req, runtime), new GetDentryIdByUuidResponse({}));
  }

  /**
   * 根据文件DentryUuid获取文件DentryId
   * 
   * @param request - GetDentryIdByUuidRequest
   * @returns GetDentryIdByUuidResponse
   */
  async getDentryIdByUuid(dentryUuid: string, request: GetDentryIdByUuidRequest): Promise<GetDentryIdByUuidResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryIdByUuidHeaders({ });
    return await this.getDentryIdByUuidWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 委托权限获取文档内容
   * 
   * @param request - GetDocContentRequest
   * @param headers - GetDocContentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDocContentResponse
   */
  async getDocContentWithOptions(dentryUuid: string, request: GetDocContentRequest, headers: GetDocContentHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocContentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.generateCp)) {
      query["generateCp"] = request.generateCp;
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

  /**
   * 委托权限获取文档内容
   * 
   * @param request - GetDocContentRequest
   * @returns GetDocContentResponse
   */
  async getDocContent(dentryUuid: string, request: GetDocContentRequest): Promise<GetDocContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocContentHeaders({ });
    return await this.getDocContentWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 委托权限获取文档内容
   * 
   * @param request - GetDocContentForELMRequest
   * @param headers - GetDocContentForELMHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDocContentForELMResponse
   */
  async getDocContentForELMWithOptions(dentryUuid: string, request: GetDocContentForELMRequest, headers: GetDocContentForELMHeaders, runtime: $Util.RuntimeOptions): Promise<GetDocContentForELMResponse> {
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
      action: "GetDocContentForELM",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/elm/me/dentries/${dentryUuid}/contents`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDocContentForELMResponse>(await this.execute(params, req, runtime), new GetDocContentForELMResponse({}));
  }

  /**
   * 委托权限获取文档内容
   * 
   * @param request - GetDocContentForELMRequest
   * @returns GetDocContentForELMResponse
   */
  async getDocContentForELM(dentryUuid: string, request: GetDocContentForELMRequest): Promise<GetDocContentForELMResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDocContentForELMHeaders({ });
    return await this.getDocContentForELMWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 获取当前企业下钉盘目录我的文件对应的空间信息
   * 
   * @param request - GetMySpaceRequest
   * @param headers - GetMySpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMySpaceResponse
   */
  async getMySpaceWithOptions(request: GetMySpaceRequest, headers: GetMySpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetMySpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isMySpace)) {
      query["isMySpace"] = request.isMySpace;
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
      action: "GetMySpace",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/me/mySpace/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMySpaceResponse>(await this.execute(params, req, runtime), new GetMySpaceResponse({}));
  }

  /**
   * 获取当前企业下钉盘目录我的文件对应的空间信息
   * 
   * @param request - GetMySpaceRequest
   * @returns GetMySpaceResponse
   */
  async getMySpace(request: GetMySpaceRequest): Promise<GetMySpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMySpaceHeaders({ });
    return await this.getMySpaceWithOptions(request, headers, runtime);
  }

  /**
   * 查询小组主页schema （包括轮播图、公告、便捷入口）
   * 
   * @param request - GetSchemaRequest
   * @param headers - GetSchemaHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSchemaResponse
   */
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

  /**
   * 查询小组主页schema （包括轮播图、公告、便捷入口）
   * 
   * @param request - GetSchemaRequest
   * @returns GetSchemaResponse
   */
  async getSchema(teamId: string, request: GetSchemaRequest): Promise<GetSchemaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSchemaHeaders({ });
    return await this.getSchemaWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 查询目录树
   * 
   * @param request - GetSpaceDirectoriesRequest
   * @param headers - GetSpaceDirectoriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpaceDirectoriesResponse
   */
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

  /**
   * 查询目录树
   * 
   * @param request - GetSpaceDirectoriesRequest
   * @returns GetSpaceDirectoriesResponse
   */
  async getSpaceDirectories(spaceId: string, request: GetSpaceDirectoriesRequest): Promise<GetSpaceDirectoriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceDirectoriesHeaders({ });
    return await this.getSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 获取星标信息
   * 
   * @param request - GetStarInfoRequest
   * @param headers - GetStarInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetStarInfoResponse
   */
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

  /**
   * 获取星标信息
   * 
   * @param request - GetStarInfoRequest
   * @returns GetStarInfoResponse
   */
  async getStarInfo(dentryUuid: string, request: GetStarInfoRequest): Promise<GetStarInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStarInfoHeaders({ });
    return await this.getStarInfoWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 查询小组详情
   * 
   * @param request - GetTeamRequest
   * @param headers - GetTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTeamResponse
   */
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

  /**
   * 查询小组详情
   * 
   * @param request - GetTeamRequest
   * @returns GetTeamResponse
   */
  async getTeam(teamId: string, request: GetTeamRequest): Promise<GetTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTeamHeaders({ });
    return await this.getTeamWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 获取知识库下的总节点数
   * 
   * @param request - GetTotalNumberOfDentriesRequest
   * @param headers - GetTotalNumberOfDentriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTotalNumberOfDentriesResponse
   */
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

  /**
   * 获取知识库下的总节点数
   * 
   * @param request - GetTotalNumberOfDentriesRequest
   * @returns GetTotalNumberOfDentriesResponse
   */
  async getTotalNumberOfDentries(request: GetTotalNumberOfDentriesRequest): Promise<GetTotalNumberOfDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTotalNumberOfDentriesHeaders({ });
    return await this.getTotalNumberOfDentriesWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识库总数
   * 
   * @param request - GetTotalNumberOfSpacesRequest
   * @param headers - GetTotalNumberOfSpacesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTotalNumberOfSpacesResponse
   */
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

  /**
   * 获取知识库总数
   * 
   * @param request - GetTotalNumberOfSpacesRequest
   * @returns GetTotalNumberOfSpacesResponse
   */
  async getTotalNumberOfSpaces(request: GetTotalNumberOfSpacesRequest): Promise<GetTotalNumberOfSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTotalNumberOfSpacesHeaders({ });
    return await this.getTotalNumberOfSpacesWithOptions(request, headers, runtime);
  }

  /**
   * 查询文档免登的用户信息
   * 
   * @param request - GetUserInfoByOpenTokenRequest
   * @param headers - GetUserInfoByOpenTokenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserInfoByOpenTokenResponse
   */
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

  /**
   * 查询文档免登的用户信息
   * 
   * @param request - GetUserInfoByOpenTokenRequest
   * @returns GetUserInfoByOpenTokenResponse
   */
  async getUserInfoByOpenToken(request: GetUserInfoByOpenTokenRequest): Promise<GetUserInfoByOpenTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserInfoByOpenTokenHeaders({ });
    return await this.getUserInfoByOpenTokenWithOptions(request, headers, runtime);
  }

  /**
   * 根据文件DentryId获取文件DentryUuid
   * 
   * @param request - GetUuidByDentryIdRequest
   * @param headers - GetUuidByDentryIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUuidByDentryIdResponse
   */
  async getUuidByDentryIdWithOptions(dentryId: string, request: GetUuidByDentryIdRequest, headers: GetUuidByDentryIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetUuidByDentryIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.spaceId)) {
      query["spaceId"] = request.spaceId;
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
      action: "GetUuidByDentryId",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/${dentryId}/queryDentryUuid`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUuidByDentryIdResponse>(await this.execute(params, req, runtime), new GetUuidByDentryIdResponse({}));
  }

  /**
   * 根据文件DentryId获取文件DentryUuid
   * 
   * @param request - GetUuidByDentryIdRequest
   * @returns GetUuidByDentryIdResponse
   */
  async getUuidByDentryId(dentryId: string, request: GetUuidByDentryIdRequest): Promise<GetUuidByDentryIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUuidByDentryIdHeaders({ });
    return await this.getUuidByDentryIdWithOptions(dentryId, request, headers, runtime);
  }

  /**
   * 以超级管理员身份转交小组
   * 
   * @param request - HandoverTeamWithoutAuthRequest
   * @param headers - HandoverTeamWithoutAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HandoverTeamWithoutAuthResponse
   */
  async handoverTeamWithoutAuthWithOptions(request: HandoverTeamWithoutAuthRequest, headers: HandoverTeamWithoutAuthHeaders, runtime: $Util.RuntimeOptions): Promise<HandoverTeamWithoutAuthResponse> {
    Util.validateModel(request);
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "HandoverTeamWithoutAuth",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/teams/members/handoverWithoutAuth`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HandoverTeamWithoutAuthResponse>(await this.execute(params, req, runtime), new HandoverTeamWithoutAuthResponse({}));
  }

  /**
   * 以超级管理员身份转交小组
   * 
   * @param request - HandoverTeamWithoutAuthRequest
   * @returns HandoverTeamWithoutAuthResponse
   */
  async handoverTeamWithoutAuth(request: HandoverTeamWithoutAuthRequest): Promise<HandoverTeamWithoutAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HandoverTeamWithoutAuthHeaders({ });
    return await this.handoverTeamWithoutAuthWithOptions(request, headers, runtime);
  }

  /**
   * 查询小组动态
   * 
   * @param request - ListFeedsRequest
   * @param headers - ListFeedsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListFeedsResponse
   */
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

  /**
   * 查询小组动态
   * 
   * @param request - ListFeedsRequest
   * @returns ListFeedsResponse
   */
  async listFeeds(teamId: string, request: ListFeedsRequest): Promise<ListFeedsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFeedsHeaders({ });
    return await this.listFeedsWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 查询小组热门文档
   * 
   * @param request - ListHotDocsRequest
   * @param headers - ListHotDocsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListHotDocsResponse
   */
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

  /**
   * 查询小组热门文档
   * 
   * @param request - ListHotDocsRequest
   * @returns ListHotDocsResponse
   */
  async listHotDocs(teamId: string, request: ListHotDocsRequest): Promise<ListHotDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListHotDocsHeaders({ });
    return await this.listHotDocsWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 获取置顶知识库列表
   * 
   * @param request - ListPinSpacesRequest
   * @param headers - ListPinSpacesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListPinSpacesResponse
   */
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

  /**
   * 获取置顶知识库列表
   * 
   * @param request - ListPinSpacesRequest
   * @returns ListPinSpacesResponse
   */
  async listPinSpaces(request: ListPinSpacesRequest): Promise<ListPinSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPinSpacesHeaders({ });
    return await this.listPinSpacesWithOptions(request, headers, runtime);
  }

  /**
   * 查询文档最近记录列表
   * 
   * @param request - ListRecentsRequest
   * @param headers - ListRecentsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListRecentsResponse
   */
  async listRecentsWithOptions(request: ListRecentsRequest, headers: ListRecentsHeaders, runtime: $Util.RuntimeOptions): Promise<ListRecentsResponse> {
    Util.validateModel(request);
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ListRecents",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/recentRecords/lists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListRecentsResponse>(await this.execute(params, req, runtime), new ListRecentsResponse({}));
  }

  /**
   * 查询文档最近记录列表
   * 
   * @param request - ListRecentsRequest
   * @returns ListRecentsResponse
   */
  async listRecents(request: ListRecentsRequest): Promise<ListRecentsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRecentsHeaders({ });
    return await this.listRecentsWithOptions(request, headers, runtime);
  }

  /**
   * 查询关联了知识库的团队列表
   * 
   * @param request - ListRelatedSpaceTeamsRequest
   * @param headers - ListRelatedSpaceTeamsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListRelatedSpaceTeamsResponse
   */
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

  /**
   * 查询关联了知识库的团队列表
   * 
   * @param request - ListRelatedSpaceTeamsRequest
   * @returns ListRelatedSpaceTeamsResponse
   */
  async listRelatedSpaceTeams(request: ListRelatedSpaceTeamsRequest): Promise<ListRelatedSpaceTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRelatedSpaceTeamsHeaders({ });
    return await this.listRelatedSpaceTeamsWithOptions(request, headers, runtime);
  }

  /**
   * 查询小组列表
   * 
   * @param request - ListRelatedTeamsRequest
   * @param headers - ListRelatedTeamsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListRelatedTeamsResponse
   */
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

  /**
   * 查询小组列表
   * 
   * @param request - ListRelatedTeamsRequest
   * @returns ListRelatedTeamsResponse
   */
  async listRelatedTeams(request: ListRelatedTeamsRequest): Promise<ListRelatedTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRelatedTeamsHeaders({ });
    return await this.listRelatedTeamsWithOptions(request, headers, runtime);
  }

  /**
   * 查询知识库分组
   * 
   * @param request - ListSpaceSectionsRequest
   * @param headers - ListSpaceSectionsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSpaceSectionsResponse
   */
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

  /**
   * 查询知识库分组
   * 
   * @param request - ListSpaceSectionsRequest
   * @returns ListSpaceSectionsResponse
   */
  async listSpaceSections(teamId: string, request: ListSpaceSectionsRequest): Promise<ListSpaceSectionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSpaceSectionsHeaders({ });
    return await this.listSpaceSectionsWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 获取星标列表
   * 
   * @param request - ListStarsRequest
   * @param headers - ListStarsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListStarsResponse
   */
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

  /**
   * 获取星标列表
   * 
   * @param request - ListStarsRequest
   * @returns ListStarsResponse
   */
  async listStars(request: ListStarsRequest): Promise<ListStarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListStarsHeaders({ });
    return await this.listStarsWithOptions(request, headers, runtime);
  }

  /**
   * 查询小组成员列表
   * 
   * @param request - ListTeamMembersRequest
   * @param headers - ListTeamMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListTeamMembersResponse
   */
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

  /**
   * 查询小组成员列表
   * 
   * @param request - ListTeamMembersRequest
   * @returns ListTeamMembersResponse
   */
  async listTeamMembers(teamId: string, request: ListTeamMembersRequest): Promise<ListTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTeamMembersHeaders({ });
    return await this.listTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 标记星标
   * 
   * @param request - MarkStarRequest
   * @param headers - MarkStarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MarkStarResponse
   */
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

  /**
   * 标记星标
   * 
   * @param request - MarkStarRequest
   * @returns MarkStarResponse
   */
  async markStar(dentryUuid: string, request: MarkStarRequest): Promise<MarkStarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MarkStarHeaders({ });
    return await this.markStarWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 移动知识库节点
   * 
   * @param request - MoveDentryRequest
   * @param headers - MoveDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MoveDentryResponse
   */
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

  /**
   * 移动知识库节点
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
   * 置顶知识库
   * 
   * @param request - PinSpaceRequest
   * @param headers - PinSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PinSpaceResponse
   */
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

  /**
   * 置顶知识库
   * 
   * @param request - PinSpaceRequest
   * @returns PinSpaceResponse
   */
  async pinSpace(spaceId: string, request: PinSpaceRequest): Promise<PinSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PinSpaceHeaders({ });
    return await this.pinSpaceWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 查询知识库节点（包括文档和文件夹）
   * 
   * @param request - QueryDentryRequest
   * @param headers - QueryDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDentryResponse
   */
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

  /**
   * 查询知识库节点（包括文档和文件夹）
   * 
   * @param request - QueryDentryRequest
   * @returns QueryDentryResponse
   */
  async queryDentry(spaceId: string, dentryId: string, request: QueryDentryRequest): Promise<QueryDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDentryHeaders({ });
    return await this.queryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  /**
   * 获取文档内容
   * 
   * @param request - QueryDocContentRequest
   * @param headers - QueryDocContentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDocContentResponse
   */
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

  /**
   * 获取文档内容
   * 
   * @param request - QueryDocContentRequest
   * @returns QueryDocContentResponse
   */
  async queryDocContent(dentryUuid: string, request: QueryDocContentRequest): Promise<QueryDocContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDocContentHeaders({ });
    return await this.queryDocContentWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 根据链接查询节点或知识库信息
   * 
   * @param request - QueryItemByUrlRequest
   * @param headers - QueryItemByUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryItemByUrlResponse
   */
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

  /**
   * 根据链接查询节点或知识库信息
   * 
   * @param request - QueryItemByUrlRequest
   * @returns QueryItemByUrlResponse
   */
  async queryItemByUrl(request: QueryItemByUrlRequest): Promise<QueryItemByUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryItemByUrlHeaders({ });
    return await this.queryItemByUrlWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户的「我的文档」
   * 
   * @param headers - QueryMineSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMineSpaceResponse
   */
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

  /**
   * 查询用户的「我的文档」
   * @returns QueryMineSpaceResponse
   */
  async queryMineSpace(unionId: string): Promise<QueryMineSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMineSpaceHeaders({ });
    return await this.queryMineSpaceWithOptions(unionId, headers, runtime);
  }

  /**
   * 查询最近列表
   * 
   * @param request - QueryRecentListRequest
   * @param headers - QueryRecentListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRecentListResponse
   */
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

  /**
   * 查询最近列表
   * 
   * @param request - QueryRecentListRequest
   * @returns QueryRecentListResponse
   */
  async queryRecentList(request: QueryRecentListRequest): Promise<QueryRecentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRecentListHeaders({ });
    return await this.queryRecentListWithOptions(request, headers, runtime);
  }

  /**
   * 查询指定知识库信息
   * 
   * @param request - QuerySpaceRequest
   * @param headers - QuerySpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySpaceResponse
   */
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

  /**
   * 查询指定知识库信息
   * 
   * @param request - QuerySpaceRequest
   * @returns QuerySpaceResponse
   */
  async querySpace(spaceId: string, request: QuerySpaceRequest): Promise<QuerySpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySpaceHeaders({ });
    return await this.querySpaceWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 查询与我关联的知识库列表（支持筛选小组）
   * 
   * @param request - RelatedSpacesRequest
   * @param headers - RelatedSpacesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RelatedSpacesResponse
   */
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

  /**
   * 查询与我关联的知识库列表（支持筛选小组）
   * 
   * @param request - RelatedSpacesRequest
   * @returns RelatedSpacesResponse
   */
  async relatedSpaces(request: RelatedSpacesRequest): Promise<RelatedSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RelatedSpacesHeaders({ });
    return await this.relatedSpacesWithOptions(request, headers, runtime);
  }

  /**
   * 移除小组成员
   * 
   * @param request - RemoveTeamMembersRequest
   * @param headers - RemoveTeamMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveTeamMembersResponse
   */
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

  /**
   * 移除小组成员
   * 
   * @param request - RemoveTeamMembersRequest
   * @returns RemoveTeamMembersResponse
   */
  async removeTeamMembers(teamId: string, request: RemoveTeamMembersRequest): Promise<RemoveTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveTeamMembersHeaders({ });
    return await this.removeTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 知识库节点（包括文档和文件夹）重命名
   * 
   * @param request - RenameDentryRequest
   * @param headers - RenameDentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RenameDentryResponse
   */
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

  /**
   * 知识库节点（包括文档和文件夹）重命名
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
   * 添加或修改小组成员
   * 
   * @param request - SaveTeamMembersRequest
   * @param headers - SaveTeamMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveTeamMembersResponse
   */
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

  /**
   * 添加或修改小组成员
   * 
   * @param request - SaveTeamMembersRequest
   * @returns SaveTeamMembersResponse
   */
  async saveTeamMembers(teamId: string, request: SaveTeamMembersRequest): Promise<SaveTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveTeamMembersHeaders({ });
    return await this.saveTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 搜索知识库和节点
   * 
   * @param request - SearchRequest
   * @param headers - SearchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchResponse
   */
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

  /**
   * 搜索知识库和节点
   * 
   * @param request - SearchRequest
   * @returns SearchResponse
   */
  async search(request: SearchRequest): Promise<SearchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchHeaders({ });
    return await this.searchWithOptions(request, headers, runtime);
  }

  /**
   * 搜索模板中心模板
   * 
   * @param request - SearchTemplatesRequest
   * @param headers - SearchTemplatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchTemplatesResponse
   */
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

  /**
   * 搜索模板中心模板
   * 
   * @param request - SearchTemplatesRequest
   * @returns SearchTemplatesResponse
   */
  async searchTemplates(request: SearchTemplatesRequest): Promise<SearchTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchTemplatesHeaders({ });
    return await this.searchTemplatesWithOptions(request, headers, runtime);
  }

  /**
   * 获取文件打开链接
   * 
   * @param request - ShareUrlRequest
   * @param headers - ShareUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ShareUrlResponse
   */
  async shareUrlWithOptions(request: ShareUrlRequest, headers: ShareUrlHeaders, runtime: $Util.RuntimeOptions): Promise<ShareUrlResponse> {
    Util.validateModel(request);
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ShareUrl",
      version: "doc_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/doc/dentries/shareUrls/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ShareUrlResponse>(await this.execute(params, req, runtime), new ShareUrlResponse({}));
  }

  /**
   * 获取文件打开链接
   * 
   * @param request - ShareUrlRequest
   * @returns ShareUrlResponse
   */
  async shareUrl(request: ShareUrlRequest): Promise<ShareUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ShareUrlHeaders({ });
    return await this.shareUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识库模板列表
   * 
   * @param request - TeamTemplatesRequest
   * @param headers - TeamTemplatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TeamTemplatesResponse
   */
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

  /**
   * 获取知识库模板列表
   * 
   * @param request - TeamTemplatesRequest
   * @returns TeamTemplatesResponse
   */
  async teamTemplates(request: TeamTemplatesRequest): Promise<TeamTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TeamTemplatesHeaders({ });
    return await this.teamTemplatesWithOptions(request, headers, runtime);
  }

  /**
   * 获取模板分类列表
   * 
   * @param request - TemplateCategoriesRequest
   * @param headers - TemplateCategoriesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TemplateCategoriesResponse
   */
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

  /**
   * 获取模板分类列表
   * 
   * @param request - TemplateCategoriesRequest
   * @returns TemplateCategoriesResponse
   */
  async templateCategories(request: TemplateCategoriesRequest): Promise<TemplateCategoriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TemplateCategoriesHeaders({ });
    return await this.templateCategoriesWithOptions(request, headers, runtime);
  }

  /**
   * 取消标记星标
   * 
   * @param request - UnmarkStarRequest
   * @param headers - UnmarkStarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnmarkStarResponse
   */
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

  /**
   * 取消标记星标
   * 
   * @param request - UnmarkStarRequest
   * @returns UnmarkStarResponse
   */
  async unmarkStar(dentryUuid: string, request: UnmarkStarRequest): Promise<UnmarkStarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnmarkStarHeaders({ });
    return await this.unmarkStarWithOptions(dentryUuid, request, headers, runtime);
  }

  /**
   * 取消置顶知识库
   * 
   * @param request - UnpinSpaceRequest
   * @param headers - UnpinSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnpinSpaceResponse
   */
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

  /**
   * 取消置顶知识库
   * 
   * @param request - UnpinSpaceRequest
   * @returns UnpinSpaceResponse
   */
  async unpinSpace(spaceId: string, request: UnpinSpaceRequest): Promise<UnpinSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnpinSpaceHeaders({ });
    return await this.unpinSpaceWithOptions(spaceId, request, headers, runtime);
  }

  /**
   * 更新小组
   * 
   * @param request - UpdateTeamRequest
   * @param headers - UpdateTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateTeamResponse
   */
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

  /**
   * 更新小组
   * 
   * @param request - UpdateTeamRequest
   * @returns UpdateTeamResponse
   */
  async updateTeam(teamId: string, request: UpdateTeamRequest): Promise<UpdateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTeamHeaders({ });
    return await this.updateTeamWithOptions(teamId, request, headers, runtime);
  }

  /**
   * 用户模板列表
   * 
   * @param request - UserTemplatesRequest
   * @param headers - UserTemplatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UserTemplatesResponse
   */
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

  /**
   * 用户模板列表
   * 
   * @param request - UserTemplatesRequest
   * @returns UserTemplatesResponse
   */
  async userTemplates(request: UserTemplatesRequest): Promise<UserTemplatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserTemplatesHeaders({ });
    return await this.userTemplatesWithOptions(request, headers, runtime);
  }

}
