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

export class ResultItemsDentryAppPropertiesValue extends $tea.Model {
  name?: string;
  value?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
      visibility: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DentryAppPropertiesValue extends $tea.Model {
  name?: string;
  value?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
      visibility: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DentriesAppPropertiesValue extends $tea.Model {
  name?: string;
  value?: string;
  visibility?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
      visibility: 'visibility',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
      visibility: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesHeaders extends $tea.Model {
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

export class GetDentriesRequest extends $tea.Model {
  dentryIds?: string[];
  option?: GetDentriesRequestOption;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      option: GetDentriesRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBody extends $tea.Model {
  resultItems?: GetDentriesResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': GetDentriesResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDentriesResponseBody;
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
      body: GetDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryHeaders extends $tea.Model {
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

export class GetDentryRequest extends $tea.Model {
  option?: GetDentryRequestOption;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetDentryRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBody extends $tea.Model {
  dentry?: GetDentryResponseBodyDentry;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: GetDentryResponseBodyDentry,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDentryResponseBody;
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
      body: GetDentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsHeaders extends $tea.Model {
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

export class GetDentryThumbnailsRequest extends $tea.Model {
  dentryIds?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      dentryIds: 'dentryIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponseBody extends $tea.Model {
  resultItems?: GetDentryThumbnailsResponseBodyResultItems[];
  static names(): { [key: string]: string } {
    return {
      resultItems: 'resultItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resultItems: { 'type': 'array', 'itemType': GetDentryThumbnailsResponseBodyResultItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDentryThumbnailsResponseBody;
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
      body: GetDentryThumbnailsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoHeaders extends $tea.Model {
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

export class GetFileDownloadInfoRequest extends $tea.Model {
  option?: GetFileDownloadInfoRequestOption;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: GetFileDownloadInfoRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponseBody extends $tea.Model {
  headerSignatureInfo?: GetFileDownloadInfoResponseBodyHeaderSignatureInfo;
  protocol?: string;
  static names(): { [key: string]: string } {
    return {
      headerSignatureInfo: 'headerSignatureInfo',
      protocol: 'protocol',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headerSignatureInfo: GetFileDownloadInfoResponseBodyHeaderSignatureInfo,
      protocol: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFileDownloadInfoResponseBody;
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
      body: GetFileDownloadInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceHeaders extends $tea.Model {
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

export class GetSpaceRequest extends $tea.Model {
  openConversationId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBody extends $tea.Model {
  space?: GetSpaceResponseBodySpace;
  static names(): { [key: string]: string } {
    return {
      space: 'space',
    };
  }

  static types(): { [key: string]: any } {
    return {
      space: GetSpaceResponseBodySpace,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSpaceResponseBody;
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
      body: GetSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesHeaders extends $tea.Model {
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

export class ListAllDentriesRequest extends $tea.Model {
  option?: ListAllDentriesRequestOption;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      option: ListAllDentriesRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponseBody extends $tea.Model {
  dentries?: ListAllDentriesResponseBodyDentries[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      dentries: 'dentries',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentries: { 'type': 'array', 'itemType': ListAllDentriesResponseBodyDentries },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListAllDentriesResponseBody;
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
      body: ListAllDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesHeaders extends $tea.Model {
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

export class ListDentriesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  order?: string;
  orderBy?: string;
  parentId?: string;
  unionId?: string;
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
      orderBy: 'orderBy',
      parentId: 'parentId',
      unionId: 'unionId',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      order: 'string',
      orderBy: 'string',
      parentId: 'string',
      unionId: 'string',
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBody extends $tea.Model {
  dentries?: ListDentriesResponseBodyDentries[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      dentries: 'dentries',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentries: { 'type': 'array', 'itemType': ListDentriesResponseBodyDentries },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListDentriesResponseBody;
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
      body: ListDentriesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListExpiredHeaders extends $tea.Model {
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

export class ListExpiredRequest extends $tea.Model {
  openConversationId?: string;
  option?: ListExpiredRequestOption;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      option: 'option',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      option: ListExpiredRequestOption,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListExpiredResponseBody extends $tea.Model {
  files?: ListExpiredResponseBodyFiles[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      files: 'files',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      files: { 'type': 'array', 'itemType': ListExpiredResponseBodyFiles },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListExpiredResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListExpiredResponseBody;
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
      body: ListExpiredResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeEventHeaders extends $tea.Model {
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

export class SubscribeEventRequest extends $tea.Model {
  scope?: string;
  scopeId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      scope: 'scope',
      scopeId: 'scopeId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scope: 'string',
      scopeId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeEventResponseBody extends $tea.Model {
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

export class SubscribeEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SubscribeEventResponseBody;
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
      body: SubscribeEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeEventHeaders extends $tea.Model {
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

export class UnsubscribeEventRequest extends $tea.Model {
  scope?: string;
  scopeId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      scope: 'scope',
      scopeId: 'scopeId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scope: 'string',
      scopeId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeEventResponseBody extends $tea.Model {
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

export class UnsubscribeEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnsubscribeEventResponseBody;
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
      body: UnsubscribeEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesRequestOption extends $tea.Model {
  appIdsForAppProperties?: string[];
  static names(): { [key: string]: string } {
    return {
      appIdsForAppProperties: 'appIdsForAppProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appIdsForAppProperties: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBodyResultItemsDentryProperties extends $tea.Model {
  readOnly?: boolean;
  static names(): { [key: string]: string } {
    return {
      readOnly: 'readOnly',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readOnly: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBodyResultItemsDentryThumbnail extends $tea.Model {
  height?: number;
  url?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      url: 'url',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      url: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBodyResultItemsDentry extends $tea.Model {
  appProperties?: { [key: string]: ResultItemsDentryAppPropertiesValue[] };
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  partitionType?: string;
  path?: string;
  properties?: GetDentriesResponseBodyResultItemsDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  thumbnail?: GetDentriesResponseBodyResultItemsDentryThumbnail;
  type?: string;
  uuid?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      partitionType: 'partitionType',
      path: 'path',
      properties: 'properties',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      storageDriver: 'storageDriver',
      thumbnail: 'thumbnail',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': ResultItemsDentryAppPropertiesValue } },
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      partitionType: 'string',
      path: 'string',
      properties: GetDentriesResponseBodyResultItemsDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: GetDentriesResponseBodyResultItemsDentryThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentriesResponseBodyResultItems extends $tea.Model {
  dentry?: GetDentriesResponseBodyResultItemsDentry;
  dentryId?: string;
  errorCode?: string;
  spaceId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dentry: 'dentry',
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentry: GetDentriesResponseBodyResultItemsDentry,
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryRequestOption extends $tea.Model {
  appIdsForAppProperties?: string[];
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      appIdsForAppProperties: 'appIdsForAppProperties',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appIdsForAppProperties: { 'type': 'array', 'itemType': 'string' },
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBodyDentryProperties extends $tea.Model {
  readOnly?: boolean;
  static names(): { [key: string]: string } {
    return {
      readOnly: 'readOnly',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readOnly: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBodyDentryThumbnail extends $tea.Model {
  height?: number;
  url?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      url: 'url',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      url: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryResponseBodyDentry extends $tea.Model {
  appProperties?: { [key: string]: DentryAppPropertiesValue[] };
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  partitionType?: string;
  path?: string;
  properties?: GetDentryResponseBodyDentryProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  thumbnail?: GetDentryResponseBodyDentryThumbnail;
  type?: string;
  uuid?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      partitionType: 'partitionType',
      path: 'path',
      properties: 'properties',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      storageDriver: 'storageDriver',
      thumbnail: 'thumbnail',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentryAppPropertiesValue } },
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      partitionType: 'string',
      path: 'string',
      properties: GetDentryResponseBodyDentryProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: GetDentryResponseBodyDentryThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponseBodyResultItemsThumbnail extends $tea.Model {
  height?: number;
  url?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      url: 'url',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      url: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDentryThumbnailsResponseBodyResultItems extends $tea.Model {
  dentryId?: string;
  errorCode?: string;
  spaceId?: string;
  success?: boolean;
  thumbnail?: GetDentryThumbnailsResponseBodyResultItemsThumbnail;
  static names(): { [key: string]: string } {
    return {
      dentryId: 'dentryId',
      errorCode: 'errorCode',
      spaceId: 'spaceId',
      success: 'success',
      thumbnail: 'thumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dentryId: 'string',
      errorCode: 'string',
      spaceId: 'string',
      success: 'boolean',
      thumbnail: GetDentryThumbnailsResponseBodyResultItemsThumbnail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoRequestOption extends $tea.Model {
  preferIntranet?: boolean;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      preferIntranet: 'preferIntranet',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      preferIntranet: 'boolean',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileDownloadInfoResponseBodyHeaderSignatureInfo extends $tea.Model {
  expirationSeconds?: number;
  headers?: { [key: string]: string };
  internalResourceUrls?: string[];
  region?: string;
  resourceUrls?: string[];
  static names(): { [key: string]: string } {
    return {
      expirationSeconds: 'expirationSeconds',
      headers: 'headers',
      internalResourceUrls: 'internalResourceUrls',
      region: 'region',
      resourceUrls: 'resourceUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationSeconds: 'number',
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      internalResourceUrls: { 'type': 'array', 'itemType': 'string' },
      region: 'string',
      resourceUrls: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceResponseBodySpace extends $tea.Model {
  corpId?: string;
  createTime?: string;
  modifiedTime?: string;
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createTime: 'createTime',
      modifiedTime: 'modifiedTime',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createTime: 'string',
      modifiedTime: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesRequestOption extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  order?: string;
  withThumbnail?: boolean;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      order: 'order',
      withThumbnail: 'withThumbnail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      order: 'string',
      withThumbnail: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponseBodyDentriesProperties extends $tea.Model {
  readOnly?: boolean;
  static names(): { [key: string]: string } {
    return {
      readOnly: 'readOnly',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readOnly: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponseBodyDentriesThumbnail extends $tea.Model {
  height?: number;
  url?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      url: 'url',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      url: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllDentriesResponseBodyDentries extends $tea.Model {
  appProperties?: { [key: string]: DentriesAppPropertiesValue[] };
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  partitionType?: string;
  path?: string;
  properties?: ListAllDentriesResponseBodyDentriesProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  thumbnail?: ListAllDentriesResponseBodyDentriesThumbnail;
  type?: string;
  uuid?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      partitionType: 'partitionType',
      path: 'path',
      properties: 'properties',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      storageDriver: 'storageDriver',
      thumbnail: 'thumbnail',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentriesAppPropertiesValue } },
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      partitionType: 'string',
      path: 'string',
      properties: ListAllDentriesResponseBodyDentriesProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: ListAllDentriesResponseBodyDentriesThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBodyDentriesProperties extends $tea.Model {
  readOnly?: boolean;
  static names(): { [key: string]: string } {
    return {
      readOnly: 'readOnly',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readOnly: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBodyDentriesThumbnail extends $tea.Model {
  height?: number;
  url?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      height: 'height',
      url: 'url',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      height: 'number',
      url: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDentriesResponseBodyDentries extends $tea.Model {
  appProperties?: { [key: string]: DentriesAppPropertiesValue[] };
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  partitionType?: string;
  path?: string;
  properties?: ListDentriesResponseBodyDentriesProperties;
  size?: number;
  spaceId?: string;
  status?: string;
  storageDriver?: string;
  thumbnail?: ListDentriesResponseBodyDentriesThumbnail;
  type?: string;
  uuid?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      appProperties: 'appProperties',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      partitionType: 'partitionType',
      path: 'path',
      properties: 'properties',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      storageDriver: 'storageDriver',
      thumbnail: 'thumbnail',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appProperties: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': DentriesAppPropertiesValue } },
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      partitionType: 'string',
      path: 'string',
      properties: ListDentriesResponseBodyDentriesProperties,
      size: 'number',
      spaceId: 'string',
      status: 'string',
      storageDriver: 'string',
      thumbnail: ListDentriesResponseBodyDentriesThumbnail,
      type: 'string',
      uuid: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListExpiredRequestOption extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListExpiredResponseBodyFiles extends $tea.Model {
  conversationId?: string;
  createTime?: string;
  creatorId?: string;
  extension?: string;
  id?: string;
  modifiedTime?: string;
  modifierId?: string;
  name?: string;
  parentId?: string;
  path?: string;
  size?: number;
  spaceId?: string;
  status?: string;
  type?: string;
  uuid?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      createTime: 'createTime',
      creatorId: 'creatorId',
      extension: 'extension',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      name: 'name',
      parentId: 'parentId',
      path: 'path',
      size: 'size',
      spaceId: 'spaceId',
      status: 'status',
      type: 'type',
      uuid: 'uuid',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      createTime: 'string',
      creatorId: 'string',
      extension: 'string',
      id: 'string',
      modifiedTime: 'string',
      modifierId: 'string',
      name: 'string',
      parentId: 'string',
      path: 'string',
      size: 'number',
      spaceId: 'string',
      status: 'string',
      type: 'string',
      uuid: 'string',
      version: 'number',
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


  async getDentriesWithOptions(spaceId: string, request: GetDentriesRequest, headers: GetDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "GetDentries",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/spaces/${spaceId}/dentries/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentriesResponse>(await this.execute(params, req, runtime), new GetDentriesResponse({}));
  }

  async getDentries(spaceId: string, request: GetDentriesRequest): Promise<GetDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentriesHeaders({ });
    return await this.getDentriesWithOptions(spaceId, request, headers, runtime);
  }

  async getDentryWithOptions(spaceId: string, dentryId: string, request: GetDentryRequest, headers: GetDentryHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "GetDentry",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/spaces/${spaceId}/dentries/${dentryId}/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentryResponse>(await this.execute(params, req, runtime), new GetDentryResponse({}));
  }

  async getDentry(spaceId: string, dentryId: string, request: GetDentryRequest): Promise<GetDentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryHeaders({ });
    return await this.getDentryWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async getDentryThumbnailsWithOptions(spaceId: string, request: GetDentryThumbnailsRequest, headers: GetDentryThumbnailsHeaders, runtime: $Util.RuntimeOptions): Promise<GetDentryThumbnailsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dentryIds)) {
      body["dentryIds"] = request.dentryIds;
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
      action: "GetDentryThumbnails",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/spaces/${spaceId}/thumbnails/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDentryThumbnailsResponse>(await this.execute(params, req, runtime), new GetDentryThumbnailsResponse({}));
  }

  async getDentryThumbnails(spaceId: string, request: GetDentryThumbnailsRequest): Promise<GetDentryThumbnailsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDentryThumbnailsHeaders({ });
    return await this.getDentryThumbnailsWithOptions(spaceId, request, headers, runtime);
  }

  async getFileDownloadInfoWithOptions(spaceId: string, dentryId: string, request: GetFileDownloadInfoRequest, headers: GetFileDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileDownloadInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "GetFileDownloadInfo",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/spaces/${spaceId}/dentries/${dentryId}/downloadInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFileDownloadInfoResponse>(await this.execute(params, req, runtime), new GetFileDownloadInfoResponse({}));
  }

  async getFileDownloadInfo(spaceId: string, dentryId: string, request: GetFileDownloadInfoRequest): Promise<GetFileDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileDownloadInfoHeaders({ });
    return await this.getFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
  }

  async getSpaceWithOptions(request: GetSpaceRequest, headers: GetSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetSpace",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/conversations/spaces/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceResponse>(await this.execute(params, req, runtime), new GetSpaceResponse({}));
  }

  async getSpace(request: GetSpaceRequest): Promise<GetSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceHeaders({ });
    return await this.getSpaceWithOptions(request, headers, runtime);
  }

  async listAllDentriesWithOptions(spaceId: string, request: ListAllDentriesRequest, headers: ListAllDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<ListAllDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "ListAllDentries",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/spaces/${spaceId}/dentries/listAll`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAllDentriesResponse>(await this.execute(params, req, runtime), new ListAllDentriesResponse({}));
  }

  async listAllDentries(spaceId: string, request: ListAllDentriesRequest): Promise<ListAllDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAllDentriesHeaders({ });
    return await this.listAllDentriesWithOptions(spaceId, request, headers, runtime);
  }

  async listDentriesWithOptions(spaceId: string, request: ListDentriesRequest, headers: ListDentriesHeaders, runtime: $Util.RuntimeOptions): Promise<ListDentriesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.order)) {
      query["order"] = request.order;
    }

    if (!Util.isUnset(request.orderBy)) {
      query["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.parentId)) {
      query["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.withThumbnail)) {
      query["withThumbnail"] = request.withThumbnail;
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
      action: "ListDentries",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/spaces/${spaceId}/dentries`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListDentriesResponse>(await this.execute(params, req, runtime), new ListDentriesResponse({}));
  }

  async listDentries(spaceId: string, request: ListDentriesRequest): Promise<ListDentriesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDentriesHeaders({ });
    return await this.listDentriesWithOptions(spaceId, request, headers, runtime);
  }

  async listExpiredWithOptions(request: ListExpiredRequest, headers: ListExpiredHeaders, runtime: $Util.RuntimeOptions): Promise<ListExpiredResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.option)) {
      body["option"] = request.option;
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
      action: "ListExpired",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/conversations/expiredFileLists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListExpiredResponse>(await this.execute(params, req, runtime), new ListExpiredResponse({}));
  }

  async listExpired(request: ListExpiredRequest): Promise<ListExpiredResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListExpiredHeaders({ });
    return await this.listExpiredWithOptions(request, headers, runtime);
  }

  async subscribeEventWithOptions(request: SubscribeEventRequest, headers: SubscribeEventHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeEventResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.scopeId)) {
      body["scopeId"] = request.scopeId;
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
      action: "SubscribeEvent",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/events/subscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SubscribeEventResponse>(await this.execute(params, req, runtime), new SubscribeEventResponse({}));
  }

  async subscribeEvent(request: SubscribeEventRequest): Promise<SubscribeEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeEventHeaders({ });
    return await this.subscribeEventWithOptions(request, headers, runtime);
  }

  async unsubscribeEventWithOptions(request: UnsubscribeEventRequest, headers: UnsubscribeEventHeaders, runtime: $Util.RuntimeOptions): Promise<UnsubscribeEventResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.scopeId)) {
      body["scopeId"] = request.scopeId;
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
      action: "UnsubscribeEvent",
      version: "snsStorage_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/snsStorage/events/unsubscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnsubscribeEventResponse>(await this.execute(params, req, runtime), new UnsubscribeEventResponse({}));
  }

  async unsubscribeEvent(request: UnsubscribeEventRequest): Promise<UnsubscribeEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsubscribeEventHeaders({ });
    return await this.unsubscribeEventWithOptions(request, headers, runtime);
  }

}
