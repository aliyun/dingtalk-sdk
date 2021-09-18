// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateVersionAcrossBundleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVersionAcrossBundleRequest extends $tea.Model {
  dingTokenGrantType?: number;
  sourceVersion?: string;
  sourceBundleId?: string;
  dingOrgId?: number;
  dingCorpId?: string;
  bundleId?: string;
  version?: string;
  dingClientId?: string;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      dingTokenGrantType: 'dingTokenGrantType',
      sourceVersion: 'sourceVersion',
      sourceBundleId: 'sourceBundleId',
      dingOrgId: 'dingOrgId',
      dingCorpId: 'dingCorpId',
      bundleId: 'bundleId',
      version: 'version',
      dingClientId: 'dingClientId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingTokenGrantType: 'number',
      sourceVersion: 'string',
      sourceBundleId: 'string',
      dingOrgId: 'number',
      dingCorpId: 'string',
      bundleId: 'string',
      version: 'string',
      dingClientId: 'string',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVersionAcrossBundleResponseBody extends $tea.Model {
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

export class CreateVersionAcrossBundleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateVersionAcrossBundleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateVersionAcrossBundleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVersionStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVersionStatusRequest extends $tea.Model {
  versionType?: number;
  version?: string;
  bundleId?: string;
  miniAppId?: string;
  dingClientId?: string;
  dingTokenGrantType?: number;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      versionType: 'versionType',
      version: 'version',
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      versionType: 'number',
      version: 'string',
      bundleId: 'string',
      miniAppId: 'string',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVersionStatusResponseBody extends $tea.Model {
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

export class UpdateVersionStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateVersionStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateVersionStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetExtendSettingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetExtendSettingRequest extends $tea.Model {
  miniAppId?: string;
  buildH5Bundle?: boolean;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  dingClientId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      buildH5Bundle: 'buildH5Bundle',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingClientId: 'dingClientId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      buildH5Bundle: 'boolean',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
      dingClientId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetExtendSettingResponseBody extends $tea.Model {
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

export class SetExtendSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SetExtendSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SetExtendSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMiniAppHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMiniAppRequest extends $tea.Model {
  bizType?: number;
  bizId?: string;
  name?: string;
  icon?: string;
  desc?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  dingClientId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      bizId: 'bizId',
      name: 'name',
      icon: 'icon',
      desc: 'desc',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingClientId: 'dingClientId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      bizId: 'string',
      name: 'string',
      icon: 'string',
      desc: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
      dingClientId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMiniAppResponseBody extends $tea.Model {
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

export class CreateMiniAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateMiniAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateMiniAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMaxVersionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMaxVersionRequest extends $tea.Model {
  miniAppId?: string;
  bundleId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      bundleId: 'bundleId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      bundleId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMaxVersionResponseBody extends $tea.Model {
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

export class GetMaxVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMaxVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMaxVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSettingByMiniAppIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSettingByMiniAppIdResponseBody extends $tea.Model {
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

export class GetSettingByMiniAppIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSettingByMiniAppIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSettingByMiniAppIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHtmlBundleBuildHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHtmlBundleBuildRequest extends $tea.Model {
  miniAppId?: string;
  bundleId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      bundleId: 'bundleId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      bundleId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHtmlBundleBuildResponseBody extends $tea.Model {
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

export class QueryHtmlBundleBuildResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHtmlBundleBuildResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHtmlBundleBuildResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMiniAppPluginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMiniAppPluginRequest extends $tea.Model {
  bizType?: number;
  bizId?: string;
  name?: string;
  icon?: string;
  desc?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  dingClientId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      bizId: 'bizId',
      name: 'name',
      icon: 'icon',
      desc: 'desc',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingClientId: 'dingClientId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      bizId: 'string',
      name: 'string',
      icon: 'string',
      desc: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
      dingClientId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMiniAppPluginResponseBody extends $tea.Model {
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

export class CreateMiniAppPluginResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateMiniAppPluginResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateMiniAppPluginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvaiableVersionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvaiableVersionRequest extends $tea.Model {
  miniAppId?: string;
  versionTypeSet?: number[];
  bundleId?: string;
  pageSize?: number;
  pageNum?: number;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      versionTypeSet: 'versionTypeSet',
      bundleId: 'bundleId',
      pageSize: 'pageSize',
      pageNum: 'pageNum',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      versionTypeSet: { 'type': 'array', 'itemType': 'number' },
      bundleId: 'string',
      pageSize: 'number',
      pageNum: 'number',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvaiableVersionResponseBody extends $tea.Model {
  versions?: ListAvaiableVersionResponseBodyVersions[];
  static names(): { [key: string]: string } {
    return {
      versions: 'versions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      versions: { 'type': 'array', 'itemType': ListAvaiableVersionResponseBodyVersions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvaiableVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAvaiableVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAvaiableVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvokeHtmlBundleBuildHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvokeHtmlBundleBuildRequest extends $tea.Model {
  miniAppId?: string;
  bundleId?: string;
  version?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  dingClientId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      bundleId: 'bundleId',
      version: 'version',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingClientId: 'dingClientId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      bundleId: 'string',
      version: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
      dingClientId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvokeHtmlBundleBuildResponseBody extends $tea.Model {
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

export class InvokeHtmlBundleBuildResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: InvokeHtmlBundleBuildResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: InvokeHtmlBundleBuildResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAvaiableVersionResponseBodyVersions extends $tea.Model {
  packageUrl?: string;
  packageSize?: string;
  buildStatus?: number;
  version?: string;
  h5Bundle?: string;
  static names(): { [key: string]: string } {
    return {
      packageUrl: 'packageUrl',
      packageSize: 'packageSize',
      buildStatus: 'buildStatus',
      version: 'version',
      h5Bundle: 'h5Bundle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      packageUrl: 'string',
      packageSize: 'string',
      buildStatus: 'number',
      version: 'string',
      h5Bundle: 'string',
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


  async createVersionAcrossBundle(request: CreateVersionAcrossBundleRequest): Promise<CreateVersionAcrossBundleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVersionAcrossBundleHeaders({ });
    return await this.createVersionAcrossBundleWithOptions(request, headers, runtime);
  }

  async createVersionAcrossBundleWithOptions(request: CreateVersionAcrossBundleRequest, headers: CreateVersionAcrossBundleHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVersionAcrossBundleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.sourceVersion)) {
      body["sourceVersion"] = request.sourceVersion;
    }

    if (!Util.isUnset(request.sourceBundleId)) {
      body["sourceBundleId"] = request.sourceBundleId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
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
    return $tea.cast<CreateVersionAcrossBundleResponse>(await this.doROARequest("CreateVersionAcrossBundle", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/versions/createAcrossBundle`, "json", req, runtime), new CreateVersionAcrossBundleResponse({}));
  }

  async updateVersionStatus(request: UpdateVersionStatusRequest): Promise<UpdateVersionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVersionStatusHeaders({ });
    return await this.updateVersionStatusWithOptions(request, headers, runtime);
  }

  async updateVersionStatusWithOptions(request: UpdateVersionStatusRequest, headers: UpdateVersionStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVersionStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.versionType)) {
      body["versionType"] = request.versionType;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
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
    return $tea.cast<UpdateVersionStatusResponse>(await this.doROARequest("UpdateVersionStatus", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/versions/status`, "json", req, runtime), new UpdateVersionStatusResponse({}));
  }

  async setExtendSetting(request: SetExtendSettingRequest): Promise<SetExtendSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetExtendSettingHeaders({ });
    return await this.setExtendSettingWithOptions(request, headers, runtime);
  }

  async setExtendSettingWithOptions(request: SetExtendSettingRequest, headers: SetExtendSettingHeaders, runtime: $Util.RuntimeOptions): Promise<SetExtendSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.buildH5Bundle)) {
      body["buildH5Bundle"] = request.buildH5Bundle;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
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
    return $tea.cast<SetExtendSettingResponse>(await this.doROARequest("SetExtendSetting", "miniapp_1.0", "HTTP", "PUT", "AK", `/v1.0/miniapp/apps/settings`, "json", req, runtime), new SetExtendSettingResponse({}));
  }

  async createMiniApp(request: CreateMiniAppRequest): Promise<CreateMiniAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMiniAppHeaders({ });
    return await this.createMiniAppWithOptions(request, headers, runtime);
  }

  async createMiniAppWithOptions(request: CreateMiniAppRequest, headers: CreateMiniAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMiniAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
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
    return $tea.cast<CreateMiniAppResponse>(await this.doROARequest("CreateMiniApp", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/apps`, "json", req, runtime), new CreateMiniAppResponse({}));
  }

  async getMaxVersion(request: GetMaxVersionRequest): Promise<GetMaxVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMaxVersionHeaders({ });
    return await this.getMaxVersionWithOptions(request, headers, runtime);
  }

  async getMaxVersionWithOptions(request: GetMaxVersionRequest, headers: GetMaxVersionHeaders, runtime: $Util.RuntimeOptions): Promise<GetMaxVersionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.bundleId)) {
      query["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
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
    return $tea.cast<GetMaxVersionResponse>(await this.doROARequest("GetMaxVersion", "miniapp_1.0", "HTTP", "GET", "AK", `/v1.0/miniapp/apps/maxVersions`, "json", req, runtime), new GetMaxVersionResponse({}));
  }

  async getSettingByMiniAppId(miniAppId: string): Promise<GetSettingByMiniAppIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSettingByMiniAppIdHeaders({ });
    return await this.getSettingByMiniAppIdWithOptions(miniAppId, headers, runtime);
  }

  async getSettingByMiniAppIdWithOptions(miniAppId: string, headers: GetSettingByMiniAppIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetSettingByMiniAppIdResponse> {
    miniAppId = OpenApiUtil.getEncodeParam(miniAppId);
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
    return $tea.cast<GetSettingByMiniAppIdResponse>(await this.doROARequest("GetSettingByMiniAppId", "miniapp_1.0", "HTTP", "GET", "AK", `/v1.0/miniapp/apps/settings`, "json", req, runtime), new GetSettingByMiniAppIdResponse({}));
  }

  async queryHtmlBundleBuild(request: QueryHtmlBundleBuildRequest): Promise<QueryHtmlBundleBuildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHtmlBundleBuildHeaders({ });
    return await this.queryHtmlBundleBuildWithOptions(request, headers, runtime);
  }

  async queryHtmlBundleBuildWithOptions(request: QueryHtmlBundleBuildRequest, headers: QueryHtmlBundleBuildHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHtmlBundleBuildResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.bundleId)) {
      query["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.version)) {
      query["version"] = request.version;
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
    return $tea.cast<QueryHtmlBundleBuildResponse>(await this.doROARequest("QueryHtmlBundleBuild", "miniapp_1.0", "HTTP", "GET", "AK", `/v1.0/miniapp/h5Bundles/buildResults`, "json", req, runtime), new QueryHtmlBundleBuildResponse({}));
  }

  async createMiniAppPlugin(request: CreateMiniAppPluginRequest): Promise<CreateMiniAppPluginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMiniAppPluginHeaders({ });
    return await this.createMiniAppPluginWithOptions(request, headers, runtime);
  }

  async createMiniAppPluginWithOptions(request: CreateMiniAppPluginRequest, headers: CreateMiniAppPluginHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMiniAppPluginResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
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
    return $tea.cast<CreateMiniAppPluginResponse>(await this.doROARequest("CreateMiniAppPlugin", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/plugins`, "json", req, runtime), new CreateMiniAppPluginResponse({}));
  }

  async listAvaiableVersion(request: ListAvaiableVersionRequest): Promise<ListAvaiableVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAvaiableVersionHeaders({ });
    return await this.listAvaiableVersionWithOptions(request, headers, runtime);
  }

  async listAvaiableVersionWithOptions(request: ListAvaiableVersionRequest, headers: ListAvaiableVersionHeaders, runtime: $Util.RuntimeOptions): Promise<ListAvaiableVersionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.versionTypeSet)) {
      body["versionTypeSet"] = request.versionTypeSet;
    }

    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNum)) {
      body["pageNum"] = request.pageNum;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<ListAvaiableVersionResponse>(await this.doROARequest("ListAvaiableVersion", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/apps/versions/query`, "json", req, runtime), new ListAvaiableVersionResponse({}));
  }

  async invokeHtmlBundleBuild(request: InvokeHtmlBundleBuildRequest): Promise<InvokeHtmlBundleBuildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InvokeHtmlBundleBuildHeaders({ });
    return await this.invokeHtmlBundleBuildWithOptions(request, headers, runtime);
  }

  async invokeHtmlBundleBuildWithOptions(request: InvokeHtmlBundleBuildRequest, headers: InvokeHtmlBundleBuildHeaders, runtime: $Util.RuntimeOptions): Promise<InvokeHtmlBundleBuildResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
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
    return $tea.cast<InvokeHtmlBundleBuildResponse>(await this.doROARequest("InvokeHtmlBundleBuild", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/h5Bundles/build`, "json", req, runtime), new InvokeHtmlBundleBuildResponse({}));
  }

}
