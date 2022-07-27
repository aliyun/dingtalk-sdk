// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  members?: AddWorkspaceDocMembersRequestMembers[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': AddWorkspaceDocMembersRequestMembers },
      operatorId: 'string',
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
  members?: AddWorkspaceMembersRequestMembers[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': AddWorkspaceMembersRequestMembers },
      operatorId: 'string',
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
  values?: string[][];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      values: 'values',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      operatorId: 'string',
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
  nodeIds?: string[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      nodeIds: 'nodeIds',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeIds: { 'type': 'array', 'itemType': 'string' },
      operatorId: 'string',
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
  includeRecent?: boolean;
  operatorId?: string;
  workspaceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      includeRecent: 'includeRecent',
      operatorId: 'operatorId',
      workspaceIds: 'workspaceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeRecent: 'boolean',
      operatorId: 'string',
      workspaceIds: { 'type': 'array', 'itemType': 'string' },
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

export class CreateSheetResponseBody extends $tea.Model {
  id?: string;
  name?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      visibility: 'string',
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

export class CreateWorkspaceResponseBody extends $tea.Model {
  description?: string;
  name?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      name: 'name',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      name: 'string',
      url: 'string',
      workspaceId: 'string',
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
  docType?: string;
  name?: string;
  operatorId?: string;
  parentNodeId?: string;
  templateId?: string;
  templateType?: string;
  static names(): { [key: string]: string } {
    return {
      docType: 'docType',
      name: 'name',
      operatorId: 'operatorId',
      parentNodeId: 'parentNodeId',
      templateId: 'templateId',
      templateType: 'templateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docType: 'string',
      name: 'string',
      operatorId: 'string',
      parentNodeId: 'string',
      templateId: 'string',
      templateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateWorkspaceDocResponseBody extends $tea.Model {
  docKey?: string;
  nodeId?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      docKey: 'docKey',
      nodeId: 'nodeId',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docKey: 'string',
      nodeId: 'string',
      url: 'string',
      workspaceId: 'string',
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

export class DeleteWorkspaceDocHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWorkspaceDocRequest extends $tea.Model {
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

export class DeleteWorkspaceDocResponse extends $tea.Model {
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
  members?: DeleteWorkspaceDocMembersRequestMembers[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': DeleteWorkspaceDocMembersRequestMembers },
      operatorId: 'string',
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
  members?: DeleteWorkspaceMembersRequestMembers[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': DeleteWorkspaceMembersRequestMembers },
      operatorId: 'string',
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

export class GetRangeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRangeRequest extends $tea.Model {
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

export class GetRangeResponseBody extends $tea.Model {
  backgroundColors?: GetRangeResponseBodyBackgroundColors[][];
  displayValues?: string[][];
  formulas?: string[][];
  values?: any[][];
  static names(): { [key: string]: string } {
    return {
      backgroundColors: 'backgroundColors',
      displayValues: 'displayValues',
      formulas: 'formulas',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundColors: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': GetRangeResponseBodyBackgroundColors } },
      displayValues: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      formulas: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'any' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRangeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRangeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRangeResponseBody,
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
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBody extends $tea.Model {
  nextToken?: string;
  recentList?: GetRecentEditDocsResponseBodyRecentList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      recentList: 'recentList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      recentList: { 'type': 'array', 'itemType': GetRecentEditDocsResponseBodyRecentList },
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

export class GetRecentOpenDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentOpenDocsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentOpenDocsResponseBody extends $tea.Model {
  nextToken?: string;
  recentList?: GetRecentOpenDocsResponseBodyRecentList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      recentList: 'recentList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      recentList: { 'type': 'array', 'itemType': GetRecentOpenDocsResponseBodyRecentList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentOpenDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetRecentOpenDocsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetRecentOpenDocsResponseBody,
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
  includeRecent?: boolean;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      includeRecent: 'includeRecent',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeRecent: 'boolean',
      operatorId: 'string',
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
  columnCount?: number;
  lastNonEmptyColumn?: number;
  lastNonEmptyRow?: number;
  name?: string;
  rowCount?: number;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      columnCount: 'columnCount',
      lastNonEmptyColumn: 'lastNonEmptyColumn',
      lastNonEmptyRow: 'lastNonEmptyRow',
      name: 'name',
      rowCount: 'rowCount',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      columnCount: 'number',
      lastNonEmptyColumn: 'number',
      lastNonEmptyRow: 'number',
      name: 'string',
      rowCount: 'number',
      visibility: 'string',
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

export class GetTemplateByIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTemplateByIdRequest extends $tea.Model {
  belong?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      belong: 'belong',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belong: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTemplateByIdResponseBody extends $tea.Model {
  coverUrl?: string;
  createTime?: number;
  docType?: string;
  id?: string;
  templateType?: string;
  title?: string;
  updateTime?: number;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      createTime: 'createTime',
      docType: 'docType',
      id: 'id',
      templateType: 'templateType',
      title: 'title',
      updateTime: 'updateTime',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      createTime: 'number',
      docType: 'string',
      id: 'string',
      templateType: 'string',
      title: 'string',
      updateTime: 'number',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTemplateByIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTemplateByIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTemplateByIdResponseBody,
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
  corpId?: string;
  isDeleted?: boolean;
  owner?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isDeleted: 'isDeleted',
      owner: 'owner',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isDeleted: 'boolean',
      owner: 'string',
      url: 'string',
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
  hasPermission?: boolean;
  nodeBO?: GetWorkspaceNodeResponseBodyNodeBO;
  workspaceBO?: GetWorkspaceNodeResponseBodyWorkspaceBO;
  static names(): { [key: string]: string } {
    return {
      hasPermission: 'hasPermission',
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasPermission: 'boolean',
      nodeBO: GetWorkspaceNodeResponseBodyNodeBO,
      workspaceBO: GetWorkspaceNodeResponseBodyWorkspaceBO,
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

export class InsertBlocksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequest extends $tea.Model {
  blocks?: InsertBlocksRequestBlocks[];
  location?: InsertBlocksRequestLocation;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      blocks: 'blocks',
      location: 'location',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blocks: { 'type': 'array', 'itemType': InsertBlocksRequestBlocks },
      location: InsertBlocksRequestLocation,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksResponse extends $tea.Model {
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

export class ListTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTemplateRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  templateType?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      templateType: 'templateType',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      templateType: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTemplateResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  templateList?: ListTemplateResponseBodyTemplateList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      templateList: 'templateList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      templateList: { 'type': 'array', 'itemType': ListTemplateResponseBodyTemplateList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RangeFindNextHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RangeFindNextRequest extends $tea.Model {
  findOptions?: RangeFindNextRequestFindOptions;
  text?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      findOptions: 'findOptions',
      text: 'text',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      findOptions: RangeFindNextRequestFindOptions,
      text: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RangeFindNextResponseBody extends $tea.Model {
  a1Notation?: string;
  static names(): { [key: string]: string } {
    return {
      a1Notation: 'a1Notation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      a1Notation: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RangeFindNextResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RangeFindNextResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RangeFindNextResponseBody,
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
  keyword?: string;
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBody extends $tea.Model {
  docs?: SearchWorkspaceDocsResponseBodyDocs[];
  hasMore?: boolean;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      docs: 'docs',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docs: { 'type': 'array', 'itemType': SearchWorkspaceDocsResponseBodyDocs },
      hasMore: 'boolean',
      nextToken: 'string',
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
  backgroundColors?: string[][];
  hyperlinks?: UpdateRangeRequestHyperlinks[][];
  values?: string[][];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      backgroundColors: 'backgroundColors',
      hyperlinks: 'hyperlinks',
      values: 'values',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundColors: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      hyperlinks: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': UpdateRangeRequestHyperlinks } },
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      operatorId: 'string',
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

export class UpdateSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSheetRequest extends $tea.Model {
  name?: string;
  visibility?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      visibility: 'visibility',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      visibility: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSheetResponse extends $tea.Model {
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
  members?: UpdateWorkspaceDocMembersRequestMembers[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': UpdateWorkspaceDocMembersRequestMembers },
      operatorId: 'string',
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
  members?: UpdateWorkspaceMembersRequestMembers[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      members: 'members',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': UpdateWorkspaceMembersRequestMembers },
      operatorId: 'string',
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

export class BatchGetWorkspaceDocsResponseBodyResultNodeBO extends $tea.Model {
  deleted?: boolean;
  docType?: string;
  lastEditTime?: number;
  name?: string;
  nodeId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      deleted: 'deleted',
      docType: 'docType',
      lastEditTime: 'lastEditTime',
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleted: 'boolean',
      docType: 'string',
      lastEditTime: 'number',
      name: 'string',
      nodeId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO extends $tea.Model {
  name?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspaceDocsResponseBodyResult extends $tea.Model {
  hasPermission?: boolean;
  nodeBO?: BatchGetWorkspaceDocsResponseBodyResultNodeBO;
  workspaceBO?: BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO;
  static names(): { [key: string]: string } {
    return {
      hasPermission: 'hasPermission',
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasPermission: 'boolean',
      nodeBO: BatchGetWorkspaceDocsResponseBodyResultNodeBO,
      workspaceBO: BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList extends $tea.Model {
  lastEditTime?: string;
  name?: string;
  nodeId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      lastEditTime: 'lastEditTime',
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastEditTime: 'string',
      name: 'string',
      nodeId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetWorkspacesResponseBodyWorkspacesWorkspace extends $tea.Model {
  createTime?: number;
  name?: string;
  orgPublished?: boolean;
  recentList?: BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList[];
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      name: 'name',
      orgPublished: 'orgPublished',
      recentList: 'recentList',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      name: 'string',
      orgPublished: 'boolean',
      recentList: { 'type': 'array', 'itemType': BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList },
      url: 'string',
      workspaceId: 'string',
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

export class GetRangeResponseBodyBackgroundColors extends $tea.Model {
  red?: number;
  green?: number;
  blue?: number;
  hexString?: string;
  static names(): { [key: string]: string } {
    return {
      red: 'red',
      green: 'green',
      blue: 'blue',
      hexString: 'hexString',
    };
  }

  static types(): { [key: string]: any } {
    return {
      red: 'number',
      green: 'number',
      blue: 'number',
      hexString: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBodyRecentListNodeBO extends $tea.Model {
  createTime?: number;
  docType?: string;
  isDeleted?: boolean;
  lastEditTime?: number;
  nodeId?: string;
  nodeName?: string;
  updateTime?: number;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      docType: 'docType',
      isDeleted: 'isDeleted',
      lastEditTime: 'lastEditTime',
      nodeId: 'nodeId',
      nodeName: 'nodeName',
      updateTime: 'updateTime',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      docType: 'string',
      isDeleted: 'boolean',
      lastEditTime: 'number',
      nodeId: 'string',
      nodeName: 'string',
      updateTime: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentEditDocsResponseBodyRecentListWorkspaceBO extends $tea.Model {
  url?: string;
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
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

export class GetRecentOpenDocsResponseBodyRecentListNodeBO extends $tea.Model {
  createTime?: number;
  docType?: string;
  isDeleted?: boolean;
  lastOpenTime?: number;
  nodeId?: string;
  nodeName?: string;
  updateTime?: number;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      docType: 'docType',
      isDeleted: 'isDeleted',
      lastOpenTime: 'lastOpenTime',
      nodeId: 'nodeId',
      nodeName: 'nodeName',
      updateTime: 'updateTime',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      docType: 'string',
      isDeleted: 'boolean',
      lastOpenTime: 'number',
      nodeId: 'string',
      nodeName: 'string',
      updateTime: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentOpenDocsResponseBodyRecentListWorkspaceBO extends $tea.Model {
  url?: string;
  workspaceId?: string;
  workspaceName?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
      workspaceId: 'workspaceId',
      workspaceName: 'workspaceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
      workspaceId: 'string',
      workspaceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecentOpenDocsResponseBodyRecentList extends $tea.Model {
  nodeBO?: GetRecentOpenDocsResponseBodyRecentListNodeBO;
  workspaceBO?: GetRecentOpenDocsResponseBodyRecentListWorkspaceBO;
  static names(): { [key: string]: string } {
    return {
      nodeBO: 'nodeBO',
      workspaceBO: 'workspaceBO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeBO: GetRecentOpenDocsResponseBodyRecentListNodeBO,
      workspaceBO: GetRecentOpenDocsResponseBodyRecentListWorkspaceBO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesResponseBodyWorkspacesRecentList extends $tea.Model {
  lastEditTime?: number;
  name?: string;
  nodeId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      lastEditTime: 'lastEditTime',
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastEditTime: 'number',
      name: 'string',
      nodeId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRelatedWorkspacesResponseBodyWorkspaces extends $tea.Model {
  createTime?: number;
  deleted?: boolean;
  name?: string;
  owner?: string;
  recentList?: GetRelatedWorkspacesResponseBodyWorkspacesRecentList[];
  role?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      deleted: 'deleted',
      name: 'name',
      owner: 'owner',
      recentList: 'recentList',
      role: 'role',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      deleted: 'boolean',
      name: 'string',
      owner: 'string',
      recentList: { 'type': 'array', 'itemType': GetRelatedWorkspacesResponseBodyWorkspacesRecentList },
      role: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceNodeResponseBodyNodeBO extends $tea.Model {
  docType?: string;
  lastEditTime?: number;
  name?: string;
  nodeId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      docType: 'docType',
      lastEditTime: 'lastEditTime',
      name: 'name',
      nodeId: 'nodeId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docType: 'string',
      lastEditTime: 'number',
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
  name?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestBlocksParagraphChildrenTextTextStyle extends $tea.Model {
  bold?: boolean;
  dataType?: string;
  fontSize?: number;
  sizeUnit?: string;
  static names(): { [key: string]: string } {
    return {
      bold: 'bold',
      dataType: 'dataType',
      fontSize: 'fontSize',
      sizeUnit: 'sizeUnit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bold: 'boolean',
      dataType: 'string',
      fontSize: 'number',
      sizeUnit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestBlocksParagraphChildrenText extends $tea.Model {
  content?: string;
  textStyle?: InsertBlocksRequestBlocksParagraphChildrenTextTextStyle;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      textStyle: 'textStyle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      textStyle: InsertBlocksRequestBlocksParagraphChildrenTextTextStyle,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestBlocksParagraphChildren extends $tea.Model {
  elementType?: string;
  text?: InsertBlocksRequestBlocksParagraphChildrenText;
  static names(): { [key: string]: string } {
    return {
      elementType: 'elementType',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      elementType: 'string',
      text: InsertBlocksRequestBlocksParagraphChildrenText,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestBlocksParagraphStyle extends $tea.Model {
  headingLevel?: string;
  static names(): { [key: string]: string } {
    return {
      headingLevel: 'headingLevel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headingLevel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestBlocksParagraph extends $tea.Model {
  children?: InsertBlocksRequestBlocksParagraphChildren[];
  style?: InsertBlocksRequestBlocksParagraphStyle;
  static names(): { [key: string]: string } {
    return {
      children: 'children',
      style: 'style',
    };
  }

  static types(): { [key: string]: any } {
    return {
      children: { 'type': 'array', 'itemType': InsertBlocksRequestBlocksParagraphChildren },
      style: InsertBlocksRequestBlocksParagraphStyle,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestBlocks extends $tea.Model {
  blockType?: string;
  paragraph?: InsertBlocksRequestBlocksParagraph;
  static names(): { [key: string]: string } {
    return {
      blockType: 'blockType',
      paragraph: 'paragraph',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blockType: 'string',
      paragraph: InsertBlocksRequestBlocksParagraph,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertBlocksRequestLocation extends $tea.Model {
  head?: boolean;
  static names(): { [key: string]: string } {
    return {
      head: 'head',
    };
  }

  static types(): { [key: string]: any } {
    return {
      head: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTemplateResponseBodyTemplateList extends $tea.Model {
  coverUrl?: string;
  createTime?: number;
  docType?: string;
  id?: string;
  templateType?: string;
  title?: string;
  updateTime?: number;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      createTime: 'createTime',
      docType: 'docType',
      id: 'id',
      templateType: 'templateType',
      title: 'title',
      updateTime: 'updateTime',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      createTime: 'number',
      docType: 'string',
      id: 'string',
      templateType: 'string',
      title: 'string',
      updateTime: 'number',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RangeFindNextRequestFindOptions extends $tea.Model {
  matchCase?: boolean;
  matchEntireCell?: boolean;
  matchFormulaText?: boolean;
  scope?: string;
  useRegExp?: boolean;
  static names(): { [key: string]: string } {
    return {
      matchCase: 'matchCase',
      matchEntireCell: 'matchEntireCell',
      matchFormulaText: 'matchFormulaText',
      scope: 'scope',
      useRegExp: 'useRegExp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      matchCase: 'boolean',
      matchEntireCell: 'boolean',
      matchFormulaText: 'boolean',
      scope: 'string',
      useRegExp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBodyDocsNodeBO extends $tea.Model {
  docType?: string;
  lastEditTime?: number;
  name?: string;
  nodeId?: string;
  originName?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      docType: 'docType',
      lastEditTime: 'lastEditTime',
      name: 'name',
      nodeId: 'nodeId',
      originName: 'originName',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docType: 'string',
      lastEditTime: 'number',
      name: 'string',
      nodeId: 'string',
      originName: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO extends $tea.Model {
  name?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      workspaceId: 'string',
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

export class UpdateRangeRequestHyperlinks extends $tea.Model {
  type?: string;
  link?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      link: 'link',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      link: 'string',
      text: 'string',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async addWorkspaceDocMembers(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest): Promise<AddWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceDocMembersHeaders({ });
    return await this.addWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async addWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest, headers: AddWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    nodeId = OpenApiUtil.getEncodeParam(nodeId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<AddWorkspaceDocMembersResponse>(await this.doROARequest("AddWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`, "none", req, runtime), new AddWorkspaceDocMembersResponse({}));
  }

  async addWorkspaceMembers(workspaceId: string, request: AddWorkspaceMembersRequest): Promise<AddWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceMembersHeaders({ });
    return await this.addWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async addWorkspaceMembersWithOptions(workspaceId: string, request: AddWorkspaceMembersRequest, headers: AddWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceMembersResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<AddWorkspaceMembersResponse>(await this.doROARequest("AddWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/members`, "json", req, runtime), new AddWorkspaceMembersResponse({}));
  }

  async appendRows(workbookId: string, sheetId: string, request: AppendRowsRequest): Promise<AppendRowsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendRowsHeaders({ });
    return await this.appendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async appendRowsWithOptions(workbookId: string, sheetId: string, request: AppendRowsRequest, headers: AppendRowsHeaders, runtime: $Util.RuntimeOptions): Promise<AppendRowsResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AppendRowsResponse>(await this.doROARequest("AppendRows", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/appendRows`, "none", req, runtime), new AppendRowsResponse({}));
  }

  async batchGetWorkspaceDocs(request: BatchGetWorkspaceDocsRequest): Promise<BatchGetWorkspaceDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetWorkspaceDocsHeaders({ });
    return await this.batchGetWorkspaceDocsWithOptions(request, headers, runtime);
  }

  async batchGetWorkspaceDocsWithOptions(request: BatchGetWorkspaceDocsRequest, headers: BatchGetWorkspaceDocsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetWorkspaceDocsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nodeIds)) {
      body["nodeIds"] = request.nodeIds;
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
    return $tea.cast<BatchGetWorkspaceDocsResponse>(await this.doROARequest("BatchGetWorkspaceDocs", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/docs/infos/query`, "json", req, runtime), new BatchGetWorkspaceDocsResponse({}));
  }

  async batchGetWorkspaces(request: BatchGetWorkspacesRequest): Promise<BatchGetWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetWorkspacesHeaders({ });
    return await this.batchGetWorkspacesWithOptions(request, headers, runtime);
  }

  async batchGetWorkspacesWithOptions(request: BatchGetWorkspacesRequest, headers: BatchGetWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetWorkspacesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.includeRecent)) {
      body["includeRecent"] = request.includeRecent;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.workspaceIds)) {
      body["workspaceIds"] = request.workspaceIds;
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
    return $tea.cast<BatchGetWorkspacesResponse>(await this.doROARequest("BatchGetWorkspaces", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/infos/query`, "json", req, runtime), new BatchGetWorkspacesResponse({}));
  }

  async createSheet(workbookId: string, request: CreateSheetRequest): Promise<CreateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSheetHeaders({ });
    return await this.createSheetWithOptions(workbookId, request, headers, runtime);
  }

  async createSheetWithOptions(workbookId: string, request: CreateSheetRequest, headers: CreateSheetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSheetResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
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
    return $tea.cast<CreateWorkspaceResponse>(await this.doROARequest("CreateWorkspace", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces`, "json", req, runtime), new CreateWorkspaceResponse({}));
  }

  async createWorkspaceDoc(workspaceId: string, request: CreateWorkspaceDocRequest): Promise<CreateWorkspaceDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceDocHeaders({ });
    return await this.createWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
  }

  async createWorkspaceDocWithOptions(workspaceId: string, request: CreateWorkspaceDocRequest, headers: CreateWorkspaceDocHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkspaceDocResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.docType)) {
      body["docType"] = request.docType;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.parentNodeId)) {
      body["parentNodeId"] = request.parentNodeId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.templateType)) {
      body["templateType"] = request.templateType;
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
    return $tea.cast<CreateWorkspaceDocResponse>(await this.doROARequest("CreateWorkspaceDoc", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs`, "json", req, runtime), new CreateWorkspaceDocResponse({}));
  }

  async deleteSheet(workbookId: string, sheetId: string, request: DeleteSheetRequest): Promise<DeleteSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSheetHeaders({ });
    return await this.deleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async deleteSheetWithOptions(workbookId: string, sheetId: string, request: DeleteSheetRequest, headers: DeleteSheetHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSheetResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
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
    return $tea.cast<DeleteSheetResponse>(await this.doROARequest("DeleteSheet", "doc_1.0", "HTTP", "DELETE", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`, "none", req, runtime), new DeleteSheetResponse({}));
  }

  async deleteWorkspaceDoc(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocRequest): Promise<DeleteWorkspaceDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceDocHeaders({ });
    return await this.deleteWorkspaceDocWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async deleteWorkspaceDocWithOptions(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocRequest, headers: DeleteWorkspaceDocHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceDocResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    nodeId = OpenApiUtil.getEncodeParam(nodeId);
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
    return $tea.cast<DeleteWorkspaceDocResponse>(await this.doROARequest("DeleteWorkspaceDoc", "doc_1.0", "HTTP", "DELETE", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}`, "none", req, runtime), new DeleteWorkspaceDocResponse({}));
  }

  async deleteWorkspaceDocMembers(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest): Promise<DeleteWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceDocMembersHeaders({ });
    return await this.deleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async deleteWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest, headers: DeleteWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    nodeId = OpenApiUtil.getEncodeParam(nodeId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<DeleteWorkspaceDocMembersResponse>(await this.doROARequest("DeleteWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members/remove`, "none", req, runtime), new DeleteWorkspaceDocMembersResponse({}));
  }

  async deleteWorkspaceMembers(workspaceId: string, request: DeleteWorkspaceMembersRequest): Promise<DeleteWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceMembersHeaders({ });
    return await this.deleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async deleteWorkspaceMembersWithOptions(workspaceId: string, request: DeleteWorkspaceMembersRequest, headers: DeleteWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceMembersResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<DeleteWorkspaceMembersResponse>(await this.doROARequest("DeleteWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workspaces/${workspaceId}/members/remove`, "none", req, runtime), new DeleteWorkspaceMembersResponse({}));
  }

  async getRange(workbookId: string, sheetId: string, rangeAddress: string, request: GetRangeRequest): Promise<GetRangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRangeHeaders({ });
    return await this.getRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async getRangeWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: GetRangeRequest, headers: GetRangeHeaders, runtime: $Util.RuntimeOptions): Promise<GetRangeResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
    rangeAddress = OpenApiUtil.getEncodeParam(rangeAddress);
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
    return $tea.cast<GetRangeResponse>(await this.doROARequest("GetRange", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}`, "json", req, runtime), new GetRangeResponse({}));
  }

  async getRecentEditDocs(request: GetRecentEditDocsRequest): Promise<GetRecentEditDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecentEditDocsHeaders({ });
    return await this.getRecentEditDocsWithOptions(request, headers, runtime);
  }

  async getRecentEditDocsWithOptions(request: GetRecentEditDocsRequest, headers: GetRecentEditDocsHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecentEditDocsResponse> {
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
    return $tea.cast<GetRecentEditDocsResponse>(await this.doROARequest("GetRecentEditDocs", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/docs/recentEditDocs`, "json", req, runtime), new GetRecentEditDocsResponse({}));
  }

  async getRecentOpenDocs(request: GetRecentOpenDocsRequest): Promise<GetRecentOpenDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecentOpenDocsHeaders({ });
    return await this.getRecentOpenDocsWithOptions(request, headers, runtime);
  }

  async getRecentOpenDocsWithOptions(request: GetRecentOpenDocsRequest, headers: GetRecentOpenDocsHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecentOpenDocsResponse> {
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
    return $tea.cast<GetRecentOpenDocsResponse>(await this.doROARequest("GetRecentOpenDocs", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/docs/recentOpenDocs`, "json", req, runtime), new GetRecentOpenDocsResponse({}));
  }

  async getRelatedWorkspaces(request: GetRelatedWorkspacesRequest): Promise<GetRelatedWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelatedWorkspacesHeaders({ });
    return await this.getRelatedWorkspacesWithOptions(request, headers, runtime);
  }

  async getRelatedWorkspacesWithOptions(request: GetRelatedWorkspacesRequest, headers: GetRelatedWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<GetRelatedWorkspacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.includeRecent)) {
      query["includeRecent"] = request.includeRecent;
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
    return $tea.cast<GetRelatedWorkspacesResponse>(await this.doROARequest("GetRelatedWorkspaces", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces`, "json", req, runtime), new GetRelatedWorkspacesResponse({}));
  }

  async getSheet(workbookId: string, sheetId: string, request: GetSheetRequest): Promise<GetSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSheetHeaders({ });
    return await this.getSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async getSheetWithOptions(workbookId: string, sheetId: string, request: GetSheetRequest, headers: GetSheetHeaders, runtime: $Util.RuntimeOptions): Promise<GetSheetResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
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
    return $tea.cast<GetSheetResponse>(await this.doROARequest("GetSheet", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`, "json", req, runtime), new GetSheetResponse({}));
  }

  async getTemplateById(templateId: string, request: GetTemplateByIdRequest): Promise<GetTemplateByIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTemplateByIdHeaders({ });
    return await this.getTemplateByIdWithOptions(templateId, request, headers, runtime);
  }

  async getTemplateByIdWithOptions(templateId: string, request: GetTemplateByIdRequest, headers: GetTemplateByIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetTemplateByIdResponse> {
    Util.validateModel(request);
    templateId = OpenApiUtil.getEncodeParam(templateId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.belong)) {
      query["belong"] = request.belong;
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
    return $tea.cast<GetTemplateByIdResponse>(await this.doROARequest("GetTemplateById", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/templates/${templateId}`, "json", req, runtime), new GetTemplateByIdResponse({}));
  }

  async getWorkspace(workspaceId: string): Promise<GetWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceHeaders({ });
    return await this.getWorkspaceWithOptions(workspaceId, headers, runtime);
  }

  async getWorkspaceWithOptions(workspaceId: string, headers: GetWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspaceResponse> {
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
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
    return $tea.cast<GetWorkspaceResponse>(await this.doROARequest("GetWorkspace", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/${workspaceId}`, "json", req, runtime), new GetWorkspaceResponse({}));
  }

  async getWorkspaceNode(workspaceId: string, nodeId: string, request: GetWorkspaceNodeRequest): Promise<GetWorkspaceNodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceNodeHeaders({ });
    return await this.getWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async getWorkspaceNodeWithOptions(workspaceId: string, nodeId: string, request: GetWorkspaceNodeRequest, headers: GetWorkspaceNodeHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspaceNodeResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    nodeId = OpenApiUtil.getEncodeParam(nodeId);
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
    return $tea.cast<GetWorkspaceNodeResponse>(await this.doROARequest("GetWorkspaceNode", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}`, "json", req, runtime), new GetWorkspaceNodeResponse({}));
  }

  async insertBlocks(documentId: string, request: InsertBlocksRequest): Promise<InsertBlocksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertBlocksHeaders({ });
    return await this.insertBlocksWithOptions(documentId, request, headers, runtime);
  }

  async insertBlocksWithOptions(documentId: string, request: InsertBlocksRequest, headers: InsertBlocksHeaders, runtime: $Util.RuntimeOptions): Promise<InsertBlocksResponse> {
    Util.validateModel(request);
    documentId = OpenApiUtil.getEncodeParam(documentId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blocks)) {
      body["blocks"] = request.blocks;
    }

    if (!Util.isUnset($tea.toMap(request.location))) {
      body["location"] = request.location;
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
    return $tea.cast<InsertBlocksResponse>(await this.doROARequest("InsertBlocks", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/documents/${documentId}/blocks`, "none", req, runtime), new InsertBlocksResponse({}));
  }

  async listTemplate(request: ListTemplateRequest): Promise<ListTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTemplateHeaders({ });
    return await this.listTemplateWithOptions(request, headers, runtime);
  }

  async listTemplateWithOptions(request: ListTemplateRequest, headers: ListTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<ListTemplateResponse> {
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

    if (!Util.isUnset(request.templateType)) {
      query["templateType"] = request.templateType;
    }

    if (!Util.isUnset(request.workspaceId)) {
      query["workspaceId"] = request.workspaceId;
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
    return $tea.cast<ListTemplateResponse>(await this.doROARequest("ListTemplate", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/templates`, "json", req, runtime), new ListTemplateResponse({}));
  }

  async rangeFindNext(workbookId: string, sheetId: string, rangeAddress: string, request: RangeFindNextRequest): Promise<RangeFindNextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RangeFindNextHeaders({ });
    return await this.rangeFindNextWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async rangeFindNextWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: RangeFindNextRequest, headers: RangeFindNextHeaders, runtime: $Util.RuntimeOptions): Promise<RangeFindNextResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
    rangeAddress = OpenApiUtil.getEncodeParam(rangeAddress);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.findOptions))) {
      body["findOptions"] = request.findOptions;
    }

    if (!Util.isUnset(request.text)) {
      body["text"] = request.text;
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
    return $tea.cast<RangeFindNextResponse>(await this.doROARequest("RangeFindNext", "doc_1.0", "HTTP", "POST", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/findNext`, "json", req, runtime), new RangeFindNextResponse({}));
  }

  async searchWorkspaceDocs(request: SearchWorkspaceDocsRequest): Promise<SearchWorkspaceDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchWorkspaceDocsHeaders({ });
    return await this.searchWorkspaceDocsWithOptions(request, headers, runtime);
  }

  async searchWorkspaceDocsWithOptions(request: SearchWorkspaceDocsRequest, headers: SearchWorkspaceDocsHeaders, runtime: $Util.RuntimeOptions): Promise<SearchWorkspaceDocsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
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

    if (!Util.isUnset(request.workspaceId)) {
      query["workspaceId"] = request.workspaceId;
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
    return $tea.cast<SearchWorkspaceDocsResponse>(await this.doROARequest("SearchWorkspaceDocs", "doc_1.0", "HTTP", "GET", "AK", `/v1.0/doc/docs`, "json", req, runtime), new SearchWorkspaceDocsResponse({}));
  }

  async updateRange(workbookId: string, sheetId: string, rangeAddress: string, request: UpdateRangeRequest): Promise<UpdateRangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRangeHeaders({ });
    return await this.updateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async updateRangeWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: UpdateRangeRequest, headers: UpdateRangeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRangeResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
    rangeAddress = OpenApiUtil.getEncodeParam(rangeAddress);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.backgroundColors)) {
      body["backgroundColors"] = request.backgroundColors;
    }

    if (!Util.isUnset(request.hyperlinks)) {
      body["hyperlinks"] = request.hyperlinks;
    }

    if (!Util.isUnset(request.values)) {
      body["values"] = request.values;
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
    return $tea.cast<UpdateRangeResponse>(await this.doROARequest("UpdateRange", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}`, "none", req, runtime), new UpdateRangeResponse({}));
  }

  async updateSheet(workbookId: string, sheetId: string, request: UpdateSheetRequest): Promise<UpdateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSheetHeaders({ });
    return await this.updateSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async updateSheetWithOptions(workbookId: string, sheetId: string, request: UpdateSheetRequest, headers: UpdateSheetHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSheetResponse> {
    Util.validateModel(request);
    workbookId = OpenApiUtil.getEncodeParam(workbookId);
    sheetId = OpenApiUtil.getEncodeParam(sheetId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.visibility)) {
      body["visibility"] = request.visibility;
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
    return $tea.cast<UpdateSheetResponse>(await this.doROARequest("UpdateSheet", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`, "none", req, runtime), new UpdateSheetResponse({}));
  }

  async updateWorkspaceDocMembers(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest): Promise<UpdateWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceDocMembersHeaders({ });
    return await this.updateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async updateWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest, headers: UpdateWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceDocMembersResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    nodeId = OpenApiUtil.getEncodeParam(nodeId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<UpdateWorkspaceDocMembersResponse>(await this.doROARequest("UpdateWorkspaceDocMembers", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`, "none", req, runtime), new UpdateWorkspaceDocMembersResponse({}));
  }

  async updateWorkspaceMembers(workspaceId: string, request: UpdateWorkspaceMembersRequest): Promise<UpdateWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceMembersHeaders({ });
    return await this.updateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async updateWorkspaceMembersWithOptions(workspaceId: string, request: UpdateWorkspaceMembersRequest, headers: UpdateWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceMembersResponse> {
    Util.validateModel(request);
    workspaceId = OpenApiUtil.getEncodeParam(workspaceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
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
    return $tea.cast<UpdateWorkspaceMembersResponse>(await this.doROARequest("UpdateWorkspaceMembers", "doc_1.0", "HTTP", "PUT", "AK", `/v1.0/doc/workspaces/${workspaceId}/members`, "none", req, runtime), new UpdateWorkspaceMembersResponse({}));
  }

}
