// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
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
  /**
   * @remarks
   * This parameter is required.
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: number;
  bundleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  desc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateMiniAppResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  bizType?: number;
  bundleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  desc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateMiniAppPluginResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateVersionAcrossBundleResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMaxVersionResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMiniAppMetaDataResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSettingByMiniAppIdResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  bundleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  miniAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InvokeHtmlBundleBuildResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  bundleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  miniAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pageNum?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAvaiableVersionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryHtmlBundleBuildResponseBody;
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
      body: QueryHtmlBundleBuildResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollBackVersionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bundleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  miniAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  rollbackVersion?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  targetVersion?: string;
  static names(): { [key: string]: string } {
    return {
      bundleId: 'bundleId',
      miniAppId: 'miniAppId',
      rollbackVersion: 'rollbackVersion',
      targetVersion: 'targetVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bundleId: 'string',
      miniAppId: 'string',
      rollbackVersion: 'string',
      targetVersion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RollBackVersionResponseBody extends $tea.Model {
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

export class RollBackVersionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RollBackVersionResponseBody;
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
      body: RollBackVersionResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  buildH5Bundle?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SetExtendSettingResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  bundleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  miniAppId?: string;
  version?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateVersionStatusResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  buildStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  h5Bundle?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  packageSize?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  packageUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 创建小程序
   * 
   * @param request - CreateMiniAppRequest
   * @param headers - CreateMiniAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateMiniAppResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateMiniApp",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/apps`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateMiniAppResponse>(await this.execute(params, req, runtime), new CreateMiniAppResponse({}));
  }

  /**
   * 创建小程序
   * 
   * @param request - CreateMiniAppRequest
   * @returns CreateMiniAppResponse
   */
  async createMiniApp(request: CreateMiniAppRequest): Promise<CreateMiniAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMiniAppHeaders({ });
    return await this.createMiniAppWithOptions(request, headers, runtime);
  }

  /**
   * 创建小程序组件
   * 
   * @param request - CreateMiniAppPluginRequest
   * @param headers - CreateMiniAppPluginHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateMiniAppPluginResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateMiniAppPlugin",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/plugins`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateMiniAppPluginResponse>(await this.execute(params, req, runtime), new CreateMiniAppPluginResponse({}));
  }

  /**
   * 创建小程序组件
   * 
   * @param request - CreateMiniAppPluginRequest
   * @returns CreateMiniAppPluginResponse
   */
  async createMiniAppPlugin(request: CreateMiniAppPluginRequest): Promise<CreateMiniAppPluginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMiniAppPluginHeaders({ });
    return await this.createMiniAppPluginWithOptions(request, headers, runtime);
  }

  /**
   * 小程序多端发布版本
   * 
   * @param request - CreateVersionAcrossBundleRequest
   * @param headers - CreateVersionAcrossBundleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateVersionAcrossBundleResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateVersionAcrossBundle",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/versions/createAcrossBundle`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateVersionAcrossBundleResponse>(await this.execute(params, req, runtime), new CreateVersionAcrossBundleResponse({}));
  }

  /**
   * 小程序多端发布版本
   * 
   * @param request - CreateVersionAcrossBundleRequest
   * @returns CreateVersionAcrossBundleResponse
   */
  async createVersionAcrossBundle(request: CreateVersionAcrossBundleRequest): Promise<CreateVersionAcrossBundleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVersionAcrossBundleHeaders({ });
    return await this.createVersionAcrossBundleWithOptions(request, headers, runtime);
  }

  /**
   * 获取小程序最大的构建版本
   * 
   * @param request - GetMaxVersionRequest
   * @param headers - GetMaxVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMaxVersionResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetMaxVersion",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/apps/maxVersions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMaxVersionResponse>(await this.execute(params, req, runtime), new GetMaxVersionResponse({}));
  }

  /**
   * 获取小程序最大的构建版本
   * 
   * @param request - GetMaxVersionRequest
   * @returns GetMaxVersionResponse
   */
  async getMaxVersion(request: GetMaxVersionRequest): Promise<GetMaxVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMaxVersionHeaders({ });
    return await this.getMaxVersionWithOptions(request, headers, runtime);
  }

  /**
   * 同步小程序元数据
   * 
   * @param request - GetMiniAppMetaDataRequest
   * @param headers - GetMiniAppMetaDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMiniAppMetaDataResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetMiniAppMetaData",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/apps/metadata`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMiniAppMetaDataResponse>(await this.execute(params, req, runtime), new GetMiniAppMetaDataResponse({}));
  }

  /**
   * 同步小程序元数据
   * 
   * @param request - GetMiniAppMetaDataRequest
   * @returns GetMiniAppMetaDataResponse
   */
  async getMiniAppMetaData(request: GetMiniAppMetaDataRequest): Promise<GetMiniAppMetaDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMiniAppMetaDataHeaders({ });
    return await this.getMiniAppMetaDataWithOptions(request, headers, runtime);
  }

  /**
   * 查询小程序配置
   * 
   * @param headers - GetSettingByMiniAppIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSettingByMiniAppIdResponse
   */
  async getSettingByMiniAppIdWithOptions(miniAppId: string, headers: GetSettingByMiniAppIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetSettingByMiniAppIdResponse> {
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
      action: "GetSettingByMiniAppId",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/apps/settings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSettingByMiniAppIdResponse>(await this.execute(params, req, runtime), new GetSettingByMiniAppIdResponse({}));
  }

  /**
   * 查询小程序配置
   * @returns GetSettingByMiniAppIdResponse
   */
  async getSettingByMiniAppId(miniAppId: string): Promise<GetSettingByMiniAppIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSettingByMiniAppIdHeaders({ });
    return await this.getSettingByMiniAppIdWithOptions(miniAppId, headers, runtime);
  }

  /**
   * 构建H5Bundle
   * 
   * @param request - InvokeHtmlBundleBuildRequest
   * @param headers - InvokeHtmlBundleBuildHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InvokeHtmlBundleBuildResponse
   */
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
    let params = new $OpenApi.Params({
      action: "InvokeHtmlBundleBuild",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/h5Bundles/build`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InvokeHtmlBundleBuildResponse>(await this.execute(params, req, runtime), new InvokeHtmlBundleBuildResponse({}));
  }

  /**
   * 构建H5Bundle
   * 
   * @param request - InvokeHtmlBundleBuildRequest
   * @returns InvokeHtmlBundleBuildResponse
   */
  async invokeHtmlBundleBuild(request: InvokeHtmlBundleBuildRequest): Promise<InvokeHtmlBundleBuildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InvokeHtmlBundleBuildHeaders({ });
    return await this.invokeHtmlBundleBuildWithOptions(request, headers, runtime);
  }

  /**
   * 获取小程序版本列表
   * 
   * @param request - ListAvaiableVersionRequest
   * @param headers - ListAvaiableVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAvaiableVersionResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ListAvaiableVersion",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/apps/versions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAvaiableVersionResponse>(await this.execute(params, req, runtime), new ListAvaiableVersionResponse({}));
  }

  /**
   * 获取小程序版本列表
   * 
   * @param request - ListAvaiableVersionRequest
   * @returns ListAvaiableVersionResponse
   */
  async listAvaiableVersion(request: ListAvaiableVersionRequest): Promise<ListAvaiableVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAvaiableVersionHeaders({ });
    return await this.listAvaiableVersionWithOptions(request, headers, runtime);
  }

  /**
   * 查询H5构建结果
   * 
   * @param request - QueryHtmlBundleBuildRequest
   * @param headers - QueryHtmlBundleBuildHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryHtmlBundleBuildResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryHtmlBundleBuild",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/h5Bundles/buildResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHtmlBundleBuildResponse>(await this.execute(params, req, runtime), new QueryHtmlBundleBuildResponse({}));
  }

  /**
   * 查询H5构建结果
   * 
   * @param request - QueryHtmlBundleBuildRequest
   * @returns QueryHtmlBundleBuildResponse
   */
  async queryHtmlBundleBuild(request: QueryHtmlBundleBuildRequest): Promise<QueryHtmlBundleBuildResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHtmlBundleBuildHeaders({ });
    return await this.queryHtmlBundleBuildWithOptions(request, headers, runtime);
  }

  /**
   * 回滚版本
   * 
   * @param request - RollBackVersionRequest
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RollBackVersionResponse
   */
  async rollBackVersionWithOptions(request: RollBackVersionRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<RollBackVersionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bundleId)) {
      body["bundleId"] = request.bundleId;
    }

    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.rollbackVersion)) {
      body["rollbackVersion"] = request.rollbackVersion;
    }

    if (!Util.isUnset(request.targetVersion)) {
      body["targetVersion"] = request.targetVersion;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RollBackVersion",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/versions/rollback`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RollBackVersionResponse>(await this.execute(params, req, runtime), new RollBackVersionResponse({}));
  }

  /**
   * 回滚版本
   * 
   * @param request - RollBackVersionRequest
   * @returns RollBackVersionResponse
   */
  async rollBackVersion(request: RollBackVersionRequest): Promise<RollBackVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.rollBackVersionWithOptions(request, headers, runtime);
  }

  /**
   * 修改小程序配置
   * 
   * @param request - SetExtendSettingRequest
   * @param headers - SetExtendSettingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetExtendSettingResponse
   */
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
    let params = new $OpenApi.Params({
      action: "SetExtendSetting",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/apps/settings`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetExtendSettingResponse>(await this.execute(params, req, runtime), new SetExtendSettingResponse({}));
  }

  /**
   * 修改小程序配置
   * 
   * @param request - SetExtendSettingRequest
   * @returns SetExtendSettingResponse
   */
  async setExtendSetting(request: SetExtendSettingRequest): Promise<SetExtendSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetExtendSettingHeaders({ });
    return await this.setExtendSettingWithOptions(request, headers, runtime);
  }

  /**
   * 发布版本
   * 
   * @param request - UpdateVersionStatusRequest
   * @param headers - UpdateVersionStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateVersionStatusResponse
   */
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
    let params = new $OpenApi.Params({
      action: "UpdateVersionStatus",
      version: "miniapp_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/miniapp/versions/status`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateVersionStatusResponse>(await this.execute(params, req, runtime), new UpdateVersionStatusResponse({}));
  }

  /**
   * 发布版本
   * 
   * @param request - UpdateVersionStatusRequest
   * @returns UpdateVersionStatusResponse
   */
  async updateVersionStatus(request: UpdateVersionStatusRequest): Promise<UpdateVersionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVersionStatusHeaders({ });
    return await this.updateVersionStatusWithOptions(request, headers, runtime);
  }

}
