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

export class AddTeamHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamRequest extends $tea.Model {
  name?: string;
  option?: AddTeamRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      option: AddTeamRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamResponseBody extends $tea.Model {
  team?: AddTeamResponseBodyTeam;
  static names(): { [key: string]: string } {
    return {
      team: 'team',
    };
  }

  static types(): { [key: string]: any } {
    return {
      team: AddTeamResponseBodyTeam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddTeamResponseBody;
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
      body: AddTeamResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceRequest extends $tea.Model {
  name?: string;
  option?: AddWorkspaceRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      option: AddWorkspaceRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceResponseBody extends $tea.Model {
  workspace?: AddWorkspaceResponseBodyWorkspace;
  static names(): { [key: string]: string } {
    return {
      workspace: 'workspace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspace: AddWorkspaceResponseBodyWorkspace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddWorkspaceResponseBody;
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
      body: AddWorkspaceResponseBody,
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

export class DeleteTeamResponseBody extends $tea.Model {
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

export class DeleteTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteTeamResponseBody;
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
      body: DeleteTeamResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultHandOverUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultHandOverUserRequest extends $tea.Model {
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

export class GetDefaultHandOverUserResponseBody extends $tea.Model {
  defaultHandoverUserId?: string;
  static names(): { [key: string]: string } {
    return {
      defaultHandoverUserId: 'defaultHandoverUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultHandoverUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultHandOverUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDefaultHandOverUserResponseBody;
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
      body: GetDefaultHandOverUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMineWorkspaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMineWorkspaceRequest extends $tea.Model {
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

export class GetMineWorkspaceResponseBody extends $tea.Model {
  workspace?: GetMineWorkspaceResponseBodyWorkspace;
  static names(): { [key: string]: string } {
    return {
      workspace: 'workspace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspace: GetMineWorkspaceResponseBodyWorkspace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMineWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMineWorkspaceResponseBody;
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
      body: GetMineWorkspaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeRequest extends $tea.Model {
  operatorId?: string;
  withPermissionRole?: boolean;
  withStatisticalInfo?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      withPermissionRole: 'withPermissionRole',
      withStatisticalInfo: 'withStatisticalInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      withPermissionRole: 'boolean',
      withStatisticalInfo: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeResponseBody extends $tea.Model {
  node?: GetNodeResponseBodyNode;
  static names(): { [key: string]: string } {
    return {
      node: 'node',
    };
  }

  static types(): { [key: string]: any } {
    return {
      node: GetNodeResponseBodyNode,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetNodeResponseBody;
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
      body: GetNodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeByUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeByUrlRequest extends $tea.Model {
  option?: GetNodeByUrlRequestOption;
  url?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      url: 'url',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetNodeByUrlRequestOption,
      url: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeByUrlResponseBody extends $tea.Model {
  node?: GetNodeByUrlResponseBodyNode;
  static names(): { [key: string]: string } {
    return {
      node: 'node',
    };
  }

  static types(): { [key: string]: any } {
    return {
      node: GetNodeByUrlResponseBodyNode,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeByUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetNodeByUrlResponseBody;
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
      body: GetNodeByUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodesRequest extends $tea.Model {
  nodeIds?: string[];
  option?: GetNodesRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      nodeIds: 'nodeIds',
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodeIds: { 'type': 'array', 'itemType': 'string' },
      option: GetNodesRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodesResponseBody extends $tea.Model {
  nodes?: GetNodesResponseBodyNodes[];
  static names(): { [key: string]: string } {
    return {
      nodes: 'nodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nodes: { 'type': 'array', 'itemType': GetNodesResponseBodyNodes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetNodesResponseBody;
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
      body: GetNodesResponseBody,
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

export class GetTeamResponseBody extends $tea.Model {
  team?: GetTeamResponseBodyTeam;
  static names(): { [key: string]: string } {
    return {
      team: 'team',
    };
  }

  static types(): { [key: string]: any } {
    return {
      team: GetTeamResponseBodyTeam,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTeamResponseBody;
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
      body: GetTeamResponseBody,
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

export class GetWorkspaceRequest extends $tea.Model {
  operatorId?: string;
  withPermissionRole?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      withPermissionRole: 'withPermissionRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      withPermissionRole: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceResponseBody extends $tea.Model {
  workspace?: GetWorkspaceResponseBodyWorkspace;
  static names(): { [key: string]: string } {
    return {
      workspace: 'workspace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspace: GetWorkspaceResponseBodyWorkspace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetWorkspaceResponseBody;
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
      body: GetWorkspaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesRequest extends $tea.Model {
  option?: GetWorkspacesRequestOption;
  workspaceIds?: string[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      workspaceIds: 'workspaceIds',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetWorkspacesRequestOption,
      workspaceIds: { 'type': 'array', 'itemType': 'string' },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesResponseBody extends $tea.Model {
  workspaces?: GetWorkspacesResponseBodyWorkspaces[];
  static names(): { [key: string]: string } {
    return {
      workspaces: 'workspaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workspaces: { 'type': 'array', 'itemType': GetWorkspacesResponseBodyWorkspaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetWorkspacesResponseBody;
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
      body: GetWorkspacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HandOverWorkspaceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HandOverWorkspaceRequest extends $tea.Model {
  sourceOwnerId?: string;
  targetOwnerId?: string;
  workspaceId?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      sourceOwnerId: 'sourceOwnerId',
      targetOwnerId: 'targetOwnerId',
      workspaceId: 'workspaceId',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sourceOwnerId: 'string',
      targetOwnerId: 'string',
      workspaceId: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HandOverWorkspaceResponseBody extends $tea.Model {
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

export class HandOverWorkspaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: HandOverWorkspaceResponseBody;
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
      body: HandOverWorkspaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNodesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNodesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  parentNodeId?: string;
  withPermissionRole?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      parentNodeId: 'parentNodeId',
      withPermissionRole: 'withPermissionRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      parentNodeId: 'string',
      withPermissionRole: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNodesResponseBody extends $tea.Model {
  nextToken?: string;
  nodes?: ListNodesResponseBodyNodes[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      nodes: 'nodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      nodes: { 'type': 'array', 'itemType': ListNodesResponseBodyNodes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNodesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListNodesResponseBody;
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
      body: ListNodesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamsRequest extends $tea.Model {
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

export class ListTeamsResponseBody extends $tea.Model {
  nextToken?: string;
  teams?: ListTeamsResponseBodyTeams[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      teams: 'teams',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      teams: { 'type': 'array', 'itemType': ListTeamsResponseBodyTeams },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListTeamsResponseBody;
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
      body: ListTeamsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkspacesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkspacesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  operatorId?: string;
  orderBy?: string;
  teamId?: string;
  withPermissionRole?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorId: 'operatorId',
      orderBy: 'orderBy',
      teamId: 'teamId',
      withPermissionRole: 'withPermissionRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      operatorId: 'string',
      orderBy: 'string',
      teamId: 'string',
      withPermissionRole: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkspacesResponseBody extends $tea.Model {
  nextToken?: string;
  workspaces?: ListWorkspacesResponseBodyWorkspaces[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      workspaces: 'workspaces',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      workspaces: { 'type': 'array', 'itemType': ListWorkspacesResponseBodyWorkspaces },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkspacesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListWorkspacesResponseBody;
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
      body: ListWorkspacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDefaultHandOverUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDefaultHandOverUserRequest extends $tea.Model {
  defaultHandoverUserId?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      defaultHandoverUserId: 'defaultHandoverUserId',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultHandoverUserId: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDefaultHandOverUserResponseBody extends $tea.Model {
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

export class SetDefaultHandOverUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetDefaultHandOverUserResponseBody;
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
      body: SetDefaultHandOverUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamRequestOptionIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamRequestOption extends $tea.Model {
  cover?: string;
  description?: string;
  icon?: AddTeamRequestOptionIcon;
  static names(): { [key: string]: string } {
    return {
      cover: 'cover',
      description: 'description',
      icon: 'icon',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cover: 'string',
      description: 'string',
      icon: AddTeamRequestOptionIcon,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamResponseBodyTeamIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTeamResponseBodyTeam extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: AddTeamResponseBodyTeamIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: AddTeamResponseBodyTeamIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceRequestOption extends $tea.Model {
  description?: string;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceResponseBodyWorkspaceIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddWorkspaceResponseBodyWorkspace extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: AddWorkspaceResponseBodyWorkspaceIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  permissionRole?: string;
  rootNodeId?: string;
  teamId?: string;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      permissionRole: 'permissionRole',
      rootNodeId: 'rootNodeId',
      teamId: 'teamId',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: AddWorkspaceResponseBodyWorkspaceIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      permissionRole: 'string',
      rootNodeId: 'string',
      teamId: 'string',
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMineWorkspaceResponseBodyWorkspaceIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMineWorkspaceResponseBodyWorkspace extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: GetMineWorkspaceResponseBodyWorkspaceIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  permissionRole?: string;
  rootNodeId?: string;
  teamId?: string;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      permissionRole: 'permissionRole',
      rootNodeId: 'rootNodeId',
      teamId: 'teamId',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: GetMineWorkspaceResponseBodyWorkspaceIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      permissionRole: 'string',
      rootNodeId: 'string',
      teamId: 'string',
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeResponseBodyNodeStatisticalInfo extends $tea.Model {
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

export class GetNodeResponseBodyNode extends $tea.Model {
  category?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  hasChildren?: boolean;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  nodeId?: string;
  permissionRole?: string;
  size?: number;
  statisticalInfo?: GetNodeResponseBodyNodeStatisticalInfo;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      hasChildren: 'hasChildren',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      nodeId: 'nodeId',
      permissionRole: 'permissionRole',
      size: 'size',
      statisticalInfo: 'statisticalInfo',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      hasChildren: 'boolean',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      nodeId: 'string',
      permissionRole: 'string',
      size: 'number',
      statisticalInfo: GetNodeResponseBodyNodeStatisticalInfo,
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeByUrlRequestOption extends $tea.Model {
  withPermissionRole?: boolean;
  withStatisticalInfo?: boolean;
  static names(): { [key: string]: string } {
    return {
      withPermissionRole: 'withPermissionRole',
      withStatisticalInfo: 'withStatisticalInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      withPermissionRole: 'boolean',
      withStatisticalInfo: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodeByUrlResponseBodyNodeStatisticalInfo extends $tea.Model {
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

export class GetNodeByUrlResponseBodyNode extends $tea.Model {
  category?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  hasChildren?: boolean;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  nodeId?: string;
  permissionRole?: string;
  size?: number;
  statisticalInfo?: GetNodeByUrlResponseBodyNodeStatisticalInfo;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      hasChildren: 'hasChildren',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      nodeId: 'nodeId',
      permissionRole: 'permissionRole',
      size: 'size',
      statisticalInfo: 'statisticalInfo',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      hasChildren: 'boolean',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      nodeId: 'string',
      permissionRole: 'string',
      size: 'number',
      statisticalInfo: GetNodeByUrlResponseBodyNodeStatisticalInfo,
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodesRequestOption extends $tea.Model {
  withPermissionRole?: boolean;
  withStatisticalInfo?: boolean;
  static names(): { [key: string]: string } {
    return {
      withPermissionRole: 'withPermissionRole',
      withStatisticalInfo: 'withStatisticalInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      withPermissionRole: 'boolean',
      withStatisticalInfo: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNodesResponseBodyNodesStatisticalInfo extends $tea.Model {
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

export class GetNodesResponseBodyNodes extends $tea.Model {
  category?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  hasChildren?: boolean;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  nodeId?: string;
  permissionRole?: string;
  size?: number;
  statisticalInfo?: GetNodesResponseBodyNodesStatisticalInfo;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      hasChildren: 'hasChildren',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      nodeId: 'nodeId',
      permissionRole: 'permissionRole',
      size: 'size',
      statisticalInfo: 'statisticalInfo',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      hasChildren: 'boolean',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      nodeId: 'string',
      permissionRole: 'string',
      size: 'number',
      statisticalInfo: GetNodesResponseBodyNodesStatisticalInfo,
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTeamResponseBodyTeamIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTeamResponseBodyTeam extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: GetTeamResponseBodyTeamIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: GetTeamResponseBodyTeamIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceResponseBodyWorkspaceIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspaceResponseBodyWorkspace extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: GetWorkspaceResponseBodyWorkspaceIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  permissionRole?: string;
  rootNodeId?: string;
  teamId?: string;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      permissionRole: 'permissionRole',
      rootNodeId: 'rootNodeId',
      teamId: 'teamId',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: GetWorkspaceResponseBodyWorkspaceIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      permissionRole: 'string',
      rootNodeId: 'string',
      teamId: 'string',
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesRequestOption extends $tea.Model {
  withPermissionRole?: boolean;
  static names(): { [key: string]: string } {
    return {
      withPermissionRole: 'withPermissionRole',
    };
  }

  static types(): { [key: string]: any } {
    return {
      withPermissionRole: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesResponseBodyWorkspacesIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkspacesResponseBodyWorkspaces extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: GetWorkspacesResponseBodyWorkspacesIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  permissionRole?: string;
  rootNodeId?: string;
  teamId?: string;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      permissionRole: 'permissionRole',
      rootNodeId: 'rootNodeId',
      teamId: 'teamId',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: GetWorkspacesResponseBodyWorkspacesIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      permissionRole: 'string',
      rootNodeId: 'string',
      teamId: 'string',
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListNodesResponseBodyNodesStatisticalInfo extends $tea.Model {
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

export class ListNodesResponseBodyNodes extends $tea.Model {
  category?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  hasChildren?: boolean;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  nodeId?: string;
  permissionRole?: string;
  size?: number;
  statisticalInfo?: ListNodesResponseBodyNodesStatisticalInfo;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      hasChildren: 'hasChildren',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      nodeId: 'nodeId',
      permissionRole: 'permissionRole',
      size: 'size',
      statisticalInfo: 'statisticalInfo',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      hasChildren: 'boolean',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      nodeId: 'string',
      permissionRole: 'string',
      size: 'number',
      statisticalInfo: ListNodesResponseBodyNodesStatisticalInfo,
      type: 'string',
      url: 'string',
      workspaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamsResponseBodyTeamsIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTeamsResponseBodyTeams extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: ListTeamsResponseBodyTeamsIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  teamId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      teamId: 'teamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: ListTeamsResponseBodyTeamsIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      teamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkspacesResponseBodyWorkspacesIcon extends $tea.Model {
  type?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkspacesResponseBodyWorkspaces extends $tea.Model {
  corpId?: string;
  cover?: string;
  createTime?: string;
  creatorId?: string;
  description?: string;
  icon?: ListWorkspacesResponseBodyWorkspacesIcon;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  permissionRole?: string;
  rootNodeId?: string;
  teamId?: string;
  type?: string;
  url?: string;
  workspaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      cover: 'cover',
      createTime: 'createTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      permissionRole: 'permissionRole',
      rootNodeId: 'rootNodeId',
      teamId: 'teamId',
      type: 'type',
      url: 'url',
      workspaceId: 'workspaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      cover: 'string',
      createTime: 'string',
      creatorId: 'string',
      description: 'string',
      icon: ListWorkspacesResponseBodyWorkspacesIcon,
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      permissionRole: 'string',
      rootNodeId: 'string',
      teamId: 'string',
      type: 'string',
      url: 'string',
      workspaceId: 'string',
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


  async addTeamWithOptions(request: AddTeamRequest, headers: AddTeamHeaders, runtime: $Util.RuntimeOptions): Promise<AddTeamResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

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
      action: "AddTeam",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/teams`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddTeamResponse>(await this.execute(params, req, runtime), new AddTeamResponse({}));
  }

  async addTeam(request: AddTeamRequest): Promise<AddTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddTeamHeaders({ });
    return await this.addTeamWithOptions(request, headers, runtime);
  }

  async addWorkspaceWithOptions(request: AddWorkspaceRequest, headers: AddWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

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
      action: "AddWorkspace",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/workspaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddWorkspaceResponse>(await this.execute(params, req, runtime), new AddWorkspaceResponse({}));
  }

  async addWorkspace(request: AddWorkspaceRequest): Promise<AddWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceHeaders({ });
    return await this.addWorkspaceWithOptions(request, headers, runtime);
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
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/teams/${teamId}`,
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

  async getDefaultHandOverUserWithOptions(request: GetDefaultHandOverUserRequest, headers: GetDefaultHandOverUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetDefaultHandOverUserResponse> {
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
      action: "GetDefaultHandOverUser",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/managementSettings/defaultHandOverUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDefaultHandOverUserResponse>(await this.execute(params, req, runtime), new GetDefaultHandOverUserResponse({}));
  }

  async getDefaultHandOverUser(request: GetDefaultHandOverUserRequest): Promise<GetDefaultHandOverUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDefaultHandOverUserHeaders({ });
    return await this.getDefaultHandOverUserWithOptions(request, headers, runtime);
  }

  async getMineWorkspaceWithOptions(request: GetMineWorkspaceRequest, headers: GetMineWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetMineWorkspaceResponse> {
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
      action: "GetMineWorkspace",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/mineWorkspaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMineWorkspaceResponse>(await this.execute(params, req, runtime), new GetMineWorkspaceResponse({}));
  }

  async getMineWorkspace(request: GetMineWorkspaceRequest): Promise<GetMineWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMineWorkspaceHeaders({ });
    return await this.getMineWorkspaceWithOptions(request, headers, runtime);
  }

  async getNodeWithOptions(nodeId: string, request: GetNodeRequest, headers: GetNodeHeaders, runtime: $Util.RuntimeOptions): Promise<GetNodeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.withPermissionRole)) {
      query["withPermissionRole"] = request.withPermissionRole;
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
      action: "GetNode",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/nodes/${nodeId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNodeResponse>(await this.execute(params, req, runtime), new GetNodeResponse({}));
  }

  async getNode(nodeId: string, request: GetNodeRequest): Promise<GetNodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNodeHeaders({ });
    return await this.getNodeWithOptions(nodeId, request, headers, runtime);
  }

  async getNodeByUrlWithOptions(request: GetNodeByUrlRequest, headers: GetNodeByUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetNodeByUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
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
      action: "GetNodeByUrl",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/nodes/queryByUrl`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNodeByUrlResponse>(await this.execute(params, req, runtime), new GetNodeByUrlResponse({}));
  }

  async getNodeByUrl(request: GetNodeByUrlRequest): Promise<GetNodeByUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNodeByUrlHeaders({ });
    return await this.getNodeByUrlWithOptions(request, headers, runtime);
  }

  async getNodesWithOptions(request: GetNodesRequest, headers: GetNodesHeaders, runtime: $Util.RuntimeOptions): Promise<GetNodesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nodeIds)) {
      body["nodeIds"] = request.nodeIds;
    }

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
      action: "GetNodes",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/nodes/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNodesResponse>(await this.execute(params, req, runtime), new GetNodesResponse({}));
  }

  async getNodes(request: GetNodesRequest): Promise<GetNodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNodesHeaders({ });
    return await this.getNodesWithOptions(request, headers, runtime);
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
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/teams/${teamId}`,
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

  async getWorkspaceWithOptions(workspaceId: string, request: GetWorkspaceRequest, headers: GetWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.withPermissionRole)) {
      query["withPermissionRole"] = request.withPermissionRole;
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
      action: "GetWorkspace",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/workspaces/${workspaceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWorkspaceResponse>(await this.execute(params, req, runtime), new GetWorkspaceResponse({}));
  }

  async getWorkspace(workspaceId: string, request: GetWorkspaceRequest): Promise<GetWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceHeaders({ });
    return await this.getWorkspaceWithOptions(workspaceId, request, headers, runtime);
  }

  async getWorkspacesWithOptions(request: GetWorkspacesRequest, headers: GetWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspacesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetWorkspaces",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/workspaces/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWorkspacesResponse>(await this.execute(params, req, runtime), new GetWorkspacesResponse({}));
  }

  async getWorkspaces(request: GetWorkspacesRequest): Promise<GetWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspacesHeaders({ });
    return await this.getWorkspacesWithOptions(request, headers, runtime);
  }

  async handOverWorkspaceWithOptions(request: HandOverWorkspaceRequest, headers: HandOverWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<HandOverWorkspaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sourceOwnerId)) {
      body["sourceOwnerId"] = request.sourceOwnerId;
    }

    if (!Util.isUnset(request.targetOwnerId)) {
      body["targetOwnerId"] = request.targetOwnerId;
    }

    if (!Util.isUnset(request.workspaceId)) {
      body["workspaceId"] = request.workspaceId;
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
      action: "HandOverWorkspace",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/managementOperations/workspaces/handOver`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HandOverWorkspaceResponse>(await this.execute(params, req, runtime), new HandOverWorkspaceResponse({}));
  }

  async handOverWorkspace(request: HandOverWorkspaceRequest): Promise<HandOverWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HandOverWorkspaceHeaders({ });
    return await this.handOverWorkspaceWithOptions(request, headers, runtime);
  }

  async listNodesWithOptions(request: ListNodesRequest, headers: ListNodesHeaders, runtime: $Util.RuntimeOptions): Promise<ListNodesResponse> {
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

    if (!Util.isUnset(request.parentNodeId)) {
      query["parentNodeId"] = request.parentNodeId;
    }

    if (!Util.isUnset(request.withPermissionRole)) {
      query["withPermissionRole"] = request.withPermissionRole;
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
      action: "ListNodes",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/nodes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListNodesResponse>(await this.execute(params, req, runtime), new ListNodesResponse({}));
  }

  async listNodes(request: ListNodesRequest): Promise<ListNodesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListNodesHeaders({ });
    return await this.listNodesWithOptions(request, headers, runtime);
  }

  async listTeamsWithOptions(request: ListTeamsRequest, headers: ListTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListTeamsResponse> {
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
    let params = new $OpenApi.Params({
      action: "ListTeams",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/teams`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListTeamsResponse>(await this.execute(params, req, runtime), new ListTeamsResponse({}));
  }

  async listTeams(request: ListTeamsRequest): Promise<ListTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTeamsHeaders({ });
    return await this.listTeamsWithOptions(request, headers, runtime);
  }

  async listWorkspacesWithOptions(request: ListWorkspacesRequest, headers: ListWorkspacesHeaders, runtime: $Util.RuntimeOptions): Promise<ListWorkspacesResponse> {
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

    if (!Util.isUnset(request.orderBy)) {
      query["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.teamId)) {
      query["teamId"] = request.teamId;
    }

    if (!Util.isUnset(request.withPermissionRole)) {
      query["withPermissionRole"] = request.withPermissionRole;
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
      action: "ListWorkspaces",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/workspaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListWorkspacesResponse>(await this.execute(params, req, runtime), new ListWorkspacesResponse({}));
  }

  async listWorkspaces(request: ListWorkspacesRequest): Promise<ListWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListWorkspacesHeaders({ });
    return await this.listWorkspacesWithOptions(request, headers, runtime);
  }

  async setDefaultHandOverUserWithOptions(request: SetDefaultHandOverUserRequest, headers: SetDefaultHandOverUserHeaders, runtime: $Util.RuntimeOptions): Promise<SetDefaultHandOverUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.defaultHandoverUserId)) {
      body["defaultHandoverUserId"] = request.defaultHandoverUserId;
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
      action: "SetDefaultHandOverUser",
      version: "wiki_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/wiki/managementSettings/defaultHandOverUsers/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetDefaultHandOverUserResponse>(await this.execute(params, req, runtime), new SetDefaultHandOverUserResponse({}));
  }

  async setDefaultHandOverUser(request: SetDefaultHandOverUserRequest): Promise<SetDefaultHandOverUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetDefaultHandOverUserHeaders({ });
    return await this.setDefaultHandOverUserWithOptions(request, headers, runtime);
  }

}
