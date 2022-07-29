// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  iconVO?: SpaceModelIconVO;
  id?: string;
  name?: string;
  owner?: SpaceModelOwner;
  url?: string;
  visitorInfo?: SpaceModelVisitorInfo;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      description: 'description',
      iconVO: 'iconVO',
      id: 'id',
      name: 'name',
      owner: 'owner',
      url: 'url',
      visitorInfo: 'visitorInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      description: 'string',
      iconVO: SpaceModelIconVO,
      id: 'string',
      name: 'string',
      owner: SpaceModelOwner,
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
      url: 'string',
      visitorInfo: SpaceVOVisitorInfo,
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
  body: DentryVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: DentryVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DentryVO,
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
  body: GetSpaceDirectoriesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSpaceDirectoriesResponseBody,
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
  body: GetUserInfoByOpenTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserInfoByOpenTokenResponseBody,
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
  body: DentryVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DentryVO,
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
  body: DentryVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DentryVO,
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
  body: SpaceVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryRecentListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: SpaceVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  items?: SpaceModel[];
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
      items: { 'type': 'array', 'itemType': SpaceModel },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelatedSpacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RelatedSpacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RelatedSpacesResponseBody,
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
  body: DentryVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DentryVO,
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
  body: SearchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchResponseBody,
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

export class QueryRecentListResponseBodyRecentList extends $tea.Model {
  deleted?: boolean;
  dentry?: DentryModel;
  recentTime?: number;
  static names(): { [key: string]: string } {
    return {
      deleted: 'deleted',
      dentry: 'dentry',
      recentTime: 'recentTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleted: 'boolean',
      dentry: DentryModel,
      recentTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchRequestDentryRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  searchFileType?: number;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      searchFileType: 'searchFileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      searchFileType: 'number',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchRequestSpaceRequest extends $tea.Model {
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
  searchFileType?: number;
  spaceId?: string;
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
      searchFileType: 'searchFileType',
      spaceId: 'spaceId',
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
      searchFileType: 'number',
      spaceId: 'string',
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

export class SearchResponseBodySpaceResultItems extends $tea.Model {
  name?: string;
  originName?: string;
  spaceId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      originName: 'originName',
      spaceId: 'spaceId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      originName: 'string',
      spaceId: 'string',
      url: 'string',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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
    return $tea.cast<CopyDentryResponse>(await this.doROARequest("CopyDentry", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}/copy`, "json", req, runtime), new CopyDentryResponse({}));
  }

  async createDentry(spaceId: string, request: CreateDentryRequest): Promise<CreateDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDentryHeaders({ });
    return await this.createDentryWithOptions(spaceId, request, headers, runtime);
  }

  async createDentryWithOptions(spaceId: string, request: CreateDentryRequest, headers: CreateDentryHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
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
    return $tea.cast<CreateDentryResponse>(await this.doROARequest("CreateDentry", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/spaces/${spaceId}/dentries`, "json", req, runtime), new CreateDentryResponse({}));
  }

  async getSpaceDirectories(spaceId: string, request: GetSpaceDirectoriesRequest): Promise<GetSpaceDirectoriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceDirectoriesHeaders({ });
    return await this.getSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
  }

  async getSpaceDirectoriesWithOptions(spaceId: string, request: GetSpaceDirectoriesRequest, headers: GetSpaceDirectoriesHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceDirectoriesResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
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
    return $tea.cast<GetSpaceDirectoriesResponse>(await this.doROARequest("GetSpaceDirectories", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/${spaceId}/directories`, "json", req, runtime), new GetSpaceDirectoriesResponse({}));
  }

  async getUserInfoByOpenToken(request: GetUserInfoByOpenTokenRequest): Promise<GetUserInfoByOpenTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserInfoByOpenTokenHeaders({ });
    return await this.getUserInfoByOpenTokenWithOptions(request, headers, runtime);
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
    return $tea.cast<GetUserInfoByOpenTokenResponse>(await this.doROARequest("GetUserInfoByOpenToken", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/userInfos`, "json", req, runtime), new GetUserInfoByOpenTokenResponse({}));
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
    return $tea.cast<MoveDentryResponse>(await this.doROARequest("MoveDentry", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}/move`, "json", req, runtime), new MoveDentryResponse({}));
  }

  async queryDentry(spaceId: string, dentryId: string, request: QueryDentryRequest): Promise<QueryDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDentryHeaders({ });
    return await this.queryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async queryDentryWithOptions(spaceId: string, dentryId: string, request: QueryDentryRequest, headers: QueryDentryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDentryResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
    dentryId = OpenApiUtil.getEncodeParam(dentryId);
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
    return $tea.cast<QueryDentryResponse>(await this.doROARequest("QueryDentry", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}`, "json", req, runtime), new QueryDentryResponse({}));
  }

  async queryMineSpace(unionId: string): Promise<QueryMineSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMineSpaceHeaders({ });
    return await this.queryMineSpaceWithOptions(unionId, headers, runtime);
  }

  async queryMineSpaceWithOptions(unionId: string, headers: QueryMineSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMineSpaceResponse> {
    unionId = OpenApiUtil.getEncodeParam(unionId);
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
    return $tea.cast<QueryMineSpaceResponse>(await this.doROARequest("QueryMineSpace", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/users/${unionId}/mine`, "json", req, runtime), new QueryMineSpaceResponse({}));
  }

  async queryRecentList(request: QueryRecentListRequest): Promise<QueryRecentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRecentListHeaders({ });
    return await this.queryRecentListWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryRecentListResponse>(await this.doROARequest("QueryRecentList", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/docs/recent`, "json", req, runtime), new QueryRecentListResponse({}));
  }

  async querySpace(spaceId: string, request: QuerySpaceRequest): Promise<QuerySpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySpaceHeaders({ });
    return await this.querySpaceWithOptions(spaceId, request, headers, runtime);
  }

  async querySpaceWithOptions(spaceId: string, request: QuerySpaceRequest, headers: QuerySpaceHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySpaceResponse> {
    Util.validateModel(request);
    spaceId = OpenApiUtil.getEncodeParam(spaceId);
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
    return $tea.cast<QuerySpaceResponse>(await this.doROARequest("QuerySpace", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/${spaceId}`, "json", req, runtime), new QuerySpaceResponse({}));
  }

  async relatedSpaces(request: RelatedSpacesRequest): Promise<RelatedSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RelatedSpacesHeaders({ });
    return await this.relatedSpacesWithOptions(request, headers, runtime);
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
    return $tea.cast<RelatedSpacesResponse>(await this.doROARequest("RelatedSpaces", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/relations/spaces`, "json", req, runtime), new RelatedSpacesResponse({}));
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
    return $tea.cast<RenameDentryResponse>(await this.doROARequest("RenameDentry", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/spaces/${spaceId}/dentries/${dentryId}/rename`, "json", req, runtime), new RenameDentryResponse({}));
  }

  async search(request: SearchRequest): Promise<SearchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchHeaders({ });
    return await this.searchWithOptions(request, headers, runtime);
  }

  async searchWithOptions(request: SearchRequest, headers: SearchHeaders, runtime: $Util.RuntimeOptions): Promise<SearchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.dentryRequest))) {
      body["dentryRequest"] = request.dentryRequest;
    }

    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset($tea.toMap(request.spaceRequest))) {
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
    return $tea.cast<SearchResponse>(await this.doROARequest("Search", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/search`, "json", req, runtime), new SearchResponse({}));
  }

}
