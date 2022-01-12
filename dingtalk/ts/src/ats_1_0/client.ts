// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  body: AddApplicationRegFormTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: AddFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddFileResponseBody,
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
  body: ConfirmRightsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: FinishBeginnerTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetApplicationRegFormByFlowIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetCandidateByPhoneNumberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetFileUploadInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetFlowIdByRelationEntityIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetJobAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryInterviewsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryInterviewsResponseBody,
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
  body: UpdateApplicationRegFormResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async addApplicationRegFormTemplate(request: AddApplicationRegFormTemplateRequest): Promise<AddApplicationRegFormTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddApplicationRegFormTemplateHeaders({ });
    return await this.addApplicationRegFormTemplateWithOptions(request, headers, runtime);
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
    return $tea.cast<AddApplicationRegFormTemplateResponse>(await this.doROARequest("AddApplicationRegFormTemplate", "ats_1.0", "HTTP", "POST", "AK", `/v1.0/ats/flows/applicationRegForms/templates`, "json", req, runtime), new AddApplicationRegFormTemplateResponse({}));
  }

  async addFile(request: AddFileRequest): Promise<AddFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddFileHeaders({ });
    return await this.addFileWithOptions(request, headers, runtime);
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
    return $tea.cast<AddFileResponse>(await this.doROARequest("AddFile", "ats_1.0", "HTTP", "POST", "AK", `/v1.0/ats/files`, "json", req, runtime), new AddFileResponse({}));
  }

  async confirmRights(rightsCode: string, request: ConfirmRightsRequest): Promise<ConfirmRightsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConfirmRightsHeaders({ });
    return await this.confirmRightsWithOptions(rightsCode, request, headers, runtime);
  }

  async confirmRightsWithOptions(rightsCode: string, request: ConfirmRightsRequest, headers: ConfirmRightsHeaders, runtime: $Util.RuntimeOptions): Promise<ConfirmRightsResponse> {
    Util.validateModel(request);
    rightsCode = OpenApiUtil.getEncodeParam(rightsCode);
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
    return $tea.cast<ConfirmRightsResponse>(await this.doROARequest("ConfirmRights", "ats_1.0", "HTTP", "POST", "AK", `/v1.0/ats/rights/${rightsCode}/confirm`, "json", req, runtime), new ConfirmRightsResponse({}));
  }

  async finishBeginnerTask(taskCode: string, request: FinishBeginnerTaskRequest): Promise<FinishBeginnerTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishBeginnerTaskHeaders({ });
    return await this.finishBeginnerTaskWithOptions(taskCode, request, headers, runtime);
  }

  async finishBeginnerTaskWithOptions(taskCode: string, request: FinishBeginnerTaskRequest, headers: FinishBeginnerTaskHeaders, runtime: $Util.RuntimeOptions): Promise<FinishBeginnerTaskResponse> {
    Util.validateModel(request);
    taskCode = OpenApiUtil.getEncodeParam(taskCode);
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
    return $tea.cast<FinishBeginnerTaskResponse>(await this.doROARequest("FinishBeginnerTask", "ats_1.0", "HTTP", "POST", "AK", `/v1.0/ats/beginnerTasks/${taskCode}/finish`, "json", req, runtime), new FinishBeginnerTaskResponse({}));
  }

  async getApplicationRegFormByFlowId(flowId: string, request: GetApplicationRegFormByFlowIdRequest): Promise<GetApplicationRegFormByFlowIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplicationRegFormByFlowIdHeaders({ });
    return await this.getApplicationRegFormByFlowIdWithOptions(flowId, request, headers, runtime);
  }

  async getApplicationRegFormByFlowIdWithOptions(flowId: string, request: GetApplicationRegFormByFlowIdRequest, headers: GetApplicationRegFormByFlowIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplicationRegFormByFlowIdResponse> {
    Util.validateModel(request);
    flowId = OpenApiUtil.getEncodeParam(flowId);
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
    return $tea.cast<GetApplicationRegFormByFlowIdResponse>(await this.doROARequest("GetApplicationRegFormByFlowId", "ats_1.0", "HTTP", "GET", "AK", `/v1.0/ats/flows/${flowId}/applicationRegForms`, "json", req, runtime), new GetApplicationRegFormByFlowIdResponse({}));
  }

  async getCandidateByPhoneNumber(request: GetCandidateByPhoneNumberRequest): Promise<GetCandidateByPhoneNumberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCandidateByPhoneNumberHeaders({ });
    return await this.getCandidateByPhoneNumberWithOptions(request, headers, runtime);
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
    return $tea.cast<GetCandidateByPhoneNumberResponse>(await this.doROARequest("GetCandidateByPhoneNumber", "ats_1.0", "HTTP", "GET", "AK", `/v1.0/ats/candidates`, "json", req, runtime), new GetCandidateByPhoneNumberResponse({}));
  }

  async getFileUploadInfo(request: GetFileUploadInfoRequest): Promise<GetFileUploadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadInfoHeaders({ });
    return await this.getFileUploadInfoWithOptions(request, headers, runtime);
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
    return $tea.cast<GetFileUploadInfoResponse>(await this.doROARequest("GetFileUploadInfo", "ats_1.0", "HTTP", "GET", "AK", `/v1.0/ats/files/uploadInfos`, "json", req, runtime), new GetFileUploadInfoResponse({}));
  }

  async getFlowIdByRelationEntityId(request: GetFlowIdByRelationEntityIdRequest): Promise<GetFlowIdByRelationEntityIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowIdByRelationEntityIdHeaders({ });
    return await this.getFlowIdByRelationEntityIdWithOptions(request, headers, runtime);
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
    return $tea.cast<GetFlowIdByRelationEntityIdResponse>(await this.doROARequest("GetFlowIdByRelationEntityId", "ats_1.0", "HTTP", "GET", "AK", `/v1.0/ats/flows/ids`, "json", req, runtime), new GetFlowIdByRelationEntityIdResponse({}));
  }

  async getJobAuth(jobId: string, request: GetJobAuthRequest): Promise<GetJobAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobAuthHeaders({ });
    return await this.getJobAuthWithOptions(jobId, request, headers, runtime);
  }

  async getJobAuthWithOptions(jobId: string, request: GetJobAuthRequest, headers: GetJobAuthHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobAuthResponse> {
    Util.validateModel(request);
    jobId = OpenApiUtil.getEncodeParam(jobId);
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
    return $tea.cast<GetJobAuthResponse>(await this.doROARequest("GetJobAuth", "ats_1.0", "HTTP", "GET", "AK", `/v1.0/ats/auths/jobs/${jobId}`, "json", req, runtime), new GetJobAuthResponse({}));
  }

  async queryInterviews(request: QueryInterviewsRequest): Promise<QueryInterviewsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInterviewsHeaders({ });
    return await this.queryInterviewsWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryInterviewsResponse>(await this.doROARequest("QueryInterviews", "ats_1.0", "HTTP", "POST", "AK", `/v1.0/ats/interviews/query`, "json", req, runtime), new QueryInterviewsResponse({}));
  }

  async updateApplicationRegForm(flowId: string, request: UpdateApplicationRegFormRequest): Promise<UpdateApplicationRegFormResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateApplicationRegFormHeaders({ });
    return await this.updateApplicationRegFormWithOptions(flowId, request, headers, runtime);
  }

  async updateApplicationRegFormWithOptions(flowId: string, request: UpdateApplicationRegFormRequest, headers: UpdateApplicationRegFormHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateApplicationRegFormResponse> {
    Util.validateModel(request);
    flowId = OpenApiUtil.getEncodeParam(flowId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset($tea.toMap(request.dingPanFile))) {
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
    return $tea.cast<UpdateApplicationRegFormResponse>(await this.doROARequest("UpdateApplicationRegForm", "ats_1.0", "HTTP", "PUT", "AK", `/v1.0/ats/flows/${flowId}/applicationRegForms`, "json", req, runtime), new UpdateApplicationRegFormResponse({}));
  }

  async updateInterviewSignInInfo(interviewId: string, request: UpdateInterviewSignInInfoRequest): Promise<UpdateInterviewSignInInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInterviewSignInInfoHeaders({ });
    return await this.updateInterviewSignInInfoWithOptions(interviewId, request, headers, runtime);
  }

  async updateInterviewSignInInfoWithOptions(interviewId: string, request: UpdateInterviewSignInInfoRequest, headers: UpdateInterviewSignInInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInterviewSignInInfoResponse> {
    Util.validateModel(request);
    interviewId = OpenApiUtil.getEncodeParam(interviewId);
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
    return $tea.cast<UpdateInterviewSignInInfoResponse>(await this.doROARequest("UpdateInterviewSignInInfo", "ats_1.0", "HTTP", "PUT", "AK", `/v1.0/ats/interviews/${interviewId}/signInInfos`, "none", req, runtime), new UpdateInterviewSignInInfoResponse({}));
  }

}
