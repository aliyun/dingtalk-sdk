// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CorpInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoResponseBody extends $tea.Model {
  data?: CorpInfoResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: CorpInfoResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CorpInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CorpInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperRequest extends $tea.Model {
  dingCorpId?: string;
  redirectUrl?: string;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      redirectUrl: 'redirectUrl',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      redirectUrl: 'string',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperResponseBody extends $tea.Model {
  code?: number;
  message?: string;
  data?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      message: 'string',
      data: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateDeveloperResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateDeveloperResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlRequest extends $tea.Model {
  dingCorpId?: string;
  userId?: string;
  redirectUrl?: string;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      userId: 'userId',
      redirectUrl: 'redirectUrl',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      userId: 'string',
      redirectUrl: 'string',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlResponseBody extends $tea.Model {
  code?: number;
  message?: string;
  data?: GetUserRealnameUrlResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      message: 'string',
      data: GetUserRealnameUrlResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserRealnameUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserRealnameUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlRequest extends $tea.Model {
  dingCorpId?: string;
  userId?: string;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      userId: 'userId',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      userId: 'string',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlResponseBody extends $tea.Model {
  code?: number;
  message?: string;
  data?: GetCorpRealnameUrlResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      message: 'string',
      data: GetCorpRealnameUrlResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCorpRealnameUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCorpRealnameUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileResponseBody extends $tea.Model {
  data?: GetFileResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetFileResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlRequest extends $tea.Model {
  redirectUrl?: string;
  dingCorpId?: string;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      redirectUrl: 'redirectUrl',
      dingCorpId: 'dingCorpId',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      redirectUrl: 'string',
      dingCorpId: 'string',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlResponseBody extends $tea.Model {
  data?: AuthUrlResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: AuthUrlResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AuthUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AuthUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthResponseBody extends $tea.Model {
  data?: CancelCorpAuthResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: CancelCorpAuthResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CancelCorpAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CancelCorpAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlRequest extends $tea.Model {
  dingCorpId?: string;
  taskId?: string;
  dingSuiteKey?: string;
  dingIsvAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      taskId: 'taskId',
      dingSuiteKey: 'dingSuiteKey',
      dingIsvAccessToken: 'dingIsvAccessToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      taskId: 'string',
      dingSuiteKey: 'string',
      dingIsvAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlResponseBody extends $tea.Model {
  data?: GetSignNoticeUrlResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetSignNoticeUrlResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSignNoticeUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSignNoticeUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlRequest extends $tea.Model {
  dingCorpId?: string;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  contentType?: string;
  contentMd5?: string;
  convert2Pdf?: boolean;
  fileName?: string;
  fileSize?: number;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
      contentType: 'contentType',
      contentMd5: 'contentMd5',
      convert2Pdf: 'convert2Pdf',
      fileName: 'fileName',
      fileSize: 'fileSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
      contentType: 'string',
      contentMd5: 'string',
      convert2Pdf: 'boolean',
      fileName: 'string',
      fileSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponseBody extends $tea.Model {
  code?: number;
  message?: string;
  data?: GetUploadUrlResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      message: 'string',
      data: GetUploadUrlResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUploadUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUploadUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalRequest extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalResponseBody extends $tea.Model {
  data?: ListSealApprovalResponseBodyData[];
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': ListSealApprovalResponseBodyData },
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSealApprovalResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSealApprovalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginResponseBody extends $tea.Model {
  data?: ContractMarginResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: ContractMarginResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ContractMarginResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ContractMarginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailRequest extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponseBody extends $tea.Model {
  data?: GetFlowDetailResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetFlowDetailResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFlowDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFlowDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequest extends $tea.Model {
  autoStart?: boolean;
  files?: GetProcessStartUrlRequestFiles[];
  dingCorpId?: string;
  initiatorUserId?: string;
  participants?: GetProcessStartUrlRequestParticipants[];
  redirectUrl?: string;
  sourceInfo?: GetProcessStartUrlRequestSourceInfo;
  taskName?: string;
  ccs?: GetProcessStartUrlRequestCcs[];
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      autoStart: 'autoStart',
      files: 'files',
      dingCorpId: 'dingCorpId',
      initiatorUserId: 'initiatorUserId',
      participants: 'participants',
      redirectUrl: 'redirectUrl',
      sourceInfo: 'sourceInfo',
      taskName: 'taskName',
      ccs: 'ccs',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoStart: 'boolean',
      files: { 'type': 'array', 'itemType': GetProcessStartUrlRequestFiles },
      dingCorpId: 'string',
      initiatorUserId: 'string',
      participants: { 'type': 'array', 'itemType': GetProcessStartUrlRequestParticipants },
      redirectUrl: 'string',
      sourceInfo: GetProcessStartUrlRequestSourceInfo,
      taskName: 'string',
      ccs: { 'type': 'array', 'itemType': GetProcessStartUrlRequestCcs },
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlResponseBody extends $tea.Model {
  message?: string;
  code?: number;
  data?: GetProcessStartUrlResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      code: 'code',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      code: 'number',
      data: GetProcessStartUrlResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetProcessStartUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetProcessStartUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleResponseBody extends $tea.Model {
  data?: CorpConsoleResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: CorpConsoleResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CorpConsoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CorpConsoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsRequest extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsResponseBody extends $tea.Model {
  data?: ListFlowDocsResponseBodyData[];
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': ListFlowDocsResponseBodyData },
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListFlowDocsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListFlowDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponseBody extends $tea.Model {
  data?: GetUserInfoResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetUserInfoResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusResponseBody extends $tea.Model {
  data?: GetCropStatusResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetCropStatusResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCropStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCropStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderRequest extends $tea.Model {
  dingCorpId?: string;
  itemCode?: string;
  itemName?: string;
  orderCreateTime?: number;
  orderId?: string;
  payFee?: number;
  quantity?: number;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      itemCode: 'itemCode',
      itemName: 'itemName',
      orderCreateTime: 'orderCreateTime',
      orderId: 'orderId',
      payFee: 'payFee',
      quantity: 'quantity',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      itemCode: 'string',
      itemName: 'string',
      orderCreateTime: 'number',
      orderId: 'string',
      payFee: 'number',
      quantity: 'number',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderResponseBody extends $tea.Model {
  code?: number;
  message?: string;
  data?: ChannelOrderResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      message: 'string',
      data: ChannelOrderResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ChannelOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ChannelOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleRequest extends $tea.Model {
  dingCorpId?: string;
  serviceStartTime?: number;
  serviceStopTime?: number;
  orderCreateTime?: number;
  orderId?: string;
  quantity?: number;
  dingIsvAccessToken?: string;
  dingSuiteKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      serviceStartTime: 'serviceStartTime',
      serviceStopTime: 'serviceStopTime',
      orderCreateTime: 'orderCreateTime',
      orderId: 'orderId',
      quantity: 'quantity',
      dingIsvAccessToken: 'dingIsvAccessToken',
      dingSuiteKey: 'dingSuiteKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      serviceStartTime: 'number',
      serviceStopTime: 'number',
      orderCreateTime: 'number',
      orderId: 'string',
      quantity: 'number',
      dingIsvAccessToken: 'string',
      dingSuiteKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleResponseBody extends $tea.Model {
  code?: number;
  message?: string;
  data?: OrderResaleResponseBodyData;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      message: 'string',
      data: OrderResaleResponseBodyData,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: OrderResaleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: OrderResaleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailRequest extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailResponseBody extends $tea.Model {
  data?: GetFlowSignDetailResponseBodyData;
  code?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      code: 'code',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetFlowSignDetailResponseBodyData,
      code: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetFlowSignDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFlowSignDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoResponseBodyData extends $tea.Model {
  realName?: boolean;
  orgRealName?: string;
  static names(): { [key: string]: string } {
    return {
      realName: 'realName',
      orgRealName: 'orgRealName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      realName: 'boolean',
      orgRealName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlResponseBodyData extends $tea.Model {
  taskId?: string;
  pcUrl?: string;
  mobileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      pcUrl: 'pcUrl',
      mobileUrl: 'mobileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      pcUrl: 'string',
      mobileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlResponseBodyData extends $tea.Model {
  taskId?: string;
  pcUrl?: string;
  mobileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      pcUrl: 'pcUrl',
      mobileUrl: 'mobileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      pcUrl: 'string',
      mobileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileResponseBodyData extends $tea.Model {
  fileId?: string;
  name?: string;
  downloadUrl?: string;
  size?: number;
  status?: number;
  pdfTotalPages?: number;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      name: 'name',
      downloadUrl: 'downloadUrl',
      size: 'size',
      status: 'status',
      pdfTotalPages: 'pdfTotalPages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      name: 'string',
      downloadUrl: 'string',
      size: 'number',
      status: 'number',
      pdfTotalPages: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlResponseBodyData extends $tea.Model {
  taskId?: string;
  mobileUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthResponseBodyData extends $tea.Model {
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

export class GetSignNoticeUrlResponseBodyData extends $tea.Model {
  pcUrl?: string;
  mobileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pcUrl: 'pcUrl',
      mobileUrl: 'mobileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pcUrl: 'string',
      mobileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponseBodyData extends $tea.Model {
  fileId?: string;
  uploadUrl?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      uploadUrl: 'uploadUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      uploadUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalResponseBodyDataApprovalNodes extends $tea.Model {
  approverName?: string;
  status?: string;
  startTime?: number;
  approvalTime?: number;
  static names(): { [key: string]: string } {
    return {
      approverName: 'approverName',
      status: 'status',
      startTime: 'startTime',
      approvalTime: 'approvalTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approverName: 'string',
      status: 'string',
      startTime: 'number',
      approvalTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalResponseBodyData extends $tea.Model {
  approvalName?: string;
  status?: string;
  refuseReason?: string;
  sponsorAccountName?: string;
  startTime?: number;
  endTime?: number;
  sealIdImg?: string;
  approvalNodes?: ListSealApprovalResponseBodyDataApprovalNodes[];
  static names(): { [key: string]: string } {
    return {
      approvalName: 'approvalName',
      status: 'status',
      refuseReason: 'refuseReason',
      sponsorAccountName: 'sponsorAccountName',
      startTime: 'startTime',
      endTime: 'endTime',
      sealIdImg: 'sealIdImg',
      approvalNodes: 'approvalNodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approvalName: 'string',
      status: 'string',
      refuseReason: 'string',
      sponsorAccountName: 'string',
      startTime: 'number',
      endTime: 'number',
      sealIdImg: 'string',
      approvalNodes: { 'type': 'array', 'itemType': ListSealApprovalResponseBodyDataApprovalNodes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginResponseBodyData extends $tea.Model {
  margin?: number;
  static names(): { [key: string]: string } {
    return {
      margin: 'margin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      margin: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponseBodyDataLogs extends $tea.Model {
  operatorAccountName?: string;
  logType?: string;
  operateDescription?: string;
  operateTime?: number;
  static names(): { [key: string]: string } {
    return {
      operatorAccountName: 'operatorAccountName',
      logType: 'logType',
      operateDescription: 'operateDescription',
      operateTime: 'operateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorAccountName: 'string',
      logType: 'string',
      operateDescription: 'string',
      operateTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponseBodyData extends $tea.Model {
  businessSense?: string;
  flowStatus?: number;
  initiatorAuthorizedName?: string;
  initiatorName?: string;
  logs?: GetFlowDetailResponseBodyDataLogs[];
  static names(): { [key: string]: string } {
    return {
      businessSense: 'businessSense',
      flowStatus: 'flowStatus',
      initiatorAuthorizedName: 'initiatorAuthorizedName',
      initiatorName: 'initiatorName',
      logs: 'logs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessSense: 'string',
      flowStatus: 'number',
      initiatorAuthorizedName: 'string',
      initiatorName: 'string',
      logs: { 'type': 'array', 'itemType': GetFlowDetailResponseBodyDataLogs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequestFiles extends $tea.Model {
  fileId?: string;
  fileName?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequestParticipants extends $tea.Model {
  accountType?: string;
  dingCorpId?: string;
  signRequirements?: string;
  userId?: string;
  account?: string;
  accountName?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      dingCorpId: 'dingCorpId',
      signRequirements: 'signRequirements',
      userId: 'userId',
      account: 'account',
      accountName: 'accountName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      dingCorpId: 'string',
      signRequirements: 'string',
      userId: 'string',
      account: 'string',
      accountName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequestSourceInfo extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  showText?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      showText: 'showText',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      showText: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequestCcs extends $tea.Model {
  accountType?: string;
  dingCorpId?: string;
  userId?: string;
  account?: string;
  accountName?: string;
  orgName?: string;
  static names(): { [key: string]: string } {
    return {
      accountType: 'accountType',
      dingCorpId: 'dingCorpId',
      userId: 'userId',
      account: 'account',
      accountName: 'accountName',
      orgName: 'orgName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountType: 'string',
      dingCorpId: 'string',
      userId: 'string',
      account: 'string',
      accountName: 'string',
      orgName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlResponseBodyData extends $tea.Model {
  taskId?: string;
  pcUrl?: string;
  mobileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      pcUrl: 'pcUrl',
      mobileUrl: 'mobileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      pcUrl: 'string',
      mobileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleResponseBodyData extends $tea.Model {
  orgConsoleUrl?: number;
  static names(): { [key: string]: string } {
    return {
      orgConsoleUrl: 'orgConsoleUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgConsoleUrl: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsResponseBodyData extends $tea.Model {
  fileId?: string;
  fileName?: string;
  fileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileUrl: 'fileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponseBodyData extends $tea.Model {
  realName?: boolean;
  userRealName?: string;
  static names(): { [key: string]: string } {
    return {
      realName: 'realName',
      userRealName: 'userRealName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      realName: 'boolean',
      userRealName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusResponseBodyData extends $tea.Model {
  authStatus?: string;
  installStatus?: string;
  static names(): { [key: string]: string } {
    return {
      authStatus: 'authStatus',
      installStatus: 'installStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authStatus: 'string',
      installStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderResponseBodyData extends $tea.Model {
  esignOrderId?: string;
  static names(): { [key: string]: string } {
    return {
      esignOrderId: 'esignOrderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      esignOrderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleResponseBodyData extends $tea.Model {
  esignOrderId?: string;
  static names(): { [key: string]: string } {
    return {
      esignOrderId: 'esignOrderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      esignOrderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailResponseBodyDataSigners extends $tea.Model {
  signerName?: string;
  signStatus?: number;
  static names(): { [key: string]: string } {
    return {
      signerName: 'signerName',
      signStatus: 'signStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      signerName: 'string',
      signStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailResponseBodyData extends $tea.Model {
  businessSense?: string;
  flowStatus?: number;
  signers?: GetFlowSignDetailResponseBodyDataSigners[];
  static names(): { [key: string]: string } {
    return {
      businessSense: 'businessSense',
      flowStatus: 'flowStatus',
      signers: 'signers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessSense: 'string',
      flowStatus: 'number',
      signers: { 'type': 'array', 'itemType': GetFlowSignDetailResponseBodyDataSigners },
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


  async corpInfo(): Promise<CorpInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CorpInfoHeaders({ });
    return await this.corpInfoWithOptions(headers, runtime);
  }

  async corpInfoWithOptions(headers: CorpInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CorpInfoResponse> {
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
    return $tea.cast<CorpInfoResponse>(await this.doROARequest("CorpInfo", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/corps/info`, "json", req, runtime), new CorpInfoResponse({}));
  }

  async createDeveloper(request: CreateDeveloperRequest): Promise<CreateDeveloperResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeveloperHeaders({ });
    return await this.createDeveloperWithOptions(request, headers, runtime);
  }

  async createDeveloperWithOptions(request: CreateDeveloperRequest, headers: CreateDeveloperHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeveloperResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<CreateDeveloperResponse>(await this.doROARequest("CreateDeveloper", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/developers/create`, "json", req, runtime), new CreateDeveloperResponse({}));
  }

  async getUserRealnameUrl(request: GetUserRealnameUrlRequest): Promise<GetUserRealnameUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserRealnameUrlHeaders({ });
    return await this.getUserRealnameUrlWithOptions(request, headers, runtime);
  }

  async getUserRealnameUrlWithOptions(request: GetUserRealnameUrlRequest, headers: GetUserRealnameUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserRealnameUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<GetUserRealnameUrlResponse>(await this.doROARequest("GetUserRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/users/realname`, "json", req, runtime), new GetUserRealnameUrlResponse({}));
  }

  async getCorpRealnameUrl(request: GetCorpRealnameUrlRequest): Promise<GetCorpRealnameUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpRealnameUrlHeaders({ });
    return await this.getCorpRealnameUrlWithOptions(request, headers, runtime);
  }

  async getCorpRealnameUrlWithOptions(request: GetCorpRealnameUrlRequest, headers: GetCorpRealnameUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpRealnameUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<GetCorpRealnameUrlResponse>(await this.doROARequest("GetCorpRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/corps/realname`, "json", req, runtime), new GetCorpRealnameUrlResponse({}));
  }

  async getFile(fileId: string): Promise<GetFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileHeaders({ });
    return await this.getFileWithOptions(fileId, headers, runtime);
  }

  async getFileWithOptions(fileId: string, headers: GetFileHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileResponse> {
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
    return $tea.cast<GetFileResponse>(await this.doROARequest("GetFile", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/files/${fileId}`, "json", req, runtime), new GetFileResponse({}));
  }

  async authUrl(request: AuthUrlRequest): Promise<AuthUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AuthUrlHeaders({ });
    return await this.authUrlWithOptions(request, headers, runtime);
  }

  async authUrlWithOptions(request: AuthUrlRequest, headers: AuthUrlHeaders, runtime: $Util.RuntimeOptions): Promise<AuthUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<AuthUrlResponse>(await this.doROARequest("AuthUrl", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/auths/url`, "json", req, runtime), new AuthUrlResponse({}));
  }

  async cancelCorpAuth(): Promise<CancelCorpAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelCorpAuthHeaders({ });
    return await this.cancelCorpAuthWithOptions(headers, runtime);
  }

  async cancelCorpAuthWithOptions(headers: CancelCorpAuthHeaders, runtime: $Util.RuntimeOptions): Promise<CancelCorpAuthResponse> {
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
    return $tea.cast<CancelCorpAuthResponse>(await this.doROARequest("CancelCorpAuth", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/corps/auth/cancel`, "json", req, runtime), new CancelCorpAuthResponse({}));
  }

  async getSignNoticeUrl(request: GetSignNoticeUrlRequest): Promise<GetSignNoticeUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignNoticeUrlHeaders({ });
    return await this.getSignNoticeUrlWithOptions(request, headers, runtime);
  }

  async getSignNoticeUrlWithOptions(request: GetSignNoticeUrlRequest, headers: GetSignNoticeUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignNoticeUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
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
    return $tea.cast<GetSignNoticeUrlResponse>(await this.doROARequest("GetSignNoticeUrl", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/signs/notice/url`, "json", req, runtime), new GetSignNoticeUrlResponse({}));
  }

  async getUploadUrl(request: GetUploadUrlRequest): Promise<GetUploadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadUrlHeaders({ });
    return await this.getUploadUrlWithOptions(request, headers, runtime);
  }

  async getUploadUrlWithOptions(request: GetUploadUrlRequest, headers: GetUploadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.contentType)) {
      body["contentType"] = request.contentType;
    }

    if (!Util.isUnset(request.contentMd5)) {
      body["contentMd5"] = request.contentMd5;
    }

    if (!Util.isUnset(request.convert2Pdf)) {
      body["convert2Pdf"] = request.convert2Pdf;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
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
    return $tea.cast<GetUploadUrlResponse>(await this.doROARequest("GetUploadUrl", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/files/getUploadUrl`, "json", req, runtime), new GetUploadUrlResponse({}));
  }

  async listSealApproval(request: ListSealApprovalRequest): Promise<ListSealApprovalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSealApprovalHeaders({ });
    return await this.listSealApprovalWithOptions(request, headers, runtime);
  }

  async listSealApprovalWithOptions(request: ListSealApprovalRequest, headers: ListSealApprovalHeaders, runtime: $Util.RuntimeOptions): Promise<ListSealApprovalResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
    return $tea.cast<ListSealApprovalResponse>(await this.doROARequest("ListSealApproval", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/seals/approval/list`, "json", req, runtime), new ListSealApprovalResponse({}));
  }

  async contractMargin(): Promise<ContractMarginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ContractMarginHeaders({ });
    return await this.contractMarginWithOptions(headers, runtime);
  }

  async contractMarginWithOptions(headers: ContractMarginHeaders, runtime: $Util.RuntimeOptions): Promise<ContractMarginResponse> {
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
    return $tea.cast<ContractMarginResponse>(await this.doROARequest("ContractMargin", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/contracts/margin`, "json", req, runtime), new ContractMarginResponse({}));
  }

  async getFlowDetail(request: GetFlowDetailRequest): Promise<GetFlowDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowDetailHeaders({ });
    return await this.getFlowDetailWithOptions(request, headers, runtime);
  }

  async getFlowDetailWithOptions(request: GetFlowDetailRequest, headers: GetFlowDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
    return $tea.cast<GetFlowDetailResponse>(await this.doROARequest("GetFlowDetail", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/flows/detail`, "json", req, runtime), new GetFlowDetailResponse({}));
  }

  async getProcessStartUrl(request: GetProcessStartUrlRequest): Promise<GetProcessStartUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessStartUrlHeaders({ });
    return await this.getProcessStartUrlWithOptions(request, headers, runtime);
  }

  async getProcessStartUrlWithOptions(request: GetProcessStartUrlRequest, headers: GetProcessStartUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessStartUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.autoStart)) {
      body["autoStart"] = request.autoStart;
    }

    if (!Util.isUnset(request.files)) {
      body["files"] = request.files;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.initiatorUserId)) {
      body["initiatorUserId"] = request.initiatorUserId;
    }

    if (!Util.isUnset(request.participants)) {
      body["participants"] = request.participants;
    }

    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset($tea.toMap(request.sourceInfo))) {
      body["sourceInfo"] = request.sourceInfo;
    }

    if (!Util.isUnset(request.taskName)) {
      body["taskName"] = request.taskName;
    }

    if (!Util.isUnset(request.ccs)) {
      body["ccs"] = request.ccs;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<GetProcessStartUrlResponse>(await this.doROARequest("GetProcessStartUrl", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/process/start`, "json", req, runtime), new GetProcessStartUrlResponse({}));
  }

  async corpConsole(): Promise<CorpConsoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CorpConsoleHeaders({ });
    return await this.corpConsoleWithOptions(headers, runtime);
  }

  async corpConsoleWithOptions(headers: CorpConsoleHeaders, runtime: $Util.RuntimeOptions): Promise<CorpConsoleResponse> {
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
    return $tea.cast<CorpConsoleResponse>(await this.doROARequest("CorpConsole", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/corps/console`, "json", req, runtime), new CorpConsoleResponse({}));
  }

  async listFlowDocs(request: ListFlowDocsRequest): Promise<ListFlowDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFlowDocsHeaders({ });
    return await this.listFlowDocsWithOptions(request, headers, runtime);
  }

  async listFlowDocsWithOptions(request: ListFlowDocsRequest, headers: ListFlowDocsHeaders, runtime: $Util.RuntimeOptions): Promise<ListFlowDocsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
    return $tea.cast<ListFlowDocsResponse>(await this.doROARequest("ListFlowDocs", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/flows/docs`, "json", req, runtime), new ListFlowDocsResponse({}));
  }

  async getUserInfo(userId: string): Promise<GetUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserInfoHeaders({ });
    return await this.getUserInfoWithOptions(userId, headers, runtime);
  }

  async getUserInfoWithOptions(userId: string, headers: GetUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserInfoResponse> {
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
    return $tea.cast<GetUserInfoResponse>(await this.doROARequest("GetUserInfo", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/users/${userId}`, "json", req, runtime), new GetUserInfoResponse({}));
  }

  async getCropStatus(): Promise<GetCropStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCropStatusHeaders({ });
    return await this.getCropStatusWithOptions(headers, runtime);
  }

  async getCropStatusWithOptions(headers: GetCropStatusHeaders, runtime: $Util.RuntimeOptions): Promise<GetCropStatusResponse> {
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
    return $tea.cast<GetCropStatusResponse>(await this.doROARequest("GetCropStatus", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/corps/statuses`, "json", req, runtime), new GetCropStatusResponse({}));
  }

  async channelOrder(request: ChannelOrderRequest): Promise<ChannelOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChannelOrderHeaders({ });
    return await this.channelOrderWithOptions(request, headers, runtime);
  }

  async channelOrderWithOptions(request: ChannelOrderRequest, headers: ChannelOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ChannelOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.itemCode)) {
      body["itemCode"] = request.itemCode;
    }

    if (!Util.isUnset(request.itemName)) {
      body["itemName"] = request.itemName;
    }

    if (!Util.isUnset(request.orderCreateTime)) {
      body["orderCreateTime"] = request.orderCreateTime;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.payFee)) {
      body["payFee"] = request.payFee;
    }

    if (!Util.isUnset(request.quantity)) {
      body["quantity"] = request.quantity;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<ChannelOrderResponse>(await this.doROARequest("ChannelOrder", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/orders/channel`, "json", req, runtime), new ChannelOrderResponse({}));
  }

  async orderResale(request: OrderResaleRequest): Promise<OrderResaleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrderResaleHeaders({ });
    return await this.orderResaleWithOptions(request, headers, runtime);
  }

  async orderResaleWithOptions(request: OrderResaleRequest, headers: OrderResaleHeaders, runtime: $Util.RuntimeOptions): Promise<OrderResaleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.serviceStartTime)) {
      body["serviceStartTime"] = request.serviceStartTime;
    }

    if (!Util.isUnset(request.serviceStopTime)) {
      body["serviceStopTime"] = request.serviceStopTime;
    }

    if (!Util.isUnset(request.orderCreateTime)) {
      body["orderCreateTime"] = request.orderCreateTime;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.quantity)) {
      body["quantity"] = request.quantity;
    }

    if (!Util.isUnset(request.dingIsvAccessToken)) {
      body["dingIsvAccessToken"] = request.dingIsvAccessToken;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
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
    return $tea.cast<OrderResaleResponse>(await this.doROARequest("OrderResale", "esign_1.0", "HTTP", "POST", "AK", `/v1.0/esign/orders/resale`, "json", req, runtime), new OrderResaleResponse({}));
  }

  async getFlowSignDetail(request: GetFlowSignDetailRequest): Promise<GetFlowSignDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowSignDetailHeaders({ });
    return await this.getFlowSignDetailWithOptions(request, headers, runtime);
  }

  async getFlowSignDetailWithOptions(request: GetFlowSignDetailRequest, headers: GetFlowSignDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowSignDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
    return $tea.cast<GetFlowSignDetailResponse>(await this.doROARequest("GetFlowSignDetail", "esign_1.0", "HTTP", "GET", "AK", `/v1.0/esign/flows/sign/detail`, "json", req, runtime), new GetFlowSignDetailResponse({}));
  }

}
