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

export class AddApplicationRegFormTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApplicationRegFormTemplateRequest extends $tea.Model {
  bizCode?: string;
  content?: string;
  name?: string;
  outerId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      content: 'content',
      name: 'name',
      outerId: 'outerId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      content: 'string',
      name: 'string',
      outerId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApplicationRegFormTemplateResponseBody extends $tea.Model {
  templateId?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddApplicationRegFormTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddApplicationRegFormTemplateResponseBody;
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
      body: AddApplicationRegFormTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileRequest extends $tea.Model {
  bizCode?: string;
  fileName?: string;
  mediaId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      fileName: 'fileName',
      mediaId: 'mediaId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      fileName: 'string',
      mediaId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileResponseBody extends $tea.Model {
  fileId?: string;
  fileName?: string;
  spaceId?: number;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      spaceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddFileResponseBody;
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
      body: AddFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddUserAccountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddUserAccountRequest extends $tea.Model {
  bizCode?: string;
  channelAccountName?: string;
  channelUserIdentify?: string;
  phoneNumber?: string;
  corpId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channelAccountName: 'channelAccountName',
      channelUserIdentify: 'channelUserIdentify',
      phoneNumber: 'phoneNumber',
      corpId: 'corpId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channelAccountName: 'string',
      channelUserIdentify: 'string',
      phoneNumber: 'string',
      corpId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddUserAccountResponseBody extends $tea.Model {
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

export class AddUserAccountResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddUserAccountResponseBody;
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
      body: AddUserAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailRequest extends $tea.Model {
  bizCode?: string;
  channel?: string;
  jobInfo?: CollectRecruitJobDetailRequestJobInfo;
  outCorpId?: string;
  outCorpName?: string;
  recruitUserInfo?: CollectRecruitJobDetailRequestRecruitUserInfo;
  source?: string;
  updateTime?: number;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channel: 'channel',
      jobInfo: 'jobInfo',
      outCorpId: 'outCorpId',
      outCorpName: 'outCorpName',
      recruitUserInfo: 'recruitUserInfo',
      source: 'source',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channel: 'string',
      jobInfo: CollectRecruitJobDetailRequestJobInfo,
      outCorpId: 'string',
      outCorpName: 'string',
      recruitUserInfo: CollectRecruitJobDetailRequestRecruitUserInfo,
      source: 'string',
      updateTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailResponseBody extends $tea.Model {
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

export class CollectRecruitJobDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollectRecruitJobDetailResponseBody;
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
      body: CollectRecruitJobDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequest extends $tea.Model {
  bizCode?: string;
  channelCode?: string;
  channelOuterId?: string;
  channelTalentId?: string;
  deliverJobId?: string;
  optUserId?: string;
  resumeChannelUrl?: string;
  resumeData?: CollectResumeDetailRequestResumeData;
  resumeFile?: CollectResumeDetailRequestResumeFile;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channelCode: 'channelCode',
      channelOuterId: 'channelOuterId',
      channelTalentId: 'channelTalentId',
      deliverJobId: 'deliverJobId',
      optUserId: 'optUserId',
      resumeChannelUrl: 'resumeChannelUrl',
      resumeData: 'resumeData',
      resumeFile: 'resumeFile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channelCode: 'string',
      channelOuterId: 'string',
      channelTalentId: 'string',
      deliverJobId: 'string',
      optUserId: 'string',
      resumeChannelUrl: 'string',
      resumeData: CollectResumeDetailRequestResumeData,
      resumeFile: CollectResumeDetailRequestResumeFile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailResponseBody extends $tea.Model {
  resumeId?: string;
  static names(): { [key: string]: string } {
    return {
      resumeId: 'resumeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resumeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollectResumeDetailResponseBody;
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
      body: CollectResumeDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeMailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeMailRequest extends $tea.Model {
  bizCode?: string;
  channelCode?: string;
  deliverJobId?: string;
  fromMailAddress?: string;
  historyMailImport?: boolean;
  mailId?: string;
  mailTitle?: string;
  optUserId?: string;
  receiveMailAddress?: string;
  receiveMailType?: number;
  receivedTime?: number;
  resumeChannelUrl?: string;
  resumeFile?: CollectResumeMailRequestResumeFile;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channelCode: 'channelCode',
      deliverJobId: 'deliverJobId',
      fromMailAddress: 'fromMailAddress',
      historyMailImport: 'historyMailImport',
      mailId: 'mailId',
      mailTitle: 'mailTitle',
      optUserId: 'optUserId',
      receiveMailAddress: 'receiveMailAddress',
      receiveMailType: 'receiveMailType',
      receivedTime: 'receivedTime',
      resumeChannelUrl: 'resumeChannelUrl',
      resumeFile: 'resumeFile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channelCode: 'string',
      deliverJobId: 'string',
      fromMailAddress: 'string',
      historyMailImport: 'boolean',
      mailId: 'string',
      mailTitle: 'string',
      optUserId: 'string',
      receiveMailAddress: 'string',
      receiveMailType: 'number',
      receivedTime: 'number',
      resumeChannelUrl: 'string',
      resumeFile: CollectResumeMailRequestResumeFile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeMailResponseBody extends $tea.Model {
  resumeId?: string;
  static names(): { [key: string]: string } {
    return {
      resumeId: 'resumeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resumeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeMailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CollectResumeMailResponseBody;
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
      body: CollectResumeMailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConfirmRightsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConfirmRightsRequest extends $tea.Model {
  bizCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConfirmRightsResponseBody extends $tea.Model {
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

export class ConfirmRightsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ConfirmRightsResponseBody;
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
      body: ConfirmRightsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishBeginnerTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishBeginnerTaskRequest extends $tea.Model {
  scope?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      scope: 'scope',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scope: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishBeginnerTaskResponseBody extends $tea.Model {
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

export class FinishBeginnerTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: FinishBeginnerTaskResponseBody;
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
      body: FinishBeginnerTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationRegFormByFlowIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationRegFormByFlowIdRequest extends $tea.Model {
  bizCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationRegFormByFlowIdResponseBody extends $tea.Model {
  candidateId?: string;
  creatorUserId?: string;
  flowId?: string;
  formId?: string;
  gmtCreateMillis?: number;
  gmtModifiedMillis?: number;
  jobId?: string;
  status?: number;
  templateId?: string;
  templateVersion?: number;
  static names(): { [key: string]: string } {
    return {
      candidateId: 'candidateId',
      creatorUserId: 'creatorUserId',
      flowId: 'flowId',
      formId: 'formId',
      gmtCreateMillis: 'gmtCreateMillis',
      gmtModifiedMillis: 'gmtModifiedMillis',
      jobId: 'jobId',
      status: 'status',
      templateId: 'templateId',
      templateVersion: 'templateVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      candidateId: 'string',
      creatorUserId: 'string',
      flowId: 'string',
      formId: 'string',
      gmtCreateMillis: 'number',
      gmtModifiedMillis: 'number',
      jobId: 'string',
      status: 'number',
      templateId: 'string',
      templateVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplicationRegFormByFlowIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetApplicationRegFormByFlowIdResponseBody;
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
      body: GetApplicationRegFormByFlowIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCandidateByPhoneNumberHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCandidateByPhoneNumberRequest extends $tea.Model {
  bizCode?: string;
  phoneNumber?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      phoneNumber: 'phoneNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      phoneNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCandidateByPhoneNumberResponseBody extends $tea.Model {
  candidateId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      candidateId: 'candidateId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      candidateId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCandidateByPhoneNumberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCandidateByPhoneNumberResponseBody;
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
      body: GetCandidateByPhoneNumberResponseBody,
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
  bizCode?: string;
  fileName?: string;
  fileSize?: number;
  md5?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      fileName: 'fileName',
      fileSize: 'fileSize',
      md5: 'md5',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      fileName: 'string',
      fileSize: 'number',
      md5: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoResponseBody extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  accessToken?: string;
  accessTokenExpirationMillis?: number;
  bucket?: string;
  endPoint?: string;
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      accessToken: 'accessToken',
      accessTokenExpirationMillis: 'accessTokenExpirationMillis',
      bucket: 'bucket',
      endPoint: 'endPoint',
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      accessToken: 'string',
      accessTokenExpirationMillis: 'number',
      bucket: 'string',
      endPoint: 'string',
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFileUploadInfoResponseBody;
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
      body: GetFileUploadInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowIdByRelationEntityIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowIdByRelationEntityIdRequest extends $tea.Model {
  bizCode?: string;
  relationEntity?: string;
  relationEntityId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      relationEntity: 'relationEntity',
      relationEntityId: 'relationEntityId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      relationEntity: 'string',
      relationEntityId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowIdByRelationEntityIdResponseBody extends $tea.Model {
  flowId?: string;
  static names(): { [key: string]: string } {
    return {
      flowId: 'flowId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flowId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowIdByRelationEntityIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFlowIdByRelationEntityIdResponseBody;
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
      body: GetFlowIdByRelationEntityIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthRequest extends $tea.Model {
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthResponseBody extends $tea.Model {
  jobId?: string;
  jobOwners?: GetJobAuthResponseBodyJobOwners[];
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      jobOwners: 'jobOwners',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
      jobOwners: { 'type': 'array', 'itemType': GetJobAuthResponseBodyJobOwners },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetJobAuthResponseBody;
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
      body: GetJobAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInterviewsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInterviewsRequest extends $tea.Model {
  bizCode?: string;
  candidateId?: string;
  startTimeBeginMillis?: number;
  startTimeEndMillis?: number;
  nextToken?: string;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      candidateId: 'candidateId',
      startTimeBeginMillis: 'startTimeBeginMillis',
      startTimeEndMillis: 'startTimeEndMillis',
      nextToken: 'nextToken',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      candidateId: 'string',
      startTimeBeginMillis: 'number',
      startTimeEndMillis: 'number',
      nextToken: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInterviewsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryInterviewsResponseBodyList[];
  nextToken?: string;
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
      list: { 'type': 'array', 'itemType': QueryInterviewsResponseBodyList },
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInterviewsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryInterviewsResponseBody;
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
      body: QueryInterviewsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportMessageStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportMessageStatusRequest extends $tea.Model {
  bizCode?: string;
  channel?: string;
  errorCode?: string;
  errorMsg?: string;
  messageId?: string;
  receiverUserId?: string;
  senderUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channel: 'channel',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      messageId: 'messageId',
      receiverUserId: 'receiverUserId',
      senderUserId: 'senderUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channel: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      messageId: 'string',
      receiverUserId: 'string',
      senderUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportMessageStatusResponseBody extends $tea.Model {
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

export class ReportMessageStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ReportMessageStatusResponseBody;
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
      body: ReportMessageStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncChannelMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncChannelMessageRequest extends $tea.Model {
  bizCode?: string;
  channel?: string;
  content?: string;
  createTime?: number;
  receiverUserId?: string;
  senderUserId?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channel: 'channel',
      content: 'content',
      createTime: 'createTime',
      receiverUserId: 'receiverUserId',
      senderUserId: 'senderUserId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channel: 'string',
      content: 'string',
      createTime: 'number',
      receiverUserId: 'string',
      senderUserId: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncChannelMessageResponseBody extends $tea.Model {
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

export class SyncChannelMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SyncChannelMessageResponseBody;
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
      body: SyncChannelMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplicationRegFormHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplicationRegFormRequest extends $tea.Model {
  bizCode?: string;
  content?: string;
  dingPanFile?: UpdateApplicationRegFormRequestDingPanFile;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      content: 'content',
      dingPanFile: 'dingPanFile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      content: 'string',
      dingPanFile: UpdateApplicationRegFormRequestDingPanFile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplicationRegFormResponseBody extends $tea.Model {
  creatorUserId?: string;
  formId?: string;
  gmtCreateMillis?: number;
  gmtModifiedMillis?: number;
  status?: number;
  templateId?: string;
  templateVersion?: number;
  static names(): { [key: string]: string } {
    return {
      creatorUserId: 'creatorUserId',
      formId: 'formId',
      gmtCreateMillis: 'gmtCreateMillis',
      gmtModifiedMillis: 'gmtModifiedMillis',
      status: 'status',
      templateId: 'templateId',
      templateVersion: 'templateVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUserId: 'string',
      formId: 'string',
      gmtCreateMillis: 'number',
      gmtModifiedMillis: 'number',
      status: 'number',
      templateId: 'string',
      templateVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplicationRegFormResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateApplicationRegFormResponseBody;
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
      body: UpdateApplicationRegFormResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInterviewSignInInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInterviewSignInInfoRequest extends $tea.Model {
  bizCode?: string;
  signInTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      signInTimeMillis: 'signInTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      signInTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInterviewSignInInfoResponse extends $tea.Model {
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

export class UpdateJobDeliverHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateJobDeliverRequest extends $tea.Model {
  bizCode?: string;
  channelOuterId?: string;
  deliverUserId?: string;
  errorCode?: string;
  errorMsg?: string;
  opTime?: number;
  opUserId?: string;
  status?: number;
  jobId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      channelOuterId: 'channelOuterId',
      deliverUserId: 'deliverUserId',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      opTime: 'opTime',
      opUserId: 'opUserId',
      status: 'status',
      jobId: 'jobId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      channelOuterId: 'string',
      deliverUserId: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      opTime: 'number',
      opUserId: 'string',
      status: 'number',
      jobId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateJobDeliverResponseBody extends $tea.Model {
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

export class UpdateJobDeliverResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateJobDeliverResponseBody;
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
      body: UpdateJobDeliverResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailRequestJobInfoAddress extends $tea.Model {
  cityCode?: string;
  detail?: string;
  districtCode?: string;
  latitude?: string;
  longitude?: string;
  name?: string;
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      cityCode: 'cityCode',
      detail: 'detail',
      districtCode: 'districtCode',
      latitude: 'latitude',
      longitude: 'longitude',
      name: 'name',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cityCode: 'string',
      detail: 'string',
      districtCode: 'string',
      latitude: 'string',
      longitude: 'string',
      name: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailRequestJobInfoFullTimeInfo extends $tea.Model {
  maxJobExperience?: string;
  minJobExperience?: string;
  salaryMonth?: string;
  static names(): { [key: string]: string } {
    return {
      maxJobExperience: 'maxJobExperience',
      minJobExperience: 'minJobExperience',
      salaryMonth: 'salaryMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxJobExperience: 'string',
      minJobExperience: 'string',
      salaryMonth: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailRequestJobInfoPartTimeInfo extends $tea.Model {
  contactNumber?: string;
  salaryPeriod?: string;
  settleType?: string;
  specifyWorkDate?: string;
  specifyWorkTime?: string;
  workBeginTimeMin?: string;
  workDateType?: string;
  workEndDate?: string;
  workEndTimeMin?: string;
  workStartDate?: string;
  static names(): { [key: string]: string } {
    return {
      contactNumber: 'contactNumber',
      salaryPeriod: 'salaryPeriod',
      settleType: 'settleType',
      specifyWorkDate: 'specifyWorkDate',
      specifyWorkTime: 'specifyWorkTime',
      workBeginTimeMin: 'workBeginTimeMin',
      workDateType: 'workDateType',
      workEndDate: 'workEndDate',
      workEndTimeMin: 'workEndTimeMin',
      workStartDate: 'workStartDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactNumber: 'string',
      salaryPeriod: 'string',
      settleType: 'string',
      specifyWorkDate: 'string',
      specifyWorkTime: 'string',
      workBeginTimeMin: 'string',
      workDateType: 'string',
      workEndDate: 'string',
      workEndTimeMin: 'string',
      workStartDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailRequestJobInfo extends $tea.Model {
  address?: CollectRecruitJobDetailRequestJobInfoAddress;
  category?: string;
  description?: string;
  extInfo?: string;
  fullTimeInfo?: CollectRecruitJobDetailRequestJobInfoFullTimeInfo;
  headCount?: string;
  jobNature?: string;
  jobTags?: string[];
  maxSalary?: string;
  minSalary?: string;
  name?: string;
  outJobId?: string;
  partTimeInfo?: CollectRecruitJobDetailRequestJobInfoPartTimeInfo;
  requiredEdu?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      category: 'category',
      description: 'description',
      extInfo: 'extInfo',
      fullTimeInfo: 'fullTimeInfo',
      headCount: 'headCount',
      jobNature: 'jobNature',
      jobTags: 'jobTags',
      maxSalary: 'maxSalary',
      minSalary: 'minSalary',
      name: 'name',
      outJobId: 'outJobId',
      partTimeInfo: 'partTimeInfo',
      requiredEdu: 'requiredEdu',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: CollectRecruitJobDetailRequestJobInfoAddress,
      category: 'string',
      description: 'string',
      extInfo: 'string',
      fullTimeInfo: CollectRecruitJobDetailRequestJobInfoFullTimeInfo,
      headCount: 'string',
      jobNature: 'string',
      jobTags: { 'type': 'array', 'itemType': 'string' },
      maxSalary: 'string',
      minSalary: 'string',
      name: 'string',
      outJobId: 'string',
      partTimeInfo: CollectRecruitJobDetailRequestJobInfoPartTimeInfo,
      requiredEdu: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectRecruitJobDetailRequestRecruitUserInfo extends $tea.Model {
  extInfo?: string;
  outUserId?: string;
  userMobile?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      extInfo: 'extInfo',
      outUserId: 'outUserId',
      userMobile: 'userMobile',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extInfo: 'string',
      outUserId: 'string',
      userMobile: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataBaseInfo extends $tea.Model {
  age?: number;
  avatar?: string;
  beginWorkTime?: string;
  birthday?: string;
  email?: string;
  englishName?: string;
  graduateTime?: string;
  highestEducation?: number;
  jobTitle?: string;
  lastSchoolName?: string;
  married?: number;
  name?: string;
  nativePlace?: string;
  nowLocation?: string;
  personalHonor?: string;
  phoneNum?: string;
  politicalStatus?: number;
  selfEvaluation?: string;
  sex?: number;
  virtualPhoneNum?: string;
  workingYears?: number;
  static names(): { [key: string]: string } {
    return {
      age: 'age',
      avatar: 'avatar',
      beginWorkTime: 'beginWorkTime',
      birthday: 'birthday',
      email: 'email',
      englishName: 'englishName',
      graduateTime: 'graduateTime',
      highestEducation: 'highestEducation',
      jobTitle: 'jobTitle',
      lastSchoolName: 'lastSchoolName',
      married: 'married',
      name: 'name',
      nativePlace: 'nativePlace',
      nowLocation: 'nowLocation',
      personalHonor: 'personalHonor',
      phoneNum: 'phoneNum',
      politicalStatus: 'politicalStatus',
      selfEvaluation: 'selfEvaluation',
      sex: 'sex',
      virtualPhoneNum: 'virtualPhoneNum',
      workingYears: 'workingYears',
    };
  }

  static types(): { [key: string]: any } {
    return {
      age: 'number',
      avatar: 'string',
      beginWorkTime: 'string',
      birthday: 'string',
      email: 'string',
      englishName: 'string',
      graduateTime: 'string',
      highestEducation: 'number',
      jobTitle: 'string',
      lastSchoolName: 'string',
      married: 'number',
      name: 'string',
      nativePlace: 'string',
      nowLocation: 'string',
      personalHonor: 'string',
      phoneNum: 'string',
      politicalStatus: 'number',
      selfEvaluation: 'string',
      sex: 'number',
      virtualPhoneNum: 'string',
      workingYears: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataCertificates extends $tea.Model {
  certificateName?: string;
  grantTime?: string;
  static names(): { [key: string]: string } {
    return {
      certificateName: 'certificateName',
      grantTime: 'grantTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certificateName: 'string',
      grantTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataEducationExperiences extends $tea.Model {
  degree?: number;
  department?: string;
  description?: string;
  endDate?: string;
  major?: string;
  schoolName?: string;
  startDate?: string;
  static names(): { [key: string]: string } {
    return {
      degree: 'degree',
      department: 'department',
      description: 'description',
      endDate: 'endDate',
      major: 'major',
      schoolName: 'schoolName',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      degree: 'number',
      department: 'string',
      description: 'string',
      endDate: 'string',
      major: 'string',
      schoolName: 'string',
      startDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataJobExpect extends $tea.Model {
  jobName?: string;
  locations?: string[];
  maxSalary?: string;
  minSalary?: string;
  onboardTime?: string;
  static names(): { [key: string]: string } {
    return {
      jobName: 'jobName',
      locations: 'locations',
      maxSalary: 'maxSalary',
      minSalary: 'minSalary',
      onboardTime: 'onboardTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobName: 'string',
      locations: { 'type': 'array', 'itemType': 'string' },
      maxSalary: 'string',
      minSalary: 'string',
      onboardTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataLanguageSkill extends $tea.Model {
  certificateName?: string;
  languageName?: string;
  static names(): { [key: string]: string } {
    return {
      certificateName: 'certificateName',
      languageName: 'languageName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certificateName: 'string',
      languageName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataTrainingExperiences extends $tea.Model {
  description?: string;
  endDate?: string;
  institutionName?: string;
  location?: string;
  name?: string;
  startDate?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      endDate: 'endDate',
      institutionName: 'institutionName',
      location: 'location',
      name: 'name',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      endDate: 'string',
      institutionName: 'string',
      location: 'string',
      name: 'string',
      startDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeDataWorkExperiences extends $tea.Model {
  companyName?: string;
  department?: string;
  description?: string;
  endDate?: string;
  jobTitle?: string;
  location?: string;
  responsibility?: string;
  startDate?: string;
  static names(): { [key: string]: string } {
    return {
      companyName: 'companyName',
      department: 'department',
      description: 'description',
      endDate: 'endDate',
      jobTitle: 'jobTitle',
      location: 'location',
      responsibility: 'responsibility',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyName: 'string',
      department: 'string',
      description: 'string',
      endDate: 'string',
      jobTitle: 'string',
      location: 'string',
      responsibility: 'string',
      startDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeData extends $tea.Model {
  baseInfo?: CollectResumeDetailRequestResumeDataBaseInfo;
  certificates?: CollectResumeDetailRequestResumeDataCertificates[];
  educationExperiences?: CollectResumeDetailRequestResumeDataEducationExperiences[];
  jobExpect?: CollectResumeDetailRequestResumeDataJobExpect;
  languageSkill?: CollectResumeDetailRequestResumeDataLanguageSkill[];
  trainingExperiences?: CollectResumeDetailRequestResumeDataTrainingExperiences[];
  workExperiences?: CollectResumeDetailRequestResumeDataWorkExperiences[];
  static names(): { [key: string]: string } {
    return {
      baseInfo: 'baseInfo',
      certificates: 'certificates',
      educationExperiences: 'educationExperiences',
      jobExpect: 'jobExpect',
      languageSkill: 'languageSkill',
      trainingExperiences: 'trainingExperiences',
      workExperiences: 'workExperiences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      baseInfo: CollectResumeDetailRequestResumeDataBaseInfo,
      certificates: { 'type': 'array', 'itemType': CollectResumeDetailRequestResumeDataCertificates },
      educationExperiences: { 'type': 'array', 'itemType': CollectResumeDetailRequestResumeDataEducationExperiences },
      jobExpect: CollectResumeDetailRequestResumeDataJobExpect,
      languageSkill: { 'type': 'array', 'itemType': CollectResumeDetailRequestResumeDataLanguageSkill },
      trainingExperiences: { 'type': 'array', 'itemType': CollectResumeDetailRequestResumeDataTrainingExperiences },
      workExperiences: { 'type': 'array', 'itemType': CollectResumeDetailRequestResumeDataWorkExperiences },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeDetailRequestResumeFile extends $tea.Model {
  downloadUrl?: string;
  fileName?: string;
  fileType?: string;
  static names(): { [key: string]: string } {
    return {
      downloadUrl: 'downloadUrl',
      fileName: 'fileName',
      fileType: 'fileType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUrl: 'string',
      fileName: 'string',
      fileType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CollectResumeMailRequestResumeFile extends $tea.Model {
  downloadUrl?: string;
  fileName?: string;
  fileType?: string;
  static names(): { [key: string]: string } {
    return {
      downloadUrl: 'downloadUrl',
      fileName: 'fileName',
      fileType: 'fileType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUrl: 'string',
      fileName: 'string',
      fileType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobAuthResponseBodyJobOwners extends $tea.Model {
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

export class QueryInterviewsResponseBodyListInterviewers extends $tea.Model {
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

export class QueryInterviewsResponseBodyList extends $tea.Model {
  cancelled?: boolean;
  creatorUserId?: string;
  endTimeMillis?: number;
  interviewId?: string;
  interviewers?: QueryInterviewsResponseBodyListInterviewers[];
  jobId?: string;
  startTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      cancelled: 'cancelled',
      creatorUserId: 'creatorUserId',
      endTimeMillis: 'endTimeMillis',
      interviewId: 'interviewId',
      interviewers: 'interviewers',
      jobId: 'jobId',
      startTimeMillis: 'startTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cancelled: 'boolean',
      creatorUserId: 'string',
      endTimeMillis: 'number',
      interviewId: 'string',
      interviewers: { 'type': 'array', 'itemType': QueryInterviewsResponseBodyListInterviewers },
      jobId: 'string',
      startTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplicationRegFormRequestDingPanFile extends $tea.Model {
  fileId?: string;
  fileName?: string;
  fileSize?: number;
  fileType?: string;
  spaceId?: number;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileSize: 'number',
      fileType: 'string',
      spaceId: 'number',
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


  async addApplicationRegFormTemplateWithOptions(request: AddApplicationRegFormTemplateRequest, headers: AddApplicationRegFormTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<AddApplicationRegFormTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

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
      action: "AddApplicationRegFormTemplate",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/flows/applicationRegForms/templates`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddApplicationRegFormTemplateResponse>(await this.execute(params, req, runtime), new AddApplicationRegFormTemplateResponse({}));
  }

  async addApplicationRegFormTemplate(request: AddApplicationRegFormTemplateRequest): Promise<AddApplicationRegFormTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddApplicationRegFormTemplateHeaders({ });
    return await this.addApplicationRegFormTemplateWithOptions(request, headers, runtime);
  }

  async addFileWithOptions(request: AddFileRequest, headers: AddFileHeaders, runtime: $Util.RuntimeOptions): Promise<AddFileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

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
      action: "AddFile",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/files`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddFileResponse>(await this.execute(params, req, runtime), new AddFileResponse({}));
  }

  async addFile(request: AddFileRequest): Promise<AddFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFileHeaders({ });
    return await this.addFileWithOptions(request, headers, runtime);
  }

  async addUserAccountWithOptions(request: AddUserAccountRequest, headers: AddUserAccountHeaders, runtime: $Util.RuntimeOptions): Promise<AddUserAccountResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelAccountName)) {
      body["channelAccountName"] = request.channelAccountName;
    }

    if (!Util.isUnset(request.channelUserIdentify)) {
      body["channelUserIdentify"] = request.channelUserIdentify;
    }

    if (!Util.isUnset(request.phoneNumber)) {
      body["phoneNumber"] = request.phoneNumber;
    }

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
      action: "AddUserAccount",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/channels/users/accounts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddUserAccountResponse>(await this.execute(params, req, runtime), new AddUserAccountResponse({}));
  }

  async addUserAccount(request: AddUserAccountRequest): Promise<AddUserAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddUserAccountHeaders({ });
    return await this.addUserAccountWithOptions(request, headers, runtime);
  }

  async collectRecruitJobDetailWithOptions(request: CollectRecruitJobDetailRequest, headers: CollectRecruitJobDetailHeaders, runtime: $Util.RuntimeOptions): Promise<CollectRecruitJobDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.jobInfo)) {
      body["jobInfo"] = request.jobInfo;
    }

    if (!Util.isUnset(request.outCorpId)) {
      body["outCorpId"] = request.outCorpId;
    }

    if (!Util.isUnset(request.outCorpName)) {
      body["outCorpName"] = request.outCorpName;
    }

    if (!Util.isUnset(request.recruitUserInfo)) {
      body["recruitUserInfo"] = request.recruitUserInfo;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.updateTime)) {
      body["updateTime"] = request.updateTime;
    }

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
      action: "CollectRecruitJobDetail",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/channels/jobs/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollectRecruitJobDetailResponse>(await this.execute(params, req, runtime), new CollectRecruitJobDetailResponse({}));
  }

  async collectRecruitJobDetail(request: CollectRecruitJobDetailRequest): Promise<CollectRecruitJobDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollectRecruitJobDetailHeaders({ });
    return await this.collectRecruitJobDetailWithOptions(request, headers, runtime);
  }

  async collectResumeDetailWithOptions(request: CollectResumeDetailRequest, headers: CollectResumeDetailHeaders, runtime: $Util.RuntimeOptions): Promise<CollectResumeDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCode)) {
      body["channelCode"] = request.channelCode;
    }

    if (!Util.isUnset(request.channelOuterId)) {
      body["channelOuterId"] = request.channelOuterId;
    }

    if (!Util.isUnset(request.channelTalentId)) {
      body["channelTalentId"] = request.channelTalentId;
    }

    if (!Util.isUnset(request.deliverJobId)) {
      body["deliverJobId"] = request.deliverJobId;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.resumeChannelUrl)) {
      body["resumeChannelUrl"] = request.resumeChannelUrl;
    }

    if (!Util.isUnset(request.resumeData)) {
      body["resumeData"] = request.resumeData;
    }

    if (!Util.isUnset(request.resumeFile)) {
      body["resumeFile"] = request.resumeFile;
    }

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
      action: "CollectResumeDetail",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/resumes/details`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollectResumeDetailResponse>(await this.execute(params, req, runtime), new CollectResumeDetailResponse({}));
  }

  async collectResumeDetail(request: CollectResumeDetailRequest): Promise<CollectResumeDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollectResumeDetailHeaders({ });
    return await this.collectResumeDetailWithOptions(request, headers, runtime);
  }

  async collectResumeMailWithOptions(request: CollectResumeMailRequest, headers: CollectResumeMailHeaders, runtime: $Util.RuntimeOptions): Promise<CollectResumeMailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelCode)) {
      body["channelCode"] = request.channelCode;
    }

    if (!Util.isUnset(request.deliverJobId)) {
      body["deliverJobId"] = request.deliverJobId;
    }

    if (!Util.isUnset(request.fromMailAddress)) {
      body["fromMailAddress"] = request.fromMailAddress;
    }

    if (!Util.isUnset(request.historyMailImport)) {
      body["historyMailImport"] = request.historyMailImport;
    }

    if (!Util.isUnset(request.mailId)) {
      body["mailId"] = request.mailId;
    }

    if (!Util.isUnset(request.mailTitle)) {
      body["mailTitle"] = request.mailTitle;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.receiveMailAddress)) {
      body["receiveMailAddress"] = request.receiveMailAddress;
    }

    if (!Util.isUnset(request.receiveMailType)) {
      body["receiveMailType"] = request.receiveMailType;
    }

    if (!Util.isUnset(request.receivedTime)) {
      body["receivedTime"] = request.receivedTime;
    }

    if (!Util.isUnset(request.resumeChannelUrl)) {
      body["resumeChannelUrl"] = request.resumeChannelUrl;
    }

    if (!Util.isUnset(request.resumeFile)) {
      body["resumeFile"] = request.resumeFile;
    }

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
      action: "CollectResumeMail",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/resumes/mails`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CollectResumeMailResponse>(await this.execute(params, req, runtime), new CollectResumeMailResponse({}));
  }

  async collectResumeMail(request: CollectResumeMailRequest): Promise<CollectResumeMailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollectResumeMailHeaders({ });
    return await this.collectResumeMailWithOptions(request, headers, runtime);
  }

  async confirmRightsWithOptions(rightsCode: string, request: ConfirmRightsRequest, headers: ConfirmRightsHeaders, runtime: $Util.RuntimeOptions): Promise<ConfirmRightsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

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
      action: "ConfirmRights",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/rights/${rightsCode}/confirm`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConfirmRightsResponse>(await this.execute(params, req, runtime), new ConfirmRightsResponse({}));
  }

  async confirmRights(rightsCode: string, request: ConfirmRightsRequest): Promise<ConfirmRightsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConfirmRightsHeaders({ });
    return await this.confirmRightsWithOptions(rightsCode, request, headers, runtime);
  }

  async finishBeginnerTaskWithOptions(taskCode: string, request: FinishBeginnerTaskRequest, headers: FinishBeginnerTaskHeaders, runtime: $Util.RuntimeOptions): Promise<FinishBeginnerTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scope)) {
      query["scope"] = request.scope;
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
      action: "FinishBeginnerTask",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/beginnerTasks/${taskCode}/finish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<FinishBeginnerTaskResponse>(await this.execute(params, req, runtime), new FinishBeginnerTaskResponse({}));
  }

  async finishBeginnerTask(taskCode: string, request: FinishBeginnerTaskRequest): Promise<FinishBeginnerTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishBeginnerTaskHeaders({ });
    return await this.finishBeginnerTaskWithOptions(taskCode, request, headers, runtime);
  }

  async getApplicationRegFormByFlowIdWithOptions(flowId: string, request: GetApplicationRegFormByFlowIdRequest, headers: GetApplicationRegFormByFlowIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplicationRegFormByFlowIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

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
      action: "GetApplicationRegFormByFlowId",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/flows/${flowId}/applicationRegForms`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetApplicationRegFormByFlowIdResponse>(await this.execute(params, req, runtime), new GetApplicationRegFormByFlowIdResponse({}));
  }

  async getApplicationRegFormByFlowId(flowId: string, request: GetApplicationRegFormByFlowIdRequest): Promise<GetApplicationRegFormByFlowIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationRegFormByFlowIdHeaders({ });
    return await this.getApplicationRegFormByFlowIdWithOptions(flowId, request, headers, runtime);
  }

  async getCandidateByPhoneNumberWithOptions(request: GetCandidateByPhoneNumberRequest, headers: GetCandidateByPhoneNumberHeaders, runtime: $Util.RuntimeOptions): Promise<GetCandidateByPhoneNumberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.phoneNumber)) {
      query["phoneNumber"] = request.phoneNumber;
    }

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
      action: "GetCandidateByPhoneNumber",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/candidates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetCandidateByPhoneNumberResponse>(await this.execute(params, req, runtime), new GetCandidateByPhoneNumberResponse({}));
  }

  async getCandidateByPhoneNumber(request: GetCandidateByPhoneNumberRequest): Promise<GetCandidateByPhoneNumberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCandidateByPhoneNumberHeaders({ });
    return await this.getCandidateByPhoneNumberWithOptions(request, headers, runtime);
  }

  async getFileUploadInfoWithOptions(request: GetFileUploadInfoRequest, headers: GetFileUploadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileUploadInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileSize)) {
      query["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.md5)) {
      query["md5"] = request.md5;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "GetFileUploadInfo",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/files/uploadInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFileUploadInfoResponse>(await this.execute(params, req, runtime), new GetFileUploadInfoResponse({}));
  }

  async getFileUploadInfo(request: GetFileUploadInfoRequest): Promise<GetFileUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadInfoHeaders({ });
    return await this.getFileUploadInfoWithOptions(request, headers, runtime);
  }

  async getFlowIdByRelationEntityIdWithOptions(request: GetFlowIdByRelationEntityIdRequest, headers: GetFlowIdByRelationEntityIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowIdByRelationEntityIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.relationEntity)) {
      query["relationEntity"] = request.relationEntity;
    }

    if (!Util.isUnset(request.relationEntityId)) {
      query["relationEntityId"] = request.relationEntityId;
    }

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
      action: "GetFlowIdByRelationEntityId",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/flows/ids`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFlowIdByRelationEntityIdResponse>(await this.execute(params, req, runtime), new GetFlowIdByRelationEntityIdResponse({}));
  }

  async getFlowIdByRelationEntityId(request: GetFlowIdByRelationEntityIdRequest): Promise<GetFlowIdByRelationEntityIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowIdByRelationEntityIdHeaders({ });
    return await this.getFlowIdByRelationEntityIdWithOptions(request, headers, runtime);
  }

  async getJobAuthWithOptions(jobId: string, request: GetJobAuthRequest, headers: GetJobAuthHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobAuthResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

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
      action: "GetJobAuth",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/auths/jobs/${jobId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetJobAuthResponse>(await this.execute(params, req, runtime), new GetJobAuthResponse({}));
  }

  async getJobAuth(jobId: string, request: GetJobAuthRequest): Promise<GetJobAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobAuthHeaders({ });
    return await this.getJobAuthWithOptions(jobId, request, headers, runtime);
  }

  async queryInterviewsWithOptions(request: QueryInterviewsRequest, headers: QueryInterviewsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInterviewsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.candidateId)) {
      body["candidateId"] = request.candidateId;
    }

    if (!Util.isUnset(request.startTimeBeginMillis)) {
      body["startTimeBeginMillis"] = request.startTimeBeginMillis;
    }

    if (!Util.isUnset(request.startTimeEndMillis)) {
      body["startTimeEndMillis"] = request.startTimeEndMillis;
    }

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
      action: "QueryInterviews",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/interviews/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryInterviewsResponse>(await this.execute(params, req, runtime), new QueryInterviewsResponse({}));
  }

  async queryInterviews(request: QueryInterviewsRequest): Promise<QueryInterviewsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInterviewsHeaders({ });
    return await this.queryInterviewsWithOptions(request, headers, runtime);
  }

  async reportMessageStatusWithOptions(request: ReportMessageStatusRequest, headers: ReportMessageStatusHeaders, runtime: $Util.RuntimeOptions): Promise<ReportMessageStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.errorCode)) {
      body["errorCode"] = request.errorCode;
    }

    if (!Util.isUnset(request.errorMsg)) {
      body["errorMsg"] = request.errorMsg;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
    }

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
      action: "ReportMessageStatus",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/channels/messages/statuses/report`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReportMessageStatusResponse>(await this.execute(params, req, runtime), new ReportMessageStatusResponse({}));
  }

  async reportMessageStatus(request: ReportMessageStatusRequest): Promise<ReportMessageStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportMessageStatusHeaders({ });
    return await this.reportMessageStatusWithOptions(request, headers, runtime);
  }

  async syncChannelMessageWithOptions(request: SyncChannelMessageRequest, headers: SyncChannelMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SyncChannelMessageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

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
      action: "SyncChannelMessage",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/channels/messages/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncChannelMessageResponse>(await this.execute(params, req, runtime), new SyncChannelMessageResponse({}));
  }

  async syncChannelMessage(request: SyncChannelMessageRequest): Promise<SyncChannelMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncChannelMessageHeaders({ });
    return await this.syncChannelMessageWithOptions(request, headers, runtime);
  }

  async updateApplicationRegFormWithOptions(flowId: string, request: UpdateApplicationRegFormRequest, headers: UpdateApplicationRegFormHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateApplicationRegFormResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.dingPanFile)) {
      body["dingPanFile"] = request.dingPanFile;
    }

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
      action: "UpdateApplicationRegForm",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/flows/${flowId}/applicationRegForms`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateApplicationRegFormResponse>(await this.execute(params, req, runtime), new UpdateApplicationRegFormResponse({}));
  }

  async updateApplicationRegForm(flowId: string, request: UpdateApplicationRegFormRequest): Promise<UpdateApplicationRegFormResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateApplicationRegFormHeaders({ });
    return await this.updateApplicationRegFormWithOptions(flowId, request, headers, runtime);
  }

  async updateInterviewSignInInfoWithOptions(interviewId: string, request: UpdateInterviewSignInInfoRequest, headers: UpdateInterviewSignInInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInterviewSignInInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.signInTimeMillis)) {
      body["signInTimeMillis"] = request.signInTimeMillis;
    }

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
      action: "UpdateInterviewSignInInfo",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/interviews/${interviewId}/signInInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateInterviewSignInInfoResponse>(await this.execute(params, req, runtime), new UpdateInterviewSignInInfoResponse({}));
  }

  async updateInterviewSignInInfo(interviewId: string, request: UpdateInterviewSignInInfoRequest): Promise<UpdateInterviewSignInInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInterviewSignInInfoHeaders({ });
    return await this.updateInterviewSignInInfoWithOptions(interviewId, request, headers, runtime);
  }

  async updateJobDeliverWithOptions(request: UpdateJobDeliverRequest, headers: UpdateJobDeliverHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateJobDeliverResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.jobId)) {
      query["jobId"] = request.jobId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channelOuterId)) {
      body["channelOuterId"] = request.channelOuterId;
    }

    if (!Util.isUnset(request.deliverUserId)) {
      body["deliverUserId"] = request.deliverUserId;
    }

    if (!Util.isUnset(request.errorCode)) {
      body["errorCode"] = request.errorCode;
    }

    if (!Util.isUnset(request.errorMsg)) {
      body["errorMsg"] = request.errorMsg;
    }

    if (!Util.isUnset(request.opTime)) {
      body["opTime"] = request.opTime;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

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
      action: "UpdateJobDeliver",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/jobs/deliveryStatus`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateJobDeliverResponse>(await this.execute(params, req, runtime), new UpdateJobDeliverResponse({}));
  }

  async updateJobDeliver(request: UpdateJobDeliverRequest): Promise<UpdateJobDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateJobDeliverHeaders({ });
    return await this.updateJobDeliverWithOptions(request, headers, runtime);
  }

}
