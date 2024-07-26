// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"key":"value"}
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 应聘登记表
   */
  name?: string;
  /**
   * @example
   * xxx
   */
  outerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxx
   */
  templateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddApplicationRegFormTemplateResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三的简历
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  mediaId?: string;
  /**
   * @example
   * manager5875
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111111
   */
  fileId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三的简历
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddFileResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @example
   * 示例昵称xxx
   */
  channelAccountName?: string;
  /**
   * @example
   * 6FSe51616SOdd394d6
   */
  channelUserIdentify?: string;
  /**
   * @example
   * 16600010001
   */
  phoneNumber?: string;
  /**
   * @example
   * ding123456789
   */
  corpId?: string;
  /**
   * @example
   * 1676451039
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddUserAccountResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @example
   * zhilian
   */
  channel?: string;
  jobInfo?: CollectRecruitJobDetailRequestJobInfo;
  /**
   * @example
   * corpxxxxxxxxx
   */
  outCorpId?: string;
  /**
   * @example
   * 小莫科技有限公司
   */
  outCorpName?: string;
  recruitUserInfo?: CollectRecruitJobDetailRequestRecruitUserInfo;
  /**
   * @example
   * BOSS
   */
  source?: string;
  /**
   * @example
   * 1677465956008
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CollectRecruitJobDetailResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @example
   * liepin
   */
  channelCode?: string;
  /**
   * @example
   * resumexxxxxxxxxx
   */
  channelOuterId?: string;
  /**
   * @example
   * xxxxxx
   */
  channelTalentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * jobId8fc0d56a605d495ea0214af7axxxxxxx
   */
  deliverJobId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2701606624233xxxxx
   */
  optUserId?: string;
  /**
   * @example
   * http:www.xxx.com
   */
  resumeChannelUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CollectResumeDetailResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * liepin
   */
  channelCode?: string;
  /**
   * @example
   * jobId8fc0d56a605d495ea0214af7axxxxxxx
   */
  deliverJobId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx@163.com
   */
  fromMailAddress?: string;
  historyMailImport?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxxxx
   */
  mailId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxx应聘贵公司xxx职位
   */
  mailTitle?: string;
  /**
   * @example
   * 2701606624233xxxxx
   */
  optUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx@163.com
   */
  receiveMailAddress?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  receiveMailType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  receivedTime?: number;
  /**
   * @example
   * http:www.xxx.com
   */
  resumeChannelUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CollectResumeMailResponseBody;
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
  /**
   * @example
   * ddats
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConfirmRightsResponseBody;
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
  /**
   * @example
   * advancedBeginnerTask
   */
  scope?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager5875
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FinishBeginnerTaskResponseBody;
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
  /**
   * @example
   * ddats
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  candidateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager5875
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * flowXXX
   */
  flowId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * formXXX
   */
  formId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626775016427
   */
  gmtCreateMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626775016427
   */
  gmtModifiedMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * jobXXX
   */
  jobId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * templateXXX
   */
  templateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetApplicationRegFormByFlowIdResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13688888888
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  candidateId?: string;
  /**
   * @example
   * 张三
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCandidateByPhoneNumberResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三的简历
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1024
   */
  fileSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  md5?: string;
  /**
   * @example
   * manager5875
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  accessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  accessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  accessToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626923829000
   */
  accessTokenExpirationMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lippi-space-zjk
   */
  bucket?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * oss-cn-zhangjiakou.aliyuncs.com
   */
  endPoint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFileUploadInfoResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * interview
   */
  relationEntity?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFlowIdByRelationEntityIdResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetJobAuthResponseBody;
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

