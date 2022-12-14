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
  recentList?: DentryModel[];
  type?: number;
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
  body: TeamVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TeamVO,
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
  body: TeamVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TeamVO,
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
  body: GetSchemaResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: TeamVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetTotalNumberOfDentriesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetTotalNumberOfSpacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: ListFeedsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: ListHotDocsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListHotDocsResponseBody,
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
  body: ListRelatedSpaceTeamsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: ListRelatedTeamsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: ListSpaceSectionsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSpaceSectionsResponseBody,
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
  body: ListTeamMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListTeamMembersResponseBody,
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
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      url: 'string',
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
  body: QueryItemByUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: RemoveTeamMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: SaveTeamMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: TeamVO;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TeamVO,
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
  summaryLength?: number;
  visitTimeRange?: SearchRequestDentryRequestVisitTimeRange;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      searchField: 'searchField',
      searchFileType: 'searchFileType',
      spaceId: 'spaceId',
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
  url?: string;
  userLastOperation?: SearchResponseBodySpaceResultItemsUserLastOperation;
  static names(): { [key: string]: string } {
    return {
      iconVO: 'iconVO',
      name: 'name',
      originName: 'originName',
      spaceId: 'spaceId',
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

  async createSpace(request: CreateSpaceRequest): Promise<CreateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSpaceHeaders({ });
    return await this.createSpaceWithOptions(request, headers, runtime);
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
    return $tea.cast<CreateSpaceResponse>(await this.doROARequest("CreateSpace", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/spaces`, "json", req, runtime), new CreateSpaceResponse({}));
  }

  async createTeam(request: CreateTeamRequest): Promise<CreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTeamHeaders({ });
    return await this.createTeamWithOptions(request, headers, runtime);
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
    return $tea.cast<CreateTeamResponse>(await this.doROARequest("CreateTeam", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/teams`, "json", req, runtime), new CreateTeamResponse({}));
  }

  async deleteTeam(teamId: string, request: DeleteTeamRequest): Promise<DeleteTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTeamHeaders({ });
    return await this.deleteTeamWithOptions(teamId, request, headers, runtime);
  }

  async deleteTeamWithOptions(teamId: string, request: DeleteTeamRequest, headers: DeleteTeamHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTeamResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<DeleteTeamResponse>(await this.doROARequest("DeleteTeam", "doc_2.0", "HTTP", "DELETE", "AK", `/v2.0/doc/teams/${teamId}`, "json", req, runtime), new DeleteTeamResponse({}));
  }

  async getSchema(teamId: string, request: GetSchemaRequest): Promise<GetSchemaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSchemaHeaders({ });
    return await this.getSchemaWithOptions(teamId, request, headers, runtime);
  }

  async getSchemaWithOptions(teamId: string, request: GetSchemaRequest, headers: GetSchemaHeaders, runtime: $Util.RuntimeOptions): Promise<GetSchemaResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<GetSchemaResponse>(await this.doROARequest("GetSchema", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/${teamId}/schemas`, "json", req, runtime), new GetSchemaResponse({}));
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

  async getTeam(teamId: string, request: GetTeamRequest): Promise<GetTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTeamHeaders({ });
    return await this.getTeamWithOptions(teamId, request, headers, runtime);
  }

  async getTeamWithOptions(teamId: string, request: GetTeamRequest, headers: GetTeamHeaders, runtime: $Util.RuntimeOptions): Promise<GetTeamResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<GetTeamResponse>(await this.doROARequest("GetTeam", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/${teamId}`, "json", req, runtime), new GetTeamResponse({}));
  }

  async getTotalNumberOfDentries(request: GetTotalNumberOfDentriesRequest): Promise<GetTotalNumberOfDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTotalNumberOfDentriesHeaders({ });
    return await this.getTotalNumberOfDentriesWithOptions(request, headers, runtime);
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
    return $tea.cast<GetTotalNumberOfDentriesResponse>(await this.doROARequest("GetTotalNumberOfDentries", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/statistics/dentryCounts`, "json", req, runtime), new GetTotalNumberOfDentriesResponse({}));
  }

  async getTotalNumberOfSpaces(request: GetTotalNumberOfSpacesRequest): Promise<GetTotalNumberOfSpacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTotalNumberOfSpacesHeaders({ });
    return await this.getTotalNumberOfSpacesWithOptions(request, headers, runtime);
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
    return $tea.cast<GetTotalNumberOfSpacesResponse>(await this.doROARequest("GetTotalNumberOfSpaces", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/spaces/statistics/spaceCounts`, "json", req, runtime), new GetTotalNumberOfSpacesResponse({}));
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

  async listFeeds(teamId: string, request: ListFeedsRequest): Promise<ListFeedsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFeedsHeaders({ });
    return await this.listFeedsWithOptions(teamId, request, headers, runtime);
  }

  async listFeedsWithOptions(teamId: string, request: ListFeedsRequest, headers: ListFeedsHeaders, runtime: $Util.RuntimeOptions): Promise<ListFeedsResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<ListFeedsResponse>(await this.doROARequest("ListFeeds", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/${teamId}/feeds`, "json", req, runtime), new ListFeedsResponse({}));
  }

  async listHotDocs(teamId: string, request: ListHotDocsRequest): Promise<ListHotDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListHotDocsHeaders({ });
    return await this.listHotDocsWithOptions(teamId, request, headers, runtime);
  }

  async listHotDocsWithOptions(teamId: string, request: ListHotDocsRequest, headers: ListHotDocsHeaders, runtime: $Util.RuntimeOptions): Promise<ListHotDocsResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<ListHotDocsResponse>(await this.doROARequest("ListHotDocs", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/${teamId}/hotDocs`, "json", req, runtime), new ListHotDocsResponse({}));
  }

  async listRelatedSpaceTeams(request: ListRelatedSpaceTeamsRequest): Promise<ListRelatedSpaceTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRelatedSpaceTeamsHeaders({ });
    return await this.listRelatedSpaceTeamsWithOptions(request, headers, runtime);
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
    return $tea.cast<ListRelatedSpaceTeamsResponse>(await this.doROARequest("ListRelatedSpaceTeams", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/relations/spaceTeams`, "json", req, runtime), new ListRelatedSpaceTeamsResponse({}));
  }

  async listRelatedTeams(request: ListRelatedTeamsRequest): Promise<ListRelatedTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRelatedTeamsHeaders({ });
    return await this.listRelatedTeamsWithOptions(request, headers, runtime);
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
    return $tea.cast<ListRelatedTeamsResponse>(await this.doROARequest("ListRelatedTeams", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams`, "json", req, runtime), new ListRelatedTeamsResponse({}));
  }

  async listSpaceSections(teamId: string, request: ListSpaceSectionsRequest): Promise<ListSpaceSectionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSpaceSectionsHeaders({ });
    return await this.listSpaceSectionsWithOptions(teamId, request, headers, runtime);
  }

  async listSpaceSectionsWithOptions(teamId: string, request: ListSpaceSectionsRequest, headers: ListSpaceSectionsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSpaceSectionsResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<ListSpaceSectionsResponse>(await this.doROARequest("ListSpaceSections", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/${teamId}/spaceSections`, "json", req, runtime), new ListSpaceSectionsResponse({}));
  }

  async listTeamMembers(teamId: string, request: ListTeamMembersRequest): Promise<ListTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTeamMembersHeaders({ });
    return await this.listTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  async listTeamMembersWithOptions(teamId: string, request: ListTeamMembersRequest, headers: ListTeamMembersHeaders, runtime: $Util.RuntimeOptions): Promise<ListTeamMembersResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<ListTeamMembersResponse>(await this.doROARequest("ListTeamMembers", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/teams/${teamId}/members`, "json", req, runtime), new ListTeamMembersResponse({}));
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

  async queryItemByUrl(request: QueryItemByUrlRequest): Promise<QueryItemByUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryItemByUrlHeaders({ });
    return await this.queryItemByUrlWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryItemByUrlResponse>(await this.doROARequest("QueryItemByUrl", "doc_2.0", "HTTP", "GET", "AK", `/v2.0/doc/items`, "json", req, runtime), new QueryItemByUrlResponse({}));
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

  async removeTeamMembers(teamId: string, request: RemoveTeamMembersRequest): Promise<RemoveTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveTeamMembersHeaders({ });
    return await this.removeTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  async removeTeamMembersWithOptions(teamId: string, request: RemoveTeamMembersRequest, headers: RemoveTeamMembersHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveTeamMembersResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<RemoveTeamMembersResponse>(await this.doROARequest("RemoveTeamMembers", "doc_2.0", "HTTP", "PUT", "AK", `/v2.0/doc/teams/${teamId}/members/remove`, "json", req, runtime), new RemoveTeamMembersResponse({}));
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

  async saveTeamMembers(teamId: string, request: SaveTeamMembersRequest): Promise<SaveTeamMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveTeamMembersHeaders({ });
    return await this.saveTeamMembersWithOptions(teamId, request, headers, runtime);
  }

  async saveTeamMembersWithOptions(teamId: string, request: SaveTeamMembersRequest, headers: SaveTeamMembersHeaders, runtime: $Util.RuntimeOptions): Promise<SaveTeamMembersResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<SaveTeamMembersResponse>(await this.doROARequest("SaveTeamMembers", "doc_2.0", "HTTP", "PUT", "AK", `/v2.0/doc/teams/${teamId}/members`, "json", req, runtime), new SaveTeamMembersResponse({}));
  }

  async search(request: SearchRequest): Promise<SearchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchHeaders({ });
    return await this.searchWithOptions(request, headers, runtime);
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
    return $tea.cast<SearchResponse>(await this.doROARequest("Search", "doc_2.0", "HTTP", "POST", "AK", `/v2.0/doc/search`, "json", req, runtime), new SearchResponse({}));
  }

  async updateTeam(teamId: string, request: UpdateTeamRequest): Promise<UpdateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTeamHeaders({ });
    return await this.updateTeamWithOptions(teamId, request, headers, runtime);
  }

  async updateTeamWithOptions(teamId: string, request: UpdateTeamRequest, headers: UpdateTeamHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTeamResponse> {
    Util.validateModel(request);
    teamId = OpenApiUtil.getEncodeParam(teamId);
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
    return $tea.cast<UpdateTeamResponse>(await this.doROARequest("UpdateTeam", "doc_2.0", "HTTP", "PUT", "AK", `/v2.0/doc/teams/${teamId}`, "json", req, runtime), new UpdateTeamResponse({}));
  }

}
