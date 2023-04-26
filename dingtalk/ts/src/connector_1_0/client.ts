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

export class CreateActionHeaders extends $tea.Model {
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

export class CreateActionRequest extends $tea.Model {
  actionInfo?: CreateActionRequestActionInfo[];
  integratorFlag?: string;
  static names(): { [key: string]: string } {
    return {
      actionInfo: 'actionInfo',
      integratorFlag: 'integratorFlag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionInfo: { 'type': 'array', 'itemType': CreateActionRequestActionInfo },
      integratorFlag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionResponseBody extends $tea.Model {
  item?: CreateActionResponseBodyItem[];
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: { 'type': 'array', 'itemType': CreateActionResponseBodyItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateActionResponseBody;
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
      body: CreateActionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConnectorHeaders extends $tea.Model {
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

export class CreateConnectorRequest extends $tea.Model {
  connectorInfo?: CreateConnectorRequestConnectorInfo[];
  integratorFlag?: string;
  static names(): { [key: string]: string } {
    return {
      connectorInfo: 'connectorInfo',
      integratorFlag: 'integratorFlag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectorInfo: { 'type': 'array', 'itemType': CreateConnectorRequestConnectorInfo },
      integratorFlag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConnectorResponseBody extends $tea.Model {
  item?: CreateConnectorResponseBodyItem[];
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: { 'type': 'array', 'itemType': CreateConnectorResponseBodyItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConnectorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateConnectorResponseBody;
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
      body: CreateConnectorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInvocableInstanceHeaders extends $tea.Model {
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

export class CreateInvocableInstanceRequest extends $tea.Model {
  connectAssetUri?: string;
  instanceKey?: string;
  static names(): { [key: string]: string } {
    return {
      connectAssetUri: 'connectAssetUri',
      instanceKey: 'instanceKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectAssetUri: 'string',
      instanceKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInvocableInstanceResponseBody extends $tea.Model {
  connectAssetUri?: string;
  versionId?: string;
  static names(): { [key: string]: string } {
    return {
      connectAssetUri: 'connectAssetUri',
      versionId: 'versionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectAssetUri: 'string',
      versionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInvocableInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateInvocableInstanceResponseBody;
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
      body: CreateInvocableInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTriggerHeaders extends $tea.Model {
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

export class CreateTriggerRequest extends $tea.Model {
  integratorFlag?: string;
  triggerInfo?: CreateTriggerRequestTriggerInfo[];
  static names(): { [key: string]: string } {
    return {
      integratorFlag: 'integratorFlag',
      triggerInfo: 'triggerInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      integratorFlag: 'string',
      triggerInfo: { 'type': 'array', 'itemType': CreateTriggerRequestTriggerInfo },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTriggerResponseBody extends $tea.Model {
  item?: CreateTriggerResponseBodyItem[];
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: { 'type': 'array', 'itemType': CreateTriggerResponseBodyItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTriggerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateTriggerResponseBody;
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
      body: CreateTriggerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActionDetailHeaders extends $tea.Model {
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

export class GetActionDetailRequest extends $tea.Model {
  connectAssetUri?: string;
  static names(): { [key: string]: string } {
    return {
      connectAssetUri: 'connectAssetUri',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectAssetUri: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActionDetailResponseBody extends $tea.Model {
  connectAssetUri?: string;
  inputSchema?: string;
  integrationConfig?: GetActionDetailResponseBodyIntegrationConfig;
  name?: string;
  outputSchema?: string;
  refId?: string;
  refProviderCorpId?: string;
  refType?: string;
  static names(): { [key: string]: string } {
    return {
      connectAssetUri: 'connectAssetUri',
      inputSchema: 'inputSchema',
      integrationConfig: 'integrationConfig',
      name: 'name',
      outputSchema: 'outputSchema',
      refId: 'refId',
      refProviderCorpId: 'refProviderCorpId',
      refType: 'refType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectAssetUri: 'string',
      inputSchema: 'string',
      integrationConfig: GetActionDetailResponseBodyIntegrationConfig,
      name: 'string',
      outputSchema: 'string',
      refId: 'string',
      refProviderCorpId: 'string',
      refType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActionDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetActionDetailResponseBody;
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
      body: GetActionDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvokeInstanceHeaders extends $tea.Model {
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

export class InvokeInstanceRequest extends $tea.Model {
  connectAssetUri?: string;
  inputJsonString?: string;
  instanceKey?: string;
  static names(): { [key: string]: string } {
    return {
      connectAssetUri: 'connectAssetUri',
      inputJsonString: 'inputJsonString',
      instanceKey: 'instanceKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectAssetUri: 'string',
      inputJsonString: 'string',
      instanceKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvokeInstanceResponseBody extends $tea.Model {
  cost?: number;
  errorCode?: string;
  errorMessage?: string;
  instanceId?: string;
  outputJson?: string;
  static names(): { [key: string]: string } {
    return {
      cost: 'cost',
      errorCode: 'errorCode',
      errorMessage: 'errorMessage',
      instanceId: 'instanceId',
      outputJson: 'outputJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cost: 'number',
      errorCode: 'string',
      errorMessage: 'string',
      instanceId: 'string',
      outputJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvokeInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InvokeInstanceResponseBody;
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
      body: InvokeInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageHeaders extends $tea.Model {
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

export class PullDataByPageRequest extends $tea.Model {
  appId?: string;
  dataModelId?: string;
  datetimeFilterField?: string;
  maxDatetime?: number;
  maxResults?: number;
  minDatetime?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      dataModelId: 'dataModelId',
      datetimeFilterField: 'datetimeFilterField',
      maxDatetime: 'maxDatetime',
      maxResults: 'maxResults',
      minDatetime: 'minDatetime',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      dataModelId: 'string',
      datetimeFilterField: 'string',
      maxDatetime: 'number',
      maxResults: 'number',
      minDatetime: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponseBody extends $tea.Model {
  list?: PullDataByPageResponseBodyList[];
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': PullDataByPageResponseBodyList },
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PullDataByPageResponseBody;
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
      body: PullDataByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkHeaders extends $tea.Model {
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

export class PullDataByPkRequest extends $tea.Model {
  appId?: string;
  primaryKey?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      primaryKey: 'primaryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      primaryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkResponseBody extends $tea.Model {
  dataCreateAppId?: string;
  dataCreateAppType?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  dataModifiedAppId?: string;
  dataModifiedAppType?: string;
  jsonData?: string;
  static names(): { [key: string]: string } {
    return {
      dataCreateAppId: 'dataCreateAppId',
      dataCreateAppType: 'dataCreateAppType',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      dataModifiedAppId: 'dataModifiedAppId',
      dataModifiedAppType: 'dataModifiedAppType',
      jsonData: 'jsonData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataCreateAppId: 'string',
      dataCreateAppType: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      dataModifiedAppId: 'string',
      dataModifiedAppType: 'string',
      jsonData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPkResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PullDataByPkResponseBody;
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
      body: PullDataByPkResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActionsHeaders extends $tea.Model {
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

export class SearchActionsRequest extends $tea.Model {
  connectorId?: string;
  connectorProviderCorpId?: string;
  integrationTypes?: string[];
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      connectorId: 'connectorId',
      connectorProviderCorpId: 'connectorProviderCorpId',
      integrationTypes: 'integrationTypes',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectorId: 'string',
      connectorProviderCorpId: 'string',
      integrationTypes: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActionsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: SearchActionsResponseBodyList[];
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
      list: { 'type': 'array', 'itemType': SearchActionsResponseBodyList },
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActionsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchActionsResponseBody;
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
      body: SearchActionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchConnectorsHeaders extends $tea.Model {
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

export class SearchConnectorsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchConnectorsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: SearchConnectorsResponseBodyList[];
  nextToken?: string;
  totalCount?: string;
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
      list: { 'type': 'array', 'itemType': SearchConnectorsResponseBodyList },
      nextToken: 'string',
      totalCount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchConnectorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SearchConnectorsResponseBody;
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
      body: SearchConnectorsResponseBody,
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
  appId?: string;
  triggerDataList?: SyncDataRequestTriggerDataList[];
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      triggerDataList: 'triggerDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      triggerDataList: { 'type': 'array', 'itemType': SyncDataRequestTriggerDataList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponseBody extends $tea.Model {
  list?: SyncDataResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': SyncDataResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SyncDataResponseBody;
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

export class UpdateActionHeaders extends $tea.Model {
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

export class UpdateActionRequest extends $tea.Model {
  actionInfo?: UpdateActionRequestActionInfo[];
  integratorFlag?: string;
  static names(): { [key: string]: string } {
    return {
      actionInfo: 'actionInfo',
      integratorFlag: 'integratorFlag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionInfo: { 'type': 'array', 'itemType': UpdateActionRequestActionInfo },
      integratorFlag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionResponseBody extends $tea.Model {
  item?: UpdateActionResponseBodyItem[];
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: { 'type': 'array', 'itemType': UpdateActionResponseBodyItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateActionResponseBody;
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
      body: UpdateActionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateConnectorHeaders extends $tea.Model {
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

export class UpdateConnectorRequest extends $tea.Model {
  connectorInfo?: UpdateConnectorRequestConnectorInfo[];
  integratorFlag?: string;
  static names(): { [key: string]: string } {
    return {
      connectorInfo: 'connectorInfo',
      integratorFlag: 'integratorFlag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      connectorInfo: { 'type': 'array', 'itemType': UpdateConnectorRequestConnectorInfo },
      integratorFlag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateConnectorResponseBody extends $tea.Model {
  item?: UpdateConnectorResponseBodyItem[];
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: { 'type': 'array', 'itemType': UpdateConnectorResponseBodyItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateConnectorResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateConnectorResponseBody;
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
      body: UpdateConnectorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTriggerHeaders extends $tea.Model {
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

export class UpdateTriggerRequest extends $tea.Model {
  integratorFlag?: string;
  triggerInfo?: UpdateTriggerRequestTriggerInfo[];
  static names(): { [key: string]: string } {
    return {
      integratorFlag: 'integratorFlag',
      triggerInfo: 'triggerInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      integratorFlag: 'string',
      triggerInfo: { 'type': 'array', 'itemType': UpdateTriggerRequestTriggerInfo },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTriggerResponseBody extends $tea.Model {
  item?: UpdateTriggerResponseBodyItem[];
  static names(): { [key: string]: string } {
    return {
      item: 'item',
    };
  }

  static types(): { [key: string]: any } {
    return {
      item: { 'type': 'array', 'itemType': UpdateTriggerResponseBodyItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTriggerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateTriggerResponseBody;
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
      body: UpdateTriggerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionRequestActionInfoInputMappingConfig extends $tea.Model {
  customSchemaMapping?: string;
  rules?: string;
  static names(): { [key: string]: string } {
    return {
      customSchemaMapping: 'customSchemaMapping',
      rules: 'rules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customSchemaMapping: 'string',
      rules: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionRequestActionInfoOutputDataRules extends $tea.Model {
  expectValue?: string;
  operate?: string;
  propertyPath?: string;
  static names(): { [key: string]: string } {
    return {
      expectValue: 'expectValue',
      operate: 'operate',
      propertyPath: 'propertyPath',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expectValue: 'string',
      operate: 'string',
      propertyPath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionRequestActionInfoOutputMappingConfig extends $tea.Model {
  customSchemaMapping?: string;
  rules?: string;
  static names(): { [key: string]: string } {
    return {
      customSchemaMapping: 'customSchemaMapping',
      rules: 'rules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customSchemaMapping: 'string',
      rules: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionRequestActionInfo extends $tea.Model {
  apiPath?: string;
  description?: string;
  dingConnectorId?: string;
  inputMappingConfig?: CreateActionRequestActionInfoInputMappingConfig;
  inputSchema?: string;
  integratorActionId?: string;
  integratorConnectorId?: string;
  name?: string;
  outputDataRules?: CreateActionRequestActionInfoOutputDataRules[];
  outputMappingConfig?: CreateActionRequestActionInfoOutputMappingConfig;
  outputSchema?: string;
  static names(): { [key: string]: string } {
    return {
      apiPath: 'apiPath',
      description: 'description',
      dingConnectorId: 'dingConnectorId',
      inputMappingConfig: 'inputMappingConfig',
      inputSchema: 'inputSchema',
      integratorActionId: 'integratorActionId',
      integratorConnectorId: 'integratorConnectorId',
      name: 'name',
      outputDataRules: 'outputDataRules',
      outputMappingConfig: 'outputMappingConfig',
      outputSchema: 'outputSchema',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiPath: 'string',
      description: 'string',
      dingConnectorId: 'string',
      inputMappingConfig: CreateActionRequestActionInfoInputMappingConfig,
      inputSchema: 'string',
      integratorActionId: 'string',
      integratorConnectorId: 'string',
      name: 'string',
      outputDataRules: { 'type': 'array', 'itemType': CreateActionRequestActionInfoOutputDataRules },
      outputMappingConfig: CreateActionRequestActionInfoOutputMappingConfig,
      outputSchema: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActionResponseBodyItem extends $tea.Model {
  dingActionId?: string;
  dingConnectorId?: string;
  integratorActionId?: string;
  integratorConnectorId?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: string;
  static names(): { [key: string]: string } {
    return {
      dingActionId: 'dingActionId',
      dingConnectorId: 'dingConnectorId',
      integratorActionId: 'integratorActionId',
      integratorConnectorId: 'integratorConnectorId',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingActionId: 'string',
      dingConnectorId: 'string',
      integratorActionId: 'string',
      integratorConnectorId: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConnectorRequestConnectorInfo extends $tea.Model {
  apiDomain?: string;
  apiSecret?: string;
  appId?: number;
  authValueEnv?: boolean;
  description?: string;
  domainEnv?: boolean;
  iconMediaId?: string;
  integratorConnectorId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      apiDomain: 'apiDomain',
      apiSecret: 'apiSecret',
      appId: 'appId',
      authValueEnv: 'authValueEnv',
      description: 'description',
      domainEnv: 'domainEnv',
      iconMediaId: 'iconMediaId',
      integratorConnectorId: 'integratorConnectorId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiDomain: 'string',
      apiSecret: 'string',
      appId: 'number',
      authValueEnv: 'boolean',
      description: 'string',
      domainEnv: 'boolean',
      iconMediaId: 'string',
      integratorConnectorId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateConnectorResponseBodyItem extends $tea.Model {
  dingConnectorId?: string;
  integratorConnectorId?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingConnectorId: 'dingConnectorId',
      integratorConnectorId: 'integratorConnectorId',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingConnectorId: 'string',
      integratorConnectorId: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTriggerRequestTriggerInfo extends $tea.Model {
  description?: string;
  dingConnectorId?: string;
  inputSchema?: string;
  integratorConnectorId?: string;
  integratorTriggerId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      dingConnectorId: 'dingConnectorId',
      inputSchema: 'inputSchema',
      integratorConnectorId: 'integratorConnectorId',
      integratorTriggerId: 'integratorTriggerId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      dingConnectorId: 'string',
      inputSchema: 'string',
      integratorConnectorId: 'string',
      integratorTriggerId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTriggerResponseBodyItem extends $tea.Model {
  dingConnectorId?: string;
  dingTriggerId?: string;
  integratorConnectorId?: string;
  integratorTriggerId?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingConnectorId: 'dingConnectorId',
      dingTriggerId: 'dingTriggerId',
      integratorConnectorId: 'integratorConnectorId',
      integratorTriggerId: 'integratorTriggerId',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingConnectorId: 'string',
      dingTriggerId: 'string',
      integratorConnectorId: 'string',
      integratorTriggerId: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActionDetailResponseBodyIntegrationConfigCategoryNames extends $tea.Model {
  value?: string;
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActionDetailResponseBodyIntegrationConfigProps extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetActionDetailResponseBodyIntegrationConfig extends $tea.Model {
  categoryNames?: GetActionDetailResponseBodyIntegrationConfigCategoryNames[];
  entityName?: string;
  props?: GetActionDetailResponseBodyIntegrationConfigProps[];
  static names(): { [key: string]: string } {
    return {
      categoryNames: 'categoryNames',
      entityName: 'entityName',
      props: 'props',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryNames: { 'type': 'array', 'itemType': GetActionDetailResponseBodyIntegrationConfigCategoryNames },
      entityName: 'string',
      props: { 'type': 'array', 'itemType': GetActionDetailResponseBodyIntegrationConfigProps },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PullDataByPageResponseBodyList extends $tea.Model {
  dataCreateAppId?: string;
  dataCreateAppType?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  dataModifiedAppId?: string;
  dataModifiedAppType?: string;
  jsonData?: string;
  static names(): { [key: string]: string } {
    return {
      dataCreateAppId: 'dataCreateAppId',
      dataCreateAppType: 'dataCreateAppType',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      dataModifiedAppId: 'dataModifiedAppId',
      dataModifiedAppType: 'dataModifiedAppType',
      jsonData: 'jsonData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataCreateAppId: 'string',
      dataCreateAppType: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      dataModifiedAppId: 'string',
      dataModifiedAppType: 'string',
      jsonData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchActionsResponseBodyList extends $tea.Model {
  authorityUrl?: string;
  authorized?: boolean;
  connectAssetUri?: string;
  connectorId?: string;
  description?: string;
  icon?: string;
  id?: string;
  integrationType?: string;
  name?: string;
  providerCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      authorityUrl: 'authorityUrl',
      authorized: 'authorized',
      connectAssetUri: 'connectAssetUri',
      connectorId: 'connectorId',
      description: 'description',
      icon: 'icon',
      id: 'id',
      integrationType: 'integrationType',
      name: 'name',
      providerCorpId: 'providerCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorityUrl: 'string',
      authorized: 'boolean',
      connectAssetUri: 'string',
      connectorId: 'string',
      description: 'string',
      icon: 'string',
      id: 'string',
      integrationType: 'string',
      name: 'string',
      providerCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchConnectorsResponseBodyList extends $tea.Model {
  description?: string;
  icon?: string;
  id?: string;
  name?: string;
  providerCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      icon: 'icon',
      id: 'id',
      name: 'name',
      providerCorpId: 'providerCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      icon: 'string',
      id: 'string',
      name: 'string',
      providerCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataRequestTriggerDataList extends $tea.Model {
  action?: string;
  customTriggerId?: string;
  dataGmtCreate?: number;
  dataGmtModified?: number;
  integrationObject?: string;
  jsonData?: string;
  triggerCondition?: string;
  triggerId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      customTriggerId: 'customTriggerId',
      dataGmtCreate: 'dataGmtCreate',
      dataGmtModified: 'dataGmtModified',
      integrationObject: 'integrationObject',
      jsonData: 'jsonData',
      triggerCondition: 'triggerCondition',
      triggerId: 'triggerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      customTriggerId: 'string',
      dataGmtCreate: 'number',
      dataGmtModified: 'number',
      integrationObject: 'string',
      jsonData: 'string',
      triggerCondition: 'string',
      triggerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataResponseBodyList extends $tea.Model {
  bizPrimaryKey?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: boolean;
  triggerId?: string;
  static names(): { [key: string]: string } {
    return {
      bizPrimaryKey: 'bizPrimaryKey',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
      triggerId: 'triggerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizPrimaryKey: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'boolean',
      triggerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionRequestActionInfoInputMappingConfig extends $tea.Model {
  customSchemaMapping?: string;
  rules?: string;
  static names(): { [key: string]: string } {
    return {
      customSchemaMapping: 'customSchemaMapping',
      rules: 'rules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customSchemaMapping: 'string',
      rules: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionRequestActionInfoOutputDataRules extends $tea.Model {
  expectValue?: string;
  operate?: string;
  propertyPath?: string;
  static names(): { [key: string]: string } {
    return {
      expectValue: 'expectValue',
      operate: 'operate',
      propertyPath: 'propertyPath',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expectValue: 'string',
      operate: 'string',
      propertyPath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionRequestActionInfoOutputMappingConfig extends $tea.Model {
  customSchemaMapping?: string;
  rules?: string;
  static names(): { [key: string]: string } {
    return {
      customSchemaMapping: 'customSchemaMapping',
      rules: 'rules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customSchemaMapping: 'string',
      rules: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionRequestActionInfo extends $tea.Model {
  apiPath?: string;
  description?: string;
  dingActionId?: string;
  dingConnectorId?: string;
  inputMappingConfig?: UpdateActionRequestActionInfoInputMappingConfig;
  inputSchema?: string;
  integratorActionId?: string;
  integratorConnectorId?: string;
  name?: string;
  outputDataRules?: UpdateActionRequestActionInfoOutputDataRules[];
  outputMappingConfig?: UpdateActionRequestActionInfoOutputMappingConfig;
  outputSchema?: string;
  static names(): { [key: string]: string } {
    return {
      apiPath: 'apiPath',
      description: 'description',
      dingActionId: 'dingActionId',
      dingConnectorId: 'dingConnectorId',
      inputMappingConfig: 'inputMappingConfig',
      inputSchema: 'inputSchema',
      integratorActionId: 'integratorActionId',
      integratorConnectorId: 'integratorConnectorId',
      name: 'name',
      outputDataRules: 'outputDataRules',
      outputMappingConfig: 'outputMappingConfig',
      outputSchema: 'outputSchema',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiPath: 'string',
      description: 'string',
      dingActionId: 'string',
      dingConnectorId: 'string',
      inputMappingConfig: UpdateActionRequestActionInfoInputMappingConfig,
      inputSchema: 'string',
      integratorActionId: 'string',
      integratorConnectorId: 'string',
      name: 'string',
      outputDataRules: { 'type': 'array', 'itemType': UpdateActionRequestActionInfoOutputDataRules },
      outputMappingConfig: UpdateActionRequestActionInfoOutputMappingConfig,
      outputSchema: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateActionResponseBodyItem extends $tea.Model {
  dingActionId?: string;
  dingConnectorId?: string;
  integratorActionId?: string;
  integratorConnectorId?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: string;
  static names(): { [key: string]: string } {
    return {
      dingActionId: 'dingActionId',
      dingConnectorId: 'dingConnectorId',
      integratorActionId: 'integratorActionId',
      integratorConnectorId: 'integratorConnectorId',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingActionId: 'string',
      dingConnectorId: 'string',
      integratorActionId: 'string',
      integratorConnectorId: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateConnectorRequestConnectorInfo extends $tea.Model {
  apiDomain?: string;
  apiSecret?: string;
  appId?: number;
  authValueEnv?: boolean;
  description?: string;
  dingConnectorId?: string;
  domainEnv?: boolean;
  iconMediaId?: string;
  integratorConnectorId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      apiDomain: 'apiDomain',
      apiSecret: 'apiSecret',
      appId: 'appId',
      authValueEnv: 'authValueEnv',
      description: 'description',
      dingConnectorId: 'dingConnectorId',
      domainEnv: 'domainEnv',
      iconMediaId: 'iconMediaId',
      integratorConnectorId: 'integratorConnectorId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiDomain: 'string',
      apiSecret: 'string',
      appId: 'number',
      authValueEnv: 'boolean',
      description: 'string',
      dingConnectorId: 'string',
      domainEnv: 'boolean',
      iconMediaId: 'string',
      integratorConnectorId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateConnectorResponseBodyItem extends $tea.Model {
  dingConnectorId?: string;
  integratorConnectorId?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingConnectorId: 'dingConnectorId',
      integratorConnectorId: 'integratorConnectorId',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingConnectorId: 'string',
      integratorConnectorId: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTriggerRequestTriggerInfo extends $tea.Model {
  description?: string;
  dingConnectorId?: string;
  dingTriggerId?: string;
  inputSchema?: string;
  integratorConnectorId?: string;
  integratorTriggerId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      dingConnectorId: 'dingConnectorId',
      dingTriggerId: 'dingTriggerId',
      inputSchema: 'inputSchema',
      integratorConnectorId: 'integratorConnectorId',
      integratorTriggerId: 'integratorTriggerId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      dingConnectorId: 'string',
      dingTriggerId: 'string',
      inputSchema: 'string',
      integratorConnectorId: 'string',
      integratorTriggerId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTriggerResponseBodyItem extends $tea.Model {
  dingConnectorId?: string;
  dingTriggerId?: string;
  integratorConnectorId?: string;
  integratorTriggerId?: string;
  subErrCode?: string;
  subErrMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingConnectorId: 'dingConnectorId',
      dingTriggerId: 'dingTriggerId',
      integratorConnectorId: 'integratorConnectorId',
      integratorTriggerId: 'integratorTriggerId',
      subErrCode: 'subErrCode',
      subErrMsg: 'subErrMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingConnectorId: 'string',
      dingTriggerId: 'string',
      integratorConnectorId: 'string',
      integratorTriggerId: 'string',
      subErrCode: 'string',
      subErrMsg: 'string',
      success: 'boolean',
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


  async createActionWithOptions(request: CreateActionRequest, headers: CreateActionHeaders, runtime: $Util.RuntimeOptions): Promise<CreateActionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionInfo)) {
      body["actionInfo"] = request.actionInfo;
    }

    if (!Util.isUnset(request.integratorFlag)) {
      body["integratorFlag"] = request.integratorFlag;
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
      action: "CreateAction",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/actions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateActionResponse>(await this.execute(params, req, runtime), new CreateActionResponse({}));
  }

  async createAction(request: CreateActionRequest): Promise<CreateActionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateActionHeaders({ });
    return await this.createActionWithOptions(request, headers, runtime);
  }

  async createConnectorWithOptions(request: CreateConnectorRequest, headers: CreateConnectorHeaders, runtime: $Util.RuntimeOptions): Promise<CreateConnectorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.connectorInfo)) {
      body["connectorInfo"] = request.connectorInfo;
    }

    if (!Util.isUnset(request.integratorFlag)) {
      body["integratorFlag"] = request.integratorFlag;
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
      action: "CreateConnector",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/connectors`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateConnectorResponse>(await this.execute(params, req, runtime), new CreateConnectorResponse({}));
  }

  async createConnector(request: CreateConnectorRequest): Promise<CreateConnectorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateConnectorHeaders({ });
    return await this.createConnectorWithOptions(request, headers, runtime);
  }

  async createInvocableInstanceWithOptions(request: CreateInvocableInstanceRequest, headers: CreateInvocableInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInvocableInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.connectAssetUri)) {
      body["connectAssetUri"] = request.connectAssetUri;
    }

    if (!Util.isUnset(request.instanceKey)) {
      body["instanceKey"] = request.instanceKey;
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
      action: "CreateInvocableInstance",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateInvocableInstanceResponse>(await this.execute(params, req, runtime), new CreateInvocableInstanceResponse({}));
  }

  async createInvocableInstance(request: CreateInvocableInstanceRequest): Promise<CreateInvocableInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInvocableInstanceHeaders({ });
    return await this.createInvocableInstanceWithOptions(request, headers, runtime);
  }

  async createTriggerWithOptions(request: CreateTriggerRequest, headers: CreateTriggerHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTriggerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.integratorFlag)) {
      body["integratorFlag"] = request.integratorFlag;
    }

    if (!Util.isUnset(request.triggerInfo)) {
      body["triggerInfo"] = request.triggerInfo;
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
      action: "CreateTrigger",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/triggers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTriggerResponse>(await this.execute(params, req, runtime), new CreateTriggerResponse({}));
  }

  async createTrigger(request: CreateTriggerRequest): Promise<CreateTriggerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTriggerHeaders({ });
    return await this.createTriggerWithOptions(request, headers, runtime);
  }

  async getActionDetailWithOptions(request: GetActionDetailRequest, headers: GetActionDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetActionDetailResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.connectAssetUri)) {
      body["connectAssetUri"] = request.connectAssetUri;
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
      action: "GetActionDetail",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/assets/actions/details/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetActionDetailResponse>(await this.execute(params, req, runtime), new GetActionDetailResponse({}));
  }

  async getActionDetail(request: GetActionDetailRequest): Promise<GetActionDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetActionDetailHeaders({ });
    return await this.getActionDetailWithOptions(request, headers, runtime);
  }

  async invokeInstanceWithOptions(request: InvokeInstanceRequest, headers: InvokeInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<InvokeInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.connectAssetUri)) {
      body["connectAssetUri"] = request.connectAssetUri;
    }

    if (!Util.isUnset(request.inputJsonString)) {
      body["inputJsonString"] = request.inputJsonString;
    }

    if (!Util.isUnset(request.instanceKey)) {
      body["instanceKey"] = request.instanceKey;
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
      action: "InvokeInstance",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/instances/invoke`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InvokeInstanceResponse>(await this.execute(params, req, runtime), new InvokeInstanceResponse({}));
  }

  async invokeInstance(request: InvokeInstanceRequest): Promise<InvokeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InvokeInstanceHeaders({ });
    return await this.invokeInstanceWithOptions(request, headers, runtime);
  }

  async pullDataByPageWithOptions(request: PullDataByPageRequest, headers: PullDataByPageHeaders, runtime: $Util.RuntimeOptions): Promise<PullDataByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.dataModelId)) {
      query["dataModelId"] = request.dataModelId;
    }

    if (!Util.isUnset(request.datetimeFilterField)) {
      query["datetimeFilterField"] = request.datetimeFilterField;
    }

    if (!Util.isUnset(request.maxDatetime)) {
      query["maxDatetime"] = request.maxDatetime;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.minDatetime)) {
      query["minDatetime"] = request.minDatetime;
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
      action: "PullDataByPage",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/data`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PullDataByPageResponse>(await this.execute(params, req, runtime), new PullDataByPageResponse({}));
  }

  async pullDataByPage(request: PullDataByPageRequest): Promise<PullDataByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullDataByPageHeaders({ });
    return await this.pullDataByPageWithOptions(request, headers, runtime);
  }

  async pullDataByPkWithOptions(dataModelId: string, request: PullDataByPkRequest, headers: PullDataByPkHeaders, runtime: $Util.RuntimeOptions): Promise<PullDataByPkResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.primaryKey)) {
      query["primaryKey"] = request.primaryKey;
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
      action: "PullDataByPk",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/data/${dataModelId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PullDataByPkResponse>(await this.execute(params, req, runtime), new PullDataByPkResponse({}));
  }

  async pullDataByPk(dataModelId: string, request: PullDataByPkRequest): Promise<PullDataByPkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PullDataByPkHeaders({ });
    return await this.pullDataByPkWithOptions(dataModelId, request, headers, runtime);
  }

  async searchActionsWithOptions(request: SearchActionsRequest, headers: SearchActionsHeaders, runtime: $Util.RuntimeOptions): Promise<SearchActionsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.connectorId)) {
      body["connectorId"] = request.connectorId;
    }

    if (!Util.isUnset(request.connectorProviderCorpId)) {
      body["connectorProviderCorpId"] = request.connectorProviderCorpId;
    }

    if (!Util.isUnset(request.integrationTypes)) {
      body["integrationTypes"] = request.integrationTypes;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
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
      action: "SearchActions",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/assets/actions/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchActionsResponse>(await this.execute(params, req, runtime), new SearchActionsResponse({}));
  }

  async searchActions(request: SearchActionsRequest): Promise<SearchActionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchActionsHeaders({ });
    return await this.searchActionsWithOptions(request, headers, runtime);
  }

  async searchConnectorsWithOptions(request: SearchConnectorsRequest, headers: SearchConnectorsHeaders, runtime: $Util.RuntimeOptions): Promise<SearchConnectorsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
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
      action: "SearchConnectors",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/assets/connectors`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchConnectorsResponse>(await this.execute(params, req, runtime), new SearchConnectorsResponse({}));
  }

  async searchConnectors(request: SearchConnectorsRequest): Promise<SearchConnectorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchConnectorsHeaders({ });
    return await this.searchConnectorsWithOptions(request, headers, runtime);
  }

  async syncDataWithOptions(request: SyncDataRequest, headers: SyncDataHeaders, runtime: $Util.RuntimeOptions): Promise<SyncDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.triggerDataList)) {
      body["triggerDataList"] = request.triggerDataList;
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
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/triggers/data/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncDataResponse>(await this.execute(params, req, runtime), new SyncDataResponse({}));
  }

  async syncData(request: SyncDataRequest): Promise<SyncDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncDataHeaders({ });
    return await this.syncDataWithOptions(request, headers, runtime);
  }

  async updateActionWithOptions(request: UpdateActionRequest, headers: UpdateActionHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateActionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionInfo)) {
      body["actionInfo"] = request.actionInfo;
    }

    if (!Util.isUnset(request.integratorFlag)) {
      body["integratorFlag"] = request.integratorFlag;
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
      action: "UpdateAction",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/actions`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateActionResponse>(await this.execute(params, req, runtime), new UpdateActionResponse({}));
  }

  async updateAction(request: UpdateActionRequest): Promise<UpdateActionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateActionHeaders({ });
    return await this.updateActionWithOptions(request, headers, runtime);
  }

  async updateConnectorWithOptions(request: UpdateConnectorRequest, headers: UpdateConnectorHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateConnectorResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.connectorInfo)) {
      body["connectorInfo"] = request.connectorInfo;
    }

    if (!Util.isUnset(request.integratorFlag)) {
      body["integratorFlag"] = request.integratorFlag;
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
      action: "UpdateConnector",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/connectors`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateConnectorResponse>(await this.execute(params, req, runtime), new UpdateConnectorResponse({}));
  }

  async updateConnector(request: UpdateConnectorRequest): Promise<UpdateConnectorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateConnectorHeaders({ });
    return await this.updateConnectorWithOptions(request, headers, runtime);
  }

  async updateTriggerWithOptions(request: UpdateTriggerRequest, headers: UpdateTriggerHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTriggerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.integratorFlag)) {
      body["integratorFlag"] = request.integratorFlag;
    }

    if (!Util.isUnset(request.triggerInfo)) {
      body["triggerInfo"] = request.triggerInfo;
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
      action: "UpdateTrigger",
      version: "connector_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/connector/triggers`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTriggerResponse>(await this.execute(params, req, runtime), new UpdateTriggerResponse({}));
  }

  async updateTrigger(request: UpdateTriggerRequest): Promise<UpdateTriggerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTriggerHeaders({ });
    return await this.updateTriggerWithOptions(request, headers, runtime);
  }

}