export class ImportJobDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ImportJobDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  body?: ImportJobDataRequestBody[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': ImportJobDataRequestBody },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ImportJobDataResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ImportJobDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ImportJobDataResponseBody;
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
      body: ImportJobDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCandidatesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCandidatesRequest extends $tea.Model {
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * 154XXX
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * entry
   */
  statId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 013224566462XXXXXXXXXX
   */
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      statId: 'statId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      statId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCandidatesResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryCandidatesResponseBodyList[];
  /**
   * @example
   * xxxxxx
   */
  nextToken?: number;
  /**
   * @example
   * 100
   */
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
      list: { 'type': 'array', 'itemType': QueryCandidatesResponseBodyList },
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCandidatesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCandidatesResponseBody;
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
      body: QueryCandidatesResponseBody,
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  candidateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626796800000
   */
  startTimeBeginMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626883199000
   */
  startTimeEndMillis?: number;
  /**
   * @example
   * xxx
   */
  nextToken?: string;
  /**
   * @example
   * 10
   */
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
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  list?: QueryInterviewsResponseBodyList[];
  /**
   * @example
   * xxx
   */
  nextToken?: string;
  /**
   * @example
   * 总数量
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryInterviewsResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @example
   * corp-ABC-prd
   */
  channel?: string;
  /**
   * @example
   * INVALID_USER
   */
  errorCode?: string;
  /**
   * @example
   * 无效用户
   */
  errorMsg?: string;
  /**
   * @example
   * 594c5b30-57bd-4001-8903-4dc64cdc6739
   */
  messageId?: string;
  /**
   * @example
   * AppUid@Channel
   */
  receiverUserId?: string;
  /**
   * @example
   * AppUid@Channel
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReportMessageStatusResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @example
   * Corp-ABC-prd
   */
  channel?: string;
  /**
   * @example
   * {"msgtype":"text","text":{"content":"月会通知"}}
   */
  content?: string;
  /**
   * @example
   * 1667964772048
   */
  createTime?: number;
  /**
   * @example
   * AppUid@Channel
   */
  receiverUserId?: string;
  /**
   * @example
   * AppUid@Channel
   */
  senderUserId?: string;
  /**
   * @example
   * 594c5b30-57bd-4001-8903-4dc64cdc6739
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncChannelMessageResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"key":"value"}
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager5875
   */
  creatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * formXXX
   */
  formId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626775016427
   */
  gmtCreateMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626775016427
   */
  gmtModifiedMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * templateXXX
   */
  templateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateApplicationRegFormResponseBody;
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
  /**
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1626796800000
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ddats
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * channelOuterId
   */
  channelOuterId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27016066248xxxxx
   */
  deliverUserId?: string;
  /**
   * @example
   * ATS001
   */
  errorCode?: string;
  /**
   * @example
   * 职位审核不通过
   */
  errorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1666780239981
   */
  opTime?: number;
  /**
   * @example
   * 27016066248xxxxx
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * jobId23ed0d46548f4e88a7b808d3f3057xxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateJobDeliverResponseBody;
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
  /**
   * @example
   * 310000
   */
  cityCode?: string;
  /**
   * @example
   * 文一西路999号
   */
  detail?: string;
  /**
   * @example
   * 311000
   */
  districtCode?: string;
  /**
   * @example
   * 89.54613
   */
  latitude?: string;
  /**
   * @example
   * 128.45613
   */
  longitude?: string;
  /**
   * @example
   * 总部大楼
   */
  name?: string;
  /**
   * @example
   * 300000
   */
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
  /**
   * @example
   * 20
   */
  maxJobExperience?: string;
  /**
   * @example
   * 2
   */
  minJobExperience?: string;
  /**
   * @example
   * 12
   */
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
  /**
   * @example
   * 158****8718
   */
  contactNumber?: string;
  /**
   * @example
   * MONTH
   */
  salaryPeriod?: string;
  /**
   * @example
   * MONTH
   */
  settleType?: string;
  /**
   * @example
   * N
   */
  specifyWorkDate?: string;
  /**
   * @example
   * N
   */
  specifyWorkTime?: string;
  /**
   * @example
   * 480
   */
  workBeginTimeMin?: string;
  /**
   * @example
   * WORKDAY
   */
  workDateType?: string;
  /**
   * @example
   * 2024-02-18
   */
  workEndDate?: string;
  /**
   * @example
   * 1080
   */
  workEndTimeMin?: string;
  /**
   * @example
   * 2023-02-18
   */
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
  /**
   * @example
   * C10001
   */
  category?: string;
  /**
   * @example
   * 园艺师职位描述
   */
  description?: string;
  extInfo?: string;
  fullTimeInfo?: CollectRecruitJobDetailRequestJobInfoFullTimeInfo;
  /**
   * @example
   * 20
   */
  headCount?: string;
  /**
   * @example
   * FULL-TIME
   */
  jobNature?: string;
  jobTags?: string[];
  /**
   * @example
   * 8000
   */
  maxSalary?: string;
  /**
   * @example
   * 3000
   */
  minSalary?: string;
  /**
   * @example
   * 园艺师
   */
  name?: string;
  /**
   * @example
   * jobIdxxxxxxx
   */
  outJobId?: string;
  partTimeInfo?: CollectRecruitJobDetailRequestJobInfoPartTimeInfo;
  /**
   * @example
   * 高中
   */
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
  /**
   * @example
   * {"sex":"male"}
   */
  extInfo?: string;
  /**
   * @example
   * userxxxxx
   */
  outUserId?: string;
  /**
   * @example
   * 158****8717
   */
  userMobile?: string;
  /**
   * @example
   * 陈*
   */
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
  /**
   * @example
   * 18
   */
  age?: number;
  /**
   * @example
   * http://www.xxxx.com
   */
  avatar?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  beginWorkTime?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  birthday?: string;
  /**
   * @example
   * xxxxxxx@alibaba-inc.com
   */
  email?: string;
  /**
   * @example
   * Jason
   */
  englishName?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  graduateTime?: string;
  /**
   * @example
   * 1
   */
  highestEducation?: number;
  /**
   * @example
   * java开发工程师
   */
  jobTitle?: string;
  /**
   * @example
   * 清华大学
   */
  lastSchoolName?: string;
  /**
   * @example
   * 1
   */
  married?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 孙先生
   */
  name?: string;
  /**
   * @example
   * 浙江省杭州市余杭区仓前街道
   */
  nativePlace?: string;
  /**
   * @example
   * 浙江省杭州市余杭区仓前街道欧美金融城
   */
  nowLocation?: string;
  /**
   * @example
   * 曾获得xxx比赛xxx奖项
   */
  personalHonor?: string;
  /**
   * @example
   * 187xxxxxxxx
   */
  phoneNum?: string;
  /**
   * @example
   * 1
   */
  politicalStatus?: number;
  /**
   * @example
   * 沟通能力强......
   */
  selfEvaluation?: string;
  /**
   * @example
   * 1
   */
  sex?: number;
  /**
   * @example
   * 187xxxxxxxx
   */
  virtualPhoneNum?: string;
  /**
   * @example
   * 3
   */
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
  /**
   * @example
   * 高级技工证书
   */
  certificateName?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
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
  /**
   * @example
   * 1
   */
  degree?: number;
  /**
   * @example
   * 计算机学院
   */
  department?: string;
  /**
   * @example
   * 在校期间.......
   */
  description?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  endDate?: string;
  /**
   * @example
   * 计算机科学与技术
   */
  major?: string;
  /**
   * @example
   * 清华大学
   */
  schoolName?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
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
  /**
   * @example
   * Java开发工程师
   */
  jobName?: string;
  locations?: string[];
  /**
   * @example
   * 8000
   */
  maxSalary?: string;
  /**
   * @example
   * 3000
   */
  minSalary?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
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
  /**
   * @example
   * 大学英语六级
   */
  certificateName?: string;
  /**
   * @example
   * 英语
   */
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
  /**
   * @example
   * 培训期间，学习了xxxx技能，获取xxxx证书。
   */
  description?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  endDate?: string;
  /**
   * @example
   * 新东方挖掘机学校
   */
  institutionName?: string;
  /**
   * @example
   * 浙江省杭州市余杭区
   */
  location?: string;
  /**
   * @example
   * 挖掘机专业技能培训
   */
  name?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
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
  /**
   * @example
   * 钉钉（中国）信息技术有限公司
   */
  companyName?: string;
  /**
   * @example
   * 智能人事
   */
  department?: string;
  /**
   * @example
   * 工作期间负责......取得了......成果
   */
  description?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
  endDate?: string;
  /**
   * @example
   * Java开发工程师
   */
  jobTitle?: string;
  /**
   * @example
   * 杭州
   */
  location?: string;
  /**
   * @example
   * 负责......
   */
  responsibility?: string;
  /**
   * @example
   * yyyy-MM-dd
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * http:www.xxx.com
   */
  downloadUrl?: string;
  /**
   * @example
   * xxx.pdf
   */
  fileName?: string;
  /**
   * @example
   * pdf
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * http:www.xxx.com
   */
  downloadUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx的简历.pdf
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * pdf
   */
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

export class ImportJobDataRequestBodyAddress extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  cityCode?: string;
  customName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  districtCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  latitude?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  longitude?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      cityCode: 'cityCode',
      customName: 'customName',
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
      customName: 'string',
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

export class ImportJobDataRequestBodyFullTimeExt extends $tea.Model {
  salaryMonth?: number;
  static names(): { [key: string]: string } {
    return {
      salaryMonth: 'salaryMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      salaryMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ImportJobDataRequestBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  address?: ImportJobDataRequestBodyAddress;
  /**
   * @remarks
   * This parameter is required.
   */
  category?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  experience?: string;
  fullTimeExt?: ImportJobDataRequestBodyFullTimeExt;
  /**
   * @remarks
   * This parameter is required.
   */
  jobNature?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  maxSalary?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  minSalary?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  requiredEdu?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      category: 'category',
      description: 'description',
      experience: 'experience',
      fullTimeExt: 'fullTimeExt',
      jobNature: 'jobNature',
      maxSalary: 'maxSalary',
      minSalary: 'minSalary',
      name: 'name',
      requiredEdu: 'requiredEdu',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: ImportJobDataRequestBodyAddress,
      category: 'string',
      description: 'string',
      experience: 'string',
      fullTimeExt: ImportJobDataRequestBodyFullTimeExt,
      jobNature: 'string',
      maxSalary: 'number',
      minSalary: 'number',
      name: 'string',
      requiredEdu: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCandidatesResponseBodyList extends $tea.Model {
  /**
   * @example
   * 64167133e3394c6b9959eexxxxxxxxxx
   */
  candidateId?: string;
  /**
   * @example
   * ding2c0158xxxxxxxxxx
   */
  corpId?: string;
  /**
   * @example
   * 1701014400000
   */
  entryDate?: number;
  /**
   * @example
   * 013224566462xxxxxxxxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      candidateId: 'candidateId',
      corpId: 'corpId',
      entryDate: 'entryDate',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      candidateId: 'string',
      corpId: 'string',
      entryDate: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInterviewsResponseBodyListInterviewers extends $tea.Model {
  /**
   * @example
   * xxx
   */
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
  /**
   * @example
   * false
   */
  cancelled?: boolean;
  /**
   * @example
   * xxx
   */
  creatorUserId?: string;
  /**
   * @example
   * 1626861600000
   */
  endTimeMillis?: number;
  /**
   * @example
   * xxx
   */
  interviewId?: string;
  interviewers?: QueryInterviewsResponseBodyListInterviewers[];
  /**
   * @example
   * xxx
   */
  jobId?: string;
  /**
   * @example
   * 1626858000000
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "123456"
   */
  fileId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "张三的应聘登记表（开发工程师）"
   */
  fileName?: string;
  /**
   * @example
   * 1024
   */
  fileSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * pdf
   */
  fileType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 223344
   */
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
   * 添加应聘登记表模板
   * 
   * @param request - AddApplicationRegFormTemplateRequest
   * @param headers - AddApplicationRegFormTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddApplicationRegFormTemplateResponse
   */
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

  /**
   * 添加应聘登记表模板
   * 
   * @param request - AddApplicationRegFormTemplateRequest
   * @returns AddApplicationRegFormTemplateResponse
   */
  async addApplicationRegFormTemplate(request: AddApplicationRegFormTemplateRequest): Promise<AddApplicationRegFormTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddApplicationRegFormTemplateHeaders({ });
    return await this.addApplicationRegFormTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 添加钉盘文件
   * 
   * @param request - AddFileRequest
   * @param headers - AddFileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddFileResponse
   */
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

  /**
   * 添加钉盘文件
   * 
   * @param request - AddFileRequest
   * @returns AddFileResponse
   */
  async addFile(request: AddFileRequest): Promise<AddFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFileHeaders({ });
    return await this.addFileWithOptions(request, headers, runtime);
  }

  /**
   * 添加渠道个人账号
   * 
   * @param request - AddUserAccountRequest
   * @param headers - AddUserAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddUserAccountResponse
   */
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

  /**
   * 添加渠道个人账号
   * 
   * @param request - AddUserAccountRequest
   * @returns AddUserAccountResponse
   */
  async addUserAccount(request: AddUserAccountRequest): Promise<AddUserAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddUserAccountHeaders({ });
    return await this.addUserAccountWithOptions(request, headers, runtime);
  }

  /**
   * 渠道招聘职位需求导入
   * 
   * @param request - CollectRecruitJobDetailRequest
   * @param headers - CollectRecruitJobDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CollectRecruitJobDetailResponse
   */
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

  /**
   * 渠道招聘职位需求导入
   * 
   * @param request - CollectRecruitJobDetailRequest
   * @returns CollectRecruitJobDetailResponse
   */
  async collectRecruitJobDetail(request: CollectRecruitJobDetailRequest): Promise<CollectRecruitJobDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollectRecruitJobDetailHeaders({ });
    return await this.collectRecruitJobDetailWithOptions(request, headers, runtime);
  }

  /**
   * 结构化简历信息回流
   * 
   * @param request - CollectResumeDetailRequest
   * @param headers - CollectResumeDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CollectResumeDetailResponse
   */
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

  /**
   * 结构化简历信息回流
   * 
   * @param request - CollectResumeDetailRequest
   * @returns CollectResumeDetailResponse
   */
  async collectResumeDetail(request: CollectResumeDetailRequest): Promise<CollectResumeDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollectResumeDetailHeaders({ });
    return await this.collectResumeDetailWithOptions(request, headers, runtime);
  }

  /**
   * 邮箱简历回流
   * 
   * @param request - CollectResumeMailRequest
   * @param headers - CollectResumeMailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CollectResumeMailResponse
   */
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

  /**
   * 邮箱简历回流
   * 
   * @param request - CollectResumeMailRequest
   * @returns CollectResumeMailResponse
   */
  async collectResumeMail(request: CollectResumeMailRequest): Promise<CollectResumeMailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CollectResumeMailHeaders({ });
    return await this.collectResumeMailWithOptions(request, headers, runtime);
  }

  /**
   * 确认权益
   * 
   * @param request - ConfirmRightsRequest
   * @param headers - ConfirmRightsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConfirmRightsResponse
   */
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

  /**
   * 确认权益
   * 
   * @param request - ConfirmRightsRequest
   * @returns ConfirmRightsResponse
   */
  async confirmRights(rightsCode: string, request: ConfirmRightsRequest): Promise<ConfirmRightsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConfirmRightsHeaders({ });
    return await this.confirmRightsWithOptions(rightsCode, request, headers, runtime);
  }

  /**
   * 完成指定的新手任务
   * 
   * @param request - FinishBeginnerTaskRequest
   * @param headers - FinishBeginnerTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FinishBeginnerTaskResponse
   */
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

  /**
   * 完成指定的新手任务
   * 
   * @param request - FinishBeginnerTaskRequest
   * @returns FinishBeginnerTaskResponse
   */
  async finishBeginnerTask(taskCode: string, request: FinishBeginnerTaskRequest): Promise<FinishBeginnerTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishBeginnerTaskHeaders({ });
    return await this.finishBeginnerTaskWithOptions(taskCode, request, headers, runtime);
  }

  /**
   * 获取招聘流程关联的应聘登记表信息
   * 
   * @param request - GetApplicationRegFormByFlowIdRequest
   * @param headers - GetApplicationRegFormByFlowIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetApplicationRegFormByFlowIdResponse
   */
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

  /**
   * 获取招聘流程关联的应聘登记表信息
   * 
   * @param request - GetApplicationRegFormByFlowIdRequest
   * @returns GetApplicationRegFormByFlowIdResponse
   */
  async getApplicationRegFormByFlowId(flowId: string, request: GetApplicationRegFormByFlowIdRequest): Promise<GetApplicationRegFormByFlowIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationRegFormByFlowIdHeaders({ });
    return await this.getApplicationRegFormByFlowIdWithOptions(flowId, request, headers, runtime);
  }

  /**
   * 根据手机号获取候选人信息
   * 
   * @param request - GetCandidateByPhoneNumberRequest
   * @param headers - GetCandidateByPhoneNumberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCandidateByPhoneNumberResponse
   */
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

  /**
   * 根据手机号获取候选人信息
   * 
   * @param request - GetCandidateByPhoneNumberRequest
   * @returns GetCandidateByPhoneNumberResponse
   */
  async getCandidateByPhoneNumber(request: GetCandidateByPhoneNumberRequest): Promise<GetCandidateByPhoneNumberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCandidateByPhoneNumberHeaders({ });
    return await this.getCandidateByPhoneNumberWithOptions(request, headers, runtime);
  }

  /**
   * 获取钉盘上传文件信息
   * 
   * @param request - GetFileUploadInfoRequest
   * @param headers - GetFileUploadInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFileUploadInfoResponse
   */
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

  /**
   * 获取钉盘上传文件信息
   * 
   * @param request - GetFileUploadInfoRequest
   * @returns GetFileUploadInfoResponse
   */
  async getFileUploadInfo(request: GetFileUploadInfoRequest): Promise<GetFileUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadInfoHeaders({ });
    return await this.getFileUploadInfoWithOptions(request, headers, runtime);
  }

  /**
   * 根据招聘流程关联的实体标识获取招聘流程标识
   * 
   * @param request - GetFlowIdByRelationEntityIdRequest
   * @param headers - GetFlowIdByRelationEntityIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFlowIdByRelationEntityIdResponse
   */
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

  /**
   * 根据招聘流程关联的实体标识获取招聘流程标识
   * 
   * @param request - GetFlowIdByRelationEntityIdRequest
   * @returns GetFlowIdByRelationEntityIdResponse
   */
  async getFlowIdByRelationEntityId(request: GetFlowIdByRelationEntityIdRequest): Promise<GetFlowIdByRelationEntityIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowIdByRelationEntityIdHeaders({ });
    return await this.getFlowIdByRelationEntityIdWithOptions(request, headers, runtime);
  }

  /**
   * 获取职位信息
   * 
   * @param request - GetJobAuthRequest
   * @param headers - GetJobAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetJobAuthResponse
   */
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

  /**
   * 获取职位信息
   * 
   * @param request - GetJobAuthRequest
   * @returns GetJobAuthResponse
   */
  async getJobAuth(jobId: string, request: GetJobAuthRequest): Promise<GetJobAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobAuthHeaders({ });
    return await this.getJobAuthWithOptions(jobId, request, headers, runtime);
  }

  /**
   * 导入外部渠道发布的职位数据
   * 
   * @param request - ImportJobDataRequest
   * @param headers - ImportJobDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ImportJobDataResponse
   */
  async importJobDataWithOptions(request: ImportJobDataRequest, headers: ImportJobDataHeaders, runtime: $Util.RuntimeOptions): Promise<ImportJobDataResponse> {
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
      action: "ImportJobData",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/weHire/jobs/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ImportJobDataResponse>(await this.execute(params, req, runtime), new ImportJobDataResponse({}));
  }

  /**
   * 导入外部渠道发布的职位数据
   * 
   * @param request - ImportJobDataRequest
   * @returns ImportJobDataResponse
   */
  async importJobData(request: ImportJobDataRequest): Promise<ImportJobDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ImportJobDataHeaders({ });
    return await this.importJobDataWithOptions(request, headers, runtime);
  }

  /**
   * 查询候选人详情列表
   * 
   * @param request - QueryCandidatesRequest
   * @param headers - QueryCandidatesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCandidatesResponse
   */
  async queryCandidatesWithOptions(request: QueryCandidatesRequest, headers: QueryCandidatesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCandidatesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.statId)) {
      body["statId"] = request.statId;
    }

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
      action: "QueryCandidates",
      version: "ats_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/ats/candidates/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCandidatesResponse>(await this.execute(params, req, runtime), new QueryCandidatesResponse({}));
  }

  /**
   * 查询候选人详情列表
   * 
   * @param request - QueryCandidatesRequest
   * @returns QueryCandidatesResponse
   */
  async queryCandidates(request: QueryCandidatesRequest): Promise<QueryCandidatesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCandidatesHeaders({ });
    return await this.queryCandidatesWithOptions(request, headers, runtime);
  }

  /**
   * 查询面试列表
   * 
   * @param request - QueryInterviewsRequest
   * @param headers - QueryInterviewsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryInterviewsResponse
   */
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

  /**
   * 查询面试列表
   * 
   * @param request - QueryInterviewsRequest
   * @returns QueryInterviewsResponse
   */
  async queryInterviews(request: QueryInterviewsRequest): Promise<QueryInterviewsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInterviewsHeaders({ });
    return await this.queryInterviewsWithOptions(request, headers, runtime);
  }

  /**
   * 反馈渠道消息状态
   * 
   * @param request - ReportMessageStatusRequest
   * @param headers - ReportMessageStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReportMessageStatusResponse
   */
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

  /**
   * 反馈渠道消息状态
   * 
   * @param request - ReportMessageStatusRequest
   * @returns ReportMessageStatusResponse
   */
  async reportMessageStatus(request: ReportMessageStatusRequest): Promise<ReportMessageStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportMessageStatusHeaders({ });
    return await this.reportMessageStatusWithOptions(request, headers, runtime);
  }

  /**
   * 同步渠道IM消息
   * 
   * @param request - SyncChannelMessageRequest
   * @param headers - SyncChannelMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncChannelMessageResponse
   */
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

  /**
   * 同步渠道IM消息
   * 
   * @param request - SyncChannelMessageRequest
   * @returns SyncChannelMessageResponse
   */
  async syncChannelMessage(request: SyncChannelMessageRequest): Promise<SyncChannelMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncChannelMessageHeaders({ });
    return await this.syncChannelMessageWithOptions(request, headers, runtime);
  }

  /**
   * 更新应聘登记表内容
   * 
   * @param request - UpdateApplicationRegFormRequest
   * @param headers - UpdateApplicationRegFormHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateApplicationRegFormResponse
   */
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

  /**
   * 更新应聘登记表内容
   * 
   * @param request - UpdateApplicationRegFormRequest
   * @returns UpdateApplicationRegFormResponse
   */
  async updateApplicationRegForm(flowId: string, request: UpdateApplicationRegFormRequest): Promise<UpdateApplicationRegFormResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateApplicationRegFormHeaders({ });
    return await this.updateApplicationRegFormWithOptions(flowId, request, headers, runtime);
  }

  /**
   * 更新面试签到信息
   * 
   * @param request - UpdateInterviewSignInInfoRequest
   * @param headers - UpdateInterviewSignInInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInterviewSignInInfoResponse
   */
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

  /**
   * 更新面试签到信息
   * 
   * @param request - UpdateInterviewSignInInfoRequest
   * @returns UpdateInterviewSignInInfoResponse
   */
  async updateInterviewSignInInfo(interviewId: string, request: UpdateInterviewSignInInfoRequest): Promise<UpdateInterviewSignInInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInterviewSignInInfoHeaders({ });
    return await this.updateInterviewSignInInfoWithOptions(interviewId, request, headers, runtime);
  }

  /**
   * 渠道侧职位发布状态变更回调
   * 
   * @param request - UpdateJobDeliverRequest
   * @param headers - UpdateJobDeliverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateJobDeliverResponse
   */
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

  /**
   * 渠道侧职位发布状态变更回调
   * 
   * @param request - UpdateJobDeliverRequest
   * @returns UpdateJobDeliverResponse
   */
  async updateJobDeliver(request: UpdateJobDeliverRequest): Promise<UpdateJobDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateJobDeliverHeaders({ });
    return await this.updateJobDeliverWithOptions(request, headers, runtime);
  }

}
