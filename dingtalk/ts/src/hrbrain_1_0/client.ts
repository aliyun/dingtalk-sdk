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

export class HrbrainImportAwardDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportAwardDetailRequest extends $tea.Model {
  body?: HrbrainImportAwardDetailRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportAwardDetailRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportAwardDetailResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportAwardDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportAwardDetailResponseBody;
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
      body: HrbrainImportAwardDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDeptInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDeptInfoRequest extends $tea.Model {
  body?: HrbrainImportDeptInfoRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportDeptInfoRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDeptInfoResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDeptInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportDeptInfoResponseBody;
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
      body: HrbrainImportDeptInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDimissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDimissionRequest extends $tea.Model {
  body?: HrbrainImportDimissionRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportDimissionRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDimissionResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDimissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportDimissionResponseBody;
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
      body: HrbrainImportDimissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEduExpHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEduExpRequest extends $tea.Model {
  body?: HrbrainImportEduExpRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportEduExpRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEduExpResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEduExpResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportEduExpResponseBody;
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
      body: HrbrainImportEduExpResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEmpInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEmpInfoRequest extends $tea.Model {
  body?: HrbrainImportEmpInfoRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportEmpInfoRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEmpInfoResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEmpInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportEmpInfoResponseBody;
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
      body: HrbrainImportEmpInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelBaseHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelBaseRequest extends $tea.Model {
  body?: HrbrainImportLabelBaseRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportLabelBaseRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelBaseResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelBaseResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportLabelBaseResponseBody;
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
      body: HrbrainImportLabelBaseResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelCustomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelCustomRequest extends $tea.Model {
  body?: HrbrainImportLabelCustomRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportLabelCustomRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelCustomResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelCustomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportLabelCustomResponseBody;
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
      body: HrbrainImportLabelCustomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelIndustryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelIndustryRequest extends $tea.Model {
  body?: HrbrainImportLabelIndustryRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportLabelIndustryRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelIndustryResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelIndustryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportLabelIndustryResponseBody;
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
      body: HrbrainImportLabelIndustryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelInventoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelInventoryRequest extends $tea.Model {
  body?: HrbrainImportLabelInventoryRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportLabelInventoryRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelInventoryResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelInventoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportLabelInventoryResponseBody;
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
      body: HrbrainImportLabelInventoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelProfSkillHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelProfSkillRequest extends $tea.Model {
  body?: HrbrainImportLabelProfSkillRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportLabelProfSkillRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelProfSkillResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelProfSkillResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportLabelProfSkillResponseBody;
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
      body: HrbrainImportLabelProfSkillResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPerfEvalHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPerfEvalRequest extends $tea.Model {
  body?: HrbrainImportPerfEvalRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportPerfEvalRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPerfEvalResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPerfEvalResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportPerfEvalResponseBody;
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
      body: HrbrainImportPerfEvalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPromEvalHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPromEvalRequest extends $tea.Model {
  body?: HrbrainImportPromEvalRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportPromEvalRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPromEvalResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPromEvalResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportPromEvalResponseBody;
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
      body: HrbrainImportPromEvalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPunDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPunDetailRequest extends $tea.Model {
  body?: HrbrainImportPunDetailRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportPunDetailRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPunDetailResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPunDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportPunDetailResponseBody;
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
      body: HrbrainImportPunDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportRegistHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportRegistRequest extends $tea.Model {
  body?: HrbrainImportRegistRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportRegistRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportRegistResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportRegistResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportRegistResponseBody;
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
      body: HrbrainImportRegistResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportTransferEvalHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportTransferEvalRequest extends $tea.Model {
  body?: HrbrainImportTransferEvalRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportTransferEvalRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportTransferEvalResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportTransferEvalResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportTransferEvalResponseBody;
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
      body: HrbrainImportTransferEvalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportWorkExpHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportWorkExpRequest extends $tea.Model {
  body?: HrbrainImportWorkExpRequestBody[];
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': HrbrainImportWorkExpRequestBody },
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportWorkExpResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportWorkExpResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrbrainImportWorkExpResponseBody;
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
      body: HrbrainImportWorkExpResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryRequest extends $tea.Model {
  body?: StaffLabelRecordsQueryRequestBody[];
  dingCorpId?: string;
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      dingCorpId: 'dingCorpId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': StaffLabelRecordsQueryRequestBody },
      dingCorpId: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryResponseBody extends $tea.Model {
  content?: StaffLabelRecordsQueryResponseBodyContent;
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: StaffLabelRecordsQueryResponseBodyContent,
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StaffLabelRecordsQueryResponseBody;
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
      body: StaffLabelRecordsQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataRequest extends $tea.Model {
  content?: string;
  dataId?: string;
  etlTime?: string;
  projectId?: string;
  schemaId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      dataId: 'dataId',
      etlTime: 'etlTime',
      projectId: 'projectId',
      schemaId: 'schemaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      dataId: 'string',
      etlTime: 'string',
      projectId: 'string',
      schemaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponseBody extends $tea.Model {
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

export class SyncDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncDataResponseBody;
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
      body: SyncDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportAwardDetailRequestBody extends $tea.Model {
  awardDate?: string;
  awardName?: string;
  awardOrg?: string;
  awardType?: string;
  comment?: string;
  extendInfo?: { [key: string]: any };
  name?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      awardDate: 'awardDate',
      awardName: 'awardName',
      awardOrg: 'awardOrg',
      awardType: 'awardType',
      comment: 'comment',
      extendInfo: 'extendInfo',
      name: 'name',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      awardDate: 'string',
      awardName: 'string',
      awardOrg: 'string',
      awardType: 'string',
      comment: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDeptInfoRequestBody extends $tea.Model {
  createDate?: string;
  deptName?: string;
  deptNo?: string;
  effectiveDate?: string;
  extendInfo?: { [key: string]: any };
  isEffective?: string;
  superDeptName?: string;
  superDeptNo?: string;
  superEmpId?: string;
  superName?: string;
  static names(): { [key: string]: string } {
    return {
      createDate: 'createDate',
      deptName: 'deptName',
      deptNo: 'deptNo',
      effectiveDate: 'effectiveDate',
      extendInfo: 'extendInfo',
      isEffective: 'isEffective',
      superDeptName: 'superDeptName',
      superDeptNo: 'superDeptNo',
      superEmpId: 'superEmpId',
      superName: 'superName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createDate: 'string',
      deptName: 'string',
      deptNo: 'string',
      effectiveDate: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      isEffective: 'string',
      superDeptName: 'string',
      superDeptNo: 'string',
      superEmpId: 'string',
      superName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportDimissionRequestBody extends $tea.Model {
  deptName?: string;
  deptNo?: string;
  dimissionDate?: string;
  dimissionReaasonDesc?: string;
  dimissionReason?: string;
  empType?: string;
  extendInfo?: { [key: string]: any };
  jobCodeName?: string;
  jobLevel?: string;
  name?: string;
  postName?: string;
  superName?: string;
  workLocAddr?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      deptNo: 'deptNo',
      dimissionDate: 'dimissionDate',
      dimissionReaasonDesc: 'dimissionReaasonDesc',
      dimissionReason: 'dimissionReason',
      empType: 'empType',
      extendInfo: 'extendInfo',
      jobCodeName: 'jobCodeName',
      jobLevel: 'jobLevel',
      name: 'name',
      postName: 'postName',
      superName: 'superName',
      workLocAddr: 'workLocAddr',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      deptNo: 'string',
      dimissionDate: 'string',
      dimissionReaasonDesc: 'string',
      dimissionReason: 'string',
      empType: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      jobCodeName: 'string',
      jobLevel: 'string',
      name: 'string',
      postName: 'string',
      superName: 'string',
      workLocAddr: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEduExpRequestBody extends $tea.Model {
  eduName?: string;
  endDate?: string;
  extendInfo?: { [key: string]: any };
  major?: string;
  name?: string;
  schoolName?: string;
  startDate?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      eduName: 'eduName',
      endDate: 'endDate',
      extendInfo: 'extendInfo',
      major: 'major',
      name: 'name',
      schoolName: 'schoolName',
      startDate: 'startDate',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eduName: 'string',
      endDate: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      major: 'string',
      name: 'string',
      schoolName: 'string',
      startDate: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportEmpInfoRequestBody extends $tea.Model {
  birthday?: string;
  deptName?: string;
  deptNo?: string;
  dimissionDate?: string;
  empSource?: string;
  empStatus?: string;
  empType?: string;
  extendInfo?: { [key: string]: any };
  gender?: string;
  highestDegree?: string;
  highestEduName?: string;
  isDimission?: string;
  jobCodeName?: string;
  jobLevel?: string;
  lastSchoolName?: string;
  marriage?: string;
  name?: string;
  nation?: string;
  nationCtry?: string;
  politicalStatus?: string;
  postName?: string;
  registDate?: string;
  regularDate?: string;
  superEmpId?: string;
  superName?: string;
  workEmail?: string;
  workLocAddr?: string;
  workLocCity?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      birthday: 'birthday',
      deptName: 'deptName',
      deptNo: 'deptNo',
      dimissionDate: 'dimissionDate',
      empSource: 'empSource',
      empStatus: 'empStatus',
      empType: 'empType',
      extendInfo: 'extendInfo',
      gender: 'gender',
      highestDegree: 'highestDegree',
      highestEduName: 'highestEduName',
      isDimission: 'isDimission',
      jobCodeName: 'jobCodeName',
      jobLevel: 'jobLevel',
      lastSchoolName: 'lastSchoolName',
      marriage: 'marriage',
      name: 'name',
      nation: 'nation',
      nationCtry: 'nationCtry',
      politicalStatus: 'politicalStatus',
      postName: 'postName',
      registDate: 'registDate',
      regularDate: 'regularDate',
      superEmpId: 'superEmpId',
      superName: 'superName',
      workEmail: 'workEmail',
      workLocAddr: 'workLocAddr',
      workLocCity: 'workLocCity',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      birthday: 'string',
      deptName: 'string',
      deptNo: 'string',
      dimissionDate: 'string',
      empSource: 'string',
      empStatus: 'string',
      empType: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gender: 'string',
      highestDegree: 'string',
      highestEduName: 'string',
      isDimission: 'string',
      jobCodeName: 'string',
      jobLevel: 'string',
      lastSchoolName: 'string',
      marriage: 'string',
      name: 'string',
      nation: 'string',
      nationCtry: 'string',
      politicalStatus: 'string',
      postName: 'string',
      registDate: 'string',
      regularDate: 'string',
      superEmpId: 'string',
      superName: 'string',
      workEmail: 'string',
      workLocAddr: 'string',
      workLocCity: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelBaseRequestBody extends $tea.Model {
  extendInfo?: { [key: string]: any };
  name?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      extendInfo: 'extendInfo',
      name: 'name',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelCustomRequestBody extends $tea.Model {
  extendInfo?: { [key: string]: any };
  name?: string;
  tag?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      extendInfo: 'extendInfo',
      name: 'name',
      tag: 'tag',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      tag: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelIndustryRequestBody extends $tea.Model {
  extendInfo?: { [key: string]: any };
  level1?: string;
  level2?: string;
  level3?: string;
  name?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      extendInfo: 'extendInfo',
      level1: 'level1',
      level2: 'level2',
      level3: 'level3',
      name: 'name',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      level1: 'string',
      level2: 'string',
      level3: 'string',
      name: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelInventoryRequestBody extends $tea.Model {
  extendInfo?: { [key: string]: any };
  name?: string;
  period?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      extendInfo: 'extendInfo',
      name: 'name',
      period: 'period',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      period: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportLabelProfSkillRequestBody extends $tea.Model {
  extendInfo?: { [key: string]: any };
  level1?: string;
  level2?: string;
  level3?: string;
  name?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      extendInfo: 'extendInfo',
      level1: 'level1',
      level2: 'level2',
      level3: 'level3',
      name: 'name',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      level1: 'string',
      level2: 'string',
      level3: 'string',
      name: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPerfEvalRequestBody extends $tea.Model {
  comment?: string;
  extendInfo?: { [key: string]: any };
  name?: string;
  perfCate?: string;
  perfPlanName?: string;
  perfScore?: string;
  period?: string;
  periodEndDate?: string;
  periodStartDate?: string;
  score?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      comment: 'comment',
      extendInfo: 'extendInfo',
      name: 'name',
      perfCate: 'perfCate',
      perfPlanName: 'perfPlanName',
      perfScore: 'perfScore',
      period: 'period',
      periodEndDate: 'periodEndDate',
      periodStartDate: 'periodStartDate',
      score: 'score',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comment: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      perfCate: 'string',
      perfPlanName: 'string',
      perfScore: 'string',
      period: 'string',
      periodEndDate: 'string',
      periodStartDate: 'string',
      score: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPromEvalRequestBody extends $tea.Model {
  comment?: string;
  effectiveDate?: string;
  extendInfo?: { [key: string]: any };
  name?: string;
  newJobLevel?: string;
  period?: string;
  periodEndDate?: string;
  periodStartDate?: string;
  preJobLevel?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      comment: 'comment',
      effectiveDate: 'effectiveDate',
      extendInfo: 'extendInfo',
      name: 'name',
      newJobLevel: 'newJobLevel',
      period: 'period',
      periodEndDate: 'periodEndDate',
      periodStartDate: 'periodStartDate',
      preJobLevel: 'preJobLevel',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comment: 'string',
      effectiveDate: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      newJobLevel: 'string',
      period: 'string',
      periodEndDate: 'string',
      periodStartDate: 'string',
      preJobLevel: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportPunDetailRequestBody extends $tea.Model {
  comment?: string;
  effectiveDate?: string;
  extendInfo?: { [key: string]: any };
  name?: string;
  punName?: string;
  punOrg?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      comment: 'comment',
      effectiveDate: 'effectiveDate',
      extendInfo: 'extendInfo',
      name: 'name',
      punName: 'punName',
      punOrg: 'punOrg',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      comment: 'string',
      effectiveDate: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      punName: 'string',
      punOrg: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportRegistRequestBody extends $tea.Model {
  deptName?: string;
  deptNo?: string;
  empSource?: string;
  empType?: string;
  extendInfo?: { [key: string]: any };
  jobCodeName?: string;
  jobLevel?: string;
  name?: string;
  postName?: string;
  registDate?: string;
  superName?: string;
  workLocAddr?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      deptNo: 'deptNo',
      empSource: 'empSource',
      empType: 'empType',
      extendInfo: 'extendInfo',
      jobCodeName: 'jobCodeName',
      jobLevel: 'jobLevel',
      name: 'name',
      postName: 'postName',
      registDate: 'registDate',
      superName: 'superName',
      workLocAddr: 'workLocAddr',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      deptNo: 'string',
      empSource: 'string',
      empType: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      jobCodeName: 'string',
      jobLevel: 'string',
      name: 'string',
      postName: 'string',
      registDate: 'string',
      superName: 'string',
      workLocAddr: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportTransferEvalRequestBody extends $tea.Model {
  currInfo?: { [key: string]: any };
  extendInfo?: { [key: string]: any };
  name?: string;
  preInfo?: { [key: string]: any };
  transferDate?: string;
  transferReason?: string;
  transferType?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      currInfo: 'currInfo',
      extendInfo: 'extendInfo',
      name: 'name',
      preInfo: 'preInfo',
      transferDate: 'transferDate',
      transferReason: 'transferReason',
      transferType: 'transferType',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      name: 'string',
      preInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      transferDate: 'string',
      transferReason: 'string',
      transferType: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrbrainImportWorkExpRequestBody extends $tea.Model {
  companyName?: string;
  endDate?: string;
  extendInfo?: { [key: string]: any };
  jobDesc?: string;
  name?: string;
  postName?: string;
  startDate?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      companyName: 'companyName',
      endDate: 'endDate',
      extendInfo: 'extendInfo',
      jobDesc: 'jobDesc',
      name: 'name',
      postName: 'postName',
      startDate: 'startDate',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyName: 'string',
      endDate: 'string',
      extendInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      jobDesc: 'string',
      name: 'string',
      postName: 'string',
      startDate: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryRequestBodyLabels extends $tea.Model {
  code?: string;
  typeCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      typeCode: 'typeCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      typeCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryRequestBody extends $tea.Model {
  labels?: StaffLabelRecordsQueryRequestBodyLabels[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      labels: 'labels',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labels: { 'type': 'array', 'itemType': StaffLabelRecordsQueryRequestBodyLabels },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions extends $tea.Model {
  label?: string;
  tip?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
      tip: 'tip',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
      tip: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryResponseBodyContentDataLabels extends $tea.Model {
  code?: string;
  guid?: string;
  name?: string;
  options?: StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions[];
  typeCode?: string;
  typeName?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      guid: 'guid',
      name: 'name',
      options: 'options',
      typeCode: 'typeCode',
      typeName: 'typeName',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      guid: 'string',
      name: 'string',
      options: { 'type': 'array', 'itemType': StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions },
      typeCode: 'string',
      typeName: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryResponseBodyContentData extends $tea.Model {
  labels?: StaffLabelRecordsQueryResponseBodyContentDataLabels[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      labels: 'labels',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labels: { 'type': 'array', 'itemType': StaffLabelRecordsQueryResponseBodyContentDataLabels },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StaffLabelRecordsQueryResponseBodyContent extends $tea.Model {
  data?: StaffLabelRecordsQueryResponseBodyContentData[];
  maxResults?: number;
  nextToken?: string;
  totalCountt?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      totalCountt: 'totalCountt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': StaffLabelRecordsQueryResponseBodyContentData },
      maxResults: 'number',
      nextToken: 'string',
      totalCountt: 'number',
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


  /**
   * @summary 集成奖励记录
   *
   * @param request HrbrainImportAwardDetailRequest
   * @param headers HrbrainImportAwardDetailHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportAwardDetailResponse
   */
  async hrbrainImportAwardDetailWithOptions(request: HrbrainImportAwardDetailRequest, headers: HrbrainImportAwardDetailHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportAwardDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportAwardDetail",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/awardDetails/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportAwardDetailResponse>(await this.execute(params, req, runtime), new HrbrainImportAwardDetailResponse({}));
  }

  /**
   * @summary 集成奖励记录
   *
   * @param request HrbrainImportAwardDetailRequest
   * @return HrbrainImportAwardDetailResponse
   */
  async hrbrainImportAwardDetail(request: HrbrainImportAwardDetailRequest): Promise<HrbrainImportAwardDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportAwardDetailHeaders({ });
    return await this.hrbrainImportAwardDetailWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成组织架构
   *
   * @param request HrbrainImportDeptInfoRequest
   * @param headers HrbrainImportDeptInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportDeptInfoResponse
   */
  async hrbrainImportDeptInfoWithOptions(request: HrbrainImportDeptInfoRequest, headers: HrbrainImportDeptInfoHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportDeptInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportDeptInfo",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/deptInfos/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportDeptInfoResponse>(await this.execute(params, req, runtime), new HrbrainImportDeptInfoResponse({}));
  }

  /**
   * @summary 集成组织架构
   *
   * @param request HrbrainImportDeptInfoRequest
   * @return HrbrainImportDeptInfoResponse
   */
  async hrbrainImportDeptInfo(request: HrbrainImportDeptInfoRequest): Promise<HrbrainImportDeptInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportDeptInfoHeaders({ });
    return await this.hrbrainImportDeptInfoWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成离职信息
   *
   * @param request HrbrainImportDimissionRequest
   * @param headers HrbrainImportDimissionHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportDimissionResponse
   */
  async hrbrainImportDimissionWithOptions(request: HrbrainImportDimissionRequest, headers: HrbrainImportDimissionHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportDimissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportDimission",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/dimissionInfos/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportDimissionResponse>(await this.execute(params, req, runtime), new HrbrainImportDimissionResponse({}));
  }

  /**
   * @summary 集成离职信息
   *
   * @param request HrbrainImportDimissionRequest
   * @return HrbrainImportDimissionResponse
   */
  async hrbrainImportDimission(request: HrbrainImportDimissionRequest): Promise<HrbrainImportDimissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportDimissionHeaders({ });
    return await this.hrbrainImportDimissionWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成教育经历
   *
   * @param request HrbrainImportEduExpRequest
   * @param headers HrbrainImportEduExpHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportEduExpResponse
   */
  async hrbrainImportEduExpWithOptions(request: HrbrainImportEduExpRequest, headers: HrbrainImportEduExpHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportEduExpResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportEduExp",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/eduExperiences/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportEduExpResponse>(await this.execute(params, req, runtime), new HrbrainImportEduExpResponse({}));
  }

  /**
   * @summary 集成教育经历
   *
   * @param request HrbrainImportEduExpRequest
   * @return HrbrainImportEduExpResponse
   */
  async hrbrainImportEduExp(request: HrbrainImportEduExpRequest): Promise<HrbrainImportEduExpResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportEduExpHeaders({ });
    return await this.hrbrainImportEduExpWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成人员信息
   *
   * @param request HrbrainImportEmpInfoRequest
   * @param headers HrbrainImportEmpInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportEmpInfoResponse
   */
  async hrbrainImportEmpInfoWithOptions(request: HrbrainImportEmpInfoRequest, headers: HrbrainImportEmpInfoHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportEmpInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportEmpInfo",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/empInfos/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportEmpInfoResponse>(await this.execute(params, req, runtime), new HrbrainImportEmpInfoResponse({}));
  }

  /**
   * @summary 集成人员信息
   *
   * @param request HrbrainImportEmpInfoRequest
   * @return HrbrainImportEmpInfoResponse
   */
  async hrbrainImportEmpInfo(request: HrbrainImportEmpInfoRequest): Promise<HrbrainImportEmpInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportEmpInfoHeaders({ });
    return await this.hrbrainImportEmpInfoWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成基础标签
   *
   * @param request HrbrainImportLabelBaseRequest
   * @param headers HrbrainImportLabelBaseHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportLabelBaseResponse
   */
  async hrbrainImportLabelBaseWithOptions(request: HrbrainImportLabelBaseRequest, headers: HrbrainImportLabelBaseHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportLabelBaseResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportLabelBase",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/baseLabels/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportLabelBaseResponse>(await this.execute(params, req, runtime), new HrbrainImportLabelBaseResponse({}));
  }

  /**
   * @summary 集成基础标签
   *
   * @param request HrbrainImportLabelBaseRequest
   * @return HrbrainImportLabelBaseResponse
   */
  async hrbrainImportLabelBase(request: HrbrainImportLabelBaseRequest): Promise<HrbrainImportLabelBaseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportLabelBaseHeaders({ });
    return await this.hrbrainImportLabelBaseWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成自定义标签
   *
   * @param request HrbrainImportLabelCustomRequest
   * @param headers HrbrainImportLabelCustomHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportLabelCustomResponse
   */
  async hrbrainImportLabelCustomWithOptions(request: HrbrainImportLabelCustomRequest, headers: HrbrainImportLabelCustomHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportLabelCustomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportLabelCustom",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/customLabels/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportLabelCustomResponse>(await this.execute(params, req, runtime), new HrbrainImportLabelCustomResponse({}));
  }

  /**
   * @summary 集成自定义标签
   *
   * @param request HrbrainImportLabelCustomRequest
   * @return HrbrainImportLabelCustomResponse
   */
  async hrbrainImportLabelCustom(request: HrbrainImportLabelCustomRequest): Promise<HrbrainImportLabelCustomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportLabelCustomHeaders({ });
    return await this.hrbrainImportLabelCustomWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成领域经验
   *
   * @param request HrbrainImportLabelIndustryRequest
   * @param headers HrbrainImportLabelIndustryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportLabelIndustryResponse
   */
  async hrbrainImportLabelIndustryWithOptions(request: HrbrainImportLabelIndustryRequest, headers: HrbrainImportLabelIndustryHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportLabelIndustryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportLabelIndustry",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/industries/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportLabelIndustryResponse>(await this.execute(params, req, runtime), new HrbrainImportLabelIndustryResponse({}));
  }

  /**
   * @summary 集成领域经验
   *
   * @param request HrbrainImportLabelIndustryRequest
   * @return HrbrainImportLabelIndustryResponse
   */
  async hrbrainImportLabelIndustry(request: HrbrainImportLabelIndustryRequest): Promise<HrbrainImportLabelIndustryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportLabelIndustryHeaders({ });
    return await this.hrbrainImportLabelIndustryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成盘点数据
   *
   * @param request HrbrainImportLabelInventoryRequest
   * @param headers HrbrainImportLabelInventoryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportLabelInventoryResponse
   */
  async hrbrainImportLabelInventoryWithOptions(request: HrbrainImportLabelInventoryRequest, headers: HrbrainImportLabelInventoryHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportLabelInventoryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportLabelInventory",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/inventories/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportLabelInventoryResponse>(await this.execute(params, req, runtime), new HrbrainImportLabelInventoryResponse({}));
  }

  /**
   * @summary 集成盘点数据
   *
   * @param request HrbrainImportLabelInventoryRequest
   * @return HrbrainImportLabelInventoryResponse
   */
  async hrbrainImportLabelInventory(request: HrbrainImportLabelInventoryRequest): Promise<HrbrainImportLabelInventoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportLabelInventoryHeaders({ });
    return await this.hrbrainImportLabelInventoryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成专业技能
   *
   * @param request HrbrainImportLabelProfSkillRequest
   * @param headers HrbrainImportLabelProfSkillHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportLabelProfSkillResponse
   */
  async hrbrainImportLabelProfSkillWithOptions(request: HrbrainImportLabelProfSkillRequest, headers: HrbrainImportLabelProfSkillHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportLabelProfSkillResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportLabelProfSkill",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/profSkills/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportLabelProfSkillResponse>(await this.execute(params, req, runtime), new HrbrainImportLabelProfSkillResponse({}));
  }

  /**
   * @summary 集成专业技能
   *
   * @param request HrbrainImportLabelProfSkillRequest
   * @return HrbrainImportLabelProfSkillResponse
   */
  async hrbrainImportLabelProfSkill(request: HrbrainImportLabelProfSkillRequest): Promise<HrbrainImportLabelProfSkillResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportLabelProfSkillHeaders({ });
    return await this.hrbrainImportLabelProfSkillWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成绩效记录
   *
   * @param request HrbrainImportPerfEvalRequest
   * @param headers HrbrainImportPerfEvalHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportPerfEvalResponse
   */
  async hrbrainImportPerfEvalWithOptions(request: HrbrainImportPerfEvalRequest, headers: HrbrainImportPerfEvalHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportPerfEvalResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportPerfEval",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/perfRecords/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportPerfEvalResponse>(await this.execute(params, req, runtime), new HrbrainImportPerfEvalResponse({}));
  }

  /**
   * @summary 集成绩效记录
   *
   * @param request HrbrainImportPerfEvalRequest
   * @return HrbrainImportPerfEvalResponse
   */
  async hrbrainImportPerfEval(request: HrbrainImportPerfEvalRequest): Promise<HrbrainImportPerfEvalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportPerfEvalHeaders({ });
    return await this.hrbrainImportPerfEvalWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成晋升记录
   *
   * @param request HrbrainImportPromEvalRequest
   * @param headers HrbrainImportPromEvalHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportPromEvalResponse
   */
  async hrbrainImportPromEvalWithOptions(request: HrbrainImportPromEvalRequest, headers: HrbrainImportPromEvalHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportPromEvalResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportPromEval",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/promRecords/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportPromEvalResponse>(await this.execute(params, req, runtime), new HrbrainImportPromEvalResponse({}));
  }

  /**
   * @summary 集成晋升记录
   *
   * @param request HrbrainImportPromEvalRequest
   * @return HrbrainImportPromEvalResponse
   */
  async hrbrainImportPromEval(request: HrbrainImportPromEvalRequest): Promise<HrbrainImportPromEvalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportPromEvalHeaders({ });
    return await this.hrbrainImportPromEvalWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成处分记录
   *
   * @param request HrbrainImportPunDetailRequest
   * @param headers HrbrainImportPunDetailHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportPunDetailResponse
   */
  async hrbrainImportPunDetailWithOptions(request: HrbrainImportPunDetailRequest, headers: HrbrainImportPunDetailHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportPunDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportPunDetail",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/punDetails/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportPunDetailResponse>(await this.execute(params, req, runtime), new HrbrainImportPunDetailResponse({}));
  }

  /**
   * @summary 集成处分记录
   *
   * @param request HrbrainImportPunDetailRequest
   * @return HrbrainImportPunDetailResponse
   */
  async hrbrainImportPunDetail(request: HrbrainImportPunDetailRequest): Promise<HrbrainImportPunDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportPunDetailHeaders({ });
    return await this.hrbrainImportPunDetailWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成入职信息
   *
   * @param request HrbrainImportRegistRequest
   * @param headers HrbrainImportRegistHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportRegistResponse
   */
  async hrbrainImportRegistWithOptions(request: HrbrainImportRegistRequest, headers: HrbrainImportRegistHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportRegistResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportRegist",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/registerInfos/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportRegistResponse>(await this.execute(params, req, runtime), new HrbrainImportRegistResponse({}));
  }

  /**
   * @summary 集成入职信息
   *
   * @param request HrbrainImportRegistRequest
   * @return HrbrainImportRegistResponse
   */
  async hrbrainImportRegist(request: HrbrainImportRegistRequest): Promise<HrbrainImportRegistResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportRegistHeaders({ });
    return await this.hrbrainImportRegistWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成异动记录
   *
   * @param request HrbrainImportTransferEvalRequest
   * @param headers HrbrainImportTransferEvalHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportTransferEvalResponse
   */
  async hrbrainImportTransferEvalWithOptions(request: HrbrainImportTransferEvalRequest, headers: HrbrainImportTransferEvalHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportTransferEvalResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportTransferEval",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/changeRecords/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportTransferEvalResponse>(await this.execute(params, req, runtime), new HrbrainImportTransferEvalResponse({}));
  }

  /**
   * @summary 集成异动记录
   *
   * @param request HrbrainImportTransferEvalRequest
   * @return HrbrainImportTransferEvalResponse
   */
  async hrbrainImportTransferEval(request: HrbrainImportTransferEvalRequest): Promise<HrbrainImportTransferEvalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportTransferEvalHeaders({ });
    return await this.hrbrainImportTransferEvalWithOptions(request, headers, runtime);
  }

  /**
   * @summary 集成工作经历
   *
   * @param request HrbrainImportWorkExpRequest
   * @param headers HrbrainImportWorkExpHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrbrainImportWorkExpResponse
   */
  async hrbrainImportWorkExpWithOptions(request: HrbrainImportWorkExpRequest, headers: HrbrainImportWorkExpHeaders, runtime: $Util.RuntimeOptions): Promise<HrbrainImportWorkExpResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "HrbrainImportWorkExp",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/workExperiences/import`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrbrainImportWorkExpResponse>(await this.execute(params, req, runtime), new HrbrainImportWorkExpResponse({}));
  }

  /**
   * @summary 集成工作经历
   *
   * @param request HrbrainImportWorkExpRequest
   * @return HrbrainImportWorkExpResponse
   */
  async hrbrainImportWorkExp(request: HrbrainImportWorkExpRequest): Promise<HrbrainImportWorkExpResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrbrainImportWorkExpHeaders({ });
    return await this.hrbrainImportWorkExpWithOptions(request, headers, runtime);
  }

  /**
   * @summary 人员标签查询
   *
   * @param request StaffLabelRecordsQueryRequest
   * @param headers StaffLabelRecordsQueryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return StaffLabelRecordsQueryResponse
   */
  async staffLabelRecordsQueryWithOptions(request: StaffLabelRecordsQueryRequest, headers: StaffLabelRecordsQueryHeaders, runtime: $Util.RuntimeOptions): Promise<StaffLabelRecordsQueryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      query["dingCorpId"] = request.dingCorpId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "StaffLabelRecordsQuery",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas/labelRecords/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StaffLabelRecordsQueryResponse>(await this.execute(params, req, runtime), new StaffLabelRecordsQueryResponse({}));
  }

  /**
   * @summary 人员标签查询
   *
   * @param request StaffLabelRecordsQueryRequest
   * @return StaffLabelRecordsQueryResponse
   */
  async staffLabelRecordsQuery(request: StaffLabelRecordsQueryRequest): Promise<StaffLabelRecordsQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StaffLabelRecordsQueryHeaders({ });
    return await this.staffLabelRecordsQueryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 同步统计基础数据
   *
   * @param request SyncDataRequest
   * @param headers SyncDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SyncDataResponse
   */
  async syncDataWithOptions(request: SyncDataRequest, headers: SyncDataHeaders, runtime: $Util.RuntimeOptions): Promise<SyncDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.dataId)) {
      body["dataId"] = request.dataId;
    }

    if (!Util.isUnset(request.etlTime)) {
      body["etlTime"] = request.etlTime;
    }

    if (!Util.isUnset(request.projectId)) {
      body["projectId"] = request.projectId;
    }

    if (!Util.isUnset(request.schemaId)) {
      body["schemaId"] = request.schemaId;
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
      action: "SyncData",
      version: "hrbrain_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrbrain/datas`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SyncDataResponse>(await this.execute(params, req, runtime), new SyncDataResponse({}));
  }

  /**
   * @summary 同步统计基础数据
   *
   * @param request SyncDataRequest
   * @return SyncDataResponse
   */
  async syncData(request: SyncDataRequest): Promise<SyncDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncDataHeaders({ });
    return await this.syncDataWithOptions(request, headers, runtime);
  }

}
