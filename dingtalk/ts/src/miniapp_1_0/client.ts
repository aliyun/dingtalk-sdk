// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  bizId?: string;
  bizType?: number;
  bundleId?: string;
  desc?: string;
  icon?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      bizType: 'bizType',
      bundleId: 'bundleId',
      desc: 'desc',
      icon: 'icon',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      bizType: 'number',
      bundleId: 'string',
      desc: 'string',
      icon: 'string',
      name: 'string',
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
  bizId?: string;
  bizType?: number;
  bundleId?: string;
  desc?: string;
  icon?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      bizType: 'bizType',
      bundleId: 'bundleId',
      desc: 'desc',
      icon: 'icon',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      bizType: 'number',
      bundleId: 'string',
      desc: 'string',
      icon: 'string',
      name: 'string',
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
  bundleId?: string;
  miniAppId?: string;
  sourceBundleId?: string;
  sourceVersion?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      sourceBundleId: 'sourceBundleId',
      sourceVersion: 'sourceVersion',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
      sourceBundleId: 'string',
      sourceVersion: 'string',
      version: 'string',
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
  bundleId?: string;
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
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

export class GetMiniAppMetaDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMiniAppMetaDataRequest extends $tea.Model {
  bundleId?: string;
  bundleIdTableGmtModified?: { [key: string]: any };
  fromAppName?: string;
  miniAppIdTableGmtModified?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      bundleIdTableGmtModified: 'bundleIdTableGmtModified',
      fromAppName: 'fromAppName',
      miniAppIdTableGmtModified: 'miniAppIdTableGmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      bundleIdTableGmtModified: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      fromAppName: 'string',
      miniAppIdTableGmtModified: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMiniAppMetaDataResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: GetMiniAppMetaDataResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: GetMiniAppMetaDataResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMiniAppMetaDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMiniAppMetaDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMiniAppMetaDataResponseBody,
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
  bundleId?: string;
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
      version: 'string',
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
  bundleId?: string;
  miniAppId?: string;
  pageNum?: number;
  pageSize?: number;
  versionTypeSet?: number[];
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      pageNum: 'pageNum',
      pageSize: 'pageSize',
      versionTypeSet: 'versionTypeSet',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
      pageNum: 'number',
      pageSize: 'number',
      versionTypeSet: { 'type': 'array', 'itemType': 'number' },
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
  bundleId?: string;
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
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
  buildH5Bundle?: boolean;
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      buildH5Bundle: 'buildH5Bundle',
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buildH5Bundle: 'boolean',
      miniAppId: 'string',
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
  bundleId?: string;
  miniAppId?: string;
  version?: string;
  versionType?: number;
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      version: 'version',
      versionType: 'versionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
      version: 'string',
      versionType: 'number',
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

export class GetMiniAppMetaDataResponseBodyResult extends $tea.Model {
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

export class ListAvaiableVersionResponseBodyVersions extends $tea.Model {
  buildStatus?: number;
  h5Bundle?: string;
  packageSize?: string;
  packageUrl?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      buildStatus: 'buildStatus',
      h5Bundle: 'h5Bundle',
      packageSize: 'packageSize',
      packageUrl: 'packageUrl',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buildStatus: 'number',
      h5Bundle: 'string',
      packageSize: 'string',
      packageUrl: 'string',
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


  async createMiniApp(request: CreateMiniAppRequest): Promise<CreateMiniAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMiniAppHeaders({ });
    return await this.createMiniAppWithOptions(request, headers, runtime);
  }

  async createMiniAppWithOptions(request: CreateMiniAppRequest, headers: CreateMiniAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMiniAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateMiniAppResponse>(await this.doROARequest("CreateMiniApp", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/apps`, "json", req, runtime), new CreateMiniAppResponse({}));
  }

  async createMiniAppPlugin(request: CreateMiniAppPluginRequest): Promise<CreateMiniAppPluginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMiniAppPluginHeaders({ });
    return await this.createMiniAppPluginWithOptions(request, headers, runtime);
  }

  async createMiniAppPluginWithOptions(request: CreateMiniAppPluginRequest, headers: CreateMiniAppPluginHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMiniAppPluginResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateMiniAppPluginResponse>(await this.doROARequest("CreateMiniAppPlugin", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/plugins`, "json", req, runtime), new CreateMiniAppPluginResponse({}));
  }

  async createVersionAcrossBundle(request: CreateVersionAcrossBundleRequest): Promise<CreateVersionAcrossBundleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVersionAcrossBundleHeaders({ });
    return await this.createVersionAcrossBundleWithOptions(request, headers, runtime);
  }

