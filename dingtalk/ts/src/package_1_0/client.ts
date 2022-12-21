// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CloseHPackageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseHPackageRequest extends $tea.Model {
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseHPackageResponseBody extends $tea.Model {
  result?: any;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseHPackageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CloseHPackageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CloseHPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadTokenRequest extends $tea.Model {
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadTokenResponseBody extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  bucket?: string;
  endpoint?: string;
  expiration?: string;
  name?: string;
  region?: string;
  stsToken?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      bucket: 'bucket',
      endpoint: 'endpoint',
      expiration: 'expiration',
      name: 'name',
      region: 'region',
      stsToken: 'stsToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      bucket: 'string',
      endpoint: 'string',
      expiration: 'string',
      name: 'string',
      region: 'string',
      stsToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUploadTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUploadTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPackageListGetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPackageListGetRequest extends $tea.Model {
  miniAppId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPackageListGetResponseBody extends $tea.Model {
  list?: HPackageListGetResponseBodyList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': HPackageListGetResponseBodyList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPackageListGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HPackageListGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HPackageListGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPublishPackageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPublishPackageRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPublishPackageResponseBody extends $tea.Model {
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

export class HPublishPackageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HPublishPackageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HPublishPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageRequest extends $tea.Model {
  miniAppId?: string;
  ossObjectKey?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      ossObjectKey: 'ossObjectKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      ossObjectKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageResponseBody extends $tea.Model {
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

export class HUploadPackageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HUploadPackageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HUploadPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusRequest extends $tea.Model {
  miniAppId?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusResponseBody extends $tea.Model {
  buildTime?: number;
  finished?: boolean;
  packageSize?: number;
  status?: string;
  taskId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      buildTime: 'buildTime',
      finished: 'finished',
      packageSize: 'packageSize',
      status: 'status',
      taskId: 'taskId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buildTime: 'number',
      finished: 'boolean',
      packageSize: 'number',
      status: 'string',
      taskId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HUploadPackageStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HUploadPackageStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenMicroAppPackageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenMicroAppPackageRequest extends $tea.Model {
  agentId?: number;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenMicroAppPackageResponseBody extends $tea.Model {
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenMicroAppPackageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: OpenMicroAppPackageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: OpenMicroAppPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayDeployHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayDeployRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayDeployResponseBody extends $tea.Model {
  result?: any;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayDeployResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayDeployResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayDeployResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayExitHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayExitRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayExitResponseBody extends $tea.Model {
  reuslt?: any;
  static names(): { [key: string]: string } {
    return {
      reuslt: 'reuslt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reuslt: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayExitResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayExitResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayExitResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgGetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgGetRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgGetResponseBody extends $tea.Model {
  value?: string[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayOrgGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayOrgGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgSetRequest extends $tea.Model {
  miniAppId?: string;
  value?: string[];
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      value: 'value',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      value: { 'type': 'array', 'itemType': 'string' },
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgSetResponseBody extends $tea.Model {
  result?: any;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayOrgSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayOrgSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayOrgSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentGetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentGetRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentGetResponseBody extends $tea.Model {
  value?: number;
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayPercentGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayPercentGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentSetRequest extends $tea.Model {
  miniAppId?: string;
  value?: number;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      value: 'value',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      value: 'number',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentSetResponseBody extends $tea.Model {
  result?: any;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayPercentSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayPercentSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayPercentSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayUserIdGetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayUserIdGetRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayUserIdGetResponseBody extends $tea.Model {
  value?: string[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseGrayUserIdGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReleaseGrayUserIdGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReleaseGrayUserIdGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPackageListGetResponseBodyList extends $tea.Model {
  avaliable?: number;
  creator?: string;
  finished?: boolean;
  operationTime?: number;
  packageSize?: number;
  status?: string;
  taskId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      avaliable: 'avaliable',
      creator: 'creator',
      finished: 'finished',
      operationTime: 'operationTime',
      packageSize: 'packageSize',
      status: 'status',
      taskId: 'taskId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avaliable: 'number',
      creator: 'string',
      finished: 'boolean',
      operationTime: 'number',
      packageSize: 'number',
      status: 'string',
      taskId: 'string',
      version: 'string',
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


  async closeHPackage(request: CloseHPackageRequest): Promise<CloseHPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseHPackageHeaders({ });
    return await this.closeHPackageWithOptions(request, headers, runtime);
  }

  async closeHPackageWithOptions(request: CloseHPackageRequest, headers: CloseHPackageHeaders, runtime: $Util.RuntimeOptions): Promise<CloseHPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
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
    return $tea.cast<CloseHPackageResponse>(await this.doROARequest("CloseHPackage", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/h5/microApps/close`, "json", req, runtime), new CloseHPackageResponse({}));
  }

  async getUploadToken(request: GetUploadTokenRequest): Promise<GetUploadTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadTokenHeaders({ });
    return await this.getUploadTokenWithOptions(request, headers, runtime);
  }

  async getUploadTokenWithOptions(request: GetUploadTokenRequest, headers: GetUploadTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadTokenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
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
    return $tea.cast<GetUploadTokenResponse>(await this.doROARequest("GetUploadToken", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/uploadTokens`, "json", req, runtime), new GetUploadTokenResponse({}));
  }

  async hPackageListGet(request: HPackageListGetRequest): Promise<HPackageListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HPackageListGetHeaders({ });
    return await this.hPackageListGetWithOptions(request, headers, runtime);
  }

  async hPackageListGetWithOptions(request: HPackageListGetRequest, headers: HPackageListGetHeaders, runtime: $Util.RuntimeOptions): Promise<HPackageListGetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<HPackageListGetResponse>(await this.doROARequest("HPackageListGet", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/h5/versions`, "json", req, runtime), new HPackageListGetResponse({}));
  }

  async hPublishPackage(request: HPublishPackageRequest): Promise<HPublishPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HPublishPackageHeaders({ });
    return await this.hPublishPackageWithOptions(request, headers, runtime);
  }

  async hPublishPackageWithOptions(request: HPublishPackageRequest, headers: HPublishPackageHeaders, runtime: $Util.RuntimeOptions): Promise<HPublishPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<HPublishPackageResponse>(await this.doROARequest("HPublishPackage", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/h5/publish`, "json", req, runtime), new HPublishPackageResponse({}));
  }

  async hUploadPackage(request: HUploadPackageRequest): Promise<HUploadPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HUploadPackageHeaders({ });
    return await this.hUploadPackageWithOptions(request, headers, runtime);
  }

  async hUploadPackageWithOptions(request: HUploadPackageRequest, headers: HUploadPackageHeaders, runtime: $Util.RuntimeOptions): Promise<HUploadPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.ossObjectKey)) {
      body["ossObjectKey"] = request.ossObjectKey;
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
    return $tea.cast<HUploadPackageResponse>(await this.doROARequest("HUploadPackage", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/h5/asyncUpload`, "json", req, runtime), new HUploadPackageResponse({}));
  }

  async hUploadPackageStatus(request: HUploadPackageStatusRequest): Promise<HUploadPackageStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HUploadPackageStatusHeaders({ });
    return await this.hUploadPackageStatusWithOptions(request, headers, runtime);
  }

  async hUploadPackageStatusWithOptions(request: HUploadPackageStatusRequest, headers: HUploadPackageStatusHeaders, runtime: $Util.RuntimeOptions): Promise<HUploadPackageStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
    return $tea.cast<HUploadPackageStatusResponse>(await this.doROARequest("HUploadPackageStatus", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/h5/uploadStatus`, "json", req, runtime), new HUploadPackageStatusResponse({}));
  }

  async openMicroAppPackage(request: OpenMicroAppPackageRequest): Promise<OpenMicroAppPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenMicroAppPackageHeaders({ });
    return await this.openMicroAppPackageWithOptions(request, headers, runtime);
  }

  async openMicroAppPackageWithOptions(request: OpenMicroAppPackageRequest, headers: OpenMicroAppPackageHeaders, runtime: $Util.RuntimeOptions): Promise<OpenMicroAppPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
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
    return $tea.cast<OpenMicroAppPackageResponse>(await this.doROARequest("OpenMicroAppPackage", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/h5/microApps/open`, "json", req, runtime), new OpenMicroAppPackageResponse({}));
  }

  async releaseGrayDeploy(request: ReleaseGrayDeployRequest): Promise<ReleaseGrayDeployResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayDeployHeaders({ });
    return await this.releaseGrayDeployWithOptions(request, headers, runtime);
  }

  async releaseGrayDeployWithOptions(request: ReleaseGrayDeployRequest, headers: ReleaseGrayDeployHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayDeployResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<ReleaseGrayDeployResponse>(await this.doROARequest("ReleaseGrayDeploy", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/greys/deploy`, "json", req, runtime), new ReleaseGrayDeployResponse({}));
  }

  async releaseGrayExit(request: ReleaseGrayExitRequest): Promise<ReleaseGrayExitResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayExitHeaders({ });
    return await this.releaseGrayExitWithOptions(request, headers, runtime);
  }

  async releaseGrayExitWithOptions(request: ReleaseGrayExitRequest, headers: ReleaseGrayExitHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayExitResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<ReleaseGrayExitResponse>(await this.doROARequest("ReleaseGrayExit", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/greys/exit`, "json", req, runtime), new ReleaseGrayExitResponse({}));
  }

  async releaseGrayOrgGet(request: ReleaseGrayOrgGetRequest): Promise<ReleaseGrayOrgGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayOrgGetHeaders({ });
    return await this.releaseGrayOrgGetWithOptions(request, headers, runtime);
  }

  async releaseGrayOrgGetWithOptions(request: ReleaseGrayOrgGetRequest, headers: ReleaseGrayOrgGetHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayOrgGetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
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
    return $tea.cast<ReleaseGrayOrgGetResponse>(await this.doROARequest("ReleaseGrayOrgGet", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/greys/organizations`, "json", req, runtime), new ReleaseGrayOrgGetResponse({}));
  }

  async releaseGrayOrgSet(request: ReleaseGrayOrgSetRequest): Promise<ReleaseGrayOrgSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayOrgSetHeaders({ });
    return await this.releaseGrayOrgSetWithOptions(request, headers, runtime);
  }

  async releaseGrayOrgSetWithOptions(request: ReleaseGrayOrgSetRequest, headers: ReleaseGrayOrgSetHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayOrgSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.value)) {
      body["value"] = request.value;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<ReleaseGrayOrgSetResponse>(await this.doROARequest("ReleaseGrayOrgSet", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/greys/organizations/release`, "json", req, runtime), new ReleaseGrayOrgSetResponse({}));
  }

  async releaseGrayPercentGet(request: ReleaseGrayPercentGetRequest): Promise<ReleaseGrayPercentGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayPercentGetHeaders({ });
    return await this.releaseGrayPercentGetWithOptions(request, headers, runtime);
  }

  async releaseGrayPercentGetWithOptions(request: ReleaseGrayPercentGetRequest, headers: ReleaseGrayPercentGetHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayPercentGetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
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
    return $tea.cast<ReleaseGrayPercentGetResponse>(await this.doROARequest("ReleaseGrayPercentGet", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/greys/users/percents`, "json", req, runtime), new ReleaseGrayPercentGetResponse({}));
  }

  async releaseGrayPercentSet(request: ReleaseGrayPercentSetRequest): Promise<ReleaseGrayPercentSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayPercentSetHeaders({ });
    return await this.releaseGrayPercentSetWithOptions(request, headers, runtime);
  }

  async releaseGrayPercentSetWithOptions(request: ReleaseGrayPercentSetRequest, headers: ReleaseGrayPercentSetHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayPercentSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.value)) {
      body["value"] = request.value;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<ReleaseGrayPercentSetResponse>(await this.doROARequest("ReleaseGrayPercentSet", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/greys/users/percents/release`, "json", req, runtime), new ReleaseGrayPercentSetResponse({}));
  }

  async releaseGrayUserIdGet(request: ReleaseGrayUserIdGetRequest): Promise<ReleaseGrayUserIdGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseGrayUserIdGetHeaders({ });
    return await this.releaseGrayUserIdGetWithOptions(request, headers, runtime);
  }

  async releaseGrayUserIdGetWithOptions(request: ReleaseGrayUserIdGetRequest, headers: ReleaseGrayUserIdGetHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseGrayUserIdGetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
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
    return $tea.cast<ReleaseGrayUserIdGetResponse>(await this.doROARequest("ReleaseGrayUserIdGet", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/greys/users`, "json", req, runtime), new ReleaseGrayUserIdGetResponse({}));
  }

}
