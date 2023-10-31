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

export class AddAccountMappingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAccountMappingRequest extends $tea.Model {
  domain?: string;
  extension?: { [key: string]: string };
  outId?: string;
  outTenantId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      extension: 'extension',
      outId: 'outId',
      outTenantId: 'outTenantId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      outId: 'string',
      outTenantId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAccountMappingResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAccountMappingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddAccountMappingResponseBody;
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
      body: AddAccountMappingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingRequest extends $tea.Model {
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  name?: string;
  nodeListSceneConfig?: AddContactHideBySceneSettingRequestNodeListSceneConfig;
  objectDeptIds?: number[];
  objectTagIds?: number[];
  objectUserIds?: string[];
  profileSceneConfig?: AddContactHideBySceneSettingRequestProfileSceneConfig;
  searchSceneConfig?: AddContactHideBySceneSettingRequestSearchSceneConfig;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      name: 'name',
      nodeListSceneConfig: 'nodeListSceneConfig',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      objectUserIds: 'objectUserIds',
      profileSceneConfig: 'profileSceneConfig',
      searchSceneConfig: 'searchSceneConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      nodeListSceneConfig: AddContactHideBySceneSettingRequestNodeListSceneConfig,
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      objectUserIds: { 'type': 'array', 'itemType': 'string' },
      profileSceneConfig: AddContactHideBySceneSettingRequestProfileSceneConfig,
      searchSceneConfig: AddContactHideBySceneSettingRequestSearchSceneConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingResponseBody extends $tea.Model {
  settingId?: number;
  static names(): { [key: string]: string } {
    return {
      settingId: 'settingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      settingId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddContactHideBySceneSettingResponseBody;
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
      body: AddContactHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingRequest extends $tea.Model {
  chatSubtitleConfig?: AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig;
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  hideFields?: string[];
  name?: string;
  objectDeptIds?: number[];
  objectTagIds?: number[];
  objectUserIds?: string[];
  profileSceneConfig?: AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig;
  searchSceneConfig?: AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig;
  static names(): { [key: string]: string } {
    return {
      chatSubtitleConfig: 'chatSubtitleConfig',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      hideFields: 'hideFields',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      objectUserIds: 'objectUserIds',
      profileSceneConfig: 'profileSceneConfig',
      searchSceneConfig: 'searchSceneConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatSubtitleConfig: AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig,
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      hideFields: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      objectUserIds: { 'type': 'array', 'itemType': 'string' },
      profileSceneConfig: AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig,
      searchSceneConfig: AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingResponseBody extends $tea.Model {
  settingId?: number;
  static names(): { [key: string]: string } {
    return {
      settingId: 'settingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      settingId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddEmpAttributeHideBySceneSettingResponseBody;
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
      body: AddEmpAttributeHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AnnualCertificationAuditHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AnnualCertificationAuditRequest extends $tea.Model {
  applicantMobile?: string;
  applicantName?: string;
  applicationLetter?: string;
  authStatus?: number;
  certificateType?: number;
  corpName?: string;
  depositaryBank?: string;
  extension?: string;
  legalPerson?: string;
  licenseNumber?: string;
  licenseUrl?: string;
  orderId?: string;
  publicAccount?: string;
  reasonCode?: string;
  reasonMsg?: string;
  tag?: string;
  static names(): { [key: string]: string } {
    return {
      applicantMobile: 'applicantMobile',
      applicantName: 'applicantName',
      applicationLetter: 'applicationLetter',
      authStatus: 'authStatus',
      certificateType: 'certificateType',
      corpName: 'corpName',
      depositaryBank: 'depositaryBank',
      extension: 'extension',
      legalPerson: 'legalPerson',
      licenseNumber: 'licenseNumber',
      licenseUrl: 'licenseUrl',
      orderId: 'orderId',
      publicAccount: 'publicAccount',
      reasonCode: 'reasonCode',
      reasonMsg: 'reasonMsg',
      tag: 'tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      applicantMobile: 'string',
      applicantName: 'string',
      applicationLetter: 'string',
      authStatus: 'number',
      certificateType: 'number',
      corpName: 'string',
      depositaryBank: 'string',
      extension: 'string',
      legalPerson: 'string',
      licenseNumber: 'string',
      licenseUrl: 'string',
      orderId: 'string',
      publicAccount: 'string',
      reasonCode: 'string',
      reasonMsg: 'string',
      tag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AnnualCertificationAuditResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AnnualCertificationAuditResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AnnualCertificationAuditResponseBody;
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
      body: AnnualCertificationAuditResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchApproveUnionApplyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchApproveUnionApplyRequest extends $tea.Model {
  body?: BatchApproveUnionApplyRequestBody[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': BatchApproveUnionApplyRequestBody },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchApproveUnionApplyResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchApproveUnionApplyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchApproveUnionApplyResponseBody;
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
      body: BatchApproveUnionApplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangeMainAdminHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangeMainAdminRequest extends $tea.Model {
  effectCorpId?: string;
  sourceUserId?: string;
  targetUserId?: string;
  static names(): { [key: string]: string } {
    return {
      effectCorpId: 'effectCorpId',
      sourceUserId: 'sourceUserId',
      targetUserId: 'targetUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      effectCorpId: 'string',
      sourceUserId: 'string',
      targetUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangeMainAdminResponse extends $tea.Model {
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

export class CreateCooperateOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCooperateOrgRequest extends $tea.Model {
  industryCode?: number;
  logoMediaId?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      industryCode: 'industryCode',
      logoMediaId: 'logoMediaId',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      industryCode: 'number',
      logoMediaId: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCooperateOrgResponseBody extends $tea.Model {
  cooperateCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      cooperateCorpId: 'cooperateCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cooperateCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCooperateOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateCooperateOrgResponseBody;
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
      body: CreateCooperateOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupRequest extends $tea.Model {
  groupName?: string;
  members?: CreateManagementGroupRequestMembers[];
  resourceIds?: string[];
  scope?: CreateManagementGroupRequestScope;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      members: 'members',
      resourceIds: 'resourceIds',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      members: { 'type': 'array', 'itemType': CreateManagementGroupRequestMembers },
      resourceIds: { 'type': 'array', 'itemType': 'string' },
      scope: CreateManagementGroupRequestScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupResponseBody extends $tea.Model {
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateManagementGroupResponseBody;
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
      body: CreateManagementGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSecondaryManagementGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSecondaryManagementGroupRequest extends $tea.Model {
  groupName?: string;
  members?: CreateSecondaryManagementGroupRequestMembers[];
  resourceIds?: string[];
  scope?: CreateSecondaryManagementGroupRequestScope;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      members: 'members',
      resourceIds: 'resourceIds',
      scope: 'scope',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      members: { 'type': 'array', 'itemType': CreateSecondaryManagementGroupRequestMembers },
      resourceIds: { 'type': 'array', 'itemType': 'string' },
      scope: CreateSecondaryManagementGroupRequestScope,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSecondaryManagementGroupResponseBody extends $tea.Model {
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSecondaryManagementGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateSecondaryManagementGroupResponseBody;
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
      body: CreateSecondaryManagementGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DelAccountMappingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DelAccountMappingRequest extends $tea.Model {
  domain?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DelAccountMappingResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DelAccountMappingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DelAccountMappingResponseBody;
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
      body: DelAccountMappingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteContactHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteContactHideBySceneSettingResponseBody extends $tea.Model {
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

export class DeleteContactHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteContactHideBySceneSettingResponseBody;
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
      body: DeleteContactHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteContactHideSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteContactHideSettingResponse extends $tea.Model {
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

export class DeleteContactRestrictSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteContactRestrictSettingResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteContactRestrictSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteContactRestrictSettingResponseBody;
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
      body: DeleteContactRestrictSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEmpAttributeHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEmpAttributeHideBySceneSettingResponseBody extends $tea.Model {
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

export class DeleteEmpAttributeHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteEmpAttributeHideBySceneSettingResponseBody;
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
      body: DeleteEmpAttributeHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEmpAttributeVisibilityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEmpAttributeVisibilityResponse extends $tea.Model {
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

export class DeleteManagementGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteManagementGroupResponse extends $tea.Model {
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

export class GetAccountMappingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountMappingRequest extends $tea.Model {
  domain?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountMappingResponseBody extends $tea.Model {
  result?: GetAccountMappingResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetAccountMappingResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountMappingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAccountMappingResponseBody;
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
      body: GetAccountMappingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoRequest extends $tea.Model {
  deptId?: number;
  inviterUserId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      inviterUserId: 'inviterUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      inviterUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoResponseBody extends $tea.Model {
  auditType?: number;
  empApplyJoinDept?: boolean;
  inviteSwitch?: boolean;
  inviteUrl?: string;
  linkInvite?: boolean;
  orgApplyCodeInvite?: boolean;
  searchNameInvite?: boolean;
  static names(): { [key: string]: string } {
    return {
      auditType: 'auditType',
      empApplyJoinDept: 'empApplyJoinDept',
      inviteSwitch: 'inviteSwitch',
      inviteUrl: 'inviteUrl',
      linkInvite: 'linkInvite',
      orgApplyCodeInvite: 'orgApplyCodeInvite',
      searchNameInvite: 'searchNameInvite',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auditType: 'number',
      empApplyJoinDept: 'boolean',
      inviteSwitch: 'boolean',
      inviteUrl: 'string',
      linkInvite: 'boolean',
      orgApplyCodeInvite: 'boolean',
      searchNameInvite: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetApplyInviteInfoResponseBody;
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
      body: GetApplyInviteInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataRequest extends $tea.Model {
  body?: { [key: string]: string };
  branchCorpId?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      branchCorpId: 'branchCorpId',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      branchCorpId: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponseBody extends $tea.Model {
  result?: GetBranchAuthDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetBranchAuthDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetBranchAuthDataResponseBody;
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
      body: GetBranchAuthDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInUserHolderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInUserHolderResponseBody extends $tea.Model {
  avatarUrl?: string;
  cardAcceptStatus?: number;
  cardAcceptTimeLong?: number;
  cardId?: string;
  cardSource?: number;
  extension?: { [key: string]: any };
  industryName?: string;
  introduce?: string;
  name?: string;
  orgName?: string;
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      cardAcceptStatus: 'cardAcceptStatus',
      cardAcceptTimeLong: 'cardAcceptTimeLong',
      cardId: 'cardId',
      cardSource: 'cardSource',
      extension: 'extension',
      industryName: 'industryName',
      introduce: 'introduce',
      name: 'name',
      orgName: 'orgName',
      templateId: 'templateId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      cardAcceptStatus: 'number',
      cardAcceptTimeLong: 'number',
      cardId: 'string',
      cardSource: 'number',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      industryName: 'string',
      introduce: 'string',
      name: 'string',
      orgName: 'string',
      templateId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInUserHolderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCardInUserHolderResponseBody;
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
      body: GetCardInUserHolderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBody extends $tea.Model {
  adminRole?: number;
  avatarUrl?: string;
  cardId?: string;
  extension?: GetCardInfoResponseBodyExtension;
  industryName?: string;
  introduce?: { [key: string]: any };
  name?: string;
  orgName?: string;
  settings?: { [key: string]: any };
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      adminRole: 'adminRole',
      avatarUrl: 'avatarUrl',
      cardId: 'cardId',
      extension: 'extension',
      industryName: 'industryName',
      introduce: 'introduce',
      name: 'name',
      orgName: 'orgName',
      settings: 'settings',
      templateId: 'templateId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adminRole: 'number',
      avatarUrl: 'string',
      cardId: 'string',
      extension: GetCardInfoResponseBodyExtension,
      industryName: 'string',
      introduce: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      orgName: 'string',
      settings: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      templateId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCardInfoResponseBody;
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
      body: GetCardInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactHideBySceneSettingResponseBody extends $tea.Model {
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  id?: number;
  name?: string;
  nodeListSceneConfig?: GetContactHideBySceneSettingResponseBodyNodeListSceneConfig;
  objectDeptIds?: number[];
  objectTagIds?: number[];
  objectUserIds?: string[];
  profileSceneConfig?: GetContactHideBySceneSettingResponseBodyProfileSceneConfig;
  searchSceneConfig?: GetContactHideBySceneSettingResponseBodySearchSceneConfig;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      id: 'id',
      name: 'name',
      nodeListSceneConfig: 'nodeListSceneConfig',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      objectUserIds: 'objectUserIds',
      profileSceneConfig: 'profileSceneConfig',
      searchSceneConfig: 'searchSceneConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      name: 'string',
      nodeListSceneConfig: GetContactHideBySceneSettingResponseBodyNodeListSceneConfig,
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      objectUserIds: { 'type': 'array', 'itemType': 'string' },
      profileSceneConfig: GetContactHideBySceneSettingResponseBodyProfileSceneConfig,
      searchSceneConfig: GetContactHideBySceneSettingResponseBodySearchSceneConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetContactHideBySceneSettingResponseBody;
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
      body: GetContactHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCooperateOrgInviteInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCooperateOrgInviteInfoResponseBody extends $tea.Model {
  inviteUrl?: string;
  static names(): { [key: string]: string } {
    return {
      inviteUrl: 'inviteUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCooperateOrgInviteInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCooperateOrgInviteInfoResponseBody;
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
      body: GetCooperateOrgInviteInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpCardStyleListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpCardStyleListResponseBody extends $tea.Model {
  result?: { [key: string]: any }[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpCardStyleListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCorpCardStyleListResponseBody;
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
      body: GetCorpCardStyleListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdRequest extends $tea.Model {
  migrationDingId?: string;
  static names(): { [key: string]: string } {
    return {
      migrationDingId: 'migrationDingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationDingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdResponseBody extends $tea.Model {
  dingId?: string;
  static names(): { [key: string]: string } {
    return {
      dingId: 'dingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDingIdByMigrationDingIdResponseBody;
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
      body: GetDingIdByMigrationDingIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpAttributeHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpAttributeHideBySceneSettingResponseBody extends $tea.Model {
  chatSubtitleConfig?: GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig;
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  hideFields?: string[];
  id?: number;
  name?: string;
  objectDeptIds?: number[];
  objectTagIds?: number[];
  objectUserIds?: string[];
  profileSceneConfig?: GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig;
  searchSceneConfig?: GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig;
  static names(): { [key: string]: string } {
    return {
      chatSubtitleConfig: 'chatSubtitleConfig',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      hideFields: 'hideFields',
      id: 'id',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      objectUserIds: 'objectUserIds',
      profileSceneConfig: 'profileSceneConfig',
      searchSceneConfig: 'searchSceneConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatSubtitleConfig: GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig,
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      hideFields: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      objectUserIds: { 'type': 'array', 'itemType': 'string' },
      profileSceneConfig: GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig,
      searchSceneConfig: GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpAttributeHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetEmpAttributeHideBySceneSettingResponseBody;
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
      body: GetEmpAttributeHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexResponseBody extends $tea.Model {
  idxCarbon?: number;
  idxEfficiency?: number;
  idxMonthlyAvg?: number;
  idxTotal?: number;
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      idxCarbon: 'idxCarbon',
      idxEfficiency: 'idxEfficiency',
      idxMonthlyAvg: 'idxMonthlyAvg',
      idxTotal: 'idxTotal',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      idxCarbon: 'number',
      idxEfficiency: 'number',
      idxMonthlyAvg: 'number',
      idxTotal: 'number',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetLatestDingIndexResponseBody;
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
      body: GetLatestDingIndexResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdRequest extends $tea.Model {
  dingId?: string;
  static names(): { [key: string]: string } {
    return {
      dingId: 'dingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdResponseBody extends $tea.Model {
  migrationDingIdList?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      migrationDingIdList: 'migrationDingIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationDingIdList: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMigrationDingIdByDingIdResponseBody;
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
      body: GetMigrationDingIdByDingIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationUnionIdByUnionIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationUnionIdByUnionIdRequest extends $tea.Model {
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

export class GetMigrationUnionIdByUnionIdResponseBody extends $tea.Model {
  migrationUnionIdList?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      migrationUnionIdList: 'migrationUnionIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationUnionIdList: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationUnionIdByUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMigrationUnionIdByUnionIdResponseBody;
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
      body: GetMigrationUnionIdByUnionIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgAuthInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgAuthInfoRequest extends $tea.Model {
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgAuthInfoResponseBody extends $tea.Model {
  authLevel?: number;
  legalPerson?: string;
  licenseOrgName?: string;
  licenseUrl?: string;
  orgName?: string;
  organizationCode?: string;
  registrationNum?: string;
  unifiedSocialCredit?: string;
  static names(): { [key: string]: string } {
    return {
      authLevel: 'authLevel',
      legalPerson: 'legalPerson',
      licenseOrgName: 'licenseOrgName',
      licenseUrl: 'licenseUrl',
      orgName: 'orgName',
      organizationCode: 'organizationCode',
      registrationNum: 'registrationNum',
      unifiedSocialCredit: 'unifiedSocialCredit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authLevel: 'number',
      legalPerson: 'string',
      licenseOrgName: 'string',
      licenseUrl: 'string',
      orgName: 'string',
      organizationCode: 'string',
      registrationNum: 'string',
      unifiedSocialCredit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOrgAuthInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOrgAuthInfoResponseBody;
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
      body: GetOrgAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultRequest extends $tea.Model {
  jobId?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultResponseBody extends $tea.Model {
  status?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTranslateFileJobResultResponseBody;
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
      body: GetTranslateFileJobResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUnionIdByMigrationUnionIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUnionIdByMigrationUnionIdRequest extends $tea.Model {
  migrationUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      migrationUnionId: 'migrationUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUnionIdByMigrationUnionIdResponseBody extends $tea.Model {
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

export class GetUnionIdByMigrationUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUnionIdByMigrationUnionIdResponseBody;
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
      body: GetUnionIdByMigrationUnionIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBody extends $tea.Model {
  avatarUrl?: string;
  email?: string;
  mobile?: string;
  nick?: string;
  openId?: string;
  stateCode?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      email: 'email',
      mobile: 'mobile',
      nick: 'nick',
      openId: 'openId',
      stateCode: 'stateCode',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      email: 'string',
      mobile: 'string',
      nick: 'string',
      openId: 'string',
      stateCode: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserResponseBody;
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
      body: GetUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCardHolderListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCardHolderListRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCardHolderListResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: GetUserCardHolderListResponseBodyList[];
  nextToken?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': GetUserCardHolderListResponseBodyList },
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCardHolderListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserCardHolderListResponseBody;
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
      body: GetUserCardHolderListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsFriendHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsFriendRequest extends $tea.Model {
  mobileNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      mobileNo: 'mobileNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsFriendResponseBody extends $tea.Model {
  isFriend?: boolean;
  static names(): { [key: string]: string } {
    return {
      isFriend: 'isFriend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isFriend: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsFriendResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IsFriendResponseBody;
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
      body: IsFriendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsvCardEventPushHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsvCardEventPushRequest extends $tea.Model {
  eventParams?: { [key: string]: any };
  eventType?: string;
  isvCardId?: string;
  isvToken?: string;
  isvUid?: string;
  static names(): { [key: string]: string } {
    return {
      eventParams: 'eventParams',
      eventType: 'eventType',
      isvCardId: 'isvCardId',
      isvToken: 'isvToken',
      isvUid: 'isvUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      eventType: 'string',
      isvCardId: 'string',
      isvToken: 'string',
      isvUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IsvCardEventPushResponseBody extends $tea.Model {
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

export class IsvCardEventPushResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: IsvCardEventPushResponseBody;
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
      body: IsvCardEventPushResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageRequest extends $tea.Model {
  agentId?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: ListBasicRoleInPageResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListBasicRoleInPageResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListBasicRoleInPageResponseBody;
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
      body: ListBasicRoleInPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: ListContactHideSettingsResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListContactHideSettingsResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListContactHideSettingsResponseBody;
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
      body: ListContactHideSettingsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactRestrictSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactRestrictSettingRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactRestrictSettingResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: ListContactRestrictSettingResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListContactRestrictSettingResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactRestrictSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListContactRestrictSettingResponseBody;
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
      body: ListContactRestrictSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: ListEmpAttributeVisibilityResponseBodyList[];
  nextCursor?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListEmpAttributeVisibilityResponseBodyList },
      nextCursor: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListEmpAttributeVisibilityResponseBody;
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
      body: ListEmpAttributeVisibilityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpLeaveRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpLeaveRecordsRequest extends $tea.Model {
  endTime?: string;
  maxResults?: number;
  nextToken?: string;
  startTime?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      maxResults: 'number',
      nextToken: 'string',
      startTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpLeaveRecordsResponseBody extends $tea.Model {
  nextToken?: string;
  records?: ListEmpLeaveRecordsResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': ListEmpLeaveRecordsResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpLeaveRecordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListEmpLeaveRecordsResponseBody;
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
      body: ListEmpLeaveRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBody extends $tea.Model {
  groups?: ListManagementGroupsResponseBodyGroups[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      groups: 'groups',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groups: { 'type': 'array', 'itemType': ListManagementGroupsResponseBodyGroups },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListManagementGroupsResponseBody;
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
      body: ListManagementGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOwnedOrgByStaffIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOwnedOrgByStaffIdRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOwnedOrgByStaffIdResponseBody extends $tea.Model {
  orgList?: ListOwnedOrgByStaffIdResponseBodyOrgList[];
  static names(): { [key: string]: string } {
    return {
      orgList: 'orgList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgList: { 'type': 'array', 'itemType': ListOwnedOrgByStaffIdResponseBodyOrgList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOwnedOrgByStaffIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListOwnedOrgByStaffIdResponseBody;
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
      body: ListOwnedOrgByStaffIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsRequest extends $tea.Model {
  seniorStaffId?: string;
  static names(): { [key: string]: string } {
    return {
      seniorStaffId: 'seniorStaffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      seniorStaffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsResponseBody extends $tea.Model {
  protectScenes?: string[];
  seniorStaffId?: string;
  seniorWhiteList?: ListSeniorSettingsResponseBodySeniorWhiteList[];
  static names(): { [key: string]: string } {
    return {
      protectScenes: 'protectScenes',
      seniorStaffId: 'seniorStaffId',
      seniorWhiteList: 'seniorWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      protectScenes: { 'type': 'array', 'itemType': 'string' },
      seniorStaffId: 'string',
      seniorWhiteList: { 'type': 'array', 'itemType': ListSeniorSettingsResponseBodySeniorWhiteList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListSeniorSettingsResponseBody;
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
      body: ListSeniorSettingsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MultiOrgPermissionGrantHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MultiOrgPermissionGrantRequest extends $tea.Model {
  grantDeptIdList?: number[];
  joinCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      grantDeptIdList: 'grantDeptIdList',
      joinCorpId: 'joinCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      grantDeptIdList: { 'type': 'array', 'itemType': 'number' },
      joinCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MultiOrgPermissionGrantResponse extends $tea.Model {
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

export class QueryCardVisitorStatisticDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCardVisitorStatisticDataRequest extends $tea.Model {
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

export class QueryCardVisitorStatisticDataResponseBody extends $tea.Model {
  cardSendCnt?: number;
  todayVisitAddCnt?: number;
  todayVisitCnt?: number;
  totalVisitAddCnt?: number;
  totalVisitCnt?: number;
  wechatTodayVisitAddCnt?: number;
  wechatTodayVisitCnt?: number;
  wechatTotalVisitAddCnt?: number;
  wechatTotalVisitCnt?: number;
  static names(): { [key: string]: string } {
    return {
      cardSendCnt: 'cardSendCnt',
      todayVisitAddCnt: 'todayVisitAddCnt',
      todayVisitCnt: 'todayVisitCnt',
      totalVisitAddCnt: 'totalVisitAddCnt',
      totalVisitCnt: 'totalVisitCnt',
      wechatTodayVisitAddCnt: 'wechatTodayVisitAddCnt',
      wechatTodayVisitCnt: 'wechatTodayVisitCnt',
      wechatTotalVisitAddCnt: 'wechatTotalVisitAddCnt',
      wechatTotalVisitCnt: 'wechatTotalVisitCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardSendCnt: 'number',
      todayVisitAddCnt: 'number',
      todayVisitCnt: 'number',
      totalVisitAddCnt: 'number',
      totalVisitCnt: 'number',
      wechatTodayVisitAddCnt: 'number',
      wechatTodayVisitCnt: 'number',
      wechatTotalVisitAddCnt: 'number',
      wechatTotalVisitCnt: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCardVisitorStatisticDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCardVisitorStatisticDataResponseBody;
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
      body: QueryCardVisitorStatisticDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpStatisticDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpStatisticDataRequest extends $tea.Model {
  endTime?: string;
  startTime?: string;
  templateIds?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      templateIds: 'templateIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      startTime: 'string',
      templateIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpStatisticDataResponseBody extends $tea.Model {
  result?: QueryCorpStatisticDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryCorpStatisticDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpStatisticDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCorpStatisticDataResponseBody;
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
      body: QueryCorpStatisticDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpUserStatisticHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpUserStatisticRequest extends $tea.Model {
  endTime?: string;
  maxResults?: number;
  nextToken?: number;
  startTime?: string;
  templateIds?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTime: 'startTime',
      templateIds: 'templateIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      maxResults: 'number',
      nextToken: 'number',
      startTime: 'string',
      templateIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpUserStatisticResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryCorpUserStatisticResponseBodyList[];
  nextToken?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCorpUserStatisticResponseBodyList },
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpUserStatisticResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCorpUserStatisticResponseBody;
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
      body: QueryCorpUserStatisticResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryResourceManagementMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryResourceManagementMembersResponseBody extends $tea.Model {
  members?: QueryResourceManagementMembersResponseBodyMembers[];
  static names(): { [key: string]: string } {
    return {
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': QueryResourceManagementMembersResponseBodyMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryResourceManagementMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryResourceManagementMembersResponseBody;
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
      body: QueryResourceManagementMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatusRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatusResponseBody extends $tea.Model {
  disable?: boolean;
  static names(): { [key: string]: string } {
    return {
      disable: 'disable',
    };
  }

  static types(): { [key: string]: any } {
    return {
      disable: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryStatusResponseBody;
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
      body: QueryStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserManagementResourcesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserManagementResourcesResponseBody extends $tea.Model {
  resourceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      resourceIds: 'resourceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resourceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserManagementResourcesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserManagementResourcesResponseBody;
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
      body: QueryUserManagementResourcesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVerifyResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVerifyResultRequest extends $tea.Model {
  verifyId?: string;
  static names(): { [key: string]: string } {
    return {
      verifyId: 'verifyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      verifyId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVerifyResultResponseBody extends $tea.Model {
  corpId?: string;
  factorCode?: string;
  factorDesc?: string;
  resultCode?: string;
  resultDesc?: string;
  state?: string;
  userId?: string;
  verifyTimestamp?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      factorCode: 'factorCode',
      factorDesc: 'factorDesc',
      resultCode: 'resultCode',
      resultDesc: 'resultDesc',
      state: 'state',
      userId: 'userId',
      verifyTimestamp: 'verifyTimestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      factorCode: 'string',
      factorDesc: 'string',
      resultCode: 'string',
      resultDesc: 'string',
      state: 'string',
      userId: 'string',
      verifyTimestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVerifyResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryVerifyResultResponseBody;
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
      body: QueryVerifyResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDepartmentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDepartmentRequest extends $tea.Model {
  offset?: number;
  queryWord?: string;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      offset: 'offset',
      queryWord: 'queryWord',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      offset: 'number',
      queryWord: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDepartmentResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: number[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': 'number' },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchDepartmentResponseBody;
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
      body: SearchDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserRequest extends $tea.Model {
  fullMatchField?: number;
  offset?: number;
  queryWord?: string;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      fullMatchField: 'fullMatchField',
      offset: 'offset',
      queryWord: 'queryWord',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fullMatchField: 'number',
      offset: 'number',
      queryWord: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: string[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': 'string' },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchUserResponseBody;
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
      body: SearchUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeparateBranchOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeparateBranchOrgRequest extends $tea.Model {
  attachDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      attachDeptId: 'attachDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeparateBranchOrgResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SeparateBranchOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SeparateBranchOrgResponseBody;
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
      body: SeparateBranchOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDisableHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDisableRequest extends $tea.Model {
  reason?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      reason: 'reason',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reason: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDisableResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetDisableResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetDisableResponseBody;
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
      body: SetDisableResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetEnableHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetEnableRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetEnableResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetEnableResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SetEnableResponseBody;
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
      body: SetEnableResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignOutHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignOutRequest extends $tea.Model {
  reason?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      reason: 'reason',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reason: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignOutResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignOutResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SignOutResponseBody;
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
      body: SignOutResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SortUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SortUserRequest extends $tea.Model {
  sortType?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      sortType: 'sortType',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sortType: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SortUserResponseBody extends $tea.Model {
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SortUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SortUserResponseBody;
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
      body: SortUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransformToExclusiveAccountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransformToExclusiveAccountRequest extends $tea.Model {
  idpDingTalk?: boolean;
  initPassword?: string;
  loginId?: string;
  transformType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      idpDingTalk: 'idpDingTalk',
      initPassword: 'initPassword',
      loginId: 'loginId',
      transformType: 'transformType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      idpDingTalk: 'boolean',
      initPassword: 'string',
      loginId: 'string',
      transformType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransformToExclusiveAccountResponse extends $tea.Model {
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

export class TranslateFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TranslateFileRequest extends $tea.Model {
  medias?: { [key: string]: string };
  outputFileName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      medias: 'medias',
      outputFileName: 'outputFileName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      medias: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      outputFileName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TranslateFileResponseBody extends $tea.Model {
  jobId?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TranslateFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: TranslateFileResponseBody;
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
      body: TranslateFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UniqueQueryUserCardHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UniqueQueryUserCardRequest extends $tea.Model {
  templateId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UniqueQueryUserCardResponseBody extends $tea.Model {
  avatarUrl?: string;
  cardId?: string;
  extension?: { [key: string]: any };
  industryName?: string;
  introduce?: string;
  name?: string;
  orgName?: string;
  settings?: { [key: string]: any };
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      cardId: 'cardId',
      extension: 'extension',
      industryName: 'industryName',
      introduce: 'introduce',
      name: 'name',
      orgName: 'orgName',
      settings: 'settings',
      templateId: 'templateId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      cardId: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      industryName: 'string',
      introduce: 'string',
      name: 'string',
      orgName: 'string',
      settings: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      templateId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UniqueQueryUserCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UniqueQueryUserCardResponseBody;
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
      body: UniqueQueryUserCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBranchAttributesInCooperateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBranchAttributesInCooperateRequest extends $tea.Model {
  body?: UpdateBranchAttributesInCooperateRequestBody[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': UpdateBranchAttributesInCooperateRequestBody },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBranchAttributesInCooperateResponse extends $tea.Model {
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

export class UpdateBranchVisibleSettingInCooperateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBranchVisibleSettingInCooperateRequest extends $tea.Model {
  body?: UpdateBranchVisibleSettingInCooperateRequestBody[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': UpdateBranchVisibleSettingInCooperateRequestBody },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBranchVisibleSettingInCooperateResponse extends $tea.Model {
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

export class UpdateContactHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideBySceneSettingRequest extends $tea.Model {
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  name?: string;
  nodeListSceneConfig?: UpdateContactHideBySceneSettingRequestNodeListSceneConfig;
  objectDeptIds?: number[];
  objectTagIds?: number[];
  objectUserIds?: string[];
  profileSceneConfig?: UpdateContactHideBySceneSettingRequestProfileSceneConfig;
  searchSceneConfig?: UpdateContactHideBySceneSettingRequestSearchSceneConfig;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      name: 'name',
      nodeListSceneConfig: 'nodeListSceneConfig',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      objectUserIds: 'objectUserIds',
      profileSceneConfig: 'profileSceneConfig',
      searchSceneConfig: 'searchSceneConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      nodeListSceneConfig: UpdateContactHideBySceneSettingRequestNodeListSceneConfig,
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      objectUserIds: { 'type': 'array', 'itemType': 'string' },
      profileSceneConfig: UpdateContactHideBySceneSettingRequestProfileSceneConfig,
      searchSceneConfig: UpdateContactHideBySceneSettingRequestSearchSceneConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideBySceneSettingResponseBody extends $tea.Model {
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

export class UpdateContactHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateContactHideBySceneSettingResponseBody;
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
      body: UpdateContactHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingRequest extends $tea.Model {
  active?: boolean;
  description?: string;
  excludeDeptIds?: number[];
  excludeStaffIds?: string[];
  excludeTagIds?: number[];
  hideInSearch?: boolean;
  hideInUserProfile?: boolean;
  id?: number;
  name?: string;
  objectDeptIds?: number[];
  objectStaffIds?: string[];
  objectTagIds?: number[];
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeStaffIds: 'excludeStaffIds',
      excludeTagIds: 'excludeTagIds',
      hideInSearch: 'hideInSearch',
      hideInUserProfile: 'hideInUserProfile',
      id: 'id',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectStaffIds: 'objectStaffIds',
      objectTagIds: 'objectTagIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      hideInSearch: 'boolean',
      hideInUserProfile: 'boolean',
      id: 'number',
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateContactHideSettingResponseBody;
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
      body: UpdateContactHideSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactRestrictSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactRestrictSettingRequest extends $tea.Model {
  active?: boolean;
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  id?: number;
  name?: string;
  restrictInSearch?: boolean;
  restrictInUserProfile?: boolean;
  subjectDeptIds?: number[];
  subjectTagIds?: number[];
  subjectUserIds?: string[];
  type?: string;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      id: 'id',
      name: 'name',
      restrictInSearch: 'restrictInSearch',
      restrictInUserProfile: 'restrictInUserProfile',
      subjectDeptIds: 'subjectDeptIds',
      subjectTagIds: 'subjectTagIds',
      subjectUserIds: 'subjectUserIds',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      name: 'string',
      restrictInSearch: 'boolean',
      restrictInUserProfile: 'boolean',
      subjectDeptIds: { 'type': 'array', 'itemType': 'number' },
      subjectTagIds: { 'type': 'array', 'itemType': 'number' },
      subjectUserIds: { 'type': 'array', 'itemType': 'string' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactRestrictSettingResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactRestrictSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateContactRestrictSettingResponseBody;
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
      body: UpdateContactRestrictSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDeptSettngTailFirstHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDeptSettngTailFirstRequest extends $tea.Model {
  enable?: boolean;
  static names(): { [key: string]: string } {
    return {
      enable: 'enable',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enable: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDeptSettngTailFirstResponse extends $tea.Model {
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

export class UpdateEmpAttrbuteVisibilitySettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttrbuteVisibilitySettingRequest extends $tea.Model {
  active?: boolean;
  description?: string;
  excludeDeptIds?: number[];
  excludeStaffIds?: string[];
  excludeTagIds?: number[];
  hideFields?: string[];
  id?: number;
  name?: string;
  objectDeptIds?: number[];
  objectStaffIds?: string[];
  objectTagIds?: number[];
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeStaffIds: 'excludeStaffIds',
      excludeTagIds: 'excludeTagIds',
      hideFields: 'hideFields',
      id: 'id',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectStaffIds: 'objectStaffIds',
      objectTagIds: 'objectTagIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      hideFields: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttrbuteVisibilitySettingResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttrbuteVisibilitySettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateEmpAttrbuteVisibilitySettingResponseBody;
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
      body: UpdateEmpAttrbuteVisibilitySettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttributeHideBySceneSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttributeHideBySceneSettingRequest extends $tea.Model {
  chatSubtitleConfig?: UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig;
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  hideFields?: string[];
  name?: string;
  objectDeptIds?: number[];
  objectTagIds?: number[];
  objectUserIds?: string[];
  profileSceneConfig?: UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig;
  searchSceneConfig?: UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig;
  static names(): { [key: string]: string } {
    return {
      chatSubtitleConfig: 'chatSubtitleConfig',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      hideFields: 'hideFields',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      objectUserIds: 'objectUserIds',
      profileSceneConfig: 'profileSceneConfig',
      searchSceneConfig: 'searchSceneConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatSubtitleConfig: UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig,
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      hideFields: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      objectUserIds: { 'type': 'array', 'itemType': 'string' },
      profileSceneConfig: UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig,
      searchSceneConfig: UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttributeHideBySceneSettingResponseBody extends $tea.Model {
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

export class UpdateEmpAttributeHideBySceneSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateEmpAttributeHideBySceneSettingResponseBody;
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
      body: UpdateEmpAttributeHideBySceneSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupRequest extends $tea.Model {
  groupName?: string;
  members?: UpdateManagementGroupRequestMembers[];
  resourceIds?: string[];
  scope?: UpdateManagementGroupRequestScope;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      members: 'members',
      resourceIds: 'resourceIds',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      members: { 'type': 'array', 'itemType': UpdateManagementGroupRequestMembers },
      resourceIds: { 'type': 'array', 'itemType': 'string' },
      scope: UpdateManagementGroupRequestScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupResponse extends $tea.Model {
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

export class UpdateSeniorSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSeniorSettingRequest extends $tea.Model {
  open?: boolean;
  permitDeptIds?: number[];
  permitStaffIds?: string[];
  permitTagIds?: number[];
  protectScenes?: string[];
  seniorStaffId?: string;
  static names(): { [key: string]: string } {
    return {
      open: 'open',
      permitDeptIds: 'permitDeptIds',
      permitStaffIds: 'permitStaffIds',
      permitTagIds: 'permitTagIds',
      protectScenes: 'protectScenes',
      seniorStaffId: 'seniorStaffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      open: 'boolean',
      permitDeptIds: { 'type': 'array', 'itemType': 'number' },
      permitStaffIds: { 'type': 'array', 'itemType': 'string' },
      permitTagIds: { 'type': 'array', 'itemType': 'number' },
      protectScenes: { 'type': 'array', 'itemType': 'string' },
      seniorStaffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSeniorSettingResponse extends $tea.Model {
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

export class UpdateUserOwnnessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserOwnnessRequest extends $tea.Model {
  deletedFlag?: number;
  endTime?: number;
  id?: number;
  ownenssType?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      deletedFlag: 'deletedFlag',
      endTime: 'endTime',
      id: 'id',
      ownenssType: 'ownenssType',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deletedFlag: 'number',
      endTime: 'number',
      id: 'number',
      ownenssType: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserOwnnessResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserOwnnessResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateUserOwnnessResponseBody;
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
      body: UpdateUserOwnnessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingRequestNodeListSceneConfig extends $tea.Model {
  active?: boolean;
  deptObjectIncludeEmp?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      deptObjectIncludeEmp: 'deptObjectIncludeEmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      deptObjectIncludeEmp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingRequestProfileSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactHideBySceneSettingRequestSearchSceneConfig extends $tea.Model {
  active?: boolean;
  deptObjectIncludeEmp?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      deptObjectIncludeEmp: 'deptObjectIncludeEmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      deptObjectIncludeEmp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchApproveUnionApplyRequestBody extends $tea.Model {
  branchCorpId?: string;
  linkDeptId?: number;
  unionRootName?: string;
  static names(): { [key: string]: string } {
    return {
      branchCorpId: 'branchCorpId',
      linkDeptId: 'linkDeptId',
      unionRootName: 'unionRootName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      branchCorpId: 'string',
      linkDeptId: 'number',
      unionRootName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupRequestMembers extends $tea.Model {
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

export class CreateManagementGroupRequestScope extends $tea.Model {
  deptIds?: number[];
  scopeType?: number;
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      scopeType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSecondaryManagementGroupRequestMembers extends $tea.Model {
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

export class CreateSecondaryManagementGroupRequestScope extends $tea.Model {
  deptIds?: number[];
  scopeType?: number;
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      scopeType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccountMappingResponseBodyResult extends $tea.Model {
  domain?: string;
  extension?: { [key: string]: string };
  outId?: string;
  outTenantId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      extension: 'extension',
      outId: 'outId',
      outTenantId: 'outTenantId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      outId: 'string',
      outTenantId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponseBodyResult extends $tea.Model {
  fieldCode?: string;
  fieldName?: string;
  fieldValue?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldValue: 'fieldValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfoAddressArea extends $tea.Model {
  region?: string;
  regionFullName?: string;
  static names(): { [key: string]: string } {
    return {
      region: 'region',
      regionFullName: 'regionFullName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      region: 'string',
      regionFullName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfoAddress extends $tea.Model {
  area?: GetCardInfoResponseBodyExtensionCardContactInfoAddressArea;
  detail?: string;
  static names(): { [key: string]: string } {
    return {
      area: 'area',
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      area: GetCardInfoResponseBodyExtensionCardContactInfoAddressArea,
      detail: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfoEmail extends $tea.Model {
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfoLink extends $tea.Model {
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfoTelephone extends $tea.Model {
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone extends $tea.Model {
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtensionCardContactInfo extends $tea.Model {
  address?: GetCardInfoResponseBodyExtensionCardContactInfoAddress[];
  email?: GetCardInfoResponseBodyExtensionCardContactInfoEmail[];
  link?: GetCardInfoResponseBodyExtensionCardContactInfoLink[];
  telephone?: GetCardInfoResponseBodyExtensionCardContactInfoTelephone[];
  workPhone?: GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone[];
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      email: 'email',
      link: 'link',
      telephone: 'telephone',
      workPhone: 'workPhone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: { 'type': 'array', 'itemType': GetCardInfoResponseBodyExtensionCardContactInfoAddress },
      email: { 'type': 'array', 'itemType': GetCardInfoResponseBodyExtensionCardContactInfoEmail },
      link: { 'type': 'array', 'itemType': GetCardInfoResponseBodyExtensionCardContactInfoLink },
      telephone: { 'type': 'array', 'itemType': GetCardInfoResponseBodyExtensionCardContactInfoTelephone },
      workPhone: { 'type': 'array', 'itemType': GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCardInfoResponseBodyExtension extends $tea.Model {
  cardContactInfo?: GetCardInfoResponseBodyExtensionCardContactInfo;
  corpId?: string;
  department?: string;
  orgAuthed?: boolean;
  orgLogo?: string;
  originCardUrl?: string;
  shareContent?: string;
  thumbnailUrl?: string;
  videoFileName?: string;
  videoTitle?: string;
  videoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      cardContactInfo: 'cardContactInfo',
      corpId: 'corpId',
      department: 'department',
      orgAuthed: 'orgAuthed',
      orgLogo: 'orgLogo',
      originCardUrl: 'originCardUrl',
      shareContent: 'shareContent',
      thumbnailUrl: 'thumbnailUrl',
      videoFileName: 'videoFileName',
      videoTitle: 'videoTitle',
      videoUrl: 'videoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardContactInfo: GetCardInfoResponseBodyExtensionCardContactInfo,
      corpId: 'string',
      department: 'string',
      orgAuthed: 'boolean',
      orgLogo: 'string',
      originCardUrl: 'string',
      shareContent: 'string',
      thumbnailUrl: 'string',
      videoFileName: 'string',
      videoTitle: 'string',
      videoUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactHideBySceneSettingResponseBodyNodeListSceneConfig extends $tea.Model {
  active?: boolean;
  deptObjectIncludeEmp?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      deptObjectIncludeEmp: 'deptObjectIncludeEmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      deptObjectIncludeEmp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactHideBySceneSettingResponseBodyProfileSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContactHideBySceneSettingResponseBodySearchSceneConfig extends $tea.Model {
  active?: boolean;
  deptObjectIncludeEmp?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      deptObjectIncludeEmp: 'deptObjectIncludeEmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      deptObjectIncludeEmp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCardHolderListResponseBodyList extends $tea.Model {
  avatarUrl?: string;
  cardAcceptStatus?: number;
  cardAcceptTimeLong?: number;
  cardId?: string;
  cardSource?: number;
  extension?: { [key: string]: any };
  industryName?: string;
  introduce?: string;
  name?: string;
  orgName?: string;
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      cardAcceptStatus: 'cardAcceptStatus',
      cardAcceptTimeLong: 'cardAcceptTimeLong',
      cardId: 'cardId',
      cardSource: 'cardSource',
      extension: 'extension',
      industryName: 'industryName',
      introduce: 'introduce',
      name: 'name',
      orgName: 'orgName',
      templateId: 'templateId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      cardAcceptStatus: 'number',
      cardAcceptTimeLong: 'number',
      cardId: 'string',
      cardSource: 'number',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      industryName: 'string',
      introduce: 'string',
      name: 'string',
      orgName: 'string',
      templateId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope extends $tea.Model {
  deptIds?: number[];
  includeMemberDepts?: boolean;
  includeSelfManageDepts?: boolean;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      includeMemberDepts: 'includeMemberDepts',
      includeSelfManageDepts: 'includeSelfManageDepts',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      includeMemberDepts: 'boolean',
      includeSelfManageDepts: 'boolean',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponseBodyListOpenActionOpenCondition extends $tea.Model {
  openContactScope?: ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope;
  static names(): { [key: string]: string } {
    return {
      openContactScope: 'openContactScope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openContactScope: ListBasicRoleInPageResponseBodyListOpenActionOpenConditionOpenContactScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponseBodyListOpenAction extends $tea.Model {
  actionIds?: string[];
  openCondition?: ListBasicRoleInPageResponseBodyListOpenActionOpenCondition;
  static names(): { [key: string]: string } {
    return {
      actionIds: 'actionIds',
      openCondition: 'openCondition',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionIds: { 'type': 'array', 'itemType': 'string' },
      openCondition: ListBasicRoleInPageResponseBodyListOpenActionOpenCondition,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponseBodyListOpenMembers extends $tea.Model {
  belongCorpId?: string;
  memberId?: string;
  memberType?: string;
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      belongCorpId: 'belongCorpId',
      memberId: 'memberId',
      memberType: 'memberType',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongCorpId: 'string',
      memberId: 'string',
      memberType: 'string',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListBasicRoleInPageResponseBodyList extends $tea.Model {
  openAction?: ListBasicRoleInPageResponseBodyListOpenAction;
  openMembers?: ListBasicRoleInPageResponseBodyListOpenMembers[];
  openResources?: string[];
  openRoleId?: string;
  openRoleName?: string;
  static names(): { [key: string]: string } {
    return {
      openAction: 'openAction',
      openMembers: 'openMembers',
      openResources: 'openResources',
      openRoleId: 'openRoleId',
      openRoleName: 'openRoleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openAction: ListBasicRoleInPageResponseBodyListOpenAction,
      openMembers: { 'type': 'array', 'itemType': ListBasicRoleInPageResponseBodyListOpenMembers },
      openResources: { 'type': 'array', 'itemType': 'string' },
      openRoleId: 'string',
      openRoleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsResponseBodyList extends $tea.Model {
  active?: boolean;
  description?: string;
  excludeDeptIds?: number[];
  excludeStaffIds?: string[];
  excludeTagIds?: number[];
  id?: number;
  name?: string;
  objectDeptIds?: number[];
  objectStaffIds?: string[];
  objectTagIds?: number[];
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeStaffIds: 'excludeStaffIds',
      excludeTagIds: 'excludeTagIds',
      id: 'id',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectStaffIds: 'objectStaffIds',
      objectTagIds: 'objectTagIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      id: 'number',
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactRestrictSettingResponseBodyList extends $tea.Model {
  active?: boolean;
  description?: string;
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  excludeUserIds?: string[];
  id?: number;
  name?: string;
  restrictInSearch?: boolean;
  restrictInUserProfile?: boolean;
  subjectDeptIds?: number[];
  subjectTagIds?: number[];
  subjectUserIds?: string[];
  type?: string;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      excludeUserIds: 'excludeUserIds',
      id: 'id',
      name: 'name',
      restrictInSearch: 'restrictInSearch',
      restrictInUserProfile: 'restrictInUserProfile',
      subjectDeptIds: 'subjectDeptIds',
      subjectTagIds: 'subjectTagIds',
      subjectUserIds: 'subjectUserIds',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeUserIds: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      name: 'string',
      restrictInSearch: 'boolean',
      restrictInUserProfile: 'boolean',
      subjectDeptIds: { 'type': 'array', 'itemType': 'number' },
      subjectTagIds: { 'type': 'array', 'itemType': 'number' },
      subjectUserIds: { 'type': 'array', 'itemType': 'string' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityResponseBodyList extends $tea.Model {
  active?: boolean;
  description?: string;
  excludeDeptIds?: number[];
  excludeStaffIds?: string[];
  excludeTagIds?: number[];
  gmtCreate?: string;
  gmtModified?: string;
  hideFields?: string[];
  id?: number;
  name?: string;
  objectDeptIds?: number[];
  objectStaffIds?: string[];
  objectTagIds?: number[];
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      description: 'description',
      excludeDeptIds: 'excludeDeptIds',
      excludeStaffIds: 'excludeStaffIds',
      excludeTagIds: 'excludeTagIds',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      hideFields: 'hideFields',
      id: 'id',
      name: 'name',
      objectDeptIds: 'objectDeptIds',
      objectStaffIds: 'objectStaffIds',
      objectTagIds: 'objectTagIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      description: 'string',
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      gmtCreate: 'string',
      gmtModified: 'string',
      hideFields: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      name: 'string',
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpLeaveRecordsResponseBodyRecords extends $tea.Model {
  leaveReason?: string;
  leaveTime?: string;
  mobile?: string;
  name?: string;
  stateCode?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      leaveReason: 'leaveReason',
      leaveTime: 'leaveTime',
      mobile: 'mobile',
      name: 'name',
      stateCode: 'stateCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      leaveReason: 'string',
      leaveTime: 'string',
      mobile: 'string',
      name: 'string',
      stateCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBodyGroupsMembers extends $tea.Model {
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

export class ListManagementGroupsResponseBodyGroupsScope extends $tea.Model {
  deptIds?: number[];
  scopeType?: number;
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      scopeType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBodyGroups extends $tea.Model {
  groupId?: string;
  groupName?: string;
  members?: ListManagementGroupsResponseBodyGroupsMembers[];
  resourceIds?: string[];
  scope?: ListManagementGroupsResponseBodyGroupsScope;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      members: 'members',
      resourceIds: 'resourceIds',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
      groupName: 'string',
      members: { 'type': 'array', 'itemType': ListManagementGroupsResponseBodyGroupsMembers },
      resourceIds: { 'type': 'array', 'itemType': 'string' },
      scope: ListManagementGroupsResponseBodyGroupsScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOwnedOrgByStaffIdResponseBodyOrgList extends $tea.Model {
  corpId?: string;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsResponseBodySeniorWhiteList extends $tea.Model {
  id?: string;
  name?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpStatisticDataResponseBodyResult extends $tea.Model {
  cardBeReceivedTotalCnt?: number;
  cardReceiveTotalCnt?: number;
  cardTotalBeVisitedCnt?: number;
  dataDate?: string;
  dingTotalShareCnt?: number;
  totalSendCnt?: number;
  wechatTotalShareCnt?: number;
  static names(): { [key: string]: string } {
    return {
      cardBeReceivedTotalCnt: 'cardBeReceivedTotalCnt',
      cardReceiveTotalCnt: 'cardReceiveTotalCnt',
      cardTotalBeVisitedCnt: 'cardTotalBeVisitedCnt',
      dataDate: 'dataDate',
      dingTotalShareCnt: 'dingTotalShareCnt',
      totalSendCnt: 'totalSendCnt',
      wechatTotalShareCnt: 'wechatTotalShareCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBeReceivedTotalCnt: 'number',
      cardReceiveTotalCnt: 'number',
      cardTotalBeVisitedCnt: 'number',
      dataDate: 'string',
      dingTotalShareCnt: 'number',
      totalSendCnt: 'number',
      wechatTotalShareCnt: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpUserStatisticResponseBodyList extends $tea.Model {
  avatarUrl?: string;
  name?: string;
  receiveCnt?: number;
  sendCnt?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      name: 'name',
      receiveCnt: 'receiveCnt',
      sendCnt: 'sendCnt',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      name: 'string',
      receiveCnt: 'number',
      sendCnt: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryResourceManagementMembersResponseBodyMembers extends $tea.Model {
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

export class UpdateBranchAttributesInCooperateRequestBody extends $tea.Model {
  branchCorpId?: string;
  linkDeptId?: number;
  unionRootName?: string;
  static names(): { [key: string]: string } {
    return {
      branchCorpId: 'branchCorpId',
      linkDeptId: 'linkDeptId',
      unionRootName: 'unionRootName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      branchCorpId: 'string',
      linkDeptId: 'number',
      unionRootName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBranchVisibleSettingInCooperateRequestBody extends $tea.Model {
  branchCorpId?: string;
  open?: boolean;
  type?: number;
  visibleBranchCorpIds?: string[];
  visibleDeptIds?: number[];
  static names(): { [key: string]: string } {
    return {
      branchCorpId: 'branchCorpId',
      open: 'open',
      type: 'type',
      visibleBranchCorpIds: 'visibleBranchCorpIds',
      visibleDeptIds: 'visibleDeptIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      branchCorpId: 'string',
      open: 'boolean',
      type: 'number',
      visibleBranchCorpIds: { 'type': 'array', 'itemType': 'string' },
      visibleDeptIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideBySceneSettingRequestNodeListSceneConfig extends $tea.Model {
  active?: boolean;
  deptObjectIncludeEmp?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      deptObjectIncludeEmp: 'deptObjectIncludeEmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      deptObjectIncludeEmp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideBySceneSettingRequestProfileSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideBySceneSettingRequestSearchSceneConfig extends $tea.Model {
  active?: boolean;
  deptObjectIncludeEmp?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      deptObjectIncludeEmp: 'deptObjectIncludeEmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      deptObjectIncludeEmp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig extends $tea.Model {
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupRequestMembers extends $tea.Model {
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

export class UpdateManagementGroupRequestScope extends $tea.Model {
  deptIds?: number[];
  scopeType?: number;
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      scopeType: 'number',
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


  async addAccountMappingWithOptions(request: AddAccountMappingRequest, headers: AddAccountMappingHeaders, runtime: $Util.RuntimeOptions): Promise<AddAccountMappingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.domain)) {
      body["domain"] = request.domain;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.outId)) {
      body["outId"] = request.outId;
    }

    if (!Util.isUnset(request.outTenantId)) {
      body["outTenantId"] = request.outTenantId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

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
      action: "AddAccountMapping",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/accountMappings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddAccountMappingResponse>(await this.execute(params, req, runtime), new AddAccountMappingResponse({}));
  }

  async addAccountMapping(request: AddAccountMappingRequest): Promise<AddAccountMappingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAccountMappingHeaders({ });
    return await this.addAccountMappingWithOptions(request, headers, runtime);
  }

  async addContactHideBySceneSettingWithOptions(request: AddContactHideBySceneSettingRequest, headers: AddContactHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<AddContactHideBySceneSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.excludeUserIds)) {
      body["excludeUserIds"] = request.excludeUserIds;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.nodeListSceneConfig)) {
      body["nodeListSceneConfig"] = request.nodeListSceneConfig;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

    if (!Util.isUnset(request.objectUserIds)) {
      body["objectUserIds"] = request.objectUserIds;
    }

    if (!Util.isUnset(request.profileSceneConfig)) {
      body["profileSceneConfig"] = request.profileSceneConfig;
    }

    if (!Util.isUnset(request.searchSceneConfig)) {
      body["searchSceneConfig"] = request.searchSceneConfig;
    }

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
      action: "AddContactHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/organizations/hides/settings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddContactHideBySceneSettingResponse>(await this.execute(params, req, runtime), new AddContactHideBySceneSettingResponse({}));
  }

  async addContactHideBySceneSetting(request: AddContactHideBySceneSettingRequest): Promise<AddContactHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddContactHideBySceneSettingHeaders({ });
    return await this.addContactHideBySceneSettingWithOptions(request, headers, runtime);
  }

  async addEmpAttributeHideBySceneSettingWithOptions(request: AddEmpAttributeHideBySceneSettingRequest, headers: AddEmpAttributeHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<AddEmpAttributeHideBySceneSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatSubtitleConfig)) {
      body["chatSubtitleConfig"] = request.chatSubtitleConfig;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.excludeUserIds)) {
      body["excludeUserIds"] = request.excludeUserIds;
    }

    if (!Util.isUnset(request.hideFields)) {
      body["hideFields"] = request.hideFields;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

    if (!Util.isUnset(request.objectUserIds)) {
      body["objectUserIds"] = request.objectUserIds;
    }

    if (!Util.isUnset(request.profileSceneConfig)) {
      body["profileSceneConfig"] = request.profileSceneConfig;
    }

    if (!Util.isUnset(request.searchSceneConfig)) {
      body["searchSceneConfig"] = request.searchSceneConfig;
    }

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
      action: "AddEmpAttributeHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/empAttributes/hides/settings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddEmpAttributeHideBySceneSettingResponse>(await this.execute(params, req, runtime), new AddEmpAttributeHideBySceneSettingResponse({}));
  }

  async addEmpAttributeHideBySceneSetting(request: AddEmpAttributeHideBySceneSettingRequest): Promise<AddEmpAttributeHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddEmpAttributeHideBySceneSettingHeaders({ });
    return await this.addEmpAttributeHideBySceneSettingWithOptions(request, headers, runtime);
  }

  async annualCertificationAuditWithOptions(request: AnnualCertificationAuditRequest, headers: AnnualCertificationAuditHeaders, runtime: $Util.RuntimeOptions): Promise<AnnualCertificationAuditResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.applicantMobile)) {
      body["applicantMobile"] = request.applicantMobile;
    }

    if (!Util.isUnset(request.applicantName)) {
      body["applicantName"] = request.applicantName;
    }

    if (!Util.isUnset(request.applicationLetter)) {
      body["applicationLetter"] = request.applicationLetter;
    }

    if (!Util.isUnset(request.authStatus)) {
      body["authStatus"] = request.authStatus;
    }

    if (!Util.isUnset(request.certificateType)) {
      body["certificateType"] = request.certificateType;
    }

    if (!Util.isUnset(request.corpName)) {
      body["corpName"] = request.corpName;
    }

    if (!Util.isUnset(request.depositaryBank)) {
      body["depositaryBank"] = request.depositaryBank;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.legalPerson)) {
      body["legalPerson"] = request.legalPerson;
    }

    if (!Util.isUnset(request.licenseNumber)) {
      body["licenseNumber"] = request.licenseNumber;
    }

    if (!Util.isUnset(request.licenseUrl)) {
      body["licenseUrl"] = request.licenseUrl;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.publicAccount)) {
      body["publicAccount"] = request.publicAccount;
    }

    if (!Util.isUnset(request.reasonCode)) {
      body["reasonCode"] = request.reasonCode;
    }

    if (!Util.isUnset(request.reasonMsg)) {
      body["reasonMsg"] = request.reasonMsg;
    }

    if (!Util.isUnset(request.tag)) {
      body["tag"] = request.tag;
    }

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
      action: "AnnualCertificationAudit",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/organizations/authorities/audit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AnnualCertificationAuditResponse>(await this.execute(params, req, runtime), new AnnualCertificationAuditResponse({}));
  }

  async annualCertificationAudit(request: AnnualCertificationAuditRequest): Promise<AnnualCertificationAuditResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AnnualCertificationAuditHeaders({ });
    return await this.annualCertificationAuditWithOptions(request, headers, runtime);
  }

  async batchApproveUnionApplyWithOptions(request: BatchApproveUnionApplyRequest, headers: BatchApproveUnionApplyHeaders, runtime: $Util.RuntimeOptions): Promise<BatchApproveUnionApplyResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "BatchApproveUnionApply",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cooperateCorps/unionApplications/approve`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchApproveUnionApplyResponse>(await this.execute(params, req, runtime), new BatchApproveUnionApplyResponse({}));
  }

  async batchApproveUnionApply(request: BatchApproveUnionApplyRequest): Promise<BatchApproveUnionApplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchApproveUnionApplyHeaders({ });
    return await this.batchApproveUnionApplyWithOptions(request, headers, runtime);
  }

  async changeMainAdminWithOptions(request: ChangeMainAdminRequest, headers: ChangeMainAdminHeaders, runtime: $Util.RuntimeOptions): Promise<ChangeMainAdminResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.effectCorpId)) {
      body["effectCorpId"] = request.effectCorpId;
    }

    if (!Util.isUnset(request.sourceUserId)) {
      body["sourceUserId"] = request.sourceUserId;
    }

    if (!Util.isUnset(request.targetUserId)) {
      body["targetUserId"] = request.targetUserId;
    }

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
      action: "ChangeMainAdmin",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/mainAdministrators/change`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<ChangeMainAdminResponse>(await this.execute(params, req, runtime), new ChangeMainAdminResponse({}));
  }

  async changeMainAdmin(request: ChangeMainAdminRequest): Promise<ChangeMainAdminResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChangeMainAdminHeaders({ });
    return await this.changeMainAdminWithOptions(request, headers, runtime);
  }

  async createCooperateOrgWithOptions(request: CreateCooperateOrgRequest, headers: CreateCooperateOrgHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCooperateOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.industryCode)) {
      body["industryCode"] = request.industryCode;
    }

    if (!Util.isUnset(request.logoMediaId)) {
      body["logoMediaId"] = request.logoMediaId;
    }

    if (!Util.isUnset(request.orgName)) {
      body["orgName"] = request.orgName;
    }

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
      action: "CreateCooperateOrg",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cooperateCorps`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateCooperateOrgResponse>(await this.execute(params, req, runtime), new CreateCooperateOrgResponse({}));
  }

  async createCooperateOrg(request: CreateCooperateOrgRequest): Promise<CreateCooperateOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCooperateOrgHeaders({ });
    return await this.createCooperateOrgWithOptions(request, headers, runtime);
  }

  async createManagementGroupWithOptions(request: CreateManagementGroupRequest, headers: CreateManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateManagementGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.resourceIds)) {
      body["resourceIds"] = request.resourceIds;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

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
      action: "CreateManagementGroup",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/managementGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateManagementGroupResponse>(await this.execute(params, req, runtime), new CreateManagementGroupResponse({}));
  }

  async createManagementGroup(request: CreateManagementGroupRequest): Promise<CreateManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateManagementGroupHeaders({ });
    return await this.createManagementGroupWithOptions(request, headers, runtime);
  }

  async createSecondaryManagementGroupWithOptions(request: CreateSecondaryManagementGroupRequest, headers: CreateSecondaryManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSecondaryManagementGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.resourceIds)) {
      body["resourceIds"] = request.resourceIds;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

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
      action: "CreateSecondaryManagementGroup",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/secondaryAdministrators/managementGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSecondaryManagementGroupResponse>(await this.execute(params, req, runtime), new CreateSecondaryManagementGroupResponse({}));
  }

  async createSecondaryManagementGroup(request: CreateSecondaryManagementGroupRequest): Promise<CreateSecondaryManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSecondaryManagementGroupHeaders({ });
    return await this.createSecondaryManagementGroupWithOptions(request, headers, runtime);
  }

  async delAccountMappingWithOptions(request: DelAccountMappingRequest, headers: DelAccountMappingHeaders, runtime: $Util.RuntimeOptions): Promise<DelAccountMappingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.domain)) {
      query["domain"] = request.domain;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

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
      action: "DelAccountMapping",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/accountMappings`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DelAccountMappingResponse>(await this.execute(params, req, runtime), new DelAccountMappingResponse({}));
  }

  async delAccountMapping(request: DelAccountMappingRequest): Promise<DelAccountMappingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DelAccountMappingHeaders({ });
    return await this.delAccountMappingWithOptions(request, headers, runtime);
  }

  async deleteContactHideBySceneSettingWithOptions(settingId: string, headers: DeleteContactHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteContactHideBySceneSettingResponse> {
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
      action: "DeleteContactHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/organizations/hides/settings/${settingId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteContactHideBySceneSettingResponse>(await this.execute(params, req, runtime), new DeleteContactHideBySceneSettingResponse({}));
  }

  async deleteContactHideBySceneSetting(settingId: string): Promise<DeleteContactHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteContactHideBySceneSettingHeaders({ });
    return await this.deleteContactHideBySceneSettingWithOptions(settingId, headers, runtime);
  }

  async deleteContactHideSettingWithOptions(settingId: string, headers: DeleteContactHideSettingHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteContactHideSettingResponse> {
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
      action: "DeleteContactHideSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/contactHideSettings/${settingId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteContactHideSettingResponse>(await this.execute(params, req, runtime), new DeleteContactHideSettingResponse({}));
  }

  async deleteContactHideSetting(settingId: string): Promise<DeleteContactHideSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteContactHideSettingHeaders({ });
    return await this.deleteContactHideSettingWithOptions(settingId, headers, runtime);
  }

  async deleteContactRestrictSettingWithOptions(settingId: string, headers: DeleteContactRestrictSettingHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteContactRestrictSettingResponse> {
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
      action: "DeleteContactRestrictSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/restrictions/settings/${settingId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteContactRestrictSettingResponse>(await this.execute(params, req, runtime), new DeleteContactRestrictSettingResponse({}));
  }

  async deleteContactRestrictSetting(settingId: string): Promise<DeleteContactRestrictSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteContactRestrictSettingHeaders({ });
    return await this.deleteContactRestrictSettingWithOptions(settingId, headers, runtime);
  }

  async deleteEmpAttributeHideBySceneSettingWithOptions(settingId: string, headers: DeleteEmpAttributeHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteEmpAttributeHideBySceneSettingResponse> {
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
      action: "DeleteEmpAttributeHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/empAttributes/hides/settings/${settingId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteEmpAttributeHideBySceneSettingResponse>(await this.execute(params, req, runtime), new DeleteEmpAttributeHideBySceneSettingResponse({}));
  }

  async deleteEmpAttributeHideBySceneSetting(settingId: string): Promise<DeleteEmpAttributeHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteEmpAttributeHideBySceneSettingHeaders({ });
    return await this.deleteEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
  }

  async deleteEmpAttributeVisibilityWithOptions(settingId: string, headers: DeleteEmpAttributeVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteEmpAttributeVisibilityResponse> {
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
      action: "DeleteEmpAttributeVisibility",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/staffAttributes/visibilitySettings/${settingId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteEmpAttributeVisibilityResponse>(await this.execute(params, req, runtime), new DeleteEmpAttributeVisibilityResponse({}));
  }

  async deleteEmpAttributeVisibility(settingId: string): Promise<DeleteEmpAttributeVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteEmpAttributeVisibilityHeaders({ });
    return await this.deleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
  }

  async deleteManagementGroupWithOptions(groupId: string, headers: DeleteManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteManagementGroupResponse> {
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
      action: "DeleteManagementGroup",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/managementGroups/${groupId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteManagementGroupResponse>(await this.execute(params, req, runtime), new DeleteManagementGroupResponse({}));
  }

  async deleteManagementGroup(groupId: string): Promise<DeleteManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteManagementGroupHeaders({ });
    return await this.deleteManagementGroupWithOptions(groupId, headers, runtime);
  }

  async getAccountMappingWithOptions(request: GetAccountMappingRequest, headers: GetAccountMappingHeaders, runtime: $Util.RuntimeOptions): Promise<GetAccountMappingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.domain)) {
      query["domain"] = request.domain;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

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
      action: "GetAccountMapping",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/accountMappings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAccountMappingResponse>(await this.execute(params, req, runtime), new GetAccountMappingResponse({}));
  }

  async getAccountMapping(request: GetAccountMappingRequest): Promise<GetAccountMappingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAccountMappingHeaders({ });
    return await this.getAccountMappingWithOptions(request, headers, runtime);
  }

  async getApplyInviteInfoWithOptions(request: GetApplyInviteInfoRequest, headers: GetApplyInviteInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplyInviteInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.inviterUserId)) {
      query["inviterUserId"] = request.inviterUserId;
    }

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
      action: "GetApplyInviteInfo",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/invites/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetApplyInviteInfoResponse>(await this.execute(params, req, runtime), new GetApplyInviteInfoResponse({}));
  }

  async getApplyInviteInfo(request: GetApplyInviteInfoRequest): Promise<GetApplyInviteInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplyInviteInfoHeaders({ });
    return await this.getApplyInviteInfoWithOptions(request, headers, runtime);
  }

  async getBranchAuthDataWithOptions(request: GetBranchAuthDataRequest, headers: GetBranchAuthDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetBranchAuthDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.branchCorpId)) {
      query["branchCorpId"] = request.branchCorpId;
    }

    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.body)) {
      body["body"] = request.body;
    }

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
      action: "GetBranchAuthData",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/branchAuthDatas/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetBranchAuthDataResponse>(await this.execute(params, req, runtime), new GetBranchAuthDataResponse({}));
  }

  async getBranchAuthData(request: GetBranchAuthDataRequest): Promise<GetBranchAuthDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBranchAuthDataHeaders({ });
    return await this.getBranchAuthDataWithOptions(request, headers, runtime);
  }

  async getCardInUserHolderWithOptions(cardId: string, headers: GetCardInUserHolderHeaders, runtime: $Util.RuntimeOptions): Promise<GetCardInUserHolderResponse> {
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
      action: "GetCardInUserHolder",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/holders/infos/${cardId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCardInUserHolderResponse>(await this.execute(params, req, runtime), new GetCardInUserHolderResponse({}));
  }

  async getCardInUserHolder(cardId: string): Promise<GetCardInUserHolderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCardInUserHolderHeaders({ });
    return await this.getCardInUserHolderWithOptions(cardId, headers, runtime);
  }

  async getCardInfoWithOptions(cardId: string, headers: GetCardInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetCardInfoResponse> {
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
      action: "GetCardInfo",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/infos/${cardId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCardInfoResponse>(await this.execute(params, req, runtime), new GetCardInfoResponse({}));
  }

  async getCardInfo(cardId: string): Promise<GetCardInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCardInfoHeaders({ });
    return await this.getCardInfoWithOptions(cardId, headers, runtime);
  }

  async getContactHideBySceneSettingWithOptions(settingId: string, headers: GetContactHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<GetContactHideBySceneSettingResponse> {
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
      action: "GetContactHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/organizations/hides/settings/${settingId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetContactHideBySceneSettingResponse>(await this.execute(params, req, runtime), new GetContactHideBySceneSettingResponse({}));
  }

  async getContactHideBySceneSetting(settingId: string): Promise<GetContactHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetContactHideBySceneSettingHeaders({ });
    return await this.getContactHideBySceneSettingWithOptions(settingId, headers, runtime);
  }

  async getCooperateOrgInviteInfoWithOptions(cooperateCorpId: string, headers: GetCooperateOrgInviteInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetCooperateOrgInviteInfoResponse> {
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
      action: "GetCooperateOrgInviteInfo",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cooperateCorps/${cooperateCorpId}/inviteInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCooperateOrgInviteInfoResponse>(await this.execute(params, req, runtime), new GetCooperateOrgInviteInfoResponse({}));
  }

  async getCooperateOrgInviteInfo(cooperateCorpId: string): Promise<GetCooperateOrgInviteInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCooperateOrgInviteInfoHeaders({ });
    return await this.getCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
  }

  async getCorpCardStyleListWithOptions(headers: GetCorpCardStyleListHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpCardStyleListResponse> {
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
      action: "GetCorpCardStyleList",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/styles/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCorpCardStyleListResponse>(await this.execute(params, req, runtime), new GetCorpCardStyleListResponse({}));
  }

  async getCorpCardStyleList(): Promise<GetCorpCardStyleListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpCardStyleListHeaders({ });
    return await this.getCorpCardStyleListWithOptions(headers, runtime);
  }

  async getDingIdByMigrationDingIdWithOptions(request: GetDingIdByMigrationDingIdRequest, headers: GetDingIdByMigrationDingIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingIdByMigrationDingIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.migrationDingId)) {
      query["migrationDingId"] = request.migrationDingId;
    }

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
      action: "GetDingIdByMigrationDingId",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccount/getDingIdByMigrationDingIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDingIdByMigrationDingIdResponse>(await this.execute(params, req, runtime), new GetDingIdByMigrationDingIdResponse({}));
  }

  async getDingIdByMigrationDingId(request: GetDingIdByMigrationDingIdRequest): Promise<GetDingIdByMigrationDingIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingIdByMigrationDingIdHeaders({ });
    return await this.getDingIdByMigrationDingIdWithOptions(request, headers, runtime);
  }

  async getEmpAttributeHideBySceneSettingWithOptions(settingId: string, headers: GetEmpAttributeHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmpAttributeHideBySceneSettingResponse> {
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
      action: "GetEmpAttributeHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/empAttributes/hides/settings/${settingId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEmpAttributeHideBySceneSettingResponse>(await this.execute(params, req, runtime), new GetEmpAttributeHideBySceneSettingResponse({}));
  }

  async getEmpAttributeHideBySceneSetting(settingId: string): Promise<GetEmpAttributeHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmpAttributeHideBySceneSettingHeaders({ });
    return await this.getEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
  }

  async getLatestDingIndexWithOptions(headers: GetLatestDingIndexHeaders, runtime: $Util.RuntimeOptions): Promise<GetLatestDingIndexResponse> {
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
      action: "GetLatestDingIndex",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/dingIndexs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetLatestDingIndexResponse>(await this.execute(params, req, runtime), new GetLatestDingIndexResponse({}));
  }

  async getLatestDingIndex(): Promise<GetLatestDingIndexResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLatestDingIndexHeaders({ });
    return await this.getLatestDingIndexWithOptions(headers, runtime);
  }

  async getMigrationDingIdByDingIdWithOptions(request: GetMigrationDingIdByDingIdRequest, headers: GetMigrationDingIdByDingIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetMigrationDingIdByDingIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingId)) {
      query["dingId"] = request.dingId;
    }

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
      action: "GetMigrationDingIdByDingId",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccount/getMigrationDingIdByDingIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMigrationDingIdByDingIdResponse>(await this.execute(params, req, runtime), new GetMigrationDingIdByDingIdResponse({}));
  }

  async getMigrationDingIdByDingId(request: GetMigrationDingIdByDingIdRequest): Promise<GetMigrationDingIdByDingIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMigrationDingIdByDingIdHeaders({ });
    return await this.getMigrationDingIdByDingIdWithOptions(request, headers, runtime);
  }

  async getMigrationUnionIdByUnionIdWithOptions(request: GetMigrationUnionIdByUnionIdRequest, headers: GetMigrationUnionIdByUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetMigrationUnionIdByUnionIdResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetMigrationUnionIdByUnionId",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMigrationUnionIdByUnionIdResponse>(await this.execute(params, req, runtime), new GetMigrationUnionIdByUnionIdResponse({}));
  }

  async getMigrationUnionIdByUnionId(request: GetMigrationUnionIdByUnionIdRequest): Promise<GetMigrationUnionIdByUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMigrationUnionIdByUnionIdHeaders({ });
    return await this.getMigrationUnionIdByUnionIdWithOptions(request, headers, runtime);
  }

  async getOrgAuthInfoWithOptions(request: GetOrgAuthInfoRequest, headers: GetOrgAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetOrgAuthInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetCorpId)) {
      query["targetCorpId"] = request.targetCorpId;
    }

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
      action: "GetOrgAuthInfo",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/organizations/authInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOrgAuthInfoResponse>(await this.execute(params, req, runtime), new GetOrgAuthInfoResponse({}));
  }

  async getOrgAuthInfo(request: GetOrgAuthInfoRequest): Promise<GetOrgAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOrgAuthInfoHeaders({ });
    return await this.getOrgAuthInfoWithOptions(request, headers, runtime);
  }

  async getTranslateFileJobResultWithOptions(request: GetTranslateFileJobResultRequest, headers: GetTranslateFileJobResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetTranslateFileJobResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobId)) {
      query["jobId"] = request.jobId;
    }

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
      action: "GetTranslateFileJobResult",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/files/translateResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTranslateFileJobResultResponse>(await this.execute(params, req, runtime), new GetTranslateFileJobResultResponse({}));
  }

  async getTranslateFileJobResult(request: GetTranslateFileJobResultRequest): Promise<GetTranslateFileJobResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTranslateFileJobResultHeaders({ });
    return await this.getTranslateFileJobResultWithOptions(request, headers, runtime);
  }

  async getUnionIdByMigrationUnionIdWithOptions(request: GetUnionIdByMigrationUnionIdRequest, headers: GetUnionIdByMigrationUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetUnionIdByMigrationUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.migrationUnionId)) {
      query["migrationUnionId"] = request.migrationUnionId;
    }

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
      action: "GetUnionIdByMigrationUnionId",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUnionIdByMigrationUnionIdResponse>(await this.execute(params, req, runtime), new GetUnionIdByMigrationUnionIdResponse({}));
  }

  async getUnionIdByMigrationUnionId(request: GetUnionIdByMigrationUnionIdRequest): Promise<GetUnionIdByMigrationUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUnionIdByMigrationUnionIdHeaders({ });
    return await this.getUnionIdByMigrationUnionIdWithOptions(request, headers, runtime);
  }

  async getUserWithOptions(unionId: string, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
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
      action: "GetUser",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/users/${unionId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserResponse>(await this.execute(params, req, runtime), new GetUserResponse({}));
  }

  async getUser(unionId: string): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(unionId, headers, runtime);
  }

  async getUserCardHolderListWithOptions(request: GetUserCardHolderListRequest, headers: GetUserCardHolderListHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserCardHolderListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetUserCardHolderList",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/holders/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserCardHolderListResponse>(await this.execute(params, req, runtime), new GetUserCardHolderListResponse({}));
  }

  async getUserCardHolderList(request: GetUserCardHolderListRequest): Promise<GetUserCardHolderListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserCardHolderListHeaders({ });
    return await this.getUserCardHolderListWithOptions(request, headers, runtime);
  }

  async isFriendWithOptions(request: IsFriendRequest, headers: IsFriendHeaders, runtime: $Util.RuntimeOptions): Promise<IsFriendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mobileNo)) {
      body["mobileNo"] = request.mobileNo;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

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
      action: "IsFriend",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/relationships/friends/judge`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IsFriendResponse>(await this.execute(params, req, runtime), new IsFriendResponse({}));
  }

  async isFriend(request: IsFriendRequest): Promise<IsFriendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IsFriendHeaders({ });
    return await this.isFriendWithOptions(request, headers, runtime);
  }

  async isvCardEventPushWithOptions(request: IsvCardEventPushRequest, headers: IsvCardEventPushHeaders, runtime: $Util.RuntimeOptions): Promise<IsvCardEventPushResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvCardId)) {
      query["isvCardId"] = request.isvCardId;
    }

    if (!Util.isUnset(request.isvToken)) {
      query["isvToken"] = request.isvToken;
    }

    if (!Util.isUnset(request.isvUid)) {
      query["isvUid"] = request.isvUid;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.eventParams)) {
      body["eventParams"] = request.eventParams;
    }

    if (!Util.isUnset(request.eventType)) {
      body["eventType"] = request.eventType;
    }

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
      action: "IsvCardEventPush",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/events/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IsvCardEventPushResponse>(await this.execute(params, req, runtime), new IsvCardEventPushResponse({}));
  }

  async isvCardEventPush(request: IsvCardEventPushRequest): Promise<IsvCardEventPushResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IsvCardEventPushHeaders({ });
    return await this.isvCardEventPushWithOptions(request, headers, runtime);
  }

  async listBasicRoleInPageWithOptions(request: ListBasicRoleInPageRequest, headers: ListBasicRoleInPageHeaders, runtime: $Util.RuntimeOptions): Promise<ListBasicRoleInPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      query["agentId"] = request.agentId;
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListBasicRoleInPage",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/rbac/administrativeGroups/baseInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListBasicRoleInPageResponse>(await this.execute(params, req, runtime), new ListBasicRoleInPageResponse({}));
  }

  async listBasicRoleInPage(request: ListBasicRoleInPageRequest): Promise<ListBasicRoleInPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListBasicRoleInPageHeaders({ });
    return await this.listBasicRoleInPageWithOptions(request, headers, runtime);
  }

  async listContactHideSettingsWithOptions(request: ListContactHideSettingsRequest, headers: ListContactHideSettingsHeaders, runtime: $Util.RuntimeOptions): Promise<ListContactHideSettingsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListContactHideSettings",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/contactHideSettings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListContactHideSettingsResponse>(await this.execute(params, req, runtime), new ListContactHideSettingsResponse({}));
  }

  async listContactHideSettings(request: ListContactHideSettingsRequest): Promise<ListContactHideSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListContactHideSettingsHeaders({ });
    return await this.listContactHideSettingsWithOptions(request, headers, runtime);
  }

  async listContactRestrictSettingWithOptions(request: ListContactRestrictSettingRequest, headers: ListContactRestrictSettingHeaders, runtime: $Util.RuntimeOptions): Promise<ListContactRestrictSettingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListContactRestrictSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/restrictions/settings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListContactRestrictSettingResponse>(await this.execute(params, req, runtime), new ListContactRestrictSettingResponse({}));
  }

  async listContactRestrictSetting(request: ListContactRestrictSettingRequest): Promise<ListContactRestrictSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListContactRestrictSettingHeaders({ });
    return await this.listContactRestrictSettingWithOptions(request, headers, runtime);
  }

  async listEmpAttributeVisibilityWithOptions(request: ListEmpAttributeVisibilityRequest, headers: ListEmpAttributeVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<ListEmpAttributeVisibilityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListEmpAttributeVisibility",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/staffAttributes/visibilitySettings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListEmpAttributeVisibilityResponse>(await this.execute(params, req, runtime), new ListEmpAttributeVisibilityResponse({}));
  }

  async listEmpAttributeVisibility(request: ListEmpAttributeVisibilityRequest): Promise<ListEmpAttributeVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEmpAttributeVisibilityHeaders({ });
    return await this.listEmpAttributeVisibilityWithOptions(request, headers, runtime);
  }

  async listEmpLeaveRecordsWithOptions(request: ListEmpLeaveRecordsRequest, headers: ListEmpLeaveRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<ListEmpLeaveRecordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

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
      action: "ListEmpLeaveRecords",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/empLeaveRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListEmpLeaveRecordsResponse>(await this.execute(params, req, runtime), new ListEmpLeaveRecordsResponse({}));
  }

  async listEmpLeaveRecords(request: ListEmpLeaveRecordsRequest): Promise<ListEmpLeaveRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEmpLeaveRecordsHeaders({ });
    return await this.listEmpLeaveRecordsWithOptions(request, headers, runtime);
  }

  async listManagementGroupsWithOptions(request: ListManagementGroupsRequest, headers: ListManagementGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<ListManagementGroupsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListManagementGroups",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/managementGroups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListManagementGroupsResponse>(await this.execute(params, req, runtime), new ListManagementGroupsResponse({}));
  }

  async listManagementGroups(request: ListManagementGroupsRequest): Promise<ListManagementGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListManagementGroupsHeaders({ });
    return await this.listManagementGroupsWithOptions(request, headers, runtime);
  }

  async listOwnedOrgByStaffIdWithOptions(request: ListOwnedOrgByStaffIdRequest, headers: ListOwnedOrgByStaffIdHeaders, runtime: $Util.RuntimeOptions): Promise<ListOwnedOrgByStaffIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

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
      action: "ListOwnedOrgByStaffId",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/ownedOrganizations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListOwnedOrgByStaffIdResponse>(await this.execute(params, req, runtime), new ListOwnedOrgByStaffIdResponse({}));
  }

  async listOwnedOrgByStaffId(request: ListOwnedOrgByStaffIdRequest): Promise<ListOwnedOrgByStaffIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListOwnedOrgByStaffIdHeaders({ });
    return await this.listOwnedOrgByStaffIdWithOptions(request, headers, runtime);
  }

  async listSeniorSettingsWithOptions(request: ListSeniorSettingsRequest, headers: ListSeniorSettingsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSeniorSettingsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.seniorStaffId)) {
      query["seniorStaffId"] = request.seniorStaffId;
    }

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
      action: "ListSeniorSettings",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/seniorSettings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListSeniorSettingsResponse>(await this.execute(params, req, runtime), new ListSeniorSettingsResponse({}));
  }

  async listSeniorSettings(request: ListSeniorSettingsRequest): Promise<ListSeniorSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSeniorSettingsHeaders({ });
    return await this.listSeniorSettingsWithOptions(request, headers, runtime);
  }

  async multiOrgPermissionGrantWithOptions(request: MultiOrgPermissionGrantRequest, headers: MultiOrgPermissionGrantHeaders, runtime: $Util.RuntimeOptions): Promise<MultiOrgPermissionGrantResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.grantDeptIdList)) {
      body["grantDeptIdList"] = request.grantDeptIdList;
    }

    if (!Util.isUnset(request.joinCorpId)) {
      body["joinCorpId"] = request.joinCorpId;
    }

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
      action: "MultiOrgPermissionGrant",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/multiOrgPermissions/auth`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<MultiOrgPermissionGrantResponse>(await this.execute(params, req, runtime), new MultiOrgPermissionGrantResponse({}));
  }

  async multiOrgPermissionGrant(request: MultiOrgPermissionGrantRequest): Promise<MultiOrgPermissionGrantResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MultiOrgPermissionGrantHeaders({ });
    return await this.multiOrgPermissionGrantWithOptions(request, headers, runtime);
  }

  async queryCardVisitorStatisticDataWithOptions(request: QueryCardVisitorStatisticDataRequest, headers: QueryCardVisitorStatisticDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCardVisitorStatisticDataResponse> {
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
    let params = new $OpenApi.Params({
      action: "QueryCardVisitorStatisticData",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/visitors/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCardVisitorStatisticDataResponse>(await this.execute(params, req, runtime), new QueryCardVisitorStatisticDataResponse({}));
  }

  async queryCardVisitorStatisticData(request: QueryCardVisitorStatisticDataRequest): Promise<QueryCardVisitorStatisticDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCardVisitorStatisticDataHeaders({ });
    return await this.queryCardVisitorStatisticDataWithOptions(request, headers, runtime);
  }

  async queryCorpStatisticDataWithOptions(request: QueryCorpStatisticDataRequest, headers: QueryCorpStatisticDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCorpStatisticDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.templateIds)) {
      body["templateIds"] = request.templateIds;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

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
      action: "QueryCorpStatisticData",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/templates/statistics/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCorpStatisticDataResponse>(await this.execute(params, req, runtime), new QueryCorpStatisticDataResponse({}));
  }

  async queryCorpStatisticData(request: QueryCorpStatisticDataRequest): Promise<QueryCorpStatisticDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCorpStatisticDataHeaders({ });
    return await this.queryCorpStatisticDataWithOptions(request, headers, runtime);
  }

  async queryCorpUserStatisticWithOptions(request: QueryCorpUserStatisticRequest, headers: QueryCorpUserStatisticHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCorpUserStatisticResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.templateIds)) {
      body["templateIds"] = request.templateIds;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

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
      action: "QueryCorpUserStatistic",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cards/users/statistics/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCorpUserStatisticResponse>(await this.execute(params, req, runtime), new QueryCorpUserStatisticResponse({}));
  }

  async queryCorpUserStatistic(request: QueryCorpUserStatisticRequest): Promise<QueryCorpUserStatisticResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCorpUserStatisticHeaders({ });
    return await this.queryCorpUserStatisticWithOptions(request, headers, runtime);
  }

  async queryResourceManagementMembersWithOptions(resourceId: string, headers: QueryResourceManagementMembersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryResourceManagementMembersResponse> {
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
      action: "QueryResourceManagementMembers",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/resources/${resourceId}/managementMembers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryResourceManagementMembersResponse>(await this.execute(params, req, runtime), new QueryResourceManagementMembersResponse({}));
  }

  async queryResourceManagementMembers(resourceId: string): Promise<QueryResourceManagementMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryResourceManagementMembersHeaders({ });
    return await this.queryResourceManagementMembersWithOptions(resourceId, headers, runtime);
  }

  async queryStatusWithOptions(request: QueryStatusRequest, headers: QueryStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

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
      action: "QueryStatus",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/status`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryStatusResponse>(await this.execute(params, req, runtime), new QueryStatusResponse({}));
  }

  async queryStatus(request: QueryStatusRequest): Promise<QueryStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryStatusHeaders({ });
    return await this.queryStatusWithOptions(request, headers, runtime);
  }

  async queryUserManagementResourcesWithOptions(userId: string, headers: QueryUserManagementResourcesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserManagementResourcesResponse> {
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
      action: "QueryUserManagementResources",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/users/${userId}/managemementResources`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryUserManagementResourcesResponse>(await this.execute(params, req, runtime), new QueryUserManagementResourcesResponse({}));
  }

  async queryUserManagementResources(userId: string): Promise<QueryUserManagementResourcesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserManagementResourcesHeaders({ });
    return await this.queryUserManagementResourcesWithOptions(userId, headers, runtime);
  }

  async queryVerifyResultWithOptions(request: QueryVerifyResultRequest, headers: QueryVerifyResultHeaders, runtime: $Util.RuntimeOptions): Promise<QueryVerifyResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.verifyId)) {
      query["verifyId"] = request.verifyId;
    }

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
      action: "QueryVerifyResult",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/verifyIdentitys/verifyResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryVerifyResultResponse>(await this.execute(params, req, runtime), new QueryVerifyResultResponse({}));
  }

  async queryVerifyResult(request: QueryVerifyResultRequest): Promise<QueryVerifyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryVerifyResultHeaders({ });
    return await this.queryVerifyResultWithOptions(request, headers, runtime);
  }

  async searchDepartmentWithOptions(request: SearchDepartmentRequest, headers: SearchDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<SearchDepartmentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.offset)) {
      body["offset"] = request.offset;
    }

    if (!Util.isUnset(request.queryWord)) {
      body["queryWord"] = request.queryWord;
    }

    if (!Util.isUnset(request.size)) {
      body["size"] = request.size;
    }

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
      action: "SearchDepartment",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/departments/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchDepartmentResponse>(await this.execute(params, req, runtime), new SearchDepartmentResponse({}));
  }

  async searchDepartment(request: SearchDepartmentRequest): Promise<SearchDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchDepartmentHeaders({ });
    return await this.searchDepartmentWithOptions(request, headers, runtime);
  }

  async searchUserWithOptions(request: SearchUserRequest, headers: SearchUserHeaders, runtime: $Util.RuntimeOptions): Promise<SearchUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fullMatchField)) {
      body["fullMatchField"] = request.fullMatchField;
    }

    if (!Util.isUnset(request.offset)) {
      body["offset"] = request.offset;
    }

    if (!Util.isUnset(request.queryWord)) {
      body["queryWord"] = request.queryWord;
    }

    if (!Util.isUnset(request.size)) {
      body["size"] = request.size;
    }

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
      action: "SearchUser",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/users/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchUserResponse>(await this.execute(params, req, runtime), new SearchUserResponse({}));
  }

  async searchUser(request: SearchUserRequest): Promise<SearchUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchUserHeaders({ });
    return await this.searchUserWithOptions(request, headers, runtime);
  }

  async separateBranchOrgWithOptions(request: SeparateBranchOrgRequest, headers: SeparateBranchOrgHeaders, runtime: $Util.RuntimeOptions): Promise<SeparateBranchOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachDeptId)) {
      body["attachDeptId"] = request.attachDeptId;
    }

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
      action: "SeparateBranchOrg",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cooperateCorps/separate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SeparateBranchOrgResponse>(await this.execute(params, req, runtime), new SeparateBranchOrgResponse({}));
  }

  async separateBranchOrg(request: SeparateBranchOrgRequest): Promise<SeparateBranchOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SeparateBranchOrgHeaders({ });
    return await this.separateBranchOrgWithOptions(request, headers, runtime);
  }

  async setDisableWithOptions(request: SetDisableRequest, headers: SetDisableHeaders, runtime: $Util.RuntimeOptions): Promise<SetDisableResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.reason)) {
      body["reason"] = request.reason;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

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
      action: "SetDisable",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/disable`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetDisableResponse>(await this.execute(params, req, runtime), new SetDisableResponse({}));
  }

  async setDisable(request: SetDisableRequest): Promise<SetDisableResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetDisableHeaders({ });
    return await this.setDisableWithOptions(request, headers, runtime);
  }

  async setEnableWithOptions(request: SetEnableRequest, headers: SetEnableHeaders, runtime: $Util.RuntimeOptions): Promise<SetEnableResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

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
      action: "SetEnable",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/enable`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetEnableResponse>(await this.execute(params, req, runtime), new SetEnableResponse({}));
  }

  async setEnable(request: SetEnableRequest): Promise<SetEnableResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetEnableHeaders({ });
    return await this.setEnableWithOptions(request, headers, runtime);
  }

  async signOutWithOptions(request: SignOutRequest, headers: SignOutHeaders, runtime: $Util.RuntimeOptions): Promise<SignOutResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.reason)) {
      body["reason"] = request.reason;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

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
      action: "SignOut",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccounts/signOut`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SignOutResponse>(await this.execute(params, req, runtime), new SignOutResponse({}));
  }

  async signOut(request: SignOutRequest): Promise<SignOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignOutHeaders({ });
    return await this.signOutWithOptions(request, headers, runtime);
  }

  async sortUserWithOptions(request: SortUserRequest, headers: SortUserHeaders, runtime: $Util.RuntimeOptions): Promise<SortUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sortType)) {
      body["sortType"] = request.sortType;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
    }

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
      action: "SortUser",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/users/sort`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SortUserResponse>(await this.execute(params, req, runtime), new SortUserResponse({}));
  }

  async sortUser(request: SortUserRequest): Promise<SortUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SortUserHeaders({ });
    return await this.sortUserWithOptions(request, headers, runtime);
  }

  async transformToExclusiveAccountWithOptions(request: TransformToExclusiveAccountRequest, headers: TransformToExclusiveAccountHeaders, runtime: $Util.RuntimeOptions): Promise<TransformToExclusiveAccountResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.idpDingTalk)) {
      body["idpDingTalk"] = request.idpDingTalk;
    }

    if (!Util.isUnset(request.initPassword)) {
      body["initPassword"] = request.initPassword;
    }

    if (!Util.isUnset(request.loginId)) {
      body["loginId"] = request.loginId;
    }

    if (!Util.isUnset(request.transformType)) {
      body["transformType"] = request.transformType;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

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
      action: "TransformToExclusiveAccount",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/orgAccount/transformToExclusiveAccounts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<TransformToExclusiveAccountResponse>(await this.execute(params, req, runtime), new TransformToExclusiveAccountResponse({}));
  }

  async transformToExclusiveAccount(request: TransformToExclusiveAccountRequest): Promise<TransformToExclusiveAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransformToExclusiveAccountHeaders({ });
    return await this.transformToExclusiveAccountWithOptions(request, headers, runtime);
  }

  async translateFileWithOptions(request: TranslateFileRequest, headers: TranslateFileHeaders, runtime: $Util.RuntimeOptions): Promise<TranslateFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.medias)) {
      body["medias"] = request.medias;
    }

    if (!Util.isUnset(request.outputFileName)) {
      body["outputFileName"] = request.outputFileName;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

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
      action: "TranslateFile",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/files/translate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TranslateFileResponse>(await this.execute(params, req, runtime), new TranslateFileResponse({}));
  }

  async translateFile(request: TranslateFileRequest): Promise<TranslateFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TranslateFileHeaders({ });
    return await this.translateFileWithOptions(request, headers, runtime);
  }

  async uniqueQueryUserCardWithOptions(request: UniqueQueryUserCardRequest, headers: UniqueQueryUserCardHeaders, runtime: $Util.RuntimeOptions): Promise<UniqueQueryUserCardResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateId)) {
      query["templateId"] = request.templateId;
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
    let params = new $OpenApi.Params({
      action: "UniqueQueryUserCard",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/uniques/cards`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UniqueQueryUserCardResponse>(await this.execute(params, req, runtime), new UniqueQueryUserCardResponse({}));
  }

  async uniqueQueryUserCard(request: UniqueQueryUserCardRequest): Promise<UniqueQueryUserCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UniqueQueryUserCardHeaders({ });
    return await this.uniqueQueryUserCardWithOptions(request, headers, runtime);
  }

  async updateBranchAttributesInCooperateWithOptions(request: UpdateBranchAttributesInCooperateRequest, headers: UpdateBranchAttributesInCooperateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateBranchAttributesInCooperateResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateBranchAttributesInCooperate",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cooperateCorps/branchAttributes`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateBranchAttributesInCooperateResponse>(await this.execute(params, req, runtime), new UpdateBranchAttributesInCooperateResponse({}));
  }

  async updateBranchAttributesInCooperate(request: UpdateBranchAttributesInCooperateRequest): Promise<UpdateBranchAttributesInCooperateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateBranchAttributesInCooperateHeaders({ });
    return await this.updateBranchAttributesInCooperateWithOptions(request, headers, runtime);
  }

  async updateBranchVisibleSettingInCooperateWithOptions(request: UpdateBranchVisibleSettingInCooperateRequest, headers: UpdateBranchVisibleSettingInCooperateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateBranchVisibleSettingInCooperateResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateBranchVisibleSettingInCooperate",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/cooperateCorps/branchVisibleSettings`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateBranchVisibleSettingInCooperateResponse>(await this.execute(params, req, runtime), new UpdateBranchVisibleSettingInCooperateResponse({}));
  }

  async updateBranchVisibleSettingInCooperate(request: UpdateBranchVisibleSettingInCooperateRequest): Promise<UpdateBranchVisibleSettingInCooperateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateBranchVisibleSettingInCooperateHeaders({ });
    return await this.updateBranchVisibleSettingInCooperateWithOptions(request, headers, runtime);
  }

  async updateContactHideBySceneSettingWithOptions(settingId: string, request: UpdateContactHideBySceneSettingRequest, headers: UpdateContactHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateContactHideBySceneSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.excludeUserIds)) {
      body["excludeUserIds"] = request.excludeUserIds;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.nodeListSceneConfig)) {
      body["nodeListSceneConfig"] = request.nodeListSceneConfig;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

    if (!Util.isUnset(request.objectUserIds)) {
      body["objectUserIds"] = request.objectUserIds;
    }

    if (!Util.isUnset(request.profileSceneConfig)) {
      body["profileSceneConfig"] = request.profileSceneConfig;
    }

    if (!Util.isUnset(request.searchSceneConfig)) {
      body["searchSceneConfig"] = request.searchSceneConfig;
    }

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
      action: "UpdateContactHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/organizations/hides/settings/${settingId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateContactHideBySceneSettingResponse>(await this.execute(params, req, runtime), new UpdateContactHideBySceneSettingResponse({}));
  }

  async updateContactHideBySceneSetting(settingId: string, request: UpdateContactHideBySceneSettingRequest): Promise<UpdateContactHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateContactHideBySceneSettingHeaders({ });
    return await this.updateContactHideBySceneSettingWithOptions(settingId, request, headers, runtime);
  }

  async updateContactHideSettingWithOptions(request: UpdateContactHideSettingRequest, headers: UpdateContactHideSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateContactHideSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.active)) {
      body["active"] = request.active;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeStaffIds)) {
      body["excludeStaffIds"] = request.excludeStaffIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.hideInSearch)) {
      body["hideInSearch"] = request.hideInSearch;
    }

    if (!Util.isUnset(request.hideInUserProfile)) {
      body["hideInUserProfile"] = request.hideInUserProfile;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectStaffIds)) {
      body["objectStaffIds"] = request.objectStaffIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

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
      action: "UpdateContactHideSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/contactHideSettings`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateContactHideSettingResponse>(await this.execute(params, req, runtime), new UpdateContactHideSettingResponse({}));
  }

  async updateContactHideSetting(request: UpdateContactHideSettingRequest): Promise<UpdateContactHideSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateContactHideSettingHeaders({ });
    return await this.updateContactHideSettingWithOptions(request, headers, runtime);
  }

  async updateContactRestrictSettingWithOptions(request: UpdateContactRestrictSettingRequest, headers: UpdateContactRestrictSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateContactRestrictSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.active)) {
      body["active"] = request.active;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.excludeUserIds)) {
      body["excludeUserIds"] = request.excludeUserIds;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.restrictInSearch)) {
      body["restrictInSearch"] = request.restrictInSearch;
    }

    if (!Util.isUnset(request.restrictInUserProfile)) {
      body["restrictInUserProfile"] = request.restrictInUserProfile;
    }

    if (!Util.isUnset(request.subjectDeptIds)) {
      body["subjectDeptIds"] = request.subjectDeptIds;
    }

    if (!Util.isUnset(request.subjectTagIds)) {
      body["subjectTagIds"] = request.subjectTagIds;
    }

    if (!Util.isUnset(request.subjectUserIds)) {
      body["subjectUserIds"] = request.subjectUserIds;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

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
      action: "UpdateContactRestrictSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/restrictions/settings`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateContactRestrictSettingResponse>(await this.execute(params, req, runtime), new UpdateContactRestrictSettingResponse({}));
  }

  async updateContactRestrictSetting(request: UpdateContactRestrictSettingRequest): Promise<UpdateContactRestrictSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateContactRestrictSettingHeaders({ });
    return await this.updateContactRestrictSettingWithOptions(request, headers, runtime);
  }

  async updateDeptSettngTailFirstWithOptions(request: UpdateDeptSettngTailFirstRequest, headers: UpdateDeptSettngTailFirstHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDeptSettngTailFirstResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.enable)) {
      body["enable"] = request.enable;
    }

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
      action: "UpdateDeptSettngTailFirst",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/depts/settings/priorities`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "formData",
      bodyType: "json",
    });
    return $tea.cast<UpdateDeptSettngTailFirstResponse>(await this.execute(params, req, runtime), new UpdateDeptSettngTailFirstResponse({}));
  }

  async updateDeptSettngTailFirst(request: UpdateDeptSettngTailFirstRequest): Promise<UpdateDeptSettngTailFirstResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDeptSettngTailFirstHeaders({ });
    return await this.updateDeptSettngTailFirstWithOptions(request, headers, runtime);
  }

  async updateEmpAttrbuteVisibilitySettingWithOptions(request: UpdateEmpAttrbuteVisibilitySettingRequest, headers: UpdateEmpAttrbuteVisibilitySettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateEmpAttrbuteVisibilitySettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.active)) {
      body["active"] = request.active;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeStaffIds)) {
      body["excludeStaffIds"] = request.excludeStaffIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.hideFields)) {
      body["hideFields"] = request.hideFields;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectStaffIds)) {
      body["objectStaffIds"] = request.objectStaffIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

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
      action: "UpdateEmpAttrbuteVisibilitySetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/staffAttributes/visibilitySettings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateEmpAttrbuteVisibilitySettingResponse>(await this.execute(params, req, runtime), new UpdateEmpAttrbuteVisibilitySettingResponse({}));
  }

  async updateEmpAttrbuteVisibilitySetting(request: UpdateEmpAttrbuteVisibilitySettingRequest): Promise<UpdateEmpAttrbuteVisibilitySettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateEmpAttrbuteVisibilitySettingHeaders({ });
    return await this.updateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
  }

  async updateEmpAttributeHideBySceneSettingWithOptions(settingId: string, request: UpdateEmpAttributeHideBySceneSettingRequest, headers: UpdateEmpAttributeHideBySceneSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateEmpAttributeHideBySceneSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatSubtitleConfig)) {
      body["chatSubtitleConfig"] = request.chatSubtitleConfig;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.excludeUserIds)) {
      body["excludeUserIds"] = request.excludeUserIds;
    }

    if (!Util.isUnset(request.hideFields)) {
      body["hideFields"] = request.hideFields;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

    if (!Util.isUnset(request.objectUserIds)) {
      body["objectUserIds"] = request.objectUserIds;
    }

    if (!Util.isUnset(request.profileSceneConfig)) {
      body["profileSceneConfig"] = request.profileSceneConfig;
    }

    if (!Util.isUnset(request.searchSceneConfig)) {
      body["searchSceneConfig"] = request.searchSceneConfig;
    }

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
      action: "UpdateEmpAttributeHideBySceneSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/empAttributes/hides/settings/${settingId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateEmpAttributeHideBySceneSettingResponse>(await this.execute(params, req, runtime), new UpdateEmpAttributeHideBySceneSettingResponse({}));
  }

  async updateEmpAttributeHideBySceneSetting(settingId: string, request: UpdateEmpAttributeHideBySceneSettingRequest): Promise<UpdateEmpAttributeHideBySceneSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateEmpAttributeHideBySceneSettingHeaders({ });
    return await this.updateEmpAttributeHideBySceneSettingWithOptions(settingId, request, headers, runtime);
  }

  async updateManagementGroupWithOptions(groupId: string, request: UpdateManagementGroupRequest, headers: UpdateManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateManagementGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.resourceIds)) {
      body["resourceIds"] = request.resourceIds;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

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
      action: "UpdateManagementGroup",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/managementGroups/${groupId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateManagementGroupResponse>(await this.execute(params, req, runtime), new UpdateManagementGroupResponse({}));
  }

  async updateManagementGroup(groupId: string, request: UpdateManagementGroupRequest): Promise<UpdateManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateManagementGroupHeaders({ });
    return await this.updateManagementGroupWithOptions(groupId, request, headers, runtime);
  }

  async updateSeniorSettingWithOptions(request: UpdateSeniorSettingRequest, headers: UpdateSeniorSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSeniorSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.open)) {
      body["open"] = request.open;
    }

    if (!Util.isUnset(request.permitDeptIds)) {
      body["permitDeptIds"] = request.permitDeptIds;
    }

    if (!Util.isUnset(request.permitStaffIds)) {
      body["permitStaffIds"] = request.permitStaffIds;
    }

    if (!Util.isUnset(request.permitTagIds)) {
      body["permitTagIds"] = request.permitTagIds;
    }

    if (!Util.isUnset(request.protectScenes)) {
      body["protectScenes"] = request.protectScenes;
    }

    if (!Util.isUnset(request.seniorStaffId)) {
      body["seniorStaffId"] = request.seniorStaffId;
    }

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
      action: "UpdateSeniorSetting",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/seniorSettings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateSeniorSettingResponse>(await this.execute(params, req, runtime), new UpdateSeniorSettingResponse({}));
  }

  async updateSeniorSetting(request: UpdateSeniorSettingRequest): Promise<UpdateSeniorSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSeniorSettingHeaders({ });
    return await this.updateSeniorSettingWithOptions(request, headers, runtime);
  }

  async updateUserOwnnessWithOptions(userId: string, request: UpdateUserOwnnessRequest, headers: UpdateUserOwnnessHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUserOwnnessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deletedFlag)) {
      body["deletedFlag"] = request.deletedFlag;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.ownenssType)) {
      body["ownenssType"] = request.ownenssType;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

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
      action: "UpdateUserOwnness",
      version: "contact_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contact/user/${userId}/ownness`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateUserOwnnessResponse>(await this.execute(params, req, runtime), new UpdateUserOwnnessResponse({}));
  }

  async updateUserOwnness(userId: string, request: UpdateUserOwnnessRequest): Promise<UpdateUserOwnnessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUserOwnnessHeaders({ });
    return await this.updateUserOwnnessWithOptions(userId, request, headers, runtime);
  }

}
