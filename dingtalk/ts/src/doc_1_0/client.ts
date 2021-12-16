// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchGetWorkspaceDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsRequest extends $tea.Model {
  operatorId?: string;
  nodeIds?: string[];
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingAccessTokenType?: string;
  dingUid?: number;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      nodeIds: 'nodeIds',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingAccessTokenType: 'dingAccessTokenType',
      dingUid: 'dingUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      nodeIds: { 'type': 'array', 'itemType': 'string' },
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingAccessTokenType: 'string',
      dingUid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsResponseBody extends $tea.Model {
  result?: BatchGetWorkspaceDocsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': BatchGetWorkspaceDocsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchGetWorkspaceDocsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchGetWorkspaceDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSheetRequest extends $tea.Model {
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

export class DeleteSheetResponse extends $tea.Model {
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

export class UpdateWorkspaceDocMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceDocMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: UpdateWorkspaceDocMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': UpdateWorkspaceDocMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceDocMembersResponse extends $tea.Model {
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

export class CreateWorkspaceDocHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceDocRequest extends $tea.Model {
  name?: string;
  docType?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      docType: 'docType',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      docType: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceDocResponseBody extends $tea.Model {
  workspaceId?: string;
  nodeId?: string;
  docKey?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      nodeId: 'nodeId',
      docKey: 'docKey',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      nodeId: 'string',
      docKey: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceDocResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateWorkspaceDocResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateWorkspaceDocResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetRequest extends $tea.Model {
  operatorId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetResponseBody extends $tea.Model {
  visibility?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      visibility: 'visibility',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      visibility: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateSheetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceRequest extends $tea.Model {
  name?: string;
  description?: string;
  operatorId?: string;
  dingOrgId?: number;
  dingUid?: number;
  dingAccessTokenType?: string;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      description: 'description',
      operatorId: 'operatorId',
      dingOrgId: 'dingOrgId',
      dingUid: 'dingUid',
      dingAccessTokenType: 'dingAccessTokenType',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      description: 'string',
      operatorId: 'string',
      dingOrgId: 'number',
      dingUid: 'number',
      dingAccessTokenType: 'string',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceResponseBody extends $tea.Model {
  workspaceId?: string;
  name?: string;
  description?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      name: 'name',
      description: 'description',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      name: 'string',
      description: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateWorkspaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateWorkspaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: DeleteWorkspaceDocMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': DeleteWorkspaceDocMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersResponse extends $tea.Model {
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

export class GetWorkspaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceResponseBody extends $tea.Model {
  url?: string;
  isDeleted?: boolean;
  owner?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
      isDeleted: 'isDeleted',
      owner: 'owner',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
      isDeleted: 'boolean',
      owner: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetWorkspaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetWorkspaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsRequest extends $tea.Model {
  workspaceId?: string;
  operatorId?: string;
  keyword?: string;
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      operatorId: 'operatorId',
      keyword: 'keyword',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      operatorId: 'string',
      keyword: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  docs?: SearchWorkspaceDocsResponseBodyDocs[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      docs: 'docs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      docs: { 'type': 'array', 'itemType': SearchWorkspaceDocsResponseBodyDocs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchWorkspaceDocsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchWorkspaceDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRangeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRangeRequest extends $tea.Model {
  operatorId?: string;
  values?: string[][];
  backgroundColors?: string[][];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      values: 'values',
      backgroundColors: 'backgroundColors',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      backgroundColors: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRangeResponse extends $tea.Model {
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

export class BatchGetWorkspacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesRequest extends $tea.Model {
  operatorId?: string;
  includeRecent?: boolean;
  workspaceIds?: string[];
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingUid?: number;
  dingAccessTokenType?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      includeRecent: 'includeRecent',
      workspaceIds: 'workspaceIds',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingUid: 'dingUid',
      dingAccessTokenType: 'dingAccessTokenType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      includeRecent: 'boolean',
      workspaceIds: { 'type': 'array', 'itemType': 'string' },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingUid: 'number',
      dingAccessTokenType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponseBody extends $tea.Model {
  workspaces?: BatchGetWorkspacesResponseBodyWorkspaces[];
  static names(): { [key: string]: string } {
    return {
      workspaces: 'workspaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaces: { 'type': 'array', 'itemType': BatchGetWorkspacesResponseBodyWorkspaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchGetWorkspacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchGetWorkspacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: DeleteWorkspaceMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': DeleteWorkspaceMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceMembersResponse extends $tea.Model {
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

export class AddWorkspaceDocMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceDocMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: AddWorkspaceDocMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': AddWorkspaceDocMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceDocMembersResponse extends $tea.Model {
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

export class UpdateWorkspaceMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: UpdateWorkspaceMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': UpdateWorkspaceMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceMembersResponse extends $tea.Model {
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

export class GetSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSheetRequest extends $tea.Model {
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

export class GetSheetResponseBody extends $tea.Model {
  name?: string[];
  visibility?: string[];
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: { 'type': 'array', 'itemType': 'string' },
      visibility: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSheetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSheetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesRequest extends $tea.Model {
  operatorId?: string;
  includeRecent?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      includeRecent: 'includeRecent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      includeRecent: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesResponseBody extends $tea.Model {
  workspaces?: GetRelatedWorkspacesResponseBodyWorkspaces[];
  static names(): { [key: string]: string } {
    return {
      workspaces: 'workspaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaces: { 'type': 'array', 'itemType': GetRelatedWorkspacesResponseBodyWorkspaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRelatedWorkspacesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRelatedWorkspacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsRequest extends $tea.Model {
  operatorId?: string;
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBody extends $tea.Model {
  recentList?: GetRecentEditDocsResponseBodyRecentList[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      recentList: 'recentList',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recentList: { 'type': 'array', 'itemType': GetRecentEditDocsResponseBodyRecentList },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRecentEditDocsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRecentEditDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersRequest extends $tea.Model {
  operatorId?: string;
  members?: AddWorkspaceMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      members: { 'type': 'array', 'itemType': AddWorkspaceMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersResponseBody extends $tea.Model {
  notInOrgList?: string[];
  static names(): { [key: string]: string } {
    return {
      notInOrgList: 'notInOrgList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notInOrgList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddWorkspaceMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddWorkspaceMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceNodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceNodeRequest extends $tea.Model {
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

export class GetWorkspaceNodeResponseBody extends $tea.Model {
  nodeBO?: GetWorkspaceNodeResponseBodyNodeBO;
  workspaceBO?: GetWorkspaceNodeResponseBodyWorkspaceBO;
  hasPermission?: boolean;
  static names(): { [key: string]: string } {
    return {
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
      hasPermission: 'hasPermission',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeBO: GetWorkspaceNodeResponseBodyNodeBO,
      workspaceBO: GetWorkspaceNodeResponseBodyWorkspaceBO,
      hasPermission: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceNodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetWorkspaceNodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetWorkspaceNodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendRowsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendRowsRequest extends $tea.Model {
  operatorId?: string;
  values?: string[][];
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendRowsResponse extends $tea.Model {
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

export class BatchGetWorkspaceDocsResponseBodyResultNodeBO extends $tea.Model {
  name?: string;
  nodeId?: string;
  url?: string;
  deleted?: boolean;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
      deleted: 'deleted',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      nodeId: 'string',
      url: 'string',
      deleted: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO extends $tea.Model {
  workspaceId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsResponseBodyResult extends $tea.Model {
  nodeBO?: BatchGetWorkspaceDocsResponseBodyResultNodeBO;
  workspaceBO?: BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO;
  hasPermission?: boolean;
  static names(): { [key: string]: string } {
    return {
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
      hasPermission: 'hasPermission',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeBO: BatchGetWorkspaceDocsResponseBodyResultNodeBO,
      workspaceBO: BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO,
      hasPermission: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceDocMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBodyDocsNodeBO extends $tea.Model {
  name?: string;
  nodeId?: string;
  url?: string;
  lastEditTime?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
      lastEditTime: 'lastEditTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      nodeId: 'string',
      url: 'string',
      lastEditTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO extends $tea.Model {
  workspaceId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBodyDocs extends $tea.Model {
  nodeBO?: SearchWorkspaceDocsResponseBodyDocsNodeBO;
  workspaceBO?: SearchWorkspaceDocsResponseBodyDocsWorkspaceBO;
  static names(): { [key: string]: string } {
    return {
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeBO: SearchWorkspaceDocsResponseBodyDocsNodeBO,
      workspaceBO: SearchWorkspaceDocsResponseBodyDocsWorkspaceBO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList extends $tea.Model {
  nodeId?: string;
  name?: string;
  url?: string;
  lastEditTime?: string;
  static names(): { [key: string]: string } {
    return {
      nodeId: 'nodeId',
      name: 'name',
      url: 'url',
      lastEditTime: 'lastEditTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeId: 'string',
      name: 'string',
      url: 'string',
      lastEditTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponseBodyWorkspacesWorkspace extends $tea.Model {
  workspaceId?: string;
  name?: string;
  url?: string;
  recentList?: BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList[];
  orgPublished?: boolean;
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      name: 'name',
      url: 'url',
      recentList: 'recentList',
      orgPublished: 'orgPublished',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      name: 'string',
      url: 'string',
      recentList: { 'type': 'array', 'itemType': BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList },
      orgPublished: 'boolean',
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponseBodyWorkspaces extends $tea.Model {
  hasPermission?: boolean;
  workspace?: BatchGetWorkspacesResponseBodyWorkspacesWorkspace;
  static names(): { [key: string]: string } {
    return {
      hasPermission: 'hasPermission',
      workspace: 'workspace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasPermission: 'boolean',
      workspace: BatchGetWorkspacesResponseBodyWorkspacesWorkspace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceDocMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateWorkspaceMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesResponseBodyWorkspacesRecentList extends $tea.Model {
  nodeId?: string;
  name?: string;
  url?: string;
  lastEditTime?: number;
  static names(): { [key: string]: string } {
    return {
      nodeId: 'nodeId',
      name: 'name',
      url: 'url',
      lastEditTime: 'lastEditTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeId: 'string',
      name: 'string',
      url: 'string',
      lastEditTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesResponseBodyWorkspaces extends $tea.Model {
  workspaceId?: string;
  url?: string;
  deleted?: boolean;
  owner?: string;
  role?: string;
  name?: string;
  recentList?: GetRelatedWorkspacesResponseBodyWorkspacesRecentList[];
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      url: 'url',
      deleted: 'deleted',
      owner: 'owner',
      role: 'role',
      name: 'name',
      recentList: 'recentList',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      url: 'string',
      deleted: 'boolean',
      owner: 'string',
      role: 'string',
      name: 'string',
      recentList: { 'type': 'array', 'itemType': GetRelatedWorkspacesResponseBodyWorkspacesRecentList },
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBodyRecentListNodeBO extends $tea.Model {
  nodeId?: string;
  nodeName?: string;
  url?: string;
  lastEditTime?: number;
  isDeleted?: boolean;
  static names(): { [key: string]: string } {
    return {
      nodeId: 'nodeId',
      nodeName: 'nodeName',
      url: 'url',
      lastEditTime: 'lastEditTime',
      isDeleted: 'isDeleted',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeId: 'string',
      nodeName: 'string',
      url: 'string',
      lastEditTime: 'number',
      isDeleted: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBodyRecentListWorkspaceBO extends $tea.Model {
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      workspaceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBodyRecentList extends $tea.Model {
  nodeBO?: GetRecentEditDocsResponseBodyRecentListNodeBO;
  workspaceBO?: GetRecentEditDocsResponseBodyRecentListWorkspaceBO;
  static names(): { [key: string]: string } {
    return {
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeBO: GetRecentEditDocsResponseBodyRecentListNodeBO,
      workspaceBO: GetRecentEditDocsResponseBodyRecentListWorkspaceBO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceMembersRequestMembers extends $tea.Model {
  memberId?: string;
  memberType?: string;
  roleType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      roleType: 'roleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      roleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceNodeResponseBodyNodeBO extends $tea.Model {
  name?: string;
  nodeId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      nodeId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceNodeResponseBodyWorkspaceBO extends $tea.Model {
  workspaceId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      workspaceId: 'workspaceId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaceId: 'string',
      name: 'string',
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


  async batchGetWorkspaceDocs(request: BatchGetWorkspaceDocsRequest): Promise<BatchGetWorkspaceDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetWorkspaceDocsHeaders({ });
    return await this.batchGetWorkspaceDocsWithOptions(request, headers, runtime);
  }

  async batchGetWorkspaceDocsWithOptions(request: BatchGetWorkspaceDocsRequest, headers: BatchGetWorkspaceDocsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetWorkspaceDocsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.nodeIds)) {
      body["nodeIds"] = request.nodeIds;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingAccessTokenType)) {
      body["dingAccessTokenType"] = request.dingAccessTokenType;
    }

    if (!Util.isUnset(request.dingUid)) {
      body["dingUid"] = request.dingUid;
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
    return $tea.cast<BatchGetWorkspaceDocsResponse>(await this.doROARequest("BatchGetWorkspaceDocs", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/docs/infos/query`, "json", req, runtime), new BatchGetWorkspaceDocsResponse({}));
  }

  async deleteSheet(workbookId: string, sheetId: string, request: DeleteSheetRequest): Promise<DeleteSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSheetHeaders({ });
    return await this.deleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async deleteSheetWithOptions(workbookId: string, sheetId: string, request: DeleteSheetRequest, headers: DeleteSheetHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSheetResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<DeleteSheetResponse>(await this.doROARequest("DeleteSheet", "doc_1.0", "HTTP", "DELETE", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`, "none", req, runtime), new DeleteSheetResponse({}));
  }

  async updateWorkspaceDocMembers(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest): Promise<UpdateWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceDocMembersHeaders({ });
    return await this.updateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async updateWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest, headers: UpdateWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<UpdateWorkspaceDocMembersResponse>(await this.doROARequest("UpdateWorkspaceDocMembers", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`, "none", req, runtime), new UpdateWorkspaceDocMembersResponse({}));
  }

  async createWorkspaceDoc(workspaceId: string, request: CreateWorkspaceDocRequest): Promise<CreateWorkspaceDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceDocHeaders({ });
    return await this.createWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
  }

  async createWorkspaceDocWithOptions(workspaceId: string, request: CreateWorkspaceDocRequest, headers: CreateWorkspaceDocHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkspaceDocResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.docType)) {
      body["docType"] = request.docType;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
    return $tea.cast<CreateWorkspaceDocResponse>(await this.doROARequest("CreateWorkspaceDoc", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs`, "json", req, runtime), new CreateWorkspaceDocResponse({}));
  }

  async createSheet(workbookId: string, request: CreateSheetRequest): Promise<CreateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSheetHeaders({ });
    return await this.createSheetWithOptions(workbookId, request, headers, runtime);
  }

  async createSheetWithOptions(workbookId: string, request: CreateSheetRequest, headers: CreateSheetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSheetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateSheetResponse>(await this.doROARequest("CreateSheet", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets`, "json", req, runtime), new CreateSheetResponse({}));
  }

  async createWorkspace(request: CreateWorkspaceRequest): Promise<CreateWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceHeaders({ });
    return await this.createWorkspaceWithOptions(request, headers, runtime);
  }

  async createWorkspaceWithOptions(request: CreateWorkspaceRequest, headers: CreateWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkspaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingUid)) {
      body["dingUid"] = request.dingUid;
    }

    if (!Util.isUnset(request.dingAccessTokenType)) {
      body["dingAccessTokenType"] = request.dingAccessTokenType;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<CreateWorkspaceResponse>(await this.doROARequest("CreateWorkspace", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces`, "json", req, runtime), new CreateWorkspaceResponse({}));
  }

  async deleteWorkspaceDocMembers(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest): Promise<DeleteWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceDocMembersHeaders({ });
    return await this.deleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async deleteWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest, headers: DeleteWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<DeleteWorkspaceDocMembersResponse>(await this.doROARequest("DeleteWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members/remove`, "none", req, runtime), new DeleteWorkspaceDocMembersResponse({}));
  }

  async getWorkspace(workspaceId: string): Promise<GetWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceHeaders({ });
    return await this.getWorkspaceWithOptions(workspaceId, headers, runtime);
  }

  async getWorkspaceWithOptions(workspaceId: string, headers: GetWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspaceResponse> {
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
    return $tea.cast<GetWorkspaceResponse>(await this.doROARequest("GetWorkspace", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/${workspaceId}`, "json", req, runtime), new GetWorkspaceResponse({}));
  }

  async searchWorkspaceDocs(request: SearchWorkspaceDocsRequest): Promise<SearchWorkspaceDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchWorkspaceDocsHeaders({ });
    return await this.searchWorkspaceDocsWithOptions(request, headers, runtime);
  }

  async searchWorkspaceDocsWithOptions(request: SearchWorkspaceDocsRequest, headers: SearchWorkspaceDocsHeaders, runtime: $Util.RuntimeOptions): Promise<SearchWorkspaceDocsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.workspaceId)) {
      query["workspaceId"] = request.workspaceId;
    }

    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<SearchWorkspaceDocsResponse>(await this.doROARequest("SearchWorkspaceDocs", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/docs`, "json", req, runtime), new SearchWorkspaceDocsResponse({}));
  }

  async updateRange(workbookId: string, sheetId: string, rangeAddress: string, request: UpdateRangeRequest): Promise<UpdateRangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRangeHeaders({ });
    return await this.updateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async updateRangeWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: UpdateRangeRequest, headers: UpdateRangeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRangeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.values)) {
      body["values"] = request.values;
    }

    if (!Util.isUnset(request.backgroundColors)) {
      body["backgroundColors"] = request.backgroundColors;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateRangeResponse>(await this.doROARequest("UpdateRange", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}`, "none", req, runtime), new UpdateRangeResponse({}));
  }

  async batchGetWorkspaces(request: BatchGetWorkspacesRequest): Promise<BatchGetWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetWorkspacesHeaders({ });
    return await this.batchGetWorkspacesWithOptions(request, headers, runtime);
  }

  async batchGetWorkspacesWithOptions(request: BatchGetWorkspacesRequest, headers: BatchGetWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetWorkspacesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.includeRecent)) {
      body["includeRecent"] = request.includeRecent;
    }

    if (!Util.isUnset(request.workspaceIds)) {
      body["workspaceIds"] = request.workspaceIds;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingUid)) {
      body["dingUid"] = request.dingUid;
    }

    if (!Util.isUnset(request.dingAccessTokenType)) {
      body["dingAccessTokenType"] = request.dingAccessTokenType;
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
    return $tea.cast<BatchGetWorkspacesResponse>(await this.doROARequest("BatchGetWorkspaces", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/infos/query`, "json", req, runtime), new BatchGetWorkspacesResponse({}));
  }

  async deleteWorkspaceMembers(workspaceId: string, request: DeleteWorkspaceMembersRequest): Promise<DeleteWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceMembersHeaders({ });
    return await this.deleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async deleteWorkspaceMembersWithOptions(workspaceId: string, request: DeleteWorkspaceMembersRequest, headers: DeleteWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<DeleteWorkspaceMembersResponse>(await this.doROARequest("DeleteWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/members/remove`, "none", req, runtime), new DeleteWorkspaceMembersResponse({}));
  }

  async addWorkspaceDocMembers(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest): Promise<AddWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceDocMembersHeaders({ });
    return await this.addWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async addWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest, headers: AddWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<AddWorkspaceDocMembersResponse>(await this.doROARequest("AddWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`, "none", req, runtime), new AddWorkspaceDocMembersResponse({}));
  }

  async updateWorkspaceMembers(workspaceId: string, request: UpdateWorkspaceMembersRequest): Promise<UpdateWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceMembersHeaders({ });
    return await this.updateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async updateWorkspaceMembersWithOptions(workspaceId: string, request: UpdateWorkspaceMembersRequest, headers: UpdateWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<UpdateWorkspaceMembersResponse>(await this.doROARequest("UpdateWorkspaceMembers", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workspaces/${workspaceId}/members`, "none", req, runtime), new UpdateWorkspaceMembersResponse({}));
  }

  async getSheet(workbookId: string, sheetId: string, request: GetSheetRequest): Promise<GetSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSheetHeaders({ });
    return await this.getSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async getSheetWithOptions(workbookId: string, sheetId: string, request: GetSheetRequest, headers: GetSheetHeaders, runtime: $Util.RuntimeOptions): Promise<GetSheetResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetSheetResponse>(await this.doROARequest("GetSheet", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`, "json", req, runtime), new GetSheetResponse({}));
  }

  async getRelatedWorkspaces(request: GetRelatedWorkspacesRequest): Promise<GetRelatedWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelatedWorkspacesHeaders({ });
    return await this.getRelatedWorkspacesWithOptions(request, headers, runtime);
  }

  async getRelatedWorkspacesWithOptions(request: GetRelatedWorkspacesRequest, headers: GetRelatedWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<GetRelatedWorkspacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.includeRecent)) {
      query["includeRecent"] = request.includeRecent;
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
    return $tea.cast<GetRelatedWorkspacesResponse>(await this.doROARequest("GetRelatedWorkspaces", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces`, "json", req, runtime), new GetRelatedWorkspacesResponse({}));
  }

  async getRecentEditDocs(request: GetRecentEditDocsRequest): Promise<GetRecentEditDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecentEditDocsHeaders({ });
    return await this.getRecentEditDocsWithOptions(request, headers, runtime);
  }

  async getRecentEditDocsWithOptions(request: GetRecentEditDocsRequest, headers: GetRecentEditDocsHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecentEditDocsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetRecentEditDocsResponse>(await this.doROARequest("GetRecentEditDocs", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/docs/recentEditDocs`, "json", req, runtime), new GetRecentEditDocsResponse({}));
  }

  async addWorkspaceMembers(workspaceId: string, request: AddWorkspaceMembersRequest): Promise<AddWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceMembersHeaders({ });
    return await this.addWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async addWorkspaceMembersWithOptions(workspaceId: string, request: AddWorkspaceMembersRequest, headers: AddWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<AddWorkspaceMembersResponse>(await this.doROARequest("AddWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/members`, "json", req, runtime), new AddWorkspaceMembersResponse({}));
  }

  async getWorkspaceNode(workspaceId: string, nodeId: string, request: GetWorkspaceNodeRequest): Promise<GetWorkspaceNodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceNodeHeaders({ });
    return await this.getWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async getWorkspaceNodeWithOptions(workspaceId: string, nodeId: string, request: GetWorkspaceNodeRequest, headers: GetWorkspaceNodeHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspaceNodeResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetWorkspaceNodeResponse>(await this.doROARequest("GetWorkspaceNode", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}`, "json", req, runtime), new GetWorkspaceNodeResponse({}));
  }

  async appendRows(workbookId: string, sheetId: string, request: AppendRowsRequest): Promise<AppendRowsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendRowsHeaders({ });
    return await this.appendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async appendRowsWithOptions(workbookId: string, sheetId: string, request: AppendRowsRequest, headers: AppendRowsHeaders, runtime: $Util.RuntimeOptions): Promise<AppendRowsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.values)) {
      body["values"] = request.values;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AppendRowsResponse>(await this.doROARequest("AppendRows", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/appendRows`, "none", req, runtime), new AppendRowsResponse({}));
  }

}