  async createVersionAcrossBundleWithOptions(request: CreateVersionAcrossBundleRequest, headers: CreateVersionAcrossBundleHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVersionAcrossBundleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.sourceBundleId)) {
      body["sourceBundleId"] = request.sourceBundleId;
    }

    if (!Util.isUnset(request.sourceVersion)) {
      body["sourceVersion"] = request.sourceVersion;
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
    return $tea.cast<CreateVersionAcrossBundleResponse>(await this.doROARequest("CreateVersionAcrossBundle", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/versions/createAcrossBundle`, "json", req, runtime), new CreateVersionAcrossBundleResponse({}));
  }

  async getMaxVersion(request: GetMaxVersionRequest): Promise<GetMaxVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMaxVersionHeaders({ });
    return await this.getMaxVersionWithOptions(request, headers, runtime);
  }

  async getMaxVersionWithOptions(request: GetMaxVersionRequest, headers: GetMaxVersionHeaders, runtime: $Util.RuntimeOptions): Promise<GetMaxVersionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      query["bundleId"] = request.bundleId;
    }

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
    return $tea.cast<GetMaxVersionResponse>(await this.doROARequest("GetMaxVersion", "miniapp_1.0", "HTTP", "GET", "AK", `/v1.0/miniapp/apps/maxVersions`, "json", req, runtime), new GetMaxVersionResponse({}));
  }

  async getMiniAppMetaData(request: GetMiniAppMetaDataRequest): Promise<GetMiniAppMetaDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMiniAppMetaDataHeaders({ });
    return await this.getMiniAppMetaDataWithOptions(request, headers, runtime);
  }

  async getMiniAppMetaDataWithOptions(request: GetMiniAppMetaDataRequest, headers: GetMiniAppMetaDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetMiniAppMetaDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.bundleIdTableGmtModified)) {
      body["bundleIdTableGmtModified"] = request.bundleIdTableGmtModified;
    }

    if (!Util.isUnset(request.fromAppName)) {
      body["fromAppName"] = request.fromAppName;
    }

    if (!Util.isUnset(request.miniAppIdTableGmtModified)) {
      body["miniAppIdTableGmtModified"] = request.miniAppIdTableGmtModified;
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
    return $tea.cast<GetMiniAppMetaDataResponse>(await this.doROARequest("GetMiniAppMetaData", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/apps/metadata`, "json", req, runtime), new GetMiniAppMetaDataResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetSettingByMiniAppIdResponse>(await this.doROARequest("GetSettingByMiniAppId", "miniapp_1.0", "HTTP", "GET", "AK", `/v1.0/miniapp/apps/settings`, "json", req, runtime), new GetSettingByMiniAppIdResponse({}));
  }

  async invokeHtmlBundleBuild(request: InvokeHtmlBundleBuildRequest): Promise<InvokeHtmlBundleBuildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InvokeHtmlBundleBuildHeaders({ });
    return await this.invokeHtmlBundleBuildWithOptions(request, headers, runtime);
  }

  async invokeHtmlBundleBuildWithOptions(request: InvokeHtmlBundleBuildRequest, headers: InvokeHtmlBundleBuildHeaders, runtime: $Util.RuntimeOptions): Promise<InvokeHtmlBundleBuildResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

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
    return $tea.cast<InvokeHtmlBundleBuildResponse>(await this.doROARequest("InvokeHtmlBundleBuild", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/h5Bundles/build`, "json", req, runtime), new InvokeHtmlBundleBuildResponse({}));
  }

  async listAvaiableVersion(request: ListAvaiableVersionRequest): Promise<ListAvaiableVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAvaiableVersionHeaders({ });
    return await this.listAvaiableVersionWithOptions(request, headers, runtime);
  }

  async listAvaiableVersionWithOptions(request: ListAvaiableVersionRequest, headers: ListAvaiableVersionHeaders, runtime: $Util.RuntimeOptions): Promise<ListAvaiableVersionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.pageNum)) {
      body["pageNum"] = request.pageNum;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.versionTypeSet)) {
      body["versionTypeSet"] = request.versionTypeSet;
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
    return $tea.cast<ListAvaiableVersionResponse>(await this.doROARequest("ListAvaiableVersion", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/apps/versions/query`, "json", req, runtime), new ListAvaiableVersionResponse({}));
  }

  async queryHtmlBundleBuild(request: QueryHtmlBundleBuildRequest): Promise<QueryHtmlBundleBuildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHtmlBundleBuildHeaders({ });
    return await this.queryHtmlBundleBuildWithOptions(request, headers, runtime);
  }

  async queryHtmlBundleBuildWithOptions(request: QueryHtmlBundleBuildRequest, headers: QueryHtmlBundleBuildHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHtmlBundleBuildResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      query["bundleId"] = request.bundleId;
    }

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
    return $tea.cast<QueryHtmlBundleBuildResponse>(await this.doROARequest("QueryHtmlBundleBuild", "miniapp_1.0", "HTTP", "GET", "AK", `/v1.0/miniapp/h5Bundles/buildResults`, "json", req, runtime), new QueryHtmlBundleBuildResponse({}));
  }

  async setExtendSetting(request: SetExtendSettingRequest): Promise<SetExtendSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetExtendSettingHeaders({ });
    return await this.setExtendSettingWithOptions(request, headers, runtime);
  }

  async setExtendSettingWithOptions(request: SetExtendSettingRequest, headers: SetExtendSettingHeaders, runtime: $Util.RuntimeOptions): Promise<SetExtendSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.buildH5Bundle)) {
      body["buildH5Bundle"] = request.buildH5Bundle;
    }

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
    return $tea.cast<SetExtendSettingResponse>(await this.doROARequest("SetExtendSetting", "miniapp_1.0", "HTTP", "PUT", "AK", `/v1.0/miniapp/apps/settings`, "json", req, runtime), new SetExtendSettingResponse({}));
  }

  async updateVersionStatus(request: UpdateVersionStatusRequest): Promise<UpdateVersionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVersionStatusHeaders({ });
    return await this.updateVersionStatusWithOptions(request, headers, runtime);
  }

  async updateVersionStatusWithOptions(request: UpdateVersionStatusRequest, headers: UpdateVersionStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVersionStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
    }

    if (!Util.isUnset(request.versionType)) {
      body["versionType"] = request.versionType;
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
    return $tea.cast<UpdateVersionStatusResponse>(await this.doROARequest("UpdateVersionStatus", "miniapp_1.0", "HTTP", "POST", "AK", `/v1.0/miniapp/versions/status`, "json", req, runtime), new UpdateVersionStatusResponse({}));
  }

}
