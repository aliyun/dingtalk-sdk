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

export class AttachmentsMapValue extends $tea.Model {
  uploadKey?: string;
  name?: string;
  mediaType?: string;
  static names(): { [key: string]: string } {
    return {
      uploadKey: 'uploadKey',
      name: 'name',
      mediaType: 'mediaType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uploadKey: 'string',
      name: 'string',
      mediaType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCommentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCommentRequest extends $tea.Model {
  commentContent?: string;
  commentType?: string;
  option?: AddCommentRequestOption;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      commentContent: 'commentContent',
      commentType: 'commentType',
      option: 'option',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commentContent: 'string',
      commentType: 'string',
      option: AddCommentRequestOption,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCommentResponseBody extends $tea.Model {
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

export class AddCommentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddCommentResponseBody;
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
      body: AddCommentResponseBody,
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  body: AddWorkspaceMembersResponseBody;
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRequest extends $tea.Model {
  requests?: BatchRequestRequests[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      requests: 'requests',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requests: { 'type': 'array', 'itemType': BatchRequestRequests },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchResponseBody extends $tea.Model {
  responses?: any[];
  static names(): { [key: string]: string } {
    return {
      responses: 'responses',
    };
  }

  static types(): { [key: string]: any } {
    return {
      responses: { 'type': 'array', 'itemType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchResponseBody;
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
      body: BatchResponseBody,
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
  statusCode: number;
  body: BatchGetWorkspaceDocsResponseBody;
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
  statusCode: number;
  body: BatchGetWorkspacesResponseBody;
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
      body: BatchGetWorkspacesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindCoolAppToSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindCoolAppToSheetRequest extends $tea.Model {
  coolAppCode?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindCoolAppToSheetResponseBody extends $tea.Model {
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

export class BindCoolAppToSheetResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BindCoolAppToSheetResponseBody;
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
      body: BindCoolAppToSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRequest extends $tea.Model {
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

export class ClearResponseBody extends $tea.Model {
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

export class ClearResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ClearResponseBody;
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
      body: ClearResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearDataRequest extends $tea.Model {
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

export class ClearDataResponseBody extends $tea.Model {
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

export class ClearDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ClearDataResponseBody;
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
      body: ClearDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConditionalFormattingRuleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConditionalFormattingRuleRequest extends $tea.Model {
  cellStyle?: CreateConditionalFormattingRuleRequestCellStyle;
  duplicateCondition?: CreateConditionalFormattingRuleRequestDuplicateCondition;
  ranges?: string[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      cellStyle: 'cellStyle',
      duplicateCondition: 'duplicateCondition',
      ranges: 'ranges',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cellStyle: CreateConditionalFormattingRuleRequestCellStyle,
      duplicateCondition: CreateConditionalFormattingRuleRequestDuplicateCondition,
      ranges: { 'type': 'array', 'itemType': 'string' },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConditionalFormattingRuleResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConditionalFormattingRuleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateConditionalFormattingRuleResponseBody;
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
      body: CreateConditionalFormattingRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperMetadataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperMetadataRequest extends $tea.Model {
  associatedColumn?: CreateDeveloperMetadataRequestAssociatedColumn;
  associatedRow?: CreateDeveloperMetadataRequestAssociatedRow;
  value?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      associatedColumn: 'associatedColumn',
      associatedRow: 'associatedRow',
      value: 'value',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      associatedColumn: CreateDeveloperMetadataRequestAssociatedColumn,
      associatedRow: CreateDeveloperMetadataRequestAssociatedRow,
      value: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperMetadataResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperMetadataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateDeveloperMetadataResponseBody;
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
      body: CreateDeveloperMetadataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRangeProtectionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRangeProtectionRequest extends $tea.Model {
  editableSetting?: CreateRangeProtectionRequestEditableSetting;
  otherUserPermission?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      editableSetting: 'editableSetting',
      otherUserPermission: 'otherUserPermission',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editableSetting: CreateRangeProtectionRequestEditableSetting,
      otherUserPermission: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRangeProtectionResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRangeProtectionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateRangeProtectionResponseBody;
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
      body: CreateRangeProtectionResponseBody,
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
  statusCode: number;
  body: CreateSheetResponseBody;
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
  statusCode: number;
  body: CreateWorkspaceResponseBody;
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
  statusCode: number;
  body: CreateWorkspaceDocResponseBody;
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
      body: CreateWorkspaceDocResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteColumnsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteColumnsRequest extends $tea.Model {
  column?: number;
  columnCount?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      column: 'column',
      columnCount: 'columnCount',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      column: 'number',
      columnCount: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteColumnsResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteColumnsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteColumnsResponseBody;
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
      body: DeleteColumnsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDropdownListsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDropdownListsRequest extends $tea.Model {
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

export class DeleteDropdownListsResponseBody extends $tea.Model {
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

export class DeleteDropdownListsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteDropdownListsResponseBody;
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
      body: DeleteDropdownListsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRangeProtectionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRangeProtectionRequest extends $tea.Model {
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

export class DeleteRangeProtectionResponseBody extends $tea.Model {
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

export class DeleteRangeProtectionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteRangeProtectionResponseBody;
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
      body: DeleteRangeProtectionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRowsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRowsRequest extends $tea.Model {
  row?: number;
  rowCount?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      row: 'row',
      rowCount: 'rowCount',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      row: 'number',
      rowCount: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRowsResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRowsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteRowsResponseBody;
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
      body: DeleteRowsResponseBody,
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

export class DeleteSheetResponseBody extends $tea.Model {
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

export class DeleteSheetResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteSheetResponseBody;
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
      body: DeleteSheetResponseBody,
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendParagraphHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendParagraphRequest extends $tea.Model {
  elementType?: string;
  properties?: { [key: string]: any };
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      elementType: 'elementType',
      properties: 'properties',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      elementType: 'string',
      properties: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendParagraphResponseBody extends $tea.Model {
  result?: DocAppendParagraphResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DocAppendParagraphResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendParagraphResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocAppendParagraphResponseBody;
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
      body: DocAppendParagraphResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendTextHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendTextRequest extends $tea.Model {
  text?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendTextResponseBody extends $tea.Model {
  result?: DocAppendTextResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DocAppendTextResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendTextResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocAppendTextResponseBody;
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
      body: DocAppendTextResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocBlocksQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocBlocksQueryRequest extends $tea.Model {
  blockType?: string;
  endIndex?: number;
  operatorId?: string;
  startIndex?: number;
  static names(): { [key: string]: string } {
    return {
      blockType: 'blockType',
      endIndex: 'endIndex',
      operatorId: 'operatorId',
      startIndex: 'startIndex',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blockType: 'string',
      endIndex: 'number',
      operatorId: 'string',
      startIndex: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocBlocksQueryResponseBody extends $tea.Model {
  result?: DocBlocksQueryResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DocBlocksQueryResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocBlocksQueryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocBlocksQueryResponseBody;
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
      body: DocBlocksQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocDeleteBlockHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocDeleteBlockRequest extends $tea.Model {
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

export class DocDeleteBlockResponseBody extends $tea.Model {
  result?: DocDeleteBlockResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DocDeleteBlockResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocDeleteBlockResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocDeleteBlockResponseBody;
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
      body: DocDeleteBlockResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocInsertBlocksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocInsertBlocksRequest extends $tea.Model {
  blockId?: string;
  element?: { [key: string]: any };
  index?: number;
  where?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      blockId: 'blockId',
      element: 'element',
      index: 'index',
      where: 'where',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blockId: 'string',
      element: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      index: 'number',
      where: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocInsertBlocksResponseBody extends $tea.Model {
  result?: DocInsertBlocksResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DocInsertBlocksResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocInsertBlocksResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocInsertBlocksResponseBody;
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
      body: DocInsertBlocksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocUpdateContentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocUpdateContentRequest extends $tea.Model {
  content?: string;
  dataType?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      dataType: 'dataType',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      dataType: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocUpdateContentResponseBody extends $tea.Model {
  result?: DocUpdateContentResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DocUpdateContentResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocUpdateContentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DocUpdateContentResponseBody;
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
      body: DocUpdateContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsRequest extends $tea.Model {
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

export class GetAllSheetsResponseBody extends $tea.Model {
  value?: GetAllSheetsResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': GetAllSheetsResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAllSheetsResponseBody;
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
      body: GetAllSheetsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeveloperMetadataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeveloperMetadataRequest extends $tea.Model {
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

export class GetDeveloperMetadataResponseBody extends $tea.Model {
  associatedColumn?: GetDeveloperMetadataResponseBodyAssociatedColumn;
  associatedRow?: GetDeveloperMetadataResponseBodyAssociatedRow;
  value?: any;
  static names(): { [key: string]: string } {
    return {
      associatedColumn: 'associatedColumn',
      associatedRow: 'associatedRow',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      associatedColumn: GetDeveloperMetadataResponseBodyAssociatedColumn,
      associatedRow: GetDeveloperMetadataResponseBodyAssociatedRow,
      value: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeveloperMetadataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDeveloperMetadataResponseBody;
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
      body: GetDeveloperMetadataResponseBody,
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
  select?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      select: 'select',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      select: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRangeResponseBody extends $tea.Model {
  backgroundColors?: GetRangeResponseBodyBackgroundColors[][];
  displayValues?: string[][];
  fontSizes?: number[][];
  fontWeights?: string[][];
  formulas?: string[][];
  horizontalAlignments?: string[][];
  values?: any[][];
  verticalAlignments?: string[][];
  static names(): { [key: string]: string } {
    return {
      backgroundColors: 'backgroundColors',
      displayValues: 'displayValues',
      fontSizes: 'fontSizes',
      fontWeights: 'fontWeights',
      formulas: 'formulas',
      horizontalAlignments: 'horizontalAlignments',
      values: 'values',
      verticalAlignments: 'verticalAlignments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundColors: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': GetRangeResponseBodyBackgroundColors } },
      displayValues: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      fontSizes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'number' } },
      fontWeights: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      formulas: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      horizontalAlignments: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'any' } },
      verticalAlignments: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRangeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetRangeResponseBody;
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
  statusCode: number;
  body: GetRecentEditDocsResponseBody;
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
  statusCode: number;
  body: GetRecentOpenDocsResponseBody;
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
  statusCode: number;
  body: GetRelatedWorkspacesResponseBody;
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
  id?: string;
  lastNonEmptyColumn?: number;
  lastNonEmptyRow?: number;
  name?: string;
  rowCount?: number;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      columnCount: 'columnCount',
      id: 'id',
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
      id: 'string',
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
  statusCode: number;
  body: GetSheetResponseBody;
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
  statusCode: number;
  body: GetTemplateByIdResponseBody;
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
  isDeleted?: boolean;
  owner?: string;
  rootDentryUuid?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      isDeleted: 'isDeleted',
      owner: 'owner',
      rootDentryUuid: 'rootDentryUuid',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isDeleted: 'boolean',
      owner: 'string',
      rootDentryUuid: 'string',
      url: 'string',
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
  statusCode: number;
  body: GetWorkspaceNodeResponseBody;
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
      body: GetWorkspaceNodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDocumentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDocumentRequest extends $tea.Model {
  attachmentsMap?: { [key: string]: AttachmentsMapValue };
  importType?: number;
  linksKey?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      attachmentsMap: 'attachmentsMap',
      importType: 'importType',
      linksKey: 'linksKey',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachmentsMap: { 'type': 'map', 'keyType': 'string', 'valueType': AttachmentsMapValue },
      importType: 'number',
      linksKey: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitDocumentResponseBody extends $tea.Model {
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

export class InitDocumentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InitDocumentResponseBody;
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
      body: InitDocumentResponseBody,
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertColumnsBeforeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertColumnsBeforeRequest extends $tea.Model {
  column?: number;
  columnCount?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      column: 'column',
      columnCount: 'columnCount',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      column: 'number',
      columnCount: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertColumnsBeforeResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertColumnsBeforeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InsertColumnsBeforeResponseBody;
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
      body: InsertColumnsBeforeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertDropdownListsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertDropdownListsRequest extends $tea.Model {
  options?: InsertDropdownListsRequestOptions[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      options: 'options',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      options: { 'type': 'array', 'itemType': InsertDropdownListsRequestOptions },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertDropdownListsResponseBody extends $tea.Model {
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

export class InsertDropdownListsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InsertDropdownListsResponseBody;
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
      body: InsertDropdownListsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRowsBeforeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRowsBeforeRequest extends $tea.Model {
  row?: number;
  rowCount?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      row: 'row',
      rowCount: 'rowCount',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      row: 'number',
      rowCount: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRowsBeforeResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRowsBeforeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InsertRowsBeforeResponseBody;
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
      body: InsertRowsBeforeResponseBody,
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
  statusCode: number;
  body: ListTemplateResponseBody;
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
      body: ListTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MergeRangeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MergeRangeRequest extends $tea.Model {
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

export class MergeRangeResponseBody extends $tea.Model {
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

export class MergeRangeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: MergeRangeResponseBody;
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
      body: MergeRangeResponseBody,
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
  statusCode: number;
  body: RangeFindNextResponseBody;
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
  statusCode: number;
  body: SearchWorkspaceDocsResponseBody;
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
      body: SearchWorkspaceDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnWidthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnWidthRequest extends $tea.Model {
  column?: number;
  width?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      column: 'column',
      width: 'width',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      column: 'number',
      width: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnWidthResponseBody extends $tea.Model {
  sheetId?: string;
  sheetName?: string;
  static names(): { [key: string]: string } {
    return {
      sheetId: 'sheetId',
      sheetName: 'sheetName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sheetId: 'string',
      sheetName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnWidthResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetColumnWidthResponseBody;
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
      body: SetColumnWidthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnsVisibilityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnsVisibilityRequest extends $tea.Model {
  column?: number;
  columnCount?: number;
  visibility?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      column: 'column',
      columnCount: 'columnCount',
      visibility: 'visibility',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      column: 'number',
      columnCount: 'number',
      visibility: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnsVisibilityResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetColumnsVisibilityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetColumnsVisibilityResponseBody;
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
      body: SetColumnsVisibilityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowHeightHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowHeightRequest extends $tea.Model {
  height?: number;
  row?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      row: 'row',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      row: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowHeightResponseBody extends $tea.Model {
  sheetId?: string;
  sheetName?: string;
  static names(): { [key: string]: string } {
    return {
      sheetId: 'sheetId',
      sheetName: 'sheetName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sheetId: 'string',
      sheetName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowHeightResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetRowHeightResponseBody;
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
      body: SetRowHeightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowsVisibilityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowsVisibilityRequest extends $tea.Model {
  row?: number;
  rowCount?: number;
  visibility?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      row: 'row',
      rowCount: 'rowCount',
      visibility: 'visibility',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      row: 'number',
      rowCount: 'number',
      visibility: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowsVisibilityResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRowsVisibilityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetRowsVisibilityResponseBody;
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
      body: SetRowsVisibilityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetAutofitRowsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetAutofitRowsRequest extends $tea.Model {
  fontWidth?: number;
  row?: number;
  rowCount?: number;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      fontWidth: 'fontWidth',
      row: 'row',
      rowCount: 'rowCount',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fontWidth: 'number',
      row: 'number',
      rowCount: 'number',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetAutofitRowsResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetAutofitRowsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SheetAutofitRowsResponseBody;
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
      body: SheetAutofitRowsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetFindAllHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetFindAllRequest extends $tea.Model {
  findOptions?: SheetFindAllRequestFindOptions;
  text?: string;
  operatorId?: string;
  select?: string;
  static names(): { [key: string]: string } {
    return {
      findOptions: 'findOptions',
      text: 'text',
      operatorId: 'operatorId',
      select: 'select',
    };
  }

  static types(): { [key: string]: any } {
    return {
      findOptions: SheetFindAllRequestFindOptions,
      text: 'string',
      operatorId: 'string',
      select: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetFindAllResponseBody extends $tea.Model {
  value?: SheetFindAllResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': SheetFindAllResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetFindAllResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SheetFindAllResponseBody;
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
      body: SheetFindAllResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindCoolAppToSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindCoolAppToSheetRequest extends $tea.Model {
  coolAppCode?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindCoolAppToSheetResponseBody extends $tea.Model {
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

export class UnbindCoolAppToSheetResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnbindCoolAppToSheetResponseBody;
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
      body: UnbindCoolAppToSheetResponseBody,
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
  fontSizes?: number[][];
  fontWeights?: string[][];
  horizontalAlignments?: string[][];
  hyperlinks?: UpdateRangeRequestHyperlinks[][];
  numberFormat?: string;
  values?: string[][];
  verticalAlignments?: string[][];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      backgroundColors: 'backgroundColors',
      fontSizes: 'fontSizes',
      fontWeights: 'fontWeights',
      horizontalAlignments: 'horizontalAlignments',
      hyperlinks: 'hyperlinks',
      numberFormat: 'numberFormat',
      values: 'values',
      verticalAlignments: 'verticalAlignments',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundColors: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      fontSizes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'number' } },
      fontWeights: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      horizontalAlignments: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      hyperlinks: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': UpdateRangeRequestHyperlinks } },
      numberFormat: 'string',
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      verticalAlignments: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRangeResponseBody extends $tea.Model {
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

export class UpdateRangeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateRangeResponseBody;
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
      body: UpdateRangeResponseBody,
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCommentRequestOption extends $tea.Model {
  createTime?: string;
  extra?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      extra: 'extra',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class BatchRequestRequests extends $tea.Model {
  body?: any;
  method?: string;
  path?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      method: 'method',
      path: 'path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: 'any',
      method: 'string',
      path: 'string',
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

export class CreateConditionalFormattingRuleRequestCellStyle extends $tea.Model {
  backgroundColor?: string;
  static names(): { [key: string]: string } {
    return {
      backgroundColor: 'backgroundColor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundColor: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConditionalFormattingRuleRequestDuplicateCondition extends $tea.Model {
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperMetadataRequestAssociatedColumn extends $tea.Model {
  column?: number;
  sheet?: string;
  static names(): { [key: string]: string } {
    return {
      column: 'column',
      sheet: 'sheet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      column: 'number',
      sheet: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperMetadataRequestAssociatedRow extends $tea.Model {
  row?: number;
  sheet?: string;
  static names(): { [key: string]: string } {
    return {
      row: 'row',
      sheet: 'sheet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      row: 'number',
      sheet: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRangeProtectionRequestEditableSetting extends $tea.Model {
  deleteColumns?: boolean;
  deleteRows?: boolean;
  editCells?: boolean;
  formatCells?: boolean;
  insertColumns?: boolean;
  insertRows?: boolean;
  toggleColumnsVisibility?: boolean;
  toggleRowsVisibility?: boolean;
  static names(): { [key: string]: string } {
    return {
      deleteColumns: 'deleteColumns',
      deleteRows: 'deleteRows',
      editCells: 'editCells',
      formatCells: 'formatCells',
      insertColumns: 'insertColumns',
      insertRows: 'insertRows',
      toggleColumnsVisibility: 'toggleColumnsVisibility',
      toggleRowsVisibility: 'toggleRowsVisibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleteColumns: 'boolean',
      deleteRows: 'boolean',
      editCells: 'boolean',
      formatCells: 'boolean',
      insertColumns: 'boolean',
      insertRows: 'boolean',
      toggleColumnsVisibility: 'boolean',
      toggleRowsVisibility: 'boolean',
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

export class DocAppendParagraphResponseBodyResult extends $tea.Model {
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocAppendTextResponseBodyResult extends $tea.Model {
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocBlocksQueryResponseBodyResult extends $tea.Model {
  data?: any[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocDeleteBlockResponseBodyResult extends $tea.Model {
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocInsertBlocksResponseBodyResult extends $tea.Model {
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DocUpdateContentResponseBodyResult extends $tea.Model {
  data?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsResponseBodyValue extends $tea.Model {
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

export class GetDeveloperMetadataResponseBodyAssociatedColumn extends $tea.Model {
  column?: number;
  sheetId?: string;
  static names(): { [key: string]: string } {
    return {
      column: 'column',
      sheetId: 'sheetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      column: 'number',
      sheetId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeveloperMetadataResponseBodyAssociatedRow extends $tea.Model {
  row?: number;
  sheetId?: string;
  static names(): { [key: string]: string } {
    return {
      row: 'row',
      sheetId: 'sheetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      row: 'number',
      sheetId: 'string',
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

export class InsertDropdownListsRequestOptions extends $tea.Model {
  color?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      color: 'color',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      color: 'string',
      value: 'string',
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
  includeHidden?: boolean;
  matchCase?: boolean;
  matchEntireCell?: boolean;
  matchFormulaText?: boolean;
  scope?: string;
  useRegExp?: boolean;
  static names(): { [key: string]: string } {
    return {
      includeHidden: 'includeHidden',
      matchCase: 'matchCase',
      matchEntireCell: 'matchEntireCell',
      matchFormulaText: 'matchFormulaText',
      scope: 'scope',
      useRegExp: 'useRegExp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeHidden: 'boolean',
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

export class SheetFindAllRequestFindOptions extends $tea.Model {
  includeHidden?: boolean;
  matchCase?: boolean;
  matchEntireCell?: boolean;
  matchFormulaText?: boolean;
  scope?: string;
  unionCells?: boolean;
  useRegExp?: boolean;
  static names(): { [key: string]: string } {
    return {
      includeHidden: 'includeHidden',
      matchCase: 'matchCase',
      matchEntireCell: 'matchEntireCell',
      matchFormulaText: 'matchFormulaText',
      scope: 'scope',
      unionCells: 'unionCells',
      useRegExp: 'useRegExp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      includeHidden: 'boolean',
      matchCase: 'boolean',
      matchEntireCell: 'boolean',
      matchFormulaText: 'boolean',
      scope: 'string',
      unionCells: 'boolean',
      useRegExp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SheetFindAllResponseBodyValue extends $tea.Model {
  a1Notation?: string;
  values?: any[][];
  static names(): { [key: string]: string } {
    return {
      a1Notation: 'a1Notation',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      a1Notation: 'string',
      values: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'any' } },
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


  async addCommentWithOptions(docId: string, request: AddCommentRequest, headers: AddCommentHeaders, runtime: $Util.RuntimeOptions): Promise<AddCommentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.commentContent)) {
      body["commentContent"] = request.commentContent;
    }

    if (!Util.isUnset(request.commentType)) {
      body["commentType"] = request.commentType;
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
      action: "AddComment",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/docs/${docId}/comments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddCommentResponse>(await this.execute(params, req, runtime), new AddCommentResponse({}));
  }

  async addComment(docId: string, request: AddCommentRequest): Promise<AddCommentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCommentHeaders({ });
    return await this.addCommentWithOptions(docId, request, headers, runtime);
  }

  async addWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest, headers: AddWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceDocMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "AddWorkspaceDocMembers",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<AddWorkspaceDocMembersResponse>(await this.execute(params, req, runtime), new AddWorkspaceDocMembersResponse({}));
  }

  async addWorkspaceDocMembers(workspaceId: string, nodeId: string, request: AddWorkspaceDocMembersRequest): Promise<AddWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceDocMembersHeaders({ });
    return await this.addWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async addWorkspaceMembersWithOptions(workspaceId: string, request: AddWorkspaceMembersRequest, headers: AddWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddWorkspaceMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "AddWorkspaceMembers",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddWorkspaceMembersResponse>(await this.execute(params, req, runtime), new AddWorkspaceMembersResponse({}));
  }

  async addWorkspaceMembers(workspaceId: string, request: AddWorkspaceMembersRequest): Promise<AddWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddWorkspaceMembersHeaders({ });
    return await this.addWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AppendRows",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/appendRows`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<AppendRowsResponse>(await this.execute(params, req, runtime), new AppendRowsResponse({}));
  }

  async appendRows(workbookId: string, sheetId: string, request: AppendRowsRequest): Promise<AppendRowsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendRowsHeaders({ });
    return await this.appendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async batchWithOptions(workbookId: string, request: BatchRequest, headers: BatchHeaders, runtime: $Util.RuntimeOptions): Promise<BatchResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.requests)) {
      body["requests"] = request.requests;
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
      action: "Batch",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchResponse>(await this.execute(params, req, runtime), new BatchResponse({}));
  }

  async batch(workbookId: string, request: BatchRequest): Promise<BatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchHeaders({ });
    return await this.batchWithOptions(workbookId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "BatchGetWorkspaceDocs",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/docs/infos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchGetWorkspaceDocsResponse>(await this.execute(params, req, runtime), new BatchGetWorkspaceDocsResponse({}));
  }

  async batchGetWorkspaceDocs(request: BatchGetWorkspaceDocsRequest): Promise<BatchGetWorkspaceDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetWorkspaceDocsHeaders({ });
    return await this.batchGetWorkspaceDocsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "BatchGetWorkspaces",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/infos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchGetWorkspacesResponse>(await this.execute(params, req, runtime), new BatchGetWorkspacesResponse({}));
  }

  async batchGetWorkspaces(request: BatchGetWorkspacesRequest): Promise<BatchGetWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetWorkspacesHeaders({ });
    return await this.batchGetWorkspacesWithOptions(request, headers, runtime);
  }

  async bindCoolAppToSheetWithOptions(workbookId: string, request: BindCoolAppToSheetRequest, headers: BindCoolAppToSheetHeaders, runtime: $Util.RuntimeOptions): Promise<BindCoolAppToSheetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
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
      action: "BindCoolAppToSheet",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/coolApps`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BindCoolAppToSheetResponse>(await this.execute(params, req, runtime), new BindCoolAppToSheetResponse({}));
  }

  async bindCoolAppToSheet(workbookId: string, request: BindCoolAppToSheetRequest): Promise<BindCoolAppToSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BindCoolAppToSheetHeaders({ });
    return await this.bindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
  }

  async clearWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: ClearRequest, headers: ClearHeaders, runtime: $Util.RuntimeOptions): Promise<ClearResponse> {
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
      action: "Clear",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/clear`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ClearResponse>(await this.execute(params, req, runtime), new ClearResponse({}));
  }

  async clear(workbookId: string, sheetId: string, rangeAddress: string, request: ClearRequest): Promise<ClearResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearHeaders({ });
    return await this.clearWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async clearDataWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: ClearDataRequest, headers: ClearDataHeaders, runtime: $Util.RuntimeOptions): Promise<ClearDataResponse> {
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
      action: "ClearData",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/clearData`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ClearDataResponse>(await this.execute(params, req, runtime), new ClearDataResponse({}));
  }

  async clearData(workbookId: string, sheetId: string, rangeAddress: string, request: ClearDataRequest): Promise<ClearDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearDataHeaders({ });
    return await this.clearDataWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async createConditionalFormattingRuleWithOptions(workbookId: string, sheetId: string, request: CreateConditionalFormattingRuleRequest, headers: CreateConditionalFormattingRuleHeaders, runtime: $Util.RuntimeOptions): Promise<CreateConditionalFormattingRuleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cellStyle)) {
      body["cellStyle"] = request.cellStyle;
    }

    if (!Util.isUnset(request.duplicateCondition)) {
      body["duplicateCondition"] = request.duplicateCondition;
    }

    if (!Util.isUnset(request.ranges)) {
      body["ranges"] = request.ranges;
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
      action: "CreateConditionalFormattingRule",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/conditionalFormattingRules`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateConditionalFormattingRuleResponse>(await this.execute(params, req, runtime), new CreateConditionalFormattingRuleResponse({}));
  }

  async createConditionalFormattingRule(workbookId: string, sheetId: string, request: CreateConditionalFormattingRuleRequest): Promise<CreateConditionalFormattingRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateConditionalFormattingRuleHeaders({ });
    return await this.createConditionalFormattingRuleWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async createDeveloperMetadataWithOptions(workbookId: string, request: CreateDeveloperMetadataRequest, headers: CreateDeveloperMetadataHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeveloperMetadataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.associatedColumn)) {
      body["associatedColumn"] = request.associatedColumn;
    }

    if (!Util.isUnset(request.associatedRow)) {
      body["associatedRow"] = request.associatedRow;
    }

    if (!Util.isUnset(request.value)) {
      body["value"] = request.value;
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
      action: "CreateDeveloperMetadata",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/developerMetadatas`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDeveloperMetadataResponse>(await this.execute(params, req, runtime), new CreateDeveloperMetadataResponse({}));
  }

  async createDeveloperMetadata(workbookId: string, request: CreateDeveloperMetadataRequest): Promise<CreateDeveloperMetadataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeveloperMetadataHeaders({ });
    return await this.createDeveloperMetadataWithOptions(workbookId, request, headers, runtime);
  }

  async createRangeProtectionWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: CreateRangeProtectionRequest, headers: CreateRangeProtectionHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRangeProtectionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.editableSetting)) {
      body["editableSetting"] = request.editableSetting;
    }

    if (!Util.isUnset(request.otherUserPermission)) {
      body["otherUserPermission"] = request.otherUserPermission;
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
      action: "CreateRangeProtection",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/protections`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateRangeProtectionResponse>(await this.execute(params, req, runtime), new CreateRangeProtectionResponse({}));
  }

  async createRangeProtection(workbookId: string, sheetId: string, rangeAddress: string, request: CreateRangeProtectionRequest): Promise<CreateRangeProtectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRangeProtectionHeaders({ });
    return await this.createRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateSheet",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSheetResponse>(await this.execute(params, req, runtime), new CreateSheetResponse({}));
  }

  async createSheet(workbookId: string, request: CreateSheetRequest): Promise<CreateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSheetHeaders({ });
    return await this.createSheetWithOptions(workbookId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CreateWorkspace",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateWorkspaceResponse>(await this.execute(params, req, runtime), new CreateWorkspaceResponse({}));
  }

  async createWorkspace(request: CreateWorkspaceRequest): Promise<CreateWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceHeaders({ });
    return await this.createWorkspaceWithOptions(request, headers, runtime);
  }

  async createWorkspaceDocWithOptions(workspaceId: string, request: CreateWorkspaceDocRequest, headers: CreateWorkspaceDocHeaders, runtime: $Util.RuntimeOptions): Promise<CreateWorkspaceDocResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "CreateWorkspaceDoc",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/docs`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateWorkspaceDocResponse>(await this.execute(params, req, runtime), new CreateWorkspaceDocResponse({}));
  }

  async createWorkspaceDoc(workspaceId: string, request: CreateWorkspaceDocRequest): Promise<CreateWorkspaceDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateWorkspaceDocHeaders({ });
    return await this.createWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
  }

  async deleteColumnsWithOptions(workbookId: string, sheetId: string, request: DeleteColumnsRequest, headers: DeleteColumnsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteColumnsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.column)) {
      body["column"] = request.column;
    }

    if (!Util.isUnset(request.columnCount)) {
      body["columnCount"] = request.columnCount;
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
      action: "DeleteColumns",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/deleteColumns`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteColumnsResponse>(await this.execute(params, req, runtime), new DeleteColumnsResponse({}));
  }

  async deleteColumns(workbookId: string, sheetId: string, request: DeleteColumnsRequest): Promise<DeleteColumnsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteColumnsHeaders({ });
    return await this.deleteColumnsWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async deleteDropdownListsWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: DeleteDropdownListsRequest, headers: DeleteDropdownListsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDropdownListsResponse> {
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
      action: "DeleteDropdownLists",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/deleteDropdownLists`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDropdownListsResponse>(await this.execute(params, req, runtime), new DeleteDropdownListsResponse({}));
  }

  async deleteDropdownLists(workbookId: string, sheetId: string, rangeAddress: string, request: DeleteDropdownListsRequest): Promise<DeleteDropdownListsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDropdownListsHeaders({ });
    return await this.deleteDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async deleteRangeProtectionWithOptions(workbookId: string, sheetId: string, rangeAddress: string, protectionId: string, request: DeleteRangeProtectionRequest, headers: DeleteRangeProtectionHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRangeProtectionResponse> {
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
      action: "DeleteRangeProtection",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/protections/${protectionId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteRangeProtectionResponse>(await this.execute(params, req, runtime), new DeleteRangeProtectionResponse({}));
  }

  async deleteRangeProtection(workbookId: string, sheetId: string, rangeAddress: string, protectionId: string, request: DeleteRangeProtectionRequest): Promise<DeleteRangeProtectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRangeProtectionHeaders({ });
    return await this.deleteRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
  }

  async deleteRowsWithOptions(workbookId: string, sheetId: string, request: DeleteRowsRequest, headers: DeleteRowsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRowsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.row)) {
      body["row"] = request.row;
    }

    if (!Util.isUnset(request.rowCount)) {
      body["rowCount"] = request.rowCount;
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
      action: "DeleteRows",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/deleteRows`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteRowsResponse>(await this.execute(params, req, runtime), new DeleteRowsResponse({}));
  }

  async deleteRows(workbookId: string, sheetId: string, request: DeleteRowsRequest): Promise<DeleteRowsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRowsHeaders({ });
    return await this.deleteRowsWithOptions(workbookId, sheetId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteSheet",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteSheetResponse>(await this.execute(params, req, runtime), new DeleteSheetResponse({}));
  }

  async deleteSheet(workbookId: string, sheetId: string, request: DeleteSheetRequest): Promise<DeleteSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSheetHeaders({ });
    return await this.deleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async deleteWorkspaceDocWithOptions(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocRequest, headers: DeleteWorkspaceDocHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceDocResponse> {
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
      action: "DeleteWorkspaceDoc",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteWorkspaceDocResponse>(await this.execute(params, req, runtime), new DeleteWorkspaceDocResponse({}));
  }

  async deleteWorkspaceDoc(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocRequest): Promise<DeleteWorkspaceDocResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceDocHeaders({ });
    return await this.deleteWorkspaceDocWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async deleteWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest, headers: DeleteWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceDocMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "DeleteWorkspaceDocMembers",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteWorkspaceDocMembersResponse>(await this.execute(params, req, runtime), new DeleteWorkspaceDocMembersResponse({}));
  }

  async deleteWorkspaceDocMembers(workspaceId: string, nodeId: string, request: DeleteWorkspaceDocMembersRequest): Promise<DeleteWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceDocMembersHeaders({ });
    return await this.deleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async deleteWorkspaceMembersWithOptions(workspaceId: string, request: DeleteWorkspaceMembersRequest, headers: DeleteWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWorkspaceMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "DeleteWorkspaceMembers",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/members/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteWorkspaceMembersResponse>(await this.execute(params, req, runtime), new DeleteWorkspaceMembersResponse({}));
  }

  async deleteWorkspaceMembers(workspaceId: string, request: DeleteWorkspaceMembersRequest): Promise<DeleteWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWorkspaceMembersHeaders({ });
    return await this.deleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

  async docAppendParagraphWithOptions(docKey: string, blockId: string, request: DocAppendParagraphRequest, headers: DocAppendParagraphHeaders, runtime: $Util.RuntimeOptions): Promise<DocAppendParagraphResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.elementType)) {
      body["elementType"] = request.elementType;
    }

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
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
      action: "DocAppendParagraph",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/suites/documents/${docKey}/blocks/${blockId}/paragraph/appendElement`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocAppendParagraphResponse>(await this.execute(params, req, runtime), new DocAppendParagraphResponse({}));
  }

  async docAppendParagraph(docKey: string, blockId: string, request: DocAppendParagraphRequest): Promise<DocAppendParagraphResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocAppendParagraphHeaders({ });
    return await this.docAppendParagraphWithOptions(docKey, blockId, request, headers, runtime);
  }

  async docAppendTextWithOptions(docKey: string, blockId: string, request: DocAppendTextRequest, headers: DocAppendTextHeaders, runtime: $Util.RuntimeOptions): Promise<DocAppendTextResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "DocAppendText",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/suites/documents/${docKey}/blocks/${blockId}/paragraph/appendText`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocAppendTextResponse>(await this.execute(params, req, runtime), new DocAppendTextResponse({}));
  }

  async docAppendText(docKey: string, blockId: string, request: DocAppendTextRequest): Promise<DocAppendTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocAppendTextHeaders({ });
    return await this.docAppendTextWithOptions(docKey, blockId, request, headers, runtime);
  }

  async docBlocksQueryWithOptions(docKey: string, request: DocBlocksQueryRequest, headers: DocBlocksQueryHeaders, runtime: $Util.RuntimeOptions): Promise<DocBlocksQueryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blockType)) {
      query["blockType"] = request.blockType;
    }

    if (!Util.isUnset(request.endIndex)) {
      query["endIndex"] = request.endIndex;
    }

    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.startIndex)) {
      query["startIndex"] = request.startIndex;
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
      action: "DocBlocksQuery",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/suites/documents/${docKey}/blocks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocBlocksQueryResponse>(await this.execute(params, req, runtime), new DocBlocksQueryResponse({}));
  }

  async docBlocksQuery(docKey: string, request: DocBlocksQueryRequest): Promise<DocBlocksQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocBlocksQueryHeaders({ });
    return await this.docBlocksQueryWithOptions(docKey, request, headers, runtime);
  }

  async docDeleteBlockWithOptions(docKey: string, blockId: string, request: DocDeleteBlockRequest, headers: DocDeleteBlockHeaders, runtime: $Util.RuntimeOptions): Promise<DocDeleteBlockResponse> {
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
      action: "DocDeleteBlock",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/suites/documents/${docKey}/blocks/${blockId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocDeleteBlockResponse>(await this.execute(params, req, runtime), new DocDeleteBlockResponse({}));
  }

  async docDeleteBlock(docKey: string, blockId: string, request: DocDeleteBlockRequest): Promise<DocDeleteBlockResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocDeleteBlockHeaders({ });
    return await this.docDeleteBlockWithOptions(docKey, blockId, request, headers, runtime);
  }

  async docInsertBlocksWithOptions(docKey: string, request: DocInsertBlocksRequest, headers: DocInsertBlocksHeaders, runtime: $Util.RuntimeOptions): Promise<DocInsertBlocksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blockId)) {
      body["blockId"] = request.blockId;
    }

    if (!Util.isUnset(request.element)) {
      body["element"] = request.element;
    }

    if (!Util.isUnset(request.index)) {
      body["index"] = request.index;
    }

    if (!Util.isUnset(request.where)) {
      body["where"] = request.where;
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
      action: "DocInsertBlocks",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/suites/documents/${docKey}/blocks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocInsertBlocksResponse>(await this.execute(params, req, runtime), new DocInsertBlocksResponse({}));
  }

  async docInsertBlocks(docKey: string, request: DocInsertBlocksRequest): Promise<DocInsertBlocksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocInsertBlocksHeaders({ });
    return await this.docInsertBlocksWithOptions(docKey, request, headers, runtime);
  }

  async docUpdateContentWithOptions(docKey: string, request: DocUpdateContentRequest, headers: DocUpdateContentHeaders, runtime: $Util.RuntimeOptions): Promise<DocUpdateContentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.dataType)) {
      body["dataType"] = request.dataType;
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
      action: "DocUpdateContent",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/suites/documents/${docKey}/overwriteContent`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DocUpdateContentResponse>(await this.execute(params, req, runtime), new DocUpdateContentResponse({}));
  }

  async docUpdateContent(docKey: string, request: DocUpdateContentRequest): Promise<DocUpdateContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DocUpdateContentHeaders({ });
    return await this.docUpdateContentWithOptions(docKey, request, headers, runtime);
  }

  async getAllSheetsWithOptions(workbookId: string, request: GetAllSheetsRequest, headers: GetAllSheetsHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllSheetsResponse> {
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
      action: "GetAllSheets",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllSheetsResponse>(await this.execute(params, req, runtime), new GetAllSheetsResponse({}));
  }

  async getAllSheets(workbookId: string, request: GetAllSheetsRequest): Promise<GetAllSheetsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllSheetsHeaders({ });
    return await this.getAllSheetsWithOptions(workbookId, request, headers, runtime);
  }

  async getDeveloperMetadataWithOptions(workbookId: string, developerMetadataId: string, request: GetDeveloperMetadataRequest, headers: GetDeveloperMetadataHeaders, runtime: $Util.RuntimeOptions): Promise<GetDeveloperMetadataResponse> {
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
      action: "GetDeveloperMetadata",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/developerMetadatas/${developerMetadataId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDeveloperMetadataResponse>(await this.execute(params, req, runtime), new GetDeveloperMetadataResponse({}));
  }

  async getDeveloperMetadata(workbookId: string, developerMetadataId: string, request: GetDeveloperMetadataRequest): Promise<GetDeveloperMetadataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeveloperMetadataHeaders({ });
    return await this.getDeveloperMetadataWithOptions(workbookId, developerMetadataId, request, headers, runtime);
  }

  async getRangeWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: GetRangeRequest, headers: GetRangeHeaders, runtime: $Util.RuntimeOptions): Promise<GetRangeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.select)) {
      query["select"] = request.select;
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
      action: "GetRange",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRangeResponse>(await this.execute(params, req, runtime), new GetRangeResponse({}));
  }

  async getRange(workbookId: string, sheetId: string, rangeAddress: string, request: GetRangeRequest): Promise<GetRangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRangeHeaders({ });
    return await this.getRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetRecentEditDocs",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/docs/recentEditDocs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecentEditDocsResponse>(await this.execute(params, req, runtime), new GetRecentEditDocsResponse({}));
  }

  async getRecentEditDocs(request: GetRecentEditDocsRequest): Promise<GetRecentEditDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecentEditDocsHeaders({ });
    return await this.getRecentEditDocsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetRecentOpenDocs",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/docs/recentOpenDocs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecentOpenDocsResponse>(await this.execute(params, req, runtime), new GetRecentOpenDocsResponse({}));
  }

  async getRecentOpenDocs(request: GetRecentOpenDocsRequest): Promise<GetRecentOpenDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecentOpenDocsHeaders({ });
    return await this.getRecentOpenDocsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetRelatedWorkspaces",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRelatedWorkspacesResponse>(await this.execute(params, req, runtime), new GetRelatedWorkspacesResponse({}));
  }

  async getRelatedWorkspaces(request: GetRelatedWorkspacesRequest): Promise<GetRelatedWorkspacesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRelatedWorkspacesHeaders({ });
    return await this.getRelatedWorkspacesWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetSheet",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSheetResponse>(await this.execute(params, req, runtime), new GetSheetResponse({}));
  }

  async getSheet(workbookId: string, sheetId: string, request: GetSheetRequest): Promise<GetSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSheetHeaders({ });
    return await this.getSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async getTemplateByIdWithOptions(templateId: string, request: GetTemplateByIdRequest, headers: GetTemplateByIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetTemplateByIdResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetTemplateById",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/templates/${templateId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTemplateByIdResponse>(await this.execute(params, req, runtime), new GetTemplateByIdResponse({}));
  }

  async getTemplateById(templateId: string, request: GetTemplateByIdRequest): Promise<GetTemplateByIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTemplateByIdHeaders({ });
    return await this.getTemplateByIdWithOptions(templateId, request, headers, runtime);
  }

  async getWorkspaceWithOptions(workspaceId: string, headers: GetWorkspaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkspaceResponse> {
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
      action: "GetWorkspace",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWorkspaceResponse>(await this.execute(params, req, runtime), new GetWorkspaceResponse({}));
  }

  async getWorkspace(workspaceId: string): Promise<GetWorkspaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceHeaders({ });
    return await this.getWorkspaceWithOptions(workspaceId, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetWorkspaceNode",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWorkspaceNodeResponse>(await this.execute(params, req, runtime), new GetWorkspaceNodeResponse({}));
  }

  async getWorkspaceNode(workspaceId: string, nodeId: string, request: GetWorkspaceNodeRequest): Promise<GetWorkspaceNodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkspaceNodeHeaders({ });
    return await this.getWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async initDocumentWithOptions(docId: string, request: InitDocumentRequest, headers: InitDocumentHeaders, runtime: $Util.RuntimeOptions): Promise<InitDocumentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachmentsMap)) {
      body["attachmentsMap"] = request.attachmentsMap;
    }

    if (!Util.isUnset(request.importType)) {
      body["importType"] = request.importType;
    }

    if (!Util.isUnset(request.linksKey)) {
      body["linksKey"] = request.linksKey;
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
      action: "InitDocument",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/docs/${docId}/init`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InitDocumentResponse>(await this.execute(params, req, runtime), new InitDocumentResponse({}));
  }

  async initDocument(docId: string, request: InitDocumentRequest): Promise<InitDocumentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitDocumentHeaders({ });
    return await this.initDocumentWithOptions(docId, request, headers, runtime);
  }

  async insertBlocksWithOptions(documentId: string, request: InsertBlocksRequest, headers: InsertBlocksHeaders, runtime: $Util.RuntimeOptions): Promise<InsertBlocksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blocks)) {
      body["blocks"] = request.blocks;
    }

    if (!Util.isUnset(request.location)) {
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
    let params = new $OpenApi.Params({
      action: "InsertBlocks",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/documents/${documentId}/blocks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<InsertBlocksResponse>(await this.execute(params, req, runtime), new InsertBlocksResponse({}));
  }

  async insertBlocks(documentId: string, request: InsertBlocksRequest): Promise<InsertBlocksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertBlocksHeaders({ });
    return await this.insertBlocksWithOptions(documentId, request, headers, runtime);
  }

  async insertColumnsBeforeWithOptions(workbookId: string, sheetId: string, request: InsertColumnsBeforeRequest, headers: InsertColumnsBeforeHeaders, runtime: $Util.RuntimeOptions): Promise<InsertColumnsBeforeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.column)) {
      body["column"] = request.column;
    }

    if (!Util.isUnset(request.columnCount)) {
      body["columnCount"] = request.columnCount;
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
      action: "InsertColumnsBefore",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/insertColumnsBefore`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InsertColumnsBeforeResponse>(await this.execute(params, req, runtime), new InsertColumnsBeforeResponse({}));
  }

  async insertColumnsBefore(workbookId: string, sheetId: string, request: InsertColumnsBeforeRequest): Promise<InsertColumnsBeforeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertColumnsBeforeHeaders({ });
    return await this.insertColumnsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async insertDropdownListsWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: InsertDropdownListsRequest, headers: InsertDropdownListsHeaders, runtime: $Util.RuntimeOptions): Promise<InsertDropdownListsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.options)) {
      body["options"] = request.options;
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
      action: "InsertDropdownLists",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/insertDropdownLists`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InsertDropdownListsResponse>(await this.execute(params, req, runtime), new InsertDropdownListsResponse({}));
  }

  async insertDropdownLists(workbookId: string, sheetId: string, rangeAddress: string, request: InsertDropdownListsRequest): Promise<InsertDropdownListsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertDropdownListsHeaders({ });
    return await this.insertDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async insertRowsBeforeWithOptions(workbookId: string, sheetId: string, request: InsertRowsBeforeRequest, headers: InsertRowsBeforeHeaders, runtime: $Util.RuntimeOptions): Promise<InsertRowsBeforeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.row)) {
      body["row"] = request.row;
    }

    if (!Util.isUnset(request.rowCount)) {
      body["rowCount"] = request.rowCount;
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
      action: "InsertRowsBefore",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/insertRowsBefore`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InsertRowsBeforeResponse>(await this.execute(params, req, runtime), new InsertRowsBeforeResponse({}));
  }

  async insertRowsBefore(workbookId: string, sheetId: string, request: InsertRowsBeforeRequest): Promise<InsertRowsBeforeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertRowsBeforeHeaders({ });
    return await this.insertRowsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ListTemplate",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/templates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListTemplateResponse>(await this.execute(params, req, runtime), new ListTemplateResponse({}));
  }

  async listTemplate(request: ListTemplateRequest): Promise<ListTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTemplateHeaders({ });
    return await this.listTemplateWithOptions(request, headers, runtime);
  }

  async mergeRangeWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: MergeRangeRequest, headers: MergeRangeHeaders, runtime: $Util.RuntimeOptions): Promise<MergeRangeResponse> {
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
      action: "MergeRange",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/merge`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MergeRangeResponse>(await this.execute(params, req, runtime), new MergeRangeResponse({}));
  }

  async mergeRange(workbookId: string, sheetId: string, rangeAddress: string, request: MergeRangeRequest): Promise<MergeRangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MergeRangeHeaders({ });
    return await this.mergeRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async rangeFindNextWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: RangeFindNextRequest, headers: RangeFindNextHeaders, runtime: $Util.RuntimeOptions): Promise<RangeFindNextResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.findOptions)) {
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
    let params = new $OpenApi.Params({
      action: "RangeFindNext",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}/findNext`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RangeFindNextResponse>(await this.execute(params, req, runtime), new RangeFindNextResponse({}));
  }

  async rangeFindNext(workbookId: string, sheetId: string, rangeAddress: string, request: RangeFindNextRequest): Promise<RangeFindNextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RangeFindNextHeaders({ });
    return await this.rangeFindNextWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SearchWorkspaceDocs",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/docs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchWorkspaceDocsResponse>(await this.execute(params, req, runtime), new SearchWorkspaceDocsResponse({}));
  }

  async searchWorkspaceDocs(request: SearchWorkspaceDocsRequest): Promise<SearchWorkspaceDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchWorkspaceDocsHeaders({ });
    return await this.searchWorkspaceDocsWithOptions(request, headers, runtime);
  }

  async setColumnWidthWithOptions(workbookId: string, sheetId: string, request: SetColumnWidthRequest, headers: SetColumnWidthHeaders, runtime: $Util.RuntimeOptions): Promise<SetColumnWidthResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.column)) {
      body["column"] = request.column;
    }

    if (!Util.isUnset(request.width)) {
      body["width"] = request.width;
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
      action: "SetColumnWidth",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/setColumnWidth`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetColumnWidthResponse>(await this.execute(params, req, runtime), new SetColumnWidthResponse({}));
  }

  async setColumnWidth(workbookId: string, sheetId: string, request: SetColumnWidthRequest): Promise<SetColumnWidthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetColumnWidthHeaders({ });
    return await this.setColumnWidthWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async setColumnsVisibilityWithOptions(workbookId: string, sheetId: string, request: SetColumnsVisibilityRequest, headers: SetColumnsVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<SetColumnsVisibilityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.column)) {
      body["column"] = request.column;
    }

    if (!Util.isUnset(request.columnCount)) {
      body["columnCount"] = request.columnCount;
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
    let params = new $OpenApi.Params({
      action: "SetColumnsVisibility",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/setColumnsVisibility`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetColumnsVisibilityResponse>(await this.execute(params, req, runtime), new SetColumnsVisibilityResponse({}));
  }

  async setColumnsVisibility(workbookId: string, sheetId: string, request: SetColumnsVisibilityRequest): Promise<SetColumnsVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetColumnsVisibilityHeaders({ });
    return await this.setColumnsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async setRowHeightWithOptions(workbookId: string, sheetId: string, request: SetRowHeightRequest, headers: SetRowHeightHeaders, runtime: $Util.RuntimeOptions): Promise<SetRowHeightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.height)) {
      body["height"] = request.height;
    }

    if (!Util.isUnset(request.row)) {
      body["row"] = request.row;
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
      action: "SetRowHeight",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/setRowHeight`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetRowHeightResponse>(await this.execute(params, req, runtime), new SetRowHeightResponse({}));
  }

  async setRowHeight(workbookId: string, sheetId: string, request: SetRowHeightRequest): Promise<SetRowHeightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetRowHeightHeaders({ });
    return await this.setRowHeightWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async setRowsVisibilityWithOptions(workbookId: string, sheetId: string, request: SetRowsVisibilityRequest, headers: SetRowsVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<SetRowsVisibilityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.row)) {
      body["row"] = request.row;
    }

    if (!Util.isUnset(request.rowCount)) {
      body["rowCount"] = request.rowCount;
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
    let params = new $OpenApi.Params({
      action: "SetRowsVisibility",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/setRowsVisibility`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetRowsVisibilityResponse>(await this.execute(params, req, runtime), new SetRowsVisibilityResponse({}));
  }

  async setRowsVisibility(workbookId: string, sheetId: string, request: SetRowsVisibilityRequest): Promise<SetRowsVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetRowsVisibilityHeaders({ });
    return await this.setRowsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async sheetAutofitRowsWithOptions(workbookId: string, sheetId: string, request: SheetAutofitRowsRequest, headers: SheetAutofitRowsHeaders, runtime: $Util.RuntimeOptions): Promise<SheetAutofitRowsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fontWidth)) {
      body["fontWidth"] = request.fontWidth;
    }

    if (!Util.isUnset(request.row)) {
      body["row"] = request.row;
    }

    if (!Util.isUnset(request.rowCount)) {
      body["rowCount"] = request.rowCount;
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
      action: "SheetAutofitRows",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/autofitRows`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SheetAutofitRowsResponse>(await this.execute(params, req, runtime), new SheetAutofitRowsResponse({}));
  }

  async sheetAutofitRows(workbookId: string, sheetId: string, request: SheetAutofitRowsRequest): Promise<SheetAutofitRowsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SheetAutofitRowsHeaders({ });
    return await this.sheetAutofitRowsWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async sheetFindAllWithOptions(workbookId: string, sheetId: string, request: SheetFindAllRequest, headers: SheetFindAllHeaders, runtime: $Util.RuntimeOptions): Promise<SheetFindAllResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.select)) {
      query["select"] = request.select;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.findOptions)) {
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
    let params = new $OpenApi.Params({
      action: "SheetFindAll",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/findAll`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SheetFindAllResponse>(await this.execute(params, req, runtime), new SheetFindAllResponse({}));
  }

  async sheetFindAll(workbookId: string, sheetId: string, request: SheetFindAllRequest): Promise<SheetFindAllResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SheetFindAllHeaders({ });
    return await this.sheetFindAllWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async unbindCoolAppToSheetWithOptions(workbookId: string, request: UnbindCoolAppToSheetRequest, headers: UnbindCoolAppToSheetHeaders, runtime: $Util.RuntimeOptions): Promise<UnbindCoolAppToSheetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      query["coolAppCode"] = request.coolAppCode;
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
      action: "UnbindCoolAppToSheet",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/coolApps`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnbindCoolAppToSheetResponse>(await this.execute(params, req, runtime), new UnbindCoolAppToSheetResponse({}));
  }

  async unbindCoolAppToSheet(workbookId: string, request: UnbindCoolAppToSheetRequest): Promise<UnbindCoolAppToSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnbindCoolAppToSheetHeaders({ });
    return await this.unbindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
  }

  async updateRangeWithOptions(workbookId: string, sheetId: string, rangeAddress: string, request: UpdateRangeRequest, headers: UpdateRangeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRangeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.backgroundColors)) {
      body["backgroundColors"] = request.backgroundColors;
    }

    if (!Util.isUnset(request.fontSizes)) {
      body["fontSizes"] = request.fontSizes;
    }

    if (!Util.isUnset(request.fontWeights)) {
      body["fontWeights"] = request.fontWeights;
    }

    if (!Util.isUnset(request.horizontalAlignments)) {
      body["horizontalAlignments"] = request.horizontalAlignments;
    }

    if (!Util.isUnset(request.hyperlinks)) {
      body["hyperlinks"] = request.hyperlinks;
    }

    if (!Util.isUnset(request.numberFormat)) {
      body["numberFormat"] = request.numberFormat;
    }

    if (!Util.isUnset(request.values)) {
      body["values"] = request.values;
    }

    if (!Util.isUnset(request.verticalAlignments)) {
      body["verticalAlignments"] = request.verticalAlignments;
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
      action: "UpdateRange",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}/ranges/${rangeAddress}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRangeResponse>(await this.execute(params, req, runtime), new UpdateRangeResponse({}));
  }

  async updateRange(workbookId: string, sheetId: string, rangeAddress: string, request: UpdateRangeRequest): Promise<UpdateRangeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRangeHeaders({ });
    return await this.updateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
  }

  async updateSheetWithOptions(workbookId: string, sheetId: string, request: UpdateSheetRequest, headers: UpdateSheetHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSheetResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateSheet",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workbooks/${workbookId}/sheets/${sheetId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateSheetResponse>(await this.execute(params, req, runtime), new UpdateSheetResponse({}));
  }

  async updateSheet(workbookId: string, sheetId: string, request: UpdateSheetRequest): Promise<UpdateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSheetHeaders({ });
    return await this.updateSheetWithOptions(workbookId, sheetId, request, headers, runtime);
  }

  async updateWorkspaceDocMembersWithOptions(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest, headers: UpdateWorkspaceDocMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceDocMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateWorkspaceDocMembers",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/docs/${nodeId}/members`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateWorkspaceDocMembersResponse>(await this.execute(params, req, runtime), new UpdateWorkspaceDocMembersResponse({}));
  }

  async updateWorkspaceDocMembers(workspaceId: string, nodeId: string, request: UpdateWorkspaceDocMembersRequest): Promise<UpdateWorkspaceDocMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceDocMembersHeaders({ });
    return await this.updateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
  }

  async updateWorkspaceMembersWithOptions(workspaceId: string, request: UpdateWorkspaceMembersRequest, headers: UpdateWorkspaceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateWorkspaceMembersResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "UpdateWorkspaceMembers",
      version: "doc_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/doc/workspaces/${workspaceId}/members`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateWorkspaceMembersResponse>(await this.execute(params, req, runtime), new UpdateWorkspaceMembersResponse({}));
  }

  async updateWorkspaceMembers(workspaceId: string, request: UpdateWorkspaceMembersRequest): Promise<UpdateWorkspaceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateWorkspaceMembersHeaders({ });
    return await this.updateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
  }

}
